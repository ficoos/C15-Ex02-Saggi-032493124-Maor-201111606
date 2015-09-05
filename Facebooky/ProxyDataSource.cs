using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace Facebooky
{
	class ProxyDataSource : Component, IBindingListView
	{
		private List<Post> m_FilteredPosts;
		private User m_User;
		public bool ProxyEnabled { get; set; }
		private ICollection<PostFilterGroup> m_PostFilterGroups;
		private readonly BindingSource r_OriginalBindingSource;

		public ProxyDataSource(User i_User, ICollection<PostFilterGroup> i_FilterGroup)
		{
			ProxyEnabled = true;
			this.r_OriginalBindingSource = new BindingSource(i_User, "NewsFeed");
			m_User = i_User;
			m_PostFilterGroups = i_FilterGroup;
			m_FilteredPosts = new List<Post>();
			this.filterPosts();
			this.r_OriginalBindingSource.ListChanged += this.DoWhenListChange;
			//To Saggi- I get an error about syncroot. Do you think I should forward it to the syncroot of the original databinding? or to creat a new one? No one references it.
		}
		public void DoWhenListChange(object i_Sender, EventArgs i_Args)
		{
			this.filterPosts();
		}
		private void filterPosts()
		{
			this.m_FilteredPosts = this.m_User.NewsFeed.Where(i_Post => this.getPostPriority(i_Post) != ePostPriority.Hidden).ToList();
			this.m_FilteredPosts.Sort(
			(i_Post, i_OtherPost) => this.getPostPriority(i_OtherPost).CompareTo(this.getPostPriority(i_Post)));
		}
		private ePostPriority getPostPriority(Post i_Post)
		{
			ePostPriority postPriority = ePostPriority.None;
			foreach (PostFilterGroup filterGroup in m_PostFilterGroups)
			{
				if (filterGroup.IsMatch(i_Post))
				{
					postPriority = (ePostPriority)Math.Min((int)filterGroup.PostPriority, (int)postPriority);
				}

				if (postPriority == ePostPriority.Hidden)
				{
					break;
				}
			}

			return postPriority;
		}

		public void UpdatePostFilterGroups(ICollection<PostFilterGroup> i_NewGroup)
		{
			if (i_NewGroup != null)
			{
				m_PostFilterGroups = i_NewGroup;
				this.filterPosts();
			}
		}
		public IEnumerator GetEnumerator()
		{
			return ProxyEnabled ? m_FilteredPosts.GetEnumerator() : this.r_OriginalBindingSource.GetEnumerator();
		} //To Saggi- how can I make sure i wont return a null? Should I use an object that memamesh IEnumerator and assign the value to it first, and then return the object?

		public int Count
		{
			get
			{
				if (!ProxyEnabled)
				{
					return this.r_OriginalBindingSource.Count;
				}
				else
				{
					return this.r_OriginalBindingSource.Count;
				}
			}

		}



		public int Add(object i_Value)
		{
			if (!ProxyEnabled)
			{
				return this.r_OriginalBindingSource.Add(i_Value);
			}
			else
			{
				this.r_OriginalBindingSource.Add(i_Value as Post);
				return m_FilteredPosts.IndexOf(i_Value as Post);
			}

		}



		public void Clear()
		{
			this.r_OriginalBindingSource.Clear();
		}

		public int IndexOf(object i_Value)
		{
			return this.r_OriginalBindingSource.IndexOf(i_Value);
		}
		public object this[int i_Index]
		{
			get
			{
				return this.r_OriginalBindingSource[i_Index];
			}
			set
			{
				this.r_OriginalBindingSource[i_Index] = value;
			}
		}




		/// <summary>
		/// To Saggi- The functions bellow are not referenced anywhere. For now point ignore the style of the bellow
		/// </summary>


		public object SyncRoot { get; private set; }

		public bool IsSynchronized { get; private set; }
		public bool Contains(object i_Value)
		{
			throw new NotImplementedException();
		}
		public void Insert(int i_Index, object i_Value)
		{
			throw new NotImplementedException();
		}

		public void Remove(object i_Value)
		{
			throw new NotImplementedException();
		}
		public void CopyTo(Array array, int index)
		{
			throw new NotImplementedException();
		}
		public void RemoveAt(int i_Index)
		{
			throw new NotImplementedException();
		}

		public bool IsReadOnly { get; private set; }

		public bool IsFixedSize { get; private set; }

		public object AddNew()
		{
			throw new NotImplementedException();
		}

		public void AddIndex(PropertyDescriptor i_Property)
		{
			throw new NotImplementedException();
		}

		public void ApplySort(PropertyDescriptor i_Property, ListSortDirection i_Direction)
		{
			throw new NotImplementedException();
		}

		public int Find(PropertyDescriptor property, object key)
		{
			throw new NotImplementedException();
		}

		public void RemoveIndex(PropertyDescriptor property)
		{
			throw new NotImplementedException();
		}

		public void RemoveSort()
		{
			throw new NotImplementedException();
		}

		public bool AllowNew { get; private set; }

		public bool AllowEdit { get; private set; }

		public bool AllowRemove { get; private set; }

		public bool SupportsChangeNotification { get; private set; }

		public bool SupportsSearching { get; private set; }

		public bool SupportsSorting { get; private set; }

		public bool IsSorted { get; private set; }

		public PropertyDescriptor SortProperty { get; private set; }

		public ListSortDirection SortDirection { get; private set; }

		public event ListChangedEventHandler ListChanged;

		public void ApplySort(ListSortDescriptionCollection i_Sorts)
		{
			throw new NotImplementedException();
		}

		public void RemoveFilter()
		{
			throw new NotImplementedException();
		}

		public string Filter { get; set; }

		public ListSortDescriptionCollection SortDescriptions { get; private set; }

		public bool SupportsAdvancedSorting { get; private set; }

		public bool SupportsFiltering { get; private set; }

	}
}

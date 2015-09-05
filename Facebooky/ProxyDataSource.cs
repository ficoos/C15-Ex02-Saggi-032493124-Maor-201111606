using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using FacebookWrapper.ObjectModel;

namespace Facebooky
{
	class ProxyDataSource : Component, IBindingListView
	{
		private List<Post> r_FilteredPosts;
		private User m_User;
		public bool ProxyEnabled { get; set; }

		private readonly ICollection<PostFilterGroup> r_PostFilterGroups;
		

		private BindingSource m_OriginalBindingSource;
		public ProxyDataSource(User i_User, ICollection<PostFilterGroup> i_FilterGroup)
		{
			ProxyEnabled = true;
			m_OriginalBindingSource = new BindingSource(i_User,"NewsFeed");
			m_User = i_User;
			r_PostFilterGroups = i_FilterGroup;
			r_FilteredPosts = new List<Post>();
	//		r_FilteredPosts.Add(new Post());
			this.filterPosts();
			m_OriginalBindingSource.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.DoWhenListChange); 

		}
		

		public void DoWhenListChange(object i_Sender, EventArgs i_Args)
		{
			this.filterPosts();
		}
		private void filterPosts()
		{
			this.r_FilteredPosts = this.m_User.NewsFeed.Where(i_Post => this.getPostPriority(i_Post) != ePostPriority.Hidden).ToList();
			this.r_FilteredPosts.Sort(
			(i_Post, i_OtherPost) => this.getPostPriority(i_OtherPost).CompareTo(this.getPostPriority(i_Post)));
			
//			r_FilteredPosts.Add(new Post());
		}

		private ePostPriority getPostPriority(Post i_Post)
		{
			ePostPriority postPriority = ePostPriority.None;
			foreach (PostFilterGroup filterGroup in r_PostFilterGroups)
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
		public IEnumerator GetEnumerator()
		{
			return ProxyEnabled ? r_FilteredPosts.GetEnumerator():m_OriginalBindingSource.GetEnumerator();		
		}

		public void CopyTo(Array array, int index)
		{
			throw new NotImplementedException();
		}

		public int Count
		{
			get
		{
			if (!ProxyEnabled)
			{
				return m_OriginalBindingSource.Count;
			}
			else
			{
				return m_OriginalBindingSource.Count;
			}	
		}
			private set
			{
				throw new NotImplementedException();  // WHAT IS THIS?!
			}
		}

		public object SyncRoot { get; private set; }

		public bool IsSynchronized { get; private set; }

		public int Add(object i_Value)
		{
			if (!ProxyEnabled)
			{
				return m_OriginalBindingSource.Add(i_Value);
			}
			else
			{
				m_OriginalBindingSource.Add(i_Value as Post);
				return r_FilteredPosts.IndexOf(i_Value as Post);
			}
			
		}

		public bool Contains(object i_Value)
		{
			throw new NotImplementedException();
		}

		public void Clear()
		{
			m_OriginalBindingSource.Clear();
		}

		public int IndexOf(object i_Value)
		{
			return m_OriginalBindingSource.IndexOf(i_Value);
		}

		public void Insert(int i_Index, object i_Value)
		{
			throw new NotImplementedException();
		}

		public void Remove(object i_Value)
		{
			throw new NotImplementedException();
		}

		public void RemoveAt(int i_Index)
		{
			throw new NotImplementedException();
		}

		public object this[int i_Index]
		{
			get
			{
				return m_OriginalBindingSource[i_Index];
			}
			set
			{
				m_OriginalBindingSource[i_Index] = value;
			}
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

		public void ApplySort(ListSortDescriptionCollection sorts)
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

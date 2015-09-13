using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace Facebooky
{
	public class ProxyDataSource : Component, IBindingListView
	{
		private readonly BindingSource r_OriginalBindingSource;

		private List<Post> m_FilteringEnabled;

		private User m_User;

		public bool ProxyEnabled { get; set; }

		private ICollection<PostFilterGroup> m_PostFilterGroups;

		public ProxyDataSource(User i_User, ICollection<PostFilterGroup> i_FilterGroup)
		{
			ProxyEnabled = true;
			SyncRoot = i_User;
			this.r_OriginalBindingSource = new BindingSource(i_User, "NewsFeed");
			m_User = i_User;
			m_PostFilterGroups = i_FilterGroup;
			this.m_FilteringEnabled = new List<Post>();
			this.filterPosts();
			this.r_OriginalBindingSource.ListChanged += this.DoWhenListChange;
		}

		public void DoWhenListChange(object i_Sender, EventArgs i_Args)
		{
			this.filterPosts();
		}

		private void filterPosts()
		{
			this.m_FilteringEnabled = this.m_User.NewsFeed.Where(i_Post => this.calculatePostPriority(i_Post) != ePostPriority.Hidden).ToList();
			this.m_FilteringEnabled.Sort(
			(i_Post, i_OtherPost) => this.calculatePostPriority(i_OtherPost).CompareTo(this.calculatePostPriority(i_Post)));
		}

		private ePostPriority calculatePostPriority(Post i_Post)
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
			IEnumerator enumerator = ProxyEnabled ? this.m_FilteringEnabled.GetEnumerator() : this.r_OriginalBindingSource.GetEnumerator();

			// Spec requires that we *always* return an enumerator.
			return enumerator ?? (new object[0]).GetEnumerator();
		}

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
					return this.m_FilteringEnabled.Count;
				}
			}
		}

		public int Add(object i_Value)
		{
			int index;
			if (!ProxyEnabled)
			{
				index = this.r_OriginalBindingSource.Add(i_Value);
			}
			else
			{
				this.r_OriginalBindingSource.Add(i_Value as Post);
				index = this.m_FilteringEnabled.IndexOf(i_Value as Post);
			}

			return index;
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

		public object SyncRoot { get; private set; }

		public bool IsSynchronized
		{
			get
			{
				return r_OriginalBindingSource.IsSynchronized;
			}
		}

		public bool Contains(object i_Value)
		{
			return r_OriginalBindingSource.Contains(i_Value);
		}

		public void Insert(int i_Index, object i_Value)
		{
			r_OriginalBindingSource.Insert(i_Index, i_Value);
		}

		public void Remove(object i_Value)
		{
			r_OriginalBindingSource.Remove(i_Value);
		}

		public void CopyTo(Array i_Array, int i_Index)
		{
			r_OriginalBindingSource.CopyTo(i_Array, i_Index);
		}

		public void RemoveAt(int i_Index)
		{
			r_OriginalBindingSource.RemoveAt(i_Index);
		}

		public bool IsReadOnly
		{
			get
			{
				return true;
			}
		}

		public bool IsFixedSize
		{
			get
			{
				return false;
			}
		}

		public object AddNew()
		{
			return r_OriginalBindingSource.AddNew();
		}

		public void AddIndex(PropertyDescriptor i_Property)
		{
			throw new NotImplementedException();
		}

		public void ApplySort(PropertyDescriptor i_Property, ListSortDirection i_Direction)
		{
			throw new NotImplementedException();
		}

		public int Find(PropertyDescriptor i_Property, object i_Key)
		{
			throw new NotImplementedException();
		}

		public void RemoveIndex(PropertyDescriptor i_Property)
		{
			throw new NotImplementedException();
		}

		public void RemoveSort()
		{
			throw new NotImplementedException();
		}

		public bool AllowNew
		{
			get
			{
				return false;
			}
		}

		public bool AllowEdit
		{
			get
			{
				return false;
			}
		}

		public bool AllowRemove
		{
			get
			{
				return false;
			}
		}

		public bool SupportsChangeNotification
		{
			get
			{
				return r_OriginalBindingSource.SupportsChangeNotification;
			}
		}

		public bool SupportsSearching
		{
			get
			{
				return r_OriginalBindingSource.SupportsSearching;
			}
		}

		public bool SupportsSorting
		{
			get
			{
				return false;
			}
		}

		public bool IsSorted
		{
			get
			{
				return false;
			}
		}

		public PropertyDescriptor SortProperty
		{
			get
			{
				return null;
			}
		}

		public ListSortDirection SortDirection
		{
			get
			{
				return ListSortDirection.Ascending;
			}
		}

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

		public ListSortDescriptionCollection SortDescriptions
		{
			get
			{
				return null;
			}
		}

		public bool SupportsAdvancedSorting
		{
			get
			{
				return false;
			}
		}

		public bool SupportsFiltering
		{
			get
			{
				return false;
			}
		}
	}
}

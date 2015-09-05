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
		private List<Post> m_FilteredPosts;
		public bool ProxyEnabled { get; set; }
		private BindingSource m_OriginalBindingSource;

		public ProxyDataSource(User i_User, ICollection<PostFilterGroup> i_FilterGroup)
		{
			m_OriginalBindingSource = new BindingSource(i_User,"NewsFeed");
			

		}

		public IEnumerator GetEnumerator()
		{
			return m_OriginalBindingSource.GetEnumerator();
		}

		public void CopyTo(Array array, int index)
		{
			throw new NotImplementedException();
		}

		public int Count
		{
			get
		{
			return m_OriginalBindingSource.Count;
		}
			private set
			{
				throw new NotImplementedException();  // WHAT IS THIS?!
			}
		}

		public object SyncRoot { get; private set; }

		public bool IsSynchronized { get; private set; }

		public int Add(object value)
		{
			return m_OriginalBindingSource.Add(value);
		}

		public bool Contains(object value)
		{
			throw new NotImplementedException();
		}

		public void Clear()
		{
			m_OriginalBindingSource.Clear();
		}

		public int IndexOf(object value)
		{
			return m_OriginalBindingSource.IndexOf(value);
		}

		public void Insert(int index, object value)
		{
			throw new NotImplementedException();
		}

		public void Remove(object value)
		{
			throw new NotImplementedException();
		}

		public void RemoveAt(int index)
		{
			throw new NotImplementedException();
		}

		public object this[int index]
		{
			get
			{
				return m_OriginalBindingSource[index];
			}
			set
			{
				m_OriginalBindingSource[index] = value;
			}
		}

		public bool IsReadOnly { get; private set; }

		public bool IsFixedSize { get; private set; }

		public object AddNew()
		{
			throw new NotImplementedException();
		}

		public void AddIndex(PropertyDescriptor property)
		{
			throw new NotImplementedException();
		}

		public void ApplySort(PropertyDescriptor property, ListSortDirection direction)
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

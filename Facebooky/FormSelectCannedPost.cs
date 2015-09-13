﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

namespace Facebooky
{
	public partial class FormSelectCannedPost : Form
    {      
        public CannedPost SelectedPost { get; private set; }

        public string CannedPostsDirectoryPath { get; set; }

        public FormSelectCannedPost()
        {
            InitializeComponent();
	        SelectedPost = null;
        }

        protected override void OnShown(EventArgs i_Args)
        {
            refreshPostList();
            base.OnShown(i_Args);
        }

        private void refreshPostList()
        {
	        IEnumerable<string> allUserFiles =
		        Directory.GetFiles(this.CannedPostsDirectoryPath)
			        .Where(i_FileName => i_FileName.ToLower().EndsWith(".post.xml"))
			        .Select(Path.GetFileName);

			Dictionary<string, List<CannedPost>> categoriesAndTemplates = new Dictionary<string, List<CannedPost>>();
            foreach(string fileName in allUserFiles)
            {
                CannedPost post = this.getCannedPostByPostNameInForm(fileName);

                if (post != null)
                {
                    foreach (string category in post.Categories)
                    {
                        if(!categoriesAndTemplates.ContainsKey(category))
                        {
                            categoriesAndTemplates.Add(category, new List<CannedPost>());
                            categoriesAndTemplates[category].Add(post);
                        }
                        else
                        {
                            categoriesAndTemplates[category].Add(post);
                        }
                    }
                }
            }

			treeViewCategories.Nodes.Clear();
            foreach(string category in categoriesAndTemplates.Keys)
            {
                TreeNode node = new TreeNode(category);
                foreach (CannedPost post in categoriesAndTemplates[category])
                {
                    TreeNode postNode = node.Nodes.Add(post.Name);
	                postNode.Tag = post;
                }

				treeViewCategories.Nodes.Add(node);
            }
        }

        private void buttonCancel_Click(object i_Sender, EventArgs i_Args)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void buttonSelect_Click(object i_Sender, EventArgs i_Args)
        {
	        if (treeViewCategories.SelectedNode != null)
	        {
		        SelectedPost = treeViewCategories.SelectedNode.Tag as CannedPost;
				if (SelectedPost != null)
		        {
					this.DialogResult = DialogResult.OK;
			        this.Close();
		        }
	        }
        }

        private void buttonCreateNew_Click(object i_Sender, EventArgs i_Args)
        {
            showEditPost(null);
        }

        private void buttonEdit_Click(object i_Sender, EventArgs i_Args)
        {
	        if (this.treeViewCategories.SelectedNode != null)
	        {
		        CannedPost post = this.treeViewCategories.SelectedNode.Tag as CannedPost;

		        if (post != null)
		        {
			        this.showEditPost(post);
		        }
	        }
        }

        private void showEditPost(CannedPost i_Post)
        {
            FormEditCannedPost editForm = new FormEditCannedPost();
            editForm.CannedPost = i_Post;
            editForm.ShowDialog();
            if (editForm.DialogResult == DialogResult.OK)
            {
                XmlSerializer serializer = new XmlSerializer(typeof(CannedPost));
                using (TextWriter writer = new StreamWriter(Path.Combine(this.CannedPostsDirectoryPath, editForm.CannedPost.Name + ".post.xml")))
                {
                    serializer.Serialize(writer, editForm.CannedPost);
                }
            }

            refreshPostList();
        }

        private CannedPost getCannedPostByPostNameInForm(string i_PostName)
        {
            CannedPost post = null;
            if (i_PostName != null)
            {
                string selectedPostPath = Path.Combine(CannedPostsDirectoryPath, i_PostName);
                XmlSerializer serializer = new XmlSerializer(typeof(CannedPost));

                using (TextReader reader = new StreamReader(selectedPostPath))
                {
                    post = serializer.Deserialize(reader) as CannedPost;
                }
            }

	        return post;
        }
    }
}

﻿using System;
using System.Windows.Controls;
using System.Windows.Input;
using GitHub.InlineReviews.ViewModels;

namespace GitHub.InlineReviews.Views
{
    public partial class CommentView : UserControl
    {
        public CommentView()
        {
            InitializeComponent();
        }

        private void ReplyPlaceholder_GotFocus(object sender, System.Windows.RoutedEventArgs e)
        {
            var command = ((ICommentViewModel)DataContext)?.BeginEdit;

            if (command?.CanExecute(null) == true)
            {
                command.Execute(null);
            }
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;

// The Content Dialog item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace ReactNative.DevSupport
{
    /// <summary>
    /// The content dialog for red box exception display.
    /// </summary>
    sealed partial class RedBoxDialog : Window, INotifyPropertyChanged
    {
        private readonly Action _onClick;

        private string _message;
        private IList<IStackFrame> _stackTrace;

        /// <summary>
        /// Instantiates the <see cref="RedBoxDialog"/>.
        /// </summary>
        /// <param name="onClick">
        /// Action to take when primary button is clicked.
        /// </param>
        public RedBoxDialog(Action onClick)
        {
            InitializeComponent();

            _onClick = onClick;
        }

        /// <summary>
        /// Notifies the event subscriber when properties change.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// The error cookie.
        /// </summary>
        public int ErrorCookie
        {
            get;
            set;
        }

        /// <summary>
        /// The exception message.
        /// </summary>
        public string Message
        {
            get
            {
                return _message;
            }
            set
            {
                _message = value;
                OnNotifyPropertyChanged();
            }
        }

        /// <summary>
        /// The stack trace.
        /// </summary>
        public IList<IStackFrame> StackTrace
        {
            get
            {
                return _stackTrace;
            }
            set
            {
                _stackTrace = value;
                OnNotifyPropertyChanged();
            }
        }

        private void OnNotifyPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
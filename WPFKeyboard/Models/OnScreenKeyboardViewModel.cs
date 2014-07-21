﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using WindowsInput.Native;

namespace WPFKeyboard.Models
{
    public class OnScreenKeyboardViewModel
    {
        readonly ObservableCollection<OnScreenKeyboardSectionViewModel> _sections = new ObservableCollection<OnScreenKeyboardSectionViewModel>();

        public ObservableCollection<OnScreenKeyboardSectionViewModel> Sections
        {
            get { return _sections; }
        }

        public IModiferStateManager ModiferStateManager { get; protected set; }

        public bool IsStickyKeyHeld { get; set; }

        public VirtualKeyCode StickyVirtualKeyCode { get; set; }
    }
}

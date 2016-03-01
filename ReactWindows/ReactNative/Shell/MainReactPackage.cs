﻿using ReactNative.Bridge;
using ReactNative.Modules.AppState;
using ReactNative.Modules.Core;
using ReactNative.Modules.Toast;
using ReactNative.Modules.WebSocket;
using ReactNative.UIManager;
using ReactNative.Views.Image;
using ReactNative.Views.Scroll;
using ReactNative.Views.Switch;
using ReactNative.Views.Text;
using ReactNative.Views.TextInput;
using ReactNative.Views.View;
using System;
using System.Collections.Generic;

namespace ReactNative.Shell
{
    /// <summary>
    /// Package defining basic modules and view managers.
    /// </summary>
    public class MainReactPackage : IReactPackage
    {
        /// <summary>
        /// Creates the list of native modules to register with the react
        /// instance. 
        /// </summary>
        /// <param name="reactContext">The react application context.</param>
        /// <returns>The list of native modules.</returns>
        public IReadOnlyList<INativeModule> CreateNativeModules(ReactContext reactContext)
        {
            return new List<INativeModule>
            {
                new AppStateModule(reactContext),
                //new AsyncStorageModule(reactContext),
                //new CameraRollManager(reactContext),
                //new ClipboardModule(reactContext),
                //new DialogModule(reactContext),
                //new LocationModule(reactContext),
                //new NetworkingModule(reactContext),
                //new NetInfoModule(reactContext),
                new ToastModule(reactContext),
                new WebSocketModule(reactContext),
            };
        }

        /// <summary>
        /// Creates the list of JavaScript modules to register with the 
        /// react instance. 
        /// </summary>
        /// <returns>The list of JavaScript modules.</returns>
        public IReadOnlyList<Type> CreateJavaScriptModulesConfig()
        {
            return new List<Type>(0);
        }

        /// <summary>
        /// Creates the list of view managers that should be registered with
        /// the <see cref="UIManagerModule"/>.
        /// </summary>
        /// <param name="reactContext">The react application context.</param>
        /// <returns>The list of view managers.</returns>
        public IReadOnlyList<IViewManager> CreateViewManagers(
            ReactContext reactContext)
        {
            return new List<IViewManager>
            {
                //new ReactDrawerLayoutManager(),
                //new ReactHorizontalScrollViewManager(),
                new ReactImageManager(),
                new ReactVirtualImageManager(),
                //new ReactProgressBarViewManager(),
                new ReactRawTextManager(),
                //new RecyclerViewBackedScrollViewManager(),
                new ReactScrollViewManager(),
                new ReactSwitchManager(),
                new ReactTextInputManager(),
                new ReactMultilineTextInputManager(),
                new ReactTextViewManager(),
                //new ReactToolbarManager(),
                new ReactViewManager(),
                //new ReactViewPagerManager(),
                //new ReactTextInlineImageViewManager(),
                new ReactVirtualTextViewManager(),
                //new SwipeRefreshLayoutManager(),
                //new ReactWebViewManager(),
            };
        }
    }
}
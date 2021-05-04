// ts2fable 0.0.0
module rec ReactNative

#nowarn "3390" // disable warnings for invalid XML comments
#nowarn "0044" // disable warnings for `Obsolete` usage

open System
open Fable.Core
open Fable.Core.JS

type Array<'T> = System.Collections.Generic.IList<'T>
type Error = System.Exception
type ReadonlyArray<'T> = System.Collections.Generic.IReadOnlyList<'T>

module PropTypes = Prop_types
/// <summary>
/// <c>AppRegistry</c> is the JS entry point to running all React Native apps.  App
/// root components should register themselves with
/// <c>AppRegistry.registerComponent</c>, then the native system can load the bundle
/// for the app and then actually run the app when it's ready by invoking
/// <c>AppRegistry.runApplication</c>.
/// 
/// To "stop" an application when a view should be destroyed, call
/// <c>AppRegistry.unmountApplicationComponentAtRootTag</c> with the tag that was
/// pass into <c>runApplication</c>. These should always be used as a pair.
/// 
/// <c>AppRegistry</c> should be <c>require</c>d early in the <c>require</c> sequence to make
/// sure the JS execution environment is setup before other modules are
/// <c>require</c>d.
/// </summary>
let [<Import("AppRegistry","react-native")>] appRegistry: AppRegistry.IExports = jsNative
let [<Import("StyleSheet","react-native")>] styleSheet: StyleSheet.IExports = jsNative
let [<Import("Animated","react-native")>] animated: Animated.IExports = jsNative
let [<Import("addons","react-native")>] addons: Addons.IExports = jsNative
let [<Import("TextBase","react-native")>] TextBase: obj = jsNative
let [<Import("TextInputBase","react-native")>] TextInputBase: obj = jsNative
let [<Import("ToolbarAndroidBase","react-native")>] ToolbarAndroidBase: obj = jsNative
let [<Import("ViewBase","react-native")>] ViewBase: obj = jsNative
let [<Import("ViewPagerAndroidBase","react-native")>] ViewPagerAndroidBase: obj = jsNative
let [<Import("KeyboardAvoidingViewBase","react-native")>] KeyboardAvoidingViewBase: obj = jsNative
let [<Import("SafeAreaViewBase","react-native")>] SafeAreaViewBase: obj = jsNative
let [<Import("SegmentedControlIOSBase","react-native")>] SegmentedControlIOSBase: obj = jsNative
let [<Import("ActivityIndicatorBase","react-native")>] ActivityIndicatorBase: obj = jsNative
let [<Import("DatePickerIOSBase","react-native")>] DatePickerIOSBase: obj = jsNative
let [<Import("DrawerLayoutAndroidBase","react-native")>] DrawerLayoutAndroidBase: obj = jsNative
let [<Import("PickerIOSBase","react-native")>] PickerIOSBase: obj = jsNative
let [<Import("ProgressBarAndroidBase","react-native")>] ProgressBarAndroidBase: obj = jsNative
let [<Import("ProgressViewIOSBase","react-native")>] ProgressViewIOSBase: obj = jsNative
let [<Import("RefreshControlBase","react-native")>] RefreshControlBase: obj = jsNative
let [<Import("RecyclerViewBackedScrollViewBase","react-native")>] RecyclerViewBackedScrollViewBase: obj = jsNative
let [<Import("SliderBase","react-native")>] SliderBase: obj = jsNative
let [<Import("ImageBase","react-native")>] ImageBase: obj = jsNative
let [<Import("ImageBackgroundBase","react-native")>] ImageBackgroundBase: obj = jsNative
let [<Import("ListViewBase","react-native")>] ListViewBase: obj = jsNative
let [<Import("MapViewBase","react-native")>] MapViewBase: obj = jsNative
let [<Import("MaskedViewBase","react-native")>] MaskedViewBase: obj = jsNative
let [<Import("TouchableWithoutFeedbackBase","react-native")>] TouchableWithoutFeedbackBase: obj = jsNative
let [<Import("TouchableHighlightBase","react-native")>] TouchableHighlightBase: obj = jsNative
let [<Import("TouchableOpacityBase","react-native")>] TouchableOpacityBase: obj = jsNative
let [<Import("TouchableNativeFeedbackBase","react-native")>] TouchableNativeFeedbackBase: obj = jsNative
let [<Import("ScrollViewBase","react-native")>] ScrollViewBase: obj = jsNative
let [<Import("SnapshotViewIOSBase","react-native")>] SnapshotViewIOSBase: obj = jsNative
let [<Import("SwitchBase","react-native")>] SwitchBase: obj = jsNative
let [<Import("ART","react-native")>] ART: ARTStatic = jsNative
let [<Import("ImagePickerIOS","react-native")>] ImagePickerIOS: ImagePickerIOSStatic = jsNative
let [<Import("LayoutAnimation","react-native")>] LayoutAnimation: LayoutAnimationStatic = jsNative
let [<Import("SectionList","react-native")>] SectionList: SectionListStatic<obj option> = jsNative
let [<Import("Systrace","react-native")>] Systrace: SystraceStatic = jsNative
let [<Import("ActionSheetIOS","react-native")>] ActionSheetIOS: ActionSheetIOSStatic = jsNative
let [<Import("Share","react-native")>] Share: ShareStatic = jsNative
let [<Import("AdSupportIOS","react-native")>] AdSupportIOS: AdSupportIOSStatic = jsNative
let [<Import("AccessibilityInfo","react-native")>] AccessibilityInfo: AccessibilityInfoStatic = jsNative
let [<Import("Alert","react-native")>] Alert: AlertStatic = jsNative
let [<Import("AlertAndroid","react-native")>] AlertAndroid: AlertAndroidStatic = jsNative
let [<Import("AlertIOS","react-native")>] AlertIOS: AlertIOSStatic = jsNative
let [<Import("AppState","react-native")>] AppState: AppStateStatic = jsNative
let [<Import("AppStateIOS","react-native")>] AppStateIOS: AppStateStatic = jsNative
let [<Import("AsyncStorage","react-native")>] AsyncStorage: AsyncStorageStatic = jsNative
let [<Import("BackAndroid","react-native")>] BackAndroid: BackAndroidStatic = jsNative
let [<Import("BackHandler","react-native")>] BackHandler: BackHandlerStatic = jsNative
let [<Import("CameraRoll","react-native")>] CameraRoll: CameraRollStatic = jsNative
let [<Import("Clipboard","react-native")>] Clipboard: ClipboardStatic = jsNative
let [<Import("DatePickerAndroid","react-native")>] DatePickerAndroid: DatePickerAndroidStatic = jsNative
let [<Import("Geolocation","react-native")>] Geolocation: GeolocationStatic = jsNative
/// <summary><see href="http://facebook.github.io/react-native/blog/2016/08/19/right-to-left-support-for-react-native-apps.html" /></summary>
let [<Import("I18nManager","react-native")>] I18nManager: I18nManagerStatic = jsNative
let [<Import("ImageEditor","react-native")>] ImageEditor: ImageEditorStatic = jsNative
let [<Import("ImageStore","react-native")>] ImageStore: ImageStoreStatic = jsNative
let [<Import("InteractionManager","react-native")>] InteractionManager: InteractionManagerStatic = jsNative
let [<Import("IntentAndroid","react-native")>] IntentAndroid: IntentAndroidStatic = jsNative
let [<Import("Keyboard","react-native")>] Keyboard: KeyboardStatic = jsNative
let [<Import("Linking","react-native")>] Linking: LinkingStatic = jsNative
let [<Import("LinkingIOS","react-native")>] LinkingIOS: LinkingIOSStatic = jsNative
let [<Import("NativeMethodsMixin","react-native")>] NativeMethodsMixin: NativeMethodsMixinStatic = jsNative
let [<Import("NativeComponent","react-native")>] NativeComponent: NativeMethodsMixinStatic = jsNative
let [<Import("NetInfo","react-native")>] NetInfo: NetInfoStatic = jsNative
let [<Import("PanResponder","react-native")>] PanResponder: PanResponderStatic = jsNative
let [<Import("PermissionsAndroid","react-native")>] PermissionsAndroid: PermissionsAndroidStatic = jsNative
let [<Import("PushNotificationIOS","react-native")>] PushNotificationIOS: PushNotificationIOSStatic = jsNative
let [<Import("Settings","react-native")>] Settings: SettingsStatic = jsNative
let [<Import("StatusBarIOS","react-native")>] StatusBarIOS: StatusBarIOSStatic = jsNative
let [<Import("TimePickerAndroid","react-native")>] TimePickerAndroid: TimePickerAndroidStatic = jsNative
let [<Import("ToastAndroid","react-native")>] ToastAndroid: ToastAndroidStatic = jsNative
let [<Import("UIManager","react-native")>] UIManager: UIManagerStatic = jsNative
let [<Import("VibrationIOS","react-native")>] VibrationIOS: VibrationIOSStatic = jsNative
let [<Import("Vibration","react-native")>] Vibration: VibrationStatic = jsNative
/// <summary>
/// Initial dimensions are set before <c>runApplication</c> is called so they should
/// be available before any other require's are run, but may be updated later.
/// 
/// Note: Although dimensions are available immediately, they may change (e.g
/// due to device rotation) so any rendering logic or styles that depend on
/// these constants should try to call this function on every render, rather
/// than caching the value (for example, using inline styles rather than
/// setting a value in a <c>StyleSheet</c>).
/// 
/// Example: <c>const {height, width} = Dimensions.get('window');</c>
/// </summary>
let [<Import("Dimensions","react-native")>] Dimensions: Dimensions = jsNative
let [<Import("ShadowPropTypesIOS","react-native")>] ShadowPropTypesIOS: ShadowPropTypesIOSStatic = jsNative
let [<Import("Easing","react-native")>] Easing: EasingStatic = jsNative
let [<Import("DeviceEventEmitter","react-native")>] DeviceEventEmitter: DeviceEventEmitterStatic = jsNative
/// Abstract base class for implementing event-emitting modules. This implements
/// a subset of the standard EventEmitter node module API.
let [<Import("NativeEventEmitter","react-native")>] NativeEventEmitter: NativeEventEmitter = jsNative
/// Deprecated - subclass NativeEventEmitter to create granular event modules instead of
/// adding all event listeners directly to RCTNativeAppEventEmitter.
let [<Import("NativeAppEventEmitter","react-native")>] NativeAppEventEmitter: RCTNativeAppEventEmitter = jsNative
/// <summary>
/// Native Modules written in ObjectiveC/Swift/Java exposed via the RCTBridge
/// Define lazy getters for each module. These will return the module if already loaded, or load it if not.
/// See <see href="https://facebook.github.io/react-native/docs/native-modules-ios.html" />
/// Use:
/// &lt;code&gt;const MyModule = NativeModules.ModuleName&lt;/code&gt;
/// </summary>
let [<Import("NativeModules","react-native")>] NativeModules: NativeModulesStatic = jsNative
let [<Import("Platform","react-native")>] Platform: PlatformStatic = jsNative
let [<Import("PlatformIOS","react-native")>] PlatformIOS: PlatformIOSStatic = jsNative
let [<Import("PixelRatio","react-native")>] PixelRatio: PixelRatioStatic = jsNative
let [<Import("YellowBox","react-native")>] YellowBox: obj = jsNative
let [<Import("ColorPropType","react-native")>] ColorPropType: React.Validator<string> = jsNative
let [<Import("EdgeInsetsPropType","react-native")>] EdgeInsetsPropType: React.Validator<Insets> = jsNative
let [<Import("PointPropType","react-native")>] PointPropType: React.Validator<PointPropType> = jsNative
let [<Import("ViewPropTypes","react-native")>] ViewPropTypes: React.ValidationMap<ViewProps> = jsNative

type [<AllowNullLiteral>] IExports =
    /// EventSubscription represents a subscription to a particular event. It can
    /// remove its own subscription.
    abstract EventSubscription: EventSubscriptionStatic
    /// EmitterSubscription represents a subscription with listener and context data.
    abstract EmitterSubscription: EmitterSubscriptionStatic
    abstract EventEmitter: EventEmitterStatic
    abstract createElement: ``type``: React.ReactType * ?props: 'P * [<ParamArray>] children: React.ReactNode[] -> React.ReactElement<'P>
    /// A React component for displaying text which supports nesting, styling, and touch handling.
    abstract TextComponent: TextComponentStatic
    abstract Text: TextStatic
    /// DocumentSelectionState is responsible for maintaining selection information
    /// for a document.
    /// 
    /// It is intended for use by AbstractTextEditor-based components for
    /// identifying the appropriate start/end positions to modify the
    /// DocumentContent, and for programatically setting browser selection when
    /// components re-render.
    abstract DocumentSelectionState: DocumentSelectionStateStatic
    /// <seealso href="https://facebook.github.io/react-native/docs/textinput.html#methods" />
    abstract TextInputComponent: TextInputComponentStatic
    abstract TextInput: TextInputStatic
    /// <summary>
    /// React component that wraps the Android-only [<c>Toolbar</c> widget][0]. A Toolbar can display a logo,
    /// navigation icon (e.g. hamburger menu), a title &amp; subtitle and a list of actions. The title and
    /// subtitle are expanded so the logo and navigation icons are displayed on the left, title and
    /// subtitle in the middle and the actions on the right.
    /// 
    /// If the toolbar has an only child, it will be displayed between the title and actions.
    /// 
    /// Although the Toolbar supports remote images for the logo, navigation and action icons, this
    /// should only be used in DEV mode where <c>require('./some_icon.png')</c> translates into a packager
    /// URL. In release mode you should always use a drawable resource for these icons. Using
    /// <c>require('./some_icon.png')</c> will do this automatically for you, so as long as you don't
    /// explicitly use e.g. <c>{uri: 'http://...'}</c>, you will be good.
    /// 
    /// [0]: <see href="https://developer.android.com/reference/android/support/v7/widget/Toolbar.html" />
    /// </summary>
    abstract ToolbarAndroidComponent: ToolbarAndroidComponentStatic
    abstract ToolbarAndroid: ToolbarAndroidStatic
    /// The most fundamental component for building UI, View is a container that supports layout with flexbox, style, some touch handling,
    /// and accessibility controls, and is designed to be nested inside other views and to have 0 to many children of any type.
    /// View maps directly to the native view equivalent on whatever platform React is running on,
    /// whether that is a UIView, <div>, android.view, etc.
    abstract ViewComponent: ViewComponentStatic
    abstract View: ViewStatic
    abstract ViewPagerAndroidComponent: ViewPagerAndroidComponentStatic
    abstract ViewPagerAndroid: ViewPagerAndroidStatic
    /// It is a component to solve the common problem of views that need to move out of the way of the virtual keyboard.
    /// It can automatically adjust either its position or bottom padding based on the position of the keyboard.
    abstract KeyboardAvoidingViewComponent: KeyboardAvoidingViewComponentStatic
    abstract KeyboardAvoidingView: KeyboardAvoidingViewStatic
    abstract WebView: WebViewStatic
    /// Renders nested content and automatically applies paddings reflect the portion of the view
    /// that is not covered by navigation bars, tab bars, toolbars, and other ancestor views.
    /// Moreover, and most importantly, Safe Area's paddings feflect physical limitation of the screen,
    /// such as rounded corners or camera notches (aka sensor housing area on iPhone X).
    abstract SafeAreaViewComponent: SafeAreaViewComponentStatic
    abstract SafeAreaView: SafeAreaViewStatic
    /// A component which enables customization of the keyboard input accessory view on iOS. The input accessory view is
    /// displayed above the keyboard whenever a TextInput has focus. This component can be used to create custom toolbars.
    /// 
    /// To use this component wrap your custom toolbar with the InputAccessoryView component, and set a nativeID. Then, pass
    /// that nativeID as the inputAccessoryViewID of whatever TextInput you desire.
    abstract InputAccessoryView: InputAccessoryViewStatic
    /// <summary>
    /// Use <c>SegmentedControlIOS</c> to render a UISegmentedControl iOS.
    /// 
    /// #### Programmatically changing selected index
    /// 
    /// The selected index can be changed on the fly by assigning the
    /// selectIndex prop to a state variable, then changing that variable.
    /// Note that the state variable would need to be updated as the user
    /// selects a value and changes the index, as shown in the example below.
    /// 
    /// <code language="`">
    /// &lt;SegmentedControlIOS
    ///    values={['One', 'Two']}
    ///    selectedIndex={this.state.selectedIndex}
    ///    onChange={(event) =&gt; {
    ///      this.setState({selectedIndex: event.nativeEvent.selectedSegmentIndex});
    ///    }}
    /// /&gt;
    /// </code>
    /// </summary>
    abstract SegmentedControlIOSComponent: SegmentedControlIOSComponentStatic
    abstract SegmentedControlIOS: SegmentedControlIOSStatic
    /// <summary>
    /// A navigator is an object of navigation functions that a view can call.
    /// It is passed as a prop to any component rendered by NavigatorIOS.
    /// 
    /// Navigator functions are also available on the NavigatorIOS component:
    /// </summary>
    /// <seealso href="https://facebook.github.io/react-native/docs/navigatorios.html#navigator" />
    abstract NavigatorIOS: NavigatorIOSStatic
    abstract ActivityIndicatorComponent: ActivityIndicatorComponentStatic
    abstract ActivityIndicator: ActivityIndicatorStatic
    [<Obsolete("since version 0.28.0")>]
    abstract ActivityIndicatorIOS: ActivityIndicatorIOSStatic
    abstract DatePickerIOSComponent: DatePickerIOSComponentStatic
    abstract DatePickerIOS: DatePickerIOSStatic
    abstract DrawerLayoutAndroidComponent: DrawerLayoutAndroidComponentStatic
    abstract DrawerLayoutAndroid: DrawerLayoutAndroidStatic
    /// <seealso cref="PickerIOS.ios.js" />
    abstract PickerIOSItem: PickerIOSItemStatic
    abstract PickerItem: PickerItemStatic
    /// <seealso href="https://facebook.github.io/react-native/docs/picker.html" />
    /// <seealso cref="Picker.js" />
    abstract Picker: PickerStatic
    /// <seealso href="https://facebook.github.io/react-native/docs/pickerios.html" />
    /// <seealso cref="PickerIOS.ios.js" />
    abstract PickerIOSComponent: PickerIOSComponentStatic
    abstract PickerIOS: PickerIOSStatic
    /// <summary>
    /// React component that wraps the Android-only <c>ProgressBar</c>. This component is used to indicate
    /// that the app is loading or there is some activity in the app.
    /// </summary>
    abstract ProgressBarAndroidComponent: ProgressBarAndroidComponentStatic
    abstract ProgressBarAndroid: ProgressBarAndroidStatic
    abstract ProgressViewIOSComponent: ProgressViewIOSComponentStatic
    abstract ProgressViewIOS: ProgressViewIOSStatic
    /// <summary>
    /// This component is used inside a ScrollView or ListView to add pull to refresh
    /// functionality. When the ScrollView is at <c>scrollY: 0</c>, swiping down
    /// triggers an <c>onRefresh</c> event.
    /// 
    /// __Note:__ <c>refreshing</c> is a controlled prop, this is why it needs to be set to true
    /// in the <c>onRefresh</c> function otherwise the refresh indicator will stop immediately.
    /// </summary>
    abstract RefreshControlComponent: RefreshControlComponentStatic
    abstract RefreshControl: RefreshControlStatic
    /// <summary>
    /// Wrapper around android native recycler view.
    /// 
    /// It simply renders rows passed as children in a separate recycler view cells
    /// similarly to how <c>ScrollView</c> is doing it. Thanks to the fact that it uses
    /// native <c>RecyclerView</c> though, rows that are out of sight are going to be
    /// automatically detached (similarly on how this would work with
    /// <c>removeClippedSubviews = true</c> on a <c>ScrollView.js</c>).
    /// 
    /// CAUTION: This is an experimental component and should only be used together
    /// with javascript implementation of list view (see ListView.js). In order to
    /// use it pass this component as <c>renderScrollComponent</c> to the list view. For
    /// now only horizontal scrolling is supported.
    /// </summary>
    abstract RecyclerViewBackedScrollViewComponent: RecyclerViewBackedScrollViewComponentStatic
    abstract RecyclerViewBackedScrollView: RecyclerViewBackedScrollViewStatic
    /// A component used to select a single value from a range of values.
    abstract SliderComponent: SliderComponentStatic
    abstract Slider: SliderStatic
    /// <summary>
    /// Use SwitchIOS to render a boolean input on iOS.
    /// 
    /// This is a controlled component, so you must hook in to the onValueChange callback and update the value prop in order for the component to update,
    /// otherwise the user's change will be reverted immediately to reflect props.value as the source of truth.
    /// </summary>
    /// <seealso href="https://facebook.github.io/react-native/docs/switchios.html" />
    abstract SwitchIOS: SwitchIOSStatic
    abstract ImageComponent: ImageComponentStatic
    abstract Image: ImageStatic
    abstract ImageBackgroundComponent: ImageBackgroundComponentStatic
    abstract ImageBackground: ImageBackgroundStatic
    abstract FlatList: FlatListStatic
    abstract ListViewComponent: ListViewComponentStatic
    abstract ListView: ListViewStatic
    /// <seealso href="https://facebook.github.io/react-native/docs/mapview.html#content" />
    abstract MapViewComponent: MapViewComponentStatic
    abstract MapView: MapViewStatic
    /// <seealso href="https://facebook.github.io/react-native/docs/maskedviewios.html" />
    abstract MaskedViewComponent: MaskedViewComponentStatic
    abstract MaskedViewIOS: MaskedViewIOSStatic
    abstract Modal: ModalStatic
    /// <summary>
    /// Do not use unless you have a very good reason.
    /// All the elements that respond to press should have a visual feedback when touched.
    /// This is one of the primary reason a "web" app doesn't feel "native".
    /// </summary>
    /// <seealso href="https://facebook.github.io/react-native/docs/touchablewithoutfeedback.html" />
    abstract TouchableWithoutFeedbackComponent: TouchableWithoutFeedbackComponentStatic
    abstract TouchableWithoutFeedback: TouchableWithoutFeedbackStatic
    /// <summary>
    /// A wrapper for making views respond properly to touches.
    /// On press down, the opacity of the wrapped view is decreased,
    /// which allows the underlay color to show through, darkening or tinting the view.
    /// The underlay comes from adding a view to the view hierarchy,
    /// which can sometimes cause unwanted visual artifacts if not used correctly,
    /// for example if the backgroundColor of the wrapped view isn't explicitly set to an opaque color.
    /// 
    /// NOTE: TouchableHighlight supports only one child
    /// If you wish to have several child components, wrap them in a View.
    /// </summary>
    /// <seealso href="https://facebook.github.io/react-native/docs/touchablehighlight.html" />
    abstract TouchableHighlightComponent: TouchableHighlightComponentStatic
    abstract TouchableHighlight: TouchableHighlightStatic
    /// <summary>
    /// A wrapper for making views respond properly to touches.
    /// On press down, the opacity of the wrapped view is decreased, dimming it.
    /// This is done without actually changing the view hierarchy,
    /// and in general is easy to add to an app without weird side-effects.
    /// </summary>
    /// <seealso href="https://facebook.github.io/react-native/docs/touchableopacity.html" />
    abstract TouchableOpacityComponent: TouchableOpacityComponentStatic
    abstract TouchableOpacity: TouchableOpacityStatic
    /// <summary>
    /// A wrapper for making views respond properly to touches (Android only).
    /// On Android this component uses native state drawable to display touch feedback.
    /// At the moment it only supports having a single View instance as a child node,
    /// as it's implemented by replacing that View with another instance of RCTView node with some additional properties set.
    /// 
    /// Background drawable of native feedback touchable can be customized with background property.
    /// </summary>
    /// <seealso href="https://facebook.github.io/react-native/docs/touchablenativefeedback.html#content" />
    abstract TouchableNativeFeedbackComponent: TouchableNativeFeedbackComponentStatic
    abstract TouchableNativeFeedback: TouchableNativeFeedbackStatic
    /// <summary>
    /// Provides efficient data processing and access to the
    /// <c>ListView</c> component.  A <c>ListViewDataSource</c> is created with functions for
    /// extracting data from the input blob, and comparing elements (with default
    /// implementations for convenience).  The input blob can be as simple as an
    /// array of strings, or an object with rows nested inside section objects.
    /// 
    /// To update the data in the datasource, use <c>cloneWithRows</c> (or
    /// <c>cloneWithRowsAndSections</c> if you care about sections).  The data in the
    /// data source is immutable, so you can't modify it directly.  The clone methods
    /// suck in the new data and compute a diff for each row so ListView knows
    /// whether to re-render it or not.
    /// </summary>
    abstract ListViewDataSource: ListViewDataSourceStatic
    abstract TabBarIOSItem: TabBarIOSItemStatic
    abstract TabBarIOS: TabBarIOSStatic
    /// Deprecated - subclass NativeEventEmitter to create granular event modules instead of
    /// adding all event listeners directly to RCTDeviceEventEmitter.
    abstract DeviceEventEmitter: DeviceEventEmitterStaticStatic
    abstract ScrollViewComponent: ScrollViewComponentStatic
    abstract ScrollView: ScrollViewStatic
    abstract SnapshotViewIOSComponent: SnapshotViewIOSComponentStatic
    abstract SnapshotViewIOS: SnapshotViewIOSStatic
    /// <summary>
    /// A container component that renders multiple SwipeableRow's in a ListView
    /// implementation. This is designed to be a drop-in replacement for the
    /// standard React Native <c>ListView</c>, so use it as if it were a ListView, but
    /// with extra props, i.e.
    /// 
    /// let ds = SwipeableListView.getNewDataSource();
    /// ds.cloneWithRowsAndSections(dataBlob, ?sectionIDs, ?rowIDs);
    /// // ..
    /// &lt;SwipeableListView renderRow={..} renderQuickActions={..} {..ListView props} /&gt;
    /// 
    /// SwipeableRow can be used independently of this component, but the main
    /// benefit of using this component is
    /// 
    /// - It ensures that at most 1 row is swiped open (auto closes others)
    /// - It can bounce the 1st row of the list so users know it's swipeable
    /// - More to come
    /// </summary>
    abstract SwipeableListView: SwipeableListViewStatic
    abstract Button: ButtonStatic
    abstract PermissionsAndroid: PermissionsAndroidStaticStatic
    abstract StatusBar: StatusBarStatic
    /// <summary>
    /// Renders a boolean input.
    /// 
    /// This is a controlled component that requires an <c>onValueChange</c> callback that
    /// updates the <c>value</c> prop in order for the component to reflect user actions.
    /// If the <c>value</c> prop is not updated, the component will continue to render
    /// the supplied <c>value</c> prop instead of the expected result of any user actions.
    /// </summary>
    abstract SwitchComponent: SwitchComponentStatic
    abstract Switch: SwitchStatic
    abstract ClippingRectangle: ClippingRectangleStatic
    abstract Group: GroupStatic
    abstract Shape: ShapeStatic
    abstract Surface: SurfaceStatic
    abstract ARTText: ARTTextStatic
    /// <summary>
    /// Used to create React components that directly wrap native component
    /// implementations.  Config information is extracted from data exported from the
    /// UIManager module.  You should also wrap the native component in a
    /// hand-written component with full propTypes definitions and other
    /// documentation - pass the hand-written component in as <c>componentInterface</c> to
    /// verify all the native props are documented via <c>propTypes</c>.
    /// 
    /// If some native props shouldn't be exposed in the wrapper interface, you can
    /// pass null for <c>componentInterface</c> and call <c>verifyPropTypes</c> directly
    /// with <c>nativePropsToIgnore</c>;
    /// 
    /// Common types are lined up with the appropriate prop differs with
    /// <c>TypeToDifferMap</c>.  Non-scalar types not in the map default to <c>deepDiffer</c>.
    /// </summary>
    abstract requireNativeComponent: viewName: string * ?componentInterface: ComponentInterface<'P> * ?extraConfig: RequireNativeComponentExtraConfig -> React.ComponentClass<obj>
    abstract findNodeHandle: componentOrHandle: U3<float, React.Component<obj option, obj option>, React.ComponentClass<obj option>> option -> float option
    abstract processColor: color: obj option -> float
    abstract __spread: target: obj option * [<ParamArray>] sources: obj option[] -> obj option
    abstract require: name: string -> obj option
    abstract console: Console
    abstract navigator: Navigator
    /// <summary>
    /// This contains the non-native <c>XMLHttpRequest</c> object, which you can use if you want to route network requests
    /// through DevTools (to trace them):
    /// 
    ///    global.XMLHttpRequest = global.originalXMLHttpRequest;
    /// </summary>
    /// <seealso href="https://github.com/facebook/react-native/issues/934" />
    abstract originalXMLHttpRequest: obj option
    abstract __BUNDLE_START_TIME__: float
    abstract ErrorUtils: ErrorUtils
    /// This variable is set to true when react-native is running in Dev mode
    /// Typical usage:
    /// &lt;code&gt; if (__DEV__) console.log('Running in dev mode')&lt;/code&gt;
    abstract __DEV__: bool

type [<AllowNullLiteral>] RequireNativeComponentExtraConfig =
    abstract nativeOnly: 'NP option with get, set

type Constructor<'T> =
    obj

type [<AllowNullLiteral>] MeasureOnSuccessCallback =
    [<Emit "$0($1...)">] abstract Invoke: x: float * y: float * width: float * height: float * pageX: float * pageY: float -> unit

type [<AllowNullLiteral>] MeasureInWindowOnSuccessCallback =
    [<Emit "$0($1...)">] abstract Invoke: x: float * y: float * width: float * height: float -> unit

type [<AllowNullLiteral>] MeasureLayoutOnSuccessCallback =
    [<Emit "$0($1...)">] abstract Invoke: left: float * top: float * width: float * height: float -> unit

/// EventSubscription represents a subscription to a particular event. It can
/// remove its own subscription.
type [<AllowNullLiteral>] EventSubscription =
    abstract eventType: string with get, set
    abstract key: float with get, set
    abstract subscriber: EventSubscriptionVendor with get, set
    /// Removes this subscription from the subscriber that controls it.
    abstract remove: unit -> unit

/// EventSubscription represents a subscription to a particular event. It can
/// remove its own subscription.
type [<AllowNullLiteral>] EventSubscriptionStatic =
    /// <param name="subscriber">
    /// the subscriber that controls
    /// this subscription.
    /// </param>
    [<EmitConstructor>] abstract Create: subscriber: EventSubscriptionVendor -> EventSubscription

/// EventSubscriptionVendor stores a set of EventSubscriptions that are
/// subscribed to a particular event type.
type [<AllowNullLiteral>] EventSubscriptionVendor =
    abstract constructor: unit -> EventSubscriptionVendor
    /// Adds a subscription keyed by an event type.
    abstract addSubscription: eventType: string * subscription: EventSubscription -> EventSubscription
    /// <summary>Removes a bulk set of the subscriptions.</summary>
    /// <param name="eventType">
    /// Optional name of the event type whose
    /// registered supscriptions to remove, if null remove all subscriptions.
    /// </param>
    abstract removeAllSubscriptions: ?eventType: string -> unit
    /// <summary>
    /// Removes a specific subscription. Instead of calling this function, call
    /// <c>subscription.remove()</c> directly.
    /// </summary>
    abstract removeSubscription: subscription: obj option -> unit
    /// Returns the array of subscriptions that are currently registered for the
    /// given event type.
    /// 
    /// Note: This array can be potentially sparse as subscriptions are deleted
    /// from it when they are removed.
    abstract getSubscriptionsForType: eventType: string -> ResizeArray<EventSubscription>

/// EmitterSubscription represents a subscription with listener and context data.
type [<AllowNullLiteral>] EmitterSubscription =
    inherit EventSubscription
    abstract emitter: EventEmitter with get, set
    abstract listener: (unit -> obj option) with get, set
    abstract context: obj option with get, set
    /// <summary>
    /// Removes this subscription from the emitter that registered it.
    /// Note: we're overriding the <c>remove()</c> method of EventSubscription here
    /// but deliberately not calling <c>super.remove()</c> as the responsibility
    /// for removing the subscription lies with the EventEmitter.
    /// </summary>
    abstract remove: unit -> unit

/// EmitterSubscription represents a subscription with listener and context data.
type [<AllowNullLiteral>] EmitterSubscriptionStatic =
    /// <param name="emitter">
    /// The event emitter that registered this
    /// subscription
    /// </param>
    /// <param name="subscriber">
    /// The subscriber that controls
    /// this subscription
    /// </param>
    /// <param name="listener">
    /// Function to invoke when the specified event is
    /// emitted
    /// </param>
    /// <param name="context">
    /// Optional context object to use when invoking the
    /// listener
    /// </param>
    [<EmitConstructor>] abstract Create: emitter: EventEmitter * subscriber: EventSubscriptionVendor * listener: (unit -> obj option) * context: obj option -> EmitterSubscription

type [<AllowNullLiteral>] EventEmitterListener =
    /// <summary>
    /// Adds a listener to be invoked when events of the specified type are
    /// emitted. An optional calling context may be provided. The data arguments
    /// emitted will be passed to the listener function.
    /// </summary>
    /// <param name="eventType">Name of the event to listen to</param>
    /// <param name="listener">
    /// Function to invoke when the specified event is
    /// emitted
    /// </param>
    /// <param name="context">
    /// Optional context object to use when invoking the
    /// listener
    /// </param>
    abstract addListener: eventType: string * listener: (ResizeArray<obj option> -> obj option) * ?context: obj -> EmitterSubscription

type [<AllowNullLiteral>] EventEmitter =
    inherit EventEmitterListener
    /// <summary>
    /// Similar to addListener, except that the listener is removed after it is
    /// invoked once.
    /// </summary>
    /// <param name="eventType">Name of the event to listen to</param>
    /// <param name="listener">
    /// Function to invoke only once when the
    /// specified event is emitted
    /// </param>
    /// <param name="context">
    /// Optional context object to use when invoking the
    /// listener
    /// </param>
    abstract once: eventType: string * listener: (ResizeArray<obj option> -> obj option) * context: obj option -> EmitterSubscription
    /// <summary>
    /// Removes all of the registered listeners, including those registered as
    /// listener maps.
    /// </summary>
    /// <param name="eventType">
    /// Optional name of the event whose registered
    /// listeners to remove
    /// </param>
    abstract removeAllListeners: ?eventType: string -> unit
    /// <summary>
    /// Provides an API that can be called during an eventing cycle to remove the
    /// last listener that was invoked. This allows a developer to provide an event
    /// object that can remove the listener (or listener map) during the
    /// invocation.
    /// 
    /// If it is called when not inside of an emitting cycle it will throw.
    /// </summary>
    /// <exception cref="Error"> When called not during an eventing cycle</exception>
    /// <example>
    ///   const subscription = emitter.addListenerMap({
    ///     someEvent: function(data, event) {
    ///       console.log(data);
    ///       emitter.removeCurrentListener();
    ///     }
    ///   });
    /// 
    ///   emitter.emit('someEvent', 'abc'); // logs 'abc'
    ///   emitter.emit('someEvent', 'def'); // does not log anything
    /// </example>
    abstract removeCurrentListener: unit -> unit
    /// <summary>
    /// Removes a specific subscription. Called by the <c>remove()</c> method of the
    /// subscription itself to ensure any necessary cleanup is performed.
    /// </summary>
    abstract removeSubscription: subscription: EmitterSubscription -> unit
    /// <summary>
    /// Returns an array of listeners that are currently registered for the given
    /// event.
    /// </summary>
    /// <param name="eventType">Name of the event to query</param>
    abstract listeners: eventType: string -> ResizeArray<EmitterSubscription>
    /// <summary>
    /// Emits an event of the given type with the given data. All handlers of that
    /// particular type will be notified.
    /// </summary>
    /// <param name="eventType">Name of the event to emit</param>
    /// <param name="Arbitrary">arguments to be passed to each registered listener</param>
    /// <example>
    ///   emitter.addListener('someEvent', function(message) {
    ///     console.log(message);
    ///   });
    /// 
    ///   emitter.emit('someEvent', 'abc'); // logs 'abc'
    /// </example>
    abstract emit: eventType: string * [<ParamArray>] ``params``: obj option[] -> unit
    /// <summary>Removes the given listener for event of specific type.</summary>
    /// <param name="eventType">Name of the event to emit</param>
    /// <param name="listener">
    /// Function to invoke when the specified event is
    /// emitted
    /// </param>
    /// <example>
    ///   emitter.removeListener('someEvent', function(message) {
    ///     console.log(message);
    ///   }); // removes the listener if already registered
    /// </example>
    abstract removeListener: eventType: string * listener: (ResizeArray<obj option> -> obj option) -> unit

type [<AllowNullLiteral>] EventEmitterStatic =
    /// <param name="subscriber">
    /// Optional subscriber instance
    /// to use. If omitted, a new subscriber will be created for the emitter.
    /// </param>
    [<EmitConstructor>] abstract Create: ?subscriber: EventSubscriptionVendor -> EventEmitter

/// <summary>
/// NativeMethodsMixin provides methods to access the underlying native component directly.
/// This can be useful in cases when you want to focus a view or measure its on-screen dimensions,
/// for example.
/// The methods described here are available on most of the default components provided by React Native.
/// Note, however, that they are not available on composite components that aren't directly backed by a
/// native view. This will generally include most components that you define in your own app.
/// For more information, see <see href="http://facebook.github.io/react-native/docs/direct-manipulation.html">Direct Manipulation</see>.
/// </summary>
/// <seealso href="https://github.com/facebook/react-native/blob/master/Libraries/ReactIOS/NativeMethodsMixin.js" />
type [<AllowNullLiteral>] NativeMethodsMixinStatic =
    /// <summary>
    /// Determines the location on screen, width, and height of the given view and
    /// returns the values via an async callback. If successful, the callback will
    /// be called with the following arguments:
    /// 
    ///   - x
    ///   - y
    ///   - width
    ///   - height
    ///   - pageX
    ///   - pageY
    /// 
    /// Note that these measurements are not available until after the rendering
    /// has been completed in native. If you need the measurements as soon as
    /// possible, consider using the [<c>onLayout</c>
    /// prop](docs/view.html#onlayout) instead.
    /// </summary>
    abstract measure: callback: MeasureOnSuccessCallback -> unit
    /// Determines the location of the given view in the window and returns the
    /// values via an async callback. If the React root view is embedded in
    /// another native view, this will give you the absolute coordinates. If
    /// successful, the callback will be called with the following
    /// arguments:
    /// 
    ///   - x
    ///   - y
    ///   - width
    ///   - height
    /// 
    /// Note that these measurements are not available until after the rendering
    /// has been completed in native.
    abstract measureInWindow: callback: MeasureInWindowOnSuccessCallback -> unit
    /// <summary>
    /// Like [<c>measure()</c>](#measure), but measures the view relative an ancestor,
    /// specified as <c>relativeToNativeNode</c>. This means that the returned x, y
    /// are relative to the origin x, y of the ancestor view.
    /// 
    /// As always, to obtain a native node handle for a component, you can use
    /// <c>React.findNodeHandle(component)</c>.
    /// </summary>
    abstract measureLayout: relativeToNativeNode: float * onSuccess: MeasureLayoutOnSuccessCallback * onFail: (unit -> unit) -> unit
    /// This function sends props straight to native. They will not participate in
    /// future diff process - this means that if you do not include them in the
    /// next render, they will remain active (see [Direct
    /// Manipulation](docs/direct-manipulation.html)).
    abstract setNativeProps: nativeProps: Object -> unit
    /// Requests focus for the given input or view. The exact behavior triggered
    /// will depend on the platform and type of view.
    abstract focus: unit -> unit
    /// <summary>Removes focus from an input or view. This is the opposite of <c>focus()</c>.</summary>
    abstract blur: unit -> unit
    abstract refs: NativeMethodsMixinStaticRefs with get, set

type [<AllowNullLiteral>] Runnable =
    [<Emit "$0($1...)">] abstract Invoke: appParameters: obj option -> unit

type [<AllowNullLiteral>] Task =
    [<Emit "$0($1...)">] abstract Invoke: taskData: obj option -> Promise<unit>

type [<AllowNullLiteral>] TaskProvider =
    [<Emit "$0($1...)">] abstract Invoke: unit -> Task

type NodeHandle =
    float

type [<AllowNullLiteral>] NativeSyntheticEvent<'T> =
    abstract bubbles: bool with get, set
    abstract cancelable: bool with get, set
    abstract currentTarget: NodeHandle with get, set
    abstract defaultPrevented: bool with get, set
    abstract eventPhase: float with get, set
    abstract isTrusted: bool with get, set
    abstract nativeEvent: 'T with get, set
    abstract isPropagationStopped: unit -> bool
    abstract isDefaultPrevented: unit -> bool
    abstract persist: unit -> unit
    abstract preventDefault: unit -> unit
    abstract stopPropagation: unit -> unit
    abstract target: NodeHandle with get, set
    abstract timeStamp: float with get, set
    abstract ``type``: string with get, set

type [<AllowNullLiteral>] NativeTouchEvent =
    /// Array of all touch events that have changed since the last event
    abstract changedTouches: ResizeArray<NativeTouchEvent> with get, set
    /// The ID of the touch
    abstract identifier: string with get, set
    /// The X position of the touch, relative to the element
    abstract locationX: float with get, set
    /// The Y position of the touch, relative to the element
    abstract locationY: float with get, set
    /// The X position of the touch, relative to the screen
    abstract pageX: float with get, set
    /// The Y position of the touch, relative to the screen
    abstract pageY: float with get, set
    /// The node id of the element receiving the touch event
    abstract target: string with get, set
    /// A time identifier for the touch, useful for velocity calculation
    abstract timestamp: float with get, set
    /// Array of all current touches on the screen
    abstract touches: ResizeArray<NativeTouchEvent> with get, set

type [<AllowNullLiteral>] GestureResponderEvent =
    inherit NativeSyntheticEvent<NativeTouchEvent>

type [<AllowNullLiteral>] PointPropType =
    abstract x: float with get, set
    abstract y: float with get, set

type [<AllowNullLiteral>] Insets =
    abstract top: float option with get, set
    abstract left: float option with get, set
    abstract bottom: float option with get, set
    abstract right: float option with get, set

/// <summary>//FIXME: need to find documentation on which component is a TTouchable and can implement that interface</summary>
/// <seealso cref="React.DOMAtributes" />
type [<AllowNullLiteral>] Touchable =
    abstract onTouchStart: (GestureResponderEvent -> unit) option with get, set
    abstract onTouchMove: (GestureResponderEvent -> unit) option with get, set
    abstract onTouchEnd: (GestureResponderEvent -> unit) option with get, set
    abstract onTouchCancel: (GestureResponderEvent -> unit) option with get, set
    abstract onTouchEndCapture: (GestureResponderEvent -> unit) option with get, set

type [<AllowNullLiteral>] ComponentProvider =
    [<Emit "$0($1...)">] abstract Invoke: unit -> React.ComponentType<obj option>

type [<AllowNullLiteral>] AppConfig =
    abstract appKey: string with get, set
    abstract ``component``: ComponentProvider option with get, set
    abstract run: Runnable option with get, set

/// <summary>
/// <c>AppRegistry</c> is the JS entry point to running all React Native apps.  App
/// root components should register themselves with
/// <c>AppRegistry.registerComponent</c>, then the native system can load the bundle
/// for the app and then actually run the app when it's ready by invoking
/// <c>AppRegistry.runApplication</c>.
/// 
/// To "stop" an application when a view should be destroyed, call
/// <c>AppRegistry.unmountApplicationComponentAtRootTag</c> with the tag that was
/// pass into <c>runApplication</c>. These should always be used as a pair.
/// 
/// <c>AppRegistry</c> should be <c>require</c>d early in the <c>require</c> sequence to make
/// sure the JS execution environment is setup before other modules are
/// <c>require</c>d.
/// </summary>
module AppRegistry =

    type [<AllowNullLiteral>] IExports =
        abstract registerConfig: config: ResizeArray<AppConfig> -> unit
        abstract registerComponent: appKey: string * getComponentFunc: ComponentProvider -> string
        abstract registerRunnable: appKey: string * func: Runnable -> string
        abstract getAppKeys: unit -> ResizeArray<string>
        abstract unmountApplicationComponentAtRootTag: rootTag: float -> unit
        abstract runApplication: appKey: string * appParameters: obj option -> unit
        abstract registerHeadlessTask: appKey: string * task: TaskProvider -> unit
        abstract getRunnable: appKey: string -> Runnable option

type [<AllowNullLiteral>] LayoutAnimationTypes =
    abstract spring: string with get, set
    abstract linear: string with get, set
    abstract easeInEaseOut: string with get, set
    abstract easeIn: string with get, set
    abstract easeOut: string with get, set

type [<AllowNullLiteral>] LayoutAnimationProperties =
    abstract opacity: string with get, set
    abstract scaleXY: string with get, set

type [<AllowNullLiteral>] LayoutAnimationAnim =
    abstract duration: float option with get, set
    abstract delay: float option with get, set
    abstract springDamping: float option with get, set
    abstract initialVelocity: float option with get, set
    abstract ``type``: string option with get, set
    abstract property: string option with get, set

type [<AllowNullLiteral>] LayoutAnimationConfig =
    abstract duration: float with get, set
    abstract create: LayoutAnimationAnim option with get, set
    abstract update: LayoutAnimationAnim option with get, set
    abstract delete: LayoutAnimationAnim option with get, set

/// Automatically animates views to their new positions when the next layout happens.
/// A common way to use this API is to call LayoutAnimation.configureNext before
/// calling setState.
type [<AllowNullLiteral>] LayoutAnimationStatic =
    /// <summary>Schedules an animation to happen on the next layout.</summary>
    /// <param name="config">
    /// Specifies animation properties:
    /// <c>duration</c> in milliseconds
    /// <c>create</c>, config for animating in new views (see Anim type)
    /// <c>update</c>, config for animating views that have been updated (see Anim type)
    /// </param>
    /// <param name="onAnimationDidEnd">Called when the animation finished. Only supported on iOS.</param>
    abstract configureNext: (LayoutAnimationConfig -> ((unit -> unit)) option -> unit) with get, set
    /// Helper for creating a config for configureNext.
    abstract create: (float -> (string) option -> (string) option -> LayoutAnimationConfig) with get, set
    abstract Types: LayoutAnimationTypes with get, set
    abstract Properties: LayoutAnimationProperties with get, set
    abstract configChecker: (LayoutAnimationStaticConfigChecker -> obj option) with get, set
    abstract Presets: LayoutAnimationStaticPresets with get, set
    abstract easeInEaseOut: (((unit -> unit)) option -> unit) with get, set
    abstract linear: (((unit -> unit)) option -> unit) with get, set
    abstract spring: (((unit -> unit)) option -> unit) with get, set

type [<StringEnum>] [<RequireQualifiedAccess>] FlexAlignType =
    | [<CompiledName "flex-start">] FlexStart
    | [<CompiledName "flex-end">] FlexEnd
    | Center
    | Stretch
    | Baseline

/// <summary>Flex Prop Types</summary>
/// <seealso href="https://facebook.github.io/react-native/docs/flexbox.html#proptypes" />
/// <seealso href="https://facebook.github.io/react-native/docs/layout-props.html" />
/// <seealso href="https://github.com/facebook/react-native/blob/master/Libraries/StyleSheet/LayoutPropTypes.js" />
type [<AllowNullLiteral>] FlexStyle =
    abstract alignContent: FlexStyleAlignContent option with get, set
    abstract alignItems: FlexAlignType option with get, set
    abstract alignSelf: U2<FlexAlignType, string> option with get, set
    abstract aspectRatio: float option with get, set
    abstract borderBottomWidth: float option with get, set
    abstract borderEndWidth: U2<float, string> option with get, set
    abstract borderLeftWidth: float option with get, set
    abstract borderRightWidth: float option with get, set
    abstract borderStartWidth: U2<float, string> option with get, set
    abstract borderTopWidth: float option with get, set
    abstract borderWidth: float option with get, set
    abstract bottom: U2<float, string> option with get, set
    abstract display: FlexStyleDisplay option with get, set
    abstract ``end``: U2<float, string> option with get, set
    abstract flex: float option with get, set
    abstract flexBasis: U2<float, string> option with get, set
    abstract flexDirection: FlexStyleFlexDirection option with get, set
    abstract flexGrow: float option with get, set
    abstract flexShrink: float option with get, set
    abstract flexWrap: FlexStyleFlexWrap option with get, set
    abstract height: U2<float, string> option with get, set
    abstract justifyContent: FlexStyleJustifyContent option with get, set
    abstract left: U2<float, string> option with get, set
    abstract margin: U2<float, string> option with get, set
    abstract marginBottom: U2<float, string> option with get, set
    abstract marginEnd: U2<float, string> option with get, set
    abstract marginHorizontal: U2<float, string> option with get, set
    abstract marginLeft: U2<float, string> option with get, set
    abstract marginRight: U2<float, string> option with get, set
    abstract marginStart: U2<float, string> option with get, set
    abstract marginTop: U2<float, string> option with get, set
    abstract marginVertical: U2<float, string> option with get, set
    abstract maxHeight: U2<float, string> option with get, set
    abstract maxWidth: U2<float, string> option with get, set
    abstract minHeight: U2<float, string> option with get, set
    abstract minWidth: U2<float, string> option with get, set
    abstract overflow: FlexStyleOverflow option with get, set
    abstract padding: U2<float, string> option with get, set
    abstract paddingBottom: U2<float, string> option with get, set
    abstract paddingEnd: U2<float, string> option with get, set
    abstract paddingHorizontal: U2<float, string> option with get, set
    abstract paddingLeft: U2<float, string> option with get, set
    abstract paddingRight: U2<float, string> option with get, set
    abstract paddingStart: U2<float, string> option with get, set
    abstract paddingTop: U2<float, string> option with get, set
    abstract paddingVertical: U2<float, string> option with get, set
    abstract position: FlexStylePosition option with get, set
    abstract right: U2<float, string> option with get, set
    abstract start: U2<float, string> option with get, set
    abstract top: U2<float, string> option with get, set
    abstract width: U2<float, string> option with get, set
    abstract zIndex: float option with get, set
    abstract direction: FlexStyleDirection option with get, set

/// <seealso cref="ShadowPropTypesIOS.js" />
type [<AllowNullLiteral>] ShadowPropTypesIOSStatic =
    /// <summary>Sets the drop shadow color</summary>
    abstract shadowColor: string with get, set
    /// <summary>Sets the drop shadow offset</summary>
    abstract shadowOffset: ShadowPropTypesIOSStaticShadowOffset with get, set
    /// <summary>Sets the drop shadow opacity (multiplied by the color's alpha component)</summary>
    abstract shadowOpacity: float with get, set
    /// <summary>Sets the drop shadow blur radius</summary>
    abstract shadowRadius: float with get, set

type [<AllowNullLiteral>] GeoConfiguration =
    abstract skipPermissionRequests: bool with get, set

type [<AllowNullLiteral>] GeoOptions =
    abstract timeout: float option with get, set
    abstract maximumAge: float option with get, set
    abstract enableHighAccuracy: bool option with get, set
    abstract distanceFilter: float option with get, set
    abstract useSignificantChanges: bool option with get, set

type [<AllowNullLiteral>] GeolocationReturnType =
    abstract coords: GeolocationReturnTypeCoords with get, set
    abstract timestamp: float with get, set

type [<AllowNullLiteral>] GeolocationError =
    abstract code: float with get, set
    abstract message: string with get, set
    abstract PERMISSION_DENIED: float with get, set
    abstract POSITION_UNAVAILABLE: float with get, set
    abstract TIMEOUT: float with get, set

type [<AllowNullLiteral>] PerpectiveTransform =
    abstract perspective: float with get, set

type [<AllowNullLiteral>] RotateTransform =
    abstract rotate: string with get, set

type [<AllowNullLiteral>] RotateXTransform =
    abstract rotateX: string with get, set

type [<AllowNullLiteral>] RotateYTransform =
    abstract rotateY: string with get, set

type [<AllowNullLiteral>] RotateZTransform =
    abstract rotateZ: string with get, set

type [<AllowNullLiteral>] ScaleTransform =
    abstract scale: float with get, set

type [<AllowNullLiteral>] ScaleXTransform =
    abstract scaleX: float with get, set

type [<AllowNullLiteral>] ScaleYTransform =
    abstract scaleY: float with get, set

type [<AllowNullLiteral>] TranslateXTransform =
    abstract translateX: float with get, set

type [<AllowNullLiteral>] TranslateYTransform =
    abstract translateY: float with get, set

type [<AllowNullLiteral>] SkewXTransform =
    abstract skewX: string with get, set

type [<AllowNullLiteral>] SkewYTransform =
    abstract skewY: string with get, set

type [<AllowNullLiteral>] TransformsStyle =
    abstract transform: ResizeArray<obj> option with get, set
    abstract transformMatrix: Array<float> option with get, set
    abstract rotation: float option with get, set
    abstract scaleX: float option with get, set
    abstract scaleY: float option with get, set
    abstract translateX: float option with get, set
    abstract translateY: float option with get, set

type [<AllowNullLiteral>] StyleSheetProperties =
    abstract hairlineWidth: float with get, set
    abstract flatten: style: 'T -> 'T

type [<AllowNullLiteral>] LayoutRectangle =
    abstract x: float with get, set
    abstract y: float with get, set
    abstract width: float with get, set
    abstract height: float with get, set

type [<AllowNullLiteral>] LayoutChangeEvent =
    abstract nativeEvent: LayoutChangeEventNativeEvent with get, set

type [<AllowNullLiteral>] TextStyleIOS =
    inherit ViewStyle
    abstract letterSpacing: float option with get, set
    abstract textDecorationColor: string option with get, set
    abstract textDecorationStyle: TextStyleIOSTextDecorationStyle option with get, set
    abstract textTransform: TextStyleIOSTextTransform option with get, set
    abstract writingDirection: TextStyleIOSWritingDirection option with get, set

type [<AllowNullLiteral>] TextStyleAndroid =
    inherit ViewStyle
    abstract textAlignVertical: TextStyleAndroidTextAlignVertical option with get, set
    abstract includeFontPadding: bool option with get, set

type [<AllowNullLiteral>] TextStyle =
    inherit TextStyleIOS
    inherit TextStyleAndroid
    inherit ViewStyle
    abstract color: string option with get, set
    abstract fontFamily: string option with get, set
    abstract fontSize: float option with get, set
    abstract fontStyle: TextStyleFontStyle option with get, set
    /// Specifies font weight. The values 'normal' and 'bold' are supported
    /// for most fonts. Not all fonts have a variant for each of the numeric
    /// values, in that case the closest one is chosen.
    abstract fontWeight: TextStyleFontWeight option with get, set
    abstract letterSpacing: float option with get, set
    abstract lineHeight: float option with get, set
    abstract textAlign: TextStyleTextAlign option with get, set
    abstract textDecorationLine: TextStyleTextDecorationLine option with get, set
    abstract textDecorationStyle: TextStyleIOSTextDecorationStyle option with get, set
    abstract textDecorationColor: string option with get, set
    abstract textShadowColor: string option with get, set
    abstract textShadowOffset: ShadowPropTypesIOSStaticShadowOffset option with get, set
    abstract textShadowRadius: float option with get, set
    abstract testID: string option with get, set

type [<AllowNullLiteral>] TextPropsIOS =
    /// Specifies whether font should be scaled down automatically to fit given style constraints.
    abstract adjustsFontSizeToFit: bool option with get, set
    /// Specifies smallest possible scale a font can reach when adjustsFontSizeToFit is enabled. (values 0.01-1.0).
    abstract minimumFontScale: float option with get, set
    /// <summary>
    /// When <c>true</c>, no visual change is made when text is pressed down. By
    /// default, a gray oval highlights the text on press down.
    /// </summary>
    abstract suppressHighlighting: bool option with get, set

type [<AllowNullLiteral>] TextPropsAndroid =
    /// Lets the user select text, to use the native copy and paste functionality.
    abstract selectable: bool option with get, set
    /// The highlight color of the text.
    abstract selectionColor: string option with get, set
    /// <summary>
    /// Set text break strategy on Android API Level 23+
    /// default is <c>highQuality</c>.
    /// </summary>
    abstract textBreakStrategy: TextPropsAndroidTextBreakStrategy option with get, set

type [<AllowNullLiteral>] TextProps =
    inherit TextPropsIOS
    inherit TextPropsAndroid
    inherit AccessibilityProps
    /// <summary>
    /// Specifies whether fonts should scale to respect Text Size accessibility settings.
    /// The default is <c>true</c>.
    /// </summary>
    abstract allowFontScaling: bool option with get, set
    /// <summary>
    /// This can be one of the following values:
    /// 
    /// - <c>head</c> - The line is displayed so that the end fits in the container and the missing text
    /// at the beginning of the line is indicated by an ellipsis glyph. e.g., "...wxyz"
    /// - <c>middle</c> - The line is displayed so that the beginning and end fit in the container and the
    /// missing text in the middle is indicated by an ellipsis glyph. "ab...yz"
    /// - <c>tail</c> - The line is displayed so that the beginning fits in the container and the
    /// missing text at the end of the line is indicated by an ellipsis glyph. e.g., "abcd..."
    /// - <c>clip</c> - Lines are not drawn past the edge of the text container.
    /// 
    /// The default is <c>tail</c>.
    /// 
    /// <c>numberOfLines</c> must be set in conjunction with this prop.
    /// 
    /// &gt; <c>clip</c> is working only for iOS
    /// </summary>
    abstract ellipsizeMode: TextPropsEllipsizeMode option with get, set
    /// Line Break mode. Works only with numberOfLines.
    /// clip is working only for iOS
    abstract lineBreakMode: TextPropsEllipsizeMode option with get, set
    /// <summary>
    /// Used to truncate the text with an ellipsis after computing the text
    /// layout, including line wrapping, such that the total number of lines
    /// does not exceed this number.
    /// 
    /// This prop is commonly used with <c>ellipsizeMode</c>.
    /// </summary>
    abstract numberOfLines: float option with get, set
    /// Invoked on mount and layout changes with
    /// 
    /// {nativeEvent: { layout: {x, y, width, height}}}.
    abstract onLayout: (LayoutChangeEvent -> unit) option with get, set
    /// This function is called on press.
    /// Text intrinsically supports press handling with a default highlight state (which can be disabled with suppressHighlighting).
    abstract onPress: (GestureResponderEvent -> unit) option with get, set
    /// <summary>
    /// This function is called on long press.
    /// e.g., <c>onLongPress={this.increaseSize}&gt;</c>`
    /// </summary>
    abstract onLongPress: (GestureResponderEvent -> unit) option with get, set
    /// <seealso href="https://facebook.github.io/react-native/docs/text.html#style" />
    abstract style: StyleProp<TextStyle> option with get, set
    /// Used to locate this view in end-to-end tests.
    abstract testID: string option with get, set

/// A React component for displaying text which supports nesting, styling, and touch handling.
type [<AllowNullLiteral>] TextComponent =
    inherit React.Component<TextProps>

/// A React component for displaying text which supports nesting, styling, and touch handling.
type [<AllowNullLiteral>] TextComponentStatic =
    [<EmitConstructor>] abstract Create: unit -> TextComponent

type [<AllowNullLiteral>] Text =
    inherit TextBase

type [<AllowNullLiteral>] TextStatic =
    [<EmitConstructor>] abstract Create: unit -> Text

type [<StringEnum>] [<RequireQualifiedAccess>] DataDetectorTypes =
    | PhoneNumber
    | Link
    | Address
    | CalendarEvent
    | None
    | All

/// DocumentSelectionState is responsible for maintaining selection information
/// for a document.
/// 
/// It is intended for use by AbstractTextEditor-based components for
/// identifying the appropriate start/end positions to modify the
/// DocumentContent, and for programatically setting browser selection when
/// components re-render.
type [<AllowNullLiteral>] DocumentSelectionState =
    inherit EventEmitter
    /// <summary>
    /// Apply an update to the state. If either offset value has changed,
    /// set the values and emit the <c>change</c> event. Otherwise no-op.
    /// </summary>
    abstract update: anchor: float * focus: float -> unit
    /// Given a max text length, constrain our selection offsets to ensure
    /// that the selection remains strictly within the text range.
    abstract constrainLength: maxLength: float -> unit
    abstract focus: unit -> unit
    abstract blur: unit -> unit
    abstract hasFocus: unit -> bool
    abstract isCollapsed: unit -> bool
    abstract isBackward: unit -> bool
    abstract getAnchorOffset: unit -> float
    abstract getFocusOffset: unit -> float
    abstract getStartOffset: unit -> float
    abstract getEndOffset: unit -> float
    abstract overlaps: start: float * ``end``: float -> bool

/// DocumentSelectionState is responsible for maintaining selection information
/// for a document.
/// 
/// It is intended for use by AbstractTextEditor-based components for
/// identifying the appropriate start/end positions to modify the
/// DocumentContent, and for programatically setting browser selection when
/// components re-render.
type [<AllowNullLiteral>] DocumentSelectionStateStatic =
    [<EmitConstructor>] abstract Create: anchor: float * focus: float -> DocumentSelectionState

/// <summary>IOS Specific properties for TextInput</summary>
/// <seealso href="https://facebook.github.io/react-native/docs/textinput.html#props" />
type [<AllowNullLiteral>] TextInputIOSProps =
    /// enum('never', 'while-editing', 'unless-editing', 'always')
    /// When the clear button should appear on the right side of the text view
    abstract clearButtonMode: TextInputIOSPropsClearButtonMode option with get, set
    /// If true, clears the text field automatically when editing begins
    abstract clearTextOnFocus: bool option with get, set
    /// <summary>
    /// Determines the types of data converted to clickable URLs in the text input.
    /// Only valid if <c>multiline={true}</c> and <c>editable={false}</c>.
    /// By default no data types are detected.
    /// 
    /// You can provide one type or an array of many types.
    /// 
    /// Possible values for <c>dataDetectorTypes</c> are:
    /// 
    /// - <c>'phoneNumber'</c>
    /// - <c>'link'</c>
    /// - <c>'address'</c>
    /// - <c>'calendarEvent'</c>
    /// - <c>'none'</c>
    /// - <c>'all'</c>
    /// </summary>
    abstract dataDetectorTypes: U2<DataDetectorTypes, ResizeArray<DataDetectorTypes>> option with get, set
    /// If true, the keyboard disables the return key when there is no text and automatically enables it when there is text.
    /// The default value is false.
    abstract enablesReturnKeyAutomatically: bool option with get, set
    /// Determines the color of the keyboard.
    abstract keyboardAppearance: TextInputIOSPropsKeyboardAppearance option with get, set
    /// See DocumentSelectionState.js, some state that is responsible for maintaining selection information for a document
    abstract selectionState: DocumentSelectionState option with get, set
    /// If false, disables spell-check style (i.e. red underlines). The default value is inherited from autoCorrect
    abstract spellCheck: bool option with get, set
    /// <summary>
    /// Give the keyboard and the system information about the expected
    /// semantic meaning for the content that users enter.
    /// 
    /// For iOS 11+ you can set <c>textContentType</c> to <c>username</c> or <c>password</c> to
    /// enable autofill of login details from the device keychain.
    /// 
    /// To disable autofill, set textContentType to <c>none</c>.
    /// 
    /// Possible values for <c>textContentType</c> are:
    /// 
    ///   - <c>'none'</c>
    ///   - <c>'URL'</c>
    ///   - <c>'addressCity'</c>
    ///   - <c>'addressCityAndState'</c>
    ///   - <c>'addressState'</c>
    ///   - <c>'countryName'</c>
    ///   - <c>'creditCardNumber'</c>
    ///   - <c>'emailAddress'</c>
    ///   - <c>'familyName'</c>
    ///   - <c>'fullStreetAddress'</c>
    ///   - <c>'givenName'</c>
    ///   - <c>'jobTitle'</c>
    ///   - <c>'location'</c>
    ///   - <c>'middleName'</c>
    ///   - <c>'name'</c>
    ///   - <c>'namePrefix'</c>
    ///   - <c>'nameSuffix'</c>
    ///   - <c>'nickname'</c>
    ///   - <c>'organizationName'</c>
    ///   - <c>'postalCode'</c>
    ///   - <c>'streetAddressLine1'</c>
    ///   - <c>'streetAddressLine2'</c>
    ///   - <c>'sublocality'</c>
    ///   - <c>'telephoneNumber'</c>
    ///   - <c>'username'</c>
    ///   - <c>'password'</c>
    /// </summary>
    abstract textContentType: TextInputIOSPropsTextContentType option with get, set

/// <summary>Android Specific properties for TextInput</summary>
/// <seealso href="https://facebook.github.io/react-native/docs/textinput.html#props" />
type [<AllowNullLiteral>] TextInputAndroidProps =
    /// When false, if there is a small amount of space available around a text input (e.g. landscape orientation on a phone),
    ///    the OS may choose to have the user edit the text inside of a full screen text input mode.
    /// When true, this feature is disabled and users will always edit the text directly inside of the text input.
    /// Defaults to false.
    abstract disableFullscreenUI: bool option with get, set
    /// If defined, the provided image resource will be rendered on the left.
    abstract inlineImageLeft: string option with get, set
    /// Padding between the inline image, if any, and the text input itself.
    abstract inlineImagePadding: float option with get, set
    /// Sets the number of lines for a TextInput.
    /// Use it with multiline set to true to be able to fill the lines.
    abstract numberOfLines: float option with get, set
    /// <summary>Sets the return key to the label. Use it instead of <c>returnKeyType</c>.</summary>
    abstract returnKeyLabel: string option with get, set
    /// Set text break strategy on Android API Level 23+, possible values are simple, highQuality, balanced
    /// The default value is simple.
    abstract textBreakStrategy: TextPropsAndroidTextBreakStrategy option with get, set
    /// The color of the textInput underline.
    abstract underlineColorAndroid: string option with get, set

type [<StringEnum>] [<RequireQualifiedAccess>] KeyboardType =
    | Default
    | [<CompiledName "email-address">] EmailAddress
    | Numeric
    | [<CompiledName "phone-pad">] PhonePad

type [<StringEnum>] [<RequireQualifiedAccess>] KeyboardTypeIOS =
    | [<CompiledName "ascii-capable">] AsciiCapable
    | [<CompiledName "numbers-and-punctuation">] NumbersAndPunctuation
    | Url
    | [<CompiledName "number-pad">] NumberPad
    | [<CompiledName "name-phone-pad">] NamePhonePad
    | [<CompiledName "decimal-pad">] DecimalPad
    | Twitter
    | [<CompiledName "web-search">] WebSearch

type KeyboardTypeAndroid =
    string

type KeyboardTypeOptions =
    U3<KeyboardType, KeyboardTypeAndroid, KeyboardTypeIOS>

type [<StringEnum>] [<RequireQualifiedAccess>] ReturnKeyType =
    | Done
    | Go
    | Next
    | Search
    | Send

type [<StringEnum>] [<RequireQualifiedAccess>] ReturnKeyTypeAndroid =
    | None
    | Previous

type [<StringEnum>] [<RequireQualifiedAccess>] ReturnKeyTypeIOS =
    | Default
    | Google
    | Join
    | Route
    | Yahoo
    | [<CompiledName "emergency-call">] EmergencyCall

type ReturnKeyTypeOptions =
    U3<ReturnKeyType, ReturnKeyTypeAndroid, ReturnKeyTypeIOS>

/// <seealso cref="TextInputProps.onFocus" />
type [<AllowNullLiteral>] TextInputFocusEventData =
    abstract target: float with get, set
    abstract text: string with get, set
    abstract eventCount: float with get, set

/// <seealso cref="TextInputProps.onScroll" />
type [<AllowNullLiteral>] TextInputScrollEventData =
    abstract contentOffset: TextInputScrollEventDataContentOffset with get, set

/// <seealso cref="TextInputProps.onSelectionChange" />
type [<AllowNullLiteral>] TextInputSelectionChangeEventData =
    abstract selection: TextInputSelectionChangeEventDataSelection with get, set
    abstract target: float with get, set

/// <seealso cref="TextInputProps.onKeyPress" />
type [<AllowNullLiteral>] TextInputKeyPressEventData =
    abstract key: string with get, set

/// <seealso cref="TextInputProps.onChange" />
type [<AllowNullLiteral>] TextInputChangeEventData =
    abstract eventCount: float with get, set
    abstract target: float with get, set
    abstract text: string with get, set

/// <seealso cref="TextInputProps.onContentSizeChange" />
type [<AllowNullLiteral>] TextInputContentSizeChangeEventData =
    abstract contentSize: ShadowPropTypesIOSStaticShadowOffset with get, set

/// <seealso cref="TextInputProps.onEndEditing" />
type [<AllowNullLiteral>] TextInputEndEditingEventData =
    abstract text: string with get, set

/// <seealso cref="TextInputProps.onSubmitEditing" />
type [<AllowNullLiteral>] TextInputSubmitEditingEventData =
    abstract text: string with get, set

/// <seealso href="https://facebook.github.io/react-native/docs/textinput.html#props" />
type [<AllowNullLiteral>] TextInputProps =
    inherit ViewProps
    inherit TextInputIOSProps
    inherit TextInputAndroidProps
    inherit AccessibilityProps
    /// <summary>
    /// Specifies whether fonts should scale to respect Text Size accessibility settings.
    /// The default is <c>true</c>.
    /// </summary>
    abstract allowFontScaling: bool option with get, set
    /// <summary>
    /// Can tell TextInput to automatically capitalize certain characters.
    ///       characters: all characters,
    ///       words: first letter of each word
    ///       sentences: first letter of each sentence (default)
    ///       none: don't auto capitalize anything
    /// 
    /// <see href="https://facebook.github.io/react-native/docs/textinput.html#autocapitalize" />
    /// </summary>
    abstract autoCapitalize: TextInputPropsAutoCapitalize option with get, set
    /// If false, disables auto-correct.
    /// The default value is true.
    abstract autoCorrect: bool option with get, set
    /// If true, focuses the input on componentDidMount.
    /// The default value is false.
    abstract autoFocus: bool option with get, set
    /// If true, the text field will blur when submitted.
    /// The default value is true.
    abstract blurOnSubmit: bool option with get, set
    /// If true, caret is hidden. The default value is false.
    abstract caretHidden: bool option with get, set
    /// If true, context menu is hidden. The default value is false.
    abstract contextMenuHidden: bool option with get, set
    /// Provides an initial value that will change when the user starts typing.
    /// Useful for simple use-cases where you don't want to deal with listening to events
    /// and updating the value prop to keep the controlled state in sync.
    abstract defaultValue: string option with get, set
    /// If false, text is not editable. The default value is true.
    abstract editable: bool option with get, set
    /// enum("default", 'numeric', 'email-address', "ascii-capable", 'numbers-and-punctuation', 'url', 'number-pad', 'phone-pad', 'name-phone-pad',
    /// 'decimal-pad', 'twitter', 'web-search', 'visible-password')
    /// Determines which keyboard to open, e.g.numeric.
    /// The following values work across platforms: - default - numeric - email-address - phone-pad
    /// The following values work on iOS: - ascii-capable - numbers-and-punctuation - url - number-pad - name-phone-pad - decimal-pad - twitter - web-search
    /// The following values work on Android: - visible-password
    abstract keyboardType: KeyboardTypeOptions option with get, set
    /// Limits the maximum number of characters that can be entered.
    /// Use this instead of implementing the logic in JS to avoid flicker.
    abstract maxLength: float option with get, set
    /// If true, the text input can be multiple lines. The default value is false.
    abstract multiline: bool option with get, set
    /// Callback that is called when the text input is blurred
    abstract onBlur: (NativeSyntheticEvent<TextInputFocusEventData> -> unit) option with get, set
    /// Callback that is called when the text input's text changes.
    abstract onChange: (NativeSyntheticEvent<TextInputChangeEventData> -> unit) option with get, set
    /// Callback that is called when the text input's text changes.
    /// Changed text is passed as an argument to the callback handler.
    abstract onChangeText: (string -> unit) option with get, set
    /// <summary>
    /// Callback that is called when the text input's content size changes.
    /// This will be called with
    /// <c>{ nativeEvent: { contentSize: { width, height } } }</c>.
    /// 
    /// Only called for multiline text inputs.
    /// </summary>
    abstract onContentSizeChange: (NativeSyntheticEvent<TextInputContentSizeChangeEventData> -> unit) option with get, set
    /// Callback that is called when text input ends.
    abstract onEndEditing: (NativeSyntheticEvent<TextInputEndEditingEventData> -> unit) option with get, set
    /// Callback that is called when the text input is focused
    abstract onFocus: (NativeSyntheticEvent<TextInputFocusEventData> -> unit) option with get, set
    /// Callback that is called when the text input selection is changed.
    abstract onSelectionChange: (NativeSyntheticEvent<TextInputSelectionChangeEventData> -> unit) option with get, set
    /// Callback that is called when the text input's submit button is pressed.
    abstract onSubmitEditing: (NativeSyntheticEvent<TextInputSubmitEditingEventData> -> unit) option with get, set
    /// <summary>
    /// Invoked on content scroll with
    ///   <c>{ nativeEvent: { contentOffset: { x, y } } }</c>.
    /// 
    /// May also contain other properties from ScrollEvent but on Android contentSize is not provided for performance reasons.
    /// </summary>
    abstract onScroll: (NativeSyntheticEvent<TextInputScrollEventData> -> unit) option with get, set
    /// <summary>
    /// Callback that is called when a key is pressed.
    /// This will be called with
    ///   <c>{ nativeEvent: { key: keyValue } }</c>
    /// where keyValue is 'Enter' or 'Backspace' for respective keys and the typed-in character otherwise including ' ' for space.
    /// 
    /// Fires before onChange callbacks.
    /// Note: on Android only the inputs from soft keyboard are handled, not the hardware keyboard inputs.
    /// </summary>
    abstract onKeyPress: (NativeSyntheticEvent<TextInputKeyPressEventData> -> unit) option with get, set
    /// The string that will be rendered before text input has been entered
    abstract placeholder: string option with get, set
    /// The text color of the placeholder string
    abstract placeholderTextColor: string option with get, set
    /// enum('default', 'go', 'google', 'join', 'next', 'route', 'search', 'send', 'yahoo', 'done', 'emergency-call')
    /// Determines how the return key should look.
    abstract returnKeyType: ReturnKeyTypeOptions option with get, set
    /// If true, the text input obscures the text entered so that sensitive text like passwords stay secure.
    /// The default value is false.
    abstract secureTextEntry: bool option with get, set
    /// If true, all text will automatically be selected on focus
    abstract selectTextOnFocus: bool option with get, set
    /// The start and end of the text input's selection. Set start and end to
    /// the same value to position the cursor.
    abstract selection: TextInputPropsSelection option with get, set
    /// The highlight (and cursor on ios) color of the text input
    abstract selectionColor: string option with get, set
    /// Styles
    abstract style: StyleProp<TextStyle> option with get, set
    /// Used to locate this view in end-to-end tests
    abstract testID: string option with get, set
    /// <summary>
    /// Used to connect to an InputAccessoryView. Not part of react-natives documentation, but present in examples and
    /// code.
    /// See <see href="https://facebook.github.io/react-native/docs/inputaccessoryview.html" /> for more information.
    /// </summary>
    abstract inputAccessoryViewID: string option with get, set
    /// The value to show for the text input. TextInput is a controlled component,
    /// which means the native value will be forced to match this value prop if provided.
    /// For most uses this works great, but in some cases this may cause flickering - one common cause is preventing edits by keeping value the same.
    /// In addition to simply setting the same value, either set editable={false},
    /// or set/update maxLength to prevent unwanted edits without flicker.
    abstract value: string option with get, set

/// This class is responsible for coordinating the "focused"
/// state for TextInputs. All calls relating to the keyboard
/// should be funneled through here
type [<AllowNullLiteral>] TextInputState =
    /// Returns the ID of the currently focused text field, if one exists
    /// If no text field is focused it returns null
    abstract currentlyFocusedField: unit -> float
    /// <param name="TextInputID">
    /// id of the text field to focus
    /// Focuses the specified text field
    /// noop if the text field was already focused
    /// </param>
    [<Obsolete("")>]
    abstract focusTextInput: ?textFieldID: float -> unit
    /// <param name="textFieldID">
    /// id of the text field to focus
    /// Unfocuses the specified text field
    /// noop if it wasn't focused
    /// </param>
    [<Obsolete("")>]
    abstract blurTextInput: ?textFieldID: float -> unit

/// <seealso href="https://facebook.github.io/react-native/docs/textinput.html#methods" />
type [<AllowNullLiteral>] TextInputComponent =
    inherit React.Component<TextInputProps>

/// <seealso href="https://facebook.github.io/react-native/docs/textinput.html#methods" />
type [<AllowNullLiteral>] TextInputComponentStatic =
    [<EmitConstructor>] abstract Create: unit -> TextInputComponent

type [<AllowNullLiteral>] TextInput =
    inherit TextInputBase
    /// Returns if the input is currently focused.
    abstract isFocused: (unit -> bool) with get, set
    /// Removes all text from the input.
    abstract clear: (unit -> unit) with get, set

type [<AllowNullLiteral>] TextInputStatic =
    [<EmitConstructor>] abstract Create: unit -> TextInput
    /// Access the current focus state.
    abstract State: TextInputState with get, set

type [<AllowNullLiteral>] ToolbarAndroidAction =
    /// title: required, the title of this action
    abstract title: string with get, set
    /// icon: the icon for this action, e.g. require('./some_icon.png')
    abstract icon: ImageURISource option with get, set
    /// show: when to show this action as an icon or hide it in the overflow menu: always, ifRoom or never
    abstract show: ToolbarAndroidActionShow option with get, set
    /// showWithText: boolean, whether to show text alongside the icon or not
    abstract showWithText: bool option with get, set

type [<AllowNullLiteral>] ToolbarAndroidProps =
    inherit ViewProps
    /// <summary>
    /// Sets possible actions on the toolbar as part of the action menu. These are displayed as icons
    /// or text on the right side of the widget. If they don't fit they are placed in an 'overflow'
    /// menu.
    /// 
    /// This property takes an array of objects, where each object has the following keys:
    /// 
    /// * <c>title</c>: **required**, the title of this action
    /// * <c>icon</c>: the icon for this action, e.g. <c>require('./some_icon.png')</c>
    /// * <c>show</c>: when to show this action as an icon or hide it in the overflow menu: <c>always</c>,
    /// <c>ifRoom</c> or <c>never</c>
    /// * <c>showWithText</c>: boolean, whether to show text alongside the icon or not
    /// </summary>
    abstract actions: ResizeArray<ToolbarAndroidAction> option with get, set
    /// Sets the content inset for the toolbar ending edge.
    /// The content inset affects the valid area for Toolbar content other
    /// than the navigation button and menu. Insets define the minimum
    /// margin for these components and can be used to effectively align
    /// Toolbar content along well-known gridlines.
    abstract contentInsetEnd: float option with get, set
    /// Sets the content inset for the toolbar starting edge.
    /// The content inset affects the valid area for Toolbar content
    /// other than the navigation button and menu. Insets define the
    /// minimum margin for these components and can be used to effectively
    /// align Toolbar content along well-known gridlines.
    abstract contentInsetStart: float option with get, set
    /// Sets the toolbar logo.
    abstract logo: ImageURISource option with get, set
    /// Sets the navigation icon.
    abstract navIcon: ImageURISource option with get, set
    /// Callback that is called when an action is selected. The only
    /// argument that is passed to the callback is the position of the
    /// action in the actions array.
    abstract onActionSelected: (float -> unit) option with get, set
    /// Callback called when the icon is selected.
    abstract onIconClicked: (unit -> unit) option with get, set
    /// Sets the overflow icon.
    abstract overflowIcon: ImageURISource option with get, set
    /// Used to set the toolbar direction to RTL.
    /// In addition to this property you need to add
    /// android:supportsRtl="true"
    /// to your application AndroidManifest.xml and then call
    /// setLayoutDirection(LayoutDirection.RTL) in your MainActivity
    /// onCreate method.
    abstract rtl: bool option with get, set
    /// Sets the toolbar subtitle.
    abstract subtitle: string option with get, set
    /// Sets the toolbar subtitle color.
    abstract subtitleColor: string option with get, set
    /// Used to locate this view in end-to-end tests.
    abstract testID: string option with get, set
    /// Sets the toolbar title.
    abstract title: string option with get, set
    /// Sets the toolbar title color.
    abstract titleColor: string option with get, set

/// <summary>
/// React component that wraps the Android-only [<c>Toolbar</c> widget][0]. A Toolbar can display a logo,
/// navigation icon (e.g. hamburger menu), a title &amp; subtitle and a list of actions. The title and
/// subtitle are expanded so the logo and navigation icons are displayed on the left, title and
/// subtitle in the middle and the actions on the right.
/// 
/// If the toolbar has an only child, it will be displayed between the title and actions.
/// 
/// Although the Toolbar supports remote images for the logo, navigation and action icons, this
/// should only be used in DEV mode where <c>require('./some_icon.png')</c> translates into a packager
/// URL. In release mode you should always use a drawable resource for these icons. Using
/// <c>require('./some_icon.png')</c> will do this automatically for you, so as long as you don't
/// explicitly use e.g. <c>{uri: 'http://...'}</c>, you will be good.
/// 
/// [0]: <see href="https://developer.android.com/reference/android/support/v7/widget/Toolbar.html" />
/// </summary>
type [<AllowNullLiteral>] ToolbarAndroidComponent =
    inherit React.Component<ToolbarAndroidProps>

/// <summary>
/// React component that wraps the Android-only [<c>Toolbar</c> widget][0]. A Toolbar can display a logo,
/// navigation icon (e.g. hamburger menu), a title &amp; subtitle and a list of actions. The title and
/// subtitle are expanded so the logo and navigation icons are displayed on the left, title and
/// subtitle in the middle and the actions on the right.
/// 
/// If the toolbar has an only child, it will be displayed between the title and actions.
/// 
/// Although the Toolbar supports remote images for the logo, navigation and action icons, this
/// should only be used in DEV mode where <c>require('./some_icon.png')</c> translates into a packager
/// URL. In release mode you should always use a drawable resource for these icons. Using
/// <c>require('./some_icon.png')</c> will do this automatically for you, so as long as you don't
/// explicitly use e.g. <c>{uri: 'http://...'}</c>, you will be good.
/// 
/// [0]: <see href="https://developer.android.com/reference/android/support/v7/widget/Toolbar.html" />
/// </summary>
type [<AllowNullLiteral>] ToolbarAndroidComponentStatic =
    [<EmitConstructor>] abstract Create: unit -> ToolbarAndroidComponent

type [<AllowNullLiteral>] ToolbarAndroid =
    inherit ToolbarAndroidBase

type [<AllowNullLiteral>] ToolbarAndroidStatic =
    [<EmitConstructor>] abstract Create: unit -> ToolbarAndroid

/// Gesture recognition on mobile devices is much more complicated than web.
/// A touch can go through several phases as the app determines what the user's intention is.
/// For example, the app needs to determine if the touch is scrolling, sliding on a widget, or tapping.
/// This can even change during the duration of a touch. There can also be multiple simultaneous touches.
/// 
/// The touch responder system is needed to allow components to negotiate these touch interactions
/// without any additional knowledge about their parent or child components.
/// This system is implemented in ResponderEventPlugin.js, which contains further details and documentation.
/// 
/// Best Practices
/// Users can feel huge differences in the usability of web apps vs. native, and this is one of the big causes.
/// Every action should have the following attributes:
///       Feedback/highlighting- show the user what is handling their touch, and what will happen when they release the gesture
///       Cancel-ability- when making an action, the user should be able to abort it mid-touch by dragging their finger away
/// 
/// These features make users more comfortable while using an app,
/// because it allows people to experiment and interact without fear of making mistakes.
/// 
/// TouchableHighlight and Touchable*
/// The responder system can be complicated to use.
/// So we have provided an abstract Touchable implementation for things that should be "tappable".
/// This uses the responder system and allows you to easily configure tap interactions declaratively.
/// Use TouchableHighlight anywhere where you would use a button or link on web.
type [<AllowNullLiteral>] GestureResponderHandlers =
    /// Does this view want to become responder on the start of a touch?
    abstract onStartShouldSetResponder: (GestureResponderEvent -> bool) option with get, set
    /// Called for every touch move on the View when it is not the responder: does this view want to "claim" touch responsiveness?
    abstract onMoveShouldSetResponder: (GestureResponderEvent -> bool) option with get, set
    /// If the View returns true and attempts to become the responder, one of the following will happen:
    abstract onResponderEnd: (GestureResponderEvent -> unit) option with get, set
    /// The View is now responding for touch events.
    /// This is the time to highlight and show the user what is happening
    abstract onResponderGrant: (GestureResponderEvent -> unit) option with get, set
    /// Something else is the responder right now and will not release it
    abstract onResponderReject: (GestureResponderEvent -> unit) option with get, set
    /// The user is moving their finger
    abstract onResponderMove: (GestureResponderEvent -> unit) option with get, set
    /// Fired at the end of the touch, ie "touchUp"
    abstract onResponderRelease: (GestureResponderEvent -> unit) option with get, set
    abstract onResponderStart: (GestureResponderEvent -> unit) option with get, set
    /// Something else wants to become responder.
    /// Should this view release the responder? Returning true allows release
    abstract onResponderTerminationRequest: (GestureResponderEvent -> bool) option with get, set
    /// The responder has been taken from the View.
    /// Might be taken by other views after a call to onResponderTerminationRequest,
    /// or might be taken by the OS without asking (happens with control center/ notification center on iOS)
    abstract onResponderTerminate: (GestureResponderEvent -> unit) option with get, set
    /// onStartShouldSetResponder and onMoveShouldSetResponder are called with a bubbling pattern,
    /// where the deepest node is called first.
    /// That means that the deepest component will become responder when multiple Views return true for *ShouldSetResponder handlers.
    /// This is desirable in most cases, because it makes sure all controls and buttons are usable.
    /// 
    /// However, sometimes a parent will want to make sure that it becomes responder.
    /// This can be handled by using the capture phase.
    /// Before the responder system bubbles up from the deepest component,
    /// it will do a capture phase, firing on*ShouldSetResponderCapture.
    /// So if a parent View wants to prevent the child from becoming responder on a touch start,
    /// it should have a onStartShouldSetResponderCapture handler which returns true.
    abstract onStartShouldSetResponderCapture: (GestureResponderEvent -> bool) option with get, set
    /// onStartShouldSetResponder and onMoveShouldSetResponder are called with a bubbling pattern,
    /// where the deepest node is called first.
    /// That means that the deepest component will become responder when multiple Views return true for *ShouldSetResponder handlers.
    /// This is desirable in most cases, because it makes sure all controls and buttons are usable.
    /// 
    /// However, sometimes a parent will want to make sure that it becomes responder.
    /// This can be handled by using the capture phase.
    /// Before the responder system bubbles up from the deepest component,
    /// it will do a capture phase, firing on*ShouldSetResponderCapture.
    /// So if a parent View wants to prevent the child from becoming responder on a touch start,
    /// it should have a onStartShouldSetResponderCapture handler which returns true.
    abstract onMoveShouldSetResponderCapture: (GestureResponderEvent -> bool) option with get, set

/// <seealso href="https://facebook.github.io/react-native/docs/view.html#style" />
/// <seealso href="https://github.com/facebook/react-native/blob/master/Libraries/Components/View/ViewStylePropTypes.js" />
type [<AllowNullLiteral>] ViewStyle =
    inherit FlexStyle
    inherit ShadowStyleIOS
    inherit TransformsStyle
    abstract backfaceVisibility: ViewStyleBackfaceVisibility option with get, set
    abstract backgroundColor: string option with get, set
    abstract borderBottomColor: string option with get, set
    abstract borderBottomEndRadius: float option with get, set
    abstract borderBottomLeftRadius: float option with get, set
    abstract borderBottomRightRadius: float option with get, set
    abstract borderBottomStartRadius: float option with get, set
    abstract borderBottomWidth: float option with get, set
    abstract borderColor: string option with get, set
    abstract borderEndColor: string option with get, set
    abstract borderLeftColor: string option with get, set
    abstract borderLeftWidth: float option with get, set
    abstract borderRadius: float option with get, set
    abstract borderRightColor: string option with get, set
    abstract borderRightWidth: float option with get, set
    abstract borderStartColor: string option with get, set
    abstract borderStyle: ViewStyleBorderStyle option with get, set
    abstract borderTopColor: string option with get, set
    abstract borderTopEndRadius: float option with get, set
    abstract borderTopLeftRadius: float option with get, set
    abstract borderTopRightRadius: float option with get, set
    abstract borderTopStartRadius: float option with get, set
    abstract borderTopWidth: float option with get, set
    abstract borderWidth: float option with get, set
    abstract opacity: float option with get, set
    abstract testID: string option with get, set
    /// <summary>
    /// Sets the elevation of a view, using Android's underlying
    /// <see href="https://developer.android.com/training/material/shadows-clipping.html#Elevation">elevation API</see>.
    /// This adds a drop shadow to the item and affects z-order for overlapping views.
    /// Only supported on Android 5.0+, has no effect on earlier versions.
    /// </summary>
    abstract elevation: float option with get, set

type [<AllowNullLiteral>] ViewPropsIOS =
    /// <summary>A Boolean value indicating whether VoiceOver should ignore the elements within views that are siblings of the receiver.</summary>
    abstract accessibilityViewIsModal: bool option with get, set
    /// <summary>Provides an array of custom actions available for accessibility.</summary>
    abstract accessibilityActions: Array<string> option with get, set
    /// <summary>
    /// When <c>accessible</c> is true, the system will try to invoke this function
    /// when the user performs an accessibility custom action.
    /// </summary>
    abstract onAccessibilityAction: (unit -> unit) option with get, set
    /// Whether this view should be rendered as a bitmap before compositing.
    /// 
    /// On iOS, this is useful for animations and interactions that do not modify this component's dimensions nor its children;
    /// for example, when translating the position of a static view, rasterization allows the renderer to reuse a cached bitmap of a static view
    /// and quickly composite it during each frame.
    /// 
    /// Rasterization incurs an off-screen drawing pass and the bitmap consumes memory.
    /// Test and measure when using this property.
    abstract shouldRasterizeIOS: bool option with get, set

type [<AllowNullLiteral>] ViewPropsAndroid =
    /// Views that are only used to layout their children or otherwise don't draw anything
    /// may be automatically removed from the native hierarchy as an optimization.
    /// Set this property to false to disable this optimization and ensure that this View exists in the native view hierarchy.
    abstract collapsable: bool option with get, set
    /// Whether this view needs to rendered offscreen and composited with an alpha in order to preserve 100% correct colors and blending behavior.
    /// The default (false) falls back to drawing the component and its children
    /// with an alpha applied to the paint used to draw each element instead of rendering the full component offscreen and compositing it back with an alpha value.
    /// This default may be noticeable and undesired in the case where the View you are setting an opacity on
    /// has multiple overlapping elements (e.g. multiple overlapping Views, or text and a background).
    /// 
    /// Rendering offscreen to preserve correct alpha behavior is extremely expensive
    /// and hard to debug for non-native developers, which is why it is not turned on by default.
    /// If you do need to enable this property for an animation,
    /// consider combining it with renderToHardwareTextureAndroid if the view contents are static (i.e. it doesn't need to be redrawn each frame).
    /// If that property is enabled, this View will be rendered off-screen once,
    /// saved in a hardware texture, and then composited onto the screen with an alpha each frame without having to switch rendering targets on the GPU.
    abstract needsOffscreenAlphaCompositing: bool option with get, set
    /// Whether this view should render itself (and all of its children) into a single hardware texture on the GPU.
    /// 
    /// On Android, this is useful for animations and interactions that only modify opacity, rotation, translation, and/or scale:
    /// in those cases, the view doesn't have to be redrawn and display lists don't need to be re-executed. The texture can just be
    /// re-used and re-composited with different parameters. The downside is that this can use up limited video memory, so this prop should be set back to false at the end of the interaction/animation.
    abstract renderToHardwareTextureAndroid: bool option with get, set

type Falsy =
    obj

type [<AllowNullLiteral>] RecursiveArray<'T> =
    inherit Array<U2<'T, RecursiveArray<'T>>>

/// <summary>Keep a brand of 'T' so that calls to <c>StyleSheet.flatten</c> can take <c>RegisteredStyle&lt;T&gt;</c> and return <c>T</c>.</summary>
type [<AllowNullLiteral>] RegisteredStyle<'T> =
    interface end

type StyleProp<'T> =
    U4<'T, RegisteredStyle<'T>, RecursiveArray<U3<'T, RegisteredStyle<'T>, Falsy>>, Falsy>

/// <seealso href="https://facebook.github.io/react-native/docs/accessibility.html#accessibility-properties" />
type [<AllowNullLiteral>] AccessibilityProps =
    inherit AccessibilityPropsAndroid
    inherit AccessibilityPropsIOS
    /// When true, indicates that the view is an accessibility element.
    /// By default, all the touchable elements are accessible.
    abstract accessible: bool option with get, set
    /// Overrides the text that's read by the screen reader when the user interacts with the element. By default, the
    /// label is constructed by traversing all the children and accumulating all the Text nodes separated by space.
    abstract accessibilityLabel: string option with get, set

type [<AllowNullLiteral>] AccessibilityPropsAndroid =
    /// <summary>
    /// In some cases, we also want to alert the end user of the type of selected component (i.e., that it is a “button”).
    /// If we were using native buttons, this would work automatically. Since we are using javascript, we need to
    /// provide a bit more context for TalkBack. To do so, you must specify the ‘accessibilityComponentType’ property
    /// for any UI component. For instances, we support ‘button’, ‘radiobutton_checked’ and ‘radiobutton_unchecked’ and so on.
    /// </summary>
    abstract accessibilityComponentType: AccessibilityPropsAndroidAccessibilityComponentType option with get, set
    /// <summary>
    /// Indicates to accessibility services whether the user should be notified when this view changes.
    /// Works for Android API &gt;= 19 only.
    /// See <see href="http://developer.android.com/reference/android/view/View.html#attr_android:accessibilityLiveRegion" /> for references.
    /// </summary>
    abstract accessibilityLiveRegion: AccessibilityPropsAndroidAccessibilityLiveRegion option with get, set
    /// <summary>
    /// Controls how view is important for accessibility which is if it fires accessibility events
    /// and if it is reported to accessibility services that query the screen.
    /// Works for Android only. See <see href="http://developer.android.com/reference/android/R.attr.html#importantForAccessibility" /> for references.
    /// 
    /// Possible values:
    ///       'auto' - The system determines whether the view is important for accessibility - default (recommended).
    ///       'yes' - The view is important for accessibility.
    ///       'no' - The view is not important for accessibility.
    ///       'no-hide-descendants' - The view is not important for accessibility, nor are any of its descendant views.
    /// </summary>
    abstract importantForAccessibility: AccessibilityPropsAndroidImportantForAccessibility option with get, set

type [<AllowNullLiteral>] AccessibilityPropsIOS =
    /// <summary>
    /// A Boolean value indicating whether the accessibility elements contained within this accessibility element
    /// are hidden to the screen reader.
    /// </summary>
    abstract accessibilityElementsHidden: bool option with get, set
    /// <summary>
    /// Accessibility traits tell a person using VoiceOver what kind of element they have selected.
    /// Is this element a label? A button? A header? These questions are answered by accessibilityTraits.
    /// </summary>
    abstract accessibilityTraits: U2<AccessibilityTrait, ResizeArray<AccessibilityTrait>> option with get, set
    /// <summary>When <c>accessible</c> is true, the system will try to invoke this function when the user performs accessibility tap gesture.</summary>
    abstract onAccessibilityTap: (unit -> unit) option with get, set
    /// <summary>When accessible is true, the system will invoke this function when the user performs the magic tap gesture.</summary>
    abstract onMagicTap: (unit -> unit) option with get, set

type [<StringEnum>] [<RequireQualifiedAccess>] AccessibilityTrait =
    | None
    | Button
    | Link
    | Header
    | Search
    | Image
    | Selected
    | Plays
    | Key
    | Text
    | Summary
    | Disabled
    | FrequentUpdates
    | StartsMedia
    | Adjustable
    | AllowsDirectInteraction
    | PageTurn

/// <seealso href="https://facebook.github.io/react-native/docs/view.html#props" />
type [<AllowNullLiteral>] ViewProps =
    inherit ViewPropsAndroid
    inherit ViewPropsIOS
    inherit GestureResponderHandlers
    inherit Touchable
    inherit AccessibilityProps
    /// This defines how far a touch event can start away from the view.
    /// Typical interface guidelines recommend touch targets that are at least
    /// 30 - 40 points/density-independent pixels. If a Touchable view has
    /// a height of 20 the touchable height can be extended to 40 with
    /// hitSlop={{top: 10, bottom: 10, left: 0, right: 0}}
    /// NOTE The touch area never extends past the parent view bounds and
    /// the Z-index of sibling views always takes precedence if a touch
    /// hits two overlapping views.
    abstract hitSlop: Insets option with get, set
    /// Invoked on mount and layout changes with
    /// 
    /// {nativeEvent: { layout: {x, y, width, height}}}.
    abstract onLayout: (LayoutChangeEvent -> unit) option with get, set
    /// In the absence of auto property, none is much like CSS's none value. box-none is as if you had applied the CSS class:
    /// 
    /// .box-none {
    ///    pointer-events: none;
    /// }
    /// .box-none * {
    ///    pointer-events: all;
    /// }
    /// 
    /// box-only is the equivalent of
    /// 
    /// .box-only {
    ///    pointer-events: all;
    /// }
    /// .box-only * {
    ///    pointer-events: none;
    /// }
    /// 
    /// But since pointerEvents does not affect layout/appearance, and we are already deviating from the spec by adding additional modes,
    /// we opt to not include pointerEvents on style. On some platforms, we would need to implement it as a className anyways. Using style or not is an implementation detail of the platform.
    abstract pointerEvents: ViewPropsPointerEvents option with get, set
    /// This is a special performance property exposed by RCTView and is useful for scrolling content when there are many subviews,
    /// most of which are offscreen. For this property to be effective, it must be applied to a view that contains many subviews that extend outside its bound.
    /// The subviews must also have overflow: hidden, as should the containing view (or one of its superviews).
    abstract removeClippedSubviews: bool option with get, set
    abstract style: StyleProp<ViewStyle> option with get, set
    /// Used to locate this view in end-to-end tests.
    abstract testID: string option with get, set

/// The most fundamental component for building UI, View is a container that supports layout with flexbox, style, some touch handling,
/// and accessibility controls, and is designed to be nested inside other views and to have 0 to many children of any type.
/// View maps directly to the native view equivalent on whatever platform React is running on,
/// whether that is a UIView, <div>, android.view, etc.
type [<AllowNullLiteral>] ViewComponent =
    inherit React.Component<ViewProps>

/// The most fundamental component for building UI, View is a container that supports layout with flexbox, style, some touch handling,
/// and accessibility controls, and is designed to be nested inside other views and to have 0 to many children of any type.
/// View maps directly to the native view equivalent on whatever platform React is running on,
/// whether that is a UIView, <div>, android.view, etc.
type [<AllowNullLiteral>] ViewComponentStatic =
    [<EmitConstructor>] abstract Create: unit -> ViewComponent

type [<AllowNullLiteral>] View =
    inherit ViewBase

type [<AllowNullLiteral>] ViewStatic =
    [<EmitConstructor>] abstract Create: unit -> View
    /// <summary>Is 3D Touch / Force Touch available (i.e. will touch events include <c>force</c>)</summary>
    abstract forceTouchAvailable: bool with get, set

/// <seealso href="https://facebook.github.io/react-native/docs/viewpagerandroid.html#props" />
type [<AllowNullLiteral>] ViewPagerAndroidOnPageScrollEventData =
    abstract position: float with get, set
    abstract offset: float with get, set

type [<AllowNullLiteral>] ViewPagerAndroidOnPageSelectedEventData =
    abstract position: float with get, set

type [<AllowNullLiteral>] ViewPagerAndroidProps =
    inherit ViewProps
    /// <summary>
    /// Index of initial page that should be selected. Use <c>setPage</c> method to
    /// update the page, and <c>onPageSelected</c> to monitor page changes
    /// </summary>
    abstract initialPage: float option with get, set
    /// When false, the content does not scroll.
    /// The default value is true.
    abstract scrollEnabled: bool option with get, set
    /// <summary>
    /// Executed when transitioning between pages (ether because of animation for
    /// the requested page change or when user is swiping/dragging between pages)
    /// The <c>event.nativeEvent</c> object for this callback will carry following data:
    ///   - position - index of first page from the left that is currently visible
    ///   - offset - value from range [0,1) describing stage between page transitions.
    ///     Value x means that (1 - x) fraction of the page at "position" index is
    ///     visible, and x fraction of the next page is visible.
    /// </summary>
    abstract onPageScroll: (NativeSyntheticEvent<ViewPagerAndroidOnPageScrollEventData> -> unit) option with get, set
    /// <summary>
    /// This callback will be called once ViewPager finish navigating to selected page
    /// (when user swipes between pages). The <c>event.nativeEvent</c> object passed to this
    /// callback will have following fields:
    ///   - position - index of page that has been selected
    /// </summary>
    abstract onPageSelected: (NativeSyntheticEvent<ViewPagerAndroidOnPageSelectedEventData> -> unit) option with get, set
    /// Function called when the page scrolling state has changed.
    /// The page scrolling state can be in 3 states:
    /// - idle, meaning there is no interaction with the page scroller happening at the time
    /// - dragging, meaning there is currently an interaction with the page scroller
    /// - settling, meaning that there was an interaction with the page scroller, and the
    ///    page scroller is now finishing it's closing or opening animation
    abstract onPageScrollStateChanged: (ViewPagerAndroidPropsOnPageScrollStateChanged -> unit) option with get, set
    /// Determines whether the keyboard gets dismissed in response to a drag.
    ///    - 'none' (the default), drags do not dismiss the keyboard.
    ///    - 'on-drag', the keyboard is dismissed when a drag begins.
    abstract keyboardDismissMode: ViewPagerAndroidPropsKeyboardDismissMode option with get, set
    /// Blank space to show between pages. This is only visible while scrolling, pages are still
    /// edge-to-edge.
    abstract pageMargin: float option with get, set

type [<AllowNullLiteral>] ViewPagerAndroidComponent =
    inherit React.Component<ViewPagerAndroidProps>

type [<AllowNullLiteral>] ViewPagerAndroidComponentStatic =
    [<EmitConstructor>] abstract Create: unit -> ViewPagerAndroidComponent

type [<AllowNullLiteral>] ViewPagerAndroid =
    inherit ViewPagerAndroidBase
    /// A helper function to scroll to a specific page in the ViewPager.
    /// The transition between pages will be animated.
    abstract setPage: selectedPage: float -> unit
    /// A helper function to scroll to a specific page in the ViewPager.
    /// The transition between pages will *not* be animated.
    abstract setPageWithoutAnimation: selectedPage: float -> unit

type [<AllowNullLiteral>] ViewPagerAndroidStatic =
    [<EmitConstructor>] abstract Create: unit -> ViewPagerAndroid

/// It is a component to solve the common problem of views that need to move out of the way of the virtual keyboard.
/// It can automatically adjust either its position or bottom padding based on the position of the keyboard.
type [<AllowNullLiteral>] KeyboardAvoidingViewComponent =
    inherit React.Component<KeyboardAvoidingViewProps>

/// It is a component to solve the common problem of views that need to move out of the way of the virtual keyboard.
/// It can automatically adjust either its position or bottom padding based on the position of the keyboard.
type [<AllowNullLiteral>] KeyboardAvoidingViewComponentStatic =
    [<EmitConstructor>] abstract Create: unit -> KeyboardAvoidingViewComponent

type [<AllowNullLiteral>] KeyboardAvoidingView =
    inherit KeyboardAvoidingViewBase

type [<AllowNullLiteral>] KeyboardAvoidingViewStatic =
    [<EmitConstructor>] abstract Create: unit -> KeyboardAvoidingView

type [<AllowNullLiteral>] KeyboardAvoidingViewProps =
    inherit ViewProps
    abstract behavior: KeyboardAvoidingViewPropsBehavior option with get, set
    /// The style of the content container(View) when behavior is 'position'.
    abstract contentContainerStyle: StyleProp<ViewStyle> option with get, set
    /// This is the distance between the top of the user screen and the react native view,
    /// may be non-zero in some use cases.
    abstract keyboardVerticalOffset: float option with get, set
    /// Enables or disables the KeyboardAvoidingView.
    /// 
    /// Default is true
    abstract enabled: bool option with get, set

/// //FIXME: No documentation extracted from code comment on WebView.ios.js
type [<AllowNullLiteral>] NavState =
    abstract url: string option with get, set
    abstract title: string option with get, set
    abstract loading: bool option with get, set
    abstract canGoBack: bool option with get, set
    abstract canGoForward: bool option with get, set
    [<EmitIndexer>] abstract Item: key: string -> obj option with get, set

/// Passed data from WebView via window.postMessage.
type [<AllowNullLiteral>] WebViewMessageEventData =
    /// The data sent from a WebView; can only be a string.
    abstract data: string with get, set

type [<AllowNullLiteral>] WebViewPropsAndroid =
    /// Used for android only, JS is enabled by default for WebView on iOS
    abstract javaScriptEnabled: bool option with get, set
    /// Used on Android only, controls whether DOM Storage is enabled
    /// or not android
    abstract domStorageEnabled: bool option with get, set
    /// Sets the user-agent for the WebView.
    abstract userAgent: string option with get, set
    /// Specifies the mixed content mode. i.e WebView will allow a secure origin to load content from any other origin.
    /// Possible values for mixedContentMode are:
    /// 'never' (default) - WebView will not allow a secure origin to load content from an insecure origin.
    /// 'always' - WebView will allow a secure origin to load content from any other origin, even if that origin is insecure.
    /// 'compatibility' - WebView will attempt to be compatible with the approach of a modern web browser with regard to mixed content.
    abstract mixedContentMode: WebViewPropsAndroidMixedContentMode option with get, set
    /// Controls whether form autocomplete data should be saved
    abstract saveFormDataDisabled: bool option with get, set

type [<AllowNullLiteral>] WebViewIOSLoadRequestEvent =
    abstract target: float with get, set
    abstract canGoBack: bool with get, set
    abstract lockIdentifier: float with get, set
    abstract loading: bool with get, set
    abstract title: string with get, set
    abstract canGoForward: bool with get, set
    abstract navigationType: WebViewIOSLoadRequestEventNavigationType with get, set
    abstract url: string with get, set

type [<AllowNullLiteral>] WebViewPropsIOS =
    /// Determines whether HTML5 videos play inline or use the native
    /// full-screen controller. default value false
    /// NOTE : "In order * for video to play inline, not only does
    /// this property need to be set to true, but the video element
    /// in the HTML document must also include the webkit-playsinline
    /// attribute."
    abstract allowsInlineMediaPlayback: bool option with get, set
    /// <summary>
    /// Boolean value that determines whether the web view bounces
    /// when it reaches the edge of the content. The default value is <c>true</c>.
    /// </summary>
    abstract bounces: bool option with get, set
    /// <summary>
    /// Determines the types of data converted to clickable URLs in
    /// the web view’s content. By default only phone numbers are detected.
    /// 
    /// You can provide one type or an array of many types.
    /// 
    /// Possible values for <c>dataDetectorTypes</c> are:
    /// 
    /// - <c>'phoneNumber'</c>
    /// - <c>'link'</c>
    /// - <c>'address'</c>
    /// - <c>'calendarEvent'</c>
    /// - <c>'none'</c>
    /// - <c>'all'</c>
    /// </summary>
    abstract dataDetectorTypes: U2<DataDetectorTypes, ResizeArray<DataDetectorTypes>> option with get, set
    /// A floating-point number that determines how quickly the scroll
    /// view decelerates after the user lifts their finger. You may also
    /// use string shortcuts "normal" and "fast" which match the
    /// underlying iOS settings for UIScrollViewDecelerationRateNormal
    /// and UIScrollViewDecelerationRateFast respectively.
    /// - normal: 0.998 - fast: 0.99 (the default for iOS WebView)
    abstract decelerationRate: U2<float, string> option with get, set
    /// Allows custom handling of any webview requests by a JS handler.
    /// Return true or false from this method to continue loading the
    /// request.
    abstract onShouldStartLoadWithRequest: (WebViewIOSLoadRequestEvent -> bool) option with get, set
    /// <summary>
    /// Boolean value that determines whether scrolling is enabled in the
    /// <c>WebView</c>. The default value is <c>true</c>.
    /// </summary>
    abstract scrollEnabled: bool option with get, set

type [<AllowNullLiteral>] WebViewUriSource =
    abstract uri: string option with get, set
    abstract method: WebViewUriSourceMethod option with get, set
    abstract headers: obj option with get, set
    abstract body: string option with get, set

type [<AllowNullLiteral>] WebViewHtmlSource =
    abstract html: string with get, set
    abstract baseUrl: string option with get, set

type [<AllowNullLiteral>] WebViewNativeConfig =
    abstract ``component``: obj option with get, set
    abstract props: obj option with get, set
    abstract viewManager: obj option with get, set

/// <seealso href="https://facebook.github.io/react-native/docs/webview.html#props" />
type [<AllowNullLiteral>] WebViewProps =
    inherit ViewProps
    inherit WebViewPropsAndroid
    inherit WebViewPropsIOS
    /// <summary>
    /// Controls whether to adjust the content inset for web views that are
    /// placed behind a navigation bar, tab bar, or toolbar. The default value
    /// is <c>true</c>.
    /// </summary>
    abstract automaticallyAdjustContentInsets: bool option with get, set
    /// The amount by which the web view content is inset from the edges of
    /// the scroll view. Defaults to {top: 0, left: 0, bottom: 0, right: 0}.
    abstract contentInset: Insets option with get, set
    [<Obsolete("")>]
    abstract html: string option with get, set
    /// Set this to provide JavaScript that will be injected into the web page
    /// when the view loads.
    abstract injectedJavaScript: string option with get, set
    /// Invoked when load fails
    abstract onError: (NavState -> unit) option with get, set
    /// Invoked when load finish
    abstract onLoad: (NavState -> unit) option with get, set
    /// Invoked when load either succeeds or fails
    abstract onLoadEnd: (NavState -> unit) option with get, set
    /// Invoked on load start
    abstract onLoadStart: (NavState -> unit) option with get, set
    /// Invoked when window.postMessage is called from WebView.
    abstract onMessage: (NativeSyntheticEvent<WebViewMessageEventData> -> unit) option with get, set
    /// <summary>Function that is invoked when the <c>WebView</c> loading starts or ends.</summary>
    abstract onNavigationStateChange: (NavState -> unit) option with get, set
    /// Function that returns a view to show if there's an error.
    abstract renderError: (unit -> React.ReactElement<ViewProps>) option with get, set
    /// Function that returns a loading indicator.
    abstract renderLoading: (unit -> React.ReactElement<ViewProps>) option with get, set
    /// <summary>
    /// Boolean value that forces the <c>WebView</c> to show the loading view
    /// on the first load.
    /// </summary>
    abstract startInLoadingState: bool option with get, set
    abstract style: StyleProp<ViewStyle> option with get, set
    abstract url: string option with get, set
    abstract source: U3<WebViewUriSource, WebViewHtmlSource, float> option with get, set
    /// Determines whether HTML5 audio & videos require the user to tap
    /// before they can start playing. The default value is false.
    abstract mediaPlaybackRequiresUserAction: bool option with get, set
    /// sets whether the webpage scales to fit the view and the user can change the scale
    abstract scalesPageToFit: bool option with get, set
    /// <summary>
    /// List of origin strings to allow being navigated to.
    /// The strings allow wildcards and get matched against just the origin (not the full URL).
    /// If the user taps to navigate to a new page but the new page is not in this whitelist, the URL will be handled by the OS.
    /// The default whitelisted origins are "<see href="http://"" /> and "<see href="https://"." />
    /// </summary>
    abstract originWhitelist: ResizeArray<string> option with get, set
    /// Override the native component used to render the WebView. Enables a custom native
    /// WebView which uses the same JavaScript as the original WebView.
    abstract nativeConfig: WebViewNativeConfig option with get, set

type [<AllowNullLiteral>] WebView =
    inherit React.Component<WebViewProps>
    /// Go back one page in the webview's history.
    abstract goBack: (unit -> unit) with get, set
    /// Go forward one page in the webview's history.
    abstract goForward: (unit -> unit) with get, set
    /// Post a message to the WebView in the form of a string.
    abstract postMessage: (string -> unit) with get, set
    /// Reloads the current page.
    abstract reload: (unit -> unit) with get, set
    /// Stop loading the current page.
    abstract stopLoading: unit -> unit
    /// Returns the native webview node.
    abstract getWebViewHandle: (unit -> obj option) with get, set
    /// Inject JavaScript to be executed immediately.
    abstract injectJavaScript: (string -> unit) with get, set

type [<AllowNullLiteral>] WebViewStatic =
    [<EmitConstructor>] abstract Create: unit -> WebView

/// <seealso href="https://facebook.github.io/react-native/docs/segmentedcontrolios.html" />
/// <seealso cref="SegmentedControlIOS.ios.js" />
type [<AllowNullLiteral>] NativeSegmentedControlIOSChangeEvent =
    abstract value: string with get, set
    abstract selectedSegmentIndex: float with get, set
    abstract target: float with get, set

type [<AllowNullLiteral>] SegmentedControlIOSProps =
    inherit ViewProps
    /// If false the user won't be able to interact with the control. Default value is true.
    abstract enabled: bool option with get, set
    /// If true, then selecting a segment won't persist visually.
    /// The onValueChange callback will still work as expected.
    abstract momentary: bool option with get, set
    /// Callback that is called when the user taps a segment;
    /// passes the event as an argument
    abstract onChange: (NativeSyntheticEvent<NativeSegmentedControlIOSChangeEvent> -> unit) option with get, set
    /// Callback that is called when the user taps a segment; passes the segment's value as an argument
    abstract onValueChange: (string -> unit) option with get, set
    /// The index in props.values of the segment to be (pre)selected.
    abstract selectedIndex: float option with get, set
    /// Accent color of the control.
    abstract tintColor: string option with get, set
    /// The labels for the control's segment buttons, in order.
    abstract values: ResizeArray<string> option with get, set

/// Renders nested content and automatically applies paddings reflect the portion of the view
/// that is not covered by navigation bars, tab bars, toolbars, and other ancestor views.
/// Moreover, and most importantly, Safe Area's paddings feflect physical limitation of the screen,
/// such as rounded corners or camera notches (aka sensor housing area on iPhone X).
type [<AllowNullLiteral>] SafeAreaViewComponent =
    inherit React.Component<ViewProps>

/// Renders nested content and automatically applies paddings reflect the portion of the view
/// that is not covered by navigation bars, tab bars, toolbars, and other ancestor views.
/// Moreover, and most importantly, Safe Area's paddings feflect physical limitation of the screen,
/// such as rounded corners or camera notches (aka sensor housing area on iPhone X).
type [<AllowNullLiteral>] SafeAreaViewComponentStatic =
    [<EmitConstructor>] abstract Create: unit -> SafeAreaViewComponent

type [<AllowNullLiteral>] SafeAreaView =
    inherit SafeAreaViewBase

type [<AllowNullLiteral>] SafeAreaViewStatic =
    [<EmitConstructor>] abstract Create: unit -> SafeAreaView

/// A component which enables customization of the keyboard input accessory view on iOS. The input accessory view is
/// displayed above the keyboard whenever a TextInput has focus. This component can be used to create custom toolbars.
/// 
/// To use this component wrap your custom toolbar with the InputAccessoryView component, and set a nativeID. Then, pass
/// that nativeID as the inputAccessoryViewID of whatever TextInput you desire.
type [<AllowNullLiteral>] InputAccessoryView =
    inherit React.Component<InputAccessoryViewProps>

/// A component which enables customization of the keyboard input accessory view on iOS. The input accessory view is
/// displayed above the keyboard whenever a TextInput has focus. This component can be used to create custom toolbars.
/// 
/// To use this component wrap your custom toolbar with the InputAccessoryView component, and set a nativeID. Then, pass
/// that nativeID as the inputAccessoryViewID of whatever TextInput you desire.
type [<AllowNullLiteral>] InputAccessoryViewStatic =
    [<EmitConstructor>] abstract Create: unit -> InputAccessoryView

type [<AllowNullLiteral>] InputAccessoryViewProps =
    abstract backgroundColor: string option with get, set
    /// An ID which is used to associate this InputAccessoryView to specified TextInput(s).
    abstract nativeID: string option with get, set
    abstract style: StyleProp<ViewStyle> option with get, set

/// <summary>
/// Use <c>SegmentedControlIOS</c> to render a UISegmentedControl iOS.
/// 
/// #### Programmatically changing selected index
/// 
/// The selected index can be changed on the fly by assigning the
/// selectIndex prop to a state variable, then changing that variable.
/// Note that the state variable would need to be updated as the user
/// selects a value and changes the index, as shown in the example below.
/// 
/// <code language="`">
/// &lt;SegmentedControlIOS
///    values={['One', 'Two']}
///    selectedIndex={this.state.selectedIndex}
///    onChange={(event) =&gt; {
///      this.setState({selectedIndex: event.nativeEvent.selectedSegmentIndex});
///    }}
/// /&gt;
/// </code>
/// </summary>
type [<AllowNullLiteral>] SegmentedControlIOSComponent =
    inherit React.Component<SegmentedControlIOSProps>

/// <summary>
/// Use <c>SegmentedControlIOS</c> to render a UISegmentedControl iOS.
/// 
/// #### Programmatically changing selected index
/// 
/// The selected index can be changed on the fly by assigning the
/// selectIndex prop to a state variable, then changing that variable.
/// Note that the state variable would need to be updated as the user
/// selects a value and changes the index, as shown in the example below.
/// 
/// <code language="`">
/// &lt;SegmentedControlIOS
///    values={['One', 'Two']}
///    selectedIndex={this.state.selectedIndex}
///    onChange={(event) =&gt; {
///      this.setState({selectedIndex: event.nativeEvent.selectedSegmentIndex});
///    }}
/// /&gt;
/// </code>
/// </summary>
type [<AllowNullLiteral>] SegmentedControlIOSComponentStatic =
    [<EmitConstructor>] abstract Create: unit -> SegmentedControlIOSComponent

type [<AllowNullLiteral>] SegmentedControlIOS =
    inherit SegmentedControlIOSBase

type [<AllowNullLiteral>] SegmentedControlIOSStatic =
    [<EmitConstructor>] abstract Create: unit -> SegmentedControlIOS

type [<AllowNullLiteral>] NavigatorIOSProps =
    /// The default background color of the navigation bar.
    abstract barTintColor: string option with get, set
    /// NavigatorIOS uses "route" objects to identify child views, their props, and navigation bar configuration.
    /// "push" and all the other navigation operations expect routes to be like this
    abstract initialRoute: Route with get, set
    /// The default wrapper style for components in the navigator.
    /// A common use case is to set the backgroundColor for every page
    abstract itemWrapperStyle: StyleProp<ViewStyle> option with get, set
    /// <summary>
    /// Boolean value that indicates whether the interactive pop gesture is
    /// enabled. This is useful for enabling/disabling the back swipe navigation
    /// gesture.
    /// 
    /// If this prop is not provided, the default behavior is for the back swipe
    /// gesture to be enabled when the navigation bar is shown and disabled when
    /// the navigation bar is hidden. Once you've provided the
    /// <c>interactivePopGestureEnabled</c> prop, you can never restore the default
    /// behavior.
    /// </summary>
    abstract interactivePopGestureEnabled: bool option with get, set
    /// A Boolean value that indicates whether the navigation bar is hidden
    abstract navigationBarHidden: bool option with get, set
    /// A Boolean value that indicates whether to hide the 1px hairline shadow
    abstract shadowHidden: bool option with get, set
    /// The color used for buttons in the navigation bar
    abstract tintColor: string option with get, set
    /// The text color of the navigation bar title
    abstract titleTextColor: string option with get, set
    /// A Boolean value that indicates whether the navigation bar is translucent
    abstract translucent: bool option with get, set
    /// NOT IN THE DOC BUT IN THE EXAMPLES
    abstract style: StyleProp<ViewStyle> option with get, set

/// <summary>
/// A navigator is an object of navigation functions that a view can call.
/// It is passed as a prop to any component rendered by NavigatorIOS.
/// 
/// Navigator functions are also available on the NavigatorIOS component:
/// </summary>
/// <seealso href="https://facebook.github.io/react-native/docs/navigatorios.html#navigator" />
type [<AllowNullLiteral>] NavigatorIOS =
    inherit React.Component<NavigatorIOSProps>
    /// Navigate forward to a new route
    abstract push: (Route -> unit) with get, set
    /// Go back one page
    abstract pop: (unit -> unit) with get, set
    /// Go back N pages at once. When N=1, behavior matches pop()
    abstract popN: (float -> unit) with get, set
    /// Replace the route for the current page and immediately load the view for the new route
    abstract replace: (Route -> unit) with get, set
    /// Replace the route/view for the previous page
    abstract replacePrevious: (Route -> unit) with get, set
    /// Replaces the previous route/view and transitions back to it
    abstract replacePreviousAndPop: (Route -> unit) with get, set
    /// Replaces the top item and popToTop
    abstract resetTo: (Route -> unit) with get, set
    /// Go back to the item for a particular route object
    abstract popToRoute: route: Route -> unit
    /// Go back to the top item
    abstract popToTop: unit -> unit

/// <summary>
/// A navigator is an object of navigation functions that a view can call.
/// It is passed as a prop to any component rendered by NavigatorIOS.
/// 
/// Navigator functions are also available on the NavigatorIOS component:
/// </summary>
/// <seealso href="https://facebook.github.io/react-native/docs/navigatorios.html#navigator" />
type [<AllowNullLiteral>] NavigatorIOSStatic =
    [<EmitConstructor>] abstract Create: unit -> NavigatorIOS

/// <seealso href="https://facebook.github.io/react-native/docs/activityindicator.html#props" />
type [<AllowNullLiteral>] ActivityIndicatorProps =
    inherit ViewProps
    /// Whether to show the indicator (true, the default) or hide it (false).
    abstract animating: bool option with get, set
    /// The foreground color of the spinner (default is gray).
    abstract color: string option with get, set
    /// Whether the indicator should hide when not animating (true by default).
    abstract hidesWhenStopped: bool option with get, set
    /// Size of the indicator.
    /// Small has a height of 20, large has a height of 36.
    /// 
    /// enum('small', 'large')
    abstract size: U2<float, string> option with get, set
    abstract style: StyleProp<ViewStyle> option with get, set

type [<AllowNullLiteral>] ActivityIndicatorComponent =
    inherit React.Component<ActivityIndicatorProps>

type [<AllowNullLiteral>] ActivityIndicatorComponentStatic =
    [<EmitConstructor>] abstract Create: unit -> ActivityIndicatorComponent

type [<AllowNullLiteral>] ActivityIndicator =
    inherit ActivityIndicatorBase

type [<AllowNullLiteral>] ActivityIndicatorStatic =
    [<EmitConstructor>] abstract Create: unit -> ActivityIndicator

/// <seealso href="https://facebook.github.io/react-native/docs/activityindicatorios.html#props" />
type [<AllowNullLiteral>] ActivityIndicatorIOSProps =
    inherit ViewProps
    /// Whether to show the indicator (true, the default) or hide it (false).
    abstract animating: bool option with get, set
    /// The foreground color of the spinner (default is gray).
    abstract color: string option with get, set
    /// Whether the indicator should hide when not animating (true by default).
    abstract hidesWhenStopped: bool option with get, set
    /// Invoked on mount and layout changes with
    abstract onLayout: (ActivityIndicatorIOSPropsOnLayout -> unit) option with get, set
    /// Size of the indicator.
    /// Small has a height of 20, large has a height of 36.
    /// 
    /// enum('small', 'large')
    abstract size: ActivityIndicatorIOSPropsSize option with get, set
    abstract style: StyleProp<ViewStyle> option with get, set

[<Obsolete("since version 0.28.0")>]
type [<AllowNullLiteral>] ActivityIndicatorIOS =
    inherit React.Component<ActivityIndicatorIOSProps>

[<Obsolete("since version 0.28.0")>]
type [<AllowNullLiteral>] ActivityIndicatorIOSStatic =
    [<EmitConstructor>] abstract Create: unit -> ActivityIndicatorIOS

type [<AllowNullLiteral>] DatePickerIOSProps =
    inherit ViewProps
    /// The currently selected date.
    abstract date: DateTime with get, set
    /// The date picker locale.
    abstract locale: string option with get, set
    /// Maximum date.
    /// Restricts the range of possible date/time values.
    abstract maximumDate: DateTime option with get, set
    /// Maximum date.
    /// Restricts the range of possible date/time values.
    abstract minimumDate: DateTime option with get, set
    /// enum(1, 2, 3, 4, 5, 6, 10, 12, 15, 20, 30)
    /// The interval at which minutes can be selected.
    abstract minuteInterval: DatePickerIOSPropsMinuteInterval option with get, set
    /// enum('date', 'time', 'datetime')
    /// The date picker mode.
    abstract mode: DatePickerIOSPropsMode option with get, set
    /// Date change handler.
    /// This is called when the user changes the date or time in the UI.
    /// The first and only argument is a Date object representing the new date and time.
    abstract onDateChange: (DateTime -> unit) with get, set
    /// Timezone offset in minutes.
    /// By default, the date picker will use the device's timezone. With this parameter, it is possible to force a certain timezone offset.
    /// For instance, to show times in Pacific Standard Time, pass -7 * 60.
    abstract timeZoneOffsetInMinutes: float option with get, set

type [<AllowNullLiteral>] DatePickerIOSComponent =
    inherit React.Component<DatePickerIOSProps>

type [<AllowNullLiteral>] DatePickerIOSComponentStatic =
    [<EmitConstructor>] abstract Create: unit -> DatePickerIOSComponent

type [<AllowNullLiteral>] DatePickerIOS =
    inherit DatePickerIOSBase

type [<AllowNullLiteral>] DatePickerIOSStatic =
    [<EmitConstructor>] abstract Create: unit -> DatePickerIOS

type [<AllowNullLiteral>] DrawerSlideEvent =
    inherit NativeSyntheticEvent<NativeTouchEvent>

/// <seealso cref="DrawerLayoutAndroid.android.js" />
type [<AllowNullLiteral>] DrawerLayoutAndroidProps =
    inherit ViewProps
    /// Specifies the background color of the drawer. The default value
    /// is white. If you want to set the opacity of the drawer, use rgba.
    /// Example:
    /// return (
    ///    <DrawerLayoutAndroid drawerBackgroundColor="rgba(0,0,0,0.5)">
    ///    </DrawerLayoutAndroid>
    /// );
    abstract drawerBackgroundColor: string option with get, set
    /// Specifies the lock mode of the drawer. The drawer can be locked
    /// in 3 states:
    /// 
    /// - unlocked (default), meaning that the drawer will respond
    ///    (open/close) to touch gestures.
    /// 
    /// - locked-closed, meaning that the drawer will stay closed and not
    ///    respond to gestures.
    /// 
    /// - locked-open, meaning that the drawer will stay opened and
    ///    not respond to gestures. The drawer may still be opened and
    ///    closed programmatically (openDrawer/closeDrawer).
    abstract drawerLockMode: DrawerLayoutAndroidPropsDrawerLockMode option with get, set
    /// Specifies the side of the screen from which the drawer will slide in.
    /// enum(DrawerLayoutAndroid.positions.Left, DrawerLayoutAndroid.positions.Right)
    abstract drawerPosition: float option with get, set
    /// Specifies the width of the drawer, more precisely the width of the
    /// view that be pulled in from the edge of the window.
    abstract drawerWidth: float option with get, set
    /// Determines whether the keyboard gets dismissed in response to a drag.
    /// - 'none' (the default), drags do not dismiss the keyboard.
    /// - 'on-drag', the keyboard is dismissed when a drag begins.
    abstract keyboardDismissMode: ViewPagerAndroidPropsKeyboardDismissMode option with get, set
    /// Function called whenever the navigation view has been closed.
    abstract onDrawerClose: (unit -> unit) option with get, set
    /// Function called whenever the navigation view has been opened.
    abstract onDrawerOpen: (unit -> unit) option with get, set
    /// Function called whenever there is an interaction with the navigation view.
    abstract onDrawerSlide: (DrawerSlideEvent -> unit) option with get, set
    /// Function called when the drawer state has changed.
    /// The drawer can be in 3 states:
    /// - idle, meaning there is no interaction with the navigation
    ///    view happening at the time
    /// - dragging, meaning there is currently an interaction with the
    ///    navigation view
    /// - settling, meaning that there was an interaction with the
    ///    navigation view, and the navigation view is now finishing
    ///    it's closing or opening animation
    abstract onDrawerStateChanged: (ViewPagerAndroidPropsOnPageScrollStateChanged -> unit) option with get, set
    /// The navigation view that will be rendered to the side of the
    /// screen and can be pulled in.
    abstract renderNavigationView: (unit -> JSX.Element) with get, set
    /// Make the drawer take the entire screen and draw the background of
    /// the status bar to allow it to open over the status bar. It will
    /// only have an effect on API 21+.
    abstract statusBarBackgroundColor: string option with get, set

type [<AllowNullLiteral>] DrawerPosition =
    abstract Left: float with get, set
    abstract Right: float with get, set

type [<AllowNullLiteral>] DrawerLayoutAndroidComponent =
    inherit React.Component<DrawerLayoutAndroidProps>

type [<AllowNullLiteral>] DrawerLayoutAndroidComponentStatic =
    [<EmitConstructor>] abstract Create: unit -> DrawerLayoutAndroidComponent

type [<AllowNullLiteral>] DrawerLayoutAndroid =
    inherit DrawerLayoutAndroidBase
    /// drawer's positions.
    abstract positions: DrawerPosition with get, set
    /// Opens the drawer.
    abstract openDrawer: unit -> unit
    /// Closes the drawer.
    abstract closeDrawer: unit -> unit

type [<AllowNullLiteral>] DrawerLayoutAndroidStatic =
    [<EmitConstructor>] abstract Create: unit -> DrawerLayoutAndroid

/// <seealso cref="PickerIOS.ios.js" />
type [<AllowNullLiteral>] PickerIOSItemProps =
    abstract value: U2<string, float> option with get, set
    abstract label: string option with get, set

/// <seealso cref="PickerIOS.ios.js" />
type [<AllowNullLiteral>] PickerIOSItem =
    inherit React.Component<PickerIOSItemProps>

/// <seealso cref="PickerIOS.ios.js" />
type [<AllowNullLiteral>] PickerIOSItemStatic =
    [<EmitConstructor>] abstract Create: unit -> PickerIOSItem

/// <seealso cref="Picker.js" />
type [<AllowNullLiteral>] PickerItemProps =
    abstract testID: string option with get, set
    abstract color: string option with get, set
    abstract label: string with get, set
    abstract value: obj option with get, set

type [<AllowNullLiteral>] PickerItem =
    inherit React.Component<PickerItemProps>

type [<AllowNullLiteral>] PickerItemStatic =
    [<EmitConstructor>] abstract Create: unit -> PickerItem

type [<AllowNullLiteral>] PickerPropsIOS =
    inherit ViewProps
    /// <summary>Style to apply to each of the item labels.</summary>
    abstract itemStyle: StyleProp<ViewStyle> option with get, set

type [<AllowNullLiteral>] PickerPropsAndroid =
    inherit ViewProps
    /// <summary>
    /// If set to false, the picker will be disabled, i.e. the user will not be able to make a
    /// selection.
    /// </summary>
    abstract enabled: bool option with get, set
    /// <summary>
    /// On Android, specifies how to display the selection items when the user taps on the picker:
    /// 
    ///    - 'dialog': Show a modal dialog. This is the default.
    ///    - 'dropdown': Shows a dropdown anchored to the picker view
    /// </summary>
    abstract mode: PickerPropsAndroidMode option with get, set
    /// <summary>Prompt string for this picker, used on Android in dialog mode as the title of the dialog.</summary>
    abstract prompt: string option with get, set

/// <seealso href="https://facebook.github.io/react-native/docs/picker.html" />
/// <seealso cref="Picker.js" />
type [<AllowNullLiteral>] PickerProps =
    inherit PickerPropsIOS
    inherit PickerPropsAndroid
    /// Callback for when an item is selected. This is called with the
    /// following parameters:
    /// - itemValue: the value prop of the item that was selected
    /// - itemPosition: the index of the selected item in this picker
    abstract onValueChange: (obj option -> float -> unit) option with get, set
    /// Value matching value of one of the items.
    /// Can be a string or an integer.
    abstract selectedValue: obj option with get, set
    abstract style: StyleProp<ViewStyle> option with get, set
    /// Used to locate this view in end-to-end tests.
    abstract testId: string option with get, set

/// <seealso href="https://facebook.github.io/react-native/docs/picker.html" />
/// <seealso cref="Picker.js" />
type [<AllowNullLiteral>] Picker =
    inherit React.Component<PickerProps>

/// <seealso href="https://facebook.github.io/react-native/docs/picker.html" />
/// <seealso cref="Picker.js" />
type [<AllowNullLiteral>] PickerStatic =
    [<EmitConstructor>] abstract Create: unit -> Picker
    /// On Android, display the options in a dialog.
    abstract MODE_DIALOG: string with get, set
    /// On Android, display the options in a dropdown (this is the default).
    abstract MODE_DROPDOWN: string with get, set
    abstract Item: obj with get, set

/// <seealso href="https://facebook.github.io/react-native/docs/pickerios.html" />
/// <seealso cref="PickerIOS.ios.js" />
type [<AllowNullLiteral>] PickerIOSProps =
    inherit ViewProps
    abstract itemStyle: StyleProp<TextStyle> option with get, set
    abstract onValueChange: (U2<string, float> -> unit) option with get, set
    abstract selectedValue: U2<string, float> option with get, set

/// <seealso href="https://facebook.github.io/react-native/docs/pickerios.html" />
/// <seealso cref="PickerIOS.ios.js" />
type [<AllowNullLiteral>] PickerIOSComponent =
    inherit React.Component<PickerIOSProps>

/// <seealso href="https://facebook.github.io/react-native/docs/pickerios.html" />
/// <seealso cref="PickerIOS.ios.js" />
type [<AllowNullLiteral>] PickerIOSComponentStatic =
    [<EmitConstructor>] abstract Create: unit -> PickerIOSComponent

type [<AllowNullLiteral>] PickerIOS =
    inherit PickerIOSBase

type [<AllowNullLiteral>] PickerIOSStatic =
    [<EmitConstructor>] abstract Create: unit -> PickerIOS
    abstract Item: obj with get, set

/// <seealso href="https://facebook.github.io/react-native/docs/progressbarandroid.html" />
/// <seealso cref="ProgressBarAndroid.android.js" />
type [<AllowNullLiteral>] ProgressBarAndroidProps =
    inherit ViewProps
    /// Style of the ProgressBar. One of:
    ///    Horizontal
    ///    Normal (default)
    ///    Small
    ///    Large
    ///    Inverse
    ///    SmallInverse
    ///    LargeInverse
    abstract styleAttr: ProgressBarAndroidPropsStyleAttr option with get, set
    /// If the progress bar will show indeterminate progress.
    /// Note that this can only be false if styleAttr is Horizontal.
    abstract indeterminate: bool option with get, set
    /// The progress value (between 0 and 1).
    abstract progress: float option with get, set
    /// Color of the progress bar.
    abstract color: string option with get, set
    /// Used to locate this view in end-to-end tests.
    abstract testID: string option with get, set

/// <summary>
/// React component that wraps the Android-only <c>ProgressBar</c>. This component is used to indicate
/// that the app is loading or there is some activity in the app.
/// </summary>
type [<AllowNullLiteral>] ProgressBarAndroidComponent =
    inherit React.Component<ProgressBarAndroidProps>

/// <summary>
/// React component that wraps the Android-only <c>ProgressBar</c>. This component is used to indicate
/// that the app is loading or there is some activity in the app.
/// </summary>
type [<AllowNullLiteral>] ProgressBarAndroidComponentStatic =
    [<EmitConstructor>] abstract Create: unit -> ProgressBarAndroidComponent

type [<AllowNullLiteral>] ProgressBarAndroid =
    inherit ProgressBarAndroidBase

type [<AllowNullLiteral>] ProgressBarAndroidStatic =
    [<EmitConstructor>] abstract Create: unit -> ProgressBarAndroid

/// <seealso href="https://facebook.github.io/react-native/docs/progressviewios.html" />
/// <seealso cref="ProgressViewIOS.ios.js" />
type [<AllowNullLiteral>] ProgressViewIOSProps =
    inherit ViewProps
    /// The progress bar style.
    abstract progressViewStyle: ProgressViewIOSPropsProgressViewStyle option with get, set
    /// The progress value (between 0 and 1).
    abstract progress: float option with get, set
    /// The tint color of the progress bar itself.
    abstract progressTintColor: string option with get, set
    /// The tint color of the progress bar track.
    abstract trackTintColor: string option with get, set
    /// A stretchable image to display as the progress bar.
    abstract progressImage: U2<ImageURISource, ResizeArray<ImageURISource>> option with get, set
    /// A stretchable image to display behind the progress bar.
    abstract trackImage: U2<ImageURISource, ResizeArray<ImageURISource>> option with get, set

type [<AllowNullLiteral>] ProgressViewIOSComponent =
    inherit React.Component<ProgressViewIOSProps>

type [<AllowNullLiteral>] ProgressViewIOSComponentStatic =
    [<EmitConstructor>] abstract Create: unit -> ProgressViewIOSComponent

type [<AllowNullLiteral>] ProgressViewIOS =
    inherit ProgressViewIOSBase

type [<AllowNullLiteral>] ProgressViewIOSStatic =
    [<EmitConstructor>] abstract Create: unit -> ProgressViewIOS

type [<AllowNullLiteral>] RefreshControlPropsIOS =
    inherit ViewProps
    /// The color of the refresh indicator.
    abstract tintColor: string option with get, set
    /// The title displayed under the refresh indicator.
    abstract title: string option with get, set
    /// Title color.
    abstract titleColor: string option with get, set

type [<AllowNullLiteral>] RefreshControlPropsAndroid =
    inherit ViewProps
    /// The colors (at least one) that will be used to draw the refresh indicator.
    abstract colors: ResizeArray<string> option with get, set
    /// Whether the pull to refresh functionality is enabled.
    abstract enabled: bool option with get, set
    /// The background color of the refresh indicator.
    abstract progressBackgroundColor: string option with get, set
    /// Size of the refresh indicator, see RefreshControl.SIZE.
    abstract size: float option with get, set
    /// <summary>Progress view top offset</summary>
    abstract progressViewOffset: float option with get, set

type [<AllowNullLiteral>] RefreshControlProps =
    inherit RefreshControlPropsIOS
    inherit RefreshControlPropsAndroid
    /// Called when the view starts refreshing.
    abstract onRefresh: (unit -> unit) option with get, set
    /// Whether the view should be indicating an active refresh.
    abstract refreshing: bool with get, set

/// <summary>
/// This component is used inside a ScrollView or ListView to add pull to refresh
/// functionality. When the ScrollView is at <c>scrollY: 0</c>, swiping down
/// triggers an <c>onRefresh</c> event.
/// 
/// __Note:__ <c>refreshing</c> is a controlled prop, this is why it needs to be set to true
/// in the <c>onRefresh</c> function otherwise the refresh indicator will stop immediately.
/// </summary>
type [<AllowNullLiteral>] RefreshControlComponent =
    inherit React.Component<RefreshControlProps>

/// <summary>
/// This component is used inside a ScrollView or ListView to add pull to refresh
/// functionality. When the ScrollView is at <c>scrollY: 0</c>, swiping down
/// triggers an <c>onRefresh</c> event.
/// 
/// __Note:__ <c>refreshing</c> is a controlled prop, this is why it needs to be set to true
/// in the <c>onRefresh</c> function otherwise the refresh indicator will stop immediately.
/// </summary>
type [<AllowNullLiteral>] RefreshControlComponentStatic =
    [<EmitConstructor>] abstract Create: unit -> RefreshControlComponent

type [<AllowNullLiteral>] RefreshControl =
    inherit RefreshControlBase

type [<AllowNullLiteral>] RefreshControlStatic =
    [<EmitConstructor>] abstract Create: unit -> RefreshControl
    abstract SIZE: Object with get, set

type [<AllowNullLiteral>] RecyclerViewBackedScrollViewProps =
    inherit ScrollViewProps

/// <summary>
/// Wrapper around android native recycler view.
/// 
/// It simply renders rows passed as children in a separate recycler view cells
/// similarly to how <c>ScrollView</c> is doing it. Thanks to the fact that it uses
/// native <c>RecyclerView</c> though, rows that are out of sight are going to be
/// automatically detached (similarly on how this would work with
/// <c>removeClippedSubviews = true</c> on a <c>ScrollView.js</c>).
/// 
/// CAUTION: This is an experimental component and should only be used together
/// with javascript implementation of list view (see ListView.js). In order to
/// use it pass this component as <c>renderScrollComponent</c> to the list view. For
/// now only horizontal scrolling is supported.
/// </summary>
type [<AllowNullLiteral>] RecyclerViewBackedScrollViewComponent =
    inherit React.Component<RecyclerViewBackedScrollViewProps>

/// <summary>
/// Wrapper around android native recycler view.
/// 
/// It simply renders rows passed as children in a separate recycler view cells
/// similarly to how <c>ScrollView</c> is doing it. Thanks to the fact that it uses
/// native <c>RecyclerView</c> though, rows that are out of sight are going to be
/// automatically detached (similarly on how this would work with
/// <c>removeClippedSubviews = true</c> on a <c>ScrollView.js</c>).
/// 
/// CAUTION: This is an experimental component and should only be used together
/// with javascript implementation of list view (see ListView.js). In order to
/// use it pass this component as <c>renderScrollComponent</c> to the list view. For
/// now only horizontal scrolling is supported.
/// </summary>
type [<AllowNullLiteral>] RecyclerViewBackedScrollViewComponentStatic =
    [<EmitConstructor>] abstract Create: unit -> RecyclerViewBackedScrollViewComponent

type [<AllowNullLiteral>] RecyclerViewBackedScrollView =
    inherit RecyclerViewBackedScrollViewBase
    /// A helper function to scroll to a specific point  in the scrollview.
    /// This is currently used to help focus on child textviews, but can also
    /// be used to quickly scroll to any element we want to focus. Syntax:
    /// 
    /// scrollResponderScrollTo(options: {x: number = 0; y: number = 0; animated: boolean = true})
    /// 
    /// Note: The weird argument signature is due to the fact that, for historical reasons,
    /// the function also accepts separate arguments as as alternative to the options object.
    /// This is deprecated due to ambiguity (y before x), and SHOULD NOT BE USED.
    abstract scrollTo: ?y: U2<float, RecyclerViewBackedScrollViewScrollTo> * ?x: float * ?animated: bool -> unit
    /// <summary>
    /// Returns a reference to the underlying scroll responder, which supports
    /// operations like <c>scrollTo</c>. All ScrollView-like components should
    /// implement this method so that they can be composed while providing access
    /// to the underlying scroll responder's methods.
    /// </summary>
    abstract getScrollResponder: unit -> JSX.Element

type [<AllowNullLiteral>] RecyclerViewBackedScrollViewStatic =
    [<EmitConstructor>] abstract Create: unit -> RecyclerViewBackedScrollView

type [<AllowNullLiteral>] SliderPropsAndroid =
    inherit ViewProps
    /// Color of the foreground switch grip.
    abstract thumbTintColor: string option with get, set

type [<AllowNullLiteral>] SliderPropsIOS =
    inherit ViewProps
    /// Assigns a maximum track image. Only static images are supported.
    /// The leftmost pixel of the image will be stretched to fill the track.
    abstract maximumTrackImage: ImageURISource option with get, set
    /// Assigns a minimum track image. Only static images are supported.
    /// The rightmost pixel of the image will be stretched to fill the track.
    abstract minimumTrackImage: ImageURISource option with get, set
    /// Sets an image for the thumb. Only static images are supported.
    abstract thumbImage: ImageURISource option with get, set
    /// Assigns a single image for the track. Only static images
    /// are supported. The center pixel of the image will be stretched
    /// to fill the track.
    abstract trackImage: ImageURISource option with get, set

type [<AllowNullLiteral>] SliderProps =
    inherit SliderPropsIOS
    inherit SliderPropsAndroid
    /// If true the user won't be able to move the slider.
    /// Default value is false.
    abstract disabled: bool option with get, set
    /// The color used for the track to the right of the button.
    /// Overrides the default blue gradient image.
    abstract maximumTrackTintColor: string option with get, set
    /// Initial maximum value of the slider. Default value is 1.
    abstract maximumValue: float option with get, set
    /// The color used for the track to the left of the button.
    /// Overrides the default blue gradient image.
    abstract minimumTrackTintColor: string option with get, set
    /// Initial minimum value of the slider. Default value is 0.
    abstract minimumValue: float option with get, set
    /// Callback called when the user finishes changing the value (e.g. when the slider is released).
    abstract onSlidingComplete: (float -> unit) option with get, set
    /// Callback continuously called while the user is dragging the slider.
    abstract onValueChange: (float -> unit) option with get, set
    /// Step value of the slider. The value should be between 0 and (maximumValue - minimumValue). Default value is 0.
    abstract step: float option with get, set
    /// Used to style and layout the Slider. See StyleSheet.js and ViewStylePropTypes.js for more info.
    abstract style: StyleProp<ViewStyle> option with get, set
    /// Used to locate this view in UI automation tests.
    abstract testID: string option with get, set
    /// Initial value of the slider. The value should be between minimumValue
    /// and maximumValue, which default to 0 and 1 respectively.
    /// Default value is 0.
    /// This is not a controlled component, you don't need to update
    /// the value during dragging.
    abstract value: float option with get, set

/// A component used to select a single value from a range of values.
type [<AllowNullLiteral>] SliderComponent =
    inherit React.Component<SliderProps>

/// A component used to select a single value from a range of values.
type [<AllowNullLiteral>] SliderComponentStatic =
    [<EmitConstructor>] abstract Create: unit -> SliderComponent

type [<AllowNullLiteral>] Slider =
    inherit SliderBase

type [<AllowNullLiteral>] SliderStatic =
    [<EmitConstructor>] abstract Create: unit -> Slider

type SliderIOS =
    Slider

/// <summary><see href="https://facebook.github.io/react-native/docs/switchios.html#props" /></summary>
type [<AllowNullLiteral>] SwitchIOSProps =
    inherit ViewProps
    /// If true the user won't be able to toggle the switch. Default value is false.
    abstract disabled: bool option with get, set
    /// Background color when the switch is turned on.
    abstract onTintColor: string option with get, set
    /// Callback that is called when the user toggles the switch.
    abstract onValueChange: (bool -> unit) option with get, set
    /// Background color for the switch round button.
    abstract thumbTintColor: string option with get, set
    /// Background color when the switch is turned off.
    abstract tintColor: string option with get, set
    /// The value of the switch, if true the switch will be turned on. Default value is false.
    abstract value: bool option with get, set

/// <summary>
/// Use SwitchIOS to render a boolean input on iOS.
/// 
/// This is a controlled component, so you must hook in to the onValueChange callback and update the value prop in order for the component to update,
/// otherwise the user's change will be reverted immediately to reflect props.value as the source of truth.
/// </summary>
/// <seealso href="https://facebook.github.io/react-native/docs/switchios.html" />
type [<AllowNullLiteral>] SwitchIOS =
    inherit React.Component<SwitchIOSProps>

/// <summary>
/// Use SwitchIOS to render a boolean input on iOS.
/// 
/// This is a controlled component, so you must hook in to the onValueChange callback and update the value prop in order for the component to update,
/// otherwise the user's change will be reverted immediately to reflect props.value as the source of truth.
/// </summary>
/// <seealso href="https://facebook.github.io/react-native/docs/switchios.html" />
type [<AllowNullLiteral>] SwitchIOSStatic =
    [<EmitConstructor>] abstract Create: unit -> SwitchIOS

type [<StringEnum>] [<RequireQualifiedAccess>] ImageResizeMode =
    | Cover
    | Contain
    | Stretch
    | Repeat
    | Center

/// <seealso cref="ImageResizeMode.js" />
type [<AllowNullLiteral>] ImageResizeModeStatic =
    /// contain - The image will be resized such that it will be completely
    /// visible, contained within the frame of the View.
    abstract contain: ImageResizeMode with get, set
    /// cover - The image will be resized such that the entire area of the view
    /// is covered by the image, potentially clipping parts of the image.
    abstract cover: ImageResizeMode with get, set
    /// stretch - The image will be stretched to fill the entire frame of the
    /// view without clipping.  This may change the aspect ratio of the image,
    /// distoring it.  Only supported on iOS.
    abstract stretch: ImageResizeMode with get, set
    /// center - The image will be scaled down such that it is completely visible,
    /// if bigger than the area of the view.
    /// The image will not be scaled up.
    abstract center: ImageResizeMode with get, set
    /// repeat - The image will be repeated to cover the frame of the View. The
    /// image will keep it's size and aspect ratio.
    abstract repeat: ImageResizeMode with get, set

type [<AllowNullLiteral>] ShadowStyleIOS =
    abstract shadowColor: string option with get, set
    abstract shadowOffset: ShadowPropTypesIOSStaticShadowOffset option with get, set
    abstract shadowOpacity: float option with get, set
    abstract shadowRadius: float option with get, set

/// <summary>Image style</summary>
/// <seealso href="https://facebook.github.io/react-native/docs/image.html#style" />
/// <seealso href="https://github.com/facebook/react-native/blob/master/Libraries/Image/ImageStylePropTypes.js" />
type [<AllowNullLiteral>] ImageStyle =
    inherit FlexStyle
    inherit ShadowStyleIOS
    inherit TransformsStyle
    abstract resizeMode: ImageResizeMode option with get, set
    abstract backfaceVisibility: ViewStyleBackfaceVisibility option with get, set
    abstract borderBottomLeftRadius: float option with get, set
    abstract borderBottomRightRadius: float option with get, set
    abstract backgroundColor: string option with get, set
    abstract borderColor: string option with get, set
    abstract borderWidth: float option with get, set
    abstract borderRadius: float option with get, set
    abstract borderTopLeftRadius: float option with get, set
    abstract borderTopRightRadius: float option with get, set
    abstract overflow: ViewStyleBackfaceVisibility option with get, set
    abstract overlayColor: string option with get, set
    abstract tintColor: string option with get, set
    abstract opacity: float option with get, set

type [<AllowNullLiteral>] ImageURISource =
    /// <summary>
    /// <c>uri</c> is a string representing the resource identifier for the image, which
    /// could be an http address, a local file path, or the name of a static image
    /// resource (which should be wrapped in the <c>require('./path/to/image.png')</c>
    /// function).
    /// </summary>
    abstract uri: string option with get, set
    /// <summary>
    /// <c>bundle</c> is the iOS asset bundle which the image is included in. This
    /// will default to [NSBundle mainBundle] if not set.
    /// </summary>
    abstract bundle: string option with get, set
    /// <summary><c>method</c> is the HTTP Method to use. Defaults to GET if not specified.</summary>
    abstract method: string option with get, set
    /// <summary>
    /// <c>headers</c> is an object representing the HTTP headers to send along with the
    /// request for a remote image.
    /// </summary>
    abstract headers: ImageURISourceHeaders option with get, set
    /// <summary>
    /// <c>cache</c> determines how the requests handles potentially cached
    /// responses.
    /// 
    /// - <c>default</c>: Use the native platforms default strategy. <c>useProtocolCachePolicy</c> on iOS.
    /// 
    /// - <c>reload</c>: The data for the URL will be loaded from the originating source.
    /// No existing cache data should be used to satisfy a URL load request.
    /// 
    /// - <c>force-cache</c>: The existing cached data will be used to satisfy the request,
    /// regardless of its age or expiration date. If there is no existing data in the cache
    /// corresponding the request, the data is loaded from the originating source.
    /// 
    /// - <c>only-if-cached</c>: The existing cache data will be used to satisfy a request, regardless of
    /// its age or expiration date. If there is no existing data in the cache corresponding
    /// to a URL load request, no attempt is made to load the data from the originating source,
    /// and the load is considered to have failed.
    /// </summary>
    abstract cache: ImageURISourceCache option with get, set
    /// <summary>
    /// <c>body</c> is the HTTP body to send with the request. This must be a valid
    /// UTF-8 string, and will be sent exactly as specified, with no
    /// additional encoding (e.g. URL-escaping or base64) applied.
    /// </summary>
    abstract body: string option with get, set
    /// <summary>
    /// <c>width</c> and <c>height</c> can be specified if known at build time, in which case
    /// these will be used to set the default <c>&lt;Image/&gt;</c> component dimensions.
    /// </summary>
    abstract width: float option with get, set
    abstract height: float option with get, set
    /// <summary>
    /// <c>scale</c> is used to indicate the scale factor of the image. Defaults to 1.0 if
    /// unspecified, meaning that one image pixel equates to one display point / DIP.
    /// </summary>
    abstract scale: float option with get, set

type ImageRequireSource =
    float

/// <seealso cref="ImagePropsIOS.onProgress" />
type [<AllowNullLiteral>] ImageProgressEventDataIOS =
    abstract loaded: float with get, set
    abstract total: float with get, set

type [<AllowNullLiteral>] ImagePropsIOS =
    /// <summary>blurRadius: the blur radius of the blur filter added to the image</summary>
    abstract blurRadius: float option with get, set
    /// When the image is resized, the corners of the size specified by capInsets will stay a fixed size,
    /// but the center content and borders of the image will be stretched.
    /// This is useful for creating resizable rounded buttons, shadows, and other resizable assets.
    /// More info on Apple documentation
    abstract capInsets: Insets option with get, set
    /// Invoked on download progress with {nativeEvent: {loaded, total}}
    abstract onProgress: (NativeSyntheticEvent<ImageProgressEventDataIOS> -> unit) option with get, set
    /// <summary>
    /// Invoked when a partial load of the image is complete. The definition of
    /// what constitutes a "partial load" is loader specific though this is meant
    /// for progressive JPEG loads.
    /// </summary>
    abstract onPartialLoad: (unit -> unit) option with get, set

type [<AllowNullLiteral>] ImagePropsAndroid =
    /// The mechanism that should be used to resize the image when the image's dimensions
    /// differ from the image view's dimensions. Defaults to auto.
    /// 
    /// 'auto': Use heuristics to pick between resize and scale.
    /// 
    /// 'resize': A software operation which changes the encoded image in memory before it gets decoded.
    /// This should be used instead of scale when the image is much larger than the view.
    /// 
    /// 'scale': The image gets drawn downscaled or upscaled. Compared to resize, scale is faster (usually hardware accelerated)
    /// and produces higher quality images. This should be used if the image is smaller than the view.
    /// It should also be used if the image is slightly bigger than the view.
    abstract resizeMethod: ImagePropsAndroidResizeMethod option with get, set
    /// Duration of fade in animation.
    abstract fadeDuration: float option with get, set

/// <seealso href="https://facebook.github.io/react-native/docs/image.html#source" />
type ImageSourcePropType =
    U3<ImageURISource, ResizeArray<ImageURISource>, ImageRequireSource>

/// <seealso cref="ImagePropsBase.onLoad" />
type [<AllowNullLiteral>] ImageLoadEventDataAndroid =
    abstract uri: string option with get, set

type [<AllowNullLiteral>] ImageLoadEventData =
    inherit ImageLoadEventDataAndroid
    abstract source: ImageLoadEventDataSource with get, set

type [<AllowNullLiteral>] ImageErrorEventData =
    abstract error: obj option with get, set

/// <seealso href="https://facebook.github.io/react-native/docs/image.html#resolveassetsource" />
type [<AllowNullLiteral>] ImageResolvedAssetSource =
    abstract height: float with get, set
    abstract width: float with get, set
    abstract scale: float with get, set
    abstract uri: string with get, set

/// <seealso href="https://facebook.github.io/react-native/docs/image.html" />
type [<AllowNullLiteral>] ImagePropsBase =
    inherit ImagePropsIOS
    inherit ImagePropsAndroid
    inherit AccessibilityProps
    /// onLayout function
    /// 
    /// Invoked on mount and layout changes with
    /// 
    /// {nativeEvent: { layout: {x, y, width, height} }}.
    abstract onLayout: (LayoutChangeEvent -> unit) option with get, set
    /// Invoked on load error with {nativeEvent: {error}}
    abstract onError: (NativeSyntheticEvent<ImageErrorEventData> -> unit) option with get, set
    /// Invoked when load completes successfully
    /// { source: { url, height, width } }.
    abstract onLoad: (NativeSyntheticEvent<ImageLoadEventData> -> unit) option with get, set
    /// Invoked when load either succeeds or fails
    abstract onLoadEnd: (unit -> unit) option with get, set
    /// Invoked on load start
    abstract onLoadStart: (unit -> unit) option with get, set
    abstract progressiveRenderingEnabled: bool option with get, set
    abstract borderRadius: float option with get, set
    abstract borderTopLeftRadius: float option with get, set
    abstract borderTopRightRadius: float option with get, set
    abstract borderBottomLeftRadius: float option with get, set
    abstract borderBottomRightRadius: float option with get, set
    /// Determines how to resize the image when the frame doesn't match the raw
    /// image dimensions.
    /// 
    /// 'cover': Scale the image uniformly (maintain the image's aspect ratio)
    /// so that both dimensions (width and height) of the image will be equal
    /// to or larger than the corresponding dimension of the view (minus padding).
    /// 
    /// 'contain': Scale the image uniformly (maintain the image's aspect ratio)
    /// so that both dimensions (width and height) of the image will be equal to
    /// or less than the corresponding dimension of the view (minus padding).
    /// 
    /// 'stretch': Scale width and height independently, This may change the
    /// aspect ratio of the src.
    /// 
    /// 'repeat': Repeat the image to cover the frame of the view.
    /// The image will keep it's size and aspect ratio. (iOS only)
    /// 
    /// 'center': Scale the image down so that it is completely visible,
    /// if bigger than the area of the view.
    /// The image will not be scaled up.
    abstract resizeMode: ImageResizeMode option with get, set
    /// <summary>
    /// The mechanism that should be used to resize the image when the image's dimensions
    /// differ from the image view's dimensions. Defaults to <c>auto</c>.
    /// 
    /// - <c>auto</c>: Use heuristics to pick between <c>resize</c> and <c>scale</c>.
    /// 
    /// - <c>resize</c>: A software operation which changes the encoded image in memory before it
    /// gets decoded. This should be used instead of <c>scale</c> when the image is much larger
    /// than the view.
    /// 
    /// - <c>scale</c>: The image gets drawn downscaled or upscaled. Compared to <c>resize</c>, <c>scale</c> is
    /// faster (usually hardware accelerated) and produces higher quality images. This
    /// should be used if the image is smaller than the view. It should also be used if the
    /// image is slightly bigger than the view.
    /// 
    /// More details about <c>resize</c> and <c>scale</c> can be found at <see href="http://frescolib.org/docs/resizing-rotating.html." />
    /// </summary>
    abstract resizeMethod: ImagePropsAndroidResizeMethod option with get, set
    /// The image source (either a remote URL or a local file resource).
    /// 
    /// This prop can also contain several remote URLs, specified together with their width and height and potentially with scale/other URI arguments.
    /// The native side will then choose the best uri to display based on the measured size of the image container.
    /// A cache property can be added to control how networked request interacts with the local cache.
    /// 
    /// The currently supported formats are png, jpg, jpeg, bmp, gif, webp (Android only), psd (iOS only).
    abstract source: ImageSourcePropType with get, set
    /// <summary>
    /// similarly to <c>source</c>, this property represents the resource used to render
    /// the loading indicator for the image, displayed until image is ready to be
    /// displayed, typically after when it got downloaded from network.
    /// </summary>
    abstract loadingIndicatorSource: ImageURISource option with get, set
    /// A unique identifier for this element to be used in UI Automation testing scripts.
    abstract testID: string option with get, set
    /// A static image to display while downloading the final image off the network.
    abstract defaultSource: U2<ImageURISource, float> option with get, set

type [<AllowNullLiteral>] ImageProps =
    inherit ImagePropsBase
    /// Style
    abstract style: StyleProp<ImageStyle> option with get, set

type [<AllowNullLiteral>] ImageComponent =
    inherit React.Component<ImageProps>

type [<AllowNullLiteral>] ImageComponentStatic =
    [<EmitConstructor>] abstract Create: unit -> ImageComponent

type [<AllowNullLiteral>] Image =
    inherit ImageBase

type [<AllowNullLiteral>] ImageStatic =
    [<EmitConstructor>] abstract Create: unit -> Image
    abstract getSize: uri: string * success: (float -> float -> unit) * failure: (obj option -> unit) -> obj option
    abstract prefetch: url: string -> obj option
    abstract abortPrefetch: requestId: float -> unit
    abstract queryCache: urls: ResizeArray<string> -> Promise<Map<string, ImageStaticQueryCachePromiseMap>>
    /// <seealso href="https://facebook.github.io/react-native/docs/image.html#resolveassetsource" />
    abstract resolveAssetSource: source: ImageSourcePropType -> ImageResolvedAssetSource

type [<AllowNullLiteral>] ImageBackgroundProps =
    inherit ImagePropsBase
    abstract imageStyle: StyleProp<ImageStyle> option with get, set
    abstract style: StyleProp<ViewStyle> option with get, set
    abstract imageRef: image: Image -> unit

type [<AllowNullLiteral>] ImageBackgroundComponent =
    inherit React.Component<ImageBackgroundProps>

type [<AllowNullLiteral>] ImageBackgroundComponentStatic =
    [<EmitConstructor>] abstract Create: unit -> ImageBackgroundComponent

type [<AllowNullLiteral>] ImageBackground =
    inherit ImageBackgroundBase
    abstract resizeMode: ImageResizeMode with get, set
    abstract getSize: uri: string * success: (float -> float -> unit) * failure: (obj option -> unit) -> obj option
    abstract prefetch: url: string -> obj option
    abstract abortPrefetch: requestId: float -> unit
    abstract queryCache: urls: ResizeArray<string> -> Promise<Map<string, ImageStaticQueryCachePromiseMap>>

type [<AllowNullLiteral>] ImageBackgroundStatic =
    [<EmitConstructor>] abstract Create: unit -> ImageBackground

type [<AllowNullLiteral>] ViewToken =
    abstract item: obj option with get, set
    abstract key: string with get, set
    abstract index: float option with get, set
    abstract isViewable: bool with get, set
    abstract section: obj option with get, set

type [<AllowNullLiteral>] ViewabilityConfig =
    /// Minimum amount of time (in milliseconds) that an item must be physically viewable before the
    /// viewability callback will be fired. A high number means that scrolling through content without
    /// stopping will not mark the content as viewable.
    abstract minimumViewTime: float option with get, set
    /// Percent of viewport that must be covered for a partially occluded item to count as
    /// "viewable", 0-100. Fully visible items are always considered viewable. A value of 0 means
    /// that a single pixel in the viewport makes the item viewable, and a value of 100 means that
    /// an item must be either entirely visible or cover the entire viewport to count as viewable.
    abstract viewAreaCoveragePercentThreshold: float option with get, set
    /// <summary>
    /// Similar to <c>viewAreaPercentThreshold</c>, but considers the percent of the item that is visible,
    /// rather than the fraction of the viewable area it covers.
    /// </summary>
    abstract itemVisiblePercentThreshold: float option with get, set
    /// <summary>
    /// Nothing is considered viewable until the user scrolls or <c>recordInteraction</c> is called after
    /// render.
    /// </summary>
    abstract waitForInteraction: bool option with get, set

type [<AllowNullLiteral>] ViewabilityConfigCallbackPair =
    abstract viewabilityConfig: ViewabilityConfig with get, set
    abstract onViewableItemsChanged: (ViewabilityConfigCallbackPairOnViewableItemsChanged -> unit) option with get, set

type ViewabilityConfigCallbackPairs =
    ResizeArray<ViewabilityConfigCallbackPair>

/// <seealso href="https://facebook.github.io/react-native/docs/flatlist.html#props" />
type [<AllowNullLiteral>] ListRenderItemInfo<'ItemT> =
    abstract item: 'ItemT with get, set
    abstract index: float with get, set
    abstract separators: ListRenderItemInfoSeparators with get, set

type [<AllowNullLiteral>] ListRenderItem<'ItemT> =
    [<Emit "$0($1...)">] abstract Invoke: info: ListRenderItemInfo<'ItemT> -> React.ReactElement<obj option> option

type [<AllowNullLiteral>] FlatListProps<'ItemT> =
    inherit VirtualizedListProps<'ItemT>
    /// Rendered in between each item, but not at the top or bottom
    abstract ItemSeparatorComponent: U2<React.ComponentType<obj option>, (unit -> React.ReactElement<obj option>)> option with get, set
    /// Rendered when the list is empty.
    abstract ListEmptyComponent: U3<React.ComponentClass<obj option>, React.ReactElement<obj option>, (unit -> React.ReactElement<obj option>)> option with get, set
    /// Rendered at the very end of the list.
    abstract ListFooterComponent: U3<React.ComponentClass<obj option>, React.ReactElement<obj option>, (unit -> React.ReactElement<obj option>)> option with get, set
    /// Rendered at the very beginning of the list.
    abstract ListHeaderComponent: U3<React.ComponentClass<obj option>, React.ReactElement<obj option>, (unit -> React.ReactElement<obj option>)> option with get, set
    /// Optional custom style for multi-item rows generated when numColumns > 1
    abstract columnWrapperStyle: StyleProp<ViewStyle> option with get, set
    /// When false tapping outside of the focused text input when the keyboard
    /// is up dismisses the keyboard. When true the scroll view will not catch
    /// taps and the keyboard will not dismiss automatically. The default value
    /// is false.
    abstract keyboardShouldPersistTaps: U2<bool, string> option with get, set
    /// For simplicity, data is just a plain array. If you want to use something else,
    /// like an immutable list, use the underlying VirtualizedList directly.
    abstract data: ReadonlyArray<'ItemT> option with get, set
    /// <summary>
    /// A marker property for telling the list to re-render (since it implements PureComponent).
    /// If any of your <c>renderItem</c>, Header, Footer, etc. functions depend on anything outside of the <c>data</c> prop,
    /// stick it here and treat it immutably.
    /// </summary>
    abstract extraData: obj option with get, set
    /// <summary>
    /// <c>getItemLayout</c> is an optional optimization that lets us skip measurement of dynamic
    /// content if you know the height of items a priori. getItemLayout is the most efficient,
    /// and is easy to use if you have fixed height items, for example:
    /// <code>
    /// getItemLayout={(data, index) =&gt; (
    ///    {length: ITEM_HEIGHT, offset: ITEM_HEIGHT * index, index}
    /// )}
    /// </code>
    /// Remember to include separator length (height or width) in your offset calculation if you specify
    /// <c>ItemSeparatorComponent</c>.
    /// </summary>
    abstract getItemLayout: (Array<'ItemT> option -> float -> FlatListPropsGetItemLayout) option with get, set
    /// If true, renders items next to each other horizontally instead of stacked vertically.
    abstract horizontal: bool option with get, set
    /// How many items to render in the initial batch
    abstract initialNumToRender: float option with get, set
    /// Instead of starting at the top with the first item, start at initialScrollIndex
    abstract initialScrollIndex: float option with get, set
    /// <summary>
    /// Used to extract a unique key for a given item at the specified index. Key is used for caching
    /// and as the react key to track item re-ordering. The default extractor checks <c>item.key</c>, then
    /// falls back to using the index, like React does.
    /// </summary>
    abstract keyExtractor: ('ItemT -> float -> string) option with get, set
    abstract legacyImplementation: bool option with get, set
    /// <summary>
    /// Multiple columns can only be rendered with <c>horizontal={false}</c> and will zig-zag like a <c>flexWrap</c> layout.
    /// Items should all be the same height - masonry layouts are not supported.
    /// </summary>
    abstract numColumns: float option with get, set
    /// Called once when the scroll position gets within onEndReachedThreshold of the rendered content.
    abstract onEndReached: (FlatListPropsOnEndReached -> unit) option with get, set
    /// <summary>
    /// How far from the end (in units of visible length of the list) the bottom edge of the
    /// list must be from the end of the content to trigger the <c>onEndReached</c> callback.
    /// Thus a value of 0.5 will trigger <c>onEndReached</c> when the end of the content is
    /// within half the visible length of the list.
    /// </summary>
    abstract onEndReachedThreshold: float option with get, set
    /// If provided, a standard RefreshControl will be added for "Pull to Refresh" functionality.
    /// Make sure to also set the refreshing prop correctly.
    abstract onRefresh: (unit -> unit) option with get, set
    /// <summary>Called when the viewability of rows changes, as defined by the <c>viewablePercentThreshold</c> prop.</summary>
    abstract onViewableItemsChanged: (ViewabilityConfigCallbackPairOnViewableItemsChanged -> unit) option with get, set
    /// Set this true while waiting for new data from a refresh.
    abstract refreshing: bool option with get, set
    /// <summary>
    /// Takes an item from data and renders it into the list. Typical usage:
    /// <code>
    /// _renderItem = ({item}) =&gt; (
    ///    &lt;TouchableOpacity onPress={() =&gt; this._onPress(item)}&gt;
    ///      &lt;Text&gt;{item.title}&lt;/Text&gt;
    ///    &lt;TouchableOpacity/&gt;
    /// );
    /// ...
    /// &lt;FlatList data={[{title: 'Title Text', key: 'item1'}]} renderItem={this._renderItem} /&gt;
    /// </code>
    /// Provides additional metadata like <c>index</c> if you need it.
    /// </summary>
    abstract renderItem: ListRenderItem<'ItemT> with get, set
    /// <summary>See <c>ViewabilityHelper</c> for flow type and further documentation.</summary>
    abstract viewabilityConfig: obj option with get, set
    /// Note: may have bugs (missing content) in some circumstances - use at your own risk.
    /// 
    /// This may improve scroll performance for large lists.
    abstract removeClippedSubviews: bool option with get, set

type [<AllowNullLiteral>] FlatList<'ItemT> =
    inherit React.Component<FlatListProps<'ItemT>>
    /// Exports some data, e.g. for perf investigations or analytics.
    abstract getMetrics: (unit -> FlatListGetMetrics) with get, set
    /// <summary>Scrolls to the end of the content. May be janky without <c>getItemLayout</c> prop.</summary>
    abstract scrollToEnd: ((FlatListScrollToEnd) option -> unit) with get, set
    /// Scrolls to the item at the specified index such that it is positioned in the viewable area
    /// such that viewPosition 0 places it at the top, 1 at the bottom, and 0.5 centered in the middle.
    /// Cannot scroll to locations outside the render window without specifying the getItemLayout prop.
    abstract scrollToIndex: (FlatListScrollToIndex -> unit) with get, set
    /// <summary>
    /// Requires linear scan through data - use <c>scrollToIndex</c> instead if possible.
    /// May be janky without <c>getItemLayout</c> prop.
    /// </summary>
    abstract scrollToItem: (FlatListScrollToItem<'ItemT> -> unit) with get, set
    /// <summary>Scroll to a specific content pixel offset, like a normal <c>ScrollView</c>.</summary>
    abstract scrollToOffset: (FlatListScrollToOffset -> unit) with get, set
    /// Tells the list an interaction has occured, which should trigger viewability calculations,
    /// e.g. if waitForInteractions is true and the user has not scrolled. This is typically called
    /// by taps on items or by navigation actions.
    abstract recordInteraction: (unit -> unit) with get, set

type [<AllowNullLiteral>] FlatListStatic =
    [<EmitConstructor>] abstract Create: unit -> FlatList<'ItemT>

/// <seealso href="https://facebook.github.io/react-native/docs/sectionlist.html" />
type [<AllowNullLiteral>] SectionBase<'ItemT> =
    abstract data: ResizeArray<'ItemT> with get, set
    abstract key: string option with get, set
    abstract renderItem: SectionListRenderItem<'ItemT> option with get, set
    abstract ItemSeparatorComponent: U2<React.ComponentClass<obj option>, (unit -> React.ReactElement<obj option>)> option with get, set
    abstract keyExtractor: ('ItemT -> float -> string) option with get, set

type [<AllowNullLiteral>] SectionListData<'ItemT> =
    inherit SectionBase<'ItemT>
    [<EmitIndexer>] abstract Item: key: string -> obj option with get, set

/// <seealso href="https://facebook.github.io/react-native/docs/sectionlist.html#props" />
type [<AllowNullLiteral>] SectionListRenderItemInfo<'ItemT> =
    inherit ListRenderItemInfo<'ItemT>
    abstract section: SectionListData<'ItemT> with get, set

type [<AllowNullLiteral>] SectionListRenderItem<'ItemT> =
    [<Emit "$0($1...)">] abstract Invoke: info: SectionListRenderItemInfo<'ItemT> -> React.ReactElement<obj option> option

type [<AllowNullLiteral>] SectionListProps<'ItemT> =
    inherit VirtualizedListWithoutRenderItemProps<'ItemT>
    /// Rendered in between adjacent Items within each section.
    abstract ItemSeparatorComponent: React.ComponentType<obj option> option with get, set
    /// Rendered when the list is empty.
    abstract ListEmptyComponent: U3<React.ComponentClass<obj option>, React.ReactElement<obj option>, (unit -> React.ReactElement<obj option>)> option with get, set
    /// Rendered at the very end of the list.
    abstract ListFooterComponent: U2<React.ComponentClass<obj option>, (unit -> React.ReactElement<obj option>)> option with get, set
    /// Rendered at the very beginning of the list.
    abstract ListHeaderComponent: U3<React.ComponentClass<obj option>, React.ReactElement<obj option>, (unit -> React.ReactElement<obj option>)> option with get, set
    /// Rendered in between each section.
    abstract SectionSeparatorComponent: U2<React.ComponentClass<obj option>, (unit -> React.ReactElement<obj option>)> option with get, set
    /// <summary>
    /// A marker property for telling the list to re-render (since it implements PureComponent).
    /// If any of your <c>renderItem</c>, Header, Footer, etc. functions depend on anything outside of the <c>data</c> prop,
    /// stick it here and treat it immutably.
    /// </summary>
    abstract extraData: obj option with get, set
    /// <summary>
    /// <c>getItemLayout</c> is an optional optimization that lets us skip measurement of dynamic
    /// content if you know the height of items a priori. getItemLayout is the most efficient,
    /// and is easy to use if you have fixed height items, for example:
    /// <code>
    /// getItemLayout={(data, index) =&gt; (
    ///    {length: ITEM_HEIGHT, offset: ITEM_HEIGHT * index, index}
    /// )}
    /// </code>
    /// </summary>
    abstract getItemLayout: (ResizeArray<SectionListData<'ItemT>> option -> float -> FlatListPropsGetItemLayout) option with get, set
    /// How many items to render in the initial batch
    abstract initialNumToRender: float option with get, set
    /// Reverses the direction of scroll. Uses scale transforms of -1.
    abstract inverted: bool option with get, set
    /// <summary>
    /// Used to extract a unique key for a given item at the specified index. Key is used for caching
    /// and as the react key to track item re-ordering. The default extractor checks <c>item.key</c>, then
    /// falls back to using the index, like React does.
    /// </summary>
    abstract keyExtractor: ('ItemT -> float -> string) option with get, set
    /// Called once when the scroll position gets within onEndReachedThreshold of the rendered content.
    abstract onEndReached: (FlatListPropsOnEndReached -> unit) option with get, set
    /// <summary>
    /// How far from the end (in units of visible length of the list) the bottom edge of the
    /// list must be from the end of the content to trigger the <c>onEndReached</c> callback.
    /// Thus a value of 0.5 will trigger <c>onEndReached</c> when the end of the content is
    /// within half the visible length of the list.
    /// </summary>
    abstract onEndReachedThreshold: float option with get, set
    /// If provided, a standard RefreshControl will be added for "Pull to Refresh" functionality.
    /// Make sure to also set the refreshing prop correctly.
    abstract onRefresh: (unit -> unit) option with get, set
    /// <summary>
    /// Used to handle failures when scrolling to an index that has not been measured yet.
    /// Recommended action is to either compute your own offset and <c>scrollTo</c> it, or scroll as far
    /// as possible and then try again after more items have been rendered.
    /// </summary>
    abstract onScrollToIndexFailed: (SectionListPropsOnScrollToIndexFailed -> unit) option with get, set
    /// Set this true while waiting for new data from a refresh.
    abstract refreshing: bool option with get, set
    /// Default renderer for every item in every section. Can be over-ridden on a per-section basis.
    abstract renderItem: SectionListRenderItem<'ItemT> option with get, set
    /// Rendered at the top of each section. Sticky headers are not yet supported.
    abstract renderSectionHeader: (SectionListPropsRenderSectionHeader<'ItemT> -> React.ReactElement<obj option> option) option with get, set
    /// Rendered at the bottom of each section.
    abstract renderSectionFooter: (SectionListPropsRenderSectionHeader<'ItemT> -> React.ReactElement<obj option> option) option with get, set
    /// An array of objects with data for each section.
    abstract sections: ResizeArray<SectionListData<'ItemT>> with get, set
    /// <summary>Render a custom scroll component, e.g. with a differently styled <c>RefreshControl</c>.</summary>
    abstract renderScrollComponent: (ScrollViewProps -> React.ReactElement<ScrollViewProps>) option with get, set
    /// Note: may have bugs (missing content) in some circumstances - use at your own risk.
    /// 
    /// This may improve scroll performance for large lists.
    abstract removeClippedSubviews: bool option with get, set
    /// Makes section headers stick to the top of the screen until the next one pushes it off.
    /// Only enabled by default on iOS because that is the platform standard there.
    abstract stickySectionHeadersEnabled: bool option with get, set

type [<AllowNullLiteral>] SectionListScrollParams =
    abstract animated: bool option with get, set
    abstract itemIndex: float with get, set
    abstract sectionIndex: float with get, set
    abstract viewOffset: float option with get, set
    abstract viewPosition: float option with get, set

type [<AllowNullLiteral>] SectionListStatic<'SectionT> =
    inherit React.ComponentClass<SectionListProps<'SectionT>>
    /// Scrolls to the item at the specified sectionIndex and itemIndex (within the section)
    /// positioned in the viewable area such that viewPosition 0 places it at the top
    /// (and may be covered by a sticky header), 1 at the bottom, and 0.5 centered in the middle.
    abstract scrollToLocation: ``params``: SectionListScrollParams -> unit

/// <seealso href="https://facebook.github.io/react-native/docs/virtualizedlist.html#props" />
type [<AllowNullLiteral>] VirtualizedListProps<'ItemT> =
    inherit VirtualizedListWithoutRenderItemProps<'ItemT>
    abstract renderItem: ListRenderItem<'ItemT> with get, set

type [<AllowNullLiteral>] VirtualizedListWithoutRenderItemProps<'ItemT> =
    inherit ScrollViewProps
    /// Rendered when the list is empty. Can be a React Component Class, a render function, or
    /// a rendered element.
    abstract ListEmptyComponent: U3<React.ComponentClass<obj option>, React.ReactElement<obj option>, (unit -> React.ReactElement<obj option>)> option with get, set
    /// Rendered at the bottom of all the items. Can be a React Component Class, a render function, or
    /// a rendered element.
    abstract ListFooterComponent: U3<React.ComponentClass<obj option>, React.ReactElement<obj option>, (unit -> React.ReactElement<obj option>)> option with get, set
    /// Rendered at the top of all the items. Can be a React Component Class, a render function, or
    /// a rendered element.
    abstract ListHeaderComponent: U3<React.ComponentClass<obj option>, React.ReactElement<obj option>, (unit -> React.ReactElement<obj option>)> option with get, set
    /// The default accessor functions assume this is an Array<{key: string}> but you can override
    /// getItem, getItemCount, and keyExtractor to handle any type of index-based data.
    abstract data: obj option with get, set
    /// <summary>
    /// <c>debug</c> will turn on extra logging and visual overlays to aid with debugging both usage and
    /// implementation, but with a significant perf hit.
    /// </summary>
    abstract debug: bool option with get, set
    /// DEPRECATED: Virtualization provides significant performance and memory optimizations, but fully
    /// unmounts react instances that are outside of the render window. You should only need to disable
    /// this for debugging purposes.
    abstract disableVirtualization: bool option with get, set
    /// <summary>
    /// A marker property for telling the list to re-render (since it implements <c>PureComponent</c>). If
    /// any of your <c>renderItem</c>, Header, Footer, etc. functions depend on anything outside of the
    /// <c>data</c> prop, stick it here and treat it immutably.
    /// </summary>
    abstract extraData: obj option with get, set
    /// A generic accessor for extracting an item from any sort of data blob.
    abstract getItem: (obj option -> float -> 'ItemT) option with get, set
    /// Determines how many items are in the data blob.
    abstract getItemCount: (obj option -> float) option with get, set
    abstract getItemLayout: (obj option -> float -> FlatListPropsGetItemLayout) option with get, set
    /// When true the scroll view's children are arranged horizontally in a row
    /// instead of vertically in a column. The default value is false.
    abstract horizontal: bool option with get, set
    /// How many items to render in the initial batch. This should be enough to fill the screen but not
    /// much more. Note these items will never be unmounted as part of the windowed rendering in order
    /// to improve perceived performance of scroll-to-top actions.
    abstract initialNumToRender: float option with get, set
    /// <summary>
    /// Instead of starting at the top with the first item, start at <c>initialScrollIndex</c>. This
    /// disables the "scroll to top" optimization that keeps the first <c>initialNumToRender</c> items
    /// always rendered and immediately renders the items starting at this initial index. Requires
    /// <c>getItemLayout</c> to be implemented.
    /// </summary>
    abstract initialScrollIndex: float option with get, set
    /// Reverses the direction of scroll. Uses scale transforms of -1.
    abstract inverted: bool option with get, set
    abstract keyExtractor: ('ItemT -> float -> string) option with get, set
    abstract listKey: string option with get, set
    /// The maximum number of items to render in each incremental render batch. The more rendered at
    /// once, the better the fill rate, but responsiveness my suffer because rendering content may
    /// interfere with responding to button taps or other interactions.
    abstract maxToRenderPerBatch: float option with get, set
    abstract onEndReached: (FlatListPropsOnEndReached -> unit) option with get, set
    abstract onEndReachedThreshold: float option with get, set
    /// Invoked on mount and layout changes with
    /// 
    /// {nativeEvent: { layout: {x, y, width, height}}}.
    abstract onLayout: (LayoutChangeEvent -> unit) option with get, set
    /// <summary>
    /// If provided, a standard RefreshControl will be added for "Pull to Refresh" functionality. Make
    /// sure to also set the <c>refreshing</c> prop correctly.
    /// </summary>
    abstract onRefresh: (unit -> unit) option with get, set
    /// <summary>
    /// Used to handle failures when scrolling to an index that has not been measured yet.
    /// Recommended action is to either compute your own offset and <c>scrollTo</c> it, or scroll as far
    /// as possible and then try again after more items have been rendered.
    /// </summary>
    abstract onScrollToIndexFailed: (SectionListPropsOnScrollToIndexFailed -> unit) option with get, set
    /// <summary>
    /// Called when the viewability of rows changes, as defined by the
    /// <c>viewabilityConfig</c> prop.
    /// </summary>
    abstract onViewableItemsChanged: (ViewabilityConfigCallbackPairOnViewableItemsChanged -> unit) option with get, set
    /// <summary>Set this when offset is needed for the loading indicator to show correctly.</summary>
    abstract progressViewOffset: float option with get, set
    /// Set this true while waiting for new data from a refresh.
    abstract refreshing: bool option with get, set
    /// Note: may have bugs (missing content) in some circumstances - use at your own risk.
    /// 
    /// This may improve scroll performance for large lists.
    abstract removeClippedSubviews: bool option with get, set
    /// <summary>Render a custom scroll component, e.g. with a differently styled <c>RefreshControl</c>.</summary>
    abstract renderScrollComponent: (ScrollViewProps -> React.ReactElement<ScrollViewProps>) option with get, set
    /// <summary>
    /// Amount of time between low-pri item render batches, e.g. for rendering items quite a ways off
    /// screen. Similar fill rate/responsiveness tradeoff as <c>maxToRenderPerBatch</c>.
    /// </summary>
    abstract updateCellsBatchingPeriod: float option with get, set
    abstract viewabilityConfig: ViewabilityConfig option with get, set
    abstract viewabilityConfigCallbackPairs: ViewabilityConfigCallbackPairs option with get, set
    /// <summary>
    /// Determines the maximum number of items rendered outside of the visible area, in units of
    /// visible lengths. So if your list fills the screen, then <c>windowSize={21}</c> (the default) will
    /// render the visible screen area plus up to 10 screens above and 10 below the viewport. Reducing
    /// this number will reduce memory consumption and may improve performance, but will increase the
    /// chance that fast scrolling may reveal momentary blank areas of unrendered content.
    /// </summary>
    abstract windowSize: float option with get, set

/// <seealso href="https://facebook.github.io/react-native/docs/listview.html#props" />
type [<AllowNullLiteral>] ListViewProps =
    inherit ScrollViewProps
    /// <summary>An instance of <see cref="docs/listviewdatasource.html">ListView.DataSource</see> to use</summary>
    abstract dataSource: ListViewDataSource with get, set
    /// Flag indicating whether empty section headers should be rendered.
    /// In the future release empty section headers will be rendered by
    /// default, and the flag will be deprecated. If empty sections are not
    /// desired to be rendered their indices should be excluded from
    /// sectionID object.
    abstract enableEmptySections: bool option with get, set
    /// How many rows to render on initial component mount.  Use this to make
    /// it so that the first screen worth of data apears at one time instead of
    /// over the course of multiple frames.
    abstract initialListSize: float option with get, set
    /// <summary>
    /// (visibleRows, changedRows) =&gt; void
    /// 
    /// Called when the set of visible rows changes.  <c>visibleRows</c> maps
    /// { sectionID: { rowID: true }} for all the visible rows, and
    /// <c>changedRows</c> maps { sectionID: { rowID: true | false }} for the rows
    /// that have changed their visibility, with true indicating visible, and
    /// false indicating the view has moved out of view.
    /// </summary>
    abstract onChangeVisibleRows: (Array<ListViewPropsOnChangeVisibleRowsArray> -> Array<ListViewPropsOnChangeVisibleRowsArray> -> unit) option with get, set
    /// Called when all rows have been rendered and the list has been scrolled
    /// to within onEndReachedThreshold of the bottom.  The native scroll
    /// event is provided.
    abstract onEndReached: (unit -> unit) option with get, set
    /// Threshold in pixels for onEndReached.
    abstract onEndReachedThreshold: float option with get, set
    /// Number of rows to render per event loop.
    abstract pageSize: float option with get, set
    /// A performance optimization for improving scroll perf of
    /// large lists, used in conjunction with overflow: 'hidden' on the row
    /// containers.  Use at your own risk.
    abstract removeClippedSubviews: bool option with get, set
    /// () => renderable
    /// 
    /// The header and footer are always rendered (if these props are provided)
    /// on every render pass.  If they are expensive to re-render, wrap them
    /// in StaticContainer or other mechanism as appropriate.  Footer is always
    /// at the bottom of the list, and header at the top, on every render pass.
    abstract renderFooter: (unit -> React.ReactElement<obj option>) option with get, set
    /// () => renderable
    /// 
    /// The header and footer are always rendered (if these props are provided)
    /// on every render pass.  If they are expensive to re-render, wrap them
    /// in StaticContainer or other mechanism as appropriate.  Footer is always
    /// at the bottom of the list, and header at the top, on every render pass.
    abstract renderHeader: (unit -> React.ReactElement<obj option>) option with get, set
    /// (rowData, sectionID, rowID) => renderable
    /// Takes a data entry from the data source and its ids and should return
    /// a renderable component to be rendered as the row.  By default the data
    /// is exactly what was put into the data source, but it's also possible to
    /// provide custom extractors.
    abstract renderRow: (obj option -> U2<string, float> -> U2<string, float> -> (bool) option -> React.ReactElement<obj option>) with get, set
    /// A function that returns the scrollable component in which the list rows are rendered.
    /// Defaults to returning a ScrollView with the given props.
    abstract renderScrollComponent: (ScrollViewProps -> React.ReactElement<ScrollViewProps>) option with get, set
    /// (sectionData, sectionID) => renderable
    /// 
    /// If provided, a sticky header is rendered for this section.  The sticky
    /// behavior means that it will scroll with the content at the top of the
    /// section until it reaches the top of the screen, at which point it will
    /// stick to the top until it is pushed off the screen by the next section
    /// header.
    abstract renderSectionHeader: (obj option -> U2<string, float> -> React.ReactElement<obj option>) option with get, set
    /// (sectionID, rowID, adjacentRowHighlighted) => renderable
    /// If provided, a renderable component to be rendered as the separator below each row
    /// but not the last row if there is a section header below.
    /// Take a sectionID and rowID of the row above and whether its adjacent row is highlighted.
    abstract renderSeparator: (U2<string, float> -> U2<string, float> -> (bool) option -> React.ReactElement<obj option>) option with get, set
    /// How early to start rendering rows before they come on screen, in
    /// pixels.
    abstract scrollRenderAheadDistance: float option with get, set
    /// <summary>
    /// An array of child indices determining which children get docked to the
    /// top of the screen when scrolling. For example, passing
    /// <c>stickyHeaderIndices={[0]}</c> will cause the first child to be fixed to the
    /// top of the scroll view. This property is not supported in conjunction
    /// with <c>horizontal={true}</c>.
    /// </summary>
    abstract stickyHeaderIndices: ResizeArray<float> option with get, set
    /// <summary>
    /// Makes the sections headers sticky. The sticky behavior means that it will scroll with the
    /// content at the top of the section until it reaches the top of the screen, at which point it
    /// will stick to the top until it is pushed off the screen by the next section header. This
    /// property is not supported in conjunction with <c>horizontal={true}</c>. Only enabled by default
    /// on iOS because of typical platform standards.
    /// </summary>
    abstract stickySectionHeadersEnabled: bool option with get, set

type [<AllowNullLiteral>] TimerMixin =
    abstract setTimeout: obj with get, set
    abstract clearTimeout: obj with get, set
    abstract setInterval: obj with get, set
    abstract clearInterval: obj with get, set
    abstract setImmediate: obj with get, set
    abstract clearImmediate: obj with get, set
    abstract requestAnimationFrame: obj with get, set
    abstract cancelAnimationFrame: obj with get, set

type [<AllowNullLiteral>] ListViewComponent =
    inherit React.Component<ListViewProps>

type [<AllowNullLiteral>] ListViewComponentStatic =
    [<EmitConstructor>] abstract Create: unit -> ListViewComponent

type [<AllowNullLiteral>] ListView =
    inherit ListViewBase
    /// Exports some data, e.g. for perf investigations or analytics.
    abstract getMetrics: (unit -> FlatListGetMetrics) with get, set
    /// Provides a handle to the underlying scroll responder.
    abstract getScrollResponder: (unit -> obj option) with get, set
    /// <summary>
    /// Scrolls to a given x, y offset, either immediately or with a smooth animation.
    /// 
    /// See <c>ScrollView#scrollTo</c>.
    /// </summary>
    abstract scrollTo: ((U2<float, RecyclerViewBackedScrollViewScrollTo>) option -> (float) option -> (bool) option -> unit) with get, set

type [<AllowNullLiteral>] ListViewStatic =
    [<EmitConstructor>] abstract Create: unit -> ListView
    abstract DataSource: ListViewDataSource with get, set

type [<AllowNullLiteral>] MapViewAnnotation =
    abstract latitude: float with get, set
    abstract longitude: float with get, set
    abstract animateDrop: bool option with get, set
    abstract draggable: bool option with get, set
    abstract onDragStateChange: (unit -> obj option) option with get, set
    abstract onFocus: (unit -> obj option) option with get, set
    abstract onBlur: (unit -> obj option) option with get, set
    abstract title: string option with get, set
    abstract subtitle: string option with get, set
    abstract leftCalloutView: React.ReactElement<obj option> option with get, set
    abstract rightCalloutView: React.ReactElement<obj option> option with get, set
    abstract detailCalloutView: React.ReactElement<obj option> option with get, set
    abstract tintColor: string option with get, set
    abstract image: ImageURISource option with get, set
    abstract view: React.ReactElement<obj option> option with get, set
    abstract hasLeftCallout: bool option with get, set
    abstract hasRightCallout: bool option with get, set
    abstract onLeftCalloutPress: (unit -> unit) option with get, set
    abstract onRightCalloutPress: (unit -> unit) option with get, set
    abstract id: string option with get, set

type [<AllowNullLiteral>] MapViewRegion =
    abstract latitude: float with get, set
    abstract longitude: float with get, set
    abstract latitudeDelta: float option with get, set
    abstract longitudeDelta: float option with get, set

type [<AllowNullLiteral>] MapViewOverlay =
    abstract coordinates: ResizeArray<MapViewOverlayCoordinates> with get, set
    abstract lineWidth: float option with get, set
    abstract strokeColor: string option with get, set
    abstract fillColor: string option with get, set
    abstract id: string option with get, set

type [<AllowNullLiteral>] MapViewProps =
    inherit ViewProps
    /// If false points of interest won't be displayed on the map.
    /// Default value is true.
    abstract showsPointsOfInterest: bool option with get, set
    /// Map annotations with title/subtitle.
    abstract annotations: ResizeArray<MapViewAnnotation> option with get, set
    /// If true the map will follow the user's location whenever it changes.
    /// Note that this has no effect unless showsUserLocation is enabled.
    /// Default value is true.
    abstract followUserLocation: bool option with get, set
    /// Insets for the map's legal label, originally at bottom left of the map. See EdgeInsetsPropType.js for more information.
    abstract legalLabelInsets: Insets option with get, set
    /// The map type to be displayed.
    ///      standard: standard road map (default)
    ///      satellite: satellite view
    ///      hybrid: satellite view with roads and points of interest overlayed
    /// 
    /// enum('standard', 'satellite', 'hybrid')
    abstract mapType: MapViewPropsMapType option with get, set
    /// Maximum size of area that can be displayed.
    abstract maxDelta: float option with get, set
    /// Minimum size of area that can be displayed.
    abstract minDelta: float option with get, set
    /// Map overlays
    abstract overlays: ResizeArray<MapViewOverlay> option with get, set
    /// If false compass won't be displayed on the map.
    /// Default value is true.
    abstract showsCompass: bool option with get, set
    /// Callback that is called once, when the user taps an annotation.
    abstract onAnnotationPress: (unit -> unit) option with get, set
    /// Callback that is called continuously when the user is dragging the map.
    abstract onRegionChange: (MapViewRegion -> unit) option with get, set
    /// Callback that is called once, when the user is done moving the map.
    abstract onRegionChangeComplete: (MapViewRegion -> unit) option with get, set
    /// When this property is set to true and a valid camera is associated with the map,
    /// the camera’s pitch angle is used to tilt the plane of the map.
    /// 
    /// When this property is set to false, the camera’s pitch angle is ignored and
    /// the map is always displayed as if the user is looking straight down onto it.
    abstract pitchEnabled: bool option with get, set
    /// The region to be displayed by the map.
    /// The region is defined by the center coordinates and the span of coordinates to display.
    abstract region: MapViewRegion option with get, set
    /// When this property is set to true and a valid camera is associated with the map,
    /// the camera’s heading angle is used to rotate the plane of the map around its center point.
    /// 
    /// When this property is set to false, the camera’s heading angle is ignored and the map is always oriented
    /// so that true north is situated at the top of the map view
    abstract rotateEnabled: bool option with get, set
    /// If false the user won't be able to change the map region being displayed.
    /// Default value is true.
    abstract scrollEnabled: bool option with get, set
    /// If true the app will ask for the user's location and focus on it.
    /// Default value is false.
    /// 
    /// NOTE: You need to add NSLocationWhenInUseUsageDescription key in Info.plist to enable geolocation,
    /// otherwise it is going to fail silently!
    abstract showsUserLocation: bool option with get, set
    /// Used to style and layout the MapView.
    /// See StyleSheet.js and ViewStylePropTypes.js for more info.
    abstract style: StyleProp<ViewStyle> option with get, set
    /// If false the user won't be able to pinch/zoom the map.
    /// Default value is true.
    abstract zoomEnabled: bool option with get, set

/// <seealso href="https://facebook.github.io/react-native/docs/mapview.html#content" />
type [<AllowNullLiteral>] MapViewComponent =
    inherit React.Component<MapViewProps>

/// <seealso href="https://facebook.github.io/react-native/docs/mapview.html#content" />
type [<AllowNullLiteral>] MapViewComponentStatic =
    [<EmitConstructor>] abstract Create: unit -> MapViewComponent

type [<AllowNullLiteral>] MapView =
    inherit MapViewBase

type [<AllowNullLiteral>] MapViewStatic =
    [<EmitConstructor>] abstract Create: unit -> MapView
    abstract PinColors: MapViewStaticPinColors with get, set

type [<AllowNullLiteral>] MaskedViewIOSProps =
    inherit ViewProps
    abstract maskElement: React.ReactElement<obj option> with get, set

/// <seealso href="https://facebook.github.io/react-native/docs/maskedviewios.html" />
type [<AllowNullLiteral>] MaskedViewComponent =
    inherit React.Component<MaskedViewIOSProps>

/// <seealso href="https://facebook.github.io/react-native/docs/maskedviewios.html" />
type [<AllowNullLiteral>] MaskedViewComponentStatic =
    [<EmitConstructor>] abstract Create: unit -> MaskedViewComponent

type [<AllowNullLiteral>] MaskedViewIOS =
    inherit MaskedViewBase

type [<AllowNullLiteral>] MaskedViewIOSStatic =
    [<EmitConstructor>] abstract Create: unit -> MaskedViewIOS

type [<AllowNullLiteral>] ModalBaseProps =
    abstract animated: bool option with get, set
    /// <summary>
    /// The <c>animationType</c> prop controls how the modal animates.
    /// 
    /// - <c>slide</c> slides in from the bottom
    /// - <c>fade</c> fades into view
    /// - <c>none</c> appears without an animation
    /// </summary>
    abstract animationType: ModalBasePropsAnimationType option with get, set
    /// <summary>
    /// The <c>transparent</c> prop determines whether your modal will fill the entire view.
    /// Setting this to <c>true</c> will render the modal over a transparent background.
    /// </summary>
    abstract transparent: bool option with get, set
    /// <summary>The <c>visible</c> prop determines whether your modal is visible.</summary>
    abstract visible: bool option with get, set
    /// <summary>
    /// The <c>onRequestClose</c> prop allows passing a function that will be called once the modal has been dismissed.
    /// _On the Android platform, this is a required function._
    /// </summary>
    abstract onRequestClose: (unit -> unit) option with get, set
    /// <summary>The <c>onShow</c> prop allows passing a function that will be called once the modal has been shown.</summary>
    abstract onShow: (NativeSyntheticEvent<obj option> -> unit) option with get, set

type [<AllowNullLiteral>] ModalPropsIOS =
    /// <summary>The <c>presentationStyle</c> determines the style of modal to show</summary>
    abstract presentationStyle: ModalPropsIOSPresentationStyle option with get, set
    /// <summary>
    /// The <c>supportedOrientations</c> prop allows the modal to be rotated to any of the specified orientations.
    /// On iOS, the modal is still restricted by what's specified in your app's Info.plist's UISupportedInterfaceOrientations field.
    /// </summary>
    abstract supportedOrientations: Array<ModalPropsIOSSupportedOrientationsArray> option with get, set
    /// <summary>The <c>onDismiss</c> prop allows passing a function that will be called once the modal has been dismissed.</summary>
    abstract onDismiss: (unit -> unit) option with get, set
    /// <summary>
    /// The <c>onOrientationChange</c> callback is called when the orientation changes while the modal is being displayed.
    /// The orientation provided is only 'portrait' or 'landscape'. This callback is also called on initial render, regardless of the current orientation.
    /// </summary>
    abstract onOrientationChange: (NativeSyntheticEvent<obj option> -> unit) option with get, set

type [<AllowNullLiteral>] ModalPropsAndroid =
    /// Controls whether to force hardware acceleration for the underlying window.
    abstract hardwareAccelerated: bool option with get, set

type [<AllowNullLiteral>] ModalProps =
    interface end

type [<AllowNullLiteral>] Modal =
    inherit React.Component<ModalProps>

type [<AllowNullLiteral>] ModalStatic =
    [<EmitConstructor>] abstract Create: unit -> Modal

/// <seealso href="https://github.com/facebook/react-native/blob/0.34-stable\Libraries\Components\Touchable\Touchable.js" />
type [<AllowNullLiteral>] TouchableMixin =
    /// <summary>
    /// Invoked when the item should be highlighted. Mixers should implement this
    /// to visually distinguish the <c>VisualRect</c> so that the user knows that
    /// releasing a touch will result in a "selection" (analog to click).
    /// </summary>
    abstract touchableHandleActivePressIn: e: GestureResponderEvent -> unit
    /// <summary>
    /// Invoked when the item is "active" (in that it is still eligible to become
    /// a "select") but the touch has left the <c>PressRect</c>. Usually the mixer will
    /// want to unhighlight the <c>VisualRect</c>. If the user (while pressing) moves
    /// back into the <c>PressRect</c> <c>touchableHandleActivePressIn</c> will be invoked
    /// again and the mixer should probably highlight the <c>VisualRect</c> again. This
    /// event will not fire on an <c>touchEnd/mouseUp</c> event, only move events while
    /// the user is depressing the mouse/touch.
    /// </summary>
    abstract touchableHandleActivePressOut: e: GestureResponderEvent -> unit
    /// <summary>
    /// Invoked when the item is "selected" - meaning the interaction ended by
    /// letting up while the item was either in the state
    /// <c>RESPONDER_ACTIVE_PRESS_IN</c> or <c>RESPONDER_INACTIVE_PRESS_IN</c>.
    /// </summary>
    abstract touchableHandlePress: e: GestureResponderEvent -> unit
    /// <summary>
    /// Invoked when the item is long pressed - meaning the interaction ended by
    /// letting up while the item was in <c>RESPONDER_ACTIVE_LONG_PRESS_IN</c>. If
    /// <c>touchableHandleLongPress</c> is *not* provided, <c>touchableHandlePress</c> will
    /// be called as it normally is. If <c>touchableHandleLongPress</c> is provided, by
    /// default any <c>touchableHandlePress</c> callback will not be invoked. To
    /// override this default behavior, override <c>touchableLongPressCancelsPress</c>
    /// to return false. As a result, <c>touchableHandlePress</c> will be called when
    /// lifting up, even if <c>touchableHandleLongPress</c> has also been called.
    /// </summary>
    abstract touchableHandleLongPress: e: GestureResponderEvent -> unit
    /// <summary>
    /// Returns the amount to extend the <c>HitRect</c> into the <c>PressRect</c>. Positive
    /// numbers mean the size expands outwards.
    /// </summary>
    abstract touchableGetPressRectOffset: unit -> Insets
    /// Returns the number of millis to wait before triggering a highlight.
    abstract touchableGetHighlightDelayMS: unit -> float
    abstract touchableGetLongPressDelayMS: unit -> float
    abstract touchableGetPressOutDelayMS: unit -> float
    abstract touchableGetHitSlop: unit -> Insets

/// <seealso href="https://facebook.github.io/react-native/docs/touchablewithoutfeedback.html#props" />
type [<AllowNullLiteral>] TouchableWithoutFeedbackProps =
    inherit AccessibilityProps
    /// Delay in ms, from onPressIn, before onLongPress is called.
    abstract delayLongPress: float option with get, set
    /// Delay in ms, from the start of the touch, before onPressIn is called.
    abstract delayPressIn: float option with get, set
    /// Delay in ms, from the release of the touch, before onPressOut is called.
    abstract delayPressOut: float option with get, set
    /// If true, disable all interactions for this component.
    abstract disabled: bool option with get, set
    /// This defines how far your touch can start away from the button.
    /// This is added to pressRetentionOffset when moving off of the button.
    /// NOTE The touch area never extends past the parent view bounds and
    /// the Z-index of sibling views always takes precedence if a touch hits
    /// two overlapping views.
    abstract hitSlop: Insets option with get, set
    /// Invoked on mount and layout changes with
    /// {nativeEvent: {layout: {x, y, width, height}}}
    abstract onLayout: (LayoutChangeEvent -> unit) option with get, set
    abstract onLongPress: (GestureResponderEvent -> unit) option with get, set
    /// Called when the touch is released,
    /// but not if cancelled (e.g. by a scroll that steals the responder lock).
    abstract onPress: (GestureResponderEvent -> unit) option with get, set
    abstract onPressIn: (GestureResponderEvent -> unit) option with get, set
    abstract onPressOut: (GestureResponderEvent -> unit) option with get, set
    /// //FIXME: not in doc but available in examples
    abstract style: StyleProp<ViewStyle> option with get, set
    /// When the scroll view is disabled, this defines how far your
    /// touch may move off of the button, before deactivating the button.
    /// Once deactivated, try moving it back and you'll see that the button
    /// is once again reactivated! Move it back and forth several times
    /// while the scroll view is disabled. Ensure you pass in a constant
    /// to reduce memory allocations.
    abstract pressRetentionOffset: Insets option with get, set
    /// Used to locate this view in end-to-end tests.
    abstract testID: string option with get, set

/// <summary>
/// Do not use unless you have a very good reason.
/// All the elements that respond to press should have a visual feedback when touched.
/// This is one of the primary reason a "web" app doesn't feel "native".
/// </summary>
/// <seealso href="https://facebook.github.io/react-native/docs/touchablewithoutfeedback.html" />
type [<AllowNullLiteral>] TouchableWithoutFeedbackComponent =
    inherit React.Component<TouchableWithoutFeedbackProps>

/// <summary>
/// Do not use unless you have a very good reason.
/// All the elements that respond to press should have a visual feedback when touched.
/// This is one of the primary reason a "web" app doesn't feel "native".
/// </summary>
/// <seealso href="https://facebook.github.io/react-native/docs/touchablewithoutfeedback.html" />
type [<AllowNullLiteral>] TouchableWithoutFeedbackComponentStatic =
    [<EmitConstructor>] abstract Create: unit -> TouchableWithoutFeedbackComponent

type [<AllowNullLiteral>] TouchableWithoutFeedback =
    inherit TouchableWithoutFeedbackBase

type [<AllowNullLiteral>] TouchableWithoutFeedbackStatic =
    [<EmitConstructor>] abstract Create: unit -> TouchableWithoutFeedback

/// <seealso href="https://facebook.github.io/react-native/docs/touchablehighlight.html#props" />
type [<AllowNullLiteral>] TouchableHighlightProps =
    inherit TouchableWithoutFeedbackProps
    /// Determines what the opacity of the wrapped view should be when touch is active.
    abstract activeOpacity: float option with get, set
    /// Called immediately after the underlay is hidden
    abstract onHideUnderlay: (unit -> unit) option with get, set
    /// Called immediately after the underlay is shown
    abstract onShowUnderlay: (unit -> unit) option with get, set
    /// <summary>//FIXME: not in doc but available in examples</summary>
    /// <seealso href="https://facebook.github.io/react-native/docs/view.html#style" />
    abstract style: StyleProp<ViewStyle> option with get, set
    /// The color of the underlay that will show through when the touch is active.
    abstract underlayColor: string option with get, set

/// <summary>
/// A wrapper for making views respond properly to touches.
/// On press down, the opacity of the wrapped view is decreased,
/// which allows the underlay color to show through, darkening or tinting the view.
/// The underlay comes from adding a view to the view hierarchy,
/// which can sometimes cause unwanted visual artifacts if not used correctly,
/// for example if the backgroundColor of the wrapped view isn't explicitly set to an opaque color.
/// 
/// NOTE: TouchableHighlight supports only one child
/// If you wish to have several child components, wrap them in a View.
/// </summary>
/// <seealso href="https://facebook.github.io/react-native/docs/touchablehighlight.html" />
type [<AllowNullLiteral>] TouchableHighlightComponent =
    inherit React.Component<TouchableHighlightProps>

/// <summary>
/// A wrapper for making views respond properly to touches.
/// On press down, the opacity of the wrapped view is decreased,
/// which allows the underlay color to show through, darkening or tinting the view.
/// The underlay comes from adding a view to the view hierarchy,
/// which can sometimes cause unwanted visual artifacts if not used correctly,
/// for example if the backgroundColor of the wrapped view isn't explicitly set to an opaque color.
/// 
/// NOTE: TouchableHighlight supports only one child
/// If you wish to have several child components, wrap them in a View.
/// </summary>
/// <seealso href="https://facebook.github.io/react-native/docs/touchablehighlight.html" />
type [<AllowNullLiteral>] TouchableHighlightComponentStatic =
    [<EmitConstructor>] abstract Create: unit -> TouchableHighlightComponent

type [<AllowNullLiteral>] TouchableHighlight =
    inherit TouchableHighlightBase

type [<AllowNullLiteral>] TouchableHighlightStatic =
    [<EmitConstructor>] abstract Create: unit -> TouchableHighlight

/// <seealso href="https://facebook.github.io/react-native/docs/touchableopacity.html#props" />
type [<AllowNullLiteral>] TouchableOpacityProps =
    inherit TouchableWithoutFeedbackProps
    /// Determines what the opacity of the wrapped view should be when touch is active.
    /// Defaults to 0.2
    abstract activeOpacity: float option with get, set

/// <summary>
/// A wrapper for making views respond properly to touches.
/// On press down, the opacity of the wrapped view is decreased, dimming it.
/// This is done without actually changing the view hierarchy,
/// and in general is easy to add to an app without weird side-effects.
/// </summary>
/// <seealso href="https://facebook.github.io/react-native/docs/touchableopacity.html" />
type [<AllowNullLiteral>] TouchableOpacityComponent =
    inherit React.Component<TouchableOpacityProps>

/// <summary>
/// A wrapper for making views respond properly to touches.
/// On press down, the opacity of the wrapped view is decreased, dimming it.
/// This is done without actually changing the view hierarchy,
/// and in general is easy to add to an app without weird side-effects.
/// </summary>
/// <seealso href="https://facebook.github.io/react-native/docs/touchableopacity.html" />
type [<AllowNullLiteral>] TouchableOpacityComponentStatic =
    [<EmitConstructor>] abstract Create: unit -> TouchableOpacityComponent

type [<AllowNullLiteral>] TouchableOpacity =
    inherit TouchableOpacityBase
    /// Animate the touchable to a new opacity.
    abstract setOpacityTo: (float -> unit) with get, set

type [<AllowNullLiteral>] TouchableOpacityStatic =
    [<EmitConstructor>] abstract Create: unit -> TouchableOpacity

type [<AllowNullLiteral>] BaseBackgroundPropType =
    abstract ``type``: string with get, set

type [<AllowNullLiteral>] RippleBackgroundPropType =
    inherit BaseBackgroundPropType
    abstract ``type``: string with get, set
    abstract color: float option with get, set
    abstract borderless: bool option with get, set

type [<AllowNullLiteral>] ThemeAttributeBackgroundPropType =
    inherit BaseBackgroundPropType
    abstract ``type``: string with get, set
    abstract attribute: string with get, set

type BackgroundPropType =
    U2<RippleBackgroundPropType, ThemeAttributeBackgroundPropType>

/// <seealso href="https://facebook.github.io/react-native/docs/touchableopacity.html#props" />
type [<AllowNullLiteral>] TouchableNativeFeedbackProps =
    inherit TouchableWithoutFeedbackProps
    /// Determines the type of background drawable that's going to be used to display feedback.
    /// It takes an object with type property and extra data depending on the type.
    /// It's recommended to use one of the following static methods to generate that dictionary:
    ///       1) TouchableNativeFeedback.SelectableBackground() - will create object that represents android theme's
    ///          default background for selectable elements (?android:attr/selectableItemBackground)
    ///       2) TouchableNativeFeedback.SelectableBackgroundBorderless() - will create object that represent android
    ///          theme's default background for borderless selectable elements
    ///          (?android:attr/selectableItemBackgroundBorderless). Available on android API level 21+
    ///       3) TouchableNativeFeedback.Ripple(color, borderless) - will create object that represents ripple drawable
    ///          with specified color (as a string). If property borderless evaluates to true the ripple will render
    ///          outside of the view bounds (see native actionbar buttons as an example of that behavior). This background
    ///          type is available on Android API level 21+
    abstract background: BackgroundPropType option with get, set
    abstract useForeground: bool option with get, set

/// <summary>
/// A wrapper for making views respond properly to touches (Android only).
/// On Android this component uses native state drawable to display touch feedback.
/// At the moment it only supports having a single View instance as a child node,
/// as it's implemented by replacing that View with another instance of RCTView node with some additional properties set.
/// 
/// Background drawable of native feedback touchable can be customized with background property.
/// </summary>
/// <seealso href="https://facebook.github.io/react-native/docs/touchablenativefeedback.html#content" />
type [<AllowNullLiteral>] TouchableNativeFeedbackComponent =
    inherit React.Component<TouchableNativeFeedbackProps>

/// <summary>
/// A wrapper for making views respond properly to touches (Android only).
/// On Android this component uses native state drawable to display touch feedback.
/// At the moment it only supports having a single View instance as a child node,
/// as it's implemented by replacing that View with another instance of RCTView node with some additional properties set.
/// 
/// Background drawable of native feedback touchable can be customized with background property.
/// </summary>
/// <seealso href="https://facebook.github.io/react-native/docs/touchablenativefeedback.html#content" />
type [<AllowNullLiteral>] TouchableNativeFeedbackComponentStatic =
    [<EmitConstructor>] abstract Create: unit -> TouchableNativeFeedbackComponent

type [<AllowNullLiteral>] TouchableNativeFeedback =
    inherit TouchableNativeFeedbackBase

type [<AllowNullLiteral>] TouchableNativeFeedbackStatic =
    [<EmitConstructor>] abstract Create: unit -> TouchableNativeFeedback
    /// Creates an object that represents android theme's default background for
    /// selectable elements (?android:attr/selectableItemBackground).
    abstract SelectableBackground: unit -> ThemeAttributeBackgroundPropType
    /// Creates an object that represent android theme's default background for borderless
    /// selectable elements (?android:attr/selectableItemBackgroundBorderless).
    /// Available on android API level 21+.
    abstract SelectableBackgroundBorderless: unit -> ThemeAttributeBackgroundPropType
    /// <summary>
    /// Creates an object that represents ripple drawable with specified color (as a
    /// string). If property <c>borderless</c> evaluates to true the ripple will
    /// render outside of the view bounds (see native actionbar buttons as an
    /// example of that behavior). This background type is available on Android
    /// API level 21+.
    /// </summary>
    /// <param name="color">The ripple color</param>
    /// <param name="borderless">If the ripple can render outside it's bounds</param>
    abstract Ripple: color: string * ?borderless: bool -> RippleBackgroundPropType
    abstract canUseNativeForeground: unit -> bool

type [<AllowNullLiteral>] Route =
    abstract ``component``: React.ComponentType<obj option> option with get, set
    abstract id: string option with get, set
    abstract title: string option with get, set
    abstract passProps: Object option with get, set
    [<EmitIndexer>] abstract Item: key: string -> obj option with get, set
    abstract backButtonTitle: string option with get, set
    abstract content: string option with get, set
    abstract message: string option with get, set
    abstract index: float option with get, set
    abstract onRightButtonPress: (unit -> unit) option with get, set
    abstract rightButtonTitle: string option with get, set
    abstract wrapperStyle: obj option with get, set

type [<AllowNullLiteral>] InteractionMixin =
    abstract createInteractionHandle: unit -> float
    abstract clearInteractionHandle: clearHandle: float -> unit
    /// Schedule work for after all interactions have completed.
    abstract runAfterInteractions: callback: (unit -> obj option) -> unit

type [<AllowNullLiteral>] SubscribableMixin =
    /// <summary>
    /// Special form of calling <c>addListener</c> that *guarantees* that a
    /// subscription *must* be tied to a component instance, and therefore will
    /// be cleaned up when the component is unmounted. It is impossible to create
    /// the subscription and pass it in - this method must be the one to create
    /// the subscription and therefore can guarantee it is retained in a way that
    /// will be cleaned up.
    /// </summary>
    /// <param name="eventEmitter">emitter to subscribe to.</param>
    /// <param name="eventType">Type of event to listen to.</param>
    /// <param name="listener">Function to invoke when event occurs.</param>
    /// <param name="context">Object to use as listener context.</param>
    abstract addListenerOn: eventEmitter: obj option * eventType: string * listener: (unit -> obj option) * context: obj option -> unit

module StyleSheet =

    type [<AllowNullLiteral>] IExports =
        /// Creates a StyleSheet style reference from the given object.
        abstract create: styles: 'T -> obj when 'T :> NamedStyles<'T>
        /// <summary>
        /// Flattens an array of style objects, into one aggregated style object.
        /// Alternatively, this method can be used to lookup IDs, returned by
        /// StyleSheet.register.
        /// 
        /// &gt; **NOTE**: Exercise caution as abusing this can tax you in terms of
        /// &gt; optimizations.
        /// &gt;
        /// &gt; IDs enable optimizations through the bridge and memory in general. Refering
        /// &gt; to style objects directly will deprive you of these optimizations.
        /// 
        /// Example:
        /// <code>
        /// const styles = StyleSheet.create({
        ///    listItem: {
        ///      flex: 1,
        ///      fontSize: 16,
        ///      color: 'white'
        ///    },
        ///    selectedListItem: {
        ///      color: 'green'
        ///    }
        /// });
        /// 
        /// StyleSheet.flatten([styles.listItem, styles.selectedListItem])
        /// // returns { flex: 1, fontSize: 16, color: 'green' }
        /// </code>
        /// Alternative use:
        /// <code>
        /// StyleSheet.flatten(styles.listItem);
        /// // return { flex: 1, fontSize: 16, color: 'white' }
        /// // Simply styles.listItem would return its ID (number)
        /// </code>
        /// This method internally uses <c>StyleSheetRegistry.getStyleByID(style)</c>
        /// to resolve style objects represented by IDs. Thus, an array of style
        /// objects (instances of StyleSheet.create), are individually resolved to,
        /// their respective objects, merged as one and then returned. This also explains
        /// the alternative use.
        /// </summary>
        abstract flatten: ?style: RegisteredStyle<'T> -> 'T
        abstract flatten: ?style: StyleProp<TextStyle> -> TextStyle
        abstract flatten: ?style: StyleProp<ImageStyle> -> ImageStyle
        abstract flatten: ?style: StyleProp<ViewStyle> -> ViewStyle
        /// WARNING: EXPERIMENTAL. Breaking changes will probably happen a lot and will
        /// not be reliably announced. The whole thing might be deleted, who knows? Use
        /// at your own risk.
        /// 
        /// Sets a function to use to pre-process a style property value. This is used
        /// internally to process color and transform values. You should not use this
        /// unless you really know what you are doing and have exhausted other options.
        abstract setStyleAttributePreprocessor: property: string * ``process``: (obj option -> obj option) -> unit
        /// <summary>
        /// This is defined as the width of a thin line on the platform. It can be
        /// used as the thickness of a border or division between two elements.
        /// Example:
        /// <code>
        ///    {
        ///      borderBottomColor: '#bbb',
        ///      borderBottomWidth: StyleSheet.hairlineWidth
        ///    }
        /// </code>
        /// 
        /// This constant will always be a round number of pixels (so a line defined
        /// by it look crisp) and will try to match the standard width of a thin line
        /// on the underlying platform. However, you should not rely on it being a
        /// constant size, because on different platforms and screen densities its
        /// value may be calculated differently.
        /// </summary>
        abstract hairlineWidth: float
        /// <summary>
        /// Sometimes you may want <c>absoluteFill</c> but with a couple tweaks - <c>absoluteFillObject</c> can be
        /// used to create a customized entry in a <c>StyleSheet</c>, e.g.:
        /// 
        ///    const styles = StyleSheet.create({
        ///      wrapper: {
        ///        ...StyleSheet.absoluteFillObject,
        ///        top: 10,
        ///        backgroundColor: 'transparent',
        ///      },
        ///    });
        /// </summary>
        abstract absoluteFillObject: AbsoluteFillStyle
        /// <summary>
        /// A very common pattern is to create overlays with position absolute and zero positioning,
        /// so <c>absoluteFill</c> can be used for convenience and to reduce duplication of these repeated
        /// styles.
        /// </summary>
        abstract absoluteFill: RegisteredStyle<AbsoluteFillStyle>

    type [<AllowNullLiteral>] NamedStyles<'T> =
        interface end

    type [<AllowNullLiteral>] AbsoluteFillStyle =
        abstract position: string with get, set
        abstract left: obj with get, set
        abstract right: obj with get, set
        abstract top: obj with get, set
        abstract bottom: obj with get, set

type [<AllowNullLiteral>] RelayProfiler =
    abstract attachProfileHandler: name: string * handler: (string -> (obj) option -> (unit -> unit)) -> unit
    abstract attachAggregateHandler: name: string * handler: (string -> (unit -> unit) -> unit) -> unit

type [<AllowNullLiteral>] SystraceStatic =
    abstract setEnabled: enabled: bool -> unit
    /// beginEvent/endEvent for starting and then ending a profile within the same call stack frame
    abstract beginEvent: ?profileName: obj * ?args: obj -> unit
    abstract endEvent: unit -> unit
    /// beginAsyncEvent/endAsyncEvent for starting and then ending a profile where the end can either
    /// occur on another thread or out of the current stack frame, eg await
    /// the returned cookie variable should be used as input into the endAsyncEvent call to end the profile
    abstract beginAsyncEvent: ?profileName: obj -> obj option
    abstract endAsyncEvent: ?profileName: obj * ?cookie: obj -> unit
    /// counterEvent registers the value to the profileName on the systrace timeline
    abstract counterEvent: ?profileName: obj * ?value: obj -> unit
    /// Relay profiles use await calls, so likely occur out of current stack frame
    /// therefore async variant of profiling is used
    abstract attachToRelayProfiler: relayProfiler: RelayProfiler -> unit
    abstract swizzleJSON: unit -> unit
    /// <summary>
    /// Measures multiple methods of a class. For example, you can do:
    /// Systrace.measureMethods(JSON, 'JSON', ['parse', 'stringify']);
    /// </summary>
    /// <param name="methodNames">Map from method names to method display names.</param>
    abstract measureMethods: object: obj option * objectName: string * methodNames: Array<string> -> unit
    /// <summary>
    /// Returns an profiled version of the input function. For example, you can:
    /// JSON.parse = Systrace.measure('JSON', 'parse', JSON.parse);
    /// </summary>
    /// <returns>replacement function</returns>
    abstract measure: objName: string * fnName: string * func: 'T -> 'T

/// //FIXME: Could not find docs. Inferred from examples and jscode : ListViewDataSource.js
type [<AllowNullLiteral>] DataSourceAssetCallback =
    abstract rowHasChanged: (obj option -> obj option -> bool) option with get, set
    abstract sectionHeaderHasChanged: (obj option -> obj option -> bool) option with get, set
    abstract getRowData: (obj option -> U2<float, string> -> U2<float, string> -> obj option) option with get, set
    abstract getSectionHeaderData: (obj option -> U2<float, string> -> obj option) option with get, set

/// <summary>
/// Provides efficient data processing and access to the
/// <c>ListView</c> component.  A <c>ListViewDataSource</c> is created with functions for
/// extracting data from the input blob, and comparing elements (with default
/// implementations for convenience).  The input blob can be as simple as an
/// array of strings, or an object with rows nested inside section objects.
/// 
/// To update the data in the datasource, use <c>cloneWithRows</c> (or
/// <c>cloneWithRowsAndSections</c> if you care about sections).  The data in the
/// data source is immutable, so you can't modify it directly.  The clone methods
/// suck in the new data and compute a diff for each row so ListView knows
/// whether to re-render it or not.
/// </summary>
type [<AllowNullLiteral>] ListViewDataSource =
    /// <summary>
    /// Clones this <c>ListViewDataSource</c> with the specified <c>dataBlob</c> and
    /// <c>rowIdentities</c>. The <c>dataBlob</c> is just an aribitrary blob of data. At
    /// construction an extractor to get the interesting informatoin was defined
    /// (or the default was used).
    /// 
    /// The <c>rowIdentities</c> is is a 2D array of identifiers for rows.
    /// ie. [['a1', 'a2'], ['b1', 'b2', 'b3'], ...].  If not provided, it's
    /// assumed that the keys of the section data are the row identities.
    /// 
    /// Note: This function does NOT clone the data in this data source. It simply
    /// passes the functions defined at construction to a new data source with
    /// the data specified. If you wish to maintain the existing data you must
    /// handle merging of old and new data separately and then pass that into
    /// this function as the <c>dataBlob</c>.
    /// </summary>
    abstract cloneWithRows: dataBlob: U2<Array<obj option>, LayoutAnimationStaticConfigChecker> * ?rowIdentities: Array<U2<string, float>> -> ListViewDataSource
    /// <summary>
    /// This performs the same function as the <c>cloneWithRows</c> function but here
    /// you also specify what your <c>sectionIdentities</c> are. If you don't care
    /// about sections you should safely be able to use <c>cloneWithRows</c>.
    /// 
    /// <c>sectionIdentities</c> is an array of identifiers for  sections.
    /// ie. ['s1', 's2', ...].  If not provided, it's assumed that the
    /// keys of dataBlob are the section identities.
    /// 
    /// Note: this returns a new object!
    /// </summary>
    abstract cloneWithRowsAndSections: dataBlob: U2<Array<obj option>, LayoutAnimationStaticConfigChecker> * ?sectionIdentities: Array<U2<string, float>> * ?rowIdentities: Array<Array<U2<string, float>>> -> ListViewDataSource
    abstract getRowCount: unit -> float
    abstract getRowAndSectionCount: unit -> float
    /// Returns if the row is dirtied and needs to be rerendered
    abstract rowShouldUpdate: sectionIndex: float * rowIndex: float -> bool
    /// Gets the data required to render the row.
    abstract getRowData: sectionIndex: float * rowIndex: float -> obj option
    /// Gets the rowID at index provided if the dataSource arrays were flattened,
    /// or null of out of range indexes.
    abstract getRowIDForFlatIndex: index: float -> string
    /// Gets the sectionID at index provided if the dataSource arrays were flattened,
    /// or null for out of range indexes.
    abstract getSectionIDForFlatIndex: index: float -> string
    /// Returns an array containing the number of rows in each section
    abstract getSectionLengths: unit -> Array<float>
    /// Returns if the section header is dirtied and needs to be rerendered
    abstract sectionHeaderShouldUpdate: sectionIndex: float -> bool
    /// Gets the data required to render the section header
    abstract getSectionHeaderData: sectionIndex: float -> obj option

/// <summary>
/// Provides efficient data processing and access to the
/// <c>ListView</c> component.  A <c>ListViewDataSource</c> is created with functions for
/// extracting data from the input blob, and comparing elements (with default
/// implementations for convenience).  The input blob can be as simple as an
/// array of strings, or an object with rows nested inside section objects.
/// 
/// To update the data in the datasource, use <c>cloneWithRows</c> (or
/// <c>cloneWithRowsAndSections</c> if you care about sections).  The data in the
/// data source is immutable, so you can't modify it directly.  The clone methods
/// suck in the new data and compute a diff for each row so ListView knows
/// whether to re-render it or not.
/// </summary>
type [<AllowNullLiteral>] ListViewDataSourceStatic =
    /// <summary>
    /// You can provide custom extraction and <c>hasChanged</c> functions for section
    /// headers and rows.  If absent, data will be extracted with the
    /// <c>defaultGetRowData</c> and <c>defaultGetSectionHeaderData</c> functions.
    /// 
    /// The default extractor expects data of one of the following forms:
    /// 
    ///       { sectionID_1: { rowID_1: &lt;rowData1&gt;, ... }, ... }
    /// 
    ///     or
    /// 
    ///       { sectionID_1: [ &lt;rowData1&gt;, &lt;rowData2&gt;, ... ], ... }
    /// 
    ///     or
    /// 
    ///       [ [ &lt;rowData1&gt;, &lt;rowData2&gt;, ... ], ... ]
    /// 
    /// The constructor takes in a params argument that can contain any of the
    /// following:
    /// 
    /// - getRowData(dataBlob, sectionID, rowID);
    /// - getSectionHeaderData(dataBlob, sectionID);
    /// - rowHasChanged(prevRowData, nextRowData);
    /// - sectionHeaderHasChanged(prevSectionData, nextSectionData);
    /// </summary>
    [<EmitConstructor>] abstract Create: onAsset: DataSourceAssetCallback -> ListViewDataSource

/// <seealso href="https://facebook.github.io/react-native/docs/tabbarios-item.html#props" />
type [<AllowNullLiteral>] TabBarIOSItemProps =
    inherit ViewProps
    /// Little red bubble that sits at the top right of the icon.
    abstract badge: U2<string, float> option with get, set
    /// Background color for the badge. Available since iOS 10.
    abstract badgeColor: string option with get, set
    /// A custom icon for the tab. It is ignored when a system icon is defined.
    abstract icon: ImageURISource option with get, set
    /// Callback when this tab is being selected,
    /// you should change the state of your component to set selected={true}.
    abstract onPress: (unit -> unit) option with get, set
    /// If set to true it renders the image as original,
    /// it defaults to being displayed as a template
    abstract renderAsOriginal: bool option with get, set
    /// It specifies whether the children are visible or not. If you see a blank content, you probably forgot to add a selected one.
    abstract selected: bool option with get, set
    /// A custom icon when the tab is selected.
    /// It is ignored when a system icon is defined. If left empty, the icon will be tinted in blue.
    abstract selectedIcon: ImageURISource option with get, set
    /// React style object.
    abstract style: StyleProp<ViewStyle> option with get, set
    /// Items comes with a few predefined system icons.
    /// Note that if you are using them, the title and selectedIcon will be overriden with the system ones.
    /// 
    ///   enum('bookmarks', 'contacts', 'downloads', 'favorites', 'featured', 'history', 'more', 'most-recent', 'most-viewed', 'recents', 'search', 'top-rated')
    abstract systemIcon: TabBarIOSItemPropsSystemIcon option with get, set
    /// Text that appears under the icon. It is ignored when a system icon is defined.
    abstract title: string option with get, set

type [<AllowNullLiteral>] TabBarIOSItem =
    inherit React.Component<TabBarIOSItemProps>

type [<AllowNullLiteral>] TabBarIOSItemStatic =
    [<EmitConstructor>] abstract Create: unit -> TabBarIOSItem

/// <seealso href="https://facebook.github.io/react-native/docs/tabbarios.html#props" />
type [<AllowNullLiteral>] TabBarIOSProps =
    inherit ViewProps
    /// Background color of the tab bar
    abstract barTintColor: string option with get, set
    /// <summary>
    /// Specifies tab bar item positioning. Available values are:
    /// - fill - distributes items across the entire width of the tab bar
    /// - center - centers item in the available tab bar space
    /// - auto (default) - distributes items dynamically according to the
    /// user interface idiom. In a horizontally compact environment (e.g. iPhone 5)
    /// this value defaults to <c>fill</c>, in a horizontally regular one (e.g. iPad)
    /// it defaults to center.
    /// </summary>
    abstract itemPositioning: TabBarIOSPropsItemPositioning option with get, set
    /// Color of the currently selected tab icon
    abstract tintColor: string option with get, set
    /// A Boolean value that indicates whether the tab bar is translucent
    abstract translucent: bool option with get, set
    /// Color of text on unselected tabs
    abstract unselectedTintColor: string option with get, set
    /// Color of unselected tab icons. Available since iOS 10.
    abstract unselectedItemTintColor: string option with get, set

type [<AllowNullLiteral>] TabBarIOS =
    inherit React.Component<TabBarIOSProps>

type [<AllowNullLiteral>] TabBarIOSStatic =
    [<EmitConstructor>] abstract Create: unit -> TabBarIOS
    abstract Item: obj with get, set

type [<AllowNullLiteral>] PixelRatioStatic =
    abstract get: unit -> float
    abstract getFontScale: unit -> float
    /// Converts a layout size (dp) to pixel size (px).
    /// Guaranteed to return an integer number.
    abstract getPixelSizeForLayoutSize: layoutSize: float -> float
    /// Rounds a layout size (dp) to the nearest layout size that
    /// corresponds to an integer number of pixels. For example,
    /// on a device with a PixelRatio of 3,
    /// PixelRatio.roundToNearestPixel(8.4) = 8.33,
    /// which corresponds to exactly (8.33 * 3) = 25 pixels.
    abstract roundToNearestPixel: layoutSize: float -> float
    /// No-op for iOS, but used on the web. Should not be documented. [sic]
    abstract startDetecting: unit -> unit

/// <seealso href="https://facebook.github.io/react-native/docs/platform-specific-code.html#content" />
type [<StringEnum>] [<RequireQualifiedAccess>] PlatformOSType =
    | Ios
    | Android
    | Macos
    | Windows
    | Web

type [<AllowNullLiteral>] PlatformStatic =
    abstract OS: PlatformOSType with get, set
    abstract Version: U2<float, string> with get, set
    /// <seealso href="https://facebook.github.io/react-native/docs/platform-specific-code.html#content" />
    abstract select: specifics: obj -> 'T

type [<AllowNullLiteral>] PlatformIOSStatic =
    inherit PlatformStatic
    abstract isPad: bool with get, set
    abstract isTVOS: bool with get, set

/// Deprecated - subclass NativeEventEmitter to create granular event modules instead of
/// adding all event listeners directly to RCTDeviceEventEmitter.
type [<AllowNullLiteral>] DeviceEventEmitterStatic =
    inherit EventEmitter
    abstract sharedSubscriber: EventSubscriptionVendor with get, set
    /// Adds a listener to be invoked when events of the specified type are
    /// emitted. An optional calling context may be provided. The data arguments
    /// emitted will be passed to the listener function.
    abstract addListener: ``type``: string * listener: (obj option -> unit) * ?context: obj -> EmitterSubscription

/// Deprecated - subclass NativeEventEmitter to create granular event modules instead of
/// adding all event listeners directly to RCTDeviceEventEmitter.
type [<AllowNullLiteral>] DeviceEventEmitterStaticStatic =
    [<EmitConstructor>] abstract Create: unit -> DeviceEventEmitterStatic

type [<AllowNullLiteral>] ScaledSize =
    abstract width: float with get, set
    abstract height: float with get, set
    abstract scale: float with get, set
    abstract fontScale: float with get, set

/// <summary>
/// Initial dimensions are set before <c>runApplication</c> is called so they should
/// be available before any other require's are run, but may be updated later.
/// 
/// Note: Although dimensions are available immediately, they may change (e.g
/// due to device rotation) so any rendering logic or styles that depend on
/// these constants should try to call this function on every render, rather
/// than caching the value (for example, using inline styles rather than
/// setting a value in a <c>StyleSheet</c>).
/// 
/// Example: <c>const {height, width} = Dimensions.get('window');</c>
/// </summary>
/// <param name="dim">Name of dimension as defined when calling <c>set</c>.</param>
/// <returns>Value for the dimension.</returns>
/// <seealso href="https://facebook.github.io/react-native/docs/dimensions.html#content" />
type [<AllowNullLiteral>] Dimensions =
    /// <summary>
    /// Initial dimensions are set before runApplication is called so they
    /// should be available before any other require's are run, but may be
    /// updated later.
    /// Note: Although dimensions are available immediately, they may
    /// change (e.g due to device rotation) so any rendering logic or
    /// styles that depend on these constants should try to call this
    /// function on every render, rather than caching the value (for
    /// example, using inline styles rather than setting a value in a
    /// StyleSheet).
    /// Example: const {height, width} = Dimensions.get('window');
    /// </summary>
    /// <param name="dim">Name of dimension as defined when calling set.</param>
    /// <returns>Value for the dimension.</returns>
    abstract get: dim: DimensionsGetDim -> ScaledSize
    /// <summary>This should only be called from native code by sending the didUpdateDimensions event.</summary>
    /// <param name="dims">Simple string-keyed object of dimensions to set</param>
    abstract set: dims: DimensionsSetDims -> unit
    /// <summary>Add an event listener for dimension changes</summary>
    /// <param name="type">the type of event to listen to</param>
    /// <param name="handler">the event handler</param>
    [<Emit "$0.addEventListener('change',$1)">] abstract addEventListener_change: handler: (DimensionsAddEventListener_change -> unit) -> unit
    /// <summary>Remove an event listener</summary>
    /// <param name="type">the type of event</param>
    /// <param name="handler">the event handler</param>
    [<Emit "$0.removeEventListener('change',$1)">] abstract removeEventListener_change: handler: (DimensionsAddEventListener_change -> unit) -> unit

type [<StringEnum>] [<RequireQualifiedAccess>] DimensionsGetDim =
    | Window
    | Screen

type [<AllowNullLiteral>] DimensionsSetDims =
    [<EmitIndexer>] abstract Item: key: string -> obj option with get, set

type [<AllowNullLiteral>] SimpleTask =
    abstract name: string with get, set
    abstract gen: (unit -> unit) with get, set

type [<AllowNullLiteral>] PromiseTask =
    abstract name: string with get, set
    abstract gen: (unit -> Promise<obj option>) with get, set

type Handle =
    float

type [<AllowNullLiteral>] InteractionManagerStatic =
    inherit EventEmitterListener
    abstract Events: InteractionManagerStaticEvents with get, set
    /// Schedule a function to run after all interactions have completed.
    /// Returns a cancellable
    abstract runAfterInteractions: ?task: U3<(unit -> obj option), SimpleTask, PromiseTask> -> InteractionManagerStaticRunAfterInteractionsReturn
    /// Notify manager that an interaction has started.
    abstract createInteractionHandle: unit -> Handle
    /// Notify manager that an interaction has completed.
    abstract clearInteractionHandle: handle: Handle -> unit
    /// A positive number will use setTimeout to schedule any tasks after
    /// the eventLoopRunningTime hits the deadline value, otherwise all
    /// tasks will be executed in one setImmediate batch (default).
    abstract setDeadline: deadline: float -> unit

type [<AllowNullLiteral>] InteractionManagerStaticRunAfterInteractionsReturn =
    abstract ``then``: (((unit -> obj option)) option -> ((unit -> obj option)) option -> Promise<obj option>) with get, set
    abstract ``done``: (ResizeArray<obj option> -> obj option) with get, set
    abstract cancel: (unit -> unit) with get, set

type [<AllowNullLiteral>] ScrollResponderEvent =
    inherit NativeSyntheticEvent<NativeTouchEvent>

type [<AllowNullLiteral>] ScrollResponderMixin =
    inherit SubscribableMixin
    /// <summary>Invoke this from an <c>onScroll</c> event.</summary>
    abstract scrollResponderHandleScrollShouldSetResponder: unit -> bool
    /// <summary>
    /// Merely touch starting is not sufficient for a scroll view to become the
    /// responder. Being the "responder" means that the very next touch move/end
    /// event will result in an action/movement.
    /// 
    /// Invoke this from an <c>onStartShouldSetResponder</c> event.
    /// 
    /// <c>onStartShouldSetResponder</c> is used when the next move/end will trigger
    /// some UI movement/action, but when you want to yield priority to views
    /// nested inside of the view.
    /// 
    /// There may be some cases where scroll views actually should return <c>true</c>
    /// from <c>onStartShouldSetResponder</c>: Any time we are detecting a standard tap
    /// that gives priority to nested views.
    /// 
    /// - If a single tap on the scroll view triggers an action such as
    ///    recentering a map style view yet wants to give priority to interaction
    ///    views inside (such as dropped pins or labels), then we would return true
    ///    from this method when there is a single touch.
    /// 
    /// - Similar to the previous case, if a two finger "tap" should trigger a
    ///    zoom, we would check the <c>touches</c> count, and if <c>&gt;= 2</c>, we would return
    ///    true.
    /// </summary>
    abstract scrollResponderHandleStartShouldSetResponder: unit -> bool
    /// <summary>
    /// There are times when the scroll view wants to become the responder
    /// (meaning respond to the next immediate <c>touchStart/touchEnd</c>), in a way
    /// that *doesn't* give priority to nested views (hence the capture phase):
    /// 
    /// - Currently animating.
    /// - Tapping anywhere that is not the focused input, while the keyboard is
    ///    up (which should dismiss the keyboard).
    /// 
    /// Invoke this from an <c>onStartShouldSetResponderCapture</c> event.
    /// </summary>
    abstract scrollResponderHandleStartShouldSetResponderCapture: e: ScrollResponderEvent -> bool
    /// <summary>
    /// Invoke this from an <c>onResponderReject</c> event.
    /// 
    /// Some other element is not yielding its role as responder. Normally, we'd
    /// just disable the <c>UIScrollView</c>, but a touch has already began on it, the
    /// <c>UIScrollView</c> will not accept being disabled after that. The easiest
    /// solution for now is to accept the limitation of disallowing this
    /// altogether. To improve this, find a way to disable the <c>UIScrollView</c> after
    /// a touch has already started.
    /// </summary>
    abstract scrollResponderHandleResponderReject: unit -> obj option
    /// We will allow the scroll view to give up its lock iff it acquired the lock
    /// during an animation. This is a very useful default that happens to satisfy
    /// many common user experiences.
    /// 
    /// - Stop a scroll on the left edge, then turn that into an outer view's
    ///    backswipe.
    /// - Stop a scroll mid-bounce at the top, continue pulling to have the outer
    ///    view dismiss.
    /// - However, without catching the scroll view mid-bounce (while it is
    ///    motionless), if you drag far enough for the scroll view to become
    ///    responder (and therefore drag the scroll view a bit), any backswipe
    ///    navigation of a swipe gesture higher in the view hierarchy, should be
    ///    rejected.
    abstract scrollResponderHandleTerminationRequest: unit -> bool
    /// <summary>Invoke this from an <c>onTouchEnd</c> event.</summary>
    /// <param name="e">Event.</param>
    abstract scrollResponderHandleTouchEnd: e: ScrollResponderEvent -> unit
    /// <summary>Invoke this from an <c>onResponderRelease</c> event.</summary>
    abstract scrollResponderHandleResponderRelease: e: ScrollResponderEvent -> unit
    abstract scrollResponderHandleScroll: e: ScrollResponderEvent -> unit
    /// <summary>Invoke this from an <c>onResponderGrant</c> event.</summary>
    abstract scrollResponderHandleResponderGrant: e: ScrollResponderEvent -> unit
    /// <summary>
    /// Unfortunately, <c>onScrollBeginDrag</c> also fires when *stopping* the scroll
    /// animation, and there's not an easy way to distinguish a drag vs. stopping
    /// momentum.
    /// 
    /// Invoke this from an <c>onScrollBeginDrag</c> event.
    /// </summary>
    abstract scrollResponderHandleScrollBeginDrag: e: ScrollResponderEvent -> unit
    /// <summary>Invoke this from an <c>onScrollEndDrag</c> event.</summary>
    abstract scrollResponderHandleScrollEndDrag: e: ScrollResponderEvent -> unit
    /// <summary>Invoke this from an <c>onMomentumScrollBegin</c> event.</summary>
    abstract scrollResponderHandleMomentumScrollBegin: e: ScrollResponderEvent -> unit
    /// <summary>Invoke this from an <c>onMomentumScrollEnd</c> event.</summary>
    abstract scrollResponderHandleMomentumScrollEnd: e: ScrollResponderEvent -> unit
    /// <summary>
    /// Invoke this from an <c>onTouchStart</c> event.
    /// 
    /// Since we know that the <c>SimpleEventPlugin</c> occurs later in the plugin
    /// order, after <c>ResponderEventPlugin</c>, we can detect that we were *not*
    /// permitted to be the responder (presumably because a contained view became
    /// responder). The <c>onResponderReject</c> won't fire in that case - it only
    /// fires when a *current* responder rejects our request.
    /// </summary>
    /// <param name="e">Touch Start event.</param>
    abstract scrollResponderHandleTouchStart: e: ScrollResponderEvent -> unit
    /// <summary>
    /// Invoke this from an <c>onTouchMove</c> event.
    /// 
    /// Since we know that the <c>SimpleEventPlugin</c> occurs later in the plugin
    /// order, after <c>ResponderEventPlugin</c>, we can detect that we were *not*
    /// permitted to be the responder (presumably because a contained view became
    /// responder). The <c>onResponderReject</c> won't fire in that case - it only
    /// fires when a *current* responder rejects our request.
    /// </summary>
    /// <param name="e">Touch Start event.</param>
    abstract scrollResponderHandleTouchMove: e: ScrollResponderEvent -> unit
    /// A helper function for this class that lets us quickly determine if the
    /// view is currently animating. This is particularly useful to know when
    /// a touch has just started or ended.
    abstract scrollResponderIsAnimating: unit -> bool
    /// <summary>
    /// Returns the node that represents native view that can be scrolled.
    /// Components can pass what node to use by defining a <c>getScrollableNode</c>
    /// function otherwise <c>this</c> is used.
    /// </summary>
    abstract scrollResponderGetScrollableNode: unit -> obj option
    /// A helper function to scroll to a specific point  in the scrollview.
    /// This is currently used to help focus on child textviews, but can also
    /// be used to quickly scroll to any element we want to focus. Syntax:
    /// 
    /// scrollResponderScrollTo(options: {x: number = 0; y: number = 0; animated: boolean = true})
    /// 
    /// Note: The weird argument signature is due to the fact that, for historical reasons,
    /// the function also accepts separate arguments as as alternative to the options object.
    /// This is deprecated due to ambiguity (y before x), and SHOULD NOT BE USED.
    abstract scrollResponderScrollTo: ?x: U2<float, RecyclerViewBackedScrollViewScrollTo> * ?y: float * ?animated: bool -> unit
    /// <summary>
    /// A helper function to zoom to a specific rect in the scrollview. The argument has the shape
    /// {x: number; y: number; width: number; height: number; animated: boolean = true}
    /// </summary>
    abstract scrollResponderZoomTo: rect: ScrollResponderMixinScrollResponderZoomToRect * ?animated: bool -> unit
    /// <summary>
    /// This method should be used as the callback to onFocus in a TextInputs'
    /// parent view. Note that any module using this mixin needs to return
    /// the parent view's ref in getScrollViewRef() in order to use this method.
    /// </summary>
    /// <param name="nodeHandle">The TextInput node handle</param>
    /// <param name="additionalOffset">
    /// The scroll view's top "contentInset".
    /// Default is 0.
    /// </param>
    /// <param name="preventNegativeScrolling">
    /// Whether to allow pulling the content
    /// down to make it meet the keyboard's top. Default is false.
    /// </param>
    abstract scrollResponderScrollNativeHandleToKeyboard: nodeHandle: obj option * ?additionalOffset: float * ?preventNegativeScrollOffset: bool -> unit
    /// <summary>
    /// The calculations performed here assume the scroll view takes up the entire
    /// screen - even if has some content inset. We then measure the offsets of the
    /// keyboard, and compensate both for the scroll view's "contentInset".
    /// </summary>
    /// <param name="left">Position of input w.r.t. table view.</param>
    /// <param name="top">Position of input w.r.t. table view.</param>
    /// <param name="width">Width of the text input.</param>
    /// <param name="height">Height of the text input.</param>
    abstract scrollResponderInputMeasureAndScrollToKeyboard: left: float * top: float * width: float * height: float -> unit
    abstract scrollResponderTextInputFocusError: e: ScrollResponderEvent -> unit
    /// <summary>
    /// <c>componentWillMount</c> is the closest thing to a  standard "constructor" for
    /// React components.
    /// 
    /// The <c>keyboardWillShow</c> is called before input focus.
    /// </summary>
    abstract componentWillMount: unit -> unit
    /// <summary>
    /// Warning, this may be called several times for a single keyboard opening.
    /// It's best to store the information in this method and then take any action
    /// at a later point (either in <c>keyboardDidShow</c> or other).
    /// 
    /// Here's the order that events occur in:
    /// - focus
    /// - willShow {startCoordinates, endCoordinates} several times
    /// - didShow several times
    /// - blur
    /// - willHide {startCoordinates, endCoordinates} several times
    /// - didHide several times
    /// 
    /// The <c>ScrollResponder</c> providesModule callbacks for each of these events.
    /// Even though any user could have easily listened to keyboard events
    /// themselves, using these <c>props</c> callbacks ensures that ordering of events
    /// is consistent - and not dependent on the order that the keyboard events are
    /// subscribed to. This matters when telling the scroll view to scroll to where
    /// the keyboard is headed - the scroll responder better have been notified of
    /// the keyboard destination before being instructed to scroll to where the
    /// keyboard will be. Stick to the <c>ScrollResponder</c> callbacks, and everything
    /// will work.
    /// 
    /// WARNING: These callbacks will fire even if a keyboard is displayed in a
    /// different navigation pane. Filter out the events to determine if they are
    /// relevant to you. (For example, only if you receive these callbacks after
    /// you had explicitly focused a node etc).
    /// </summary>
    abstract scrollResponderKeyboardWillShow: e: ScrollResponderEvent -> unit
    abstract scrollResponderKeyboardWillHide: e: ScrollResponderEvent -> unit
    abstract scrollResponderKeyboardDidShow: e: ScrollResponderEvent -> unit
    abstract scrollResponderKeyboardDidHide: e: ScrollResponderEvent -> unit

type [<AllowNullLiteral>] ScrollResponderMixinScrollResponderZoomToRect =
    abstract x: float with get, set
    abstract y: float with get, set
    abstract width: float with get, set
    abstract height: float with get, set
    abstract animated: bool option with get, set

type [<AllowNullLiteral>] ScrollViewPropsIOS =
    /// <summary>
    /// When true the scroll view bounces horizontally when it reaches the end
    /// even if the content is smaller than the scroll view itself. The default
    /// value is true when <c>horizontal={true}</c> and false otherwise.
    /// </summary>
    abstract alwaysBounceHorizontal: bool option with get, set
    /// <summary>
    /// When true the scroll view bounces vertically when it reaches the end
    /// even if the content is smaller than the scroll view itself. The default
    /// value is false when <c>horizontal={true}</c> and true otherwise.
    /// </summary>
    abstract alwaysBounceVertical: bool option with get, set
    /// Controls whether iOS should automatically adjust the content inset for scroll views that are placed behind a navigation bar or tab bar/ toolbar.
    /// The default value is true.
    abstract automaticallyAdjustContentInsets: bool option with get, set
    /// <summary>
    /// When true the scroll view bounces when it reaches the end of the
    /// content if the content is larger then the scroll view along the axis of
    /// the scroll direction. When false it disables all bouncing even if
    /// the <c>alwaysBounce*</c> props are true. The default value is true.
    /// </summary>
    abstract bounces: bool option with get, set
    /// When true gestures can drive zoom past min/max and the zoom will animate
    /// to the min/max value at gesture end otherwise the zoom will not exceed
    /// the limits.
    abstract bouncesZoom: bool option with get, set
    /// When false once tracking starts won't try to drag if the touch moves.
    /// The default value is true.
    abstract canCancelContentTouches: bool option with get, set
    /// When true the scroll view automatically centers the content when the
    /// content is smaller than the scroll view bounds; when the content is
    /// larger than the scroll view this property has no effect. The default
    /// value is false.
    abstract centerContent: bool option with get, set
    /// The amount by which the scroll view content is inset from the edges of the scroll view.
    /// Defaults to {0, 0, 0, 0}.
    abstract contentInset: Insets option with get, set
    /// Used to manually set the starting scroll offset.
    /// The default value is {x: 0, y: 0}
    abstract contentOffset: PointPropType option with get, set
    /// This property specifies how the safe area insets are used to modify the content area of the scroll view.
    /// The default value of this property must be 'automatic'. But the default value is 'never' until RN@0.51.
    abstract contentInsetAdjustmentBehavior: ScrollViewPropsIOSContentInsetAdjustmentBehavior option with get, set
    /// A floating-point number that determines how quickly the scroll view
    /// decelerates after the user lifts their finger. Reasonable choices include
    ///    - Normal: 0.998 (the default)
    ///    - Fast: 0.9
    abstract decelerationRate: U2<float, string> option with get, set
    /// When true the ScrollView will try to lock to only vertical or horizontal
    /// scrolling while dragging.  The default value is false.
    abstract directionalLockEnabled: bool option with get, set
    /// The style of the scroll indicators.
    /// - default (the default), same as black.
    /// - black, scroll indicator is black. This style is good against
    ///    a white content background.
    /// - white, scroll indicator is white. This style is good against
    ///    a black content background.
    abstract indicatorStyle: ScrollViewPropsIOSIndicatorStyle option with get, set
    /// The maximum allowed zoom scale. The default value is 1.0.
    abstract maximumZoomScale: float option with get, set
    /// The minimum allowed zoom scale. The default value is 1.0.
    abstract minimumZoomScale: float option with get, set
    /// Called when a scrolling animation ends.
    abstract onScrollAnimationEnd: (unit -> unit) option with get, set
    /// When true, ScrollView allows use of pinch gestures to zoom in and out.
    /// The default value is true.
    abstract pinchGestureEnabled: bool option with get, set
    /// This controls how often the scroll event will be fired while scrolling (in events per seconds).
    /// A higher number yields better accuracy for code that is tracking the scroll position,
    /// but can lead to scroll performance problems due to the volume of information being send over the bridge.
    /// The default value is zero, which means the scroll event will be sent only once each time the view is scrolled.
    abstract scrollEventThrottle: float option with get, set
    /// The amount by which the scroll view indicators are inset from the edges of the scroll view.
    /// This should normally be set to the same value as the contentInset.
    /// Defaults to {0, 0, 0, 0}.
    abstract scrollIndicatorInsets: Insets option with get, set
    /// When true the scroll view scrolls to top when the status bar is tapped.
    /// The default value is true.
    abstract scrollsToTop: bool option with get, set
    /// When snapToInterval is set, snapToAlignment will define the relationship of the the snapping to the scroll view.
    ///       - start (the default) will align the snap at the left (horizontal) or top (vertical)
    ///       - center will align the snap in the center
    ///       - end will align the snap at the right (horizontal) or bottom (vertical)
    abstract snapToAlignment: ScrollViewPropsIOSSnapToAlignment option with get, set
    /// When set, causes the scroll view to stop at multiples of the value of snapToInterval.
    /// This can be used for paginating through children that have lengths smaller than the scroll view.
    /// Used in combination with snapToAlignment.
    abstract snapToInterval: float option with get, set
    /// <summary>
    /// An array of child indices determining which children get docked to the
    /// top of the screen when scrolling. For example passing
    /// <c>stickyHeaderIndices={[0]}</c> will cause the first child to be fixed to the
    /// top of the scroll view. This property is not supported in conjunction
    /// with <c>horizontal={true}</c>.
    /// </summary>
    abstract stickyHeaderIndices: ResizeArray<float> option with get, set
    /// The current scale of the scroll view content. The default value is 1.0.
    abstract zoomScale: float option with get, set

type [<AllowNullLiteral>] ScrollViewPropsAndroid =
    /// Sometimes a scrollview takes up more space than its content fills.
    /// When this is the case, this prop will fill the rest of the
    /// scrollview with a color to avoid setting a background and creating
    /// unnecessary overdraw. This is an advanced optimization that is not
    /// needed in the general case.
    abstract endFillColor: string option with get, set
    /// <summary>
    /// Tag used to log scroll performance on this scroll view. Will force
    /// momentum events to be turned on (see sendMomentumEvents). This doesn't do
    /// anything out of the box and you need to implement a custom native
    /// FpsListener for it to be useful.
    /// </summary>
    abstract scrollPerfTag: string option with get, set
    /// Used to override default value of overScroll mode.
    /// 
    ///    Possible values:
    ///      - 'auto' - Default value, allow a user to over-scroll this view only if the content is large enough to meaningfully scroll.
    ///      - 'always' - Always allow a user to over-scroll this view.
    ///      - 'never' - Never allow a user to over-scroll this view.
    abstract overScrollMode: ScrollViewPropsAndroidOverScrollMode option with get, set
    /// Enables nested scrolling for Android API level 21+. Nested scrolling is supported by default on iOS.
    abstract nestedScrollEnabled: bool option with get, set

type [<AllowNullLiteral>] ScrollViewProps =
    inherit ViewProps
    inherit ScrollViewPropsIOS
    inherit ScrollViewPropsAndroid
    inherit Touchable
    /// These styles will be applied to the scroll view content container which
    /// wraps all of the child views. Example:
    /// 
    ///    return (
    ///      <ScrollView contentContainerStyle={styles.contentContainer}>
    ///      </ScrollView>
    ///    );
    ///    ...
    ///    const styles = StyleSheet.create({
    ///      contentContainer: {
    ///        paddingVertical: 20
    ///      }
    ///    });
    abstract contentContainerStyle: StyleProp<ViewStyle> option with get, set
    /// When true the scroll view's children are arranged horizontally in a row
    /// instead of vertically in a column. The default value is false.
    abstract horizontal: bool option with get, set
    /// Determines whether the keyboard gets dismissed in response to a drag.
    ///    - 'none' (the default) drags do not dismiss the keyboard.
    ///    - 'onDrag' the keyboard is dismissed when a drag begins.
    ///    - 'interactive' the keyboard is dismissed interactively with the drag
    ///      and moves in synchrony with the touch; dragging upwards cancels the
    ///      dismissal.
    abstract keyboardDismissMode: ScrollViewPropsKeyboardDismissMode option with get, set
    /// When false tapping outside of the focused text input when the keyboard
    /// is up dismisses the keyboard. When true the scroll view will not catch
    /// taps and the keyboard will not dismiss automatically. The default value
    /// is false.
    abstract keyboardShouldPersistTaps: U2<bool, string> option with get, set
    /// Called when scrollable content view of the ScrollView changes.
    /// Handler function is passed the content width and content height as parameters: (contentWidth, contentHeight)
    /// It's implemented using onLayout handler attached to the content container which this ScrollView renders.
    abstract onContentSizeChange: (float -> float -> unit) option with get, set
    /// Fires at most once per frame during scrolling.
    /// The frequency of the events can be contolled using the scrollEventThrottle prop.
    abstract onScroll: (NativeSyntheticEvent<NativeScrollEvent> -> unit) option with get, set
    /// Fires if a user initiates a scroll gesture.
    abstract onScrollBeginDrag: (NativeSyntheticEvent<NativeScrollEvent> -> unit) option with get, set
    /// Fires when a user has finished scrolling.
    abstract onScrollEndDrag: (NativeSyntheticEvent<NativeScrollEvent> -> unit) option with get, set
    /// Fires when scroll view has finished moving
    abstract onMomentumScrollEnd: (NativeSyntheticEvent<NativeScrollEvent> -> unit) option with get, set
    /// Fires when scroll view has begun moving
    abstract onMomentumScrollBegin: (NativeSyntheticEvent<NativeScrollEvent> -> unit) option with get, set
    /// When true the scroll view stops on multiples of the scroll view's size
    /// when scrolling. This can be used for horizontal pagination. The default
    /// value is false.
    abstract pagingEnabled: bool option with get, set
    /// When false, the content does not scroll. The default value is true
    abstract scrollEnabled: bool option with get, set
    /// <summary>
    /// Experimental: When true offscreen child views (whose <c>overflow</c> value is
    /// <c>hidden</c>) are removed from their native backing superview when offscreen.
    /// This canimprove scrolling performance on long lists. The default value is
    /// false.
    /// </summary>
    abstract removeClippedSubviews: bool option with get, set
    /// When true, shows a horizontal scroll indicator.
    abstract showsHorizontalScrollIndicator: bool option with get, set
    /// When true, shows a vertical scroll indicator.
    abstract showsVerticalScrollIndicator: bool option with get, set
    /// Style
    abstract style: StyleProp<ViewStyle> option with get, set
    /// A RefreshControl component, used to provide pull-to-refresh
    /// functionality for the ScrollView.
    abstract refreshControl: React.ReactElement<RefreshControlProps> option with get, set

type [<AllowNullLiteral>] ScrollViewComponent =
    inherit React.Component<ScrollViewProps>

type [<AllowNullLiteral>] ScrollViewComponentStatic =
    [<EmitConstructor>] abstract Create: unit -> ScrollViewComponent

type [<AllowNullLiteral>] ScrollView =
    inherit ScrollViewBase
    /// Scrolls to a given x, y offset, either immediately or with a smooth animation.
    /// Syntax:
    /// 
    /// scrollTo(options: {x: number = 0; y: number = 0; animated: boolean = true})
    /// 
    /// Note: The weird argument signature is due to the fact that, for historical reasons,
    /// the function also accepts separate arguments as as alternative to the options object.
    /// This is deprecated due to ambiguity (y before x), and SHOULD NOT BE USED.
    abstract scrollTo: ?y: U2<float, RecyclerViewBackedScrollViewScrollTo> * ?x: float * ?animated: bool -> unit
    /// A helper function that scrolls to the end of the scrollview;
    /// If this is a vertical ScrollView, it scrolls to the bottom.
    /// If this is a horizontal ScrollView scrolls to the right.
    /// 
    /// The options object has an animated prop, that enables the scrolling animation or not.
    /// The animated prop defaults to true
    abstract scrollToEnd: ?options: ScrollViewScrollToEndOptions -> unit
    /// <summary>
    /// Returns a reference to the underlying scroll responder, which supports
    /// operations like <c>scrollTo</c>. All ScrollView-like components should
    /// implement this method so that they can be composed while providing access
    /// to the underlying scroll responder's methods.
    /// </summary>
    abstract getScrollResponder: unit -> JSX.Element
    abstract getScrollableNode: unit -> obj option
    abstract getInnerViewNode: unit -> obj option
    abstract scrollWithoutAnimationTo: (float -> float -> unit) option with get, set

type [<AllowNullLiteral>] ScrollViewScrollToEndOptions =
    abstract animated: bool with get, set

type [<AllowNullLiteral>] ScrollViewStatic =
    [<EmitConstructor>] abstract Create: unit -> ScrollView

type [<AllowNullLiteral>] NativeScrollRectangle =
    abstract left: float with get, set
    abstract top: float with get, set
    abstract bottom: float with get, set
    abstract right: float with get, set

type [<AllowNullLiteral>] NativeScrollPoint =
    abstract x: float with get, set
    abstract y: float with get, set

type [<AllowNullLiteral>] NativeScrollVelocity =
    abstract x: float with get, set
    abstract y: float with get, set

type [<AllowNullLiteral>] NativeScrollSize =
    abstract height: float with get, set
    abstract width: float with get, set

type [<AllowNullLiteral>] NativeScrollEvent =
    abstract contentInset: NativeScrollRectangle with get, set
    abstract contentOffset: NativeScrollPoint with get, set
    abstract contentSize: NativeScrollSize with get, set
    abstract layoutMeasurement: NativeScrollSize with get, set
    abstract velocity: NativeScrollVelocity option with get, set
    abstract zoomScale: float with get, set

type [<AllowNullLiteral>] SnapshotViewIOSProps =
    inherit ViewProps
    abstract onSnapshotReady: unit -> obj option
    abstract testIdentifier: string with get, set

type [<AllowNullLiteral>] SnapshotViewIOSComponent =
    inherit React.Component<SnapshotViewIOSProps>

type [<AllowNullLiteral>] SnapshotViewIOSComponentStatic =
    [<EmitConstructor>] abstract Create: unit -> SnapshotViewIOSComponent

type [<AllowNullLiteral>] SnapshotViewIOS =
    inherit SnapshotViewIOSBase

type [<AllowNullLiteral>] SnapshotViewIOSStatic =
    [<EmitConstructor>] abstract Create: unit -> SnapshotViewIOS

/// <summary>
/// Data source wrapper around ListViewDataSource to allow for tracking of
/// which row is swiped open and close opened row(s) when another row is swiped
/// open.
/// 
/// See <see href="https://github.com/facebook/react-native/pull/5602" /> for why
/// ListViewDataSource is not subclassed.
/// </summary>
type [<AllowNullLiteral>] SwipeableListViewDataSource =
    abstract cloneWithRowsAndSections: dataBlob: obj option * ?sectionIdentities: Array<string> * ?rowIdentities: Array<Array<string>> -> SwipeableListViewDataSource
    abstract getDataSource: unit -> ListViewDataSource
    abstract getOpenRowID: unit -> string
    abstract getFirstRowID: unit -> string
    abstract setOpenRowID: rowID: string -> SwipeableListViewDataSource

type [<AllowNullLiteral>] SwipeableListViewProps =
    /// To alert the user that swiping is possible, the first row can bounce
    /// on component mount.
    abstract bounceFirstRowOnMount: bool with get, set
    /// <summary>
    /// Use <c>SwipeableListView.getNewDataSource()</c> to get a data source to use,
    /// then use it just like you would a normal ListView data source
    /// </summary>
    abstract dataSource: SwipeableListViewDataSource with get, set
    abstract maxSwipeDistance: float with get, set
    abstract renderRow: (obj option -> U2<string, float> -> U2<string, float> -> (bool) option -> React.ReactElement<obj option>) with get, set
    abstract renderQuickActions: rowData: obj option * sectionID: U2<string, float> * rowID: U2<string, float> -> React.ReactElement<obj option>

/// <summary>
/// A container component that renders multiple SwipeableRow's in a ListView
/// implementation. This is designed to be a drop-in replacement for the
/// standard React Native <c>ListView</c>, so use it as if it were a ListView, but
/// with extra props, i.e.
/// 
/// let ds = SwipeableListView.getNewDataSource();
/// ds.cloneWithRowsAndSections(dataBlob, ?sectionIDs, ?rowIDs);
/// // ..
/// &lt;SwipeableListView renderRow={..} renderQuickActions={..} {..ListView props} /&gt;
/// 
/// SwipeableRow can be used independently of this component, but the main
/// benefit of using this component is
/// 
/// - It ensures that at most 1 row is swiped open (auto closes others)
/// - It can bounce the 1st row of the list so users know it's swipeable
/// - More to come
/// </summary>
type [<AllowNullLiteral>] SwipeableListView =
    inherit React.Component<SwipeableListViewProps>

/// <summary>
/// A container component that renders multiple SwipeableRow's in a ListView
/// implementation. This is designed to be a drop-in replacement for the
/// standard React Native <c>ListView</c>, so use it as if it were a ListView, but
/// with extra props, i.e.
/// 
/// let ds = SwipeableListView.getNewDataSource();
/// ds.cloneWithRowsAndSections(dataBlob, ?sectionIDs, ?rowIDs);
/// // ..
/// &lt;SwipeableListView renderRow={..} renderQuickActions={..} {..ListView props} /&gt;
/// 
/// SwipeableRow can be used independently of this component, but the main
/// benefit of using this component is
/// 
/// - It ensures that at most 1 row is swiped open (auto closes others)
/// - It can bounce the 1st row of the list so users know it's swipeable
/// - More to come
/// </summary>
type [<AllowNullLiteral>] SwipeableListViewStatic =
    [<EmitConstructor>] abstract Create: unit -> SwipeableListView
    abstract getNewDataSource: unit -> SwipeableListViewDataSource

/// <seealso cref=":"><see href="http://facebook.github.io/react-native/docs/actionsheetios.html#content" /></seealso>
type [<AllowNullLiteral>] ActionSheetIOSOptions =
    abstract title: string option with get, set
    abstract options: ResizeArray<string> with get, set
    abstract cancelButtonIndex: float option with get, set
    abstract destructiveButtonIndex: float option with get, set
    abstract message: string option with get, set
    abstract tintColor: string option with get, set

type [<AllowNullLiteral>] ShareActionSheetIOSOptions =
    abstract message: string option with get, set
    abstract url: string option with get, set
    abstract subject: string option with get, set
    /// The activities to exclude from the ActionSheet.
    /// For example: ['com.apple.UIKit.activity.PostToTwitter']
    abstract excludedActivityTypes: ResizeArray<string> option with get, set

/// <seealso href="https://facebook.github.io/react-native/docs/actionsheetios.html#content" />
type [<AllowNullLiteral>] ActionSheetIOSStatic =
    /// <summary>
    /// Display an iOS action sheet. The <c>options</c> object must contain one or more
    /// of:
    /// - <c>options</c> (array of strings) - a list of button titles (required)
    /// - <c>cancelButtonIndex</c> (int) - index of cancel button in <c>options</c>
    /// - <c>destructiveButtonIndex</c> (int) - index of destructive button in <c>options</c>
    /// - <c>title</c> (string) - a title to show above the action sheet
    /// - <c>message</c> (string) - a message to show below the title
    /// </summary>
    abstract showActionSheetWithOptions: (ActionSheetIOSOptions -> (float -> unit) -> unit) with get, set
    /// <summary>
    /// Display the iOS share sheet. The <c>options</c> object should contain
    /// one or both of <c>message</c> and <c>url</c> and can additionally have
    /// a <c>subject</c> or <c>excludedActivityTypes</c>:
    /// 
    /// - <c>url</c> (string) - a URL to share
    /// - <c>message</c> (string) - a message to share
    /// - <c>subject</c> (string) - a subject for the message
    /// - <c>excludedActivityTypes</c> (array) - the activities to exclude from the ActionSheet
    /// 
    /// NOTE: if <c>url</c> points to a local file, or is a base64-encoded
    /// uri, the file it points to will be loaded and shared directly.
    /// In this way, you can share images, videos, PDF files, etc.
    /// </summary>
    abstract showShareActionSheetWithOptions: (ShareActionSheetIOSOptions -> (Error -> unit) -> (bool -> string -> unit) -> unit) with get, set

type ShareContent =
    U4<string, string, string, string>

type [<AllowNullLiteral>] ShareOptions =
    abstract dialogTitle: string option with get, set
    abstract excludedActivityTypes: Array<string> option with get, set
    abstract tintColor: string option with get, set

type [<AllowNullLiteral>] ShareStatic =
    /// <summary>
    /// Open a dialog to share text content.
    /// 
    /// In iOS, Returns a Promise which will be invoked an object containing <c>action</c>, <c>activityType</c>.
    /// If the user dismissed the dialog, the Promise will still be resolved with action being <c>Share.dismissedAction</c>
    /// and all the other keys being undefined.
    /// 
    /// In Android, Returns a Promise which always be resolved with action being <c>Share.sharedAction</c>.
    /// 
    /// ### Content
    /// 
    ///   - <c>message</c> - a message to share
    ///   - <c>title</c> - title of the message
    /// 
    /// #### iOS
    /// 
    ///   - <c>url</c> - an URL to share
    /// 
    /// At least one of URL and message is required.
    /// 
    /// ### Options
    /// 
    /// #### iOS
    /// 
    /// - <c>excludedActivityTypes</c>
    /// - <c>tintColor</c>
    /// 
    /// #### Android
    /// 
    /// - <c>dialogTitle</c>
    /// </summary>
    abstract share: content: ShareContent * ?options: ShareOptions -> Promise<Object>
    abstract sharedAction: string with get, set
    abstract dismissedAction: string with get, set

type [<StringEnum>] [<RequireQualifiedAccess>] AccessibilityEventName =
    | Change
    | AnnouncementFinished

type AccessibilityChangeEvent =
    bool

type [<AllowNullLiteral>] AccessibilityAnnoucementFinishedEvent =
    abstract announcement: string with get, set
    abstract success: bool with get, set

type AccessibilityEvent =
    U2<AccessibilityChangeEvent, AccessibilityAnnoucementFinishedEvent>

/// <seealso href="https://facebook.github.io/react-native/docs/accessibilityinfo.html" />
type [<AllowNullLiteral>] AccessibilityInfoStatic =
    /// Query whether a screen reader is currently enabled.
    /// Returns a promise which resolves to a boolean. The result is true when a screen reader is enabled and false otherwise.
    abstract fetch: (unit -> Promise<bool>) with get, set
    /// Add an event handler. Supported events:
    ///   - change: Fires when the state of the screen reader changes.
    ///             The argument to the event handler is a boolean.
    ///             The boolean is true when a screen reader is enabled and false otherwise.
    /// 
    /// - announcementFinished: iOS-only event. Fires when the screen reader has finished making an announcement.
    ///                          The argument to the event handler is a dictionary with these keys:
    ///                           - announcement: The string announced by the screen reader.
    ///                           - success: A boolean indicating whether the announcement was successfully made.
    abstract addEventListener: (AccessibilityEventName -> (AccessibilityEvent -> unit) -> unit) with get, set
    /// Remove an event handler.
    abstract removeEventListener: (AccessibilityEventName -> (AccessibilityEvent -> unit) -> unit) with get, set
    /// <summary>Set acessibility focus to a react component.</summary>
    abstract setAccessibilityFocus: (float -> unit) with get, set
    /// <summary>Post a string to be announced by the screen reader.</summary>
    abstract announceForAccessibility: (string -> unit) with get, set

/// <seealso href="https://facebook.github.io/react-native/docs/alert.html#content" />
type [<AllowNullLiteral>] AlertButton =
    abstract text: string option with get, set
    abstract onPress: (unit -> unit) option with get, set
    abstract style: AlertButtonStyle option with get, set

type [<AllowNullLiteral>] AlertOptions =
    abstract cancelable: bool option with get, set
    abstract onDismiss: (unit -> unit) option with get, set

/// <summary>
/// Launches an alert dialog with the specified title and message.
/// 
/// Optionally provide a list of buttons. Tapping any button will fire the
/// respective onPress callback and dismiss the alert. By default, the only
/// button will be an 'OK' button.
/// 
/// This is an API that works both on iOS and Android and can show static
/// alerts. To show an alert that prompts the user to enter some information,
/// see <c>AlertIOS</c>; entering text in an alert is common on iOS only.
/// 
/// ## iOS
/// 
/// On iOS you can specify any number of buttons. Each button can optionally
/// specify a style, which is one of 'default', 'cancel' or 'destructive'.
/// 
/// ## Android
/// 
/// On Android at most three buttons can be specified. Android has a concept
/// of a neutral, negative and a positive button:
/// 
///    - If you specify one button, it will be the 'positive' one (such as 'OK')
///    - Two buttons mean 'negative', 'positive' (such as 'Cancel', 'OK')
///    - Three buttons mean 'neutral', 'negative', 'positive' (such as 'Later', 'Cancel', 'OK')
/// 
/// <code>
/// // Works on both iOS and Android
/// Alert.alert(
///    'Alert Title',
///    'My Alert Msg',
///    [
///      {text: 'Ask me later', onPress: () =&gt; console.log('Ask me later pressed')},
///      {text: 'Cancel', onPress: () =&gt; console.log('Cancel Pressed'), style: 'cancel'},
///      {text: 'OK', onPress: () =&gt; console.log('OK Pressed')},
///    ]
/// )
/// </code>
/// </summary>
type [<AllowNullLiteral>] AlertStatic =
    abstract alert: (string -> (string) option -> (ResizeArray<AlertButton>) option -> (AlertOptions) option -> (string) option -> unit) with get, set

/// Wrapper around the Android native module.
type [<AllowNullLiteral>] AlertAndroidStatic =
    abstract alert: (string -> (string) option -> (ResizeArray<AlertButton>) option -> (AlertOptions) option -> unit) with get, set

/// //FIXME: No documentation - inferred from RCTAdSupport.m
type [<AllowNullLiteral>] AdSupportIOSStatic =
    abstract getAdvertisingId: ((string -> unit) -> (Error -> unit) -> unit) with get, set
    abstract getAdvertisingTrackingEnabled: ((bool -> unit) -> (Error -> unit) -> unit) with get, set

type [<AllowNullLiteral>] AlertIOSButton =
    abstract text: string with get, set
    abstract onPress: ((string) option -> unit) option with get, set
    abstract style: AlertButtonStyle option with get, set

type [<StringEnum>] [<RequireQualifiedAccess>] AlertType =
    | Default
    | [<CompiledName "plain-text">] PlainText
    | [<CompiledName "secure-text">] SecureText
    | [<CompiledName "login-password">] LoginPassword

/// <summary>
/// <c>AlertIOS</c> provides functionality to create an iOS alert dialog with a
/// message or create a prompt for user input.
/// 
/// We recommend using the <see cref="/docs/alert.html"><c>Alert.alert</c></see> method for
/// cross-platform support if you don't need to create iOS-only prompts.
/// </summary>
/// <seealso href="https://facebook.github.io/react-native/docs/alertios.html#content" />
type [<AllowNullLiteral>] AlertIOSStatic =
    /// <summary>Create and display a popup alert.</summary>
    /// <param name="title">The dialog's title.</param>
    /// <param name="message">
    /// An optional message that appears below
    /// the dialog's title.
    /// </param>
    /// <param name="callbackOrButtons">
    /// This optional argument should
    /// be either a single-argument function or an array of buttons. If passed
    /// a function, it will be called when the user taps 'OK'.
    /// 
    /// If passed an array of button configurations, each button should include
    /// a <c>text</c> key, as well as optional <c>onPress</c> and <c>style</c> keys. <c>style</c>
    /// should be one of 'default', 'cancel' or 'destructive'.
    /// </param>
    /// <param name="type">Deprecated, do not use.</param>
    abstract alert: (string -> (string) option -> (U2<(unit -> unit), Array<AlertIOSButton>>) option -> (AlertType) option -> unit) with get, set
    /// <summary>Create and display a prompt to enter some text.</summary>
    /// <param name="title">The dialog's title.</param>
    /// <param name="message">
    /// An optional message that appears above the text
    /// input.
    /// </param>
    /// <param name="callbackOrButtons">
    /// This optional argument should
    /// be either a single-argument function or an array of buttons. If passed
    /// a function, it will be called with the prompt's value when the user
    /// taps 'OK'.
    /// 
    /// If passed an array of button configurations, each button should include
    /// a <c>text</c> key, as well as optional <c>onPress</c> and <c>style</c> keys (see
    /// example). <c>style</c> should be one of 'default', 'cancel' or 'destructive'.
    /// </param>
    /// <param name="type">
    /// This configures the text input. One of 'plain-text',
    /// 'secure-text' or 'login-password'.
    /// </param>
    /// <param name="defaultValue">The default text in text input.</param>
    abstract prompt: (string -> (string) option -> (U2<(string -> unit), Array<AlertIOSButton>>) option -> (AlertType) option -> (string) option -> (U2<KeyboardType, KeyboardTypeIOS>) option -> unit) with get, set

/// <summary>
/// AppStateIOS can tell you if the app is in the foreground or background,
/// and notify you when the state changes.
/// 
/// AppStateIOS is frequently used to determine the intent and proper behavior
/// when handling push notifications.
/// 
/// iOS App States
///       active - The app is running in the foreground
///       background - The app is running in the background. The user is either in another app or on the home screen
///       inactive - This is a transition state that currently never happens for typical React Native apps.
/// 
/// For more information, see Apple's documentation: <see href="https://developer.apple.com/library/ios/documentation/iPhone/Conceptual/iPhoneOSProgrammingGuide/TheAppLifeCycle/TheAppLifeCycle.html" />
/// </summary>
/// <seealso href="https://facebook.github.io/react-native/docs/appstateios.html#content" />
type [<StringEnum>] [<RequireQualifiedAccess>] AppStateEvent =
    | Change
    | MemoryWarning

type [<StringEnum>] [<RequireQualifiedAccess>] AppStateStatus =
    | Active
    | Background
    | Inactive

type [<AllowNullLiteral>] AppStateStatic =
    abstract currentState: AppStateStatus with get, set
    /// Add a handler to AppState changes by listening to the change event
    /// type and providing the handler
    abstract addEventListener: ``type``: AppStateEvent * listener: (AppStateStatus -> unit) -> unit
    /// Remove a handler by passing the change event type and the handler
    abstract removeEventListener: ``type``: AppStateEvent * listener: (AppStateStatus -> unit) -> unit

/// <summary>
/// AsyncStorage is a simple, unencrypted, asynchronous, persistent, key-value storage
/// system that is global to the app.  It should be used instead of LocalStorage.
/// 
/// It is recommended that you use an abstraction on top of <c>AsyncStorage</c>
/// instead of <c>AsyncStorage</c> directly for anything more than light usage since
/// it operates globally.
/// 
/// On iOS, <c>AsyncStorage</c> is backed by native code that stores small values in a
/// serialized dictionary and larger values in separate files. On Android,
/// <c>AsyncStorage</c> will use either <see href="http://rocksdb.org/">RocksDB</see> or SQLite
/// based on what is available.
/// </summary>
/// <seealso href="https://facebook.github.io/react-native/docs/asyncstorage.html#content" />
type [<AllowNullLiteral>] AsyncStorageStatic =
    /// Fetches key and passes the result to callback, along with an Error if there is any.
    abstract getItem: key: string * ?callback: ((Error) option -> (string) option -> unit) -> Promise<string option>
    /// Sets value for key and calls callback on completion, along with an Error if there is any
    abstract setItem: key: string * value: string * ?callback: ((Error) option -> unit) -> Promise<unit>
    abstract removeItem: key: string * ?callback: ((Error) option -> unit) -> Promise<unit>
    /// Merges existing value with input value, assuming they are stringified json. Returns a Promise object.
    /// Not supported by all native implementation
    abstract mergeItem: key: string * value: string * ?callback: ((Error) option -> unit) -> Promise<unit>
    /// Erases all AsyncStorage for all clients, libraries, etc. You probably don't want to call this.
    /// Use removeItem or multiRemove to clear only your own keys instead.
    abstract clear: ?callback: ((Error) option -> unit) -> Promise<unit>
    /// Gets all keys known to the app, for all callers, libraries, etc
    abstract getAllKeys: ?callback: ((Error) option -> (ResizeArray<string>) option -> unit) -> Promise<ResizeArray<string>>
    /// multiGet invokes callback with an array of key-value pair arrays that matches the input format of multiSet
    abstract multiGet: keys: ResizeArray<string> * ?callback: ((ResizeArray<Error>) option -> (ResizeArray<string * string>) option -> unit) -> Promise<ResizeArray<string * string>>
    /// multiSet and multiMerge take arrays of key-value array pairs that match the output of multiGet,
    /// 
    /// multiSet([['k1', 'val1'], ['k2', 'val2']], cb);
    abstract multiSet: keyValuePairs: ResizeArray<ResizeArray<string>> * ?callback: ((ResizeArray<Error>) option -> unit) -> Promise<unit>
    /// Delete all the keys in the keys array.
    abstract multiRemove: keys: ResizeArray<string> * ?callback: ((ResizeArray<Error>) option -> unit) -> Promise<unit>
    /// Merges existing values with input values, assuming they are stringified json.
    /// Returns a Promise object.
    /// 
    /// Not supported by all native implementations.
    abstract multiMerge: keyValuePairs: ResizeArray<ResizeArray<string>> * ?callback: ((ResizeArray<Error>) option -> unit) -> Promise<unit>

type BackPressEventName =
    string

/// Detect hardware back button presses, and programmatically invoke the
/// default back button functionality to exit the app if there are no
/// listeners or if none of the listeners return true.
/// Methods don't have more detailed documentation as of 0.25.
type [<AllowNullLiteral>] BackAndroidStatic =
    abstract exitApp: unit -> unit
    abstract addEventListener: eventName: BackPressEventName * handler: (unit -> unit) -> unit
    abstract removeEventListener: eventName: BackPressEventName * handler: (unit -> unit) -> unit

/// Detect hardware back button presses, and programmatically invoke the
/// default back button functionality to exit the app if there are no
/// listeners or if none of the listeners return true.
/// Methods don't have more detailed documentation as of 0.25.
type [<AllowNullLiteral>] BackHandlerStatic =
    abstract exitApp: unit -> unit
    abstract addEventListener: eventName: BackPressEventName * handler: (unit -> unit) -> NativeEventSubscription
    abstract removeEventListener: eventName: BackPressEventName * handler: (unit -> unit) -> unit

type [<AllowNullLiteral>] ButtonProps =
    abstract title: string with get, set
    abstract onPress: (NativeSyntheticEvent<NativeTouchEvent> -> unit) with get, set
    abstract color: string option with get, set
    abstract accessibilityLabel: string option with get, set
    abstract disabled: bool option with get, set
    /// Used to locate this button in end-to-end tests.
    abstract testID: string option with get, set

type [<AllowNullLiteral>] Button =
    inherit React.Component<ButtonProps>

type [<AllowNullLiteral>] ButtonStatic =
    [<EmitConstructor>] abstract Create: unit -> Button

type [<StringEnum>] [<RequireQualifiedAccess>] CameraRollGroupType =
    | [<CompiledName "Album">] Album
    | [<CompiledName "All">] All
    | [<CompiledName "Event">] Event
    | [<CompiledName "Faces">] Faces
    | [<CompiledName "Library">] Library
    | [<CompiledName "PhotoStream">] PhotoStream
    | [<CompiledName "SavedPhotos">] SavedPhotos

type [<StringEnum>] [<RequireQualifiedAccess>] CameraRollAssetType =
    | [<CompiledName "All">] All
    | [<CompiledName "Videos">] Videos
    | [<CompiledName "Photos">] Photos

type [<AllowNullLiteral>] CameraRollFetchParams =
    abstract first: float with get, set
    abstract after: string option with get, set
    abstract groupTypes: CameraRollGroupType option with get, set
    abstract groupName: string option with get, set
    abstract assetType: CameraRollAssetType option with get, set

type [<AllowNullLiteral>] CameraRollNodeInfo =
    abstract image: Image with get, set
    abstract group_name: string with get, set
    abstract timestamp: float with get, set
    abstract location: obj option with get, set

type [<AllowNullLiteral>] CameraRollEdgeInfo =
    abstract node: CameraRollNodeInfo with get, set

type [<AllowNullLiteral>] CameraRollAssetInfo =
    abstract edges: ResizeArray<CameraRollEdgeInfo> with get, set
    abstract page_info: CameraRollAssetInfoPage_info with get, set

type [<AllowNullLiteral>] GetPhotosParamType =
    abstract first: float with get, set
    abstract after: string option with get, set
    abstract groupTypes: CameraRollGroupType option with get, set
    abstract groupName: string option with get, set
    abstract assetType: CameraRollAssetType option with get, set
    abstract mimeTypes: ResizeArray<string> option with get, set

type [<AllowNullLiteral>] GetPhotosReturnType =
    abstract edges: ResizeArray<GetPhotosReturnTypeEdges> with get, set
    abstract page_info: GetPhotosReturnTypePage_info with get, set

/// <summary>
/// CameraRoll provides access to the local camera roll / gallery.
/// Before using this you must link the RCTCameraRoll library.
/// You can refer to (Linking)[<see href="https://facebook.github.io/react-native/docs/linking-libraries-ios.html]" /> for help.
/// </summary>
type [<AllowNullLiteral>] CameraRollStatic =
    abstract GroupTypesOptions: ResizeArray<CameraRollGroupType> with get, set
    abstract AssetTypeOptions: ResizeArray<CameraRollAssetType> with get, set
    /// <summary>Saves the image to the camera roll / gallery.</summary>
    [<Obsolete("use saveToCameraRoll instead")>]
    abstract saveImageWithTag: tag: string -> Promise<string>
    /// <summary>
    /// Saves the photo or video to the camera roll / gallery.
    /// 
    /// On Android, the tag must be a local image or video URI, such as <c>"file:///sdcard/img.png"</c>.
    /// 
    /// On iOS, the tag can be any image URI (including local, remote asset-library and base64 data URIs)
    /// or a local video file URI (remote or data URIs are not supported for saving video at this time).
    /// 
    /// If the tag has a file extension of .mov or .mp4, it will be inferred as a video. Otherwise
    /// it will be treated as a photo. To override the automatic choice, you can pass an optional
    /// <c>type</c> parameter that must be one of 'photo' or 'video'.
    /// 
    /// Returns a Promise which will resolve with the new URI.
    /// </summary>
    abstract saveToCameraRoll: tag: string * ?``type``: CameraRollStaticSaveToCameraRollType -> Promise<string>
    /// <summary>Invokes callback with photo identifier objects from the local camera roll of the device matching shape defined by getPhotosReturnChecker.</summary>
    /// <param name="params">See getPhotosParamChecker.</param>
    abstract getPhotos: ``params``: GetPhotosParamType -> Promise<GetPhotosReturnType>

type [<StringEnum>] [<RequireQualifiedAccess>] CameraRollStaticSaveToCameraRollType =
    | Photo
    | Video

/// Clipboard gives you an interface for setting and getting content from Clipboard on both iOS and Android
type [<AllowNullLiteral>] ClipboardStatic =
    abstract getString: unit -> Promise<string>
    abstract setString: content: string -> unit

type [<AllowNullLiteral>] DatePickerAndroidOpenOptions =
    abstract date: U2<DateTime, float> option with get, set
    abstract minDate: U2<DateTime, float> option with get, set
    abstract maxDate: U2<DateTime, float> option with get, set
    abstract mode: DatePickerAndroidOpenOptionsMode option with get, set

type [<AllowNullLiteral>] DatePickerAndroidOpenReturn =
    abstract action: string with get, set
    abstract year: float option with get, set
    abstract month: float option with get, set
    abstract day: float option with get, set

type [<AllowNullLiteral>] DatePickerAndroidStatic =
    /// Opens the standard Android date picker dialog.
    /// 
    /// The available keys for the options object are:
    /// - date (Date object or timestamp in milliseconds) - date to show by default
    /// - minDate (Date or timestamp in milliseconds) - minimum date that can be selected
    /// - maxDate (Date object or timestamp in milliseconds) - maximum date that can be selected
    /// - mode (enum('calendar', 'spinner', 'default')) - To set the date-picker mode to calendar/spinner/default
    ///   - 'calendar': Show a date picker in calendar mode.
    ///   - 'spinner': Show a date picker in spinner mode.
    ///   - 'default': Show a default native date picker(spinner/calendar) based on android versions.
    /// 
    /// Returns a Promise which will be invoked an object containing action, year, month (0-11), day if the user picked a date.
    /// If the user dismissed the dialog, the Promise will still be resolved with action being DatePickerAndroid.dismissedAction and all the other keys being undefined.
    /// Always check whether the action before reading the values.
    /// 
    /// Note the native date picker dialog has some UI glitches on Android 4 and lower when using the minDate and maxDate options.
    abstract ``open``: ?options: DatePickerAndroidOpenOptions -> Promise<DatePickerAndroidOpenReturn>
    /// A date has been selected.
    abstract dateSetAction: string with get, set
    /// The dialog has been dismissed.
    abstract dismissedAction: string with get, set

type [<AllowNullLiteral>] IntentAndroidStatic =
    /// <summary>
    /// Starts a corresponding external activity for the given URL.
    /// 
    ///   For example, if the URL is "<see href="https://www.facebook.com"," /> the system browser will be opened, or the "choose application" dialog will be shown.
    /// 
    ///   You can use other URLs, like a location (e.g. "geo:37.484847,-122.148386"), a contact, or any other URL that can be opened with {@code Intent.ACTION_VIEW}.
    /// 
    ///   NOTE: This method will fail if the system doesn't know how to open the specified URL. If you're passing in a non-http(s) URL, it's best to check {@code canOpenURL} first.
    /// 
    ///   NOTE: For web URLs, the protocol ("<see href="http://"," /> "<see href="https://")" /> must be set accordingly!
    /// </summary>
    [<Obsolete("")>]
    abstract openURL: url: string -> unit
    /// <summary>
    /// Determine whether or not an installed app can handle a given URL.
    /// 
    ///   You can use other URLs, like a location (e.g. "geo:37.484847,-122.148386"), a contact, or any other URL that can be opened with {@code Intent.ACTION_VIEW}.
    /// 
    ///   NOTE: For web URLs, the protocol ("<see href="http://"," /> "<see href="https://")" /> must be set accordingly!
    /// </summary>
    /// <param name="URL">the URL to open</param>
    [<Obsolete("")>]
    abstract canOpenURL: url: string * callback: (bool -> unit) -> unit
    /// <summary>
    /// If the app launch was triggered by an app link with {@code Intent.ACTION_VIEW}, it will give the link url, otherwise it will give null
    /// 
    ///   Refer <see href="http://developer.android.com/training/app-indexing/deep-linking.html#handling-intents" />
    /// </summary>
    [<Obsolete("")>]
    abstract getInitialURL: callback: (string -> unit) -> unit

type [<AllowNullLiteral>] LinkingStatic =
    inherit NativeEventEmitter
    /// <summary>
    /// Add a handler to Linking changes by listening to the <c>url</c> event type
    /// and providing the handler
    /// </summary>
    abstract addEventListener: ``type``: string * handler: (LinkingStaticAddEventListener -> unit) -> unit
    /// <summary>Remove a handler by passing the <c>url</c> event type and the handler</summary>
    abstract removeEventListener: ``type``: string * handler: (LinkingStaticAddEventListener -> unit) -> unit
    /// <summary>
    /// Try to open the given url with any of the installed apps.
    /// You can use other URLs, like a location (e.g. "geo:37.484847,-122.148386"), a contact, or any other URL that can be opened with the installed apps.
    /// NOTE: This method will fail if the system doesn't know how to open the specified URL. If you're passing in a non-http(s) URL, it's best to check {@code canOpenURL} first.
    /// NOTE: For web URLs, the protocol ("<see href="http://"," /> "<see href="https://")" /> must be set accordingly!
    /// </summary>
    abstract openURL: url: string -> Promise<obj option>
    /// <summary>
    /// Determine whether or not an installed app can handle a given URL.
    /// NOTE: For web URLs, the protocol ("<see href="http://"," /> "<see href="https://")" /> must be set accordingly!
    /// NOTE: As of iOS 9, your app needs to provide the LSApplicationQueriesSchemes key inside Info.plist.
    /// </summary>
    /// <param name="URL">the URL to open</param>
    abstract canOpenURL: url: string -> Promise<bool>
    /// <summary>
    /// If the app launch was triggered by an app link with, it will give the link url, otherwise it will give null
    /// NOTE: To support deep linking on Android, refer <see href="http://developer.android.com/training/app-indexing/deep-linking.html#handling-intents" />
    /// </summary>
    abstract getInitialURL: unit -> Promise<string>

type [<AllowNullLiteral>] LinkingIOSStatic =
    /// Add a handler to LinkingIOS changes by listening to the url event type and providing the handler
    [<Obsolete("")>]
    abstract addEventListener: ``type``: string * handler: (LinkingStaticAddEventListener -> unit) -> unit
    /// Remove a handler by passing the url event type and the handler
    [<Obsolete("")>]
    abstract removeEventListener: ``type``: string * handler: (LinkingStaticAddEventListener -> unit) -> unit
    /// Try to open the given url with any of the installed apps.
    [<Obsolete("")>]
    abstract openURL: url: string -> unit
    /// Determine whether or not an installed app can handle a given URL. The callback function will be called with bool supported as the only argument
    /// NOTE: As of iOS 9, your app needs to provide the LSApplicationQueriesSchemes key inside Info.plist.
    [<Obsolete("")>]
    abstract canOpenURL: url: string * callback: (bool -> unit) -> unit
    /// If the app launch was triggered by an app link, it will pop the link url, otherwise it will return null
    [<Obsolete("")>]
    abstract popInitialURL: unit -> string

/// <summary>NetInfo exposes info about online/offline status</summary>
/// <seealso href="https://facebook.github.io/react-native/docs/netinfo.html#content" />
type [<StringEnum>] [<RequireQualifiedAccess>] ConnectionType =
    | None
    | Wifi
    | Cell
    | Unknown
    | [<CompiledName "NONE">] NONE
    | [<CompiledName "MOBILE">] MOBILE
    | [<CompiledName "WIFI">] WIFI
    | [<CompiledName "MOBILE_MMS">] MOBILE_MMS
    | [<CompiledName "MOBILE_SUPL">] MOBILE_SUPL
    | [<CompiledName "MOBILE_DUN">] MOBILE_DUN
    | [<CompiledName "MOBILE_HIPRI">] MOBILE_HIPRI
    | [<CompiledName "WIMAX">] WIMAX
    | [<CompiledName "BLUETOOTH">] BLUETOOTH
    | [<CompiledName "DUMMY">] DUMMY
    | [<CompiledName "ETHERNET">] ETHERNET
    | [<CompiledName "MOBILE_FOTA">] MOBILE_FOTA
    | [<CompiledName "MOBILE_IMS">] MOBILE_IMS
    | [<CompiledName "MOBILE_CBS">] MOBILE_CBS
    | [<CompiledName "WIFI_P2P">] WIFI_P2P
    | [<CompiledName "MOBILE_IA">] MOBILE_IA
    | [<CompiledName "MOBILE_EMERGENCY">] MOBILE_EMERGENCY
    | [<CompiledName "PROXY">] PROXY
    | [<CompiledName "VPN">] VPN
    | [<CompiledName "UNKNOWN">] UNKNOWN

type [<StringEnum>] [<RequireQualifiedAccess>] EffectiveConnectionType =
    | [<CompiledName "2g">] N2g
    | [<CompiledName "3g">] N3g
    | [<CompiledName "4g">] N4g
    | Unknown

type [<AllowNullLiteral>] ConnectionInfo =
    abstract ``type``: ConnectionType with get, set
    abstract effectiveType: EffectiveConnectionType with get, set

type [<AllowNullLiteral>] NetInfoStatic =
    /// <summary>
    /// This function is deprecated. Use <c>getConnectionInfo</c> instead. Returns a promise that
    /// resolves with one of the deprecated connectivity types listed above.
    /// </summary>
    abstract fetch: (unit -> Promise<ConnectionType>) with get, set
    /// <summary>
    /// Adds an event handler. Supported events:
    /// 
    /// - <c>connectionChange</c>: Fires when the network status changes. The argument to the event
    ///    handler is an object with keys:
    ///    - <c>type</c>: A <c>DeprecatedConnectionType</c> (listed above)
    ///    - <c>effectiveType</c>: An <c>EffectiveConnectionType</c> (listed above)
    /// - <c>change</c>: This event is deprecated. Listen to <c>connectionChange</c> instead. Fires when
    ///    the network status changes. The argument to the event handler is one of the deprecated
    ///    connectivity types listed above.
    /// </summary>
    abstract addEventListener: (string -> (U2<ConnectionInfo, ConnectionType> -> unit) -> unit) with get, set
    /// Removes the listener for network status changes.
    abstract removeEventListener: (string -> (U2<ConnectionInfo, ConnectionType> -> unit) -> unit) with get, set
    /// <summary>
    /// Returns a promise that resolves to an object with <c>type</c> and <c>effectiveType</c> keys
    /// whose values are a <c>ConnectionType</c> and an <c>EffectiveConnectionType</c>, (described above),
    /// respectively.
    /// </summary>
    abstract getConnectionInfo: (unit -> Promise<ConnectionInfo>) with get, set
    /// An object with the same methods as above but the listener receives a
    /// boolean which represents the internet connectivity.
    /// Use this if you are only interested with whether the device has internet
    /// connectivity.
    abstract isConnected: NetInfoStaticIsConnected with get, set
    /// Detect if the current active connection is
    /// metered or not. A network is classified as metered when the user is
    /// sensitive to heavy data usage on that connection due to monetary
    /// costs, data limitations or battery/performance issues.
    abstract isConnectionExpensive: (unit -> Promise<bool>) with get, set

type [<AllowNullLiteral>] PanResponderGestureState =
    /// ID of the gestureState- persisted as long as there at least one touch on
    abstract stateID: float with get, set
    /// the latest screen coordinates of the recently-moved touch
    abstract moveX: float with get, set
    /// the latest screen coordinates of the recently-moved touch
    abstract moveY: float with get, set
    /// the screen coordinates of the responder grant
    abstract x0: float with get, set
    /// the screen coordinates of the responder grant
    abstract y0: float with get, set
    /// accumulated distance of the gesture since the touch started
    abstract dx: float with get, set
    /// accumulated distance of the gesture since the touch started
    abstract dy: float with get, set
    /// current velocity of the gesture
    abstract vx: float with get, set
    /// current velocity of the gesture
    abstract vy: float with get, set
    /// Number of touches currently on screen
    abstract numberActiveTouches: float with get, set
    abstract _accountsForMovesUpTo: float with get, set

/// <seealso cref="documentation">of GestureResponderHandlers</seealso>
type [<AllowNullLiteral>] PanResponderCallbacks =
    abstract onMoveShouldSetPanResponder: (GestureResponderEvent -> PanResponderGestureState -> bool) option with get, set
    abstract onStartShouldSetPanResponder: (GestureResponderEvent -> PanResponderGestureState -> bool) option with get, set
    abstract onPanResponderGrant: (GestureResponderEvent -> PanResponderGestureState -> unit) option with get, set
    abstract onPanResponderMove: (GestureResponderEvent -> PanResponderGestureState -> unit) option with get, set
    abstract onPanResponderRelease: (GestureResponderEvent -> PanResponderGestureState -> unit) option with get, set
    abstract onPanResponderTerminate: (GestureResponderEvent -> PanResponderGestureState -> unit) option with get, set
    abstract onMoveShouldSetPanResponderCapture: (GestureResponderEvent -> PanResponderGestureState -> bool) option with get, set
    abstract onStartShouldSetPanResponderCapture: (GestureResponderEvent -> PanResponderGestureState -> bool) option with get, set
    abstract onPanResponderReject: (GestureResponderEvent -> PanResponderGestureState -> unit) option with get, set
    abstract onPanResponderStart: (GestureResponderEvent -> PanResponderGestureState -> unit) option with get, set
    abstract onPanResponderEnd: (GestureResponderEvent -> PanResponderGestureState -> unit) option with get, set
    abstract onPanResponderTerminationRequest: (GestureResponderEvent -> PanResponderGestureState -> bool) option with get, set
    abstract onShouldBlockNativeResponder: (GestureResponderEvent -> PanResponderGestureState -> bool) option with get, set

type [<AllowNullLiteral>] PanResponderInstance =
    abstract panHandlers: GestureResponderHandlers with get, set

/// PanResponder reconciles several touches into a single gesture.
/// It makes single-touch gestures resilient to extra touches,
/// and can be used to recognize simple multi-touch gestures.
/// 
/// It provides a predictable wrapper of the responder handlers provided by the gesture responder system.
/// For each handler, it provides a new gestureState object alongside the normal event.
type [<AllowNullLiteral>] PanResponderStatic =
    /// <param name="config">
    /// Enhanced versions of all of the responder callbacks
    /// that provide not only the typical <c>ResponderSyntheticEvent</c>, but also the
    /// <c>PanResponder</c> gesture state.  Simply replace the word <c>Responder</c> with
    /// <c>PanResponder</c> in each of the typical <c>onResponder*</c> callbacks. For
    /// example, the <c>config</c> object would look like:
    /// 
    /// - <c>onMoveShouldSetPanResponder: (e, gestureState) =&gt; {...}</c>
    /// - <c>onMoveShouldSetPanResponderCapture: (e, gestureState) =&gt; {...}</c>
    /// - <c>onStartShouldSetPanResponder: (e, gestureState) =&gt; {...}</c>
    /// - <c>onStartShouldSetPanResponderCapture: (e, gestureState) =&gt; {...}</c>
    /// - <c>onPanResponderReject: (e, gestureState) =&gt; {...}</c>
    /// - <c>onPanResponderGrant: (e, gestureState) =&gt; {...}</c>
    /// - <c>onPanResponderStart: (e, gestureState) =&gt; {...}</c>
    /// - <c>onPanResponderEnd: (e, gestureState) =&gt; {...}</c>
    /// - <c>onPanResponderRelease: (e, gestureState) =&gt; {...}</c>
    /// - <c>onPanResponderMove: (e, gestureState) =&gt; {...}</c>
    /// - <c>onPanResponderTerminate: (e, gestureState) =&gt; {...}</c>
    /// - <c>onPanResponderTerminationRequest: (e, gestureState) =&gt; {...}</c>
    /// - <c>onShouldBlockNativeResponder: (e, gestureState) =&gt; {...}</c>
    /// 
    /// In general, for events that have capture equivalents, we update the
    /// gestureState once in the capture phase and can use it in the bubble phase
    /// as well.
    /// 
    /// Be careful with onStartShould* callbacks. They only reflect updated
    /// <c>gestureState</c> for start/end events that bubble/capture to the Node.
    /// Once the node is the responder, you can rely on every start/end event
    /// being processed by the gesture and <c>gestureState</c> being updated
    /// accordingly. (numberActiveTouches) may not be totally accurate unless you
    /// are the responder.
    /// </param>
    abstract create: config: PanResponderCallbacks -> PanResponderInstance

type [<AllowNullLiteral>] Rationale =
    abstract title: string with get, set
    abstract message: string with get, set

type [<StringEnum>] [<RequireQualifiedAccess>] Permission =
    | [<CompiledName "android.permission.READ_CALENDAR">] Android_permission_READ_CALENDAR
    | [<CompiledName "android.permission.WRITE_CALENDAR">] Android_permission_WRITE_CALENDAR
    | [<CompiledName "android.permission.CAMERA">] Android_permission_CAMERA
    | [<CompiledName "android.permission.READ_CONTACTS">] Android_permission_READ_CONTACTS
    | [<CompiledName "android.permission.WRITE_CONTACTS">] Android_permission_WRITE_CONTACTS
    | [<CompiledName "android.permission.GET_ACCOUNTS">] Android_permission_GET_ACCOUNTS
    | [<CompiledName "android.permission.ACCESS_FINE_LOCATION">] Android_permission_ACCESS_FINE_LOCATION
    | [<CompiledName "android.permission.ACCESS_COARSE_LOCATION">] Android_permission_ACCESS_COARSE_LOCATION
    | [<CompiledName "android.permission.RECORD_AUDIO">] Android_permission_RECORD_AUDIO
    | [<CompiledName "android.permission.READ_PHONE_STATE">] Android_permission_READ_PHONE_STATE
    | [<CompiledName "android.permission.CALL_PHONE">] Android_permission_CALL_PHONE
    | [<CompiledName "android.permission.READ_CALL_LOG">] Android_permission_READ_CALL_LOG
    | [<CompiledName "android.permission.WRITE_CALL_LOG">] Android_permission_WRITE_CALL_LOG
    | [<CompiledName "com.android.voicemail.permission.ADD_VOICEMAIL">] Com_android_voicemail_permission_ADD_VOICEMAIL
    | [<CompiledName "android.permission.USE_SIP">] Android_permission_USE_SIP
    | [<CompiledName "android.permission.PROCESS_OUTGOING_CALLS">] Android_permission_PROCESS_OUTGOING_CALLS
    | [<CompiledName "android.permission.BODY_SENSORS">] Android_permission_BODY_SENSORS
    | [<CompiledName "android.permission.SEND_SMS">] Android_permission_SEND_SMS
    | [<CompiledName "android.permission.RECEIVE_SMS">] Android_permission_RECEIVE_SMS
    | [<CompiledName "android.permission.READ_SMS">] Android_permission_READ_SMS
    | [<CompiledName "android.permission.RECEIVE_WAP_PUSH">] Android_permission_RECEIVE_WAP_PUSH
    | [<CompiledName "android.permission.RECEIVE_MMS">] Android_permission_RECEIVE_MMS
    | [<CompiledName "android.permission.READ_EXTERNAL_STORAGE">] Android_permission_READ_EXTERNAL_STORAGE
    | [<CompiledName "android.permission.WRITE_EXTERNAL_STORAGE">] Android_permission_WRITE_EXTERNAL_STORAGE

type [<StringEnum>] [<RequireQualifiedAccess>] PermissionStatus =
    | Granted
    | Denied
    | Never_ask_again

type [<AllowNullLiteral>] PermissionsAndroidStatic =
    /// A list of permission results that are returned
    abstract RESULTS: PermissionsAndroidStaticRESULTS with get, set
    /// A list of specified "dangerous" permissions that require prompting the user
    abstract PERMISSIONS: PermissionsAndroidStaticPERMISSIONS with get, set
    /// Deprecated
    abstract checkPermission: permission: Permission -> Promise<bool>
    /// Returns a promise resolving to a boolean value as to whether the specified
    /// permissions has been granted
    abstract check: permission: Permission -> Promise<bool>
    /// Deprecated
    abstract requestPermission: permission: Permission * ?rationale: Rationale -> Promise<bool>
    /// <summary>
    /// Prompts the user to enable a permission and returns a promise resolving to a
    /// string value indicating whether the user allowed or denied the request
    /// 
    /// If the optional rationale argument is included (which is an object with a
    /// title and message), this function checks with the OS whether it is necessary
    /// to show a dialog explaining why the permission is needed
    /// (<see href="https://developer.android.com/training/permissions/requesting.html#explain)" />
    /// and then shows the system permission dialog
    /// </summary>
    abstract request: permission: Permission * ?rationale: Rationale -> Promise<string>
    /// Prompts the user to enable multiple permissions in the same dialog and
    /// returns an object with the permissions as keys and strings as values
    /// indicating whether the user allowed or denied the request
    abstract requestMultiple: permissions: Array<string> -> Promise<PermissionsAndroidStaticRequestMultiplePromise>

type [<AllowNullLiteral>] PermissionsAndroidStaticStatic =
    [<EmitConstructor>] abstract Create: unit -> PermissionsAndroidStatic

type [<AllowNullLiteral>] PushNotificationPermissions =
    abstract alert: bool option with get, set
    abstract badge: bool option with get, set
    abstract sound: bool option with get, set

type [<AllowNullLiteral>] PushNotification =
    /// <summary>An alias for <c>getAlert</c> to get the notification's main message string</summary>
    abstract getMessage: unit -> U2<string, Object>
    /// <summary>Gets the sound string from the <c>aps</c> object</summary>
    abstract getSound: unit -> string
    /// <summary>Gets the notification's main message from the <c>aps</c> object</summary>
    abstract getAlert: unit -> U2<string, Object>
    /// <summary>Gets the badge count number from the <c>aps</c> object</summary>
    abstract getBadgeCount: unit -> float
    /// Gets the data object on the notif
    abstract getData: unit -> Object
    /// iOS Only
    /// Signifies remote notification handling is complete
    abstract finish: result: string -> unit

type [<AllowNullLiteral>] PresentLocalNotificationDetails =
    abstract alertBody: string with get, set
    abstract alertAction: string with get, set
    abstract soundName: string option with get, set
    abstract category: string option with get, set
    abstract userInfo: Object option with get, set
    abstract applicationIconBadgeNumber: float option with get, set

type [<AllowNullLiteral>] ScheduleLocalNotificationDetails =
    abstract fireDate: DateTime with get, set
    abstract alertBody: string with get, set
    abstract alertAction: string with get, set
    abstract soundName: string option with get, set
    abstract category: string option with get, set
    abstract userInfo: Object option with get, set
    abstract applicationIconBadgeNumber: float option with get, set

type [<StringEnum>] [<RequireQualifiedAccess>] PushNotificationEventName =
    | Notification
    | LocalNotification
    | Register
    | RegistrationError

type [<AllowNullLiteral>] FetchResult =
    abstract NewData: string with get, set
    abstract NoData: string with get, set
    abstract ResultFailed: string with get, set

/// <summary>Handle push notifications for your app, including permission handling and icon badge number.</summary>
/// <seealso href="https://facebook.github.io/react-native/docs/pushnotificationios.html#content">
/// 
/// //FIXME: BGR: The documentation seems completely off compared to the actual js implementation. I could never get the example to run
/// </seealso>
type [<AllowNullLiteral>] PushNotificationIOSStatic =
    /// Schedules the localNotification for immediate presentation.
    /// details is an object containing:
    /// alertBody : The message displayed in the notification alert.
    /// alertAction : The "action" displayed beneath an actionable notification. Defaults to "view";
    /// soundName : The sound played when the notification is fired (optional).
    /// category : The category of this notification, required for actionable notifications (optional).
    /// userInfo : An optional object containing additional notification data.
    /// applicationIconBadgeNumber (optional) : The number to display as the app's icon badge. The default value of this property is 0, which means that no badge is displayed.
    abstract presentLocalNotification: details: PresentLocalNotificationDetails -> unit
    /// Schedules the localNotification for future presentation.
    /// details is an object containing:
    /// fireDate : The date and time when the system should deliver the notification.
    /// alertBody : The message displayed in the notification alert.
    /// alertAction : The "action" displayed beneath an actionable notification. Defaults to "view";
    /// soundName : The sound played when the notification is fired (optional).
    /// category : The category of this notification, required for actionable notifications (optional).
    /// userInfo : An optional object containing additional notification data.
    /// applicationIconBadgeNumber (optional) : The number to display as the app's icon badge. Setting the number to 0 removes the icon badge.
    abstract scheduleLocalNotification: details: ScheduleLocalNotificationDetails -> unit
    /// Cancels all scheduled localNotifications
    abstract cancelAllLocalNotifications: unit -> unit
    /// Cancel local notifications.
    /// Optionally restricts the set of canceled notifications to those notifications whose userInfo fields match the corresponding fields in the userInfo argument.
    abstract cancelLocalNotifications: userInfo: Object -> unit
    /// Sets the badge number for the app icon on the home screen
    abstract setApplicationIconBadgeNumber: number: float -> unit
    /// Gets the current badge number for the app icon on the home screen
    abstract getApplicationIconBadgeNumber: callback: (float -> unit) -> unit
    /// Gets the local notifications that are currently scheduled.
    abstract getScheduledLocalNotifications: callback: (ResizeArray<ScheduleLocalNotificationDetails> -> unit) -> unit
    /// <summary>
    /// Attaches a listener to remote notifications while the app is running in the
    /// foreground or the background.
    /// 
    /// The handler will get be invoked with an instance of <c>PushNotificationIOS</c>
    /// 
    /// The type MUST be 'notification'
    /// </summary>
    abstract addEventListener: ``type``: PushNotificationIOSStaticAddEventListenerType * handler: (PushNotification -> unit) -> unit
    /// Fired when the user registers for remote notifications.
    /// 
    /// The handler will be invoked with a hex string representing the deviceToken.
    /// 
    /// The type MUST be 'register'
    [<Emit "$0.addEventListener('register',$1)">] abstract addEventListener_register: handler: (string -> unit) -> unit
    /// Fired when the user fails to register for remote notifications.
    /// Typically occurs when APNS is having issues, or the device is a simulator.
    /// 
    /// The handler will be invoked with {message: string, code: number, details: any}.
    /// 
    /// The type MUST be 'registrationError'
    [<Emit "$0.addEventListener('registrationError',$1)">] abstract addEventListener_registrationError: handler: (PushNotificationIOSStaticAddEventListener_registrationError -> unit) -> unit
    /// <summary>
    /// Removes the event listener. Do this in <c>componentWillUnmount</c> to prevent
    /// memory leaks
    /// </summary>
    abstract removeEventListener: ``type``: PushNotificationEventName * handler: U3<(PushNotification -> unit), (string -> unit), (PushNotificationIOSStaticAddEventListener_registrationError -> unit)> -> unit
    /// Requests all notification permissions from iOS, prompting the user's
    /// dialog box.
    abstract requestPermissions: ?permissions: ResizeArray<PushNotificationPermissions> -> unit
    /// Requests all notification permissions from iOS, prompting the user's
    /// dialog box.
    abstract requestPermissions: ?permissions: PushNotificationPermissions -> Promise<PushNotificationPermissions>
    /// Unregister for all remote notifications received via Apple Push
    /// Notification service.
    /// You should call this method in rare circumstances only, such as when
    /// a new version of the app removes support for all types of remote
    /// notifications. Users can temporarily prevent apps from receiving
    /// remote notifications through the Notifications section of the
    /// Settings app. Apps unregistered through this method can always
    /// re-register.
    abstract abandonPermissions: unit -> unit
    /// <summary>
    /// See what push permissions are currently enabled. <c>callback</c> will be
    /// invoked with a <c>permissions</c> object:
    /// 
    ///   - <c>alert</c> :boolean
    ///   - <c>badge</c> :boolean
    ///   - <c>sound</c> :boolean
    /// </summary>
    abstract checkPermissions: callback: (PushNotificationPermissions -> unit) -> unit
    /// <summary>
    /// This method returns a promise that resolves to either the notification
    /// object if the app was launched by a push notification, or <c>null</c> otherwise.
    /// </summary>
    abstract getInitialNotification: unit -> Promise<PushNotification>
    /// <summary>
    /// iOS fetch results that best describe the result of a finished remote notification handler.
    /// For a list of possible values, see <c>PushNotificationIOS.FetchResult</c>.
    /// </summary>
    abstract FetchResult: FetchResult with get, set

type [<StringEnum>] [<RequireQualifiedAccess>] PushNotificationIOSStaticAddEventListenerType =
    | Notification
    | LocalNotification

type [<AllowNullLiteral>] SettingsStatic =
    abstract get: key: string -> obj option
    abstract set: settings: Object -> unit
    abstract watchKeys: keys: U2<string, Array<string>> * callback: (unit -> unit) -> float
    abstract clearWatch: watchId: float -> unit

type [<StringEnum>] [<RequireQualifiedAccess>] StatusBarStyle =
    | Default
    | [<CompiledName "light-content">] LightContent
    | [<CompiledName "dark-content">] DarkContent

type [<StringEnum>] [<RequireQualifiedAccess>] StatusBarAnimation =
    | None
    | Fade
    | Slide

type [<AllowNullLiteral>] StatusBarPropsIOS =
    /// Sets the color of the status bar text.
    abstract barStyle: StatusBarStyle option with get, set
    /// If the network activity indicator should be visible.
    abstract networkActivityIndicatorVisible: bool option with get, set
    /// The transition effect when showing and hiding the status bar using
    /// the hidden prop. Defaults to 'fade'.
    abstract showHideTransition: StatusBarPropsIOSShowHideTransition option with get, set

type [<AllowNullLiteral>] StatusBarPropsAndroid =
    /// The background color of the status bar.
    abstract backgroundColor: string option with get, set
    /// If the status bar is translucent. When translucent is set to true,
    /// the app will draw under the status bar. This is useful when using a
    /// semi transparent status bar color.
    abstract translucent: bool option with get, set

type [<AllowNullLiteral>] StatusBarProps =
    inherit StatusBarPropsIOS
    inherit StatusBarPropsAndroid
    /// If the transition between status bar property changes should be
    /// animated. Supported for backgroundColor, barStyle and hidden.
    abstract animated: bool option with get, set
    /// If the status bar is hidden.
    abstract hidden: bool option with get, set

type [<AllowNullLiteral>] StatusBar =
    inherit React.Component<StatusBarProps>

type [<AllowNullLiteral>] StatusBarStatic =
    [<EmitConstructor>] abstract Create: unit -> StatusBar
    /// <summary>The current height of the status bar on the device.</summary>
    abstract currentHeight: float option with get, set
    /// <summary>Show or hide the status bar</summary>
    /// <param name="hidden">The dialog's title.</param>
    /// <param name="animation">
    /// Optional animation when
    /// changing the status bar hidden property.
    /// </param>
    abstract setHidden: (bool -> (StatusBarAnimation) option -> unit) with get, set
    /// <summary>Set the status bar style</summary>
    /// <param name="style">Status bar style to set</param>
    /// <param name="animated">Animate the style change.</param>
    abstract setBarStyle: (StatusBarStyle -> (bool) option -> unit) with get, set
    /// <summary>Control the visibility of the network activity indicator</summary>
    /// <param name="visible">Show the indicator.</param>
    abstract setNetworkActivityIndicatorVisible: (bool -> unit) with get, set
    /// <summary>Set the background color for the status bar</summary>
    /// <param name="color">Background color.</param>
    /// <param name="animated">Animate the style change.</param>
    abstract setBackgroundColor: (string -> (bool) option -> unit) with get, set
    /// <summary>Control the translucency of the status bar</summary>
    /// <param name="translucent">Set as translucent.</param>
    abstract setTranslucent: (bool -> unit) with get, set

/// <summary>
/// StatusBarIOS is deprecated.
/// Use <c>StatusBar</c> for mutating the status bar.
/// </summary>
type [<AllowNullLiteral>] StatusBarIOSStatic =
    inherit NativeEventEmitter

type [<AllowNullLiteral>] TimePickerAndroidOpenOptions =
    abstract hour: float option with get, set
    abstract minute: float option with get, set
    abstract is24Hour: bool option with get, set
    abstract mode: TimePickerAndroidOpenOptionsMode option with get, set

/// <summary>
/// Opens the standard Android time picker dialog.
/// 
/// ### Example
/// 
/// <code>
/// try {
///    const {action, hour, minute} = await TimePickerAndroid.open({
///      hour: 14,
///      minute: 0,
///      is24Hour: false, // Will display '2 PM'
///    });
///    if (action !== TimePickerAndroid.dismissedAction) {
///      // Selected hour (0-23), minute (0-59)
///    }
/// } catch ({code, message}) {
///    console.warn('Cannot open time picker', message);
/// }
/// </code>
/// </summary>
type [<AllowNullLiteral>] TimePickerAndroidStatic =
    /// <summary>
    /// Opens the standard Android time picker dialog.
    /// 
    /// The available keys for the <c>options</c> object are:
    ///    * <c>hour</c> (0-23) - the hour to show, defaults to the current time
    ///    * <c>minute</c> (0-59) - the minute to show, defaults to the current time
    ///    * <c>is24Hour</c> (boolean) - If <c>true</c>, the picker uses the 24-hour format. If <c>false</c>,
    ///      the picker shows an AM/PM chooser. If undefined, the default for the current locale
    ///      is used.
    ///    * <c>mode</c> (enum('clock', 'spinner', 'default')) - set the time picker mode
    ///      * 'clock': Show a time picker in clock mode.
    ///      * 'spinner': Show a time picker in spinner mode.
    ///      * 'default': Show a default time picker based on Android versions.
    /// 
    /// Returns a Promise which will be invoked an object containing <c>action</c>, <c>hour</c> (0-23),
    /// <c>minute</c> (0-59) if the user picked a time. If the user dismissed the dialog, the Promise will
    /// still be resolved with action being <c>TimePickerAndroid.dismissedAction</c> and all the other keys
    /// being undefined. **Always** check whether the <c>action</c> before reading the values.
    /// </summary>
    abstract ``open``: options: TimePickerAndroidOpenOptions -> Promise<TimePickerAndroidStaticOpenPromise>
    /// A time has been selected.
    abstract timeSetAction: string with get, set
    /// The dialog has been dismissed.
    abstract dismissedAction: string with get, set

/// <summary>
/// This exposes the native ToastAndroid module as a JS module. This has a function 'show'
/// which takes the following parameters:
/// 
/// 1. String message: A string with the text to toast
/// 2. int duration: The duration of the toast. May be ToastAndroid.SHORT or ToastAndroid.LONG
/// 
/// There is also a function <c>showWithGravity</c> to specify the layout gravity. May be
/// ToastAndroid.TOP, ToastAndroid.BOTTOM, ToastAndroid.CENTER
/// </summary>
type [<AllowNullLiteral>] ToastAndroidStatic =
    /// String message: A string with the text to toast
    /// int duration: The duration of the toast.
    /// May be ToastAndroid.SHORT or ToastAndroid.LONG
    abstract show: message: string * duration: float -> unit
    /// <summary><c>gravity</c> may be ToastAndroid.TOP, ToastAndroid.BOTTOM, ToastAndroid.CENTER</summary>
    abstract showWithGravity: message: string * duration: float * gravity: float -> unit
    abstract SHORT: float with get, set
    abstract LONG: float with get, set
    abstract TOP: float with get, set
    abstract BOTTOM: float with get, set
    abstract CENTER: float with get, set

type [<AllowNullLiteral>] UIManagerStatic =
    /// <summary>
    /// Capture an image of the screen, window or an individual view. The image
    /// will be stored in a temporary file that will only exist for as long as the
    /// app is running.
    /// 
    /// The <c>view</c> argument can be the literal string <c>window</c> if you want to
    /// capture the entire window, or it can be a reference to a specific
    /// React Native component.
    /// 
    /// The <c>options</c> argument may include:
    /// - width/height (number) - the width and height of the image to capture.
    /// - format (string) - either 'png' or 'jpeg'. Defaults to 'png'.
    /// - quality (number) - the quality when using jpeg. 0.0 - 1.0 (default).
    /// 
    /// Returns a Promise&lt;string&gt; (tempFilePath)
    /// </summary>
    abstract takeSnapshot: ((U3<React.ReactElement<obj option>, float, string>) option -> (UIManagerStaticTakeSnapshot) option -> Promise<string>) with get, set
    /// <summary>
    /// Determines the location on screen, width, and height of the given view and
    /// returns the values via an async callback. If successful, the callback will
    /// be called with the following arguments:
    /// 
    ///   - x
    ///   - y
    ///   - width
    ///   - height
    ///   - pageX
    ///   - pageY
    /// 
    /// Note that these measurements are not available until after the rendering
    /// has been completed in native. If you need the measurements as soon as
    /// possible, consider using the [<c>onLayout</c>
    /// prop](docs/view.html#onlayout) instead.
    /// </summary>
    abstract measure: node: float * callback: MeasureOnSuccessCallback -> unit
    /// Determines the location of the given view in the window and returns the
    /// values via an async callback. If the React root view is embedded in
    /// another native view, this will give you the absolute coordinates. If
    /// successful, the callback will be called with the following
    /// arguments:
    /// 
    ///   - x
    ///   - y
    ///   - width
    ///   - height
    /// 
    /// Note that these measurements are not available until after the rendering
    /// has been completed in native.
    abstract measureInWindow: node: float * callback: MeasureInWindowOnSuccessCallback -> unit
    /// <summary>
    /// Like [<c>measure()</c>](#measure), but measures the view relative an ancestor,
    /// specified as <c>relativeToNativeNode</c>. This means that the returned x, y
    /// are relative to the origin x, y of the ancestor view.
    /// 
    /// As always, to obtain a native node handle for a component, you can use
    /// <c>React.findNodeHandle(component)</c>.
    /// </summary>
    abstract measureLayout: node: float * relativeToNativeNode: float * onFail: (unit -> unit) * onSuccess: MeasureLayoutOnSuccessCallback -> unit
    /// <summary>
    /// Automatically animates views to their new positions when the
    /// next layout happens.
    /// 
    /// A common way to use this API is to call it before calling <c>setState</c>.
    /// 
    /// Note that in order to get this to work on **Android** you need to set the following flags via <c>UIManager</c>:
    /// 
    ///      UIManager.setLayoutAnimationEnabledExperimental &amp;&amp; UIManager.setLayoutAnimationEnabledExperimental(true);
    /// </summary>
    abstract setLayoutAnimationEnabledExperimental: value: bool -> unit

type [<AllowNullLiteral>] SwitchPropsIOS =
    inherit ViewProps
    /// Background color when the switch is turned on.
    abstract onTintColor: string option with get, set
    /// Color of the foreground switch grip.
    abstract thumbTintColor: string option with get, set
    /// Background color when the switch is turned off.
    abstract tintColor: string option with get, set

type [<AllowNullLiteral>] SwitchProps =
    inherit SwitchPropsIOS
    /// If true the user won't be able to toggle the switch.
    /// Default value is false.
    abstract disabled: bool option with get, set
    /// Invoked with the new value when the value changes.
    abstract onValueChange: (bool -> unit) option with get, set
    /// Used to locate this view in end-to-end tests.
    abstract testID: string option with get, set
    /// The value of the switch. If true the switch will be turned on.
    /// Default value is false.
    abstract value: bool option with get, set
    abstract style: StyleProp<ViewStyle> option with get, set

/// <summary>
/// Renders a boolean input.
/// 
/// This is a controlled component that requires an <c>onValueChange</c> callback that
/// updates the <c>value</c> prop in order for the component to reflect user actions.
/// If the <c>value</c> prop is not updated, the component will continue to render
/// the supplied <c>value</c> prop instead of the expected result of any user actions.
/// </summary>
type [<AllowNullLiteral>] SwitchComponent =
    inherit React.Component<SwitchProps>

/// <summary>
/// Renders a boolean input.
/// 
/// This is a controlled component that requires an <c>onValueChange</c> callback that
/// updates the <c>value</c> prop in order for the component to reflect user actions.
/// If the <c>value</c> prop is not updated, the component will continue to render
/// the supplied <c>value</c> prop instead of the expected result of any user actions.
/// </summary>
type [<AllowNullLiteral>] SwitchComponentStatic =
    [<EmitConstructor>] abstract Create: unit -> SwitchComponent

type [<AllowNullLiteral>] Switch =
    inherit SwitchBase

type [<AllowNullLiteral>] SwitchStatic =
    [<EmitConstructor>] abstract Create: unit -> Switch

/// <summary>
/// NOTE: <c>VibrationIOS</c> is being deprecated. Use <c>Vibration</c> instead.
/// 
/// The Vibration API is exposed at VibrationIOS.vibrate().
/// On iOS, calling this function will trigger a one second vibration.
/// The vibration is asynchronous so this method will return immediately.
/// 
/// There will be no effect on devices that do not support Vibration, eg. the iOS simulator.
/// 
/// Vibration patterns are currently unsupported.
/// </summary>
/// <seealso href="https://facebook.github.io/react-native/docs/vibrationios.html#content" />
type [<AllowNullLiteral>] VibrationIOSStatic =
    [<Obsolete("")>]
    abstract vibrate: unit -> unit

/// <summary>
/// The Vibration API is exposed at <c>Vibration.vibrate()</c>.
/// The vibration is asynchronous so this method will return immediately.
/// 
/// There will be no effect on devices that do not support Vibration, eg. the simulator.
/// 
/// **Note for android**
/// add <c>&lt;uses-permission android:name="android.permission.VIBRATE"/&gt;</c> to <c>AndroidManifest.xml</c>
/// 
/// **Android Usage:**
/// 
/// [0, 500, 200, 500]
/// V(0.5s) --wait(0.2s)--&gt; V(0.5s)
/// 
/// [300, 500, 200, 500]
/// --wait(0.3s)--&gt; V(0.5s) --wait(0.2s)--&gt; V(0.5s)
/// 
/// **iOS Usage:**
/// if first argument is 0, it will not be included in pattern array.
/// 
/// [0, 1000, 2000, 3000]
/// V(fixed) --wait(1s)--&gt; V(fixed) --wait(2s)--&gt; V(fixed) --wait(3s)--&gt; V(fixed)
/// </summary>
type [<AllowNullLiteral>] VibrationStatic =
    abstract vibrate: pattern: U2<float, ResizeArray<float>> * repeat: bool -> unit
    /// Stop vibration
    abstract cancel: unit -> unit

/// <summary>
/// This class implements common easing functions. The math is pretty obscure,
/// but this cool website has nice visual illustrations of what they represent:
/// <see href="http://xaedes.de/dev/transitions/" />
/// </summary>
type [<AllowNullLiteral>] EasingFunction =
    /// <summary>
    /// This class implements common easing functions. The math is pretty obscure,
    /// but this cool website has nice visual illustrations of what they represent:
    /// <see href="http://xaedes.de/dev/transitions/" />
    /// </summary>
    [<Emit "$0($1...)">] abstract Invoke: value: float -> float

type [<AllowNullLiteral>] EasingStatic =
    abstract step0: EasingFunction with get, set
    abstract step1: EasingFunction with get, set
    abstract linear: EasingFunction with get, set
    abstract ease: EasingFunction with get, set
    abstract quad: EasingFunction with get, set
    abstract cubic: EasingFunction with get, set
    abstract poly: n: float -> EasingFunction
    abstract sin: EasingFunction with get, set
    abstract circle: EasingFunction with get, set
    abstract exp: EasingFunction with get, set
    abstract elastic: bounciness: float -> EasingFunction
    abstract back: s: float -> EasingFunction
    abstract bounce: EasingFunction with get, set
    abstract bezier: x1: float * y1: float * x2: float * y2: float -> EasingFunction
    abstract ``in``: easing: EasingFunction -> EasingFunction
    abstract out: easing: EasingFunction -> EasingFunction
    abstract inOut: easing: EasingFunction -> EasingFunction

module Animated =

    type [<AllowNullLiteral>] IExports =
        abstract Animated: AnimatedStatic
        abstract AnimatedWithChildren: AnimatedWithChildrenStatic
        abstract AnimatedInterpolation: AnimatedInterpolationStatic
        /// <summary>
        /// Standard value for driving animations.  One <c>Animated.Value</c> can drive
        /// multiple properties in a synchronized fashion, but can only be driven by one
        /// mechanism at a time.  Using a new mechanism (e.g. starting a new animation,
        /// or calling <c>setValue</c>) will stop any previous ones.
        /// </summary>
        abstract Value: ValueStatic
        /// <summary>
        /// 2D Value for driving 2D animations, such as pan gestures.  Almost identical
        /// API to normal <c>Animated.Value</c>, but multiplexed.  Contains two regular
        /// <c>Animated.Value</c>s under the hood.
        /// </summary>
        abstract ValueXY: ValueXYStatic
        /// Animates a value from an initial velocity to zero based on a decay
        /// coefficient.
        abstract decay: value: U2<AnimatedValue, AnimatedValueXY> * config: DecayAnimationConfig -> CompositeAnimation
        /// <summary>
        /// Animates a value along a timed easing curve.  The <c>Easing</c> module has tons
        /// of pre-defined curves, or you can use your own function.
        /// </summary>
        abstract timing: U2<AnimatedValue, AnimatedValueXY> -> TimingAnimationConfig -> CompositeAnimation
        /// Creates a new Animated value composed from two Animated values added
        /// together.
        abstract add: a: Animated * b: Animated -> AnimatedAddition
        abstract AnimatedAddition: AnimatedAdditionStatic
        /// Creates a new Animated value composed by dividing the first Animated
        /// value by the second Animated value.
        abstract divide: a: Animated * b: Animated -> AnimatedDivision
        abstract AnimatedDivision: AnimatedDivisionStatic
        /// Creates a new Animated value composed from two Animated values multiplied
        /// together.
        abstract multiply: a: Animated * b: Animated -> AnimatedMultiplication
        abstract AnimatedMultiplication: AnimatedMultiplicationStatic
        /// Creates a new Animated value that is the (non-negative) modulo of the
        /// provided Animated value
        abstract modulo: a: Animated * modulus: float -> AnimatedModulo
        abstract AnimatedModulo: AnimatedModuloStatic
        /// <summary>
        /// Create a new Animated value that is limited between 2 values. It uses the
        /// difference between the last value so even if the value is far from the bounds
        /// it will start changing when the value starts getting closer again.
        /// (<c>value = clamp(value + diff, min, max)</c>).
        /// 
        /// This is useful with scroll events, for example, to show the navbar when
        /// scrolling up and to hide it when scrolling down.
        /// </summary>
        abstract diffClamp: a: Animated * min: float * max: float -> AnimatedDiffClamp
        abstract AnimatedDiffClamp: AnimatedDiffClampStatic
        /// Starts an animation after the given delay.
        abstract delay: time: float -> CompositeAnimation
        /// Starts an array of animations in order, waiting for each to complete
        /// before starting the next.  If the current running animation is stopped, no
        /// following animations will be started.
        abstract sequence: animations: Array<CompositeAnimation> -> CompositeAnimation
        /// Array of animations may run in parallel (overlap), but are started in
        /// sequence with successive delays.  Nice for doing trailing effects.
        abstract stagger: time: float * animations: Array<CompositeAnimation> -> CompositeAnimation
        /// Loops a given animation continuously, so that each time it reaches the end,
        /// it resets and begins again from the start. Can specify number of times to
        /// loop using the key 'iterations' in the config. Will loop without blocking
        /// the UI thread if the child animation is set to 'useNativeDriver'.
        abstract loop: animation: CompositeAnimation * ?config: LoopAnimationConfig -> CompositeAnimation
        /// <summary>
        /// Spring animation based on Rebound and Origami.  Tracks velocity state to
        /// create fluid motions as the <c>toValue</c> updates, and can be chained together.
        /// </summary>
        abstract spring: value: U2<AnimatedValue, AnimatedValueXY> * config: SpringAnimationConfig -> CompositeAnimation
        /// <summary>
        /// Starts an array of animations all at the same time.  By default, if one
        /// of the animations is stopped, they will all be stopped.  You can override
        /// this with the <c>stopTogether</c> flag.
        /// </summary>
        abstract ``parallel``: animations: Array<CompositeAnimation> * ?config: ParallelConfig -> CompositeAnimation
        /// <summary>
        /// Takes an array of mappings and extracts values from each arg accordingly,
        /// then calls <c>setValue</c> on the mapped outputs.  e.g.
        /// 
        /// <code language="javascript">
        /// onScroll={Animated.event(
        ///    [{nativeEvent: {contentOffset: {x: this._scrollX}}}]
        ///    {listener},          // Optional async listener
        /// )
        /// ...
        /// onPanResponderMove: Animated.event([
        ///    null,                // raw event arg ignored
        ///    {dx: this._panX},    // gestureState arg
        /// ]),
        /// </code>
        /// </summary>
        abstract ``event``: argMapping: Array<Mapping option> * ?config: EventConfig<'T> -> (ResizeArray<obj option> -> unit)
        /// <summary>Make any React component Animatable.  Used to create <c>Animated.View</c>, etc.</summary>
        abstract createAnimatedComponent: ``component``: obj option -> obj option
        /// Animated variants of the basic native views. Accepts Animated.Value for
        /// props and style.
        abstract View: obj option
        abstract Image: obj option
        abstract Text: obj option
        abstract ScrollView: obj option

    type AnimatedValue =
        Value

    type AnimatedValueXY =
        ValueXY

    type Base =
        Animated

    type [<AllowNullLiteral>] Animated =
        interface end

    type [<AllowNullLiteral>] AnimatedStatic =
        [<EmitConstructor>] abstract Create: unit -> Animated

    type [<AllowNullLiteral>] AnimatedWithChildren =
        inherit Animated

    type [<AllowNullLiteral>] AnimatedWithChildrenStatic =
        [<EmitConstructor>] abstract Create: unit -> AnimatedWithChildren

    type [<AllowNullLiteral>] AnimatedInterpolation =
        inherit AnimatedWithChildren
        abstract interpolate: config: InterpolationConfigType -> AnimatedInterpolation

    type [<AllowNullLiteral>] AnimatedInterpolationStatic =
        [<EmitConstructor>] abstract Create: unit -> AnimatedInterpolation

    type [<StringEnum>] [<RequireQualifiedAccess>] ExtrapolateType =
        | Extend
        | Identity
        | Clamp

    type [<AllowNullLiteral>] InterpolationConfigType =
        abstract inputRange: ResizeArray<float> with get, set
        abstract outputRange: U2<ResizeArray<float>, ResizeArray<string>> with get, set
        abstract easing: (float -> float) option with get, set
        abstract extrapolate: ExtrapolateType option with get, set
        abstract extrapolateLeft: ExtrapolateType option with get, set
        abstract extrapolateRight: ExtrapolateType option with get, set

    type [<AllowNullLiteral>] ValueListenerCallback =
        [<Emit "$0($1...)">] abstract Invoke: state: ValueListenerCallbackInvokeState -> unit

    type [<AllowNullLiteral>] ValueListenerCallbackInvokeState =
        abstract value: float with get, set

    /// <summary>
    /// Standard value for driving animations.  One <c>Animated.Value</c> can drive
    /// multiple properties in a synchronized fashion, but can only be driven by one
    /// mechanism at a time.  Using a new mechanism (e.g. starting a new animation,
    /// or calling <c>setValue</c>) will stop any previous ones.
    /// </summary>
    type [<AllowNullLiteral>] Value =
        inherit AnimatedWithChildren
        /// Directly set the value.  This will stop any animations running on the value
        /// and update all the bound properties.
        abstract setValue: value: float -> unit
        /// <summary>
        /// Sets an offset that is applied on top of whatever value is set, whether via
        /// <c>setValue</c>, an animation, or <c>Animated.event</c>.  Useful for compensating
        /// things like the start of a pan gesture.
        /// </summary>
        abstract setOffset: offset: float -> unit
        /// Merges the offset value into the base value and resets the offset to zero.
        /// The final output of the value is unchanged.
        abstract flattenOffset: unit -> unit
        /// Sets the offset value to the base value, and resets the base value to zero.
        /// The final output of the value is unchanged.
        abstract extractOffset: unit -> unit
        /// Adds an asynchronous listener to the value so you can observe updates from
        /// animations.  This is useful because there is no way to
        /// synchronously read the value because it might be driven natively.
        abstract addListener: callback: ValueListenerCallback -> string
        abstract removeListener: id: string -> unit
        abstract removeAllListeners: unit -> unit
        /// <summary>
        /// Stops any running animation or tracking.  <c>callback</c> is invoked with the
        /// final value after stopping the animation, which is useful for updating
        /// state to match the animation position with layout.
        /// </summary>
        abstract stopAnimation: ?callback: (float -> unit) -> unit
        /// Interpolates the value before updating the property, e.g. mapping 0-1 to
        /// 0-10.
        abstract interpolate: config: InterpolationConfigType -> AnimatedInterpolation

    /// <summary>
    /// Standard value for driving animations.  One <c>Animated.Value</c> can drive
    /// multiple properties in a synchronized fashion, but can only be driven by one
    /// mechanism at a time.  Using a new mechanism (e.g. starting a new animation,
    /// or calling <c>setValue</c>) will stop any previous ones.
    /// </summary>
    type [<AllowNullLiteral>] ValueStatic =
        [<EmitConstructor>] abstract Create: value: float -> Value

    type [<AllowNullLiteral>] ValueXYListenerCallback =
        [<Emit "$0($1...)">] abstract Invoke: value: ValueXYListenerCallbackInvokeValue -> unit

    type [<AllowNullLiteral>] ValueXYListenerCallbackInvokeValue =
        abstract x: float with get, set
        abstract y: float with get, set

    /// <summary>
    /// 2D Value for driving 2D animations, such as pan gestures.  Almost identical
    /// API to normal <c>Animated.Value</c>, but multiplexed.  Contains two regular
    /// <c>Animated.Value</c>s under the hood.
    /// </summary>
    type [<AllowNullLiteral>] ValueXY =
        inherit AnimatedWithChildren
        abstract x: AnimatedValue with get, set
        abstract y: AnimatedValue with get, set
        abstract setValue: value: ValueXYSetValueValue -> unit
        abstract setOffset: offset: ValueXYSetOffsetOffset -> unit
        abstract flattenOffset: unit -> unit
        abstract extractOffset: unit -> unit
        abstract stopAnimation: ?callback: (ValueXYStopAnimation -> unit) -> unit
        abstract addListener: callback: ValueXYListenerCallback -> string
        abstract removeListener: id: string -> unit
        /// <summary>
        /// Converts <c>{x, y}</c> into <c>{left, top}</c> for use in style, e.g.
        /// 
        /// <code language="javascript">
        ///   style={this.state.anim.getLayout()}
        /// </code>
        /// </summary>
        abstract getLayout: unit -> ValueXYGetLayoutReturn
        /// <summary>
        /// Converts <c>{x, y}</c> into a useable translation transform, e.g.
        /// 
        /// <code language="javascript">
        ///   style={{
        ///     transform: this.state.anim.getTranslateTransform()
        ///   }}
        /// </code>
        /// </summary>
        abstract getTranslateTransform: unit -> ResizeArray<ValueXYGetTranslateTransform>

    type [<AllowNullLiteral>] ValueXYSetValueValue =
        abstract x: float with get, set
        abstract y: float with get, set

    type [<AllowNullLiteral>] ValueXYSetOffsetOffset =
        abstract x: float with get, set
        abstract y: float with get, set

    type [<AllowNullLiteral>] ValueXYGetLayoutReturn =
        [<EmitIndexer>] abstract Item: key: string -> AnimatedValue with get, set

    /// <summary>
    /// 2D Value for driving 2D animations, such as pan gestures.  Almost identical
    /// API to normal <c>Animated.Value</c>, but multiplexed.  Contains two regular
    /// <c>Animated.Value</c>s under the hood.
    /// </summary>
    type [<AllowNullLiteral>] ValueXYStatic =
        [<EmitConstructor>] abstract Create: ?valueIn: ValueXYStaticValueIn -> ValueXY

    type [<AllowNullLiteral>] ValueXYStaticValueIn =
        abstract x: U2<float, AnimatedValue> with get, set
        abstract y: U2<float, AnimatedValue> with get, set

    type [<AllowNullLiteral>] EndResult =
        abstract finished: bool with get, set

    type [<AllowNullLiteral>] EndCallback =
        [<Emit "$0($1...)">] abstract Invoke: result: EndResult -> unit

    type [<AllowNullLiteral>] CompositeAnimation =
        abstract start: ((EndCallback) option -> unit) with get, set
        abstract stop: (unit -> unit) with get, set

    type [<AllowNullLiteral>] AnimationConfig =
        abstract isInteraction: bool option with get, set
        abstract useNativeDriver: bool option with get, set

    type [<AllowNullLiteral>] DecayAnimationConfig =
        inherit AnimationConfig
        abstract velocity: U2<float, ValueXYStopAnimation> with get, set
        abstract deceleration: float option with get, set

    type [<AllowNullLiteral>] TimingAnimationConfig =
        inherit AnimationConfig
        abstract toValue: U4<float, AnimatedValue, ValueXYStopAnimation, AnimatedValueXY> with get, set
        abstract easing: (float -> float) option with get, set
        abstract duration: float option with get, set
        abstract delay: float option with get, set

    type [<AllowNullLiteral>] SpringAnimationConfig =
        inherit AnimationConfig
        abstract toValue: U4<float, AnimatedValue, ValueXYStopAnimation, AnimatedValueXY> with get, set
        abstract overshootClamping: bool option with get, set
        abstract restDisplacementThreshold: float option with get, set
        abstract restSpeedThreshold: float option with get, set
        abstract velocity: U2<float, ValueXYStopAnimation> option with get, set
        abstract bounciness: float option with get, set
        abstract speed: float option with get, set
        abstract tension: float option with get, set
        abstract friction: float option with get, set
        abstract stiffness: float option with get, set
        abstract mass: float option with get, set
        abstract damping: float option with get, set

    type [<AllowNullLiteral>] LoopAnimationConfig =
        abstract iterations: float option with get, set

    type [<AllowNullLiteral>] AnimatedAddition =
        inherit AnimatedInterpolation

    type [<AllowNullLiteral>] AnimatedAdditionStatic =
        [<EmitConstructor>] abstract Create: unit -> AnimatedAddition

    type [<AllowNullLiteral>] AnimatedDivision =
        inherit AnimatedInterpolation

    type [<AllowNullLiteral>] AnimatedDivisionStatic =
        [<EmitConstructor>] abstract Create: unit -> AnimatedDivision

    type [<AllowNullLiteral>] AnimatedMultiplication =
        inherit AnimatedInterpolation

    type [<AllowNullLiteral>] AnimatedMultiplicationStatic =
        [<EmitConstructor>] abstract Create: unit -> AnimatedMultiplication

    type [<AllowNullLiteral>] AnimatedModulo =
        inherit AnimatedInterpolation

    type [<AllowNullLiteral>] AnimatedModuloStatic =
        [<EmitConstructor>] abstract Create: unit -> AnimatedModulo

    type [<AllowNullLiteral>] AnimatedDiffClamp =
        inherit AnimatedInterpolation

    type [<AllowNullLiteral>] AnimatedDiffClampStatic =
        [<EmitConstructor>] abstract Create: unit -> AnimatedDiffClamp

    type [<AllowNullLiteral>] ParallelConfig =
        abstract stopTogether: bool option with get, set

    type Mapping =
        U2<Mapping, AnimatedValue>

    type [<AllowNullLiteral>] EventConfig<'T> =
        abstract listener: (NativeSyntheticEvent<'T> -> unit) option with get, set
        abstract useNativeDriver: bool option with get, set

    type [<AllowNullLiteral>] ValueXYStopAnimation =
        abstract x: float with get, set
        abstract y: float with get, set

    type [<AllowNullLiteral>] ValueXYGetTranslateTransform =
        [<EmitIndexer>] abstract Item: key: string -> AnimatedValue with get, set

type [<AllowNullLiteral>] I18nManagerStatic =
    abstract isRTL: bool with get, set
    abstract allowRTL: (bool -> I18nManagerStaticAllowRTL) with get, set
    abstract forceRTL: (bool -> I18nManagerStaticAllowRTL) with get, set

type [<AllowNullLiteral>] GeolocationStatic =
    /// Invokes the success callback once with the latest location info.  Supported
    /// options: timeout (ms), maximumAge (ms), enableHighAccuracy (bool)
    /// On Android, this can return almost immediately if the location is cached or
    /// request an update, which might take a while.
    abstract getCurrentPosition: geo_success: (GeolocationReturnType -> unit) * ?geo_error: (GeolocationError -> unit) * ?geo_options: GeoOptions -> unit
    /// Invokes the success callback whenever the location changes.  Supported
    /// options: timeout (ms), maximumAge (ms), enableHighAccuracy (bool), distanceFilter(m)
    abstract watchPosition: success: (GeolocationReturnType -> unit) * ?error: (GeolocationError -> unit) * ?options: GeoOptions -> float
    abstract clearWatch: watchID: float -> unit
    abstract stopObserving: unit -> unit
    abstract requestAuthorization: unit -> unit
    abstract setRNConfiguration: config: GeoConfiguration -> unit

type [<AllowNullLiteral>] OpenCameraDialogOptions =
    /// Defaults to false
    abstract videoMode: bool option with get, set

type [<AllowNullLiteral>] OpenSelectDialogOptions =
    /// Defaults to true
    abstract showImages: bool option with get, set
    /// Defaults to false
    abstract showVideos: bool option with get, set

/// [imageURL|tempImageTag, height, width]
type ImagePickerResult =
    string * float * float

type [<AllowNullLiteral>] ImagePickerIOSStatic =
    abstract canRecordVideos: callback: (bool -> unit) -> unit
    abstract canUseCamera: callback: (bool -> unit) -> unit
    abstract openCameraDialog: config: OpenCameraDialogOptions * successCallback: (ImagePickerResult -> unit) * cancelCallback: (ResizeArray<obj option> -> unit) -> unit
    abstract openSelectDialog: config: OpenSelectDialogOptions * successCallback: (ImagePickerResult -> unit) * cancelCallback: (ResizeArray<obj option> -> unit) -> unit

type [<AllowNullLiteral>] ImageStoreStatic =
    /// <summary>Check if the ImageStore contains image data for the specified URI.</summary>
    abstract hasImageForTag: uri: string * callback: (bool -> unit) -> unit
    /// <summary>
    /// Delete an image from the ImageStore. Images are stored in memory and
    /// must be manually removed when you are finished with them, otherwise they
    /// will continue to use up RAM until the app is terminated. It is safe to
    /// call <c>removeImageForTag()</c> without first calling <c>hasImageForTag()</c>, it
    /// will simply fail silently.
    /// </summary>
    abstract removeImageForTag: uri: string -> unit
    /// <summary>
    /// Stores a base64-encoded image in the ImageStore, and returns a URI that
    /// can be used to access or display the image later. Images are stored in
    /// memory only, and must be manually deleted when you are finished with
    /// them by calling <c>removeImageForTag()</c>.
    /// 
    /// Note that it is very inefficient to transfer large quantities of binary
    /// data between JS and native code, so you should avoid calling this more
    /// than necessary.
    /// </summary>
    abstract addImageFromBase64: base64ImageData: string * success: (string -> unit) * failure: (obj option -> unit) -> unit
    /// <summary>
    /// Retrieves the base64-encoded data for an image in the ImageStore. If the
    /// specified URI does not match an image in the store, the failure callback
    /// will be called.
    /// 
    /// Note that it is very inefficient to transfer large quantities of binary
    /// data between JS and native code, so you should avoid calling this more
    /// than necessary. To display an image in the ImageStore, you can just pass
    /// the URI to an <c>&lt;Image/&gt;</c> component; there is no need to retrieve the
    /// base64 data.
    /// </summary>
    abstract getBase64ForTag: uri: string * success: (string -> unit) * failure: (obj option -> unit) -> unit

type [<AllowNullLiteral>] NativeEventSubscription =
    /// Call this method to un-subscribe from a native-event
    abstract remove: unit -> unit

/// <summary>
/// Receive events from native-code
/// Deprecated - subclass NativeEventEmitter to create granular event modules instead of
/// adding all event listeners directly to RCTNativeAppEventEmitter.
/// </summary>
/// <seealso href="https://github.com/facebook/react-native/blob/0.34-stable\Libraries\EventEmitter\RCTNativeAppEventEmitter.js" />
/// <seealso href="https://facebook.github.io/react-native/docs/native-modules-ios.html#sending-events-to-javascript" />
type RCTNativeAppEventEmitter =
    DeviceEventEmitterStatic

type [<AllowNullLiteral>] ImageCropData =
    /// The top-left corner of the cropped image, specified in the original
    /// image's coordinate space.
    abstract offset: TextInputScrollEventDataContentOffset with get, set
    /// The size (dimensions) of the cropped image, specified in the original
    /// image's coordinate space.
    abstract size: ShadowPropTypesIOSStaticShadowOffset with get, set
    /// (Optional) size to scale the cropped image to.
    abstract displaySize: ShadowPropTypesIOSStaticShadowOffset option with get, set
    /// <summary>
    /// (Optional) the resizing mode to use when scaling the image. If the
    /// <c>displaySize</c> param is not specified, this has no effect.
    /// </summary>
    abstract resizeMode: ImageCropDataResizeMode option with get, set

type [<AllowNullLiteral>] ImageEditorStatic =
    /// Crop the image specified by the URI param. If URI points to a remote
    /// image, it will be downloaded automatically. If the image cannot be
    /// loaded/downloaded, the failure callback will be called.
    /// 
    /// If the cropping process is successful, the resultant cropped image
    /// will be stored in the ImageStore, and the URI returned in the success
    /// callback will point to the image in the store. Remember to delete the
    /// cropped image from the ImageStore when you are done with it.
    abstract cropImage: uri: string * cropData: ImageCropData * success: (string -> unit) * failure: (Object -> unit) -> unit

type [<AllowNullLiteral>] ARTNodeMixin =
    abstract opacity: float option with get, set
    abstract originX: float option with get, set
    abstract originY: float option with get, set
    abstract scaleX: float option with get, set
    abstract scaleY: float option with get, set
    abstract scale: float option with get, set
    abstract title: string option with get, set
    abstract x: float option with get, set
    abstract y: float option with get, set
    abstract visible: bool option with get, set

type [<AllowNullLiteral>] ARTGroupProps =
    inherit ARTNodeMixin
    abstract width: float option with get, set
    abstract height: float option with get, set

type [<AllowNullLiteral>] ARTClippingRectangleProps =
    inherit ARTNodeMixin
    abstract width: float option with get, set
    abstract height: float option with get, set

type [<AllowNullLiteral>] ARTRenderableMixin =
    inherit ARTNodeMixin
    abstract fill: string option with get, set
    abstract stroke: string option with get, set
    abstract strokeCap: ARTRenderableMixinStrokeCap option with get, set
    abstract strokeDash: ResizeArray<float> option with get, set
    abstract strokeJoin: ARTRenderableMixinStrokeJoin option with get, set
    abstract strokeWidth: float option with get, set

type [<AllowNullLiteral>] ARTShapeProps =
    inherit ARTRenderableMixin
    abstract d: string with get, set
    abstract width: float option with get, set
    abstract height: float option with get, set

type [<AllowNullLiteral>] ARTTextProps =
    inherit ARTRenderableMixin
    abstract font: string option with get, set
    abstract alignment: string option with get, set

type [<AllowNullLiteral>] ARTSurfaceProps =
    abstract style: StyleProp<ViewStyle> option with get, set
    abstract width: float with get, set
    abstract height: float with get, set

type [<AllowNullLiteral>] ClippingRectangle =
    inherit React.Component<ARTClippingRectangleProps>

type [<AllowNullLiteral>] ClippingRectangleStatic =
    [<EmitConstructor>] abstract Create: unit -> ClippingRectangle

type [<AllowNullLiteral>] Group =
    inherit React.Component<ARTGroupProps>

type [<AllowNullLiteral>] GroupStatic =
    [<EmitConstructor>] abstract Create: unit -> Group

type [<AllowNullLiteral>] Shape =
    inherit React.Component<ARTShapeProps>

type [<AllowNullLiteral>] ShapeStatic =
    [<EmitConstructor>] abstract Create: unit -> Shape

type [<AllowNullLiteral>] Surface =
    inherit React.Component<ARTSurfaceProps>

type [<AllowNullLiteral>] SurfaceStatic =
    [<EmitConstructor>] abstract Create: unit -> Surface

type [<AllowNullLiteral>] ARTText =
    inherit React.Component<ARTTextProps>

type [<AllowNullLiteral>] ARTTextStatic =
    [<EmitConstructor>] abstract Create: unit -> ARTText

type [<AllowNullLiteral>] ARTStatic =
    abstract ClippingRectangle: obj with get, set
    abstract Group: obj with get, set
    abstract Shape: obj with get, set
    abstract Surface: obj with get, set
    abstract Text: obj with get, set

type [<AllowNullLiteral>] KeyboardStatic =
    inherit NativeEventEmitter
    abstract dismiss: (unit -> unit) with get, set

type ART =
    ARTStatic

type ImagePickerIOS =
    ImagePickerIOSStatic

type LayoutAnimation =
    LayoutAnimationStatic

type SectionList<'ItemT> =
    SectionListStatic<'ItemT>

type Systrace =
    SystraceStatic

type ActionSheetIOS =
    ActionSheetIOSStatic

type Share =
    ShareStatic

type AdSupportIOS =
    AdSupportIOSStatic

type AccessibilityInfo =
    AccessibilityInfoStatic

type Alert =
    AlertStatic

type AlertAndroid =
    AlertAndroidStatic

type AlertIOS =
    AlertIOSStatic

type AppState =
    AppStateStatic

type AppStateIOS =
    AppStateStatic

type AsyncStorage =
    AsyncStorageStatic

type BackAndroid =
    BackAndroidStatic

type BackHandler =
    BackHandlerStatic

type CameraRoll =
    CameraRollStatic

type Clipboard =
    ClipboardStatic

type DatePickerAndroid =
    DatePickerAndroidStatic

type Geolocation =
    GeolocationStatic

/// <summary><see href="http://facebook.github.io/react-native/blog/2016/08/19/right-to-left-support-for-react-native-apps.html" /></summary>
type I18nManager =
    I18nManagerStatic

type ImageEditor =
    ImageEditorStatic

type ImageStore =
    ImageStoreStatic

type IntentAndroid =
    IntentAndroidStatic

type Linking =
    LinkingStatic

type LinkingIOS =
    LinkingIOSStatic

type NativeMethodsMixin =
    NativeMethodsMixinStatic

type NativeComponent =
    NativeMethodsMixinStatic

type NetInfo =
    NetInfoStatic

type PanResponder =
    PanResponderStatic

type PermissionsAndroid =
    PermissionsAndroidStatic

type PushNotificationIOS =
    PushNotificationIOSStatic

type Settings =
    SettingsStatic

type StatusBarIOS =
    StatusBarIOSStatic

type TimePickerAndroid =
    TimePickerAndroidStatic

type ToastAndroid =
    ToastAndroidStatic

type UIManager =
    UIManagerStatic

type VibrationIOS =
    VibrationIOSStatic

type Vibration =
    VibrationStatic

type Easing =
    EasingStatic

/// Abstract base class for implementing event-emitting modules. This implements
/// a subset of the standard EventEmitter node module API.
type [<AllowNullLiteral>] NativeEventEmitter =
    inherit EventEmitter

/// Interface for NativeModules which allows to augment NativeModules with type informations.
/// See react-native-sensor-manager for example.
type [<AllowNullLiteral>] NativeModulesStatic =
    [<EmitIndexer>] abstract Item: name: string -> obj option with get, set

type [<AllowNullLiteral>] ComponentInterface<'P> =
    abstract name: string option with get, set
    abstract displayName: string option with get, set
    abstract propTypes: PropTypes.ValidationMap<'P> with get, set

type [<AllowNullLiteral>] ErrorHandlerCallback =
    [<Emit "$0($1...)">] abstract Invoke: error: obj option * ?isFatal: bool -> unit

type [<AllowNullLiteral>] ErrorUtils =
    abstract setGlobalHandler: (ErrorHandlerCallback -> unit) with get, set
    abstract getGlobalHandler: (unit -> ErrorHandlerCallback) with get, set

module Addons =

    type [<AllowNullLiteral>] IExports =
        abstract TestModule: TestModuleStatic

    type [<AllowNullLiteral>] TestModuleStatic =
        abstract verifySnapshot: (((obj) option -> unit) -> unit) with get, set
        abstract markTestPassed: (obj option -> unit) with get, set
        abstract markTestCompleted: (unit -> unit) with get, set

    type TestModule =
        TestModuleStatic

/// <summary>Console polyfill</summary>
/// <seealso href="https://facebook.github.io/react-native/docs/javascript-environment.html#polyfills" />
type [<AllowNullLiteral>] Console =
    abstract error: ?message: obj * [<ParamArray>] optionalParams: obj option[] -> unit
    abstract info: ?message: obj * [<ParamArray>] optionalParams: obj option[] -> unit
    abstract log: ?message: obj * [<ParamArray>] optionalParams: obj option[] -> unit
    abstract warn: ?message: obj * [<ParamArray>] optionalParams: obj option[] -> unit
    abstract trace: ?message: obj * [<ParamArray>] optionalParams: obj option[] -> unit
    abstract debug: ?message: obj * [<ParamArray>] optionalParams: obj option[] -> unit
    abstract table: [<ParamArray>] data: obj option[] -> unit
    abstract disableYellowBox: bool with get, set
    abstract ignoredYellowBox: ResizeArray<string> with get, set

/// <summary>Navigator object for accessing location API</summary>
/// <seealso href="https://facebook.github.io/react-native/docs/javascript-environment.html#polyfills" />
type [<AllowNullLiteral>] Navigator =
    abstract product: string
    abstract geolocation: Geolocation

type [<AllowNullLiteral>] NativeMethodsMixinStaticRefs =
    [<EmitIndexer>] abstract Item: key: string -> React.Component<obj option, obj option> with get, set

type [<AllowNullLiteral>] LayoutAnimationStaticConfigChecker =
    [<EmitIndexer>] abstract Item: key: string -> obj option with get, set

type [<AllowNullLiteral>] LayoutAnimationStaticPresets =
    abstract easeInEaseOut: LayoutAnimationConfig with get, set
    abstract linear: LayoutAnimationConfig with get, set
    abstract spring: LayoutAnimationConfig with get, set

type [<StringEnum>] [<RequireQualifiedAccess>] FlexStyleAlignContent =
    | [<CompiledName "flex-start">] FlexStart
    | [<CompiledName "flex-end">] FlexEnd
    | Center
    | Stretch
    | [<CompiledName "space-between">] SpaceBetween
    | [<CompiledName "space-around">] SpaceAround

type [<StringEnum>] [<RequireQualifiedAccess>] FlexStyleDisplay =
    | None
    | Flex

type [<StringEnum>] [<RequireQualifiedAccess>] FlexStyleFlexDirection =
    | Row
    | Column
    | [<CompiledName "row-reverse">] RowReverse
    | [<CompiledName "column-reverse">] ColumnReverse

type [<StringEnum>] [<RequireQualifiedAccess>] FlexStyleFlexWrap =
    | Wrap
    | Nowrap
    | [<CompiledName "wrap-reverse">] WrapReverse

type [<StringEnum>] [<RequireQualifiedAccess>] FlexStyleJustifyContent =
    | [<CompiledName "flex-start">] FlexStart
    | [<CompiledName "flex-end">] FlexEnd
    | Center
    | [<CompiledName "space-between">] SpaceBetween
    | [<CompiledName "space-around">] SpaceAround
    | [<CompiledName "space-evenly">] SpaceEvenly

type [<StringEnum>] [<RequireQualifiedAccess>] FlexStyleOverflow =
    | Visible
    | Hidden
    | Scroll

type [<StringEnum>] [<RequireQualifiedAccess>] FlexStylePosition =
    | Absolute
    | Relative

type [<StringEnum>] [<RequireQualifiedAccess>] FlexStyleDirection =
    | Inherit
    | Ltr
    | Rtl

type [<AllowNullLiteral>] ShadowPropTypesIOSStaticShadowOffset =
    abstract width: float with get, set
    abstract height: float with get, set

type [<AllowNullLiteral>] GeolocationReturnTypeCoords =
    abstract latitude: float with get, set
    abstract longitude: float with get, set
    abstract altitude: float option with get, set
    abstract accuracy: float with get, set
    abstract altitudeAccuracy: float option with get, set
    abstract heading: float option with get, set
    abstract speed: float option with get, set

type [<AllowNullLiteral>] LayoutChangeEventNativeEvent =
    abstract layout: LayoutRectangle with get, set

type [<StringEnum>] [<RequireQualifiedAccess>] TextStyleIOSTextDecorationStyle =
    | Solid
    | Double
    | Dotted
    | Dashed

type [<StringEnum>] [<RequireQualifiedAccess>] TextStyleIOSTextTransform =
    | None
    | Capitalize
    | Uppercase
    | Lowercase

type [<StringEnum>] [<RequireQualifiedAccess>] TextStyleIOSWritingDirection =
    | Auto
    | Ltr
    | Rtl

type [<StringEnum>] [<RequireQualifiedAccess>] TextStyleAndroidTextAlignVertical =
    | Auto
    | Top
    | Bottom
    | Center

type [<StringEnum>] [<RequireQualifiedAccess>] TextStyleFontStyle =
    | Normal
    | Italic

type [<StringEnum>] [<RequireQualifiedAccess>] TextStyleFontWeight =
    | Normal
    | Bold
    | [<CompiledName "100">] N100
    | [<CompiledName "200">] N200
    | [<CompiledName "300">] N300
    | [<CompiledName "400">] N400
    | [<CompiledName "500">] N500
    | [<CompiledName "600">] N600
    | [<CompiledName "700">] N700
    | [<CompiledName "800">] N800
    | [<CompiledName "900">] N900

type [<StringEnum>] [<RequireQualifiedAccess>] TextStyleTextAlign =
    | Auto
    | Left
    | Right
    | Center
    | Justify

type [<StringEnum>] [<RequireQualifiedAccess>] TextStyleTextDecorationLine =
    | None
    | Underline
    | [<CompiledName "line-through">] LineThrough
    | [<CompiledName "underline line-through">] ``Underline lineThrough``

type [<StringEnum>] [<RequireQualifiedAccess>] TextPropsAndroidTextBreakStrategy =
    | Simple
    | HighQuality
    | Balanced

type [<StringEnum>] [<RequireQualifiedAccess>] TextPropsEllipsizeMode =
    | Head
    | Middle
    | Tail
    | Clip

type [<StringEnum>] [<RequireQualifiedAccess>] TextInputIOSPropsClearButtonMode =
    | Never
    | [<CompiledName "while-editing">] WhileEditing
    | [<CompiledName "unless-editing">] UnlessEditing
    | Always

type [<StringEnum>] [<RequireQualifiedAccess>] TextInputIOSPropsKeyboardAppearance =
    | Default
    | Light
    | Dark

type [<StringEnum>] [<RequireQualifiedAccess>] TextInputIOSPropsTextContentType =
    | None
    | [<CompiledName "URL">] URL
    | AddressCity
    | AddressCityAndState
    | AddressState
    | CountryName
    | CreditCardNumber
    | EmailAddress
    | FamilyName
    | FullStreetAddress
    | GivenName
    | JobTitle
    | Location
    | MiddleName
    | Name
    | NamePrefix
    | NameSuffix
    | Nickname
    | OrganizationName
    | PostalCode
    | StreetAddressLine1
    | StreetAddressLine2
    | Sublocality
    | TelephoneNumber
    | Username
    | Password

type [<AllowNullLiteral>] TextInputScrollEventDataContentOffset =
    abstract x: float with get, set
    abstract y: float with get, set

type [<AllowNullLiteral>] TextInputSelectionChangeEventDataSelection =
    abstract start: float with get, set
    abstract ``end``: float with get, set

type [<StringEnum>] [<RequireQualifiedAccess>] TextInputPropsAutoCapitalize =
    | None
    | Sentences
    | Words
    | Characters

type [<AllowNullLiteral>] TextInputPropsSelection =
    abstract start: float with get, set
    abstract ``end``: float option with get, set

type [<StringEnum>] [<RequireQualifiedAccess>] ToolbarAndroidActionShow =
    | Always
    | IfRoom
    | Never

type [<StringEnum>] [<RequireQualifiedAccess>] ViewStyleBackfaceVisibility =
    | Visible
    | Hidden

type [<StringEnum>] [<RequireQualifiedAccess>] ViewStyleBorderStyle =
    | Solid
    | Dotted
    | Dashed

type [<StringEnum>] [<RequireQualifiedAccess>] AccessibilityPropsAndroidAccessibilityComponentType =
    | None
    | Button
    | Radiobutton_checked
    | Radiobutton_unchecked

type [<StringEnum>] [<RequireQualifiedAccess>] AccessibilityPropsAndroidAccessibilityLiveRegion =
    | None
    | Polite
    | Assertive

type [<StringEnum>] [<RequireQualifiedAccess>] AccessibilityPropsAndroidImportantForAccessibility =
    | Auto
    | Yes
    | No
    | [<CompiledName "no-hide-descendants">] NoHideDescendants

type [<StringEnum>] [<RequireQualifiedAccess>] ViewPropsPointerEvents =
    | [<CompiledName "box-none">] BoxNone
    | None
    | [<CompiledName "box-only">] BoxOnly
    | Auto

type [<StringEnum>] [<RequireQualifiedAccess>] ViewPagerAndroidPropsOnPageScrollStateChanged =
    | [<CompiledName "Idle">] Idle
    | [<CompiledName "Dragging">] Dragging
    | [<CompiledName "Settling">] Settling

type [<StringEnum>] [<RequireQualifiedAccess>] ViewPagerAndroidPropsKeyboardDismissMode =
    | None
    | [<CompiledName "on-drag">] OnDrag

type [<StringEnum>] [<RequireQualifiedAccess>] KeyboardAvoidingViewPropsBehavior =
    | Height
    | Position
    | Padding

type [<StringEnum>] [<RequireQualifiedAccess>] WebViewPropsAndroidMixedContentMode =
    | Never
    | Always
    | Compatibility

type [<StringEnum>] [<RequireQualifiedAccess>] WebViewIOSLoadRequestEventNavigationType =
    | Click
    | Formsubmit
    | Backforward
    | Reload
    | Formresubmit
    | Other

type [<StringEnum>] [<RequireQualifiedAccess>] WebViewUriSourceMethod =
    | [<CompiledName "GET">] GET
    | [<CompiledName "POST">] POST

type [<AllowNullLiteral>] ActivityIndicatorIOSPropsOnLayoutNativeEventLayout =
    abstract x: float with get, set
    abstract y: float with get, set
    abstract width: float with get, set
    abstract height: float with get, set

type [<AllowNullLiteral>] ActivityIndicatorIOSPropsOnLayoutNativeEvent =
    abstract layout: ActivityIndicatorIOSPropsOnLayoutNativeEventLayout with get, set

type [<AllowNullLiteral>] ActivityIndicatorIOSPropsOnLayout =
    abstract nativeEvent: ActivityIndicatorIOSPropsOnLayoutNativeEvent with get, set

type [<StringEnum>] [<RequireQualifiedAccess>] ActivityIndicatorIOSPropsSize =
    | Small
    | Large

type [<RequireQualifiedAccess>] DatePickerIOSPropsMinuteInterval =
    | N1 = 1
    | N2 = 2
    | N3 = 3
    | N4 = 4
    | N5 = 5
    | N6 = 6
    | N10 = 10
    | N12 = 12
    | N15 = 15
    | N20 = 20
    | N30 = 30

type [<StringEnum>] [<RequireQualifiedAccess>] DatePickerIOSPropsMode =
    | Date
    | Time
    | Datetime

type [<StringEnum>] [<RequireQualifiedAccess>] DrawerLayoutAndroidPropsDrawerLockMode =
    | Unlocked
    | [<CompiledName "locked-closed">] LockedClosed
    | [<CompiledName "locked-open">] LockedOpen

type [<StringEnum>] [<RequireQualifiedAccess>] PickerPropsAndroidMode =
    | Dialog
    | Dropdown

type [<StringEnum>] [<RequireQualifiedAccess>] ProgressBarAndroidPropsStyleAttr =
    | [<CompiledName "Horizontal">] Horizontal
    | [<CompiledName "Normal">] Normal
    | [<CompiledName "Small">] Small
    | [<CompiledName "Large">] Large
    | [<CompiledName "Inverse">] Inverse
    | [<CompiledName "SmallInverse">] SmallInverse
    | [<CompiledName "LargeInverse">] LargeInverse

type [<StringEnum>] [<RequireQualifiedAccess>] ProgressViewIOSPropsProgressViewStyle =
    | Default
    | Bar

type [<AllowNullLiteral>] RecyclerViewBackedScrollViewScrollTo =
    abstract x: float option with get, set
    abstract y: float option with get, set
    abstract animated: bool option with get, set

type [<AllowNullLiteral>] ImageURISourceHeaders =
    [<EmitIndexer>] abstract Item: key: string -> string with get, set

type [<StringEnum>] [<RequireQualifiedAccess>] ImageURISourceCache =
    | Default
    | Reload
    | [<CompiledName "force-cache">] ForceCache
    | [<CompiledName "only-if-cached">] OnlyIfCached

type [<StringEnum>] [<RequireQualifiedAccess>] ImagePropsAndroidResizeMethod =
    | Auto
    | Resize
    | Scale

type [<AllowNullLiteral>] ImageLoadEventDataSource =
    abstract height: float with get, set
    abstract width: float with get, set
    abstract url: string with get, set

type [<StringEnum>] [<RequireQualifiedAccess>] ImageStaticQueryCachePromiseMap =
    | Memory
    | Disk

type [<AllowNullLiteral>] ViewabilityConfigCallbackPairOnViewableItemsChanged =
    abstract viewableItems: Array<ViewToken> with get, set
    abstract changed: Array<ViewToken> with get, set

type [<StringEnum>] [<RequireQualifiedAccess>] ListRenderItemInfoSeparatorsUpdateProps =
    | Leading
    | Trailing

type [<AllowNullLiteral>] ListRenderItemInfoSeparators =
    abstract highlight: (unit -> unit) with get, set
    abstract unhighlight: (unit -> unit) with get, set
    abstract updateProps: (ListRenderItemInfoSeparatorsUpdateProps -> obj option -> unit) with get, set

type [<AllowNullLiteral>] FlatListPropsGetItemLayout =
    abstract length: float with get, set
    abstract offset: float with get, set
    abstract index: float with get, set

type [<AllowNullLiteral>] FlatListPropsOnEndReached =
    abstract distanceFromEnd: float with get, set

type [<AllowNullLiteral>] FlatListGetMetrics =
    abstract contentLength: float with get, set
    abstract totalRows: float with get, set
    abstract renderedRows: float with get, set
    abstract visibleRows: float with get, set

type [<AllowNullLiteral>] FlatListScrollToEnd =
    abstract animated: bool option with get, set

type [<AllowNullLiteral>] FlatListScrollToIndex =
    abstract animated: bool option with get, set
    abstract index: float with get, set
    abstract viewOffset: float option with get, set
    abstract viewPosition: float option with get, set

type [<AllowNullLiteral>] FlatListScrollToItem<'ItemT> =
    abstract animated: bool option with get, set
    abstract item: 'ItemT with get, set
    abstract viewPosition: float option with get, set

type [<AllowNullLiteral>] FlatListScrollToOffset =
    abstract animated: bool option with get, set
    abstract offset: float with get, set

type [<AllowNullLiteral>] SectionListPropsOnScrollToIndexFailed =
    abstract index: float with get, set
    abstract highestMeasuredFrameIndex: float with get, set
    abstract averageItemLength: float with get, set

type [<AllowNullLiteral>] SectionListPropsRenderSectionHeader<'ItemT> =
    abstract section: SectionListData<'ItemT> with get, set

type [<AllowNullLiteral>] ListViewPropsOnChangeVisibleRowsArrayItem =
    [<EmitIndexer>] abstract Item: rowID: string -> bool with get, set

type [<AllowNullLiteral>] ListViewPropsOnChangeVisibleRowsArray =
    [<EmitIndexer>] abstract Item: sectionId: string -> ListViewPropsOnChangeVisibleRowsArrayItem with get, set

type [<AllowNullLiteral>] MapViewOverlayCoordinates =
    abstract latitude: float with get, set
    abstract longitude: float with get, set

type [<StringEnum>] [<RequireQualifiedAccess>] MapViewPropsMapType =
    | Standard
    | Satellite
    | Hybrid

type [<AllowNullLiteral>] MapViewStaticPinColors =
    abstract RED: string with get, set
    abstract GREEN: string with get, set
    abstract PURPLE: string with get, set

type [<StringEnum>] [<RequireQualifiedAccess>] ModalBasePropsAnimationType =
    | None
    | Slide
    | Fade

type [<StringEnum>] [<RequireQualifiedAccess>] ModalPropsIOSPresentationStyle =
    | FullScreen
    | PageSheet
    | FormSheet
    | OverFullScreen

type [<StringEnum>] [<RequireQualifiedAccess>] ModalPropsIOSSupportedOrientationsArray =
    | Portrait
    | [<CompiledName "portrait-upside-down">] PortraitUpsideDown
    | Landscape
    | [<CompiledName "landscape-left">] LandscapeLeft
    | [<CompiledName "landscape-right">] LandscapeRight

type [<StringEnum>] [<RequireQualifiedAccess>] TabBarIOSItemPropsSystemIcon =
    | Bookmarks
    | Contacts
    | Downloads
    | Favorites
    | Featured
    | History
    | More
    | [<CompiledName "most-recent">] MostRecent
    | [<CompiledName "most-viewed">] MostViewed
    | Recents
    | Search
    | [<CompiledName "top-rated">] TopRated

type [<StringEnum>] [<RequireQualifiedAccess>] TabBarIOSPropsItemPositioning =
    | Fill
    | Center
    | Auto

type [<AllowNullLiteral>] DimensionsAddEventListener_change =
    abstract window: ScaledSize with get, set
    abstract screen: ScaledSize with get, set

type [<AllowNullLiteral>] InteractionManagerStaticEvents =
    abstract interactionStart: string with get, set
    abstract interactionComplete: string with get, set

type [<StringEnum>] [<RequireQualifiedAccess>] ScrollViewPropsIOSContentInsetAdjustmentBehavior =
    | Automatic
    | ScrollableAxes
    | Never
    | Always

type [<StringEnum>] [<RequireQualifiedAccess>] ScrollViewPropsIOSIndicatorStyle =
    | Default
    | Black
    | White

type [<StringEnum>] [<RequireQualifiedAccess>] ScrollViewPropsIOSSnapToAlignment =
    | Start
    | Center
    | End

type [<StringEnum>] [<RequireQualifiedAccess>] ScrollViewPropsAndroidOverScrollMode =
    | Auto
    | Always
    | Never

type [<StringEnum>] [<RequireQualifiedAccess>] ScrollViewPropsKeyboardDismissMode =
    | None
    | Interactive
    | [<CompiledName "on-drag">] OnDrag

type [<StringEnum>] [<RequireQualifiedAccess>] AlertButtonStyle =
    | Default
    | Cancel
    | Destructive

type [<AllowNullLiteral>] CameraRollAssetInfoPage_info =
    abstract has_next_page: bool with get, set
    abstract end_cursor: string with get, set

type [<AllowNullLiteral>] GetPhotosReturnTypeEdgesNodeImage =
    abstract uri: string with get, set
    abstract height: float with get, set
    abstract width: float with get, set
    abstract isStored: bool option with get, set

type [<AllowNullLiteral>] GetPhotosReturnTypeEdgesNodeLocation =
    abstract latitude: float with get, set
    abstract longitude: float with get, set
    abstract altitude: float with get, set
    abstract heading: float with get, set
    abstract speed: float with get, set

type [<AllowNullLiteral>] GetPhotosReturnTypeEdgesNode =
    abstract ``type``: string with get, set
    abstract group_name: string with get, set
    abstract image: GetPhotosReturnTypeEdgesNodeImage with get, set
    abstract timestamp: float with get, set
    abstract location: GetPhotosReturnTypeEdgesNodeLocation with get, set

type [<AllowNullLiteral>] GetPhotosReturnTypeEdges =
    abstract node: GetPhotosReturnTypeEdgesNode with get, set

type [<AllowNullLiteral>] GetPhotosReturnTypePage_info =
    abstract has_next_page: bool with get, set
    abstract start_cursor: string option with get, set
    abstract end_cursor: string option with get, set

type [<StringEnum>] [<RequireQualifiedAccess>] DatePickerAndroidOpenOptionsMode =
    | Calendar
    | Spinner
    | Default

type [<AllowNullLiteral>] LinkingStaticAddEventListener =
    abstract url: string with get, set

type [<AllowNullLiteral>] NetInfoStaticIsConnected =
    abstract fetch: (unit -> Promise<bool>) with get, set
    /// <summary>eventName is expected to be <c>change</c>(deprecated) or <c>connectionChange</c></summary>
    abstract addEventListener: (string -> (bool -> unit) -> unit) with get, set
    /// <summary>eventName is expected to be <c>change</c>(deprecated) or <c>connectionChange</c></summary>
    abstract removeEventListener: (string -> (bool -> unit) -> unit) with get, set

type [<AllowNullLiteral>] PermissionsAndroidStaticRESULTS =
    [<EmitIndexer>] abstract Item: key: string -> PermissionStatus with get, set

type [<AllowNullLiteral>] PermissionsAndroidStaticPERMISSIONS =
    [<EmitIndexer>] abstract Item: key: string -> Permission with get, set

type [<AllowNullLiteral>] PermissionsAndroidStaticRequestMultiplePromise =
    [<EmitIndexer>] abstract Item: permission: string -> PermissionStatus with get, set

type [<AllowNullLiteral>] PushNotificationIOSStaticAddEventListener_registrationError =
    abstract message: string with get, set
    abstract code: float with get, set
    abstract details: obj option with get, set

type [<StringEnum>] [<RequireQualifiedAccess>] StatusBarPropsIOSShowHideTransition =
    | Fade
    | Slide

type [<StringEnum>] [<RequireQualifiedAccess>] TimePickerAndroidOpenOptionsMode =
    | Clock
    | Spinner
    | Default

type [<AllowNullLiteral>] TimePickerAndroidStaticOpenPromise =
    abstract action: string with get, set
    abstract hour: float with get, set
    abstract minute: float with get, set

type [<StringEnum>] [<RequireQualifiedAccess>] UIManagerStaticTakeSnapshotFormat =
    | Png
    | Jpeg

type [<AllowNullLiteral>] UIManagerStaticTakeSnapshot =
    abstract width: float option with get, set
    abstract height: float option with get, set
    abstract format: UIManagerStaticTakeSnapshotFormat option with get, set
    abstract quality: float option with get, set

type [<AllowNullLiteral>] I18nManagerStaticAllowRTL =
    interface end

type [<StringEnum>] [<RequireQualifiedAccess>] ImageCropDataResizeMode =
    | Contain
    | Cover
    | Stretch

type [<StringEnum>] [<RequireQualifiedAccess>] ARTRenderableMixinStrokeCap =
    | Butt
    | Square
    | Round

type [<StringEnum>] [<RequireQualifiedAccess>] ARTRenderableMixinStrokeJoin =
    | Bevel
    | Miter
    | Round

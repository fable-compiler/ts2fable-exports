// ts2fable 0.0.0
module rec ReactXP
open System
open Fable.Core
open Fable.Import.JS
open Fable.Import.Browser

module ReactXP = __web_ReactXP

module __android_Accessibility =
    let [<Import("","reactxp/android/Accessibility")>] : ``.IExports`` = jsNative
    type Accessibility as NativeAccessibility = ___native_common_Accessibility.Accessibility as NativeAccessibility
    let [<Import("_default","reactxp")>] _default: Accessibility = jsNative

    type [<AllowNullLiteral>] IExports =
        abstract Accessibility: AccessibilityStatic

    type [<AllowNullLiteral>] Accessibility =
        inherit NativeAccessibility
        abstract _lastAnnouncement: obj with get, set
        abstract announceForAccessibility: announcement: string -> unit

    type [<AllowNullLiteral>] AccessibilityStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> Accessibility

module __android_AccessibilityUtil =
    let [<Import("","reactxp/android/AccessibilityUtil")>] : ``.IExports`` = jsNative
    type AccessibilityPlatformUtil as CommonAccessibilityNativeUtil = ___common_AccessibilityUtil.AccessibilityPlatformUtil as CommonAccessibilityNativeUtil
    let [<Import("_default","reactxp")>] _default: AccessibilityUtil = jsNative

    type [<AllowNullLiteral>] IExports =
        abstract AccessibilityUtil: AccessibilityUtilStatic

    type [<AllowNullLiteral>] AccessibilityUtil =
        inherit CommonAccessibilityNativeUtil
        abstract _sendAccessibilityEvent: obj with get, set
        abstract setAccessibilityFocus: ``component``: React.Component<obj option, obj option> -> unit

    type [<AllowNullLiteral>] AccessibilityUtilStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> AccessibilityUtil

module __android_GestureView =
    let [<Import("","reactxp/android/GestureView")>] : ``.IExports`` = jsNative
    type GestureView as BaseGestureView = ___native_common_GestureView.GestureView as BaseGestureView

    type [<AllowNullLiteral>] IExports =
        abstract GestureView: GestureViewStatic

    type [<AllowNullLiteral>] GestureView =
        inherit BaseGestureView
        abstract _getPreferredPanRatio: unit -> float
        abstract _getEventTimestamp: e: Types.TouchEvent -> float

    type [<AllowNullLiteral>] GestureViewStatic =
        [<Emit "new $0($1...)">] abstract Create: props: Types.GestureViewProps -> GestureView

module __android_Image =
    let [<Import("","reactxp/android/Image")>] : ``.IExports`` = jsNative
    type Image as CommonImage = ___native_common_Image.Image as CommonImage

    type [<AllowNullLiteral>] IExports =
        abstract Image: ImageStatic

    type [<AllowNullLiteral>] Image =
        inherit CommonImage
        abstract _getAdditionalProps: unit -> RN.ImagePropertiesAndroid

    type [<AllowNullLiteral>] ImageStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> Image

module __android_ReactXP =
    let [<Import("*","reactxp/android/ReactXP")>] reactXP: ReactXP.IExports = jsNative

    module ReactXP =

        type [<AllowNullLiteral>] IExports =
            abstract Accessibility: RXInterfaces.Accessibility
            abstract ActivityIndicator: obj
            abstract Alert: RXInterfaces.Alert
            abstract App: RXInterfaces.App
            abstract Button: obj
            abstract Picker: obj
            abstract Clipboard: RXInterfaces.Clipboard
            abstract GestureView: obj
            abstract Image: RXInterfaces.ImageConstructor
            abstract Input: RXInterfaces.Input
            abstract International: RXInterfaces.International
            abstract Link: obj
            abstract Linking: RXInterfaces.Linking
            abstract Location: RXInterfaces.Location
            abstract Modal: RXInterfaces.Modal
            abstract Network: RXInterfaces.Network
            abstract Platform: RXInterfaces.Platform
            abstract Popup: RXInterfaces.Popup
            abstract ScrollView: RXInterfaces.ScrollViewConstructor
            abstract StatusBar: RXInterfaces.StatusBar
            abstract Storage: RXInterfaces.Storage
            abstract Styles: RXInterfaces.Styles
            abstract Text: obj
            abstract TextInput: obj
            abstract UserInterface: RXInterfaces.UserInterface
            abstract UserPresence: RXInterfaces.UserPresence
            abstract View: obj
            abstract WebView: RXInterfaces.WebViewConstructor
            abstract Animated: RXInterfaces.Animated
            abstract __spread: obj option

        type Accessibility =
            RXInterfaces.Accessibility

        type ActivityIndicator =
            RXInterfaces.ActivityIndicator

        type Alert =
            RXInterfaces.Alert

        type App =
            RXInterfaces.App

        type Button =
            RXInterfaces.Button

        type Picker =
            RXInterfaces.Picker

        type Clipboard =
            RXInterfaces.Clipboard

        type GestureView =
            RXInterfaces.GestureView

        type Image =
            RXInterfaces.Image

        type Input =
            RXInterfaces.Input

        type International =
            RXInterfaces.International

        type Link =
            RXInterfaces.Link

        type Linking =
            RXInterfaces.Linking

        type Location =
            RXInterfaces.Location

        type Modal =
            RXInterfaces.Modal

        type Network =
            RXInterfaces.Network

        type Platform =
            RXInterfaces.Platform

        type Popup =
            RXInterfaces.Popup

        type ScrollView =
            RXInterfaces.ScrollView

        type StatusBar =
            RXInterfaces.StatusBar

        type Storage =
            RXInterfaces.Storage

        type Styles =
            RXInterfaces.Styles

        type Text =
            RXInterfaces.Text

        type TextInput =
            RXInterfaces.TextInput

        type UserInterface =
            RXInterfaces.UserInterface

        type UserPresence =
            RXInterfaces.UserPresence

        type View =
            RXInterfaces.View

        type WebView =
            RXInterfaces.WebView

module __android_StatusBar =
    let [<Import("","reactxp/android/StatusBar")>] : ``.IExports`` = jsNative
    let [<Import("_default","reactxp")>] _default: StatusBar = jsNative

    type [<AllowNullLiteral>] IExports =
        abstract StatusBar: StatusBarStatic

    type [<AllowNullLiteral>] StatusBar =
        inherit RX.StatusBar
        abstract isOverlay: unit -> bool
        abstract setHidden: hidden: bool * showHideTransition: U2<string, string> -> unit
        abstract setBackgroundColor: color: string * animated: bool -> unit
        abstract setTranslucent: translucent: bool -> unit
        abstract setBarStyle: style: U3<string, string, string> * animated: bool -> unit
        abstract setNetworkActivityIndicatorVisible: value: bool -> unit

    type [<AllowNullLiteral>] StatusBarStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> StatusBar

module __android_Text =
    let [<Import("","reactxp/android/Text")>] : ``.IExports`` = jsNative
    type Text as CommonText = ___native_common_Text.Text as CommonText

    type [<AllowNullLiteral>] IExports =
        abstract Text: TextStatic

    type [<AllowNullLiteral>] Text =
        inherit CommonText
        abstract _getStyles: unit -> Types.StyleRuleSetRecursiveArray<Types.TextStyleRuleSet>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] TextStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> Text

module __common_Accessibility =
    let [<Import("","reactxp/common/Accessibility")>] : ``.IExports`` = jsNative

    type [<AllowNullLiteral>] IExports =
        abstract Accessibility: AccessibilityStatic

    type [<AllowNullLiteral>] Accessibility =
        inherit RX.Accessibility
        abstract isScreenReaderEnabled: unit -> bool
        abstract screenReaderChangedEvent: SubscribableEvent<(bool -> unit)> with get, set
        abstract isHighContrastEnabled: unit -> bool
        abstract newAnnouncementReadyEvent: SubscribableEvent<(string -> unit)> with get, set
        abstract announceForAccessibility: announcement: string -> unit

    type [<AllowNullLiteral>] AccessibilityStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> Accessibility

module __common_AccessibilityUtil =
    let [<Import("","reactxp/common/AccessibilityUtil")>] : ``.IExports`` = jsNative
    let [<Import("ImportantForAccessibilityMap","reactxp")>] ImportantForAccessibilityMap: obj = jsNative

    type [<AllowNullLiteral>] IExports =
        abstract AccessibilityPlatformUtil: AccessibilityPlatformUtilStatic
        abstract AccessibilityUtil: AccessibilityUtilStatic

    type [<StringEnum>] [<RequireQualifiedAccess>] ImportantForAccessibilityValue =
        | Auto
        | Yes
        | No
        | [<CompiledName "no-hide-descendants">] NoHideDescendants

    type [<AllowNullLiteral>] AccessibilityPlatformUtil =
        abstract setAccessibilityFocus: ``component``: React.Component<obj option, obj option> -> unit

    type [<AllowNullLiteral>] AccessibilityPlatformUtilStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> AccessibilityPlatformUtil

    type [<AllowNullLiteral>] AccessibilityUtil =
        abstract isHidden: importantForAccessibility: Types.ImportantForAccessibility option -> obj option
        abstract importantForAccessibilityToString: importantForAccessibility: Types.ImportantForAccessibility option * ?defaultImportantForAccessibility: Types.ImportantForAccessibility -> ImportantForAccessibilityValue option
        abstract accessibilityLiveRegionToString: liveRegion: Types.AccessibilityLiveRegion -> string option
        abstract accessibilityTraitToString: ``trait``: U2<Types.AccessibilityTrait, ResizeArray<Types.AccessibilityTrait>> * ?defaultTrait: Types.AccessibilityTrait -> U2<string, ResizeArray<string>> option

    type [<AllowNullLiteral>] AccessibilityUtilStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> AccessibilityUtil

module __common_AppConfig =
    let [<Import("","reactxp/common/AppConfig")>] : ``.IExports`` = jsNative
    let [<Import("instance","reactxp")>] instance: AppConfig = jsNative

    type [<AllowNullLiteral>] IExports =
        abstract AppConfig: AppConfigStatic

    /// AppConfig.tsx
    /// 
    /// Copyright (c) Microsoft Corporation. All rights reserved.
    /// Licensed under the MIT license.
    /// 
    /// A simple class to store application config.
    type [<AllowNullLiteral>] AppConfig =
        abstract _isDebug: obj with get, set
        abstract _isDevelopment: obj with get, set
        abstract setAppConfig: isDebug: bool * isDevelopment: bool -> unit
        abstract isDebugMode: unit -> bool
        abstract isDevelopmentMode: unit -> bool

    /// AppConfig.tsx
    /// 
    /// Copyright (c) Microsoft Corporation. All rights reserved.
    /// Licensed under the MIT license.
    /// 
    /// A simple class to store application config.
    type [<AllowNullLiteral>] AppConfigStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> AppConfig

module __common_Bezier =
    let [<Import("","reactxp/common/Bezier")>] : ``.IExports`` = jsNative

    type [<AllowNullLiteral>] IExports =
        /// https://github.com/gre/bezier-easing
        /// BezierEasing - use bezier curve for transition easing function
        /// by Gaëtan Renaudeau 2014 - 2015 – MIT License
        abstract bezier: mX1: float * mY1: float * mX2: float * mY2: float -> (float -> float)

module __common_Easing =
    let [<Import("","reactxp/common/Easing")>] : ``.IExports`` = jsNative
    let [<Import("_default","reactxp")>] _default: Easing = jsNative

    type [<AllowNullLiteral>] IExports =
        abstract Easing: EasingStatic

    type [<AllowNullLiteral>] Easing =
        inherit Types.Animated.Easing
        abstract CubicBezier: x1: float * y1: float * x2: float * y2: float -> Types.Animated.EasingFunction
        abstract Default: unit -> Types.Animated.EasingFunction
        abstract Linear: unit -> Types.Animated.EasingFunction
        abstract Out: unit -> Types.Animated.EasingFunction
        abstract In: unit -> Types.Animated.EasingFunction
        abstract InOut: unit -> Types.Animated.EasingFunction
        abstract OutBack: unit -> Types.Animated.EasingFunction
        abstract InBack: unit -> Types.Animated.EasingFunction
        abstract InOutBack: unit -> Types.Animated.EasingFunction
        abstract Steps: intervals: float * ?``end``: bool -> Types.Animated.EasingFunction
        abstract StepStart: unit -> Types.Animated.EasingFunction
        abstract StepEnd: unit -> Types.Animated.EasingFunction

    type [<AllowNullLiteral>] EasingStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> Easing

module __common_Interfaces =
    let [<Import("","reactxp/common/Interfaces")>] : ``.IExports`` = jsNative

    type [<AllowNullLiteral>] IExports =
        abstract ActivityIndicator: ActivityIndicatorStatic
        abstract Alert: AlertStatic
        abstract AnimatedComponent: AnimatedComponentStatic
        abstract AnimatedImage: AnimatedImageStatic
        abstract AnimatedText: AnimatedTextStatic
        abstract AnimatedTextInput: AnimatedTextInputStatic
        abstract AnimatedView: AnimatedViewStatic
        abstract App: AppStatic
        abstract UserInterface: UserInterfaceStatic
        abstract Modal: ModalStatic
        abstract Popup: PopupStatic
        abstract Linking: LinkingStatic
        abstract Accessibility: AccessibilityStatic
        abstract Button: ButtonStatic
        abstract Picker: PickerStatic
        abstract Component: ComponentStatic
        abstract ImageConstructor: ImageConstructorStatic
        abstract Image: ImageStatic
        abstract Clipboard: ClipboardStatic
        abstract Link: LinkStatic
        abstract Storage: StorageStatic
        abstract Location: LocationStatic
        abstract Network: NetworkStatic
        abstract Platform: PlatformStatic
        abstract Input: InputStatic
        abstract ScrollViewConstructor: ScrollViewConstructorStatic
        abstract StatusBar: StatusBarStatic
        abstract Styles: StylesStatic
        abstract Text: TextStatic
        abstract TextInput: TextInputStatic
        abstract UserPresence: UserPresenceStatic
        abstract ViewBase: ViewBaseStatic
        abstract View: ViewStatic
        abstract GestureView: GestureViewStatic
        abstract WebViewConstructor: WebViewConstructorStatic

    type [<AllowNullLiteral>] ActivityIndicator =
        inherit React.Component<Types.ActivityIndicatorProps, obj option>

    type [<AllowNullLiteral>] ActivityIndicatorStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> ActivityIndicator

    type [<AllowNullLiteral>] Alert =
        abstract show: title: string * ?message: string * ?buttons: ResizeArray<Types.AlertButtonSpec> * ?options: Types.AlertOptions -> unit

    type [<AllowNullLiteral>] AlertStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> Alert

    type [<AllowNullLiteral>] AnimatedComponent<'P, 'T> =
        inherit React.Component<'P, 'T>
        abstract setNativeProps: props: 'P -> unit

    type [<AllowNullLiteral>] AnimatedComponentStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> AnimatedComponent<'P, 'T>

    type [<AllowNullLiteral>] AnimatedImage =
        inherit AnimatedComponent<Types.AnimatedImageProps, Types.Stateless>

    type [<AllowNullLiteral>] AnimatedImageStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> AnimatedImage

    type [<AllowNullLiteral>] AnimatedText =
        inherit AnimatedComponent<Types.AnimatedTextProps, Types.Stateless>

    type [<AllowNullLiteral>] AnimatedTextStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> AnimatedText

    type [<AllowNullLiteral>] AnimatedTextInput =
        inherit AnimatedComponent<Types.AnimatedTextInputProps, Types.Stateless>

    type [<AllowNullLiteral>] AnimatedTextInputStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> AnimatedTextInput

    type [<AllowNullLiteral>] AnimatedView =
        inherit AnimatedComponent<Types.AnimatedViewProps, Types.Stateless>
        inherit FocusableComponent
        abstract setFocusRestricted: restricted: bool -> unit
        abstract setFocusLimited: limited: bool -> unit
        abstract focus: unit -> unit
        abstract requestFocus: unit -> unit
        abstract blur: unit -> unit

    type [<AllowNullLiteral>] AnimatedViewStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> AnimatedView

    type [<AllowNullLiteral>] App =
        abstract initialize: debug: bool * development: bool -> unit
        abstract getActivationState: unit -> Types.AppActivationState
        abstract activationStateChangedEvent: SubscribableEvent<(Types.AppActivationState -> unit)> with get, set
        abstract memoryWarningEvent: SubscribableEvent<(unit -> unit)> with get, set

    type [<AllowNullLiteral>] AppStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> App

    type [<AllowNullLiteral>] UserInterface =
        abstract setMainView: element: React.ReactElement<obj option> -> unit
        abstract registerRootView: viewKey: string * getComponentFunc: Function -> unit
        abstract useCustomScrollbars: ?enable: bool -> unit
        abstract isHighPixelDensityScreen: unit -> bool
        abstract getPixelRatio: unit -> float
        abstract measureLayoutRelativeToWindow: ``component``: React.Component<obj option, obj option> -> SyncTasks.Promise<Types.LayoutInfo>
        abstract measureLayoutRelativeToAncestor: ``component``: React.Component<obj option, obj option> * ancestor: React.Component<obj option, obj option> -> SyncTasks.Promise<Types.LayoutInfo>
        abstract measureWindow: ?rootViewId: string -> Types.Dimensions
        abstract getContentSizeMultiplier: unit -> SyncTasks.Promise<float>
        abstract contentSizeMultiplierChangedEvent: SubscribableEvent<(float -> unit)> with get, set
        abstract setMaxContentSizeMultiplier: maxContentSizeMultiplier: float -> unit
        abstract dismissKeyboard: unit -> unit
        abstract enableTouchLatencyEvents: latencyThresholdMs: float -> unit
        abstract touchLatencyEvent: SubscribableEvent<(float -> unit)> with get, set
        abstract isNavigatingWithKeyboard: unit -> bool
        abstract keyboardNavigationEvent: SubscribableEvent<(bool -> unit)> with get, set

    type [<AllowNullLiteral>] UserInterfaceStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> UserInterface

    type [<AllowNullLiteral>] Modal =
        abstract isDisplayed: ?modalId: string -> bool
        abstract show: modal: React.ReactElement<Types.ViewProps> * modalId: string * ?options: Types.ModalOptions -> unit
        abstract dismiss: modalId: string -> unit
        abstract dismissAll: unit -> unit

    type [<AllowNullLiteral>] ModalStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> Modal

    type [<AllowNullLiteral>] Popup =
        abstract show: options: Types.PopupOptions * popupId: string * ?delay: float -> bool
        abstract autoDismiss: popupId: string * ?delay: float -> unit
        abstract dismiss: popupId: string -> unit
        abstract dismissAll: unit -> unit
        abstract isDisplayed: ?popupId: string -> bool

    type [<AllowNullLiteral>] PopupStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> Popup

    type [<AllowNullLiteral>] Linking =
        abstract getInitialUrl: unit -> SyncTasks.Promise<string option>
        abstract deepLinkRequestEvent: SubscribableEvent<(string -> unit)> with get, set
        abstract openUrl: url: string -> SyncTasks.Promise<unit>
        abstract launchSms: smsData: Types.SmsInfo -> SyncTasks.Promise<unit>
        abstract launchEmail: emailData: Types.EmailInfo -> SyncTasks.Promise<unit>
        abstract _createEmailUrl: emailInfo: Types.EmailInfo -> string

    type [<AllowNullLiteral>] LinkingStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> Linking

    type [<AllowNullLiteral>] Accessibility =
        abstract isScreenReaderEnabled: unit -> bool
        abstract isHighContrastEnabled: unit -> bool
        abstract announceForAccessibility: announcement: string -> unit
        abstract screenReaderChangedEvent: SubscribableEvent<(bool -> unit)> with get, set
        abstract highContrastChangedEvent: SubscribableEvent<(bool -> unit)> with get, set

    type [<AllowNullLiteral>] AccessibilityStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> Accessibility

    type [<AllowNullLiteral>] FocusableComponent =
        abstract focus: unit -> unit
        abstract requestFocus: unit -> unit
        abstract blur: unit -> unit

    type [<AllowNullLiteral>] Button =
        inherit React.Component<Types.ButtonProps, obj option>
        inherit FocusableComponent
        abstract focus: unit -> unit
        abstract requestFocus: unit -> unit
        abstract blur: unit -> unit

    type [<AllowNullLiteral>] ButtonStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> Button

    type [<AllowNullLiteral>] Picker =
        inherit React.Component<Types.PickerProps, Types.Stateless>

    type [<AllowNullLiteral>] PickerStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> Picker

    type [<AllowNullLiteral>] Component<'P, 'T> =
        inherit React.Component<'P, 'T>

    type [<AllowNullLiteral>] ComponentStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> Component<'P, 'T>

    type [<AllowNullLiteral>] ImageConstructor =
        abstract prefetch: url: string -> SyncTasks.Promise<bool>
        abstract getMetadata: url: string -> SyncTasks.Promise<Types.ImageMetadata>

    type [<AllowNullLiteral>] ImageConstructorStatic =
        [<Emit "new $0($1...)">] abstract Create: props: Types.ImageProps -> ImageConstructor

    type [<AllowNullLiteral>] Image =
        inherit React.Component<Types.ImageProps, obj option>
        abstract getNativeWidth: unit -> float option
        abstract getNativeHeight: unit -> float option

    type [<AllowNullLiteral>] ImageStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> Image

    type [<AllowNullLiteral>] Clipboard =
        abstract setText: text: string -> unit
        abstract getText: unit -> SyncTasks.Promise<string>

    type [<AllowNullLiteral>] ClipboardStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> Clipboard

    type [<AllowNullLiteral>] Link =
        inherit React.Component<Types.LinkProps, obj option>
        inherit FocusableComponent
        abstract focus: unit -> unit
        abstract requestFocus: unit -> unit
        abstract blur: unit -> unit

    type [<AllowNullLiteral>] LinkStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> Link

    type [<AllowNullLiteral>] Storage =
        abstract getItem: key: string -> SyncTasks.Promise<string option>
        abstract setItem: key: string * value: string -> SyncTasks.Promise<unit>
        abstract removeItem: key: string -> SyncTasks.Promise<unit>
        abstract clear: unit -> SyncTasks.Promise<unit>

    type [<AllowNullLiteral>] StorageStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> Storage

    type [<AllowNullLiteral>] Location =
        abstract isAvailable: unit -> bool
        abstract setConfiguration: config: LocationConfiguration -> unit
        abstract getCurrentPosition: ?options: PositionOptions -> SyncTasks.Promise<Position>
        abstract watchPosition: successCallback: Types.LocationSuccessCallback * ?errorCallback: Types.LocationFailureCallback * ?options: PositionOptions -> SyncTasks.Promise<Types.LocationWatchId>
        abstract clearWatch: watchID: Types.LocationWatchId -> unit

    type [<AllowNullLiteral>] LocationStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> Location

    type [<AllowNullLiteral>] LocationConfiguration =
        abstract skipPermissionRequests: bool with get, set

    type [<AllowNullLiteral>] Network =
        abstract isConnected: unit -> SyncTasks.Promise<bool>
        abstract getType: unit -> SyncTasks.Promise<Types.DeviceNetworkType>
        abstract connectivityChangedEvent: SubscribableEvent<(bool -> unit)> with get, set

    type [<AllowNullLiteral>] NetworkStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> Network

    type [<AllowNullLiteral>] Platform =
        abstract getType: unit -> Types.PlatformType
        abstract select: specifics: obj -> 'T option

    type [<AllowNullLiteral>] PlatformStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> Platform

    type [<AllowNullLiteral>] Input =
        abstract backButtonEvent: SubscribableEvent<(unit -> bool)> with get, set
        abstract keyDownEvent: SubscribableEvent<(Types.KeyboardEvent -> bool)> with get, set
        abstract keyUpEvent: SubscribableEvent<(Types.KeyboardEvent -> bool)> with get, set

    type [<AllowNullLiteral>] InputStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> Input

    type [<AllowNullLiteral>] ScrollViewConstructor =
        interface end

    type [<AllowNullLiteral>] ScrollViewConstructorStatic =
        [<Emit "new $0($1...)">] abstract Create: props: Types.ScrollViewProps -> ScrollViewConstructor

    type [<AllowNullLiteral>] ScrollView =
        inherit React.Component<Types.ScrollViewProps, obj option>
        abstract setScrollTop: scrollTop: float * ?animate: bool -> unit
        abstract setScrollLeft: scrollLeft: float * ?animate: bool -> unit
        abstract addToScrollTop: deltaTop: float * ?animate: bool -> unit
        abstract addToScrollLeft: deltaLeft: float * ?animate: bool -> unit

    type [<AllowNullLiteral>] StatusBar =
        abstract isOverlay: unit -> bool
        abstract setHidden: hidden: bool * showHideTransition: U2<string, string> -> unit
        abstract setBarStyle: style: U3<string, string, string> * animated: bool -> unit
        abstract setNetworkActivityIndicatorVisible: value: bool -> unit
        abstract setBackgroundColor: color: string * animated: bool -> unit
        abstract setTranslucent: translucent: bool -> unit

    type [<AllowNullLiteral>] StatusBarStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> StatusBar

    type [<AllowNullLiteral>] Styles =
        abstract combine: ruleSet1: Types.StyleRuleSetRecursive<'T> option * ?ruleSet2: Types.StyleRuleSetRecursive<'T> -> Types.StyleRuleSetOrArray<'T> option
        abstract createViewStyle: ruleSet: Types.ViewStyle * ?cacheStyle: bool -> Types.ViewStyleRuleSet
        abstract createAnimatedViewStyle: ruleSet: Types.AnimatedViewStyle -> Types.AnimatedViewStyleRuleSet
        abstract createScrollViewStyle: ruleSet: Types.ScrollViewStyle * ?cacheStyle: bool -> Types.ScrollViewStyleRuleSet
        abstract createButtonStyle: ruleSet: Types.ButtonStyle * ?cacheStyle: bool -> Types.ButtonStyleRuleSet
        abstract createWebViewStyle: ruleSet: Types.WebViewStyle * ?cacheStyle: bool -> Types.WebViewStyleRuleSet
        abstract createTextStyle: ruleSet: Types.TextStyle * ?cacheStyle: bool -> Types.TextStyleRuleSet
        abstract createAnimatedTextStyle: ruleSet: Types.AnimatedTextStyle -> Types.AnimatedTextStyleRuleSet
        abstract createTextInputStyle: ruleSet: Types.TextInputStyle * ?cacheStyle: bool -> Types.TextInputStyleRuleSet
        abstract createAnimatedTextInputStyle: ruleSet: Types.AnimatedTextInputStyle -> Types.AnimatedTextInputStyleRuleSet
        abstract createImageStyle: ruleSet: Types.ImageStyle * ?cacheStyle: bool -> Types.ImageStyleRuleSet
        abstract createAnimatedImageStyle: ruleSet: Types.AnimatedImageStyle -> Types.AnimatedImageStyleRuleSet
        abstract createLinkStyle: ruleSet: Types.LinkStyleRuleSet * ?cacheStyle: bool -> Types.LinkStyleRuleSet
        abstract createPickerStyle: ruleSet: Types.PickerStyle * ?cacheStyle: bool -> Types.PickerStyleRuleSet
        abstract getCssPropertyAliasesCssStyle: unit -> obj

    type [<AllowNullLiteral>] StylesStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> Styles

    type [<AllowNullLiteral>] Text =
        inherit React.Component<Types.TextProps, obj option>
        inherit FocusableComponent
        abstract focus: unit -> unit
        abstract requestFocus: unit -> unit
        abstract blur: unit -> unit

    type [<AllowNullLiteral>] TextStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> Text

    type [<AllowNullLiteral>] TextInput =
        inherit React.Component<Types.TextInputProps, obj option>
        inherit FocusableComponent
        abstract setAccessibilityFocus: unit -> unit
        abstract isFocused: unit -> bool
        abstract selectAll: unit -> unit
        abstract selectRange: start: float * ``end``: float -> unit
        abstract getSelectionRange: unit -> obj
        abstract setValue: value: string -> unit
        abstract focus: unit -> unit
        abstract requestFocus: unit -> unit
        abstract blur: unit -> unit

    type [<AllowNullLiteral>] TextInputStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> TextInput

    type [<AllowNullLiteral>] UserPresence =
        abstract isUserPresent: unit -> bool
        abstract userPresenceChangedEvent: SubscribableEvent<(bool -> unit)> with get, set

    type [<AllowNullLiteral>] UserPresenceStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> UserPresence

    type [<AllowNullLiteral>] ViewBase<'P, 'S> =
        inherit React.Component<'P, 'S>

    type [<AllowNullLiteral>] ViewBaseStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> ViewBase<'P, 'S>

    type [<AllowNullLiteral>] View =
        inherit ViewBase<Types.ViewProps, obj option>
        inherit FocusableComponent
        abstract setFocusRestricted: restricted: bool -> unit
        abstract setFocusLimited: limited: bool -> unit
        abstract focus: unit -> unit
        abstract requestFocus: unit -> unit
        abstract blur: unit -> unit

    type [<AllowNullLiteral>] ViewStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> View

    type [<AllowNullLiteral>] GestureView =
        inherit ViewBase<Types.GestureViewProps, obj option>

    type [<AllowNullLiteral>] GestureViewStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> GestureView

    type [<AllowNullLiteral>] WebViewConstructor =
        interface end

    type [<AllowNullLiteral>] WebViewConstructorStatic =
        [<Emit "new $0($1...)">] abstract Create: props: Types.WebViewProps -> WebViewConstructor

    type [<AllowNullLiteral>] WebView =
        inherit ViewBase<Types.WebViewProps, obj option>
        abstract postMessage: message: string * ?targetOrigin: string -> unit
        abstract reload: unit -> unit
        abstract goBack: unit -> unit
        abstract goForward: unit -> unit

    type [<AllowNullLiteral>] Animated =
        abstract Image: obj with get, set
        abstract Text: obj with get, set
        abstract TextInput: obj with get, set
        abstract View: obj with get, set
        abstract Easing: Types.Animated.Easing with get, set
        abstract timing: Types.Animated.TimingFunction with get, set
        abstract ``parallel``: Types.Animated.ParallelFunction with get, set
        abstract sequence: Types.Animated.SequenceFunction with get, set
        abstract Value: obj with get, set
        abstract createValue: (float -> Types.AnimatedValue) with get, set
        abstract interpolate: (Types.AnimatedValue -> ResizeArray<float> -> ResizeArray<string> -> Types.InterpolatedValue) with get, set

    type [<AllowNullLiteral>] International =
        abstract allowRTL: allow: bool -> unit
        abstract forceRTL: force: bool -> unit
        abstract isRTL: unit -> bool

module __common_Linking =
    let [<Import("","reactxp/common/Linking")>] : ``.IExports`` = jsNative

    type [<AllowNullLiteral>] IExports =
        abstract Linking: LinkingStatic

    type [<AllowNullLiteral>] Linking =
        inherit RX.Linking
        abstract _openUrl: url: string -> SyncTasks.Promise<unit>
        abstract launchSms: phoneInfo: Types.SmsInfo -> SyncTasks.Promise<unit>
        abstract openUrl: url: string -> SyncTasks.Promise<unit>
        abstract _createEmailUrl: emailInfo: Types.EmailInfo -> string
        abstract _createSmsUrl: smsInfo: Types.SmsInfo -> string
        abstract _isEmailValid: obj with get, set
        abstract _filterValidEmails: obj with get, set

    type [<AllowNullLiteral>] LinkingStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> Linking

module __common_Location =
    let [<Import("","reactxp/common/Location")>] : ``.IExports`` = jsNative
    let [<Import("_default","reactxp")>] _default: Location = jsNative

    type [<AllowNullLiteral>] IExports =
        abstract Location: LocationStatic

    type [<AllowNullLiteral>] Location =
        inherit RX.Location
        abstract setConfiguration: config: RX.LocationConfiguration -> unit
        abstract isAvailable: unit -> bool
        abstract getCurrentPosition: ?options: PositionOptions -> SyncTasks.Promise<Position>
        abstract watchPosition: successCallback: Types.LocationSuccessCallback * ?errorCallback: Types.LocationFailureCallback * ?options: PositionOptions -> SyncTasks.Promise<Types.LocationWatchId>
        abstract clearWatch: watchID: Types.LocationWatchId -> unit

    type [<AllowNullLiteral>] LocationStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> Location

module __common_lodashMini =

    type [<AllowNullLiteral>] Dictionary<'T> =
        [<Emit "$0[$1]{{=$2}}">] abstract Item: index: string -> 'T with get, set

module __common_ModuleInterface =
    let [<Import("*","reactxp/common/ModuleInterface")>] reactXP: ReactXP.IExports = jsNative

    module ReactXP =

        type [<AllowNullLiteral>] IExports =
            abstract Accessibility: Interfaces.Accessibility
            abstract ActivityIndicator: obj
            abstract Alert: Interfaces.Alert
            abstract App: Interfaces.App
            abstract Button: obj
            abstract Picker: obj
            abstract Clipboard: Interfaces.Clipboard
            abstract GestureView: obj
            abstract Image: Interfaces.ImageConstructor
            abstract Input: Interfaces.Input
            abstract International: Interfaces.International
            abstract Link: obj
            abstract Linking: Interfaces.Linking
            abstract Location: Interfaces.Location
            abstract Modal: Interfaces.Modal
            abstract Network: Interfaces.Network
            abstract Platform: Interfaces.Platform
            abstract Popup: Interfaces.Popup
            abstract ScrollView: Interfaces.ScrollViewConstructor
            abstract StatusBar: Interfaces.StatusBar
            abstract Storage: Interfaces.Storage
            abstract Styles: Interfaces.Styles
            abstract Text: obj
            abstract TextInput: obj
            abstract UserInterface: Interfaces.UserInterface
            abstract UserPresence: Interfaces.UserPresence
            abstract View: obj
            abstract WebView: Interfaces.WebViewConstructor
            abstract Animated: Interfaces.Animated
            abstract createElement: obj
            abstract Children: obj
            abstract __spread: obj option

        type Accessibility =
            Interfaces.Accessibility

        type ActivityIndicator =
            Interfaces.ActivityIndicator

        type Alert =
            Interfaces.Alert

        type App =
            Interfaces.App

        type Button =
            Interfaces.Button

        type Picker =
            Interfaces.Picker

        type Clipboard =
            Interfaces.Clipboard

        type GestureView =
            Interfaces.GestureView

        type Image =
            Interfaces.Image

        type Input =
            Interfaces.Input

        type International =
            Interfaces.International

        type Link =
            Interfaces.Link

        type Linking =
            Interfaces.Linking

        type Location =
            Interfaces.Location

        type Modal =
            Interfaces.Modal

        type Network =
            Interfaces.Network

        type Platform =
            Interfaces.Platform

        type Popup =
            Interfaces.Popup

        type ScrollView =
            Interfaces.ScrollView

        type StatusBar =
            Interfaces.StatusBar

        type Storage =
            Interfaces.Storage

        type Styles =
            Interfaces.Styles

        type Text =
            Interfaces.Text

        type TextInput =
            Interfaces.TextInput

        type UserInterface =
            Interfaces.UserInterface

        type UserPresence =
            Interfaces.UserPresence

        type View =
            Interfaces.View

        type WebView =
            Interfaces.WebView

        type Animated =
            Interfaces.Animated

module __common_PopupContainerViewBase =
    let [<Import("","reactxp/common/PopupContainerViewBase")>] : ``.IExports`` = jsNative

    type [<AllowNullLiteral>] IExports =
        abstract PopupContainerViewBase: PopupContainerViewBaseStatic

    type [<AllowNullLiteral>] PopupContainerViewBaseProps =
        inherit Types.CommonProps
        abstract hidden: bool option with get, set

    type [<AllowNullLiteral>] PopupContainerViewContext =
        abstract focusManager: FocusManagerBase option with get, set

    type [<AllowNullLiteral>] PopupComponent =
        abstract onShow: (unit -> unit) with get, set
        abstract onHide: (unit -> unit) with get, set

    type [<AllowNullLiteral>] PopupContainerViewBase<'P, 'S> =
        inherit React.Component<'P, 'S>
        abstract contextTypes: React.ValidationMap<obj option> with get, set
        abstract childContextTypes: React.ValidationMap<obj option> with get, set
        abstract _popupComponentStack: obj with get, set
        abstract getChildContext: unit -> obj
        abstract registerPopupComponent: onShow: (unit -> unit) * onHide: (unit -> unit) -> PopupComponent
        abstract unregisterPopupComponent: ``component``: PopupComponent -> unit
        abstract isHidden: unit -> bool
        abstract componentDidUpdate: prevProps: 'P * prevState: 'S -> unit
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] PopupContainerViewBaseStatic =
        [<Emit "new $0($1...)">] abstract Create: props: 'P * context: PopupContainerViewContext -> PopupContainerViewBase<'P, 'S>

module __common_StyleLeakDetector =
    let [<Import("","reactxp/common/StyleLeakDetector")>] : ``.IExports`` = jsNative
    let [<Import("instance","reactxp")>] instance: StyleLeakDetector = jsNative

    type [<AllowNullLiteral>] IExports =
        abstract StyleLeakDetector: StyleLeakDetectorStatic

    type [<AllowNullLiteral>] StyleLeakDetector =
        abstract _fingerprintRegistry: obj with get, set
        abstract _getFingerprint: obj with get, set
        /// We need to sort objects before using JSON.stringify as otherwise objects
        /// {a: 1, b: 2} and {b: 2, a: 1} would have a different fingerprints
        abstract _sortAny: obj with get, set
        abstract _sortObject: obj with get, set
        abstract _sortArray: obj with get, set
        abstract isDisabled: unit -> bool
        abstract detectLeaks: style: 'T -> unit

    type [<AllowNullLiteral>] StyleLeakDetectorStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> StyleLeakDetector

module __common_Types =
    let [<Import("","reactxp/common/Types")>] : ``.IExports`` = jsNative
    let [<Import("*","reactxp/common/Types")>] animated: Animated.IExports = jsNative
    let [<Import("Children","reactxp")>] Children: React.ReactChildren = jsNative

    type [<AllowNullLiteral>] IExports =
        abstract AnimatedValue: AnimatedValueStatic
        abstract InterpolatedValue: InterpolatedValueStatic

    type ReactNode =
        React.ReactNode

    type [<AllowNullLiteral>] ReactInterface =
        abstract createElement: ``type``: string * ?props: 'P * [<ParamArray>] children: ResizeArray<ReactNode> -> React.ReactElement<'P>

    type [<AllowNullLiteral>] FlexboxParentStyle =
        abstract flexDirection: U4<string, string, string, string> option with get, set
        abstract alignSelf: U5<string, string, string, string, string> option with get, set
        abstract borderWidth: float option with get, set
        abstract borderTopWidth: float option with get, set
        abstract borderRightWidth: float option with get, set
        abstract borderBottomWidth: float option with get, set
        abstract borderLeftWidth: float option with get, set
        abstract height: float option with get, set
        abstract width: float option with get, set
        abstract top: float option with get, set
        abstract right: float option with get, set
        abstract bottom: float option with get, set
        abstract left: float option with get, set
        abstract flexGrow: float option with get, set
        abstract flexShrink: float option with get, set
        abstract flexBasis: float option with get, set
        abstract flex: float option with get, set
        abstract maxHeight: float option with get, set
        abstract maxWidth: float option with get, set
        abstract minHeight: float option with get, set
        abstract minWidth: float option with get, set
        abstract margin: float option with get, set
        abstract marginHorizontal: float option with get, set
        abstract marginVertical: float option with get, set
        abstract marginTop: float option with get, set
        abstract marginRight: float option with get, set
        abstract marginBottom: float option with get, set
        abstract marginLeft: float option with get, set
        abstract padding: float option with get, set
        abstract paddingHorizontal: float option with get, set
        abstract paddingVertical: float option with get, set
        abstract paddingTop: float option with get, set
        abstract paddingRight: float option with get, set
        abstract paddingBottom: float option with get, set
        abstract paddingLeft: float option with get, set
        abstract position: U2<string, string> option with get, set

    type [<AllowNullLiteral>] FlexboxChildrenStyle =
        abstract alignItems: U4<string, string, string, string> option with get, set
        abstract alignContent: U5<string, string, string, string, string> option with get, set
        abstract flexWrap: U2<string, string> option with get, set
        abstract justifyContent: U5<string, string, string, string, string> option with get, set

    type [<AllowNullLiteral>] FlexboxStyle =
        inherit FlexboxParentStyle
        inherit FlexboxChildrenStyle

    type [<AllowNullLiteral>] InterpolationConfig =
        abstract inputRange: ResizeArray<float> with get, set
        abstract outputRange: U2<ResizeArray<float>, ResizeArray<string>> with get, set

    type [<AllowNullLiteral>] AnimatedValue =
        abstract setValue: value: float -> unit
        abstract interpolate: config: InterpolationConfig -> InterpolatedValue

    type [<AllowNullLiteral>] AnimatedValueStatic =
        [<Emit "new $0($1...)">] abstract Create: ``val``: float -> AnimatedValue

    type [<AllowNullLiteral>] InterpolatedValue =
        interface end

    type [<AllowNullLiteral>] InterpolatedValueStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> InterpolatedValue

    type [<AllowNullLiteral>] AnimatedFlexboxStyle =
        abstract height: U2<AnimatedValue, InterpolatedValue> option with get, set
        abstract width: U2<AnimatedValue, InterpolatedValue> option with get, set
        abstract top: U2<AnimatedValue, InterpolatedValue> option with get, set
        abstract right: U2<AnimatedValue, InterpolatedValue> option with get, set
        abstract bottom: U2<AnimatedValue, InterpolatedValue> option with get, set
        abstract left: U2<AnimatedValue, InterpolatedValue> option with get, set

    type [<AllowNullLiteral>] TransformStyle =
        abstract transform: ResizeArray<obj> option with get, set

    type [<AllowNullLiteral>] AnimatedTransformStyle =
        abstract transform: ResizeArray<obj> option with get, set

    type StyleRuleSet<'T> =
        U2<'T, float> option

    [<RequireQualifiedAccess; CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
    module StyleRuleSet =
        let ofTOption v: StyleRuleSet<'T> = v |> Microsoft.FSharp.Core.Option.map U2.Case1
        let ofT v: StyleRuleSet<'T> = v |> U2.Case1 |> Some
        let isT (v: StyleRuleSet<'T>) = match v with None -> false | Some o -> match o with U2.Case1 _ -> true | _ -> false
        let asT (v: StyleRuleSet<'T>) = match v with None -> None | Some o -> match o with U2.Case1 o -> Some o | _ -> None
        let ofFloatOption v: StyleRuleSet<'T> = v |> Microsoft.FSharp.Core.Option.map U2.Case2
        let ofFloat v: StyleRuleSet<'T> = v |> U2.Case2 |> Some
        let isFloat (v: StyleRuleSet<'T>) = match v with None -> false | Some o -> match o with U2.Case2 _ -> true | _ -> false
        let asFloat (v: StyleRuleSet<'T>) = match v with None -> None | Some o -> match o with U2.Case2 o -> Some o | _ -> None

    type StyleRuleSetOrArray<'T> =
        U2<StyleRuleSet<'T>, Array<StyleRuleSet<'T>>>

    [<RequireQualifiedAccess; CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
    module StyleRuleSetOrArray =
        let ofStyleRuleSet v: StyleRuleSetOrArray<'T> = v |> U2.Case1
        let isStyleRuleSet (v: StyleRuleSetOrArray<'T>) = match v with U2.Case1 _ -> true | _ -> false
        let asStyleRuleSet (v: StyleRuleSetOrArray<'T>) = match v with U2.Case1 o -> Some o | _ -> None
        let ofArray v: StyleRuleSetOrArray<'T> = v |> U2.Case2
        let isArray (v: StyleRuleSetOrArray<'T>) = match v with U2.Case2 _ -> true | _ -> false
        let asArray (v: StyleRuleSetOrArray<'T>) = match v with U2.Case2 o -> Some o | _ -> None

    type [<AllowNullLiteral>] StyleRuleSetRecursiveArray<'T> =
        inherit Array<U2<StyleRuleSetOrArray<'T>, StyleRuleSetRecursiveArray<'T>>>

    type StyleRuleSetRecursive<'T> =
        U2<StyleRuleSet<'T>, StyleRuleSetRecursiveArray<'T>>

    [<RequireQualifiedAccess; CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
    module StyleRuleSetRecursive =
        let ofStyleRuleSet v: StyleRuleSetRecursive<'T> = v |> U2.Case1
        let isStyleRuleSet (v: StyleRuleSetRecursive<'T>) = match v with U2.Case1 _ -> true | _ -> false
        let asStyleRuleSet (v: StyleRuleSetRecursive<'T>) = match v with U2.Case1 o -> Some o | _ -> None
        let ofStyleRuleSetRecursiveArray v: StyleRuleSetRecursive<'T> = v |> U2.Case2
        let isStyleRuleSetRecursiveArray (v: StyleRuleSetRecursive<'T>) = match v with U2.Case2 _ -> true | _ -> false
        let asStyleRuleSetRecursiveArray (v: StyleRuleSetRecursive<'T>) = match v with U2.Case2 o -> Some o | _ -> None

    type [<AllowNullLiteral>] ViewAndImageCommonStyle =
        inherit FlexboxStyle
        inherit TransformStyle
        abstract borderWidth: float option with get, set
        abstract borderColor: string option with get, set
        abstract borderRadius: float option with get, set
        abstract borderTopRightRadius: float option with get, set
        abstract borderBottomRightRadius: float option with get, set
        abstract borderBottomLeftRadius: float option with get, set
        abstract borderTopLeftRadius: float option with get, set
        abstract overflow: U2<string, string> option with get, set
        abstract backgroundColor: string option with get, set
        abstract opacity: float option with get, set

    type [<AllowNullLiteral>] AnimatedViewAndImageCommonStyle =
        inherit AnimatedFlexboxStyle
        inherit AnimatedTransformStyle
        abstract borderRadius: U2<AnimatedValue, InterpolatedValue> option with get, set
        abstract backgroundColor: InterpolatedValue option with get, set
        abstract opacity: U2<AnimatedValue, InterpolatedValue> option with get, set

    type [<AllowNullLiteral>] ShadowOffset =
        abstract width: float with get, set
        abstract height: float with get, set

    type [<AllowNullLiteral>] ViewStyle =
        inherit ViewAndImageCommonStyle
        abstract borderStyle: U4<string, string, string, string> option with get, set
        abstract wordBreak: U2<string, string> option with get, set
        abstract appRegion: U2<string, string> option with get, set
        abstract cursor: U2<string, string> option with get, set
        abstract shadowOffset: ShadowOffset option with get, set
        abstract shadowOpacity: float option with get, set
        abstract shadowRadius: float option with get, set
        abstract shadowColor: string option with get, set
        abstract elevation: float option with get, set
        abstract acrylicOpacityUWP: float option with get, set
        abstract acrylicSourceUWP: U2<string, string> option with get, set
        abstract acrylicTintColorUWP: string option with get, set

    type ViewStyleRuleSet =
        StyleRuleSet<ViewStyle>

    type [<AllowNullLiteral>] AnimatedViewStyle =
        inherit AnimatedViewAndImageCommonStyle

    type AnimatedViewStyleRuleSet =
        StyleRuleSet<AnimatedViewStyle>

    type [<AllowNullLiteral>] ScrollViewStyle =
        inherit FlexboxParentStyle
        inherit TransformStyle
        abstract overflow: U2<string, string> option with get, set
        abstract backgroundColor: string option with get, set
        abstract opacity: float option with get, set

    type ScrollViewStyleRuleSet =
        StyleRuleSet<ScrollViewStyle>

    type [<AllowNullLiteral>] ButtonStyle =
        inherit ViewStyle

    type ButtonStyleRuleSet =
        StyleRuleSet<ButtonStyle>

    type [<AllowNullLiteral>] WebViewStyle =
        inherit ViewStyle

    type WebViewStyleRuleSet =
        StyleRuleSet<WebViewStyle>

    type [<AllowNullLiteral>] ActivityIndicatorStyle =
        inherit ViewStyle

    type ActivityIndicatorStyleRuleSet =
        StyleRuleSet<ActivityIndicatorStyle>

    type [<AllowNullLiteral>] FontInfo =
        abstract fontFamily: string option with get, set
        abstract fontStyle: U2<string, string> option with get, set
        abstract fontWeight: obj option with get, set

    type [<AllowNullLiteral>] TextStyle =
        inherit ViewStyle
        abstract color: string option with get, set
        abstract fontFamily: string option with get, set
        abstract fontSize: float option with get, set
        abstract fontStyle: U2<string, string> option with get, set
        abstract fontWeight: obj option with get, set
        abstract font: FontInfo option with get, set
        abstract letterSpacing: float option with get, set
        abstract lineHeight: float option with get, set
        abstract textAlign: U5<string, string, string, string, string> option with get, set
        abstract textDecorationLine: U4<string, string, string, string> option with get, set
        abstract textDecorationStyle: U4<string, string, string, string> option with get, set
        abstract textDecorationColor: string option with get, set
        abstract writingDirection: U3<string, string, string> option with get, set
        abstract textAlignVertical: U4<string, string, string, string> option with get, set
        abstract includeFontPadding: bool option with get, set

    type TextStyleRuleSet =
        StyleRuleSet<TextStyle>

    type [<AllowNullLiteral>] AnimatedTextStyle =
        inherit AnimatedViewAndImageCommonStyle
        abstract color: InterpolatedValue option with get, set
        abstract fontSize: U2<AnimatedValue, InterpolatedValue> option with get, set

    type AnimatedTextStyleRuleSet =
        StyleRuleSet<AnimatedTextStyle>

    type [<AllowNullLiteral>] TextInputStyle =
        inherit TextStyle

    type TextInputStyleRuleSet =
        StyleRuleSet<TextInputStyle>

    type [<AllowNullLiteral>] AnimatedTextInputStyle =
        inherit AnimatedViewAndImageCommonStyle
        abstract color: InterpolatedValue option with get, set
        abstract fontSize: U2<AnimatedValue, InterpolatedValue> option with get, set

    type AnimatedTextInputStyleRuleSet =
        StyleRuleSet<AnimatedTextInputStyle>

    type [<AllowNullLiteral>] LinkStyle =
        inherit TextStyle

    type LinkStyleRuleSet =
        StyleRuleSet<LinkStyle>

    type [<AllowNullLiteral>] ImageStyle =
        inherit ViewAndImageCommonStyle
        inherit FlexboxStyle
        abstract overlayColor: string option with get, set

    type ImageStyleRuleSet =
        StyleRuleSet<ImageStyle>

    type [<AllowNullLiteral>] AnimatedImageStyle =
        inherit AnimatedViewAndImageCommonStyle
        inherit AnimatedFlexboxStyle

    type AnimatedImageStyleRuleSet =
        StyleRuleSet<AnimatedImageStyle>

    type [<AllowNullLiteral>] PickerStyle =
        inherit ViewStyle
        abstract color: string option with get, set

    type PickerStyleRuleSet =
        StyleRuleSet<PickerStyle>

    type ComponentBase =
        React.Component<obj option, obj option>

    type [<AllowNullLiteral>] CommonProps =
        abstract ref: U2<string, (ComponentBase option -> unit)> option with get, set
        abstract key: U2<string, float> option with get, set
        abstract children: U2<ReactNode, ResizeArray<ReactNode>> option with get, set
        abstract testId: string option with get, set

    type [<AllowNullLiteral>] Stateless =
        interface end

    type [<AllowNullLiteral>] CommonAccessibilityProps =
        abstract importantForAccessibility: ImportantForAccessibility option with get, set
        abstract accessibilityId: string option with get, set
        abstract accessibilityLabel: string option with get, set
        abstract accessibilityTraits: U2<AccessibilityTrait, ResizeArray<AccessibilityTrait>> option with get, set
        abstract tabIndex: float option with get, set
        abstract ariaValueNow: float option with get, set
        abstract accessibilityActions: ResizeArray<string> option with get, set
        abstract onAccessibilityAction: (SyntheticEvent -> unit) option with get, set

    type [<RequireQualifiedAccess>] ImportantForAccessibility =
        | Auto = 1
        | Yes = 2
        | No = 3
        | NoHideDescendants = 4

    type [<StringEnum>] [<RequireQualifiedAccess>] AriaLive =
        | Off
        | Assertive
        | Polite

    type [<RequireQualifiedAccess>] AccessibilityLiveRegion =
        | None = 0
        | Polite = 1
        | Assertive = 2

    type [<RequireQualifiedAccess>] AccessibilityTrait =
        | Summary = 0
        | Adjustable = 1
        | Button = 2
        | Tab = 3
        | Selected = 4
        | Radio_button_checked = 5
        | Radio_button_unchecked = 6
        | Link = 7
        | Header = 8
        | Search = 9
        | Image = 10
        | Plays = 11
        | Key = 12
        | Text = 13
        | Disabled = 14
        | FrequentUpdates = 15
        | StartsMedia = 16
        | AllowsDirectInteraction = 17
        | PageTurn = 18
        | Menu = 19
        | MenuItem = 20
        | MenuBar = 21
        | TabList = 22
        | List = 23
        | ListItem = 24
        | ListBox = 25
        | Group = 26
        | CheckBox = 27
        | Checked = 28
        | ComboBox = 29
        | Log = 30
        | Status = 31
        | Dialog = 32
        | HasPopup = 33
        | Option = 34
        | Switch = 35
        | None = 36

    type [<AllowNullLiteral>] FocusArbitrator =
        [<Emit "$0($1...)">] abstract Invoke: candidates: ResizeArray<FocusCandidate> -> FocusCandidate option

    type [<AllowNullLiteral>] FocusCandidate =
        abstract ``component``: RX.FocusableComponent with get, set
        abstract accessibilityId: string option with get, set

    type [<AllowNullLiteral>] CommonStyledProps<'T> =
        inherit CommonProps
        abstract style: StyleRuleSetRecursive<'T> option with get, set

    type [<AllowNullLiteral>] ButtonProps =
        inherit CommonStyledProps<ButtonStyleRuleSet>
        inherit CommonAccessibilityProps
        abstract title: string option with get, set
        abstract disabled: bool option with get, set
        abstract disabledOpacity: float option with get, set
        abstract delayLongPress: float option with get, set
        abstract autoFocus: bool option with get, set
        abstract onAccessibilityTapIOS: (SyntheticEvent -> unit) option with get, set
        abstract onContextMenu: (MouseEvent -> unit) option with get, set
        abstract onPress: (SyntheticEvent -> unit) option with get, set
        abstract onPressIn: (SyntheticEvent -> unit) option with get, set
        abstract onPressOut: (SyntheticEvent -> unit) option with get, set
        abstract onLongPress: (SyntheticEvent -> unit) option with get, set
        abstract onHoverStart: (SyntheticEvent -> unit) option with get, set
        abstract onHoverEnd: (SyntheticEvent -> unit) option with get, set
        abstract onKeyPress: (KeyboardEvent -> unit) option with get, set
        abstract onFocus: (FocusEvent -> unit) option with get, set
        abstract onBlur: (FocusEvent -> unit) option with get, set
        abstract shouldRasterizeIOS: bool option with get, set
        abstract disableTouchOpacityAnimation: bool option with get, set
        abstract activeOpacity: float option with get, set
        abstract underlayColor: string option with get, set
        abstract id: string option with get, set
        abstract ariaControls: string option with get, set

    type [<AllowNullLiteral>] PickerPropsItem =
        abstract label: string with get, set
        abstract value: string with get, set

    type [<AllowNullLiteral>] PickerProps =
        inherit CommonProps
        abstract items: ResizeArray<PickerPropsItem> with get, set
        abstract selectedValue: string with get, set
        abstract onValueChange: (string -> float -> unit) with get, set
        abstract style: StyleRuleSetRecursive<PickerStyleRuleSet> option with get, set
        abstract mode: U2<string, string> option with get, set

    type [<StringEnum>] [<RequireQualifiedAccess>] ImageResizeMode =
        | Stretch
        | Contain
        | Cover
        | Auto
        | Repeat

    type [<AllowNullLiteral>] ImagePropsShared =
        inherit CommonProps
        abstract source: string with get, set
        abstract headers: obj option with get, set
        abstract accessibilityLabel: string option with get, set
        abstract resizeMode: ImageResizeMode option with get, set
        abstract resizeMethod: U3<string, string, string> option with get, set
        abstract title: string option with get, set
        abstract onLoad: (Dimensions -> unit) option with get, set
        abstract onError: (Error -> unit) option with get, set

    type [<AllowNullLiteral>] ImageProps =
        inherit ImagePropsShared
        abstract style: StyleRuleSetRecursive<ImageStyleRuleSet> option with get, set

    type [<AllowNullLiteral>] ImageMetadata =
        abstract width: float with get, set
        abstract height: float with get, set

    type [<AllowNullLiteral>] AnimatedImageProps =
        inherit ImagePropsShared
        abstract style: StyleRuleSetRecursive<U2<AnimatedImageStyleRuleSet, ImageStyleRuleSet>> option with get, set

    type [<AllowNullLiteral>] TextPropsShared =
        inherit CommonProps
        abstract selectable: bool option with get, set
        abstract numberOfLines: float option with get, set
        abstract allowFontScaling: bool option with get, set
        abstract maxContentSizeMultiplier: float option with get, set
        abstract ellipsizeMode: U3<string, string, string> option with get, set
        abstract textBreakStrategy: U3<string, string, string> option with get, set
        abstract importantForAccessibility: ImportantForAccessibility option with get, set
        abstract accessibilityId: string option with get, set
        abstract autoFocus: bool option with get, set
        abstract onPress: (SyntheticEvent -> unit) option with get, set
        abstract id: string option with get, set
        abstract onContextMenu: (MouseEvent -> unit) option with get, set

    type [<AllowNullLiteral>] TextProps =
        inherit TextPropsShared
        abstract style: StyleRuleSetRecursive<TextStyleRuleSet> option with get, set

    type [<AllowNullLiteral>] AnimatedTextProps =
        inherit TextPropsShared
        abstract style: StyleRuleSetRecursive<U2<AnimatedTextStyleRuleSet, TextStyleRuleSet>> option with get, set

    type [<StringEnum>] [<RequireQualifiedAccess>] ViewLayerType =
        | None
        | Software
        | Hardware

    type [<RequireQualifiedAccess>] LimitFocusType =
        | Unlimited = 0
        | Limited = 1
        | Accessible = 2

    type [<AllowNullLiteral>] ViewPropsShared =
        inherit CommonProps
        inherit CommonAccessibilityProps
        abstract title: string option with get, set
        abstract ignorePointerEvents: bool option with get, set
        abstract blockPointerEvents: bool option with get, set
        abstract shouldRasterizeIOS: bool option with get, set
        abstract viewLayerTypeAndroid: ViewLayerType option with get, set
        abstract restrictFocusWithin: bool option with get, set
        abstract limitFocusWithin: LimitFocusType option with get, set
        abstract autoFocus: bool option with get, set
        abstract arbitrateFocus: FocusArbitrator option with get, set
        abstract importantForLayout: bool option with get, set
        abstract id: string option with get, set
        abstract ariaLabelledBy: string option with get, set
        abstract ariaRoleDescription: string option with get, set
        abstract accessibilityLiveRegion: AccessibilityLiveRegion option with get, set
        abstract animateChildEnter: bool option with get, set
        abstract animateChildLeave: bool option with get, set
        abstract animateChildMove: bool option with get, set
        abstract onAccessibilityTapIOS: Function option with get, set
        abstract onLayout: (ViewOnLayoutEvent -> unit) option with get, set
        abstract onMouseEnter: (MouseEvent -> unit) option with get, set
        abstract onMouseLeave: (MouseEvent -> unit) option with get, set
        abstract onDragEnter: (DragEvent -> unit) option with get, set
        abstract onDragOver: (DragEvent -> unit) option with get, set
        abstract onDragLeave: (DragEvent -> unit) option with get, set
        abstract onDrop: (DragEvent -> unit) option with get, set
        abstract onMouseOver: (MouseEvent -> unit) option with get, set
        abstract onMouseMove: (MouseEvent -> unit) option with get, set
        abstract onPress: (SyntheticEvent -> unit) option with get, set
        abstract onLongPress: (SyntheticEvent -> unit) option with get, set
        abstract onKeyPress: (KeyboardEvent -> unit) option with get, set
        abstract onFocus: (FocusEvent -> unit) option with get, set
        abstract onBlur: (FocusEvent -> unit) option with get, set
        abstract disableTouchOpacityAnimation: bool option with get, set
        abstract activeOpacity: float option with get, set
        abstract underlayColor: string option with get, set
        abstract onContextMenu: (MouseEvent -> unit) option with get, set
        abstract onStartShouldSetResponder: (SyntheticEvent -> bool) option with get, set
        abstract onMoveShouldSetResponder: (SyntheticEvent -> bool) option with get, set
        abstract onStartShouldSetResponderCapture: (SyntheticEvent -> bool) option with get, set
        abstract onMoveShouldSetResponderCapture: (SyntheticEvent -> bool) option with get, set
        abstract onResponderGrant: (SyntheticEvent -> unit) option with get, set
        abstract onResponderReject: (SyntheticEvent -> unit) option with get, set
        abstract onResponderRelease: (SyntheticEvent -> unit) option with get, set
        abstract onResponderStart: (TouchEvent -> unit) option with get, set
        abstract onResponderMove: (TouchEvent -> unit) option with get, set
        abstract onResponderEnd: (TouchEvent -> unit) option with get, set
        abstract onResponderTerminate: (SyntheticEvent -> unit) option with get, set
        abstract onResponderTerminationRequest: (SyntheticEvent -> bool) option with get, set

    type [<AllowNullLiteral>] ViewProps =
        inherit ViewPropsShared
        abstract style: StyleRuleSetRecursive<ViewStyleRuleSet> option with get, set
        abstract useSafeInsets: bool option with get, set

    type [<AllowNullLiteral>] AnimatedViewProps =
        inherit ViewPropsShared
        abstract style: StyleRuleSetRecursive<U2<AnimatedViewStyleRuleSet, ViewStyleRuleSet>> option with get, set

    type [<AllowNullLiteral>] GestureState =
        abstract timeStamp: float with get, set

    type [<AllowNullLiteral>] MultiTouchGestureState =
        inherit GestureState
        abstract initialCenterClientX: float with get, set
        abstract initialCenterClientY: float with get, set
        abstract initialCenterPageX: float with get, set
        abstract initialCenterPageY: float with get, set
        abstract initialWidth: float with get, set
        abstract initialHeight: float with get, set
        abstract initialDistance: float with get, set
        abstract initialAngle: float with get, set
        abstract centerClientX: float with get, set
        abstract centerClientY: float with get, set
        abstract centerPageX: float with get, set
        abstract centerPageY: float with get, set
        abstract velocityX: float with get, set
        abstract velocityY: float with get, set
        abstract width: float with get, set
        abstract height: float with get, set
        abstract distance: float with get, set
        abstract angle: float with get, set
        abstract isComplete: bool with get, set

    type [<AllowNullLiteral>] ScrollWheelGestureState =
        inherit GestureState
        abstract clientX: float with get, set
        abstract clientY: float with get, set
        abstract pageX: float with get, set
        abstract pageY: float with get, set
        abstract scrollAmount: float with get, set

    type [<AllowNullLiteral>] PanGestureState =
        inherit GestureState
        abstract initialClientX: float with get, set
        abstract initialClientY: float with get, set
        abstract initialPageX: float with get, set
        abstract initialPageY: float with get, set
        abstract clientX: float with get, set
        abstract clientY: float with get, set
        abstract pageX: float with get, set
        abstract pageY: float with get, set
        abstract velocityX: float with get, set
        abstract velocityY: float with get, set
        abstract isComplete: bool with get, set

    type [<AllowNullLiteral>] TapGestureState =
        inherit GestureState
        abstract clientX: float with get, set
        abstract clientY: float with get, set
        abstract pageX: float with get, set
        abstract pageY: float with get, set

    type [<RequireQualifiedAccess>] GestureMouseCursor =
        | Default = 0
        | Pointer = 1
        | Grab = 2
        | Move = 3

    type [<RequireQualifiedAccess>] PreferredPanGesture =
        | Horizontal = 0
        | Vertical = 1

    type [<AllowNullLiteral>] GestureViewProps =
        inherit CommonStyledProps<ViewStyleRuleSet>
        inherit CommonAccessibilityProps
        abstract onPinchZoom: (MultiTouchGestureState -> unit) option with get, set
        abstract onRotate: (MultiTouchGestureState -> unit) option with get, set
        abstract onScrollWheel: (ScrollWheelGestureState -> unit) option with get, set
        abstract mouseOverCursor: GestureMouseCursor option with get, set
        abstract onPan: (PanGestureState -> unit) option with get, set
        abstract onPanVertical: (PanGestureState -> unit) option with get, set
        abstract onPanHorizontal: (PanGestureState -> unit) option with get, set
        abstract onTap: (TapGestureState -> unit) option with get, set
        abstract onDoubleTap: (TapGestureState -> unit) option with get, set
        abstract onContextMenu: (TapGestureState -> unit) option with get, set
        abstract preferredPan: PreferredPanGesture option with get, set
        abstract panPixelThreshold: float option with get, set
        abstract releaseOnRequest: bool option with get, set

    type [<AllowNullLiteral>] ScrollIndicatorInsets =
        abstract top: float with get, set
        abstract left: float with get, set
        abstract bottom: float with get, set
        abstract right: float with get, set

    type [<AllowNullLiteral>] ScrollViewProps =
        inherit CommonProps
        inherit CommonAccessibilityProps
        abstract style: StyleRuleSetRecursive<ScrollViewStyleRuleSet> option with get, set
        abstract children: ReactNode option with get, set
        abstract vertical: bool option with get, set
        abstract horizontal: bool option with get, set
        abstract onLayout: (ViewOnLayoutEvent -> unit) option with get, set
        abstract onContentSizeChange: (float -> float -> unit) option with get, set
        abstract onScroll: (float -> float -> unit) option with get, set
        abstract onScrollBeginDrag: (unit -> unit) option with get, set
        abstract onScrollEndDrag: (unit -> unit) option with get, set
        abstract onKeyPress: (KeyboardEvent -> unit) option with get, set
        abstract onFocus: (FocusEvent -> unit) option with get, set
        abstract onBlur: (FocusEvent -> unit) option with get, set
        abstract showsHorizontalScrollIndicator: bool option with get, set
        abstract showsVerticalScrollIndicator: bool option with get, set
        abstract scrollEnabled: bool option with get, set
        abstract keyboardDismissMode: U3<string, string, string> option with get, set
        abstract keyboardShouldPersistTaps: bool option with get, set
        abstract scrollEventThrottle: float option with get, set
        abstract bounces: bool option with get, set
        abstract pagingEnabled: bool option with get, set
        abstract snapToInterval: float option with get, set
        abstract scrollsToTop: bool option with get, set
        abstract overScrollMode: U3<string, string, string> option with get, set
        abstract scrollIndicatorInsets: ScrollIndicatorInsets option with get, set
        abstract tabNavigation: U3<string, string, string> option with get, set

    type [<AllowNullLiteral>] LinkProps =
        inherit CommonStyledProps<LinkStyleRuleSet>
        abstract title: string option with get, set
        abstract url: string with get, set
        abstract children: ReactNode option with get, set
        abstract selectable: bool option with get, set
        abstract numberOfLines: float option with get, set
        abstract allowFontScaling: bool option with get, set
        abstract maxContentSizeMultiplier: float option with get, set
        abstract tabIndex: float option with get, set
        abstract accessibilityId: string option with get, set
        abstract autoFocus: bool option with get, set
        abstract onPress: (RX.Types.SyntheticEvent -> string -> unit) option with get, set
        abstract onLongPress: (RX.Types.SyntheticEvent -> string -> unit) option with get, set
        abstract onHoverStart: (SyntheticEvent -> unit) option with get, set
        abstract onHoverEnd: (SyntheticEvent -> unit) option with get, set
        abstract onContextMenu: (MouseEvent -> unit) option with get, set

    type [<AllowNullLiteral>] TextInputPropsShared =
        inherit CommonProps
        inherit CommonAccessibilityProps
        abstract autoCapitalize: U4<string, string, string, string> option with get, set
        abstract autoCorrect: bool option with get, set
        abstract autoFocus: bool option with get, set
        abstract blurOnSubmit: bool option with get, set
        abstract defaultValue: string option with get, set
        abstract editable: bool option with get, set
        abstract keyboardType: U4<string, string, string, string> option with get, set
        abstract maxLength: float option with get, set
        abstract multiline: bool option with get, set
        abstract placeholder: string option with get, set
        abstract placeholderTextColor: string option with get, set
        abstract secureTextEntry: bool option with get, set
        abstract value: string option with get, set
        abstract title: string option with get, set
        abstract allowFontScaling: bool option with get, set
        abstract maxContentSizeMultiplier: float option with get, set
        abstract keyboardAppearance: U3<string, string, string> option with get, set
        abstract returnKeyType: U5<string, string, string, string, string> option with get, set
        abstract disableFullscreenUI: bool option with get, set
        abstract spellCheck: bool option with get, set
        abstract selectionColor: string option with get, set
        abstract clearButtonMode: U4<string, string, string, string> option with get, set
        abstract onKeyPress: (KeyboardEvent -> unit) option with get, set
        abstract onFocus: (FocusEvent -> unit) option with get, set
        abstract onBlur: (FocusEvent -> unit) option with get, set
        abstract onPaste: (ClipboardEvent -> unit) option with get, set
        abstract onChangeText: (string -> unit) option with get, set
        abstract onSelectionChange: (float -> float -> unit) option with get, set
        abstract onSubmitEditing: (unit -> unit) option with get, set
        abstract onScroll: (float -> float -> unit) option with get, set

    type [<AllowNullLiteral>] TextInputProps =
        inherit TextInputPropsShared
        abstract style: StyleRuleSetRecursive<TextInputStyleRuleSet> option with get, set

    type [<AllowNullLiteral>] AnimatedTextInputProps =
        inherit TextInputPropsShared
        abstract style: StyleRuleSetRecursive<U2<AnimatedTextInputStyleRuleSet, TextInputStyleRuleSet>> option with get, set

    type [<AllowNullLiteral>] ActivityIndicatorProps =
        inherit CommonStyledProps<ActivityIndicatorStyleRuleSet>
        abstract color: string with get, set
        abstract size: U4<string, string, string, string> option with get, set
        abstract deferTime: float option with get, set

    type [<AllowNullLiteral>] WebViewNavigationState =
        inherit Event
        abstract canGoBack: bool with get, set
        abstract canGoForward: bool with get, set
        abstract loading: bool with get, set
        abstract url: string with get, set
        abstract title: string with get, set

    type [<AllowNullLiteral>] WebViewErrorState =
        inherit WebViewNavigationState
        abstract description: string with get, set
        abstract domain: string with get, set
        abstract code: string with get, set

    type [<RequireQualifiedAccess>] WebViewSandboxMode =
        | None = 0
        | AllowForms = 1
        | AllowModals = 2
        | AllowOrientationLock = 4
        | AllowPointerLock = 8
        | AllowPopups = 16
        | AllowPopupsToEscapeSandbox = 32
        | AllowPresentation = 64
        | AllowSameOrigin = 128
        | AllowScripts = 256
        | AllowTopNavigation = 512

    type [<AllowNullLiteral>] WebViewSource =
        abstract html: string with get, set
        abstract baseUrl: string option with get, set

    type [<AllowNullLiteral>] WebViewProps =
        inherit CommonStyledProps<WebViewStyleRuleSet>
        abstract url: string option with get, set
        abstract source: WebViewSource option with get, set
        abstract headers: obj option with get, set
        abstract onLoad: (SyntheticEvent -> unit) option with get, set
        abstract onNavigationStateChange: (WebViewNavigationState -> unit) option with get, set
        abstract scalesPageToFit: bool option with get, set
        abstract injectedJavaScript: string option with get, set
        abstract javaScriptEnabled: bool option with get, set
        abstract startInLoadingState: bool option with get, set
        abstract domStorageEnabled: bool option with get, set
        abstract onShouldStartLoadWithRequest: (WebViewShouldStartLoadEvent -> bool) option with get, set
        abstract onLoadStart: (SyntheticEvent -> unit) option with get, set
        abstract onError: (SyntheticEvent -> unit) option with get, set
        abstract onMessage: (WebViewMessageEvent -> unit) option with get, set
        abstract sandbox: WebViewSandboxMode option with get, set

    type [<StringEnum>] [<RequireQualifiedAccess>] PopupPosition =
        | Top
        | Right
        | Bottom
        | Left

    type [<AllowNullLiteral>] PopupOptions =
        abstract getAnchor: (unit -> React.Component<obj option, obj option>) with get, set
        abstract renderPopup: (PopupPosition -> float -> float -> float -> ReactNode) with get, set
        abstract getElementTriggeringPopup: (unit -> React.Component<obj option, obj option>) option with get, set
        abstract onDismiss: (unit -> unit) option with get, set
        abstract positionPriorities: ResizeArray<PopupPosition> option with get, set
        abstract useInnerPositioning: bool option with get, set
        abstract onAnchorPressed: (RX.Types.SyntheticEvent -> unit) option with get, set
        abstract dismissIfShown: bool option with get, set
        abstract preventDismissOnPress: bool option with get, set
        abstract cacheable: bool option with get, set
        abstract rootViewId: string option with get, set

    type [<AllowNullLiteral>] ModalOptions =
        abstract rootViewId: string option with get, set

    type [<AllowNullLiteral>] AlertButtonSpec =
        abstract text: string option with get, set
        abstract onPress: (unit -> unit) option with get, set
        abstract style: U3<string, string, string> option with get, set

    type [<AllowNullLiteral>] AlertModalTheme =
        abstract bodyStyle: StyleRuleSet<ViewStyle> option with get, set
        abstract titleTextStyle: StyleRuleSet<TextStyle> option with get, set
        abstract messageTextStyle: StyleRuleSet<TextStyle> option with get, set
        abstract buttonStyle: StyleRuleSet<ButtonStyle> option with get, set
        abstract buttonHoverStyle: StyleRuleSet<ButtonStyle> option with get, set
        abstract buttonTextStyle: StyleRuleSet<TextStyle> option with get, set
        abstract cancelButtonStyle: StyleRuleSet<ButtonStyle> option with get, set
        abstract cancelButtonHoverStyle: StyleRuleSet<ButtonStyle> option with get, set
        abstract cancelButtonTextStyle: StyleRuleSet<TextStyle> option with get, set

    type [<AllowNullLiteral>] AlertOptions =
        abstract icon: string option with get, set
        abstract theme: AlertModalTheme option with get, set

    type [<RequireQualifiedAccess>] LocationErrorType =
        | PermissionDenied = 1
        | PositionUnavailable = 2
        | Timeout = 3

    type LocationWatchId =
        float

    type [<AllowNullLiteral>] LocationSuccessCallback =
        [<Emit "$0($1...)">] abstract Invoke: position: Position -> unit

    type [<AllowNullLiteral>] LocationFailureCallback =
        [<Emit "$0($1...)">] abstract Invoke: error: LocationErrorType -> unit

    module Animated =

        type [<AllowNullLiteral>] IExports =
            abstract timing: TimingFunction
            abstract sequence: SequenceFunction
            abstract ``parallel``: ParallelFunction

        type [<AllowNullLiteral>] EndResult =
            abstract finished: bool with get, set

        type [<AllowNullLiteral>] EndCallback =
            [<Emit "$0($1...)">] abstract Invoke: result: EndResult -> unit

        type [<AllowNullLiteral>] CompositeAnimation =
            abstract start: (EndCallback -> unit) with get, set
            abstract stop: (unit -> unit) with get, set

        type [<AllowNullLiteral>] LoopConfig =
            abstract restartFrom: float with get, set

        type [<AllowNullLiteral>] AnimationConfig =
            abstract useNativeDriver: bool option with get, set
            abstract isInteraction: bool option with get, set

        type [<AllowNullLiteral>] TimingAnimationConfig =
            inherit AnimationConfig
            abstract toValue: float with get, set
            abstract easing: EasingFunction option with get, set
            abstract duration: float option with get, set
            abstract delay: float option with get, set
            abstract loop: LoopConfig option with get, set

        type [<AllowNullLiteral>] InterpolationConfigType =
            abstract inputRange: ResizeArray<float> with get, set
            abstract outputRange: ResizeArray<U2<float, string>> with get, set

        type [<AllowNullLiteral>] TimingFunction =
            [<Emit "$0($1...)">] abstract Invoke: value: U2<RX.Types.AnimatedValue, RX.Types.InterpolatedValue> * config: TimingAnimationConfig -> CompositeAnimation

        type [<AllowNullLiteral>] SequenceFunction =
            [<Emit "$0($1...)">] abstract Invoke: animations: Array<CompositeAnimation> -> CompositeAnimation

        type [<AllowNullLiteral>] ParallelFunction =
            [<Emit "$0($1...)">] abstract Invoke: animations: Array<CompositeAnimation> -> CompositeAnimation

        type [<AllowNullLiteral>] EasingFunction =
            abstract cssName: string with get, set
            abstract ``function``: (float -> float) with get, set

        type [<AllowNullLiteral>] Easing =
            abstract Default: unit -> EasingFunction
            abstract Linear: unit -> EasingFunction
            abstract Out: unit -> EasingFunction
            abstract In: unit -> EasingFunction
            abstract InOut: unit -> EasingFunction
            abstract InBack: unit -> EasingFunction
            abstract OutBack: unit -> EasingFunction
            abstract InOutBack: unit -> EasingFunction
            abstract StepStart: unit -> EasingFunction
            abstract StepEnd: unit -> EasingFunction
            abstract Steps: intervals: float * ?``end``: bool -> EasingFunction
            abstract CubicBezier: x1: float * y1: float * x2: float * y2: float -> EasingFunction

    type [<AllowNullLiteral>] SyntheticEvent =
        abstract bubbles: bool
        abstract cancelable: bool
        abstract defaultPrevented: bool
        abstract timeStamp: float
        abstract nativeEvent: obj option
        abstract preventDefault: unit -> unit
        abstract stopPropagation: unit -> unit

    type [<AllowNullLiteral>] ClipboardEvent =
        inherit SyntheticEvent
        abstract clipboardData: DataTransfer with get, set

    type FocusEvent =
        SyntheticEvent

    type [<AllowNullLiteral>] MouseEvent =
        inherit SyntheticEvent
        abstract altKey: bool with get, set
        abstract button: float with get, set
        abstract clientX: float with get, set
        abstract clientY: float with get, set
        abstract ctrlKey: bool with get, set
        abstract metaKey: bool with get, set
        abstract shiftKey: bool with get, set
        abstract pageX: float option with get, set
        abstract pageY: float option with get, set

    type [<AllowNullLiteral>] DragEvent =
        inherit MouseEvent
        abstract dataTransfer: DataTransfer with get, set

    type [<AllowNullLiteral>] Touch =
        abstract identifier: float with get, set
        abstract locationX: float with get, set
        abstract locationY: float with get, set
        abstract screenX: float with get, set
        abstract screenY: float with get, set
        abstract clientX: float with get, set
        abstract clientY: float with get, set
        abstract pageX: float with get, set
        abstract pageY: float with get, set

    type [<AllowNullLiteral>] TouchList =
        [<Emit "$0[$1]{{=$2}}">] abstract Item: index: float -> Touch with get, set
        abstract length: float with get, set
        abstract item: index: float -> Touch
        abstract identifiedTouch: identifier: float -> Touch

    type [<AllowNullLiteral>] TouchEvent =
        inherit SyntheticEvent
        abstract altKey: bool with get, set
        abstract changedTouches: TouchList with get, set
        abstract ctrlKey: bool with get, set
        abstract metaKey: bool with get, set
        abstract shiftKey: bool with get, set
        abstract targetTouches: TouchList with get, set
        abstract locationX: float option with get, set
        abstract locationY: float option with get, set
        abstract pageX: float option with get, set
        abstract pageY: float option with get, set
        abstract touches: TouchList with get, set

    type [<AllowNullLiteral>] WheelEvent =
        inherit SyntheticEvent
        abstract deltaMode: float with get, set
        abstract deltaX: float with get, set
        abstract deltaY: float with get, set
        abstract deltaZ: float with get, set

    type [<AllowNullLiteral>] WebViewShouldStartLoadEvent =
        abstract url: string with get, set

    type [<AllowNullLiteral>] WebViewNavigationEvent =
        inherit SyntheticEvent
        abstract nativeEvent: WebViewNavigationState with get, set

    type [<AllowNullLiteral>] WebViewErrorEvent =
        inherit SyntheticEvent
        abstract nativeEvent: WebViewErrorState with get, set

    type [<AllowNullLiteral>] ViewOnLayoutEvent =
        abstract x: float with get, set
        abstract y: float with get, set
        abstract height: float with get, set
        abstract width: float with get, set

    type [<AllowNullLiteral>] KeyboardEvent =
        inherit SyntheticEvent
        abstract ctrlKey: bool with get, set
        abstract altKey: bool with get, set
        abstract shiftKey: bool with get, set
        abstract keyCode: float with get, set
        abstract metaKey: bool with get, set
        abstract key: string with get, set

    type [<AllowNullLiteral>] WebViewMessageEvent =
        inherit SyntheticEvent
        abstract data: string with get, set
        abstract origin: string with get, set

    type [<AllowNullLiteral>] Dimensions =
        abstract width: float with get, set
        abstract height: float with get, set

    type [<AllowNullLiteral>] EmailInfo =
        abstract ``to``: ResizeArray<string> option with get, set
        abstract cc: ResizeArray<string> option with get, set
        abstract bcc: ResizeArray<string> option with get, set
        abstract subject: string option with get, set
        abstract body: string option with get, set

    type [<AllowNullLiteral>] SmsInfo =
        abstract phoneNumber: string option with get, set
        abstract body: string option with get, set

    type [<RequireQualifiedAccess>] LinkingErrorCode =
        | NoAppFound = 0
        | UnexpectedFailure = 1
        | Blocked = 2
        | InitialUrlNotFound = 3

    type [<AllowNullLiteral>] LinkingErrorInfo =
        abstract code: LinkingErrorCode with get, set
        abstract url: string option with get, set
        abstract description: string option with get, set

    type [<RequireQualifiedAccess>] AppActivationState =
        | Active = 1
        | Background = 2
        | Inactive = 3
        | Extension = 4

    type [<AllowNullLiteral>] LayoutInfo =
        abstract x: float with get, set
        abstract y: float with get, set
        abstract width: float with get, set
        abstract height: float with get, set

    type [<StringEnum>] [<RequireQualifiedAccess>] PlatformType =
        | Web
        | Ios
        | Android
        | Windows
        | Macos

    type [<RequireQualifiedAccess>] DeviceNetworkType =
        | Unknown = 0
        | None = 1
        | Wifi = 2
        | Mobile2G = 3
        | Mobile3G = 4
        | Mobile4G = 5

module __ios_Accessibility =
    let [<Import("","reactxp/ios/Accessibility")>] : ``.IExports`` = jsNative
    type Accessibility as NativeAccessibility = ___native_common_Accessibility.Accessibility as NativeAccessibility
    let [<Import("_default","reactxp")>] _default: Accessibility = jsNative

    type [<AllowNullLiteral>] IExports =
        abstract Accessibility: AccessibilityStatic

    type [<AllowNullLiteral>] Accessibility =
        inherit NativeAccessibility
        abstract _announcementQueue: obj with get, set
        abstract _retryTimestamp: obj with get, set
        abstract _updateScreenReaderStatus: isEnabled: bool -> unit
        abstract announceForAccessibility: announcement: string -> unit
        abstract _postAnnouncement: obj with get, set
        abstract _recalcAnnouncement: obj with get, set

    type [<AllowNullLiteral>] AccessibilityStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> Accessibility

module __ios_AccessibilityUtil =
    let [<Import("","reactxp/ios/AccessibilityUtil")>] : ``.IExports`` = jsNative
    type AccessibilityPlatformUtil = ___common_AccessibilityUtil.AccessibilityPlatformUtil
    let [<Import("_default","reactxp")>] _default: AccessibilityUtil = jsNative

    type [<AllowNullLiteral>] IExports =
        abstract AccessibilityUtil: AccessibilityUtilStatic

    type [<AllowNullLiteral>] AccessibilityUtil =
        inherit AccessibilityPlatformUtil
        abstract setAccessibilityFocus: ``component``: React.Component<obj option, obj option> -> unit

    type [<AllowNullLiteral>] AccessibilityUtilStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> AccessibilityUtil

module __ios_GestureView =
    let [<Import("","reactxp/ios/GestureView")>] : ``.IExports`` = jsNative
    type GestureView as BaseGestureView = ___native_common_GestureView.GestureView as BaseGestureView

    type [<AllowNullLiteral>] IExports =
        abstract GestureView: GestureViewStatic

    type [<AllowNullLiteral>] GestureView =
        inherit BaseGestureView
        abstract _getPreferredPanRatio: unit -> float
        abstract _getEventTimestamp: e: Types.TouchEvent -> float

    type [<AllowNullLiteral>] GestureViewStatic =
        [<Emit "new $0($1...)">] abstract Create: props: Types.GestureViewProps -> GestureView

module __ios_Linking =
    let [<Import("","reactxp/ios/Linking")>] : ``.IExports`` = jsNative
    type Linking as CommonLinking = ___native_common_Linking.Linking as CommonLinking
    let [<Import("_default","reactxp")>] _default: Linking = jsNative

    type [<AllowNullLiteral>] IExports =
        abstract Linking: LinkingStatic

    type [<AllowNullLiteral>] Linking =
        inherit CommonLinking
        abstract _createSmsUrl: smsInfo: Types.SmsInfo -> string

    type [<AllowNullLiteral>] LinkingStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> Linking

module __ios_ReactXP =
    let [<Import("*","reactxp/ios/ReactXP")>] reactXP: ReactXP.IExports = jsNative

    module ReactXP =

        type [<AllowNullLiteral>] IExports =
            abstract Accessibility: RXInterfaces.Accessibility
            abstract ActivityIndicator: obj
            abstract Alert: RXInterfaces.Alert
            abstract App: RXInterfaces.App
            abstract Button: obj
            abstract Picker: obj
            abstract Clipboard: RXInterfaces.Clipboard
            abstract GestureView: obj
            abstract Image: RXInterfaces.ImageConstructor
            abstract Input: RXInterfaces.Input
            abstract International: RXInterfaces.International
            abstract Link: obj
            abstract Linking: RXInterfaces.Linking
            abstract Location: RXInterfaces.Location
            abstract Modal: RXInterfaces.Modal
            abstract Network: RXInterfaces.Network
            abstract Platform: RXInterfaces.Platform
            abstract Popup: RXInterfaces.Popup
            abstract ScrollView: RXInterfaces.ScrollViewConstructor
            abstract StatusBar: RXInterfaces.StatusBar
            abstract Storage: RXInterfaces.Storage
            abstract Styles: RXInterfaces.Styles
            abstract Text: obj
            abstract TextInput: obj
            abstract UserInterface: RXInterfaces.UserInterface
            abstract UserPresence: RXInterfaces.UserPresence
            abstract View: obj
            abstract WebView: RXInterfaces.WebViewConstructor
            abstract Animated: RXInterfaces.Animated
            abstract __spread: obj option

        type Accessibility =
            RXInterfaces.Accessibility

        type ActivityIndicator =
            RXInterfaces.ActivityIndicator

        type Alert =
            RXInterfaces.Alert

        type App =
            RXInterfaces.App

        type Button =
            RXInterfaces.Button

        type Picker =
            RXInterfaces.Picker

        type Clipboard =
            RXInterfaces.Clipboard

        type GestureView =
            RXInterfaces.GestureView

        type Image =
            RXInterfaces.Image

        type Input =
            RXInterfaces.Input

        type International =
            RXInterfaces.International

        type Link =
            RXInterfaces.Link

        type Linking =
            RXInterfaces.Linking

        type Location =
            RXInterfaces.Location

        type Modal =
            RXInterfaces.Modal

        type Network =
            RXInterfaces.Network

        type Platform =
            RXInterfaces.Platform

        type Popup =
            RXInterfaces.Popup

        type ScrollView =
            RXInterfaces.ScrollView

        type StatusBar =
            RXInterfaces.StatusBar

        type Storage =
            RXInterfaces.Storage

        type Styles =
            RXInterfaces.Styles

        type Text =
            RXInterfaces.Text

        type TextInput =
            RXInterfaces.TextInput

        type UserInterface =
            RXInterfaces.UserInterface

        type UserPresence =
            RXInterfaces.UserPresence

        type View =
            RXInterfaces.View

        type WebView =
            RXInterfaces.WebView

module __ios_StatusBar =
    let [<Import("","reactxp/ios/StatusBar")>] : ``.IExports`` = jsNative
    let [<Import("_default","reactxp")>] _default: StatusBar = jsNative

    type [<AllowNullLiteral>] IExports =
        abstract StatusBar: StatusBarStatic

    type [<AllowNullLiteral>] StatusBar =
        inherit RX.StatusBar
        abstract isOverlay: unit -> bool
        abstract setBarStyle: style: U3<string, string, string> * animated: bool -> unit
        abstract setHidden: hidden: bool * showHideTransition: U2<string, string> -> unit
        abstract setNetworkActivityIndicatorVisible: value: bool -> unit
        abstract setBackgroundColor: color: string * animated: bool -> unit
        abstract setTranslucent: translucent: bool -> unit

    type [<AllowNullLiteral>] StatusBarStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> StatusBar

module __macos_Accessibility =
    let [<Import("","reactxp/macos/Accessibility")>] : ``.IExports`` = jsNative
    type Accessibility as NativeAccessibility = ___native_common_Accessibility.Accessibility as NativeAccessibility
    let [<Import("_default","reactxp")>] _default: Accessibility = jsNative

    type [<AllowNullLiteral>] IExports =
        abstract Accessibility: AccessibilityStatic

    type [<AllowNullLiteral>] Accessibility =
        inherit NativeAccessibility
        abstract _announcementQueue: obj with get, set
        abstract _retryTimestamp: obj with get, set
        abstract _updateScreenReaderStatus: isEnabled: bool -> unit
        abstract announceForAccessibility: announcement: string -> unit
        abstract _postAnnouncement: obj with get, set
        abstract _recalcAnnouncement: obj with get, set

    type [<AllowNullLiteral>] AccessibilityStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> Accessibility

module __macos_AccessibilityUtil =
    let [<Import("","reactxp/macos/AccessibilityUtil")>] : ``.IExports`` = jsNative
    type AccessibilityPlatformUtil = ___common_AccessibilityUtil.AccessibilityPlatformUtil
    let [<Import("_default","reactxp")>] _default: AccessibilityUtil = jsNative

    type [<AllowNullLiteral>] IExports =
        abstract AccessibilityUtil: AccessibilityUtilStatic

    type [<AllowNullLiteral>] AccessibilityUtil =
        inherit AccessibilityPlatformUtil
        abstract setAccessibilityFocus: ``component``: React.Component<obj option, obj option> -> unit

    type [<AllowNullLiteral>] AccessibilityUtilStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> AccessibilityUtil

module __macos_GestureView =
    let [<Import("","reactxp/macos/GestureView")>] : ``.IExports`` = jsNative
    type GestureView as BaseGestureView = ___native_common_GestureView.GestureView as BaseGestureView

    type [<AllowNullLiteral>] IExports =
        abstract GestureView: GestureViewStatic

    type [<AllowNullLiteral>] GestureView =
        inherit BaseGestureView
        abstract _getPreferredPanRatio: unit -> float
        abstract _getEventTimestamp: e: Types.TouchEvent -> float

    type [<AllowNullLiteral>] GestureViewStatic =
        [<Emit "new $0($1...)">] abstract Create: props: Types.GestureViewProps -> GestureView

module __macos_Input =
    let [<Import("","reactxp/macos/Input")>] : ``.IExports`` = jsNative
    let [<Import("_default","reactxp")>] _default: Input = jsNative

    type [<AllowNullLiteral>] IExports =
        abstract Input: InputStatic

    type [<AllowNullLiteral>] Input =
        inherit RX.Input

    type [<AllowNullLiteral>] InputStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> Input

module __macos_Linking =
    let [<Import("","reactxp/macos/Linking")>] : ``.IExports`` = jsNative
    type Linking as CommonLinking = ___native_common_Linking.Linking as CommonLinking
    let [<Import("_default","reactxp")>] _default: Linking = jsNative

    type [<AllowNullLiteral>] IExports =
        abstract Linking: LinkingStatic

    type [<AllowNullLiteral>] Linking =
        inherit CommonLinking
        abstract _createSmsUrl: smsInfo: Types.SmsInfo -> string

    type [<AllowNullLiteral>] LinkingStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> Linking

module __macos_ReactXP =
    let [<Import("*","reactxp/macos/ReactXP")>] reactXP: ReactXP.IExports = jsNative

    module ReactXP =

        type [<AllowNullLiteral>] IExports =
            abstract Accessibility: RXInterfaces.Accessibility
            abstract ActivityIndicator: obj
            abstract Alert: RXInterfaces.Alert
            abstract App: RXInterfaces.App
            abstract Button: obj
            abstract Picker: obj
            abstract Clipboard: RXInterfaces.Clipboard
            abstract GestureView: obj
            abstract Image: RXInterfaces.ImageConstructor
            abstract Input: RXInterfaces.Input
            abstract International: RXInterfaces.International
            abstract Link: obj
            abstract Linking: RXInterfaces.Linking
            abstract Location: RXInterfaces.Location
            abstract Modal: RXInterfaces.Modal
            abstract Network: RXInterfaces.Network
            abstract Platform: RXInterfaces.Platform
            abstract Popup: RXInterfaces.Popup
            abstract ScrollView: RXInterfaces.ScrollViewConstructor
            abstract StatusBar: RXInterfaces.StatusBar
            abstract Storage: RXInterfaces.Storage
            abstract Styles: RXInterfaces.Styles
            abstract Text: obj
            abstract TextInput: obj
            abstract UserInterface: RXInterfaces.UserInterface
            abstract UserPresence: RXInterfaces.UserPresence
            abstract View: obj
            abstract WebView: RXInterfaces.WebViewConstructor
            abstract Animated: RXInterfaces.Animated
            abstract __spread: obj option

        type Accessibility =
            RXInterfaces.Accessibility

        type ActivityIndicator =
            RXInterfaces.ActivityIndicator

        type Alert =
            RXInterfaces.Alert

        type App =
            RXInterfaces.App

        type Button =
            RXInterfaces.Button

        type Picker =
            RXInterfaces.Picker

        type Clipboard =
            RXInterfaces.Clipboard

        type GestureView =
            RXInterfaces.GestureView

        type Image =
            RXInterfaces.Image

        type Input =
            RXInterfaces.Input

        type International =
            RXInterfaces.International

        type Link =
            RXInterfaces.Link

        type Linking =
            RXInterfaces.Linking

        type Location =
            RXInterfaces.Location

        type Modal =
            RXInterfaces.Modal

        type Network =
            RXInterfaces.Network

        type Platform =
            RXInterfaces.Platform

        type Popup =
            RXInterfaces.Popup

        type ScrollView =
            RXInterfaces.ScrollView

        type StatusBar =
            RXInterfaces.StatusBar

        type Storage =
            RXInterfaces.Storage

        type Styles =
            RXInterfaces.Styles

        type Text =
            RXInterfaces.Text

        type TextInput =
            RXInterfaces.TextInput

        type UserInterface =
            RXInterfaces.UserInterface

        type UserPresence =
            RXInterfaces.UserPresence

        type View =
            RXInterfaces.View

        type WebView =
            RXInterfaces.WebView

module __macos_StatusBar =
    let [<Import("","reactxp/macos/StatusBar")>] : ``.IExports`` = jsNative
    let [<Import("_default","reactxp")>] _default: StatusBar = jsNative

    type [<AllowNullLiteral>] IExports =
        abstract StatusBar: StatusBarStatic

    type [<AllowNullLiteral>] StatusBar =
        inherit RX.StatusBar
        abstract isOverlay: unit -> bool
        abstract setHidden: hidden: bool * showHideTransition: U2<string, string> -> unit
        abstract setBackgroundColor: color: string * animated: bool -> unit
        abstract setTranslucent: translucent: bool -> unit
        abstract setBarStyle: style: U3<string, string, string> * animated: bool -> unit
        abstract setNetworkActivityIndicatorVisible: value: bool -> unit

    type [<AllowNullLiteral>] StatusBarStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> StatusBar

module __macos_TextInput =
    let [<Import("","reactxp/macos/TextInput")>] : ``.IExports`` = jsNative
    type FocusArbitratorProvider = ___common_utils_AutoFocusHelper.FocusArbitratorProvider

    type [<AllowNullLiteral>] IExports =
        abstract TextInput: TextInputStatic

    type [<AllowNullLiteral>] TextInputState =
        abstract inputValue: string with get, set
        abstract isFocused: bool with get, set

    type [<AllowNullLiteral>] TextInputContext =
        abstract focusArbitrator: FocusArbitratorProvider option with get, set

    type [<AllowNullLiteral>] TextInput =
        inherit React.Component<Types.TextInputProps, TextInputState>
        abstract contextTypes: React.ValidationMap<obj option> with get, set
        abstract context: TextInputContext with get, set
        abstract _selectionStart: obj with get, set
        abstract _selectionEnd: obj with get, set
        abstract _mountedComponent: obj with get, set
        abstract componentDidMount: unit -> unit
        abstract componentWillReceiveProps: nextProps: Types.TextInputProps -> unit
        abstract render: unit -> JSX.Element
        abstract _onMount: (obj option -> unit) with get, set
        abstract _onPaste: obj with get, set
        abstract _onFocus: obj with get, set
        abstract _onBlur: obj with get, set
        abstract _onChangeText: obj with get, set
        abstract _onSelectionChange: obj with get, set
        abstract _onKeyPress: obj with get, set
        abstract _onScroll: obj with get, set
        abstract blur: unit -> unit
        abstract requestFocus: unit -> unit
        abstract focus: unit -> unit
        abstract setAccessibilityFocus: unit -> unit
        abstract isFocused: unit -> bool
        abstract selectAll: unit -> unit
        abstract selectRange: start: float * ``end``: float -> unit
        abstract getSelectionRange: unit -> obj
        abstract setValue: value: string -> unit

    type [<AllowNullLiteral>] TextInputStatic =
        [<Emit "new $0($1...)">] abstract Create: props: Types.TextInputProps * context: TextInputContext -> TextInput

module __macos_View =
    let [<Import("","reactxp/macos/View")>] : ``.IExports`` = jsNative
    type View as ViewCommon = ___native_common_View.View as ViewCommon

    type [<AllowNullLiteral>] IExports =
        abstract View: ViewStatic

    type [<AllowNullLiteral>] View =
        inherit ViewCommon
        abstract _buildInternalProps: props: Types.ViewProps -> unit

    type [<AllowNullLiteral>] ViewStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> View

module __native_common_Accessibility =
    let [<Import("","reactxp/native-common/Accessibility")>] : ``.IExports`` = jsNative
    type Accessibility as CommonAccessibility = ___common_Accessibility.Accessibility as CommonAccessibility
    let [<Import("_default","reactxp")>] _default: Accessibility = jsNative

    type [<AllowNullLiteral>] IExports =
        abstract Accessibility: AccessibilityStatic

    type [<AllowNullLiteral>] Accessibility =
        inherit CommonAccessibility
        abstract _isScreenReaderEnabled: bool with get, set
        abstract _updateScreenReaderStatus: isEnabled: bool -> unit
        abstract isScreenReaderEnabled: unit -> bool

    type [<AllowNullLiteral>] AccessibilityStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> Accessibility

module __native_common_AccessibilityUtil =
    let [<Import("","reactxp/native-common/AccessibilityUtil")>] : ``.IExports`` = jsNative
    type AccessibilityUtil as CommonAccessibilityUtil = ___common_AccessibilityUtil.AccessibilityUtil as CommonAccessibilityUtil
    type AccessibilityPlatformUtil = ___common_AccessibilityUtil.AccessibilityPlatformUtil
    let [<Import("_default","reactxp")>] _default: AccessibilityUtil = jsNative

    type [<AllowNullLiteral>] IExports =
        abstract AccessibilityUtil: AccessibilityUtilStatic

    type [<StringEnum>] [<RequireQualifiedAccess>] AccessibilityLiveRegionValue =
        | None
        | Polite
        | Assertive

    type [<StringEnum>] [<RequireQualifiedAccess>] AccessibilityComponentTypeValue =
        | None
        | Button
        | Radiobutton_checked
        | Radiobutton_unchecked

    type [<AllowNullLiteral>] AccessibilityUtil =
        inherit CommonAccessibilityUtil
        abstract _instance: obj with get, set
        abstract setAccessibilityPlatformUtil: instance: AccessibilityPlatformUtil -> unit
        abstract accessibilityTraitToString: overrideTraits: U2<Types.AccessibilityTrait, ResizeArray<Types.AccessibilityTrait>> option * ?defaultTrait: Types.AccessibilityTrait * ?ensureDefaultTrait: bool -> ResizeArray<RN.AccessibilityTraits>
        abstract accessibilityComponentTypeToString: overrideTraits: U2<Types.AccessibilityTrait, ResizeArray<Types.AccessibilityTrait>> option * ?defaultTrait: Types.AccessibilityTrait -> AccessibilityComponentTypeValue option
        abstract accessibilityLiveRegionToString: liveRegion: Types.AccessibilityLiveRegion option -> AccessibilityLiveRegionValue option
        abstract setAccessibilityFocus: ``component``: React.Component<obj option, obj option> -> unit

    type [<AllowNullLiteral>] AccessibilityUtilStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> AccessibilityUtil

module __native_common_ActivityIndicator =
    let [<Import("","reactxp/native-common/ActivityIndicator")>] : ``.IExports`` = jsNative

    type [<AllowNullLiteral>] IExports =
        abstract ActivityIndicator: ActivityIndicatorStatic

    type [<AllowNullLiteral>] ActivityIndicatorState =
        abstract isVisible: bool option with get, set

    type [<AllowNullLiteral>] ActivityIndicator =
        inherit React.Component<Types.ActivityIndicatorProps, ActivityIndicatorState>
        abstract _isMounted: obj with get, set
        abstract componentDidMount: unit -> unit
        abstract componentWillUnmount: unit -> unit
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] ActivityIndicatorStatic =
        [<Emit "new $0($1...)">] abstract Create: props: Types.ActivityIndicatorProps -> ActivityIndicator

module __native_common_Alert =
    let [<Import("","reactxp/native-common/Alert")>] : ``.IExports`` = jsNative
    let [<Import("_default","reactxp")>] _default: Alert = jsNative

    type [<AllowNullLiteral>] IExports =
        abstract Alert: AlertStatic

    type [<AllowNullLiteral>] Alert =
        inherit RX.Alert
        abstract show: title: string * ?message: string * ?buttons: ResizeArray<Types.AlertButtonSpec> * ?options: RX.Types.AlertOptions -> unit

    type [<AllowNullLiteral>] AlertStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> Alert

module __native_common_Animated =
    let [<Import("","reactxp/native-common/Animated")>] : ``.IExports`` = jsNative
    let [<Import("CommonAnimatedClasses","reactxp")>] CommonAnimatedClasses: AnimatedClasses = jsNative
    let [<Import("AnimatedCommon","reactxp")>] AnimatedCommon: obj = jsNative

    type [<AllowNullLiteral>] IExports =
        abstract makeAnimated: nativeAnimatedClasses: AnimatedClasses * ?useFocusRestrictedView: bool -> RX.Animated

    type [<AllowNullLiteral>] AnimatedClasses =
        abstract Image: obj with get, set
        abstract Text: obj with get, set
        abstract TextInput: obj with get, set
        abstract View: obj with get, set

module __native_common_App =
    let [<Import("","reactxp/native-common/App")>] : ``.IExports`` = jsNative
    let [<Import("_default","reactxp")>] _default: App = jsNative

    type [<AllowNullLiteral>] IExports =
        abstract App: AppStatic

    type [<AllowNullLiteral>] App =
        inherit RX.App
        abstract initialize: debug: bool * development: bool -> unit
        abstract getActivationState: unit -> Types.AppActivationState
        abstract getRootViewFactory: unit -> RN.ComponentProvider
        abstract getRootViewUsingPropsFactory: unit -> RN.ComponentProvider

    type [<AllowNullLiteral>] AppStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> App

module __native_common_Button =
    let [<Import("","reactxp/native-common/Button")>] : ``.IExports`` = jsNative
    type FocusArbitratorProvider = ___common_utils_AutoFocusHelper.FocusArbitratorProvider
    type Button as ButtonBase = ___common_Interfaces.Button as ButtonBase

    type [<AllowNullLiteral>] IExports =
        abstract Button: ButtonStatic

    type [<AllowNullLiteral>] ButtonContext =
        abstract hasRxButtonAscendant: bool option with get, set
        abstract focusArbitrator: FocusArbitratorProvider option with get, set

    type [<AllowNullLiteral>] Button =
        inherit ButtonBase
        abstract contextTypes: obj with get, set
        abstract context: ButtonContext with get, set
        abstract childContextTypes: React.ValidationMap<obj option> with get, set
        abstract _mixin_componentDidMount: obj with get, set
        abstract _mixin_componentWillUnmount: obj with get, set
        abstract touchableGetInitialState: (unit -> RN.Touchable.State) with get, set
        abstract touchableHandleStartShouldSetResponder: (unit -> bool) with get, set
        abstract touchableHandleResponderTerminationRequest: (unit -> bool) with get, set
        abstract touchableHandleResponderGrant: (RN.GestureResponderEvent -> unit) with get, set
        abstract touchableHandleResponderMove: (RN.GestureResponderEvent -> unit) with get, set
        abstract touchableHandleResponderRelease: (RN.GestureResponderEvent -> unit) with get, set
        abstract touchableHandleResponderTerminate: (RN.GestureResponderEvent -> unit) with get, set
        abstract _isMounted: bool with get, set
        abstract _isMouseOver: bool with get, set
        abstract _isHoverStarted: bool with get, set
        abstract _buttonElement: obj option with get, set
        abstract _hideTimeout: obj with get, set
        abstract _defaultOpacityValue: obj with get, set
        abstract _opacityAnimatedValue: obj with get, set
        abstract _opacityAnimatedStyle: obj with get, set
        abstract _render: internalProps: RN.ViewProps * onMount: (obj option -> unit) -> JSX.Element
        abstract render: unit -> JSX.Element
        abstract componentDidMount: unit -> unit
        abstract componentWillUnmount: unit -> unit
        abstract componentWillReceiveProps: nextProps: Types.ButtonProps -> unit
        abstract getChildContext: unit -> ButtonContext
        abstract setNativeProps: nativeProps: RN.ViewProps -> unit
        abstract touchableHandleActivePressIn: (Types.SyntheticEvent -> unit) with get, set
        abstract touchableHandleActivePressOut: (Types.SyntheticEvent -> unit) with get, set
        abstract touchableHandlePress: (Types.SyntheticEvent -> unit) with get, set
        abstract touchableHandleLongPress: (Types.SyntheticEvent -> unit) with get, set
        abstract touchableGetHighlightDelayMS: (unit -> float) with get, set
        abstract touchableGetPressRectOffset: (unit -> obj) with get, set
        abstract requestFocus: unit -> unit
        abstract blur: unit -> unit
        abstract focus: unit -> unit
        abstract _setOpacityStyles: obj with get, set
        abstract _onMount: obj with get, set
        abstract _isTouchFeedbackApplicable: obj with get, set
        abstract _opacityActive: obj with get, set
        abstract _opacityInactive: obj with get, set
        abstract _getDefaultOpacityValue: obj with get, set
        abstract _onMouseEnter: (Types.SyntheticEvent -> unit) with get, set
        abstract _onMouseLeave: (Types.SyntheticEvent -> unit) with get, set
        abstract _onHoverStart: (Types.SyntheticEvent -> unit) with get, set
        abstract _onHoverEnd: (Types.SyntheticEvent -> unit) with get, set
        /// Animate the touchable to a new opacity.
        abstract setOpacityTo: value: float * duration: float -> unit
        abstract _hasPressHandler: obj with get, set
        abstract _showUnderlay: obj with get, set
        abstract _hideUnderlay: obj with get, set

    type [<AllowNullLiteral>] ButtonStatic =
        [<Emit "new $0($1...)">] abstract Create: props: Types.ButtonProps * context: ButtonContext -> Button

module __native_common_Clipboard =
    let [<Import("","reactxp/native-common/Clipboard")>] : ``.IExports`` = jsNative
    let [<Import("_default","reactxp")>] _default: Clipboard = jsNative

    type [<AllowNullLiteral>] IExports =
        abstract Clipboard: ClipboardStatic

    type [<AllowNullLiteral>] Clipboard =
        inherit RX.Clipboard
        abstract setText: text: string -> unit
        abstract getText: unit -> SyncTasks.Promise<string>

    type [<AllowNullLiteral>] ClipboardStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> Clipboard

module __native_common_FrontLayerViewManager =
    let [<Import("","reactxp/native-common/FrontLayerViewManager")>] : ``.IExports`` = jsNative
    let [<Import("_default","reactxp")>] _default: FrontLayerViewManager = jsNative

    type [<AllowNullLiteral>] IExports =
        abstract FrontLayerViewManager: FrontLayerViewManagerStatic

    type [<AllowNullLiteral>] FrontLayerViewManager =
        abstract _overlayStack: obj with get, set
        abstract _cachedPopups: obj with get, set
        abstract event_changed: SubscribableEvent<(unit -> unit)> with get, set
        abstract showModal: modal: React.ReactElement<Types.ViewProps> * modalId: string * ?options: Types.ModalOptions -> unit
        abstract isModalDisplayed: ?modalId: string -> bool
        abstract dismissModal: modalId: string -> unit
        abstract dismissAllmodals: unit -> unit
        abstract showPopup: popupOptions: Types.PopupOptions * popupId: string * ?delay: float -> bool
        abstract dismissPopup: popupId: string -> unit
        abstract dismissAllPopups: unit -> unit
        abstract getModalLayerView: ?rootViewId: string option -> React.ReactElement<obj option> option
        abstract getActivePopupId: unit -> string option
        abstract releaseCachedPopups: unit -> unit
        abstract modalOptionsMatchesRootViewId: obj with get, set
        abstract _renderPopup: obj with get, set
        abstract getPopupLayerView: ?rootViewId: string option -> JSX.Element option
        abstract _onBackgroundPressed: obj with get, set
        abstract _dismissActivePopup: obj with get, set
        abstract _findIndexOfModal: obj with get, set
        abstract _findIndexOfPopup: obj with get, set
        abstract _getActiveOverlay: obj with get, set
        abstract isPopupDisplayed: ?popupId: string -> bool

    type [<AllowNullLiteral>] FrontLayerViewManagerStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> FrontLayerViewManager

module __native_common_GestureView =
    let [<Import("","reactxp/native-common/GestureView")>] : ``.IExports`` = jsNative

    type [<AllowNullLiteral>] IExports =
        abstract GestureView: GestureViewStatic

    type [<AllowNullLiteral>] GestureView =
        inherit React.Component<Types.GestureViewProps, Types.Stateless>
        abstract _panResponder: obj with get, set
        abstract _doubleTapTimer: obj with get, set
        abstract _pendingGestureType: obj with get, set
        abstract _pendingGestureState: obj with get, set
        abstract _lastTapEvent: obj with get, set
        abstract _lastGestureStartEvent: obj with get, set
        abstract componentWillUnmount: unit -> unit
        abstract _getPreferredPanRatio: unit -> float
        abstract _getEventTimestamp: e: Types.TouchEvent -> float
        abstract _onPanResponderEnd: obj with get, set
        abstract _setPendingGestureState: obj with get, set
        abstract _detectMoveGesture: obj with get, set
        abstract _isTap: obj with get, set
        abstract _isDoubleTap: obj with get, set
        abstract _startDoubleTapTimer: obj with get, set
        abstract _cancelDoubleTapTimer: obj with get, set
        abstract _reportDelayedTap: obj with get, set
        abstract _shouldRespondToPinchZoom: obj with get, set
        abstract _shouldRespondToRotate: obj with get, set
        abstract _shouldRespondToPan: obj with get, set
        abstract _shouldRespondToPanVertical: obj with get, set
        abstract _shouldRespondToPanHorizontal: obj with get, set
        abstract _calcDistance: obj with get, set
        abstract _calcAngle: obj with get, set
        abstract _radiansToDegrees: obj with get, set
        abstract _sendMultiTouchEvents: obj with get, set
        abstract _sendPanEvent: obj with get, set
        abstract _sendTapEvent: obj with get, set
        abstract _sendDoubleTapEvent: obj with get, set
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] GestureViewStatic =
        [<Emit "new $0($1...)">] abstract Create: props: Types.GestureViewProps -> GestureView

module __native_common_Image =
    let [<Import("","reactxp/native-common/Image")>] : ``.IExports`` = jsNative

    type [<AllowNullLiteral>] IExports =
        abstract Image: ImageStatic

    type [<AllowNullLiteral>] ImageContext =
        abstract isRxParentAText: bool option with get, set

    type [<AllowNullLiteral>] Image =
        inherit React.Component<Types.ImageProps, Types.Stateless>
        inherit React.ChildContextProvider<ImageContext>
        abstract childContextTypes: React.ValidationMap<obj option> with get, set
        abstract _mountedComponent: RN.ReactNativeBaseComponent<obj option, obj option> option with get, set
        abstract _nativeImageWidth: obj with get, set
        abstract _nativeImageHeight: obj with get, set
        abstract _getAdditionalProps: unit -> U2<RN.ImageProperties, obj>
        abstract render: unit -> JSX.Element
        abstract _onMount: (RN.ReactNativeBaseComponent<obj option, obj option> option -> unit) with get, set
        abstract setNativeProps: nativeProps: RN.ImageProperties -> unit
        abstract getChildContext: unit -> obj
        abstract getStyles: unit -> ResizeArray<Types.StyleRuleSetRecursive<Types.StyleRuleSet<Types.ImageStyle>>>
        abstract _onLoad: obj with get, set
        abstract _onError: obj with get, set
        abstract _buildSource: obj with get, set
        abstract getNativeWidth: unit -> float option
        abstract getNativeHeight: unit -> float option

    type [<AllowNullLiteral>] ImageStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> Image
        abstract prefetch: url: string -> SyncTasks.Promise<bool>
        abstract getMetadata: url: string -> SyncTasks.Promise<Types.ImageMetadata>

module __native_common_Input =
    let [<Import("","reactxp/native-common/Input")>] : ``.IExports`` = jsNative
    let [<Import("_default","reactxp")>] _default: Input = jsNative

    type [<AllowNullLiteral>] IExports =
        abstract Input: InputStatic

    type [<AllowNullLiteral>] Input =
        inherit RX.Input

    type [<AllowNullLiteral>] InputStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> Input

module __native_common_International =
    let [<Import("","reactxp/native-common/International")>] : ``.IExports`` = jsNative
    let [<Import("_default","reactxp")>] _default: International = jsNative

    type [<AllowNullLiteral>] IExports =
        abstract International: InternationalStatic

    type [<AllowNullLiteral>] International =
        inherit RXInterfaces.International
        abstract allowRTL: allow: bool -> unit
        abstract forceRTL: force: bool -> unit
        abstract isRTL: unit -> bool

    type [<AllowNullLiteral>] InternationalStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> International

module __native_common_Link =
    let [<Import("","reactxp/native-common/Link")>] : ``.IExports`` = jsNative
    type FocusArbitratorProvider = ___common_utils_AutoFocusHelper.FocusArbitratorProvider

    type [<AllowNullLiteral>] IExports =
        abstract LinkBase: LinkBaseStatic
        abstract Link: LinkStatic

    type [<AllowNullLiteral>] LinkContext =
        abstract focusArbitrator: FocusArbitratorProvider option with get, set
        abstract isRxParentAText: bool option with get, set

    type [<AllowNullLiteral>] LinkBase<'S> =
        inherit React.Component<Types.LinkProps, 'S>
        abstract contextTypes: obj with get, set
        abstract context: LinkContext with get, set
        abstract _mountedComponent: RN.ReactNativeBaseComponent<obj option, obj option> option with get, set
        abstract _isMounted: bool with get, set
        abstract setNativeProps: nativeProps: RN.TextProps -> unit
        abstract render: unit -> JSX.Element
        abstract componentDidMount: unit -> unit
        abstract componentWillUnmount: unit -> unit
        abstract _render: internalProps: RN.TextProps * onMount: (obj option -> unit) -> JSX.Element
        abstract _onMount: (obj option -> unit) with get, set
        abstract _onPress: (RX.Types.SyntheticEvent -> unit) with get, set
        abstract _onLongPress: (RX.Types.SyntheticEvent -> unit) with get, set
        abstract requestFocus: unit -> unit
        abstract focus: unit -> unit
        abstract blur: unit -> unit

    type [<AllowNullLiteral>] LinkBaseStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> LinkBase<'S>

    type [<AllowNullLiteral>] Link =
        inherit LinkBase<obj>

    type [<AllowNullLiteral>] LinkStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> Link

module __native_common_Linking =
    let [<Import("","reactxp/native-common/Linking")>] : ``.IExports`` = jsNative
    type Linking as CommonLinking = ___common_Linking.Linking as CommonLinking
    let [<Import("_default","reactxp")>] _default: Linking = jsNative

    type [<AllowNullLiteral>] IExports =
        abstract Linking: LinkingStatic

    type [<AllowNullLiteral>] Linking =
        inherit CommonLinking
        abstract _openUrl: url: string -> SyncTasks.Promise<unit>
        abstract getInitialUrl: unit -> SyncTasks.Promise<string option>
        abstract launchEmail: emailInfo: Types.EmailInfo -> SyncTasks.Promise<unit>

    type [<AllowNullLiteral>] LinkingStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> Linking

module __native_common_MainViewStore =
    let [<Import("","reactxp/native-common/MainViewStore")>] : ``.IExports`` = jsNative
    let [<Import("_default","reactxp")>] _default: MainViewStore = jsNative

    type [<AllowNullLiteral>] IExports =
        abstract MainViewStore: MainViewStoreStatic

    type [<AllowNullLiteral>] MainViewStore =
        inherit SubscribableEvent<(unit -> unit)>
        abstract _mainView: obj with get, set
        abstract getMainView: unit -> React.ReactElement<obj option> option
        abstract setMainView: view: React.ReactElement<obj option> -> unit

    type [<AllowNullLiteral>] MainViewStoreStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> MainViewStore

module __native_common_Modal =
    let [<Import("","reactxp/native-common/Modal")>] : ``.IExports`` = jsNative
    let [<Import("_default","reactxp")>] _default: Modal = jsNative

    type [<AllowNullLiteral>] IExports =
        abstract Modal: ModalStatic

    type [<AllowNullLiteral>] Modal =
        inherit RX.Modal
        abstract isDisplayed: ?modalId: string -> bool
        abstract show: modal: React.ReactElement<Types.ViewProps> * modalId: string * ?options: Types.ModalOptions -> unit
        abstract dismiss: modalId: string -> unit
        abstract dismissAll: unit -> unit

    type [<AllowNullLiteral>] ModalStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> Modal

module __native_common_ModalContainer =
    let [<Import("","reactxp/native-common/ModalContainer")>] : ``.IExports`` = jsNative

    type [<AllowNullLiteral>] IExports =
        abstract ModalContainer: ModalContainerStatic

    type [<AllowNullLiteral>] ModalContainerProps =
        inherit Types.CommonProps
        abstract hidden: bool option with get, set

    type [<AllowNullLiteral>] ModalContainer =
        inherit React.Component<ModalContainerProps, Types.Stateless>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] ModalContainerStatic =
        [<Emit "new $0($1...)">] abstract Create: props: ModalContainerProps -> ModalContainer

module __native_common_Network =
    let [<Import("","reactxp/native-common/Network")>] : ``.IExports`` = jsNative
    let [<Import("_default","reactxp")>] _default: Network = jsNative

    type [<AllowNullLiteral>] IExports =
        abstract Network: NetworkStatic

    type [<AllowNullLiteral>] Network =
        inherit RX.Network
        abstract isConnected: unit -> SyncTasks.Promise<bool>
        abstract getType: unit -> SyncTasks.Promise<Types.DeviceNetworkType>
        abstract _onEventOccured: obj with get, set
        abstract _getNetworkTypeFromNetInfo: obj with get, set
        abstract _getNetworkTypeFromConnectionInfo: obj with get, set

    type [<AllowNullLiteral>] NetworkStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> Network

module __native_common_Picker =
    let [<Import("","reactxp/native-common/Picker")>] : ``.IExports`` = jsNative

    type [<AllowNullLiteral>] IExports =
        abstract Picker: PickerStatic

    type [<AllowNullLiteral>] Picker =
        inherit RX.Picker
        abstract render: unit -> JSX.Element
        abstract onValueChange: (obj option -> float -> unit) with get, set

    type [<AllowNullLiteral>] PickerStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> Picker

module __native_common_Platform =
    let [<Import("","reactxp/native-common/Platform")>] : ``.IExports`` = jsNative
    let [<Import("_default","reactxp")>] _default: Platform = jsNative

    type [<AllowNullLiteral>] IExports =
        abstract Platform: PlatformStatic

    type [<AllowNullLiteral>] Platform =
        inherit RX.Platform
        abstract getType: unit -> Types.PlatformType
        abstract select: specifics: obj -> 'T option

    type [<AllowNullLiteral>] PlatformStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> Platform

module __native_common_Popup =
    let [<Import("","reactxp/native-common/Popup")>] : ``.IExports`` = jsNative
    let [<Import("_default","reactxp")>] _default: Popup = jsNative

    type [<AllowNullLiteral>] IExports =
        abstract Popup: PopupStatic

    type [<AllowNullLiteral>] Popup =
        inherit RX.Popup
        abstract show: options: Types.PopupOptions * popupId: string * ?delay: float -> bool
        abstract autoDismiss: popupId: string * ?delay: float -> unit
        abstract dismiss: popupId: string -> unit
        abstract dismissAll: unit -> unit
        abstract isDisplayed: ?popupId: string -> bool

    type [<AllowNullLiteral>] PopupStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> Popup

module __native_common_PopupContainerView =
    let [<Import("","reactxp/native-common/PopupContainerView")>] : ``.IExports`` = jsNative
    type PopupContainerViewBase = ___common_PopupContainerViewBase.PopupContainerViewBase
    type PopupContainerViewBaseProps = ___common_PopupContainerViewBase.PopupContainerViewBaseProps
    type PopupContainerViewContext = ___common_PopupContainerViewBase.PopupContainerViewContext

    type [<AllowNullLiteral>] IExports =
        abstract PopupContainerView: PopupContainerViewStatic

    type [<AllowNullLiteral>] PopupContainerViewProps =
        inherit PopupContainerViewBaseProps
        abstract popupOptions: Types.PopupOptions with get, set
        abstract anchorHandle: float option with get, set
        abstract onDismissPopup: (unit -> unit) option with get, set

    type [<AllowNullLiteral>] PopupContainerViewState =
        abstract isMeasuringPopup: bool with get, set
        abstract popupWidth: float with get, set
        abstract popupHeight: float with get, set
        abstract anchorPosition: Types.PopupPosition with get, set
        abstract anchorOffset: float with get, set
        abstract popupY: float with get, set
        abstract popupX: float with get, set
        abstract constrainedPopupWidth: float with get, set
        abstract constrainedPopupHeight: float with get, set

    type [<AllowNullLiteral>] PopupContainerView =
        inherit PopupContainerViewBase<PopupContainerViewProps, PopupContainerViewState>
        abstract _mountedComponent: obj with get, set
        abstract _viewHandle: obj with get, set
        abstract _respositionPopupTimer: obj with get, set
        abstract _getInitialState: obj with get, set
        abstract componentWillReceiveProps: prevProps: PopupContainerViewProps -> unit
        abstract componentDidUpdate: prevProps: PopupContainerViewProps * prevState: PopupContainerViewState -> unit
        abstract componentDidMount: unit -> unit
        abstract componentWillUnmount: unit -> unit
        abstract render: unit -> JSX.Element
        abstract _onMount: (RN.ReactNativeBaseComponent<obj option, obj option> option -> unit) with get, set
        abstract _recalcPosition: obj with get, set
        abstract _recalcPositionFromLayoutData: obj with get, set
        abstract _recalcInnerPosition: obj with get, set
        abstract _dismissPopup: obj with get, set
        abstract _startRepositionPopupTimer: obj with get, set
        abstract _stopRepositionPopupTimer: obj with get, set

    type [<AllowNullLiteral>] PopupContainerViewStatic =
        [<Emit "new $0($1...)">] abstract Create: props: PopupContainerViewProps * context: PopupContainerViewContext -> PopupContainerView

module __native_common_RootView =
    let [<Import("","reactxp/native-common/RootView")>] : ``.IExports`` = jsNative

    type [<AllowNullLiteral>] IExports =
        abstract BaseRootView: BaseRootViewStatic
        abstract RootViewUsingStore: RootViewUsingStoreStatic
        abstract RootViewUsingProps: RootViewUsingPropsStatic

    type [<AllowNullLiteral>] BaseRootViewProps =
        abstract reactxp_rootViewId: string option with get, set

    type [<AllowNullLiteral>] RootViewPropsWithMainViewType =
        inherit BaseRootViewProps
        abstract reactxp_mainViewType: string with get, set

    type [<AllowNullLiteral>] RootViewState =
        abstract mainView: obj option with get, set
        abstract announcementText: string option with get, set

    type [<AllowNullLiteral>] BaseRootView<'P> =
        inherit React.Component<'P, RootViewState>
        abstract _frontLayerViewChangedSubscription: obj with get, set
        abstract _newAnnouncementEventChangedSubscription: obj with get, set
        abstract _memoryWarningEventSubscription: obj with get, set
        abstract _mainViewProps: obj with get, set
        abstract _rootViewId: string option with get, set
        abstract _getPropsForMainView: unit -> obj
        abstract componentWillMount: unit -> unit
        abstract componentWillUnmount: unit -> unit
        abstract render: unit -> JSX.Element
        abstract _renderAnnouncerView: unit -> JSX.Element
        abstract renderTopView: content: JSX.Element -> JSX.Element

    type [<AllowNullLiteral>] BaseRootViewStatic =
        [<Emit "new $0($1...)">] abstract Create: props: 'P -> BaseRootView<'P>

    type [<AllowNullLiteral>] RootViewUsingStore =
        inherit BaseRootView<BaseRootViewProps>
        abstract _changeListener: obj with get, set
        abstract componentWillMount: unit -> unit
        abstract componentWillUnmount: unit -> unit
        abstract _onChange: obj with get, set
        abstract _getStateFromStore: obj with get, set
        abstract _getPropsForMainView: unit -> obj

    type [<AllowNullLiteral>] RootViewUsingStoreStatic =
        [<Emit "new $0($1...)">] abstract Create: props: BaseRootViewProps -> RootViewUsingStore

    type [<AllowNullLiteral>] RootViewUsingProps =
        inherit BaseRootView<RootViewPropsWithMainViewType>
        abstract _getPropsForMainView: unit -> obj

    type [<AllowNullLiteral>] RootViewUsingPropsStatic =
        [<Emit "new $0($1...)">] abstract Create: props: RootViewPropsWithMainViewType -> RootViewUsingProps

module __native_common_ScrollView =
    let [<Import("","reactxp/native-common/ScrollView")>] : ``.IExports`` = jsNative

    type [<AllowNullLiteral>] IExports =
        abstract ScrollView: ScrollViewStatic

    type [<AllowNullLiteral>] ScrollView =
        inherit ViewBase<Types.ScrollViewProps, Types.Stateless>
        inherit RX.ScrollView
        abstract _scrollTop: obj with get, set
        abstract _scrollLeft: obj with get, set
        abstract _nativeView: obj option with get, set
        abstract _render: props: Types.ScrollViewProps -> JSX.Element
        abstract render: unit -> JSX.Element
        abstract _onScroll: obj with get, set
        abstract setScrollTop: scrollTop: float * ?animate: bool -> unit
        abstract setScrollLeft: scrollLeft: float * ?animate: bool -> unit
        abstract addToScrollTop: deltaTop: float * ?animate: bool -> unit
        abstract addToScrollLeft: deltaLeft: float * ?animate: bool -> unit

    type [<AllowNullLiteral>] ScrollViewStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> ScrollView
        abstract useCustomScrollbars: unit -> unit

module __native_common_Storage =
    let [<Import("","reactxp/native-common/Storage")>] : ``.IExports`` = jsNative
    let [<Import("_default","reactxp")>] _default: Storage = jsNative

    type [<AllowNullLiteral>] IExports =
        abstract Storage: StorageStatic

    type [<AllowNullLiteral>] Storage =
        inherit RX.Storage
        abstract getItem: key: string -> SyncTasks.Promise<string option>
        abstract setItem: key: string * value: string -> SyncTasks.Promise<unit>
        abstract removeItem: key: string -> SyncTasks.Promise<unit>
        abstract clear: unit -> SyncTasks.Promise<unit>

    type [<AllowNullLiteral>] StorageStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> Storage

module __native_common_StyleLeakDetector =
    let [<Import("","reactxp/native-common/StyleLeakDetector")>] : ``.IExports`` = jsNative
    type StyleLeakDetector as CommonStyleLeakDetector = ___common_StyleLeakDetector.StyleLeakDetector as CommonStyleLeakDetector
    let [<Import("_default","reactxp")>] _default: StyleLeakDetector = jsNative

    type [<AllowNullLiteral>] IExports =
        abstract StyleLeakDetector: StyleLeakDetectorStatic

    type [<AllowNullLiteral>] StyleLeakDetector =
        inherit CommonStyleLeakDetector
        abstract isDisabled: unit -> bool

    type [<AllowNullLiteral>] StyleLeakDetectorStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> StyleLeakDetector

module __native_common_Styles =
    let [<Import("","reactxp/native-common/Styles")>] : ``.IExports`` = jsNative
    let [<Import("_default","reactxp")>] _default: Styles = jsNative

    type [<AllowNullLiteral>] IExports =
        abstract Styles: StylesStatic

    type [<AllowNullLiteral>] Styles =
        inherit RX.Styles
        abstract combine: ruleSet1: Types.StyleRuleSetRecursive<'S> option * ?ruleSet2: Types.StyleRuleSetRecursive<'S> -> Types.StyleRuleSetOrArray<'S> option
        abstract createViewStyle: ruleSet: Types.ViewStyle * ?cacheStyle: bool -> Types.ViewStyleRuleSet
        abstract createAnimatedViewStyle: ruleSet: Types.AnimatedViewStyle -> Types.AnimatedViewStyleRuleSet
        abstract createScrollViewStyle: ruleSet: Types.ScrollViewStyle * ?cacheStyle: bool -> Types.ScrollViewStyleRuleSet
        abstract createButtonStyle: ruleSet: Types.ButtonStyle * ?cacheStyle: bool -> Types.ButtonStyleRuleSet
        abstract createWebViewStyle: ruleSet: Types.WebViewStyle * ?cacheStyle: bool -> Types.WebViewStyleRuleSet
        abstract createTextStyle: ruleSet: Types.TextStyle * ?cacheStyle: bool -> Types.TextStyleRuleSet
        abstract createAnimatedTextStyle: ruleSet: Types.AnimatedTextStyle -> Types.AnimatedTextStyleRuleSet
        abstract createTextInputStyle: ruleSet: Types.TextInputStyle * ?cacheStyle: bool -> Types.TextInputStyleRuleSet
        abstract createAnimatedTextInputStyle: ruleSet: Types.AnimatedTextInputStyle -> Types.AnimatedTextInputStyleRuleSet
        abstract createImageStyle: ruleSet: Types.ImageStyle * ?cacheStyle: bool -> Types.ImageStyleRuleSet
        abstract createAnimatedImageStyle: ruleSet: Types.AnimatedImageStyle -> Types.AnimatedImageStyleRuleSet
        abstract createLinkStyle: ruleSet: Types.LinkStyle * ?cacheStyle: bool -> Types.LinkStyleRuleSet
        abstract createPickerStyle: ruleSet: Types.PickerStyle * ?cacheStyle: bool -> Types.PickerStyleRuleSet
        abstract getCssPropertyAliasesCssStyle: unit -> obj
        abstract _adaptStyles: obj with get, set
        abstract _adaptAnimatedStyles: obj with get, set

    type [<AllowNullLiteral>] StylesStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> Styles

module __native_common_Text =
    let [<Import("","reactxp/native-common/Text")>] : ``.IExports`` = jsNative
    type FocusArbitratorProvider = ___common_utils_AutoFocusHelper.FocusArbitratorProvider

    type [<AllowNullLiteral>] IExports =
        abstract Text: TextStatic

    type [<AllowNullLiteral>] TextContext =
        abstract isRxParentAText: bool with get, set
        abstract focusArbitrator: FocusArbitratorProvider option with get, set
        abstract isRxParentAContextMenuResponder: bool option with get, set

    type [<AllowNullLiteral>] Text =
        inherit React.Component<Types.TextProps, Types.Stateless>
        inherit React.ChildContextProvider<TextContext>
        abstract contextTypes: React.ValidationMap<obj option> with get, set
        abstract context: TextContext with get, set
        abstract childContextTypes: React.ValidationMap<obj option> with get, set
        abstract _mountedComponent: RN.ReactNativeBaseComponent<obj option, obj option> option with get, set
        abstract setNativeProps: nativeProps: RN.TextProps -> unit
        abstract render: unit -> JSX.Element
        abstract componentDidMount: unit -> unit
        abstract _onMount: (obj option -> unit) with get, set
        abstract _onPress: obj with get, set
        abstract getChildContext: unit -> obj
        abstract _getStyles: unit -> Types.StyleRuleSetRecursiveArray<Types.TextStyleRuleSet>
        abstract requestFocus: unit -> unit
        abstract focus: unit -> unit
        abstract blur: unit -> unit

    type [<AllowNullLiteral>] TextStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> Text

module __native_common_TextInput =
    let [<Import("","reactxp/native-common/TextInput")>] : ``.IExports`` = jsNative
    type FocusArbitratorProvider = ___common_utils_AutoFocusHelper.FocusArbitratorProvider

    type [<AllowNullLiteral>] IExports =
        abstract TextInput: TextInputStatic

    type [<AllowNullLiteral>] TextInputState =
        abstract inputValue: string with get, set
        abstract isFocused: bool with get, set

    type [<AllowNullLiteral>] TextInputContext =
        abstract focusArbitrator: FocusArbitratorProvider option with get, set

    type [<AllowNullLiteral>] TextInput =
        inherit React.Component<Types.TextInputProps, TextInputState>
        abstract contextTypes: React.ValidationMap<obj option> with get, set
        abstract context: TextInputContext with get, set
        abstract _selectionToSet: obj with get, set
        abstract _selection: obj with get, set
        abstract _mountedComponent: RN.ReactNativeBaseComponent<obj option, obj option> option with get, set
        abstract componentWillReceiveProps: nextProps: Types.TextInputProps -> unit
        abstract componentDidMount: unit -> unit
        abstract _render: props: RN.TextInputProps * onMount: (obj option -> unit) -> JSX.Element
        abstract render: unit -> JSX.Element
        abstract _onMount: (RN.ReactNativeBaseComponent<obj option, obj option> option -> unit) with get, set
        abstract _onFocus: obj with get, set
        abstract _onBlur: obj with get, set
        abstract _onChangeText: obj with get, set
        abstract _onSelectionChange: obj with get, set
        abstract _onKeyPress: obj with get, set
        abstract _onPaste: obj with get, set
        abstract _onScroll: obj with get, set
        abstract blur: unit -> unit
        abstract requestFocus: unit -> unit
        abstract focus: unit -> unit
        abstract setAccessibilityFocus: unit -> unit
        abstract isFocused: unit -> bool
        abstract selectAll: unit -> unit
        abstract selectRange: start: float * ``end``: float -> unit
        abstract getSelectionRange: unit -> obj
        abstract setValue: value: string -> unit

    type [<AllowNullLiteral>] TextInputStatic =
        [<Emit "new $0($1...)">] abstract Create: props: Types.TextInputProps * context: TextInputContext -> TextInput

module __native_common_UserInterface =
    let [<Import("","reactxp/native-common/UserInterface")>] : ``.IExports`` = jsNative
    let [<Import("_default","reactxp")>] _default: UserInterface = jsNative

    type [<AllowNullLiteral>] IExports =
        abstract UserInterface: UserInterfaceStatic

    type [<AllowNullLiteral>] UserInterface =
        inherit RX.UserInterface
        abstract _touchLatencyThresholhdMs: obj with get, set
        abstract _isNavigatingWithKeyboard: obj with get, set
        abstract _rootViewUsingPropsFactory: obj with get, set
        abstract measureLayoutRelativeToWindow: ``component``: React.Component<obj option, obj option> -> SyncTasks.Promise<Types.LayoutInfo>
        abstract measureLayoutRelativeToAncestor: ``component``: React.Component<obj option, obj option> * ancestor: React.Component<obj option, obj option> -> SyncTasks.Promise<Types.LayoutInfo>
        abstract measureWindow: ?rootViewId: string -> Types.LayoutInfo
        abstract getContentSizeMultiplier: unit -> SyncTasks.Promise<float>
        abstract getMaxContentSizeMultiplier: unit -> SyncTasks.Promise<float>
        abstract setMaxContentSizeMultiplier: maxContentSizeMultiplier: float -> unit
        abstract useCustomScrollbars: ?enable: bool -> unit
        abstract dismissKeyboard: unit -> unit
        abstract isHighPixelDensityScreen: unit -> bool
        abstract getPixelRatio: unit -> float
        abstract setMainView: element: React.ReactElement<obj option> -> unit
        abstract registerRootViewUsingPropsFactory: factory: RN.ComponentProvider -> unit
        abstract registerRootView: viewKey: string * getComponentFunc: Function -> unit
        abstract renderMainView: unit -> unit
        abstract enableTouchLatencyEvents: latencyThresholdMs: float -> unit
        abstract evaluateTouchLatency: e: Types.SyntheticEvent -> unit
        abstract isNavigatingWithKeyboard: unit -> bool
        abstract _keyboardNavigationStateChanged: obj with get, set

    type [<AllowNullLiteral>] UserInterfaceStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> UserInterface

module __native_common_UserPresence =
    let [<Import("","reactxp/native-common/UserPresence")>] : ``.IExports`` = jsNative
    let [<Import("_default","reactxp")>] _default: UserPresence = jsNative

    type [<AllowNullLiteral>] IExports =
        abstract UserPresence: UserPresenceStatic

    type [<AllowNullLiteral>] UserPresence =
        inherit RX.UserPresence
        abstract isUserPresent: unit -> bool

    type [<AllowNullLiteral>] UserPresenceStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> UserPresence

module __native_common_View =
    let [<Import("","reactxp/native-common/View")>] : ``.IExports`` = jsNative
    type FocusArbitratorProvider = ___common_utils_AutoFocusHelper.FocusArbitratorProvider

    type [<AllowNullLiteral>] IExports =
        abstract View: ViewStatic

    type [<AllowNullLiteral>] ViewContext =
        abstract focusArbitrator: FocusArbitratorProvider option with get, set

    type [<AllowNullLiteral>] View =
        inherit ViewBase<Types.ViewProps, Types.Stateless>
        abstract contextTypes: React.ValidationMap<obj option> with get, set
        abstract context: ViewContext with get, set
        abstract childContextTypes: React.ValidationMap<obj option> with get, set
        abstract _internalProps: obj option with get, set
        abstract touchableGetInitialState: (unit -> RN.Touchable.State) with get, set
        abstract touchableHandleStartShouldSetResponder: (unit -> bool) with get, set
        abstract touchableHandleResponderTerminationRequest: (unit -> bool) with get, set
        abstract touchableHandleResponderGrant: (React.SyntheticEvent<obj option> -> unit) with get, set
        abstract touchableHandleResponderMove: (React.SyntheticEvent<obj option> -> unit) with get, set
        abstract touchableHandleResponderRelease: (React.SyntheticEvent<obj option> -> unit) with get, set
        abstract touchableHandleResponderTerminate: (React.SyntheticEvent<obj option> -> unit) with get, set
        abstract _mixinIsApplied: obj with get, set
        abstract _childrenKeys: obj with get, set
        abstract _mixin_componentDidMount: obj option with get, set
        abstract _mixin_componentWillUnmount: obj option with get, set
        abstract _isMounted: bool with get, set
        abstract _hideTimeout: obj with get, set
        abstract _defaultOpacityValue: obj with get, set
        abstract _opacityAnimatedValue: obj with get, set
        abstract _opacityAnimatedStyle: obj with get, set
        abstract _focusArbitratorProvider: obj with get, set
        abstract componentWillReceiveProps: nextProps: Types.ViewProps -> unit
        abstract componentWillUpdate: nextProps: Types.ViewProps * nextState: ViewComponentWillUpdateNextState -> unit
        abstract componentDidMount: unit -> unit
        abstract componentWillUnmount: unit -> unit
        abstract _updateMixin: obj with get, set
        abstract getChildContext: unit -> ViewContext
        /// Attention:
        /// be careful with setting any non layout properties unconditionally in this method to any value
        /// as on android that would lead to extra layers of Views.
        abstract _buildInternalProps: props: Types.ViewProps -> unit
        abstract _isTouchFeedbackApplicable: obj with get, set
        abstract _opacityActive: obj with get, set
        abstract _opacityInactive: obj with get, set
        abstract _getDefaultOpacityValue: obj with get, set
        abstract _setOpacityTo: obj with get, set
        abstract _showUnderlay: obj with get, set
        abstract _hideUnderlay: obj with get, set
        abstract _isButton: viewProps: Types.ViewProps -> bool
        abstract _updateFocusArbitratorProvider: obj with get, set
        abstract render: unit -> JSX.Element
        abstract touchableHandlePress: e: Types.SyntheticEvent -> unit
        abstract touchableHandleLongPress: e: Types.SyntheticEvent -> unit
        abstract touchableHandleActivePressIn: e: Types.SyntheticEvent -> unit
        abstract touchableHandleActivePressOut: e: Types.SyntheticEvent -> unit
        abstract touchableGetHighlightDelayMS: unit -> float
        abstract touchableGetPressRectOffset: unit -> obj
        abstract setFocusRestricted: restricted: bool -> unit
        abstract setFocusLimited: limited: bool -> unit
        abstract blur: unit -> unit
        abstract requestFocus: unit -> unit
        abstract focus: unit -> unit

    type [<AllowNullLiteral>] ViewComponentWillUpdateNextState =
        interface end

    type [<AllowNullLiteral>] ViewStatic =
        [<Emit "new $0($1...)">] abstract Create: props: Types.ViewProps * context: ViewContext -> View

module __native_common_ViewBase =
    let [<Import("","reactxp/native-common/ViewBase")>] : ``.IExports`` = jsNative

    type [<AllowNullLiteral>] IExports =
        abstract ViewBase: ViewBaseStatic

    type [<AllowNullLiteral>] ViewBase<'P, 'S> =
        inherit RX.ViewBase<'P, 'S>
        abstract _defaultViewStyle: obj with get, set
        abstract _layoutEventValues: obj with get, set
        abstract render: unit -> JSX.Element
        abstract _nativeView: RN.View option with get, set
        abstract setNativeProps: nativeProps: RN.ViewProps -> unit
        abstract _setNativeView: (obj option -> unit) with get, set
        abstract _getStyles: props: Types.ViewProps -> RX.Types.StyleRuleSetRecursive<RX.Types.StyleRuleSet<RX.Types.ViewStyle>>
        abstract _onLayout: (RN.LayoutChangeEvent -> unit) with get, set

    type [<AllowNullLiteral>] ViewBaseStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> ViewBase<'P, 'S>
        abstract setDefaultViewStyle: defaultViewStyle: Types.ViewStyleRuleSet -> unit
        abstract getDefaultViewStyle: unit -> RX.Types.StyleRuleSet<RX.Types.ViewStyle>

module __native_common_WebView =
    let [<Import("","reactxp/native-common/WebView")>] : ``.IExports`` = jsNative

    type [<AllowNullLiteral>] IExports =
        abstract WebView: WebViewStatic

    type [<AllowNullLiteral>] WebView =
        inherit React.Component<Types.WebViewProps, Types.Stateless>
        inherit RX.WebView
        abstract _mountedComponent: obj with get, set
        abstract render: unit -> JSX.Element
        abstract _onMount: (obj option -> unit) with get, set
        abstract _onMessage: (RN.NativeSyntheticEvent<RN.WebViewMessageEventData> -> unit) with get, set
        abstract _buildSource: obj with get, set
        abstract postMessage: message: string * ?targetOrigin: string -> unit
        abstract reload: unit -> unit
        abstract goBack: unit -> unit
        abstract goForward: unit -> unit

    type [<AllowNullLiteral>] WebViewStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> WebView

module __native_desktop_App =
    let [<Import("","reactxp/native-desktop/App")>] : ``.IExports`` = jsNative
    type ComponentProvider = React_native.ComponentProvider
    type App as AppCommon = ___native_common_App.App as AppCommon
    let [<Import("_default","reactxp")>] _default: App = jsNative

    type [<AllowNullLiteral>] IExports =
        abstract App: AppStatic

    type [<AllowNullLiteral>] App =
        inherit AppCommon
        abstract getRootViewFactory: unit -> ComponentProvider
        abstract getRootViewUsingPropsFactory: unit -> ComponentProvider

    type [<AllowNullLiteral>] AppStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> App

module __native_desktop_Input =
    let [<Import("","reactxp/native-desktop/Input")>] : ``.IExports`` = jsNative
    type Input as InputCommon = ___native_common_Input.Input as InputCommon
    let [<Import("_default","reactxp")>] _default: Input = jsNative

    type [<AllowNullLiteral>] IExports =
        abstract Input: InputStatic

    type [<AllowNullLiteral>] Input =
        inherit InputCommon
        abstract dispatchKeyDown: e: Types.KeyboardEvent -> unit
        abstract dispatchKeyUp: e: Types.KeyboardEvent -> unit

    type [<AllowNullLiteral>] InputStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> Input

module __native_desktop_RootView =
    type RootView as RootViewBase = ___native_common_RootView.RootView as RootViewBase
    type RootViewUsingProps as RootViewUsingPropsBase = ___native_common_RootView.RootViewUsingProps as RootViewUsingPropsBase
    type BaseRootViewProps = ___native_common_RootView.BaseRootViewProps
    type RootViewPropsWithMainViewType = ___native_common_RootView.RootViewPropsWithMainViewType
    type RootViewState = ___native_common_RootView.RootViewState
    type BaseRootView = ___native_common_RootView.BaseRootView
    let [<Import("RootViewUsingStore","reactxp")>] RootViewUsingStore: obj = jsNative
    let [<Import("RootViewUsingProps","reactxp")>] RootViewUsingProps: obj = jsNative

module __tslint_groupedImportRule =
    let [<Import("","reactxp/tslint/groupedImportRule")>] : ``.IExports`` = jsNative
    module Ts = Typescript
    type RuleFailure = Tslint.RuleFailure
    type Rules = Tslint.Rules

    type [<AllowNullLiteral>] IExports =
        abstract Rule: RuleStatic

    type [<AllowNullLiteral>] Rule =
        inherit Rules.AbstractRule
        abstract FAILURE_STRING_PART: string with get, set
        abstract apply: sourceFile: Ts.SourceFile -> ResizeArray<RuleFailure>

    type [<AllowNullLiteral>] RuleStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> Rule

module __tslint_incorrectThisPropsRule =
    let [<Import("","reactxp/tslint/incorrectThisPropsRule")>] : ``.IExports`` = jsNative
    module Ts = Typescript
    type RuleFailure = Tslint.RuleFailure
    type Rules = Tslint.Rules

    type [<AllowNullLiteral>] IExports =
        abstract Rule: RuleStatic

    type [<AllowNullLiteral>] Rule =
        inherit Rules.AbstractRule
        abstract apply: sourceFile: Ts.SourceFile -> ResizeArray<RuleFailure>

    type [<AllowNullLiteral>] RuleStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> Rule

module __tslint_noUnreferencedStylesRule =
    let [<Import("","reactxp/tslint/noUnreferencedStylesRule")>] : ``.IExports`` = jsNative
    module Ts = Typescript
    type RuleFailure = Tslint.RuleFailure
    type Rules = Tslint.Rules

    type [<AllowNullLiteral>] IExports =
        abstract Rule: RuleStatic

    type [<AllowNullLiteral>] Rule =
        inherit Rules.AbstractRule
        abstract apply: sourceFile: Ts.SourceFile -> ResizeArray<RuleFailure>

    type [<AllowNullLiteral>] RuleStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> Rule

module __web_Accessibility =
    let [<Import("","reactxp/web/Accessibility")>] : ``.IExports`` = jsNative
    type Accessibility as CommonAccessibility = ___common_Accessibility.Accessibility as CommonAccessibility
    let [<Import("_default","reactxp")>] _default: Accessibility = jsNative

    type [<AllowNullLiteral>] IExports =
        abstract Accessibility: AccessibilityStatic

    type [<AllowNullLiteral>] Accessibility =
        inherit CommonAccessibility
        abstract isScreenReaderEnabled: unit -> bool

    type [<AllowNullLiteral>] AccessibilityStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> Accessibility

module __web_AccessibilityAnnouncer =
    let [<Import("","reactxp/web/AccessibilityAnnouncer")>] : ``.IExports`` = jsNative

    type [<AllowNullLiteral>] IExports =
        abstract AccessibilityAnnouncer: AccessibilityAnnouncerStatic

    type [<AllowNullLiteral>] AccessibilityAnnouncerState =
        abstract announcementText: string with get, set
        abstract announcementTextInNestedDiv: bool with get, set

    type [<AllowNullLiteral>] AccessibilityAnnouncer =
        inherit React.Component<obj, AccessibilityAnnouncerState>
        abstract _clearAnnouncementTimer: obj with get, set
        abstract _newAnnouncementEventChangedSubscription: obj with get, set
        abstract _getInitialState: obj with get, set
        abstract componentDidUpdate: prevProps: AccessibilityAnnouncerComponentDidUpdatePrevProps * prevState: AccessibilityAnnouncerState -> unit
        abstract componentWillUnmount: unit -> unit
        abstract render: unit -> JSX.Element
        abstract _cancelClearAnnouncementTimer: obj with get, set
        abstract _startClearAnnouncementTimer: obj with get, set

    type [<AllowNullLiteral>] AccessibilityAnnouncerComponentDidUpdatePrevProps =
        interface end

    type [<AllowNullLiteral>] AccessibilityAnnouncerStatic =
        [<Emit "new $0($1...)">] abstract Create: props: AccessibilityAnnouncerStaticProps -> AccessibilityAnnouncer

    type [<AllowNullLiteral>] AccessibilityAnnouncerStaticProps =
        interface end

module __web_AccessibilityUtil =
    let [<Import("","reactxp/web/AccessibilityUtil")>] : ``.IExports`` = jsNative
    type AccessibilityUtil as CommonAccessibiltiyUtil = ___common_AccessibilityUtil.AccessibilityUtil as CommonAccessibiltiyUtil
    let [<Import("_default","reactxp")>] _default: AccessibilityUtil = jsNative

    type [<AllowNullLiteral>] IExports =
        abstract AccessibilityUtil: AccessibilityUtilStatic

    type [<AllowNullLiteral>] AccessibilityUtil =
        inherit CommonAccessibiltiyUtil
        abstract accessibilityLiveRegionToString: liveRegion: Types.AccessibilityLiveRegion -> Types.AriaLive option
        abstract accessibilityTraitToString: traits: U2<Types.AccessibilityTrait, ResizeArray<Types.AccessibilityTrait>> option * ?defaultTrait: Types.AccessibilityTrait -> string option
        abstract accessibilityTraitToAriaSelected: traits: U2<Types.AccessibilityTrait, ResizeArray<Types.AccessibilityTrait>> option -> bool option
        abstract accessibilityTraitToAriaChecked: traits: U2<Types.AccessibilityTrait, ResizeArray<Types.AccessibilityTrait>> option -> bool option
        abstract accessibilityTraitToAriaHasPopup: traits: U2<Types.AccessibilityTrait, ResizeArray<Types.AccessibilityTrait>> option -> bool option

    type [<AllowNullLiteral>] AccessibilityUtilStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> AccessibilityUtil

module __web_ActivityIndicator =
    let [<Import("","reactxp/web/ActivityIndicator")>] : ``.IExports`` = jsNative

    type [<AllowNullLiteral>] IExports =
        abstract ActivityIndicator: ActivityIndicatorStatic

    type [<AllowNullLiteral>] ActivityIndicatorState =
        abstract isVisible: bool option with get, set

    type [<AllowNullLiteral>] ActivityIndicator =
        inherit React.Component<Types.ActivityIndicatorProps, ActivityIndicatorState>
        abstract _isStyleSheetInstalled: obj with get, set
        abstract _isMounted: obj with get, set
        abstract _installStyleSheet: obj with get, set
        abstract componentDidMount: unit -> unit
        abstract componentWillUnmount: unit -> unit
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] ActivityIndicatorStatic =
        [<Emit "new $0($1...)">] abstract Create: props: Types.ActivityIndicatorProps -> ActivityIndicator

module __web_Alert =
    let [<Import("","reactxp/web/Alert")>] : ``.IExports`` = jsNative
    let [<Import("_default","reactxp")>] _default: Alert = jsNative

    type [<AllowNullLiteral>] IExports =
        abstract Alert: AlertStatic

    type [<AllowNullLiteral>] Alert =
        inherit RX.Alert
        abstract _modalId: obj with get, set
        abstract show: title: string * ?message: string * ?buttons: ResizeArray<Types.AlertButtonSpec> * ?options: Types.AlertOptions -> unit

    type [<AllowNullLiteral>] AlertStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> Alert

module __web_AlertModalContent =
    let [<Import("","reactxp/web/AlertModalContent")>] : ``.IExports`` = jsNative
    type ViewProps = ___common_Types.ViewProps

    type [<AllowNullLiteral>] IExports =
        abstract AlertModalContent: AlertModalContentStatic

    type [<AllowNullLiteral>] AppModalContentProps =
        inherit ViewProps
        abstract buttons: ResizeArray<Types.AlertButtonSpec> option with get, set
        abstract title: string with get, set
        abstract message: string option with get, set
        abstract modalId: string with get, set
        abstract theme: Types.AlertModalTheme option with get, set

    type [<AllowNullLiteral>] AppModalContentState =
        abstract hoverIndex: float with get, set

    type [<AllowNullLiteral>] AlertModalContent =
        inherit RX.Component<AppModalContentProps, AppModalContentState>
        abstract render: unit -> JSX.Element
        abstract _onPressButton: obj with get, set
        abstract _onPressBody: obj with get, set
        abstract _onPressBackground: obj with get, set

    type [<AllowNullLiteral>] AlertModalContentStatic =
        [<Emit "new $0($1...)">] abstract Create: props: AppModalContentProps -> AlertModalContent

module __web_Animated =
    let [<Import("","reactxp/web/Animated")>] : ``.IExports`` = jsNative
    let [<Import("timing","reactxp")>] timing: Types.Animated.TimingFunction = jsNative
    let [<Import("sequence","reactxp")>] sequence: Types.Animated.SequenceFunction = jsNative
    let [<Import("parallel","reactxp")>] ``parallel``: Types.Animated.ParallelFunction = jsNative
    let [<Import("Image","reactxp")>] Image: obj = jsNative
    let [<Import("Text","reactxp")>] Text: obj = jsNative
    let [<Import("TextInput","reactxp")>] TextInput: obj = jsNative
    let [<Import("View","reactxp")>] View: obj = jsNative
    let [<Import("createValue","reactxp")>] createValue: (float -> Value) = jsNative
    let [<Import("interpolate","reactxp")>] interpolate: (Value -> ResizeArray<float> -> ResizeArray<string> -> Value) = jsNative

    type [<AllowNullLiteral>] IExports =
        abstract Animation: AnimationStatic
        abstract Value: ValueStatic

    type [<AllowNullLiteral>] Animation =
        abstract _id: float option with get, set
        abstract start: ?onEnd: Types.Animated.EndCallback -> unit
        abstract stop: unit -> unit

    type [<AllowNullLiteral>] AnimationStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> Animation

    type [<AllowNullLiteral>] ValueListener =
        abstract setValue: valueObject: Value * newValue: U2<float, string> -> unit
        abstract startTransition: valueObject: Value * from: U2<float, string> * toValue: U2<float, string> * duration: float * easing: string * delay: float * onEnd: Types.Animated.EndCallback -> unit
        abstract stopTransition: valueObject: Value -> U2<float, string> option

    type [<AllowNullLiteral>] Value =
        inherit Types.AnimatedValue
        abstract _value: obj with get, set
        abstract _listeners: obj with get, set
        abstract _interpolationConfig: obj with get, set
        abstract _getValue: unit -> U2<float, string>
        abstract _isInterpolated: unit -> bool
        abstract _getInterpolatedValue: key: float -> U2<string, float>
        abstract interpolate: config: Types.Animated.InterpolationConfigType -> Value
        abstract setValue: value: U2<float, string> -> unit
        abstract _addListener: listenerToAdd: ValueListener -> unit
        abstract _removeListener: listenerToRemove: ValueListener -> unit
        abstract _removeAllListeners: unit -> unit
        abstract _startTransition: toValue: U2<float, string> * duration: float * easing: string * delay: float * onEnd: Types.Animated.EndCallback -> unit
        abstract _stopTransition: unit -> unit
        abstract _updateFinalValue: value: U2<float, string> -> unit

    type [<AllowNullLiteral>] ValueStatic =
        [<Emit "new $0($1...)">] abstract Create: value: float -> Value

    type Image =
        RX.AnimatedImage

    type Text =
        RX.AnimatedText

    type TextInput =
        RX.AnimatedTextInput

    type View =
        RX.AnimatedView

module __web_App =
    let [<Import("","reactxp/web/App")>] : ``.IExports`` = jsNative
    let [<Import("_default","reactxp")>] _default: App = jsNative

    type [<AllowNullLiteral>] IExports =
        abstract App: AppStatic

    type [<AllowNullLiteral>] App =
        inherit RX.App
        abstract _activationState: obj with get, set
        abstract initialize: debug: bool * development: bool -> unit
        abstract getActivationState: unit -> Types.AppActivationState
        abstract _setActivationState: obj with get, set

    type [<AllowNullLiteral>] AppStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> App

module __web_Button =
    let [<Import("","reactxp/web/Button")>] : ``.IExports`` = jsNative
    type FocusArbitratorProvider = ___common_utils_AutoFocusHelper.FocusArbitratorProvider
    type Button as ButtonBase = ___common_Interfaces.Button as ButtonBase

    type [<AllowNullLiteral>] IExports =
        abstract Button: ButtonStatic

    type [<AllowNullLiteral>] ButtonContext =
        abstract hasRxButtonAscendant: bool option with get, set
        abstract focusArbitrator: FocusArbitratorProvider option with get, set

    type [<AllowNullLiteral>] Button =
        inherit ButtonBase
        abstract contextTypes: obj with get, set
        abstract context: ButtonContext with get, set
        abstract childContextTypes: obj with get, set
        abstract _isMounted: obj with get, set
        abstract _lastMouseDownEvent: obj with get, set
        abstract _ignoreClick: obj with get, set
        abstract _longPressTimer: obj with get, set
        abstract _isMouseOver: obj with get, set
        abstract _isFocusedWithKeyboard: obj with get, set
        abstract _isHoverStarted: obj with get, set
        abstract getChildContext: unit -> ButtonContext
        abstract render: unit -> JSX.Element
        abstract componentDidMount: unit -> unit
        abstract componentWillUnmount: unit -> unit
        abstract requestFocus: unit -> unit
        abstract focus: unit -> unit
        abstract blur: unit -> unit
        abstract onClick: (Types.MouseEvent -> unit) with get, set
        abstract _getStyles: obj with get, set
        abstract _onContextMenu: obj with get, set
        abstract _onMouseDown: obj with get, set
        abstract _onMouseUp: obj with get, set
        abstract _onMouseEnter: obj with get, set
        abstract _onMouseLeave: obj with get, set
        abstract _onFocus: obj with get, set
        abstract _onBlur: obj with get, set
        abstract _onHoverStart: obj with get, set
        abstract _onHoverEnd: obj with get, set

    type [<AllowNullLiteral>] ButtonStatic =
        [<Emit "new $0($1...)">] abstract Create: props: Types.ButtonProps * context: ButtonContext -> Button

module __web_Clipboard =
    let [<Import("","reactxp/web/Clipboard")>] : ``.IExports`` = jsNative
    let [<Import("_default","reactxp")>] _default: Clipboard = jsNative

    type [<AllowNullLiteral>] IExports =
        abstract Clipboard: ClipboardStatic

    type [<AllowNullLiteral>] Clipboard =
        inherit RX.Clipboard
        abstract setText: text: string -> unit
        abstract getText: unit -> SyncTasks.Promise<string>
        abstract _createInvisibleNode: obj with get, set
        abstract _copyNode: obj with get, set

    type [<AllowNullLiteral>] ClipboardStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> Clipboard

module __web_CustomScrollbar =
    let [<Import("","reactxp/web/CustomScrollbar")>] : ``.IExports`` = jsNative

    type [<AllowNullLiteral>] IExports =
        abstract Scrollbar: ScrollbarStatic

    /// CustomScrollbar.ts
    /// 
    /// Copyright (c) Microsoft Corporation. All rights reserved.
    /// Licensed under the MIT license.
    /// 
    /// Custom scrollbar implementation for web.
    type [<AllowNullLiteral>] ScrollbarOptions =
        abstract horizontal: bool option with get, set
        abstract vertical: bool option with get, set
        abstract hiddenScrollbar: bool option with get, set

    type [<AllowNullLiteral>] Scrollbar =
        abstract _container: obj with get, set
        abstract _verticalBar: obj with get, set
        abstract _horizontalBar: obj with get, set
        abstract _viewport: obj with get, set
        abstract _dragging: obj with get, set
        abstract _dragIsVertical: obj with get, set
        abstract _scrollingVisible: obj with get, set
        abstract _hasHorizontal: obj with get, set
        abstract _hasVertical: obj with get, set
        abstract _hasHiddenScrollbar: obj with get, set
        abstract _stopDragCallback: obj with get, set
        abstract _startDragVCallback: obj with get, set
        abstract _startDragHCallback: obj with get, set
        abstract _handleDragCallback: obj with get, set
        abstract _handleWheelCallback: obj with get, set
        abstract _handleMouseDownCallback: obj with get, set
        abstract _updateCallback: obj with get, set
        abstract _asyncInitTimer: obj with get, set
        abstract _tryLtrOverride: obj with get, set
        abstract _prevent: obj with get, set
        abstract _updateSliders: obj with get, set
        abstract _handleDrag: obj with get, set
        abstract _startDrag: obj with get, set
        abstract _stopDrag: obj with get, set
        abstract _handleWheel: obj with get, set
        abstract _handleMouseDown: obj with get, set
        abstract _normalizeDelta: obj with get, set
        abstract _addListeners: obj with get, set
        abstract _removeListeners: obj with get, set
        abstract _createDivWithClass: obj with get, set
        abstract _addScrollBar: obj with get, set
        abstract _addScrollbars: obj with get, set
        abstract _removeScrollbars: obj with get, set
        abstract _calcNewBarSize: obj with get, set
        abstract _resize: obj with get, set
        abstract update: unit -> unit
        abstract show: unit -> unit
        abstract hide: unit -> unit
        abstract init: ?options: ScrollbarOptions -> unit
        abstract dispose: unit -> unit

    type [<AllowNullLiteral>] ScrollbarStatic =
        abstract getNativeScrollbarWidth: unit -> float
        abstract _installStyleSheet: unit -> unit
        [<Emit "new $0($1...)">] abstract Create: container: HTMLElement -> Scrollbar

module __web_FrontLayerViewManager =
    let [<Import("","reactxp/web/FrontLayerViewManager")>] : ``.IExports`` = jsNative
    let [<Import("_default","reactxp")>] _default: FrontLayerViewManager = jsNative

    type [<AllowNullLiteral>] IExports =
        abstract FrontLayerViewManager: FrontLayerViewManagerStatic

    type [<AllowNullLiteral>] FrontLayerViewManager =
        abstract _mainView: obj with get, set
        abstract _modalStack: obj with get, set
        abstract _activePopupOptions: obj with get, set
        abstract _activePopupId: obj with get, set
        abstract _activePopupAutoDismiss: obj with get, set
        abstract _activePopupAutoDismissDelay: obj with get, set
        abstract _activePopupShowDelay: obj with get, set
        abstract _popupShowDelayTimer: obj with get, set
        abstract _cachedPopups: obj with get, set
        abstract _isRtlDefault: obj with get, set
        abstract _isRtlAllowed: obj with get, set
        abstract _isRtlForced: obj with get, set
        abstract setMainView: element: React.ReactElement<obj option> -> unit
        abstract isModalDisplayed: ?modalId: string -> bool
        abstract showModal: modal: React.ReactElement<Types.ViewProps> * modalId: string * ?options: Types.ModalOptions -> unit
        abstract dismissModal: modalId: string -> unit
        abstract dismissAllModals: unit -> unit
        abstract _shouldPopupBeDismissed: obj with get, set
        abstract showPopup: options: Types.PopupOptions * popupId: string * ?showDelay: float -> bool
        abstract _showPopup: obj with get, set
        abstract autoDismissPopup: popupId: string * ?dismissDelay: float -> unit
        abstract dismissPopup: popupId: string -> unit
        abstract dismissAllPopups: unit -> unit
        abstract _renderRootView: obj with get, set
        abstract isPopupDisplayed: ?popupId: string -> bool
        abstract allowRTL: allow: bool -> unit
        abstract forceRTL: force: bool -> unit
        abstract isRTL: unit -> bool

    type [<AllowNullLiteral>] FrontLayerViewManagerStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> FrontLayerViewManager

module __web_GestureView =
    let [<Import("","reactxp/web/GestureView")>] : ``.IExports`` = jsNative

    type [<AllowNullLiteral>] IExports =
        abstract GestureView: GestureViewStatic

    type [<AllowNullLiteral>] GestureView =
        inherit React.Component<Types.GestureViewProps, Types.Stateless>
        abstract _id: obj with get, set
        abstract _container: obj with get, set
        abstract _doubleTapTimer: obj with get, set
        abstract _lastTapEvent: obj with get, set
        abstract _responder: obj with get, set
        abstract _pendingGestureType: obj with get, set
        abstract _gestureTypeLocked: obj with get, set
        abstract _skipNextTap: obj with get, set
        abstract componentWillUnmount: unit -> unit
        abstract render: unit -> JSX.Element
        abstract _createMouseResponder: obj with get, set
        abstract _disposeMouseResponder: obj with get, set
        abstract _setContainerRef: obj with get, set
        abstract _getStyles: obj with get, set
        abstract _onClick: obj with get, set
        abstract _sendContextMenuEvent: obj with get, set
        abstract _detectGestureType: obj with get, set
        abstract _getPanPixelThreshold: obj with get, set
        abstract _shouldRespondToPan: obj with get, set
        abstract _shouldRespondToPanVertical: obj with get, set
        abstract _shouldRespondToPanHorizontal: obj with get, set
        abstract _onWheel: obj with get, set
        abstract _calcDistance: obj with get, set
        abstract _isDoubleTap: obj with get, set
        abstract _startDoubleTapTimer: obj with get, set
        abstract _cancelDoubleTapTimer: obj with get, set
        abstract _reportDelayedTap: obj with get, set
        abstract _sendTapEvent: obj with get, set
        abstract _sendDoubleTapEvent: obj with get, set
        abstract _sendPanEvent: obj with get, set
        abstract _getGestureViewClientRect: obj with get, set

    type [<AllowNullLiteral>] GestureViewStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> GestureView

module __web_Image =
    let [<Import("","reactxp/web/Image")>] : ``.IExports`` = jsNative

    type [<AllowNullLiteral>] IExports =
        abstract Image: ImageStatic

    type [<AllowNullLiteral>] ImageState =
        abstract showImgTag: bool with get, set
        abstract xhrRequest: bool with get, set
        abstract displayUrl: string with get, set

    type [<AllowNullLiteral>] ImageContext =
        abstract isRxParentAText: bool option with get, set

    type [<AllowNullLiteral>] Image =
        inherit React.Component<Types.ImageProps, ImageState>
        abstract contextTypes: React.ValidationMap<obj option> with get, set
        abstract context: ImageContext with get, set
        abstract childContextTypes: React.ValidationMap<obj option> with get, set
        abstract _mountedComponent: obj with get, set
        abstract getChildContext: unit -> obj
        abstract _isMounted: obj with get, set
        abstract _nativeImageWidth: obj with get, set
        abstract _nativeImageHeight: obj with get, set
        abstract componentWillReceiveProps: nextProps: Types.ImageProps -> unit
        abstract componentDidMount: unit -> unit
        abstract componentWillUnmount: unit -> unit
        abstract _initializeAndSetState: obj with get, set
        abstract _handleXhrBlob: obj with get, set
        abstract _startXhrImageFetch: obj with get, set
        abstract _actuallyStartXhrImageFetch: obj with get, set
        abstract render: unit -> React.ReactElement<obj option>
        abstract _onMount: (HTMLImageElement option -> unit) with get, set
        abstract _getStyles: obj with get, set
        abstract _buildBackgroundSize: obj with get, set
        abstract _onLoad: obj with get, set
        abstract _imgOnError: obj with get, set
        abstract _onError: obj with get, set
        abstract _onMouseUp: obj with get, set
        abstract getNativeWidth: unit -> float option
        abstract getNativeHeight: unit -> float option

    type [<AllowNullLiteral>] ImageStatic =
        abstract prefetch: url: string -> SyncTasks.Promise<bool>
        abstract getMetadata: url: string -> SyncTasks.Promise<Types.ImageMetadata>
        [<Emit "new $0($1...)">] abstract Create: props: Types.ImageProps -> Image

module __web_Input =
    let [<Import("","reactxp/web/Input")>] : ``.IExports`` = jsNative
    let [<Import("_default","reactxp")>] _default: Input = jsNative

    type [<AllowNullLiteral>] IExports =
        abstract Input: InputStatic

    type [<AllowNullLiteral>] Input =
        inherit RX.Input
        abstract dispatchKeyDown: e: Types.KeyboardEvent -> unit
        abstract dispatchKeyUp: e: Types.KeyboardEvent -> unit

    type [<AllowNullLiteral>] InputStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> Input

module __web_International =
    let [<Import("","reactxp/web/International")>] : ``.IExports`` = jsNative
    let [<Import("_default","reactxp")>] _default: International = jsNative

    type [<AllowNullLiteral>] IExports =
        abstract International: InternationalStatic

    type [<AllowNullLiteral>] International =
        inherit RXInterfaces.International
        abstract allowRTL: allow: bool -> unit
        abstract forceRTL: force: bool -> unit
        abstract isRTL: unit -> bool

    type [<AllowNullLiteral>] InternationalStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> International

module __web_Link =
    let [<Import("","reactxp/web/Link")>] : ``.IExports`` = jsNative
    type FocusArbitratorProvider = ___common_utils_AutoFocusHelper.FocusArbitratorProvider

    type [<AllowNullLiteral>] IExports =
        abstract Link: LinkStatic

    type [<AllowNullLiteral>] LinkContext =
        abstract focusArbitrator: FocusArbitratorProvider option with get, set

    type [<AllowNullLiteral>] Link =
        inherit React.Component<Types.LinkProps, Types.Stateless>
        abstract contextTypes: obj with get, set
        abstract context: LinkContext with get, set
        abstract _isMounted: obj with get, set
        abstract _longPressTimer: obj with get, set
        abstract render: unit -> JSX.Element
        abstract componentDidMount: unit -> unit
        abstract componentWillUnmount: unit -> unit
        abstract requestFocus: unit -> unit
        abstract focus: unit -> unit
        abstract blur: unit -> unit
        abstract _getStyles: unit -> Types.LinkStyleRuleSet
        abstract _onClick: obj with get, set
        abstract _onMouseDown: obj with get, set
        abstract _onMouseUp: obj with get, set
        abstract _onContextMenu: obj with get, set

    type [<AllowNullLiteral>] LinkStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> Link

module __web_Linking =
    let [<Import("","reactxp/web/Linking")>] : ``.IExports`` = jsNative
    type Linking as CommonLinking = ___common_Linking.Linking as CommonLinking
    let [<Import("_default","reactxp")>] _default: Linking = jsNative

    type [<AllowNullLiteral>] IExports =
        abstract Linking: LinkingStatic

    type [<AllowNullLiteral>] Linking =
        inherit CommonLinking
        abstract _openUrl: url: string -> SyncTasks.Promise<unit>
        abstract launchEmail: emailInfo: Types.EmailInfo -> SyncTasks.Promise<unit>
        abstract getInitialUrl: unit -> SyncTasks.Promise<string option>

    type [<AllowNullLiteral>] LinkingStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> Linking

module __web_Modal =
    let [<Import("","reactxp/web/Modal")>] : ``.IExports`` = jsNative
    let [<Import("_default","reactxp")>] _default: Modal = jsNative

    type [<AllowNullLiteral>] IExports =
        abstract Modal: ModalStatic

    type [<AllowNullLiteral>] Modal =
        inherit RX.Modal
        abstract isDisplayed: ?modalId: string -> bool
        abstract show: modal: React.ReactElement<Types.ViewProps> * modalId: string * ?options: Types.ModalOptions -> unit
        abstract dismiss: modalId: string -> unit
        abstract dismissAll: unit -> unit

    type [<AllowNullLiteral>] ModalStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> Modal

module __web_ModalContainer =
    let [<Import("","reactxp/web/ModalContainer")>] : ``.IExports`` = jsNative

    type [<AllowNullLiteral>] IExports =
        abstract ModalContainer: ModalContainerStatic

    type [<AllowNullLiteral>] ModalContainer =
        inherit React.Component<Types.CommonProps, Types.Stateless>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] ModalContainerStatic =
        [<Emit "new $0($1...)">] abstract Create: props: Types.CommonProps -> ModalContainer

module __web_Network =
    let [<Import("","reactxp/web/Network")>] : ``.IExports`` = jsNative
    let [<Import("_default","reactxp")>] _default: Network = jsNative

    type [<AllowNullLiteral>] IExports =
        abstract Network: NetworkStatic

    type [<AllowNullLiteral>] Network =
        inherit RX.Network
        abstract isConnected: unit -> SyncTasks.Promise<bool>
        abstract getType: unit -> SyncTasks.Promise<Types.DeviceNetworkType>
        abstract _onEventOccured: obj with get, set

    type [<AllowNullLiteral>] NetworkStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> Network

module __web_Picker =
    let [<Import("","reactxp/web/Picker")>] : ``.IExports`` = jsNative

    type [<AllowNullLiteral>] IExports =
        abstract Picker: PickerStatic

    type [<AllowNullLiteral>] Picker =
        inherit RX.Picker
        abstract render: unit -> JSX.Element
        abstract _getStyles: obj with get, set
        abstract _onValueChange: obj with get, set

    type [<AllowNullLiteral>] PickerStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> Picker

module __web_Platform =
    let [<Import("","reactxp/web/Platform")>] : ``.IExports`` = jsNative
    let [<Import("_default","reactxp")>] _default: Platform = jsNative

    type [<AllowNullLiteral>] IExports =
        abstract Platform: PlatformStatic

    type [<AllowNullLiteral>] Platform =
        inherit RX.Platform
        abstract getType: unit -> Types.PlatformType
        abstract select: specifics: obj -> 'T option

    type [<AllowNullLiteral>] PlatformStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> Platform

module __web_Popup =
    let [<Import("","reactxp/web/Popup")>] : ``.IExports`` = jsNative
    let [<Import("_default","reactxp")>] _default: Popup = jsNative

    type [<AllowNullLiteral>] IExports =
        abstract Popup: PopupStatic

    type [<AllowNullLiteral>] Popup =
        inherit RX.Popup
        abstract show: options: Types.PopupOptions * popupId: string * ?delay: float -> bool
        abstract autoDismiss: popupId: string * ?delay: float -> unit
        abstract dismiss: popupId: string -> unit
        abstract dismissAll: unit -> unit
        abstract isDisplayed: ?popupId: string -> bool

    type [<AllowNullLiteral>] PopupStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> Popup

module __web_PopupContainerView =
    let [<Import("","reactxp/web/PopupContainerView")>] : ``.IExports`` = jsNative
    type PopupContainerViewBase = ___common_PopupContainerViewBase.PopupContainerViewBase
    type PopupContainerViewBaseProps = ___common_PopupContainerViewBase.PopupContainerViewBaseProps
    type PopupContainerViewContext = ___common_PopupContainerViewBase.PopupContainerViewContext

    type [<AllowNullLiteral>] IExports =
        abstract PopupContainerView: PopupContainerViewStatic

    type [<AllowNullLiteral>] PopupContainerViewProps =
        inherit PopupContainerViewBaseProps
        abstract style: React.CSSProperties with get, set
        abstract onMouseEnter: (React.MouseEvent<HTMLDivElement> -> unit) option with get, set
        abstract onMouseLeave: (React.MouseEvent<HTMLDivElement> -> unit) option with get, set

    type [<AllowNullLiteral>] PopupContainerView =
        inherit PopupContainerViewBase<PopupContainerViewProps, Types.Stateless>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] PopupContainerViewStatic =
        [<Emit "new $0($1...)">] abstract Create: props: PopupContainerViewProps * context: PopupContainerViewContext -> PopupContainerView

module __web_ReactXP =
    let [<Import("*","reactxp/web/ReactXP")>] reactXP: ReactXP.IExports = jsNative

    module ReactXP =

        type [<AllowNullLiteral>] IExports =
            abstract Accessibility: RXInterfaces.Accessibility
            abstract ActivityIndicator: obj
            abstract Alert: RXInterfaces.Alert
            abstract App: RXInterfaces.App
            abstract Button: obj
            abstract Picker: obj
            abstract Clipboard: RXInterfaces.Clipboard
            abstract GestureView: obj
            abstract Image: RXInterfaces.ImageConstructor
            abstract Input: RXInterfaces.Input
            abstract International: RXInterfaces.International
            abstract Link: obj
            abstract Linking: RXInterfaces.Linking
            abstract Location: RXInterfaces.Location
            abstract Modal: RXInterfaces.Modal
            abstract Network: RXInterfaces.Network
            abstract Platform: RXInterfaces.Platform
            abstract Popup: RXInterfaces.Popup
            abstract ScrollView: RXInterfaces.ScrollViewConstructor
            abstract StatusBar: RXInterfaces.StatusBar
            abstract Storage: RXInterfaces.Storage
            abstract Styles: RXInterfaces.Styles
            abstract Text: obj
            abstract TextInput: obj
            abstract UserInterface: RXInterfaces.UserInterface
            abstract UserPresence: RXInterfaces.UserPresence
            abstract View: obj
            abstract WebView: RXInterfaces.WebViewConstructor
            abstract createElement: obj
            abstract Children: React.ReactChildren
            abstract __spread: obj option

        type Accessibility =
            RXInterfaces.Accessibility

        type ActivityIndicator =
            RXInterfaces.ActivityIndicator

        type Alert =
            RXInterfaces.Alert

        type App =
            RXInterfaces.App

        type Button =
            RXInterfaces.Button

        type Picker =
            RXInterfaces.Picker

        type Clipboard =
            RXInterfaces.Clipboard

        type GestureView =
            RXInterfaces.GestureView

        type Image =
            RXInterfaces.Image

        type Input =
            RXInterfaces.Input

        type International =
            RXInterfaces.International

        type Link =
            RXInterfaces.Link

        type Linking =
            RXInterfaces.Linking

        type Location =
            RXInterfaces.Location

        type Modal =
            RXInterfaces.Modal

        type Network =
            RXInterfaces.Network

        type Platform =
            RXInterfaces.Platform

        type Popup =
            RXInterfaces.Popup

        type ScrollView =
            RXInterfaces.ScrollView

        type StatusBar =
            RXInterfaces.StatusBar

        type Storage =
            RXInterfaces.Storage

        type Styles =
            RXInterfaces.Styles

        type Text =
            RXInterfaces.Text

        type TextInput =
            RXInterfaces.TextInput

        type UserInterface =
            RXInterfaces.UserInterface

        type UserPresence =
            RXInterfaces.UserPresence

        type View =
            RXInterfaces.View

        type WebView =
            RXInterfaces.WebView

module __web_RootView =
    let [<Import("","reactxp/web/RootView")>] : ``.IExports`` = jsNative

    type [<AllowNullLiteral>] IExports =
        abstract PopupDescriptor: PopupDescriptorStatic
        abstract RootView: RootViewStatic

    type [<AllowNullLiteral>] PopupDescriptor =
        abstract popupId: string with get, set
        abstract popupOptions: Types.PopupOptions with get, set

    type [<AllowNullLiteral>] PopupDescriptorStatic =
        [<Emit "new $0($1...)">] abstract Create: popupId: string * popupOptions: Types.PopupOptions -> PopupDescriptor

    type [<AllowNullLiteral>] RootViewProps =
        abstract mainView: React.ReactNode option with get, set
        abstract modal: React.ReactElement<Types.ViewProps> option with get, set
        abstract activePopup: PopupDescriptor option with get, set
        abstract cachedPopup: ResizeArray<PopupDescriptor> option with get, set
        abstract autoDismiss: bool option with get, set
        abstract autoDismissDelay: float option with get, set
        abstract onDismissPopup: (unit -> unit) option with get, set
        abstract keyBoardFocusOutline: string option with get, set
        abstract mouseFocusOutline: string option with get, set
        abstract writingDirection: U3<string, string, string> option with get, set

    type [<AllowNullLiteral>] RootViewState =
        abstract isMeasuringPopup: bool with get, set
        abstract popupWidth: float with get, set
        abstract popupHeight: float with get, set
        abstract anchorPosition: Types.PopupPosition with get, set
        abstract anchorOffset: float with get, set
        abstract popupTop: float with get, set
        abstract popupLeft: float with get, set
        abstract constrainedPopupWidth: float with get, set
        abstract constrainedPopupHeight: float with get, set
        abstract isMouseInPopup: bool with get, set
        abstract focusClass: string option with get, set

    type [<AllowNullLiteral>] RootView =
        inherit React.Component<RootViewProps, RootViewState>
        abstract childContextTypes: React.ValidationMap<obj option> with get, set
        abstract _mountedComponent: obj with get, set
        abstract _hidePopupTimer: obj with get, set
        abstract _respositionPopupTimer: obj with get, set
        abstract _clickHandlerInstalled: obj with get, set
        abstract _keyboardHandlerInstalled: obj with get, set
        abstract _focusManager: obj with get, set
        abstract _isNavigatingWithKeyboardUpateTimer: obj with get, set
        abstract _shouldEnableKeyboardNavigationModeOnFocus: obj with get, set
        abstract _applicationIsNotActive: obj with get, set
        abstract _applicationIsNotActiveTimer: obj with get, set
        abstract _prevFocusedElement: obj with get, set
        abstract _updateKeyboardNavigationModeOnFocusTimer: obj with get, set
        abstract getChildContext: unit -> obj
        abstract _getInitialState: obj with get, set
        abstract componentWillReceiveProps: prevProps: RootViewProps -> unit
        abstract componentDidUpdate: prevProps: RootViewProps * prevState: RootViewState -> unit
        abstract componentDidMount: unit -> unit
        abstract componentWillUnmount: unit -> unit
        abstract _renderPopup: obj with get, set
        abstract render: unit -> JSX.Element
        abstract _onMount: (PopupContainerView option -> unit) with get, set
        abstract _tryClosePopup: obj with get, set
        abstract _determineIfClickOnElement: obj with get, set
        abstract _onMouseDownCapture: obj with get, set
        abstract _onKeyDownCapture: obj with get, set
        abstract _onFocusIn: obj with get, set
        abstract _onFocusOut: obj with get, set
        abstract _requestApplicationIsNotActive: obj with get, set
        abstract _cancelApplicationIsNotActive: obj with get, set
        abstract _updateKeyboardNavigationState: obj with get, set
        abstract _onKeyDown: obj with get, set
        abstract _onKeyUp: obj with get, set
        abstract _onMouseEnter: obj with get, set
        abstract _onMouseLeave: obj with get, set
        abstract _startHidePopupTimer: obj with get, set
        abstract _stopHidePopupTimer: obj with get, set
        abstract _dismissPopup: obj with get, set
        abstract _startRepositionPopupTimer: obj with get, set
        abstract _stopRepositionPopupTimer: obj with get, set
        abstract _recalcPosition: obj with get, set
        abstract _recalcInnerPosition: obj with get, set

    type [<AllowNullLiteral>] RootViewStatic =
        [<Emit "new $0($1...)">] abstract Create: props: RootViewProps -> RootView

module __web_ScrollView =
    let [<Import("","reactxp/web/ScrollView")>] : ``.IExports`` = jsNative

    type [<AllowNullLiteral>] IExports =
        abstract ScrollView: ScrollViewStatic

    type [<AllowNullLiteral>] ScrollView =
        inherit ViewBase<Types.ScrollViewProps, Types.Stateless>
        inherit RX.ScrollView
        abstract _mountedComponent: obj with get, set
        abstract _mounted: obj with get, set
        abstract _customScrollbar: obj with get, set
        abstract _customScrollbarEnabled: obj with get, set
        abstract _dragging: obj with get, set
        abstract componentDidUpdate: unit -> unit
        abstract render: unit -> JSX.Element
        abstract componentWillMount: unit -> unit
        abstract componentDidMount: unit -> unit
        abstract componentWillReceiveProps: newProps: Types.ScrollViewProps -> unit
        abstract componentWillUnmount: unit -> unit
        abstract _getContainer: unit -> HTMLElement option
        abstract _onScroll: obj with get, set
        abstract _onPropsChange: obj with get, set
        abstract createCustomScrollbarsIfNeeded: obj with get, set
        abstract _getContainerStyle: obj with get, set
        abstract _renderNormal: obj with get, set
        abstract _renderWithCustomScrollbar: obj with get, set
        abstract _onMount: (HTMLElement option -> unit) with get, set
        abstract setScrollTop: scrollTop: float * ?animate: bool -> unit
        abstract setScrollLeft: scrollLeft: float * ?animate: bool -> unit
        abstract addToScrollTop: deltaTop: float * animate: bool -> unit
        abstract addToScrollLeft: deltaLeft: float * animate: bool -> unit
        abstract _easeInOut: obj with get, set
        abstract _onTouchStart: obj with get, set
        abstract _onTouchEnd: obj with get, set

    type [<AllowNullLiteral>] ScrollViewStatic =
        [<Emit "new $0($1...)">] abstract Create: props: Types.ScrollViewProps -> ScrollView

module __web_ScrollViewConfig =
    let [<Import("","reactxp/web/ScrollViewConfig")>] : ``.IExports`` = jsNative
    let [<Import("_default","reactxp")>] _default: ScrollViewConfig = jsNative

    type [<AllowNullLiteral>] IExports =
        abstract ScrollViewConfig: ScrollViewConfigStatic

    /// ScrollViewConfig.ts
    /// 
    /// Copyright (c) Microsoft Corporation. All rights reserved.
    /// Licensed under the MIT license.
    /// 
    /// Web-specific scroll view configuration, required to avoid circular
    /// dependency between application and ScrollView.
    type [<AllowNullLiteral>] ScrollViewConfig =
        abstract _useCustomScrollbars: obj with get, set
        abstract setUseCustomScrollbars: value: bool -> unit
        abstract useCustomScrollbars: unit -> bool

    /// ScrollViewConfig.ts
    /// 
    /// Copyright (c) Microsoft Corporation. All rights reserved.
    /// Licensed under the MIT license.
    /// 
    /// Web-specific scroll view configuration, required to avoid circular
    /// dependency between application and ScrollView.
    type [<AllowNullLiteral>] ScrollViewConfigStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> ScrollViewConfig

module __web_StatusBar =
    let [<Import("","reactxp/web/StatusBar")>] : ``.IExports`` = jsNative
    let [<Import("_default","reactxp")>] _default: StatusBar = jsNative

    type [<AllowNullLiteral>] IExports =
        abstract StatusBar: StatusBarStatic

    type [<AllowNullLiteral>] StatusBar =
        inherit RX.StatusBar
        abstract isOverlay: unit -> bool
        abstract setBarStyle: style: U3<string, string, string> * animated: bool -> unit
        abstract setHidden: hidden: bool * showHideTransition: U2<string, string> -> unit
        abstract setNetworkActivityIndicatorVisible: value: bool -> unit
        abstract setBackgroundColor: color: string * animated: bool -> unit
        abstract setTranslucent: translucent: bool -> unit

    type [<AllowNullLiteral>] StatusBarStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> StatusBar

module __web_Storage =
    let [<Import("","reactxp/web/Storage")>] : ``.IExports`` = jsNative
    let [<Import("_default","reactxp")>] _default: Storage = jsNative

    type [<AllowNullLiteral>] IExports =
        abstract Storage: StorageStatic

    type [<AllowNullLiteral>] Storage =
        inherit RX.Storage
        abstract getItem: key: string -> SyncTasks.Promise<string option>
        abstract setItem: key: string * value: string -> SyncTasks.Promise<unit>
        abstract removeItem: key: string -> SyncTasks.Promise<unit>
        abstract clear: unit -> SyncTasks.Promise<unit>

    type [<AllowNullLiteral>] StorageStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> Storage

module __web_Styles =
    let [<Import("","reactxp/web/Styles")>] : ``.IExports`` = jsNative
    let [<Import("_default","reactxp")>] _default: Styles = jsNative

    type [<AllowNullLiteral>] IExports =
        abstract Styles: StylesStatic
        abstract memoize: func: 'T * ?resolver: (ResizeArray<obj option> -> obj option) -> 'T

    type [<AllowNullLiteral>] CssAliasMap =
        [<Emit "$0[$1]{{=$2}}">] abstract Item: prop: string -> string with get, set

    type [<AllowNullLiteral>] Styles =
        inherit RX.Styles
        abstract combine: ruleSet1: Types.StyleRuleSetRecursive<'S> option * ?ruleSet2: Types.StyleRuleSetRecursive<'S> -> Types.StyleRuleSetOrArray<'S> option
        abstract createViewStyle: ruleSet: Types.ViewStyle * ?cacheStyle: bool -> Types.ViewStyleRuleSet
        abstract createAnimatedViewStyle: ruleSet: Types.AnimatedViewStyle -> Types.AnimatedViewStyleRuleSet
        abstract createScrollViewStyle: ruleSet: Types.ScrollViewStyle * ?cacheStyle: bool -> Types.ScrollViewStyleRuleSet
        abstract createButtonStyle: ruleSet: Types.ButtonStyle * ?cacheStyle: bool -> Types.ButtonStyleRuleSet
        abstract createWebViewStyle: ruleSet: Types.WebViewStyle * ?cacheStyle: bool -> Types.WebViewStyleRuleSet
        abstract createTextStyle: ruleSet: Types.TextStyle * ?cacheStyle: bool -> Types.TextStyleRuleSet
        abstract createAnimatedTextStyle: ruleSet: Types.AnimatedTextStyle -> Types.AnimatedTextStyleRuleSet
        abstract createTextInputStyle: ruleSet: Types.TextInputStyle * ?cacheStyle: bool -> Types.TextInputStyleRuleSet
        abstract createAnimatedTextInputStyle: ruleSet: Types.AnimatedTextInputStyle -> Types.AnimatedTextInputStyleRuleSet
        abstract createLinkStyle: ruleSet: Types.LinkStyle * ?cacheStyle: bool -> Types.LinkStyleRuleSet
        abstract createImageStyle: ruleSet: Types.ImageStyle * ?cacheStyle: bool -> Types.ImageStyleRuleSet
        abstract createAnimatedImageStyle: ruleSet: Types.AnimatedImageStyle -> Types.AnimatedImageStyleRuleSet
        abstract createPickerStyle: ruleSet: Types.PickerStyle * ?cacheStyle: bool -> Types.PickerStyleRuleSet
        abstract _getCssPropertyAlias: obj with get, set
        abstract _createDummyElement: obj with get, set
        abstract _getCssPropertyAliasesJsStyle: obj with get, set
        abstract convertJsToCssStyle: prop: string -> string
        abstract _cssPropertyAliasesCssStyle: (unit -> CssAliasMap) with get, set
        abstract getCssPropertyAliasesCssStyle: unit -> obj
        abstract getParentComponentName: ``component``: obj option -> string
        abstract _adaptStyles: obj with get, set

    type [<AllowNullLiteral>] StylesStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> Styles

module __web_Text =
    let [<Import("","reactxp/web/Text")>] : ``.IExports`` = jsNative
    type FocusArbitratorProvider = ___common_utils_AutoFocusHelper.FocusArbitratorProvider
    type Text as TextBase = ___common_Interfaces.Text as TextBase

    type [<AllowNullLiteral>] IExports =
        abstract Text: TextStatic

    type [<AllowNullLiteral>] TextContext =
        abstract isRxParentAText: bool with get, set
        abstract focusArbitrator: FocusArbitratorProvider option with get, set

    type [<AllowNullLiteral>] Text =
        inherit TextBase
        abstract contextTypes: obj with get, set
        abstract context: TextContext with get, set
        abstract childContextTypes: React.ValidationMap<obj option> with get, set
        abstract _isMounted: obj with get, set
        abstract getChildContext: unit -> obj
        abstract render: unit -> JSX.Element
        abstract componentDidMount: unit -> unit
        abstract componentWillUnmount: unit -> unit
        abstract _getStyles: unit -> Types.TextStyleRuleSet
        abstract blur: unit -> unit
        abstract requestFocus: unit -> unit
        abstract focus: unit -> unit

    type [<AllowNullLiteral>] TextStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> Text

module __web_TextInput =
    let [<Import("","reactxp/web/TextInput")>] : ``.IExports`` = jsNative
    type FocusArbitratorProvider = ___common_utils_AutoFocusHelper.FocusArbitratorProvider

    type [<AllowNullLiteral>] IExports =
        abstract TextInput: TextInputStatic

    type [<AllowNullLiteral>] TextInputState =
        abstract inputValue: string option with get, set

    type [<AllowNullLiteral>] TextInputContext =
        abstract focusArbitrator: FocusArbitratorProvider option with get, set

    type [<AllowNullLiteral>] TextInput =
        inherit React.Component<Types.TextInputProps, TextInputState>
        abstract contextTypes: React.ValidationMap<obj option> with get, set
        abstract context: TextInputContext with get, set
        abstract _mountedComponent: obj with get, set
        abstract _selectionStart: obj with get, set
        abstract _selectionEnd: obj with get, set
        abstract _isFocused: obj with get, set
        abstract _ariaLiveEnabled: obj with get, set
        abstract componentWillReceiveProps: nextProps: Types.TextInputProps -> unit
        abstract componentDidMount: unit -> unit
        abstract render: unit -> JSX.Element
        abstract _onMount: obj with get, set
        abstract _onInput: obj with get, set
        abstract _onFocus: obj with get, set
        abstract _onBlur: obj with get, set
        abstract _getKeyboardType: obj with get, set
        abstract _onPaste: obj with get, set
        abstract _onInputChanged: obj with get, set
        abstract _checkSelectionChanged: obj with get, set
        abstract _onKeyDown: obj with get, set
        abstract _onScroll: obj with get, set
        abstract _focus: obj with get, set
        abstract blur: unit -> unit
        abstract requestFocus: unit -> unit
        abstract focus: unit -> unit
        abstract setAccessibilityFocus: unit -> unit
        abstract isFocused: unit -> bool
        abstract selectAll: unit -> unit
        abstract selectRange: start: float * ``end``: float -> unit
        abstract getSelectionRange: unit -> obj
        abstract setValue: value: string -> unit

    type [<AllowNullLiteral>] TextInputStatic =
        [<Emit "new $0($1...)">] abstract Create: props: Types.TextInputProps * context: TextInputContext -> TextInput

module __web_UserInterface =
    let [<Import("","reactxp/web/UserInterface")>] : ``.IExports`` = jsNative
    let [<Import("_default","reactxp")>] _default: UserInterface = jsNative

    type [<AllowNullLiteral>] IExports =
        abstract UserInterface: UserInterfaceStatic

    type [<AllowNullLiteral>] UserInterface =
        inherit RX.UserInterface
        abstract _isNavigatingWithKeyboard: obj with get, set
        abstract measureLayoutRelativeToWindow: ``component``: React.Component<obj option, obj option> -> SyncTasks.Promise<Types.LayoutInfo>
        abstract measureLayoutRelativeToAncestor: ``component``: React.Component<obj option, obj option> * ancestor: React.Component<obj option, obj option> -> SyncTasks.Promise<Types.LayoutInfo>
        abstract measureWindow: ?rootViewId: string -> Types.LayoutInfo
        abstract getContentSizeMultiplier: unit -> SyncTasks.Promise<float>
        abstract getMaxContentSizeMultiplier: unit -> SyncTasks.Promise<float>
        abstract setMaxContentSizeMultiplier: maxContentSizeMultiplier: float -> unit
        abstract isHighPixelDensityScreen: unit -> bool
        abstract getPixelRatio: unit -> float
        abstract setMainView: element: React.ReactElement<obj option> -> unit
        abstract registerRootView: viewKey: string * getComponentFunc: Function -> unit
        abstract useCustomScrollbars: ?enable: bool -> unit
        abstract dismissKeyboard: unit -> unit
        abstract enableTouchLatencyEvents: latencyThresholdMs: float -> unit
        abstract evaluateTouchLatency: e: Types.MouseEvent -> unit
        abstract isNavigatingWithKeyboard: unit -> bool
        abstract _keyboardNavigationStateChanged: obj with get, set

    type [<AllowNullLiteral>] UserInterfaceStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> UserInterface

module __web_UserPresence =
    let [<Import("","reactxp/web/UserPresence")>] : ``.IExports`` = jsNative
    let [<Import("instance","reactxp")>] instance: UserPresence = jsNative

    type [<AllowNullLiteral>] IExports =
        abstract UserPresence: UserPresenceStatic

    type [<AllowNullLiteral>] UserPresence =
        inherit RX.UserPresence
        abstract _isPresent: obj with get, set
        abstract isUserPresent: unit -> bool
        abstract _setUserPresent: obj with get, set
        abstract _handleWakeup: obj with get, set
        abstract _handleIdle: obj with get, set
        abstract _handleFocus: obj with get, set
        abstract _handleBlur: obj with get, set

    type [<AllowNullLiteral>] UserPresenceStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> UserPresence

module __web_View =
    let [<Import("","reactxp/web/View")>] : ``.IExports`` = jsNative
    type FocusArbitratorProvider = ___common_utils_AutoFocusHelper.FocusArbitratorProvider
    type FocusManager = __utils_FocusManager.FocusManager

    type [<AllowNullLiteral>] IExports =
        abstract View: ViewStatic

    type [<AllowNullLiteral>] ViewContext =
        abstract isRxParentAText: bool option with get, set
        abstract focusManager: FocusManager option with get, set
        abstract popupContainer: PopupContainerView option with get, set
        abstract focusArbitrator: FocusArbitratorProvider option with get, set

    type [<AllowNullLiteral>] View =
        inherit ViewBase<Types.ViewProps, Types.Stateless>
        abstract contextTypes: React.ValidationMap<obj option> with get, set
        abstract context: ViewContext with get, set
        abstract childContextTypes: React.ValidationMap<obj option> with get, set
        abstract _focusManager: obj with get, set
        abstract _limitFocusWithin: obj with get, set
        abstract _isFocusLimited: obj with get, set
        abstract _isFocusRestricted: obj with get, set
        abstract _focusArbitratorProvider: obj with get, set
        abstract _resizeDetectorAnimationFrame: obj with get, set
        abstract _resizeDetectorNodes: obj with get, set
        abstract _popupContainer: obj with get, set
        abstract _popupToken: obj with get, set
        abstract _renderResizeDetectorIfNeeded: obj with get, set
        abstract _resizeDetectorReset: obj with get, set
        abstract _resizeDetectorOnScroll: obj with get, set
        abstract getChildContext: unit -> ViewContext
        abstract _getContainer: unit -> HTMLElement option
        abstract _isHidden: obj with get, set
        abstract _updateFocusArbitratorProvider: obj with get, set
        abstract setFocusRestricted: restricted: bool -> unit
        abstract setFocusLimited: limited: bool -> unit
        abstract render: unit -> React.ReactElement<obj option>
        abstract componentWillReceiveProps: nextProps: Types.ViewProps -> unit
        abstract enableFocusManager: unit -> unit
        abstract disableFocusManager: unit -> unit
        abstract componentDidMount: unit -> unit
        abstract componentWillUnmount: unit -> unit
        abstract blur: unit -> unit
        abstract requestFocus: unit -> unit
        abstract focus: unit -> unit

    type [<AllowNullLiteral>] ViewStatic =
        [<Emit "new $0($1...)">] abstract Create: props: Types.ViewProps * context: ViewContext -> View

module __web_ViewBase =
    let [<Import("","reactxp/web/ViewBase")>] : ``.IExports`` = jsNative

    type [<AllowNullLiteral>] IExports =
        abstract ViewBase: ViewBaseStatic

    type [<AllowNullLiteral>] ViewBase<'P, 'S> =
        inherit RX.ViewBase<'P, 'S>
        abstract _viewCheckingTimer: obj with get, set
        abstract _isResizeHandlerInstalled: obj with get, set
        abstract _viewCheckingList: obj with get, set
        abstract _appActivationState: obj with get, set
        abstract render: unit -> JSX.Element
        abstract _getContainer: unit -> HTMLElement option
        abstract _isMounted: bool with get, set
        abstract _isPopupDisplayed: obj with get, set
        abstract componentWillReceiveProps: nextProps: Types.ViewProps -> unit
        abstract _layoutReportList: obj with get, set
        abstract _layoutReportingTimer: obj with get, set
        abstract _reportLayoutChange: obj with get, set
        abstract _lastX: float with get, set
        abstract _lastY: float with get, set
        abstract _lastWidth: float with get, set
        abstract _lastHeight: float with get, set
        abstract _checkAndReportLayout: unit -> SyncTasks.Promise<unit>
        abstract _checkViewCheckerBuild: obj with get, set
        abstract _checkViewCheckerUnbuild: obj with get, set
        abstract componentDidMount: unit -> unit
        abstract componentDidUpdate: unit -> unit
        abstract _onResize: obj with get, set
        abstract componentWillUnmount: unit -> unit

    type [<AllowNullLiteral>] ViewBaseStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> ViewBase<'P, 'S>
        abstract setActivationState: newState: Types.AppActivationState -> unit
        abstract _checkViews: unit -> unit
        abstract _reportDeferredLayoutChanges: unit -> unit

module __web_WebView =
    let [<Import("","reactxp/web/WebView")>] : ``.IExports`` = jsNative

    type [<AllowNullLiteral>] IExports =
        abstract WebView: WebViewStatic

    type [<AllowNullLiteral>] WebViewState =
        abstract postComplete: bool option with get, set
        abstract webFormIdentifier: string option with get, set
        abstract webFrameIdentifier: string option with get, set

    type [<AllowNullLiteral>] WebView =
        inherit React.Component<Types.WebViewProps, WebViewState>
        inherit RX.WebView
        abstract _webFrameNumber: obj with get, set
        abstract _onMessageReceived: obj with get, set
        abstract _messageListenerInstalled: obj with get, set
        abstract _mountedComponent: obj with get, set
        abstract _onMessageReceivedToken: obj with get, set
        abstract componentDidMount: unit -> unit
        abstract componentDidUpdate: prevProps: Types.WebViewProps * prevState: WebViewState -> unit
        abstract componentWillUnmount: unit -> unit
        abstract _getCustomHtml: obj with get, set
        abstract _setContents: obj with get, set
        abstract _installMessageListener: obj with get, set
        abstract _postRender: obj with get, set
        abstract render: unit -> JSX.Element
        abstract _onMount: (HTMLIFrameElement option -> unit) with get, set
        abstract _onLoad: obj with get, set
        abstract _sandboxToStringValue: obj with get, set
        abstract postMessage: message: string * ?targetOrigin: string -> unit
        abstract reload: unit -> unit
        abstract goBack: unit -> unit
        abstract goForward: unit -> unit

    type [<AllowNullLiteral>] WebViewStatic =
        [<Emit "new $0($1...)">] abstract Create: props: Types.WebViewProps -> WebView

module __web_window =
    let [<Import("_default","reactxp")>] _default: Window = jsNative

module __windows_Accessibility =
    let [<Import("","reactxp/windows/Accessibility")>] : ``.IExports`` = jsNative
    type Accessibility as NativeAccessibility = ___native_common_Accessibility.Accessibility as NativeAccessibility
    let [<Import("_default","reactxp")>] _default: Accessibility = jsNative

    type [<AllowNullLiteral>] IExports =
        abstract Accessibility: AccessibilityStatic

    type [<AllowNullLiteral>] Accessibility =
        inherit NativeAccessibility
        abstract _isHighContrast: obj with get, set
        abstract _updateIsHighContrast: obj with get, set
        abstract isHighContrastEnabled: unit -> bool

    type [<AllowNullLiteral>] AccessibilityStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> Accessibility

module __windows_AccessibilityAnnouncer =
    let [<Import("","reactxp/windows/AccessibilityAnnouncer")>] : ``.IExports`` = jsNative

    type [<AllowNullLiteral>] IExports =
        abstract AccessibilityAnnouncer: AccessibilityAnnouncerStatic

    type [<AllowNullLiteral>] AccessibilityAnnouncer =
        inherit React.Component<obj, obj>
        abstract _viewElement: obj with get, set
        abstract _announcementQueue: obj with get, set
        abstract _announcementQueueTimer: obj with get, set
        abstract _newAnnouncementEventChangedSubscription: obj with get, set
        abstract _lastAnnouncement: obj with get, set
        abstract componentWillUnmount: unit -> unit
        abstract render: unit -> JSX.Element
        abstract _onViewRef: obj with get, set
        abstract _tryDequeueAndAnnounce: obj with get, set
        abstract _dequeueAndPostAnnouncement: obj with get, set

    type [<AllowNullLiteral>] AccessibilityAnnouncerStatic =
        [<Emit "new $0($1...)">] abstract Create: props: AccessibilityAnnouncerStaticProps -> AccessibilityAnnouncer

    type [<AllowNullLiteral>] AccessibilityAnnouncerStaticProps =
        interface end

module __windows_AccessibilityUtil =
    let [<Import("","reactxp/windows/AccessibilityUtil")>] : ``.IExports`` = jsNative
    type AccessibilityPlatformUtil = ___common_AccessibilityUtil.AccessibilityPlatformUtil
    let [<Import("_default","reactxp")>] _default: AccessibilityUtil = jsNative

    type [<AllowNullLiteral>] IExports =
        abstract AccessibilityUtil: AccessibilityUtilStatic

    type [<AllowNullLiteral>] AccessibilityUtil =
        inherit AccessibilityPlatformUtil
        abstract setAccessibilityFocus: ``component``: React.Component<obj option, obj option> -> unit

    type [<AllowNullLiteral>] AccessibilityUtilStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> AccessibilityUtil

module __windows_App =
    let [<Import("","reactxp/windows/App")>] : ``.IExports`` = jsNative
    type ComponentProvider = React_native.ComponentProvider
    type App as AppCommon = ___native_common_App.App as AppCommon
    let [<Import("_default","reactxp")>] _default: App = jsNative

    type [<AllowNullLiteral>] IExports =
        abstract App: AppStatic

    type [<AllowNullLiteral>] App =
        inherit AppCommon
        abstract getRootViewFactory: unit -> ComponentProvider
        abstract getRootViewUsingPropsFactory: unit -> ComponentProvider

    type [<AllowNullLiteral>] AppStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> App

module __windows_Button =
    let [<Import("","reactxp/windows/Button")>] : ``.IExports`` = jsNative
    type ImportantForAccessibilityValue = ___native_common_AccessibilityUtil.ImportantForAccessibilityValue
    type Button as ButtonBase = ___native_common_Button.Button as ButtonBase
    type ButtonContext as ButtonContextBase = ___native_common_Button.ButtonContext as ButtonContextBase
    type FocusManagerFocusableComponent = ___native_desktop_utils_FocusManager.FocusManagerFocusableComponent

    type [<AllowNullLiteral>] IExports =
        abstract Button: ButtonStatic

    type [<AllowNullLiteral>] ButtonContext =
        inherit ButtonContextBase
        abstract isRxParentAContextMenuResponder: bool option with get, set
        abstract isRxParentAFocusableInSameFocusManager: bool option with get, set

    type [<AllowNullLiteral>] Button =
        inherit ButtonBase
        inherit React.ChildContextProvider<ButtonContext>
        inherit FocusManagerFocusableComponent
        abstract context: ButtonContext with get, set
        abstract childContextTypes: React.ValidationMap<obj option> with get, set
        abstract _isFocusedWithKeyboard: obj with get, set
        abstract _getContextMenuOffset: unit -> obj
        abstract _render: internalProps: RN.ViewProps * onMount: (obj option -> unit) -> JSX.Element
        abstract focus: unit -> unit
        abstract blur: unit -> unit
        abstract setNativeProps: nativeProps: RN.ViewProps -> unit
        abstract getChildContext: unit -> ButtonContext
        abstract _onAccessibilityTap: obj with get, set
        abstract _onKeyDown: obj with get, set
        abstract _onKeyUp: obj with get, set
        abstract _onFocus: obj with get, set
        abstract _onBlur: obj with get, set
        abstract _onHoverStart: (React.SyntheticEvent<obj option> -> unit) with get, set
        abstract _onHoverEnd: (React.SyntheticEvent<obj option> -> unit) with get, set
        abstract onFocus: unit -> unit
        abstract getTabIndex: unit -> float option
        abstract getImportantForAccessibility: unit -> ImportantForAccessibilityValue option
        abstract updateNativeAccessibilityProps: unit -> unit

    type [<AllowNullLiteral>] ButtonStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> Button

module __windows_GestureView =
    let [<Import("","reactxp/windows/GestureView")>] : ``.IExports`` = jsNative
    type GestureView as BaseGestureView = ___native_common_GestureView.GestureView as BaseGestureView

    type [<AllowNullLiteral>] IExports =
        abstract GestureView: GestureViewStatic

    type [<AllowNullLiteral>] GestureView =
        inherit BaseGestureView
        abstract _getPreferredPanRatio: unit -> float
        abstract _getEventTimestamp: e: Types.TouchEvent -> float

    type [<AllowNullLiteral>] GestureViewStatic =
        [<Emit "new $0($1...)">] abstract Create: props: Types.GestureViewProps -> GestureView

module __windows_Link =
    let [<Import("","reactxp/windows/Link")>] : ``.IExports`` = jsNative
    type ImportantForAccessibilityValue = ___native_common_AccessibilityUtil.ImportantForAccessibilityValue
    type FocusManagerFocusableComponent = ___native_desktop_utils_FocusManager.FocusManagerFocusableComponent
    type LinkBase = ___native_common_Link.LinkBase

    type [<AllowNullLiteral>] IExports =
        abstract Link: LinkStatic

    type [<AllowNullLiteral>] LinkState =
        abstract isRestrictedOrLimited: bool with get, set

    type [<AllowNullLiteral>] Link =
        inherit LinkBase<LinkState>
        inherit FocusManagerFocusableComponent
        abstract _getContextMenuOffset: unit -> obj
        abstract componentDidMount: unit -> unit
        abstract componentWillUnmount: unit -> unit
        abstract _restrictedOrLimitedCallback: obj with get, set
        abstract _render: internalProps: RN.TextProps * onMount: (obj option -> unit) -> JSX.Element
        abstract _renderLinkAsFocusableText: obj with get, set
        abstract _focusableElement: obj with get, set
        abstract _onFocusableRef: obj with get, set
        abstract _createFocusableTextProps: obj with get, set
        abstract _nativeHyperlinkElement: obj with get, set
        abstract _onNativeHyperlinkRef: obj with get, set
        abstract _renderLinkAsNativeHyperlink: obj with get, set
        abstract focus: unit -> unit
        abstract blur: unit -> unit
        abstract setNativeProps: nativeProps: RN.TextProps -> unit
        abstract requestFocus: unit -> unit
        abstract _isAvailableToFocus: obj with get, set
        abstract _onKeyDown: obj with get, set
        abstract _onKeyUp: obj with get, set
        abstract _onFocus: obj with get, set
        abstract onFocus: unit -> unit
        abstract getTabIndex: unit -> float option
        abstract getImportantForAccessibility: unit -> ImportantForAccessibilityValue option
        abstract updateNativeAccessibilityProps: unit -> unit

    type [<AllowNullLiteral>] LinkStatic =
        [<Emit "new $0($1...)">] abstract Create: props: Types.LinkProps -> Link

module __windows_ReactXP =
    let [<Import("*","reactxp/windows/ReactXP")>] reactXP: ReactXP.IExports = jsNative

    module ReactXP =

        type [<AllowNullLiteral>] IExports =
            abstract Accessibility: RXInterfaces.Accessibility
            abstract ActivityIndicator: obj
            abstract Alert: RXInterfaces.Alert
            abstract App: RXInterfaces.App
            abstract Button: obj
            abstract Picker: obj
            abstract Clipboard: RXInterfaces.Clipboard
            abstract GestureView: obj
            abstract Image: RXInterfaces.ImageConstructor
            abstract Input: RXInterfaces.Input
            abstract International: RXInterfaces.International
            abstract Link: obj
            abstract Linking: RXInterfaces.Linking
            abstract Location: RXInterfaces.Location
            abstract Modal: RXInterfaces.Modal
            abstract Network: RXInterfaces.Network
            abstract Platform: RXInterfaces.Platform
            abstract Popup: RXInterfaces.Popup
            abstract ScrollView: RXInterfaces.ScrollViewConstructor
            abstract StatusBar: RXInterfaces.StatusBar
            abstract Storage: RXInterfaces.Storage
            abstract Styles: RXInterfaces.Styles
            abstract Text: obj
            abstract TextInput: obj
            abstract UserInterface: RXInterfaces.UserInterface
            abstract UserPresence: RXInterfaces.UserPresence
            abstract View: obj
            abstract WebView: RXInterfaces.WebViewConstructor
            abstract Animated: RXInterfaces.Animated
            abstract __spread: obj option

        type Accessibility =
            RXInterfaces.Accessibility

        type ActivityIndicator =
            RXInterfaces.ActivityIndicator

        type Alert =
            RXInterfaces.Alert

        type App =
            RXInterfaces.App

        type Button =
            RXInterfaces.Button

        type Picker =
            RXInterfaces.Picker

        type Clipboard =
            RXInterfaces.Clipboard

        type GestureView =
            RXInterfaces.GestureView

        type Image =
            RXInterfaces.Image

        type Input =
            RXInterfaces.Input

        type International =
            RXInterfaces.International

        type Link =
            RXInterfaces.Link

        type Linking =
            RXInterfaces.Linking

        type Location =
            RXInterfaces.Location

        type Modal =
            RXInterfaces.Modal

        type Network =
            RXInterfaces.Network

        type Platform =
            RXInterfaces.Platform

        type Popup =
            RXInterfaces.Popup

        type ScrollView =
            RXInterfaces.ScrollView

        type StatusBar =
            RXInterfaces.StatusBar

        type Storage =
            RXInterfaces.Storage

        type Styles =
            RXInterfaces.Styles

        type Text =
            RXInterfaces.Text

        type TextInput =
            RXInterfaces.TextInput

        type UserInterface =
            RXInterfaces.UserInterface

        type UserPresence =
            RXInterfaces.UserPresence

        type View =
            RXInterfaces.View

        type WebView =
            RXInterfaces.WebView

module __windows_RootView =
    let [<Import("","reactxp/windows/RootView")>] : ``.IExports`` = jsNative
    type RootView as RootViewBase = ___native_desktop_RootView.RootView as RootViewBase
    type RootViewUsingProps as RootViewUsingPropsBase = ___native_desktop_RootView.RootViewUsingProps as RootViewUsingPropsBase
    type BaseRootViewProps = ___native_desktop_RootView.BaseRootViewProps
    type RootViewPropsWithMainViewType = ___native_desktop_RootView.RootViewPropsWithMainViewType
    type RootViewState = ___native_desktop_RootView.RootViewState
    type BaseRootView = ___native_desktop_RootView.BaseRootView

    type [<AllowNullLiteral>] IExports =
        abstract RootViewUsingStore: RootViewUsingStoreStatic
        abstract RootViewUsingProps: RootViewUsingPropsStatic

    type [<AllowNullLiteral>] RootViewUsingStore =
        inherit RootViewBase
        abstract renderTopView: content: JSX.Element -> JSX.Element
        abstract _renderAnnouncerView: unit -> JSX.Element

    type [<AllowNullLiteral>] RootViewUsingStoreStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> RootViewUsingStore

    type [<AllowNullLiteral>] RootViewUsingProps =
        inherit RootViewUsingPropsBase
        abstract renderTopView: content: JSX.Element -> JSX.Element
        abstract _renderAnnouncerView: unit -> JSX.Element

    type [<AllowNullLiteral>] RootViewUsingPropsStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> RootViewUsingProps

module __windows_ScrollView =
    let [<Import("","reactxp/windows/ScrollView")>] : ``.IExports`` = jsNative
    type ScrollView as ScrollViewBase = ___native_common_ScrollView.ScrollView as ScrollViewBase

    type [<AllowNullLiteral>] IExports =
        abstract ScrollView: ScrollViewStatic

    type [<AllowNullLiteral>] ScrollView =
        inherit ScrollViewBase
        abstract _render: props: Types.ScrollViewProps -> JSX.Element
        abstract _onKeyDown: obj with get, set

    type [<AllowNullLiteral>] ScrollViewStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> ScrollView

module __windows_StatusBar =
    let [<Import("","reactxp/windows/StatusBar")>] : ``.IExports`` = jsNative
    let [<Import("_default","reactxp")>] _default: StatusBar = jsNative

    type [<AllowNullLiteral>] IExports =
        abstract StatusBar: StatusBarStatic

    type [<AllowNullLiteral>] StatusBar =
        inherit RX.StatusBar
        abstract isOverlay: unit -> bool
        abstract setHidden: hidden: bool * showHideTransition: U2<string, string> -> unit
        abstract setBackgroundColor: color: string * animated: bool -> unit
        abstract setTranslucent: translucent: bool -> unit
        abstract setBarStyle: style: U3<string, string, string> * animated: bool -> unit
        abstract setNetworkActivityIndicatorVisible: value: bool -> unit

    type [<AllowNullLiteral>] StatusBarStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> StatusBar

module __windows_Text =
    let [<Import("","reactxp/windows/Text")>] : ``.IExports`` = jsNative
    type ImportantForAccessibilityValue = ___native_common_AccessibilityUtil.ImportantForAccessibilityValue
    type Text as TextBase = ___native_common_Text.Text as TextBase
    type TextContext as TextContextBase = ___native_common_Text.TextContext as TextContextBase
    type FocusManagerFocusableComponent = ___native_desktop_utils_FocusManager.FocusManagerFocusableComponent

    type [<AllowNullLiteral>] IExports =
        abstract Text: TextStatic

    type [<AllowNullLiteral>] TextContext =
        inherit TextContextBase
        abstract isRxParentAFocusableInSameFocusManager: bool option with get, set

    type [<AllowNullLiteral>] Text =
        inherit TextBase
        inherit React.ChildContextProvider<TextContext>
        inherit FocusManagerFocusableComponent
        abstract contextTypes: React.ValidationMap<obj option> with get, set
        abstract context: TextContext with get, set
        abstract childContextTypes: React.ValidationMap<obj option> with get, set
        abstract requestFocus: unit -> unit
        abstract getChildContext: unit -> TextContext
        abstract onFocus: unit -> unit
        abstract getTabIndex: unit -> float
        abstract getImportantForAccessibility: unit -> ImportantForAccessibilityValue option
        abstract updateNativeAccessibilityProps: unit -> unit

    type [<AllowNullLiteral>] TextStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> Text

module __windows_TextInput =
    let [<Import("","reactxp/windows/TextInput")>] : ``.IExports`` = jsNative
    type ImportantForAccessibilityValue = ___native_common_AccessibilityUtil.ImportantForAccessibilityValue
    type FocusManagerFocusableComponent = ___native_desktop_utils_FocusManager.FocusManagerFocusableComponent
    type TextInput as TextInputBase = ___native_common_TextInput.TextInput as TextInputBase

    type [<AllowNullLiteral>] IExports =
        abstract TextInput: TextInputStatic

    type [<AllowNullLiteral>] TextInput =
        inherit TextInputBase
        inherit FocusManagerFocusableComponent
        abstract _render: props: RN.TextInputProps * onMount: (obj option -> unit) -> JSX.Element
        abstract _onFocusEx: obj with get, set
        abstract onFocus: unit -> unit
        abstract getTabIndex: unit -> float
        abstract getImportantForAccessibility: unit -> ImportantForAccessibilityValue option
        abstract updateNativeAccessibilityProps: unit -> unit

    type [<AllowNullLiteral>] TextInputStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> TextInput

module __windows_View =
    let [<Import("","reactxp/windows/View")>] : ``.IExports`` = jsNative
    type ImportantForAccessibilityValue = ___native_common_AccessibilityUtil.ImportantForAccessibilityValue
    type View as ViewCommon = ___native_common_View.View as ViewCommon
    type ViewContext as ViewContextCommon = ___native_common_View.ViewContext as ViewContextCommon
    type FocusManagerFocusableComponent = ___native_desktop_utils_FocusManager.FocusManagerFocusableComponent
    type FocusManager = ___native_desktop_utils_FocusManager.FocusManager

    type [<AllowNullLiteral>] IExports =
        abstract View: ViewStatic

    type [<AllowNullLiteral>] ViewContext =
        inherit ViewContextCommon
        abstract isRxParentAText: bool option with get, set
        abstract focusManager: FocusManager option with get, set
        abstract popupContainer: PopupContainerView option with get, set
        abstract isRxParentAContextMenuResponder: bool option with get, set
        abstract isRxParentAFocusableInSameFocusManager: bool option with get, set

    type [<AllowNullLiteral>] View =
        inherit ViewCommon
        inherit React.ChildContextProvider<ViewContext>
        inherit FocusManagerFocusableComponent
        abstract contextTypes: React.ValidationMap<obj option> with get, set
        abstract context: ViewContext with get, set
        abstract childContextTypes: React.ValidationMap<obj option> with get, set
        abstract _getContextMenuOffset: unit -> obj
        abstract _onKeyDown: obj with get, set
        abstract _onMouseEnter: obj with get, set
        abstract _onMouseLeave: obj with get, set
        abstract _onMouseOver: obj with get, set
        abstract _onMouseMove: obj with get, set
        abstract _focusableElement: obj with get, set
        abstract _focusManager: obj with get, set
        abstract _limitFocusWithin: obj with get, set
        abstract _isFocusLimited: obj with get, set
        abstract _isFocusRestricted: obj with get, set
        abstract _popupContainer: obj with get, set
        abstract _popupToken: obj with get, set
        abstract componentWillReceiveProps: nextProps: Types.ViewProps -> unit
        abstract enableFocusManager: unit -> unit
        abstract disableFocusManager: unit -> unit
        abstract componentDidMount: unit -> unit
        abstract componentWillUnmount: unit -> unit
        abstract hasTrait: obj with get, set
        abstract _showContextMenu: obj with get, set
        abstract _buildInternalProps: props: Types.ViewProps -> unit
        abstract render: unit -> JSX.Element
        abstract _onFocusableRef: obj with get, set
        abstract requestFocus: unit -> unit
        abstract focus: unit -> unit
        abstract blur: unit -> unit
        abstract getChildContext: unit -> ViewContext
        abstract _isHidden: obj with get, set
        abstract setFocusRestricted: restricted: bool -> unit
        abstract setFocusLimited: limited: bool -> unit
        abstract _focusRestrictionCallback: obj with get, set
        abstract setNativeProps: nativeProps: RN.ViewProps -> unit
        abstract _isButton: viewProps: Types.ViewProps -> bool
        abstract _onFocusableKeyDown: obj with get, set
        abstract _onFocusableKeyUp: obj with get, set
        abstract _onFocus: obj with get, set
        abstract _onBlur: obj with get, set
        abstract onFocus: unit -> unit
        abstract getTabIndex: unit -> float option
        abstract getImportantForAccessibility: unit -> ImportantForAccessibilityValue option
        abstract updateNativeAccessibilityProps: unit -> unit

    type [<AllowNullLiteral>] ViewStatic =
        [<Emit "new $0($1...)">] abstract Create: props: Types.ViewProps * context: ViewContext -> View

module __common_utils_AutoFocusHelper =
    let [<Import("","reactxp/common/utils/AutoFocusHelper")>] : ``.IExports`` = jsNative

    type [<AllowNullLiteral>] IExports =
        abstract setSortAndFilterFunc: sortAndFilter: SortAndFilterFunc -> unit
        abstract FocusArbitratorProvider: FocusArbitratorProviderStatic

    type [<RequireQualifiedAccess>] FocusCandidateType =
        | Focus = 1
        | FocusFirst = 2

    type [<AllowNullLiteral>] FocusCandidateInternal =
        abstract ``component``: React.Component<obj option, obj option> with get, set
        abstract focus: (unit -> unit) with get, set
        abstract isAvailable: (unit -> bool) with get, set
        abstract ``type``: FocusCandidateType with get, set
        abstract accessibilityId: string option with get, set

    type [<AllowNullLiteral>] SortAndFilterFunc =
        [<Emit "$0($1...)">] abstract Invoke: candidates: ResizeArray<FocusCandidateInternal> -> ResizeArray<FocusCandidateInternal>

    type [<AllowNullLiteral>] FocusArbitratorProvider =
        abstract _id: obj with get, set
        abstract _parentArbitratorProvider: obj with get, set
        abstract _arbitratorCallback: obj with get, set
        abstract _candidates: obj with get, set
        abstract _pendingChildren: obj with get, set
        abstract _notifyParent: obj with get, set
        abstract _arbitrate: obj with get, set
        abstract _requestFocus: obj with get, set
        abstract _arbitrate: obj with get, set
        abstract setCallback: ?arbitrator: Types.FocusArbitrator -> unit

    type [<AllowNullLiteral>] FocusArbitratorProviderStatic =
        [<Emit "new $0($1...)">] abstract Create: ?view: Interfaces.View * ?arbitrator: Types.FocusArbitrator -> FocusArbitratorProvider
        abstract requestFocus: ``component``: React.Component<obj option, obj option> * focus: (unit -> unit) * isAvailable: (unit -> bool) * ?``type``: FocusCandidateType -> unit

module __common_utils_FocusManager =
    let [<Import("","reactxp/common/utils/FocusManager")>] : ``.IExports`` = jsNative

    type [<AllowNullLiteral>] IExports =
        abstract FocusManager: FocusManagerStatic
        abstract applyFocusableComponentMixin: Component: obj option * ?isConditionallyFocusable: Function * ?accessibleOnly: bool -> unit

    type [<RequireQualifiedAccess>] RestrictFocusType =
        | Unrestricted = 0
        | Restricted = 1
        | RestrictedFocusFirst = 2

    type [<AllowNullLiteral>] FocusableInternal =
        abstract focusableComponentId: string option with get, set

    type [<AllowNullLiteral>] FocusableComponentInternal =
        interface end

    type [<AllowNullLiteral>] StoredFocusableComponent =
        abstract id: string with get, set
        abstract numericId: float with get, set
        abstract ``component``: FocusableComponentInternal with get, set
        abstract onFocus: (unit -> unit) with get, set
        abstract accessibleOnly: bool with get, set
        abstract restricted: bool with get, set
        abstract limitedCount: float with get, set
        abstract limitedCountAccessible: float with get, set
        abstract removed: bool option with get, set
        abstract callbacks: ResizeArray<FocusableComponentStateCallback> option with get, set

    type [<AllowNullLiteral>] FocusableComponentStateCallback =
        [<Emit "$0($1...)">] abstract Invoke: restrictedOrLimited: bool -> unit

    type [<AllowNullLiteral>] FocusManagerRestrictionStateCallback =
        [<Emit "$0($1...)">] abstract Invoke: restricted: RestrictFocusType -> unit

    type [<AllowNullLiteral>] FocusManager =
        abstract _restrictionStack: obj with get, set
        abstract _currentRestrictionOwner: FocusManager option with get, set
        abstract _restoreRestrictionTimer: obj with get, set
        abstract _pendingPrevFocusedComponent: obj with get, set
        abstract _currentFocusedComponent: StoredFocusableComponent option with get, set
        abstract _allFocusableComponents: obj with get, set
        abstract _skipFocusCheck: bool with get, set
        abstract _resetFocusTimer: float option with get, set
        abstract _parent: obj with get, set
        abstract _isFocusLimited: obj with get, set
        abstract _currentRestrictType: obj with get, set
        abstract _prevFocusedComponent: obj with get, set
        abstract _myFocusableComponentIds: obj with get, set
        abstract _restrictionStateCallback: obj with get, set
        abstract addFocusListenerOnComponent: ``component``: FocusableComponentInternal * onFocus: (unit -> unit) -> unit
        abstract removeFocusListenerFromComponent: ``component``: FocusableComponentInternal * onFocus: (unit -> unit) -> unit
        abstract focusComponent: ``component``: FocusableComponentInternal -> bool
        abstract resetFocus: focusFirstWhenNavigatingWithKeyboard: bool -> unit
        abstract _updateComponentFocusRestriction: storedComponent: StoredFocusableComponent -> unit
        abstract addFocusableComponent: ``component``: FocusableComponentInternal * ?accessibleOnly: bool -> unit
        abstract removeFocusableComponent: ``component``: FocusableComponentInternal -> unit
        abstract restrictFocusWithin: restrictType: RestrictFocusType * ?noFocusReset: bool -> unit
        abstract removeFocusRestriction: unit -> unit
        abstract limitFocusWithin: limitType: Types.LimitFocusType -> unit
        abstract removeFocusLimitation: unit -> unit
        abstract release: unit -> unit
        abstract setRestrictionStateCallback: callback: FocusManagerRestrictionStateCallback option -> unit
        abstract _getStoredComponent: obj with get, set
        abstract _removeFocusRestriction: obj with get, set
        abstract _clearRestoreRestrictionTimeout: obj with get, set

    type [<AllowNullLiteral>] FocusManagerStatic =
        [<Emit "new $0($1...)">] abstract Create: parent: FocusManager option -> FocusManager
        abstract subscribe: ``component``: FocusableComponentInternal * callback: FocusableComponentStateCallback -> unit
        abstract unsubscribe: ``component``: FocusableComponentInternal * callback: FocusableComponentStateCallback -> unit
        abstract isComponentFocusRestrictedOrLimited: ``component``: FocusableComponentInternal -> bool
        abstract getCurrentFocusedComponent: unit -> string option
        abstract _callFocusableComponentStateChangeCallbacks: storedComponent: StoredFocusableComponent * restrictedOrLimited: bool -> unit

module __common_utils_Timers =
    let [<Import("","reactxp/common/utils/Timers")>] : ``.IExports`` = jsNative

    type [<AllowNullLiteral>] IExports =
        abstract Timers: TimersStatic

    /// Timers.ts
    /// 
    /// Copyright (c) Microsoft Corporation. All rights reserved.
    /// Licensed under the MIT license.
    /// 
    /// Utility functions for creating timers. We wrap the normal
    /// global timer methods because they are defined in both
    /// the node and lib type definition files, and the definitions
    /// don't match. Depending on which one TypeScript picks up,
    /// we can get compiler errors.
    type [<AllowNullLiteral>] Timers =
        interface end

    /// Timers.ts
    /// 
    /// Copyright (c) Microsoft Corporation. All rights reserved.
    /// Licensed under the MIT license.
    /// 
    /// Utility functions for creating timers. We wrap the normal
    /// global timer methods because they are defined in both
    /// the node and lib type definition files, and the definitions
    /// don't match. Depending on which one TypeScript picks up,
    /// we can get compiler errors.
    type [<AllowNullLiteral>] TimersStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> Timers
        abstract clearInterval: handle: float -> unit
        abstract clearTimeout: handle: float -> unit
        abstract setInterval: handler: (unit -> unit) * timeout: float -> float
        abstract setTimeout: handler: (unit -> unit) * timeout: float -> float

module __native_common_utils_EventHelpers =
    let [<Import("","reactxp/native-common/utils/EventHelpers")>] : ``.IExports`` = jsNative
    let [<Import("_default","reactxp")>] _default: EventHelpers = jsNative

    type [<AllowNullLiteral>] IExports =
        abstract EventHelpers: EventHelpersStatic

    type [<AllowNullLiteral>] EventHelpers =
        abstract toKeyboardEvent: e: Types.SyntheticEvent -> Types.KeyboardEvent
        abstract toFocusEvent: e: Types.SyntheticEvent -> Types.FocusEvent
        abstract toMouseEvent: e: Types.SyntheticEvent -> Types.MouseEvent
        abstract toDragEvent: e: Types.SyntheticEvent -> Types.DragEvent
        abstract toMouseButton: e: Types.TouchEvent -> float
        abstract isRightMouseButton: e: Types.SyntheticEvent -> bool
        abstract keyboardToMouseEvent: e: Types.KeyboardEvent * layoutInfo: Types.LayoutInfo * contextMenuOffset: EventHelpersKeyboardToMouseEventContextMenuOffset -> Types.MouseEvent

    type [<AllowNullLiteral>] EventHelpersKeyboardToMouseEventContextMenuOffset =
        abstract x: float with get, set
        abstract y: float with get, set

    type [<AllowNullLiteral>] EventHelpersStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> EventHelpers

module __native_desktop_utils_FocusManager =
    let [<Import("","reactxp/native-desktop/utils/FocusManager")>] : ``.IExports`` = jsNative
    type FocusManager as FocusManagerBase = ______common_utils_FocusManager.FocusManager as FocusManagerBase
    type FocusableComponentInternal as FocusableComponentInternalBase = ______common_utils_FocusManager.FocusableComponentInternal as FocusableComponentInternalBase
    type StoredFocusableComponent as StoredFocusableComponentBase = ______common_utils_FocusManager.StoredFocusableComponent as StoredFocusableComponentBase
    type ImportantForAccessibilityValue = ______native_common_AccessibilityUtil.ImportantForAccessibilityValue
    type FocusableComponentStateCallback = ______common_utils_FocusManager.FocusableComponentStateCallback

    type [<AllowNullLiteral>] IExports =
        abstract FocusManager: FocusManagerStatic
        abstract applyFocusableComponentMixin: Component: obj option * ?isConditionallyFocusable: Function * ?accessibleOnly: bool -> unit

    type [<RequireQualifiedAccess>] OverrideType =
        | None = 0
        | Accessible = 1
        | Limited = 2

    type [<AllowNullLiteral>] StoredFocusableComponent =
        inherit StoredFocusableComponentBase
        abstract curOverrideType: OverrideType option with get, set

    type [<AllowNullLiteral>] FocusManagerFocusableComponent =
        abstract getTabIndex: unit -> float option
        abstract getImportantForAccessibility: unit -> ImportantForAccessibilityValue option
        abstract onFocus: unit -> unit
        abstract focus: unit -> unit
        abstract updateNativeAccessibilityProps: unit -> unit

    type [<AllowNullLiteral>] FocusableComponentInternal =
        inherit FocusManagerFocusableComponent
        inherit FocusableComponentInternalBase
        abstract tabIndexOverride: float option with get, set
        abstract tabIndexLocalOverride: float option with get, set
        abstract tabIndexLocalOverrideTimer: float option with get, set
        abstract importantForAccessibilityOverride: string option with get, set
        abstract onFocusSink: (unit -> unit) option with get, set

    type [<AllowNullLiteral>] FocusManager =
        inherit FocusManagerBase
        abstract addFocusListenerOnComponent: ``component``: FocusableComponentInternal * onFocus: (unit -> unit) -> unit
        abstract removeFocusListenerFromComponent: ``component``: FocusableComponentInternal * onFocus: (unit -> unit) -> unit
        abstract focusComponent: ``component``: FocusableComponentInternal -> bool
        abstract focusFirst: obj with get, set
        abstract resetFocus: focusFirstWhenNavigatingWithKeyboard: bool -> unit
        abstract _updateComponentFocusRestriction: storedComponent: StoredFocusableComponent -> unit
        abstract _updateComponentTabIndexAndIFAOverrides: obj with get, set

    type [<AllowNullLiteral>] FocusManagerStatic =
        [<Emit "new $0($1...)">] abstract Create: parent: FocusManager option -> FocusManager

module __web_animated_executeTransition =
    let [<Import("","reactxp/web/animated/executeTransition")>] : ``.IExports`` = jsNative

    type [<AllowNullLiteral>] IExports =
        abstract executeTransition: element: HTMLElement * transitions: ResizeArray<TransitionSpec> * ``done``: (unit -> unit) -> unit

    /// executeTransition.tsx
    /// 
    /// Copyright (c) Microsoft Corporation. All rights reserved.
    /// Licensed under the MIT license.
    /// 
    /// Provides a convenient API for applying a CSS transition to a DOM element and
    /// notifying when the transition is complete.
    type [<AllowNullLiteral>] TransitionSpec =
        abstract property: string with get, set
        abstract duration: float with get, set
        abstract timing: string option with get, set
        abstract delay: float option with get, set
        abstract from: obj option with get, set
        abstract ``to``: obj option with get, set

module __web_listAnimations_AnimateListEdits =
    let [<Import("","reactxp/web/listAnimations/AnimateListEdits")>] : ``.IExports`` = jsNative

    type [<AllowNullLiteral>] IExports =
        abstract AnimateListEdits: AnimateListEditsStatic

    type [<AllowNullLiteral>] AnimateListEditsProps =
        abstract animateChildEnter: bool option with get, set
        abstract animateChildLeave: bool option with get, set
        abstract animateChildMove: bool option with get, set

    type [<AllowNullLiteral>] AnimateListEdits =
        inherit React.Component<AnimateListEditsProps, Types.Stateless>
        abstract _handleWillAnimate: edits: MonitorListEdits.Edits * ``done``: (unit -> unit) -> unit
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] AnimateListEditsStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> AnimateListEdits

module __web_listAnimations_MonitorListEdits =
    let [<Import("","reactxp/web/listAnimations/MonitorListEdits")>] : ``.IExports`` = jsNative

    type [<AllowNullLiteral>] IExports =
        abstract MonitorListEdits: MonitorListEditsStatic

    type [<AllowNullLiteral>] AddEdit =
        abstract element: U2<React.Component<obj option, obj option>, Element> with get, set

    type [<AllowNullLiteral>] MoveEdit =
        abstract element: U2<React.Component<obj option, obj option>, Element> with get, set
        abstract leftDelta: float with get, set
        abstract topDelta: float with get, set

    type [<AllowNullLiteral>] RemoveEdit =
        abstract element: U2<React.Component<obj option, obj option>, Element> with get, set
        abstract leftDelta: float with get, set
        abstract topDelta: float with get, set

    type [<AllowNullLiteral>] Edits =
        abstract added: ResizeArray<AddEdit> with get, set
        abstract moved: ResizeArray<MoveEdit> with get, set
        abstract removed: ResizeArray<RemoveEdit> with get, set

    type [<AllowNullLiteral>] MonitorListEditsProps =
        inherit React.HTMLAttributes<obj option>
        abstract componentWillAnimate: (Edits -> (unit -> unit) -> unit) with get, set
        abstract testId: string option with get, set

    type [<AllowNullLiteral>] MonitorListEdits =
        inherit React.Component<MonitorListEditsProps, Types.Stateless>
        abstract _itemRefs: obj with get, set
        abstract _refReplacementCache: obj with get, set
        abstract _isMounted: obj with get, set
        abstract _childrenKeys: obj with get, set
        abstract _childrenMap: obj with get, set
        abstract _childrenToRender: obj with get, set
        abstract _phase: obj with get, set
        abstract _willAnimatePhaseInfo: obj with get, set
        abstract componentWillMount: unit -> unit
        abstract componentDidMount: unit -> unit
        abstract componentWillUnmount: unit -> unit
        abstract shouldComponentUpdate: unit -> bool
        abstract componentWillUpdate: nextProps: MonitorListEditsProps -> unit
        abstract render: unit -> JSX.Element
        abstract componentDidUpdate: prevProps: MonitorListEditsProps -> unit
        abstract _saveRef: obj with get, set

    type [<AllowNullLiteral>] MonitorListEditsStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> MonitorListEdits

module __web_utils_AppVisibilityUtils =
    let [<Import("","reactxp/web/utils/AppVisibilityUtils")>] : ``.IExports`` = jsNative
    let [<Import("_default","reactxp")>] _default: AppVisibilityUtils = jsNative

    type [<AllowNullLiteral>] IExports =
        abstract AppVisibilityUtils: AppVisibilityUtilsStatic

    type [<AllowNullLiteral>] AppVisibilityUtils =
        abstract _isIdle: obj with get, set
        abstract _timer: obj with get, set
        abstract onFocusedEvent: SubscribableEvent<(unit -> unit)>
        abstract onBlurredEvent: SubscribableEvent<(unit -> unit)>
        abstract onAppForegroundedEvent: SubscribableEvent<(unit -> unit)>
        abstract onAppBackgroundedEvent: SubscribableEvent<(unit -> unit)>
        abstract onIdleEvent: SubscribableEvent<(unit -> unit)>
        abstract onWakeUpEvent: SubscribableEvent<(unit -> unit)>
        abstract hasFocusAndActive: unit -> bool
        abstract hasFocus: unit -> bool
        abstract isAppInForeground: unit -> bool
        abstract _trackIdleStatus: obj with get, set
        abstract _wakeUpAndSetTimerForIdle: obj with get, set
        abstract _onFocus: obj with get, set
        abstract _onBlur: obj with get, set
        abstract _onAppVisibilityChanged: obj with get, set
        abstract _onWakeUp: obj with get, set
        abstract _onIdle: obj with get, set

    type [<AllowNullLiteral>] AppVisibilityUtilsStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> AppVisibilityUtils

module __web_utils_FocusManager =
    let [<Import("","reactxp/web/utils/FocusManager")>] : ``.IExports`` = jsNative
    type FocusManager as FocusManagerBase = ______common_utils_FocusManager.FocusManager as FocusManagerBase
    type FocusableComponentInternal = ______common_utils_FocusManager.FocusableComponentInternal
    type StoredFocusableComponent as StoredFocusableComponentBase = ______common_utils_FocusManager.StoredFocusableComponent as StoredFocusableComponentBase
    type FocusCandidateInternal = ______common_utils_AutoFocusHelper.FocusCandidateInternal
    type FocusableComponentStateCallback = ______common_utils_FocusManager.FocusableComponentStateCallback

    type [<AllowNullLiteral>] IExports =
        abstract FocusManager: FocusManagerStatic
        abstract applyFocusableComponentMixin: Component: obj option * ?isConditionallyFocusable: Function -> unit

    type [<AllowNullLiteral>] StoredFocusableComponent =
        inherit StoredFocusableComponentBase
        abstract origTabIndex: float option with get, set
        abstract origAriaHidden: string option with get, set
        abstract curTabIndex: float option with get, set
        abstract curAriaHidden: bool option with get, set

    type [<AllowNullLiteral>] FocusManager =
        inherit FocusManagerBase
        abstract _setTabIndexTimer: obj with get, set
        abstract _setTabIndexElement: obj with get, set
        abstract _lastFocusedProgrammatically: obj with get, set
        abstract addFocusListenerOnComponent: ``component``: FocusableComponentInternal * onFocus: (unit -> unit) -> unit
        abstract removeFocusListenerFromComponent: ``component``: FocusableComponentInternal * onFocus: (unit -> unit) -> unit
        abstract focusComponent: ``component``: FocusableComponentInternal -> bool
        abstract _isComponentAvailable: obj with get, set
        abstract _getFirstFocusable: obj with get, set
        abstract resetFocus: focusFirstWhenNavigatingWithKeyboard: bool -> unit
        abstract _updateComponentFocusRestriction: storedComponent: StoredFocusableComponent -> unit
        abstract _setTabIndex: obj with get, set
        abstract _setAriaHidden: obj with get, set

    type [<AllowNullLiteral>] FocusManagerStatic =
        [<Emit "new $0($1...)">] abstract Create: parent: FocusManager option -> FocusManager
        abstract initListeners: unit -> unit
        abstract setLastFocusedProgrammatically: element: HTMLElement option -> unit
        abstract getLastFocusedProgrammatically: ?reset: bool -> HTMLElement option
        abstract focusFirst: ?last: bool -> unit
        abstract sortAndFilterAutoFocusCandidates: candidates: ResizeArray<FocusCandidateInternal> -> ResizeArray<FocusCandidateInternal>

module __web_utils_MouseResponder =
    let [<Import("","reactxp/web/utils/MouseResponder")>] : ``.IExports`` = jsNative

    type [<AllowNullLiteral>] IExports =
        abstract MouseResponder: MouseResponderStatic

    type [<AllowNullLiteral>] MouseResponderConfig =
        abstract id: float with get, set
        abstract target: HTMLElement with get, set
        abstract shouldBecomeFirstResponder: (MouseEvent -> Types.PanGestureState -> bool) option with get, set
        abstract onMove: (MouseEvent -> Types.PanGestureState -> unit) option with get, set
        abstract onTerminate: (MouseEvent -> Types.PanGestureState -> unit) option with get, set

    type [<AllowNullLiteral>] MouseResponderSubscription =
        abstract dispose: unit -> unit

    type [<AllowNullLiteral>] MouseResponder =
        abstract _currentResponder: obj with get, set
        abstract _pendingGestureState: obj with get, set
        abstract _initialized: obj with get, set
        abstract _responders: obj with get, set
        abstract _initializeEventHandlers: obj with get, set
        abstract _removeEventHandlers: obj with get, set
        abstract _onMouseDown: obj with get, set
        abstract _onMouseMove: obj with get, set
        abstract _onMouseUp: obj with get, set
        abstract _calcVelocity: obj with get, set

    type [<AllowNullLiteral>] MouseResponderStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> MouseResponder
        abstract create: config: MouseResponderConfig -> MouseResponderSubscription

module __web_utils_restyleForInlineText =
    let [<Import("","reactxp/web/utils/restyleForInlineText")>] : ``.IExports`` = jsNative

    type [<AllowNullLiteral>] IExports =
        abstract restyleForInlineText: reactElement: React.ReactElement<obj option> -> React.ReactElement<obj option>

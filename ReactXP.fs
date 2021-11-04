// ts2fable 0.0.0
module rec ReactXP

#nowarn "3390" // disable warnings for invalid XML comments

open System
open Fable.Core
open Fable.Core.JS
open Browser.Types

type Array<'T> = System.Collections.Generic.IList<'T>
type Error = System.Exception
type Function = System.Action

module ReactXP = __web_ReactXP

module __android_Accessibility =
    type NativeAccessibility = __native_common_Accessibility.Accessibility

    type [<AllowNullLiteral>] IExports =
        abstract Accessibility: AccessibilityStatic
        abstract _default: Accessibility

    type [<AllowNullLiteral>] Accessibility =
        inherit NativeAccessibility
        abstract announceForAccessibility: announcement: string -> unit

    type [<AllowNullLiteral>] AccessibilityStatic =
        [<EmitConstructor>] abstract Create: unit -> Accessibility

module __android_AccessibilityUtil =
    type CommonAccessibilityNativeUtil = __common_AccessibilityUtil.AccessibilityPlatformUtil

    type [<AllowNullLiteral>] IExports =
        abstract AccessibilityUtil: AccessibilityUtilStatic
        abstract _default: AccessibilityUtil

    type [<AllowNullLiteral>] AccessibilityUtil =
        inherit CommonAccessibilityNativeUtil
        abstract setAccessibilityFocus: ``component``: React.Component<obj option, obj option> -> unit

    type [<AllowNullLiteral>] AccessibilityUtilStatic =
        [<EmitConstructor>] abstract Create: unit -> AccessibilityUtil

module __android_GestureView =
    type BaseGestureView = __native_common_GestureView.GestureView
    type Types = __common_Interfaces.Types

    type [<AllowNullLiteral>] IExports =
        abstract GestureView: GestureViewStatic

    type [<AllowNullLiteral>] GestureView =
        inherit BaseGestureView
        abstract _getPreferredPanRatio: unit -> float
        abstract _getEventTimestamp: e: Types.TouchEvent -> float

    type [<AllowNullLiteral>] GestureViewStatic =
        [<EmitConstructor>] abstract Create: props: Types.GestureViewProps -> GestureView

module __android_Image =
    module RN = React_native
    type CommonImage = __native_common_Image.Image

    type [<AllowNullLiteral>] IExports =
        abstract Image: ImageStatic

    type [<AllowNullLiteral>] Image =
        inherit CommonImage
        abstract _getAdditionalProps: unit -> RN.ImagePropertiesAndroid

    type [<AllowNullLiteral>] ImageStatic =
        [<EmitConstructor>] abstract Create: unit -> Image

module __android_ReactXP =
    let [<ImportAll("reactxp/android/ReactXP")>] reactXP: ReactXP.IExports = jsNative

    module ReactXP =

        type [<AllowNullLiteral>] IExports =
            abstract Accessibility: RXInterfaces.Accessibility with get, set
            abstract ActivityIndicator: obj with get, set
            abstract Alert: RXInterfaces.Alert with get, set
            abstract App: RXInterfaces.App with get, set
            abstract Button: obj with get, set
            abstract Picker: obj with get, set
            abstract Clipboard: RXInterfaces.Clipboard with get, set
            abstract GestureView: obj with get, set
            abstract Image: RXInterfaces.ImageConstructor with get, set
            abstract Input: RXInterfaces.Input with get, set
            abstract International: RXInterfaces.International with get, set
            abstract Link: obj with get, set
            abstract Linking: RXInterfaces.Linking with get, set
            abstract Location: RXInterfaces.Location with get, set
            abstract Modal: RXInterfaces.Modal with get, set
            abstract Network: RXInterfaces.Network with get, set
            abstract Platform: RXInterfaces.Platform with get, set
            abstract Popup: RXInterfaces.Popup with get, set
            abstract ScrollView: RXInterfaces.ScrollViewConstructor with get, set
            abstract StatusBar: RXInterfaces.StatusBar with get, set
            abstract Storage: RXInterfaces.Storage with get, set
            abstract Styles: RXInterfaces.Styles with get, set
            abstract Text: obj with get, set
            abstract TextInput: obj with get, set
            abstract UserInterface: RXInterfaces.UserInterface with get, set
            abstract UserPresence: RXInterfaces.UserPresence with get, set
            abstract View: obj with get, set
            abstract WebView: RXInterfaces.WebViewConstructor with get, set
            abstract Animated: RXInterfaces.Animated
            abstract __spread: obj option with get, set

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
    module RX = ___common_Interfaces

    type [<AllowNullLiteral>] IExports =
        abstract StatusBar: StatusBarStatic
        abstract _default: StatusBar

    type [<AllowNullLiteral>] StatusBar =
        inherit RX.StatusBar
        abstract isOverlay: unit -> bool
        abstract setHidden: hidden: bool * showHideTransition: StatusBarSetHiddenShowHideTransition -> unit
        abstract setBackgroundColor: color: string * animated: bool -> unit
        abstract setTranslucent: translucent: bool -> unit
        abstract setBarStyle: style: StatusBarSetBarStyleStyle * animated: bool -> unit
        abstract setNetworkActivityIndicatorVisible: value: bool -> unit

    type [<StringEnum>] [<RequireQualifiedAccess>] StatusBarSetHiddenShowHideTransition =
        | Slide
        | Fade

    type [<StringEnum>] [<RequireQualifiedAccess>] StatusBarSetBarStyleStyle =
        | Default
        | [<CompiledName "light-content">] LightContent
        | [<CompiledName "dark-content">] DarkContent

    type [<AllowNullLiteral>] StatusBarStatic =
        [<EmitConstructor>] abstract Create: unit -> StatusBar

module __android_Text =
    type Types = __common_Interfaces.Types
    type CommonText = __native_common_Text.Text

    type [<AllowNullLiteral>] IExports =
        abstract Text: TextStatic

    type [<AllowNullLiteral>] Text =
        inherit CommonText
        abstract _getStyles: unit -> Types.StyleRuleSetRecursiveArray<Types.TextStyleRuleSet>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] TextStatic =
        [<EmitConstructor>] abstract Create: unit -> Text

module __common_Accessibility =
    module RX = ___common_Interfaces

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
        [<EmitConstructor>] abstract Create: unit -> Accessibility

module __common_AccessibilityUtil =
    type Types = __common_Interfaces.Types

    type [<AllowNullLiteral>] IExports =
        abstract ImportantForAccessibilityMap: IExportsImportantForAccessibilityMap
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
        [<EmitConstructor>] abstract Create: unit -> AccessibilityPlatformUtil

    type [<AllowNullLiteral>] AccessibilityUtil =
        abstract isHidden: importantForAccessibility: Types.ImportantForAccessibility option -> obj
        abstract importantForAccessibilityToString: importantForAccessibility: Types.ImportantForAccessibility option * ?defaultImportantForAccessibility: Types.ImportantForAccessibility -> ImportantForAccessibilityValue option
        abstract accessibilityLiveRegionToString: liveRegion: Types.AccessibilityLiveRegion -> string option
        abstract accessibilityTraitToString: ``trait``: U2<Types.AccessibilityTrait, ResizeArray<Types.AccessibilityTrait>> * ?defaultTrait: Types.AccessibilityTrait -> U2<string, ResizeArray<string>> option

    type [<AllowNullLiteral>] AccessibilityUtilStatic =
        [<EmitConstructor>] abstract Create: unit -> AccessibilityUtil

    type [<AllowNullLiteral>] IExportsImportantForAccessibilityMap =
        abstract ``[Types.ImportantForAccessibility.Auto]``: ImportantForAccessibilityValue with get, set
        abstract ``[Types.ImportantForAccessibility.Yes]``: ImportantForAccessibilityValue with get, set
        abstract ``[Types.ImportantForAccessibility.No]``: ImportantForAccessibilityValue with get, set
        abstract ``[Types.ImportantForAccessibility.NoHideDescendants]``: ImportantForAccessibilityValue with get, set

module __common_AppConfig =

    type [<AllowNullLiteral>] IExports =
        /// AppConfig.tsx
        /// 
        /// Copyright (c) Microsoft Corporation. All rights reserved.
        /// Licensed under the MIT license.
        /// 
        /// A simple class to store application config.
        abstract AppConfig: AppConfigStatic
        abstract _default: AppConfig

    /// AppConfig.tsx
    /// 
    /// Copyright (c) Microsoft Corporation. All rights reserved.
    /// Licensed under the MIT license.
    /// 
    /// A simple class to store application config.
    type [<AllowNullLiteral>] AppConfig =
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
        [<EmitConstructor>] abstract Create: unit -> AppConfig

module __common_assert =

    type [<AllowNullLiteral>] IExports =
        /// assert
        /// 
        /// Copyright (c) Microsoft Corporation. All rights reserved.
        /// Licensed under the MIT license.
        abstract ``assert``: obj option -> (string) option -> unit

module __common_Bezier =

    type [<AllowNullLiteral>] IExports =
        /// <summary>
        /// <see href="https://github.com/gre/bezier-easing" />
        /// BezierEasing - use bezier curve for transition easing function
        /// by Gaëtan Renaudeau 2014 - 2015 – MIT License
        /// </summary>
        abstract bezier: mX1: float * mY1: float * mX2: float * mY2: float -> (float -> float)

module __common_Easing =
    type Types = __common_Interfaces.Types

    type [<AllowNullLiteral>] IExports =
        abstract Easing: EasingStatic
        abstract _default: Easing

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
        [<EmitConstructor>] abstract Create: unit -> Easing

module __common_Image =
    type ImageResizeMode = __common_Types.ImageResizeMode

    type [<AllowNullLiteral>] IExports =
        abstract DEFAULT_RESIZE_MODE: ImageResizeMode

module __common_Interfaces =
    module SyncTasks = Synctasks
    module Types = __Types

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
        inherit React.Component<Types.ActivityIndicatorProps>

    type [<AllowNullLiteral>] ActivityIndicatorStatic =
        [<EmitConstructor>] abstract Create: unit -> ActivityIndicator

    type [<AllowNullLiteral>] Alert =
        abstract show: title: string * ?message: string * ?buttons: ResizeArray<Types.AlertButtonSpec> * ?options: Types.AlertOptions -> unit

    type [<AllowNullLiteral>] AlertStatic =
        [<EmitConstructor>] abstract Create: unit -> Alert

    type [<AllowNullLiteral>] AnimatedComponent<'P, 'T, 'C when 'P :> Types.CommonProps<'C>> =
        inherit React.Component<'P, 'T>
        abstract setNativeProps: props: 'P -> unit

    type [<AllowNullLiteral>] AnimatedComponentStatic =
        [<EmitConstructor>] abstract Create: unit -> AnimatedComponent<'P, 'T, 'C> when 'P :> Types.CommonProps<'C>

    type [<AllowNullLiteral>] AnimatedImage =
        inherit AnimatedComponent<Types.AnimatedImageProps, Types.Stateless, AnimatedImage>

    type [<AllowNullLiteral>] AnimatedImageStatic =
        [<EmitConstructor>] abstract Create: unit -> AnimatedImage

    type [<AllowNullLiteral>] AnimatedText =
        inherit AnimatedComponent<Types.AnimatedTextProps, Types.Stateless, AnimatedText>

    type [<AllowNullLiteral>] AnimatedTextStatic =
        [<EmitConstructor>] abstract Create: unit -> AnimatedText

    type [<AllowNullLiteral>] AnimatedTextInput =
        inherit AnimatedComponent<Types.AnimatedTextInputProps, Types.Stateless, AnimatedTextInput>

    type [<AllowNullLiteral>] AnimatedTextInputStatic =
        [<EmitConstructor>] abstract Create: unit -> AnimatedTextInput

    type [<AllowNullLiteral>] AnimatedView =
        inherit AnimatedComponent<Types.AnimatedViewProps, Types.Stateless, AnimatedView>
        inherit FocusableComponent
        abstract setFocusRestricted: restricted: bool -> unit
        abstract setFocusLimited: limited: bool -> unit
        abstract focus: unit -> unit
        abstract requestFocus: unit -> unit
        abstract blur: unit -> unit

    type [<AllowNullLiteral>] AnimatedViewStatic =
        [<EmitConstructor>] abstract Create: unit -> AnimatedView

    type [<AllowNullLiteral>] App =
        abstract supportsExperimentalKeyboardNavigation: bool with get, set
        abstract initialize: debug: bool * development: bool -> unit
        abstract getActivationState: unit -> Types.AppActivationState
        abstract activationStateChangedEvent: SubscribableEvent<(Types.AppActivationState -> unit)> with get, set
        abstract memoryWarningEvent: SubscribableEvent<(unit -> unit)> with get, set

    type [<AllowNullLiteral>] AppStatic =
        [<EmitConstructor>] abstract Create: unit -> App

    type [<AllowNullLiteral>] UserInterface =
        abstract setMainView: element: React.ReactElement<obj option> -> unit
        abstract registerRootView: viewKey: string * getComponentFunc: Function -> unit
        abstract useCustomScrollbars: ?enable: bool -> unit
        abstract isHighPixelDensityScreen: unit -> bool
        abstract getPixelRatio: unit -> float
        abstract measureLayoutRelativeToWindow: ``component``: React.Component<obj option> -> SyncTasks.Promise<Types.LayoutInfo>
        abstract measureLayoutRelativeToAncestor: ``component``: React.Component<obj option> * ancestor: React.Component<obj option> -> SyncTasks.Promise<Types.LayoutInfo>
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
        [<EmitConstructor>] abstract Create: unit -> UserInterface

    type [<AllowNullLiteral>] Modal =
        abstract isDisplayed: ?modalId: string -> bool
        abstract show: modal: React.ReactElement<Types.ViewProps> * modalId: string * ?options: Types.ModalOptions -> unit
        abstract dismiss: modalId: string -> unit
        abstract dismissAll: unit -> unit

    type [<AllowNullLiteral>] ModalStatic =
        [<EmitConstructor>] abstract Create: unit -> Modal

    type [<AllowNullLiteral>] Popup =
        abstract show: options: Types.PopupOptions * popupId: string * ?delay: float -> bool
        abstract autoDismiss: popupId: string * ?delay: float -> unit
        abstract dismiss: popupId: string -> unit
        abstract dismissAll: unit -> unit
        abstract isDisplayed: ?popupId: string -> bool

    type [<AllowNullLiteral>] PopupStatic =
        [<EmitConstructor>] abstract Create: unit -> Popup

    type [<AllowNullLiteral>] Linking =
        abstract getInitialUrl: unit -> SyncTasks.Promise<string option>
        abstract deepLinkRequestEvent: SubscribableEvent<(string -> unit)> with get, set
        abstract openUrl: url: string -> SyncTasks.Promise<unit>
        abstract launchSms: smsData: Types.SmsInfo -> SyncTasks.Promise<unit>
        abstract launchEmail: emailData: Types.EmailInfo -> SyncTasks.Promise<unit>
        abstract _createEmailUrl: emailInfo: Types.EmailInfo -> string

    type [<AllowNullLiteral>] LinkingStatic =
        [<EmitConstructor>] abstract Create: unit -> Linking

    type [<AllowNullLiteral>] Accessibility =
        abstract isScreenReaderEnabled: unit -> bool
        abstract isHighContrastEnabled: unit -> bool
        abstract announceForAccessibility: announcement: string -> unit
        abstract screenReaderChangedEvent: SubscribableEvent<(bool -> unit)> with get, set
        abstract highContrastChangedEvent: SubscribableEvent<(bool -> unit)> with get, set

    type [<AllowNullLiteral>] AccessibilityStatic =
        [<EmitConstructor>] abstract Create: unit -> Accessibility

    type [<AllowNullLiteral>] FocusableComponent =
        abstract focus: unit -> unit
        abstract requestFocus: unit -> unit
        abstract blur: unit -> unit

    type [<AllowNullLiteral>] Button =
        inherit React.Component<Types.ButtonProps>
        inherit FocusableComponent
        abstract focus: unit -> unit
        abstract requestFocus: unit -> unit
        abstract blur: unit -> unit

    type [<AllowNullLiteral>] ButtonStatic =
        [<EmitConstructor>] abstract Create: unit -> Button

    type [<AllowNullLiteral>] Picker =
        inherit React.Component<Types.PickerProps, Types.Stateless>

    type [<AllowNullLiteral>] PickerStatic =
        [<EmitConstructor>] abstract Create: unit -> Picker

    type [<AllowNullLiteral>] Component<'P, 'T> =
        inherit React.Component<'P, 'T>

    type [<AllowNullLiteral>] ComponentStatic =
        [<EmitConstructor>] abstract Create: unit -> Component<'P, 'T>

    type [<AllowNullLiteral>] ImageConstructor =
        abstract prefetch: url: string -> SyncTasks.Promise<bool>
        abstract getMetadata: url: string -> SyncTasks.Promise<Types.ImageMetadata>

    type [<AllowNullLiteral>] ImageConstructorStatic =
        [<EmitConstructor>] abstract Create: props: Types.ImageProps -> ImageConstructor

    type [<AllowNullLiteral>] Image =
        inherit React.Component<Types.ImageProps>
        abstract getNativeWidth: unit -> float option
        abstract getNativeHeight: unit -> float option

    type [<AllowNullLiteral>] ImageStatic =
        [<EmitConstructor>] abstract Create: unit -> Image

    type [<AllowNullLiteral>] Clipboard =
        abstract setText: text: string -> unit
        abstract getText: unit -> SyncTasks.Promise<string>

    type [<AllowNullLiteral>] ClipboardStatic =
        [<EmitConstructor>] abstract Create: unit -> Clipboard

    type [<AllowNullLiteral>] Link =
        inherit React.Component<Types.LinkProps>
        inherit FocusableComponent
        abstract focus: unit -> unit
        abstract requestFocus: unit -> unit
        abstract blur: unit -> unit

    type [<AllowNullLiteral>] LinkStatic =
        [<EmitConstructor>] abstract Create: unit -> Link

    type [<AllowNullLiteral>] Storage =
        abstract getItem: key: string -> SyncTasks.Promise<string option>
        abstract setItem: key: string * value: string -> SyncTasks.Promise<unit>
        abstract removeItem: key: string -> SyncTasks.Promise<unit>
        abstract clear: unit -> SyncTasks.Promise<unit>

    type [<AllowNullLiteral>] StorageStatic =
        [<EmitConstructor>] abstract Create: unit -> Storage

    type [<AllowNullLiteral>] Location =
        abstract isAvailable: unit -> bool
        abstract setConfiguration: config: LocationConfiguration -> unit
        abstract getCurrentPosition: ?options: PositionOptions -> SyncTasks.Promise<Position>
        abstract watchPosition: successCallback: Types.LocationSuccessCallback * ?errorCallback: Types.LocationFailureCallback * ?options: PositionOptions -> SyncTasks.Promise<Types.LocationWatchId>
        abstract clearWatch: watchID: Types.LocationWatchId -> unit

    type [<AllowNullLiteral>] LocationStatic =
        [<EmitConstructor>] abstract Create: unit -> Location

    type [<AllowNullLiteral>] LocationConfiguration =
        abstract skipPermissionRequests: bool with get, set

    type [<AllowNullLiteral>] Network =
        abstract isConnected: unit -> SyncTasks.Promise<bool>
        abstract getType: unit -> SyncTasks.Promise<Types.DeviceNetworkType>
        abstract connectivityChangedEvent: SubscribableEvent<(bool -> unit)> with get, set

    type [<AllowNullLiteral>] NetworkStatic =
        [<EmitConstructor>] abstract Create: unit -> Network

    type [<AllowNullLiteral>] Platform =
        abstract getType: unit -> Types.PlatformType
        abstract select: specifics: obj -> 'T option

    type [<AllowNullLiteral>] PlatformStatic =
        [<EmitConstructor>] abstract Create: unit -> Platform

    type [<AllowNullLiteral>] Input =
        abstract backButtonEvent: SubscribableEvent<(unit -> bool)> with get, set
        abstract keyDownEvent: SubscribableEvent<(Types.KeyboardEvent -> bool)> with get, set
        abstract keyUpEvent: SubscribableEvent<(Types.KeyboardEvent -> bool)> with get, set

    type [<AllowNullLiteral>] InputStatic =
        [<EmitConstructor>] abstract Create: unit -> Input

    type [<AllowNullLiteral>] ScrollViewConstructor =
        interface end

    type [<AllowNullLiteral>] ScrollViewConstructorStatic =
        [<EmitConstructor>] abstract Create: props: Types.ScrollViewProps -> ScrollViewConstructor

    type [<AllowNullLiteral>] ScrollView =
        inherit React.Component<Types.ScrollViewProps>
        abstract setScrollTop: scrollTop: float * ?animate: bool -> unit
        abstract setScrollLeft: scrollLeft: float * ?animate: bool -> unit

    type [<AllowNullLiteral>] StatusBar =
        abstract isOverlay: unit -> bool
        abstract setHidden: hidden: bool * showHideTransition: StatusBarSetHiddenShowHideTransition -> unit
        abstract setBarStyle: style: StatusBarSetBarStyleStyle * animated: bool -> unit
        abstract setNetworkActivityIndicatorVisible: value: bool -> unit
        abstract setBackgroundColor: color: string * animated: bool -> unit
        abstract setTranslucent: translucent: bool -> unit

    type [<StringEnum>] [<RequireQualifiedAccess>] StatusBarSetHiddenShowHideTransition =
        | Fade
        | Slide

    type [<StringEnum>] [<RequireQualifiedAccess>] StatusBarSetBarStyleStyle =
        | Default
        | [<CompiledName "light-content">] LightContent
        | [<CompiledName "dark-content">] DarkContent

    type [<AllowNullLiteral>] StatusBarStatic =
        [<EmitConstructor>] abstract Create: unit -> StatusBar

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
        abstract getCssPropertyAliasesCssStyle: unit -> StylesGetCssPropertyAliasesCssStyleReturn

    type [<AllowNullLiteral>] StylesGetCssPropertyAliasesCssStyleReturn =
        [<EmitIndexer>] abstract Item: key: string -> string with get, set

    type [<AllowNullLiteral>] StylesStatic =
        [<EmitConstructor>] abstract Create: unit -> Styles

    type [<AllowNullLiteral>] Text =
        inherit React.Component<Types.TextProps>
        inherit FocusableComponent
        abstract focus: unit -> unit
        abstract requestFocus: unit -> unit
        abstract blur: unit -> unit
        abstract getSelectedText: unit -> string

    type [<AllowNullLiteral>] TextStatic =
        [<EmitConstructor>] abstract Create: unit -> Text

    type [<AllowNullLiteral>] TextInput =
        inherit React.Component<Types.TextInputProps>
        inherit FocusableComponent
        abstract setAccessibilityFocus: unit -> unit
        abstract isFocused: unit -> bool
        abstract selectAll: unit -> unit
        abstract selectRange: start: float * ``end``: float -> unit
        abstract getSelectionRange: unit -> TextInputGetSelectionRangeReturn
        abstract setValue: value: string -> unit
        abstract focus: unit -> unit
        abstract requestFocus: unit -> unit
        abstract blur: unit -> unit

    type [<AllowNullLiteral>] TextInputGetSelectionRangeReturn =
        abstract start: float with get, set
        abstract ``end``: float with get, set

    type [<AllowNullLiteral>] TextInputStatic =
        [<EmitConstructor>] abstract Create: unit -> TextInput

    type [<AllowNullLiteral>] UserPresence =
        abstract isUserPresent: unit -> bool
        abstract userPresenceChangedEvent: SubscribableEvent<(bool -> unit)> with get, set

    type [<AllowNullLiteral>] UserPresenceStatic =
        [<EmitConstructor>] abstract Create: unit -> UserPresence

    type ViewBase<'P> =
        ViewBase<'P, obj>

    type [<AllowNullLiteral>] ViewBase<'P, 'S> =
        inherit React.Component<'P, 'S>

    type [<AllowNullLiteral>] ViewBaseStatic =
        [<EmitConstructor>] abstract Create: unit -> ViewBase<'P, 'S>

    type [<AllowNullLiteral>] View =
        inherit ViewBase<Types.ViewProps>
        inherit FocusableComponent
        abstract setFocusRestricted: restricted: bool -> unit
        abstract setFocusLimited: limited: bool -> unit
        abstract focus: unit -> unit
        abstract requestFocus: unit -> unit
        abstract blur: unit -> unit

    type [<AllowNullLiteral>] ViewStatic =
        [<EmitConstructor>] abstract Create: unit -> View

    type [<AllowNullLiteral>] GestureView =
        inherit ViewBase<Types.GestureViewProps>

    type [<AllowNullLiteral>] GestureViewStatic =
        [<EmitConstructor>] abstract Create: unit -> GestureView

    type [<AllowNullLiteral>] WebViewConstructor =
        interface end

    type [<AllowNullLiteral>] WebViewConstructorStatic =
        [<EmitConstructor>] abstract Create: props: Types.WebViewProps -> WebViewConstructor

    type [<AllowNullLiteral>] WebView =
        inherit ViewBase<Types.WebViewProps>
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
    module SyncTasks = Synctasks
    module RX = __Interfaces

    type [<AllowNullLiteral>] IExports =
        abstract Linking: LinkingStatic

    type [<AllowNullLiteral>] Linking =
        inherit RX.Linking
        abstract _openUrl: url: string -> SyncTasks.Promise<unit>
        abstract launchSms: phoneInfo: RX.Types.SmsInfo -> SyncTasks.Promise<unit>
        abstract openUrl: url: string -> SyncTasks.Promise<unit>
        abstract _createEmailUrl: emailInfo: RX.Types.EmailInfo -> string
        abstract _createSmsUrl: smsInfo: RX.Types.SmsInfo -> string

    type [<AllowNullLiteral>] LinkingStatic =
        [<EmitConstructor>] abstract Create: unit -> Linking

module __common_Location =
    module SyncTasks = Synctasks
    module RX = __Interfaces

    type [<AllowNullLiteral>] IExports =
        abstract Location: LocationStatic
        abstract _default: Location

    type [<AllowNullLiteral>] Location =
        inherit RX.Location
        abstract setConfiguration: config: RX.LocationConfiguration -> unit
        abstract isAvailable: unit -> bool
        abstract getCurrentPosition: ?options: PositionOptions -> SyncTasks.Promise<Position>
        abstract watchPosition: successCallback: RX.Types.LocationSuccessCallback * ?errorCallback: RX.Types.LocationFailureCallback * ?options: PositionOptions -> SyncTasks.Promise<RX.Types.LocationWatchId>
        abstract clearWatch: watchID: RX.Types.LocationWatchId -> unit

    type [<AllowNullLiteral>] LocationStatic =
        [<EmitConstructor>] abstract Create: unit -> Location

module __common_lodashMini =

    type [<AllowNullLiteral>] Dictionary<'T> =
        [<EmitIndexer>] abstract Item: index: string -> 'T with get, set

module __common_ModuleInterface =
    module RX = __Interfaces
    let [<ImportAll("reactxp/common/ModuleInterface")>] reactXP: ReactXP.IExports = jsNative

    module ReactXP =

        type [<AllowNullLiteral>] IExports =
            abstract Accessibility: RX.Accessibility with get, set
            abstract ActivityIndicator: obj with get, set
            abstract Alert: RX.Alert with get, set
            abstract App: RX.App with get, set
            abstract Button: obj with get, set
            abstract Picker: obj with get, set
            abstract Clipboard: RX.Clipboard with get, set
            abstract GestureView: obj with get, set
            abstract Image: RX.ImageConstructor with get, set
            abstract Input: RX.Input with get, set
            abstract International: RX.International with get, set
            abstract Link: obj with get, set
            abstract Linking: RX.Linking with get, set
            abstract Location: RX.Location with get, set
            abstract Modal: RX.Modal with get, set
            abstract Network: RX.Network with get, set
            abstract Platform: RX.Platform with get, set
            abstract Popup: RX.Popup with get, set
            abstract ScrollView: RX.ScrollViewConstructor with get, set
            abstract StatusBar: RX.StatusBar with get, set
            abstract Storage: RX.Storage with get, set
            abstract Styles: RX.Styles with get, set
            abstract Text: obj with get, set
            abstract TextInput: obj with get, set
            abstract UserInterface: RX.UserInterface with get, set
            abstract UserPresence: RX.UserPresence with get, set
            abstract View: obj with get, set
            abstract WebView: RX.WebViewConstructor with get, set
            abstract Animated: RX.Animated with get, set
            abstract createElement: obj with get, set
            abstract Children: obj with get, set
            abstract __spread: obj option with get, set

        type Accessibility =
            RX.Accessibility

        type ActivityIndicator =
            RX.ActivityIndicator

        type Alert =
            RX.Alert

        type App =
            RX.App

        type Button =
            RX.Button

        type Picker =
            RX.Picker

        type Clipboard =
            RX.Clipboard

        type GestureView =
            RX.GestureView

        type Image =
            RX.Image

        type Input =
            RX.Input

        type International =
            RX.International

        type Link =
            RX.Link

        type Linking =
            RX.Linking

        type Location =
            RX.Location

        type Modal =
            RX.Modal

        type Network =
            RX.Network

        type Platform =
            RX.Platform

        type Popup =
            RX.Popup

        type ScrollView =
            RX.ScrollView

        type StatusBar =
            RX.StatusBar

        type Storage =
            RX.Storage

        type Styles =
            RX.Styles

        type Text =
            RX.Text

        type TextInput =
            RX.TextInput

        type UserInterface =
            RX.UserInterface

        type UserPresence =
            RX.UserPresence

        type View =
            RX.View

        type WebView =
            RX.WebView

        type Animated =
            RX.Animated

module __common_PopupContainerViewBase =
    type Types = __common_Interfaces.Types
    type Dimensions = __common_Types.Dimensions
    type PopupPosition = __common_Types.PopupPosition

    type [<AllowNullLiteral>] IExports =
        abstract recalcPositionFromLayoutData: windowDims: Dimensions * anchorRect: ClientRect * popupRect: Dimensions * ?positionPriorities: ResizeArray<PopupPosition> * ?useInnerPositioning: bool -> RecalcResult option
        abstract PopupContainerViewBase: PopupContainerViewBaseStatic

    type [<AllowNullLiteral>] PopupContainerViewBaseProps<'C> =
        inherit Types.CommonProps<'C>
        abstract hidden: bool option with get, set

    type [<AllowNullLiteral>] PopupContainerViewContext =
        abstract focusManager: FocusManagerBase option with get, set

    type [<AllowNullLiteral>] PopupComponent =
        abstract onShow: (unit -> unit) with get, set
        abstract onHide: (unit -> unit) with get, set

    type [<AllowNullLiteral>] RecalcResult =
        abstract popupY: float with get, set
        abstract popupX: float with get, set
        abstract anchorOffset: float with get, set
        abstract anchorPosition: PopupPosition with get, set
        abstract constrainedPopupWidth: float with get, set
        abstract constrainedPopupHeight: float with get, set

    type [<AllowNullLiteral>] PopupContainerViewBase<'P, 'S, 'C when 'P :> PopupContainerViewBaseProps<'C>> =
        inherit React.Component<'P, 'S>
        abstract getChildContext: unit -> PopupContainerViewBaseGetChildContextReturn
        abstract registerPopupComponent: onShow: (unit -> unit) * onHide: (unit -> unit) -> PopupComponent
        abstract unregisterPopupComponent: ``component``: PopupComponent -> unit
        abstract isHidden: unit -> bool
        abstract componentDidUpdate: prevProps: 'P * prevState: 'S -> unit
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] PopupContainerViewBaseGetChildContextReturn =
        abstract focusManager: obj option with get, set
        abstract popupContainer: PopupContainerViewBase<'P, 'S, 'C> with get, set

    type [<AllowNullLiteral>] PopupContainerViewBaseStatic =
        abstract contextTypes: React.ValidationMap<obj option> with get, set
        abstract childContextTypes: React.ValidationMap<obj option> with get, set
        [<EmitConstructor>] abstract Create: props: 'P * ?context: PopupContainerViewContext -> PopupContainerViewBase<'P, 'S, 'C>

module __common_StyleLeakDetector =
    type Types = __common_Interfaces.Types

    type [<AllowNullLiteral>] IExports =
        abstract StyleLeakDetector: StyleLeakDetectorStatic
        abstract _default: StyleLeakDetector

    type [<AllowNullLiteral>] StyleLeakDetector =
        abstract isDisabled: unit -> bool
        abstract detectLeaks: style: 'T -> unit when 'T :> Types.ViewAndImageCommonStyle

    type [<AllowNullLiteral>] StyleLeakDetectorStatic =
        [<EmitConstructor>] abstract Create: unit -> StyleLeakDetector

module __common_Types =
    module RX = __Interfaces
    let [<ImportAll("reactxp/common/Types")>] animated: Animated.IExports = jsNative

    type [<AllowNullLiteral>] IExports =
        abstract AnimatedValue: AnimatedValueStatic
        abstract Children: React.ReactChildren with get, set

    type ReactNode =
        React.ReactNode

    type [<AllowNullLiteral>] ReactInterface =
        abstract createElement: ``type``: string * ?props: 'P * [<ParamArray>] children: ReactNode[] -> React.ReactElement<'P>

    type [<AllowNullLiteral>] FlexboxParentStyle =
        abstract flexDirection: FlexboxParentStyleFlexDirection option with get, set
        abstract alignSelf: FlexboxParentStyleAlignSelf option with get, set
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
        abstract position: FlexboxParentStylePosition option with get, set

    type [<AllowNullLiteral>] FlexboxChildrenStyle =
        abstract alignItems: FlexboxChildrenStyleAlignItems option with get, set
        abstract alignContent: FlexboxParentStyleAlignSelf option with get, set
        abstract flexWrap: FlexboxChildrenStyleFlexWrap option with get, set
        abstract justifyContent: FlexboxChildrenStyleJustifyContent option with get, set

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
        [<EmitConstructor>] abstract Create: ``val``: float -> AnimatedValue

    type [<AllowNullLiteral>] InterpolatedValue =
        abstract interpolate: config: InterpolationConfig -> InterpolatedValue

    type [<AllowNullLiteral>] AnimatedFlexboxStyle =
        abstract height: U2<AnimatedValue, InterpolatedValue> option with get, set
        abstract width: U2<AnimatedValue, InterpolatedValue> option with get, set
        abstract top: U2<AnimatedValue, InterpolatedValue> option with get, set
        abstract right: U2<AnimatedValue, InterpolatedValue> option with get, set
        abstract bottom: U2<AnimatedValue, InterpolatedValue> option with get, set
        abstract left: U2<AnimatedValue, InterpolatedValue> option with get, set

    type [<AllowNullLiteral>] TransformStyle =
        abstract transform: ResizeArray<TransformStyleTransform> option with get, set

    type [<AllowNullLiteral>] AnimatedTransformStyle =
        abstract transform: ResizeArray<AnimatedTransformStyleTransform> option with get, set

    type StyleRuleSet<'T> =
        U2<'T, float> option

    type StyleRuleSetOrArray<'T> =
        U2<StyleRuleSet<'T>, Array<StyleRuleSet<'T>>>

    type [<AllowNullLiteral>] StyleRuleSetRecursiveArray<'T> =
        inherit Array<U2<StyleRuleSetOrArray<'T>, StyleRuleSetRecursiveArray<'T>>>

    type StyleRuleSetRecursive<'T> =
        U2<StyleRuleSet<'T>, StyleRuleSetRecursiveArray<'T>>

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
        abstract overflow: ViewAndImageCommonStyleOverflow option with get, set
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
        abstract borderStyle: ViewStyleBorderStyle option with get, set
        abstract wordBreak: ViewStyleWordBreak option with get, set
        abstract appRegion: ViewStyleAppRegion option with get, set
        abstract cursor: ViewStyleCursor option with get, set
        abstract shadowOffset: ShadowOffset option with get, set
        abstract shadowOpacity: float option with get, set
        abstract shadowRadius: float option with get, set
        abstract shadowColor: string option with get, set
        abstract elevation: float option with get, set
        abstract acrylicOpacityUWP: float option with get, set
        abstract acrylicSourceUWP: ViewStyleAcrylicSourceUWP option with get, set
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
        abstract overflow: ViewAndImageCommonStyleOverflow option with get, set
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
        abstract fontStyle: FontInfoFontStyle option with get, set
        abstract fontWeight: FontInfoFontWeight option with get, set

    type [<AllowNullLiteral>] TextStyle =
        inherit ViewStyle
        abstract color: string option with get, set
        abstract fontFamily: string option with get, set
        abstract fontSize: float option with get, set
        abstract fontStyle: FontInfoFontStyle option with get, set
        abstract fontWeight: FontInfoFontWeight option with get, set
        abstract font: FontInfo option with get, set
        abstract letterSpacing: float option with get, set
        abstract lineHeight: float option with get, set
        abstract textAlign: TextStyleTextAlign option with get, set
        abstract textDecorationLine: TextStyleTextDecorationLine option with get, set
        abstract textDecorationStyle: TextStyleTextDecorationStyle option with get, set
        abstract textDecorationColor: string option with get, set
        abstract writingDirection: TextStyleWritingDirection option with get, set
        abstract textAlignVertical: TextStyleTextAlignVertical option with get, set
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

    /// Components
    type [<AllowNullLiteral>] RefObject<'T> =
        abstract current: 'T option

    type Ref<'T> =
        U2<('T option -> unit), RefObject<'T>> option

    type [<AllowNullLiteral>] RefAttributes<'T> =
        abstract ref: Ref<'T> option with get, set
        abstract key: U2<string, float> option with get, set

    type CommonProps =
        CommonProps<React.Component>

    type [<AllowNullLiteral>] CommonProps<'C> =
        inherit RefAttributes<'C>
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

    type [<AllowNullLiteral>] CommonStyledProps<'T, 'C> =
        inherit CommonProps<'C>
        abstract style: StyleRuleSetRecursive<'T> option with get, set

    type [<AllowNullLiteral>] ButtonProps =
        inherit CommonStyledProps<ButtonStyleRuleSet, RX.Button>
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
        inherit CommonProps<RX.Picker>
        abstract items: ResizeArray<PickerPropsItem> with get, set
        abstract selectedValue: string with get, set
        abstract onValueChange: (string -> float -> unit) with get, set
        abstract style: StyleRuleSetRecursive<PickerStyleRuleSet> option with get, set
        abstract mode: PickerPropsMode option with get, set

    /// WebView, Image headers
    type [<AllowNullLiteral>] Headers =
        [<EmitIndexer>] abstract Item: header: string -> string with get, set

    type [<StringEnum>] [<RequireQualifiedAccess>] ImageResizeMode =
        | Stretch
        | Contain
        | Cover
        | Auto
        | Repeat

    type [<AllowNullLiteral>] ImagePropsShared<'C> =
        inherit CommonProps<'C>
        abstract source: string with get, set
        abstract headers: Headers option with get, set
        abstract accessibilityLabel: string option with get, set
        abstract resizeMode: ImageResizeMode option with get, set
        abstract resizeMethod: ImagePropsSharedResizeMethod option with get, set
        abstract title: string option with get, set
        abstract onLoad: (Dimensions -> unit) option with get, set
        abstract onError: ((Error) option -> unit) option with get, set

    type [<AllowNullLiteral>] ImageProps =
        inherit ImagePropsShared<RX.Image>
        abstract style: StyleRuleSetRecursive<ImageStyleRuleSet> option with get, set

    type [<AllowNullLiteral>] ImageMetadata =
        abstract width: float with get, set
        abstract height: float with get, set

    type [<AllowNullLiteral>] AnimatedImageProps =
        inherit ImagePropsShared<RX.AnimatedImage>
        abstract style: StyleRuleSetRecursive<U2<AnimatedImageStyleRuleSet, ImageStyleRuleSet>> option with get, set

    type [<AllowNullLiteral>] TextPropsShared<'C> =
        inherit CommonProps<'C>
        abstract selectable: bool option with get, set
        abstract numberOfLines: float option with get, set
        abstract allowFontScaling: bool option with get, set
        abstract maxContentSizeMultiplier: float option with get, set
        abstract ellipsizeMode: TextPropsSharedEllipsizeMode option with get, set
        abstract textBreakStrategy: TextPropsSharedTextBreakStrategy option with get, set
        abstract importantForAccessibility: ImportantForAccessibility option with get, set
        abstract accessibilityId: string option with get, set
        abstract autoFocus: bool option with get, set
        abstract onPress: (SyntheticEvent -> unit) option with get, set
        abstract id: string option with get, set
        abstract onContextMenu: (MouseEvent -> unit) option with get, set

    type [<AllowNullLiteral>] TextProps =
        inherit TextPropsShared<RX.Text>
        abstract style: StyleRuleSetRecursive<TextStyleRuleSet> option with get, set

    type [<AllowNullLiteral>] AnimatedTextProps =
        inherit TextPropsShared<RX.AnimatedText>
        abstract style: StyleRuleSetRecursive<U2<AnimatedTextStyleRuleSet, TextStyleRuleSet>> option with get, set

    type [<StringEnum>] [<RequireQualifiedAccess>] ViewLayerType =
        | None
        | Software
        | Hardware

    type [<RequireQualifiedAccess>] LimitFocusType =
        | Unlimited = 0
        | Limited = 1
        | Accessible = 2

    type [<AllowNullLiteral>] ViewPropsShared<'C> =
        inherit CommonProps<'C>
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
        abstract onAccessibilityTapIOS: (SyntheticEvent -> unit) option with get, set
        abstract onLayout: (ViewOnLayoutEvent -> unit) option with get, set
        abstract onMouseEnter: (MouseEvent -> unit) option with get, set
        abstract onMouseLeave: (MouseEvent -> unit) option with get, set
        abstract onDragStart: (DragEvent -> unit) option with get, set
        abstract onDrag: (DragEvent -> unit) option with get, set
        abstract onDragEnd: (DragEvent -> unit) option with get, set
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
        inherit ViewPropsShared<RX.View>
        abstract style: StyleRuleSetRecursive<ViewStyleRuleSet> option with get, set
        abstract useSafeInsets: bool option with get, set

    type [<AllowNullLiteral>] AnimatedViewProps =
        inherit ViewPropsShared<RX.AnimatedView>
        abstract style: StyleRuleSetRecursive<U2<AnimatedViewStyleRuleSet, ViewStyleRuleSet>> option with get, set

    type [<AllowNullLiteral>] GestureState =
        abstract isTouch: bool with get, set
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
        | EWResize = 4
        | NSResize = 5
        | NESWResize = 6
        | NWSEResize = 7
        | NotAllowed = 8
        | ZoomIn = 9
        | ZoomOut = 10

    type [<RequireQualifiedAccess>] PreferredPanGesture =
        | Horizontal = 0
        | Vertical = 1

    type [<AllowNullLiteral>] GestureViewProps =
        inherit CommonStyledProps<ViewStyleRuleSet, RX.GestureView>
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
        abstract onLongPress: (TapGestureState -> unit) option with get, set
        abstract onContextMenu: (TapGestureState -> unit) option with get, set
        abstract onFocus: (FocusEvent -> unit) option with get, set
        abstract onBlur: (FocusEvent -> unit) option with get, set
        abstract onKeyPress: (KeyboardEvent -> unit) option with get, set
        abstract preferredPan: PreferredPanGesture option with get, set
        abstract panPixelThreshold: float option with get, set
        abstract releaseOnRequest: bool option with get, set

    type [<AllowNullLiteral>] ScrollIndicatorInsets =
        abstract top: float with get, set
        abstract left: float with get, set
        abstract bottom: float with get, set
        abstract right: float with get, set

    type [<AllowNullLiteral>] ScrollViewProps =
        inherit CommonStyledProps<ScrollViewStyleRuleSet, RX.ScrollView>
        inherit CommonAccessibilityProps
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
        abstract keyboardDismissMode: ScrollViewPropsKeyboardDismissMode option with get, set
        abstract keyboardShouldPersistTaps: bool option with get, set
        abstract scrollEventThrottle: float option with get, set
        abstract bounces: bool option with get, set
        abstract pagingEnabled: bool option with get, set
        abstract snapToInterval: float option with get, set
        abstract scrollsToTop: bool option with get, set
        abstract overScrollMode: ScrollViewPropsOverScrollMode option with get, set
        abstract scrollIndicatorInsets: ScrollIndicatorInsets option with get, set
        abstract tabNavigation: ScrollViewPropsTabNavigation option with get, set
        abstract scrollXAnimatedValue: RX.Types.AnimatedValue option with get, set
        abstract scrollYAnimatedValue: RX.Types.AnimatedValue option with get, set

    type [<AllowNullLiteral>] LinkProps =
        inherit CommonStyledProps<LinkStyleRuleSet, RX.Link>
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

    type [<AllowNullLiteral>] TextInputPropsShared<'C> =
        inherit CommonProps<'C>
        inherit CommonAccessibilityProps
        abstract autoCapitalize: TextInputPropsSharedAutoCapitalize option with get, set
        abstract autoCorrect: bool option with get, set
        abstract autoFocus: bool option with get, set
        abstract blurOnSubmit: bool option with get, set
        abstract defaultValue: string option with get, set
        abstract editable: bool option with get, set
        abstract keyboardType: TextInputPropsSharedKeyboardType option with get, set
        abstract maxLength: float option with get, set
        abstract multiline: bool option with get, set
        abstract placeholder: string option with get, set
        abstract placeholderTextColor: string option with get, set
        abstract secureTextEntry: bool option with get, set
        abstract value: string option with get, set
        abstract title: string option with get, set
        abstract allowFontScaling: bool option with get, set
        abstract maxContentSizeMultiplier: float option with get, set
        abstract keyboardAppearance: TextInputPropsSharedKeyboardAppearance option with get, set
        abstract returnKeyType: TextInputPropsSharedReturnKeyType option with get, set
        abstract disableFullscreenUI: bool option with get, set
        abstract spellCheck: bool option with get, set
        abstract selectionColor: string option with get, set
        abstract clearButtonMode: TextInputPropsSharedClearButtonMode option with get, set
        abstract onKeyPress: (KeyboardEvent -> unit) option with get, set
        abstract onFocus: (FocusEvent -> unit) option with get, set
        abstract onBlur: (FocusEvent -> unit) option with get, set
        abstract onPaste: (ClipboardEvent -> unit) option with get, set
        abstract onChangeText: (string -> unit) option with get, set
        abstract onSelectionChange: (float -> float -> unit) option with get, set
        abstract onSubmitEditing: (unit -> unit) option with get, set
        abstract onScroll: (float -> float -> unit) option with get, set

    type [<AllowNullLiteral>] TextInputProps =
        inherit TextInputPropsShared<RX.TextInput>
        abstract style: StyleRuleSetRecursive<TextInputStyleRuleSet> option with get, set

    type [<AllowNullLiteral>] AnimatedTextInputProps =
        inherit TextInputPropsShared<RX.AnimatedTextInput>
        abstract style: StyleRuleSetRecursive<U2<AnimatedTextInputStyleRuleSet, TextInputStyleRuleSet>> option with get, set

    type [<AllowNullLiteral>] ActivityIndicatorProps =
        inherit CommonStyledProps<ActivityIndicatorStyleRuleSet, RX.ActivityIndicator>
        abstract color: string with get, set
        abstract size: ActivityIndicatorPropsSize option with get, set
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
        | AllowMixedContentAlways = 1024
        | AllowMixedContentCompatibilityMode = 2048

    type [<AllowNullLiteral>] WebViewSource =
        abstract html: string with get, set
        abstract baseUrl: string option with get, set

    type [<AllowNullLiteral>] WebViewProps =
        inherit CommonStyledProps<WebViewStyleRuleSet, RX.WebView>
        abstract url: string option with get, set
        abstract source: WebViewSource option with get, set
        abstract headers: Headers option with get, set
        abstract onLoad: (SyntheticEvent -> unit) option with get, set
        abstract onNavigationStateChange: (WebViewNavigationState -> unit) option with get, set
        abstract scalesPageToFit: bool option with get, set
        abstract injectedJavaScript: string option with get, set
        abstract javaScriptEnabled: bool option with get, set
        abstract mediaPlaybackRequiresUserAction: bool option with get, set
        abstract allowsInlineMediaPlayback: bool option with get, set
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
        | Context

    type [<AllowNullLiteral>] PopupOptions =
        abstract getAnchor: (unit -> React.Component<obj option, obj option>) with get, set
        abstract renderPopup: (PopupPosition -> float -> float -> float -> ReactNode) with get, set
        abstract getElementTriggeringPopup: (unit -> React.Component<obj option, obj option>) option with get, set
        abstract onDismiss: (unit -> unit) option with get, set
        abstract positionPriorities: ResizeArray<PopupPosition> option with get, set
        abstract useInnerPositioning: bool option with get, set
        abstract onAnchorPressed: ((RX.Types.SyntheticEvent) option -> unit) option with get, set
        abstract dismissIfShown: bool option with get, set
        abstract preventDismissOnPress: bool option with get, set
        abstract cacheable: bool option with get, set
        abstract rootViewId: string option with get, set

    type [<AllowNullLiteral>] ModalOptions =
        abstract rootViewId: string option with get, set

    type [<AllowNullLiteral>] AlertButtonSpec =
        abstract text: string option with get, set
        abstract onPress: (unit -> unit) option with get, set
        abstract style: AlertButtonSpecStyle option with get, set

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
        abstract rootViewId: string option with get, set
        abstract preventDismissOnPress: bool option with get, set

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
            abstract timing: TimingFunction with get, set
            abstract sequence: SequenceFunction with get, set
            abstract ``parallel``: ParallelFunction with get, set

        type [<AllowNullLiteral>] EndResult =
            abstract finished: bool with get, set

        type [<AllowNullLiteral>] EndCallback =
            [<Emit "$0($1...)">] abstract Invoke: result: EndResult -> unit

        type [<AllowNullLiteral>] CompositeAnimation =
            abstract start: ((EndCallback) option -> unit) with get, set
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
        [<EmitIndexer>] abstract Item: index: float -> Touch with get, set
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

    type [<StringEnum>] [<RequireQualifiedAccess>] FlexboxParentStyleFlexDirection =
        | Column
        | Row
        | [<CompiledName "column-reverse">] ColumnReverse
        | [<CompiledName "row-reverse">] RowReverse

    type [<StringEnum>] [<RequireQualifiedAccess>] FlexboxParentStyleAlignSelf =
        | Auto
        | [<CompiledName "flex-start">] FlexStart
        | [<CompiledName "flex-end">] FlexEnd
        | Center
        | Stretch

    type [<StringEnum>] [<RequireQualifiedAccess>] FlexboxParentStylePosition =
        | Absolute
        | Relative

    type [<StringEnum>] [<RequireQualifiedAccess>] FlexboxChildrenStyleAlignItems =
        | [<CompiledName "flex-start">] FlexStart
        | [<CompiledName "flex-end">] FlexEnd
        | Center
        | Stretch

    type [<StringEnum>] [<RequireQualifiedAccess>] FlexboxChildrenStyleFlexWrap =
        | Wrap
        | Nowrap

    type [<StringEnum>] [<RequireQualifiedAccess>] FlexboxChildrenStyleJustifyContent =
        | [<CompiledName "flex-start">] FlexStart
        | [<CompiledName "flex-end">] FlexEnd
        | Center
        | [<CompiledName "space-between">] SpaceBetween
        | [<CompiledName "space-around">] SpaceAround

    type [<AllowNullLiteral>] TransformStyleTransform =
        abstract perspective: float option with get, set
        abstract rotate: string option with get, set
        abstract rotateX: string option with get, set
        abstract rotateY: string option with get, set
        abstract rotateZ: string option with get, set
        abstract scale: float option with get, set
        abstract scaleX: float option with get, set
        abstract scaleY: float option with get, set
        abstract translateX: float option with get, set
        abstract translateY: float option with get, set

    type [<AllowNullLiteral>] AnimatedTransformStyleTransform =
        abstract perspective: U2<AnimatedValue, InterpolatedValue> option with get, set
        abstract rotate: U2<AnimatedValue, InterpolatedValue> option with get, set
        abstract rotateX: U2<AnimatedValue, InterpolatedValue> option with get, set
        abstract rotateY: U2<AnimatedValue, InterpolatedValue> option with get, set
        abstract rotateZ: U2<AnimatedValue, InterpolatedValue> option with get, set
        abstract scale: U2<AnimatedValue, InterpolatedValue> option with get, set
        abstract scaleX: U2<AnimatedValue, InterpolatedValue> option with get, set
        abstract scaleY: U2<AnimatedValue, InterpolatedValue> option with get, set
        abstract translateX: U2<AnimatedValue, InterpolatedValue> option with get, set
        abstract translateY: U2<AnimatedValue, InterpolatedValue> option with get, set

    type [<StringEnum>] [<RequireQualifiedAccess>] ViewAndImageCommonStyleOverflow =
        | Visible
        | Hidden

    type [<StringEnum>] [<RequireQualifiedAccess>] ViewStyleBorderStyle =
        | Solid
        | Dotted
        | Dashed
        | None

    type [<StringEnum>] [<RequireQualifiedAccess>] ViewStyleWordBreak =
        | [<CompiledName "break-all">] BreakAll
        | [<CompiledName "break-word">] BreakWord

    type [<StringEnum>] [<RequireQualifiedAccess>] ViewStyleAppRegion =
        | Drag
        | [<CompiledName "no-drag">] NoDrag

    type [<StringEnum>] [<RequireQualifiedAccess>] ViewStyleCursor =
        | Pointer
        | Default

    type [<StringEnum>] [<RequireQualifiedAccess>] ViewStyleAcrylicSourceUWP =
        | Host
        | App

    type [<StringEnum>] [<RequireQualifiedAccess>] FontInfoFontStyle =
        | Normal
        | Italic

    type [<StringEnum>] [<RequireQualifiedAccess>] FontInfoFontWeight =
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

    type [<StringEnum>] [<RequireQualifiedAccess>] TextStyleTextDecorationStyle =
        | Solid
        | Double
        | Dotted
        | Dashed

    type [<StringEnum>] [<RequireQualifiedAccess>] TextStyleWritingDirection =
        | Auto
        | Ltr
        | Rtl

    type [<StringEnum>] [<RequireQualifiedAccess>] TextStyleTextAlignVertical =
        | Auto
        | Top
        | Bottom
        | Center

    type [<StringEnum>] [<RequireQualifiedAccess>] PickerPropsMode =
        | Dialog
        | Dropdown

    type [<StringEnum>] [<RequireQualifiedAccess>] ImagePropsSharedResizeMethod =
        | Auto
        | Resize
        | Scale

    type [<StringEnum>] [<RequireQualifiedAccess>] TextPropsSharedEllipsizeMode =
        | Head
        | Middle
        | Tail

    type [<StringEnum>] [<RequireQualifiedAccess>] TextPropsSharedTextBreakStrategy =
        | HighQuality
        | Simple
        | Balanced

    type [<StringEnum>] [<RequireQualifiedAccess>] ScrollViewPropsKeyboardDismissMode =
        | None
        | Interactive
        | [<CompiledName "on-drag">] OnDrag

    type [<StringEnum>] [<RequireQualifiedAccess>] ScrollViewPropsOverScrollMode =
        | Auto
        | Always
        | Never

    type [<StringEnum>] [<RequireQualifiedAccess>] ScrollViewPropsTabNavigation =
        | Local
        | Cycle
        | Once

    type [<StringEnum>] [<RequireQualifiedAccess>] TextInputPropsSharedAutoCapitalize =
        | None
        | Sentences
        | Words
        | Characters

    type [<StringEnum>] [<RequireQualifiedAccess>] TextInputPropsSharedKeyboardType =
        | Default
        | Numeric
        | [<CompiledName "email-address">] EmailAddress
        | [<CompiledName "number-pad">] NumberPad

    type [<StringEnum>] [<RequireQualifiedAccess>] TextInputPropsSharedKeyboardAppearance =
        | Default
        | Light
        | Dark

    type [<StringEnum>] [<RequireQualifiedAccess>] TextInputPropsSharedReturnKeyType =
        | Done
        | Go
        | Next
        | Search
        | Send

    type [<StringEnum>] [<RequireQualifiedAccess>] TextInputPropsSharedClearButtonMode =
        | Never
        | [<CompiledName "while-editing">] WhileEditing
        | [<CompiledName "unless-editing">] UnlessEditing
        | Always

    type [<StringEnum>] [<RequireQualifiedAccess>] ActivityIndicatorPropsSize =
        | Large
        | Medium
        | Small
        | Tiny

    type [<StringEnum>] [<RequireQualifiedAccess>] AlertButtonSpecStyle =
        | Default
        | Cancel
        | Destructive

module __ios_Accessibility =
    type NativeAccessibility = __native_common_Accessibility.Accessibility

    type [<AllowNullLiteral>] IExports =
        abstract Accessibility: AccessibilityStatic
        abstract _default: Accessibility

    type [<AllowNullLiteral>] Accessibility =
        inherit NativeAccessibility
        abstract _updateScreenReaderStatus: isEnabled: bool -> unit
        abstract announceForAccessibility: announcement: string -> unit

    type [<AllowNullLiteral>] AccessibilityStatic =
        [<EmitConstructor>] abstract Create: unit -> Accessibility

module __ios_AccessibilityUtil =
    type AccessibilityPlatformUtil = __common_AccessibilityUtil.AccessibilityPlatformUtil

    type [<AllowNullLiteral>] IExports =
        abstract AccessibilityUtil: AccessibilityUtilStatic
        abstract _default: AccessibilityUtil

    type [<AllowNullLiteral>] AccessibilityUtil =
        inherit AccessibilityPlatformUtil
        abstract setAccessibilityFocus: ``component``: React.Component<obj option, obj option> -> unit

    type [<AllowNullLiteral>] AccessibilityUtilStatic =
        [<EmitConstructor>] abstract Create: unit -> AccessibilityUtil

module __ios_GestureView =
    type BaseGestureView = __native_common_GestureView.GestureView
    type Types = __common_Interfaces.Types

    type [<AllowNullLiteral>] IExports =
        abstract GestureView: GestureViewStatic

    type [<AllowNullLiteral>] GestureView =
        inherit BaseGestureView
        abstract _getPreferredPanRatio: unit -> float
        abstract _getEventTimestamp: e: Types.TouchEvent -> float

    type [<AllowNullLiteral>] GestureViewStatic =
        [<EmitConstructor>] abstract Create: props: Types.GestureViewProps -> GestureView

module __ios_Linking =
    type Types = __common_Interfaces.Types
    type CommonLinking = __native_common_Linking.Linking

    type [<AllowNullLiteral>] IExports =
        abstract Linking: LinkingStatic
        abstract _default: Linking

    type [<AllowNullLiteral>] Linking =
        inherit CommonLinking
        abstract _createSmsUrl: smsInfo: Types.SmsInfo -> string

    type [<AllowNullLiteral>] LinkingStatic =
        [<EmitConstructor>] abstract Create: unit -> Linking

module __ios_ReactXP =
    let [<ImportAll("reactxp/ios/ReactXP")>] reactXP: ReactXP.IExports = jsNative

    module ReactXP =

        type [<AllowNullLiteral>] IExports =
            abstract Accessibility: RXInterfaces.Accessibility with get, set
            abstract ActivityIndicator: obj with get, set
            abstract Alert: RXInterfaces.Alert with get, set
            abstract App: RXInterfaces.App with get, set
            abstract Button: obj with get, set
            abstract Picker: obj with get, set
            abstract Clipboard: RXInterfaces.Clipboard with get, set
            abstract GestureView: obj with get, set
            abstract Image: RXInterfaces.ImageConstructor with get, set
            abstract Input: RXInterfaces.Input with get, set
            abstract International: RXInterfaces.International with get, set
            abstract Link: obj with get, set
            abstract Linking: RXInterfaces.Linking with get, set
            abstract Location: RXInterfaces.Location with get, set
            abstract Modal: RXInterfaces.Modal with get, set
            abstract Network: RXInterfaces.Network with get, set
            abstract Platform: RXInterfaces.Platform with get, set
            abstract Popup: RXInterfaces.Popup with get, set
            abstract ScrollView: RXInterfaces.ScrollViewConstructor with get, set
            abstract StatusBar: RXInterfaces.StatusBar with get, set
            abstract Storage: RXInterfaces.Storage with get, set
            abstract Styles: RXInterfaces.Styles with get, set
            abstract Text: obj with get, set
            abstract TextInput: obj with get, set
            abstract UserInterface: RXInterfaces.UserInterface with get, set
            abstract UserPresence: RXInterfaces.UserPresence with get, set
            abstract View: obj with get, set
            abstract WebView: RXInterfaces.WebViewConstructor with get, set
            abstract Animated: RXInterfaces.Animated
            abstract __spread: obj option with get, set

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
    module RX = ___common_Interfaces

    type [<AllowNullLiteral>] IExports =
        abstract StatusBar: StatusBarStatic
        abstract _default: StatusBar

    type [<AllowNullLiteral>] StatusBar =
        inherit RX.StatusBar
        abstract isOverlay: unit -> bool
        abstract setBarStyle: style: StatusBarSetBarStyleStyle * animated: bool -> unit
        abstract setHidden: hidden: bool * showHideTransition: StatusBarSetHiddenShowHideTransition -> unit
        abstract setNetworkActivityIndicatorVisible: value: bool -> unit
        abstract setBackgroundColor: color: string * animated: bool -> unit
        abstract setTranslucent: translucent: bool -> unit

    type [<StringEnum>] [<RequireQualifiedAccess>] StatusBarSetBarStyleStyle =
        | Default
        | [<CompiledName "light-content">] LightContent
        | [<CompiledName "dark-content">] DarkContent

    type [<StringEnum>] [<RequireQualifiedAccess>] StatusBarSetHiddenShowHideTransition =
        | Fade
        | Slide

    type [<AllowNullLiteral>] StatusBarStatic =
        [<EmitConstructor>] abstract Create: unit -> StatusBar

module __macos_Accessibility =
    type NativeAccessibility = __native_common_Accessibility.Accessibility

    type [<AllowNullLiteral>] IExports =
        abstract Accessibility: AccessibilityStatic
        abstract _default: Accessibility

    type [<AllowNullLiteral>] Accessibility =
        inherit NativeAccessibility
        abstract _updateScreenReaderStatus: isEnabled: bool -> unit
        abstract announceForAccessibility: announcement: string -> unit

    type [<AllowNullLiteral>] AccessibilityStatic =
        [<EmitConstructor>] abstract Create: unit -> Accessibility

module __macos_AccessibilityUtil =
    type AccessibilityPlatformUtil = __common_AccessibilityUtil.AccessibilityPlatformUtil

    type [<AllowNullLiteral>] IExports =
        abstract AccessibilityUtil: AccessibilityUtilStatic
        abstract _default: AccessibilityUtil

    type [<AllowNullLiteral>] AccessibilityUtil =
        inherit AccessibilityPlatformUtil
        abstract setAccessibilityFocus: ``component``: React.Component<obj option, obj option> -> unit

    type [<AllowNullLiteral>] AccessibilityUtilStatic =
        [<EmitConstructor>] abstract Create: unit -> AccessibilityUtil

module __macos_GestureView =
    type BaseGestureView = __native_common_GestureView.GestureView
    type Types = __common_Interfaces.Types

    type [<AllowNullLiteral>] IExports =
        abstract GestureView: GestureViewStatic

    type [<AllowNullLiteral>] GestureView =
        inherit BaseGestureView
        abstract _getPreferredPanRatio: unit -> float
        abstract _getEventTimestamp: e: Types.TouchEvent -> float

    type [<AllowNullLiteral>] GestureViewStatic =
        [<EmitConstructor>] abstract Create: props: Types.GestureViewProps -> GestureView

module __macos_Input =
    module RX = ___common_Interfaces

    type [<AllowNullLiteral>] IExports =
        abstract Input: InputStatic
        abstract _default: Input

    type [<AllowNullLiteral>] Input =
        inherit RX.Input

    type [<AllowNullLiteral>] InputStatic =
        [<EmitConstructor>] abstract Create: unit -> Input

module __macos_Linking =
    type Types = __common_Interfaces.Types
    type CommonLinking = __native_common_Linking.Linking

    type [<AllowNullLiteral>] IExports =
        abstract Linking: LinkingStatic
        abstract _default: Linking

    type [<AllowNullLiteral>] Linking =
        inherit CommonLinking
        abstract _createSmsUrl: smsInfo: Types.SmsInfo -> string

    type [<AllowNullLiteral>] LinkingStatic =
        [<EmitConstructor>] abstract Create: unit -> Linking

module __macos_ReactXP =
    let [<ImportAll("reactxp/macos/ReactXP")>] reactXP: ReactXP.IExports = jsNative

    module ReactXP =

        type [<AllowNullLiteral>] IExports =
            abstract Accessibility: RXInterfaces.Accessibility with get, set
            abstract ActivityIndicator: obj with get, set
            abstract Alert: RXInterfaces.Alert with get, set
            abstract App: RXInterfaces.App with get, set
            abstract Button: obj with get, set
            abstract Picker: obj with get, set
            abstract Clipboard: RXInterfaces.Clipboard with get, set
            abstract GestureView: obj with get, set
            abstract Image: RXInterfaces.ImageConstructor with get, set
            abstract Input: RXInterfaces.Input with get, set
            abstract International: RXInterfaces.International with get, set
            abstract Link: obj with get, set
            abstract Linking: RXInterfaces.Linking with get, set
            abstract Location: RXInterfaces.Location with get, set
            abstract Modal: RXInterfaces.Modal with get, set
            abstract Network: RXInterfaces.Network with get, set
            abstract Platform: RXInterfaces.Platform with get, set
            abstract Popup: RXInterfaces.Popup with get, set
            abstract ScrollView: RXInterfaces.ScrollViewConstructor with get, set
            abstract StatusBar: RXInterfaces.StatusBar with get, set
            abstract Storage: RXInterfaces.Storage with get, set
            abstract Styles: RXInterfaces.Styles with get, set
            abstract Text: obj with get, set
            abstract TextInput: obj with get, set
            abstract UserInterface: RXInterfaces.UserInterface with get, set
            abstract UserPresence: RXInterfaces.UserPresence with get, set
            abstract View: obj with get, set
            abstract WebView: RXInterfaces.WebViewConstructor with get, set
            abstract Animated: RXInterfaces.Animated
            abstract __spread: obj option with get, set

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
    module RX = ___common_Interfaces

    type [<AllowNullLiteral>] IExports =
        abstract StatusBar: StatusBarStatic
        abstract _default: StatusBar

    type [<AllowNullLiteral>] StatusBar =
        inherit RX.StatusBar
        abstract isOverlay: unit -> bool
        abstract setHidden: hidden: bool * showHideTransition: StatusBarSetHiddenShowHideTransition -> unit
        abstract setBackgroundColor: color: string * animated: bool -> unit
        abstract setTranslucent: translucent: bool -> unit
        abstract setBarStyle: style: StatusBarSetBarStyleStyle * animated: bool -> unit
        abstract setNetworkActivityIndicatorVisible: value: bool -> unit

    type [<StringEnum>] [<RequireQualifiedAccess>] StatusBarSetHiddenShowHideTransition =
        | Fade
        | Slide

    type [<StringEnum>] [<RequireQualifiedAccess>] StatusBarSetBarStyleStyle =
        | Default
        | [<CompiledName "light-content">] LightContent
        | [<CompiledName "dark-content">] DarkContent

    type [<AllowNullLiteral>] StatusBarStatic =
        [<EmitConstructor>] abstract Create: unit -> StatusBar

module __macos_View =
    type Types = __common_Interfaces.Types
    type ViewCommon = __native_common_View.View

    type [<AllowNullLiteral>] IExports =
        abstract View: ViewStatic

    type [<AllowNullLiteral>] View =
        inherit ViewCommon
        abstract _buildInternalProps: props: Types.ViewProps -> unit

    type [<AllowNullLiteral>] ViewStatic =
        [<EmitConstructor>] abstract Create: unit -> View

module __native_common_Accessibility =
    type CommonAccessibility = __common_Accessibility.Accessibility
    type Types = __common_Interfaces.Types

    type [<AllowNullLiteral>] IExports =
        abstract Accessibility: AccessibilityStatic
        abstract _default: Accessibility

    type [<AllowNullLiteral>] MacComponentAccessibilityProps =
        abstract onClick: (Types.SyntheticEvent -> unit) option with get, set
        abstract acceptsKeyboardFocus: obj option with get, set
        abstract enableFocusRing: obj option with get, set

    type [<AllowNullLiteral>] Accessibility =
        inherit CommonAccessibility
        abstract _isScreenReaderEnabled: bool with get, set
        abstract _updateScreenReaderStatus: isEnabled: bool -> unit
        abstract isScreenReaderEnabled: unit -> bool

    type [<AllowNullLiteral>] AccessibilityStatic =
        [<EmitConstructor>] abstract Create: unit -> Accessibility

module __native_common_AccessibilityUtil =
    module RN = React_native
    type AccessibilityPlatformUtil = __common_AccessibilityUtil.AccessibilityPlatformUtil
    type CommonAccessibilityUtil = __common_AccessibilityUtil.AccessibilityUtil
    type Types = __common_Interfaces.Types

    type [<AllowNullLiteral>] IExports =
        abstract AccessibilityUtil: AccessibilityUtilStatic
        abstract _default: AccessibilityUtil

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
        abstract setAccessibilityPlatformUtil: instance: AccessibilityPlatformUtil -> unit
        abstract accessibilityTraitToString: overrideTraits: U2<Types.AccessibilityTrait, ResizeArray<Types.AccessibilityTrait>> option * ?defaultTrait: Types.AccessibilityTrait * ?ensureDefaultTrait: bool -> ResizeArray<RN.AccessibilityTrait> option
        abstract accessibilityComponentTypeToString: overrideTraits: U2<Types.AccessibilityTrait, ResizeArray<Types.AccessibilityTrait>> option * ?defaultTrait: Types.AccessibilityTrait -> AccessibilityComponentTypeValue option
        abstract accessibilityLiveRegionToString: liveRegion: Types.AccessibilityLiveRegion option -> AccessibilityLiveRegionValue option
        abstract setAccessibilityFocus: ``component``: React.Component<obj option, obj option> -> unit

    type [<AllowNullLiteral>] AccessibilityUtilStatic =
        [<EmitConstructor>] abstract Create: unit -> AccessibilityUtil

module __native_common_ActivityIndicator =
    type Types = __common_Interfaces.Types

    type [<AllowNullLiteral>] IExports =
        abstract ActivityIndicator: ActivityIndicatorStatic

    type [<AllowNullLiteral>] ActivityIndicatorState =
        abstract isVisible: bool option with get, set

    type [<AllowNullLiteral>] ActivityIndicator =
        inherit React.Component<Types.ActivityIndicatorProps, ActivityIndicatorState>
        abstract componentDidMount: unit -> unit
        abstract componentWillUnmount: unit -> unit
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] ActivityIndicatorStatic =
        [<EmitConstructor>] abstract Create: props: Types.ActivityIndicatorProps -> ActivityIndicator

module __native_common_Alert =
    module RX = ___common_Interfaces

    type [<AllowNullLiteral>] IExports =
        abstract Alert: AlertStatic
        abstract _default: Alert

    type [<AllowNullLiteral>] Alert =
        inherit RX.Alert
        abstract show: title: string * ?message: string * ?buttons: ResizeArray<RX.Types.AlertButtonSpec> * ?options: RX.Types.AlertOptions -> unit

    type [<AllowNullLiteral>] AlertStatic =
        [<EmitConstructor>] abstract Create: unit -> Alert

module __native_common_Animated =
    module RN = React_native
    module RX = ___common_Interfaces

    type [<AllowNullLiteral>] IExports =
        abstract CommonAnimatedClasses: AnimatedClasses
        abstract makeAnimated: nativeAnimatedClasses: AnimatedClasses * ?useFocusRestrictedView: bool -> RX.Animated
        abstract AnimatedCommon: IExportsAnimatedCommon with get, set

    type [<AllowNullLiteral>] AnimatedClasses =
        abstract Image: obj with get, set
        abstract Text: obj with get, set
        abstract TextInput: obj with get, set
        abstract View: obj with get, set

    type [<AllowNullLiteral>] IExportsAnimatedCommon =
        abstract Easing: RX.Types.Animated.Easing with get, set
        abstract timing: (RX.Types.AnimatedValue -> RX.Types.Animated.TimingAnimationConfig -> RX.Types.Animated.CompositeAnimation) with get, set
        abstract ``parallel``: obj with get, set
        abstract sequence: obj with get, set
        abstract Value: obj with get, set
        abstract createValue: (float -> RN.Animated.Value) with get, set
        abstract interpolate: (RX.Types.AnimatedValue -> ResizeArray<float> -> ResizeArray<string> -> RX.Types.InterpolatedValue) with get, set

module __native_common_App =
    module RN = React_native
    module RX = ___common_Interfaces

    type [<AllowNullLiteral>] IExports =
        abstract App: AppStatic
        abstract _default: App

    type [<AllowNullLiteral>] App =
        inherit RX.App
        abstract initialize: debug: bool * development: bool -> unit
        abstract getActivationState: unit -> RX.Types.AppActivationState
        abstract getRootViewFactory: unit -> RN.ComponentProvider
        abstract getRootViewUsingPropsFactory: unit -> RN.ComponentProvider

    type [<AllowNullLiteral>] AppStatic =
        [<EmitConstructor>] abstract Create: unit -> App

module __native_common_Button =
    module PropTypes = Prop_types
    module RN = React_native
    type FocusArbitratorProvider = __common_utils_AutoFocusHelper.FocusArbitratorProvider
    type ButtonBase = __common_Interfaces.Button
    type Types = __common_Interfaces.Types

    type [<AllowNullLiteral>] IExports =
        abstract Button: ButtonStatic

    type [<AllowNullLiteral>] ButtonContext =
        abstract hasRxButtonAscendant: bool option with get, set
        abstract focusArbitrator: FocusArbitratorProvider option with get, set

    type [<AllowNullLiteral>] Button =
        inherit ButtonBase
        abstract context: ButtonContext with get, set
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
        abstract _buttonElement: RN.View option with get, set
        abstract _render: internalProps: RN.ViewProps * onMount: (RN.View option -> unit) -> JSX.Element
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
        abstract touchableGetPressRectOffset: (unit -> ButtonTouchableGetPressRectOffset) with get, set
        abstract requestFocus: unit -> unit
        abstract blur: unit -> unit
        abstract focus: unit -> unit
        abstract _onMouseEnter: (Types.SyntheticEvent -> unit) with get, set
        abstract _onMouseLeave: (Types.SyntheticEvent -> unit) with get, set
        abstract _onHoverStart: (Types.SyntheticEvent -> unit) with get, set
        abstract _onHoverEnd: (Types.SyntheticEvent -> unit) with get, set
        /// Animate the touchable to a new opacity.
        abstract setOpacityTo: value: float * duration: float -> unit

    type [<AllowNullLiteral>] ButtonStatic =
        abstract contextTypes: ButtonStaticContextTypes with get, set
        abstract childContextTypes: React.ValidationMap<obj option> with get, set
        [<EmitConstructor>] abstract Create: props: Types.ButtonProps * ?context: ButtonContext -> Button

    type [<AllowNullLiteral>] ButtonTouchableGetPressRectOffset =
        abstract top: float with get, set
        abstract left: float with get, set
        abstract right: float with get, set
        abstract bottom: float with get, set

    type [<AllowNullLiteral>] ButtonStaticContextTypes =
        abstract hasRxButtonAscendant: obj with get, set
        abstract focusArbitrator: obj with get, set

module __native_common_Clipboard =
    module SyncTasks = Synctasks
    module RX = ___common_Interfaces

    type [<AllowNullLiteral>] IExports =
        abstract Clipboard: ClipboardStatic
        abstract _default: Clipboard

    type [<AllowNullLiteral>] Clipboard =
        inherit RX.Clipboard
        abstract setText: text: string -> unit
        abstract getText: unit -> SyncTasks.Promise<string>

    type [<AllowNullLiteral>] ClipboardStatic =
        [<EmitConstructor>] abstract Create: unit -> Clipboard

module __native_common_FrontLayerViewManager =
    type Types = __common_Interfaces.Types

    type [<AllowNullLiteral>] IExports =
        abstract FrontLayerViewManager: FrontLayerViewManagerStatic
        abstract _default: FrontLayerViewManager

    type [<AllowNullLiteral>] FrontLayerViewManager =
        abstract event_changed: SubscribableEvent<(unit -> unit)> with get, set
        abstract showModal: modal: React.ReactElement<Types.ViewProps> * modalId: string * ?options: Types.ModalOptions -> unit
        abstract isModalDisplayed: ?modalId: string -> bool
        abstract dismissModal: modalId: string -> unit
        abstract dismissAllmodals: unit -> unit
        abstract showPopup: popupOptions: Types.PopupOptions * popupId: string * ?delay: float -> bool
        abstract dismissPopup: popupId: string -> unit
        abstract dismissAllPopups: unit -> unit
        abstract getModalLayerView: ?rootViewId: string -> React.ReactElement<obj option> option
        abstract getActivePopupId: unit -> string option
        abstract releaseCachedPopups: unit -> unit
        abstract isPopupActiveFor: ?rootViewId: string -> bool
        abstract getPopupLayerView: ?rootViewId: string -> JSX.Element option
        abstract isPopupDisplayed: ?popupId: string -> bool

    type [<AllowNullLiteral>] FrontLayerViewManagerStatic =
        [<EmitConstructor>] abstract Create: unit -> FrontLayerViewManager

module __native_common_GestureView =
    type Types = __common_Interfaces.Types

    type [<AllowNullLiteral>] IExports =
        abstract GestureView: GestureViewStatic

    type [<AllowNullLiteral>] GestureView =
        inherit React.Component<Types.GestureViewProps, Types.Stateless>
        abstract componentWillUnmount: unit -> unit
        abstract _getPreferredPanRatio: unit -> float
        abstract _getEventTimestamp: e: Types.TouchEvent -> float
        abstract render: unit -> JSX.Element
        abstract focus: unit -> unit
        abstract blur: unit -> unit

    type [<AllowNullLiteral>] GestureViewStatic =
        [<EmitConstructor>] abstract Create: props: Types.GestureViewProps -> GestureView

module __native_common_Image =
    module RN = React_native
    module SyncTasks = Synctasks
    type Types = __common_Interfaces.Types

    type [<AllowNullLiteral>] IExports =
        abstract Image: ImageStatic

    type [<AllowNullLiteral>] ImageContext =
        abstract isRxParentAText: bool option with get, set

    type [<AllowNullLiteral>] ImageState =
        abstract forceCache: bool option with get, set
        abstract lastNativeError: obj option with get, set
        abstract headers: Types.Headers option with get, set

    type [<AllowNullLiteral>] Image =
        inherit React.Component<Types.ImageProps, ImageState>
        inherit React.ChildContextProvider<ImageContext>
        abstract _mountedComponent: RN.Image option with get, set
        abstract state: ImageState
        abstract _getAdditionalProps: unit -> U2<RN.ImageProperties, Image_getAdditionalProps>
        abstract render: unit -> JSX.Element
        abstract componentWillReceiveProps: nextProps: Types.ImageProps -> unit
        abstract _onMount: (RN.Image option -> unit) with get, set
        abstract setNativeProps: nativeProps: RN.ImageProps -> unit
        abstract getChildContext: unit -> ImageGetChildContextReturn
        abstract getStyles: unit -> ResizeArray<Types.StyleRuleSetRecursive<Types.StyleRuleSet<Types.ImageStyle>>>
        abstract getNativeWidth: unit -> float option
        abstract getNativeHeight: unit -> float option

    type [<AllowNullLiteral>] ImageGetChildContextReturn =
        abstract isRxParentAText: bool with get, set

    type [<AllowNullLiteral>] ImageStatic =
        [<EmitConstructor>] abstract Create: unit -> Image
        abstract childContextTypes: React.ValidationMap<obj option> with get, set
        abstract prefetch: url: string -> SyncTasks.Promise<bool>
        abstract getMetadata: url: string -> SyncTasks.Promise<Types.ImageMetadata>

    type [<AllowNullLiteral>] Image_getAdditionalProps =
        interface end

module __native_common_Input =
    module RX = ___common_Interfaces

    type [<AllowNullLiteral>] IExports =
        abstract Input: InputStatic
        abstract _default: Input

    type [<AllowNullLiteral>] Input =
        inherit RX.Input

    type [<AllowNullLiteral>] InputStatic =
        [<EmitConstructor>] abstract Create: unit -> Input

module __native_common_International =
    module RX = ___common_Interfaces

    type [<AllowNullLiteral>] IExports =
        abstract International: InternationalStatic
        abstract _default: International

    type [<AllowNullLiteral>] International =
        inherit RX.International
        abstract allowRTL: allow: bool -> unit
        abstract forceRTL: force: bool -> unit
        abstract isRTL: unit -> bool

    type [<AllowNullLiteral>] InternationalStatic =
        [<EmitConstructor>] abstract Create: unit -> International

module __native_common_Link =
    module PropTypes = Prop_types
    module RN = React_native
    module RX = ___common_Interfaces
    type FocusArbitratorProvider = __common_utils_AutoFocusHelper.FocusArbitratorProvider

    type [<AllowNullLiteral>] IExports =
        abstract LinkBase: LinkBaseStatic
        abstract Link: LinkStatic

    type [<AllowNullLiteral>] LinkContext =
        abstract focusArbitrator: FocusArbitratorProvider option with get, set
        abstract isRxParentAText: bool option with get, set

    type [<AllowNullLiteral>] LinkBase<'S> =
        inherit React.Component<RX.Types.LinkProps, 'S>
        abstract context: LinkContext with get, set
        abstract _mountedComponent: RN.Text option with get, set
        abstract _isMounted: bool with get, set
        abstract setNativeProps: nativeProps: RN.TextProps -> unit
        abstract render: unit -> JSX.Element
        abstract componentDidMount: unit -> unit
        abstract componentWillUnmount: unit -> unit
        abstract _render: internalProps: RN.TextProps * onMount: (RN.Text option -> unit) -> JSX.Element
        abstract _onMount: (RN.Text option -> unit) with get, set
        abstract _onPress: (RX.Types.SyntheticEvent -> unit) with get, set
        abstract _onLongPress: (RX.Types.SyntheticEvent -> unit) with get, set
        abstract requestFocus: unit -> unit
        abstract focus: unit -> unit
        abstract blur: unit -> unit

    type [<AllowNullLiteral>] LinkBaseStatic =
        [<EmitConstructor>] abstract Create: unit -> LinkBase<'S>
        abstract contextTypes: LinkBaseStaticContextTypes with get, set

    type [<AllowNullLiteral>] Link =
        inherit LinkBase<LinkLinkBase>

    type [<AllowNullLiteral>] LinkStatic =
        [<EmitConstructor>] abstract Create: unit -> Link

    type [<AllowNullLiteral>] LinkBaseStaticContextTypes =
        abstract focusArbitrator: obj with get, set
        abstract isRxParentAText: obj with get, set

    type [<AllowNullLiteral>] LinkLinkBase =
        interface end

module __native_common_Linking =
    module SyncTasks = Synctasks
    type Types = __common_Interfaces.Types
    type CommonLinking = __common_Linking.Linking

    type [<AllowNullLiteral>] IExports =
        abstract Linking: LinkingStatic
        abstract _default: Linking

    type [<AllowNullLiteral>] Linking =
        inherit CommonLinking
        abstract _openUrl: url: string -> SyncTasks.Promise<unit>
        abstract getInitialUrl: unit -> SyncTasks.Promise<string option>
        abstract launchEmail: emailInfo: Types.EmailInfo -> SyncTasks.Promise<unit>

    type [<AllowNullLiteral>] LinkingStatic =
        [<EmitConstructor>] abstract Create: unit -> Linking

module __native_common_MainViewStore =

    type [<AllowNullLiteral>] IExports =
        abstract MainViewStore: MainViewStoreStatic
        abstract _default: MainViewStore

    type [<AllowNullLiteral>] MainViewStore =
        inherit SubscribableEvent<(unit -> unit)>
        abstract getMainView: unit -> React.ReactElement<obj option, U3<string, (obj option -> React.ReactElement<obj option, U3<string, obj option, obj>> option), obj>> option
        abstract setMainView: view: React.ReactElement<obj option> -> unit

    type [<AllowNullLiteral>] MainViewStoreStatic =
        [<EmitConstructor>] abstract Create: unit -> MainViewStore

module __native_common_Modal =
    module RX = ___common_Interfaces

    type [<AllowNullLiteral>] IExports =
        abstract Modal: ModalStatic
        abstract _default: Modal

    type [<AllowNullLiteral>] Modal =
        inherit RX.Modal
        abstract isDisplayed: ?modalId: string -> bool
        abstract show: modal: React.ReactElement<RX.Types.ViewProps> * modalId: string * ?options: RX.Types.ModalOptions -> unit
        abstract dismiss: modalId: string -> unit
        abstract dismissAll: unit -> unit

    type [<AllowNullLiteral>] ModalStatic =
        [<EmitConstructor>] abstract Create: unit -> Modal

module __native_common_ModalContainer =
    type Types = __common_Interfaces.Types

    type [<AllowNullLiteral>] IExports =
        abstract ModalContainer: ModalContainerStatic

    type [<AllowNullLiteral>] ModalContainerProps =
        inherit Types.CommonProps<ModalContainer>
        abstract hidden: bool option with get, set

    type [<AllowNullLiteral>] ModalContainer =
        inherit React.Component<ModalContainerProps, Types.Stateless>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] ModalContainerStatic =
        [<EmitConstructor>] abstract Create: props: ModalContainerProps -> ModalContainer

module __native_common_Network =
    module SyncTasks = Synctasks
    module RX = ___common_Interfaces

    type [<AllowNullLiteral>] IExports =
        abstract Network: NetworkStatic
        abstract _default: Network

    type [<AllowNullLiteral>] Network =
        inherit RX.Network
        abstract isConnected: unit -> SyncTasks.Promise<bool>
        abstract getType: unit -> SyncTasks.Promise<RX.Types.DeviceNetworkType>

    type [<AllowNullLiteral>] NetworkStatic =
        [<EmitConstructor>] abstract Create: unit -> Network

module __native_common_Picker =
    module RX = ___common_Interfaces

    type [<AllowNullLiteral>] IExports =
        abstract Picker: PickerStatic

    type [<AllowNullLiteral>] Picker =
        inherit RX.Picker
        abstract render: unit -> JSX.Element
        abstract onValueChange: (obj option -> float -> unit) with get, set

    type [<AllowNullLiteral>] PickerStatic =
        [<EmitConstructor>] abstract Create: unit -> Picker

module __native_common_Platform =
    module RX = ___common_Interfaces

    type [<AllowNullLiteral>] IExports =
        abstract Platform: PlatformStatic
        abstract _default: Platform

    type [<AllowNullLiteral>] Platform =
        inherit RX.Platform
        abstract getType: unit -> RX.Types.PlatformType
        abstract select: specifics: obj -> 'T option

    type [<AllowNullLiteral>] PlatformStatic =
        [<EmitConstructor>] abstract Create: unit -> Platform

module __native_common_Popup =
    module RX = ___common_Interfaces

    type [<AllowNullLiteral>] IExports =
        abstract Popup: PopupStatic
        abstract _default: Popup

    type [<AllowNullLiteral>] Popup =
        inherit RX.Popup
        abstract show: options: RX.Types.PopupOptions * popupId: string * ?delay: float -> bool
        abstract autoDismiss: popupId: string * ?delay: float -> unit
        abstract dismiss: popupId: string -> unit
        abstract dismissAll: unit -> unit
        abstract isDisplayed: ?popupId: string -> bool

    type [<AllowNullLiteral>] PopupStatic =
        [<EmitConstructor>] abstract Create: unit -> Popup

module __native_common_PopupContainerView =
    module RN = React_native
    type Types = __common_Interfaces.Types
    type PopupContainerViewBase = __common_PopupContainerViewBase.PopupContainerViewBase
    type PopupContainerViewBaseProps = __common_PopupContainerViewBase.PopupContainerViewBaseProps
    type PopupContainerViewContext = __common_PopupContainerViewBase.PopupContainerViewContext
    type RecalcResult = __common_PopupContainerViewBase.RecalcResult

    type [<AllowNullLiteral>] IExports =
        abstract PopupContainerView: PopupContainerViewStatic

    type [<AllowNullLiteral>] PopupContainerViewProps =
        inherit PopupContainerViewBaseProps<PopupContainerView>
        abstract popupOptions: Types.PopupOptions with get, set
        abstract anchorHandle: float option with get, set
        abstract onDismissPopup: (unit -> unit) option with get, set

    type [<AllowNullLiteral>] PopupContainerViewState =
        inherit RecalcResult
        abstract isMeasuringPopup: bool with get, set
        abstract popupWidth: float with get, set
        abstract popupHeight: float with get, set

    type [<AllowNullLiteral>] PopupContainerView =
        inherit PopupContainerViewBase<PopupContainerViewProps, PopupContainerViewState, PopupContainerView>
        abstract componentWillReceiveProps: prevProps: PopupContainerViewProps -> unit
        abstract componentDidUpdate: prevProps: PopupContainerViewProps * prevState: PopupContainerViewState -> unit
        abstract componentDidMount: unit -> unit
        abstract componentWillUnmount: unit -> unit
        abstract render: unit -> JSX.Element
        abstract _onMount: (RN.View option -> unit) with get, set

    type [<AllowNullLiteral>] PopupContainerViewStatic =
        [<EmitConstructor>] abstract Create: props: PopupContainerViewProps * ?context: PopupContainerViewContext -> PopupContainerView

module __native_common_RootView =

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

    type [<AllowNullLiteral>] BaseRootView<'P when 'P :> BaseRootViewProps> =
        inherit React.Component<'P, RootViewState>
        abstract _mainViewProps: BaseRootView_mainViewProps with get, set
        abstract _rootViewId: string option with get, set
        abstract _getPropsForMainView: unit -> BaseRootView_getPropsForMainViewReturn
        abstract componentWillMount: unit -> unit
        abstract componentDidMount: unit -> unit
        abstract componentWillUnmount: unit -> unit
        abstract render: unit -> JSX.Element
        abstract _renderAnnouncerView: unit -> JSX.Element
        abstract renderTopView: content: JSX.Element -> JSX.Element

    type [<AllowNullLiteral>] BaseRootView_getPropsForMainViewReturn =
        interface end

    type [<AllowNullLiteral>] BaseRootViewStatic =
        [<EmitConstructor>] abstract Create: props: 'P -> BaseRootView<'P>

    type [<AllowNullLiteral>] RootViewUsingStore =
        inherit BaseRootView<BaseRootViewProps>
        abstract componentWillMount: unit -> unit
        abstract componentWillUnmount: unit -> unit
        abstract _getPropsForMainView: unit -> RootViewUsingStore_getPropsForMainViewReturn

    type [<AllowNullLiteral>] RootViewUsingStore_getPropsForMainViewReturn =
        interface end

    type [<AllowNullLiteral>] RootViewUsingStoreStatic =
        [<EmitConstructor>] abstract Create: props: BaseRootViewProps -> RootViewUsingStore

    type [<AllowNullLiteral>] RootViewUsingProps =
        inherit BaseRootView<RootViewPropsWithMainViewType>
        abstract _getPropsForMainView: unit -> RootViewUsingProps_getPropsForMainViewReturn

    type [<AllowNullLiteral>] RootViewUsingProps_getPropsForMainViewReturn =
        interface end

    type [<AllowNullLiteral>] RootViewUsingPropsStatic =
        [<EmitConstructor>] abstract Create: props: RootViewPropsWithMainViewType -> RootViewUsingProps

    type [<AllowNullLiteral>] BaseRootView_mainViewProps =
        interface end

module __native_common_ScrollView =
    module RN = React_native
    module RX = ___common_Interfaces

    type [<AllowNullLiteral>] IExports =
        abstract ScrollView: ScrollViewStatic

    type [<AllowNullLiteral>] ScrollView =
        inherit ViewBase<RX.Types.ScrollViewProps, RX.Types.Stateless, RN.ScrollView, RX.ScrollView>
        inherit RX.ScrollView
        abstract _render: nativeProps: obj -> JSX.Element
        abstract render: unit -> JSX.Element
        abstract setScrollTop: scrollTop: float * ?animate: bool -> unit
        abstract setScrollLeft: scrollLeft: float * ?animate: bool -> unit

    type [<AllowNullLiteral>] ScrollViewStatic =
        [<EmitConstructor>] abstract Create: unit -> ScrollView
        abstract useCustomScrollbars: unit -> unit

module __native_common_Storage =
    module SyncTasks = Synctasks
    module RX = ___common_Interfaces

    type [<AllowNullLiteral>] IExports =
        abstract Storage: StorageStatic
        abstract _default: Storage

    type [<AllowNullLiteral>] Storage =
        inherit RX.Storage
        abstract getItem: key: string -> SyncTasks.Promise<string option>
        abstract setItem: key: string * value: string -> SyncTasks.Promise<unit>
        abstract removeItem: key: string -> SyncTasks.Promise<unit>
        abstract clear: unit -> SyncTasks.Promise<unit>

    type [<AllowNullLiteral>] StorageStatic =
        [<EmitConstructor>] abstract Create: unit -> Storage

module __native_common_StyleLeakDetector =
    type CommonStyleLeakDetector = __common_StyleLeakDetector.StyleLeakDetector

    type [<AllowNullLiteral>] IExports =
        abstract StyleLeakDetector: StyleLeakDetectorStatic
        abstract _default: StyleLeakDetector

    type [<AllowNullLiteral>] StyleLeakDetector =
        inherit CommonStyleLeakDetector
        abstract isDisabled: unit -> bool

    type [<AllowNullLiteral>] StyleLeakDetectorStatic =
        [<EmitConstructor>] abstract Create: unit -> StyleLeakDetector

module __native_common_Styles =
    module RX = ___common_Interfaces

    type [<AllowNullLiteral>] IExports =
        abstract Styles: StylesStatic
        abstract _default: Styles

    type [<AllowNullLiteral>] Styles =
        inherit RX.Styles
        abstract combine: ruleSet1: RX.Types.StyleRuleSetRecursive<'S> option * ?ruleSet2: RX.Types.StyleRuleSetRecursive<'S> -> RX.Types.StyleRuleSetOrArray<'S> option
        abstract createViewStyle: ruleSet: RX.Types.ViewStyle * ?cacheStyle: bool -> RX.Types.ViewStyleRuleSet
        abstract createAnimatedViewStyle: ruleSet: RX.Types.AnimatedViewStyle -> RX.Types.AnimatedViewStyleRuleSet
        abstract createScrollViewStyle: ruleSet: RX.Types.ScrollViewStyle * ?cacheStyle: bool -> RX.Types.ScrollViewStyleRuleSet
        abstract createButtonStyle: ruleSet: RX.Types.ButtonStyle * ?cacheStyle: bool -> RX.Types.ButtonStyleRuleSet
        abstract createWebViewStyle: ruleSet: RX.Types.WebViewStyle * ?cacheStyle: bool -> RX.Types.WebViewStyleRuleSet
        abstract createTextStyle: ruleSet: RX.Types.TextStyle * ?cacheStyle: bool -> RX.Types.TextStyleRuleSet
        abstract createAnimatedTextStyle: ruleSet: RX.Types.AnimatedTextStyle -> RX.Types.AnimatedTextStyleRuleSet
        abstract createTextInputStyle: ruleSet: RX.Types.TextInputStyle * ?cacheStyle: bool -> RX.Types.TextInputStyleRuleSet
        abstract createAnimatedTextInputStyle: ruleSet: RX.Types.AnimatedTextInputStyle -> RX.Types.AnimatedTextInputStyleRuleSet
        abstract createImageStyle: ruleSet: RX.Types.ImageStyle * ?cacheStyle: bool -> RX.Types.ImageStyleRuleSet
        abstract createAnimatedImageStyle: ruleSet: RX.Types.AnimatedImageStyle -> RX.Types.AnimatedImageStyleRuleSet
        abstract createLinkStyle: ruleSet: RX.Types.LinkStyle * ?cacheStyle: bool -> RX.Types.LinkStyleRuleSet
        abstract createPickerStyle: ruleSet: RX.Types.PickerStyle * ?cacheStyle: bool -> RX.Types.PickerStyleRuleSet
        abstract getCssPropertyAliasesCssStyle: unit -> StylesGetCssPropertyAliasesCssStyleReturn

    type [<AllowNullLiteral>] StylesGetCssPropertyAliasesCssStyleReturn =
        [<EmitIndexer>] abstract Item: key: string -> string with get, set

    type [<AllowNullLiteral>] StylesStatic =
        [<EmitConstructor>] abstract Create: unit -> Styles

module __native_common_Text =
    module RN = React_native
    type FocusArbitratorProvider = __common_utils_AutoFocusHelper.FocusArbitratorProvider
    type Types = __common_Interfaces.Types

    type [<AllowNullLiteral>] IExports =
        abstract Text: TextStatic

    type [<AllowNullLiteral>] TextContext =
        abstract isRxParentAText: bool with get, set
        abstract focusArbitrator: FocusArbitratorProvider option with get, set
        abstract isRxParentAContextMenuResponder: bool option with get, set

    type [<AllowNullLiteral>] Text =
        inherit React.Component<Types.TextProps, Types.Stateless>
        inherit React.ChildContextProvider<TextContext>
        abstract context: TextContext with get, set
        abstract _mountedComponent: RN.Text option with get, set
        abstract setNativeProps: nativeProps: RN.TextProps -> unit
        abstract render: unit -> JSX.Element
        abstract componentDidMount: unit -> unit
        abstract _onMount: (RN.Text option -> unit) with get, set
        abstract _getExtendedProperties: unit -> RN.ExtendedTextProps
        abstract getChildContext: unit -> TextGetChildContextReturn
        abstract _getStyles: unit -> Types.StyleRuleSetRecursiveArray<Types.TextStyleRuleSet>
        abstract requestFocus: unit -> unit
        abstract focus: unit -> unit
        abstract blur: unit -> unit
        abstract getSelectedText: unit -> string

    type [<AllowNullLiteral>] TextGetChildContextReturn =
        abstract isRxParentAText: bool with get, set

    type [<AllowNullLiteral>] TextStatic =
        [<EmitConstructor>] abstract Create: unit -> Text
        abstract contextTypes: React.ValidationMap<obj option> with get, set
        abstract childContextTypes: React.ValidationMap<obj option> with get, set

module __native_common_TextInput =
    module RN = React_native
    type FocusArbitratorProvider = __common_utils_AutoFocusHelper.FocusArbitratorProvider
    type Types = __common_Interfaces.Types

    type [<AllowNullLiteral>] IExports =
        abstract TextInput: TextInputStatic

    type [<AllowNullLiteral>] TextInputState =
        abstract inputValue: string with get, set
        abstract isFocused: bool with get, set

    type [<AllowNullLiteral>] TextInputContext =
        abstract focusArbitrator: FocusArbitratorProvider option with get, set

    type [<AllowNullLiteral>] TextInput =
        inherit React.Component<Types.TextInputProps, TextInputState>
        abstract context: TextInputContext with get, set
        abstract _mountedComponent: RN.TextInput option with get, set
        abstract componentWillReceiveProps: nextProps: Types.TextInputProps -> unit
        abstract componentDidMount: unit -> unit
        abstract _render: props: RN.TextInputProps * onMount: (RN.TextInput option -> unit) -> JSX.Element
        abstract render: unit -> JSX.Element
        abstract _onMount: (RN.TextInput option -> unit) with get, set
        abstract blur: unit -> unit
        abstract requestFocus: unit -> unit
        abstract focus: unit -> unit
        abstract setAccessibilityFocus: unit -> unit
        abstract isFocused: unit -> bool
        abstract selectAll: unit -> unit
        abstract selectRange: start: float * ``end``: float -> unit
        abstract getSelectionRange: unit -> TextInputGetSelectionRangeReturn
        abstract setValue: value: string -> unit

    type [<AllowNullLiteral>] TextInputGetSelectionRangeReturn =
        abstract start: float with get, set
        abstract ``end``: float with get, set

    type [<AllowNullLiteral>] TextInputStatic =
        abstract contextTypes: React.ValidationMap<obj option> with get, set
        [<EmitConstructor>] abstract Create: props: Types.TextInputProps * ?context: TextInputContext -> TextInput

module __native_common_UserInterface =
    module RN = React_native
    module SyncTasks = Synctasks
    module RX = ___common_Interfaces

    type [<AllowNullLiteral>] IExports =
        abstract UserInterface: UserInterfaceStatic
        abstract _default: UserInterface

    type [<AllowNullLiteral>] UserInterface =
        inherit RX.UserInterface
        abstract measureLayoutRelativeToWindow: ``component``: React.Component<obj option, obj option> -> SyncTasks.Promise<RX.Types.LayoutInfo>
        abstract measureLayoutRelativeToAncestor: ``component``: React.Component<obj option, obj option> * ancestor: React.Component<obj option, obj option> -> SyncTasks.Promise<RX.Types.LayoutInfo>
        abstract measureWindow: ?rootViewId: string -> RX.Types.LayoutInfo
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
        abstract evaluateTouchLatency: e: RX.Types.SyntheticEvent -> unit
        abstract isNavigatingWithKeyboard: unit -> bool
        abstract notifyRootViewInstanceCreated: rootViewId: string * nodeHandle: float -> unit
        abstract notifyRootViewInstanceDestroyed: rootViewId: string -> unit
        abstract findNodeHandleByRootViewId: rootViewId: string -> float option

    type [<AllowNullLiteral>] UserInterfaceStatic =
        [<EmitConstructor>] abstract Create: unit -> UserInterface

module __native_common_UserPresence =
    module RX = ___common_Interfaces

    type [<AllowNullLiteral>] IExports =
        abstract UserPresence: UserPresenceStatic
        abstract _default: UserPresence

    type [<AllowNullLiteral>] UserPresence =
        inherit RX.UserPresence
        abstract isUserPresent: unit -> bool

    type [<AllowNullLiteral>] UserPresenceStatic =
        [<EmitConstructor>] abstract Create: unit -> UserPresence

module __native_common_View =
    module RN = React_native
    module RX = ___common_Interfaces
    type FocusArbitratorProvider = __common_utils_AutoFocusHelper.FocusArbitratorProvider

    type [<AllowNullLiteral>] IExports =
        abstract View: ViewStatic

    type [<AllowNullLiteral>] ViewContext =
        abstract focusArbitrator: FocusArbitratorProvider option with get, set

    type [<AllowNullLiteral>] View =
        inherit ViewBase<RX.Types.ViewProps, RX.Types.Stateless, RN.View, RX.View>
        abstract context: ViewContext with get, set
        abstract _internalProps: obj option with get, set
        abstract touchableGetInitialState: (unit -> RN.Touchable.State) with get, set
        abstract touchableHandleStartShouldSetResponder: (unit -> bool) with get, set
        abstract touchableHandleResponderTerminationRequest: (unit -> bool) with get, set
        abstract touchableHandleResponderGrant: (React.SyntheticEvent<obj option> -> unit) with get, set
        abstract touchableHandleResponderMove: (React.SyntheticEvent<obj option> -> unit) with get, set
        abstract touchableHandleResponderRelease: (React.SyntheticEvent<obj option> -> unit) with get, set
        abstract touchableHandleResponderTerminate: (React.SyntheticEvent<obj option> -> unit) with get, set
        abstract _isMounted: bool with get, set
        abstract componentWillReceiveProps: nextProps: RX.Types.ViewProps -> unit
        abstract componentWillUpdate: nextProps: RX.Types.ViewProps * nextState: ViewComponentWillUpdateNextState -> unit
        abstract componentDidMount: unit -> unit
        abstract componentWillUnmount: unit -> unit
        abstract getChildContext: unit -> ViewContext
        /// Attention:
        /// be careful with setting any non layout properties unconditionally in this method to any value
        /// as on android that would lead to extra layers of Views.
        abstract _buildInternalProps: props: RX.Types.ViewProps -> unit
        abstract _isButton: viewProps: RX.Types.ViewProps -> bool
        abstract render: unit -> JSX.Element
        abstract touchableHandlePress: e: RX.Types.SyntheticEvent -> unit
        abstract touchableHandleLongPress: e: RX.Types.SyntheticEvent -> unit
        abstract touchableHandleActivePressIn: e: RX.Types.SyntheticEvent -> unit
        abstract touchableHandleActivePressOut: e: RX.Types.SyntheticEvent -> unit
        abstract touchableGetHighlightDelayMS: unit -> float
        abstract touchableGetPressRectOffset: unit -> ViewTouchableGetPressRectOffsetReturn
        abstract setFocusRestricted: restricted: bool -> unit
        abstract setFocusLimited: limited: bool -> unit
        abstract blur: unit -> unit
        abstract requestFocus: unit -> unit
        abstract focus: unit -> unit

    type [<AllowNullLiteral>] ViewComponentWillUpdateNextState =
        interface end

    type [<AllowNullLiteral>] ViewTouchableGetPressRectOffsetReturn =
        abstract top: float with get, set
        abstract left: float with get, set
        abstract right: float with get, set
        abstract bottom: float with get, set

    type [<AllowNullLiteral>] ViewStatic =
        abstract contextTypes: React.ValidationMap<obj option> with get, set
        abstract childContextTypes: React.ValidationMap<obj option> with get, set
        [<EmitConstructor>] abstract Create: props: RX.Types.ViewProps * ?context: ViewContext -> View

module __native_common_ViewBase =
    module RN = React_native
    module RX = ___common_Interfaces

    type [<AllowNullLiteral>] IExports =
        abstract ViewBase: ViewBaseStatic

    type [<AllowNullLiteral>] ViewBase<'P, 'S, 'T, 'C when 'P :> RX.Types.ViewPropsShared<'C>> =
        inherit RX.ViewBase<'P, 'S>
        abstract render: unit -> JSX.Element
        abstract _nativeComponent: 'T option with get, set
        abstract setNativeProps: nativeProps: RN.ViewProps -> unit
        abstract _setNativeComponent: ('T option -> unit) with get, set
        abstract _getStyles: props: RX.Types.ViewProps -> RX.Types.StyleRuleSetRecursive<RX.Types.StyleRuleSet<RX.Types.ViewStyle>>
        abstract _onLayout: (RN.LayoutChangeEvent -> unit) with get, set

    type [<AllowNullLiteral>] ViewBaseStatic =
        [<EmitConstructor>] abstract Create: unit -> ViewBase<'P, 'S, 'T, 'C> when 'P :> RX.Types.ViewPropsShared<'C>
        abstract setDefaultViewStyle: defaultViewStyle: RX.Types.ViewStyleRuleSet -> unit
        abstract getDefaultViewStyle: unit -> RX.Types.StyleRuleSet<RX.Types.ViewStyle>

module __native_common_WebView =
    module RN = React_native
    module RX = ___common_Interfaces

    type [<AllowNullLiteral>] IExports =
        abstract WebView: WebViewStatic

    type [<AllowNullLiteral>] WebView =
        inherit React.Component<RX.Types.WebViewProps, RX.Types.Stateless>
        inherit RX.WebView
        abstract render: unit -> JSX.Element
        abstract _onMount: (RN.WebView option -> unit) with get, set
        abstract _onMessage: (RN.NativeSyntheticEvent<RN.WebViewMessageEventData> -> unit) with get, set
        abstract postMessage: message: string * ?targetOrigin: string -> unit
        abstract reload: unit -> unit
        abstract goBack: unit -> unit
        abstract goForward: unit -> unit

    type [<AllowNullLiteral>] WebViewStatic =
        [<EmitConstructor>] abstract Create: unit -> WebView

module __native_desktop_App =
    type ComponentProvider = React_native.ComponentProvider
    type AppCommon = __native_common_App.App

    type [<AllowNullLiteral>] IExports =
        abstract App: AppStatic
        abstract _default: App

    type [<AllowNullLiteral>] App =
        inherit AppCommon
        abstract getRootViewFactory: unit -> ComponentProvider
        abstract getRootViewUsingPropsFactory: unit -> ComponentProvider

    type [<AllowNullLiteral>] AppStatic =
        [<EmitConstructor>] abstract Create: unit -> App

module __native_desktop_Input =
    type InputCommon = __native_common_Input.Input
    type Types = __common_Interfaces.Types

    type [<AllowNullLiteral>] IExports =
        abstract Input: InputStatic
        abstract _default: Input

    type [<AllowNullLiteral>] Input =
        inherit InputCommon
        abstract dispatchKeyDown: e: Types.KeyboardEvent -> unit
        abstract dispatchKeyUp: e: Types.KeyboardEvent -> unit

    type [<AllowNullLiteral>] InputStatic =
        [<EmitConstructor>] abstract Create: unit -> Input

module __native_desktop_RootView =
    module PropTypes = Prop_types
    module RN = React_native
    type BaseRootView = __native_common_RootView.BaseRootView
    type BaseRootViewProps = __native_common_RootView.BaseRootViewProps
    type RootViewBase = __native_common_RootView.RootView
    type RootViewPropsWithMainViewType = __native_common_RootView.RootViewPropsWithMainViewType
    type RootViewState = __native_common_RootView.RootViewState
    type RootViewUsingPropsBase = __native_common_RootView.RootViewUsingProps

    type [<AllowNullLiteral>] IExports =
        abstract RootViewUsingStore: obj
        abstract RootViewUsingProps: obj

module __native_desktop_ScrollView =
    module RN = React_native
    type ScrollViewBase = __native_common_ScrollView.ScrollView

    type [<AllowNullLiteral>] IExports =
        abstract ScrollView: ScrollViewStatic

    type [<AllowNullLiteral>] ScrollViewProps =
        interface end

    type [<AllowNullLiteral>] ScrollView =
        inherit ScrollViewBase
        abstract _render: nativeProps: ScrollViewProps -> JSX.Element

    type [<AllowNullLiteral>] ScrollViewStatic =
        [<EmitConstructor>] abstract Create: unit -> ScrollView

module __tslint_groupedImportRule =
    module Ts = Typescript
    type RuleFailure = Tslint.RuleFailure
    type Rules = Tslint.Rules

    type [<AllowNullLiteral>] IExports =
        abstract Rule: RuleStatic

    type [<AllowNullLiteral>] Rule =
        inherit Rules.AbstractRule
        abstract apply: sourceFile: Ts.SourceFile -> ResizeArray<RuleFailure>

    type [<AllowNullLiteral>] RuleStatic =
        [<EmitConstructor>] abstract Create: unit -> Rule
        abstract FAILURE_STRING_PART: string with get, set

module __tslint_incorrectThisPropsRule =
    module Ts = Typescript
    type RuleFailure = Tslint.RuleFailure
    type Rules = Tslint.Rules

    type [<AllowNullLiteral>] IExports =
        abstract Rule: RuleStatic

    type [<AllowNullLiteral>] Rule =
        inherit Rules.AbstractRule
        abstract apply: sourceFile: Ts.SourceFile -> ResizeArray<RuleFailure>

    type [<AllowNullLiteral>] RuleStatic =
        [<EmitConstructor>] abstract Create: unit -> Rule

module __tslint_noUnreferencedStylesRule =
    module Ts = Typescript
    type RuleFailure = Tslint.RuleFailure
    type Rules = Tslint.Rules

    type [<AllowNullLiteral>] IExports =
        abstract Rule: RuleStatic

    type [<AllowNullLiteral>] Rule =
        inherit Rules.AbstractRule
        abstract apply: sourceFile: Ts.SourceFile -> ResizeArray<RuleFailure>

    type [<AllowNullLiteral>] RuleStatic =
        [<EmitConstructor>] abstract Create: unit -> Rule

module __web_Accessibility =
    type CommonAccessibility = __common_Accessibility.Accessibility

    type [<AllowNullLiteral>] IExports =
        abstract Accessibility: AccessibilityStatic
        abstract _default: Accessibility

    type [<AllowNullLiteral>] Accessibility =
        inherit CommonAccessibility
        abstract isScreenReaderEnabled: unit -> bool

    type [<AllowNullLiteral>] AccessibilityStatic =
        [<EmitConstructor>] abstract Create: unit -> Accessibility

module __web_AccessibilityAnnouncer =

    type [<AllowNullLiteral>] IExports =
        abstract AccessibilityAnnouncer: AccessibilityAnnouncerStatic

    type [<AllowNullLiteral>] AccessibilityAnnouncerState =
        abstract announcementText: string with get, set
        abstract announcementTextInNestedDiv: bool with get, set

    type [<AllowNullLiteral>] AccessibilityAnnouncer =
        inherit React.Component<AccessibilityAnnouncerReactComponent, AccessibilityAnnouncerState>
        abstract componentDidUpdate: prevProps: AccessibilityAnnouncerComponentDidUpdatePrevProps * prevState: AccessibilityAnnouncerState -> unit
        abstract componentWillUnmount: unit -> unit
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] AccessibilityAnnouncerComponentDidUpdatePrevProps =
        interface end

    type [<AllowNullLiteral>] AccessibilityAnnouncerStatic =
        [<EmitConstructor>] abstract Create: props: AccessibilityAnnouncerStaticProps -> AccessibilityAnnouncer

    type [<AllowNullLiteral>] AccessibilityAnnouncerStaticProps =
        interface end

    type [<AllowNullLiteral>] AccessibilityAnnouncerReactComponent =
        interface end

module __web_AccessibilityUtil =
    type CommonAccessibiltiyUtil = __common_AccessibilityUtil.AccessibilityUtil
    type Types = __common_Interfaces.Types

    type [<AllowNullLiteral>] IExports =
        abstract AccessibilityUtil: AccessibilityUtilStatic
        abstract _default: AccessibilityUtil

    type [<AllowNullLiteral>] AccessibilityUtil =
        inherit CommonAccessibiltiyUtil
        abstract accessibilityLiveRegionToString: liveRegion: Types.AccessibilityLiveRegion -> Types.AriaLive option
        abstract accessibilityTraitToString: traits: U2<Types.AccessibilityTrait, ResizeArray<Types.AccessibilityTrait>> option * ?defaultTrait: Types.AccessibilityTrait -> string option
        abstract accessibilityTraitToAriaSelected: traits: U2<Types.AccessibilityTrait, ResizeArray<Types.AccessibilityTrait>> option -> bool option
        abstract accessibilityTraitToAriaChecked: traits: U2<Types.AccessibilityTrait, ResizeArray<Types.AccessibilityTrait>> option -> bool option
        abstract accessibilityTraitToAriaHasPopup: traits: U2<Types.AccessibilityTrait, ResizeArray<Types.AccessibilityTrait>> option -> bool option

    type [<AllowNullLiteral>] AccessibilityUtilStatic =
        [<EmitConstructor>] abstract Create: unit -> AccessibilityUtil

module __web_ActivityIndicator =
    type Types = __common_Interfaces.Types

    type [<AllowNullLiteral>] IExports =
        abstract ActivityIndicator: ActivityIndicatorStatic

    type [<AllowNullLiteral>] ActivityIndicatorState =
        abstract isVisible: bool option with get, set

    type [<AllowNullLiteral>] ActivityIndicator =
        inherit React.Component<Types.ActivityIndicatorProps, ActivityIndicatorState>
        abstract componentDidMount: unit -> unit
        abstract componentWillUnmount: unit -> unit
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] ActivityIndicatorStatic =
        [<EmitConstructor>] abstract Create: props: Types.ActivityIndicatorProps -> ActivityIndicator

module __web_Alert =
    module RX = ___common_Interfaces

    type [<AllowNullLiteral>] IExports =
        abstract Alert: AlertStatic
        abstract _default: Alert

    type [<AllowNullLiteral>] Alert =
        inherit RX.Alert
        abstract show: title: string * ?message: string * ?buttons: ResizeArray<RX.Types.AlertButtonSpec> * ?options: RX.Types.AlertOptions -> unit

    type [<AllowNullLiteral>] AlertStatic =
        [<EmitConstructor>] abstract Create: unit -> Alert

module __web_AlertModalContent =
    module RX = ___common_Interfaces

    type [<AllowNullLiteral>] IExports =
        abstract AlertModalContent: AlertModalContentStatic

    type [<AllowNullLiteral>] AppModalContentProps =
        inherit RX.Types.ViewProps
        abstract buttons: ResizeArray<RX.Types.AlertButtonSpec> option with get, set
        abstract title: string with get, set
        abstract message: string option with get, set
        abstract modalId: string with get, set
        abstract theme: RX.Types.AlertModalTheme option with get, set
        abstract preventDismissOnPress: bool option with get, set

    type [<AllowNullLiteral>] AppModalContentState =
        abstract hoverIndex: float with get, set

    type [<AllowNullLiteral>] AlertModalContent =
        inherit RX.Component<AppModalContentProps, AppModalContentState>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] AlertModalContentStatic =
        [<EmitConstructor>] abstract Create: props: AppModalContentProps -> AlertModalContent

module __web_Animated =
    module RX = ___common_Interfaces

    type [<AllowNullLiteral>] IExports =
        abstract Animation: AnimationStatic
        abstract Value: ValueStatic
        abstract InterpolatedValue: InterpolatedValueStatic
        abstract timing: RX.Types.Animated.TimingFunction with get, set
        abstract sequence: RX.Types.Animated.SequenceFunction with get, set
        abstract ``parallel``: RX.Types.Animated.ParallelFunction with get, set
        abstract Image: obj with get, set
        abstract Text: obj with get, set
        abstract TextInput: obj with get, set
        abstract View: obj with get, set
        abstract createValue: (float -> Value) with get, set
        abstract interpolate: (Value -> ResizeArray<float> -> ResizeArray<string> -> Value) with get, set

    type [<AllowNullLiteral>] Animation =
        abstract _id: float option with get, set
        abstract start: ?onEnd: RX.Types.Animated.EndCallback -> unit
        abstract stop: unit -> unit

    type [<AllowNullLiteral>] AnimationStatic =
        [<EmitConstructor>] abstract Create: unit -> Animation

    type [<AllowNullLiteral>] ValueListener =
        abstract setValue: valueObject: Value * newValue: U2<float, string> -> unit
        abstract startTransition: valueObject: Value * from: U2<float, string> * toValue: U2<float, string> * duration: float * easing: string * delay: float * onEnd: RX.Types.Animated.EndCallback -> unit
        abstract stopTransition: valueObject: Value -> U2<float, string> option

    type [<AllowNullLiteral>] Value =
        inherit RX.Types.AnimatedValue
        abstract _value: U2<float, string> with get, set
        abstract _getInputValue: unit -> U2<float, string>
        abstract _getOutputValue: unit -> U2<float, string>
        abstract _getInterpolatedValue: inputVal: U2<float, string> -> U2<float, string>
        abstract _isInterpolated: unit -> bool
        abstract interpolate: config: RX.Types.Animated.InterpolationConfigType -> InterpolatedValue
        abstract setValue: value: U2<float, string> -> unit
        abstract _addListener: listenerToAdd: ValueListener -> unit
        abstract _removeListener: listenerToRemove: ValueListener -> unit
        abstract _removeAllListeners: unit -> unit
        abstract _startTransition: toValue: U2<float, string> * duration: float * easing: string * delay: float * onEnd: RX.Types.Animated.EndCallback -> unit
        abstract _stopTransition: unit -> unit
        abstract _updateFinalValue: value: U2<float, string> -> unit

    type [<AllowNullLiteral>] ValueStatic =
        [<EmitConstructor>] abstract Create: value: float -> Value

    type [<AllowNullLiteral>] InterpolatedValue =
        inherit Value
        abstract _startTransition: toValue: U2<float, string> * duration: float * easing: string * delay: float * onEnd: RX.Types.Animated.EndCallback -> unit
        abstract _convertValueToNumeric: inputVal: U2<float, string> -> float
        abstract _addUnitsToNumericValue: value: float * templateValue: U2<float, string> -> U2<float, string>
        abstract _getInterpolatedValue: inputVal: U2<float, string> -> U2<float, string>
        abstract _isInterpolated: unit -> bool

    type [<AllowNullLiteral>] InterpolatedValueStatic =
        [<EmitConstructor>] abstract Create: _config: RX.Types.Animated.InterpolationConfigType * rootValue: Value -> InterpolatedValue

    type Image =
        RX.AnimatedImage

    type Text =
        RX.AnimatedText

    type TextInput =
        RX.AnimatedTextInput

    type View =
        RX.AnimatedView

module __web_App =
    module RX = ___common_Interfaces

    type [<AllowNullLiteral>] IExports =
        abstract App: AppStatic
        abstract _default: App

    type [<AllowNullLiteral>] App =
        inherit RX.App
        abstract initialize: debug: bool * development: bool -> unit
        abstract getActivationState: unit -> RX.Types.AppActivationState

    type [<AllowNullLiteral>] AppStatic =
        [<EmitConstructor>] abstract Create: unit -> App

module __web_Button =
    module PropTypes = Prop_types
    type FocusArbitratorProvider = __common_utils_AutoFocusHelper.FocusArbitratorProvider
    type ButtonBase = __common_Interfaces.Button
    type Types = __common_Interfaces.Types

    type [<AllowNullLiteral>] IExports =
        abstract Button: ButtonStatic

    type [<AllowNullLiteral>] ButtonContext =
        abstract hasRxButtonAscendant: bool option with get, set
        abstract focusArbitrator: FocusArbitratorProvider option with get, set

    type [<AllowNullLiteral>] Button =
        inherit ButtonBase
        abstract context: ButtonContext with get, set
        abstract getChildContext: unit -> ButtonContext
        abstract render: unit -> JSX.Element
        abstract componentDidMount: unit -> unit
        abstract requestFocus: unit -> unit
        abstract focus: unit -> unit
        abstract blur: unit -> unit
        abstract onClick: (Types.MouseEvent -> unit) with get, set

    type [<AllowNullLiteral>] ButtonStatic =
        abstract contextTypes: ButtonStaticContextTypes with get, set
        abstract childContextTypes: ButtonStaticChildContextTypes with get, set
        [<EmitConstructor>] abstract Create: props: Types.ButtonProps * ?context: ButtonContext -> Button

    type [<AllowNullLiteral>] ButtonStaticContextTypes =
        abstract hasRxButtonAscendant: obj with get, set
        abstract focusArbitrator: obj with get, set

    type [<AllowNullLiteral>] ButtonStaticChildContextTypes =
        abstract hasRxButtonAscendant: obj with get, set

module __web_Clipboard =
    module SyncTasks = Synctasks
    module RX = ___common_Interfaces

    type [<AllowNullLiteral>] IExports =
        abstract Clipboard: ClipboardStatic
        abstract _default: Clipboard

    type [<AllowNullLiteral>] Clipboard =
        inherit RX.Clipboard
        abstract setText: text: string -> unit
        abstract getText: unit -> SyncTasks.Promise<string>

    type [<AllowNullLiteral>] ClipboardStatic =
        [<EmitConstructor>] abstract Create: unit -> Clipboard

module __web_CustomScrollbar =

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
        abstract update: unit -> unit
        abstract show: unit -> unit
        abstract hide: unit -> unit
        abstract init: ?options: ScrollbarOptions -> unit
        abstract dispose: unit -> unit

    type [<AllowNullLiteral>] ScrollbarStatic =
        abstract getNativeScrollbarWidth: unit -> float
        [<EmitConstructor>] abstract Create: container: HTMLElement -> Scrollbar

module __web_FrontLayerViewManager =
    type Types = __common_Interfaces.Types

    type [<AllowNullLiteral>] IExports =
        abstract FrontLayerViewManager: FrontLayerViewManagerStatic
        abstract _default: FrontLayerViewManager

    type [<AllowNullLiteral>] FrontLayerViewManager =
        abstract setMainView: element: React.ReactElement<obj option> -> unit
        abstract isModalDisplayed: ?modalId: string -> bool
        abstract showModal: modal: React.ReactElement<Types.ViewProps> * modalId: string * ?options: Types.ModalOptions -> unit
        abstract dismissModal: modalId: string -> unit
        abstract dismissAllModals: unit -> unit
        abstract showPopup: options: Types.PopupOptions * popupId: string * ?showDelay: float -> bool
        abstract autoDismissPopup: popupId: string * ?dismissDelay: float -> unit
        abstract dismissPopup: popupId: string -> unit
        abstract dismissAllPopups: unit -> unit
        abstract isPopupDisplayed: ?popupId: string -> bool
        abstract allowRTL: allow: bool -> unit
        abstract forceRTL: force: bool -> unit
        abstract isRTL: unit -> bool

    type [<AllowNullLiteral>] FrontLayerViewManagerStatic =
        [<EmitConstructor>] abstract Create: unit -> FrontLayerViewManager

module __web_GestureView =
    type Types = __common_Interfaces.Types

    type [<AllowNullLiteral>] IExports =
        abstract GestureView: GestureViewStatic

    type [<AllowNullLiteral>] GestureViewContext =
        abstract isInRxMainView: bool option with get, set

    type [<AllowNullLiteral>] GestureView =
        inherit React.Component<Types.GestureViewProps, Types.Stateless>
        abstract componentDidMount: unit -> unit
        abstract componentWillUnmount: unit -> unit
        abstract render: unit -> JSX.Element
        abstract blur: unit -> unit
        abstract focus: unit -> unit
        abstract _getContainer: unit -> HTMLElement option

    type [<AllowNullLiteral>] GestureViewStatic =
        [<EmitConstructor>] abstract Create: unit -> GestureView
        abstract contextTypes: React.ValidationMap<obj option> with get, set

module __web_Image =
    module SyncTasks = Synctasks
    type Types = __common_Interfaces.Types

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
        abstract context: ImageContext with get, set
        abstract getChildContext: unit -> ImageGetChildContextReturn
        abstract componentWillReceiveProps: nextProps: Types.ImageProps -> unit
        abstract componentDidMount: unit -> unit
        abstract componentWillUnmount: unit -> unit
        abstract render: unit -> JSX.Element
        abstract _onMount: (HTMLImageElement option -> unit) with get, set
        abstract getNativeWidth: unit -> float option
        abstract getNativeHeight: unit -> float option

    type [<AllowNullLiteral>] ImageGetChildContextReturn =
        abstract isRxParentAText: bool with get, set

    type [<AllowNullLiteral>] ImageStatic =
        abstract contextTypes: React.ValidationMap<obj option> with get, set
        abstract childContextTypes: React.ValidationMap<obj option> with get, set
        abstract prefetch: url: string -> SyncTasks.Promise<bool>
        abstract getMetadata: url: string -> SyncTasks.Promise<Types.ImageMetadata>
        [<EmitConstructor>] abstract Create: props: Types.ImageProps -> Image

module __web_Input =
    module RX = ___common_Interfaces

    type [<AllowNullLiteral>] IExports =
        abstract Input: InputStatic
        abstract _default: Input

    type [<AllowNullLiteral>] Input =
        inherit RX.Input
        abstract dispatchKeyDown: e: RX.Types.KeyboardEvent -> unit
        abstract dispatchKeyUp: e: RX.Types.KeyboardEvent -> unit

    type [<AllowNullLiteral>] InputStatic =
        [<EmitConstructor>] abstract Create: unit -> Input

module __web_International =
    module RX = ___common_Interfaces

    type [<AllowNullLiteral>] IExports =
        abstract International: InternationalStatic
        abstract _default: International

    type [<AllowNullLiteral>] International =
        inherit RX.International
        abstract allowRTL: allow: bool -> unit
        abstract forceRTL: force: bool -> unit
        abstract isRTL: unit -> bool

    type [<AllowNullLiteral>] InternationalStatic =
        [<EmitConstructor>] abstract Create: unit -> International

module __web_Link =
    module PropTypes = Prop_types
    type FocusArbitratorProvider = __common_utils_AutoFocusHelper.FocusArbitratorProvider
    type Types = __common_Interfaces.Types

    type [<AllowNullLiteral>] IExports =
        abstract Link: LinkStatic

    type [<AllowNullLiteral>] LinkContext =
        abstract focusArbitrator: FocusArbitratorProvider option with get, set

    type [<AllowNullLiteral>] Link =
        inherit React.Component<Types.LinkProps, Types.Stateless>
        abstract context: LinkContext with get, set
        abstract render: unit -> JSX.Element
        abstract componentDidMount: unit -> unit
        abstract requestFocus: unit -> unit
        abstract focus: unit -> unit
        abstract blur: unit -> unit

    type [<AllowNullLiteral>] LinkStatic =
        [<EmitConstructor>] abstract Create: unit -> Link
        abstract contextTypes: LinkStaticContextTypes with get, set

    type [<AllowNullLiteral>] LinkStaticContextTypes =
        abstract focusArbitrator: obj with get, set

module __web_Linking =
    module SyncTasks = Synctasks
    type Types = __common_Interfaces.Types
    type CommonLinking = __common_Linking.Linking

    type [<AllowNullLiteral>] IExports =
        abstract Linking: LinkingStatic
        abstract _default: Linking

    type [<AllowNullLiteral>] Linking =
        inherit CommonLinking
        abstract _openUrl: url: string -> SyncTasks.Promise<unit>
        abstract launchEmail: emailInfo: Types.EmailInfo -> SyncTasks.Promise<unit>
        abstract getInitialUrl: unit -> SyncTasks.Promise<string option>

    type [<AllowNullLiteral>] LinkingStatic =
        [<EmitConstructor>] abstract Create: unit -> Linking

module __web_Modal =
    module RX = ___common_Interfaces

    type [<AllowNullLiteral>] IExports =
        abstract Modal: ModalStatic
        abstract _default: Modal

    type [<AllowNullLiteral>] Modal =
        inherit RX.Modal
        abstract isDisplayed: ?modalId: string -> bool
        abstract show: modal: React.ReactElement<RX.Types.ViewProps> * modalId: string * ?options: RX.Types.ModalOptions -> unit
        abstract dismiss: modalId: string -> unit
        abstract dismissAll: unit -> unit

    type [<AllowNullLiteral>] ModalStatic =
        [<EmitConstructor>] abstract Create: unit -> Modal

module __web_ModalContainer =
    type Types = __common_Interfaces.Types

    type [<AllowNullLiteral>] IExports =
        abstract ModalContainer: ModalContainerStatic

    type [<AllowNullLiteral>] ModalContainer =
        inherit React.Component<Types.CommonProps<ModalContainer>, Types.Stateless>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] ModalContainerStatic =
        [<EmitConstructor>] abstract Create: props: Types.CommonProps<ModalContainer> -> ModalContainer

module __web_Network =
    module SyncTasks = Synctasks
    module RX = ___common_Interfaces

    type [<AllowNullLiteral>] IExports =
        abstract Network: NetworkStatic
        abstract _default: Network

    type [<AllowNullLiteral>] Network =
        inherit RX.Network
        abstract isConnected: unit -> SyncTasks.Promise<bool>
        abstract getType: unit -> SyncTasks.Promise<RX.Types.DeviceNetworkType>

    type [<AllowNullLiteral>] NetworkStatic =
        [<EmitConstructor>] abstract Create: unit -> Network

module __web_Picker =
    module RX = ___common_Interfaces

    type [<AllowNullLiteral>] IExports =
        abstract Picker: PickerStatic

    type [<AllowNullLiteral>] Picker =
        inherit RX.Picker
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] PickerStatic =
        [<EmitConstructor>] abstract Create: unit -> Picker

module __web_Platform =
    module RX = ___common_Interfaces

    type [<AllowNullLiteral>] IExports =
        abstract Platform: PlatformStatic
        abstract _default: Platform

    type [<AllowNullLiteral>] Platform =
        inherit RX.Platform
        abstract getType: unit -> RX.Types.PlatformType
        abstract select: specifics: obj -> 'T option

    type [<AllowNullLiteral>] PlatformStatic =
        [<EmitConstructor>] abstract Create: unit -> Platform

module __web_Popup =
    module RX = ___common_Interfaces

    type [<AllowNullLiteral>] IExports =
        abstract Popup: PopupStatic
        abstract _default: Popup

    type [<AllowNullLiteral>] Popup =
        inherit RX.Popup
        abstract show: options: RX.Types.PopupOptions * popupId: string * ?delay: float -> bool
        abstract autoDismiss: popupId: string * ?delay: float -> unit
        abstract dismiss: popupId: string -> unit
        abstract dismissAll: unit -> unit
        abstract isDisplayed: ?popupId: string -> bool

    type [<AllowNullLiteral>] PopupStatic =
        [<EmitConstructor>] abstract Create: unit -> Popup

module __web_PopupContainerView =
    type Types = __common_Interfaces.Types
    type PopupContainerViewBase = __common_PopupContainerViewBase.PopupContainerViewBase
    type PopupContainerViewBaseProps = __common_PopupContainerViewBase.PopupContainerViewBaseProps
    type PopupContainerViewContext = __common_PopupContainerViewBase.PopupContainerViewContext

    type [<AllowNullLiteral>] IExports =
        abstract PopupContainerView: PopupContainerViewStatic

    type [<AllowNullLiteral>] PopupContainerViewProps =
        inherit PopupContainerViewBaseProps<PopupContainerView>
        abstract style: React.CSSProperties with get, set
        abstract onMouseEnter: (React.MouseEvent<HTMLDivElement> -> unit) option with get, set
        abstract onMouseLeave: (React.MouseEvent<HTMLDivElement> -> unit) option with get, set

    type [<AllowNullLiteral>] PopupContainerView =
        inherit PopupContainerViewBase<PopupContainerViewProps, Types.Stateless, PopupContainerView>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] PopupContainerViewStatic =
        [<EmitConstructor>] abstract Create: props: PopupContainerViewProps * ?context: PopupContainerViewContext -> PopupContainerView

module __web_ReactXP =
    let [<ImportAll("reactxp/web/ReactXP")>] reactXP: ReactXP.IExports = jsNative

    module ReactXP =

        type [<AllowNullLiteral>] IExports =
            abstract Accessibility: RXInterfaces.Accessibility with get, set
            abstract ActivityIndicator: obj with get, set
            abstract Alert: RXInterfaces.Alert with get, set
            abstract App: RXInterfaces.App with get, set
            abstract Button: obj with get, set
            abstract Picker: obj with get, set
            abstract Clipboard: RXInterfaces.Clipboard with get, set
            abstract GestureView: obj with get, set
            abstract Image: RXInterfaces.ImageConstructor with get, set
            abstract Input: RXInterfaces.Input with get, set
            abstract International: RXInterfaces.International with get, set
            abstract Link: obj with get, set
            abstract Linking: RXInterfaces.Linking with get, set
            abstract Location: RXInterfaces.Location with get, set
            abstract Modal: RXInterfaces.Modal with get, set
            abstract Network: RXInterfaces.Network with get, set
            abstract Platform: RXInterfaces.Platform with get, set
            abstract Popup: RXInterfaces.Popup with get, set
            abstract ScrollView: RXInterfaces.ScrollViewConstructor with get, set
            abstract StatusBar: RXInterfaces.StatusBar with get, set
            abstract Storage: RXInterfaces.Storage with get, set
            abstract Styles: RXInterfaces.Styles with get, set
            abstract Text: obj with get, set
            abstract TextInput: obj with get, set
            abstract UserInterface: RXInterfaces.UserInterface with get, set
            abstract UserPresence: RXInterfaces.UserPresence with get, set
            abstract View: obj with get, set
            abstract WebView: RXInterfaces.WebViewConstructor with get, set
            abstract __spread: obj option with get, set

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
    type Types = __common_Interfaces.Types
    type RecalcResult = __common_PopupContainerViewBase.RecalcResult

    type [<AllowNullLiteral>] IExports =
        abstract PopupDescriptor: PopupDescriptorStatic
        abstract MainViewContainer: MainViewContainerStatic
        abstract RootView: RootViewStatic

    type [<AllowNullLiteral>] PopupDescriptor =
        abstract popupId: string with get, set
        abstract popupOptions: Types.PopupOptions with get, set

    type [<AllowNullLiteral>] PopupDescriptorStatic =
        [<EmitConstructor>] abstract Create: popupId: string * popupOptions: Types.PopupOptions -> PopupDescriptor

    type [<AllowNullLiteral>] RootViewProps =
        inherit Types.CommonProps<RootView>
        abstract mainView: React.ReactNode option with get, set
        abstract modal: React.ReactElement<Types.ViewProps> option with get, set
        abstract activePopup: PopupDescriptor option with get, set
        abstract cachedPopup: ResizeArray<PopupDescriptor> option with get, set
        abstract autoDismiss: bool option with get, set
        abstract autoDismissDelay: float option with get, set
        abstract onDismissPopup: (unit -> unit) option with get, set
        abstract keyBoardFocusOutline: string option with get, set
        abstract mouseFocusOutline: string option with get, set
        abstract writingDirection: RootViewPropsWritingDirection option with get, set

    type [<AllowNullLiteral>] RootViewState =
        inherit RecalcResult
        abstract isMeasuringPopup: bool with get, set
        abstract popupWidth: float with get, set
        abstract popupHeight: float with get, set
        abstract focusClass: string option with get, set

    type [<AllowNullLiteral>] MainViewContext =
        abstract isInRxMainView: bool option with get, set

    type [<AllowNullLiteral>] MainViewContainer =
        inherit React.Component<Types.CommonProps<MainViewContainer>, Types.Stateless>
        inherit React.ChildContextProvider<MainViewContext>
        abstract getChildContext: unit -> MainViewContext
        abstract render: unit -> obj

    type [<AllowNullLiteral>] MainViewContainerStatic =
        [<EmitConstructor>] abstract Create: unit -> MainViewContainer
        abstract childContextTypes: React.ValidationMap<obj option> with get, set

    type [<AllowNullLiteral>] RootView =
        inherit React.Component<RootViewProps, RootViewState>
        abstract getChildContext: unit -> RootViewGetChildContextReturn
        abstract componentWillReceiveProps: prevProps: RootViewProps -> unit
        abstract componentDidUpdate: prevProps: RootViewProps * prevState: RootViewState -> unit
        abstract componentDidMount: unit -> unit
        abstract componentWillUnmount: unit -> unit
        abstract render: unit -> JSX.Element
        abstract _onMount: (PopupContainerView option -> unit) with get, set

    type [<AllowNullLiteral>] RootViewGetChildContextReturn =
        abstract focusManager: FocusManager with get, set

    type [<AllowNullLiteral>] RootViewStatic =
        abstract childContextTypes: React.ValidationMap<obj option> with get, set
        [<EmitConstructor>] abstract Create: props: RootViewProps -> RootView

    type [<StringEnum>] [<RequireQualifiedAccess>] RootViewPropsWritingDirection =
        | Auto
        | Rtl
        | Ltr

module __web_ScrollView =
    module RX = ___common_Interfaces

    type [<AllowNullLiteral>] IExports =
        abstract ScrollView: ScrollViewStatic

    type [<AllowNullLiteral>] ScrollView =
        inherit ViewBase<RX.Types.ScrollViewProps, RX.Types.Stateless, RX.ScrollView>
        inherit RX.ScrollView
        abstract componentDidUpdate: unit -> unit
        abstract render: unit -> JSX.Element
        abstract componentWillMount: unit -> unit
        abstract componentDidMount: unit -> unit
        abstract componentWillReceiveProps: newProps: RX.Types.ScrollViewProps -> unit
        abstract componentWillUnmount: unit -> unit
        abstract _getContainer: unit -> HTMLElement option
        abstract _onMount: (HTMLElement option -> unit) with get, set
        abstract setScrollTop: scrollTop: float * ?animate: bool -> unit
        abstract setScrollLeft: scrollLeft: float * ?animate: bool -> unit

    type [<AllowNullLiteral>] ScrollViewStatic =
        [<EmitConstructor>] abstract Create: props: RX.Types.ScrollViewProps -> ScrollView

module __web_ScrollViewConfig =

    type [<AllowNullLiteral>] IExports =
        /// ScrollViewConfig.ts
        /// 
        /// Copyright (c) Microsoft Corporation. All rights reserved.
        /// Licensed under the MIT license.
        /// 
        /// Web-specific scroll view configuration, required to avoid circular
        /// dependency between application and ScrollView.
        abstract ScrollViewConfig: ScrollViewConfigStatic
        abstract _default: ScrollViewConfig

    /// ScrollViewConfig.ts
    /// 
    /// Copyright (c) Microsoft Corporation. All rights reserved.
    /// Licensed under the MIT license.
    /// 
    /// Web-specific scroll view configuration, required to avoid circular
    /// dependency between application and ScrollView.
    type [<AllowNullLiteral>] ScrollViewConfig =
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
        [<EmitConstructor>] abstract Create: unit -> ScrollViewConfig

module __web_StatusBar =
    module RX = ___common_Interfaces

    type [<AllowNullLiteral>] IExports =
        abstract StatusBar: StatusBarStatic
        abstract _default: StatusBar

    type [<AllowNullLiteral>] StatusBar =
        inherit RX.StatusBar
        abstract isOverlay: unit -> bool
        abstract setBarStyle: style: StatusBarSetBarStyleStyle * animated: bool -> unit
        abstract setHidden: hidden: bool * showHideTransition: StatusBarSetHiddenShowHideTransition -> unit
        abstract setNetworkActivityIndicatorVisible: value: bool -> unit
        abstract setBackgroundColor: color: string * animated: bool -> unit
        abstract setTranslucent: translucent: bool -> unit

    type [<StringEnum>] [<RequireQualifiedAccess>] StatusBarSetBarStyleStyle =
        | Default
        | [<CompiledName "light-content">] LightContent
        | [<CompiledName "dark-content">] DarkContent

    type [<StringEnum>] [<RequireQualifiedAccess>] StatusBarSetHiddenShowHideTransition =
        | Fade
        | Slide

    type [<AllowNullLiteral>] StatusBarStatic =
        [<EmitConstructor>] abstract Create: unit -> StatusBar

module __web_Storage =
    module SyncTasks = Synctasks
    module RX = ___common_Interfaces

    type [<AllowNullLiteral>] IExports =
        abstract Storage: StorageStatic
        abstract _default: Storage

    type [<AllowNullLiteral>] Storage =
        inherit RX.Storage
        abstract getItem: key: string -> SyncTasks.Promise<string option>
        abstract setItem: key: string * value: string -> SyncTasks.Promise<unit>
        abstract removeItem: key: string -> SyncTasks.Promise<unit>
        abstract clear: unit -> SyncTasks.Promise<unit>

    type [<AllowNullLiteral>] StorageStatic =
        [<EmitConstructor>] abstract Create: unit -> Storage

module __web_Styles =
    module RX = ___common_Interfaces

    type [<AllowNullLiteral>] IExports =
        abstract Styles: StylesStatic
        abstract memoize: func: 'T * ?resolver: (ResizeArray<obj option> -> obj option) -> 'T
        abstract _default: Styles

    type [<AllowNullLiteral>] CssAliasMap =
        [<EmitIndexer>] abstract Item: prop: string -> string with get, set

    type [<AllowNullLiteral>] Styles =
        inherit RX.Styles
        abstract combine: ruleSet1: RX.Types.StyleRuleSetRecursive<'S> option * ?ruleSet2: RX.Types.StyleRuleSetRecursive<'S> -> 'S option
        abstract createViewStyle: ruleSet: RX.Types.ViewStyle * ?cacheStyle: bool -> RX.Types.ViewStyleRuleSet
        abstract createAnimatedViewStyle: ruleSet: RX.Types.AnimatedViewStyle -> RX.Types.AnimatedViewStyleRuleSet
        abstract createScrollViewStyle: ruleSet: RX.Types.ScrollViewStyle * ?cacheStyle: bool -> RX.Types.ScrollViewStyleRuleSet
        abstract createButtonStyle: ruleSet: RX.Types.ButtonStyle * ?cacheStyle: bool -> RX.Types.ButtonStyleRuleSet
        abstract createWebViewStyle: ruleSet: RX.Types.WebViewStyle * ?cacheStyle: bool -> RX.Types.WebViewStyleRuleSet
        abstract createTextStyle: ruleSet: RX.Types.TextStyle * ?cacheStyle: bool -> RX.Types.TextStyleRuleSet
        abstract createAnimatedTextStyle: ruleSet: RX.Types.AnimatedTextStyle -> RX.Types.AnimatedTextStyleRuleSet
        abstract createTextInputStyle: ruleSet: RX.Types.TextInputStyle * ?cacheStyle: bool -> RX.Types.TextInputStyleRuleSet
        abstract createAnimatedTextInputStyle: ruleSet: RX.Types.AnimatedTextInputStyle -> RX.Types.AnimatedTextInputStyleRuleSet
        abstract createLinkStyle: ruleSet: RX.Types.LinkStyle * ?cacheStyle: bool -> RX.Types.LinkStyleRuleSet
        abstract createImageStyle: ruleSet: RX.Types.ImageStyle * ?cacheStyle: bool -> RX.Types.ImageStyleRuleSet
        abstract createAnimatedImageStyle: ruleSet: RX.Types.AnimatedImageStyle -> RX.Types.AnimatedImageStyleRuleSet
        abstract createPickerStyle: ruleSet: RX.Types.PickerStyle * ?cacheStyle: bool -> RX.Types.PickerStyleRuleSet
        abstract convertJsToCssStyle: prop: string -> string
        abstract _cssPropertyAliasesCssStyle: (unit -> CssAliasMap) with get, set
        abstract getCssPropertyAliasesCssStyle: unit -> StylesGetCssPropertyAliasesCssStyleReturn
        abstract getParentComponentName: ``component``: obj option -> string

    type [<AllowNullLiteral>] StylesGetCssPropertyAliasesCssStyleReturn =
        [<EmitIndexer>] abstract Item: key: string -> string with get, set

    type [<AllowNullLiteral>] StylesStatic =
        [<EmitConstructor>] abstract Create: unit -> Styles

module __web_Text =
    module PropTypes = Prop_types
    type FocusArbitratorProvider = __common_utils_AutoFocusHelper.FocusArbitratorProvider
    type TextBase = __common_Interfaces.Text

    type [<AllowNullLiteral>] IExports =
        abstract Text: TextStatic

    type [<AllowNullLiteral>] TextContext =
        abstract isRxParentAText: bool with get, set
        abstract focusArbitrator: FocusArbitratorProvider option with get, set

    type [<AllowNullLiteral>] Text =
        inherit TextBase
        abstract context: TextContext with get, set
        abstract getChildContext: unit -> TextGetChildContextReturn
        abstract render: unit -> JSX.Element
        abstract componentDidMount: unit -> unit
        abstract blur: unit -> unit
        abstract requestFocus: unit -> unit
        abstract focus: unit -> unit
        abstract getSelectedText: unit -> string

    type [<AllowNullLiteral>] TextGetChildContextReturn =
        abstract isRxParentAText: bool with get, set

    type [<AllowNullLiteral>] TextStatic =
        [<EmitConstructor>] abstract Create: unit -> Text
        abstract contextTypes: TextStaticContextTypes with get, set
        abstract childContextTypes: React.ValidationMap<obj option> with get, set

    type [<AllowNullLiteral>] TextStaticContextTypes =
        abstract focusArbitrator: obj with get, set

module __web_TextInput =
    type FocusArbitratorProvider = __common_utils_AutoFocusHelper.FocusArbitratorProvider
    type Types = __common_Interfaces.Types

    type [<AllowNullLiteral>] IExports =
        abstract TextInput: TextInputStatic

    type [<AllowNullLiteral>] TextInputState =
        abstract inputValue: string option with get, set
        abstract autoResize: bool option with get, set

    type [<AllowNullLiteral>] TextInputContext =
        abstract focusArbitrator: FocusArbitratorProvider option with get, set

    type [<AllowNullLiteral>] TextInput =
        inherit React.Component<Types.TextInputProps, TextInputState>
        abstract context: TextInputContext with get, set
        abstract componentWillReceiveProps: nextProps: Types.TextInputProps -> unit
        abstract componentDidMount: unit -> unit
        abstract componentWillUnmount: unit -> unit
        abstract render: unit -> JSX.Element
        abstract blur: unit -> unit
        abstract requestFocus: unit -> unit
        abstract focus: unit -> unit
        abstract setAccessibilityFocus: unit -> unit
        abstract isFocused: unit -> bool
        abstract selectAll: unit -> unit
        abstract selectRange: start: float * ``end``: float -> unit
        abstract getSelectionRange: unit -> TextInputGetSelectionRangeReturn
        abstract setValue: value: string -> unit

    type [<AllowNullLiteral>] TextInputGetSelectionRangeReturn =
        abstract start: float with get, set
        abstract ``end``: float with get, set

    type [<AllowNullLiteral>] TextInputStatic =
        abstract contextTypes: React.ValidationMap<obj option> with get, set
        [<EmitConstructor>] abstract Create: props: Types.TextInputProps * ?context: TextInputContext -> TextInput

module __web_UserInterface =
    module SyncTasks = Synctasks
    module RX = ___common_Interfaces

    type [<AllowNullLiteral>] IExports =
        abstract UserInterface: UserInterfaceStatic
        abstract _default: UserInterface

    type [<AllowNullLiteral>] UserInterface =
        inherit RX.UserInterface
        abstract measureLayoutRelativeToWindow: ``component``: React.Component<obj option, obj option> -> SyncTasks.Promise<RX.Types.LayoutInfo>
        abstract measureLayoutRelativeToAncestor: ``component``: React.Component<obj option, obj option> * ancestor: React.Component<obj option, obj option> -> SyncTasks.Promise<RX.Types.LayoutInfo>
        abstract measureWindow: ?rootViewId: string -> RX.Types.LayoutInfo
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
        abstract evaluateTouchLatency: e: RX.Types.MouseEvent -> unit
        abstract isNavigatingWithKeyboard: unit -> bool

    type [<AllowNullLiteral>] UserInterfaceStatic =
        [<EmitConstructor>] abstract Create: unit -> UserInterface

module __web_UserPresence =
    module RX = ___common_Interfaces

    type [<AllowNullLiteral>] IExports =
        abstract UserPresence: UserPresenceStatic
        abstract instance: UserPresence

    type [<AllowNullLiteral>] UserPresence =
        inherit RX.UserPresence
        abstract isUserPresent: unit -> bool

    type [<AllowNullLiteral>] UserPresenceStatic =
        [<EmitConstructor>] abstract Create: unit -> UserPresence

module __web_View =
    module RX = ___common_Interfaces
    type FocusArbitratorProvider = __common_utils_AutoFocusHelper.FocusArbitratorProvider
    type FocusManager = __web_utils_FocusManager.FocusManager

    type [<AllowNullLiteral>] IExports =
        abstract View: ViewStatic

    type [<AllowNullLiteral>] ViewContext =
        abstract isRxParentAText: bool option with get, set
        abstract focusManager: FocusManager option with get, set
        abstract popupContainer: PopupContainerView option with get, set
        abstract focusArbitrator: FocusArbitratorProvider option with get, set

    type [<AllowNullLiteral>] View =
        inherit ViewBase<RX.Types.ViewProps, RX.Types.Stateless, RX.View>
        abstract context: ViewContext with get, set
        abstract getChildContext: unit -> ViewContext
        abstract _getContainer: unit -> HTMLElement option
        abstract setFocusRestricted: restricted: bool -> unit
        abstract setFocusLimited: limited: bool -> unit
        abstract render: unit -> React.ReactElement<obj option, U3<string, (obj option -> React.ReactElement<obj option, U3<string, obj option, obj>> option), obj>>
        abstract componentWillReceiveProps: nextProps: RX.Types.ViewProps -> unit
        abstract enableFocusManager: unit -> unit
        abstract disableFocusManager: unit -> unit
        abstract componentDidMount: unit -> unit
        abstract componentWillUnmount: unit -> unit
        abstract blur: unit -> unit
        abstract requestFocus: unit -> unit
        abstract focus: unit -> unit

    type [<AllowNullLiteral>] ViewStatic =
        abstract contextTypes: React.ValidationMap<obj option> with get, set
        abstract childContextTypes: React.ValidationMap<obj option> with get, set
        [<EmitConstructor>] abstract Create: props: RX.Types.ViewProps * ?context: ViewContext -> View

module __web_ViewBase =
    module SyncTasks = Synctasks
    module RX = ___common_Interfaces

    type [<AllowNullLiteral>] IExports =
        abstract ViewBase: ViewBaseStatic

    type [<AllowNullLiteral>] ViewBase<'P, 'S, 'C when 'P :> RX.Types.ViewPropsShared<'C>> =
        inherit RX.ViewBase<'P, 'S>
        abstract render: unit -> JSX.Element
        abstract _getContainer: unit -> HTMLElement option
        abstract _isMounted: bool with get, set
        abstract componentWillReceiveProps: nextProps: RX.Types.ViewPropsShared<'C> -> unit
        abstract _lastX: float with get, set
        abstract _lastY: float with get, set
        abstract _lastWidth: float with get, set
        abstract _lastHeight: float with get, set
        abstract _checkAndReportLayout: unit -> SyncTasks.Promise<unit>
        abstract componentDidMount: unit -> unit
        abstract componentDidUpdate: unit -> unit
        abstract componentWillUnmount: unit -> unit

    type [<AllowNullLiteral>] ViewBaseStatic =
        [<EmitConstructor>] abstract Create: unit -> ViewBase<'P, 'S, 'C> when 'P :> RX.Types.ViewPropsShared<'C>
        abstract setActivationState: newState: RX.Types.AppActivationState -> unit
        abstract _checkViews: unit -> unit
        abstract _reportDeferredLayoutChanges: unit -> unit

module __web_WebView =
    module RX = ___common_Interfaces

    type [<AllowNullLiteral>] IExports =
        abstract WebView: WebViewStatic

    type [<AllowNullLiteral>] WebViewState =
        abstract postComplete: bool option with get, set
        abstract webFormIdentifier: string option with get, set
        abstract webFrameIdentifier: string option with get, set

    type [<AllowNullLiteral>] WebView =
        inherit React.Component<RX.Types.WebViewProps, WebViewState>
        inherit RX.WebView
        abstract componentDidMount: unit -> unit
        abstract componentDidUpdate: prevProps: RX.Types.WebViewProps * prevState: WebViewState -> unit
        abstract componentWillUnmount: unit -> unit
        abstract render: unit -> JSX.Element
        abstract _onMount: (HTMLIFrameElement option -> unit) with get, set
        abstract postMessage: message: string * ?targetOrigin: string -> unit
        abstract reload: unit -> unit
        abstract goBack: unit -> unit
        abstract goForward: unit -> unit

    type [<AllowNullLiteral>] WebViewStatic =
        [<EmitConstructor>] abstract Create: props: RX.Types.WebViewProps -> WebView

module __web_window =

    type [<AllowNullLiteral>] IExports =
        abstract _default: Window

module __windows_Accessibility =
    type NativeAccessibility = __native_common_Accessibility.Accessibility

    type [<AllowNullLiteral>] IExports =
        abstract Accessibility: AccessibilityStatic
        abstract _default: Accessibility

    type [<AllowNullLiteral>] Accessibility =
        inherit NativeAccessibility
        abstract isHighContrastEnabled: unit -> bool

    type [<AllowNullLiteral>] AccessibilityStatic =
        [<EmitConstructor>] abstract Create: unit -> Accessibility

module __windows_AccessibilityAnnouncer =

    type [<AllowNullLiteral>] IExports =
        abstract AccessibilityAnnouncer: AccessibilityAnnouncerStatic

    type [<AllowNullLiteral>] AccessibilityAnnouncer =
        inherit React.Component<AccessibilityAnnouncerReactComponent, AccessibilityAnnouncerReactComponent>
        abstract componentWillUnmount: unit -> unit
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] AccessibilityAnnouncerStatic =
        [<EmitConstructor>] abstract Create: props: AccessibilityAnnouncerStaticProps -> AccessibilityAnnouncer

    type [<AllowNullLiteral>] AccessibilityAnnouncerStaticProps =
        interface end

    type [<AllowNullLiteral>] AccessibilityAnnouncerReactComponent =
        interface end

module __windows_AccessibilityUtil =
    type AccessibilityPlatformUtil = __common_AccessibilityUtil.AccessibilityPlatformUtil

    type [<AllowNullLiteral>] IExports =
        abstract AccessibilityUtil: AccessibilityUtilStatic
        abstract _default: AccessibilityUtil

    type [<AllowNullLiteral>] AccessibilityUtil =
        inherit AccessibilityPlatformUtil
        abstract setAccessibilityFocus: ``component``: React.Component<obj option, obj option> -> unit

    type [<AllowNullLiteral>] AccessibilityUtilStatic =
        [<EmitConstructor>] abstract Create: unit -> AccessibilityUtil

module __windows_App =
    type ComponentProvider = React_native.ComponentProvider
    type AppCommon = __native_common_App.App

    type [<AllowNullLiteral>] IExports =
        abstract App: AppStatic
        abstract _default: App

    type [<AllowNullLiteral>] App =
        inherit AppCommon
        abstract getRootViewFactory: unit -> ComponentProvider
        abstract getRootViewUsingPropsFactory: unit -> ComponentProvider

    type [<AllowNullLiteral>] AppStatic =
        [<EmitConstructor>] abstract Create: unit -> App

module __windows_Button =
    module RN = React_native
    type ImportantForAccessibilityValue = __native_common_AccessibilityUtil.ImportantForAccessibilityValue
    type ButtonBase = __native_common_Button.Button
    type ButtonContextBase = __native_common_Button.ButtonContext
    type FocusManagerFocusableComponent = __native_desktop_utils_FocusManager.FocusManagerFocusableComponent

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
        abstract _getContextMenuOffset: unit -> Button_getContextMenuOffsetReturn
        abstract _render: internalProps: RN.ViewProps * onMount: (obj option -> unit) -> JSX.Element
        abstract focus: unit -> unit
        abstract blur: unit -> unit
        abstract setNativeProps: nativeProps: RN.ViewProps -> unit
        abstract getChildContext: unit -> ButtonContext
        abstract _onHoverStart: (React.SyntheticEvent<obj option, Event> -> unit) with get, set
        abstract _onHoverEnd: (React.SyntheticEvent<obj option, Event> -> unit) with get, set
        abstract onFocus: unit -> unit
        abstract getTabIndex: unit -> float option
        abstract getImportantForAccessibility: unit -> ImportantForAccessibilityValue option
        abstract updateNativeAccessibilityProps: unit -> unit

    type [<AllowNullLiteral>] Button_getContextMenuOffsetReturn =
        abstract x: float with get, set
        abstract y: float with get, set

    type [<AllowNullLiteral>] ButtonStatic =
        [<EmitConstructor>] abstract Create: unit -> Button
        abstract childContextTypes: React.ValidationMap<obj option> with get, set

module __windows_GestureView =
    type BaseGestureView = __native_common_GestureView.GestureView
    type Types = __common_Interfaces.Types

    type [<AllowNullLiteral>] IExports =
        abstract GestureView: GestureViewStatic

    type [<AllowNullLiteral>] GestureView =
        inherit BaseGestureView
        abstract _getPreferredPanRatio: unit -> float
        abstract _getEventTimestamp: e: Types.TouchEvent -> float

    type [<AllowNullLiteral>] GestureViewStatic =
        [<EmitConstructor>] abstract Create: props: Types.GestureViewProps -> GestureView

module __windows_Link =
    module RN = React_native
    type ImportantForAccessibilityValue = __native_common_AccessibilityUtil.ImportantForAccessibilityValue
    type FocusManagerFocusableComponent = __native_desktop_utils_FocusManager.FocusManagerFocusableComponent
    type Types = __common_Interfaces.Types
    type LinkBase = __native_common_Link.LinkBase

    type [<AllowNullLiteral>] IExports =
        abstract Link: LinkStatic

    type [<AllowNullLiteral>] LinkState =
        abstract isRestrictedOrLimited: bool with get, set

    type [<AllowNullLiteral>] Link =
        inherit LinkBase<LinkState>
        inherit FocusManagerFocusableComponent
        abstract _getContextMenuOffset: unit -> Link_getContextMenuOffsetReturn
        abstract componentDidMount: unit -> unit
        abstract componentWillUnmount: unit -> unit
        abstract _render: internalProps: RN.TextProps * onMount: (obj option -> unit) -> JSX.Element
        abstract focus: unit -> unit
        abstract blur: unit -> unit
        abstract setNativeProps: nativeProps: RN.TextProps -> unit
        abstract requestFocus: unit -> unit
        abstract onFocus: unit -> unit
        abstract getTabIndex: unit -> float option
        abstract getImportantForAccessibility: unit -> ImportantForAccessibilityValue option
        abstract updateNativeAccessibilityProps: unit -> unit

    type [<AllowNullLiteral>] Link_getContextMenuOffsetReturn =
        abstract x: float with get, set
        abstract y: float with get, set

    type [<AllowNullLiteral>] LinkStatic =
        [<EmitConstructor>] abstract Create: props: Types.LinkProps -> Link

module __windows_ReactXP =
    let [<ImportAll("reactxp/windows/ReactXP")>] reactXP: ReactXP.IExports = jsNative

    module ReactXP =

        type [<AllowNullLiteral>] IExports =
            abstract Accessibility: RXInterfaces.Accessibility with get, set
            abstract ActivityIndicator: obj with get, set
            abstract Alert: RXInterfaces.Alert with get, set
            abstract App: RXInterfaces.App with get, set
            abstract Button: obj with get, set
            abstract Picker: obj with get, set
            abstract Clipboard: RXInterfaces.Clipboard with get, set
            abstract GestureView: obj with get, set
            abstract Image: RXInterfaces.ImageConstructor with get, set
            abstract Input: RXInterfaces.Input with get, set
            abstract International: RXInterfaces.International with get, set
            abstract Link: obj with get, set
            abstract Linking: RXInterfaces.Linking with get, set
            abstract Location: RXInterfaces.Location with get, set
            abstract Modal: RXInterfaces.Modal with get, set
            abstract Network: RXInterfaces.Network with get, set
            abstract Platform: RXInterfaces.Platform with get, set
            abstract Popup: RXInterfaces.Popup with get, set
            abstract ScrollView: RXInterfaces.ScrollViewConstructor with get, set
            abstract StatusBar: RXInterfaces.StatusBar with get, set
            abstract Storage: RXInterfaces.Storage with get, set
            abstract Styles: RXInterfaces.Styles with get, set
            abstract Text: obj with get, set
            abstract TextInput: obj with get, set
            abstract UserInterface: RXInterfaces.UserInterface with get, set
            abstract UserPresence: RXInterfaces.UserPresence with get, set
            abstract View: obj with get, set
            abstract WebView: RXInterfaces.WebViewConstructor with get, set
            abstract Animated: RXInterfaces.Animated
            abstract __spread: obj option with get, set

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
    type BaseRootView = __native_desktop_RootView.BaseRootView
    type BaseRootViewProps = __native_desktop_RootView.BaseRootViewProps
    type RootViewBase = __native_desktop_RootView.RootView
    type RootViewPropsWithMainViewType = __native_desktop_RootView.RootViewPropsWithMainViewType
    type RootViewState = __native_desktop_RootView.RootViewState
    type RootViewUsingPropsBase = __native_desktop_RootView.RootViewUsingProps

    type [<AllowNullLiteral>] IExports =
        abstract RootViewUsingStore: RootViewUsingStoreStatic
        abstract RootViewUsingProps: RootViewUsingPropsStatic

    type [<AllowNullLiteral>] RootViewUsingStore =
        inherit RootViewBase
        abstract renderTopView: content: JSX.Element -> JSX.Element
        abstract _renderAnnouncerView: unit -> JSX.Element

    type [<AllowNullLiteral>] RootViewUsingStoreStatic =
        [<EmitConstructor>] abstract Create: unit -> RootViewUsingStore

    type [<AllowNullLiteral>] RootViewUsingProps =
        inherit RootViewUsingPropsBase
        abstract renderTopView: content: JSX.Element -> JSX.Element
        abstract _renderAnnouncerView: unit -> JSX.Element

    type [<AllowNullLiteral>] RootViewUsingPropsStatic =
        [<EmitConstructor>] abstract Create: unit -> RootViewUsingProps

module __windows_StatusBar =
    module RX = ___common_Interfaces

    type [<AllowNullLiteral>] IExports =
        abstract StatusBar: StatusBarStatic
        abstract _default: StatusBar

    type [<AllowNullLiteral>] StatusBar =
        inherit RX.StatusBar
        abstract isOverlay: unit -> bool
        abstract setHidden: hidden: bool * showHideTransition: StatusBarSetHiddenShowHideTransition -> unit
        abstract setBackgroundColor: color: string * animated: bool -> unit
        abstract setTranslucent: translucent: bool -> unit
        abstract setBarStyle: style: StatusBarSetBarStyleStyle * animated: bool -> unit
        abstract setNetworkActivityIndicatorVisible: value: bool -> unit

    type [<StringEnum>] [<RequireQualifiedAccess>] StatusBarSetHiddenShowHideTransition =
        | Fade
        | Slide

    type [<StringEnum>] [<RequireQualifiedAccess>] StatusBarSetBarStyleStyle =
        | Default
        | [<CompiledName "light-content">] LightContent
        | [<CompiledName "dark-content">] DarkContent

    type [<AllowNullLiteral>] StatusBarStatic =
        [<EmitConstructor>] abstract Create: unit -> StatusBar

module __windows_Text =
    type ExtendedTextProps = React_native.ExtendedTextProps
    type ImportantForAccessibilityValue = __native_common_AccessibilityUtil.ImportantForAccessibilityValue
    type FocusManagerFocusableComponent = __native_desktop_utils_FocusManager.FocusManagerFocusableComponent
    type TextBase = __native_common_Text.Text
    type TextContextBase = __native_common_Text.TextContext

    type [<AllowNullLiteral>] IExports =
        abstract Text: TextStatic

    type [<AllowNullLiteral>] TextContext =
        inherit TextContextBase
        abstract isRxParentAFocusableInSameFocusManager: bool option with get, set

    type [<AllowNullLiteral>] Text =
        inherit TextBase
        inherit React.ChildContextProvider<TextContext>
        inherit FocusManagerFocusableComponent
        abstract context: TextContext with get, set
        abstract _getExtendedProperties: unit -> ExtendedTextProps
        abstract requestFocus: unit -> unit
        abstract getChildContext: unit -> TextContext
        abstract onFocus: unit -> unit
        abstract getTabIndex: unit -> float
        abstract getImportantForAccessibility: unit -> ImportantForAccessibilityValue option
        abstract updateNativeAccessibilityProps: unit -> unit
        abstract getSelectedText: unit -> string

    type [<AllowNullLiteral>] TextStatic =
        [<EmitConstructor>] abstract Create: unit -> Text
        abstract contextTypes: React.ValidationMap<obj option> with get, set
        abstract childContextTypes: React.ValidationMap<obj option> with get, set

module __windows_TextInput =
    module RN = React_native
    type ImportantForAccessibilityValue = __native_common_AccessibilityUtil.ImportantForAccessibilityValue
    type FocusManagerFocusableComponent = __native_desktop_utils_FocusManager.FocusManagerFocusableComponent
    type TextInputBase = __native_common_TextInput.TextInput

    type [<AllowNullLiteral>] IExports =
        abstract TextInput: TextInputStatic

    type [<AllowNullLiteral>] TextInput =
        inherit TextInputBase
        inherit FocusManagerFocusableComponent
        abstract _render: props: RN.TextInputProps * onMount: (obj option -> unit) -> JSX.Element
        abstract onFocus: unit -> unit
        abstract getTabIndex: unit -> float
        abstract getImportantForAccessibility: unit -> ImportantForAccessibilityValue option
        abstract updateNativeAccessibilityProps: unit -> unit

    type [<AllowNullLiteral>] TextInputStatic =
        [<EmitConstructor>] abstract Create: unit -> TextInput

module __windows_View =
    module RN = React_native
    module RNW = React_native_windows
    type ImportantForAccessibilityValue = __native_common_AccessibilityUtil.ImportantForAccessibilityValue
    type FocusManager = __native_desktop_utils_FocusManager.FocusManager
    type FocusManagerFocusableComponent = __native_desktop_utils_FocusManager.FocusManagerFocusableComponent
    type Types = __common_Interfaces.Types
    type ViewCommon = __native_common_View.View
    type ViewContextCommon = __native_common_View.ViewContext

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
        abstract context: ViewContext with get, set
        abstract _getContextMenuOffset: unit -> View_getContextMenuOffsetReturn
        abstract componentWillReceiveProps: nextProps: Types.ViewProps -> unit
        abstract enableFocusManager: unit -> unit
        abstract disableFocusManager: unit -> unit
        abstract componentDidMount: unit -> unit
        abstract componentWillUnmount: unit -> unit
        abstract _buildInternalProps: props: Types.ViewProps -> unit
        abstract render: unit -> JSX.Element
        abstract requestFocus: unit -> unit
        abstract focus: unit -> unit
        abstract blur: unit -> unit
        abstract getChildContext: unit -> ViewContext
        abstract setFocusRestricted: restricted: bool -> unit
        abstract setFocusLimited: limited: bool -> unit
        abstract setNativeProps: nativeProps: obj -> unit
        abstract _isButton: viewProps: Types.ViewProps -> bool
        abstract onFocus: unit -> unit
        abstract getTabIndex: unit -> float option
        abstract getImportantForAccessibility: unit -> ImportantForAccessibilityValue option
        abstract updateNativeAccessibilityProps: unit -> unit

    type [<AllowNullLiteral>] View_getContextMenuOffsetReturn =
        abstract x: float with get, set
        abstract y: float with get, set

    type [<AllowNullLiteral>] ViewStatic =
        abstract contextTypes: React.ValidationMap<obj option> with get, set
        abstract childContextTypes: React.ValidationMap<obj option> with get, set
        [<EmitConstructor>] abstract Create: props: Types.ViewProps * ?context: ViewContext -> View

module __common_utils_AutoFocusHelper =
    module RX = ___Interfaces

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
        abstract setCallback: ?arbitrator: RX.Types.FocusArbitrator -> unit

    type [<AllowNullLiteral>] FocusArbitratorProviderStatic =
        [<EmitConstructor>] abstract Create: ?view: RX.View * ?arbitrator: RX.Types.FocusArbitrator -> FocusArbitratorProvider
        abstract requestFocus: ``component``: React.Component<obj option, obj option> * focus: (unit -> unit) * isAvailable: (unit -> bool) * ?``type``: FocusCandidateType -> unit

module __common_utils_FocusManager =
    type Types = __common_Interfaces.Types

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
        abstract _myFocusableComponentIds: FocusManager_myFocusableComponentIds with get, set
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

    type [<AllowNullLiteral>] FocusManagerStatic =
        abstract _currentRestrictionOwner: FocusManager option with get, set
        abstract _currentFocusedComponent: StoredFocusableComponent option with get, set
        abstract _allFocusableComponents: FocusManagerStatic_allFocusableComponents with get, set
        abstract _skipFocusCheck: bool with get, set
        abstract _resetFocusTimer: float option with get, set
        [<EmitConstructor>] abstract Create: parent: FocusManager option -> FocusManager
        abstract subscribe: ``component``: FocusableComponentInternal * callback: FocusableComponentStateCallback -> unit
        abstract unsubscribe: ``component``: FocusableComponentInternal * callback: FocusableComponentStateCallback -> unit
        abstract isComponentFocusRestrictedOrLimited: ``component``: FocusableComponentInternal -> bool
        abstract getCurrentFocusedComponent: unit -> string option
        abstract _callFocusableComponentStateChangeCallbacks: storedComponent: StoredFocusableComponent * restrictedOrLimited: bool -> unit

    type [<AllowNullLiteral>] FocusManager_myFocusableComponentIds =
        [<EmitIndexer>] abstract Item: id: string -> bool with get, set

    type [<AllowNullLiteral>] FocusManagerStatic_allFocusableComponents =
        [<EmitIndexer>] abstract Item: id: string -> StoredFocusableComponent with get, set

module __common_utils_Timers =

    type [<AllowNullLiteral>] IExports =
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
        [<EmitConstructor>] abstract Create: unit -> Timers
        abstract clearInterval: handle: float -> unit
        abstract clearTimeout: handle: float -> unit
        abstract setInterval: handler: (unit -> unit) * timeout: float -> float
        abstract setTimeout: handler: (unit -> unit) * timeout: float -> float

module __native_common_utils_EventHelpers =
    type Types = __common_Interfaces.Types

    type [<AllowNullLiteral>] IExports =
        abstract EventHelpers: EventHelpersStatic
        abstract _default: EventHelpers

    type [<AllowNullLiteral>] EventHelpers =
        abstract toKeyboardEvent: e: Types.SyntheticEvent -> Types.KeyboardEvent
        abstract toFocusEvent: e: Types.SyntheticEvent -> Types.FocusEvent
        abstract toMouseEvent: e: Types.SyntheticEvent -> Types.MouseEvent
        abstract toDragEvent: e: Types.SyntheticEvent -> Types.DragEvent
        abstract toMouseButton: nativeEvent: obj option -> float
        abstract isActuallyMouseEvent: e: Types.TouchEvent option -> bool
        abstract isRightMouseButton: e: Types.SyntheticEvent -> bool
        abstract keyboardToMouseEvent: e: Types.KeyboardEvent * layoutInfo: Types.LayoutInfo * contextMenuOffset: EventHelpersKeyboardToMouseEventContextMenuOffset -> Types.MouseEvent

    type [<AllowNullLiteral>] EventHelpersKeyboardToMouseEventContextMenuOffset =
        abstract x: float with get, set
        abstract y: float with get, set

    type [<AllowNullLiteral>] EventHelpersStatic =
        [<EmitConstructor>] abstract Create: unit -> EventHelpers

module __native_desktop_utils_FocusManager =
    type ImportantForAccessibilityValue = __native_common_AccessibilityUtil.ImportantForAccessibilityValue
    type FocusableComponentInternalBase = __common_utils_FocusManager.FocusableComponentInternal
    type FocusableComponentStateCallback = __common_utils_FocusManager.FocusableComponentStateCallback
    type FocusManagerBase = __common_utils_FocusManager.FocusManager
    type StoredFocusableComponentBase = __common_utils_FocusManager.StoredFocusableComponent

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
        abstract resetFocus: focusFirstWhenNavigatingWithKeyboard: bool -> unit
        abstract _updateComponentFocusRestriction: storedComponent: StoredFocusableComponent -> unit

    type [<AllowNullLiteral>] FocusManagerStatic =
        [<EmitConstructor>] abstract Create: parent: FocusManager option -> FocusManager

module __web_animated_executeTransition =

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
    type Types = __common_Interfaces.Types

    type [<AllowNullLiteral>] IExports =
        abstract AnimateListEdits: AnimateListEditsStatic

    type [<AllowNullLiteral>] AnimateListEditsProps =
        abstract animateChildEnter: bool option with get, set
        abstract animateChildLeave: bool option with get, set
        abstract animateChildMove: bool option with get, set

    type [<AllowNullLiteral>] AnimateListEdits =
        inherit React.Component<AnimateListEditsProps, Types.Stateless>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] AnimateListEditsStatic =
        [<EmitConstructor>] abstract Create: unit -> AnimateListEdits

module __web_listAnimations_MonitorListEdits =
    type Types = __common_Interfaces.Types

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
        abstract componentWillMount: unit -> unit
        abstract componentDidMount: unit -> unit
        abstract componentWillUnmount: unit -> unit
        abstract shouldComponentUpdate: unit -> bool
        abstract componentWillUpdate: nextProps: MonitorListEditsProps -> unit
        abstract render: unit -> JSX.Element
        abstract componentDidUpdate: prevProps: MonitorListEditsProps -> unit

    type [<AllowNullLiteral>] MonitorListEditsStatic =
        [<EmitConstructor>] abstract Create: unit -> MonitorListEdits

module __web_utils_AppVisibilityUtils =

    type [<AllowNullLiteral>] IExports =
        abstract AppVisibilityUtils: AppVisibilityUtilsStatic
        abstract _default: AppVisibilityUtils

    type [<AllowNullLiteral>] AppVisibilityUtils =
        abstract onFocusedEvent: SubscribableEvent<(unit -> unit)>
        abstract onBlurredEvent: SubscribableEvent<(unit -> unit)>
        abstract onAppForegroundedEvent: SubscribableEvent<(unit -> unit)>
        abstract onAppBackgroundedEvent: SubscribableEvent<(unit -> unit)>
        abstract onIdleEvent: SubscribableEvent<(unit -> unit)>
        abstract onWakeUpEvent: SubscribableEvent<(unit -> unit)>
        abstract hasFocusAndActive: unit -> bool
        abstract hasFocus: unit -> bool
        abstract isAppInForeground: unit -> bool

    type [<AllowNullLiteral>] AppVisibilityUtilsStatic =
        [<EmitConstructor>] abstract Create: unit -> AppVisibilityUtils

module __web_utils_FocusManager =
    type FocusCandidateInternal = __common_utils_AutoFocusHelper.FocusCandidateInternal
    type FocusableComponentInternal = __common_utils_FocusManager.FocusableComponentInternal
    type FocusableComponentStateCallback = __common_utils_FocusManager.FocusableComponentStateCallback
    type FocusManagerBase = __common_utils_FocusManager.FocusManager
    type StoredFocusableComponentBase = __common_utils_FocusManager.StoredFocusableComponent

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
        abstract addFocusListenerOnComponent: ``component``: FocusableComponentInternal * onFocus: (unit -> unit) -> unit
        abstract removeFocusListenerFromComponent: ``component``: FocusableComponentInternal * onFocus: (unit -> unit) -> unit
        abstract focusComponent: ``component``: FocusableComponentInternal -> bool
        abstract resetFocus: focusFirstWhenNavigatingWithKeyboard: bool -> unit
        abstract _updateComponentFocusRestriction: storedComponent: StoredFocusableComponent -> unit

    type [<AllowNullLiteral>] FocusManagerStatic =
        [<EmitConstructor>] abstract Create: parent: FocusManager option -> FocusManager
        abstract initListeners: unit -> unit
        abstract setLastFocusedProgrammatically: element: HTMLElement option -> unit
        abstract getLastFocusedProgrammatically: ?reset: bool -> HTMLElement option
        abstract focusFirst: ?last: bool -> unit
        abstract sortAndFilterAutoFocusCandidates: candidates: ResizeArray<FocusCandidateInternal> -> ResizeArray<FocusCandidateInternal>

module __web_utils_MouseResponder =
    type Types = __common_Interfaces.Types

    type [<AllowNullLiteral>] IExports =
        abstract MouseResponder: MouseResponderStatic

    type [<AllowNullLiteral>] MouseResponderConfig =
        abstract id: float with get, set
        abstract target: HTMLElement with get, set
        abstract disableWhenModal: bool with get, set
        abstract shouldBecomeFirstResponder: (MouseEvent -> Types.PanGestureState -> bool) option with get, set
        abstract onMove: (MouseEvent -> Types.PanGestureState -> unit) option with get, set
        abstract onTerminate: (MouseEvent -> Types.PanGestureState -> unit) option with get, set

    type [<AllowNullLiteral>] MouseResponderSubscription =
        abstract dispose: unit -> unit

    type [<AllowNullLiteral>] MouseResponder =
        interface end

    type [<AllowNullLiteral>] MouseResponderStatic =
        [<EmitConstructor>] abstract Create: unit -> MouseResponder
        abstract setModalIsDisplayed: isDisplayed: bool -> unit
        abstract create: config: MouseResponderConfig -> MouseResponderSubscription

module __web_utils_restyleForInlineText =

    type [<AllowNullLiteral>] IExports =
        abstract restyleForInlineText: reactElement: React.ReactElement<obj option> -> React.ReactElement<obj option, U3<string, (obj option -> React.ReactElement<obj option, U3<string, obj option, obj>> option), obj>>

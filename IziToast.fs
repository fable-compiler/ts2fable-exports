// ts2fable 0.0.0
module rec IziToast

#nowarn "3390" // disable warnings for invalid XML comments

open System
open Fable.Core
open Fable.Core.JS
open Browser.Types

type Array<'T> = System.Collections.Generic.IList<'T>

let [<ImportAll("izitoast")>] iziToast: IziToast = jsNative

type [<StringEnum>] [<RequireQualifiedAccess>] IziToastPosition =
    | BottomRight
    | BottomLeft
    | TopRight
    | TopLeft
    | TopCenter
    | BottomCenter
    | Center

type [<StringEnum>] [<RequireQualifiedAccess>] IziToastTransitionIn =
    | BounceInLeft
    | BounceInRight
    | BounceInUp
    | BounceInDown
    | FadeIn
    | FadeInDown
    | FadeInUp
    | FadeInLeft
    | FadeInRight
    | FlipInX

type [<StringEnum>] [<RequireQualifiedAccess>] IziToastTransitionOut =
    | FadeOut
    | FadeOutUp
    | FadeOutDown
    | FadeOutLeft
    | FadeOutRight
    | FlipOutX

type [<AllowNullLiteral>] IziToastSettings =
    /// Id of the toast
    abstract id: string option with get, set
    /// The class that will be applied to the toast. It may be used as a reference.
    abstract ``class``: string option with get, set
    /// Title of the toast.
    abstract title: string option with get, set
    /// Title color.
    abstract titleColor: string option with get, set
    /// Title fontSize.
    abstract titleSize: string option with get, set
    /// Title lineHeight.
    abstract titleLineHeight: string option with get, set
    /// Message of notification.
    abstract message: string option with get, set
    /// Message color.
    abstract messageColor: string option with get, set
    /// Message fontSize.
    abstract messageSize: string option with get, set
    /// Message lineHeight.
    abstract messageLineHeight: string option with get, set
    /// Background color of the Toast
    abstract backgroundColor: string option with get, set
    /// It can be light or dark or set another class. Create and use like this ".iziToast-theme-name"
    /// Default value: light
    abstract theme: string option with get, set
    /// It can be #hexadecimal, pre-defined themes like blue, red, green and yellow or set another class. Create and use like this ".iziToast-color-name"
    abstract color: string option with get, set
    /// Icon class (font-icon of your choice, Icomoon, Fontawesome etc.).
    abstract icon: string option with get, set
    /// Icon text (font-icon using text, Material Icons, etc.).
    abstract iconText: string option with get, set
    /// Icon color.
    abstract iconColor: string option with get, set
    /// Cover image.
    abstract image: string option with get, set
    /// Width of cover image.
    /// Default value: 50
    abstract imageWidth: float option with get, set
    /// Sets maxWidth of toast.
    abstract maxWidth: float option with get, set
    /// The z-index CSS attribute of the toast
    /// Default value: 99999
    abstract zindex: float option with get, set
    /// It can be 1 or 2, or use another layout, creating the class like this: ".iziToast-layout3"
    /// Default value: 1
    abstract layout: float option with get, set
    /// Applies a balloon like toast.
    /// Default value: false
    abstract balloon: bool option with get, set
    /// Show "x" close button.
    /// Default value: true
    abstract close: bool option with get, set
    /// Allows to close toast using the Esc key.
    /// Default value: false
    abstract closeOnEscape: bool option with get, set
    /// Allows to close toast by clicking itself.
    /// Default value: false
    abstract closeOnClick: bool option with get, set
    /// RTL option
    /// Default value: false
    abstract rtl: bool option with get, set
    /// Where it will be shown.
    /// Default value: bottomRight
    abstract position: IziToastPosition option with get, set
    /// Fixed place where you want to show the toasts.
    abstract target: string option with get, set
    /// Add toast to first position.
    /// Default value: true
    abstract targetFirst: bool option with get, set
    /// Waits until the toast is closed so you can open it (Use 1 or 'once').
    /// Replaces the toast that was already open (Use 2 or 'replace').
    /// Default value: 0
    abstract displayMode: float option with get, set
    /// Amount in milliseconds to close the toast or false to disable.
    /// Default value: 5000
    abstract timeout: U2<bool, float> option with get, set
    /// Drag feature used to close the toast.
    /// Default value: true
    abstract drag: bool option with get, set
    /// Pause the toast timeout while the cursor is on it.
    /// Default value: true
    abstract pauseOnHover: bool option with get, set
    /// Reset the toast timeout while the cursor is on it.
    /// Default value: false
    abstract resetOnHover: bool option with get, set
    /// Enable timeout progress bar.
    /// Default value: true
    abstract progressBar: bool option with get, set
    /// Progress bar color.
    abstract progressBarColor: string option with get, set
    /// Animation Easing of progress bar.
    /// Default value: linear
    abstract progressBarEasing: string option with get, set
    /// Enables display the Overlay layer on the page.
    /// Default value: false
    abstract overlay: bool option with get, set
    /// Allows to close toast clicking on the Overlay.
    /// Default value: false
    abstract overlayClose: bool option with get, set
    /// Overlay background color.
    /// Default value: rgba(0, 0, 0, 0.6)
    abstract overlayColor: string option with get, set
    /// Enable animations of elements in the toast.
    /// Default value: true
    abstract animateInside: bool option with get, set
    /// Array of buttons.
    /// The first parameter is html string
    /// The second parameter is click event callback
    /// The last parameter is a boolean that defines whether there will be focus or not.
    abstract buttons: ResizeArray<string * (IziToast -> HTMLDivElement -> HTMLButtonElement -> MouseEvent -> Array<HTMLInputElement> -> unit) * bool> option with get, set
    /// Array of inputs.
    /// The first parameter is html string
    /// The second and third parameters is event type and event callback
    /// The last parameter is a boolean that defines whether there will be focus or not.
    abstract inputs: ResizeArray<string * string * (IziToast -> HTMLDivElement -> HTMLInputElement -> Event -> unit) * bool> option with get, set
    /// Default toast open animation.
    /// Default value: 'fadeInUp'
    abstract transitionIn: IziToastTransitionIn option with get, set
    /// Default toast close animation.
    /// Default value: 'fadeOut'
    abstract transitionOut: IziToastTransitionOut option with get, set
    /// Default toast opening mobile transition.
    /// Default value: 'fadeInUp'
    abstract transitionInMobile: IziToastTransitionIn option with get, set
    /// Default toast closing mobile transition.
    /// Default value: 'fadeOutDown'
    abstract transitionOutMobile: IziToastTransitionOut option with get, set
    /// <summary>Callback function triggered when opening the toast.</summary>
    /// <param name="settings">Settings of opening toast.</param>
    /// <param name="toast">Toast DOM element.</param>
    abstract onOpening: (IziToastSettings -> HTMLDivElement -> unit) option with get, set
    /// <summary>Callback function triggered when opened the toast.</summary>
    /// <param name="settings">Settings of opening toast.</param>
    /// <param name="toast">Toast DOM element.</param>
    abstract onOpened: (IziToastSettings -> HTMLDivElement -> unit) option with get, set
    /// <summary>Callback function triggered when closing the toast.</summary>
    /// <param name="settings">Settings of closing toast.</param>
    /// <param name="toast">Toast DOM element.</param>
    /// <param name="closedBy">Closed by info set by hide method.</param>
    abstract onClosing: (IziToastSettings -> HTMLDivElement -> string -> unit) option with get, set
    /// <summary>Callback function triggered when closed the toast.</summary>
    /// <param name="settings">Settings of closing toast.</param>
    /// <param name="toast">Toast DOM element.</param>
    /// <param name="closedBy">Closed by info set by hide method. (default: drag | timeout | button | overlay | esc | toast)</param>
    abstract onClosed: (IziToastSettings -> HTMLDivElement -> string -> unit) option with get, set

type [<AllowNullLiteral>] IziToastProgress =
    abstract pause: unit -> unit
    abstract reset: unit -> unit
    abstract resume: unit -> unit
    abstract start: unit -> unit

type [<AllowNullLiteral>] IziToast =
    /// <summary>Sets default values.</summary>
    /// <param name="settings">Settings to set as default.</param>
    abstract settings: settings: IziToastSettings -> unit
    /// Destroys all toasts.
    abstract destroy: unit -> unit
    /// <summary>Opens the toast.</summary>
    /// <returns>Returns false if toast can not be opened.</returns>
    abstract show: settings: IziToastSettings -> U2<unit, bool>
    /// <summary>Closes the specific toast.</summary>
    /// <param name="settings">Settings for this toast.</param>
    /// <param name="toast">Toast element or selector to hide.</param>
    /// <param name="closedBy">Custom closed by info to use in other functions.</param>
    abstract hide: settings: IziToastSettings * toast: U2<HTMLDivElement, string> * ?closedBy: string -> unit
    /// <summary>Control progress bar time.</summary>
    /// <param name="settings">Settings for this toast.</param>
    /// <param name="toast">Toast element</param>
    /// <param name="callback">Callback function triggered when invoke IziToastProgress</param>
    abstract progress: settings: IziToastSettings * toast: HTMLDivElement * ?callback: (unit -> unit) -> IziToastProgress
    /// <summary>Shows an info toast.</summary>
    /// <param name="settings">Settings for this toast.</param>
    abstract info: settings: IziToastSettings -> unit
    /// <summary>Shows an error toast.</summary>
    /// <param name="settings">Settings for this toast.</param>
    abstract error: settings: IziToastSettings -> unit
    /// <summary>Shows a warning toast.</summary>
    /// <param name="settings">Settings for this toast.</param>
    abstract warning: settings: IziToastSettings -> unit
    /// <summary>Shows a success toast.</summary>
    /// <param name="settings">Settings for this toast.</param>
    abstract success: settings: IziToastSettings -> unit
    /// <summary>Shows a question toast.</summary>
    /// <param name="settings">Settings for this toast.</param>
    abstract question: settings: IziToastSettings -> unit

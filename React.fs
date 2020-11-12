// ts2fable 0.0.0
module rec React
open System
open Fable.Core
open Fable.Core.JS
open Browser.Types

[<Erase>] type KeyOf<'T> = Key of string
type Array<'T> = System.Collections.Generic.IList<'T>
type Error = System.Exception

let [<Import("*","react")>] react: React.IExports = jsNative

type NativeAnimationEvent =
    AnimationEvent

type NativeClipboardEvent =
    ClipboardEvent

type NativeCompositionEvent =
    CompositionEvent

type NativeDragEvent =
    DragEvent

type NativeFocusEvent =
    FocusEvent

type NativeKeyboardEvent =
    KeyboardEvent

type NativeMouseEvent =
    MouseEvent

type NativeTouchEvent =
    TouchEvent

type NativeTransitionEvent =
    TransitionEvent

type NativeUIEvent =
    UIEvent

type NativeWheelEvent =
    WheelEvent

module React =

    type [<AllowNullLiteral>] IExports =
        abstract createClass: spec: ComponentSpec<'P, 'S> -> ClassicComponentClass<'P>
        abstract createFactory: ``type``: KeyOf<ReactHTML> -> HTMLFactory<'T> when 'T :> HTMLElement
        abstract createFactory: ``type``: KeyOf<ReactSVG> -> SVGFactory
        abstract createFactory: ``type``: string -> DOMFactory<'P, 'T> when 'P :> DOMAttributes<'T> and 'T :> Element
        abstract createFactory: ``type``: SFC<'P> -> SFCFactory<'P>
        abstract createFactory: ``type``: ClassType<'P, ClassicComponent<'P, ComponentState>, ClassicComponentClass<'P>> -> CFactory<'P, ClassicComponent<'P, ComponentState>>
        abstract createFactory: ``type``: ClassType<'P, 'T, 'C> -> CFactory<'P, 'T> when 'T :> Component<'P, ComponentState> and 'C :> ComponentClass<'P>
        abstract createFactory: ``type``: ComponentClass<'P> -> Factory<'P>
        [<Emit "$0.createElement('input',$1,$2)">] abstract createElement_input: ?props: obj * [<ParamArray>] children: ReactNode[] -> DetailedReactHTMLElement<IExportsCreateElement_inputDetailedReactHTMLElement, HTMLInputElement>
        abstract createElement: ``type``: KeyOf<ReactHTML> * ?props: obj * [<ParamArray>] children: ReactNode[] -> DetailedReactHTMLElement<'P, 'T> when 'P :> HTMLAttributes<'T> and 'T :> HTMLElement
        abstract createElement: ``type``: KeyOf<ReactSVG> * ?props: obj * [<ParamArray>] children: ReactNode[] -> ReactSVGElement when 'P :> SVGAttributes<'T> and 'T :> SVGElement
        abstract createElement: ``type``: string * ?props: obj * [<ParamArray>] children: ReactNode[] -> DOMElement<'P, 'T> when 'P :> DOMAttributes<'T> and 'T :> Element
        abstract createElement: ``type``: SFC<'P> * ?props: obj * [<ParamArray>] children: ReactNode[] -> SFCElement<'P>
        abstract createElement: ``type``: ClassType<'P, ClassicComponent<'P, ComponentState>, ClassicComponentClass<'P>> * ?props: obj * [<ParamArray>] children: ReactNode[] -> CElement<'P, ClassicComponent<'P, ComponentState>>
        abstract createElement: ``type``: ClassType<'P, 'T, 'C> * ?props: obj * [<ParamArray>] children: ReactNode[] -> CElement<'P, 'T> when 'T :> Component<'P, ComponentState> and 'C :> ComponentClass<'P>
        abstract createElement: ``type``: ComponentClass<'P> * ?props: obj * [<ParamArray>] children: ReactNode[] -> ReactElement<'P>
        abstract cloneElement: element: DetailedReactHTMLElement<'P, 'T> * ?props: 'P * [<ParamArray>] children: ReactNode[] -> DetailedReactHTMLElement<'P, 'T> when 'P :> HTMLAttributes<'T> and 'T :> HTMLElement
        abstract cloneElement: element: ReactHTMLElement<'T> * ?props: 'P * [<ParamArray>] children: ReactNode[] -> ReactHTMLElement<'T> when 'P :> HTMLAttributes<'T> and 'T :> HTMLElement
        abstract cloneElement: element: ReactSVGElement * ?props: 'P * [<ParamArray>] children: ReactNode[] -> ReactSVGElement when 'P :> SVGAttributes<'T> and 'T :> SVGElement
        abstract cloneElement: element: DOMElement<'P, 'T> * ?props: obj * [<ParamArray>] children: ReactNode[] -> DOMElement<'P, 'T> when 'P :> DOMAttributes<'T> and 'T :> Element
        abstract cloneElement: element: SFCElement<'P> * ?props: 'Q * [<ParamArray>] children: ReactNode[] -> SFCElement<'P> when 'P :> 'Q
        abstract cloneElement: element: CElement<'P, 'T> * ?props: 'Q * [<ParamArray>] children: ReactNode[] -> CElement<'P, 'T> when 'P :> 'Q and 'T :> Component<'P, ComponentState>
        abstract cloneElement: element: ReactElement<'P> * ?props: 'Q * [<ParamArray>] children: ReactNode[] -> ReactElement<'P> when 'P :> 'Q
        abstract isValidElement: ``object``: IsValidElementObject -> bool
        abstract DOM: ReactDOM
        abstract PropTypes: ReactPropTypes
        abstract Children: ReactChildren
        abstract version: string
        abstract Component: ComponentStatic
        abstract PureComponent: PureComponentStatic
        abstract ComponentClass: ComponentClassStatic
        abstract ClassicComponentClass: ClassicComponentClassStatic

    type [<AllowNullLiteral>] IsValidElementObject =
        interface end

    type ReactType =
        U2<string, ComponentType<obj option>>

    type ComponentType =
        ComponentType<obj>

    type ComponentType<'P> =
        U2<ComponentClass<'P>, StatelessComponent<'P>>

    type Key =
        U2<string, float>

    type Ref<'T> =
        U2<string, ('T option -> obj option)>

    type [<AllowNullLiteral>] ComponentState =
        interface end

    type [<AllowNullLiteral>] Attributes =
        abstract key: Key option with get, set

    type [<AllowNullLiteral>] ClassAttributes<'T> =
        inherit Attributes
        abstract ref: Ref<'T> option with get, set

    type [<AllowNullLiteral>] ReactElement<'P> =
        abstract ``type``: U3<string, ComponentClass<'P>, SFC<'P>> with get, set
        abstract props: 'P with get, set
        abstract key: Key option with get, set

    type [<AllowNullLiteral>] SFCElement<'P> =
        inherit ReactElement<'P>
        abstract ``type``: SFC<'P> with get, set

    type CElement<'P, 'T when 'T :> Component<'P, ComponentState>> =
        ComponentElement<'P, 'T>

    type [<AllowNullLiteral>] ComponentElement<'P, 'T when 'T :> Component<'P, ComponentState>> =
        inherit ReactElement<'P>
        abstract ``type``: ComponentClass<'P> with get, set
        abstract ref: Ref<'T> option with get, set

    type ClassicElement<'P> =
        CElement<'P, ClassicComponent<'P, ComponentState>>

    type [<AllowNullLiteral>] DOMElement<'P, 'T when 'T :> Element> =
        inherit ReactElement<'P>
        abstract ``type``: string with get, set
        abstract ref: Ref<'T> with get, set

    type [<AllowNullLiteral>] ReactHTMLElement<'T when 'T :> HTMLElement> =
        inherit DetailedReactHTMLElement<AllHTMLAttributes<'T>, 'T>

    type [<AllowNullLiteral>] DetailedReactHTMLElement<'P, 'T when 'P :> HTMLAttributes<'T> and 'T :> HTMLElement> =
        inherit DOMElement<'P, 'T>
        abstract ``type``: KeyOf<ReactHTML> with get, set

    type [<AllowNullLiteral>] ReactSVGElement =
        inherit DOMElement<SVGAttributes<SVGElement>, SVGElement>
        abstract ``type``: KeyOf<ReactSVG> with get, set

    type [<AllowNullLiteral>] Factory<'P> =
        [<Emit "$0($1...)">] abstract Invoke: ?props: obj * [<ParamArray>] children: ReactNode[] -> ReactElement<'P>

    type [<AllowNullLiteral>] SFCFactory<'P> =
        [<Emit "$0($1...)">] abstract Invoke: ?props: obj * [<ParamArray>] children: ReactNode[] -> SFCElement<'P>

    type [<AllowNullLiteral>] ComponentFactory<'P, 'T when 'T :> Component<'P, ComponentState>> =
        [<Emit "$0($1...)">] abstract Invoke: ?props: obj * [<ParamArray>] children: ReactNode[] -> CElement<'P, 'T>

    type CFactory<'P, 'T when 'T :> Component<'P, ComponentState>> =
        ComponentFactory<'P, 'T>

    type ClassicFactory<'P> =
        CFactory<'P, ClassicComponent<'P, ComponentState>>

    type [<AllowNullLiteral>] DOMFactory<'P, 'T when 'P :> DOMAttributes<'T> and 'T :> Element> =
        [<Emit "$0($1...)">] abstract Invoke: ?props: obj * [<ParamArray>] children: ReactNode[] -> DOMElement<'P, 'T>

    type [<AllowNullLiteral>] HTMLFactory<'T when 'T :> HTMLElement> =
        inherit DetailedHTMLFactory<AllHTMLAttributes<'T>, 'T>

    type [<AllowNullLiteral>] DetailedHTMLFactory<'P, 'T when 'P :> HTMLAttributes<'T> and 'T :> HTMLElement> =
        inherit DOMFactory<'P, 'T>
        [<Emit "$0($1...)">] abstract Invoke: ?props: obj * [<ParamArray>] children: ReactNode[] -> DetailedReactHTMLElement<'P, 'T>

    type [<AllowNullLiteral>] SVGFactory =
        inherit DOMFactory<SVGAttributes<SVGElement>, SVGElement>
        [<Emit "$0($1...)">] abstract Invoke: ?props: obj * [<ParamArray>] children: ReactNode[] -> ReactSVGElement

    type ReactText =
        U2<string, float>

    type ReactChild =
        U2<ReactElement<obj option>, ReactText>

    type ReactFragment =
        Array<U3<ReactChild, ResizeArray<obj option>, bool>>

    type ReactNode =
        U3<ReactChild, ReactFragment, bool> option

    type ReactInstance =
        U2<Component<obj option>, Element>

    type Component =
        Component<obj, obj>

    type Component<'P> =
        Component<'P, obj>

    type [<AllowNullLiteral>] Component<'P, 'S> =
        inherit ComponentLifecycle<'P, 'S>
        abstract setState: f: ('S -> 'P -> obj) * ?callback: (unit -> obj option) -> unit
        abstract setState: state: obj * ?callback: (unit -> obj option) -> unit
        abstract forceUpdate: ?callBack: (unit -> obj option) -> unit
        abstract render: unit -> JSX.Element option
        abstract props: obj with get, set
        abstract state: obj with get, set
        abstract context: obj option with get, set
        abstract refs: ComponentRefs with get, set

    type [<AllowNullLiteral>] ComponentStatic =
        [<Emit "new $0($1...)">] abstract Create: ?props: 'P * ?context: obj -> Component<'P, 'S>

    type PureComponent =
        PureComponent<obj, obj>

    type PureComponent<'P> =
        PureComponent<'P, obj>

    type [<AllowNullLiteral>] PureComponent<'P, 'S> =
        inherit Component<'P, 'S>

    type [<AllowNullLiteral>] PureComponentStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> PureComponent<'P, 'S>

    type ClassicComponent =
        ClassicComponent<obj, obj>

    type ClassicComponent<'P> =
        ClassicComponent<'P, obj>

    type [<AllowNullLiteral>] ClassicComponent<'P, 'S> =
        inherit Component<'P, 'S>
        abstract replaceState: nextState: 'S * ?callback: (unit -> obj option) -> unit
        abstract isMounted: unit -> bool
        abstract getInitialState: unit -> 'S

    type [<AllowNullLiteral>] ChildContextProvider<'CC> =
        abstract getChildContext: unit -> 'CC

    type SFC =
        SFC<obj>

    type SFC<'P> =
        StatelessComponent<'P>

    type StatelessComponent =
        StatelessComponent<obj>

    type [<AllowNullLiteral>] StatelessComponent<'P> =
        [<Emit "$0($1...)">] abstract Invoke: props: obj * ?context: obj -> ReactElement<obj option> option
        abstract propTypes: ValidationMap<'P> option with get, set
        abstract contextTypes: ValidationMap<obj option> option with get, set
        abstract defaultProps: obj option with get, set
        abstract displayName: string option with get, set

    type ComponentClass =
        ComponentClass<obj>

    type [<AllowNullLiteral>] ComponentClass<'P> =
        abstract propTypes: ValidationMap<'P> option with get, set
        abstract contextTypes: ValidationMap<obj option> option with get, set
        abstract childContextTypes: ValidationMap<obj option> option with get, set
        abstract defaultProps: obj option with get, set
        abstract displayName: string option with get, set

    type [<AllowNullLiteral>] ComponentClassStatic =
        [<Emit "new $0($1...)">] abstract Create: ?props: 'P * ?context: obj -> ComponentClass<'P>

    type ClassicComponentClass =
        ClassicComponentClass<obj>

    type [<AllowNullLiteral>] ClassicComponentClass<'P> =
        inherit ComponentClass<'P>
        abstract getDefaultProps: unit -> 'P

    type [<AllowNullLiteral>] ClassicComponentClassStatic =
        [<Emit "new $0($1...)">] abstract Create: ?props: 'P * ?context: obj -> ClassicComponentClass<'P>

    type [<AllowNullLiteral>] ClassType<'P, 'T, 'C when 'T :> Component<'P, ComponentState> and 'C :> ComponentClass<'P>> =
        interface end

    type [<AllowNullLiteral>] ComponentLifecycle<'P, 'S> =
        /// Called immediately before mounting occurs, and before `Component#render`.
        /// Avoid introducing any side-effects or subscriptions in this method.
        abstract componentWillMount: unit -> unit
        /// Called immediately after a compoment is mounted. Setting state here will trigger re-rendering.
        abstract componentDidMount: unit -> unit
        /// Called when the component may be receiving new props.
        /// React may call this even if props have not changed, so be sure to compare new and existing
        /// props if you only want to handle changes.
        /// 
        /// Calling `Component#setState` generally does not trigger this method.
        abstract componentWillReceiveProps: nextProps: obj * nextContext: obj option -> unit
        /// Called to determine whether the change in props and state should trigger a re-render.
        /// 
        /// `Component` always returns true.
        /// `PureComponent` implements a shallow comparison on props and state and returns true if any
        /// props or states have changed.
        /// 
        /// If false is returned, `Component#render`, `componentWillUpdate`
        /// and `componentDidUpdate` will not be called.
        abstract shouldComponentUpdate: nextProps: obj * nextState: obj * nextContext: obj option -> bool
        /// Called immediately before rendering when new props or state is received. Not called for the initial render.
        /// 
        /// Note: You cannot call `Component#setState` here.
        abstract componentWillUpdate: nextProps: obj * nextState: obj * nextContext: obj option -> unit
        /// Called immediately after updating occurs. Not called for the initial render.
        abstract componentDidUpdate: prevProps: obj * prevState: obj * prevContext: obj option -> unit
        /// Called immediately before a component is destroyed. Perform any necessary cleanup in this method, such as
        /// cancelled network requests, or cleaning up any DOM elements created in `componentDidMount`.
        abstract componentWillUnmount: unit -> unit
        /// Catches exceptions generated in descendant components. Unhandled exceptions will cause
        /// the entire component tree to unmount.
        abstract componentDidCatch: error: Error * errorInfo: ErrorInfo -> unit

    type [<AllowNullLiteral>] Mixin<'P, 'S> =
        inherit ComponentLifecycle<'P, 'S>
        abstract mixins: Array<Mixin<'P, 'S>> option with get, set
        abstract statics: MixinStatics option with get, set
        abstract displayName: string option with get, set
        abstract propTypes: ValidationMap<obj option> option with get, set
        abstract contextTypes: ValidationMap<obj option> option with get, set
        abstract childContextTypes: ValidationMap<obj option> option with get, set
        abstract getDefaultProps: unit -> 'P
        abstract getInitialState: unit -> 'S

    type [<AllowNullLiteral>] ComponentSpec<'P, 'S> =
        inherit Mixin<'P, 'S>
        abstract render: unit -> ReactElement<obj option> option
        [<Emit "$0[$1]{{=$2}}">] abstract Item: propertyName: string -> obj option with get, set

    type [<AllowNullLiteral>] SyntheticEvent<'T> =
        abstract bubbles: bool with get, set
        abstract currentTarget: obj with get, set
        abstract cancelable: bool with get, set
        abstract defaultPrevented: bool with get, set
        abstract eventPhase: float with get, set
        abstract isTrusted: bool with get, set
        abstract nativeEvent: Event with get, set
        abstract preventDefault: unit -> unit
        abstract isDefaultPrevented: unit -> bool
        abstract stopPropagation: unit -> unit
        abstract isPropagationStopped: unit -> bool
        abstract persist: unit -> unit
        abstract target: EventTarget with get, set
        abstract timeStamp: float with get, set
        abstract ``type``: string with get, set

    type [<AllowNullLiteral>] ClipboardEvent<'T> =
        inherit SyntheticEvent<'T>
        abstract clipboardData: DataTransfer with get, set
        abstract nativeEvent: NativeClipboardEvent with get, set

    type [<AllowNullLiteral>] CompositionEvent<'T> =
        inherit SyntheticEvent<'T>
        abstract data: string with get, set
        abstract nativeEvent: NativeCompositionEvent with get, set

    type [<AllowNullLiteral>] DragEvent<'T> =
        inherit MouseEvent<'T>
        abstract dataTransfer: DataTransfer with get, set
        abstract nativeEvent: NativeDragEvent with get, set

    type [<AllowNullLiteral>] FocusEvent<'T> =
        inherit SyntheticEvent<'T>
        abstract nativeEvent: NativeFocusEvent with get, set
        abstract relatedTarget: EventTarget with get, set

    type [<AllowNullLiteral>] FormEvent<'T> =
        inherit SyntheticEvent<'T>

    type [<AllowNullLiteral>] InvalidEvent<'T> =
        inherit SyntheticEvent<'T>
        abstract target: obj with get, set

    type [<AllowNullLiteral>] ChangeEvent<'T> =
        inherit SyntheticEvent<'T>
        abstract target: obj with get, set

    type [<AllowNullLiteral>] KeyboardEvent<'T> =
        inherit SyntheticEvent<'T>
        abstract altKey: bool with get, set
        abstract charCode: float with get, set
        abstract ctrlKey: bool with get, set
        abstract getModifierState: key: string -> bool
        abstract key: string with get, set
        abstract keyCode: float with get, set
        abstract locale: string with get, set
        abstract location: float with get, set
        abstract metaKey: bool with get, set
        abstract nativeEvent: NativeKeyboardEvent with get, set
        abstract repeat: bool with get, set
        abstract shiftKey: bool with get, set
        abstract which: float with get, set

    type [<AllowNullLiteral>] MouseEvent<'T> =
        inherit SyntheticEvent<'T>
        abstract altKey: bool with get, set
        abstract button: float with get, set
        abstract buttons: float with get, set
        abstract clientX: float with get, set
        abstract clientY: float with get, set
        abstract ctrlKey: bool with get, set
        abstract getModifierState: key: string -> bool
        abstract metaKey: bool with get, set
        abstract nativeEvent: NativeMouseEvent with get, set
        abstract pageX: float with get, set
        abstract pageY: float with get, set
        abstract relatedTarget: EventTarget with get, set
        abstract screenX: float with get, set
        abstract screenY: float with get, set
        abstract shiftKey: bool with get, set

    type [<AllowNullLiteral>] TouchEvent<'T> =
        inherit SyntheticEvent<'T>
        abstract altKey: bool with get, set
        abstract changedTouches: TouchList with get, set
        abstract ctrlKey: bool with get, set
        abstract getModifierState: key: string -> bool
        abstract metaKey: bool with get, set
        abstract nativeEvent: NativeTouchEvent with get, set
        abstract shiftKey: bool with get, set
        abstract targetTouches: TouchList with get, set
        abstract touches: TouchList with get, set

    type [<AllowNullLiteral>] UIEvent<'T> =
        inherit SyntheticEvent<'T>
        abstract detail: float with get, set
        abstract nativeEvent: NativeUIEvent with get, set
        abstract view: AbstractView with get, set

    type [<AllowNullLiteral>] WheelEvent<'T> =
        inherit MouseEvent<'T>
        abstract deltaMode: float with get, set
        abstract deltaX: float with get, set
        abstract deltaY: float with get, set
        abstract deltaZ: float with get, set
        abstract nativeEvent: NativeWheelEvent with get, set

    type [<AllowNullLiteral>] AnimationEvent<'T> =
        inherit SyntheticEvent<'T>
        abstract animationName: string with get, set
        abstract elapsedTime: float with get, set
        abstract nativeEvent: NativeAnimationEvent with get, set
        abstract pseudoElement: string with get, set

    type [<AllowNullLiteral>] TransitionEvent<'T> =
        inherit SyntheticEvent<'T>
        abstract elapsedTime: float with get, set
        abstract nativeEvent: NativeTransitionEvent with get, set
        abstract propertyName: string with get, set
        abstract pseudoElement: string with get, set

    type [<AllowNullLiteral>] EventHandler<'E when 'E :> SyntheticEvent<obj option>> =
        [<Emit "$0($1...)">] abstract Invoke: ``event``: 'E -> unit

    type ReactEventHandler<'T> =
        EventHandler<SyntheticEvent<'T>>

    type ClipboardEventHandler<'T> =
        EventHandler<ClipboardEvent<'T>>

    type CompositionEventHandler<'T> =
        EventHandler<CompositionEvent<'T>>

    type DragEventHandler<'T> =
        EventHandler<DragEvent<'T>>

    type FocusEventHandler<'T> =
        EventHandler<FocusEvent<'T>>

    type FormEventHandler<'T> =
        EventHandler<FormEvent<'T>>

    type ChangeEventHandler<'T> =
        EventHandler<ChangeEvent<'T>>

    type KeyboardEventHandler<'T> =
        EventHandler<KeyboardEvent<'T>>

    type MouseEventHandler<'T> =
        EventHandler<MouseEvent<'T>>

    type TouchEventHandler<'T> =
        EventHandler<TouchEvent<'T>>

    type UIEventHandler<'T> =
        EventHandler<UIEvent<'T>>

    type WheelEventHandler<'T> =
        EventHandler<WheelEvent<'T>>

    type AnimationEventHandler<'T> =
        EventHandler<AnimationEvent<'T>>

    type TransitionEventHandler<'T> =
        EventHandler<TransitionEvent<'T>>

    type [<AllowNullLiteral>] Props<'T> =
        abstract children: ReactNode option with get, set
        abstract key: Key option with get, set
        abstract ref: Ref<'T> option with get, set

    type [<AllowNullLiteral>] HTMLProps<'T> =
        inherit AllHTMLAttributes<'T>
        inherit ClassAttributes<'T>

    type [<AllowNullLiteral>] DetailedHTMLProps<'E, 'T when 'E :> HTMLAttributes<'T>> =
        interface end

    type [<AllowNullLiteral>] SVGProps<'T> =
        inherit SVGAttributes<'T>
        inherit ClassAttributes<'T>

    type [<AllowNullLiteral>] DOMAttributes<'T> =
        abstract children: ReactNode option with get, set
        abstract dangerouslySetInnerHTML: DOMAttributesDangerouslySetInnerHTML option with get, set
        abstract onCopy: ClipboardEventHandler<'T> option with get, set
        abstract onCopyCapture: ClipboardEventHandler<'T> option with get, set
        abstract onCut: ClipboardEventHandler<'T> option with get, set
        abstract onCutCapture: ClipboardEventHandler<'T> option with get, set
        abstract onPaste: ClipboardEventHandler<'T> option with get, set
        abstract onPasteCapture: ClipboardEventHandler<'T> option with get, set
        abstract onCompositionEnd: CompositionEventHandler<'T> option with get, set
        abstract onCompositionEndCapture: CompositionEventHandler<'T> option with get, set
        abstract onCompositionStart: CompositionEventHandler<'T> option with get, set
        abstract onCompositionStartCapture: CompositionEventHandler<'T> option with get, set
        abstract onCompositionUpdate: CompositionEventHandler<'T> option with get, set
        abstract onCompositionUpdateCapture: CompositionEventHandler<'T> option with get, set
        abstract onFocus: FocusEventHandler<'T> option with get, set
        abstract onFocusCapture: FocusEventHandler<'T> option with get, set
        abstract onBlur: FocusEventHandler<'T> option with get, set
        abstract onBlurCapture: FocusEventHandler<'T> option with get, set
        abstract onChange: FormEventHandler<'T> option with get, set
        abstract onChangeCapture: FormEventHandler<'T> option with get, set
        abstract onInput: FormEventHandler<'T> option with get, set
        abstract onInputCapture: FormEventHandler<'T> option with get, set
        abstract onReset: FormEventHandler<'T> option with get, set
        abstract onResetCapture: FormEventHandler<'T> option with get, set
        abstract onSubmit: FormEventHandler<'T> option with get, set
        abstract onSubmitCapture: FormEventHandler<'T> option with get, set
        abstract onInvalid: FormEventHandler<'T> option with get, set
        abstract onInvalidCapture: FormEventHandler<'T> option with get, set
        abstract onLoad: ReactEventHandler<'T> option with get, set
        abstract onLoadCapture: ReactEventHandler<'T> option with get, set
        abstract onError: ReactEventHandler<'T> option with get, set
        abstract onErrorCapture: ReactEventHandler<'T> option with get, set
        abstract onKeyDown: KeyboardEventHandler<'T> option with get, set
        abstract onKeyDownCapture: KeyboardEventHandler<'T> option with get, set
        abstract onKeyPress: KeyboardEventHandler<'T> option with get, set
        abstract onKeyPressCapture: KeyboardEventHandler<'T> option with get, set
        abstract onKeyUp: KeyboardEventHandler<'T> option with get, set
        abstract onKeyUpCapture: KeyboardEventHandler<'T> option with get, set
        abstract onAbort: ReactEventHandler<'T> option with get, set
        abstract onAbortCapture: ReactEventHandler<'T> option with get, set
        abstract onCanPlay: ReactEventHandler<'T> option with get, set
        abstract onCanPlayCapture: ReactEventHandler<'T> option with get, set
        abstract onCanPlayThrough: ReactEventHandler<'T> option with get, set
        abstract onCanPlayThroughCapture: ReactEventHandler<'T> option with get, set
        abstract onDurationChange: ReactEventHandler<'T> option with get, set
        abstract onDurationChangeCapture: ReactEventHandler<'T> option with get, set
        abstract onEmptied: ReactEventHandler<'T> option with get, set
        abstract onEmptiedCapture: ReactEventHandler<'T> option with get, set
        abstract onEncrypted: ReactEventHandler<'T> option with get, set
        abstract onEncryptedCapture: ReactEventHandler<'T> option with get, set
        abstract onEnded: ReactEventHandler<'T> option with get, set
        abstract onEndedCapture: ReactEventHandler<'T> option with get, set
        abstract onLoadedData: ReactEventHandler<'T> option with get, set
        abstract onLoadedDataCapture: ReactEventHandler<'T> option with get, set
        abstract onLoadedMetadata: ReactEventHandler<'T> option with get, set
        abstract onLoadedMetadataCapture: ReactEventHandler<'T> option with get, set
        abstract onLoadStart: ReactEventHandler<'T> option with get, set
        abstract onLoadStartCapture: ReactEventHandler<'T> option with get, set
        abstract onPause: ReactEventHandler<'T> option with get, set
        abstract onPauseCapture: ReactEventHandler<'T> option with get, set
        abstract onPlay: ReactEventHandler<'T> option with get, set
        abstract onPlayCapture: ReactEventHandler<'T> option with get, set
        abstract onPlaying: ReactEventHandler<'T> option with get, set
        abstract onPlayingCapture: ReactEventHandler<'T> option with get, set
        abstract onProgress: ReactEventHandler<'T> option with get, set
        abstract onProgressCapture: ReactEventHandler<'T> option with get, set
        abstract onRateChange: ReactEventHandler<'T> option with get, set
        abstract onRateChangeCapture: ReactEventHandler<'T> option with get, set
        abstract onSeeked: ReactEventHandler<'T> option with get, set
        abstract onSeekedCapture: ReactEventHandler<'T> option with get, set
        abstract onSeeking: ReactEventHandler<'T> option with get, set
        abstract onSeekingCapture: ReactEventHandler<'T> option with get, set
        abstract onStalled: ReactEventHandler<'T> option with get, set
        abstract onStalledCapture: ReactEventHandler<'T> option with get, set
        abstract onSuspend: ReactEventHandler<'T> option with get, set
        abstract onSuspendCapture: ReactEventHandler<'T> option with get, set
        abstract onTimeUpdate: ReactEventHandler<'T> option with get, set
        abstract onTimeUpdateCapture: ReactEventHandler<'T> option with get, set
        abstract onVolumeChange: ReactEventHandler<'T> option with get, set
        abstract onVolumeChangeCapture: ReactEventHandler<'T> option with get, set
        abstract onWaiting: ReactEventHandler<'T> option with get, set
        abstract onWaitingCapture: ReactEventHandler<'T> option with get, set
        abstract onClick: MouseEventHandler<'T> option with get, set
        abstract onClickCapture: MouseEventHandler<'T> option with get, set
        abstract onContextMenu: MouseEventHandler<'T> option with get, set
        abstract onContextMenuCapture: MouseEventHandler<'T> option with get, set
        abstract onDoubleClick: MouseEventHandler<'T> option with get, set
        abstract onDoubleClickCapture: MouseEventHandler<'T> option with get, set
        abstract onDrag: DragEventHandler<'T> option with get, set
        abstract onDragCapture: DragEventHandler<'T> option with get, set
        abstract onDragEnd: DragEventHandler<'T> option with get, set
        abstract onDragEndCapture: DragEventHandler<'T> option with get, set
        abstract onDragEnter: DragEventHandler<'T> option with get, set
        abstract onDragEnterCapture: DragEventHandler<'T> option with get, set
        abstract onDragExit: DragEventHandler<'T> option with get, set
        abstract onDragExitCapture: DragEventHandler<'T> option with get, set
        abstract onDragLeave: DragEventHandler<'T> option with get, set
        abstract onDragLeaveCapture: DragEventHandler<'T> option with get, set
        abstract onDragOver: DragEventHandler<'T> option with get, set
        abstract onDragOverCapture: DragEventHandler<'T> option with get, set
        abstract onDragStart: DragEventHandler<'T> option with get, set
        abstract onDragStartCapture: DragEventHandler<'T> option with get, set
        abstract onDrop: DragEventHandler<'T> option with get, set
        abstract onDropCapture: DragEventHandler<'T> option with get, set
        abstract onMouseDown: MouseEventHandler<'T> option with get, set
        abstract onMouseDownCapture: MouseEventHandler<'T> option with get, set
        abstract onMouseEnter: MouseEventHandler<'T> option with get, set
        abstract onMouseLeave: MouseEventHandler<'T> option with get, set
        abstract onMouseMove: MouseEventHandler<'T> option with get, set
        abstract onMouseMoveCapture: MouseEventHandler<'T> option with get, set
        abstract onMouseOut: MouseEventHandler<'T> option with get, set
        abstract onMouseOutCapture: MouseEventHandler<'T> option with get, set
        abstract onMouseOver: MouseEventHandler<'T> option with get, set
        abstract onMouseOverCapture: MouseEventHandler<'T> option with get, set
        abstract onMouseUp: MouseEventHandler<'T> option with get, set
        abstract onMouseUpCapture: MouseEventHandler<'T> option with get, set
        abstract onSelect: ReactEventHandler<'T> option with get, set
        abstract onSelectCapture: ReactEventHandler<'T> option with get, set
        abstract onTouchCancel: TouchEventHandler<'T> option with get, set
        abstract onTouchCancelCapture: TouchEventHandler<'T> option with get, set
        abstract onTouchEnd: TouchEventHandler<'T> option with get, set
        abstract onTouchEndCapture: TouchEventHandler<'T> option with get, set
        abstract onTouchMove: TouchEventHandler<'T> option with get, set
        abstract onTouchMoveCapture: TouchEventHandler<'T> option with get, set
        abstract onTouchStart: TouchEventHandler<'T> option with get, set
        abstract onTouchStartCapture: TouchEventHandler<'T> option with get, set
        abstract onScroll: UIEventHandler<'T> option with get, set
        abstract onScrollCapture: UIEventHandler<'T> option with get, set
        abstract onWheel: WheelEventHandler<'T> option with get, set
        abstract onWheelCapture: WheelEventHandler<'T> option with get, set
        abstract onAnimationStart: AnimationEventHandler<'T> option with get, set
        abstract onAnimationStartCapture: AnimationEventHandler<'T> option with get, set
        abstract onAnimationEnd: AnimationEventHandler<'T> option with get, set
        abstract onAnimationEndCapture: AnimationEventHandler<'T> option with get, set
        abstract onAnimationIteration: AnimationEventHandler<'T> option with get, set
        abstract onAnimationIterationCapture: AnimationEventHandler<'T> option with get, set
        abstract onTransitionEnd: TransitionEventHandler<'T> option with get, set
        abstract onTransitionEndCapture: TransitionEventHandler<'T> option with get, set

    type [<StringEnum>] [<RequireQualifiedAccess>] CSSWideKeyword =
        | Initial
        | Inherit
        | Unset

    type CSSPercentage =
        string

    type CSSLength =
        U2<float, string>

    type [<AllowNullLiteral>] CSSProperties =
        /// Aligns a flex container's lines within the flex container when there is extra space in the cross-axis, similar to how justify-content aligns individual items within the main-axis.
        abstract alignContent: U2<CSSWideKeyword, string> option with get, set
        /// Sets the default alignment in the cross axis for all of the flex container's items, including anonymous flex items, similarly to how justify-content aligns items along the main axis.
        abstract alignItems: U2<CSSWideKeyword, string> option with get, set
        /// Allows the default alignment to be overridden for individual flex items.
        abstract alignSelf: U2<CSSWideKeyword, string> option with get, set
        /// This property allows precise alignment of elements, such as graphics,
        /// that do not have a baseline-table or lack the desired baseline in their baseline-table.
        /// With the alignment-adjust property, the position of the baseline identified by the alignment-baseline
        /// can be explicitly determined. It also determines precisely the alignment point for each glyph within a textual element.
        abstract alignmentAdjust: U2<CSSWideKeyword, obj option> option with get, set
        abstract alignmentBaseline: U2<CSSWideKeyword, obj option> option with get, set
        /// Defines a length of time to elapse before an animation starts, allowing an animation to begin execution some time after it is applied.
        abstract animationDelay: U2<CSSWideKeyword, obj option> option with get, set
        /// Defines whether an animation should run in reverse on some or all cycles.
        abstract animationDirection: U2<CSSWideKeyword, obj option> option with get, set
        /// Specifies how many times an animation cycle should play.
        abstract animationIterationCount: U2<CSSWideKeyword, obj option> option with get, set
        /// Defines the list of animations that apply to the element.
        abstract animationName: U2<CSSWideKeyword, obj option> option with get, set
        /// Defines whether an animation is running or paused.
        abstract animationPlayState: U2<CSSWideKeyword, obj option> option with get, set
        /// Allows changing the style of any element to platform-based interface elements or vice versa.
        abstract appearance: U2<CSSWideKeyword, obj option> option with get, set
        /// Determines whether or not the “back” side of a transformed element is visible when facing the viewer.
        abstract backfaceVisibility: U2<CSSWideKeyword, obj option> option with get, set
        /// Shorthand property to set the values for one or more of:
        /// background-clip, background-color, background-image,
        /// background-origin, background-position, background-repeat,
        /// background-size, and background-attachment.
        abstract background: U2<CSSWideKeyword, obj option> option with get, set
        /// If a background-image is specified, this property determines
        /// whether that image's position is fixed within the viewport,
        /// or scrolls along with its containing block.
        /// See CSS 3 background-attachment property https://drafts.csswg.org/css-backgrounds-3/#the-background-attachment
        abstract backgroundAttachment: U2<CSSWideKeyword, string> option with get, set
        /// This property describes how the element's background images should blend with each other and the element's background color.
        /// The value is a list of blend modes that corresponds to each background image. Each element in the list will apply to the
        /// corresponding element of background-image. If a property doesn’t have enough comma-separated values to match the number of layers,
        /// the UA must calculate its used value by repeating the list of values until there are enough.
        abstract backgroundBlendMode: U2<CSSWideKeyword, obj option> option with get, set
        /// Sets the background color of an element.
        abstract backgroundColor: U2<CSSWideKeyword, obj option> option with get, set
        abstract backgroundComposite: U2<CSSWideKeyword, obj option> option with get, set
        /// Applies one or more background images to an element. These can be any valid CSS image, including url() paths to image files or CSS gradients.
        abstract backgroundImage: U2<CSSWideKeyword, obj option> option with get, set
        /// Specifies what the background-position property is relative to.
        abstract backgroundOrigin: U2<CSSWideKeyword, obj option> option with get, set
        /// Sets the position of a background image.
        abstract backgroundPosition: U2<CSSWideKeyword, obj option> option with get, set
        /// Background-repeat defines if and how background images will be repeated after they have been sized and positioned
        abstract backgroundRepeat: U2<CSSWideKeyword, obj option> option with get, set
        /// Obsolete - spec retired, not implemented.
        abstract baselineShift: U2<CSSWideKeyword, obj option> option with get, set
        /// Non standard. Sets or retrieves the location of the Dynamic HTML (DHTML) behavior.
        abstract behavior: U2<CSSWideKeyword, obj option> option with get, set
        /// Shorthand property that defines the different properties of all four sides of an element's border in a single declaration.
        /// It can be used to set border-width, border-style and border-color, or a subset of these.
        abstract border: U2<CSSWideKeyword, obj option> option with get, set
        /// Shorthand that sets the values of border-bottom-color,
        /// border-bottom-style, and border-bottom-width.
        abstract borderBottom: U2<CSSWideKeyword, obj option> option with get, set
        /// Sets the color of the bottom border of an element.
        abstract borderBottomColor: U2<CSSWideKeyword, obj option> option with get, set
        /// Defines the shape of the border of the bottom-left corner.
        abstract borderBottomLeftRadius: U2<CSSWideKeyword, obj option> option with get, set
        /// Defines the shape of the border of the bottom-right corner.
        abstract borderBottomRightRadius: U2<CSSWideKeyword, obj option> option with get, set
        /// Sets the line style of the bottom border of a box.
        abstract borderBottomStyle: U2<CSSWideKeyword, obj option> option with get, set
        /// Sets the width of an element's bottom border. To set all four borders,
        /// use the border-width shorthand property which sets the values simultaneously for border-top-width,
        /// border-right-width, border-bottom-width, and border-left-width.
        abstract borderBottomWidth: U2<CSSWideKeyword, obj option> option with get, set
        /// Border-collapse can be used for collapsing the borders between table cells
        abstract borderCollapse: U2<CSSWideKeyword, obj option> option with get, set
        /// The CSS border-color property sets the color of an element's four borders.
        /// This property can have from one to four values, made up of the elementary properties:
        ///       •       border-top-color
        ///       •       border-right-color
        ///       •       border-bottom-color
        ///       •       border-left-color The default color is the currentColor of each of these values.
        /// If you provide one value, it sets the color for the element. Two values set the horizontal and vertical values,
        /// respectively. Providing three values sets the top, vertical, and bottom values, in that order.
        /// Four values set all for sides: top, right, bottom, and left, in that order.
        abstract borderColor: U2<CSSWideKeyword, obj option> option with get, set
        /// Specifies different corner clipping effects, such as scoop (inner curves), bevel (straight cuts) or notch (cut-off rectangles).
        /// Works along with border-radius to specify the size of each corner effect.
        abstract borderCornerShape: U2<CSSWideKeyword, obj option> option with get, set
        /// The property border-image-source is used to set the image to be used instead of the border style.
        /// If this is set to none the border-style is used instead.
        abstract borderImageSource: U2<CSSWideKeyword, obj option> option with get, set
        /// The border-image-width CSS property defines the offset to use for dividing the border image in nine parts,
        /// the top-left corner, central top edge, top-right-corner, central right edge, bottom-right corner, central bottom edge,
        /// bottom-left corner, and central right edge. They represent inward distance from the top, right, bottom, and left edges.
        abstract borderImageWidth: U2<CSSWideKeyword, obj option> option with get, set
        /// Shorthand property that defines the border-width, border-style and border-color of an element's left border in a single declaration.
        /// Note that you can use the corresponding longhand properties to set specific individual properties of the left border — border-left-width,
        /// border-left-style and border-left-color.
        abstract borderLeft: U2<CSSWideKeyword, obj option> option with get, set
        /// The CSS border-left-color property sets the color of an element's left border. This page explains the border-left-color value,
        /// but often you will find it more convenient to fix the border's left color as part of a shorthand set, either border-left or border-color.
        /// Colors can be defined several ways. For more information, see Usage.
        abstract borderLeftColor: U2<CSSWideKeyword, obj option> option with get, set
        /// Sets the style of an element's left border. To set all four borders, use the shorthand property, border-style.
        /// Otherwise, you can set the borders individually with border-top-style, border-right-style, border-bottom-style, border-left-style.
        abstract borderLeftStyle: U2<CSSWideKeyword, obj option> option with get, set
        /// Sets the width of an element's left border. To set all four borders,
        /// use the border-width shorthand property which sets the values simultaneously for border-top-width,
        /// border-right-width, border-bottom-width, and border-left-width.
        abstract borderLeftWidth: U2<CSSWideKeyword, obj option> option with get, set
        /// Shorthand property that defines the border-width, border-style and border-color of an element's right border
        /// in a single declaration. Note that you can use the corresponding longhand properties to set specific
        /// individual properties of the right border — border-right-width, border-right-style and border-right-color.
        abstract borderRight: U2<CSSWideKeyword, obj option> option with get, set
        /// Sets the color of an element's right border. This page explains the border-right-color value,
        /// but often you will find it more convenient to fix the border's right color as part of a shorthand set,
        /// either border-right or border-color.
        /// Colors can be defined several ways. For more information, see Usage.
        abstract borderRightColor: U2<CSSWideKeyword, obj option> option with get, set
        /// Sets the style of an element's right border. To set all four borders, use the shorthand property,
        /// border-style. Otherwise, you can set the borders individually with border-top-style, border-right-style,
        /// border-bottom-style, border-left-style.
        abstract borderRightStyle: U2<CSSWideKeyword, obj option> option with get, set
        /// Sets the width of an element's right border. To set all four borders,
        /// use the border-width shorthand property which sets the values simultaneously for border-top-width,
        /// border-right-width, border-bottom-width, and border-left-width.
        abstract borderRightWidth: U2<CSSWideKeyword, obj option> option with get, set
        /// Specifies the distance between the borders of adjacent cells.
        abstract borderSpacing: U2<CSSWideKeyword, obj option> option with get, set
        /// Sets the style of an element's four borders. This property can have from one to four values.
        /// With only one value, the value will be applied to all four borders;
        /// otherwise, this works as a shorthand property for each of border-top-style, border-right-style,
        /// border-bottom-style, border-left-style, where each border style may be assigned a separate value.
        abstract borderStyle: U2<CSSWideKeyword, obj option> option with get, set
        /// Shorthand property that defines the border-width, border-style and border-color of an element's top border
        /// in a single declaration. Note that you can use the corresponding longhand properties to set specific
        /// individual properties of the top border — border-top-width, border-top-style and border-top-color.
        abstract borderTop: U2<CSSWideKeyword, obj option> option with get, set
        /// Sets the color of an element's top border. This page explains the border-top-color value,
        /// but often you will find it more convenient to fix the border's top color as part of a shorthand set,
        /// either border-top or border-color.
        /// Colors can be defined several ways. For more information, see Usage.
        abstract borderTopColor: U2<CSSWideKeyword, obj option> option with get, set
        /// Sets the rounding of the top-left corner of the element.
        abstract borderTopLeftRadius: U2<CSSWideKeyword, obj option> option with get, set
        /// Sets the rounding of the top-right corner of the element.
        abstract borderTopRightRadius: U2<CSSWideKeyword, obj option> option with get, set
        /// Sets the style of an element's top border. To set all four borders, use the shorthand property, border-style.
        /// Otherwise, you can set the borders individually with border-top-style, border-right-style, border-bottom-style, border-left-style.
        abstract borderTopStyle: U2<CSSWideKeyword, obj option> option with get, set
        /// Sets the width of an element's top border. To set all four borders,
        /// use the border-width shorthand property which sets the values simultaneously for border-top-width,
        /// border-right-width, border-bottom-width, and border-left-width.
        abstract borderTopWidth: U2<CSSWideKeyword, obj option> option with get, set
        /// Sets the width of an element's four borders. This property can have from one to four values.
        /// This is a shorthand property for setting values simultaneously for border-top-width,
        /// border-right-width, border-bottom-width, and border-left-width.
        abstract borderWidth: U2<CSSWideKeyword, obj option> option with get, set
        /// This property specifies how far an absolutely positioned box's bottom margin edge
        /// is offset above the bottom edge of the box's containing block. For relatively positioned boxes,
        /// the offset is with respect to the bottom edges of the box itself
        /// (i.e., the box is given a position in the normal flow, then offset from that position according to these properties).
        abstract bottom: U2<CSSWideKeyword, obj option> option with get, set
        /// Obsolete.
        abstract boxAlign: U2<CSSWideKeyword, obj option> option with get, set
        /// Breaks a box into fragments creating new borders,
        /// padding and repeating backgrounds or lets it stay as a continuous box on a page break,
        /// column break, or, for inline elements, at a line break.
        abstract boxDecorationBreak: U2<CSSWideKeyword, obj option> option with get, set
        /// Deprecated
        abstract boxDirection: U2<CSSWideKeyword, obj option> option with get, set
        /// Do not use. This property has been replaced by the flex-wrap property.
        /// Gets or sets a value that specifies the direction to add successive rows or columns when the value of box-lines is set to multiple.
        abstract boxLineProgression: U2<CSSWideKeyword, obj option> option with get, set
        /// Do not use. This property has been replaced by the flex-wrap property.
        /// Gets or sets a value that specifies whether child elements wrap onto multiple lines or columns based on the space available in the object.
        abstract boxLines: U2<CSSWideKeyword, obj option> option with get, set
        /// Do not use. This property has been replaced by flex-order.
        /// Specifies the ordinal group that a child element of the object belongs to.
        /// This ordinal value identifies the display order (along the axis defined by the box-orient property) for the group.
        abstract boxOrdinalGroup: U2<CSSWideKeyword, obj option> option with get, set
        /// Deprecated.
        abstract boxFlex: U2<CSSWideKeyword, float> option with get, set
        /// Deprecated.
        abstract boxFlexGroup: U2<CSSWideKeyword, float> option with get, set
        /// Cast a drop shadow from the frame of almost any element.
        /// MDN: https://developer.mozilla.org/en-US/docs/Web/CSS/box-shadow
        abstract boxShadow: U2<CSSWideKeyword, obj option> option with get, set
        /// The CSS break-after property allows you to force a break on multi-column layouts.
        /// More specifically, it allows you to force a break after an element.
        /// It allows you to determine if a break should occur, and what type of break it should be.
        /// The break-after CSS property describes how the page, column or region break behaves after the generated box.
        /// If there is no generated box, the property is ignored.
        abstract breakAfter: U2<CSSWideKeyword, obj option> option with get, set
        /// Control page/column/region breaks that fall above a block of content
        abstract breakBefore: U2<CSSWideKeyword, obj option> option with get, set
        /// Control page/column/region breaks that fall within a block of content
        abstract breakInside: U2<CSSWideKeyword, obj option> option with get, set
        /// The clear CSS property specifies if an element can be positioned next to
        /// or must be positioned below the floating elements that precede it in the markup.
        abstract clear: U2<CSSWideKeyword, obj option> option with get, set
        /// Deprecated; see clip-path.
        /// Lets you specify the dimensions of an absolutely positioned element that should be visible,
        /// and the element is clipped into this shape, and displayed.
        abstract clip: U2<CSSWideKeyword, obj option> option with get, set
        /// Clipping crops an graphic, so that only a portion of the graphic is rendered, or filled.
        /// This clip-rule property, when used with the clip-path property, defines which clip rule, or algorithm,
        /// to use when filling the different parts of a graphics.
        abstract clipRule: U2<CSSWideKeyword, obj option> option with get, set
        /// The color property sets the color of an element's foreground content (usually text),
        /// accepting any standard CSS color from keywords and hex values to RGB(a) and HSL(a).
        abstract color: U2<CSSWideKeyword, obj option> option with get, set
        /// Describes the number of columns of the element.
        /// See CSS 3 column-count property https://www.w3.org/TR/css3-multicol/#cc
        abstract columnCount: U3<CSSWideKeyword, float, string> option with get, set
        /// Specifies how to fill columns (balanced or sequential).
        abstract columnFill: U2<CSSWideKeyword, obj option> option with get, set
        /// The column-gap property controls the width of the gap between columns in multi-column elements.
        abstract columnGap: U2<CSSWideKeyword, obj option> option with get, set
        /// Sets the width, style, and color of the rule between columns.
        abstract columnRule: U2<CSSWideKeyword, obj option> option with get, set
        /// Specifies the color of the rule between columns.
        abstract columnRuleColor: U2<CSSWideKeyword, obj option> option with get, set
        /// Specifies the width of the rule between columns.
        abstract columnRuleWidth: U2<CSSWideKeyword, obj option> option with get, set
        /// The column-span CSS property makes it possible for an element to span across all columns when its value is set to all.
        /// An element that spans more than one column is called a spanning element.
        abstract columnSpan: U2<CSSWideKeyword, obj option> option with get, set
        /// Specifies the width of columns in multi-column elements.
        abstract columnWidth: U2<CSSWideKeyword, obj option> option with get, set
        /// This property is a shorthand property for setting column-width and/or column-count.
        abstract columns: U2<CSSWideKeyword, obj option> option with get, set
        /// The counter-increment property accepts one or more names of counters (identifiers),
        /// each one optionally followed by an integer which specifies the value by which the counter should be incremented
        /// (e.g. if the value is 2, the counter increases by 2 each time it is invoked).
        abstract counterIncrement: U2<CSSWideKeyword, obj option> option with get, set
        /// The counter-reset property contains a list of one or more names of counters,
        /// each one optionally followed by an integer (otherwise, the integer defaults to 0.).
        /// Each time the given element is invoked, the counters specified by the property are set to the given integer.
        abstract counterReset: U2<CSSWideKeyword, obj option> option with get, set
        /// The cue property specifies sound files (known as an "auditory icon") to be played by speech media agents
        /// before and after presenting an element's content; if only one file is specified, it is played both before and after.
        /// The volume at which the file(s) should be played, relative to the volume of the main element, may also be specified.
        /// The icon files may also be set separately with the cue-before and cue-after properties.
        abstract cue: U2<CSSWideKeyword, obj option> option with get, set
        /// The cue-after property specifies a sound file (known as an "auditory icon") to be played by speech media agents
        /// after presenting an element's content; the volume at which the file should be played may also be specified.
        /// The shorthand property cue sets cue sounds for both before and after the element is presented.
        abstract cueAfter: U2<CSSWideKeyword, obj option> option with get, set
        /// Specifies the mouse cursor displayed when the mouse pointer is over an element.
        abstract cursor: U2<CSSWideKeyword, obj option> option with get, set
        /// The direction CSS property specifies the text direction/writing direction. The rtl is used for Hebrew or Arabic text, the ltr is for other languages.
        abstract direction: U2<CSSWideKeyword, obj option> option with get, set
        /// This property specifies the type of rendering box used for an element. It is a shorthand property for many other display properties.
        abstract display: U2<CSSWideKeyword, obj option> option with get, set
        /// The ‘fill’ property paints the interior of the given graphical element.
        /// The area to be painted consists of any areas inside the outline of the shape.
        /// To determine the inside of the shape, all subpaths are considered,
        /// and the interior is determined according to the rules associated with the current value of the ‘fill-rule’ property.
        /// The zero-width geometric outline of a shape is included in the area to be painted.
        abstract fill: U2<CSSWideKeyword, obj option> option with get, set
        /// SVG: Specifies the opacity of the color or the content the current object is filled with.
        /// See SVG 1.1 https://www.w3.org/TR/SVG/painting.html#FillOpacityProperty
        abstract fillOpacity: U2<CSSWideKeyword, float> option with get, set
        /// The ‘fill-rule’ property indicates the algorithm which is to be used to determine what parts of the canvas are included inside the shape.
        /// For a simple, non-intersecting path, it is intuitively clear what region lies "inside";
        /// however, for a more complex path, such as a path that intersects itself or where one subpath encloses another,
        /// the interpretation of "inside" is not so obvious.
        /// The ‘fill-rule’ property provides two options for how the inside of a shape is determined:
        abstract fillRule: U2<CSSWideKeyword, obj option> option with get, set
        /// Applies various image processing effects. This property is largely unsupported. See Compatibility section for more information.
        abstract filter: U2<CSSWideKeyword, obj option> option with get, set
        /// Shorthand for `flex-grow`, `flex-shrink`, and `flex-basis`.
        abstract flex: U3<CSSWideKeyword, float, string> option with get, set
        /// Obsolete, do not use. This property has been renamed to align-items.
        /// Specifies the alignment (perpendicular to the layout axis defined by the flex-direction property) of child elements of the object.
        abstract flexAlign: U2<CSSWideKeyword, obj option> option with get, set
        /// The flex-basis CSS property describes the initial main size of the flex item
        /// before any free space is distributed according to the flex factors described in the flex property (flex-grow and flex-shrink).
        abstract flexBasis: U2<CSSWideKeyword, obj option> option with get, set
        /// The flex-direction CSS property describes how flex items are placed in the flex container, by setting the direction of the flex container's main axis.
        abstract flexDirection: U2<CSSWideKeyword, string> option with get, set
        /// The flex-flow CSS property defines the flex container's main and cross axis. It is a shorthand property for the flex-direction and flex-wrap properties.
        abstract flexFlow: U2<CSSWideKeyword, string> option with get, set
        /// Specifies the flex grow factor of a flex item.
        /// See CSS flex-grow property https://drafts.csswg.org/css-flexbox-1/#flex-grow-property
        abstract flexGrow: U2<CSSWideKeyword, float> option with get, set
        /// Do not use. This property has been renamed to align-self
        /// Specifies the alignment (perpendicular to the layout axis defined by flex-direction) of child elements of the object.
        abstract flexItemAlign: U2<CSSWideKeyword, obj option> option with get, set
        /// Do not use. This property has been renamed to align-content.
        /// Specifies how a flexbox's lines align within the flexbox when there is extra space along the axis that is perpendicular to the axis defined by the flex-direction property.
        abstract flexLinePack: U2<CSSWideKeyword, obj option> option with get, set
        /// Gets or sets a value that specifies the ordinal group that a flexbox element belongs to. This ordinal value identifies the display order for the group.
        abstract flexOrder: U2<CSSWideKeyword, obj option> option with get, set
        /// Specifies the flex shrink factor of a flex item.
        /// See CSS flex-shrink property https://drafts.csswg.org/css-flexbox-1/#flex-shrink-property
        abstract flexShrink: U2<CSSWideKeyword, float> option with get, set
        /// Specifies whether flex items are forced into a single line or can be wrapped onto multiple lines.
        /// If wrapping is allowed, this property also enables you to control the direction in which lines are stacked.
        /// See CSS flex-wrap property https://drafts.csswg.org/css-flexbox-1/#flex-wrap-property
        abstract flexWrap: U2<CSSWideKeyword, string> option with get, set
        /// Elements which have the style float are floated horizontally.
        /// These elements can move as far to the left or right of the containing element.
        /// All elements after the floating element will flow around it, but elements before the floating element are not impacted.
        /// If several floating elements are placed after each other, they will float next to each other as long as there is room.
        abstract float: U2<CSSWideKeyword, obj option> option with get, set
        /// Flows content from a named flow (specified by a corresponding flow-into) through selected elements to form a dynamic chain of layout regions.
        abstract flowFrom: U2<CSSWideKeyword, obj option> option with get, set
        /// The font property is shorthand that allows you to do one of two things: you can either set up six of the most mature font properties in one line,
        /// or you can set one of a choice of keywords to adopt a system font setting.
        abstract font: U2<CSSWideKeyword, obj option> option with get, set
        /// The font-family property allows one or more font family names and/or generic family names to be specified for usage on the selected element(s)' text.
        /// The browser then goes through the list; for each character in the selection it applies the first font family that has an available glyph for that character.
        abstract fontFamily: U2<CSSWideKeyword, obj option> option with get, set
        /// The font-kerning property allows contextual adjustment of inter-glyph spacing, i.e. the spaces between the characters in text.
        /// This property controls <bold>metric kerning</bold> - that utilizes adjustment data contained in the font. Optical Kerning is not supported as yet.
        abstract fontKerning: U2<CSSWideKeyword, obj option> option with get, set
        /// Specifies the size of the font. Used to compute em and ex units.
        /// See CSS 3 font-size property https://www.w3.org/TR/css-fonts-3/#propdef-font-size
        abstract fontSize: U4<CSSWideKeyword, CSSLength, CSSPercentage, string> option with get, set
        /// The font-size-adjust property adjusts the font-size of the fallback fonts defined with font-family,
        /// so that the x-height is the same no matter what font is used.
        /// This preserves the readability of the text when fallback happens.
        /// See CSS 3 font-size-adjust property https://www.w3.org/TR/css-fonts-3/#propdef-font-size-adjust
        abstract fontSizeAdjust: U3<CSSWideKeyword, float, string> option with get, set
        /// Allows you to expand or condense the widths for a normal, condensed, or expanded font face.
        /// See CSS 3 font-stretch property https://drafts.csswg.org/css-fonts-3/#propdef-font-stretch
        abstract fontStretch: U2<CSSWideKeyword, string> option with get, set
        /// The font-style property allows normal, italic, or oblique faces to be selected.
        /// Italic forms are generally cursive in nature while oblique faces are typically sloped versions of the regular face.
        /// Oblique faces can be simulated by artificially sloping the glyphs of the regular face.
        /// See CSS 3 font-style property https://www.w3.org/TR/css-fonts-3/#propdef-font-style
        abstract fontStyle: U2<CSSWideKeyword, string> option with get, set
        /// This value specifies whether the user agent is allowed to synthesize bold or oblique font faces when a font family lacks bold or italic faces.
        abstract fontSynthesis: U2<CSSWideKeyword, obj option> option with get, set
        /// The font-variant property enables you to select the small-caps font within a font family.
        abstract fontVariant: U2<CSSWideKeyword, obj option> option with get, set
        /// Fonts can provide alternate glyphs in addition to default glyph for a character. This property provides control over the selection of these alternate glyphs.
        abstract fontVariantAlternates: U2<CSSWideKeyword, obj option> option with get, set
        /// Specifies the weight or boldness of the font.
        /// See CSS 3 'font-weight' property https://www.w3.org/TR/css-fonts-3/#propdef-font-weight
        abstract fontWeight: U3<CSSWideKeyword, string, float> option with get, set
        /// Lays out one or more grid items bound by 4 grid lines. Shorthand for setting grid-column-start, grid-column-end, grid-row-start, and grid-row-end in a single declaration.
        abstract gridArea: U2<CSSWideKeyword, obj option> option with get, set
        /// Controls a grid item's placement in a grid area, particularly grid position and a grid span. Shorthand for setting grid-column-start and grid-column-end in a single declaration.
        abstract gridColumn: U2<CSSWideKeyword, obj option> option with get, set
        /// Controls a grid item's placement in a grid area as well as grid position and a grid span.
        /// The grid-column-end property (with grid-row-start, grid-row-end, and grid-column-start) determines a grid item's placement by specifying the grid lines of a grid item's grid area.
        abstract gridColumnEnd: U2<CSSWideKeyword, obj option> option with get, set
        /// Determines a grid item's placement by specifying the starting grid lines of a grid item's grid area.
        /// A grid item's placement in a grid area consists of a grid position and a grid span.
        /// See also ( grid-row-start, grid-row-end, and grid-column-end)
        abstract gridColumnStart: U2<CSSWideKeyword, obj option> option with get, set
        /// Gets or sets a value that indicates which row an element within a Grid should appear in. Shorthand for setting grid-row-start and grid-row-end in a single declaration.
        abstract gridRow: U2<CSSWideKeyword, obj option> option with get, set
        /// Determines a grid item’s placement by specifying the block-end. A grid item's placement in a grid area consists of a grid position and a grid span.
        /// The grid-row-end property (with grid-row-start, grid-column-start, and grid-column-end) determines a grid item's placement by specifying the grid lines of a grid item's grid area.
        abstract gridRowEnd: U2<CSSWideKeyword, obj option> option with get, set
        /// Specifies a row position based upon an integer location, string value, or desired row size.
        /// css/properties/grid-row is used as short-hand for grid-row-position and grid-row-position
        abstract gridRowPosition: U2<CSSWideKeyword, obj option> option with get, set
        abstract gridRowSpan: U2<CSSWideKeyword, obj option> option with get, set
        /// Specifies named grid areas which are not associated with any particular grid item, but can be referenced from the grid-placement properties.
        /// The syntax of the grid-template-areas property also provides a visualization of the structure of the grid, making the overall layout of the grid container easier to understand.
        abstract gridTemplateAreas: U2<CSSWideKeyword, obj option> option with get, set
        /// Specifies (with grid-template-rows) the line names and track sizing functions of the grid.
        /// Each sizing function can be specified as a length, a percentage of the grid container’s size,
        /// a measurement of the contents occupying the column or row, or a fraction of the free space in the grid.
        abstract gridTemplateColumns: U2<CSSWideKeyword, obj option> option with get, set
        /// Specifies (with grid-template-columns) the line names and track sizing functions of the grid.
        /// Each sizing function can be specified as a length, a percentage of the grid container’s size,
        /// a measurement of the contents occupying the column or row, or a fraction of the free space in the grid.
        abstract gridTemplateRows: U2<CSSWideKeyword, obj option> option with get, set
        /// Sets the height of an element. The content area of the element height does not include the padding, border, and margin of the element.
        abstract height: U2<CSSWideKeyword, obj option> option with get, set
        /// Specifies the minimum number of characters in a hyphenated word
        abstract hyphenateLimitChars: U2<CSSWideKeyword, obj option> option with get, set
        /// Indicates the maximum number of successive hyphenated lines in an element. The ‘no-limit’ value means that there is no limit.
        abstract hyphenateLimitLines: U2<CSSWideKeyword, obj option> option with get, set
        /// Specifies the maximum amount of trailing whitespace (before justification) that may be left in a line before hyphenation is triggered
        /// to pull part of a word from the next line back up into the current one.
        abstract hyphenateLimitZone: U2<CSSWideKeyword, obj option> option with get, set
        /// Specifies whether or not words in a sentence can be split by the use of a manual or automatic hyphenation mechanism.
        abstract hyphens: U2<CSSWideKeyword, obj option> option with get, set
        abstract imeMode: U2<CSSWideKeyword, obj option> option with get, set
        /// Defines how the browser distributes space between and around flex items
        /// along the main-axis of their container.
        /// See CSS justify-content property https://www.w3.org/TR/css-flexbox-1/#justify-content-property
        abstract justifyContent: U2<CSSWideKeyword, string> option with get, set
        abstract layoutGrid: U2<CSSWideKeyword, obj option> option with get, set
        abstract layoutGridChar: U2<CSSWideKeyword, obj option> option with get, set
        abstract layoutGridLine: U2<CSSWideKeyword, obj option> option with get, set
        abstract layoutGridMode: U2<CSSWideKeyword, obj option> option with get, set
        abstract layoutGridType: U2<CSSWideKeyword, obj option> option with get, set
        /// Sets the left edge of an element
        abstract left: U2<CSSWideKeyword, obj option> option with get, set
        /// The letter-spacing CSS property specifies the spacing behavior between text characters.
        abstract letterSpacing: U2<CSSWideKeyword, obj option> option with get, set
        /// Deprecated. Gets or sets line-breaking rules for text in selected languages such as Japanese, Chinese, and Korean.
        abstract lineBreak: U2<CSSWideKeyword, obj option> option with get, set
        abstract lineClamp: U2<CSSWideKeyword, float> option with get, set
        /// Specifies the height of an inline block level element.
        /// See CSS 2.1 line-height property https://www.w3.org/TR/CSS21/visudet.html#propdef-line-height
        abstract lineHeight: U5<CSSWideKeyword, float, CSSLength, CSSPercentage, string> option with get, set
        /// Shorthand property that sets the list-style-type, list-style-position and list-style-image properties in one declaration.
        abstract listStyle: U2<CSSWideKeyword, obj option> option with get, set
        /// This property sets the image that will be used as the list item marker. When the image is available,
        /// it will replace the marker set with the 'list-style-type' marker. That also means that if the image is not available,
        /// it will show the style specified by list-style-property
        abstract listStyleImage: U2<CSSWideKeyword, obj option> option with get, set
        /// Specifies if the list-item markers should appear inside or outside the content flow.
        abstract listStylePosition: U2<CSSWideKeyword, obj option> option with get, set
        /// Specifies the type of list-item marker in a list.
        abstract listStyleType: U2<CSSWideKeyword, obj option> option with get, set
        /// The margin property is shorthand to allow you to set all four margins of an element at once.
        /// Its equivalent longhand properties are margin-top, margin-right, margin-bottom and margin-left.
        /// Negative values are also allowed.
        abstract margin: U2<CSSWideKeyword, obj option> option with get, set
        /// margin-bottom sets the bottom margin of an element.
        abstract marginBottom: U2<CSSWideKeyword, obj option> option with get, set
        /// margin-left sets the left margin of an element.
        abstract marginLeft: U2<CSSWideKeyword, obj option> option with get, set
        /// margin-right sets the right margin of an element.
        abstract marginRight: U2<CSSWideKeyword, obj option> option with get, set
        /// margin-top sets the top margin of an element.
        abstract marginTop: U2<CSSWideKeyword, obj option> option with get, set
        /// The marquee-direction determines the initial direction in which the marquee content moves.
        abstract marqueeDirection: U2<CSSWideKeyword, obj option> option with get, set
        /// The 'marquee-style' property determines a marquee's scrolling behavior.
        abstract marqueeStyle: U2<CSSWideKeyword, obj option> option with get, set
        /// This property is shorthand for setting mask-image, mask-mode, mask-repeat, mask-position, mask-clip, mask-origin, mask-composite and mask-size.
        /// Omitted values are set to their original properties' initial values.
        abstract mask: U2<CSSWideKeyword, obj option> option with get, set
        /// This property is shorthand for setting mask-border-source, mask-border-slice, mask-border-width, mask-border-outset, and mask-border-repeat.
        /// Omitted values are set to their original properties' initial values.
        abstract maskBorder: U2<CSSWideKeyword, obj option> option with get, set
        /// This property specifies how the images for the sides and the middle part of the mask image are scaled and tiled.
        /// The first keyword applies to the horizontal sides, the second one applies to the vertical ones.
        /// If the second keyword is absent, it is assumed to be the same as the first, similar to the CSS border-image-repeat property.
        abstract maskBorderRepeat: U2<CSSWideKeyword, obj option> option with get, set
        /// This property specifies inward offsets from the top, right, bottom, and left edges of the mask image,
        /// dividing it into nine regions: four corners, four edges, and a middle.
        /// The middle image part is discarded and treated as fully transparent black unless the fill keyword is present.
        /// The four values set the top, right, bottom and left offsets in that order, similar to the CSS border-image-slice property.
        abstract maskBorderSlice: U2<CSSWideKeyword, obj option> option with get, set
        /// Specifies an image to be used as a mask. An image that is empty, fails to download, is non-existent, or cannot be displayed is ignored and does not mask the element.
        abstract maskBorderSource: U2<CSSWideKeyword, obj option> option with get, set
        /// This property sets the width of the mask box image, similar to the CSS border-image-width property.
        abstract maskBorderWidth: U2<CSSWideKeyword, obj option> option with get, set
        /// Determines the mask painting area, which defines the area that is affected by the mask.
        /// The painted content of an element may be restricted to this area.
        abstract maskClip: U2<CSSWideKeyword, obj option> option with get, set
        /// For elements rendered as a single box, specifies the mask positioning area.
        /// For elements rendered as multiple boxes (e.g., inline boxes on several lines, boxes on several pages)
        /// specifies which boxes box-decoration-break operates on to determine the mask positioning area(s).
        abstract maskOrigin: U2<CSSWideKeyword, obj option> option with get, set
        /// This property must not be used. It is no longer included in any standard or standard track specification,
        /// nor is it implemented in any browser. It is only used when the text-align-last property is set to size.
        /// It controls allowed adjustments of font-size to fit line content.
        abstract maxFontSize: U2<CSSWideKeyword, obj option> option with get, set
        /// Sets the maximum height for an element. It prevents the height of the element to exceed the specified value.
        /// If min-height is specified and is greater than max-height, max-height is overridden.
        abstract maxHeight: U2<CSSWideKeyword, obj option> option with get, set
        /// Sets the maximum width for an element. It limits the width property to be larger than the value specified in max-width.
        abstract maxWidth: U2<CSSWideKeyword, obj option> option with get, set
        /// Sets the minimum height for an element. It prevents the height of the element to be smaller than the specified value.
        /// The value of min-height overrides both max-height and height.
        abstract minHeight: U2<CSSWideKeyword, obj option> option with get, set
        /// Sets the minimum width of an element. It limits the width property to be not smaller than the value specified in min-width.
        abstract minWidth: U2<CSSWideKeyword, obj option> option with get, set
        /// Specifies the transparency of an element.
        /// See CSS 3 opacity property https://drafts.csswg.org/css-color-3/#opacity
        abstract opacity: U2<CSSWideKeyword, float> option with get, set
        /// Specifies the order used to lay out flex items in their flex container.
        /// Elements are laid out in the ascending order of the order value.
        /// See CSS order property https://drafts.csswg.org/css-flexbox-1/#order-property
        abstract order: U2<CSSWideKeyword, float> option with get, set
        /// In paged media, this property defines the minimum number of lines in
        /// a block container that must be left at the bottom of the page.
        /// See CSS 3 orphans, widows properties https://drafts.csswg.org/css-break-3/#widows-orphans
        abstract orphans: U2<CSSWideKeyword, float> option with get, set
        /// The CSS outline property is a shorthand property for setting one or more of the individual outline properties outline-style,
        /// outline-width and outline-color in a single rule. In most cases the use of this shortcut is preferable and more convenient.
        /// Outlines differ from borders in the following ways:
        ///       •       Outlines do not take up space, they are drawn above the content.
        ///       •       Outlines may be non-rectangular. They are rectangular in Gecko/Firefox.
        ///               Internet Explorer attempts to place the smallest contiguous outline around all elements or shapes that are indicated to have an outline.
        ///               Opera draws a non-rectangular shape around a construct.
        abstract outline: U2<CSSWideKeyword, obj option> option with get, set
        /// The outline-color property sets the color of the outline of an element. An outline is a line that is drawn around elements, outside the border edge, to make the element stand out.
        abstract outlineColor: U2<CSSWideKeyword, obj option> option with get, set
        /// The outline-offset property offsets the outline and draw it beyond the border edge.
        abstract outlineOffset: U2<CSSWideKeyword, obj option> option with get, set
        /// The overflow property controls how extra content exceeding the bounding box of an element is rendered.
        /// It can be used in conjunction with an element that has a fixed width and height, to eliminate text-induced page distortion.
        abstract overflow: U2<CSSWideKeyword, string> option with get, set
        /// Specifies the preferred scrolling methods for elements that overflow.
        abstract overflowStyle: U2<CSSWideKeyword, obj option> option with get, set
        /// Controls how extra content exceeding the x-axis of the bounding box of an element is rendered.
        abstract overflowX: U2<CSSWideKeyword, string> option with get, set
        /// Controls how extra content exceeding the y-axis of the bounding box of an element is rendered.
        abstract overflowY: U2<CSSWideKeyword, string> option with get, set
        /// The padding optional CSS property sets the required padding space on one to four sides of an element.
        /// The padding area is the space between an element and its border. Negative values are not allowed but decimal values are permitted.
        /// The element size is treated as fixed, and the content of the element shifts toward the center as padding is increased.
        /// The padding property is a shorthand to avoid setting each side separately (padding-top, padding-right, padding-bottom, padding-left).
        abstract padding: U2<CSSWideKeyword, obj option> option with get, set
        /// The padding-bottom CSS property of an element sets the padding space required on the bottom of an element.
        /// The padding area is the space between the content of the element and its border.
        /// Contrary to margin-bottom values, negative values of padding-bottom are invalid.
        abstract paddingBottom: U2<CSSWideKeyword, obj option> option with get, set
        /// The padding-left CSS property of an element sets the padding space required on the left side of an element.
        /// The padding area is the space between the content of the element and its border.
        /// Contrary to margin-left values, negative values of padding-left are invalid.
        abstract paddingLeft: U2<CSSWideKeyword, obj option> option with get, set
        /// The padding-right CSS property of an element sets the padding space required on the right side of an element.
        /// The padding area is the space between the content of the element and its border.
        /// Contrary to margin-right values, negative values of padding-right are invalid.
        abstract paddingRight: U2<CSSWideKeyword, obj option> option with get, set
        /// The padding-top CSS property of an element sets the padding space required on the top of an element.
        /// The padding area is the space between the content of the element and its border.
        /// Contrary to margin-top values, negative values of padding-top are invalid.
        abstract paddingTop: U2<CSSWideKeyword, obj option> option with get, set
        /// The page-break-after property is supported in all major browsers. With CSS3, page-break-* properties are only aliases of the break-* properties.
        /// The CSS3 Fragmentation spec defines breaks for all CSS box fragmentation.
        abstract pageBreakAfter: U2<CSSWideKeyword, obj option> option with get, set
        /// The page-break-before property sets the page-breaking behavior before an element.
        /// With CSS3, page-break-* properties are only aliases of the break-* properties.
        /// The CSS3 Fragmentation spec defines breaks for all CSS box fragmentation.
        abstract pageBreakBefore: U2<CSSWideKeyword, obj option> option with get, set
        /// Sets the page-breaking behavior inside an element. With CSS3, page-break-* properties are only aliases of the break-* properties.
        /// The CSS3 Fragmentation spec defines breaks for all CSS box fragmentation.
        abstract pageBreakInside: U2<CSSWideKeyword, obj option> option with get, set
        /// The pause property determines how long a speech media agent should pause before and after presenting an element.
        /// It is a shorthand for the pause-before and pause-after properties.
        abstract pause: U2<CSSWideKeyword, obj option> option with get, set
        /// The pause-after property determines how long a speech media agent should pause after presenting an element.
        /// It may be replaced by the shorthand property pause, which sets pause time before and after.
        abstract pauseAfter: U2<CSSWideKeyword, obj option> option with get, set
        /// The pause-before property determines how long a speech media agent should pause before presenting an element.
        /// It may be replaced by the shorthand property pause, which sets pause time before and after.
        abstract pauseBefore: U2<CSSWideKeyword, obj option> option with get, set
        /// The perspective property defines how far an element is placed from the view on the z-axis, from the screen to the viewer.
        /// Perspective defines how an object is viewed. In graphic arts, perspective is the representation on a flat surface of what the viewer's eye would see in a 3D space.
        /// (See Wikipedia for more information about graphical perspective and for related illustrations.)
        /// The illusion of perspective on a flat surface, such as a computer screen,
        /// is created by projecting points on the flat surface as they would appear if the flat surface were a window
        /// through which the viewer was looking at the object. In discussion of virtual environments, this flat surface is called a projection plane.
        abstract perspective: U2<CSSWideKeyword, obj option> option with get, set
        /// The perspective-origin property establishes the origin for the perspective property.
        /// It effectively sets the X and Y position at which the viewer appears to be looking at the children of the element.
        /// When used with perspective, perspective-origin changes the appearance of an object,
        /// as if a viewer were looking at it from a different origin.
        /// An object appears differently if a viewer is looking directly at it versus looking at it from below, above, or from the side.
        /// Thus, the perspective-origin is like a vanishing point.
        /// The default value of perspective-origin is 50% 50%.
        /// This displays an object as if the viewer's eye were positioned directly at the center of the screen, both top-to-bottom and left-to-right.
        /// A value of 0% 0% changes the object as if the viewer was looking toward the top left angle.
        /// A value of 100% 100% changes the appearance as if viewed toward the bottom right angle.
        abstract perspectiveOrigin: U2<CSSWideKeyword, obj option> option with get, set
        /// The pointer-events property allows you to control whether an element can be the target for the pointing device (e.g, mouse, pen) events.
        abstract pointerEvents: U2<CSSWideKeyword, obj option> option with get, set
        /// The position property controls the type of positioning used by an element within its parent elements.
        /// The effect of the position property depends on a lot of factors, for example the position property of parent elements.
        abstract position: U2<CSSWideKeyword, string> option with get, set
        /// Obsolete: unsupported.
        /// This property determines whether or not a full-width punctuation mark character should be trimmed if it appears at the beginning of a line,
        /// so that its "ink" lines up with the first glyph in the line above and below.
        abstract punctuationTrim: U2<CSSWideKeyword, obj option> option with get, set
        /// Sets the type of quotation marks for embedded quotations.
        abstract quotes: U2<CSSWideKeyword, obj option> option with get, set
        /// Controls whether the last region in a chain displays additional 'overset' content according its default overflow property,
        /// or if it displays a fragment of content as if it were flowing into a subsequent region.
        abstract regionFragment: U2<CSSWideKeyword, obj option> option with get, set
        /// The rest-after property determines how long a speech media agent should pause after presenting an element's main content,
        /// before presenting that element's exit cue sound. It may be replaced by the shorthand property rest, which sets rest time before and after.
        abstract restAfter: U2<CSSWideKeyword, obj option> option with get, set
        /// The rest-before property determines how long a speech media agent should pause after presenting an intro cue sound for an element,
        /// before presenting that element's main content. It may be replaced by the shorthand property rest, which sets rest time before and after.
        abstract restBefore: U2<CSSWideKeyword, obj option> option with get, set
        /// Specifies the position an element in relation to the right side of the containing element.
        abstract right: U2<CSSWideKeyword, obj option> option with get, set
        abstract rubyAlign: U2<CSSWideKeyword, obj option> option with get, set
        abstract rubyPosition: U2<CSSWideKeyword, obj option> option with get, set
        /// Defines the alpha channel threshold used to extract a shape from an image. Can be thought of as a "minimum opacity" threshold;
        /// that is, a value of 0.5 means that the shape will enclose all the pixels that are more than 50% opaque.
        abstract shapeImageThreshold: U2<CSSWideKeyword, obj option> option with get, set
        /// A future level of CSS Shapes will define a shape-inside property, which will define a shape to wrap content within the element.
        /// See Editor's Draft <http://dev.w3.org/csswg/css-shapes/> and CSSWG wiki page on next-level plans <http://wiki.csswg.org/spec/css-shapes>
        abstract shapeInside: U2<CSSWideKeyword, obj option> option with get, set
        /// Adds a margin to a shape-outside. In effect, defines a new shape that is the smallest contour around all the points
        /// that are the shape-margin distance outward perpendicular to each point on the underlying shape.
        /// For points where a perpendicular direction is not defined (e.g., a triangle corner),
        /// takes all points on a circle centered at the point and with a radius of the shape-margin distance.
        /// This property accepts only non-negative values.
        abstract shapeMargin: U2<CSSWideKeyword, obj option> option with get, set
        /// Declares a shape around which text should be wrapped, with possible modifications from the shape-margin property.
        /// The shape defined by shape-outside and shape-margin changes the geometry of a float element's float area.
        abstract shapeOutside: U2<CSSWideKeyword, obj option> option with get, set
        /// The speak property determines whether or not a speech synthesizer will read aloud the contents of an element.
        abstract speak: U2<CSSWideKeyword, obj option> option with get, set
        /// The speak-as property determines how the speech synthesizer interprets the content: words as whole words or as a sequence of letters,
        /// numbers as a numerical value or a sequence of digits, punctuation as pauses in speech or named punctuation characters.
        abstract speakAs: U2<CSSWideKeyword, obj option> option with get, set
        /// SVG: Specifies the opacity of the outline on the current object.
        /// See SVG 1.1 https://www.w3.org/TR/SVG/painting.html#StrokeOpacityProperty
        abstract strokeOpacity: U2<CSSWideKeyword, float> option with get, set
        /// SVG: Specifies the width of the outline on the current object.
        /// See SVG 1.1 https://www.w3.org/TR/SVG/painting.html#StrokeWidthProperty
        abstract strokeWidth: U3<CSSWideKeyword, CSSPercentage, CSSLength> option with get, set
        /// The tab-size CSS property is used to customise the width of a tab (U+0009) character.
        abstract tabSize: U2<CSSWideKeyword, obj option> option with get, set
        /// The 'table-layout' property controls the algorithm used to lay out the table cells, rows, and columns.
        abstract tableLayout: U2<CSSWideKeyword, obj option> option with get, set
        /// The text-align CSS property describes how inline content like text is aligned in its parent block element.
        /// text-align does not control the alignment of block elements itself, only their inline content.
        abstract textAlign: U2<CSSWideKeyword, obj option> option with get, set
        /// The text-align-last CSS property describes how the last line of a block element or a line before line break is aligned in its parent block element.
        abstract textAlignLast: U2<CSSWideKeyword, obj option> option with get, set
        /// The text-decoration CSS property is used to set the text formatting to underline, overline, line-through or blink.
        /// underline and overline decorations are positioned under the text, line-through over it.
        abstract textDecoration: U2<CSSWideKeyword, obj option> option with get, set
        /// Sets the color of any text decoration, such as underlines, overlines, and strike throughs.
        abstract textDecorationColor: U2<CSSWideKeyword, obj option> option with get, set
        /// Sets what kind of line decorations are added to an element, such as underlines, overlines, etc.
        abstract textDecorationLine: U2<CSSWideKeyword, obj option> option with get, set
        abstract textDecorationLineThrough: U2<CSSWideKeyword, obj option> option with get, set
        abstract textDecorationNone: U2<CSSWideKeyword, obj option> option with get, set
        abstract textDecorationOverline: U2<CSSWideKeyword, obj option> option with get, set
        /// Specifies what parts of an element’s content are skipped over when applying any text decoration.
        abstract textDecorationSkip: U2<CSSWideKeyword, obj option> option with get, set
        /// This property specifies the style of the text decoration line drawn on the specified element.
        /// The intended meaning for the values are the same as those of the border-style-properties.
        abstract textDecorationStyle: U2<CSSWideKeyword, obj option> option with get, set
        abstract textDecorationUnderline: U2<CSSWideKeyword, obj option> option with get, set
        /// The text-emphasis property will apply special emphasis marks to the elements text.
        /// Slightly similar to the text-decoration property only that this property can have affect on the line-height.
        /// It also is noted that this is shorthand for text-emphasis-style and for text-emphasis-color.
        abstract textEmphasis: U2<CSSWideKeyword, obj option> option with get, set
        /// The text-emphasis-color property specifies the foreground color of the emphasis marks.
        abstract textEmphasisColor: U2<CSSWideKeyword, obj option> option with get, set
        /// The text-emphasis-style property applies special emphasis marks to an element's text.
        abstract textEmphasisStyle: U2<CSSWideKeyword, obj option> option with get, set
        /// This property helps determine an inline box's block-progression dimension,
        /// derived from the text-height and font-size properties for non-replaced elements,
        /// the height or the width for replaced elements, and the stacked block-progression dimension for inline-block elements.
        /// The block-progression dimension determines the position of the padding, border and margin for the element.
        abstract textHeight: U2<CSSWideKeyword, obj option> option with get, set
        /// Specifies the amount of space horizontally that should be left on the first line of the text of an element.
        /// This horizontal spacing is at the beginning of the first line and is in respect to the left edge of the containing block box.
        abstract textIndent: U2<CSSWideKeyword, obj option> option with get, set
        abstract textJustifyTrim: U2<CSSWideKeyword, obj option> option with get, set
        abstract textKashidaSpace: U2<CSSWideKeyword, obj option> option with get, set
        /// The text-line-through property is a shorthand property for text-line-through-style, text-line-through-color and text-line-through-mode.
        /// (Considered obsolete; use text-decoration instead.)
        abstract textLineThrough: U2<CSSWideKeyword, obj option> option with get, set
        /// Specifies the line colors for the line-through text decoration.
        /// (Considered obsolete; use text-decoration-color instead.)
        abstract textLineThroughColor: U2<CSSWideKeyword, obj option> option with get, set
        /// Sets the mode for the line-through text decoration, determining whether the text decoration affects the space characters or not.
        /// (Considered obsolete; use text-decoration-skip instead.)
        abstract textLineThroughMode: U2<CSSWideKeyword, obj option> option with get, set
        /// Specifies the line style for line-through text decoration.
        /// (Considered obsolete; use text-decoration-style instead.)
        abstract textLineThroughStyle: U2<CSSWideKeyword, obj option> option with get, set
        /// Specifies the line width for the line-through text decoration.
        abstract textLineThroughWidth: U2<CSSWideKeyword, obj option> option with get, set
        /// The text-overflow shorthand CSS property determines how overflowed content that is not displayed is signaled to the users.
        /// It can be clipped, display an ellipsis ('…', U+2026 HORIZONTAL ELLIPSIS) or a Web author-defined string.
        /// It covers the two long-hand properties text-overflow-mode and text-overflow-ellipsis
        abstract textOverflow: U2<CSSWideKeyword, obj option> option with get, set
        /// The text-overline property is the shorthand for the text-overline-style, text-overline-width, text-overline-color, and text-overline-mode properties.
        abstract textOverline: U2<CSSWideKeyword, obj option> option with get, set
        /// Specifies the line color for the overline text decoration.
        abstract textOverlineColor: U2<CSSWideKeyword, obj option> option with get, set
        /// Sets the mode for the overline text decoration, determining whether the text decoration affects the space characters or not.
        abstract textOverlineMode: U2<CSSWideKeyword, obj option> option with get, set
        /// Specifies the line style for overline text decoration.
        abstract textOverlineStyle: U2<CSSWideKeyword, obj option> option with get, set
        /// Specifies the line width for the overline text decoration.
        abstract textOverlineWidth: U2<CSSWideKeyword, obj option> option with get, set
        /// The text-rendering CSS property provides information to the browser about how to optimize when rendering text.
        /// Options are: legibility, speed or geometric precision.
        abstract textRendering: U2<CSSWideKeyword, obj option> option with get, set
        /// Obsolete: unsupported.
        abstract textScript: U2<CSSWideKeyword, obj option> option with get, set
        /// The CSS text-shadow property applies one or more drop shadows to the text and <text-decorations> of an element.
        /// Each shadow is specified as an offset from the text, along with optional color and blur radius values.
        abstract textShadow: U2<CSSWideKeyword, obj option> option with get, set
        /// This property transforms text for styling purposes. (It has no effect on the underlying content.)
        abstract textTransform: U2<CSSWideKeyword, obj option> option with get, set
        /// Unsupported.
        /// This property will add a underline position value to the element that has an underline defined.
        abstract textUnderlinePosition: U2<CSSWideKeyword, obj option> option with get, set
        /// After review this should be replaced by text-decoration should it not?
        /// This property will set the underline style for text with a line value for underline, overline, and line-through.
        abstract textUnderlineStyle: U2<CSSWideKeyword, obj option> option with get, set
        /// This property specifies how far an absolutely positioned box's top margin edge is offset below the top edge of the box's containing block.
        /// For relatively positioned boxes, the offset is with respect to the top edges of the box itself (i.e., the box is given a position in the normal flow,
        /// then offset from that position according to these properties).
        abstract top: U2<CSSWideKeyword, obj option> option with get, set
        /// Determines whether touch input may trigger default behavior supplied by the user agent, such as panning or zooming.
        abstract touchAction: U2<CSSWideKeyword, obj option> option with get, set
        /// CSS transforms allow elements styled with CSS to be transformed in two-dimensional or three-dimensional space.
        /// Using this property, elements can be translated, rotated, scaled, and skewed. The value list may consist of 2D and/or 3D transform values.
        abstract transform: U2<CSSWideKeyword, obj option> option with get, set
        /// This property defines the origin of the transformation axes relative to the element to which the transformation is applied.
        abstract transformOrigin: U2<CSSWideKeyword, obj option> option with get, set
        /// This property allows you to define the relative position of the origin of the transformation grid along the z-axis.
        abstract transformOriginZ: U2<CSSWideKeyword, obj option> option with get, set
        /// This property specifies how nested elements are rendered in 3D space relative to their parent.
        abstract transformStyle: U2<CSSWideKeyword, obj option> option with get, set
        /// The transition CSS property is a shorthand property for transition-property, transition-duration, transition-timing-function,
        /// and transition-delay. It allows to define the transition between two states of an element.
        abstract transition: U2<CSSWideKeyword, obj option> option with get, set
        /// Defines when the transition will start. A value of ‘0s’ means the transition will execute as soon as the property is changed.
        /// Otherwise, the value specifies an offset from the moment the property is changed, and the transition will delay execution by that offset.
        abstract transitionDelay: U2<CSSWideKeyword, obj option> option with get, set
        /// The 'transition-duration' property specifies the length of time a transition animation takes to complete.
        abstract transitionDuration: U2<CSSWideKeyword, obj option> option with get, set
        /// The 'transition-property' property specifies the name of the CSS property to which the transition is applied.
        abstract transitionProperty: U2<CSSWideKeyword, obj option> option with get, set
        /// Sets the pace of action within a transition
        abstract transitionTimingFunction: U2<CSSWideKeyword, obj option> option with get, set
        /// The unicode-bidi CSS property specifies the level of embedding with respect to the bidirectional algorithm.
        abstract unicodeBidi: U2<CSSWideKeyword, obj option> option with get, set
        /// unicode-range allows you to set a specific range of characters to be downloaded from a font (embedded using @font-face) and made available for use on the current page.
        abstract unicodeRange: U2<CSSWideKeyword, obj option> option with get, set
        /// This is for all the high level UX stuff.
        abstract userFocus: U2<CSSWideKeyword, obj option> option with get, set
        /// For inputing user content
        abstract userInput: U2<CSSWideKeyword, obj option> option with get, set
        /// The vertical-align property controls how inline elements or text are vertically aligned compared to the baseline.
        /// If this property is used on table-cells it controls the vertical alignment of content of the table cell.
        abstract verticalAlign: U2<CSSWideKeyword, obj option> option with get, set
        /// The visibility property specifies whether the boxes generated by an element are rendered.
        abstract visibility: U2<CSSWideKeyword, obj option> option with get, set
        /// The voice-balance property sets the apparent position (in stereo sound) of the synthesized voice for spoken media.
        abstract voiceBalance: U2<CSSWideKeyword, obj option> option with get, set
        /// The voice-duration property allows the author to explicitly set the amount of time it should take a speech synthesizer to read an element's content,
        /// for example to allow the speech to be synchronized with other media.
        /// With a value of auto (the default) the length of time it takes to read the content is determined by the content itself and the voice-rate property.
        abstract voiceDuration: U2<CSSWideKeyword, obj option> option with get, set
        /// The voice-family property sets the speaker's voice used by a speech media agent to read an element.
        /// The speaker may be specified as a named character (to match a voice option in the speech reading software)
        /// or as a generic description of the age and gender of the voice.
        /// Similar to the font-family property for visual media,
        /// a comma-separated list of fallback options may be given in case the speech reader does not recognize the character name
        /// or cannot synthesize the requested combination of generic properties.
        abstract voiceFamily: U2<CSSWideKeyword, obj option> option with get, set
        /// The voice-pitch property sets pitch or tone (high or low) for the synthesized speech when reading an element;
        /// the pitch may be specified absolutely or relative to the normal pitch for the voice-family used to read the text.
        abstract voicePitch: U2<CSSWideKeyword, obj option> option with get, set
        /// The voice-range property determines how much variation in pitch or tone will be created by the speech synthesize when reading an element.
        /// Emphasized text, grammatical structures and punctuation may all be rendered as changes in pitch,
        /// this property determines how strong or obvious those changes are;
        /// large ranges are associated with enthusiastic or emotional speech,
        /// while small ranges are associated with flat or mechanical speech.
        abstract voiceRange: U2<CSSWideKeyword, obj option> option with get, set
        /// The voice-rate property sets the speed at which the voice synthesized by a speech media agent will read content.
        abstract voiceRate: U2<CSSWideKeyword, obj option> option with get, set
        /// The voice-stress property sets the level of vocal emphasis to be used for synthesized speech reading the element.
        abstract voiceStress: U2<CSSWideKeyword, obj option> option with get, set
        /// The voice-volume property sets the volume for spoken content in speech media. It replaces the deprecated volume property.
        abstract voiceVolume: U2<CSSWideKeyword, obj option> option with get, set
        /// The white-space property controls whether and how white space inside the element is collapsed, and whether lines may wrap at unforced "soft wrap" opportunities.
        abstract whiteSpace: U2<CSSWideKeyword, obj option> option with get, set
        /// Obsolete: unsupported.
        abstract whiteSpaceTreatment: U2<CSSWideKeyword, obj option> option with get, set
        /// In paged media, this property defines the mimimum number of lines
        /// that must be left at the top of the second page.
        /// See CSS 3 orphans, widows properties https://drafts.csswg.org/css-break-3/#widows-orphans
        abstract widows: U2<CSSWideKeyword, float> option with get, set
        /// Specifies the width of the content area of an element. The content area of the element width does not include the padding, border, and margin of the element.
        abstract width: U2<CSSWideKeyword, obj option> option with get, set
        /// The word-break property is often used when there is long generated content that is strung together without and spaces or hyphens to beak apart.
        /// A common case of this is when there is a long URL that does not have any hyphens. This case could potentially cause the breaking of the layout as it could extend past the parent element.
        abstract wordBreak: U2<CSSWideKeyword, obj option> option with get, set
        /// The word-spacing CSS property specifies the spacing behavior between "words".
        abstract wordSpacing: U2<CSSWideKeyword, obj option> option with get, set
        /// An alias of css/properties/overflow-wrap, word-wrap defines whether to break words when the content exceeds the boundaries of its container.
        abstract wordWrap: U2<CSSWideKeyword, obj option> option with get, set
        /// Specifies how exclusions affect inline content within block-level elements. Elements lay out their inline content in their content area but wrap around exclusion areas.
        abstract wrapFlow: U2<CSSWideKeyword, obj option> option with get, set
        /// Set the value that is used to offset the inner wrap shape from other shapes. Inline content that intersects a shape with this property will be pushed by this shape's margin.
        abstract wrapMargin: U2<CSSWideKeyword, obj option> option with get, set
        /// Obsolete and unsupported. Do not use.
        /// This CSS property controls the text when it reaches the end of the block in which it is enclosed.
        abstract wrapOption: U2<CSSWideKeyword, obj option> option with get, set
        /// writing-mode specifies if lines of text are laid out horizontally or vertically, and the direction which lines of text and blocks progress.
        abstract writingMode: U2<CSSWideKeyword, obj option> option with get, set
        /// The z-index property specifies the z-order of an element and its descendants.
        /// When elements overlap, z-order determines which one covers the other.
        /// See CSS 2 z-index property https://www.w3.org/TR/CSS2/visuren.html#z-index
        abstract zIndex: U3<CSSWideKeyword, float, string> option with get, set
        /// Sets the initial zoom factor of a document defined by @viewport.
        /// See CSS zoom descriptor https://drafts.csswg.org/css-device-adapt/#zoom-desc
        abstract zoom: U4<CSSWideKeyword, float, CSSPercentage, string> option with get, set
        [<Emit "$0[$1]{{=$2}}">] abstract Item: propertyName: string -> obj option with get, set

    type [<AllowNullLiteral>] HTMLAttributes<'T> =
        inherit DOMAttributes<'T>
        abstract defaultChecked: bool option with get, set
        abstract defaultValue: U2<string, ResizeArray<string>> option with get, set
        abstract suppressContentEditableWarning: bool option with get, set
        abstract accessKey: string option with get, set
        abstract className: string option with get, set
        abstract contentEditable: bool option with get, set
        abstract contextMenu: string option with get, set
        abstract dir: string option with get, set
        abstract draggable: bool option with get, set
        abstract hidden: bool option with get, set
        abstract id: string option with get, set
        abstract lang: string option with get, set
        abstract slot: string option with get, set
        abstract spellCheck: bool option with get, set
        abstract style: CSSProperties option with get, set
        abstract tabIndex: float option with get, set
        abstract title: string option with get, set
        abstract inputMode: string option with get, set
        abstract is: string option with get, set
        abstract radioGroup: string option with get, set
        abstract role: string option with get, set
        abstract about: string option with get, set
        abstract datatype: string option with get, set
        abstract inlist: obj option with get, set
        abstract prefix: string option with get, set
        abstract property: string option with get, set
        abstract resource: string option with get, set
        abstract typeof: string option with get, set
        abstract vocab: string option with get, set
        abstract autoCapitalize: string option with get, set
        abstract autoCorrect: string option with get, set
        abstract autoSave: string option with get, set
        abstract color: string option with get, set
        abstract itemProp: string option with get, set
        abstract itemScope: bool option with get, set
        abstract itemType: string option with get, set
        abstract itemID: string option with get, set
        abstract itemRef: string option with get, set
        abstract results: float option with get, set
        abstract security: string option with get, set
        abstract unselectable: bool option with get, set

    type [<AllowNullLiteral>] AllHTMLAttributes<'T> =
        inherit HTMLAttributes<'T>
        abstract accept: string option with get, set
        abstract acceptCharset: string option with get, set
        abstract action: string option with get, set
        abstract allowFullScreen: bool option with get, set
        abstract allowTransparency: bool option with get, set
        abstract alt: string option with get, set
        abstract async: bool option with get, set
        abstract autoComplete: string option with get, set
        abstract autoFocus: bool option with get, set
        abstract autoPlay: bool option with get, set
        abstract capture: bool option with get, set
        abstract cellPadding: U2<float, string> option with get, set
        abstract cellSpacing: U2<float, string> option with get, set
        abstract charSet: string option with get, set
        abstract challenge: string option with get, set
        abstract ``checked``: bool option with get, set
        abstract cite: string option with get, set
        abstract classID: string option with get, set
        abstract cols: float option with get, set
        abstract colSpan: float option with get, set
        abstract content: string option with get, set
        abstract controls: bool option with get, set
        abstract coords: string option with get, set
        abstract crossOrigin: string option with get, set
        abstract data: string option with get, set
        abstract dateTime: string option with get, set
        abstract ``default``: bool option with get, set
        abstract defer: bool option with get, set
        abstract disabled: bool option with get, set
        abstract download: obj option with get, set
        abstract encType: string option with get, set
        abstract form: string option with get, set
        abstract formAction: string option with get, set
        abstract formEncType: string option with get, set
        abstract formMethod: string option with get, set
        abstract formNoValidate: bool option with get, set
        abstract formTarget: string option with get, set
        abstract frameBorder: U2<float, string> option with get, set
        abstract headers: string option with get, set
        abstract height: U2<float, string> option with get, set
        abstract high: float option with get, set
        abstract href: string option with get, set
        abstract hrefLang: string option with get, set
        abstract htmlFor: string option with get, set
        abstract httpEquiv: string option with get, set
        abstract integrity: string option with get, set
        abstract keyParams: string option with get, set
        abstract keyType: string option with get, set
        abstract kind: string option with get, set
        abstract label: string option with get, set
        abstract list: string option with get, set
        abstract loop: bool option with get, set
        abstract low: float option with get, set
        abstract manifest: string option with get, set
        abstract marginHeight: float option with get, set
        abstract marginWidth: float option with get, set
        abstract max: U2<float, string> option with get, set
        abstract maxLength: float option with get, set
        abstract media: string option with get, set
        abstract mediaGroup: string option with get, set
        abstract ``method``: string option with get, set
        abstract min: U2<float, string> option with get, set
        abstract minLength: float option with get, set
        abstract multiple: bool option with get, set
        abstract muted: bool option with get, set
        abstract name: string option with get, set
        abstract nonce: string option with get, set
        abstract noValidate: bool option with get, set
        abstract ``open``: bool option with get, set
        abstract optimum: float option with get, set
        abstract pattern: string option with get, set
        abstract placeholder: string option with get, set
        abstract playsInline: bool option with get, set
        abstract poster: string option with get, set
        abstract preload: string option with get, set
        abstract readOnly: bool option with get, set
        abstract rel: string option with get, set
        abstract required: bool option with get, set
        abstract reversed: bool option with get, set
        abstract rows: float option with get, set
        abstract rowSpan: float option with get, set
        abstract sandbox: string option with get, set
        abstract scope: string option with get, set
        abstract scoped: bool option with get, set
        abstract scrolling: string option with get, set
        abstract seamless: bool option with get, set
        abstract selected: bool option with get, set
        abstract shape: string option with get, set
        abstract size: float option with get, set
        abstract sizes: string option with get, set
        abstract span: float option with get, set
        abstract src: string option with get, set
        abstract srcDoc: string option with get, set
        abstract srcLang: string option with get, set
        abstract srcSet: string option with get, set
        abstract start: float option with get, set
        abstract step: U2<float, string> option with get, set
        abstract summary: string option with get, set
        abstract target: string option with get, set
        abstract ``type``: string option with get, set
        abstract useMap: string option with get, set
        abstract value: U3<string, ResizeArray<string>, float> option with get, set
        abstract width: U2<float, string> option with get, set
        abstract wmode: string option with get, set
        abstract wrap: string option with get, set

    type [<AllowNullLiteral>] AnchorHTMLAttributes<'T> =
        inherit HTMLAttributes<'T>
        abstract download: obj option with get, set
        abstract href: string option with get, set
        abstract hrefLang: string option with get, set
        abstract media: string option with get, set
        abstract rel: string option with get, set
        abstract target: string option with get, set

    type [<AllowNullLiteral>] AudioHTMLAttributes<'T> =
        inherit MediaHTMLAttributes<'T>

    type [<AllowNullLiteral>] AreaHTMLAttributes<'T> =
        inherit HTMLAttributes<'T>
        abstract alt: string option with get, set
        abstract coords: string option with get, set
        abstract download: obj option with get, set
        abstract href: string option with get, set
        abstract hrefLang: string option with get, set
        abstract media: string option with get, set
        abstract rel: string option with get, set
        abstract shape: string option with get, set
        abstract target: string option with get, set

    type [<AllowNullLiteral>] BaseHTMLAttributes<'T> =
        inherit HTMLAttributes<'T>
        abstract href: string option with get, set
        abstract target: string option with get, set

    type [<AllowNullLiteral>] BlockquoteHTMLAttributes<'T> =
        inherit HTMLAttributes<'T>
        abstract cite: string option with get, set

    type [<AllowNullLiteral>] ButtonHTMLAttributes<'T> =
        inherit HTMLAttributes<'T>
        abstract autoFocus: bool option with get, set
        abstract disabled: bool option with get, set
        abstract form: string option with get, set
        abstract formAction: string option with get, set
        abstract formEncType: string option with get, set
        abstract formMethod: string option with get, set
        abstract formNoValidate: bool option with get, set
        abstract formTarget: string option with get, set
        abstract name: string option with get, set
        abstract ``type``: string option with get, set
        abstract value: U3<string, ResizeArray<string>, float> option with get, set

    type [<AllowNullLiteral>] CanvasHTMLAttributes<'T> =
        inherit HTMLAttributes<'T>
        abstract height: U2<float, string> option with get, set
        abstract width: U2<float, string> option with get, set

    type [<AllowNullLiteral>] ColHTMLAttributes<'T> =
        inherit HTMLAttributes<'T>
        abstract span: float option with get, set

    type [<AllowNullLiteral>] ColgroupHTMLAttributes<'T> =
        inherit HTMLAttributes<'T>
        abstract span: float option with get, set

    type [<AllowNullLiteral>] DetailsHTMLAttributes<'T> =
        inherit HTMLAttributes<'T>
        abstract ``open``: bool option with get, set

    type [<AllowNullLiteral>] DelHTMLAttributes<'T> =
        inherit HTMLAttributes<'T>
        abstract cite: string option with get, set
        abstract dateTime: string option with get, set

    type [<AllowNullLiteral>] EmbedHTMLAttributes<'T> =
        inherit HTMLAttributes<'T>
        abstract height: U2<float, string> option with get, set
        abstract src: string option with get, set
        abstract ``type``: string option with get, set
        abstract width: U2<float, string> option with get, set

    type [<AllowNullLiteral>] FieldsetHTMLAttributes<'T> =
        inherit HTMLAttributes<'T>
        abstract disabled: bool option with get, set
        abstract form: string option with get, set
        abstract name: string option with get, set

    type [<AllowNullLiteral>] FormHTMLAttributes<'T> =
        inherit HTMLAttributes<'T>
        abstract acceptCharset: string option with get, set
        abstract action: string option with get, set
        abstract autoComplete: string option with get, set
        abstract encType: string option with get, set
        abstract ``method``: string option with get, set
        abstract name: string option with get, set
        abstract noValidate: bool option with get, set
        abstract target: string option with get, set

    type [<AllowNullLiteral>] HtmlHTMLAttributes<'T> =
        inherit HTMLAttributes<'T>
        abstract manifest: string option with get, set

    type [<AllowNullLiteral>] IframeHTMLAttributes<'T> =
        inherit HTMLAttributes<'T>
        abstract allowFullScreen: bool option with get, set
        abstract allowTransparency: bool option with get, set
        abstract frameBorder: U2<float, string> option with get, set
        abstract height: U2<float, string> option with get, set
        abstract marginHeight: float option with get, set
        abstract marginWidth: float option with get, set
        abstract name: string option with get, set
        abstract sandbox: string option with get, set
        abstract scrolling: string option with get, set
        abstract seamless: bool option with get, set
        abstract src: string option with get, set
        abstract srcDoc: string option with get, set
        abstract width: U2<float, string> option with get, set

    type [<AllowNullLiteral>] ImgHTMLAttributes<'T> =
        inherit HTMLAttributes<'T>
        abstract alt: string option with get, set
        abstract height: U2<float, string> option with get, set
        abstract sizes: string option with get, set
        abstract src: string option with get, set
        abstract srcSet: string option with get, set
        abstract useMap: string option with get, set
        abstract width: U2<float, string> option with get, set

    type [<AllowNullLiteral>] InsHTMLAttributes<'T> =
        inherit HTMLAttributes<'T>
        abstract cite: string option with get, set
        abstract dateTime: string option with get, set

    type [<AllowNullLiteral>] InputHTMLAttributes<'T> =
        inherit HTMLAttributes<'T>
        abstract accept: string option with get, set
        abstract alt: string option with get, set
        abstract autoComplete: string option with get, set
        abstract autoFocus: bool option with get, set
        abstract capture: bool option with get, set
        abstract ``checked``: bool option with get, set
        abstract crossOrigin: string option with get, set
        abstract disabled: bool option with get, set
        abstract form: string option with get, set
        abstract formAction: string option with get, set
        abstract formEncType: string option with get, set
        abstract formMethod: string option with get, set
        abstract formNoValidate: bool option with get, set
        abstract formTarget: string option with get, set
        abstract height: U2<float, string> option with get, set
        abstract list: string option with get, set
        abstract max: U2<float, string> option with get, set
        abstract maxLength: float option with get, set
        abstract min: U2<float, string> option with get, set
        abstract minLength: float option with get, set
        abstract multiple: bool option with get, set
        abstract name: string option with get, set
        abstract pattern: string option with get, set
        abstract placeholder: string option with get, set
        abstract readOnly: bool option with get, set
        abstract required: bool option with get, set
        abstract size: float option with get, set
        abstract src: string option with get, set
        abstract step: U2<float, string> option with get, set
        abstract ``type``: string option with get, set
        abstract value: U3<string, ResizeArray<string>, float> option with get, set
        abstract width: U2<float, string> option with get, set
        abstract onChange: ChangeEventHandler<'T> option with get, set

    type [<AllowNullLiteral>] KeygenHTMLAttributes<'T> =
        inherit HTMLAttributes<'T>
        abstract autoFocus: bool option with get, set
        abstract challenge: string option with get, set
        abstract disabled: bool option with get, set
        abstract form: string option with get, set
        abstract keyType: string option with get, set
        abstract keyParams: string option with get, set
        abstract name: string option with get, set

    type [<AllowNullLiteral>] LabelHTMLAttributes<'T> =
        inherit HTMLAttributes<'T>
        abstract form: string option with get, set
        abstract htmlFor: string option with get, set

    type [<AllowNullLiteral>] LiHTMLAttributes<'T> =
        inherit HTMLAttributes<'T>
        abstract value: U3<string, ResizeArray<string>, float> option with get, set

    type [<AllowNullLiteral>] LinkHTMLAttributes<'T> =
        inherit HTMLAttributes<'T>
        abstract href: string option with get, set
        abstract hrefLang: string option with get, set
        abstract integrity: string option with get, set
        abstract media: string option with get, set
        abstract rel: string option with get, set
        abstract sizes: string option with get, set
        abstract ``type``: string option with get, set

    type [<AllowNullLiteral>] MapHTMLAttributes<'T> =
        inherit HTMLAttributes<'T>
        abstract name: string option with get, set

    type [<AllowNullLiteral>] MenuHTMLAttributes<'T> =
        inherit HTMLAttributes<'T>
        abstract ``type``: string option with get, set

    type [<AllowNullLiteral>] MediaHTMLAttributes<'T> =
        inherit HTMLAttributes<'T>
        abstract autoPlay: bool option with get, set
        abstract controls: bool option with get, set
        abstract crossOrigin: string option with get, set
        abstract loop: bool option with get, set
        abstract mediaGroup: string option with get, set
        abstract muted: bool option with get, set
        abstract preload: string option with get, set
        abstract src: string option with get, set

    type [<AllowNullLiteral>] MetaHTMLAttributes<'T> =
        inherit HTMLAttributes<'T>
        abstract charSet: string option with get, set
        abstract content: string option with get, set
        abstract httpEquiv: string option with get, set
        abstract name: string option with get, set

    type [<AllowNullLiteral>] MeterHTMLAttributes<'T> =
        inherit HTMLAttributes<'T>
        abstract form: string option with get, set
        abstract high: float option with get, set
        abstract low: float option with get, set
        abstract max: U2<float, string> option with get, set
        abstract min: U2<float, string> option with get, set
        abstract optimum: float option with get, set
        abstract value: U3<string, ResizeArray<string>, float> option with get, set

    type [<AllowNullLiteral>] QuoteHTMLAttributes<'T> =
        inherit HTMLAttributes<'T>
        abstract cite: string option with get, set

    type [<AllowNullLiteral>] ObjectHTMLAttributes<'T> =
        inherit HTMLAttributes<'T>
        abstract classID: string option with get, set
        abstract data: string option with get, set
        abstract form: string option with get, set
        abstract height: U2<float, string> option with get, set
        abstract name: string option with get, set
        abstract ``type``: string option with get, set
        abstract useMap: string option with get, set
        abstract width: U2<float, string> option with get, set
        abstract wmode: string option with get, set

    type [<AllowNullLiteral>] OlHTMLAttributes<'T> =
        inherit HTMLAttributes<'T>
        abstract reversed: bool option with get, set
        abstract start: float option with get, set

    type [<AllowNullLiteral>] OptgroupHTMLAttributes<'T> =
        inherit HTMLAttributes<'T>
        abstract disabled: bool option with get, set
        abstract label: string option with get, set

    type [<AllowNullLiteral>] OptionHTMLAttributes<'T> =
        inherit HTMLAttributes<'T>
        abstract disabled: bool option with get, set
        abstract label: string option with get, set
        abstract selected: bool option with get, set
        abstract value: U3<string, ResizeArray<string>, float> option with get, set

    type [<AllowNullLiteral>] OutputHTMLAttributes<'T> =
        inherit HTMLAttributes<'T>
        abstract form: string option with get, set
        abstract htmlFor: string option with get, set
        abstract name: string option with get, set

    type [<AllowNullLiteral>] ParamHTMLAttributes<'T> =
        inherit HTMLAttributes<'T>
        abstract name: string option with get, set
        abstract value: U3<string, ResizeArray<string>, float> option with get, set

    type [<AllowNullLiteral>] ProgressHTMLAttributes<'T> =
        inherit HTMLAttributes<'T>
        abstract max: U2<float, string> option with get, set
        abstract value: U3<string, ResizeArray<string>, float> option with get, set

    type [<AllowNullLiteral>] ScriptHTMLAttributes<'T> =
        inherit HTMLAttributes<'T>
        abstract async: bool option with get, set
        abstract charSet: string option with get, set
        abstract crossOrigin: string option with get, set
        abstract defer: bool option with get, set
        abstract integrity: string option with get, set
        abstract nonce: string option with get, set
        abstract src: string option with get, set
        abstract ``type``: string option with get, set

    type [<AllowNullLiteral>] SelectHTMLAttributes<'T> =
        inherit HTMLAttributes<'T>
        abstract autoFocus: bool option with get, set
        abstract disabled: bool option with get, set
        abstract form: string option with get, set
        abstract multiple: bool option with get, set
        abstract name: string option with get, set
        abstract required: bool option with get, set
        abstract size: float option with get, set
        abstract value: U3<string, ResizeArray<string>, float> option with get, set
        abstract onChange: ChangeEventHandler<'T> option with get, set

    type [<AllowNullLiteral>] SourceHTMLAttributes<'T> =
        inherit HTMLAttributes<'T>
        abstract media: string option with get, set
        abstract sizes: string option with get, set
        abstract src: string option with get, set
        abstract srcSet: string option with get, set
        abstract ``type``: string option with get, set

    type [<AllowNullLiteral>] StyleHTMLAttributes<'T> =
        inherit HTMLAttributes<'T>
        abstract media: string option with get, set
        abstract nonce: string option with get, set
        abstract scoped: bool option with get, set
        abstract ``type``: string option with get, set

    type [<AllowNullLiteral>] TableHTMLAttributes<'T> =
        inherit HTMLAttributes<'T>
        abstract cellPadding: U2<float, string> option with get, set
        abstract cellSpacing: U2<float, string> option with get, set
        abstract summary: string option with get, set

    type [<AllowNullLiteral>] TextareaHTMLAttributes<'T> =
        inherit HTMLAttributes<'T>
        abstract autoComplete: string option with get, set
        abstract autoFocus: bool option with get, set
        abstract cols: float option with get, set
        abstract dirName: string option with get, set
        abstract disabled: bool option with get, set
        abstract form: string option with get, set
        abstract maxLength: float option with get, set
        abstract minLength: float option with get, set
        abstract name: string option with get, set
        abstract placeholder: string option with get, set
        abstract readOnly: bool option with get, set
        abstract required: bool option with get, set
        abstract rows: float option with get, set
        abstract value: U3<string, ResizeArray<string>, float> option with get, set
        abstract wrap: string option with get, set
        abstract onChange: ChangeEventHandler<'T> option with get, set

    type [<AllowNullLiteral>] TdHTMLAttributes<'T> =
        inherit HTMLAttributes<'T>
        abstract colSpan: float option with get, set
        abstract headers: string option with get, set
        abstract rowSpan: float option with get, set
        abstract scope: string option with get, set

    type [<AllowNullLiteral>] ThHTMLAttributes<'T> =
        inherit HTMLAttributes<'T>
        abstract colSpan: float option with get, set
        abstract headers: string option with get, set
        abstract rowSpan: float option with get, set
        abstract scope: string option with get, set

    type [<AllowNullLiteral>] TimeHTMLAttributes<'T> =
        inherit HTMLAttributes<'T>
        abstract dateTime: string option with get, set

    type [<AllowNullLiteral>] TrackHTMLAttributes<'T> =
        inherit HTMLAttributes<'T>
        abstract ``default``: bool option with get, set
        abstract kind: string option with get, set
        abstract label: string option with get, set
        abstract src: string option with get, set
        abstract srcLang: string option with get, set

    type [<AllowNullLiteral>] VideoHTMLAttributes<'T> =
        inherit MediaHTMLAttributes<'T>
        abstract height: U2<float, string> option with get, set
        abstract playsInline: bool option with get, set
        abstract poster: string option with get, set
        abstract width: U2<float, string> option with get, set

    type [<AllowNullLiteral>] SVGAttributes<'T> =
        inherit DOMAttributes<'T>
        abstract className: string option with get, set
        abstract color: string option with get, set
        abstract height: U2<float, string> option with get, set
        abstract id: string option with get, set
        abstract lang: string option with get, set
        abstract max: U2<float, string> option with get, set
        abstract media: string option with get, set
        abstract ``method``: string option with get, set
        abstract min: U2<float, string> option with get, set
        abstract name: string option with get, set
        abstract style: CSSProperties option with get, set
        abstract target: string option with get, set
        abstract ``type``: string option with get, set
        abstract width: U2<float, string> option with get, set
        abstract role: string option with get, set
        abstract tabIndex: float option with get, set
        abstract accentHeight: U2<float, string> option with get, set
        abstract accumulate: SVGAttributesAccumulate option with get, set
        abstract additive: SVGAttributesAdditive option with get, set
        abstract alignmentBaseline: SVGAttributesAlignmentBaseline option with get, set
        abstract allowReorder: SVGAttributesAllowReorder option with get, set
        abstract alphabetic: U2<float, string> option with get, set
        abstract amplitude: U2<float, string> option with get, set
        abstract arabicForm: SVGAttributesArabicForm option with get, set
        abstract ascent: U2<float, string> option with get, set
        abstract attributeName: string option with get, set
        abstract attributeType: string option with get, set
        abstract autoReverse: U2<float, string> option with get, set
        abstract azimuth: U2<float, string> option with get, set
        abstract baseFrequency: U2<float, string> option with get, set
        abstract baselineShift: U2<float, string> option with get, set
        abstract baseProfile: U2<float, string> option with get, set
        abstract bbox: U2<float, string> option with get, set
        abstract ``begin``: U2<float, string> option with get, set
        abstract bias: U2<float, string> option with get, set
        abstract by: U2<float, string> option with get, set
        abstract calcMode: U2<float, string> option with get, set
        abstract capHeight: U2<float, string> option with get, set
        abstract clip: U2<float, string> option with get, set
        abstract clipPath: string option with get, set
        abstract clipPathUnits: U2<float, string> option with get, set
        abstract clipRule: U2<float, string> option with get, set
        abstract colorInterpolation: U2<float, string> option with get, set
        abstract colorInterpolationFilters: SVGAttributesColorInterpolationFilters option with get, set
        abstract colorProfile: U2<float, string> option with get, set
        abstract colorRendering: U2<float, string> option with get, set
        abstract contentScriptType: U2<float, string> option with get, set
        abstract contentStyleType: U2<float, string> option with get, set
        abstract cursor: U2<float, string> option with get, set
        abstract cx: U2<float, string> option with get, set
        abstract cy: U2<float, string> option with get, set
        abstract d: string option with get, set
        abstract decelerate: U2<float, string> option with get, set
        abstract descent: U2<float, string> option with get, set
        abstract diffuseConstant: U2<float, string> option with get, set
        abstract direction: U2<float, string> option with get, set
        abstract display: U2<float, string> option with get, set
        abstract divisor: U2<float, string> option with get, set
        abstract dominantBaseline: U2<float, string> option with get, set
        abstract dur: U2<float, string> option with get, set
        abstract dx: U2<float, string> option with get, set
        abstract dy: U2<float, string> option with get, set
        abstract edgeMode: U2<float, string> option with get, set
        abstract elevation: U2<float, string> option with get, set
        abstract enableBackground: U2<float, string> option with get, set
        abstract ``end``: U2<float, string> option with get, set
        abstract exponent: U2<float, string> option with get, set
        abstract externalResourcesRequired: U2<float, string> option with get, set
        abstract fill: string option with get, set
        abstract fillOpacity: U2<float, string> option with get, set
        abstract fillRule: SVGAttributesFillRule option with get, set
        abstract filter: string option with get, set
        abstract filterRes: U2<float, string> option with get, set
        abstract filterUnits: U2<float, string> option with get, set
        abstract floodColor: U2<float, string> option with get, set
        abstract floodOpacity: U2<float, string> option with get, set
        abstract focusable: U2<float, string> option with get, set
        abstract fontFamily: string option with get, set
        abstract fontSize: U2<float, string> option with get, set
        abstract fontSizeAdjust: U2<float, string> option with get, set
        abstract fontStretch: U2<float, string> option with get, set
        abstract fontStyle: U2<float, string> option with get, set
        abstract fontVariant: U2<float, string> option with get, set
        abstract fontWeight: U2<float, string> option with get, set
        abstract format: U2<float, string> option with get, set
        abstract from: U2<float, string> option with get, set
        abstract fx: U2<float, string> option with get, set
        abstract fy: U2<float, string> option with get, set
        abstract g1: U2<float, string> option with get, set
        abstract g2: U2<float, string> option with get, set
        abstract glyphName: U2<float, string> option with get, set
        abstract glyphOrientationHorizontal: U2<float, string> option with get, set
        abstract glyphOrientationVertical: U2<float, string> option with get, set
        abstract glyphRef: U2<float, string> option with get, set
        abstract gradientTransform: string option with get, set
        abstract gradientUnits: string option with get, set
        abstract hanging: U2<float, string> option with get, set
        abstract horizAdvX: U2<float, string> option with get, set
        abstract horizOriginX: U2<float, string> option with get, set
        abstract ideographic: U2<float, string> option with get, set
        abstract imageRendering: U2<float, string> option with get, set
        abstract in2: U2<float, string> option with get, set
        abstract ``in``: string option with get, set
        abstract intercept: U2<float, string> option with get, set
        abstract k1: U2<float, string> option with get, set
        abstract k2: U2<float, string> option with get, set
        abstract k3: U2<float, string> option with get, set
        abstract k4: U2<float, string> option with get, set
        abstract k: U2<float, string> option with get, set
        abstract kernelMatrix: U2<float, string> option with get, set
        abstract kernelUnitLength: U2<float, string> option with get, set
        abstract kerning: U2<float, string> option with get, set
        abstract keyPoints: U2<float, string> option with get, set
        abstract keySplines: U2<float, string> option with get, set
        abstract keyTimes: U2<float, string> option with get, set
        abstract lengthAdjust: U2<float, string> option with get, set
        abstract letterSpacing: U2<float, string> option with get, set
        abstract lightingColor: U2<float, string> option with get, set
        abstract limitingConeAngle: U2<float, string> option with get, set
        abstract local: U2<float, string> option with get, set
        abstract markerEnd: string option with get, set
        abstract markerHeight: U2<float, string> option with get, set
        abstract markerMid: string option with get, set
        abstract markerStart: string option with get, set
        abstract markerUnits: U2<float, string> option with get, set
        abstract markerWidth: U2<float, string> option with get, set
        abstract mask: string option with get, set
        abstract maskContentUnits: U2<float, string> option with get, set
        abstract maskUnits: U2<float, string> option with get, set
        abstract mathematical: U2<float, string> option with get, set
        abstract mode: U2<float, string> option with get, set
        abstract numOctaves: U2<float, string> option with get, set
        abstract offset: U2<float, string> option with get, set
        abstract opacity: U2<float, string> option with get, set
        abstract operator: U2<float, string> option with get, set
        abstract order: U2<float, string> option with get, set
        abstract orient: U2<float, string> option with get, set
        abstract orientation: U2<float, string> option with get, set
        abstract origin: U2<float, string> option with get, set
        abstract overflow: U2<float, string> option with get, set
        abstract overlinePosition: U2<float, string> option with get, set
        abstract overlineThickness: U2<float, string> option with get, set
        abstract paintOrder: U2<float, string> option with get, set
        abstract panose1: U2<float, string> option with get, set
        abstract pathLength: U2<float, string> option with get, set
        abstract patternContentUnits: string option with get, set
        abstract patternTransform: U2<float, string> option with get, set
        abstract patternUnits: string option with get, set
        abstract pointerEvents: U2<float, string> option with get, set
        abstract points: string option with get, set
        abstract pointsAtX: U2<float, string> option with get, set
        abstract pointsAtY: U2<float, string> option with get, set
        abstract pointsAtZ: U2<float, string> option with get, set
        abstract preserveAlpha: U2<float, string> option with get, set
        abstract preserveAspectRatio: string option with get, set
        abstract primitiveUnits: U2<float, string> option with get, set
        abstract r: U2<float, string> option with get, set
        abstract radius: U2<float, string> option with get, set
        abstract refX: U2<float, string> option with get, set
        abstract refY: U2<float, string> option with get, set
        abstract renderingIntent: U2<float, string> option with get, set
        abstract repeatCount: U2<float, string> option with get, set
        abstract repeatDur: U2<float, string> option with get, set
        abstract requiredExtensions: U2<float, string> option with get, set
        abstract requiredFeatures: U2<float, string> option with get, set
        abstract restart: U2<float, string> option with get, set
        abstract result: string option with get, set
        abstract rotate: U2<float, string> option with get, set
        abstract rx: U2<float, string> option with get, set
        abstract ry: U2<float, string> option with get, set
        abstract scale: U2<float, string> option with get, set
        abstract seed: U2<float, string> option with get, set
        abstract shapeRendering: U2<float, string> option with get, set
        abstract slope: U2<float, string> option with get, set
        abstract spacing: U2<float, string> option with get, set
        abstract specularConstant: U2<float, string> option with get, set
        abstract specularExponent: U2<float, string> option with get, set
        abstract speed: U2<float, string> option with get, set
        abstract spreadMethod: string option with get, set
        abstract startOffset: U2<float, string> option with get, set
        abstract stdDeviation: U2<float, string> option with get, set
        abstract stemh: U2<float, string> option with get, set
        abstract stemv: U2<float, string> option with get, set
        abstract stitchTiles: U2<float, string> option with get, set
        abstract stopColor: string option with get, set
        abstract stopOpacity: U2<float, string> option with get, set
        abstract strikethroughPosition: U2<float, string> option with get, set
        abstract strikethroughThickness: U2<float, string> option with get, set
        abstract string: U2<float, string> option with get, set
        abstract stroke: string option with get, set
        abstract strokeDasharray: U2<string, float> option with get, set
        abstract strokeDashoffset: U2<string, float> option with get, set
        abstract strokeLinecap: SVGAttributesStrokeLinecap option with get, set
        abstract strokeLinejoin: SVGAttributesStrokeLinejoin option with get, set
        abstract strokeMiterlimit: string option with get, set
        abstract strokeOpacity: U2<float, string> option with get, set
        abstract strokeWidth: U2<float, string> option with get, set
        abstract surfaceScale: U2<float, string> option with get, set
        abstract systemLanguage: U2<float, string> option with get, set
        abstract tableValues: U2<float, string> option with get, set
        abstract targetX: U2<float, string> option with get, set
        abstract targetY: U2<float, string> option with get, set
        abstract textAnchor: string option with get, set
        abstract textDecoration: U2<float, string> option with get, set
        abstract textLength: U2<float, string> option with get, set
        abstract textRendering: U2<float, string> option with get, set
        abstract ``to``: U2<float, string> option with get, set
        abstract transform: string option with get, set
        abstract u1: U2<float, string> option with get, set
        abstract u2: U2<float, string> option with get, set
        abstract underlinePosition: U2<float, string> option with get, set
        abstract underlineThickness: U2<float, string> option with get, set
        abstract unicode: U2<float, string> option with get, set
        abstract unicodeBidi: U2<float, string> option with get, set
        abstract unicodeRange: U2<float, string> option with get, set
        abstract unitsPerEm: U2<float, string> option with get, set
        abstract vAlphabetic: U2<float, string> option with get, set
        abstract values: string option with get, set
        abstract vectorEffect: U2<float, string> option with get, set
        abstract version: string option with get, set
        abstract vertAdvY: U2<float, string> option with get, set
        abstract vertOriginX: U2<float, string> option with get, set
        abstract vertOriginY: U2<float, string> option with get, set
        abstract vHanging: U2<float, string> option with get, set
        abstract vIdeographic: U2<float, string> option with get, set
        abstract viewBox: string option with get, set
        abstract viewTarget: U2<float, string> option with get, set
        abstract visibility: U2<float, string> option with get, set
        abstract vMathematical: U2<float, string> option with get, set
        abstract widths: U2<float, string> option with get, set
        abstract wordSpacing: U2<float, string> option with get, set
        abstract writingMode: U2<float, string> option with get, set
        abstract x1: U2<float, string> option with get, set
        abstract x2: U2<float, string> option with get, set
        abstract x: U2<float, string> option with get, set
        abstract xChannelSelector: string option with get, set
        abstract xHeight: U2<float, string> option with get, set
        abstract xlinkActuate: string option with get, set
        abstract xlinkArcrole: string option with get, set
        abstract xlinkHref: string option with get, set
        abstract xlinkRole: string option with get, set
        abstract xlinkShow: string option with get, set
        abstract xlinkTitle: string option with get, set
        abstract xlinkType: string option with get, set
        abstract xmlBase: string option with get, set
        abstract xmlLang: string option with get, set
        abstract xmlns: string option with get, set
        abstract xmlnsXlink: string option with get, set
        abstract xmlSpace: string option with get, set
        abstract y1: U2<float, string> option with get, set
        abstract y2: U2<float, string> option with get, set
        abstract y: U2<float, string> option with get, set
        abstract yChannelSelector: string option with get, set
        abstract z: U2<float, string> option with get, set
        abstract zoomAndPan: string option with get, set

    type [<AllowNullLiteral>] ReactHTML =
        abstract a: DetailedHTMLFactory<AnchorHTMLAttributes<HTMLAnchorElement>, HTMLAnchorElement> with get, set
        abstract abbr: DetailedHTMLFactory<HTMLAttributes<HTMLElement>, HTMLElement> with get, set
        abstract address: DetailedHTMLFactory<HTMLAttributes<HTMLElement>, HTMLElement> with get, set
        abstract area: DetailedHTMLFactory<AreaHTMLAttributes<HTMLAreaElement>, HTMLAreaElement> with get, set
        abstract article: DetailedHTMLFactory<HTMLAttributes<HTMLElement>, HTMLElement> with get, set
        abstract aside: DetailedHTMLFactory<HTMLAttributes<HTMLElement>, HTMLElement> with get, set
        abstract audio: DetailedHTMLFactory<AudioHTMLAttributes<HTMLAudioElement>, HTMLAudioElement> with get, set
        abstract b: DetailedHTMLFactory<HTMLAttributes<HTMLElement>, HTMLElement> with get, set
        abstract ``base``: DetailedHTMLFactory<BaseHTMLAttributes<HTMLBaseElement>, HTMLBaseElement> with get, set
        abstract bdi: DetailedHTMLFactory<HTMLAttributes<HTMLElement>, HTMLElement> with get, set
        abstract bdo: DetailedHTMLFactory<HTMLAttributes<HTMLElement>, HTMLElement> with get, set
        abstract big: DetailedHTMLFactory<HTMLAttributes<HTMLElement>, HTMLElement> with get, set
        abstract blockquote: DetailedHTMLFactory<BlockquoteHTMLAttributes<HTMLElement>, HTMLElement> with get, set
        abstract body: DetailedHTMLFactory<HTMLAttributes<HTMLBodyElement>, HTMLBodyElement> with get, set
        abstract br: DetailedHTMLFactory<HTMLAttributes<HTMLBRElement>, HTMLBRElement> with get, set
        abstract button: DetailedHTMLFactory<ButtonHTMLAttributes<HTMLButtonElement>, HTMLButtonElement> with get, set
        abstract canvas: DetailedHTMLFactory<CanvasHTMLAttributes<HTMLCanvasElement>, HTMLCanvasElement> with get, set
        abstract caption: DetailedHTMLFactory<HTMLAttributes<HTMLElement>, HTMLElement> with get, set
        abstract cite: DetailedHTMLFactory<HTMLAttributes<HTMLElement>, HTMLElement> with get, set
        abstract code: DetailedHTMLFactory<HTMLAttributes<HTMLElement>, HTMLElement> with get, set
        abstract col: DetailedHTMLFactory<ColHTMLAttributes<HTMLTableColElement>, HTMLTableColElement> with get, set
        abstract colgroup: DetailedHTMLFactory<ColgroupHTMLAttributes<HTMLTableColElement>, HTMLTableColElement> with get, set
        abstract data: DetailedHTMLFactory<HTMLAttributes<HTMLElement>, HTMLElement> with get, set
        abstract datalist: DetailedHTMLFactory<HTMLAttributes<HTMLDataListElement>, HTMLDataListElement> with get, set
        abstract dd: DetailedHTMLFactory<HTMLAttributes<HTMLElement>, HTMLElement> with get, set
        abstract del: DetailedHTMLFactory<DelHTMLAttributes<HTMLElement>, HTMLElement> with get, set
        abstract details: DetailedHTMLFactory<DetailsHTMLAttributes<HTMLElement>, HTMLElement> with get, set
        abstract dfn: DetailedHTMLFactory<HTMLAttributes<HTMLElement>, HTMLElement> with get, set
        abstract dialog: DetailedHTMLFactory<HTMLAttributes<HTMLElement>, HTMLElement> with get, set
        abstract div: DetailedHTMLFactory<HTMLAttributes<HTMLDivElement>, HTMLDivElement> with get, set
        abstract dl: DetailedHTMLFactory<HTMLAttributes<HTMLDListElement>, HTMLDListElement> with get, set
        abstract dt: DetailedHTMLFactory<HTMLAttributes<HTMLElement>, HTMLElement> with get, set
        abstract em: DetailedHTMLFactory<HTMLAttributes<HTMLElement>, HTMLElement> with get, set
        abstract embed: DetailedHTMLFactory<EmbedHTMLAttributes<HTMLEmbedElement>, HTMLEmbedElement> with get, set
        abstract fieldset: DetailedHTMLFactory<FieldsetHTMLAttributes<HTMLFieldSetElement>, HTMLFieldSetElement> with get, set
        abstract figcaption: DetailedHTMLFactory<HTMLAttributes<HTMLElement>, HTMLElement> with get, set
        abstract figure: DetailedHTMLFactory<HTMLAttributes<HTMLElement>, HTMLElement> with get, set
        abstract footer: DetailedHTMLFactory<HTMLAttributes<HTMLElement>, HTMLElement> with get, set
        abstract form: DetailedHTMLFactory<FormHTMLAttributes<HTMLFormElement>, HTMLFormElement> with get, set
        abstract h1: DetailedHTMLFactory<HTMLAttributes<HTMLHeadingElement>, HTMLHeadingElement> with get, set
        abstract h2: DetailedHTMLFactory<HTMLAttributes<HTMLHeadingElement>, HTMLHeadingElement> with get, set
        abstract h3: DetailedHTMLFactory<HTMLAttributes<HTMLHeadingElement>, HTMLHeadingElement> with get, set
        abstract h4: DetailedHTMLFactory<HTMLAttributes<HTMLHeadingElement>, HTMLHeadingElement> with get, set
        abstract h5: DetailedHTMLFactory<HTMLAttributes<HTMLHeadingElement>, HTMLHeadingElement> with get, set
        abstract h6: DetailedHTMLFactory<HTMLAttributes<HTMLHeadingElement>, HTMLHeadingElement> with get, set
        abstract head: DetailedHTMLFactory<HTMLAttributes<HTMLElement>, HTMLHeadElement> with get, set
        abstract header: DetailedHTMLFactory<HTMLAttributes<HTMLElement>, HTMLElement> with get, set
        abstract hgroup: DetailedHTMLFactory<HTMLAttributes<HTMLElement>, HTMLElement> with get, set
        abstract hr: DetailedHTMLFactory<HTMLAttributes<HTMLHRElement>, HTMLHRElement> with get, set
        abstract html: DetailedHTMLFactory<HtmlHTMLAttributes<HTMLHtmlElement>, HTMLHtmlElement> with get, set
        abstract i: DetailedHTMLFactory<HTMLAttributes<HTMLElement>, HTMLElement> with get, set
        abstract iframe: DetailedHTMLFactory<IframeHTMLAttributes<HTMLIFrameElement>, HTMLIFrameElement> with get, set
        abstract img: DetailedHTMLFactory<ImgHTMLAttributes<HTMLImageElement>, HTMLImageElement> with get, set
        abstract input: DetailedHTMLFactory<InputHTMLAttributes<HTMLInputElement>, HTMLInputElement> with get, set
        abstract ins: DetailedHTMLFactory<InsHTMLAttributes<HTMLModElement>, HTMLModElement> with get, set
        abstract kbd: DetailedHTMLFactory<HTMLAttributes<HTMLElement>, HTMLElement> with get, set
        abstract keygen: DetailedHTMLFactory<KeygenHTMLAttributes<HTMLElement>, HTMLElement> with get, set
        abstract label: DetailedHTMLFactory<LabelHTMLAttributes<HTMLLabelElement>, HTMLLabelElement> with get, set
        abstract legend: DetailedHTMLFactory<HTMLAttributes<HTMLLegendElement>, HTMLLegendElement> with get, set
        abstract li: DetailedHTMLFactory<LiHTMLAttributes<HTMLLIElement>, HTMLLIElement> with get, set
        abstract link: DetailedHTMLFactory<LinkHTMLAttributes<HTMLLinkElement>, HTMLLinkElement> with get, set
        abstract main: DetailedHTMLFactory<HTMLAttributes<HTMLElement>, HTMLElement> with get, set
        abstract map: DetailedHTMLFactory<MapHTMLAttributes<HTMLMapElement>, HTMLMapElement> with get, set
        abstract mark: DetailedHTMLFactory<HTMLAttributes<HTMLElement>, HTMLElement> with get, set
        abstract menu: DetailedHTMLFactory<MenuHTMLAttributes<HTMLElement>, HTMLElement> with get, set
        abstract menuitem: DetailedHTMLFactory<HTMLAttributes<HTMLElement>, HTMLElement> with get, set
        abstract meta: DetailedHTMLFactory<MetaHTMLAttributes<HTMLMetaElement>, HTMLMetaElement> with get, set
        abstract meter: DetailedHTMLFactory<MeterHTMLAttributes<HTMLElement>, HTMLElement> with get, set
        abstract nav: DetailedHTMLFactory<HTMLAttributes<HTMLElement>, HTMLElement> with get, set
        abstract noscript: DetailedHTMLFactory<HTMLAttributes<HTMLElement>, HTMLElement> with get, set
        abstract ``object``: DetailedHTMLFactory<ObjectHTMLAttributes<HTMLObjectElement>, HTMLObjectElement> with get, set
        abstract ol: DetailedHTMLFactory<OlHTMLAttributes<HTMLOListElement>, HTMLOListElement> with get, set
        abstract optgroup: DetailedHTMLFactory<OptgroupHTMLAttributes<HTMLOptGroupElement>, HTMLOptGroupElement> with get, set
        abstract option: DetailedHTMLFactory<OptionHTMLAttributes<HTMLOptionElement>, HTMLOptionElement> with get, set
        abstract output: DetailedHTMLFactory<OutputHTMLAttributes<HTMLElement>, HTMLElement> with get, set
        abstract p: DetailedHTMLFactory<HTMLAttributes<HTMLParagraphElement>, HTMLParagraphElement> with get, set
        abstract param: DetailedHTMLFactory<ParamHTMLAttributes<HTMLParamElement>, HTMLParamElement> with get, set
        abstract picture: DetailedHTMLFactory<HTMLAttributes<HTMLElement>, HTMLElement> with get, set
        abstract pre: DetailedHTMLFactory<HTMLAttributes<HTMLPreElement>, HTMLPreElement> with get, set
        abstract progress: DetailedHTMLFactory<ProgressHTMLAttributes<HTMLProgressElement>, HTMLProgressElement> with get, set
        abstract q: DetailedHTMLFactory<QuoteHTMLAttributes<HTMLQuoteElement>, HTMLQuoteElement> with get, set
        abstract rp: DetailedHTMLFactory<HTMLAttributes<HTMLElement>, HTMLElement> with get, set
        abstract rt: DetailedHTMLFactory<HTMLAttributes<HTMLElement>, HTMLElement> with get, set
        abstract ruby: DetailedHTMLFactory<HTMLAttributes<HTMLElement>, HTMLElement> with get, set
        abstract s: DetailedHTMLFactory<HTMLAttributes<HTMLElement>, HTMLElement> with get, set
        abstract samp: DetailedHTMLFactory<HTMLAttributes<HTMLElement>, HTMLElement> with get, set
        abstract script: DetailedHTMLFactory<ScriptHTMLAttributes<HTMLScriptElement>, HTMLScriptElement> with get, set
        abstract section: DetailedHTMLFactory<HTMLAttributes<HTMLElement>, HTMLElement> with get, set
        abstract select: DetailedHTMLFactory<SelectHTMLAttributes<HTMLSelectElement>, HTMLSelectElement> with get, set
        abstract small: DetailedHTMLFactory<HTMLAttributes<HTMLElement>, HTMLElement> with get, set
        abstract source: DetailedHTMLFactory<SourceHTMLAttributes<HTMLSourceElement>, HTMLSourceElement> with get, set
        abstract span: DetailedHTMLFactory<HTMLAttributes<HTMLSpanElement>, HTMLSpanElement> with get, set
        abstract strong: DetailedHTMLFactory<HTMLAttributes<HTMLElement>, HTMLElement> with get, set
        abstract style: DetailedHTMLFactory<StyleHTMLAttributes<HTMLStyleElement>, HTMLStyleElement> with get, set
        abstract sub: DetailedHTMLFactory<HTMLAttributes<HTMLElement>, HTMLElement> with get, set
        abstract summary: DetailedHTMLFactory<HTMLAttributes<HTMLElement>, HTMLElement> with get, set
        abstract sup: DetailedHTMLFactory<HTMLAttributes<HTMLElement>, HTMLElement> with get, set
        abstract table: DetailedHTMLFactory<TableHTMLAttributes<HTMLTableElement>, HTMLTableElement> with get, set
        abstract tbody: DetailedHTMLFactory<HTMLAttributes<HTMLTableSectionElement>, HTMLTableSectionElement> with get, set
        abstract td: DetailedHTMLFactory<TdHTMLAttributes<HTMLTableDataCellElement>, HTMLTableDataCellElement> with get, set
        abstract textarea: DetailedHTMLFactory<TextareaHTMLAttributes<HTMLTextAreaElement>, HTMLTextAreaElement> with get, set
        abstract tfoot: DetailedHTMLFactory<HTMLAttributes<HTMLTableSectionElement>, HTMLTableSectionElement> with get, set
        abstract th: DetailedHTMLFactory<ThHTMLAttributes<HTMLTableHeaderCellElement>, HTMLTableHeaderCellElement> with get, set
        abstract thead: DetailedHTMLFactory<HTMLAttributes<HTMLTableSectionElement>, HTMLTableSectionElement> with get, set
        abstract time: DetailedHTMLFactory<TimeHTMLAttributes<HTMLElement>, HTMLElement> with get, set
        abstract title: DetailedHTMLFactory<HTMLAttributes<HTMLTitleElement>, HTMLTitleElement> with get, set
        abstract tr: DetailedHTMLFactory<HTMLAttributes<HTMLTableRowElement>, HTMLTableRowElement> with get, set
        abstract track: DetailedHTMLFactory<TrackHTMLAttributes<HTMLTrackElement>, HTMLTrackElement> with get, set
        abstract u: DetailedHTMLFactory<HTMLAttributes<HTMLElement>, HTMLElement> with get, set
        abstract ul: DetailedHTMLFactory<HTMLAttributes<HTMLUListElement>, HTMLUListElement> with get, set
        abstract var: DetailedHTMLFactory<HTMLAttributes<HTMLElement>, HTMLElement> with get, set
        abstract video: DetailedHTMLFactory<VideoHTMLAttributes<HTMLVideoElement>, HTMLVideoElement> with get, set
        abstract wbr: DetailedHTMLFactory<HTMLAttributes<HTMLElement>, HTMLElement> with get, set

    type [<AllowNullLiteral>] ReactSVG =
        abstract svg: SVGFactory with get, set
        abstract animate: SVGFactory with get, set
        abstract circle: SVGFactory with get, set
        abstract defs: SVGFactory with get, set
        abstract ellipse: SVGFactory with get, set
        abstract g: SVGFactory with get, set
        abstract image: SVGFactory with get, set
        abstract line: SVGFactory with get, set
        abstract linearGradient: SVGFactory with get, set
        abstract mask: SVGFactory with get, set
        abstract path: SVGFactory with get, set
        abstract pattern: SVGFactory with get, set
        abstract polygon: SVGFactory with get, set
        abstract polyline: SVGFactory with get, set
        abstract radialGradient: SVGFactory with get, set
        abstract rect: SVGFactory with get, set
        abstract stop: SVGFactory with get, set
        abstract symbol: SVGFactory with get, set
        abstract text: SVGFactory with get, set
        abstract tspan: SVGFactory with get, set
        abstract ``use``: SVGFactory with get, set

    type [<AllowNullLiteral>] ReactDOM =
        inherit ReactHTML
        inherit ReactSVG

    type [<AllowNullLiteral>] Validator<'T> =
        [<Emit "$0($1...)">] abstract Invoke: ``object``: 'T * key: string * componentName: string * [<ParamArray>] rest: obj option[] -> Error option

    type [<AllowNullLiteral>] Requireable<'T> =
        inherit Validator<'T>
        abstract isRequired: Validator<'T> with get, set

    type [<AllowNullLiteral>] ValidationMap<'T> =
        interface end

    type [<AllowNullLiteral>] ReactPropTypes =
        abstract any: Requireable<obj option> with get, set
        abstract array: Requireable<obj option> with get, set
        abstract bool: Requireable<obj option> with get, set
        abstract func: Requireable<obj option> with get, set
        abstract number: Requireable<obj option> with get, set
        abstract ``object``: Requireable<obj option> with get, set
        abstract string: Requireable<obj option> with get, set
        abstract node: Requireable<obj option> with get, set
        abstract element: Requireable<obj option> with get, set
        abstract instanceOf: expectedClass: ReactPropTypesInstanceOfExpectedClass -> Requireable<obj option>
        abstract oneOf: types: ResizeArray<obj option> -> Requireable<obj option>
        abstract oneOfType: types: Array<Validator<obj option>> -> Requireable<obj option>
        abstract arrayOf: ``type``: Validator<obj option> -> Requireable<obj option>
        abstract objectOf: ``type``: Validator<obj option> -> Requireable<obj option>
        abstract shape: ``type``: ValidationMap<obj option> -> Requireable<obj option>

    type [<AllowNullLiteral>] ReactPropTypesInstanceOfExpectedClass =
        interface end

    type [<AllowNullLiteral>] ReactChildren =
        abstract map: children: ReactNode * fn: (ReactChild -> float -> 'T) -> ResizeArray<'T>
        abstract forEach: children: ReactNode * fn: (ReactChild -> float -> obj option) -> unit
        abstract count: children: ReactNode -> float
        abstract only: children: ReactNode -> ReactElement<obj option>
        abstract toArray: children: ReactNode -> ResizeArray<ReactChild>

    type [<AllowNullLiteral>] AbstractView =
        abstract styleMedia: StyleMedia with get, set
        abstract document: Document with get, set

    type [<AllowNullLiteral>] Touch =
        abstract identifier: float with get, set
        abstract target: EventTarget with get, set
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

    type [<AllowNullLiteral>] ErrorInfo =
        /// Captures which component contained the exception, and it's ancestors.
        abstract componentStack: string with get, set

    type [<AllowNullLiteral>] IExportsCreateElement_inputDetailedReactHTMLElement =
        interface end

    type [<AllowNullLiteral>] ComponentRefs =
        [<Emit "$0[$1]{{=$2}}">] abstract Item: key: string -> ReactInstance with get, set

    type [<AllowNullLiteral>] MixinStatics =
        [<Emit "$0[$1]{{=$2}}">] abstract Item: key: string -> obj option with get, set

    type [<AllowNullLiteral>] DOMAttributesDangerouslySetInnerHTML =
        abstract __html: string with get, set

    type [<StringEnum>] [<RequireQualifiedAccess>] SVGAttributesAccumulate =
        | None
        | Sum

    type [<StringEnum>] [<RequireQualifiedAccess>] SVGAttributesAdditive =
        | Replace
        | Sum

    type [<StringEnum>] [<RequireQualifiedAccess>] SVGAttributesAlignmentBaseline =
        | Auto
        | Baseline
        | [<CompiledName "before-edge">] BeforeEdge
        | [<CompiledName "text-before-edge">] TextBeforeEdge
        | Middle
        | Central
        | [<CompiledName "after-edge">] AfterEdge
        | [<CompiledName "text-after-edge">] TextAfterEdge
        | Ideographic
        | Alphabetic
        | Hanging
        | Mathematical
        | Inherit

    type [<StringEnum>] [<RequireQualifiedAccess>] SVGAttributesAllowReorder =
        | No
        | Yes

    type [<StringEnum>] [<RequireQualifiedAccess>] SVGAttributesArabicForm =
        | Initial
        | Medial
        | Terminal
        | Isolated

    type [<StringEnum>] [<RequireQualifiedAccess>] SVGAttributesColorInterpolationFilters =
        | Auto
        | SRGB
        | LinearRGB
        | Inherit

    type [<StringEnum>] [<RequireQualifiedAccess>] SVGAttributesFillRule =
        | Nonzero
        | Evenodd
        | Inherit

    type [<StringEnum>] [<RequireQualifiedAccess>] SVGAttributesStrokeLinecap =
        | Butt
        | Round
        | Square
        | Inherit

    type [<StringEnum>] [<RequireQualifiedAccess>] SVGAttributesStrokeLinejoin =
        | Miter
        | Round
        | Bevel
        | Inherit

module JSX =

    type [<AllowNullLiteral>] Element =
        inherit React.ReactElement<obj option>

    type [<AllowNullLiteral>] ElementClass =
        inherit React.Component<obj option>
        abstract render: unit -> Element option

    type [<AllowNullLiteral>] ElementAttributesProperty =
        abstract props: ElementAttributesPropertyProps with get, set

    type [<AllowNullLiteral>] ElementChildrenAttribute =
        abstract children: ElementAttributesPropertyProps with get, set

    type [<AllowNullLiteral>] IntrinsicAttributes =
        inherit React.Attributes

    type [<AllowNullLiteral>] IntrinsicClassAttributes<'T> =
        inherit React.ClassAttributes<'T>

    type [<AllowNullLiteral>] IntrinsicElements =
        abstract a: React.DetailedHTMLProps<React.AnchorHTMLAttributes<HTMLAnchorElement>, HTMLAnchorElement> with get, set
        abstract abbr: React.DetailedHTMLProps<React.HTMLAttributes<HTMLElement>, HTMLElement> with get, set
        abstract address: React.DetailedHTMLProps<React.HTMLAttributes<HTMLElement>, HTMLElement> with get, set
        abstract area: React.DetailedHTMLProps<React.AreaHTMLAttributes<HTMLAreaElement>, HTMLAreaElement> with get, set
        abstract article: React.DetailedHTMLProps<React.HTMLAttributes<HTMLElement>, HTMLElement> with get, set
        abstract aside: React.DetailedHTMLProps<React.HTMLAttributes<HTMLElement>, HTMLElement> with get, set
        abstract audio: React.DetailedHTMLProps<React.AudioHTMLAttributes<HTMLAudioElement>, HTMLAudioElement> with get, set
        abstract b: React.DetailedHTMLProps<React.HTMLAttributes<HTMLElement>, HTMLElement> with get, set
        abstract ``base``: React.DetailedHTMLProps<React.BaseHTMLAttributes<HTMLBaseElement>, HTMLBaseElement> with get, set
        abstract bdi: React.DetailedHTMLProps<React.HTMLAttributes<HTMLElement>, HTMLElement> with get, set
        abstract bdo: React.DetailedHTMLProps<React.HTMLAttributes<HTMLElement>, HTMLElement> with get, set
        abstract big: React.DetailedHTMLProps<React.HTMLAttributes<HTMLElement>, HTMLElement> with get, set
        abstract blockquote: React.DetailedHTMLProps<React.BlockquoteHTMLAttributes<HTMLElement>, HTMLElement> with get, set
        abstract body: React.DetailedHTMLProps<React.HTMLAttributes<HTMLBodyElement>, HTMLBodyElement> with get, set
        abstract br: React.DetailedHTMLProps<React.HTMLAttributes<HTMLBRElement>, HTMLBRElement> with get, set
        abstract button: React.DetailedHTMLProps<React.ButtonHTMLAttributes<HTMLButtonElement>, HTMLButtonElement> with get, set
        abstract canvas: React.DetailedHTMLProps<React.CanvasHTMLAttributes<HTMLCanvasElement>, HTMLCanvasElement> with get, set
        abstract caption: React.DetailedHTMLProps<React.HTMLAttributes<HTMLElement>, HTMLElement> with get, set
        abstract cite: React.DetailedHTMLProps<React.HTMLAttributes<HTMLElement>, HTMLElement> with get, set
        abstract code: React.DetailedHTMLProps<React.HTMLAttributes<HTMLElement>, HTMLElement> with get, set
        abstract col: React.DetailedHTMLProps<React.ColHTMLAttributes<HTMLTableColElement>, HTMLTableColElement> with get, set
        abstract colgroup: React.DetailedHTMLProps<React.ColgroupHTMLAttributes<HTMLTableColElement>, HTMLTableColElement> with get, set
        abstract data: React.DetailedHTMLProps<React.HTMLAttributes<HTMLElement>, HTMLElement> with get, set
        abstract datalist: React.DetailedHTMLProps<React.HTMLAttributes<HTMLDataListElement>, HTMLDataListElement> with get, set
        abstract dd: React.DetailedHTMLProps<React.HTMLAttributes<HTMLElement>, HTMLElement> with get, set
        abstract del: React.DetailedHTMLProps<React.DelHTMLAttributes<HTMLElement>, HTMLElement> with get, set
        abstract details: React.DetailedHTMLProps<React.DetailsHTMLAttributes<HTMLElement>, HTMLElement> with get, set
        abstract dfn: React.DetailedHTMLProps<React.HTMLAttributes<HTMLElement>, HTMLElement> with get, set
        abstract dialog: React.DetailedHTMLProps<React.HTMLAttributes<HTMLElement>, HTMLElement> with get, set
        abstract div: React.DetailedHTMLProps<React.HTMLAttributes<HTMLDivElement>, HTMLDivElement> with get, set
        abstract dl: React.DetailedHTMLProps<React.HTMLAttributes<HTMLDListElement>, HTMLDListElement> with get, set
        abstract dt: React.DetailedHTMLProps<React.HTMLAttributes<HTMLElement>, HTMLElement> with get, set
        abstract em: React.DetailedHTMLProps<React.HTMLAttributes<HTMLElement>, HTMLElement> with get, set
        abstract embed: React.DetailedHTMLProps<React.EmbedHTMLAttributes<HTMLEmbedElement>, HTMLEmbedElement> with get, set
        abstract fieldset: React.DetailedHTMLProps<React.FieldsetHTMLAttributes<HTMLFieldSetElement>, HTMLFieldSetElement> with get, set
        abstract figcaption: React.DetailedHTMLProps<React.HTMLAttributes<HTMLElement>, HTMLElement> with get, set
        abstract figure: React.DetailedHTMLProps<React.HTMLAttributes<HTMLElement>, HTMLElement> with get, set
        abstract footer: React.DetailedHTMLProps<React.HTMLAttributes<HTMLElement>, HTMLElement> with get, set
        abstract form: React.DetailedHTMLProps<React.FormHTMLAttributes<HTMLFormElement>, HTMLFormElement> with get, set
        abstract h1: React.DetailedHTMLProps<React.HTMLAttributes<HTMLHeadingElement>, HTMLHeadingElement> with get, set
        abstract h2: React.DetailedHTMLProps<React.HTMLAttributes<HTMLHeadingElement>, HTMLHeadingElement> with get, set
        abstract h3: React.DetailedHTMLProps<React.HTMLAttributes<HTMLHeadingElement>, HTMLHeadingElement> with get, set
        abstract h4: React.DetailedHTMLProps<React.HTMLAttributes<HTMLHeadingElement>, HTMLHeadingElement> with get, set
        abstract h5: React.DetailedHTMLProps<React.HTMLAttributes<HTMLHeadingElement>, HTMLHeadingElement> with get, set
        abstract h6: React.DetailedHTMLProps<React.HTMLAttributes<HTMLHeadingElement>, HTMLHeadingElement> with get, set
        abstract head: React.DetailedHTMLProps<React.HTMLAttributes<HTMLHeadElement>, HTMLHeadElement> with get, set
        abstract header: React.DetailedHTMLProps<React.HTMLAttributes<HTMLElement>, HTMLElement> with get, set
        abstract hgroup: React.DetailedHTMLProps<React.HTMLAttributes<HTMLElement>, HTMLElement> with get, set
        abstract hr: React.DetailedHTMLProps<React.HTMLAttributes<HTMLHRElement>, HTMLHRElement> with get, set
        abstract html: React.DetailedHTMLProps<React.HtmlHTMLAttributes<HTMLHtmlElement>, HTMLHtmlElement> with get, set
        abstract i: React.DetailedHTMLProps<React.HTMLAttributes<HTMLElement>, HTMLElement> with get, set
        abstract iframe: React.DetailedHTMLProps<React.IframeHTMLAttributes<HTMLIFrameElement>, HTMLIFrameElement> with get, set
        abstract img: React.DetailedHTMLProps<React.ImgHTMLAttributes<HTMLImageElement>, HTMLImageElement> with get, set
        abstract input: React.DetailedHTMLProps<React.InputHTMLAttributes<HTMLInputElement>, HTMLInputElement> with get, set
        abstract ins: React.DetailedHTMLProps<React.InsHTMLAttributes<HTMLModElement>, HTMLModElement> with get, set
        abstract kbd: React.DetailedHTMLProps<React.HTMLAttributes<HTMLElement>, HTMLElement> with get, set
        abstract keygen: React.DetailedHTMLProps<React.KeygenHTMLAttributes<HTMLElement>, HTMLElement> with get, set
        abstract label: React.DetailedHTMLProps<React.LabelHTMLAttributes<HTMLLabelElement>, HTMLLabelElement> with get, set
        abstract legend: React.DetailedHTMLProps<React.HTMLAttributes<HTMLLegendElement>, HTMLLegendElement> with get, set
        abstract li: React.DetailedHTMLProps<React.LiHTMLAttributes<HTMLLIElement>, HTMLLIElement> with get, set
        abstract link: React.DetailedHTMLProps<React.LinkHTMLAttributes<HTMLLinkElement>, HTMLLinkElement> with get, set
        abstract main: React.DetailedHTMLProps<React.HTMLAttributes<HTMLElement>, HTMLElement> with get, set
        abstract map: React.DetailedHTMLProps<React.MapHTMLAttributes<HTMLMapElement>, HTMLMapElement> with get, set
        abstract mark: React.DetailedHTMLProps<React.HTMLAttributes<HTMLElement>, HTMLElement> with get, set
        abstract menu: React.DetailedHTMLProps<React.MenuHTMLAttributes<HTMLElement>, HTMLElement> with get, set
        abstract menuitem: React.DetailedHTMLProps<React.HTMLAttributes<HTMLElement>, HTMLElement> with get, set
        abstract meta: React.DetailedHTMLProps<React.MetaHTMLAttributes<HTMLMetaElement>, HTMLMetaElement> with get, set
        abstract meter: React.DetailedHTMLProps<React.MeterHTMLAttributes<HTMLElement>, HTMLElement> with get, set
        abstract nav: React.DetailedHTMLProps<React.HTMLAttributes<HTMLElement>, HTMLElement> with get, set
        abstract noindex: React.DetailedHTMLProps<React.HTMLAttributes<HTMLElement>, HTMLElement> with get, set
        abstract noscript: React.DetailedHTMLProps<React.HTMLAttributes<HTMLElement>, HTMLElement> with get, set
        abstract ``object``: React.DetailedHTMLProps<React.ObjectHTMLAttributes<HTMLObjectElement>, HTMLObjectElement> with get, set
        abstract ol: React.DetailedHTMLProps<React.OlHTMLAttributes<HTMLOListElement>, HTMLOListElement> with get, set
        abstract optgroup: React.DetailedHTMLProps<React.OptgroupHTMLAttributes<HTMLOptGroupElement>, HTMLOptGroupElement> with get, set
        abstract option: React.DetailedHTMLProps<React.OptionHTMLAttributes<HTMLOptionElement>, HTMLOptionElement> with get, set
        abstract output: React.DetailedHTMLProps<React.OutputHTMLAttributes<HTMLElement>, HTMLElement> with get, set
        abstract p: React.DetailedHTMLProps<React.HTMLAttributes<HTMLParagraphElement>, HTMLParagraphElement> with get, set
        abstract param: React.DetailedHTMLProps<React.ParamHTMLAttributes<HTMLParamElement>, HTMLParamElement> with get, set
        abstract picture: React.DetailedHTMLProps<React.HTMLAttributes<HTMLElement>, HTMLElement> with get, set
        abstract pre: React.DetailedHTMLProps<React.HTMLAttributes<HTMLPreElement>, HTMLPreElement> with get, set
        abstract progress: React.DetailedHTMLProps<React.ProgressHTMLAttributes<HTMLProgressElement>, HTMLProgressElement> with get, set
        abstract q: React.DetailedHTMLProps<React.QuoteHTMLAttributes<HTMLQuoteElement>, HTMLQuoteElement> with get, set
        abstract rp: React.DetailedHTMLProps<React.HTMLAttributes<HTMLElement>, HTMLElement> with get, set
        abstract rt: React.DetailedHTMLProps<React.HTMLAttributes<HTMLElement>, HTMLElement> with get, set
        abstract ruby: React.DetailedHTMLProps<React.HTMLAttributes<HTMLElement>, HTMLElement> with get, set
        abstract s: React.DetailedHTMLProps<React.HTMLAttributes<HTMLElement>, HTMLElement> with get, set
        abstract samp: React.DetailedHTMLProps<React.HTMLAttributes<HTMLElement>, HTMLElement> with get, set
        abstract script: React.DetailedHTMLProps<React.ScriptHTMLAttributes<HTMLScriptElement>, HTMLScriptElement> with get, set
        abstract section: React.DetailedHTMLProps<React.HTMLAttributes<HTMLElement>, HTMLElement> with get, set
        abstract select: React.DetailedHTMLProps<React.SelectHTMLAttributes<HTMLSelectElement>, HTMLSelectElement> with get, set
        abstract small: React.DetailedHTMLProps<React.HTMLAttributes<HTMLElement>, HTMLElement> with get, set
        abstract source: React.DetailedHTMLProps<React.SourceHTMLAttributes<HTMLSourceElement>, HTMLSourceElement> with get, set
        abstract span: React.DetailedHTMLProps<React.HTMLAttributes<HTMLSpanElement>, HTMLSpanElement> with get, set
        abstract strong: React.DetailedHTMLProps<React.HTMLAttributes<HTMLElement>, HTMLElement> with get, set
        abstract style: React.DetailedHTMLProps<React.StyleHTMLAttributes<HTMLStyleElement>, HTMLStyleElement> with get, set
        abstract sub: React.DetailedHTMLProps<React.HTMLAttributes<HTMLElement>, HTMLElement> with get, set
        abstract summary: React.DetailedHTMLProps<React.HTMLAttributes<HTMLElement>, HTMLElement> with get, set
        abstract sup: React.DetailedHTMLProps<React.HTMLAttributes<HTMLElement>, HTMLElement> with get, set
        abstract table: React.DetailedHTMLProps<React.TableHTMLAttributes<HTMLTableElement>, HTMLTableElement> with get, set
        abstract tbody: React.DetailedHTMLProps<React.HTMLAttributes<HTMLTableSectionElement>, HTMLTableSectionElement> with get, set
        abstract td: React.DetailedHTMLProps<React.TdHTMLAttributes<HTMLTableDataCellElement>, HTMLTableDataCellElement> with get, set
        abstract textarea: React.DetailedHTMLProps<React.TextareaHTMLAttributes<HTMLTextAreaElement>, HTMLTextAreaElement> with get, set
        abstract tfoot: React.DetailedHTMLProps<React.HTMLAttributes<HTMLTableSectionElement>, HTMLTableSectionElement> with get, set
        abstract th: React.DetailedHTMLProps<React.ThHTMLAttributes<HTMLTableHeaderCellElement>, HTMLTableHeaderCellElement> with get, set
        abstract thead: React.DetailedHTMLProps<React.HTMLAttributes<HTMLTableSectionElement>, HTMLTableSectionElement> with get, set
        abstract time: React.DetailedHTMLProps<React.TimeHTMLAttributes<HTMLElement>, HTMLElement> with get, set
        abstract title: React.DetailedHTMLProps<React.HTMLAttributes<HTMLTitleElement>, HTMLTitleElement> with get, set
        abstract tr: React.DetailedHTMLProps<React.HTMLAttributes<HTMLTableRowElement>, HTMLTableRowElement> with get, set
        abstract track: React.DetailedHTMLProps<React.TrackHTMLAttributes<HTMLTrackElement>, HTMLTrackElement> with get, set
        abstract u: React.DetailedHTMLProps<React.HTMLAttributes<HTMLElement>, HTMLElement> with get, set
        abstract ul: React.DetailedHTMLProps<React.HTMLAttributes<HTMLUListElement>, HTMLUListElement> with get, set
        abstract var: React.DetailedHTMLProps<React.HTMLAttributes<HTMLElement>, HTMLElement> with get, set
        abstract video: React.DetailedHTMLProps<React.VideoHTMLAttributes<HTMLVideoElement>, HTMLVideoElement> with get, set
        abstract wbr: React.DetailedHTMLProps<React.HTMLAttributes<HTMLElement>, HTMLElement> with get, set
        abstract svg: React.SVGProps<SVGSVGElement> with get, set
        abstract animate: React.SVGProps<SVGElement> with get, set
        abstract animateTransform: React.SVGProps<SVGElement> with get, set
        abstract circle: React.SVGProps<SVGCircleElement> with get, set
        abstract clipPath: React.SVGProps<SVGClipPathElement> with get, set
        abstract defs: React.SVGProps<SVGDefsElement> with get, set
        abstract desc: React.SVGProps<SVGDescElement> with get, set
        abstract ellipse: React.SVGProps<SVGEllipseElement> with get, set
        abstract feBlend: React.SVGProps<SVGFEBlendElement> with get, set
        abstract feColorMatrix: React.SVGProps<SVGFEColorMatrixElement> with get, set
        abstract feComponentTransfer: React.SVGProps<SVGFEComponentTransferElement> with get, set
        abstract feComposite: React.SVGProps<SVGFECompositeElement> with get, set
        abstract feConvolveMatrix: React.SVGProps<SVGFEConvolveMatrixElement> with get, set
        abstract feDiffuseLighting: React.SVGProps<SVGFEDiffuseLightingElement> with get, set
        abstract feDisplacementMap: React.SVGProps<SVGFEDisplacementMapElement> with get, set
        abstract feDistantLight: React.SVGProps<SVGFEDistantLightElement> with get, set
        abstract feFlood: React.SVGProps<SVGFEFloodElement> with get, set
        abstract feFuncA: React.SVGProps<SVGFEFuncAElement> with get, set
        abstract feFuncB: React.SVGProps<SVGFEFuncBElement> with get, set
        abstract feFuncG: React.SVGProps<SVGFEFuncGElement> with get, set
        abstract feFuncR: React.SVGProps<SVGFEFuncRElement> with get, set
        abstract feGaussianBlur: React.SVGProps<SVGFEGaussianBlurElement> with get, set
        abstract feImage: React.SVGProps<SVGFEImageElement> with get, set
        abstract feMerge: React.SVGProps<SVGFEMergeElement> with get, set
        abstract feMergeNode: React.SVGProps<SVGFEMergeNodeElement> with get, set
        abstract feMorphology: React.SVGProps<SVGFEMorphologyElement> with get, set
        abstract feOffset: React.SVGProps<SVGFEOffsetElement> with get, set
        abstract fePointLight: React.SVGProps<SVGFEPointLightElement> with get, set
        abstract feSpecularLighting: React.SVGProps<SVGFESpecularLightingElement> with get, set
        abstract feSpotLight: React.SVGProps<SVGFESpotLightElement> with get, set
        abstract feTile: React.SVGProps<SVGFETileElement> with get, set
        abstract feTurbulence: React.SVGProps<SVGFETurbulenceElement> with get, set
        abstract filter: React.SVGProps<SVGFilterElement> with get, set
        abstract foreignObject: React.SVGProps<SVGForeignObjectElement> with get, set
        abstract g: React.SVGProps<SVGGElement> with get, set
        abstract image: React.SVGProps<SVGImageElement> with get, set
        abstract line: React.SVGProps<SVGLineElement> with get, set
        abstract linearGradient: React.SVGProps<SVGLinearGradientElement> with get, set
        abstract marker: React.SVGProps<SVGMarkerElement> with get, set
        abstract mask: React.SVGProps<SVGMaskElement> with get, set
        abstract metadata: React.SVGProps<SVGMetadataElement> with get, set
        abstract path: React.SVGProps<SVGPathElement> with get, set
        abstract pattern: React.SVGProps<SVGPatternElement> with get, set
        abstract polygon: React.SVGProps<SVGPolygonElement> with get, set
        abstract polyline: React.SVGProps<SVGPolylineElement> with get, set
        abstract radialGradient: React.SVGProps<SVGRadialGradientElement> with get, set
        abstract rect: React.SVGProps<SVGRectElement> with get, set
        abstract stop: React.SVGProps<SVGStopElement> with get, set
        abstract switch: React.SVGProps<SVGSwitchElement> with get, set
        abstract symbol: React.SVGProps<SVGSymbolElement> with get, set
        abstract text: React.SVGProps<SVGTextElement> with get, set
        abstract textPath: React.SVGProps<SVGTextPathElement> with get, set
        abstract tspan: React.SVGProps<SVGTSpanElement> with get, set
        abstract ``use``: React.SVGProps<SVGUseElement> with get, set
        abstract view: React.SVGProps<SVGViewElement> with get, set

    type [<AllowNullLiteral>] ElementAttributesPropertyProps =
        interface end

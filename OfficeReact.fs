// ts2fable 0.0.0
module rec OfficeReact
open System
open Fable.Core
open Fable.Import.JS
open Fable.Import.Browser


type [<AllowNullLiteral>] IExports =
    abstract Async: AsyncStatic

/// Bugs often appear in async code when stuff gets disposed, but async operations don't get canceled.
/// This Async helper class solves these issues by tying async code to the lifetime of a disposable object.
/// 
/// Usage: Anything class extending from BaseModel can access this helper via this.async. Otherwise create a
/// new instance of the class and remember to call dispose() during your code's dispose handler.
type [<AllowNullLiteral>] Async =
    abstract _timeoutIds: obj with get, set
    abstract _immediateIds: obj with get, set
    abstract _intervalIds: obj with get, set
    abstract _animationFrameIds: obj with get, set
    abstract _isDisposed: obj with get, set
    abstract _parent: obj with get, set
    abstract _onErrorHandler: obj with get, set
    abstract _noop: obj with get, set
    /// Dispose function, clears all async operations.
    abstract dispose: unit -> unit
    /// <summary>SetTimeout override, which will auto cancel the timeout during dispose.</summary>
    /// <param name="callback">- Callback to execute.</param>
    /// <param name="duration">- Duration in milliseconds.</param>
    abstract setTimeout: callback: (unit -> unit) * duration: float -> float
    /// <summary>Clears the timeout.</summary>
    /// <param name="id">- Id to cancel.</param>
    abstract clearTimeout: id: float -> unit
    /// <summary>SetImmediate override, which will auto cancel the immediate during dispose.</summary>
    /// <param name="callback">- Callback to execute.</param>
    abstract setImmediate: callback: (unit -> unit) -> float
    /// <summary>Clears the immediate.</summary>
    /// <param name="id">- Id to cancel.</param>
    abstract clearImmediate: id: float -> unit
    /// <summary>SetInterval override, which will auto cancel the timeout during dispose.</summary>
    /// <param name="callback">- Callback to execute.</param>
    /// <param name="duration">- Duration in milliseconds.</param>
    abstract setInterval: callback: (unit -> unit) * duration: float -> float
    /// <summary>Clears the interval.</summary>
    /// <param name="id">- Id to cancel.</param>
    abstract clearInterval: id: float -> unit
    /// <summary>Creates a function that, when executed, will only call the func function at most once per
    /// every wait milliseconds. Provide an options object to indicate that func should be invoked
    /// on the leading and/or trailing edge of the wait timeout. Subsequent calls to the throttled
    /// function will return the result of the last func call.
    /// 
    /// Note: If leading and trailing options are true func will be called on the trailing edge of
    /// the timeout only if the the throttled function is invoked more than once during the wait timeout.</summary>
    /// <param name="func">- The function to throttle.</param>
    /// <param name="wait">- The number of milliseconds to throttle executions to. Defaults to 0.</param>
    /// <param name="options">- The options object.</param>
    abstract throttle: func: 'T * ?wait: float * ?options: AsyncThrottleOptions -> U2<'T, (unit -> unit)>
    /// <summary>Creates a function that will delay the execution of func until after wait milliseconds have
    /// elapsed since the last time it was invoked. Provide an options object to indicate that func
    /// should be invoked on the leading and/or trailing edge of the wait timeout. Subsequent calls
    /// to the debounced function will return the result of the last func call.
    /// 
    /// Note: If leading and trailing options are true func will be called on the trailing edge of
    /// the timeout only if the the debounced function is invoked more than once during the wait
    /// timeout.</summary>
    /// <param name="func">- The function to debounce.</param>
    /// <param name="wait">- The number of milliseconds to delay.</param>
    /// <param name="options">- The options object.</param>
    abstract debounce: func: 'T * ?wait: float * ?options: AsyncDebounceOptions -> obj
    abstract requestAnimationFrame: callback: (unit -> unit) -> float
    abstract cancelAnimationFrame: id: float -> unit
    abstract _logError: e: obj option -> unit

type [<AllowNullLiteral>] AsyncThrottleOptions =
    abstract leading: bool option with get, set
    abstract trailing: bool option with get, set

type [<AllowNullLiteral>] AsyncDebounceOptions =
    abstract leading: bool option with get, set
    abstract maxWait: float option with get, set
    abstract trailing: bool option with get, set

/// Bugs often appear in async code when stuff gets disposed, but async operations don't get canceled.
/// This Async helper class solves these issues by tying async code to the lifetime of a disposable object.
/// 
/// Usage: Anything class extending from BaseModel can access this helper via this.async. Otherwise create a
/// new instance of the class and remember to call dispose() during your code's dispose handler.
type [<AllowNullLiteral>] AsyncStatic =
    [<Emit "new $0($1...)">] abstract Create: ?parent: obj * ?onError: (obj option -> unit) -> Async

type [<AllowNullLiteral>] ICancelable<'T> =
    abstract flush: (unit -> 'T) with get, set
    abstract cancel: (unit -> unit) with get, set
    abstract pending: (unit -> bool) with get, set

type [<AllowNullLiteral>] IExports =
    abstract AutoScroll: AutoScrollStatic

/// AutoScroll simply hooks up mouse events given a parent element, and scrolls the container
/// up/down depending on how close the mouse is to the top/bottom of the container.
/// 
/// Once you don't want autoscroll any more, just dispose the helper and it will unhook events.
type [<AllowNullLiteral>] AutoScroll =
    abstract _events: obj with get, set
    abstract _scrollableParent: obj with get, set
    abstract _scrollRect: obj with get, set
    abstract _scrollVelocity: obj with get, set
    abstract _timeoutId: obj with get, set
    abstract dispose: unit -> unit
    abstract _onMouseMove: ev: obj -> unit
    abstract _onTouchMove: ev: obj -> unit
    abstract _computeScrollVelocity: clientY: obj -> unit
    abstract _startScroll: unit -> unit
    abstract _incrementScroll: unit -> unit
    abstract _stopScroll: unit -> unit

/// AutoScroll simply hooks up mouse events given a parent element, and scrolls the container
/// up/down depending on how close the mouse is to the top/bottom of the container.
/// 
/// Once you don't want autoscroll any more, just dispose the helper and it will unhook events.
type [<AllowNullLiteral>] AutoScrollStatic =
    [<Emit "new $0($1...)">] abstract Create: element: HTMLElement -> AutoScroll

type [<AllowNullLiteral>] IExports =
    abstract EventGroup: EventGroupStatic

/// EventRecord interface.
type [<AllowNullLiteral>] IEventRecord =
    abstract target: obj option with get, set
    abstract eventName: string with get, set
    abstract parent: obj option with get, set
    abstract callback: (obj option -> unit) with get, set
    abstract elementCallback: (ResizeArray<obj option> -> unit) option with get, set
    abstract objectCallback: (obj option -> unit) option with get, set
    abstract useCapture: bool with get, set

/// EventRecordsByName interface.
type [<AllowNullLiteral>] IEventRecordsByName =
    [<Emit "$0[$1]{{=$2}}">] abstract Item: eventName: string -> IEventRecordList with get, set

/// EventRecordList interface.
type [<AllowNullLiteral>] IEventRecordList =
    [<Emit "$0[$1]{{=$2}}">] abstract Item: id: string -> U2<ResizeArray<IEventRecord>, float> with get, set
    abstract count: float with get, set

/// DeclaredEventsByName interface.
type [<AllowNullLiteral>] IDeclaredEventsByName =
    [<Emit "$0[$1]{{=$2}}">] abstract Item: eventName: string -> bool with get, set

/// An instance of EventGroup allows anything with a handle to it to trigger events on it.
/// If the target is an HTMLElement, the event will be attached to the element and can be
/// triggered as usual (like clicking for onclick).
/// The event can be triggered by calling EventGroup.raise() here. If the target is an
/// HTMLElement, the event gets raised and is handled by the browser. Otherwise, it gets
/// handled here in EventGroup, and the handler is called in the context of the parent
/// (which is passed in in the constructor).
type [<AllowNullLiteral>] EventGroup =
    abstract _uniqueId: obj with get, set
    abstract _parent: obj with get, set
    abstract _eventRecords: obj with get, set
    abstract _id: obj with get, set
    abstract _isDisposed: obj with get, set
    abstract dispose: unit -> unit
    /// On the target, attach a set of events, where the events object is a name to function mapping. 
    abstract onAll: target: obj option * events: EventGroupOnAllEvents * ?useCapture: bool -> unit
    /// On the target, attach an event whose handler will be called in the context of the parent
    /// of this instance of EventGroup.
    abstract on: target: obj option * eventName: string * callback: (obj option -> unit) * ?useCapture: bool -> unit
    abstract off: ?target: obj option * ?eventName: string * ?callback: (obj option -> unit) * ?useCapture: bool -> unit
    /// Trigger the given event in the context of this instance of EventGroup. 
    abstract raise: eventName: string * ?eventArgs: obj option * ?bubbleEvent: bool -> bool option
    /// Declare an event as being supported by this instance of EventGroup. 
    abstract declare: ``event``: U2<string, ResizeArray<string>> -> unit

type [<AllowNullLiteral>] EventGroupOnAllEvents =
    [<Emit "$0[$1]{{=$2}}">] abstract Item: key: string -> (obj option -> unit) with get, set

/// An instance of EventGroup allows anything with a handle to it to trigger events on it.
/// If the target is an HTMLElement, the event will be attached to the element and can be
/// triggered as usual (like clicking for onclick).
/// The event can be triggered by calling EventGroup.raise() here. If the target is an
/// HTMLElement, the event gets raised and is handled by the browser. Otherwise, it gets
/// handled here in EventGroup, and the handler is called in the context of the parent
/// (which is passed in in the constructor).
type [<AllowNullLiteral>] EventGroupStatic =
    /// For IE8, bubbleEvent is ignored here and must be dealt with by the handler.
    /// Events raised here by default have bubbling set to false and cancelable set to true.
    /// This applies also to built-in events being raised manually here on HTMLElements,
    /// which may lead to unexpected behavior if it differs from the defaults.
    abstract raise: target: obj option * eventName: string * ?eventArgs: obj option * ?bubbleEvent: bool -> bool option
    abstract isObserved: target: obj option * eventName: string -> bool
    /// Check to see if the target has declared support of the given event. 
    abstract isDeclared: target: obj option * eventName: string -> bool
    abstract stopPropagation: ``event``: obj option -> unit
    abstract _isElement: target: obj -> unit
    /// parent: the context in which events attached to non-HTMLElements are called 
    [<Emit "new $0($1...)">] abstract Create: parent: obj option -> EventGroup

/// Disposable interface.
type [<AllowNullLiteral>] IDisposable =
    abstract dispose: (unit -> unit) with get, set

type [<AllowNullLiteral>] IExports =
    /// <summary>Warns when a deprecated props are being used.</summary>
    /// <param name="componentName">- The name of the component being used.</param>
    /// <param name="props">- The props passed into the component.</param>
    /// <param name="deprecationMap">- The map of deprecations, where key is the prop name and the value is
    /// either null or a replacement prop name.</param>
    abstract warnDeprecations: componentName: string * props: 'P * deprecationMap: ISettingsMap<'P> -> unit
    /// <summary>Warns when two props which are mutually exclusive are both being used.</summary>
    /// <param name="componentName">- The name of the component being used.</param>
    /// <param name="props">- The props passed into the component.</param>
    /// <param name="exclusiveMap">- A map where the key is a parameter, and the value is the other parameter.</param>
    abstract warnMutuallyExclusive: componentName: string * props: 'P * exclusiveMap: ISettingsMap<'P> -> unit
    /// <summary>Warns when props are required if a condition is met.</summary>
    /// <param name="componentName">- The name of the component being used.</param>
    /// <param name="props">- The props passed into the component.</param>
    /// <param name="requiredProps">- The name of the props that are required when the condition is met.</param>
    /// <param name="conditionalPropName">- The name of the prop that the condition is based on.</param>
    /// <param name="condition">- Whether the condition is met.</param>
    abstract warnConditionallyRequiredProps: componentName: string * props: 'P * requiredProps: ResizeArray<string> * conditionalPropName: string * condition: bool -> unit
    /// <summary>Sends a warning to console, if the api is present.</summary>
    /// <param name="message">- Warning message.</param>
    abstract warn: message: string -> unit
    /// <summary>Configures the warning callback. Passing in undefined will reset it to use the default
    /// console.warn function.</summary>
    /// <param name="warningCallback">- Callback to override the generated warnings.</param>
    abstract setWarningCallback: ?warningCallback: (string -> unit) -> unit

type [<AllowNullLiteral>] ISettingsMap<'T> =
    interface end
type Async = __Async.Async
type EventGroup = __EventGroup.EventGroup
type IDisposable = __IDisposable.IDisposable
type ISettingsMap = __warn.ISettingsMap

type [<AllowNullLiteral>] IExports =
    abstract BaseComponent: BaseComponentStatic
    /// Simple constant function for returning null, used to render empty templates in JSX.
    abstract nullRender: unit -> JSX.Element option

type IBaseProps =
    IBaseProps<obj>

/// BaseProps interface.
type [<AllowNullLiteral>] IBaseProps<'T> =
    abstract componentRef: ('T option -> U2<unit, 'T>) option with get, set

type BaseComponent<'S> =
    BaseComponent<obj, 'S>

type BaseComponent =
    BaseComponent<obj, obj>

/// BaseComponent class, which provides basic helpers for all components.
type [<AllowNullLiteral>] BaseComponent<'P, 'S> =
    inherit React.Component<'P, 'S>
    abstract onError: (string -> obj option -> unit) with get, set
    /// Controls whether the componentRef prop will be resolved by this component instance. If you are
    /// implementing a passthrough (higher-order component), you would set this to false and pass through
    /// the props to the inner component, allowing it to resolve the componentRef.
    abstract _shouldUpdateComponentRef: bool with get, set
    abstract __async: obj with get, set
    abstract __events: obj with get, set
    abstract __disposables: obj with get, set
    abstract __resolves: obj with get, set
    abstract __className: obj with get, set
    /// When the component will receive props, make sure the componentRef is updated.
    abstract componentWillReceiveProps: newProps: obj * newContext: obj option -> unit
    /// When the component has mounted, update the componentRef.
    abstract componentDidMount: unit -> unit
    /// If we have disposables, dispose them automatically on unmount.
    abstract componentWillUnmount: unit -> unit
    /// Gets the object's class name.
    abstract className: string
    /// Allows subclasses to push things to this._disposables to be auto disposed.
    abstract _disposables: ResizeArray<IDisposable>
    /// Gets the async instance associated with the component, created on demand. The async instance gives
    /// subclasses a way to execute setTimeout/setInterval async calls safely, where the callbacks
    /// will be cleared/ignored automatically after unmounting. The helpers within the async object also
    /// preserve the this pointer so that you don't need to "bind" the callbacks.
    abstract _async: Async
    /// Gets the event group instance assocaited with the component, created on demand. The event instance
    /// provides on/off methods for listening to DOM (or regular javascript object) events. The event callbacks
    /// will be automatically disconnected after unmounting. The helpers within the events object also
    /// preserve the this reference so that you don't need to "bind" the callbacks.
    abstract _events: EventGroup
    /// <summary>Helper to return a memoized ref resolver function.</summary>
    /// <param name="refName">- Name of the member to assign the ref to.</param>
    abstract _resolveRef: refName: string -> (React.ReactNode -> React.ReactNode)
    /// Updates the componentRef (by calling it with "this" when necessary.)
    abstract _updateComponentRef: currentProps: IBaseProps option * ?newProps: IBaseProps -> unit
    /// <summary>Warns when a deprecated props are being used.</summary>
    /// <param name="deprecationMap">- The map of deprecations, where key is the prop name and the value is
    /// either null or a replacement prop name.</param>
    abstract _warnDeprecations: deprecationMap: ISettingsMap<'P> -> unit
    /// <summary>Warns when props which are mutually exclusive with each other are both used.</summary>
    /// <param name="mutuallyExclusiveMap">- The map of mutually exclusive props.</param>
    abstract _warnMutuallyExclusive: mutuallyExclusiveMap: ISettingsMap<'P> -> unit
    /// <summary>Warns when props are required if a condition is met.</summary>
    /// <param name="requiredProps">- The name of the props that are required when the condition is met.</param>
    /// <param name="conditionalPropName">- The name of the prop that the condition is based on.</param>
    /// <param name="condition">- Whether the condition is met.</param>
    abstract _warnConditionallyRequiredProps: requiredProps: ResizeArray<string> * conditionalPropName: string * condition: bool -> unit

/// BaseComponent class, which provides basic helpers for all components.
type [<AllowNullLiteral>] BaseComponentStatic =
    /// <summary>BaseComponent constructor</summary>
    /// <param name="props">- The props for the component.</param>
    /// <param name="context">- The context for the component.</param>
    [<Emit "new $0($1...)">] abstract Create: props: 'P * ?context: obj option -> BaseComponent<'P, 'S>
module PropTypes = Prop_types

type [<AllowNullLiteral>] IExports =
    abstract provideContext: contextTypes: PropTypes.ValidationMap<'TContext> * mapPropsToContext: ('TProps -> 'TContext) -> React.ComponentType<'TProps>

type [<AllowNullLiteral>] IExports =
    abstract Customizations: CustomizationsStatic

type [<AllowNullLiteral>] Settings =
    [<Emit "$0[$1]{{=$2}}">] abstract Item: key: string -> obj option with get, set

type [<AllowNullLiteral>] SettingsFunction =
    [<Emit "$0($1...)">] abstract Invoke: settings: Settings -> Settings

type [<AllowNullLiteral>] ICustomizations =
    abstract settings: Settings with get, set
    abstract scopedSettings: obj with get, set

type [<AllowNullLiteral>] Customizations =
    interface end

type [<AllowNullLiteral>] CustomizationsStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> Customizations
    abstract reset: unit -> unit
    abstract applySettings: settings: Settings -> unit
    abstract applyScopedSettings: scopeName: string * settings: Settings -> unit
    abstract getSettings: properties: ResizeArray<string> * ?scopeName: string * ?localSettings: ICustomizations -> obj option
    abstract observe: onChange: (unit -> unit) -> unit
    abstract unobserve: onChange: (unit -> unit) -> unit
    abstract _raiseChange: unit -> unit
module PropTypes = Prop_types
type BaseComponent = __BaseComponent.BaseComponent
type IBaseProps = __BaseComponent.IBaseProps
type ICustomizations = __Customizations.ICustomizations
type Settings = __Customizations.Settings
type SettingsFunction = __Customizations.SettingsFunction

type [<AllowNullLiteral>] IExports =
    abstract Customizer: CustomizerStatic

type [<AllowNullLiteral>] ICustomizerContext =
    abstract customizations: ICustomizations with get, set

type [<AllowNullLiteral>] ICustomizerProps =
    interface end

/// The Customizer component allows for default props to be mixed into components which
/// are decorated with the customizable() decorator. This enables injection scenarios like:
/// 
/// 1. render svg icons instead of the icon font within all buttons
/// 2. inject a custom theme object into a component
/// 
/// Props are provided via the settings prop which should be one of the following:
/// - A json map which contains 1 or more name/value pairs representing injectable props.
/// - A function that receives the current settings and returns the new ones that apply to the scope
type [<AllowNullLiteral>] Customizer =
    inherit BaseComponent<ICustomizerProps, ICustomizerContext>
    abstract contextTypes: obj with get, set
    abstract childContextTypes: obj with get, set
    abstract getChildContext: unit -> ICustomizerContext
    abstract componentWillReceiveProps: newProps: obj option * newContext: obj option -> unit
    abstract render: unit -> React.ReactElement<obj>
    abstract _getCustomizations: props: obj * context: obj -> unit

/// The Customizer component allows for default props to be mixed into components which
/// are decorated with the customizable() decorator. This enables injection scenarios like:
/// 
/// 1. render svg icons instead of the icon font within all buttons
/// 2. inject a custom theme object into a component
/// 
/// Props are provided via the settings prop which should be one of the following:
/// - A json map which contains 1 or more name/value pairs representing injectable props.
/// - A function that receives the current settings and returns the new ones that apply to the scope
type [<AllowNullLiteral>] CustomizerStatic =
    [<Emit "new $0($1...)">] abstract Create: props: ICustomizerProps * context: obj option -> Customizer

type [<AllowNullLiteral>] IExports =
    abstract DelayedRender: DelayedRenderStatic

/// DelayedRender component props.
type [<AllowNullLiteral>] IDelayedRenderProps =
    inherit React.Props<obj>
    /// Number of milliseconds to delay rendering children.
    abstract delay: float option with get, set

/// DelayedRender component state.
type [<AllowNullLiteral>] IDelayedRenderState =
    /// Whether the component is rendered or not.
    abstract isRendered: bool with get, set

/// Utility component for delaying the render of a child component after a given delay. This component
/// requires a single child component; don't pass in many components. Wrap multiple components in a DIV
/// if necessary.
type [<AllowNullLiteral>] DelayedRender =
    inherit React.Component<IDelayedRenderProps, IDelayedRenderState>
    abstract defaultProps: obj with get, set
    abstract _timeoutId: obj with get, set
    abstract componentDidMount: unit -> unit
    abstract componentWillUnmount: unit -> unit
    abstract render: unit -> React.ReactElement<obj> option

/// Utility component for delaying the render of a child component after a given delay. This component
/// requires a single child component; don't pass in many components. Wrap multiple components in a DIV
/// if necessary.
type [<AllowNullLiteral>] DelayedRenderStatic =
    [<Emit "new $0($1...)">] abstract Create: props: IDelayedRenderProps -> DelayedRender

type [<AllowNullLiteral>] IExports =
    abstract FabricPerformance: FabricPerformanceStatic

/// PerfData interface.
type [<AllowNullLiteral>] IPerfData =
    abstract duration: float with get, set
    abstract timeStamp: float with get, set

/// PerfMeasurement interface.
type [<AllowNullLiteral>] IPerfMeasurement =
    abstract totalDuration: float with get, set
    abstract count: float with get, set
    abstract all: ResizeArray<IPerfData> with get, set

/// PerfSummary interface.
type [<AllowNullLiteral>] IPerfSummary =
    [<Emit "$0[$1]{{=$2}}">] abstract Item: key: string -> IPerfMeasurement with get, set

/// Performance helper class for measuring things.
type [<AllowNullLiteral>] FabricPerformance =
    abstract summary: IPerfSummary with get, set
    abstract _timeoutId: obj with get, set

/// Performance helper class for measuring things.
type [<AllowNullLiteral>] FabricPerformanceStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> FabricPerformance
    /// <summary>Measures execution time of the given syncronous function. If the same logic is executed multiple times,
    /// each individual measurement will be collected as well the overall numbers.</summary>
    /// <param name="name">- The name of this measurement</param>
    /// <param name="func">- The logic to be measured for execution time</param>
    abstract ``measure``: name: string * func: (unit -> unit) -> unit
    abstract reset: unit -> unit
    abstract setPeriodicReset: unit -> unit

type [<AllowNullLiteral>] IExports =
    abstract GlobalSettings: GlobalSettingsStatic

/// Change description used for change callbacks in GlobalSettings.
type [<AllowNullLiteral>] IChangeDescription =
    abstract key: string with get, set
    abstract oldValue: obj option with get, set
    abstract value: obj option with get, set

/// Change event callback.
type [<AllowNullLiteral>] IChangeEventCallback =
    abstract __id__: string option with get, set
    [<Emit "$0($1...)">] abstract Invoke: ?changeDescription: IChangeDescription -> unit

/// Global settings helper, which stores settings in the global (window) namespace.
/// If window is not provided, it will store settings in module scope. Provides a
/// way to observe changes as well when their values change.
type [<AllowNullLiteral>] GlobalSettings =
    interface end

/// Global settings helper, which stores settings in the global (window) namespace.
/// If window is not provided, it will store settings in module scope. Provides a
/// way to observe changes as well when their values change.
type [<AllowNullLiteral>] GlobalSettingsStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> GlobalSettings
    abstract getValue: key: string * ?defaultValue: U2<'T, (unit -> 'T)> -> 'T
    abstract setValue: key: string * value: 'T -> 'T
    abstract addChangeListener: cb: IChangeEventCallback -> unit
    abstract removeChangeListener: cb: IChangeEventCallback -> unit

type [<AllowNullLiteral>] IClassNames<'T> =
    interface end

type IComponentAs<'T> =
    U2<React.StatelessComponent<'T>, React.ComponentClass<'T>>

[<RequireQualifiedAccess; CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
module IComponentAs =
    let ofReact.StatelessComponent v: IComponentAs<'T> = v |> U2.Case1
    let isReact.StatelessComponent (v: IComponentAs<'T>) = match v with U2.Case1 _ -> true | _ -> false
    let asReact.StatelessComponent (v: IComponentAs<'T>) = match v with U2.Case1 o -> Some o | _ -> None
    let ofReact.ComponentClass v: IComponentAs<'T> = v |> U2.Case2
    let isReact.ComponentClass (v: IComponentAs<'T>) = match v with U2.Case2 _ -> true | _ -> false
    let asReact.ComponentClass (v: IComponentAs<'T>) = match v with U2.Case2 o -> Some o | _ -> None

/// Point interface.
type [<AllowNullLiteral>] IPoint =
    abstract x: float with get, set
    abstract y: float with get, set

/// Rectangle interface.
type [<AllowNullLiteral>] IRectangle =
    abstract left: float with get, set
    abstract top: float with get, set
    abstract width: float with get, set
    abstract height: float with get, set
    abstract right: float option with get, set
    abstract bottom: float option with get, set

/// An interface representing a component that will not output any DOM, will just render its children and
/// pass through items to modify the children.
type [<AllowNullLiteral>] IRenderComponent<'TProps> =
    /// JSX.Element to return in this component's render() function.
    abstract children: ('TProps -> JSX.Element) with get, set

/// Render function interface for providing overrideable render callbacks.
type [<AllowNullLiteral>] IRenderFunction<'P> =
    [<Emit "$0($1...)">] abstract Invoke: ?props: 'P * ?defaultRender: ('P -> JSX.Element option) -> JSX.Element option

type [<AllowNullLiteral>] ISize =
    abstract width: float with get, set
    abstract height: float with get, set

type [<AllowNullLiteral>] IStyleFunction<'TStylesProps, 'TStyles> =
    [<Emit "$0($1...)">] abstract Invoke: props: 'TStylesProps -> obj

type [<RequireQualifiedAccess>] KeyCodes =
    | Backspace = 8
    | Tab = 9
    | Enter = 13
    | Shift = 16
    | Ctrl = 17
    | Alt = 18
    | PauseBreak = 19
    | Capslock = 20
    | Escape = 27
    | Space = 32
    | PageUp = 33
    | PageDown = 34
    | End = 35
    | Home = 36
    | Left = 37
    | Up = 38
    | Right = 39
    | Down = 40
    | Insert = 45
    | Del = 46
    | Zero = 48
    | One = 49
    | Two = 50
    | Three = 51
    | Four = 52
    | Five = 53
    | Six = 54
    | Seven = 55
    | Eight = 56
    | Nine = 57
    | A = 65
    | B = 66
    | C = 67
    | D = 68
    | E = 69
    | F = 70
    | G = 71
    | H = 72
    | I = 73
    | J = 74
    | K = 75
    | L = 76
    | M = 77
    | N = 78
    | O = 79
    | P = 80
    | Q = 81
    | R = 82
    | S = 83
    | T = 84
    | U = 85
    | V = 86
    | W = 87
    | X = 88
    | Y = 89
    | Z = 90
    | LeftWindow = 91
    | RightWindow = 92
    | Select = 93
    | Zero_numpad = 96
    | One_numpad = 97
    | Two_numpad = 98
    | Three_numpad = 99
    | Four_numpad = 100
    | Five_numpad = 101
    | Six_numpad = 102
    | Seven_numpad = 103
    | Eight_numpad = 104
    | Nine_numpad = 105
    | Multiply = 106
    | Add = 107
    | Subtract = 109
    | DecimalPoint = 110
    | Divide = 111
    | F1 = 112
    | F2 = 113
    | F3 = 114
    | F4 = 115
    | F5 = 116
    | F6 = 117
    | F7 = 118
    | F8 = 119
    | F9 = 120
    | F10 = 121
    | F11 = 122
    | F12 = 123
    | Numlock = 144
    | ScrollLock = 145
    | Semicolon = 186
    | EqualSign = 187
    | Comma = 188
    | Dash = 189
    | Period = 190
    | ForwardSlash = 191
    | GraveAccent = 192
    | OpenBracket = 219
    | BackSlash = 220
    | CloseBracket = 221
    | SingleQuote = 222

type [<AllowNullLiteral>] IExports =
    abstract Rectangle: RectangleStatic

/// Rectangle helper class.
type [<AllowNullLiteral>] Rectangle =
    abstract top: float with get, set
    abstract bottom: float with get, set
    abstract left: float with get, set
    abstract right: float with get, set
    /// Calculated automatically by subtracting the right from left
    abstract width: float
    /// Calculated automatically by subtracting the bottom from top.
    abstract height: float
    /// Tests if another rect is approximately equal to this rect (within 4 decimal places.)
    abstract equals: rect: Rectangle -> bool

/// Rectangle helper class.
type [<AllowNullLiteral>] RectangleStatic =
    [<Emit "new $0($1...)">] abstract Create: ?left: float * ?right: float * ?top: float * ?bottom: float -> Rectangle

type [<AllowNullLiteral>] IExports =
    /// <summary>Helper to find the index of an item within an array, using a callback to
    /// determine the match.</summary>
    /// <param name="array">- Array to search.</param>
    /// <param name="cb">- Callback which returns true on matches.</param>
    abstract findIndex: array: ResizeArray<'T> * cb: ('T -> float -> bool) -> float
    /// <summary>Helper to find the first item within an array that satisfies the callback.</summary>
    /// <param name="array">- Array to search</param>
    /// <param name="cb">- Callback which returns true on matches</param>
    abstract find: array: ResizeArray<'T> * cb: ('T -> float -> bool) -> 'T option
    /// <summary>Creates an array of a given size and helper method to populate.</summary>
    /// <param name="size">- Size of array.</param>
    /// <param name="getItem">- Callback to populate given cell index.</param>
    abstract createArray: size: float * getItem: (float -> 'T) -> ResizeArray<'T>
    /// <summary>Convert the given array to a matrix with columnCount number
    /// of columns.</summary>
    /// <param name="items">- The array to convert</param>
    /// <param name="columnCount">- The number of columns for the resulting matrix</param>
    abstract toMatrix: items: ResizeArray<'T> * columnCount: float -> ResizeArray<ResizeArray<'T>>
    /// <summary>Given an array, it returns a new array that does not contain the item at the given index.</summary>
    /// <param name="array">- The array to operate on</param>
    /// <param name="index">- The index of the element to remove</param>
    abstract removeIndex: array: ResizeArray<'T> * index: float -> ResizeArray<'T>
    /// <summary>Given an array, this function returns a new array where the element at a given index has been replaced.</summary>
    /// <param name="array">- The array to operate on</param>
    /// <param name="newElement">- The element that will be placed in the new array</param>
    /// <param name="index">- The index of the element that should be replaced</param>
    abstract replaceElement: array: ResizeArray<'T> * newElement: 'T * index: float -> ResizeArray<'T>
    /// <summary>Given an array, this function returns a new array where an element has been inserted at the given index.</summary>
    /// <param name="array">- The array to operate on</param>
    /// <param name="index">- The index where an element should be inserted</param>
    /// <param name="itemToAdd">- The element to insert</param>
    abstract addElementAtIndex: array: ResizeArray<'T> * index: float * itemToAdd: 'T -> ResizeArray<'T>
    /// <summary>Given an array where each element is of type T or T[], flatten it into an array of T</summary>
    /// <param name="array">- The array where each element can optionally also be an array</param>
    abstract flatten: array: ResizeArray<U2<'T, ResizeArray<'T>>> -> ResizeArray<'T>
    /// <summary>Returns a boolean indicating if the two given arrays are equal in length and values.</summary>
    /// <param name="array1">- First array to compare</param>
    /// <param name="array2">- Second array to compare</param>
    abstract arraysEqual: array1: ResizeArray<'T> * array2: ResizeArray<'T> -> bool

type [<AllowNullLiteral>] IExports =
    /// AssertNever is a utility function that can be used for exhaustiveness checks in switch statements.
    abstract assertNever: x: obj -> obj

type [<AllowNullLiteral>] IExports =
    /// Autobind is a utility for binding methods in a class. This simplifies tagging methods as being "bound" to the this pointer
    /// so that they can be used in scenarios that simply require a function callback.
    abstract autobind: target: obj option * key: string * descriptor: TypedPropertyDescriptor<'T> -> U2<obj, unit>

type [<StringEnum>] [<RequireQualifiedAccess>] ICSSRule =
    | Initial
    | Inherit
    | Unset

type ICSSPercentageRule =
    string

type ICSSPixelUnitRule =
    U2<string, float>

[<RequireQualifiedAccess; CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
module ICSSPixelUnitRule =
    let ofString v: ICSSPixelUnitRule = v |> U2.Case1
    let isString (v: ICSSPixelUnitRule) = match v with U2.Case1 _ -> true | _ -> false
    let asString (v: ICSSPixelUnitRule) = match v with U2.Case1 o -> Some o | _ -> None
    let ofFloat v: ICSSPixelUnitRule = v |> U2.Case2
    let isFloat (v: ICSSPixelUnitRule) = match v with U2.Case2 _ -> true | _ -> false
    let asFloat (v: ICSSPixelUnitRule) = match v with U2.Case2 o -> Some o | _ -> None

type IFontWeight =
    obj

/// The base font style.
type [<AllowNullLiteral>] IRawFontStyle =
    /// The font property is shorthand that allows you to do one of two things: you can
    /// either set up six of the most mature font properties in one line, or you can set
    ///   one of a choice of keywords to adopt a system font setting.
    abstract font: U2<ICSSRule, string> option with get, set
    /// The font-family property allows one or more font family names and/or generic family
    /// names to be specified for usage on the selected element(s)' text. The browser then
    /// goes through the list; for each character in the selection it applies the first
    /// font family that has an available glyph for that character.
    abstract fontFamily: U2<ICSSRule, string> option with get, set
    /// The font-kerning property allows contextual adjustment of inter-glyph spacing, i.e.
    /// the spaces between the characters in text. This property controls <bold>metric
    /// kerning</bold> - that utilizes adjustment data contained in the font. Optical
    /// Kerning is not supported as yet.
    abstract fontKerning: U2<ICSSRule, string> option with get, set
    /// Specifies the size of the font. Used to compute em and ex units.
    /// See CSS 3 font-size property https://www.w3.org/TR/css-fonts-3/#propdef-font-size
    abstract fontSize: obj option with get, set
    /// The font-size-adjust property adjusts the font-size of the fallback fonts defined
    /// with font-family, so that the x-height is the same no matter what font is used.
    /// This preserves the readability of the text when fallback happens.
    /// See CSS 3 font-size-adjust property
    /// https://www.w3.org/TR/css-fonts-3/#propdef-font-size-adjust
    abstract fontSizeAdjust: U3<ICSSRule, string, float> option with get, set
    /// Allows you to expand or condense the widths for a normal, condensed, or expanded
    /// font face.
    /// See CSS 3 font-stretch property
    /// https://drafts.csswg.org/css-fonts-3/#propdef-font-stretch
    abstract fontStretch: obj option with get, set
    /// The font-style property allows normal, italic, or oblique faces to be selected.
    /// Italic forms are generally cursive in nature while oblique faces are typically
    /// sloped versions of the regular face. Oblique faces can be simulated by artificially
    /// sloping the glyphs of the regular face.
    /// See CSS 3 font-style property https://www.w3.org/TR/css-fonts-3/#propdef-font-style
    abstract fontStyle: U4<ICSSRule, string, string, string> option with get, set
    /// This value specifies whether the user agent is allowed to synthesize bold or
    ///   oblique font faces when a font family lacks bold or italic faces.
    abstract fontSynthesis: U2<ICSSRule, string> option with get, set
    /// The font-variant property enables you to select the small-caps font within a font
    /// family.
    abstract fontVariant: U2<ICSSRule, string> option with get, set
    /// Fonts can provide alternate glyphs in addition to default glyph for a character.
    /// This property provides control over the selection of these alternate glyphs.
    abstract fontVariantAlternates: U2<ICSSRule, string> option with get, set
    /// Specifies the weight or boldness of the font.
    /// See CSS 3 'font-weight' property https://www.w3.org/TR/css-fonts-3/#propdef-font-weight
    abstract fontWeight: IFontWeight option with get, set

/// Font face definition.
type [<AllowNullLiteral>] IFontFace =
    inherit IRawFontStyle
    /// Specifies the src of the font.
    abstract src: string option with get, set
    /// unicode-range allows you to set a specific range of characters to be downloaded
    /// from a font (embedded using @font-face) and made available for use on the current
    /// page.
    abstract unicodeRange: U2<ICSSRule, string> option with get, set
    /// Feature settings for the font.
    abstract fontFeatureSettings: string option with get, set

/// All raw style properties.
type [<AllowNullLiteral>] IRawStyleBase =
    inherit IRawFontStyle
    /// (Ms specific) constrast adjust rule.
    abstract MsHighContrastAdjust: U2<ICSSRule, string> option with get, set
    /// (Moz specific) font smoothing directive.
    abstract MozOsxFontSmoothing: U4<string, string, string, string> option with get, set
    /// (Webkit specific) font smoothing directive.
    abstract WebkitFontSmoothing: U4<string, string, string, string> option with get, set
    /// (Webkit specific) momentum scrolling on iOS devices
    abstract WebkitOverflowScrolling: U2<string, string> option with get, set
    /// Aligns a flex container's lines within the flex container when there is extra space
    /// in the cross-axis, similar to how justify-content aligns individual items within the main-axis.
    abstract alignContent: U7<ICSSRule, string, string, string, string, string, string> option with get, set
    /// Sets the default alignment in the cross axis for all of the flex container's items,
    /// including anonymous flex items, similarly to how justify-content aligns items along the main axis.
    abstract alignItems: U6<ICSSRule, string, string, string, string, string> option with get, set
    /// Allows the default alignment to be overridden for individual flex items.
    abstract alignSelf: U7<ICSSRule, string, string, string, string, string, string> option with get, set
    /// This property allows precise alignment of elements, such as graphics, that do not
    /// have a baseline-table or lack the desired baseline in their baseline-table. With the
    /// alignment-adjust property, the position of the baseline identified by the
    /// alignment-baseline can be explicitly determined. It also determines precisely
    /// the alignment point for each glyph within a textual element.
    abstract alignmentAdjust: U2<ICSSRule, string> option with get, set
    /// Specifies how an object is aligned with respect to its parent. This property specifies
    /// which baseline of this element is to be aligned with the corresponding baseline of the
    /// parent. For example, this allows alphabetic baselines in Roman text to stay aligned
    /// across font size changes. It defaults to the baseline with the same name as the computed
    /// value of the alignment-baseline property.
    abstract alignmentBaseline: U2<ICSSRule, string> option with get, set
    /// The animation CSS property is a shorthand property for the various animation properties:
    /// `animation-name`, `animation-duration`, `animation-timing-function`, `animation-delay`,
    /// `animation-iteration-count`, `animation-direction`, `animation-fill-mode`, and
    /// `animation-play-state`.
    abstract animation: U2<ICSSRule, string> option with get, set
    /// Defines a length of time to elapse before an animation starts, allowing an animation to begin execution some time after it is applied.
    abstract animationDelay: U2<ICSSRule, string> option with get, set
    /// Defines whether an animation should run in reverse on some or all cycles.
    abstract animationDirection: U2<ICSSRule, string> option with get, set
    /// Specifies the length an animation takes to finish. Default value is 0, meaning
    /// there will be no animation.
    abstract animationDuration: U2<ICSSRule, string> option with get, set
    /// The animation-fill-mode CSS property specifies how a CSS animation should apply
    /// styles to its target before and after its execution.
    abstract animationFillMode: U5<ICSSRule, string, string, string, string> option with get, set
    /// Specifies how many times an animation cycle should play.
    abstract animationIterationCount: U2<ICSSRule, string> option with get, set
    /// Defines the list of animations that apply to the element.
    abstract animationName: U2<ICSSRule, string> option with get, set
    /// Defines whether an animation is running or paused.
    abstract animationPlayState: U2<ICSSRule, string> option with get, set
    /// The animation-timing-function specifies the speed curve of an animation.
    abstract animationTimingFunction: U2<ICSSRule, string> option with get, set
    /// Allows changing the style of any element to platform-based interface elements or
    /// vice versa.
    abstract appearance: U2<ICSSRule, string> option with get, set
    /// Determines whether or not the “back” side of a transformed element is visible when
    /// facing the viewer.
    abstract backfaceVisibility: U2<ICSSRule, string> option with get, set
    /// Shorthand property to set the values for one or more of:
    /// background-clip, background-color, background-image,
    /// background-origin, background-position, background-repeat,
    /// background-size, and background-attachment.
    abstract background: U2<ICSSRule, string> option with get, set
    /// If a background-image is specified, this property determines
    /// whether that image's position is fixed within the viewport,
    /// or scrolls along with its containing block.
    /// See CSS 3 background-attachment property https://drafts.csswg.org/css-backgrounds-3/#the-background-attachment
    abstract backgroundAttachment: U4<ICSSRule, string, string, string> option with get, set
    /// This property describes how the element's background images should blend with each
    /// other and the element's background color. The value is a list of blend modes that
    /// corresponds to each background image. Each element in the list will apply to the
    /// corresponding element of background-image. If a property doesn’t have enough
    /// comma-separated values to match the number of layers, the UA must calculate its
    /// used value by repeating the list of values until there are enough.
    abstract backgroundBlendMode: U2<ICSSRule, string> option with get, set
    /// The background-clip CSS property specifies if an element's background, whether a
    /// <color> or an <image>, extends underneath its border.
    /// 
    /// \* Does not work in IE
    /// 
    /// \* The `text` value is experimental and should not be used in production code.
    abstract backgroundClip: U5<ICSSRule, string, string, string, string> option with get, set
    /// Sets the background color of an element.
    abstract backgroundColor: U2<ICSSRule, string> option with get, set
    /// Sets a compositing style for background images and colors.
    abstract backgroundComposite: U2<ICSSRule, string> option with get, set
    /// Applies one or more background images to an element. These can be any valid CSS
    /// image, including url() paths to image files or CSS gradients.
    abstract backgroundImage: U2<ICSSRule, string> option with get, set
    /// Specifies what the background-position property is relative to.
    abstract backgroundOrigin: U2<ICSSRule, string> option with get, set
    /// Sets the position of a background image.
    abstract backgroundPosition: U2<ICSSRule, string> option with get, set
    /// Background-repeat defines if and how background images will be repeated after they
    /// have been sized and positioned
    abstract backgroundRepeat: U2<ICSSRule, string> option with get, set
    /// Sets the size of background images
    abstract backgroundSize: U2<ICSSRule, string> option with get, set
    /// Shorthand property that defines the different properties of all four sides of an
    /// element's border in a single declaration. It can be used to set border-width,
    /// border-style and border-color, or a subset of these.
    abstract border: U3<ICSSRule, obj, string> option with get, set
    /// Shorthand that sets the values of border-bottom-color,
    /// border-bottom-style, and border-bottom-width.
    abstract borderBottom: U2<ICSSRule, ICSSPixelUnitRule> option with get, set
    /// Sets the color of the bottom border of an element.
    abstract borderBottomColor: U2<ICSSRule, string> option with get, set
    /// Defines the shape of the border of the bottom-left corner.
    abstract borderBottomLeftRadius: U2<ICSSRule, string> option with get, set
    /// Defines the shape of the border of the bottom-right corner.
    abstract borderBottomRightRadius: U2<ICSSRule, string> option with get, set
    /// Sets the line style of the bottom border of a box.
    abstract borderBottomStyle: U2<ICSSRule, string> option with get, set
    /// Sets the width of an element's bottom border. To set all four borders, use the
    /// border-width shorthand property which sets the values simultaneously for
    /// border-top-width, border-right-width, border-bottom-width, and border-left-width.
    abstract borderBottomWidth: U2<ICSSRule, ICSSPixelUnitRule> option with get, set
    /// Border-collapse can be used for collapsing the borders between table cells
    abstract borderCollapse: U2<ICSSRule, string> option with get, set
    /// The CSS border-color property sets the color of an element's four borders. This
    /// property can have from one to four values, made up of the elementary properties:
    ///       •       border-top-color
    ///       •       border-right-color
    ///       •       border-bottom-color
    ///       •       border-left-color The default color is the currentColor of each of
    /// these values.
    /// If you provide one value, it sets the color for the element. Two values set the
    /// horizontal and vertical values, respectively. Providing three values sets the top,
    /// vertical, and bottom values, in that order. Four values set all for sides: top,
    /// right, bottom, and left, in that order.
    abstract borderColor: U2<ICSSRule, string> option with get, set
    /// Specifies different corner clipping effects, such as scoop (inner curves), bevel
    /// (straight cuts) or notch (cut-off rectangles). Works along with border-radius to
    /// specify the size of each corner effect.
    abstract borderCornerShape: U2<ICSSRule, string> option with get, set
    /// The property border-image-source is used to set the image to be used instead of
    /// the border style. If this is set to none the border-style is used instead.
    abstract borderImageSource: U2<ICSSRule, string> option with get, set
    /// The border-image-width CSS property defines the offset to use for dividing the
    /// border image in nine parts, the top-left corner, central top edge, top-right-corner,
    /// central right edge, bottom-right corner, central bottom edge, bottom-left corner,
    /// and central right edge. They represent inward distance from the top, right, bottom,
    /// and left edges.
    abstract borderImageWidth: U2<ICSSRule, ICSSPixelUnitRule> option with get, set
    /// Shorthand property that defines the border-width, border-style and border-color of
    /// an element's left border in a single declaration. Note that you can use the
    /// corresponding longhand properties to set specific individual properties of the left
    /// border — border-left-width, border-left-style and border-left-color.
    abstract borderLeft: U2<ICSSRule, ICSSPixelUnitRule> option with get, set
    /// The CSS border-left-color property sets the color of an element's left border. This
    ///   page explains the border-left-color value, but often you will find it more
    /// convenient to fix the border's left color as part of a shorthand set, either
    /// border-left or border-color. Colors can be defined several ways. For more
    /// information, see Usage.
    abstract borderLeftColor: U2<ICSSRule, string> option with get, set
    /// Sets the style of an element's left border. To set all four borders, use the
    /// shorthand property, border-style. Otherwise, you can set the borders individually
    /// with border-top-style, border-right-style, border-bottom-style, border-left-style.
    abstract borderLeftStyle: U2<ICSSRule, string> option with get, set
    /// Sets the width of an element's left border. To set all four borders, use the
    /// border-width shorthand property which sets the values simultaneously for
    /// border-top-width, border-right-width, border-bottom-width, and border-left-width.
    abstract borderLeftWidth: U2<ICSSRule, ICSSPixelUnitRule> option with get, set
    /// Defines how round the border's corners are.
    abstract borderRadius: U2<ICSSRule, ICSSPixelUnitRule> option with get, set
    /// Shorthand property that defines the border-width, border-style and border-color of
    /// an element's right border in a single declaration. Note that you can use the
    /// corresponding longhand properties to set specific individual properties of the
    /// right border — border-right-width, border-right-style and border-right-color.
    abstract borderRight: U2<ICSSRule, ICSSPixelUnitRule> option with get, set
    /// Sets the color of an element's right border. This page explains the
    /// border-right-color value, but often you will find it more convenient to fix the
    /// border's right color as part of a shorthand set, either border-right or border-color.
    /// Colors can be defined several ways. For more information, see Usage.
    abstract borderRightColor: U2<ICSSRule, string> option with get, set
    /// Sets the style of an element's right border. To set all four borders, use the
    /// shorthand property, border-style. Otherwise, you can set the borders individually
    /// with border-top-style, border-right-style, border-bottom-style, border-left-style.
    abstract borderRightStyle: U2<ICSSRule, string> option with get, set
    /// Sets the width of an element's right border. To set all four borders, use the
    /// border-width shorthand property which sets the values simultaneously for
    /// border-top-width, border-right-width, border-bottom-width, and border-left-width.
    abstract borderRightWidth: U2<ICSSRule, ICSSPixelUnitRule> option with get, set
    /// Specifies the distance between the borders of adjacent cells.
    abstract borderSpacing: U2<ICSSRule, string> option with get, set
    /// Sets the style of an element's four borders. This property can have from one to
    /// four values. With only one value, the value will be applied to all four borders;
    /// otherwise, this works as a shorthand property for each of border-top-style,
    ///   border-right-style, border-bottom-style, border-left-style, where each border
    ///   style may be assigned a separate value.
    abstract borderStyle: U2<ICSSRule, string> option with get, set
    /// Shorthand property that defines the border-width, border-style and border-color of
    /// an element's top border in a single declaration. Note that you can use the
    /// corresponding longhand properties to set specific individual properties of the top
    /// border — border-top-width, border-top-style and border-top-color.
    abstract borderTop: U2<ICSSRule, ICSSPixelUnitRule> option with get, set
    /// Sets the color of an element's top border. This page explains the border-top-color
    /// value, but often you will find it more convenient to fix the border's top color as
    /// part of a shorthand set, either border-top or border-color.
    /// Colors can be defined several ways. For more information, see Usage.
    abstract borderTopColor: U2<ICSSRule, string> option with get, set
    /// Sets the rounding of the top-left corner of the element.
    abstract borderTopLeftRadius: U2<ICSSRule, string> option with get, set
    /// Sets the rounding of the top-right corner of the element.
    abstract borderTopRightRadius: U2<ICSSRule, string> option with get, set
    /// Sets the style of an element's top border. To set all four borders, use the
    /// shorthand property, border-style. Otherwise, you can set the borders individually
    /// with border-top-style, border-right-style, border-bottom-style, border-left-style.
    abstract borderTopStyle: U2<ICSSRule, string> option with get, set
    /// Sets the width of an element's top border. To set all four borders, use the
    /// border-width shorthand property which sets the values simultaneously for
    /// border-top-width, border-right-width, border-bottom-width, and border-left-width.
    abstract borderTopWidth: U2<ICSSRule, ICSSPixelUnitRule> option with get, set
    /// Sets the width of an element's four borders. This property can have from one to
    /// four values. This is a shorthand property for setting values simultaneously for
    /// border-top-width, border-right-width, border-bottom-width, and border-left-width.
    abstract borderWidth: U2<ICSSRule, ICSSPixelUnitRule> option with get, set
    /// This property specifies how far an absolutely positioned box's bottom margin edge
    /// is offset above the bottom edge of the box's containing block. For relatively
    /// positioned boxes, the offset is with respect to the bottom edges of the box itself
    /// (i.e., the box is given a position in the normal flow, then offset from that
    /// position according to these properties).
    abstract bottom: U2<ICSSRule, ICSSPixelUnitRule> option with get, set
    /// Breaks a box into fragments creating new borders, padding and repeating backgrounds
    /// or lets it stay as a continuous box on a page break, column break, or, for inline
    /// elements, at a line break.
    abstract boxDecorationBreak: U2<ICSSRule, string> option with get, set
    /// Cast a drop shadow from the frame of almost any element.
    /// MDN: https://developer.mozilla.org/en-US/docs/Web/CSS/box-shadow
    abstract boxShadow: U2<ICSSRule, string> option with get, set
    /// The CSS box-sizing property is used to alter the default CSS box model used to
    /// calculate width and height of the elements.
    abstract boxSizing: U3<ICSSRule, string, string> option with get, set
    /// The CSS break-after property allows you to force a break on multi-column layouts.
    /// More specifically, it allows you to force a break after an element. It allows you
    /// to determine if a break should occur, and what type of break it should be. The
    /// break-after CSS property describes how the page, column or region break behaves
    /// after the generated box. If there is no generated box, the property is ignored.
    abstract breakAfter: U2<ICSSRule, string> option with get, set
    /// Control page/column/region breaks that fall above a block of content
    abstract breakBefore: U2<ICSSRule, string> option with get, set
    /// Control page/column/region breaks that fall within a block of content
    abstract breakInside: U2<ICSSRule, string> option with get, set
    /// The clear CSS property specifies if an element can be positioned next to or must be
    /// positioned below the floating elements that precede it in the markup.
    abstract clear: U2<ICSSRule, string> option with get, set
    /// Clipping crops an graphic, so that only a portion of the graphic is rendered, or
    /// filled. This clip-rule property, when used with the clip-path property, defines
    /// which clip rule, or algorithm, to use when filling the different parts of a graphics.
    abstract clipRule: U2<ICSSRule, string> option with get, set
    /// The color property sets the color of an element's foreground content (usually text),
    /// accepting any standard CSS color from keywords and hex values to RGB(a) and HSL(a).
    abstract color: U2<ICSSRule, string> option with get, set
    /// Describes the number of columns of the element.
    /// See CSS 3 column-count property https://www.w3.org/TR/css3-multicol/#cc
    abstract columnCount: U3<ICSSRule, float, string> option with get, set
    /// Specifies how to fill columns (balanced or sequential).
    abstract columnFill: U2<ICSSRule, string> option with get, set
    /// The column-gap property controls the width of the gap between columns in multi-column
    /// elements.
    abstract columnGap: U2<ICSSRule, string> option with get, set
    /// Sets the width, style, and color of the rule between columns.
    abstract columnRule: U2<ICSSRule, string> option with get, set
    /// Specifies the color of the rule between columns.
    abstract columnRuleColor: U2<ICSSRule, string> option with get, set
    /// Specifies the width of the rule between columns.
    abstract columnRuleWidth: U2<ICSSRule, ICSSPixelUnitRule> option with get, set
    /// The column-span CSS property makes it possible for an element to span across all
    /// columns when its value is set to all. An element that spans more than one column
    /// is called a spanning element.
    abstract columnSpan: U2<ICSSRule, string> option with get, set
    /// Specifies the width of columns in multi-column elements.
    abstract columnWidth: U2<ICSSRule, ICSSPixelUnitRule> option with get, set
    /// This property is a shorthand property for setting column-width and/or column-count.
    abstract columns: U2<ICSSRule, string> option with get, set
    /// Content for pseudo selectors.
    abstract content: string option with get, set
    /// The counter-increment property accepts one or more names of counters (identifiers),
    /// each one optionally followed by an integer which specifies the value by which the
    /// counter should be incremented (e.g. if the value is 2, the counter increases by 2
    /// each time it is invoked).
    abstract counterIncrement: U2<ICSSRule, string> option with get, set
    /// The counter-reset property contains a list of one or more names of counters, each
    /// one optionally followed by an integer (otherwise, the integer defaults to 0.) Each
    /// time the given element is invoked, the counters specified by the property are set to the given integer.
    abstract counterReset: U2<ICSSRule, string> option with get, set
    /// The cue property specifies sound files (known as an "auditory icon") to be played by
    /// speech media agents before and after presenting an element's content; if only one
    /// file is specified, it is played both before and after. The volume at which the
    /// file(s) should be played, relative to the volume of the main element, may also be
    /// specified. The icon files may also be set separately with the cue-before and
    /// cue-after properties.
    abstract cue: U2<ICSSRule, string> option with get, set
    /// The cue-after property specifies a sound file (known as an "auditory icon") to be
    /// played by speech media agents after presenting an element's content; the volume at
    /// which the file should be played may also be specified. The shorthand property cue
    /// sets cue sounds for both before and after the element is presented.
    abstract cueAfter: U2<ICSSRule, string> option with get, set
    /// Specifies the mouse cursor displayed when the mouse pointer is over an element.
    abstract cursor: U2<ICSSRule, string> option with get, set
    /// The direction CSS property specifies the text direction/writing direction. The rtl
    /// is used for Hebrew or Arabic text, the ltr is for other languages.
    abstract direction: U2<ICSSRule, string> option with get, set
    /// This property specifies the type of rendering box used for an element. It is a
    /// shorthand property for many other display properties.
    abstract display: U2<ICSSRule, string> option with get, set
    /// The ‘fill’ property paints the interior of the given graphical element. The area to
    /// be painted consists of any areas inside the outline of the shape. To determine the
    /// inside of the shape, all subpaths are considered, and the interior is determined
    /// according to the rules associated with the current value of the ‘fill-rule’
    /// property. The zero-width geometric outline of a shape is included in the area to be
    /// painted.
    abstract fill: U2<ICSSRule, string> option with get, set
    /// SVG: Specifies the opacity of the color or the content the current object is filled
    /// with.
    /// See SVG 1.1 https://www.w3.org/TR/SVG/painting.html#FillOpacityProperty
    abstract fillOpacity: U2<ICSSRule, float> option with get, set
    /// The ‘fill-rule’ property indicates the algorithm which is to be used to determine
    /// what parts of the canvas are included inside the shape. For a simple,
    /// non-intersecting path, it is intuitively clear what region lies "inside"; however,
    /// for a more complex path, such as a path that intersects itself or where one subpath
    /// encloses another, the interpretation of "inside" is not so obvious.
    /// The ‘fill-rule’ property provides two options for how the inside of a shape is
    /// determined:
    abstract fillRule: U2<ICSSRule, string> option with get, set
    /// Applies various image processing effects. This property is largely unsupported. See
    /// Compatibility section for more information.
    abstract filter: U2<ICSSRule, string> option with get, set
    /// Shorthand for `flex-grow`, `flex-shrink`, and `flex-basis`.
    abstract flex: U3<ICSSRule, string, float> option with get, set
    /// The flex-basis CSS property describes the initial main size of the flex item before
    /// any free space is distributed according to the flex factors described in the flex
    /// property (flex-grow and flex-shrink).
    abstract flexBasis: U3<ICSSRule, string, float> option with get, set
    /// The flex-direction CSS property describes how flex items are placed in the flex
    /// container, by setting the direction of the flex container's main axis.
    abstract flexDirection: U5<ICSSRule, string, string, string, string> option with get, set
    /// The flex-flow CSS property defines the flex container's main and cross axis. It is
    /// a shorthand property for the flex-direction and flex-wrap properties.
    abstract flexFlow: U2<ICSSRule, string> option with get, set
    /// Specifies the flex grow factor of a flex item.
    /// See CSS flex-grow property https://drafts.csswg.org/css-flexbox-1/#flex-grow-property
    abstract flexGrow: U3<ICSSRule, float, string> option with get, set
    /// Specifies the flex shrink factor of a flex item.
    /// See CSS flex-shrink property https://drafts.csswg.org/css-flexbox-1/#flex-shrink-property
    abstract flexShrink: U3<ICSSRule, float, string> option with get, set
    /// Specifies whether flex items are forced into a single line or can be wrapped onto
    /// multiple lines. If wrapping is allowed, this property also enables you to control
    /// the direction in which lines are stacked.
    /// See CSS flex-wrap property https://drafts.csswg.org/css-flexbox-1/#flex-wrap-property
    abstract flexWrap: U4<ICSSRule, string, string, string> option with get, set
    /// Elements which have the style float are floated horizontally. These elements can
    /// move as far to the left or right of the containing element. All elements after
    /// the floating element will flow around it, but elements before the floating element
    /// are not impacted. If several floating elements are placed after each other, they
    /// will float next to each other as long as there is room.
    abstract float: U2<ICSSRule, string> option with get, set
    /// Flows content from a named flow (specified by a corresponding flow-into) through
    /// selected elements to form a dynamic chain of layout regions.
    abstract flowFrom: U2<ICSSRule, string> option with get, set
    /// Lays out one or more grid items bound by 4 grid lines. Shorthand for setting
    /// grid-column-start, grid-column-end, grid-row-start, and grid-row-end in a single
    /// declaration.
    abstract gridArea: U2<ICSSRule, string> option with get, set
    /// Controls a grid item's placement in a grid area, particularly grid position and a
    /// grid span. Shorthand for setting grid-column-start and grid-column-end in a single
    /// declaration.
    abstract gridColumn: U2<ICSSRule, string> option with get, set
    /// Controls a grid item's placement in a grid area as well as grid position and a
    /// grid span. The grid-column-end property (with grid-row-start, grid-row-end, and
    /// grid-column-start) determines a grid item's placement by specifying the grid lines
    /// of a grid item's grid area.
    abstract gridColumnEnd: U2<ICSSRule, string> option with get, set
    /// Determines a grid item's placement by specifying the starting grid lines of a grid
    /// item's grid area . A grid item's placement in a grid area consists of a grid
    /// position and a grid span. See also ( grid-row-start, grid-row-end, and
    /// grid-column-end)
    abstract gridColumnStart: U2<ICSSRule, string> option with get, set
    /// Gets or sets a value that indicates which row an element within a Grid should
    /// appear in. Shorthand for setting grid-row-start and grid-row-end in a single
    /// declaration.
    abstract gridRow: U2<ICSSRule, string> option with get, set
    /// Determines a grid item’s placement by specifying the block-end. A grid item's
    /// placement in a grid area consists of a grid position and a grid span. The
    /// grid-row-end property (with grid-row-start, grid-column-start, and grid-column-end)
    /// determines a grid item's placement by specifying the grid lines of a grid item's
    /// grid area.
    abstract gridRowEnd: U2<ICSSRule, string> option with get, set
    /// Specifies a row position based upon an integer location, string value, or desired
    /// row size.
    /// css/properties/grid-row is used as short-hand for grid-row-position and
    /// grid-row-position
    abstract gridRowPosition: U2<ICSSRule, string> option with get, set
    /// Specifies named grid areas which are not associated with any particular grid item,
    /// but can be referenced from the grid-placement properties. The syntax of the
    /// grid-template-areas property also provides a visualization of the structure of the
    /// grid, making the overall layout of the grid container easier to understand.
    abstract gridTemplateAreas: U2<ICSSRule, string> option with get, set
    /// Specifies (with grid-template-rows) the line names and track sizing functions of
    /// the grid. Each sizing function can be specified as a length, a percentage of the
    /// grid container’s size, a measurement of the contents occupying the column or row,
    /// or a fraction of the free space in the grid.
    abstract gridTemplateColumns: U2<ICSSRule, string> option with get, set
    /// Specifies (with grid-template-columns) the line names and track sizing functions of
    /// the grid. Each sizing function can be specified as a length, a percentage of the
    /// grid container’s size, a measurement of the contents occupying the column or row,
    /// or a fraction of the free space in the grid.
    abstract gridTemplateRows: U2<ICSSRule, string> option with get, set
    /// Sets the height of an element. The content area of the element height does not
    /// include the padding, border, and margin of the element.
    abstract height: U2<ICSSRule, ICSSPixelUnitRule> option with get, set
    /// Specifies the minimum number of characters in a hyphenated word
    abstract hyphenateLimitChars: U2<ICSSRule, string> option with get, set
    /// Indicates the maximum number of successive hyphenated lines in an element. The
    /// ‘no-limit’ value means that there is no limit.
    abstract hyphenateLimitLines: U2<ICSSRule, string> option with get, set
    /// Specifies the maximum amount of trailing whitespace (before justification) that may
    /// be left in a line before hyphenation is triggered to pull part of a word from the
    /// next line back up into the current one.
    abstract hyphenateLimitZone: U2<ICSSRule, string> option with get, set
    /// Specifies whether or not words in a sentence can be split by the use of a manual or
    /// automatic hyphenation mechanism.
    abstract hyphens: U2<ICSSRule, string> option with get, set
    /// Defines how the browser distributes space between and around flex items
    /// along the main-axis of their container.
    /// See CSS justify-content property
    /// https://www.w3.org/TR/css-flexbox-1/#justify-content-property
    abstract justifyContent: U7<ICSSRule, string, string, string, string, string, string> option with get, set
    /// Sets the left position of an element relative to the nearest anscestor that is set
    /// to position absolute, relative, or fixed.
    abstract left: U2<ICSSRule, ICSSPixelUnitRule> option with get, set
    /// The letter-spacing CSS property specifies the spacing behavior between text
    /// characters.
    abstract letterSpacing: U2<ICSSRule, string> option with get, set
    /// Specifies the height of an inline block level element.
    /// See CSS 2.1 line-height property https://www.w3.org/TR/CSS21/visudet.html#propdef-line-height
    abstract lineHeight: U4<ICSSRule, string, ICSSPixelUnitRule, ICSSPercentageRule> option with get, set
    /// Shorthand property that sets the list-style-type, list-style-position and
    /// list-style-image properties in one declaration.
    abstract listStyle: U2<ICSSRule, string> option with get, set
    /// This property sets the image that will be used as the list item marker. When the
    /// image is available, it will replace the marker set with the 'list-style-type'
    /// marker. That also means that if the image is not available, it will show the style
    /// specified by list-style-property
    abstract listStyleImage: U2<ICSSRule, string> option with get, set
    /// Specifies if the list-item markers should appear inside or outside the content flow.
    abstract listStylePosition: U2<ICSSRule, string> option with get, set
    /// Specifies the type of list-item marker in a list.
    abstract listStyleType: U2<ICSSRule, string> option with get, set
    /// The margin property is shorthand to allow you to set all four margins of an element
    /// at once. Its equivalent longhand properties are margin-top, margin-right,
    /// margin-bottom and margin-left. Negative values are also allowed.
    abstract margin: U2<ICSSRule, ICSSPixelUnitRule> option with get, set
    /// margin-bottom sets the bottom margin of an element.
    abstract marginBottom: U2<ICSSRule, ICSSPixelUnitRule> option with get, set
    /// margin-left sets the left margin of an element.
    abstract marginLeft: U2<ICSSRule, ICSSPixelUnitRule> option with get, set
    /// margin-right sets the right margin of an element.
    abstract marginRight: U2<ICSSRule, ICSSPixelUnitRule> option with get, set
    /// margin-top sets the top margin of an element.
    abstract marginTop: U2<ICSSRule, ICSSPixelUnitRule> option with get, set
    /// The marquee-direction determines the initial direction in which the marquee content moves.
    abstract marqueeDirection: U2<ICSSRule, string> option with get, set
    /// The 'marquee-style' property determines a marquee's scrolling behavior.
    abstract marqueeStyle: U2<ICSSRule, string> option with get, set
    /// This property is shorthand for setting mask-image, mask-mode, mask-repeat,
    /// mask-position, mask-clip, mask-origin, mask-composite and mask-size. Omitted
    /// values are set to their original properties' initial values.
    abstract mask: U2<ICSSRule, string> option with get, set
    /// This property is shorthand for setting mask-border-source, mask-border-slice,
    /// mask-border-width, mask-border-outset, and mask-border-repeat. Omitted values
    /// are set to their original properties' initial values.
    abstract maskBorder: U2<ICSSRule, string> option with get, set
    /// This property specifies how the images for the sides and the middle part of the
    /// mask image are scaled and tiled. The first keyword applies to the horizontal
    /// sides, the second one applies to the vertical ones. If the second keyword is
    /// absent, it is assumed to be the same as the first, similar to the CSS
    /// border-image-repeat property.
    abstract maskBorderRepeat: U2<ICSSRule, string> option with get, set
    /// This property specifies inward offsets from the top, right, bottom, and left
    /// edges of the mask image, dividing it into nine regions: four corners, four
    /// edges, and a middle. The middle image part is discarded and treated as fully
    /// transparent black unless the fill keyword is present. The four values set the
    /// top, right, bottom and left offsets in that order, similar to the CSS
    /// border-image-slice property.
    abstract maskBorderSlice: U2<ICSSRule, string> option with get, set
    /// Specifies an image to be used as a mask. An image that is empty, fails to
    /// download, is non-existent, or cannot be displayed is ignored and does not mask
    /// the element.
    abstract maskBorderSource: U2<ICSSRule, string> option with get, set
    /// This property sets the width of the mask box image, similar to the CSS
    /// border-image-width property.
    abstract maskBorderWidth: U2<ICSSRule, ICSSPixelUnitRule> option with get, set
    /// Determines the mask painting area, which defines the area that is affected by
    /// the mask. The painted content of an element may be restricted to this area.
    abstract maskClip: U2<ICSSRule, string> option with get, set
    /// For elements rendered as a single box, specifies the mask positioning area. For
    /// elements rendered as multiple boxes (e.g., inline boxes on several lines, boxes
    /// on several pages) specifies which boxes box-decoration-break operates on to
    /// determine the mask positioning area(s).
    abstract maskOrigin: U2<ICSSRule, string> option with get, set
    /// This property must not be used. It is no longer included in any standard or
    /// standard track specification, nor is it implemented in any browser. It is only
    /// used when the text-align-last property is set to size. It controls allowed
    /// adjustments of font-size to fit line content.
    abstract maxFontSize: U2<ICSSRule, ICSSPixelUnitRule> option with get, set
    /// Sets the maximum height for an element. It prevents the height of the element to
    ///   exceed the specified value. If min-height is specified and is greater than
    /// max-height, max-height is overridden.
    abstract maxHeight: U2<ICSSRule, ICSSPixelUnitRule> option with get, set
    /// Sets the maximum width for an element. It limits the width property to be larger
    /// than the value specified in max-width.
    abstract maxWidth: U2<ICSSRule, ICSSPixelUnitRule> option with get, set
    /// Sets the minimum height for an element. It prevents the height of the element to
    /// be smaller than the specified value. The value of min-height overrides both
    /// max-height and height.
    abstract minHeight: U2<ICSSRule, ICSSPixelUnitRule> option with get, set
    /// Sets the minimum width of an element. It limits the width property to be not
    /// smaller than the value specified in min-width.
    abstract minWidth: U2<ICSSRule, ICSSPixelUnitRule> option with get, set
    /// Specifies the transparency of an element.
    /// See CSS 3 opacity property https://drafts.csswg.org/css-color-3/#opacity
    abstract opacity: U3<ICSSRule, float, string> option with get, set
    /// Specifies the order used to lay out flex items in their flex container.
    /// Elements are laid out in the ascending order of the order value.
    /// See CSS order property https://drafts.csswg.org/css-flexbox-1/#order-property
    abstract order: U2<ICSSRule, float> option with get, set
    /// In paged media, this property defines the minimum number of lines in
    /// a block container that must be left at the bottom of the page.
    /// See CSS 3 orphans, widows properties https://drafts.csswg.org/css-break-3/#widows-orphans
    abstract orphans: U2<ICSSRule, float> option with get, set
    /// The CSS outline property is a shorthand property for setting one or more of the
    /// individual outline properties outline-style, outline-width and outline-color in a
    /// single rule. In most cases the use of this shortcut is preferable and more
    /// convenient.
    /// Outlines differ from borders in the following ways:
    ///       •       Outlines do not take up space, they are drawn above the content.
    ///       •       Outlines may be non-rectangular. They are rectangular in
    /// Gecko/Firefox. Internet Explorer attempts to place the smallest contiguous outline
    /// around all elements or shapes that are indicated to have an outline. Opera draws a
    /// non-rectangular shape around a construct.
    abstract outline: U3<ICSSRule, obj, string> option with get, set
    /// The outline-color property sets the color of the outline of an element. An
    /// outline is a line that is drawn around elements, outside the border edge, to make
    /// the element stand out.
    abstract outlineColor: U2<ICSSRule, string> option with get, set
    /// The outline-offset property offsets the outline and draw it beyond the border edge.
    abstract outlineOffset: U2<ICSSRule, string> option with get, set
    /// The overflow property controls how extra content exceeding the bounding box of an
    /// element is rendered. It can be used in conjunction with an element that has a
    /// fixed width and height, to eliminate text-induced page distortion.
    abstract overflow: U5<ICSSRule, string, string, string, string> option with get, set
    /// Specifies the preferred scrolling methods for elements that overflow.
    abstract overflowStyle: U2<ICSSRule, string> option with get, set
    /// Specifies whether or not the browser should insert line breaks within words to
    /// prevent text from overflowing its content box. In contrast to word-break,
    /// overflow-wrap will only create a break if an entire word cannot be placed on its
    /// own line without overflowing.
    abstract overflowWrap: U3<ICSSRule, string, string> option with get, set
    /// Controls how extra content exceeding the x-axis of the bounding box of an element
    /// is rendered.
    abstract overflowX: U5<ICSSRule, string, string, string, string> option with get, set
    /// Controls how extra content exceeding the y-axis of the bounding box of an element
    /// is rendered.
    abstract overflowY: U5<ICSSRule, string, string, string, string> option with get, set
    /// The padding optional CSS property sets the required padding space on one to four
    /// sides of an element. The padding area is the space between an element and its
    /// border. Negative values are not allowed but decimal values are permitted. The
    ///   element size is treated as fixed, and the content of the element shifts toward the
    /// center as padding is increased. The padding property is a shorthand to avoid
    /// setting each side separately (padding-top, padding-right, padding-bottom,
    /// padding-left).
    abstract padding: U2<ICSSRule, ICSSPixelUnitRule> option with get, set
    /// The padding-bottom CSS property of an element sets the padding space required on
    /// the bottom of an element. The padding area is the space between the content of the
    /// element and its border. Contrary to margin-bottom values, negative values of
    /// padding-bottom are invalid.
    abstract paddingBottom: U2<ICSSRule, ICSSPixelUnitRule> option with get, set
    /// The padding-left CSS property of an element sets the padding space required on the
    /// left side of an element. The padding area is the space between the content of the
    /// element and its border. Contrary to margin-left values, negative values of
    /// padding-left are invalid.
    abstract paddingLeft: U2<ICSSRule, ICSSPixelUnitRule> option with get, set
    /// The padding-right CSS property of an element sets the padding space required on the
    /// right side of an element. The padding area is the space between the content of the
    /// element and its border. Contrary to margin-right values, negative values of
    /// padding-right are invalid.
    abstract paddingRight: U2<ICSSRule, ICSSPixelUnitRule> option with get, set
    /// The padding-top CSS property of an element sets the padding space required on the
    /// top of an element. The padding area is the space between the content of the element
    /// and its border. Contrary to margin-top values, negative values of padding-top are
    /// invalid.
    abstract paddingTop: U2<ICSSRule, ICSSPixelUnitRule> option with get, set
    /// The page-break-after property is supported in all major browsers. With CSS3,
    ///   page-break-* properties are only aliases of the break-* properties. The CSS3
    /// Fragmentation spec defines breaks for all CSS box fragmentation.
    abstract pageBreakAfter: U2<ICSSRule, string> option with get, set
    /// The page-break-before property sets the page-breaking behavior before an element.
    /// With CSS3, page-break-* properties are only aliases of the break-* properties. The
    /// CSS3 Fragmentation spec defines breaks for all CSS box fragmentation.
    abstract pageBreakBefore: U2<ICSSRule, string> option with get, set
    /// Sets the page-breaking behavior inside an element. With CSS3, page-break-*
    /// properties are only aliases of the break-* properties. The CSS3 Fragmentation spec
    /// defines breaks for all CSS box fragmentation.
    abstract pageBreakInside: U2<ICSSRule, string> option with get, set
    /// The pause property determines how long a speech media agent should pause before and
    /// after presenting an element. It is a shorthand for the pause-before and pause-after
    ///   properties.
    abstract pause: U2<ICSSRule, string> option with get, set
    /// The pause-after property determines how long a speech media agent should pause after
    /// presenting an element. It may be replaced by the shorthand property pause, which
    /// sets pause time before and after.
    abstract pauseAfter: U2<ICSSRule, string> option with get, set
    /// The pause-before property determines how long a speech media agent should pause
    /// before presenting an element. It may be replaced by the shorthand property pause,
    /// which sets pause time before and after.
    abstract pauseBefore: U2<ICSSRule, string> option with get, set
    /// The perspective property defines how far an element is placed from the view on the
    /// z-axis, from the screen to the viewer. Perspective defines how an object is viewed.
    /// In graphic arts, perspective is the representation on a flat surface of what the
    /// viewer's eye would see in a 3D space. (See Wikipedia for more information about
    /// graphical perspective and for related illustrations.)
    /// The illusion of perspective on a flat surface, such as a computer screen, is created
    /// by projecting points on the flat surface as they would appear if the flat surface
    /// were a window through which the viewer was looking at the object. In discussion of
    /// virtual environments, this flat surface is called a projection plane.
    abstract perspective: U2<ICSSRule, string> option with get, set
    /// The perspective-origin property establishes the origin for the perspective property.
    /// It effectively sets the X and Y position at which the viewer appears to be looking
    /// at the children of the element.
    /// When used with perspective, perspective-origin changes the appearance of an object,
    /// as if a viewer were looking at it from a different origin. An object appears
    /// differently if a viewer is looking directly at it versus looking at it from below,
    /// above, or from the side. Thus, the perspective-origin is like a vanishing point.
    /// The default value of perspective-origin is 50% 50%. This displays an object as if
    /// the viewer's eye were positioned directly at the center of the screen, both
    /// top-to-bottom and left-to-right. A value of 0% 0% changes the object as if the
    /// viewer was looking toward the top left angle. A value of 100% 100% changes the
    /// appearance as if viewed toward the bottom right angle.
    abstract perspectiveOrigin: U2<ICSSRule, string> option with get, set
    /// The pointer-events property allows you to control whether an element can be the
    /// target for the pointing device (e.g, mouse, pen) events.
    abstract pointerEvents: U2<ICSSRule, string> option with get, set
    /// The position property controls the type of positioning used by an element within
    /// its parent elements. The effect of the position property depends on a lot of
    /// factors, for example the position property of parent elements.
    abstract position: U6<ICSSRule, string, string, string, string, string> option with get, set
    /// Sets the type of quotation marks for embedded quotations.
    abstract quotes: U2<ICSSRule, string> option with get, set
    /// Controls whether the last region in a chain displays additional 'overset' content
    /// according its default overflow property, or if it displays a fragment of content
    /// as if it were flowing into a subsequent region.
    abstract regionFragment: U2<ICSSRule, string> option with get, set
    /// The rest-after property determines how long a speech media agent should pause after
    /// presenting an element's main content, before presenting that element's exit cue
    /// sound. It may be replaced by the shorthand property rest, which sets rest time
    /// before and after.
    abstract restAfter: U2<ICSSRule, string> option with get, set
    /// The rest-before property determines how long a speech media agent should pause after
    /// presenting an intro cue sound for an element, before presenting that element's main
    /// content. It may be replaced by the shorthand property rest, which sets rest time
    /// before and after.
    abstract restBefore: U2<ICSSRule, string> option with get, set
    /// Specifies the position an element in relation to the right side of the containing
    /// element.
    abstract right: U2<ICSSRule, ICSSPixelUnitRule> option with get, set
    /// Defines the alpha channel threshold used to extract a shape from an image. Can be
    /// thought of as a "minimum opacity" threshold; that is, a value of 0.5 means that the
    /// shape will enclose all the pixels that are more than 50% opaque.
    abstract shapeImageThreshold: U2<ICSSRule, string> option with get, set
    /// A future level of CSS Shapes will define a shape-inside property, which will define
    /// a shape to wrap content within the element. See Editor's Draft
    /// <http://dev.w3.org/csswg/css-shapes/> and CSSWG wiki page on next-level plans
    /// <http://wiki.csswg.org/spec/css-shapes>
    abstract shapeInside: U2<ICSSRule, string> option with get, set
    /// Adds a margin to a shape-outside. In effect, defines a new shape that is the
    /// smallest contour around all the points that are the shape-margin distance outward
    /// perpendicular to each point on the underlying shape. For points where a
    /// perpendicular direction is not defined (e.g., a triangle corner), takes all
    /// points on a circle centered at the point and with a radius of the shape-margin
    /// distance. This property accepts only non-negative values.
    abstract shapeMargin: U2<ICSSRule, string> option with get, set
    /// Declares a shape around which text should be wrapped, with possible modifications
    /// from the shape-margin property. The shape defined by shape-outside and shape-margin
    /// changes the geometry of a float element's float area.
    abstract shapeOutside: U2<ICSSRule, string> option with get, set
    /// The speak property determines whether or not a speech synthesizer will read aloud
    /// the contents of an element.
    abstract speak: U2<ICSSRule, string> option with get, set
    /// The speak-as property determines how the speech synthesizer interprets the content:
    /// words as whole words or as a sequence of letters, numbers as a numerical value or a
    /// sequence of digits, punctuation as pauses in speech or named punctuation characters.
    abstract speakAs: U2<ICSSRule, string> option with get, set
    /// The stroke property in CSS is for adding a border to SVG shapes.
    /// See SVG 1.1 https://www.w3.org/TR/SVG/painting.html#Stroke
    abstract stroke: U2<ICSSRule, string> option with get, set
    /// SVG: Specifies the opacity of the outline on the current object.
    /// See SVG 1.1 https://www.w3.org/TR/SVG/painting.html#StrokeOpacityProperty
    abstract strokeOpacity: U2<ICSSRule, float> option with get, set
    /// SVG: Specifies the width of the outline on the current object.
    /// See SVG 1.1 https://www.w3.org/TR/SVG/painting.html#StrokeWidthProperty
    abstract strokeWidth: U2<ICSSRule, ICSSPixelUnitRule> option with get, set
    /// The tab-size CSS property is used to customise the width of a tab (U+0009) character.
    abstract tabSize: U2<ICSSRule, string> option with get, set
    /// The 'table-layout' property controls the algorithm used to lay out the table cells, rows, and columns.
    abstract tableLayout: U2<ICSSRule, string> option with get, set
    /// The text-align CSS property describes how inline content like text is aligned in its
    /// parent block element. text-align does not control the alignment of block elements
    /// itself, only their inline content.
    abstract textAlign: U2<ICSSRule, string> option with get, set
    /// The text-align-last CSS property describes how the last line of a block element or
    /// a line before line break is aligned in its parent block element.
    abstract textAlignLast: U2<ICSSRule, string> option with get, set
    /// The text-decoration CSS property is used to set the text formatting to underline,
    /// overline, line-through or blink. underline and overline decorations are positioned
    /// under the text, line-through over it.
    abstract textDecoration: U2<ICSSRule, string> option with get, set
    /// Sets the color of any text decoration, such as underlines, overlines, and strike
    /// throughs.
    abstract textDecorationColor: U2<ICSSRule, string> option with get, set
    /// Sets what kind of line decorations are added to an element, such as underlines,
    /// overlines, etc.
    abstract textDecorationLine: U2<ICSSRule, string> option with get, set
    /// Specifies what parts of an element’s content are skipped over when applying any
    /// text decoration.
    abstract textDecorationSkip: U2<ICSSRule, string> option with get, set
    /// This property specifies the style of the text decoration line drawn on the
    /// specified element. The intended meaning for the values are the same as those of
    /// the border-style-properties.
    abstract textDecorationStyle: U2<ICSSRule, string> option with get, set
    /// The text-emphasis property will apply special emphasis marks to the elements text.
    /// Slightly similar to the text-decoration property only that this property can have
    /// affect on the line-height. It also is noted that this is shorthand for
    /// text-emphasis-style and for text-emphasis-color.
    abstract textEmphasis: U2<ICSSRule, string> option with get, set
    /// The text-emphasis-color property specifies the foreground color of the emphasis
    /// marks.
    abstract textEmphasisColor: U2<ICSSRule, string> option with get, set
    /// The text-emphasis-style property applies special emphasis marks to an element's
    /// text.
    abstract textEmphasisStyle: U2<ICSSRule, string> option with get, set
    /// This property helps determine an inline box's block-progression dimension, derived
    /// from the text-height and font-size properties for non-replaced elements, the height
    /// or the width for replaced elements, and the stacked block-progression dimension for
    /// inline-block elements. The block-progression dimension determines the position of
    /// the padding, border and margin for the element.
    abstract textHeight: U2<ICSSRule, string> option with get, set
    /// Specifies the amount of space horizontally that should be left on the first line of
    /// the text of an element. This horizontal spacing is at the beginning of the first
    /// line and is in respect to the left edge of the containing block box.
    abstract textIndent: U2<ICSSRule, string> option with get, set
    /// The text-overflow shorthand CSS property determines how overflowed content that is
    /// not displayed is signaled to the users. It can be clipped, display an ellipsis
    /// ('…', U+2026 HORIZONTAL ELLIPSIS) or a Web author-defined string. It covers the
    /// two long-hand properties text-overflow-mode and text-overflow-ellipsis
    abstract textOverflow: U2<ICSSRule, string> option with get, set
    /// The text-overline property is the shorthand for the text-overline-style,
    /// text-overline-width, text-overline-color, and text-overline-mode properties.
    abstract textOverline: U2<ICSSRule, string> option with get, set
    /// Specifies the line color for the overline text decoration.
    abstract textOverlineColor: U2<ICSSRule, string> option with get, set
    /// Sets the mode for the overline text decoration, determining whether the text
    /// decoration affects the space characters or not.
    abstract textOverlineMode: U2<ICSSRule, string> option with get, set
    /// Specifies the line style for overline text decoration.
    abstract textOverlineStyle: U2<ICSSRule, string> option with get, set
    /// Specifies the line width for the overline text decoration.
    abstract textOverlineWidth: U2<ICSSRule, ICSSPixelUnitRule> option with get, set
    /// The text-rendering CSS property provides information to the browser about how to
    /// optimize when rendering text. Options are: legibility, speed or geometric precision.
    abstract textRendering: U2<ICSSRule, string> option with get, set
    /// The CSS text-shadow property applies one or more drop shadows to the text and
    /// <text-decorations> of an element. Each shadow is specified as an offset from the
    /// text, along with optional color and blur radius values.
    abstract textShadow: U2<ICSSRule, string> option with get, set
    /// This property transforms text for styling purposes. (It has no effect on the
    /// underlying content.)
    abstract textTransform: U2<ICSSRule, string> option with get, set
    /// Unsupported.
    /// This property will add a underline position value to the element that has an
    /// underline defined.
    abstract textUnderlinePosition: U2<ICSSRule, string> option with get, set
    /// After review this should be replaced by text-decoration should it not?
    /// This property will set the underline style for text with a line value for
    /// underline, overline, and line-through.
    abstract textUnderlineStyle: U2<ICSSRule, string> option with get, set
    /// This property specifies how far an absolutely positioned box's top margin edge is
    /// offset below the top edge of the box's containing block. For relatively positioned
    /// boxes, the offset is with respect to the top edges of the box itself (i.e., the box
    /// is given a position in the normal flow, then offset from that position according to
    /// these properties).
    abstract top: U2<ICSSRule, ICSSPixelUnitRule> option with get, set
    /// Determines whether touch input may trigger default behavior supplied by the user
    /// agent, such as panning or zooming.
    abstract touchAction: U2<ICSSRule, string> option with get, set
    /// CSS transforms allow elements styled with CSS to be transformed in two-dimensional
    /// or three-dimensional space. Using this property, elements can be translated,
    /// rotated, scaled, and skewed. The value list may consist of 2D and/or 3D transform
    /// values.
    abstract transform: U2<ICSSRule, string> option with get, set
    /// This property defines the origin of the transformation axes relative to the element
    /// to which the transformation is applied.
    abstract transformOrigin: U2<ICSSRule, string> option with get, set
    /// This property allows you to define the relative position of the origin of the
    /// transformation grid along the z-axis.
    abstract transformOriginZ: U2<ICSSRule, string> option with get, set
    /// This property specifies how nested elements are rendered in 3D space relative to their parent.
    abstract transformStyle: U2<ICSSRule, string> option with get, set
    /// The transition CSS property is a shorthand property for transition-property,
    /// transition-duration, transition-timing-function, and transition-delay. It allows to
    /// define the transition between two states of an element.
    abstract transition: U2<ICSSRule, string> option with get, set
    /// Defines when the transition will start. A value of ‘0s’ means the transition will
    /// execute as soon as the property is changed. Otherwise, the value specifies an
    /// offset from the moment the property is changed, and the transition will delay
    /// execution by that offset.
    abstract transitionDelay: U2<ICSSRule, string> option with get, set
    /// The 'transition-duration' property specifies the length of time a transition
    /// animation takes to complete.
    abstract transitionDuration: U2<ICSSRule, string> option with get, set
    /// The 'transition-property' property specifies the name of the CSS property to which
    /// the transition is applied.
    abstract transitionProperty: U2<ICSSRule, string> option with get, set
    /// Sets the pace of action within a transition
    abstract transitionTimingFunction: U2<ICSSRule, string> option with get, set
    /// The unicode-bidi CSS property specifies the level of embedding with respect to the bidirectional algorithm.
    abstract unicodeBidi: U2<ICSSRule, string> option with get, set
    /// This is for all the high level UX stuff.
    abstract userFocus: U2<ICSSRule, string> option with get, set
    /// For inputing user content
    abstract userInput: U2<ICSSRule, string> option with get, set
    /// Defines the text selection behavior.
    abstract userSelect: U6<ICSSRule, string, string, string, string, string> option with get, set
    /// The vertical-align property controls how inline elements or text are vertically
    /// aligned compared to the baseline. If this property is used on table-cells it
    /// controls the vertical alignment of content of the table cell.
    abstract verticalAlign: U2<ICSSRule, string> option with get, set
    /// The visibility property specifies whether the boxes generated by an element are rendered.
    abstract visibility: U2<ICSSRule, string> option with get, set
    /// The voice-balance property sets the apparent position (in stereo sound) of the synthesized voice for spoken media.
    abstract voiceBalance: U2<ICSSRule, string> option with get, set
    /// The voice-duration property allows the author to explicitly set the amount of time
    /// it should take a speech synthesizer to read an element's content, for example to
    /// allow the speech to be synchronized with other media. With a value of auto (the
    /// default) the length of time it takes to read the content is determined by the
    /// content itself and the voice-rate property.
    abstract voiceDuration: U2<ICSSRule, string> option with get, set
    /// The voice-family property sets the speaker's voice used by a speech media agent to
    /// read an element. The speaker may be specified as a named character (to match a
    /// voice option in the speech reading software) or as a generic description of the
    /// age and gender of the voice. Similar to the font-family property for visual media,
    /// a comma-separated list of fallback options may be given in case the speech reader
    /// does not recognize the character name or cannot synthesize the requested combination
    /// of generic properties.
    abstract voiceFamily: U2<ICSSRule, string> option with get, set
    /// The voice-pitch property sets pitch or tone (high or low) for the synthesized speech
    /// when reading an element; the pitch may be specified absolutely or relative to the
    /// normal pitch for the voice-family used to read the text.
    abstract voicePitch: U2<ICSSRule, string> option with get, set
    /// The voice-range property determines how much variation in pitch or tone will be
    /// created by the speech synthesize when reading an element. Emphasized text,
    /// grammatical structures and punctuation may all be rendered as changes in pitch,
    /// this property determines how strong or obvious those changes are; large ranges are
    /// associated with enthusiastic or emotional speech, while small ranges are associated
    /// with flat or mechanical speech.
    abstract voiceRange: U2<ICSSRule, string> option with get, set
    /// The voice-rate property sets the speed at which the voice synthesized by a speech
    /// media agent will read content.
    abstract voiceRate: U2<ICSSRule, string> option with get, set
    /// The voice-stress property sets the level of vocal emphasis to be used for
    /// synthesized speech reading the element.
    abstract voiceStress: U2<ICSSRule, string> option with get, set
    /// The voice-volume property sets the volume for spoken content in speech media. It
    /// replaces the deprecated volume property.
    abstract voiceVolume: U2<ICSSRule, string> option with get, set
    /// The white-space property controls whether and how white space inside the element is
    /// collapsed, and whether lines may wrap at unforced "soft wrap" opportunities.
    abstract whiteSpace: U2<ICSSRule, string> option with get, set
    /// In paged media, this property defines the mimimum number of lines that must be left
    /// at the top of the second page.
    /// See CSS 3 orphans, widows properties
    /// https://drafts.csswg.org/css-break-3/#widows-orphans
    abstract widows: U2<ICSSRule, float> option with get, set
    /// Specifies the width of the content area of an element. The content area of the element
    /// width does not include the padding, border, and margin of the element.
    abstract width: U2<ICSSRule, ICSSPixelUnitRule> option with get, set
    /// The word-break property is often used when there is long generated content that is
    /// strung together without and spaces or hyphens to beak apart. A common case of this
    /// is when there is a long URL that does not have any hyphens. This case could
    /// potentially cause the breaking of the layout as it could extend past the parent
    /// element.
    abstract wordBreak: U2<ICSSRule, string> option with get, set
    /// The word-spacing CSS property specifies the spacing behavior between "words".
    abstract wordSpacing: U2<ICSSRule, string> option with get, set
    /// An alias of css/properties/overflow-wrap, word-wrap defines whether to break
    /// words when the content exceeds the boundaries of its container.
    abstract wordWrap: U2<ICSSRule, string> option with get, set
    /// Specifies how exclusions affect inline content within block-level elements. Elements
    /// lay out their inline content in their content area but wrap around exclusion areas.
    abstract wrapFlow: U2<ICSSRule, string> option with get, set
    /// Set the value that is used to offset the inner wrap shape from other shapes. Inline
    /// content that intersects a shape with this property will be pushed by this shape's
    /// margin.
    abstract wrapMargin: U2<ICSSRule, string> option with get, set
    /// writing-mode specifies if lines of text are laid out horizontally or vertically,
    /// and the direction which lines of text and blocks progress.
    abstract writingMode: U2<ICSSRule, string> option with get, set
    /// The z-index property specifies the z-order of an element and its descendants.
    /// When elements overlap, z-order determines which one covers the other.
    /// See CSS 2 z-index property https://www.w3.org/TR/CSS2/visuren.html#z-index
    abstract zIndex: U3<ICSSRule, string, float> option with get, set
    /// Sets the initial zoom factor of a document defined by @viewport.
    /// See CSS zoom descriptor https://drafts.csswg.org/css-device-adapt/#zoom-desc
    abstract zoom: U4<ICSSRule, string, float, ICSSPercentageRule> option with get, set
type IRawStyleBase = __IRawStyleBase.IRawStyleBase

/// IStyleObject extends a raw style objects, but allows selectors to be defined
/// under the selectors node.
type [<AllowNullLiteral>] IRawStyle =
    inherit IRawStyleBase
    /// Display name for the style.
    abstract displayName: string option with get, set
    /// Custom selectors for the style.
    abstract selectors: obj option with get, set

type IStyleBase =
    U3<IRawStyle, string, obj> option

[<RequireQualifiedAccess; CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
module IStyleBase =
    let ofIRawStyleOption v: IStyleBase = v |> Microsoft.FSharp.Core.Option.map U3.Case1
    let ofIRawStyle v: IStyleBase = v |> U3.Case1 |> Some
    let isIRawStyle (v: IStyleBase) = match v with None -> false | Some o -> match o with U3.Case1 _ -> true | _ -> false
    let asIRawStyle (v: IStyleBase) = match v with None -> None | Some o -> match o with U3.Case1 o -> Some o | _ -> None
    let ofStringOption v: IStyleBase = v |> Microsoft.FSharp.Core.Option.map U3.Case2
    let ofString v: IStyleBase = v |> U3.Case2 |> Some
    let isString (v: IStyleBase) = match v with None -> false | Some o -> match o with U3.Case2 _ -> true | _ -> false
    let asString (v: IStyleBase) = match v with None -> None | Some o -> match o with U3.Case2 o -> Some o | _ -> None
    let ofObjOption v: IStyleBase = v |> Microsoft.FSharp.Core.Option.map U3.Case3
    let ofObj v: IStyleBase = v |> U3.Case3 |> Some
    let isObj (v: IStyleBase) = match v with None -> false | Some o -> match o with U3.Case3 _ -> true | _ -> false
    let asObj (v: IStyleBase) = match v with None -> None | Some o -> match o with U3.Case3 o -> Some o | _ -> None

type [<AllowNullLiteral>] IStyleBaseArray =
    inherit Array<IStyle>

type IStyle =
    U2<IStyleBase, IStyleBaseArray>

[<RequireQualifiedAccess; CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
module IStyle =
    let ofIStyleBase v: IStyle = v |> U2.Case1
    let isIStyleBase (v: IStyle) = match v with U2.Case1 _ -> true | _ -> false
    let asIStyleBase (v: IStyle) = match v with U2.Case1 o -> Some o | _ -> None
    let ofIStyleBaseArray v: IStyle = v |> U2.Case2
    let isIStyleBaseArray (v: IStyle) = match v with U2.Case2 _ -> true | _ -> false
    let asIStyleBaseArray (v: IStyle) = match v with U2.Case2 o -> Some o | _ -> None
type IStyle = __IStyle.IStyle

type [<AllowNullLiteral>] IStyleSet =
    [<Emit "$0[$1]{{=$2}}">] abstract Item: key: string -> IStyle with get, set
type IStyle = __IStyle.IStyle

type [<AllowNullLiteral>] IExports =
    /// Concatination helper, which can merge class names together. Skips over falsey values.
    abstract mergeStyles: [<ParamArray>] args: ResizeArray<U3<IStyle, ResizeArray<IStyle>, obj> option> -> string
type IStyle = __IStyle.IStyle

type [<AllowNullLiteral>] IExports =
    /// Allows you to pass in 1 or more sets of areas which will return a merged
    /// set of classes.
    abstract mergeStyleSets: [<ParamArray>] cssSets: ResizeArray<obj option> -> obj

type [<AllowNullLiteral>] IExports =
    /// Combine a set of styles together (but does not register css classes.)
    abstract concatStyleSets: [<ParamArray>] args: ResizeArray<U2<'T, obj> option> -> 'T
type IFontFace = __IRawStyleBase.IFontFace

type [<AllowNullLiteral>] IExports =
    /// Registers a font face.
    abstract fontFace: font: IFontFace -> unit

type [<AllowNullLiteral>] IExports =
    /// Registers keyframe definitions.
    abstract keyframes: timeline: KeyframesTimeline -> string

type [<AllowNullLiteral>] KeyframesTimeline =
    [<Emit "$0[$1]{{=$2}}">] abstract Item: key: string -> obj with get, set
type IStyle = __IStyle.IStyle

type [<AllowNullLiteral>] IExports =
    abstract Stylesheet: StylesheetStatic

type [<RequireQualifiedAccess>] InjectionMode =
    | None = 0
    | InsertNode = 1
    | AppendChild = 2

/// Stylesheet config.
type [<AllowNullLiteral>] IStyleSheetConfig =
    /// Injection mode for how rules are inserted.
    abstract injectionMode: InjectionMode option with get, set
    /// Falls back to "css".
    abstract defaultPrefix: string option with get, set
    abstract onInsertRule: (string -> unit) option with get, set

/// Represents the state of styles registered in the page. Abstracts
/// the surface for adding styles to the stylesheet, exposes helpers
/// for reading the styles registered in server rendered scenarios.
type [<AllowNullLiteral>] Stylesheet =
    abstract _lastStyleElement: obj option with get, set
    abstract _styleElement: obj option with get, set
    abstract _rules: obj with get, set
    abstract _config: obj with get, set
    abstract _rulesToInsert: obj with get, set
    abstract _counter: obj with get, set
    abstract _keyToClassName: obj with get, set
    abstract _classNameToArgs: obj with get, set
    /// Configures the stylesheet.
    abstract setConfig: ?config: IStyleSheetConfig -> unit
    /// <summary>Generates a unique classname.</summary>
    /// <param name="displayName">- Optional value to use as a prefix.</param>
    abstract getClassName: ?displayName: string -> string
    /// Used internally to cache information about a class which was
    /// registered with the stylesheet.
    abstract cacheClassName: className: string * key: string * args: ResizeArray<IStyle> * rules: ResizeArray<string> -> unit
    /// Gets the appropriate classname given a key which was previously
    /// registered using cacheClassName.
    abstract classNameFromKey: key: string -> string option
    /// Gets the arguments associated with a given classname which was
    /// previously registered using cacheClassName.
    abstract argsFromClassName: className: string -> ResizeArray<IStyle> option
    /// Gets the arguments associated with a given classname which was
    /// previously registered using cacheClassName.
    abstract insertedRulesFromClassName: className: string -> ResizeArray<string> option
    /// Inserts a css rule into the stylesheet.
    abstract insertRule: rule: string -> unit
    /// Gets all rules registered with the stylesheet; only valid when
    /// using InsertionMode.none.
    abstract getRules: unit -> string
    /// Resets the internal state of the stylesheet. Only used in server
    /// rendered scenarios where we're using InsertionMode.none.
    abstract reset: unit -> unit
    abstract resetKeys: unit -> unit
    abstract _getStyleElement: unit -> unit
    abstract _createStyleElement: unit -> unit

/// Represents the state of styles registered in the page. Abstracts
/// the surface for adding styles to the stylesheet, exposes helpers
/// for reading the styles registered in server rendered scenarios.
type [<AllowNullLiteral>] StylesheetStatic =
    /// Gets the singleton instance.
    abstract getInstance: unit -> Stylesheet
    [<Emit "new $0($1...)">] abstract Create: ?config: IStyleSheetConfig -> Stylesheet
type IStyle = @uifabric_merge_styles_lib_index.IStyle
type IClassNames = __IClassNames.IClassNames
type IStyleFunction = __IStyleFunction.IStyleFunction

type [<AllowNullLiteral>] IExports =
    /// Creates a getClassNames function which calls getStyles given the props, and injects them
    /// into mergeStyleSets.
    abstract classNamesFunction: unit -> (IStyleFunction<'TStyleProps, 'TStyles> -> 'TStyleProps -> IClassNames<'TStyles>)

type [<AllowNullLiteral>] IExports =
    /// This is a polyfill for the React.createRef() api.
    /// For more info on React.createRef() see the official React documentation
    /// on creating and accessing refs.
    abstract createRef: unit -> RefObject<'T>

type [<AllowNullLiteral>] RefObject<'T> =
    [<Emit "$0($1...)">] abstract Invoke: ``component``: 'T option -> unit
    abstract current: 'T option with get, set
    abstract value: 'T option with get, set

type [<AllowNullLiteral>] IExports =
    /// Concatination helper, which can merge class names together. Skips over falsey values.
    abstract css: [<ParamArray>] args: ResizeArray<ICssInput> -> string

/// Dictionary of booleans.
type [<AllowNullLiteral>] IDictionary =
    [<Emit "$0[$1]{{=$2}}">] abstract Item: className: string -> bool with get, set

/// Serializable object.
type [<AllowNullLiteral>] ISerializableObject =
    abstract toString: (unit -> string) option with get, set

type ICssInput =
    U4<string, ISerializableObject, IDictionary, bool> option

[<RequireQualifiedAccess; CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
module ICssInput =
    let ofStringOption v: ICssInput = v |> Microsoft.FSharp.Core.Option.map U4.Case1
    let ofString v: ICssInput = v |> U4.Case1 |> Some
    let isString (v: ICssInput) = match v with None -> false | Some o -> match o with U4.Case1 _ -> true | _ -> false
    let asString (v: ICssInput) = match v with None -> None | Some o -> match o with U4.Case1 o -> Some o | _ -> None
    let ofISerializableObjectOption v: ICssInput = v |> Microsoft.FSharp.Core.Option.map U4.Case2
    let ofISerializableObject v: ICssInput = v |> U4.Case2 |> Some
    let isISerializableObject (v: ICssInput) = match v with None -> false | Some o -> match o with U4.Case2 _ -> true | _ -> false
    let asISerializableObject (v: ICssInput) = match v with None -> None | Some o -> match o with U4.Case2 o -> Some o | _ -> None
    let ofIDictionaryOption v: ICssInput = v |> Microsoft.FSharp.Core.Option.map U4.Case3
    let ofIDictionary v: ICssInput = v |> U4.Case3 |> Some
    let isIDictionary (v: ICssInput) = match v with None -> false | Some o -> match o with U4.Case3 _ -> true | _ -> false
    let asIDictionary (v: ICssInput) = match v with None -> None | Some o -> match o with U4.Case3 o -> Some o | _ -> None
    let ofBoolOption v: ICssInput = v |> Microsoft.FSharp.Core.Option.map U4.Case4
    let ofBool v: ICssInput = v |> U4.Case4 |> Some
    let isBool (v: ICssInput) = match v with None -> false | Some o -> match o with U4.Case4 _ -> true | _ -> false
    let asBool (v: ICssInput) = match v with None -> None | Some o -> match o with U4.Case4 o -> Some o | _ -> None

type [<AllowNullLiteral>] IExports =
    abstract customizable: scope: string * fields: ResizeArray<string> -> (obj -> obj option)
type IRectangle = __IRectangle.IRectangle

type [<AllowNullLiteral>] IExports =
    /// Sets the virtual parent of an element.
    /// Pass `undefined` as the `parent` to clear the virtual parent.
    abstract setVirtualParent: child: HTMLElement * parent: HTMLElement -> unit
    /// Gets the virtual parent given the child element, if it exists.
    abstract getVirtualParent: child: HTMLElement -> HTMLElement option
    /// Gets the element which is the parent of a given element.
    /// If `allowVirtuaParents` is `true`, this method prefers the virtual parent over
    /// real DOM parent when present.
    abstract getParent: child: HTMLElement * ?allowVirtualParents: bool -> HTMLElement option
    /// <summary>Gets the elements which are child elements of the given element.
    /// If `allowVirtualChildren` is `true`, this method enumerates virtual child elements
    /// after the original children.</summary>
    /// <param name="parent"></param>
    /// <param name="allowVirtualChildren"></param>
    abstract getChildren: parent: HTMLElement * ?allowVirtualChildren: bool -> ResizeArray<HTMLElement>
    /// Determines whether or not a parent element contains a given child element.
    /// If `allowVirtualParents` is true, this method may return `true` if the child
    /// has the parent in its virtual element hierarchy.
    abstract elementContains: parent: HTMLElement option * child: HTMLElement option * ?allowVirtualParents: bool -> bool
    /// Helper to set ssr mode to simulate no window object returned from getWindow helper.
    abstract setSSR: isEnabled: bool -> unit
    /// Helper to get the window object.
    abstract getWindow: ?rootElement: Element option -> Window option
    /// Helper to get the document object.
    abstract getDocument: ?rootElement: HTMLElement option -> Document option
    /// Helper to get bounding client rect, works with window.
    abstract getRect: element: U2<HTMLElement, Window> option -> IRectangle option
    /// <summary>Finds the first parent element where the matchFunction returns true</summary>
    /// <param name="element">element to start searching at</param>
    /// <param name="matchFunction">the function that determines if the element is a match</param>
    abstract findElementRecursive: element: HTMLElement option * matchFunction: (HTMLElement -> bool) -> HTMLElement option
    /// <summary>Determines if an element, or any of its ancestors, contian the given attribute</summary>
    /// <param name="element">- element to start searching at</param>
    /// <param name="attribute">- the attribute to search for</param>
    abstract elementContainsAttribute: element: HTMLElement * attribute: string -> string option

type [<AllowNullLiteral>] IExports =
    /// Gets the first focusable element.
    abstract getFirstFocusable: rootElement: HTMLElement * currentElement: HTMLElement * ?includeElementsInFocusZones: bool -> HTMLElement option
    /// Gets the last focusable element.
    abstract getLastFocusable: rootElement: HTMLElement * currentElement: HTMLElement * ?includeElementsInFocusZones: bool -> HTMLElement option
    /// Gets the last tabbable element.
    abstract getLastTabbable: rootElement: HTMLElement * currentElement: HTMLElement * ?includeElementsInFocusZones: bool -> HTMLElement option
    /// <summary>Attempts to focus the first focusable element that is a child or child's child of the rootElement.</summary>
    /// <param name="rootElement">- Element to start the search for a focusable child.</param>
    abstract focusFirstChild: rootElement: HTMLElement -> bool
    /// Traverse to find the previous element.
    abstract getPreviousElement: rootElement: HTMLElement * currentElement: HTMLElement option * ?checkNode: bool * ?suppressParentTraversal: bool * ?traverseChildren: bool * ?includeElementsInFocusZones: bool * ?allowFocusRoot: bool * ?tabbable: bool -> HTMLElement option
    /// Traverse to find the next focusable element.
    abstract getNextElement: rootElement: HTMLElement * currentElement: HTMLElement option * ?checkNode: bool * ?suppressParentTraversal: bool * ?suppressChildTraversal: bool * ?includeElementsInFocusZones: bool * ?allowFocusRoot: bool -> HTMLElement option
    /// Determines if an element is visible.
    abstract isElementVisible: element: HTMLElement option -> bool
    /// Determines if an element can receive focus.
    abstract isElementTabbable: element: HTMLElement * ?checkTabIndex: bool -> bool
    /// Determines if a given element is a focus zone.
    abstract isElementFocusZone: ?element: HTMLElement -> bool
    /// Determines if a given element is a focus sub zone.
    abstract isElementFocusSubZone: ?element: HTMLElement -> bool
    /// Determines if an element, or any of its children, contain focus.
    abstract doesElementContainFocus: element: HTMLElement -> bool
    /// <summary>Determines if an, or any of its ancestors, sepcificies that it doesn't want focus to wrap</summary>
    /// <param name="element">- element to start searching from</param>
    /// <param name="noWrapDataAttribute">- the no wrap data attribute to match (either)</param>
    abstract shouldWrapFocus: element: HTMLElement * noWrapDataAttribute: U2<string, string> -> bool
    /// <summary>Sets focus to an element asynchronously. The focus will be set at the next browser repaint,
    /// meaning it won't cause any extra recalculations. If more than one focusAsync is called during one frame,
    /// only the latest called focusAsync element will actually be focused</summary>
    /// <param name="element">The element to focus</param>
    abstract focusAsync: element: U2<HTMLElement, obj> option -> unit

type [<AllowNullLiteral>] IExports =
    /// <summary>Allows you to hoist methods, except those in an exclusion set from a source object into a destination object.</summary>
    /// <param name="destination">- The instance of the object to hoist the methods onto.</param>
    /// <param name="source">- The instance of the object where the methods are hoisted from.</param>
    /// <param name="exclusions">- (Optional) What methods to exclude from being hoisted.</param>
    abstract hoistMethods: destination: obj option * source: obj option * ?exclusions: ResizeArray<string> -> ResizeArray<string>
    /// <summary>Provides a method for convenience to unhoist hoisted methods.</summary>
    /// <param name="source">- The source object upon which methods were hoisted.</param>
    /// <param name="methodNames">- An array of method names to unhoist.</param>
    abstract unhoistMethods: source: obj option * methodNames: ResizeArray<string> -> unit

type [<AllowNullLiteral>] IExports =
    /// <summary>Allows you to hoist static functions in components.
    /// Created for the purpose of fixing broken static functions in classes
    /// that utilize decorators.</summary>
    /// <param name="source">- The object where the methods are hoisted from.</param>
    /// <param name="dest">- The object to hoist the methods onto.</param>
    abstract hoistStatics: source: 'TSource * dest: 'TDest -> 'TDest
let [<Import("obj","@uifabric/utilities/lib/initializeFocusRects")>] IsFocusVisibleClassName: obj = jsNative

type [<AllowNullLiteral>] IExports =
    /// <summary>Initializes the logic which:
    /// 
    /// 1. Subscribes keydown and mousedown events. (It will only do it once per window,
    ///     so it's safe to call this method multiple times.)
    /// 2. When the user presses directional keyboard keys, adds the 'is-focusVisible' classname
    ///     to the document body.
    /// 3. When the user clicks a mouse button, we remove the classname if it exists.
    /// 
    /// This logic allows components on the page to conditionally render focus treatments only
    /// if the global classname exists, which simplifies logic overall.</summary>
    /// <param name="window"></param>
    abstract initializeFocusRects: ?window: Window -> unit

type [<AllowNullLiteral>] IExports =
    /// Get (up to 2 characters) initials based on display name of the persona.
    abstract getInitials: displayName: string option * isRtl: bool * ?allowPhoneInitials: bool -> string

type [<AllowNullLiteral>] IExports =
    /// Returns true if the keycode is a directional keyboard key.
    abstract isDirectionalKeyCode: which: float -> bool
    /// Adds a keycode to the list of keys that, when pressed, should cause the focus outlines to be visible.
    /// This can be used to add global shortcut keys that directionally move from section to section within
    /// an app or between focus trap zones.
    abstract addDirectionalKeyCode: which: float -> unit

type [<AllowNullLiteral>] IExports =
    /// Gets the rtl state of the page (returns true if in rtl.)
    abstract getLanguage: unit -> string option
    /// Sets the rtl state of the page (by adjusting the dir attribute of the html element.)
    abstract setLanguage: language: string * ?avoidPersisting: bool -> unit
type IPoint = __IPoint.IPoint
type ISize = __ISize.ISize

type [<AllowNullLiteral>] IExports =
    /// Determines the distance between two points.
    abstract getDistanceBetweenPoints: point1: IPoint * point2: IPoint -> float
    /// <summary>Produces a proportionally-scaled version of an input content size when fit to a bounding size.
    /// Given a `contentSize` and a `boundsSize`, this function scales `contentSize` proportionally
    /// using either `contain` or `cover` fit behaviors.
    /// Use this function to pre-calculate the layout for the CSS `object-fit` and `background-fit` behaviors.
    /// With `contain`, the output size must be the largest it can be while completely within the `boundsSize`.
    /// With `cover`, the output size must be the smallest it can be while completely around the `boundsSize`.
    /// By default, there is a `maxScale` value of 1, which prevents the `contentSize` from being scaled larger.</summary>
    /// <param name="options">the options for the bounds fit operation</param>
    abstract fitContentToBounds: options: IFitContentToBoundsOptions -> ISize
    /// <summary>Calculates a number's precision based on the number of trailing
    /// zeros if the number does not have a decimal indicated by a negative
    /// precision. Otherwise, it calculates the number of digits after
    /// the decimal point indicated by a positive precision.</summary>
    /// <param name="value"></param>
    abstract calculatePrecision: value: U2<float, string> -> float
    /// <summary>Rounds a number to a certain level of precision. Accepts negative precision.</summary>
    /// <param name="value">The value that is being rounded.</param>
    /// <param name="precision">The number of decimal places to round the number to</param>
    abstract precisionRound: value: float * precision: float * ?``base``: float -> float

type [<StringEnum>] [<RequireQualifiedAccess>] FitMode =
    | Contain
    | Cover

/// Options for fitting content sizes into bounding sizes.
type [<AllowNullLiteral>] IFitContentToBoundsOptions =
    /// The size of the content to fit to the bounds.
    /// The output will be proportional to this value.
    abstract contentSize: ISize with get, set
    /// The size of the bounds.
    abstract boundsSize: ISize with get, set
    /// The fit mode to apply, either 'contain' or 'cover'.
    abstract mode: FitMode with get, set
    /// An optional maximum scale factor to apply. The default is 1.
    /// Use Infinity for an unbounded resize.
    abstract maxScale: float option with get, set

type [<AllowNullLiteral>] IExports =
    /// Test utility for providing a custom weakmap.
    abstract setMemoizeWeakMap: weakMap: obj option -> unit
    /// Memoize decorator to be used on class methods. Note that the "this" reference
    /// will be inaccessible within a memoized method, given that a cached method's this
    /// would not be instance specific.
    abstract memoize: target: obj option * key: string * descriptor: TypedPropertyDescriptor<'T> -> obj
    /// <summary>Memoizes a function; when you pass in the same parameters multiple times, it returns a cached result.
    /// Be careful when passing in objects, you need to pass in the same INSTANCE for caching to work. Otherwise
    /// it will grow the cache unnecessarily. Also avoid using default values that evaluate functions; passing in
    /// undefined for a value and relying on a default function will execute it the first time, but will not
    /// re-evaluate subsequent times which may have been unexpected.
    /// 
    /// By default, the cache will reset after 100 permutations, to avoid abuse cases where the function is
    /// unintendedly called with unique objects. Without a reset, the cache could grow infinitely, so we safeguard
    /// by resetting. To override this behavior, pass a value of 0 to the maxCacheSize parameter.</summary>
    /// <param name="cb">- The function to memoize.</param>
    /// <param name="maxCacheSize">- Max results to cache. If the cache exceeds this value, it will reset on the next call.</param>
    abstract memoizeFunction: cb: 'T * ?maxCacheSize: float -> 'T

type [<AllowNullLiteral>] IExports =
    /// Compares a to b and b to a.
    abstract shallowCompare: a: 'TA * b: 'TB -> bool
    /// <summary>Makes a resulting merge of a bunch of objects. Pass in the target object followed by 1 or more
    /// objects as arguments and they will be merged sequentially into the target. Note that this will
    /// shallow merge; it will not create new cloned values for target members.</summary>
    /// <param name="target">- Target object to merge following object arguments into.</param>
    /// <param name="args">- One or more objects that will be mixed into the target in the order they are provided.</param>
    abstract assign: target: obj option * [<ParamArray>] args: ResizeArray<obj option> -> obj option
    /// <summary>Makes a resulting merge of a bunch of objects, but allows a filter function to be passed in to filter
    /// the resulting merges. This allows for scenarios where you want to merge "everything except that one thing"
    /// or "properties that start with data-". Note that this will shallow merge; it will not create new cloned
    /// values for target members.</summary>
    /// <param name="isAllowed">- Callback to determine if the given propName is allowed in the result.</param>
    /// <param name="target">- Target object to merge following object arguments into.</param>
    /// <param name="args">- One or more objects that will be mixed into the target in the order they are provided.</param>
    abstract filteredAssign: isAllowed: (string -> bool) * target: obj option * [<ParamArray>] args: ResizeArray<obj option> -> obj option
    /// Generates a unique id in the global scope (this spans across duplicate copies of the same library.)
    abstract getId: ?prefix: string -> string
    abstract mapEnumByName: theEnum: obj option * callback: (string -> U2<string, float> -> 'T option) -> ResizeArray<'T option> option
    /// <summary>Get all values in an object dictionary</summary>
    /// <param name="obj">- The dictionary to get values for</param>
    abstract values: obj: obj option -> ResizeArray<'T>

type [<AllowNullLiteral>] IExports =
    /// <summary>Detects whether an element's content has horizontal overflow</summary>
    /// <param name="element">- Element to check for overflow</param>
    abstract hasHorizontalOverflow: element: HTMLElement -> bool
    /// <summary>Detects whether an element's content has vertical overflow</summary>
    /// <param name="element">- Element to check for overflow</param>
    abstract hasVerticalOverflow: element: HTMLElement -> bool
    /// <summary>Detects whether an element's content has overflow in any direction</summary>
    /// <param name="element">- Element to check for overflow</param>
    abstract hasOverflow: element: HTMLElement -> bool
let [<Import("stringArray","@uifabric/utilities/lib/properties")>] baseElementEvents: ResizeArray<string> = jsNative
let [<Import("stringArray","@uifabric/utilities/lib/properties")>] baseElementProperties: ResizeArray<string> = jsNative
let [<Import("stringArray","@uifabric/utilities/lib/properties")>] htmlElementProperties: ResizeArray<string> = jsNative
let [<Import("stringArray","@uifabric/utilities/lib/properties")>] anchorProperties: ResizeArray<string> = jsNative
let [<Import("stringArray","@uifabric/utilities/lib/properties")>] buttonProperties: ResizeArray<string> = jsNative
let [<Import("stringArray","@uifabric/utilities/lib/properties")>] divProperties: ResizeArray<string> = jsNative
let [<Import("stringArray","@uifabric/utilities/lib/properties")>] inputProperties: ResizeArray<string> = jsNative
let [<Import("stringArray","@uifabric/utilities/lib/properties")>] textAreaProperties: ResizeArray<string> = jsNative
let [<Import("stringArray","@uifabric/utilities/lib/properties")>] imageProperties: ResizeArray<string> = jsNative

type [<AllowNullLiteral>] IExports =
    /// <summary>Gets native supported props for an html element provided the allowance set. Use one of the property
    /// sets defined (divProperties, buttonPropertes, etc) to filter out supported properties from a given
    /// props set. Note that all data- and aria- prefixed attributes will be allowed.
    /// NOTE: getNativeProps should always be applied first when adding props to a react component. The
    /// non-native props should be applied second. This will prevent getNativeProps from overriding your custom props.
    /// For example, if props passed to getNativeProps has an onClick function and getNativeProps is added to
    /// the component after an onClick function is added, then the getNativeProps onClick will override it.</summary>
    /// <param name="props">- The unfiltered input props</param>
    abstract getNativeProps: props: GetNativePropsProps * allowedPropNames: ResizeArray<string> * ?excludedPropNames: ResizeArray<string> -> 'T

type [<AllowNullLiteral>] GetNativePropsProps =
    interface end

type [<AllowNullLiteral>] IExports =
    /// Sets the current base url used for fetching images. 
    abstract getResourceUrl: url: string -> string
    /// Gets the current base url used for fetching images. 
    abstract setBaseUrl: baseUrl: string -> unit

type [<AllowNullLiteral>] IExports =
    /// Gets the rtl state of the page (returns true if in rtl.)
    abstract getRTL: unit -> bool
    /// Sets the rtl state of the page (by adjusting the dir attribute of the html element.)
    abstract setRTL: isRTL: bool * ?persistSetting: bool -> unit
    /// Returns the given key, but flips right/left arrows if necessary.
    abstract getRTLSafeKeyCode: key: float -> float
let [<Import("obj","@uifabric/utilities/lib/scroll")>] DATA_IS_SCROLLABLE_ATTRIBUTE: obj = jsNative

type [<AllowNullLiteral>] IExports =
    /// Disables the body scrolling.
    abstract disableBodyScroll: unit -> unit
    /// Enables the body scrolling.
    abstract enableBodyScroll: unit -> unit
    /// Calculates the width of a scrollbar for the browser/os.
    abstract getScrollbarWidth: unit -> float
    /// Traverses up the DOM for the element with the data-is-scrollable=true attribute, or returns
    /// document.body.
    abstract findScrollableParent: startingElement: HTMLElement option -> HTMLElement option

type [<AllowNullLiteral>] IExports =
    /// String format method, used for scenarios where at runtime you
    /// need to evaluate a formatted string given a tokenized string. This
    /// usually only is needed in localization scenarios.
    /// 
    /// Example "I love {0} every {1}".format("CXP") will result in a Debug Exception.
    abstract format: s: string * [<ParamArray>] values: ResizeArray<obj option> -> string
type IStyleFunction = __IStyleFunction.IStyleFunction

type [<AllowNullLiteral>] IExports =
    /// The styled HOC wrapper allows you to create a functional wrapper around a given component which will resolve
    /// getStyles functional props, and mix customized props passed in using concatStyleSets. Example:
    /// 
    /// ```tsx
    /// export const Toggle = styled(
    ///    ToggleBase,
    ///    {
    ///      getStyles: props => ({ root: { background: 'red' }})
    ///    }
    /// );
    /// ```
    abstract styled: Component: U2<React.ComponentClass<'TComponentProps>, React.StatelessComponent<'TComponentProps>> * getBaseStyles: ('TStyleProps -> 'TStyles) * ?getProps: ('TComponentProps -> obj) -> ('TComponentProps -> JSX.Element)

type [<AllowNullLiteral>] IPropsWithStyles<'TStyleProps, 'TStyles> =
    abstract getStyles: IStyleFunction<'TStyleProps, 'TStyles> option with get, set
    abstract subComponents: obj option with get, set
type IRawStyle = @uifabric_merge_styles_lib_index.IRawStyle

/// All Fabric standard animations, exposed as json objects referencing predefined
/// keyframes. These objects can be mixed in with other class definitions.
type [<AllowNullLiteral>] IAnimationStyles =
    abstract slideRightIn10: IRawStyle with get, set
    abstract slideRightIn20: IRawStyle with get, set
    abstract slideRightIn40: IRawStyle with get, set
    abstract slideRightIn400: IRawStyle with get, set
    abstract slideLeftIn10: IRawStyle with get, set
    abstract slideLeftIn20: IRawStyle with get, set
    abstract slideLeftIn40: IRawStyle with get, set
    abstract slideLeftIn400: IRawStyle with get, set
    abstract slideUpIn10: IRawStyle with get, set
    abstract slideUpIn20: IRawStyle with get, set
    abstract slideDownIn10: IRawStyle with get, set
    abstract slideDownIn20: IRawStyle with get, set
    abstract slideRightOut10: IRawStyle with get, set
    abstract slideRightOut20: IRawStyle with get, set
    abstract slideRightOut40: IRawStyle with get, set
    abstract slideRightOut400: IRawStyle with get, set
    abstract slideLeftOut10: IRawStyle with get, set
    abstract slideLeftOut20: IRawStyle with get, set
    abstract slideLeftOut40: IRawStyle with get, set
    abstract slideLeftOut400: IRawStyle with get, set
    abstract slideUpOut10: IRawStyle with get, set
    abstract slideUpOut20: IRawStyle with get, set
    abstract slideDownOut10: IRawStyle with get, set
    abstract slideDownOut20: IRawStyle with get, set
    abstract scaleUpIn100: IRawStyle with get, set
    abstract scaleDownIn100: IRawStyle with get, set
    abstract scaleUpOut103: IRawStyle with get, set
    abstract scaleDownOut98: IRawStyle with get, set
    abstract fadeIn100: IRawStyle with get, set
    abstract fadeIn200: IRawStyle with get, set
    abstract fadeIn400: IRawStyle with get, set
    abstract fadeIn500: IRawStyle with get, set
    abstract fadeOut100: IRawStyle with get, set
    abstract fadeOut200: IRawStyle with get, set
    abstract fadeOut400: IRawStyle with get, set
    abstract fadeOut500: IRawStyle with get, set
    abstract rotate90deg: IRawStyle with get, set
    abstract rotateN90deg: IRawStyle with get, set

type [<AllowNullLiteral>] IAnimationVariables =
    abstract easeFunction1: string with get, set
    abstract easeFunction2: string with get, set
    abstract durationValue1: string with get, set
    abstract durationValue2: string with get, set
    abstract durationValue3: string with get, set
    abstract durationValue4: string with get, set
type IRawStyle = @uifabric_merge_styles_lib_index.IRawStyle

/// UI Fabric font set.
type [<AllowNullLiteral>] IFontStyles =
    abstract tiny: IRawStyle with get, set
    abstract xSmall: IRawStyle with get, set
    abstract small: IRawStyle with get, set
    abstract smallPlus: IRawStyle with get, set
    abstract medium: IRawStyle with get, set
    abstract mediumPlus: IRawStyle with get, set
    abstract large: IRawStyle with get, set
    abstract xLarge: IRawStyle with get, set
    abstract xxLarge: IRawStyle with get, set
    abstract superLarge: IRawStyle with get, set
    abstract mega: IRawStyle with get, set

/// UI Fabric color palette.
type [<AllowNullLiteral>] IPalette =
    /// Color code for themeDarker.
    abstract themeDarker: string with get, set
    /// Color code for themeDark.
    abstract themeDark: string with get, set
    /// Color code for themeDarkAlt.
    abstract themeDarkAlt: string with get, set
    /// Color code for themePrimary.
    abstract themePrimary: string with get, set
    /// Color code for themeSecondary.
    abstract themeSecondary: string with get, set
    /// Color code for themeTertiary.
    abstract themeTertiary: string with get, set
    /// Color code for themeLight.
    abstract themeLight: string with get, set
    /// Color code for themeLighter.
    abstract themeLighter: string with get, set
    /// Color code for themeLighterAlt.
    abstract themeLighterAlt: string with get, set
    /// Color code for the strongest color, which is black in the default theme. This is a very light color in inverted themes.
    abstract black: string with get, set
    /// Color code for blackTranslucent40.
    abstract blackTranslucent40: string with get, set
    /// Color code for neutralDark.
    abstract neutralDark: string with get, set
    /// Color code for neutralPrimary.
    abstract neutralPrimary: string with get, set
    /// Color code for neutralPrimaryAlt.
    abstract neutralPrimaryAlt: string with get, set
    /// Color code for neutralSecondary.
    abstract neutralSecondary: string with get, set
    /// Color code for neutralTertiary.
    abstract neutralTertiary: string with get, set
    /// Color code for neutralTertiaryAlt.
    abstract neutralTertiaryAlt: string with get, set
    /// Color code for neutralQuaternary.
    abstract neutralQuaternary: string with get, set
    /// Color code for neutralQuaternaryAlt.
    abstract neutralQuaternaryAlt: string with get, set
    /// Color code for neutralLight.
    abstract neutralLight: string with get, set
    /// Color code for neutralLighter.
    abstract neutralLighter: string with get, set
    /// Color code for neutralLighterAlt.
    abstract neutralLighterAlt: string with get, set
    /// Color code for the accent.
    abstract accent: string with get, set
    /// Color code for the softest color, which is white in the default theme. This is a very dark color in dark themes.
    /// This is the page background.
    abstract white: string with get, set
    /// Color code for whiteTranslucent40
    abstract whiteTranslucent40: string with get, set
    /// Color code for yellow.
    abstract yellow: string with get, set
    /// Color code for yellowLight.
    abstract yellowLight: string with get, set
    /// Color code for orange.
    abstract orange: string with get, set
    /// Color code for orangeLight.
    abstract orangeLight: string with get, set
    /// Color code for orangeLighter.
    abstract orangeLighter: string with get, set
    /// Color code for redDark.
    abstract redDark: string with get, set
    /// Color code for red.
    abstract red: string with get, set
    /// Color code for magentaDark.
    abstract magentaDark: string with get, set
    /// Color code for magenta.
    abstract magenta: string with get, set
    /// Color code for magentaLight.
    abstract magentaLight: string with get, set
    /// Color code for purpleDark.
    abstract purpleDark: string with get, set
    /// Color code for purple.
    abstract purple: string with get, set
    /// Color code for purpleLight.
    abstract purpleLight: string with get, set
    /// Color code for blueDark.
    abstract blueDark: string with get, set
    /// Color code for blueMid.
    abstract blueMid: string with get, set
    /// Color code for blue.
    abstract blue: string with get, set
    /// Color code for blueLight.
    abstract blueLight: string with get, set
    /// Color code for tealDark.
    abstract tealDark: string with get, set
    /// Color code for teal.
    abstract teal: string with get, set
    /// Color code for tealLight.
    abstract tealLight: string with get, set
    /// Color code for greenDark.
    abstract greenDark: string with get, set
    /// Color code for green.
    abstract green: string with get, set
    /// Color code for greenLight.
    abstract greenLight: string with get, set

/// The collection of semantic slots for colors used in themes.
/// 
/// ## Naming Convention
/// 
/// The name of a semantic slot can quickly tell you how it’s meant to be used. It generally follows this format:
/// 
/// [category name][element name][checked state][hovered/pressed/disabled state]
/// [category name] – The “family” that this slot belongs to.
/// [element name] – The name of the thing being targeted, such as the background or border.
/// [checked state] – Whether the thing is checked. We assume things are unchecked by default, so no need to specify the unchecked state.
/// (We used “checked” to refer to anything that is on, selected, toggled, highlighted, emphasized, etc.)
/// [hovered/pressed/disabled state] – One of these states, if applicable. Each of these states are mutually exclusive.
/// Pressed styles overwrite hovered styles, and disabled elements cannot be hovered or pressed.
/// 
/// ## Base Slots
/// 
/// A basic set of slots that provide many default body styles, such as text, subtext, disabled colors, and so on.
/// If a category doesn't provide the slot you're looking for, use one from this category.
/// For example, the placeholder text on a text input field has no corresponding slot in its category,
/// so you'd use the bodySubtextColor from this category.
/// 
/// ## Invariants
/// 
/// When color has meaning, we do not want to change the color much theme to theme. For example, we
/// will always want errors to be some shade of red, but we will need to tweak the exact shade so it's
/// legible depending on whether it's an inverted theme or not.
/// Invariant colors should almost never be changed by the theme, the defaults should suffice.
/// 
/// ## Input Controls
/// 
/// This category contains input components commonly used to denote state, including radio buttons,
/// check boxes, toggle switches, sliders, progress bars, and more.
/// 
/// ## Buttons
/// 
/// Buttons! And all the flavors thereof.
/// 
/// ## Menus
/// 
/// Any kind of popup menus uses this category.
/// 
/// ## Lists
/// 
/// Lists differ from menus in that they are designed to show infinite amounts of items, often scroll,
/// and have a large and complex interaction surface.
/// This category covers all kinds of lists, whether they're typical one-item-per-row lists (like DetailsList) or ones with a tiled layout.
type [<AllowNullLiteral>] ISemanticColors =
    /// The default color for backgrounds.
    abstract bodyBackground: string with get, set
    /// A special semantic slot that will always be the same or darker (not necessarily stronger) than the bodyBackground slot, even in
    /// an inverted theme. This is used for zones near the edge of the page, to provide a vignetting effect. This is especially effective
    /// with zones near the edge of the page in stronger themes or if it uses a variant theme.
    abstract bodyFrameBackground: string with get, set
    /// The default color for text.
    abstract bodyText: string with get, set
    /// Checked text color, e.g. selected menu item text.
    abstract bodyTextChecked: string with get, set
    /// De-emphasized text; e.g. metadata, captions, placeholder text.
    abstract bodySubtext: string with get, set
    /// Divider lines; e.g. lines that separate sections in a menu, an <HR> element.
    abstract bodyDivider: string with get, set
    /// The color of a link.
    abstract link: string with get, set
    /// The color of a hovered link. Also used when the link is active.
    abstract linkHovered: string with get, set
    /// The default color for backgrounds of disabled controls; e.g. disabled text field.
    abstract disabledBackground: string with get, set
    /// The default color for disabled text on top of disabledBackground; e.g. text in a disabled text field, disabled button text.
    abstract disabledText: string with get, set
    /// The default color for disabled text on the default background (bodyBackground).
    abstract disabledBodyText: string with get, set
    /// Disabled de-emphasized text, for use on disabledBackground.
    abstract disabledSubtext: string with get, set
    /// The color of the outline around focused controls that don't already have a border; e.g. menu items
    abstract focusBorder: string with get, set
    /// The default color of error text, used on bodyBackground.
    abstract errorText: string with get, set
    /// The color of text on errorBackground, warningBackground, blockingBackground, or successBackground.
    abstract warningText: string with get, set
    /// The background for errors, if necessary, or highlighting the section of the page where the error is present.
    abstract errorBackground: string with get, set
    /// Background for blocking issues, which is more severe than a warning, but not as bad as an error.
    abstract blockingBackground: string with get, set
    /// Background for warning messages.
    abstract warningBackground: string with get, set
    /// Foreground color for warning highlights
    abstract warningHighlight: string with get, set
    /// Background for success
    abstract successBackground: string with get, set
    /// The border of a large input control in its resting, state; e.g. the box of dropdown.
    abstract inputBorder: string with get, set
    /// The border of a small input control in its resting unchecked state; e.g. the box of an unchecked checkbox.
    abstract smallInputBorder: string with get, set
    /// The border color of a large hovered input control, such as textbox.
    abstract inputBorderHovered: string with get, set
    /// The background color of an input, e.g. textbox background.
    abstract inputBackground: string with get, set
    /// The background of a checked control; e.g. checked radio button's dot, checked toggle's background.
    abstract inputBackgroundChecked: string with get, set
    /// The background of a checked and hovered control; e.g. checked checkbox's background color on hover.
    abstract inputBackgroundCheckedHovered: string with get, set
    /// The foreground of a checked control; e.g. checked checkbox's checkmark color, checked toggle's thumb color,
    /// radio button's background color around the dot.
    abstract inputForegroundChecked: string with get, set
    /// The alternate focus border color for elements that already have a border; e.g. text field borders on focus.
    abstract inputFocusBorderAlt: string with get, set
    /// The color of placeholder text.
    abstract inputPlaceholderText: string with get, set
    /// Background of a standard button
    abstract buttonBackground: string with get, set
    /// Background of a hovered standard button
    abstract buttonBackgroundHovered: string with get, set
    /// Background of a checked standard button; e.g. bold/italicize/underline text button in toolbar
    abstract buttonBackgroundChecked: string with get, set
    /// Background of a checked and hovered standard button; e.g. bold/italicize/underline text button in toolbar
    abstract buttonBackgroundCheckedHovered: string with get, set
    /// Border of a standard button
    abstract buttonBorder: string with get, set
    /// Color of text in a standard button
    abstract buttonText: string with get, set
    /// Color of text in a hovered standard button
    abstract buttonTextHovered: string with get, set
    /// Color of text in a checked standard button
    abstract buttonTextChecked: string with get, set
    /// Color of text in a checked and hovered standard button
    abstract buttonTextCheckedHovered: string with get, set
    /// The background of a hovered menu item.
    abstract menuItemBackgroundHovered: string with get, set
    /// The default colors of icons in menus.
    abstract menuIcon: string with get, set
    /// The headers in menus that denote title of a section.
    abstract menuHeader: string with get, set
    /// The background color for the entire list.
    abstract listBackground: string with get, set
    /// The default text color for list item titles and text in column fields.
    abstract listText: string with get, set
    /// The background color of a hovered list item.
    abstract listItemBackgroundHovered: string with get, set
    /// The background color of a checked list item.
    abstract listItemBackgroundChecked: string with get, set
    /// The background color of a checked and hovered list item.
    abstract listItemBackgroundCheckedHovered: string with get, set
    /// The background color for a hovered list header.
    abstract listHeaderBackgroundHovered: string with get, set
    /// The background color for a pressed list header.
    abstract listHeaderBackgroundPressed: string with get, set
    abstract listTextColor: string with get, set
    abstract menuItemBackgroundChecked: string with get, set
type IPalette = __IPalette.IPalette
type IFontStyles = __IFontStyles.IFontStyles
type ISemanticColors = __ISemanticColors.ISemanticColors

type [<AllowNullLiteral>] ITheme =
    abstract palette: IPalette with get, set
    abstract fonts: IFontStyles with get, set
    abstract semanticColors: ISemanticColors with get, set
    abstract isInverted: bool with get, set
    /// This setting is for a very narrow use case and you probably don't need to worry about,
    /// unless you share a environment with others that also use fabric.
    /// It is used for disabling global styles on fabric components. This will prevent global
    /// overrides that might have been set by other fabric users from applying to your components.
    /// When you set this setting to `true` on your theme the components in the subtree of your
    /// Customizer will not get the global styles applied to them.
    abstract disableGlobalClassNames: bool with get, set

type [<AllowNullLiteral>] IPartialTheme =
    abstract palette: obj option with get, set
    abstract fonts: obj option with get, set
    abstract semanticColors: obj option with get, set
    abstract isInverted: bool option with get, set
    abstract disableGlobalClassNames: bool option with get, set
let [<Import("IColorClassNames","@uifabric/styling/lib/classNames/ColorClassNames")>] ColorClassNames: IColorClassNames = jsNative

type [<AllowNullLiteral>] IColorClassNames =
    abstract themeDarker: string with get, set
    abstract themeDarkerHover: string with get, set
    abstract themeDarkerBackground: string with get, set
    abstract themeDarkerBackgroundHover: string with get, set
    abstract themeDarkerBorder: string with get, set
    abstract themeDarkerBorderHover: string with get, set
    abstract themeDark: string with get, set
    abstract themeDarkHover: string with get, set
    abstract themeDarkBackground: string with get, set
    abstract themeDarkBackgroundHover: string with get, set
    abstract themeDarkBorder: string with get, set
    abstract themeDarkBorderHover: string with get, set
    abstract themeDarkAlt: string with get, set
    abstract themeDarkAltHover: string with get, set
    abstract themeDarkAltBackground: string with get, set
    abstract themeDarkAltBackgroundHover: string with get, set
    abstract themeDarkAltBorder: string with get, set
    abstract themeDarkAltBorderHover: string with get, set
    abstract themePrimary: string with get, set
    abstract themePrimaryHover: string with get, set
    abstract themePrimaryBackground: string with get, set
    abstract themePrimaryBackgroundHover: string with get, set
    abstract themePrimaryBorder: string with get, set
    abstract themePrimaryBorderHover: string with get, set
    abstract themeSecondary: string with get, set
    abstract themeSecondaryHover: string with get, set
    abstract themeSecondaryBackground: string with get, set
    abstract themeSecondaryBackgroundHover: string with get, set
    abstract themeSecondaryBorder: string with get, set
    abstract themeSecondaryBorderHover: string with get, set
    abstract themeTertiary: string with get, set
    abstract themeTertiaryHover: string with get, set
    abstract themeTertiaryBackground: string with get, set
    abstract themeTertiaryBackgroundHover: string with get, set
    abstract themeTertiaryBorder: string with get, set
    abstract themeTertiaryBorderHover: string with get, set
    abstract themeLight: string with get, set
    abstract themeLightHover: string with get, set
    abstract themeLightBackground: string with get, set
    abstract themeLightBackgroundHover: string with get, set
    abstract themeLightBorder: string with get, set
    abstract themeLightBorderHover: string with get, set
    abstract themeLighter: string with get, set
    abstract themeLighterHover: string with get, set
    abstract themeLighterBackground: string with get, set
    abstract themeLighterBackgroundHover: string with get, set
    abstract themeLighterBorder: string with get, set
    abstract themeLighterBorderHover: string with get, set
    abstract themeLighterAlt: string with get, set
    abstract themeLighterAltHover: string with get, set
    abstract themeLighterAltBackground: string with get, set
    abstract themeLighterAltBackgroundHover: string with get, set
    abstract themeLighterAltBorder: string with get, set
    abstract themeLighterAltBorderHover: string with get, set
    abstract black: string with get, set
    abstract blackHover: string with get, set
    abstract blackBackground: string with get, set
    abstract blackBackgroundHover: string with get, set
    abstract blackBorder: string with get, set
    abstract blackBorderHover: string with get, set
    abstract blackTranslucent40: string with get, set
    abstract blackTranslucent40Hover: string with get, set
    abstract blackTranslucent40Background: string with get, set
    abstract blackTranslucent40BackgroundHover: string with get, set
    abstract blackTranslucent40Border: string with get, set
    abstract blackTranslucent40BorderHover: string with get, set
    abstract neutralDark: string with get, set
    abstract neutralDarkHover: string with get, set
    abstract neutralDarkBackground: string with get, set
    abstract neutralDarkBackgroundHover: string with get, set
    abstract neutralDarkBorder: string with get, set
    abstract neutralDarkBorderHover: string with get, set
    abstract neutralPrimary: string with get, set
    abstract neutralPrimaryHover: string with get, set
    abstract neutralPrimaryBackground: string with get, set
    abstract neutralPrimaryBackgroundHover: string with get, set
    abstract neutralPrimaryBorder: string with get, set
    abstract neutralPrimaryBorderHover: string with get, set
    abstract neutralPrimaryAlt: string with get, set
    abstract neutralPrimaryAltHover: string with get, set
    abstract neutralPrimaryAltBackground: string with get, set
    abstract neutralPrimaryAltBackgroundHover: string with get, set
    abstract neutralPrimaryAltBorder: string with get, set
    abstract neutralPrimaryAltBorderHover: string with get, set
    abstract neutralSecondary: string with get, set
    abstract neutralSecondaryHover: string with get, set
    abstract neutralSecondaryBackground: string with get, set
    abstract neutralSecondaryBackgroundHover: string with get, set
    abstract neutralSecondaryBorder: string with get, set
    abstract neutralSecondaryBorderHover: string with get, set
    abstract neutralSecondaryAlt: string with get, set
    abstract neutralSecondaryAltHover: string with get, set
    abstract neutralSecondaryAltBackground: string with get, set
    abstract neutralSecondaryAltBackgroundHover: string with get, set
    abstract neutralSecondaryAltBorder: string with get, set
    abstract neutralSecondaryAltBorderHover: string with get, set
    abstract neutralTertiary: string with get, set
    abstract neutralTertiaryHover: string with get, set
    abstract neutralTertiaryBackground: string with get, set
    abstract neutralTertiaryBackgroundHover: string with get, set
    abstract neutralTertiaryBorder: string with get, set
    abstract neutralTertiaryBorderHover: string with get, set
    abstract neutralTertiaryAlt: string with get, set
    abstract neutralTertiaryAltHover: string with get, set
    abstract neutralTertiaryAltBackground: string with get, set
    abstract neutralTertiaryAltBackgroundHover: string with get, set
    abstract neutralTertiaryAltBorder: string with get, set
    abstract neutralTertiaryAltBorderHover: string with get, set
    abstract neutralQuaternary: string with get, set
    abstract neutralQuaternaryHover: string with get, set
    abstract neutralQuaternaryBackground: string with get, set
    abstract neutralQuaternaryBackgroundHover: string with get, set
    abstract neutralQuaternaryBorder: string with get, set
    abstract neutralQuaternaryBorderHover: string with get, set
    abstract neutralQuaternaryAlt: string with get, set
    abstract neutralQuaternaryAltHover: string with get, set
    abstract neutralQuaternaryAltBackground: string with get, set
    abstract neutralQuaternaryAltBackgroundHover: string with get, set
    abstract neutralQuaternaryAltBorder: string with get, set
    abstract neutralQuaternaryAltBorderHover: string with get, set
    abstract neutralLight: string with get, set
    abstract neutralLightHover: string with get, set
    abstract neutralLightBackground: string with get, set
    abstract neutralLightBackgroundHover: string with get, set
    abstract neutralLightBorder: string with get, set
    abstract neutralLightBorderHover: string with get, set
    abstract neutralLighter: string with get, set
    abstract neutralLighterHover: string with get, set
    abstract neutralLighterBackground: string with get, set
    abstract neutralLighterBackgroundHover: string with get, set
    abstract neutralLighterBorder: string with get, set
    abstract neutralLighterBorderHover: string with get, set
    abstract neutralLighterAlt: string with get, set
    abstract neutralLighterAltHover: string with get, set
    abstract neutralLighterAltBackground: string with get, set
    abstract neutralLighterAltBackgroundHover: string with get, set
    abstract neutralLighterAltBorder: string with get, set
    abstract neutralLighterAltBorderHover: string with get, set
    abstract white: string with get, set
    abstract whiteHover: string with get, set
    abstract whiteBackground: string with get, set
    abstract whiteBackgroundHover: string with get, set
    abstract whiteBorder: string with get, set
    abstract whiteBorderHover: string with get, set
    abstract whiteTranslucent40: string with get, set
    abstract whiteTranslucent40Hover: string with get, set
    abstract whiteTranslucent40Background: string with get, set
    abstract whiteTranslucent40BackgroundHover: string with get, set
    abstract whiteTranslucent40Border: string with get, set
    abstract whiteTranslucent40BorderHover: string with get, set
    abstract yellow: string with get, set
    abstract yellowHover: string with get, set
    abstract yellowBackground: string with get, set
    abstract yellowBackgroundHover: string with get, set
    abstract yellowBorder: string with get, set
    abstract yellowBorderHover: string with get, set
    abstract yellowLight: string with get, set
    abstract yellowLightHover: string with get, set
    abstract yellowLightBackground: string with get, set
    abstract yellowLightBackgroundHover: string with get, set
    abstract yellowLightBorder: string with get, set
    abstract yellowLightBorderHover: string with get, set
    abstract orange: string with get, set
    abstract orangeHover: string with get, set
    abstract orangeBackground: string with get, set
    abstract orangeBackgroundHover: string with get, set
    abstract orangeBorder: string with get, set
    abstract orangeBorderHover: string with get, set
    abstract orangeLight: string with get, set
    abstract orangeLightHover: string with get, set
    abstract orangeLightBackground: string with get, set
    abstract orangeLightBackgroundHover: string with get, set
    abstract orangeLightBorder: string with get, set
    abstract orangeLightBorderHover: string with get, set
    abstract orangeLighter: string with get, set
    abstract orangeLighterHover: string with get, set
    abstract orangeLighterBackground: string with get, set
    abstract orangeLighterBackgroundHover: string with get, set
    abstract orangeLighterBorder: string with get, set
    abstract orangeLighterBorderHover: string with get, set
    abstract redDark: string with get, set
    abstract redDarkHover: string with get, set
    abstract redDarkBackground: string with get, set
    abstract redDarkBackgroundHover: string with get, set
    abstract redDarkBorder: string with get, set
    abstract redDarkBorderHover: string with get, set
    abstract red: string with get, set
    abstract redHover: string with get, set
    abstract redBackground: string with get, set
    abstract redBackgroundHover: string with get, set
    abstract redBorder: string with get, set
    abstract redBorderHover: string with get, set
    abstract magentaDark: string with get, set
    abstract magentaDarkHover: string with get, set
    abstract magentaDarkBackground: string with get, set
    abstract magentaDarkBackgroundHover: string with get, set
    abstract magentaDarkBorder: string with get, set
    abstract magentaDarkBorderHover: string with get, set
    abstract magenta: string with get, set
    abstract magentaHover: string with get, set
    abstract magentaBackground: string with get, set
    abstract magentaBackgroundHover: string with get, set
    abstract magentaBorder: string with get, set
    abstract magentaBorderHover: string with get, set
    abstract magentaLight: string with get, set
    abstract magentaLightHover: string with get, set
    abstract magentaLightBackground: string with get, set
    abstract magentaLightBackgroundHover: string with get, set
    abstract magentaLightBorder: string with get, set
    abstract magentaLightBorderHover: string with get, set
    abstract purpleDark: string with get, set
    abstract purpleDarkHover: string with get, set
    abstract purpleDarkBackground: string with get, set
    abstract purpleDarkBackgroundHover: string with get, set
    abstract purpleDarkBorder: string with get, set
    abstract purpleDarkBorderHover: string with get, set
    abstract purple: string with get, set
    abstract purpleHover: string with get, set
    abstract purpleBackground: string with get, set
    abstract purpleBackgroundHover: string with get, set
    abstract purpleBorder: string with get, set
    abstract purpleBorderHover: string with get, set
    abstract purpleLight: string with get, set
    abstract purpleLightHover: string with get, set
    abstract purpleLightBackground: string with get, set
    abstract purpleLightBackgroundHover: string with get, set
    abstract purpleLightBorder: string with get, set
    abstract purpleLightBorderHover: string with get, set
    abstract blueDark: string with get, set
    abstract blueDarkHover: string with get, set
    abstract blueDarkBackground: string with get, set
    abstract blueDarkBackgroundHover: string with get, set
    abstract blueDarkBorder: string with get, set
    abstract blueDarkBorderHover: string with get, set
    abstract blueMid: string with get, set
    abstract blueMidHover: string with get, set
    abstract blueMidBackground: string with get, set
    abstract blueMidBackgroundHover: string with get, set
    abstract blueMidBorder: string with get, set
    abstract blueMidBorderHover: string with get, set
    abstract blue: string with get, set
    abstract blueHover: string with get, set
    abstract blueBackground: string with get, set
    abstract blueBackgroundHover: string with get, set
    abstract blueBorder: string with get, set
    abstract blueBorderHover: string with get, set
    abstract blueLight: string with get, set
    abstract blueLightHover: string with get, set
    abstract blueLightBackground: string with get, set
    abstract blueLightBackgroundHover: string with get, set
    abstract blueLightBorder: string with get, set
    abstract blueLightBorderHover: string with get, set
    abstract tealDark: string with get, set
    abstract tealDarkHover: string with get, set
    abstract tealDarkBackground: string with get, set
    abstract tealDarkBackgroundHover: string with get, set
    abstract tealDarkBorder: string with get, set
    abstract tealDarkBorderHover: string with get, set
    abstract teal: string with get, set
    abstract tealHover: string with get, set
    abstract tealBackground: string with get, set
    abstract tealBackgroundHover: string with get, set
    abstract tealBorder: string with get, set
    abstract tealBorderHover: string with get, set
    abstract tealLight: string with get, set
    abstract tealLightHover: string with get, set
    abstract tealLightBackground: string with get, set
    abstract tealLightBackgroundHover: string with get, set
    abstract tealLightBorder: string with get, set
    abstract tealLightBorderHover: string with get, set
    abstract greenDark: string with get, set
    abstract greenDarkHover: string with get, set
    abstract greenDarkBackground: string with get, set
    abstract greenDarkBackgroundHover: string with get, set
    abstract greenDarkBorder: string with get, set
    abstract greenDarkBorderHover: string with get, set
    abstract green: string with get, set
    abstract greenHover: string with get, set
    abstract greenBackground: string with get, set
    abstract greenBackgroundHover: string with get, set
    abstract greenBorder: string with get, set
    abstract greenBorderHover: string with get, set
    abstract greenLight: string with get, set
    abstract greenLightHover: string with get, set
    abstract greenLightBackground: string with get, set
    abstract greenLightBackgroundHover: string with get, set
    abstract greenLightBorder: string with get, set
    abstract greenLightBorderHover: string with get, set
type IAnimationStyles = ___interfaces_index.IAnimationStyles
type IAnimationVariables = ___interfaces_index.IAnimationVariables
let [<Import("IAnimationVariables","@uifabric/styling/lib/styles/AnimationStyles")>] AnimationVariables: IAnimationVariables = jsNative
let [<Import("IAnimationStyles","@uifabric/styling/lib/styles/AnimationStyles")>] AnimationStyles: IAnimationStyles = jsNative
type IFontStyles = ___interfaces_index.IFontStyles
let [<Import("IFontStyles","@uifabric/styling/lib/styles/DefaultFontStyles")>] DefaultFontStyles: IFontStyles = jsNative

type [<AllowNullLiteral>] IExports =
    abstract registerDefaultFontFaces: baseUrl: string -> unit
type IFontStyles = ___interfaces_index.IFontStyles

type [<AllowNullLiteral>] IExports =
    abstract createFontStyles: localeCode: string option -> IFontStyles

module LocalizedFontNames =

    type [<AllowNullLiteral>] IExports =
        abstract Arabic: obj
        abstract Cyrillic: obj
        abstract EastEuropean: obj
        abstract Greek: obj
        abstract Hebrew: obj
        abstract Thai: obj
        abstract Vietnamese: obj
        abstract WestEuropean: obj
        abstract Selawik: obj

module LocalizedFontFamilies =

    type [<AllowNullLiteral>] IExports =
        abstract Arabic: string
        abstract ChineseSimplified: obj
        abstract ChineseTraditional: obj
        abstract Cyrillic: string
        abstract EastEuropean: string
        abstract Greek: string
        abstract Hebrew: string
        abstract Hindi: obj
        abstract Japanese: obj
        abstract Korean: obj
        abstract Selawik: string
        abstract Thai: obj
        abstract Vietnamese: string
        abstract WestEuropean: string

module FontSizes =

    type [<AllowNullLiteral>] IExports =
        abstract mini: obj
        abstract xSmall: obj
        abstract small: obj
        abstract smallPlus: obj
        abstract medium: obj
        abstract mediumPlus: obj
        abstract icon: obj
        abstract large: obj
        abstract xLarge: obj
        abstract xxLarge: obj
        abstract superLarge: obj
        abstract mega: obj

module FontWeights =

    type [<AllowNullLiteral>] IExports =
        abstract light: obj
        abstract semilight: obj
        abstract regular: obj
        abstract semibold: obj
        abstract bold: obj

module IconFontSizes =

    type [<AllowNullLiteral>] IExports =
        abstract xSmall: obj
        abstract small: obj
        abstract medium: obj
        abstract large: obj
type IRawStyle = @uifabric_merge_styles_lib_index.IRawStyle
type ITheme = ___interfaces_index.ITheme

type [<AllowNullLiteral>] IExports =
    /// <summary>Generates a focus style which can be used to define an :after focus border.</summary>
    /// <param name="theme">- The theme object to use.</param>
    /// <param name="inset">- The number of pixels to inset the border.</param>
    /// <param name="position">- The positioning applied to the container. Must
    /// be 'relative' or 'absolute' so that the focus border can live around it.</param>
    /// <param name="highContrastStyle">- Style for high contrast mode.</param>
    abstract getFocusStyle: theme: ITheme * ?inset: float * ?position: U2<string, string> * ?highContrastStyle: IRawStyle option -> IRawStyle
    /// Generates style to clear browser specific focus styles.
    abstract focusClear: unit -> IRawStyle
type ITheme = ___interfaces_index.ITheme

type [<AllowNullLiteral>] IExports =
    /// <summary>Checks for the `disableGlobalClassNames` property on the `theme` to determine if it should return `classNames`</summary>
    /// <param name="classNames">The global class names that apply when the flag is false</param>
    /// <param name="theme">The theme to check the flag on</param>
    abstract getGlobalClassNames: classNames: GlobalClassNames<'T> * theme: ITheme -> obj

type GlobalClassNames<'IStyles> =
    Record<obj, string>
type ITheme = ___interfaces_index.ITheme
type IPartialTheme = ___interfaces_index.IPartialTheme
let [<Import("obj","@uifabric/styling/lib/styles/theme")>] ThemeSettingName: obj = jsNative

type [<AllowNullLiteral>] IExports =
    /// <summary>Gets the theme object</summary>
    /// <param name="depComments">- Whether to include deprecated tags as comments for deprecated slots.</param>
    abstract getTheme: ?depComments: bool -> ITheme
    /// Registers a callback that gets called whenever the theme changes.
    /// This should only be used when the component cannot automatically get theme changes through its state.
    /// This will not register duplicate callbacks.
    abstract registerOnThemeChangeCallback: callback: (ITheme -> unit) -> unit
    /// See registerOnThemeChangeCallback().
    /// Removes previously registered callbacks.
    abstract removeOnThemeChangeCallback: callback: (ITheme -> unit) -> unit
    /// <summary>Applies the theme, while filling in missing slots.</summary>
    /// <param name="theme">- Partial theme object.</param>
    /// <param name="depComments">- Whether to include deprecated tags as comments for deprecated slots.</param>
    abstract loadTheme: theme: IPartialTheme * ?depComments: bool -> ITheme
    /// <summary>Creates a custom theme definition which can be used with the Customizer.</summary>
    /// <param name="theme">- Partial theme object.</param>
    /// <param name="depComments">- Whether to include deprecated tags as comments for deprecated slots.</param>
    abstract createTheme: theme: IPartialTheme * ?depComments: bool -> ITheme
let [<Import("obj","@uifabric/styling/lib/styles/CommonStyles")>] HighContrastSelector: obj = jsNative
let [<Import("obj","@uifabric/styling/lib/styles/CommonStyles")>] ScreenWidthMinSmall: obj = jsNative
let [<Import("obj","@uifabric/styling/lib/styles/CommonStyles")>] ScreenWidthMinMedium: obj = jsNative
let [<Import("obj","@uifabric/styling/lib/styles/CommonStyles")>] ScreenWidthMinLarge: obj = jsNative
let [<Import("obj","@uifabric/styling/lib/styles/CommonStyles")>] ScreenWidthMinXLarge: obj = jsNative
let [<Import("obj","@uifabric/styling/lib/styles/CommonStyles")>] ScreenWidthMinXXLarge: obj = jsNative
let [<Import("obj","@uifabric/styling/lib/styles/CommonStyles")>] ScreenWidthMinXXXLarge: obj = jsNative
let [<Import("float","@uifabric/styling/lib/styles/CommonStyles")>] ScreenWidthMaxSmall: float = jsNative
let [<Import("float","@uifabric/styling/lib/styles/CommonStyles")>] ScreenWidthMaxMedium: float = jsNative
let [<Import("float","@uifabric/styling/lib/styles/CommonStyles")>] ScreenWidthMaxLarge: float = jsNative
let [<Import("float","@uifabric/styling/lib/styles/CommonStyles")>] ScreenWidthMaxXLarge: float = jsNative
let [<Import("float","@uifabric/styling/lib/styles/CommonStyles")>] ScreenWidthMaxXXLarge: float = jsNative

type [<AllowNullLiteral>] IExports =
    abstract getScreenSelector: min: float * max: float -> string
type IRawStyle = @uifabric_merge_styles_lib_index.IRawStyle
let [<Import("IRawStyle","@uifabric/styling/lib/styles/GeneralStyles")>] normalize: IRawStyle = jsNative
let [<Import("IRawStyle","@uifabric/styling/lib/styles/GeneralStyles")>] noWrap: IRawStyle = jsNative

module ZIndexes =

    type [<AllowNullLiteral>] IExports =
        abstract Nav: obj
        abstract ScrollablePane: obj
        abstract FocusStyle: obj
        abstract Coachmark: obj
        abstract Layer: obj
        abstract KeytipLayer: obj

type [<AllowNullLiteral>] IExports =
    /// <summary>Builds a class names object from a given map.</summary>
    /// <param name="styles">- Map of unprocessed styles.</param>
    abstract buildClassMap: styles: 'T -> obj
type IRawStyle = @uifabric_merge_styles_lib_index.IRawStyle
type IFontFace = @uifabric_merge_styles_lib_index.IFontFace

type [<AllowNullLiteral>] IExports =
    /// <summary>Registers a given subset of icons.</summary>
    /// <param name="iconSubset">- the icon subset definition.</param>
    abstract registerIcons: iconSubset: IIconSubset * ?options: obj -> unit
    /// Remaps one icon name to another.
    abstract registerIconAlias: iconName: string * mappedToName: string -> unit
    /// <summary>Gets an icon definition. If an icon is requested but the subset has yet to be registered,
    /// it will get registered immediately.</summary>
    /// <param name="name">- Name of icon.</param>
    abstract getIcon: ?name: string -> IIconRecord option
    /// Sets the icon options.
    abstract setIconOptions: options: obj -> unit

type [<AllowNullLiteral>] IIconSubset =
    abstract fontFace: IFontFace option with get, set
    abstract icons: obj with get, set
    abstract style: IRawStyle option with get, set

type [<AllowNullLiteral>] IIconSubsetRecord =
    inherit IIconSubset
    abstract isRegistered: bool option with get, set
    abstract className: string option with get, set

type [<AllowNullLiteral>] IIconRecord =
    abstract code: string option with get, set
    abstract subset: IIconSubsetRecord with get, set

type [<AllowNullLiteral>] IIconOptions =
    /// By default, registering the same set of icons will generate a console warning per duplicate icon
    /// registered, because this scenario can create unexpected consequences.
    /// 
    /// Some scenarios include:
    /// 
    /// Icon set was previously registered using a different base url.
    /// Icon set was previously registered but a different version was provided.
    /// Icons in a previous registered set overlap with a new set.
    /// 
    /// To simply ignore previously registered icons, you can specify to disable warnings. This means
    /// that if an icon which was previous registered is registered again, it will be silently ignored.
    /// However, consider whether the problems listed above will cause issues.
    abstract disableWarnings: bool with get, set
    abstract warnOnMissingIcons: bool option with get, set

type [<AllowNullLiteral>] IIconRecords =
    abstract __options: IIconOptions with get, set
    abstract __remapped: obj with get, set
    [<Emit "$0[$1]{{=$2}}">] abstract Item: key: string -> U2<IIconRecord, obj> with get, set

type [<AllowNullLiteral>] IExports =
    /// Gets an icon classname. You should be able to add this classname to an I tag with no
    /// additional classnames, and render the icon.
    abstract getIconClassName: name: string -> string
type BaseComponent = ______Utilities.BaseComponent
type IPersonaProps = __Persona_types.IPersonaProps

type [<AllowNullLiteral>] IExports =
    abstract PersonaBase: PersonaBaseStatic

/// Persona with no default styles.
/// [Use the `getStyles` API to add your own styles.](https://github.com/OfficeDev/office-ui-fabric-react/wiki/Styling)
type [<AllowNullLiteral>] PersonaBase =
    inherit BaseComponent<IPersonaProps, obj>
    abstract defaultProps: IPersonaProps with get, set
    abstract render: unit -> JSX.Element
    /// Deprecation helper for getting text.
    abstract _getText: unit -> unit
    abstract _renderElement: obj with get, set

/// Persona with no default styles.
/// [Use the `getStyles` API to add your own styles.](https://github.com/OfficeDev/office-ui-fabric-react/wiki/Styling)
type [<AllowNullLiteral>] PersonaBaseStatic =
    [<Emit "new $0($1...)">] abstract Create: props: IPersonaProps -> PersonaBase
type IStyle = ______Styling.IStyle
type ITheme = ______Styling.ITheme
type IStyleFunction = ______Utilities.IStyleFunction

type [<AllowNullLiteral>] IImage =
    interface end

type [<AllowNullLiteral>] IImageProps =
    inherit React.ImgHTMLAttributes<HTMLImageElement>
    /// Optional callback to access the ICheckbox interface. Use this instead of ref for accessing
    /// the public methods and properties of the component.
    abstract componentRef: (IImage option -> unit) option with get, set
    /// Call to provide customized styling that will layer on top of the variant rules
    abstract getStyles: IStyleFunction<IImageStyleProps, IImageStyles> option with get, set
    /// Theme provided by HOC.
    abstract theme: ITheme option with get, set
    /// Additional css class to apply to the Component
    abstract className: string option with get, set
    /// If true, fades the image in when loaded.
    abstract shouldFadeIn: bool option with get, set
    /// If true, the image starts as visible and is hidden on error. Otherwise, the image is hidden until
    /// it is successfully loaded. This disables shouldFadeIn.
    abstract shouldStartVisible: bool option with get, set
    /// Used to determine how the image is scaled and cropped to fit the frame.
    abstract imageFit: ImageFit option with get, set
    /// Deprecated at v1.3.6, to replace the src in case of errors, use onLoadingStateChange instead and
    /// rerender the Image with a difference src.
    abstract errorSrc: string option with get, set
    /// If true, the image frame will expand to fill its parent container.
    abstract maximizeFrame: bool option with get, set
    /// Optional callback method for when the image load state has changed.
    /// The 'loadState' parameter indicates the current state of the Image.
    abstract onLoadingStateChange: (ImageLoadState -> unit) option with get, set
    /// Specifies the cover style to be used for this image. If not
    /// specified, this will be dynamically calculated based on the
    /// aspect ratio for the image.
    abstract coverStyle: ImageCoverStyle option with get, set

type [<RequireQualifiedAccess>] ImageFit =
    | Center = 0
    | Contain = 1
    | Cover = 2
    | None = 3

type [<RequireQualifiedAccess>] ImageCoverStyle =
    | Landscape = 0
    | Portrait = 1

type [<RequireQualifiedAccess>] ImageLoadState =
    | NotLoaded = 0
    | Loaded = 1
    | Error = 2
    | ErrorLoaded = 3

type [<AllowNullLiteral>] IImageStyleProps =
    /// Accept theme prop.
    abstract theme: ITheme with get, set
    /// Accept custom classNames
    abstract className: string option with get, set
    /// If true, the image frame will expand to fill its parent container.
    abstract maximizeFrame: bool option with get, set
    /// If true, the image is loaded
    abstract isLoaded: bool option with get, set
    /// If true, fades the image in when loaded.
    abstract shouldFadeIn: bool option with get, set
    /// If true, the image starts as visible and is hidden on error. Otherwise, the image is hidden until
    /// it is successfully loaded. This disables shouldFadeIn.
    abstract shouldStartVisible: bool option with get, set
    /// If true the image is coverStyle landscape instead of portrait
    abstract isLandscape: bool option with get, set
    /// ImageFit booleans for center, cover, contain, none
    abstract isCenter: bool option with get, set
    abstract isContain: bool option with get, set
    abstract isCover: bool option with get, set
    abstract isNone: bool option with get, set
    /// if true image load is in error
    abstract isError: bool option with get, set
    /// if true, imageFit is undefined
    abstract isNotImageFit: bool option with get, set
    /// Image width valye
    abstract width: U2<float, string> option with get, set
    /// Image height valye
    abstract height: U2<float, string> option with get, set

type [<AllowNullLiteral>] IImageStyles =
    /// Style set for the root div element.
    abstract root: IStyle with get, set
    /// Style set for the img element.
    abstract image: IStyle with get, set
type BaseComponent = ______Utilities.BaseComponent
type IImageProps = __Image_types.IImageProps
type ImageLoadState = __Image_types.ImageLoadState

type [<AllowNullLiteral>] IExports =
    abstract ImageBase: ImageBaseStatic

type [<AllowNullLiteral>] IImageState =
    abstract loadState: ImageLoadState option with get, set

type [<AllowNullLiteral>] ImageBase =
    inherit BaseComponent<IImageProps, IImageState>
    abstract defaultProps: obj with get, set
    abstract _svgRegex: obj with get, set
    abstract _coverStyle: obj with get, set
    abstract _imageElement: obj with get, set
    abstract _frameElement: obj with get, set
    abstract componentWillReceiveProps: nextProps: IImageProps -> unit
    abstract componentDidUpdate: prevProps: IImageProps * prevState: IImageState -> unit
    abstract render: unit -> JSX.Element
    abstract _onImageLoaded: obj with get, set
    abstract _checkImageLoaded: unit -> unit
    abstract _computeCoverStyle: props: obj -> unit
    abstract _onImageError: obj with get, set

type [<AllowNullLiteral>] ImageBaseStatic =
    [<Emit "new $0($1...)">] abstract Create: props: IImageProps -> ImageBase
type IRenderFunction = ______Utilities.IRenderFunction
type PersonaBase = __Persona_base.PersonaBase
type ImageLoadState = ______Image.ImageLoadState
type IStyle = ______Styling.IStyle
type ITheme = ______Styling.ITheme
type IStyleFunction = ______Utilities.IStyleFunction

type [<AllowNullLiteral>] IPersona =
    interface end

type [<AllowNullLiteral>] IPersonaSharedProps =
    inherit React.HTMLAttributes<PersonaBase>
    /// Primary text to display, usually the name of the person.
    abstract text: string option with get, set
    /// Decides the size of the control.
    abstract size: PersonaSize option with get, set
    /// Optional custom renderer for the coin
    abstract onRenderCoin: IRenderFunction<IPersonaSharedProps> option with get, set
    /// If true, adds the css class 'is-fadeIn' to the image.
    abstract imageShouldFadeIn: bool option with get, set
    /// If true, the image starts as visible and is hidden on error. Otherwise, the image is hidden until
    /// it is successfully loaded. This disables imageShouldFadeIn.
    abstract imageShouldStartVisible: bool option with get, set
    /// Url to the image to use, should be a square aspect ratio and big enough to fit in the image area.
    abstract imageUrl: string option with get, set
    /// Alt text for the image to use. Defaults to an empty string.
    abstract imageAlt: string option with get, set
    /// The user's initials to display in the image area when there is no image.
    abstract imageInitials: string option with get, set
    /// Whether initials are calculated for phone numbers and number sequences.
    /// Example: Set property to true to get initials for project names consisting of numbers only.
    abstract allowPhoneInitials: bool option with get, set
    /// Optional custom renderer for the initials
    abstract onRenderInitials: IRenderFunction<IPersonaSharedProps> option with get, set
    /// Optional callback for when loading state of the photo changes
    abstract onPhotoLoadingStateChange: (ImageLoadState -> unit) option with get, set
    /// The background color when the user's initials are displayed.
    abstract initialsColor: U2<PersonaInitialsColor, string> option with get, set
    /// Presence of the person to display - will not display presence if undefined.
    abstract presence: PersonaPresence option with get, set
    /// Secondary text to display, usually the role of the user.
    abstract secondaryText: string option with get, set
    /// Tertiary text to display, usually the status of the user.
    abstract tertiaryText: string option with get, set
    /// Optional text to display, usually a custom message set.
    abstract optionalText: string option with get, set
    /// Whether to not render persona details, and just render the persona image/initials.
    abstract hidePersonaDetails: bool option with get, set
    abstract showSecondaryText: bool option with get, set
    /// If true, show the special coin for unknown persona.
    /// It has '?' in place of initials, with static font and background colors
    abstract showUnknownPersonaCoin: bool option with get, set
    /// Optional custom persona coin size in pixel.
    abstract coinSize: float option with get, set
    /// Optional HTML element props for Persona coin.
    abstract coinProps: React.HTMLAttributes<HTMLDivElement> option with get, set
    /// Theme provided by High-Order Component.
    abstract theme: ITheme option with get, set
    /// Primary text to display, usually the name of the person.
    abstract primaryText: string option with get, set

type [<AllowNullLiteral>] IPersonaProps =
    inherit IPersonaSharedProps
    /// Optional callback to access the IPersona interface. Use this instead of ref for accessing
    /// the public methods and properties of the component.
    abstract componentRef: (IPersona option -> unit) option with get, set
    /// Additional CSS class(es) to apply to the Persona
    abstract className: string option with get, set
    /// Call to provide customized styling that will layer on top of variant rules
    abstract getStyles: IStyleFunction<IPersonaStyleProps, IPersonaStyles> option with get, set
    /// Optional custom renderer for the primary text.
    abstract onRenderPrimaryText: IRenderFunction<IPersonaProps> option with get, set
    /// Optional custom renderer for the secondary text.
    abstract onRenderSecondaryText: IRenderFunction<IPersonaProps> option with get, set
    /// Optional custom renderer for the tertiary text.
    abstract onRenderTertiaryText: IRenderFunction<IPersonaProps> option with get, set
    /// Optional custom renderer for the optional text.
    abstract onRenderOptionalText: IRenderFunction<IPersonaProps> option with get, set

type [<AllowNullLiteral>] IPersonaStyleProps =
    /// Theme provided by High-Order Component.
    abstract theme: ITheme with get, set
    /// Custom class name.
    abstract className: string option with get, set
    /// Optional custom persona coin size in pixel.
    abstract coinSize: float option with get, set
    /// Decides the size of the control.
    abstract size: PersonaSize option with get, set
    /// Presence of the person to display - will not display presence if undefined.
    abstract presence: PersonaPresence option with get, set
    abstract showSecondaryText: bool option with get, set

type [<AllowNullLiteral>] IPersonaStyles =
    abstract root: IStyle with get, set
    abstract details: IStyle with get, set
    abstract primaryText: IStyle with get, set
    abstract secondaryText: IStyle with get, set
    abstract tertiaryText: IStyle with get, set
    abstract optionalText: IStyle with get, set
    abstract textContent: IStyle with get, set

type [<AllowNullLiteral>] IPersonaCoinProps =
    inherit IPersonaSharedProps
    /// Gets the component ref.
    abstract componentRef: (IPersonaCoinProps -> unit) option with get, set
    /// Call to provide customized styling that will layer on top of the variant rules
    abstract getStyles: IStyleFunction<IPersonaCoinStyleProps, IPersonaCoinStyles> option with get, set
    /// Additional css class to apply to the PersonaCoin
    abstract className: string option with get, set

type [<AllowNullLiteral>] IPersonaCoinStyleProps =
    /// Theme provided by High-Order Component.
    abstract theme: ITheme with get, set
    /// Custom class name.
    abstract className: string option with get, set
    /// Decides the size of the control.
    abstract size: PersonaSize option with get, set
    /// Decides whether to display coin for unknown persona
    abstract showUnknownPersonaCoin: bool option with get, set

type [<AllowNullLiteral>] IPersonaCoinStyles =
    abstract coin: IStyle with get, set
    abstract imageArea: IStyle with get, set
    abstract image: IStyle with get, set
    abstract initials: IStyle with get, set
    abstract size10WithoutPresenceIcon: IStyle with get, set

type [<AllowNullLiteral>] IPersonaPresenceProps =
    inherit IPersonaSharedProps
    /// Gets the component ref.
    abstract componentRef: (IPersonaPresenceProps -> unit) option with get, set
    /// Call to provide customized styling that will layer on top of the variant rules
    abstract getStyles: IStyleFunction<IPersonaPresenceStyleProps, IPersonaPresenceStyles> option with get, set

type [<AllowNullLiteral>] IPersonaPresenceStyleProps =
    /// Theme provided by High-Order Component.
    abstract theme: ITheme with get, set
    /// Custom class name.
    abstract className: string option with get, set
    /// Presence of the person to display - will not display presence if undefined.
    abstract presence: PersonaPresence option with get, set
    /// Decides the size of the control.
    abstract size: PersonaSize option with get, set

type [<AllowNullLiteral>] IPersonaPresenceStyles =
    abstract presence: IStyle with get, set
    abstract presenceIcon: IStyle with get, set

type [<RequireQualifiedAccess>] PersonaSize =
    | Tiny = 0
    | ExtraExtraSmall = 1
    | ExtraSmall = 2
    | Small = 3
    | Regular = 4
    | Large = 5
    | ExtraLarge = 6
    | Size28 = 7
    | Size16 = 8
    | Size10 = 9
    | Size24 = 10
    | Size32 = 11
    | Size40 = 12
    | Size48 = 13
    | Size72 = 14
    | Size100 = 15

type [<RequireQualifiedAccess>] PersonaPresence =
    | None = 0
    | Offline = 1
    | Online = 2
    | Away = 3
    | Dnd = 4
    | Blocked = 5
    | Busy = 6

type [<RequireQualifiedAccess>] PersonaInitialsColor =
    | LightBlue = 0
    | Blue = 1
    | DarkBlue = 2
    | Teal = 3
    | LightGreen = 4
    | Green = 5
    | DarkGreen = 6
    | LightPink = 7
    | Pink = 8
    | Magenta = 9
    | Purple = 10
    | Black = 11
    | Orange = 12
    | Red = 13
    | DarkRed = 14
    | Transparent = 15
type BaseComponent = _________Utilities.BaseComponent
type IPersonaCoinProps = ___Persona_types.IPersonaCoinProps

type [<AllowNullLiteral>] IExports =
    abstract PersonaCoinBase: PersonaCoinBaseStatic

type [<AllowNullLiteral>] IPersonaState =
    abstract isImageLoaded: bool option with get, set
    abstract isImageError: bool option with get, set

/// PersonaCoin with no default styles.
/// [Use the `getStyles` API to add your own styles.](https://github.com/OfficeDev/office-ui-fabric-react/wiki/Styling)
type [<AllowNullLiteral>] PersonaCoinBase =
    inherit BaseComponent<IPersonaCoinProps, IPersonaState>
    abstract defaultProps: IPersonaCoinProps with get, set
    abstract render: unit -> JSX.Element option
    abstract _onRenderCoin: obj with get, set
    /// Deprecation helper for getting text.
    abstract _getText: unit -> unit
    abstract _onRenderInitials: obj with get, set
    abstract _onPhotoLoadingStateChange: obj with get, set

/// PersonaCoin with no default styles.
/// [Use the `getStyles` API to add your own styles.](https://github.com/OfficeDev/office-ui-fabric-react/wiki/Styling)
type [<AllowNullLiteral>] PersonaCoinBaseStatic =
    [<Emit "new $0($1...)">] abstract Create: props: IPersonaCoinProps -> PersonaCoinBase
type PersonaPresence = __Persona_types.PersonaPresence
type PersonaSize = __Persona_types.PersonaSize
let [<Import("","office-ui-fabric-react")>] sizeBoolean: (PersonaSize -> obj) = jsNative
let [<Import("","office-ui-fabric-react")>] presenceBoolean: (PersonaPresence -> obj) = jsNative

module PersonaSize =

    type [<AllowNullLiteral>] IExports =
        abstract size10: obj
        abstract size16: obj
        abstract size24: obj
        abstract size28: obj
        abstract size32: obj
        abstract size40: obj
        abstract size48: obj
        abstract size72: obj
        abstract size100: obj

module PersonaPresenceSize =

    type [<AllowNullLiteral>] IExports =
        abstract size6: obj
        abstract size8: obj
        abstract size12: obj
        abstract size20: obj
        abstract size28: obj
        abstract border: obj
type IStyle = ______Styling.IStyle
type IRenderFunction = ______Utilities.IRenderFunction
type IPersonaSharedProps = ______Persona.IPersonaSharedProps

type [<AllowNullLiteral>] IActivityItemProps =
    inherit React.AllHTMLAttributes<HTMLElement>
    /// An element describing the activity that took place. If no activityDescription, activityDescriptionText, or onRenderActivityDescription are included, no description of the activity is shown.
    abstract activityDescription: U2<ResizeArray<React.ReactNode>, React.ReactNode> option with get, set
    /// Text describing the activity that occurred and naming the people involved in it. Deprecated, use activityDescription instead.
    abstract activityDescriptionText: string option with get, set
    /// An element containing an icon shown next to the activity item.
    abstract activityIcon: React.ReactNode option with get, set
    /// If activityIcon is not set, then the persona props in this array will be used as the icon for the this activity item.
    abstract activityPersonas: Array<IPersonaSharedProps> option with get, set
    /// An element containing the text of comments or @mention messages. If no comments, commentText, or onRenderComments are included, no comments are shown.
    abstract comments: U2<ResizeArray<React.ReactNode>, React.ReactNode> option with get, set
    /// Text of comments or @mention messages. Deprecated, use comments instead.
    abstract commentText: string option with get, set
    /// Gets ref to component interface.
    abstract componentRef: (unit -> unit) option with get, set
    /// Indicated if the compact styling should be used.
    abstract isCompact: bool option with get, set
    /// A renderer for the description of the current activity.
    abstract onRenderActivityDescription: IRenderFunction<IActivityItemProps> option with get, set
    /// A renderer that adds the text of a comment below the activity description.
    abstract onRenderComments: IRenderFunction<IActivityItemProps> option with get, set
    /// A renderer to create the icon next to the activity item.
    abstract onRenderIcon: IRenderFunction<IActivityItemProps> option with get, set
    /// A renderer adds a time stamp. If not included, timeStamp is shown as plain text below the activity.
    abstract onRenderTimeStamp: IRenderFunction<IActivityItemProps> option with get, set
    /// Optional styling for the elements within the Activity Item.
    abstract styles: IActivityItemStyles option with get, set
    /// Element shown as a timestamp on this activity. If not included, no timestamp is shown.
    abstract timeStamp: U3<string, ResizeArray<React.ReactNode>, React.ReactNode> option with get, set
    /// Beacon color one
    abstract beaconColorOne: string option with get, set
    /// Beacon color two
    abstract beaconColorTwo: string option with get, set
    /// Enables/Disables the beacon that radiates
    /// from the center of the center of the activity icon. Signals an activity has started.
    abstract animateBeaconSignal: bool option with get, set

type [<AllowNullLiteral>] IActivityItemStyles =
    /// Styles applied to the root activity item container.
    abstract root: IStyle option with get, set
    /// Styles applied to the root activity item container.
    abstract pulsingBeacon: IStyle option with get, set
    /// Styles applied to the main container of the activity's description.
    abstract activityContent: IStyle option with get, set
    /// Styles applied to the persona of the user that did this activity.
    abstract activityPersona: IStyle option with get, set
    /// Styles applied to the activity's description.
    abstract activityText: IStyle option with get, set
    /// Styles applied to the icon indicating the type of the activity. Only shown when personas are unavailable.
    abstract activityTypeIcon: IStyle option with get, set
    /// Styles applied to the text of comments.
    abstract commentText: IStyle option with get, set
    /// Styles applied to personas when two users are involved in a single activity.
    abstract doublePersona: IStyle option with get, set
    /// Styles applied to root in the compact variant.
    abstract isCompactRoot: IStyle option with get, set
    /// Styles applied to personas and icons in the compact variant.
    abstract isCompactIcon: IStyle option with get, set
    /// Styles applied to main text container in the compact variant.
    abstract isCompactContent: IStyle option with get, set
    /// Styles applied to personas in the compact variant.
    abstract isCompactPersona: IStyle option with get, set
    /// Styles applied to a wrapper around personas in the compact variant.
    abstract isCompactPersonaContainer: IStyle option with get, set
    /// Styles applied to the container of the persona image or activity type icon.
    abstract personaContainer: IStyle option with get, set
    /// Styles applied to the timestamp at the end of each activity item.
    abstract timeStamp: IStyle option with get, set
    /// Styles applied to the timestamp in compact mode.
    /// This can occur if a host overrides the render behavior to force the timestamp to render.
    abstract isCompactTimeStamp: IStyle option with get, set
type BaseComponent = ______Utilities.BaseComponent
type IActivityItemProps = __ActivityItem_types.IActivityItemProps

type [<AllowNullLiteral>] IExports =
    abstract ActivityItem: ActivityItemStatic

type [<AllowNullLiteral>] ActivityItem =
    inherit BaseComponent<IActivityItemProps, obj>
    abstract render: unit -> JSX.Element
    abstract _onRenderIcon: obj with get, set
    abstract _onRenderActivityDescription: obj with get, set
    abstract _onRenderComments: obj with get, set
    abstract _onRenderTimeStamp: obj with get, set
    abstract _onRenderPersonaArray: obj with get, set
    abstract _getClassNames: props: obj -> unit

type [<AllowNullLiteral>] ActivityItemStatic =
    [<Emit "new $0($1...)">] abstract Create: props: IActivityItemProps -> ActivityItem
type BaseComponent = ______Utilities.BaseComponent
type IBreadcrumbProps = __Breadcrumb_types.IBreadcrumbProps
type IBreadcrumbItem = __Breadcrumb_types.IBreadcrumbItem

type [<AllowNullLiteral>] IExports =
    abstract BreadcrumbBase: BreadcrumbBaseStatic

type [<AllowNullLiteral>] IBreadCrumbData =
    abstract props: IBreadcrumbProps with get, set
    abstract renderedItems: ResizeArray<IBreadcrumbItem> with get, set
    abstract renderedOverflowItems: ResizeArray<IBreadcrumbItem> with get, set

type [<AllowNullLiteral>] BreadcrumbBase =
    inherit BaseComponent<IBreadcrumbProps, obj option>
    abstract defaultProps: IBreadcrumbProps with get, set
    abstract _classNames: obj with get, set
    abstract _focusZone: obj with get, set
    /// Sets focus to the first breadcrumb link.
    abstract focus: unit -> unit
    abstract render: unit -> JSX.Element
    abstract componentWillReceiveProps: nextProps: IBreadcrumbProps -> unit
    abstract _onReduceData: obj with get, set
    abstract _onRenderBreadcrumb: obj with get, set
    abstract _onRenderItem: obj with get, set
    abstract _onBreadcrumbClicked: obj with get, set
    /// <summary>Validate incoming props</summary>
    /// <param name="props">Props to validate</param>
    abstract _validateProps: props: obj -> unit

type [<AllowNullLiteral>] BreadcrumbBaseStatic =
    [<Emit "new $0($1...)">] abstract Create: props: IBreadcrumbProps -> BreadcrumbBase
type IImageProps = ___Image_Image_types.IImageProps
type IStyle = ______Styling.IStyle
type IBaseProps = ______Utilities.IBaseProps
type IStyleFunction = ______Utilities.IStyleFunction

type [<RequireQualifiedAccess>] IconType =
    | Default = 0
    | Image = 1
    | Default = 100000
    | Image = 100001

type [<AllowNullLiteral>] IIconProps =
    inherit IBaseProps
    inherit React.HTMLAttributes<HTMLElement>
    /// The name of the icon to use from the icon font. If string is empty, a placeholder icon will be rendered the same width as an icon
    abstract iconName: string option with get, set
    /// The aria label of the button for the benefit of screen readers.
    abstract ariaLabel: string option with get, set
    /// The type of icon to render (image or icon font).
    abstract iconType: IconType option with get, set
    /// If rendering an image icon, these props will be passed to the Image component.
    abstract imageProps: IImageProps option with get, set
    /// If rendering an image icon, this function callback will be invoked in the event loading the image errors.
    abstract imageErrorAs: U2<React.StatelessComponent<IImageProps>, React.ComponentClass<IImageProps>> option with get, set
    /// Gets the styles for an Icon.
    abstract getStyles: IStyleFunction<IIconStyleProps, IIconStyles> option with get, set
    /// Deprecated: use getStyles.
    abstract styles: IIconStyles option with get, set

type [<AllowNullLiteral>] IIconStyleProps =
    abstract className: string option with get, set
    abstract iconClassName: string option with get, set
    abstract isPlaceholder: bool with get, set
    abstract isImage: bool with get, set
    abstract styles: obj option with get, set

type [<AllowNullLiteral>] IIconStyles =
    abstract root: IStyle option with get, set
    /// Deprecated. Use 'root'.
    abstract imageContainer: IStyle option with get, set
type IIconProps = __Icon_types.IIconProps
type BaseComponent = ______Utilities.BaseComponent

type [<AllowNullLiteral>] IExports =
    abstract IconBase: IconBaseStatic

type [<AllowNullLiteral>] IIconState =
    abstract imageLoadError: bool with get, set

type [<AllowNullLiteral>] IconBase =
    inherit BaseComponent<IIconProps, IIconState>
    abstract render: unit -> JSX.Element
    abstract onImageLoadingStateChange: obj with get, set
    abstract _getIconContent: ?name: obj -> unit

type [<AllowNullLiteral>] IconBaseStatic =
    [<Emit "new $0($1...)">] abstract Create: props: IIconProps -> IconBase
type IStyle = ______Styling.IStyle
type ITheme = ______Styling.ITheme
let [<Import("","office-ui-fabric-react")>] getStyles: (IBreadcrumbStyleProps -> IBreadcrumbStyles) = jsNative

type [<AllowNullLiteral>] IBreadcrumbStyleProps =
    abstract className: string option with get, set
    abstract theme: ITheme with get, set

type [<AllowNullLiteral>] IBreadcrumbStyles =
    abstract root: IStyle with get, set
    abstract list: IStyle with get, set
    abstract listItem: IStyle with get, set
    abstract chevron: IStyle with get, set
    abstract overflow: IStyle with get, set
    abstract overflowButton: IStyle with get, set
    abstract itemLink: IStyle with get, set
    abstract item: IStyle with get, set
type BreadcrumbBase = __Breadcrumb_base.BreadcrumbBase
type IBreadCrumbData = __Breadcrumb_base.IBreadCrumbData
type IIconProps = ___Icon.IIconProps
type IRenderFunction = ______Utilities.IRenderFunction
type IStyleFunction = ______Utilities.IStyleFunction
type IComponentAs = ______Utilities.IComponentAs
type IBreadcrumbStyleProps = __Breadcrumb_styles.IBreadcrumbStyleProps
type IBreadcrumbStyles = __Breadcrumb_styles.IBreadcrumbStyles
type ITheme = ______Styling.ITheme

type [<AllowNullLiteral>] IBreadcrumb =
    /// Sets focus to the first breadcrumb link.
    abstract focus: unit -> unit

type [<AllowNullLiteral>] IBreadcrumbProps =
    inherit React.Props<BreadcrumbBase>
    /// Optional callback to access the IBreadcrumb interface. Use this instead of ref for accessing
    /// the public methods and properties of the component.
    abstract componentRef: (IBreadcrumb option -> unit) option with get, set
    /// Collection of breadcrumbs to render
    abstract items: ResizeArray<IBreadcrumbItem> with get, set
    /// Optional root classname for the root breadcrumb element.
    abstract className: string option with get, set
    /// Render a custom divider in place of the default chevron '>'
    abstract dividerAs: IComponentAs<IDividerAsProps> option with get, set
    /// The maximum number of breadcrumbs to display before coalescing.
    /// If not specified, all breadcrumbs will be rendered.
    abstract maxDisplayedItems: float option with get, set
    /// Method to call when trying to render an item. 
    abstract onRenderItem: IRenderFunction<IBreadcrumbItem> option with get, set
    /// Method to call when reducing the length of the breadcrumb.
    /// Return undefined to never reduce breadcrumb length
    abstract onReduceData: (IBreadCrumbData -> IBreadCrumbData option) option with get, set
    /// Aria label to place on the navigation landmark for breadcrumb
    abstract ariaLabel: string option with get, set
    /// Optional name to use for aria label on overflow button.
    abstract overflowAriaLabel: string option with get, set
    /// Optional index where overflow items will be collapsed. Defaults to 0.
    abstract overflowIndex: float option with get, set
    abstract getStyles: IStyleFunction<IBreadcrumbStyleProps, IBreadcrumbStyles> option with get, set
    abstract theme: ITheme option with get, set

type [<AllowNullLiteral>] IBreadcrumbItem =
    /// Text to display to the user for the breadcrumb
    abstract text: string with get, set
    /// Arbitrary unique string associated with the breadcrumb
    abstract key: string with get, set
    /// Callback issued when the breadcrumb is selected.
    abstract onClick: (React.MouseEvent<HTMLElement> -> IBreadcrumbItem -> unit) option with get, set
    /// Url to navigate to when this breadcrumb is clicked.
    abstract href: string option with get, set
    /// If this breadcrumb item is the item the user is currently on, if set to true, aria-current="page" will be applied to this breadcrumb link
    abstract isCurrentItem: bool option with get, set

type [<AllowNullLiteral>] IDividerAsProps =
    inherit IIconProps
    /// Optional breadcrumb item corresponds to left of the divider to be passed for custom rendering.
    /// For overflowed items, it will be last item in the list
    abstract item: IBreadcrumbItem option with get, set

type [<RequireQualifiedAccess>] DirectionalHint =
    | TopLeftEdge = 0
    | TopCenter = 1
    | TopRightEdge = 2
    | TopAutoEdge = 3
    | BottomLeftEdge = 4
    | BottomCenter = 5
    | BottomRightEdge = 6
    | BottomAutoEdge = 7
    | LeftTopEdge = 8
    | LeftCenter = 9
    | LeftBottomEdge = 10
    | RightTopEdge = 11
    | RightCenter = 12
    | RightBottomEdge = 13
type FocusZone = __FocusZone.FocusZone

/// FocusZone component class interface.
type [<AllowNullLiteral>] IFocusZone =
    /// <summary>Sets focus to the first tabbable item in the zone.</summary>
    /// <param name="forceIntoFirstElement">If true, focus will be forced into the first element, even if focus is already in the focus zone.</param>
    abstract focus: ?forceIntoFirstElement: bool -> bool
    /// Sets focus to a specific child element within the zone. This can be used in conjunction with
    /// onBeforeFocus to created delayed focus scenarios (like animate the scroll position to the correct
    /// location and then focus.)
    abstract focusElement: ?childElement: HTMLElement -> bool

/// FocusZone component props.
type [<AllowNullLiteral>] IFocusZoneProps =
    inherit React.HTMLAttributes<U2<HTMLElement, FocusZone>>
    /// Optional callback to access the IFocusZone interface. Use this instead of ref for accessing
    /// the public methods and properties of the component.
    abstract componentRef: (IFocusZone option -> unit) option with get, set
    /// Additional class name to provide on the root element, in addition to the ms-FocusZone class.
    abstract className: string option with get, set
    /// Defines which arrows to react to.
    abstract direction: FocusZoneDirection option with get, set
    /// Optionally provide a selector for identifying the intial active element.
    abstract defaultActiveElement: string option with get, set
    /// If set, the FocusZone will not be tabbable and keyboard navigation will be disabled.
    /// This does not affect disabled attribute of any child.
    abstract disabled: bool option with get, set
    /// Element type the root element will use. Default is "div".
    abstract elementType: obj option with get, set
    /// If set, will cycle to the beginning of the targets once the user navigates to the
    /// next target while at the end, and to the end when navigate to the previous at the beginning.
    abstract isCircularNavigation: bool option with get, set
    /// If provided, this callback will be executed on keypresses to determine if the user
    /// intends to navigate into the inner zone. Returning true will ask the first inner zone to
    /// set focus.
    abstract isInnerZoneKeystroke: (React.KeyboardEvent<HTMLElement> -> bool) option with get, set
    /// Sets the aria-labelledby attribute.
    abstract ariaLabelledBy: string option with get, set
    /// Sets the aria-describedby attribute.
    abstract ariaDescribedBy: string option with get, set
    /// Callback for when one of immediate children elements gets active by getting focused
    /// or by having one of its respective children elements focused.
    abstract onActiveElementChanged: (HTMLElement -> React.FocusEvent<HTMLElement> -> unit) option with get, set
    /// Deprecated at v1.12.1. DIV props provided to the FocusZone will be mixed into the root element.
    abstract rootProps: React.HTMLAttributes<HTMLDivElement> option with get, set
    /// Callback method for determining if focus should indeed be set on the given element.
    abstract onBeforeFocus: (HTMLElement -> bool) option with get, set
    /// Allow focus to move to root 
    abstract allowFocusRoot: bool option with get, set
    /// Allows tab key to be handled to tab through a list of items in the focus zone,
    /// an unfortunate side effect is that users will not be able to tab out of the focus zone
    /// and have to hit escape or some other key.
    abstract allowTabKey: bool option with get, set
    /// Allows tab key to be handled to tab through a list of items in the focus zone,
    /// an unfortunate side effect is that users will not be able to tab out of the focus zone
    /// and have to hit escape or some other key.
    abstract handleTabKey: FocusZoneTabbableElements option with get, set
    /// A callback method to determine if the input element should lose focus on arrow keys
    ///   
    abstract shouldInputLoseFocusOnArrowKey: (HTMLInputElement -> bool) option with get, set
    /// Whether the to check for data-no-horizontal-wrap or data-no-vertical-wrap attributes
    /// when determining how to move focus
    abstract checkForNoWrap: bool option with get, set
    /// Whether the FocusZone should allow focus events to propagate past the FocusZone
    abstract doNotAllowFocusEventToPropagate: bool option with get, set
    /// Callback to notify creators that focus has been set on the FocusZone
    abstract onFocusNotification: (unit -> unit) option with get, set

type [<RequireQualifiedAccess>] FocusZoneTabbableElements =
    | None = 0
    | All = 1
    | InputOnly = 2

type [<RequireQualifiedAccess>] FocusZoneDirection =
    | Vertical = 0
    | Horizontal = 1
    | Bidirectional = 2
type IFocusZone = __FocusZone_types.IFocusZone
type IFocusZoneProps = __FocusZone_types.IFocusZoneProps
type BaseComponent = ______Utilities.BaseComponent

type [<AllowNullLiteral>] IExports =
    abstract FocusZone: FocusZoneStatic

type [<AllowNullLiteral>] FocusZone =
    inherit BaseComponent<IFocusZoneProps, obj>
    inherit IFocusZone
    abstract defaultProps: IFocusZoneProps with get, set
    abstract _root: obj with get, set
    abstract _id: obj with get, set
    /// The most recently focused child element. 
    abstract _activeElement: obj with get, set
    /// The child element with tabindex=0. 
    abstract _defaultFocusElement: obj with get, set
    abstract _focusAlignment: obj with get, set
    abstract _isInnerZone: obj with get, set
    /// Used to allow us to move to next focusable element even when we're focusing on a input element when pressing tab 
    abstract _processingTabKey: obj with get, set
    abstract componentDidMount: unit -> unit
    abstract componentWillUnmount: unit -> unit
    abstract render: unit -> JSX.Element
    /// <summary>Sets focus to the first tabbable item in the zone.</summary>
    /// <param name="forceIntoFirstElement">If true, focus will be forced into the first element, even if focus is already in the focus zone.</param>
    abstract focus: ?forceIntoFirstElement: bool -> bool
    /// <summary>Sets focus to a specific child element within the zone. This can be used in conjunction with
    /// onBeforeFocus to created delayed focus scenarios (like animate the scroll position to the correct
    /// location and then focus.)</summary>
    /// <param name="element">The child element within the zone to focus.</param>
    abstract focusElement: element: HTMLElement -> bool
    abstract _onFocus: obj with get, set
    /// Handle global tab presses so that we can patch tabindexes on the fly.
    abstract _onKeyDownCapture: ev: obj -> unit
    abstract _onMouseDown: obj with get, set
    abstract _setActiveElement: element: obj * ?forceAlignemnt: obj -> unit
    /// Handle the keystrokes.
    abstract _onKeyDown: obj with get, set
    /// Walk up the dom try to find a focusable element.
    abstract _tryInvokeClickForFocusable: target: obj -> unit
    /// Traverse to find first child zone.
    abstract _getFirstInnerZone: ?rootElement: obj -> unit
    abstract _moveFocus: isForward: obj * getDistanceFromCenter: obj * ?ev: obj * ?useDefaultWrap: obj -> unit
    abstract _moveFocusDown: unit -> unit
    abstract _moveFocusUp: unit -> unit
    abstract _moveFocusLeft: unit -> unit
    abstract _moveFocusRight: unit -> unit
    abstract _setFocusAlignment: element: obj * ?isHorizontal: obj * ?isVertical: obj -> unit
    abstract _isImmediateDescendantOfZone: ?element: obj -> unit
    abstract _getOwnerZone: ?element: obj -> unit
    abstract _updateTabIndexes: ?element: obj -> unit
    abstract _isElementInput: element: obj -> unit
    abstract _shouldInputLoseFocus: element: obj * ?isForward: obj -> unit
    abstract _shouldWrapFocus: element: obj * noWrapDataAttribute: obj -> unit

type [<AllowNullLiteral>] FocusZoneStatic =
    [<Emit "new $0($1...)">] abstract Create: props: IFocusZoneProps -> FocusZone
type DirectionalHint = ______common_DirectionalHint.DirectionalHint
type IPoint = __positioning_types.IPoint
type IRectangle = ______Utilities.IRectangle

type [<RequireQualifiedAccess>] RectangleEdge =
    | Top = 1
    | Bottom = -1
    | Left = 2
    | Right = -2

type [<RequireQualifiedAccess>] Position =
    | Top = 0
    | Bottom = 1
    | Start = 2
    | End = 3

type [<AllowNullLiteral>] IPositionProps =
    abstract target: U3<Element, MouseEvent, IPoint> option with get, set
    /// how the element should be positioned 
    abstract directionalHint: DirectionalHint option with get, set
    /// How the element should be positioned in RTL layouts.
    /// If not specified, a mirror of `directionalHint` will be used instead
    abstract directionalHintForRTL: DirectionalHint option with get, set
    /// The gap between the callout and the target 
    abstract gapSpace: float option with get, set
    abstract beakWidth: float option with get, set
    /// The bounding rectangle for which  the contextual menu can appear in.
    abstract bounds: IRectangle option with get, set
    abstract isBeakVisible: bool option with get, set
    /// If true the position returned will have the menu element cover the target.
    /// If false then it will position next to the target;
    abstract coverTarget: bool option with get, set
    /// If true the position will not change edges in an attempt to fit the rectangle within bounds.
    /// It will still attempt to align it to whatever bounds are given.
    abstract directionalHintFixed: bool option with get, set

type [<AllowNullLiteral>] ICalloutPositionProps =
    inherit IPositionProps
    /// The width of the beak.
    abstract beakWidth: float option with get, set
    abstract isBeakVisible: bool option with get, set

type [<AllowNullLiteral>] IPositionedData =
    inherit IPositionDirectionalHintData
    /// The new position of the element.
    abstract elementPosition: IPosition with get, set
    /// The finalized target edge that element is aligning to. For instance RectangleEdge.bottom would mean
    /// that the bottom edge of the target is being aligned to by the RectangleEdge.top of the element
    /// that is being positioned.
    abstract targetEdge: RectangleEdge with get, set
    /// The finalized alignment edge that the element is aligning too. For instance, RectangleEdge.left means
    /// that the left edge of the target should be in line with the left edge of the element being positioned.
    abstract alignmentEdge: RectangleEdge option with get, set

type [<AllowNullLiteral>] ICalloutPositionedInfo =
    inherit IPositionedData
    abstract beakPosition: ICalloutBeakPositionedInfo with get, set

type [<AllowNullLiteral>] ICalloutBeakPositionedInfo =
    inherit IPositionedData
    abstract closestEdge: RectangleEdge with get, set

/// Gives the position of some element on the page. Only a pair of vertical and horizontal edges need to be
/// given. So top/left or bottom/left is sufficient.
/// The number given is the distance in pixels from whatever host was given..
/// So bottom: 100 would be 100px up from the bottom of the host while top: 100px from the top.
type [<AllowNullLiteral>] IPosition =
    abstract top: float option with get, set
    abstract left: float option with get, set
    abstract bottom: float option with get, set
    abstract right: float option with get, set
    [<Emit "$0[$1]{{=$2}}">] abstract Item: key: string -> float option with get, set

type [<AllowNullLiteral>] ICalloutPositon =
    inherit IPosition

type [<AllowNullLiteral>] IPoint =
    abstract x: float with get, set
    abstract y: float with get, set

type [<AllowNullLiteral>] IPositionDirectionalHintData =
    abstract targetEdge: RectangleEdge with get, set
    abstract alignmentEdge: RectangleEdge option with get, set
    abstract isAuto: bool option with get, set

type [<AllowNullLiteral>] IRelativePositions =
    abstract calloutPosition: ICalloutPositon with get, set
    abstract beakPosition: obj with get, set
    abstract directionalClassName: string with get, set
    abstract submenuDirection: DirectionalHint with get, set
type DirectionalHint = ______common_DirectionalHint.DirectionalHint
type Rectangle as FullRectangle = ______Utilities.Rectangle as FullRectangle
type IRectangle = ______Utilities.IRectangle
type IPositionDirectionalHintData = __positioning_types.IPositionDirectionalHintData
type IPositionedData = __positioning_types.IPositionedData
type IPoint = __positioning_types.IPoint
type ICalloutPositionedInfo = __positioning_types.ICalloutPositionedInfo
type IPositionProps = __positioning_types.IPositionProps
type RectangleEdge = __positioning_types.RectangleEdge
type IRelativePositions = __positioning_types.IRelativePositions
let [<Import("","office-ui-fabric-react")>] __positioningTestPackage: obj = jsNative

type [<AllowNullLiteral>] IExports =
    abstract Rectangle: RectangleStatic
    /// <param name="props"></param>
    /// <param name="hostElement"></param>
    /// <param name="elementToPosition"></param>
    abstract _getRelativePositions: props: IPositionProps * hostElement: HTMLElement * elementToPosition: HTMLElement -> IRelativePositions
    /// <param name="props"></param>
    /// <param name="hostElement"></param>
    /// <param name="calloutElement"></param>
    abstract getRelativePositions: props: IPositionProps * hostElement: HTMLElement * calloutElement: HTMLElement -> IRelativePositions
    /// <summary>Used to position an element relative to the given positioning props.
    /// If positioning has been completed before, previousPositioningData
    /// can be passed to ensure that the positioning element repositions based on
    /// its previous targets rather than starting with directionalhint.</summary>
    /// <param name="props"></param>
    /// <param name="hostElement"></param>
    /// <param name="elementToPosition"></param>
    /// <param name="previousPositions"></param>
    abstract positionElement: props: IPositionProps * hostElement: HTMLElement * elementToPosition: HTMLElement * ?previousPositions: IPositionedData -> IPositionedData
    abstract positionCallout: props: IPositionProps * hostElement: HTMLElement * elementToPosition: HTMLElement * ?previousPositions: ICalloutPositionedInfo -> ICalloutPositionedInfo
    /// Get's the maximum height that a rectangle can have in order to fit below or above a target.
    /// If the directional hint specifies a left or right edge (i.e. leftCenter) it will limit the height to the topBorder
    /// of the target given.
    /// If no bounds are provided then the window is treated as the bounds.
    abstract getMaxHeight: target: U3<Element, MouseEvent, IPoint> * targetEdge: DirectionalHint * ?gapSpace: float * ?bounds: IRectangle * ?coverTarget: bool -> float

type [<AllowNullLiteral>] Rectangle =
    inherit FullRectangle
    [<Emit "$0[$1]{{=$2}}">] abstract Item: key: string -> U3<float, bool, obj option> with get, set

type [<AllowNullLiteral>] RectangleStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> Rectangle

/// Do not call methods from this directly, use either positionCallout or positionElement or make another function that
/// utilizes them.
/// START Private functions and interfaces
type [<AllowNullLiteral>] IElementPosition =
    abstract elementRectangle: Rectangle with get, set
    abstract targetEdge: RectangleEdge with get, set
    abstract alignmentEdge: RectangleEdge option with get, set

type [<AllowNullLiteral>] IElementPositionInfo =
    inherit IElementPosition
    abstract targetRectangle: Rectangle with get, set
type IStyle = ______Styling.IStyle
type ITheme = ______Styling.ITheme
type DirectionalHint = ______common_DirectionalHint.DirectionalHint
type IPoint = ______Utilities.IPoint
type IRectangle = ______Utilities.IRectangle
type ICalloutPositionedInfo = ______utilities_positioning.ICalloutPositionedInfo
type IStyleFunction = ______Utilities.IStyleFunction

type [<AllowNullLiteral>] ICallout =
    interface end

type [<AllowNullLiteral>] ICalloutProps =
    /// Optional callback to access the ICallout interface. Use this instead of ref for accessing
    /// the public methods and properties of the component.
    abstract componentRef: (ICallout option -> unit) option with get, set
    /// The target that the Callout should try to position itself based on.
    /// It can be either an Element a querySelector string of a valid Element
    /// or a MouseEvent. If MouseEvent is given then the origin point of the event will be used.
    abstract target: U4<Element, string, MouseEvent, IPoint> option with get, set
    /// How the element should be positioned
    abstract directionalHint: DirectionalHint option with get, set
    /// How the element should be positioned in RTL layouts.
    /// If not specified, a mirror of `directionalHint` will be used instead
    abstract directionalHintForRTL: DirectionalHint option with get, set
    /// The gap between the Callout and the target
    abstract gapSpace: float option with get, set
    /// The width of the beak.
    abstract beakWidth: float option with get, set
    /// Custom width for callout including borders. If value is 0, no width is applied.
    abstract calloutWidth: float option with get, set
    /// The background color of the Callout in hex format ie. #ffffff.
    abstract backgroundColor: string option with get, set
    /// The bounding rectangle for which  the contextual menu can appear in.
    abstract bounds: IRectangle option with get, set
    /// The minimum distance the callout will be away from the edge of the screen.
    ///   
    abstract minPagePadding: float option with get, set
    /// If true use a point rather than rectangle to position the Callout.
    /// For example it can be used to position based on a click.
    abstract useTargetPoint: bool option with get, set
    /// Point used to position the Callout
    abstract targetPoint: IPoint option with get, set
    /// If true then the beak is visible. If false it will not be shown.
    abstract isBeakVisible: bool option with get, set
    /// If true then the onClose will not not dismiss on scroll
    abstract preventDismissOnScroll: bool option with get, set
    /// If true the position returned will have the menu element cover the target.
    /// If false then it will position next to the target;
    abstract coverTarget: bool option with get, set
    /// Aria role assigned to the callout (Eg. dialog, alertdialog).
    abstract role: string option with get, set
    /// Accessible label text for callout.
    abstract ariaLabel: string option with get, set
    /// Defines the element id referencing the element containing label text for callout.
    abstract ariaLabelledBy: string option with get, set
    /// Defines the element id referencing the element containing the description for the callout.
    abstract ariaDescribedBy: string option with get, set
    /// CSS class to apply to the callout.
    abstract className: string option with get, set
    /// Optional callback when the layer content has mounted.
    abstract onLayerMounted: (unit -> unit) option with get, set
    /// Optional callback that is called once the callout has been correctly positioned.
    abstract onPositioned: (ICalloutPositionedInfo -> unit) option with get, set
    /// Callback when the Callout tries to close.
    abstract onDismiss: (obj option -> unit) option with get, set
    /// If true do not render on a new layer. If false render on a new layer.
    abstract doNotLayer: bool option with get, set
    /// If true the position will not change sides in an attempt to fit the callout within bounds.
    /// It will still attempt to align it to whatever bounds are given.
    abstract directionalHintFixed: bool option with get, set
    /// Specify the final height of the content.
    /// To be used when expanding the content dynamically so that callout can adjust its position.
    abstract finalHeight: float option with get, set
    /// If true then the callout will attempt to focus the first focusable element that it contains.
    /// If it doesn't find an element, no focus will be set and the method will return false.
    /// This means that it's the contents responsibility to either set focus or have
    /// focusable items.
    abstract setInitialFocus: bool option with get, set
    /// Deprecated at v0.59.1, to be removed at >= v1.0.0. Pass in a beakWidth to dictate size.
    abstract beakStyle: string option with get, set
    /// Set max height of callout
    /// When not set the callout will expand with contents up to the bottom of the screen
    abstract calloutMaxHeight: float option with get, set
    /// Callback when the Callout body is scrolled.
    abstract onScroll: (unit -> unit) option with get, set
    /// Optional theme for component
    abstract theme: ITheme option with get, set
    /// Optional styles for the component.
    abstract getStyles: IStyleFunction<ICalloutContentStyleProps, ICalloutContentStyles> option with get, set
    /// If specified, renders the Callout in a hidden state.
    /// Use this flag, rather than rendering a callout conditionally based on visibility,
    /// to improve rendering performance when it becomes visible.
    /// Note: When callout is hidden its content will not be rendered. It will only render
    /// once the callout is visible.
    abstract hidden: bool option with get, set

type [<AllowNullLiteral>] ICalloutContentStyleProps =
    /// Theme to apply to the calloutContent.
    abstract theme: ITheme with get, set
    /// Width for callout including borders.
    abstract calloutWidth: float option with get, set
    /// CSS class to apply to the callout.
    abstract className: string option with get, set
    /// Callout positioning data
    abstract positions: ICalloutPositionedInfo option with get, set
    /// Whether or not to clip content of the callout,
    /// if it overflows vertically.
    abstract overflowYHidden: bool option with get, set
    abstract contentMaxHeight: float option with get, set
    /// Background color for the beak and callout.
    abstract backgroundColor: string option with get, set
    /// Width of Callout beak
    abstract beakWidth: float option with get, set
    /// Deprecated at v0.59.1, to be removed at >= v1.0.0. Pass in a beakWidth to dictate size.
    abstract beakStyle: string option with get, set

type [<AllowNullLiteral>] ICalloutContentStyles =
    /// Style for wrapper of Callout component.
    abstract container: IStyle with get, set
    /// Style for callout container root element.
    abstract root: IStyle with get, set
    /// Style for callout beak.
    abstract beak: IStyle with get, set
    /// Style for callout beak curtain.
    abstract beakCurtain: IStyle with get, set
    /// Style for content component of the callout.
    abstract calloutMain: IStyle with get, set
type ICalloutProps = __Callout_types.ICalloutProps
type DirectionalHint = ______common_DirectionalHint.DirectionalHint
type BaseComponent = ______Utilities.BaseComponent
type ICalloutPositionedInfo = ______utilities_positioning.ICalloutPositionedInfo

type [<AllowNullLiteral>] IExports =
    abstract CalloutContentBase: CalloutContentBaseStatic

type [<AllowNullLiteral>] ICalloutState =
    abstract positions: ICalloutPositionedInfo option with get, set
    abstract slideDirectionalClassName: string option with get, set
    abstract calloutElementRect: ClientRect option with get, set
    abstract heightOffset: float option with get, set

type [<AllowNullLiteral>] CalloutContentBase =
    inherit BaseComponent<ICalloutProps, ICalloutState>
    abstract defaultProps: obj with get, set
    abstract _classNames: obj with get, set
    abstract _didSetInitialFocus: obj with get, set
    abstract _hostElement: obj with get, set
    abstract _calloutElement: obj with get, set
    abstract _targetWindow: obj with get, set
    abstract _bounds: obj with get, set
    abstract _positionAttempts: obj with get, set
    abstract _target: obj with get, set
    abstract _setHeightOffsetTimer: obj with get, set
    abstract _hasListeners: obj with get, set
    abstract _maxHeight: obj with get, set
    abstract componentDidUpdate: unit -> unit
    abstract componentWillMount: unit -> unit
    abstract componentWillUpdate: newProps: ICalloutProps -> unit
    abstract componentDidMount: unit -> unit
    abstract render: unit -> JSX.Element option
    abstract dismiss: (U3<Event, React.KeyboardEvent<HTMLElement>, React.MouseEvent<HTMLElement>> option -> unit) with get, set
    abstract _dismissOnScroll: ev: Event -> unit
    abstract _dismissOnLostFocus: ev: Event -> unit
    abstract _setInitialFocus: (unit -> unit) with get, set
    abstract _onComponentDidMount: (unit -> unit) with get, set
    abstract _addListeners: unit -> unit
    abstract _removeListeners: unit -> unit
    abstract _updateAsyncPosition: unit -> unit
    abstract _getBeakPosition: unit -> unit
    abstract _updatePosition: unit -> unit
    abstract _getBounds: unit -> unit
    abstract _getMaxHeight: unit -> unit
    abstract _arePositionsEqual: positions: obj * newPosition: obj -> unit
    abstract _comparePositions: oldPositions: obj * newPositions: obj -> unit
    abstract _setTargetWindowAndElement: target: obj -> unit
    abstract _setHeightOffsetEveryFrame: unit -> unit
    abstract _getTarget: ?props: obj -> unit

type [<AllowNullLiteral>] CalloutContentBaseStatic =
    [<Emit "new $0($1...)">] abstract Create: props: ICalloutProps -> CalloutContentBase
type BaseComponent = ______Utilities.BaseComponent
type ICalloutProps = __Callout_types.ICalloutProps
type ICalloutState = __CalloutContent_base.ICalloutState

type [<AllowNullLiteral>] IExports =
    abstract Callout: CalloutStatic

type [<AllowNullLiteral>] Callout =
    inherit BaseComponent<ICalloutProps, ICalloutState>
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] CalloutStatic =
    [<Emit "new $0($1...)">] abstract Create: props: ICalloutProps -> Callout

type [<AllowNullLiteral>] IExports =
    /// Allows a server rendered scenario to provide a default responsive mode.
    abstract setResponsiveMode: responsiveMode: ResponsiveMode option -> unit
    abstract withResponsiveMode: ComposedComponent: obj -> obj option

type [<AllowNullLiteral>] IWithResponsiveModeState =
    abstract responsiveMode: ResponsiveMode option with get, set

type [<RequireQualifiedAccess>] ResponsiveMode =
    | Small = 0
    | Medium = 1
    | Large = 2
    | XLarge = 3
    | XxLarge = 4
    | XxxLarge = 5
type ITheme = ______Styling.ITheme

type [<AllowNullLiteral>] IVerticalDividerProps =
    /// Optional function to generate the class names for the divider for custom styling
    abstract getClassNames: (ITheme -> IVerticalDividerClassNames) option with get, set

type [<AllowNullLiteral>] IVerticalDividerClassNames =
    abstract wrapper: string with get, set
    abstract divider: string with get, set
type ITheme = ______Styling.ITheme
type IVerticalDividerClassNames = ___Divider_VerticalDivider_types.IVerticalDividerClassNames
let [<Import("","office-ui-fabric-react")>] getSplitButtonVerticalDividerClassNames: (ITheme -> IVerticalDividerClassNames) = jsNative
let [<Import("","office-ui-fabric-react")>] getContextualMenuClassNames: (ITheme -> string option -> IContextualMenuClassNames) = jsNative
let [<Import("","office-ui-fabric-react")>] getItemClassNames: (ITheme -> bool -> bool -> bool -> bool -> bool -> string option -> string option -> string option -> string option -> bool option -> IMenuItemClassNames) = jsNative

type [<AllowNullLiteral>] IContextualMenuClassNames =
    abstract container: string with get, set
    abstract root: string with get, set
    abstract list: string with get, set
    abstract header: string with get, set
    abstract title: string with get, set

type [<AllowNullLiteral>] IMenuItemClassNames =
    abstract item: string with get, set
    abstract divider: string with get, set
    abstract root: string with get, set
    abstract linkContent: string with get, set
    abstract icon: string with get, set
    abstract checkmarkIcon: string with get, set
    abstract subMenuIcon: string with get, set
    abstract label: string with get, set
    abstract secondaryText: string with get, set
    abstract splitContainer: string with get, set
    abstract splitPrimary: string with get, set
    abstract splitMenu: string with get, set
    abstract linkContentMenu: string with get, set
type IContextualMenuItem = __ContextualMenu_types.IContextualMenuItem
type IMenuItemClassNames = __ContextualMenu_classNames.IMenuItemClassNames

type [<AllowNullLiteral>] IContextualMenuRenderItem =
    /// Function to open this item's subMenu, if present.
    abstract openSubMenu: (unit -> unit) with get, set
    /// Function to close this item's subMenu, if present.
    abstract dismissSubMenu: (unit -> unit) with get, set
    /// Dismiss the menu this item belongs to.
    abstract dismissMenu: (bool -> unit) with get, set

type [<AllowNullLiteral>] IContextualMenuItemProps =
    inherit React.HTMLAttributes<IContextualMenuItemProps>
    /// Optional callback to access the IContextualMenuRenderItem interface. Use this instead of ref for accessing
    /// the public methods and properties of the component.
    abstract componentRef: (IContextualMenuRenderItem option -> unit) option with get, set
    /// The item to display
    abstract item: IContextualMenuItem with get, set
    /// Classnames for different aspects of a menu item
    abstract classNames: IMenuItemClassNames with get, set
    /// Index of the item
    abstract index: float with get, set
    /// If this item has icons
    abstract hasIcons: bool option with get, set
    /// Click handler for the checkmark
    abstract onCheckmarkClick: (IContextualMenuItem -> React.MouseEvent<HTMLElement> -> unit) option with get, set
    /// This prop will get set by ContextualMenu and can be called to open this item's subMenu, if present.
    abstract openSubMenu: (obj option -> HTMLElement -> unit) option with get, set
    /// This prop will get set by ContextualMenu and can be called to close this item's subMenu, if present.
    abstract dismissSubMenu: (unit -> unit) option with get, set
    /// This prop will get set by ContextualMenu and can be called to close the menu this item belongs to.
    /// If dismissAll is true, all menus will be closed.
    abstract dismissMenu: (obj option -> bool -> unit) option with get, set
    /// This prop will get set by the wrapping component and will return the element that wraps this ContextualMenuItem.
    /// Used for openSubMenu.
    abstract getSubmenuTarget: (unit -> HTMLElement option) option with get, set
type ICalloutProps = ______Callout.ICalloutProps
type IStyle = ______Styling.IStyle
type ITheme = ______Styling.ITheme
type IStyleFunction = ______Utilities.IStyleFunction
type IPoint = ______Utilities.IPoint

type [<AllowNullLiteral>] IKeytip =
    interface end

type [<AllowNullLiteral>] IKeytipProps =
    /// Optional callback to access the Keytip component. Use this instead of ref for accessing
    /// the public methods and properties of the component.
    abstract componentRef: (IKeytip option -> unit) option with get, set
    /// Content to put inside the keytip
    abstract content: string with get, set
    /// Theme for the component
    abstract theme: ITheme option with get, set
    /// T/F if the corresponding control for this keytip is disabled
    abstract disabled: bool option with get, set
    /// T/F if the keytip is visible
    abstract visible: bool option with get, set
    /// Function to call when this keytip is activated
    /// 'el' is the DOM element marked with 'data-ktp-execute-target'
    abstract onExecute: (HTMLElement option -> unit) option with get, set
    /// Function to call when the keytip is returned to
    /// 'el' is the DOM element marked with 'data-ktp-execute-target'
    abstract onReturn: (HTMLElement option -> unit) option with get, set
    /// Array of KeySequences which is the full key sequence to trigger this keytip
    /// Should not include initial 'start' key sequence
    abstract keySequences: ResizeArray<string> with get, set
    /// Full KeySequence of the overflow set button, will be set automatically if this keytip is inside an overflow
    abstract overflowSetSequence: ResizeArray<string> option with get, set
    /// ICalloutProps to pass to the callout element
    abstract calloutProps: ICalloutProps option with get, set
    /// Optional styles for the component.
    abstract getStyles: IStyleFunction<IKeytipStyleProps, IKeytipStyles> option with get, set
    /// Offset x and y for the keytip, added from the top-left corner
    /// By default the keytip will be anchored to the bottom-center of the element
    abstract offset: IPoint option with get, set
    /// Whether or not this keytip will have children keytips that are dynamically created (DOM is generated on keytip activation)
    /// Common cases are a Pivot or Modal
    abstract hasDynamicChildren: bool option with get, set
    /// Whether or not this keytip belongs to a component that has a menu
    /// Keytip mode will stay on when a menu is opened, even if the items in that menu have no keytips
    abstract hasMenu: bool option with get, set

/// Props to style Keytip component
type [<AllowNullLiteral>] IKeytipStyleProps =
    /// The theme for the keytip.
    abstract theme: ITheme with get, set
    /// Whether the keytip is disabled or not.
    abstract disabled: bool option with get, set
    /// T/F if the keytip is visible
    abstract visible: bool option with get, set

type [<AllowNullLiteral>] IKeytipStyles =
    /// Style for the div container surrounding the keytip content.
    abstract container: IStyle with get, set
    /// Style for the keytip content element.
    abstract root: IStyle with get, set
type BaseComponent = ______Utilities.BaseComponent
type IKeytip = __Keytip_types.IKeytip
type IKeytipProps = __Keytip_types.IKeytipProps

type [<AllowNullLiteral>] IExports =
    abstract Keytip: KeytipStatic

/// A callout corresponding to another Fabric component to describe a key sequence that will activate that component
type [<AllowNullLiteral>] Keytip =
    inherit BaseComponent<IKeytipProps, obj>
    inherit IKeytip
    abstract render: unit -> JSX.Element

/// A callout corresponding to another Fabric component to describe a key sequence that will activate that component
type [<AllowNullLiteral>] KeytipStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> Keytip
type DirectionalHint = ______common_DirectionalHint.DirectionalHint
type FocusZoneDirection = ______FocusZone.FocusZoneDirection
type IFocusZoneProps = ______FocusZone.IFocusZoneProps
type IIconProps = ___Icon_Icon_types.IIconProps
type ICalloutProps = ______Callout.ICalloutProps
type ITheme = ______Styling.ITheme
type IStyle = ______Styling.IStyle
type IButtonStyles = ______Button.IButtonStyles
type IPoint = ______Utilities.IPoint
type IRectangle = ______Utilities.IRectangle
type IRenderFunction = ______Utilities.IRenderFunction
type IWithResponsiveModeState = ______utilities_decorators_withResponsiveMode.IWithResponsiveModeState
type IContextualMenuClassNames = __ContextualMenu_classNames.IContextualMenuClassNames
type IMenuItemClassNames = __ContextualMenu_classNames.IMenuItemClassNames
type IVerticalDividerClassNames = ___Divider_VerticalDivider_types.IVerticalDividerClassNames
type IContextualMenuItemProps = __ContextualMenuItem_types.IContextualMenuItemProps
type IContextualMenuRenderItem = __ContextualMenuItem_types.IContextualMenuRenderItem
type IKeytipProps = ______Keytip.IKeytipProps

type [<RequireQualifiedAccess>] ContextualMenuItemType =
    | Normal = 0
    | Divider = 1
    | Header = 2
    | Section = 3

type [<AllowNullLiteral>] IContextualMenu =
    interface end

/// React.Props is deprecated and we're removing it in 6.0. Usage of 'any' should go away with it.
type [<AllowNullLiteral>] IContextualMenuProps =
    inherit React.Props<obj option>
    inherit IWithResponsiveModeState
    /// Optional callback to access the IContextualMenu interface. Use this instead of ref for accessing
    /// the public methods and properties of the component.
    abstract componentRef: (IContextualMenu option -> unit) option with get, set
    /// The target that the ContextualMenu should try to position itself based on.
    /// It can be either an Element a querySelector string of a valid Element
    /// or a MouseEvent. If MouseEvent is given then the origin point of the event will be used.
    abstract target: U4<Element, string, MouseEvent, IPoint> option with get, set
    /// How the element should be positioned
    abstract directionalHint: DirectionalHint option with get, set
    /// How the element should be positioned in RTL layouts.
    /// If not specified, a mirror of `directionalHint` will be used instead
    abstract directionalHintForRTL: DirectionalHint option with get, set
    /// The gap between the ContextualMenu and the target
    abstract gapSpace: float option with get, set
    /// The width of the beak.
    abstract beakWidth: float option with get, set
    /// If true the context menu will render as the same width as the target element
    abstract useTargetWidth: bool option with get, set
    /// If true the context menu will have a minimum width equal to the width of the target element
    abstract useTargetAsMinWidth: bool option with get, set
    /// The bounding rectangle for which the contextual menu can appear in.
    abstract bounds: IRectangle option with get, set
    /// If true use a point rather than rectangle to position the ContextualMenu.
    /// For example it can be used to position based on a click.
    abstract useTargetPoint: bool option with get, set
    /// Point used to position the ContextualMenu
    abstract targetPoint: IPoint option with get, set
    /// If true then the beak is visible. If false it will not be shown.
    abstract isBeakVisible: bool option with get, set
    /// If true the position returned will have the menu element cover the target.
    /// If false then it will position next to the target;
    abstract coverTarget: bool option with get, set
    /// Collection of menu items.
    abstract items: ResizeArray<IContextualMenuItem> with get, set
    /// Aria Labelled by labelElementId
    abstract labelElementId: string option with get, set
    /// Whether to focus on the menu when mounted.
    abstract shouldFocusOnMount: bool option with get, set
    /// Whether to focus on the contextual menu container (as opposed to the first menu item).
    abstract shouldFocusOnContainer: bool option with get, set
    /// Callback when the ContextualMenu tries to close. If dismissAll is true then all
    /// submenus will be dismissed.
    abstract onDismiss: (obj option -> bool -> unit) option with get, set
    /// Click handler which is invoked if onClick is not passed for individual contextual
    /// menu item.
    /// Returning true will dismiss the menu even if ev.preventDefault() was called.
    abstract onItemClick: (U2<React.MouseEvent<HTMLElement>, React.KeyboardEvent<HTMLElement>> -> IContextualMenuItem -> U2<bool, unit>) option with get, set
    /// CSS class to apply to the context menu.
    abstract className: string option with get, set
    /// Whether this menu is a submenu of another menu or not.
    abstract isSubMenu: bool option with get, set
    /// DOM id to tag the ContextualMenu with, for reference.
    /// Should be used for 'aria-owns' and other such uses, rather than direct reference for programmatic purposes.
    abstract id: string option with get, set
    /// Aria label for accessibility for the ContextualMenu.
    /// If none specified no aria label will be applied to the ContextualMenu.
    abstract ariaLabel: string option with get, set
    /// If true do not render on a new layer. If false render on a new layer.
    abstract doNotLayer: bool option with get, set
    /// Direction for arrow navigation of the ContextualMenu. Should only be specified if using custom-rendered menu items.
    abstract arrowDirection: FocusZoneDirection option with get, set
    /// If true the position will not change sides in an attempt to fit the ContextualMenu within bounds.
    /// It will still attempt to align it to whatever bounds are given.
    abstract directionalHintFixed: bool option with get, set
    /// Callback for when the contextualmenu has been opened.
    abstract onMenuOpened: (IContextualMenuProps -> unit) option with get, set
    /// Callback for when the contextualmenu is being closed (removing from the DOM)
    abstract onMenuDismissed: (IContextualMenuProps -> unit) option with get, set
    /// Pass in custom callout props
    abstract calloutProps: ICalloutProps option with get, set
    /// Optional title to be displayed on top of the menu.
    abstract title: string option with get, set
    /// Custom styling for the contextual menu.
    abstract styles: IContextualMenuStyles option with get, set
    /// Theme provided by HOC.
    abstract theme: ITheme option with get, set
    /// Method to provide the classnames to style the contextual menu. Default value is the getMenuClassnames func
    /// defined in ContextualMenu.classnames.
    abstract getMenuClassNames: (ITheme -> string -> IContextualMenuClassNames) option with get, set
    /// Method to call when trying to render a submenu. 
    abstract onRenderSubMenu: IRenderFunction<IContextualMenuProps> option with get, set
    /// Delay (in milliseconds) to wait before expanding / dismissing a submenu on mouseEnter or mouseLeave
    abstract subMenuHoverDelay: float option with get, set
    /// Method to override the render of the individual menu items
    abstract contextualMenuItemAs: U2<React.ComponentClass<IContextualMenuItemProps>, React.StatelessComponent<IContextualMenuItemProps>> option with get, set
    /// Props to pass down to the FocusZone.
    /// NOTE: the default FocusZoneDirection will be used unless a direction
    /// is specified in the focusZoneProps (even if other focusZoneProps are defined)
    abstract focusZoneProps: IFocusZoneProps option with get, set
    /// If specified, renders the ContextualMenu in a hidden state.
    /// Use this flag, rather than rendering a ContextualMenu conditionally based on visibility,
    /// to improve rendering performance when it becomes visible.
    /// Note: When ContextualMenu is hidden its content will not be rendered. It will only render
    /// once the ContextualMenu is visible.
    abstract hidden: bool option with get, set

type [<AllowNullLiteral>] IContextualMenuItem =
    /// Optional callback to access the IContextualMenuRenderItem interface. This will get passed down to ContextualMenuItem.
    abstract componentRef: (IContextualMenuRenderItem option -> unit) option with get, set
    /// Unique id to identify the item
    abstract key: string with get, set
    /// Text description for the menu item to display
    abstract name: string option with get, set
    /// Seconday description for the menu item to display
    abstract secondaryText: string option with get, set
    abstract itemType: ContextualMenuItemType option with get, set
    /// Props that go to the IconComponent
    abstract iconProps: IIconProps option with get, set
    /// Custom render function for the menu item icon
    abstract onRenderIcon: IRenderFunction<IContextualMenuItemProps> option with get, set
    /// Props that go to the IconComponent used for the chevron.
    abstract submenuIconProps: IIconProps option with get, set
    /// Deprecated at v0.69.0 and will no longer exist after 1.0 use IconProps instead.
    abstract icon: string option with get, set
    /// Whether the menu item is disabled
    abstract disabled: bool option with get, set
    /// If the menu item is a split button, this prop disables purely the primary action of the button.
    abstract primaryDisabled: bool option with get, set
    /// Deprecated at v0.65.1 and will be removed by v 1.0. Use 'disabled' instead.
    abstract isDisabled: bool option with get, set
    /// [TODO] Not Yet Implemented
    abstract shortCut: string option with get, set
    /// Whether or not this menu item can be checked
    abstract canCheck: bool option with get, set
    /// Whether or not this menu item is currently checked.
    abstract ``checked``: bool option with get, set
    /// Deprecated at v.65.1 and will be removed by v 1.0. Use 'checked' instead.
    abstract isChecked: bool option with get, set
    /// Whether or not this menu item is a splitButton.
    abstract split: bool option with get, set
    /// Any custom data the developer wishes to associate with the menu item.
    abstract data: obj option with get, set
    /// Callback issued when the menu item is invoked. If ev.preventDefault() is called in onClick, click will not close menu.
    /// Returning true will dismiss the menu even if ev.preventDefault() was called.
    abstract onClick: (U2<React.MouseEvent<HTMLElement>, React.KeyboardEvent<HTMLElement>> -> IContextualMenuItem -> U2<bool, unit>) option with get, set
    /// An optional URL to navigate to upon selection
    abstract href: string option with get, set
    /// An optional target when using href
    abstract target: string option with get, set
    /// An optional rel when using href. If target is _blank rel is defaulted to a value to prevent clickjacking.
    abstract rel: string option with get, set
    /// Deprecated at v.80.0 and will be removed by v 1.0. Use 'subMenuProps' instead.
    abstract items: ResizeArray<IContextualMenuItem> option with get, set
    /// Properties to apply to a submenu to this item.
    /// The ContextualMenu will provide default values for 'target', 'onDismiss', 'isSubMenu',
    ///   'id', 'shouldFocusOnMount', 'directionalHint', 'className', and 'gapSpace', all of which
    ///   can be overridden.
    abstract subMenuProps: IContextualMenuProps option with get, set
    /// Method to provide the classnames to style the individual items inside a menu. Default value is the getItemClassnames func
    /// defined in ContextualMenu.classnames.
    abstract getItemClassNames: (ITheme -> bool -> bool -> bool -> bool -> bool -> string -> string -> string -> string -> bool -> IMenuItemClassNames) option with get, set
    /// Method to provide the classnames to style the Vertical Divider of a split button inside a menu. Default value is the getVerticalDividerClassnames func defined in ContextualMenu.classnames
    abstract getSplitButtonVerticalDividerClassNames: (ITheme -> IVerticalDividerClassNames) option with get, set
    /// Properties to apply to render this item as a section.
    /// This prop is mutually exclusive with subMenuProps.
    abstract sectionProps: IContextualMenuSection option with get, set
    /// Additional css class to apply to the menu item
    abstract className: string option with get, set
    /// Additional styles to apply to the menu item
    abstract style: React.CSSProperties option with get, set
    /// Optional accessibility label (aria-label) attribute that will be stamped on to the element.
    /// If none is specified, the aria-label attribute will contain the item name
    abstract ariaLabel: string option with get, set
    /// Optional title for displaying text when hovering over an item.
    abstract title: string option with get, set
    /// Method to custom render this menu item.
    /// For keyboard accessibility, the top-level rendered item should be a focusable element
    /// (like an anchor or a button) or have the `data-is-focusable` property set to true.
    /// 
    /// The function receives a function that can be called to dismiss the menu as a second argument.
    ///   This can be used to make sure that a custom menu item click dismisses the menu.
    abstract onRender: (obj option -> (obj option -> bool -> unit) -> React.ReactNode) option with get, set
    /// A function to be executed onMouseDown. This is executed before an onClick event and can
    /// be used to interrupt native on click events as well. The click event should still handle
    /// the commands. This should only be used in special cases when react and non-react are mixed.
    abstract onMouseDown: (IContextualMenuItem -> obj option -> unit) option with get, set
    /// Optional override for the role attribute on the menu button. If one is not provided, it will
    /// have a value of menuitem or menuitemcheckbox.
    abstract role: string option with get, set
    /// When rendering a custom component that is passed in, the component might also be a list of
    /// elements. We want to keep track of the correct index our menu is using based off of
    /// the length of the custom list. It is up to the user to increment the count for their list.
    abstract customOnRenderListLength: float option with get, set
    /// Keytip for this contextual menu item
    abstract keytipProps: IKeytipProps option with get, set
    /// Any additional properties to use when custom rendering menu items.
    [<Emit "$0[$1]{{=$2}}">] abstract Item: propertyName: string -> obj option with get, set
    /// Optional prop to make an item readonly which is disabled but visitable by keyboard, will apply aria-readonly and some styling. Not supported by all components
    abstract inactive: bool option with get, set

/// React.Props is deprecated and we're removing it in 6.0. Usage of 'any' should go away with it.
type [<AllowNullLiteral>] IContextualMenuSection =
    inherit React.Props<obj option>
    /// The items to include inside the section.
    abstract items: ResizeArray<IContextualMenuItem> with get, set
    /// The optional section title.
    abstract title: string option with get, set
    /// If set to true, the section will display a divider at the top of the section.
    abstract topDivider: bool option with get, set
    /// If set to true, the section will display a divider at the bottom of the section.
    abstract bottomDivider: bool option with get, set

type [<AllowNullLiteral>] IMenuItemStyles =
    inherit IButtonStyles
    /// Styles for a menu item that is an anchor link.
    abstract item: IStyle with get, set
    /// Styles for the content inside the button/link of the menuItem.
    abstract linkContent: IStyle with get, set
    /// Styles for a menu item that is an anchor link.
    abstract anchorLink: IStyle with get, set
    /// Default icon color style for known icons.
    abstract iconColor: IStyle with get, set
    /// Default style for checkmark icons.
    abstract checkmarkIcon: IStyle with get, set
    /// Styles for the submenu icon of a menu item.
    abstract subMenuIcon: IStyle with get, set
    /// Styles for a divider item of a ConextualMenu.
    abstract divider: IStyle with get, set
    /// Styles for a split button divider in a menu item
    abstract splitButtonSeparator: IStyle with get, set

type [<AllowNullLiteral>] IContextualMenuStyles =
    /// Style override for the contextual menu title.
    abstract title: IStyle with get, set
    /// Style for the container which parents all menu items.
    abstract container: IStyle with get, set
    /// Base styles for the root element of all ContextualMenus.
    abstract root: IStyle with get, set
    /// Styles for the header item of a ContextualMenu
    abstract header: IStyle with get, set
    /// Styles for the list that contains all menuItems.
    abstract list: IStyle with get, set
type IContextualMenuProps = __ContextualMenu_types.IContextualMenuProps
type IContextualMenuItem = __ContextualMenu_types.IContextualMenuItem
type DirectionalHint = ______common_DirectionalHint.DirectionalHint
type BaseComponent = ______Utilities.BaseComponent

type [<AllowNullLiteral>] IExports =
    abstract getSubmenuItems: item: IContextualMenuItem -> ResizeArray<IContextualMenuItem> option
    /// Returns true if a list of menu items can contain a checkbox
    abstract canAnyMenuItemsCheck: items: ResizeArray<IContextualMenuItem> -> bool
    abstract ContextualMenu: ContextualMenuStatic

type [<AllowNullLiteral>] IContextualMenuState =
    abstract expandedMenuItemKey: string option with get, set
    abstract expandedByMouseClick: bool option with get, set
    abstract dismissedMenuItemKey: string option with get, set
    abstract contextualMenuItems: ResizeArray<IContextualMenuItem> option with get, set
    abstract contextualMenuTarget: Element option with get, set
    abstract submenuTarget: Element option with get, set
    abstract positions: obj option with get, set
    abstract slideDirectionalClassName: string option with get, set
    abstract subMenuId: string option with get, set
    abstract submenuDirection: DirectionalHint option with get, set

type [<AllowNullLiteral>] ContextualMenu =
    inherit BaseComponent<IContextualMenuProps, IContextualMenuState>
    abstract defaultProps: IContextualMenuProps with get, set
    abstract _host: obj with get, set
    abstract _previousActiveElement: obj with get, set
    abstract _isFocusingPreviousElement: obj with get, set
    abstract _enterTimerId: obj with get, set
    abstract _targetWindow: obj with get, set
    abstract _target: obj with get, set
    abstract _classNames: obj with get, set
    abstract _isScrollIdle: obj with get, set
    abstract _scrollIdleTimeoutId: obj with get, set
    abstract _adjustedFocusZoneProps: obj with get, set
    abstract dismiss: (obj option -> bool option -> unit) with get, set
    abstract componentWillUpdate: newProps: IContextualMenuProps -> unit
    abstract componentWillMount: unit -> unit
    abstract componentDidMount: unit -> unit
    abstract componentWillUnmount: unit -> unit
    abstract render: unit -> JSX.Element option
    abstract _onMenuOpened: unit -> unit
    abstract _onMenuClosed: unit -> unit
    /// Gets the focusZoneDirection by using the arrowDirection if specified,
    /// the direction specificed in the focusZoneProps, or defaults to FocusZoneDirection.vertical
    abstract _getFocusZoneDirection: unit -> unit
    abstract _onRenderSubMenu: subMenuProps: obj -> unit
    abstract _renderMenuItem: item: obj * index: obj * focusableElementIndex: obj * totalItemCount: obj * hasCheckmarks: obj * hasIcons: obj -> unit
    abstract _renderSectionItem: item: obj * menuClassNames: obj * index: obj * hasCheckmarks: obj * hasIcons: obj -> unit
    abstract _renderListItem: content: obj * key: obj * classNames: obj * ?title: obj -> unit
    abstract _renderSeparator: index: obj * classNames: obj * ?top: obj * ?fromSection: obj -> unit
    abstract _renderNormalItem: item: obj * classNames: obj * index: obj * focusableElementIndex: obj * totalItemCount: obj * hasCheckmarks: obj * hasIcons: obj -> unit
    abstract _renderHeaderMenuItem: item: obj * classNames: obj * index: obj * hasCheckmarks: obj * hasIcons: obj -> unit
    abstract _renderAnchorMenuItem: item: obj * classNames: obj * index: obj * focusableElementIndex: obj * totalItemCount: obj * hasCheckmarks: obj * hasIcons: obj -> unit
    abstract _renderButtonItem: item: obj * classNames: obj * index: obj * focusableElementIndex: obj * totalItemCount: obj * ?hasCheckmarks: obj * ?hasIcons: obj -> unit
    abstract _renderSplitButton: item: obj * classNames: obj * index: obj * focusableElementIndex: obj * totalItemCount: obj * ?hasCheckmarks: obj * ?hasIcons: obj -> unit
    abstract _getIconProps: item: obj -> unit
    abstract _onKeyDown: obj with get, set
    /// Checks if the submenu should be closed
    abstract _shouldCloseSubMenu: obj with get, set
    abstract _onMenuKeyDown: obj with get, set
    /// Scroll handler for the callout to make sure the mouse events
    /// for updating focus are not interacting during scroll
    abstract _onScroll: obj with get, set
    abstract _onItemMouseEnterBase: obj with get, set
    abstract _onItemMouseMoveBase: obj with get, set
    abstract _onMouseItemLeave: obj with get, set
    /// Handles updating focus when mouseEnter or mouseMove fire.
    /// As part of updating focus, This function will also update
    /// the expand/collapse state accordingly.
    abstract _updateFocusOnMouseEvent: item: obj * ev: obj * ?target: obj -> unit
    abstract _onItemMouseDown: obj with get, set
    abstract _onItemClick: obj with get, set
    abstract _onItemClickBase: obj with get, set
    abstract _onAnchorClick: obj with get, set
    abstract _executeItemClick: obj with get, set
    abstract _onItemKeyDown: obj with get, set
    abstract _cancelSubMenuTimer: obj with get, set
    abstract _onItemSubMenuExpand: obj with get, set
    abstract _getSubmenuProps: unit -> unit
    abstract _findItemByKey: key: obj -> unit
    /// <summary>Returns the item that mathes a given key if any.</summary>
    /// <param name="key">The key of the item to match</param>
    /// <param name="items">The items to look for the key</param>
    abstract _findItemByKeyFromItems: key: obj * items: obj -> unit
    abstract _onSubMenuDismiss: obj with get, set
    abstract _setTargetWindowAndElement: target: obj -> unit
    abstract _getSubMenuId: obj with get, set
    abstract _onPointerAndTouchEvent: obj with get, set

type [<AllowNullLiteral>] ContextualMenuStatic =
    [<Emit "new $0($1...)">] abstract Create: props: IContextualMenuProps -> ContextualMenu
type BaseComponent = ______Utilities.BaseComponent
type IContextualMenuItemProps = __ContextualMenuItem_types.IContextualMenuItemProps

type [<AllowNullLiteral>] IExports =
    abstract ContextualMenuItem: ContextualMenuItemStatic

type [<AllowNullLiteral>] ContextualMenuItem =
    inherit BaseComponent<IContextualMenuItemProps, obj>
    abstract render: unit -> JSX.Element
    abstract openSubMenu: (unit -> unit) with get, set
    abstract dismissSubMenu: (unit -> unit) with get, set
    abstract dismissMenu: (bool option -> unit) with get, set

type [<AllowNullLiteral>] ContextualMenuItemStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> ContextualMenuItem
type BaseComponent = ______Utilities.BaseComponent
type IButtonProps = __Button_types.IButtonProps

type [<AllowNullLiteral>] IExports =
    abstract Button: ButtonStatic

/// This class is deprecated. Use the individual *Button components instead.
type [<AllowNullLiteral>] Button =
    inherit BaseComponent<IButtonProps, obj>
    /// Set this BaseComponent._resolveComponentRef to false, bypassing resolution of componentRef.
    abstract _shouldUpdateComponentRef: bool with get, set
    abstract render: unit -> JSX.Element

/// This class is deprecated. Use the individual *Button components instead.
type [<AllowNullLiteral>] ButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: props: IButtonProps -> Button
type IButtonStyles = __Button_types.IButtonStyles
let [<Import("","office-ui-fabric-react")>] getBaseButtonClassNames: (IButtonStyles -> string -> string -> string option -> string option -> bool -> bool -> bool -> bool option -> IButtonClassNames) = jsNative

type [<AllowNullLiteral>] IButtonClassNames =
    abstract root: string option with get, set
    abstract flexContainer: string option with get, set
    abstract textContainer: string option with get, set
    abstract icon: string option with get, set
    abstract label: string option with get, set
    abstract menuIcon: string option with get, set
    abstract description: string option with get, set
    abstract screenReaderText: string option with get, set
type IButtonStyles = ___Button_types.IButtonStyles
let [<Import("","office-ui-fabric-react")>] getClassNames: (IButtonStyles -> bool -> bool -> bool -> ISplitButtonClassNames) = jsNative

type [<AllowNullLiteral>] ISplitButtonClassNames =
    abstract root: string option with get, set
    abstract icon: string option with get, set
    abstract splitButtonContainer: string option with get, set
    abstract flexContainer: string option with get, set
    abstract divider: string option with get, set
type BaseButton = __BaseButton.BaseButton
type Button = __Button.Button
type IButtonClassNames = __BaseButton_classNames.IButtonClassNames
type ISplitButtonClassNames = __SplitButton_SplitButton_classNames.ISplitButtonClassNames
type IRenderFunction = ______Utilities.IRenderFunction
type KeyCodes = ______Utilities.KeyCodes
type IContextualMenuProps = ______ContextualMenu.IContextualMenuProps
type IIconProps = ______Icon.IIconProps
type IStyle = ______Styling.IStyle
type ITheme = ______Styling.ITheme
type IKeytipProps = ______Keytip.IKeytipProps

type [<AllowNullLiteral>] IButton =
    /// Sets focus to the button.
    abstract focus: (unit -> unit) with get, set
    /// If there is a menu associated with this button and it is visible, this will dismiss the menu
    abstract dismissMenu: (unit -> unit) with get, set
    /// If there is a menu associated with this button and it is visible, this will open the menu
    abstract openMenu: (unit -> unit) with get, set

type [<AllowNullLiteral>] IButtonProps =
    inherit React.AllHTMLAttributes<U5<HTMLAnchorElement, HTMLButtonElement, HTMLDivElement, BaseButton, Button>>
    /// Optional callback to access the IButton interface. Use this instead of ref for accessing
    /// the public methods and properties of the component.
    abstract componentRef: (IButton option -> unit) option with get, set
    /// If provided, this component will be rendered as an anchor.
    abstract href: string option with get, set
    /// Changes the visual presentation of the button to be emphasized (if defined)
    abstract primary: bool option with get, set
    /// Unique id to identify the item. Typically a duplicate of key value.
    abstract uniqueId: U2<string, float> option with get, set
    /// Whether the button is disabled
    abstract disabled: bool option with get, set
    /// If set to true and if this is a splitButton (split == true) then the primary action of a split button is disabled.
    abstract primaryDisabled: bool option with get, set
    /// Custom styling for individual elements within the button DOM.
    abstract styles: IButtonStyles option with get, set
    /// Theme provided by HOC.
    abstract theme: ITheme option with get, set
    /// Whether the button is checked
    abstract ``checked``: bool option with get, set
    /// If provided, additional class name to provide on the root element.
    abstract className: string option with get, set
    /// The aria label of the button for the benefit of screen readers.
    abstract ariaLabel: string option with get, set
    /// Detailed description of the button for the benefit of screen readers.
    /// 
    /// Besides the compound button, other button types will need more information provided to screen reader.
    abstract ariaDescription: string option with get, set
    /// If provided and is true it adds an 'aria-hidden' attribute instructing screen readers to ignore the element.
    abstract ariaHidden: bool option with get, set
    /// Text to render button label. If text is supplied, it will override any string in button children. Other children components will be passed through after the text.
    abstract text: string option with get, set
    /// The props for the icon shown in the button.
    abstract iconProps: IIconProps option with get, set
    /// Props for button menu. Providing this will default to showing the menu icon. See menuIconProps for overriding
    /// how the default icon looks. Providing this in addition of onClick and setting the split property to true will render a SplitButton.
    abstract menuProps: IContextualMenuProps option with get, set
    /// Callback that runs after Button's contextualmenu was closed (removed from the DOM)
    abstract onAfterMenuDismiss: (unit -> unit) option with get, set
    /// If set to true, and if menuProps and onClick are provided, the button will render as a SplitButton. Defaults to false.
    abstract split: bool option with get, set
    /// The props for the icon shown when providing a menu dropdown.
    abstract menuIconProps: IIconProps option with get, set
    /// Accessible label for the dropdown chevron button if this button is split.
    abstract splitButtonAriaLabel: string option with get, set
    /// Optional callback when menu is clicked.
    abstract onMenuClick: (U2<React.MouseEvent<HTMLElement>, React.KeyboardEvent<HTMLElement>> -> IButtonProps -> unit) option with get, set
    /// Custom render function for the icon
    abstract onRenderIcon: IRenderFunction<IButtonProps> option with get, set
    /// Custom render function for the label text.
    abstract onRenderText: IRenderFunction<IButtonProps> option with get, set
    /// Custom render function for the desciption text.
    abstract onRenderDescription: IRenderFunction<IButtonProps> option with get, set
    /// Custom render function for the aria description element.
    abstract onRenderAriaDescription: IRenderFunction<IButtonProps> option with get, set
    /// Custom render function for rendering the button children.
    abstract onRenderChildren: IRenderFunction<IButtonProps> option with get, set
    /// Custom render function for button menu icon
    abstract onRenderMenuIcon: IRenderFunction<IButtonProps> option with get, set
    /// Custom render function for button menu
    abstract onRenderMenu: IRenderFunction<IContextualMenuProps> option with get, set
    /// Description of the action this button takes.
    /// Only used for compound buttons
    abstract secondaryText: string option with get, set
    /// Deprecated at v1.2.3, to be removed at >= v2.0.0. Use specific button component instead
    abstract buttonType: ButtonType option with get, set
    /// Deprecated at v0.56.2, to be removed at >= v1.0.0. Just pass in button props instead;
    /// they will be mixed into the button/anchor element rendered by the component.
    abstract rootProps: U2<React.ButtonHTMLAttributes<HTMLButtonElement>, React.AnchorHTMLAttributes<HTMLAnchorElement>> option with get, set
    /// Any custom data the developer wishes to associate with the menu item.
    abstract toggled: bool option with get, set
    /// Any custom data the developer wishes to associate with the menu item.
    abstract data: obj option with get, set
    /// Method to provide the classnames to style a button.
    /// The default value for this prop is the getClassnames func
    /// defined in BaseButton.classnames.
    abstract getClassNames: (ITheme -> string -> string -> string option -> string option -> bool -> bool -> bool -> bool option -> IButtonClassNames) option with get, set
    /// Method to provide the classnames to style a button.
    /// The default value for this prop is the getClassnames func
    /// defined in BaseButton.classnames.
    abstract getSplitButtonClassNames: (bool -> bool -> bool -> ISplitButtonClassNames) option with get, set
    /// Provides a custom KeyCode that can be used to open the button menu.
    /// The default KeyCode is the down arrow. A value of null can be provided to disable the key codes for opening the button menu.
    abstract menuTriggerKeyCode: KeyCodes option with get, set
    /// Optional keytip for this button
    abstract keytipProps: IKeytipProps option with get, set
    /// Menu will not be created or destroyed when opened or closed, instead it
    /// will be hidden. This will improve perf of the menu opening but could potentially
    /// impact overall perf by having more elemnts in the dom. Should only be used
    /// when perf is important.
    /// Note: This may increase the amount of time it takes for the button itself to mount.
    abstract persistMenu: bool option with get, set
    /// Style for the description text if applicable (for compound buttons.)
    abstract description: IStyle option with get, set

type [<RequireQualifiedAccess>] ElementType =
    | Button = 0
    | Anchor = 1

type [<RequireQualifiedAccess>] ButtonType =
    | Normal = 0
    | Primary = 1
    | Hero = 2
    | Compound = 3
    | Command = 4
    | Icon = 5
    | Default = 6

type [<AllowNullLiteral>] IButtonStyles =
    /// Style for the root element in the default enabled, non-toggled state.
    abstract root: IStyle option with get, set
    /// Style override for the root element in a checked state, layered on top of the root style.
    abstract rootChecked: IStyle option with get, set
    /// Style override for the root element in a disabled state, layered on top of the root style.
    abstract rootDisabled: IStyle option with get, set
    /// Style override applied to the root on hover in the default, enabled, non-toggled state.
    abstract rootHovered: IStyle option with get, set
    /// Style override applied to the root on hover in the default, enabled, non-toggled state.
    abstract rootFocused: IStyle option with get, set
    /// Style override applied to the root on pressed in the default, enabled, non-toggled state.
    abstract rootPressed: IStyle option with get, set
    /// Style override applied to the root on when menu is expanded in the default, enabled, non-toggled state.
    abstract rootExpanded: IStyle option with get, set
    /// Style override applied to the root on hover in a checked, enabled state
    abstract rootCheckedHovered: IStyle option with get, set
    /// Style override applied to the root on pressed in a checked, enabled state
    abstract rootCheckedPressed: IStyle option with get, set
    /// Style override applied to the root on hover in a checked, disabled state
    abstract rootCheckedDisabled: IStyle option with get, set
    /// Style override applied to the root on hover in a expanded state on hover
    abstract rootExpandedHovered: IStyle option with get, set
    /// Style for the flexbox container within the root element.
    abstract flexContainer: IStyle option with get, set
    /// Style for the text container within the flexbox container element (and contains the text and description).
    abstract textContainer: IStyle option with get, set
    /// Style for the icon on the near side of the label.
    abstract icon: IStyle option with get, set
    /// Style for the icon on the near side of the label on hover.
    abstract iconHovered: IStyle option with get, set
    /// Style for the icon on the near side of the label when pressed.
    abstract iconPressed: IStyle option with get, set
    /// Style for the icon on the near side of the label when expanded.
    abstract iconExpanded: IStyle option with get, set
    /// Style for the icon on the near side of the label when expanded and hovered.
    abstract iconExpandedHovered: IStyle option with get, set
    /// Style override for the icon when the button is disabled.
    abstract iconDisabled: IStyle option with get, set
    /// Style override for the icon when the button is checked.
    abstract iconChecked: IStyle option with get, set
    /// Style for the text content of the button.
    abstract label: IStyle option with get, set
    /// Style override for the text content when the button is disabled.
    abstract labelDisabled: IStyle option with get, set
    /// Style override for the text content when the button is checked.
    abstract labelChecked: IStyle option with get, set
    /// Style for the menu chevron.
    abstract menuIcon: IStyle option with get, set
    /// Style for the menu chevron on hover.
    abstract menuIconHovered: IStyle option with get, set
    /// Style for the menu chevron when pressed.
    abstract menuIconPressed: IStyle option with get, set
    /// Style for the menu chevron when expanded.
    abstract menuIconExpanded: IStyle option with get, set
    /// Style for the menu chevron when expanded and hovered.
    abstract menuIconExpandedHovered: IStyle option with get, set
    /// Style override for the menu chevron when the button is disabled.
    abstract menuIconDisabled: IStyle option with get, set
    /// Style override for the menu chevron when the button is checked.
    abstract menuIconChecked: IStyle option with get, set
    /// Style for the description text if applicable (for compound buttons.)
    abstract description: IStyle option with get, set
    /// Style for the description text if applicable (for compound buttons.)
    abstract secondaryText: IStyle option with get, set
    /// Style override for the description text when the button is hovered.
    abstract descriptionHovered: IStyle option with get, set
    /// Style for the description text when the button is pressed.
    abstract descriptionPressed: IStyle option with get, set
    /// Style override for the description text when the button is disabled.
    abstract descriptionDisabled: IStyle option with get, set
    /// Style override for the description text when the button is checked.
    abstract descriptionChecked: IStyle option with get, set
    /// Style override for the screen reader text.
    abstract screenReaderText: IStyle option with get, set
    /// Style override for the container div around a SplitButton element
    abstract splitButtonContainer: IStyle option with get, set
    /// Style for container div around a SplitButton element when the button is hovered.
    abstract splitButtonContainerHovered: IStyle option with get, set
    /// Style for container div around a SplitButton element when the button is focused.
    abstract splitButtonContainerFocused: IStyle option with get, set
    /// Style for container div around a SplitButton element when the button is checked.
    abstract splitButtonContainerChecked: IStyle option with get, set
    /// Style for container div around a SplitButton element when the button is checked and hovered.
    abstract splitButtonContainerCheckedHovered: IStyle option with get, set
    /// Style override for the container div around a SplitButton element in a disabled state
    abstract splitButtonContainerDisabled: IStyle option with get, set
    /// Style override for the divider element that appears between the button and menu button
    /// for a split button.
    abstract splitButtonDivider: IStyle option with get, set
    /// Style override for the SplitButton menu button
    abstract splitButtonMenuButton: IStyle option with get, set
    /// Style override for the SplitButton menu button element in a disabled state.
    abstract splitButtonMenuButtonDisabled: IStyle option with get, set
    /// Style override for the SplitButton menu button element in a checked state
    abstract splitButtonMenuButtonChecked: IStyle option with get, set
    /// Style override for the SplitButton menu button element in an expanded state
    abstract splitButtonMenuButtonExpanded: IStyle option with get, set
    /// Style override for the SplitButton menu icon element
    abstract splitButtonMenuIcon: IStyle option with get, set
    /// Style override for the SplitButton menu icon element in a disabled state
    abstract splitButtonMenuIconDisabled: IStyle option with get, set
    /// Style override for the SplitButton FlexContainer.
    abstract splitButtonFlexContainer: IStyle option with get, set
type BaseComponent = ______Utilities.BaseComponent
type IContextualMenuProps = ______ContextualMenu.IContextualMenuProps
type IButtonProps = __Button_types.IButtonProps
type IButton = __Button_types.IButton

type [<AllowNullLiteral>] IExports =
    abstract BaseButton: BaseButtonStatic

type [<AllowNullLiteral>] IBaseButtonProps =
    inherit IButtonProps
    abstract baseClassName: string option with get, set
    abstract variantClassName: string option with get, set

type [<AllowNullLiteral>] IBaseButtonState =
    abstract menuProps: IContextualMenuProps option with get, set

type [<AllowNullLiteral>] BaseButton =
    inherit BaseComponent<IBaseButtonProps, IBaseButtonState>
    inherit IButton
    abstract _isSplitButton: obj
    abstract _isExpanded: obj
    abstract defaultProps: obj with get, set
    abstract _buttonElement: obj with get, set
    abstract _splitButtonContainer: obj with get, set
    abstract _labelId: obj with get, set
    abstract _descriptionId: obj with get, set
    abstract _ariaDescriptionId: obj with get, set
    abstract _classNames: obj with get, set
    abstract _processingTouch: obj with get, set
    abstract _lastTouchTimeoutId: obj with get, set
    abstract render: unit -> JSX.Element
    abstract componentDidMount: unit -> unit
    abstract componentDidUpdate: prevProps: IBaseButtonProps * prevState: IBaseButtonState -> unit
    abstract focus: unit -> unit
    abstract dismissMenu: unit -> unit
    abstract openMenu: unit -> unit
    abstract _onRenderContent: tag: obj * buttonProps: obj -> unit
    abstract _onRenderIcon: obj with get, set
    abstract _onRenderTextContents: obj with get, set
    abstract _onRenderText: obj with get, set
    abstract _hasText: unit -> unit
    abstract _onRenderChildren: obj with get, set
    abstract _onRenderDescription: obj with get, set
    abstract _onRenderAriaDescription: obj with get, set
    abstract _onRenderMenuIcon: obj with get, set
    abstract _onRenderMenu: obj with get, set
    abstract _dismissMenu: obj with get, set
    abstract _openMenu: obj with get, set
    abstract _onToggleMenu: obj with get, set
    abstract _onRenderSplitButtonContent: tag: obj * buttonProps: obj -> unit
    abstract _onSplitButtonPrimaryClick: obj with get, set
    abstract _onRenderSplitButtonDivider: classNames: obj -> unit
    abstract _onRenderSplitButtonMenuButton: classNames: obj * keytipAttributes: obj -> unit
    abstract _onMouseDown: obj with get, set
    abstract _onSplitButtonContainerKeyDown: obj with get, set
    abstract _onMenuKeyDown: obj with get, set
    abstract _onTouchStart: obj with get, set
    abstract _onPointerDown: ev: obj -> unit
    abstract _handleTouchAndPointerEvent: unit -> unit
    /// <summary>Returns if the user hits a valid keyboard key to open the menu</summary>
    /// <param name="ev">- the keyboard event</param>
    abstract _isValidMenuOpenKey: ev: obj -> unit
    abstract _onMenuClick: obj with get, set

type [<AllowNullLiteral>] BaseButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: props: IBaseButtonProps * rootClassName: string -> BaseButton
type BaseComponent = _________Utilities.BaseComponent
type IButtonProps = ___Button_types.IButtonProps

type [<AllowNullLiteral>] IExports =
    abstract ActionButton: ActionButtonStatic

type [<AllowNullLiteral>] ActionButton =
    inherit BaseComponent<IButtonProps, obj>
    /// Tell BaseComponent to bypass resolution of componentRef.
    abstract _shouldUpdateComponentRef: bool with get, set
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] ActionButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> ActionButton
type BaseComponent = _________Utilities.BaseComponent
type IButtonProps = ___Button_types.IButtonProps

type [<AllowNullLiteral>] IExports =
    abstract CommandBarButton: CommandBarButtonStatic

type [<AllowNullLiteral>] CommandBarButton =
    inherit BaseComponent<IButtonProps, obj>
    /// Tell BaseComponent to bypass resolution of componentRef.
    abstract _shouldUpdateComponentRef: bool with get, set
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] CommandBarButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> CommandBarButton
type BaseComponent = _________Utilities.BaseComponent
type IButtonProps = ___Button_types.IButtonProps

type [<AllowNullLiteral>] IExports =
    abstract CompoundButton: CompoundButtonStatic

type [<AllowNullLiteral>] CompoundButton =
    inherit BaseComponent<IButtonProps, obj>
    /// Tell BaseComponent to bypass resolution of componentRef.
    abstract _shouldUpdateComponentRef: bool with get, set
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] CompoundButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> CompoundButton
type BaseComponent = _________Utilities.BaseComponent
type IButtonProps = ___Button_types.IButtonProps

type [<AllowNullLiteral>] IExports =
    abstract DefaultButton: DefaultButtonStatic

type [<AllowNullLiteral>] DefaultButton =
    inherit BaseComponent<IButtonProps, obj>
    /// Tell BaseComponent to bypass resolution of componentRef.
    abstract _shouldUpdateComponentRef: bool with get, set
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] DefaultButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> DefaultButton
type BaseComponent = _________Utilities.BaseComponent
type IButtonProps = ___Button_types.IButtonProps

type [<AllowNullLiteral>] IExports =
    abstract MessageBarButton: MessageBarButtonStatic

type [<AllowNullLiteral>] MessageBarButton =
    inherit BaseComponent<IButtonProps, obj>
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] MessageBarButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> MessageBarButton
type BaseComponent = _________Utilities.BaseComponent
type IButtonProps = ___Button_types.IButtonProps

type [<AllowNullLiteral>] IExports =
    abstract PrimaryButton: PrimaryButtonStatic

type [<AllowNullLiteral>] PrimaryButton =
    inherit BaseComponent<IButtonProps, obj>
    /// Set this BaseComponent._resolveComponentRef to false, bypassing resolution of componentRef.
    abstract _shouldUpdateComponentRef: bool with get, set
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] PrimaryButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> PrimaryButton
type BaseComponent = _________Utilities.BaseComponent
type IButtonProps = ___Button_types.IButtonProps

type [<AllowNullLiteral>] IExports =
    abstract IconButton: IconButtonStatic

type [<AllowNullLiteral>] IconButton =
    inherit BaseComponent<IButtonProps, obj>
    /// Tell BaseComponent to bypass resolution of componentRef.
    abstract _shouldUpdateComponentRef: bool with get, set
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] IconButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> IconButton

type [<RequireQualifiedAccess>] DayOfWeek =
    | Sunday = 0
    | Monday = 1
    | Tuesday = 2
    | Wednesday = 3
    | Thursday = 4
    | Friday = 5
    | Saturday = 6

type [<RequireQualifiedAccess>] MonthOfYear =
    | January = 0
    | February = 1
    | March = 2
    | April = 3
    | May = 4
    | June = 5
    | July = 6
    | August = 7
    | September = 8
    | October = 9
    | November = 10
    | December = 11

type [<RequireQualifiedAccess>] FirstWeekOfYear =
    | FirstDay = 0
    | FirstFullWeek = 1
    | FirstFourDayWeek = 2

type [<RequireQualifiedAccess>] DateRangeType =
    | Day = 0
    | Week = 1
    | Month = 2
    | WorkWeek = 3
type Calendar = __Calendar.Calendar
type DayOfWeek = ______utilities_dateValues_DateValues.DayOfWeek
type FirstWeekOfYear = ______utilities_dateValues_DateValues.FirstWeekOfYear
type DateRangeType = ______utilities_dateValues_DateValues.DateRangeType

type [<AllowNullLiteral>] ICalendar =
    /// Sets focus to the selected date. 
    abstract focus: (unit -> unit) with get, set

type [<AllowNullLiteral>] ICalendarProps =
    inherit React.Props<Calendar>
    /// Optional callback to access the ICalendar interface. Use this instead of ref for accessing
    /// the public methods and properties of the component.
    abstract componentRef: (ICalendar option -> unit) option with get, set
    /// Optional class name to add to the root element.
    abstract className: string option with get, set
    /// Callback issued when a date is selected
    abstract onSelectDate: (DateTime -> ResizeArray<DateTime> -> unit) option with get, set
    /// Callback issued when calendar is closed
    abstract onDismiss: (unit -> unit) option with get, set
    /// Whether the month picker is shown beside the day picker or hidden.
    abstract isMonthPickerVisible: bool option with get, set
    /// Whether the day picker is shown beside the month picker or hidden.
    abstract isDayPickerVisible: bool option with get, set
    /// Show month picker on top of date picker when visible.
    abstract showMonthPickerAsOverlay: bool option with get, set
    /// Value of today. If null, current time in client machine will be used.
    abstract today: DateTime option with get, set
    /// Default value of the Calendar, if any
    abstract value: DateTime option with get, set
    /// The first day of the week for your locale.
    abstract firstDayOfWeek: DayOfWeek option with get, set
    /// The date range type indicating how  many days should be selected as the user
    /// selects days
    abstract dateRangeType: DateRangeType option with get, set
    /// Whether the month view should automatically navigate to the next or previous date range
    /// depending on the selected date. If this property is set to true and the currently displayed
    /// month is March 2017, if the user clicks on a day outside the month, i.e., April 1st, the
    /// picker will automatically navigate to the month of April.
    abstract autoNavigateOnSelection: bool option with get, set
    /// Whether the "Go to today" link should be shown or not
    abstract showGoToToday: bool option with get, set
    /// This property has been removed at 0.80.0 in place of the focus method, to be removed @ 1.0.0.
    abstract shouldFocusOnMount: bool option with get, set
    /// Localized strings to use in the Calendar
    abstract strings: ICalendarStrings option with get, set
    /// Whether the month picker should highlight the current month
    abstract highlightCurrentMonth: bool option with get, set
    /// Whether the month picker should highlight the selected month
    abstract highlightSelectedMonth: bool option with get, set
    /// Customize navigation icons using ICalendarIconStrings
    abstract navigationIcons: ICalendarIconStrings option with get, set
    /// Whether the calendar should show the week number (weeks 1 to 53) before each week row
    abstract showWeekNumbers: bool option with get, set
    /// Defines when the first week of the year should start, FirstWeekOfYear.FirstDay,
    /// FirstWeekOfYear.FirstFullWeek or FirstWeekOfYear.FirstFourDayWeek are the possible values
    abstract firstWeekOfYear: FirstWeekOfYear option with get, set
    /// Apply additional formating to dates, for example localized date formatting.
    abstract dateTimeFormatter: ICalendarFormatDateCallbacks option with get, set
    /// If set the Calendar will not allow navigation to or selection of a date earlier than this value.
    abstract minDate: DateTime option with get, set
    /// If set the Calendar will not allow navigation to or selection of a date later than this value.
    abstract maxDate: DateTime option with get, set
    /// Whether the calendar should show 6 weeks by default.
    abstract showSixWeeksByDefault: bool option with get, set
    /// The days that are selectable when dateRangeType is WorkWeek. If dateRangeType is not WorkWeek this property does nothing.
    abstract workWeekDays: ResizeArray<DayOfWeek> option with get, set

type [<AllowNullLiteral>] ICalendarStrings =
    /// An array of strings for the full names of months.
    /// The array is 0-based, so months[0] should be the full name of January.
    abstract months: ResizeArray<string> with get, set
    /// An array of strings for the short names of months.
    /// The array is 0-based, so shortMonths[0] should be the short name of January.
    abstract shortMonths: ResizeArray<string> with get, set
    /// An array of strings for the full names of days of the week.
    /// The array is 0-based, so days[0] should be the full name of Sunday.
    abstract days: ResizeArray<string> with get, set
    /// An array of strings for the initials of the days of the week.
    /// The array is 0-based, so days[0] should be the initial of Sunday.
    abstract shortDays: ResizeArray<string> with get, set
    /// String to render for button to direct the user to today's date.
    abstract goToToday: string with get, set
    /// Aria-label for the "previous month" button.
    abstract prevMonthAriaLabel: string option with get, set
    /// Aria-label for the "next month" button.
    abstract nextMonthAriaLabel: string option with get, set
    /// Aria-label for the "previous year" button.
    abstract prevYearAriaLabel: string option with get, set
    /// Aria-label for the "next year" button.
    abstract nextYearAriaLabel: string option with get, set
    /// Aria-label format string for the week number header. Should have 1 string param e.g. "week number {0}"
    abstract weekNumberFormatString: string option with get, set

type [<AllowNullLiteral>] ICalendarIconStrings =
    /// FabricMDL2Icons name for the left navigation icon.  Previous default: ChevronLeft.
    abstract leftNavigation: string option with get, set
    /// FabricMDL2Icons name for the right navigation icon.  Previous default: ChevronRight.
    abstract rightNavigation: string option with get, set

type [<AllowNullLiteral>] ICalendarFormatDateCallbacks =
    /// Callback to apply formatting to mmmm d, yyyy formated dates
    abstract formatMonthDayYear: (DateTime -> ICalendarStrings -> string) with get, set
    /// Callback to apply formatting to the month and year in the Day Picker header
    abstract formatMonthYear: (DateTime -> ICalendarStrings -> string) with get, set
    /// Callback to apply formatting to the days in the Day Picker calendar
    abstract formatDay: (DateTime -> string) with get, set
    /// Callback to apply formatting to the year in the Month Picker header
    abstract formatYear: (DateTime -> string) with get, set
type ICalendar = __Calendar_types.ICalendar
type ICalendarProps = __Calendar_types.ICalendarProps
type BaseComponent = ______Utilities.BaseComponent

type [<AllowNullLiteral>] IExports =
    abstract Calendar: CalendarStatic

type [<AllowNullLiteral>] ICalendarState =
    /// The currently focused date in the day picker, but not necessarily selected 
    abstract navigatedDayDate: DateTime option with get, set
    /// The currently focused date in the month picker, but not necessarily selected 
    abstract navigatedMonthDate: DateTime option with get, set
    /// The currently selected date in the calendar 
    abstract selectedDate: DateTime option with get, set
    /// State used to show/hide month picker 
    abstract isMonthPickerVisible: bool option with get, set
    /// State used to show/hide day picker 
    abstract isDayPickerVisible: bool option with get, set

type [<AllowNullLiteral>] Calendar =
    inherit BaseComponent<ICalendarProps, ICalendarState>
    inherit ICalendar
    abstract defaultProps: ICalendarProps with get, set
    abstract _dayPicker: obj with get, set
    abstract _monthPicker: obj with get, set
    abstract _focusOnUpdate: obj with get, set
    abstract componentWillReceiveProps: nextProps: ICalendarProps -> unit
    abstract componentDidUpdate: unit -> unit
    abstract render: unit -> JSX.Element
    abstract focus: unit -> unit
    abstract _navigateDayPickerDay: obj with get, set
    abstract _navigateMonthPickerDay: obj with get, set
    abstract _onNavigateDayDate: obj with get, set
    abstract _onNavigateMonthDate: obj with get, set
    abstract _onSelectDate: obj with get, set
    abstract _onHeaderSelect: obj with get, set
    abstract _onGotoToday: obj with get, set
    abstract _onGotoTodayKeyDown: obj with get, set
    abstract _onDatePickerPopupKeyDown: obj with get, set
    abstract _handleEscKey: obj with get, set

type [<AllowNullLiteral>] CalendarStatic =
    [<Emit "new $0($1...)">] abstract Create: props: ICalendarProps -> Calendar
type BaseComponent = ______Utilities.BaseComponent
type ICheckProps = __Check_types.ICheckProps

type [<AllowNullLiteral>] IExports =
    abstract CheckBase: CheckBaseStatic

type [<AllowNullLiteral>] CheckBase =
    inherit BaseComponent<ICheckProps, obj>
    abstract defaultProps: ICheckProps with get, set
    abstract shouldComponentUpdate: newProps: ICheckProps -> bool
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] CheckBaseStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> CheckBase
type IRawStyle = @uifabric_merge_styles_lib_index.IRawStyle

/// All Fabric standard animations, exposed as json objects referencing predefined
/// keyframes. These objects can be mixed in with other class definitions.
type [<AllowNullLiteral>] IAnimationStyles =
    abstract slideRightIn10: IRawStyle with get, set
    abstract slideRightIn20: IRawStyle with get, set
    abstract slideRightIn40: IRawStyle with get, set
    abstract slideRightIn400: IRawStyle with get, set
    abstract slideLeftIn10: IRawStyle with get, set
    abstract slideLeftIn20: IRawStyle with get, set
    abstract slideLeftIn40: IRawStyle with get, set
    abstract slideLeftIn400: IRawStyle with get, set
    abstract slideUpIn10: IRawStyle with get, set
    abstract slideUpIn20: IRawStyle with get, set
    abstract slideDownIn10: IRawStyle with get, set
    abstract slideDownIn20: IRawStyle with get, set
    abstract slideRightOut10: IRawStyle with get, set
    abstract slideRightOut20: IRawStyle with get, set
    abstract slideRightOut40: IRawStyle with get, set
    abstract slideRightOut400: IRawStyle with get, set
    abstract slideLeftOut10: IRawStyle with get, set
    abstract slideLeftOut20: IRawStyle with get, set
    abstract slideLeftOut40: IRawStyle with get, set
    abstract slideLeftOut400: IRawStyle with get, set
    abstract slideUpOut10: IRawStyle with get, set
    abstract slideUpOut20: IRawStyle with get, set
    abstract slideDownOut10: IRawStyle with get, set
    abstract slideDownOut20: IRawStyle with get, set
    abstract scaleUpIn100: IRawStyle with get, set
    abstract scaleDownIn100: IRawStyle with get, set
    abstract scaleUpOut103: IRawStyle with get, set
    abstract scaleDownOut98: IRawStyle with get, set
    abstract fadeIn100: IRawStyle with get, set
    abstract fadeIn200: IRawStyle with get, set
    abstract fadeIn400: IRawStyle with get, set
    abstract fadeIn500: IRawStyle with get, set
    abstract fadeOut100: IRawStyle with get, set
    abstract fadeOut200: IRawStyle with get, set
    abstract fadeOut400: IRawStyle with get, set
    abstract fadeOut500: IRawStyle with get, set
    abstract rotate90deg: IRawStyle with get, set
    abstract rotateN90deg: IRawStyle with get, set

type [<AllowNullLiteral>] IAnimationVariables =
    abstract easeFunction1: string with get, set
    abstract easeFunction2: string with get, set
    abstract durationValue1: string with get, set
    abstract durationValue2: string with get, set
    abstract durationValue3: string with get, set
    abstract durationValue4: string with get, set
type IRawStyle = @uifabric_merge_styles_lib_index.IRawStyle

/// UI Fabric font set.
type [<AllowNullLiteral>] IFontStyles =
    abstract tiny: IRawStyle with get, set
    abstract xSmall: IRawStyle with get, set
    abstract small: IRawStyle with get, set
    abstract smallPlus: IRawStyle with get, set
    abstract medium: IRawStyle with get, set
    abstract mediumPlus: IRawStyle with get, set
    abstract large: IRawStyle with get, set
    abstract xLarge: IRawStyle with get, set
    abstract xxLarge: IRawStyle with get, set
    abstract superLarge: IRawStyle with get, set
    abstract mega: IRawStyle with get, set

/// UI Fabric color palette.
type [<AllowNullLiteral>] IPalette =
    /// Color code for themeDarker.
    abstract themeDarker: string with get, set
    /// Color code for themeDark.
    abstract themeDark: string with get, set
    /// Color code for themeDarkAlt.
    abstract themeDarkAlt: string with get, set
    /// Color code for themePrimary.
    abstract themePrimary: string with get, set
    /// Color code for themeSecondary.
    abstract themeSecondary: string with get, set
    /// Color code for themeTertiary.
    abstract themeTertiary: string with get, set
    /// Color code for themeLight.
    abstract themeLight: string with get, set
    /// Color code for themeLighter.
    abstract themeLighter: string with get, set
    /// Color code for themeLighterAlt.
    abstract themeLighterAlt: string with get, set
    /// Color code for the strongest color, which is black in the default theme. This is a very light color in inverted themes.
    abstract black: string with get, set
    /// Color code for blackTranslucent40.
    abstract blackTranslucent40: string with get, set
    /// Color code for neutralDark.
    abstract neutralDark: string with get, set
    /// Color code for neutralPrimary.
    abstract neutralPrimary: string with get, set
    /// Color code for neutralPrimaryAlt.
    abstract neutralPrimaryAlt: string with get, set
    /// Color code for neutralSecondary.
    abstract neutralSecondary: string with get, set
    /// Color code for neutralTertiary.
    abstract neutralTertiary: string with get, set
    /// Color code for neutralTertiaryAlt.
    abstract neutralTertiaryAlt: string with get, set
    /// Color code for neutralQuaternary.
    abstract neutralQuaternary: string with get, set
    /// Color code for neutralQuaternaryAlt.
    abstract neutralQuaternaryAlt: string with get, set
    /// Color code for neutralLight.
    abstract neutralLight: string with get, set
    /// Color code for neutralLighter.
    abstract neutralLighter: string with get, set
    /// Color code for neutralLighterAlt.
    abstract neutralLighterAlt: string with get, set
    /// Color code for the accent.
    abstract accent: string with get, set
    /// Color code for the softest color, which is white in the default theme. This is a very dark color in dark themes.
    /// This is the page background.
    abstract white: string with get, set
    /// Color code for whiteTranslucent40
    abstract whiteTranslucent40: string with get, set
    /// Color code for yellow.
    abstract yellow: string with get, set
    /// Color code for yellowLight.
    abstract yellowLight: string with get, set
    /// Color code for orange.
    abstract orange: string with get, set
    /// Color code for orangeLight.
    abstract orangeLight: string with get, set
    /// Color code for orangeLighter.
    abstract orangeLighter: string with get, set
    /// Color code for redDark.
    abstract redDark: string with get, set
    /// Color code for red.
    abstract red: string with get, set
    /// Color code for magentaDark.
    abstract magentaDark: string with get, set
    /// Color code for magenta.
    abstract magenta: string with get, set
    /// Color code for magentaLight.
    abstract magentaLight: string with get, set
    /// Color code for purpleDark.
    abstract purpleDark: string with get, set
    /// Color code for purple.
    abstract purple: string with get, set
    /// Color code for purpleLight.
    abstract purpleLight: string with get, set
    /// Color code for blueDark.
    abstract blueDark: string with get, set
    /// Color code for blueMid.
    abstract blueMid: string with get, set
    /// Color code for blue.
    abstract blue: string with get, set
    /// Color code for blueLight.
    abstract blueLight: string with get, set
    /// Color code for tealDark.
    abstract tealDark: string with get, set
    /// Color code for teal.
    abstract teal: string with get, set
    /// Color code for tealLight.
    abstract tealLight: string with get, set
    /// Color code for greenDark.
    abstract greenDark: string with get, set
    /// Color code for green.
    abstract green: string with get, set
    /// Color code for greenLight.
    abstract greenLight: string with get, set

/// The collection of semantic slots for colors used in themes.
/// 
/// ## Naming Convention
/// 
/// The name of a semantic slot can quickly tell you how it’s meant to be used. It generally follows this format:
/// 
/// [category name][element name][checked state][hovered/pressed/disabled state]
/// [category name] – The “family” that this slot belongs to.
/// [element name] – The name of the thing being targeted, such as the background or border.
/// [checked state] – Whether the thing is checked. We assume things are unchecked by default, so no need to specify the unchecked state.
/// (We used “checked” to refer to anything that is on, selected, toggled, highlighted, emphasized, etc.)
/// [hovered/pressed/disabled state] – One of these states, if applicable. Each of these states are mutually exclusive.
/// Pressed styles overwrite hovered styles, and disabled elements cannot be hovered or pressed.
/// 
/// ## Base Slots
/// 
/// A basic set of slots that provide many default body styles, such as text, subtext, disabled colors, and so on.
/// If a category doesn't provide the slot you're looking for, use one from this category.
/// For example, the placeholder text on a text input field has no corresponding slot in its category,
/// so you'd use the bodySubtextColor from this category.
/// 
/// ## Invariants
/// 
/// When color has meaning, we do not want to change the color much theme to theme. For example, we
/// will always want errors to be some shade of red, but we will need to tweak the exact shade so it's
/// legible depending on whether it's an inverted theme or not.
/// Invariant colors should almost never be changed by the theme, the defaults should suffice.
/// 
/// ## Input Controls
/// 
/// This category contains input components commonly used to denote state, including radio buttons,
/// check boxes, toggle switches, sliders, progress bars, and more.
/// 
/// ## Buttons
/// 
/// Buttons! And all the flavors thereof.
/// 
/// ## Menus
/// 
/// Any kind of popup menus uses this category.
/// 
/// ## Lists
/// 
/// Lists differ from menus in that they are designed to show infinite amounts of items, often scroll,
/// and have a large and complex interaction surface.
/// This category covers all kinds of lists, whether they're typical one-item-per-row lists (like DetailsList) or ones with a tiled layout.
type [<AllowNullLiteral>] ISemanticColors =
    /// The default color for backgrounds.
    abstract bodyBackground: string with get, set
    /// A special semantic slot that will always be the same or darker (not necessarily stronger) than the bodyBackground slot, even in
    /// an inverted theme. This is used for zones near the edge of the page, to provide a vignetting effect. This is especially effective
    /// with zones near the edge of the page in stronger themes or if it uses a variant theme.
    abstract bodyFrameBackground: string with get, set
    /// The default color for text.
    abstract bodyText: string with get, set
    /// Checked text color, e.g. selected menu item text.
    abstract bodyTextChecked: string with get, set
    /// De-emphasized text; e.g. metadata, captions, placeholder text.
    abstract bodySubtext: string with get, set
    /// Divider lines; e.g. lines that separate sections in a menu, an <HR> element.
    abstract bodyDivider: string with get, set
    /// The color of a link.
    abstract link: string with get, set
    /// The color of a hovered link. Also used when the link is active.
    abstract linkHovered: string with get, set
    /// The default color for backgrounds of disabled controls; e.g. disabled text field.
    abstract disabledBackground: string with get, set
    /// The default color for disabled text on top of disabledBackground; e.g. text in a disabled text field, disabled button text.
    abstract disabledText: string with get, set
    /// The default color for disabled text on the default background (bodyBackground).
    abstract disabledBodyText: string with get, set
    /// Disabled de-emphasized text, for use on disabledBackground.
    abstract disabledSubtext: string with get, set
    /// The color of the outline around focused controls that don't already have a border; e.g. menu items
    abstract focusBorder: string with get, set
    /// The default color of error text, used on bodyBackground.
    abstract errorText: string with get, set
    /// The color of text on errorBackground, warningBackground, blockingBackground, or successBackground.
    abstract warningText: string with get, set
    /// The background for errors, if necessary, or highlighting the section of the page where the error is present.
    abstract errorBackground: string with get, set
    /// Background for blocking issues, which is more severe than a warning, but not as bad as an error.
    abstract blockingBackground: string with get, set
    /// Background for warning messages.
    abstract warningBackground: string with get, set
    /// Foreground color for warning highlights
    abstract warningHighlight: string with get, set
    /// Background for success
    abstract successBackground: string with get, set
    /// The border of a large input control in its resting, state; e.g. the box of dropdown.
    abstract inputBorder: string with get, set
    /// The border of a small input control in its resting unchecked state; e.g. the box of an unchecked checkbox.
    abstract smallInputBorder: string with get, set
    /// The border color of a large hovered input control, such as textbox.
    abstract inputBorderHovered: string with get, set
    /// The background color of an input, e.g. textbox background.
    abstract inputBackground: string with get, set
    /// The background of a checked control; e.g. checked radio button's dot, checked toggle's background.
    abstract inputBackgroundChecked: string with get, set
    /// The background of a checked and hovered control; e.g. checked checkbox's background color on hover.
    abstract inputBackgroundCheckedHovered: string with get, set
    /// The foreground of a checked control; e.g. checked checkbox's checkmark color, checked toggle's thumb color,
    /// radio button's background color around the dot.
    abstract inputForegroundChecked: string with get, set
    /// The alternate focus border color for elements that already have a border; e.g. text field borders on focus.
    abstract inputFocusBorderAlt: string with get, set
    /// The color of placeholder text.
    abstract inputPlaceholderText: string with get, set
    /// Background of a standard button
    abstract buttonBackground: string with get, set
    /// Background of a hovered standard button
    abstract buttonBackgroundHovered: string with get, set
    /// Background of a checked standard button; e.g. bold/italicize/underline text button in toolbar
    abstract buttonBackgroundChecked: string with get, set
    /// Background of a checked and hovered standard button; e.g. bold/italicize/underline text button in toolbar
    abstract buttonBackgroundCheckedHovered: string with get, set
    /// Border of a standard button
    abstract buttonBorder: string with get, set
    /// Color of text in a standard button
    abstract buttonText: string with get, set
    /// Color of text in a hovered standard button
    abstract buttonTextHovered: string with get, set
    /// Color of text in a checked standard button
    abstract buttonTextChecked: string with get, set
    /// Color of text in a checked and hovered standard button
    abstract buttonTextCheckedHovered: string with get, set
    /// The background of a hovered menu item.
    abstract menuItemBackgroundHovered: string with get, set
    /// The default colors of icons in menus.
    abstract menuIcon: string with get, set
    /// The headers in menus that denote title of a section.
    abstract menuHeader: string with get, set
    /// The background color for the entire list.
    abstract listBackground: string with get, set
    /// The default text color for list item titles and text in column fields.
    abstract listText: string with get, set
    /// The background color of a hovered list item.
    abstract listItemBackgroundHovered: string with get, set
    /// The background color of a checked list item.
    abstract listItemBackgroundChecked: string with get, set
    /// The background color of a checked and hovered list item.
    abstract listItemBackgroundCheckedHovered: string with get, set
    /// The background color for a hovered list header.
    abstract listHeaderBackgroundHovered: string with get, set
    /// The background color for a pressed list header.
    abstract listHeaderBackgroundPressed: string with get, set
    abstract listTextColor: string with get, set
    abstract menuItemBackgroundChecked: string with get, set
type IPalette = __IPalette.IPalette
type IFontStyles = __IFontStyles.IFontStyles
type ISemanticColors = __ISemanticColors.ISemanticColors

type [<AllowNullLiteral>] ITheme =
    abstract palette: IPalette with get, set
    abstract fonts: IFontStyles with get, set
    abstract semanticColors: ISemanticColors with get, set
    abstract isInverted: bool with get, set
    /// This setting is for a very narrow use case and you probably don't need to worry about,
    /// unless you share a environment with others that also use fabric.
    /// It is used for disabling global styles on fabric components. This will prevent global
    /// overrides that might have been set by other fabric users from applying to your components.
    /// When you set this setting to `true` on your theme the components in the subtree of your
    /// Customizer will not get the global styles applied to them.
    abstract disableGlobalClassNames: bool with get, set

type [<AllowNullLiteral>] IPartialTheme =
    abstract palette: obj option with get, set
    abstract fonts: obj option with get, set
    abstract semanticColors: obj option with get, set
    abstract isInverted: bool option with get, set
    abstract disableGlobalClassNames: bool option with get, set
let [<Import("IColorClassNames","@uifabric/styling/lib-es2015/classNames/ColorClassNames")>] ColorClassNames: IColorClassNames = jsNative

type [<AllowNullLiteral>] IColorClassNames =
    abstract themeDarker: string with get, set
    abstract themeDarkerHover: string with get, set
    abstract themeDarkerBackground: string with get, set
    abstract themeDarkerBackgroundHover: string with get, set
    abstract themeDarkerBorder: string with get, set
    abstract themeDarkerBorderHover: string with get, set
    abstract themeDark: string with get, set
    abstract themeDarkHover: string with get, set
    abstract themeDarkBackground: string with get, set
    abstract themeDarkBackgroundHover: string with get, set
    abstract themeDarkBorder: string with get, set
    abstract themeDarkBorderHover: string with get, set
    abstract themeDarkAlt: string with get, set
    abstract themeDarkAltHover: string with get, set
    abstract themeDarkAltBackground: string with get, set
    abstract themeDarkAltBackgroundHover: string with get, set
    abstract themeDarkAltBorder: string with get, set
    abstract themeDarkAltBorderHover: string with get, set
    abstract themePrimary: string with get, set
    abstract themePrimaryHover: string with get, set
    abstract themePrimaryBackground: string with get, set
    abstract themePrimaryBackgroundHover: string with get, set
    abstract themePrimaryBorder: string with get, set
    abstract themePrimaryBorderHover: string with get, set
    abstract themeSecondary: string with get, set
    abstract themeSecondaryHover: string with get, set
    abstract themeSecondaryBackground: string with get, set
    abstract themeSecondaryBackgroundHover: string with get, set
    abstract themeSecondaryBorder: string with get, set
    abstract themeSecondaryBorderHover: string with get, set
    abstract themeTertiary: string with get, set
    abstract themeTertiaryHover: string with get, set
    abstract themeTertiaryBackground: string with get, set
    abstract themeTertiaryBackgroundHover: string with get, set
    abstract themeTertiaryBorder: string with get, set
    abstract themeTertiaryBorderHover: string with get, set
    abstract themeLight: string with get, set
    abstract themeLightHover: string with get, set
    abstract themeLightBackground: string with get, set
    abstract themeLightBackgroundHover: string with get, set
    abstract themeLightBorder: string with get, set
    abstract themeLightBorderHover: string with get, set
    abstract themeLighter: string with get, set
    abstract themeLighterHover: string with get, set
    abstract themeLighterBackground: string with get, set
    abstract themeLighterBackgroundHover: string with get, set
    abstract themeLighterBorder: string with get, set
    abstract themeLighterBorderHover: string with get, set
    abstract themeLighterAlt: string with get, set
    abstract themeLighterAltHover: string with get, set
    abstract themeLighterAltBackground: string with get, set
    abstract themeLighterAltBackgroundHover: string with get, set
    abstract themeLighterAltBorder: string with get, set
    abstract themeLighterAltBorderHover: string with get, set
    abstract black: string with get, set
    abstract blackHover: string with get, set
    abstract blackBackground: string with get, set
    abstract blackBackgroundHover: string with get, set
    abstract blackBorder: string with get, set
    abstract blackBorderHover: string with get, set
    abstract blackTranslucent40: string with get, set
    abstract blackTranslucent40Hover: string with get, set
    abstract blackTranslucent40Background: string with get, set
    abstract blackTranslucent40BackgroundHover: string with get, set
    abstract blackTranslucent40Border: string with get, set
    abstract blackTranslucent40BorderHover: string with get, set
    abstract neutralDark: string with get, set
    abstract neutralDarkHover: string with get, set
    abstract neutralDarkBackground: string with get, set
    abstract neutralDarkBackgroundHover: string with get, set
    abstract neutralDarkBorder: string with get, set
    abstract neutralDarkBorderHover: string with get, set
    abstract neutralPrimary: string with get, set
    abstract neutralPrimaryHover: string with get, set
    abstract neutralPrimaryBackground: string with get, set
    abstract neutralPrimaryBackgroundHover: string with get, set
    abstract neutralPrimaryBorder: string with get, set
    abstract neutralPrimaryBorderHover: string with get, set
    abstract neutralPrimaryAlt: string with get, set
    abstract neutralPrimaryAltHover: string with get, set
    abstract neutralPrimaryAltBackground: string with get, set
    abstract neutralPrimaryAltBackgroundHover: string with get, set
    abstract neutralPrimaryAltBorder: string with get, set
    abstract neutralPrimaryAltBorderHover: string with get, set
    abstract neutralSecondary: string with get, set
    abstract neutralSecondaryHover: string with get, set
    abstract neutralSecondaryBackground: string with get, set
    abstract neutralSecondaryBackgroundHover: string with get, set
    abstract neutralSecondaryBorder: string with get, set
    abstract neutralSecondaryBorderHover: string with get, set
    abstract neutralSecondaryAlt: string with get, set
    abstract neutralSecondaryAltHover: string with get, set
    abstract neutralSecondaryAltBackground: string with get, set
    abstract neutralSecondaryAltBackgroundHover: string with get, set
    abstract neutralSecondaryAltBorder: string with get, set
    abstract neutralSecondaryAltBorderHover: string with get, set
    abstract neutralTertiary: string with get, set
    abstract neutralTertiaryHover: string with get, set
    abstract neutralTertiaryBackground: string with get, set
    abstract neutralTertiaryBackgroundHover: string with get, set
    abstract neutralTertiaryBorder: string with get, set
    abstract neutralTertiaryBorderHover: string with get, set
    abstract neutralTertiaryAlt: string with get, set
    abstract neutralTertiaryAltHover: string with get, set
    abstract neutralTertiaryAltBackground: string with get, set
    abstract neutralTertiaryAltBackgroundHover: string with get, set
    abstract neutralTertiaryAltBorder: string with get, set
    abstract neutralTertiaryAltBorderHover: string with get, set
    abstract neutralQuaternary: string with get, set
    abstract neutralQuaternaryHover: string with get, set
    abstract neutralQuaternaryBackground: string with get, set
    abstract neutralQuaternaryBackgroundHover: string with get, set
    abstract neutralQuaternaryBorder: string with get, set
    abstract neutralQuaternaryBorderHover: string with get, set
    abstract neutralQuaternaryAlt: string with get, set
    abstract neutralQuaternaryAltHover: string with get, set
    abstract neutralQuaternaryAltBackground: string with get, set
    abstract neutralQuaternaryAltBackgroundHover: string with get, set
    abstract neutralQuaternaryAltBorder: string with get, set
    abstract neutralQuaternaryAltBorderHover: string with get, set
    abstract neutralLight: string with get, set
    abstract neutralLightHover: string with get, set
    abstract neutralLightBackground: string with get, set
    abstract neutralLightBackgroundHover: string with get, set
    abstract neutralLightBorder: string with get, set
    abstract neutralLightBorderHover: string with get, set
    abstract neutralLighter: string with get, set
    abstract neutralLighterHover: string with get, set
    abstract neutralLighterBackground: string with get, set
    abstract neutralLighterBackgroundHover: string with get, set
    abstract neutralLighterBorder: string with get, set
    abstract neutralLighterBorderHover: string with get, set
    abstract neutralLighterAlt: string with get, set
    abstract neutralLighterAltHover: string with get, set
    abstract neutralLighterAltBackground: string with get, set
    abstract neutralLighterAltBackgroundHover: string with get, set
    abstract neutralLighterAltBorder: string with get, set
    abstract neutralLighterAltBorderHover: string with get, set
    abstract white: string with get, set
    abstract whiteHover: string with get, set
    abstract whiteBackground: string with get, set
    abstract whiteBackgroundHover: string with get, set
    abstract whiteBorder: string with get, set
    abstract whiteBorderHover: string with get, set
    abstract whiteTranslucent40: string with get, set
    abstract whiteTranslucent40Hover: string with get, set
    abstract whiteTranslucent40Background: string with get, set
    abstract whiteTranslucent40BackgroundHover: string with get, set
    abstract whiteTranslucent40Border: string with get, set
    abstract whiteTranslucent40BorderHover: string with get, set
    abstract yellow: string with get, set
    abstract yellowHover: string with get, set
    abstract yellowBackground: string with get, set
    abstract yellowBackgroundHover: string with get, set
    abstract yellowBorder: string with get, set
    abstract yellowBorderHover: string with get, set
    abstract yellowLight: string with get, set
    abstract yellowLightHover: string with get, set
    abstract yellowLightBackground: string with get, set
    abstract yellowLightBackgroundHover: string with get, set
    abstract yellowLightBorder: string with get, set
    abstract yellowLightBorderHover: string with get, set
    abstract orange: string with get, set
    abstract orangeHover: string with get, set
    abstract orangeBackground: string with get, set
    abstract orangeBackgroundHover: string with get, set
    abstract orangeBorder: string with get, set
    abstract orangeBorderHover: string with get, set
    abstract orangeLight: string with get, set
    abstract orangeLightHover: string with get, set
    abstract orangeLightBackground: string with get, set
    abstract orangeLightBackgroundHover: string with get, set
    abstract orangeLightBorder: string with get, set
    abstract orangeLightBorderHover: string with get, set
    abstract orangeLighter: string with get, set
    abstract orangeLighterHover: string with get, set
    abstract orangeLighterBackground: string with get, set
    abstract orangeLighterBackgroundHover: string with get, set
    abstract orangeLighterBorder: string with get, set
    abstract orangeLighterBorderHover: string with get, set
    abstract redDark: string with get, set
    abstract redDarkHover: string with get, set
    abstract redDarkBackground: string with get, set
    abstract redDarkBackgroundHover: string with get, set
    abstract redDarkBorder: string with get, set
    abstract redDarkBorderHover: string with get, set
    abstract red: string with get, set
    abstract redHover: string with get, set
    abstract redBackground: string with get, set
    abstract redBackgroundHover: string with get, set
    abstract redBorder: string with get, set
    abstract redBorderHover: string with get, set
    abstract magentaDark: string with get, set
    abstract magentaDarkHover: string with get, set
    abstract magentaDarkBackground: string with get, set
    abstract magentaDarkBackgroundHover: string with get, set
    abstract magentaDarkBorder: string with get, set
    abstract magentaDarkBorderHover: string with get, set
    abstract magenta: string with get, set
    abstract magentaHover: string with get, set
    abstract magentaBackground: string with get, set
    abstract magentaBackgroundHover: string with get, set
    abstract magentaBorder: string with get, set
    abstract magentaBorderHover: string with get, set
    abstract magentaLight: string with get, set
    abstract magentaLightHover: string with get, set
    abstract magentaLightBackground: string with get, set
    abstract magentaLightBackgroundHover: string with get, set
    abstract magentaLightBorder: string with get, set
    abstract magentaLightBorderHover: string with get, set
    abstract purpleDark: string with get, set
    abstract purpleDarkHover: string with get, set
    abstract purpleDarkBackground: string with get, set
    abstract purpleDarkBackgroundHover: string with get, set
    abstract purpleDarkBorder: string with get, set
    abstract purpleDarkBorderHover: string with get, set
    abstract purple: string with get, set
    abstract purpleHover: string with get, set
    abstract purpleBackground: string with get, set
    abstract purpleBackgroundHover: string with get, set
    abstract purpleBorder: string with get, set
    abstract purpleBorderHover: string with get, set
    abstract purpleLight: string with get, set
    abstract purpleLightHover: string with get, set
    abstract purpleLightBackground: string with get, set
    abstract purpleLightBackgroundHover: string with get, set
    abstract purpleLightBorder: string with get, set
    abstract purpleLightBorderHover: string with get, set
    abstract blueDark: string with get, set
    abstract blueDarkHover: string with get, set
    abstract blueDarkBackground: string with get, set
    abstract blueDarkBackgroundHover: string with get, set
    abstract blueDarkBorder: string with get, set
    abstract blueDarkBorderHover: string with get, set
    abstract blueMid: string with get, set
    abstract blueMidHover: string with get, set
    abstract blueMidBackground: string with get, set
    abstract blueMidBackgroundHover: string with get, set
    abstract blueMidBorder: string with get, set
    abstract blueMidBorderHover: string with get, set
    abstract blue: string with get, set
    abstract blueHover: string with get, set
    abstract blueBackground: string with get, set
    abstract blueBackgroundHover: string with get, set
    abstract blueBorder: string with get, set
    abstract blueBorderHover: string with get, set
    abstract blueLight: string with get, set
    abstract blueLightHover: string with get, set
    abstract blueLightBackground: string with get, set
    abstract blueLightBackgroundHover: string with get, set
    abstract blueLightBorder: string with get, set
    abstract blueLightBorderHover: string with get, set
    abstract tealDark: string with get, set
    abstract tealDarkHover: string with get, set
    abstract tealDarkBackground: string with get, set
    abstract tealDarkBackgroundHover: string with get, set
    abstract tealDarkBorder: string with get, set
    abstract tealDarkBorderHover: string with get, set
    abstract teal: string with get, set
    abstract tealHover: string with get, set
    abstract tealBackground: string with get, set
    abstract tealBackgroundHover: string with get, set
    abstract tealBorder: string with get, set
    abstract tealBorderHover: string with get, set
    abstract tealLight: string with get, set
    abstract tealLightHover: string with get, set
    abstract tealLightBackground: string with get, set
    abstract tealLightBackgroundHover: string with get, set
    abstract tealLightBorder: string with get, set
    abstract tealLightBorderHover: string with get, set
    abstract greenDark: string with get, set
    abstract greenDarkHover: string with get, set
    abstract greenDarkBackground: string with get, set
    abstract greenDarkBackgroundHover: string with get, set
    abstract greenDarkBorder: string with get, set
    abstract greenDarkBorderHover: string with get, set
    abstract green: string with get, set
    abstract greenHover: string with get, set
    abstract greenBackground: string with get, set
    abstract greenBackgroundHover: string with get, set
    abstract greenBorder: string with get, set
    abstract greenBorderHover: string with get, set
    abstract greenLight: string with get, set
    abstract greenLightHover: string with get, set
    abstract greenLightBackground: string with get, set
    abstract greenLightBackgroundHover: string with get, set
    abstract greenLightBorder: string with get, set
    abstract greenLightBorderHover: string with get, set
type IAnimationStyles = ___interfaces_index.IAnimationStyles
type IAnimationVariables = ___interfaces_index.IAnimationVariables
let [<Import("IAnimationVariables","@uifabric/styling/lib-es2015/styles/AnimationStyles")>] AnimationVariables: IAnimationVariables = jsNative
let [<Import("IAnimationStyles","@uifabric/styling/lib-es2015/styles/AnimationStyles")>] AnimationStyles: IAnimationStyles = jsNative
type IFontStyles = ___interfaces_index.IFontStyles
let [<Import("IFontStyles","@uifabric/styling/lib-es2015/styles/DefaultFontStyles")>] DefaultFontStyles: IFontStyles = jsNative

type [<AllowNullLiteral>] IExports =
    abstract registerDefaultFontFaces: baseUrl: string -> unit
type IFontStyles = ___interfaces_index.IFontStyles

type [<AllowNullLiteral>] IExports =
    abstract createFontStyles: localeCode: string option -> IFontStyles

module LocalizedFontNames =

    type [<AllowNullLiteral>] IExports =
        abstract Arabic: obj
        abstract Cyrillic: obj
        abstract EastEuropean: obj
        abstract Greek: obj
        abstract Hebrew: obj
        abstract Thai: obj
        abstract Vietnamese: obj
        abstract WestEuropean: obj
        abstract Selawik: obj

module LocalizedFontFamilies =

    type [<AllowNullLiteral>] IExports =
        abstract Arabic: string
        abstract ChineseSimplified: obj
        abstract ChineseTraditional: obj
        abstract Cyrillic: string
        abstract EastEuropean: string
        abstract Greek: string
        abstract Hebrew: string
        abstract Hindi: obj
        abstract Japanese: obj
        abstract Korean: obj
        abstract Selawik: string
        abstract Thai: obj
        abstract Vietnamese: string
        abstract WestEuropean: string

module FontSizes =

    type [<AllowNullLiteral>] IExports =
        abstract mini: obj
        abstract xSmall: obj
        abstract small: obj
        abstract smallPlus: obj
        abstract medium: obj
        abstract mediumPlus: obj
        abstract icon: obj
        abstract large: obj
        abstract xLarge: obj
        abstract xxLarge: obj
        abstract superLarge: obj
        abstract mega: obj

module FontWeights =

    type [<AllowNullLiteral>] IExports =
        abstract light: obj
        abstract semilight: obj
        abstract regular: obj
        abstract semibold: obj
        abstract bold: obj

module IconFontSizes =

    type [<AllowNullLiteral>] IExports =
        abstract xSmall: obj
        abstract small: obj
        abstract medium: obj
        abstract large: obj
type IRawStyle = @uifabric_merge_styles_lib_index.IRawStyle
type ITheme = ___interfaces_index.ITheme

type [<AllowNullLiteral>] IExports =
    /// <summary>Generates a focus style which can be used to define an :after focus border.</summary>
    /// <param name="theme">- The theme object to use.</param>
    /// <param name="inset">- The number of pixels to inset the border.</param>
    /// <param name="position">- The positioning applied to the container. Must
    /// be 'relative' or 'absolute' so that the focus border can live around it.</param>
    /// <param name="highContrastStyle">- Style for high contrast mode.</param>
    abstract getFocusStyle: theme: ITheme * ?inset: float * ?position: U2<string, string> * ?highContrastStyle: IRawStyle option -> IRawStyle
    /// Generates style to clear browser specific focus styles.
    abstract focusClear: unit -> IRawStyle
type ITheme = ___interfaces_index.ITheme

type [<AllowNullLiteral>] IExports =
    /// <summary>Checks for the `disableGlobalClassNames` property on the `theme` to determine if it should return `classNames`</summary>
    /// <param name="classNames">The global class names that apply when the flag is false</param>
    /// <param name="theme">The theme to check the flag on</param>
    abstract getGlobalClassNames: classNames: GlobalClassNames<'T> * theme: ITheme -> obj

type GlobalClassNames<'IStyles> =
    Record<obj, string>
type ITheme = ___interfaces_index.ITheme
type IPartialTheme = ___interfaces_index.IPartialTheme
let [<Import("obj","@uifabric/styling/lib-es2015/styles/theme")>] ThemeSettingName: obj = jsNative

type [<AllowNullLiteral>] IExports =
    /// <summary>Gets the theme object</summary>
    /// <param name="depComments">- Whether to include deprecated tags as comments for deprecated slots.</param>
    abstract getTheme: ?depComments: bool -> ITheme
    /// Registers a callback that gets called whenever the theme changes.
    /// This should only be used when the component cannot automatically get theme changes through its state.
    /// This will not register duplicate callbacks.
    abstract registerOnThemeChangeCallback: callback: (ITheme -> unit) -> unit
    /// See registerOnThemeChangeCallback().
    /// Removes previously registered callbacks.
    abstract removeOnThemeChangeCallback: callback: (ITheme -> unit) -> unit
    /// <summary>Applies the theme, while filling in missing slots.</summary>
    /// <param name="theme">- Partial theme object.</param>
    /// <param name="depComments">- Whether to include deprecated tags as comments for deprecated slots.</param>
    abstract loadTheme: theme: IPartialTheme * ?depComments: bool -> ITheme
    /// <summary>Creates a custom theme definition which can be used with the Customizer.</summary>
    /// <param name="theme">- Partial theme object.</param>
    /// <param name="depComments">- Whether to include deprecated tags as comments for deprecated slots.</param>
    abstract createTheme: theme: IPartialTheme * ?depComments: bool -> ITheme
let [<Import("obj","@uifabric/styling/lib-es2015/styles/CommonStyles")>] HighContrastSelector: obj = jsNative
let [<Import("obj","@uifabric/styling/lib-es2015/styles/CommonStyles")>] ScreenWidthMinSmall: obj = jsNative
let [<Import("obj","@uifabric/styling/lib-es2015/styles/CommonStyles")>] ScreenWidthMinMedium: obj = jsNative
let [<Import("obj","@uifabric/styling/lib-es2015/styles/CommonStyles")>] ScreenWidthMinLarge: obj = jsNative
let [<Import("obj","@uifabric/styling/lib-es2015/styles/CommonStyles")>] ScreenWidthMinXLarge: obj = jsNative
let [<Import("obj","@uifabric/styling/lib-es2015/styles/CommonStyles")>] ScreenWidthMinXXLarge: obj = jsNative
let [<Import("obj","@uifabric/styling/lib-es2015/styles/CommonStyles")>] ScreenWidthMinXXXLarge: obj = jsNative
let [<Import("float","@uifabric/styling/lib-es2015/styles/CommonStyles")>] ScreenWidthMaxSmall: float = jsNative
let [<Import("float","@uifabric/styling/lib-es2015/styles/CommonStyles")>] ScreenWidthMaxMedium: float = jsNative
let [<Import("float","@uifabric/styling/lib-es2015/styles/CommonStyles")>] ScreenWidthMaxLarge: float = jsNative
let [<Import("float","@uifabric/styling/lib-es2015/styles/CommonStyles")>] ScreenWidthMaxXLarge: float = jsNative
let [<Import("float","@uifabric/styling/lib-es2015/styles/CommonStyles")>] ScreenWidthMaxXXLarge: float = jsNative

type [<AllowNullLiteral>] IExports =
    abstract getScreenSelector: min: float * max: float -> string
type IRawStyle = @uifabric_merge_styles_lib_index.IRawStyle
let [<Import("IRawStyle","@uifabric/styling/lib-es2015/styles/GeneralStyles")>] normalize: IRawStyle = jsNative
let [<Import("IRawStyle","@uifabric/styling/lib-es2015/styles/GeneralStyles")>] noWrap: IRawStyle = jsNative

module ZIndexes =

    type [<AllowNullLiteral>] IExports =
        abstract Nav: obj
        abstract ScrollablePane: obj
        abstract FocusStyle: obj
        abstract Coachmark: obj
        abstract Layer: obj
        abstract KeytipLayer: obj

type [<AllowNullLiteral>] IExports =
    /// <summary>Builds a class names object from a given map.</summary>
    /// <param name="styles">- Map of unprocessed styles.</param>
    abstract buildClassMap: styles: 'T -> obj
type IRawStyle = @uifabric_merge_styles_lib_index.IRawStyle
type IFontFace = @uifabric_merge_styles_lib_index.IFontFace

type [<AllowNullLiteral>] IExports =
    /// <summary>Registers a given subset of icons.</summary>
    /// <param name="iconSubset">- the icon subset definition.</param>
    abstract registerIcons: iconSubset: IIconSubset * ?options: obj -> unit
    /// Remaps one icon name to another.
    abstract registerIconAlias: iconName: string * mappedToName: string -> unit
    /// <summary>Gets an icon definition. If an icon is requested but the subset has yet to be registered,
    /// it will get registered immediately.</summary>
    /// <param name="name">- Name of icon.</param>
    abstract getIcon: ?name: string -> IIconRecord option
    /// Sets the icon options.
    abstract setIconOptions: options: obj -> unit

type [<AllowNullLiteral>] IIconSubset =
    abstract fontFace: IFontFace option with get, set
    abstract icons: obj with get, set
    abstract style: IRawStyle option with get, set

type [<AllowNullLiteral>] IIconSubsetRecord =
    inherit IIconSubset
    abstract isRegistered: bool option with get, set
    abstract className: string option with get, set

type [<AllowNullLiteral>] IIconRecord =
    abstract code: string option with get, set
    abstract subset: IIconSubsetRecord with get, set

type [<AllowNullLiteral>] IIconOptions =
    /// By default, registering the same set of icons will generate a console warning per duplicate icon
    /// registered, because this scenario can create unexpected consequences.
    /// 
    /// Some scenarios include:
    /// 
    /// Icon set was previously registered using a different base url.
    /// Icon set was previously registered but a different version was provided.
    /// Icons in a previous registered set overlap with a new set.
    /// 
    /// To simply ignore previously registered icons, you can specify to disable warnings. This means
    /// that if an icon which was previous registered is registered again, it will be silently ignored.
    /// However, consider whether the problems listed above will cause issues.
    abstract disableWarnings: bool with get, set
    abstract warnOnMissingIcons: bool option with get, set

type [<AllowNullLiteral>] IIconRecords =
    abstract __options: IIconOptions with get, set
    abstract __remapped: obj with get, set
    [<Emit "$0[$1]{{=$2}}">] abstract Item: key: string -> U2<IIconRecord, obj> with get, set

type [<AllowNullLiteral>] IExports =
    /// Gets an icon classname. You should be able to add this classname to an I tag with no
    /// additional classnames, and render the icon.
    abstract getIconClassName: name: string -> string

type [<AllowNullLiteral>] IExports =
    abstract Async: AsyncStatic

/// Bugs often appear in async code when stuff gets disposed, but async operations don't get canceled.
/// This Async helper class solves these issues by tying async code to the lifetime of a disposable object.
/// 
/// Usage: Anything class extending from BaseModel can access this helper via this.async. Otherwise create a
/// new instance of the class and remember to call dispose() during your code's dispose handler.
type [<AllowNullLiteral>] Async =
    abstract _timeoutIds: obj with get, set
    abstract _immediateIds: obj with get, set
    abstract _intervalIds: obj with get, set
    abstract _animationFrameIds: obj with get, set
    abstract _isDisposed: obj with get, set
    abstract _parent: obj with get, set
    abstract _onErrorHandler: obj with get, set
    abstract _noop: obj with get, set
    /// Dispose function, clears all async operations.
    abstract dispose: unit -> unit
    /// <summary>SetTimeout override, which will auto cancel the timeout during dispose.</summary>
    /// <param name="callback">- Callback to execute.</param>
    /// <param name="duration">- Duration in milliseconds.</param>
    abstract setTimeout: callback: (unit -> unit) * duration: float -> float
    /// <summary>Clears the timeout.</summary>
    /// <param name="id">- Id to cancel.</param>
    abstract clearTimeout: id: float -> unit
    /// <summary>SetImmediate override, which will auto cancel the immediate during dispose.</summary>
    /// <param name="callback">- Callback to execute.</param>
    abstract setImmediate: callback: (unit -> unit) -> float
    /// <summary>Clears the immediate.</summary>
    /// <param name="id">- Id to cancel.</param>
    abstract clearImmediate: id: float -> unit
    /// <summary>SetInterval override, which will auto cancel the timeout during dispose.</summary>
    /// <param name="callback">- Callback to execute.</param>
    /// <param name="duration">- Duration in milliseconds.</param>
    abstract setInterval: callback: (unit -> unit) * duration: float -> float
    /// <summary>Clears the interval.</summary>
    /// <param name="id">- Id to cancel.</param>
    abstract clearInterval: id: float -> unit
    /// <summary>Creates a function that, when executed, will only call the func function at most once per
    /// every wait milliseconds. Provide an options object to indicate that func should be invoked
    /// on the leading and/or trailing edge of the wait timeout. Subsequent calls to the throttled
    /// function will return the result of the last func call.
    /// 
    /// Note: If leading and trailing options are true func will be called on the trailing edge of
    /// the timeout only if the the throttled function is invoked more than once during the wait timeout.</summary>
    /// <param name="func">- The function to throttle.</param>
    /// <param name="wait">- The number of milliseconds to throttle executions to. Defaults to 0.</param>
    /// <param name="options">- The options object.</param>
    abstract throttle: func: 'T * ?wait: float * ?options: AsyncThrottleOptions -> U2<'T, (unit -> unit)>
    /// <summary>Creates a function that will delay the execution of func until after wait milliseconds have
    /// elapsed since the last time it was invoked. Provide an options object to indicate that func
    /// should be invoked on the leading and/or trailing edge of the wait timeout. Subsequent calls
    /// to the debounced function will return the result of the last func call.
    /// 
    /// Note: If leading and trailing options are true func will be called on the trailing edge of
    /// the timeout only if the the debounced function is invoked more than once during the wait
    /// timeout.</summary>
    /// <param name="func">- The function to debounce.</param>
    /// <param name="wait">- The number of milliseconds to delay.</param>
    /// <param name="options">- The options object.</param>
    abstract debounce: func: 'T * ?wait: float * ?options: AsyncDebounceOptions -> obj
    abstract requestAnimationFrame: callback: (unit -> unit) -> float
    abstract cancelAnimationFrame: id: float -> unit
    abstract _logError: e: obj option -> unit

type [<AllowNullLiteral>] AsyncThrottleOptions =
    abstract leading: bool option with get, set
    abstract trailing: bool option with get, set

type [<AllowNullLiteral>] AsyncDebounceOptions =
    abstract leading: bool option with get, set
    abstract maxWait: float option with get, set
    abstract trailing: bool option with get, set

/// Bugs often appear in async code when stuff gets disposed, but async operations don't get canceled.
/// This Async helper class solves these issues by tying async code to the lifetime of a disposable object.
/// 
/// Usage: Anything class extending from BaseModel can access this helper via this.async. Otherwise create a
/// new instance of the class and remember to call dispose() during your code's dispose handler.
type [<AllowNullLiteral>] AsyncStatic =
    [<Emit "new $0($1...)">] abstract Create: ?parent: obj * ?onError: (obj option -> unit) -> Async

type [<AllowNullLiteral>] ICancelable<'T> =
    abstract flush: (unit -> 'T) with get, set
    abstract cancel: (unit -> unit) with get, set
    abstract pending: (unit -> bool) with get, set

type [<AllowNullLiteral>] IExports =
    abstract AutoScroll: AutoScrollStatic

/// AutoScroll simply hooks up mouse events given a parent element, and scrolls the container
/// up/down depending on how close the mouse is to the top/bottom of the container.
/// 
/// Once you don't want autoscroll any more, just dispose the helper and it will unhook events.
type [<AllowNullLiteral>] AutoScroll =
    abstract _events: obj with get, set
    abstract _scrollableParent: obj with get, set
    abstract _scrollRect: obj with get, set
    abstract _scrollVelocity: obj with get, set
    abstract _timeoutId: obj with get, set
    abstract dispose: unit -> unit
    abstract _onMouseMove: ev: obj -> unit
    abstract _onTouchMove: ev: obj -> unit
    abstract _computeScrollVelocity: clientY: obj -> unit
    abstract _startScroll: unit -> unit
    abstract _incrementScroll: unit -> unit
    abstract _stopScroll: unit -> unit

/// AutoScroll simply hooks up mouse events given a parent element, and scrolls the container
/// up/down depending on how close the mouse is to the top/bottom of the container.
/// 
/// Once you don't want autoscroll any more, just dispose the helper and it will unhook events.
type [<AllowNullLiteral>] AutoScrollStatic =
    [<Emit "new $0($1...)">] abstract Create: element: HTMLElement -> AutoScroll

type [<AllowNullLiteral>] IExports =
    abstract EventGroup: EventGroupStatic

/// EventRecord interface.
type [<AllowNullLiteral>] IEventRecord =
    abstract target: obj option with get, set
    abstract eventName: string with get, set
    abstract parent: obj option with get, set
    abstract callback: (obj option -> unit) with get, set
    abstract elementCallback: (ResizeArray<obj option> -> unit) option with get, set
    abstract objectCallback: (obj option -> unit) option with get, set
    abstract useCapture: bool with get, set

/// EventRecordsByName interface.
type [<AllowNullLiteral>] IEventRecordsByName =
    [<Emit "$0[$1]{{=$2}}">] abstract Item: eventName: string -> IEventRecordList with get, set

/// EventRecordList interface.
type [<AllowNullLiteral>] IEventRecordList =
    [<Emit "$0[$1]{{=$2}}">] abstract Item: id: string -> U2<ResizeArray<IEventRecord>, float> with get, set
    abstract count: float with get, set

/// DeclaredEventsByName interface.
type [<AllowNullLiteral>] IDeclaredEventsByName =
    [<Emit "$0[$1]{{=$2}}">] abstract Item: eventName: string -> bool with get, set

/// An instance of EventGroup allows anything with a handle to it to trigger events on it.
/// If the target is an HTMLElement, the event will be attached to the element and can be
/// triggered as usual (like clicking for onclick).
/// The event can be triggered by calling EventGroup.raise() here. If the target is an
/// HTMLElement, the event gets raised and is handled by the browser. Otherwise, it gets
/// handled here in EventGroup, and the handler is called in the context of the parent
/// (which is passed in in the constructor).
type [<AllowNullLiteral>] EventGroup =
    abstract _uniqueId: obj with get, set
    abstract _parent: obj with get, set
    abstract _eventRecords: obj with get, set
    abstract _id: obj with get, set
    abstract _isDisposed: obj with get, set
    abstract dispose: unit -> unit
    /// On the target, attach a set of events, where the events object is a name to function mapping. 
    abstract onAll: target: obj option * events: EventGroupOnAllEvents * ?useCapture: bool -> unit
    /// On the target, attach an event whose handler will be called in the context of the parent
    /// of this instance of EventGroup.
    abstract on: target: obj option * eventName: string * callback: (obj option -> unit) * ?useCapture: bool -> unit
    abstract off: ?target: obj option * ?eventName: string * ?callback: (obj option -> unit) * ?useCapture: bool -> unit
    /// Trigger the given event in the context of this instance of EventGroup. 
    abstract raise: eventName: string * ?eventArgs: obj option * ?bubbleEvent: bool -> bool option
    /// Declare an event as being supported by this instance of EventGroup. 
    abstract declare: ``event``: U2<string, ResizeArray<string>> -> unit

type [<AllowNullLiteral>] EventGroupOnAllEvents =
    [<Emit "$0[$1]{{=$2}}">] abstract Item: key: string -> (obj option -> unit) with get, set

/// An instance of EventGroup allows anything with a handle to it to trigger events on it.
/// If the target is an HTMLElement, the event will be attached to the element and can be
/// triggered as usual (like clicking for onclick).
/// The event can be triggered by calling EventGroup.raise() here. If the target is an
/// HTMLElement, the event gets raised and is handled by the browser. Otherwise, it gets
/// handled here in EventGroup, and the handler is called in the context of the parent
/// (which is passed in in the constructor).
type [<AllowNullLiteral>] EventGroupStatic =
    /// For IE8, bubbleEvent is ignored here and must be dealt with by the handler.
    /// Events raised here by default have bubbling set to false and cancelable set to true.
    /// This applies also to built-in events being raised manually here on HTMLElements,
    /// which may lead to unexpected behavior if it differs from the defaults.
    abstract raise: target: obj option * eventName: string * ?eventArgs: obj option * ?bubbleEvent: bool -> bool option
    abstract isObserved: target: obj option * eventName: string -> bool
    /// Check to see if the target has declared support of the given event. 
    abstract isDeclared: target: obj option * eventName: string -> bool
    abstract stopPropagation: ``event``: obj option -> unit
    abstract _isElement: target: obj -> unit
    /// parent: the context in which events attached to non-HTMLElements are called 
    [<Emit "new $0($1...)">] abstract Create: parent: obj option -> EventGroup

/// Disposable interface.
type [<AllowNullLiteral>] IDisposable =
    abstract dispose: (unit -> unit) with get, set

type [<AllowNullLiteral>] IExports =
    /// <summary>Warns when a deprecated props are being used.</summary>
    /// <param name="componentName">- The name of the component being used.</param>
    /// <param name="props">- The props passed into the component.</param>
    /// <param name="deprecationMap">- The map of deprecations, where key is the prop name and the value is
    /// either null or a replacement prop name.</param>
    abstract warnDeprecations: componentName: string * props: 'P * deprecationMap: ISettingsMap<'P> -> unit
    /// <summary>Warns when two props which are mutually exclusive are both being used.</summary>
    /// <param name="componentName">- The name of the component being used.</param>
    /// <param name="props">- The props passed into the component.</param>
    /// <param name="exclusiveMap">- A map where the key is a parameter, and the value is the other parameter.</param>
    abstract warnMutuallyExclusive: componentName: string * props: 'P * exclusiveMap: ISettingsMap<'P> -> unit
    /// <summary>Warns when props are required if a condition is met.</summary>
    /// <param name="componentName">- The name of the component being used.</param>
    /// <param name="props">- The props passed into the component.</param>
    /// <param name="requiredProps">- The name of the props that are required when the condition is met.</param>
    /// <param name="conditionalPropName">- The name of the prop that the condition is based on.</param>
    /// <param name="condition">- Whether the condition is met.</param>
    abstract warnConditionallyRequiredProps: componentName: string * props: 'P * requiredProps: ResizeArray<string> * conditionalPropName: string * condition: bool -> unit
    /// <summary>Sends a warning to console, if the api is present.</summary>
    /// <param name="message">- Warning message.</param>
    abstract warn: message: string -> unit
    /// <summary>Configures the warning callback. Passing in undefined will reset it to use the default
    /// console.warn function.</summary>
    /// <param name="warningCallback">- Callback to override the generated warnings.</param>
    abstract setWarningCallback: ?warningCallback: (string -> unit) -> unit

type [<AllowNullLiteral>] ISettingsMap<'T> =
    interface end
type Async = __Async.Async
type EventGroup = __EventGroup.EventGroup
type IDisposable = __IDisposable.IDisposable
type ISettingsMap = __warn.ISettingsMap

type [<AllowNullLiteral>] IExports =
    abstract BaseComponent: BaseComponentStatic
    /// Simple constant function for returning null, used to render empty templates in JSX.
    abstract nullRender: unit -> JSX.Element option

type IBaseProps =
    IBaseProps<obj>

/// BaseProps interface.
type [<AllowNullLiteral>] IBaseProps<'T> =
    abstract componentRef: ('T option -> U2<unit, 'T>) option with get, set

type BaseComponent<'S> =
    BaseComponent<obj, 'S>

type BaseComponent =
    BaseComponent<obj, obj>

/// BaseComponent class, which provides basic helpers for all components.
type [<AllowNullLiteral>] BaseComponent<'P, 'S> =
    inherit React.Component<'P, 'S>
    abstract onError: (string -> obj option -> unit) with get, set
    /// Controls whether the componentRef prop will be resolved by this component instance. If you are
    /// implementing a passthrough (higher-order component), you would set this to false and pass through
    /// the props to the inner component, allowing it to resolve the componentRef.
    abstract _shouldUpdateComponentRef: bool with get, set
    abstract __async: obj with get, set
    abstract __events: obj with get, set
    abstract __disposables: obj with get, set
    abstract __resolves: obj with get, set
    abstract __className: obj with get, set
    /// When the component will receive props, make sure the componentRef is updated.
    abstract componentWillReceiveProps: newProps: obj * newContext: obj option -> unit
    /// When the component has mounted, update the componentRef.
    abstract componentDidMount: unit -> unit
    /// If we have disposables, dispose them automatically on unmount.
    abstract componentWillUnmount: unit -> unit
    /// Gets the object's class name.
    abstract className: string
    /// Allows subclasses to push things to this._disposables to be auto disposed.
    abstract _disposables: ResizeArray<IDisposable>
    /// Gets the async instance associated with the component, created on demand. The async instance gives
    /// subclasses a way to execute setTimeout/setInterval async calls safely, where the callbacks
    /// will be cleared/ignored automatically after unmounting. The helpers within the async object also
    /// preserve the this pointer so that you don't need to "bind" the callbacks.
    abstract _async: Async
    /// Gets the event group instance assocaited with the component, created on demand. The event instance
    /// provides on/off methods for listening to DOM (or regular javascript object) events. The event callbacks
    /// will be automatically disconnected after unmounting. The helpers within the events object also
    /// preserve the this reference so that you don't need to "bind" the callbacks.
    abstract _events: EventGroup
    /// <summary>Helper to return a memoized ref resolver function.</summary>
    /// <param name="refName">- Name of the member to assign the ref to.</param>
    abstract _resolveRef: refName: string -> (React.ReactNode -> React.ReactNode)
    /// Updates the componentRef (by calling it with "this" when necessary.)
    abstract _updateComponentRef: currentProps: IBaseProps option * ?newProps: IBaseProps -> unit
    /// <summary>Warns when a deprecated props are being used.</summary>
    /// <param name="deprecationMap">- The map of deprecations, where key is the prop name and the value is
    /// either null or a replacement prop name.</param>
    abstract _warnDeprecations: deprecationMap: ISettingsMap<'P> -> unit
    /// <summary>Warns when props which are mutually exclusive with each other are both used.</summary>
    /// <param name="mutuallyExclusiveMap">- The map of mutually exclusive props.</param>
    abstract _warnMutuallyExclusive: mutuallyExclusiveMap: ISettingsMap<'P> -> unit
    /// <summary>Warns when props are required if a condition is met.</summary>
    /// <param name="requiredProps">- The name of the props that are required when the condition is met.</param>
    /// <param name="conditionalPropName">- The name of the prop that the condition is based on.</param>
    /// <param name="condition">- Whether the condition is met.</param>
    abstract _warnConditionallyRequiredProps: requiredProps: ResizeArray<string> * conditionalPropName: string * condition: bool -> unit

/// BaseComponent class, which provides basic helpers for all components.
type [<AllowNullLiteral>] BaseComponentStatic =
    /// <summary>BaseComponent constructor</summary>
    /// <param name="props">- The props for the component.</param>
    /// <param name="context">- The context for the component.</param>
    [<Emit "new $0($1...)">] abstract Create: props: 'P * ?context: obj option -> BaseComponent<'P, 'S>
module PropTypes = Prop_types

type [<AllowNullLiteral>] IExports =
    abstract provideContext: contextTypes: PropTypes.ValidationMap<'TContext> * mapPropsToContext: ('TProps -> 'TContext) -> React.ComponentType<'TProps>

type [<AllowNullLiteral>] IExports =
    abstract Customizations: CustomizationsStatic

type [<AllowNullLiteral>] Settings =
    [<Emit "$0[$1]{{=$2}}">] abstract Item: key: string -> obj option with get, set

type [<AllowNullLiteral>] SettingsFunction =
    [<Emit "$0($1...)">] abstract Invoke: settings: Settings -> Settings

type [<AllowNullLiteral>] ICustomizations =
    abstract settings: Settings with get, set
    abstract scopedSettings: obj with get, set

type [<AllowNullLiteral>] Customizations =
    interface end

type [<AllowNullLiteral>] CustomizationsStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> Customizations
    abstract reset: unit -> unit
    abstract applySettings: settings: Settings -> unit
    abstract applyScopedSettings: scopeName: string * settings: Settings -> unit
    abstract getSettings: properties: ResizeArray<string> * ?scopeName: string * ?localSettings: ICustomizations -> obj option
    abstract observe: onChange: (unit -> unit) -> unit
    abstract unobserve: onChange: (unit -> unit) -> unit
    abstract _raiseChange: unit -> unit
module PropTypes = Prop_types
type BaseComponent = __BaseComponent.BaseComponent
type IBaseProps = __BaseComponent.IBaseProps
type ICustomizations = __Customizations.ICustomizations
type Settings = __Customizations.Settings
type SettingsFunction = __Customizations.SettingsFunction

type [<AllowNullLiteral>] IExports =
    abstract Customizer: CustomizerStatic

type [<AllowNullLiteral>] ICustomizerContext =
    abstract customizations: ICustomizations with get, set

type [<AllowNullLiteral>] ICustomizerProps =
    interface end

/// The Customizer component allows for default props to be mixed into components which
/// are decorated with the customizable() decorator. This enables injection scenarios like:
/// 
/// 1. render svg icons instead of the icon font within all buttons
/// 2. inject a custom theme object into a component
/// 
/// Props are provided via the settings prop which should be one of the following:
/// - A json map which contains 1 or more name/value pairs representing injectable props.
/// - A function that receives the current settings and returns the new ones that apply to the scope
type [<AllowNullLiteral>] Customizer =
    inherit BaseComponent<ICustomizerProps, ICustomizerContext>
    abstract contextTypes: obj with get, set
    abstract childContextTypes: obj with get, set
    abstract getChildContext: unit -> ICustomizerContext
    abstract componentWillReceiveProps: newProps: obj option * newContext: obj option -> unit
    abstract render: unit -> React.ReactElement<obj>
    abstract _getCustomizations: props: obj * context: obj -> unit

/// The Customizer component allows for default props to be mixed into components which
/// are decorated with the customizable() decorator. This enables injection scenarios like:
/// 
/// 1. render svg icons instead of the icon font within all buttons
/// 2. inject a custom theme object into a component
/// 
/// Props are provided via the settings prop which should be one of the following:
/// - A json map which contains 1 or more name/value pairs representing injectable props.
/// - A function that receives the current settings and returns the new ones that apply to the scope
type [<AllowNullLiteral>] CustomizerStatic =
    [<Emit "new $0($1...)">] abstract Create: props: ICustomizerProps * context: obj option -> Customizer

type [<AllowNullLiteral>] IExports =
    abstract DelayedRender: DelayedRenderStatic

/// DelayedRender component props.
type [<AllowNullLiteral>] IDelayedRenderProps =
    inherit React.Props<obj>
    /// Number of milliseconds to delay rendering children.
    abstract delay: float option with get, set

/// DelayedRender component state.
type [<AllowNullLiteral>] IDelayedRenderState =
    /// Whether the component is rendered or not.
    abstract isRendered: bool with get, set

/// Utility component for delaying the render of a child component after a given delay. This component
/// requires a single child component; don't pass in many components. Wrap multiple components in a DIV
/// if necessary.
type [<AllowNullLiteral>] DelayedRender =
    inherit React.Component<IDelayedRenderProps, IDelayedRenderState>
    abstract defaultProps: obj with get, set
    abstract _timeoutId: obj with get, set
    abstract componentDidMount: unit -> unit
    abstract componentWillUnmount: unit -> unit
    abstract render: unit -> React.ReactElement<obj> option

/// Utility component for delaying the render of a child component after a given delay. This component
/// requires a single child component; don't pass in many components. Wrap multiple components in a DIV
/// if necessary.
type [<AllowNullLiteral>] DelayedRenderStatic =
    [<Emit "new $0($1...)">] abstract Create: props: IDelayedRenderProps -> DelayedRender

type [<AllowNullLiteral>] IExports =
    abstract FabricPerformance: FabricPerformanceStatic

/// PerfData interface.
type [<AllowNullLiteral>] IPerfData =
    abstract duration: float with get, set
    abstract timeStamp: float with get, set

/// PerfMeasurement interface.
type [<AllowNullLiteral>] IPerfMeasurement =
    abstract totalDuration: float with get, set
    abstract count: float with get, set
    abstract all: ResizeArray<IPerfData> with get, set

/// PerfSummary interface.
type [<AllowNullLiteral>] IPerfSummary =
    [<Emit "$0[$1]{{=$2}}">] abstract Item: key: string -> IPerfMeasurement with get, set

/// Performance helper class for measuring things.
type [<AllowNullLiteral>] FabricPerformance =
    abstract summary: IPerfSummary with get, set
    abstract _timeoutId: obj with get, set

/// Performance helper class for measuring things.
type [<AllowNullLiteral>] FabricPerformanceStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> FabricPerformance
    /// <summary>Measures execution time of the given syncronous function. If the same logic is executed multiple times,
    /// each individual measurement will be collected as well the overall numbers.</summary>
    /// <param name="name">- The name of this measurement</param>
    /// <param name="func">- The logic to be measured for execution time</param>
    abstract ``measure``: name: string * func: (unit -> unit) -> unit
    abstract reset: unit -> unit
    abstract setPeriodicReset: unit -> unit

type [<AllowNullLiteral>] IExports =
    abstract GlobalSettings: GlobalSettingsStatic

/// Change description used for change callbacks in GlobalSettings.
type [<AllowNullLiteral>] IChangeDescription =
    abstract key: string with get, set
    abstract oldValue: obj option with get, set
    abstract value: obj option with get, set

/// Change event callback.
type [<AllowNullLiteral>] IChangeEventCallback =
    abstract __id__: string option with get, set
    [<Emit "$0($1...)">] abstract Invoke: ?changeDescription: IChangeDescription -> unit

/// Global settings helper, which stores settings in the global (window) namespace.
/// If window is not provided, it will store settings in module scope. Provides a
/// way to observe changes as well when their values change.
type [<AllowNullLiteral>] GlobalSettings =
    interface end

/// Global settings helper, which stores settings in the global (window) namespace.
/// If window is not provided, it will store settings in module scope. Provides a
/// way to observe changes as well when their values change.
type [<AllowNullLiteral>] GlobalSettingsStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> GlobalSettings
    abstract getValue: key: string * ?defaultValue: U2<'T, (unit -> 'T)> -> 'T
    abstract setValue: key: string * value: 'T -> 'T
    abstract addChangeListener: cb: IChangeEventCallback -> unit
    abstract removeChangeListener: cb: IChangeEventCallback -> unit

type [<AllowNullLiteral>] IClassNames<'T> =
    interface end

type IComponentAs<'T> =
    U2<React.StatelessComponent<'T>, React.ComponentClass<'T>>

[<RequireQualifiedAccess; CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
module IComponentAs =
    let ofReact.StatelessComponent v: IComponentAs<'T> = v |> U2.Case1
    let isReact.StatelessComponent (v: IComponentAs<'T>) = match v with U2.Case1 _ -> true | _ -> false
    let asReact.StatelessComponent (v: IComponentAs<'T>) = match v with U2.Case1 o -> Some o | _ -> None
    let ofReact.ComponentClass v: IComponentAs<'T> = v |> U2.Case2
    let isReact.ComponentClass (v: IComponentAs<'T>) = match v with U2.Case2 _ -> true | _ -> false
    let asReact.ComponentClass (v: IComponentAs<'T>) = match v with U2.Case2 o -> Some o | _ -> None

/// Point interface.
type [<AllowNullLiteral>] IPoint =
    abstract x: float with get, set
    abstract y: float with get, set

/// Rectangle interface.
type [<AllowNullLiteral>] IRectangle =
    abstract left: float with get, set
    abstract top: float with get, set
    abstract width: float with get, set
    abstract height: float with get, set
    abstract right: float option with get, set
    abstract bottom: float option with get, set

/// An interface representing a component that will not output any DOM, will just render its children and
/// pass through items to modify the children.
type [<AllowNullLiteral>] IRenderComponent<'TProps> =
    /// JSX.Element to return in this component's render() function.
    abstract children: ('TProps -> JSX.Element) with get, set

/// Render function interface for providing overrideable render callbacks.
type [<AllowNullLiteral>] IRenderFunction<'P> =
    [<Emit "$0($1...)">] abstract Invoke: ?props: 'P * ?defaultRender: ('P -> JSX.Element option) -> JSX.Element option

type [<AllowNullLiteral>] ISize =
    abstract width: float with get, set
    abstract height: float with get, set

type [<AllowNullLiteral>] IStyleFunction<'TStylesProps, 'TStyles> =
    [<Emit "$0($1...)">] abstract Invoke: props: 'TStylesProps -> obj

type [<RequireQualifiedAccess>] KeyCodes =
    | Backspace = 8
    | Tab = 9
    | Enter = 13
    | Shift = 16
    | Ctrl = 17
    | Alt = 18
    | PauseBreak = 19
    | Capslock = 20
    | Escape = 27
    | Space = 32
    | PageUp = 33
    | PageDown = 34
    | End = 35
    | Home = 36
    | Left = 37
    | Up = 38
    | Right = 39
    | Down = 40
    | Insert = 45
    | Del = 46
    | Zero = 48
    | One = 49
    | Two = 50
    | Three = 51
    | Four = 52
    | Five = 53
    | Six = 54
    | Seven = 55
    | Eight = 56
    | Nine = 57
    | A = 65
    | B = 66
    | C = 67
    | D = 68
    | E = 69
    | F = 70
    | G = 71
    | H = 72
    | I = 73
    | J = 74
    | K = 75
    | L = 76
    | M = 77
    | N = 78
    | O = 79
    | P = 80
    | Q = 81
    | R = 82
    | S = 83
    | T = 84
    | U = 85
    | V = 86
    | W = 87
    | X = 88
    | Y = 89
    | Z = 90
    | LeftWindow = 91
    | RightWindow = 92
    | Select = 93
    | Zero_numpad = 96
    | One_numpad = 97
    | Two_numpad = 98
    | Three_numpad = 99
    | Four_numpad = 100
    | Five_numpad = 101
    | Six_numpad = 102
    | Seven_numpad = 103
    | Eight_numpad = 104
    | Nine_numpad = 105
    | Multiply = 106
    | Add = 107
    | Subtract = 109
    | DecimalPoint = 110
    | Divide = 111
    | F1 = 112
    | F2 = 113
    | F3 = 114
    | F4 = 115
    | F5 = 116
    | F6 = 117
    | F7 = 118
    | F8 = 119
    | F9 = 120
    | F10 = 121
    | F11 = 122
    | F12 = 123
    | Numlock = 144
    | ScrollLock = 145
    | Semicolon = 186
    | EqualSign = 187
    | Comma = 188
    | Dash = 189
    | Period = 190
    | ForwardSlash = 191
    | GraveAccent = 192
    | OpenBracket = 219
    | BackSlash = 220
    | CloseBracket = 221
    | SingleQuote = 222

type [<AllowNullLiteral>] IExports =
    abstract Rectangle: RectangleStatic

/// Rectangle helper class.
type [<AllowNullLiteral>] Rectangle =
    abstract top: float with get, set
    abstract bottom: float with get, set
    abstract left: float with get, set
    abstract right: float with get, set
    /// Calculated automatically by subtracting the right from left
    abstract width: float
    /// Calculated automatically by subtracting the bottom from top.
    abstract height: float
    /// Tests if another rect is approximately equal to this rect (within 4 decimal places.)
    abstract equals: rect: Rectangle -> bool

/// Rectangle helper class.
type [<AllowNullLiteral>] RectangleStatic =
    [<Emit "new $0($1...)">] abstract Create: ?left: float * ?right: float * ?top: float * ?bottom: float -> Rectangle

type [<AllowNullLiteral>] IExports =
    /// <summary>Helper to find the index of an item within an array, using a callback to
    /// determine the match.</summary>
    /// <param name="array">- Array to search.</param>
    /// <param name="cb">- Callback which returns true on matches.</param>
    abstract findIndex: array: ResizeArray<'T> * cb: ('T -> float -> bool) -> float
    /// <summary>Helper to find the first item within an array that satisfies the callback.</summary>
    /// <param name="array">- Array to search</param>
    /// <param name="cb">- Callback which returns true on matches</param>
    abstract find: array: ResizeArray<'T> * cb: ('T -> float -> bool) -> 'T option
    /// <summary>Creates an array of a given size and helper method to populate.</summary>
    /// <param name="size">- Size of array.</param>
    /// <param name="getItem">- Callback to populate given cell index.</param>
    abstract createArray: size: float * getItem: (float -> 'T) -> ResizeArray<'T>
    /// <summary>Convert the given array to a matrix with columnCount number
    /// of columns.</summary>
    /// <param name="items">- The array to convert</param>
    /// <param name="columnCount">- The number of columns for the resulting matrix</param>
    abstract toMatrix: items: ResizeArray<'T> * columnCount: float -> ResizeArray<ResizeArray<'T>>
    /// <summary>Given an array, it returns a new array that does not contain the item at the given index.</summary>
    /// <param name="array">- The array to operate on</param>
    /// <param name="index">- The index of the element to remove</param>
    abstract removeIndex: array: ResizeArray<'T> * index: float -> ResizeArray<'T>
    /// <summary>Given an array, this function returns a new array where the element at a given index has been replaced.</summary>
    /// <param name="array">- The array to operate on</param>
    /// <param name="newElement">- The element that will be placed in the new array</param>
    /// <param name="index">- The index of the element that should be replaced</param>
    abstract replaceElement: array: ResizeArray<'T> * newElement: 'T * index: float -> ResizeArray<'T>
    /// <summary>Given an array, this function returns a new array where an element has been inserted at the given index.</summary>
    /// <param name="array">- The array to operate on</param>
    /// <param name="index">- The index where an element should be inserted</param>
    /// <param name="itemToAdd">- The element to insert</param>
    abstract addElementAtIndex: array: ResizeArray<'T> * index: float * itemToAdd: 'T -> ResizeArray<'T>
    /// <summary>Given an array where each element is of type T or T[], flatten it into an array of T</summary>
    /// <param name="array">- The array where each element can optionally also be an array</param>
    abstract flatten: array: ResizeArray<U2<'T, ResizeArray<'T>>> -> ResizeArray<'T>
    /// <summary>Returns a boolean indicating if the two given arrays are equal in length and values.</summary>
    /// <param name="array1">- First array to compare</param>
    /// <param name="array2">- Second array to compare</param>
    abstract arraysEqual: array1: ResizeArray<'T> * array2: ResizeArray<'T> -> bool

type [<AllowNullLiteral>] IExports =
    /// AssertNever is a utility function that can be used for exhaustiveness checks in switch statements.
    abstract assertNever: x: obj -> obj

type [<AllowNullLiteral>] IExports =
    /// Autobind is a utility for binding methods in a class. This simplifies tagging methods as being "bound" to the this pointer
    /// so that they can be used in scenarios that simply require a function callback.
    abstract autobind: target: obj option * key: string * descriptor: TypedPropertyDescriptor<'T> -> U2<obj, unit>
type IStyle = @uifabric_merge_styles_lib_index.IStyle
type IClassNames = __IClassNames.IClassNames
type IStyleFunction = __IStyleFunction.IStyleFunction

type [<AllowNullLiteral>] IExports =
    /// Creates a getClassNames function which calls getStyles given the props, and injects them
    /// into mergeStyleSets.
    abstract classNamesFunction: unit -> (IStyleFunction<'TStyleProps, 'TStyles> -> 'TStyleProps -> IClassNames<'TStyles>)

type [<AllowNullLiteral>] IExports =
    /// This is a polyfill for the React.createRef() api.
    /// For more info on React.createRef() see the official React documentation
    /// on creating and accessing refs.
    abstract createRef: unit -> RefObject<'T>

type [<AllowNullLiteral>] RefObject<'T> =
    [<Emit "$0($1...)">] abstract Invoke: ``component``: 'T option -> unit
    abstract current: 'T option with get, set
    abstract value: 'T option with get, set

type [<AllowNullLiteral>] IExports =
    /// Concatination helper, which can merge class names together. Skips over falsey values.
    abstract css: [<ParamArray>] args: ResizeArray<ICssInput> -> string

/// Dictionary of booleans.
type [<AllowNullLiteral>] IDictionary =
    [<Emit "$0[$1]{{=$2}}">] abstract Item: className: string -> bool with get, set

/// Serializable object.
type [<AllowNullLiteral>] ISerializableObject =
    abstract toString: (unit -> string) option with get, set

type ICssInput =
    U4<string, ISerializableObject, IDictionary, bool> option

[<RequireQualifiedAccess; CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
module ICssInput =
    let ofStringOption v: ICssInput = v |> Microsoft.FSharp.Core.Option.map U4.Case1
    let ofString v: ICssInput = v |> U4.Case1 |> Some
    let isString (v: ICssInput) = match v with None -> false | Some o -> match o with U4.Case1 _ -> true | _ -> false
    let asString (v: ICssInput) = match v with None -> None | Some o -> match o with U4.Case1 o -> Some o | _ -> None
    let ofISerializableObjectOption v: ICssInput = v |> Microsoft.FSharp.Core.Option.map U4.Case2
    let ofISerializableObject v: ICssInput = v |> U4.Case2 |> Some
    let isISerializableObject (v: ICssInput) = match v with None -> false | Some o -> match o with U4.Case2 _ -> true | _ -> false
    let asISerializableObject (v: ICssInput) = match v with None -> None | Some o -> match o with U4.Case2 o -> Some o | _ -> None
    let ofIDictionaryOption v: ICssInput = v |> Microsoft.FSharp.Core.Option.map U4.Case3
    let ofIDictionary v: ICssInput = v |> U4.Case3 |> Some
    let isIDictionary (v: ICssInput) = match v with None -> false | Some o -> match o with U4.Case3 _ -> true | _ -> false
    let asIDictionary (v: ICssInput) = match v with None -> None | Some o -> match o with U4.Case3 o -> Some o | _ -> None
    let ofBoolOption v: ICssInput = v |> Microsoft.FSharp.Core.Option.map U4.Case4
    let ofBool v: ICssInput = v |> U4.Case4 |> Some
    let isBool (v: ICssInput) = match v with None -> false | Some o -> match o with U4.Case4 _ -> true | _ -> false
    let asBool (v: ICssInput) = match v with None -> None | Some o -> match o with U4.Case4 o -> Some o | _ -> None

type [<AllowNullLiteral>] IExports =
    abstract customizable: scope: string * fields: ResizeArray<string> -> (obj -> obj option)
type IRectangle = __IRectangle.IRectangle

type [<AllowNullLiteral>] IExports =
    /// Sets the virtual parent of an element.
    /// Pass `undefined` as the `parent` to clear the virtual parent.
    abstract setVirtualParent: child: HTMLElement * parent: HTMLElement -> unit
    /// Gets the virtual parent given the child element, if it exists.
    abstract getVirtualParent: child: HTMLElement -> HTMLElement option
    /// Gets the element which is the parent of a given element.
    /// If `allowVirtuaParents` is `true`, this method prefers the virtual parent over
    /// real DOM parent when present.
    abstract getParent: child: HTMLElement * ?allowVirtualParents: bool -> HTMLElement option
    /// <summary>Gets the elements which are child elements of the given element.
    /// If `allowVirtualChildren` is `true`, this method enumerates virtual child elements
    /// after the original children.</summary>
    /// <param name="parent"></param>
    /// <param name="allowVirtualChildren"></param>
    abstract getChildren: parent: HTMLElement * ?allowVirtualChildren: bool -> ResizeArray<HTMLElement>
    /// Determines whether or not a parent element contains a given child element.
    /// If `allowVirtualParents` is true, this method may return `true` if the child
    /// has the parent in its virtual element hierarchy.
    abstract elementContains: parent: HTMLElement option * child: HTMLElement option * ?allowVirtualParents: bool -> bool
    /// Helper to set ssr mode to simulate no window object returned from getWindow helper.
    abstract setSSR: isEnabled: bool -> unit
    /// Helper to get the window object.
    abstract getWindow: ?rootElement: Element option -> Window option
    /// Helper to get the document object.
    abstract getDocument: ?rootElement: HTMLElement option -> Document option
    /// Helper to get bounding client rect, works with window.
    abstract getRect: element: U2<HTMLElement, Window> option -> IRectangle option
    /// <summary>Finds the first parent element where the matchFunction returns true</summary>
    /// <param name="element">element to start searching at</param>
    /// <param name="matchFunction">the function that determines if the element is a match</param>
    abstract findElementRecursive: element: HTMLElement option * matchFunction: (HTMLElement -> bool) -> HTMLElement option
    /// <summary>Determines if an element, or any of its ancestors, contian the given attribute</summary>
    /// <param name="element">- element to start searching at</param>
    /// <param name="attribute">- the attribute to search for</param>
    abstract elementContainsAttribute: element: HTMLElement * attribute: string -> string option

type [<AllowNullLiteral>] IExports =
    /// Gets the first focusable element.
    abstract getFirstFocusable: rootElement: HTMLElement * currentElement: HTMLElement * ?includeElementsInFocusZones: bool -> HTMLElement option
    /// Gets the last focusable element.
    abstract getLastFocusable: rootElement: HTMLElement * currentElement: HTMLElement * ?includeElementsInFocusZones: bool -> HTMLElement option
    /// Gets the last tabbable element.
    abstract getLastTabbable: rootElement: HTMLElement * currentElement: HTMLElement * ?includeElementsInFocusZones: bool -> HTMLElement option
    /// <summary>Attempts to focus the first focusable element that is a child or child's child of the rootElement.</summary>
    /// <param name="rootElement">- Element to start the search for a focusable child.</param>
    abstract focusFirstChild: rootElement: HTMLElement -> bool
    /// Traverse to find the previous element.
    abstract getPreviousElement: rootElement: HTMLElement * currentElement: HTMLElement option * ?checkNode: bool * ?suppressParentTraversal: bool * ?traverseChildren: bool * ?includeElementsInFocusZones: bool * ?allowFocusRoot: bool * ?tabbable: bool -> HTMLElement option
    /// Traverse to find the next focusable element.
    abstract getNextElement: rootElement: HTMLElement * currentElement: HTMLElement option * ?checkNode: bool * ?suppressParentTraversal: bool * ?suppressChildTraversal: bool * ?includeElementsInFocusZones: bool * ?allowFocusRoot: bool -> HTMLElement option
    /// Determines if an element is visible.
    abstract isElementVisible: element: HTMLElement option -> bool
    /// Determines if an element can receive focus.
    abstract isElementTabbable: element: HTMLElement * ?checkTabIndex: bool -> bool
    /// Determines if a given element is a focus zone.
    abstract isElementFocusZone: ?element: HTMLElement -> bool
    /// Determines if a given element is a focus sub zone.
    abstract isElementFocusSubZone: ?element: HTMLElement -> bool
    /// Determines if an element, or any of its children, contain focus.
    abstract doesElementContainFocus: element: HTMLElement -> bool
    /// <summary>Determines if an, or any of its ancestors, sepcificies that it doesn't want focus to wrap</summary>
    /// <param name="element">- element to start searching from</param>
    /// <param name="noWrapDataAttribute">- the no wrap data attribute to match (either)</param>
    abstract shouldWrapFocus: element: HTMLElement * noWrapDataAttribute: U2<string, string> -> bool
    /// <summary>Sets focus to an element asynchronously. The focus will be set at the next browser repaint,
    /// meaning it won't cause any extra recalculations. If more than one focusAsync is called during one frame,
    /// only the latest called focusAsync element will actually be focused</summary>
    /// <param name="element">The element to focus</param>
    abstract focusAsync: element: U2<HTMLElement, obj> option -> unit

type [<AllowNullLiteral>] IExports =
    /// <summary>Allows you to hoist methods, except those in an exclusion set from a source object into a destination object.</summary>
    /// <param name="destination">- The instance of the object to hoist the methods onto.</param>
    /// <param name="source">- The instance of the object where the methods are hoisted from.</param>
    /// <param name="exclusions">- (Optional) What methods to exclude from being hoisted.</param>
    abstract hoistMethods: destination: obj option * source: obj option * ?exclusions: ResizeArray<string> -> ResizeArray<string>
    /// <summary>Provides a method for convenience to unhoist hoisted methods.</summary>
    /// <param name="source">- The source object upon which methods were hoisted.</param>
    /// <param name="methodNames">- An array of method names to unhoist.</param>
    abstract unhoistMethods: source: obj option * methodNames: ResizeArray<string> -> unit

type [<AllowNullLiteral>] IExports =
    /// <summary>Allows you to hoist static functions in components.
    /// Created for the purpose of fixing broken static functions in classes
    /// that utilize decorators.</summary>
    /// <param name="source">- The object where the methods are hoisted from.</param>
    /// <param name="dest">- The object to hoist the methods onto.</param>
    abstract hoistStatics: source: 'TSource * dest: 'TDest -> 'TDest
let [<Import("obj","@uifabric/utilities/lib-es2015/initializeFocusRects")>] IsFocusVisibleClassName: obj = jsNative

type [<AllowNullLiteral>] IExports =
    /// <summary>Initializes the logic which:
    /// 
    /// 1. Subscribes keydown and mousedown events. (It will only do it once per window,
    ///     so it's safe to call this method multiple times.)
    /// 2. When the user presses directional keyboard keys, adds the 'is-focusVisible' classname
    ///     to the document body.
    /// 3. When the user clicks a mouse button, we remove the classname if it exists.
    /// 
    /// This logic allows components on the page to conditionally render focus treatments only
    /// if the global classname exists, which simplifies logic overall.</summary>
    /// <param name="window"></param>
    abstract initializeFocusRects: ?window: Window -> unit

type [<AllowNullLiteral>] IExports =
    /// Get (up to 2 characters) initials based on display name of the persona.
    abstract getInitials: displayName: string option * isRtl: bool * ?allowPhoneInitials: bool -> string

type [<AllowNullLiteral>] IExports =
    /// Returns true if the keycode is a directional keyboard key.
    abstract isDirectionalKeyCode: which: float -> bool
    /// Adds a keycode to the list of keys that, when pressed, should cause the focus outlines to be visible.
    /// This can be used to add global shortcut keys that directionally move from section to section within
    /// an app or between focus trap zones.
    abstract addDirectionalKeyCode: which: float -> unit

type [<AllowNullLiteral>] IExports =
    /// Gets the rtl state of the page (returns true if in rtl.)
    abstract getLanguage: unit -> string option
    /// Sets the rtl state of the page (by adjusting the dir attribute of the html element.)
    abstract setLanguage: language: string * ?avoidPersisting: bool -> unit
type IPoint = __IPoint.IPoint
type ISize = __ISize.ISize

type [<AllowNullLiteral>] IExports =
    /// Determines the distance between two points.
    abstract getDistanceBetweenPoints: point1: IPoint * point2: IPoint -> float
    /// <summary>Produces a proportionally-scaled version of an input content size when fit to a bounding size.
    /// Given a `contentSize` and a `boundsSize`, this function scales `contentSize` proportionally
    /// using either `contain` or `cover` fit behaviors.
    /// Use this function to pre-calculate the layout for the CSS `object-fit` and `background-fit` behaviors.
    /// With `contain`, the output size must be the largest it can be while completely within the `boundsSize`.
    /// With `cover`, the output size must be the smallest it can be while completely around the `boundsSize`.
    /// By default, there is a `maxScale` value of 1, which prevents the `contentSize` from being scaled larger.</summary>
    /// <param name="options">the options for the bounds fit operation</param>
    abstract fitContentToBounds: options: IFitContentToBoundsOptions -> ISize
    /// <summary>Calculates a number's precision based on the number of trailing
    /// zeros if the number does not have a decimal indicated by a negative
    /// precision. Otherwise, it calculates the number of digits after
    /// the decimal point indicated by a positive precision.</summary>
    /// <param name="value"></param>
    abstract calculatePrecision: value: U2<float, string> -> float
    /// <summary>Rounds a number to a certain level of precision. Accepts negative precision.</summary>
    /// <param name="value">The value that is being rounded.</param>
    /// <param name="precision">The number of decimal places to round the number to</param>
    abstract precisionRound: value: float * precision: float * ?``base``: float -> float

type [<StringEnum>] [<RequireQualifiedAccess>] FitMode =
    | Contain
    | Cover

/// Options for fitting content sizes into bounding sizes.
type [<AllowNullLiteral>] IFitContentToBoundsOptions =
    /// The size of the content to fit to the bounds.
    /// The output will be proportional to this value.
    abstract contentSize: ISize with get, set
    /// The size of the bounds.
    abstract boundsSize: ISize with get, set
    /// The fit mode to apply, either 'contain' or 'cover'.
    abstract mode: FitMode with get, set
    /// An optional maximum scale factor to apply. The default is 1.
    /// Use Infinity for an unbounded resize.
    abstract maxScale: float option with get, set

type [<AllowNullLiteral>] IExports =
    /// Test utility for providing a custom weakmap.
    abstract setMemoizeWeakMap: weakMap: obj option -> unit
    /// Memoize decorator to be used on class methods. Note that the "this" reference
    /// will be inaccessible within a memoized method, given that a cached method's this
    /// would not be instance specific.
    abstract memoize: target: obj option * key: string * descriptor: TypedPropertyDescriptor<'T> -> obj
    /// <summary>Memoizes a function; when you pass in the same parameters multiple times, it returns a cached result.
    /// Be careful when passing in objects, you need to pass in the same INSTANCE for caching to work. Otherwise
    /// it will grow the cache unnecessarily. Also avoid using default values that evaluate functions; passing in
    /// undefined for a value and relying on a default function will execute it the first time, but will not
    /// re-evaluate subsequent times which may have been unexpected.
    /// 
    /// By default, the cache will reset after 100 permutations, to avoid abuse cases where the function is
    /// unintendedly called with unique objects. Without a reset, the cache could grow infinitely, so we safeguard
    /// by resetting. To override this behavior, pass a value of 0 to the maxCacheSize parameter.</summary>
    /// <param name="cb">- The function to memoize.</param>
    /// <param name="maxCacheSize">- Max results to cache. If the cache exceeds this value, it will reset on the next call.</param>
    abstract memoizeFunction: cb: 'T * ?maxCacheSize: float -> 'T

type [<AllowNullLiteral>] IExports =
    /// Compares a to b and b to a.
    abstract shallowCompare: a: 'TA * b: 'TB -> bool
    /// <summary>Makes a resulting merge of a bunch of objects. Pass in the target object followed by 1 or more
    /// objects as arguments and they will be merged sequentially into the target. Note that this will
    /// shallow merge; it will not create new cloned values for target members.</summary>
    /// <param name="target">- Target object to merge following object arguments into.</param>
    /// <param name="args">- One or more objects that will be mixed into the target in the order they are provided.</param>
    abstract assign: target: obj option * [<ParamArray>] args: ResizeArray<obj option> -> obj option
    /// <summary>Makes a resulting merge of a bunch of objects, but allows a filter function to be passed in to filter
    /// the resulting merges. This allows for scenarios where you want to merge "everything except that one thing"
    /// or "properties that start with data-". Note that this will shallow merge; it will not create new cloned
    /// values for target members.</summary>
    /// <param name="isAllowed">- Callback to determine if the given propName is allowed in the result.</param>
    /// <param name="target">- Target object to merge following object arguments into.</param>
    /// <param name="args">- One or more objects that will be mixed into the target in the order they are provided.</param>
    abstract filteredAssign: isAllowed: (string -> bool) * target: obj option * [<ParamArray>] args: ResizeArray<obj option> -> obj option
    /// Generates a unique id in the global scope (this spans across duplicate copies of the same library.)
    abstract getId: ?prefix: string -> string
    abstract mapEnumByName: theEnum: obj option * callback: (string -> U2<string, float> -> 'T option) -> ResizeArray<'T option> option
    /// <summary>Get all values in an object dictionary</summary>
    /// <param name="obj">- The dictionary to get values for</param>
    abstract values: obj: obj option -> ResizeArray<'T>

type [<AllowNullLiteral>] IExports =
    /// <summary>Detects whether an element's content has horizontal overflow</summary>
    /// <param name="element">- Element to check for overflow</param>
    abstract hasHorizontalOverflow: element: HTMLElement -> bool
    /// <summary>Detects whether an element's content has vertical overflow</summary>
    /// <param name="element">- Element to check for overflow</param>
    abstract hasVerticalOverflow: element: HTMLElement -> bool
    /// <summary>Detects whether an element's content has overflow in any direction</summary>
    /// <param name="element">- Element to check for overflow</param>
    abstract hasOverflow: element: HTMLElement -> bool
let [<Import("stringArray","@uifabric/utilities/lib-es2015/properties")>] baseElementEvents: ResizeArray<string> = jsNative
let [<Import("stringArray","@uifabric/utilities/lib-es2015/properties")>] baseElementProperties: ResizeArray<string> = jsNative
let [<Import("stringArray","@uifabric/utilities/lib-es2015/properties")>] htmlElementProperties: ResizeArray<string> = jsNative
let [<Import("stringArray","@uifabric/utilities/lib-es2015/properties")>] anchorProperties: ResizeArray<string> = jsNative
let [<Import("stringArray","@uifabric/utilities/lib-es2015/properties")>] buttonProperties: ResizeArray<string> = jsNative
let [<Import("stringArray","@uifabric/utilities/lib-es2015/properties")>] divProperties: ResizeArray<string> = jsNative
let [<Import("stringArray","@uifabric/utilities/lib-es2015/properties")>] inputProperties: ResizeArray<string> = jsNative
let [<Import("stringArray","@uifabric/utilities/lib-es2015/properties")>] textAreaProperties: ResizeArray<string> = jsNative
let [<Import("stringArray","@uifabric/utilities/lib-es2015/properties")>] imageProperties: ResizeArray<string> = jsNative

type [<AllowNullLiteral>] IExports =
    /// <summary>Gets native supported props for an html element provided the allowance set. Use one of the property
    /// sets defined (divProperties, buttonPropertes, etc) to filter out supported properties from a given
    /// props set. Note that all data- and aria- prefixed attributes will be allowed.
    /// NOTE: getNativeProps should always be applied first when adding props to a react component. The
    /// non-native props should be applied second. This will prevent getNativeProps from overriding your custom props.
    /// For example, if props passed to getNativeProps has an onClick function and getNativeProps is added to
    /// the component after an onClick function is added, then the getNativeProps onClick will override it.</summary>
    /// <param name="props">- The unfiltered input props</param>
    abstract getNativeProps: props: GetNativePropsProps * allowedPropNames: ResizeArray<string> * ?excludedPropNames: ResizeArray<string> -> 'T

type [<AllowNullLiteral>] GetNativePropsProps =
    interface end

type [<AllowNullLiteral>] IExports =
    /// Sets the current base url used for fetching images. 
    abstract getResourceUrl: url: string -> string
    /// Gets the current base url used for fetching images. 
    abstract setBaseUrl: baseUrl: string -> unit

type [<AllowNullLiteral>] IExports =
    /// Gets the rtl state of the page (returns true if in rtl.)
    abstract getRTL: unit -> bool
    /// Sets the rtl state of the page (by adjusting the dir attribute of the html element.)
    abstract setRTL: isRTL: bool * ?persistSetting: bool -> unit
    /// Returns the given key, but flips right/left arrows if necessary.
    abstract getRTLSafeKeyCode: key: float -> float
let [<Import("obj","@uifabric/utilities/lib-es2015/scroll")>] DATA_IS_SCROLLABLE_ATTRIBUTE: obj = jsNative

type [<AllowNullLiteral>] IExports =
    /// Disables the body scrolling.
    abstract disableBodyScroll: unit -> unit
    /// Enables the body scrolling.
    abstract enableBodyScroll: unit -> unit
    /// Calculates the width of a scrollbar for the browser/os.
    abstract getScrollbarWidth: unit -> float
    /// Traverses up the DOM for the element with the data-is-scrollable=true attribute, or returns
    /// document.body.
    abstract findScrollableParent: startingElement: HTMLElement option -> HTMLElement option

type [<AllowNullLiteral>] IExports =
    /// String format method, used for scenarios where at runtime you
    /// need to evaluate a formatted string given a tokenized string. This
    /// usually only is needed in localization scenarios.
    /// 
    /// Example "I love {0} every {1}".format("CXP") will result in a Debug Exception.
    abstract format: s: string * [<ParamArray>] values: ResizeArray<obj option> -> string
type IStyleFunction = __IStyleFunction.IStyleFunction

type [<AllowNullLiteral>] IExports =
    /// The styled HOC wrapper allows you to create a functional wrapper around a given component which will resolve
    /// getStyles functional props, and mix customized props passed in using concatStyleSets. Example:
    /// 
    /// ```tsx
    /// export const Toggle = styled(
    ///    ToggleBase,
    ///    {
    ///      getStyles: props => ({ root: { background: 'red' }})
    ///    }
    /// );
    /// ```
    abstract styled: Component: U2<React.ComponentClass<'TComponentProps>, React.StatelessComponent<'TComponentProps>> * getBaseStyles: ('TStyleProps -> 'TStyles) * ?getProps: ('TComponentProps -> obj) -> ('TComponentProps -> JSX.Element)

type [<AllowNullLiteral>] IPropsWithStyles<'TStyleProps, 'TStyles> =
    abstract getStyles: IStyleFunction<'TStyleProps, 'TStyles> option with get, set
    abstract subComponents: obj option with get, set
type CheckBase = __Check_base.CheckBase
type IStyle = @uifabric_styling.IStyle
type ITheme = @uifabric_styling.ITheme
type IStyleFunction = @uifabric_utilities.IStyleFunction

type [<AllowNullLiteral>] ICheckProps =
    inherit React.Props<CheckBase>
    /// Gets the component ref.
    abstract componentRef: (ICheckProps option -> unit) option with get, set
    /// Whether or not this menu item is currently checked.
    abstract ``checked``: bool option with get, set
    /// Call to provide customized styling that will layer on top of the variant rules
    abstract getStyles: IStyleFunction<ICheckStyleProps, ICheckStyles> option with get, set
    /// Flag to always show the check icon. Not currently working.
    abstract alwaysShowCheck: bool option with get, set
    /// Theme provided by HOC.
    abstract theme: ITheme option with get, set
    /// Additional css class to apply to the Check
    abstract className: string option with get, set

type [<AllowNullLiteral>] ICheckStyleProps =
    /// Accept theme prop.
    abstract theme: ITheme with get, set
    /// Accept custom classNames
    abstract className: string option with get, set
    /// Accept custom checkBox size in pixels.
    abstract checkBoxHeight: string option with get, set
    abstract ``checked``: bool option with get, set

type [<AllowNullLiteral>] ICheckStyles =
    /// Style for the root element.
    abstract root: IStyle with get, set
    /// The 'check' icon styles.
    abstract check: IStyle with get, set
    /// The 'circle' icon styles.
    abstract circle: IStyle with get, set
type ICheckboxStyles = __Checkbox_types.ICheckboxStyles
let [<Import("","office-ui-fabric-react")>] getClassNames: (ICheckboxStyles -> bool -> bool -> bool -> string option -> ICheckboxClassNames) = jsNative

type [<AllowNullLiteral>] ICheckboxClassNames =
    abstract root: string with get, set
    abstract label: string with get, set
    abstract checkbox: string with get, set
    abstract checkmark: string with get, set
    abstract text: string with get, set
type IStyle = ______Styling.IStyle
type ITheme = ______Styling.ITheme
type IRenderFunction = ______Utilities.IRenderFunction
type IIconProps = ___Icon_Icon_types.IIconProps
type ICheckboxClassNames = __Checkbox_classNames.ICheckboxClassNames
type IKeytipProps = ______Keytip.IKeytipProps

/// Checkbox class interface.
type [<AllowNullLiteral>] ICheckbox =
    /// Gets the current checked state. 
    abstract ``checked``: bool with get, set
    /// Sets focus to the checkbox. 
    abstract focus: (unit -> unit) with get, set

/// Checkbox properties.
type [<AllowNullLiteral>] ICheckboxProps =
    inherit React.ButtonHTMLAttributes<U2<HTMLElement, HTMLInputElement>>
    /// Optional callback to access the ICheckbox interface. Use this instead of ref for accessing
    /// the public methods and properties of the component.
    abstract componentRef: (ICheckbox option -> unit) option with get, set
    /// Additional class name to provide on the root element, in addition to the ms-Checkbox class.
    abstract className: string option with get, set
    /// Checked state. Mutually exclusive to "defaultChecked". Use this if you control the checked state at a higher
    /// level and plan to pass in the correct value based on handling onChange events and re-rendering.
    abstract ``checked``: bool option with get, set
    /// Default checked state. Mutually exclusive to "checked". Use this if you want an uncontrolled component, and
    /// want the Checkbox instance to maintain its own state.
    abstract defaultChecked: bool option with get, set
    /// Label to display next to the checkbox.
    abstract label: string option with get, set
    /// Disabled state of the checkbox.
    abstract disabled: bool option with get, set
    /// Callback that is called when the checked value has changed.
    abstract onChange: (React.FormEvent<U2<HTMLElement, HTMLInputElement>> -> bool -> unit) option with get, set
    /// Optional input props that will be mixed into the input element, *before* other props are applied. This allows
    /// you to extend the input element with additional attributes, such as data-automation-id needed for automation.
    /// Note that if you provide, for example, "disabled" as well as "inputProps.disabled", the former will take
    /// precedence over the later.
    abstract inputProps: React.ButtonHTMLAttributes<U2<HTMLElement, HTMLButtonElement>> option with get, set
    /// Allows you to set the checkbox to be at the before (start) or after (end) the label.
    abstract boxSide: U2<string, string> option with get, set
    /// Theme provided by HOC.
    abstract theme: ITheme option with get, set
    /// Accessible label for the checkbox.
    abstract ariaLabel: string option with get, set
    /// ID for element that contains label information for the checkbox.
    abstract ariaLabelledBy: string option with get, set
    /// ID for element that provides extended information for the checkbox.
    abstract ariaDescribedBy: string option with get, set
    /// The position in the parent set (if in a set) for aria-posinset.
    abstract ariaPositionInSet: float option with get, set
    /// The total size of the parent set (if in a set) for aria-setsize.
    abstract ariaSetSize: float option with get, set
    /// Custom styles for this component
    abstract styles: ICheckboxStyles option with get, set
    /// Custom function for providing the classNames for the checkbox. Can be used to provide
    /// all styles for the component instead of applying them on top of the default styles.
    abstract getClassNames: (ITheme -> bool -> bool -> bool -> string -> ICheckboxClassNames) option with get, set
    /// Custom render function for the label.
    abstract onRenderLabel: IRenderFunction<ICheckboxProps> option with get, set
    /// Custom icon props for the check mark rendered by the checkbox
    abstract checkmarkIconProps: IIconProps option with get, set
    /// Optional keytip for this checkbox
    abstract keytipProps: IKeytipProps option with get, set

type [<AllowNullLiteral>] ICheckboxStyles =
    /// Style for the root element (a button) of the checkbox component in the default enabled/unchecked state.
    abstract root: IStyle option with get, set
    /// Style for the label part (contains the customized checkbox + text) when enabled.
    abstract label: IStyle option with get, set
    /// Style for the label when reversed
    abstract labelReversed: IStyle option with get, set
    /// Style override for the label part when disabled.
    abstract labelDisabled: IStyle option with get, set
    /// Style for checkbox in its default unchecked/enabled state.
    abstract checkbox: IStyle option with get, set
    /// Style override for checkbox when enabled/unchecked/hovered.
    abstract checkboxHovered: IStyle option with get, set
    /// Style override for checkbox when enabled/unchecked/focused.
    abstract checkboxFocused: IStyle option with get, set
    /// Style override for checkbox when enabled/checked.
    abstract checkboxChecked: IStyle option with get, set
    /// Style override for checkbox when enabled/checked/hovered.
    abstract checkboxCheckedHovered: IStyle option with get, set
    /// Style override for checkbox when enabled/checked/focused.
    abstract checkboxCheckedFocused: IStyle option with get, set
    /// Style override for checkbox when disabled/unchecked.
    abstract checkboxDisabled: IStyle option with get, set
    /// Style override for checkbox when disabled/checked.
    abstract checkboxCheckedDisabled: IStyle option with get, set
    /// Style for the checkmark in the default enabled/unchecked state.
    abstract checkmark: IStyle option with get, set
    /// Style override for the checkmark when enabled/checked.
    abstract checkmarkChecked: IStyle option with get, set
    /// Style override for checkmark when disabled/unchecked.
    abstract checkmarkDisabled: IStyle option with get, set
    /// Style override for checkmark when disabled/checked.
    abstract checkmarkCheckedDisabled: IStyle option with get, set
    /// Style for text appearing with the checkbox in its default enabled state.
    abstract text: IStyle option with get, set
    /// Style override for text appearing with the checkbox when enabled/hovered.
    abstract textHovered: IStyle option with get, set
    /// Style override for text appearing with the checkbox when enabled/focused.
    abstract textFocused: IStyle option with get, set
    /// Style override for text appearing with the checkbox when disabled.
    abstract textDisabled: IStyle option with get, set
type BaseComponent = ______Utilities.BaseComponent
type ICheckbox = __Checkbox_types.ICheckbox
type ICheckboxProps = __Checkbox_types.ICheckboxProps

type [<AllowNullLiteral>] IExports =
    abstract Checkbox: CheckboxStatic

type [<AllowNullLiteral>] ICheckboxState =
    /// Is true when Uncontrolled control is checked. 
    abstract isChecked: bool option with get, set

type [<AllowNullLiteral>] Checkbox =
    inherit BaseComponent<ICheckboxProps, ICheckboxState>
    inherit ICheckbox
    abstract defaultProps: ICheckboxProps with get, set
    abstract _checkBox: obj with get, set
    abstract _id: obj with get, set
    abstract _classNames: obj with get, set
    abstract componentWillReceiveProps: newProps: ICheckboxProps -> unit
    /// Render the Checkbox based on passed props
    abstract render: unit -> JSX.Element
    abstract ``checked``: bool
    abstract focus: unit -> unit
    abstract _onFocus: obj with get, set
    abstract _onBlur: obj with get, set
    abstract _onClick: obj with get, set
    abstract _onRenderLabel: obj with get, set

type [<AllowNullLiteral>] CheckboxStatic =
    /// <summary>Initialize a new instance of the TopHeaderV2</summary>
    /// <param name="props">Props for the component</param>
    /// <param name="context">Context or initial state for the base component.</param>
    [<Emit "new $0($1...)">] abstract Create: props: ICheckboxProps * ?context: obj option -> Checkbox
type IIconProps = ______Icon.IIconProps
type IRenderFunction = ______Utilities.IRenderFunction

type [<AllowNullLiteral>] IChoiceGroup =
    interface end

type [<AllowNullLiteral>] IChoiceGroupProps =
    inherit React.InputHTMLAttributes<U2<HTMLElement, HTMLInputElement>>
    /// Optional callback to access the IChoiceGroup interface. Use this instead of ref for accessing
    /// the public methods and properties of the component.
    abstract componentRef: (IChoiceGroup option -> unit) option with get, set
    /// The options for the choice group.
    abstract options: ResizeArray<IChoiceGroupOption> option with get, set
    /// The key of the option that will be initially checked.
    abstract defaultSelectedKey: U2<string, float> option with get, set
    /// The key of the selected option. If you provide this, you must maintain selection
    /// state by observing onChange events and passing a new value in when changed.
    abstract selectedKey: U2<string, float> option with get, set
    /// A callback for receiving a notification when the choice has been changed.
    abstract onChange: (React.FormEvent<U2<HTMLElement, HTMLInputElement>> -> IChoiceGroupOption -> unit) option with get, set
    /// Descriptive label for the choice group.
    abstract label: string option with get, set
    /// Deprecated and will be removed by 07/17/2017 Use 'onChange' instead.
    abstract onChanged: (IChoiceGroupOption -> React.FormEvent<U2<HTMLElement, HTMLInputElement>> -> unit) option with get, set

type [<AllowNullLiteral>] IChoiceGroupOption =
    inherit React.HTMLAttributes<U2<HTMLElement, HTMLInputElement>>
    /// A required key to uniquely identify the option.
    abstract key: string with get, set
    /// The text string for the option.
    abstract text: string with get, set
    /// Optional override of option render
    abstract onRenderField: IRenderFunction<IChoiceGroupOption> option with get, set
    /// Optional override of option render
    abstract onRenderLabel: (IChoiceGroupOption -> JSX.Element) option with get, set
    /// The Icon component props for choice field
    abstract iconProps: IIconProps option with get, set
    /// The src of image for choice field.
    abstract imageSrc: string option with get, set
    /// The alt of image for choice field. Defaults to '' if not set.
    abstract imageAlt: string option with get, set
    /// The src of image for choice field which is selected.
    abstract selectedImageSrc: string option with get, set
    /// The width and height of the image in px for choice field.
    abstract imageSize: obj option with get, set
    /// Whether or not the option is disabled.
    abstract disabled: bool option with get, set
    /// This value is maintained by the component and is accessible during onRenderField
    abstract ``checked``: bool option with get, set
    /// This value is maintained by the component and is accessible during onRenderField
    abstract id: string option with get, set
    /// This value is maintained by the component and is accessible during onRenderField
    abstract labelId: string option with get, set
type IChoiceGroupProps = __ChoiceGroup_types.IChoiceGroupProps
type BaseComponent = ______Utilities.BaseComponent

type [<AllowNullLiteral>] IExports =
    abstract ChoiceGroup: ChoiceGroupStatic

type [<AllowNullLiteral>] IChoiceGroupState =
    abstract keyChecked: U2<string, float> with get, set
    /// Is true when the control has focus. 
    abstract keyFocused: U2<string, float> option with get, set

type [<AllowNullLiteral>] ChoiceGroup =
    inherit BaseComponent<IChoiceGroupProps, IChoiceGroupState>
    abstract defaultProps: IChoiceGroupProps with get, set
    abstract _id: obj with get, set
    abstract _labelId: obj with get, set
    abstract _inputElement: obj with get, set
    abstract componentWillReceiveProps: newProps: IChoiceGroupProps -> unit
    abstract render: unit -> JSX.Element
    abstract focus: unit -> unit
    abstract _onFocus: option: obj * ev: obj -> unit
    abstract _onBlur: option: obj * ev: obj -> unit
    abstract _onRenderField: option: obj -> unit
    abstract _onRenderLabel: option: obj -> unit
    abstract _onChange: option: obj * evt: obj -> unit
    /// If all the isChecked property of options are falsy values, return undefined;
    /// Else return the key of the first option with the truthy isChecked property.
    abstract _getKeyChecked: props: obj -> unit

type [<AllowNullLiteral>] ChoiceGroupStatic =
    [<Emit "new $0($1...)">] abstract Create: props: IChoiceGroupProps -> ChoiceGroup

type [<AllowNullLiteral>] IColorPickerProps =
    /// Gets the component ref.
    abstract componentRef: (unit -> unit) option with get, set
    /// The CSS-compatible string to describe the initial color
    abstract color: string with get, set
    /// Callback issued when the user changes the color
    abstract onColorChanged: (string -> unit) option with get, set
    /// The setting of whether to hide the alpha control slider.
    abstract alphaSliderHidden: bool option with get, set
    /// Label for the hex textfield.
    abstract hexLabel: string option with get, set
    /// Label for the red textfield
    abstract redLabel: string option with get, set
    /// Label for the green textfield
    abstract greenLabel: string option with get, set
    /// Label for the blue textfield
    abstract blueLabel: string option with get, set
    /// Label for the alpha textfield
    abstract alphaLabel: string option with get, set
let [<Import("obj","office-ui-fabric-react")>] MAX_COLOR_SATURATION: obj = jsNative
let [<Import("obj","office-ui-fabric-react")>] MAX_COLOR_HUE: obj = jsNative
let [<Import("obj","office-ui-fabric-react")>] MAX_COLOR_VALUE: obj = jsNative
let [<Import("obj","office-ui-fabric-react")>] MAX_COLOR_RGBA: obj = jsNative

type [<AllowNullLiteral>] IExports =
    abstract cssColor: color: string -> IRGB option
    abstract rgb2hex: r: float * g: float * b: float -> string
    abstract hsv2hex: h: float * s: float * v: float -> string
    abstract rgb2hsv: r: float * g: float * b: float -> IHSV
    abstract hsl2hsv: h: float * s: float * l: float -> IHSV
    abstract hsv2hsl: h: float * s: float * v: float -> obj
    abstract hsl2rgb: h: float * s: float * l: float -> IRGB
    abstract hsv2rgb: h: float * s: float * v: float -> IRGB
    abstract getColorFromString: inputColor: string -> IColor option
    abstract getColorFromRGBA: rgba: GetColorFromRGBARgba -> IColor
    abstract getFullColorString: color: IColor -> string
    abstract updateSV: color: IColor * s: float * v: float -> IColor
    abstract updateH: color: IColor * h: float -> IColor
    abstract updateA: color: IColor * a: float -> IColor

type [<AllowNullLiteral>] GetColorFromRGBARgba =
    abstract r: float with get, set
    abstract g: float with get, set
    abstract b: float with get, set
    abstract a: float with get, set

type [<AllowNullLiteral>] IRGB =
    abstract r: float with get, set
    abstract g: float with get, set
    abstract b: float with get, set
    abstract a: float option with get, set

type [<AllowNullLiteral>] IHSV =
    abstract h: float with get, set
    abstract s: float with get, set
    abstract v: float with get, set

type [<AllowNullLiteral>] IHSL =
    abstract h: float with get, set
    abstract s: float with get, set
    abstract l: float with get, set

type [<AllowNullLiteral>] IColor =
    inherit IRGB
    inherit IHSV
    abstract hex: string with get, set
    abstract str: string with get, set
type BaseComponent = ______Utilities.BaseComponent
type IColorPickerProps = __ColorPicker_types.IColorPickerProps
type IColor = ______utilities_color_colors.IColor

type [<AllowNullLiteral>] IExports =
    abstract ColorPicker: ColorPickerStatic

type [<AllowNullLiteral>] IColorPickerState =
    abstract isOpen: bool with get, set
    abstract color: IColor with get, set

type [<AllowNullLiteral>] ColorPicker =
    inherit BaseComponent<IColorPickerProps, IColorPickerState>
    abstract defaultProps: obj with get, set
    abstract hexText: obj with get, set
    abstract rText: obj with get, set
    abstract gText: obj with get, set
    abstract bText: obj with get, set
    abstract aText: obj with get, set
    abstract componentWillReceiveProps: newProps: IColorPickerProps -> unit
    abstract render: unit -> JSX.Element
    abstract _onSVChanged: obj with get, set
    abstract _onHChanged: obj with get, set
    abstract _onAChanged: obj with get, set
    abstract _onHexChanged: obj with get, set
    abstract _onRGBAChanged: obj with get, set
    abstract _updateColor: ?newColor: obj -> unit

type [<AllowNullLiteral>] ColorPickerStatic =
    [<Emit "new $0($1...)">] abstract Create: props: IColorPickerProps -> ColorPicker

type [<AllowNullLiteral>] ISelectableOption =
    /// Arbitrary string associated with this option.
    abstract key: U2<string, float> with get, set
    /// Text to render for this option
    abstract text: string with get, set
    /// Text to render for this option
    abstract itemType: SelectableOptionMenuItemType option with get, set
    /// Index for this option
    abstract index: float option with get, set
    /// The aria label for the dropdown option. If not present, the `text` will be used.
    abstract ariaLabel: string option with get, set
    /// If option is selected. 
    abstract selected: bool option with get, set
    /// Whether the option is disabled
    abstract disabled: bool option with get, set

type [<RequireQualifiedAccess>] SelectableOptionMenuItemType =
    | Normal = 0
    | Divider = 1
    | Header = 2
type ILayerProps = __Layer_types.ILayerProps
type BaseComponent = ______Utilities.BaseComponent

type [<AllowNullLiteral>] IExports =
    abstract LayerBase: LayerBaseStatic

type [<AllowNullLiteral>] LayerBase =
    inherit BaseComponent<ILayerProps, obj>
    abstract defaultProps: ILayerProps with get, set
    abstract _rootElement: obj with get, set
    abstract _host: obj with get, set
    abstract _layerElement: obj with get, set
    abstract _hasMounted: obj with get, set
    abstract componentDidMount: unit -> unit
    abstract componentWillUnmount: unit -> unit
    abstract componentDidUpdate: unit -> unit
    abstract render: unit -> JSX.Element
    abstract _removeLayerElement: unit -> unit
    abstract _getHost: unit -> unit

type [<AllowNullLiteral>] LayerBaseStatic =
    /// Used for notifying applicable Layers that a host is available/unavailable and to re-evaluate Layers that
    /// care about the specific host.
    abstract notifyHostChanged: id: string -> unit
    /// Sets the default target selector to use when determining the host in which
    /// Layered content will be injected into. If not provided, an element will be
    /// created at the end of the document body.
    /// 
    /// Passing in a falsey value will clear the default target and reset back to
    /// using a created element at the end of document body.
    abstract setDefaultTarget: ?selector: string -> unit
    [<Emit "new $0($1...)">] abstract Create: props: ILayerProps -> LayerBase
type LayerBase = __Layer_base.LayerBase
type IStyle = ______Styling.IStyle
type ITheme = ______Styling.ITheme
type IStyleFunction = ______Utilities.IStyleFunction

type [<AllowNullLiteral>] ILayer =
    interface end

type [<AllowNullLiteral>] ILayerProps =
    inherit React.HTMLAttributes<U2<HTMLDivElement, LayerBase>>
    /// Optional callback to access the ILayer interface. Use this instead of ref for accessing
    /// the public methods and properties of the component.
    abstract componentRef: (ILayer option -> unit) option with get, set
    /// Call to provide customized styling that will layer on top of the variant rules
    abstract getStyles: IStyleFunction<ILayerStyleProps, ILayerStyles> option with get, set
    /// Theme provided by HOC.
    abstract theme: ITheme option with get, set
    /// Additional css class to apply to the Layer
    abstract className: string option with get, set
    /// Callback for when the layer is mounted. 
    abstract onLayerMounted: (unit -> unit) option with get, set
    /// Callback for when the layer is mounted.
    abstract onLayerDidMount: (unit -> unit) option with get, set
    /// Callback for when the layer is unmounted.
    abstract onLayerWillUnmount: (unit -> unit) option with get, set
    /// The optional id property provided on a LayerHost that this Layer should render within. The LayerHost does
    /// not need to be immediately available but once has been rendered, and if missing, we'll avoid trying
    /// to render the Layer content until the host is available. If an id is not provided, we will render the Layer
    /// content in a fixed position element rendered at the end of the document.
    abstract hostId: string option with get, set

type [<AllowNullLiteral>] ILayerStyleProps =
    /// Accept theme prop.
    abstract theme: ITheme with get, set
    /// Accept custom classNames
    abstract className: string option with get, set
    /// Check if Host
    abstract isNotHost: bool option with get, set

type [<AllowNullLiteral>] ILayerStyles =
    /// Style for the root element when fixed.
    abstract root: IStyle option with get, set
    /// Style for the Fabric component.
    abstract content: IStyle option with get, set

type [<AllowNullLiteral>] ILayerHost =
    interface end

type [<AllowNullLiteral>] ILayerHostProps =
    inherit React.HTMLAttributes<HTMLElement>
    /// Optional callback to access the ILayerHost interface. Use this instead of ref for accessing
    /// the public methods and properties of the component.
    abstract componentRef: (ILayerHost option -> unit) option with get, set
    /// Defines the id for the layer host that Layers can target (using the hostId property.)
    abstract id: string option with get, set
type BaseComponent = ______Utilities.BaseComponent
type ILayerHostProps = __LayerHost_types.ILayerHostProps

type [<AllowNullLiteral>] IExports =
    abstract LayerHost: LayerHostStatic

type [<AllowNullLiteral>] LayerHost =
    inherit BaseComponent<ILayerHostProps, obj>
    abstract shouldComponentUpdate: unit -> bool
    abstract componentDidMount: unit -> unit
    abstract componentWillUnmount: unit -> unit
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] LayerHostStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> LayerHost

type [<AllowNullLiteral>] IFocusTrapZone =
    /// Sets focus on the first focusable, or configured, child in focus trap zone
    abstract focus: (unit -> unit) with get, set

type [<AllowNullLiteral>] IFocusTrapZoneProps =
    inherit React.HTMLAttributes<HTMLDivElement>
    /// Optional callback to access the IFocusTrapZone interface. Use this instead of ref for accessing
    /// the public methods and properties of the component.
    abstract componentRef: (IFocusTrapZone option -> unit) option with get, set
    /// Sets the HTMLElement to focus on when exiting the FocusTrapZone.
    abstract elementToFocusOnDismiss: HTMLElement option with get, set
    /// Sets the aria-labelledby attribute.
    abstract ariaLabelledBy: string option with get, set
    /// Indicates if this Trap Zone will allow clicks outside the FocusTrapZone
    abstract isClickableOutsideFocusTrap: bool option with get, set
    /// Indicates if this Trap Zone will ignore keeping track of HTMLElement that activated the Zone.
    abstract ignoreExternalFocusing: bool option with get, set
    /// Indicates whether focus trap zone should force focus inside the focus trap zone
    abstract forceFocusInsideTrap: bool option with get, set
    /// Indicates the selector for first focusable item
    abstract firstFocusableSelector: U2<string, (unit -> string)> option with get, set
    /// Do not put focus onto first element when render focus trap zone
    abstract disableFirstFocus: bool option with get, set
    /// Optional, onKeyDown event handler
    abstract onKeyDown: (React.KeyboardEvent<HTMLElement> -> unit) option with get, set
type BaseComponent = ______Utilities.BaseComponent
type IFocusTrapZone = __FocusTrapZone_types.IFocusTrapZone
type IFocusTrapZoneProps = __FocusTrapZone_types.IFocusTrapZoneProps

type [<AllowNullLiteral>] IExports =
    abstract FocusTrapZone: FocusTrapZoneStatic

type [<AllowNullLiteral>] FocusTrapZone =
    inherit BaseComponent<IFocusTrapZoneProps, obj>
    inherit IFocusTrapZone
    abstract _focusStack: obj with get, set
    abstract _clickStack: obj with get, set
    abstract _root: obj with get, set
    abstract _previouslyFocusedElement: obj with get, set
    abstract _isInFocusStack: obj with get, set
    abstract _isInClickStack: obj with get, set
    abstract componentWillMount: unit -> unit
    abstract componentDidMount: unit -> unit
    abstract componentWillReceiveProps: nextProps: IFocusTrapZoneProps -> unit
    abstract componentWillUnmount: unit -> unit
    abstract render: unit -> JSX.Element
    /// Need to expose this method in case of popups since focus needs to be set when popup is opened
    abstract focus: unit -> unit
    abstract _onKeyboardHandler: obj with get, set
    abstract _forceFocusInTrap: ev: obj -> unit
    abstract _forceClickInTrap: ev: obj -> unit

type [<AllowNullLiteral>] FocusTrapZoneStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> FocusTrapZone
type Panel = __Panel.Panel
type IRenderFunction = ______Utilities.IRenderFunction
type ILayerProps = ______Layer.ILayerProps
type IFocusTrapZoneProps = ______FocusTrapZone.IFocusTrapZoneProps

type [<AllowNullLiteral>] IPanel =
    /// Forces the panel to open.
    abstract ``open``: (unit -> unit) with get, set
    /// Forces the panel to dismiss.
    abstract dismiss: (unit -> unit) with get, set

type [<AllowNullLiteral>] IPanelProps =
    inherit React.Props<Panel>
    /// Optional callback to access the IPanel interface. Use this instead of ref for accessing
    /// the public methods and properties of the component.
    abstract componentRef: (IPanel option -> unit) option with get, set
    /// Whether the panel is displayed.
    abstract isOpen: bool option with get, set
    /// Has the close button visible.
    abstract hasCloseButton: bool option with get, set
    /// Whether the panel can be light dismissed.
    abstract isLightDismiss: bool option with get, set
    /// Whether the panel is hidden on dismiss, instead of destroyed in the DOM.
    abstract isHiddenOnDismiss: bool option with get, set
    /// Whether the panel uses a modal overlay or not
    abstract isBlocking: bool option with get, set
    /// Determines if content should stretch to fill available space putting footer at the bottom of the page
    abstract isFooterAtBottom: bool option with get, set
    /// Header text for the Panel.
    abstract headerText: string option with get, set
    /// A callback function for when the panel is closed, before the animation completes.
    abstract onDismiss: (unit -> unit) option with get, set
    /// A callback function which is called after the Panel is dismissed and the animation is complete.
    abstract onDismissed: (unit -> unit) option with get, set
    /// Additional styling options.
    abstract className: string option with get, set
    /// Type of the panel.
    abstract ``type``: PanelType option with get, set
    /// Custom panel width, used only when type is set to PanelType.custom.
    abstract customWidth: string option with get, set
    /// Aria label on close button
    abstract closeButtonAriaLabel: string option with get, set
    /// Optional parameter to provider the class name for header text
    abstract headerClassName: string option with get, set
    /// Sets the HTMLElement to focus on when exiting the FocusTrapZone.
    abstract elementToFocusOnDismiss: HTMLElement option with get, set
    /// Indicates if this Panel will ignore keeping track of HTMLElement that activated the Zone.
    /// Deprecated, use focusTrapZoneProps.
    abstract ignoreExternalFocusing: bool option with get, set
    /// Indicates whether Panel should force focus inside the focus trap zone
    /// Deprecated, use focusTrapZoneProps.
    abstract forceFocusInsideTrap: bool option with get, set
    /// Indicates the selector for first focusable item.
    /// Deprecated, use focusTrapZoneProps.
    abstract firstFocusableSelector: string option with get, set
    /// Optional props to pass to the FocusTrapZone component to manage focus in the panel.
    abstract focusTrapZoneProps: IFocusTrapZoneProps option with get, set
    /// Optional props to pass to the Layer component hosting the panel.
    abstract layerProps: ILayerProps option with get, set
    /// Optional custom function to handle clicks outside the panel in lightdismiss mode
    abstract onLightDismissClick: (unit -> unit) option with get, set
    /// Optional custom function to handle clicks outside this component
    abstract onOuterClick: (unit -> unit) option with get, set
    /// Optional custom renderer navigation region. Replaces current close button.
    abstract onRenderNavigation: IRenderFunction<IPanelProps> option with get, set
    /// Optional custom renderer for header region. Replaces current title
    abstract onRenderHeader: IPanelHeaderRenderer option with get, set
    /// Optional custom renderer for body region. Replaces any children passed into the component.
    abstract onRenderBody: IRenderFunction<IPanelProps> option with get, set
    /// Optional custom renderer for footer region. Replaces sticky footer.
    abstract onRenderFooter: IRenderFunction<IPanelProps> option with get, set
    /// Custom renderer for content in the sticky footer
    abstract onRenderFooterContent: IRenderFunction<IPanelProps> option with get, set
    /// Deprecated property. Serves no function.
    abstract componentId: string option with get, set

/// Renderer function which takes an additional parameter, the ID to use for the element containing
/// the panel's title. This allows the `aria-labelledby` for the panel popup to work correctly.
/// Note that if `headerTextId` is provided, it **must** be used on an element, or screen readers
/// will be confused by the reference to a nonexistent ID.
type [<AllowNullLiteral>] IPanelHeaderRenderer =
    inherit IRenderFunction<IPanelProps>
    /// <param name="props">Props given to the panel</param>
    /// <param name="defaultRender">Default header renderer. If using this renderer in code that does not
    /// assign `headerTextId` to an element elsewhere, it **must** be passed to this function.</param>
    /// <param name="headerTextId">If provided, this **must** be used as the ID of an element containing the
    /// panel's title, because the panel popup uses this ID as its aria-labelledby.</param>
    [<Emit "$0($1...)">] abstract Invoke: ?props: IPanelProps * ?defaultRender: IPanelHeaderRenderer * ?headerTextId: string option -> JSX.Element option

type [<RequireQualifiedAccess>] PanelType =
    | SmallFluid = 0
    | SmallFixedFar = 1
    | SmallFixedNear = 2
    | Medium = 3
    | Large = 4
    | LargeFixed = 5
    | ExtraLarge = 6
    | Custom = 7
type BaseComponent = ______Utilities.BaseComponent
type IPanel = __Panel_types.IPanel
type IPanelProps = __Panel_types.IPanelProps

type [<AllowNullLiteral>] IExports =
    abstract Panel: PanelStatic

type [<AllowNullLiteral>] IPanelState =
    abstract isFooterSticky: bool option with get, set
    abstract isOpen: bool option with get, set
    abstract isAnimating: bool option with get, set
    abstract id: string option with get, set

type [<AllowNullLiteral>] Panel =
    inherit BaseComponent<IPanelProps, IPanelState>
    inherit IPanel
    abstract defaultProps: IPanelProps with get, set
    abstract _panel: obj with get, set
    abstract _content: obj with get, set
    abstract componentDidMount: unit -> unit
    abstract componentWillReceiveProps: newProps: IPanelProps -> unit
    abstract render: unit -> JSX.Element option
    abstract ``open``: unit -> unit
    abstract dismiss: (unit -> unit) with get, set
    abstract _onRenderNavigation: obj with get, set
    abstract _onRenderHeader: obj with get, set
    abstract _onRenderBody: obj with get, set
    abstract _onRenderFooter: obj with get, set
    abstract _updateFooterPosition: unit -> unit
    abstract _dismissOnOuterClick: ev: obj -> unit
    abstract _onPanelClick: obj with get, set
    abstract _onTransitionComplete: obj with get, set

type [<AllowNullLiteral>] PanelStatic =
    [<Emit "new $0($1...)">] abstract Create: props: IPanelProps -> Panel
type IRenderFunction = ______Utilities.IRenderFunction
type ICalloutProps = ______Callout.ICalloutProps
type IPanelProps = ______Panel.IPanelProps
type ISelectableOption = ______utilities_selectableOption_SelectableOption_types.ISelectableOption

type [<AllowNullLiteral>] ISelectableDroppableTextProps<'T> =
    inherit React.HTMLAttributes<'T>
    /// Optional callback to access the ISelectableDroppableText interface. Use this instead of ref for accessing
    /// the public methods and properties of the component.
    abstract componentRef: ('T option -> unit) option with get, set
    /// Descriptive label for the ISelectableDroppableText
    abstract label: string option with get, set
    /// Aria Label for the ISelectableDroppableText for screen reader users.
    abstract ariaLabel: string option with get, set
    /// Id of the ISelectableDroppableText
    abstract id: string option with get, set
    /// If provided, additional class name to provide on the root element.
    abstract className: string option with get, set
    /// The key(s) that will be initially used to set a selected item.
    abstract defaultSelectedKey: U4<string, float, ResizeArray<string>, ResizeArray<float>> option with get, set
    /// The key(s) of the selected item. If you provide this, you must maintain selection
    /// state by observing onChange events and passing a new value in when changed.
    abstract selectedKey: U4<string, float, ResizeArray<string>, ResizeArray<float>> option with get, set
    /// Collection of options for this ISelectableDroppableText
    abstract options: obj option with get, set
    /// Callback issues when the selected option changes
    abstract onChanged: (ISelectableOption -> float -> unit) option with get, set
    /// Optional custom renderer for the ISelectableDroppableText container
    abstract onRenderContainer: IRenderFunction<ISelectableDroppableTextProps<'T>> option with get, set
    /// Optional custom renderer for the ISelectableDroppableText list
    abstract onRenderList: IRenderFunction<ISelectableDroppableTextProps<'T>> option with get, set
    /// Optional custom renderer for the ISelectableDroppableText options
    abstract onRenderItem: IRenderFunction<ISelectableOption> option with get, set
    /// Optional custom renderer for the ISelectableDroppableText option content
    abstract onRenderOption: IRenderFunction<ISelectableOption> option with get, set
    /// Whether or not the ISelectableDroppableText is disabled.
    abstract disabled: bool option with get, set
    /// Whether or not the ISelectableDroppableText is required.
    abstract required: bool option with get, set
    /// Custom properties for ISelectableDroppableText's Callout used to render options.
    abstract calloutProps: ICalloutProps option with get, set
    /// Custom properties for ISelectableDroppableText's Panel used to render options on small devices.
    abstract panelProps: IPanelProps option with get, set
    /// Descriptive label for the ISelectableDroppableText Error Message
    abstract errorMessage: string option with get, set
type IComboBoxStyles = __ComboBox_types.IComboBoxStyles
type IComboBoxOptionStyles = __ComboBox_types.IComboBoxOptionStyles
let [<Import("","office-ui-fabric-react")>] getClassNames: (obj -> string -> bool -> bool -> bool -> bool -> bool -> bool -> IComboBoxClassNames) = jsNative
let [<Import("","office-ui-fabric-react")>] getComboBoxOptionClassNames: (obj -> IComboBoxOptionClassNames) = jsNative

type [<AllowNullLiteral>] IComboBoxClassNames =
    abstract container: string with get, set
    abstract label: string with get, set
    abstract root: string with get, set
    abstract input: string with get, set
    abstract errorMessage: string with get, set
    abstract callout: string with get, set
    abstract optionsContainer: string with get, set
    abstract header: string with get, set
    abstract divider: string with get, set
    abstract optionsContainerWrapper: string with get, set

type [<AllowNullLiteral>] IComboBoxOptionClassNames =
    abstract optionText: string with get, set
    abstract root: string with get, set
type IIconProps = ______Icon.IIconProps
type ISelectableOption = ______utilities_selectableOption_SelectableOption_types.ISelectableOption
type ISelectableDroppableTextProps = ______utilities_selectableOption_SelectableDroppableText_types.ISelectableDroppableTextProps
type IStyle = ______Styling.IStyle
type ITheme = ______Styling.ITheme
type IButtonStyles = ______Button.IButtonStyles
type IRenderFunction = ______Utilities.IRenderFunction
type IComboBoxClassNames = __ComboBox_classNames.IComboBoxClassNames
type IKeytipProps = ______Keytip.IKeytipProps

type [<AllowNullLiteral>] IComboBox =
    /// If there is a menu open this will dismiss the menu
    abstract dismissMenu: (unit -> unit) with get, set
    /// Sets focus to the input in the comboBox
    abstract focus: ?shouldOpenOnFocus: bool -> bool

type [<AllowNullLiteral>] IComboBoxOption =
    inherit ISelectableOption
    /// Specific styles for each comboBox option. If you intend to give
    /// common styles to all comboBox option please use
    /// the prop comboBoxOptionStyles
    abstract styles: obj option with get, set
    /// In scenarios where embedded data is used at the text prop, we will use the ariaLabel prop
    /// to set the aria-label and preview text. Default to false
    abstract useAriaLabelAsText: bool option with get, set

type [<AllowNullLiteral>] IComboBoxProps =
    inherit ISelectableDroppableTextProps<IComboBox>
    /// Optional callback to access the IComboBox interface. Use this instead of ref for accessing
    /// the public methods and properties of the component.
    abstract componentRef: (IComboBox option -> unit) option with get, set
    /// Collection of options for this ComboBox
    abstract options: ResizeArray<IComboBoxOption> with get, set
    /// Callback issues when either:
    /// 1) the selected option changes
    /// 2) a manually edited value is submitted. In this case there may not be a matched option if allowFreeform is also true
    ///     (and hence only value would be true, the other parameter would be null in this case)
    abstract onChanged: (IComboBoxOption -> float -> string -> obj option -> unit) option with get, set
    /// Callback issued when the user changes the pending value in ComboBox
    abstract onPendingValueChanged: (IComboBoxOption -> float -> string -> unit) option with get, set
    /// Function that gets invoked when the ComboBox menu is launched
    abstract onMenuOpen: (unit -> unit) option with get, set
    /// Function that gets invoked when the ComboBox menu is dismissed
    abstract onMenuDismissed: (unit -> unit) option with get, set
    /// Callback issued when the options should be resolved, if they have been updated or
    /// if they need to be passed in the first time
    abstract onResolveOptions: (ResizeArray<IComboBoxOption> -> U2<ResizeArray<IComboBoxOption>, PromiseLike<ResizeArray<IComboBoxOption>>>) option with get, set
    /// Callback issued when the ComboBox requests the list to scroll to a specific element
    abstract onScrollToItem: (float -> unit) option with get, set
    /// Whether the ComboBox is free form, meaning that the user input is not bound to provided options. Defaults to false.
    abstract allowFreeform: bool option with get, set
    /// Whether the ComboBox auto completes. As the user is inputing text, it will be suggested potential matches from the list of options. If
    /// the combo box is expanded, this will also scroll to the suggested option, and give it a selected style.
    abstract autoComplete: U2<string, string> option with get, set
    /// Value to show in the input, does not have to map to a combobox option
    abstract text: string option with get, set
    /// The IconProps to use for the button aspect of the combobox
    abstract buttonIconProps: IIconProps option with get, set
    /// Theme provided by HOC.
    abstract theme: ITheme option with get, set
    /// Custom styles for this component
    abstract styles: obj option with get, set
    /// Custom function for providing the classNames for the ComboBox. Can be used to provide
    /// all styles for the component instead of applying them on top of the default styles.
    abstract getClassNames: (ITheme -> bool -> bool -> bool -> bool -> bool -> bool -> string -> IComboBoxClassNames) option with get, set
    /// Styles for the caret down button.
    abstract caretDownButtonStyles: obj option with get, set
    /// Default styles that should be applied to ComboBox options,
    /// in case an option does not come with user-defined custom styles
    abstract comboBoxOptionStyles: obj option with get, set
    /// When options are scrollable the selected option is positioned at the top of the callout when it is opened (unless it has reached the end of the scrollbar).
    abstract scrollSelectedToTop: bool option with get, set
    /// Add additional content below the callout list.
    abstract onRenderLowerContent: IRenderFunction<IComboBoxProps> option with get, set
    /// Custom width for dropdown (unless useComboBoxAsMenuWidth is undefined or false)
    abstract dropdownWidth: float option with get, set
    /// Whether to use the ComboBoxes width as the menu's width
    abstract useComboBoxAsMenuWidth: bool option with get, set
    /// Optional mode indicates if multi-choice selections is allowed.  Default to false
    abstract multiSelect: bool option with get, set
    /// Sets the 'aria-hidden' attribute on the ComboBox's button element instructing screen readers how to handle the element. This element is hidden by default because all functionality is handled by the input element and the arrow button is only meant to be decorative.
    abstract isButtonAriaHidden: bool option with get, set
    /// Optional keytip for this combo box
    abstract keytipProps: IKeytipProps option with get, set
    /// Value to show in the input, does not have to map to a combobox option
    abstract value: string option with get, set

type [<AllowNullLiteral>] IComboBoxStyles =
    /// Style for the container which has the ComboBox and the label
    abstract container: IStyle with get, set
    /// Style for the label element of the ComboBox.
    abstract label: IStyle with get, set
    /// Style for the label element of the ComboBox in the disabled state.
    abstract labelDisabled: IStyle with get, set
    /// Base styles for the root element of all ComboBoxes.
    abstract root: IStyle with get, set
    /// Styles for the root element for variant of ComboBox with an errorMessage in the props.
    abstract rootError: IStyle with get, set
    /// Styles for variant of ComboBox where allowFreeForm is false in the props.
    abstract rootDisallowFreeForm: IStyle with get, set
    /// Styles for when the ComboBox is hovered. These styles are applied for all comboBoxes except when
    /// the comboBox is disabled.
    abstract rootHovered: IStyle with get, set
    /// Styles for when the ComboBox is active. These styles are applied for all comboBoxes except when
    /// the comboBox is disabled.
    abstract rootPressed: IStyle with get, set
    /// Styles for when the ComboBox is focused. These styles are applied for all comboBoxes except when
    /// the comboBox is disabled.
    abstract rootFocused: IStyle with get, set
    /// Styles for when the comboBox is disabled. These styles override all the other styles.
    /// NOTE : Hover (or) Focused (or) active styles are not applied for disabled comboBoxes.
    abstract rootDisabled: IStyle with get, set
    /// Base styles for the input element - which contains the currently selected
    /// option.
    abstract input: IStyle with get, set
    /// Style override for the input element when comboBox is disabled.
    abstract inputDisabled: IStyle with get, set
    /// Styles for the error Message text of the comboBox.
    abstract errorMessage: IStyle with get, set
    /// Styles for the callout.
    abstract callout: IStyle with get, set
    /// Styles for the optionsContainerWrapper.
    abstract optionsContainerWrapper: IStyle with get, set
    /// Styles for the container of all the Combobox options
    /// Includes the headers and dividers.
    abstract optionsContainer: IStyle with get, set
    /// Styles for a header in the options.
    abstract header: IStyle with get, set
    /// Styles for a divider in the options.
    abstract divider: IStyle with get, set

type [<AllowNullLiteral>] IComboBoxOptionStyles =
    inherit IButtonStyles
    /// Styles for the text inside the comboBox option.
    /// This should be used instead of the description
    /// inside IButtonStyles because we custom render the text
    /// in the comboBox options.
    abstract optionText: IStyle with get, set
type BaseComponent = ______Utilities.BaseComponent
type IComboBoxOption = __ComboBox_types.IComboBoxOption
type IComboBoxProps = __ComboBox_types.IComboBoxProps

type [<AllowNullLiteral>] IExports =
    abstract ComboBox: ComboBoxStatic

type [<AllowNullLiteral>] IComboBoxState =
    abstract isOpen: bool option with get, set
    abstract selectedIndices: ResizeArray<float> option with get, set
    abstract focused: bool option with get, set
    abstract suggestedDisplayValue: string option with get, set
    abstract currentOptions: ResizeArray<IComboBoxOption> with get, set
    abstract currentPendingValueValidIndex: float with get, set
    abstract currentPendingValueValidIndexOnHover: float with get, set
    abstract currentPendingValue: string with get, set

type [<AllowNullLiteral>] ComboBox =
    inherit BaseComponent<IComboBoxProps, IComboBoxState>
    abstract defaultProps: IComboBoxProps with get, set
    abstract _root: obj with get, set
    abstract _autofill: obj with get, set
    abstract _comboBoxWrapper: obj with get, set
    abstract _comboBoxMenu: obj with get, set
    abstract _selectedElement: obj with get, set
    abstract _id: obj with get, set
    abstract _lastReadOnlyAutoCompleteChangeTimeoutId: obj with get, set
    abstract _currentPromise: obj with get, set
    abstract _currentVisibleValue: obj with get, set
    abstract _classNames: obj with get, set
    abstract _isScrollIdle: obj with get, set
    abstract _hasPendingValue: obj with get, set
    abstract _scrollIdleTimeoutId: obj with get, set
    abstract _processingTouch: obj with get, set
    abstract _lastTouchTimeoutId: obj with get, set
    abstract _focusInputAfterClose: obj with get, set
    abstract componentDidMount: unit -> unit
    abstract componentWillReceiveProps: newProps: IComboBoxProps -> unit
    abstract componentDidUpdate: prevProps: IComboBoxProps * prevState: IComboBoxState -> unit
    abstract componentWillUnmount: unit -> unit
    abstract render: unit -> JSX.Element
    /// Set focus on the input
    abstract focus: (bool option -> unit) with get, set
    /// Close menu callout if it is open
    abstract dismissMenu: (unit -> unit) with get, set
    /// componentWillReceiveProps handler for the auto fill component
    /// Checks/updates the iput value to set, if needed
    abstract _onUpdateValueInAutofillWillReceiveProps: obj with get, set
    /// componentDidUpdate handler for the auto fill component
    abstract _onShouldSelectFullInputValueInAutofillComponentDidUpdate: obj with get, set
    /// Get the correct value to pass to the input
    /// to show to the user based off of the current props and state
    abstract _getVisibleValue: obj with get, set
    /// <summary>Is the index within the bounds of the array?</summary>
    /// <param name="options">- options to check if the index is valid for</param>
    /// <param name="index">- the index to check</param>
    abstract _indexWithinBounds: options: obj * index: obj -> unit
    /// Handler for typing changes on the input
    abstract _onInputChange: obj with get, set
    /// <summary>Process the new input's new value when the comboBox
    /// allows freeform entry</summary>
    /// <param name="updatedValue">- the input's newly changed value</param>
    abstract _processInputChangeWithFreeform: updatedValue: obj -> unit
    /// <summary>Process the new input's new value when the comboBox
    /// does not allow freeform entry</summary>
    /// <param name="updatedValue">- the input's newly changed value</param>
    abstract _processInputChangeWithoutFreeform: updatedValue: obj -> unit
    abstract _getFirstSelectedIndex: unit -> unit
    /// <summary>Walk along the options starting at the index, stepping by the delta (positive or negative)
    /// looking for the next valid selectable index (e.g. skipping headings and dividers)</summary>
    /// <param name="index">- the index to get the next selectable index from</param>
    abstract _getNextSelectableIndex: index: obj * searchDirection: obj -> unit
    /// <summary>Set the selected index. Note, this is
    /// the "real" selected index, not the pending selected index</summary>
    /// <param name="index">- the index to set (or the index to set from if a search direction is provided)</param>
    /// <param name="searchDirection">- the direction to search along the options from the given index</param>
    abstract _setSelectedIndex: index: obj * submitPendingValueEvent: obj * ?searchDirection: obj -> unit
    /// Focus (and select) the content of the input
    /// and set the focused state
    abstract _select: obj with get, set
    /// Callback issued when the options should be resolved, if they have been updated or
    /// if they need to be passed in the first time. This only does work if an onResolveOptions
    /// callback was passed in
    abstract _onResolveOptions: obj with get, set
    /// OnBlur handler. Set the focused state to false
    /// and submit any pending value
    abstract _onBlur: obj with get, set
    /// Submit a pending value if there is one
    abstract _submitPendingValue: submitPendingValueEvent: obj -> unit
    abstract _onRenderContainer: obj with get, set
    abstract _onRenderList: obj with get, set
    abstract _onRenderItem: obj with get, set
    abstract _onRenderLowerContent: obj with get, set
    abstract _renderSeparator: item: obj -> unit
    abstract _renderHeader: item: obj -> unit
    abstract _renderOption: obj with get, set
    /// If we are coming from a mouseOut:
    /// there is no visible selected option.
    /// 
    /// Else if We are hovering over an item:
    /// that gets the selected look.
    /// 
    /// Else:
    /// Use the current valid pending index if it exists OR
    /// we do not have a valid index and we currently have a pending input value,
    /// otherwise use the selected index
    abstract _isOptionSelected: index: obj -> unit
    /// <summary>Gets the pending selected index taking into account hover, valueValidIndex, and selectedIndex</summary>
    /// <param name="includeCurrentPendingValue">- Should we include the currentPendingValue when
    /// finding the index</param>
    abstract _getPendingSelectedIndex: includeCurrentPendingValue: obj -> unit
    /// Scroll handler for the callout to make sure the mouse events
    /// for updating focus are not interacting during scroll
    abstract _onScroll: obj with get, set
    /// Scroll the selected element into view
    abstract _scrollIntoView: unit -> unit
    abstract _onRenderOptionContent: obj with get, set
    /// <summary>Click handler for the menu items
    /// to select the item and also close the menu</summary>
    /// <param name="index">- the index of the item that was clicked</param>
    abstract _onItemClick: index: obj -> unit
    /// Handles dismissing (cancelling) the menu
    abstract _onDismiss: obj with get, set
    /// <summary>Get the index of the option that is marked as selected</summary>
    /// <param name="options">- the comboBox options</param>
    /// <param name="selectedKeys">- the known selected key to find</param>
    abstract _getSelectedIndices: options: obj * selectedKeys: obj -> unit
    /// Reset the selected index by clearing the
    /// input (of any pending text), clearing the pending state,
    /// and setting the suggested display value to the last
    /// selected state text
    abstract _resetSelectedIndex: unit -> unit
    /// Clears the pending info state
    abstract _clearPendingInfo: unit -> unit
    /// <summary>Set the pending info</summary>
    /// <param name="currentPendingValue">- new pending value to set</param>
    /// <param name="currentPendingValueValidIndex">- new pending value index to set</param>
    /// <param name="suggestedDisplayValue">- new suggest display value to set</param>
    abstract _setPendingInfo: currentPendingValue: obj * currentPendingValueValidIndex: obj * suggestedDisplayValue: obj -> unit
    /// <summary>Set the pending info from the given index</summary>
    /// <param name="index">- the index to set the pending info from</param>
    abstract _setPendingInfoFromIndex: index: obj -> unit
    /// <summary>Sets the pending info for the comboBox</summary>
    /// <param name="index">- the index to search from</param>
    /// <param name="searchDirection">- the direction to search</param>
    abstract _setPendingInfoFromIndexAndDirection: index: obj * searchDirection: obj -> unit
    abstract _notifyPendingValueChanged: prevState: obj -> unit
    /// Sets the isOpen state and updates focusInputAfterClose
    abstract _setOpenStateAndFocusOnClose: isOpen: obj * focusInputAfterClose: obj -> unit
    /// Handle keydown on the input
    abstract _onInputKeyDown: obj with get, set
    /// Handle keyup on the input
    abstract _onInputKeyUp: obj with get, set
    abstract _onOptionMouseEnter: index: obj -> unit
    abstract _onOptionMouseMove: index: obj -> unit
    abstract _onOptionMouseLeave: obj with get, set
    /// <summary>Handle dismissing the menu and
    /// eating the required key event when disabled</summary>
    /// <param name="ev">- the keyboard event that was fired</param>
    abstract _handleInputWhenDisabled: ev: obj -> unit
    /// Click handler for the button of the comboBox
    /// and the input when not allowing freeform. This
    /// toggles the expand/collapse state of the comboBox (if enbled)
    abstract _onComboBoxClick: obj with get, set
    /// Click handler for the autofill.
    abstract _onAutofillClick: obj with get, set
    abstract _onTouchStart: obj with get, set
    abstract _onPointerDown: obj with get, set
    abstract _handleTouchAndPointerEvent: unit -> unit
    /// Get the styles for the current option.
    abstract _getCaretButtonStyles: unit -> unit
    /// <summary>Get the styles for the current option.</summary>
    /// <param name="item">Item props for the current option</param>
    abstract _getCurrentOptionStyles: item: obj -> unit
    /// Get the aria-activedescendant value for the comboxbox.
    abstract _getAriaActiveDescentValue: unit -> unit
    /// Get the aria autocomplete value for the Combobox
    abstract _getAriaAutoCompleteValue: unit -> unit
    abstract _isPendingOption: item: obj -> unit
    /// Given default selected key(s) and selected key(s), return the selected keys(s).
    /// When default selected key(s) are available, they take precedence and return them instead of selected key(s).
    abstract _getSelectedKeys: defaultSelectedKey: obj * selectedKey: obj -> unit
    abstract _getPreviewText: item: obj -> unit

type [<AllowNullLiteral>] ComboBoxStatic =
    [<Emit "new $0($1...)">] abstract Create: props: IComboBoxProps -> ComboBox
type BaseComponent = ______Utilities.BaseComponent
type IComboBoxProps = __ComboBox_types.IComboBoxProps
type IComboBox = __ComboBox_types.IComboBox

type [<AllowNullLiteral>] IExports =
    abstract VirtualizedComboBox: VirtualizedComboBoxStatic

type [<AllowNullLiteral>] VirtualizedComboBox =
    inherit BaseComponent<IComboBoxProps, obj>
    inherit IComboBox
    /// The combo box element 
    abstract _comboBox: obj with get, set
    /// The virtualized list element 
    abstract _list: obj with get, set
    abstract dismissMenu: unit -> unit
    abstract focus: unit -> bool
    abstract render: unit -> JSX.Element
    abstract _onRenderList: (IComboBoxProps -> JSX.Element) with get, set
    abstract _onScrollToItem: (float -> unit) with get, set

type [<AllowNullLiteral>] VirtualizedComboBoxStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> VirtualizedComboBox
type IContextualMenuItem = ___ContextualMenu_index.IContextualMenuItem
type IContextualMenuProps = ___ContextualMenu_index.IContextualMenuProps

type [<AllowNullLiteral>] ICommandBar =
    /// Sets focus to the active command in the list.
    abstract focus: unit -> unit

type [<AllowNullLiteral>] ICommandBarProps =
    inherit React.HTMLAttributes<HTMLDivElement>
    /// Optional callback to access the ICommandBar interface. Use this instead of ref for accessing
    /// the public methods and properties of the component.
    abstract componentRef: (ICommandBar option -> unit) option with get, set
    /// Whether or not the search box is visible
    abstract isSearchBoxVisible: bool option with get, set
    /// Placeholder text to display in the search box
    abstract searchPlaceholderText: string option with get, set
    /// Items to render
    abstract items: ResizeArray<IContextualMenuItem> with get, set
    /// Default items to have in the overflow menu
    abstract overflowItems: ResizeArray<IContextualMenuItem> option with get, set
    /// Menu props to be passed to overflow elipsis
    abstract overflowMenuProps: obj option with get, set
    /// Text to be read by screen readers if there are overflow items and focus is on elipsis button
    abstract elipisisAriaLabel: string option with get, set
    /// Items to render on the right side (or left, in RTL).
    abstract farItems: ResizeArray<IContextualMenuItem> option with get, set
    /// Additional css class to apply to the command bar
    abstract className: string option with get, set

type [<AllowNullLiteral>] ICommandBarItemProps =
    inherit IContextualMenuItem
    /// Remove text when button is not in the overflow
    abstract iconOnly: bool option with get, set
type BaseComponent = ______Utilities.BaseComponent
type ICommandBar = __CommandBar_types.ICommandBar
type ICommandBarProps = __CommandBar_types.ICommandBarProps
type IContextualMenuProps = ______ContextualMenu.IContextualMenuProps
type IContextualMenuItem = ______ContextualMenu.IContextualMenuItem

type [<AllowNullLiteral>] IExports =
    abstract CommandBar: CommandBarStatic

type [<AllowNullLiteral>] ICommandBarState =
    abstract renderedItems: ResizeArray<IContextualMenuItem> option with get, set
    abstract renderedOverflowItems: ResizeArray<IContextualMenuItem> option with get, set
    abstract expandedMenuItemKey: string option with get, set
    abstract expandedMenuId: string option with get, set
    abstract contextualMenuProps: IContextualMenuProps option with get, set
    abstract contextualMenuTarget: HTMLElement option with get, set
    abstract renderedFarItems: ResizeArray<IContextualMenuItem> option with get, set

type [<AllowNullLiteral>] CommandBar =
    inherit BaseComponent<ICommandBarProps, ICommandBarState>
    inherit ICommandBar
    abstract defaultProps: ICommandBarProps with get, set
    abstract refs: obj with get, set
    abstract _searchSurface: obj with get, set
    abstract _commandSurface: obj with get, set
    abstract _commandBarRegion: obj with get, set
    abstract _farCommandSurface: obj with get, set
    abstract _focusZone: obj with get, set
    abstract _overflow: obj with get, set
    abstract _id: obj with get, set
    abstract _overflowWidth: obj with get, set
    abstract _commandItemWidths: obj with get, set
    abstract componentDidMount: unit -> unit
    abstract componentWillReceiveProps: nextProps: ICommandBarProps -> unit
    abstract componentDidUpdate: prevProps: ICommandBarProps * prevStates: ICommandBarState -> unit
    abstract render: unit -> JSX.Element
    abstract focus: unit -> unit
    abstract _renderItemInCommandBar: item: obj * posInSet: obj * setSize: obj * expandedMenuItemKey: obj * ?isFarItem: obj -> unit
    abstract _renderIcon: item: obj -> unit
    abstract _asyncMeasure: unit -> unit
    abstract _updateItemMeasurements: unit -> unit
    abstract _updateRenderedItems: unit -> unit
    abstract _onItemClick: item: obj -> unit
    abstract _onOverflowClick: obj with get, set
    abstract _onContextMenuDismiss: obj with get, set
    abstract _getStateFromProps: nextProps: obj -> unit
    abstract _getContextualMenuPropsAfterUpdate: renderedItems: obj * overflowItems: obj * overflowMenuProps: obj -> unit
    abstract _getContextualMenuPropsFromItem: item: obj -> unit

type [<AllowNullLiteral>] CommandBarStatic =
    [<Emit "new $0($1...)">] abstract Create: props: ICommandBarProps -> CommandBar
type DatePicker = __DatePicker.DatePicker
type DayOfWeek = ______Calendar.DayOfWeek
type ICalendarProps = ______Calendar.ICalendarProps
type FirstWeekOfYear = ______utilities_dateValues_DateValues.FirstWeekOfYear
type ICalendarFormatDateCallbacks = ___Calendar_Calendar_types.ICalendarFormatDateCallbacks

type [<AllowNullLiteral>] IDatePicker =
    /// Sets focus to the text field 
    abstract focus: unit -> unit
    /// Reset the state of the picker to the default 
    abstract reset: unit -> unit

type [<AllowNullLiteral>] IDatePickerProps =
    inherit React.Props<DatePicker>
    /// Optional callback to access the IDatePicker interface. Use this instead of ref for accessing
    /// the public methods and properties of the component.
    abstract componentRef: (IDatePicker option -> unit) option with get, set
    /// Pass calendar props to calendar component
    abstract calendarProps: ICalendarProps option with get, set
    /// Callback issued when a date is selected
    abstract onSelectDate: (DateTime option -> unit) option with get, set
    /// Label for the DatePicker
    abstract label: string option with get, set
    /// Whether the DatePicker is a required field or not
    abstract isRequired: bool option with get, set
    /// Disabled state of the DatePicker.
    abstract disabled: bool option with get, set
    /// Aria Label for TextField of the DatePicker for screen reader users.
    abstract ariaLabel: string option with get, set
    /// Aria label for date picker popup for screen reader users.
    abstract pickerAriaLabel: string option with get, set
    /// Whether the month picker is shown beside the day picker or hidden.
    abstract isMonthPickerVisible: bool option with get, set
    /// Show month picker on top of date picker when visible.
    abstract showMonthPickerAsOverlay: bool option with get, set
    /// Whether the DatePicker allows input a date string directly or not
    abstract allowTextInput: bool option with get, set
    /// Whether the DatePicker should open automatically when the control is focused
    abstract disableAutoFocus: bool option with get, set
    /// Placeholder text for the DatePicker
    abstract placeholder: string option with get, set
    /// Value of today. If null, current time in client machine will be used.
    abstract today: DateTime option with get, set
    /// Default value of the DatePicker, if any
    abstract value: DateTime option with get, set
    /// Optional method to format the chosen date to a string to display in the DatePicker
    abstract formatDate: (DateTime -> string) option with get, set
    /// Optional method to parse the text input value to date, it is only useful when allowTextInput is set to true
    abstract parseDateFromString: (string -> DateTime option) option with get, set
    /// The first day of the week for your locale.
    abstract firstDayOfWeek: DayOfWeek option with get, set
    /// Localized strings to use in the DatePicker
    abstract strings: IDatePickerStrings option with get, set
    /// Whether the month picker should highlight the current month
    abstract highlightCurrentMonth: bool option with get, set
    /// Whether the month picker should highlight the selected month
    abstract highlightSelectedMonth: bool option with get, set
    /// Whether the calendar should show the week number (weeks 1 to 53) before each week row
    abstract showWeekNumbers: bool option with get, set
    /// Defines when the first week of the year should start, FirstWeekOfYear.FirstDay,
    /// FirstWeekOfYear.FirstFullWeek or FirstWeekOfYear.FirstFourDayWeek are the possible values
    abstract firstWeekOfYear: FirstWeekOfYear option with get, set
    /// Whether the "Go to today" link should be shown or not
    abstract showGoToToday: bool option with get, set
    /// Determines if DatePicker has a border.
    abstract borderless: bool option with get, set
    /// Optional Classname for datepicker root element .
    abstract className: string option with get, set
    /// Apply additional formating to dates, for example localized date formatting.
    abstract dateTimeFormatter: ICalendarFormatDateCallbacks option with get, set
    /// The minimum allowable date.
    abstract minDate: DateTime option with get, set
    /// The maximum allowable date.
    abstract maxDate: DateTime option with get, set
    /// The initially highlighted date in the calendar picker
    abstract initialPickerDate: DateTime option with get, set
    /// Callback that runs after DatePicker's menu (Calendar) is closed
    abstract onAfterMenuDismiss: (unit -> unit) option with get, set

type [<AllowNullLiteral>] IDatePickerStrings =
    /// An array of strings for the full names of months.
    /// The array is 0-based, so months[0] should be the full name of January.
    abstract months: ResizeArray<string> with get, set
    /// An array of strings for the short names of months.
    /// The array is 0-based, so shortMonths[0] should be the short name of January.
    abstract shortMonths: ResizeArray<string> with get, set
    /// An array of strings for the full names of days of the week.
    /// The array is 0-based, so days[0] should be the full name of Sunday.
    abstract days: ResizeArray<string> with get, set
    /// An array of strings for the initials of the days of the week.
    /// The array is 0-based, so days[0] should be the initial of Sunday.
    abstract shortDays: ResizeArray<string> with get, set
    /// String to render for button to direct the user to today's date.
    abstract goToToday: string with get, set
    /// Error message to render for TextField if isRequired validation fails.
    abstract isRequiredErrorMessage: string option with get, set
    /// Error message to render for TextField if input date string parsing fails.
    abstract invalidInputErrorMessage: string option with get, set
    /// Error message to render for TextField if date boundary (minDate, maxDate) validation fails.
    abstract isOutOfBoundsErrorMessage: string option with get, set
    /// Aria-label for the "previous month" button.
    abstract prevMonthAriaLabel: string option with get, set
    /// Aria-label for the "next month" button.
    abstract nextMonthAriaLabel: string option with get, set
    /// Aria-label for the "previous year" button.
    abstract prevYearAriaLabel: string option with get, set
    /// Aria-label for the "next year" button.
    abstract nextYearAriaLabel: string option with get, set
type IDatePicker = __DatePicker_types.IDatePicker
type IDatePickerProps = __DatePicker_types.IDatePickerProps
type BaseComponent = ______Utilities.BaseComponent

type [<AllowNullLiteral>] IExports =
    abstract DatePicker: DatePickerStatic

type [<AllowNullLiteral>] IDatePickerState =
    abstract selectedDate: DateTime option with get, set
    abstract formattedDate: string option with get, set
    abstract isDatePickerShown: bool option with get, set
    abstract errorMessage: string option with get, set

type [<AllowNullLiteral>] DatePicker =
    inherit BaseComponent<IDatePickerProps, IDatePickerState>
    inherit IDatePicker
    abstract defaultProps: IDatePickerProps with get, set
    abstract _calendar: obj with get, set
    abstract _datePickerDiv: obj with get, set
    abstract _textField: obj with get, set
    abstract _preventFocusOpeningPicker: obj with get, set
    abstract componentWillReceiveProps: nextProps: IDatePickerProps -> unit
    abstract componentDidUpdate: prevProps: IDatePickerProps * prevState: IDatePickerState -> unit
    abstract render: unit -> JSX.Element
    abstract focus: unit -> unit
    abstract reset: unit -> unit
    abstract _onSelectDate: obj with get, set
    abstract _onCalloutPositioned: obj with get, set
    abstract _onTextFieldFocus: obj with get, set
    abstract _onTextFieldBlur: obj with get, set
    abstract _onTextFieldChanged: obj with get, set
    abstract _onTextFieldKeyDown: obj with get, set
    abstract _onTextFieldClick: obj with get, set
    abstract _onIconClick: obj with get, set
    abstract _showDatePickerPopup: unit -> unit
    abstract _dismissDatePickerPopup: obj with get, set
    /// Callback for closing the calendar callout
    abstract _calendarDismissed: obj with get, set
    abstract _handleEscKey: obj with get, set
    abstract _validateTextInput: obj with get, set
    abstract _getDefaultState: ?props: obj -> unit
    abstract _isDateOutOfBounds: date: obj * ?minDate: obj * ?maxDate: obj -> unit

type [<AllowNullLiteral>] DatePickerStatic =
    [<Emit "new $0($1...)">] abstract Create: props: IDatePickerProps -> DatePicker
let [<Import("obj","office-ui-fabric-react")>] SELECTION_CHANGE: obj = jsNative

type [<AllowNullLiteral>] IObjectWithKey =
    abstract key: U2<string, float> option with get, set

type [<RequireQualifiedAccess>] SelectionMode =
    | None = 0
    | Single = 1
    | Multiple = 2

type [<AllowNullLiteral>] ISelection =
    abstract count: float with get, set
    abstract mode: SelectionMode with get, set
    abstract canSelectItem: (IObjectWithKey -> bool) with get, set
    abstract setChangeEvents: isEnabled: bool * ?suppressChange: bool -> unit
    abstract setItems: items: ResizeArray<IObjectWithKey> * shouldClear: bool -> unit
    abstract getItems: unit -> ResizeArray<IObjectWithKey>
    abstract getSelection: unit -> ResizeArray<IObjectWithKey>
    abstract getSelectedIndices: unit -> ResizeArray<float>
    abstract getSelectedCount: unit -> float
    abstract isRangeSelected: fromIndex: float * count: float -> bool
    abstract isAllSelected: unit -> bool
    abstract isKeySelected: key: string -> bool
    abstract isIndexSelected: index: float -> bool
    abstract isModal: unit -> bool
    abstract setAllSelected: isAllSelected: bool -> unit
    abstract setKeySelected: key: string * isSelected: bool * shouldAnchor: bool -> unit
    abstract setIndexSelected: index: float * isSelected: bool * shouldAnchor: bool -> unit
    abstract setModal: isModal: bool -> unit
    abstract selectToKey: key: string * ?clearSelection: bool -> unit
    abstract selectToIndex: index: float * ?clearSelection: bool -> unit
    abstract toggleAllSelected: unit -> unit
    abstract toggleKeySelected: key: string -> unit
    abstract toggleIndexSelected: index: float -> unit
    abstract toggleRangeSelected: fromIndex: float * count: float -> unit

type [<RequireQualifiedAccess>] SelectionDirection =
    | Horizontal = 0
    | Vertical = 1
type IObjectWithKey = __interfaces.IObjectWithKey
type ISelection = __interfaces.ISelection
type SelectionMode = __interfaces.SelectionMode

type [<AllowNullLiteral>] IExports =
    abstract Selection: SelectionStatic

type [<AllowNullLiteral>] ISelectionOptions =
    abstract onSelectionChanged: (unit -> unit) option with get, set
    abstract getKey: (IObjectWithKey -> float -> U2<string, float>) option with get, set
    abstract canSelectItem: (IObjectWithKey -> bool) option with get, set
    abstract selectionMode: SelectionMode option with get, set

type [<AllowNullLiteral>] Selection =
    inherit ISelection
    abstract count: float with get, set
    abstract mode: SelectionMode
    abstract _getKey: obj with get, set
    abstract _canSelectItem: obj with get, set
    abstract _changeEventSuppressionCount: obj with get, set
    abstract _items: obj with get, set
    abstract _selectedItems: obj with get, set
    abstract _selectedIndices: obj with get, set
    abstract _isAllSelected: obj with get, set
    abstract _exemptedIndices: obj with get, set
    abstract _exemptedCount: obj with get, set
    abstract _keyToIndexMap: obj with get, set
    abstract _anchoredIndex: obj with get, set
    abstract _onSelectionChanged: obj with get, set
    abstract _hasChanged: obj with get, set
    abstract _unselectableIndices: obj with get, set
    abstract _unselectableCount: obj with get, set
    abstract _isModal: obj with get, set
    abstract canSelectItem: item: IObjectWithKey -> bool
    abstract getKey: item: IObjectWithKey * ?index: float -> string
    abstract setChangeEvents: isEnabled: bool * ?suppressChange: bool -> unit
    abstract isModal: unit -> bool
    abstract setModal: isModal: bool -> unit
    /// Selection needs the items, call this method to set them. If the set
    /// of items is the same, this will re-evaluate selection and index maps.
    /// Otherwise, shouldClear should be set to true, so that selection is
    /// cleared.
    abstract setItems: items: ResizeArray<IObjectWithKey> * ?shouldClear: bool -> unit
    abstract getItems: unit -> ResizeArray<IObjectWithKey>
    abstract getSelection: unit -> ResizeArray<IObjectWithKey>
    abstract getSelectedCount: unit -> float
    abstract getSelectedIndices: unit -> ResizeArray<float>
    abstract isRangeSelected: fromIndex: float * count: float -> bool
    abstract isAllSelected: unit -> bool
    abstract isKeySelected: key: string -> bool
    abstract isIndexSelected: index: float -> bool
    abstract setAllSelected: isAllSelected: bool -> unit
    abstract setKeySelected: key: string * isSelected: bool * shouldAnchor: bool -> unit
    abstract setIndexSelected: index: float * isSelected: bool * shouldAnchor: bool -> unit
    abstract selectToKey: key: string * ?clearSelection: bool -> unit
    abstract selectToIndex: index: float * ?clearSelection: bool -> unit
    abstract toggleAllSelected: unit -> unit
    abstract toggleKeySelected: key: string -> unit
    abstract toggleIndexSelected: index: float -> unit
    abstract toggleRangeSelected: fromIndex: float * count: float -> unit
    abstract _updateCount: unit -> unit
    abstract _change: unit -> unit

type [<AllowNullLiteral>] SelectionStatic =
    [<Emit "new $0($1...)">] abstract Create: ?options: ISelectionOptions -> Selection
type BaseComponent = ______Utilities.BaseComponent
type ISelection = __interfaces.ISelection
type SelectionMode = __interfaces.SelectionMode
type IObjectWithKey = __interfaces.IObjectWithKey

type [<AllowNullLiteral>] IExports =
    abstract SelectionZone: SelectionZoneStatic

type [<AllowNullLiteral>] ISelectionZone =
    abstract ignoreNextFocus: (unit -> unit) with get, set

type [<AllowNullLiteral>] ISelectionZoneProps =
    inherit React.Props<SelectionZone>
    abstract componentRef: (unit -> unit) option with get, set
    abstract selection: ISelection with get, set
    abstract layout: obj option with get, set
    abstract selectionMode: SelectionMode option with get, set
    abstract selectionPreservedOnEmptyClick: bool option with get, set
    abstract disableAutoSelectOnInputElements: bool option with get, set
    abstract enterModalOnTouch: bool option with get, set
    abstract isSelectedOnFocus: bool option with get, set
    abstract onItemInvoked: (IObjectWithKey -> float -> Event -> unit) option with get, set
    abstract onItemContextMenu: (obj option -> float -> Event -> U2<unit, bool>) option with get, set

type [<AllowNullLiteral>] SelectionZone =
    inherit BaseComponent<ISelectionZoneProps, obj>
    abstract defaultProps: obj with get, set
    abstract _root: obj with get, set
    abstract _isCtrlPressed: obj with get, set
    abstract _isShiftPressed: obj with get, set
    abstract _isMetaPressed: obj with get, set
    abstract _shouldHandleFocus: obj with get, set
    abstract _shouldHandleFocusTimeoutId: obj with get, set
    abstract _isTouch: obj with get, set
    abstract _isTouchTimeoutId: obj with get, set
    abstract componentDidMount: unit -> unit
    abstract render: unit -> JSX.Element
    /// In some cases, the consuming scenario requires to set focus on a row without having SelectionZone
    /// react to the event. Note that focus events in IE <= 11 will occur asynchronously after .focus() has
    /// been called on an element, so we need a flag to store the idea that we will bypass the "next"
    /// focus event that occurs. This method does that.
    abstract ignoreNextFocus: (unit -> unit) with get, set
    abstract _onMouseDownCapture: obj with get, set
    /// When we focus an item, for single/multi select scenarios, we should try to select it immediately
    /// as long as the focus did not originate from a mouse down/touch event. For those cases, we handle them
    /// specially.
    abstract _onFocus: obj with get, set
    abstract _onMouseDown: obj with get, set
    abstract _onTouchStartCapture: obj with get, set
    abstract _onClick: obj with get, set
    abstract _onContextMenu: obj with get, set
    abstract _isSelectionDisabled: target: obj -> unit
    /// In multi selection, if you double click within an item's root (but not within the invoke element or input elements),
    /// we should execute the invoke handler.
    abstract _onDoubleClick: obj with get, set
    abstract _onKeyDownCapture: obj with get, set
    abstract _onKeyDown: obj with get, set
    abstract _onToggleAllClick: ev: obj -> unit
    abstract _onToggleClick: ev: obj * index: obj -> unit
    abstract _onInvokeClick: ev: obj * index: obj -> unit
    abstract _onItemSurfaceClick: ev: obj * index: obj -> unit
    abstract _onInvokeMouseDown: ev: obj * index: obj -> unit
    abstract _tryClearOnEmptyClick: ev: obj -> unit
    abstract _clearAndSelectIndex: index: obj -> unit
    /// We need to track the modifier key states so that when focus events occur, which do not contain
    /// modifier states in the Event object, we know how to behave.
    abstract _updateModifiers: ev: obj -> unit
    abstract _findItemRoot: target: obj -> unit
    abstract _getItemIndex: itemRoot: obj -> unit
    abstract _shouldAutoSelect: element: obj -> unit
    abstract _hasAttribute: element: obj * attributeName: obj -> unit
    abstract _isInputElement: element: obj -> unit
    abstract _isNonHandledClick: element: obj -> unit
    abstract _handleNextFocus: handleFocus: obj -> unit
    abstract _setIsTouch: isTouch: obj -> unit
    abstract _getSelectionMode: unit -> unit

type [<AllowNullLiteral>] SelectionZoneStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> SelectionZone
type IRectangle = ______Utilities.IRectangle
type IRenderFunction = ______Utilities.IRenderFunction
type List = __List.List

type [<RequireQualifiedAccess>] ScrollToMode =
    | Auto = 0
    | Top = 1
    | Bottom = 2
    | Center = 3

type [<AllowNullLiteral>] IList =
    /// Force the component to update.
    abstract forceUpdate: (unit -> unit) with get, set
    /// Scroll to the given index. By default will bring the page the specified item is on into the view. If a callback
    /// to measure the height of an individual item is specified, will only scroll to bring the specific item into view.
    /// 
    /// Note: with items of variable height and no passed in `getPageHeight` method, the list might jump after scrolling
    /// when windows before/ahead are being rendered, and the estimated height is replaced using actual elements.
    abstract scrollToIndex: (float -> (float -> float) -> ScrollToMode -> unit) with get, set

type [<AllowNullLiteral>] IListProps =
    inherit React.HTMLAttributes<U2<List, HTMLDivElement>>
    /// Optional callback to access the IList interface. Use this instead of ref for accessing
    /// the public methods and properties of the component.
    abstract componentRef: (IList option -> unit) option with get, set
    /// Optional classname to append to root list. 
    abstract className: string option with get, set
    /// Items to render. 
    abstract items: ResizeArray<obj option> option with get, set
    /// Method to call when trying to render an item.
    abstract onRenderCell: (obj option -> float -> bool -> React.ReactNode) option with get, set
    /// Optional callback for monitoring when a page is added. 
    abstract onPageAdded: (IPage -> unit) option with get, set
    /// Optional callback for monitoring when a page is removed. 
    abstract onPageRemoved: (IPage -> unit) option with get, set
    /// Optional callback to get the item key, to be used on render. 
    abstract getKey: (obj option -> float -> string) option with get, set
    /// Called by the list to get the specification for a page.
    /// Use this method to provide an allocation of items per page,
    /// as well as an estimated rendered height for the page.
    /// The list will use this to optimize virtualization.
    abstract getPageSpecification: (float -> IRectangle -> IPageSpecification) option with get, set
    /// Method called by the list to get how many items to render per page from specified index.
    /// In general, use `getPageSpecification` instead.
    abstract getItemCountForPage: (float -> IRectangle -> float) option with get, set
    /// Method called by the list to get the pixel height for a given page. By default, we measure the first
    /// page's height and default all other pages to that height when calculating the surface space. It is
    /// ideal to be able to adequately predict page heights in order to keep the surface space from jumping
    /// in pixels, which has been seen to cause browser performance issues.
    /// In general, use `getPageSpecification` instead.
    abstract getPageHeight: (float -> IRectangle -> float) option with get, set
    /// Method called by the list to derive the page style object. For spacer pages, the list will derive
    /// the height and passed in heights will be ignored.
    abstract getPageStyle: (IPage -> obj option) option with get, set
    /// In addition to the visible window, how many windowHeights should we render ahead.
    abstract renderedWindowsAhead: float option with get, set
    /// In addition to the visible window, how many windowHeights should we render behind.
    abstract renderedWindowsBehind: float option with get, set
    /// Index in items array to start rendering from. Defaults to 0. 
    abstract startIndex: float option with get, set
    /// Number of items to render. Defaults to items.length. 
    abstract renderCount: float option with get, set
    /// Boolean value to enable render page caching. This is an experimental performance optimization
    /// that is off by default.
    abstract usePageCache: bool option with get, set
    /// Optional callback to determine whether the list should be rendered in full, or virtualized.
    /// Virtualization will add and remove pages of items as the user scrolls them into the visible range.
    /// This benefits larger list scenarios by reducing the DOM on the screen, but can negatively affect performance for smaller lists.
    /// The default implementation will virtualize when this callback is not provided.
    abstract onShouldVirtualize: (IListProps -> bool) option with get, set
    /// The role to assign to the list root element.
    /// Use this to override the default assignment of 'list' to the root and 'listitem' to the cells.
    abstract role: string option with get, set
    /// Called when the List will render a page.
    /// Override this to control how cells are rendered within a page.
    abstract onRenderPage: (IPageProps -> IRenderFunction<IPageProps> -> React.ReactNode) option with get, set

type [<AllowNullLiteral>] IPage =
    abstract key: string with get, set
    abstract items: ResizeArray<obj option> option with get, set
    abstract startIndex: float with get, set
    abstract itemCount: float with get, set
    abstract style: obj option with get, set
    abstract top: float with get, set
    abstract height: float with get, set
    abstract data: obj option with get, set

type [<AllowNullLiteral>] IPageProps =
    inherit React.HTMLAttributes<HTMLDivElement>
    inherit React.Props<HTMLDivElement>
    /// The role being assigned to the rendered page element by the list.
    abstract role: string option with get, set
    /// The allocation data for the page.
    abstract page: IPage with get, set

type [<AllowNullLiteral>] IPageSpecification =
    /// The number of items to allocate to the page.
    abstract itemCount: float option with get, set
    /// The estimated pixel height of the page.
    abstract height: float option with get, set
    /// Data to pass through to the page when rendering.
    abstract data: obj option with get, set
    /// The key to use when creating the page.
    abstract key: string option with get, set
type BaseComponent = ______Utilities.BaseComponent
type IList = __List_types.IList
type IListProps = __List_types.IListProps
type IPage = __List_types.IPage
type ScrollToMode = __List_types.ScrollToMode

type [<AllowNullLiteral>] IExports =
    abstract List: ListStatic

type [<AllowNullLiteral>] IListState =
    abstract pages: ResizeArray<IPage> option with get, set
    /// The last versionstamp for  
    abstract measureVersion: float option with get, set
    abstract isScrolling: bool option with get, set

/// The List renders virtualized pages of items. Each page's item count is determined by the getItemCountForPage callback if
/// provided by the caller, or 10 as default. Each page's height is determined by the getPageHeight callback if provided by
/// the caller, or by cached measurements if available, or by a running average, or a default fallback.
/// 
/// The algorithm for rendering pages works like this:
/// 
/// 1. Predict visible pages based on "current measure data" (page heights, surface position, visible window)
/// 2. If changes are necessary, apply changes (add/remove pages)
/// 3. For pages that are added, measure the page heights if we need to using getBoundingClientRect
/// 4. If measurements don't match predictions, update measure data and goto step 1 asynchronously
/// 
/// Measuring too frequently can pull performance down significantly. To compensate, we cache measured values so that
/// we can avoid re-measuring during operations that should not alter heights, like scrolling.
/// 
/// To optimize glass rendering performance, onShouldVirtualize can be set. When onShouldVirtualize return false,
/// List will run in fast mode (not virtualized) to render all items without any measurements to improve page load time. And we
/// start doing measurements and rendering in virtualized mode when items grows larger than this threshold.
/// 
/// However, certain operations can make measure data stale. For example, resizing the list, or passing in new props,
/// or forcing an update change cause pages to shrink/grow. When these operations occur, we increment a measureVersion
/// number, which we associate with cached measurements and use to determine if a remeasure should occur.
type [<AllowNullLiteral>] List =
    inherit BaseComponent<IListProps, IListState>
    inherit IList
    abstract defaultProps: obj with get, set
    abstract refs: obj with get, set
    abstract _root: obj with get, set
    abstract _surface: obj with get, set
    abstract _estimatedPageHeight: obj with get, set
    abstract _totalEstimates: obj with get, set
    abstract _cachedPageHeights: obj with get, set
    abstract _focusedIndex: obj with get, set
    abstract _scrollElement: obj with get, set
    abstract _hasCompletedFirstRender: obj with get, set
    abstract _surfaceRect: obj with get, set
    abstract _requiredRect: obj with get, set
    abstract _allowedRect: obj with get, set
    abstract _materializedRect: obj with get, set
    abstract _requiredWindowsAhead: obj with get, set
    abstract _requiredWindowsBehind: obj with get, set
    abstract _measureVersion: obj with get, set
    abstract _scrollHeight: obj with get, set
    abstract _scrollTop: obj with get, set
    abstract _pageCache: obj with get, set
    /// <summary>Scroll to the given index. By default will bring the page the specified item is on into the view. If a callback
    /// to measure the height of an individual item is specified, will only scroll to bring the specific item into view.
    /// 
    /// Note: with items of variable height and no passed in `getPageHeight` method, the list might jump after scrolling
    /// when windows before/ahead are being rendered, and the estimated height is replaced using actual elements.</summary>
    /// <param name="index">Index of item to scroll to</param>
    /// <param name="measureItem">Optional callback to measure the height of an individual item</param>
    /// <param name="scrollToMode">Optional defines where in the window the item should be positioned to when scrolling</param>
    abstract scrollToIndex: index: float * ?measureItem: (float -> float) * ?scrollToMode: ScrollToMode -> unit
    abstract componentDidMount: unit -> unit
    abstract componentWillReceiveProps: newProps: IListProps -> unit
    abstract shouldComponentUpdate: newProps: IListProps * newState: IListState -> bool
    abstract forceUpdate: unit -> unit
    abstract render: unit -> JSX.Element
    abstract _shouldVirtualize: ?props: obj -> unit
    /// when props.items change or forceUpdate called, throw away cached pages
    abstract _invalidatePageCache: unit -> unit
    abstract _renderPage: page: obj -> unit
    /// Generate the style object for the page. 
    abstract _getPageStyle: page: obj -> unit
    abstract _onRenderPage: obj with get, set
    /// Track the last item index focused so that we ensure we keep it rendered. 
    abstract _onFocus: ev: obj -> unit
    /// Called synchronously to reset the required render range to 0 on scrolling. After async scroll has executed,
    /// we will call onAsyncIdle which will reset it back to it's correct value.
    abstract _onScroll: unit -> unit
    abstract _resetRequiredWindows: unit -> unit
    /// Debounced method to asynchronously update the visible region on a scroll event.
    abstract _onAsyncScroll: unit -> unit
    /// This is an async debounced method that will try and increment the windows we render. If we can increment
    /// either, we increase the amount we render and re-evaluate.
    abstract _onAsyncIdle: unit -> unit
    /// Function to call when the list is done scrolling.
    /// This function is debounced.
    abstract _onScrollingDone: unit -> unit
    abstract _onAsyncResize: unit -> unit
    abstract _updatePages: ?props: obj -> unit
    /// <summary>Notify consumers that the rendered pages have changed</summary>
    /// <param name="oldPages">The old pages</param>
    /// <param name="newPages">The new pages</param>
    /// <param name="props">The props to use</param>
    abstract _notifyPageChanges: oldPages: obj * newPages: obj * ?props: obj -> unit
    abstract _updatePageMeasurements: pages: obj -> unit
    /// Given a page, measure its dimensions, update cache.
    abstract _measurePage: page: obj -> unit
    /// Called when a page has been added to the DOM. 
    abstract _onPageAdded: page: obj -> unit
    /// Called when a page has been removed from the DOM. 
    abstract _onPageRemoved: page: obj -> unit
    /// Build up the pages that should be rendered. 
    abstract _buildPages: props: obj -> unit
    abstract _getPageSpecification: itemIndex: obj * visibleRect: obj -> unit
    /// Get the pixel height of a give page. Will use the props getPageHeight first, and if not provided, fallback to
    /// cached height, or estimated page height, or default page height.
    abstract _getPageHeight: itemIndex: obj * itemsPerPage: obj * visibleRect: obj -> unit
    abstract _getItemCountForPage: itemIndex: obj * visibileRect: obj -> unit
    abstract _createPage: pageKey: obj * items: obj * ?startIndex: obj * ?count: obj * ?style: obj * ?data: obj -> unit
    abstract _getRenderCount: ?props: obj -> unit
    /// Calculate the visible rect within the list where top: 0 and left: 0 is the top/left of the list. 
    abstract _updateRenderRects: ?props: obj * ?forceUpdate: obj -> unit

/// The List renders virtualized pages of items. Each page's item count is determined by the getItemCountForPage callback if
/// provided by the caller, or 10 as default. Each page's height is determined by the getPageHeight callback if provided by
/// the caller, or by cached measurements if available, or by a running average, or a default fallback.
/// 
/// The algorithm for rendering pages works like this:
/// 
/// 1. Predict visible pages based on "current measure data" (page heights, surface position, visible window)
/// 2. If changes are necessary, apply changes (add/remove pages)
/// 3. For pages that are added, measure the page heights if we need to using getBoundingClientRect
/// 4. If measurements don't match predictions, update measure data and goto step 1 asynchronously
/// 
/// Measuring too frequently can pull performance down significantly. To compensate, we cache measured values so that
/// we can avoid re-measuring during operations that should not alter heights, like scrolling.
/// 
/// To optimize glass rendering performance, onShouldVirtualize can be set. When onShouldVirtualize return false,
/// List will run in fast mode (not virtualized) to render all items without any measurements to improve page load time. And we
/// start doing measurements and rendering in virtualized mode when items grows larger than this threshold.
/// 
/// However, certain operations can make measure data stale. For example, resizing the list, or passing in new props,
/// or forcing an update change cause pages to shrink/grow. When these operations occur, we increment a measureVersion
/// number, which we associate with cached measurements and use to determine if a remeasure should occur.
type [<AllowNullLiteral>] ListStatic =
    [<Emit "new $0($1...)">] abstract Create: props: IListProps -> List
type BaseComponent = ______Utilities.BaseComponent
type IGroupedList = __GroupedList_types.IGroupedList
type IGroupedListProps = __GroupedList_types.IGroupedListProps
type IGroup = __GroupedList_types.IGroup
type ScrollToMode = ______List.ScrollToMode
type SelectionMode = ______utilities_selection_index.SelectionMode

type [<AllowNullLiteral>] IExports =
    abstract GroupedList: GroupedListStatic

type [<AllowNullLiteral>] IGroupedListState =
    abstract lastWidth: float option with get, set
    abstract lastSelectionMode: SelectionMode option with get, set
    abstract groups: ResizeArray<IGroup> option with get, set

type [<AllowNullLiteral>] GroupedList =
    inherit BaseComponent<IGroupedListProps, IGroupedListState>
    inherit IGroupedList
    abstract defaultProps: obj with get, set
    abstract refs: obj with get, set
    abstract _list: obj with get, set
    abstract _isSomeGroupExpanded: obj with get, set
    abstract scrollToIndex: index: float * ?measureItem: (float -> float) * ?scrollToMode: ScrollToMode -> unit
    abstract componentWillReceiveProps: newProps: IGroupedListProps -> unit
    abstract render: unit -> JSX.Element
    abstract forceUpdate: unit -> unit
    abstract toggleCollapseAll: allCollapsed: bool -> unit
    abstract _renderGroup: obj with get, set
    abstract _returnOne: unit -> unit
    abstract _getGroupKey: group: obj * index: obj -> unit
    abstract _getGroupNestingDepth: unit -> unit
    abstract _onToggleCollapse: obj with get, set
    abstract _onToggleSelectGroup: obj with get, set
    abstract _forceListUpdates: ?groups: obj -> unit
    abstract _onToggleSummarize: obj with get, set
    abstract _getPageSpecification: obj with get, set
    abstract _computeIsSomeGroupExpanded: groups: obj -> unit
    abstract _updateIsSomeGroupExpanded: unit -> unit

type [<AllowNullLiteral>] GroupedListStatic =
    [<Emit "new $0($1...)">] abstract Create: props: IGroupedListProps -> GroupedList
type EventGroup = ______Utilities.EventGroup

type [<AllowNullLiteral>] IDragDropHelper =
    abstract subscribe: (HTMLElement -> EventGroup -> IDragDropOptions -> obj) with get, set
    abstract unsubscribe: (HTMLElement -> string -> unit) with get, set
    abstract dispose: (unit -> unit) with get, set

type [<AllowNullLiteral>] IDragDropEvents =
    abstract canDrop: (IDragDropContext -> IDragDropContext -> bool) option with get, set
    abstract canDrag: (obj option -> bool) option with get, set
    abstract onDragEnter: (obj option -> DragEvent -> string) option with get, set
    abstract onDragLeave: (obj option -> DragEvent -> unit) option with get, set
    abstract onDrop: (obj option -> DragEvent -> unit) option with get, set
    abstract onDragStart: (obj option -> float -> ResizeArray<obj option> -> MouseEvent -> unit) option with get, set
    abstract onDragEnd: (obj option -> DragEvent -> unit) option with get, set

type [<AllowNullLiteral>] IDragDropContext =
    abstract data: obj option with get, set
    abstract index: float with get, set
    abstract isGroup: bool option with get, set

type [<AllowNullLiteral>] IDragDropTarget =
    abstract root: React.ReactInstance with get, set
    abstract options: IDragDropOptions with get, set
    abstract key: string with get, set

type [<AllowNullLiteral>] IDragDropOptions =
    abstract key: string option with get, set
    abstract eventMap: ResizeArray<obj> option with get, set
    abstract selectionIndex: float with get, set
    abstract context: IDragDropContext with get, set
    abstract updateDropState: (bool -> DragEvent -> unit) with get, set
    abstract canDrop: (IDragDropContext -> IDragDropContext -> bool) option with get, set
    abstract canDrag: (obj option -> bool) option with get, set
    abstract onDragStart: (obj option -> float -> ResizeArray<obj option> -> MouseEvent -> unit) option with get, set
    abstract onDrop: (obj option -> DragEvent -> unit) option with get, set
    abstract onDragEnd: (obj option -> DragEvent -> unit) option with get, set
    abstract onDragOver: (obj option -> DragEvent -> unit) option with get, set

type [<AllowNullLiteral>] IDragDropEvent =
    abstract isHandled: bool option with get, set
type EventGroup = ______Utilities.EventGroup
type IDragDropHelper = __interfaces.IDragDropHelper
type IDragDropOptions = __interfaces.IDragDropOptions
type ISelection = ______utilities_selection_interfaces.ISelection

type [<AllowNullLiteral>] IExports =
    abstract DragDropHelper: DragDropHelperStatic

type [<AllowNullLiteral>] IDragDropHelperParams =
    abstract selection: ISelection with get, set
    abstract minimumPixelsForDrag: float option with get, set

type [<AllowNullLiteral>] DragDropHelper =
    inherit IDragDropHelper
    abstract _dragEnterCounts: obj with get, set
    abstract _distanceSquaredForDrag: obj
    abstract _isDragging: obj with get, set
    abstract _dragData: obj with get, set
    abstract _selection: obj with get, set
    abstract _activeTargets: obj with get, set
    abstract _events: obj with get, set
    abstract _lastId: obj with get, set
    abstract dispose: unit -> unit
    abstract subscribe: root: HTMLElement * events: EventGroup * dragDropOptions: IDragDropOptions -> obj
    abstract unsubscribe: root: HTMLElement * key: string -> unit
    abstract _onDragEnd: target: obj * ``event``: obj -> unit
    /// clear drag data when mouse up on body
    abstract _onMouseUp: ``event``: obj -> unit
    /// clear drag data when mouse up outside of the document
    abstract _onDocumentMouseUp: ``event``: obj -> unit
    /// when mouse move over a new drop target while dragging some items,
    /// fire dragleave on the old target and fire dragenter to the new target
    /// The target will handle style change on dragenter and dragleave events.
    abstract _onMouseMove: target: obj * ``event``: obj -> unit
    /// when mouse leave a target while dragging some items, fire dragleave to the target
    abstract _onMouseLeave: target: obj * ``event``: obj -> unit
    /// when mouse down on a draggable item, we start to track dragdata.
    abstract _onMouseDown: target: obj * ``event``: obj -> unit
    /// determine whether the child target is a descendant of the parent
    abstract _isChild: parent: obj * child: obj -> unit
    abstract _isDraggable: target: obj -> unit
    abstract _isDroppable: target: obj -> unit

type [<AllowNullLiteral>] DragDropHelperStatic =
    [<Emit "new $0($1...)">] abstract Create: ``params``: IDragDropHelperParams -> DragDropHelper

type [<AllowNullLiteral>] IExports =
    abstract withViewport: ComposedComponent: obj -> obj option

type [<AllowNullLiteral>] IViewport =
    abstract width: float with get, set
    abstract height: float with get, set

type [<AllowNullLiteral>] IWithViewportState =
    abstract viewport: IViewport option with get, set

type [<AllowNullLiteral>] IWithViewportProps =
    abstract skipViewportMeasures: bool option with get, set
type GroupedList = __GroupedList.GroupedList
type IList = ______List.IList
type IListProps = ______List.IListProps
type IRenderFunction = ______Utilities.IRenderFunction
type IDragDropContext = ______utilities_dragdrop_index.IDragDropContext
type IDragDropEvents = ______utilities_dragdrop_index.IDragDropEvents
type IDragDropHelper = ______utilities_dragdrop_index.IDragDropHelper
type ISelection = ______utilities_selection_index.ISelection
type SelectionMode = ______utilities_selection_index.SelectionMode
type IViewport = ______utilities_decorators_withViewport.IViewport

type [<RequireQualifiedAccess>] CollapseAllVisibility =
    | Hidden = 0
    | Visible = 1

type [<AllowNullLiteral>] IGroupedList =
    inherit IList
    /// Ensures that the list content is updated. Call this in cases where the list prop updates don't change, but the list
    /// still needs to be re-evaluated. For example, if a sizer bar is adjusted and causes the list width to change, you can
    /// call this to force a re-evaluation. Be aware that this can be an expensive operation and should be done sparingly.
    abstract forceUpdate: (unit -> unit) with get, set
    /// Toggles the collapsed state of all the groups in the list.
    abstract toggleCollapseAll: (bool -> unit) with get, set

type [<AllowNullLiteral>] IGroupedListProps =
    inherit React.Props<GroupedList>
    /// Optional callback to access the IGroupedList interface. Use this instead of ref for accessing
    /// the public methods and properties of the component.
    abstract componentRef: (IGroupedList option -> unit) option with get, set
    /// Optional class name to add to the root element. 
    abstract className: string option with get, set
    /// Map of callback functions related to drag and drop functionality. 
    abstract dragDropEvents: IDragDropEvents option with get, set
    /// helper to manage drag/drop across item and groups 
    abstract dragDropHelper: IDragDropHelper option with get, set
    /// Event names and corresponding callbacks that will be registered to groups and rendered elements 
    abstract eventsToRegister: ResizeArray<obj> option with get, set
    /// Optional override properties to render groups. 
    abstract groupProps: IGroupRenderProps option with get, set
    /// Optional grouping instructions. 
    abstract groups: ResizeArray<IGroup> option with get, set
    /// List of items to render. 
    abstract items: ResizeArray<obj option> with get, set
    /// Optional properties to pass through to the list components being rendered. 
    abstract listProps: IListProps option with get, set
    /// Rendering callback to render the group items. 
    abstract onRenderCell: (float -> obj option -> float -> React.ReactNode) with get, set
    /// Optional selection model to track selection state.  
    abstract selection: ISelection option with get, set
    /// Controls how/if the list manages selection. 
    abstract selectionMode: SelectionMode option with get, set
    /// Optional Viewport, provided by the parent component. 
    abstract viewport: IViewport option with get, set
    /// Optional callback when the group expand state changes between all collapsed and at least one group is expanded. 
    abstract onGroupExpandStateChanged: (bool -> unit) option with get, set
    /// boolean to control if pages containing unchanged items should be cached, this is a perf optimization
    /// The same property in List.Props
    abstract usePageCache: bool option with get, set
    /// Optional callback to determine whether the list should be rendered in full, or virtualized.
    /// Virtualization will add and remove pages of items as the user scrolls them into the visible range.
    /// This benefits larger list scenarios by reducing the DOM on the screen, but can negatively affect performance for smaller lists.
    /// The default implementation will virtualize when this callback is not provided.
    abstract onShouldVirtualize: (IListProps -> bool) option with get, set

type [<AllowNullLiteral>] IGroup =
    /// Unique identifier for the group.
    abstract key: string with get, set
    /// Display name for the group, rendered on the header.
    abstract name: string with get, set
    /// Start index for the group within the given items.
    abstract startIndex: float with get, set
    /// How many items should be rendered within the group.
    abstract count: float with get, set
    /// Nested groups, if any.
    abstract children: ResizeArray<IGroup> option with get, set
    /// Number indicating the level of nested groups.
    abstract level: float option with get, set
    /// Deprecated at 1.0.0, selection state will be controled by the selection store only.
    abstract isSelected: bool option with get, set
    /// If all the items in the group are collapsed.
    abstract isCollapsed: bool option with get, set
    /// If the items within the group are summarized or showing all.
    abstract isShowingAll: bool option with get, set
    /// If drag/drop is enabled for the group header.
    abstract isDropEnabled: bool option with get, set
    /// Arbitrary data required to be preserved by the caller.
    abstract data: obj option with get, set
    /// Optional accessibility label (aria-label) attribute that will be stamped on to the element.
    /// If none is specified, the arai-label attribute will contain the group name
    abstract ariaLabel: string option with get, set
    /// Optional flag to indicate the group has more data to load than the current group count indicated.
    /// This can be used to indicate that a plus should be rendered next to the group count in the header.
    abstract hasMoreData: bool option with get, set

type [<AllowNullLiteral>] IGroupRenderProps =
    /// Boolean indicating if all groups are in collapsed state. 
    abstract isAllGroupsCollapsed: bool option with get, set
    /// Grouping item limit. 
    abstract getGroupItemLimit: (IGroup -> float) option with get, set
    /// Callback for when all groups are expanded or collapsed. 
    abstract onToggleCollapseAll: (bool -> unit) option with get, set
    /// Information to pass in to the group header. 
    abstract headerProps: IGroupDividerProps option with get, set
    /// Information to pass in to the group Show all footer. 
    abstract showAllProps: IGroupDividerProps option with get, set
    /// Information to pass in to the group footer. 
    abstract footerProps: IGroupDividerProps option with get, set
    /// Override which allows the caller to provide a custom header.
    abstract onRenderHeader: IRenderFunction<IGroupDividerProps> option with get, set
    /// Override which allows the caller to provide a custom Show All link.
    abstract onRenderShowAll: IRenderFunction<IGroupDividerProps> option with get, set
    /// Override which allows the caller to provide a custom footer.
    abstract onRenderFooter: IRenderFunction<IGroupDividerProps> option with get, set
    /// Flag to indicate whether to ignore the collapsing icon on header.
    abstract collapseAllVisibility: CollapseAllVisibility option with get, set
    /// Boolean indicating if empty groups are shown
    abstract showEmptyGroups: bool option with get, set

type [<AllowNullLiteral>] IGroupDividerProps =
    abstract componentRef: (unit -> unit) option with get, set
    /// Callback to determine if a group has missing items and needs to load them from the server. 
    abstract isGroupLoading: (IGroup -> bool) option with get, set
    /// Text shown on group headers to indicate the group is being loaded. 
    abstract loadingText: string option with get, set
    /// The group to be rendered by the header. 
    abstract group: IGroup option with get, set
    /// The index of the group. 
    abstract groupIndex: float option with get, set
    /// The indent level of the group. 
    abstract groupLevel: float option with get, set
    /// If all items in the group are selected. 
    abstract selected: bool option with get, set
    /// Deprecated at v.65.1 and will be removed by v 1.0. Use 'selected' instead.
    abstract isSelected: bool option with get, set
    /// A reference to the viewport in which the header is rendered. 
    abstract viewport: IViewport option with get, set
    /// The selection mode of the list the group lives within. 
    abstract selectionMode: SelectionMode option with get, set
    /// Text to display for the group footer. 
    abstract footerText: string option with get, set
    /// Text to display for the group "Show All" link. 
    abstract showAllLinkText: string option with get, set
    /// Callback for when the group "Show All" link is clicked 
    abstract onToggleSummarize: (IGroup -> unit) option with get, set
    /// Callback for when the group header is clicked. 
    abstract onGroupHeaderClick: (IGroup -> unit) option with get, set
    /// Callback for when the group is expanded or collapsed. 
    abstract onToggleCollapse: (IGroup -> unit) option with get, set
    /// Callback for when the group is selected. 
    abstract onToggleSelectGroup: (IGroup -> unit) option with get, set
    /// Determines if the group selection check box is shown for collapsed groups. 
    abstract isCollapsedGroupSelectVisible: bool option with get, set
let [<Import("","office-ui-fabric-react")>] DetailsRowCheck: (IDetailsRowCheckProps -> JSX.Element) = jsNative

type [<AllowNullLiteral>] IDetailsRowCheckProps =
    inherit React.HTMLAttributes<HTMLElement>
    abstract isHeader: bool option with get, set
    abstract selected: bool option with get, set
    /// Deprecated at v.65.1 and will be removed by v 1.0. Use 'selected' instead.
    abstract isSelected: bool option with get, set
    abstract anySelected: bool option with get, set
    abstract canSelect: bool with get, set
type IColumn = __DetailsList_types.IColumn
type BaseComponent = ______Utilities.BaseComponent

type [<AllowNullLiteral>] IExports =
    abstract DetailsRowFields: DetailsRowFieldsStatic

type [<AllowNullLiteral>] IDetailsRowFieldsProps =
    abstract componentRef: (unit -> unit) option with get, set
    abstract item: obj option with get, set
    abstract itemIndex: float with get, set
    abstract columnStartIndex: float with get, set
    abstract columns: ResizeArray<IColumn> with get, set
    abstract compact: bool option with get, set
    abstract onRenderItemColumn: (obj option -> float -> IColumn -> obj option) option with get, set
    abstract shimmer: bool option with get, set

type [<AllowNullLiteral>] IDetailsRowFieldsState =
    abstract cellContent: ResizeArray<React.ReactNode> with get, set

type [<AllowNullLiteral>] DetailsRowFields =
    inherit BaseComponent<IDetailsRowFieldsProps, IDetailsRowFieldsState>
    abstract componentWillReceiveProps: newProps: IDetailsRowFieldsProps -> unit
    abstract render: unit -> JSX.Element
    abstract _getState: props: obj -> unit
    abstract _getCellText: item: obj * column: obj -> unit

type [<AllowNullLiteral>] DetailsRowFieldsStatic =
    [<Emit "new $0($1...)">] abstract Create: props: IDetailsRowFieldsProps -> DetailsRowFields
type BaseComponent = ______Utilities.BaseComponent
type IColumn = __DetailsList_types.IColumn
type CheckboxVisibility = __DetailsList_types.CheckboxVisibility
type IDetailsRowCheckProps = __DetailsRowCheck.IDetailsRowCheckProps
type IDetailsRowFieldsProps = __DetailsRowFields.IDetailsRowFieldsProps
type ISelection = ______utilities_selection_interfaces.ISelection
type SelectionMode = ______utilities_selection_interfaces.SelectionMode
type CollapseAllVisibility = ______GroupedList.CollapseAllVisibility
type IDragDropHelper = ________utilities_dragdrop_interfaces.IDragDropHelper
type IDragDropEvents = ________utilities_dragdrop_interfaces.IDragDropEvents
type IViewport = ______utilities_decorators_withViewport.IViewport

type [<AllowNullLiteral>] IExports =
    abstract DetailsRow: DetailsRowStatic

type [<AllowNullLiteral>] IDetailsRowProps =
    inherit React.Props<DetailsRow>
    abstract componentRef: (unit -> unit) option with get, set
    abstract item: obj option with get, set
    abstract itemIndex: float with get, set
    abstract columns: ResizeArray<IColumn> with get, set
    abstract compact: bool option with get, set
    abstract selectionMode: SelectionMode with get, set
    abstract selection: ISelection with get, set
    abstract eventsToRegister: ResizeArray<obj> option with get, set
    abstract onDidMount: (DetailsRow -> unit) option with get, set
    abstract onWillUnmount: (DetailsRow -> unit) option with get, set
    abstract onRenderCheck: (IDetailsRowCheckProps -> JSX.Element) option with get, set
    abstract onRenderItemColumn: (obj option -> float -> IColumn -> obj option) option with get, set
    abstract dragDropEvents: IDragDropEvents option with get, set
    abstract dragDropHelper: IDragDropHelper option with get, set
    abstract groupNestingDepth: float option with get, set
    abstract viewport: IViewport option with get, set
    abstract checkboxVisibility: CheckboxVisibility option with get, set
    abstract collapseAllVisibility: CollapseAllVisibility option with get, set
    abstract getRowAriaLabel: (obj option -> string) option with get, set
    abstract getRowAriaDescribedBy: (obj option -> string) option with get, set
    abstract checkButtonAriaLabel: string option with get, set
    abstract checkboxCellClassName: string option with get, set
    abstract rowFieldsAs: U2<React.StatelessComponent<IDetailsRowFieldsProps>, React.ComponentClass<IDetailsRowFieldsProps>> option with get, set
    abstract className: string option with get, set
    abstract shimmer: bool option with get, set

type [<AllowNullLiteral>] IDetailsRowSelectionState =
    abstract isSelected: bool with get, set
    abstract isSelectionModal: bool with get, set

type [<AllowNullLiteral>] IDetailsRowState =
    abstract selectionState: IDetailsRowSelectionState option with get, set
    abstract columnMeasureInfo: obj option with get, set
    abstract isDropping: bool option with get, set
    abstract groupNestingDepth: float option with get, set

type [<AllowNullLiteral>] DetailsRow =
    inherit BaseComponent<IDetailsRowProps, IDetailsRowState>
    abstract _root: obj with get, set
    abstract _cellMeasurer: obj with get, set
    abstract _focusZone: obj with get, set
    abstract _droppingClassNames: obj with get, set
    abstract _hasMounted: obj with get, set
    abstract _dragDropSubscription: obj with get, set
    abstract componentDidMount: unit -> unit
    abstract componentDidUpdate: previousProps: IDetailsRowProps -> unit
    abstract componentWillUnmount: unit -> unit
    abstract componentWillReceiveProps: newProps: IDetailsRowProps -> unit
    abstract render: unit -> JSX.Element
    /// <summary>measure cell at index. and call the call back with the measured cell width when finish measure</summary>
    /// <param name="index">(the cell index)</param>
    /// <param name="onMeasureDone">(the call back function when finish measure)</param>
    abstract measureCell: index: float * onMeasureDone: (float -> unit) -> unit
    abstract focus: ?forceIntoFirstElement: bool -> bool
    abstract _onRenderCheck: props: IDetailsRowCheckProps -> JSX.Element
    abstract _getSelectionState: props: obj -> unit
    abstract _onSelectionChanged: unit -> unit
    abstract _onToggleSelection: unit -> unit
    abstract _onRootRef: obj with get, set
    abstract _getRowDragDropOptions: unit -> unit
    /// <summary>update isDropping state based on the input value, which is used to change style during drag and drop
    /// 
    /// when change to true, that means drag enter. we will add default dropping class name
    /// or the custom dropping class name (return result from onDragEnter) to the root elemet.
    /// 
    /// when change to false, that means drag leave. we will remove the dropping class name from root element.</summary>
    /// <param name="newValue">(new isDropping state value)</param>
    /// <param name="event">(the event trigger dropping state change which can be dragenter, dragleave etc)</param>
    abstract _updateDroppingState: newValue: obj * ``event``: obj -> unit

type [<AllowNullLiteral>] DetailsRowStatic =
    [<Emit "new $0($1...)">] abstract Create: props: IDetailsRowProps -> DetailsRow
type BaseComponent = ______Utilities.BaseComponent
type ITooltipProps = __Tooltip_types.ITooltipProps

type [<AllowNullLiteral>] IExports =
    abstract TooltipBase: TooltipBaseStatic

type [<AllowNullLiteral>] TooltipBase =
    inherit BaseComponent<ITooltipProps, obj option>
    abstract defaultProps: obj with get, set
    abstract _classNames: obj with get, set
    abstract render: unit -> JSX.Element
    abstract _onRenderContent: obj with get, set

type [<AllowNullLiteral>] TooltipBaseStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> TooltipBase
type TooltipBase = __Tooltip_base.TooltipBase
type ICalloutProps = ______Callout.ICalloutProps
type IRenderFunction = ______Utilities.IRenderFunction
type DirectionalHint = ______common_DirectionalHint.DirectionalHint
type IStyle = ______Styling.IStyle
type ITheme = ______Styling.ITheme
type IStyleFunction = ______Utilities.IStyleFunction

type [<AllowNullLiteral>] ITooltip =
    interface end

/// Tooltip component props.
type [<AllowNullLiteral>] ITooltipProps =
    inherit React.HTMLAttributes<U2<HTMLDivElement, TooltipBase>>
    /// Optional callback to access the ITooltip interface. Use this instead of ref for accessing
    /// the public methods and properties of the component.
    abstract componentRef: (ITooltip option -> unit) option with get, set
    /// Properties to pass through for Callout, reference detail properties in ICalloutProps
    abstract calloutProps: ICalloutProps option with get, set
    /// String to be passed to the tooltip
    abstract content: string option with get, set
    /// Render function to populate content area
    abstract onRenderContent: IRenderFunction<ITooltipProps> option with get, set
    /// Length of delay. Can be set to zero if you do not want a delay.
    abstract delay: TooltipDelay option with get, set
    /// Max width of tooltip
    abstract maxWidth: string option with get, set
    /// Element to anchor the Tooltip to.
    abstract targetElement: HTMLElement option with get, set
    /// Indicator of how the tooltip should be anchored to its targetElement.
    abstract directionalHint: DirectionalHint option with get, set
    /// How the element should be positioned in RTL layouts.
    /// If not specified, a mirror of `directionalHint` will be used instead
    abstract directionalHintForRTL: DirectionalHint option with get, set
    /// Theme to apply to the component.
    abstract theme: ITheme option with get, set
    /// Call to provide customized styling that will layer on top of the variant rules.
    abstract getStyles: IStyleFunction<ITooltipStyleProps, ITooltipStyles> option with get, set

type [<RequireQualifiedAccess>] TooltipDelay =
    | Zero = 0
    | Medium = 1
    | Long = 2

type [<AllowNullLiteral>] ITooltipStyleProps =
    /// Accept theme prop.
    abstract theme: ITheme with get, set
    /// Accept custom classNames
    abstract className: string option with get, set
    /// Delay before tooltip appears.
    abstract delay: TooltipDelay option with get, set
    /// Maximum width of tooltip.
    abstract maxWidth: string option with get, set

type [<AllowNullLiteral>] ITooltipStyles =
    /// Style for the root element.
    abstract root: IStyle with get, set
    /// Style for the content element.
    abstract content: IStyle with get, set
    /// Style for the subtext element.
    abstract subText: IStyle with get, set
type TooltipHost = __TooltipHost.TooltipHost
type TooltipDelay = __Tooltip_types.TooltipDelay
type ITooltipProps = __Tooltip_types.ITooltipProps
type ICalloutProps = ______Callout.ICalloutProps
type DirectionalHint = ______common_DirectionalHint.DirectionalHint

type [<AllowNullLiteral>] ITooltipHost =
    interface end

type [<RequireQualifiedAccess>] TooltipOverflowMode =
    | Parent = 0
    | Self = 1

/// Tooltip component props.
type [<AllowNullLiteral>] ITooltipHostProps =
    inherit React.HTMLAttributes<U2<HTMLDivElement, TooltipHost>>
    /// Optional callback to access the ITooltipHost interface. Use this instead of ref for accessing
    /// the public methods and properties of the component.
    abstract componentRef: (ITooltipHost option -> unit) option with get, set
    /// Additional properties to pass through for Callout, reference detail properties in ICalloutProps
    abstract calloutProps: ICalloutProps option with get, set
    /// Additional properties to pass through for Tooltip, reference detail properties in ITooltipProps
    abstract tooltipProps: ITooltipProps option with get, set
    /// Whether or not to mark the container as described by the tooltip.
    /// If not specified, the caller should mark as element as described by the tooltip id.
    abstract setAriaDescribedBy: bool option with get, set
    /// Length of delay
    abstract delay: TooltipDelay option with get, set
    /// String to be passed to the tooltip
    abstract content: string option with get, set
    /// Indicator of how the tooltip should be anchored to its targetElement.
    abstract directionalHint: DirectionalHint option with get, set
    /// How the element should be positioned in RTL layouts.
    /// If not specified, a mirror of `directionalHint` will be used instead
    abstract directionalHintForRTL: DirectionalHint option with get, set
    /// Only show if there is overflow. If set, the tooltip hosts observes  and only shows the tooltip if this element has overflow.
    /// It also uses the parent as target element for the tooltip.
    abstract overflowMode: TooltipOverflowMode option with get, set
    /// Optional class name to apply to tooltip host.
    abstract hostClassName: string option with get, set
    /// Optionally a number of milliseconds to delay closing the tooltip, so that
    /// the user has time to hover over the tooltip and interact with it. Hovering
    /// over the tooltip will count as hovering over the host, so that the tooltip
    /// will stay open if the user is actively interacting with it.
    abstract closeDelay: float option with get, set
    /// Notifies when tooltip becomes visible or hidden, whatever the trigger was.
    abstract onTooltipToggle: isTooltipVisible: bool -> unit
type BaseComponent = ______Utilities.BaseComponent
type ITooltipHostProps = __TooltipHost_types.ITooltipHostProps
type TooltipDelay = __Tooltip_types.TooltipDelay

type [<AllowNullLiteral>] IExports =
    abstract TooltipHost: TooltipHostStatic

type [<AllowNullLiteral>] ITooltipHostState =
    abstract isTooltipVisible: bool with get, set

type [<AllowNullLiteral>] TooltipHost =
    inherit BaseComponent<ITooltipHostProps, ITooltipHostState>
    abstract defaultProps: obj with get, set
    abstract _tooltipHost: obj with get, set
    abstract _closingTimer: obj with get, set
    abstract render: unit -> JSX.Element
    abstract _getTargetElement: unit -> unit
    abstract _onTooltipMouseEnter: obj with get, set
    abstract _onTooltipMouseLeave: obj with get, set
    abstract _clearDismissTimer: obj with get, set
    abstract _hideTooltip: obj with get, set
    abstract _toggleTooltip: isTooltipVisible: obj -> unit

type [<AllowNullLiteral>] TooltipHostStatic =
    [<Emit "new $0($1...)">] abstract Create: props: ITooltipHostProps -> TooltipHost
type BaseComponent = ______Utilities.BaseComponent
type IRenderFunction = ______Utilities.IRenderFunction
type IColumn = __DetailsList_types.IColumn
type DetailsListLayoutMode = __DetailsList_types.DetailsListLayoutMode
type IColumnReorderOptions = __DetailsList_types.IColumnReorderOptions
type CollapseAllVisibility = ______GroupedList.CollapseAllVisibility
type ITooltipHostProps = ______Tooltip.ITooltipHostProps
type ISelection = ______utilities_selection_interfaces.ISelection
type SelectionMode = ______utilities_selection_interfaces.SelectionMode

type [<AllowNullLiteral>] IExports =
    abstract DetailsHeader: DetailsHeaderStatic

type [<AllowNullLiteral>] IDetailsHeader =
    abstract focus: (unit -> bool) with get, set

type [<AllowNullLiteral>] IDetailsHeaderProps =
    inherit React.Props<DetailsHeader>
    abstract componentRef: (IDetailsHeader option -> unit) option with get, set
    abstract columns: ResizeArray<IColumn> with get, set
    abstract selection: ISelection with get, set
    abstract selectionMode: SelectionMode with get, set
    abstract layoutMode: DetailsListLayoutMode with get, set
    abstract onColumnIsSizingChanged: (IColumn -> bool -> unit) option with get, set
    abstract onColumnResized: (IColumn -> float -> float -> unit) option with get, set
    abstract onColumnAutoResized: (IColumn -> float -> unit) option with get, set
    abstract onColumnClick: (React.MouseEvent<HTMLElement> -> IColumn -> unit) option with get, set
    abstract onColumnContextMenu: (IColumn -> React.MouseEvent<HTMLElement> -> unit) option with get, set
    abstract onRenderColumnHeaderTooltip: IRenderFunction<ITooltipHostProps> option with get, set
    abstract groupNestingDepth: float option with get, set
    abstract collapseAllVisibility: CollapseAllVisibility option with get, set
    abstract isAllCollapsed: bool option with get, set
    abstract onToggleCollapseAll: (bool -> unit) option with get, set
    /// ariaLabel for the entire header 
    abstract ariaLabel: string option with get, set
    /// ariaLabel for the header checkbox that selects or deselects everything 
    abstract ariaLabelForSelectAllCheckbox: string option with get, set
    abstract ariaLabelForSelectionColumn: string option with get, set
    abstract selectAllVisibility: SelectAllVisibility option with get, set
    abstract columnReorderOptions: IColumnReorderOptions option with get, set
    abstract minimumPixelsForDrag: float option with get, set

type [<RequireQualifiedAccess>] SelectAllVisibility =
    | None = 0
    | Hidden = 1
    | Visible = 2

type [<AllowNullLiteral>] IDetailsHeaderState =
    abstract columnResizeDetails: IColumnResizeDetails option with get, set
    abstract isAllSelected: bool option with get, set
    abstract isSizing: bool option with get, set
    abstract groupNestingDepth: float option with get, set
    abstract isAllCollapsed: bool option with get, set

type [<AllowNullLiteral>] IColumnResizeDetails =
    abstract columnIndex: float with get, set
    abstract originX: float option with get, set
    abstract columnMinWidth: float with get, set

type [<AllowNullLiteral>] IDropHintDetails =
    abstract originX: float with get, set
    abstract startX: float with get, set
    abstract endX: float with get, set
    abstract dropHintElementRef: HTMLElement with get, set

type [<AllowNullLiteral>] DetailsHeader =
    inherit BaseComponent<IDetailsHeaderProps, IDetailsHeaderState>
    inherit IDetailsHeader
    abstract defaultProps: obj with get, set
    abstract _rootElement: obj with get, set
    abstract _rootComponent: obj with get, set
    abstract _id: obj with get, set
    abstract _draggedColumnIndex: obj with get, set
    abstract _dropHintDetails: obj with get, set
    abstract _dragDropHelper: obj with get, set
    abstract _currentDropHintIndex: obj with get, set
    abstract _subscriptionObject: obj with get, set
    abstract _onDropIndexInfo: obj with get, set
    abstract componentDidMount: unit -> unit
    abstract componentDidUpdate: prevProps: IDetailsHeaderProps -> unit
    abstract componentWillReceiveProps: newProps: IDetailsHeaderProps -> unit
    abstract componentWillUnmount: unit -> unit
    abstract render: unit -> JSX.Element
    /// Set focus to the active thing in the focus area. 
    abstract focus: unit -> bool
    abstract _getHeaderDragDropOptions: unit -> unit
    abstract _updateDroppingState: newValue: obj * ``event``: obj -> unit
    abstract _isValidCurrentDropHintIndex: unit -> unit
    abstract _onDragOver: item: obj * ``event``: obj -> unit
    abstract _onDrop: ?item: obj * ?``event``: obj -> unit
    abstract _setDraggedItemIndex: itemIndex: obj -> unit
    abstract _resetDropHints: unit -> unit
    abstract _updateDropHintElement: element: obj * property: obj -> unit
    abstract _getDropHintPositions: unit -> unit
    /// Based on the given cursor position, finds the nearest drop hint and updates the state to make it visible
    abstract _computeDropHintToBeShown: clientX: obj -> unit
    abstract _renderColumnSizer: columnIndex: obj -> unit
    abstract _renderDropHint: dropHintIndex: obj -> unit
    abstract _onRenderColumnHeaderTooltip: obj with get, set
    /// <summary>double click on the column sizer will auto ajust column width
    /// to fit the longest content among current rendered rows.</summary>
    /// <param name="columnIndex">(index of the column user double clicked)</param>
    /// <param name="ev">(mouse double click event)</param>
    abstract _onSizerDoubleClick: columnIndex: obj * ev: obj -> unit
    /// Called when the select all toggle is clicked.
    abstract _onSelectAllClicked: obj with get, set
    abstract _onRootMouseDown: obj with get, set
    abstract _onRootMouseMove: obj with get, set
    abstract _onRootRef: obj with get, set
    abstract _onRootKeyDown: obj with get, set
    /// mouse move event handler in the header
    /// it will set isSizing state to true when user clicked on the sizer and move the mouse.
    abstract _onSizerMouseMove: obj with get, set
    abstract _onSizerBlur: obj with get, set
    /// mouse up event handler in the header
    /// clear the resize related state.
    /// This is to ensure we can catch double click event
    abstract _onSizerMouseUp: obj with get, set
    abstract _onSelectionChanged: unit -> unit
    abstract _onToggleCollapseAll: unit -> unit

type [<AllowNullLiteral>] DetailsHeaderStatic =
    [<Emit "new $0($1...)">] abstract Create: props: IDetailsHeaderProps -> DetailsHeader
type DetailsList = __DetailsList.DetailsList
type ISelection = ______utilities_selection_index.ISelection
type SelectionMode = ______utilities_selection_index.SelectionMode
type ISelectionZoneProps = ______utilities_selection_index.ISelectionZoneProps
type IRenderFunction = ______Utilities.IRenderFunction
type IDragDropEvents = ________utilities_dragdrop_index.IDragDropEvents
type IDragDropContext = ________utilities_dragdrop_index.IDragDropContext
type IGroup = ___GroupedList_index.IGroup
type IGroupRenderProps = ___GroupedList_index.IGroupRenderProps
type IDetailsRowProps = ___DetailsList_DetailsRow.IDetailsRowProps
type IDetailsHeaderProps = __DetailsHeader.IDetailsHeaderProps
type IWithViewportProps = ______utilities_decorators_withViewport.IWithViewportProps
type IViewport = ______utilities_decorators_withViewport.IViewport
type IList = ___List_index.IList
type IListProps = ___List_index.IListProps
type ScrollToMode = ___List_index.ScrollToMode

type [<AllowNullLiteral>] IDetailsList =
    inherit IList
    /// Ensures that the list content is updated. Call this in cases where the list prop updates don't change, but the list
    /// still needs to be re-evaluated. For example, if a sizer bar is adjusted and causes the list width to change, you can
    /// call this to force a re-evaluation. Be aware that this can be an expensive operation and should be done sparingly.
    abstract forceUpdate: (unit -> unit) with get, set
    /// Scroll to and focus the item at the given index. focusIndex will call scrollToIndex on the specified index.
    abstract focusIndex: (float -> bool -> (float -> float) -> ScrollToMode -> unit) with get, set

type [<AllowNullLiteral>] IDetailsListProps =
    inherit React.Props<DetailsList>
    inherit IWithViewportProps
    /// Optional callback to access the IDetailsList interface. Use this instead of ref for accessing
    /// the public methods and properties of the component.
    abstract componentRef: (IDetailsList option -> unit) option with get, set
    /// A key that uniquely identifies the given items. If provided, the selection will be reset when the key changes. 
    abstract setKey: string option with get, set
    /// The items to render. 
    abstract items: ResizeArray<obj option> with get, set
    /// Optional properties to pass through to the list components being rendered. 
    abstract listProps: IListProps option with get, set
    /// Optional default focused index to set focus to once the items have rendered and the index exists.
    abstract initialFocusedIndex: float option with get, set
    /// Optional class name to add to the root element. 
    abstract className: string option with get, set
    /// Optional grouping instructions. The definition for IGroup can be found under the GroupedList component. 
    abstract groups: ResizeArray<IGroup> option with get, set
    /// Optional override properties to render groups. The definition for IGroupRenderProps can be found under the GroupedList component. 
    abstract groupProps: IGroupRenderProps option with get, set
    /// Optional selection model to track selection state.  
    abstract selection: ISelection option with get, set
    /// Controls how/if the details list manages selection. Options include none, single, multiple 
    abstract selectionMode: SelectionMode option with get, set
    /// By default, selection is cleared when clicking on an empty (non-focusable) section of the screen. Setting this value to true
    /// overrides that behavior and maintains selection.
    abstract selectionPreservedOnEmptyClick: bool option with get, set
    /// Addition props to pass through to the selection zone created by default.
    abstract selectionZoneProps: ISelectionZoneProps option with get, set
    /// Controls how the columns are adjusted. 
    abstract layoutMode: DetailsListLayoutMode option with get, set
    /// Controls the visibility of selection check box.
    abstract checkboxVisibility: CheckboxVisibility option with get, set
    /// Controls the visibility of the details header.
    abstract isHeaderVisible: bool option with get, set
    /// Given column defitions. If none are provided, default columns will be created based on the item's properties. 
    abstract columns: ResizeArray<IColumn> option with get, set
    /// Controls how the list contrains overflow. 
    abstract constrainMode: ConstrainMode option with get, set
    /// Event names and corresponding callbacks that will be registered to rendered row elements. 
    abstract rowElementEventMap: ResizeArray<obj> option with get, set
    /// Callback for when the details list has been updated. Useful for telemetry tracking externally. 
    abstract onDidUpdate: (DetailsList -> obj option) option with get, set
    /// Callback for when a given row has been mounted. Useful for identifying when a row has been rendered on the page. 
    abstract onRowDidMount: (obj option -> float -> unit) option with get, set
    /// Callback for when a given row has been mounted. Useful for identifying when a row has been removed from the page. 
    abstract onRowWillUnmount: (obj option -> float -> unit) option with get, set
    /// Callback for when the user clicks on the column header. 
    abstract onColumnHeaderClick: (React.MouseEvent<HTMLElement> -> IColumn -> unit) option with get, set
    /// Callback for when the user asks for a contextual menu (usually via right click) from a column header. 
    abstract onColumnHeaderContextMenu: (IColumn -> React.MouseEvent<HTMLElement> -> unit) option with get, set
    /// Callback fired on column resize 
    abstract onColumnResize: (IColumn -> float -> float -> unit) option with get, set
    /// Callback for when a given row has been invoked (by pressing enter while it is selected.) 
    abstract onItemInvoked: (obj option -> float -> Event -> unit) option with get, set
    /// Callback for when the context menu of an item has been accessed. If undefined or false are returned, ev.preventDefault() will be called.
    abstract onItemContextMenu: (obj option -> float -> Event -> U2<unit, bool>) option with get, set
    /// If provided, will allow the caller to override the default row rendering.
    abstract onRenderRow: IRenderFunction<IDetailsRowProps> option with get, set
    /// If provided, will be the "default" item column renderer method. This affects cells within the rows; not the rows themselves.
    /// If a column definition provides its own onRender method, that will be used instead of this.
    abstract onRenderItemColumn: (obj option -> float -> IColumn -> obj option) option with get, set
    /// Map of callback functions related to row drag and drop functionality. 
    abstract dragDropEvents: IDragDropEvents option with get, set
    /// Callback for what to render when the item is missing. 
    abstract onRenderMissingItem: (float -> IDetailsRowProps -> React.ReactNode) option with get, set
    /// If set to true and we provide an empty array, it will render 10 lines of whatever provided in onRenderMissingItem.
    abstract enableShimmer: bool option with get, set
    /// An override to render the details header.
    abstract onRenderDetailsHeader: IRenderFunction<IDetailsHeaderProps> option with get, set
    /// Viewport, provided by the withViewport decorator. 
    abstract viewport: IViewport option with get, set
    /// Callback for when an item in the list becomes active by clicking anywhere inside the row or navigating to it with keyboard. 
    abstract onActiveItemChanged: (obj option -> float -> React.FocusEvent<HTMLElement> -> unit) option with get, set
    /// The aria-label attribute to stamp out on the list header 
    abstract ariaLabelForListHeader: string option with get, set
    /// The aria-label attribute to stamp out on select all checkbox for the list 
    abstract ariaLabelForSelectAllCheckbox: string option with get, set
    /// An ARIA label for the name of the selection column, for localization.
    abstract ariaLabelForSelectionColumn: string option with get, set
    /// Optional callback to get the aria-label string for a given item. 
    abstract getRowAriaLabel: (obj option -> string) option with get, set
    /// Optional callback to get the aria-describedby IDs (space separated strings) of the elements that describe the item. 
    abstract getRowAriaDescribedBy: (obj option -> string) option with get, set
    /// Optional callback to get the item key, to be used in the selection and on render. 
    abstract getKey: (obj option -> float -> string) option with get, set
    /// A text summary of the table set via aria-label. 
    abstract ariaLabel: string option with get, set
    /// Check button aria label for details list. 
    abstract checkButtonAriaLabel: string option with get, set
    /// Aria label for grid in details list. 
    abstract ariaLabelForGrid: string option with get, set
    /// Boolean value to indicate if the role application should be applied on details list. Set to false by default 
    abstract shouldApplyApplicationRole: bool option with get, set
    /// The minimum mouse move distance to interpret the action as drag event.
    abstract minimumPixelsForDrag: float option with get, set
    /// Boolean value to indicate if the component should render in compact mode. Set to false by default 
    abstract compact: bool option with get, set
    /// Boolean value to enable render page caching. This is an experimental performance optimization
    /// that is off by default.
    abstract usePageCache: bool option with get, set
    /// Optional callback to determine whether the list should be rendered in full, or virtualized.
    /// Virtualization will add and remove pages of items as the user scrolls them into the visible range.
    /// This benefits larger list scenarios by reducing the DOM on the screen, but can negatively affect performance for smaller lists.
    /// The default implementation will virtualize when this callback is not provided.
    abstract onShouldVirtualize: (IListProps -> bool) option with get, set
    /// Optional class name to add to the cell of a checkbox
    abstract checkboxCellClassName: string option with get, set
    /// Whether or not the selection zone should enter modal state on touch.
    abstract enterModalSelectionOnTouch: bool option with get, set
    /// Options for column re-order using drag and drop
    abstract columnReorderOptions: IColumnReorderOptions option with get, set

type [<AllowNullLiteral>] IColumn =
    /// A unique key for identifying the column.
    abstract key: string with get, set
    /// Name to render on the column header.
    abstract name: string with get, set
    /// The field to pull the text value from for the column. This can be null if a custom
    /// onRender method is provided.
    abstract fieldName: string with get, set
    /// An optional class name to stick on the column cell within each row.
    abstract className: string option with get, set
    /// Minimum width for the column.
    abstract minWidth: float with get, set
    /// Optional accessibility label (aria-label) attribute that will be stamped on to the element.
    /// If none is specified, the arai-label attribute will contain the column name
    abstract ariaLabel: string option with get, set
    /// Optional flag on whether the column is a header for the given row. There should be only one column with
    /// row header set to true.
    abstract isRowHeader: bool option with get, set
    /// Maximum width for the column, if stretching is allowed in justified scenarios.
    abstract maxWidth: float option with get, set
    /// Defines how the column's header should render.
    abstract columnActionsMode: ColumnActionsMode option with get, set
    /// Optional iconName to use for the column header.
    abstract iconName: string option with get, set
    /// Whether or not only the icon is used in the column header.
    /// Set this to true so the column name and dropdown chevron are not displayed.
    abstract isIconOnly: bool option with get, set
    /// Class name to add to the Icon component.
    abstract iconClassName: string option with get, set
    /// If specified will allow the column to be collapsed when rendered in justified layout.
    abstract isCollapsable: bool option with get, set
    /// Determines if the column is currently sorted. Renders a sort arrow in the column header.
    abstract isSorted: bool option with get, set
    /// Determines if the arrow is pointed down (descending) or up.
    abstract isSortedDescending: bool option with get, set
    /// Determines if the column can be resized.
    abstract isResizable: bool option with get, set
    /// Determines if the column can render multi-line text.
    abstract isMultiline: bool option with get, set
    /// If provided uses this method to render custom cell content, rather than the default text rendering.
    abstract onRender: (obj option -> float -> IColumn -> obj option) option with get, set
    /// Determines if the column is filtered, and if so shows a filter icon.
    abstract isFiltered: bool option with get, set
    /// If provided, will be executed when the user clicks on the column header.
    abstract onColumnClick: (React.MouseEvent<HTMLElement> -> IColumn -> obj option) option with get, set
    /// If provided, will be executed when the user accesses the contextmenu on a column header.
    abstract onColumnContextMenu: (IColumn -> React.MouseEvent<HTMLElement> -> obj option) option with get, set
    /// If set will show a grouped icon next to the column header name.
    abstract isGrouped: bool option with get, set
    /// Arbitrary data passthrough which can be used by the caller.
    abstract data: obj option with get, set
    /// Internal only value.
    abstract calculatedWidth: float option with get, set
    /// Internal only value.
    /// Remembers the actual witdh of the column on any case.
    /// On the other hand, calculatedWidth is only saved when it's defined by user, not for justified calculations.
    abstract currentWidth: float option with get, set
    /// An optional class name to stick on the column cell within each header.
    abstract headerClassName: string option with get, set
    /// If set, will add additional LTR padding-right to column and cells.
    abstract isPadded: bool option with get, set

type [<RequireQualifiedAccess>] ColumnActionsMode =
    | Disabled = 0
    | Clickable = 1
    | HasDropdown = 2

type [<RequireQualifiedAccess>] ConstrainMode =
    | Unconstrained = 0
    | HorizontalConstrained = 1

type [<AllowNullLiteral>] IColumnReorderOptions =
    /// Specifies the number fixed columns from left(0th index)
    abstract frozenColumnCountFromStart: float option with get, set
    /// Specifies the number fixed columns from right
    abstract frozenColumnCountFromEnd: float option with get, set
    /// Callback to handle the column reorder
    /// draggedIndex is the source column index, that need to be placed in targetIndex
    abstract handleColumnReorder: (float -> float -> unit) with get, set

type [<RequireQualifiedAccess>] DetailsListLayoutMode =
    | FixedColumns = 0
    | Justified = 1

type [<RequireQualifiedAccess>] CheckboxVisibility =
    | OnHover = 0
    | Always = 1
    | Hidden = 2
type BaseComponent = ______Utilities.BaseComponent
type CheckboxVisibility = ___DetailsList_DetailsList_types.CheckboxVisibility
type ConstrainMode = ___DetailsList_DetailsList_types.ConstrainMode
type DetailsListLayoutMode = ___DetailsList_DetailsList_types.DetailsListLayoutMode
type IColumn = ___DetailsList_DetailsList_types.IColumn
type IDetailsList = ___DetailsList_DetailsList_types.IDetailsList
type IDetailsListProps = ___DetailsList_DetailsList_types.IDetailsListProps
type IDetailsRowProps = ___DetailsList_DetailsRow.IDetailsRowProps
type SelectionMode = ______utilities_selection_index.SelectionMode
type ScrollToMode = ______List.ScrollToMode

type [<AllowNullLiteral>] IExports =
    abstract DetailsList: DetailsListStatic
    abstract buildColumns: items: ResizeArray<obj option> * ?canResizeColumns: bool * ?onColumnClick: (React.MouseEvent<HTMLElement> -> IColumn -> obj option) * ?sortedColumnKey: string * ?isSortedDescending: bool * ?groupedColumnKey: string * ?isMultiline: bool -> ResizeArray<IColumn>

type [<AllowNullLiteral>] IDetailsListState =
    abstract focusedItemIndex: float with get, set
    abstract lastWidth: float option with get, set
    abstract lastSelectionMode: SelectionMode option with get, set
    abstract adjustedColumns: ResizeArray<IColumn> option with get, set
    abstract isCollapsed: bool option with get, set
    abstract isSizing: bool option with get, set
    abstract isDropping: bool option with get, set
    abstract isSomeGroupExpanded: bool option with get, set

type [<AllowNullLiteral>] DetailsList =
    inherit BaseComponent<IDetailsListProps, IDetailsListState>
    inherit IDetailsList
    abstract defaultProps: obj with get, set
    abstract _root: obj with get, set
    abstract _header: obj with get, set
    abstract _groupedList: obj with get, set
    abstract _list: obj with get, set
    abstract _focusZone: obj with get, set
    abstract _selectionZone: obj with get, set
    abstract _selection: obj with get, set
    abstract _activeRows: obj with get, set
    abstract _dragDropHelper: obj with get, set
    abstract _initialFocusedIndex: obj with get, set
    abstract _pendingForceUpdate: obj with get, set
    abstract _columnOverrides: obj with get, set
    abstract scrollToIndex: index: float * ?measureItem: (float -> float) * ?scrollToMode: ScrollToMode -> unit
    abstract focusIndex: index: float * ?forceIntoFirstElement: bool * ?measureItem: (float -> float) * ?scrollToMode: ScrollToMode -> unit
    abstract componentWillUnmount: unit -> unit
    abstract componentDidUpdate: prevProps: obj option * prevState: obj option -> unit
    abstract componentWillReceiveProps: newProps: IDetailsListProps -> unit
    abstract componentWillUpdate: unit -> unit
    abstract render: unit -> JSX.Element
    abstract forceUpdate: unit -> unit
    abstract _onRenderRow: (IDetailsRowProps -> obj option -> JSX.Element) with get, set
    abstract _onRenderDetailsHeader: obj with get, set
    abstract _onRenderListCell: obj with get, set
    abstract _onRenderCell: nestingDepth: obj * item: obj * index: obj -> unit
    abstract _onGroupExpandStateChanged: isSomeGroupExpanded: obj -> unit
    abstract _onColumnIsSizingChanged: column: obj * isSizing: obj -> unit
    abstract _onHeaderKeyDown: ev: obj -> unit
    abstract _onContentKeyDown: ev: obj -> unit
    abstract _getGroupNestingDepth: unit -> unit
    abstract _onRowDidMount: row: obj -> unit
    abstract _setFocusToRowIfPending: row: obj -> unit
    abstract _setFocusToRow: row: obj * ?forceIntoFirstElement: obj -> unit
    abstract _onRowWillUnmount: row: obj -> unit
    abstract _onToggleCollapse: collapsed: obj -> unit
    abstract _forceListUpdates: unit -> unit
    abstract _adjustColumns: newProps: obj * ?forceUpdate: obj * ?resizingColumnIndex: obj -> unit
    /// Returns adjusted columns, given the viewport size and layout mode. 
    abstract _getAdjustedColumns: newProps: obj * ?forceUpdate: obj * ?resizingColumnIndex: obj -> unit
    /// Builds a set of columns based on the given columns mixed with the current overrides. 
    abstract _getFixedColumns: newColumns: obj -> unit
    abstract _getJustifiedColumnsAfterResize: newColumns: obj * viewportWidth: obj * props: obj * resizingColumnIndex: obj -> unit
    /// Builds a set of columns to fix within the viewport width. 
    abstract _getJustifiedColumns: newColumns: obj * viewportWidth: obj * props: obj * firstIndex: obj -> unit
    abstract _onColumnResized: resizingColumn: obj * newWidth: obj * resizingColumnIndex: obj -> unit
    abstract _rememberCalculatedWidth: column: obj * newCalculatedWidth: obj -> unit
    abstract _getColumnOverride: key: obj -> unit
    /// <summary>Callback function when double clicked on the details header column resizer
    /// which will measure the column cells of all the active rows and resize the
    /// column to the max cell width.</summary>
    /// <param name="column">(double clicked column definition)</param>
    /// <param name="columnIndex">(double clicked column index)</param>
    abstract _onColumnAutoResized: column: obj * columnIndex: obj -> unit
    /// Call back function when an element in FocusZone becomes active. It will transalate it into item
    /// and call onActiveItemChanged callback if specified.
    abstract _onActiveRowChanged: ?el: obj * ?ev: obj -> unit
    abstract _onBlur: ``event``: obj -> unit
    abstract _getItemKey: item: obj * itemIndex: obj -> unit

type [<AllowNullLiteral>] DetailsListStatic =
    [<Emit "new $0($1...)">] abstract Create: props: IDetailsListProps -> DetailsList

type [<AllowNullLiteral>] IAccessiblePopupProps =
    /// Sets the HTMLElement to focus on when exiting the FocusTrapZone.
    abstract elementToFocusOnDismiss: HTMLElement option with get, set
    /// Indicates if this dialog will ignore keeping track of HTMLElement that activated the Zone.
    abstract ignoreExternalFocusing: bool option with get, set
    /// Indicates whether dialog should force focus inside the focus trap zone
    abstract forceFocusInsideTrap: bool option with get, set
    /// Indicates the selector for first focusable item
    abstract firstFocusableSelector: U2<string, (unit -> string)> option with get, set
    /// Aria label on close button
    abstract closeButtonAriaLabel: string option with get, set
    /// Indicates if this dialog will allow clicks outside the FocusTrapZone
    abstract isClickableOutsideFocusTrap: bool option with get, set
type Modal = __Modal.Modal
type IWithResponsiveModeState = ______utilities_decorators_withResponsiveMode.IWithResponsiveModeState
type IAccessiblePopupProps = ______common_IAccessiblePopupProps.IAccessiblePopupProps

type [<AllowNullLiteral>] IModal =
    /// Sets focus on the first focusable, or configured, child in focus trap zone
    abstract focus: (unit -> unit) with get, set

type [<AllowNullLiteral>] IModalProps =
    inherit React.Props<Modal>
    inherit IWithResponsiveModeState
    inherit IAccessiblePopupProps
    /// Optional callback to access the IDialog interface. Use this instead of ref for accessing
    /// the public methods and properties of the component.
    abstract componentRef: (IModal option -> unit) option with get, set
    /// Whether the dialog is displayed.
    abstract isOpen: bool option with get, set
    /// Whether the overlay is dark themed.
    abstract isDarkOverlay: bool option with get, set
    /// A callback function for when the Modal is dismissed light dismiss, before the animation completes.
    abstract onDismiss: (React.MouseEvent<HTMLButtonElement> -> obj option) option with get, set
    /// A callback function which is called after the Modal is dismissed and the animation is complete.
    abstract onDismissed: (unit -> obj option) option with get, set
    /// Whether the dialog can be light dismissed by clicking outside the dialog (on the overlay).
    abstract isBlocking: bool option with get, set
    /// Optional class name to be added to the root class
    abstract className: string option with get, set
    /// Optional override for container class
    abstract containerClassName: string option with get, set
    /// A callback function for when the Modal content is mounted on the overlay layer
    abstract onLayerDidMount: (unit -> unit) option with get, set
    /// ARIA id for the title of the Modal, if any
    abstract titleAriaId: string option with get, set
    /// ARIA id for the subtitle of the Modal, if any
    abstract subtitleAriaId: string option with get, set
type BaseComponent = ______Utilities.BaseComponent
type IModalProps = __Modal_types.IModalProps
type IModal = __Modal_types.IModal

type [<AllowNullLiteral>] IExports =
    abstract Modal: ModalStatic

type [<AllowNullLiteral>] IDialogState =
    abstract isOpen: bool option with get, set
    abstract isVisible: bool option with get, set
    abstract isVisibleClose: bool option with get, set
    abstract id: string option with get, set

type [<AllowNullLiteral>] Modal =
    inherit BaseComponent<IModalProps, IDialogState>
    inherit IModal
    abstract defaultProps: IModalProps with get, set
    abstract _onModalCloseTimer: obj with get, set
    abstract _focusTrapZone: obj with get, set
    abstract componentWillReceiveProps: newProps: IModalProps -> unit
    abstract componentDidUpdate: prevProps: IModalProps * prevState: IDialogState -> unit
    abstract render: unit -> JSX.Element option
    abstract focus: unit -> unit
    abstract _onModalClose: unit -> unit

type [<AllowNullLiteral>] ModalStatic =
    [<Emit "new $0($1...)">] abstract Create: props: IModalProps -> Modal
type BaseComponent = ______Utilities.BaseComponent
type IDialogProps = __Dialog_types.IDialogProps

type [<AllowNullLiteral>] IExports =
    abstract DialogBase: DialogBaseStatic

type [<AllowNullLiteral>] DialogBase =
    inherit BaseComponent<IDialogProps, obj>
    abstract defaultProps: IDialogProps with get, set
    abstract _id: obj with get, set
    abstract _defaultTitleTextId: obj with get, set
    abstract _defaultSubTextId: obj with get, set
    abstract render: unit -> JSX.Element
    abstract _getSubTextId: obj with get, set
    abstract _getTitleTextId: obj with get, set

type [<AllowNullLiteral>] DialogBaseStatic =
    [<Emit "new $0($1...)">] abstract Create: props: IDialogProps -> DialogBase
type BaseComponent = ______Utilities.BaseComponent
type IDialogContentProps = __DialogContent_types.IDialogContentProps

type [<AllowNullLiteral>] IExports =
    abstract DialogContentBase: DialogContentBaseStatic

type [<AllowNullLiteral>] DialogContentBase =
    inherit BaseComponent<IDialogContentProps, obj>
    abstract defaultProps: IDialogContentProps with get, set
    abstract render: unit -> JSX.Element
    abstract _groupChildren: unit -> unit

type [<AllowNullLiteral>] DialogContentBaseStatic =
    [<Emit "new $0($1...)">] abstract Create: props: IDialogContentProps -> DialogContentBase
type DialogContentBase = __DialogContent_base.DialogContentBase
type IButtonProps = ___Button_Button_types.IButtonProps
type ResponsiveMode = ______utilities_decorators_withResponsiveMode.ResponsiveMode
type IStyle = ______Styling.IStyle
type ITheme = ______Styling.ITheme
type IStyleFunction = ______Utilities.IStyleFunction

type [<AllowNullLiteral>] IDialogContent =
    interface end

type [<AllowNullLiteral>] IDialogContentProps =
    inherit React.Props<DialogContentBase>
    /// Optional callback to access the IDialogContent interface. Use this instead of ref for accessing
    /// the public methods and properties of the component.
    abstract componentRef: (IDialogContent option -> unit) option with get, set
    /// Call to provide customized styling that will layer on top of the variant rules
    abstract getStyles: IStyleFunction<IDialogContentStyleProps, IDialogContentStyles> option with get, set
    /// Theme provided by HOC.
    abstract theme: ITheme option with get, set
    /// Is inside a multiline wrapper
    abstract isMultiline: bool option with get, set
    /// Show an 'x' close button in the upper-right corner
    abstract showCloseButton: bool option with get, set
    /// Other top buttons that will show up next to the close button
    abstract topButtonsProps: ResizeArray<IButtonProps> option with get, set
    /// Optional override class name
    abstract className: string option with get, set
    /// A callback function for when the Dialog is dismissed from the close button or light dismiss, before the animation completes.
    abstract onDismiss: (React.MouseEvent<HTMLButtonElement> -> obj option) option with get, set
    /// The Id for subText container
    abstract subTextId: string option with get, set
    /// The subtext to display in the dialog
    abstract subText: string option with get, set
    /// The Id for title container
    abstract titleId: string option with get, set
    /// The title text to display at the top of the dialog.
    abstract title: string option with get, set
    /// Responsive mode passed in from decorator.
    abstract responsiveMode: ResponsiveMode option with get, set
    /// Label to be passed to to aria-label of close button
    abstract closeButtonAriaLabel: string option with get, set
    /// The type of Dialog to display.
    abstract ``type``: DialogType option with get, set

type [<RequireQualifiedAccess>] DialogType =
    | Normal = 0
    | LargeHeader = 1
    | Close = 2

type [<AllowNullLiteral>] IDialogContentStyleProps =
    /// Accept theme prop.
    abstract theme: ITheme with get, set
    /// Accept custom classNames
    abstract className: string option with get, set
    abstract isLargeHeader: bool option with get, set
    abstract isClose: bool option with get, set
    abstract hidden: bool option with get, set
    /// Is inside a multiline wrapper
    abstract isMultiline: bool option with get, set

type [<AllowNullLiteral>] IDialogContentStyles =
    /// Style for the content element.
    abstract content: IStyle with get, set
    abstract subText: IStyle with get, set
    abstract header: IStyle with get, set
    abstract button: IStyle with get, set
    abstract inner: IStyle with get, set
    abstract innerContent: IStyle with get, set
    abstract title: IStyle with get, set
    abstract topButton: IStyle with get, set
type IModalProps = ______Modal.IModalProps
type DialogBase = __Dialog_base.DialogBase
type DialogType = __DialogContent_types.DialogType
type IDialogContentProps = __DialogContent_types.IDialogContentProps
type IButtonProps = ___Button_Button_types.IButtonProps
type IWithResponsiveModeState = ______utilities_decorators_withResponsiveMode.IWithResponsiveModeState
type IAccessiblePopupProps = ______common_IAccessiblePopupProps.IAccessiblePopupProps
type IStyle = ______Styling.IStyle
type ITheme = ______Styling.ITheme
type IStyleFunction = ______Utilities.IStyleFunction

type [<AllowNullLiteral>] IDialog =
    interface end

type [<AllowNullLiteral>] IDialogProps =
    inherit React.Props<DialogBase>
    inherit IWithResponsiveModeState
    inherit IAccessiblePopupProps
    /// Optional callback to access the IDialog interface. Use this instead of ref for accessing
    /// the public methods and properties of the component.
    abstract componentRef: (IDialog option -> unit) option with get, set
    /// Call to provide customized styling that will layer on top of the variant rules
    abstract getStyles: IStyleFunction<IDialogStyleProps, IDialogStyles> option with get, set
    /// Theme provided by HOC.
    abstract theme: ITheme option with get, set
    /// Props to be passed through to Dialog Content
    abstract dialogContentProps: IDialogContentProps option with get, set
    /// A callback function for when the Dialog is dismissed from the close button or light dismiss. Can also be specified separately in content and modal.
    abstract onDismiss: (React.MouseEvent<HTMLButtonElement> -> obj option) option with get, set
    /// Whether the dialog is hidden.
    abstract hidden: bool option with get, set
    /// Props to be passed through to Modal
    abstract modalProps: IModalProps option with get, set
    /// Whether the dialog is displayed.
    abstract isOpen: bool option with get, set
    /// Whether the overlay is dark themed.
    abstract isDarkOverlay: bool option with get, set
    /// A callback function which is called after the Dialog is dismissed and the animation is complete.
    abstract onDismissed: (unit -> obj option) option with get, set
    /// Whether the dialog can be light dismissed by clicking outside the dialog (on the overlay).
    abstract isBlocking: bool option with get, set
    /// Optional class name to be added to the root class
    abstract className: string option with get, set
    /// Optional override for container class
    abstract containerClassName: string option with get, set
    /// A callback function for when the Dialog content is mounted on the overlay layer
    abstract onLayerDidMount: (unit -> unit) option with get, set
    /// Deprecated at 0.81.2, use 'onLayerDidMount' instead.
    abstract onLayerMounted: (unit -> unit) option with get, set
    /// The type of Dialog to display.
    abstract ``type``: DialogType option with get, set
    /// The title text to display at the top of the dialog.
    abstract title: string option with get, set
    /// The subtext to display in the dialog.
    abstract subText: string option with get, set
    /// Optional override content class
    abstract contentClassName: string option with get, set
    /// Other top buttons that will show up next to the close button
    abstract topButtonsProps: ResizeArray<IButtonProps> option with get, set
    /// Optional id for aria-LabelledBy
    abstract ariaLabelledById: string option with get, set
    /// Optional id for aria-DescribedBy
    abstract ariaDescribedById: string option with get, set

type [<AllowNullLiteral>] IDialogStyleProps =
    /// Accept theme prop.
    abstract theme: ITheme with get, set
    /// Accept custom classNames
    abstract className: string option with get, set
    /// Optional override for container class
    abstract containerClassName: string option with get, set
    /// Optional override content class
    abstract contentClassName: string option with get, set
    /// Whether the dialog is hidden.
    abstract hidden: bool option with get, set
    /// Default min-width for the dialog box.
    abstract dialogDefaultMinWidth: string option with get, set
    /// Default max-width for the dialog box.
    abstract dialogDefaultMaxWidth: string option with get, set

type [<AllowNullLiteral>] IDialogStyles =
    /// Style for the root element.
    abstract root: IStyle with get, set
    abstract main: IStyle with get, set
type IDialogFooterProps = __DialogFooter_types.IDialogFooterProps
type BaseComponent = ______Utilities.BaseComponent

type [<AllowNullLiteral>] IExports =
    abstract DialogFooterBase: DialogFooterBaseStatic

type [<AllowNullLiteral>] DialogFooterBase =
    inherit BaseComponent<IDialogFooterProps, obj>
    abstract _classNames: obj with get, set
    abstract render: unit -> JSX.Element
    abstract _renderChildrenAsActions: unit -> unit

type [<AllowNullLiteral>] DialogFooterBaseStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> DialogFooterBase
type DialogFooterBase = __DialogFooter_base.DialogFooterBase
type IStyle = ______Styling.IStyle
type ITheme = ______Styling.ITheme
type IStyleFunction = ______Utilities.IStyleFunction

type [<AllowNullLiteral>] IDialogFooterProps =
    inherit React.Props<DialogFooterBase>
    /// Gets the component ref.
    abstract componentRef: (IDialogFooterProps option -> unit) option with get, set
    /// Call to provide customized styling that will layer on top of the variant rules
    abstract getStyles: IStyleFunction<IDialogFooterStyleProps, IDialogFooterStyles> option with get, set
    /// Theme provided by HOC.
    abstract theme: ITheme option with get, set
    /// Optional override class name
    abstract className: string option with get, set

type [<AllowNullLiteral>] IDialogFooterStyleProps =
    /// Accept theme prop.
    abstract theme: ITheme with get, set
    /// Optional override class name
    abstract className: string option with get, set

type [<AllowNullLiteral>] IDialogFooterStyles =
    /// Style for the actions element.
    abstract actions: IStyle with get, set
    abstract actionsRight: IStyle with get, set
    abstract action: IStyle with get, set
type BaseComponent = ______Utilities.BaseComponent
type IDocumentCardTitleProps = __DocumentCard_types.IDocumentCardTitleProps

type [<AllowNullLiteral>] IExports =
    abstract DocumentCardTitle: DocumentCardTitleStatic

type [<AllowNullLiteral>] IDocumentCardTitleState =
    abstract truncatedTitleFirstPiece: string option with get, set
    abstract truncatedTitleSecondPiece: string option with get, set

type [<AllowNullLiteral>] DocumentCardTitle =
    inherit BaseComponent<IDocumentCardTitleProps, IDocumentCardTitleState>
    abstract _titleElement: obj with get, set
    abstract _scrollTimerId: obj with get, set
    abstract _truncatedTitleAtWidth: obj with get, set
    abstract _isTruncated: obj with get, set
    abstract componentDidMount: unit -> unit
    abstract componentWillReceiveProps: newProps: IDocumentCardTitleProps -> unit
    abstract componentDidUpdate: unit -> unit
    abstract render: unit -> JSX.Element
    abstract _startTruncation: obj with get, set
    abstract _shrinkTitle: unit -> unit
    abstract _doesTitleOverflow: unit -> unit
    abstract _updateTruncation: unit -> unit

type [<AllowNullLiteral>] DocumentCardTitleStatic =
    [<Emit "new $0($1...)">] abstract Create: props: IDocumentCardTitleProps -> DocumentCardTitle
type IDocumentCardPreviewProps = __DocumentCard_types.IDocumentCardPreviewProps
type BaseComponent = ______Utilities.BaseComponent

type [<AllowNullLiteral>] IExports =
    abstract DocumentCardPreview: DocumentCardPreviewStatic

type [<AllowNullLiteral>] DocumentCardPreview =
    inherit BaseComponent<IDocumentCardPreviewProps, obj option>
    abstract render: unit -> JSX.Element
    abstract _renderPreviewImage: previewImage: obj -> unit
    abstract _renderPreviewList: obj with get, set

type [<AllowNullLiteral>] DocumentCardPreviewStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> DocumentCardPreview
type BaseComponent = ______Utilities.BaseComponent
type IDocumentCardLocationProps = __DocumentCard_types.IDocumentCardLocationProps

type [<AllowNullLiteral>] IExports =
    abstract DocumentCardLocation: DocumentCardLocationStatic

type [<AllowNullLiteral>] DocumentCardLocation =
    inherit BaseComponent<IDocumentCardLocationProps, obj option>
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] DocumentCardLocationStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> DocumentCardLocation
type BaseComponent = ______Utilities.BaseComponent
type IDocumentCardActivityProps = __DocumentCard_types.IDocumentCardActivityProps

type [<AllowNullLiteral>] IExports =
    abstract DocumentCardActivity: DocumentCardActivityStatic

type [<AllowNullLiteral>] DocumentCardActivity =
    inherit BaseComponent<IDocumentCardActivityProps, obj option>
    abstract render: unit -> JSX.Element option
    abstract _renderAvatars: people: obj -> unit
    abstract _renderAvatar: person: obj -> unit
    abstract _getNameString: people: obj -> unit

type [<AllowNullLiteral>] DocumentCardActivityStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> DocumentCardActivity
type BaseComponent = ______Utilities.BaseComponent
type IDocumentCardActionsProps = __DocumentCard_types.IDocumentCardActionsProps

type [<AllowNullLiteral>] IExports =
    abstract DocumentCardActions: DocumentCardActionsStatic

type [<AllowNullLiteral>] DocumentCardActions =
    inherit BaseComponent<IDocumentCardActionsProps, obj option>
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] DocumentCardActionsStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> DocumentCardActions
type BaseComponent = ______Utilities.BaseComponent
type IDocumentCardLogoProps = __DocumentCard_types.IDocumentCardLogoProps

type [<AllowNullLiteral>] IExports =
    abstract DocumentCardLogo: DocumentCardLogoStatic

type [<AllowNullLiteral>] DocumentCardLogo =
    inherit BaseComponent<IDocumentCardLogoProps, obj option>
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] DocumentCardLogoStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> DocumentCardLogo
type BaseComponent = ______Utilities.BaseComponent
type IDocumentCardStatusProps = __DocumentCard_types.IDocumentCardStatusProps

type [<AllowNullLiteral>] IExports =
    abstract DocumentCardStatus: DocumentCardStatusStatic

type [<AllowNullLiteral>] DocumentCardStatus =
    inherit BaseComponent<IDocumentCardStatusProps, obj option>
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] DocumentCardStatusStatic =
    [<Emit "new $0($1...)">] abstract Create: props: IDocumentCardStatusProps -> DocumentCardStatus
type DocumentCard = __DocumentCard.DocumentCard
type DocumentCardTitle = __DocumentCardTitle.DocumentCardTitle
type DocumentCardPreview = __DocumentCardPreview.DocumentCardPreview
type DocumentCardLocation = __DocumentCardLocation.DocumentCardLocation
type DocumentCardActivity = __DocumentCardActivity.DocumentCardActivity
type DocumentCardActions = __DocumentCardActions.DocumentCardActions
type DocumentCardLogo = __DocumentCardLogo.DocumentCardLogo
type DocumentCardStatus = __DocumentCardStatus.DocumentCardStatus
type PersonaInitialsColor = ______Persona.PersonaInitialsColor
type ImageFit = ______Image.ImageFit
type IButtonProps = ______Button.IButtonProps
type IIconProps = ______Icon.IIconProps

type [<AllowNullLiteral>] IDocumentCard =
    interface end

type [<AllowNullLiteral>] IDocumentCardProps =
    inherit React.Props<DocumentCard>
    /// Optional callback to access the IDocumentCard interface. Use this instead of ref for accessing
    /// the public methods and properties of the component.
    abstract componentRef: (IDocumentCard option -> unit) option with get, set
    /// The type of DocumentCard to display.
    abstract ``type``: DocumentCardType option with get, set
    /// Function to call when the card is clicked or keyboard Enter/Space is pushed.
    abstract onClick: (React.SyntheticEvent<HTMLElement> -> unit) option with get, set
    /// A URL to navigate to when the card is clicked. If a function has also been provided,
    /// it will be used instead of the URL.
    abstract onClickHref: string option with get, set
    /// Optional class for document card.
    abstract className: string option with get, set
    /// Hex color value of the line below the card, which should correspond to the document type.
    /// This should only be supplied when using the 'compact' card layout.
    /// 
    /// Deprecated at v4.17.1, to be removed at >= v5.0.0.
    abstract accentColor: string option with get, set

type [<RequireQualifiedAccess>] DocumentCardType =
    | Normal = 0
    | Compact = 1

type [<AllowNullLiteral>] IDocumentCardPreviewProps =
    inherit React.Props<DocumentCardPreview>
    /// Gets the component ref.
    abstract componentRef: (unit -> unit) option with get, set
    /// One or more preview images to display.
    abstract previewImages: ResizeArray<IDocumentCardPreviewImage> with get, set
    /// The function return string that will describe the number of overflow documents.
    /// such as  (overflowCount: number) => `+${ overflowCount } more`,
    abstract getOverflowDocumentCountText: (float -> string) option with get, set

type [<AllowNullLiteral>] IDocumentCardPreviewImage =
    /// Gets the component ref.
    abstract componentRef: (unit -> unit) option with get, set
    /// File name for the document this preview represents.
    abstract name: string option with get, set
    /// URL to view the file.
    abstract url: string option with get, set
    /// Path to the preview image.
    abstract previewImageSrc: string option with get, set
    /// Deprecated at v1.3.6, to be removed at >= v2.0.0.
    abstract errorImageSrc: string option with get, set
    /// Path to the icon associated with this document type.
    abstract iconSrc: string option with get, set
    /// If provided, forces the preview image to be this width.
    abstract width: float option with get, set
    /// If provided, forces the preview image to be this height.
    abstract height: float option with get, set
    /// Used to determine how to size the image to fit the dimensions of the component.
    /// If both dimensions are provided, then the image is fit using ImageFit.scale, otherwise ImageFit.none is used.
    abstract imageFit: ImageFit option with get, set
    /// Hex color value of the line below the preview, which should correspond to the document type.
    /// 
    /// Deprecated at v4.17.1, to be removed at >= v5.0.0.
    abstract accentColor: string option with get, set
    /// The props for the preview icon.
    /// If provided, icon will be rendered instead of image.
    abstract previewIconProps: IIconProps option with get, set
    /// The props for the preview icon container classname.
    /// If provided, icon container classname will be used..
    abstract previewIconContainerClass: string option with get, set

type [<AllowNullLiteral>] IDocumentCardTitleProps =
    inherit React.Props<DocumentCardTitle>
    /// Gets the component ref.
    abstract componentRef: (unit -> unit) option with get, set
    /// Title text. If the card represents more than one document, this should be the title of one document and a "+X" string. For example, a collection of four documents would have a string of "Document.docx +3".
    abstract title: string with get, set
    /// Whether we truncate the title to fit within the box. May have a performance impact.
    abstract shouldTruncate: bool option with get, set
    /// Whether show as title as secondary title style such as smaller font and lighter color.
    abstract showAsSecondaryTitle: bool option with get, set

type [<AllowNullLiteral>] IDocumentCardLocationProps =
    inherit React.Props<DocumentCardLocation>
    /// Gets the component ref.
    abstract componentRef: (unit -> unit) option with get, set
    /// Text for the location of the document.
    abstract location: string with get, set
    /// URL to navigate to for this location.
    abstract locationHref: string option with get, set
    /// Function to call when the location is clicked.
    abstract onClick: (React.MouseEvent<HTMLElement> -> unit) option with get, set
    /// Aria label for the link to the document location.
    abstract ariaLabel: string option with get, set

type [<AllowNullLiteral>] IDocumentCardActivityProps =
    inherit React.Props<DocumentCardActivity>
    /// Gets the component ref.
    abstract componentRef: (unit -> unit) option with get, set
    /// Describes the activity that has taken place, such as "Created Feb 23, 2016".
    abstract activity: string with get, set
    /// One or more people who are involved in this activity.
    abstract people: ResizeArray<IDocumentCardActivityPerson> with get, set

type [<AllowNullLiteral>] IDocumentCardActivityPerson =
    /// The name of the person.
    abstract name: string with get, set
    /// Path to the profile photo of the person.
    abstract profileImageSrc: string with get, set
    /// The user's initials to display in the profile photo area when there is no image.
    abstract initials: string option with get, set
    /// Whether initials are calculated for phone numbers and number sequences.
    /// Example: Set property to true to get initials for project names consisting of numbers only.
    abstract allowPhoneInitials: bool option with get, set
    /// The background color when the user's initials are displayed.
    abstract initialsColor: PersonaInitialsColor option with get, set

type [<AllowNullLiteral>] IDocumentCardActionsProps =
    inherit React.Props<DocumentCardActions>
    /// Gets the component ref.
    abstract componentRef: (unit -> unit) option with get, set
    /// The actions available for this document.
    abstract actions: ResizeArray<IButtonProps> with get, set
    /// The number of views this document has received.
    abstract views: Number option with get, set

type [<AllowNullLiteral>] IDocumentCardLogoProps =
    inherit React.Props<DocumentCardLogo>
    /// Gets the component ref.
    abstract componentRef: (unit -> unit) option with get, set
    /// Describes DocumentCard Logo badge.
    abstract logoIcon: string with get, set
    /// Describe Logo name, optional.
    abstract logoName: string option with get, set

type [<AllowNullLiteral>] IDocumentCardStatusProps =
    inherit React.Props<DocumentCardStatus>
    /// Gets the component ref.
    abstract componentRef: (unit -> unit) option with get, set
    /// Describes DocumentCard status icon.
    abstract statusIcon: string option with get, set
    /// Describe status information. Required field.
    abstract status: string with get, set
type IDocumentCardProps = __DocumentCard_types.IDocumentCardProps
type BaseComponent = ______Utilities.BaseComponent

type [<AllowNullLiteral>] IExports =
    abstract DocumentCard: DocumentCardStatic

type [<AllowNullLiteral>] DocumentCard =
    inherit BaseComponent<IDocumentCardProps, obj option>
    abstract defaultProps: IDocumentCardProps with get, set
    abstract render: unit -> JSX.Element
    abstract _onClick: obj with get, set
    abstract _onKeyDown: obj with get, set
    abstract _onAction: obj with get, set

type [<AllowNullLiteral>] DocumentCardStatic =
    [<Emit "new $0($1...)">] abstract Create: props: IDocumentCardProps -> DocumentCard
type IRenderFunction = ______Utilities.IRenderFunction
type ISelectableOption = ______utilities_selectableOption_SelectableOption_types.ISelectableOption
type ISelectableDroppableTextProps = ______utilities_selectableOption_SelectableDroppableText_types.ISelectableDroppableTextProps
type ResponsiveMode = ______utilities_decorators_withResponsiveMode.ResponsiveMode
type IKeytipProps = ______Keytip.IKeytipProps

type [<AllowNullLiteral>] IDropdown =
    abstract focus: (bool -> unit) with get, set

type [<AllowNullLiteral>] IDropdownProps =
    inherit ISelectableDroppableTextProps<HTMLDivElement>
    /// Input placeholder text. Displayed until option is selected.
    abstract placeHolder: string option with get, set
    /// Callback issues when the selected option changes
    abstract onChanged: (IDropdownOption -> float -> unit) option with get, set
    /// Callback issues when the options callout is dismissed
    abstract onDismiss: (unit -> unit) option with get, set
    /// Optional custom renderer for placeholder text
    abstract onRenderPlaceHolder: IRenderFunction<IDropdownProps> option with get, set
    /// Optional custom renderer for selected option displayed in input
    abstract onRenderTitle: IRenderFunction<U2<IDropdownOption, ResizeArray<IDropdownOption>>> option with get, set
    /// Optional custom renderer for chevron icon
    abstract onRenderCaretDown: IRenderFunction<IDropdownProps> option with get, set
    /// Custom width for dropdown. If value is 0, width of the input field is used.
    abstract dropdownWidth: float option with get, set
    abstract responsiveMode: ResponsiveMode option with get, set
    /// Optional mode indicates if multi-choice selections is allowed.  Default to false
    abstract multiSelect: bool option with get, set
    /// Keys that will be initially used to set selected items.
    abstract defaultSelectedKeys: U2<ResizeArray<string>, ResizeArray<float>> option with get, set
    /// Keys of the selected items. If you provide this, you must maintain selection
    /// state by observing onChange events and passing a new value in when changed.
    abstract selectedKeys: U2<ResizeArray<string>, ResizeArray<float>> option with get, set
    /// When multiple items are selected, this still will be used to separate values in
    /// the dropdown title.
    abstract multiSelectDelimiter: string option with get, set
    /// Deprecated at v0.52.0, use 'disabled' instead.
    abstract isDisabled: bool option with get, set
    /// Optional keytip for this dropdown
    abstract keytipProps: IKeytipProps option with get, set

type [<AllowNullLiteral>] IDropdownOption =
    inherit ISelectableOption
    /// Data available to custom onRender functions.
    abstract data: obj option with get, set
    /// Deprecated at v.65.1, use 'selected' instead.
    abstract isSelected: bool option with get, set
type IDropdownProps = __Dropdown_types.IDropdownProps
type IWithResponsiveModeState = ______utilities_decorators_withResponsiveMode.IWithResponsiveModeState
type BaseComponent = ______Utilities.BaseComponent

type [<AllowNullLiteral>] IExports =
    abstract Dropdown: DropdownStatic

type [<AllowNullLiteral>] IDropdownInternalProps =
    inherit IDropdownProps
    inherit IWithResponsiveModeState

type [<AllowNullLiteral>] IDropdownState =
    abstract isOpen: bool option with get, set
    abstract selectedIndices: ResizeArray<float> option with get, set

type [<AllowNullLiteral>] Dropdown =
    inherit BaseComponent<IDropdownInternalProps, IDropdownState>
    abstract defaultProps: obj with get, set
    abstract Option: obj with get, set
    abstract _host: obj with get, set
    abstract _focusZone: obj with get, set
    abstract _dropDown: obj with get, set
    abstract _id: obj with get, set
    abstract _isScrollIdle: obj with get, set
    abstract _scrollIdleDelay: obj
    abstract _scrollIdleTimeoutId: obj with get, set
    abstract componentWillReceiveProps: newProps: IDropdownProps -> unit
    abstract componentDidUpdate: prevProps: IDropdownProps * prevState: IDropdownState -> unit
    abstract render: unit -> JSX.Element
    abstract focus: ?shouldOpenOnFocus: bool -> unit
    abstract setSelectedIndex: index: float -> unit
    abstract _copyArray: array: obj -> unit
    /// <summary>Finds the next valid Dropdown option and sets the selected index to it.</summary>
    /// <param name="stepValue">Value of how many items the function should traverse.  Should be -1 or 1.</param>
    /// <param name="index">Index of where the search should start</param>
    /// <param name="selectedIndex">The selectedIndex Dropdown's state</param>
    abstract _moveIndex: stepValue: obj * index: obj * selectedIndex: obj -> unit
    abstract _onRenderTitle: obj with get, set
    abstract _onRenderPlaceHolder: obj with get, set
    abstract _onRenderContainer: obj with get, set
    abstract _onRenderCaretDown: obj with get, set
    abstract _onRenderList: obj with get, set
    abstract _onRenderItem: obj with get, set
    abstract _renderSeparator: item: obj -> unit
    abstract _renderHeader: item: obj -> unit
    abstract _renderOption: obj with get, set
    abstract _onRenderOption: obj with get, set
    abstract _onRenderLabel: obj with get, set
    abstract _onPositioned: obj with get, set
    abstract _onItemClick: obj with get, set
    /// Scroll handler for the callout to make sure the mouse events
    /// for updating focus are not interacting during scroll
    abstract _onScroll: obj with get, set
    abstract _onItemMouseEnter: item: obj * ev: obj -> unit
    abstract _onItemMouseMove: item: obj * ev: obj -> unit
    abstract _onMouseItemLeave: obj with get, set
    abstract _onDismiss: obj with get, set
    abstract _getSelectedIndexes: options: obj * selectedKey: obj -> unit
    abstract _getAllSelectedOptions: options: obj * selectedIndices: obj -> unit
    abstract _getAllSelectedIndices: options: obj -> unit
    abstract _getSelectedIndex: options: obj * selectedKey: obj -> unit
    abstract _onDropdownBlur: obj with get, set
    abstract _onDropdownKeyDown: obj with get, set
    abstract _onDropdownKeyUp: obj with get, set
    abstract _onZoneKeyDown: obj with get, set
    abstract _onDropdownClick: obj with get, set

type [<AllowNullLiteral>] DropdownStatic =
    [<Emit "new $0($1...)">] abstract Create: props: IDropdownProps -> Dropdown
type Autofill = __Autofill.Autofill
type KeyCodes = ______Utilities.KeyCodes

type [<AllowNullLiteral>] IAutofill =
    /// The current index of the cursor in the input area. Returns -1 if the input element
    /// is not ready.
    abstract cursorLocation: float option with get, set
    /// A boolean for whether or not there is a value selected in the input area.
    abstract isValueSelected: bool with get, set
    /// The current text value that the user has entered.
    abstract value: string with get, set
    /// The current index of where the selection starts. Returns -1 if the input element
    /// is not ready.
    abstract selectionStart: float option with get, set
    /// the current index of where the selection ends. Returns -1 if the input element
    /// is not ready.
    abstract selectionEnd: float option with get, set
    /// The current input element.
    abstract inputElement: HTMLInputElement option with get, set
    /// Focus the input element.
    abstract focus: unit -> unit
    /// Clear all text in the input. Sets value to '';
    abstract clear: unit -> unit

type [<AllowNullLiteral>] IAutofillProps =
    inherit React.InputHTMLAttributes<U2<HTMLInputElement, Autofill>>
    /// Gets the compoonent ref.
    abstract componentRef: (IAutofill option -> unit) option with get, set
    /// The suggested autofill value that will display.
    abstract suggestedDisplayValue: string option with get, set
    /// A callback for when the current input value changes.
    abstract onInputValueChange: (string -> unit) option with get, set
    /// When the user uses left arrow, right arrow, clicks, or deletes text autofill is disabled
    /// Since the user has taken control. It is automatically reenabled when the user enters text and the
    /// cursor is at the end of the text in the input box. This specifies other key presses that will reenabled
    /// autofill.
    abstract enableAutofillOnKeyPress: ResizeArray<KeyCodes> option with get, set
    /// The default value to be visible. This is different from placeholder
    /// because it actually sets the current value of the picker
    /// Note: This will only be set upon component creation
    /// and will not update with subsequent prop updates.
    abstract defaultVisibleValue: string option with get, set
    /// Handler for checking and updating the value if needed
    /// in componentWillReceiveProps
    abstract updateValueInWillReceiveProps: (unit -> string option) option with get, set
    /// Handler for checking if the full value of the input should
    /// be seleced in componentDidUpdate
    abstract shouldSelectFullInputValueInComponentDidUpdate: (unit -> bool) option with get, set
    /// A callback used to modify the input string.
    abstract onInputChange: (string -> string) option with get, set

type [<AllowNullLiteral>] IBaseAutoFill =
    inherit IAutofill

type [<AllowNullLiteral>] IBaseAutoFillProps =
    inherit IAutofillProps
type IAutofillProps = __Autofill_types.IAutofillProps
type IAutofill = __Autofill_types.IAutofill
type BaseComponent = ______Utilities.BaseComponent
type KeyCodes = ______Utilities.KeyCodes

type [<AllowNullLiteral>] IExports =
    abstract Autofill: AutofillStatic
    abstract BaseAutoFill: BaseAutoFillStatic

type [<AllowNullLiteral>] IAutofillState =
    abstract displayValue: string option with get, set

type [<AllowNullLiteral>] Autofill =
    inherit BaseComponent<IAutofillProps, IAutofillState>
    inherit IAutofill
    abstract defaultProps: obj with get, set
    abstract _inputElement: obj with get, set
    abstract _autoFillEnabled: obj with get, set
    abstract _value: obj with get, set
    abstract cursorLocation: float option
    abstract isValueSelected: bool
    abstract value: string
    abstract selectionStart: float option
    abstract selectionEnd: float option
    abstract inputElement: HTMLInputElement option
    abstract componentWillReceiveProps: nextProps: IAutofillProps -> unit
    abstract componentDidUpdate: unit -> unit
    abstract render: unit -> JSX.Element
    abstract focus: unit -> unit
    abstract clear: unit -> unit
    abstract _onCompositionStart: obj with get, set
    abstract _onCompositionEnd: obj with get, set
    abstract _onClick: obj with get, set
    abstract _onKeyDown: obj with get, set
    abstract _onInputChanged: obj with get, set
    abstract _onChanged: obj with get, set
    abstract _getCurrentInputValue: ?ev: obj -> unit
    /// <summary>Attempts to enable autofill. Whether or not autofill is enabled depends on the input value,
    /// whether or not any text is selected, and only if the new input value is longer than the old input value.
    /// Autofill should never be set to true if the value is composing. Once compositionEnd is called, then
    /// it should be completed.
    /// See https://developer.mozilla.org/en-US/docs/Web/API/CompositionEvent for more information on composition.</summary>
    /// <param name="newValue"></param>
    /// <param name="oldValue"></param>
    /// <param name="isComposing">if true then the text is actively being composed and it has not completed.</param>
    /// <param name="isComposed">if the text is a composed text value.</param>
    abstract _tryEnableAutofill: newValue: obj * oldValue: obj * ?isComposing: obj * ?isComposed: obj -> unit
    abstract _notifyInputChange: newValue: obj -> unit
    /// Updates the current input value as well as getting a new display value.
    abstract _updateValue: obj with get, set
    /// <summary>Returns a string that should be used as the display value.
    /// It evaluates this based on whether or not the suggested value starts with the input value
    /// and whether or not autofill is enabled.</summary>
    /// <param name="inputValue">the value that the input currently has.</param>
    /// <param name="suggestedDisplayValue">the possible full value</param>
    abstract _getDisplayValue: inputValue: obj * ?suggestedDisplayValue: obj -> unit
    abstract _doesTextStartWith: text: obj * startWith: obj -> unit

type [<AllowNullLiteral>] AutofillStatic =
    [<Emit "new $0($1...)">] abstract Create: props: IAutofillProps -> Autofill

/// Legacy, @deprecated, do not use.
type [<AllowNullLiteral>] BaseAutoFill =
    inherit Autofill

/// Legacy, @deprecated, do not use.
type [<AllowNullLiteral>] BaseAutoFillStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> BaseAutoFill

type [<AllowNullLiteral>] IExports =
    abstract SuggestionsController: SuggestionsControllerStatic

type [<AllowNullLiteral>] ISuggestionModel<'T> =
    abstract item: 'T with get, set
    abstract selected: bool with get, set
    abstract ariaLabel: string option with get, set

type [<AllowNullLiteral>] SuggestionsController<'T> =
    abstract currentIndex: float with get, set
    abstract currentSuggestion: ISuggestionModel<'T> option with get, set
    abstract suggestions: ResizeArray<ISuggestionModel<'T>> with get, set
    abstract updateSuggestions: newSuggestions: ResizeArray<'T> * ?selectedIndex: float -> unit
    /// Increments the suggestion index and gets the next suggestion in the list.
    abstract nextSuggestion: unit -> bool
    /// Decrements the suggestion index and gets the previous suggestion in the list.
    abstract previousSuggestion: unit -> bool
    abstract getSuggestions: unit -> ResizeArray<ISuggestionModel<'T>>
    abstract getCurrentItem: unit -> ISuggestionModel<'T>
    abstract getSuggestionAtIndex: index: float -> ISuggestionModel<'T>
    abstract hasSelectedSuggestion: unit -> bool
    abstract removeSuggestion: index: float -> unit
    abstract createGenericSuggestion: itemToConvert: U2<ISuggestionModel<'T>, 'T> -> unit
    abstract convertSuggestionsToSuggestionItems: suggestions: Array<U2<ISuggestionModel<'T>, 'T>> -> ResizeArray<ISuggestionModel<'T>>
    abstract deselectAllSuggestions: unit -> unit
    abstract setSelectedSuggestion: index: float -> unit
    abstract _isSuggestionModel: obj with get, set
    abstract _ensureSuggestionModel: obj with get, set

type [<AllowNullLiteral>] SuggestionsControllerStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> SuggestionsController<'T>
type ISuggestionModel = __SuggestionsController.ISuggestionModel
type IRenderFunction = _________Utilities.IRenderFunction
type KeyCodes = _________Utilities.KeyCodes
type IPersonaProps = ______Persona_Persona_types.IPersonaProps

type [<AllowNullLiteral>] ISuggestionsProps<'T> =
    inherit React.Props<obj option>
    /// Gets the component ref.
    abstract componentRef: (unit -> unit) option with get, set
    /// How the suggestion should look in the suggestion list.
    abstract onRenderSuggestion: ('T -> 'T -> JSX.Element) option with get, set
    /// What should occur when a suggestion is clicked
    abstract onSuggestionClick: (React.MouseEvent<HTMLElement> -> obj option -> float -> unit) with get, set
    /// The list of Suggestions that will be displayed
    abstract suggestions: ResizeArray<ISuggestionModel<'T>> with get, set
    /// How the "no result found" should look in the suggestion list.
    abstract onRenderNoResultFound: IRenderFunction<unit> option with get, set
    /// The text that appears at the top of the suggestions list.
    abstract suggestionsHeaderText: string option with get, set
    /// The text that should appear at the top of the most recenty used box.
    abstract mostRecentlyUsedHeaderText: string option with get, set
    /// The text that appears indicating to the user that they can search for more results.
    abstract searchForMoreText: string option with get, set
    /// The callback that should be called when the user attempts to get more results
    abstract onGetMoreResults: (unit -> unit) option with get, set
    /// The text that appears indicating to the use to force resolve the input
    abstract forceResolveText: string option with get, set
    /// The callback that should be called to see if the force resolve command should be shown
    abstract showForceResolve: (unit -> bool) option with get, set
    /// The callback that should be called when the user attempts to use the input text as as item
    abstract createGenericItem: (unit -> unit) option with get, set
    /// The CSS classname of the suggestions list.
    abstract className: string option with get, set
    /// The text that should appear if there is a search error.
    abstract searchErrorText: string option with get, set
    /// The text that should appear if no results are found when searching.
    abstract noResultsFoundText: string option with get, set
    /// the classname of the suggestionitem.
    abstract suggestionsItemClassName: string option with get, set
    /// Used to indicate whether or not the user can request more suggestions.
    /// Dictates whether or not the searchForMore button is displayed.
    abstract moreSuggestionsAvailable: bool option with get, set
    /// Used to indicate whether or not the suggestions are loading.
    abstract isLoading: bool option with get, set
    /// Used to indicate whether or not the component is searching for more results.
    abstract isSearching: bool option with get, set
    /// The text to display while the results are loading.
    abstract loadingText: string option with get, set
    /// The text to display while searching for more results in a limited sugesstions list.
    abstract searchingText: string option with get, set
    /// Indicates if a short list of recent suggestions should be shown.
    abstract isMostRecentlyUsedVisible: bool option with get, set
    /// Function to fire when one of the optional remove buttons on a suggestion is clicked.
    abstract onSuggestionRemove: (React.MouseEvent<HTMLElement> -> IPersonaProps -> float -> unit) option with get, set
    /// Indicates if the text in resultsFooter or resultsFooterFull should be shown at the end of the suggestion list.
    abstract isResultsFooterVisible: bool option with get, set
    /// Maximum number of suggestions to show in the full suggestion list.
    abstract resultsMaximumNumber: float option with get, set
    /// A renderer that adds an element at the end of the suggestions list it has more items than resultsMaximumNumber.
    abstract resultsFooterFull: (ISuggestionsProps<'T> -> JSX.Element) option with get, set
    /// A renderer that adds an element at the end of the suggestions list it has fewer items than resultsMaximumNumber.
    abstract resultsFooter: (ISuggestionsProps<'T> -> JSX.Element) option with get, set
    /// Indicates whether to show a button with each suggestion to remove that suggestion.
    abstract showRemoveButtons: bool option with get, set
    /// Screen reader message to read when there are suggestions available.
    abstract suggestionsAvailableAlertText: string option with get, set
    /// A function that resets focus to the expected item in the suggestion list
    abstract refocusSuggestions: (KeyCodes -> unit) option with get, set
    /// An ARIA label for the container that is the parent of the suggestions.
    abstract suggestionsContainerAriaLabel: string option with get, set
    /// An ARIA label to use for the buttons to remove individual suggestions.
    abstract removeSuggestionAriaLabel: string option with get, set

type [<AllowNullLiteral>] ISuggestionItemProps<'T> =
    abstract componentRef: (unit -> unit) option with get, set
    abstract suggestionModel: ISuggestionModel<'T> with get, set
    abstract RenderSuggestion: ('T -> ISuggestionItemProps<'T> -> JSX.Element) with get, set
    abstract onClick: (React.MouseEvent<HTMLButtonElement> -> unit) with get, set
    abstract onRemoveItem: (React.MouseEvent<HTMLButtonElement> -> unit) with get, set
    abstract className: string option with get, set
    abstract id: string option with get, set
    abstract showRemoveButton: bool option with get, set
    abstract isSelectedOverride: bool option with get, set
    /// The ARIA label for the button to remove the suggestion from the list.
    abstract removeButtonAriaLabel: string option with get, set
type BaseComponent = _________Utilities.BaseComponent
type IButton = _________Button.IButton
type ISuggestionItemProps = __Suggestions_types.ISuggestionItemProps
type ISuggestionsProps = __Suggestions_types.ISuggestionsProps

type [<AllowNullLiteral>] IExports =
    abstract SuggestionsItem: SuggestionsItemStatic
    abstract Suggestions: SuggestionsStatic

type [<RequireQualifiedAccess>] SuggestionActionType =
    | None = 0
    | ForceResolve = 1
    | SearchMore = 2

type [<AllowNullLiteral>] ISuggestionsState =
    abstract selectedActionType: SuggestionActionType with get, set

type [<AllowNullLiteral>] SuggestionsItem<'T> =
    inherit BaseComponent<ISuggestionItemProps<'T>, obj>
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] SuggestionsItemStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> SuggestionsItem<'T>

type [<AllowNullLiteral>] Suggestions<'T> =
    inherit BaseComponent<ISuggestionsProps<'T>, ISuggestionsState>
    abstract _forceResolveButton: obj with get, set
    abstract _searchForMoreButton: obj with get, set
    abstract _selectedElement: obj with get, set
    abstract SuggestionsItemOfProperType: obj with get, set
    abstract activeSelectedElement: obj with get, set
    abstract componentDidMount: unit -> unit
    abstract componentDidUpdate: unit -> unit
    abstract render: unit -> JSX.Element
    /// Returns true if the event was handled, false otherwise
    abstract tryHandleKeyDown: (float -> float -> bool) with get, set
    abstract hasSuggestedAction: unit -> bool
    abstract hasSuggestedActionSelected: unit -> bool
    abstract executeSelectedAction: unit -> unit
    abstract focusAboveSuggestions: unit -> unit
    abstract focusBelowSuggestions: unit -> unit
    abstract focusSearchForMoreButton: unit -> unit
    abstract scrollSelected: unit -> unit
    abstract _renderSuggestions: unit -> unit
    abstract _getMoreResults: obj with get, set
    abstract _forceResolve: obj with get, set
    abstract _shouldShowForceResolve: obj with get, set
    abstract _onClickTypedSuggestionsItem: obj with get, set
    abstract _refocusOnSuggestions: obj with get, set
    abstract _onRemoveTypedSuggestionsItem: obj with get, set

type [<AllowNullLiteral>] SuggestionsStatic =
    [<Emit "new $0($1...)">] abstract Create: suggestionsProps: ISuggestionsProps<'T> -> Suggestions<'T>

type [<AllowNullLiteral>] IPickerItemProps<'T> =
    inherit React.AllHTMLAttributes<HTMLElement>
    abstract componentRef: (unit -> unit) option with get, set
    abstract item: 'T with get, set
    abstract index: float with get, set
    abstract selected: bool option with get, set
    abstract onRemoveItem: (unit -> unit) option with get, set
    /// Internal Use only, gives a callback to the renderer to call when an item has changed.
    /// This allows the base picker to keep track of changes in the items.
    abstract onItemChange: ('T -> float -> unit) option with get, set
    abstract key: U2<string, float> option with get, set
    abstract removeButtonAriaLabel: string option with get, set
type IPickerItemProps = __PickerItem_types.IPickerItemProps
type IPersonaProps = ___Persona_Persona_types.IPersonaProps
type IRenderFunction = ______Utilities.IRenderFunction
type ISuggestionModel = __Suggestions_SuggestionsController.ISuggestionModel
type BaseAutoFill = __AutoFill_BaseAutoFill.BaseAutoFill

type [<AllowNullLiteral>] IBasePicker<'T> =
    /// Gets the current value of the input. 
    abstract items: ResizeArray<'T> option with get, set
    /// Sets focus to the focus zone. 
    abstract focus: (unit -> unit) with get, set
    /// Set focus to the input 
    abstract focusInput: (unit -> unit) with get, set

type [<AllowNullLiteral>] IBasePickerProps<'T> =
    inherit React.Props<obj option>
    abstract componentRef: (IBasePicker<'T> option -> unit) option with get, set
    /// Function that specifies how the selected item will appear.
    abstract onRenderItem: (IPickerItemProps<'T> -> JSX.Element) option with get, set
    /// Function that specifies how an individual suggestion item will appear.
    abstract onRenderSuggestionsItem: ('T -> obj option -> JSX.Element) option with get, set
    /// A callback for what should happen when a person types text into the input.
    /// Returns the already selected items so the resolver can filter them out.
    /// If used in conjunction with resolveDelay this will ony kick off after the delay throttle.
    abstract onResolveSuggestions: (string -> ResizeArray<'T> -> U2<ResizeArray<'T>, PromiseLike<ResizeArray<'T>>>) with get, set
    /// The delay time in ms before resolving suggestions, which is kicked off when input has been cahnged.
    /// e.g. If a second input change happens within the resolveDelay time, the timer will start over.
    /// Only until after the timer completes will onResolveSuggestions be called.
    abstract resolveDelay: float option with get, set
    /// A callback for what should happen when a user clicks the input.
    abstract onEmptyInputFocus: (ResizeArray<'T> -> U2<ResizeArray<'T>, PromiseLike<ResizeArray<'T>>>) option with get, set
    /// Initial items that have already been selected and should appear in the people picker.
    abstract defaultSelectedItems: ResizeArray<'T> option with get, set
    /// A callback for when the selected list of items changes.
    abstract onChange: (ResizeArray<'T> -> unit) option with get, set
    /// A callback for when the user put focus on the picker
    abstract onFocus: React.FocusEventHandler<U2<HTMLInputElement, BaseAutoFill>> option with get, set
    /// A callback for when the user moves the focus away from the picker
    abstract onBlur: React.FocusEventHandler<U2<HTMLInputElement, BaseAutoFill>> option with get, set
    /// A callback to get text from an item. Used to autofill text in the pickers.
    abstract getTextFromItem: ('T -> string -> string) option with get, set
    /// A callback that gets the rest of the results when a user clicks get more results.
    abstract onGetMoreResults: (string -> ResizeArray<'T> -> U2<ResizeArray<'T>, PromiseLike<ResizeArray<'T>>>) option with get, set
    /// ClassName for the picker.
    abstract className: string option with get, set
    /// The properties that will get passed to the Suggestions component.
    abstract pickerSuggestionsProps: IBasePickerSuggestionsProps option with get, set
    /// AutoFill input native props
    abstract inputProps: IInputProps option with get, set
    /// A callback for when a persona is removed from the suggestion list
    abstract onRemoveSuggestion: (IPersonaProps -> unit) option with get, set
    /// A function used to validate if raw text entered into the well can be added into the selected items list
    abstract onValidateInput: (string -> ValidationState) option with get, set
    /// The text to display while searching for more results in a limited suggestions list
    abstract searchingText: U2<(obj -> string), string> option with get, set
    /// Flag for disabling the picker.
    abstract disabled: bool option with get, set
    /// Restrict the amount of selectable items.
    abstract itemLimit: float option with get, set
    /// Function that specifies how arbitrary text entered into the well is handled.
    abstract createGenericItem: (string -> ValidationState -> U2<ISuggestionModel<'T>, 'T>) option with get, set
    /// Aria label for the "X" button in the selected item component.
    abstract removeButtonAriaLabel: string option with get, set
    /// A callback to process a selection after the user selects something from the picker. If the callback returns null,
    /// the item will not be added to the picker.
    abstract onItemSelected: ('T -> U2<'T, PromiseLike<'T>> option) option with get, set
    /// The items that the base picker should currently display as selected. If this is provided then the picker will act as a controlled component.
    abstract selectedItems: ResizeArray<'T> option with get, set
    /// A callback used to modify the input string.
    abstract onInputChange: (string -> string) option with get, set
    /// A callback to override the default behavior of adding the selected suggestion on dismiss.
    abstract onDismiss: (obj option -> 'T -> unit) option with get, set
    /// Adds an additional alert for the currently selected suggestion. This prop should be set to true for IE11 and below, as it
    /// enables proper screen reader behavior for each suggestion (since aria-activedescendant does not work with IE11).
    /// It should not be set for modern browsers (Edge, Chrome).
    abstract enableSelectedSuggestionAlert: bool option with get, set

type [<AllowNullLiteral>] IBasePickerSuggestionsProps =
    /// Function that specifies what to render when no results are found.
    abstract onRenderNoResultFound: IRenderFunction<unit> option with get, set
    /// The text that should appear at the top of the suggestion box.
    abstract suggestionsHeaderText: string option with get, set
    /// The text that should appear at the top of the most recently used box.
    abstract mostRecentlyUsedHeaderText: string option with get, set
    /// the text that should appear when no results are returned.
    abstract noResultsFoundText: string option with get, set
    /// ClassName for the picker.
    abstract className: string option with get, set
    /// Classname for the suggestion box.
    abstract suggestionsClassName: string option with get, set
    /// ClassName for suggestion items.
    abstract suggestionsItemClassName: string option with get, set
    /// The text that should appear on the button to search for more.
    abstract searchForMoreText: string option with get, set
    /// The text that appears indicating to the use to force resolve the input
    abstract forceResolveText: string option with get, set
    /// The text to display while the results are loading.
    abstract loadingText: string option with get, set
    /// The text to display while searching for more results in a limited sugesstions list.
    abstract searchingText: string option with get, set
    /// A renderer that adds an element at the end of the suggestions list it has more items than resultsMaximumNumber.
    abstract resultsFooterFull: (unit -> JSX.Element) option with get, set
    /// A renderer that adds an element at the end of the suggestions list when there are fewer than resultsMaximumNumber.
    abstract resultsFooter: (unit -> JSX.Element) option with get, set
    /// Maximum number of suggestions to show in the full suggestion list.
    abstract resultsMaximumNumber: float option with get, set
    /// Indicates whether to show a button with each suggestion to remove that suggestion.
    abstract showRemoveButtons: bool option with get, set
    /// Screen reader message to read when there are suggestions available.
    abstract suggestionsAvailableAlertText: string option with get, set
    /// An ARIA label for the container that is the parent of the suggestions.
    abstract suggestionsContainerAriaLabel: string option with get, set

type [<RequireQualifiedAccess>] ValidationState =
    | Valid = 0
    | Warning = 1
    | Invalid = 2

type [<AllowNullLiteral>] IInputProps =
    inherit React.InputHTMLAttributes<HTMLInputElement>
    /// Screen reader label to apply to an input element.
    abstract ``aria-label``: string option with get, set
    /// The default value to be visible when the autofill first created.
    /// This is different than placeholder text because the placeholder text will disappear and re-appear. This
    /// text persists until deleted or changed.
    abstract defaultVisibleValue: string option with get, set
type BaseComponent = ______Utilities.BaseComponent
type KeyCodes = ______Utilities.KeyCodes
type IFocusZone = ______FocusZone.IFocusZone
type Selection = ______utilities_selection_index.Selection
type Suggestions = __Suggestions_Suggestions.Suggestions
type ISuggestionsProps = __Suggestions_Suggestions_types.ISuggestionsProps
type SuggestionsController = __Suggestions_SuggestionsController.SuggestionsController
type IBasePicker = __BasePicker_types.IBasePicker
type IBasePickerProps = __BasePicker_types.IBasePickerProps
type IAutofill = ___Autofill_index.IAutofill
type Autofill = ___Autofill_index.Autofill
type IPickerItemProps = __PickerItem_types.IPickerItemProps
type IPersonaProps = ___Persona_Persona_types.IPersonaProps

type [<AllowNullLiteral>] IExports =
    abstract BasePicker: BasePickerStatic
    abstract BasePickerListBelow: BasePickerListBelowStatic

type [<AllowNullLiteral>] IBasePickerState =
    abstract items: obj option with get, set
    abstract suggestedDisplayValue: string option with get, set
    abstract moreSuggestionsAvailable: bool option with get, set
    abstract isFocused: bool option with get, set
    abstract isSearching: bool option with get, set
    abstract isMostRecentlyUsedVisible: bool option with get, set
    abstract suggestionsVisible: bool option with get, set
    abstract suggestionsLoading: bool option with get, set
    abstract isResultsFooterVisible: bool option with get, set

type [<AllowNullLiteral>] BasePicker<'T, 'P> =
    inherit BaseComponent<'P, IBasePickerState>
    inherit IBasePicker<'T>
    abstract selection: Selection with get, set
    abstract root: obj with get, set
    abstract input: obj with get, set
    abstract focusZone: obj with get, set
    abstract suggestionElement: obj with get, set
    abstract suggestionStore: SuggestionsController<'T> with get, set
    abstract SuggestionOfProperType: obj with get, set
    abstract loadingTimer: float option with get, set
    abstract currentPromise: PromiseLike<obj option> option with get, set
    abstract items: ResizeArray<'T>
    abstract componentWillUpdate: newProps: 'P * newState: IBasePickerState -> unit
    abstract componentDidMount: unit -> unit
    abstract componentWillReceiveProps: newProps: 'P -> unit
    abstract componentWillUnmount: unit -> unit
    abstract focus: unit -> unit
    abstract focusInput: unit -> unit
    abstract dismissSuggestions: (obj option -> unit) with get, set
    abstract completeSuggestion: unit -> unit
    abstract refocusSuggestions: (KeyCodes -> unit) with get, set
    abstract render: unit -> JSX.Element
    abstract canAddItems: unit -> bool
    abstract renderSuggestions: unit -> JSX.Element option
    abstract renderItems: unit -> ResizeArray<JSX.Element>
    abstract resetFocus: ?index: float -> unit
    abstract onSuggestionSelect: unit -> unit
    abstract onSelectionChange: unit -> unit
    abstract updateSuggestions: suggestions: ResizeArray<obj option> -> unit
    abstract onEmptyInputFocus: unit -> unit
    abstract updateValue: updatedValue: string -> unit
    abstract updateSuggestionsList: suggestions: U2<ResizeArray<'T>, PromiseLike<ResizeArray<'T>>> * ?updatedValue: string -> unit
    abstract resolveNewValue: updatedValue: string * suggestions: ResizeArray<'T> -> unit
    abstract onChange: ?items: ResizeArray<'T> -> unit
    abstract onInputChange: (string -> unit) with get, set
    abstract onSuggestionClick: (React.MouseEvent<HTMLElement> -> obj option -> float -> unit) with get, set
    abstract onSuggestionRemove: (React.MouseEvent<HTMLElement> -> IPersonaProps -> float -> unit) with get, set
    abstract onInputFocus: (React.FocusEvent<U2<HTMLInputElement, Autofill>> -> unit) with get, set
    abstract onInputBlur: (React.FocusEvent<U2<HTMLInputElement, Autofill>> -> unit) with get, set
    abstract onKeyDown: (React.KeyboardEvent<HTMLElement> -> unit) with get, set
    abstract onItemChange: ('T -> float -> unit) with get, set
    abstract onGetMoreResults: (unit -> unit) with get, set
    abstract addItemByIndex: (float -> unit) with get, set
    abstract addItem: ('T -> unit) with get, set
    abstract removeItem: (IPickerItemProps<'T> -> unit) with get, set
    abstract removeItems: (ResizeArray<obj option> -> unit) with get, set
    abstract onBackspace: ev: React.KeyboardEvent<HTMLElement> -> unit
    abstract _isFocusZoneInnerKeystroke: (React.KeyboardEvent<HTMLElement> -> bool) with get, set
    /// Controls what happens whenever there is an action that impacts the selected items.
    /// If selectedItems is provided as a property then this will act as a controlled component and it will not update it's own state.
    abstract _updateSelectedItems: items: obj * ?focusIndex: obj -> unit
    abstract _onSelectedItemsUpdated: ?items: obj * ?focusIndex: obj -> unit
    abstract _onResolveSuggestions: updatedValue: obj -> unit
    abstract _onValidateInput: unit -> unit
    abstract _getTextFromItem: item: obj * ?currentValue: obj -> unit

type [<AllowNullLiteral>] BasePickerStatic =
    [<Emit "new $0($1...)">] abstract Create: basePickerProps: 'P -> BasePicker<'T, 'P>

type [<AllowNullLiteral>] BasePickerListBelow<'T, 'P> =
    inherit BasePicker<'T, 'P>
    abstract render: unit -> JSX.Element
    abstract onBackspace: ev: React.KeyboardEvent<HTMLElement> -> unit

type [<AllowNullLiteral>] BasePickerListBelowStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> BasePickerListBelow<'T, 'P>
let [<Import("obj","office-ui-fabric-react")>] resultContent: obj = jsNative
let [<Import("obj","office-ui-fabric-react")>] resultItem: obj = jsNative
let [<Import("obj","office-ui-fabric-react")>] peoplePickerPersona: obj = jsNative
let [<Import("obj","office-ui-fabric-react")>] peoplePicker: obj = jsNative
let [<Import("obj","office-ui-fabric-react")>] peoplePickerPersonaContent: obj = jsNative
type IPersonaProps = ____________Persona.IPersonaProps
type IPickerItemProps = ______PickerItem_types.IPickerItemProps
type IContextualMenuItem = ____________ContextualMenu.IContextualMenuItem
type ValidationState = ______BasePicker_types.ValidationState

type [<AllowNullLiteral>] IPeoplePickerItemProps =
    inherit IPickerItemProps<obj>

type [<AllowNullLiteral>] IPeoplePickerItemWithMenuProps =
    inherit IPickerItemProps<IPersonaWithMenu>
    abstract item: IPersonaWithMenu with get, set

type [<AllowNullLiteral>] IPersonaWithMenu =
    inherit IPersonaProps
    abstract menuItems: ResizeArray<IContextualMenuItem> option with get, set
type BasePicker = ___BasePicker.BasePicker
type BasePickerListBelow = ___BasePicker.BasePickerListBelow
type IBasePickerProps = ___BasePicker_types.IBasePickerProps
type IBasePickerSuggestionsProps = ___BasePicker_types.IBasePickerSuggestionsProps
type ValidationState = ___BasePicker_types.ValidationState
type IPersonaProps = _________Persona.IPersonaProps
type IPeoplePickerItemProps = __PeoplePickerItems_PeoplePickerItem_types.IPeoplePickerItemProps

type [<AllowNullLiteral>] IExports =
    abstract BasePeoplePicker: BasePeoplePickerStatic
    abstract MemberListPeoplePicker: MemberListPeoplePickerStatic
    abstract NormalPeoplePicker: NormalPeoplePickerStatic
    abstract CompactPeoplePicker: CompactPeoplePickerStatic
    abstract ListPeoplePicker: ListPeoplePickerStatic
    abstract createGenericItem: name: string * currentValidationState: ValidationState * allowPhoneInitials: bool -> obj

type [<AllowNullLiteral>] IPeoplePickerProps =
    inherit IBasePickerProps<IPersonaProps>

type [<AllowNullLiteral>] BasePeoplePicker =
    inherit BasePicker<IPersonaProps, IPeoplePickerProps>

type [<AllowNullLiteral>] BasePeoplePickerStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> BasePeoplePicker

type [<AllowNullLiteral>] MemberListPeoplePicker =
    inherit BasePickerListBelow<IPersonaProps, IPeoplePickerProps>

type [<AllowNullLiteral>] MemberListPeoplePickerStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> MemberListPeoplePicker

/// Standard People Picker.
type [<AllowNullLiteral>] NormalPeoplePicker =
    inherit BasePeoplePicker
    abstract defaultProps: obj with get, set

/// Standard People Picker.
type [<AllowNullLiteral>] NormalPeoplePickerStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> NormalPeoplePicker

/// Compact layout. It uses small personas when displaying search results.
type [<AllowNullLiteral>] CompactPeoplePicker =
    inherit BasePeoplePicker
    abstract defaultProps: obj with get, set

/// Compact layout. It uses small personas when displaying search results.
type [<AllowNullLiteral>] CompactPeoplePickerStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> CompactPeoplePicker

/// MemberList layout. The selected people show up below the search box.
type [<AllowNullLiteral>] ListPeoplePicker =
    inherit MemberListPeoplePicker
    abstract defaultProps: obj with get, set

/// MemberList layout. The selected people show up below the search box.
type [<AllowNullLiteral>] ListPeoplePickerStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> ListPeoplePicker

type [<AllowNullLiteral>] IGenericItem =
    abstract primaryText: string with get, set
    abstract imageInitials: string with get, set
    abstract ValidationState: ValidationState with get, set
type IPickerItemProps = ___PickerItem_types.IPickerItemProps
type ITag = __TagPicker.ITag
let [<Import("","office-ui-fabric-react")>] TagItem: (ITagItemProps -> JSX.Element) = jsNative

type [<AllowNullLiteral>] ITagItemProps =
    inherit IPickerItemProps<ITag>
    abstract enableTagFocusInDisabledPicker: bool option with get, set
type BasePicker = ___BasePicker.BasePicker
type IBasePickerProps = ___BasePicker_types.IBasePickerProps
type ITagItemProps = __TagItem.ITagItemProps

type [<AllowNullLiteral>] IExports =
    abstract TagPicker: TagPickerStatic

type [<AllowNullLiteral>] ITag =
    abstract key: string with get, set
    abstract name: string with get, set

type [<AllowNullLiteral>] ITagPickerProps =
    inherit IBasePickerProps<ITag>

type [<AllowNullLiteral>] TagPicker =
    inherit BasePicker<ITag, ITagPickerProps>
    abstract defaultProps: obj with get, set

type [<AllowNullLiteral>] TagPickerStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> TagPicker
type ISuggestionModel = _________Pickers.ISuggestionModel
type IPersonaProps = _________Persona.IPersonaProps

type [<AllowNullLiteral>] ISuggestionsCoreProps<'T> =
    inherit React.Props<obj option>
    /// Gets the component ref.
    abstract componentRef: (unit -> unit) option with get, set
    /// How the suggestion should look in the suggestion list.
    abstract onRenderSuggestion: ('T -> 'T -> JSX.Element) option with get, set
    /// What should occur when a suggestion is clicked
    abstract onSuggestionClick: (React.MouseEvent<HTMLElement> -> obj option -> float -> unit) with get, set
    /// The list of Suggestions that will be displayed
    abstract suggestions: ResizeArray<ISuggestionModel<'T>> with get, set
    /// Function to fire when one of the optional remove buttons on a suggestion is clicked.
    abstract onSuggestionRemove: (React.MouseEvent<HTMLElement> -> IPersonaProps -> float -> unit) option with get, set
    /// Screen reader message to read when there are suggestions available.
    abstract suggestionsAvailableAlertText: string option with get, set
    /// An ARIA label for the container that is the parent of the suggestions.
    abstract suggestionsContainerAriaLabel: string option with get, set
    /// the classname of the suggestionitem.
    abstract suggestionsItemClassName: string option with get, set
    /// Maximum number of suggestions to show in the full suggestion list.
    abstract resultsMaximumNumber: float option with get, set
    /// Indicates whether to show a button with each suggestion to remove that suggestion.
    abstract showRemoveButtons: bool option with get, set
    /// Indicates whether to loop around to the top or bottom of the the suggestions
    /// on calling nextSuggestion and previousSuggestion, respectively
    abstract shouldLoopSelection: bool with get, set

type [<AllowNullLiteral>] ISuggestionsControlProps<'T> =
    inherit React.Props<obj option>
    inherit ISuggestionsCoreProps<'T>
    /// An ARIA label for the container that is the parent of the suggestions header items.
    abstract suggestionsHeaderContainerAriaLabel: string option with get, set
    /// An ARIA label for the container that is the parent of the suggestions footer items.
    abstract suggestionsFooterContainerAriaLabel: string option with get, set
    /// The header items props
    abstract headerItemsProps: ResizeArray<ISuggestionsHeaderFooterProps> option with get, set
    /// The footer items props
    abstract footerItemsProps: ResizeArray<ISuggestionsHeaderFooterProps> option with get, set
    /// Whether or not the first selectable item in the suggestions list should be selected
    abstract shouldSelectFirstItem: (unit -> bool) option with get, set
    /// The CSS classname of the suggestions list.
    abstract className: string option with get, set
    /// Completes the suggestion
    abstract completeSuggestion: (unit -> unit) with get, set

type [<AllowNullLiteral>] ISuggestionsHeaderFooterProps =
    abstract renderItem: (unit -> JSX.Element) with get, set
    abstract onExecute: (unit -> unit) option with get, set
    abstract className: string option with get, set
    abstract ariaLabel: string option with get, set
    abstract shouldShow: (unit -> bool) with get, set

type [<AllowNullLiteral>] ISuggestionsHeaderFooterItemProps =
    abstract componentRef: (unit -> unit) option with get, set
    abstract renderItem: (unit -> JSX.Element) with get, set
    abstract onExecute: (unit -> unit) option with get, set
    abstract isSelected: bool with get, set
    abstract id: string with get, set
    abstract className: string option with get, set
type ISuggestionModel = _________Pickers.ISuggestionModel

type [<AllowNullLiteral>] IExports =
    abstract SuggestionsStore: SuggestionsStoreStatic

type [<AllowNullLiteral>] SuggestionsStore<'T> =
    abstract suggestions: ResizeArray<ISuggestionModel<'T>> with get, set
    abstract updateSuggestions: newSuggestions: ResizeArray<'T> -> unit
    abstract getSuggestions: unit -> ResizeArray<ISuggestionModel<'T>>
    abstract getSuggestionAtIndex: index: float -> ISuggestionModel<'T>
    abstract removeSuggestion: index: float -> unit
    abstract convertSuggestionsToSuggestionItems: suggestions: Array<U2<ISuggestionModel<'T>, 'T>> -> ResizeArray<ISuggestionModel<'T>>
    abstract _isSuggestionModel: value: obj -> unit
    abstract _ensureSuggestionModel: suggestion: obj -> unit

type [<AllowNullLiteral>] SuggestionsStoreStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> SuggestionsStore<'T>
type ISuggestionModel = ______Pickers.ISuggestionModel
type IPersonaProps = ______Persona.IPersonaProps
type ISuggestionsHeaderFooterProps = __Suggestions_Suggestions_types.ISuggestionsHeaderFooterProps
type SuggestionsStore = __Suggestions_SuggestionsStore.SuggestionsStore

type [<AllowNullLiteral>] IBaseFloatingPicker =
    /// Whether the suggestions are shown 
    abstract isSuggestionsShown: bool with get, set
    /// On queryString changed 
    abstract onQueryStringChanged: (string -> unit) with get, set
    /// Hides the picker 
    abstract hidePicker: (unit -> unit) with get, set
    /// Shows the picker
    abstract showPicker: (bool -> unit) with get, set
    /// Gets the suggestions 
    abstract suggestions: ResizeArray<obj option> with get, set
    /// Gets the input text 
    abstract inputText: string with get, set

type [<AllowNullLiteral>] IBaseFloatingPickerProps<'T> =
    inherit React.Props<obj option>
    abstract componentRef: (IBaseFloatingPicker option -> unit) option with get, set
    /// The suggestions store
    abstract suggestionsStore: SuggestionsStore<'T> with get, set
    /// The suggestions to show on zero query
    abstract onZeroQuerySuggestion: (ResizeArray<'T> -> U2<ResizeArray<'T>, PromiseLike<ResizeArray<'T>>>) option with get, set
    /// The input element to listen on events
    abstract inputElement: HTMLInputElement option with get, set
    /// Function that specifies how an individual suggestion item will appear.
    abstract onRenderSuggestionsItem: ('T -> obj option -> JSX.Element) option with get, set
    /// A callback for what should happen when a person types text into the input.
    /// Returns the already selected items so the resolver can filter them out.
    /// If used in conjunction with resolveDelay this will ony kick off after the delay throttle.
    abstract onResolveSuggestions: (string -> ResizeArray<'T> -> U2<ResizeArray<'T>, PromiseLike<ResizeArray<'T>>> option) with get, set
    /// A callback for when the input has been changed
    abstract onInputChanged: (string -> unit) option with get, set
    /// The delay time in ms before resolving suggestions, which is kicked off when input has been cahnged.
    /// e.g. If a second input change happens within the resolveDelay time, the timer will start over.
    /// Only until after the timer completes will onResolveSuggestions be called.
    abstract resolveDelay: float option with get, set
    /// A callback for when a suggestion is clicked
    abstract onChange: ('T -> unit) option with get, set
    /// ClassName for the picker.
    abstract className: string option with get, set
    /// The properties that will get passed to the Suggestions component.
    abstract pickerSuggestionsProps: IBaseFloatingPickerSuggestionProps option with get, set
    /// A callback for when a persona is removed from the suggestion list
    abstract onRemoveSuggestion: (IPersonaProps -> unit) option with get, set
    /// A function used to validate if raw text entered into the well can be added
    abstract onValidateInput: (string -> bool) option with get, set
    /// The text to display while searching for more results in a limited suggestions list
    abstract searchingText: U2<(obj -> string), string> option with get, set
    /// Function that specifies how arbitrary text entered into the well is handled.
    abstract createGenericItem: (string -> bool -> ISuggestionModel<'T>) option with get, set
    /// The callback that should be called to see if the force resolve command should be shown
    abstract showForceResolve: (unit -> bool) option with get, set
    /// The items that the base picker should currently display as selected. If this is provided then the picker will act as a controlled
    /// component.
    abstract selectedItems: ResizeArray<'T> option with get, set
    /// A callback to get text from an item. Used to autofill text in the pickers.
    abstract getTextFromItem: ('T -> string -> string) option with get, set
    /// Width for the suggestions callout
    abstract calloutWidth: float option with get, set
    /// The callback that should be called when the suggestions are shown
    abstract onSuggestionsShown: (unit -> unit) option with get, set
    /// The callback that should be called when the suggestions are hiden
    abstract onSuggestionsHidden: (unit -> unit) option with get, set

type [<AllowNullLiteral>] IBaseFloatingPickerSuggestionProps =
    /// Whether or not the first selectable item in the suggestions list should be selected
    abstract shouldSelectFirstItem: (unit -> bool) option with get, set
    /// The header items props
    abstract headerItemsProps: ResizeArray<ISuggestionsHeaderFooterProps> option with get, set
    /// The footer items props
    abstract footerItemsProps: ResizeArray<ISuggestionsHeaderFooterProps> option with get, set
type BaseComponent = _________Utilities.BaseComponent
type ISuggestionModel = _________Pickers.ISuggestionModel
type ISuggestionsCoreProps = __Suggestions_types.ISuggestionsCoreProps

type [<AllowNullLiteral>] IExports =
    abstract SuggestionsCore: SuggestionsCoreStatic

/// Class when used with SuggestionsStore, renders a basic suggestions control
type [<AllowNullLiteral>] SuggestionsCore<'T> =
    inherit BaseComponent<ISuggestionsCoreProps<'T>, obj>
    abstract currentIndex: float with get, set
    abstract currentSuggestion: ISuggestionModel<'T> option with get, set
    abstract _selectedElement: HTMLDivElement with get, set
    abstract SuggestionsItemOfProperType: obj with get, set
    /// Increments the selected suggestion index
    abstract nextSuggestion: unit -> bool
    /// Decrements the selected suggestion index
    abstract previousSuggestion: unit -> bool
    abstract getCurrentItem: unit -> ISuggestionModel<'T>
    abstract getSuggestionAtIndex: index: float -> ISuggestionModel<'T>
    abstract hasSuggestionSelected: unit -> bool
    abstract removeSuggestion: index: float -> unit
    abstract deselectAllSuggestions: unit -> unit
    abstract setSelectedSuggestion: index: float -> unit
    abstract componentDidUpdate: unit -> unit
    abstract render: unit -> JSX.Element
    abstract scrollSelected: unit -> unit
    abstract _onClickTypedSuggestionsItem: item: obj * index: obj -> unit
    abstract _onRemoveTypedSuggestionsItem: item: obj * index: obj -> unit

/// Class when used with SuggestionsStore, renders a basic suggestions control
type [<AllowNullLiteral>] SuggestionsCoreStatic =
    [<Emit "new $0($1...)">] abstract Create: suggestionsProps: ISuggestionsCoreProps<'T> -> SuggestionsCore<'T>
type BaseComponent = _________Utilities.BaseComponent
type IButton = _________Button.IButton
type ISuggestionModel = _________Pickers.ISuggestionModel
type ISuggestionsHeaderFooterItemProps = __Suggestions_types.ISuggestionsHeaderFooterItemProps
type ISuggestionsControlProps = __Suggestions_types.ISuggestionsControlProps
type SuggestionsCore = __SuggestionsCore.SuggestionsCore

type [<AllowNullLiteral>] IExports =
    abstract SuggestionsHeaderFooterItem: SuggestionsHeaderFooterItemStatic
    abstract SuggestionsControl: SuggestionsControlStatic

type [<RequireQualifiedAccess>] SuggestionItemType =
    | Header = 0
    | Suggestion = 1
    | Footer = 2

type [<AllowNullLiteral>] ISuggestionsControlState =
    abstract selectedHeaderIndex: float with get, set
    abstract selectedFooterIndex: float with get, set

type [<AllowNullLiteral>] SuggestionsHeaderFooterItem =
    inherit BaseComponent<ISuggestionsHeaderFooterItemProps, obj>
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] SuggestionsHeaderFooterItemStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> SuggestionsHeaderFooterItem

/// Class when used with SuggestionsStore, renders a suggestions control with customizable headers and footers
type [<AllowNullLiteral>] SuggestionsControl<'T> =
    inherit BaseComponent<ISuggestionsControlProps<'T>, ISuggestionsControlState>
    abstract _forceResolveButton: IButton with get, set
    abstract _searchForMoreButton: IButton with get, set
    abstract _selectedElement: HTMLDivElement with get, set
    abstract _suggestions: SuggestionsCore<'T> with get, set
    abstract SuggestionsOfProperType: obj with get, set
    abstract componentDidMount: unit -> unit
    abstract componentDidUpdate: unit -> unit
    abstract componentWillReceiveProps: unit -> unit
    abstract componentWillUnmount: unit -> unit
    abstract render: unit -> JSX.Element
    abstract currentSuggestion: ISuggestionModel<'T>
    abstract hasSuggestionSelected: unit -> bool
    abstract hasSelection: unit -> bool
    abstract executeSelectedAction: unit -> unit
    abstract removeSuggestion: ?index: float -> unit
    /// <summary>Handles the key down, returns true, if the event was handled, false otherwise</summary>
    /// <param name="keyCode">The keyCode to handle</param>
    abstract handleKeyDown: keyCode: float -> bool
    abstract scrollSelected: unit -> unit
    abstract renderHeaderItems: unit -> JSX.Element option
    abstract renderFooterItems: unit -> JSX.Element option
    abstract _renderSuggestions: unit -> JSX.Element
    /// Selects the next selectable item
    abstract selectNextItem: itemType: SuggestionItemType * ?originalItemType: SuggestionItemType -> unit
    /// Selects the previous selectable item
    abstract selectPreviousItem: itemType: SuggestionItemType * ?originalItemType: SuggestionItemType -> unit
    /// Resets the selected state and selects the first selectable item
    abstract resetSelectedItem: unit -> unit
    /// Selects the first item
    abstract selectFirstItem: unit -> unit
    /// Selects the last item
    abstract selectLastItem: unit -> unit
    /// <summary>Selects the next item in the suggestion item type group, given the current index
    /// If none is able to be selected, returns false, otherwise returns true</summary>
    /// <param name="itemType">The suggestion item type</param>
    /// <param name="currentIndex">The current index, default is -1</param>
    abstract _selectNextItemOfItemType: itemType: obj * ?currentIndex: obj -> unit
    /// <summary>Selects the previous item in the suggestion item type group, given the current index
    /// If none is able to be selected, returns false, otherwise returns true</summary>
    /// <param name="itemType">The suggestion item type</param>
    /// <param name="currentIndex">The current index. If none is provided, the default is the items length of specified type</param>
    abstract _selectPreviousItemOfItemType: itemType: obj * ?currentIndex: obj -> unit
    abstract _getCurrentIndexForType: itemType: obj -> unit
    abstract _getNextItemSectionType: itemType: obj -> unit
    abstract _getPreviousItemSectionType: itemType: obj -> unit

/// Class when used with SuggestionsStore, renders a suggestions control with customizable headers and footers
type [<AllowNullLiteral>] SuggestionsControlStatic =
    [<Emit "new $0($1...)">] abstract Create: suggestionsProps: ISuggestionsControlProps<'T> -> SuggestionsControl<'T>
type BaseComponent = ______Utilities.BaseComponent
type IBaseFloatingPicker = __BaseFloatingPicker_types.IBaseFloatingPicker
type IBaseFloatingPickerProps = __BaseFloatingPicker_types.IBaseFloatingPickerProps
type ISuggestionsControlProps = __Suggestions_Suggestions_types.ISuggestionsControlProps
type SuggestionsControl = __Suggestions_SuggestionsControl.SuggestionsControl
type SuggestionsStore = __Suggestions_SuggestionsStore.SuggestionsStore

type [<AllowNullLiteral>] IExports =
    abstract BaseFloatingPicker: BaseFloatingPickerStatic

type [<AllowNullLiteral>] IBaseFloatingPickerState =
    abstract queryString: string with get, set
    abstract suggestedDisplayValue: string option with get, set
    abstract moreSuggestionsAvailable: bool option with get, set
    abstract isMostRecentlyUsedVisible: bool option with get, set
    abstract suggestionsVisible: bool option with get, set
    abstract suggestionsLoading: bool option with get, set
    abstract isResultsFooterVisible: bool option with get, set
    abstract didBind: bool with get, set

type [<AllowNullLiteral>] BaseFloatingPicker<'T, 'P> =
    inherit BaseComponent<'P, IBaseFloatingPickerState>
    inherit IBaseFloatingPicker
    abstract selection: Selection with get, set
    abstract root: obj with get, set
    abstract suggestionStore: SuggestionsStore<'T> with get, set
    abstract suggestionsControl: SuggestionsControl<'T> with get, set
    abstract SuggestionsControlOfProperType: obj with get, set
    abstract loadingTimer: float option with get, set
    abstract currentPromise: PromiseLike<obj option> with get, set
    abstract inputText: string
    abstract suggestions: ResizeArray<obj option>
    abstract forceResolveSuggestion: unit -> unit
    abstract isSuggestionsShown: bool
    abstract onQueryStringChanged: (string -> unit) with get, set
    abstract hidePicker: (unit -> unit) with get, set
    abstract showPicker: (bool -> unit) with get, set
    abstract componentDidMount: unit -> unit
    abstract componentDidUpdate: unit -> unit
    abstract componentWillUnmount: unit -> unit
    abstract completeSuggestion: (unit -> unit) with get, set
    abstract updateSuggestions: suggestions: ResizeArray<'T> * ?forceUpdate: bool -> unit
    abstract render: unit -> JSX.Element
    abstract renderSuggestions: unit -> JSX.Element option
    abstract onSuggestionSelect: unit -> unit
    abstract onSelectionChange: unit -> unit
    abstract updateValue: updatedValue: string -> unit
    abstract updateSuggestionWithZeroState: unit -> unit
    abstract updateSuggestionsList: suggestions: U2<ResizeArray<'T>, PromiseLike<ResizeArray<'T>>> * ?updatedValue: string -> unit
    abstract resolveNewValue: updatedValue: string * suggestions: ResizeArray<'T> -> unit
    abstract onChange: item: 'T -> unit
    abstract onSuggestionClick: (React.MouseEvent<HTMLElement> -> 'T -> float -> unit) with get, set
    abstract onSuggestionRemove: (React.MouseEvent<HTMLElement> -> 'T -> float -> unit) with get, set
    abstract onKeyDown: (MouseEvent -> unit) with get, set
    abstract _onResolveSuggestions: updatedValue: obj -> unit
    abstract _onValidateInput: obj with get, set
    abstract _getTextFromItem: item: obj * ?currentValue: obj -> unit
    abstract _updateSuggestionsVisible: shouldShow: obj -> unit
    abstract _bindToInputElement: unit -> unit
    abstract _unbindFromInputElement: unit -> unit

type [<AllowNullLiteral>] BaseFloatingPickerStatic =
    [<Emit "new $0($1...)">] abstract Create: basePickerProps: 'P -> BaseFloatingPicker<'T, 'P>
let [<Import("obj","office-ui-fabric-react")>] resultContent: obj = jsNative
let [<Import("obj","office-ui-fabric-react")>] resultItem: obj = jsNative
let [<Import("obj","office-ui-fabric-react")>] peoplePickerPersona: obj = jsNative
let [<Import("obj","office-ui-fabric-react")>] peoplePicker: obj = jsNative
let [<Import("obj","office-ui-fabric-react")>] peoplePickerPersonaContent: obj = jsNative
type BaseFloatingPicker = ___BaseFloatingPicker.BaseFloatingPicker
type IBaseFloatingPickerProps = ___BaseFloatingPicker_types.IBaseFloatingPickerProps
type IPersonaProps = _________Persona.IPersonaProps
type ISuggestionModel = _________Pickers.ISuggestionModel

type [<AllowNullLiteral>] IExports =
    abstract BaseFloatingPeoplePicker: BaseFloatingPeoplePickerStatic
    abstract FloatingPeoplePicker: FloatingPeoplePickerStatic
    abstract createItem: name: string * isValid: bool -> ISuggestionModel<IPersonaProps>

type [<AllowNullLiteral>] IPeopleFloatingPickerProps =
    inherit IBaseFloatingPickerProps<IPersonaProps>

type [<AllowNullLiteral>] BaseFloatingPeoplePicker =
    inherit BaseFloatingPicker<IPersonaProps, IPeopleFloatingPickerProps>

type [<AllowNullLiteral>] BaseFloatingPeoplePickerStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> BaseFloatingPeoplePicker

type [<AllowNullLiteral>] FloatingPeoplePicker =
    inherit BaseFloatingPeoplePicker
    abstract defaultProps: obj option with get, set

type [<AllowNullLiteral>] FloatingPeoplePickerStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> FloatingPeoplePicker
type IPickerItemProps = ______Pickers.IPickerItemProps
type ISuggestionModel = ______Pickers.ISuggestionModel
type ValidationState = ______Pickers.ValidationState
type Selection = ______Selection.Selection

type [<AllowNullLiteral>] IBaseSelectedItemsList<'T> =
    /// Gets the current value of the input. 
    abstract items: ResizeArray<'T> option with get, set
    abstract addItems: (ResizeArray<'T> -> unit) with get, set

type [<AllowNullLiteral>] ISelectedItemProps<'T> =
    inherit IPickerItemProps<'T>
    abstract onCopyItem: ('T -> unit) with get, set

type [<AllowNullLiteral>] IBaseSelectedItemsListProps<'T> =
    inherit React.Props<obj option>
    abstract componentRef: (IBaseSelectedItemsList<'T> option -> unit) option with get, set
    /// The selection
    abstract selection: Selection option with get, set
    /// A callback for when items are copied
    abstract onCopyItems: (ResizeArray<'T> -> string) option with get, set
    /// Function that specifies how the selected item will appear.
    abstract onRenderItem: (ISelectedItemProps<'T> -> JSX.Element) option with get, set
    /// Initial items that have already been selected and should appear in the people picker.
    abstract defaultSelectedItems: ResizeArray<'T> option with get, set
    /// A callback for when the selected list of items changes.
    abstract onChange: (ResizeArray<'T> -> unit) option with get, set
    /// ClassName for the picker.
    abstract className: string option with get, set
    /// Function that specifies how arbitrary text entered into the well is handled.
    abstract createGenericItem: (string -> ValidationState -> ISuggestionModel<'T>) option with get, set
    /// A callback to process a selection after the user selects something from the picker.
    abstract onItemSelected: ('T -> U2<'T, PromiseLike<'T>>) option with get, set
    /// The items that the base picker should currently display as selected. If this is provided then the picker will act as a
    /// controlled component.
    abstract selectedItems: ResizeArray<'T> option with get, set
    /// Aria label for the 'X' button in the selected item component.
    abstract removeButtonAriaLabel: string option with get, set
    /// A callback when and item is deleted
    abstract onItemDeleted: ('T -> unit) option with get, set
type BaseComponent = ______Utilities.BaseComponent
type Selection = ______Selection.Selection
type IBaseSelectedItemsList = __BaseSelectedItemsList_types.IBaseSelectedItemsList
type IBaseSelectedItemsListProps = __BaseSelectedItemsList_types.IBaseSelectedItemsListProps
type ISelectedItemProps = __BaseSelectedItemsList_types.ISelectedItemProps

type [<AllowNullLiteral>] IExports =
    abstract BaseSelectedItemsList: BaseSelectedItemsListStatic

type [<AllowNullLiteral>] IBaseSelectedItemsListState =
    abstract items: obj option with get, set
    abstract suggestedDisplayValue: string option with get, set
    abstract moreSuggestionsAvailable: bool option with get, set
    abstract isSearching: bool option with get, set
    abstract isMostRecentlyUsedVisible: bool option with get, set
    abstract suggestionsVisible: bool option with get, set
    abstract suggestionsLoading: bool option with get, set
    abstract isResultsFooterVisible: bool option with get, set

type [<AllowNullLiteral>] BaseSelectedItemsList<'T, 'P> =
    inherit BaseComponent<'P, IBaseSelectedItemsListState>
    inherit IBaseSelectedItemsList<'T>
    abstract root: HTMLElement with get, set
    abstract selection: Selection with get, set
    abstract items: ResizeArray<'T>
    abstract addItems: (ResizeArray<'T> -> unit) with get, set
    abstract removeItemAt: (float -> unit) with get, set
    abstract removeItem: (ISelectedItemProps<'T> -> unit) with get, set
    abstract removeItems: (ResizeArray<obj option> -> unit) with get, set
    /// Controls what happens whenever there is an action that impacts the selected items.
    /// If selectedItems is provided as a property then this will act as a controlled component and it will not update it's own state.
    abstract updateItems: items: ResizeArray<'T> * ?focusIndex: float -> unit
    abstract onCopy: (React.ClipboardEvent<HTMLElement> -> unit) with get, set
    abstract unselectAll: unit -> unit
    abstract componentWillUpdate: newProps: 'P * newState: IBaseSelectedItemsListState -> unit
    abstract componentDidMount: unit -> unit
    abstract componentWillReceiveProps: newProps: 'P -> unit
    abstract render: unit -> obj option
    abstract renderItems: (unit -> ResizeArray<JSX.Element>) with get, set
    abstract onSelectionChanged: (unit -> unit) with get, set
    abstract onChange: ?items: ResizeArray<'T> -> unit
    abstract onKeyDown: (React.KeyboardEvent<HTMLElement> -> unit) with get, set
    abstract onItemChange: ('T -> float -> unit) with get, set
    abstract onBackspace: ev: React.KeyboardEvent<HTMLElement> -> unit
    abstract copyItems: items: ResizeArray<'T> -> unit
    abstract _isFocusZoneInnerKeystroke: ev: React.KeyboardEvent<HTMLElement> -> bool
    abstract _onSelectedItemsUpdated: ?items: obj * ?focusIndex: obj -> unit

type [<AllowNullLiteral>] BaseSelectedItemsListStatic =
    [<Emit "new $0($1...)">] abstract Create: basePickerProps: 'P -> BaseSelectedItemsList<'T, 'P>
type BaseSelectedItemsList = ___BaseSelectedItemsList.BaseSelectedItemsList
type IBaseSelectedItemsListProps = ___BaseSelectedItemsList_types.IBaseSelectedItemsListProps
type ISelectedItemProps = ___BaseSelectedItemsList_types.ISelectedItemProps
type IPersonaProps = _________Persona.IPersonaProps
type IRenderFunction = _________Utilities.IRenderFunction
type IBaseFloatingPickerProps = _________FloatingPicker.IBaseFloatingPickerProps

type [<AllowNullLiteral>] IExports =
    abstract BasePeopleSelectedItemsList: BasePeopleSelectedItemsListStatic
    abstract SelectedPeopleList: SelectedPeopleListStatic

type [<AllowNullLiteral>] IExtendedPersonaProps =
    inherit IPersonaProps
    abstract isValid: bool with get, set
    abstract blockRecipientRemoval: bool option with get, set
    abstract shouldBlockSelection: bool option with get, set
    abstract canExpand: bool option with get, set
    abstract isEditing: bool option with get, set

type [<AllowNullLiteral>] ISelectedPeopleItemProps =
    inherit ISelectedItemProps<IExtendedPersonaProps>
    abstract onExpandItem: (unit -> unit) option with get, set
    abstract renderPersonaCoin: IRenderFunction<IPersonaProps> option with get, set
    abstract renderPrimaryText: IRenderFunction<IPersonaProps> option with get, set

type [<AllowNullLiteral>] ISelectedPeopleProps =
    inherit IBaseSelectedItemsListProps<IExtendedPersonaProps>
    abstract onExpandGroup: (IExtendedPersonaProps -> unit) option with get, set
    abstract removeMenuItemText: string option with get, set
    abstract copyMenuItemText: string option with get, set
    abstract editMenuItemText: string option with get, set
    abstract getEditingItemText: (IExtendedPersonaProps -> string) option with get, set
    abstract onRenderFloatingPicker: (IBaseFloatingPickerProps<IPersonaProps> -> JSX.Element) option with get, set
    abstract floatingPickerProps: IBaseFloatingPickerProps<IPersonaProps> option with get, set

type [<AllowNullLiteral>] BasePeopleSelectedItemsList =
    inherit BaseSelectedItemsList<IExtendedPersonaProps, ISelectedPeopleProps>

type [<AllowNullLiteral>] BasePeopleSelectedItemsListStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> BasePeopleSelectedItemsList

/// Standard People Picker.
type [<AllowNullLiteral>] SelectedPeopleList =
    inherit BasePeopleSelectedItemsList
    abstract defaultProps: obj option with get, set
    abstract replaceItem: (IExtendedPersonaProps -> ResizeArray<IExtendedPersonaProps> -> unit) with get, set
    abstract renderItems: (unit -> ResizeArray<JSX.Element>) with get, set
    abstract _renderItem: item: obj * index: obj -> unit
    abstract _beginEditing: obj with get, set
    abstract _completeEditing: obj with get, set
    abstract _createMenuItems: item: obj -> unit

/// Standard People Picker.
type [<AllowNullLiteral>] SelectedPeopleListStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> SelectedPeopleList
type BaseComponent = ____________Utilities.BaseComponent
type ISelectedPeopleItemProps = ___SelectedPeopleList.ISelectedPeopleItemProps

type [<AllowNullLiteral>] IExports =
    abstract ExtendedSelectedItem: ExtendedSelectedItemStatic

type [<AllowNullLiteral>] IPeoplePickerItemState =
    abstract contextualMenuVisible: bool with get, set

type [<AllowNullLiteral>] ExtendedSelectedItem =
    inherit BaseComponent<ISelectedPeopleItemProps, IPeoplePickerItemState>
    abstract persona: obj with get, set
    abstract render: unit -> JSX.Element
    abstract _onClickIconButton: action: obj -> unit

type [<AllowNullLiteral>] ExtendedSelectedItemStatic =
    [<Emit "new $0($1...)">] abstract Create: props: ISelectedPeopleItemProps -> ExtendedSelectedItem
type Autofill = ______Autofill.Autofill
type IInputProps = ______Pickers.IInputProps
type IBaseFloatingPickerProps = ______FloatingPicker.IBaseFloatingPickerProps
type IBaseSelectedItemsListProps = ______SelectedItemsList.IBaseSelectedItemsListProps

type [<AllowNullLiteral>] IBaseExtendedPicker<'T> =
    /// Forces the picker to resolve 
    abstract forceResolve: (unit -> unit) option with get, set
    /// Gets the current value of the input. 
    abstract items: ResizeArray<'T> option with get, set
    /// Sets focus to the input. 
    abstract focus: (unit -> unit) with get, set

type [<AllowNullLiteral>] IBaseExtendedPickerProps<'T> =
    abstract componentRef: (IBaseExtendedPicker<'T> option -> unit) option with get, set
    /// Header/title element for the picker
    abstract headerComponent: JSX.Element option with get, set
    /// Initial items that have already been selected and should appear in the people picker.
    abstract defaultSelectedItems: ResizeArray<'T> option with get, set
    /// A callback for when the selected list of items changes.
    abstract onChange: (ResizeArray<'T> -> unit) option with get, set
    /// A callback for when text is pasted into the input
    abstract onPaste: (string -> ResizeArray<'T>) option with get, set
    /// A callback for when the user put focus on the picker
    abstract onFocus: React.FocusEventHandler<U2<HTMLInputElement, Autofill>> option with get, set
    /// A callback for when the user moves the focus away from the picker
    abstract onBlur: React.FocusEventHandler<U2<HTMLInputElement, Autofill>> option with get, set
    /// ClassName for the picker.
    abstract className: string option with get, set
    /// Function that specifies how the floating picker will appear.
    abstract onRenderFloatingPicker: (IBaseFloatingPickerProps<'T> -> JSX.Element) with get, set
    /// Function that specifies how the floating picker will appear.
    abstract onRenderSelectedItems: (IBaseSelectedItemsListProps<'T> -> JSX.Element) with get, set
    /// Floating picker properties
    abstract floatingPickerProps: IBaseFloatingPickerProps<'T> with get, set
    /// Selected items list properties
    abstract selectedItemsListProps: IBaseSelectedItemsListProps<'T> with get, set
    /// Autofill input native props
    abstract inputProps: IInputProps option with get, set
    /// Flag for disabling the picker.
    abstract disabled: bool option with get, set
    /// Restrict the amount of selectable items.
    abstract itemLimit: float option with get, set
    /// A callback to process a selection after the user selects something from the picker.
    abstract onItemSelected: ('T -> U2<'T, PromiseLike<'T>>) option with get, set
    /// Deprecated at 5.96.0. Use defaultSelectedItems or selectedItems in selectedItemsListProps instead.
    abstract selectedItems: ResizeArray<'T> option with get, set
type BaseComponent = ______Utilities.BaseComponent
type Autofill = ______Autofill.Autofill
type IBaseExtendedPickerProps = __BaseExtendedPicker_types.IBaseExtendedPickerProps
type IBaseExtendedPicker = __BaseExtendedPicker_types.IBaseExtendedPicker
type IBaseFloatingPickerProps = ______FloatingPicker.IBaseFloatingPickerProps
type BaseFloatingPicker = ______FloatingPicker.BaseFloatingPicker
type BaseSelectedItemsList = ______SelectedItemsList.BaseSelectedItemsList
type IBaseSelectedItemsListProps = ______SelectedItemsList.IBaseSelectedItemsListProps
type Selection = ______Selection.Selection

type [<AllowNullLiteral>] IExports =
    abstract BaseExtendedPicker: BaseExtendedPickerStatic

type [<AllowNullLiteral>] IBaseExtendedPickerState =
    abstract items: obj option with get, set
    abstract suggestedDisplayValue: string option with get, set
    abstract moreSuggestionsAvailable: bool option with get, set
    abstract isSearching: bool option with get, set
    abstract isMostRecentlyUsedVisible: bool option with get, set
    abstract suggestionsVisible: bool option with get, set
    abstract suggestionsLoading: bool option with get, set
    abstract isResultsFooterVisible: bool option with get, set

type [<AllowNullLiteral>] BaseExtendedPicker<'T, 'P> =
    inherit BaseComponent<'P, IBaseExtendedPickerState>
    inherit IBaseExtendedPicker<'T>
    abstract floatingPicker: obj with get, set
    abstract selectedItemsList: obj with get, set
    abstract root: obj with get, set
    abstract input: obj with get, set
    abstract selection: Selection with get, set
    abstract floatingPickerProps: IBaseFloatingPickerProps<'T> with get, set
    abstract selectedItemsListProps: IBaseSelectedItemsListProps<'T> with get, set
    abstract items: obj option
    abstract componentDidMount: unit -> unit
    abstract componentWillReceiveProps: newProps: 'P -> unit
    abstract focus: unit -> unit
    abstract clearInput: unit -> unit
    abstract inputElement: HTMLInputElement option
    abstract render: unit -> JSX.Element
    abstract onSelectionChange: (unit -> unit) with get, set
    abstract canAddItems: unit -> bool
    abstract renderSuggestions: unit -> JSX.Element
    abstract renderSelectedItemsList: unit -> JSX.Element
    abstract onInputChange: (string -> unit) with get, set
    abstract onInputFocus: (React.FocusEvent<U2<HTMLInputElement, Autofill>> -> unit) with get, set
    abstract onInputClick: (React.MouseEvent<U2<HTMLInputElement, Autofill>> -> unit) with get, set
    abstract onBackspace: (React.KeyboardEvent<HTMLElement> -> unit) with get, set
    abstract onCopy: (React.ClipboardEvent<HTMLElement> -> unit) with get, set
    abstract onPaste: (React.ClipboardEvent<U2<HTMLInputElement, Autofill>> -> unit) with get, set
    abstract _onSuggestionSelected: ('T -> unit) with get, set
    abstract _onSelectedItemsChanged: (unit -> unit) with get, set

type [<AllowNullLiteral>] BaseExtendedPickerStatic =
    [<Emit "new $0($1...)">] abstract Create: basePickerProps: 'P -> BaseExtendedPicker<'T, 'P>
let [<Import("obj","office-ui-fabric-react")>] resultContent: obj = jsNative
let [<Import("obj","office-ui-fabric-react")>] resultItem: obj = jsNative
let [<Import("obj","office-ui-fabric-react")>] peoplePickerPersona: obj = jsNative
let [<Import("obj","office-ui-fabric-react")>] peoplePicker: obj = jsNative
let [<Import("obj","office-ui-fabric-react")>] peoplePickerPersonaContent: obj = jsNative
type IPickerItemProps = _________Pickers.IPickerItemProps
type IExtendedPersonaProps = _________SelectedItemsList.IExtendedPersonaProps
type IPersonaProps = _________Persona.IPersonaProps
type BaseExtendedPicker = ___BaseExtendedPicker.BaseExtendedPicker
type IBaseExtendedPickerProps = ___BaseExtendedPicker_types.IBaseExtendedPickerProps

type [<AllowNullLiteral>] IExports =
    abstract BaseExtendedPeoplePicker: BaseExtendedPeoplePickerStatic
    abstract ExtendedPeoplePicker: ExtendedPeoplePickerStatic

type [<AllowNullLiteral>] IPeoplePickerItemProps =
    inherit IPickerItemProps<IExtendedPersonaProps>

type [<AllowNullLiteral>] IExtendedPeoplePickerProps =
    inherit IBaseExtendedPickerProps<IPersonaProps>

type [<AllowNullLiteral>] BaseExtendedPeoplePicker =
    inherit BaseExtendedPicker<IPersonaProps, IExtendedPeoplePickerProps>

type [<AllowNullLiteral>] BaseExtendedPeoplePickerStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> BaseExtendedPeoplePicker

type [<AllowNullLiteral>] ExtendedPeoplePicker =
    inherit BaseExtendedPeoplePicker

type [<AllowNullLiteral>] ExtendedPeoplePickerStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> ExtendedPeoplePicker
type IExtendedPersonaProps = ______SelectedItemsList.IExtendedPersonaProps
let [<Import("objArray","office-ui-fabric-react")>] people: ResizeArray<obj> = jsNative
let [<Import("IExtendedPersonaPropsArray","office-ui-fabric-react")>] mru: ResizeArray<IExtendedPersonaProps> = jsNative
let [<Import("IExtendedPersonaPropsArray","office-ui-fabric-react")>] groupOne: ResizeArray<IExtendedPersonaProps> = jsNative
let [<Import("IExtendedPersonaPropsArray","office-ui-fabric-react")>] groupTwo: ResizeArray<IExtendedPersonaProps> = jsNative
type IStyle = ______Styling.IStyle
type ITheme = ______Styling.ITheme

type [<AllowNullLiteral>] IFabricProps =
    inherit React.HTMLAttributes<HTMLDivElement>
    abstract componentRef: (unit -> unit) option with get, set
    abstract theme: ITheme option with get, set

type [<AllowNullLiteral>] IFabricStyleProps =
    inherit IFabricProps
    abstract theme: ITheme with get, set
    abstract isFocusVisible: bool with get, set

type [<AllowNullLiteral>] IFabricStyles =
    abstract root: IStyle with get, set
type BaseComponent = ______Utilities.BaseComponent
type IFabricProps = __Fabric_types.IFabricProps

type [<AllowNullLiteral>] IExports =
    abstract Fabric: FabricStatic

type [<AllowNullLiteral>] Fabric =
    inherit BaseComponent<IFabricProps, obj>
    abstract _rootElement: obj with get, set
    abstract render: unit -> JSX.Element
    abstract componentDidMount: unit -> unit
    abstract _onMouseDown: obj with get, set
    abstract _onKeyDown: obj with get, set

type [<AllowNullLiteral>] FabricStatic =
    [<Emit "new $0($1...)">] abstract Create: props: IFabricProps -> Fabric
type BaseComponent = ______Utilities.BaseComponent
type IFacepileProps = __Facepile_types.IFacepileProps

type [<AllowNullLiteral>] IExports =
    abstract FacepileBase: FacepileBaseStatic

type [<AllowNullLiteral>] FacepileBase =
    inherit BaseComponent<IFacepileProps, obj>
    abstract defaultProps: IFacepileProps with get, set
    abstract _ariaDescriptionId: obj with get, set
    abstract render: unit -> JSX.Element
    abstract onRenderAriaDescription: unit -> U2<string, JSX.Element> option
    abstract _onRenderVisiblePersonas: personas: obj * singlePersona: obj -> unit
    abstract _getPersonaControl: persona: obj -> unit
    abstract _getPersonaCoinControl: persona: obj -> unit
    abstract _getElementWithOnClickEvent: personaControl: obj * persona: obj * index: obj -> unit
    abstract _getElementWithoutOnClickEvent: personaControl: obj * persona: obj * index: obj -> unit
    abstract _getElementProps: persona: obj * index: obj -> unit
    abstract _getOverflowElement: personasOverflow: obj -> unit
    abstract _getDescriptiveOverflowElement: personasOverflow: obj -> unit
    abstract _getIconElement: icon: obj -> unit
    abstract _getAddNewElement: unit -> unit
    abstract _onPersonaClick: persona: obj * ?ev: obj -> unit
    abstract _onPersonaMouseMove: persona: obj * ?ev: obj -> unit
    abstract _onPersonaMouseOut: persona: obj * ?ev: obj -> unit
    abstract _renderInitials: iconName: obj * ?overflowButton: obj -> unit
    abstract _renderInitialsNotPictured: numPersonasNotPictured: obj -> unit

type [<AllowNullLiteral>] FacepileBaseStatic =
    [<Emit "new $0($1...)">] abstract Create: props: IFacepileProps -> FacepileBase
type FacepileBase = __Facepile_base.FacepileBase
type IStyle = ______Styling.IStyle
type ITheme = ______Styling.ITheme
type IStyleFunction = ______Utilities.IStyleFunction
type IButtonProps = ___Button_index.IButtonProps
type IPersonaSharedProps = ___Persona_index.IPersonaSharedProps
type PersonaInitialsColor = ___Persona_index.PersonaInitialsColor
type PersonaSize = ___Persona_index.PersonaSize

type [<AllowNullLiteral>] IFacepile =
    interface end

type [<AllowNullLiteral>] IFacepileProps =
    inherit React.Props<FacepileBase>
    /// Optional callback to access the IFacepile interface. Use this instead of ref for accessing
    /// the public methods and properties of the component.
    abstract componentRef: (IFacepile option -> unit) option with get, set
    /// Call to provide customized styling that will layer on top of the variant rules.
    abstract getStyles: IStyleFunction<IFacepileStyleProps, IFacepileStyles> option with get, set
    /// Theme provided by High-Order Component.
    abstract theme: ITheme option with get, set
    /// Additional css class to apply to the Facepile
    abstract className: string option with get, set
    /// Array of IPersonaProps that define each Persona.
    abstract personas: ResizeArray<IFacepilePersona> with get, set
    /// Personas to place in the overflow
    abstract overflowPersonas: ResizeArray<IFacepilePersona> option with get, set
    /// Maximum number of personas to show 
    abstract maxDisplayablePersonas: float option with get, set
    /// Size to display the personas 
    abstract personaSize: PersonaSize option with get, set
    /// ARIA label for persona list 
    abstract ariaDescription: string option with get, set
    /// Show add person button 
    abstract showAddButton: bool option with get, set
    /// Button properties for the add face button 
    abstract addButtonProps: IButtonProps option with get, set
    /// Deprecated at v0.70, use 'overflowButtonProps' instead;
    abstract chevronButtonProps: IButtonProps option with get, set
    /// Properties for the overflow icon 
    abstract overflowButtonProps: IButtonProps option with get, set
    /// Type of overflow icon to use 
    abstract overflowButtonType: OverflowButtonType option with get, set
    /// Method to access properties on the underlying Persona control 
    abstract getPersonaProps: (IFacepilePersona -> IPersonaSharedProps) option with get, set

type [<AllowNullLiteral>] IFacepilePersona =
    inherit React.ButtonHTMLAttributes<U2<HTMLButtonElement, HTMLDivElement>>
    /// Name of the person.
    abstract personaName: string option with get, set
    /// Url to the image to use, should be a square aspect ratio and big enough to fit in the image area.
    abstract imageUrl: string option with get, set
    /// The user's initials to display in the image area when there is no image.
    abstract imageInitials: string option with get, set
    /// Whether initials are calculated for phone numbers and number sequences.
    /// Example: Set property to true to get initials for project names consisting of numbers only.
    abstract allowPhoneInitials: bool option with get, set
    /// The background color when the user's initials are displayed.
    abstract initialsColor: PersonaInitialsColor option with get, set
    /// If provided, persona will be rendered with cursor:pointer and the handler will be
    /// called on click.
    abstract onClick: (React.MouseEvent<HTMLElement> -> IFacepilePersona -> unit) option with get, set
    /// If provided, the handler will be called on mouse move.
    abstract onMouseMove: (React.MouseEvent<HTMLElement> -> IFacepilePersona -> unit) option with get, set
    /// If provided, the handler will be called when mouse moves out of the component.
    abstract onMouseOut: (React.MouseEvent<HTMLElement> -> IFacepilePersona -> unit) option with get, set
    /// Extra data - not used directly but can be handy for passing additional data to custom event
    /// handlers.
    abstract data: obj option with get, set

type [<RequireQualifiedAccess>] OverflowButtonType =
    | None = 0
    | Descriptive = 1
    | More = 2
    | DownArrow = 3

type [<AllowNullLiteral>] IFacepileStyleProps =
    /// Theme provided by High-Order Component.
    abstract theme: ITheme with get, set
    /// Accept custom classNames
    abstract className: string option with get, set

type [<AllowNullLiteral>] IFacepileStyles =
    /// Style for the root element.
    abstract root: IStyle with get, set
type ExpandingCard = __ExpandingCard.ExpandingCard
type IRenderFunction = ______Utilities.IRenderFunction
type IStyle = ______Styling.IStyle
type ITheme = ______Styling.ITheme
type DirectionalHint = ______common_DirectionalHint.DirectionalHint

type [<AllowNullLiteral>] IExpandingCard =
    interface end

/// ExpandingCard component props.
type [<AllowNullLiteral>] IExpandingCardProps =
    inherit React.HTMLAttributes<U2<HTMLDivElement, ExpandingCard>>
    /// Optional callback to access the IExpandingCard interface. Use this instead of ref for accessing
    /// the public methods and properties of the component.
    abstract componentRef: (IExpandingCard option -> unit) option with get, set
    /// Item to be returned with onRender functions
    abstract renderData: obj option with get, set
    /// Render function to populate compact content area
    abstract onRenderCompactCard: IRenderFunction<IExpandingCardProps> option with get, set
    /// Render function to populate expanded content area
    abstract onRenderExpandedCard: IRenderFunction<IExpandingCardProps> option with get, set
    /// Element to anchor the ExpandingCard to.
    abstract targetElement: HTMLElement option with get, set
    /// Callback upon focus or mouse enter event
    abstract onEnter: (obj option -> unit) option with get, set
    /// Callback upon blur or mouse leave event
    abstract onLeave: (obj option -> unit) option with get, set
    /// Height of compact card
    abstract compactCardHeight: float option with get, set
    /// Height of expanded card
    abstract expandedCardHeight: float option with get, set
    /// Use to open the card in expanded format and not wait for the delay
    abstract mode: ExpandingCardMode option with get, set
    /// Theme provided by HOC.
    abstract theme: ITheme option with get, set
    /// How the element should be positioned
    abstract directionalHint: DirectionalHint option with get, set
    /// The gap between the card and the target
    abstract gapSpace: float option with get, set
    /// Custom styles for this component
    abstract styles: IExpandingCardStyles option with get, set
    /// Make callout content show on the set side
    abstract directionalHintFixed: bool option with get, set
    /// Trap focus or not
    abstract trapFocus: bool option with get, set
    /// Focus on first element by default on card or not
    abstract firstFocus: bool option with get, set

type [<RequireQualifiedAccess>] ExpandingCardMode =
    | Compact = 0
    | Expanded = 1

type [<RequireQualifiedAccess>] OpenCardMode =
    | Hover = 0
    | HotKey = 1

type [<AllowNullLiteral>] IExpandingCardStyles =
    /// Style for the root element in the default enabled, non-toggled state.
    abstract root: IStyle option with get, set
    /// Style for the main card element.
    abstract compactCard: IStyle option with get, set
    /// Base Style for the expanded card content
    abstract expandedCard: IStyle option with get, set
    /// Style for the expanded card scroll content
    abstract expandedCardScroll: IStyle option with get, set
type BaseComponent = ______Utilities.BaseComponent
type IExpandingCardProps = __ExpandingCard_types.IExpandingCardProps
type DirectionalHint = ______common_DirectionalHint.DirectionalHint

type [<AllowNullLiteral>] IExports =
    abstract ExpandingCard: ExpandingCardStatic

type [<AllowNullLiteral>] IExpandingCardState =
    abstract firstFrameRendered: bool with get, set
    abstract needsScroll: bool with get, set

type [<AllowNullLiteral>] ExpandingCard =
    inherit BaseComponent<IExpandingCardProps, IExpandingCardState>
    abstract defaultProps: obj with get, set
    abstract _styles: obj with get, set
    abstract _callout: obj with get, set
    abstract _expandedElem: obj with get, set
    abstract componentDidMount: unit -> unit
    abstract componentWillUnmount: unit -> unit
    abstract render: unit -> JSX.Element
    abstract _onKeyDown: obj with get, set
    abstract _onRenderCompactCard: obj with get, set
    abstract _onRenderExpandedCard: obj with get, set
    abstract _checkNeedsScroll: obj with get, set

type [<AllowNullLiteral>] ExpandingCardStatic =
    [<Emit "new $0($1...)">] abstract Create: props: IExpandingCardProps -> ExpandingCard
type HoverCard = __HoverCard.HoverCard
type IExpandingCardProps = __ExpandingCard_types.IExpandingCardProps
type IStyle = ______Styling.IStyle

type [<AllowNullLiteral>] IHoverCard =
    interface end

/// HoverCard component props.
type [<AllowNullLiteral>] IHoverCardProps =
    inherit React.HTMLAttributes<U2<HTMLDivElement, HoverCard>>
    /// Optional callback to access the IHoverCardHost interface. Use this instead of ref for accessing
    /// the public methods and properties of the component.
    abstract componentRef: (IHoverCard option -> unit) option with get, set
    /// Additional properties to pass through for HoverCard, reference detail properties in IHoverCardProps
    abstract expandingCardProps: IExpandingCardProps option with get, set
    /// Whether or not to mark the container as described by the hover card.
    /// If not specified, the caller should mark as element as described by the hover card id.
    abstract setAriaDescribedBy: bool option with get, set
    /// Length of compact card delay
    abstract cardOpenDelay: float option with get, set
    /// Length of card dismiss delay. A min number is necessary for pointer to hop between target and card
    abstract cardDismissDelay: float option with get, set
    /// Time in ms when expanded card should open after compact card
    abstract expandedCardOpenDelay: float option with get, set
    /// If true disables Card dismiss upon mouse leave, so that card sticks around.
    abstract sticky: bool option with get, set
    /// Enables instant open of the full card upon click
    abstract instantOpenOnClick: bool option with get, set
    /// Custom styles for this component
    abstract styles: IHoverCardStyles option with get, set
    /// Optional target element to tag hover card on
    abstract target: U2<HTMLElement, string> option with get, set
    /// Callback when card becomes visible
    abstract onCardVisible: (unit -> unit) option with get, set
    /// Callback when card hides
    abstract onCardHide: (unit -> unit) option with get, set
    /// Trap focus or not
    abstract trapFocus: bool option with get, set
    /// Should block hover card or not
    abstract shouldBlockHoverCard: (unit -> unit) option with get, set

type [<AllowNullLiteral>] IHoverCardStyles =
    /// Style for the host element in the default enabled, non-toggled state.
    abstract host: IStyle option with get, set
type BaseComponent = ______Utilities.BaseComponent
type IHoverCardProps = __HoverCard_types.IHoverCardProps
type ExpandingCardMode = __ExpandingCard_types.ExpandingCardMode
type OpenCardMode = __ExpandingCard_types.OpenCardMode

type [<AllowNullLiteral>] IExports =
    abstract HoverCard: HoverCardStatic

type [<AllowNullLiteral>] IHoverCardState =
    abstract isHoverCardVisible: bool option with get, set
    abstract mode: ExpandingCardMode option with get, set
    abstract openMode: OpenCardMode option with get, set

type [<AllowNullLiteral>] HoverCard =
    inherit BaseComponent<IHoverCardProps, IHoverCardState>
    abstract defaultProps: obj with get, set
    abstract _hoverCard: obj with get, set
    abstract _dismissTimerId: obj with get, set
    abstract _openTimerId: obj with get, set
    abstract _currentMouseTarget: obj with get, set
    abstract _styles: obj with get, set
    abstract componentDidMount: unit -> unit
    abstract componentDidUpdate: prevProps: IHoverCardProps * prevState: IHoverCardState -> unit
    abstract render: unit -> JSX.Element
    abstract _getTargetElement: unit -> unit
    abstract _shouldBlockHoverCard: unit -> unit
    abstract _cardOpen: obj with get, set
    abstract _executeCardOpen: obj with get, set
    abstract _cardDismiss: obj with get, set
    abstract _executeCardDimiss: obj with get, set
    abstract _instantOpenAsExpanded: obj with get, set

type [<AllowNullLiteral>] HoverCardStatic =
    [<Emit "new $0($1...)">] abstract Create: props: IHoverCardProps -> HoverCard
type IKeytipProps = ______Keytip.IKeytipProps

type [<AllowNullLiteral>] IKeytipDataProps =
    /// IKeytipProps to create from this KeytipData
    /// If no keytipProps are defined, a keytip won't be registered
    abstract keytipProps: IKeytipProps option with get, set
    /// String to add to the aria-describedby generated by this KeytipData
    /// It will prepend this string to the generated aria-describedby property
    abstract ariaDescribedBy: string option with get, set
    /// T/F if this keytip should be disabled upon creation
    abstract disabled: bool option with get, set
type BaseComponent = ______Utilities.BaseComponent
type IRenderComponent = ______Utilities.IRenderComponent
type IKeytipDataProps = __KeytipData_types.IKeytipDataProps

type [<AllowNullLiteral>] IExports =
    abstract KeytipData: KeytipDataStatic

/// A small element to help the target component correctly read out its aria-describedby for its Keytip
type [<AllowNullLiteral>] KeytipData =
    inherit BaseComponent<obj, obj>
    abstract _uniqueId: obj with get, set
    abstract _keytipManager: obj with get, set
    abstract componentDidMount: unit -> unit
    abstract componentWillUnmount: unit -> unit
    abstract componentDidUpdate: unit -> unit
    abstract render: unit -> JSX.Element
    abstract _getKtpProps: unit -> unit
    /// <summary>Gets the aria- and data- attributes to attach to the component</summary>
    /// <param name="keytipProps"></param>
    /// <param name="describedByPrepend"></param>
    abstract _getKtpAttrs: keytipProps: obj * ?describedByPrepend: obj -> unit

/// A small element to help the target component correctly read out its aria-describedby for its Keytip
type [<AllowNullLiteral>] KeytipDataStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> KeytipData

type [<AllowNullLiteral>] IExports =
    /// <summary>Tests for equality between two IKeytipTransitionKeys.</summary>
    /// <param name="key1">- First IKeytipTransitionKey.</param>
    /// <param name="key2">- Second IKeytipTransitionKey.</param>
    abstract transitionKeysAreEqual: key1: IKeytipTransitionKey * key2: IKeytipTransitionKey -> bool
    /// <summary>Tests if 'key' is present in 'keys'.</summary>
    /// <param name="keys">- Array of IKeytipTransitionKey.</param>
    /// <param name="key">- IKeytipTransitionKey to find in 'keys'.</param>
    abstract transitionKeysContain: keys: ResizeArray<IKeytipTransitionKey> * key: IKeytipTransitionKey -> bool

type [<RequireQualifiedAccess>] KeytipTransitionModifier =
    | Shift = 16
    | Ctrl = 17
    | Alt = 18
    | Meta = 91

type [<AllowNullLiteral>] IKeytipTransitionKey =
    abstract key: string with get, set
    abstract modifierKeys: ResizeArray<KeytipTransitionModifier> option with get, set
type IStyleFunction = ______Utilities.IStyleFunction
type IStyle = ______Styling.IStyle
type IKeytipTransitionKey = ______utilities_keytips_IKeytipTransitionKey.IKeytipTransitionKey

type [<AllowNullLiteral>] IKeytipLayer =
    interface end

type [<AllowNullLiteral>] IKeytipLayerProps =
    inherit React.Props<IKeytipLayer>
    /// Optional callback to access the KeytipLayer component. Use this instead of ref for accessing
    /// the public methods and properties of the component.
    abstract componentRef: (IKeytipLayer option -> unit) option with get, set
    /// String to put inside the layer to be used for the aria-describedby for the component with the keytip
    /// Should be one of the starting sequences
    abstract content: string with get, set
    /// List of key sequences that will start keytips mode
    abstract keytipStartSequences: ResizeArray<IKeytipTransitionKey> option with get, set
    /// List of key sequences that execute the return functionality in keytips (going back to the previous level of keytips)
    abstract keytipReturnSequences: ResizeArray<IKeytipTransitionKey> option with get, set
    /// List of key sequences that will exit keytips mode
    abstract keytipExitSequences: ResizeArray<IKeytipTransitionKey> option with get, set
    /// Callback function triggered when keytip mode is exited
    abstract onExitKeytipMode: (unit -> unit) option with get, set
    /// Callback function triggered when keytip mode is entered
    abstract onEnterKeytipMode: (unit -> unit) option with get, set
    /// getStyles function for KeytipLayer
    abstract getStyles: IStyleFunction<IKeytipLayerStyleProps, IKeytipLayerStyles> option with get, set

type [<AllowNullLiteral>] IKeytipLayerStyles =
    abstract innerContent: IStyle with get, set

type [<AllowNullLiteral>] IKeytipLayerStyleProps =
    interface end

type [<AllowNullLiteral>] IKeytipTreeNode =
    /// ID of the <Keytip> DOM element. Needed to locate the correct keytip in the KeytipLayer's 'keytip' state array
    abstract id: string with get, set
    /// KeySequence that invokes this KeytipTreeNode's onExecute function
    abstract keySequences: ResizeArray<string> with get, set
    /// Overflow set sequence for this keytip
    abstract overflowSetSequence: ResizeArray<string> option with get, set
    /// Control's execute function for when keytip is invoked, passed from the component to the Manager in the IKeytipProps
    abstract onExecute: (HTMLElement option -> unit) option with get, set
    /// Function to execute when we return to this keytip
    abstract onReturn: (HTMLElement option -> unit) option with get, set
    /// List of keytip IDs that should become visible when this keytip is pressed, can be empty
    abstract children: ResizeArray<string> with get, set
    /// Parent keytip ID
    abstract parent: string with get, set
    /// Whether or not this keytip will have children keytips that are dynamically created (DOM is generated on keytip activation)
    /// Common cases are keytips in a menu or modal
    abstract hasDynamicChildren: bool option with get, set
    /// Whether or not this keytip belongs to a component that has a menu
    /// Keytip mode will stay on when a menu is opened, even if the items in that menu have no keytips
    abstract hasMenu: bool option with get, set
    /// T/F if this keytip's component is currently disabled
    abstract disabled: bool option with get, set
    /// T/F if this keytip is a persisted keytip
    abstract persisted: bool option with get, set
type IKeytipProps = ______Keytip.IKeytipProps
type IKeytipTreeNode = __IKeytipTreeNode.IKeytipTreeNode

type [<AllowNullLiteral>] IExports =
    abstract KeytipTree: KeytipTreeStatic

/// This class is responsible for handling the parent/child relationships between keytips
type [<AllowNullLiteral>] KeytipTree =
    abstract currentKeytip: IKeytipTreeNode option with get, set
    abstract root: IKeytipTreeNode with get, set
    abstract nodeMap: obj with get, set
    /// <summary>Add a keytip node to this KeytipTree</summary>
    /// <param name="keytipProps">- Keytip to add to the Tree</param>
    /// <param name="uniqueID">- Unique ID for this keytip</param>
    /// <param name="persisted">- T/F if this keytip should be marked as persisted</param>
    abstract addNode: keytipProps: IKeytipProps * uniqueID: string * ?persisted: bool -> unit
    /// <summary>Updates a node in the tree</summary>
    /// <param name="keytipProps">- Keytip props to update</param>
    /// <param name="uniqueID">- Unique ID for this keytip</param>
    abstract updateNode: keytipProps: IKeytipProps * uniqueID: string -> unit
    /// Removes a node from the KeytipTree
    abstract removeNode: keytipProps: IKeytipProps * uniqueID: string -> unit
    /// <summary>Searches the currentKeytip's children to exactly match a sequence. Will not match disabled nodes but
    /// will match persisted nodes</summary>
    /// <param name="keySequence">- string to match</param>
    /// <param name="currentKeytip">- The keytip who's children will try to match</param>
    abstract getExactMatchedNode: keySequence: string * currentKeytip: IKeytipTreeNode -> IKeytipTreeNode option
    /// <summary>Searches the currentKeytip's children to find nodes that start with the given sequence. Will not match
    /// disabled nodes but will match persisted nodes</summary>
    /// <param name="keySequence">- string to partially match</param>
    /// <param name="currentKeytip">- The keytip who's children will try to partially match</param>
    abstract getPartiallyMatchedNodes: keySequence: string * currentKeytip: IKeytipTreeNode -> ResizeArray<IKeytipTreeNode>
    /// <summary>Get the non-persisted children of the give node
    /// If no node is given, will use the 'currentKeytip'</summary>
    /// <param name="node">- Node to get the children for</param>
    abstract getChildren: ?node: IKeytipTreeNode -> ResizeArray<string>
    /// <summary>Gets all nodes from their IDs</summary>
    /// <param name="ids">List of keytip IDs</param>
    abstract getNodes: ids: ResizeArray<string> -> ResizeArray<IKeytipTreeNode>
    /// <summary>Gets a single node from its ID</summary>
    /// <param name="id">- ID of the node to get</param>
    abstract getNode: id: string -> IKeytipTreeNode option
    /// <summary>Tests if the currentKeytip in this.keytipTree is the parent of 'keytipProps'</summary>
    /// <param name="keytipProps">- Keytip to test the parent for</param>
    abstract isCurrentKeytipParent: keytipProps: IKeytipProps -> bool
    abstract _getParentID: fullSequence: obj -> unit
    abstract _getFullSequence: keytipProps: obj -> unit
    abstract _getNodeSequence: node: obj -> unit
    abstract _createNode: id: obj * keySequences: obj * parentId: obj * children: obj * ?hasDynamicChildren: obj * ?overflowSetSequence: obj * ?hasMenu: obj * ?onExecute: obj * ?onReturn: obj * ?disabled: obj * ?persisted: obj -> unit

/// This class is responsible for handling the parent/child relationships between keytips
type [<AllowNullLiteral>] KeytipTreeStatic =
    /// KeytipTree constructor
    [<Emit "new $0($1...)">] abstract Create: unit -> KeytipTree
type IKeytipLayerProps = __KeytipLayer_types.IKeytipLayerProps
type IKeytipProps = ______Keytip.IKeytipProps
type BaseComponent = ______Utilities.BaseComponent
type KeytipTree = __KeytipTree.KeytipTree
type IKeytipTransitionKey = ______utilities_keytips_IKeytipTransitionKey.IKeytipTransitionKey

type [<AllowNullLiteral>] IExports =
    abstract KeytipLayerBase: KeytipLayerBaseStatic

type [<AllowNullLiteral>] IKeytipLayerState =
    abstract inKeytipMode: bool with get, set
    abstract keytips: ResizeArray<IKeytipProps> with get, set
    abstract visibleKeytips: ResizeArray<IKeytipProps> with get, set

/// A layer that holds all keytip items
type [<AllowNullLiteral>] KeytipLayerBase =
    inherit BaseComponent<IKeytipLayerProps, IKeytipLayerState>
    abstract defaultProps: IKeytipLayerProps with get, set
    abstract _keytipTree: obj with get, set
    abstract _keytipManager: obj with get, set
    abstract _classNames: obj with get, set
    abstract _currentSequence: obj with get, set
    abstract _newCurrentKeytipSequences: obj option with get, set
    abstract _delayedKeytipQueue: obj with get, set
    abstract _delayedQueueTimeout: obj with get, set
    abstract _keyHandled: obj with get, set
    abstract render: unit -> JSX.Element
    abstract componentDidMount: unit -> unit
    abstract componentWillUnmount: unit -> unit
    abstract getCurrentSequence: unit -> string
    abstract getKeytipTree: unit -> KeytipTree
    /// <summary>Processes an IKeytipTransitionKey entered by the user</summary>
    /// <param name="transitionKey">- IKeytipTransitionKey received by the layer to process</param>
    abstract processTransitionInput: transitionKey: IKeytipTransitionKey -> unit
    /// <summary>Processes inputs from the document listener and traverse the keytip tree</summary>
    /// <param name="key">- Key pressed by the user</param>
    abstract processInput: key: string -> unit
    /// <summary>Show the given keytips and hide all others</summary>
    /// <param name="ids">- Keytip IDs to show</param>
    abstract showKeytips: ids: ResizeArray<string> -> unit
    /// Enters keytip mode for this layer
    abstract _enterKeytipMode: unit -> unit
    /// Exits keytip mode for this layer
    abstract _exitKeytipMode: unit -> unit
    /// <summary>Sets the keytips state property</summary>
    /// <param name="keytipProps">- Keytips to set in this layer</param>
    abstract _setKeytips: ?keytipProps: obj -> unit
    /// <summary>Callback function to use for persisted keytips</summary>
    /// <param name="overflowButtonSequences">- The overflow button sequence to execute</param>
    /// <param name="keytipSequences">- The keytip that should become the 'currentKeytip' when it is registered</param>
    abstract _persistedKeytipExecute: overflowButtonSequences: obj * keytipSequences: obj -> unit
    abstract _getVisibleKeytips: keytips: obj -> unit
    abstract _onDismiss: obj with get, set
    abstract _onKeyDown: obj with get, set
    /// <summary>Gets the ModifierKeyCodes based on the keyboard event</summary>
    /// <param name="ev">- React.KeyboardEvent</param>
    abstract _getModifierKey: key: obj * ev: obj -> unit
    abstract _onKeyPress: obj with get, set
    abstract _onKeytipAdded: obj with get, set
    abstract _onKeytipUpdated: obj with get, set
    abstract _onKeytipRemoved: obj with get, set
    abstract _onPersistedKeytipAdded: obj with get, set
    abstract _onPersistedKeytipRemoved: obj with get, set
    abstract _onPersistedKeytipExecute: obj with get, set
    /// <summary>Trigger a keytip immediately and set it as the current keytip</summary>
    /// <param name="keytipProps">- Keytip to trigger immediately</param>
    abstract _triggerKeytipImmediately: keytipProps: obj -> unit
    abstract _addKeytipToQueue: keytipID: obj -> unit
    abstract _removeKeytipFromQueue: keytipID: obj -> unit
    /// <summary>Gets the DOM element for the specified keytip</summary>
    /// <param name="keytipId">- ID of the keytip to query for</param>
    abstract _getKeytipDOMElement: keytipId: obj -> unit
    /// <summary>Returns T/F if the keytipProps keySequences match the currentKeytip, and the currentKeytip is in an overflow well
    /// This will make 'keytipProps' the new currentKeytip</summary>
    /// <param name="keytipProps">- Keytip props to check</param>
    abstract _isCurrentKeytipAnAlias: keytipProps: obj -> unit
    /// Sets if we are in keytip mode.
    /// Note, this sets both the state for the layer as well as
    /// the value that the manager will expose externally.
    abstract _setInKeytipMode: obj with get, set

/// A layer that holds all keytip items
type [<AllowNullLiteral>] KeytipLayerBaseStatic =
    [<Emit "new $0($1...)">] abstract Create: props: IKeytipLayerProps * context: obj option -> KeytipLayerBase
type ITheme = ______Styling.ITheme

type [<AllowNullLiteral>] ILabel =
    interface end

type [<AllowNullLiteral>] ILabelProps =
    inherit React.LabelHTMLAttributes<HTMLLabelElement>
    /// Optional callback to access the ILabel interface. Use this instead of ref for accessing
    /// the public methods and properties of the component.
    abstract componentRef: (ILabel option -> unit) option with get, set
    /// Whether the associated form field is required or not
    abstract required: bool option with get, set
    /// Renders the label as disabled.
    abstract disabled: bool option with get, set
    /// Theme provided by HOC.
    abstract theme: ITheme option with get, set
type BaseComponent = ______Utilities.BaseComponent
type ILabelProps = __Label_types.ILabelProps

type [<AllowNullLiteral>] IExports =
    abstract Label: LabelStatic

type [<AllowNullLiteral>] Label =
    inherit BaseComponent<ILabelProps, obj>
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] LabelStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> Label
type BaseComponent = ______Utilities.BaseComponent
type ILink = __Link_types.ILink
type ILinkProps = __Link_types.ILinkProps

type [<AllowNullLiteral>] IExports =
    abstract LinkBase: LinkBaseStatic

type [<AllowNullLiteral>] LinkBase =
    inherit BaseComponent<ILinkProps, obj option>
    inherit ILink
    abstract _link: obj with get, set
    abstract render: unit -> JSX.Element
    abstract focus: unit -> unit
    abstract _onClick: obj with get, set

type [<AllowNullLiteral>] LinkBaseStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> LinkBase
type LinkBase = __Link_base.LinkBase
type IStyle = ______Styling.IStyle
type ITheme = ______Styling.ITheme
type IStyleFunction = ______Utilities.IStyleFunction
type IKeytipProps = ______Keytip.IKeytipProps

type [<AllowNullLiteral>] ILink =
    /// Sets focus to the link. 
    abstract focus: unit -> unit

type [<AllowNullLiteral>] ILinkProps =
    inherit React.AllHTMLAttributes<U4<HTMLAnchorElement, HTMLButtonElement, HTMLElement, LinkBase>>
    /// Optional callback to access the ILink interface. Use this instead of ref for accessing
    /// the public methods and properties of the component.
    abstract componentRef: (ILink option -> unit) option with get, set
    /// Whether the link is disabled
    abstract disabled: bool option with get, set
    /// Call to provide customized styling that will layer on top of the variant rules.
    abstract getStyles: IStyleFunction<ILinkStyleProps, ILinkStyles> option with get, set
    /// Theme (provided through customization.)
    abstract theme: ITheme option with get, set
    /// Optional keytip for this Link
    abstract keytipProps: IKeytipProps option with get, set

type [<AllowNullLiteral>] ILinkStyleProps =
    abstract className: string option with get, set
    abstract isButton: bool option with get, set
    abstract isDisabled: bool option with get, set
    abstract theme: ITheme with get, set

type [<AllowNullLiteral>] ILinkStyles =
    abstract root: IStyle with get, set
type BaseButton = ______Button.BaseButton
type Button = ______Button.Button

type [<AllowNullLiteral>] IMessageBar =
    interface end

type [<AllowNullLiteral>] IMessageBarProps =
    inherit React.HTMLAttributes<HTMLElement>
    /// Optional callback to access the IMessageBar interface. Use this instead of ref for accessing
    /// the public methods and properties of the component.
    abstract componentRef: (IMessageBar option -> unit) option with get, set
    /// The type of MessageBar to render.
    abstract messageBarType: MessageBarType option with get, set
    /// The actions you want to show on the other side.
    abstract actions: JSX.Element option with get, set
    /// A description of the message bar for the benefit of screen readers.
    abstract ariaLabel: string option with get, set
    /// Whether the message bar has a dismiss button and its callback.
    /// If null, we don't show a dismiss button.
    abstract onDismiss: (React.MouseEvent<U5<HTMLButtonElement, BaseButton, HTMLAnchorElement, HTMLDivElement, Button>> -> obj option) option with get, set
    /// Determines if the message bar is multi lined.
    /// If false, and the text overflows over buttons or to another line, it is clipped.
    abstract isMultiline: bool option with get, set
    /// Aria label on dismiss button if onDismiss is defined.
    abstract dismissButtonAriaLabel: string option with get, set
    /// Determines if the message bar text is truncated.
    /// If true, a button will render to toggle between a single line view and multiline view.
    /// This prop is for single line message bars with no buttons only in a limited space scenario.
    abstract truncated: bool option with get, set
    /// Aria label on overflow button if truncated is defined.
    abstract overflowButtonAriaLabel: string option with get, set

type [<RequireQualifiedAccess>] MessageBarType =
    | Info = 0
    | Error = 1
    | Blocked = 2
    | SevereWarning = 3
    | Success = 4
    | Warning = 5
    | Remove = 90000
type BaseComponent = ______Utilities.BaseComponent
type IMessageBarProps = __MessageBar_types.IMessageBarProps

type [<AllowNullLiteral>] IExports =
    abstract MessageBar: MessageBarStatic

type [<AllowNullLiteral>] IMessageBarState =
    abstract labelId: string option with get, set
    abstract showContent: bool option with get, set
    abstract expandSingleLine: bool option with get, set

type [<AllowNullLiteral>] MessageBar =
    inherit BaseComponent<IMessageBarProps, IMessageBarState>
    abstract defaultProps: IMessageBarProps with get, set
    abstract ICON_MAP: obj with get, set
    abstract render: unit -> JSX.Element
    abstract _getActionsDiv: unit -> unit
    abstract _getClassName: unit -> unit
    abstract _getDismissDiv: unit -> unit
    abstract _getDismissSingleLine: unit -> unit
    abstract _getExpandSingleLine: unit -> unit
    abstract _getIconSpan: unit -> unit
    abstract _renderMultiLine: unit -> unit
    abstract _renderSingleLine: unit -> unit
    abstract _renderInnerText: unit -> unit
    abstract _getAnnouncementPriority: unit -> unit
    abstract _onClick: obj with get, set

type [<AllowNullLiteral>] MessageBarStatic =
    [<Emit "new $0($1...)">] abstract Create: props: IMessageBarProps -> MessageBar
type ISelection = ______utilities_selection_interfaces.ISelection
type ITheme = ______Styling.ITheme
type IStyle = ______Styling.IStyle
type IStyleFunction = ______Utilities.IStyleFunction

type [<AllowNullLiteral>] IMarqueeSelection =
    interface end

type [<AllowNullLiteral>] IMarqueeSelectionProps =
    inherit React.HTMLAttributes<HTMLDivElement>
    /// Optional callback to access the IMarqueeSelection interface. Use this instead of ref for accessing
    /// the public methods and properties of the component.
    abstract componentRef: (IMarqueeSelection option -> unit) option with get, set
    /// The selection object to interact with when updating selection changes.
    abstract selection: ISelection with get, set
    /// Optional props to mix into the root DIV element.
    abstract rootProps: React.HTMLAttributes<HTMLDivElement> option with get, set
    /// Optional callback that is called, when the mouse down event occurs, in order to determine
    /// if we should start a marquee selection. If true is returned, we will cancel the mousedown
    /// event to prevent upstream mousedown handlers from executing.
    abstract onShouldStartSelection: (MouseEvent -> bool) option with get, set
    /// Optional flag to control the enabled state of marquee selection. This allows you to render
    /// it and have events all ready to go, but conditionally disable it. That way transitioning
    /// between enabled/disabled generate no difference in the DOM.
    abstract isEnabled: bool option with get, set
    /// Optional flag to restrict the drag rect to the root element, instead of allowing the drag
    /// rect to start outside of the root element boundaries.
    abstract isDraggingConstrainedToRoot: bool option with get, set
    /// Additional CSS class(es) to apply to the MarqueeSelection.
    abstract className: string option with get, set
    /// Theme (provided through customization.)
    abstract theme: ITheme option with get, set
    /// Call to provide customized styling that will layer on top of the variant rules.
    abstract getStyles: IStyleFunction<IMarqueeSelectionStyleProps, IMarqueeSelectionStyles> option with get, set

type [<AllowNullLiteral>] IMarqueeSelectionStyleProps =
    abstract theme: ITheme with get, set
    abstract className: string option with get, set

type [<AllowNullLiteral>] IMarqueeSelectionStyles =
    abstract root: IStyle option with get, set
    abstract dragMask: IStyle option with get, set
    abstract box: IStyle option with get, set
    abstract boxFill: IStyle option with get, set
type IStyle = ______Styling.IStyle
type ITheme = ______Styling.ITheme
type IRenderFunction = ______Utilities.IRenderFunction
type IStyleFunction = ______Utilities.IStyleFunction
type IIconProps = ___Icon_Icon_types.IIconProps

type [<AllowNullLiteral>] INav =
    /// The meta 'key' property of the currently selected NavItem of the Nav. Can return
    /// undefined if the currently selected nav item has no populated key property. Be aware
    /// that in order for Nav to properly understand which key is selected all NavItems in
    /// all groups of the Nav must have populated key properties.
    abstract selectedKey: string option with get, set

type [<AllowNullLiteral>] INavProps =
    /// Optional callback to access the INav interface. Use this instead of ref for accessing
    /// the public methods and properties of the component.
    abstract componentRef: (INav option -> unit) option with get, set
    /// Call to provide customized styling that will layer on top of the variant rules
    abstract getStyles: IStyleFunction<INavStyleProps, INavStyles> option with get, set
    /// Theme provided by HOC.
    abstract theme: ITheme option with get, set
    /// Additional css class to apply to the Nav
    abstract className: string option with get, set
    /// A collection of link groups to display in the navigation bar
    abstract groups: ResizeArray<INavLinkGroup> option with get, set
    /// Used to customize how content inside the link tag is rendered
    abstract onRenderLink: IRenderFunction<INavLink> option with get, set
    /// Function callback invoked when a link in the navigation is clicked
    abstract onLinkClick: (React.MouseEvent<HTMLElement> -> INavLink -> unit) option with get, set
    /// Function callback invoked when the chevron on a link is clicked
    abstract onLinkExpandClick: (React.MouseEvent<HTMLElement> -> INavLink -> unit) option with get, set
    /// Indicates whether the navigation component renders on top of other content in the UI
    abstract isOnTop: bool option with get, set
    /// (Optional) The key of the nav item initially selected.
    abstract initialSelectedKey: string option with get, set
    /// (Optional) The key of the nav item selected by caller.
    abstract selectedKey: string option with get, set
    /// (Optional) The nav container aria label.
    abstract ariaLabel: string option with get, set
    /// (Optional) The nav container aria label.
    abstract expandButtonAriaLabel: string option with get, set
    /// Deprecated at v0.68.1 and will be removed at >= V1.0.0.
    abstract expandedStateText: string option with get, set
    /// Deprecated at v0.68.1 and will be removed at >= V1.0.0.
    abstract collapsedStateText: string option with get, set

type [<AllowNullLiteral>] INavLinkGroup =
    /// Text to render as the header of a group
    abstract name: string option with get, set
    /// Links to render within this group
    abstract links: ResizeArray<INavLink> with get, set
    /// The name to use for functional automation tests
    abstract automationId: string option with get, set
    /// If true, the group should render collapsed by default
    abstract collapseByDefault: bool option with get, set
    /// Callback invoked when a group header is clicked
    abstract onHeaderClick: (React.MouseEvent<HTMLElement> -> bool -> unit) option with get, set

type [<AllowNullLiteral>] INavLink =
    /// Text to render for this link
    abstract name: string with get, set
    /// URL to navigate to for this link
    abstract url: string with get, set
    /// Meta info for the link server, if negative, client side added node.
    abstract key: string option with get, set
    /// Child links to this link, if any
    abstract links: ResizeArray<INavLink> option with get, set
    /// Callback invoked when this link is clicked. Providing this callback will cause the link
    /// to render as a button (rather than an anchor) unless forceAnchor is set to true.
    abstract onClick: (React.MouseEvent<HTMLElement> -> INavLink -> unit) option with get, set
    /// button icon name if applied
    abstract icon: string option with get, set
    /// Deprecated. Use iconProps.className instead.
    abstract iconClassName: string option with get, set
    /// button icon props if applied
    abstract iconProps: IIconProps option with get, set
    /// Deprecated at v0.68.1 and will be removed at >= v1.0.0.
    abstract engagementName: string option with get, set
    /// Deprecated at v0.68.1 and will be removed at >= v1.0.0.
    abstract altText: string option with get, set
    /// The name to use for functional automation tests
    abstract automationId: string option with get, set
    /// Whether or not the link is in an expanded state
    abstract isExpanded: bool option with get, set
    /// Aria label for nav link
    abstract ariaLabel: string option with get, set
    /// title for tooltip or description
    abstract title: string option with get, set
    /// Link <a> target.
    abstract target: string option with get, set
    /// Point to the parent node key.  This is used in EditNav when move node from sublink to
    ///    parent link vs vers.
    abstract parentId: string option with get, set
    /// (Optional) By default, any link with onClick defined will render as a button.
    /// Set this property to true to override that behavior. (Links without onClick defined
    /// will render as anchors by default.)
    abstract forceAnchor: bool option with get, set
    /// (Optional) Any additional properties to apply to the rendered links.
    [<Emit "$0[$1]{{=$2}}">] abstract Item: propertyName: string -> obj option with get, set

type [<AllowNullLiteral>] INavStyleProps =
    /// Accept theme prop.
    abstract theme: ITheme with get, set
    /// Accept custom classNames
    abstract className: string option with get, set
    /// is element on top boolean
    abstract isOnTop: bool option with get, set
    /// is element a link boolean
    abstract isLink: bool option with get, set
    /// is element a group boolean
    abstract isGroup: bool option with get, set
    /// is element expanded boolean
    abstract isExpanded: bool option with get, set
    /// is element selected boolean
    abstract isSelected: bool option with get, set
    /// is button
    abstract isButtonEntry: bool option with get, set
    /// Nav height value
    abstract navHeight: float option with get, set
    /// left padding value
    abstract leftPadding: float option with get, set
    /// left padding when expanded value
    abstract leftPaddingExpanded: float option with get, set
    /// right padding value
    abstract rightPadding: float option with get, set
    /// position value
    abstract position: float option with get, set
    /// Inherited from INavProps
    /// A collection of link groups to display in the navigation bar
    abstract groups: ResizeArray<INavLinkGroup> option with get, set

type [<AllowNullLiteral>] INavStyles =
    /// Style set for the root element.
    abstract root: IStyle with get, set
    /// Style set for the link text container div element.
    abstract linkText: IStyle with get, set
    /// Style set for the link element extending the
    /// root style set for ActionButton component.
    abstract link: IStyle with get, set
    /// Style set for the composite link container div element
    abstract compositeLink: IStyle with get, set
    /// Style set for the chevron button inside the composite
    /// link and group elements.
    abstract chevronButton: IStyle with get, set
    /// Style set for the chevron icon inside the composite
    /// link and group elements.
    abstract chevronIcon: IStyle with get, set
    /// Style set for the nav links ul element.
    abstract navItems: IStyle with get, set
    /// Style set for the nav links li element.
    abstract navItem: IStyle with get, set
    /// Style set for the group root div.
    abstract group: IStyle with get, set
    /// Style set for the group content div inside group.
    abstract groupContent: IStyle with get, set
type BaseComponent = ______Utilities.BaseComponent
type INav = __Nav_types.INav
type INavProps = __Nav_types.INavProps

type [<AllowNullLiteral>] IExports =
    abstract isRelativeUrl: url: string -> bool
    abstract NavBase: NavBaseStatic

type [<AllowNullLiteral>] INavState =
    abstract isGroupCollapsed: obj option with get, set
    abstract isLinkExpandStateChanged: bool option with get, set
    abstract selectedKey: string option with get, set

type [<AllowNullLiteral>] NavBase =
    inherit BaseComponent<INavProps, INavState>
    inherit INav
    abstract defaultProps: INavProps with get, set
    abstract componentWillReceiveProps: newProps: INavProps -> unit
    abstract render: unit -> JSX.Element option
    abstract selectedKey: string option
    abstract _onRenderLink: obj with get, set
    abstract _renderNavLink: link: obj * linkIndex: obj * nestingLevel: obj -> unit
    abstract _renderCompositeLink: link: obj * linkIndex: obj * nestingLevel: obj -> unit
    abstract _renderLink: link: obj * linkIndex: obj * nestingLevel: obj -> unit
    abstract _renderLinks: links: obj * nestingLevel: obj -> unit
    abstract _renderGroup: obj with get, set
    abstract _onGroupHeaderClicked: group: obj * ev: obj -> unit
    abstract _onLinkExpandClicked: link: obj * ev: obj -> unit
    abstract _onNavAnchorLinkClicked: link: obj * ev: obj -> unit
    abstract _onNavButtonLinkClicked: link: obj * ev: obj -> unit
    abstract _isLinkSelected: link: obj -> unit

type [<AllowNullLiteral>] NavBaseStatic =
    [<Emit "new $0($1...)">] abstract Create: props: INavProps -> NavBase
type OverflowSet = __OverflowSet.OverflowSet
type IRenderFunction = ______Utilities.IRenderFunction
type IFocusZoneProps = ______FocusZone.IFocusZoneProps
type IKeytipProps = ______Keytip.IKeytipProps

type [<AllowNullLiteral>] IOverflowSet =
    /// <summary>Sets focus to the first tabbable item in the zone.</summary>
    /// <param name="forceIntoFirstElement">If true, focus will be forced into the first element, even if focus is already in the focus zone.</param>
    abstract focus: ?forceIntoFirstElement: bool -> bool
    /// <summary>Sets focus to a specific child element within the zone. This can be used in conjunction with
    /// onBeforeFocus to created delayed focus scenarios (like animate the scroll position to the correct
    /// location and then focus.)</summary>
    /// <param name="childElement">The child element within the zone to focus.</param>
    abstract focusElement: ?childElement: HTMLElement -> bool

type [<AllowNullLiteral>] IOverflowSetProps =
    inherit React.Props<OverflowSet>
    /// Gets the component ref.
    abstract componentRef: (IOverflowSet option -> unit) option with get, set
    /// Class name
    abstract className: string option with get, set
    /// An array of items to be rendered by your onRenderItem function in the primary content area
    abstract items: ResizeArray<IOverflowSetItemProps> option with get, set
    /// Change item layout direction to vertical/stacked.
    abstract vertical: bool option with get, set
    /// An array of items to be passed to overflow contextual menu
    abstract overflowItems: ResizeArray<IOverflowSetItemProps> option with get, set
    /// Method to call when trying to render an item.
    abstract onRenderItem: (IOverflowSetItemProps -> obj option) with get, set
    /// Rendering method for overflow button and contextual menu. The argument to the function is
    /// the overflowItems passed in as props to this function.
    abstract onRenderOverflowButton: IRenderFunction<ResizeArray<obj option>> with get, set
    /// Custom properties for OverflowSet's FocusZone.
    /// If doNotContainWithinFocusZone is set to true focusZoneProps will be ignored.
    /// Use one or the other.
    abstract focusZoneProps: IFocusZoneProps option with get, set
    /// If true do not contain the OverflowSet inside of a FocusZone,
    /// otherwise the OverflowSet will contain a FocusZone.
    /// If this is set to true focusZoneProps will be ignored.
    /// Use one or the other.
    abstract doNotContainWithinFocusZone: bool option with get, set
    /// The role for the OverflowSet.
    abstract role: string option with get, set
    /// Optional full keytip sequence for the overflow button, if it will have a keytip.
    abstract keytipSequences: ResizeArray<string> option with get, set
    /// Function that will take in an IOverflowSetItemProps and return the subMenu for that item.
    /// If not provided, will use 'item.subMenuProps.items' by default.
    /// This is only used if your overflow set has keytips.
    abstract itemSubMenuProvider: (IOverflowSetItemProps -> ResizeArray<obj option> option) option with get, set

type [<AllowNullLiteral>] IOverflowSetItemProps =
    /// Unique id to identify the item.
    abstract key: string with get, set
    /// Optional keytip for the overflowSetItem.
    abstract keytipProps: IKeytipProps option with get, set
    /// Any additional properties to use when custom rendering menu items.
    [<Emit "$0[$1]{{=$2}}">] abstract Item: propertyName: string -> obj option with get, set
type BaseComponent = ______Utilities.BaseComponent
type IOverflowSet = __OverflowSet_types.IOverflowSet
type IOverflowSetProps = __OverflowSet_types.IOverflowSetProps

type [<AllowNullLiteral>] IExports =
    abstract OverflowSet: OverflowSetStatic

type [<AllowNullLiteral>] OverflowSet =
    inherit BaseComponent<IOverflowSetProps, obj>
    inherit IOverflowSet
    abstract _focusZone: obj with get, set
    abstract _persistedKeytips: obj with get, set
    abstract _keytipManager: obj with get, set
    abstract _divContainer: obj with get, set
    abstract render: unit -> JSX.Element
    /// <summary>Sets focus to the first tabbable item in the OverflowSet.</summary>
    /// <param name="forceIntoFirstElement">If true, focus will be forced into the first element,
    /// even if focus is already in theOverflowSet</param>
    abstract focus: ?forceIntoFirstElement: bool -> bool
    /// <summary>Sets focus to a specific child element within the OverflowSet.</summary>
    /// <param name="childElement">The child element within the zone to focus.</param>
    abstract focusElement: ?childElement: HTMLElement -> bool
    abstract componentDidMount: unit -> unit
    abstract componentWillUnmount: unit -> unit
    abstract componentWillUpdate: unit -> unit
    abstract componentDidUpdate: unit -> unit
    abstract _registerPersistedKeytips: unit -> unit
    abstract _unregisterPersistedKeytips: unit -> unit
    abstract _onRenderItems: obj with get, set
    abstract _onRenderOverflowButtonWrapper: obj with get, set
    /// Gets the subMenu for an overflow item
    /// Checks if itemSubMenuProvider has been defined, if not defaults to subMenuProps
    abstract _getSubMenuForItem: item: obj -> unit

type [<AllowNullLiteral>] OverflowSetStatic =
    [<Emit "new $0($1...)">] abstract Create: props: IOverflowSetProps -> OverflowSet
type IStyle = ______Styling.IStyle
type ITheme = ______Styling.ITheme
type IStyleFunction = ______Utilities.IStyleFunction

type [<AllowNullLiteral>] IOverlay =
    interface end

type [<AllowNullLiteral>] IOverlayProps =
    inherit React.HTMLAttributes<HTMLElement>
    /// Gets the component ref.
    abstract componentRef: (IOverlayProps option -> unit) option with get, set
    /// Call to provide customized styling that will layer on top of the variant rules
    abstract getStyles: IStyleFunction<IOverlayStyleProps, IOverlayStyles> option with get, set
    /// Theme provided by HOC.
    abstract theme: ITheme option with get, set
    /// Additional css class to apply to the Overlay
    abstract className: string option with get, set
    /// Whether to use the dark-themed overlay.
    abstract isDarkThemed: bool option with get, set
    abstract onClick: (unit -> unit) option with get, set

type [<AllowNullLiteral>] IOverlayStyleProps =
    /// Accept theme prop.
    abstract theme: ITheme with get, set
    /// Accept custom classNames
    abstract className: string option with get, set
    /// Is overlay visible
    abstract isNone: bool option with get, set
    /// Is overlay dark themed
    abstract isDark: bool option with get, set

type [<AllowNullLiteral>] IOverlayStyles =
    /// Style for the root element.
    abstract root: IStyle with get, set
type BaseComponent = ______Utilities.BaseComponent
type IOverlayProps = __Overlay_types.IOverlayProps

type [<AllowNullLiteral>] IExports =
    abstract OverlayBase: OverlayBaseStatic

type [<AllowNullLiteral>] OverlayBase =
    inherit BaseComponent<IOverlayProps, obj>
    abstract componentDidMount: unit -> unit
    abstract componentWillUnmount: unit -> unit
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] OverlayBaseStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> OverlayBase
type IRenderFunction = ______Utilities.IRenderFunction
type IKeytipProps = ______Keytip.IKeytipProps

type [<AllowNullLiteral>] IPivotItemProps =
    inherit React.HTMLAttributes<HTMLDivElement>
    /// Gets the component ref.
    abstract componentRef: (unit -> unit) option with get, set
    /// The text displayed of each pivot link - renaming to 'headerText'.
    abstract linkText: string option with get, set
    /// The text displayed of each pivot link.
    abstract headerText: string option with get, set
    /// Props for the header command button supporting native props - data-* and aria-* - for each pivot header/link element
    abstract headerButtonProps: obj option with get, set
    /// An required key to uniquely identify a pivot item.
    /// 
    /// Note: The 'key' from react props cannot be used inside component.
    abstract itemKey: string option with get, set
    /// The aria label of each pivot link which will read by screen reader instead of linkText.
    /// 
    /// Note that unless you have compelling requirements you should not override aria-label.
    abstract ariaLabel: string option with get, set
    /// An optional item count that gets displayed just after the linkText(itemCount)
    /// 
    /// Example: completed(4)
    abstract itemCount: float option with get, set
    /// An optional icon to show next to the pivot link.
    abstract itemIcon: string option with get, set
    /// Optional custom renderer for the pivot item link
    abstract onRenderItemLink: IRenderFunction<IPivotItemProps> option with get, set
    /// Optional keytip for this PivotItem
    abstract keytipProps: IKeytipProps option with get, set
type BaseComponent = ______Utilities.BaseComponent
type IPivotProps = __Pivot_types.IPivotProps
type IPivotItemProps = __PivotItem_types.IPivotItemProps

type [<AllowNullLiteral>] IExports =
    abstract PivotBase: PivotBaseStatic

/// Usage:
/// 
///   <Pivot>
///     <PivotItem linkText="Foo">
///       <Label>Pivot #1</Label>
///     </PivotItem>
///     <PivotItem linkText="Bar">
///       <Label>Pivot #2</Label>
///     </PivotItem>
///     <PivotItem linkText="Bas">
///       <Label>Pivot #3</Label>
///     </PivotItem>
///   </Pivot>
type [<AllowNullLiteral>] IPivotState =
    abstract links: ResizeArray<IPivotItemProps> with get, set
    abstract selectedKey: string with get, set
    abstract selectedTabId: string with get, set

type [<AllowNullLiteral>] PivotBase =
    inherit BaseComponent<IPivotProps, IPivotState>
    abstract _keyToIndexMapping: obj with get, set
    abstract _keyToTabIds: obj with get, set
    abstract _pivotId: obj with get, set
    abstract focusZone: obj with get, set
    abstract componentWillReceiveProps: nextProps: IPivotProps -> unit
    /// Sets focus to the first pivot tab.
    abstract focus: unit -> unit
    abstract render: unit -> JSX.Element
    /// Renders the set of links to route between pivots
    abstract _renderPivotLinks: unit -> unit
    abstract _renderPivotLink: obj with get, set
    abstract _renderLinkContent: obj with get, set
    /// Renders the current Pivot Item
    abstract _renderPivotItem: unit -> unit
    /// Gets the set of PivotLinks as arrary of IPivotItemProps
    /// The set of Links is determined by child components of type PivotItem
    abstract _getPivotLinks: props: obj -> unit
    /// Generates the Id for the tab button.
    abstract _getTabId: itemKey: obj * index: obj -> unit
    /// whether the key exists in the pivot items.
    abstract _isKeyValid: itemKey: obj -> unit
    /// Handles the onClick event on PivotLinks
    abstract _onLinkClick: itemKey: obj * ev: obj -> unit
    /// Handle the onKeyPress eventon the PivotLinks
    abstract _onKeyPress: itemKey: obj * ev: obj -> unit
    /// Updates the state with the new selected index
    abstract _updateSelectedItem: itemKey: obj * ?ev: obj -> unit

type [<AllowNullLiteral>] PivotBaseStatic =
    [<Emit "new $0($1...)">] abstract Create: props: IPivotProps -> PivotBase
type BaseComponent = ______Utilities.BaseComponent
type IPivotItemProps = __PivotItem_types.IPivotItemProps

type [<AllowNullLiteral>] IExports =
    abstract PivotItem: PivotItemStatic

type [<AllowNullLiteral>] PivotItem =
    inherit BaseComponent<IPivotItemProps, obj>
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] PivotItemStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> PivotItem
type PivotBase = __Pivot_base.PivotBase
type IStyle = ______Styling.IStyle
type ITheme = ______Styling.ITheme
type IStyleFunction = ______Utilities.IStyleFunction
type PivotItem = __PivotItem.PivotItem

type [<AllowNullLiteral>] IPivot =
    /// Sets focus to the first pivot tab.
    abstract focus: unit -> unit

type [<AllowNullLiteral>] IPivotProps =
    inherit React.Props<PivotBase>
    /// Optional callback to access the IPivot interface. Use this instead of ref for accessing
    /// the public methods and properties of the component.
    abstract componentRef: (IPivot option -> unit) option with get, set
    /// Call to provide customized styling that will layer on top of the variant rules.
    abstract getStyles: IStyleFunction<IPivotStyleProps, IPivotStyles> option with get, set
    /// Theme provided by High-Order Component.
    abstract theme: ITheme option with get, set
    /// Additional css class to apply to the Pivot
    abstract className: string option with get, set
    /// The index of the pivot item initially selected.
    /// 
    /// It only works when initialSelectedKey is not defined. You must not use them together.
    abstract initialSelectedIndex: float option with get, set
    /// The key of the pivot item initially selected.
    /// 
    /// It will make initialSelectedIndex not work. You must not use them together.
    abstract initialSelectedKey: string option with get, set
    /// The key of the selected pivot item.
    /// 
    /// If set, this will override the Pivot's selected item state.
    abstract selectedKey: string option with get, set
    /// Callback issued when the selected pivot item is changed
    abstract onLinkClick: (PivotItem -> React.MouseEvent<HTMLElement> -> unit) option with get, set
    /// Specify the PivotLinkSize to use (normal, large)
    abstract linkSize: PivotLinkSize option with get, set
    /// Specify the PivotLinkFormat to use (links, tabs)
    abstract linkFormat: PivotLinkFormat option with get, set
    /// Specify whether to skip rendering the tabpanel with the content of the selected tab.
    /// Use this prop if you plan to separately render the tab content
    /// and don't want to leave an empty tabpanel in the page that may confuse Screen Readers.
    abstract headersOnly: bool option with get, set
    /// Optional. Specify how IDs are generated for each tab header.
    /// Useful if you're rendering content outside and need to connect aria-labelledby.
    abstract getTabId: (string -> float -> string) option with get, set

type [<AllowNullLiteral>] IPivotStyleProps =
    /// Theme provided by High-Order Component.
    abstract theme: ITheme with get, set
    /// Accept custom classNames
    abstract className: string option with get, set
    abstract linkIsSelected: bool option with get, set
    abstract linkIsDisabled: bool option with get, set
    abstract linkIsOverflow: bool option with get, set
    abstract rootIsLarge: bool option with get, set
    abstract rootIsTabs: bool option with get, set

type [<AllowNullLiteral>] IPivotStyles =
    /// Style for the root element.
    abstract root: IStyle with get, set
    abstract links: IStyle with get, set
    abstract link: IStyle with get, set
    abstract text: IStyle with get, set
    abstract count: IStyle with get, set
    abstract icon: IStyle with get, set
    abstract ellipsis: IStyle with get, set

type [<RequireQualifiedAccess>] PivotLinkFormat =
    | Links = 0
    | Tabs = 1

type [<RequireQualifiedAccess>] PivotLinkSize =
    | Normal = 0
    | Large = 1
type BaseComponent = ______Utilities.BaseComponent
type IProgressIndicatorProps = __ProgressIndicator_types.IProgressIndicatorProps

type [<AllowNullLiteral>] IExports =
    abstract ProgressIndicatorBase: ProgressIndicatorBaseStatic

/// ProgressIndicator with no default styles.
/// [Use the `getStyles` API to add your own styles.](https://github.com/OfficeDev/office-ui-fabric-react/wiki/Styling)
type [<AllowNullLiteral>] ProgressIndicatorBase =
    inherit BaseComponent<IProgressIndicatorProps, obj>
    abstract defaultProps: obj with get, set
    abstract render: unit -> JSX.Element
    abstract _onRenderProgress: obj with get, set

/// ProgressIndicator with no default styles.
/// [Use the `getStyles` API to add your own styles.](https://github.com/OfficeDev/office-ui-fabric-react/wiki/Styling)
type [<AllowNullLiteral>] ProgressIndicatorBaseStatic =
    [<Emit "new $0($1...)">] abstract Create: props: IProgressIndicatorProps -> ProgressIndicatorBase
type ProgressIndicatorBase = __ProgressIndicator_base.ProgressIndicatorBase
type IStyle = ______Styling.IStyle
type ITheme = ______Styling.ITheme
type IStyleFunction = ______Utilities.IStyleFunction
type IRenderFunction = ______Utilities.IRenderFunction

type [<AllowNullLiteral>] IProgressIndicator =
    abstract focus: (unit -> unit) with get, set

type [<AllowNullLiteral>] IProgressIndicatorProps =
    inherit React.Props<ProgressIndicatorBase>
    /// Gets the component ref.
    abstract componentRef: (IProgressIndicatorProps option -> unit) option with get, set
    /// Call to provide customized styling that will layer on top of the variant rules.
    abstract getStyles: IStyleFunction<IProgressIndicatorStyleProps, IProgressIndicatorStyles> option with get, set
    /// Theme provided by High-Order Component.
    abstract theme: ITheme option with get, set
    /// Additional css class to apply to the ProgressIndicator
    abstract className: string option with get, set
    /// Label to display above the control. May be a string or React virtual elements.
    abstract label: React.ReactNode option with get, set
    /// Text describing or supplementing the operation. May be a string or React virtual elements.
    abstract description: React.ReactNode option with get, set
    /// Percentage of the operation's completeness. If this is not set, the indeterminate progress animation will be shown instead.
    abstract percentComplete: float option with get, set
    /// Whether or not to hide the progress state.
    abstract progressHidden: bool option with get, set
    /// A render override for the progress track.
    abstract onRenderProgress: IRenderFunction<IProgressIndicatorProps> option with get, set
    /// Text alternative of the progress status, used by screen readers for reading the value of the progress.
    abstract ariaValueText: string option with get, set
    /// Deprecated at v0.43.0, to be removed at >= v0.53.0. Use 'label' instead.
    abstract title: string option with get, set
    /// Height of the ProgressIndicator
    abstract barHeight: float option with get, set

type [<AllowNullLiteral>] IProgressIndicatorStyleProps =
    /// Theme provided by High-Order Component.
    abstract theme: ITheme with get, set
    /// Accept custom classNames
    abstract className: string option with get, set
    abstract indeterminate: bool option with get, set
    abstract barHeight: float option with get, set

type [<AllowNullLiteral>] IProgressIndicatorStyles =
    /// Style for the root element.
    abstract root: IStyle with get, set
    abstract itemName: IStyle with get, set
    abstract itemDescription: IStyle with get, set
    abstract itemProgress: IStyle with get, set
    abstract progressTrack: IStyle with get, set
    abstract progressBar: IStyle with get, set
type IStyle = ______Styling.IStyle
type ITheme = ______Styling.ITheme
type IStyleFunction = ______Utilities.IStyleFunction

type [<AllowNullLiteral>] IRating =
    interface end

/// Rating component props.
type [<AllowNullLiteral>] IRatingProps =
    inherit React.AllHTMLAttributes<HTMLElement>
    /// Optional callback to access the IRating interface. Use this instead of ref for accessing
    /// the public methods and properties of the component.
    abstract componentRef: (IRating option -> unit) option with get, set
    /// Selected rating, has to be an integer between min and max
    abstract rating: float option with get, set
    /// Minimum rating, defaults to 1, has to be >= 0
    abstract min: float option with get, set
    /// Maximum rating, defaults to 5, has to be >= min
    abstract max: float option with get, set
    /// Allow the rating value to be set to 0 instead of a minimum of 1.
    abstract allowZeroStars: bool option with get, set
    /// Custom icon, defaults to FavoriteStar
    abstract icon: string option with get, set
    /// Size of rating, defaults to small
    abstract size: RatingSize option with get, set
    /// Callback when the rating has changed
    abstract onChanged: (float -> unit) option with get, set
    /// Optional label format for star ratings, will be read by screen readers, defaults to ''.
    /// Can be used like "{0} of {1} stars selected".
    /// Where {0} will be subsituted by the current rating and {1} will be subsituted by the max rating.
    abstract ariaLabelFormat: string option with get, set
    /// Deprecated: Optional id of label describing this instance of Rating. Instead of this use getArialabel
    abstract ariaLabelId: string option with get, set
    /// Optional flag to mark rating control as readOnly
    abstract readOnly: bool option with get, set
    abstract getAriaLabel: (float -> float -> string) option with get, set
    /// Call to provide customized styling that will layer on top of the variant rules.
    abstract getStyles: IStyleFunction<IRatingStyleProps, IRatingStyles> option with get, set
    /// Theme (provided through customization.)
    abstract theme: ITheme option with get, set

type [<RequireQualifiedAccess>] RatingSize =
    | Small = 0
    | Large = 1

type [<AllowNullLiteral>] IRatingStyleProps =
    abstract disabled: bool option with get, set
    abstract readOnly: bool option with get, set
    abstract theme: ITheme with get, set

type [<AllowNullLiteral>] IRatingStyles =
    abstract root: IStyle with get, set
    abstract ratingStar: IStyle with get, set
    abstract ratingStarBack: IStyle with get, set
    abstract ratingStarFront: IStyle with get, set
    abstract ratingButton: IStyle with get, set
    abstract ratingStarIsSmall: IStyle with get, set
    abstract ratingStarIsLarge: IStyle with get, set
    abstract rootIsSmall: IStyle with get, set
    abstract rootIsLarge: IStyle with get, set
    abstract labelText: IStyle with get, set
    abstract ratingFocusZone: IStyle with get, set
type BaseComponent = ______Utilities.BaseComponent
type IRatingProps = __Rating_types.IRatingProps

type [<AllowNullLiteral>] IExports =
    abstract RatingBase: RatingBaseStatic

type [<AllowNullLiteral>] IRatingState =
    abstract rating: float option with get, set

type [<AllowNullLiteral>] RatingBase =
    inherit BaseComponent<IRatingProps, IRatingState>
    abstract defaultProps: IRatingProps with get, set
    abstract _id: obj with get, set
    abstract _min: obj with get, set
    abstract _labelId: obj with get, set
    abstract _classNames: obj with get, set
    abstract componentWillReceiveProps: nextProps: IRatingProps -> unit
    abstract render: unit -> JSX.Element
    abstract _getStarId: index: obj -> unit
    abstract _onFocus: value: obj * ev: obj -> unit
    abstract _getLabel: rating: obj -> unit
    abstract _getInitialValue: props: obj -> unit
    abstract _getClampedRating: rating: obj -> unit
    abstract _getFillingPercentage: starPosition: obj -> unit

type [<AllowNullLiteral>] RatingBaseStatic =
    [<Emit "new $0($1...)">] abstract Create: props: IRatingProps -> RatingBase
type BaseComponent = ______Utilities.BaseComponent
type IResizeGroupProps = __ResizeGroup_types.IResizeGroupProps
let [<Import("","office-ui-fabric-react")>] getMeasurementCache: (unit -> obj) = jsNative
let [<Import("","office-ui-fabric-react")>] getNextResizeGroupStateProvider: (obj -> obj) = jsNative

type [<AllowNullLiteral>] IExports =
    abstract ResizeGroupBase: ResizeGroupBaseStatic

type [<AllowNullLiteral>] IResizeGroupState =
    /// Final data used to render proper sized component
    abstract renderedData: obj option with get, set
    /// Data to render in a hidden div for measurement
    abstract dataToMeasure: obj option with get, set
    /// Set to true when the content container might have new dimensions and should
    /// be remeasured.
    abstract measureContainer: bool option with get, set
    /// Are we resizing to accommodate having more or less available space?
    /// The 'grow' direction is when the container may have more room than the last render,
    /// such as when a window resize occurs. This means we will try to fit more content in the window.
    /// The 'shrink' direction is when the contents don't fit in the container and we need
    /// to find a transformation of the data that makes everything fit.
    abstract resizeDirection: U2<string, string> option with get, set

type [<AllowNullLiteral>] ResizeGroupBase =
    inherit BaseComponent<IResizeGroupProps, IResizeGroupState>
    abstract _nextResizeGroupStateProvider: obj with get, set
    abstract _root: obj with get, set
    abstract _measured: obj with get, set
    abstract render: unit -> JSX.Element
    abstract componentDidMount: unit -> unit
    abstract componentWillReceiveProps: nextProps: IResizeGroupProps -> unit
    abstract componentDidUpdate: prevProps: IResizeGroupProps -> unit
    abstract remeasure: unit -> unit
    abstract _afterComponentRendered: unit -> unit
    abstract _onResize: unit -> unit

type [<AllowNullLiteral>] ResizeGroupBaseStatic =
    [<Emit "new $0($1...)">] abstract Create: props: IResizeGroupProps -> ResizeGroupBase
type ResizeGroupBase = __ResizeGroup_base.ResizeGroupBase
type IStyle = ______Styling.IStyle
type ITheme = ______Styling.ITheme
type IStyleFunction = ______Utilities.IStyleFunction

type [<AllowNullLiteral>] IResizeGroup =
    /// Remeasures the available space.
    abstract remeasure: unit -> unit

type [<AllowNullLiteral>] IResizeGroupProps =
    inherit React.HTMLAttributes<U2<ResizeGroupBase, HTMLElement>>
    /// Optional callback to access the IResizeGroup interface. Use this instead of ref for accessing
    /// the public methods and properties of the component.
    abstract componentRef: (IResizeGroup option -> unit) option with get, set
    /// Call to provide customized styling that will layer on top of the variant rules
    abstract getStyles: IStyleFunction<IResizeGroupStyleProps, IResizeGroupStyles> option with get, set
    /// Theme provided by HOC.
    abstract theme: ITheme option with get, set
    /// Additional css class to apply to the Component
    abstract className: string option with get, set
    /// Initial data to be passed to the onRenderData function. When there is no onGrowData provided, this data should represent what should
    /// be passed to the render function when the parent container of the ResizeGroup is at it's maximum supported width. A cacheKey property
    /// may optionally be included as part of the data. Two data objects with the same cacheKey will be assumed to take up the
    /// same width and will prevent measurements. The type of cacheKey is a string.
    abstract data: obj option with get, set
    /// Function to render the data. Called when rendering the contents to the screen and when
    /// rendering in a hidden div to measure the size of the contents.
    abstract onRenderData: (obj option -> JSX.Element) with get, set
    /// Function to be performed on the data in order to reduce its width and make it fit into the given space.
    /// If there are no more scaling steps to apply, it should return undefined to prevent
    /// an infinite render loop.
    abstract onReduceData: (obj option -> obj option) with get, set
    /// Function to be performed on the data in order to increase its width. It is called in scenarios where the
    /// container has more room than the previous render and we may be able to fit more content. If there are no more
    /// scaling operations to perform on teh data, it should return undefined to prevent an infinite render loop.
    abstract onGrowData: (obj option -> obj option) option with get, set
    /// Function to be called every time data is rendered. It provides the data that was actually rendered.
    /// A use case would be adding telemetry when a particular control is shown in an overflow well or
    /// dropped as a result of onReduceData or to count the number of renders that an implementation of
    /// onReduceData triggers.
    abstract dataDidRender: (obj option -> unit) option with get, set

type [<AllowNullLiteral>] IResizeGroupStyleProps =
    /// Accept theme prop.
    abstract theme: ITheme with get, set
    /// Accept custom classNames
    abstract className: string option with get, set

type [<AllowNullLiteral>] IResizeGroupStyles =
    /// Style for the root element.
    abstract root: IStyle with get, set
type Sticky = __Sticky.Sticky

type [<AllowNullLiteral>] IStickyProps =
    inherit React.Props<Sticky>
    /// Gets ref to component interface.
    abstract componentRef: (IStickyProps option -> unit) option with get, set
    /// Class name to apply to the sticky element if component is sticky.
    abstract stickyClassName: string option with get, set
    /// color to apply as 'background-color' style for sticky element.
    abstract stickyBackgroundColor: string option with get, set
    /// Region to render sticky component in.
    abstract stickyPosition: StickyPositionType option with get, set

type [<RequireQualifiedAccess>] StickyPositionType =
    | Both = 0
    | Header = 1
    | Footer = 2
module PropTypes = Prop_types
type BaseComponent = ______Utilities.BaseComponent
type IStickyProps = __Sticky_types.IStickyProps

type [<AllowNullLiteral>] IExports =
    abstract Sticky: StickyStatic

type [<AllowNullLiteral>] IStickyState =
    abstract isStickyTop: bool with get, set
    abstract isStickyBottom: bool with get, set

type [<AllowNullLiteral>] IStickyContext =
    abstract scrollablePane: PropTypes.Requireable<obj> with get, set

type [<AllowNullLiteral>] Sticky =
    inherit BaseComponent<IStickyProps, IStickyState>
    abstract defaultProps: IStickyProps with get, set
    abstract contextTypes: IStickyContext with get, set
    abstract context: obj with get, set
    abstract distanceFromTop: float with get, set
    abstract _root: obj with get, set
    abstract _stickyContentTop: obj with get, set
    abstract _stickyContentBottom: obj with get, set
    abstract _nonStickyContent: obj with get, set
    abstract root: HTMLDivElement option
    abstract stickyContentTop: HTMLDivElement option
    abstract stickyContentBottom: HTMLDivElement option
    abstract nonStickyContent: HTMLDivElement option
    abstract canStickyTop: bool
    abstract canStickyBottom: bool
    abstract componentDidMount: unit -> unit
    abstract componentWillUnmount: unit -> unit
    abstract componentDidUpdate: prevProps: IStickyProps * prevState: IStickyState -> unit
    abstract shouldComponentUpdate: nextProps: IStickyProps * nextState: IStickyState -> bool
    abstract render: unit -> JSX.Element
    abstract addSticky: stickyContent: HTMLDivElement -> unit
    abstract resetSticky: unit -> unit
    abstract setDistanceFromTop: container: HTMLDivElement -> unit
    abstract _getContentStyles: isSticky: obj -> unit
    abstract _getStickyPlaceholderHeight: isSticky: obj -> unit
    abstract _getNonStickyPlaceholderHeight: unit -> unit
    abstract _onScrollEvent: obj with get, set
    abstract _getStickyDistanceFromTop: obj with get, set
    abstract _getStickyDistanceFromTopForFooter: obj with get, set
    abstract _getNonStickyDistanceFromTop: obj with get, set
    abstract _getBackground: unit -> unit

type [<AllowNullLiteral>] StickyStatic =
    [<Emit "new $0($1...)">] abstract Create: props: IStickyProps -> Sticky
module PropTypes = Prop_types
type BaseComponent = ______Utilities.BaseComponent
type IScrollablePane = __ScrollablePane_types.IScrollablePane
type IScrollablePaneProps = __ScrollablePane_types.IScrollablePaneProps
type Sticky = ______Sticky.Sticky

type [<AllowNullLiteral>] IExports =
    abstract ScrollablePaneBase: ScrollablePaneBaseStatic

type [<AllowNullLiteral>] IScrollablePaneContext =
    abstract scrollablePane: PropTypes.Requireable<obj> with get, set

type [<AllowNullLiteral>] IScrollablePaneState =
    abstract stickyTopHeight: float with get, set
    abstract stickyBottomHeight: float with get, set

type [<AllowNullLiteral>] ScrollablePaneBase =
    inherit BaseComponent<IScrollablePaneProps, IScrollablePaneState>
    inherit IScrollablePane
    abstract childContextTypes: React.ValidationMap<IScrollablePaneContext> with get, set
    abstract _root: obj with get, set
    abstract _stickyAboveRef: obj with get, set
    abstract _stickyBelowRef: obj with get, set
    abstract _contentContainer: obj with get, set
    abstract _subscribers: obj with get, set
    abstract _stickies: obj with get, set
    abstract _mutationObserver: obj with get, set
    abstract root: HTMLDivElement option
    abstract stickyAbove: HTMLDivElement option
    abstract stickyBelow: HTMLDivElement option
    abstract contentContainer: HTMLDivElement option
    abstract getChildContext: unit -> obj
    abstract componentDidMount: unit -> unit
    abstract componentWillUnmount: unit -> unit
    abstract shouldComponentUpdate: nextProps: IScrollablePaneProps * nextState: IScrollablePaneState -> bool
    abstract componentDidUpdate: prevProps: IScrollablePaneProps * prevState: IScrollablePaneState -> unit
    abstract render: unit -> JSX.Element
    abstract setStickiesDistanceFromTop: unit -> unit
    abstract forceLayoutUpdate: unit -> unit
    abstract subscribe: (Function -> unit) with get, set
    abstract unsubscribe: (Function -> unit) with get, set
    abstract addSticky: (Sticky -> unit) with get, set
    abstract removeSticky: (Sticky -> unit) with get, set
    abstract sortSticky: (Sticky -> unit) with get, set
    abstract updateStickyRefHeights: (unit -> unit) with get, set
    abstract notifySubscribers: (unit -> unit) with get, set
    abstract getScrollPosition: (unit -> float) with get, set
    abstract _checkStickyStatus: sticky: obj -> unit
    abstract _addToStickyContainer: obj with get, set
    abstract _removeStickyFromContainers: obj with get, set
    abstract _onWindowResize: obj with get, set
    abstract _getStickyContainerStyle: obj with get, set

type [<AllowNullLiteral>] ScrollablePaneBaseStatic =
    [<Emit "new $0($1...)">] abstract Create: props: IScrollablePaneProps -> ScrollablePaneBase
type ScrollablePaneBase = __ScrollablePane_base.ScrollablePaneBase
type IStyle = ______Styling.IStyle
type ITheme = ______Styling.ITheme
type IStyleFunction = ______Utilities.IStyleFunction

type [<AllowNullLiteral>] IScrollablePane =
    /// Triggers a layout update for the pane. 
    abstract forceLayoutUpdate: unit -> unit
    /// Gets the current scroll position of the scrollable pane 
    abstract getScrollPosition: unit -> float

type [<AllowNullLiteral>] IScrollablePaneProps =
    inherit React.HTMLAttributes<U2<HTMLElement, ScrollablePaneBase>>
    /// Optional callback to access the IScrollablePane interface. Use this instead of ref for accessing
    /// the public methods and properties of the component.
    abstract componentRef: (IScrollablePane option -> unit) option with get, set
    /// Call to provide customized styling that will layer on top of the variant rules
    abstract getStyles: IStyleFunction<IScrollablePaneStyleProps, IScrollablePaneStyles> option with get, set
    /// Theme provided by HOC.
    abstract theme: ITheme option with get, set
    /// Additional css class to apply to the ScrollablePane
    abstract className: string option with get, set
    /// Sets the initial scroll position of the ScrollablePane
    abstract initialScrollPosition: float option with get, set

type [<AllowNullLiteral>] IScrollablePaneStyleProps =
    /// Accept theme prop.
    abstract theme: ITheme with get, set
    /// Accept custom classNames
    abstract className: string option with get, set

type [<AllowNullLiteral>] IScrollablePaneStyles =
    /// Style set for the root element.
    abstract root: IStyle with get, set
    /// Style set for the stickyAbove element.
    abstract stickyAbove: IStyle with get, set
    /// Style set for the stickyAbove element.
    abstract stickyBelow: IStyle with get, set
    /// Style set for the stickyBelowItems element.
    abstract stickyBelowItems: IStyle with get, set
    /// Style set for the contentContainer element.
    abstract contentContainer: IStyle with get, set
type ITheme = ______Styling.ITheme
type IStyle = ______Styling.IStyle
type IStyleFunction = ______Utilities.IStyleFunction
type IButtonProps = ___Button.IButtonProps

type [<AllowNullLiteral>] ISearchBox =
    /// Sets focus inside the search input box.
    abstract focus: unit -> unit
    /// Returns whether or not the SearchBox has focus
    abstract hasFocus: unit -> bool

type [<AllowNullLiteral>] ISearchBoxProps =
    inherit React.InputHTMLAttributes<HTMLInputElement>
    /// Optional callback to access the ISearchBox interface. Use this instead of ref for accessing
    /// the public methods and properties of the component.
    abstract componentRef: (ISearchBox option -> unit) option with get, set
    /// Placeholder for the search box.
    abstract placeholder: string option with get, set
    /// Deprecated. Use placeholder instead.
    abstract labelText: string option with get, set
    /// Callback function for when the typed input for the SearchBox has changed.
    abstract onChange: (obj option -> unit) option with get, set
    /// Callback executed when the user presses enter in the search box.
    abstract onSearch: (obj option -> unit) option with get, set
    /// Callback executed when the user clears the search box by either clicking 'X' or hitting escape.
    abstract onClear: (obj option -> unit) option with get, set
    /// Callback executed when the user presses escape in the search box.
    abstract onEscape: (obj option -> unit) option with get, set
    /// Deprecated at v0.52.2, use 'onChange' instead.
    abstract onChanged: (obj option -> unit) option with get, set
    /// The value of the text in the SearchBox.
    abstract value: string option with get, set
    /// The default value of the text in the SearchBox, in the case of an uncontrolled component.
    /// Up till now, this has not been implemented, deprecating. Will re-implement if uncontrolled
    /// component behavior is implemented.
    abstract defaultValue: string option with get, set
    /// CSS class to apply to the SearchBox.
    abstract className: string option with get, set
    /// The aria label of the SearchBox for the benefit of screen readers.
    abstract ariaLabel: string option with get, set
    /// The props for the clear button.
    abstract clearButtonProps: IButtonProps option with get, set
    /// Whether or not the SearchBox is underlined.
    abstract underlined: bool option with get, set
    /// Theme (provided through customization.)
    abstract theme: ITheme option with get, set
    /// Call to provide customized styling that will layer on top of the variant rules.
    abstract getStyles: IStyleFunction<ISearchBoxStyleProps, ISearchBoxStyles> option with get, set
    /// Whether or not to animate the SearchBox icon on focus.
    abstract disableAnimation: bool option with get, set

type [<AllowNullLiteral>] ISearchBoxStyleProps =
    abstract theme: ITheme with get, set
    abstract className: string option with get, set
    abstract disabled: bool option with get, set
    abstract hasFocus: bool option with get, set
    abstract underlined: bool option with get, set
    abstract hasInput: bool option with get, set
    abstract disableAnimation: bool option with get, set

type [<AllowNullLiteral>] ISearchBoxStyles =
    abstract root: IStyle option with get, set
    abstract iconContainer: IStyle option with get, set
    abstract icon: IStyle option with get, set
    abstract field: IStyle option with get, set
    abstract clearButton: IStyle option with get, set
type ISearchBoxProps = __SearchBox_types.ISearchBoxProps
type BaseComponent = ______Utilities.BaseComponent

type [<AllowNullLiteral>] IExports =
    abstract SearchBoxBase: SearchBoxBaseStatic

type [<AllowNullLiteral>] ISearchBoxState =
    abstract value: string option with get, set
    abstract hasFocus: bool option with get, set
    abstract id: string option with get, set

type [<AllowNullLiteral>] SearchBoxBase =
    inherit BaseComponent<ISearchBoxProps, ISearchBoxState>
    abstract defaultProps: ISearchBoxProps with get, set
    abstract _rootElement: obj with get, set
    abstract _inputElement: obj with get, set
    abstract _latestValue: obj with get, set
    abstract componentWillReceiveProps: newProps: ISearchBoxProps -> unit
    abstract render: unit -> JSX.Element
    /// Sets focus to the search box input field
    abstract focus: unit -> unit
    /// Returns whether or not the SearchBox has focus
    abstract hasFocus: unit -> bool
    abstract _onClear: ev: obj -> unit
    abstract _onClickFocus: obj with get, set
    abstract _onFocusCapture: obj with get, set
    abstract _onClearClick: obj with get, set
    abstract _onKeyDown: obj with get, set
    abstract _onBlur: obj with get, set
    abstract _onInputChange: obj with get, set
    abstract _callOnChange: newValue: obj -> unit

type [<AllowNullLiteral>] SearchBoxBaseStatic =
    [<Emit "new $0($1...)">] abstract Create: props: ISearchBoxProps -> SearchBoxBase
type BaseComponent = ______Utilities.BaseComponent
type ISliderProps = __Slider_types.ISliderProps
type ISlider = __Slider_types.ISlider

type [<AllowNullLiteral>] IExports =
    abstract SliderBase: SliderBaseStatic

type [<AllowNullLiteral>] ISliderState =
    abstract value: float option with get, set
    abstract renderedValue: float option with get, set

type [<RequireQualifiedAccess>] ValuePosition =
    | Previous = 0
    | Next = 1

type [<AllowNullLiteral>] SliderBase =
    inherit BaseComponent<ISliderProps, ISliderState>
    inherit ISlider
    abstract defaultProps: ISliderProps with get, set
    abstract _sliderLine: obj with get, set
    abstract _thumb: obj with get, set
    abstract _id: obj with get, set
    /// Invoked when a component is receiving new props. This method is not called for the initial render.
    abstract componentWillReceiveProps: newProps: ISliderProps -> unit
    abstract render: unit -> React.ReactElement<obj>
    abstract focus: unit -> unit
    abstract value: float option
    abstract _getAriaValueText: obj with get, set
    abstract _getThumbStyle: vertical: obj * thumbOffsetPercent: obj -> unit
    abstract _onMouseDownOrTouchStart: obj with get, set
    abstract _onMouseMoveOrTouchMove: obj with get, set
    abstract _getPosition: ``event``: obj * vertical: obj -> unit
    abstract _updateValue: value: obj * renderedValue: obj -> unit
    abstract _onMouseUpOrTouchEnd: obj with get, set
    abstract _onKeyDown: obj with get, set

type [<AllowNullLiteral>] SliderBaseStatic =
    [<Emit "new $0($1...)">] abstract Create: props: ISliderProps -> SliderBase
type SliderBase = __Slider_base.SliderBase
type IStyle = ______Styling.IStyle
type ITheme = ______Styling.ITheme
type IStyleFunction = ______Utilities.IStyleFunction

type [<AllowNullLiteral>] ISlider =
    abstract value: float option with get, set
    abstract focus: (unit -> unit) with get, set

type [<AllowNullLiteral>] ISliderProps =
    inherit React.Props<SliderBase>
    /// Optional callback to access the ISlider interface. Use this instead of ref for accessing
    /// the public methods and properties of the component.
    abstract componentRef: (ISlider option -> unit) option with get, set
    /// Call to provide customized styling that will layer on top of the variant rules.
    abstract getStyles: IStyleFunction<ISliderStyleProps, ISliderStyles> option with get, set
    /// Theme provided by High-Order Component.
    abstract theme: ITheme option with get, set
    /// Description label of the Slider
    abstract label: string option with get, set
    /// The initial value of the Slider. Use this if you intend for the Slider to be an uncontrolled component.
    /// This value is mutually exclusive to value. Use one or the other.
    abstract defaultValue: float option with get, set
    /// The initial value of the Slider. Use this if you intend to pass in a new value as a result of onChange events.
    /// This value is mutually exclusive to defaultValue. Use one or the other.
    abstract value: float option with get, set
    /// The min value of the Slider
    abstract min: float option with get, set
    /// The max value of the Slider
    abstract max: float option with get, set
    /// The difference between the two adjacent values of the Slider
    abstract step: float option with get, set
    /// Whether to show the value on the right of the Slider.
    abstract showValue: bool option with get, set
    /// Callback when the value has been changed
    abstract onChange: (float -> unit) option with get, set
    /// A description of the Slider for the benefit of screen readers.
    abstract ariaLabel: string option with get, set
    /// A text description of the Slider number value for the benefit of screen readers. This should be used when the Slider number value is not accurately represented by a number.
    abstract ariaValueText: (float -> string) option with get, set
    /// Optional flag to render the slider vertically. Defaults to rendering horizontal.
    abstract vertical: bool option with get, set
    /// Optional flag to render the Slider as disabled.
    abstract disabled: bool option with get, set
    /// Optional className to attach to the slider root element.
    abstract className: string option with get, set
    /// Optional mixin for additional props on the thumb button within the slider.
    abstract buttonProps: React.HTMLAttributes<HTMLButtonElement> option with get, set

type [<AllowNullLiteral>] ISliderStyleProps =
    /// Theme provided by High-Order Component.
    abstract theme: ITheme with get, set
    /// Accept custom classNames.
    abstract className: string option with get, set
    abstract titleLabel: string option with get, set
    abstract rootIsEnabled: bool option with get, set
    abstract rootIsDisabled: bool option with get, set
    abstract rootIsHorizontal: bool option with get, set
    abstract rootIsVertical: bool option with get, set
    abstract showTransitions: bool option with get, set

type [<AllowNullLiteral>] ISliderStyles =
    abstract root: IStyle with get, set
    abstract container: IStyle with get, set
    abstract slideBox: IStyle with get, set
    abstract line: IStyle with get, set
    abstract thumb: IStyle with get, set
    abstract lineContainer: IStyle with get, set
    abstract activeSection: IStyle with get, set
    abstract inactiveSection: IStyle with get, set
    abstract valueLabel: IStyle with get, set
type ISpinButtonStyles = __SpinButton_types.ISpinButtonStyles
type KeyboardSpinDirection = __SpinButton.KeyboardSpinDirection
type Position = ______utilities_positioning.Position
let [<Import("","office-ui-fabric-react")>] getClassNames: (ISpinButtonStyles -> bool -> bool -> KeyboardSpinDirection -> Position -> ISpinButtonClassNames) = jsNative

type [<AllowNullLiteral>] ISpinButtonClassNames =
    abstract root: string with get, set
    abstract labelWrapper: string with get, set
    abstract icon: string with get, set
    abstract label: string with get, set
    abstract spinButtonWrapper: string with get, set
    abstract input: string with get, set
    abstract arrowBox: string with get, set
type Position = ______utilities_positioning.Position
type IIconProps = ______Icon.IIconProps
type ITheme = ______Styling.ITheme
type IStyle = ______Styling.IStyle
type ISpinButtonClassNames = __SpinButton_classNames.ISpinButtonClassNames
type KeyboardSpinDirection = __SpinButton.KeyboardSpinDirection
type IButtonStyles = ______Button.IButtonStyles
type IKeytipProps = ______Keytip.IKeytipProps

type [<AllowNullLiteral>] ISpinButton =
    /// The value of the SpinButton. Use this if you intend to pass in a new value as a result of onChange events.
    /// This value is mutually exclusive to defaultValue. Use one or the other.
    abstract value: string option with get, set
    /// Sets focus to the spin button.
    abstract focus: (unit -> unit) with get, set

type [<AllowNullLiteral>] ISpinButtonProps =
    /// Gets the component ref.
    abstract componentRef: (ISpinButton option -> unit) option with get, set
    /// The initial value of the SpinButton. Use this if you intend for the SpinButton to be an uncontrolled component.
    /// This value is mutually exclusive to value. Use one or the other.
    abstract defaultValue: string option with get, set
    /// The value of the SpinButton. Use this if you intend to pass in a new value as a result of onChange events.
    /// This value is mutually exclusive to defaultValue. Use one or the other.
    abstract value: string option with get, set
    /// The min value of the SpinButton.
    abstract min: float option with get, set
    /// The max value of the SpinButton.
    abstract max: float option with get, set
    /// The difference between the two adjacent values of the SpinButton.
    /// This value is sued to calculate the precision of the input if no
    /// precision is given. The precision calculated this way will always
    /// be >= 0.
    abstract step: float option with get, set
    /// A description of the SpinButton for the benefit of screen readers.
    abstract ariaLabel: string option with get, set
    /// A title for the SpinButton used for a more descriptive name that's also visible on its tooltip.
    abstract title: string option with get, set
    /// Whether or not the SpinButton is disabled.
    abstract disabled: bool option with get, set
    /// Optional className for SpinButton.
    abstract className: string option with get, set
    /// Descriptive label for the SpinButton.
    abstract label: string with get, set
    abstract labelPosition: Position option with get, set
    /// Icon that goes along with the label for the whole SpinButton
    abstract iconProps: IIconProps option with get, set
    /// This callback is triggered when the value inside the SpinButton should be validated.
    abstract onValidate: (string -> U2<string, unit>) option with get, set
    /// This callback is triggered when the increment button is pressed or if the user presses up arrow with focus on the input of the spinButton
    abstract onIncrement: (string -> U2<string, unit>) option with get, set
    /// This callback is triggered when the decrement button is pressed or if the user presses down arrow with focus on the input of the spinButton
    abstract onDecrement: (string -> U2<string, unit>) option with get, set
    /// A callback for when the user put focus on the picker
    abstract onFocus: React.FocusEventHandler<HTMLInputElement> option with get, set
    /// A callback for when the user moves the focus away from the picker
    abstract onBlur: React.FocusEventHandler<HTMLInputElement> option with get, set
    /// Icon for the increment button of the spinButton
    abstract incrementButtonIcon: IIconProps option with get, set
    /// Icon for the decrement button of the spinButton
    abstract decrementButtonIcon: IIconProps option with get, set
    /// Custom styling for individual elements within the button DOM.
    abstract styles: obj option with get, set
    /// Custom function for providing the classNames for the spinbutton. Can be used to provide
    /// all styles for the component instead of applying them on top of the default styles.
    abstract getClassNames: (ITheme -> bool -> bool -> KeyboardSpinDirection -> Position -> ISpinButtonClassNames) option with get, set
    /// Custom styles for the upArrow button.
    /// 
    /// Note: The buttons are in a checked state when arrow keys are used to
    /// incremenent/decrement the spinButton. Use rootChecked instead of rootPressed
    /// for styling when that is the case.
    abstract upArrowButtonStyles: obj option with get, set
    /// Custom styles for the downArrow button.
    /// 
    /// Note: The buttons are in a checked state when arrow keys are used to
    /// incremenent/decrement the spinButton. Use rootChecked instead of rootPressed
    /// for styling when that is the case.
    abstract downArrowButtonStyles: obj option with get, set
    /// Theme provided by HOC.
    abstract theme: ITheme option with get, set
    /// Accessibile label text for the increment button for the benefit of the screen reader.
    abstract incrementButtonAriaLabel: string option with get, set
    /// Accessibile label text for the decrement button for the benefit of the screen reader.
    abstract decrementButtonAriaLabel: string option with get, set
    /// To how many decimal places the value should be rounded to.
    /// The default value is calculated based on the precision of step.
    /// IE: if step = 1, precision = 0. step = 0.0089, precision = 4. step = 300, precision = 2. step = 23.00, precision = 2.
    abstract precision: float option with get, set
    /// The position in the parent set (if in a set) for aria-posinset.
    abstract ariaPositionInSet: float option with get, set
    /// The total size of the parent set (if in a set) for aria-setsize.
    abstract ariaSetSize: float option with get, set
    /// Optional keytip for this spin button
    abstract keytipProps: IKeytipProps option with get, set

type [<AllowNullLiteral>] ISpinButtonStyles =
    /// Styles for the root of the spin button component.
    abstract root: IStyle with get, set
    /// Style for the label wrapper element of the component
    /// The label wrapper contains the icon and the label.
    abstract labelWrapper: IStyle with get, set
    /// Style override when the label is positioned at the start.
    abstract labelWrapperStart: IStyle with get, set
    /// Style override when the label is positioned at the end.
    abstract labelWrapperEnd: IStyle with get, set
    /// Style override when the label is positioned at the top.
    abstract labelWrapperTop: IStyle with get, set
    /// Style override when the label is positioned at the bottom.
    abstract labelWrapperBottom: IStyle with get, set
    /// Style for the icon.
    abstract icon: IStyle with get, set
    /// Style for the icon.
    abstract iconDisabled: IStyle with get, set
    /// Style for the label text
    abstract label: IStyle with get, set
    /// Style for the label text
    abstract labelDisabled: IStyle with get, set
    /// Style for spinButtonWrapper when enabled.
    abstract spinButtonWrapper: IStyle with get, set
    /// Style override when label is positioned at the top/bottom.
    abstract spinButtonWrapperTopBottom: IStyle with get, set
    /// Style override when spinButton is enabled/hovered.
    abstract spinButtonWrapperHovered: IStyle with get, set
    /// Style override when spinButton is enabled/focused.
    abstract spinButtonWrapperFocused: IStyle with get, set
    /// Style override when spinButton is disabled.
    abstract spinButtonWrapperDisabled: IStyle with get, set
    /// Styles for the input.
    abstract input: IStyle with get, set
    /// Style override for ::selection
    abstract inputTextSelected: IStyle with get, set
    /// Style override when spinButton is disabled.
    abstract inputDisabled: IStyle with get, set
    /// Styles for the arrowButtonsContainer
    abstract arrowButtonsContainer: IStyle with get, set
    /// Style override for the arrowButtonsContainer when spin button is disabled.
    abstract arrowButtonsContainerDisabled: IStyle with get, set
type BaseComponent = ______Utilities.BaseComponent
type ISpinButton = __SpinButton_types.ISpinButton
type ISpinButtonProps = __SpinButton_types.ISpinButtonProps

type [<AllowNullLiteral>] IExports =
    abstract SpinButton: SpinButtonStatic

type [<RequireQualifiedAccess>] KeyboardSpinDirection =
    | Down = -1
    | NotSpinning = 0
    | Up = 1

type [<AllowNullLiteral>] ISpinButtonState =
    /// Is true when the control has focus.
    abstract isFocused: bool with get, set
    /// the value of the spin button
    abstract value: string with get, set
    /// keyboard spin direction, used to style the up or down button
    /// as active when up/down arrow is pressed
    abstract keyboardSpinDirection: KeyboardSpinDirection with get, set
    /// The calculated precision for the value.
    abstract precision: float with get, set

type [<AllowNullLiteral>] SpinButton =
    inherit BaseComponent<ISpinButtonProps, ISpinButtonState>
    inherit ISpinButton
    abstract defaultProps: ISpinButtonProps with get, set
    abstract _input: obj with get, set
    abstract _inputId: obj with get, set
    abstract _labelId: obj with get, set
    abstract _lastValidValue: obj with get, set
    abstract _spinningByMouse: obj with get, set
    abstract _onValidate: obj option with get, set
    abstract _onIncrement: obj option with get, set
    abstract _onDecrement: obj option with get, set
    abstract _currentStepFunctionHandle: obj with get, set
    abstract _initialStepDelay: obj with get, set
    abstract _stepDelay: obj with get, set
    /// Invoked when a component is receiving new props. This method is not called for the initial render.
    abstract componentWillReceiveProps: newProps: ISpinButtonProps -> unit
    abstract render: unit -> JSX.Element
    abstract focus: unit -> unit
    abstract _onFocus: obj with get, set
    abstract _onBlur: obj with get, set
    /// Gets the value of the spin button.
    abstract value: string option
    /// Validate function to use if one is not passed in
    abstract _defaultOnValidate: obj with get, set
    /// Increment function to use if one is not passed in
    abstract _defaultOnIncrement: obj with get, set
    /// Increment function to use if one is not passed in
    abstract _defaultOnDecrement: obj with get, set
    abstract _onChange: unit -> unit
    /// This is used when validating text entry
    /// in the input (not when changed via the buttons)
    abstract _validate: obj with get, set
    /// The method is needed to ensure we are updating the actual input value.
    /// without this our value will never change (and validation will not have the correct number)
    abstract _onInputChange: obj with get, set
    /// Update the value with the given stepFunction
    abstract _updateValue: obj with get, set
    /// Stop spinning (clear any currently pending update and set spinning to false)
    abstract _stop: obj with get, set
    /// Handle keydown on the text field. We need to update
    /// the value when up or down arrow are depressed
    abstract _handleKeyDown: obj with get, set
    /// Make sure that we have stopped spinning on keyUp
    /// if the up or down arrow fired this event
    abstract _handleKeyUp: obj with get, set
    abstract _onIncrementMouseDown: obj with get, set
    abstract _onDecrementMouseDown: obj with get, set

type [<AllowNullLiteral>] SpinButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: props: ISpinButtonProps -> SpinButton
type ITheme = ______Styling.ITheme
type IStyle = ______Styling.IStyle
type IStyleFunction = ______Utilities.IStyleFunction

type [<AllowNullLiteral>] ISpinner =
    interface end

type [<AllowNullLiteral>] ISpinnerProps =
    inherit React.HTMLAttributes<HTMLElement>
    /// Optional callback to access the ISpinner interface. Use this instead of ref for accessing
    /// the public methods and properties of the component.
    abstract componentRef: (ISpinner option -> unit) option with get, set
    /// Deprecated and will be removed at >= 2.0.0. Use SpinnerSize instead.
    abstract ``type``: SpinnerType option with get, set
    /// The size of Spinner to render. { extraSmall, small, medium, large }
    abstract size: SpinnerSize option with get, set
    /// The label to show next to the Spinner. Label updates will be announced to the screen readers.
    /// Use ariaLive to control politeness level.
    abstract label: string option with get, set
    /// Additional CSS class(es) to apply to the Spinner.
    abstract className: string option with get, set
    /// Politeness setting for label update announcement.
    abstract ariaLive: U3<string, string, string> option with get, set
    /// Alternative status label for screen reader
    abstract ariaLabel: string option with get, set
    /// Theme (provided through customization.)
    abstract theme: ITheme option with get, set
    /// Call to provide customized styling that will layer on top of the variant rules.
    abstract getStyles: IStyleFunction<ISpinnerStyleProps, ISpinnerStyles> option with get, set

type [<RequireQualifiedAccess>] SpinnerSize =
    | XSmall = 0
    | Small = 1
    | Medium = 2
    | Large = 3

type [<RequireQualifiedAccess>] SpinnerType =
    | Normal = 0
    | Large = 1

type [<AllowNullLiteral>] ISpinnerStyleProps =
    abstract theme: ITheme with get, set
    abstract size: SpinnerSize option with get, set
    abstract className: string option with get, set

type [<AllowNullLiteral>] ISpinnerStyles =
    abstract root: IStyle option with get, set
    abstract circle: IStyle option with get, set
    abstract label: IStyle option with get, set
    abstract screenReaderText: IStyle option with get, set
type IStyle = ______Styling.IStyle
type ITheme = ______Styling.ITheme
type IStyleFunction = ______Utilities.IStyleFunction

type [<AllowNullLiteral>] IColorPickerGridCellProps =
    /// Item to render
    abstract item: IColorCellProps with get, set
    /// Arbitrary unique string associated with this option
    abstract id: string with get, set
    /// The label for this item.
    /// Visible text if this item is a header,
    /// tooltip if is this item is normal
    abstract label: string option with get, set
    /// The CSS-compatible string to describe the color
    abstract color: string option with get, set
    /// Index for this option
    abstract index: float option with get, set
    /// The theme object to use for styling.
    abstract theme: ITheme option with get, set
    /// Wheter or not colorOption should be rendered as a circle or square.
    abstract circle: bool option with get, set
    /// Optional, if the this option should be disabled
    abstract disabled: bool option with get, set
    /// Optional, if the cell is currently selected
    abstract selected: bool with get, set
    /// The on click handler
    abstract onClick: (IColorCellProps -> unit) option with get, set
    /// Optional, the onHover handler
    abstract onHover: (IColorCellProps -> unit) option with get, set
    /// Optional, the onFocus handler
    abstract onFocus: (IColorCellProps -> unit) option with get, set
    /// Optional styles for the component.
    abstract getStyles: IStyleFunction<IColorPickerGridCellStyleProps, IColorPickerGridCellStyles> option with get, set
    /// Optional, mouseEnter handler.
    abstract onMouseEnter: (React.MouseEvent<HTMLButtonElement> -> bool) option with get, set
    /// Optional, mouseMove handler
    abstract onMouseMove: (React.MouseEvent<HTMLButtonElement> -> bool) option with get, set
    /// Optional, mouseLeave handler
    abstract onMouseLeave: (React.MouseEvent<HTMLButtonElement> -> unit) option with get, set
    /// Optional, onWheel handler
    abstract onWheel: (React.MouseEvent<HTMLButtonElement> -> unit) option with get, set
    /// Optional, onkeydown handler
    abstract onKeyDown: (React.KeyboardEvent<HTMLButtonElement> -> unit) option with get, set

type [<AllowNullLiteral>] IColorCellProps =
    /// Arbitrary unique string associated with this option
    abstract id: string with get, set
    /// The label for this item.
    /// Visible text if this item is a header,
    /// tooltip if is this item is normal
    abstract label: string option with get, set
    /// The CSS-compatible string to describe the color
    abstract color: string option with get, set
    /// Index for this option
    abstract index: float option with get, set

/// Properties required to build the styles for the color picker component.
type [<AllowNullLiteral>] IColorPickerGridCellStyleProps =
    /// Theme to apply to the cell.
    abstract theme: ITheme with get, set
    /// Whether the component is disabled or not.
    abstract disabled: bool option with get, set
    /// Whether the cell is currently selected or not.
    abstract selected: bool option with get, set
    /// Whether the svg color element should be rendered as a circle or not.
    abstract circle: bool option with get, set
    /// Whether the color being rendered is white or not. If it is white we show a border around it.
    abstract isWhite: bool option with get, set

/// Styles for the Color Picker Component.
type [<AllowNullLiteral>] IColorPickerGridCellStyles =
    /// Style to apply to a colorCell in the color picker.
    abstract colorCell: IStyle with get, set
    /// Style to apply to the svg element that renders the color.
    abstract svg: IStyle with get, set
type IStyle = ______Styling.IStyle
type ITheme = ______Styling.ITheme
type IStyleFunction = ______Utilities.IStyleFunction
type IColorCellProps = __ColorPickerGridCell_types.IColorCellProps
type IColorPickerGridCellStyleProps = __ColorPickerGridCell_types.IColorPickerGridCellStyleProps
type IColorPickerGridCellStyles = __ColorPickerGridCell_types.IColorPickerGridCellStyles

type [<AllowNullLiteral>] ISwatchColorPicker =
    interface end

type [<AllowNullLiteral>] ISwatchColorPickerProps =
    /// Gets the component ref.
    abstract componentRef: (ISwatchColorPicker option -> unit) option with get, set
    /// the number of columns for the swatch color picker
    abstract columnCount: float with get, set
    /// The id for the swatch color picker
    abstract id: string option with get, set
    /// Additional class name to provide on the root element
    abstract className: string option with get, set
    /// The shape of the color cells, defaults to circle
    abstract cellShape: U2<string, string> option with get, set
    /// The id of color cell that is currently selected
    abstract selectedId: string option with get, set
    /// The color cells that will be made available to the user
    abstract colorCells: ResizeArray<IColorCellProps> with get, set
    /// Callback issued when the user changes the color.
    /// Note, if no id or color is given, there is no selected cell
    /// (e.g. the user executed the currently selected cell to unselect it)
    abstract onColorChanged: (string -> string -> unit) option with get, set
    /// Callback issued when the user hovers over a color cell.
    /// Note, if no id or color is given, cells are not longer being hovered
    abstract onCellHovered: (string -> string -> unit) option with get, set
    /// Callback issued when the user focuses a color cell.
    /// Note, if no id or color is given, cells are not longer being focused
    abstract onCellFocused: (string -> string -> unit) option with get, set
    /// Is this swatch color picker disabled?
    abstract disabled: bool option with get, set
    /// The optional position this grid is in the parent set (index in a parent menu, for example)
    abstract positionInSet: float option with get, set
    /// The optional size of the parent set (size of parent menu, for example)
    abstract setSize: float option with get, set
    /// Should focus cycle to the beginning of once the user navigates past the end (and visa vsersa).
    /// This prop is only relevant if doNotcontainWithinFocusZone is not true
    abstract shouldFocusCircularNavigate: bool option with get, set
    /// If true do not contain the grid inside of a FocusZone.
    /// If false contain the grid inside of a FocusZone.
    abstract doNotContainWithinFocusZone: bool option with get, set
    /// Theme to apply to the component.
    abstract theme: ITheme option with get, set
    /// Optional styles for the component.
    abstract getStyles: IStyleFunction<ISwatchColorPickerStyleProps, ISwatchColorPickerStyles> option with get, set
    /// Optional styles for the component.
    abstract getColorGridCellStyles: IStyleFunction<IColorPickerGridCellStyleProps, IColorPickerGridCellStyles> option with get, set
    /// Optional, whether to update focus when a cell is hovered.
    abstract focusOnHover: bool option with get, set
    /// Selector to focus on mouseLeave
    /// SHOULD ONLY BE USED IN CONJUNCTION WITH focusOnHover
    abstract mouseLeaveParentSelector: string option with get, set

/// Properties required to build the styles for the color picker component.
type [<AllowNullLiteral>] ISwatchColorPickerStyleProps =
    /// Theme to apply to the container
    abstract theme: ITheme with get, set
    /// Custom className to apply to the container.
    abstract className: string option with get, set

/// Styles for the Color Picker Component.
type [<AllowNullLiteral>] ISwatchColorPickerStyles =
    /// Style applied to the container grid of the swatchColorPicker
    abstract root: IStyle with get, set
    /// Style for the table cells of the grid.
    abstract tableCell: IStyle with get, set
    /// Optional, style for the FocusZone container for the grid
    abstract focusedContainer: IStyle option with get, set
type BaseComponent = ______Utilities.BaseComponent
type ISwatchColorPicker = __SwatchColorPicker_types.ISwatchColorPicker
type ISwatchColorPickerProps = __SwatchColorPicker_types.ISwatchColorPickerProps

type [<AllowNullLiteral>] IExports =
    abstract SwatchColorPickerBase: SwatchColorPickerBaseStatic

type [<AllowNullLiteral>] ISwatchColorPickerState =
    abstract selectedIndex: float option with get, set

type [<AllowNullLiteral>] SwatchColorPickerBase =
    inherit BaseComponent<ISwatchColorPickerProps, ISwatchColorPickerState>
    inherit ISwatchColorPicker
    abstract defaultProps: ISwatchColorPickerProps with get, set
    abstract _id: obj with get, set
    abstract _cellFocused: obj with get, set
    abstract navigationIdleTimeoutId: obj with get, set
    abstract isNavigationIdle: obj with get, set
    abstract navigationIdleDelay: obj
    abstract async: obj with get, set
    abstract componentWillReceiveProps: newProps: ISwatchColorPickerProps -> unit
    abstract componentWillUnmount: unit -> unit
    abstract render: unit -> JSX.Element option
    /// When the whole swatchColorPicker is blurred,
    /// make sure to clear the pending focused stated
    abstract _onSwatchColorPickerBlur: obj with get, set
    /// <summary>Get the selected item's index</summary>
    /// <param name="items">- The items to search</param>
    /// <param name="selectedId">- The selected item's id to find</param>
    abstract _getSelectedIndex: items: obj * selectedId: obj -> unit
    /// Render a color cell
    abstract _renderOption: obj with get, set
    /// Callback passed to the GridCell that will manage triggering the onCellHovered callback for mouseEnter
    abstract _onMouseEnter: obj with get, set
    /// Callback passed to the GridCell that will manage Hover/Focus updates
    abstract _onMouseMove: obj with get, set
    /// Callback passed to the GridCell that will manage Hover/Focus updates
    abstract _onMouseLeave: obj with get, set
    /// Callback to make sure we don't update the hovered element during mouse wheel
    abstract _onWheel: obj with get, set
    /// Callback that
    abstract _onKeyDown: obj with get, set
    /// Sets a timeout so we won't process any mouse "hover" events
    /// while navigating (via mouseWheel or arrowKeys)
    abstract setNavigationTimeout: obj with get, set
    /// Callback passed to the GridCell class that will trigger the onCellHovered callback of the SwatchColorPicker
    /// NOTE: This will not be triggered if shouldFocusOnHover === true
    abstract _onGridCellHovered: obj with get, set
    /// Callback passed to the GridCell class that will trigger the onCellFocus callback of the SwatchColorPicker
    abstract _onGridCellFocused: obj with get, set
    /// Handle the click on a cell
    abstract _onCellClick: obj with get, set

type [<AllowNullLiteral>] SwatchColorPickerBaseStatic =
    [<Emit "new $0($1...)">] abstract Create: props: ISwatchColorPickerProps -> SwatchColorPickerBase
type IColorPickerGridCellProps = __ColorPickerGridCell_types.IColorPickerGridCellProps

type [<AllowNullLiteral>] IExports =
    abstract ColorPickerGridCellBase: ColorPickerGridCellBaseStatic

type [<AllowNullLiteral>] ColorPickerGridCellBase =
    inherit React.Component<IColorPickerGridCellProps, obj>
    abstract defaultProps: IColorPickerGridCellProps with get, set
    abstract _classNames: obj with get, set
    abstract render: unit -> JSX.Element
    /// Render the core of a color cell
    abstract _onRenderColorOption: obj with get, set
    /// <summary>Validate if the cell's color is white or not to apply whiteCell style</summary>
    /// <param name="inputColor">- The color of the current cell</param>
    abstract _isWhiteCell: inputColor: obj -> unit
    /// Method to override the getClassNames func in a button.
    abstract _getClassNames: obj with get, set

type [<AllowNullLiteral>] ColorPickerGridCellBaseStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> ColorPickerGridCellBase
type BaseComponent = ______Utilities.BaseComponent
type ITeachingBubbleProps = __TeachingBubble_types.ITeachingBubbleProps
type ITeachingBubbleState = __TeachingBubble.ITeachingBubbleState
type ImageFit = ______Image.ImageFit

type [<AllowNullLiteral>] IExports =
    abstract TeachingBubbleContent: TeachingBubbleContentStatic

type [<AllowNullLiteral>] TeachingBubbleContent =
    inherit BaseComponent<ITeachingBubbleProps, ITeachingBubbleState>
    abstract defaultProps: obj with get, set
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] TeachingBubbleContentStatic =
    [<Emit "new $0($1...)">] abstract Create: props: ITeachingBubbleProps -> TeachingBubbleContent
type TeachingBubble = __TeachingBubble.TeachingBubble
type TeachingBubbleContent = __TeachingBubbleContent.TeachingBubbleContent
type IImageProps = ______Image.IImageProps
type IButtonProps = ______Button.IButtonProps
type IAccessiblePopupProps = ______common_IAccessiblePopupProps.IAccessiblePopupProps
type ICalloutProps = ______Callout.ICalloutProps

type [<AllowNullLiteral>] ITeachingBubble =
    interface end

/// TeachingBubble component props.
type [<AllowNullLiteral>] ITeachingBubbleProps =
    inherit React.Props<U2<TeachingBubble, TeachingBubbleContent>>
    inherit IAccessiblePopupProps
    /// Optional callback to access the ISlider interface. Use this instead of ref for accessing
    /// the public methods and properties of the component.
    abstract componentRef: (ITeachingBubble option -> unit) option with get, set
    /// Properties to pass through for Callout, reference detail properties in ICalloutProps
    abstract calloutProps: ICalloutProps option with get, set
    /// A headline for the Teaching Bubble.
    abstract headline: string option with get, set
    /// A variation with smaller bold headline and no margins.
    abstract hasCondensedHeadline: bool option with get, set
    /// Does the TeachingBubble have a close button in the top right corner?
    abstract hasCloseIcon: bool option with get, set
    /// An Image for the Teaching Bubble.
    abstract illustrationImage: IImageProps option with get, set
    /// The Primary interaction button
    abstract primaryButtonProps: IButtonProps option with get, set
    /// The Secondary interaction button
    abstract secondaryButtonProps: IButtonProps option with get, set
    /// Element to anchor the TeachingBubble to.
    abstract targetElement: HTMLElement option with get, set
    /// Callback when the TeachingBubble tries to close.
    abstract onDismiss: (obj option -> unit) option with get, set
    /// Whether or not the Teaching Bubble is wide, with image on the left side.
    abstract isWide: bool option with get, set
    /// A variation with smaller bold headline and margins to the body (hasCondensedHeadline takes precedence if it is also set to true).
    abstract hasSmallHeadline: bool option with get, set
type BaseComponent = ______Utilities.BaseComponent
type ITeachingBubbleProps = __TeachingBubble_types.ITeachingBubbleProps
type DirectionalHint = ______common_DirectionalHint.DirectionalHint

type [<AllowNullLiteral>] IExports =
    abstract TeachingBubble: TeachingBubbleStatic

type [<AllowNullLiteral>] ITeachingBubbleState =
    abstract isTeachingBubbleVisible: bool option with get, set

type [<AllowNullLiteral>] TeachingBubble =
    inherit BaseComponent<ITeachingBubbleProps, ITeachingBubbleState>
    abstract defaultProps: obj with get, set
    abstract _defaultCalloutProps: obj with get, set
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] TeachingBubbleStatic =
    [<Emit "new $0($1...)">] abstract Create: props: ITeachingBubbleProps -> TeachingBubble
type IRenderFunction = ______Utilities.IRenderFunction
type IIconProps = ______Icon.IIconProps

type [<AllowNullLiteral>] ITextField =
    /// Gets the current value of the input. 
    abstract value: string option with get, set
    /// Sets focus to the input. 
    abstract focus: (unit -> unit) with get, set
    /// Select the value of the text field. 
    abstract select: (unit -> unit) with get, set
    /// Sets the selection start of the text field to a specified value. 
    abstract setSelectionStart: (float -> unit) with get, set
    /// Sets the selection end of the text field to a specified value. 
    abstract setSelectionEnd: (float -> unit) with get, set
    /// Sets the start and end positions of a selection in a text field.
    abstract setSelectionRange: (float -> float -> unit) with get, set
    /// Gets the selection start of the text field. Returns -1 if there is no selection. 
    abstract selectionStart: float option with get, set
    /// Gets the selection end of the text field. Returns -1 if there is no selection. 
    abstract selectionEnd: float option with get, set

/// TextField component props.
type [<AllowNullLiteral>] ITextFieldProps =
    inherit React.AllHTMLAttributes<U2<HTMLInputElement, HTMLTextAreaElement>>
    /// Optional callback to access the ITextField interface. Use this instead of ref for accessing
    /// the public methods and properties of the component.
    abstract componentRef: (ITextField option -> unit) option with get, set
    /// Whether or not the textfield is a multiline textfield.
    abstract multiline: bool option with get, set
    /// Whether or not the multiline textfield is resizable.
    abstract resizable: bool option with get, set
    /// Whether or not to auto adjust textField height. Applies only to multiline textfield.
    abstract autoAdjustHeight: bool option with get, set
    /// Whether or not the textfield is underlined.
    abstract underlined: bool option with get, set
    /// Whether or not the textfield is borderless.
    abstract borderless: bool option with get, set
    /// Label for the textfield.
    abstract label: string option with get, set
    /// Optional custom renderer for the label.
    abstract onRenderLabel: IRenderFunction<ITextFieldProps> option with get, set
    /// The textfield input description
    abstract description: string option with get, set
    /// Optional custom renderer for the description.
    abstract onRenderDescription: IRenderFunction<ITextFieldProps> option with get, set
    abstract addonString: string option with get, set
    /// String for prefix
    abstract prefix: string option with get, set
    /// String for suffix
    abstract suffix: string option with get, set
    abstract onRenderAddon: IRenderFunction<ITextFieldProps> option with get, set
    /// Custom render function for prefix.
    abstract onRenderPrefix: IRenderFunction<ITextFieldProps> option with get, set
    /// Custom render function for suffix.
    abstract onRenderSuffix: IRenderFunction<ITextFieldProps> option with get, set
    /// Optional icon props for an icon.
    abstract iconProps: IIconProps option with get, set
    /// Default value of the textfield, if any. Only provide this if the textfield is an uncontrolled component;
    /// otherwise, use the "value" property.
    abstract defaultValue: string option with get, set
    /// Current value of the textfield. Only provide this if the textfield is a controlled component where you
    /// are maintaining its current state; otherwise, use the "defaultValue" property.
    abstract value: string option with get, set
    /// Disabled state of the textfield.
    abstract disabled: bool option with get, set
    /// If set, this will display an error message for the text field.
    abstract errorMessage: string option with get, set
    /// Callback for the onChanged event.
    abstract onChanged: (obj option -> unit) option with get, set
    /// Callback for the onBeforeChange event.
    abstract onBeforeChange: (obj option -> unit) option with get, set
    /// Callback for the onNotifyValidationResult event.
    abstract onNotifyValidationResult: (string -> string option -> unit) option with get, set
    /// The method is used to get the validation error message and determine whether the input value is valid or not.
    /// 
    ///    When it returns string:
    ///    - If valid, it returns empty string.
    ///    - If invalid, it returns the error message string and the text field will
    ///      show a red border and show an error message below the text field.
    /// 
    ///    When it returns Promise<string>:
    ///    - The resolved value is display as error message.
    ///    - The rejected, the value is thrown away.
    abstract onGetErrorMessage: (string -> U2<string, PromiseLike<string>> option) option with get, set
    /// Text field will start to validate after users stop typing for `deferredValidationTime` milliseconds.
    abstract deferredValidationTime: float option with get, set
    /// Optional class name that is added to the container of the component.
    abstract className: string option with get, set
    /// Optional class name that is added specifically to the input/textarea element.
    abstract inputClassName: string option with get, set
    /// Aria Label for textfield, if any.
    abstract ariaLabel: string option with get, set
    /// Run validation only on input focus
    abstract validateOnFocusIn: bool option with get, set
    /// Run validation only on input focus out
    abstract validateOnFocusOut: bool option with get, set
    /// Optional flag to disable onload validation
    abstract validateOnLoad: bool option with get, set
    abstract iconClass: string option with get, set
    /// Whether the input field should have autocomplete enabled.
    /// This tells the browser to display options based on earlier typed values.
    abstract autoComplete: U2<string, string> option with get, set
    /// The masking string that defines the mask's behavior.
    /// A backslash will escape any character.
    /// Special format characters are:
    /// '9': [0-9]
    /// 'a': [a-zA-Z]
    /// '*': [a-zA-Z0-9]
    abstract mask: string option with get, set
    /// The character to show in place of unfilled characters of the mask.
    abstract maskChar: string option with get, set
    /// An object defining the format characters and corresponding regexp values.
    /// Default format characters: {
    ///   '9': /[0-9]/,
    ///   'a': /[a-zA-Z]/,
    ///   '*': /[a-zA-Z0-9]/
    /// }
    abstract maskFormat: obj option with get, set
    /// Deprecated property. Serves no function.
    abstract componentId: string option with get, set
type ITextField = __TextField_types.ITextField
type ITextFieldProps = __TextField_types.ITextFieldProps
type BaseComponent = ______Utilities.BaseComponent

type [<AllowNullLiteral>] IExports =
    abstract TextField: TextFieldStatic

type [<AllowNullLiteral>] ITextFieldState =
    abstract value: string option with get, set
    /// Is true when the control has focus. 
    abstract isFocused: bool option with get, set
    /// The validation error message.
    /// 
    /// - If there is no validation error or we have not validated the input value, errorMessage is an empty string.
    /// - If we have done the validation and there is validation error, errorMessage is the validation error message.
    abstract errorMessage: string option with get, set

type [<AllowNullLiteral>] TextField =
    inherit BaseComponent<ITextFieldProps, ITextFieldState>
    inherit ITextField
    abstract defaultProps: ITextFieldProps with get, set
    abstract _id: obj with get, set
    abstract _descriptionId: obj with get, set
    abstract _delayedValidate: obj with get, set
    abstract _isMounted: obj with get, set
    abstract _lastValidation: obj with get, set
    abstract _latestValue: obj with get, set
    abstract _latestValidateValue: obj with get, set
    abstract _isDescriptionAvailable: obj with get, set
    abstract _textElement: obj with get, set
    /// Gets the current value of the text field.
    abstract value: string option
    abstract componentDidMount: unit -> unit
    abstract componentWillReceiveProps: newProps: ITextFieldProps -> unit
    abstract componentWillUnmount: unit -> unit
    abstract render: unit -> JSX.Element
    /// Sets focus on the text field
    abstract focus: unit -> unit
    /// Selects the text field
    abstract select: unit -> unit
    /// Sets the selection start of the text field to a specified value
    abstract setSelectionStart: value: float -> unit
    /// Sets the selection end of the text field to a specified value
    abstract setSelectionEnd: value: float -> unit
    /// Gets the selection start of the text field
    abstract selectionStart: float option
    /// Gets the selection end of the text field
    abstract selectionEnd: float option
    /// <summary>Sets the start and end positions of a selection in a text field.</summary>
    /// <param name="start">Index of the start of the selection.</param>
    /// <param name="end">Index of the end of the selection.</param>
    abstract setSelectionRange: start: float * ``end``: float -> unit
    abstract _onFocus: ev: obj -> unit
    abstract _onBlur: ev: obj -> unit
    abstract _onRenderLabel: obj with get, set
    abstract _onRenderDescription: obj with get, set
    abstract _onRenderAddon: props: obj -> unit
    abstract _onRenderPrefix: props: obj -> unit
    abstract _onRenderSuffix: props: obj -> unit
    abstract _getTextElementClassName: unit -> unit
    abstract _errorMessage: obj
    abstract _renderTextArea: unit -> unit
    abstract _renderInput: unit -> unit
    abstract _onInputChange: ``event``: obj -> unit
    abstract _validate: value: obj -> unit
    abstract _notifyAfterValidate: value: obj * errorMessage: obj -> unit
    abstract _adjustInputHeight: unit -> unit

type [<AllowNullLiteral>] TextFieldStatic =
    [<Emit "new $0($1...)">] abstract Create: props: ITextFieldProps -> TextField
type ITextField = ___TextField_types.ITextField
type ITextFieldProps = ___TextField_types.ITextFieldProps
type BaseComponent = _________Utilities.BaseComponent
let [<Import("obj","office-ui-fabric-react")>] DEFAULT_MASK_CHAR: obj = jsNative

type [<AllowNullLiteral>] IExports =
    abstract MaskedTextField: MaskedTextFieldStatic

/// props.mask:
///   The string containing the prompt and format characters.
/// Example:
///   'Phone Number: (999) 9999'
/// 
/// _maskCharData
///   An array of data containing information regarding the format characters,
///   their indices inside the display text, and their corresponding values.
/// Example:
///   [
///     { value: '1', displayIndex: 16, format: /[0-9]/ },
///     { value: '2', displayIndex: 17, format: /[0-9]/ },
///     { displayIndex: 18, format: /[0-9]/ },
///     { value: '4', displayIndex: 22, format: /[0-9]/ },
///     ...
///   ]
type [<AllowNullLiteral>] IMaskedTextFieldState =
    /// The mask string formatted with the input value.
    /// This is what is displayed inside the TextField
    /// Example:
    ///   'Phone Number: 12_ - 4___'
    abstract displayValue: string with get, set
    /// The index into the rendered value of the first unfilled format character 
    abstract maskCursorPosition: float option with get, set

type [<AllowNullLiteral>] MaskedTextField =
    inherit BaseComponent<ITextFieldProps, IMaskedTextFieldState>
    inherit ITextField
    abstract defaultProps: ITextFieldProps with get, set
    /// Tell BaseComponent to bypass resolution of componentRef.
    abstract _shouldUpdateComponentRef: bool with get, set
    abstract _textField: obj with get, set
    abstract _maskCharData: obj with get, set
    abstract _isFocused: obj with get, set
    abstract _moveCursorOnMouseUp: obj with get, set
    abstract _changeSelectionData: obj with get, set
    abstract componentWillReceiveProps: newProps: ITextFieldProps -> unit
    abstract componentDidUpdate: unit -> unit
    abstract render: unit -> JSX.Element
    abstract value: string option
    abstract setValue: newValue: string -> unit
    abstract focus: unit -> unit
    abstract select: unit -> unit
    abstract setSelectionStart: value: float -> unit
    abstract setSelectionEnd: value: float -> unit
    abstract setSelectionRange: start: float * ``end``: float -> unit
    abstract selectionStart: float option
    abstract selectionEnd: float option
    abstract _onFocus: ``event``: obj -> unit
    abstract _onBlur: ``event``: obj -> unit
    abstract _onMouseDown: ``event``: obj -> unit
    abstract _onMouseUp: ``event``: obj -> unit
    abstract _onBeforeChange: value: obj -> unit
    abstract _onInputChange: value: obj -> unit
    abstract _onKeyDown: ``event``: obj -> unit
    abstract _onPaste: ``event``: obj -> unit

type [<AllowNullLiteral>] MaskedTextFieldStatic =
    [<Emit "new $0($1...)">] abstract Create: props: ITextFieldProps -> MaskedTextField
type Toggle = __Toggle.Toggle
type IStyle = ______Styling.IStyle
type ITheme = ______Styling.ITheme
type IKeytipProps = ______Keytip.IKeytipProps

type [<AllowNullLiteral>] IToggle =
    abstract focus: (unit -> unit) with get, set

/// Toggle component props.
type [<AllowNullLiteral>] IToggleProps =
    inherit React.HTMLAttributes<U2<HTMLElement, Toggle>>
    /// Optional callback to access the IToggle interface. Use this instead of ref for accessing
    /// the public methods and properties of the component.
    abstract componentRef: (IToggle option -> unit) option with get, set
    /// A label for the toggle.
    abstract label: string option with get, set
    /// Text to display when toggle is ON.
    abstract onText: string option with get, set
    /// Text to display when toggle is OFF.
    abstract offText: string option with get, set
    /// Text for screen-reader to announce when toggle is ON.
    abstract onAriaLabel: string option with get, set
    /// Text for screen-reader to announce when toggle is OFF.
    abstract offAriaLabel: string option with get, set
    /// Checked state of the toggle. If you are maintaining state yourself, use this property. Otherwise refer to 'defaultChecked'.
    abstract ``checked``: bool option with get, set
    /// Initial state of the toggle. If you want the toggle to maintain its own state, use this. Otherwise refer to 'checked'.
    abstract defaultChecked: bool option with get, set
    /// Optional disabled flag.
    abstract disabled: bool option with get, set
    /// onchange callback.
    abstract onChanged: (bool -> unit) option with get, set
    /// Theme provided by HOC.
    abstract theme: ITheme option with get, set
    /// Custom styles for this component
    abstract styles: IToggleStyles option with get, set
    /// Optional keytip for this toggle
    abstract keytipProps: IKeytipProps option with get, set

type [<AllowNullLiteral>] IToggleStyles =
    /// Style for the root element in the default enabled/unchecked state.
    abstract root: IStyle option with get, set
    abstract label: IStyle option with get, set
    /// Style for the container wrapping switch and the state (on/off) text.
    abstract container: IStyle option with get, set
    /// Style for the toggle "pill" element, which is inside of the container and contains the thumb.
    abstract pill: IStyle option with get, set
    /// Style override for the pill element when enabled/checked.
    abstract pillChecked: IStyle option with get, set
    /// Style override for the pill element when enabled/unchecked/hovered.
    abstract pillHovered: IStyle option with get, set
    /// Style override for the pill element when enabled/checked/hovered.
    abstract pillCheckedHovered: IStyle option with get, set
    /// Style override for the pill element when disabled/unchecked.
    abstract pillDisabled: IStyle option with get, set
    /// Style override for the pill element when disabled/checked.
    abstract pillCheckedDisabled: IStyle option with get, set
    /// Style for the thumb element inside of the pill, in the normal unchecked enabled state.
    abstract thumb: IStyle option with get, set
    /// Style override for the thumb when enabled/unchecked/hovered.
    abstract thumbHovered: IStyle option with get, set
    /// Style override for the thumb when enabled/checked.
    abstract thumbChecked: IStyle option with get, set
    /// Style override for the thumb when enabled/checked/hovered.
    abstract thumbCheckedHovered: IStyle option with get, set
    /// Style override for the thumb when disabled/unchecked.
    abstract thumbDisabled: IStyle option with get, set
    /// Style override for the thumb when disabled/checked.
    abstract thumbCheckedDisabled: IStyle option with get, set
    /// Style for the text indicating the on/off state of the control.
    abstract text: IStyle option with get, set
type BaseComponent = ______Utilities.BaseComponent
type IToggleProps = __Toggle_types.IToggleProps
type IToggle = __Toggle_types.IToggle

type [<AllowNullLiteral>] IExports =
    abstract Toggle: ToggleStatic

type [<AllowNullLiteral>] IToggleState =
    abstract isChecked: bool with get, set

type [<AllowNullLiteral>] Toggle =
    inherit BaseComponent<IToggleProps, IToggleState>
    inherit IToggle
    abstract _id: obj with get, set
    abstract _toggleButton: obj with get, set
    /// Gets the current checked state of the toggle.
    abstract ``checked``: bool
    abstract componentWillReceiveProps: newProps: IToggleProps -> unit
    abstract render: unit -> JSX.Element
    abstract focus: unit -> unit
    abstract _onClick: obj with get, set
    abstract _noop: unit -> unit

type [<AllowNullLiteral>] ToggleStatic =
    [<Emit "new $0($1...)">] abstract Create: props: IToggleProps -> Toggle

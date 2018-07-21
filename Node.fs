// ts2fable 0.0.0
module rec Node
open System
open Fable.Core
open Fable.Import.JS

let [<Import("*","assert")>] ``assert``: Assert.IExports = jsNative
let [<Import("*","async_hooks")>] async_hooks: Async_hooks.IExports = jsNative
let [<Import("*","buffer")>] buffer: Buffer.IExports = jsNative
let [<Import("*","child_process")>] child_process: Child_process.IExports = jsNative
let [<Import("*","cluster")>] cluster: Cluster.IExports = jsNative
let [<Import("*","crypto")>] crypto: Crypto.IExports = jsNative
let [<Import("*","dgram")>] dgram: Dgram.IExports = jsNative
let [<Import("*","dns")>] dns: Dns.IExports = jsNative
let [<Import("*","domain")>] domain: Domain.IExports = jsNative
let [<Import("*","events")>] events: Events.IExports = jsNative
let [<Import("*","fs")>] fs: Fs.IExports = jsNative
let [<Import("*","http")>] http: Http.IExports = jsNative
let [<Import("*","http2")>] http2: Http2.IExports = jsNative
let [<Import("*","https")>] https: Https.IExports = jsNative
let [<Import("*","net")>] net: Net.IExports = jsNative
let [<Import("*","os")>] os: Os.IExports = jsNative
let [<Import("*","path")>] path: Path.IExports = jsNative
let [<Import("*","perf_hooks")>] perf_hooks: Perf_hooks.IExports = jsNative
let [<Import("*","punycode")>] punycode: Punycode.IExports = jsNative
let [<Import("*","querystring")>] querystring: Querystring.IExports = jsNative
let [<Import("*","readline")>] readline: Readline.IExports = jsNative
let [<Import("*","repl")>] repl: Repl.IExports = jsNative
let [<Import("*","stream")>] stream: Stream.IExports = jsNative
let [<Import("*","timers")>] timers: Timers.IExports = jsNative
let [<Import("*","tls")>] tls: Tls.IExports = jsNative
let [<Import("*","tty")>] tty: Tty.IExports = jsNative
let [<Import("*","url")>] url: Url.IExports = jsNative
let [<Import("*","util")>] util: Util.IExports = jsNative
let [<Import("*","v8")>] v8: V8.IExports = jsNative
let [<Import("*","vm")>] vm: Vm.IExports = jsNative
let [<Import("*","zlib")>] zlib: Zlib.IExports = jsNative
let [<Global>] Symbol: SymbolConstructor = jsNative
let [<Global>] ``process``: NodeJS.Process = jsNative
let [<Global>] ``global``: NodeJS.Global = jsNative
let [<Global>] console: Console = jsNative
let [<Global>] __filename: string = jsNative
let [<Global>] __dirname: string = jsNative
let [<Global>] require: NodeRequire = jsNative
let [<Global>] ``module``: NodeModule = jsNative
let [<Global>] exports: obj option = jsNative
let [<Global>] SlowBuffer: obj = jsNative
let [<Global>] Buffer: obj = jsNative

type [<AllowNullLiteral>] IExports =
    abstract setTimeout: callback: (ResizeArray<obj option> -> unit) * ms: float * [<ParamArray>] args: ResizeArray<obj option> -> NodeJS.Timer
    abstract clearTimeout: timeoutId: NodeJS.Timer -> unit
    abstract setInterval: callback: (ResizeArray<obj option> -> unit) * ms: float * [<ParamArray>] args: ResizeArray<obj option> -> NodeJS.Timer
    abstract clearInterval: intervalId: NodeJS.Timer -> unit
    abstract setImmediate: callback: (ResizeArray<obj option> -> unit) * [<ParamArray>] args: ResizeArray<obj option> -> obj option
    abstract clearImmediate: immediateId: obj option -> unit

/// inspector module types 
type [<AllowNullLiteral>] Console =
    abstract Console: NodeJS.ConsoleConstructor with get, set
    abstract ``assert``: value: obj option * ?message: string * [<ParamArray>] optionalParams: ResizeArray<obj option> -> unit
    abstract dir: obj: obj option * ?options: NodeJS.InspectOptions -> unit
    abstract debug: ?message: obj option * [<ParamArray>] optionalParams: ResizeArray<obj option> -> unit
    abstract error: ?message: obj option * [<ParamArray>] optionalParams: ResizeArray<obj option> -> unit
    abstract info: ?message: obj option * [<ParamArray>] optionalParams: ResizeArray<obj option> -> unit
    abstract log: ?message: obj option * [<ParamArray>] optionalParams: ResizeArray<obj option> -> unit
    abstract time: label: string -> unit
    abstract timeEnd: label: string -> unit
    abstract trace: ?message: obj option * [<ParamArray>] optionalParams: ResizeArray<obj option> -> unit
    abstract warn: ?message: obj option * [<ParamArray>] optionalParams: ResizeArray<obj option> -> unit

type [<AllowNullLiteral>] Error =
    abstract stack: string option with get, set

type [<AllowNullLiteral>] ErrorConstructor =
    /// Create .stack property on a target object 
    abstract captureStackTrace: targetObject: Object * ?constructorOpt: Function -> unit
    /// Optional override for formatting stack traces
    abstract prepareStackTrace: (Error -> ResizeArray<NodeJS.CallSite> -> obj option) option with get, set
    abstract stackTraceLimit: float with get, set

type [<AllowNullLiteral>] MapConstructor =
    interface end

type [<AllowNullLiteral>] WeakMapConstructor =
    interface end

type [<AllowNullLiteral>] SetConstructor =
    interface end

type [<AllowNullLiteral>] WeakSetConstructor =
    interface end

type [<AllowNullLiteral>] Iterable<'T> =
    interface end

type [<AllowNullLiteral>] Iterator<'T> =
    abstract next: ?value: obj option -> IteratorResult<'T>

type [<AllowNullLiteral>] IteratorResult<'T> =
    interface end

type [<AllowNullLiteral>] SymbolConstructor =
    abstract iterator: Symbol

type [<AllowNullLiteral>] String =
    /// Removes whitespace from the left end of a string. 
    abstract trimLeft: unit -> string
    /// Removes whitespace from the right end of a string. 
    abstract trimRight: unit -> string

module SetTimeout =

    type [<AllowNullLiteral>] IExports =
        abstract __promisify__: ms: float -> Promise<unit>
        abstract __promisify__: ms: float * value: 'T -> Promise<'T>

module SetImmediate =

    type [<AllowNullLiteral>] IExports =
        abstract __promisify__: unit -> Promise<unit>
        abstract __promisify__: value: 'T -> Promise<'T>

type [<AllowNullLiteral>] NodeRequireFunction =
    [<Emit "$0($1...)">] abstract Invoke: id: string -> obj option

type [<AllowNullLiteral>] NodeRequire =
    inherit NodeRequireFunction
    abstract resolve: RequireResolve with get, set
    abstract cache: obj option with get, set
    abstract extensions: NodeExtensions with get, set
    abstract main: NodeModule option with get, set

type [<AllowNullLiteral>] RequireResolve =
    [<Emit "$0($1...)">] abstract Invoke: id: string * ?options: RequireResolveInvokeOptions -> string
    abstract paths: request: string -> ResizeArray<string> option

type [<AllowNullLiteral>] RequireResolveInvokeOptions =
    abstract paths: ResizeArray<string> option with get, set

type [<AllowNullLiteral>] NodeExtensions =
    abstract ``.js``: (NodeModule -> string -> obj option) with get, set
    abstract ``.json``: (NodeModule -> string -> obj option) with get, set
    abstract ``.node``: (NodeModule -> string -> obj option) with get, set
    [<Emit "$0[$1]{{=$2}}">] abstract Item: ext: string -> (NodeModule -> string -> obj option) with get, set

type [<AllowNullLiteral>] NodeModule =
    abstract exports: obj option with get, set
    abstract require: NodeRequireFunction with get, set
    abstract id: string with get, set
    abstract filename: string with get, set
    abstract loaded: bool with get, set
    abstract parent: NodeModule option with get, set
    abstract children: ResizeArray<NodeModule> with get, set
    abstract paths: ResizeArray<string> with get, set

type [<StringEnum>] [<RequireQualifiedAccess>] BufferEncoding =
    | Ascii
    | Utf8
    | Utf16le
    | Ucs2
    | Base64
    | Latin1
    | Binary
    | Hex

/// Raw data is stored in instances of the Buffer class.
/// A Buffer is similar to an array of integers but corresponds to a raw memory allocation outside the V8 heap.  A Buffer cannot be resized.
/// Valid string encodings: 'ascii'|'utf8'|'utf16le'|'ucs2'(alias of 'utf16le')|'base64'|'binary'(deprecated)|'hex'
type [<AllowNullLiteral>] Buffer =
    inherit NodeBuffer

module NodeJS =

    type [<AllowNullLiteral>] IExports =
        abstract ConsoleConstructor: ConsoleConstructorStatic
        abstract EventEmitter: EventEmitterStatic
        abstract Module: ModuleStatic

    type [<AllowNullLiteral>] InspectOptions =
        abstract showHidden: bool option with get, set
        abstract depth: float option with get, set
        abstract colors: bool option with get, set
        abstract customInspect: bool option with get, set
        abstract showProxy: bool option with get, set
        abstract maxArrayLength: float option with get, set
        abstract breakLength: float option with get, set

    type [<AllowNullLiteral>] ConsoleConstructor =
        abstract prototype: Console with get, set

    type [<AllowNullLiteral>] ConsoleConstructorStatic =
        [<Emit "new $0($1...)">] abstract Create: stdout: WritableStream * ?stderr: WritableStream -> ConsoleConstructor

    type [<AllowNullLiteral>] CallSite =
        /// Value of "this"
        abstract getThis: unit -> obj option
        /// Type of "this" as a string.
        /// This is the name of the function stored in the constructor field of
        /// "this", if available.  Otherwise the object's [[Class]] internal
        /// property.
        abstract getTypeName: unit -> string option
        /// Current function
        abstract getFunction: unit -> Function option
        /// Name of the current function, typically its name property.
        /// If a name property is not available an attempt will be made to try
        /// to infer a name from the function's context.
        abstract getFunctionName: unit -> string option
        /// Name of the property [of "this" or one of its prototypes] that holds
        /// the current function
        abstract getMethodName: unit -> string option
        /// Name of the script [if this function was defined in a script]
        abstract getFileName: unit -> string option
        /// Current line number [if this function was defined in a script]
        abstract getLineNumber: unit -> float option
        /// Current column number [if this function was defined in a script]
        abstract getColumnNumber: unit -> float option
        /// A call site object representing the location where eval was called
        /// [if this function was created using a call to eval]
        abstract getEvalOrigin: unit -> string option
        /// Is this a toplevel invocation, that is, is "this" the global object?
        abstract isToplevel: unit -> bool
        /// Does this call take place in code defined by a call to eval?
        abstract isEval: unit -> bool
        /// Is this call in native V8 code?
        abstract isNative: unit -> bool
        /// Is this a constructor call?
        abstract isConstructor: unit -> bool

    type [<AllowNullLiteral>] ErrnoException =
        inherit Error
        abstract errno: float option with get, set
        abstract code: string option with get, set
        abstract path: string option with get, set
        abstract syscall: string option with get, set
        abstract stack: string option with get, set

    type [<AllowNullLiteral>] EventEmitter =
        abstract addListener: ``event``: U2<string, Symbol> * listener: (ResizeArray<obj option> -> unit) -> EventEmitter
        abstract on: ``event``: U2<string, Symbol> * listener: (ResizeArray<obj option> -> unit) -> EventEmitter
        abstract once: ``event``: U2<string, Symbol> * listener: (ResizeArray<obj option> -> unit) -> EventEmitter
        abstract removeListener: ``event``: U2<string, Symbol> * listener: (ResizeArray<obj option> -> unit) -> EventEmitter
        abstract removeAllListeners: ?``event``: U2<string, Symbol> -> EventEmitter
        abstract setMaxListeners: n: float -> EventEmitter
        abstract getMaxListeners: unit -> float
        abstract listeners: ``event``: U2<string, Symbol> -> ResizeArray<Function>
        abstract emit: ``event``: U2<string, Symbol> * [<ParamArray>] args: ResizeArray<obj option> -> bool
        abstract listenerCount: ``type``: U2<string, Symbol> -> float
        abstract prependListener: ``event``: U2<string, Symbol> * listener: (ResizeArray<obj option> -> unit) -> EventEmitter
        abstract prependOnceListener: ``event``: U2<string, Symbol> * listener: (ResizeArray<obj option> -> unit) -> EventEmitter
        abstract eventNames: unit -> Array<U2<string, Symbol>>

    type [<AllowNullLiteral>] EventEmitterStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> EventEmitter

    type [<AllowNullLiteral>] ReadableStream =
        inherit EventEmitter
        abstract readable: bool with get, set
        abstract read: ?size: float -> U2<string, Buffer>
        abstract setEncoding: encoding: string -> ReadableStream
        abstract pause: unit -> ReadableStream
        abstract resume: unit -> ReadableStream
        abstract isPaused: unit -> bool
        abstract pipe: destination: 'T * ?options: ReadableStreamPipeOptions -> 'T
        abstract unpipe: ?destination: 'T -> ReadableStream
        abstract unshift: chunk: string -> unit
        abstract unshift: chunk: Buffer -> unit
        abstract wrap: oldStream: ReadableStream -> ReadableStream

    type [<AllowNullLiteral>] ReadableStreamPipeOptions =
        abstract ``end``: bool option with get, set

    type [<AllowNullLiteral>] WritableStream =
        inherit EventEmitter
        abstract writable: bool with get, set
        abstract write: buffer: U2<Buffer, string> * ?cb: Function -> bool
        abstract write: str: string * ?encoding: string * ?cb: Function -> bool
        abstract ``end``: ?cb: Function -> unit
        abstract ``end``: buffer: Buffer * ?cb: Function -> unit
        abstract ``end``: str: string * ?cb: Function -> unit
        abstract ``end``: str: string * ?encoding: string * ?cb: Function -> unit

    type [<AllowNullLiteral>] ReadWriteStream =
        inherit ReadableStream
        inherit WritableStream

    type [<AllowNullLiteral>] Events =
        inherit EventEmitter

    type [<AllowNullLiteral>] Domain =
        inherit Events
        abstract run: fn: Function -> unit
        abstract add: emitter: Events -> unit
        abstract remove: emitter: Events -> unit
        abstract bind: cb: (Error -> obj option -> obj option) -> obj option
        abstract intercept: cb: (obj option -> obj option) -> obj option
        abstract dispose: unit -> unit
        abstract addListener: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> Domain
        abstract on: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> Domain
        abstract once: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> Domain
        abstract removeListener: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> Domain
        abstract removeAllListeners: ?``event``: string -> Domain

    type [<AllowNullLiteral>] MemoryUsage =
        abstract rss: float with get, set
        abstract heapTotal: float with get, set
        abstract heapUsed: float with get, set
        abstract ``external``: float with get, set

    type [<AllowNullLiteral>] CpuUsage =
        abstract user: float with get, set
        abstract system: float with get, set

    type [<AllowNullLiteral>] ProcessVersions =
        abstract http_parser: string with get, set
        abstract node: string with get, set
        abstract v8: string with get, set
        abstract ares: string with get, set
        abstract uv: string with get, set
        abstract zlib: string with get, set
        abstract modules: string with get, set
        abstract openssl: string with get, set

    type [<StringEnum>] [<RequireQualifiedAccess>] Platform =
        | Aix
        | Android
        | Darwin
        | Freebsd
        | Linux
        | Openbsd
        | Sunos
        | Win32
        | Cygwin

    type [<StringEnum>] [<RequireQualifiedAccess>] Signals =
        | [<CompiledName "SIGABRT">] SIGABRT
        | [<CompiledName "SIGALRM">] SIGALRM
        | [<CompiledName "SIGBUS">] SIGBUS
        | [<CompiledName "SIGCHLD">] SIGCHLD
        | [<CompiledName "SIGCONT">] SIGCONT
        | [<CompiledName "SIGFPE">] SIGFPE
        | [<CompiledName "SIGHUP">] SIGHUP
        | [<CompiledName "SIGILL">] SIGILL
        | [<CompiledName "SIGINT">] SIGINT
        | [<CompiledName "SIGIO">] SIGIO
        | [<CompiledName "SIGIOT">] SIGIOT
        | [<CompiledName "SIGKILL">] SIGKILL
        | [<CompiledName "SIGPIPE">] SIGPIPE
        | [<CompiledName "SIGPOLL">] SIGPOLL
        | [<CompiledName "SIGPROF">] SIGPROF
        | [<CompiledName "SIGPWR">] SIGPWR
        | [<CompiledName "SIGQUIT">] SIGQUIT
        | [<CompiledName "SIGSEGV">] SIGSEGV
        | [<CompiledName "SIGSTKFLT">] SIGSTKFLT
        | [<CompiledName "SIGSTOP">] SIGSTOP
        | [<CompiledName "SIGSYS">] SIGSYS
        | [<CompiledName "SIGTERM">] SIGTERM
        | [<CompiledName "SIGTRAP">] SIGTRAP
        | [<CompiledName "SIGTSTP">] SIGTSTP
        | [<CompiledName "SIGTTIN">] SIGTTIN
        | [<CompiledName "SIGTTOU">] SIGTTOU
        | [<CompiledName "SIGUNUSED">] SIGUNUSED
        | [<CompiledName "SIGURG">] SIGURG
        | [<CompiledName "SIGUSR1">] SIGUSR1
        | [<CompiledName "SIGUSR2">] SIGUSR2
        | [<CompiledName "SIGVTALRM">] SIGVTALRM
        | [<CompiledName "SIGWINCH">] SIGWINCH
        | [<CompiledName "SIGXCPU">] SIGXCPU
        | [<CompiledName "SIGXFSZ">] SIGXFSZ
        | [<CompiledName "SIGBREAK">] SIGBREAK
        | [<CompiledName "SIGLOST">] SIGLOST
        | [<CompiledName "SIGINFO">] SIGINFO

    type [<AllowNullLiteral>] BeforeExitListener =
        [<Emit "$0($1...)">] abstract Invoke: code: float -> unit

    type [<AllowNullLiteral>] DisconnectListener =
        [<Emit "$0($1...)">] abstract Invoke: unit -> unit

    type [<AllowNullLiteral>] ExitListener =
        [<Emit "$0($1...)">] abstract Invoke: code: float -> unit

    type [<AllowNullLiteral>] RejectionHandledListener =
        [<Emit "$0($1...)">] abstract Invoke: promise: Promise<obj option> -> unit

    type [<AllowNullLiteral>] UncaughtExceptionListener =
        [<Emit "$0($1...)">] abstract Invoke: error: Error -> unit

    type [<AllowNullLiteral>] UnhandledRejectionListener =
        [<Emit "$0($1...)">] abstract Invoke: reason: obj option * promise: Promise<obj option> -> unit

    type [<AllowNullLiteral>] WarningListener =
        [<Emit "$0($1...)">] abstract Invoke: warning: Error -> unit

    type [<AllowNullLiteral>] MessageListener =
        [<Emit "$0($1...)">] abstract Invoke: message: obj option * sendHandle: obj option -> unit

    type [<AllowNullLiteral>] SignalsListener =
        [<Emit "$0($1...)">] abstract Invoke: unit -> unit

    type [<AllowNullLiteral>] NewListenerListener =
        [<Emit "$0($1...)">] abstract Invoke: ``type``: U2<string, Symbol> * listener: (ResizeArray<obj option> -> unit) -> unit

    type [<AllowNullLiteral>] RemoveListenerListener =
        [<Emit "$0($1...)">] abstract Invoke: ``type``: U2<string, Symbol> * listener: (ResizeArray<obj option> -> unit) -> unit

    type [<AllowNullLiteral>] Socket =
        inherit ReadWriteStream
        abstract isTTY: obj option with get, set

    type [<AllowNullLiteral>] ProcessEnv =
        [<Emit "$0[$1]{{=$2}}">] abstract Item: key: string -> string option with get, set

    type [<AllowNullLiteral>] WriteStream =
        inherit Socket
        abstract writableHighWaterMark: float
        abstract columns: float option with get, set
        abstract rows: float option with get, set
        abstract _write: chunk: obj option * encoding: string * callback: Function -> unit
        abstract _destroy: err: Error * callback: Function -> unit
        abstract _final: callback: Function -> unit
        abstract setDefaultEncoding: encoding: string -> WriteStream
        abstract cork: unit -> unit
        abstract uncork: unit -> unit
        abstract destroy: ?error: Error -> unit

    type [<AllowNullLiteral>] ReadStream =
        inherit Socket
        abstract readableHighWaterMark: float
        abstract isRaw: bool option with get, set
        abstract setRawMode: mode: bool -> unit
        abstract _read: size: float -> unit
        abstract _destroy: err: Error * callback: Function -> unit
        abstract push: chunk: obj option * ?encoding: string -> bool
        abstract destroy: ?error: Error -> unit

    type [<AllowNullLiteral>] Process =
        inherit EventEmitter
        abstract stdout: WriteStream with get, set
        abstract stderr: WriteStream with get, set
        abstract stdin: ReadStream with get, set
        abstract openStdin: unit -> Socket
        abstract argv: ResizeArray<string> with get, set
        abstract argv0: string with get, set
        abstract execArgv: ResizeArray<string> with get, set
        abstract execPath: string with get, set
        abstract abort: unit -> unit
        abstract chdir: directory: string -> unit
        abstract cwd: unit -> string
        abstract debugPort: float with get, set
        abstract emitWarning: warning: U2<string, Error> * ?name: string * ?ctor: Function -> unit
        abstract env: ProcessEnv with get, set
        abstract exit: ?code: float -> obj
        abstract exitCode: float with get, set
        abstract getgid: unit -> float
        abstract setgid: id: U2<float, string> -> unit
        abstract getuid: unit -> float
        abstract setuid: id: U2<float, string> -> unit
        abstract geteuid: unit -> float
        abstract seteuid: id: U2<float, string> -> unit
        abstract getegid: unit -> float
        abstract setegid: id: U2<float, string> -> unit
        abstract getgroups: unit -> ResizeArray<float>
        abstract setgroups: groups: Array<U2<string, float>> -> unit
        abstract version: string with get, set
        abstract versions: ProcessVersions with get, set
        abstract config: obj with get, set
        abstract kill: pid: float * ?signal: U2<string, float> -> unit
        abstract pid: float with get, set
        abstract title: string with get, set
        abstract arch: string with get, set
        abstract platform: Platform with get, set
        abstract mainModule: NodeModule option with get, set
        abstract memoryUsage: unit -> MemoryUsage
        abstract cpuUsage: ?previousValue: CpuUsage -> CpuUsage
        abstract nextTick: callback: Function * [<ParamArray>] args: ResizeArray<obj option> -> unit
        abstract umask: ?mask: float -> float
        abstract uptime: unit -> float
        abstract hrtime: ?time: float * float -> float * float
        abstract domain: Domain with get, set
        abstract send: message: obj option * ?sendHandle: obj option -> unit
        abstract disconnect: unit -> unit
        abstract connected: bool with get, set
        /// EventEmitter
        ///    1. beforeExit
        ///    2. disconnect
        ///    3. exit
        ///    4. message
        ///    5. rejectionHandled
        ///    6. uncaughtException
        ///    7. unhandledRejection
        ///    8. warning
        ///    9. message
        ///   10. <All OS Signals>
        ///   11. newListener/removeListener inherited from EventEmitter
        [<Emit "$0.addListener('beforeExit',$1)">] abstract addListener_beforeExit: listener: BeforeExitListener -> Process
        [<Emit "$0.addListener('disconnect',$1)">] abstract addListener_disconnect: listener: DisconnectListener -> Process
        [<Emit "$0.addListener('exit',$1)">] abstract addListener_exit: listener: ExitListener -> Process
        [<Emit "$0.addListener('rejectionHandled',$1)">] abstract addListener_rejectionHandled: listener: RejectionHandledListener -> Process
        [<Emit "$0.addListener('uncaughtException',$1)">] abstract addListener_uncaughtException: listener: UncaughtExceptionListener -> Process
        [<Emit "$0.addListener('unhandledRejection',$1)">] abstract addListener_unhandledRejection: listener: UnhandledRejectionListener -> Process
        [<Emit "$0.addListener('warning',$1)">] abstract addListener_warning: listener: WarningListener -> Process
        [<Emit "$0.addListener('message',$1)">] abstract addListener_message: listener: MessageListener -> Process
        abstract addListener: ``event``: Signals * listener: SignalsListener -> Process
        [<Emit "$0.addListener('newListener',$1)">] abstract addListener_newListener: listener: NewListenerListener -> Process
        [<Emit "$0.addListener('removeListener',$1)">] abstract addListener_removeListener: listener: RemoveListenerListener -> Process
        [<Emit "$0.emit('beforeExit',$1)">] abstract emit_beforeExit: code: float -> bool
        [<Emit "$0.emit('disconnect')">] abstract emit_disconnect: unit -> bool
        [<Emit "$0.emit('exit',$1)">] abstract emit_exit: code: float -> bool
        [<Emit "$0.emit('rejectionHandled',$1)">] abstract emit_rejectionHandled: promise: Promise<obj option> -> bool
        [<Emit "$0.emit('uncaughtException',$1)">] abstract emit_uncaughtException: error: Error -> bool
        [<Emit "$0.emit('unhandledRejection',$1,$2)">] abstract emit_unhandledRejection: reason: obj option * promise: Promise<obj option> -> bool
        [<Emit "$0.emit('warning',$1)">] abstract emit_warning: warning: Error -> bool
        [<Emit "$0.emit('message',$1,$2)">] abstract emit_message: message: obj option * sendHandle: obj option -> Process
        abstract emit: ``event``: Signals -> bool
        [<Emit "$0.emit('newListener',$1,$2)">] abstract emit_newListener: eventName: U2<string, Symbol> * listener: (ResizeArray<obj option> -> unit) -> Process
        [<Emit "$0.emit('removeListener',$1,$2)">] abstract emit_removeListener: eventName: string * listener: (ResizeArray<obj option> -> unit) -> Process
        [<Emit "$0.on('beforeExit',$1)">] abstract on_beforeExit: listener: BeforeExitListener -> Process
        [<Emit "$0.on('disconnect',$1)">] abstract on_disconnect: listener: DisconnectListener -> Process
        [<Emit "$0.on('exit',$1)">] abstract on_exit: listener: ExitListener -> Process
        [<Emit "$0.on('rejectionHandled',$1)">] abstract on_rejectionHandled: listener: RejectionHandledListener -> Process
        [<Emit "$0.on('uncaughtException',$1)">] abstract on_uncaughtException: listener: UncaughtExceptionListener -> Process
        [<Emit "$0.on('unhandledRejection',$1)">] abstract on_unhandledRejection: listener: UnhandledRejectionListener -> Process
        [<Emit "$0.on('warning',$1)">] abstract on_warning: listener: WarningListener -> Process
        [<Emit "$0.on('message',$1)">] abstract on_message: listener: MessageListener -> Process
        abstract on: ``event``: Signals * listener: SignalsListener -> Process
        [<Emit "$0.on('newListener',$1)">] abstract on_newListener: listener: NewListenerListener -> Process
        [<Emit "$0.on('removeListener',$1)">] abstract on_removeListener: listener: RemoveListenerListener -> Process
        [<Emit "$0.once('beforeExit',$1)">] abstract once_beforeExit: listener: BeforeExitListener -> Process
        [<Emit "$0.once('disconnect',$1)">] abstract once_disconnect: listener: DisconnectListener -> Process
        [<Emit "$0.once('exit',$1)">] abstract once_exit: listener: ExitListener -> Process
        [<Emit "$0.once('rejectionHandled',$1)">] abstract once_rejectionHandled: listener: RejectionHandledListener -> Process
        [<Emit "$0.once('uncaughtException',$1)">] abstract once_uncaughtException: listener: UncaughtExceptionListener -> Process
        [<Emit "$0.once('unhandledRejection',$1)">] abstract once_unhandledRejection: listener: UnhandledRejectionListener -> Process
        [<Emit "$0.once('warning',$1)">] abstract once_warning: listener: WarningListener -> Process
        [<Emit "$0.once('message',$1)">] abstract once_message: listener: MessageListener -> Process
        abstract once: ``event``: Signals * listener: SignalsListener -> Process
        [<Emit "$0.once('newListener',$1)">] abstract once_newListener: listener: NewListenerListener -> Process
        [<Emit "$0.once('removeListener',$1)">] abstract once_removeListener: listener: RemoveListenerListener -> Process
        [<Emit "$0.prependListener('beforeExit',$1)">] abstract prependListener_beforeExit: listener: BeforeExitListener -> Process
        [<Emit "$0.prependListener('disconnect',$1)">] abstract prependListener_disconnect: listener: DisconnectListener -> Process
        [<Emit "$0.prependListener('exit',$1)">] abstract prependListener_exit: listener: ExitListener -> Process
        [<Emit "$0.prependListener('rejectionHandled',$1)">] abstract prependListener_rejectionHandled: listener: RejectionHandledListener -> Process
        [<Emit "$0.prependListener('uncaughtException',$1)">] abstract prependListener_uncaughtException: listener: UncaughtExceptionListener -> Process
        [<Emit "$0.prependListener('unhandledRejection',$1)">] abstract prependListener_unhandledRejection: listener: UnhandledRejectionListener -> Process
        [<Emit "$0.prependListener('warning',$1)">] abstract prependListener_warning: listener: WarningListener -> Process
        [<Emit "$0.prependListener('message',$1)">] abstract prependListener_message: listener: MessageListener -> Process
        abstract prependListener: ``event``: Signals * listener: SignalsListener -> Process
        [<Emit "$0.prependListener('newListener',$1)">] abstract prependListener_newListener: listener: NewListenerListener -> Process
        [<Emit "$0.prependListener('removeListener',$1)">] abstract prependListener_removeListener: listener: RemoveListenerListener -> Process
        [<Emit "$0.prependOnceListener('beforeExit',$1)">] abstract prependOnceListener_beforeExit: listener: BeforeExitListener -> Process
        [<Emit "$0.prependOnceListener('disconnect',$1)">] abstract prependOnceListener_disconnect: listener: DisconnectListener -> Process
        [<Emit "$0.prependOnceListener('exit',$1)">] abstract prependOnceListener_exit: listener: ExitListener -> Process
        [<Emit "$0.prependOnceListener('rejectionHandled',$1)">] abstract prependOnceListener_rejectionHandled: listener: RejectionHandledListener -> Process
        [<Emit "$0.prependOnceListener('uncaughtException',$1)">] abstract prependOnceListener_uncaughtException: listener: UncaughtExceptionListener -> Process
        [<Emit "$0.prependOnceListener('unhandledRejection',$1)">] abstract prependOnceListener_unhandledRejection: listener: UnhandledRejectionListener -> Process
        [<Emit "$0.prependOnceListener('warning',$1)">] abstract prependOnceListener_warning: listener: WarningListener -> Process
        [<Emit "$0.prependOnceListener('message',$1)">] abstract prependOnceListener_message: listener: MessageListener -> Process
        abstract prependOnceListener: ``event``: Signals * listener: SignalsListener -> Process
        [<Emit "$0.prependOnceListener('newListener',$1)">] abstract prependOnceListener_newListener: listener: NewListenerListener -> Process
        [<Emit "$0.prependOnceListener('removeListener',$1)">] abstract prependOnceListener_removeListener: listener: RemoveListenerListener -> Process
        [<Emit "$0.listeners('beforeExit')">] abstract listeners_beforeExit: unit -> ResizeArray<BeforeExitListener>
        [<Emit "$0.listeners('disconnect')">] abstract listeners_disconnect: unit -> ResizeArray<DisconnectListener>
        [<Emit "$0.listeners('exit')">] abstract listeners_exit: unit -> ResizeArray<ExitListener>
        [<Emit "$0.listeners('rejectionHandled')">] abstract listeners_rejectionHandled: unit -> ResizeArray<RejectionHandledListener>
        [<Emit "$0.listeners('uncaughtException')">] abstract listeners_uncaughtException: unit -> ResizeArray<UncaughtExceptionListener>
        [<Emit "$0.listeners('unhandledRejection')">] abstract listeners_unhandledRejection: unit -> ResizeArray<UnhandledRejectionListener>
        [<Emit "$0.listeners('warning')">] abstract listeners_warning: unit -> ResizeArray<WarningListener>
        [<Emit "$0.listeners('message')">] abstract listeners_message: unit -> ResizeArray<MessageListener>
        abstract listeners: ``event``: Signals -> ResizeArray<SignalsListener>
        [<Emit "$0.listeners('newListener')">] abstract listeners_newListener: unit -> ResizeArray<NewListenerListener>
        [<Emit "$0.listeners('removeListener')">] abstract listeners_removeListener: unit -> ResizeArray<RemoveListenerListener>

    type [<AllowNullLiteral>] Global =
        abstract Array: obj with get, set
        abstract ArrayBuffer: obj with get, set
        abstract Boolean: obj with get, set
        abstract Buffer: obj with get, set
        abstract DataView: obj with get, set
        abstract Date: obj with get, set
        abstract Error: obj with get, set
        abstract EvalError: obj with get, set
        abstract Float32Array: obj with get, set
        abstract Float64Array: obj with get, set
        abstract Function: obj with get, set
        abstract GLOBAL: Global with get, set
        abstract Infinity: obj with get, set
        abstract Int16Array: obj with get, set
        abstract Int32Array: obj with get, set
        abstract Int8Array: obj with get, set
        abstract Intl: obj with get, set
        abstract JSON: obj with get, set
        abstract Map: MapConstructor with get, set
        abstract Math: obj with get, set
        abstract NaN: obj with get, set
        abstract Number: obj with get, set
        abstract Object: obj with get, set
        abstract Promise: Function with get, set
        abstract RangeError: obj with get, set
        abstract ReferenceError: obj with get, set
        abstract RegExp: obj with get, set
        abstract Set: SetConstructor with get, set
        abstract String: obj with get, set
        abstract Symbol: Function with get, set
        abstract SyntaxError: obj with get, set
        abstract TypeError: obj with get, set
        abstract URIError: obj with get, set
        abstract Uint16Array: obj with get, set
        abstract Uint32Array: obj with get, set
        abstract Uint8Array: obj with get, set
        abstract Uint8ClampedArray: Function with get, set
        abstract WeakMap: WeakMapConstructor with get, set
        abstract WeakSet: WeakSetConstructor with get, set
        abstract clearImmediate: (obj option -> unit) with get, set
        abstract clearInterval: (NodeJS.Timer -> unit) with get, set
        abstract clearTimeout: (NodeJS.Timer -> unit) with get, set
        abstract console: obj with get, set
        abstract decodeURI: obj with get, set
        abstract decodeURIComponent: obj with get, set
        abstract encodeURI: obj with get, set
        abstract encodeURIComponent: obj with get, set
        abstract escape: (string -> string) with get, set
        abstract eval: obj with get, set
        abstract ``global``: Global with get, set
        abstract isFinite: obj with get, set
        abstract isNaN: obj with get, set
        abstract parseFloat: obj with get, set
        abstract parseInt: obj with get, set
        abstract ``process``: Process with get, set
        abstract root: Global with get, set
        abstract setImmediate: ((ResizeArray<obj option> -> unit) -> ResizeArray<obj option> -> obj option) with get, set
        abstract setInterval: ((ResizeArray<obj option> -> unit) -> float -> ResizeArray<obj option> -> NodeJS.Timer) with get, set
        abstract setTimeout: ((ResizeArray<obj option> -> unit) -> float -> ResizeArray<obj option> -> NodeJS.Timer) with get, set
        abstract undefined: obj with get, set
        abstract unescape: (string -> string) with get, set
        abstract gc: (unit -> unit) with get, set
        abstract v8debug: obj option with get, set

    type [<AllowNullLiteral>] Timer =
        abstract ref: unit -> unit
        abstract unref: unit -> unit

    type [<AllowNullLiteral>] Module =
        abstract builtinModules: ResizeArray<string> with get, set
        abstract Module: obj with get, set
        abstract exports: obj option with get, set
        abstract require: NodeRequireFunction with get, set
        abstract id: string with get, set
        abstract filename: string with get, set
        abstract loaded: bool with get, set
        abstract parent: Module option with get, set
        abstract children: ResizeArray<Module> with get, set
        abstract paths: ResizeArray<string> with get, set

    type [<AllowNullLiteral>] ModuleStatic =
        abstract runMain: unit -> unit
        abstract wrap: code: string -> string
        [<Emit "new $0($1...)">] abstract Create: id: string * ?parent: Module -> Module

type [<AllowNullLiteral>] IterableIterator<'T> =
    interface end

type [<AllowNullLiteral>] NodeBuffer =
    inherit Uint8Array
    abstract write: string: string * ?offset: float * ?length: float * ?encoding: string -> float
    abstract toString: ?encoding: string * ?start: float * ?``end``: float -> string
    abstract toJSON: unit -> obj
    abstract equals: otherBuffer: Buffer -> bool
    abstract compare: otherBuffer: Buffer * ?targetStart: float * ?targetEnd: float * ?sourceStart: float * ?sourceEnd: float -> float
    abstract copy: targetBuffer: Buffer * ?targetStart: float * ?sourceStart: float * ?sourceEnd: float -> float
    abstract slice: ?start: float * ?``end``: float -> Buffer
    abstract writeUIntLE: value: float * offset: float * byteLength: float * ?noAssert: bool -> float
    abstract writeUIntBE: value: float * offset: float * byteLength: float * ?noAssert: bool -> float
    abstract writeIntLE: value: float * offset: float * byteLength: float * ?noAssert: bool -> float
    abstract writeIntBE: value: float * offset: float * byteLength: float * ?noAssert: bool -> float
    abstract readUIntLE: offset: float * byteLength: float * ?noAssert: bool -> float
    abstract readUIntBE: offset: float * byteLength: float * ?noAssert: bool -> float
    abstract readIntLE: offset: float * byteLength: float * ?noAssert: bool -> float
    abstract readIntBE: offset: float * byteLength: float * ?noAssert: bool -> float
    abstract readUInt8: offset: float * ?noAssert: bool -> float
    abstract readUInt16LE: offset: float * ?noAssert: bool -> float
    abstract readUInt16BE: offset: float * ?noAssert: bool -> float
    abstract readUInt32LE: offset: float * ?noAssert: bool -> float
    abstract readUInt32BE: offset: float * ?noAssert: bool -> float
    abstract readInt8: offset: float * ?noAssert: bool -> float
    abstract readInt16LE: offset: float * ?noAssert: bool -> float
    abstract readInt16BE: offset: float * ?noAssert: bool -> float
    abstract readInt32LE: offset: float * ?noAssert: bool -> float
    abstract readInt32BE: offset: float * ?noAssert: bool -> float
    abstract readFloatLE: offset: float * ?noAssert: bool -> float
    abstract readFloatBE: offset: float * ?noAssert: bool -> float
    abstract readDoubleLE: offset: float * ?noAssert: bool -> float
    abstract readDoubleBE: offset: float * ?noAssert: bool -> float
    abstract swap16: unit -> Buffer
    abstract swap32: unit -> Buffer
    abstract swap64: unit -> Buffer
    abstract writeUInt8: value: float * offset: float * ?noAssert: bool -> float
    abstract writeUInt16LE: value: float * offset: float * ?noAssert: bool -> float
    abstract writeUInt16BE: value: float * offset: float * ?noAssert: bool -> float
    abstract writeUInt32LE: value: float * offset: float * ?noAssert: bool -> float
    abstract writeUInt32BE: value: float * offset: float * ?noAssert: bool -> float
    abstract writeInt8: value: float * offset: float * ?noAssert: bool -> float
    abstract writeInt16LE: value: float * offset: float * ?noAssert: bool -> float
    abstract writeInt16BE: value: float * offset: float * ?noAssert: bool -> float
    abstract writeInt32LE: value: float * offset: float * ?noAssert: bool -> float
    abstract writeInt32BE: value: float * offset: float * ?noAssert: bool -> float
    abstract writeFloatLE: value: float * offset: float * ?noAssert: bool -> float
    abstract writeFloatBE: value: float * offset: float * ?noAssert: bool -> float
    abstract writeDoubleLE: value: float * offset: float * ?noAssert: bool -> float
    abstract writeDoubleBE: value: float * offset: float * ?noAssert: bool -> float
    abstract fill: value: obj option * ?offset: float * ?``end``: float -> NodeBuffer
    abstract indexOf: value: U3<string, float, Buffer> * ?byteOffset: float * ?encoding: string -> float
    abstract lastIndexOf: value: U3<string, float, Buffer> * ?byteOffset: float * ?encoding: string -> float
    abstract entries: unit -> IterableIterator<float * float>
    abstract includes: value: U3<string, float, Buffer> * ?byteOffset: float * ?encoding: string -> bool
    abstract keys: unit -> IterableIterator<float>
    abstract values: unit -> IterableIterator<float>

module Buffer =

    type [<AllowNullLiteral>] IExports =
        abstract BuffType: obj
        abstract SlowBuffType: obj
    let INSPECT_MAX_BYTES: float = jsNative

module Querystring =

    type [<AllowNullLiteral>] IExports =
        abstract stringify: obj: 'T * ?sep: string * ?eq: string * ?options: StringifyOptions -> string
        abstract parse: str: string * ?sep: string * ?eq: string * ?options: ParseOptions -> ParsedUrlQuery
        abstract parse: str: string * ?sep: string * ?eq: string * ?options: ParseOptions -> 'T
        abstract escape: str: string -> string
        abstract unescape: str: string -> string

    type [<AllowNullLiteral>] StringifyOptions =
        abstract encodeURIComponent: Function option with get, set

    type [<AllowNullLiteral>] ParseOptions =
        abstract maxKeys: float option with get, set
        abstract decodeURIComponent: Function option with get, set

    type [<AllowNullLiteral>] ParsedUrlQuery =
        [<Emit "$0[$1]{{=$2}}">] abstract Item: key: string -> U2<string, ResizeArray<string>> option with get, set

module Events =

    type [<AllowNullLiteral>] IExports =
        abstract ``internal``: internalStatic
        abstract EventEmitter: EventEmitterStatic

    type [<AllowNullLiteral>] ``internal`` =
        inherit NodeJS.EventEmitter

    type [<AllowNullLiteral>] internalStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> ``internal``

    type [<AllowNullLiteral>] EventEmitter =
        inherit ``internal``
        abstract defaultMaxListeners: float with get, set
        abstract addListener: ``event``: U2<string, Symbol> * listener: (ResizeArray<obj option> -> unit) -> EventEmitter
        abstract on: ``event``: U2<string, Symbol> * listener: (ResizeArray<obj option> -> unit) -> EventEmitter
        abstract once: ``event``: U2<string, Symbol> * listener: (ResizeArray<obj option> -> unit) -> EventEmitter
        abstract prependListener: ``event``: U2<string, Symbol> * listener: (ResizeArray<obj option> -> unit) -> EventEmitter
        abstract prependOnceListener: ``event``: U2<string, Symbol> * listener: (ResizeArray<obj option> -> unit) -> EventEmitter
        abstract removeListener: ``event``: U2<string, Symbol> * listener: (ResizeArray<obj option> -> unit) -> EventEmitter
        abstract removeAllListeners: ?``event``: U2<string, Symbol> -> EventEmitter
        abstract setMaxListeners: n: float -> EventEmitter
        abstract getMaxListeners: unit -> float
        abstract listeners: ``event``: U2<string, Symbol> -> ResizeArray<Function>
        abstract emit: ``event``: U2<string, Symbol> * [<ParamArray>] args: ResizeArray<obj option> -> bool
        abstract eventNames: unit -> Array<U2<string, Symbol>>
        abstract listenerCount: ``type``: U2<string, Symbol> -> float

    type [<AllowNullLiteral>] EventEmitterStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> EventEmitter
        abstract listenerCount: emitter: EventEmitter * ``event``: U2<string, Symbol> -> float

module Http =
    type URL = Url.URL

    type [<AllowNullLiteral>] IExports =
        abstract Server: ServerStatic
        abstract ServerRequest: ServerRequestStatic
        abstract OutgoingMessage: OutgoingMessageStatic
        abstract ServerResponse: ServerResponseStatic
        abstract ClientRequest: ClientRequestStatic
        abstract IncomingMessage: IncomingMessageStatic
        abstract ClientResponse: ClientResponseStatic
        abstract Agent: AgentStatic
        abstract createServer: ?requestListener: (IncomingMessage -> ServerResponse -> unit) -> Server
        abstract createClient: ?port: float * ?host: string -> obj option
        abstract request: options: U3<RequestOptions, string, URL> * ?callback: (IncomingMessage -> unit) -> ClientRequest
        abstract get: options: U3<RequestOptions, string, URL> * ?callback: (IncomingMessage -> unit) -> ClientRequest

    type [<AllowNullLiteral>] IncomingHttpHeaders =
        abstract accept: string option with get, set
        abstract ``access-control-allow-origin``: string option with get, set
        abstract ``access-control-allow-credentials``: string option with get, set
        abstract ``access-control-expose-headers``: string option with get, set
        abstract ``access-control-max-age``: string option with get, set
        abstract ``access-control-allow-methods``: string option with get, set
        abstract ``access-control-allow-headers``: string option with get, set
        abstract ``accept-patch``: string option with get, set
        abstract ``accept-ranges``: string option with get, set
        abstract authorization: string option with get, set
        abstract age: string option with get, set
        abstract allow: string option with get, set
        abstract ``alt-svc``: string option with get, set
        abstract ``cache-control``: string option with get, set
        abstract connection: string option with get, set
        abstract ``content-disposition``: string option with get, set
        abstract ``content-encoding``: string option with get, set
        abstract ``content-language``: string option with get, set
        abstract ``content-length``: string option with get, set
        abstract ``content-location``: string option with get, set
        abstract ``content-range``: string option with get, set
        abstract ``content-type``: string option with get, set
        abstract date: string option with get, set
        abstract expires: string option with get, set
        abstract host: string option with get, set
        abstract ``last-modified``: string option with get, set
        abstract location: string option with get, set
        abstract pragma: string option with get, set
        abstract ``proxy-authenticate``: string option with get, set
        abstract ``public-key-pins``: string option with get, set
        abstract ``retry-after``: string option with get, set
        abstract ``set-cookie``: ResizeArray<string> option with get, set
        abstract ``strict-transport-security``: string option with get, set
        abstract trailer: string option with get, set
        abstract ``transfer-encoding``: string option with get, set
        abstract tk: string option with get, set
        abstract upgrade: string option with get, set
        abstract vary: string option with get, set
        abstract via: string option with get, set
        abstract warning: string option with get, set
        abstract ``www-authenticate``: string option with get, set
        [<Emit "$0[$1]{{=$2}}">] abstract Item: header: string -> U2<string, ResizeArray<string>> option with get, set

    type [<AllowNullLiteral>] OutgoingHttpHeaders =
        [<Emit "$0[$1]{{=$2}}">] abstract Item: header: string -> U3<float, string, ResizeArray<string>> option with get, set

    type [<AllowNullLiteral>] ClientRequestArgs =
        abstract protocol: string option with get, set
        abstract host: string option with get, set
        abstract hostname: string option with get, set
        abstract family: float option with get, set
        abstract port: U2<float, string> option with get, set
        abstract defaultPort: U2<float, string> option with get, set
        abstract localAddress: string option with get, set
        abstract socketPath: string option with get, set
        abstract ``method``: string option with get, set
        abstract path: string option with get, set
        abstract headers: OutgoingHttpHeaders option with get, set
        abstract auth: string option with get, set
        abstract agent: U2<Agent, bool> option with get, set
        abstract _defaultAgent: Agent option with get, set
        abstract timeout: float option with get, set
        abstract createConnection: (ClientRequestArgs -> (Error -> Net.Socket -> unit) -> Net.Socket) option with get, set

    type [<AllowNullLiteral>] Server =
        inherit Net.Server
        abstract setTimeout: ?msecs: float * ?callback: (unit -> unit) -> Server
        abstract setTimeout: callback: (unit -> unit) -> Server
        abstract maxHeadersCount: float with get, set
        abstract timeout: float with get, set
        abstract keepAliveTimeout: float with get, set

    type [<AllowNullLiteral>] ServerStatic =
        [<Emit "new $0($1...)">] abstract Create: ?requestListener: (IncomingMessage -> ServerResponse -> unit) -> Server

    type [<AllowNullLiteral>] ServerRequest =
        inherit IncomingMessage
        abstract connection: Net.Socket with get, set

    type [<AllowNullLiteral>] ServerRequestStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> ServerRequest

    type [<AllowNullLiteral>] OutgoingMessage =
        inherit Stream.Writable
        abstract upgrading: bool with get, set
        abstract chunkedEncoding: bool with get, set
        abstract shouldKeepAlive: bool with get, set
        abstract useChunkedEncodingByDefault: bool with get, set
        abstract sendDate: bool with get, set
        abstract finished: bool with get, set
        abstract headersSent: bool with get, set
        abstract connection: Net.Socket with get, set
        abstract setTimeout: msecs: float * ?callback: (unit -> unit) -> OutgoingMessage
        abstract destroy: error: Error -> unit
        abstract setHeader: name: string * value: U3<float, string, ResizeArray<string>> -> unit
        abstract getHeader: name: string -> U3<float, string, ResizeArray<string>> option
        abstract getHeaders: unit -> OutgoingHttpHeaders
        abstract getHeaderNames: unit -> ResizeArray<string>
        abstract hasHeader: name: string -> bool
        abstract removeHeader: name: string -> unit
        abstract addTrailers: headers: U2<OutgoingHttpHeaders, Array<string * string>> -> unit
        abstract flushHeaders: unit -> unit

    type [<AllowNullLiteral>] OutgoingMessageStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> OutgoingMessage

    type [<AllowNullLiteral>] ServerResponse =
        inherit OutgoingMessage
        abstract statusCode: float with get, set
        abstract statusMessage: string with get, set
        abstract assignSocket: socket: Net.Socket -> unit
        abstract detachSocket: socket: Net.Socket -> unit
        abstract writeContinue: ?callback: (unit -> unit) -> unit
        abstract writeHead: statusCode: float * ?reasonPhrase: string * ?headers: OutgoingHttpHeaders -> unit
        abstract writeHead: statusCode: float * ?headers: OutgoingHttpHeaders -> unit

    type [<AllowNullLiteral>] ServerResponseStatic =
        [<Emit "new $0($1...)">] abstract Create: req: IncomingMessage -> ServerResponse

    type [<AllowNullLiteral>] ClientRequest =
        inherit OutgoingMessage
        abstract connection: Net.Socket with get, set
        abstract socket: Net.Socket with get, set
        abstract aborted: float with get, set
        abstract abort: unit -> unit
        abstract onSocket: socket: Net.Socket -> unit
        abstract setTimeout: timeout: float * ?callback: (unit -> unit) -> ClientRequest
        abstract setNoDelay: ?noDelay: bool -> unit
        abstract setSocketKeepAlive: ?enable: bool * ?initialDelay: float -> unit

    type [<AllowNullLiteral>] ClientRequestStatic =
        [<Emit "new $0($1...)">] abstract Create: url: U3<string, URL, ClientRequestArgs> * ?cb: (IncomingMessage -> unit) -> ClientRequest

    type [<AllowNullLiteral>] IncomingMessage =
        inherit Stream.Readable
        abstract httpVersion: string with get, set
        abstract httpVersionMajor: float with get, set
        abstract httpVersionMinor: float with get, set
        abstract connection: Net.Socket with get, set
        abstract headers: IncomingHttpHeaders with get, set
        abstract rawHeaders: ResizeArray<string> with get, set
        abstract trailers: obj with get, set
        abstract rawTrailers: ResizeArray<string> with get, set
        abstract setTimeout: msecs: float * callback: (unit -> unit) -> IncomingMessage
        /// Only valid for request obtained from http.Server.
        abstract ``method``: string option with get, set
        /// Only valid for request obtained from http.Server.
        abstract url: string option with get, set
        /// Only valid for response obtained from http.ClientRequest.
        abstract statusCode: float option with get, set
        /// Only valid for response obtained from http.ClientRequest.
        abstract statusMessage: string option with get, set
        abstract socket: Net.Socket with get, set
        abstract destroy: ?error: Error -> unit

    type [<AllowNullLiteral>] IncomingMessageStatic =
        [<Emit "new $0($1...)">] abstract Create: socket: Net.Socket -> IncomingMessage

    type [<AllowNullLiteral>] ClientResponse =
        inherit IncomingMessage

    type [<AllowNullLiteral>] ClientResponseStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> ClientResponse

    type [<AllowNullLiteral>] AgentOptions =
        /// Keep sockets around in a pool to be used by other requests in the future. Default = false
        abstract keepAlive: bool option with get, set
        /// When using HTTP KeepAlive, how often to send TCP KeepAlive packets over sockets being kept alive. Default = 1000.
        /// Only relevant if keepAlive is set to true.
        abstract keepAliveMsecs: float option with get, set
        /// Maximum number of sockets to allow per host. Default for Node 0.10 is 5, default for Node 0.12 is Infinity
        abstract maxSockets: float option with get, set
        /// Maximum number of sockets to leave open in a free state. Only relevant if keepAlive is set to true. Default = 256.
        abstract maxFreeSockets: float option with get, set

    type [<AllowNullLiteral>] Agent =
        abstract maxFreeSockets: float with get, set
        abstract maxSockets: float with get, set
        abstract sockets: obj option with get, set
        abstract requests: obj option with get, set
        /// Destroy any sockets that are currently in use by the agent.
        /// It is usually not necessary to do this. However, if you are using an agent with KeepAlive enabled,
        /// then it is best to explicitly shut down the agent when you know that it will no longer be used. Otherwise,
        /// sockets may hang open for quite a long time before the server terminates them.
        abstract destroy: unit -> unit

    type [<AllowNullLiteral>] AgentStatic =
        [<Emit "new $0($1...)">] abstract Create: ?opts: AgentOptions -> Agent
    let METHODS: ResizeArray<string> = jsNative
    let STATUS_CODES: obj = jsNative

    type [<AllowNullLiteral>] RequestOptions =
        inherit ClientRequestArgs
    let globalAgent: Agent = jsNative

module Cluster =
    module Child = Child_process

    type [<AllowNullLiteral>] IExports =
        abstract Worker: WorkerStatic
        abstract disconnect: ?callback: Function -> unit
        abstract fork: ?env: obj option -> Worker
        abstract setupMaster: ?settings: ClusterSettings -> unit
        /// events.EventEmitter
        ///    1. disconnect
        ///    2. exit
        ///    3. fork
        ///    4. listening
        ///    5. message
        ///    6. online
        ///    7. setup
        abstract addListener: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> Cluster
        [<Emit "$0.addListener('disconnect',$1)">] abstract addListener_disconnect: listener: (Worker -> unit) -> Cluster
        [<Emit "$0.addListener('exit',$1)">] abstract addListener_exit: listener: (Worker -> float -> string -> unit) -> Cluster
        [<Emit "$0.addListener('fork',$1)">] abstract addListener_fork: listener: (Worker -> unit) -> Cluster
        [<Emit "$0.addListener('listening',$1)">] abstract addListener_listening: listener: (Worker -> Address -> unit) -> Cluster
        [<Emit "$0.addListener('message',$1)">] abstract addListener_message: listener: (Worker -> obj option -> U2<Net.Socket, Net.Server> -> unit) -> Cluster
        [<Emit "$0.addListener('online',$1)">] abstract addListener_online: listener: (Worker -> unit) -> Cluster
        [<Emit "$0.addListener('setup',$1)">] abstract addListener_setup: listener: (obj option -> unit) -> Cluster
        abstract emit: ``event``: U2<string, Symbol> * [<ParamArray>] args: ResizeArray<obj option> -> bool
        [<Emit "$0.emit('disconnect',$1)">] abstract emit_disconnect: worker: Worker -> bool
        [<Emit "$0.emit('exit',$1,$2,$3)">] abstract emit_exit: worker: Worker * code: float * signal: string -> bool
        [<Emit "$0.emit('fork',$1)">] abstract emit_fork: worker: Worker -> bool
        [<Emit "$0.emit('listening',$1,$2)">] abstract emit_listening: worker: Worker * address: Address -> bool
        [<Emit "$0.emit('message',$1,$2,$3)">] abstract emit_message: worker: Worker * message: obj option * handle: U2<Net.Socket, Net.Server> -> bool
        [<Emit "$0.emit('online',$1)">] abstract emit_online: worker: Worker -> bool
        [<Emit "$0.emit('setup',$1)">] abstract emit_setup: settings: obj option -> bool
        abstract on: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> Cluster
        [<Emit "$0.on('disconnect',$1)">] abstract on_disconnect: listener: (Worker -> unit) -> Cluster
        [<Emit "$0.on('exit',$1)">] abstract on_exit: listener: (Worker -> float -> string -> unit) -> Cluster
        [<Emit "$0.on('fork',$1)">] abstract on_fork: listener: (Worker -> unit) -> Cluster
        [<Emit "$0.on('listening',$1)">] abstract on_listening: listener: (Worker -> Address -> unit) -> Cluster
        [<Emit "$0.on('message',$1)">] abstract on_message: listener: (Worker -> obj option -> U2<Net.Socket, Net.Server> -> unit) -> Cluster
        [<Emit "$0.on('online',$1)">] abstract on_online: listener: (Worker -> unit) -> Cluster
        [<Emit "$0.on('setup',$1)">] abstract on_setup: listener: (obj option -> unit) -> Cluster
        abstract once: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> Cluster
        [<Emit "$0.once('disconnect',$1)">] abstract once_disconnect: listener: (Worker -> unit) -> Cluster
        [<Emit "$0.once('exit',$1)">] abstract once_exit: listener: (Worker -> float -> string -> unit) -> Cluster
        [<Emit "$0.once('fork',$1)">] abstract once_fork: listener: (Worker -> unit) -> Cluster
        [<Emit "$0.once('listening',$1)">] abstract once_listening: listener: (Worker -> Address -> unit) -> Cluster
        [<Emit "$0.once('message',$1)">] abstract once_message: listener: (Worker -> obj option -> U2<Net.Socket, Net.Server> -> unit) -> Cluster
        [<Emit "$0.once('online',$1)">] abstract once_online: listener: (Worker -> unit) -> Cluster
        [<Emit "$0.once('setup',$1)">] abstract once_setup: listener: (obj option -> unit) -> Cluster
        abstract removeListener: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> Cluster
        abstract removeAllListeners: ?``event``: string -> Cluster
        abstract setMaxListeners: n: float -> Cluster
        abstract getMaxListeners: unit -> float
        abstract listeners: ``event``: string -> ResizeArray<Function>
        abstract listenerCount: ``type``: string -> float
        abstract prependListener: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> Cluster
        [<Emit "$0.prependListener('disconnect',$1)">] abstract prependListener_disconnect: listener: (Worker -> unit) -> Cluster
        [<Emit "$0.prependListener('exit',$1)">] abstract prependListener_exit: listener: (Worker -> float -> string -> unit) -> Cluster
        [<Emit "$0.prependListener('fork',$1)">] abstract prependListener_fork: listener: (Worker -> unit) -> Cluster
        [<Emit "$0.prependListener('listening',$1)">] abstract prependListener_listening: listener: (Worker -> Address -> unit) -> Cluster
        [<Emit "$0.prependListener('message',$1)">] abstract prependListener_message: listener: (Worker -> obj option -> U2<Net.Socket, Net.Server> -> unit) -> Cluster
        [<Emit "$0.prependListener('online',$1)">] abstract prependListener_online: listener: (Worker -> unit) -> Cluster
        [<Emit "$0.prependListener('setup',$1)">] abstract prependListener_setup: listener: (obj option -> unit) -> Cluster
        abstract prependOnceListener: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> Cluster
        [<Emit "$0.prependOnceListener('disconnect',$1)">] abstract prependOnceListener_disconnect: listener: (Worker -> unit) -> Cluster
        [<Emit "$0.prependOnceListener('exit',$1)">] abstract prependOnceListener_exit: listener: (Worker -> float -> string -> unit) -> Cluster
        [<Emit "$0.prependOnceListener('fork',$1)">] abstract prependOnceListener_fork: listener: (Worker -> unit) -> Cluster
        [<Emit "$0.prependOnceListener('listening',$1)">] abstract prependOnceListener_listening: listener: (Worker -> Address -> unit) -> Cluster
        [<Emit "$0.prependOnceListener('message',$1)">] abstract prependOnceListener_message: listener: (Worker -> obj option -> U2<Net.Socket, Net.Server> -> unit) -> Cluster
        [<Emit "$0.prependOnceListener('online',$1)">] abstract prependOnceListener_online: listener: (Worker -> unit) -> Cluster
        [<Emit "$0.prependOnceListener('setup',$1)">] abstract prependOnceListener_setup: listener: (obj option -> unit) -> Cluster
        abstract eventNames: unit -> ResizeArray<string>

    type [<AllowNullLiteral>] ClusterSettings =
        abstract execArgv: ResizeArray<string> option with get, set
        abstract exec: string option with get, set
        abstract args: ResizeArray<string> option with get, set
        abstract silent: bool option with get, set
        abstract stdio: ResizeArray<obj option> option with get, set
        abstract uid: float option with get, set
        abstract gid: float option with get, set
        abstract inspectPort: U2<float, (unit -> float)> option with get, set

    type [<AllowNullLiteral>] Address =
        abstract address: string with get, set
        abstract port: float with get, set
        abstract addressType: U3<float, string, string> with get, set

    type [<AllowNullLiteral>] Worker =
        inherit Events.EventEmitter
        abstract id: float with get, set
        abstract ``process``: Child.ChildProcess with get, set
        abstract suicide: bool with get, set
        abstract send: message: obj option * ?sendHandle: obj option * ?callback: (Error -> unit) -> bool
        abstract kill: ?signal: string -> unit
        abstract destroy: ?signal: string -> unit
        abstract disconnect: unit -> unit
        abstract isConnected: unit -> bool
        abstract isDead: unit -> bool
        abstract exitedAfterDisconnect: bool with get, set
        /// events.EventEmitter
        ///    1. disconnect
        ///    2. error
        ///    3. exit
        ///    4. listening
        ///    5. message
        ///    6. online
        abstract addListener: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> Worker
        [<Emit "$0.addListener('disconnect',$1)">] abstract addListener_disconnect: listener: (unit -> unit) -> Worker
        [<Emit "$0.addListener('error',$1)">] abstract addListener_error: listener: (Error -> unit) -> Worker
        [<Emit "$0.addListener('exit',$1)">] abstract addListener_exit: listener: (float -> string -> unit) -> Worker
        [<Emit "$0.addListener('listening',$1)">] abstract addListener_listening: listener: (Address -> unit) -> Worker
        [<Emit "$0.addListener('message',$1)">] abstract addListener_message: listener: (obj option -> U2<Net.Socket, Net.Server> -> unit) -> Worker
        [<Emit "$0.addListener('online',$1)">] abstract addListener_online: listener: (unit -> unit) -> Worker
        abstract emit: ``event``: U2<string, Symbol> * [<ParamArray>] args: ResizeArray<obj option> -> bool
        [<Emit "$0.emit('disconnect')">] abstract emit_disconnect: unit -> bool
        [<Emit "$0.emit('error',$1)">] abstract emit_error: error: Error -> bool
        [<Emit "$0.emit('exit',$1,$2)">] abstract emit_exit: code: float * signal: string -> bool
        [<Emit "$0.emit('listening',$1)">] abstract emit_listening: address: Address -> bool
        [<Emit "$0.emit('message',$1,$2)">] abstract emit_message: message: obj option * handle: U2<Net.Socket, Net.Server> -> bool
        [<Emit "$0.emit('online')">] abstract emit_online: unit -> bool
        abstract on: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> Worker
        [<Emit "$0.on('disconnect',$1)">] abstract on_disconnect: listener: (unit -> unit) -> Worker
        [<Emit "$0.on('error',$1)">] abstract on_error: listener: (Error -> unit) -> Worker
        [<Emit "$0.on('exit',$1)">] abstract on_exit: listener: (float -> string -> unit) -> Worker
        [<Emit "$0.on('listening',$1)">] abstract on_listening: listener: (Address -> unit) -> Worker
        [<Emit "$0.on('message',$1)">] abstract on_message: listener: (obj option -> U2<Net.Socket, Net.Server> -> unit) -> Worker
        [<Emit "$0.on('online',$1)">] abstract on_online: listener: (unit -> unit) -> Worker
        abstract once: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> Worker
        [<Emit "$0.once('disconnect',$1)">] abstract once_disconnect: listener: (unit -> unit) -> Worker
        [<Emit "$0.once('error',$1)">] abstract once_error: listener: (Error -> unit) -> Worker
        [<Emit "$0.once('exit',$1)">] abstract once_exit: listener: (float -> string -> unit) -> Worker
        [<Emit "$0.once('listening',$1)">] abstract once_listening: listener: (Address -> unit) -> Worker
        [<Emit "$0.once('message',$1)">] abstract once_message: listener: (obj option -> U2<Net.Socket, Net.Server> -> unit) -> Worker
        [<Emit "$0.once('online',$1)">] abstract once_online: listener: (unit -> unit) -> Worker
        abstract prependListener: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> Worker
        [<Emit "$0.prependListener('disconnect',$1)">] abstract prependListener_disconnect: listener: (unit -> unit) -> Worker
        [<Emit "$0.prependListener('error',$1)">] abstract prependListener_error: listener: (Error -> unit) -> Worker
        [<Emit "$0.prependListener('exit',$1)">] abstract prependListener_exit: listener: (float -> string -> unit) -> Worker
        [<Emit "$0.prependListener('listening',$1)">] abstract prependListener_listening: listener: (Address -> unit) -> Worker
        [<Emit "$0.prependListener('message',$1)">] abstract prependListener_message: listener: (obj option -> U2<Net.Socket, Net.Server> -> unit) -> Worker
        [<Emit "$0.prependListener('online',$1)">] abstract prependListener_online: listener: (unit -> unit) -> Worker
        abstract prependOnceListener: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> Worker
        [<Emit "$0.prependOnceListener('disconnect',$1)">] abstract prependOnceListener_disconnect: listener: (unit -> unit) -> Worker
        [<Emit "$0.prependOnceListener('error',$1)">] abstract prependOnceListener_error: listener: (Error -> unit) -> Worker
        [<Emit "$0.prependOnceListener('exit',$1)">] abstract prependOnceListener_exit: listener: (float -> string -> unit) -> Worker
        [<Emit "$0.prependOnceListener('listening',$1)">] abstract prependOnceListener_listening: listener: (Address -> unit) -> Worker
        [<Emit "$0.prependOnceListener('message',$1)">] abstract prependOnceListener_message: listener: (obj option -> U2<Net.Socket, Net.Server> -> unit) -> Worker
        [<Emit "$0.prependOnceListener('online',$1)">] abstract prependOnceListener_online: listener: (unit -> unit) -> Worker

    type [<AllowNullLiteral>] WorkerStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> Worker

    type [<AllowNullLiteral>] Cluster =
        inherit Events.EventEmitter
        abstract Worker: Worker with get, set
        abstract disconnect: ?callback: Function -> unit
        abstract fork: ?env: obj option -> Worker
        abstract isMaster: bool with get, set
        abstract isWorker: bool with get, set
        abstract settings: ClusterSettings with get, set
        abstract setupMaster: ?settings: ClusterSettings -> unit
        abstract worker: Worker option with get, set
        abstract workers: obj option with get, set
        /// events.EventEmitter
        ///    1. disconnect
        ///    2. exit
        ///    3. fork
        ///    4. listening
        ///    5. message
        ///    6. online
        ///    7. setup
        abstract addListener: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> Cluster
        [<Emit "$0.addListener('disconnect',$1)">] abstract addListener_disconnect: listener: (Worker -> unit) -> Cluster
        [<Emit "$0.addListener('exit',$1)">] abstract addListener_exit: listener: (Worker -> float -> string -> unit) -> Cluster
        [<Emit "$0.addListener('fork',$1)">] abstract addListener_fork: listener: (Worker -> unit) -> Cluster
        [<Emit "$0.addListener('listening',$1)">] abstract addListener_listening: listener: (Worker -> Address -> unit) -> Cluster
        [<Emit "$0.addListener('message',$1)">] abstract addListener_message: listener: (Worker -> obj option -> U2<Net.Socket, Net.Server> -> unit) -> Cluster
        [<Emit "$0.addListener('online',$1)">] abstract addListener_online: listener: (Worker -> unit) -> Cluster
        [<Emit "$0.addListener('setup',$1)">] abstract addListener_setup: listener: (obj option -> unit) -> Cluster
        abstract emit: ``event``: U2<string, Symbol> * [<ParamArray>] args: ResizeArray<obj option> -> bool
        [<Emit "$0.emit('disconnect',$1)">] abstract emit_disconnect: worker: Worker -> bool
        [<Emit "$0.emit('exit',$1,$2,$3)">] abstract emit_exit: worker: Worker * code: float * signal: string -> bool
        [<Emit "$0.emit('fork',$1)">] abstract emit_fork: worker: Worker -> bool
        [<Emit "$0.emit('listening',$1,$2)">] abstract emit_listening: worker: Worker * address: Address -> bool
        [<Emit "$0.emit('message',$1,$2,$3)">] abstract emit_message: worker: Worker * message: obj option * handle: U2<Net.Socket, Net.Server> -> bool
        [<Emit "$0.emit('online',$1)">] abstract emit_online: worker: Worker -> bool
        [<Emit "$0.emit('setup',$1)">] abstract emit_setup: settings: obj option -> bool
        abstract on: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> Cluster
        [<Emit "$0.on('disconnect',$1)">] abstract on_disconnect: listener: (Worker -> unit) -> Cluster
        [<Emit "$0.on('exit',$1)">] abstract on_exit: listener: (Worker -> float -> string -> unit) -> Cluster
        [<Emit "$0.on('fork',$1)">] abstract on_fork: listener: (Worker -> unit) -> Cluster
        [<Emit "$0.on('listening',$1)">] abstract on_listening: listener: (Worker -> Address -> unit) -> Cluster
        [<Emit "$0.on('message',$1)">] abstract on_message: listener: (Worker -> obj option -> U2<Net.Socket, Net.Server> -> unit) -> Cluster
        [<Emit "$0.on('online',$1)">] abstract on_online: listener: (Worker -> unit) -> Cluster
        [<Emit "$0.on('setup',$1)">] abstract on_setup: listener: (obj option -> unit) -> Cluster
        abstract once: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> Cluster
        [<Emit "$0.once('disconnect',$1)">] abstract once_disconnect: listener: (Worker -> unit) -> Cluster
        [<Emit "$0.once('exit',$1)">] abstract once_exit: listener: (Worker -> float -> string -> unit) -> Cluster
        [<Emit "$0.once('fork',$1)">] abstract once_fork: listener: (Worker -> unit) -> Cluster
        [<Emit "$0.once('listening',$1)">] abstract once_listening: listener: (Worker -> Address -> unit) -> Cluster
        [<Emit "$0.once('message',$1)">] abstract once_message: listener: (Worker -> obj option -> U2<Net.Socket, Net.Server> -> unit) -> Cluster
        [<Emit "$0.once('online',$1)">] abstract once_online: listener: (Worker -> unit) -> Cluster
        [<Emit "$0.once('setup',$1)">] abstract once_setup: listener: (obj option -> unit) -> Cluster
        abstract prependListener: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> Cluster
        [<Emit "$0.prependListener('disconnect',$1)">] abstract prependListener_disconnect: listener: (Worker -> unit) -> Cluster
        [<Emit "$0.prependListener('exit',$1)">] abstract prependListener_exit: listener: (Worker -> float -> string -> unit) -> Cluster
        [<Emit "$0.prependListener('fork',$1)">] abstract prependListener_fork: listener: (Worker -> unit) -> Cluster
        [<Emit "$0.prependListener('listening',$1)">] abstract prependListener_listening: listener: (Worker -> Address -> unit) -> Cluster
        [<Emit "$0.prependListener('message',$1)">] abstract prependListener_message: listener: (Worker -> obj option -> U2<Net.Socket, Net.Server> -> unit) -> Cluster
        [<Emit "$0.prependListener('online',$1)">] abstract prependListener_online: listener: (Worker -> unit) -> Cluster
        [<Emit "$0.prependListener('setup',$1)">] abstract prependListener_setup: listener: (obj option -> unit) -> Cluster
        abstract prependOnceListener: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> Cluster
        [<Emit "$0.prependOnceListener('disconnect',$1)">] abstract prependOnceListener_disconnect: listener: (Worker -> unit) -> Cluster
        [<Emit "$0.prependOnceListener('exit',$1)">] abstract prependOnceListener_exit: listener: (Worker -> float -> string -> unit) -> Cluster
        [<Emit "$0.prependOnceListener('fork',$1)">] abstract prependOnceListener_fork: listener: (Worker -> unit) -> Cluster
        [<Emit "$0.prependOnceListener('listening',$1)">] abstract prependOnceListener_listening: listener: (Worker -> Address -> unit) -> Cluster
        [<Emit "$0.prependOnceListener('message',$1)">] abstract prependOnceListener_message: listener: (Worker -> obj option -> U2<Net.Socket, Net.Server> -> unit) -> Cluster
        [<Emit "$0.prependOnceListener('online',$1)">] abstract prependOnceListener_online: listener: (Worker -> unit) -> Cluster
        [<Emit "$0.prependOnceListener('setup',$1)">] abstract prependOnceListener_setup: listener: (obj option -> unit) -> Cluster
    let isMaster: bool = jsNative
    let isWorker: bool = jsNative
    let settings: ClusterSettings = jsNative
    let worker: Worker = jsNative
    let workers: obj = jsNative

module Zlib =

    type [<AllowNullLiteral>] IExports =
        abstract createGzip: ?options: ZlibOptions -> Gzip
        abstract createGunzip: ?options: ZlibOptions -> Gunzip
        abstract createDeflate: ?options: ZlibOptions -> Deflate
        abstract createInflate: ?options: ZlibOptions -> Inflate
        abstract createDeflateRaw: ?options: ZlibOptions -> DeflateRaw
        abstract createInflateRaw: ?options: ZlibOptions -> InflateRaw
        abstract createUnzip: ?options: ZlibOptions -> Unzip
        abstract deflate: buf: InputType * callback: (Error option -> Buffer -> unit) -> unit
        abstract deflate: buf: InputType * options: ZlibOptions * callback: (Error option -> Buffer -> unit) -> unit
        abstract deflateSync: buf: InputType * ?options: ZlibOptions -> Buffer
        abstract deflateRaw: buf: InputType * callback: (Error option -> Buffer -> unit) -> unit
        abstract deflateRaw: buf: InputType * options: ZlibOptions * callback: (Error option -> Buffer -> unit) -> unit
        abstract deflateRawSync: buf: InputType * ?options: ZlibOptions -> Buffer
        abstract gzip: buf: InputType * callback: (Error option -> Buffer -> unit) -> unit
        abstract gzip: buf: InputType * options: ZlibOptions * callback: (Error option -> Buffer -> unit) -> unit
        abstract gzipSync: buf: InputType * ?options: ZlibOptions -> Buffer
        abstract gunzip: buf: InputType * callback: (Error option -> Buffer -> unit) -> unit
        abstract gunzip: buf: InputType * options: ZlibOptions * callback: (Error option -> Buffer -> unit) -> unit
        abstract gunzipSync: buf: InputType * ?options: ZlibOptions -> Buffer
        abstract inflate: buf: InputType * callback: (Error option -> Buffer -> unit) -> unit
        abstract inflate: buf: InputType * options: ZlibOptions * callback: (Error option -> Buffer -> unit) -> unit
        abstract inflateSync: buf: InputType * ?options: ZlibOptions -> Buffer
        abstract inflateRaw: buf: InputType * callback: (Error option -> Buffer -> unit) -> unit
        abstract inflateRaw: buf: InputType * options: ZlibOptions * callback: (Error option -> Buffer -> unit) -> unit
        abstract inflateRawSync: buf: InputType * ?options: ZlibOptions -> Buffer
        abstract unzip: buf: InputType * callback: (Error option -> Buffer -> unit) -> unit
        abstract unzip: buf: InputType * options: ZlibOptions * callback: (Error option -> Buffer -> unit) -> unit
        abstract unzipSync: buf: InputType * ?options: ZlibOptions -> Buffer

    type [<AllowNullLiteral>] ZlibOptions =
        abstract flush: float option with get, set
        abstract finishFlush: float option with get, set
        abstract chunkSize: float option with get, set
        abstract windowBits: float option with get, set
        abstract level: float option with get, set
        abstract memLevel: float option with get, set
        abstract strategy: float option with get, set
        abstract dictionary: obj option with get, set

    type [<AllowNullLiteral>] Zlib =
        abstract bytesRead: float
        abstract close: ?callback: (unit -> unit) -> unit
        abstract flush: ?kind: U2<float, (unit -> unit)> * ?callback: (unit -> unit) -> unit

    type [<AllowNullLiteral>] ZlibParams =
        abstract ``params``: level: float * strategy: float * callback: (unit -> unit) -> unit

    type [<AllowNullLiteral>] ZlibReset =
        abstract reset: unit -> unit

    type [<AllowNullLiteral>] Gzip =
        inherit Stream.Transform
        inherit Zlib

    type [<AllowNullLiteral>] Gunzip =
        inherit Stream.Transform
        inherit Zlib

    type [<AllowNullLiteral>] Deflate =
        inherit Stream.Transform
        inherit Zlib
        inherit ZlibReset
        inherit ZlibParams

    type [<AllowNullLiteral>] Inflate =
        inherit Stream.Transform
        inherit Zlib
        inherit ZlibReset

    type [<AllowNullLiteral>] DeflateRaw =
        inherit Stream.Transform
        inherit Zlib
        inherit ZlibReset
        inherit ZlibParams

    type [<AllowNullLiteral>] InflateRaw =
        inherit Stream.Transform
        inherit Zlib
        inherit ZlibReset

    type [<AllowNullLiteral>] Unzip =
        inherit Stream.Transform
        inherit Zlib

    type InputType =
        U3<string, Buffer, DataView>

    [<RequireQualifiedAccess; CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
    module InputType =
        let ofString v: InputType = v |> U3.Case1
        let isString (v: InputType) = match v with U3.Case1 _ -> true | _ -> false
        let asString (v: InputType) = match v with U3.Case1 o -> Some o | _ -> None
        let ofBuffer v: InputType = v |> U3.Case2
        let isBuffer (v: InputType) = match v with U3.Case2 _ -> true | _ -> false
        let asBuffer (v: InputType) = match v with U3.Case2 o -> Some o | _ -> None
        let ofDataView v: InputType = v |> U3.Case3
        let isDataView (v: InputType) = match v with U3.Case3 _ -> true | _ -> false
        let asDataView (v: InputType) = match v with U3.Case3 o -> Some o | _ -> None

    module Constants =
        let Z_NO_FLUSH: float = jsNative
        let Z_PARTIAL_FLUSH: float = jsNative
        let Z_SYNC_FLUSH: float = jsNative
        let Z_FULL_FLUSH: float = jsNative
        let Z_FINISH: float = jsNative
        let Z_BLOCK: float = jsNative
        let Z_TREES: float = jsNative
        let Z_OK: float = jsNative
        let Z_STREAM_END: float = jsNative
        let Z_NEED_DICT: float = jsNative
        let Z_ERRNO: float = jsNative
        let Z_STREAM_ERROR: float = jsNative
        let Z_DATA_ERROR: float = jsNative
        let Z_MEM_ERROR: float = jsNative
        let Z_BUF_ERROR: float = jsNative
        let Z_VERSION_ERROR: float = jsNative
        let Z_NO_COMPRESSION: float = jsNative
        let Z_BEST_SPEED: float = jsNative
        let Z_BEST_COMPRESSION: float = jsNative
        let Z_DEFAULT_COMPRESSION: float = jsNative
        let Z_FILTERED: float = jsNative
        let Z_HUFFMAN_ONLY: float = jsNative
        let Z_RLE: float = jsNative
        let Z_FIXED: float = jsNative
        let Z_DEFAULT_STRATEGY: float = jsNative
    let Z_NO_FLUSH: float = jsNative
    let Z_PARTIAL_FLUSH: float = jsNative
    let Z_SYNC_FLUSH: float = jsNative
    let Z_FULL_FLUSH: float = jsNative
    let Z_FINISH: float = jsNative
    let Z_BLOCK: float = jsNative
    let Z_TREES: float = jsNative
    let Z_OK: float = jsNative
    let Z_STREAM_END: float = jsNative
    let Z_NEED_DICT: float = jsNative
    let Z_ERRNO: float = jsNative
    let Z_STREAM_ERROR: float = jsNative
    let Z_DATA_ERROR: float = jsNative
    let Z_MEM_ERROR: float = jsNative
    let Z_BUF_ERROR: float = jsNative
    let Z_VERSION_ERROR: float = jsNative
    let Z_NO_COMPRESSION: float = jsNative
    let Z_BEST_SPEED: float = jsNative
    let Z_BEST_COMPRESSION: float = jsNative
    let Z_DEFAULT_COMPRESSION: float = jsNative
    let Z_FILTERED: float = jsNative
    let Z_HUFFMAN_ONLY: float = jsNative
    let Z_RLE: float = jsNative
    let Z_FIXED: float = jsNative
    let Z_DEFAULT_STRATEGY: float = jsNative
    let Z_BINARY: float = jsNative
    let Z_TEXT: float = jsNative
    let Z_ASCII: float = jsNative
    let Z_UNKNOWN: float = jsNative
    let Z_DEFLATED: float = jsNative

module Os =

    type [<AllowNullLiteral>] IExports =
        abstract hostname: unit -> string
        abstract loadavg: unit -> ResizeArray<float>
        abstract uptime: unit -> float
        abstract freemem: unit -> float
        abstract totalmem: unit -> float
        abstract cpus: unit -> ResizeArray<CpuInfo>
        abstract ``type``: unit -> string
        abstract release: unit -> string
        abstract networkInterfaces: unit -> obj
        abstract homedir: unit -> string
        abstract userInfo: ?options: UserInfoOptions -> obj
        abstract arch: unit -> string
        abstract platform: unit -> NodeJS.Platform
        abstract tmpdir: unit -> string
        abstract endianness: unit -> U2<string, string>

    type [<AllowNullLiteral>] UserInfoOptions =
        abstract encoding: string with get, set

    type [<AllowNullLiteral>] CpuInfo =
        abstract model: string with get, set
        abstract speed: float with get, set
        abstract times: obj with get, set

    type [<AllowNullLiteral>] NetworkInterfaceBase =
        abstract address: string with get, set
        abstract netmask: string with get, set
        abstract mac: string with get, set
        abstract ``internal``: bool with get, set

    type [<AllowNullLiteral>] NetworkInterfaceInfoIPv4 =
        inherit NetworkInterfaceBase
        abstract family: string with get, set

    type [<AllowNullLiteral>] NetworkInterfaceInfoIPv6 =
        inherit NetworkInterfaceBase
        abstract family: string with get, set
        abstract scopeid: float with get, set

    type NetworkInterfaceInfo =
        U2<NetworkInterfaceInfoIPv4, NetworkInterfaceInfoIPv6>

    [<RequireQualifiedAccess; CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
    module NetworkInterfaceInfo =
        let ofNetworkInterfaceInfoIPv4 v: NetworkInterfaceInfo = v |> U2.Case1
        let isNetworkInterfaceInfoIPv4 (v: NetworkInterfaceInfo) = match v with U2.Case1 _ -> true | _ -> false
        let asNetworkInterfaceInfoIPv4 (v: NetworkInterfaceInfo) = match v with U2.Case1 o -> Some o | _ -> None
        let ofNetworkInterfaceInfoIPv6 v: NetworkInterfaceInfo = v |> U2.Case2
        let isNetworkInterfaceInfoIPv6 (v: NetworkInterfaceInfo) = match v with U2.Case2 _ -> true | _ -> false
        let asNetworkInterfaceInfoIPv6 (v: NetworkInterfaceInfo) = match v with U2.Case2 o -> Some o | _ -> None
    let constants: obj = jsNative
    let EOL: string = jsNative

module Https =
    type URL = Url.URL

    type [<AllowNullLiteral>] IExports =
        abstract Agent: AgentStatic
        abstract Server: ServerStatic
        abstract createServer: options: ServerOptions * ?requestListener: (Http.IncomingMessage -> Http.ServerResponse -> unit) -> Server
        abstract request: options: U3<RequestOptions, string, URL> * ?callback: (Http.IncomingMessage -> unit) -> Http.ClientRequest
        abstract get: options: U3<RequestOptions, string, URL> * ?callback: (Http.IncomingMessage -> unit) -> Http.ClientRequest

    type [<AllowNullLiteral>] ServerOptions =
        interface end

    type [<StringEnum>] [<RequireQualifiedAccess>] extendedRequestKeys =
        | Pfx
        | Key
        | Passphrase
        | Cert
        | Ca
        | Ciphers
        | RejectUnauthorized
        | SecureProtocol
        | Servername

    type [<AllowNullLiteral>] RequestOptions =
        interface end

    type [<AllowNullLiteral>] AgentOptions =
        inherit Http.AgentOptions
        inherit Tls.ConnectionOptions
        abstract rejectUnauthorized: bool option with get, set
        abstract maxCachedSessions: float option with get, set

    type [<AllowNullLiteral>] Agent =
        inherit Http.Agent
        abstract options: AgentOptions with get, set

    type [<AllowNullLiteral>] AgentStatic =
        [<Emit "new $0($1...)">] abstract Create: ?options: AgentOptions -> Agent

    type [<AllowNullLiteral>] Server =
        inherit Tls.Server
        abstract setTimeout: callback: (unit -> unit) -> Server
        abstract setTimeout: ?msecs: float * ?callback: (unit -> unit) -> Server
        abstract timeout: float with get, set
        abstract keepAliveTimeout: float with get, set

    type [<AllowNullLiteral>] ServerStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> Server
    let globalAgent: Agent = jsNative

module Punycode =

    type [<AllowNullLiteral>] IExports =
        abstract decode: string: string -> string
        abstract encode: string: string -> string
        abstract toUnicode: domain: string -> string
        abstract toASCII: domain: string -> string
    let ucs2: ucs2 = jsNative

    type [<AllowNullLiteral>] ucs2 =
        abstract decode: string: string -> ResizeArray<float>
        abstract encode: codePoints: ResizeArray<float> -> string
    let version: obj option = jsNative

module Repl =

    type [<AllowNullLiteral>] IExports =
        abstract start: ?options: U2<string, ReplOptions> -> REPLServer
        abstract Recoverable: RecoverableStatic

    type [<AllowNullLiteral>] ReplOptions =
        abstract prompt: string option with get, set
        abstract input: NodeJS.ReadableStream option with get, set
        abstract output: NodeJS.WritableStream option with get, set
        abstract terminal: bool option with get, set
        abstract eval: Function option with get, set
        abstract useColors: bool option with get, set
        abstract useGlobal: bool option with get, set
        abstract ignoreUndefined: bool option with get, set
        abstract writer: Function option with get, set
        abstract completer: Function option with get, set
        abstract replMode: obj option with get, set
        abstract breakEvalOnSigint: obj option with get, set

    type [<AllowNullLiteral>] REPLServer =
        inherit Readline.ReadLine
        abstract context: obj option with get, set
        abstract inputStream: NodeJS.ReadableStream with get, set
        abstract outputStream: NodeJS.WritableStream with get, set
        abstract defineCommand: keyword: string * cmd: U2<Function, obj> -> unit
        abstract displayPrompt: ?preserveCursor: bool -> unit
        /// events.EventEmitter
        /// 1. exit
        /// 2. reset
        abstract addListener: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> REPLServer
        [<Emit "$0.addListener('exit',$1)">] abstract addListener_exit: listener: (unit -> unit) -> REPLServer
        [<Emit "$0.addListener('reset',$1)">] abstract addListener_reset: listener: (ResizeArray<obj option> -> unit) -> REPLServer
        abstract emit: ``event``: U2<string, Symbol> * [<ParamArray>] args: ResizeArray<obj option> -> bool
        [<Emit "$0.emit('exit')">] abstract emit_exit: unit -> bool
        [<Emit "$0.emit('reset',$1)">] abstract emit_reset: context: obj option -> bool
        abstract on: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> REPLServer
        [<Emit "$0.on('exit',$1)">] abstract on_exit: listener: (unit -> unit) -> REPLServer
        [<Emit "$0.on('reset',$1)">] abstract on_reset: listener: (ResizeArray<obj option> -> unit) -> REPLServer
        abstract once: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> REPLServer
        [<Emit "$0.once('exit',$1)">] abstract once_exit: listener: (unit -> unit) -> REPLServer
        [<Emit "$0.once('reset',$1)">] abstract once_reset: listener: (ResizeArray<obj option> -> unit) -> REPLServer
        abstract prependListener: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> REPLServer
        [<Emit "$0.prependListener('exit',$1)">] abstract prependListener_exit: listener: (unit -> unit) -> REPLServer
        [<Emit "$0.prependListener('reset',$1)">] abstract prependListener_reset: listener: (ResizeArray<obj option> -> unit) -> REPLServer
        abstract prependOnceListener: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> REPLServer
        [<Emit "$0.prependOnceListener('exit',$1)">] abstract prependOnceListener_exit: listener: (unit -> unit) -> REPLServer
        [<Emit "$0.prependOnceListener('reset',$1)">] abstract prependOnceListener_reset: listener: (ResizeArray<obj option> -> unit) -> REPLServer

    type [<AllowNullLiteral>] Recoverable =
        inherit SyntaxError
        abstract err: Error with get, set

    type [<AllowNullLiteral>] RecoverableStatic =
        [<Emit "new $0($1...)">] abstract Create: err: Error -> Recoverable

module Readline =

    type [<AllowNullLiteral>] IExports =
        abstract createInterface: input: NodeJS.ReadableStream * ?output: NodeJS.WritableStream * ?completer: U2<Completer, AsyncCompleter> * ?terminal: bool -> ReadLine
        abstract createInterface: options: ReadLineOptions -> ReadLine
        abstract cursorTo: stream: NodeJS.WritableStream * x: float * ?y: float -> unit
        abstract emitKeypressEvents: stream: NodeJS.ReadableStream * ?``interface``: ReadLine -> unit
        abstract moveCursor: stream: NodeJS.WritableStream * dx: U2<float, string> * dy: U2<float, string> -> unit
        abstract clearLine: stream: NodeJS.WritableStream * dir: float -> unit
        abstract clearScreenDown: stream: NodeJS.WritableStream -> unit

    type [<AllowNullLiteral>] Key =
        abstract sequence: string option with get, set
        abstract name: string option with get, set
        abstract ctrl: bool option with get, set
        abstract meta: bool option with get, set
        abstract shift: bool option with get, set

    type [<AllowNullLiteral>] ReadLine =
        inherit Events.EventEmitter
        abstract setPrompt: prompt: string -> unit
        abstract prompt: ?preserveCursor: bool -> unit
        abstract question: query: string * callback: (string -> unit) -> unit
        abstract pause: unit -> ReadLine
        abstract resume: unit -> ReadLine
        abstract close: unit -> unit
        abstract write: data: U2<string, Buffer> * ?key: Key -> unit
        /// events.EventEmitter
        /// 1. close
        /// 2. line
        /// 3. pause
        /// 4. resume
        /// 5. SIGCONT
        /// 6. SIGINT
        /// 7. SIGTSTP
        abstract addListener: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> ReadLine
        [<Emit "$0.addListener('close',$1)">] abstract addListener_close: listener: (unit -> unit) -> ReadLine
        [<Emit "$0.addListener('line',$1)">] abstract addListener_line: listener: (obj option -> unit) -> ReadLine
        [<Emit "$0.addListener('pause',$1)">] abstract addListener_pause: listener: (unit -> unit) -> ReadLine
        [<Emit "$0.addListener('resume',$1)">] abstract addListener_resume: listener: (unit -> unit) -> ReadLine
        [<Emit "$0.addListener('SIGCONT',$1)">] abstract addListener_SIGCONT: listener: (unit -> unit) -> ReadLine
        [<Emit "$0.addListener('SIGINT',$1)">] abstract addListener_SIGINT: listener: (unit -> unit) -> ReadLine
        [<Emit "$0.addListener('SIGTSTP',$1)">] abstract addListener_SIGTSTP: listener: (unit -> unit) -> ReadLine
        abstract emit: ``event``: U2<string, Symbol> * [<ParamArray>] args: ResizeArray<obj option> -> bool
        [<Emit "$0.emit('close')">] abstract emit_close: unit -> bool
        [<Emit "$0.emit('line',$1)">] abstract emit_line: input: obj option -> bool
        [<Emit "$0.emit('pause')">] abstract emit_pause: unit -> bool
        [<Emit "$0.emit('resume')">] abstract emit_resume: unit -> bool
        [<Emit "$0.emit('SIGCONT')">] abstract emit_SIGCONT: unit -> bool
        [<Emit "$0.emit('SIGINT')">] abstract emit_SIGINT: unit -> bool
        [<Emit "$0.emit('SIGTSTP')">] abstract emit_SIGTSTP: unit -> bool
        abstract on: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> ReadLine
        [<Emit "$0.on('close',$1)">] abstract on_close: listener: (unit -> unit) -> ReadLine
        [<Emit "$0.on('line',$1)">] abstract on_line: listener: (obj option -> unit) -> ReadLine
        [<Emit "$0.on('pause',$1)">] abstract on_pause: listener: (unit -> unit) -> ReadLine
        [<Emit "$0.on('resume',$1)">] abstract on_resume: listener: (unit -> unit) -> ReadLine
        [<Emit "$0.on('SIGCONT',$1)">] abstract on_SIGCONT: listener: (unit -> unit) -> ReadLine
        [<Emit "$0.on('SIGINT',$1)">] abstract on_SIGINT: listener: (unit -> unit) -> ReadLine
        [<Emit "$0.on('SIGTSTP',$1)">] abstract on_SIGTSTP: listener: (unit -> unit) -> ReadLine
        abstract once: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> ReadLine
        [<Emit "$0.once('close',$1)">] abstract once_close: listener: (unit -> unit) -> ReadLine
        [<Emit "$0.once('line',$1)">] abstract once_line: listener: (obj option -> unit) -> ReadLine
        [<Emit "$0.once('pause',$1)">] abstract once_pause: listener: (unit -> unit) -> ReadLine
        [<Emit "$0.once('resume',$1)">] abstract once_resume: listener: (unit -> unit) -> ReadLine
        [<Emit "$0.once('SIGCONT',$1)">] abstract once_SIGCONT: listener: (unit -> unit) -> ReadLine
        [<Emit "$0.once('SIGINT',$1)">] abstract once_SIGINT: listener: (unit -> unit) -> ReadLine
        [<Emit "$0.once('SIGTSTP',$1)">] abstract once_SIGTSTP: listener: (unit -> unit) -> ReadLine
        abstract prependListener: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> ReadLine
        [<Emit "$0.prependListener('close',$1)">] abstract prependListener_close: listener: (unit -> unit) -> ReadLine
        [<Emit "$0.prependListener('line',$1)">] abstract prependListener_line: listener: (obj option -> unit) -> ReadLine
        [<Emit "$0.prependListener('pause',$1)">] abstract prependListener_pause: listener: (unit -> unit) -> ReadLine
        [<Emit "$0.prependListener('resume',$1)">] abstract prependListener_resume: listener: (unit -> unit) -> ReadLine
        [<Emit "$0.prependListener('SIGCONT',$1)">] abstract prependListener_SIGCONT: listener: (unit -> unit) -> ReadLine
        [<Emit "$0.prependListener('SIGINT',$1)">] abstract prependListener_SIGINT: listener: (unit -> unit) -> ReadLine
        [<Emit "$0.prependListener('SIGTSTP',$1)">] abstract prependListener_SIGTSTP: listener: (unit -> unit) -> ReadLine
        abstract prependOnceListener: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> ReadLine
        [<Emit "$0.prependOnceListener('close',$1)">] abstract prependOnceListener_close: listener: (unit -> unit) -> ReadLine
        [<Emit "$0.prependOnceListener('line',$1)">] abstract prependOnceListener_line: listener: (obj option -> unit) -> ReadLine
        [<Emit "$0.prependOnceListener('pause',$1)">] abstract prependOnceListener_pause: listener: (unit -> unit) -> ReadLine
        [<Emit "$0.prependOnceListener('resume',$1)">] abstract prependOnceListener_resume: listener: (unit -> unit) -> ReadLine
        [<Emit "$0.prependOnceListener('SIGCONT',$1)">] abstract prependOnceListener_SIGCONT: listener: (unit -> unit) -> ReadLine
        [<Emit "$0.prependOnceListener('SIGINT',$1)">] abstract prependOnceListener_SIGINT: listener: (unit -> unit) -> ReadLine
        [<Emit "$0.prependOnceListener('SIGTSTP',$1)">] abstract prependOnceListener_SIGTSTP: listener: (unit -> unit) -> ReadLine

    type [<AllowNullLiteral>] Completer =
        [<Emit "$0($1...)">] abstract Invoke: line: string -> CompleterResult

    type [<AllowNullLiteral>] AsyncCompleter =
        [<Emit "$0($1...)">] abstract Invoke: line: string * callback: (obj option -> CompleterResult -> unit) -> obj option

    type CompleterResult =
        ResizeArray<string> * string

    type [<AllowNullLiteral>] ReadLineOptions =
        abstract input: NodeJS.ReadableStream with get, set
        abstract output: NodeJS.WritableStream option with get, set
        abstract completer: U2<Completer, AsyncCompleter> option with get, set
        abstract terminal: bool option with get, set
        abstract historySize: float option with get, set
        abstract prompt: string option with get, set
        abstract crlfDelay: float option with get, set
        abstract removeHistoryDuplicates: bool option with get, set

module Vm =

    type [<AllowNullLiteral>] IExports =
        abstract Script: ScriptStatic
        abstract createContext: ?sandbox: Context -> Context
        abstract isContext: sandbox: Context -> bool
        abstract runInContext: code: string * contextifiedSandbox: Context * ?options: U2<RunningScriptOptions, string> -> obj option
        abstract runInDebugContext: code: string -> obj option
        abstract runInNewContext: code: string * ?sandbox: Context * ?options: U2<RunningScriptOptions, string> -> obj option
        abstract runInThisContext: code: string * ?options: U2<RunningScriptOptions, string> -> obj option

    type [<AllowNullLiteral>] Context =
        interface end

    type [<AllowNullLiteral>] ScriptOptions =
        abstract filename: string option with get, set
        abstract lineOffset: float option with get, set
        abstract columnOffset: float option with get, set
        abstract displayErrors: bool option with get, set
        abstract timeout: float option with get, set
        abstract cachedData: Buffer option with get, set
        abstract produceCachedData: bool option with get, set

    type [<AllowNullLiteral>] RunningScriptOptions =
        abstract filename: string option with get, set
        abstract lineOffset: float option with get, set
        abstract columnOffset: float option with get, set
        abstract displayErrors: bool option with get, set
        abstract timeout: float option with get, set

    type [<AllowNullLiteral>] Script =
        abstract runInContext: contextifiedSandbox: Context * ?options: RunningScriptOptions -> obj option
        abstract runInNewContext: ?sandbox: Context * ?options: RunningScriptOptions -> obj option
        abstract runInThisContext: ?options: RunningScriptOptions -> obj option

    type [<AllowNullLiteral>] ScriptStatic =
        [<Emit "new $0($1...)">] abstract Create: code: string * ?options: ScriptOptions -> Script

module Child_process =
    let [<Import("exec","child_process")>] exec: Exec.IExports = jsNative
    let [<Import("execFile","child_process")>] execFile: ExecFile.IExports = jsNative

    type [<AllowNullLiteral>] IExports =
        abstract spawn: command: string * ?args: ResizeArray<string> * ?options: SpawnOptions -> ChildProcess
        abstract exec: command: string * ?callback: (Error option -> string -> string -> unit) -> ChildProcess
        abstract exec: command: string * options: obj * ?callback: (Error option -> Buffer -> Buffer -> unit) -> ChildProcess
        abstract exec: command: string * options: obj * ?callback: (Error option -> string -> string -> unit) -> ChildProcess
        abstract exec: command: string * options: obj * ?callback: (Error option -> U2<string, Buffer> -> U2<string, Buffer> -> unit) -> ChildProcess
        abstract exec: command: string * options: ExecOptions * ?callback: (Error option -> string -> string -> unit) -> ChildProcess
        abstract exec: command: string * options: obj option * ?callback: (Error option -> U2<string, Buffer> -> U2<string, Buffer> -> unit) -> ChildProcess
        abstract execFile: file: string -> ChildProcess
        abstract execFile: file: string * options: obj option -> ChildProcess
        abstract execFile: file: string * args: ResizeArray<string> option -> ChildProcess
        abstract execFile: file: string * args: ResizeArray<string> option * options: obj option -> ChildProcess
        abstract execFile: file: string * callback: (Error option -> string -> string -> unit) -> ChildProcess
        abstract execFile: file: string * args: ResizeArray<string> option * callback: (Error option -> string -> string -> unit) -> ChildProcess
        abstract execFile: file: string * options: ExecFileOptionsWithBufferEncoding * callback: (Error option -> Buffer -> Buffer -> unit) -> ChildProcess
        abstract execFile: file: string * args: ResizeArray<string> option * options: ExecFileOptionsWithBufferEncoding * callback: (Error option -> Buffer -> Buffer -> unit) -> ChildProcess
        abstract execFile: file: string * options: ExecFileOptionsWithStringEncoding * callback: (Error option -> string -> string -> unit) -> ChildProcess
        abstract execFile: file: string * args: ResizeArray<string> option * options: ExecFileOptionsWithStringEncoding * callback: (Error option -> string -> string -> unit) -> ChildProcess
        abstract execFile: file: string * options: ExecFileOptionsWithOtherEncoding * callback: (Error option -> U2<string, Buffer> -> U2<string, Buffer> -> unit) -> ChildProcess
        abstract execFile: file: string * args: ResizeArray<string> option * options: ExecFileOptionsWithOtherEncoding * callback: (Error option -> U2<string, Buffer> -> U2<string, Buffer> -> unit) -> ChildProcess
        abstract execFile: file: string * options: ExecFileOptions * callback: (Error option -> string -> string -> unit) -> ChildProcess
        abstract execFile: file: string * args: ResizeArray<string> option * options: ExecFileOptions * callback: (Error option -> string -> string -> unit) -> ChildProcess
        abstract execFile: file: string * options: obj option * callback: (Error option -> U2<string, Buffer> -> U2<string, Buffer> -> unit) option -> ChildProcess
        abstract execFile: file: string * args: ResizeArray<string> option * options: obj option * callback: (Error option -> U2<string, Buffer> -> U2<string, Buffer> -> unit) option -> ChildProcess
        abstract fork: modulePath: string * ?args: ResizeArray<string> * ?options: ForkOptions -> ChildProcess
        abstract spawnSync: command: string -> SpawnSyncReturns<Buffer>
        abstract spawnSync: command: string * ?options: SpawnSyncOptionsWithStringEncoding -> SpawnSyncReturns<string>
        abstract spawnSync: command: string * ?options: SpawnSyncOptionsWithBufferEncoding -> SpawnSyncReturns<Buffer>
        abstract spawnSync: command: string * ?options: SpawnSyncOptions -> SpawnSyncReturns<Buffer>
        abstract spawnSync: command: string * ?args: ResizeArray<string> * ?options: SpawnSyncOptionsWithStringEncoding -> SpawnSyncReturns<string>
        abstract spawnSync: command: string * ?args: ResizeArray<string> * ?options: SpawnSyncOptionsWithBufferEncoding -> SpawnSyncReturns<Buffer>
        abstract spawnSync: command: string * ?args: ResizeArray<string> * ?options: SpawnSyncOptions -> SpawnSyncReturns<Buffer>
        abstract execSync: command: string -> Buffer
        abstract execSync: command: string * ?options: ExecSyncOptionsWithStringEncoding -> string
        abstract execSync: command: string * ?options: ExecSyncOptionsWithBufferEncoding -> Buffer
        abstract execSync: command: string * ?options: ExecSyncOptions -> Buffer
        abstract execFileSync: command: string -> Buffer
        abstract execFileSync: command: string * ?options: ExecFileSyncOptionsWithStringEncoding -> string
        abstract execFileSync: command: string * ?options: ExecFileSyncOptionsWithBufferEncoding -> Buffer
        abstract execFileSync: command: string * ?options: ExecFileSyncOptions -> Buffer
        abstract execFileSync: command: string * ?args: ResizeArray<string> * ?options: ExecFileSyncOptionsWithStringEncoding -> string
        abstract execFileSync: command: string * ?args: ResizeArray<string> * ?options: ExecFileSyncOptionsWithBufferEncoding -> Buffer
        abstract execFileSync: command: string * ?args: ResizeArray<string> * ?options: ExecFileSyncOptions -> Buffer

    type [<AllowNullLiteral>] ChildProcess =
        inherit Events.EventEmitter
        abstract stdin: Stream.Writable with get, set
        abstract stdout: Stream.Readable with get, set
        abstract stderr: Stream.Readable with get, set
        abstract stdio: Stream.Writable * Stream.Readable * Stream.Readable with get, set
        abstract killed: bool with get, set
        abstract pid: float with get, set
        abstract kill: ?signal: string -> unit
        abstract send: message: obj option * ?callback: (Error -> unit) -> bool
        abstract send: message: obj option * ?sendHandle: U2<Net.Socket, Net.Server> * ?callback: (Error -> unit) -> bool
        abstract send: message: obj option * ?sendHandle: U2<Net.Socket, Net.Server> * ?options: MessageOptions * ?callback: (Error -> unit) -> bool
        abstract connected: bool with get, set
        abstract disconnect: unit -> unit
        abstract unref: unit -> unit
        abstract ref: unit -> unit
        /// events.EventEmitter
        /// 1. close
        /// 2. disconnect
        /// 3. error
        /// 4. exit
        /// 5. message
        abstract addListener: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> ChildProcess
        [<Emit "$0.addListener('close',$1)">] abstract addListener_close: listener: (float -> string -> unit) -> ChildProcess
        [<Emit "$0.addListener('disconnect',$1)">] abstract addListener_disconnect: listener: (unit -> unit) -> ChildProcess
        [<Emit "$0.addListener('error',$1)">] abstract addListener_error: listener: (Error -> unit) -> ChildProcess
        [<Emit "$0.addListener('exit',$1)">] abstract addListener_exit: listener: (float -> string -> unit) -> ChildProcess
        [<Emit "$0.addListener('message',$1)">] abstract addListener_message: listener: (obj option -> U2<Net.Socket, Net.Server> -> unit) -> ChildProcess
        abstract emit: ``event``: U2<string, Symbol> * [<ParamArray>] args: ResizeArray<obj option> -> bool
        [<Emit "$0.emit('close',$1,$2)">] abstract emit_close: code: float * signal: string -> bool
        [<Emit "$0.emit('disconnect')">] abstract emit_disconnect: unit -> bool
        [<Emit "$0.emit('error',$1)">] abstract emit_error: err: Error -> bool
        [<Emit "$0.emit('exit',$1,$2)">] abstract emit_exit: code: float * signal: string -> bool
        [<Emit "$0.emit('message',$1,$2)">] abstract emit_message: message: obj option * sendHandle: U2<Net.Socket, Net.Server> -> bool
        abstract on: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> ChildProcess
        [<Emit "$0.on('close',$1)">] abstract on_close: listener: (float -> string -> unit) -> ChildProcess
        [<Emit "$0.on('disconnect',$1)">] abstract on_disconnect: listener: (unit -> unit) -> ChildProcess
        [<Emit "$0.on('error',$1)">] abstract on_error: listener: (Error -> unit) -> ChildProcess
        [<Emit "$0.on('exit',$1)">] abstract on_exit: listener: (float -> string -> unit) -> ChildProcess
        [<Emit "$0.on('message',$1)">] abstract on_message: listener: (obj option -> U2<Net.Socket, Net.Server> -> unit) -> ChildProcess
        abstract once: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> ChildProcess
        [<Emit "$0.once('close',$1)">] abstract once_close: listener: (float -> string -> unit) -> ChildProcess
        [<Emit "$0.once('disconnect',$1)">] abstract once_disconnect: listener: (unit -> unit) -> ChildProcess
        [<Emit "$0.once('error',$1)">] abstract once_error: listener: (Error -> unit) -> ChildProcess
        [<Emit "$0.once('exit',$1)">] abstract once_exit: listener: (float -> string -> unit) -> ChildProcess
        [<Emit "$0.once('message',$1)">] abstract once_message: listener: (obj option -> U2<Net.Socket, Net.Server> -> unit) -> ChildProcess
        abstract prependListener: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> ChildProcess
        [<Emit "$0.prependListener('close',$1)">] abstract prependListener_close: listener: (float -> string -> unit) -> ChildProcess
        [<Emit "$0.prependListener('disconnect',$1)">] abstract prependListener_disconnect: listener: (unit -> unit) -> ChildProcess
        [<Emit "$0.prependListener('error',$1)">] abstract prependListener_error: listener: (Error -> unit) -> ChildProcess
        [<Emit "$0.prependListener('exit',$1)">] abstract prependListener_exit: listener: (float -> string -> unit) -> ChildProcess
        [<Emit "$0.prependListener('message',$1)">] abstract prependListener_message: listener: (obj option -> U2<Net.Socket, Net.Server> -> unit) -> ChildProcess
        abstract prependOnceListener: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> ChildProcess
        [<Emit "$0.prependOnceListener('close',$1)">] abstract prependOnceListener_close: listener: (float -> string -> unit) -> ChildProcess
        [<Emit "$0.prependOnceListener('disconnect',$1)">] abstract prependOnceListener_disconnect: listener: (unit -> unit) -> ChildProcess
        [<Emit "$0.prependOnceListener('error',$1)">] abstract prependOnceListener_error: listener: (Error -> unit) -> ChildProcess
        [<Emit "$0.prependOnceListener('exit',$1)">] abstract prependOnceListener_exit: listener: (float -> string -> unit) -> ChildProcess
        [<Emit "$0.prependOnceListener('message',$1)">] abstract prependOnceListener_message: listener: (obj option -> U2<Net.Socket, Net.Server> -> unit) -> ChildProcess

    type [<AllowNullLiteral>] MessageOptions =
        abstract keepOpen: bool option with get, set

    type [<AllowNullLiteral>] SpawnOptions =
        abstract cwd: string option with get, set
        abstract env: obj option with get, set
        abstract stdio: obj option with get, set
        abstract detached: bool option with get, set
        abstract uid: float option with get, set
        abstract gid: float option with get, set
        abstract shell: U2<bool, string> option with get, set
        abstract windowsVerbatimArguments: bool option with get, set
        abstract windowsHide: bool option with get, set

    type [<AllowNullLiteral>] ExecOptions =
        abstract cwd: string option with get, set
        abstract env: obj option with get, set
        abstract shell: string option with get, set
        abstract timeout: float option with get, set
        abstract maxBuffer: float option with get, set
        abstract killSignal: string option with get, set
        abstract uid: float option with get, set
        abstract gid: float option with get, set
        abstract windowsHide: bool option with get, set

    type [<AllowNullLiteral>] ExecOptionsWithStringEncoding =
        inherit ExecOptions
        abstract encoding: BufferEncoding with get, set

    type [<AllowNullLiteral>] ExecOptionsWithBufferEncoding =
        inherit ExecOptions
        abstract encoding: string option with get, set

    module Exec =

        type [<AllowNullLiteral>] IExports =
            abstract __promisify__: command: string -> Promise<obj>
            abstract __promisify__: command: string * options: obj -> Promise<obj>
            abstract __promisify__: command: string * options: ExecOptions -> Promise<obj>
            abstract __promisify__: command: string * ?options: obj option -> Promise<obj>

    type [<AllowNullLiteral>] ExecFileOptions =
        abstract cwd: string option with get, set
        abstract env: obj option with get, set
        abstract timeout: float option with get, set
        abstract maxBuffer: float option with get, set
        abstract killSignal: string option with get, set
        abstract uid: float option with get, set
        abstract gid: float option with get, set
        abstract windowsHide: bool option with get, set
        abstract windowsVerbatimArguments: bool option with get, set

    type [<AllowNullLiteral>] ExecFileOptionsWithStringEncoding =
        inherit ExecFileOptions
        abstract encoding: BufferEncoding with get, set

    type [<AllowNullLiteral>] ExecFileOptionsWithBufferEncoding =
        inherit ExecFileOptions
        abstract encoding: string option with get, set

    type [<AllowNullLiteral>] ExecFileOptionsWithOtherEncoding =
        inherit ExecFileOptions
        abstract encoding: string with get, set

    module ExecFile =

        type [<AllowNullLiteral>] IExports =
            abstract __promisify__: file: string -> Promise<obj>
            abstract __promisify__: file: string * args: ResizeArray<string> option -> Promise<obj>
            abstract __promisify__: file: string * options: ExecFileOptionsWithBufferEncoding -> Promise<obj>
            abstract __promisify__: file: string * args: ResizeArray<string> option * options: ExecFileOptionsWithBufferEncoding -> Promise<obj>
            abstract __promisify__: file: string * options: ExecFileOptionsWithStringEncoding -> Promise<obj>
            abstract __promisify__: file: string * args: ResizeArray<string> option * options: ExecFileOptionsWithStringEncoding -> Promise<obj>
            abstract __promisify__: file: string * options: ExecFileOptionsWithOtherEncoding -> Promise<obj>
            abstract __promisify__: file: string * args: ResizeArray<string> option * options: ExecFileOptionsWithOtherEncoding -> Promise<obj>
            abstract __promisify__: file: string * options: ExecFileOptions -> Promise<obj>
            abstract __promisify__: file: string * args: ResizeArray<string> option * options: ExecFileOptions -> Promise<obj>
            abstract __promisify__: file: string * options: obj option -> Promise<obj>
            abstract __promisify__: file: string * args: ResizeArray<string> option * options: obj option -> Promise<obj>

    type [<AllowNullLiteral>] ForkOptions =
        abstract cwd: string option with get, set
        abstract env: obj option with get, set
        abstract execPath: string option with get, set
        abstract execArgv: ResizeArray<string> option with get, set
        abstract silent: bool option with get, set
        abstract stdio: ResizeArray<obj option> option with get, set
        abstract uid: float option with get, set
        abstract gid: float option with get, set
        abstract windowsVerbatimArguments: bool option with get, set

    type [<AllowNullLiteral>] SpawnSyncOptions =
        abstract cwd: string option with get, set
        abstract input: U2<string, Buffer> option with get, set
        abstract stdio: obj option with get, set
        abstract env: obj option with get, set
        abstract uid: float option with get, set
        abstract gid: float option with get, set
        abstract timeout: float option with get, set
        abstract killSignal: string option with get, set
        abstract maxBuffer: float option with get, set
        abstract encoding: string option with get, set
        abstract shell: U2<bool, string> option with get, set
        abstract windowsHide: bool option with get, set
        abstract windowsVerbatimArguments: bool option with get, set

    type [<AllowNullLiteral>] SpawnSyncOptionsWithStringEncoding =
        inherit SpawnSyncOptions
        abstract encoding: BufferEncoding with get, set

    type [<AllowNullLiteral>] SpawnSyncOptionsWithBufferEncoding =
        inherit SpawnSyncOptions
        abstract encoding: string with get, set

    type [<AllowNullLiteral>] SpawnSyncReturns<'T> =
        abstract pid: float with get, set
        abstract output: ResizeArray<string> with get, set
        abstract stdout: 'T with get, set
        abstract stderr: 'T with get, set
        abstract status: float with get, set
        abstract signal: string with get, set
        abstract error: Error with get, set

    type [<AllowNullLiteral>] ExecSyncOptions =
        abstract cwd: string option with get, set
        abstract input: U2<string, Buffer> option with get, set
        abstract stdio: obj option with get, set
        abstract env: obj option with get, set
        abstract shell: string option with get, set
        abstract uid: float option with get, set
        abstract gid: float option with get, set
        abstract timeout: float option with get, set
        abstract killSignal: string option with get, set
        abstract maxBuffer: float option with get, set
        abstract encoding: string option with get, set
        abstract windowsHide: bool option with get, set

    type [<AllowNullLiteral>] ExecSyncOptionsWithStringEncoding =
        inherit ExecSyncOptions
        abstract encoding: BufferEncoding with get, set

    type [<AllowNullLiteral>] ExecSyncOptionsWithBufferEncoding =
        inherit ExecSyncOptions
        abstract encoding: string with get, set

    type [<AllowNullLiteral>] ExecFileSyncOptions =
        abstract cwd: string option with get, set
        abstract input: U2<string, Buffer> option with get, set
        abstract stdio: obj option with get, set
        abstract env: obj option with get, set
        abstract uid: float option with get, set
        abstract gid: float option with get, set
        abstract timeout: float option with get, set
        abstract killSignal: string option with get, set
        abstract maxBuffer: float option with get, set
        abstract encoding: string option with get, set
        abstract windowsHide: bool option with get, set

    type [<AllowNullLiteral>] ExecFileSyncOptionsWithStringEncoding =
        inherit ExecFileSyncOptions
        abstract encoding: BufferEncoding with get, set

    type [<AllowNullLiteral>] ExecFileSyncOptionsWithBufferEncoding =
        inherit ExecFileSyncOptions
        abstract encoding: string with get, set

module Url =
    type ParsedUrlQuery = Querystring.ParsedUrlQuery

    type [<AllowNullLiteral>] IExports =
        abstract parse: urlStr: string -> UrlWithStringQuery
        abstract parse: urlStr: string * parseQueryString: obj option * ?slashesDenoteHost: bool -> UrlWithStringQuery
        abstract parse: urlStr: string * parseQueryString: obj * ?slashesDenoteHost: bool -> UrlWithParsedQuery
        abstract parse: urlStr: string * parseQueryString: bool * ?slashesDenoteHost: bool -> Url
        abstract format: URL: URL * ?options: URLFormatOptions -> string
        abstract format: urlObject: U2<UrlObject, string> -> string
        abstract resolve: from: string * ``to``: string -> string
        abstract domainToASCII: domain: string -> string
        abstract domainToUnicode: domain: string -> string
        abstract URLSearchParams: URLSearchParamsStatic
        abstract URL: URLStatic

    type [<AllowNullLiteral>] UrlObjectCommon =
        abstract auth: string option with get, set
        abstract hash: string option with get, set
        abstract host: string option with get, set
        abstract hostname: string option with get, set
        abstract href: string option with get, set
        abstract path: string option with get, set
        abstract pathname: string option with get, set
        abstract protocol: string option with get, set
        abstract search: string option with get, set
        abstract slashes: bool option with get, set

    type [<AllowNullLiteral>] UrlObject =
        inherit UrlObjectCommon
        abstract port: U2<string, float> option with get, set
        abstract query: U2<string, obj> option with get, set

    type [<AllowNullLiteral>] Url =
        inherit UrlObjectCommon
        abstract port: string option with get, set
        abstract query: U2<string, ParsedUrlQuery> option with get, set

    type [<AllowNullLiteral>] UrlWithParsedQuery =
        inherit Url
        abstract query: ParsedUrlQuery with get, set

    type [<AllowNullLiteral>] UrlWithStringQuery =
        inherit Url
        abstract query: string option with get, set

    type [<AllowNullLiteral>] URLFormatOptions =
        abstract auth: bool option with get, set
        abstract fragment: bool option with get, set
        abstract search: bool option with get, set
        abstract unicode: bool option with get, set

    type [<AllowNullLiteral>] URLSearchParams =
        inherit Iterable<string * string>
        abstract append: name: string * value: string -> unit
        abstract delete: name: string -> unit
        abstract entries: unit -> IterableIterator<string * string>
        abstract forEach: callback: (string -> string -> unit) -> unit
        abstract get: name: string -> string option
        abstract getAll: name: string -> ResizeArray<string>
        abstract has: name: string -> bool
        abstract keys: unit -> IterableIterator<string>
        abstract set: name: string * value: string -> unit
        abstract sort: unit -> unit
        abstract toString: unit -> string
        abstract values: unit -> IterableIterator<string>
        abstract ``[Symbol.iterator]``: unit -> IterableIterator<string * string>

    type [<AllowNullLiteral>] URLSearchParamsStatic =
        [<Emit "new $0($1...)">] abstract Create: ?init: U5<URLSearchParams, string, obj, Iterable<string * string>, Array<string * string>> -> URLSearchParams

    type [<AllowNullLiteral>] URL =
        abstract hash: string with get, set
        abstract host: string with get, set
        abstract hostname: string with get, set
        abstract href: string with get, set
        abstract origin: string
        abstract password: string with get, set
        abstract pathname: string with get, set
        abstract port: string with get, set
        abstract protocol: string with get, set
        abstract search: string with get, set
        abstract searchParams: URLSearchParams
        abstract username: string with get, set
        abstract toString: unit -> string
        abstract toJSON: unit -> string

    type [<AllowNullLiteral>] URLStatic =
        [<Emit "new $0($1...)">] abstract Create: input: string * ?``base``: U2<string, URL> -> URL

module Dns =
    let [<Import("lookup","dns")>] lookup: Lookup.IExports = jsNative
    let [<Import("lookupService","dns")>] lookupService: LookupService.IExports = jsNative
    let [<Import("resolve","dns")>] resolve: Resolve.IExports = jsNative
    let [<Import("resolve4","dns")>] resolve4: Resolve4.IExports = jsNative
    let [<Import("resolve6","dns")>] resolve6: Resolve6.IExports = jsNative

    type [<AllowNullLiteral>] IExports =
        abstract lookup: hostname: string * family: float * callback: (NodeJS.ErrnoException -> string -> float -> unit) -> unit
        abstract lookup: hostname: string * options: LookupOneOptions * callback: (NodeJS.ErrnoException -> string -> float -> unit) -> unit
        abstract lookup: hostname: string * options: LookupAllOptions * callback: (NodeJS.ErrnoException -> ResizeArray<LookupAddress> -> unit) -> unit
        abstract lookup: hostname: string * options: LookupOptions * callback: (NodeJS.ErrnoException -> U2<string, ResizeArray<LookupAddress>> -> float -> unit) -> unit
        abstract lookup: hostname: string * callback: (NodeJS.ErrnoException -> string -> float -> unit) -> unit
        abstract lookupService: address: string * port: float * callback: (NodeJS.ErrnoException -> string -> string -> unit) -> unit
        abstract resolve: hostname: string * callback: (NodeJS.ErrnoException -> ResizeArray<string> -> unit) -> unit
        [<Emit "$0.resolve($1,'A',$2)">] abstract resolve_A: hostname: string * callback: (NodeJS.ErrnoException -> ResizeArray<string> -> unit) -> unit
        [<Emit "$0.resolve($1,'AAAA',$2)">] abstract resolve_AAAA: hostname: string * callback: (NodeJS.ErrnoException -> ResizeArray<string> -> unit) -> unit
        [<Emit "$0.resolve($1,'CNAME',$2)">] abstract resolve_CNAME: hostname: string * callback: (NodeJS.ErrnoException -> ResizeArray<string> -> unit) -> unit
        [<Emit "$0.resolve($1,'MX',$2)">] abstract resolve_MX: hostname: string * callback: (NodeJS.ErrnoException -> ResizeArray<MxRecord> -> unit) -> unit
        [<Emit "$0.resolve($1,'NAPTR',$2)">] abstract resolve_NAPTR: hostname: string * callback: (NodeJS.ErrnoException -> ResizeArray<NaptrRecord> -> unit) -> unit
        [<Emit "$0.resolve($1,'NS',$2)">] abstract resolve_NS: hostname: string * callback: (NodeJS.ErrnoException -> ResizeArray<string> -> unit) -> unit
        [<Emit "$0.resolve($1,'PTR',$2)">] abstract resolve_PTR: hostname: string * callback: (NodeJS.ErrnoException -> ResizeArray<string> -> unit) -> unit
        [<Emit "$0.resolve($1,'SOA',$2)">] abstract resolve_SOA: hostname: string * callback: (NodeJS.ErrnoException -> SoaRecord -> unit) -> unit
        [<Emit "$0.resolve($1,'SRV',$2)">] abstract resolve_SRV: hostname: string * callback: (NodeJS.ErrnoException -> ResizeArray<SrvRecord> -> unit) -> unit
        [<Emit "$0.resolve($1,'TXT',$2)">] abstract resolve_TXT: hostname: string * callback: (NodeJS.ErrnoException -> ResizeArray<ResizeArray<string>> -> unit) -> unit
        abstract resolve: hostname: string * rrtype: string * callback: (NodeJS.ErrnoException -> U6<ResizeArray<string>, ResizeArray<MxRecord>, ResizeArray<NaptrRecord>, SoaRecord, ResizeArray<SrvRecord>, ResizeArray<ResizeArray<string>>> -> unit) -> unit
        abstract resolve4: hostname: string * callback: (NodeJS.ErrnoException -> ResizeArray<string> -> unit) -> unit
        abstract resolve4: hostname: string * options: ResolveWithTtlOptions * callback: (NodeJS.ErrnoException -> ResizeArray<RecordWithTtl> -> unit) -> unit
        abstract resolve4: hostname: string * options: ResolveOptions * callback: (NodeJS.ErrnoException -> U2<ResizeArray<string>, ResizeArray<RecordWithTtl>> -> unit) -> unit
        abstract resolve6: hostname: string * callback: (NodeJS.ErrnoException -> ResizeArray<string> -> unit) -> unit
        abstract resolve6: hostname: string * options: ResolveWithTtlOptions * callback: (NodeJS.ErrnoException -> ResizeArray<RecordWithTtl> -> unit) -> unit
        abstract resolve6: hostname: string * options: ResolveOptions * callback: (NodeJS.ErrnoException -> U2<ResizeArray<string>, ResizeArray<RecordWithTtl>> -> unit) -> unit
        abstract resolveCname: hostname: string * callback: (NodeJS.ErrnoException -> ResizeArray<string> -> unit) -> unit
        abstract resolveMx: hostname: string * callback: (NodeJS.ErrnoException -> ResizeArray<MxRecord> -> unit) -> unit
        abstract resolveNaptr: hostname: string * callback: (NodeJS.ErrnoException -> ResizeArray<NaptrRecord> -> unit) -> unit
        abstract resolveNs: hostname: string * callback: (NodeJS.ErrnoException -> ResizeArray<string> -> unit) -> unit
        abstract resolvePtr: hostname: string * callback: (NodeJS.ErrnoException -> ResizeArray<string> -> unit) -> unit
        abstract resolveSoa: hostname: string * callback: (NodeJS.ErrnoException -> SoaRecord -> unit) -> unit
        abstract resolveSrv: hostname: string * callback: (NodeJS.ErrnoException -> ResizeArray<SrvRecord> -> unit) -> unit
        abstract resolveTxt: hostname: string * callback: (NodeJS.ErrnoException -> ResizeArray<ResizeArray<string>> -> unit) -> unit
        abstract reverse: ip: string * callback: (NodeJS.ErrnoException -> ResizeArray<string> -> unit) -> unit
        abstract setServers: servers: ResizeArray<string> -> unit
    let ADDRCONFIG: float = jsNative
    let V4MAPPED: float = jsNative

    type [<AllowNullLiteral>] LookupOptions =
        abstract family: float option with get, set
        abstract hints: float option with get, set
        abstract all: bool option with get, set

    type [<AllowNullLiteral>] LookupOneOptions =
        inherit LookupOptions
        abstract all: obj option with get, set

    type [<AllowNullLiteral>] LookupAllOptions =
        inherit LookupOptions
        abstract all: obj with get, set

    type [<AllowNullLiteral>] LookupAddress =
        abstract address: string with get, set
        abstract family: float with get, set

    module Lookup =

        type [<AllowNullLiteral>] IExports =
            abstract __promisify__: hostname: string * options: LookupAllOptions -> Promise<obj>
            abstract __promisify__: hostname: string * ?options: U2<LookupOneOptions, float> -> Promise<obj>
            abstract __promisify__: hostname: string * ?options: U2<LookupOptions, float> -> Promise<obj>

    module LookupService =

        type [<AllowNullLiteral>] IExports =
            abstract __promisify__: address: string * port: float -> Promise<obj>

    type [<AllowNullLiteral>] ResolveOptions =
        abstract ttl: bool with get, set

    type [<AllowNullLiteral>] ResolveWithTtlOptions =
        inherit ResolveOptions
        abstract ttl: obj with get, set

    type [<AllowNullLiteral>] RecordWithTtl =
        abstract address: string with get, set
        abstract ttl: float with get, set

    type [<AllowNullLiteral>] MxRecord =
        abstract priority: float with get, set
        abstract exchange: string with get, set

    type [<AllowNullLiteral>] NaptrRecord =
        abstract flags: string with get, set
        abstract service: string with get, set
        abstract regexp: string with get, set
        abstract replacement: string with get, set
        abstract order: float with get, set
        abstract preference: float with get, set

    type [<AllowNullLiteral>] SoaRecord =
        abstract nsname: string with get, set
        abstract hostmaster: string with get, set
        abstract serial: float with get, set
        abstract refresh: float with get, set
        abstract retry: float with get, set
        abstract expire: float with get, set
        abstract minttl: float with get, set

    type [<AllowNullLiteral>] SrvRecord =
        abstract priority: float with get, set
        abstract weight: float with get, set
        abstract port: float with get, set
        abstract name: string with get, set

    module Resolve =

        type [<AllowNullLiteral>] IExports =
            abstract __promisify__: hostname: string * ?rrtype: U5<string, string, string, string, string> -> Promise<ResizeArray<string>>
            [<Emit "$0.__promisify__($1,'MX')">] abstract __promisify___MX: hostname: string -> Promise<ResizeArray<MxRecord>>
            [<Emit "$0.__promisify__($1,'NAPTR')">] abstract __promisify___NAPTR: hostname: string -> Promise<ResizeArray<NaptrRecord>>
            [<Emit "$0.__promisify__($1,'SOA')">] abstract __promisify___SOA: hostname: string -> Promise<SoaRecord>
            [<Emit "$0.__promisify__($1,'SRV')">] abstract __promisify___SRV: hostname: string -> Promise<ResizeArray<SrvRecord>>
            [<Emit "$0.__promisify__($1,'TXT')">] abstract __promisify___TXT: hostname: string -> Promise<ResizeArray<ResizeArray<string>>>
            abstract __promisify__: hostname: string * ?rrtype: string -> Promise<U6<ResizeArray<string>, ResizeArray<MxRecord>, ResizeArray<NaptrRecord>, SoaRecord, ResizeArray<SrvRecord>, ResizeArray<ResizeArray<string>>>>

    module Resolve4 =

        type [<AllowNullLiteral>] IExports =
            abstract __promisify__: hostname: string -> Promise<ResizeArray<string>>
            abstract __promisify__: hostname: string * options: ResolveWithTtlOptions -> Promise<ResizeArray<RecordWithTtl>>
            abstract __promisify__: hostname: string * ?options: ResolveOptions -> Promise<U2<ResizeArray<string>, ResizeArray<RecordWithTtl>>>

    module Resolve6 =

        type [<AllowNullLiteral>] IExports =
            abstract __promisify__: hostname: string -> Promise<ResizeArray<string>>
            abstract __promisify__: hostname: string * options: ResolveWithTtlOptions -> Promise<ResizeArray<RecordWithTtl>>
            abstract __promisify__: hostname: string * ?options: ResolveOptions -> Promise<U2<ResizeArray<string>, ResizeArray<RecordWithTtl>>>
    let NODATA: string = jsNative
    let FORMERR: string = jsNative
    let SERVFAIL: string = jsNative
    let NOTFOUND: string = jsNative
    let NOTIMP: string = jsNative
    let REFUSED: string = jsNative
    let BADQUERY: string = jsNative
    let BADNAME: string = jsNative
    let BADFAMILY: string = jsNative
    let BADRESP: string = jsNative
    let CONNREFUSED: string = jsNative
    let TIMEOUT: string = jsNative
    let EOF: string = jsNative
    let FILE: string = jsNative
    let NOMEM: string = jsNative
    let DESTRUCTION: string = jsNative
    let BADSTR: string = jsNative
    let BADFLAGS: string = jsNative
    let NONAME: string = jsNative
    let BADHINTS: string = jsNative
    let NOTINITIALIZED: string = jsNative
    let LOADIPHLPAPI: string = jsNative
    let ADDRGETNETWORKPARAMS: string = jsNative
    let CANCELLED: string = jsNative

module Net =

    type [<AllowNullLiteral>] IExports =
        abstract Socket: SocketStatic
        abstract Server: ServerStatic
        abstract createServer: ?connectionListener: (Socket -> unit) -> Server
        abstract createServer: ?options: CreateServerOptions * ?connectionListener: (Socket -> unit) -> Server
        abstract connect: options: NetConnectOpts * ?connectionListener: Function -> Socket
        abstract connect: port: float * ?host: string * ?connectionListener: Function -> Socket
        abstract connect: path: string * ?connectionListener: Function -> Socket
        abstract createConnection: options: NetConnectOpts * ?connectionListener: Function -> Socket
        abstract createConnection: port: float * ?host: string * ?connectionListener: Function -> Socket
        abstract createConnection: path: string * ?connectionListener: Function -> Socket
        abstract isIP: input: string -> float
        abstract isIPv4: input: string -> bool
        abstract isIPv6: input: string -> bool

    type [<AllowNullLiteral>] CreateServerOptions =
        abstract allowHalfOpen: bool option with get, set
        abstract pauseOnConnect: bool option with get, set

    type [<AllowNullLiteral>] LookupFunction =
        [<Emit "$0($1...)">] abstract Invoke: hostname: string * options: Dns.LookupOneOptions * callback: (NodeJS.ErrnoException option -> string -> float -> unit) -> unit

    type [<AllowNullLiteral>] SocketConstructorOpts =
        abstract fd: float option with get, set
        abstract allowHalfOpen: bool option with get, set
        abstract readable: bool option with get, set
        abstract writable: bool option with get, set

    type [<AllowNullLiteral>] TcpSocketConnectOpts =
        abstract port: float with get, set
        abstract host: string option with get, set
        abstract localAddress: string option with get, set
        abstract localPort: float option with get, set
        abstract hints: float option with get, set
        abstract family: float option with get, set
        abstract lookup: LookupFunction option with get, set

    type [<AllowNullLiteral>] IpcSocketConnectOpts =
        abstract path: string with get, set

    type SocketConnectOpts =
        U2<TcpSocketConnectOpts, IpcSocketConnectOpts>

    [<RequireQualifiedAccess; CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
    module SocketConnectOpts =
        let ofTcpSocketConnectOpts v: SocketConnectOpts = v |> U2.Case1
        let isTcpSocketConnectOpts (v: SocketConnectOpts) = match v with U2.Case1 _ -> true | _ -> false
        let asTcpSocketConnectOpts (v: SocketConnectOpts) = match v with U2.Case1 o -> Some o | _ -> None
        let ofIpcSocketConnectOpts v: SocketConnectOpts = v |> U2.Case2
        let isIpcSocketConnectOpts (v: SocketConnectOpts) = match v with U2.Case2 _ -> true | _ -> false
        let asIpcSocketConnectOpts (v: SocketConnectOpts) = match v with U2.Case2 o -> Some o | _ -> None

    type [<AllowNullLiteral>] Socket =
        inherit Stream.Duplex
        abstract write: buffer: Buffer -> bool
        abstract write: buffer: Buffer * ?cb: Function -> bool
        abstract write: str: string * ?cb: Function -> bool
        abstract write: str: string * ?encoding: string * ?cb: Function -> bool
        abstract write: str: string * ?encoding: string * ?fd: string -> bool
        abstract write: data: obj option * ?encoding: string * ?callback: Function -> unit
        abstract connect: options: SocketConnectOpts * ?connectionListener: Function -> Socket
        abstract connect: port: float * host: string * ?connectionListener: Function -> Socket
        abstract connect: port: float * ?connectionListener: Function -> Socket
        abstract connect: path: string * ?connectionListener: Function -> Socket
        abstract bufferSize: float with get, set
        abstract setEncoding: ?encoding: string -> Socket
        abstract destroy: ?err: obj option -> unit
        abstract pause: unit -> Socket
        abstract resume: unit -> Socket
        abstract setTimeout: timeout: float * ?callback: Function -> Socket
        abstract setNoDelay: ?noDelay: bool -> Socket
        abstract setKeepAlive: ?enable: bool * ?initialDelay: float -> Socket
        abstract address: unit -> obj
        abstract unref: unit -> unit
        abstract ref: unit -> unit
        abstract remoteAddress: string option with get, set
        abstract remoteFamily: string option with get, set
        abstract remotePort: float option with get, set
        abstract localAddress: string with get, set
        abstract localPort: float with get, set
        abstract bytesRead: float with get, set
        abstract bytesWritten: float with get, set
        abstract connecting: bool with get, set
        abstract destroyed: bool with get, set
        abstract ``end``: unit -> unit
        abstract ``end``: buffer: Buffer * ?cb: Function -> unit
        abstract ``end``: str: string * ?cb: Function -> unit
        abstract ``end``: str: string * ?encoding: string * ?cb: Function -> unit
        abstract ``end``: ?data: obj option * ?encoding: string -> unit
        /// events.EventEmitter
        ///    1. close
        ///    2. connect
        ///    3. data
        ///    4. drain
        ///    5. end
        ///    6. error
        ///    7. lookup
        ///    8. timeout
        abstract addListener: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> Socket
        [<Emit "$0.addListener('close',$1)">] abstract addListener_close: listener: (bool -> unit) -> Socket
        [<Emit "$0.addListener('connect',$1)">] abstract addListener_connect: listener: (unit -> unit) -> Socket
        [<Emit "$0.addListener('data',$1)">] abstract addListener_data: listener: (Buffer -> unit) -> Socket
        [<Emit "$0.addListener('drain',$1)">] abstract addListener_drain: listener: (unit -> unit) -> Socket
        [<Emit "$0.addListener('end',$1)">] abstract addListener_end: listener: (unit -> unit) -> Socket
        [<Emit "$0.addListener('error',$1)">] abstract addListener_error: listener: (Error -> unit) -> Socket
        [<Emit "$0.addListener('lookup',$1)">] abstract addListener_lookup: listener: (Error -> string -> U2<string, float> -> string -> unit) -> Socket
        [<Emit "$0.addListener('timeout',$1)">] abstract addListener_timeout: listener: (unit -> unit) -> Socket
        abstract emit: ``event``: U2<string, Symbol> * [<ParamArray>] args: ResizeArray<obj option> -> bool
        [<Emit "$0.emit('close',$1)">] abstract emit_close: had_error: bool -> bool
        [<Emit "$0.emit('connect')">] abstract emit_connect: unit -> bool
        [<Emit "$0.emit('data',$1)">] abstract emit_data: data: Buffer -> bool
        [<Emit "$0.emit('drain')">] abstract emit_drain: unit -> bool
        [<Emit "$0.emit('end')">] abstract emit_end: unit -> bool
        [<Emit "$0.emit('error',$1)">] abstract emit_error: err: Error -> bool
        [<Emit "$0.emit('lookup',$1,$2,$3,$4)">] abstract emit_lookup: err: Error * address: string * family: U2<string, float> * host: string -> bool
        [<Emit "$0.emit('timeout')">] abstract emit_timeout: unit -> bool
        abstract on: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> Socket
        [<Emit "$0.on('close',$1)">] abstract on_close: listener: (bool -> unit) -> Socket
        [<Emit "$0.on('connect',$1)">] abstract on_connect: listener: (unit -> unit) -> Socket
        [<Emit "$0.on('data',$1)">] abstract on_data: listener: (Buffer -> unit) -> Socket
        [<Emit "$0.on('drain',$1)">] abstract on_drain: listener: (unit -> unit) -> Socket
        [<Emit "$0.on('end',$1)">] abstract on_end: listener: (unit -> unit) -> Socket
        [<Emit "$0.on('error',$1)">] abstract on_error: listener: (Error -> unit) -> Socket
        [<Emit "$0.on('lookup',$1)">] abstract on_lookup: listener: (Error -> string -> U2<string, float> -> string -> unit) -> Socket
        [<Emit "$0.on('timeout',$1)">] abstract on_timeout: listener: (unit -> unit) -> Socket
        abstract once: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> Socket
        [<Emit "$0.once('close',$1)">] abstract once_close: listener: (bool -> unit) -> Socket
        [<Emit "$0.once('connect',$1)">] abstract once_connect: listener: (unit -> unit) -> Socket
        [<Emit "$0.once('data',$1)">] abstract once_data: listener: (Buffer -> unit) -> Socket
        [<Emit "$0.once('drain',$1)">] abstract once_drain: listener: (unit -> unit) -> Socket
        [<Emit "$0.once('end',$1)">] abstract once_end: listener: (unit -> unit) -> Socket
        [<Emit "$0.once('error',$1)">] abstract once_error: listener: (Error -> unit) -> Socket
        [<Emit "$0.once('lookup',$1)">] abstract once_lookup: listener: (Error -> string -> U2<string, float> -> string -> unit) -> Socket
        [<Emit "$0.once('timeout',$1)">] abstract once_timeout: listener: (unit -> unit) -> Socket
        abstract prependListener: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> Socket
        [<Emit "$0.prependListener('close',$1)">] abstract prependListener_close: listener: (bool -> unit) -> Socket
        [<Emit "$0.prependListener('connect',$1)">] abstract prependListener_connect: listener: (unit -> unit) -> Socket
        [<Emit "$0.prependListener('data',$1)">] abstract prependListener_data: listener: (Buffer -> unit) -> Socket
        [<Emit "$0.prependListener('drain',$1)">] abstract prependListener_drain: listener: (unit -> unit) -> Socket
        [<Emit "$0.prependListener('end',$1)">] abstract prependListener_end: listener: (unit -> unit) -> Socket
        [<Emit "$0.prependListener('error',$1)">] abstract prependListener_error: listener: (Error -> unit) -> Socket
        [<Emit "$0.prependListener('lookup',$1)">] abstract prependListener_lookup: listener: (Error -> string -> U2<string, float> -> string -> unit) -> Socket
        [<Emit "$0.prependListener('timeout',$1)">] abstract prependListener_timeout: listener: (unit -> unit) -> Socket
        abstract prependOnceListener: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> Socket
        [<Emit "$0.prependOnceListener('close',$1)">] abstract prependOnceListener_close: listener: (bool -> unit) -> Socket
        [<Emit "$0.prependOnceListener('connect',$1)">] abstract prependOnceListener_connect: listener: (unit -> unit) -> Socket
        [<Emit "$0.prependOnceListener('data',$1)">] abstract prependOnceListener_data: listener: (Buffer -> unit) -> Socket
        [<Emit "$0.prependOnceListener('drain',$1)">] abstract prependOnceListener_drain: listener: (unit -> unit) -> Socket
        [<Emit "$0.prependOnceListener('end',$1)">] abstract prependOnceListener_end: listener: (unit -> unit) -> Socket
        [<Emit "$0.prependOnceListener('error',$1)">] abstract prependOnceListener_error: listener: (Error -> unit) -> Socket
        [<Emit "$0.prependOnceListener('lookup',$1)">] abstract prependOnceListener_lookup: listener: (Error -> string -> U2<string, float> -> string -> unit) -> Socket
        [<Emit "$0.prependOnceListener('timeout',$1)">] abstract prependOnceListener_timeout: listener: (unit -> unit) -> Socket

    type [<AllowNullLiteral>] SocketStatic =
        [<Emit "new $0($1...)">] abstract Create: ?options: SocketConstructorOpts -> Socket

    type [<AllowNullLiteral>] ListenOptions =
        abstract port: float option with get, set
        abstract host: string option with get, set
        abstract backlog: float option with get, set
        abstract path: string option with get, set
        abstract exclusive: bool option with get, set

    type [<AllowNullLiteral>] Server =
        inherit Events.EventEmitter
        abstract listen: ?port: float * ?hostname: string * ?backlog: float * ?listeningListener: Function -> Server
        abstract listen: ?port: float * ?hostname: string * ?listeningListener: Function -> Server
        abstract listen: ?port: float * ?backlog: float * ?listeningListener: Function -> Server
        abstract listen: ?port: float * ?listeningListener: Function -> Server
        abstract listen: path: string * ?backlog: float * ?listeningListener: Function -> Server
        abstract listen: path: string * ?listeningListener: Function -> Server
        abstract listen: options: ListenOptions * ?listeningListener: Function -> Server
        abstract listen: handle: obj option * ?backlog: float * ?listeningListener: Function -> Server
        abstract listen: handle: obj option * ?listeningListener: Function -> Server
        abstract close: ?callback: Function -> Server
        abstract address: unit -> obj
        abstract getConnections: cb: (Error option -> float -> unit) -> unit
        abstract ref: unit -> Server
        abstract unref: unit -> Server
        abstract maxConnections: float with get, set
        abstract connections: float with get, set
        abstract listening: bool with get, set
        /// events.EventEmitter
        ///    1. close
        ///    2. connection
        ///    3. error
        ///    4. listening
        abstract addListener: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> Server
        [<Emit "$0.addListener('close',$1)">] abstract addListener_close: listener: (unit -> unit) -> Server
        [<Emit "$0.addListener('connection',$1)">] abstract addListener_connection: listener: (Socket -> unit) -> Server
        [<Emit "$0.addListener('error',$1)">] abstract addListener_error: listener: (Error -> unit) -> Server
        [<Emit "$0.addListener('listening',$1)">] abstract addListener_listening: listener: (unit -> unit) -> Server
        abstract emit: ``event``: U2<string, Symbol> * [<ParamArray>] args: ResizeArray<obj option> -> bool
        [<Emit "$0.emit('close')">] abstract emit_close: unit -> bool
        [<Emit "$0.emit('connection',$1)">] abstract emit_connection: socket: Socket -> bool
        [<Emit "$0.emit('error',$1)">] abstract emit_error: err: Error -> bool
        [<Emit "$0.emit('listening')">] abstract emit_listening: unit -> bool
        abstract on: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> Server
        [<Emit "$0.on('close',$1)">] abstract on_close: listener: (unit -> unit) -> Server
        [<Emit "$0.on('connection',$1)">] abstract on_connection: listener: (Socket -> unit) -> Server
        [<Emit "$0.on('error',$1)">] abstract on_error: listener: (Error -> unit) -> Server
        [<Emit "$0.on('listening',$1)">] abstract on_listening: listener: (unit -> unit) -> Server
        abstract once: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> Server
        [<Emit "$0.once('close',$1)">] abstract once_close: listener: (unit -> unit) -> Server
        [<Emit "$0.once('connection',$1)">] abstract once_connection: listener: (Socket -> unit) -> Server
        [<Emit "$0.once('error',$1)">] abstract once_error: listener: (Error -> unit) -> Server
        [<Emit "$0.once('listening',$1)">] abstract once_listening: listener: (unit -> unit) -> Server
        abstract prependListener: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> Server
        [<Emit "$0.prependListener('close',$1)">] abstract prependListener_close: listener: (unit -> unit) -> Server
        [<Emit "$0.prependListener('connection',$1)">] abstract prependListener_connection: listener: (Socket -> unit) -> Server
        [<Emit "$0.prependListener('error',$1)">] abstract prependListener_error: listener: (Error -> unit) -> Server
        [<Emit "$0.prependListener('listening',$1)">] abstract prependListener_listening: listener: (unit -> unit) -> Server
        abstract prependOnceListener: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> Server
        [<Emit "$0.prependOnceListener('close',$1)">] abstract prependOnceListener_close: listener: (unit -> unit) -> Server
        [<Emit "$0.prependOnceListener('connection',$1)">] abstract prependOnceListener_connection: listener: (Socket -> unit) -> Server
        [<Emit "$0.prependOnceListener('error',$1)">] abstract prependOnceListener_error: listener: (Error -> unit) -> Server
        [<Emit "$0.prependOnceListener('listening',$1)">] abstract prependOnceListener_listening: listener: (unit -> unit) -> Server

    type [<AllowNullLiteral>] ServerStatic =
        [<Emit "new $0($1...)">] abstract Create: ?connectionListener: (Socket -> unit) -> Server
        [<Emit "new $0($1...)">] abstract Create: ?options: ServerStaticOptions * ?connectionListener: (Socket -> unit) -> Server

    type [<AllowNullLiteral>] ServerStaticOptions =
        abstract allowHalfOpen: bool option with get, set
        abstract pauseOnConnect: bool option with get, set

    type [<AllowNullLiteral>] TcpNetConnectOpts =
        inherit TcpSocketConnectOpts
        inherit SocketConstructorOpts
        abstract timeout: float option with get, set

    type [<AllowNullLiteral>] IpcNetConnectOpts =
        inherit IpcSocketConnectOpts
        inherit SocketConstructorOpts
        abstract timeout: float option with get, set

    type NetConnectOpts =
        U2<TcpNetConnectOpts, IpcNetConnectOpts>

    [<RequireQualifiedAccess; CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
    module NetConnectOpts =
        let ofTcpNetConnectOpts v: NetConnectOpts = v |> U2.Case1
        let isTcpNetConnectOpts (v: NetConnectOpts) = match v with U2.Case1 _ -> true | _ -> false
        let asTcpNetConnectOpts (v: NetConnectOpts) = match v with U2.Case1 o -> Some o | _ -> None
        let ofIpcNetConnectOpts v: NetConnectOpts = v |> U2.Case2
        let isIpcNetConnectOpts (v: NetConnectOpts) = match v with U2.Case2 _ -> true | _ -> false
        let asIpcNetConnectOpts (v: NetConnectOpts) = match v with U2.Case2 o -> Some o | _ -> None

module Dgram =

    type [<AllowNullLiteral>] IExports =
        abstract createSocket: ``type``: SocketType * ?callback: (Buffer -> RemoteInfo -> unit) -> Socket
        abstract createSocket: options: SocketOptions * ?callback: (Buffer -> RemoteInfo -> unit) -> Socket
        abstract Socket: SocketStatic

    type [<AllowNullLiteral>] RemoteInfo =
        abstract address: string with get, set
        abstract family: string with get, set
        abstract port: float with get, set

    type [<AllowNullLiteral>] AddressInfo =
        abstract address: string with get, set
        abstract family: string with get, set
        abstract port: float with get, set

    type [<AllowNullLiteral>] BindOptions =
        abstract port: float with get, set
        abstract address: string option with get, set
        abstract exclusive: bool option with get, set

    type [<StringEnum>] [<RequireQualifiedAccess>] SocketType =
        | Udp4
        | Udp6

    type [<AllowNullLiteral>] SocketOptions =
        abstract ``type``: SocketType with get, set
        abstract reuseAddr: bool option with get, set
        abstract recvBufferSize: float option with get, set
        abstract sendBufferSize: float option with get, set
        abstract lookup: (string -> Dns.LookupOneOptions -> (NodeJS.ErrnoException -> string -> float -> unit) -> unit) option with get, set

    type [<AllowNullLiteral>] Socket =
        inherit Events.EventEmitter
        abstract send: msg: U4<Buffer, string, Uint8Array, ResizeArray<obj option>> * port: float * ?address: string * ?callback: (Error option -> float -> unit) -> unit
        abstract send: msg: U3<Buffer, string, Uint8Array> * offset: float * length: float * port: float * ?address: string * ?callback: (Error option -> float -> unit) -> unit
        abstract bind: ?port: float * ?address: string * ?callback: (unit -> unit) -> unit
        abstract bind: ?port: float * ?callback: (unit -> unit) -> unit
        abstract bind: ?callback: (unit -> unit) -> unit
        abstract bind: options: BindOptions * ?callback: Function -> unit
        abstract close: ?callback: (unit -> unit) -> unit
        abstract address: unit -> AddressInfo
        abstract setBroadcast: flag: bool -> unit
        abstract setTTL: ttl: float -> unit
        abstract setMulticastTTL: ttl: float -> unit
        abstract setMulticastInterface: multicastInterface: string -> unit
        abstract setMulticastLoopback: flag: bool -> unit
        abstract addMembership: multicastAddress: string * ?multicastInterface: string -> unit
        abstract dropMembership: multicastAddress: string * ?multicastInterface: string -> unit
        abstract ref: unit -> Socket
        abstract unref: unit -> Socket
        abstract setRecvBufferSize: size: float -> unit
        abstract setSendBufferSize: size: float -> unit
        abstract getRecvBufferSize: unit -> float
        abstract getSendBufferSize: unit -> float
        /// events.EventEmitter
        /// 1. close
        /// 2. error
        /// 3. listening
        /// 4. message
        abstract addListener: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> Socket
        [<Emit "$0.addListener('close',$1)">] abstract addListener_close: listener: (unit -> unit) -> Socket
        [<Emit "$0.addListener('error',$1)">] abstract addListener_error: listener: (Error -> unit) -> Socket
        [<Emit "$0.addListener('listening',$1)">] abstract addListener_listening: listener: (unit -> unit) -> Socket
        [<Emit "$0.addListener('message',$1)">] abstract addListener_message: listener: (Buffer -> AddressInfo -> unit) -> Socket
        abstract emit: ``event``: U2<string, Symbol> * [<ParamArray>] args: ResizeArray<obj option> -> bool
        [<Emit "$0.emit('close')">] abstract emit_close: unit -> bool
        [<Emit "$0.emit('error',$1)">] abstract emit_error: err: Error -> bool
        [<Emit "$0.emit('listening')">] abstract emit_listening: unit -> bool
        [<Emit "$0.emit('message',$1,$2)">] abstract emit_message: msg: Buffer * rinfo: AddressInfo -> bool
        abstract on: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> Socket
        [<Emit "$0.on('close',$1)">] abstract on_close: listener: (unit -> unit) -> Socket
        [<Emit "$0.on('error',$1)">] abstract on_error: listener: (Error -> unit) -> Socket
        [<Emit "$0.on('listening',$1)">] abstract on_listening: listener: (unit -> unit) -> Socket
        [<Emit "$0.on('message',$1)">] abstract on_message: listener: (Buffer -> AddressInfo -> unit) -> Socket
        abstract once: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> Socket
        [<Emit "$0.once('close',$1)">] abstract once_close: listener: (unit -> unit) -> Socket
        [<Emit "$0.once('error',$1)">] abstract once_error: listener: (Error -> unit) -> Socket
        [<Emit "$0.once('listening',$1)">] abstract once_listening: listener: (unit -> unit) -> Socket
        [<Emit "$0.once('message',$1)">] abstract once_message: listener: (Buffer -> AddressInfo -> unit) -> Socket
        abstract prependListener: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> Socket
        [<Emit "$0.prependListener('close',$1)">] abstract prependListener_close: listener: (unit -> unit) -> Socket
        [<Emit "$0.prependListener('error',$1)">] abstract prependListener_error: listener: (Error -> unit) -> Socket
        [<Emit "$0.prependListener('listening',$1)">] abstract prependListener_listening: listener: (unit -> unit) -> Socket
        [<Emit "$0.prependListener('message',$1)">] abstract prependListener_message: listener: (Buffer -> AddressInfo -> unit) -> Socket
        abstract prependOnceListener: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> Socket
        [<Emit "$0.prependOnceListener('close',$1)">] abstract prependOnceListener_close: listener: (unit -> unit) -> Socket
        [<Emit "$0.prependOnceListener('error',$1)">] abstract prependOnceListener_error: listener: (Error -> unit) -> Socket
        [<Emit "$0.prependOnceListener('listening',$1)">] abstract prependOnceListener_listening: listener: (unit -> unit) -> Socket
        [<Emit "$0.prependOnceListener('message',$1)">] abstract prependOnceListener_message: listener: (Buffer -> AddressInfo -> unit) -> Socket

    type [<AllowNullLiteral>] SocketStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> Socket

module Fs =
    type URL = Url.URL
    let [<Import("access","fs")>] access: Access.IExports = jsNative
    let [<Import("appendFile","fs")>] appendFile: AppendFile.IExports = jsNative
    let [<Import("chmod","fs")>] chmod: Chmod.IExports = jsNative
    let [<Import("chown","fs")>] chown: Chown.IExports = jsNative
    let [<Import("close","fs")>] close: Close.IExports = jsNative
    let [<Import("copyFile","fs")>] copyFile: CopyFile.IExports = jsNative
    let [<Import("exists","fs")>] exists: Exists.IExports = jsNative
    let [<Import("fchmod","fs")>] fchmod: Fchmod.IExports = jsNative
    let [<Import("fchown","fs")>] fchown: Fchown.IExports = jsNative
    let [<Import("fdatasync","fs")>] fdatasync: Fdatasync.IExports = jsNative
    let [<Import("fstat","fs")>] fstat: Fstat.IExports = jsNative
    let [<Import("fsync","fs")>] fsync: Fsync.IExports = jsNative
    let [<Import("ftruncate","fs")>] ftruncate: Ftruncate.IExports = jsNative
    let [<Import("futimes","fs")>] futimes: Futimes.IExports = jsNative
    let [<Import("lchmod","fs")>] lchmod: Lchmod.IExports = jsNative
    let [<Import("lchown","fs")>] lchown: Lchown.IExports = jsNative
    let [<Import("link","fs")>] link: Link.IExports = jsNative
    let [<Import("lstat","fs")>] lstat: Lstat.IExports = jsNative
    let [<Import("mkdir","fs")>] mkdir: Mkdir.IExports = jsNative
    let [<Import("mkdtemp","fs")>] mkdtemp: Mkdtemp.IExports = jsNative
    let [<Import("open","fs")>] ``open``: Open.IExports = jsNative
    let [<Import("read","fs")>] read: Read.IExports = jsNative
    let [<Import("readFile","fs")>] readFile: ReadFile.IExports = jsNative
    let [<Import("readdir","fs")>] readdir: Readdir.IExports = jsNative
    let [<Import("readlink","fs")>] readlink: Readlink.IExports = jsNative
    let [<Import("realpath","fs")>] realpath: Realpath.IExports = jsNative
    let [<Import("rename","fs")>] rename: Rename.IExports = jsNative
    let [<Import("rmdir","fs")>] rmdir: Rmdir.IExports = jsNative
    let [<Import("stat","fs")>] stat: Stat.IExports = jsNative
    let [<Import("symlink","fs")>] symlink: Symlink.IExports = jsNative
    let [<Import("truncate","fs")>] truncate: Truncate.IExports = jsNative
    let [<Import("unlink","fs")>] unlink: Unlink.IExports = jsNative
    let [<Import("utimes","fs")>] utimes: Utimes.IExports = jsNative
    let [<Import("write","fs")>] write: Write.IExports = jsNative
    let [<Import("writeFile","fs")>] writeFile: WriteFile.IExports = jsNative

    type [<AllowNullLiteral>] IExports =
        abstract Stats: StatsStatic
        abstract ReadStream: ReadStreamStatic
        abstract WriteStream: WriteStreamStatic
        /// <summary>Asynchronous rename(2) - Change the name or location of a file or directory.</summary>
        /// <param name="oldPath">A path to a file. If a URL is provided, it must use the `file:` protocol.
        /// URL support is _experimental_.</param>
        /// <param name="newPath">A path to a file. If a URL is provided, it must use the `file:` protocol.
        /// URL support is _experimental_.</param>
        abstract rename: oldPath: PathLike * newPath: PathLike * callback: (NodeJS.ErrnoException -> unit) -> unit
        /// <summary>Synchronous rename(2) - Change the name or location of a file or directory.</summary>
        /// <param name="oldPath">A path to a file. If a URL is provided, it must use the `file:` protocol.
        /// URL support is _experimental_.</param>
        /// <param name="newPath">A path to a file. If a URL is provided, it must use the `file:` protocol.
        /// URL support is _experimental_.</param>
        abstract renameSync: oldPath: PathLike * newPath: PathLike -> unit
        /// <summary>Asynchronous truncate(2) - Truncate a file to a specified length.</summary>
        /// <param name="path">A path to a file. If a URL is provided, it must use the `file:` protocol.</param>
        /// <param name="len">If not specified, defaults to `0`.</param>
        abstract truncate: path: PathLike * len: float option * callback: (NodeJS.ErrnoException -> unit) -> unit
        /// <summary>Asynchronous truncate(2) - Truncate a file to a specified length.</summary>
        /// <param name="path">A path to a file. If a URL is provided, it must use the `file:` protocol.
        /// URL support is _experimental_.</param>
        abstract truncate: path: PathLike * callback: (NodeJS.ErrnoException -> unit) -> unit
        /// <summary>Synchronous truncate(2) - Truncate a file to a specified length.</summary>
        /// <param name="path">A path to a file. If a URL is provided, it must use the `file:` protocol.</param>
        /// <param name="len">If not specified, defaults to `0`.</param>
        abstract truncateSync: path: PathLike * ?len: float option -> unit
        /// <summary>Asynchronous ftruncate(2) - Truncate a file to a specified length.</summary>
        /// <param name="fd">A file descriptor.</param>
        /// <param name="len">If not specified, defaults to `0`.</param>
        abstract ftruncate: fd: float * len: float option * callback: (NodeJS.ErrnoException -> unit) -> unit
        /// <summary>Asynchronous ftruncate(2) - Truncate a file to a specified length.</summary>
        /// <param name="fd">A file descriptor.</param>
        abstract ftruncate: fd: float * callback: (NodeJS.ErrnoException -> unit) -> unit
        /// <summary>Synchronous ftruncate(2) - Truncate a file to a specified length.</summary>
        /// <param name="fd">A file descriptor.</param>
        /// <param name="len">If not specified, defaults to `0`.</param>
        abstract ftruncateSync: fd: float * ?len: float option -> unit
        /// <summary>Asynchronous chown(2) - Change ownership of a file.</summary>
        /// <param name="path">A path to a file. If a URL is provided, it must use the `file:` protocol.</param>
        abstract chown: path: PathLike * uid: float * gid: float * callback: (NodeJS.ErrnoException -> unit) -> unit
        /// <summary>Synchronous chown(2) - Change ownership of a file.</summary>
        /// <param name="path">A path to a file. If a URL is provided, it must use the `file:` protocol.</param>
        abstract chownSync: path: PathLike * uid: float * gid: float -> unit
        /// <summary>Asynchronous fchown(2) - Change ownership of a file.</summary>
        /// <param name="fd">A file descriptor.</param>
        abstract fchown: fd: float * uid: float * gid: float * callback: (NodeJS.ErrnoException -> unit) -> unit
        /// <summary>Synchronous fchown(2) - Change ownership of a file.</summary>
        /// <param name="fd">A file descriptor.</param>
        abstract fchownSync: fd: float * uid: float * gid: float -> unit
        /// <summary>Asynchronous lchown(2) - Change ownership of a file. Does not dereference symbolic links.</summary>
        /// <param name="path">A path to a file. If a URL is provided, it must use the `file:` protocol.</param>
        abstract lchown: path: PathLike * uid: float * gid: float * callback: (NodeJS.ErrnoException -> unit) -> unit
        /// <summary>Synchronous lchown(2) - Change ownership of a file. Does not dereference symbolic links.</summary>
        /// <param name="path">A path to a file. If a URL is provided, it must use the `file:` protocol.</param>
        abstract lchownSync: path: PathLike * uid: float * gid: float -> unit
        /// <summary>Asynchronous chmod(2) - Change permissions of a file.</summary>
        /// <param name="path">A path to a file. If a URL is provided, it must use the `file:` protocol.</param>
        /// <param name="mode">A file mode. If a string is passed, it is parsed as an octal integer.</param>
        abstract chmod: path: PathLike * mode: U2<string, float> * callback: (NodeJS.ErrnoException -> unit) -> unit
        /// <summary>Synchronous chmod(2) - Change permissions of a file.</summary>
        /// <param name="path">A path to a file. If a URL is provided, it must use the `file:` protocol.</param>
        /// <param name="mode">A file mode. If a string is passed, it is parsed as an octal integer.</param>
        abstract chmodSync: path: PathLike * mode: U2<string, float> -> unit
        /// <summary>Asynchronous fchmod(2) - Change permissions of a file.</summary>
        /// <param name="fd">A file descriptor.</param>
        /// <param name="mode">A file mode. If a string is passed, it is parsed as an octal integer.</param>
        abstract fchmod: fd: float * mode: U2<string, float> * callback: (NodeJS.ErrnoException -> unit) -> unit
        /// <summary>Synchronous fchmod(2) - Change permissions of a file.</summary>
        /// <param name="fd">A file descriptor.</param>
        /// <param name="mode">A file mode. If a string is passed, it is parsed as an octal integer.</param>
        abstract fchmodSync: fd: float * mode: U2<string, float> -> unit
        /// <summary>Asynchronous lchmod(2) - Change permissions of a file. Does not dereference symbolic links.</summary>
        /// <param name="path">A path to a file. If a URL is provided, it must use the `file:` protocol.</param>
        /// <param name="mode">A file mode. If a string is passed, it is parsed as an octal integer.</param>
        abstract lchmod: path: PathLike * mode: U2<string, float> * callback: (NodeJS.ErrnoException -> unit) -> unit
        /// <summary>Synchronous lchmod(2) - Change permissions of a file. Does not dereference symbolic links.</summary>
        /// <param name="path">A path to a file. If a URL is provided, it must use the `file:` protocol.</param>
        /// <param name="mode">A file mode. If a string is passed, it is parsed as an octal integer.</param>
        abstract lchmodSync: path: PathLike * mode: U2<string, float> -> unit
        /// <summary>Asynchronous stat(2) - Get file status.</summary>
        /// <param name="path">A path to a file. If a URL is provided, it must use the `file:` protocol.</param>
        abstract stat: path: PathLike * callback: (NodeJS.ErrnoException -> Stats -> unit) -> unit
        /// <summary>Synchronous stat(2) - Get file status.</summary>
        /// <param name="path">A path to a file. If a URL is provided, it must use the `file:` protocol.</param>
        abstract statSync: path: PathLike -> Stats
        /// <summary>Asynchronous fstat(2) - Get file status.</summary>
        /// <param name="fd">A file descriptor.</param>
        abstract fstat: fd: float * callback: (NodeJS.ErrnoException -> Stats -> unit) -> unit
        /// <summary>Synchronous fstat(2) - Get file status.</summary>
        /// <param name="fd">A file descriptor.</param>
        abstract fstatSync: fd: float -> Stats
        /// <summary>Asynchronous lstat(2) - Get file status. Does not dereference symbolic links.</summary>
        /// <param name="path">A path to a file. If a URL is provided, it must use the `file:` protocol.</param>
        abstract lstat: path: PathLike * callback: (NodeJS.ErrnoException -> Stats -> unit) -> unit
        /// <summary>Synchronous lstat(2) - Get file status. Does not dereference symbolic links.</summary>
        /// <param name="path">A path to a file. If a URL is provided, it must use the `file:` protocol.</param>
        abstract lstatSync: path: PathLike -> Stats
        /// <summary>Asynchronous link(2) - Create a new link (also known as a hard link) to an existing file.</summary>
        /// <param name="existingPath">A path to a file. If a URL is provided, it must use the `file:` protocol.</param>
        /// <param name="newPath">A path to a file. If a URL is provided, it must use the `file:` protocol.</param>
        abstract link: existingPath: PathLike * newPath: PathLike * callback: (NodeJS.ErrnoException -> unit) -> unit
        /// <summary>Synchronous link(2) - Create a new link (also known as a hard link) to an existing file.</summary>
        /// <param name="existingPath">A path to a file. If a URL is provided, it must use the `file:` protocol.</param>
        /// <param name="newPath">A path to a file. If a URL is provided, it must use the `file:` protocol.</param>
        abstract linkSync: existingPath: PathLike * newPath: PathLike -> unit
        /// <summary>Asynchronous symlink(2) - Create a new symbolic link to an existing file.</summary>
        /// <param name="target">A path to an existing file. If a URL is provided, it must use the `file:` protocol.</param>
        /// <param name="path">A path to the new symlink. If a URL is provided, it must use the `file:` protocol.</param>
        /// <param name="type">May be set to `'dir'`, `'file'`, or `'junction'` (default is `'file'`) and is only available on Windows (ignored on other platforms).
        /// When using `'junction'`, the `target` argument will automatically be normalized to an absolute path.</param>
        abstract symlink: target: PathLike * path: PathLike * ``type``: Symlink.Type option * callback: (NodeJS.ErrnoException -> unit) -> unit
        /// <summary>Asynchronous symlink(2) - Create a new symbolic link to an existing file.</summary>
        /// <param name="target">A path to an existing file. If a URL is provided, it must use the `file:` protocol.</param>
        /// <param name="path">A path to the new symlink. If a URL is provided, it must use the `file:` protocol.</param>
        abstract symlink: target: PathLike * path: PathLike * callback: (NodeJS.ErrnoException -> unit) -> unit
        /// <summary>Synchronous symlink(2) - Create a new symbolic link to an existing file.</summary>
        /// <param name="target">A path to an existing file. If a URL is provided, it must use the `file:` protocol.</param>
        /// <param name="path">A path to the new symlink. If a URL is provided, it must use the `file:` protocol.</param>
        /// <param name="type">May be set to `'dir'`, `'file'`, or `'junction'` (default is `'file'`) and is only available on Windows (ignored on other platforms).
        /// When using `'junction'`, the `target` argument will automatically be normalized to an absolute path.</param>
        abstract symlinkSync: target: PathLike * path: PathLike * ?``type``: Symlink.Type option -> unit
        /// <summary>Asynchronous readlink(2) - read value of a symbolic link.</summary>
        /// <param name="path">A path to a file. If a URL is provided, it must use the `file:` protocol.</param>
        /// <param name="options">The encoding (or an object specifying the encoding), used as the encoding of the result. If not provided, `'utf8'` is used.</param>
        abstract readlink: path: PathLike * options: U2<obj, BufferEncoding> option * callback: (NodeJS.ErrnoException -> string -> unit) -> unit
        /// <summary>Asynchronous readlink(2) - read value of a symbolic link.</summary>
        /// <param name="path">A path to a file. If a URL is provided, it must use the `file:` protocol.</param>
        /// <param name="options">The encoding (or an object specifying the encoding), used as the encoding of the result. If not provided, `'utf8'` is used.</param>
        abstract readlink: path: PathLike * options: U2<obj, string> * callback: (NodeJS.ErrnoException -> Buffer -> unit) -> unit
        /// <summary>Asynchronous readlink(2) - read value of a symbolic link.</summary>
        /// <param name="path">A path to a file. If a URL is provided, it must use the `file:` protocol.</param>
        /// <param name="options">The encoding (or an object specifying the encoding), used as the encoding of the result. If not provided, `'utf8'` is used.</param>
        abstract readlink: path: PathLike * options: U2<obj, string> option * callback: (NodeJS.ErrnoException -> U2<string, Buffer> -> unit) -> unit
        /// <summary>Asynchronous readlink(2) - read value of a symbolic link.</summary>
        /// <param name="path">A path to a file. If a URL is provided, it must use the `file:` protocol.</param>
        abstract readlink: path: PathLike * callback: (NodeJS.ErrnoException -> string -> unit) -> unit
        /// <summary>Synchronous readlink(2) - read value of a symbolic link.</summary>
        /// <param name="path">A path to a file. If a URL is provided, it must use the `file:` protocol.</param>
        /// <param name="options">The encoding (or an object specifying the encoding), used as the encoding of the result. If not provided, `'utf8'` is used.</param>
        abstract readlinkSync: path: PathLike * ?options: U2<obj, BufferEncoding> option -> string
        /// <summary>Synchronous readlink(2) - read value of a symbolic link.</summary>
        /// <param name="path">A path to a file. If a URL is provided, it must use the `file:` protocol.</param>
        /// <param name="options">The encoding (or an object specifying the encoding), used as the encoding of the result. If not provided, `'utf8'` is used.</param>
        abstract readlinkSync: path: PathLike * options: U2<obj, string> -> Buffer
        /// <summary>Synchronous readlink(2) - read value of a symbolic link.</summary>
        /// <param name="path">A path to a file. If a URL is provided, it must use the `file:` protocol.</param>
        /// <param name="options">The encoding (or an object specifying the encoding), used as the encoding of the result. If not provided, `'utf8'` is used.</param>
        abstract readlinkSync: path: PathLike * ?options: U2<obj, string> option -> U2<string, Buffer>
        /// <summary>Asynchronous realpath(3) - return the canonicalized absolute pathname.</summary>
        /// <param name="path">A path to a file. If a URL is provided, it must use the `file:` protocol.</param>
        /// <param name="options">The encoding (or an object specifying the encoding), used as the encoding of the result. If not provided, `'utf8'` is used.</param>
        abstract realpath: path: PathLike * options: U2<obj, BufferEncoding> option * callback: (NodeJS.ErrnoException -> string -> unit) -> unit
        /// <summary>Asynchronous realpath(3) - return the canonicalized absolute pathname.</summary>
        /// <param name="path">A path to a file. If a URL is provided, it must use the `file:` protocol.</param>
        /// <param name="options">The encoding (or an object specifying the encoding), used as the encoding of the result. If not provided, `'utf8'` is used.</param>
        abstract realpath: path: PathLike * options: U2<obj, string> * callback: (NodeJS.ErrnoException -> Buffer -> unit) -> unit
        /// <summary>Asynchronous realpath(3) - return the canonicalized absolute pathname.</summary>
        /// <param name="path">A path to a file. If a URL is provided, it must use the `file:` protocol.</param>
        /// <param name="options">The encoding (or an object specifying the encoding), used as the encoding of the result. If not provided, `'utf8'` is used.</param>
        abstract realpath: path: PathLike * options: U2<obj, string> option * callback: (NodeJS.ErrnoException -> U2<string, Buffer> -> unit) -> unit
        /// <summary>Asynchronous realpath(3) - return the canonicalized absolute pathname.</summary>
        /// <param name="path">A path to a file. If a URL is provided, it must use the `file:` protocol.</param>
        abstract realpath: path: PathLike * callback: (NodeJS.ErrnoException -> string -> unit) -> unit
        /// <summary>Synchronous realpath(3) - return the canonicalized absolute pathname.</summary>
        /// <param name="path">A path to a file. If a URL is provided, it must use the `file:` protocol.</param>
        /// <param name="options">The encoding (or an object specifying the encoding), used as the encoding of the result. If not provided, `'utf8'` is used.</param>
        abstract realpathSync: path: PathLike * ?options: U2<obj, BufferEncoding> option -> string
        /// <summary>Synchronous realpath(3) - return the canonicalized absolute pathname.</summary>
        /// <param name="path">A path to a file. If a URL is provided, it must use the `file:` protocol.</param>
        /// <param name="options">The encoding (or an object specifying the encoding), used as the encoding of the result. If not provided, `'utf8'` is used.</param>
        abstract realpathSync: path: PathLike * options: U2<obj, string> -> Buffer
        /// <summary>Synchronous realpath(3) - return the canonicalized absolute pathname.</summary>
        /// <param name="path">A path to a file. If a URL is provided, it must use the `file:` protocol.</param>
        /// <param name="options">The encoding (or an object specifying the encoding), used as the encoding of the result. If not provided, `'utf8'` is used.</param>
        abstract realpathSync: path: PathLike * ?options: U2<obj, string> option -> U2<string, Buffer>
        /// <summary>Asynchronous unlink(2) - delete a name and possibly the file it refers to.</summary>
        /// <param name="path">A path to a file. If a URL is provided, it must use the `file:` protocol.</param>
        abstract unlink: path: PathLike * callback: (NodeJS.ErrnoException -> unit) -> unit
        /// <summary>Synchronous unlink(2) - delete a name and possibly the file it refers to.</summary>
        /// <param name="path">A path to a file. If a URL is provided, it must use the `file:` protocol.</param>
        abstract unlinkSync: path: PathLike -> unit
        /// <summary>Asynchronous rmdir(2) - delete a directory.</summary>
        /// <param name="path">A path to a file. If a URL is provided, it must use the `file:` protocol.</param>
        abstract rmdir: path: PathLike * callback: (NodeJS.ErrnoException -> unit) -> unit
        /// <summary>Synchronous rmdir(2) - delete a directory.</summary>
        /// <param name="path">A path to a file. If a URL is provided, it must use the `file:` protocol.</param>
        abstract rmdirSync: path: PathLike -> unit
        /// <summary>Asynchronous mkdir(2) - create a directory.</summary>
        /// <param name="path">A path to a file. If a URL is provided, it must use the `file:` protocol.</param>
        /// <param name="mode">A file mode. If a string is passed, it is parsed as an octal integer. If not specified, defaults to `0o777`.</param>
        abstract mkdir: path: PathLike * mode: U2<float, string> option * callback: (NodeJS.ErrnoException -> unit) -> unit
        /// <summary>Asynchronous mkdir(2) - create a directory with a mode of `0o777`.</summary>
        /// <param name="path">A path to a file. If a URL is provided, it must use the `file:` protocol.</param>
        abstract mkdir: path: PathLike * callback: (NodeJS.ErrnoException -> unit) -> unit
        /// <summary>Synchronous mkdir(2) - create a directory.</summary>
        /// <param name="path">A path to a file. If a URL is provided, it must use the `file:` protocol.</param>
        /// <param name="mode">A file mode. If a string is passed, it is parsed as an octal integer. If not specified, defaults to `0o777`.</param>
        abstract mkdirSync: path: PathLike * ?mode: U2<float, string> option -> unit
        /// <summary>Asynchronously creates a unique temporary directory.
        /// Generates six random characters to be appended behind a required prefix to create a unique temporary directory.</summary>
        /// <param name="options">The encoding (or an object specifying the encoding), used as the encoding of the result. If not provided, `'utf8'` is used.</param>
        abstract mkdtemp: prefix: string * options: U2<obj, BufferEncoding> option * callback: (NodeJS.ErrnoException -> string -> unit) -> unit
        /// <summary>Asynchronously creates a unique temporary directory.
        /// Generates six random characters to be appended behind a required prefix to create a unique temporary directory.</summary>
        /// <param name="options">The encoding (or an object specifying the encoding), used as the encoding of the result. If not provided, `'utf8'` is used.</param>
        abstract mkdtemp: prefix: string * options: U2<string, obj> * callback: (NodeJS.ErrnoException -> Buffer -> unit) -> unit
        /// <summary>Asynchronously creates a unique temporary directory.
        /// Generates six random characters to be appended behind a required prefix to create a unique temporary directory.</summary>
        /// <param name="options">The encoding (or an object specifying the encoding), used as the encoding of the result. If not provided, `'utf8'` is used.</param>
        abstract mkdtemp: prefix: string * options: U2<obj, string> option * callback: (NodeJS.ErrnoException -> U2<string, Buffer> -> unit) -> unit
        /// Asynchronously creates a unique temporary directory.
        /// Generates six random characters to be appended behind a required prefix to create a unique temporary directory.
        abstract mkdtemp: prefix: string * callback: (NodeJS.ErrnoException -> string -> unit) -> unit
        /// <summary>Synchronously creates a unique temporary directory.
        /// Generates six random characters to be appended behind a required prefix to create a unique temporary directory.</summary>
        /// <param name="options">The encoding (or an object specifying the encoding), used as the encoding of the result. If not provided, `'utf8'` is used.</param>
        abstract mkdtempSync: prefix: string * ?options: U2<obj, BufferEncoding> option -> string
        /// <summary>Synchronously creates a unique temporary directory.
        /// Generates six random characters to be appended behind a required prefix to create a unique temporary directory.</summary>
        /// <param name="options">The encoding (or an object specifying the encoding), used as the encoding of the result. If not provided, `'utf8'` is used.</param>
        abstract mkdtempSync: prefix: string * options: U2<obj, string> -> Buffer
        /// <summary>Synchronously creates a unique temporary directory.
        /// Generates six random characters to be appended behind a required prefix to create a unique temporary directory.</summary>
        /// <param name="options">The encoding (or an object specifying the encoding), used as the encoding of the result. If not provided, `'utf8'` is used.</param>
        abstract mkdtempSync: prefix: string * ?options: U2<obj, string> option -> U2<string, Buffer>
        /// <summary>Asynchronous readdir(3) - read a directory.</summary>
        /// <param name="path">A path to a file. If a URL is provided, it must use the `file:` protocol.</param>
        /// <param name="options">The encoding (or an object specifying the encoding), used as the encoding of the result. If not provided, `'utf8'` is used.</param>
        abstract readdir: path: PathLike * options: U2<obj, BufferEncoding> option * callback: (NodeJS.ErrnoException -> ResizeArray<string> -> unit) -> unit
        /// <summary>Asynchronous readdir(3) - read a directory.</summary>
        /// <param name="path">A path to a file. If a URL is provided, it must use the `file:` protocol.</param>
        /// <param name="options">The encoding (or an object specifying the encoding), used as the encoding of the result. If not provided, `'utf8'` is used.</param>
        abstract readdir: path: PathLike * options: U2<obj, string> * callback: (NodeJS.ErrnoException -> ResizeArray<Buffer> -> unit) -> unit
        /// <summary>Asynchronous readdir(3) - read a directory.</summary>
        /// <param name="path">A path to a file. If a URL is provided, it must use the `file:` protocol.</param>
        /// <param name="options">The encoding (or an object specifying the encoding), used as the encoding of the result. If not provided, `'utf8'` is used.</param>
        abstract readdir: path: PathLike * options: U2<obj, string> option * callback: (NodeJS.ErrnoException -> U2<ResizeArray<string>, ResizeArray<Buffer>> -> unit) -> unit
        /// <summary>Asynchronous readdir(3) - read a directory.</summary>
        /// <param name="path">A path to a file. If a URL is provided, it must use the `file:` protocol.</param>
        abstract readdir: path: PathLike * callback: (NodeJS.ErrnoException -> ResizeArray<string> -> unit) -> unit
        /// <summary>Synchronous readdir(3) - read a directory.</summary>
        /// <param name="path">A path to a file. If a URL is provided, it must use the `file:` protocol.</param>
        /// <param name="options">The encoding (or an object specifying the encoding), used as the encoding of the result. If not provided, `'utf8'` is used.</param>
        abstract readdirSync: path: PathLike * ?options: U2<obj, BufferEncoding> option -> ResizeArray<string>
        /// <summary>Synchronous readdir(3) - read a directory.</summary>
        /// <param name="path">A path to a file. If a URL is provided, it must use the `file:` protocol.</param>
        /// <param name="options">The encoding (or an object specifying the encoding), used as the encoding of the result. If not provided, `'utf8'` is used.</param>
        abstract readdirSync: path: PathLike * options: U2<obj, string> -> ResizeArray<Buffer>
        /// <summary>Synchronous readdir(3) - read a directory.</summary>
        /// <param name="path">A path to a file. If a URL is provided, it must use the `file:` protocol.</param>
        /// <param name="options">The encoding (or an object specifying the encoding), used as the encoding of the result. If not provided, `'utf8'` is used.</param>
        abstract readdirSync: path: PathLike * ?options: U2<obj, string> option -> U2<ResizeArray<string>, ResizeArray<Buffer>>
        /// <summary>Asynchronous close(2) - close a file descriptor.</summary>
        /// <param name="fd">A file descriptor.</param>
        abstract close: fd: float * callback: (NodeJS.ErrnoException -> unit) -> unit
        /// <summary>Synchronous close(2) - close a file descriptor.</summary>
        /// <param name="fd">A file descriptor.</param>
        abstract closeSync: fd: float -> unit
        /// <summary>Asynchronous open(2) - open and possibly create a file.</summary>
        /// <param name="path">A path to a file. If a URL is provided, it must use the `file:` protocol.</param>
        /// <param name="mode">A file mode. If a string is passed, it is parsed as an octal integer. If not supplied, defaults to `0o666`.</param>
        abstract ``open``: path: PathLike * flags: U2<string, float> * mode: U2<string, float> option * callback: (NodeJS.ErrnoException -> float -> unit) -> unit
        /// <summary>Asynchronous open(2) - open and possibly create a file. If the file is created, its mode will be `0o666`.</summary>
        /// <param name="path">A path to a file. If a URL is provided, it must use the `file:` protocol.</param>
        abstract ``open``: path: PathLike * flags: U2<string, float> * callback: (NodeJS.ErrnoException -> float -> unit) -> unit
        /// <summary>Synchronous open(2) - open and possibly create a file, returning a file descriptor..</summary>
        /// <param name="path">A path to a file. If a URL is provided, it must use the `file:` protocol.</param>
        /// <param name="mode">A file mode. If a string is passed, it is parsed as an octal integer. If not supplied, defaults to `0o666`.</param>
        abstract openSync: path: PathLike * flags: U2<string, float> * ?mode: U2<string, float> option -> float
        /// <summary>Asynchronously change file timestamps of the file referenced by the supplied path.</summary>
        /// <param name="path">A path to a file. If a URL is provided, it must use the `file:` protocol.</param>
        /// <param name="atime">The last access time. If a string is provided, it will be coerced to number.</param>
        /// <param name="mtime">The last modified time. If a string is provided, it will be coerced to number.</param>
        abstract utimes: path: PathLike * atime: U3<string, float, DateTime> * mtime: U3<string, float, DateTime> * callback: (NodeJS.ErrnoException -> unit) -> unit
        /// <summary>Synchronously change file timestamps of the file referenced by the supplied path.</summary>
        /// <param name="path">A path to a file. If a URL is provided, it must use the `file:` protocol.</param>
        /// <param name="atime">The last access time. If a string is provided, it will be coerced to number.</param>
        /// <param name="mtime">The last modified time. If a string is provided, it will be coerced to number.</param>
        abstract utimesSync: path: PathLike * atime: U3<string, float, DateTime> * mtime: U3<string, float, DateTime> -> unit
        /// <summary>Asynchronously change file timestamps of the file referenced by the supplied file descriptor.</summary>
        /// <param name="fd">A file descriptor.</param>
        /// <param name="atime">The last access time. If a string is provided, it will be coerced to number.</param>
        /// <param name="mtime">The last modified time. If a string is provided, it will be coerced to number.</param>
        abstract futimes: fd: float * atime: U3<string, float, DateTime> * mtime: U3<string, float, DateTime> * callback: (NodeJS.ErrnoException -> unit) -> unit
        /// <summary>Synchronously change file timestamps of the file referenced by the supplied file descriptor.</summary>
        /// <param name="fd">A file descriptor.</param>
        /// <param name="atime">The last access time. If a string is provided, it will be coerced to number.</param>
        /// <param name="mtime">The last modified time. If a string is provided, it will be coerced to number.</param>
        abstract futimesSync: fd: float * atime: U3<string, float, DateTime> * mtime: U3<string, float, DateTime> -> unit
        /// <summary>Asynchronous fsync(2) - synchronize a file's in-core state with the underlying storage device.</summary>
        /// <param name="fd">A file descriptor.</param>
        abstract fsync: fd: float * callback: (NodeJS.ErrnoException -> unit) -> unit
        /// <summary>Synchronous fsync(2) - synchronize a file's in-core state with the underlying storage device.</summary>
        /// <param name="fd">A file descriptor.</param>
        abstract fsyncSync: fd: float -> unit
        /// <summary>Asynchronously writes `buffer` to the file referenced by the supplied file descriptor.</summary>
        /// <param name="fd">A file descriptor.</param>
        /// <param name="offset">The part of the buffer to be written. If not supplied, defaults to `0`.</param>
        /// <param name="length">The number of bytes to write. If not supplied, defaults to `buffer.length - offset`.</param>
        /// <param name="position">The offset from the beginning of the file where this data should be written. If not supplied, defaults to the current position.</param>
        abstract write: fd: float * buffer: 'TBuffer * offset: float option * length: float option * position: float option * callback: (NodeJS.ErrnoException -> float -> 'TBuffer -> unit) -> unit
        /// <summary>Asynchronously writes `buffer` to the file referenced by the supplied file descriptor.</summary>
        /// <param name="fd">A file descriptor.</param>
        /// <param name="offset">The part of the buffer to be written. If not supplied, defaults to `0`.</param>
        /// <param name="length">The number of bytes to write. If not supplied, defaults to `buffer.length - offset`.</param>
        abstract write: fd: float * buffer: 'TBuffer * offset: float option * length: float option * callback: (NodeJS.ErrnoException -> float -> 'TBuffer -> unit) -> unit
        /// <summary>Asynchronously writes `buffer` to the file referenced by the supplied file descriptor.</summary>
        /// <param name="fd">A file descriptor.</param>
        /// <param name="offset">The part of the buffer to be written. If not supplied, defaults to `0`.</param>
        abstract write: fd: float * buffer: 'TBuffer * offset: float option * callback: (NodeJS.ErrnoException -> float -> 'TBuffer -> unit) -> unit
        /// <summary>Asynchronously writes `buffer` to the file referenced by the supplied file descriptor.</summary>
        /// <param name="fd">A file descriptor.</param>
        abstract write: fd: float * buffer: 'TBuffer * callback: (NodeJS.ErrnoException -> float -> 'TBuffer -> unit) -> unit
        /// <summary>Asynchronously writes `string` to the file referenced by the supplied file descriptor.</summary>
        /// <param name="fd">A file descriptor.</param>
        /// <param name="string">A string to write. If something other than a string is supplied it will be coerced to a string.</param>
        /// <param name="position">The offset from the beginning of the file where this data should be written. If not supplied, defaults to the current position.</param>
        /// <param name="encoding">The expected string encoding.</param>
        abstract write: fd: float * string: obj option * position: float option * encoding: string option * callback: (NodeJS.ErrnoException -> float -> string -> unit) -> unit
        /// <summary>Asynchronously writes `string` to the file referenced by the supplied file descriptor.</summary>
        /// <param name="fd">A file descriptor.</param>
        /// <param name="string">A string to write. If something other than a string is supplied it will be coerced to a string.</param>
        /// <param name="position">The offset from the beginning of the file where this data should be written. If not supplied, defaults to the current position.</param>
        abstract write: fd: float * string: obj option * position: float option * callback: (NodeJS.ErrnoException -> float -> string -> unit) -> unit
        /// <summary>Asynchronously writes `string` to the file referenced by the supplied file descriptor.</summary>
        /// <param name="fd">A file descriptor.</param>
        /// <param name="string">A string to write. If something other than a string is supplied it will be coerced to a string.</param>
        abstract write: fd: float * string: obj option * callback: (NodeJS.ErrnoException -> float -> string -> unit) -> unit
        /// <summary>Synchronously writes `buffer` to the file referenced by the supplied file descriptor, returning the number of bytes written.</summary>
        /// <param name="fd">A file descriptor.</param>
        /// <param name="offset">The part of the buffer to be written. If not supplied, defaults to `0`.</param>
        /// <param name="length">The number of bytes to write. If not supplied, defaults to `buffer.length - offset`.</param>
        /// <param name="position">The offset from the beginning of the file where this data should be written. If not supplied, defaults to the current position.</param>
        abstract writeSync: fd: float * buffer: U2<Buffer, Uint8Array> * ?offset: float option * ?length: float option * ?position: float option -> float
        /// <summary>Synchronously writes `string` to the file referenced by the supplied file descriptor, returning the number of bytes written.</summary>
        /// <param name="fd">A file descriptor.</param>
        /// <param name="string">A string to write. If something other than a string is supplied it will be coerced to a string.</param>
        /// <param name="position">The offset from the beginning of the file where this data should be written. If not supplied, defaults to the current position.</param>
        /// <param name="encoding">The expected string encoding.</param>
        abstract writeSync: fd: float * string: obj option * ?position: float option * ?encoding: string option -> float
        /// <summary>Asynchronously reads data from the file referenced by the supplied file descriptor.</summary>
        /// <param name="fd">A file descriptor.</param>
        /// <param name="buffer">The buffer that the data will be written to.</param>
        /// <param name="offset">The offset in the buffer at which to start writing.</param>
        /// <param name="length">The number of bytes to read.</param>
        /// <param name="position">The offset from the beginning of the file from which data should be read. If `null`, data will be read from the current position.</param>
        abstract read: fd: float * buffer: 'TBuffer * offset: float * length: float * position: float option * ?callback: (NodeJS.ErrnoException -> float -> 'TBuffer -> unit) -> unit
        /// <summary>Synchronously reads data from the file referenced by the supplied file descriptor, returning the number of bytes read.</summary>
        /// <param name="fd">A file descriptor.</param>
        /// <param name="buffer">The buffer that the data will be written to.</param>
        /// <param name="offset">The offset in the buffer at which to start writing.</param>
        /// <param name="length">The number of bytes to read.</param>
        /// <param name="position">The offset from the beginning of the file from which data should be read. If `null`, data will be read from the current position.</param>
        abstract readSync: fd: float * buffer: U2<Buffer, Uint8Array> * offset: float * length: float * position: float option -> float
        /// <summary>Asynchronously reads the entire contents of a file.</summary>
        /// <param name="path">A path to a file. If a URL is provided, it must use the `file:` protocol.
        /// If a file descriptor is provided, the underlying file will _not_ be closed automatically.</param>
        /// <param name="options">An object that may contain an optional flag.
        /// If a flag is not provided, it defaults to `'r'`.</param>
        abstract readFile: path: U2<PathLike, float> * options: obj option * callback: (NodeJS.ErrnoException -> Buffer -> unit) -> unit
        /// <summary>Asynchronously reads the entire contents of a file.</summary>
        /// <param name="path">A path to a file. If a URL is provided, it must use the `file:` protocol.
        /// URL support is _experimental_.
        /// If a file descriptor is provided, the underlying file will _not_ be closed automatically.</param>
        /// <param name="options">Either the encoding for the result, or an object that contains the encoding and an optional flag.
        /// If a flag is not provided, it defaults to `'r'`.</param>
        abstract readFile: path: U2<PathLike, float> * options: U2<obj, string> * callback: (NodeJS.ErrnoException -> string -> unit) -> unit
        /// <summary>Asynchronously reads the entire contents of a file.</summary>
        /// <param name="path">A path to a file. If a URL is provided, it must use the `file:` protocol.
        /// URL support is _experimental_.
        /// If a file descriptor is provided, the underlying file will _not_ be closed automatically.</param>
        /// <param name="options">Either the encoding for the result, or an object that contains the encoding and an optional flag.
        /// If a flag is not provided, it defaults to `'r'`.</param>
        abstract readFile: path: U2<PathLike, float> * options: U2<obj, string> option * callback: (NodeJS.ErrnoException -> U2<string, Buffer> -> unit) -> unit
        /// <summary>Asynchronously reads the entire contents of a file.</summary>
        /// <param name="path">A path to a file. If a URL is provided, it must use the `file:` protocol.
        /// If a file descriptor is provided, the underlying file will _not_ be closed automatically.</param>
        abstract readFile: path: U2<PathLike, float> * callback: (NodeJS.ErrnoException -> Buffer -> unit) -> unit
        /// <summary>Synchronously reads the entire contents of a file.</summary>
        /// <param name="path">A path to a file. If a URL is provided, it must use the `file:` protocol.
        /// URL support is _experimental_.
        /// If a file descriptor is provided, the underlying file will _not_ be closed automatically.</param>
        /// <param name="options">An object that may contain an optional flag. If a flag is not provided, it defaults to `'r'`.</param>
        abstract readFileSync: path: U2<PathLike, float> * ?options: obj option -> Buffer
        /// <summary>Synchronously reads the entire contents of a file.</summary>
        /// <param name="path">A path to a file. If a URL is provided, it must use the `file:` protocol.
        /// URL support is _experimental_.
        /// If a file descriptor is provided, the underlying file will _not_ be closed automatically.</param>
        /// <param name="options">Either the encoding for the result, or an object that contains the encoding and an optional flag.
        /// If a flag is not provided, it defaults to `'r'`.</param>
        abstract readFileSync: path: U2<PathLike, float> * options: U2<obj, string> -> string
        /// <summary>Synchronously reads the entire contents of a file.</summary>
        /// <param name="path">A path to a file. If a URL is provided, it must use the `file:` protocol.
        /// URL support is _experimental_.
        /// If a file descriptor is provided, the underlying file will _not_ be closed automatically.</param>
        /// <param name="options">Either the encoding for the result, or an object that contains the encoding and an optional flag.
        /// If a flag is not provided, it defaults to `'r'`.</param>
        abstract readFileSync: path: U2<PathLike, float> * ?options: U2<obj, string> option -> U2<string, Buffer>
        /// <summary>Asynchronously writes data to a file, replacing the file if it already exists.</summary>
        /// <param name="path">A path to a file. If a URL is provided, it must use the `file:` protocol.
        /// URL support is _experimental_.
        /// If a file descriptor is provided, the underlying file will _not_ be closed automatically.</param>
        /// <param name="data">The data to write. If something other than a Buffer or Uint8Array is provided, the value is coerced to a string.</param>
        /// <param name="options">Either the encoding for the file, or an object optionally specifying the encoding, file mode, and flag.
        /// If `encoding` is not supplied, the default of `'utf8'` is used.
        /// If `mode` is not supplied, the default of `0o666` is used.
        /// If `mode` is a string, it is parsed as an octal integer.
        /// If `flag` is not supplied, the default of `'w'` is used.</param>
        abstract writeFile: path: U2<PathLike, float> * data: obj option * options: U2<obj, string> option * callback: (NodeJS.ErrnoException -> unit) -> unit
        /// <summary>Asynchronously writes data to a file, replacing the file if it already exists.</summary>
        /// <param name="path">A path to a file. If a URL is provided, it must use the `file:` protocol.
        /// URL support is _experimental_.
        /// If a file descriptor is provided, the underlying file will _not_ be closed automatically.</param>
        /// <param name="data">The data to write. If something other than a Buffer or Uint8Array is provided, the value is coerced to a string.</param>
        abstract writeFile: path: U2<PathLike, float> * data: obj option * callback: (NodeJS.ErrnoException -> unit) -> unit
        /// <summary>Synchronously writes data to a file, replacing the file if it already exists.</summary>
        /// <param name="path">A path to a file. If a URL is provided, it must use the `file:` protocol.
        /// URL support is _experimental_.
        /// If a file descriptor is provided, the underlying file will _not_ be closed automatically.</param>
        /// <param name="data">The data to write. If something other than a Buffer or Uint8Array is provided, the value is coerced to a string.</param>
        /// <param name="options">Either the encoding for the file, or an object optionally specifying the encoding, file mode, and flag.
        /// If `encoding` is not supplied, the default of `'utf8'` is used.
        /// If `mode` is not supplied, the default of `0o666` is used.
        /// If `mode` is a string, it is parsed as an octal integer.
        /// If `flag` is not supplied, the default of `'w'` is used.</param>
        abstract writeFileSync: path: U2<PathLike, float> * data: obj option * ?options: U2<obj, string> option -> unit
        /// <summary>Asynchronously append data to a file, creating the file if it does not exist.</summary>
        /// <param name="file">A path to a file. If a URL is provided, it must use the `file:` protocol.
        /// URL support is _experimental_.
        /// If a file descriptor is provided, the underlying file will _not_ be closed automatically.</param>
        /// <param name="data">The data to write. If something other than a Buffer or Uint8Array is provided, the value is coerced to a string.</param>
        /// <param name="options">Either the encoding for the file, or an object optionally specifying the encoding, file mode, and flag.
        /// If `encoding` is not supplied, the default of `'utf8'` is used.
        /// If `mode` is not supplied, the default of `0o666` is used.
        /// If `mode` is a string, it is parsed as an octal integer.
        /// If `flag` is not supplied, the default of `'a'` is used.</param>
        abstract appendFile: file: U2<PathLike, float> * data: obj option * options: U2<obj, string> option * callback: (NodeJS.ErrnoException -> unit) -> unit
        /// <summary>Asynchronously append data to a file, creating the file if it does not exist.</summary>
        /// <param name="file">A path to a file. If a URL is provided, it must use the `file:` protocol.
        /// URL support is _experimental_.
        /// If a file descriptor is provided, the underlying file will _not_ be closed automatically.</param>
        /// <param name="data">The data to write. If something other than a Buffer or Uint8Array is provided, the value is coerced to a string.</param>
        abstract appendFile: file: U2<PathLike, float> * data: obj option * callback: (NodeJS.ErrnoException -> unit) -> unit
        /// <summary>Synchronously append data to a file, creating the file if it does not exist.</summary>
        /// <param name="file">A path to a file. If a URL is provided, it must use the `file:` protocol.
        /// URL support is _experimental_.
        /// If a file descriptor is provided, the underlying file will _not_ be closed automatically.</param>
        /// <param name="data">The data to write. If something other than a Buffer or Uint8Array is provided, the value is coerced to a string.</param>
        /// <param name="options">Either the encoding for the file, or an object optionally specifying the encoding, file mode, and flag.
        /// If `encoding` is not supplied, the default of `'utf8'` is used.
        /// If `mode` is not supplied, the default of `0o666` is used.
        /// If `mode` is a string, it is parsed as an octal integer.
        /// If `flag` is not supplied, the default of `'a'` is used.</param>
        abstract appendFileSync: file: U2<PathLike, float> * data: obj option * ?options: U2<obj, string> option -> unit
        /// Watch for changes on `filename`. The callback `listener` will be called each time the file is accessed.
        abstract watchFile: filename: PathLike * options: obj option * listener: (Stats -> Stats -> unit) -> unit
        /// <summary>Watch for changes on `filename`. The callback `listener` will be called each time the file is accessed.</summary>
        /// <param name="filename">A path to a file or directory. If a URL is provided, it must use the `file:` protocol.
        /// URL support is _experimental_.</param>
        abstract watchFile: filename: PathLike * listener: (Stats -> Stats -> unit) -> unit
        /// <summary>Stop watching for changes on `filename`.</summary>
        /// <param name="filename">A path to a file or directory. If a URL is provided, it must use the `file:` protocol.
        /// URL support is _experimental_.</param>
        abstract unwatchFile: filename: PathLike * ?listener: (Stats -> Stats -> unit) -> unit
        /// <summary>Watch for changes on `filename`, where `filename` is either a file or a directory, returning an `FSWatcher`.</summary>
        /// <param name="filename">A path to a file or directory. If a URL is provided, it must use the `file:` protocol.
        /// URL support is _experimental_.</param>
        /// <param name="options">Either the encoding for the filename provided to the listener, or an object optionally specifying encoding, persistent, and recursive options.
        /// If `encoding` is not supplied, the default of `'utf8'` is used.
        /// If `persistent` is not supplied, the default of `true` is used.
        /// If `recursive` is not supplied, the default of `false` is used.</param>
        abstract watch: filename: PathLike * options: U2<obj, BufferEncoding> option * ?listener: (string -> string -> unit) -> FSWatcher
        /// <summary>Watch for changes on `filename`, where `filename` is either a file or a directory, returning an `FSWatcher`.</summary>
        /// <param name="filename">A path to a file or directory. If a URL is provided, it must use the `file:` protocol.
        /// URL support is _experimental_.</param>
        /// <param name="options">Either the encoding for the filename provided to the listener, or an object optionally specifying encoding, persistent, and recursive options.
        /// If `encoding` is not supplied, the default of `'utf8'` is used.
        /// If `persistent` is not supplied, the default of `true` is used.
        /// If `recursive` is not supplied, the default of `false` is used.</param>
        abstract watch: filename: PathLike * options: U2<obj, string> * ?listener: (string -> Buffer -> unit) -> FSWatcher
        /// <summary>Watch for changes on `filename`, where `filename` is either a file or a directory, returning an `FSWatcher`.</summary>
        /// <param name="filename">A path to a file or directory. If a URL is provided, it must use the `file:` protocol.
        /// URL support is _experimental_.</param>
        /// <param name="options">Either the encoding for the filename provided to the listener, or an object optionally specifying encoding, persistent, and recursive options.
        /// If `encoding` is not supplied, the default of `'utf8'` is used.
        /// If `persistent` is not supplied, the default of `true` is used.
        /// If `recursive` is not supplied, the default of `false` is used.</param>
        abstract watch: filename: PathLike * options: U2<obj, string> option * ?listener: (string -> U2<string, Buffer> -> unit) -> FSWatcher
        /// <summary>Watch for changes on `filename`, where `filename` is either a file or a directory, returning an `FSWatcher`.</summary>
        /// <param name="filename">A path to a file or directory. If a URL is provided, it must use the `file:` protocol.
        /// URL support is _experimental_.</param>
        abstract watch: filename: PathLike * ?listener: (string -> string -> obj option) -> FSWatcher
        /// <summary>Asynchronously tests whether or not the given path exists by checking with the file system.</summary>
        /// <param name="path">A path to a file or directory. If a URL is provided, it must use the `file:` protocol.
        /// URL support is _experimental_.</param>
        abstract exists: path: PathLike * callback: (bool -> unit) -> unit
        /// <summary>Synchronously tests whether or not the given path exists by checking with the file system.</summary>
        /// <param name="path">A path to a file or directory. If a URL is provided, it must use the `file:` protocol.
        /// URL support is _experimental_.</param>
        abstract existsSync: path: PathLike -> bool
        /// <summary>Asynchronously tests a user's permissions for the file specified by path.</summary>
        /// <param name="path">A path to a file or directory. If a URL is provided, it must use the `file:` protocol.
        /// URL support is _experimental_.</param>
        abstract access: path: PathLike * mode: float option * callback: (NodeJS.ErrnoException -> unit) -> unit
        /// <summary>Asynchronously tests a user's permissions for the file specified by path.</summary>
        /// <param name="path">A path to a file or directory. If a URL is provided, it must use the `file:` protocol.
        /// URL support is _experimental_.</param>
        abstract access: path: PathLike * callback: (NodeJS.ErrnoException -> unit) -> unit
        /// <summary>Synchronously tests a user's permissions for the file specified by path.</summary>
        /// <param name="path">A path to a file or directory. If a URL is provided, it must use the `file:` protocol.
        /// URL support is _experimental_.</param>
        abstract accessSync: path: PathLike * ?mode: float -> unit
        /// <summary>Returns a new `ReadStream` object.</summary>
        /// <param name="path">A path to a file. If a URL is provided, it must use the `file:` protocol.
        /// URL support is _experimental_.</param>
        abstract createReadStream: path: PathLike * ?options: U2<string, obj> -> ReadStream
        /// <summary>Returns a new `WriteStream` object.</summary>
        /// <param name="path">A path to a file. If a URL is provided, it must use the `file:` protocol.
        /// URL support is _experimental_.</param>
        abstract createWriteStream: path: PathLike * ?options: U2<string, obj> -> WriteStream
        /// <summary>Asynchronous fdatasync(2) - synchronize a file's in-core state with storage device.</summary>
        /// <param name="fd">A file descriptor.</param>
        abstract fdatasync: fd: float * callback: (NodeJS.ErrnoException -> unit) -> unit
        /// <summary>Synchronous fdatasync(2) - synchronize a file's in-core state with storage device.</summary>
        /// <param name="fd">A file descriptor.</param>
        abstract fdatasyncSync: fd: float -> unit
        /// <summary>Asynchronously copies src to dest. By default, dest is overwritten if it already exists.
        /// No arguments other than a possible exception are given to the callback function.
        /// Node.js makes no guarantees about the atomicity of the copy operation.
        /// If an error occurs after the destination file has been opened for writing, Node.js will attempt
        /// to remove the destination.</summary>
        /// <param name="src">A path to the source file.</param>
        /// <param name="dest">A path to the destination file.</param>
        abstract copyFile: src: PathLike * dest: PathLike * callback: (NodeJS.ErrnoException -> unit) -> unit
        /// <summary>Asynchronously copies src to dest. By default, dest is overwritten if it already exists.
        /// No arguments other than a possible exception are given to the callback function.
        /// Node.js makes no guarantees about the atomicity of the copy operation.
        /// If an error occurs after the destination file has been opened for writing, Node.js will attempt
        /// to remove the destination.</summary>
        /// <param name="src">A path to the source file.</param>
        /// <param name="dest">A path to the destination file.</param>
        /// <param name="flags">An integer that specifies the behavior of the copy operation. The only supported flag is fs.constants.COPYFILE_EXCL, which causes the copy operation to fail if dest already exists.</param>
        abstract copyFile: src: PathLike * dest: PathLike * flags: float * callback: (NodeJS.ErrnoException -> unit) -> unit
        /// <summary>Synchronously copies src to dest. By default, dest is overwritten if it already exists.
        /// Node.js makes no guarantees about the atomicity of the copy operation.
        /// If an error occurs after the destination file has been opened for writing, Node.js will attempt
        /// to remove the destination.</summary>
        /// <param name="src">A path to the source file.</param>
        /// <param name="dest">A path to the destination file.</param>
        /// <param name="flags">An optional integer that specifies the behavior of the copy operation. The only supported flag is fs.constants.COPYFILE_EXCL, which causes the copy operation to fail if dest already exists.</param>
        abstract copyFileSync: src: PathLike * dest: PathLike * ?flags: float -> unit

    type PathLike =
        U3<string, Buffer, URL>

    [<RequireQualifiedAccess; CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
    module PathLike =
        let ofString v: PathLike = v |> U3.Case1
        let isString (v: PathLike) = match v with U3.Case1 _ -> true | _ -> false
        let asString (v: PathLike) = match v with U3.Case1 o -> Some o | _ -> None
        let ofBuffer v: PathLike = v |> U3.Case2
        let isBuffer (v: PathLike) = match v with U3.Case2 _ -> true | _ -> false
        let asBuffer (v: PathLike) = match v with U3.Case2 o -> Some o | _ -> None
        let ofURL v: PathLike = v |> U3.Case3
        let isURL (v: PathLike) = match v with U3.Case3 _ -> true | _ -> false
        let asURL (v: PathLike) = match v with U3.Case3 o -> Some o | _ -> None

    type [<AllowNullLiteral>] Stats =
        abstract isFile: unit -> bool
        abstract isDirectory: unit -> bool
        abstract isBlockDevice: unit -> bool
        abstract isCharacterDevice: unit -> bool
        abstract isSymbolicLink: unit -> bool
        abstract isFIFO: unit -> bool
        abstract isSocket: unit -> bool
        abstract dev: float with get, set
        abstract ino: float with get, set
        abstract mode: float with get, set
        abstract nlink: float with get, set
        abstract uid: float with get, set
        abstract gid: float with get, set
        abstract rdev: float with get, set
        abstract size: float with get, set
        abstract blksize: float with get, set
        abstract blocks: float with get, set
        abstract atimeMs: float with get, set
        abstract mtimeMs: float with get, set
        abstract ctimeMs: float with get, set
        abstract birthtimeMs: float with get, set
        abstract atime: DateTime with get, set
        abstract mtime: DateTime with get, set
        abstract ctime: DateTime with get, set
        abstract birthtime: DateTime with get, set

    type [<AllowNullLiteral>] StatsStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> Stats

    type [<AllowNullLiteral>] FSWatcher =
        inherit Events.EventEmitter
        abstract close: unit -> unit
        /// events.EventEmitter
        ///    1. change
        ///    2. error
        abstract addListener: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> FSWatcher
        [<Emit "$0.addListener('change',$1)">] abstract addListener_change: listener: (string -> U2<string, Buffer> -> unit) -> FSWatcher
        [<Emit "$0.addListener('error',$1)">] abstract addListener_error: listener: (Error -> unit) -> FSWatcher
        abstract on: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> FSWatcher
        [<Emit "$0.on('change',$1)">] abstract on_change: listener: (string -> U2<string, Buffer> -> unit) -> FSWatcher
        [<Emit "$0.on('error',$1)">] abstract on_error: listener: (Error -> unit) -> FSWatcher
        abstract once: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> FSWatcher
        [<Emit "$0.once('change',$1)">] abstract once_change: listener: (string -> U2<string, Buffer> -> unit) -> FSWatcher
        [<Emit "$0.once('error',$1)">] abstract once_error: listener: (Error -> unit) -> FSWatcher
        abstract prependListener: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> FSWatcher
        [<Emit "$0.prependListener('change',$1)">] abstract prependListener_change: listener: (string -> U2<string, Buffer> -> unit) -> FSWatcher
        [<Emit "$0.prependListener('error',$1)">] abstract prependListener_error: listener: (Error -> unit) -> FSWatcher
        abstract prependOnceListener: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> FSWatcher
        [<Emit "$0.prependOnceListener('change',$1)">] abstract prependOnceListener_change: listener: (string -> U2<string, Buffer> -> unit) -> FSWatcher
        [<Emit "$0.prependOnceListener('error',$1)">] abstract prependOnceListener_error: listener: (Error -> unit) -> FSWatcher

    type [<AllowNullLiteral>] ReadStream =
        inherit Stream.Readable
        abstract close: unit -> unit
        abstract destroy: unit -> unit
        abstract bytesRead: float with get, set
        abstract path: U2<string, Buffer> with get, set
        /// events.EventEmitter
        ///    1. open
        ///    2. close
        abstract addListener: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> ReadStream
        [<Emit "$0.addListener('open',$1)">] abstract addListener_open: listener: (float -> unit) -> ReadStream
        [<Emit "$0.addListener('close',$1)">] abstract addListener_close: listener: (unit -> unit) -> ReadStream
        abstract on: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> ReadStream
        [<Emit "$0.on('open',$1)">] abstract on_open: listener: (float -> unit) -> ReadStream
        [<Emit "$0.on('close',$1)">] abstract on_close: listener: (unit -> unit) -> ReadStream
        abstract once: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> ReadStream
        [<Emit "$0.once('open',$1)">] abstract once_open: listener: (float -> unit) -> ReadStream
        [<Emit "$0.once('close',$1)">] abstract once_close: listener: (unit -> unit) -> ReadStream
        abstract prependListener: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> ReadStream
        [<Emit "$0.prependListener('open',$1)">] abstract prependListener_open: listener: (float -> unit) -> ReadStream
        [<Emit "$0.prependListener('close',$1)">] abstract prependListener_close: listener: (unit -> unit) -> ReadStream
        abstract prependOnceListener: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> ReadStream
        [<Emit "$0.prependOnceListener('open',$1)">] abstract prependOnceListener_open: listener: (float -> unit) -> ReadStream
        [<Emit "$0.prependOnceListener('close',$1)">] abstract prependOnceListener_close: listener: (unit -> unit) -> ReadStream

    type [<AllowNullLiteral>] ReadStreamStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> ReadStream

    type [<AllowNullLiteral>] WriteStream =
        inherit Stream.Writable
        abstract close: unit -> unit
        abstract bytesWritten: float with get, set
        abstract path: U2<string, Buffer> with get, set
        /// events.EventEmitter
        ///    1. open
        ///    2. close
        abstract addListener: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> WriteStream
        [<Emit "$0.addListener('open',$1)">] abstract addListener_open: listener: (float -> unit) -> WriteStream
        [<Emit "$0.addListener('close',$1)">] abstract addListener_close: listener: (unit -> unit) -> WriteStream
        abstract on: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> WriteStream
        [<Emit "$0.on('open',$1)">] abstract on_open: listener: (float -> unit) -> WriteStream
        [<Emit "$0.on('close',$1)">] abstract on_close: listener: (unit -> unit) -> WriteStream
        abstract once: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> WriteStream
        [<Emit "$0.once('open',$1)">] abstract once_open: listener: (float -> unit) -> WriteStream
        [<Emit "$0.once('close',$1)">] abstract once_close: listener: (unit -> unit) -> WriteStream
        abstract prependListener: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> WriteStream
        [<Emit "$0.prependListener('open',$1)">] abstract prependListener_open: listener: (float -> unit) -> WriteStream
        [<Emit "$0.prependListener('close',$1)">] abstract prependListener_close: listener: (unit -> unit) -> WriteStream
        abstract prependOnceListener: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> WriteStream
        [<Emit "$0.prependOnceListener('open',$1)">] abstract prependOnceListener_open: listener: (float -> unit) -> WriteStream
        [<Emit "$0.prependOnceListener('close',$1)">] abstract prependOnceListener_close: listener: (unit -> unit) -> WriteStream

    type [<AllowNullLiteral>] WriteStreamStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> WriteStream

    module Rename =

        type [<AllowNullLiteral>] IExports =
            /// <summary>Asynchronous rename(2) - Change the name or location of a file or directory.</summary>
            /// <param name="oldPath">A path to a file. If a URL is provided, it must use the `file:` protocol.
            /// URL support is _experimental_.</param>
            /// <param name="newPath">A path to a file. If a URL is provided, it must use the `file:` protocol.
            /// URL support is _experimental_.</param>
            abstract __promisify__: oldPath: PathLike * newPath: PathLike -> Promise<unit>

    module Truncate =

        type [<AllowNullLiteral>] IExports =
            /// <summary>Asynchronous truncate(2) - Truncate a file to a specified length.</summary>
            /// <param name="path">A path to a file. If a URL is provided, it must use the `file:` protocol.</param>
            /// <param name="len">If not specified, defaults to `0`.</param>
            abstract __promisify__: path: PathLike * ?len: float option -> Promise<unit>

    module Ftruncate =

        type [<AllowNullLiteral>] IExports =
            /// <summary>Asynchronous ftruncate(2) - Truncate a file to a specified length.</summary>
            /// <param name="fd">A file descriptor.</param>
            /// <param name="len">If not specified, defaults to `0`.</param>
            abstract __promisify__: fd: float * ?len: float option -> Promise<unit>

    module Chown =

        type [<AllowNullLiteral>] IExports =
            /// <summary>Asynchronous chown(2) - Change ownership of a file.</summary>
            /// <param name="path">A path to a file. If a URL is provided, it must use the `file:` protocol.</param>
            abstract __promisify__: path: PathLike * uid: float * gid: float -> Promise<unit>

    module Fchown =

        type [<AllowNullLiteral>] IExports =
            /// <summary>Asynchronous fchown(2) - Change ownership of a file.</summary>
            /// <param name="fd">A file descriptor.</param>
            abstract __promisify__: fd: float * uid: float * gid: float -> Promise<unit>

    module Lchown =

        type [<AllowNullLiteral>] IExports =
            /// <summary>Asynchronous lchown(2) - Change ownership of a file. Does not dereference symbolic links.</summary>
            /// <param name="path">A path to a file. If a URL is provided, it must use the `file:` protocol.</param>
            abstract __promisify__: path: PathLike * uid: float * gid: float -> Promise<unit>

    module Chmod =

        type [<AllowNullLiteral>] IExports =
            /// <summary>Asynchronous chmod(2) - Change permissions of a file.</summary>
            /// <param name="path">A path to a file. If a URL is provided, it must use the `file:` protocol.</param>
            /// <param name="mode">A file mode. If a string is passed, it is parsed as an octal integer.</param>
            abstract __promisify__: path: PathLike * mode: U2<string, float> -> Promise<unit>

    module Fchmod =

        type [<AllowNullLiteral>] IExports =
            /// <summary>Asynchronous fchmod(2) - Change permissions of a file.</summary>
            /// <param name="fd">A file descriptor.</param>
            /// <param name="mode">A file mode. If a string is passed, it is parsed as an octal integer.</param>
            abstract __promisify__: fd: float * mode: U2<string, float> -> Promise<unit>

    module Lchmod =

        type [<AllowNullLiteral>] IExports =
            /// <summary>Asynchronous lchmod(2) - Change permissions of a file. Does not dereference symbolic links.</summary>
            /// <param name="path">A path to a file. If a URL is provided, it must use the `file:` protocol.</param>
            /// <param name="mode">A file mode. If a string is passed, it is parsed as an octal integer.</param>
            abstract __promisify__: path: PathLike * mode: U2<string, float> -> Promise<unit>

    module Stat =

        type [<AllowNullLiteral>] IExports =
            /// <summary>Asynchronous stat(2) - Get file status.</summary>
            /// <param name="path">A path to a file. If a URL is provided, it must use the `file:` protocol.</param>
            abstract __promisify__: path: PathLike -> Promise<Stats>

    module Fstat =

        type [<AllowNullLiteral>] IExports =
            /// <summary>Asynchronous fstat(2) - Get file status.</summary>
            /// <param name="fd">A file descriptor.</param>
            abstract __promisify__: fd: float -> Promise<Stats>

    module Lstat =

        type [<AllowNullLiteral>] IExports =
            /// <summary>Asynchronous lstat(2) - Get file status. Does not dereference symbolic links.</summary>
            /// <param name="path">A path to a file. If a URL is provided, it must use the `file:` protocol.</param>
            abstract __promisify__: path: PathLike -> Promise<Stats>

    module Link =

        type [<AllowNullLiteral>] IExports =
            /// <summary>Asynchronous link(2) - Create a new link (also known as a hard link) to an existing file.</summary>
            /// <param name="existingPath">A path to a file. If a URL is provided, it must use the `file:` protocol.</param>
            /// <param name="newPath">A path to a file. If a URL is provided, it must use the `file:` protocol.</param>
            abstract link: existingPath: PathLike * newPath: PathLike -> Promise<unit>

    module Symlink =

        type [<AllowNullLiteral>] IExports =
            /// <summary>Asynchronous symlink(2) - Create a new symbolic link to an existing file.</summary>
            /// <param name="target">A path to an existing file. If a URL is provided, it must use the `file:` protocol.</param>
            /// <param name="path">A path to the new symlink. If a URL is provided, it must use the `file:` protocol.</param>
            /// <param name="type">May be set to `'dir'`, `'file'`, or `'junction'` (default is `'file'`) and is only available on Windows (ignored on other platforms).
            /// When using `'junction'`, the `target` argument will automatically be normalized to an absolute path.</param>
            abstract __promisify__: target: PathLike * path: PathLike * ?``type``: string option -> Promise<unit>

        type [<StringEnum>] [<RequireQualifiedAccess>] Type =
            | Dir
            | File
            | Junction

    module Readlink =

        type [<AllowNullLiteral>] IExports =
            /// <summary>Asynchronous readlink(2) - read value of a symbolic link.</summary>
            /// <param name="path">A path to a file. If a URL is provided, it must use the `file:` protocol.</param>
            /// <param name="options">The encoding (or an object specifying the encoding), used as the encoding of the result. If not provided, `'utf8'` is used.</param>
            abstract __promisify__: path: PathLike * ?options: U2<obj, BufferEncoding> option -> Promise<string>
            /// <summary>Asynchronous readlink(2) - read value of a symbolic link.</summary>
            /// <param name="path">A path to a file. If a URL is provided, it must use the `file:` protocol.</param>
            /// <param name="options">The encoding (or an object specifying the encoding), used as the encoding of the result. If not provided, `'utf8'` is used.</param>
            abstract __promisify__: path: PathLike * options: U2<obj, string> -> Promise<Buffer>
            /// <summary>Asynchronous readlink(2) - read value of a symbolic link.</summary>
            /// <param name="path">A path to a file. If a URL is provided, it must use the `file:` protocol.</param>
            /// <param name="options">The encoding (or an object specifying the encoding), used as the encoding of the result. If not provided, `'utf8'` is used.</param>
            abstract __promisify__: path: PathLike * ?options: U2<obj, string> option -> Promise<U2<string, Buffer>>

    module Realpath =

        type [<AllowNullLiteral>] IExports =
            /// <summary>Asynchronous realpath(3) - return the canonicalized absolute pathname.</summary>
            /// <param name="path">A path to a file. If a URL is provided, it must use the `file:` protocol.</param>
            /// <param name="options">The encoding (or an object specifying the encoding), used as the encoding of the result. If not provided, `'utf8'` is used.</param>
            abstract __promisify__: path: PathLike * ?options: U2<obj, BufferEncoding> option -> Promise<string>
            /// <summary>Asynchronous realpath(3) - return the canonicalized absolute pathname.</summary>
            /// <param name="path">A path to a file. If a URL is provided, it must use the `file:` protocol.</param>
            /// <param name="options">The encoding (or an object specifying the encoding), used as the encoding of the result. If not provided, `'utf8'` is used.</param>
            abstract __promisify__: path: PathLike * options: U2<obj, string> -> Promise<Buffer>
            /// <summary>Asynchronous realpath(3) - return the canonicalized absolute pathname.</summary>
            /// <param name="path">A path to a file. If a URL is provided, it must use the `file:` protocol.</param>
            /// <param name="options">The encoding (or an object specifying the encoding), used as the encoding of the result. If not provided, `'utf8'` is used.</param>
            abstract __promisify__: path: PathLike * ?options: U2<obj, string> option -> Promise<U2<string, Buffer>>

    module Unlink =

        type [<AllowNullLiteral>] IExports =
            /// <summary>Asynchronous unlink(2) - delete a name and possibly the file it refers to.</summary>
            /// <param name="path">A path to a file. If a URL is provided, it must use the `file:` protocol.</param>
            abstract __promisify__: path: PathLike -> Promise<unit>

    module Rmdir =

        type [<AllowNullLiteral>] IExports =
            /// <summary>Asynchronous rmdir(2) - delete a directory.</summary>
            /// <param name="path">A path to a file. If a URL is provided, it must use the `file:` protocol.</param>
            abstract __promisify__: path: PathLike -> Promise<unit>

    module Mkdir =

        type [<AllowNullLiteral>] IExports =
            /// <summary>Asynchronous mkdir(2) - create a directory.</summary>
            /// <param name="path">A path to a file. If a URL is provided, it must use the `file:` protocol.</param>
            /// <param name="mode">A file mode. If a string is passed, it is parsed as an octal integer. If not specified, defaults to `0o777`.</param>
            abstract __promisify__: path: PathLike * ?mode: U2<float, string> option -> Promise<unit>

    module Mkdtemp =

        type [<AllowNullLiteral>] IExports =
            /// <summary>Asynchronously creates a unique temporary directory.
            /// Generates six random characters to be appended behind a required prefix to create a unique temporary directory.</summary>
            /// <param name="options">The encoding (or an object specifying the encoding), used as the encoding of the result. If not provided, `'utf8'` is used.</param>
            abstract __promisify__: prefix: string * ?options: U2<obj, BufferEncoding> option -> Promise<string>
            /// <summary>Asynchronously creates a unique temporary directory.
            /// Generates six random characters to be appended behind a required prefix to create a unique temporary directory.</summary>
            /// <param name="options">The encoding (or an object specifying the encoding), used as the encoding of the result. If not provided, `'utf8'` is used.</param>
            abstract __promisify__: prefix: string * options: U2<obj, string> -> Promise<Buffer>
            /// <summary>Asynchronously creates a unique temporary directory.
            /// Generates six random characters to be appended behind a required prefix to create a unique temporary directory.</summary>
            /// <param name="options">The encoding (or an object specifying the encoding), used as the encoding of the result. If not provided, `'utf8'` is used.</param>
            abstract __promisify__: prefix: string * ?options: U2<obj, string> option -> Promise<U2<string, Buffer>>

    module Readdir =

        type [<AllowNullLiteral>] IExports =
            /// <summary>Asynchronous readdir(3) - read a directory.</summary>
            /// <param name="path">A path to a file. If a URL is provided, it must use the `file:` protocol.</param>
            /// <param name="options">The encoding (or an object specifying the encoding), used as the encoding of the result. If not provided, `'utf8'` is used.</param>
            abstract __promisify__: path: PathLike * ?options: U2<obj, BufferEncoding> option -> Promise<ResizeArray<string>>
            /// <summary>Asynchronous readdir(3) - read a directory.</summary>
            /// <param name="path">A path to a file. If a URL is provided, it must use the `file:` protocol.</param>
            /// <param name="options">The encoding (or an object specifying the encoding), used as the encoding of the result. If not provided, `'utf8'` is used.</param>
            abstract __promisify__: path: PathLike * options: U2<string, obj> -> Promise<ResizeArray<Buffer>>
            /// <summary>Asynchronous readdir(3) - read a directory.</summary>
            /// <param name="path">A path to a file. If a URL is provided, it must use the `file:` protocol.</param>
            /// <param name="options">The encoding (or an object specifying the encoding), used as the encoding of the result. If not provided, `'utf8'` is used.</param>
            abstract __promisify__: path: PathLike * ?options: U2<obj, string> option -> Promise<U2<ResizeArray<string>, ResizeArray<Buffer>>>

    module Close =

        type [<AllowNullLiteral>] IExports =
            /// <summary>Asynchronous close(2) - close a file descriptor.</summary>
            /// <param name="fd">A file descriptor.</param>
            abstract __promisify__: fd: float -> Promise<unit>

    module Open =

        type [<AllowNullLiteral>] IExports =
            /// <summary>Asynchronous open(2) - open and possibly create a file.</summary>
            /// <param name="path">A path to a file. If a URL is provided, it must use the `file:` protocol.</param>
            /// <param name="mode">A file mode. If a string is passed, it is parsed as an octal integer. If not supplied, defaults to `0o666`.</param>
            abstract __promisify__: path: PathLike * flags: U2<string, float> * ?mode: U2<string, float> option -> Promise<float>

    module Utimes =

        type [<AllowNullLiteral>] IExports =
            /// <summary>Asynchronously change file timestamps of the file referenced by the supplied path.</summary>
            /// <param name="path">A path to a file. If a URL is provided, it must use the `file:` protocol.</param>
            /// <param name="atime">The last access time. If a string is provided, it will be coerced to number.</param>
            /// <param name="mtime">The last modified time. If a string is provided, it will be coerced to number.</param>
            abstract __promisify__: path: PathLike * atime: U3<string, float, DateTime> * mtime: U3<string, float, DateTime> -> Promise<unit>

    module Futimes =

        type [<AllowNullLiteral>] IExports =
            /// <summary>Asynchronously change file timestamps of the file referenced by the supplied file descriptor.</summary>
            /// <param name="fd">A file descriptor.</param>
            /// <param name="atime">The last access time. If a string is provided, it will be coerced to number.</param>
            /// <param name="mtime">The last modified time. If a string is provided, it will be coerced to number.</param>
            abstract __promisify__: fd: float * atime: U3<string, float, DateTime> * mtime: U3<string, float, DateTime> -> Promise<unit>

    module Fsync =

        type [<AllowNullLiteral>] IExports =
            /// <summary>Asynchronous fsync(2) - synchronize a file's in-core state with the underlying storage device.</summary>
            /// <param name="fd">A file descriptor.</param>
            abstract __promisify__: fd: float -> Promise<unit>

    module Write =

        type [<AllowNullLiteral>] IExports =
            /// <summary>Asynchronously writes `buffer` to the file referenced by the supplied file descriptor.</summary>
            /// <param name="fd">A file descriptor.</param>
            /// <param name="offset">The part of the buffer to be written. If not supplied, defaults to `0`.</param>
            /// <param name="length">The number of bytes to write. If not supplied, defaults to `buffer.length - offset`.</param>
            /// <param name="position">The offset from the beginning of the file where this data should be written. If not supplied, defaults to the current position.</param>
            abstract __promisify__: fd: float * ?buffer: 'TBuffer * ?offset: float * ?length: float * ?position: float option -> Promise<obj>
            /// <summary>Asynchronously writes `string` to the file referenced by the supplied file descriptor.</summary>
            /// <param name="fd">A file descriptor.</param>
            /// <param name="string">A string to write. If something other than a string is supplied it will be coerced to a string.</param>
            /// <param name="position">The offset from the beginning of the file where this data should be written. If not supplied, defaults to the current position.</param>
            /// <param name="encoding">The expected string encoding.</param>
            abstract __promisify__: fd: float * string: obj option * ?position: float option * ?encoding: string option -> Promise<obj>

    module Read =

        type [<AllowNullLiteral>] IExports =
            /// <param name="fd">A file descriptor.</param>
            /// <param name="buffer">The buffer that the data will be written to.</param>
            /// <param name="offset">The offset in the buffer at which to start writing.</param>
            /// <param name="length">The number of bytes to read.</param>
            /// <param name="position">The offset from the beginning of the file from which data should be read. If `null`, data will be read from the current position.</param>
            abstract __promisify__: fd: float * buffer: 'TBuffer * offset: float * length: float * position: float option -> Promise<obj>

    module ReadFile =

        type [<AllowNullLiteral>] IExports =
            /// <summary>Asynchronously reads the entire contents of a file.</summary>
            /// <param name="path">A path to a file. If a URL is provided, it must use the `file:` protocol.
            /// If a file descriptor is provided, the underlying file will _not_ be closed automatically.</param>
            /// <param name="options">An object that may contain an optional flag.
            /// If a flag is not provided, it defaults to `'r'`.</param>
            abstract __promisify__: path: U2<PathLike, float> * ?options: obj option -> Promise<Buffer>
            /// <summary>Asynchronously reads the entire contents of a file.</summary>
            /// <param name="path">A path to a file. If a URL is provided, it must use the `file:` protocol.
            /// URL support is _experimental_.
            /// If a file descriptor is provided, the underlying file will _not_ be closed automatically.</param>
            /// <param name="options">Either the encoding for the result, or an object that contains the encoding and an optional flag.
            /// If a flag is not provided, it defaults to `'r'`.</param>
            abstract __promisify__: path: U2<PathLike, float> * options: U2<obj, string> -> Promise<string>
            /// <summary>Asynchronously reads the entire contents of a file.</summary>
            /// <param name="path">A path to a file. If a URL is provided, it must use the `file:` protocol.
            /// URL support is _experimental_.
            /// If a file descriptor is provided, the underlying file will _not_ be closed automatically.</param>
            /// <param name="options">Either the encoding for the result, or an object that contains the encoding and an optional flag.
            /// If a flag is not provided, it defaults to `'r'`.</param>
            abstract __promisify__: path: U2<PathLike, float> * ?options: U2<obj, string> option -> Promise<U2<string, Buffer>>

    module WriteFile =

        type [<AllowNullLiteral>] IExports =
            /// <summary>Asynchronously writes data to a file, replacing the file if it already exists.</summary>
            /// <param name="path">A path to a file. If a URL is provided, it must use the `file:` protocol.
            /// URL support is _experimental_.
            /// If a file descriptor is provided, the underlying file will _not_ be closed automatically.</param>
            /// <param name="data">The data to write. If something other than a Buffer or Uint8Array is provided, the value is coerced to a string.</param>
            /// <param name="options">Either the encoding for the file, or an object optionally specifying the encoding, file mode, and flag.
            /// If `encoding` is not supplied, the default of `'utf8'` is used.
            /// If `mode` is not supplied, the default of `0o666` is used.
            /// If `mode` is a string, it is parsed as an octal integer.
            /// If `flag` is not supplied, the default of `'w'` is used.</param>
            abstract __promisify__: path: U2<PathLike, float> * data: obj option * ?options: U2<obj, string> option -> Promise<unit>

    module AppendFile =

        type [<AllowNullLiteral>] IExports =
            /// <summary>Asynchronously append data to a file, creating the file if it does not exist.</summary>
            /// <param name="file">A path to a file. If a URL is provided, it must use the `file:` protocol.
            /// URL support is _experimental_.
            /// If a file descriptor is provided, the underlying file will _not_ be closed automatically.</param>
            /// <param name="data">The data to write. If something other than a Buffer or Uint8Array is provided, the value is coerced to a string.</param>
            /// <param name="options">Either the encoding for the file, or an object optionally specifying the encoding, file mode, and flag.
            /// If `encoding` is not supplied, the default of `'utf8'` is used.
            /// If `mode` is not supplied, the default of `0o666` is used.
            /// If `mode` is a string, it is parsed as an octal integer.
            /// If `flag` is not supplied, the default of `'a'` is used.</param>
            abstract __promisify__: file: U2<PathLike, float> * data: obj option * ?options: U2<obj, string> option -> Promise<unit>

    module Exists =

        type [<AllowNullLiteral>] IExports =
            /// <param name="path">A path to a file or directory. If a URL is provided, it must use the `file:` protocol.
            /// URL support is _experimental_.</param>
            abstract __promisify__: path: PathLike -> Promise<bool>

    module Constants =
        let F_OK: float = jsNative
        let R_OK: float = jsNative
        let W_OK: float = jsNative
        let X_OK: float = jsNative
        let O_RDONLY: float = jsNative
        let O_WRONLY: float = jsNative
        let O_RDWR: float = jsNative
        let O_CREAT: float = jsNative
        let O_EXCL: float = jsNative
        let O_NOCTTY: float = jsNative
        let O_TRUNC: float = jsNative
        let O_APPEND: float = jsNative
        let O_DIRECTORY: float = jsNative
        let O_NOATIME: float = jsNative
        let O_NOFOLLOW: float = jsNative
        let O_SYNC: float = jsNative
        let O_DSYNC: float = jsNative
        let O_SYMLINK: float = jsNative
        let O_DIRECT: float = jsNative
        let O_NONBLOCK: float = jsNative
        let S_IFMT: float = jsNative
        let S_IFREG: float = jsNative
        let S_IFDIR: float = jsNative
        let S_IFCHR: float = jsNative
        let S_IFBLK: float = jsNative
        let S_IFIFO: float = jsNative
        let S_IFLNK: float = jsNative
        let S_IFSOCK: float = jsNative
        let S_IRWXU: float = jsNative
        let S_IRUSR: float = jsNative
        let S_IWUSR: float = jsNative
        let S_IXUSR: float = jsNative
        let S_IRWXG: float = jsNative
        let S_IRGRP: float = jsNative
        let S_IWGRP: float = jsNative
        let S_IXGRP: float = jsNative
        let S_IRWXO: float = jsNative
        let S_IROTH: float = jsNative
        let S_IWOTH: float = jsNative
        let S_IXOTH: float = jsNative
        let COPYFILE_EXCL: float = jsNative

    module Access =

        type [<AllowNullLiteral>] IExports =
            /// <summary>Asynchronously tests a user's permissions for the file specified by path.</summary>
            /// <param name="path">A path to a file or directory. If a URL is provided, it must use the `file:` protocol.
            /// URL support is _experimental_.</param>
            abstract __promisify__: path: PathLike * ?mode: float -> Promise<unit>

    module Fdatasync =

        type [<AllowNullLiteral>] IExports =
            /// <summary>Asynchronous fdatasync(2) - synchronize a file's in-core state with storage device.</summary>
            /// <param name="fd">A file descriptor.</param>
            abstract __promisify__: fd: float -> Promise<unit>

    module CopyFile =

        type [<AllowNullLiteral>] IExports =
            /// <summary>Asynchronously copies src to dest. By default, dest is overwritten if it already exists.
            /// No arguments other than a possible exception are given to the callback function.
            /// Node.js makes no guarantees about the atomicity of the copy operation.
            /// If an error occurs after the destination file has been opened for writing, Node.js will attempt
            /// to remove the destination.</summary>
            /// <param name="src">A path to the source file.</param>
            /// <param name="flags">An optional integer that specifies the behavior of the copy operation. The only supported flag is fs.constants.COPYFILE_EXCL, which causes the copy operation to fail if dest already exists.</param>
            abstract __promisify__: src: PathLike * dst: PathLike * ?flags: float -> Promise<unit>

module Path =
    let [<Import("posix","path")>] posix: Posix.IExports = jsNative
    let [<Import("win32","path")>] win32: Win32.IExports = jsNative

    type [<AllowNullLiteral>] IExports =
        /// <summary>Normalize a string path, reducing '..' and '.' parts.
        /// When multiple slashes are found, they're replaced by a single one; when the path contains a trailing slash, it is preserved. On Windows backslashes are used.</summary>
        /// <param name="p">string path to normalize.</param>
        abstract normalize: p: string -> string
        /// <summary>Join all arguments together and normalize the resulting path.
        /// Arguments must be strings. In v0.8, non-string arguments were silently ignored. In v0.10 and up, an exception is thrown.</summary>
        /// <param name="paths">paths to join.</param>
        abstract join: [<ParamArray>] paths: ResizeArray<string> -> string
        /// <summary>The right-most parameter is considered {to}.  Other parameters are considered an array of {from}.
        /// 
        /// Starting from leftmost {from} paramter, resolves {to} to an absolute path.
        /// 
        /// If {to} isn't already absolute, {from} arguments are prepended in right to left order, until an absolute path is found. If after using all {from} paths still no absolute path is found, the current working directory is used as well. The resulting path is normalized, and trailing slashes are removed unless the path gets resolved to the root directory.</summary>
        /// <param name="pathSegments">string paths to join.  Non-string arguments are ignored.</param>
        abstract resolve: [<ParamArray>] pathSegments: ResizeArray<string> -> string
        /// <summary>Determines whether {path} is an absolute path. An absolute path will always resolve to the same location, regardless of the working directory.</summary>
        /// <param name="path">path to test.</param>
        abstract isAbsolute: path: string -> bool
        /// Solve the relative path from {from} to {to}.
        /// At times we have two absolute paths, and we need to derive the relative path from one to the other. This is actually the reverse transform of path.resolve.
        abstract relative: from: string * ``to``: string -> string
        /// <summary>Return the directory name of a path. Similar to the Unix dirname command.</summary>
        /// <param name="p">the path to evaluate.</param>
        abstract dirname: p: string -> string
        /// <summary>Return the last portion of a path. Similar to the Unix basename command.
        /// Often used to extract the file name from a fully qualified path.</summary>
        /// <param name="p">the path to evaluate.</param>
        /// <param name="ext">optionally, an extension to remove from the result.</param>
        abstract basename: p: string * ?ext: string -> string
        /// <summary>Return the extension of the path, from the last '.' to end of string in the last portion of the path.
        /// If there is no '.' in the last portion of the path or the first character of it is '.', then it returns an empty string</summary>
        /// <param name="p">the path to evaluate.</param>
        abstract extname: p: string -> string
        /// <summary>Returns an object from a path string - the opposite of format().</summary>
        /// <param name="pathString">path to evaluate.</param>
        abstract parse: pathString: string -> ParsedPath
        /// Returns a path string from an object - the opposite of parse().
        abstract format: pathObject: FormatInputPathObject -> string

    /// A parsed path object generated by path.parse() or consumed by path.format().
    type [<AllowNullLiteral>] ParsedPath =
        /// The root of the path such as '/' or 'c:\'
        abstract root: string with get, set
        /// The full directory path such as '/home/user/dir' or 'c:\path\dir'
        abstract dir: string with get, set
        /// The file name including extension (if any) such as 'index.html'
        abstract ``base``: string with get, set
        /// The file extension (if any) such as '.html'
        abstract ext: string with get, set
        /// The file name without extension (if any) such as 'index'
        abstract name: string with get, set

    type [<AllowNullLiteral>] FormatInputPathObject =
        /// The root of the path such as '/' or 'c:\'
        abstract root: string option with get, set
        /// The full directory path such as '/home/user/dir' or 'c:\path\dir'
        abstract dir: string option with get, set
        /// The file name including extension (if any) such as 'index.html'
        abstract ``base``: string option with get, set
        /// The file extension (if any) such as '.html'
        abstract ext: string option with get, set
        /// The file name without extension (if any) such as 'index'
        abstract name: string option with get, set
    let sep: U2<string, string> = jsNative
    let delimiter: U2<string, string> = jsNative

    module Posix =

        type [<AllowNullLiteral>] IExports =
            abstract normalize: p: string -> string
            abstract join: [<ParamArray>] paths: ResizeArray<obj option> -> string
            abstract resolve: [<ParamArray>] pathSegments: ResizeArray<obj option> -> string
            abstract isAbsolute: p: string -> bool
            abstract relative: from: string * ``to``: string -> string
            abstract dirname: p: string -> string
            abstract basename: p: string * ?ext: string -> string
            abstract extname: p: string -> string
            abstract parse: p: string -> ParsedPath
            abstract format: pP: FormatInputPathObject -> string
        let sep: string = jsNative
        let delimiter: string = jsNative

    module Win32 =

        type [<AllowNullLiteral>] IExports =
            abstract normalize: p: string -> string
            abstract join: [<ParamArray>] paths: ResizeArray<obj option> -> string
            abstract resolve: [<ParamArray>] pathSegments: ResizeArray<obj option> -> string
            abstract isAbsolute: p: string -> bool
            abstract relative: from: string * ``to``: string -> string
            abstract dirname: p: string -> string
            abstract basename: p: string * ?ext: string -> string
            abstract extname: p: string -> string
            abstract parse: p: string -> ParsedPath
            abstract format: pP: FormatInputPathObject -> string
        let sep: string = jsNative
        let delimiter: string = jsNative

module String_decoder =

    type [<AllowNullLiteral>] NodeStringDecoder =
        abstract write: buffer: Buffer -> string
        abstract ``end``: ?buffer: Buffer -> string
    let StringDecoder: obj = jsNative

module Tls =

    type [<AllowNullLiteral>] IExports =
        abstract CLIENT_RENEG_LIMIT: float
        abstract CLIENT_RENEG_WINDOW: float
        abstract TLSSocket: TLSSocketStatic
        abstract Server: ServerStatic
        abstract checkServerIdentity: host: string * cert: PeerCertificate -> Error option
        abstract createServer: options: TlsOptions * ?secureConnectionListener: (TLSSocket -> unit) -> Server
        abstract connect: options: ConnectionOptions * ?secureConnectionListener: (unit -> unit) -> TLSSocket
        abstract connect: port: float * ?host: string * ?options: ConnectionOptions * ?secureConnectListener: (unit -> unit) -> TLSSocket
        abstract connect: port: float * ?options: ConnectionOptions * ?secureConnectListener: (unit -> unit) -> TLSSocket
        abstract createSecurePair: ?credentials: Crypto.Credentials * ?isServer: bool * ?requestCert: bool * ?rejectUnauthorized: bool -> SecurePair
        abstract createSecureContext: details: SecureContextOptions -> SecureContext
        abstract getCiphers: unit -> ResizeArray<string>

    type [<AllowNullLiteral>] Certificate =
        /// Country code.
        abstract C: string with get, set
        /// Street.
        abstract ST: string with get, set
        /// Locality.
        abstract L: string with get, set
        /// Organization.
        abstract O: string with get, set
        /// Organizational unit.
        abstract OU: string with get, set
        /// Common name.
        abstract CN: string with get, set

    type [<AllowNullLiteral>] PeerCertificate =
        abstract subject: Certificate with get, set
        abstract issuer: Certificate with get, set
        abstract subjectaltname: string with get, set
        abstract infoAccess: obj with get, set
        abstract modulus: string with get, set
        abstract exponent: string with get, set
        abstract valid_from: string with get, set
        abstract valid_to: string with get, set
        abstract fingerprint: string with get, set
        abstract ext_key_usage: ResizeArray<string> with get, set
        abstract serialNumber: string with get, set
        abstract raw: Buffer with get, set

    type [<AllowNullLiteral>] DetailedPeerCertificate =
        inherit PeerCertificate
        abstract issuerCertificate: DetailedPeerCertificate with get, set

    type [<AllowNullLiteral>] CipherNameAndProtocol =
        /// The cipher name.
        abstract name: string with get, set
        /// SSL/TLS protocol version.
        abstract version: string with get, set

    type [<AllowNullLiteral>] TLSSocket =
        inherit Net.Socket
        /// A boolean that is true if the peer certificate was signed by one of the specified CAs, otherwise false.
        abstract authorized: bool with get, set
        /// The reason why the peer's certificate has not been verified.
        /// This property becomes available only when tlsSocket.authorized === false.
        abstract authorizationError: Error with get, set
        /// Static boolean value, always true.
        /// May be used to distinguish TLS sockets from regular ones.
        abstract encrypted: bool with get, set
        /// Returns an object representing the cipher name and the SSL/TLS protocol version of the current connection.
        abstract getCipher: unit -> CipherNameAndProtocol
        /// <summary>Returns an object representing the peer's certificate.
        /// The returned object has some properties corresponding to the field of the certificate.
        /// If detailed argument is true the full chain with issuer property will be returned,
        /// if false only the top certificate without issuer property.
        /// If the peer does not provide a certificate, it returns null or an empty object.</summary>
        /// <param name="detailed">- If true; the full chain with issuer property will be returned.</param>
        abstract getPeerCertificate: detailed: obj -> DetailedPeerCertificate
        abstract getPeerCertificate: ?detailed: obj -> PeerCertificate
        abstract getPeerCertificate: ?detailed: bool -> U2<PeerCertificate, DetailedPeerCertificate>
        /// Returns a string containing the negotiated SSL/TLS protocol version of the current connection.
        /// The value `'unknown'` will be returned for connected sockets that have not completed the handshaking process.
        /// The value `null` will be returned for server sockets or disconnected client sockets.
        /// See https://www.openssl.org/docs/man1.0.2/ssl/SSL_get_version.html for more information.
        abstract getProtocol: unit -> string option
        /// Could be used to speed up handshake establishment when reconnecting to the server.
        abstract getSession: unit -> obj option
        /// NOTE: Works only with client TLS sockets.
        /// Useful only for debugging, for session reuse provide session option to tls.connect().
        abstract getTLSTicket: unit -> obj option
        /// <summary>Initiate TLS renegotiation process.
        /// 
        /// NOTE: Can be used to request peer's certificate after the secure connection has been established.
        /// ANOTHER NOTE: When running as the server, socket will be destroyed with an error after handshakeTimeout timeout.</summary>
        /// <param name="options">- The options may contain the following fields: rejectUnauthorized,
        /// requestCert (See tls.createServer() for details).</param>
        /// <param name="callback">- callback(err) will be executed with null as err, once the renegotiation
        /// is successfully completed.</param>
        abstract renegotiate: options: TLSSocketRenegotiateOptions * callback: (Error option -> unit) -> obj option
        /// <summary>Set maximum TLS fragment size (default and maximum value is: 16384, minimum is: 512).
        /// Smaller fragment size decreases buffering latency on the client: large fragments are buffered by
        /// the TLS layer until the entire fragment is received and its integrity is verified;
        /// large fragments can span multiple roundtrips, and their processing can be delayed due to packet
        /// loss or reordering. However, smaller fragments add extra TLS framing bytes and CPU overhead,
        /// which may decrease overall server throughput.</summary>
        /// <param name="size">- TLS fragment size (default and maximum value is: 16384, minimum is: 512).</param>
        abstract setMaxSendFragment: size: float -> bool
        /// events.EventEmitter
        /// 1. OCSPResponse
        /// 2. secureConnect
        abstract addListener: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> TLSSocket
        [<Emit "$0.addListener('OCSPResponse',$1)">] abstract addListener_OCSPResponse: listener: (Buffer -> unit) -> TLSSocket
        [<Emit "$0.addListener('secureConnect',$1)">] abstract addListener_secureConnect: listener: (unit -> unit) -> TLSSocket
        abstract emit: ``event``: U2<string, Symbol> * [<ParamArray>] args: ResizeArray<obj option> -> bool
        [<Emit "$0.emit('OCSPResponse',$1)">] abstract emit_OCSPResponse: response: Buffer -> bool
        [<Emit "$0.emit('secureConnect')">] abstract emit_secureConnect: unit -> bool
        abstract on: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> TLSSocket
        [<Emit "$0.on('OCSPResponse',$1)">] abstract on_OCSPResponse: listener: (Buffer -> unit) -> TLSSocket
        [<Emit "$0.on('secureConnect',$1)">] abstract on_secureConnect: listener: (unit -> unit) -> TLSSocket
        abstract once: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> TLSSocket
        [<Emit "$0.once('OCSPResponse',$1)">] abstract once_OCSPResponse: listener: (Buffer -> unit) -> TLSSocket
        [<Emit "$0.once('secureConnect',$1)">] abstract once_secureConnect: listener: (unit -> unit) -> TLSSocket
        abstract prependListener: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> TLSSocket
        [<Emit "$0.prependListener('OCSPResponse',$1)">] abstract prependListener_OCSPResponse: listener: (Buffer -> unit) -> TLSSocket
        [<Emit "$0.prependListener('secureConnect',$1)">] abstract prependListener_secureConnect: listener: (unit -> unit) -> TLSSocket
        abstract prependOnceListener: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> TLSSocket
        [<Emit "$0.prependOnceListener('OCSPResponse',$1)">] abstract prependOnceListener_OCSPResponse: listener: (Buffer -> unit) -> TLSSocket
        [<Emit "$0.prependOnceListener('secureConnect',$1)">] abstract prependOnceListener_secureConnect: listener: (unit -> unit) -> TLSSocket

    type [<AllowNullLiteral>] TLSSocketRenegotiateOptions =
        abstract rejectUnauthorized: bool option with get, set
        abstract requestCert: bool option with get, set

    type [<AllowNullLiteral>] TLSSocketStatic =
        /// Construct a new tls.TLSSocket object from an existing TCP socket.
        [<Emit "new $0($1...)">] abstract Create: socket: Net.Socket * ?options: TLSSocketStaticOptions -> TLSSocket

    type [<AllowNullLiteral>] TLSSocketStaticOptions =
        /// An optional TLS context object from tls.createSecureContext()
        abstract secureContext: SecureContext option with get, set
        /// If true the TLS socket will be instantiated in server-mode.
        /// Defaults to false.
        abstract isServer: bool option with get, set
        /// An optional net.Server instance.
        abstract server: Net.Server option with get, set
        /// If true the server will request a certificate from clients that
        /// connect and attempt to verify that certificate. Defaults to
        /// false.
        abstract requestCert: bool option with get, set
        /// If true the server will reject any connection which is not
        /// authorized with the list of supplied CAs. This option only has an
        /// effect if requestCert is true. Defaults to false.
        abstract rejectUnauthorized: bool option with get, set
        /// An array of strings or a Buffer naming possible NPN protocols.
        /// (Protocols should be ordered by their priority.)
        abstract NPNProtocols: U5<ResizeArray<string>, ResizeArray<Buffer>, ResizeArray<Uint8Array>, Buffer, Uint8Array> option with get, set
        /// An array of strings or a Buffer naming possible ALPN protocols.
        /// (Protocols should be ordered by their priority.) When the server
        /// receives both NPN and ALPN extensions from the client, ALPN takes
        /// precedence over NPN and the server does not send an NPN extension
        /// to the client.
        abstract ALPNProtocols: U5<ResizeArray<string>, ResizeArray<Buffer>, ResizeArray<Uint8Array>, Buffer, Uint8Array> option with get, set
        /// SNICallback(servername, cb) <Function> A function that will be
        /// called if the client supports SNI TLS extension. Two arguments
        /// will be passed when called: servername and cb. SNICallback should
        /// invoke cb(null, ctx), where ctx is a SecureContext instance.
        /// (tls.createSecureContext(...) can be used to get a proper
        /// SecureContext.) If SNICallback wasn't provided the default callback
        /// with high-level API will be used (see below).
        abstract SNICallback: (string -> (Error option -> SecureContext -> unit) -> unit) option with get, set
        /// An optional Buffer instance containing a TLS session.
        abstract session: Buffer option with get, set
        /// If true, specifies that the OCSP status request extension will be
        /// added to the client hello and an 'OCSPResponse' event will be
        /// emitted on the socket before establishing a secure communication
        abstract requestOCSP: bool option with get, set

    type [<AllowNullLiteral>] TlsOptions =
        inherit SecureContextOptions
        abstract handshakeTimeout: float option with get, set
        abstract requestCert: bool option with get, set
        abstract rejectUnauthorized: bool option with get, set
        abstract NPNProtocols: U5<ResizeArray<string>, ResizeArray<Buffer>, ResizeArray<Uint8Array>, Buffer, Uint8Array> option with get, set
        abstract ALPNProtocols: U5<ResizeArray<string>, ResizeArray<Buffer>, ResizeArray<Uint8Array>, Buffer, Uint8Array> option with get, set
        abstract SNICallback: (string -> (Error option -> SecureContext -> unit) -> unit) option with get, set
        abstract sessionTimeout: float option with get, set
        abstract ticketKeys: Buffer option with get, set

    type [<AllowNullLiteral>] ConnectionOptions =
        inherit SecureContextOptions
        abstract host: string option with get, set
        abstract port: float option with get, set
        abstract path: string option with get, set
        abstract socket: Net.Socket option with get, set
        abstract rejectUnauthorized: bool option with get, set
        abstract NPNProtocols: U5<ResizeArray<string>, ResizeArray<Buffer>, ResizeArray<Uint8Array>, Buffer, Uint8Array> option with get, set
        abstract ALPNProtocols: U5<ResizeArray<string>, ResizeArray<Buffer>, ResizeArray<Uint8Array>, Buffer, Uint8Array> option with get, set
        abstract checkServerIdentity: obj option with get, set
        abstract servername: string option with get, set
        abstract session: Buffer option with get, set
        abstract minDHSize: float option with get, set
        abstract secureContext: SecureContext option with get, set
        abstract lookup: Net.LookupFunction option with get, set

    type [<AllowNullLiteral>] Server =
        inherit Net.Server
        abstract addContext: hostName: string * credentials: ServerAddContextCredentials -> unit
        /// events.EventEmitter
        /// 1. tlsClientError
        /// 2. newSession
        /// 3. OCSPRequest
        /// 4. resumeSession
        /// 5. secureConnection
        abstract addListener: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> Server
        [<Emit "$0.addListener('tlsClientError',$1)">] abstract addListener_tlsClientError: listener: (Error -> TLSSocket -> unit) -> Server
        [<Emit "$0.addListener('newSession',$1)">] abstract addListener_newSession: listener: (obj option -> obj option -> (Error -> Buffer -> unit) -> unit) -> Server
        [<Emit "$0.addListener('OCSPRequest',$1)">] abstract addListener_OCSPRequest: listener: (Buffer -> Buffer -> Function -> unit) -> Server
        [<Emit "$0.addListener('resumeSession',$1)">] abstract addListener_resumeSession: listener: (obj option -> (Error -> obj option -> unit) -> unit) -> Server
        [<Emit "$0.addListener('secureConnection',$1)">] abstract addListener_secureConnection: listener: (TLSSocket -> unit) -> Server
        abstract emit: ``event``: U2<string, Symbol> * [<ParamArray>] args: ResizeArray<obj option> -> bool
        [<Emit "$0.emit('tlsClientError',$1,$2)">] abstract emit_tlsClientError: err: Error * tlsSocket: TLSSocket -> bool
        [<Emit "$0.emit('newSession',$1,$2,$3)">] abstract emit_newSession: sessionId: obj option * sessionData: obj option * callback: (Error -> Buffer -> unit) -> bool
        [<Emit "$0.emit('OCSPRequest',$1,$2,$3)">] abstract emit_OCSPRequest: certificate: Buffer * issuer: Buffer * callback: Function -> bool
        [<Emit "$0.emit('resumeSession',$1,$2)">] abstract emit_resumeSession: sessionId: obj option * callback: (Error -> obj option -> unit) -> bool
        [<Emit "$0.emit('secureConnection',$1)">] abstract emit_secureConnection: tlsSocket: TLSSocket -> bool
        abstract on: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> Server
        [<Emit "$0.on('tlsClientError',$1)">] abstract on_tlsClientError: listener: (Error -> TLSSocket -> unit) -> Server
        [<Emit "$0.on('newSession',$1)">] abstract on_newSession: listener: (obj option -> obj option -> (Error -> Buffer -> unit) -> unit) -> Server
        [<Emit "$0.on('OCSPRequest',$1)">] abstract on_OCSPRequest: listener: (Buffer -> Buffer -> Function -> unit) -> Server
        [<Emit "$0.on('resumeSession',$1)">] abstract on_resumeSession: listener: (obj option -> (Error -> obj option -> unit) -> unit) -> Server
        [<Emit "$0.on('secureConnection',$1)">] abstract on_secureConnection: listener: (TLSSocket -> unit) -> Server
        abstract once: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> Server
        [<Emit "$0.once('tlsClientError',$1)">] abstract once_tlsClientError: listener: (Error -> TLSSocket -> unit) -> Server
        [<Emit "$0.once('newSession',$1)">] abstract once_newSession: listener: (obj option -> obj option -> (Error -> Buffer -> unit) -> unit) -> Server
        [<Emit "$0.once('OCSPRequest',$1)">] abstract once_OCSPRequest: listener: (Buffer -> Buffer -> Function -> unit) -> Server
        [<Emit "$0.once('resumeSession',$1)">] abstract once_resumeSession: listener: (obj option -> (Error -> obj option -> unit) -> unit) -> Server
        [<Emit "$0.once('secureConnection',$1)">] abstract once_secureConnection: listener: (TLSSocket -> unit) -> Server
        abstract prependListener: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> Server
        [<Emit "$0.prependListener('tlsClientError',$1)">] abstract prependListener_tlsClientError: listener: (Error -> TLSSocket -> unit) -> Server
        [<Emit "$0.prependListener('newSession',$1)">] abstract prependListener_newSession: listener: (obj option -> obj option -> (Error -> Buffer -> unit) -> unit) -> Server
        [<Emit "$0.prependListener('OCSPRequest',$1)">] abstract prependListener_OCSPRequest: listener: (Buffer -> Buffer -> Function -> unit) -> Server
        [<Emit "$0.prependListener('resumeSession',$1)">] abstract prependListener_resumeSession: listener: (obj option -> (Error -> obj option -> unit) -> unit) -> Server
        [<Emit "$0.prependListener('secureConnection',$1)">] abstract prependListener_secureConnection: listener: (TLSSocket -> unit) -> Server
        abstract prependOnceListener: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> Server
        [<Emit "$0.prependOnceListener('tlsClientError',$1)">] abstract prependOnceListener_tlsClientError: listener: (Error -> TLSSocket -> unit) -> Server
        [<Emit "$0.prependOnceListener('newSession',$1)">] abstract prependOnceListener_newSession: listener: (obj option -> obj option -> (Error -> Buffer -> unit) -> unit) -> Server
        [<Emit "$0.prependOnceListener('OCSPRequest',$1)">] abstract prependOnceListener_OCSPRequest: listener: (Buffer -> Buffer -> Function -> unit) -> Server
        [<Emit "$0.prependOnceListener('resumeSession',$1)">] abstract prependOnceListener_resumeSession: listener: (obj option -> (Error -> obj option -> unit) -> unit) -> Server
        [<Emit "$0.prependOnceListener('secureConnection',$1)">] abstract prependOnceListener_secureConnection: listener: (TLSSocket -> unit) -> Server

    type [<AllowNullLiteral>] ServerAddContextCredentials =
        abstract key: string with get, set
        abstract cert: string with get, set
        abstract ca: string with get, set

    type [<AllowNullLiteral>] ServerStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> Server

    type [<AllowNullLiteral>] ClearTextStream =
        inherit Stream.Duplex
        abstract authorized: bool with get, set
        abstract authorizationError: Error with get, set
        abstract getPeerCertificate: unit -> obj option
        abstract getCipher: obj with get, set
        abstract address: obj with get, set
        abstract remoteAddress: string with get, set
        abstract remotePort: float with get, set

    type [<AllowNullLiteral>] SecurePair =
        abstract encrypted: obj option with get, set
        abstract cleartext: obj option with get, set

    type [<AllowNullLiteral>] SecureContextOptions =
        abstract pfx: U3<string, Buffer, Array<U3<string, Buffer, Object>>> option with get, set
        abstract key: U3<string, Buffer, Array<U2<Buffer, Object>>> option with get, set
        abstract passphrase: string option with get, set
        abstract cert: U3<string, Buffer, Array<U2<string, Buffer>>> option with get, set
        abstract ca: U3<string, Buffer, Array<U2<string, Buffer>>> option with get, set
        abstract ciphers: string option with get, set
        abstract honorCipherOrder: bool option with get, set
        abstract ecdhCurve: string option with get, set
        abstract crl: U3<string, Buffer, Array<U2<string, Buffer>>> option with get, set
        abstract dhparam: U2<string, Buffer> option with get, set
        abstract secureOptions: float option with get, set
        abstract secureProtocol: string option with get, set
        abstract sessionIdContext: string option with get, set

    type [<AllowNullLiteral>] SecureContext =
        abstract context: obj option with get, set
    let DEFAULT_ECDH_CURVE: string = jsNative

module Crypto =

    type [<AllowNullLiteral>] IExports =
        abstract createCredentials: details: CredentialDetails -> Credentials
        abstract createHash: algorithm: string -> Hash
        abstract createHmac: algorithm: string * key: U2<string, Buffer> -> Hmac
        abstract createCipher: algorithm: string * password: obj option -> Cipher
        abstract createCipheriv: algorithm: string * key: obj option * iv: obj option -> Cipher
        abstract createDecipher: algorithm: string * password: obj option -> Decipher
        abstract createDecipheriv: algorithm: string * key: obj option * iv: obj option -> Decipher
        abstract createSign: algorithm: string -> Signer
        abstract createVerify: algorith: string -> Verify
        abstract createDiffieHellman: prime_length: float * ?generator: float -> DiffieHellman
        abstract createDiffieHellman: prime: Buffer -> DiffieHellman
        abstract createDiffieHellman: prime: string * prime_encoding: HexBase64Latin1Encoding -> DiffieHellman
        abstract createDiffieHellman: prime: string * prime_encoding: HexBase64Latin1Encoding * generator: U2<float, Buffer> -> DiffieHellman
        abstract createDiffieHellman: prime: string * prime_encoding: HexBase64Latin1Encoding * generator: string * generator_encoding: HexBase64Latin1Encoding -> DiffieHellman
        abstract getDiffieHellman: group_name: string -> DiffieHellman
        abstract pbkdf2: password: U2<string, Buffer> * salt: U2<string, Buffer> * iterations: float * keylen: float * digest: string * callback: (Error -> Buffer -> obj option) -> unit
        abstract pbkdf2Sync: password: U2<string, Buffer> * salt: U2<string, Buffer> * iterations: float * keylen: float * digest: string -> Buffer
        abstract randomBytes: size: float -> Buffer
        abstract randomBytes: size: float * callback: (Error -> Buffer -> unit) -> unit
        abstract pseudoRandomBytes: size: float -> Buffer
        abstract pseudoRandomBytes: size: float * callback: (Error -> Buffer -> unit) -> unit
        abstract randomFillSync: buffer: U2<Buffer, Uint8Array> * ?offset: float * ?size: float -> Buffer
        abstract randomFill: buffer: Buffer * callback: (Error -> Buffer -> unit) -> unit
        abstract randomFill: buffer: Uint8Array * callback: (Error -> Uint8Array -> unit) -> unit
        abstract randomFill: buffer: Buffer * offset: float * callback: (Error -> Buffer -> unit) -> unit
        abstract randomFill: buffer: Uint8Array * offset: float * callback: (Error -> Uint8Array -> unit) -> unit
        abstract randomFill: buffer: Buffer * offset: float * size: float * callback: (Error -> Buffer -> unit) -> unit
        abstract randomFill: buffer: Uint8Array * offset: float * size: float * callback: (Error -> Uint8Array -> unit) -> unit
        abstract publicEncrypt: public_key: U2<string, RsaPublicKey> * buffer: Buffer -> Buffer
        abstract privateDecrypt: private_key: U2<string, RsaPrivateKey> * buffer: Buffer -> Buffer
        abstract privateEncrypt: private_key: U2<string, RsaPrivateKey> * buffer: Buffer -> Buffer
        abstract publicDecrypt: public_key: U2<string, RsaPublicKey> * buffer: Buffer -> Buffer
        abstract getCiphers: unit -> ResizeArray<string>
        abstract getCurves: unit -> ResizeArray<string>
        abstract getHashes: unit -> ResizeArray<string>
        abstract createECDH: curve_name: string -> ECDH
        abstract timingSafeEqual: a: Buffer * b: Buffer -> bool

    type [<AllowNullLiteral>] Certificate =
        abstract exportChallenge: spkac: U2<string, Buffer> -> Buffer
        abstract exportPublicKey: spkac: U2<string, Buffer> -> Buffer
        abstract verifySpkac: spkac: Buffer -> bool
    let Certificate: obj = jsNative
    let fips: bool = jsNative

    type [<AllowNullLiteral>] CredentialDetails =
        abstract pfx: string with get, set
        abstract key: string with get, set
        abstract passphrase: string with get, set
        abstract cert: string with get, set
        abstract ca: U2<string, ResizeArray<string>> with get, set
        abstract crl: U2<string, ResizeArray<string>> with get, set
        abstract ciphers: string with get, set

    type [<AllowNullLiteral>] Credentials =
        abstract context: obj option with get, set

    type [<StringEnum>] [<RequireQualifiedAccess>] Utf8AsciiLatin1Encoding =
        | Utf8
        | Ascii
        | Latin1

    type [<StringEnum>] [<RequireQualifiedAccess>] HexBase64Latin1Encoding =
        | Latin1
        | Hex
        | Base64

    type [<StringEnum>] [<RequireQualifiedAccess>] Utf8AsciiBinaryEncoding =
        | Utf8
        | Ascii
        | Binary

    type [<StringEnum>] [<RequireQualifiedAccess>] HexBase64BinaryEncoding =
        | Binary
        | Base64
        | Hex

    type [<StringEnum>] [<RequireQualifiedAccess>] ECDHKeyFormat =
        | Compressed
        | Uncompressed
        | Hybrid

    type [<AllowNullLiteral>] Hash =
        inherit NodeJS.ReadWriteStream
        abstract update: data: U3<string, Buffer, DataView> -> Hash
        abstract update: data: U3<string, Buffer, DataView> * input_encoding: Utf8AsciiLatin1Encoding -> Hash
        abstract digest: unit -> Buffer
        abstract digest: encoding: HexBase64Latin1Encoding -> string

    type [<AllowNullLiteral>] Hmac =
        inherit NodeJS.ReadWriteStream
        abstract update: data: U3<string, Buffer, DataView> -> Hmac
        abstract update: data: U3<string, Buffer, DataView> * input_encoding: Utf8AsciiLatin1Encoding -> Hmac
        abstract digest: unit -> Buffer
        abstract digest: encoding: HexBase64Latin1Encoding -> string

    type [<AllowNullLiteral>] Cipher =
        inherit NodeJS.ReadWriteStream
        abstract update: data: U2<Buffer, DataView> -> Buffer
        abstract update: data: string * input_encoding: Utf8AsciiBinaryEncoding -> Buffer
        abstract update: data: U2<Buffer, DataView> * input_encoding: obj option * output_encoding: HexBase64BinaryEncoding -> string
        abstract update: data: string * input_encoding: Utf8AsciiBinaryEncoding * output_encoding: HexBase64BinaryEncoding -> string
        abstract final: unit -> Buffer
        abstract final: output_encoding: string -> string
        abstract setAutoPadding: ?auto_padding: bool -> Cipher
        abstract getAuthTag: unit -> Buffer
        abstract setAAD: buffer: Buffer -> Cipher

    type [<AllowNullLiteral>] Decipher =
        inherit NodeJS.ReadWriteStream
        abstract update: data: U2<Buffer, DataView> -> Buffer
        abstract update: data: string * input_encoding: HexBase64BinaryEncoding -> Buffer
        abstract update: data: U2<Buffer, DataView> * input_encoding: obj option * output_encoding: Utf8AsciiBinaryEncoding -> string
        abstract update: data: string * input_encoding: HexBase64BinaryEncoding * output_encoding: Utf8AsciiBinaryEncoding -> string
        abstract final: unit -> Buffer
        abstract final: output_encoding: string -> string
        abstract setAutoPadding: ?auto_padding: bool -> Decipher
        abstract setAuthTag: tag: Buffer -> Decipher
        abstract setAAD: buffer: Buffer -> Decipher

    type [<AllowNullLiteral>] Signer =
        inherit NodeJS.WritableStream
        abstract update: data: U3<string, Buffer, DataView> -> Signer
        abstract update: data: U3<string, Buffer, DataView> * input_encoding: Utf8AsciiLatin1Encoding -> Signer
        abstract sign: private_key: U2<string, obj> -> Buffer
        abstract sign: private_key: U2<string, obj> * output_format: HexBase64Latin1Encoding -> string

    type [<AllowNullLiteral>] Verify =
        inherit NodeJS.WritableStream
        abstract update: data: U3<string, Buffer, DataView> -> Verify
        abstract update: data: U3<string, Buffer, DataView> * input_encoding: Utf8AsciiLatin1Encoding -> Verify
        abstract verify: ``object``: U2<string, Object> * signature: U2<Buffer, DataView> -> bool
        abstract verify: ``object``: U2<string, Object> * signature: string * signature_format: HexBase64Latin1Encoding -> bool

    type [<AllowNullLiteral>] DiffieHellman =
        abstract generateKeys: unit -> Buffer
        abstract generateKeys: encoding: HexBase64Latin1Encoding -> string
        abstract computeSecret: other_public_key: Buffer -> Buffer
        abstract computeSecret: other_public_key: string * input_encoding: HexBase64Latin1Encoding -> Buffer
        abstract computeSecret: other_public_key: string * input_encoding: HexBase64Latin1Encoding * output_encoding: HexBase64Latin1Encoding -> string
        abstract getPrime: unit -> Buffer
        abstract getPrime: encoding: HexBase64Latin1Encoding -> string
        abstract getGenerator: unit -> Buffer
        abstract getGenerator: encoding: HexBase64Latin1Encoding -> string
        abstract getPublicKey: unit -> Buffer
        abstract getPublicKey: encoding: HexBase64Latin1Encoding -> string
        abstract getPrivateKey: unit -> Buffer
        abstract getPrivateKey: encoding: HexBase64Latin1Encoding -> string
        abstract setPublicKey: public_key: Buffer -> unit
        abstract setPublicKey: public_key: string * encoding: string -> unit
        abstract setPrivateKey: private_key: Buffer -> unit
        abstract setPrivateKey: private_key: string * encoding: string -> unit
        abstract verifyError: float with get, set

    type [<AllowNullLiteral>] RsaPublicKey =
        abstract key: string with get, set
        abstract padding: float option with get, set

    type [<AllowNullLiteral>] RsaPrivateKey =
        abstract key: string with get, set
        abstract passphrase: string option with get, set
        abstract padding: float option with get, set

    type [<AllowNullLiteral>] ECDH =
        abstract generateKeys: unit -> Buffer
        abstract generateKeys: encoding: HexBase64Latin1Encoding -> string
        abstract generateKeys: encoding: HexBase64Latin1Encoding * format: ECDHKeyFormat -> string
        abstract computeSecret: other_public_key: Buffer -> Buffer
        abstract computeSecret: other_public_key: string * input_encoding: HexBase64Latin1Encoding -> Buffer
        abstract computeSecret: other_public_key: string * input_encoding: HexBase64Latin1Encoding * output_encoding: HexBase64Latin1Encoding -> string
        abstract getPrivateKey: unit -> Buffer
        abstract getPrivateKey: encoding: HexBase64Latin1Encoding -> string
        abstract getPublicKey: unit -> Buffer
        abstract getPublicKey: encoding: HexBase64Latin1Encoding -> string
        abstract getPublicKey: encoding: HexBase64Latin1Encoding * format: ECDHKeyFormat -> string
        abstract setPrivateKey: private_key: Buffer -> unit
        abstract setPrivateKey: private_key: string * encoding: HexBase64Latin1Encoding -> unit
    let DEFAULT_ENCODING: string = jsNative

module Stream =

    type [<AllowNullLiteral>] IExports =
        abstract ``internal``: internalStatic
        abstract Stream: StreamStatic
        abstract Readable: ReadableStatic
        abstract Writable: WritableStatic
        abstract Duplex: DuplexStatic
        abstract Transform: TransformStatic
        abstract PassThrough: PassThroughStatic

    type [<AllowNullLiteral>] ``internal`` =
        inherit Events.EventEmitter
        abstract pipe: destination: 'T * ?options: InternalPipeOptions -> 'T

    type [<AllowNullLiteral>] InternalPipeOptions =
        abstract ``end``: bool option with get, set

    type [<AllowNullLiteral>] internalStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> ``internal``

    type [<AllowNullLiteral>] Stream =
        inherit ``internal``

    type [<AllowNullLiteral>] StreamStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> Stream

    type [<AllowNullLiteral>] ReadableOptions =
        abstract highWaterMark: float option with get, set
        abstract encoding: string option with get, set
        abstract objectMode: bool option with get, set
        abstract read: (Readable -> float -> obj option) option with get, set
        abstract destroy: (Error -> obj option) option with get, set

    type [<AllowNullLiteral>] Readable =
        inherit Stream
        inherit NodeJS.ReadableStream
        abstract readable: bool with get, set
        abstract readableHighWaterMark: float
        abstract _read: size: float -> unit
        abstract read: ?size: float -> obj option
        abstract setEncoding: encoding: string -> Readable
        abstract pause: unit -> Readable
        abstract resume: unit -> Readable
        abstract isPaused: unit -> bool
        abstract unpipe: ?destination: 'T -> Readable
        abstract unshift: chunk: obj option -> unit
        abstract wrap: oldStream: NodeJS.ReadableStream -> Readable
        abstract push: chunk: obj option * ?encoding: string -> bool
        abstract _destroy: err: Error * callback: Function -> unit
        abstract destroy: ?error: Error -> unit
        /// Event emitter
        /// The defined events on documents including:
        /// 1. close
        /// 2. data
        /// 3. end
        /// 4. readable
        /// 5. error
        abstract addListener: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> Readable
        [<Emit "$0.addListener('close',$1)">] abstract addListener_close: listener: (unit -> unit) -> Readable
        [<Emit "$0.addListener('data',$1)">] abstract addListener_data: listener: (U2<Buffer, string> -> unit) -> Readable
        [<Emit "$0.addListener('end',$1)">] abstract addListener_end: listener: (unit -> unit) -> Readable
        [<Emit "$0.addListener('readable',$1)">] abstract addListener_readable: listener: (unit -> unit) -> Readable
        [<Emit "$0.addListener('error',$1)">] abstract addListener_error: listener: (Error -> unit) -> Readable
        abstract emit: ``event``: U2<string, Symbol> * [<ParamArray>] args: ResizeArray<obj option> -> bool
        [<Emit "$0.emit('close')">] abstract emit_close: unit -> bool
        [<Emit "$0.emit('data',$1)">] abstract emit_data: chunk: U2<Buffer, string> -> bool
        [<Emit "$0.emit('end')">] abstract emit_end: unit -> bool
        [<Emit "$0.emit('readable')">] abstract emit_readable: unit -> bool
        [<Emit "$0.emit('error',$1)">] abstract emit_error: err: Error -> bool
        abstract on: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> Readable
        [<Emit "$0.on('close',$1)">] abstract on_close: listener: (unit -> unit) -> Readable
        [<Emit "$0.on('data',$1)">] abstract on_data: listener: (U2<Buffer, string> -> unit) -> Readable
        [<Emit "$0.on('end',$1)">] abstract on_end: listener: (unit -> unit) -> Readable
        [<Emit "$0.on('readable',$1)">] abstract on_readable: listener: (unit -> unit) -> Readable
        [<Emit "$0.on('error',$1)">] abstract on_error: listener: (Error -> unit) -> Readable
        abstract once: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> Readable
        [<Emit "$0.once('close',$1)">] abstract once_close: listener: (unit -> unit) -> Readable
        [<Emit "$0.once('data',$1)">] abstract once_data: listener: (U2<Buffer, string> -> unit) -> Readable
        [<Emit "$0.once('end',$1)">] abstract once_end: listener: (unit -> unit) -> Readable
        [<Emit "$0.once('readable',$1)">] abstract once_readable: listener: (unit -> unit) -> Readable
        [<Emit "$0.once('error',$1)">] abstract once_error: listener: (Error -> unit) -> Readable
        abstract prependListener: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> Readable
        [<Emit "$0.prependListener('close',$1)">] abstract prependListener_close: listener: (unit -> unit) -> Readable
        [<Emit "$0.prependListener('data',$1)">] abstract prependListener_data: listener: (U2<Buffer, string> -> unit) -> Readable
        [<Emit "$0.prependListener('end',$1)">] abstract prependListener_end: listener: (unit -> unit) -> Readable
        [<Emit "$0.prependListener('readable',$1)">] abstract prependListener_readable: listener: (unit -> unit) -> Readable
        [<Emit "$0.prependListener('error',$1)">] abstract prependListener_error: listener: (Error -> unit) -> Readable
        abstract prependOnceListener: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> Readable
        [<Emit "$0.prependOnceListener('close',$1)">] abstract prependOnceListener_close: listener: (unit -> unit) -> Readable
        [<Emit "$0.prependOnceListener('data',$1)">] abstract prependOnceListener_data: listener: (U2<Buffer, string> -> unit) -> Readable
        [<Emit "$0.prependOnceListener('end',$1)">] abstract prependOnceListener_end: listener: (unit -> unit) -> Readable
        [<Emit "$0.prependOnceListener('readable',$1)">] abstract prependOnceListener_readable: listener: (unit -> unit) -> Readable
        [<Emit "$0.prependOnceListener('error',$1)">] abstract prependOnceListener_error: listener: (Error -> unit) -> Readable
        abstract removeListener: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> Readable
        [<Emit "$0.removeListener('close',$1)">] abstract removeListener_close: listener: (unit -> unit) -> Readable
        [<Emit "$0.removeListener('data',$1)">] abstract removeListener_data: listener: (U2<Buffer, string> -> unit) -> Readable
        [<Emit "$0.removeListener('end',$1)">] abstract removeListener_end: listener: (unit -> unit) -> Readable
        [<Emit "$0.removeListener('readable',$1)">] abstract removeListener_readable: listener: (unit -> unit) -> Readable
        [<Emit "$0.removeListener('error',$1)">] abstract removeListener_error: listener: (Error -> unit) -> Readable

    type [<AllowNullLiteral>] ReadableStatic =
        [<Emit "new $0($1...)">] abstract Create: ?opts: ReadableOptions -> Readable

    type [<AllowNullLiteral>] WritableOptions =
        abstract highWaterMark: float option with get, set
        abstract decodeStrings: bool option with get, set
        abstract objectMode: bool option with get, set
        abstract write: (obj option -> string -> Function -> obj option) option with get, set
        abstract writev: (Array<obj> -> Function -> obj option) option with get, set
        abstract destroy: (Error -> obj option) option with get, set
        abstract final: ((Error -> unit) -> unit) option with get, set

    type [<AllowNullLiteral>] Writable =
        inherit Stream
        inherit NodeJS.WritableStream
        abstract writable: bool with get, set
        abstract writableHighWaterMark: float
        abstract _write: chunk: obj option * encoding: string * callback: (Error -> unit) -> unit
        abstract _writev: chunks: Array<obj> * callback: (Error -> unit) -> unit
        abstract _destroy: err: Error * callback: Function -> unit
        abstract _final: callback: Function -> unit
        abstract write: chunk: obj option * ?cb: Function -> bool
        abstract write: chunk: obj option * ?encoding: string * ?cb: Function -> bool
        abstract setDefaultEncoding: encoding: string -> Writable
        abstract ``end``: ?cb: Function -> unit
        abstract ``end``: chunk: obj option * ?cb: Function -> unit
        abstract ``end``: chunk: obj option * ?encoding: string * ?cb: Function -> unit
        abstract cork: unit -> unit
        abstract uncork: unit -> unit
        abstract destroy: ?error: Error -> unit
        /// Event emitter
        /// The defined events on documents including:
        /// 1. close
        /// 2. drain
        /// 3. error
        /// 4. finish
        /// 5. pipe
        /// 6. unpipe
        abstract addListener: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> Writable
        [<Emit "$0.addListener('close',$1)">] abstract addListener_close: listener: (unit -> unit) -> Writable
        [<Emit "$0.addListener('drain',$1)">] abstract addListener_drain: listener: (unit -> unit) -> Writable
        [<Emit "$0.addListener('error',$1)">] abstract addListener_error: listener: (Error -> unit) -> Writable
        [<Emit "$0.addListener('finish',$1)">] abstract addListener_finish: listener: (unit -> unit) -> Writable
        [<Emit "$0.addListener('pipe',$1)">] abstract addListener_pipe: listener: (Readable -> unit) -> Writable
        [<Emit "$0.addListener('unpipe',$1)">] abstract addListener_unpipe: listener: (Readable -> unit) -> Writable
        abstract emit: ``event``: U2<string, Symbol> * [<ParamArray>] args: ResizeArray<obj option> -> bool
        [<Emit "$0.emit('close')">] abstract emit_close: unit -> bool
        [<Emit "$0.emit('drain',$1)">] abstract emit_drain: chunk: U2<Buffer, string> -> bool
        [<Emit "$0.emit('error',$1)">] abstract emit_error: err: Error -> bool
        [<Emit "$0.emit('finish')">] abstract emit_finish: unit -> bool
        [<Emit "$0.emit('pipe',$1)">] abstract emit_pipe: src: Readable -> bool
        [<Emit "$0.emit('unpipe',$1)">] abstract emit_unpipe: src: Readable -> bool
        abstract on: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> Writable
        [<Emit "$0.on('close',$1)">] abstract on_close: listener: (unit -> unit) -> Writable
        [<Emit "$0.on('drain',$1)">] abstract on_drain: listener: (unit -> unit) -> Writable
        [<Emit "$0.on('error',$1)">] abstract on_error: listener: (Error -> unit) -> Writable
        [<Emit "$0.on('finish',$1)">] abstract on_finish: listener: (unit -> unit) -> Writable
        [<Emit "$0.on('pipe',$1)">] abstract on_pipe: listener: (Readable -> unit) -> Writable
        [<Emit "$0.on('unpipe',$1)">] abstract on_unpipe: listener: (Readable -> unit) -> Writable
        abstract once: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> Writable
        [<Emit "$0.once('close',$1)">] abstract once_close: listener: (unit -> unit) -> Writable
        [<Emit "$0.once('drain',$1)">] abstract once_drain: listener: (unit -> unit) -> Writable
        [<Emit "$0.once('error',$1)">] abstract once_error: listener: (Error -> unit) -> Writable
        [<Emit "$0.once('finish',$1)">] abstract once_finish: listener: (unit -> unit) -> Writable
        [<Emit "$0.once('pipe',$1)">] abstract once_pipe: listener: (Readable -> unit) -> Writable
        [<Emit "$0.once('unpipe',$1)">] abstract once_unpipe: listener: (Readable -> unit) -> Writable
        abstract prependListener: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> Writable
        [<Emit "$0.prependListener('close',$1)">] abstract prependListener_close: listener: (unit -> unit) -> Writable
        [<Emit "$0.prependListener('drain',$1)">] abstract prependListener_drain: listener: (unit -> unit) -> Writable
        [<Emit "$0.prependListener('error',$1)">] abstract prependListener_error: listener: (Error -> unit) -> Writable
        [<Emit "$0.prependListener('finish',$1)">] abstract prependListener_finish: listener: (unit -> unit) -> Writable
        [<Emit "$0.prependListener('pipe',$1)">] abstract prependListener_pipe: listener: (Readable -> unit) -> Writable
        [<Emit "$0.prependListener('unpipe',$1)">] abstract prependListener_unpipe: listener: (Readable -> unit) -> Writable
        abstract prependOnceListener: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> Writable
        [<Emit "$0.prependOnceListener('close',$1)">] abstract prependOnceListener_close: listener: (unit -> unit) -> Writable
        [<Emit "$0.prependOnceListener('drain',$1)">] abstract prependOnceListener_drain: listener: (unit -> unit) -> Writable
        [<Emit "$0.prependOnceListener('error',$1)">] abstract prependOnceListener_error: listener: (Error -> unit) -> Writable
        [<Emit "$0.prependOnceListener('finish',$1)">] abstract prependOnceListener_finish: listener: (unit -> unit) -> Writable
        [<Emit "$0.prependOnceListener('pipe',$1)">] abstract prependOnceListener_pipe: listener: (Readable -> unit) -> Writable
        [<Emit "$0.prependOnceListener('unpipe',$1)">] abstract prependOnceListener_unpipe: listener: (Readable -> unit) -> Writable
        abstract removeListener: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> Writable
        [<Emit "$0.removeListener('close',$1)">] abstract removeListener_close: listener: (unit -> unit) -> Writable
        [<Emit "$0.removeListener('drain',$1)">] abstract removeListener_drain: listener: (unit -> unit) -> Writable
        [<Emit "$0.removeListener('error',$1)">] abstract removeListener_error: listener: (Error -> unit) -> Writable
        [<Emit "$0.removeListener('finish',$1)">] abstract removeListener_finish: listener: (unit -> unit) -> Writable
        [<Emit "$0.removeListener('pipe',$1)">] abstract removeListener_pipe: listener: (Readable -> unit) -> Writable
        [<Emit "$0.removeListener('unpipe',$1)">] abstract removeListener_unpipe: listener: (Readable -> unit) -> Writable

    type [<AllowNullLiteral>] WritableStatic =
        [<Emit "new $0($1...)">] abstract Create: ?opts: WritableOptions -> Writable

    type [<AllowNullLiteral>] DuplexOptions =
        inherit ReadableOptions
        inherit WritableOptions
        abstract allowHalfOpen: bool option with get, set
        abstract readableObjectMode: bool option with get, set
        abstract writableObjectMode: bool option with get, set

    type [<AllowNullLiteral>] Duplex =
        inherit Readable
        inherit Writable
        abstract writable: bool with get, set
        abstract writableHighWaterMark: float
        abstract _write: chunk: obj option * encoding: string * callback: (Error -> unit) -> unit
        abstract _writev: chunks: Array<obj> * callback: (Error -> unit) -> unit
        abstract _destroy: err: Error * callback: Function -> unit
        abstract _final: callback: Function -> unit
        abstract write: chunk: obj option * ?cb: Function -> bool
        abstract write: chunk: obj option * ?encoding: string * ?cb: Function -> bool
        abstract setDefaultEncoding: encoding: string -> Duplex
        abstract ``end``: ?cb: Function -> unit
        abstract ``end``: chunk: obj option * ?cb: Function -> unit
        abstract ``end``: chunk: obj option * ?encoding: string * ?cb: Function -> unit
        abstract cork: unit -> unit
        abstract uncork: unit -> unit

    type [<AllowNullLiteral>] DuplexStatic =
        [<Emit "new $0($1...)">] abstract Create: ?opts: DuplexOptions -> Duplex

    type [<AllowNullLiteral>] TransformOptions =
        inherit DuplexOptions
        abstract transform: (U2<string, Buffer> -> string -> Function -> obj option) option with get, set
        abstract flush: (Function -> obj option) option with get, set

    type [<AllowNullLiteral>] Transform =
        inherit Duplex
        abstract _transform: chunk: obj option * encoding: string * callback: Function -> unit
        abstract destroy: ?error: Error -> unit

    type [<AllowNullLiteral>] TransformStatic =
        [<Emit "new $0($1...)">] abstract Create: ?opts: TransformOptions -> Transform

    type [<AllowNullLiteral>] PassThrough =
        inherit Transform

    type [<AllowNullLiteral>] PassThroughStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> PassThrough

module Util =
    let [<Import("promisify","util")>] promisify: Promisify.IExports = jsNative

    type [<AllowNullLiteral>] IExports =
        abstract format: format: obj option * [<ParamArray>] param: ResizeArray<obj option> -> string
        abstract debug: string: string -> unit
        abstract error: [<ParamArray>] param: ResizeArray<obj option> -> unit
        abstract puts: [<ParamArray>] param: ResizeArray<obj option> -> unit
        abstract print: [<ParamArray>] param: ResizeArray<obj option> -> unit
        abstract log: string: string -> unit
        abstract isArray: ``object``: obj option -> bool
        abstract isRegExp: ``object``: obj option -> bool
        abstract isDate: ``object``: obj option -> bool
        abstract isError: ``object``: obj option -> bool
        abstract inherits: ``constructor``: obj option * superConstructor: obj option -> unit
        abstract debuglog: key: string -> (string -> ResizeArray<obj option> -> unit)
        abstract isBoolean: ``object``: obj option -> bool
        abstract isBuffer: ``object``: obj option -> bool
        abstract isFunction: ``object``: obj option -> bool
        abstract isNull: ``object``: obj option -> bool
        abstract isNullOrUndefined: ``object``: obj option -> bool
        abstract isNumber: ``object``: obj option -> bool
        abstract isObject: ``object``: obj option -> bool
        abstract isPrimitive: ``object``: obj option -> bool
        abstract isString: ``object``: obj option -> bool
        abstract isSymbol: ``object``: obj option -> bool
        abstract isUndefined: ``object``: obj option -> bool
        abstract deprecate: fn: 'T * message: string -> 'T
        abstract callbackify: fn: (unit -> Promise<unit>) -> ((NodeJS.ErrnoException -> unit) -> unit)
        abstract callbackify: fn: (unit -> Promise<'TResult>) -> ((NodeJS.ErrnoException -> 'TResult -> unit) -> unit)
        abstract callbackify: fn: ('T1 -> Promise<unit>) -> ('T1 -> (NodeJS.ErrnoException -> unit) -> unit)
        abstract callbackify: fn: ('T1 -> Promise<'TResult>) -> ('T1 -> (NodeJS.ErrnoException -> 'TResult -> unit) -> unit)
        abstract callbackify: fn: ('T1 -> 'T2 -> Promise<unit>) -> ('T1 -> 'T2 -> (NodeJS.ErrnoException -> unit) -> unit)
        abstract callbackify: fn: ('T1 -> 'T2 -> Promise<'TResult>) -> ('T1 -> 'T2 -> (NodeJS.ErrnoException -> 'TResult -> unit) -> unit)
        abstract callbackify: fn: ('T1 -> 'T2 -> 'T3 -> Promise<unit>) -> ('T1 -> 'T2 -> 'T3 -> (NodeJS.ErrnoException -> unit) -> unit)
        abstract callbackify: fn: ('T1 -> 'T2 -> 'T3 -> Promise<'TResult>) -> ('T1 -> 'T2 -> 'T3 -> (NodeJS.ErrnoException -> 'TResult -> unit) -> unit)
        abstract callbackify: fn: ('T1 -> 'T2 -> 'T3 -> 'T4 -> Promise<unit>) -> ('T1 -> 'T2 -> 'T3 -> 'T4 -> (NodeJS.ErrnoException -> unit) -> unit)
        abstract callbackify: fn: ('T1 -> 'T2 -> 'T3 -> 'T4 -> Promise<'TResult>) -> ('T1 -> 'T2 -> 'T3 -> 'T4 -> (NodeJS.ErrnoException -> 'TResult -> unit) -> unit)
        abstract callbackify: fn: ('T1 -> 'T2 -> 'T3 -> 'T4 -> 'T5 -> Promise<unit>) -> ('T1 -> 'T2 -> 'T3 -> 'T4 -> 'T5 -> (NodeJS.ErrnoException -> unit) -> unit)
        abstract callbackify: fn: ('T1 -> 'T2 -> 'T3 -> 'T4 -> 'T5 -> Promise<'TResult>) -> ('T1 -> 'T2 -> 'T3 -> 'T4 -> 'T5 -> (NodeJS.ErrnoException -> 'TResult -> unit) -> unit)
        abstract callbackify: fn: ('T1 -> 'T2 -> 'T3 -> 'T4 -> 'T5 -> 'T6 -> Promise<unit>) -> ('T1 -> 'T2 -> 'T3 -> 'T4 -> 'T5 -> 'T6 -> (NodeJS.ErrnoException -> unit) -> unit)
        abstract callbackify: fn: ('T1 -> 'T2 -> 'T3 -> 'T4 -> 'T5 -> 'T6 -> Promise<'TResult>) -> ('T1 -> 'T2 -> 'T3 -> 'T4 -> 'T5 -> 'T6 -> (NodeJS.ErrnoException -> 'TResult -> unit) -> unit)
        abstract promisify: fn: CustomPromisify<'TCustom> -> 'TCustom
        abstract promisify: fn: ((Error option -> 'TResult -> unit) -> unit) -> (unit -> Promise<'TResult>)
        abstract promisify: fn: ((Error option -> unit) -> unit) -> (unit -> Promise<unit>)
        abstract promisify: fn: ('T1 -> (Error option -> 'TResult -> unit) -> unit) -> ('T1 -> Promise<'TResult>)
        abstract promisify: fn: ('T1 -> (Error option -> unit) -> unit) -> ('T1 -> Promise<unit>)
        abstract promisify: fn: ('T1 -> 'T2 -> (Error option -> 'TResult -> unit) -> unit) -> ('T1 -> 'T2 -> Promise<'TResult>)
        abstract promisify: fn: ('T1 -> 'T2 -> (Error option -> unit) -> unit) -> ('T1 -> 'T2 -> Promise<unit>)
        abstract promisify: fn: ('T1 -> 'T2 -> 'T3 -> (Error option -> 'TResult -> unit) -> unit) -> ('T1 -> 'T2 -> 'T3 -> Promise<'TResult>)
        abstract promisify: fn: ('T1 -> 'T2 -> 'T3 -> (Error option -> unit) -> unit) -> ('T1 -> 'T2 -> 'T3 -> Promise<unit>)
        abstract promisify: fn: ('T1 -> 'T2 -> 'T3 -> 'T4 -> (Error option -> 'TResult -> unit) -> unit) -> ('T1 -> 'T2 -> 'T3 -> 'T4 -> Promise<'TResult>)
        abstract promisify: fn: ('T1 -> 'T2 -> 'T3 -> 'T4 -> (Error option -> unit) -> unit) -> ('T1 -> 'T2 -> 'T3 -> 'T4 -> Promise<unit>)
        abstract promisify: fn: ('T1 -> 'T2 -> 'T3 -> 'T4 -> 'T5 -> (Error option -> 'TResult -> unit) -> unit) -> ('T1 -> 'T2 -> 'T3 -> 'T4 -> 'T5 -> Promise<'TResult>)
        abstract promisify: fn: ('T1 -> 'T2 -> 'T3 -> 'T4 -> 'T5 -> (Error option -> unit) -> unit) -> ('T1 -> 'T2 -> 'T3 -> 'T4 -> 'T5 -> Promise<unit>)
        abstract promisify: fn: Function -> Function
        abstract TextDecoder: TextDecoderStatic
        abstract TextEncoder: TextEncoderStatic

    type [<AllowNullLiteral>] InspectOptions =
        inherit NodeJS.InspectOptions
    let inspect: obj = jsNative

    type [<AllowNullLiteral>] CustomPromisify<'TCustom> =
        inherit Function
        abstract __promisify__: 'TCustom with get, set

    module Promisify =

        type [<AllowNullLiteral>] IExports =
            abstract custom: Symbol

    type [<AllowNullLiteral>] TextDecoder =
        abstract encoding: string
        abstract fatal: bool
        abstract ignoreBOM: bool
        abstract decode: ?input: obj * ?options: TextDecoderDecodeOptions -> string

    type [<AllowNullLiteral>] TextDecoderDecodeOptions =
        abstract stream: bool option with get, set

    type [<AllowNullLiteral>] TextDecoderStatic =
        [<Emit "new $0($1...)">] abstract Create: ?encoding: string * ?options: TextDecoderStaticOptions -> TextDecoder

    type [<AllowNullLiteral>] TextDecoderStaticOptions =
        abstract fatal: bool option with get, set
        abstract ignoreBOM: bool option with get, set

    type [<AllowNullLiteral>] TextEncoder =
        abstract encoding: string
        abstract encode: ?input: string -> Uint8Array

    type [<AllowNullLiteral>] TextEncoderStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> TextEncoder

module Assert =

    type [<AllowNullLiteral>] IExports =
        abstract ``internal``: value: obj option * ?message: string -> unit
        abstract AssertionError: AssertionErrorStatic
        abstract fail: message: string -> obj
        abstract fail: actual: obj option * expected: obj option * ?message: string * ?operator: string -> obj
        abstract ok: value: obj option * ?message: string -> unit
        abstract equal: actual: obj option * expected: obj option * ?message: string -> unit
        abstract notEqual: actual: obj option * expected: obj option * ?message: string -> unit
        abstract deepEqual: actual: obj option * expected: obj option * ?message: string -> unit
        abstract notDeepEqual: acutal: obj option * expected: obj option * ?message: string -> unit
        abstract strictEqual: actual: obj option * expected: obj option * ?message: string -> unit
        abstract notStrictEqual: actual: obj option * expected: obj option * ?message: string -> unit
        abstract deepStrictEqual: actual: obj option * expected: obj option * ?message: string -> unit
        abstract notDeepStrictEqual: actual: obj option * expected: obj option * ?message: string -> unit
        abstract throws: block: Function * ?message: string -> unit
        abstract throws: block: Function * error: Function * ?message: string -> unit
        abstract throws: block: Function * error: RegExp * ?message: string -> unit
        abstract throws: block: Function * error: (obj option -> bool) * ?message: string -> unit
        abstract doesNotThrow: block: Function * ?message: string -> unit
        abstract doesNotThrow: block: Function * error: Function * ?message: string -> unit
        abstract doesNotThrow: block: Function * error: RegExp * ?message: string -> unit
        abstract doesNotThrow: block: Function * error: (obj option -> bool) * ?message: string -> unit
        abstract ifError: value: obj option -> unit

    type [<AllowNullLiteral>] AssertionError =
        inherit Error
        abstract name: string with get, set
        abstract message: string with get, set
        abstract actual: obj option with get, set
        abstract expected: obj option with get, set
        abstract operator: string with get, set
        abstract generatedMessage: bool with get, set

    type [<AllowNullLiteral>] AssertionErrorStatic =
        [<Emit "new $0($1...)">] abstract Create: ?options: AssertionErrorStaticOptions -> AssertionError

    type [<AllowNullLiteral>] AssertionErrorStaticOptions =
        abstract message: string option with get, set
        abstract actual: obj option with get, set
        abstract expected: obj option with get, set
        abstract operator: string option with get, set
        abstract stackStartFunction: Function option with get, set

module Tty =

    type [<AllowNullLiteral>] IExports =
        abstract isatty: fd: float -> bool
        abstract ReadStream: ReadStreamStatic
        abstract WriteStream: WriteStreamStatic

    type [<AllowNullLiteral>] ReadStream =
        inherit Net.Socket
        abstract isRaw: bool with get, set
        abstract setRawMode: mode: bool -> unit
        abstract isTTY: bool with get, set

    type [<AllowNullLiteral>] ReadStreamStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> ReadStream

    type [<AllowNullLiteral>] WriteStream =
        inherit Net.Socket
        abstract columns: float with get, set
        abstract rows: float with get, set
        abstract isTTY: bool with get, set

    type [<AllowNullLiteral>] WriteStreamStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> WriteStream

module Domain =

    type [<AllowNullLiteral>] IExports =
        abstract Domain: DomainStatic
        abstract create: unit -> Domain

    type [<AllowNullLiteral>] Domain =
        inherit Events.EventEmitter
        inherit NodeJS.Domain
        abstract run: fn: Function -> unit
        abstract add: emitter: Events.EventEmitter -> unit
        abstract remove: emitter: Events.EventEmitter -> unit
        abstract bind: cb: (Error -> obj option -> obj option) -> obj option
        abstract intercept: cb: (obj option -> obj option) -> obj option
        abstract dispose: unit -> unit
        abstract members: ResizeArray<obj option> with get, set
        abstract enter: unit -> unit
        abstract exit: unit -> unit

    type [<AllowNullLiteral>] DomainStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> Domain

module Constants =
    let E2BIG: float = jsNative
    let EACCES: float = jsNative
    let EADDRINUSE: float = jsNative
    let EADDRNOTAVAIL: float = jsNative
    let EAFNOSUPPORT: float = jsNative
    let EAGAIN: float = jsNative
    let EALREADY: float = jsNative
    let EBADF: float = jsNative
    let EBADMSG: float = jsNative
    let EBUSY: float = jsNative
    let ECANCELED: float = jsNative
    let ECHILD: float = jsNative
    let ECONNABORTED: float = jsNative
    let ECONNREFUSED: float = jsNative
    let ECONNRESET: float = jsNative
    let EDEADLK: float = jsNative
    let EDESTADDRREQ: float = jsNative
    let EDOM: float = jsNative
    let EEXIST: float = jsNative
    let EFAULT: float = jsNative
    let EFBIG: float = jsNative
    let EHOSTUNREACH: float = jsNative
    let EIDRM: float = jsNative
    let EILSEQ: float = jsNative
    let EINPROGRESS: float = jsNative
    let EINTR: float = jsNative
    let EINVAL: float = jsNative
    let EIO: float = jsNative
    let EISCONN: float = jsNative
    let EISDIR: float = jsNative
    let ELOOP: float = jsNative
    let EMFILE: float = jsNative
    let EMLINK: float = jsNative
    let EMSGSIZE: float = jsNative
    let ENAMETOOLONG: float = jsNative
    let ENETDOWN: float = jsNative
    let ENETRESET: float = jsNative
    let ENETUNREACH: float = jsNative
    let ENFILE: float = jsNative
    let ENOBUFS: float = jsNative
    let ENODATA: float = jsNative
    let ENODEV: float = jsNative
    let ENOENT: float = jsNative
    let ENOEXEC: float = jsNative
    let ENOLCK: float = jsNative
    let ENOLINK: float = jsNative
    let ENOMEM: float = jsNative
    let ENOMSG: float = jsNative
    let ENOPROTOOPT: float = jsNative
    let ENOSPC: float = jsNative
    let ENOSR: float = jsNative
    let ENOSTR: float = jsNative
    let ENOSYS: float = jsNative
    let ENOTCONN: float = jsNative
    let ENOTDIR: float = jsNative
    let ENOTEMPTY: float = jsNative
    let ENOTSOCK: float = jsNative
    let ENOTSUP: float = jsNative
    let ENOTTY: float = jsNative
    let ENXIO: float = jsNative
    let EOPNOTSUPP: float = jsNative
    let EOVERFLOW: float = jsNative
    let EPERM: float = jsNative
    let EPIPE: float = jsNative
    let EPROTO: float = jsNative
    let EPROTONOSUPPORT: float = jsNative
    let EPROTOTYPE: float = jsNative
    let ERANGE: float = jsNative
    let EROFS: float = jsNative
    let ESPIPE: float = jsNative
    let ESRCH: float = jsNative
    let ETIME: float = jsNative
    let ETIMEDOUT: float = jsNative
    let ETXTBSY: float = jsNative
    let EWOULDBLOCK: float = jsNative
    let EXDEV: float = jsNative
    let WSAEINTR: float = jsNative
    let WSAEBADF: float = jsNative
    let WSAEACCES: float = jsNative
    let WSAEFAULT: float = jsNative
    let WSAEINVAL: float = jsNative
    let WSAEMFILE: float = jsNative
    let WSAEWOULDBLOCK: float = jsNative
    let WSAEINPROGRESS: float = jsNative
    let WSAEALREADY: float = jsNative
    let WSAENOTSOCK: float = jsNative
    let WSAEDESTADDRREQ: float = jsNative
    let WSAEMSGSIZE: float = jsNative
    let WSAEPROTOTYPE: float = jsNative
    let WSAENOPROTOOPT: float = jsNative
    let WSAEPROTONOSUPPORT: float = jsNative
    let WSAESOCKTNOSUPPORT: float = jsNative
    let WSAEOPNOTSUPP: float = jsNative
    let WSAEPFNOSUPPORT: float = jsNative
    let WSAEAFNOSUPPORT: float = jsNative
    let WSAEADDRINUSE: float = jsNative
    let WSAEADDRNOTAVAIL: float = jsNative
    let WSAENETDOWN: float = jsNative
    let WSAENETUNREACH: float = jsNative
    let WSAENETRESET: float = jsNative
    let WSAECONNABORTED: float = jsNative
    let WSAECONNRESET: float = jsNative
    let WSAENOBUFS: float = jsNative
    let WSAEISCONN: float = jsNative
    let WSAENOTCONN: float = jsNative
    let WSAESHUTDOWN: float = jsNative
    let WSAETOOMANYREFS: float = jsNative
    let WSAETIMEDOUT: float = jsNative
    let WSAECONNREFUSED: float = jsNative
    let WSAELOOP: float = jsNative
    let WSAENAMETOOLONG: float = jsNative
    let WSAEHOSTDOWN: float = jsNative
    let WSAEHOSTUNREACH: float = jsNative
    let WSAENOTEMPTY: float = jsNative
    let WSAEPROCLIM: float = jsNative
    let WSAEUSERS: float = jsNative
    let WSAEDQUOT: float = jsNative
    let WSAESTALE: float = jsNative
    let WSAEREMOTE: float = jsNative
    let WSASYSNOTREADY: float = jsNative
    let WSAVERNOTSUPPORTED: float = jsNative
    let WSANOTINITIALISED: float = jsNative
    let WSAEDISCON: float = jsNative
    let WSAENOMORE: float = jsNative
    let WSAECANCELLED: float = jsNative
    let WSAEINVALIDPROCTABLE: float = jsNative
    let WSAEINVALIDPROVIDER: float = jsNative
    let WSAEPROVIDERFAILEDINIT: float = jsNative
    let WSASYSCALLFAILURE: float = jsNative
    let WSASERVICE_NOT_FOUND: float = jsNative
    let WSATYPE_NOT_FOUND: float = jsNative
    let WSA_E_NO_MORE: float = jsNative
    let WSA_E_CANCELLED: float = jsNative
    let WSAEREFUSED: float = jsNative
    let SIGHUP: float = jsNative
    let SIGINT: float = jsNative
    let SIGILL: float = jsNative
    let SIGABRT: float = jsNative
    let SIGFPE: float = jsNative
    let SIGKILL: float = jsNative
    let SIGSEGV: float = jsNative
    let SIGTERM: float = jsNative
    let SIGBREAK: float = jsNative
    let SIGWINCH: float = jsNative
    let SSL_OP_ALL: float = jsNative
    let SSL_OP_ALLOW_UNSAFE_LEGACY_RENEGOTIATION: float = jsNative
    let SSL_OP_CIPHER_SERVER_PREFERENCE: float = jsNative
    let SSL_OP_CISCO_ANYCONNECT: float = jsNative
    let SSL_OP_COOKIE_EXCHANGE: float = jsNative
    let SSL_OP_CRYPTOPRO_TLSEXT_BUG: float = jsNative
    let SSL_OP_DONT_INSERT_EMPTY_FRAGMENTS: float = jsNative
    let SSL_OP_EPHEMERAL_RSA: float = jsNative
    let SSL_OP_LEGACY_SERVER_CONNECT: float = jsNative
    let SSL_OP_MICROSOFT_BIG_SSLV3_BUFFER: float = jsNative
    let SSL_OP_MICROSOFT_SESS_ID_BUG: float = jsNative
    let SSL_OP_MSIE_SSLV2_RSA_PADDING: float = jsNative
    let SSL_OP_NETSCAPE_CA_DN_BUG: float = jsNative
    let SSL_OP_NETSCAPE_CHALLENGE_BUG: float = jsNative
    let SSL_OP_NETSCAPE_DEMO_CIPHER_CHANGE_BUG: float = jsNative
    let SSL_OP_NETSCAPE_REUSE_CIPHER_CHANGE_BUG: float = jsNative
    let SSL_OP_NO_COMPRESSION: float = jsNative
    let SSL_OP_NO_QUERY_MTU: float = jsNative
    let SSL_OP_NO_SESSION_RESUMPTION_ON_RENEGOTIATION: float = jsNative
    let SSL_OP_NO_SSLv2: float = jsNative
    let SSL_OP_NO_SSLv3: float = jsNative
    let SSL_OP_NO_TICKET: float = jsNative
    let SSL_OP_NO_TLSv1: float = jsNative
    let SSL_OP_NO_TLSv1_1: float = jsNative
    let SSL_OP_NO_TLSv1_2: float = jsNative
    let SSL_OP_PKCS1_CHECK_1: float = jsNative
    let SSL_OP_PKCS1_CHECK_2: float = jsNative
    let SSL_OP_SINGLE_DH_USE: float = jsNative
    let SSL_OP_SINGLE_ECDH_USE: float = jsNative
    let SSL_OP_SSLEAY_080_CLIENT_DH_BUG: float = jsNative
    let SSL_OP_SSLREF2_REUSE_CERT_TYPE_BUG: float = jsNative
    let SSL_OP_TLS_BLOCK_PADDING_BUG: float = jsNative
    let SSL_OP_TLS_D5_BUG: float = jsNative
    let SSL_OP_TLS_ROLLBACK_BUG: float = jsNative
    let ENGINE_METHOD_DSA: float = jsNative
    let ENGINE_METHOD_DH: float = jsNative
    let ENGINE_METHOD_RAND: float = jsNative
    let ENGINE_METHOD_ECDH: float = jsNative
    let ENGINE_METHOD_ECDSA: float = jsNative
    let ENGINE_METHOD_CIPHERS: float = jsNative
    let ENGINE_METHOD_DIGESTS: float = jsNative
    let ENGINE_METHOD_STORE: float = jsNative
    let ENGINE_METHOD_PKEY_METHS: float = jsNative
    let ENGINE_METHOD_PKEY_ASN1_METHS: float = jsNative
    let ENGINE_METHOD_ALL: float = jsNative
    let ENGINE_METHOD_NONE: float = jsNative
    let DH_CHECK_P_NOT_SAFE_PRIME: float = jsNative
    let DH_CHECK_P_NOT_PRIME: float = jsNative
    let DH_UNABLE_TO_CHECK_GENERATOR: float = jsNative
    let DH_NOT_SUITABLE_GENERATOR: float = jsNative
    let NPN_ENABLED: float = jsNative
    let RSA_PKCS1_PADDING: float = jsNative
    let RSA_SSLV23_PADDING: float = jsNative
    let RSA_NO_PADDING: float = jsNative
    let RSA_PKCS1_OAEP_PADDING: float = jsNative
    let RSA_X931_PADDING: float = jsNative
    let RSA_PKCS1_PSS_PADDING: float = jsNative
    let POINT_CONVERSION_COMPRESSED: float = jsNative
    let POINT_CONVERSION_UNCOMPRESSED: float = jsNative
    let POINT_CONVERSION_HYBRID: float = jsNative
    let O_RDONLY: float = jsNative
    let O_WRONLY: float = jsNative
    let O_RDWR: float = jsNative
    let S_IFMT: float = jsNative
    let S_IFREG: float = jsNative
    let S_IFDIR: float = jsNative
    let S_IFCHR: float = jsNative
    let S_IFBLK: float = jsNative
    let S_IFIFO: float = jsNative
    let S_IFSOCK: float = jsNative
    let S_IRWXU: float = jsNative
    let S_IRUSR: float = jsNative
    let S_IWUSR: float = jsNative
    let S_IXUSR: float = jsNative
    let S_IRWXG: float = jsNative
    let S_IRGRP: float = jsNative
    let S_IWGRP: float = jsNative
    let S_IXGRP: float = jsNative
    let S_IRWXO: float = jsNative
    let S_IROTH: float = jsNative
    let S_IWOTH: float = jsNative
    let S_IXOTH: float = jsNative
    let S_IFLNK: float = jsNative
    let O_CREAT: float = jsNative
    let O_EXCL: float = jsNative
    let O_NOCTTY: float = jsNative
    let O_DIRECTORY: float = jsNative
    let O_NOATIME: float = jsNative
    let O_NOFOLLOW: float = jsNative
    let O_SYNC: float = jsNative
    let O_DSYNC: float = jsNative
    let O_SYMLINK: float = jsNative
    let O_DIRECT: float = jsNative
    let O_NONBLOCK: float = jsNative
    let O_TRUNC: float = jsNative
    let O_APPEND: float = jsNative
    let F_OK: float = jsNative
    let R_OK: float = jsNative
    let W_OK: float = jsNative
    let X_OK: float = jsNative
    let UV_UDP_REUSEADDR: float = jsNative
    let SIGQUIT: float = jsNative
    let SIGTRAP: float = jsNative
    let SIGIOT: float = jsNative
    let SIGBUS: float = jsNative
    let SIGUSR1: float = jsNative
    let SIGUSR2: float = jsNative
    let SIGPIPE: float = jsNative
    let SIGALRM: float = jsNative
    let SIGCHLD: float = jsNative
    let SIGSTKFLT: float = jsNative
    let SIGCONT: float = jsNative
    let SIGSTOP: float = jsNative
    let SIGTSTP: float = jsNative
    let SIGTTIN: float = jsNative
    let SIGTTOU: float = jsNative
    let SIGURG: float = jsNative
    let SIGXCPU: float = jsNative
    let SIGXFSZ: float = jsNative
    let SIGVTALRM: float = jsNative
    let SIGPROF: float = jsNative
    let SIGIO: float = jsNative
    let SIGPOLL: float = jsNative
    let SIGPWR: float = jsNative
    let SIGSYS: float = jsNative
    let SIGUNUSED: float = jsNative
    let defaultCoreCipherList: string = jsNative
    let defaultCipherList: string = jsNative
    let ENGINE_METHOD_RSA: float = jsNative
    let ALPN_ENABLED: float = jsNative

module V8 =

    type [<AllowNullLiteral>] IExports =
        abstract getHeapStatistics: unit -> HeapInfo
        abstract getHeapSpaceStatistics: unit -> ResizeArray<HeapSpaceInfo>
        abstract setFlagsFromString: flags: string -> unit

    type [<AllowNullLiteral>] HeapSpaceInfo =
        abstract space_name: string with get, set
        abstract space_size: float with get, set
        abstract space_used_size: float with get, set
        abstract space_available_size: float with get, set
        abstract physical_space_size: float with get, set

    type DoesZapCodeSpaceFlag =
        obj

    type [<AllowNullLiteral>] HeapInfo =
        abstract total_heap_size: float with get, set
        abstract total_heap_size_executable: float with get, set
        abstract total_physical_size: float with get, set
        abstract total_available_size: float with get, set
        abstract used_heap_size: float with get, set
        abstract heap_size_limit: float with get, set
        abstract malloced_memory: float with get, set
        abstract peak_malloced_memory: float with get, set
        abstract does_zap_garbage: DoesZapCodeSpaceFlag with get, set

module Timers =
    let [<Import("setImmediate","timers")>] setImmediate: SetImmediate.IExports = jsNative
    let [<Import("setTimeout","timers")>] setTimeout: SetTimeout.IExports = jsNative

    type [<AllowNullLiteral>] IExports =
        abstract setTimeout: callback: (ResizeArray<obj option> -> unit) * ms: float * [<ParamArray>] args: ResizeArray<obj option> -> NodeJS.Timer
        abstract clearTimeout: timeoutId: NodeJS.Timer -> unit
        abstract setInterval: callback: (ResizeArray<obj option> -> unit) * ms: float * [<ParamArray>] args: ResizeArray<obj option> -> NodeJS.Timer
        abstract clearInterval: intervalId: NodeJS.Timer -> unit
        abstract setImmediate: callback: (ResizeArray<obj option> -> unit) * [<ParamArray>] args: ResizeArray<obj option> -> obj option
        abstract clearImmediate: immediateId: obj option -> unit

    module SetTimeout =

        type [<AllowNullLiteral>] IExports =
            abstract __promisify__: ms: float -> Promise<unit>
            abstract __promisify__: ms: float * value: 'T -> Promise<'T>

    module SetImmediate =

        type [<AllowNullLiteral>] IExports =
            abstract __promisify__: unit -> Promise<unit>
            abstract __promisify__: value: 'T -> Promise<'T>

module Async_hooks =

    type [<AllowNullLiteral>] IExports =
        /// Returns the asyncId of the current execution context.
        abstract executionAsyncId: unit -> float
        abstract currentId: unit -> float
        /// Returns the ID of the resource responsible for calling the callback that is currently being executed.
        abstract triggerAsyncId: unit -> float
        abstract triggerId: unit -> float
        /// <summary>Registers functions to be called for different lifetime events of each async operation.</summary>
        /// <param name="options">the callbacks to register</param>
        abstract createHook: options: HookCallbacks -> AsyncHook
        abstract AsyncResource: AsyncResourceStatic

    type [<AllowNullLiteral>] HookCallbacks =
        /// <summary>Called when a class is constructed that has the possibility to emit an asynchronous event.</summary>
        /// <param name="asyncId">a unique ID for the async resource</param>
        /// <param name="type">the type of the async resource</param>
        /// <param name="triggerAsyncId">the unique ID of the async resource in whose execution context this async resource was created</param>
        /// <param name="resource">reference to the resource representing the async operation, needs to be released during destroy</param>
        abstract init: asyncId: float * ``type``: string * triggerAsyncId: float * resource: Object -> unit
        /// <summary>When an asynchronous operation is initiated or completes a callback is called to notify the user.
        /// The before callback is called just before said callback is executed.</summary>
        /// <param name="asyncId">the unique identifier assigned to the resource about to execute the callback.</param>
        abstract before: asyncId: float -> unit
        /// <summary>Called immediately after the callback specified in before is completed.</summary>
        /// <param name="asyncId">the unique identifier assigned to the resource which has executed the callback.</param>
        abstract after: asyncId: float -> unit
        /// <summary>Called when a promise has resolve() called. This may not be in the same execution id
        /// as the promise itself.</summary>
        /// <param name="asyncId">the unique id for the promise that was resolve()d.</param>
        abstract promiseResolve: asyncId: float -> unit
        /// <summary>Called after the resource corresponding to asyncId is destroyed</summary>
        /// <param name="asyncId">a unique ID for the async resource</param>
        abstract destroy: asyncId: float -> unit

    type [<AllowNullLiteral>] AsyncHook =
        /// Enable the callbacks for a given AsyncHook instance. If no callbacks are provided enabling is a noop.
        abstract enable: unit -> AsyncHook
        /// Disable the callbacks for a given AsyncHook instance from the global pool of AsyncHook callbacks to be executed. Once a hook has been disabled it will not be called again until enabled.
        abstract disable: unit -> AsyncHook

    type [<AllowNullLiteral>] AsyncResourceOptions =
        /// The ID of the execution context that created this async event.
        /// Default: `executionAsyncId()`
        abstract triggerAsyncId: float option with get, set
        /// Disables automatic `emitDestroy` when the object is garbage collected.
        /// This usually does not need to be set (even if `emitDestroy` is called
        /// manually), unless the resource's `asyncId` is retrieved and the
        /// sensitive API's `emitDestroy` is called with it.
        /// Default: `false`
        abstract requireManualDestroy: bool option with get, set

    /// The class AsyncResource was designed to be extended by the embedder's async resources.
    /// Using this users can easily trigger the lifetime events of their own resources.
    type [<AllowNullLiteral>] AsyncResource =
        /// Call AsyncHooks before callbacks.
        abstract emitBefore: unit -> unit
        /// Call AsyncHooks after callbacks
        abstract emitAfter: unit -> unit
        /// Call AsyncHooks destroy callbacks.
        abstract emitDestroy: unit -> unit
        abstract asyncId: unit -> float
        abstract triggerAsyncId: unit -> float

    /// The class AsyncResource was designed to be extended by the embedder's async resources.
    /// Using this users can easily trigger the lifetime events of their own resources.
    type [<AllowNullLiteral>] AsyncResourceStatic =
        /// <summary>AsyncResource() is meant to be extended. Instantiating a
        /// new AsyncResource() also triggers init. If triggerAsyncId is omitted then
        /// async_hook.executionAsyncId() is used.</summary>
        /// <param name="type">The type of async event.</param>
        /// <param name="triggerAsyncId">The ID of the execution context that created
        /// this async event (default: `executionAsyncId()`), or an
        /// AsyncResourceOptions object (since 8.10)</param>
        [<Emit "new $0($1...)">] abstract Create: ``type``: string * ?triggerAsyncId: U2<float, AsyncResourceOptions> -> AsyncResource

module Http2 =
    type IncomingHttpHeaders = Http.IncomingHttpHeaders
    type OutgoingHttpHeaders = Http.OutgoingHttpHeaders

    type [<AllowNullLiteral>] IExports =
        abstract getDefaultSettings: unit -> Settings
        abstract getPackedSettings: settings: Settings -> Settings
        abstract getUnpackedSettings: buf: U2<Buffer, Uint8Array> -> Settings
        abstract createServer: ?onRequestHandler: (Http2ServerRequest -> Http2ServerResponse -> unit) -> Http2Server
        abstract createServer: options: ServerOptions * ?onRequestHandler: (Http2ServerRequest -> Http2ServerResponse -> unit) -> Http2Server
        abstract createSecureServer: ?onRequestHandler: (Http2ServerRequest -> Http2ServerResponse -> unit) -> Http2SecureServer
        abstract createSecureServer: options: SecureServerOptions * ?onRequestHandler: (Http2ServerRequest -> Http2ServerResponse -> unit) -> Http2SecureServer
        abstract connect: authority: U2<string, Url.URL> * ?listener: (ClientHttp2Session -> U2<Net.Socket, Tls.TLSSocket> -> unit) -> ClientHttp2Session
        abstract connect: authority: U2<string, Url.URL> * ?options: U2<ClientSessionOptions, SecureClientSessionOptions> * ?listener: (ClientHttp2Session -> U2<Net.Socket, Tls.TLSSocket> -> unit) -> ClientHttp2Session

    type [<AllowNullLiteral>] StreamPriorityOptions =
        abstract exclusive: bool option with get, set
        abstract parent: float option with get, set
        abstract weight: float option with get, set
        abstract silent: bool option with get, set

    type [<AllowNullLiteral>] StreamState =
        abstract localWindowSize: float option with get, set
        abstract state: float option with get, set
        abstract streamLocalClose: float option with get, set
        abstract streamRemoteClose: float option with get, set
        abstract sumDependencyWeight: float option with get, set
        abstract weight: float option with get, set

    type [<AllowNullLiteral>] ServerStreamResponseOptions =
        abstract endStream: bool option with get, set
        abstract getTrailers: (OutgoingHttpHeaders -> unit) option with get, set

    type [<AllowNullLiteral>] StatOptions =
        abstract offset: float with get, set
        abstract length: float with get, set

    type [<AllowNullLiteral>] ServerStreamFileResponseOptions =
        abstract statCheck: (Fs.Stats -> OutgoingHttpHeaders -> StatOptions -> U2<unit, bool>) option with get, set
        abstract getTrailers: (OutgoingHttpHeaders -> unit) option with get, set
        abstract offset: float option with get, set
        abstract length: float option with get, set

    type [<AllowNullLiteral>] ServerStreamFileResponseOptionsWithError =
        inherit ServerStreamFileResponseOptions
        abstract onError: (NodeJS.ErrnoException -> unit) option with get, set

    type [<AllowNullLiteral>] Http2Stream =
        inherit Stream.Duplex
        abstract aborted: bool
        abstract destroyed: bool
        abstract priority: options: StreamPriorityOptions -> unit
        abstract rstCode: float
        abstract rstStream: code: float -> unit
        abstract rstWithNoError: unit -> unit
        abstract rstWithProtocolError: unit -> unit
        abstract rstWithCancel: unit -> unit
        abstract rstWithRefuse: unit -> unit
        abstract rstWithInternalError: unit -> unit
        abstract session: Http2Session
        abstract setTimeout: msecs: float * ?callback: (unit -> unit) -> unit
        abstract state: StreamState
        abstract addListener: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> Http2Stream
        [<Emit "$0.addListener('aborted',$1)">] abstract addListener_aborted: listener: (unit -> unit) -> Http2Stream
        [<Emit "$0.addListener('close',$1)">] abstract addListener_close: listener: (unit -> unit) -> Http2Stream
        [<Emit "$0.addListener('data',$1)">] abstract addListener_data: listener: (U2<Buffer, string> -> unit) -> Http2Stream
        [<Emit "$0.addListener('drain',$1)">] abstract addListener_drain: listener: (unit -> unit) -> Http2Stream
        [<Emit "$0.addListener('end',$1)">] abstract addListener_end: listener: (unit -> unit) -> Http2Stream
        [<Emit "$0.addListener('error',$1)">] abstract addListener_error: listener: (Error -> unit) -> Http2Stream
        [<Emit "$0.addListener('finish',$1)">] abstract addListener_finish: listener: (unit -> unit) -> Http2Stream
        [<Emit "$0.addListener('frameError',$1)">] abstract addListener_frameError: listener: (float -> float -> unit) -> Http2Stream
        [<Emit "$0.addListener('pipe',$1)">] abstract addListener_pipe: listener: (Stream.Readable -> unit) -> Http2Stream
        [<Emit "$0.addListener('unpipe',$1)">] abstract addListener_unpipe: listener: (Stream.Readable -> unit) -> Http2Stream
        [<Emit "$0.addListener('streamClosed',$1)">] abstract addListener_streamClosed: listener: (float -> unit) -> Http2Stream
        [<Emit "$0.addListener('timeout',$1)">] abstract addListener_timeout: listener: (unit -> unit) -> Http2Stream
        [<Emit "$0.addListener('trailers',$1)">] abstract addListener_trailers: listener: (IncomingHttpHeaders -> float -> unit) -> Http2Stream
        abstract emit: ``event``: U2<string, Symbol> * [<ParamArray>] args: ResizeArray<obj option> -> bool
        [<Emit "$0.emit('aborted')">] abstract emit_aborted: unit -> bool
        [<Emit "$0.emit('close')">] abstract emit_close: unit -> bool
        [<Emit "$0.emit('data',$1)">] abstract emit_data: chunk: U2<Buffer, string> -> bool
        [<Emit "$0.emit('drain')">] abstract emit_drain: unit -> bool
        [<Emit "$0.emit('end')">] abstract emit_end: unit -> bool
        [<Emit "$0.emit('error',$1)">] abstract emit_error: err: Error -> bool
        [<Emit "$0.emit('finish')">] abstract emit_finish: unit -> bool
        [<Emit "$0.emit('frameError',$1,$2)">] abstract emit_frameError: frameType: float * errorCode: float -> bool
        [<Emit "$0.emit('pipe',$1)">] abstract emit_pipe: src: Stream.Readable -> bool
        [<Emit "$0.emit('unpipe',$1)">] abstract emit_unpipe: src: Stream.Readable -> bool
        [<Emit "$0.emit('streamClosed',$1)">] abstract emit_streamClosed: code: float -> bool
        [<Emit "$0.emit('timeout')">] abstract emit_timeout: unit -> bool
        [<Emit "$0.emit('trailers',$1,$2)">] abstract emit_trailers: trailers: IncomingHttpHeaders * flags: float -> bool
        abstract on: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> Http2Stream
        [<Emit "$0.on('aborted',$1)">] abstract on_aborted: listener: (unit -> unit) -> Http2Stream
        [<Emit "$0.on('close',$1)">] abstract on_close: listener: (unit -> unit) -> Http2Stream
        [<Emit "$0.on('data',$1)">] abstract on_data: listener: (U2<Buffer, string> -> unit) -> Http2Stream
        [<Emit "$0.on('drain',$1)">] abstract on_drain: listener: (unit -> unit) -> Http2Stream
        [<Emit "$0.on('end',$1)">] abstract on_end: listener: (unit -> unit) -> Http2Stream
        [<Emit "$0.on('error',$1)">] abstract on_error: listener: (Error -> unit) -> Http2Stream
        [<Emit "$0.on('finish',$1)">] abstract on_finish: listener: (unit -> unit) -> Http2Stream
        [<Emit "$0.on('frameError',$1)">] abstract on_frameError: listener: (float -> float -> unit) -> Http2Stream
        [<Emit "$0.on('pipe',$1)">] abstract on_pipe: listener: (Stream.Readable -> unit) -> Http2Stream
        [<Emit "$0.on('unpipe',$1)">] abstract on_unpipe: listener: (Stream.Readable -> unit) -> Http2Stream
        [<Emit "$0.on('streamClosed',$1)">] abstract on_streamClosed: listener: (float -> unit) -> Http2Stream
        [<Emit "$0.on('timeout',$1)">] abstract on_timeout: listener: (unit -> unit) -> Http2Stream
        [<Emit "$0.on('trailers',$1)">] abstract on_trailers: listener: (IncomingHttpHeaders -> float -> unit) -> Http2Stream
        abstract once: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> Http2Stream
        [<Emit "$0.once('aborted',$1)">] abstract once_aborted: listener: (unit -> unit) -> Http2Stream
        [<Emit "$0.once('close',$1)">] abstract once_close: listener: (unit -> unit) -> Http2Stream
        [<Emit "$0.once('data',$1)">] abstract once_data: listener: (U2<Buffer, string> -> unit) -> Http2Stream
        [<Emit "$0.once('drain',$1)">] abstract once_drain: listener: (unit -> unit) -> Http2Stream
        [<Emit "$0.once('end',$1)">] abstract once_end: listener: (unit -> unit) -> Http2Stream
        [<Emit "$0.once('error',$1)">] abstract once_error: listener: (Error -> unit) -> Http2Stream
        [<Emit "$0.once('finish',$1)">] abstract once_finish: listener: (unit -> unit) -> Http2Stream
        [<Emit "$0.once('frameError',$1)">] abstract once_frameError: listener: (float -> float -> unit) -> Http2Stream
        [<Emit "$0.once('pipe',$1)">] abstract once_pipe: listener: (Stream.Readable -> unit) -> Http2Stream
        [<Emit "$0.once('unpipe',$1)">] abstract once_unpipe: listener: (Stream.Readable -> unit) -> Http2Stream
        [<Emit "$0.once('streamClosed',$1)">] abstract once_streamClosed: listener: (float -> unit) -> Http2Stream
        [<Emit "$0.once('timeout',$1)">] abstract once_timeout: listener: (unit -> unit) -> Http2Stream
        [<Emit "$0.once('trailers',$1)">] abstract once_trailers: listener: (IncomingHttpHeaders -> float -> unit) -> Http2Stream
        abstract prependListener: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> Http2Stream
        [<Emit "$0.prependListener('aborted',$1)">] abstract prependListener_aborted: listener: (unit -> unit) -> Http2Stream
        [<Emit "$0.prependListener('close',$1)">] abstract prependListener_close: listener: (unit -> unit) -> Http2Stream
        [<Emit "$0.prependListener('data',$1)">] abstract prependListener_data: listener: (U2<Buffer, string> -> unit) -> Http2Stream
        [<Emit "$0.prependListener('drain',$1)">] abstract prependListener_drain: listener: (unit -> unit) -> Http2Stream
        [<Emit "$0.prependListener('end',$1)">] abstract prependListener_end: listener: (unit -> unit) -> Http2Stream
        [<Emit "$0.prependListener('error',$1)">] abstract prependListener_error: listener: (Error -> unit) -> Http2Stream
        [<Emit "$0.prependListener('finish',$1)">] abstract prependListener_finish: listener: (unit -> unit) -> Http2Stream
        [<Emit "$0.prependListener('frameError',$1)">] abstract prependListener_frameError: listener: (float -> float -> unit) -> Http2Stream
        [<Emit "$0.prependListener('pipe',$1)">] abstract prependListener_pipe: listener: (Stream.Readable -> unit) -> Http2Stream
        [<Emit "$0.prependListener('unpipe',$1)">] abstract prependListener_unpipe: listener: (Stream.Readable -> unit) -> Http2Stream
        [<Emit "$0.prependListener('streamClosed',$1)">] abstract prependListener_streamClosed: listener: (float -> unit) -> Http2Stream
        [<Emit "$0.prependListener('timeout',$1)">] abstract prependListener_timeout: listener: (unit -> unit) -> Http2Stream
        [<Emit "$0.prependListener('trailers',$1)">] abstract prependListener_trailers: listener: (IncomingHttpHeaders -> float -> unit) -> Http2Stream
        abstract prependOnceListener: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> Http2Stream
        [<Emit "$0.prependOnceListener('aborted',$1)">] abstract prependOnceListener_aborted: listener: (unit -> unit) -> Http2Stream
        [<Emit "$0.prependOnceListener('close',$1)">] abstract prependOnceListener_close: listener: (unit -> unit) -> Http2Stream
        [<Emit "$0.prependOnceListener('data',$1)">] abstract prependOnceListener_data: listener: (U2<Buffer, string> -> unit) -> Http2Stream
        [<Emit "$0.prependOnceListener('drain',$1)">] abstract prependOnceListener_drain: listener: (unit -> unit) -> Http2Stream
        [<Emit "$0.prependOnceListener('end',$1)">] abstract prependOnceListener_end: listener: (unit -> unit) -> Http2Stream
        [<Emit "$0.prependOnceListener('error',$1)">] abstract prependOnceListener_error: listener: (Error -> unit) -> Http2Stream
        [<Emit "$0.prependOnceListener('finish',$1)">] abstract prependOnceListener_finish: listener: (unit -> unit) -> Http2Stream
        [<Emit "$0.prependOnceListener('frameError',$1)">] abstract prependOnceListener_frameError: listener: (float -> float -> unit) -> Http2Stream
        [<Emit "$0.prependOnceListener('pipe',$1)">] abstract prependOnceListener_pipe: listener: (Stream.Readable -> unit) -> Http2Stream
        [<Emit "$0.prependOnceListener('unpipe',$1)">] abstract prependOnceListener_unpipe: listener: (Stream.Readable -> unit) -> Http2Stream
        [<Emit "$0.prependOnceListener('streamClosed',$1)">] abstract prependOnceListener_streamClosed: listener: (float -> unit) -> Http2Stream
        [<Emit "$0.prependOnceListener('timeout',$1)">] abstract prependOnceListener_timeout: listener: (unit -> unit) -> Http2Stream
        [<Emit "$0.prependOnceListener('trailers',$1)">] abstract prependOnceListener_trailers: listener: (IncomingHttpHeaders -> float -> unit) -> Http2Stream

    type [<AllowNullLiteral>] ClientHttp2Stream =
        inherit Http2Stream
        abstract addListener: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> ClientHttp2Stream
        [<Emit "$0.addListener('headers',$1)">] abstract addListener_headers: listener: (IncomingHttpHeaders -> float -> unit) -> ClientHttp2Stream
        [<Emit "$0.addListener('push',$1)">] abstract addListener_push: listener: (IncomingHttpHeaders -> float -> unit) -> ClientHttp2Stream
        [<Emit "$0.addListener('response',$1)">] abstract addListener_response: listener: (IncomingHttpHeaders -> float -> unit) -> ClientHttp2Stream
        abstract emit: ``event``: U2<string, Symbol> * [<ParamArray>] args: ResizeArray<obj option> -> bool
        [<Emit "$0.emit('headers',$1,$2)">] abstract emit_headers: headers: IncomingHttpHeaders * flags: float -> bool
        [<Emit "$0.emit('push',$1,$2)">] abstract emit_push: headers: IncomingHttpHeaders * flags: float -> bool
        [<Emit "$0.emit('response',$1,$2)">] abstract emit_response: headers: IncomingHttpHeaders * flags: float -> bool
        abstract on: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> ClientHttp2Stream
        [<Emit "$0.on('headers',$1)">] abstract on_headers: listener: (IncomingHttpHeaders -> float -> unit) -> ClientHttp2Stream
        [<Emit "$0.on('push',$1)">] abstract on_push: listener: (IncomingHttpHeaders -> float -> unit) -> ClientHttp2Stream
        [<Emit "$0.on('response',$1)">] abstract on_response: listener: (IncomingHttpHeaders -> float -> unit) -> ClientHttp2Stream
        abstract once: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> ClientHttp2Stream
        [<Emit "$0.once('headers',$1)">] abstract once_headers: listener: (IncomingHttpHeaders -> float -> unit) -> ClientHttp2Stream
        [<Emit "$0.once('push',$1)">] abstract once_push: listener: (IncomingHttpHeaders -> float -> unit) -> ClientHttp2Stream
        [<Emit "$0.once('response',$1)">] abstract once_response: listener: (IncomingHttpHeaders -> float -> unit) -> ClientHttp2Stream
        abstract prependListener: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> ClientHttp2Stream
        [<Emit "$0.prependListener('headers',$1)">] abstract prependListener_headers: listener: (IncomingHttpHeaders -> float -> unit) -> ClientHttp2Stream
        [<Emit "$0.prependListener('push',$1)">] abstract prependListener_push: listener: (IncomingHttpHeaders -> float -> unit) -> ClientHttp2Stream
        [<Emit "$0.prependListener('response',$1)">] abstract prependListener_response: listener: (IncomingHttpHeaders -> float -> unit) -> ClientHttp2Stream
        abstract prependOnceListener: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> ClientHttp2Stream
        [<Emit "$0.prependOnceListener('headers',$1)">] abstract prependOnceListener_headers: listener: (IncomingHttpHeaders -> float -> unit) -> ClientHttp2Stream
        [<Emit "$0.prependOnceListener('push',$1)">] abstract prependOnceListener_push: listener: (IncomingHttpHeaders -> float -> unit) -> ClientHttp2Stream
        [<Emit "$0.prependOnceListener('response',$1)">] abstract prependOnceListener_response: listener: (IncomingHttpHeaders -> float -> unit) -> ClientHttp2Stream

    type [<AllowNullLiteral>] ServerHttp2Stream =
        inherit Http2Stream
        abstract additionalHeaders: headers: OutgoingHttpHeaders -> unit
        abstract headersSent: bool
        abstract pushAllowed: bool
        abstract pushStream: headers: OutgoingHttpHeaders * ?callback: (ServerHttp2Stream -> unit) -> unit
        abstract pushStream: headers: OutgoingHttpHeaders * ?options: StreamPriorityOptions * ?callback: (ServerHttp2Stream -> unit) -> unit
        abstract respond: ?headers: OutgoingHttpHeaders * ?options: ServerStreamResponseOptions -> unit
        abstract respondWithFD: fd: float * ?headers: OutgoingHttpHeaders * ?options: ServerStreamFileResponseOptions -> unit
        abstract respondWithFile: path: string * ?headers: OutgoingHttpHeaders * ?options: ServerStreamFileResponseOptionsWithError -> unit

    type [<AllowNullLiteral>] Settings =
        abstract headerTableSize: float option with get, set
        abstract enablePush: bool option with get, set
        abstract initialWindowSize: float option with get, set
        abstract maxFrameSize: float option with get, set
        abstract maxConcurrentStreams: float option with get, set
        abstract maxHeaderListSize: float option with get, set

    type [<AllowNullLiteral>] ClientSessionRequestOptions =
        abstract endStream: bool option with get, set
        abstract exclusive: bool option with get, set
        abstract parent: float option with get, set
        abstract weight: float option with get, set
        abstract getTrailers: (OutgoingHttpHeaders -> float -> unit) option with get, set

    type [<AllowNullLiteral>] SessionShutdownOptions =
        abstract graceful: bool option with get, set
        abstract errorCode: float option with get, set
        abstract lastStreamID: float option with get, set
        abstract opaqueData: U2<Buffer, Uint8Array> option with get, set

    type [<AllowNullLiteral>] SessionState =
        abstract effectiveLocalWindowSize: float option with get, set
        abstract effectiveRecvDataLength: float option with get, set
        abstract nextStreamID: float option with get, set
        abstract localWindowSize: float option with get, set
        abstract lastProcStreamID: float option with get, set
        abstract remoteWindowSize: float option with get, set
        abstract outboundQueueSize: float option with get, set
        abstract deflateDynamicTableSize: float option with get, set
        abstract inflateDynamicTableSize: float option with get, set

    type [<AllowNullLiteral>] Http2Session =
        inherit Events.EventEmitter
        abstract destroy: unit -> unit
        abstract destroyed: bool
        abstract localSettings: Settings
        abstract pendingSettingsAck: bool
        abstract remoteSettings: Settings
        abstract rstStream: stream: Http2Stream * ?code: float -> unit
        abstract setTimeout: msecs: float * ?callback: (unit -> unit) -> unit
        abstract shutdown: ?callback: (unit -> unit) -> unit
        abstract shutdown: options: SessionShutdownOptions * ?callback: (unit -> unit) -> unit
        abstract socket: U2<Net.Socket, Tls.TLSSocket>
        abstract state: SessionState
        abstract priority: stream: Http2Stream * options: StreamPriorityOptions -> unit
        abstract settings: settings: Settings -> unit
        abstract ``type``: float
        abstract addListener: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> Http2Session
        [<Emit "$0.addListener('close',$1)">] abstract addListener_close: listener: (unit -> unit) -> Http2Session
        [<Emit "$0.addListener('error',$1)">] abstract addListener_error: listener: (Error -> unit) -> Http2Session
        [<Emit "$0.addListener('frameError',$1)">] abstract addListener_frameError: listener: (float -> float -> float -> unit) -> Http2Session
        [<Emit "$0.addListener('goaway',$1)">] abstract addListener_goaway: listener: (float -> float -> Buffer -> unit) -> Http2Session
        [<Emit "$0.addListener('localSettings',$1)">] abstract addListener_localSettings: listener: (Settings -> unit) -> Http2Session
        [<Emit "$0.addListener('remoteSettings',$1)">] abstract addListener_remoteSettings: listener: (Settings -> unit) -> Http2Session
        [<Emit "$0.addListener('socketError',$1)">] abstract addListener_socketError: listener: (Error -> unit) -> Http2Session
        [<Emit "$0.addListener('timeout',$1)">] abstract addListener_timeout: listener: (unit -> unit) -> Http2Session
        abstract emit: ``event``: U2<string, Symbol> * [<ParamArray>] args: ResizeArray<obj option> -> bool
        [<Emit "$0.emit('close')">] abstract emit_close: unit -> bool
        [<Emit "$0.emit('error',$1)">] abstract emit_error: err: Error -> bool
        [<Emit "$0.emit('frameError',$1,$2,$3)">] abstract emit_frameError: frameType: float * errorCode: float * streamID: float -> bool
        [<Emit "$0.emit('goaway',$1,$2,$3)">] abstract emit_goaway: errorCode: float * lastStreamID: float * opaqueData: Buffer -> bool
        [<Emit "$0.emit('localSettings',$1)">] abstract emit_localSettings: settings: Settings -> bool
        [<Emit "$0.emit('remoteSettings',$1)">] abstract emit_remoteSettings: settings: Settings -> bool
        [<Emit "$0.emit('socketError',$1)">] abstract emit_socketError: err: Error -> bool
        [<Emit "$0.emit('timeout')">] abstract emit_timeout: unit -> bool
        abstract on: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> Http2Session
        [<Emit "$0.on('close',$1)">] abstract on_close: listener: (unit -> unit) -> Http2Session
        [<Emit "$0.on('error',$1)">] abstract on_error: listener: (Error -> unit) -> Http2Session
        [<Emit "$0.on('frameError',$1)">] abstract on_frameError: listener: (float -> float -> float -> unit) -> Http2Session
        [<Emit "$0.on('goaway',$1)">] abstract on_goaway: listener: (float -> float -> Buffer -> unit) -> Http2Session
        [<Emit "$0.on('localSettings',$1)">] abstract on_localSettings: listener: (Settings -> unit) -> Http2Session
        [<Emit "$0.on('remoteSettings',$1)">] abstract on_remoteSettings: listener: (Settings -> unit) -> Http2Session
        [<Emit "$0.on('socketError',$1)">] abstract on_socketError: listener: (Error -> unit) -> Http2Session
        [<Emit "$0.on('timeout',$1)">] abstract on_timeout: listener: (unit -> unit) -> Http2Session
        abstract once: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> Http2Session
        [<Emit "$0.once('close',$1)">] abstract once_close: listener: (unit -> unit) -> Http2Session
        [<Emit "$0.once('error',$1)">] abstract once_error: listener: (Error -> unit) -> Http2Session
        [<Emit "$0.once('frameError',$1)">] abstract once_frameError: listener: (float -> float -> float -> unit) -> Http2Session
        [<Emit "$0.once('goaway',$1)">] abstract once_goaway: listener: (float -> float -> Buffer -> unit) -> Http2Session
        [<Emit "$0.once('localSettings',$1)">] abstract once_localSettings: listener: (Settings -> unit) -> Http2Session
        [<Emit "$0.once('remoteSettings',$1)">] abstract once_remoteSettings: listener: (Settings -> unit) -> Http2Session
        [<Emit "$0.once('socketError',$1)">] abstract once_socketError: listener: (Error -> unit) -> Http2Session
        [<Emit "$0.once('timeout',$1)">] abstract once_timeout: listener: (unit -> unit) -> Http2Session
        abstract prependListener: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> Http2Session
        [<Emit "$0.prependListener('close',$1)">] abstract prependListener_close: listener: (unit -> unit) -> Http2Session
        [<Emit "$0.prependListener('error',$1)">] abstract prependListener_error: listener: (Error -> unit) -> Http2Session
        [<Emit "$0.prependListener('frameError',$1)">] abstract prependListener_frameError: listener: (float -> float -> float -> unit) -> Http2Session
        [<Emit "$0.prependListener('goaway',$1)">] abstract prependListener_goaway: listener: (float -> float -> Buffer -> unit) -> Http2Session
        [<Emit "$0.prependListener('localSettings',$1)">] abstract prependListener_localSettings: listener: (Settings -> unit) -> Http2Session
        [<Emit "$0.prependListener('remoteSettings',$1)">] abstract prependListener_remoteSettings: listener: (Settings -> unit) -> Http2Session
        [<Emit "$0.prependListener('socketError',$1)">] abstract prependListener_socketError: listener: (Error -> unit) -> Http2Session
        [<Emit "$0.prependListener('timeout',$1)">] abstract prependListener_timeout: listener: (unit -> unit) -> Http2Session
        abstract prependOnceListener: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> Http2Session
        [<Emit "$0.prependOnceListener('close',$1)">] abstract prependOnceListener_close: listener: (unit -> unit) -> Http2Session
        [<Emit "$0.prependOnceListener('error',$1)">] abstract prependOnceListener_error: listener: (Error -> unit) -> Http2Session
        [<Emit "$0.prependOnceListener('frameError',$1)">] abstract prependOnceListener_frameError: listener: (float -> float -> float -> unit) -> Http2Session
        [<Emit "$0.prependOnceListener('goaway',$1)">] abstract prependOnceListener_goaway: listener: (float -> float -> Buffer -> unit) -> Http2Session
        [<Emit "$0.prependOnceListener('localSettings',$1)">] abstract prependOnceListener_localSettings: listener: (Settings -> unit) -> Http2Session
        [<Emit "$0.prependOnceListener('remoteSettings',$1)">] abstract prependOnceListener_remoteSettings: listener: (Settings -> unit) -> Http2Session
        [<Emit "$0.prependOnceListener('socketError',$1)">] abstract prependOnceListener_socketError: listener: (Error -> unit) -> Http2Session
        [<Emit "$0.prependOnceListener('timeout',$1)">] abstract prependOnceListener_timeout: listener: (unit -> unit) -> Http2Session

    type [<AllowNullLiteral>] ClientHttp2Session =
        inherit Http2Session
        abstract request: ?headers: OutgoingHttpHeaders * ?options: ClientSessionRequestOptions -> ClientHttp2Stream
        abstract addListener: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> ClientHttp2Session
        [<Emit "$0.addListener('connect',$1)">] abstract addListener_connect: listener: (ClientHttp2Session -> U2<Net.Socket, Tls.TLSSocket> -> unit) -> ClientHttp2Session
        [<Emit "$0.addListener('stream',$1)">] abstract addListener_stream: listener: (ClientHttp2Stream -> IncomingHttpHeaders -> float -> unit) -> ClientHttp2Session
        abstract emit: ``event``: U2<string, Symbol> * [<ParamArray>] args: ResizeArray<obj option> -> bool
        [<Emit "$0.emit('connect',$1,$2)">] abstract emit_connect: session: ClientHttp2Session * socket: U2<Net.Socket, Tls.TLSSocket> -> bool
        [<Emit "$0.emit('stream',$1,$2,$3)">] abstract emit_stream: stream: ClientHttp2Stream * headers: IncomingHttpHeaders * flags: float -> bool
        abstract on: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> ClientHttp2Session
        [<Emit "$0.on('connect',$1)">] abstract on_connect: listener: (ClientHttp2Session -> U2<Net.Socket, Tls.TLSSocket> -> unit) -> ClientHttp2Session
        [<Emit "$0.on('stream',$1)">] abstract on_stream: listener: (ClientHttp2Stream -> IncomingHttpHeaders -> float -> unit) -> ClientHttp2Session
        abstract once: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> ClientHttp2Session
        [<Emit "$0.once('connect',$1)">] abstract once_connect: listener: (ClientHttp2Session -> U2<Net.Socket, Tls.TLSSocket> -> unit) -> ClientHttp2Session
        [<Emit "$0.once('stream',$1)">] abstract once_stream: listener: (ClientHttp2Stream -> IncomingHttpHeaders -> float -> unit) -> ClientHttp2Session
        abstract prependListener: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> ClientHttp2Session
        [<Emit "$0.prependListener('connect',$1)">] abstract prependListener_connect: listener: (ClientHttp2Session -> U2<Net.Socket, Tls.TLSSocket> -> unit) -> ClientHttp2Session
        [<Emit "$0.prependListener('stream',$1)">] abstract prependListener_stream: listener: (ClientHttp2Stream -> IncomingHttpHeaders -> float -> unit) -> ClientHttp2Session
        abstract prependOnceListener: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> ClientHttp2Session
        [<Emit "$0.prependOnceListener('connect',$1)">] abstract prependOnceListener_connect: listener: (ClientHttp2Session -> U2<Net.Socket, Tls.TLSSocket> -> unit) -> ClientHttp2Session
        [<Emit "$0.prependOnceListener('stream',$1)">] abstract prependOnceListener_stream: listener: (ClientHttp2Stream -> IncomingHttpHeaders -> float -> unit) -> ClientHttp2Session

    type [<AllowNullLiteral>] ServerHttp2Session =
        inherit Http2Session
        abstract server: U2<Http2Server, Http2SecureServer>
        abstract addListener: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> ServerHttp2Session
        [<Emit "$0.addListener('connect',$1)">] abstract addListener_connect: listener: (ServerHttp2Session -> U2<Net.Socket, Tls.TLSSocket> -> unit) -> ServerHttp2Session
        [<Emit "$0.addListener('stream',$1)">] abstract addListener_stream: listener: (ServerHttp2Stream -> IncomingHttpHeaders -> float -> unit) -> ServerHttp2Session
        abstract emit: ``event``: U2<string, Symbol> * [<ParamArray>] args: ResizeArray<obj option> -> bool
        [<Emit "$0.emit('connect',$1,$2)">] abstract emit_connect: session: ServerHttp2Session * socket: U2<Net.Socket, Tls.TLSSocket> -> bool
        [<Emit "$0.emit('stream',$1,$2,$3)">] abstract emit_stream: stream: ServerHttp2Stream * headers: IncomingHttpHeaders * flags: float -> bool
        abstract on: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> ServerHttp2Session
        [<Emit "$0.on('connect',$1)">] abstract on_connect: listener: (ServerHttp2Session -> U2<Net.Socket, Tls.TLSSocket> -> unit) -> ServerHttp2Session
        [<Emit "$0.on('stream',$1)">] abstract on_stream: listener: (ServerHttp2Stream -> IncomingHttpHeaders -> float -> unit) -> ServerHttp2Session
        abstract once: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> ServerHttp2Session
        [<Emit "$0.once('connect',$1)">] abstract once_connect: listener: (ServerHttp2Session -> U2<Net.Socket, Tls.TLSSocket> -> unit) -> ServerHttp2Session
        [<Emit "$0.once('stream',$1)">] abstract once_stream: listener: (ServerHttp2Stream -> IncomingHttpHeaders -> float -> unit) -> ServerHttp2Session
        abstract prependListener: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> ServerHttp2Session
        [<Emit "$0.prependListener('connect',$1)">] abstract prependListener_connect: listener: (ServerHttp2Session -> U2<Net.Socket, Tls.TLSSocket> -> unit) -> ServerHttp2Session
        [<Emit "$0.prependListener('stream',$1)">] abstract prependListener_stream: listener: (ServerHttp2Stream -> IncomingHttpHeaders -> float -> unit) -> ServerHttp2Session
        abstract prependOnceListener: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> ServerHttp2Session
        [<Emit "$0.prependOnceListener('connect',$1)">] abstract prependOnceListener_connect: listener: (ServerHttp2Session -> U2<Net.Socket, Tls.TLSSocket> -> unit) -> ServerHttp2Session
        [<Emit "$0.prependOnceListener('stream',$1)">] abstract prependOnceListener_stream: listener: (ServerHttp2Stream -> IncomingHttpHeaders -> float -> unit) -> ServerHttp2Session

    type [<AllowNullLiteral>] SessionOptions =
        abstract maxDeflateDynamicTableSize: float option with get, set
        abstract maxReservedRemoteStreams: float option with get, set
        abstract maxSendHeaderBlockLength: float option with get, set
        abstract paddingStrategy: float option with get, set
        abstract peerMaxConcurrentStreams: float option with get, set
        abstract selectPadding: (float -> float -> float) option with get, set
        abstract settings: Settings option with get, set

    type ClientSessionOptions =
        SessionOptions

    type ServerSessionOptions =
        SessionOptions

    type [<AllowNullLiteral>] SecureClientSessionOptions =
        inherit ClientSessionOptions
        inherit Tls.ConnectionOptions

    type [<AllowNullLiteral>] SecureServerSessionOptions =
        inherit ServerSessionOptions
        inherit Tls.TlsOptions

    type [<AllowNullLiteral>] ServerOptions =
        inherit ServerSessionOptions
        abstract allowHTTP1: bool option with get, set

    type [<AllowNullLiteral>] SecureServerOptions =
        inherit SecureServerSessionOptions
        abstract allowHTTP1: bool option with get, set

    type [<AllowNullLiteral>] Http2Server =
        inherit Net.Server
        abstract addListener: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> Http2Server
        [<Emit "$0.addListener('request',$1)">] abstract addListener_request: listener: (Http2ServerRequest -> Http2ServerResponse -> unit) -> Http2Server
        [<Emit "$0.addListener('sessionError',$1)">] abstract addListener_sessionError: listener: (Error -> unit) -> Http2Server
        [<Emit "$0.addListener('socketError',$1)">] abstract addListener_socketError: listener: (Error -> unit) -> Http2Server
        [<Emit "$0.addListener('stream',$1)">] abstract addListener_stream: listener: (ServerHttp2Stream -> IncomingHttpHeaders -> float -> unit) -> Http2Server
        [<Emit "$0.addListener('timeout',$1)">] abstract addListener_timeout: listener: (unit -> unit) -> Http2Server
        abstract emit: ``event``: U2<string, Symbol> * [<ParamArray>] args: ResizeArray<obj option> -> bool
        [<Emit "$0.emit('request',$1,$2)">] abstract emit_request: request: Http2ServerRequest * response: Http2ServerResponse -> bool
        [<Emit "$0.emit('sessionError',$1)">] abstract emit_sessionError: err: Error -> bool
        [<Emit "$0.emit('socketError',$1)">] abstract emit_socketError: err: Error -> bool
        [<Emit "$0.emit('stream',$1,$2,$3)">] abstract emit_stream: stream: ServerHttp2Stream * headers: IncomingHttpHeaders * flags: float -> bool
        [<Emit "$0.emit('timeout')">] abstract emit_timeout: unit -> bool
        abstract on: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> Http2Server
        [<Emit "$0.on('request',$1)">] abstract on_request: listener: (Http2ServerRequest -> Http2ServerResponse -> unit) -> Http2Server
        [<Emit "$0.on('sessionError',$1)">] abstract on_sessionError: listener: (Error -> unit) -> Http2Server
        [<Emit "$0.on('socketError',$1)">] abstract on_socketError: listener: (Error -> unit) -> Http2Server
        [<Emit "$0.on('stream',$1)">] abstract on_stream: listener: (ServerHttp2Stream -> IncomingHttpHeaders -> float -> unit) -> Http2Server
        [<Emit "$0.on('timeout',$1)">] abstract on_timeout: listener: (unit -> unit) -> Http2Server
        abstract once: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> Http2Server
        [<Emit "$0.once('request',$1)">] abstract once_request: listener: (Http2ServerRequest -> Http2ServerResponse -> unit) -> Http2Server
        [<Emit "$0.once('sessionError',$1)">] abstract once_sessionError: listener: (Error -> unit) -> Http2Server
        [<Emit "$0.once('socketError',$1)">] abstract once_socketError: listener: (Error -> unit) -> Http2Server
        [<Emit "$0.once('stream',$1)">] abstract once_stream: listener: (ServerHttp2Stream -> IncomingHttpHeaders -> float -> unit) -> Http2Server
        [<Emit "$0.once('timeout',$1)">] abstract once_timeout: listener: (unit -> unit) -> Http2Server
        abstract prependListener: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> Http2Server
        [<Emit "$0.prependListener('request',$1)">] abstract prependListener_request: listener: (Http2ServerRequest -> Http2ServerResponse -> unit) -> Http2Server
        [<Emit "$0.prependListener('sessionError',$1)">] abstract prependListener_sessionError: listener: (Error -> unit) -> Http2Server
        [<Emit "$0.prependListener('socketError',$1)">] abstract prependListener_socketError: listener: (Error -> unit) -> Http2Server
        [<Emit "$0.prependListener('stream',$1)">] abstract prependListener_stream: listener: (ServerHttp2Stream -> IncomingHttpHeaders -> float -> unit) -> Http2Server
        [<Emit "$0.prependListener('timeout',$1)">] abstract prependListener_timeout: listener: (unit -> unit) -> Http2Server
        abstract prependOnceListener: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> Http2Server
        [<Emit "$0.prependOnceListener('request',$1)">] abstract prependOnceListener_request: listener: (Http2ServerRequest -> Http2ServerResponse -> unit) -> Http2Server
        [<Emit "$0.prependOnceListener('sessionError',$1)">] abstract prependOnceListener_sessionError: listener: (Error -> unit) -> Http2Server
        [<Emit "$0.prependOnceListener('socketError',$1)">] abstract prependOnceListener_socketError: listener: (Error -> unit) -> Http2Server
        [<Emit "$0.prependOnceListener('stream',$1)">] abstract prependOnceListener_stream: listener: (ServerHttp2Stream -> IncomingHttpHeaders -> float -> unit) -> Http2Server
        [<Emit "$0.prependOnceListener('timeout',$1)">] abstract prependOnceListener_timeout: listener: (unit -> unit) -> Http2Server

    type [<AllowNullLiteral>] Http2SecureServer =
        inherit Tls.Server
        abstract addListener: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> Http2SecureServer
        [<Emit "$0.addListener('request',$1)">] abstract addListener_request: listener: (Http2ServerRequest -> Http2ServerResponse -> unit) -> Http2SecureServer
        [<Emit "$0.addListener('sessionError',$1)">] abstract addListener_sessionError: listener: (Error -> unit) -> Http2SecureServer
        [<Emit "$0.addListener('socketError',$1)">] abstract addListener_socketError: listener: (Error -> unit) -> Http2SecureServer
        [<Emit "$0.addListener('stream',$1)">] abstract addListener_stream: listener: (ServerHttp2Stream -> IncomingHttpHeaders -> float -> unit) -> Http2SecureServer
        [<Emit "$0.addListener('timeout',$1)">] abstract addListener_timeout: listener: (unit -> unit) -> Http2SecureServer
        [<Emit "$0.addListener('unknownProtocol',$1)">] abstract addListener_unknownProtocol: listener: (Tls.TLSSocket -> unit) -> Http2SecureServer
        abstract emit: ``event``: U2<string, Symbol> * [<ParamArray>] args: ResizeArray<obj option> -> bool
        [<Emit "$0.emit('request',$1,$2)">] abstract emit_request: request: Http2ServerRequest * response: Http2ServerResponse -> bool
        [<Emit "$0.emit('sessionError',$1)">] abstract emit_sessionError: err: Error -> bool
        [<Emit "$0.emit('socketError',$1)">] abstract emit_socketError: err: Error -> bool
        [<Emit "$0.emit('stream',$1,$2,$3)">] abstract emit_stream: stream: ServerHttp2Stream * headers: IncomingHttpHeaders * flags: float -> bool
        [<Emit "$0.emit('timeout')">] abstract emit_timeout: unit -> bool
        [<Emit "$0.emit('unknownProtocol',$1)">] abstract emit_unknownProtocol: socket: Tls.TLSSocket -> bool
        abstract on: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> Http2SecureServer
        [<Emit "$0.on('request',$1)">] abstract on_request: listener: (Http2ServerRequest -> Http2ServerResponse -> unit) -> Http2SecureServer
        [<Emit "$0.on('sessionError',$1)">] abstract on_sessionError: listener: (Error -> unit) -> Http2SecureServer
        [<Emit "$0.on('socketError',$1)">] abstract on_socketError: listener: (Error -> unit) -> Http2SecureServer
        [<Emit "$0.on('stream',$1)">] abstract on_stream: listener: (ServerHttp2Stream -> IncomingHttpHeaders -> float -> unit) -> Http2SecureServer
        [<Emit "$0.on('timeout',$1)">] abstract on_timeout: listener: (unit -> unit) -> Http2SecureServer
        [<Emit "$0.on('unknownProtocol',$1)">] abstract on_unknownProtocol: listener: (Tls.TLSSocket -> unit) -> Http2SecureServer
        abstract once: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> Http2SecureServer
        [<Emit "$0.once('request',$1)">] abstract once_request: listener: (Http2ServerRequest -> Http2ServerResponse -> unit) -> Http2SecureServer
        [<Emit "$0.once('sessionError',$1)">] abstract once_sessionError: listener: (Error -> unit) -> Http2SecureServer
        [<Emit "$0.once('socketError',$1)">] abstract once_socketError: listener: (Error -> unit) -> Http2SecureServer
        [<Emit "$0.once('stream',$1)">] abstract once_stream: listener: (ServerHttp2Stream -> IncomingHttpHeaders -> float -> unit) -> Http2SecureServer
        [<Emit "$0.once('timeout',$1)">] abstract once_timeout: listener: (unit -> unit) -> Http2SecureServer
        [<Emit "$0.once('unknownProtocol',$1)">] abstract once_unknownProtocol: listener: (Tls.TLSSocket -> unit) -> Http2SecureServer
        abstract prependListener: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> Http2SecureServer
        [<Emit "$0.prependListener('request',$1)">] abstract prependListener_request: listener: (Http2ServerRequest -> Http2ServerResponse -> unit) -> Http2SecureServer
        [<Emit "$0.prependListener('sessionError',$1)">] abstract prependListener_sessionError: listener: (Error -> unit) -> Http2SecureServer
        [<Emit "$0.prependListener('socketError',$1)">] abstract prependListener_socketError: listener: (Error -> unit) -> Http2SecureServer
        [<Emit "$0.prependListener('stream',$1)">] abstract prependListener_stream: listener: (ServerHttp2Stream -> IncomingHttpHeaders -> float -> unit) -> Http2SecureServer
        [<Emit "$0.prependListener('timeout',$1)">] abstract prependListener_timeout: listener: (unit -> unit) -> Http2SecureServer
        [<Emit "$0.prependListener('unknownProtocol',$1)">] abstract prependListener_unknownProtocol: listener: (Tls.TLSSocket -> unit) -> Http2SecureServer
        abstract prependOnceListener: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> Http2SecureServer
        [<Emit "$0.prependOnceListener('request',$1)">] abstract prependOnceListener_request: listener: (Http2ServerRequest -> Http2ServerResponse -> unit) -> Http2SecureServer
        [<Emit "$0.prependOnceListener('sessionError',$1)">] abstract prependOnceListener_sessionError: listener: (Error -> unit) -> Http2SecureServer
        [<Emit "$0.prependOnceListener('socketError',$1)">] abstract prependOnceListener_socketError: listener: (Error -> unit) -> Http2SecureServer
        [<Emit "$0.prependOnceListener('stream',$1)">] abstract prependOnceListener_stream: listener: (ServerHttp2Stream -> IncomingHttpHeaders -> float -> unit) -> Http2SecureServer
        [<Emit "$0.prependOnceListener('timeout',$1)">] abstract prependOnceListener_timeout: listener: (unit -> unit) -> Http2SecureServer
        [<Emit "$0.prependOnceListener('unknownProtocol',$1)">] abstract prependOnceListener_unknownProtocol: listener: (Tls.TLSSocket -> unit) -> Http2SecureServer

    type [<AllowNullLiteral>] Http2ServerRequest =
        inherit Stream.Readable
        abstract headers: IncomingHttpHeaders with get, set
        abstract httpVersion: string with get, set
        abstract ``method``: string with get, set
        abstract rawHeaders: ResizeArray<string> with get, set
        abstract rawTrailers: ResizeArray<string> with get, set
        abstract setTimeout: msecs: float * ?callback: (unit -> unit) -> unit
        abstract socket: U2<Net.Socket, Tls.TLSSocket> with get, set
        abstract stream: ServerHttp2Stream with get, set
        abstract trailers: IncomingHttpHeaders with get, set
        abstract url: string with get, set
        abstract addListener: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> Http2ServerRequest
        [<Emit "$0.addListener('aborted',$1)">] abstract addListener_aborted: listener: (bool -> float -> unit) -> Http2ServerRequest
        abstract emit: ``event``: U2<string, Symbol> * [<ParamArray>] args: ResizeArray<obj option> -> bool
        [<Emit "$0.emit('aborted',$1,$2)">] abstract emit_aborted: hadError: bool * code: float -> bool
        abstract on: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> Http2ServerRequest
        [<Emit "$0.on('aborted',$1)">] abstract on_aborted: listener: (bool -> float -> unit) -> Http2ServerRequest
        abstract once: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> Http2ServerRequest
        [<Emit "$0.once('aborted',$1)">] abstract once_aborted: listener: (bool -> float -> unit) -> Http2ServerRequest
        abstract prependListener: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> Http2ServerRequest
        [<Emit "$0.prependListener('aborted',$1)">] abstract prependListener_aborted: listener: (bool -> float -> unit) -> Http2ServerRequest
        abstract prependOnceListener: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> Http2ServerRequest
        [<Emit "$0.prependOnceListener('aborted',$1)">] abstract prependOnceListener_aborted: listener: (bool -> float -> unit) -> Http2ServerRequest

    type [<AllowNullLiteral>] Http2ServerResponse =
        inherit Events.EventEmitter
        abstract addTrailers: trailers: OutgoingHttpHeaders -> unit
        abstract connection: U2<Net.Socket, Tls.TLSSocket> with get, set
        abstract ``end``: ?callback: (unit -> unit) -> unit
        abstract ``end``: ?data: U2<string, Buffer> * ?callback: (unit -> unit) -> unit
        abstract ``end``: ?data: U2<string, Buffer> * ?encoding: string * ?callback: (unit -> unit) -> unit
        abstract finished: bool
        abstract getHeader: name: string -> string
        abstract getHeaderNames: unit -> ResizeArray<string>
        abstract getHeaders: unit -> OutgoingHttpHeaders
        abstract hasHeader: name: string -> bool
        abstract headersSent: bool
        abstract removeHeader: name: string -> unit
        abstract sendDate: bool with get, set
        abstract setHeader: name: string * value: U3<float, string, ResizeArray<string>> -> unit
        abstract setTimeout: msecs: float * ?callback: (unit -> unit) -> unit
        abstract socket: U2<Net.Socket, Tls.TLSSocket> with get, set
        abstract statusCode: float with get, set
        abstract statusMessage: string with get, set
        abstract stream: ServerHttp2Stream with get, set
        abstract write: chunk: U2<string, Buffer> * ?callback: (Error -> unit) -> bool
        abstract write: chunk: U2<string, Buffer> * ?encoding: string * ?callback: (Error -> unit) -> bool
        abstract writeContinue: unit -> unit
        abstract writeHead: statusCode: float * ?headers: OutgoingHttpHeaders -> unit
        abstract writeHead: statusCode: float * ?statusMessage: string * ?headers: OutgoingHttpHeaders -> unit
        abstract createPushResponse: headers: OutgoingHttpHeaders * callback: (Error option -> Http2ServerResponse -> unit) -> unit
        abstract addListener: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> Http2ServerResponse
        [<Emit "$0.addListener('aborted',$1)">] abstract addListener_aborted: listener: (bool -> float -> unit) -> Http2ServerResponse
        [<Emit "$0.addListener('close',$1)">] abstract addListener_close: listener: (unit -> unit) -> Http2ServerResponse
        [<Emit "$0.addListener('drain',$1)">] abstract addListener_drain: listener: (unit -> unit) -> Http2ServerResponse
        [<Emit "$0.addListener('error',$1)">] abstract addListener_error: listener: (Error -> unit) -> Http2ServerResponse
        [<Emit "$0.addListener('finish',$1)">] abstract addListener_finish: listener: (unit -> unit) -> Http2ServerResponse
        abstract emit: ``event``: U2<string, Symbol> * [<ParamArray>] args: ResizeArray<obj option> -> bool
        [<Emit "$0.emit('aborted',$1,$2)">] abstract emit_aborted: hadError: bool * code: float -> bool
        [<Emit "$0.emit('close')">] abstract emit_close: unit -> bool
        [<Emit "$0.emit('drain')">] abstract emit_drain: unit -> bool
        [<Emit "$0.emit('error',$1)">] abstract emit_error: error: Error -> bool
        [<Emit "$0.emit('finish')">] abstract emit_finish: unit -> bool
        abstract on: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> Http2ServerResponse
        [<Emit "$0.on('aborted',$1)">] abstract on_aborted: listener: (bool -> float -> unit) -> Http2ServerResponse
        [<Emit "$0.on('close',$1)">] abstract on_close: listener: (unit -> unit) -> Http2ServerResponse
        [<Emit "$0.on('drain',$1)">] abstract on_drain: listener: (unit -> unit) -> Http2ServerResponse
        [<Emit "$0.on('error',$1)">] abstract on_error: listener: (Error -> unit) -> Http2ServerResponse
        [<Emit "$0.on('finish',$1)">] abstract on_finish: listener: (unit -> unit) -> Http2ServerResponse
        abstract once: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> Http2ServerResponse
        [<Emit "$0.once('aborted',$1)">] abstract once_aborted: listener: (bool -> float -> unit) -> Http2ServerResponse
        [<Emit "$0.once('close',$1)">] abstract once_close: listener: (unit -> unit) -> Http2ServerResponse
        [<Emit "$0.once('drain',$1)">] abstract once_drain: listener: (unit -> unit) -> Http2ServerResponse
        [<Emit "$0.once('error',$1)">] abstract once_error: listener: (Error -> unit) -> Http2ServerResponse
        [<Emit "$0.once('finish',$1)">] abstract once_finish: listener: (unit -> unit) -> Http2ServerResponse
        abstract prependListener: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> Http2ServerResponse
        [<Emit "$0.prependListener('aborted',$1)">] abstract prependListener_aborted: listener: (bool -> float -> unit) -> Http2ServerResponse
        [<Emit "$0.prependListener('close',$1)">] abstract prependListener_close: listener: (unit -> unit) -> Http2ServerResponse
        [<Emit "$0.prependListener('drain',$1)">] abstract prependListener_drain: listener: (unit -> unit) -> Http2ServerResponse
        [<Emit "$0.prependListener('error',$1)">] abstract prependListener_error: listener: (Error -> unit) -> Http2ServerResponse
        [<Emit "$0.prependListener('finish',$1)">] abstract prependListener_finish: listener: (unit -> unit) -> Http2ServerResponse
        abstract prependOnceListener: ``event``: string * listener: (ResizeArray<obj option> -> unit) -> Http2ServerResponse
        [<Emit "$0.prependOnceListener('aborted',$1)">] abstract prependOnceListener_aborted: listener: (bool -> float -> unit) -> Http2ServerResponse
        [<Emit "$0.prependOnceListener('close',$1)">] abstract prependOnceListener_close: listener: (unit -> unit) -> Http2ServerResponse
        [<Emit "$0.prependOnceListener('drain',$1)">] abstract prependOnceListener_drain: listener: (unit -> unit) -> Http2ServerResponse
        [<Emit "$0.prependOnceListener('error',$1)">] abstract prependOnceListener_error: listener: (Error -> unit) -> Http2ServerResponse
        [<Emit "$0.prependOnceListener('finish',$1)">] abstract prependOnceListener_finish: listener: (unit -> unit) -> Http2ServerResponse

    module Constants =
        let NGHTTP2_SESSION_SERVER: float = jsNative
        let NGHTTP2_SESSION_CLIENT: float = jsNative
        let NGHTTP2_STREAM_STATE_IDLE: float = jsNative
        let NGHTTP2_STREAM_STATE_OPEN: float = jsNative
        let NGHTTP2_STREAM_STATE_RESERVED_LOCAL: float = jsNative
        let NGHTTP2_STREAM_STATE_RESERVED_REMOTE: float = jsNative
        let NGHTTP2_STREAM_STATE_HALF_CLOSED_LOCAL: float = jsNative
        let NGHTTP2_STREAM_STATE_HALF_CLOSED_REMOTE: float = jsNative
        let NGHTTP2_STREAM_STATE_CLOSED: float = jsNative
        let NGHTTP2_NO_ERROR: float = jsNative
        let NGHTTP2_PROTOCOL_ERROR: float = jsNative
        let NGHTTP2_INTERNAL_ERROR: float = jsNative
        let NGHTTP2_FLOW_CONTROL_ERROR: float = jsNative
        let NGHTTP2_SETTINGS_TIMEOUT: float = jsNative
        let NGHTTP2_STREAM_CLOSED: float = jsNative
        let NGHTTP2_FRAME_SIZE_ERROR: float = jsNative
        let NGHTTP2_REFUSED_STREAM: float = jsNative
        let NGHTTP2_CANCEL: float = jsNative
        let NGHTTP2_COMPRESSION_ERROR: float = jsNative
        let NGHTTP2_CONNECT_ERROR: float = jsNative
        let NGHTTP2_ENHANCE_YOUR_CALM: float = jsNative
        let NGHTTP2_INADEQUATE_SECURITY: float = jsNative
        let NGHTTP2_HTTP_1_1_REQUIRED: float = jsNative
        let NGHTTP2_ERR_FRAME_SIZE_ERROR: float = jsNative
        let NGHTTP2_FLAG_NONE: float = jsNative
        let NGHTTP2_FLAG_END_STREAM: float = jsNative
        let NGHTTP2_FLAG_END_HEADERS: float = jsNative
        let NGHTTP2_FLAG_ACK: float = jsNative
        let NGHTTP2_FLAG_PADDED: float = jsNative
        let NGHTTP2_FLAG_PRIORITY: float = jsNative
        let DEFAULT_SETTINGS_HEADER_TABLE_SIZE: float = jsNative
        let DEFAULT_SETTINGS_ENABLE_PUSH: float = jsNative
        let DEFAULT_SETTINGS_INITIAL_WINDOW_SIZE: float = jsNative
        let DEFAULT_SETTINGS_MAX_FRAME_SIZE: float = jsNative
        let MAX_MAX_FRAME_SIZE: float = jsNative
        let MIN_MAX_FRAME_SIZE: float = jsNative
        let MAX_INITIAL_WINDOW_SIZE: float = jsNative
        let NGHTTP2_DEFAULT_WEIGHT: float = jsNative
        let NGHTTP2_SETTINGS_HEADER_TABLE_SIZE: float = jsNative
        let NGHTTP2_SETTINGS_ENABLE_PUSH: float = jsNative
        let NGHTTP2_SETTINGS_MAX_CONCURRENT_STREAMS: float = jsNative
        let NGHTTP2_SETTINGS_INITIAL_WINDOW_SIZE: float = jsNative
        let NGHTTP2_SETTINGS_MAX_FRAME_SIZE: float = jsNative
        let NGHTTP2_SETTINGS_MAX_HEADER_LIST_SIZE: float = jsNative
        let PADDING_STRATEGY_NONE: float = jsNative
        let PADDING_STRATEGY_MAX: float = jsNative
        let PADDING_STRATEGY_CALLBACK: float = jsNative
        let HTTP2_HEADER_STATUS: string = jsNative
        let HTTP2_HEADER_METHOD: string = jsNative
        let HTTP2_HEADER_AUTHORITY: string = jsNative
        let HTTP2_HEADER_SCHEME: string = jsNative
        let HTTP2_HEADER_PATH: string = jsNative
        let HTTP2_HEADER_ACCEPT_CHARSET: string = jsNative
        let HTTP2_HEADER_ACCEPT_ENCODING: string = jsNative
        let HTTP2_HEADER_ACCEPT_LANGUAGE: string = jsNative
        let HTTP2_HEADER_ACCEPT_RANGES: string = jsNative
        let HTTP2_HEADER_ACCEPT: string = jsNative
        let HTTP2_HEADER_ACCESS_CONTROL_ALLOW_ORIGIN: string = jsNative
        let HTTP2_HEADER_AGE: string = jsNative
        let HTTP2_HEADER_ALLOW: string = jsNative
        let HTTP2_HEADER_AUTHORIZATION: string = jsNative
        let HTTP2_HEADER_CACHE_CONTROL: string = jsNative
        let HTTP2_HEADER_CONNECTION: string = jsNative
        let HTTP2_HEADER_CONTENT_DISPOSITION: string = jsNative
        let HTTP2_HEADER_CONTENT_ENCODING: string = jsNative
        let HTTP2_HEADER_CONTENT_LANGUAGE: string = jsNative
        let HTTP2_HEADER_CONTENT_LENGTH: string = jsNative
        let HTTP2_HEADER_CONTENT_LOCATION: string = jsNative
        let HTTP2_HEADER_CONTENT_MD5: string = jsNative
        let HTTP2_HEADER_CONTENT_RANGE: string = jsNative
        let HTTP2_HEADER_CONTENT_TYPE: string = jsNative
        let HTTP2_HEADER_COOKIE: string = jsNative
        let HTTP2_HEADER_DATE: string = jsNative
        let HTTP2_HEADER_ETAG: string = jsNative
        let HTTP2_HEADER_EXPECT: string = jsNative
        let HTTP2_HEADER_EXPIRES: string = jsNative
        let HTTP2_HEADER_FROM: string = jsNative
        let HTTP2_HEADER_HOST: string = jsNative
        let HTTP2_HEADER_IF_MATCH: string = jsNative
        let HTTP2_HEADER_IF_MODIFIED_SINCE: string = jsNative
        let HTTP2_HEADER_IF_NONE_MATCH: string = jsNative
        let HTTP2_HEADER_IF_RANGE: string = jsNative
        let HTTP2_HEADER_IF_UNMODIFIED_SINCE: string = jsNative
        let HTTP2_HEADER_LAST_MODIFIED: string = jsNative
        let HTTP2_HEADER_LINK: string = jsNative
        let HTTP2_HEADER_LOCATION: string = jsNative
        let HTTP2_HEADER_MAX_FORWARDS: string = jsNative
        let HTTP2_HEADER_PREFER: string = jsNative
        let HTTP2_HEADER_PROXY_AUTHENTICATE: string = jsNative
        let HTTP2_HEADER_PROXY_AUTHORIZATION: string = jsNative
        let HTTP2_HEADER_RANGE: string = jsNative
        let HTTP2_HEADER_REFERER: string = jsNative
        let HTTP2_HEADER_REFRESH: string = jsNative
        let HTTP2_HEADER_RETRY_AFTER: string = jsNative
        let HTTP2_HEADER_SERVER: string = jsNative
        let HTTP2_HEADER_SET_COOKIE: string = jsNative
        let HTTP2_HEADER_STRICT_TRANSPORT_SECURITY: string = jsNative
        let HTTP2_HEADER_TRANSFER_ENCODING: string = jsNative
        let HTTP2_HEADER_TE: string = jsNative
        let HTTP2_HEADER_UPGRADE: string = jsNative
        let HTTP2_HEADER_USER_AGENT: string = jsNative
        let HTTP2_HEADER_VARY: string = jsNative
        let HTTP2_HEADER_VIA: string = jsNative
        let HTTP2_HEADER_WWW_AUTHENTICATE: string = jsNative
        let HTTP2_HEADER_HTTP2_SETTINGS: string = jsNative
        let HTTP2_HEADER_KEEP_ALIVE: string = jsNative
        let HTTP2_HEADER_PROXY_CONNECTION: string = jsNative
        let HTTP2_METHOD_ACL: string = jsNative
        let HTTP2_METHOD_BASELINE_CONTROL: string = jsNative
        let HTTP2_METHOD_BIND: string = jsNative
        let HTTP2_METHOD_CHECKIN: string = jsNative
        let HTTP2_METHOD_CHECKOUT: string = jsNative
        let HTTP2_METHOD_CONNECT: string = jsNative
        let HTTP2_METHOD_COPY: string = jsNative
        let HTTP2_METHOD_DELETE: string = jsNative
        let HTTP2_METHOD_GET: string = jsNative
        let HTTP2_METHOD_HEAD: string = jsNative
        let HTTP2_METHOD_LABEL: string = jsNative
        let HTTP2_METHOD_LINK: string = jsNative
        let HTTP2_METHOD_LOCK: string = jsNative
        let HTTP2_METHOD_MERGE: string = jsNative
        let HTTP2_METHOD_MKACTIVITY: string = jsNative
        let HTTP2_METHOD_MKCALENDAR: string = jsNative
        let HTTP2_METHOD_MKCOL: string = jsNative
        let HTTP2_METHOD_MKREDIRECTREF: string = jsNative
        let HTTP2_METHOD_MKWORKSPACE: string = jsNative
        let HTTP2_METHOD_MOVE: string = jsNative
        let HTTP2_METHOD_OPTIONS: string = jsNative
        let HTTP2_METHOD_ORDERPATCH: string = jsNative
        let HTTP2_METHOD_PATCH: string = jsNative
        let HTTP2_METHOD_POST: string = jsNative
        let HTTP2_METHOD_PRI: string = jsNative
        let HTTP2_METHOD_PROPFIND: string = jsNative
        let HTTP2_METHOD_PROPPATCH: string = jsNative
        let HTTP2_METHOD_PUT: string = jsNative
        let HTTP2_METHOD_REBIND: string = jsNative
        let HTTP2_METHOD_REPORT: string = jsNative
        let HTTP2_METHOD_SEARCH: string = jsNative
        let HTTP2_METHOD_TRACE: string = jsNative
        let HTTP2_METHOD_UNBIND: string = jsNative
        let HTTP2_METHOD_UNCHECKOUT: string = jsNative
        let HTTP2_METHOD_UNLINK: string = jsNative
        let HTTP2_METHOD_UNLOCK: string = jsNative
        let HTTP2_METHOD_UPDATE: string = jsNative
        let HTTP2_METHOD_UPDATEREDIRECTREF: string = jsNative
        let HTTP2_METHOD_VERSION_CONTROL: string = jsNative
        let HTTP_STATUS_CONTINUE: float = jsNative
        let HTTP_STATUS_SWITCHING_PROTOCOLS: float = jsNative
        let HTTP_STATUS_PROCESSING: float = jsNative
        let HTTP_STATUS_OK: float = jsNative
        let HTTP_STATUS_CREATED: float = jsNative
        let HTTP_STATUS_ACCEPTED: float = jsNative
        let HTTP_STATUS_NON_AUTHORITATIVE_INFORMATION: float = jsNative
        let HTTP_STATUS_NO_CONTENT: float = jsNative
        let HTTP_STATUS_RESET_CONTENT: float = jsNative
        let HTTP_STATUS_PARTIAL_CONTENT: float = jsNative
        let HTTP_STATUS_MULTI_STATUS: float = jsNative
        let HTTP_STATUS_ALREADY_REPORTED: float = jsNative
        let HTTP_STATUS_IM_USED: float = jsNative
        let HTTP_STATUS_MULTIPLE_CHOICES: float = jsNative
        let HTTP_STATUS_MOVED_PERMANENTLY: float = jsNative
        let HTTP_STATUS_FOUND: float = jsNative
        let HTTP_STATUS_SEE_OTHER: float = jsNative
        let HTTP_STATUS_NOT_MODIFIED: float = jsNative
        let HTTP_STATUS_USE_PROXY: float = jsNative
        let HTTP_STATUS_TEMPORARY_REDIRECT: float = jsNative
        let HTTP_STATUS_PERMANENT_REDIRECT: float = jsNative
        let HTTP_STATUS_BAD_REQUEST: float = jsNative
        let HTTP_STATUS_UNAUTHORIZED: float = jsNative
        let HTTP_STATUS_PAYMENT_REQUIRED: float = jsNative
        let HTTP_STATUS_FORBIDDEN: float = jsNative
        let HTTP_STATUS_NOT_FOUND: float = jsNative
        let HTTP_STATUS_METHOD_NOT_ALLOWED: float = jsNative
        let HTTP_STATUS_NOT_ACCEPTABLE: float = jsNative
        let HTTP_STATUS_PROXY_AUTHENTICATION_REQUIRED: float = jsNative
        let HTTP_STATUS_REQUEST_TIMEOUT: float = jsNative
        let HTTP_STATUS_CONFLICT: float = jsNative
        let HTTP_STATUS_GONE: float = jsNative
        let HTTP_STATUS_LENGTH_REQUIRED: float = jsNative
        let HTTP_STATUS_PRECONDITION_FAILED: float = jsNative
        let HTTP_STATUS_PAYLOAD_TOO_LARGE: float = jsNative
        let HTTP_STATUS_URI_TOO_LONG: float = jsNative
        let HTTP_STATUS_UNSUPPORTED_MEDIA_TYPE: float = jsNative
        let HTTP_STATUS_RANGE_NOT_SATISFIABLE: float = jsNative
        let HTTP_STATUS_EXPECTATION_FAILED: float = jsNative
        let HTTP_STATUS_TEAPOT: float = jsNative
        let HTTP_STATUS_MISDIRECTED_REQUEST: float = jsNative
        let HTTP_STATUS_UNPROCESSABLE_ENTITY: float = jsNative
        let HTTP_STATUS_LOCKED: float = jsNative
        let HTTP_STATUS_FAILED_DEPENDENCY: float = jsNative
        let HTTP_STATUS_UNORDERED_COLLECTION: float = jsNative
        let HTTP_STATUS_UPGRADE_REQUIRED: float = jsNative
        let HTTP_STATUS_PRECONDITION_REQUIRED: float = jsNative
        let HTTP_STATUS_TOO_MANY_REQUESTS: float = jsNative
        let HTTP_STATUS_REQUEST_HEADER_FIELDS_TOO_LARGE: float = jsNative
        let HTTP_STATUS_UNAVAILABLE_FOR_LEGAL_REASONS: float = jsNative
        let HTTP_STATUS_INTERNAL_SERVER_ERROR: float = jsNative
        let HTTP_STATUS_NOT_IMPLEMENTED: float = jsNative
        let HTTP_STATUS_BAD_GATEWAY: float = jsNative
        let HTTP_STATUS_SERVICE_UNAVAILABLE: float = jsNative
        let HTTP_STATUS_GATEWAY_TIMEOUT: float = jsNative
        let HTTP_STATUS_HTTP_VERSION_NOT_SUPPORTED: float = jsNative
        let HTTP_STATUS_VARIANT_ALSO_NEGOTIATES: float = jsNative
        let HTTP_STATUS_INSUFFICIENT_STORAGE: float = jsNative
        let HTTP_STATUS_LOOP_DETECTED: float = jsNative
        let HTTP_STATUS_BANDWIDTH_LIMIT_EXCEEDED: float = jsNative
        let HTTP_STATUS_NOT_EXTENDED: float = jsNative
        let HTTP_STATUS_NETWORK_AUTHENTICATION_REQUIRED: float = jsNative

module Perf_hooks =

    type [<AllowNullLiteral>] IExports =
        abstract PerformanceObserver: PerformanceObserverStatic
        abstract performance: Performance

    type [<AllowNullLiteral>] PerformanceEntry =
        /// The total number of milliseconds elapsed for this entry.
        /// This value will not be meaningful for all Performance Entry types.
        abstract duration: float
        /// The name of the performance entry.
        abstract name: string
        /// The high resolution millisecond timestamp marking the starting time of the Performance Entry.
        abstract startTime: float
        /// The type of the performance entry.
        /// Currently it may be one of: 'node', 'mark', 'measure', 'gc', or 'function'.
        abstract entryType: string
        /// When performanceEntry.entryType is equal to 'gc', the performance.kind property identifies
        /// the type of garbage collection operation that occurred.
        /// The value may be one of perf_hooks.constants.
        abstract kind: float option

    type [<AllowNullLiteral>] PerformanceNodeTiming =
        inherit PerformanceEntry
        /// The high resolution millisecond timestamp at which the Node.js process completed bootstrap.
        abstract bootstrapComplete: float
        /// The high resolution millisecond timestamp at which cluster processing ended.
        abstract clusterSetupEnd: float
        /// The high resolution millisecond timestamp at which cluster processing started.
        abstract clusterSetupStart: float
        /// The high resolution millisecond timestamp at which the Node.js event loop exited.
        abstract loopExit: float
        /// The high resolution millisecond timestamp at which the Node.js event loop started.
        abstract loopStart: float
        /// The high resolution millisecond timestamp at which main module load ended.
        abstract moduleLoadEnd: float
        /// The high resolution millisecond timestamp at which main module load started.
        abstract moduleLoadStart: float
        /// The high resolution millisecond timestamp at which the Node.js process was initialized.
        abstract nodeStart: float
        /// The high resolution millisecond timestamp at which preload module load ended.
        abstract preloadModuleLoadEnd: float
        /// The high resolution millisecond timestamp at which preload module load started.
        abstract preloadModuleLoadStart: float
        /// The high resolution millisecond timestamp at which third_party_main processing ended.
        abstract thirdPartyMainEnd: float
        /// The high resolution millisecond timestamp at which third_party_main processing started.
        abstract thirdPartyMainStart: float
        /// The high resolution millisecond timestamp at which the V8 platform was initialized.
        abstract v8Start: float

    type [<AllowNullLiteral>] Performance =
        /// <summary>If name is not provided, removes all PerformanceFunction objects from the Performance Timeline.
        /// If name is provided, removes entries with name.</summary>
        /// <param name="name"></param>
        abstract clearFunctions: ?name: string -> unit
        /// <summary>If name is not provided, removes all PerformanceMark objects from the Performance Timeline.
        /// If name is provided, removes only the named mark.</summary>
        /// <param name="name"></param>
        abstract clearMarks: ?name: string -> unit
        /// If name is not provided, removes all PerformanceMeasure objects from the Performance Timeline.
        /// If name is provided, removes only objects whose performanceEntry.name matches name.
        abstract clearMeasures: ?name: string -> unit
        /// Returns a list of all PerformanceEntry objects in chronological order with respect to performanceEntry.startTime.
        abstract getEntries: unit -> ResizeArray<PerformanceEntry>
        /// <summary>Returns a list of all PerformanceEntry objects in chronological order with respect to performanceEntry.startTime
        /// whose performanceEntry.name is equal to name, and optionally, whose performanceEntry.entryType is equal to type.</summary>
        /// <param name="name"></param>
        /// <param name="type"></param>
        abstract getEntriesByName: name: string * ?``type``: string -> ResizeArray<PerformanceEntry>
        /// <summary>Returns a list of all PerformanceEntry objects in chronological order with respect to performanceEntry.startTime
        /// whose performanceEntry.entryType is equal to type.</summary>
        /// <param name="type"></param>
        abstract getEntriesByType: ``type``: string -> ResizeArray<PerformanceEntry>
        /// <summary>Creates a new PerformanceMark entry in the Performance Timeline.
        /// A PerformanceMark is a subclass of PerformanceEntry whose performanceEntry.entryType is always 'mark',
        /// and whose performanceEntry.duration is always 0.
        /// Performance marks are used to mark specific significant moments in the Performance Timeline.</summary>
        /// <param name="name"></param>
        abstract mark: ?name: string -> unit
        /// <summary>Creates a new PerformanceMeasure entry in the Performance Timeline.
        /// A PerformanceMeasure is a subclass of PerformanceEntry whose performanceEntry.entryType is always 'measure',
        /// and whose performanceEntry.duration measures the number of milliseconds elapsed since startMark and endMark.
        /// 
        /// The startMark argument may identify any existing PerformanceMark in the the Performance Timeline, or may identify
        /// any of the timestamp properties provided by the PerformanceNodeTiming class. If the named startMark does not exist,
        /// then startMark is set to timeOrigin by default.
        /// 
        /// The endMark argument must identify any existing PerformanceMark in the the Performance Timeline or any of the timestamp
        /// properties provided by the PerformanceNodeTiming class. If the named endMark does not exist, an error will be thrown.</summary>
        /// <param name="name"></param>
        /// <param name="startMark"></param>
        /// <param name="endMark"></param>
        abstract ``measure``: name: string * startMark: string * endMark: string -> unit
        /// An instance of the PerformanceNodeTiming class that provides performance metrics for specific Node.js operational milestones.
        abstract nodeTiming: PerformanceNodeTiming
        abstract now: unit -> float
        /// The timeOrigin specifies the high resolution millisecond timestamp from which all performance metric durations are measured.
        abstract timeOrigin: float
        /// <summary>Wraps a function within a new function that measures the running time of the wrapped function.
        /// A PerformanceObserver must be subscribed to the 'function' event type in order for the timing details to be accessed.</summary>
        /// <param name="fn"></param>
        abstract timerify: fn: 'T -> 'T

    type [<AllowNullLiteral>] PerformanceObserverEntryList =
        abstract getEntries: unit -> ResizeArray<PerformanceEntry>
        abstract getEntriesByName: name: string * ?``type``: string -> ResizeArray<PerformanceEntry>
        abstract getEntriesByType: ``type``: string -> ResizeArray<PerformanceEntry>

    type [<AllowNullLiteral>] PerformanceObserverCallback =
        [<Emit "$0($1...)">] abstract Invoke: list: PerformanceObserverEntryList * observer: PerformanceObserver -> unit

    type [<AllowNullLiteral>] PerformanceObserver =
        /// Disconnects the PerformanceObserver instance from all notifications.
        abstract disconnect: unit -> unit
        /// <summary>Subscribes the PerformanceObserver instance to notifications of new PerformanceEntry instances identified by options.entryTypes.
        /// When options.buffered is false, the callback will be invoked once for every PerformanceEntry instance.
        /// Property buffered defaults to false.</summary>
        /// <param name="options"></param>
        abstract observe: options: PerformanceObserverObserveOptions -> unit

    type [<AllowNullLiteral>] PerformanceObserverObserveOptions =
        abstract entryTypes: ResizeArray<string> with get, set
        abstract buffered: bool option with get, set

    type [<AllowNullLiteral>] PerformanceObserverStatic =
        [<Emit "new $0($1...)">] abstract Create: callback: PerformanceObserverCallback -> PerformanceObserver

    module Constants =
        let NODE_PERFORMANCE_GC_MAJOR: float = jsNative
        let NODE_PERFORMANCE_GC_MINOR: float = jsNative
        let NODE_PERFORMANCE_GC_INCREMENTAL: float = jsNative
        let NODE_PERFORMANCE_GC_WEAKCB: float = jsNative

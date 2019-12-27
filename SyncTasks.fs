// ts2fable 0.0.0
module rec SyncTasks
open System
open Fable.Core
open Fable.Core.JS

let [<Import("config","synctasks")>] config: Config = jsNative

type [<AllowNullLiteral>] IExports =
    abstract fromThenable: thenable: Es6Thenable<'T> -> STPromise<'T>
    /// This function will defer callback of the specified callback lambda until the next JS tick, simulating standard A+ promise behavior
    abstract asyncCallback: callback: (unit -> unit) -> unit
    abstract all: values: Raceable<'T1> * Raceable<'T2> * Raceable<'T3> * Raceable<'T4> * Raceable<'T5> * Raceable<'T6> * Raceable<'T7> * Raceable<'T8> * Raceable<'T9> * Raceable<'T10> -> STPromise<'T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7 * 'T8 * 'T9 * 'T10>
    abstract all: values: Raceable<'T1> * Raceable<'T2> * Raceable<'T3> * Raceable<'T4> * Raceable<'T5> * Raceable<'T6> * Raceable<'T7> * Raceable<'T8> * Raceable<'T9> -> STPromise<'T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7 * 'T8 * 'T9>
    abstract all: values: Raceable<'T1> * Raceable<'T2> * Raceable<'T3> * Raceable<'T4> * Raceable<'T5> * Raceable<'T6> * Raceable<'T7> * Raceable<'T8> -> STPromise<'T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7 * 'T8>
    abstract all: values: Raceable<'T1> * Raceable<'T2> * Raceable<'T3> * Raceable<'T4> * Raceable<'T5> * Raceable<'T6> * Raceable<'T7> -> STPromise<'T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7>
    abstract all: values: Raceable<'T1> * Raceable<'T2> * Raceable<'T3> * Raceable<'T4> * Raceable<'T5> * Raceable<'T6> -> STPromise<'T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6>
    abstract all: values: Raceable<'T1> * Raceable<'T2> * Raceable<'T3> * Raceable<'T4> * Raceable<'T5> -> STPromise<'T1 * 'T2 * 'T3 * 'T4 * 'T5>
    abstract all: values: Raceable<'T1> * Raceable<'T2> * Raceable<'T3> * Raceable<'T4> -> STPromise<'T1 * 'T2 * 'T3 * 'T4>
    abstract all: values: Raceable<'T1> * Raceable<'T2> * Raceable<'T3> -> STPromise<'T1 * 'T2 * 'T3>
    abstract all: values: Raceable<'T1> * Raceable<'T2> -> STPromise<'T1 * 'T2>
    abstract all: values: ResizeArray<U2<'T, Thenable<'T>>> -> STPromise<ResizeArray<'T>>
    abstract Defer: unit -> Deferred<'T>
    abstract Resolved: unit -> STPromise<'T>
    abstract Resolved: ``val``: 'T -> STPromise<'T>
    abstract Rejected: ?``val``: obj -> STPromise<'T>
    abstract race: values: Raceable<'T1> * Raceable<'T2> * Raceable<'T3> * Raceable<'T4> * Raceable<'T5> * Raceable<'T6> * Raceable<'T7> * Raceable<'T8> * Raceable<'T9> * Raceable<'T10> -> STPromise<obj>
    abstract race: values: Raceable<'T1> * Raceable<'T2> * Raceable<'T3> * Raceable<'T4> * Raceable<'T5> * Raceable<'T6> * Raceable<'T7> * Raceable<'T8> * Raceable<'T9> -> STPromise<obj>
    abstract race: values: Raceable<'T1> * Raceable<'T2> * Raceable<'T3> * Raceable<'T4> * Raceable<'T5> * Raceable<'T6> * Raceable<'T7> * Raceable<'T8> -> STPromise<U8<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8>>
    abstract race: values: Raceable<'T1> * Raceable<'T2> * Raceable<'T3> * Raceable<'T4> * Raceable<'T5> * Raceable<'T6> * Raceable<'T7> -> STPromise<U7<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7>>
    abstract race: values: Raceable<'T1> * Raceable<'T2> * Raceable<'T3> * Raceable<'T4> * Raceable<'T5> * Raceable<'T6> -> STPromise<U6<'T1, 'T2, 'T3, 'T4, 'T5, 'T6>>
    abstract race: values: Raceable<'T1> * Raceable<'T2> * Raceable<'T3> * Raceable<'T4> * Raceable<'T5> -> STPromise<U5<'T1, 'T2, 'T3, 'T4, 'T5>>
    abstract race: values: Raceable<'T1> * Raceable<'T2> * Raceable<'T3> * Raceable<'T4> -> STPromise<U4<'T1, 'T2, 'T3, 'T4>>
    abstract race: values: Raceable<'T1> * Raceable<'T2> * Raceable<'T3> -> STPromise<U3<'T1, 'T2, 'T3>>
    abstract race: values: Raceable<'T1> * Raceable<'T2> -> STPromise<U2<'T1, 'T2>>
    abstract race: values: ResizeArray<U2<'T, Thenable<'T>>> -> STPromise<ResizeArray<'T>>
    abstract raceTimer: promise: STPromise<'T> * timeMs: float -> STPromise<RaceTimerResponse<'T>>

type [<AllowNullLiteral>] Es6Thenable<'R> =
    abstract ``then``: ?onFulfilled: ('R -> U2<'U, Es6Thenable<'U>>) * ?onRejected: (obj option -> U2<'U, Es6Thenable<'U>>) -> Es6Thenable<'U>
    abstract ``then``: ?onFulfilled: ('R -> U2<'U, Es6Thenable<'U>>) * ?onRejected: (obj option -> unit) -> Es6Thenable<'U>

type [<AllowNullLiteral>] SuccessFunc<'T, 'U> =
    [<Emit "$0($1...)">] abstract Invoke: value: 'T -> U2<'U, Thenable<'U>>

type [<AllowNullLiteral>] ErrorFunc<'U> =
    [<Emit "$0($1...)">] abstract Invoke: error: obj option -> U2<'U, Thenable<'U>>

type [<AllowNullLiteral>] CancelFunc =
    [<Emit "$0($1...)">] abstract Invoke: context: obj option -> unit

type [<AllowNullLiteral>] Deferred<'T> =
    abstract resolve: obj: 'T -> Deferred<'T>
    abstract reject: ?obj: obj -> Deferred<'T>
    abstract promise: unit -> STPromise<'T>
    abstract onCancel: callback: CancelFunc -> Deferred<'T>

type [<AllowNullLiteral>] Thenable<'T> =
    abstract ``then``: successFunc: SuccessFunc<'T, 'U> * ?errorFunc: ErrorFunc<'U> -> STPromise<'U>

type [<AllowNullLiteral>] Cancelable =
    abstract cancel: ?context: obj -> unit

type [<AllowNullLiteral>] STPromise<'T> =
    inherit Thenable<'T>
    inherit Cancelable
    abstract catch: errorFunc: ErrorFunc<'T> -> STPromise<'T>
    abstract ``finally``: func: (U2<'T, obj option> -> unit) -> STPromise<'T>
    abstract always: func: (U2<'T, obj option> -> U2<'U, Thenable<'U>>) -> STPromise<'U>
    abstract ``done``: successFunc: ('T -> unit) -> STPromise<'T>
    abstract fail: errorFunc: (obj option -> unit) -> STPromise<'T>
    abstract thenAsync: successFunc: SuccessFunc<'T, 'U> * ?errorFunc: ErrorFunc<'U> -> STPromise<'U>
    abstract setTracingEnabled: enabled: bool -> STPromise<'T>
    abstract toEs6Promise: unit -> Promise<'T>

type Raceable<'T> =
    U2<'T, Thenable<'T>> option

type [<AllowNullLiteral>] RaceTimerResponse<'T> =
    abstract timedOut: bool with get, set
    abstract result: 'T option with get, set

type [<AllowNullLiteral>] Config =
    abstract exceptionsToConsole: bool with get, set
    abstract catchExceptions: bool with get, set
    abstract traceEnabled: bool with get, set
    abstract exceptionHandler: (Error -> unit) option with get, set
    abstract unhandledErrorHandler: (obj option -> unit) with get, set

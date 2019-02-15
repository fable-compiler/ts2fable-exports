// ts2fable 0.0.0
module rec SubscribableEvent
open System
open Fable.Core
open Fable.Import.JS


type [<AllowNullLiteral>] IExports =
    abstract SubscriptionToken: SubscriptionTokenStatic
    abstract SubscribableEvent: SubscribableEventStatic

type [<AllowNullLiteral>] SubscriptionToken =
    abstract unsubscribe: unit -> unit

type [<AllowNullLiteral>] SubscriptionTokenStatic =
    [<Emit "new $0($1...)">] abstract Create: _event: SubscribableEvent<obj option> * _callback: (ResizeArray<obj option> -> U2<bool, unit>) -> SubscriptionToken

type [<AllowNullLiteral>] SubscribableEvent<'F> =
    abstract dispose: unit -> unit
    abstract subscribe: callback: 'F -> SubscriptionToken
    abstract unsubscribe: callback: 'F -> unit
    abstract fire: 'F with get, set

type [<AllowNullLiteral>] SubscribableEventStatic =
    [<Emit "new $0($1...)">] abstract Create: ?_allowStopPropagation: bool -> SubscribableEvent<'F>

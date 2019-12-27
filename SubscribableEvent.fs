// ts2fable 0.0.0
module rec SubscribableEvent
open System
open Fable.Core
open Fable.Core.JS


type [<AllowNullLiteral>] IExports =
    abstract SubscriptionToken: SubscriptionTokenStatic
    abstract SubscribableEvent: SubscribableEventStatic

/// SubscribableEvent.ts
/// 
/// Copyright (c) Microsoft Corporation. All rights reserved.
/// Licensed under the MIT license.
/// 
/// A simple strongly-typed pub/sub/fire eventing system.
type [<AllowNullLiteral>] SubscriptionToken =
    abstract unsubscribe: unit -> unit

/// SubscribableEvent.ts
/// 
/// Copyright (c) Microsoft Corporation. All rights reserved.
/// Licensed under the MIT license.
/// 
/// A simple strongly-typed pub/sub/fire eventing system.
type [<AllowNullLiteral>] SubscriptionTokenStatic =
    [<Emit "new $0($1...)">] abstract Create: _event: SubscribableEvent<obj option> * _callback: (ResizeArray<obj option> -> U2<bool, unit>) -> SubscriptionToken

type [<AllowNullLiteral>] SubscribableEvent<'F> =
    abstract dispose: unit -> unit
    abstract subscribe: callback: 'F -> SubscriptionToken
    abstract unsubscribe: callback: 'F -> unit
    abstract fire: 'F with get, set

type [<AllowNullLiteral>] SubscribableEventStatic =
    [<Emit "new $0($1...)">] abstract Create: ?_allowStopPropagation: bool -> SubscribableEvent<'F>

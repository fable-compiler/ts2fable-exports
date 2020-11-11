// ts2fable 0.0.0
module rec Chai
open System
open Fable.Core
open Fable.Core.JS

type Array<'T> = System.Collections.Generic.IList<'T>
type Error = System.Exception
type Function = System.Action
type ReadonlyMap<'K, 'V> = Map<'K, 'V>
type ReadonlySet<'T> = Set<'T>
type RegExp = System.Text.RegularExpressions.Regex
type Symbol = obj

let [<Import("*","chai")>] chai: Chai.ChaiStatic = jsNative

module Chai =

    type [<AllowNullLiteral>] IExports =
        abstract ErrorConstructor: ErrorConstructorStatic
        abstract Assertion: AssertionStaticStatic
        abstract AssertionError: AssertionErrorStatic

    type Message =
        U2<string, (unit -> string)>

    type ObjectProperty =
        U3<string, Symbol, float>

    type [<AllowNullLiteral>] PathInfo =
        abstract parent: obj with get, set
        abstract name: string with get, set
        abstract value: obj option with get, set
        abstract exists: bool with get, set

    type [<AllowNullLiteral>] ErrorConstructor =
        interface end

    type [<AllowNullLiteral>] ErrorConstructorStatic =
        [<Emit "new $0($1...)">] abstract Create: [<ParamArray>] args: obj option[] -> ErrorConstructor

    type [<AllowNullLiteral>] ChaiUtils =
        abstract addChainableMethod: ctx: obj * name: string * ``method``: (ResizeArray<obj option> -> unit) * ?chainingBehavior: (unit -> unit) -> unit
        abstract overwriteChainableMethod: ctx: obj * name: string * ``method``: (ResizeArray<obj option> -> unit) * ?chainingBehavior: (unit -> unit) -> unit
        abstract addLengthGuard: fn: Function * assertionName: string * isChainable: bool -> unit
        abstract addMethod: ctx: obj * name: string * ``method``: Function -> unit
        abstract addProperty: ctx: obj * name: string * getter: (unit -> obj option) -> unit
        abstract overwriteMethod: ctx: obj * name: string * ``method``: Function -> unit
        abstract overwriteProperty: ctx: obj * name: string * getter: (unit -> obj option) -> unit
        abstract compareByInspect: a: obj * b: obj -> ChaiUtilsCompareByInspectReturn
        abstract expectTypes: obj: obj * types: ResizeArray<string> -> unit
        abstract flag: obj: obj * key: string * ?value: obj -> obj option
        abstract getActual: obj: obj * args: AssertionArgs -> obj option
        abstract getProperties: obj: obj -> ResizeArray<string>
        abstract getEnumerableProperties: obj: obj -> ResizeArray<string>
        abstract getOwnEnumerablePropertySymbols: obj: obj -> ResizeArray<Symbol>
        abstract getOwnEnumerableProperties: obj: obj -> Array<U2<string, Symbol>>
        abstract getMessage: errorLike: U2<Error, string> -> string
        abstract getMessage: obj: obj option * args: AssertionArgs -> string
        abstract inspect: obj: obj option * ?showHidden: bool * ?depth: float * ?colors: bool -> unit
        abstract isProxyEnabled: unit -> bool
        abstract objDisplay: obj: obj -> unit
        abstract proxify: obj: obj * nonChainableMethodName: string -> obj
        abstract test: obj: obj * args: AssertionArgs -> bool
        abstract transferFlags: assertion: Assertion * obj: obj * ?includeAll: bool -> unit
        abstract compatibleInstance: thrown: Error * errorLike: U2<Error, ErrorConstructor> -> bool
        abstract compatibleConstructor: thrown: Error * errorLike: U2<Error, ErrorConstructor> -> bool
        abstract compatibleMessage: thrown: Error * errMatcher: U2<string, RegExp> -> bool
        abstract getConstructorName: constructorFn: Function -> string
        abstract getFuncName: constructorFn: Function -> string option
        abstract hasProperty: obj: obj option * name: ObjectProperty -> bool
        abstract getPathInfo: obj: obj * path: string -> PathInfo
        abstract getPathValue: obj: obj * path: string -> obj option

    type [<RequireQualifiedAccess>] ChaiUtilsCompareByInspectReturn =
        | N1 = 1

    type [<AllowNullLiteral>] ChaiPlugin =
        [<Emit "$0($1...)">] abstract Invoke: chai: ChaiStatic * utils: ChaiUtils -> unit

    type [<AllowNullLiteral>] ChaiStatic =
        abstract expect: ExpectStatic with get, set
        abstract should: unit -> Should
        /// Provides a way to extend the internals of Chai
        abstract ``use``: fn: ChaiPlugin -> ChaiStatic
        abstract util: ChaiUtils with get, set
        abstract ``assert``: AssertStatic with get, set
        abstract config: Config with get, set
        abstract Assertion: AssertionStatic with get, set
        abstract AssertionError: obj with get, set
        abstract version: string with get, set

    type [<AllowNullLiteral>] ExpectStatic =
        [<Emit "$0($1...)">] abstract Invoke: ``val``: obj option * ?message: string -> Assertion
        abstract fail: ?actual: obj * ?expected: obj * ?message: string * ?operator: Operator -> unit

    type [<AllowNullLiteral>] AssertStatic =
        inherit Assert

    type AssertionArgs =
        obj option * Message * Message * obj option * obj * obj

    type [<AllowNullLiteral>] AssertionPrototype =
        abstract ``assert``: [<ParamArray>] args: AssertionArgs -> unit
        abstract _obj: obj option with get, set

    type [<AllowNullLiteral>] AssertionStatic =
        inherit AssertionPrototype
        abstract prototype: AssertionPrototype with get, set
        abstract includeStack: bool with get, set
        abstract showDiff: bool with get, set
        abstract addProperty: name: string * getter: (AssertionStatic -> obj option) -> unit
        abstract addMethod: name: string * ``method``: (AssertionStatic -> ResizeArray<obj option> -> obj option) -> unit
        abstract addChainableMethod: name: string * ``method``: (AssertionStatic -> ResizeArray<obj option> -> unit) * ?chainingBehavior: (unit -> unit) -> unit
        abstract overwriteProperty: name: string * getter: (AssertionStatic -> obj option) -> unit
        abstract overwriteMethod: name: string * ``method``: (AssertionStatic -> ResizeArray<obj option> -> obj option) -> unit
        abstract overwriteChainableMethod: name: string * ``method``: (AssertionStatic -> ResizeArray<obj option> -> unit) * ?chainingBehavior: (unit -> unit) -> unit

    type [<AllowNullLiteral>] AssertionStaticStatic =
        [<Emit "new $0($1...)">] abstract Create: target: obj option * ?message: string * ?ssfi: Function * ?lockSsfi: bool -> AssertionStatic

    type Operator =
        string

    type OperatorComparable =
        U4<bool, float, string, DateTime> option

    type [<AllowNullLiteral>] ShouldAssertion =
        abstract equal: value1: obj option * value2: obj option * ?message: string -> unit
        abstract Throw: ShouldThrow with get, set
        abstract throw: ShouldThrow with get, set
        abstract exist: value: obj option * ?message: string -> unit

    type [<AllowNullLiteral>] Should =
        inherit ShouldAssertion
        abstract not: ShouldAssertion with get, set
        abstract fail: actual: obj option * expected: obj option * ?message: string * ?operator: Operator -> unit

    type [<AllowNullLiteral>] ShouldThrow =
        [<Emit "$0($1...)">] abstract Invoke: actual: Function * ?expected: U2<string, RegExp> * ?message: string -> unit
        [<Emit "$0($1...)">] abstract Invoke: actual: Function * ``constructor``: U2<Error, Function> * ?expected: U2<string, RegExp> * ?message: string -> unit

    type [<AllowNullLiteral>] Assertion =
        inherit LanguageChains
        inherit NumericComparison
        inherit TypeComparison
        abstract not: Assertion with get, set
        abstract deep: Deep with get, set
        abstract ordered: Ordered with get, set
        abstract nested: Nested with get, set
        abstract own: Own with get, set
        abstract any: KeyFilter with get, set
        abstract all: KeyFilter with get, set
        abstract a: TypeComparison with get, set
        abstract an: TypeComparison with get, set
        abstract ``include``: Include with get, set
        abstract includes: Include with get, set
        abstract contain: Include with get, set
        abstract contains: Include with get, set
        abstract ok: Assertion with get, set
        abstract ``true``: Assertion with get, set
        abstract ``false``: Assertion with get, set
        abstract ``null``: Assertion with get, set
        abstract undefined: Assertion with get, set
        abstract NaN: Assertion with get, set
        abstract exist: Assertion with get, set
        abstract empty: Assertion with get, set
        abstract arguments: Assertion with get, set
        abstract Arguments: Assertion with get, set
        abstract equal: Equal with get, set
        abstract equals: Equal with get, set
        abstract eq: Equal with get, set
        abstract eql: Equal with get, set
        abstract eqls: Equal with get, set
        abstract property: Property with get, set
        abstract ownProperty: Property with get, set
        abstract haveOwnProperty: Property with get, set
        abstract ownPropertyDescriptor: OwnPropertyDescriptor with get, set
        abstract haveOwnPropertyDescriptor: OwnPropertyDescriptor with get, set
        abstract length: Length with get, set
        abstract lengthOf: Length with get, set
        abstract ``match``: Match with get, set
        abstract matches: Match with get, set
        abstract string: string: string * ?message: string -> Assertion
        abstract keys: Keys with get, set
        abstract key: string: string -> Assertion
        abstract throw: Throw with get, set
        abstract throws: Throw with get, set
        abstract Throw: Throw with get, set
        abstract respondTo: RespondTo with get, set
        abstract respondsTo: RespondTo with get, set
        abstract itself: Assertion with get, set
        abstract satisfy: Satisfy with get, set
        abstract satisfies: Satisfy with get, set
        abstract closeTo: CloseTo with get, set
        abstract approximately: CloseTo with get, set
        abstract members: Members with get, set
        abstract increase: PropertyChange with get, set
        abstract increases: PropertyChange with get, set
        abstract decrease: PropertyChange with get, set
        abstract decreases: PropertyChange with get, set
        abstract change: PropertyChange with get, set
        abstract changes: PropertyChange with get, set
        abstract extensible: Assertion with get, set
        abstract ``sealed``: Assertion with get, set
        abstract frozen: Assertion with get, set
        abstract oneOf: list: ResizeArray<obj option> * ?message: string -> Assertion

    type [<AllowNullLiteral>] LanguageChains =
        abstract ``to``: Assertion with get, set
        abstract be: Assertion with get, set
        abstract been: Assertion with get, set
        abstract is: Assertion with get, set
        abstract that: Assertion with get, set
        abstract which: Assertion with get, set
        abstract ``and``: Assertion with get, set
        abstract has: Assertion with get, set
        abstract have: Assertion with get, set
        abstract ``with``: Assertion with get, set
        abstract at: Assertion with get, set
        abstract ``of``: Assertion with get, set
        abstract same: Assertion with get, set
        abstract but: Assertion with get, set
        abstract does: Assertion with get, set

    type [<AllowNullLiteral>] NumericComparison =
        abstract above: NumberComparer with get, set
        abstract gt: NumberComparer with get, set
        abstract greaterThan: NumberComparer with get, set
        abstract least: NumberComparer with get, set
        abstract gte: NumberComparer with get, set
        abstract below: NumberComparer with get, set
        abstract lt: NumberComparer with get, set
        abstract lessThan: NumberComparer with get, set
        abstract most: NumberComparer with get, set
        abstract lte: NumberComparer with get, set
        abstract within: start: float * finish: float * ?message: string -> Assertion
        abstract within: start: DateTime * finish: DateTime * ?message: string -> Assertion

    type [<AllowNullLiteral>] NumberComparer =
        [<Emit "$0($1...)">] abstract Invoke: value: U2<float, DateTime> * ?message: string -> Assertion

    type [<AllowNullLiteral>] TypeComparison =
        [<Emit "$0($1...)">] abstract Invoke: ``type``: string * ?message: string -> Assertion
        abstract instanceof: InstanceOf with get, set
        abstract instanceOf: InstanceOf with get, set

    type [<AllowNullLiteral>] InstanceOf =
        [<Emit "$0($1...)">] abstract Invoke: ``constructor``: obj option * ?message: string -> Assertion

    type [<AllowNullLiteral>] CloseTo =
        [<Emit "$0($1...)">] abstract Invoke: expected: float * delta: float * ?message: string -> Assertion

    type [<AllowNullLiteral>] Nested =
        abstract ``include``: Include with get, set
        abstract includes: Include with get, set
        abstract contain: Include with get, set
        abstract contains: Include with get, set
        abstract property: Property with get, set
        abstract members: Members with get, set

    type [<AllowNullLiteral>] Own =
        abstract ``include``: Include with get, set
        abstract includes: Include with get, set
        abstract contain: Include with get, set
        abstract contains: Include with get, set
        abstract property: Property with get, set

    type [<AllowNullLiteral>] Deep =
        abstract equal: Equal with get, set
        abstract equals: Equal with get, set
        abstract eq: Equal with get, set
        abstract ``include``: Include with get, set
        abstract includes: Include with get, set
        abstract contain: Include with get, set
        abstract contains: Include with get, set
        abstract property: Property with get, set
        abstract members: Members with get, set
        abstract ordered: Ordered with get, set
        abstract nested: Nested with get, set
        abstract own: Own with get, set

    type [<AllowNullLiteral>] Ordered =
        abstract members: Members with get, set

    type [<AllowNullLiteral>] KeyFilter =
        abstract keys: Keys with get, set
        abstract members: Members with get, set

    type [<AllowNullLiteral>] Equal =
        [<Emit "$0($1...)">] abstract Invoke: value: obj option * ?message: string -> Assertion

    type [<AllowNullLiteral>] Property =
        [<Emit "$0($1...)">] abstract Invoke: name: string * value: obj option * ?message: string -> Assertion
        [<Emit "$0($1...)">] abstract Invoke: name: string * ?message: string -> Assertion

    type [<AllowNullLiteral>] OwnPropertyDescriptor =
        [<Emit "$0($1...)">] abstract Invoke: name: string * descriptor: PropertyDescriptor * ?message: string -> Assertion
        [<Emit "$0($1...)">] abstract Invoke: name: string * ?message: string -> Assertion

    type [<AllowNullLiteral>] Length =
        inherit LanguageChains
        inherit NumericComparison
        [<Emit "$0($1...)">] abstract Invoke: length: float * ?message: string -> Assertion

    type [<AllowNullLiteral>] Include =
        [<Emit "$0($1...)">] abstract Invoke: value: obj option * ?message: string -> Assertion
        abstract keys: Keys with get, set
        abstract deep: Deep with get, set
        abstract ordered: Ordered with get, set
        abstract members: Members with get, set
        abstract any: KeyFilter with get, set
        abstract all: KeyFilter with get, set

    type [<AllowNullLiteral>] Match =
        [<Emit "$0($1...)">] abstract Invoke: regexp: RegExp * ?message: string -> Assertion

    type [<AllowNullLiteral>] Keys =
        [<Emit "$0($1...)">] abstract Invoke: [<ParamArray>] keys: string[] -> Assertion
        [<Emit "$0($1...)">] abstract Invoke: keys: U2<ResizeArray<obj option>, Object> -> Assertion

    type [<AllowNullLiteral>] Throw =
        [<Emit "$0($1...)">] abstract Invoke: ?expected: U2<string, RegExp> * ?message: string -> Assertion
        [<Emit "$0($1...)">] abstract Invoke: ``constructor``: U2<Error, Function> * ?expected: U2<string, RegExp> * ?message: string -> Assertion

    type [<AllowNullLiteral>] RespondTo =
        [<Emit "$0($1...)">] abstract Invoke: ``method``: string * ?message: string -> Assertion

    type [<AllowNullLiteral>] Satisfy =
        [<Emit "$0($1...)">] abstract Invoke: matcher: Function * ?message: string -> Assertion

    type [<AllowNullLiteral>] Members =
        [<Emit "$0($1...)">] abstract Invoke: set: ResizeArray<obj option> * ?message: string -> Assertion

    type [<AllowNullLiteral>] PropertyChange =
        [<Emit "$0($1...)">] abstract Invoke: ``object``: Object * ?property: string * ?message: string -> Assertion

    type [<AllowNullLiteral>] Assert =
        /// <param name="expression">Expression to test for truthiness.</param>
        /// <param name="message">Message to display on error.</param>
        [<Emit "$0($1...)">] abstract Invoke: expression: obj option * ?message: string -> unit
        /// <summary>Throws a failure.</summary>
        /// <param name="actual">Actual value.</param>
        /// <param name="expected">Potential expected value.</param>
        /// <param name="message">Message to display on error.</param>
        /// <param name="operator">Comparison operator, if not strict equality.</param>
        abstract fail: ?actual: 'T * ?expected: 'T * ?message: string * ?operator: Operator -> unit
        /// <summary>Asserts that object is truthy.</summary>
        /// <param name="message">Message to display on error.</param>
        abstract isOk: value: 'T * ?message: string -> unit
        /// <summary>Asserts that object is truthy.</summary>
        /// <param name="message">Message to display on error.</param>
        abstract ok: value: 'T * ?message: string -> unit
        /// <summary>Asserts that object is falsy.</summary>
        /// <param name="message">Message to display on error.</param>
        abstract isNotOk: value: 'T * ?message: string -> unit
        /// <summary>Asserts that object is falsy.</summary>
        /// <param name="message">Message to display on error.</param>
        abstract notOk: value: 'T * ?message: string -> unit
        /// <summary>Asserts non-strict equality (==) of actual and expected.</summary>
        /// <param name="actual">Actual value.</param>
        /// <param name="expected">Potential expected value.</param>
        /// <param name="message">Message to display on error.</param>
        abstract equal: actual: 'T * expected: 'T * ?message: string -> unit
        /// <summary>Asserts non-strict inequality (==) of actual and expected.</summary>
        /// <param name="actual">Actual value.</param>
        /// <param name="expected">Potential expected value.</param>
        /// <param name="message">Message to display on error.</param>
        abstract notEqual: actual: 'T * expected: 'T * ?message: string -> unit
        /// <summary>Asserts strict equality (===) of actual and expected.</summary>
        /// <param name="actual">Actual value.</param>
        /// <param name="expected">Potential expected value.</param>
        /// <param name="message">Message to display on error.</param>
        abstract strictEqual: actual: 'T * expected: 'T * ?message: string -> unit
        /// <summary>Asserts strict inequality (==) of actual and expected.</summary>
        /// <param name="actual">Actual value.</param>
        /// <param name="expected">Potential expected value.</param>
        /// <param name="message">Message to display on error.</param>
        abstract notStrictEqual: actual: 'T * expected: 'T * ?message: string -> unit
        /// <summary>Asserts that actual is deeply equal (==) to expected.</summary>
        /// <param name="actual">Actual value.</param>
        /// <param name="expected">Potential expected value.</param>
        /// <param name="message">Message to display on error.</param>
        abstract deepEqual: actual: 'T * expected: 'T * ?message: string -> unit
        /// <summary>Asserts that actual is not deeply equal (==) to expected.</summary>
        /// <param name="actual">Actual value.</param>
        /// <param name="expected">Potential expected value.</param>
        /// <param name="message">Message to display on error.</param>
        abstract notDeepEqual: actual: 'T * expected: 'T * ?message: string -> unit
        /// <summary>Asserts that actual is deeply strict equal (===) to expected.</summary>
        /// <param name="actual">Actual value.</param>
        /// <param name="expected">Potential expected value.</param>
        /// <param name="message">Message to display on error.</param>
        abstract deepStrictEqual: actual: 'T * expected: 'T * ?message: string -> unit
        /// <summary>Asserts valueToCheck is strictly greater than (>) valueToBeAbove.</summary>
        /// <param name="valueToCheck">Actual value.</param>
        /// <param name="valueToBeAbove">Minimum Potential expected value.</param>
        /// <param name="message">Message to display on error.</param>
        abstract isAbove: valueToCheck: float * valueToBeAbove: float * ?message: string -> unit
        /// <summary>Asserts valueToCheck is greater than or equal to (>=) valueToBeAtLeast.</summary>
        /// <param name="valueToCheck">Actual value.</param>
        /// <param name="valueToBeAtLeast">Minimum Potential expected value.</param>
        /// <param name="message">Message to display on error.</param>
        abstract isAtLeast: valueToCheck: float * valueToBeAtLeast: float * ?message: string -> unit
        /// <summary>Asserts valueToCheck is strictly less than (<) valueToBeBelow.</summary>
        /// <param name="valueToCheck">Actual value.</param>
        /// <param name="valueToBeBelow">Minimum Potential expected value.</param>
        /// <param name="message">Message to display on error.</param>
        abstract isBelow: valueToCheck: float * valueToBeBelow: float * ?message: string -> unit
        /// <summary>Asserts valueToCheck is less than or equal to (<=) valueToBeAtMost.</summary>
        /// <param name="valueToCheck">Actual value.</param>
        /// <param name="valueToBeAtMost">Minimum Potential expected value.</param>
        /// <param name="message">Message to display on error.</param>
        abstract isAtMost: valueToCheck: float * valueToBeAtMost: float * ?message: string -> unit
        /// <summary>Asserts that value is true.</summary>
        /// <param name="value">Actual value.</param>
        /// <param name="message">Message to display on error.</param>
        abstract isTrue: value: 'T * ?message: string -> unit
        /// <summary>Asserts that value is false.</summary>
        /// <param name="value">Actual value.</param>
        /// <param name="message">Message to display on error.</param>
        abstract isFalse: value: 'T * ?message: string -> unit
        /// <summary>Asserts that value is not true.</summary>
        /// <param name="value">Actual value.</param>
        /// <param name="message">Message to display on error.</param>
        abstract isNotTrue: value: 'T * ?message: string -> unit
        /// <summary>Asserts that value is not false.</summary>
        /// <param name="value">Actual value.</param>
        /// <param name="message">Message to display on error.</param>
        abstract isNotFalse: value: 'T * ?message: string -> unit
        /// <summary>Asserts that value is null.</summary>
        /// <param name="value">Actual value.</param>
        /// <param name="message">Message to display on error.</param>
        abstract isNull: value: 'T * ?message: string -> unit
        /// <summary>Asserts that value is not null.</summary>
        /// <param name="value">Actual value.</param>
        /// <param name="message">Message to display on error.</param>
        abstract isNotNull: value: 'T * ?message: string -> unit
        /// <summary>Asserts that value is NaN.</summary>
        /// <param name="value">Actual value.</param>
        /// <param name="message">Message to display on error.</param>
        abstract isNaN: value: 'T * ?message: string -> unit
        /// <summary>Asserts that value is not NaN.</summary>
        /// <param name="value">Actual value.</param>
        /// <param name="message">Message to display on error.</param>
        abstract isNotNaN: value: 'T * ?message: string -> unit
        /// <summary>Asserts that the target is neither null nor undefined.</summary>
        /// <param name="value">Actual value.</param>
        /// <param name="message">Message to display on error.</param>
        abstract exists: value: 'T * ?message: string -> unit
        /// <summary>Asserts that the target is either null or undefined.</summary>
        /// <param name="value">Actual value.</param>
        /// <param name="message">Message to display on error.</param>
        abstract notExists: value: 'T * ?message: string -> unit
        /// <summary>Asserts that value is undefined.</summary>
        /// <param name="value">Actual value.</param>
        /// <param name="message">Message to display on error.</param>
        abstract isUndefined: value: 'T * ?message: string -> unit
        /// <summary>Asserts that value is not undefined.</summary>
        /// <param name="value">Actual value.</param>
        /// <param name="message">Message to display on error.</param>
        abstract isDefined: value: 'T * ?message: string -> unit
        /// <summary>Asserts that value is a function.</summary>
        /// <param name="value">Actual value.</param>
        /// <param name="message">Message to display on error.</param>
        abstract isFunction: value: 'T * ?message: string -> unit
        /// <summary>Asserts that value is not a function.</summary>
        /// <param name="value">Actual value.</param>
        /// <param name="message">Message to display on error.</param>
        abstract isNotFunction: value: 'T * ?message: string -> unit
        /// <summary>Asserts that value is an object of type 'Object'
        /// (as revealed by Object.prototype.toString).</summary>
        /// <param name="value">Actual value.</param>
        /// <param name="message">Message to display on error.</param>
        abstract isObject: value: 'T * ?message: string -> unit
        /// <summary>Asserts that value is not an object of type 'Object'
        /// (as revealed by Object.prototype.toString).</summary>
        /// <param name="value">Actual value.</param>
        /// <param name="message">Message to display on error.</param>
        abstract isNotObject: value: 'T * ?message: string -> unit
        /// <summary>Asserts that value is an array.</summary>
        /// <param name="value">Actual value.</param>
        /// <param name="message">Message to display on error.</param>
        abstract isArray: value: 'T * ?message: string -> unit
        /// <summary>Asserts that value is not an array.</summary>
        /// <param name="value">Actual value.</param>
        /// <param name="message">Message to display on error.</param>
        abstract isNotArray: value: 'T * ?message: string -> unit
        /// <summary>Asserts that value is a string.</summary>
        /// <param name="value">Actual value.</param>
        /// <param name="message">Message to display on error.</param>
        abstract isString: value: 'T * ?message: string -> unit
        /// <summary>Asserts that value is not a string.</summary>
        /// <param name="value">Actual value.</param>
        /// <param name="message">Message to display on error.</param>
        abstract isNotString: value: 'T * ?message: string -> unit
        /// <summary>Asserts that value is a number.</summary>
        /// <param name="value">Actual value.</param>
        /// <param name="message">Message to display on error.</param>
        abstract isNumber: value: 'T * ?message: string -> unit
        /// <summary>Asserts that value is not a number.</summary>
        /// <param name="value">Actual value.</param>
        /// <param name="message">Message to display on error.</param>
        abstract isNotNumber: value: 'T * ?message: string -> unit
        /// <summary>Asserts that value is a boolean.</summary>
        /// <param name="value">Actual value.</param>
        /// <param name="message">Message to display on error.</param>
        abstract isBoolean: value: 'T * ?message: string -> unit
        /// <summary>Asserts that value is not a boolean.</summary>
        /// <param name="value">Actual value.</param>
        /// <param name="message">Message to display on error.</param>
        abstract isNotBoolean: value: 'T * ?message: string -> unit
        /// <summary>Asserts that value's type is name, as determined by Object.prototype.toString.</summary>
        /// <param name="value">Actual value.</param>
        /// <param name="name">Potential expected type name of value.</param>
        /// <param name="message">Message to display on error.</param>
        abstract typeOf: value: 'T * name: string * ?message: string -> unit
        /// <summary>Asserts that value's type is not name, as determined by Object.prototype.toString.</summary>
        /// <param name="value">Actual value.</param>
        /// <param name="name">Potential expected type name of value.</param>
        /// <param name="message">Message to display on error.</param>
        abstract notTypeOf: value: 'T * name: string * ?message: string -> unit
        /// <summary>Asserts that value is an instance of constructor.</summary>
        /// <param name="value">Actual value.</param>
        /// <param name="constructor">Potential expected contructor of value.</param>
        /// <param name="message">Message to display on error.</param>
        abstract instanceOf: value: 'T * ``constructor``: Function * ?message: string -> unit
        /// <summary>Asserts that value is not an instance of constructor.</summary>
        /// <param name="value">Actual value.</param>
        /// <param name="message">Message to display on error.</param>
        abstract notInstanceOf: value: 'T * ``type``: Function * ?message: string -> unit
        /// <summary>Asserts that haystack includes needle.</summary>
        /// <param name="haystack">Container string.</param>
        /// <param name="needle">Potential substring of haystack.</param>
        /// <param name="message">Message to display on error.</param>
        abstract ``include``: haystack: string * needle: string * ?message: string -> unit
        /// <summary>Asserts that haystack includes needle.</summary>
        /// <param name="haystack">Container array, set or map.</param>
        /// <param name="needle">Potential value contained in haystack.</param>
        /// <param name="message">Message to display on error.</param>
        abstract ``include``: haystack: U3<ResizeArray<'T>, ReadonlySet<'T>, ReadonlyMap<obj option, 'T>> * needle: 'T * ?message: string -> unit
        /// <summary>Asserts that haystack includes needle.</summary>
        /// <param name="haystack">WeakSet container.</param>
        /// <param name="needle">Potential value contained in haystack.</param>
        /// <param name="message">Message to display on error.</param>
        abstract ``include``: haystack: WeakSet<'T> * needle: 'T * ?message: string -> unit when 'T :> obj
        /// <summary>Asserts that haystack includes needle.</summary>
        /// <param name="haystack">Object.</param>
        /// <param name="needle">Potential subset of the haystack's properties.</param>
        /// <param name="message">Message to display on error.</param>
        abstract ``include``: haystack: 'T * needle: obj * ?message: string -> unit
        /// <summary>Asserts that haystack does not includes needle.</summary>
        /// <param name="haystack">Container string.</param>
        /// <param name="needle">Potential substring of haystack.</param>
        /// <param name="message">Message to display on error.</param>
        abstract notInclude: haystack: string * needle: string * ?message: string -> unit
        /// <summary>Asserts that haystack does not includes needle.</summary>
        /// <param name="haystack">Container array, set or map.</param>
        /// <param name="needle">Potential value contained in haystack.</param>
        /// <param name="message">Message to display on error.</param>
        abstract notInclude: haystack: U3<ResizeArray<'T>, ReadonlySet<'T>, ReadonlyMap<obj option, 'T>> * needle: 'T * ?message: string -> unit
        /// <summary>Asserts that haystack does not includes needle.</summary>
        /// <param name="haystack">WeakSet container.</param>
        /// <param name="needle">Potential value contained in haystack.</param>
        /// <param name="message">Message to display on error.</param>
        abstract notInclude: haystack: WeakSet<'T> * needle: 'T * ?message: string -> unit when 'T :> obj
        /// <summary>Asserts that haystack does not includes needle.</summary>
        /// <param name="haystack">Object.</param>
        /// <param name="needle">Potential subset of the haystack's properties.</param>
        /// <param name="message">Message to display on error.</param>
        abstract notInclude: haystack: 'T * needle: obj * ?message: string -> unit
        /// <summary>Asserts that haystack includes needle. Deep equality is used.</summary>
        /// <param name="haystack">Container string.</param>
        /// <param name="needle">Potential substring of haystack.</param>
        /// <param name="message">Message to display on error.</param>
        abstract deepInclude: haystack: string * needle: string * ?message: string -> unit
        /// <summary>Asserts that haystack includes needle. Deep equality is used.</summary>
        /// <param name="haystack">Container array, set or map.</param>
        /// <param name="needle">Potential value contained in haystack.</param>
        /// <param name="message">Message to display on error.</param>
        abstract deepInclude: haystack: U3<ResizeArray<'T>, ReadonlySet<'T>, ReadonlyMap<obj option, 'T>> * needle: 'T * ?message: string -> unit
        /// <summary>Asserts that haystack does not includes needle.</summary>
        /// <param name="haystack">Object.</param>
        /// <param name="needle">Potential subset of the haystack's properties.</param>
        /// <param name="message">Message to display on error.</param>
        abstract deepInclude: haystack: 'T * needle: obj * ?message: string -> unit
        /// <summary>Asserts that haystack does not includes needle. Deep equality is used.</summary>
        /// <param name="haystack">Container string.</param>
        /// <param name="needle">Potential substring of haystack.</param>
        /// <param name="message">Message to display on error.</param>
        abstract notDeepInclude: haystack: string * needle: string * ?message: string -> unit
        /// <summary>Asserts that haystack does not includes needle. Deep equality is used.</summary>
        /// <param name="haystack">Container array, set or map.</param>
        /// <param name="needle">Potential value contained in haystack.</param>
        /// <param name="message">Message to display on error.</param>
        abstract notDeepInclude: haystack: U3<ResizeArray<'T>, ReadonlySet<'T>, ReadonlyMap<obj option, 'T>> * needle: 'T * ?message: string -> unit
        /// <summary>Asserts that haystack does not includes needle. Deep equality is used.</summary>
        /// <param name="haystack">Object.</param>
        /// <param name="needle">Potential subset of the haystack's properties.</param>
        /// <param name="message">Message to display on error.</param>
        abstract notDeepInclude: haystack: 'T * needle: obj * ?message: string -> unit
        /// <summary>Asserts that ‘haystack’ includes ‘needle’. Can be used to assert the inclusion of a subset of properties in an object.
        /// 
        /// Enables the use of dot- and bracket-notation for referencing nested properties.
        /// ‘[]’ and ‘.’ in property names can be escaped using double backslashes.Asserts that ‘haystack’ includes ‘needle’.
        /// Can be used to assert the inclusion of a subset of properties in an object.
        /// Enables the use of dot- and bracket-notation for referencing nested properties.
        /// ‘[]’ and ‘.’ in property names can be escaped using double backslashes.</summary>
        /// <param name="message">Message to display on error.</param>
        abstract nestedInclude: haystack: obj option * needle: obj option * ?message: string -> unit
        /// <summary>Asserts that ‘haystack’ does not include ‘needle’. Can be used to assert the absence of a subset of properties in an object.
        /// 
        /// Enables the use of dot- and bracket-notation for referencing nested properties.
        /// ‘[]’ and ‘.’ in property names can be escaped using double backslashes.Asserts that ‘haystack’ includes ‘needle’.
        /// Can be used to assert the inclusion of a subset of properties in an object.
        /// Enables the use of dot- and bracket-notation for referencing nested properties.
        /// ‘[]’ and ‘.’ in property names can be escaped using double backslashes.</summary>
        /// <param name="message">Message to display on error.</param>
        abstract notNestedInclude: haystack: obj option * needle: obj option * ?message: string -> unit
        /// <summary>Asserts that ‘haystack’ includes ‘needle’. Can be used to assert the inclusion of a subset of properties in an object while checking for deep equality
        /// 
        /// Enables the use of dot- and bracket-notation for referencing nested properties.
        /// ‘[]’ and ‘.’ in property names can be escaped using double backslashes.Asserts that ‘haystack’ includes ‘needle’.
        /// Can be used to assert the inclusion of a subset of properties in an object.
        /// Enables the use of dot- and bracket-notation for referencing nested properties.
        /// ‘[]’ and ‘.’ in property names can be escaped using double backslashes.</summary>
        /// <param name="message">Message to display on error.</param>
        abstract deepNestedInclude: haystack: obj option * needle: obj option * ?message: string -> unit
        /// <summary>Asserts that ‘haystack’ does not include ‘needle’. Can be used to assert the absence of a subset of properties in an object while checking for deep equality.
        /// 
        /// Enables the use of dot- and bracket-notation for referencing nested properties.
        /// ‘[]’ and ‘.’ in property names can be escaped using double backslashes.Asserts that ‘haystack’ includes ‘needle’.
        /// Can be used to assert the inclusion of a subset of properties in an object.
        /// Enables the use of dot- and bracket-notation for referencing nested properties.
        /// ‘[]’ and ‘.’ in property names can be escaped using double backslashes.</summary>
        /// <param name="message">Message to display on error.</param>
        abstract notDeepNestedInclude: haystack: obj option * needle: obj option * ?message: string -> unit
        /// <summary>Asserts that ‘haystack’ includes ‘needle’. Can be used to assert the inclusion of a subset of properties in an object while ignoring inherited properties.</summary>
        /// <param name="message">Message to display on error.</param>
        abstract ownInclude: haystack: obj option * needle: obj option * ?message: string -> unit
        /// <summary>Asserts that ‘haystack’ includes ‘needle’. Can be used to assert the absence of a subset of properties in an object while ignoring inherited properties.</summary>
        /// <param name="message">Message to display on error.</param>
        abstract notOwnInclude: haystack: obj option * needle: obj option * ?message: string -> unit
        /// <summary>Asserts that ‘haystack’ includes ‘needle’. Can be used to assert the inclusion of a subset of properties in an object while ignoring inherited properties and checking for deep</summary>
        /// <param name="message">Message to display on error.</param>
        abstract deepOwnInclude: haystack: obj option * needle: obj option * ?message: string -> unit
        /// <summary>Asserts that ‘haystack’ includes ‘needle’. Can be used to assert the absence of a subset of properties in an object while ignoring inherited properties and checking for deep equality.</summary>
        /// <param name="message">Message to display on error.</param>
        abstract notDeepOwnInclude: haystack: obj option * needle: obj option * ?message: string -> unit
        /// <summary>Asserts that value matches the regular expression regexp.</summary>
        /// <param name="value">Actual value.</param>
        /// <param name="regexp">Potential match of value.</param>
        /// <param name="message">Message to display on error.</param>
        abstract ``match``: value: string * regexp: RegExp * ?message: string -> unit
        /// <summary>Asserts that value does not match the regular expression regexp.</summary>
        /// <param name="regexp">Potential match of value.</param>
        /// <param name="message">Message to display on error.</param>
        abstract notMatch: expected: obj option * regexp: RegExp * ?message: string -> unit
        /// <summary>Asserts that object has a property named by property.</summary>
        /// <param name="object">Container object.</param>
        /// <param name="property">Potential contained property of object.</param>
        /// <param name="message">Message to display on error.</param>
        abstract property: ``object``: 'T * property: string * ?message: string -> unit
        /// <summary>Asserts that object has a property named by property.</summary>
        /// <param name="object">Container object.</param>
        /// <param name="property">Potential contained property of object.</param>
        /// <param name="message">Message to display on error.</param>
        abstract notProperty: ``object``: 'T * property: string * ?message: string -> unit
        /// <summary>Asserts that object has a property named by property, which can be a string
        /// using dot- and bracket-notation for deep reference.</summary>
        /// <param name="object">Container object.</param>
        /// <param name="property">Potential contained property of object.</param>
        /// <param name="message">Message to display on error.</param>
        abstract deepProperty: ``object``: 'T * property: string * ?message: string -> unit
        /// <summary>Asserts that object does not have a property named by property, which can be a
        /// string using dot- and bracket-notation for deep reference.</summary>
        /// <param name="object">Container object.</param>
        /// <param name="property">Potential contained property of object.</param>
        /// <param name="message">Message to display on error.</param>
        abstract notDeepProperty: ``object``: 'T * property: string * ?message: string -> unit
        /// <summary>Asserts that object has a property named by property with value given by value.</summary>
        /// <param name="object">Container object.</param>
        /// <param name="property">Potential contained property of object.</param>
        /// <param name="value">Potential expected property value.</param>
        /// <param name="message">Message to display on error.</param>
        abstract propertyVal: ``object``: 'T * property: string * value: 'V * ?message: string -> unit
        /// <summary>Asserts that object has a property named by property with value given by value.</summary>
        /// <param name="object">Container object.</param>
        /// <param name="property">Potential contained property of object.</param>
        /// <param name="value">Potential expected property value.</param>
        /// <param name="message">Message to display on error.</param>
        abstract propertyNotVal: ``object``: 'T * property: string * value: 'V * ?message: string -> unit
        /// <summary>Asserts that object has a property named by property, which can be a string
        /// using dot- and bracket-notation for deep reference.</summary>
        /// <param name="object">Container object.</param>
        /// <param name="property">Potential contained property of object.</param>
        /// <param name="value">Potential expected property value.</param>
        /// <param name="message">Message to display on error.</param>
        abstract deepPropertyVal: ``object``: 'T * property: string * value: 'V * ?message: string -> unit
        /// <summary>Asserts that object does not have a property named by property, which can be a
        /// string using dot- and bracket-notation for deep reference.</summary>
        /// <param name="object">Container object.</param>
        /// <param name="property">Potential contained property of object.</param>
        /// <param name="value">Potential expected property value.</param>
        /// <param name="message">Message to display on error.</param>
        abstract deepPropertyNotVal: ``object``: 'T * property: string * value: 'V * ?message: string -> unit
        /// <summary>Asserts that object has a length property with the expected value.</summary>
        /// <param name="object">Container object.</param>
        /// <param name="length">Potential expected length of object.</param>
        /// <param name="message">Message to display on error.</param>
        abstract lengthOf: ``object``: 'T * length: float * ?message: string -> unit
        /// <summary>Asserts that fn will throw an error.</summary>
        /// <param name="fn">Function that may throw.</param>
        /// <param name="message">Message to display on error.</param>
        abstract throw: fn: Function * ?message: string -> unit
        /// <summary>Asserts that function will throw an error with message matching regexp.</summary>
        /// <param name="fn">Function that may throw.</param>
        /// <param name="regExp">Potential expected message match.</param>
        abstract throw: fn: Function * regExp: RegExp -> unit
        /// <summary>Asserts that function will throw an error that is an instance of constructor.</summary>
        /// <param name="fn">Function that may throw.</param>
        /// <param name="constructor">Potential expected error constructor.</param>
        /// <param name="message">Message to display on error.</param>
        abstract throw: fn: Function * ``constructor``: Function * ?message: string -> unit
        /// <summary>Asserts that function will throw an error that is an instance of constructor
        /// and an error with message matching regexp.</summary>
        /// <param name="fn">Function that may throw.</param>
        /// <param name="constructor">Potential expected error constructor.</param>
        abstract throw: fn: Function * ``constructor``: Function * regExp: RegExp -> unit
        /// <summary>Asserts that fn will throw an error.</summary>
        /// <param name="fn">Function that may throw.</param>
        /// <param name="message">Message to display on error.</param>
        abstract throws: fn: Function * ?message: string -> unit
        /// <summary>Asserts that function will throw an error with message matching regexp.</summary>
        /// <param name="fn">Function that may throw.</param>
        /// <param name="errType">Potential expected message match or error constructor.</param>
        /// <param name="message">Message to display on error.</param>
        abstract throws: fn: Function * errType: U2<RegExp, Function> * ?message: string -> unit
        /// <summary>Asserts that function will throw an error that is an instance of constructor
        /// and an error with message matching regexp.</summary>
        /// <param name="fn">Function that may throw.</param>
        abstract throws: fn: Function * errType: Function * regExp: RegExp -> unit
        /// <summary>Asserts that fn will throw an error.</summary>
        /// <param name="fn">Function that may throw.</param>
        /// <param name="message">Message to display on error.</param>
        abstract Throw: fn: Function * ?message: string -> unit
        /// <summary>Asserts that function will throw an error with message matching regexp.</summary>
        /// <param name="fn">Function that may throw.</param>
        /// <param name="regExp">Potential expected message match.</param>
        abstract Throw: fn: Function * regExp: RegExp -> unit
        /// <summary>Asserts that function will throw an error that is an instance of constructor.</summary>
        /// <param name="fn">Function that may throw.</param>
        /// <param name="message">Message to display on error.</param>
        abstract Throw: fn: Function * errType: Function * ?message: string -> unit
        /// <summary>Asserts that function will throw an error that is an instance of constructor
        /// and an error with message matching regexp.</summary>
        /// <param name="fn">Function that may throw.</param>
        abstract Throw: fn: Function * errType: Function * regExp: RegExp -> unit
        /// <summary>Asserts that fn will not throw an error.</summary>
        /// <param name="fn">Function that may throw.</param>
        /// <param name="message">Message to display on error.</param>
        abstract doesNotThrow: fn: Function * ?message: string -> unit
        /// <summary>Asserts that function will throw an error with message matching regexp.</summary>
        /// <param name="fn">Function that may throw.</param>
        /// <param name="regExp">Potential expected message match.</param>
        abstract doesNotThrow: fn: Function * regExp: RegExp -> unit
        /// <summary>Asserts that function will throw an error that is an instance of constructor.</summary>
        /// <param name="fn">Function that may throw.</param>
        /// <param name="message">Message to display on error.</param>
        abstract doesNotThrow: fn: Function * errType: Function * ?message: string -> unit
        /// <summary>Asserts that function will throw an error that is an instance of constructor
        /// and an error with message matching regexp.</summary>
        /// <param name="fn">Function that may throw.</param>
        abstract doesNotThrow: fn: Function * errType: Function * regExp: RegExp -> unit
        /// <summary>Compares two values using operator.</summary>
        /// <param name="val1">Left value during comparison.</param>
        /// <param name="operator">Comparison operator.</param>
        /// <param name="val2">Right value during comparison.</param>
        /// <param name="message">Message to display on error.</param>
        abstract operator: val1: OperatorComparable * operator: Operator * val2: OperatorComparable * ?message: string -> unit
        /// <summary>Asserts that the target is equal to expected, to within a +/- delta range.</summary>
        /// <param name="actual">Actual value</param>
        /// <param name="expected">Potential expected value.</param>
        /// <param name="delta">Maximum differenced between values.</param>
        /// <param name="message">Message to display on error.</param>
        abstract closeTo: actual: float * expected: float * delta: float * ?message: string -> unit
        /// <summary>Asserts that the target is equal to expected, to within a +/- delta range.</summary>
        /// <param name="delta">Maximum differenced between values.</param>
        /// <param name="message">Message to display on error.</param>
        abstract approximately: act: float * exp: float * delta: float * ?message: string -> unit
        /// <summary>Asserts that set1 and set2 have the same members. Order is not take into account.</summary>
        /// <param name="set1">Actual set of values.</param>
        /// <param name="set2">Potential expected set of values.</param>
        /// <param name="message">Message to display on error.</param>
        abstract sameMembers: set1: ResizeArray<'T> * set2: ResizeArray<'T> * ?message: string -> unit
        /// <summary>Asserts that set1 and set2 have the same members using deep equality checking.
        /// Order is not take into account.</summary>
        /// <param name="set1">Actual set of values.</param>
        /// <param name="set2">Potential expected set of values.</param>
        /// <param name="message">Message to display on error.</param>
        abstract sameDeepMembers: set1: ResizeArray<'T> * set2: ResizeArray<'T> * ?message: string -> unit
        /// <summary>Asserts that set1 and set2 have the same members in the same order.
        /// Uses a strict equality check (===).</summary>
        /// <param name="set1">Actual set of values.</param>
        /// <param name="set2">Potential expected set of values.</param>
        /// <param name="message">Message to display on error.</param>
        abstract sameOrderedMembers: set1: ResizeArray<'T> * set2: ResizeArray<'T> * ?message: string -> unit
        /// <summary>Asserts that set1 and set2 don’t have the same members in the same order.
        /// Uses a strict equality check (===).</summary>
        /// <param name="set1">Actual set of values.</param>
        /// <param name="set2">Potential expected set of values.</param>
        /// <param name="message">Message to display on error.</param>
        abstract notSameOrderedMembers: set1: ResizeArray<'T> * set2: ResizeArray<'T> * ?message: string -> unit
        /// <summary>Asserts that set1 and set2 have the same members in the same order.
        /// Uses a deep equality check.</summary>
        /// <param name="set1">Actual set of values.</param>
        /// <param name="set2">Potential expected set of values.</param>
        /// <param name="message">Message to display on error.</param>
        abstract sameDeepOrderedMembers: set1: ResizeArray<'T> * set2: ResizeArray<'T> * ?message: string -> unit
        /// <summary>Asserts that set1 and set2 don’t have the same members in the same order.
        /// Uses a deep equality check.</summary>
        /// <param name="set1">Actual set of values.</param>
        /// <param name="set2">Potential expected set of values.</param>
        /// <param name="message">Message to display on error.</param>
        abstract notSameDeepOrderedMembers: set1: ResizeArray<'T> * set2: ResizeArray<'T> * ?message: string -> unit
        /// <summary>Asserts that subset is included in superset in the same order beginning with the first element in superset.
        /// Uses a strict equality check (===).</summary>
        /// <param name="superset">Actual set of values.</param>
        /// <param name="subset">Potential contained set of values.</param>
        /// <param name="message">Message to display on error.</param>
        abstract includeOrderedMembers: superset: ResizeArray<'T> * subset: ResizeArray<'T> * ?message: string -> unit
        /// <summary>Asserts that subset isn’t included in superset in the same order beginning with the first element in superset.
        /// Uses a strict equality check (===).</summary>
        /// <param name="superset">Actual set of values.</param>
        /// <param name="subset">Potential contained set of values.</param>
        /// <param name="message">Message to display on error.</param>
        abstract notIncludeOrderedMembers: superset: ResizeArray<'T> * subset: ResizeArray<'T> * ?message: string -> unit
        /// <summary>Asserts that subset is included in superset in the same order beginning with the first element in superset.
        /// Uses a deep equality check.</summary>
        /// <param name="superset">Actual set of values.</param>
        /// <param name="subset">Potential contained set of values.</param>
        /// <param name="message">Message to display on error.</param>
        abstract includeDeepOrderedMembers: superset: ResizeArray<'T> * subset: ResizeArray<'T> * ?message: string -> unit
        /// <summary>Asserts that subset isn’t included in superset in the same order beginning with the first element in superset.
        /// Uses a deep equality check.</summary>
        /// <param name="superset">Actual set of values.</param>
        /// <param name="subset">Potential contained set of values.</param>
        /// <param name="message">Message to display on error.</param>
        abstract notIncludeDeepOrderedMembers: superset: ResizeArray<'T> * subset: ResizeArray<'T> * ?message: string -> unit
        /// <summary>Asserts that subset is included in superset. Order is not take into account.</summary>
        /// <param name="superset">Actual set of values.</param>
        /// <param name="subset">Potential contained set of values.</param>
        /// <param name="message">Message to display on error.</param>
        abstract includeMembers: superset: ResizeArray<'T> * subset: ResizeArray<'T> * ?message: string -> unit
        /// <summary>Asserts that subset is included in superset using deep equality checking.
        /// Order is not take into account.</summary>
        /// <param name="superset">Actual set of values.</param>
        /// <param name="subset">Potential contained set of values.</param>
        /// <param name="message">Message to display on error.</param>
        abstract includeDeepMembers: superset: ResizeArray<'T> * subset: ResizeArray<'T> * ?message: string -> unit
        /// <summary>Asserts that non-object, non-array value inList appears in the flat array list.</summary>
        /// <param name="inList">Value expected to be in the list.</param>
        /// <param name="list">List of values.</param>
        /// <param name="message">Message to display on error.</param>
        abstract oneOf: inList: 'T * list: ResizeArray<'T> * ?message: string -> unit
        /// <summary>Asserts that a function changes the value of a property.</summary>
        /// <param name="modifier">Function to run.</param>
        /// <param name="object">Container object.</param>
        /// <param name="property">Property of object expected to be modified.</param>
        /// <param name="message">Message to display on error.</param>
        abstract changes: modifier: Function * ``object``: 'T * property: string * ?message: string -> unit
        /// <summary>Asserts that a function does not change the value of a property.</summary>
        /// <param name="modifier">Function to run.</param>
        /// <param name="object">Container object.</param>
        /// <param name="property">Property of object expected not to be modified.</param>
        /// <param name="message">Message to display on error.</param>
        abstract doesNotChange: modifier: Function * ``object``: 'T * property: string * ?message: string -> unit
        /// <summary>Asserts that a function increases an object property.</summary>
        /// <param name="modifier">Function to run.</param>
        /// <param name="object">Container object.</param>
        /// <param name="property">Property of object expected to be increased.</param>
        /// <param name="message">Message to display on error.</param>
        abstract increases: modifier: Function * ``object``: 'T * property: string * ?message: string -> unit
        /// <summary>Asserts that a function does not increase an object property.</summary>
        /// <param name="modifier">Function to run.</param>
        /// <param name="object">Container object.</param>
        /// <param name="property">Property of object expected not to be increased.</param>
        /// <param name="message">Message to display on error.</param>
        abstract doesNotIncrease: modifier: Function * ``object``: 'T * property: string * ?message: string -> unit
        /// <summary>Asserts that a function decreases an object property.</summary>
        /// <param name="modifier">Function to run.</param>
        /// <param name="object">Container object.</param>
        /// <param name="property">Property of object expected to be decreased.</param>
        /// <param name="message">Message to display on error.</param>
        abstract decreases: modifier: Function * ``object``: 'T * property: string * ?message: string -> unit
        /// <summary>Asserts that a function does not decrease an object property.</summary>
        /// <param name="modifier">Function to run.</param>
        /// <param name="object">Container object.</param>
        /// <param name="property">Property of object expected not to be decreased.</param>
        /// <param name="message">Message to display on error.</param>
        abstract doesNotDecrease: modifier: Function * ``object``: 'T * property: string * ?message: string -> unit
        /// <summary>Asserts if value is not a false value, and throws if it is a true value.</summary>
        /// <param name="object">Actual value.</param>
        /// <param name="message">Message to display on error.</param>
        abstract ifError: ``object``: 'T * ?message: string -> unit
        /// <summary>Asserts that object is extensible (can have new properties added to it).</summary>
        /// <param name="object">Actual value.</param>
        /// <param name="message">Message to display on error.</param>
        abstract isExtensible: ``object``: 'T * ?message: string -> unit
        /// <summary>Asserts that object is extensible (can have new properties added to it).</summary>
        /// <param name="object">Actual value.</param>
        /// <param name="message">Message to display on error.</param>
        abstract extensible: ``object``: 'T * ?message: string -> unit
        /// <summary>Asserts that object is not extensible.</summary>
        /// <param name="object">Actual value.</param>
        /// <param name="message">Message to display on error.</param>
        abstract isNotExtensible: ``object``: 'T * ?message: string -> unit
        /// <summary>Asserts that object is not extensible.</summary>
        /// <param name="object">Actual value.</param>
        /// <param name="message">Message to display on error.</param>
        abstract notExtensible: ``object``: 'T * ?message: string -> unit
        /// <summary>Asserts that object is sealed (can have new properties added to it
        /// and its existing properties cannot be removed).</summary>
        /// <param name="object">Actual value.</param>
        /// <param name="message">Message to display on error.</param>
        abstract isSealed: ``object``: 'T * ?message: string -> unit
        /// <summary>Asserts that object is sealed (can have new properties added to it
        /// and its existing properties cannot be removed).</summary>
        /// <param name="object">Actual value.</param>
        /// <param name="message">Message to display on error.</param>
        abstract ``sealed``: ``object``: 'T * ?message: string -> unit
        /// <summary>Asserts that object is not sealed.</summary>
        /// <param name="object">Actual value.</param>
        /// <param name="message">Message to display on error.</param>
        abstract isNotSealed: ``object``: 'T * ?message: string -> unit
        /// <summary>Asserts that object is not sealed.</summary>
        /// <param name="object">Actual value.</param>
        /// <param name="message">Message to display on error.</param>
        abstract notSealed: ``object``: 'T * ?message: string -> unit
        /// <summary>Asserts that object is frozen (cannot have new properties added to it
        /// and its existing properties cannot be removed).</summary>
        /// <param name="object">Actual value.</param>
        /// <param name="message">Message to display on error.</param>
        abstract isFrozen: ``object``: 'T * ?message: string -> unit
        /// <summary>Asserts that object is frozen (cannot have new properties added to it
        /// and its existing properties cannot be removed).</summary>
        /// <param name="object">Actual value.</param>
        /// <param name="message">Message to display on error.</param>
        abstract frozen: ``object``: 'T * ?message: string -> unit
        /// <summary>Asserts that object is not frozen (cannot have new properties added to it
        /// and its existing properties cannot be removed).</summary>
        /// <param name="object">Actual value.</param>
        /// <param name="message">Message to display on error.</param>
        abstract isNotFrozen: ``object``: 'T * ?message: string -> unit
        /// <summary>Asserts that object is not frozen (cannot have new properties added to it
        /// and its existing properties cannot be removed).</summary>
        /// <param name="object">Actual value.</param>
        /// <param name="message">Message to display on error.</param>
        abstract notFrozen: ``object``: 'T * ?message: string -> unit
        /// <summary>Asserts that the target does not contain any values. For arrays and
        /// strings, it checks the length property. For Map and Set instances, it
        /// checks the size property. For non-function objects, it gets the count
        /// of own enumerable string keys.</summary>
        /// <param name="object">Actual value.</param>
        /// <param name="message">Message to display on error.</param>
        abstract isEmpty: ``object``: 'T * ?message: string -> unit
        /// <summary>Asserts that the target contains values. For arrays and strings, it checks
        /// the length property. For Map and Set instances, it checks the size property.
        /// For non-function objects, it gets the count of own enumerable string keys.</summary>
        /// <param name="object">Object to test.</param>
        /// <param name="message">Message to display on error.</param>
        abstract isNotEmpty: ``object``: 'T * ?message: string -> unit
        /// <summary>Asserts that `object` has at least one of the `keys` provided.
        /// You can also provide a single object instead of a `keys` array and its keys
        /// will be used as the expected set of keys.</summary>
        /// <param name="object">Object to test.</param>
        /// <param name="keys">Keys to check</param>
        /// <param name="message">Message to display on error.</param>
        abstract hasAnyKeys: ``object``: 'T * keys: U2<Array<U2<Object, string>>, AssertHasAnyKeys> * ?message: string -> unit
        /// <summary>Asserts that `object` has all and only all of the `keys` provided.
        /// You can also provide a single object instead of a `keys` array and its keys
        /// will be used as the expected set of keys.</summary>
        /// <param name="object">Object to test.</param>
        /// <param name="keys">Keys to check</param>
        /// <param name="message">Message to display on error.</param>
        abstract hasAllKeys: ``object``: 'T * keys: U2<Array<U2<Object, string>>, AssertHasAnyKeys> * ?message: string -> unit
        /// <summary>Asserts that `object` has all of the `keys` provided but may have more keys not listed.
        /// You can also provide a single object instead of a `keys` array and its keys
        /// will be used as the expected set of keys.</summary>
        /// <param name="object">Object to test.</param>
        /// <param name="keys">Keys to check</param>
        /// <param name="message">Message to display on error.</param>
        abstract containsAllKeys: ``object``: 'T * keys: U2<Array<U2<Object, string>>, AssertHasAnyKeys> * ?message: string -> unit
        /// <summary>Asserts that `object` has none of the `keys` provided.
        /// You can also provide a single object instead of a `keys` array and its keys
        /// will be used as the expected set of keys.</summary>
        /// <param name="object">Object to test.</param>
        /// <param name="keys">Keys to check</param>
        /// <param name="message">Message to display on error.</param>
        abstract doesNotHaveAnyKeys: ``object``: 'T * keys: U2<Array<U2<Object, string>>, AssertHasAnyKeys> * ?message: string -> unit
        /// <summary>Asserts that `object` does not have at least one of the `keys` provided.
        /// You can also provide a single object instead of a `keys` array and its keys
        /// will be used as the expected set of keys.</summary>
        /// <param name="object">Object to test.</param>
        /// <param name="keys">Keys to check</param>
        /// <param name="message">Message to display on error.</param>
        abstract doesNotHaveAllKeys: ``object``: 'T * keys: U2<Array<U2<Object, string>>, AssertHasAnyKeys> * ?message: string -> unit
        /// <summary>Asserts that `object` has at least one of the `keys` provided.
        /// Since Sets and Maps can have objects as keys you can use this assertion to perform
        /// a deep comparison.
        /// You can also provide a single object instead of a `keys` array and its keys
        /// will be used as the expected set of keys.</summary>
        /// <param name="object">Object to test.</param>
        /// <param name="keys">Keys to check</param>
        /// <param name="message">Message to display on error.</param>
        abstract hasAnyDeepKeys: ``object``: 'T * keys: U2<Array<U2<Object, string>>, AssertHasAnyKeys> * ?message: string -> unit
        /// <summary>Asserts that `object` has all and only all of the `keys` provided.
        /// Since Sets and Maps can have objects as keys you can use this assertion to perform
        /// a deep comparison.
        /// You can also provide a single object instead of a `keys` array and its keys
        /// will be used as the expected set of keys.</summary>
        /// <param name="object">Object to test.</param>
        /// <param name="keys">Keys to check</param>
        /// <param name="message">Message to display on error.</param>
        abstract hasAllDeepKeys: ``object``: 'T * keys: U2<Array<U2<Object, string>>, AssertHasAnyKeys> * ?message: string -> unit
        /// <summary>Asserts that `object` contains all of the `keys` provided.
        /// Since Sets and Maps can have objects as keys you can use this assertion to perform
        /// a deep comparison.
        /// You can also provide a single object instead of a `keys` array and its keys
        /// will be used as the expected set of keys.</summary>
        /// <param name="object">Object to test.</param>
        /// <param name="keys">Keys to check</param>
        /// <param name="message">Message to display on error.</param>
        abstract containsAllDeepKeys: ``object``: 'T * keys: U2<Array<U2<Object, string>>, AssertHasAnyKeys> * ?message: string -> unit
        /// <summary>Asserts that `object` contains all of the `keys` provided.
        /// Since Sets and Maps can have objects as keys you can use this assertion to perform
        /// a deep comparison.
        /// You can also provide a single object instead of a `keys` array and its keys
        /// will be used as the expected set of keys.</summary>
        /// <param name="object">Object to test.</param>
        /// <param name="keys">Keys to check</param>
        /// <param name="message">Message to display on error.</param>
        abstract doesNotHaveAnyDeepKeys: ``object``: 'T * keys: U2<Array<U2<Object, string>>, AssertHasAnyKeys> * ?message: string -> unit
        /// <summary>Asserts that `object` contains all of the `keys` provided.
        /// Since Sets and Maps can have objects as keys you can use this assertion to perform
        /// a deep comparison.
        /// You can also provide a single object instead of a `keys` array and its keys
        /// will be used as the expected set of keys.</summary>
        /// <param name="object">Object to test.</param>
        /// <param name="keys">Keys to check</param>
        /// <param name="message">Message to display on error.</param>
        abstract doesNotHaveAllDeepKeys: ``object``: 'T * keys: U2<Array<U2<Object, string>>, AssertHasAnyKeys> * ?message: string -> unit
        /// <summary>Asserts that object has a direct or inherited property named by property,
        /// which can be a string using dot- and bracket-notation for nested reference.</summary>
        /// <param name="object">Object to test.</param>
        /// <param name="property">Property to test.</param>
        /// <param name="message">Message to display on error.</param>
        abstract nestedProperty: ``object``: 'T * property: string * ?message: string -> unit
        /// <summary>Asserts that object does not have a property named by property,
        /// which can be a string using dot- and bracket-notation for nested reference.
        /// The property cannot exist on the object nor anywhere in its prototype chain.</summary>
        /// <param name="object">Object to test.</param>
        /// <param name="property">Property to test.</param>
        /// <param name="message">Message to display on error.</param>
        abstract notNestedProperty: ``object``: 'T * property: string * ?message: string -> unit
        /// <summary>Asserts that object has a property named by property with value given by value.
        /// property can use dot- and bracket-notation for nested reference. Uses a strict equality check (===).</summary>
        /// <param name="object">Object to test.</param>
        /// <param name="property">Property to test.</param>
        /// <param name="value">Value to test.</param>
        /// <param name="message">Message to display on error.</param>
        abstract nestedPropertyVal: ``object``: 'T * property: string * value: obj option * ?message: string -> unit
        /// <summary>Asserts that object does not have a property named by property with value given by value.
        /// property can use dot- and bracket-notation for nested reference. Uses a strict equality check (===).</summary>
        /// <param name="object">Object to test.</param>
        /// <param name="property">Property to test.</param>
        /// <param name="value">Value to test.</param>
        /// <param name="message">Message to display on error.</param>
        abstract notNestedPropertyVal: ``object``: 'T * property: string * value: obj option * ?message: string -> unit
        /// <summary>Asserts that object has a property named by property with a value given by value.
        /// property can use dot- and bracket-notation for nested reference. Uses a deep equality check.</summary>
        /// <param name="object">Object to test.</param>
        /// <param name="property">Property to test.</param>
        /// <param name="value">Value to test.</param>
        /// <param name="message">Message to display on error.</param>
        abstract deepNestedPropertyVal: ``object``: 'T * property: string * value: obj option * ?message: string -> unit
        /// <summary>Asserts that object does not have a property named by property with value given by value.
        /// property can use dot- and bracket-notation for nested reference. Uses a deep equality check.</summary>
        /// <param name="object">Object to test.</param>
        /// <param name="property">Property to test.</param>
        /// <param name="value">Value to test.</param>
        /// <param name="message">Message to display on error.</param>
        abstract notDeepNestedPropertyVal: ``object``: 'T * property: string * value: obj option * ?message: string -> unit

    type [<AllowNullLiteral>] Config =
        /// Default: false
        abstract includeStack: bool with get, set
        /// Default: true
        abstract showDiff: bool with get, set
        /// Default: 40
        abstract truncateThreshold: float with get, set
        /// Default: true
        abstract useProxy: bool with get, set
        /// Default: ['then', 'catch', 'inspect', 'toJSON']
        abstract proxyExcludedKeys: ResizeArray<string> with get, set

    type [<AllowNullLiteral>] AssertionError =
        abstract name: string with get, set
        abstract message: string with get, set
        abstract showDiff: bool with get, set
        abstract stack: string with get, set

    type [<AllowNullLiteral>] AssertionErrorStatic =
        [<Emit "new $0($1...)">] abstract Create: message: string * ?_props: obj * ?ssf: Function -> AssertionError

    type [<AllowNullLiteral>] AssertHasAnyKeys =
        [<Emit "$0[$1]{{=$2}}">] abstract Item: key: string -> obj option with get, set

type [<AllowNullLiteral>] Object =
    abstract should: Chai.Assertion with get, set

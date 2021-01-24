// ts2fable 0.0.0
module rec Monaco
open System
open Fable.Core
open Fable.Core.JS
open Browser.Types

type Error = System.Exception
type RegExp = System.Text.RegularExpressions.Regex

let [<Import("*","monaco-editor")>] monaco: Monaco.IExports = jsNative

module Monaco =
    let [<Import("editor","monaco-editor/monaco")>] editor: Editor.IExports = jsNative
    let [<Import("languages","monaco-editor/monaco")>] languages: Languages.IExports = jsNative

    type [<AllowNullLiteral>] IExports =
        /// A helper that allows to emit and listen to typed events
        abstract Emitter: EmitterStatic
        /// A Promise implementation that supports progress and cancelation.
        abstract Promise: PromiseStatic
        abstract CancellationTokenSource: CancellationTokenSourceStatic
        /// <summary>
        /// Uniform Resource Identifier (Uri) <see href="http://tools.ietf.org/html/rfc3986." />
        /// This class is a simple parser which creates the basic component paths
        /// (<see href="http://tools.ietf.org/html/rfc3986#section-3)" /> with minimal validation
        /// and encoding.
        /// 
        ///        <see href="foo://example.com:8042/over/there?name=ferret#nose" />
        ///        \_/   \______________/\_________/ \_________/ \__/
        ///         |           |            |            |        |
        ///      scheme     authority       path        query   fragment
        ///         |   _____________________|__
        ///        / \ /                        \
        ///        urn:example:animal:ferret:nose
        /// </summary>
        abstract Uri: UriStatic
        abstract KeyMod: KeyModStatic
        /// A position in the editor.
        abstract Position: PositionStatic
        /// A range in the editor. (startLineNumber,startColumn) is <= (endLineNumber,endColumn)
        abstract Range: RangeStatic
        /// A selection in the editor.
        /// The selection is a range that has an orientation.
        abstract Selection: SelectionStatic
        abstract Token: TokenStatic

    type [<AllowNullLiteral>] Thenable<'T> =
        /// <summary>Attaches callbacks for the resolution and/or rejection of the Promise.</summary>
        /// <param name="onfulfilled">The callback to execute when the Promise is resolved.</param>
        /// <param name="onrejected">The callback to execute when the Promise is rejected.</param>
        /// <returns>A Promise for the completion of which ever callback is executed.</returns>
        abstract ``then``: ?onfulfilled: ('T -> U2<'TResult, Thenable<'TResult>>) * ?onrejected: (obj option -> U2<'TResult, Thenable<'TResult>>) -> Thenable<'TResult>
        abstract ``then``: ?onfulfilled: ('T -> U2<'TResult, Thenable<'TResult>>) * ?onrejected: (obj option -> unit) -> Thenable<'TResult>

    type [<AllowNullLiteral>] IDisposable =
        abstract dispose: unit -> unit

    type [<AllowNullLiteral>] IEvent<'T> =
        [<Emit "$0($1...)">] abstract Invoke: listener: ('T -> obj option) * ?thisArg: obj -> IDisposable

    /// A helper that allows to emit and listen to typed events
    type [<AllowNullLiteral>] Emitter<'T> =
        abstract ``event``: IEvent<'T>
        abstract fire: ?``event``: 'T -> unit
        abstract dispose: unit -> unit

    /// A helper that allows to emit and listen to typed events
    type [<AllowNullLiteral>] EmitterStatic =
        [<EmitConstructor>] abstract Create: unit -> Emitter<'T>

    type [<RequireQualifiedAccess>] Severity =
        | Ignore = 0
        | Info = 1
        | Warning = 2
        | Error = 3

    /// The value callback to complete a promise
    type [<AllowNullLiteral>] TValueCallback<'T> =
        [<Emit "$0($1...)">] abstract Invoke: value: U2<'T, Thenable<'T>> -> unit

    type [<AllowNullLiteral>] ProgressCallback =
        [<Emit "$0($1...)">] abstract Invoke: progress: obj option -> obj option

    /// A Promise implementation that supports progress and cancelation.
    type [<AllowNullLiteral>] Promise<'V> =
        abstract ``then``: ?success: ('V -> Promise<'U>) * ?error: (obj option -> Promise<'U>) * ?progress: ProgressCallback -> Promise<'U>
        abstract ``then``: ?success: ('V -> Promise<'U>) * ?error: (obj option -> U2<Promise<'U>, 'U>) * ?progress: ProgressCallback -> Promise<'U>
        abstract ``then``: ?success: ('V -> Promise<'U>) * ?error: (obj option -> 'U) * ?progress: ProgressCallback -> Promise<'U>
        abstract ``then``: ?success: ('V -> Promise<'U>) * ?error: (obj option -> unit) * ?progress: ProgressCallback -> Promise<'U>
        abstract ``then``: ?success: ('V -> U2<Promise<'U>, 'U>) * ?error: (obj option -> Promise<'U>) * ?progress: ProgressCallback -> Promise<'U>
        abstract ``then``: ?success: ('V -> U2<Promise<'U>, 'U>) * ?error: (obj option -> U2<Promise<'U>, 'U>) * ?progress: ProgressCallback -> Promise<'U>
        abstract ``then``: ?success: ('V -> U2<Promise<'U>, 'U>) * ?error: (obj option -> 'U) * ?progress: ProgressCallback -> Promise<'U>
        abstract ``then``: ?success: ('V -> U2<Promise<'U>, 'U>) * ?error: (obj option -> unit) * ?progress: ProgressCallback -> Promise<'U>
        abstract ``then``: ?success: ('V -> 'U) * ?error: (obj option -> Promise<'U>) * ?progress: ProgressCallback -> Promise<'U>
        abstract ``then``: ?success: ('V -> 'U) * ?error: (obj option -> U2<Promise<'U>, 'U>) * ?progress: ProgressCallback -> Promise<'U>
        abstract ``then``: ?success: ('V -> 'U) * ?error: (obj option -> 'U) * ?progress: ProgressCallback -> Promise<'U>
        abstract ``then``: ?success: ('V -> 'U) * ?error: (obj option -> unit) * ?progress: ProgressCallback -> Promise<'U>
        abstract ``done``: ?success: ('V -> unit) * ?error: (obj option -> obj option) * ?progress: ProgressCallback -> unit
        abstract cancel: unit -> unit

    /// A Promise implementation that supports progress and cancelation.
    type [<AllowNullLiteral>] PromiseStatic =
        [<EmitConstructor>] abstract Create: init: (TValueCallback<'V> -> (obj option -> unit) -> ProgressCallback -> unit) * ?oncancel: obj -> Promise<'V>
        abstract ``as``: value: obj -> Promise<obj>
        abstract ``as``: value: obj -> Promise<obj>
        abstract ``as``: value: Promise<'ValueType> -> Promise<'ValueType>
        abstract ``as``: value: Thenable<'ValueType> -> Thenable<'ValueType>
        abstract ``as``: value: 'ValueType -> Promise<'ValueType>
        abstract is: value: obj option -> bool
        abstract timeout: delay: float -> Promise<unit>
        abstract join: promises: ResizeArray<Promise<'ValueType>> -> Promise<ResizeArray<'ValueType>>
        abstract join: promises: ResizeArray<Thenable<'ValueType>> -> Thenable<ResizeArray<'ValueType>>
        abstract join: promises: PromiseStaticJoinPromises -> Promise<PromiseStaticJoinPromise<'ValueType>>
        abstract any: promises: ResizeArray<Promise<'ValueType>> -> Promise<PromiseStaticAnyPromise<'ValueType>>
        abstract wrap: value: Thenable<'ValueType> -> Promise<'ValueType>
        abstract wrap: value: 'ValueType -> Promise<'ValueType>
        abstract wrapError: error: Error -> Promise<'ValueType>

    type [<AllowNullLiteral>] PromiseStaticJoinPromises =
        [<EmitIndexer>] abstract Item: n: string -> Promise<'ValueType> with get, set

    type [<AllowNullLiteral>] CancellationTokenSource =
        abstract token: CancellationToken
        abstract cancel: unit -> unit
        abstract dispose: unit -> unit

    type [<AllowNullLiteral>] CancellationTokenSourceStatic =
        [<EmitConstructor>] abstract Create: unit -> CancellationTokenSource

    type [<AllowNullLiteral>] CancellationToken =
        abstract isCancellationRequested: bool
        /// <summary>An event emitted when cancellation is requested</summary>
        abstract onCancellationRequested: IEvent<obj option>

    /// <summary>
    /// Uniform Resource Identifier (Uri) <see href="http://tools.ietf.org/html/rfc3986." />
    /// This class is a simple parser which creates the basic component paths
    /// (<see href="http://tools.ietf.org/html/rfc3986#section-3)" /> with minimal validation
    /// and encoding.
    /// 
    ///        <see href="foo://example.com:8042/over/there?name=ferret#nose" />
    ///        \_/   \______________/\_________/ \_________/ \__/
    ///         |           |            |            |        |
    ///      scheme     authority       path        query   fragment
    ///         |   _____________________|__
    ///        / \ /                        \
    ///        urn:example:animal:ferret:nose
    /// </summary>
    type [<AllowNullLiteral>] Uri =
        /// <summary>
        /// scheme is the 'http' part of '<see href="http://www.msft.com/some/path?query#fragment'." />
        /// The part before the first colon.
        /// </summary>
        abstract scheme: string
        /// <summary>
        /// authority is the 'www.msft.com' part of '<see href="http://www.msft.com/some/path?query#fragment'." />
        /// The part between the first double slashes and the next slash.
        /// </summary>
        abstract authority: string
        /// <summary>path is the '/some/path' part of '<see href="http://www.msft.com/some/path?query#fragment'." /></summary>
        abstract path: string
        /// <summary>query is the 'query' part of '<see href="http://www.msft.com/some/path?query#fragment'." /></summary>
        abstract query: string
        /// <summary>fragment is the 'fragment' part of '<see href="http://www.msft.com/some/path?query#fragment'." /></summary>
        abstract fragment: string
        /// Returns a string representing the corresponding file system path of this Uri.
        /// Will handle UNC paths and normalize windows drive letters to lower-case. Also
        /// uses the platform specific path separator. Will *not* validate the path for
        /// invalid characters and semantics. Will *not* look at the scheme of this Uri.
        abstract fsPath: string
        abstract ``with``: change: UriWithChange -> Uri
        /// <param name="skipEncoding">Do not encode the result, default is <c>false</c></param>
        abstract toString: ?skipEncoding: bool -> string
        abstract toJSON: unit -> obj option

    type [<AllowNullLiteral>] UriWithChange =
        abstract scheme: string option with get, set
        abstract authority: string option with get, set
        abstract path: string option with get, set
        abstract query: string option with get, set
        abstract fragment: string option with get, set

    /// <summary>
    /// Uniform Resource Identifier (Uri) <see href="http://tools.ietf.org/html/rfc3986." />
    /// This class is a simple parser which creates the basic component paths
    /// (<see href="http://tools.ietf.org/html/rfc3986#section-3)" /> with minimal validation
    /// and encoding.
    /// 
    ///        <see href="foo://example.com:8042/over/there?name=ferret#nose" />
    ///        \_/   \______________/\_________/ \_________/ \__/
    ///         |           |            |            |        |
    ///      scheme     authority       path        query   fragment
    ///         |   _____________________|__
    ///        / \ /                        \
    ///        urn:example:animal:ferret:nose
    /// </summary>
    type [<AllowNullLiteral>] UriStatic =
        [<EmitConstructor>] abstract Create: unit -> Uri
        abstract isUri: thing: obj option -> bool
        abstract parse: value: string -> Uri
        abstract file: path: string -> Uri
        abstract from: components: UriStaticFromComponents -> Uri
        abstract revive: data: obj option -> Uri

    type [<AllowNullLiteral>] UriStaticFromComponents =
        abstract scheme: string option with get, set
        abstract authority: string option with get, set
        abstract path: string option with get, set
        abstract query: string option with get, set
        abstract fragment: string option with get, set

    /// <summary>
    /// Virtual Key Codes, the value does not hold any inherent meaning.
    /// Inspired somewhat from <see href="https://msdn.microsoft.com/en-us/library/windows/desktop/dd375731(v=vs.85).aspx" />
    /// But these are "more general", as they should work across browsers & OS`s.
    /// </summary>
    type [<RequireQualifiedAccess>] KeyCode =
        /// Placed first to cover the 0 value of the enum.
        | Unknown = 0
        | Backspace = 1
        | Tab = 2
        | Enter = 3
        | Shift = 4
        | Ctrl = 5
        | Alt = 6
        | PauseBreak = 7
        | CapsLock = 8
        | Escape = 9
        | Space = 10
        | PageUp = 11
        | PageDown = 12
        | End = 13
        | Home = 14
        | LeftArrow = 15
        | UpArrow = 16
        | RightArrow = 17
        | DownArrow = 18
        | Insert = 19
        | Delete = 20
        | KEY_0 = 21
        | KEY_1 = 22
        | KEY_2 = 23
        | KEY_3 = 24
        | KEY_4 = 25
        | KEY_5 = 26
        | KEY_6 = 27
        | KEY_7 = 28
        | KEY_8 = 29
        | KEY_9 = 30
        | KEY_A = 31
        | KEY_B = 32
        | KEY_C = 33
        | KEY_D = 34
        | KEY_E = 35
        | KEY_F = 36
        | KEY_G = 37
        | KEY_H = 38
        | KEY_I = 39
        | KEY_J = 40
        | KEY_K = 41
        | KEY_L = 42
        | KEY_M = 43
        | KEY_N = 44
        | KEY_O = 45
        | KEY_P = 46
        | KEY_Q = 47
        | KEY_R = 48
        | KEY_S = 49
        | KEY_T = 50
        | KEY_U = 51
        | KEY_V = 52
        | KEY_W = 53
        | KEY_X = 54
        | KEY_Y = 55
        | KEY_Z = 56
        | Meta = 57
        | ContextMenu = 58
        | F1 = 59
        | F2 = 60
        | F3 = 61
        | F4 = 62
        | F5 = 63
        | F6 = 64
        | F7 = 65
        | F8 = 66
        | F9 = 67
        | F10 = 68
        | F11 = 69
        | F12 = 70
        | F13 = 71
        | F14 = 72
        | F15 = 73
        | F16 = 74
        | F17 = 75
        | F18 = 76
        | F19 = 77
        | NumLock = 78
        | ScrollLock = 79
        /// Used for miscellaneous characters; it can vary by keyboard.
        /// For the US standard keyboard, the ';:' key
        | US_SEMICOLON = 80
        /// For any country/region, the '+' key
        /// For the US standard keyboard, the '=+' key
        | US_EQUAL = 81
        /// For any country/region, the ',' key
        /// For the US standard keyboard, the ',<' key
        | US_COMMA = 82
        /// For any country/region, the '-' key
        /// For the US standard keyboard, the '-_' key
        | US_MINUS = 83
        /// For any country/region, the '.' key
        /// For the US standard keyboard, the '.>' key
        | US_DOT = 84
        /// Used for miscellaneous characters; it can vary by keyboard.
        /// For the US standard keyboard, the '/?' key
        | US_SLASH = 85
        /// Used for miscellaneous characters; it can vary by keyboard.
        /// For the US standard keyboard, the '`~' key
        | US_BACKTICK = 86
        /// Used for miscellaneous characters; it can vary by keyboard.
        /// For the US standard keyboard, the '[{' key
        | US_OPEN_SQUARE_BRACKET = 87
        /// Used for miscellaneous characters; it can vary by keyboard.
        /// For the US standard keyboard, the '\|' key
        | US_BACKSLASH = 88
        /// Used for miscellaneous characters; it can vary by keyboard.
        /// For the US standard keyboard, the ']}' key
        | US_CLOSE_SQUARE_BRACKET = 89
        /// Used for miscellaneous characters; it can vary by keyboard.
        /// For the US standard keyboard, the ''"' key
        | US_QUOTE = 90
        /// Used for miscellaneous characters; it can vary by keyboard.
        | OEM_8 = 91
        /// Either the angle bracket key or the backslash key on the RT 102-key keyboard.
        | OEM_102 = 92
        | NUMPAD_0 = 93
        | NUMPAD_1 = 94
        | NUMPAD_2 = 95
        | NUMPAD_3 = 96
        | NUMPAD_4 = 97
        | NUMPAD_5 = 98
        | NUMPAD_6 = 99
        | NUMPAD_7 = 100
        | NUMPAD_8 = 101
        | NUMPAD_9 = 102
        | NUMPAD_MULTIPLY = 103
        | NUMPAD_ADD = 104
        | NUMPAD_SEPARATOR = 105
        | NUMPAD_SUBTRACT = 106
        | NUMPAD_DECIMAL = 107
        | NUMPAD_DIVIDE = 108
        /// Cover all key codes when IME is processing input.
        | KEY_IN_COMPOSITION = 109
        | ABNT_C1 = 110
        | ABNT_C2 = 111
        /// Placed last to cover the length of the enum.
        /// Please do not depend on this value!
        | MAX_VALUE = 112

    type [<AllowNullLiteral>] KeyMod =
        interface end

    type [<AllowNullLiteral>] KeyModStatic =
        [<EmitConstructor>] abstract Create: unit -> KeyMod
        abstract CtrlCmd: float
        abstract Shift: float
        abstract Alt: float
        abstract WinCtrl: float
        abstract chord: firstPart: float * secondPart: float -> float

    /// MarkedString can be used to render human readable text. It is either a markdown string
    /// or a code-block that provides a language and a code snippet. Note that
    /// markdown strings will be sanitized - that means html will be escaped.
    type MarkedString =
        U3<string, string, string>

    type [<AllowNullLiteral>] IKeyboardEvent =
        abstract browserEvent: KeyboardEvent
        abstract target: HTMLElement
        abstract ctrlKey: bool
        abstract shiftKey: bool
        abstract altKey: bool
        abstract metaKey: bool
        abstract keyCode: KeyCode
        abstract code: string
        abstract equals: keybinding: float -> bool
        abstract preventDefault: unit -> unit
        abstract stopPropagation: unit -> unit

    type [<AllowNullLiteral>] IMouseEvent =
        abstract browserEvent: MouseEvent
        abstract leftButton: bool
        abstract middleButton: bool
        abstract rightButton: bool
        abstract target: HTMLElement
        abstract detail: float
        abstract posx: float
        abstract posy: float
        abstract ctrlKey: bool
        abstract shiftKey: bool
        abstract altKey: bool
        abstract metaKey: bool
        abstract timestamp: float
        abstract preventDefault: unit -> unit
        abstract stopPropagation: unit -> unit

    type [<AllowNullLiteral>] IScrollEvent =
        abstract scrollTop: float
        abstract scrollLeft: float
        abstract scrollWidth: float
        abstract scrollHeight: float
        abstract scrollTopChanged: bool
        abstract scrollLeftChanged: bool
        abstract scrollWidthChanged: bool
        abstract scrollHeightChanged: bool

    /// A position in the editor. This interface is suitable for serialization.
    type [<AllowNullLiteral>] IPosition =
        /// line number (starts at 1)
        abstract lineNumber: float
        /// column (the first character in a line is between column 1 and column 2)
        abstract column: float

    /// A position in the editor.
    type [<AllowNullLiteral>] Position =
        /// line number (starts at 1)
        abstract lineNumber: float
        /// column (the first character in a line is between column 1 and column 2)
        abstract column: float
        /// Test if this position equals other position
        abstract equals: other: IPosition -> bool
        /// Test if this position is before other position.
        /// If the two positions are equal, the result will be false.
        abstract isBefore: other: IPosition -> bool
        /// Test if this position is before other position.
        /// If the two positions are equal, the result will be true.
        abstract isBeforeOrEqual: other: IPosition -> bool
        /// Clone this position.
        abstract clone: unit -> Position
        /// Convert to a human-readable representation.
        abstract toString: unit -> string

    /// A position in the editor.
    type [<AllowNullLiteral>] PositionStatic =
        [<EmitConstructor>] abstract Create: lineNumber: float * column: float -> Position
        /// <summary>Test if position <c>a</c> equals position <c>b</c></summary>
        abstract equals: a: IPosition * b: IPosition -> bool
        /// <summary>
        /// Test if position <c>a</c> is before position <c>b</c>.
        /// If the two positions are equal, the result will be false.
        /// </summary>
        abstract isBefore: a: IPosition * b: IPosition -> bool
        /// <summary>
        /// Test if position <c>a</c> is before position <c>b</c>.
        /// If the two positions are equal, the result will be true.
        /// </summary>
        abstract isBeforeOrEqual: a: IPosition * b: IPosition -> bool
        /// A function that compares positions, useful for sorting
        abstract compare: a: IPosition * b: IPosition -> float
        /// <summary>Create a <c>Position</c> from an <c>IPosition</c>.</summary>
        abstract lift: pos: IPosition -> Position
        /// <summary>Test if <c>obj</c> is an <c>IPosition</c>.</summary>
        abstract isIPosition: obj: obj option -> bool

    /// A range in the editor. This interface is suitable for serialization.
    type [<AllowNullLiteral>] IRange =
        /// Line number on which the range starts (starts at 1).
        abstract startLineNumber: float
        /// <summary>Column on which the range starts in line <c>startLineNumber</c> (starts at 1).</summary>
        abstract startColumn: float
        /// Line number on which the range ends.
        abstract endLineNumber: float
        /// <summary>Column on which the range ends in line <c>endLineNumber</c>.</summary>
        abstract endColumn: float

    /// A range in the editor. (startLineNumber,startColumn) is <= (endLineNumber,endColumn)
    type [<AllowNullLiteral>] Range =
        /// Line number on which the range starts (starts at 1).
        abstract startLineNumber: float
        /// <summary>Column on which the range starts in line <c>startLineNumber</c> (starts at 1).</summary>
        abstract startColumn: float
        /// Line number on which the range ends.
        abstract endLineNumber: float
        /// <summary>Column on which the range ends in line <c>endLineNumber</c>.</summary>
        abstract endColumn: float
        /// Test if this range is empty.
        abstract isEmpty: unit -> bool
        /// Test if position is in this range. If the position is at the edges, will return true.
        abstract containsPosition: position: IPosition -> bool
        /// Test if range is in this range. If the range is equal to this range, will return true.
        abstract containsRange: range: IRange -> bool
        /// A reunion of the two ranges.
        /// The smallest position will be used as the start point, and the largest one as the end point.
        abstract plusRange: range: IRange -> Range
        /// A intersection of the two ranges.
        abstract intersectRanges: range: IRange -> Range
        /// Test if this range equals other.
        abstract equalsRange: other: IRange -> bool
        /// Return the end position (which will be after or equal to the start position)
        abstract getEndPosition: unit -> Position
        /// Return the start position (which will be before or equal to the end position)
        abstract getStartPosition: unit -> Position
        /// Clone this range.
        abstract cloneRange: unit -> Range
        /// Transform to a user presentable string representation.
        abstract toString: unit -> string
        /// Create a new range using this range's start position, and using endLineNumber and endColumn as the end position.
        abstract setEndPosition: endLineNumber: float * endColumn: float -> Range
        /// Create a new range using this range's end position, and using startLineNumber and startColumn as the start position.
        abstract setStartPosition: startLineNumber: float * startColumn: float -> Range
        /// Create a new empty range using this range's start position.
        abstract collapseToStart: unit -> Range

    /// A range in the editor. (startLineNumber,startColumn) is <= (endLineNumber,endColumn)
    type [<AllowNullLiteral>] RangeStatic =
        [<EmitConstructor>] abstract Create: startLineNumber: float * startColumn: float * endLineNumber: float * endColumn: float -> Range
        /// <summary>Test if <c>range</c> is empty.</summary>
        abstract isEmpty: range: IRange -> bool
        /// <summary>Test if <c>position</c> is in <c>range</c>. If the position is at the edges, will return true.</summary>
        abstract containsPosition: range: IRange * position: IPosition -> bool
        /// <summary>Test if <c>otherRange</c> is in <c>range</c>. If the ranges are equal, will return true.</summary>
        abstract containsRange: range: IRange * otherRange: IRange -> bool
        /// A reunion of the two ranges.
        /// The smallest position will be used as the start point, and the largest one as the end point.
        abstract plusRange: a: IRange * b: IRange -> Range
        /// A intersection of the two ranges.
        abstract intersectRanges: a: IRange * b: IRange -> Range
        /// <summary>Test if range <c>a</c> equals <c>b</c>.</summary>
        abstract equalsRange: a: IRange * b: IRange -> bool
        /// Create a new empty range using this range's start position.
        abstract collapseToStart: range: IRange -> Range
        abstract fromPositions: start: IPosition * ?``end``: IPosition -> Range
        /// <summary>Create a <c>Range</c> from an <c>IRange</c>.</summary>
        abstract lift: range: IRange -> Range
        /// <summary>Test if <c>obj</c> is an <c>IRange</c>.</summary>
        abstract isIRange: obj: obj option -> bool
        /// Test if the two ranges are touching in any way.
        abstract areIntersectingOrTouching: a: IRange * b: IRange -> bool
        /// A function that compares ranges, useful for sorting ranges
        /// It will first compare ranges on the startPosition and then on the endPosition
        abstract compareRangesUsingStarts: a: IRange * b: IRange -> float
        /// A function that compares ranges, useful for sorting ranges
        /// It will first compare ranges on the endPosition and then on the startPosition
        abstract compareRangesUsingEnds: a: IRange * b: IRange -> float
        /// Test if the range spans multiple lines.
        abstract spansMultipleLines: range: IRange -> bool

    /// A selection in the editor.
    /// The selection is a range that has an orientation.
    type [<AllowNullLiteral>] ISelection =
        /// The line number on which the selection has started.
        abstract selectionStartLineNumber: float
        /// <summary>The column on <c>selectionStartLineNumber</c> where the selection has started.</summary>
        abstract selectionStartColumn: float
        /// The line number on which the selection has ended.
        abstract positionLineNumber: float
        /// <summary>The column on <c>positionLineNumber</c> where the selection has ended.</summary>
        abstract positionColumn: float

    /// A selection in the editor.
    /// The selection is a range that has an orientation.
    type [<AllowNullLiteral>] Selection =
        inherit Range
        /// The line number on which the selection has started.
        abstract selectionStartLineNumber: float
        /// <summary>The column on <c>selectionStartLineNumber</c> where the selection has started.</summary>
        abstract selectionStartColumn: float
        /// The line number on which the selection has ended.
        abstract positionLineNumber: float
        /// <summary>The column on <c>positionLineNumber</c> where the selection has ended.</summary>
        abstract positionColumn: float
        /// Clone this selection.
        abstract clone: unit -> Selection
        /// Transform to a human-readable representation.
        abstract toString: unit -> string
        /// Test if equals other selection.
        abstract equalsSelection: other: ISelection -> bool
        /// Get directions (LTR or RTL).
        abstract getDirection: unit -> SelectionDirection
        /// <summary>Create a new selection with a different <c>positionLineNumber</c> and <c>positionColumn</c>.</summary>
        abstract setEndPosition: endLineNumber: float * endColumn: float -> Selection
        /// <summary>Get the position at <c>positionLineNumber</c> and <c>positionColumn</c>.</summary>
        abstract getPosition: unit -> Position
        /// <summary>Create a new selection with a different <c>selectionStartLineNumber</c> and <c>selectionStartColumn</c>.</summary>
        abstract setStartPosition: startLineNumber: float * startColumn: float -> Selection

    /// A selection in the editor.
    /// The selection is a range that has an orientation.
    type [<AllowNullLiteral>] SelectionStatic =
        [<EmitConstructor>] abstract Create: selectionStartLineNumber: float * selectionStartColumn: float * positionLineNumber: float * positionColumn: float -> Selection
        /// Test if the two selections are equal.
        abstract selectionsEqual: a: ISelection * b: ISelection -> bool
        /// <summary>Create a <c>Selection</c> from one or two positions</summary>
        abstract fromPositions: start: IPosition * ?``end``: IPosition -> Selection
        /// <summary>Create a <c>Selection</c> from an <c>ISelection</c>.</summary>
        abstract liftSelection: sel: ISelection -> Selection
        /// <summary><c>a</c> equals <c>b</c>.</summary>
        abstract selectionsArrEqual: a: ResizeArray<ISelection> * b: ResizeArray<ISelection> -> bool
        /// <summary>Test if <c>obj</c> is an <c>ISelection</c>.</summary>
        abstract isISelection: obj: obj option -> bool
        /// Create with a direction.
        abstract createWithDirection: startLineNumber: float * startColumn: float * endLineNumber: float * endColumn: float * direction: SelectionDirection -> Selection

    /// The direction of a selection.
    type [<RequireQualifiedAccess>] SelectionDirection =
        /// The selection starts above where it ends.
        | LTR = 0
        /// The selection starts below where it ends.
        | RTL = 1

    type [<AllowNullLiteral>] Token =
        abstract _tokenBrand: unit with get, set
        abstract offset: float
        abstract ``type``: string
        abstract language: string
        abstract toString: unit -> string

    type [<AllowNullLiteral>] TokenStatic =
        [<EmitConstructor>] abstract Create: offset: float * ``type``: string * language: string -> Token

    module Editor =

        type [<AllowNullLiteral>] IExports =
            /// <summary>
            /// Create a new editor under <c>domElement</c>.
            /// <c>domElement</c> should be empty (not contain other dom nodes).
            /// The editor will read the size of <c>domElement</c>.
            /// </summary>
            abstract create: domElement: HTMLElement * ?options: IEditorConstructionOptions * ?``override``: IEditorOverrideServices -> IStandaloneCodeEditor
            /// <summary>
            /// Emitted when an editor is created.
            /// Creating a diff editor might cause this listener to be invoked with the two editors.
            /// </summary>
            abstract onDidCreateEditor: listener: (ICodeEditor -> unit) -> IDisposable
            /// <summary>
            /// Create a new diff editor under <c>domElement</c>.
            /// <c>domElement</c> should be empty (not contain other dom nodes).
            /// The editor will read the size of <c>domElement</c>.
            /// </summary>
            abstract createDiffEditor: domElement: HTMLElement * ?options: IDiffEditorConstructionOptions * ?``override``: IEditorOverrideServices -> IStandaloneDiffEditor
            abstract createDiffNavigator: diffEditor: IStandaloneDiffEditor * ?opts: IDiffNavigatorOptions -> IDiffNavigator
            /// <summary>
            /// Create a new editor model.
            /// You can specify the language that should be set for this model or let the language be inferred from the <c>uri</c>.
            /// </summary>
            abstract createModel: value: string * ?language: string * ?uri: Uri -> IModel
            /// Change the language for a model.
            abstract setModelLanguage: model: IModel * language: string -> unit
            /// Set the markers for a model.
            abstract setModelMarkers: model: IModel * owner: string * markers: ResizeArray<IMarkerData> -> unit
            /// <summary>Get markers for owner ant/or resource</summary>
            /// <returns>list of markers</returns>
            /// <param name="filter" />
            abstract getModelMarkers: filter: GetModelMarkersFilter -> ResizeArray<IMarker>
            /// <summary>Get the model that has <c>uri</c> if it exists.</summary>
            abstract getModel: uri: Uri -> IModel
            /// Get all the created models.
            abstract getModels: unit -> ResizeArray<IModel>
            /// <summary>Emitted when a model is created.</summary>
            abstract onDidCreateModel: listener: (IModel -> unit) -> IDisposable
            /// <summary>Emitted right before a model is disposed.</summary>
            abstract onWillDisposeModel: listener: (IModel -> unit) -> IDisposable
            /// <summary>Emitted when a different language is set to a model.</summary>
            abstract onDidChangeModelLanguage: listener: (IExportsOnDidChangeModelLanguage -> unit) -> IDisposable
            /// <summary>
            /// Create a new web worker that has model syncing capabilities built in.
            /// Specify an AMD module to load that will <c>create</c> an object that will be proxied.
            /// </summary>
            abstract createWebWorker: opts: IWebWorkerOptions -> MonacoWebWorker<'T>
            /// <summary>Colorize the contents of <c>domNode</c> using attribute <c>data-lang</c>.</summary>
            abstract colorizeElement: domNode: HTMLElement * options: IColorizerElementOptions -> Promise<unit>
            /// <summary>Colorize <c>text</c> using language <c>languageId</c>.</summary>
            abstract colorize: text: string * languageId: string * options: IColorizerOptions -> Promise<string>
            /// Colorize a line in a model.
            abstract colorizeModelLine: model: IModel * lineNumber: float * ?tabSize: float -> string
            /// <summary>Tokenize <c>text</c> using language <c>languageId</c></summary>
            abstract tokenize: text: string * languageId: string -> ResizeArray<ResizeArray<Token>>
            /// Define a new theme.
            abstract defineTheme: themeName: string * themeData: IStandaloneThemeData -> unit
            /// Switches to a theme.
            abstract setTheme: themeName: string -> unit
            abstract TextModelResolvedOptions: TextModelResolvedOptionsStatic
            abstract FindMatch: FindMatchStatic
            abstract EditorType: IExportsEditorType
            /// Internal configuration options (transformed or computed) for the editor.
            abstract InternalEditorOptions: InternalEditorOptionsStatic
            abstract FontInfo: FontInfoStatic
            abstract BareFontInfo: BareFontInfoStatic

        type [<AllowNullLiteral>] GetModelMarkersFilter =
            abstract owner: string option with get, set
            abstract resource: Uri option with get, set
            abstract take: float option with get, set

        type [<AllowNullLiteral>] IDiffNavigator =
            abstract revealFirst: bool with get, set
            abstract canNavigate: unit -> bool
            abstract next: unit -> unit
            abstract previous: unit -> unit
            abstract dispose: unit -> unit

        type [<AllowNullLiteral>] IDiffNavigatorOptions =
            abstract followsCaret: bool option
            abstract ignoreCharChanges: bool option
            abstract alwaysRevealFirst: bool option

        type [<StringEnum>] [<RequireQualifiedAccess>] BuiltinTheme =
            | Vs
            | [<CompiledName "vs-dark">] VsDark
            | [<CompiledName "hc-black">] HcBlack

        type [<AllowNullLiteral>] IStandaloneThemeData =
            abstract ``base``: BuiltinTheme with get, set
            abstract ``inherit``: bool with get, set
            abstract rules: ResizeArray<ITokenThemeRule> with get, set
            abstract colors: IColors with get, set

        type [<AllowNullLiteral>] IColors =
            [<EmitIndexer>] abstract Item: colorId: string -> string with get, set

        type [<AllowNullLiteral>] ITokenThemeRule =
            abstract token: string with get, set
            abstract foreground: string option with get, set
            abstract background: string option with get, set
            abstract fontStyle: string option with get, set

        /// A web worker that can provide a proxy to an arbitrary file.
        type [<AllowNullLiteral>] MonacoWebWorker<'T> =
            /// Terminate the web worker, thus invalidating the returned proxy.
            abstract dispose: unit -> unit
            /// Get a proxy to the arbitrary loaded code.
            abstract getProxy: unit -> Promise<'T>
            /// <summary>
            /// Synchronize (send) the models at <c>resources</c> to the web worker,
            /// making them available in the monaco.worker.getMirrorModels().
            /// </summary>
            abstract withSyncedResources: resources: ResizeArray<Uri> -> Promise<'T>

        type [<AllowNullLiteral>] IWebWorkerOptions =
            /// <summary>
            /// The AMD moduleId to load.
            /// It should export a function <c>create</c> that should return the exported proxy.
            /// </summary>
            abstract moduleId: string with get, set
            /// The data to send over when calling create on the module.
            abstract createData: obj option with get, set
            /// A label to be used to identify the web worker for debugging purposes.
            abstract label: string option with get, set

        /// The options to create an editor.
        type [<AllowNullLiteral>] IEditorConstructionOptions =
            inherit IEditorOptions
            /// The initial model associated with this code editor.
            abstract model: IModel option with get, set
            /// <summary>
            /// The initial value of the auto created model in the editor.
            /// To not create automatically a model, use <c>model: null</c>.
            /// </summary>
            abstract value: string option with get, set
            /// <summary>
            /// The initial language of the auto created model in the editor.
            /// To not create automatically a model, use <c>model: null</c>.
            /// </summary>
            abstract language: string option with get, set
            /// <summary>
            /// Initial theme to be used for rendering.
            /// The current out-of-the-box available themes are: 'vs' (default), 'vs-dark', 'hc-black'.
            /// You can create custom themes via <c>monaco.editor.defineTheme</c>.
            /// To switch a theme, use <c>monaco.editor.setTheme</c>
            /// </summary>
            abstract theme: string option with get, set
            /// <summary>
            /// An URL to open when Ctrl+H (Windows and Linux) or Cmd+H (OSX) is pressed in
            /// the accessibility help dialog in the editor.
            /// 
            /// Defaults to "<see href="https://go.microsoft.com/fwlink/?linkid=852450"" />
            /// </summary>
            abstract accessibilityHelpUrl: string option with get, set

        /// The options to create a diff editor.
        type [<AllowNullLiteral>] IDiffEditorConstructionOptions =
            inherit IDiffEditorOptions
            /// <summary>
            /// Initial theme to be used for rendering.
            /// The current out-of-the-box available themes are: 'vs' (default), 'vs-dark', 'hc-black'.
            /// You can create custom themes via <c>monaco.editor.defineTheme</c>.
            /// To switch a theme, use <c>monaco.editor.setTheme</c>
            /// </summary>
            abstract theme: string option with get, set

        type [<AllowNullLiteral>] IStandaloneCodeEditor =
            inherit ICodeEditor
            abstract addCommand: keybinding: float * handler: ICommandHandler * context: string -> string
            abstract createContextKey: key: string * defaultValue: 'T -> IContextKey<'T>
            abstract addAction: descriptor: IActionDescriptor -> IDisposable

        type [<AllowNullLiteral>] IStandaloneDiffEditor =
            inherit IDiffEditor
            abstract addCommand: keybinding: float * handler: ICommandHandler * context: string -> string
            abstract createContextKey: key: string * defaultValue: 'T -> IContextKey<'T>
            abstract addAction: descriptor: IActionDescriptor -> IDisposable
            /// <summary>Get the <c>original</c> editor.</summary>
            abstract getOriginalEditor: unit -> IStandaloneCodeEditor
            /// <summary>Get the <c>modified</c> editor.</summary>
            abstract getModifiedEditor: unit -> IStandaloneCodeEditor

        type [<AllowNullLiteral>] ICommandHandler =
            [<Emit "$0($1...)">] abstract Invoke: [<ParamArray>] args: obj option[] -> unit

        type [<AllowNullLiteral>] IContextKey<'T> =
            abstract set: value: 'T -> unit
            abstract reset: unit -> unit
            abstract get: unit -> 'T

        type [<AllowNullLiteral>] IEditorOverrideServices =
            [<EmitIndexer>] abstract Item: index: string -> obj option with get, set

        type [<AllowNullLiteral>] IMarker =
            abstract owner: string with get, set
            abstract resource: Uri with get, set
            abstract severity: Severity with get, set
            abstract code: string option with get, set
            abstract message: string with get, set
            abstract source: string option with get, set
            abstract startLineNumber: float with get, set
            abstract startColumn: float with get, set
            abstract endLineNumber: float with get, set
            abstract endColumn: float with get, set

        /// A structure defining a problem/warning/etc.
        type [<AllowNullLiteral>] IMarkerData =
            abstract code: string option with get, set
            abstract severity: Severity with get, set
            abstract message: string with get, set
            abstract source: string option with get, set
            abstract startLineNumber: float with get, set
            abstract startColumn: float with get, set
            abstract endLineNumber: float with get, set
            abstract endColumn: float with get, set

        type [<AllowNullLiteral>] IColorizerOptions =
            abstract tabSize: float option with get, set

        type [<AllowNullLiteral>] IColorizerElementOptions =
            inherit IColorizerOptions
            abstract theme: string option with get, set
            abstract mimeType: string option with get, set

        type [<RequireQualifiedAccess>] ScrollbarVisibility =
            | Auto = 1
            | Hidden = 2
            | Visible = 3

        type [<AllowNullLiteral>] ThemeColor =
            abstract id: string with get, set

        /// Vertical Lane in the overview ruler of the editor.
        type [<RequireQualifiedAccess>] OverviewRulerLane =
            | Left = 1
            | Center = 2
            | Right = 4
            | Full = 7

        /// Options for rendering a model decoration in the overview ruler.
        type [<AllowNullLiteral>] IModelDecorationOverviewRulerOptions =
            /// CSS color to render in the overview ruler.
            /// e.g.: rgba(100, 100, 100, 0.5) or a color from the color registry
            abstract color: U2<string, ThemeColor> with get, set
            /// CSS color to render in the overview ruler.
            /// e.g.: rgba(100, 100, 100, 0.5) or a color from the color registry
            abstract darkColor: U2<string, ThemeColor> with get, set
            /// CSS color to render in the overview ruler.
            /// e.g.: rgba(100, 100, 100, 0.5) or a color from the color registry
            abstract hcColor: U2<string, ThemeColor> option with get, set
            /// The position in the overview ruler.
            abstract position: OverviewRulerLane with get, set

        /// Options for a model decoration.
        type [<AllowNullLiteral>] IModelDecorationOptions =
            /// Customize the growing behavior of the decoration when typing at the edges of the decoration.
            /// Defaults to TrackedRangeStickiness.AlwaysGrowsWhenTypingAtEdges
            abstract stickiness: TrackedRangeStickiness option with get, set
            /// CSS class name describing the decoration.
            abstract className: string option with get, set
            /// Message to be rendered when hovering over the glyph margin decoration.
            abstract glyphMarginHoverMessage: U2<MarkedString, ResizeArray<MarkedString>> option with get, set
            /// Array of MarkedString to render as the decoration message.
            abstract hoverMessage: U2<MarkedString, ResizeArray<MarkedString>> option with get, set
            /// Should the decoration expand to encompass a whole line.
            abstract isWholeLine: bool option with get, set
            /// If set, render this decoration in the overview ruler.
            abstract overviewRuler: IModelDecorationOverviewRulerOptions option with get, set
            /// If set, the decoration will be rendered in the glyph margin with this CSS class name.
            abstract glyphMarginClassName: string option with get, set
            /// If set, the decoration will be rendered in the lines decorations with this CSS class name.
            abstract linesDecorationsClassName: string option with get, set
            /// If set, the decoration will be rendered in the margin (covering its full width) with this CSS class name.
            abstract marginClassName: string option with get, set
            /// <summary>
            /// If set, the decoration will be rendered inline with the text with this CSS class name.
            /// Please use this only for CSS rules that must impact the text. For example, use <c>className</c>
            /// to have a background color decoration.
            /// </summary>
            abstract inlineClassName: string option with get, set
            /// If set, the decoration will be rendered before the text with this CSS class name.
            abstract beforeContentClassName: string option with get, set
            /// If set, the decoration will be rendered after the text with this CSS class name.
            abstract afterContentClassName: string option with get, set

        /// New model decorations.
        type [<AllowNullLiteral>] IModelDeltaDecoration =
            /// Range that this decoration covers.
            abstract range: IRange with get, set
            /// Options associated with this decoration.
            abstract options: IModelDecorationOptions with get, set

        /// A decoration in the model.
        type [<AllowNullLiteral>] IModelDecoration =
            /// Identifier for a decoration.
            abstract id: string
            /// Identifier for a decoration's owener.
            abstract ownerId: float
            /// Range that this decoration covers.
            abstract range: Range
            /// Options associated with this decoration.
            abstract options: IModelDecorationOptions
            /// A flag describing if this is a problem decoration (e.g. warning/error).
            abstract isForValidation: bool

        /// Word inside a model.
        type [<AllowNullLiteral>] IWordAtPosition =
            /// The word.
            abstract word: string
            /// The column where the word starts.
            abstract startColumn: float
            /// The column where the word ends.
            abstract endColumn: float

        /// End of line character preference.
        type [<RequireQualifiedAccess>] EndOfLinePreference =
            /// Use the end of line character identified in the text buffer.
            | TextDefined = 0
            /// Use line feed (\n) as the end of line character.
            | LF = 1
            /// Use carriage return and line feed (\r\n) as the end of line character.
            | CRLF = 2

        /// The default end of line to use when instantiating models.
        type [<RequireQualifiedAccess>] DefaultEndOfLine =
            /// Use line feed (\n) as the end of line character.
            | LF = 1
            /// Use carriage return and line feed (\r\n) as the end of line character.
            | CRLF = 2

        /// End of line character preference.
        type [<RequireQualifiedAccess>] EndOfLineSequence =
            /// Use line feed (\n) as the end of line character.
            | LF = 0
            /// Use carriage return and line feed (\r\n) as the end of line character.
            | CRLF = 1

        /// An identifier for a single edit operation.
        type [<AllowNullLiteral>] ISingleEditOperationIdentifier =
            /// Identifier major
            abstract major: float with get, set
            /// Identifier minor
            abstract minor: float with get, set

        /// A builder and helper for edit operations for a command.
        type [<AllowNullLiteral>] IEditOperationBuilder =
            /// <summary>Add a new edit operation (a replace operation).</summary>
            /// <param name="range">The range to replace (delete). May be empty to represent a simple insert.</param>
            /// <param name="text">The text to replace with. May be null to represent a simple delete.</param>
            abstract addEditOperation: range: Range * text: string -> unit
            /// <summary>
            /// Add a new edit operation (a replace operation).
            /// The inverse edits will be accessible in <c>ICursorStateComputerData.getInverseEditOperations()</c>
            /// </summary>
            /// <param name="range">The range to replace (delete). May be empty to represent a simple insert.</param>
            /// <param name="text">The text to replace with. May be null to represent a simple delete.</param>
            abstract addTrackedEditOperation: range: Range * text: string -> unit
            /// <summary>
            /// Track <c>selection</c> when applying edit operations.
            /// A best effort will be made to not grow/expand the selection.
            /// An empty selection will clamp to a nearby character.
            /// </summary>
            /// <param name="selection">The selection to track.</param>
            /// <param name="trackPreviousOnEmpty">
            /// If set, and the selection is empty, indicates whether the selection
            /// should clamp to the previous or the next character.
            /// </param>
            /// <returns>A unique identifer.</returns>
            abstract trackSelection: selection: Selection * ?trackPreviousOnEmpty: bool -> string

        /// A helper for computing cursor state after a command.
        type [<AllowNullLiteral>] ICursorStateComputerData =
            /// Get the inverse edit operations of the added edit operations.
            abstract getInverseEditOperations: unit -> ResizeArray<IIdentifiedSingleEditOperation>
            /// <summary>Get a previously tracked selection.</summary>
            /// <param name="id">The unique identifier returned by <c>trackSelection</c>.</param>
            /// <returns>The selection.</returns>
            abstract getTrackedSelection: id: string -> Selection

        /// A command that modifies text / cursor state on a model.
        type [<AllowNullLiteral>] ICommand =
            /// <summary>Get the edit operations needed to execute this command.</summary>
            /// <param name="model">The model the command will execute on.</param>
            /// <param name="builder">A helper to collect the needed edit operations and to track selections.</param>
            abstract getEditOperations: model: ITokenizedModel * builder: IEditOperationBuilder -> unit
            /// <summary>Compute the cursor state after the edit operations were applied.</summary>
            /// <param name="model">The model the commad has executed on.</param>
            /// <param name="helper">A helper to get inverse edit operations and to get previously tracked selections.</param>
            /// <returns>The cursor state after the command executed.</returns>
            abstract computeCursorState: model: ITokenizedModel * helper: ICursorStateComputerData -> Selection

        /// <summary>
        /// A single edit operation, that acts as a simple replace.
        /// i.e. Replace text at <c>range</c> with <c>text</c> in model.
        /// </summary>
        type [<AllowNullLiteral>] ISingleEditOperation =
            /// The range to replace. This can be empty to emulate a simple insert.
            abstract range: IRange with get, set
            /// The text to replace with. This can be null to emulate a simple delete.
            abstract text: string with get, set
            /// <summary>
            /// This indicates that this operation has "insert" semantics.
            /// i.e. forceMoveMarkers = true => if <c>range</c> is collapsed, all markers at the position will be moved.
            /// </summary>
            abstract forceMoveMarkers: bool option with get, set

        /// A single edit operation, that has an identifier.
        type [<AllowNullLiteral>] IIdentifiedSingleEditOperation =
            /// An identifier associated with this single edit operation.
            abstract identifier: ISingleEditOperationIdentifier with get, set
            /// The range to replace. This can be empty to emulate a simple insert.
            abstract range: Range with get, set
            /// The text to replace with. This can be null to emulate a simple delete.
            abstract text: string with get, set
            /// <summary>
            /// This indicates that this operation has "insert" semantics.
            /// i.e. forceMoveMarkers = true => if <c>range</c> is collapsed, all markers at the position will be moved.
            /// </summary>
            abstract forceMoveMarkers: bool with get, set
            /// <summary>
            /// This indicates that this operation is inserting automatic whitespace
            /// that can be removed on next model edit operation if <c>config.trimAutoWhitespace</c> is true.
            /// </summary>
            abstract isAutoWhitespaceEdit: bool option with get, set

        /// A callback that can compute the cursor state after applying a series of edit operations.
        type [<AllowNullLiteral>] ICursorStateComputer =
            /// A callback that can compute the resulting cursors state after some edit operations have been executed.
            [<Emit "$0($1...)">] abstract Invoke: inverseEditOperations: ResizeArray<IIdentifiedSingleEditOperation> -> ResizeArray<Selection>

        type [<AllowNullLiteral>] TextModelResolvedOptions =
            abstract _textModelResolvedOptionsBrand: unit with get, set
            abstract tabSize: float
            abstract insertSpaces: bool
            abstract defaultEOL: DefaultEndOfLine
            abstract trimAutoWhitespace: bool

        type [<AllowNullLiteral>] TextModelResolvedOptionsStatic =
            [<EmitConstructor>] abstract Create: unit -> TextModelResolvedOptions

        type [<AllowNullLiteral>] ITextModelUpdateOptions =
            abstract tabSize: float option with get, set
            abstract insertSpaces: bool option with get, set
            abstract trimAutoWhitespace: bool option with get, set

        /// A textual read-only model.
        type [<AllowNullLiteral>] ITextModel =
            /// Get the resolved options for this model.
            abstract getOptions: unit -> TextModelResolvedOptions
            /// Get the current version id of the model.
            /// Anytime a change happens to the model (even undo/redo),
            /// the version id is incremented.
            abstract getVersionId: unit -> float
            /// Get the alternative version id of the model.
            /// This alternative version id is not always incremented,
            /// it will return the same values in the case of undo-redo.
            abstract getAlternativeVersionId: unit -> float
            /// Replace the entire text buffer value contained in this model.
            abstract setValue: newValue: string -> unit
            /// <summary>Get the text stored in this model.</summary>
            /// <param name="eol">The end of line character preference. Defaults to <c>EndOfLinePreference.TextDefined</c>.</param>
            /// <param name="preserverBOM">Preserve a BOM character if it was detected when the model was constructed.</param>
            /// <returns>The text.</returns>
            abstract getValue: ?eol: EndOfLinePreference * ?preserveBOM: bool -> string
            /// Get the length of the text stored in this model.
            abstract getValueLength: ?eol: EndOfLinePreference * ?preserveBOM: bool -> float
            /// <summary>Get the text in a certain range.</summary>
            /// <param name="range">The range describing what text to get.</param>
            /// <param name="eol">The end of line character preference. This will only be used for multiline ranges. Defaults to <c>EndOfLinePreference.TextDefined</c>.</param>
            /// <returns>The text.</returns>
            abstract getValueInRange: range: IRange * ?eol: EndOfLinePreference -> string
            /// <summary>Get the length of text in a certain range.</summary>
            /// <param name="range">The range describing what text length to get.</param>
            /// <returns>The text length.</returns>
            abstract getValueLengthInRange: range: IRange -> float
            /// Get the number of lines in the model.
            abstract getLineCount: unit -> float
            /// Get the text for a certain line.
            abstract getLineContent: lineNumber: float -> string
            /// Get the text for all lines.
            abstract getLinesContent: unit -> ResizeArray<string>
            /// <summary>Get the end of line sequence predominantly used in the text buffer.</summary>
            /// <returns>EOL char sequence (e.g.: '\n' or '\r\n').</returns>
            abstract getEOL: unit -> string
            /// Change the end of line sequence used in the text buffer.
            abstract setEOL: eol: EndOfLineSequence -> unit
            /// <summary>Get the minimum legal column for line at <c>lineNumber</c></summary>
            abstract getLineMinColumn: lineNumber: float -> float
            /// <summary>Get the maximum legal column for line at <c>lineNumber</c></summary>
            abstract getLineMaxColumn: lineNumber: float -> float
            /// <summary>
            /// Returns the column before the first non whitespace character for line at <c>lineNumber</c>.
            /// Returns 0 if line is empty or contains only whitespace.
            /// </summary>
            abstract getLineFirstNonWhitespaceColumn: lineNumber: float -> float
            /// <summary>
            /// Returns the column after the last non whitespace character for line at <c>lineNumber</c>.
            /// Returns 0 if line is empty or contains only whitespace.
            /// </summary>
            abstract getLineLastNonWhitespaceColumn: lineNumber: float -> float
            /// Create a valid position,
            abstract validatePosition: position: IPosition -> Position
            /// Advances the given position by the given offest (negative offsets are also accepted)
            /// and returns it as a new valid position.
            /// 
            /// If the offset and position are such that their combination goes beyond the beginning or
            /// end of the model, throws an exception.
            /// 
            /// If the ofsset is such that the new position would be in the middle of a multi-byte
            /// line terminator, throws an exception.
            abstract modifyPosition: position: IPosition * offset: float -> Position
            /// Create a valid range.
            abstract validateRange: range: IRange -> Range
            /// <summary>
            /// Converts the position to a zero-based offset.
            /// 
            /// The position will be <see cref="TextDocument.validatePosition">adjusted</see>.
            /// </summary>
            /// <param name="position">A position.</param>
            /// <returns>A valid zero-based offset.</returns>
            abstract getOffsetAt: position: IPosition -> float
            /// <summary>Converts a zero-based offset to a position.</summary>
            /// <param name="offset">A zero-based offset.</param>
            /// <returns>A valid <see cref="Position">position</see>.</returns>
            abstract getPositionAt: offset: float -> Position
            /// Get a range covering the entire model
            abstract getFullModelRange: unit -> Range
            /// Returns iff the model was disposed or not.
            abstract isDisposed: unit -> bool
            /// <summary>Search the model.</summary>
            /// <param name="searchString">The string used to search. If it is a regular expression, set <c>isRegex</c> to true.</param>
            /// <param name="searchOnlyEditableRange">Limit the searching to only search inside the editable range of the model.</param>
            /// <param name="isRegex">Used to indicate that <c>searchString</c> is a regular expression.</param>
            /// <param name="matchCase">Force the matching to match lower/upper case exactly.</param>
            /// <param name="wordSeparators">Force the matching to match entire words only. Pass null otherwise.</param>
            /// <param name="captureMatches">The result will contain the captured groups.</param>
            /// <param name="limitResultCount">Limit the number of results</param>
            /// <returns>The ranges where the matches are. It is empty if not matches have been found.</returns>
            abstract findMatches: searchString: string * searchOnlyEditableRange: bool * isRegex: bool * matchCase: bool * wordSeparators: string * captureMatches: bool * ?limitResultCount: float -> ResizeArray<FindMatch>
            /// <summary>Search the model.</summary>
            /// <param name="searchString">The string used to search. If it is a regular expression, set <c>isRegex</c> to true.</param>
            /// <param name="searchScope">Limit the searching to only search inside this range.</param>
            /// <param name="isRegex">Used to indicate that <c>searchString</c> is a regular expression.</param>
            /// <param name="matchCase">Force the matching to match lower/upper case exactly.</param>
            /// <param name="wordSeparators">Force the matching to match entire words only. Pass null otherwise.</param>
            /// <param name="captureMatches">The result will contain the captured groups.</param>
            /// <param name="limitResultCount">Limit the number of results</param>
            /// <returns>The ranges where the matches are. It is empty if no matches have been found.</returns>
            abstract findMatches: searchString: string * searchScope: IRange * isRegex: bool * matchCase: bool * wordSeparators: string * captureMatches: bool * ?limitResultCount: float -> ResizeArray<FindMatch>
            /// <summary>Search the model for the next match. Loops to the beginning of the model if needed.</summary>
            /// <param name="searchString">The string used to search. If it is a regular expression, set <c>isRegex</c> to true.</param>
            /// <param name="searchStart">Start the searching at the specified position.</param>
            /// <param name="isRegex">Used to indicate that <c>searchString</c> is a regular expression.</param>
            /// <param name="matchCase">Force the matching to match lower/upper case exactly.</param>
            /// <param name="wordSeparators">Force the matching to match entire words only. Pass null otherwise.</param>
            /// <param name="captureMatches">The result will contain the captured groups.</param>
            /// <returns>The range where the next match is. It is null if no next match has been found.</returns>
            abstract findNextMatch: searchString: string * searchStart: IPosition * isRegex: bool * matchCase: bool * wordSeparators: string * captureMatches: bool -> FindMatch
            /// <summary>Search the model for the previous match. Loops to the end of the model if needed.</summary>
            /// <param name="searchString">The string used to search. If it is a regular expression, set <c>isRegex</c> to true.</param>
            /// <param name="searchStart">Start the searching at the specified position.</param>
            /// <param name="isRegex">Used to indicate that <c>searchString</c> is a regular expression.</param>
            /// <param name="matchCase">Force the matching to match lower/upper case exactly.</param>
            /// <param name="wordSeparators">Force the matching to match entire words only. Pass null otherwise.</param>
            /// <param name="captureMatches">The result will contain the captured groups.</param>
            /// <returns>The range where the previous match is. It is null if no previous match has been found.</returns>
            abstract findPreviousMatch: searchString: string * searchStart: IPosition * isRegex: bool * matchCase: bool * wordSeparators: string * captureMatches: bool -> FindMatch

        type [<AllowNullLiteral>] FindMatch =
            abstract _findMatchBrand: unit with get, set
            abstract range: Range
            abstract matches: ResizeArray<string>

        type [<AllowNullLiteral>] FindMatchStatic =
            [<EmitConstructor>] abstract Create: unit -> FindMatch

        type [<AllowNullLiteral>] IReadOnlyModel =
            inherit ITextModel
            /// Gets the resource associated with this editor model.
            abstract uri: Uri
            /// Get the language associated with this model.
            abstract getModeId: unit -> string
            /// <summary>Get the word under or besides <c>position</c>.</summary>
            /// <param name="position">The position to look for a word.</param>
            /// <param name="skipSyntaxTokens">Ignore syntax tokens, as identified by the mode.</param>
            /// <returns>The word under or besides <c>position</c>. Might be null.</returns>
            abstract getWordAtPosition: position: IPosition -> IWordAtPosition
            /// <summary>Get the word under or besides <c>position</c> trimmed to <c>position</c>.column</summary>
            /// <param name="position">The position to look for a word.</param>
            /// <param name="skipSyntaxTokens">Ignore syntax tokens, as identified by the mode.</param>
            /// <returns>The word under or besides <c>position</c>. Will never be null.</returns>
            abstract getWordUntilPosition: position: IPosition -> IWordAtPosition

        /// A model that is tokenized.
        type [<AllowNullLiteral>] ITokenizedModel =
            inherit ITextModel
            /// Get the language associated with this model.
            abstract getModeId: unit -> string
            /// <summary>Get the word under or besides <c>position</c>.</summary>
            /// <param name="position">The position to look for a word.</param>
            /// <param name="skipSyntaxTokens">Ignore syntax tokens, as identified by the mode.</param>
            /// <returns>The word under or besides <c>position</c>. Might be null.</returns>
            abstract getWordAtPosition: position: IPosition -> IWordAtPosition
            /// <summary>Get the word under or besides <c>position</c> trimmed to <c>position</c>.column</summary>
            /// <param name="position">The position to look for a word.</param>
            /// <param name="skipSyntaxTokens">Ignore syntax tokens, as identified by the mode.</param>
            /// <returns>The word under or besides <c>position</c>. Will never be null.</returns>
            abstract getWordUntilPosition: position: IPosition -> IWordAtPosition

        /// A model that can track markers.
        type [<AllowNullLiteral>] ITextModelWithMarkers =
            inherit ITextModel

        /// <summary>
        /// Describes the behavior of decorations when typing/editing near their edges.
        /// Note: Please do not edit the values, as they very carefully match <c>DecorationRangeBehavior</c>
        /// </summary>
        type [<RequireQualifiedAccess>] TrackedRangeStickiness =
            | AlwaysGrowsWhenTypingAtEdges = 0
            | NeverGrowsWhenTypingAtEdges = 1
            | GrowsOnlyWhenTypingBefore = 2
            | GrowsOnlyWhenTypingAfter = 3

        /// A model that can have decorations.
        type [<AllowNullLiteral>] ITextModelWithDecorations =
            /// <summary>
            /// Perform a minimum ammount of operations, in order to transform the decorations
            /// identified by <c>oldDecorations</c> to the decorations described by <c>newDecorations</c>
            /// and returns the new identifiers associated with the resulting decorations.
            /// </summary>
            /// <param name="oldDecorations">Array containing previous decorations identifiers.</param>
            /// <param name="newDecorations">Array describing what decorations should result after the call.</param>
            /// <param name="ownerId">Identifies the editor id in which these decorations should appear. If no <c>ownerId</c> is provided, the decorations will appear in all editors that attach this model.</param>
            /// <returns>An array containing the new decorations identifiers.</returns>
            abstract deltaDecorations: oldDecorations: ResizeArray<string> * newDecorations: ResizeArray<IModelDeltaDecoration> * ?ownerId: float -> ResizeArray<string>
            /// <summary>Get the options associated with a decoration.</summary>
            /// <param name="id">The decoration id.</param>
            /// <returns>The decoration options or null if the decoration was not found.</returns>
            abstract getDecorationOptions: id: string -> IModelDecorationOptions
            /// <summary>Get the range associated with a decoration.</summary>
            /// <param name="id">The decoration id.</param>
            /// <returns>The decoration range or null if the decoration was not found.</returns>
            abstract getDecorationRange: id: string -> Range
            /// <summary>Gets all the decorations for the line <c>lineNumber</c> as an array.</summary>
            /// <param name="lineNumber">The line number</param>
            /// <param name="ownerId">If set, it will ignore decorations belonging to other owners.</param>
            /// <param name="filterOutValidation">If set, it will ignore decorations specific to validation (i.e. warnings, errors).</param>
            /// <returns>An array with the decorations</returns>
            abstract getLineDecorations: lineNumber: float * ?ownerId: float * ?filterOutValidation: bool -> ResizeArray<IModelDecoration>
            /// <summary>Gets all the decorations for the lines between <c>startLineNumber</c> and <c>endLineNumber</c> as an array.</summary>
            /// <param name="startLineNumber">The start line number</param>
            /// <param name="endLineNumber">The end line number</param>
            /// <param name="ownerId">If set, it will ignore decorations belonging to other owners.</param>
            /// <param name="filterOutValidation">If set, it will ignore decorations specific to validation (i.e. warnings, errors).</param>
            /// <returns>An array with the decorations</returns>
            abstract getLinesDecorations: startLineNumber: float * endLineNumber: float * ?ownerId: float * ?filterOutValidation: bool -> ResizeArray<IModelDecoration>
            /// <summary>
            /// Gets all the deocorations in a range as an array. Only <c>startLineNumber</c> and <c>endLineNumber</c> from <c>range</c> are used for filtering.
            /// So for now it returns all the decorations on the same line as <c>range</c>.
            /// </summary>
            /// <param name="range">The range to search in</param>
            /// <param name="ownerId">If set, it will ignore decorations belonging to other owners.</param>
            /// <param name="filterOutValidation">If set, it will ignore decorations specific to validation (i.e. warnings, errors).</param>
            /// <returns>An array with the decorations</returns>
            abstract getDecorationsInRange: range: IRange * ?ownerId: float * ?filterOutValidation: bool -> ResizeArray<IModelDecoration>
            /// <summary>Gets all the decorations as an array.</summary>
            /// <param name="ownerId">If set, it will ignore decorations belonging to other owners.</param>
            /// <param name="filterOutValidation">If set, it will ignore decorations specific to validation (i.e. warnings, errors).</param>
            abstract getAllDecorations: ?ownerId: float * ?filterOutValidation: bool -> ResizeArray<IModelDecoration>

        /// An editable text model.
        type [<AllowNullLiteral>] IEditableTextModel =
            inherit ITextModelWithMarkers
            /// Normalize a string containing whitespace according to indentation rules (converts to spaces or to tabs).
            abstract normalizeIndentation: str: string -> string
            /// Get what is considered to be one indent (e.g. a tab character or 4 spaces, etc.).
            abstract getOneIndent: unit -> string
            /// Change the options of this model.
            abstract updateOptions: newOpts: ITextModelUpdateOptions -> unit
            /// Detect the indentation options for this model from its content.
            abstract detectIndentation: defaultInsertSpaces: bool * defaultTabSize: float -> unit
            /// <summary>
            /// Push a stack element onto the undo stack. This acts as an undo/redo point.
            /// The idea is to use <c>pushEditOperations</c> to edit the model and then to
            /// <c>pushStackElement</c> to create an undo/redo stop point.
            /// </summary>
            abstract pushStackElement: unit -> unit
            /// <summary>
            /// Push edit operations, basically editing the model. This is the preferred way
            /// of editing the model. The edit operations will land on the undo stack.
            /// </summary>
            /// <param name="beforeCursorState">The cursor state before the edit operaions. This cursor state will be returned when <c>undo</c> or <c>redo</c> are invoked.</param>
            /// <param name="editOperations">The edit operations.</param>
            /// <param name="cursorStateComputer">A callback that can compute the resulting cursors state after the edit operations have been executed.</param>
            /// <returns>The cursor state returned by the <c>cursorStateComputer</c>.</returns>
            abstract pushEditOperations: beforeCursorState: ResizeArray<Selection> * editOperations: ResizeArray<IIdentifiedSingleEditOperation> * cursorStateComputer: ICursorStateComputer -> ResizeArray<Selection>
            /// <summary>
            /// Edit the model without adding the edits to the undo stack.
            /// This can have dire consequences on the undo stack! See @pushEditOperations for the preferred way.
            /// </summary>
            /// <param name="operations">The edit operations.</param>
            /// <returns>The inverse edit operations, that, when applied, will bring the model back to the previous state.</returns>
            abstract applyEdits: operations: ResizeArray<IIdentifiedSingleEditOperation> -> ResizeArray<IIdentifiedSingleEditOperation>

        /// A model.
        type [<AllowNullLiteral>] IModel =
            inherit IReadOnlyModel
            inherit IEditableTextModel
            inherit ITextModelWithMarkers
            inherit ITokenizedModel
            inherit ITextModelWithDecorations
            /// <summary>An event emitted when the contents of the model have changed.</summary>
            abstract onDidChangeContent: listener: (IModelContentChangedEvent -> unit) -> IDisposable
            /// <summary>An event emitted when decorations of the model have changed.</summary>
            abstract onDidChangeDecorations: listener: (IModelDecorationsChangedEvent -> unit) -> IDisposable
            /// <summary>An event emitted when the model options have changed.</summary>
            abstract onDidChangeOptions: listener: (IModelOptionsChangedEvent -> unit) -> IDisposable
            /// <summary>An event emitted when the language associated with the model has changed.</summary>
            abstract onDidChangeLanguage: listener: (IModelLanguageChangedEvent -> unit) -> IDisposable
            /// <summary>An event emitted right before disposing the model.</summary>
            abstract onWillDispose: listener: (unit -> unit) -> IDisposable
            /// A unique identifier associated with this model.
            abstract id: string
            /// Destroy this model. This will unbind the model from the mode
            /// and make all necessary clean-up to release this object to the GC.
            abstract dispose: unit -> unit

        /// A model for the diff editor.
        type [<AllowNullLiteral>] IDiffEditorModel =
            /// Original model.
            abstract original: IModel with get, set
            /// Modified model.
            abstract modified: IModel with get, set

        /// <summary>An event describing that an editor has had its model reset (i.e. <c>editor.setModel()</c>).</summary>
        type [<AllowNullLiteral>] IModelChangedEvent =
            /// <summary>The <c>uri</c> of the previous model or null.</summary>
            abstract oldModelUrl: Uri
            /// <summary>The <c>uri</c> of the new model or null.</summary>
            abstract newModelUrl: Uri

        type [<AllowNullLiteral>] IDimension =
            abstract width: float with get, set
            abstract height: float with get, set

        /// A change
        type [<AllowNullLiteral>] IChange =
            abstract originalStartLineNumber: float
            abstract originalEndLineNumber: float
            abstract modifiedStartLineNumber: float
            abstract modifiedEndLineNumber: float

        /// A character level change.
        type [<AllowNullLiteral>] ICharChange =
            inherit IChange
            abstract originalStartColumn: float
            abstract originalEndColumn: float
            abstract modifiedStartColumn: float
            abstract modifiedEndColumn: float

        /// A line change
        type [<AllowNullLiteral>] ILineChange =
            inherit IChange
            abstract charChanges: ResizeArray<ICharChange>

        /// Information about a line in the diff editor
        type [<AllowNullLiteral>] IDiffLineInformation =
            abstract equivalentLineNumber: float

        type [<AllowNullLiteral>] INewScrollPosition =
            abstract scrollLeft: float option with get, set
            abstract scrollTop: float option with get, set

        /// Description of an action contribution
        type [<AllowNullLiteral>] IActionDescriptor =
            /// An unique identifier of the contributed action.
            abstract id: string with get, set
            /// A label of the action that will be presented to the user.
            abstract label: string with get, set
            /// Precondition rule.
            abstract precondition: string option with get, set
            /// An array of keybindings for the action.
            abstract keybindings: ResizeArray<float> option with get, set
            /// The keybinding rule (condition on top of precondition).
            abstract keybindingContext: string option with get, set
            /// Control if the action should show up in the context menu and where.
            /// The context menu of the editor has these default:
            ///    navigation - The navigation group comes first in all cases.
            ///    1_modification - This group comes next and contains commands that modify your code.
            ///    9_cutcopypaste - The last default group with the basic editing commands.
            /// You can also create your own group.
            /// Defaults to null (don't show in context menu).
            abstract contextMenuGroupId: string option with get, set
            /// Control the order in the context menu group.
            abstract contextMenuOrder: float option with get, set
            /// <summary>Method that will be executed when the action is triggered.</summary>
            /// <param name="editor">The editor instance is passed in as a convinience</param>
            abstract run: editor: ICommonCodeEditor -> U2<unit, Promise<unit>>

        type [<AllowNullLiteral>] IEditorAction =
            abstract id: string
            abstract label: string
            abstract alias: string
            abstract isSupported: unit -> bool
            abstract run: unit -> Promise<unit>

        type IEditorModel =
            U2<IModel, IDiffEditorModel>

        /// A (serializable) state of the cursors.
        type [<AllowNullLiteral>] ICursorState =
            abstract inSelectionMode: bool with get, set
            abstract selectionStart: IPosition with get, set
            abstract position: IPosition with get, set

        /// A (serializable) state of the view.
        type [<AllowNullLiteral>] IViewState =
            abstract scrollTop: float with get, set
            abstract scrollTopWithoutViewZones: float with get, set
            abstract scrollLeft: float with get, set

        /// A (serializable) state of the code editor.
        type [<AllowNullLiteral>] ICodeEditorViewState =
            abstract cursorState: ResizeArray<ICursorState> with get, set
            abstract viewState: IViewState with get, set
            abstract contributionsState: ICodeEditorViewStateContributionsState with get, set

        /// (Serializable) View state for the diff editor.
        type [<AllowNullLiteral>] IDiffEditorViewState =
            abstract original: ICodeEditorViewState with get, set
            abstract modified: ICodeEditorViewState with get, set

        /// An editor view state.
        type IEditorViewState =
            U2<ICodeEditorViewState, IDiffEditorViewState>

        /// An editor.
        type [<AllowNullLiteral>] IEditor =
            /// <summary>An event emitted when the editor has been disposed.</summary>
            abstract onDidDispose: listener: (unit -> unit) -> IDisposable
            /// Dispose the editor.
            abstract dispose: unit -> unit
            /// Get a unique id for this editor instance.
            abstract getId: unit -> string
            /// <summary>
            /// Get the editor type. Please see <c>EditorType</c>.
            /// This is to avoid an instanceof check
            /// </summary>
            abstract getEditorType: unit -> string
            /// Update the editor's options after the editor has been created.
            abstract updateOptions: newOptions: IEditorOptions -> unit
            /// Instructs the editor to remeasure its container. This method should
            /// be called when the container of the editor gets resized.
            abstract layout: ?dimension: IDimension -> unit
            /// Brings browser focus to the editor text
            abstract focus: unit -> unit
            /// Returns true if this editor has keyboard focus (e.g. cursor is blinking).
            abstract isFocused: unit -> bool
            /// Returns all actions associated with this editor.
            abstract getActions: unit -> ResizeArray<IEditorAction>
            /// Returns all actions associated with this editor.
            abstract getSupportedActions: unit -> ResizeArray<IEditorAction>
            /// Saves current view state of the editor in a serializable object.
            abstract saveViewState: unit -> IEditorViewState
            /// <summary>Restores the view state of the editor from a serializable object generated by <c>saveViewState</c>.</summary>
            abstract restoreViewState: state: IEditorViewState -> unit
            /// Given a position, returns a column number that takes tab-widths into account.
            abstract getVisibleColumnFromPosition: position: IPosition -> float
            /// Returns the primary position of the cursor.
            abstract getPosition: unit -> Position
            /// <summary>Set the primary position of the cursor. This will remove any secondary cursors.</summary>
            /// <param name="position">New primary cursor's position</param>
            abstract setPosition: position: IPosition -> unit
            /// Scroll vertically as necessary and reveal a line.
            abstract revealLine: lineNumber: float -> unit
            /// Scroll vertically as necessary and reveal a line centered vertically.
            abstract revealLineInCenter: lineNumber: float -> unit
            /// Scroll vertically as necessary and reveal a line centered vertically only if it lies outside the viewport.
            abstract revealLineInCenterIfOutsideViewport: lineNumber: float -> unit
            /// Scroll vertically or horizontally as necessary and reveal a position.
            abstract revealPosition: position: IPosition * ?revealVerticalInCenter: bool * ?revealHorizontal: bool -> unit
            /// Scroll vertically or horizontally as necessary and reveal a position centered vertically.
            abstract revealPositionInCenter: position: IPosition -> unit
            /// Scroll vertically or horizontally as necessary and reveal a position centered vertically only if it lies outside the viewport.
            abstract revealPositionInCenterIfOutsideViewport: position: IPosition -> unit
            /// Returns the primary selection of the editor.
            abstract getSelection: unit -> Selection
            /// Returns all the selections of the editor.
            abstract getSelections: unit -> ResizeArray<Selection>
            /// <summary>Set the primary selection of the editor. This will remove any secondary cursors.</summary>
            /// <param name="selection">The new selection</param>
            abstract setSelection: selection: IRange -> unit
            /// <summary>Set the primary selection of the editor. This will remove any secondary cursors.</summary>
            /// <param name="selection">The new selection</param>
            abstract setSelection: selection: Range -> unit
            /// <summary>Set the primary selection of the editor. This will remove any secondary cursors.</summary>
            /// <param name="selection">The new selection</param>
            abstract setSelection: selection: ISelection -> unit
            /// <summary>Set the primary selection of the editor. This will remove any secondary cursors.</summary>
            /// <param name="selection">The new selection</param>
            abstract setSelection: selection: Selection -> unit
            /// Set the selections for all the cursors of the editor.
            /// Cursors will be removed or added, as necessary.
            abstract setSelections: selections: ResizeArray<ISelection> -> unit
            /// Scroll vertically as necessary and reveal lines.
            abstract revealLines: startLineNumber: float * endLineNumber: float -> unit
            /// Scroll vertically as necessary and reveal lines centered vertically.
            abstract revealLinesInCenter: lineNumber: float * endLineNumber: float -> unit
            /// Scroll vertically as necessary and reveal lines centered vertically only if it lies outside the viewport.
            abstract revealLinesInCenterIfOutsideViewport: lineNumber: float * endLineNumber: float -> unit
            /// Scroll vertically or horizontally as necessary and reveal a range.
            abstract revealRange: range: IRange -> unit
            /// Scroll vertically or horizontally as necessary and reveal a range centered vertically.
            abstract revealRangeInCenter: range: IRange -> unit
            /// Scroll vertically or horizontally as necessary and reveal a range at the top of the viewport.
            abstract revealRangeAtTop: range: IRange -> unit
            /// Scroll vertically or horizontally as necessary and reveal a range centered vertically only if it lies outside the viewport.
            abstract revealRangeInCenterIfOutsideViewport: range: IRange -> unit
            /// <summary>Directly trigger a handler or an editor action.</summary>
            /// <param name="source">The source of the call.</param>
            /// <param name="handlerId">The id of the handler or the id of a contribution.</param>
            /// <param name="payload">Extra data to be sent to the handler.</param>
            abstract trigger: source: string * handlerId: string * payload: obj option -> unit
            /// Gets the current model attached to this editor.
            abstract getModel: unit -> IEditorModel
            /// Sets the current model attached to this editor.
            /// If the previous model was created by the editor via the value key in the options
            /// literal object, it will be destroyed. Otherwise, if the previous model was set
            /// via setModel, or the model key in the options literal object, the previous model
            /// will not be destroyed.
            /// It is safe to call setModel(null) to simply detach the current model from the editor.
            abstract setModel: model: IEditorModel -> unit

        /// An editor contribution that gets created every time a new editor gets created and gets disposed when the editor gets disposed.
        type [<AllowNullLiteral>] IEditorContribution =
            /// Get a unique identifier for this contribution.
            abstract getId: unit -> string
            /// Dispose this contribution.
            abstract dispose: unit -> unit
            /// Store view state.
            abstract saveViewState: unit -> obj option
            /// Restore view state.
            abstract restoreViewState: state: obj option -> unit

        type [<AllowNullLiteral>] ICommonCodeEditor =
            inherit IEditor
            /// <summary>An event emitted when the content of the current model has changed.</summary>
            abstract onDidChangeModelContent: listener: (IModelContentChangedEvent -> unit) -> IDisposable
            /// <summary>An event emitted when the language of the current model has changed.</summary>
            abstract onDidChangeModelLanguage: listener: (IModelLanguageChangedEvent -> unit) -> IDisposable
            /// <summary>An event emitted when the options of the current model has changed.</summary>
            abstract onDidChangeModelOptions: listener: (IModelOptionsChangedEvent -> unit) -> IDisposable
            /// <summary>An event emitted when the configuration of the editor has changed. (e.g. <c>editor.updateOptions()</c>)</summary>
            abstract onDidChangeConfiguration: listener: (IConfigurationChangedEvent -> unit) -> IDisposable
            /// <summary>An event emitted when the cursor position has changed.</summary>
            abstract onDidChangeCursorPosition: listener: (ICursorPositionChangedEvent -> unit) -> IDisposable
            /// <summary>An event emitted when the cursor selection has changed.</summary>
            abstract onDidChangeCursorSelection: listener: (ICursorSelectionChangedEvent -> unit) -> IDisposable
            /// <summary>An event emitted when the model of this editor has changed (e.g. <c>editor.setModel()</c>).</summary>
            abstract onDidChangeModel: listener: (IModelChangedEvent -> unit) -> IDisposable
            /// <summary>An event emitted when the decorations of the current model have changed.</summary>
            abstract onDidChangeModelDecorations: listener: (IModelDecorationsChangedEvent -> unit) -> IDisposable
            /// <summary>An event emitted when the text inside this editor gained focus (i.e. cursor blinking).</summary>
            abstract onDidFocusEditorText: listener: (unit -> unit) -> IDisposable
            /// <summary>An event emitted when the text inside this editor lost focus.</summary>
            abstract onDidBlurEditorText: listener: (unit -> unit) -> IDisposable
            /// <summary>An event emitted when the text inside this editor or an editor widget gained focus.</summary>
            abstract onDidFocusEditor: listener: (unit -> unit) -> IDisposable
            /// <summary>An event emitted when the text inside this editor or an editor widget lost focus.</summary>
            abstract onDidBlurEditor: listener: (unit -> unit) -> IDisposable
            /// Saves current view state of the editor in a serializable object.
            abstract saveViewState: unit -> ICodeEditorViewState
            /// <summary>Restores the view state of the editor from a serializable object generated by <c>saveViewState</c>.</summary>
            abstract restoreViewState: state: ICodeEditorViewState -> unit
            /// Returns true if this editor or one of its widgets has keyboard focus.
            abstract hasWidgetFocus: unit -> bool
            /// <summary>Get a contribution of this editor.</summary>
            /// <returns>The contribution or null if contribution not found.</returns>
            abstract getContribution: id: string -> 'T when 'T :> IEditorContribution
            /// Type the getModel() of IEditor.
            abstract getModel: unit -> IModel
            /// Returns the current editor's configuration
            abstract getConfiguration: unit -> InternalEditorOptions
            /// <summary>Get value of the current model attached to this editor.</summary>
            /// <seealso cref="IModel.getValue" />
            abstract getValue: ?options: ICommonCodeEditorGetValueOptions -> string
            /// <summary>Set the value of the current model attached to this editor.</summary>
            /// <seealso cref="IModel.setValue" />
            abstract setValue: newValue: string -> unit
            /// Get the scrollWidth of the editor's viewport.
            abstract getScrollWidth: unit -> float
            /// Get the scrollLeft of the editor's viewport.
            abstract getScrollLeft: unit -> float
            /// Get the scrollHeight of the editor's viewport.
            abstract getScrollHeight: unit -> float
            /// Get the scrollTop of the editor's viewport.
            abstract getScrollTop: unit -> float
            /// Change the scrollLeft of the editor's viewport.
            abstract setScrollLeft: newScrollLeft: float -> unit
            /// Change the scrollTop of the editor's viewport.
            abstract setScrollTop: newScrollTop: float -> unit
            /// Change the scroll position of the editor's viewport.
            abstract setScrollPosition: position: INewScrollPosition -> unit
            /// <summary>Get an action that is a contribution to this editor.</summary>
            /// <returns>The action or null if action not found.</returns>
            abstract getAction: id: string -> IEditorAction
            /// <summary>
            /// Execute a command on the editor.
            /// The edits will land on the undo-redo stack, but no "undo stop" will be pushed.
            /// </summary>
            /// <param name="source">The source of the call.</param>
            /// <param name="command">The command to execute</param>
            abstract executeCommand: source: string * command: ICommand -> unit
            /// Push an "undo stop" in the undo-redo stack.
            abstract pushUndoStop: unit -> bool
            /// <summary>
            /// Execute edits on the editor.
            /// The edits will land on the undo-redo stack, but no "undo stop" will be pushed.
            /// </summary>
            /// <param name="source">The source of the call.</param>
            /// <param name="edits">The edits to execute.</param>
            /// <param name="endCursoState">Cursor state after the edits were applied.</param>
            abstract executeEdits: source: string * edits: ResizeArray<IIdentifiedSingleEditOperation> * ?endCursoState: ResizeArray<Selection> -> bool
            /// <summary>Execute multiple (concommitent) commands on the editor.</summary>
            /// <param name="source">The source of the call.</param>
            /// <param name="command">The commands to execute</param>
            abstract executeCommands: source: string * commands: ResizeArray<ICommand> -> unit
            /// Get all the decorations on a line (filtering out decorations from other editors).
            abstract getLineDecorations: lineNumber: float -> ResizeArray<IModelDecoration>
            /// <summary>All decorations added through this call will get the ownerId of this editor.</summary>
            /// <seealso cref="IModel.deltaDecorations" />
            abstract deltaDecorations: oldDecorations: ResizeArray<string> * newDecorations: ResizeArray<IModelDeltaDecoration> -> ResizeArray<string>
            /// Get the layout info for the editor.
            abstract getLayoutInfo: unit -> EditorLayoutInfo

        type [<AllowNullLiteral>] ICommonCodeEditorGetValueOptions =
            abstract preserveBOM: bool with get, set
            abstract lineEnding: string with get, set

        type [<AllowNullLiteral>] ICommonDiffEditor =
            inherit IEditor
            /// <summary>An event emitted when the diff information computed by this diff editor has been updated.</summary>
            abstract onDidUpdateDiff: listener: (unit -> unit) -> IDisposable
            /// Saves current view state of the editor in a serializable object.
            abstract saveViewState: unit -> IDiffEditorViewState
            /// <summary>Restores the view state of the editor from a serializable object generated by <c>saveViewState</c>.</summary>
            abstract restoreViewState: state: IDiffEditorViewState -> unit
            /// Type the getModel() of IEditor.
            abstract getModel: unit -> IDiffEditorModel
            /// <summary>Get the <c>original</c> editor.</summary>
            abstract getOriginalEditor: unit -> ICommonCodeEditor
            /// <summary>Get the <c>modified</c> editor.</summary>
            abstract getModifiedEditor: unit -> ICommonCodeEditor
            /// Get the computed diff information.
            abstract getLineChanges: unit -> ResizeArray<ILineChange>
            /// Get information based on computed diff about a line number from the original model.
            /// If the diff computation is not finished or the model is missing, will return null.
            abstract getDiffLineInformationForOriginal: lineNumber: float -> IDiffLineInformation
            /// Get information based on computed diff about a line number from the modified model.
            /// If the diff computation is not finished or the model is missing, will return null.
            abstract getDiffLineInformationForModified: lineNumber: float -> IDiffLineInformation
            /// <seealso cref="ICodeEditor.getValue" />
            abstract getValue: ?options: ICommonDiffEditorGetValueOptions -> string

        type [<AllowNullLiteral>] ICommonDiffEditorGetValueOptions =
            abstract preserveBOM: bool with get, set
            abstract lineEnding: string with get, set

        /// An event describing that the current mode associated with a model has changed.
        type [<AllowNullLiteral>] IModelLanguageChangedEvent =
            /// Previous language
            abstract oldLanguage: string
            /// New language
            abstract newLanguage: string

        type [<AllowNullLiteral>] IModelContentChange =
            /// The range that got replaced.
            abstract range: IRange
            /// The length of the range that got replaced.
            abstract rangeLength: float
            /// The new text for the range.
            abstract text: string

        /// An event describing a change in the text of a model.
        type [<AllowNullLiteral>] IModelContentChangedEvent =
            abstract changes: ResizeArray<IModelContentChange>
            /// The (new) end-of-line character.
            abstract eol: string
            /// The new version id the model has transitioned to.
            abstract versionId: float
            /// Flag that indicates that this event was generated while undoing.
            abstract isUndoing: bool
            /// Flag that indicates that this event was generated while redoing.
            abstract isRedoing: bool
            /// Flag that indicates that all decorations were lost with this edit.
            /// The model has been reset to a new value.
            abstract isFlush: bool

        /// An event describing that model decorations have changed.
        type [<AllowNullLiteral>] IModelDecorationsChangedEvent =
            /// Lists of ids for added decorations.
            abstract addedDecorations: ResizeArray<string>
            /// Lists of ids for changed decorations.
            abstract changedDecorations: ResizeArray<string>
            /// List of ids for removed decorations.
            abstract removedDecorations: ResizeArray<string>

        /// An event describing that some ranges of lines have been tokenized (their tokens have changed).
        type [<AllowNullLiteral>] IModelTokensChangedEvent =
            abstract ranges: ResizeArray<IModelTokensChangedEventRanges>

        type [<AllowNullLiteral>] IModelOptionsChangedEvent =
            abstract tabSize: bool
            abstract insertSpaces: bool
            abstract trimAutoWhitespace: bool

        /// Describes the reason the cursor has changed its position.
        type [<RequireQualifiedAccess>] CursorChangeReason =
            /// Unknown or not set.
            | NotSet = 0
            /// <summary>A <c>model.setValue()</c> was called.</summary>
            | ContentFlush = 1
            /// <summary>The <c>model</c> has been changed outside of this cursor and the cursor recovers its position from associated markers.</summary>
            | RecoverFromMarkers = 2
            /// There was an explicit user gesture.
            | Explicit = 3
            /// There was a Paste.
            | Paste = 4
            /// There was an Undo.
            | Undo = 5
            /// There was a Redo.
            | Redo = 6

        /// An event describing that the cursor position has changed.
        type [<AllowNullLiteral>] ICursorPositionChangedEvent =
            /// Primary cursor's position.
            abstract position: Position
            /// Secondary cursors' position.
            abstract secondaryPositions: ResizeArray<Position>
            /// Reason.
            abstract reason: CursorChangeReason
            /// Source of the call that caused the event.
            abstract source: string

        /// An event describing that the cursor selection has changed.
        type [<AllowNullLiteral>] ICursorSelectionChangedEvent =
            /// The primary selection.
            abstract selection: Selection
            /// The secondary selections.
            abstract secondarySelections: ResizeArray<Selection>
            /// Source of the call that caused the event.
            abstract source: string
            /// Reason.
            abstract reason: CursorChangeReason

        /// Configuration options for editor scrollbars
        type [<AllowNullLiteral>] IEditorScrollbarOptions =
            /// The size of arrows (if displayed).
            /// Defaults to 11.
            abstract arrowSize: float option with get, set
            /// Render vertical scrollbar.
            /// Accepted values: 'auto', 'visible', 'hidden'.
            /// Defaults to 'auto'.
            abstract vertical: string option with get, set
            /// Render horizontal scrollbar.
            /// Accepted values: 'auto', 'visible', 'hidden'.
            /// Defaults to 'auto'.
            abstract horizontal: string option with get, set
            /// Cast horizontal and vertical shadows when the content is scrolled.
            /// Defaults to true.
            abstract useShadows: bool option with get, set
            /// Render arrows at the top and bottom of the vertical scrollbar.
            /// Defaults to false.
            abstract verticalHasArrows: bool option with get, set
            /// Render arrows at the left and right of the horizontal scrollbar.
            /// Defaults to false.
            abstract horizontalHasArrows: bool option with get, set
            /// Listen to mouse wheel events and react to them by scrolling.
            /// Defaults to true.
            abstract handleMouseWheel: bool option with get, set
            /// Height in pixels for the horizontal scrollbar.
            /// Defaults to 10 (px).
            abstract horizontalScrollbarSize: float option with get, set
            /// Width in pixels for the vertical scrollbar.
            /// Defaults to 10 (px).
            abstract verticalScrollbarSize: float option with get, set
            /// <summary>
            /// Width in pixels for the vertical slider.
            /// Defaults to <c>verticalScrollbarSize</c>.
            /// </summary>
            abstract verticalSliderSize: float option with get, set
            /// <summary>
            /// Height in pixels for the horizontal slider.
            /// Defaults to <c>horizontalScrollbarSize</c>.
            /// </summary>
            abstract horizontalSliderSize: float option with get, set

        /// Configuration options for editor find widget
        type [<AllowNullLiteral>] IEditorFindOptions =
            /// Controls if we seed search string in the Find Widget with editor selection.
            abstract seedSearchStringFromSelection: bool option with get, set
            /// Controls if Find in Selection flag is turned on when multiple lines of text are selected in the editor.
            abstract autoFindInSelection: bool with get, set

        /// Configuration options for editor minimap
        type [<AllowNullLiteral>] IEditorMinimapOptions =
            /// Enable the rendering of the minimap.
            /// Defaults to false.
            abstract enabled: bool option with get, set
            /// Control the rendering of the minimap slider.
            /// Defaults to 'mouseover'.
            abstract showSlider: IEditorMinimapOptionsShowSlider option with get, set
            /// Render the actual text on a line (as opposed to color blocks).
            /// Defaults to true.
            abstract renderCharacters: bool option with get, set
            /// Limit the width of the minimap to render at most a certain number of columns.
            /// Defaults to 120.
            abstract maxColumn: float option with get, set

        /// Configuration options for the editor.
        type [<AllowNullLiteral>] IEditorOptions =
            /// The aria label for the editor's textarea (when it is focused).
            abstract ariaLabel: string option with get, set
            /// Render vertical lines at the specified columns.
            /// Defaults to empty array.
            abstract rulers: ResizeArray<float> option with get, set
            /// A string containing the word separators used when doing word navigation.
            /// Defaults to `~!@#$%^&*()-=+[{]}\\|;:\'",.<>/?
            abstract wordSeparators: string option with get, set
            /// Enable Linux primary clipboard.
            /// Defaults to true.
            abstract selectionClipboard: bool option with get, set
            /// Control the rendering of line numbers.
            /// If it is a function, it will be invoked when rendering a line number and the return value will be rendered.
            /// Otherwise, if it is a truey, line numbers will be rendered normally (equivalent of using an identity function).
            /// Otherwise, line numbers will not be rendered.
            /// Defaults to true.
            abstract lineNumbers: U2<(float -> string), string> option with get, set
            /// Should the corresponding line be selected when clicking on the line number?
            /// Defaults to true.
            abstract selectOnLineNumbers: bool option with get, set
            /// Control the width of line numbers, by reserving horizontal space for rendering at least an amount of digits.
            /// Defaults to 5.
            abstract lineNumbersMinChars: float option with get, set
            /// Enable the rendering of the glyph margin.
            /// Defaults to true in vscode and to false in monaco-editor.
            abstract glyphMargin: bool option with get, set
            /// The width reserved for line decorations (in px).
            /// Line decorations are placed between line numbers and the editor content.
            /// You can pass in a string in the format floating point followed by "ch". e.g. 1.3ch.
            /// Defaults to 10.
            abstract lineDecorationsWidth: U2<float, string> option with get, set
            /// When revealing the cursor, a virtual padding (px) is added to the cursor, turning it into a rectangle.
            /// This virtual padding ensures that the cursor gets revealed before hitting the edge of the viewport.
            /// Defaults to 30 (px).
            abstract revealHorizontalRightPadding: float option with get, set
            /// Render the editor selection with rounded borders.
            /// Defaults to true.
            abstract roundedSelection: bool option with get, set
            /// Class name to be added to the editor.
            abstract extraEditorClassName: string option with get, set
            /// Should the editor be read only.
            /// Defaults to false.
            abstract readOnly: bool option with get, set
            /// Control the behavior and rendering of the scrollbars.
            abstract scrollbar: IEditorScrollbarOptions option with get, set
            /// Control the behavior and rendering of the minimap.
            abstract minimap: IEditorMinimapOptions option with get, set
            /// Control the behavior of the find widget.
            abstract find: IEditorFindOptions option with get, set
            /// <summary>
            /// Display overflow widgets as <c>fixed</c>.
            /// Defaults to <c>false</c>.
            /// </summary>
            abstract fixedOverflowWidgets: bool option with get, set
            /// The number of vertical lanes the overview ruler should render.
            /// Defaults to 2.
            abstract overviewRulerLanes: float option with get, set
            /// <summary>
            /// Controls if a border should be drawn around the overview ruler.
            /// Defaults to <c>true</c>.
            /// </summary>
            abstract overviewRulerBorder: bool option with get, set
            /// Control the cursor animation style, possible values are 'blink', 'smooth', 'phase', 'expand' and 'solid'.
            /// Defaults to 'blink'.
            abstract cursorBlinking: string option with get, set
            /// Zoom the font in the editor when using the mouse wheel in combination with holding Ctrl.
            /// Defaults to false.
            abstract mouseWheelZoom: bool option with get, set
            /// Control the cursor style, either 'block' or 'line'.
            /// Defaults to 'line'.
            abstract cursorStyle: string option with get, set
            /// Enable font ligatures.
            /// Defaults to false.
            abstract fontLigatures: bool option with get, set
            /// <summary>
            /// Disable the use of <c>will-change</c> for the editor margin and lines layers.
            /// The usage of <c>will-change</c> acts as a hint for browsers to create an extra layer.
            /// Defaults to false.
            /// </summary>
            abstract disableLayerHinting: bool option with get, set
            /// Disable the optimizations for monospace fonts.
            /// Defaults to false.
            abstract disableMonospaceOptimizations: bool option with get, set
            /// Should the cursor be hidden in the overview ruler.
            /// Defaults to false.
            abstract hideCursorInOverviewRuler: bool option with get, set
            /// Enable that scrolling can go one screen size after the last line.
            /// Defaults to true.
            abstract scrollBeyondLastLine: bool option with get, set
            /// Enable that the editor will install an interval to check if its container dom node size has changed.
            /// Enabling this might have a severe performance impact.
            /// Defaults to false.
            abstract automaticLayout: bool option with get, set
            /// <summary>
            /// Control the wrapping of the editor.
            /// When <c>wordWrap</c> = "off", the lines will never wrap.
            /// When <c>wordWrap</c> = "on", the lines will wrap at the viewport width.
            /// When <c>wordWrap</c> = "wordWrapColumn", the lines will wrap at <c>wordWrapColumn</c>.
            /// When <c>wordWrap</c> = "bounded", the lines will wrap at min(viewport width, wordWrapColumn).
            /// Defaults to "off".
            /// </summary>
            abstract wordWrap: IEditorOptionsWordWrap option with get, set
            /// <summary>
            /// Control the wrapping of the editor.
            /// When <c>wordWrap</c> = "off", the lines will never wrap.
            /// When <c>wordWrap</c> = "on", the lines will wrap at the viewport width.
            /// When <c>wordWrap</c> = "wordWrapColumn", the lines will wrap at <c>wordWrapColumn</c>.
            /// When <c>wordWrap</c> = "bounded", the lines will wrap at min(viewport width, wordWrapColumn).
            /// Defaults to 80.
            /// </summary>
            abstract wordWrapColumn: float option with get, set
            /// Force word wrapping when the text appears to be of a minified/generated file.
            /// Defaults to true.
            abstract wordWrapMinified: bool option with get, set
            /// Control indentation of wrapped lines. Can be: 'none', 'same' or 'indent'.
            /// Defaults to 'same' in vscode and to 'none' in monaco-editor.
            abstract wrappingIndent: string option with get, set
            /// Configure word wrapping characters. A break will be introduced before these characters.
            /// Defaults to '{([+'.
            abstract wordWrapBreakBeforeCharacters: string option with get, set
            /// Configure word wrapping characters. A break will be introduced after these characters.
            /// Defaults to ' \t})]?|&,;'.
            abstract wordWrapBreakAfterCharacters: string option with get, set
            /// <summary>
            /// Configure word wrapping characters. A break will be introduced after these characters only if no <c>wordWrapBreakBeforeCharacters</c> or <c>wordWrapBreakAfterCharacters</c> were found.
            /// Defaults to '.'.
            /// </summary>
            abstract wordWrapBreakObtrusiveCharacters: string option with get, set
            /// Performance guard: Stop rendering a line after x characters.
            /// Defaults to 10000.
            /// Use -1 to never stop rendering
            abstract stopRenderingLineAfter: float option with get, set
            /// Enable hover.
            /// Defaults to true.
            abstract hover: bool option with get, set
            /// Enable detecting links and making them clickable.
            /// Defaults to true.
            abstract links: bool option with get, set
            /// Enable custom contextmenu.
            /// Defaults to true.
            abstract contextmenu: bool option with get, set
            /// <summary>
            /// A multiplier to be used on the <c>deltaX</c> and <c>deltaY</c> of mouse wheel scroll events.
            /// Defaults to 1.
            /// </summary>
            abstract mouseWheelScrollSensitivity: float option with get, set
            /// The modifier to be used to add multiple cursors with the mouse.
            /// Defaults to 'alt'
            abstract multiCursorModifier: IEditorOptionsMultiCursorModifier option with get, set
            /// Configure the editor's accessibility support.
            /// Defaults to 'auto'. It is best to leave this to 'auto'.
            abstract accessibilitySupport: IEditorOptionsAccessibilitySupport option with get, set
            /// Enable quick suggestions (shadow suggestions)
            /// Defaults to true.
            abstract quickSuggestions: U2<bool, IEditorOptionsQuickSuggestions> option with get, set
            /// Quick suggestions show delay (in ms)
            /// Defaults to 500 (ms)
            abstract quickSuggestionsDelay: float option with get, set
            /// Enables parameter hints
            abstract parameterHints: bool option with get, set
            /// Render icons in suggestions box.
            /// Defaults to true.
            abstract iconsInSuggestions: bool option with get, set
            /// Enable auto closing brackets.
            /// Defaults to true.
            abstract autoClosingBrackets: bool option with get, set
            /// Enable auto indentation adjustment.
            /// Defaults to false.
            abstract autoIndent: bool option with get, set
            /// Enable format on type.
            /// Defaults to false.
            abstract formatOnType: bool option with get, set
            /// Enable format on paste.
            /// Defaults to false.
            abstract formatOnPaste: bool option with get, set
            /// Controls if the editor should allow to move selections via drag and drop.
            /// Defaults to false.
            abstract dragAndDrop: bool option with get, set
            /// Enable the suggestion box to pop-up on trigger characters.
            /// Defaults to true.
            abstract suggestOnTriggerCharacters: bool option with get, set
            /// Accept suggestions on ENTER.
            /// Defaults to 'on'.
            abstract acceptSuggestionOnEnter: IEditorOptionsAcceptSuggestionOnEnter option with get, set
            /// Accept suggestions on provider defined characters.
            /// Defaults to true.
            abstract acceptSuggestionOnCommitCharacter: bool option with get, set
            /// Enable snippet suggestions. Default to 'true'.
            abstract snippetSuggestions: IEditorOptionsSnippetSuggestions option with get, set
            /// Copying without a selection copies the current line.
            abstract emptySelectionClipboard: bool option with get, set
            /// Enable word based suggestions. Defaults to 'true'
            abstract wordBasedSuggestions: bool option with get, set
            /// The font size for the suggest widget.
            /// Defaults to the editor font size.
            abstract suggestFontSize: float option with get, set
            /// The line height for the suggest widget.
            /// Defaults to the editor line height.
            abstract suggestLineHeight: float option with get, set
            /// Enable selection highlight.
            /// Defaults to true.
            abstract selectionHighlight: bool option with get, set
            /// Enable semantic occurrences highlight.
            /// Defaults to true.
            abstract occurrencesHighlight: bool option with get, set
            /// Show code lens
            /// Defaults to true.
            abstract codeLens: bool option with get, set
            /// Enable code folding
            /// Defaults to true in vscode and to false in monaco-editor.
            abstract folding: bool option with get, set
            /// Controls whether the fold actions in the gutter stay always visible or hide unless the mouse is over the gutter.
            /// Defaults to 'mouseover'.
            abstract showFoldingControls: IEditorMinimapOptionsShowSlider option with get, set
            /// Enable highlighting of matching brackets.
            /// Defaults to true.
            abstract matchBrackets: bool option with get, set
            /// Enable rendering of whitespace.
            /// Defaults to none.
            abstract renderWhitespace: IEditorOptionsRenderWhitespace option with get, set
            /// Enable rendering of control characters.
            /// Defaults to false.
            abstract renderControlCharacters: bool option with get, set
            /// Enable rendering of indent guides.
            /// Defaults to false.
            abstract renderIndentGuides: bool option with get, set
            /// Enable rendering of current line highlight.
            /// Defaults to all.
            abstract renderLineHighlight: IEditorOptionsRenderLineHighlight option with get, set
            /// Inserting and deleting whitespace follows tab stops.
            abstract useTabStops: bool option with get, set
            /// The font family
            abstract fontFamily: string option with get, set
            /// The font weight
            abstract fontWeight: IEditorOptionsFontWeight option with get, set
            /// The font size
            abstract fontSize: float option with get, set
            /// The line height
            abstract lineHeight: float option with get, set
            /// The letter spacing
            abstract letterSpacing: float option with get, set

        /// Configuration options for the diff editor.
        type [<AllowNullLiteral>] IDiffEditorOptions =
            inherit IEditorOptions
            /// Allow the user to resize the diff editor split view.
            /// Defaults to true.
            abstract enableSplitViewResizing: bool option with get, set
            /// Render the differences in two side-by-side editors.
            /// Defaults to true.
            abstract renderSideBySide: bool option with get, set
            /// Compute the diff by ignoring leading/trailing whitespace
            /// Defaults to true.
            abstract ignoreTrimWhitespace: bool option with get, set
            /// Render +/- indicators for added/deleted changes.
            /// Defaults to true.
            abstract renderIndicators: bool option with get, set
            /// Original model should be editable?
            /// Defaults to false.
            abstract originalEditable: bool option with get, set

        type [<RequireQualifiedAccess>] RenderMinimap =
            | None = 0
            | Small = 1
            | Large = 2
            | SmallBlocks = 3
            | LargeBlocks = 4

        /// Describes how to indent wrapped lines.
        type [<RequireQualifiedAccess>] WrappingIndent =
            /// No indentation => wrapped lines begin at column 1.
            | None = 0
            /// Same => wrapped lines get the same indentation as the parent.
            | Same = 1
            /// Indent => wrapped lines get +1 indentation as the parent.
            | Indent = 2

        /// The kind of animation in which the editor's cursor should be rendered.
        type [<RequireQualifiedAccess>] TextEditorCursorBlinkingStyle =
            /// Hidden
            | Hidden = 0
            /// Blinking
            | Blink = 1
            /// Blinking with smooth fading
            | Smooth = 2
            /// Blinking with prolonged filled state and smooth fading
            | Phase = 3
            /// Expand collapse animation on the y axis
            | Expand = 4
            /// No-Blinking
            | Solid = 5

        /// The style in which the editor's cursor should be rendered.
        type [<RequireQualifiedAccess>] TextEditorCursorStyle =
            /// As a vertical line (sitting between two characters).
            | Line = 1
            /// As a block (sitting on top of a character).
            | Block = 2
            /// As a horizontal line (sitting under a character).
            | Underline = 3
            /// As a thin vertical line (sitting between two characters).
            | LineThin = 4
            /// As an outlined block (sitting on top of a character).
            | BlockOutline = 5
            /// As a thin horizontal line (sitting under a character).
            | UnderlineThin = 6

        type [<AllowNullLiteral>] InternalEditorScrollbarOptions =
            abstract arrowSize: float
            abstract vertical: ScrollbarVisibility
            abstract horizontal: ScrollbarVisibility
            abstract useShadows: bool
            abstract verticalHasArrows: bool
            abstract horizontalHasArrows: bool
            abstract handleMouseWheel: bool
            abstract horizontalScrollbarSize: float
            abstract horizontalSliderSize: float
            abstract verticalScrollbarSize: float
            abstract verticalSliderSize: float
            abstract mouseWheelScrollSensitivity: float

        type [<AllowNullLiteral>] InternalEditorMinimapOptions =
            abstract enabled: bool
            abstract showSlider: IEditorMinimapOptionsShowSlider
            abstract renderCharacters: bool
            abstract maxColumn: float

        type [<AllowNullLiteral>] InternalEditorFindOptions =
            abstract seedSearchStringFromSelection: bool
            abstract autoFindInSelection: bool

        type [<AllowNullLiteral>] EditorWrappingInfo =
            abstract inDiffEditor: bool
            abstract isDominatedByLongLines: bool
            abstract isWordWrapMinified: bool
            abstract isViewportWrapping: bool
            abstract wrappingColumn: float
            abstract wrappingIndent: WrappingIndent
            abstract wordWrapBreakBeforeCharacters: string
            abstract wordWrapBreakAfterCharacters: string
            abstract wordWrapBreakObtrusiveCharacters: string

        type [<AllowNullLiteral>] InternalEditorViewOptions =
            abstract extraEditorClassName: string
            abstract disableMonospaceOptimizations: bool
            abstract rulers: ResizeArray<float>
            abstract ariaLabel: string
            abstract renderLineNumbers: bool
            abstract renderCustomLineNumbers: (float -> string)
            abstract renderRelativeLineNumbers: bool
            abstract selectOnLineNumbers: bool
            abstract glyphMargin: bool
            abstract revealHorizontalRightPadding: float
            abstract roundedSelection: bool
            abstract overviewRulerLanes: float
            abstract overviewRulerBorder: bool
            abstract cursorBlinking: TextEditorCursorBlinkingStyle
            abstract mouseWheelZoom: bool
            abstract cursorStyle: TextEditorCursorStyle
            abstract hideCursorInOverviewRuler: bool
            abstract scrollBeyondLastLine: bool
            abstract stopRenderingLineAfter: float
            abstract renderWhitespace: IEditorOptionsRenderWhitespace
            abstract renderControlCharacters: bool
            abstract fontLigatures: bool
            abstract renderIndentGuides: bool
            abstract renderLineHighlight: IEditorOptionsRenderLineHighlight
            abstract scrollbar: InternalEditorScrollbarOptions
            abstract minimap: InternalEditorMinimapOptions
            abstract fixedOverflowWidgets: bool

        type [<AllowNullLiteral>] EditorContribOptions =
            abstract selectionClipboard: bool
            abstract hover: bool
            abstract links: bool
            abstract contextmenu: bool
            abstract quickSuggestions: U2<bool, IEditorOptionsQuickSuggestions>
            abstract quickSuggestionsDelay: float
            abstract parameterHints: bool
            abstract iconsInSuggestions: bool
            abstract formatOnType: bool
            abstract formatOnPaste: bool
            abstract suggestOnTriggerCharacters: bool
            abstract acceptSuggestionOnEnter: IEditorOptionsAcceptSuggestionOnEnter
            abstract acceptSuggestionOnCommitCharacter: bool
            abstract snippetSuggestions: IEditorOptionsSnippetSuggestions
            abstract wordBasedSuggestions: bool
            abstract suggestFontSize: float
            abstract suggestLineHeight: float
            abstract selectionHighlight: bool
            abstract occurrencesHighlight: bool
            abstract codeLens: bool
            abstract folding: bool
            abstract showFoldingControls: IEditorMinimapOptionsShowSlider
            abstract matchBrackets: bool
            abstract find: InternalEditorFindOptions

        /// Internal configuration options (transformed or computed) for the editor.
        type [<AllowNullLiteral>] InternalEditorOptions =
            abstract _internalEditorOptionsBrand: unit
            abstract canUseLayerHinting: bool
            abstract pixelRatio: float
            abstract editorClassName: string
            abstract lineHeight: float
            abstract readOnly: bool
            abstract multiCursorModifier: InternalEditorOptionsMultiCursorModifier
            abstract wordSeparators: string
            abstract autoClosingBrackets: bool
            abstract autoIndent: bool
            abstract useTabStops: bool
            abstract tabFocusMode: bool
            abstract dragAndDrop: bool
            abstract emptySelectionClipboard: bool
            abstract layoutInfo: EditorLayoutInfo
            abstract fontInfo: FontInfo
            abstract viewInfo: InternalEditorViewOptions
            abstract wrappingInfo: EditorWrappingInfo
            abstract contribInfo: EditorContribOptions

        /// Internal configuration options (transformed or computed) for the editor.
        type [<AllowNullLiteral>] InternalEditorOptionsStatic =
            [<EmitConstructor>] abstract Create: unit -> InternalEditorOptions

        /// A description for the overview ruler position.
        type [<AllowNullLiteral>] OverviewRulerPosition =
            /// Width of the overview ruler
            abstract width: float
            /// Height of the overview ruler
            abstract height: float
            /// Top position for the overview ruler
            abstract top: float
            /// Right position for the overview ruler
            abstract right: float

        /// The internal layout details of the editor.
        type [<AllowNullLiteral>] EditorLayoutInfo =
            /// Full editor width.
            abstract width: float
            /// Full editor height.
            abstract height: float
            /// Left position for the glyph margin.
            abstract glyphMarginLeft: float
            /// The width of the glyph margin.
            abstract glyphMarginWidth: float
            /// The height of the glyph margin.
            abstract glyphMarginHeight: float
            /// Left position for the line numbers.
            abstract lineNumbersLeft: float
            /// The width of the line numbers.
            abstract lineNumbersWidth: float
            /// The height of the line numbers.
            abstract lineNumbersHeight: float
            /// Left position for the line decorations.
            abstract decorationsLeft: float
            /// The width of the line decorations.
            abstract decorationsWidth: float
            /// The height of the line decorations.
            abstract decorationsHeight: float
            /// Left position for the content (actual text)
            abstract contentLeft: float
            /// The width of the content (actual text)
            abstract contentWidth: float
            /// The height of the content (actual height)
            abstract contentHeight: float
            /// The width of the minimap
            abstract minimapWidth: float
            /// Minimap render type
            abstract renderMinimap: RenderMinimap
            /// The number of columns (of typical characters) fitting on a viewport line.
            abstract viewportColumn: float
            /// The width of the vertical scrollbar.
            abstract verticalScrollbarWidth: float
            /// The height of the horizontal scrollbar.
            abstract horizontalScrollbarHeight: float
            /// The position of the overview ruler.
            abstract overviewRuler: OverviewRulerPosition

        /// An event describing that the configuration of the editor has changed.
        type [<AllowNullLiteral>] IConfigurationChangedEvent =
            abstract canUseLayerHinting: bool
            abstract pixelRatio: bool
            abstract editorClassName: bool
            abstract lineHeight: bool
            abstract readOnly: bool
            abstract accessibilitySupport: bool
            abstract multiCursorModifier: bool
            abstract wordSeparators: bool
            abstract autoClosingBrackets: bool
            abstract autoIndent: bool
            abstract useTabStops: bool
            abstract tabFocusMode: bool
            abstract dragAndDrop: bool
            abstract emptySelectionClipboard: bool
            abstract layoutInfo: bool
            abstract fontInfo: bool
            abstract viewInfo: bool
            abstract wrappingInfo: bool
            abstract contribInfo: bool

        /// A view zone is a full horizontal rectangle that 'pushes' text down.
        /// The editor reserves space for view zones when rendering.
        type [<AllowNullLiteral>] IViewZone =
            /// The line number after which this zone should appear.
            /// Use 0 to place a view zone before the first line number.
            abstract afterLineNumber: float with get, set
            /// <summary>
            /// The column after which this zone should appear.
            /// If not set, the maxLineColumn of <c>afterLineNumber</c> will be used.
            /// </summary>
            abstract afterColumn: float option with get, set
            /// Suppress mouse down events.
            /// If set, the editor will attach a mouse down listener to the view zone and .preventDefault on it.
            /// Defaults to false
            abstract suppressMouseDown: bool option with get, set
            /// <summary>
            /// The height in lines of the view zone.
            /// If specified, <c>heightInPx</c> will be used instead of this.
            /// If neither <c>heightInPx</c> nor <c>heightInLines</c> is specified, a default of <c>heightInLines</c> = 1 will be chosen.
            /// </summary>
            abstract heightInLines: float option with get, set
            /// <summary>
            /// The height in px of the view zone.
            /// If this is set, the editor will give preference to it rather than <c>heightInLines</c> above.
            /// If neither <c>heightInPx</c> nor <c>heightInLines</c> is specified, a default of <c>heightInLines</c> = 1 will be chosen.
            /// </summary>
            abstract heightInPx: float option with get, set
            /// The dom node of the view zone
            abstract domNode: HTMLElement with get, set
            /// An optional dom node for the view zone that will be placed in the margin area.
            abstract marginDomNode: HTMLElement option with get, set
            /// Callback which gives the relative top of the view zone as it appears (taking scrolling into account).
            abstract onDomNodeTop: (float -> unit) option with get, set
            /// Callback which gives the height in pixels of the view zone.
            abstract onComputedHeight: (float -> unit) option with get, set

        /// An accessor that allows for zones to be added or removed.
        type [<AllowNullLiteral>] IViewZoneChangeAccessor =
            /// <summary>Create a new view zone.</summary>
            /// <param name="zone">Zone to create</param>
            /// <returns>A unique identifier to the view zone.</returns>
            abstract addZone: zone: IViewZone -> float
            /// <summary>Remove a zone</summary>
            /// <param name="id">A unique identifier to the view zone, as returned by the <c>addZone</c> call.</param>
            abstract removeZone: id: float -> unit
            /// <summary>
            /// Change a zone's position.
            /// The editor will rescan the <c>afterLineNumber</c> and <c>afterColumn</c> properties of a view zone.
            /// </summary>
            abstract layoutZone: id: float -> unit

        /// A positioning preference for rendering content widgets.
        type [<RequireQualifiedAccess>] ContentWidgetPositionPreference =
            /// Place the content widget exactly at a position
            | EXACT = 0
            /// Place the content widget above a position
            | ABOVE = 1
            /// Place the content widget below a position
            | BELOW = 2

        /// A position for rendering content widgets.
        type [<AllowNullLiteral>] IContentWidgetPosition =
            /// <summary>
            /// Desired position for the content widget.
            /// <c>preference</c> will also affect the placement.
            /// </summary>
            abstract position: IPosition with get, set
            /// Placement preference for position, in order of preference.
            abstract preference: ResizeArray<ContentWidgetPositionPreference> with get, set

        /// A content widget renders inline with the text and can be easily placed 'near' an editor position.
        type [<AllowNullLiteral>] IContentWidget =
            /// Render this content widget in a location where it could overflow the editor's view dom node.
            abstract allowEditorOverflow: bool option with get, set
            abstract suppressMouseDown: bool option with get, set
            /// Get a unique identifier of the content widget.
            abstract getId: unit -> string
            /// Get the dom node of the content widget.
            abstract getDomNode: unit -> HTMLElement
            /// Get the placement of the content widget.
            /// If null is returned, the content widget will be placed off screen.
            abstract getPosition: unit -> IContentWidgetPosition

        /// A positioning preference for rendering overlay widgets.
        type [<RequireQualifiedAccess>] OverlayWidgetPositionPreference =
            /// Position the overlay widget in the top right corner
            | TOP_RIGHT_CORNER = 0
            /// Position the overlay widget in the bottom right corner
            | BOTTOM_RIGHT_CORNER = 1
            /// Position the overlay widget in the top center
            | TOP_CENTER = 2

        /// A position for rendering overlay widgets.
        type [<AllowNullLiteral>] IOverlayWidgetPosition =
            /// The position preference for the overlay widget.
            abstract preference: OverlayWidgetPositionPreference with get, set

        /// An overlay widgets renders on top of the text.
        type [<AllowNullLiteral>] IOverlayWidget =
            /// Get a unique identifier of the overlay widget.
            abstract getId: unit -> string
            /// Get the dom node of the overlay widget.
            abstract getDomNode: unit -> HTMLElement
            /// Get the placement of the overlay widget.
            /// If null is returned, the overlay widget is responsible to place itself.
            abstract getPosition: unit -> IOverlayWidgetPosition

        /// Type of hit element with the mouse in the editor.
        type [<RequireQualifiedAccess>] MouseTargetType =
            /// Mouse is on top of an unknown element.
            | UNKNOWN = 0
            /// Mouse is on top of the textarea used for input.
            | TEXTAREA = 1
            /// Mouse is on top of the glyph margin
            | GUTTER_GLYPH_MARGIN = 2
            /// Mouse is on top of the line numbers
            | GUTTER_LINE_NUMBERS = 3
            /// Mouse is on top of the line decorations
            | GUTTER_LINE_DECORATIONS = 4
            /// Mouse is on top of the whitespace left in the gutter by a view zone.
            | GUTTER_VIEW_ZONE = 5
            /// Mouse is on top of text in the content.
            | CONTENT_TEXT = 6
            /// Mouse is on top of empty space in the content (e.g. after line text or below last line)
            | CONTENT_EMPTY = 7
            /// Mouse is on top of a view zone in the content.
            | CONTENT_VIEW_ZONE = 8
            /// Mouse is on top of a content widget.
            | CONTENT_WIDGET = 9
            /// Mouse is on top of the decorations overview ruler.
            | OVERVIEW_RULER = 10
            /// Mouse is on top of a scrollbar.
            | SCROLLBAR = 11
            /// Mouse is on top of an overlay widget.
            | OVERLAY_WIDGET = 12
            /// Mouse is outside of the editor.
            | OUTSIDE_EDITOR = 13

        /// Target hit with the mouse in the editor.
        type [<AllowNullLiteral>] IMouseTarget =
            /// The target element
            abstract element: Element
            /// The target type
            abstract ``type``: MouseTargetType
            /// The 'approximate' editor position
            abstract position: Position
            /// Desired mouse column (e.g. when position.column gets clamped to text length -- clicking after text on a line).
            abstract mouseColumn: float
            /// The 'approximate' editor range
            abstract range: Range
            /// Some extra detail.
            abstract detail: obj option

        /// A mouse event originating from the editor.
        type [<AllowNullLiteral>] IEditorMouseEvent =
            abstract ``event``: IMouseEvent
            abstract target: IMouseTarget

        /// A rich code editor.
        type [<AllowNullLiteral>] ICodeEditor =
            inherit ICommonCodeEditor
            /// <summary>An event emitted on a "mouseup".</summary>
            abstract onMouseUp: listener: (IEditorMouseEvent -> unit) -> IDisposable
            /// <summary>An event emitted on a "mousedown".</summary>
            abstract onMouseDown: listener: (IEditorMouseEvent -> unit) -> IDisposable
            /// <summary>An event emitted on a "contextmenu".</summary>
            abstract onContextMenu: listener: (IEditorMouseEvent -> unit) -> IDisposable
            /// <summary>An event emitted on a "mousemove".</summary>
            abstract onMouseMove: listener: (IEditorMouseEvent -> unit) -> IDisposable
            /// <summary>An event emitted on a "mouseleave".</summary>
            abstract onMouseLeave: listener: (IEditorMouseEvent -> unit) -> IDisposable
            /// <summary>An event emitted on a "keyup".</summary>
            abstract onKeyUp: listener: (IKeyboardEvent -> unit) -> IDisposable
            /// <summary>An event emitted on a "keydown".</summary>
            abstract onKeyDown: listener: (IKeyboardEvent -> unit) -> IDisposable
            /// <summary>An event emitted when the layout of the editor has changed.</summary>
            abstract onDidLayoutChange: listener: (EditorLayoutInfo -> unit) -> IDisposable
            /// <summary>An event emitted when the scroll in the editor has changed.</summary>
            abstract onDidScrollChange: listener: (IScrollEvent -> unit) -> IDisposable
            /// Returns the editor's dom node
            abstract getDomNode: unit -> HTMLElement
            /// Add a content widget. Widgets must have unique ids, otherwise they will be overwritten.
            abstract addContentWidget: widget: IContentWidget -> unit
            /// Layout/Reposition a content widget. This is a ping to the editor to call widget.getPosition()
            /// and update appropiately.
            abstract layoutContentWidget: widget: IContentWidget -> unit
            /// Remove a content widget.
            abstract removeContentWidget: widget: IContentWidget -> unit
            /// Add an overlay widget. Widgets must have unique ids, otherwise they will be overwritten.
            abstract addOverlayWidget: widget: IOverlayWidget -> unit
            /// Layout/Reposition an overlay widget. This is a ping to the editor to call widget.getPosition()
            /// and update appropiately.
            abstract layoutOverlayWidget: widget: IOverlayWidget -> unit
            /// Remove an overlay widget.
            abstract removeOverlayWidget: widget: IOverlayWidget -> unit
            /// Change the view zones. View zones are lost when a new model is attached to the editor.
            abstract changeViewZones: callback: (IViewZoneChangeAccessor -> unit) -> unit
            /// Returns the range that is currently centered in the view port.
            abstract getCenteredRangeInViewport: unit -> Range
            /// <summary>
            /// Get the horizontal position (left offset) for the column w.r.t to the beginning of the line.
            /// This method works only if the line <c>lineNumber</c> is currently rendered (in the editor's viewport).
            /// Use this method with caution.
            /// </summary>
            abstract getOffsetForColumn: lineNumber: float * column: float -> float
            /// Force an editor render now.
            abstract render: unit -> unit
            /// Get the vertical position (top offset) for the line w.r.t. to the first line.
            abstract getTopForLineNumber: lineNumber: float -> float
            /// Get the vertical position (top offset) for the position w.r.t. to the first line.
            abstract getTopForPosition: lineNumber: float * column: float -> float
            /// <summary>
            /// Get the hit test target at coordinates <c>clientX</c> and <c>clientY</c>.
            /// The coordinates are relative to the top-left of the viewport.
            /// </summary>
            /// <returns>Hit test target or null if the coordinates fall outside the editor or the editor has no model.</returns>
            abstract getTargetAtClientPoint: clientX: float * clientY: float -> IMouseTarget
            /// <summary>
            /// Get the visible position for <c>position</c>.
            /// The result position takes scrolling into account and is relative to the top left corner of the editor.
            /// Explanation 1: the results of this method will change for the same <c>position</c> if the user scrolls the editor.
            /// Explanation 2: the results of this method will not change if the container of the editor gets repositioned.
            /// Warning: the results of this method are innacurate for positions that are outside the current editor viewport.
            /// </summary>
            abstract getScrolledVisiblePosition: position: IPosition -> ICodeEditorGetScrolledVisiblePositionReturn
            /// <summary>Apply the same font settings as the editor to <c>target</c>.</summary>
            abstract applyFontInfo: target: HTMLElement -> unit

        type [<AllowNullLiteral>] ICodeEditorGetScrolledVisiblePositionReturn =
            abstract top: float with get, set
            abstract left: float with get, set
            abstract height: float with get, set

        /// A rich diff editor.
        type [<AllowNullLiteral>] IDiffEditor =
            inherit ICommonDiffEditor
            /// <seealso cref="ICodeEditor.getDomNode" />
            abstract getDomNode: unit -> HTMLElement

        type [<AllowNullLiteral>] FontInfo =
            inherit BareFontInfo
            abstract _editorStylingBrand: unit
            abstract isTrusted: bool
            abstract isMonospace: bool
            abstract typicalHalfwidthCharacterWidth: float
            abstract typicalFullwidthCharacterWidth: float
            abstract spaceWidth: float
            abstract maxDigitWidth: float

        type [<AllowNullLiteral>] FontInfoStatic =
            [<EmitConstructor>] abstract Create: unit -> FontInfo

        type [<AllowNullLiteral>] BareFontInfo =
            abstract _bareFontInfoBrand: unit
            abstract zoomLevel: float
            abstract fontFamily: string
            abstract fontWeight: string
            abstract fontSize: float
            abstract lineHeight: float
            abstract letterSpacing: float

        type [<AllowNullLiteral>] BareFontInfoStatic =
            [<EmitConstructor>] abstract Create: unit -> BareFontInfo

        type [<AllowNullLiteral>] IExportsOnDidChangeModelLanguage =
            abstract model: IModel
            abstract oldLanguage: string

        type [<AllowNullLiteral>] IExportsEditorType =
            abstract ICodeEditor: string with get, set
            abstract IDiffEditor: string with get, set

        type [<AllowNullLiteral>] ICodeEditorViewStateContributionsState =
            [<EmitIndexer>] abstract Item: id: string -> obj option with get, set

        type [<AllowNullLiteral>] IModelTokensChangedEventRanges =
            /// The start of the range (inclusive)
            abstract fromLineNumber: float
            /// The end of the range (inclusive)
            abstract toLineNumber: float

        type [<StringEnum>] [<RequireQualifiedAccess>] IEditorMinimapOptionsShowSlider =
            | Always
            | Mouseover

        type [<StringEnum>] [<RequireQualifiedAccess>] IEditorOptionsWordWrap =
            | Off
            | On
            | WordWrapColumn
            | Bounded

        type [<StringEnum>] [<RequireQualifiedAccess>] IEditorOptionsMultiCursorModifier =
            | CtrlCmd
            | Alt

        type [<StringEnum>] [<RequireQualifiedAccess>] IEditorOptionsAccessibilitySupport =
            | Auto
            | Off
            | On

        type [<AllowNullLiteral>] IEditorOptionsQuickSuggestions =
            abstract other: bool with get, set
            abstract comments: bool with get, set
            abstract strings: bool with get, set

        type [<StringEnum>] [<RequireQualifiedAccess>] IEditorOptionsAcceptSuggestionOnEnter =
            | On
            | Smart
            | Off

        type [<StringEnum>] [<RequireQualifiedAccess>] IEditorOptionsSnippetSuggestions =
            | Top
            | Bottom
            | Inline
            | None

        type [<StringEnum>] [<RequireQualifiedAccess>] IEditorOptionsRenderWhitespace =
            | None
            | Boundary
            | All

        type [<StringEnum>] [<RequireQualifiedAccess>] IEditorOptionsRenderLineHighlight =
            | None
            | Gutter
            | Line
            | All

        type [<StringEnum>] [<RequireQualifiedAccess>] IEditorOptionsFontWeight =
            | Normal
            | Bold
            | Bolder
            | Lighter
            | Initial
            | Inherit
            | [<CompiledName "100">] N100
            | [<CompiledName "200">] N200
            | [<CompiledName "300">] N300
            | [<CompiledName "400">] N400
            | [<CompiledName "500">] N500
            | [<CompiledName "600">] N600
            | [<CompiledName "700">] N700
            | [<CompiledName "800">] N800
            | [<CompiledName "900">] N900

        type [<StringEnum>] [<RequireQualifiedAccess>] InternalEditorOptionsMultiCursorModifier =
            | AltKey
            | CtrlKey
            | MetaKey

    module Languages =
        let [<Import("typescript","monaco-editor/monaco/languages")>] typescript: Typescript.IExports = jsNative
        let [<Import("css","monaco-editor/monaco/languages")>] css: Css.IExports = jsNative
        let [<Import("json","monaco-editor/monaco/languages")>] json: Json.IExports = jsNative
        let [<Import("html","monaco-editor/monaco/languages")>] html: Html.IExports = jsNative

        type [<AllowNullLiteral>] IExports =
            /// Register information about a new language.
            abstract register: language: ILanguageExtensionPoint -> unit
            /// Get the information of all the registered languages.
            abstract getLanguages: unit -> ResizeArray<ILanguageExtensionPoint>
            /// <summary>An event emitted when a language is first time needed (e.g. a model has it set).</summary>
            abstract onLanguage: languageId: string * callback: (unit -> unit) -> IDisposable
            /// Set the editing configuration for a language.
            abstract setLanguageConfiguration: languageId: string * configuration: LanguageConfiguration -> IDisposable
            /// Set the tokens provider for a language (manual implementation).
            abstract setTokensProvider: languageId: string * provider: TokensProvider -> IDisposable
            /// Set the tokens provider for a language (monarch implementation).
            abstract setMonarchTokensProvider: languageId: string * languageDef: IMonarchLanguage -> IDisposable
            /// Register a reference provider (used by e.g. reference search).
            abstract registerReferenceProvider: languageId: string * provider: ReferenceProvider -> IDisposable
            /// Register a rename provider (used by e.g. rename symbol).
            abstract registerRenameProvider: languageId: string * provider: RenameProvider -> IDisposable
            /// Register a signature help provider (used by e.g. paremeter hints).
            abstract registerSignatureHelpProvider: languageId: string * provider: SignatureHelpProvider -> IDisposable
            /// Register a hover provider (used by e.g. editor hover).
            abstract registerHoverProvider: languageId: string * provider: HoverProvider -> IDisposable
            /// Register a document symbol provider (used by e.g. outline).
            abstract registerDocumentSymbolProvider: languageId: string * provider: DocumentSymbolProvider -> IDisposable
            /// Register a document highlight provider (used by e.g. highlight occurrences).
            abstract registerDocumentHighlightProvider: languageId: string * provider: DocumentHighlightProvider -> IDisposable
            /// Register a definition provider (used by e.g. go to definition).
            abstract registerDefinitionProvider: languageId: string * provider: DefinitionProvider -> IDisposable
            /// Register a implementation provider (used by e.g. go to implementation).
            abstract registerImplementationProvider: languageId: string * provider: ImplementationProvider -> IDisposable
            /// Register a type definition provider (used by e.g. go to type definition).
            abstract registerTypeDefinitionProvider: languageId: string * provider: TypeDefinitionProvider -> IDisposable
            /// Register a code lens provider (used by e.g. inline code lenses).
            abstract registerCodeLensProvider: languageId: string * provider: CodeLensProvider -> IDisposable
            /// Register a code action provider (used by e.g. quick fix).
            abstract registerCodeActionProvider: languageId: string * provider: CodeActionProvider -> IDisposable
            /// Register a formatter that can handle only entire models.
            abstract registerDocumentFormattingEditProvider: languageId: string * provider: DocumentFormattingEditProvider -> IDisposable
            /// Register a formatter that can handle a range inside a model.
            abstract registerDocumentRangeFormattingEditProvider: languageId: string * provider: DocumentRangeFormattingEditProvider -> IDisposable
            /// Register a formatter than can do formatting as the user types.
            abstract registerOnTypeFormattingEditProvider: languageId: string * provider: OnTypeFormattingEditProvider -> IDisposable
            /// Register a link provider that can find links in text.
            abstract registerLinkProvider: languageId: string * provider: LinkProvider -> IDisposable
            /// Register a completion item provider (use by e.g. suggestions).
            abstract registerCompletionItemProvider: languageId: string * provider: CompletionItemProvider -> IDisposable

        /// A token.
        type [<AllowNullLiteral>] IToken =
            abstract startIndex: float with get, set
            abstract scopes: string with get, set

        /// The result of a line tokenization.
        type [<AllowNullLiteral>] ILineTokens =
            /// The list of tokens on the line.
            abstract tokens: ResizeArray<IToken> with get, set
            /// The tokenization end state.
            /// A pointer will be held to this and the object should not be modified by the tokenizer after the pointer is returned.
            abstract endState: IState with get, set

        /// A "manual" provider of tokens.
        type [<AllowNullLiteral>] TokensProvider =
            /// The initial state of a language. Will be the state passed in to tokenize the first line.
            abstract getInitialState: unit -> IState
            /// Tokenize a line given the state at the beginning of the line.
            abstract tokenize: line: string * state: IState -> ILineTokens

        /// <summary>
        /// Contains additional diagnostic information about the context in which
        /// a <see cref="CodeActionProvider.provideCodeActions">code action</see> is run.
        /// </summary>
        type [<AllowNullLiteral>] CodeActionContext =
            /// <summary>An array of diagnostics.</summary>
            abstract markers: ResizeArray<Editor.IMarkerData>

        /// <summary>
        /// The code action interface defines the contract between extensions and
        /// the <see href="https://code.visualstudio.com/docs/editor/editingevolved#_code-action">light bulb</see> feature.
        /// </summary>
        type [<AllowNullLiteral>] CodeActionProvider =
            /// Provide commands for the given document and range.
            abstract provideCodeActions: model: Editor.IReadOnlyModel * range: Range * context: CodeActionContext * token: CancellationToken -> U2<ResizeArray<Command>, Thenable<ResizeArray<Command>>>

        /// Completion item kinds.
        type [<RequireQualifiedAccess>] CompletionItemKind =
            | Text = 0
            | Method = 1
            | Function = 2
            | Constructor = 3
            | Field = 4
            | Variable = 5
            | Class = 6
            | Interface = 7
            | Module = 8
            | Property = 9
            | Unit = 10
            | Value = 11
            | Enum = 12
            | Keyword = 13
            | Snippet = 14
            | Color = 15
            | File = 16
            | Reference = 17
            | Folder = 18

        /// <summary>
        /// A snippet string is a template which allows to insert text
        /// and to control the editor cursor when insertion happens.
        /// 
        /// A snippet can define tab stops and placeholders with <c>$1</c>, <c>$2</c>
        /// and <c>${3:foo}</c>. <c>$0</c> defines the final tab stop, it defaults to
        /// the end of the snippet. Variables are defined with <c>$name</c> and
        /// <c>${name:default value}</c>. The full snippet syntax is documented
        /// <see href="http://code.visualstudio.com/docs/editor/userdefinedsnippets#_creating-your-own-snippets">here</see>.
        /// </summary>
        type [<AllowNullLiteral>] SnippetString =
            /// The snippet string.
            abstract value: string with get, set

        /// A completion item represents a text snippet that is
        /// proposed to complete text that is being typed.
        type [<AllowNullLiteral>] CompletionItem =
            /// The label of this completion item. By default
            /// this is also the text that is inserted when selecting
            /// this completion.
            abstract label: string with get, set
            /// The kind of this completion item. Based on the kind
            /// an icon is chosen by the editor.
            abstract kind: CompletionItemKind with get, set
            /// A human-readable string with additional information
            /// about this item, like type or symbol information.
            abstract detail: string option with get, set
            /// A human-readable string that represents a doc-comment.
            abstract documentation: string option with get, set
            /// <summary>
            /// A string that should be used when comparing this item
            /// with other items. When <c>falsy</c> the <see cref="CompletionItem.label">label</see>
            /// is used.
            /// </summary>
            abstract sortText: string option with get, set
            /// <summary>
            /// A string that should be used when filtering a set of
            /// completion items. When <c>falsy</c> the <see cref="CompletionItem.label">label</see>
            /// is used.
            /// </summary>
            abstract filterText: string option with get, set
            /// <summary>
            /// A string or snippet that should be inserted in a document when selecting
            /// this completion. When <c>falsy</c> the <see cref="CompletionItem.label">label</see>
            /// is used.
            /// </summary>
            abstract insertText: U2<string, SnippetString> option with get, set
            /// <summary>
            /// A range of text that should be replaced by this completion item.
            /// 
            /// Defaults to a range from the start of the <see cref="TextDocument.getWordRangeAtPosition">current word</see> to the
            /// current position.
            /// 
            /// *Note:* The range must be a <see cref="Range.isSingleLine">single line</see> and it must
            /// <see cref="Range.contains">contain</see> the position at which completion has been <see cref="CompletionItemProvider.provideCompletionItems">requested</see>.
            /// </summary>
            abstract range: Range option with get, set
            [<Obsolete("*Deprecated** in favor of `CompletionItem.insertText` and `CompletionItem.range`.

~~An [edit](#TextEdit) which is applied to a document when selecting
this completion. When an edit is provided the value of
[insertText](#CompletionItem.insertText) is ignored.~~

~~The [range](#Range) of the edit must be single-line and on the same
line completions were [requested](#CompletionItemProvider.provideCompletionItems) at.~~")>]
            abstract textEdit: Editor.ISingleEditOperation option with get, set

        /// <summary>
        /// Represents a collection of <see cref="CompletionItem">completion items</see> to be presented
        /// in the editor.
        /// </summary>
        type [<AllowNullLiteral>] CompletionList =
            /// This list it not complete. Further typing should result in recomputing
            /// this list.
            abstract isIncomplete: bool option with get, set
            /// The completion items.
            abstract items: ResizeArray<CompletionItem> with get, set

        /// <summary>
        /// The completion item provider interface defines the contract between extensions and
        /// the <see href="https://code.visualstudio.com/docs/editor/intellisense">IntelliSense</see>.
        /// 
        /// When computing *complete* completion items is expensive, providers can optionally implement
        /// the <c>resolveCompletionItem</c>-function. In that case it is enough to return completion
        /// items with a <see cref="CompletionItem.label">label</see> from the
        /// <see cref="CompletionItemProvider.provideCompletionItems">provideCompletionItems</see>-function. Subsequently,
        /// when a completion item is shown in the UI and gains focus this provider is asked to resolve
        /// the item, like adding <see cref="CompletionItem.documentation">doc-comment</see> or <see cref="CompletionItem.detail">details</see>.
        /// </summary>
        type [<AllowNullLiteral>] CompletionItemProvider =
            abstract triggerCharacters: ResizeArray<string> option with get, set
            /// Provide completion items for the given position and document.
            abstract provideCompletionItems: model: Editor.IReadOnlyModel * position: Position * token: CancellationToken -> U4<ResizeArray<CompletionItem>, Thenable<ResizeArray<CompletionItem>>, CompletionList, Thenable<CompletionList>>
            /// <summary>
            /// Given a completion item fill in more data, like <see cref="CompletionItem.documentation">doc-comment</see>
            /// or <see cref="CompletionItem.detail">details</see>.
            /// 
            /// The editor will only resolve a completion item once.
            /// </summary>
            abstract resolveCompletionItem: item: CompletionItem * token: CancellationToken -> U2<CompletionItem, Thenable<CompletionItem>>

        /// Describes how comments for a language work.
        type [<AllowNullLiteral>] CommentRule =
            /// <summary>The line comment token, like <c>// this is a comment</c></summary>
            abstract lineComment: string option with get, set
            /// <summary>The block comment character pair, like <c>/* block comment *&#47;</c></summary>
            abstract blockComment: CharacterPair option with get, set

        /// The language configuration interface defines the contract between extensions and
        /// various editor features, like automatic bracket insertion, automatic indentation etc.
        type [<AllowNullLiteral>] LanguageConfiguration =
            /// The language's comment settings.
            abstract comments: CommentRule option with get, set
            /// The language's brackets.
            /// This configuration implicitly affects pressing Enter around these brackets.
            abstract brackets: ResizeArray<CharacterPair> option with get, set
            /// The language's word definition.
            /// If the language supports Unicode identifiers (e.g. JavaScript), it is preferable
            /// to provide a word definition that uses exclusion of known separators.
            /// e.g.: A regex that matches anything except known separators (and dot is allowed to occur in a floating point number):
            ///    /(-?\d*\.\d\w*)|([^\`\~\!\@\#\%\^\&\*\(\)\-\=\+\[\{\]\}\\\|\;\:\'\"\,\.\<\>\/\?\s]+)/g
            abstract wordPattern: RegExp option with get, set
            /// The language's indentation settings.
            abstract indentationRules: IndentationRule option with get, set
            /// The language's rules to be evaluated when pressing Enter.
            abstract onEnterRules: ResizeArray<OnEnterRule> option with get, set
            /// The language's auto closing pairs. The 'close' character is automatically inserted with the
            /// 'open' character is typed. If not set, the configured brackets will be used.
            abstract autoClosingPairs: ResizeArray<IAutoClosingPairConditional> option with get, set
            /// The language's surrounding pairs. When the 'open' character is typed on a selection, the
            /// selected string is surrounded by the open and close characters. If not set, the autoclosing pairs
            /// settings will be used.
            abstract surroundingPairs: ResizeArray<IAutoClosingPair> option with get, set
            /// **Deprecated** Do not use.
            [<Obsolete("Will be replaced by a better API soon.")>]
            abstract __electricCharacterSupport: IBracketElectricCharacterContribution option with get, set

        /// Describes indentation rules for a language.
        type [<AllowNullLiteral>] IndentationRule =
            /// If a line matches this pattern, then all the lines after it should be unindendented once (until another rule matches).
            abstract decreaseIndentPattern: RegExp with get, set
            /// If a line matches this pattern, then all the lines after it should be indented once (until another rule matches).
            abstract increaseIndentPattern: RegExp with get, set
            /// If a line matches this pattern, then **only the next line** after it should be indented once.
            abstract indentNextLinePattern: RegExp option with get, set
            /// If a line matches this pattern, then its indentation should not be changed and it should not be evaluated against the other rules.
            abstract unIndentedLinePattern: RegExp option with get, set

        /// Describes a rule to be evaluated when pressing Enter.
        type [<AllowNullLiteral>] OnEnterRule =
            /// This rule will only execute if the text before the cursor matches this regular expression.
            abstract beforeText: RegExp with get, set
            /// This rule will only execute if the text after the cursor matches this regular expression.
            abstract afterText: RegExp option with get, set
            /// The action to execute.
            abstract action: EnterAction with get, set

        type [<AllowNullLiteral>] IBracketElectricCharacterContribution =
            abstract docComment: IDocComment option with get, set

        /// Definition of documentation comments (e.g. Javadoc/JSdoc)
        type [<AllowNullLiteral>] IDocComment =
            /// The string that starts a doc comment (e.g. '/**')
            abstract ``open``: string with get, set
            /// The string that appears on the last line and closes the doc comment (e.g. ' * /').
            abstract close: string with get, set

        /// A tuple of two characters, like a pair of
        /// opening and closing brackets.
        type CharacterPair =
            string * string

        type [<AllowNullLiteral>] IAutoClosingPair =
            abstract ``open``: string with get, set
            abstract close: string with get, set

        type [<AllowNullLiteral>] IAutoClosingPairConditional =
            inherit IAutoClosingPair
            abstract notIn: ResizeArray<string> option with get, set

        /// Describes what to do with the indentation when pressing Enter.
        type [<RequireQualifiedAccess>] IndentAction =
            /// Insert new line and copy the previous line's indentation.
            | None = 0
            /// Insert new line and indent once (relative to the previous line's indentation).
            | Indent = 1
            /// Insert two new lines:
            ///   - the first one indented which will hold the cursor
            ///   - the second one at the same indentation level
            | IndentOutdent = 2
            /// Insert new line and outdent once (relative to the previous line's indentation).
            | Outdent = 3

        /// Describes what to do when pressing Enter.
        type [<AllowNullLiteral>] EnterAction =
            /// Describe what to do with the indentation.
            abstract indentAction: IndentAction with get, set
            /// Describe whether to outdent current line.
            abstract outdentCurrentLine: bool option with get, set
            /// Describes text to be appended after the new line and after the indentation.
            abstract appendText: string option with get, set
            /// Describes the number of characters to remove from the new line's indentation.
            abstract removeText: float option with get, set

        /// The state of the tokenizer between two lines.
        /// It is useful to store flags such as in multiline comment, etc.
        /// The model will clone the previous line's state and pass it in to tokenize the next line.
        type [<AllowNullLiteral>] IState =
            abstract clone: unit -> IState
            abstract equals: other: IState -> bool

        /// A hover represents additional information for a symbol or word. Hovers are
        /// rendered in a tooltip-like widget.
        type [<AllowNullLiteral>] Hover =
            /// The contents of this hover.
            abstract contents: ResizeArray<MarkedString> with get, set
            /// The range to which this hover applies. When missing, the
            /// editor will use the range at the current position or the
            /// current position itself.
            abstract range: IRange with get, set

        /// <summary>
        /// The hover provider interface defines the contract between extensions and
        /// the <see href="https://code.visualstudio.com/docs/editor/intellisense">hover</see>-feature.
        /// </summary>
        type [<AllowNullLiteral>] HoverProvider =
            /// Provide a hover for the given position and document. Multiple hovers at the same
            /// position will be merged by the editor. A hover can have a range which defaults
            /// to the word range at the position when omitted.
            abstract provideHover: model: Editor.IReadOnlyModel * position: Position * token: CancellationToken -> U2<Hover, Thenable<Hover>>

        /// Represents a parameter of a callable-signature. A parameter can
        /// have a label and a doc-comment.
        type [<AllowNullLiteral>] ParameterInformation =
            /// The label of this signature. Will be shown in
            /// the UI.
            abstract label: string with get, set
            /// The human-readable doc-comment of this signature. Will be shown
            /// in the UI but can be omitted.
            abstract documentation: string option with get, set

        /// Represents the signature of something callable. A signature
        /// can have a label, like a function-name, a doc-comment, and
        /// a set of parameters.
        type [<AllowNullLiteral>] SignatureInformation =
            /// The label of this signature. Will be shown in
            /// the UI.
            abstract label: string with get, set
            /// The human-readable doc-comment of this signature. Will be shown
            /// in the UI but can be omitted.
            abstract documentation: string option with get, set
            /// The parameters of this signature.
            abstract parameters: ResizeArray<ParameterInformation> with get, set

        /// Signature help represents the signature of something
        /// callable. There can be multiple signatures but only one
        /// active and only one active parameter.
        type [<AllowNullLiteral>] SignatureHelp =
            /// One or more signatures.
            abstract signatures: ResizeArray<SignatureInformation> with get, set
            /// The active signature.
            abstract activeSignature: float with get, set
            /// The active parameter of the active signature.
            abstract activeParameter: float with get, set

        /// <summary>
        /// The signature help provider interface defines the contract between extensions and
        /// the <see href="https://code.visualstudio.com/docs/editor/intellisense">parameter hints</see>-feature.
        /// </summary>
        type [<AllowNullLiteral>] SignatureHelpProvider =
            abstract signatureHelpTriggerCharacters: ResizeArray<string> with get, set
            /// Provide help for the signature at the given position and document.
            abstract provideSignatureHelp: model: Editor.IReadOnlyModel * position: Position * token: CancellationToken -> U2<SignatureHelp, Thenable<SignatureHelp>>

        /// A document highlight kind.
        type [<RequireQualifiedAccess>] DocumentHighlightKind =
            /// A textual occurrence.
            | Text = 0
            /// Read-access of a symbol, like reading a variable.
            | Read = 1
            /// Write-access of a symbol, like writing to a variable.
            | Write = 2

        /// A document highlight is a range inside a text document which deserves
        /// special attention. Usually a document highlight is visualized by changing
        /// the background color of its range.
        type [<AllowNullLiteral>] DocumentHighlight =
            /// The range this highlight applies to.
            abstract range: IRange with get, set
            /// <summary>The highlight kind, default is <see cref="DocumentHighlightKind.Text">text</see>.</summary>
            abstract kind: DocumentHighlightKind with get, set

        /// The document highlight provider interface defines the contract between extensions and
        /// the word-highlight-feature.
        type [<AllowNullLiteral>] DocumentHighlightProvider =
            /// Provide a set of document highlights, like all occurrences of a variable or
            /// all exit-points of a function.
            abstract provideDocumentHighlights: model: Editor.IReadOnlyModel * position: Position * token: CancellationToken -> U2<ResizeArray<DocumentHighlight>, Thenable<ResizeArray<DocumentHighlight>>>

        /// Value-object that contains additional information when
        /// requesting references.
        type [<AllowNullLiteral>] ReferenceContext =
            /// Include the declaration of the current symbol.
            abstract includeDeclaration: bool with get, set

        /// <summary>
        /// The reference provider interface defines the contract between extensions and
        /// the <see href="https://code.visualstudio.com/docs/editor/editingevolved#_peek">find references</see>-feature.
        /// </summary>
        type [<AllowNullLiteral>] ReferenceProvider =
            /// Provide a set of project-wide references for the given position and document.
            abstract provideReferences: model: Editor.IReadOnlyModel * position: Position * context: ReferenceContext * token: CancellationToken -> U2<ResizeArray<Location>, Thenable<ResizeArray<Location>>>

        /// Represents a location inside a resource, such as a line
        /// inside a text file.
        type [<AllowNullLiteral>] Location =
            /// The resource identifier of this location.
            abstract uri: Uri with get, set
            /// The document range of this locations.
            abstract range: IRange with get, set

        /// <summary>
        /// The definition of a symbol represented as one or many <see cref="Location">locations</see>.
        /// For most programming languages there is only one location at which a symbol is
        /// defined.
        /// </summary>
        type Definition =
            U2<Location, ResizeArray<Location>>

        /// <summary>
        /// The definition provider interface defines the contract between extensions and
        /// the <see href="https://code.visualstudio.com/docs/editor/editingevolved#_go-to-definition">go to definition</see>
        /// and peek definition features.
        /// </summary>
        type [<AllowNullLiteral>] DefinitionProvider =
            /// Provide the definition of the symbol at the given position and document.
            abstract provideDefinition: model: Editor.IReadOnlyModel * position: Position * token: CancellationToken -> U2<Definition, Thenable<Definition>>

        /// The implementation provider interface defines the contract between extensions and
        /// the go to implementation feature.
        type [<AllowNullLiteral>] ImplementationProvider =
            /// Provide the implementation of the symbol at the given position and document.
            abstract provideImplementation: model: Editor.IReadOnlyModel * position: Position * token: CancellationToken -> U2<Definition, Thenable<Definition>>

        /// The type definition provider interface defines the contract between extensions and
        /// the go to type definition feature.
        type [<AllowNullLiteral>] TypeDefinitionProvider =
            /// Provide the type definition of the symbol at the given position and document.
            abstract provideTypeDefinition: model: Editor.IReadOnlyModel * position: Position * token: CancellationToken -> U2<Definition, Thenable<Definition>>

        /// A symbol kind.
        type [<RequireQualifiedAccess>] SymbolKind =
            | File = 0
            | Module = 1
            | Namespace = 2
            | Package = 3
            | Class = 4
            | Method = 5
            | Property = 6
            | Field = 7
            | Constructor = 8
            | Enum = 9
            | Interface = 10
            | Function = 11
            | Variable = 12
            | Constant = 13
            | String = 14
            | Number = 15
            | Boolean = 16
            | Array = 17
            | Object = 18
            | Key = 19
            | Null = 20
            | EnumMember = 21
            | Struct = 22
            | Event = 23
            | Operator = 24
            | TypeParameter = 25

        /// Represents information about programming constructs like variables, classes,
        /// interfaces etc.
        type [<AllowNullLiteral>] SymbolInformation =
            /// The name of this symbol.
            abstract name: string with get, set
            /// The name of the symbol containing this symbol.
            abstract containerName: string option with get, set
            /// The kind of this symbol.
            abstract kind: SymbolKind with get, set
            /// The location of this symbol.
            abstract location: Location with get, set

        /// <summary>
        /// The document symbol provider interface defines the contract between extensions and
        /// the <see href="https://code.visualstudio.com/docs/editor/editingevolved#_goto-symbol">go to symbol</see>-feature.
        /// </summary>
        type [<AllowNullLiteral>] DocumentSymbolProvider =
            /// Provide symbol information for the given document.
            abstract provideDocumentSymbols: model: Editor.IReadOnlyModel * token: CancellationToken -> U2<ResizeArray<SymbolInformation>, Thenable<ResizeArray<SymbolInformation>>>

        type [<AllowNullLiteral>] TextEdit =
            abstract range: IRange with get, set
            abstract text: string with get, set
            abstract eol: Editor.EndOfLineSequence option with get, set

        /// Interface used to format a model
        type [<AllowNullLiteral>] FormattingOptions =
            /// Size of a tab in spaces.
            abstract tabSize: float with get, set
            /// Prefer spaces over tabs.
            abstract insertSpaces: bool with get, set

        /// The document formatting provider interface defines the contract between extensions and
        /// the formatting-feature.
        type [<AllowNullLiteral>] DocumentFormattingEditProvider =
            /// Provide formatting edits for a whole document.
            abstract provideDocumentFormattingEdits: model: Editor.IReadOnlyModel * options: FormattingOptions * token: CancellationToken -> U2<ResizeArray<TextEdit>, Thenable<ResizeArray<TextEdit>>>

        /// The document formatting provider interface defines the contract between extensions and
        /// the formatting-feature.
        type [<AllowNullLiteral>] DocumentRangeFormattingEditProvider =
            /// Provide formatting edits for a range in a document.
            /// 
            /// The given range is a hint and providers can decide to format a smaller
            /// or larger range. Often this is done by adjusting the start and end
            /// of the range to full syntax nodes.
            abstract provideDocumentRangeFormattingEdits: model: Editor.IReadOnlyModel * range: Range * options: FormattingOptions * token: CancellationToken -> U2<ResizeArray<TextEdit>, Thenable<ResizeArray<TextEdit>>>

        /// The document formatting provider interface defines the contract between extensions and
        /// the formatting-feature.
        type [<AllowNullLiteral>] OnTypeFormattingEditProvider =
            abstract autoFormatTriggerCharacters: ResizeArray<string> with get, set
            /// <summary>
            /// Provide formatting edits after a character has been typed.
            /// 
            /// The given position and character should hint to the provider
            /// what range the position to expand to, like find the matching <c>{</c>
            /// when <c>}</c> has been entered.
            /// </summary>
            abstract provideOnTypeFormattingEdits: model: Editor.IReadOnlyModel * position: Position * ch: string * options: FormattingOptions * token: CancellationToken -> U2<ResizeArray<TextEdit>, Thenable<ResizeArray<TextEdit>>>

        /// A link inside the editor.
        type [<AllowNullLiteral>] ILink =
            abstract range: IRange with get, set
            abstract url: string with get, set

        /// A provider of links.
        type [<AllowNullLiteral>] LinkProvider =
            abstract provideLinks: model: Editor.IReadOnlyModel * token: CancellationToken -> U2<ResizeArray<ILink>, Thenable<ResizeArray<ILink>>>
            abstract resolveLink: (ILink -> CancellationToken -> U2<ILink, Thenable<ILink>>) option with get, set

        type [<AllowNullLiteral>] IResourceEdit =
            abstract resource: Uri with get, set
            abstract range: IRange with get, set
            abstract newText: string with get, set

        type [<AllowNullLiteral>] WorkspaceEdit =
            abstract edits: ResizeArray<IResourceEdit> with get, set
            abstract rejectReason: string option with get, set

        type [<AllowNullLiteral>] RenameProvider =
            abstract provideRenameEdits: model: Editor.IReadOnlyModel * position: Position * newName: string * token: CancellationToken -> U2<WorkspaceEdit, Thenable<WorkspaceEdit>>

        type [<AllowNullLiteral>] Command =
            abstract id: string with get, set
            abstract title: string with get, set
            abstract tooltip: string option with get, set
            abstract arguments: ResizeArray<obj option> option with get, set

        type [<AllowNullLiteral>] ICodeLensSymbol =
            abstract range: IRange with get, set
            abstract id: string option with get, set
            abstract command: Command option with get, set

        type [<AllowNullLiteral>] CodeLensProvider =
            abstract onDidChange: IEvent<CodeLensProvider> option with get, set
            abstract provideCodeLenses: model: Editor.IReadOnlyModel * token: CancellationToken -> U2<ResizeArray<ICodeLensSymbol>, Thenable<ResizeArray<ICodeLensSymbol>>>
            abstract resolveCodeLens: model: Editor.IReadOnlyModel * codeLens: ICodeLensSymbol * token: CancellationToken -> U2<ICodeLensSymbol, Thenable<ICodeLensSymbol>>

        type [<AllowNullLiteral>] ILanguageExtensionPoint =
            abstract id: string with get, set
            abstract extensions: ResizeArray<string> option with get, set
            abstract filenames: ResizeArray<string> option with get, set
            abstract filenamePatterns: ResizeArray<string> option with get, set
            abstract firstLine: string option with get, set
            abstract aliases: ResizeArray<string> option with get, set
            abstract mimetypes: ResizeArray<string> option with get, set
            abstract configuration: string option with get, set

        /// A Monarch language definition
        type [<AllowNullLiteral>] IMonarchLanguage =
            /// map from string to ILanguageRule[]
            abstract tokenizer: IMonarchLanguageTokenizer with get, set
            /// is the language case insensitive?
            abstract ignoreCase: bool option with get, set
            /// if no match in the tokenizer assign this token class (default 'source')
            abstract defaultToken: string option with get, set
            /// for example [['{','}','delimiter.curly']]
            abstract brackets: ResizeArray<IMonarchLanguageBracket> option with get, set
            /// start symbol in the tokenizer (by default the first entry is used)
            abstract start: string option with get, set
            /// attach this to every token class (by default '.' + name)
            abstract tokenPostfix: string with get, set

        /// A rule is either a regular expression and an action
        ///  		shorthands: [reg,act] == { regex: reg, action: act}
        /// 		and       : [reg,act,nxt] == { regex: reg, action: act{ next: nxt }}
        type [<AllowNullLiteral>] IMonarchLanguageRule =
            /// match tokens
            abstract regex: U2<string, RegExp> option with get, set
            /// action to take on match
            abstract action: IMonarchLanguageAction option with get, set
            /// or an include rule. include all rules from the included state
            abstract ``include``: string option with get, set

        /// An action is either an array of actions...
        /// ... or a case statement with guards...
        /// ... or a basic action with a token value.
        type [<AllowNullLiteral>] IMonarchLanguageAction =
            /// array of actions for each parenthesized match group
            abstract group: ResizeArray<IMonarchLanguageAction> option with get, set
            /// map from string to ILanguageAction
            abstract cases: Object option with get, set
            /// token class (ie. css class) (or "@brackets" or "@rematch")
            abstract token: string option with get, set
            /// the next state to push, or "@push", "@pop", "@popall"
            abstract next: string option with get, set
            /// switch to this state
            abstract switchTo: string option with get, set
            /// go back n characters in the stream
            abstract goBack: float option with get, set
            abstract bracket: string option with get, set
            /// switch to embedded language (useing the mimetype) or get out using "@pop"
            abstract nextEmbedded: string option with get, set
            /// log a message to the browser console window
            abstract log: string option with get, set

        /// This interface can be shortened as an array, ie. ['{','}','delimiter.curly']
        type [<AllowNullLiteral>] IMonarchLanguageBracket =
            /// open bracket
            abstract ``open``: string with get, set
            /// closeing bracket
            abstract close: string with get, set
            /// token class
            abstract token: string with get, set

        module Typescript =

            type [<AllowNullLiteral>] IExports =
                abstract typescriptDefaults: LanguageServiceDefaults
                abstract javascriptDefaults: LanguageServiceDefaults
                abstract getTypeScriptWorker: (unit -> Monaco.Promise<obj option>)
                abstract getJavaScriptWorker: (unit -> Monaco.Promise<obj option>)

            type [<RequireQualifiedAccess>] ModuleKind =
                | None = 0
                | CommonJS = 1
                | AMD = 2
                | UMD = 3
                | System = 4
                | ES2015 = 5

            type [<RequireQualifiedAccess>] JsxEmit =
                | None = 0
                | Preserve = 1
                | React = 2

            type [<RequireQualifiedAccess>] NewLineKind =
                | CarriageReturnLineFeed = 0
                | LineFeed = 1

            type [<RequireQualifiedAccess>] ScriptTarget =
                | ES3 = 0
                | ES5 = 1
                | ES2015 = 2
                | ES2016 = 3
                | ES2017 = 4
                | ESNext = 5
                | Latest = 5

            type [<RequireQualifiedAccess>] ModuleResolutionKind =
                | Classic = 1
                | NodeJs = 2

            type CompilerOptionsValue =
                U5<string, float, bool, ResizeArray<U2<string, float>>, ResizeArray<string>>

            type [<AllowNullLiteral>] CompilerOptions =
                abstract allowJs: bool option with get, set
                abstract allowSyntheticDefaultImports: bool option with get, set
                abstract allowUnreachableCode: bool option with get, set
                abstract allowUnusedLabels: bool option with get, set
                abstract alwaysStrict: bool option with get, set
                abstract baseUrl: string option with get, set
                abstract charset: string option with get, set
                abstract declaration: bool option with get, set
                abstract declarationDir: string option with get, set
                abstract disableSizeLimit: bool option with get, set
                abstract emitBOM: bool option with get, set
                abstract emitDecoratorMetadata: bool option with get, set
                abstract experimentalDecorators: bool option with get, set
                abstract forceConsistentCasingInFileNames: bool option with get, set
                abstract importHelpers: bool option with get, set
                abstract inlineSourceMap: bool option with get, set
                abstract inlineSources: bool option with get, set
                abstract isolatedModules: bool option with get, set
                abstract jsx: JsxEmit option with get, set
                abstract lib: ResizeArray<string> option with get, set
                abstract locale: string option with get, set
                abstract mapRoot: string option with get, set
                abstract maxNodeModuleJsDepth: float option with get, set
                abstract ``module``: ModuleKind option with get, set
                abstract moduleResolution: ModuleResolutionKind option with get, set
                abstract newLine: NewLineKind option with get, set
                abstract noEmit: bool option with get, set
                abstract noEmitHelpers: bool option with get, set
                abstract noEmitOnError: bool option with get, set
                abstract noErrorTruncation: bool option with get, set
                abstract noFallthroughCasesInSwitch: bool option with get, set
                abstract noImplicitAny: bool option with get, set
                abstract noImplicitReturns: bool option with get, set
                abstract noImplicitThis: bool option with get, set
                abstract noUnusedLocals: bool option with get, set
                abstract noUnusedParameters: bool option with get, set
                abstract noImplicitUseStrict: bool option with get, set
                abstract noLib: bool option with get, set
                abstract noResolve: bool option with get, set
                abstract out: string option with get, set
                abstract outDir: string option with get, set
                abstract outFile: string option with get, set
                abstract preserveConstEnums: bool option with get, set
                abstract project: string option with get, set
                abstract reactNamespace: string option with get, set
                abstract jsxFactory: string option with get, set
                abstract removeComments: bool option with get, set
                abstract rootDir: string option with get, set
                abstract rootDirs: ResizeArray<string> option with get, set
                abstract skipLibCheck: bool option with get, set
                abstract skipDefaultLibCheck: bool option with get, set
                abstract sourceMap: bool option with get, set
                abstract sourceRoot: string option with get, set
                abstract strictNullChecks: bool option with get, set
                abstract suppressExcessPropertyErrors: bool option with get, set
                abstract suppressImplicitAnyIndexErrors: bool option with get, set
                abstract target: ScriptTarget option with get, set
                abstract traceResolution: bool option with get, set
                abstract types: ResizeArray<string> option with get, set
                /// Paths used to compute primary types search locations
                abstract typeRoots: ResizeArray<string> option with get, set
                [<EmitIndexer>] abstract Item: option: string -> CompilerOptionsValue option with get, set

            type [<AllowNullLiteral>] DiagnosticsOptions =
                abstract noSemanticValidation: bool option with get, set
                abstract noSyntaxValidation: bool option with get, set

            type [<AllowNullLiteral>] LanguageServiceDefaults =
                /// <summary>
                /// Add an additional source file to the language service. Use this
                /// for typescript (definition) files that won't be loaded as editor
                /// document, like <c>jquery.d.ts</c>.
                /// </summary>
                /// <param name="content">The file content</param>
                /// <param name="filePath">An optional file path</param>
                /// <returns>
                /// A disposabled which will remove the file from the
                /// language service upon disposal.
                /// </returns>
                abstract addExtraLib: content: string * ?filePath: string -> IDisposable
                /// Set TypeScript compiler options.
                abstract setCompilerOptions: options: CompilerOptions -> unit
                /// Configure whether syntactic and/or semantic validation should
                /// be performed
                abstract setDiagnosticsOptions: options: DiagnosticsOptions -> unit
                /// <summary>Configure when the worker shuts down. By default that is 2mins.</summary>
                /// <param name="value">
                /// The maximun idle time in milliseconds. Values less than one
                /// mean never shut down.
                /// </param>
                abstract setMaximunWorkerIdleTime: value: float -> unit
                /// Configure if all existing models should be eagerly sync'd
                /// to the worker on start or restart.
                abstract setEagerModelSync: value: bool -> unit

        module Css =

            type [<AllowNullLiteral>] IExports =
                abstract cssDefaults: LanguageServiceDefaults
                abstract lessDefaults: LanguageServiceDefaults
                abstract scssDefaults: LanguageServiceDefaults

            type [<AllowNullLiteral>] DiagnosticsOptions =
                abstract validate: bool option
                abstract lint: DiagnosticsOptionsLint option

            type [<AllowNullLiteral>] LanguageServiceDefaults =
                abstract onDidChange: IEvent<LanguageServiceDefaults>
                abstract diagnosticsOptions: DiagnosticsOptions
                abstract setDiagnosticsOptions: options: DiagnosticsOptions -> unit

            type [<StringEnum>] [<RequireQualifiedAccess>] DiagnosticsOptionsLintCompatibleVendorPrefixes =
                | Ignore
                | Warning
                | Error

            type [<AllowNullLiteral>] DiagnosticsOptionsLint =
                abstract compatibleVendorPrefixes: DiagnosticsOptionsLintCompatibleVendorPrefixes option
                abstract vendorPrefix: DiagnosticsOptionsLintCompatibleVendorPrefixes option
                abstract duplicateProperties: DiagnosticsOptionsLintCompatibleVendorPrefixes option
                abstract emptyRules: DiagnosticsOptionsLintCompatibleVendorPrefixes option
                abstract importStatement: DiagnosticsOptionsLintCompatibleVendorPrefixes option
                abstract boxModel: DiagnosticsOptionsLintCompatibleVendorPrefixes option
                abstract universalSelector: DiagnosticsOptionsLintCompatibleVendorPrefixes option
                abstract zeroUnits: DiagnosticsOptionsLintCompatibleVendorPrefixes option
                abstract fontFaceProperties: DiagnosticsOptionsLintCompatibleVendorPrefixes option
                abstract hexColorLength: DiagnosticsOptionsLintCompatibleVendorPrefixes option
                abstract argumentsInColorFunction: DiagnosticsOptionsLintCompatibleVendorPrefixes option
                abstract unknownProperties: DiagnosticsOptionsLintCompatibleVendorPrefixes option
                abstract ieHack: DiagnosticsOptionsLintCompatibleVendorPrefixes option
                abstract unknownVendorSpecificProperties: DiagnosticsOptionsLintCompatibleVendorPrefixes option
                abstract propertyIgnoredDueToDisplay: DiagnosticsOptionsLintCompatibleVendorPrefixes option
                abstract important: DiagnosticsOptionsLintCompatibleVendorPrefixes option
                abstract float: DiagnosticsOptionsLintCompatibleVendorPrefixes option
                abstract idSelector: DiagnosticsOptionsLintCompatibleVendorPrefixes option

        module Json =

            type [<AllowNullLiteral>] IExports =
                abstract jsonDefaults: LanguageServiceDefaults

            type [<AllowNullLiteral>] DiagnosticsOptions =
                /// If set, the validator will be enabled and perform syntax validation as well as schema based validation.
                abstract validate: bool option
                /// If set, comments are tolerated. If set to false, syntax errors will be emmited for comments.
                abstract allowComments: bool option
                /// A list of known schemas and/or associations of schemas to file names.
                abstract schemas: ResizeArray<DiagnosticsOptionsSchemas> option

            type [<AllowNullLiteral>] LanguageServiceDefaults =
                abstract onDidChange: IEvent<LanguageServiceDefaults>
                abstract diagnosticsOptions: DiagnosticsOptions
                abstract setDiagnosticsOptions: options: DiagnosticsOptions -> unit

            type [<AllowNullLiteral>] DiagnosticsOptionsSchemas =
                /// The URI of the schema, which is also the identifier of the schema.
                abstract uri: string
                /// A list of file names that are associated to the schema. The '*' wildcard can be used. For example '*.schema.json', 'package.json'
                abstract fileMatch: ResizeArray<string> option
                /// The schema for the given URI.
                abstract schema: obj option

        module Html =

            type [<AllowNullLiteral>] IExports =
                abstract htmlDefaults: LanguageServiceDefaults
                abstract handlebarDefaults: LanguageServiceDefaults
                abstract razorDefaults: LanguageServiceDefaults

            type [<AllowNullLiteral>] HTMLFormatConfiguration =
                abstract tabSize: float
                abstract insertSpaces: bool
                abstract wrapLineLength: float
                abstract unformatted: string
                abstract contentUnformatted: string
                abstract indentInnerHtml: bool
                abstract preserveNewLines: bool
                abstract maxPreserveNewLines: float
                abstract indentHandlebars: bool
                abstract endWithNewline: bool
                abstract extraLiners: string
                abstract wrapAttributes: HTMLFormatConfigurationWrapAttributes

            type [<AllowNullLiteral>] CompletionConfiguration =
                [<EmitIndexer>] abstract Item: provider: string -> bool with get, set

            type [<AllowNullLiteral>] Options =
                /// If set, comments are tolerated. If set to false, syntax errors will be emmited for comments.
                abstract format: HTMLFormatConfiguration option
                /// A list of known schemas and/or associations of schemas to file names.
                abstract suggest: CompletionConfiguration option

            type [<AllowNullLiteral>] LanguageServiceDefaults =
                abstract onDidChange: IEvent<LanguageServiceDefaults>
                abstract options: Options
                abstract setOptions: options: Options -> unit

            type [<StringEnum>] [<RequireQualifiedAccess>] HTMLFormatConfigurationWrapAttributes =
                | Auto
                | Force
                | [<CompiledName "force-aligned">] ForceAligned
                | [<CompiledName "force-expand-multiline">] ForceExpandMultiline

        type [<AllowNullLiteral>] IMonarchLanguageTokenizer =
            [<EmitIndexer>] abstract Item: name: string -> ResizeArray<IMonarchLanguageRule> with get, set

    module Worker =

        type [<AllowNullLiteral>] IMirrorModel =
            abstract uri: Uri
            abstract version: float
            abstract getValue: unit -> string

        type [<AllowNullLiteral>] IWorkerContext =
            /// Get all available mirror models in this worker.
            abstract getMirrorModels: unit -> ResizeArray<IMirrorModel>

    type [<AllowNullLiteral>] PromiseStaticJoinPromise<'ValueType> =
        [<EmitIndexer>] abstract Item: n: string -> 'ValueType with get, set

    type [<AllowNullLiteral>] PromiseStaticAnyPromise<'ValueType> =
        abstract key: string with get, set
        abstract value: Promise<'ValueType> with get, set

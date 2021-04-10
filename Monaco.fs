// ts2fable 0.0.0
module rec Monaco
open System
open Fable.Core
open Fable.Core.JS
open Browser.Types

type Array<'T> = System.Collections.Generic.IList<'T>
type PromiseLike<'T> = Fable.Core.JS.Promise<'T>
type ReadonlyArray<'T> = System.Collections.Generic.IReadOnlyList<'T>
type RegExp = System.Text.RegularExpressions.Regex

let [<Import("MonacoEnvironment","monaco-editor")>] MonacoEnvironment: Monaco.Environment option = jsNative

module Monaco =
    let [<Import("editor","monaco-editor/monaco")>] editor: Editor.IExports = jsNative
    let [<Import("languages","monaco-editor/monaco")>] languages: Languages.IExports = jsNative

    type [<AllowNullLiteral>] IExports =
        /// A helper that allows to emit and listen to typed events
        abstract Emitter: EmitterStatic
        abstract CancellationTokenSource: CancellationTokenSourceStatic
        /// <summary>
        /// Uniform Resource Identifier (Uri) <see href="http://tools.ietf.org/html/rfc3986." />
        /// This class is a simple parser which creates the basic component parts
        /// (<see href="http://tools.ietf.org/html/rfc3986#section-3)" /> with minimal validation
        /// and encoding.
        /// 
        /// <code language="txt">
        ///        foo://example.com:8042/over/there?name=ferret#nose
        ///        \_/   \______________/\_________/ \_________/ \__/
        ///         |           |            |            |        |
        ///      scheme     authority       path        query   fragment
        ///         |   _____________________|__
        ///        / \ /                        \
        ///        urn:example:animal:ferret:nose
        /// </code>
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

    type Thenable<'T> =
        PromiseLike<'T>

    type [<AllowNullLiteral>] Environment =
        abstract baseUrl: string option with get, set
        abstract getWorker: workerId: string * label: string -> Worker
        abstract getWorkerUrl: workerId: string * label: string -> string

    type [<AllowNullLiteral>] IDisposable =
        abstract dispose: unit -> unit

    type [<AllowNullLiteral>] IEvent<'T> =
        [<Emit "$0($1...)">] abstract Invoke: listener: ('T -> obj option) * ?thisArg: obj -> IDisposable

    /// A helper that allows to emit and listen to typed events
    type [<AllowNullLiteral>] Emitter<'T> =
        abstract ``event``: IEvent<'T>
        abstract fire: ``event``: 'T -> unit
        abstract dispose: unit -> unit

    /// A helper that allows to emit and listen to typed events
    type [<AllowNullLiteral>] EmitterStatic =
        [<EmitConstructor>] abstract Create: unit -> Emitter<'T>

    type [<RequireQualifiedAccess>] MarkerTag =
        | Unnecessary = 1
        | Deprecated = 2

    type [<RequireQualifiedAccess>] MarkerSeverity =
        | Hint = 1
        | Info = 2
        | Warning = 4
        | Error = 8

    type [<AllowNullLiteral>] CancellationTokenSource =
        abstract token: CancellationToken
        abstract cancel: unit -> unit
        abstract dispose: ?cancel: bool -> unit

    type [<AllowNullLiteral>] CancellationTokenSourceStatic =
        [<EmitConstructor>] abstract Create: ?parent: CancellationToken -> CancellationTokenSource

    type [<AllowNullLiteral>] CancellationToken =
        /// A flag signalling is cancellation has been requested.
        abstract isCancellationRequested: bool
        /// <summary>
        /// An event which fires when cancellation is requested. This event
        /// only ever fires <c>once</c> as cancellation can only happen once. Listeners
        /// that are registered after cancellation will be called (next event loop run),
        /// but also only once.
        /// </summary>
        abstract onCancellationRequested: ((obj option -> obj option) -> obj -> ResizeArray<IDisposable> -> IDisposable)

    /// <summary>
    /// Uniform Resource Identifier (Uri) <see href="http://tools.ietf.org/html/rfc3986." />
    /// This class is a simple parser which creates the basic component parts
    /// (<see href="http://tools.ietf.org/html/rfc3986#section-3)" /> with minimal validation
    /// and encoding.
    /// 
    /// <code language="txt">
    ///        foo://example.com:8042/over/there?name=ferret#nose
    ///        \_/   \______________/\_________/ \_________/ \__/
    ///         |           |            |            |        |
    ///      scheme     authority       path        query   fragment
    ///         |   _____________________|__
    ///        / \ /                        \
    ///        urn:example:animal:ferret:nose
    /// </code>
    /// </summary>
    type [<AllowNullLiteral>] Uri =
        inherit UriComponents
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
        /// <summary>
        /// Returns a string representing the corresponding file system path of this Uri.
        /// Will handle UNC paths, normalizes windows drive letters to lower-case, and uses the
        /// platform specific path separator.
        /// 
        /// * Will *not* validate the path for invalid characters and semantics.
        /// * Will *not* look at the scheme of this Uri.
        /// * The result shall *not* be used for display purposes but for accessing a file on disk.
        /// 
        /// 
        /// The *difference* to <c>Uri#path</c> is the use of the platform specific separator and the handling
        /// of UNC paths. See the below sample of a file-uri with an authority (UNC path).
        /// 
        /// <code language="ts">
        ///   const u = Uri.parse('file://server/c$/folder/file.txt')
        ///   u.authority === 'server'
        ///   u.path === '/shares/c$/file.txt'
        ///   u.fsPath === '\\server\c$\folder\file.txt'
        /// </code>
        /// 
        /// Using <c>Uri#path</c> to read a file (using fs-apis) would not be enough because parts of the path,
        /// namely the server name, would be missing. Therefore <c>Uri#fsPath</c> exists - it's sugar to ease working
        /// with URIs that represent files on disk (<c>file</c> scheme).
        /// </summary>
        abstract fsPath: string
        abstract ``with``: change: UriWithChange -> Uri
        /// <summary>
        /// Creates a string representation for this Uri. It's guaranteed that calling
        /// <c>Uri.parse</c> with the result of this function creates an Uri which is equal
        /// to this Uri.
        /// 
        /// * The result shall *not* be used for display purposes but for externalization or transport.
        /// * The result will be encoded using the percentage encoding and encoding happens mostly
        /// ignore the scheme-specific encoding rules.
        /// </summary>
        /// <param name="skipEncoding">Do not encode the result, default is <c>false</c></param>
        abstract toString: ?skipEncoding: bool -> string
        abstract toJSON: unit -> UriComponents

    type [<AllowNullLiteral>] UriWithChange =
        abstract scheme: string option with get, set
        abstract authority: string option with get, set
        abstract path: string option with get, set
        abstract query: string option with get, set
        abstract fragment: string option with get, set

    /// <summary>
    /// Uniform Resource Identifier (Uri) <see href="http://tools.ietf.org/html/rfc3986." />
    /// This class is a simple parser which creates the basic component parts
    /// (<see href="http://tools.ietf.org/html/rfc3986#section-3)" /> with minimal validation
    /// and encoding.
    /// 
    /// <code language="txt">
    ///        foo://example.com:8042/over/there?name=ferret#nose
    ///        \_/   \______________/\_________/ \_________/ \__/
    ///         |           |            |            |        |
    ///      scheme     authority       path        query   fragment
    ///         |   _____________________|__
    ///        / \ /                        \
    ///        urn:example:animal:ferret:nose
    /// </code>
    /// </summary>
    type [<AllowNullLiteral>] UriStatic =
        [<EmitConstructor>] abstract Create: unit -> Uri
        abstract isUri: thing: obj option -> bool
        /// <summary>
        /// Creates a new Uri from a string, e.g. <c>http://www.msft.com/some/path</c>,
        /// <c>file:///usr/home</c>, or <c>scheme:with/path</c>.
        /// </summary>
        /// <param name="value">A string which represents an Uri (see <c>Uri#toString</c>).</param>
        abstract parse: value: string * ?_strict: bool -> Uri
        /// <summary>
        /// Creates a new Uri from a file system path, e.g. <c>c:\my\files</c>,
        /// <c>/usr/home</c>, or <c>\\server\share\some\path</c>.
        /// 
        /// The *difference* between <c>Uri#parse</c> and <c>Uri#file</c> is that the latter treats the argument
        /// as path, not as stringified-uri. E.g. <c>Uri.file(path)</c> is **not the same as**
        /// <c>Uri.parse('file://' + path)</c> because the path might contain characters that are
        /// interpreted (# and ?). See the following sample:
        /// <code language="ts">
        /// const good = Uri.file('/coding/c#/project1');
        /// good.scheme === 'file';
        /// good.path === '/coding/c#/project1';
        /// good.fragment === '';
        /// const bad = Uri.parse('file://' + '/coding/c#/project1');
        /// bad.scheme === 'file';
        /// bad.path === '/coding/c'; // path is now broken
        /// bad.fragment === '/project1';
        /// </code>
        /// </summary>
        /// <param name="path">A file system path (see <c>Uri#fsPath</c>)</param>
        abstract file: path: string -> Uri
        abstract from: components: UriStaticFromComponents -> Uri
        /// <summary>Join a Uri path with path fragments and normalizes the resulting path.</summary>
        /// <param name="uri">The input Uri.</param>
        /// <param name="pathFragment">The path fragment to add to the Uri path.</param>
        /// <returns>The resulting Uri.</returns>
        abstract joinPath: uri: Uri * [<ParamArray>] pathFragment: string[] -> Uri
        abstract revive: data: U2<UriComponents, Uri> -> Uri
        abstract revive: data: U2<UriComponents, Uri> option -> Uri option

    type [<AllowNullLiteral>] UriStaticFromComponents =
        abstract scheme: string with get, set
        abstract authority: string option with get, set
        abstract path: string option with get, set
        abstract query: string option with get, set
        abstract fragment: string option with get, set

    type [<AllowNullLiteral>] UriComponents =
        abstract scheme: string with get, set
        abstract authority: string with get, set
        abstract path: string with get, set
        abstract query: string with get, set
        abstract fragment: string with get, set

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

    type [<AllowNullLiteral>] IMarkdownString =
        abstract value: string
        abstract isTrusted: bool option
        abstract supportThemeIcons: bool option
        abstract uris: {| Item: UriComponents |} option with get, set

    type [<AllowNullLiteral>] IKeyboardEvent =
        abstract _standardKeyboardEventBrand: obj
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
        abstract buttons: float
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
        /// <summary>Create a new position from this position.</summary>
        /// <param name="newLineNumber">new line number</param>
        /// <param name="newColumn">new column</param>
        abstract ``with``: ?newLineNumber: float * ?newColumn: float -> Position
        /// <summary>Derive a new position from this position.</summary>
        /// <param name="deltaLineNumber">line number delta</param>
        /// <param name="deltaColumn">column delta</param>
        abstract delta: ?deltaLineNumber: float * ?deltaColumn: float -> Position
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
        abstract equals: a: IPosition option * b: IPosition option -> bool
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
        /// <summary>Test if <c>range</c> is strictly in this range. <c>range</c> must start after and end before this range for the result to be true.</summary>
        abstract strictContainsRange: range: IRange -> bool
        /// A reunion of the two ranges.
        /// The smallest position will be used as the start point, and the largest one as the end point.
        abstract plusRange: range: IRange -> Range
        /// A intersection of the two ranges.
        abstract intersectRanges: range: IRange -> Range option
        /// Test if this range equals other.
        abstract equalsRange: other: IRange option -> bool
        /// Return the end position (which will be after or equal to the start position)
        abstract getEndPosition: unit -> Position
        /// Return the start position (which will be before or equal to the end position)
        abstract getStartPosition: unit -> Position
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
        /// <summary>Test if <c>otherRange</c> is strinctly in <c>range</c> (must start after, and end before). If the ranges are equal, will return false.</summary>
        abstract strictContainsRange: range: IRange * otherRange: IRange -> bool
        /// A reunion of the two ranges.
        /// The smallest position will be used as the start point, and the largest one as the end point.
        abstract plusRange: a: IRange * b: IRange -> Range
        /// A intersection of the two ranges.
        abstract intersectRanges: a: IRange * b: IRange -> Range option
        /// <summary>Test if range <c>a</c> equals <c>b</c>.</summary>
        abstract equalsRange: a: IRange option * b: IRange option -> bool
        /// Return the end position (which will be after or equal to the start position)
        abstract getEndPosition: range: IRange -> Position
        /// Return the start position (which will be before or equal to the end position)
        abstract getStartPosition: range: IRange -> Position
        /// Create a new empty range using this range's start position.
        abstract collapseToStart: range: IRange -> Range
        abstract fromPositions: start: IPosition * ?``end``: IPosition -> Range
        /// <summary>Create a <c>Range</c> from an <c>IRange</c>.</summary>
        abstract lift: range: obj -> obj
        abstract lift: range: IRange -> Range
        /// <summary>Test if <c>obj</c> is an <c>IRange</c>.</summary>
        abstract isIRange: obj: obj option -> bool
        /// Test if the two ranges are touching in any way.
        abstract areIntersectingOrTouching: a: IRange * b: IRange -> bool
        /// Test if the two ranges are intersecting. If the ranges are touching it returns true.
        abstract areIntersecting: a: IRange * b: IRange -> bool
        /// A function that compares ranges, useful for sorting ranges
        /// It will first compare ranges on the startPosition and then on the endPosition
        abstract compareRangesUsingStarts: a: IRange option * b: IRange option -> float
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
            abstract create: domElement: HTMLElement * ?options: IStandaloneEditorConstructionOptions * ?``override``: IEditorOverrideServices -> IStandaloneCodeEditor
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
            abstract createModel: value: string * ?language: string * ?uri: Uri -> ITextModel
            /// Change the language for a model.
            abstract setModelLanguage: model: ITextModel * languageId: string -> unit
            /// Set the markers for a model.
            abstract setModelMarkers: model: ITextModel * owner: string * markers: ResizeArray<IMarkerData> -> unit
            /// <summary>Get markers for owner and/or resource</summary>
            /// <returns>list of markers</returns>
            abstract getModelMarkers: filter: {| owner: string option; resource: Uri option; take: float option |} -> ResizeArray<IMarker>
            /// <summary>Get the model that has <c>uri</c> if it exists.</summary>
            abstract getModel: uri: Uri -> ITextModel option
            /// Get all the created models.
            abstract getModels: unit -> ResizeArray<ITextModel>
            /// <summary>Emitted when a model is created.</summary>
            abstract onDidCreateModel: listener: (ITextModel -> unit) -> IDisposable
            /// <summary>Emitted right before a model is disposed.</summary>
            abstract onWillDisposeModel: listener: (ITextModel -> unit) -> IDisposable
            /// <summary>Emitted when a different language is set to a model.</summary>
            abstract onDidChangeModelLanguage: listener: ({| model: ITextModel; oldLanguage: string |} -> unit) -> IDisposable
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
            abstract colorizeModelLine: model: ITextModel * lineNumber: float * ?tabSize: float -> string
            /// <summary>Tokenize <c>text</c> using language <c>languageId</c></summary>
            abstract tokenize: text: string * languageId: string -> ResizeArray<ResizeArray<Token>>
            /// Define a new theme or update an existing theme.
            abstract defineTheme: themeName: string * themeData: IStandaloneThemeData -> unit
            /// Switches to a theme.
            abstract setTheme: themeName: string -> unit
            /// Clears all cached font measurements and triggers re-measurement.
            abstract remeasureFonts: unit -> unit
            abstract TextModelResolvedOptions: TextModelResolvedOptionsStatic
            abstract FindMatch: FindMatchStatic
            /// <summary>The type of the <c>IEditor</c>.</summary>
            abstract EditorType: {| ICodeEditor: string; IDiffEditor: string |}
            /// An event describing that the configuration of the editor has changed.
            abstract ConfigurationChangedEvent: ConfigurationChangedEventStatic
            abstract EditorOptions: IExportsEditorOptions
            abstract FontInfo: FontInfoStatic
            abstract BareFontInfo: BareFontInfoStatic

        type [<AllowNullLiteral>] IDiffNavigator =
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
            abstract encodedTokensColors: ResizeArray<string> option with get, set
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
            /// An object that can be used by the web worker to make calls back to the main thread.
            abstract host: obj option with get, set
            /// Keep idle models.
            /// Defaults to false, which means that idle models will stop syncing after a while.
            abstract keepIdleModels: bool option with get, set

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
            /// <param name="editor">The editor instance is passed in as a convenience</param>
            abstract run: editor: ICodeEditor * [<ParamArray>] args: obj option[] -> U2<unit, Promise<unit>>

        /// Options which apply for all editors.
        type [<AllowNullLiteral>] IGlobalEditorOptions =
            /// <summary>
            /// The number of spaces a tab is equal to.
            /// This setting is overridden based on the file contents when <c>detectIndentation</c> is on.
            /// Defaults to 4.
            /// </summary>
            abstract tabSize: float option with get, set
            /// <summary>
            /// Insert spaces when pressing <c>Tab</c>.
            /// This setting is overridden based on the file contents when <c>detectIndentation</c> is on.
            /// Defaults to true.
            /// </summary>
            abstract insertSpaces: bool option with get, set
            /// <summary>
            /// Controls whether <c>tabSize</c> and <c>insertSpaces</c> will be automatically detected when a file is opened based on the file contents.
            /// Defaults to true.
            /// </summary>
            abstract detectIndentation: bool option with get, set
            /// Remove trailing auto inserted whitespace.
            /// Defaults to true.
            abstract trimAutoWhitespace: bool option with get, set
            /// Special handling for large files to disable certain memory intensive features.
            /// Defaults to true.
            abstract largeFileOptimizations: bool option with get, set
            /// Controls whether completions should be computed based on words in the document.
            /// Defaults to true.
            abstract wordBasedSuggestions: bool option with get, set
            /// Controls whether the semanticHighlighting is shown for the languages that support it.
            /// true: semanticHighlighting is enabled for all themes
            /// false: semanticHighlighting is disabled for all themes
            /// 'configuredByTheme': semanticHighlighting is controlled by the current color theme's semanticHighlighting setting.
            /// Defaults to 'byTheme'.
            abstract ``semanticHighlighting.enabled``: IGlobalEditorOptionsSemanticHighlightingEnabled option with get, set
            /// <summary>
            /// Keep peek editors open even when double clicking their content or when hitting <c>Escape</c>.
            /// Defaults to false.
            /// </summary>
            abstract stablePeek: bool option with get, set
            /// Lines above this length will not be tokenized for performance reasons.
            /// Defaults to 20000.
            abstract maxTokenizationLineLength: float option with get, set
            /// <summary>
            /// Theme to be used for rendering.
            /// The current out-of-the-box available themes are: 'vs' (default), 'vs-dark', 'hc-black'.
            /// You can create custom themes via <c>monaco.editor.defineTheme</c>.
            /// To switch a theme, use <c>monaco.editor.setTheme</c>
            /// </summary>
            abstract theme: string option with get, set

        /// The options to create an editor.
        type [<AllowNullLiteral>] IStandaloneEditorConstructionOptions =
            inherit IEditorConstructionOptions
            inherit IGlobalEditorOptions
            /// The initial model associated with this code editor.
            abstract model: ITextModel option with get, set
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
            /// Place overflow widgets inside an external DOM node.
            /// Defaults to an internal DOM node.
            abstract overflowWidgetsDomNode: HTMLElement option with get, set

        type [<AllowNullLiteral>] IStandaloneCodeEditor =
            inherit ICodeEditor
            /// Update the editor's options after the editor has been created.
            abstract updateOptions: newOptions: obj -> unit
            abstract addCommand: keybinding: float * handler: ICommandHandler * ?context: string -> string option
            abstract createContextKey: key: string * defaultValue: 'T -> IContextKey<'T>
            abstract addAction: descriptor: IActionDescriptor -> IDisposable

        type [<AllowNullLiteral>] IStandaloneDiffEditor =
            inherit IDiffEditor
            abstract addCommand: keybinding: float * handler: ICommandHandler * ?context: string -> string option
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
            abstract get: unit -> 'T option

        type [<AllowNullLiteral>] IEditorOverrideServices =
            [<EmitIndexer>] abstract Item: index: string -> obj option with get, set

        type [<AllowNullLiteral>] IMarker =
            abstract owner: string with get, set
            abstract resource: Uri with get, set
            abstract severity: MarkerSeverity with get, set
            abstract code: U2<string, {| value: string; target: Uri |}> option with get, set
            abstract message: string with get, set
            abstract source: string option with get, set
            abstract startLineNumber: float with get, set
            abstract startColumn: float with get, set
            abstract endLineNumber: float with get, set
            abstract endColumn: float with get, set
            abstract relatedInformation: ResizeArray<IRelatedInformation> option with get, set
            abstract tags: ResizeArray<MarkerTag> option with get, set

        /// A structure defining a problem/warning/etc.
        type [<AllowNullLiteral>] IMarkerData =
            abstract code: U2<string, {| value: string; target: Uri |}> option with get, set
            abstract severity: MarkerSeverity with get, set
            abstract message: string with get, set
            abstract source: string option with get, set
            abstract startLineNumber: float with get, set
            abstract startColumn: float with get, set
            abstract endLineNumber: float with get, set
            abstract endColumn: float with get, set
            abstract relatedInformation: ResizeArray<IRelatedInformation> option with get, set
            abstract tags: ResizeArray<MarkerTag> option with get, set

        type [<AllowNullLiteral>] IRelatedInformation =
            abstract resource: Uri with get, set
            abstract message: string with get, set
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

        /// Position in the minimap to render the decoration.
        type [<RequireQualifiedAccess>] MinimapPosition =
            | Inline = 1
            | Gutter = 2

        type [<AllowNullLiteral>] IDecorationOptions =
            /// CSS color to render.
            /// e.g.: rgba(100, 100, 100, 0.5) or a color from the color registry
            abstract color: U2<string, ThemeColor> option with get, set
            /// CSS color to render.
            /// e.g.: rgba(100, 100, 100, 0.5) or a color from the color registry
            abstract darkColor: U2<string, ThemeColor> option with get, set

        /// Options for rendering a model decoration in the overview ruler.
        type [<AllowNullLiteral>] IModelDecorationOverviewRulerOptions =
            inherit IDecorationOptions
            /// The position in the overview ruler.
            abstract position: OverviewRulerLane with get, set

        /// Options for rendering a model decoration in the overview ruler.
        type [<AllowNullLiteral>] IModelDecorationMinimapOptions =
            inherit IDecorationOptions
            /// The position in the overview ruler.
            abstract position: MinimapPosition with get, set

        /// Options for a model decoration.
        type [<AllowNullLiteral>] IModelDecorationOptions =
            /// Customize the growing behavior of the decoration when typing at the edges of the decoration.
            /// Defaults to TrackedRangeStickiness.AlwaysGrowsWhenTypingAtEdges
            abstract stickiness: TrackedRangeStickiness option with get, set
            /// CSS class name describing the decoration.
            abstract className: string option with get, set
            /// Message to be rendered when hovering over the glyph margin decoration.
            abstract glyphMarginHoverMessage: U2<IMarkdownString, ResizeArray<IMarkdownString>> option with get, set
            /// Array of MarkdownString to render as the decoration message.
            abstract hoverMessage: U2<IMarkdownString, ResizeArray<IMarkdownString>> option with get, set
            /// Should the decoration expand to encompass a whole line.
            abstract isWholeLine: bool option with get, set
            /// Specifies the stack order of a decoration.
            /// A decoration with greater stack order is always in front of a decoration with a lower stack order.
            abstract zIndex: float option with get, set
            /// If set, render this decoration in the overview ruler.
            abstract overviewRuler: IModelDecorationOverviewRulerOptions option with get, set
            /// If set, render this decoration in the minimap.
            abstract minimap: IModelDecorationMinimapOptions option with get, set
            /// If set, the decoration will be rendered in the glyph margin with this CSS class name.
            abstract glyphMarginClassName: string option with get, set
            /// If set, the decoration will be rendered in the lines decorations with this CSS class name.
            abstract linesDecorationsClassName: string option with get, set
            /// If set, the decoration will be rendered in the lines decorations with this CSS class name, but only for the first line in case of line wrapping.
            abstract firstLineDecorationClassName: string option with get, set
            /// If set, the decoration will be rendered in the margin (covering its full width) with this CSS class name.
            abstract marginClassName: string option with get, set
            /// <summary>
            /// If set, the decoration will be rendered inline with the text with this CSS class name.
            /// Please use this only for CSS rules that must impact the text. For example, use <c>className</c>
            /// to have a background color decoration.
            /// </summary>
            abstract inlineClassName: string option with get, set
            /// <summary>If there is an <c>inlineClassName</c> which affects letter spacing.</summary>
            abstract inlineClassNameAffectsLetterSpacing: bool option with get, set
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
            /// Identifier for a decoration's owner.
            abstract ownerId: float
            /// Range that this decoration covers.
            abstract range: Range
            /// Options associated with this decoration.
            abstract options: IModelDecorationOptions

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

        /// <summary>
        /// A single edit operation, that acts as a simple replace.
        /// i.e. Replace text at <c>range</c> with <c>text</c> in model.
        /// </summary>
        type [<AllowNullLiteral>] ISingleEditOperation =
            /// The range to replace. This can be empty to emulate a simple insert.
            abstract range: IRange with get, set
            /// The text to replace with. This can be null to emulate a simple delete.
            abstract text: string option with get, set
            /// <summary>
            /// This indicates that this operation has "insert" semantics.
            /// i.e. forceMoveMarkers = true => if <c>range</c> is collapsed, all markers at the position will be moved.
            /// </summary>
            abstract forceMoveMarkers: bool option with get, set

        /// A single edit operation, that has an identifier.
        type [<AllowNullLiteral>] IIdentifiedSingleEditOperation =
            /// The range to replace. This can be empty to emulate a simple insert.
            abstract range: IRange with get, set
            /// The text to replace with. This can be null to emulate a simple delete.
            abstract text: string option with get, set
            /// <summary>
            /// This indicates that this operation has "insert" semantics.
            /// i.e. forceMoveMarkers = true => if <c>range</c> is collapsed, all markers at the position will be moved.
            /// </summary>
            abstract forceMoveMarkers: bool option with get, set

        type [<AllowNullLiteral>] IValidEditOperation =
            /// The range to replace. This can be empty to emulate a simple insert.
            abstract range: Range with get, set
            /// The text to replace with. This can be empty to emulate a simple delete.
            abstract text: string with get, set

        /// A callback that can compute the cursor state after applying a series of edit operations.
        type [<AllowNullLiteral>] ICursorStateComputer =
            /// A callback that can compute the resulting cursors state after some edit operations have been executed.
            [<Emit "$0($1...)">] abstract Invoke: inverseEditOperations: ResizeArray<IValidEditOperation> -> ResizeArray<Selection> option

        type [<AllowNullLiteral>] TextModelResolvedOptions =
            abstract _textModelResolvedOptionsBrand: unit with get, set
            abstract tabSize: float
            abstract indentSize: float
            abstract insertSpaces: bool
            abstract defaultEOL: DefaultEndOfLine
            abstract trimAutoWhitespace: bool

        type [<AllowNullLiteral>] TextModelResolvedOptionsStatic =
            [<EmitConstructor>] abstract Create: unit -> TextModelResolvedOptions

        type [<AllowNullLiteral>] ITextModelUpdateOptions =
            abstract tabSize: float option with get, set
            abstract indentSize: float option with get, set
            abstract insertSpaces: bool option with get, set
            abstract trimAutoWhitespace: bool option with get, set

        type [<AllowNullLiteral>] FindMatch =
            abstract _findMatchBrand: unit with get, set
            abstract range: Range
            abstract matches: ResizeArray<string> option

        type [<AllowNullLiteral>] FindMatchStatic =
            [<EmitConstructor>] abstract Create: unit -> FindMatch

        /// <summary>
        /// Describes the behavior of decorations when typing/editing near their edges.
        /// Note: Please do not edit the values, as they very carefully match <c>DecorationRangeBehavior</c>
        /// </summary>
        type [<RequireQualifiedAccess>] TrackedRangeStickiness =
            | AlwaysGrowsWhenTypingAtEdges = 0
            | NeverGrowsWhenTypingAtEdges = 1
            | GrowsOnlyWhenTypingBefore = 2
            | GrowsOnlyWhenTypingAfter = 3

        /// A model.
        type [<AllowNullLiteral>] ITextModel =
            /// Gets the resource associated with this editor model.
            abstract uri: Uri
            /// A unique identifier associated with this model.
            abstract id: string
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
            /// <summary>Get the character count of text in a certain range.</summary>
            /// <param name="range">The range describing what text length to get.</param>
            abstract getCharacterCountInRange: range: IRange -> float
            /// Get the number of lines in the model.
            abstract getLineCount: unit -> float
            /// Get the text for a certain line.
            abstract getLineContent: lineNumber: float -> string
            /// Get the text length for a certain line.
            abstract getLineLength: lineNumber: float -> float
            /// Get the text for all lines.
            abstract getLinesContent: unit -> ResizeArray<string>
            /// <summary>Get the end of line sequence predominantly used in the text buffer.</summary>
            /// <returns>EOL char sequence (e.g.: '\n' or '\r\n').</returns>
            abstract getEOL: unit -> string
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
            /// Advances the given position by the given offset (negative offsets are also accepted)
            /// and returns it as a new valid position.
            /// 
            /// If the offset and position are such that their combination goes beyond the beginning or
            /// end of the model, throws an exception.
            /// 
            /// If the offset is such that the new position would be in the middle of a multi-byte
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
            /// Returns if the model was disposed or not.
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
            abstract findMatches: searchString: string * searchOnlyEditableRange: bool * isRegex: bool * matchCase: bool * wordSeparators: string option * captureMatches: bool * ?limitResultCount: float -> ResizeArray<FindMatch>
            /// <summary>Search the model.</summary>
            /// <param name="searchString">The string used to search. If it is a regular expression, set <c>isRegex</c> to true.</param>
            /// <param name="searchScope">Limit the searching to only search inside these ranges.</param>
            /// <param name="isRegex">Used to indicate that <c>searchString</c> is a regular expression.</param>
            /// <param name="matchCase">Force the matching to match lower/upper case exactly.</param>
            /// <param name="wordSeparators">Force the matching to match entire words only. Pass null otherwise.</param>
            /// <param name="captureMatches">The result will contain the captured groups.</param>
            /// <param name="limitResultCount">Limit the number of results</param>
            /// <returns>The ranges where the matches are. It is empty if no matches have been found.</returns>
            abstract findMatches: searchString: string * searchScope: U2<IRange, ResizeArray<IRange>> * isRegex: bool * matchCase: bool * wordSeparators: string option * captureMatches: bool * ?limitResultCount: float -> ResizeArray<FindMatch>
            /// <summary>Search the model for the next match. Loops to the beginning of the model if needed.</summary>
            /// <param name="searchString">The string used to search. If it is a regular expression, set <c>isRegex</c> to true.</param>
            /// <param name="searchStart">Start the searching at the specified position.</param>
            /// <param name="isRegex">Used to indicate that <c>searchString</c> is a regular expression.</param>
            /// <param name="matchCase">Force the matching to match lower/upper case exactly.</param>
            /// <param name="wordSeparators">Force the matching to match entire words only. Pass null otherwise.</param>
            /// <param name="captureMatches">The result will contain the captured groups.</param>
            /// <returns>The range where the next match is. It is null if no next match has been found.</returns>
            abstract findNextMatch: searchString: string * searchStart: IPosition * isRegex: bool * matchCase: bool * wordSeparators: string option * captureMatches: bool -> FindMatch option
            /// <summary>Search the model for the previous match. Loops to the end of the model if needed.</summary>
            /// <param name="searchString">The string used to search. If it is a regular expression, set <c>isRegex</c> to true.</param>
            /// <param name="searchStart">Start the searching at the specified position.</param>
            /// <param name="isRegex">Used to indicate that <c>searchString</c> is a regular expression.</param>
            /// <param name="matchCase">Force the matching to match lower/upper case exactly.</param>
            /// <param name="wordSeparators">Force the matching to match entire words only. Pass null otherwise.</param>
            /// <param name="captureMatches">The result will contain the captured groups.</param>
            /// <returns>The range where the previous match is. It is null if no previous match has been found.</returns>
            abstract findPreviousMatch: searchString: string * searchStart: IPosition * isRegex: bool * matchCase: bool * wordSeparators: string option * captureMatches: bool -> FindMatch option
            /// Get the language associated with this model.
            abstract getModeId: unit -> string
            /// <summary>Get the word under or besides <c>position</c>.</summary>
            /// <param name="position">The position to look for a word.</param>
            /// <returns>The word under or besides <c>position</c>. Might be null.</returns>
            abstract getWordAtPosition: position: IPosition -> IWordAtPosition option
            /// <summary>Get the word under or besides <c>position</c> trimmed to <c>position</c>.column</summary>
            /// <param name="position">The position to look for a word.</param>
            /// <returns>The word under or besides <c>position</c>. Will never be null.</returns>
            abstract getWordUntilPosition: position: IPosition -> IWordAtPosition
            /// <summary>
            /// Perform a minimum amount of operations, in order to transform the decorations
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
            abstract getDecorationOptions: id: string -> IModelDecorationOptions option
            /// <summary>Get the range associated with a decoration.</summary>
            /// <param name="id">The decoration id.</param>
            /// <returns>The decoration range or null if the decoration was not found.</returns>
            abstract getDecorationRange: id: string -> Range option
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
            /// Gets all the decorations in a range as an array. Only <c>startLineNumber</c> and <c>endLineNumber</c> from <c>range</c> are used for filtering.
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
            /// <summary>Gets all the decorations that should be rendered in the overview ruler as an array.</summary>
            /// <param name="ownerId">If set, it will ignore decorations belonging to other owners.</param>
            /// <param name="filterOutValidation">If set, it will ignore decorations specific to validation (i.e. warnings, errors).</param>
            abstract getOverviewRulerDecorations: ?ownerId: float * ?filterOutValidation: bool -> ResizeArray<IModelDecoration>
            /// Normalize a string containing whitespace according to indentation rules (converts to spaces or to tabs).
            abstract normalizeIndentation: str: string -> string
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
            /// <param name="beforeCursorState">The cursor state before the edit operations. This cursor state will be returned when <c>undo</c> or <c>redo</c> are invoked.</param>
            /// <param name="editOperations">The edit operations.</param>
            /// <param name="cursorStateComputer">A callback that can compute the resulting cursors state after the edit operations have been executed.</param>
            /// <returns>The cursor state returned by the <c>cursorStateComputer</c>.</returns>
            abstract pushEditOperations: beforeCursorState: ResizeArray<Selection> option * editOperations: ResizeArray<IIdentifiedSingleEditOperation> * cursorStateComputer: ICursorStateComputer -> ResizeArray<Selection> option
            /// Change the end of line sequence. This is the preferred way of
            /// changing the eol sequence. This will land on the undo stack.
            abstract pushEOL: eol: EndOfLineSequence -> unit
            /// <summary>
            /// Edit the model without adding the edits to the undo stack.
            /// This can have dire consequences on the undo stack! See @pushEditOperations for the preferred way.
            /// </summary>
            /// <param name="operations">The edit operations.</param>
            /// <returns>If desired, the inverse edit operations, that, when applied, will bring the model back to the previous state.</returns>
            abstract applyEdits: operations: ResizeArray<IIdentifiedSingleEditOperation> -> unit
            abstract applyEdits: operations: ResizeArray<IIdentifiedSingleEditOperation> * computeUndoEdits: obj -> unit
            /// Change the end of line sequence without recording in the undo stack.
            /// This can have dire consequences on the undo stack! See @pushEOL for the preferred way.
            abstract setEOL: eol: EndOfLineSequence -> unit
            /// <summary>An event emitted when the contents of the model have changed.</summary>
            abstract onDidChangeContent: listener: (IModelContentChangedEvent -> unit) -> IDisposable
            /// <summary>An event emitted when decorations of the model have changed.</summary>
            abstract onDidChangeDecorations: listener: (IModelDecorationsChangedEvent -> unit) -> IDisposable
            /// <summary>An event emitted when the model options have changed.</summary>
            abstract onDidChangeOptions: listener: (IModelOptionsChangedEvent -> unit) -> IDisposable
            /// <summary>An event emitted when the language associated with the model has changed.</summary>
            abstract onDidChangeLanguage: listener: (IModelLanguageChangedEvent -> unit) -> IDisposable
            /// <summary>An event emitted when the language configuration associated with the model has changed.</summary>
            abstract onDidChangeLanguageConfiguration: listener: (IModelLanguageConfigurationChangedEvent -> unit) -> IDisposable
            /// <summary>An event emitted right before disposing the model.</summary>
            abstract onWillDispose: listener: (unit -> unit) -> IDisposable
            /// Destroy this model. This will unbind the model from the mode
            /// and make all necessary clean-up to release this object to the GC.
            abstract dispose: unit -> unit

        /// A builder and helper for edit operations for a command.
        type [<AllowNullLiteral>] IEditOperationBuilder =
            /// <summary>Add a new edit operation (a replace operation).</summary>
            /// <param name="range">The range to replace (delete). May be empty to represent a simple insert.</param>
            /// <param name="text">The text to replace with. May be null to represent a simple delete.</param>
            abstract addEditOperation: range: IRange * text: string option * ?forceMoveMarkers: bool -> unit
            /// <summary>
            /// Add a new edit operation (a replace operation).
            /// The inverse edits will be accessible in <c>ICursorStateComputerData.getInverseEditOperations()</c>
            /// </summary>
            /// <param name="range">The range to replace (delete). May be empty to represent a simple insert.</param>
            /// <param name="text">The text to replace with. May be null to represent a simple delete.</param>
            abstract addTrackedEditOperation: range: IRange * text: string option * ?forceMoveMarkers: bool -> unit
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
            /// <returns>A unique identifier.</returns>
            abstract trackSelection: selection: Selection * ?trackPreviousOnEmpty: bool -> string

        /// A helper for computing cursor state after a command.
        type [<AllowNullLiteral>] ICursorStateComputerData =
            /// Get the inverse edit operations of the added edit operations.
            abstract getInverseEditOperations: unit -> ResizeArray<IValidEditOperation>
            /// <summary>Get a previously tracked selection.</summary>
            /// <param name="id">The unique identifier returned by <c>trackSelection</c>.</param>
            /// <returns>The selection.</returns>
            abstract getTrackedSelection: id: string -> Selection

        /// A command that modifies text / cursor state on a model.
        type [<AllowNullLiteral>] ICommand =
            /// <summary>Get the edit operations needed to execute this command.</summary>
            /// <param name="model">The model the command will execute on.</param>
            /// <param name="builder">A helper to collect the needed edit operations and to track selections.</param>
            abstract getEditOperations: model: ITextModel * builder: IEditOperationBuilder -> unit
            /// <summary>Compute the cursor state after the edit operations were applied.</summary>
            /// <param name="model">The model the command has executed on.</param>
            /// <param name="helper">A helper to get inverse edit operations and to get previously tracked selections.</param>
            /// <returns>The cursor state after the command executed.</returns>
            abstract computeCursorState: model: ITextModel * helper: ICursorStateComputerData -> Selection

        /// A model for the diff editor.
        type [<AllowNullLiteral>] IDiffEditorModel =
            /// Original model.
            abstract original: ITextModel with get, set
            /// Modified model.
            abstract modified: ITextModel with get, set

        /// <summary>An event describing that an editor has had its model reset (i.e. <c>editor.setModel()</c>).</summary>
        type [<AllowNullLiteral>] IModelChangedEvent =
            /// <summary>The <c>uri</c> of the previous model or null.</summary>
            abstract oldModelUrl: Uri option
            /// <summary>The <c>uri</c> of the new model or null.</summary>
            abstract newModelUrl: Uri option

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
            abstract charChanges: ResizeArray<ICharChange> option

        type [<AllowNullLiteral>] IContentSizeChangedEvent =
            abstract contentWidth: float
            abstract contentHeight: float
            abstract contentWidthChanged: bool
            abstract contentHeightChanged: bool

        type [<AllowNullLiteral>] INewScrollPosition =
            abstract scrollLeft: float option with get, set
            abstract scrollTop: float option with get, set

        type [<AllowNullLiteral>] IEditorAction =
            abstract id: string
            abstract label: string
            abstract alias: string
            abstract isSupported: unit -> bool
            abstract run: unit -> Promise<unit>

        type IEditorModel =
            U2<ITextModel, IDiffEditorModel>

        /// A (serializable) state of the cursors.
        type [<AllowNullLiteral>] ICursorState =
            abstract inSelectionMode: bool with get, set
            abstract selectionStart: IPosition with get, set
            abstract position: IPosition with get, set

        /// A (serializable) state of the view.
        type [<AllowNullLiteral>] IViewState =
            /// written by previous versions
            abstract scrollTop: float option with get, set
            /// written by previous versions
            abstract scrollTopWithoutViewZones: float option with get, set
            abstract scrollLeft: float with get, set
            abstract firstPosition: IPosition with get, set
            abstract firstPositionDeltaTop: float with get, set

        /// A (serializable) state of the code editor.
        type [<AllowNullLiteral>] ICodeEditorViewState =
            abstract cursorState: ResizeArray<ICursorState> with get, set
            abstract viewState: IViewState with get, set
            abstract contributionsState: {| Item: obj option |} with get, set

        /// (Serializable) View state for the diff editor.
        type [<AllowNullLiteral>] IDiffEditorViewState =
            abstract original: ICodeEditorViewState option with get, set
            abstract modified: ICodeEditorViewState option with get, set

        /// An editor view state.
        type IEditorViewState =
            U2<ICodeEditorViewState, IDiffEditorViewState>

        type [<RequireQualifiedAccess>] ScrollType =
            | Smooth = 0
            | Immediate = 1

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
            /// 
            /// If a dimension is passed in, the passed in value will be used.
            abstract layout: ?dimension: IDimension -> unit
            /// Brings browser focus to the editor text
            abstract focus: unit -> unit
            /// Returns true if the text inside this editor is focused (i.e. cursor is blinking).
            abstract hasTextFocus: unit -> bool
            /// Returns all actions associated with this editor.
            abstract getSupportedActions: unit -> ResizeArray<IEditorAction>
            /// Saves current view state of the editor in a serializable object.
            abstract saveViewState: unit -> IEditorViewState option
            /// <summary>Restores the view state of the editor from a serializable object generated by <c>saveViewState</c>.</summary>
            abstract restoreViewState: state: IEditorViewState -> unit
            /// Given a position, returns a column number that takes tab-widths into account.
            abstract getVisibleColumnFromPosition: position: IPosition -> float
            /// Returns the primary position of the cursor.
            abstract getPosition: unit -> Position option
            /// <summary>Set the primary position of the cursor. This will remove any secondary cursors.</summary>
            /// <param name="position">New primary cursor's position</param>
            abstract setPosition: position: IPosition -> unit
            /// Scroll vertically as necessary and reveal a line.
            abstract revealLine: lineNumber: float * ?scrollType: ScrollType -> unit
            /// Scroll vertically as necessary and reveal a line centered vertically.
            abstract revealLineInCenter: lineNumber: float * ?scrollType: ScrollType -> unit
            /// Scroll vertically as necessary and reveal a line centered vertically only if it lies outside the viewport.
            abstract revealLineInCenterIfOutsideViewport: lineNumber: float * ?scrollType: ScrollType -> unit
            /// Scroll vertically as necessary and reveal a line close to the top of the viewport,
            /// optimized for viewing a code definition.
            abstract revealLineNearTop: lineNumber: float * ?scrollType: ScrollType -> unit
            /// Scroll vertically or horizontally as necessary and reveal a position.
            abstract revealPosition: position: IPosition * ?scrollType: ScrollType -> unit
            /// Scroll vertically or horizontally as necessary and reveal a position centered vertically.
            abstract revealPositionInCenter: position: IPosition * ?scrollType: ScrollType -> unit
            /// Scroll vertically or horizontally as necessary and reveal a position centered vertically only if it lies outside the viewport.
            abstract revealPositionInCenterIfOutsideViewport: position: IPosition * ?scrollType: ScrollType -> unit
            /// Scroll vertically or horizontally as necessary and reveal a position close to the top of the viewport,
            /// optimized for viewing a code definition.
            abstract revealPositionNearTop: position: IPosition * ?scrollType: ScrollType -> unit
            /// Returns the primary selection of the editor.
            abstract getSelection: unit -> Selection option
            /// Returns all the selections of the editor.
            abstract getSelections: unit -> ResizeArray<Selection> option
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
            abstract revealLines: startLineNumber: float * endLineNumber: float * ?scrollType: ScrollType -> unit
            /// Scroll vertically as necessary and reveal lines centered vertically.
            abstract revealLinesInCenter: lineNumber: float * endLineNumber: float * ?scrollType: ScrollType -> unit
            /// Scroll vertically as necessary and reveal lines centered vertically only if it lies outside the viewport.
            abstract revealLinesInCenterIfOutsideViewport: lineNumber: float * endLineNumber: float * ?scrollType: ScrollType -> unit
            /// Scroll vertically as necessary and reveal lines close to the top of the viewport,
            /// optimized for viewing a code definition.
            abstract revealLinesNearTop: lineNumber: float * endLineNumber: float * ?scrollType: ScrollType -> unit
            /// Scroll vertically or horizontally as necessary and reveal a range.
            abstract revealRange: range: IRange * ?scrollType: ScrollType -> unit
            /// Scroll vertically or horizontally as necessary and reveal a range centered vertically.
            abstract revealRangeInCenter: range: IRange * ?scrollType: ScrollType -> unit
            /// Scroll vertically or horizontally as necessary and reveal a range at the top of the viewport.
            abstract revealRangeAtTop: range: IRange * ?scrollType: ScrollType -> unit
            /// Scroll vertically or horizontally as necessary and reveal a range centered vertically only if it lies outside the viewport.
            abstract revealRangeInCenterIfOutsideViewport: range: IRange * ?scrollType: ScrollType -> unit
            /// Scroll vertically or horizontally as necessary and reveal a range close to the top of the viewport,
            /// optimized for viewing a code definition.
            abstract revealRangeNearTop: range: IRange * ?scrollType: ScrollType -> unit
            /// Scroll vertically or horizontally as necessary and reveal a range close to the top of the viewport,
            /// optimized for viewing a code definition. Only if it lies outside the viewport.
            abstract revealRangeNearTopIfOutsideViewport: range: IRange * ?scrollType: ScrollType -> unit
            /// <summary>Directly trigger a handler or an editor action.</summary>
            /// <param name="source">The source of the call.</param>
            /// <param name="handlerId">The id of the handler or the id of a contribution.</param>
            /// <param name="payload">Extra data to be sent to the handler.</param>
            abstract trigger: source: string option * handlerId: string * payload: obj option -> unit
            /// Gets the current model attached to this editor.
            abstract getModel: unit -> IEditorModel option
            /// Sets the current model attached to this editor.
            /// If the previous model was created by the editor via the value key in the options
            /// literal object, it will be destroyed. Otherwise, if the previous model was set
            /// via setModel, or the model key in the options literal object, the previous model
            /// will not be destroyed.
            /// It is safe to call setModel(null) to simply detach the current model from the editor.
            abstract setModel: model: IEditorModel option -> unit

        /// An editor contribution that gets created every time a new editor gets created and gets disposed when the editor gets disposed.
        type [<AllowNullLiteral>] IEditorContribution =
            /// Dispose this contribution.
            abstract dispose: unit -> unit
            /// Store view state.
            abstract saveViewState: unit -> obj option
            /// Restore view state.
            abstract restoreViewState: state: obj option -> unit

        /// An event describing that the current mode associated with a model has changed.
        type [<AllowNullLiteral>] IModelLanguageChangedEvent =
            /// Previous language
            abstract oldLanguage: string
            /// New language
            abstract newLanguage: string

        /// An event describing that the language configuration associated with a model has changed.
        type [<AllowNullLiteral>] IModelLanguageConfigurationChangedEvent =
            interface end

        type [<AllowNullLiteral>] IModelContentChange =
            /// The range that got replaced.
            abstract range: IRange
            /// The offset of the range that got replaced.
            abstract rangeOffset: float
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
            abstract affectsMinimap: bool
            abstract affectsOverviewRuler: bool

        type [<AllowNullLiteral>] IModelOptionsChangedEvent =
            abstract tabSize: bool
            abstract indentSize: bool
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
            /// The model version id.
            abstract modelVersionId: float
            /// The old selections.
            abstract oldSelections: ResizeArray<Selection> option
            /// <summary>The model version id the that <c>oldSelections</c> refer to.</summary>
            abstract oldModelVersionId: float
            /// Source of the call that caused the event.
            abstract source: string
            /// Reason.
            abstract reason: CursorChangeReason

        type [<RequireQualifiedAccess>] AccessibilitySupport =
            /// This should be the browser case where it is not known if a screen reader is attached or no.
            | Unknown = 0
            | Disabled = 1
            | Enabled = 2

        /// Configuration options for auto closing quotes and brackets
        type [<StringEnum>] [<RequireQualifiedAccess>] EditorAutoClosingStrategy =
            | Always
            | LanguageDefined
            | BeforeWhitespace
            | Never

        /// Configuration options for auto wrapping quotes and brackets
        type [<StringEnum>] [<RequireQualifiedAccess>] EditorAutoSurroundStrategy =
            | LanguageDefined
            | Quotes
            | Brackets
            | Never

        /// Configuration options for typing over closing quotes or brackets
        type [<StringEnum>] [<RequireQualifiedAccess>] EditorAutoClosingOvertypeStrategy =
            | Always
            | Auto
            | Never

        /// Configuration options for auto indentation in the editor
        type [<RequireQualifiedAccess>] EditorAutoIndentStrategy =
            | None = 0
            | Keep = 1
            | Brackets = 2
            | Advanced = 3
            | Full = 4

        /// Configuration options for the editor.
        type [<AllowNullLiteral>] IEditorOptions =
            /// This editor is used inside a diff editor.
            abstract inDiffEditor: bool option with get, set
            /// The aria label for the editor's textarea (when it is focused).
            abstract ariaLabel: string option with get, set
            /// <summary>The <c>tabindex</c> property of the editor's textarea</summary>
            abstract tabIndex: float option with get, set
            /// Render vertical lines at the specified columns.
            /// Defaults to empty array.
            abstract rulers: ResizeArray<U2<float, IRulerOption>> option with get, set
            /// A string containing the word separators used when doing word navigation.
            /// Defaults to `~!@#$%^&*()-=+[{]}\\|;:\'",.<>/?
            abstract wordSeparators: string option with get, set
            /// Enable Linux primary clipboard.
            /// Defaults to true.
            abstract selectionClipboard: bool option with get, set
            /// <summary>
            /// Control the rendering of line numbers.
            /// If it is a function, it will be invoked when rendering a line number and the return value will be rendered.
            /// Otherwise, if it is a truey, line numbers will be rendered normally (equivalent of using an identity function).
            /// Otherwise, line numbers will not be rendered.
            /// Defaults to <c>on</c>.
            /// </summary>
            abstract lineNumbers: LineNumbersType option with get, set
            /// Controls the minimal number of visible leading and trailing lines surrounding the cursor.
            /// Defaults to 0.
            abstract cursorSurroundingLines: float option with get, set
            /// <summary>
            /// Controls when <c>cursorSurroundingLines</c> should be enforced
            /// Defaults to <c>default</c>, <c>cursorSurroundingLines</c> is not enforced when cursor position is changed
            /// by mouse.
            /// </summary>
            abstract cursorSurroundingLinesStyle: IExportsEditorOptionsCursorSurroundingLinesStyleIEditorOption option with get, set
            /// Render last line number when the file ends with a newline.
            /// Defaults to true.
            abstract renderFinalNewline: bool option with get, set
            /// Remove unusual line terminators like LINE SEPARATOR (LS), PARAGRAPH SEPARATOR (PS).
            /// Defaults to 'prompt'.
            abstract unusualLineTerminators: IExportsEditorOptionsUnusualLineTerminatorsIEditorOption option with get, set
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
            /// Rename matching regions on type.
            /// Defaults to false.
            abstract renameOnType: bool option with get, set
            /// Should the editor render validation decorations.
            /// Defaults to editable.
            abstract renderValidationDecorations: IEditorOptionsRenderValidationDecorations option with get, set
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
            /// Defaults to 3.
            abstract overviewRulerLanes: float option with get, set
            /// <summary>
            /// Controls if a border should be drawn around the overview ruler.
            /// Defaults to <c>true</c>.
            /// </summary>
            abstract overviewRulerBorder: bool option with get, set
            /// Control the cursor animation style, possible values are 'blink', 'smooth', 'phase', 'expand' and 'solid'.
            /// Defaults to 'blink'.
            abstract cursorBlinking: IEditorOptionsCursorBlinking option with get, set
            /// Zoom the font in the editor when using the mouse wheel in combination with holding Ctrl.
            /// Defaults to false.
            abstract mouseWheelZoom: bool option with get, set
            /// Control the mouse pointer style, either 'text' or 'default' or 'copy'
            /// Defaults to 'text'
            abstract mouseStyle: IEditorOptionsMouseStyle option with get, set
            /// Enable smooth caret animation.
            /// Defaults to false.
            abstract cursorSmoothCaretAnimation: bool option with get, set
            /// Control the cursor style, either 'block' or 'line'.
            /// Defaults to 'line'.
            abstract cursorStyle: IEditorOptionsCursorStyle option with get, set
            /// Control the width of the cursor when cursorStyle is set to 'line'
            abstract cursorWidth: float option with get, set
            /// Enable font ligatures.
            /// Defaults to false.
            abstract fontLigatures: U2<bool, string> option with get, set
            /// <summary>
            /// Disable the use of <c>transform: translate3d(0px, 0px, 0px)</c> for the editor margin and lines layers.
            /// The usage of <c>transform: translate3d(0px, 0px, 0px)</c> acts as a hint for browsers to create an extra layer.
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
            /// Enable that scrolling can go beyond the last column by a number of columns.
            /// Defaults to 5.
            abstract scrollBeyondLastColumn: float option with get, set
            /// Enable that the editor animates scrolling to a position.
            /// Defaults to false.
            abstract smoothScrolling: bool option with get, set
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
            /// Control indentation of wrapped lines. Can be: 'none', 'same', 'indent' or 'deepIndent'.
            /// Defaults to 'same' in vscode and to 'none' in monaco-editor.
            abstract wrappingIndent: IEditorOptionsWrappingIndent option with get, set
            /// Controls the wrapping strategy to use.
            /// Defaults to 'simple'.
            abstract wrappingStrategy: IExportsEditorOptionsWrappingStrategyIEditorOption option with get, set
            /// Configure word wrapping characters. A break will be introduced before these characters.
            /// Defaults to '([{‘“〈《「『【〔（［｛｢£¥＄￡￥+＋'.
            abstract wordWrapBreakBeforeCharacters: string option with get, set
            /// Configure word wrapping characters. A break will be introduced after these characters.
            /// Defaults to ' \t})]?|/&.,;¢°′″‰℃、。｡､￠，．：；？！％・･ゝゞヽヾーァィゥェォッャュョヮヵヶぁぃぅぇぉっゃゅょゎゕゖㇰㇱㇲㇳㇴㇵㇶㇷㇸㇹㇺㇻㇼㇽㇾㇿ々〻ｧｨｩｪｫｬｭｮｯｰ”〉》」』】〕）］｝｣'.
            abstract wordWrapBreakAfterCharacters: string option with get, set
            /// Performance guard: Stop rendering a line after x characters.
            /// Defaults to 10000.
            /// Use -1 to never stop rendering
            abstract stopRenderingLineAfter: float option with get, set
            /// Configure the editor's hover.
            abstract hover: IEditorHoverOptions option with get, set
            /// Enable detecting links and making them clickable.
            /// Defaults to true.
            abstract links: bool option with get, set
            /// Enable inline color decorators and color picker rendering.
            abstract colorDecorators: bool option with get, set
            /// Control the behaviour of comments in the editor.
            abstract comments: IEditorCommentsOptions option with get, set
            /// Enable custom contextmenu.
            /// Defaults to true.
            abstract contextmenu: bool option with get, set
            /// <summary>
            /// A multiplier to be used on the <c>deltaX</c> and <c>deltaY</c> of mouse wheel scroll events.
            /// Defaults to 1.
            /// </summary>
            abstract mouseWheelScrollSensitivity: float option with get, set
            /// <summary>
            /// FastScrolling mulitplier speed when pressing <c>Alt</c>
            /// Defaults to 5.
            /// </summary>
            abstract fastScrollSensitivity: float option with get, set
            /// Enable that the editor scrolls only the predominant axis. Prevents horizontal drift when scrolling vertically on a trackpad.
            /// Defaults to true.
            abstract scrollPredominantAxis: bool option with get, set
            /// Enable that the selection with the mouse and keys is doing column selection.
            /// Defaults to false.
            abstract columnSelection: bool option with get, set
            /// The modifier to be used to add multiple cursors with the mouse.
            /// Defaults to 'alt'
            abstract multiCursorModifier: IEditorOptionsMultiCursorModifier option with get, set
            /// Merge overlapping selections.
            /// Defaults to true
            abstract multiCursorMergeOverlapping: bool option with get, set
            /// Configure the behaviour when pasting a text with the line count equal to the cursor count.
            /// Defaults to 'spread'.
            abstract multiCursorPaste: IExportsEditorOptionsMultiCursorPasteIEditorOption option with get, set
            /// Configure the editor's accessibility support.
            /// Defaults to 'auto'. It is best to leave this to 'auto'.
            abstract accessibilitySupport: IEditorOptionsAccessibilitySupport option with get, set
            /// Controls the number of lines in the editor that can be read out by a screen reader
            abstract accessibilityPageSize: float option with get, set
            /// Suggest options.
            abstract suggest: ISuggestOptions option with get, set
            abstract gotoLocation: IGotoLocationOptions option with get, set
            /// Enable quick suggestions (shadow suggestions)
            /// Defaults to true.
            abstract quickSuggestions: U2<bool, IQuickSuggestionsOptions> option with get, set
            /// Quick suggestions show delay (in ms)
            /// Defaults to 10 (ms)
            abstract quickSuggestionsDelay: float option with get, set
            /// Controls the spacing around the editor.
            abstract padding: IEditorPaddingOptions option with get, set
            /// Parameter hint options.
            abstract parameterHints: IEditorParameterHintOptions option with get, set
            /// Options for auto closing brackets.
            /// Defaults to language defined behavior.
            abstract autoClosingBrackets: EditorAutoClosingStrategy option with get, set
            /// Options for auto closing quotes.
            /// Defaults to language defined behavior.
            abstract autoClosingQuotes: EditorAutoClosingStrategy option with get, set
            /// Options for typing over closing quotes or brackets.
            abstract autoClosingOvertype: EditorAutoClosingOvertypeStrategy option with get, set
            /// Options for auto surrounding.
            /// Defaults to always allowing auto surrounding.
            abstract autoSurround: EditorAutoSurroundStrategy option with get, set
            /// Controls whether the editor should automatically adjust the indentation when users type, paste, move or indent lines.
            /// Defaults to advanced.
            abstract autoIndent: IEditorOptionsAutoIndent option with get, set
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
            /// Syntax highlighting is copied.
            abstract copyWithSyntaxHighlighting: bool option with get, set
            /// The history mode for suggestions.
            abstract suggestSelection: IExportsEditorOptionsSuggestSelectionIEditorOption option with get, set
            /// The font size for the suggest widget.
            /// Defaults to the editor font size.
            abstract suggestFontSize: float option with get, set
            /// The line height for the suggest widget.
            /// Defaults to the editor line height.
            abstract suggestLineHeight: float option with get, set
            /// Enable tab completion.
            abstract tabCompletion: IExportsEditorOptionsTabCompletionIEditorOption option with get, set
            /// Enable selection highlight.
            /// Defaults to true.
            abstract selectionHighlight: bool option with get, set
            /// Enable semantic occurrences highlight.
            /// Defaults to true.
            abstract occurrencesHighlight: bool option with get, set
            /// Show code lens
            /// Defaults to true.
            abstract codeLens: bool option with get, set
            /// Control the behavior and rendering of the code action lightbulb.
            abstract lightbulb: IEditorLightbulbOptions option with get, set
            /// Timeout for running code actions on save.
            abstract codeActionsOnSaveTimeout: float option with get, set
            /// Enable code folding.
            /// Defaults to true.
            abstract folding: bool option with get, set
            /// Selects the folding strategy. 'auto' uses the strategies contributed for the current document, 'indentation' uses the indentation based folding strategy.
            /// Defaults to 'auto'.
            abstract foldingStrategy: IExportsEditorOptionsFoldingStrategyIEditorOption option with get, set
            /// Enable highlight for folded regions.
            /// Defaults to true.
            abstract foldingHighlight: bool option with get, set
            /// Controls whether the fold actions in the gutter stay always visible or hide unless the mouse is over the gutter.
            /// Defaults to 'mouseover'.
            abstract showFoldingControls: IExportsEditorOptionsShowFoldingControlsIEditorOption option with get, set
            /// Controls whether clicking on the empty content after a folded line will unfold the line.
            /// Defaults to false.
            abstract unfoldOnClickAfterEndOfLine: bool option with get, set
            /// Enable highlighting of matching brackets.
            /// Defaults to 'always'.
            abstract matchBrackets: IEditorOptionsMatchBrackets option with get, set
            /// Enable rendering of whitespace.
            /// Defaults to none.
            abstract renderWhitespace: IEditorOptionsRenderWhitespace option with get, set
            /// Enable rendering of control characters.
            /// Defaults to false.
            abstract renderControlCharacters: bool option with get, set
            /// Enable rendering of indent guides.
            /// Defaults to true.
            abstract renderIndentGuides: bool option with get, set
            /// Enable highlighting of the active indent guide.
            /// Defaults to true.
            abstract highlightActiveIndentGuide: bool option with get, set
            /// Enable rendering of current line highlight.
            /// Defaults to all.
            abstract renderLineHighlight: IEditorOptionsRenderLineHighlight option with get, set
            /// Control if the current line highlight should be rendered only the editor is focused.
            /// Defaults to false.
            abstract renderLineHighlightOnlyWhenFocus: bool option with get, set
            /// Inserting and deleting whitespace follows tab stops.
            abstract useTabStops: bool option with get, set
            /// The font family
            abstract fontFamily: string option with get, set
            /// The font weight
            abstract fontWeight: string option with get, set
            /// The font size
            abstract fontSize: float option with get, set
            /// The line height
            abstract lineHeight: float option with get, set
            /// The letter spacing
            abstract letterSpacing: float option with get, set
            /// Controls fading out of unused variables.
            abstract showUnused: bool option with get, set
            /// Controls whether to focus the inline editor in the peek widget by default.
            /// Defaults to false.
            abstract peekWidgetDefaultFocus: IExportsEditorOptionsPeekWidgetDefaultFocusIEditorOption option with get, set
            /// Controls whether the definition link opens element in the peek widget.
            /// Defaults to false.
            abstract definitionLinkOpensInPeek: bool option with get, set
            /// Controls strikethrough deprecated variables.
            abstract showDeprecated: bool option with get, set

        /// Configuration options for the diff editor.
        type [<AllowNullLiteral>] IDiffEditorOptions =
            inherit IEditorOptions
            /// Allow the user to resize the diff editor split view.
            /// Defaults to true.
            abstract enableSplitViewResizing: bool option with get, set
            /// Render the differences in two side-by-side editors.
            /// Defaults to true.
            abstract renderSideBySide: bool option with get, set
            /// Timeout in milliseconds after which diff computation is cancelled.
            /// Defaults to 5000.
            abstract maxComputationTime: float option with get, set
            /// Compute the diff by ignoring leading/trailing whitespace
            /// Defaults to true.
            abstract ignoreTrimWhitespace: bool option with get, set
            /// Render +/- indicators for added/deleted changes.
            /// Defaults to true.
            abstract renderIndicators: bool option with get, set
            /// Original model should be editable?
            /// Defaults to false.
            abstract originalEditable: bool option with get, set
            /// Original editor should be have code lens enabled?
            /// Defaults to false.
            abstract originalCodeLens: bool option with get, set
            /// Modified editor should be have code lens enabled?
            /// Defaults to false.
            abstract modifiedCodeLens: bool option with get, set

        /// An event describing that the configuration of the editor has changed.
        type [<AllowNullLiteral>] ConfigurationChangedEvent =
            abstract hasChanged: id: EditorOption -> bool

        /// An event describing that the configuration of the editor has changed.
        type [<AllowNullLiteral>] ConfigurationChangedEventStatic =
            [<EmitConstructor>] abstract Create: unit -> ConfigurationChangedEvent

        /// All computed editor options.
        type [<AllowNullLiteral>] IComputedEditorOptions =
            abstract get: id: 'T -> FindComputedEditorOptionValueById<'T> when 'T :> EditorOption

        type [<AllowNullLiteral>] IEditorOption<'K1, 'V when 'K1 :> EditorOption> =
            abstract id: 'K1
            abstract name: string
            abstract defaultValue: 'V with get, set

        /// Configuration options for editor comments
        type [<AllowNullLiteral>] IEditorCommentsOptions =
            /// Insert a space after the line comment token and inside the block comments tokens.
            /// Defaults to true.
            abstract insertSpace: bool option with get, set
            /// Ignore empty lines when inserting line comments.
            /// Defaults to true.
            abstract ignoreEmptyLines: bool option with get, set

        type EditorCommentsOptions =
            obj

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

        /// Configuration options for editor find widget
        type [<AllowNullLiteral>] IEditorFindOptions =
            /// Controls whether the cursor should move to find matches while typing.
            abstract cursorMoveOnType: bool option with get, set
            /// Controls if we seed search string in the Find Widget with editor selection.
            abstract seedSearchStringFromSelection: bool option with get, set
            /// Controls if Find in Selection flag is turned on in the editor.
            abstract autoFindInSelection: IEditorFindOptionsAutoFindInSelection option with get, set
            abstract addExtraSpaceOnTop: bool option with get, set
            /// Controls whether the search automatically restarts from the beginning (or the end) when no further matches can be found
            abstract loop: bool option with get, set

        type EditorFindOptions =
            obj

        type [<StringEnum>] [<RequireQualifiedAccess>] GoToLocationValues =
            | Peek
            | GotoAndPeek
            | Goto

        /// Configuration options for go to location
        type [<AllowNullLiteral>] IGotoLocationOptions =
            abstract multiple: GoToLocationValues option with get, set
            abstract multipleDefinitions: GoToLocationValues option with get, set
            abstract multipleTypeDefinitions: GoToLocationValues option with get, set
            abstract multipleDeclarations: GoToLocationValues option with get, set
            abstract multipleImplementations: GoToLocationValues option with get, set
            abstract multipleReferences: GoToLocationValues option with get, set
            abstract alternativeDefinitionCommand: string option with get, set
            abstract alternativeTypeDefinitionCommand: string option with get, set
            abstract alternativeDeclarationCommand: string option with get, set
            abstract alternativeImplementationCommand: string option with get, set
            abstract alternativeReferenceCommand: string option with get, set

        type GoToLocationOptions =
            obj

        /// Configuration options for editor hover
        type [<AllowNullLiteral>] IEditorHoverOptions =
            /// Enable the hover.
            /// Defaults to true.
            abstract enabled: bool option with get, set
            /// Delay for showing the hover.
            /// Defaults to 300.
            abstract delay: float option with get, set
            /// Is the hover sticky such that it can be clicked and its contents selected?
            /// Defaults to true.
            abstract sticky: bool option with get, set

        type EditorHoverOptions =
            obj

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

        type [<RequireQualifiedAccess>] RenderMinimap =
            | None = 0
            | Text = 1
            | Blocks = 2

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
            /// Left position for the line numbers.
            abstract lineNumbersLeft: float
            /// The width of the line numbers.
            abstract lineNumbersWidth: float
            /// Left position for the line decorations.
            abstract decorationsLeft: float
            /// The width of the line decorations.
            abstract decorationsWidth: float
            /// Left position for the content (actual text)
            abstract contentLeft: float
            /// The width of the content (actual text)
            abstract contentWidth: float
            /// Layout information for the minimap
            abstract minimap: EditorMinimapLayoutInfo
            /// The number of columns (of typical characters) fitting on a viewport line.
            abstract viewportColumn: float
            abstract isWordWrapMinified: bool
            abstract isViewportWrapping: bool
            abstract wrappingColumn: float
            /// The width of the vertical scrollbar.
            abstract verticalScrollbarWidth: float
            /// The height of the horizontal scrollbar.
            abstract horizontalScrollbarHeight: float
            /// The position of the overview ruler.
            abstract overviewRuler: OverviewRulerPosition

        /// The internal layout details of the editor.
        type [<AllowNullLiteral>] EditorMinimapLayoutInfo =
            abstract renderMinimap: RenderMinimap
            abstract minimapLeft: float
            abstract minimapWidth: float
            abstract minimapHeightIsEditorHeight: bool
            abstract minimapIsSampling: bool
            abstract minimapScale: float
            abstract minimapLineHeight: float
            abstract minimapCanvasInnerWidth: float
            abstract minimapCanvasInnerHeight: float
            abstract minimapCanvasOuterWidth: float
            abstract minimapCanvasOuterHeight: float

        /// Configuration options for editor lightbulb
        type [<AllowNullLiteral>] IEditorLightbulbOptions =
            /// Enable the lightbulb code action.
            /// Defaults to true.
            abstract enabled: bool option with get, set

        type EditorLightbulbOptions =
            obj

        /// Configuration options for editor minimap
        type [<AllowNullLiteral>] IEditorMinimapOptions =
            /// Enable the rendering of the minimap.
            /// Defaults to true.
            abstract enabled: bool option with get, set
            /// Control the side of the minimap in editor.
            /// Defaults to 'right'.
            abstract side: IEditorMinimapOptionsSide option with get, set
            /// Control the minimap rendering mode.
            /// Defaults to 'actual'.
            abstract size: IEditorMinimapOptionsSize option with get, set
            /// Control the rendering of the minimap slider.
            /// Defaults to 'mouseover'.
            abstract showSlider: IExportsEditorOptionsShowFoldingControlsIEditorOption option with get, set
            /// Render the actual text on a line (as opposed to color blocks).
            /// Defaults to true.
            abstract renderCharacters: bool option with get, set
            /// Limit the width of the minimap to render at most a certain number of columns.
            /// Defaults to 120.
            abstract maxColumn: float option with get, set
            /// Relative size of the font in the minimap. Defaults to 1.
            abstract scale: float option with get, set

        type EditorMinimapOptions =
            obj

        /// Configuration options for editor padding
        type [<AllowNullLiteral>] IEditorPaddingOptions =
            /// Spacing between top edge of editor and first line.
            abstract top: float option with get, set
            /// Spacing between bottom edge of editor and last line.
            abstract bottom: float option with get, set

        type [<AllowNullLiteral>] InternalEditorPaddingOptions =
            abstract top: float
            abstract bottom: float

        /// Configuration options for parameter hints
        type [<AllowNullLiteral>] IEditorParameterHintOptions =
            /// Enable parameter hints.
            /// Defaults to true.
            abstract enabled: bool option with get, set
            /// Enable cycling of parameter hints.
            /// Defaults to false.
            abstract cycle: bool option with get, set

        type InternalParameterHintOptions =
            obj

        /// Configuration options for quick suggestions
        type [<AllowNullLiteral>] IQuickSuggestionsOptions =
            abstract other: bool option with get, set
            abstract comments: bool option with get, set
            abstract strings: bool option with get, set

        type ValidQuickSuggestionsOptions =
            U2<bool, obj>

        type LineNumbersType =
            U2<(float -> string), string>

        type [<RequireQualifiedAccess>] RenderLineNumbersType =
            | Off = 0
            | On = 1
            | Relative = 2
            | Interval = 3
            | Custom = 4

        type [<AllowNullLiteral>] InternalEditorRenderLineNumbersOptions =
            abstract renderType: RenderLineNumbersType
            abstract renderFn: (float -> string) option

        type [<AllowNullLiteral>] IRulerOption =
            abstract column: float
            abstract color: string option

        /// Configuration options for editor scrollbars
        type [<AllowNullLiteral>] IEditorScrollbarOptions =
            /// The size of arrows (if displayed).
            /// Defaults to 11.
            abstract arrowSize: float option with get, set
            /// Render vertical scrollbar.
            /// Defaults to 'auto'.
            abstract vertical: IEditorScrollbarOptionsVertical option with get, set
            /// Render horizontal scrollbar.
            /// Defaults to 'auto'.
            abstract horizontal: IEditorScrollbarOptionsVertical option with get, set
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
            /// Always consume mouse wheel events (always call preventDefault() and stopPropagation() on the browser events).
            /// Defaults to true.
            abstract alwaysConsumeMouseWheel: bool option with get, set
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

        type [<AllowNullLiteral>] InternalEditorScrollbarOptions =
            abstract arrowSize: float
            abstract vertical: ScrollbarVisibility
            abstract horizontal: ScrollbarVisibility
            abstract useShadows: bool
            abstract verticalHasArrows: bool
            abstract horizontalHasArrows: bool
            abstract handleMouseWheel: bool
            abstract alwaysConsumeMouseWheel: bool
            abstract horizontalScrollbarSize: float
            abstract horizontalSliderSize: float
            abstract verticalScrollbarSize: float
            abstract verticalSliderSize: float

        /// Configuration options for editor suggest widget
        type [<AllowNullLiteral>] ISuggestOptions =
            /// Overwrite word ends on accept. Default to false.
            abstract insertMode: ISuggestOptionsInsertMode option with get, set
            /// Enable graceful matching. Defaults to true.
            abstract filterGraceful: bool option with get, set
            /// Prevent quick suggestions when a snippet is active. Defaults to true.
            abstract snippetsPreventQuickSuggestions: bool option with get, set
            /// Favours words that appear close to the cursor.
            abstract localityBonus: bool option with get, set
            /// Enable using global storage for remembering suggestions.
            abstract shareSuggestSelections: bool option with get, set
            /// Enable or disable icons in suggestions. Defaults to true.
            abstract showIcons: bool option with get, set
            /// Max suggestions to show in suggestions. Defaults to 12.
            abstract maxVisibleSuggestions: float option with get, set
            /// Show method-suggestions.
            abstract showMethods: bool option with get, set
            /// Show function-suggestions.
            abstract showFunctions: bool option with get, set
            /// Show constructor-suggestions.
            abstract showConstructors: bool option with get, set
            /// Show field-suggestions.
            abstract showFields: bool option with get, set
            /// Show variable-suggestions.
            abstract showVariables: bool option with get, set
            /// Show class-suggestions.
            abstract showClasses: bool option with get, set
            /// Show struct-suggestions.
            abstract showStructs: bool option with get, set
            /// Show interface-suggestions.
            abstract showInterfaces: bool option with get, set
            /// Show module-suggestions.
            abstract showModules: bool option with get, set
            /// Show property-suggestions.
            abstract showProperties: bool option with get, set
            /// Show event-suggestions.
            abstract showEvents: bool option with get, set
            /// Show operator-suggestions.
            abstract showOperators: bool option with get, set
            /// Show unit-suggestions.
            abstract showUnits: bool option with get, set
            /// Show value-suggestions.
            abstract showValues: bool option with get, set
            /// Show constant-suggestions.
            abstract showConstants: bool option with get, set
            /// Show enum-suggestions.
            abstract showEnums: bool option with get, set
            /// Show enumMember-suggestions.
            abstract showEnumMembers: bool option with get, set
            /// Show keyword-suggestions.
            abstract showKeywords: bool option with get, set
            /// Show text-suggestions.
            abstract showWords: bool option with get, set
            /// Show color-suggestions.
            abstract showColors: bool option with get, set
            /// Show file-suggestions.
            abstract showFiles: bool option with get, set
            /// Show reference-suggestions.
            abstract showReferences: bool option with get, set
            /// Show folder-suggestions.
            abstract showFolders: bool option with get, set
            /// Show typeParameter-suggestions.
            abstract showTypeParameters: bool option with get, set
            /// Show issue-suggestions.
            abstract showIssues: bool option with get, set
            /// Show user-suggestions.
            abstract showUsers: bool option with get, set
            /// Show snippet-suggestions.
            abstract showSnippets: bool option with get, set
            /// Status bar related settings.
            abstract statusBar: {| visible: bool option |} option with get, set

        type InternalSuggestOptions =
            obj

        /// Describes how to indent wrapped lines.
        type [<RequireQualifiedAccess>] WrappingIndent =
            /// No indentation => wrapped lines begin at column 1.
            | None = 0
            /// Same => wrapped lines get the same indentation as the parent.
            | Same = 1
            /// Indent => wrapped lines get +1 indentation toward the parent.
            | Indent = 2
            /// DeepIndent => wrapped lines get +2 indentation toward the parent.
            | DeepIndent = 3

        type [<AllowNullLiteral>] EditorWrappingInfo =
            abstract isDominatedByLongLines: bool
            abstract isWordWrapMinified: bool
            abstract isViewportWrapping: bool
            abstract wrappingColumn: float

        type [<RequireQualifiedAccess>] EditorOption =
            | AcceptSuggestionOnCommitCharacter = 0
            | AcceptSuggestionOnEnter = 1
            | AccessibilitySupport = 2
            | AccessibilityPageSize = 3
            | AriaLabel = 4
            | AutoClosingBrackets = 5
            | AutoClosingOvertype = 6
            | AutoClosingQuotes = 7
            | AutoIndent = 8
            | AutomaticLayout = 9
            | AutoSurround = 10
            | CodeLens = 11
            | ColorDecorators = 12
            | ColumnSelection = 13
            | Comments = 14
            | Contextmenu = 15
            | CopyWithSyntaxHighlighting = 16
            | CursorBlinking = 17
            | CursorSmoothCaretAnimation = 18
            | CursorStyle = 19
            | CursorSurroundingLines = 20
            | CursorSurroundingLinesStyle = 21
            | CursorWidth = 22
            | DisableLayerHinting = 23
            | DisableMonospaceOptimizations = 24
            | DragAndDrop = 25
            | EmptySelectionClipboard = 26
            | ExtraEditorClassName = 27
            | FastScrollSensitivity = 28
            | Find = 29
            | FixedOverflowWidgets = 30
            | Folding = 31
            | FoldingStrategy = 32
            | FoldingHighlight = 33
            | UnfoldOnClickAfterEndOfLine = 34
            | FontFamily = 35
            | FontInfo = 36
            | FontLigatures = 37
            | FontSize = 38
            | FontWeight = 39
            | FormatOnPaste = 40
            | FormatOnType = 41
            | GlyphMargin = 42
            | GotoLocation = 43
            | HideCursorInOverviewRuler = 44
            | HighlightActiveIndentGuide = 45
            | Hover = 46
            | InDiffEditor = 47
            | LetterSpacing = 48
            | Lightbulb = 49
            | LineDecorationsWidth = 50
            | LineHeight = 51
            | LineNumbers = 52
            | LineNumbersMinChars = 53
            | Links = 54
            | MatchBrackets = 55
            | Minimap = 56
            | MouseStyle = 57
            | MouseWheelScrollSensitivity = 58
            | MouseWheelZoom = 59
            | MultiCursorMergeOverlapping = 60
            | MultiCursorModifier = 61
            | MultiCursorPaste = 62
            | OccurrencesHighlight = 63
            | OverviewRulerBorder = 64
            | OverviewRulerLanes = 65
            | Padding = 66
            | ParameterHints = 67
            | PeekWidgetDefaultFocus = 68
            | DefinitionLinkOpensInPeek = 69
            | QuickSuggestions = 70
            | QuickSuggestionsDelay = 71
            | ReadOnly = 72
            | RenameOnType = 73
            | RenderControlCharacters = 74
            | RenderIndentGuides = 75
            | RenderFinalNewline = 76
            | RenderLineHighlight = 77
            | RenderLineHighlightOnlyWhenFocus = 78
            | RenderValidationDecorations = 79
            | RenderWhitespace = 80
            | RevealHorizontalRightPadding = 81
            | RoundedSelection = 82
            | Rulers = 83
            | Scrollbar = 84
            | ScrollBeyondLastColumn = 85
            | ScrollBeyondLastLine = 86
            | ScrollPredominantAxis = 87
            | SelectionClipboard = 88
            | SelectionHighlight = 89
            | SelectOnLineNumbers = 90
            | ShowFoldingControls = 91
            | ShowUnused = 92
            | SnippetSuggestions = 93
            | SmoothScrolling = 94
            | StopRenderingLineAfter = 95
            | Suggest = 96
            | SuggestFontSize = 97
            | SuggestLineHeight = 98
            | SuggestOnTriggerCharacters = 99
            | SuggestSelection = 100
            | TabCompletion = 101
            | TabIndex = 102
            | UnusualLineTerminators = 103
            | UseTabStops = 104
            | WordSeparators = 105
            | WordWrap = 106
            | WordWrapBreakAfterCharacters = 107
            | WordWrapBreakBeforeCharacters = 108
            | WordWrapColumn = 109
            | WordWrapMinified = 110
            | WrappingIndent = 111
            | WrappingStrategy = 112
            | ShowDeprecated = 113
            | EditorClassName = 114
            | PixelRatio = 115
            | TabFocusMode = 116
            | LayoutInfo = 117
            | WrappingInfo = 118

        type EditorOptionsType =
            obj

        type FindEditorOptionsKeyById<'T when 'T :> EditorOption> =
            obj

        type ComputedEditorOptionValue<'T when 'T :> IEditorOption<obj option, obj option>> =
            obj

        type FindComputedEditorOptionValueById<'T when 'T :> EditorOption> =
            NonNullable<ComputedEditorOptionValue<obj>>

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
            /// The minimum width in px of the view zone.
            /// If this is set, the editor will ensure that the scroll width is >= than this value.
            abstract minWidthInPx: float option with get, set
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
            abstract addZone: zone: IViewZone -> string
            /// <summary>Remove a zone</summary>
            /// <param name="id">A unique identifier to the view zone, as returned by the <c>addZone</c> call.</param>
            abstract removeZone: id: string -> unit
            /// <summary>
            /// Change a zone's position.
            /// The editor will rescan the <c>afterLineNumber</c> and <c>afterColumn</c> properties of a view zone.
            /// </summary>
            abstract layoutZone: id: string -> unit

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
            abstract position: IPosition option with get, set
            /// Optionally, a range can be provided to further
            /// define the position of the content widget.
            abstract range: IRange option with get, set
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
            abstract getPosition: unit -> IContentWidgetPosition option

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
            abstract preference: OverlayWidgetPositionPreference option with get, set

        /// An overlay widgets renders on top of the text.
        type [<AllowNullLiteral>] IOverlayWidget =
            /// Get a unique identifier of the overlay widget.
            abstract getId: unit -> string
            /// Get the dom node of the overlay widget.
            abstract getDomNode: unit -> HTMLElement
            /// Get the placement of the overlay widget.
            /// If null is returned, the overlay widget is responsible to place itself.
            abstract getPosition: unit -> IOverlayWidgetPosition option

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
            abstract element: Element option
            /// The target type
            abstract ``type``: MouseTargetType
            /// The 'approximate' editor position
            abstract position: Position option
            /// Desired mouse column (e.g. when position.column gets clamped to text length -- clicking after text on a line).
            abstract mouseColumn: float
            /// The 'approximate' editor range
            abstract range: Range option
            /// Some extra detail.
            abstract detail: obj option

        /// A mouse event originating from the editor.
        type [<AllowNullLiteral>] IEditorMouseEvent =
            abstract ``event``: IMouseEvent
            abstract target: IMouseTarget

        type [<AllowNullLiteral>] IPartialEditorMouseEvent =
            abstract ``event``: IMouseEvent
            abstract target: IMouseTarget option

        /// A paste event originating from the editor.
        type [<AllowNullLiteral>] IPasteEvent =
            abstract range: Range
            abstract mode: string option

        type [<AllowNullLiteral>] IEditorConstructionOptions =
            inherit IEditorOptions
            /// The initial editor dimension (to avoid measuring the container).
            abstract dimension: IDimension option with get, set
            /// Place overflow widgets inside an external DOM node.
            /// Defaults to an internal DOM node.
            abstract overflowWidgetsDomNode: HTMLElement option with get, set

        /// A rich code editor.
        type [<AllowNullLiteral>] ICodeEditor =
            inherit IEditor
            /// <summary>An event emitted when the content of the current model has changed.</summary>
            abstract onDidChangeModelContent: listener: (IModelContentChangedEvent -> unit) -> IDisposable
            /// <summary>An event emitted when the language of the current model has changed.</summary>
            abstract onDidChangeModelLanguage: listener: (IModelLanguageChangedEvent -> unit) -> IDisposable
            /// <summary>An event emitted when the language configuration of the current model has changed.</summary>
            abstract onDidChangeModelLanguageConfiguration: listener: (IModelLanguageConfigurationChangedEvent -> unit) -> IDisposable
            /// <summary>An event emitted when the options of the current model has changed.</summary>
            abstract onDidChangeModelOptions: listener: (IModelOptionsChangedEvent -> unit) -> IDisposable
            /// <summary>An event emitted when the configuration of the editor has changed. (e.g. <c>editor.updateOptions()</c>)</summary>
            abstract onDidChangeConfiguration: listener: (ConfigurationChangedEvent -> unit) -> IDisposable
            /// <summary>An event emitted when the cursor position has changed.</summary>
            abstract onDidChangeCursorPosition: listener: (ICursorPositionChangedEvent -> unit) -> IDisposable
            /// <summary>An event emitted when the cursor selection has changed.</summary>
            abstract onDidChangeCursorSelection: listener: (ICursorSelectionChangedEvent -> unit) -> IDisposable
            /// <summary>An event emitted when the model of this editor has changed (e.g. <c>editor.setModel()</c>).</summary>
            abstract onDidChangeModel: listener: (IModelChangedEvent -> unit) -> IDisposable
            /// <summary>An event emitted when the decorations of the current model have changed.</summary>
            abstract onDidChangeModelDecorations: listener: (IModelDecorationsChangedEvent -> unit) -> IDisposable
            /// <summary>An event emitted when the text inside this editor gained focus (i.e. cursor starts blinking).</summary>
            abstract onDidFocusEditorText: listener: (unit -> unit) -> IDisposable
            /// <summary>An event emitted when the text inside this editor lost focus (i.e. cursor stops blinking).</summary>
            abstract onDidBlurEditorText: listener: (unit -> unit) -> IDisposable
            /// <summary>An event emitted when the text inside this editor or an editor widget gained focus.</summary>
            abstract onDidFocusEditorWidget: listener: (unit -> unit) -> IDisposable
            /// <summary>An event emitted when the text inside this editor or an editor widget lost focus.</summary>
            abstract onDidBlurEditorWidget: listener: (unit -> unit) -> IDisposable
            /// An event emitted after composition has started.
            abstract onDidCompositionStart: listener: (unit -> unit) -> IDisposable
            /// An event emitted after composition has ended.
            abstract onDidCompositionEnd: listener: (unit -> unit) -> IDisposable
            /// <summary>An event emitted when editing failed because the editor is read-only.</summary>
            abstract onDidAttemptReadOnlyEdit: listener: (unit -> unit) -> IDisposable
            /// <summary>An event emitted when users paste text in the editor.</summary>
            abstract onDidPaste: listener: (IPasteEvent -> unit) -> IDisposable
            /// <summary>An event emitted on a "mouseup".</summary>
            abstract onMouseUp: listener: (IEditorMouseEvent -> unit) -> IDisposable
            /// <summary>An event emitted on a "mousedown".</summary>
            abstract onMouseDown: listener: (IEditorMouseEvent -> unit) -> IDisposable
            /// <summary>An event emitted on a "contextmenu".</summary>
            abstract onContextMenu: listener: (IEditorMouseEvent -> unit) -> IDisposable
            /// <summary>An event emitted on a "mousemove".</summary>
            abstract onMouseMove: listener: (IEditorMouseEvent -> unit) -> IDisposable
            /// <summary>An event emitted on a "mouseleave".</summary>
            abstract onMouseLeave: listener: (IPartialEditorMouseEvent -> unit) -> IDisposable
            /// <summary>An event emitted on a "keyup".</summary>
            abstract onKeyUp: listener: (IKeyboardEvent -> unit) -> IDisposable
            /// <summary>An event emitted on a "keydown".</summary>
            abstract onKeyDown: listener: (IKeyboardEvent -> unit) -> IDisposable
            /// <summary>An event emitted when the layout of the editor has changed.</summary>
            abstract onDidLayoutChange: listener: (EditorLayoutInfo -> unit) -> IDisposable
            /// <summary>An event emitted when the content width or content height in the editor has changed.</summary>
            abstract onDidContentSizeChange: listener: (IContentSizeChangedEvent -> unit) -> IDisposable
            /// <summary>An event emitted when the scroll in the editor has changed.</summary>
            abstract onDidScrollChange: listener: (IScrollEvent -> unit) -> IDisposable
            /// Saves current view state of the editor in a serializable object.
            abstract saveViewState: unit -> ICodeEditorViewState option
            /// <summary>Restores the view state of the editor from a serializable object generated by <c>saveViewState</c>.</summary>
            abstract restoreViewState: state: ICodeEditorViewState -> unit
            /// Returns true if the text inside this editor or an editor widget has focus.
            abstract hasWidgetFocus: unit -> bool
            /// <summary>Get a contribution of this editor.</summary>
            /// <returns>The contribution or null if contribution not found.</returns>
            abstract getContribution: id: string -> 'T when 'T :> IEditorContribution
            /// Type the getModel() of IEditor.
            abstract getModel: unit -> ITextModel option
            /// Sets the current model attached to this editor.
            /// If the previous model was created by the editor via the value key in the options
            /// literal object, it will be destroyed. Otherwise, if the previous model was set
            /// via setModel, or the model key in the options literal object, the previous model
            /// will not be destroyed.
            /// It is safe to call setModel(null) to simply detach the current model from the editor.
            abstract setModel: model: ITextModel option -> unit
            /// Gets all the editor computed options.
            abstract getOptions: unit -> IComputedEditorOptions
            /// Gets a specific editor option.
            abstract getOption: id: 'T -> FindComputedEditorOptionValueById<'T> when 'T :> EditorOption
            /// Returns the editor's configuration (without any validation or defaults).
            abstract getRawOptions: unit -> IEditorOptions
            /// <summary>Get value of the current model attached to this editor.</summary>
            /// <seealso cref="`ITextModel.getValue`" />
            abstract getValue: ?options: {| preserveBOM: bool; lineEnding: string |} -> string
            /// <summary>Set the value of the current model attached to this editor.</summary>
            /// <seealso cref="`ITextModel.setValue`" />
            abstract setValue: newValue: string -> unit
            /// <summary>
            /// Get the width of the editor's content.
            /// This is information that is "erased" when computing <c>scrollWidth = Math.max(contentWidth, width)</c>
            /// </summary>
            abstract getContentWidth: unit -> float
            /// Get the scrollWidth of the editor's viewport.
            abstract getScrollWidth: unit -> float
            /// Get the scrollLeft of the editor's viewport.
            abstract getScrollLeft: unit -> float
            /// <summary>
            /// Get the height of the editor's content.
            /// This is information that is "erased" when computing <c>scrollHeight = Math.max(contentHeight, height)</c>
            /// </summary>
            abstract getContentHeight: unit -> float
            /// Get the scrollHeight of the editor's viewport.
            abstract getScrollHeight: unit -> float
            /// Get the scrollTop of the editor's viewport.
            abstract getScrollTop: unit -> float
            /// Change the scrollLeft of the editor's viewport.
            abstract setScrollLeft: newScrollLeft: float * ?scrollType: ScrollType -> unit
            /// Change the scrollTop of the editor's viewport.
            abstract setScrollTop: newScrollTop: float * ?scrollType: ScrollType -> unit
            /// Change the scroll position of the editor's viewport.
            abstract setScrollPosition: position: INewScrollPosition * ?scrollType: ScrollType -> unit
            /// <summary>Get an action that is a contribution to this editor.</summary>
            /// <returns>The action or null if action not found.</returns>
            abstract getAction: id: string -> IEditorAction
            /// <summary>
            /// Execute a command on the editor.
            /// The edits will land on the undo-redo stack, but no "undo stop" will be pushed.
            /// </summary>
            /// <param name="source">The source of the call.</param>
            /// <param name="command">The command to execute</param>
            abstract executeCommand: source: string option * command: ICommand -> unit
            /// Push an "undo stop" in the undo-redo stack.
            abstract pushUndoStop: unit -> bool
            /// <summary>
            /// Execute edits on the editor.
            /// The edits will land on the undo-redo stack, but no "undo stop" will be pushed.
            /// </summary>
            /// <param name="source">The source of the call.</param>
            /// <param name="edits">The edits to execute.</param>
            /// <param name="endCursorState">Cursor state after the edits were applied.</param>
            abstract executeEdits: source: string option * edits: ResizeArray<IIdentifiedSingleEditOperation> * ?endCursorState: U2<ICursorStateComputer, ResizeArray<Selection>> -> bool
            /// <summary>Execute multiple (concomitant) commands on the editor.</summary>
            /// <param name="source">The source of the call.</param>
            /// <param name="command">The commands to execute</param>
            abstract executeCommands: source: string option * commands: ResizeArray<ICommand option> -> unit
            /// Get all the decorations on a line (filtering out decorations from other editors).
            abstract getLineDecorations: lineNumber: float -> ResizeArray<IModelDecoration> option
            /// <summary>All decorations added through this call will get the ownerId of this editor.</summary>
            /// <seealso cref="`ITextModel.deltaDecorations`" />
            abstract deltaDecorations: oldDecorations: ResizeArray<string> * newDecorations: ResizeArray<IModelDeltaDecoration> -> ResizeArray<string>
            /// Get the layout info for the editor.
            abstract getLayoutInfo: unit -> EditorLayoutInfo
            /// Returns the ranges that are currently visible.
            /// Does not account for horizontal scrolling.
            abstract getVisibleRanges: unit -> ResizeArray<Range>
            /// Get the vertical position (top offset) for the line w.r.t. to the first line.
            abstract getTopForLineNumber: lineNumber: float -> float
            /// Get the vertical position (top offset) for the position w.r.t. to the first line.
            abstract getTopForPosition: lineNumber: float * column: float -> float
            /// Returns the editor's container dom node
            abstract getContainerDomNode: unit -> HTMLElement
            /// Returns the editor's dom node
            abstract getDomNode: unit -> HTMLElement option
            /// Add a content widget. Widgets must have unique ids, otherwise they will be overwritten.
            abstract addContentWidget: widget: IContentWidget -> unit
            /// Layout/Reposition a content widget. This is a ping to the editor to call widget.getPosition()
            /// and update appropriately.
            abstract layoutContentWidget: widget: IContentWidget -> unit
            /// Remove a content widget.
            abstract removeContentWidget: widget: IContentWidget -> unit
            /// Add an overlay widget. Widgets must have unique ids, otherwise they will be overwritten.
            abstract addOverlayWidget: widget: IOverlayWidget -> unit
            /// Layout/Reposition an overlay widget. This is a ping to the editor to call widget.getPosition()
            /// and update appropriately.
            abstract layoutOverlayWidget: widget: IOverlayWidget -> unit
            /// Remove an overlay widget.
            abstract removeOverlayWidget: widget: IOverlayWidget -> unit
            /// Change the view zones. View zones are lost when a new model is attached to the editor.
            abstract changeViewZones: callback: (IViewZoneChangeAccessor -> unit) -> unit
            /// <summary>
            /// Get the horizontal position (left offset) for the column w.r.t to the beginning of the line.
            /// This method works only if the line <c>lineNumber</c> is currently rendered (in the editor's viewport).
            /// Use this method with caution.
            /// </summary>
            abstract getOffsetForColumn: lineNumber: float * column: float -> float
            /// Force an editor render now.
            abstract render: ?forceRedraw: bool -> unit
            /// <summary>
            /// Get the hit test target at coordinates <c>clientX</c> and <c>clientY</c>.
            /// The coordinates are relative to the top-left of the viewport.
            /// </summary>
            /// <returns>Hit test target or null if the coordinates fall outside the editor or the editor has no model.</returns>
            abstract getTargetAtClientPoint: clientX: float * clientY: float -> IMouseTarget option
            /// <summary>
            /// Get the visible position for <c>position</c>.
            /// The result position takes scrolling into account and is relative to the top left corner of the editor.
            /// Explanation 1: the results of this method will change for the same <c>position</c> if the user scrolls the editor.
            /// Explanation 2: the results of this method will not change if the container of the editor gets repositioned.
            /// Warning: the results of this method are inaccurate for positions that are outside the current editor viewport.
            /// </summary>
            abstract getScrolledVisiblePosition: position: IPosition -> {| top: float; left: float; height: float |} option
            /// <summary>Apply the same font settings as the editor to <c>target</c>.</summary>
            abstract applyFontInfo: target: HTMLElement -> unit

        /// Information about a line in the diff editor
        type [<AllowNullLiteral>] IDiffLineInformation =
            abstract equivalentLineNumber: float

        /// A rich diff editor.
        type [<AllowNullLiteral>] IDiffEditor =
            inherit IEditor
            /// <seealso cref="ICodeEditor.getDomNode" />
            abstract getDomNode: unit -> HTMLElement
            /// <summary>An event emitted when the diff information computed by this diff editor has been updated.</summary>
            abstract onDidUpdateDiff: listener: (unit -> unit) -> IDisposable
            /// Saves current view state of the editor in a serializable object.
            abstract saveViewState: unit -> IDiffEditorViewState option
            /// <summary>Restores the view state of the editor from a serializable object generated by <c>saveViewState</c>.</summary>
            abstract restoreViewState: state: IDiffEditorViewState -> unit
            /// Type the getModel() of IEditor.
            abstract getModel: unit -> IDiffEditorModel option
            /// Sets the current model attached to this editor.
            /// If the previous model was created by the editor via the value key in the options
            /// literal object, it will be destroyed. Otherwise, if the previous model was set
            /// via setModel, or the model key in the options literal object, the previous model
            /// will not be destroyed.
            /// It is safe to call setModel(null) to simply detach the current model from the editor.
            abstract setModel: model: IDiffEditorModel option -> unit
            /// <summary>Get the <c>original</c> editor.</summary>
            abstract getOriginalEditor: unit -> ICodeEditor
            /// <summary>Get the <c>modified</c> editor.</summary>
            abstract getModifiedEditor: unit -> ICodeEditor
            /// Get the computed diff information.
            abstract getLineChanges: unit -> ResizeArray<ILineChange> option
            /// Get information based on computed diff about a line number from the original model.
            /// If the diff computation is not finished or the model is missing, will return null.
            abstract getDiffLineInformationForOriginal: lineNumber: float -> IDiffLineInformation option
            /// Get information based on computed diff about a line number from the modified model.
            /// If the diff computation is not finished or the model is missing, will return null.
            abstract getDiffLineInformationForModified: lineNumber: float -> IDiffLineInformation option
            /// Update the editor's options after the editor has been created.
            abstract updateOptions: newOptions: IDiffEditorOptions -> unit

        type [<AllowNullLiteral>] FontInfo =
            inherit BareFontInfo
            abstract _editorStylingBrand: unit
            abstract isTrusted: bool
            abstract isMonospace: bool
            abstract typicalHalfwidthCharacterWidth: float
            abstract typicalFullwidthCharacterWidth: float
            abstract canUseHalfwidthRightwardsArrow: bool
            abstract spaceWidth: float
            abstract middotWidth: float
            abstract wsmiddotWidth: float
            abstract maxDigitWidth: float

        type [<AllowNullLiteral>] FontInfoStatic =
            [<EmitConstructor>] abstract Create: unit -> FontInfo

        type [<AllowNullLiteral>] BareFontInfo =
            abstract _bareFontInfoBrand: unit
            abstract zoomLevel: float
            abstract fontFamily: string
            abstract fontWeight: string
            abstract fontSize: float
            abstract fontFeatureSettings: string
            abstract lineHeight: float
            abstract letterSpacing: float

        type [<AllowNullLiteral>] BareFontInfoStatic =
            [<EmitConstructor>] abstract Create: unit -> BareFontInfo

        type IReadOnlyModel =
            ITextModel

        type IModel =
            ITextModel

        type [<StringEnum>] [<RequireQualifiedAccess>] IExportsEditorOptionsAcceptSuggestionOnEnterIEditorOption =
            | On
            | Off
            | Smart

        type [<StringEnum>] [<RequireQualifiedAccess>] IExportsEditorOptionsCursorSurroundingLinesStyleIEditorOption =
            | Default
            | All

        type [<StringEnum>] [<RequireQualifiedAccess>] IExportsEditorOptionsFoldingStrategyIEditorOption =
            | Auto
            | Indentation

        type [<StringEnum>] [<RequireQualifiedAccess>] IExportsEditorOptionsMatchBracketsIEditorOption =
            | Always
            | Never
            | Near

        type [<StringEnum>] [<RequireQualifiedAccess>] IExportsEditorOptionsMouseStyleIEditorOption =
            | Default
            | Text
            | Copy

        type [<StringEnum>] [<RequireQualifiedAccess>] IExportsEditorOptionsMultiCursorModifierIEditorOption =
            | AltKey
            | MetaKey
            | CtrlKey

        type [<StringEnum>] [<RequireQualifiedAccess>] IExportsEditorOptionsMultiCursorPasteIEditorOption =
            | Spread
            | Full

        type [<StringEnum>] [<RequireQualifiedAccess>] IExportsEditorOptionsPeekWidgetDefaultFocusIEditorOption =
            | Tree
            | Editor

        type [<StringEnum>] [<RequireQualifiedAccess>] IExportsEditorOptionsRenderLineHighlightIEditorOption =
            | All
            | Line
            | None
            | Gutter

        type [<StringEnum>] [<RequireQualifiedAccess>] IExportsEditorOptionsRenderValidationDecorationsIEditorOption =
            | On
            | Off
            | Editable

        type [<StringEnum>] [<RequireQualifiedAccess>] IExportsEditorOptionsRenderWhitespaceIEditorOption =
            | All
            | None
            | Boundary
            | Selection
            | Trailing

        type [<AllowNullLiteral>] IExportsEditorOptionsRulersIEditorOption =
            interface end

        type [<StringEnum>] [<RequireQualifiedAccess>] IExportsEditorOptionsShowFoldingControlsIEditorOption =
            | Always
            | Mouseover

        type [<StringEnum>] [<RequireQualifiedAccess>] IExportsEditorOptionsSnippetSuggestionsIEditorOption =
            | None
            | Top
            | Bottom
            | Inline

        type [<StringEnum>] [<RequireQualifiedAccess>] IExportsEditorOptionsSuggestSelectionIEditorOption =
            | First
            | RecentlyUsed
            | RecentlyUsedByPrefix

        type [<StringEnum>] [<RequireQualifiedAccess>] IExportsEditorOptionsTabCompletionIEditorOption =
            | On
            | Off
            | OnlySnippets

        type [<StringEnum>] [<RequireQualifiedAccess>] IExportsEditorOptionsUnusualLineTerminatorsIEditorOption =
            | Off
            | Prompt
            | Auto

        type [<StringEnum>] [<RequireQualifiedAccess>] IExportsEditorOptionsWordWrapIEditorOption =
            | On
            | Off
            | WordWrapColumn
            | Bounded

        type [<StringEnum>] [<RequireQualifiedAccess>] IExportsEditorOptionsWrappingStrategyIEditorOption =
            | Simple
            | Advanced

        type [<AllowNullLiteral>] IExportsEditorOptions =
            abstract acceptSuggestionOnCommitCharacter: IEditorOption<EditorOption, bool> with get, set
            abstract acceptSuggestionOnEnter: IEditorOption<EditorOption, IExportsEditorOptionsAcceptSuggestionOnEnterIEditorOption> with get, set
            abstract accessibilitySupport: IEditorOption<EditorOption, AccessibilitySupport> with get, set
            abstract accessibilityPageSize: IEditorOption<EditorOption, float> with get, set
            abstract ariaLabel: IEditorOption<EditorOption, string> with get, set
            abstract autoClosingBrackets: IEditorOption<EditorOption, EditorAutoClosingStrategy> with get, set
            abstract autoClosingOvertype: IEditorOption<EditorOption, EditorAutoClosingOvertypeStrategy> with get, set
            abstract autoClosingQuotes: IEditorOption<EditorOption, EditorAutoClosingStrategy> with get, set
            abstract autoIndent: IEditorOption<EditorOption, EditorAutoIndentStrategy> with get, set
            abstract automaticLayout: IEditorOption<EditorOption, bool> with get, set
            abstract autoSurround: IEditorOption<EditorOption, EditorAutoSurroundStrategy> with get, set
            abstract codeLens: IEditorOption<EditorOption, bool> with get, set
            abstract colorDecorators: IEditorOption<EditorOption, bool> with get, set
            abstract columnSelection: IEditorOption<EditorOption, bool> with get, set
            abstract comments: IEditorOption<EditorOption, EditorCommentsOptions> with get, set
            abstract contextmenu: IEditorOption<EditorOption, bool> with get, set
            abstract copyWithSyntaxHighlighting: IEditorOption<EditorOption, bool> with get, set
            abstract cursorBlinking: IEditorOption<EditorOption, TextEditorCursorBlinkingStyle> with get, set
            abstract cursorSmoothCaretAnimation: IEditorOption<EditorOption, bool> with get, set
            abstract cursorStyle: IEditorOption<EditorOption, TextEditorCursorStyle> with get, set
            abstract cursorSurroundingLines: IEditorOption<EditorOption, float> with get, set
            abstract cursorSurroundingLinesStyle: IEditorOption<EditorOption, IExportsEditorOptionsCursorSurroundingLinesStyleIEditorOption> with get, set
            abstract cursorWidth: IEditorOption<EditorOption, float> with get, set
            abstract disableLayerHinting: IEditorOption<EditorOption, bool> with get, set
            abstract disableMonospaceOptimizations: IEditorOption<EditorOption, bool> with get, set
            abstract dragAndDrop: IEditorOption<EditorOption, bool> with get, set
            abstract emptySelectionClipboard: IEditorOption<EditorOption, bool> with get, set
            abstract extraEditorClassName: IEditorOption<EditorOption, string> with get, set
            abstract fastScrollSensitivity: IEditorOption<EditorOption, float> with get, set
            abstract find: IEditorOption<EditorOption, EditorFindOptions> with get, set
            abstract fixedOverflowWidgets: IEditorOption<EditorOption, bool> with get, set
            abstract folding: IEditorOption<EditorOption, bool> with get, set
            abstract foldingStrategy: IEditorOption<EditorOption, IExportsEditorOptionsFoldingStrategyIEditorOption> with get, set
            abstract foldingHighlight: IEditorOption<EditorOption, bool> with get, set
            abstract unfoldOnClickAfterEndOfLine: IEditorOption<EditorOption, bool> with get, set
            abstract fontFamily: IEditorOption<EditorOption, string> with get, set
            abstract fontInfo: IEditorOption<EditorOption, FontInfo> with get, set
            abstract fontLigatures2: IEditorOption<EditorOption, string> with get, set
            abstract fontSize: IEditorOption<EditorOption, float> with get, set
            abstract fontWeight: IEditorOption<EditorOption, string> with get, set
            abstract formatOnPaste: IEditorOption<EditorOption, bool> with get, set
            abstract formatOnType: IEditorOption<EditorOption, bool> with get, set
            abstract glyphMargin: IEditorOption<EditorOption, bool> with get, set
            abstract gotoLocation: IEditorOption<EditorOption, GoToLocationOptions> with get, set
            abstract hideCursorInOverviewRuler: IEditorOption<EditorOption, bool> with get, set
            abstract highlightActiveIndentGuide: IEditorOption<EditorOption, bool> with get, set
            abstract hover: IEditorOption<EditorOption, EditorHoverOptions> with get, set
            abstract inDiffEditor: IEditorOption<EditorOption, bool> with get, set
            abstract letterSpacing: IEditorOption<EditorOption, float> with get, set
            abstract lightbulb: IEditorOption<EditorOption, EditorLightbulbOptions> with get, set
            abstract lineDecorationsWidth: IEditorOption<EditorOption, U2<string, float>> with get, set
            abstract lineHeight: IEditorOption<EditorOption, float> with get, set
            abstract lineNumbers: IEditorOption<EditorOption, InternalEditorRenderLineNumbersOptions> with get, set
            abstract lineNumbersMinChars: IEditorOption<EditorOption, float> with get, set
            abstract links: IEditorOption<EditorOption, bool> with get, set
            abstract matchBrackets: IEditorOption<EditorOption, IExportsEditorOptionsMatchBracketsIEditorOption> with get, set
            abstract minimap: IEditorOption<EditorOption, EditorMinimapOptions> with get, set
            abstract mouseStyle: IEditorOption<EditorOption, IExportsEditorOptionsMouseStyleIEditorOption> with get, set
            abstract mouseWheelScrollSensitivity: IEditorOption<EditorOption, float> with get, set
            abstract mouseWheelZoom: IEditorOption<EditorOption, bool> with get, set
            abstract multiCursorMergeOverlapping: IEditorOption<EditorOption, bool> with get, set
            abstract multiCursorModifier: IEditorOption<EditorOption, IExportsEditorOptionsMultiCursorModifierIEditorOption> with get, set
            abstract multiCursorPaste: IEditorOption<EditorOption, IExportsEditorOptionsMultiCursorPasteIEditorOption> with get, set
            abstract occurrencesHighlight: IEditorOption<EditorOption, bool> with get, set
            abstract overviewRulerBorder: IEditorOption<EditorOption, bool> with get, set
            abstract overviewRulerLanes: IEditorOption<EditorOption, float> with get, set
            abstract padding: IEditorOption<EditorOption, InternalEditorPaddingOptions> with get, set
            abstract parameterHints: IEditorOption<EditorOption, InternalParameterHintOptions> with get, set
            abstract peekWidgetDefaultFocus: IEditorOption<EditorOption, IExportsEditorOptionsPeekWidgetDefaultFocusIEditorOption> with get, set
            abstract definitionLinkOpensInPeek: IEditorOption<EditorOption, bool> with get, set
            abstract quickSuggestions: IEditorOption<EditorOption, ValidQuickSuggestionsOptions> with get, set
            abstract quickSuggestionsDelay: IEditorOption<EditorOption, float> with get, set
            abstract readOnly: IEditorOption<EditorOption, bool> with get, set
            abstract renameOnType: IEditorOption<EditorOption, bool> with get, set
            abstract renderControlCharacters: IEditorOption<EditorOption, bool> with get, set
            abstract renderIndentGuides: IEditorOption<EditorOption, bool> with get, set
            abstract renderFinalNewline: IEditorOption<EditorOption, bool> with get, set
            abstract renderLineHighlight: IEditorOption<EditorOption, IExportsEditorOptionsRenderLineHighlightIEditorOption> with get, set
            abstract renderLineHighlightOnlyWhenFocus: IEditorOption<EditorOption, bool> with get, set
            abstract renderValidationDecorations: IEditorOption<EditorOption, IExportsEditorOptionsRenderValidationDecorationsIEditorOption> with get, set
            abstract renderWhitespace: IEditorOption<EditorOption, IExportsEditorOptionsRenderWhitespaceIEditorOption> with get, set
            abstract revealHorizontalRightPadding: IEditorOption<EditorOption, float> with get, set
            abstract roundedSelection: IEditorOption<EditorOption, bool> with get, set
            abstract rulers: IEditorOption<EditorOption, IExportsEditorOptionsRulersIEditorOption> with get, set
            abstract scrollbar: IEditorOption<EditorOption, InternalEditorScrollbarOptions> with get, set
            abstract scrollBeyondLastColumn: IEditorOption<EditorOption, float> with get, set
            abstract scrollBeyondLastLine: IEditorOption<EditorOption, bool> with get, set
            abstract scrollPredominantAxis: IEditorOption<EditorOption, bool> with get, set
            abstract selectionClipboard: IEditorOption<EditorOption, bool> with get, set
            abstract selectionHighlight: IEditorOption<EditorOption, bool> with get, set
            abstract selectOnLineNumbers: IEditorOption<EditorOption, bool> with get, set
            abstract showFoldingControls: IEditorOption<EditorOption, IExportsEditorOptionsShowFoldingControlsIEditorOption> with get, set
            abstract showUnused: IEditorOption<EditorOption, bool> with get, set
            abstract showDeprecated: IEditorOption<EditorOption, bool> with get, set
            abstract snippetSuggestions: IEditorOption<EditorOption, IExportsEditorOptionsSnippetSuggestionsIEditorOption> with get, set
            abstract smoothScrolling: IEditorOption<EditorOption, bool> with get, set
            abstract stopRenderingLineAfter: IEditorOption<EditorOption, float> with get, set
            abstract suggest: IEditorOption<EditorOption, InternalSuggestOptions> with get, set
            abstract suggestFontSize: IEditorOption<EditorOption, float> with get, set
            abstract suggestLineHeight: IEditorOption<EditorOption, float> with get, set
            abstract suggestOnTriggerCharacters: IEditorOption<EditorOption, bool> with get, set
            abstract suggestSelection: IEditorOption<EditorOption, IExportsEditorOptionsSuggestSelectionIEditorOption> with get, set
            abstract tabCompletion: IEditorOption<EditorOption, IExportsEditorOptionsTabCompletionIEditorOption> with get, set
            abstract tabIndex: IEditorOption<EditorOption, float> with get, set
            abstract unusualLineTerminators: IEditorOption<EditorOption, IExportsEditorOptionsUnusualLineTerminatorsIEditorOption> with get, set
            abstract useTabStops: IEditorOption<EditorOption, bool> with get, set
            abstract wordSeparators: IEditorOption<EditorOption, string> with get, set
            abstract wordWrap: IEditorOption<EditorOption, IExportsEditorOptionsWordWrapIEditorOption> with get, set
            abstract wordWrapBreakAfterCharacters: IEditorOption<EditorOption, string> with get, set
            abstract wordWrapBreakBeforeCharacters: IEditorOption<EditorOption, string> with get, set
            abstract wordWrapColumn: IEditorOption<EditorOption, float> with get, set
            abstract wordWrapMinified: IEditorOption<EditorOption, bool> with get, set
            abstract wrappingIndent: IEditorOption<EditorOption, WrappingIndent> with get, set
            abstract wrappingStrategy: IEditorOption<EditorOption, IExportsEditorOptionsWrappingStrategyIEditorOption> with get, set
            abstract editorClassName: IEditorOption<EditorOption, string> with get, set
            abstract pixelRatio: IEditorOption<EditorOption, float> with get, set
            abstract tabFocusMode: IEditorOption<EditorOption, bool> with get, set
            abstract layoutInfo: IEditorOption<EditorOption, EditorLayoutInfo> with get, set
            abstract wrappingInfo: IEditorOption<EditorOption, EditorWrappingInfo> with get, set

        type [<StringEnum>] [<RequireQualifiedAccess>] IGlobalEditorOptionsSemanticHighlightingEnabled =
            | ConfiguredByTheme

        type [<StringEnum>] [<RequireQualifiedAccess>] IEditorOptionsRenderValidationDecorations =
            | Editable
            | On
            | Off

        type [<StringEnum>] [<RequireQualifiedAccess>] IEditorOptionsCursorBlinking =
            | Blink
            | Smooth
            | Phase
            | Expand
            | Solid

        type [<StringEnum>] [<RequireQualifiedAccess>] IEditorOptionsMouseStyle =
            | Text
            | Default
            | Copy

        type [<StringEnum>] [<RequireQualifiedAccess>] IEditorOptionsCursorStyle =
            | Line
            | Block
            | Underline
            | [<CompiledName "line-thin">] LineThin
            | [<CompiledName "block-outline">] BlockOutline
            | [<CompiledName "underline-thin">] UnderlineThin

        type [<StringEnum>] [<RequireQualifiedAccess>] IEditorOptionsWordWrap =
            | Off
            | On
            | WordWrapColumn
            | Bounded

        type [<StringEnum>] [<RequireQualifiedAccess>] IEditorOptionsWrappingIndent =
            | None
            | Same
            | Indent
            | DeepIndent

        type [<StringEnum>] [<RequireQualifiedAccess>] IEditorOptionsMultiCursorModifier =
            | CtrlCmd
            | Alt

        type [<StringEnum>] [<RequireQualifiedAccess>] IEditorOptionsAccessibilitySupport =
            | Auto
            | Off
            | On

        type [<StringEnum>] [<RequireQualifiedAccess>] IEditorOptionsAutoIndent =
            | None
            | Keep
            | Brackets
            | Advanced
            | Full

        type [<StringEnum>] [<RequireQualifiedAccess>] IEditorOptionsAcceptSuggestionOnEnter =
            | On
            | Smart
            | Off

        type [<StringEnum>] [<RequireQualifiedAccess>] IEditorOptionsSnippetSuggestions =
            | Top
            | Bottom
            | Inline
            | None

        type [<StringEnum>] [<RequireQualifiedAccess>] IEditorOptionsMatchBrackets =
            | Never
            | Near
            | Always

        type [<StringEnum>] [<RequireQualifiedAccess>] IEditorOptionsRenderWhitespace =
            | None
            | Boundary
            | Selection
            | Trailing
            | All

        type [<StringEnum>] [<RequireQualifiedAccess>] IEditorOptionsRenderLineHighlight =
            | None
            | Gutter
            | Line
            | All

        type [<StringEnum>] [<RequireQualifiedAccess>] IEditorFindOptionsAutoFindInSelection =
            | Never
            | Always
            | Multiline

        type [<StringEnum>] [<RequireQualifiedAccess>] IEditorMinimapOptionsSide =
            | Right
            | Left

        type [<StringEnum>] [<RequireQualifiedAccess>] IEditorMinimapOptionsSize =
            | Proportional
            | Fill
            | Fit

        type [<StringEnum>] [<RequireQualifiedAccess>] IEditorScrollbarOptionsVertical =
            | Auto
            | Visible
            | Hidden

        type [<StringEnum>] [<RequireQualifiedAccess>] ISuggestOptionsInsertMode =
            | Insert
            | Replace

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
            abstract getEncodedLanguageId: languageId: string -> float
            /// <summary>An event emitted when a language is first time needed (e.g. a model has it set).</summary>
            abstract onLanguage: languageId: string * callback: (unit -> unit) -> IDisposable
            /// Set the editing configuration for a language.
            abstract setLanguageConfiguration: languageId: string * configuration: LanguageConfiguration -> IDisposable
            /// Set the tokens provider for a language (manual implementation).
            abstract setTokensProvider: languageId: string * provider: U3<TokensProvider, EncodedTokensProvider, Thenable<U2<TokensProvider, EncodedTokensProvider>>> -> IDisposable
            /// Set the tokens provider for a language (monarch implementation).
            abstract setMonarchTokensProvider: languageId: string * languageDef: U2<IMonarchLanguage, Thenable<IMonarchLanguage>> -> IDisposable
            /// Register a reference provider (used by e.g. reference search).
            abstract registerReferenceProvider: languageId: string * provider: ReferenceProvider -> IDisposable
            /// Register a rename provider (used by e.g. rename symbol).
            abstract registerRenameProvider: languageId: string * provider: RenameProvider -> IDisposable
            /// Register a signature help provider (used by e.g. parameter hints).
            abstract registerSignatureHelpProvider: languageId: string * provider: SignatureHelpProvider -> IDisposable
            /// Register a hover provider (used by e.g. editor hover).
            abstract registerHoverProvider: languageId: string * provider: HoverProvider -> IDisposable
            /// Register a document symbol provider (used by e.g. outline).
            abstract registerDocumentSymbolProvider: languageId: string * provider: DocumentSymbolProvider -> IDisposable
            /// Register a document highlight provider (used by e.g. highlight occurrences).
            abstract registerDocumentHighlightProvider: languageId: string * provider: DocumentHighlightProvider -> IDisposable
            /// Register an on type rename provider.
            abstract registerOnTypeRenameProvider: languageId: string * provider: OnTypeRenameProvider -> IDisposable
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
            /// Register a document color provider (used by Color Picker, Color Decorator).
            abstract registerColorProvider: languageId: string * provider: DocumentColorProvider -> IDisposable
            /// Register a folding range provider
            abstract registerFoldingRangeProvider: languageId: string * provider: FoldingRangeProvider -> IDisposable
            /// Register a declaration provider
            abstract registerDeclarationProvider: languageId: string * provider: DeclarationProvider -> IDisposable
            /// Register a selection range provider
            abstract registerSelectionRangeProvider: languageId: string * provider: SelectionRangeProvider -> IDisposable
            /// Register a document semantic tokens provider
            abstract registerDocumentSemanticTokensProvider: languageId: string * provider: DocumentSemanticTokensProvider -> IDisposable
            /// Register a document range semantic tokens provider
            abstract registerDocumentRangeSemanticTokensProvider: languageId: string * provider: DocumentRangeSemanticTokensProvider -> IDisposable
            abstract FoldingRangeKind: FoldingRangeKindStatic

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

        /// The result of a line tokenization.
        type [<AllowNullLiteral>] IEncodedLineTokens =
            /// <summary>
            /// The tokens on the line in a binary, encoded format. Each token occupies two array indices. For token i:
            ///   - at offset 2*i => startIndex
            ///   - at offset 2*i + 1 => metadata
            /// Meta data is in binary format:
            /// - -------------------------------------------
            ///      3322 2222 2222 1111 1111 1100 0000 0000
            ///      1098 7654 3210 9876 5432 1098 7654 3210
            /// - -------------------------------------------
            ///      bbbb bbbb bfff ffff ffFF FTTT LLLL LLLL
            /// - -------------------------------------------
            ///   - L = EncodedLanguageId (8 bits): Use <c>getEncodedLanguageId</c> to get the encoded ID of a language.
            ///   - T = StandardTokenType (3 bits): Other = 0, Comment = 1, String = 2, RegEx = 4.
            ///   - F = FontStyle (3 bits): None = 0, Italic = 1, Bold = 2, Underline = 4.
            ///   - f = foreground ColorId (9 bits)
            ///   - b = background ColorId (9 bits)
            ///   - The color value for each colorId is defined in IStandaloneThemeData.customTokenColors:
            /// e.g. colorId = 1 is stored in IStandaloneThemeData.customTokenColors[1]. Color id = 0 means no color,
            /// id = 1 is for the default foreground color, id = 2 for the default background.
            /// </summary>
            abstract tokens: Uint32Array with get, set
            /// The tokenization end state.
            /// A pointer will be held to this and the object should not be modified by the tokenizer after the pointer is returned.
            abstract endState: IState with get, set

        /// A "manual" provider of tokens.
        type [<AllowNullLiteral>] TokensProvider =
            /// The initial state of a language. Will be the state passed in to tokenize the first line.
            abstract getInitialState: unit -> IState
            /// Tokenize a line given the state at the beginning of the line.
            abstract tokenize: line: string * state: IState -> ILineTokens

        /// A "manual" provider of tokens, returning tokens in a binary form.
        type [<AllowNullLiteral>] EncodedTokensProvider =
            /// The initial state of a language. Will be the state passed in to tokenize the first line.
            abstract getInitialState: unit -> IState
            /// Tokenize a line given the state at the beginning of the line.
            abstract tokenizeEncoded: line: string * state: IState -> IEncodedLineTokens

        /// <summary>
        /// Contains additional diagnostic information about the context in which
        /// a <see cref="CodeActionProvider.provideCodeActions">code action</see> is run.
        /// </summary>
        type [<AllowNullLiteral>] CodeActionContext =
            /// An array of diagnostics.
            abstract markers: ResizeArray<Editor.IMarkerData>
            /// Requested kind of actions to return.
            abstract only: string option

        /// <summary>
        /// The code action interface defines the contract between extensions and
        /// the <see href="https://code.visualstudio.com/docs/editor/editingevolved#_code-action">light bulb</see> feature.
        /// </summary>
        type [<AllowNullLiteral>] CodeActionProvider =
            /// Provide commands for the given document and range.
            abstract provideCodeActions: model: Editor.ITextModel * range: Range * context: CodeActionContext * token: CancellationToken -> ProviderResult<CodeActionList>

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
            /// Defines what characters must be after the cursor for bracket or quote autoclosing to occur when using the \'languageDefined\' autoclosing setting.
            /// 
            /// This is typically the set of characters which can not start an expression, such as whitespace, closing brackets, non-unary operators, etc.
            abstract autoCloseBefore: string option with get, set
            /// The language's folding rules.
            abstract folding: FoldingRules option with get, set
            /// **Deprecated** Do not use.
            [<Obsolete("Will be replaced by a better API soon.")>]
            abstract __electricCharacterSupport: {| docComment: IDocComment option |} option with get, set

        /// Describes indentation rules for a language.
        type [<AllowNullLiteral>] IndentationRule =
            /// If a line matches this pattern, then all the lines after it should be unindented once (until another rule matches).
            abstract decreaseIndentPattern: RegExp with get, set
            /// If a line matches this pattern, then all the lines after it should be indented once (until another rule matches).
            abstract increaseIndentPattern: RegExp with get, set
            /// If a line matches this pattern, then **only the next line** after it should be indented once.
            abstract indentNextLinePattern: RegExp option with get, set
            /// If a line matches this pattern, then its indentation should not be changed and it should not be evaluated against the other rules.
            abstract unIndentedLinePattern: RegExp option with get, set

        /// Describes language specific folding markers such as '#region' and '#endregion'.
        /// The start and end regexes will be tested against the contents of all lines and must be designed efficiently:
        /// - the regex should start with '^'
        /// - regexp flags (i, g) are ignored
        type [<AllowNullLiteral>] FoldingMarkers =
            abstract start: RegExp with get, set
            abstract ``end``: RegExp with get, set

        /// Describes folding rules for a language.
        type [<AllowNullLiteral>] FoldingRules =
            /// <summary>
            /// Used by the indentation based strategy to decide whether empty lines belong to the previous or the next block.
            /// A language adheres to the off-side rule if blocks in that language are expressed by their indentation.
            /// See <see href="https://en.wikipedia.org/wiki/Off-side_rule">wikipedia</see> for more information.
            /// If not set, <c>false</c> is used and empty lines belong to the previous block.
            /// </summary>
            abstract offSide: bool option with get, set
            /// Region markers used by the language.
            abstract markers: FoldingMarkers option with get, set

        /// Describes a rule to be evaluated when pressing Enter.
        type [<AllowNullLiteral>] OnEnterRule =
            /// This rule will only execute if the text before the cursor matches this regular expression.
            abstract beforeText: RegExp with get, set
            /// This rule will only execute if the text after the cursor matches this regular expression.
            abstract afterText: RegExp option with get, set
            /// This rule will only execute if the text above the this line matches this regular expression.
            abstract oneLineAboveText: RegExp option with get, set
            /// The action to execute.
            abstract action: EnterAction with get, set

        /// Definition of documentation comments (e.g. Javadoc/JSdoc)
        type [<AllowNullLiteral>] IDocComment =
            /// The string that starts a doc comment (e.g. '/**')
            abstract ``open``: string with get, set
            /// The string that appears on the last line and closes the doc comment (e.g. ' * /').
            abstract close: string option with get, set

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

        /// <summary>
        /// A provider result represents the values a provider, like the <see cref="HoverProvider"><c>HoverProvider</c></see>,
        /// may return. For once this is the actual result type <c>T</c>, like <c>Hover</c>, or a thenable that resolves
        /// to that type <c>T</c>. In addition, <c>null</c> and <c>undefined</c> can be returned - either directly or from a
        /// thenable.
        /// </summary>
        type ProviderResult<'T> =
            U2<'T, Thenable<'T option>> option

        /// A hover represents additional information for a symbol or word. Hovers are
        /// rendered in a tooltip-like widget.
        type [<AllowNullLiteral>] Hover =
            /// The contents of this hover.
            abstract contents: ResizeArray<IMarkdownString> with get, set
            /// The range to which this hover applies. When missing, the
            /// editor will use the range at the current position or the
            /// current position itself.
            abstract range: IRange option with get, set

        /// <summary>
        /// The hover provider interface defines the contract between extensions and
        /// the <see href="https://code.visualstudio.com/docs/editor/intellisense">hover</see>-feature.
        /// </summary>
        type [<AllowNullLiteral>] HoverProvider =
            /// Provide a hover for the given position and document. Multiple hovers at the same
            /// position will be merged by the editor. A hover can have a range which defaults
            /// to the word range at the position when omitted.
            abstract provideHover: model: Editor.ITextModel * position: Position * token: CancellationToken -> ProviderResult<Hover>

        type [<RequireQualifiedAccess>] CompletionItemKind =
            | Method = 0
            | Function = 1
            | Constructor = 2
            | Field = 3
            | Variable = 4
            | Class = 5
            | Struct = 6
            | Interface = 7
            | Module = 8
            | Property = 9
            | Event = 10
            | Operator = 11
            | Unit = 12
            | Value = 13
            | Constant = 14
            | Enum = 15
            | EnumMember = 16
            | Keyword = 17
            | Text = 18
            | Color = 19
            | File = 20
            | Reference = 21
            | Customcolor = 22
            | Folder = 23
            | TypeParameter = 24
            | User = 25
            | Issue = 26
            | Snippet = 27

        type [<AllowNullLiteral>] CompletionItemLabel =
            /// The function or variable. Rendered leftmost.
            abstract name: string with get, set
            /// <summary>The parameters without the return type. Render after <c>name</c>.</summary>
            abstract parameters: string option with get, set
            /// <summary>The fully qualified name, like package name or file path. Rendered after <c>signature</c>.</summary>
            abstract qualifier: string option with get, set
            /// The return-type of a function or type of a property/variable. Rendered rightmost.
            abstract ``type``: string option with get, set

        type [<RequireQualifiedAccess>] CompletionItemTag =
            | Deprecated = 1

        type [<RequireQualifiedAccess>] CompletionItemInsertTextRule =
            /// Adjust whitespace/indentation of multiline insert texts to
            /// match the current line indentation.
            | KeepWhitespace = 1
            /// <summary><c>insertText</c> is a snippet.</summary>
            | InsertAsSnippet = 4

        /// A completion item represents a text snippet that is
        /// proposed to complete text that is being typed.
        type [<AllowNullLiteral>] CompletionItem =
            /// The label of this completion item. By default
            /// this is also the text that is inserted when selecting
            /// this completion.
            abstract label: U2<string, CompletionItemLabel> with get, set
            /// The kind of this completion item. Based on the kind
            /// an icon is chosen by the editor.
            abstract kind: CompletionItemKind with get, set
            /// <summary>
            /// A modifier to the <c>kind</c> which affect how the item
            /// is rendered, e.g. Deprecated is rendered with a strikeout
            /// </summary>
            abstract tags: ReadonlyArray<CompletionItemTag> option with get, set
            /// A human-readable string with additional information
            /// about this item, like type or symbol information.
            abstract detail: string option with get, set
            /// A human-readable string that represents a doc-comment.
            abstract documentation: U2<string, IMarkdownString> option with get, set
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
            /// Select this item when showing. *Note* that only one completion item can be selected and
            /// that the editor decides which item that is. The rule is that the *first* item of those
            /// that match best is selected.
            abstract preselect: bool option with get, set
            /// A string or snippet that should be inserted in a document when selecting
            /// this completion.
            /// is used.
            abstract insertText: string with get, set
            /// Addition rules (as bitmask) that should be applied when inserting
            /// this completion.
            abstract insertTextRules: CompletionItemInsertTextRule option with get, set
            /// <summary>
            /// A range of text that should be replaced by this completion item.
            /// 
            /// Defaults to a range from the start of the <see cref="TextDocument.getWordRangeAtPosition">current word</see> to the
            /// current position.
            /// 
            /// *Note:* The range must be a <see cref="Range.isSingleLine">single line</see> and it must
            /// <see cref="Range.contains">contain</see> the position at which completion has been <see cref="CompletionItemProvider.provideCompletionItems">requested</see>.
            /// </summary>
            abstract range: U2<IRange, {| insert: IRange; replace: IRange |}> with get, set
            /// <summary>
            /// An optional set of characters that when pressed while this completion is active will accept it first and
            /// then type that character. *Note* that all commit characters should have <c>length=1</c> and that superfluous
            /// characters will be ignored.
            /// </summary>
            abstract commitCharacters: ResizeArray<string> option with get, set
            /// An optional array of additional text edits that are applied when
            /// selecting this completion. Edits must not overlap with the main edit
            /// nor with themselves.
            abstract additionalTextEdits: ResizeArray<Editor.ISingleEditOperation> option with get, set
            /// A command that should be run upon acceptance of this item.
            abstract command: Command option with get, set

        type [<AllowNullLiteral>] CompletionList =
            abstract suggestions: ResizeArray<CompletionItem> with get, set
            abstract incomplete: bool option with get, set
            abstract dispose: unit -> unit

        /// How a suggest provider was triggered.
        type [<RequireQualifiedAccess>] CompletionTriggerKind =
            | Invoke = 0
            | TriggerCharacter = 1
            | TriggerForIncompleteCompletions = 2

        /// <summary>
        /// Contains additional information about the context in which
        /// <see cref="CompletionItemProvider.provideCompletionItems">completion provider</see> is triggered.
        /// </summary>
        type [<AllowNullLiteral>] CompletionContext =
            /// How the completion was triggered.
            abstract triggerKind: CompletionTriggerKind with get, set
            /// <summary>
            /// Character that triggered the completion item provider.
            /// 
            /// <c>undefined</c> if provider was not triggered by a character.
            /// </summary>
            abstract triggerCharacter: string option with get, set

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
            abstract provideCompletionItems: model: Editor.ITextModel * position: Position * context: CompletionContext * token: CancellationToken -> ProviderResult<CompletionList>
            /// <summary>
            /// Given a completion item fill in more data, like <see cref="CompletionItem.documentation">doc-comment</see>
            /// or <see cref="CompletionItem.detail">details</see>.
            /// 
            /// The editor will only resolve a completion item once.
            /// </summary>
            abstract resolveCompletionItem: item: CompletionItem * token: CancellationToken -> ProviderResult<CompletionItem>

        type [<AllowNullLiteral>] CodeAction =
            abstract title: string with get, set
            abstract command: Command option with get, set
            abstract edit: WorkspaceEdit option with get, set
            abstract diagnostics: ResizeArray<Editor.IMarkerData> option with get, set
            abstract kind: string option with get, set
            abstract isPreferred: bool option with get, set
            abstract disabled: string option with get, set

        type [<AllowNullLiteral>] CodeActionList =
            inherit IDisposable
            abstract actions: ReadonlyArray<CodeAction>

        /// Represents a parameter of a callable-signature. A parameter can
        /// have a label and a doc-comment.
        type [<AllowNullLiteral>] ParameterInformation =
            /// The label of this signature. Will be shown in
            /// the UI.
            abstract label: U2<string, float * float> with get, set
            /// The human-readable doc-comment of this signature. Will be shown
            /// in the UI but can be omitted.
            abstract documentation: U2<string, IMarkdownString> option with get, set

        /// Represents the signature of something callable. A signature
        /// can have a label, like a function-name, a doc-comment, and
        /// a set of parameters.
        type [<AllowNullLiteral>] SignatureInformation =
            /// The label of this signature. Will be shown in
            /// the UI.
            abstract label: string with get, set
            /// The human-readable doc-comment of this signature. Will be shown
            /// in the UI but can be omitted.
            abstract documentation: U2<string, IMarkdownString> option with get, set
            /// The parameters of this signature.
            abstract parameters: ResizeArray<ParameterInformation> with get, set
            /// <summary>
            /// Index of the active parameter.
            /// 
            /// If provided, this is used in place of <c>SignatureHelp.activeSignature</c>.
            /// </summary>
            abstract activeParameter: float option with get, set

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

        type [<AllowNullLiteral>] SignatureHelpResult =
            inherit IDisposable
            abstract value: SignatureHelp with get, set

        type [<RequireQualifiedAccess>] SignatureHelpTriggerKind =
            | Invoke = 1
            | TriggerCharacter = 2
            | ContentChange = 3

        type [<AllowNullLiteral>] SignatureHelpContext =
            abstract triggerKind: SignatureHelpTriggerKind
            abstract triggerCharacter: string option
            abstract isRetrigger: bool
            abstract activeSignatureHelp: SignatureHelp option

        /// <summary>
        /// The signature help provider interface defines the contract between extensions and
        /// the <see href="https://code.visualstudio.com/docs/editor/intellisense">parameter hints</see>-feature.
        /// </summary>
        type [<AllowNullLiteral>] SignatureHelpProvider =
            abstract signatureHelpTriggerCharacters: ReadonlyArray<string> option
            abstract signatureHelpRetriggerCharacters: ReadonlyArray<string> option
            /// Provide help for the signature at the given position and document.
            abstract provideSignatureHelp: model: Editor.ITextModel * position: Position * token: CancellationToken * context: SignatureHelpContext -> ProviderResult<SignatureHelpResult>

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
            abstract kind: DocumentHighlightKind option with get, set

        /// The document highlight provider interface defines the contract between extensions and
        /// the word-highlight-feature.
        type [<AllowNullLiteral>] DocumentHighlightProvider =
            /// Provide a set of document highlights, like all occurrences of a variable or
            /// all exit-points of a function.
            abstract provideDocumentHighlights: model: Editor.ITextModel * position: Position * token: CancellationToken -> ProviderResult<ResizeArray<DocumentHighlight>>

        /// The rename provider interface defines the contract between extensions and
        /// the live-rename feature.
        type [<AllowNullLiteral>] OnTypeRenameProvider =
            abstract wordPattern: RegExp option with get, set
            /// Provide a list of ranges that can be live-renamed together.
            abstract provideOnTypeRenameRanges: model: Editor.ITextModel * position: Position * token: CancellationToken -> ProviderResult<{| ranges: ResizeArray<IRange>; wordPattern: RegExp option |}>

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
            abstract provideReferences: model: Editor.ITextModel * position: Position * context: ReferenceContext * token: CancellationToken -> ProviderResult<ResizeArray<Location>>

        /// Represents a location inside a resource, such as a line
        /// inside a text file.
        type [<AllowNullLiteral>] Location =
            /// The resource identifier of this location.
            abstract uri: Uri with get, set
            /// The document range of this locations.
            abstract range: IRange with get, set

        type [<AllowNullLiteral>] LocationLink =
            /// A range to select where this link originates from.
            abstract originSelectionRange: IRange option with get, set
            /// The target uri this link points to.
            abstract uri: Uri with get, set
            /// The full range this link points to.
            abstract range: IRange with get, set
            /// <summary>
            /// A range to select this link points to. Must be contained
            /// in <c>LocationLink.range</c>.
            /// </summary>
            abstract targetSelectionRange: IRange option with get, set

        type Definition =
            U3<Location, ResizeArray<Location>, ResizeArray<LocationLink>>

        /// <summary>
        /// The definition provider interface defines the contract between extensions and
        /// the <see href="https://code.visualstudio.com/docs/editor/editingevolved#_go-to-definition">go to definition</see>
        /// and peek definition features.
        /// </summary>
        type [<AllowNullLiteral>] DefinitionProvider =
            /// Provide the definition of the symbol at the given position and document.
            abstract provideDefinition: model: Editor.ITextModel * position: Position * token: CancellationToken -> ProviderResult<U2<Definition, ResizeArray<LocationLink>>>

        /// <summary>
        /// The definition provider interface defines the contract between extensions and
        /// the <see href="https://code.visualstudio.com/docs/editor/editingevolved#_go-to-definition">go to definition</see>
        /// and peek definition features.
        /// </summary>
        type [<AllowNullLiteral>] DeclarationProvider =
            /// Provide the declaration of the symbol at the given position and document.
            abstract provideDeclaration: model: Editor.ITextModel * position: Position * token: CancellationToken -> ProviderResult<U2<Definition, ResizeArray<LocationLink>>>

        /// The implementation provider interface defines the contract between extensions and
        /// the go to implementation feature.
        type [<AllowNullLiteral>] ImplementationProvider =
            /// Provide the implementation of the symbol at the given position and document.
            abstract provideImplementation: model: Editor.ITextModel * position: Position * token: CancellationToken -> ProviderResult<U2<Definition, ResizeArray<LocationLink>>>

        /// The type definition provider interface defines the contract between extensions and
        /// the go to type definition feature.
        type [<AllowNullLiteral>] TypeDefinitionProvider =
            /// Provide the type definition of the symbol at the given position and document.
            abstract provideTypeDefinition: model: Editor.ITextModel * position: Position * token: CancellationToken -> ProviderResult<U2<Definition, ResizeArray<LocationLink>>>

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

        type [<RequireQualifiedAccess>] SymbolTag =
            | Deprecated = 1

        type [<AllowNullLiteral>] DocumentSymbol =
            abstract name: string with get, set
            abstract detail: string with get, set
            abstract kind: SymbolKind with get, set
            abstract tags: ReadonlyArray<SymbolTag> with get, set
            abstract containerName: string option with get, set
            abstract range: IRange with get, set
            abstract selectionRange: IRange with get, set
            abstract children: ResizeArray<DocumentSymbol> option with get, set

        /// <summary>
        /// The document symbol provider interface defines the contract between extensions and
        /// the <see href="https://code.visualstudio.com/docs/editor/editingevolved#_go-to-symbol">go to symbol</see>-feature.
        /// </summary>
        type [<AllowNullLiteral>] DocumentSymbolProvider =
            abstract displayName: string option with get, set
            /// Provide symbol information for the given document.
            abstract provideDocumentSymbols: model: Editor.ITextModel * token: CancellationToken -> ProviderResult<ResizeArray<DocumentSymbol>>

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
            abstract displayName: string option
            /// Provide formatting edits for a whole document.
            abstract provideDocumentFormattingEdits: model: Editor.ITextModel * options: FormattingOptions * token: CancellationToken -> ProviderResult<ResizeArray<TextEdit>>

        /// The document formatting provider interface defines the contract between extensions and
        /// the formatting-feature.
        type [<AllowNullLiteral>] DocumentRangeFormattingEditProvider =
            abstract displayName: string option
            /// Provide formatting edits for a range in a document.
            /// 
            /// The given range is a hint and providers can decide to format a smaller
            /// or larger range. Often this is done by adjusting the start and end
            /// of the range to full syntax nodes.
            abstract provideDocumentRangeFormattingEdits: model: Editor.ITextModel * range: Range * options: FormattingOptions * token: CancellationToken -> ProviderResult<ResizeArray<TextEdit>>

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
            abstract provideOnTypeFormattingEdits: model: Editor.ITextModel * position: Position * ch: string * options: FormattingOptions * token: CancellationToken -> ProviderResult<ResizeArray<TextEdit>>

        /// A link inside the editor.
        type [<AllowNullLiteral>] ILink =
            abstract range: IRange with get, set
            abstract url: U2<Uri, string> option with get, set
            abstract tooltip: string option with get, set

        type [<AllowNullLiteral>] ILinksList =
            abstract links: ResizeArray<ILink> with get, set
            abstract dispose: unit -> unit

        /// A provider of links.
        type [<AllowNullLiteral>] LinkProvider =
            abstract provideLinks: model: Editor.ITextModel * token: CancellationToken -> ProviderResult<ILinksList>
            abstract resolveLink: (ILink -> CancellationToken -> ProviderResult<ILink>) option with get, set

        /// A color in RGBA format.
        type [<AllowNullLiteral>] IColor =
            /// The red component in the range [0-1].
            abstract red: float
            /// The green component in the range [0-1].
            abstract green: float
            /// The blue component in the range [0-1].
            abstract blue: float
            /// The alpha component in the range [0-1].
            abstract alpha: float

        /// String representations for a color
        type [<AllowNullLiteral>] IColorPresentation =
            /// The label of this color presentation. It will be shown on the color
            /// picker header. By default this is also the text that is inserted when selecting
            /// this color presentation.
            abstract label: string with get, set
            /// <summary>
            /// An <see cref="TextEdit">edit</see> which is applied to a document when selecting
            /// this presentation for the color.
            /// </summary>
            abstract textEdit: TextEdit option with get, set
            /// <summary>
            /// An optional array of additional <see cref="TextEdit">text edits</see> that are applied when
            /// selecting this color presentation.
            /// </summary>
            abstract additionalTextEdits: ResizeArray<TextEdit> option with get, set

        /// A color range is a range in a text model which represents a color.
        type [<AllowNullLiteral>] IColorInformation =
            /// The range within the model.
            abstract range: IRange with get, set
            /// The color represented in this range.
            abstract color: IColor with get, set

        /// A provider of colors for editor models.
        type [<AllowNullLiteral>] DocumentColorProvider =
            /// Provides the color ranges for a specific model.
            abstract provideDocumentColors: model: Editor.ITextModel * token: CancellationToken -> ProviderResult<ResizeArray<IColorInformation>>
            /// Provide the string representations for a color.
            abstract provideColorPresentations: model: Editor.ITextModel * colorInfo: IColorInformation * token: CancellationToken -> ProviderResult<ResizeArray<IColorPresentation>>

        type [<AllowNullLiteral>] SelectionRange =
            abstract range: IRange with get, set

        type [<AllowNullLiteral>] SelectionRangeProvider =
            /// Provide ranges that should be selected from the given position.
            abstract provideSelectionRanges: model: Editor.ITextModel * positions: ResizeArray<Position> * token: CancellationToken -> ProviderResult<ResizeArray<ResizeArray<SelectionRange>>>

        type [<AllowNullLiteral>] FoldingContext =
            interface end

        /// A provider of folding ranges for editor models.
        type [<AllowNullLiteral>] FoldingRangeProvider =
            /// Provides the folding ranges for a specific model.
            abstract provideFoldingRanges: model: Editor.ITextModel * context: FoldingContext * token: CancellationToken -> ProviderResult<ResizeArray<FoldingRange>>

        type [<AllowNullLiteral>] FoldingRange =
            /// The one-based start line of the range to fold. The folded area starts after the line's last character.
            abstract start: float with get, set
            /// The one-based end line of the range to fold. The folded area ends with the line's last character.
            abstract ``end``: float with get, set
            /// <summary>
            /// Describes the <see cref="FoldingRangeKind">Kind</see> of the folding range such as <see cref="FoldingRangeKind.Comment">Comment</see> or
            /// <see cref="FoldingRangeKind.Region">Region</see>. The kind is used to categorize folding ranges and used by commands
            /// like 'Fold all comments'. See
            /// <see cref="FoldingRangeKind">FoldingRangeKind</see> for an enumeration of standardized kinds.
            /// </summary>
            abstract kind: FoldingRangeKind option with get, set

        type [<AllowNullLiteral>] FoldingRangeKind =
            abstract value: string with get, set

        type [<AllowNullLiteral>] FoldingRangeKindStatic =
            /// Kind for folding range representing a comment. The value of the kind is 'comment'.
            abstract Comment: FoldingRangeKind
            /// Kind for folding range representing a import. The value of the kind is 'imports'.
            abstract Imports: FoldingRangeKind
            /// <summary>
            /// Kind for folding range representing regions (for example marked by <c>#region</c>, <c>#endregion</c>).
            /// The value of the kind is 'region'.
            /// </summary>
            abstract Region: FoldingRangeKind
            /// <summary>Creates a new <see cref="FoldingRangeKind">FoldingRangeKind</see>.</summary>
            /// <param name="value">of the kind.</param>
            [<EmitConstructor>] abstract Create: value: string -> FoldingRangeKind

        type [<AllowNullLiteral>] WorkspaceEditMetadata =
            abstract needsConfirmation: bool with get, set
            abstract label: string with get, set
            abstract description: string option with get, set
            abstract iconPath: U3<{| id: string |}, Uri, {| light: Uri; dark: Uri |}> option with get, set

        type [<AllowNullLiteral>] WorkspaceFileEditOptions =
            abstract overwrite: bool option with get, set
            abstract ignoreIfNotExists: bool option with get, set
            abstract ignoreIfExists: bool option with get, set
            abstract recursive: bool option with get, set

        type [<AllowNullLiteral>] WorkspaceFileEdit =
            abstract oldUri: Uri option with get, set
            abstract newUri: Uri option with get, set
            abstract options: WorkspaceFileEditOptions option with get, set
            abstract metadata: WorkspaceEditMetadata option with get, set

        type [<AllowNullLiteral>] WorkspaceTextEdit =
            abstract resource: Uri with get, set
            abstract edit: TextEdit with get, set
            abstract modelVersionId: float option with get, set
            abstract metadata: WorkspaceEditMetadata option with get, set

        type [<AllowNullLiteral>] WorkspaceEdit =
            abstract edits: Array<U2<WorkspaceTextEdit, WorkspaceFileEdit>> with get, set

        type [<AllowNullLiteral>] Rejection =
            abstract rejectReason: string option with get, set

        type [<AllowNullLiteral>] RenameLocation =
            abstract range: IRange with get, set
            abstract text: string with get, set

        type [<AllowNullLiteral>] RenameProvider =
            abstract provideRenameEdits: model: Editor.ITextModel * position: Position * newName: string * token: CancellationToken -> ProviderResult<obj>
            abstract resolveRenameLocation: model: Editor.ITextModel * position: Position * token: CancellationToken -> ProviderResult<obj>

        type [<AllowNullLiteral>] Command =
            abstract id: string with get, set
            abstract title: string with get, set
            abstract tooltip: string option with get, set
            abstract arguments: ResizeArray<obj option> option with get, set

        type [<AllowNullLiteral>] CodeLens =
            abstract range: IRange with get, set
            abstract id: string option with get, set
            abstract command: Command option with get, set

        type [<AllowNullLiteral>] CodeLensList =
            abstract lenses: ResizeArray<CodeLens> with get, set
            abstract dispose: unit -> unit

        type [<AllowNullLiteral>] CodeLensProvider =
            abstract onDidChange: IEvent<CodeLensProvider> option with get, set
            abstract provideCodeLenses: model: Editor.ITextModel * token: CancellationToken -> ProviderResult<CodeLensList>
            abstract resolveCodeLens: model: Editor.ITextModel * codeLens: CodeLens * token: CancellationToken -> ProviderResult<CodeLens>

        type [<AllowNullLiteral>] SemanticTokensLegend =
            abstract tokenTypes: ResizeArray<string>
            abstract tokenModifiers: ResizeArray<string>

        type [<AllowNullLiteral>] SemanticTokens =
            abstract resultId: string option
            abstract data: Uint32Array

        type [<AllowNullLiteral>] SemanticTokensEdit =
            abstract start: float
            abstract deleteCount: float
            abstract data: Uint32Array option

        type [<AllowNullLiteral>] SemanticTokensEdits =
            abstract resultId: string option
            abstract edits: ResizeArray<SemanticTokensEdit>

        type [<AllowNullLiteral>] DocumentSemanticTokensProvider =
            abstract onDidChange: IEvent<unit> option with get, set
            abstract getLegend: unit -> SemanticTokensLegend
            abstract provideDocumentSemanticTokens: model: Editor.ITextModel * lastResultId: string option * token: CancellationToken -> ProviderResult<U2<SemanticTokens, SemanticTokensEdits>>
            abstract releaseDocumentSemanticTokens: resultId: string option -> unit

        type [<AllowNullLiteral>] DocumentRangeSemanticTokensProvider =
            abstract getLegend: unit -> SemanticTokensLegend
            abstract provideDocumentRangeSemanticTokens: model: Editor.ITextModel * range: Range * token: CancellationToken -> ProviderResult<SemanticTokens>

        type [<AllowNullLiteral>] ILanguageExtensionPoint =
            abstract id: string with get, set
            abstract extensions: ResizeArray<string> option with get, set
            abstract filenames: ResizeArray<string> option with get, set
            abstract filenamePatterns: ResizeArray<string> option with get, set
            abstract firstLine: string option with get, set
            abstract aliases: ResizeArray<string> option with get, set
            abstract mimetypes: ResizeArray<string> option with get, set
            abstract configuration: Uri option with get, set

        /// A Monarch language definition
        type [<AllowNullLiteral>] IMonarchLanguage =
            /// map from string to ILanguageRule[]
            abstract tokenizer: {| Item: ResizeArray<IMonarchLanguageRule> |} with get, set
            /// is the language case insensitive?
            abstract ignoreCase: bool option with get, set
            /// is the language unicode-aware? (i.e., /\u{1D306}/)
            abstract unicode: bool option with get, set
            /// if no match in the tokenizer assign this token class (default 'source')
            abstract defaultToken: string option with get, set
            /// for example [['{','}','delimiter.curly']]
            abstract brackets: ResizeArray<IMonarchLanguageBracket> option with get, set
            /// start symbol in the tokenizer (by default the first entry is used)
            abstract start: string option with get, set
            /// attach this to every token class (by default '.' + name)
            abstract tokenPostfix: string option with get, set

        /// A rule is either a regular expression and an action
        ///  		shorthands: [reg,act] == { regex: reg, action: act}
        /// 		and       : [reg,act,nxt] == { regex: reg, action: act{ next: nxt }}
        type IShortMonarchLanguageRule1 =
            U2<string, RegExp> * IMonarchLanguageAction

        type IShortMonarchLanguageRule2 =
            U2<string, RegExp> * IMonarchLanguageAction * string

        type [<AllowNullLiteral>] IExpandedMonarchLanguageRule =
            /// match tokens
            abstract regex: U2<string, RegExp> option with get, set
            /// action to take on match
            abstract action: IMonarchLanguageAction option with get, set
            /// or an include rule. include all rules from the included state
            abstract ``include``: string option with get, set

        type IMonarchLanguageRule =
            U3<IShortMonarchLanguageRule1, IShortMonarchLanguageRule2, IExpandedMonarchLanguageRule>

        /// An action is either an array of actions...
        /// ... or a case statement with guards...
        /// ... or a basic action with a token value.
        type IShortMonarchLanguageAction =
            string

        type [<AllowNullLiteral>] IExpandedMonarchLanguageAction =
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
            /// switch to embedded language (using the mimetype) or get out using "@pop"
            abstract nextEmbedded: string option with get, set
            /// log a message to the browser console window
            abstract log: string option with get, set

        type IMonarchLanguageAction =
            U4<IShortMonarchLanguageAction, IExpandedMonarchLanguageAction, ResizeArray<IShortMonarchLanguageAction>, ResizeArray<IExpandedMonarchLanguageAction>>

        /// This interface can be shortened as an array, ie. ['{','}','delimiter.curly']
        type [<AllowNullLiteral>] IMonarchLanguageBracket =
            /// open bracket
            abstract ``open``: string with get, set
            /// closing bracket
            abstract close: string with get, set
            /// token class
            abstract token: string with get, set

        module Typescript =

            type [<AllowNullLiteral>] IExports =
                abstract typescriptVersion: string
                abstract typescriptDefaults: LanguageServiceDefaults
                abstract javascriptDefaults: LanguageServiceDefaults
                abstract getTypeScriptWorker: (unit -> Promise<(ResizeArray<Uri> -> Promise<TypeScriptWorker>)>)
                abstract getJavaScriptWorker: (unit -> Promise<(ResizeArray<Uri> -> Promise<TypeScriptWorker>)>)

            type [<RequireQualifiedAccess>] ModuleKind =
                | None = 0
                | CommonJS = 1
                | AMD = 2
                | UMD = 3
                | System = 4
                | ES2015 = 5
                | ESNext = 99

            type [<RequireQualifiedAccess>] JsxEmit =
                | None = 0
                | Preserve = 1
                | React = 2
                | ReactNative = 3

            type [<RequireQualifiedAccess>] NewLineKind =
                | CarriageReturnLineFeed = 0
                | LineFeed = 1

            type [<RequireQualifiedAccess>] ScriptTarget =
                | ES3 = 0
                | ES5 = 1
                | ES2015 = 2
                | ES2016 = 3
                | ES2017 = 4
                | ES2018 = 5
                | ES2019 = 6
                | ES2020 = 7
                | ESNext = 99
                | JSON = 100
                | Latest = 99

            type [<RequireQualifiedAccess>] ModuleResolutionKind =
                | Classic = 1
                | NodeJs = 2

            type [<AllowNullLiteral>] MapLike<'T> =
                [<EmitIndexer>] abstract Item: index: string -> 'T with get, set

            type CompilerOptionsValue =
                U6<string, float, bool, ResizeArray<U2<string, float>>, ResizeArray<string>, MapLike<ResizeArray<string>>> option

            type [<AllowNullLiteral>] CompilerOptions =
                abstract allowJs: bool option with get, set
                abstract allowSyntheticDefaultImports: bool option with get, set
                abstract allowUmdGlobalAccess: bool option with get, set
                abstract allowUnreachableCode: bool option with get, set
                abstract allowUnusedLabels: bool option with get, set
                abstract alwaysStrict: bool option with get, set
                abstract baseUrl: string option with get, set
                abstract charset: string option with get, set
                abstract checkJs: bool option with get, set
                abstract declaration: bool option with get, set
                abstract declarationMap: bool option with get, set
                abstract emitDeclarationOnly: bool option with get, set
                abstract declarationDir: string option with get, set
                abstract disableSizeLimit: bool option with get, set
                abstract disableSourceOfProjectReferenceRedirect: bool option with get, set
                abstract downlevelIteration: bool option with get, set
                abstract emitBOM: bool option with get, set
                abstract emitDecoratorMetadata: bool option with get, set
                abstract experimentalDecorators: bool option with get, set
                abstract forceConsistentCasingInFileNames: bool option with get, set
                abstract importHelpers: bool option with get, set
                abstract inlineSourceMap: bool option with get, set
                abstract inlineSources: bool option with get, set
                abstract isolatedModules: bool option with get, set
                abstract jsx: JsxEmit option with get, set
                abstract keyofStringsOnly: bool option with get, set
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
                abstract noStrictGenericChecks: bool option with get, set
                abstract noUnusedLocals: bool option with get, set
                abstract noUnusedParameters: bool option with get, set
                abstract noImplicitUseStrict: bool option with get, set
                abstract noLib: bool option with get, set
                abstract noResolve: bool option with get, set
                abstract out: string option with get, set
                abstract outDir: string option with get, set
                abstract outFile: string option with get, set
                abstract paths: MapLike<ResizeArray<string>> option with get, set
                abstract preserveConstEnums: bool option with get, set
                abstract preserveSymlinks: bool option with get, set
                abstract project: string option with get, set
                abstract reactNamespace: string option with get, set
                abstract jsxFactory: string option with get, set
                abstract composite: bool option with get, set
                abstract removeComments: bool option with get, set
                abstract rootDir: string option with get, set
                abstract rootDirs: ResizeArray<string> option with get, set
                abstract skipLibCheck: bool option with get, set
                abstract skipDefaultLibCheck: bool option with get, set
                abstract sourceMap: bool option with get, set
                abstract sourceRoot: string option with get, set
                abstract strict: bool option with get, set
                abstract strictFunctionTypes: bool option with get, set
                abstract strictBindCallApply: bool option with get, set
                abstract strictNullChecks: bool option with get, set
                abstract strictPropertyInitialization: bool option with get, set
                abstract stripInternal: bool option with get, set
                abstract suppressExcessPropertyErrors: bool option with get, set
                abstract suppressImplicitAnyIndexErrors: bool option with get, set
                abstract target: ScriptTarget option with get, set
                abstract traceResolution: bool option with get, set
                abstract resolveJsonModule: bool option with get, set
                abstract types: ResizeArray<string> option with get, set
                /// Paths used to compute primary types search locations
                abstract typeRoots: ResizeArray<string> option with get, set
                abstract esModuleInterop: bool option with get, set
                abstract useDefineForClassFields: bool option with get, set
                [<EmitIndexer>] abstract Item: option: string -> CompilerOptionsValue option with get, set

            type [<AllowNullLiteral>] DiagnosticsOptions =
                abstract noSemanticValidation: bool option with get, set
                abstract noSyntaxValidation: bool option with get, set
                abstract noSuggestionDiagnostics: bool option with get, set
                abstract diagnosticCodesToIgnore: ResizeArray<float> option with get, set

            type [<AllowNullLiteral>] WorkerOptions =
                /// <summary>A full HTTP path to a JavaScript file which adds a function <c>customTSWorkerFactory</c> to the self inside a web-worker</summary>
                abstract customWorkerPath: string option with get, set

            type [<AllowNullLiteral>] IExtraLib =
                abstract content: string with get, set
                abstract version: float with get, set

            type [<AllowNullLiteral>] IExtraLibs =
                [<EmitIndexer>] abstract Item: path: string -> IExtraLib with get, set

            /// A linked list of formatted diagnostic messages to be used as part of a multiline message.
            /// It is built from the bottom up, leaving the head to be the "main" diagnostic.
            type [<AllowNullLiteral>] DiagnosticMessageChain =
                abstract messageText: string with get, set
                /// Diagnostic category: warning = 0, error = 1, suggestion = 2, message = 3
                abstract category: DiagnosticMessageChainCategory with get, set
                abstract code: float with get, set
                abstract next: ResizeArray<DiagnosticMessageChain> option with get, set

            type [<AllowNullLiteral>] Diagnostic =
                inherit DiagnosticRelatedInformation
                /// <summary>May store more in future. For now, this will simply be <c>true</c> to indicate when a diagnostic is an unused-identifier diagnostic.</summary>
                abstract reportsUnnecessary: DiagnosticReportsUnnecessary option with get, set
                abstract source: string option with get, set
                abstract relatedInformation: ResizeArray<DiagnosticRelatedInformation> option with get, set

            type [<AllowNullLiteral>] DiagnosticRelatedInformation =
                /// Diagnostic category: warning = 0, error = 1, suggestion = 2, message = 3
                abstract category: DiagnosticMessageChainCategory with get, set
                abstract code: float with get, set
                /// TypeScriptWorker removes this to avoid serializing circular JSON structures.
                abstract file: obj with get, set
                abstract start: float option with get, set
                abstract length: float option with get, set
                abstract messageText: U2<string, DiagnosticMessageChain> with get, set

            type [<AllowNullLiteral>] EmitOutput =
                abstract outputFiles: ResizeArray<OutputFile> with get, set
                abstract emitSkipped: bool with get, set

            type [<AllowNullLiteral>] OutputFile =
                abstract name: string with get, set
                abstract writeByteOrderMark: bool with get, set
                abstract text: string with get, set

            type [<AllowNullLiteral>] LanguageServiceDefaults =
                /// Event fired when compiler options or diagnostics options are changed.
                abstract onDidChange: IEvent<unit>
                /// Event fired when extra libraries registered with the language service change.
                abstract onDidExtraLibsChange: IEvent<unit>
                abstract workerOptions: WorkerOptions
                /// Get the current extra libs registered with the language service.
                abstract getExtraLibs: unit -> IExtraLibs
                /// <summary>
                /// Add an additional source file to the language service. Use this
                /// for typescript (definition) files that won't be loaded as editor
                /// documents, like <c>jquery.d.ts</c>.
                /// </summary>
                /// <param name="content">The file content</param>
                /// <param name="filePath">An optional file path</param>
                /// <returns>
                /// A disposable which will remove the file from the
                /// language service upon disposal.
                /// </returns>
                abstract addExtraLib: content: string * ?filePath: string -> IDisposable
                /// <summary>
                /// Remove all existing extra libs and set the additional source
                /// files to the language service. Use this for typescript definition
                /// files that won't be loaded as editor documents, like <c>jquery.d.ts</c>.
                /// </summary>
                /// <param name="libs">An array of entries to register.</param>
                abstract setExtraLibs: libs: ResizeArray<{| content: string; filePath: string option |}> -> unit
                /// Get current TypeScript compiler options for the language service.
                abstract getCompilerOptions: unit -> CompilerOptions
                /// Set TypeScript compiler options.
                abstract setCompilerOptions: options: CompilerOptions -> unit
                /// Get the current diagnostics options for the language service.
                abstract getDiagnosticsOptions: unit -> DiagnosticsOptions
                /// Configure whether syntactic and/or semantic validation should
                /// be performed
                abstract setDiagnosticsOptions: options: DiagnosticsOptions -> unit
                /// Configure webworker options
                abstract setWorkerOptions: options: WorkerOptions -> unit
                /// No-op.
                abstract setMaximumWorkerIdleTime: value: float -> unit
                /// Configure if all existing models should be eagerly sync'd
                /// to the worker on start or restart.
                abstract setEagerModelSync: value: bool -> unit
                /// Get the current setting for whether all existing models should be eagerly sync'd
                /// to the worker on start or restart.
                abstract getEagerModelSync: unit -> bool

            type [<AllowNullLiteral>] TypeScriptWorker =
                /// Get diagnostic messages for any syntax issues in the given file.
                abstract getSyntacticDiagnostics: fileName: string -> Promise<ResizeArray<Diagnostic>>
                /// Get diagnostic messages for any semantic issues in the given file.
                abstract getSemanticDiagnostics: fileName: string -> Promise<ResizeArray<Diagnostic>>
                /// Get diagnostic messages for any suggestions related to the given file.
                abstract getSuggestionDiagnostics: fileName: string -> Promise<ResizeArray<Diagnostic>>
                /// Get the content of a given file.
                abstract getScriptText: fileName: string -> Promise<string option>
                /// <summary>Get diagnostic messages related to the current compiler options.</summary>
                /// <param name="fileName">Not used</param>
                abstract getCompilerOptionsDiagnostics: fileName: string -> Promise<ResizeArray<Diagnostic>>
                /// <summary>Get code completions for the given file and position.</summary>
                /// <returns><c>Promise<typescript.CompletionInfo | undefined></c></returns>
                abstract getCompletionsAtPosition: fileName: string * position: float -> Promise<obj option option>
                /// <summary>Get code completion details for the given file, position, and entry.</summary>
                /// <returns><c>Promise<typescript.CompletionEntryDetails | undefined></c></returns>
                abstract getCompletionEntryDetails: fileName: string * position: float * entry: string -> Promise<obj option option>
                /// <summary>Get signature help items for the item at the given file and position.</summary>
                /// <returns><c>Promise<typescript.SignatureHelpItems | undefined></c></returns>
                abstract getSignatureHelpItems: fileName: string * position: float -> Promise<obj option option>
                /// <summary>Get quick info for the item at the given position in the file.</summary>
                /// <returns><c>Promise<typescript.QuickInfo | undefined></c></returns>
                abstract getQuickInfoAtPosition: fileName: string * position: float -> Promise<obj option option>
                /// <summary>Get other ranges which are related to the item at the given position in the file (often used for highlighting).</summary>
                /// <returns><c>Promise<ReadonlyArray<typescript.ReferenceEntry> | undefined></c></returns>
                abstract getOccurrencesAtPosition: fileName: string * position: float -> Promise<ResizeArray<obj option> option>
                /// <summary>Get the definition of the item at the given position in the file.</summary>
                /// <returns><c>Promise<ReadonlyArray<typescript.DefinitionInfo> | undefined></c></returns>
                abstract getDefinitionAtPosition: fileName: string * position: float -> Promise<ResizeArray<obj option> option>
                /// <summary>Get references to the item at the given position in the file.</summary>
                /// <returns><c>Promise<typescript.ReferenceEntry[] | undefined></c></returns>
                abstract getReferencesAtPosition: fileName: string * position: float -> Promise<ResizeArray<obj option> option>
                /// <summary>Get outline entries for the item at the given position in the file.</summary>
                /// <returns><c>Promise<typescript.NavigationBarItem[]></c></returns>
                abstract getNavigationBarItems: fileName: string -> Promise<ResizeArray<obj option>>
                /// <summary>Get changes which should be applied to format the given file.</summary>
                /// <param name="options"><c>typescript.FormatCodeOptions</c></param>
                /// <returns><c>Promise<typescript.TextChange[]></c></returns>
                abstract getFormattingEditsForDocument: fileName: string * options: obj option -> Promise<ResizeArray<obj option>>
                /// <summary>Get changes which should be applied to format the given range in the file.</summary>
                /// <param name="options"><c>typescript.FormatCodeOptions</c></param>
                /// <returns><c>Promise<typescript.TextChange[]></c></returns>
                abstract getFormattingEditsForRange: fileName: string * start: float * ``end``: float * options: obj option -> Promise<ResizeArray<obj option>>
                /// <summary>Get formatting changes which should be applied after the given keystroke.</summary>
                /// <param name="options"><c>typescript.FormatCodeOptions</c></param>
                /// <returns><c>Promise<typescript.TextChange[]></c></returns>
                abstract getFormattingEditsAfterKeystroke: fileName: string * postion: float * ch: string * options: obj option -> Promise<ResizeArray<obj option>>
                /// <summary>Get other occurrences which should be updated when renaming the item at the given file and position.</summary>
                /// <returns><c>Promise<readonly typescript.RenameLocation[] | undefined></c></returns>
                abstract findRenameLocations: fileName: string * positon: float * findInStrings: bool * findInComments: bool * providePrefixAndSuffixTextForRename: bool -> Promise<ResizeArray<obj option> option>
                /// <summary>Get edits which should be applied to rename the item at the given file and position (or a failure reason).</summary>
                /// <param name="options"><c>typescript.RenameInfoOptions</c></param>
                /// <returns><c>Promise<typescript.RenameInfo></c></returns>
                abstract getRenameInfo: fileName: string * positon: float * options: obj option -> Promise<obj option>
                /// <summary>Get transpiled output for the given file.</summary>
                /// <returns><c>typescript.EmitOutput</c></returns>
                abstract getEmitOutput: fileName: string -> Promise<EmitOutput>
                /// <summary>Get possible code fixes at the given position in the file.</summary>
                /// <param name="formatOptions"><c>typescript.FormatCodeOptions</c></param>
                /// <returns><c>Promise<ReadonlyArray<typescript.CodeFixAction>></c></returns>
                abstract getCodeFixesAtPosition: fileName: string * start: float * ``end``: float * errorCodes: ResizeArray<float> * formatOptions: obj option -> Promise<ResizeArray<obj option>>

            type [<RequireQualifiedAccess>] DiagnosticMessageChainCategory =
                | N0 = 0
                | N1 = 1
                | N2 = 2
                | N3 = 3

            type [<AllowNullLiteral>] DiagnosticReportsUnnecessary =
                interface end

        module Css =

            type [<AllowNullLiteral>] IExports =
                abstract cssDefaults: LanguageServiceDefaults
                abstract scssDefaults: LanguageServiceDefaults
                abstract lessDefaults: LanguageServiceDefaults

            type [<AllowNullLiteral>] DiagnosticsOptions =
                abstract validate: bool option
                abstract lint: DiagnosticsOptionsLint option

            type [<AllowNullLiteral>] ModeConfiguration =
                /// Defines whether the built-in completionItemProvider is enabled.
                abstract completionItems: bool option
                /// Defines whether the built-in hoverProvider is enabled.
                abstract hovers: bool option
                /// Defines whether the built-in documentSymbolProvider is enabled.
                abstract documentSymbols: bool option
                /// Defines whether the built-in definitions provider is enabled.
                abstract definitions: bool option
                /// Defines whether the built-in references provider is enabled.
                abstract references: bool option
                /// Defines whether the built-in references provider is enabled.
                abstract documentHighlights: bool option
                /// Defines whether the built-in rename provider is enabled.
                abstract rename: bool option
                /// Defines whether the built-in color provider is enabled.
                abstract colors: bool option
                /// Defines whether the built-in foldingRange provider is enabled.
                abstract foldingRanges: bool option
                /// Defines whether the built-in diagnostic provider is enabled.
                abstract diagnostics: bool option
                /// Defines whether the built-in selection range provider is enabled.
                abstract selectionRanges: bool option

            type [<AllowNullLiteral>] LanguageServiceDefaults =
                abstract languageId: string
                abstract onDidChange: IEvent<LanguageServiceDefaults>
                abstract diagnosticsOptions: DiagnosticsOptions
                abstract modeConfiguration: ModeConfiguration
                abstract setDiagnosticsOptions: options: DiagnosticsOptions -> unit
                abstract setModeConfiguration: modeConfiguration: ModeConfiguration -> unit

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
                /// If set, comments are tolerated. If set to false, syntax errors will be emitted for comments.
                abstract allowComments: bool option
                /// A list of known schemas and/or associations of schemas to file names.
                abstract schemas: ResizeArray<{| uri: string; fileMatch: ResizeArray<string> option; schema: obj option |}> option
                /// If set, the schema service would load schema content on-demand with 'fetch' if available
                abstract enableSchemaRequest: bool option

            type [<AllowNullLiteral>] ModeConfiguration =
                /// Defines whether the built-in documentFormattingEdit provider is enabled.
                abstract documentFormattingEdits: bool option
                /// Defines whether the built-in documentRangeFormattingEdit provider is enabled.
                abstract documentRangeFormattingEdits: bool option
                /// Defines whether the built-in completionItemProvider is enabled.
                abstract completionItems: bool option
                /// Defines whether the built-in hoverProvider is enabled.
                abstract hovers: bool option
                /// Defines whether the built-in documentSymbolProvider is enabled.
                abstract documentSymbols: bool option
                /// Defines whether the built-in tokens provider is enabled.
                abstract tokens: bool option
                /// Defines whether the built-in color provider is enabled.
                abstract colors: bool option
                /// Defines whether the built-in foldingRange provider is enabled.
                abstract foldingRanges: bool option
                /// Defines whether the built-in diagnostic provider is enabled.
                abstract diagnostics: bool option
                /// Defines whether the built-in selection range provider is enabled.
                abstract selectionRanges: bool option

            type [<AllowNullLiteral>] LanguageServiceDefaults =
                abstract languageId: string
                abstract onDidChange: IEvent<LanguageServiceDefaults>
                abstract diagnosticsOptions: DiagnosticsOptions
                abstract modeConfiguration: ModeConfiguration
                abstract setDiagnosticsOptions: options: DiagnosticsOptions -> unit
                abstract setModeConfiguration: modeConfiguration: ModeConfiguration -> unit

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
                /// If set, comments are tolerated. If set to false, syntax errors will be emitted for comments.
                abstract format: HTMLFormatConfiguration option
                /// A list of known schemas and/or associations of schemas to file names.
                abstract suggest: CompletionConfiguration option

            type [<AllowNullLiteral>] ModeConfiguration =
                /// Defines whether the built-in completionItemProvider is enabled.
                abstract completionItems: bool option
                /// Defines whether the built-in hoverProvider is enabled.
                abstract hovers: bool option
                /// Defines whether the built-in documentSymbolProvider is enabled.
                abstract documentSymbols: bool option
                /// Defines whether the built-in definitions provider is enabled.
                abstract links: bool option
                /// Defines whether the built-in references provider is enabled.
                abstract documentHighlights: bool option
                /// Defines whether the built-in rename provider is enabled.
                abstract rename: bool option
                /// Defines whether the built-in color provider is enabled.
                abstract colors: bool option
                /// Defines whether the built-in foldingRange provider is enabled.
                abstract foldingRanges: bool option
                /// Defines whether the built-in diagnostic provider is enabled.
                abstract diagnostics: bool option
                /// Defines whether the built-in selection range provider is enabled.
                abstract selectionRanges: bool option
                /// Defines whether the built-in documentFormattingEdit provider is enabled.
                abstract documentFormattingEdits: bool option
                /// Defines whether the built-in documentRangeFormattingEdit provider is enabled.
                abstract documentRangeFormattingEdits: bool option

            type [<AllowNullLiteral>] LanguageServiceDefaults =
                abstract languageId: string
                abstract modeConfiguration: ModeConfiguration
                abstract onDidChange: IEvent<LanguageServiceDefaults>
                abstract options: Options
                abstract setOptions: options: Options -> unit

            type [<StringEnum>] [<RequireQualifiedAccess>] HTMLFormatConfigurationWrapAttributes =
                | Auto
                | Force
                | [<CompiledName "force-aligned">] ForceAligned
                | [<CompiledName "force-expand-multiline">] ForceExpandMultiline

    module Worker =

        type [<AllowNullLiteral>] IMirrorModel =
            abstract uri: Uri
            abstract version: float
            abstract getValue: unit -> string

        type IWorkerContext =
            IWorkerContext<obj>

        type [<AllowNullLiteral>] IWorkerContext<'H> =
            /// A proxy to the main thread host object.
            abstract host: 'H with get, set
            /// Get all available mirror models in this worker.
            abstract getMirrorModels: unit -> ResizeArray<IMirrorModel>

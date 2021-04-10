// ts2fable 0.0.0
module rec VSCode
open System
open Fable.Core
open Fable.Core.JS

type Array<'T> = System.Collections.Generic.IList<'T>
type Error = System.Exception
type Function = System.Action
type ReadonlyArray<'T> = System.Collections.Generic.IReadOnlyList<'T>
type RegExp = System.Text.RegularExpressions.Regex

let [<Import("*","vscode")>] vscode: Vscode.IExports = jsNative

module Vscode =
    /// Namespace for tasks functionality.
    let [<Import("tasks","vscode")>] tasks: Tasks.IExports = jsNative
    /// Namespace describing the environment the editor runs in.
    let [<Import("env","vscode")>] env: Env.IExports = jsNative
    /// <summary>
    /// Namespace for dealing with commands. In short, a command is a function with a
    /// unique identifier. The function is sometimes also called _command handler_.
    /// 
    /// Commands can be added to the editor using the <see cref="commands.registerCommand">registerCommand</see>
    /// and <see cref="commands.registerTextEditorCommand">registerTextEditorCommand</see> functions. Commands
    /// can be executed <see cref="commands.executeCommand">manually</see> or from a UI gesture. Those are:
    /// 
    /// * palette - Use the <c>commands</c>-section in <c>package.json</c> to make a command show in
    /// the <see href="https://code.visualstudio.com/docs/getstarted/userinterface#_command-palette">command palette</see>.
    /// * keybinding - Use the <c>keybindings</c>-section in <c>package.json</c> to enable
    /// <see href="https://code.visualstudio.com/docs/getstarted/keybindings#_customizing-shortcuts">keybindings</see>
    /// for your extension.
    /// 
    /// Commands from other extensions and from the editor itself are accessible to an extension. However,
    /// when invoking an editor command not all argument types are supported.
    /// 
    /// This is a sample that registers a command handler and adds an entry for that command to the palette. First
    /// register a command handler with the identifier <c>extension.sayHello</c>.
    /// <code language="javascript">
    /// commands.registerCommand('extension.sayHello', () => {
    ///  	window.showInformationMessage('Hello World!');
    /// });
    /// </code>
    /// Second, bind the command identifier to a title under which it will show in the palette (<c>package.json</c>).
    /// <code language="json">
    /// {
    ///  	"contributes": {
    ///  		"commands": [{
    ///  			"command": "extension.sayHello",
    ///  			"title": "Hello World"
    ///  		}]
    ///  	}
    /// }
    /// </code>
    /// </summary>
    let [<Import("commands","vscode")>] commands: Commands.IExports = jsNative
    /// Namespace for dealing with the current window of the editor. That is visible
    /// and active editors, as well as, UI elements to show messages, selections, and
    /// asking for user input.
    let [<Import("window","vscode")>] window: Window.IExports = jsNative
    /// <summary>
    /// Namespace for dealing with the current workspace. A workspace is the representation
    /// of the folder that has been opened. There is no workspace when just a file but not a
    /// folder has been opened.
    /// 
    /// The workspace offers support for <see cref="workspace.createFileSystemWatcher">listening</see> to fs
    /// events and for <see cref="workspace.findFiles">finding</see> files. Both perform well and run _outside_
    /// the editor-process so that they should be always used instead of nodejs-equivalents.
    /// </summary>
    let [<Import("workspace","vscode")>] workspace: Workspace.IExports = jsNative
    /// <summary>
    /// Namespace for participating in language-specific editor <see href="https://code.visualstudio.com/docs/editor/editingevolved">features</see>,
    /// like IntelliSense, code actions, diagnostics etc.
    /// 
    /// Many programming languages exist and there is huge variety in syntaxes, semantics, and paradigms. Despite that, features
    /// like automatic word-completion, code navigation, or code checking have become popular across different tools for different
    /// programming languages.
    /// 
    /// The editor provides an API that makes it simple to provide such common features by having all UI and actions already in place and
    /// by allowing you to participate by providing data only. For instance, to contribute a hover all you have to do is provide a function
    /// that can be called with a <see cref="TextDocument">TextDocument</see> and a <see cref="Position">Position</see> returning hover info. The rest, like tracking the
    /// mouse, positioning the hover, keeping the hover stable etc. is taken care of by the editor.
    /// 
    /// <code language="javascript">
    /// languages.registerHoverProvider('javascript', {
    ///  	provideHover(document, position, token) {
    ///  		return new Hover('I am a hover!');
    ///  	}
    /// });
    /// </code>
    /// 
    /// Registration is done using a <see cref="DocumentSelector">document selector</see> which is either a language id, like <c>javascript</c> or
    /// a more complex <see cref="DocumentFilter">filter</see> like <c>{ language: 'typescript', scheme: 'file' }</c>. Matching a document against such
    /// a selector will result in a <see cref="languages.match">score</see> that is used to determine if and how a provider shall be used. When
    /// scores are equal the provider that came last wins. For features that allow full arity, like <see cref="languages.registerHoverProvider">hover</see>,
    /// the score is only checked to be <c>>0</c>, for other features, like <see cref="languages.registerCompletionItemProvider">IntelliSense</see> the
    /// score is used for determining the order in which providers are asked to participate.
    /// </summary>
    let [<Import("languages","vscode")>] languages: Languages.IExports = jsNative
    let [<Import("scm","vscode")>] scm: Scm.IExports = jsNative
    /// Namespace for debug functionality.
    let [<Import("debug","vscode")>] debug: Debug.IExports = jsNative
    /// <summary>
    /// Namespace for dealing with installed extensions. Extensions are represented
    /// by an <see cref="Extension">extension</see>-interface which enables reflection on them.
    /// 
    /// Extension writers can provide APIs to other extensions by returning their API public
    /// surface from the <c>activate</c>-call.
    /// 
    /// <code language="javascript">
    /// export function activate(context: vscode.ExtensionContext) {
    ///  	let api = {
    ///  		sum(a, b) {
    ///  			return a + b;
    ///  		},
    ///  		mul(a, b) {
    ///  			return a * b;
    ///  		}
    ///  	};
    ///  	// 'export' public api-surface
    ///  	return api;
    /// }
    /// </code>
    /// When depending on the API of another extension add an <c>extensionDependency</c>-entry
    /// to <c>package.json</c>, and use the <see cref="extensions.getExtension">getExtension</see>-function
    /// and the <see cref="Extension.exports">exports</see>-property, like below:
    /// 
    /// <code language="javascript">
    /// let mathExt = extensions.getExtension('genius.math');
    /// let importedApi = mathExt.exports;
    /// 
    /// console.log(importedApi.mul(42, 1));
    /// </code>
    /// </summary>
    let [<Import("extensions","vscode")>] extensions: Extensions.IExports = jsNative

    type [<AllowNullLiteral>] IExports =
        /// The version of the editor.
        abstract version: string
        /// <summary>
        /// Represents a line and character position, such as
        /// the position of the cursor.
        /// 
        /// Position objects are __immutable__. Use the <see cref="Position.with">with</see> or
        /// <see cref="Position.translate">translate</see> methods to derive new positions
        /// from an existing position.
        /// </summary>
        abstract Position: PositionStatic
        /// <summary>
        /// A range represents an ordered pair of two positions.
        /// It is guaranteed that <see cref="Range.start">start</see>.isBeforeOrEqual(<see cref="Range.end)">end</see>
        /// 
        /// Range objects are __immutable__. Use the <see cref="Range.with">with</see>,
        /// <see cref="Range.intersection">intersection</see>, or <see cref="Range.union">union</see> methods
        /// to derive new ranges from an existing range.
        /// </summary>
        abstract Range: RangeStatic
        /// Represents a text selection in an editor.
        abstract Selection: SelectionStatic
        /// <summary>
        /// A reference to one of the workbench colors as defined in <see href="https://code.visualstudio.com/docs/getstarted/theme-color-reference." />
        /// Using a theme color is preferred over a custom color as it gives theme authors and users the possibility to change the color.
        /// </summary>
        abstract ThemeColor: ThemeColorStatic
        /// <summary>
        /// A reference to a named icon. Currently only <see cref="ThemeIcon.File">File</see> and <see cref="ThemeIcon.Folder">Folder</see> are supported.
        /// Using a theme icon is preferred over a custom icon as it gives theme authors the possibility to change the icons.
        /// </summary>
        abstract ThemeIcon: ThemeIconStatic
        /// A universal resource identifier representing either a file on disk
        /// or another resource, like untitled resources.
        abstract Uri: UriStatic
        /// <summary>A cancellation source creates and controls a <see cref="CancellationToken">cancellation token</see>.</summary>
        abstract CancellationTokenSource: CancellationTokenSourceStatic
        /// Represents a type which can release resources, such
        /// as event listening or a timer.
        abstract Disposable: DisposableStatic
        /// <summary>
        /// An event emitter can be used to create and manage an <see cref="Event">event</see> for others
        /// to subscribe to. One emitter always owns one event.
        /// 
        /// Use this class if you want to provide event from within your extension, for instance
        /// inside a <see cref="TextDocumentContentProvider">TextDocumentContentProvider</see> or when providing
        /// API to other extensions.
        /// </summary>
        abstract EventEmitter: EventEmitterStatic
        /// <summary>
        /// A relative pattern is a helper to construct glob patterns that are matched
        /// relatively to a base path. The base path can either be an absolute file path
        /// or a <see cref="WorkspaceFolder">workspace folder</see>.
        /// </summary>
        abstract RelativePattern: RelativePatternStatic
        /// <summary>
        /// Kind of a code action.
        /// 
        /// Kinds are a hierarchical list of identifiers separated by <c>.</c>, e.g. <c>"refactor.extract.function"</c>.
        /// 
        /// Code action kinds are used by VS Code for UI elements such as the refactoring context menu. Users
        /// can also trigger code actions with a specific kind with the <c>editor.action.codeAction</c> command.
        /// </summary>
        abstract CodeActionKind: CodeActionKindStatic
        /// <summary>
        /// A code action represents a change that can be performed in code, e.g. to fix a problem or
        /// to refactor code.
        /// 
        /// A CodeAction must set either <see cref="CodeAction.edit"><c>edit</c></see> and/or a <see cref="CodeAction.command"><c>command</c></see>. If both are supplied, the <c>edit</c> is applied first, then the command is executed.
        /// </summary>
        abstract CodeAction: CodeActionStatic
        /// <summary>
        /// A code lens represents a <see cref="Command">command</see> that should be shown along with
        /// source text, like the number of references, a way to run tests, etc.
        /// 
        /// A code lens is _unresolved_ when no command is associated to it. For performance
        /// reasons the creation of a code lens and resolving should be done to two stages.
        /// </summary>
        /// <seealso cref="CodeLensProvider.provideCodeLenses">CodeLensProvider.provideCodeLenses</seealso>
        /// <seealso cref="CodeLensProvider.resolveCodeLens">CodeLensProvider.resolveCodeLens</seealso>
        abstract CodeLens: CodeLensStatic
        /// The MarkdownString represents human readable text that supports formatting via the
        /// markdown syntax. Standard markdown is supported, also tables, but no embedded html.
        abstract MarkdownString: MarkdownStringStatic
        /// A hover represents additional information for a symbol or word. Hovers are
        /// rendered in a tooltip-like widget.
        abstract Hover: HoverStatic
        /// A document highlight is a range inside a text document which deserves
        /// special attention. Usually a document highlight is visualized by changing
        /// the background color of its range.
        abstract DocumentHighlight: DocumentHighlightStatic
        /// Represents information about programming constructs like variables, classes,
        /// interfaces etc.
        abstract SymbolInformation: SymbolInformationStatic
        /// Represents programming constructs like variables, classes, interfaces etc. that appear in a document. Document
        /// symbols can be hierarchical and they have two ranges: one that encloses its definition and one that points to
        /// its most interesting range, e.g. the range of an identifier.
        abstract DocumentSymbol: DocumentSymbolStatic
        /// A text edit represents edits that should be applied
        /// to a document.
        abstract TextEdit: TextEditStatic
        /// <summary>
        /// A workspace edit is a collection of textual and files changes for
        /// multiple resources and documents.
        /// 
        /// Use the <see cref="workspace.applyEdit">applyEdit</see>-function to apply a workspace edit.
        /// </summary>
        abstract WorkspaceEdit: WorkspaceEditStatic
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
        abstract SnippetString: SnippetStringStatic
        /// Represents a parameter of a callable-signature. A parameter can
        /// have a label and a doc-comment.
        abstract ParameterInformation: ParameterInformationStatic
        /// Represents the signature of something callable. A signature
        /// can have a label, like a function-name, a doc-comment, and
        /// a set of parameters.
        abstract SignatureInformation: SignatureInformationStatic
        /// Signature help represents the signature of something
        /// callable. There can be multiple signatures but only one
        /// active and only one active parameter.
        abstract SignatureHelp: SignatureHelpStatic
        /// <summary>
        /// A completion item represents a text snippet that is proposed to complete text that is being typed.
        /// 
        /// It is sufficient to create a completion item from just a <see cref="CompletionItem.label">label</see>. In that
        /// case the completion item will replace the <see cref="TextDocument.getWordRangeAtPosition">word</see>
        /// until the cursor with the given label or <see cref="CompletionItem.insertText">insertText</see>. Otherwise the
        /// given <see cref="CompletionItem.textEdit">edit</see> is used.
        /// 
        /// When selecting a completion item in the editor its defined or synthesized text edit will be applied
        /// to *all* cursors/selections whereas <see cref="CompletionItem.additionalTextEdits">additionalTextEdits</see> will be
        /// applied as provided.
        /// </summary>
        /// <seealso cref="CompletionItemProvider.provideCompletionItems">CompletionItemProvider.provideCompletionItems</seealso>
        /// <seealso cref="CompletionItemProvider.resolveCompletionItem">CompletionItemProvider.resolveCompletionItem</seealso>
        abstract CompletionItem: CompletionItemStatic
        /// <summary>
        /// Represents a collection of <see cref="CompletionItem">completion items</see> to be presented
        /// in the editor.
        /// </summary>
        abstract CompletionList: CompletionListStatic
        /// A document link is a range in a text document that links to an internal or external resource, like another
        /// text document or a web site.
        abstract DocumentLink: DocumentLinkStatic
        /// Represents a color in RGBA space.
        abstract Color: ColorStatic
        /// Represents a color range from a document.
        abstract ColorInformation: ColorInformationStatic
        /// <summary>
        /// A color presentation object describes how a <see cref="Color"><c>color</c></see> should be represented as text and what
        /// edits are required to refer to it from source code.
        /// 
        /// For some languages one color can have multiple presentations, e.g. css can represent the color red with
        /// the constant <c>Red</c>, the hex-value <c>#ff0000</c>, or in rgba and hsla forms. In csharp other representations
        /// apply, e.g <c>System.Drawing.Color.Red</c>.
        /// </summary>
        abstract ColorPresentation: ColorPresentationStatic
        /// A line based folding range. To be valid, start and end line must a zero or larger and smaller than the number of lines in the document.
        /// Invalid ranges will be ignored.
        abstract FoldingRange: FoldingRangeStatic
        /// Represents a location inside a resource, such as a line
        /// inside a text file.
        abstract Location: LocationStatic
        /// Represents a related message and source code location for a diagnostic. This should be
        /// used to point to code locations that cause or related to a diagnostics, e.g when duplicating
        /// a symbol in a scope.
        abstract DiagnosticRelatedInformation: DiagnosticRelatedInformationStatic
        /// Represents a diagnostic, such as a compiler error or warning. Diagnostic objects
        /// are only valid in the scope of a file.
        abstract Diagnostic: DiagnosticStatic
        /// A grouping for tasks. The editor by default supports the
        /// 'Clean', 'Build', 'RebuildAll' and 'Test' group.
        abstract TaskGroup: TaskGroupStatic
        /// The execution of a task happens as an external process
        /// without shell interaction.
        abstract ProcessExecution: ProcessExecutionStatic
        abstract ShellExecution: ShellExecutionStatic
        /// A task to execute
        abstract Task: TaskStatic
        /// <summary>
        /// A type that filesystem providers should use to signal errors.
        /// 
        /// This class has factory methods for common error-cases, like <c>EntryNotFound</c> when
        /// a file or folder doesn't exist, use them like so: <c>throw vscode.FileSystemError.EntryNotFound(someUri);</c>
        /// </summary>
        abstract FileSystemError: FileSystemErrorStatic
        abstract TreeItem: TreeItemStatic
        /// <summary>Predefined buttons for <see cref="QuickPick">QuickPick</see> and <see cref="InputBox">InputBox</see>.</summary>
        abstract QuickInputButtons: QuickInputButtonsStatic
        /// Represents a debug adapter executable and optional arguments and runtime options passed to it.
        abstract DebugAdapterExecutable: DebugAdapterExecutableStatic
        /// Represents a debug adapter running as a socket based server.
        abstract DebugAdapterServer: DebugAdapterServerStatic
        /// The base class of all breakpoint types.
        abstract Breakpoint: BreakpointStatic
        /// A breakpoint specified by a source location.
        abstract SourceBreakpoint: SourceBreakpointStatic
        /// A breakpoint specified by a function name.
        abstract FunctionBreakpoint: FunctionBreakpointStatic

    /// Represents a reference to a command. Provides a title which
    /// will be used to represent a command in the UI and, optionally,
    /// an array of arguments which will be passed to the command handler
    /// function when invoked.
    type [<AllowNullLiteral>] Command =
        /// <summary>Title of the command, like <c>save</c>.</summary>
        abstract title: string with get, set
        /// <summary>The identifier of the actual command handler.</summary>
        /// <seealso cref="commands.registerCommand">commands.registerCommand .</seealso>
        abstract command: string with get, set
        /// A tooltip for the command, when represented in the UI.
        abstract tooltip: string option with get, set
        /// Arguments that the command handler should be
        /// invoked with.
        abstract arguments: ResizeArray<obj option> option with get, set

    /// <summary>
    /// Represents a line of text, such as a line of source code.
    /// 
    /// TextLine objects are __immutable__. When a <see cref="TextDocument">document</see> changes,
    /// previously retrieved lines will not represent the latest state.
    /// </summary>
    type [<AllowNullLiteral>] TextLine =
        /// The zero-based line number.
        abstract lineNumber: float
        /// The text of this line without the line separator characters.
        abstract text: string
        /// The range this line covers without the line separator characters.
        abstract range: Range
        /// The range this line covers with the line separator characters.
        abstract rangeIncludingLineBreak: Range
        /// <summary>
        /// The offset of the first character which is not a whitespace character as defined
        /// by <c>/\s/</c>. **Note** that if a line is all whitespace the length of the line is returned.
        /// </summary>
        abstract firstNonWhitespaceCharacterIndex: float
        /// <summary>
        /// Whether this line is whitespace only, shorthand
        /// for <see cref="TextLine.firstNonWhitespaceCharacterIndex">TextLine.firstNonWhitespaceCharacterIndex</see> === <see cref="TextLine.text">TextLine.text.length</see>.
        /// </summary>
        abstract isEmptyOrWhitespace: bool

    /// <summary>
    /// Represents a text document, such as a source file. Text documents have
    /// <see cref="TextLine">lines</see> and knowledge about an underlying resource like a file.
    /// </summary>
    type [<AllowNullLiteral>] TextDocument =
        /// <summary>
        /// The associated uri for this document.
        /// 
        /// *Note* that most documents use the <c>file</c>-scheme, which means they are files on disk. However, **not** all documents are
        /// saved on disk and therefore the <c>scheme</c> must be checked before trying to access the underlying file or siblings on disk.
        /// </summary>
        /// <seealso cref="FileSystemProvider">FileSystemProvider</seealso>
        /// <seealso cref="TextDocumentContentProvider">TextDocumentContentProvider</seealso>
        abstract uri: Uri
        /// <summary>
        /// The file system path of the associated resource. Shorthand
        /// notation for <see cref="TextDocument.uri">TextDocument.uri.fsPath</see>. Independent of the uri scheme.
        /// </summary>
        abstract fileName: string
        /// <summary>
        /// Is this document representing an untitled file which has never been saved yet. *Note* that
        /// this does not mean the document will be saved to disk, use <see cref="Uri.scheme"><c>uri.scheme</c></see>
        /// to figure out where a document will be <see cref="FileSystemProvider">saved</see>, e.g. <c>file</c>, <c>ftp</c> etc.
        /// </summary>
        abstract isUntitled: bool
        /// The identifier of the language associated with this document.
        abstract languageId: string
        /// The version number of this document (it will strictly increase after each
        /// change, including undo/redo).
        abstract version: float
        /// <summary><c>true</c> if there are unpersisted changes.</summary>
        abstract isDirty: bool
        /// <summary>
        /// <c>true</c> if the document have been closed. A closed document isn't synchronized anymore
        /// and won't be re-used when the same resource is opened again.
        /// </summary>
        abstract isClosed: bool
        /// <summary>Save the underlying file.</summary>
        /// <returns>
        /// A promise that will resolve to true when the file
        /// has been saved. If the file was not dirty or the save failed,
        /// will return false.
        /// </returns>
        abstract save: unit -> Thenable<bool>
        /// <summary>
        /// The <see cref="EndOfLine">end of line</see> sequence that is predominately
        /// used in this document.
        /// </summary>
        abstract eol: EndOfLine
        /// The number of lines in this document.
        abstract lineCount: float
        /// <summary>
        /// Returns a text line denoted by the line number. Note
        /// that the returned object is *not* live and changes to the
        /// document are not reflected.
        /// </summary>
        /// <param name="line">A line number in [0, lineCount).</param>
        /// <returns>A <see cref="TextLine">line</see>.</returns>
        abstract lineAt: line: float -> TextLine
        /// <summary>
        /// Returns a text line denoted by the position. Note
        /// that the returned object is *not* live and changes to the
        /// document are not reflected.
        /// 
        /// The position will be <see cref="TextDocument.validatePosition">adjusted</see>.
        /// </summary>
        /// <seealso cref="TextDocument.lineAt">TextDocument.lineAt</seealso>
        /// <param name="position">A position.</param>
        /// <returns>A <see cref="TextLine">line</see>.</returns>
        abstract lineAt: position: Position -> TextLine
        /// <summary>
        /// Converts the position to a zero-based offset.
        /// 
        /// The position will be <see cref="TextDocument.validatePosition">adjusted</see>.
        /// </summary>
        /// <param name="position">A position.</param>
        /// <returns>A valid zero-based offset.</returns>
        abstract offsetAt: position: Position -> float
        /// <summary>Converts a zero-based offset to a position.</summary>
        /// <param name="offset">A zero-based offset.</param>
        /// <returns>A valid <see cref="Position">position</see>.</returns>
        abstract positionAt: offset: float -> Position
        /// <summary>
        /// Get the text of this document. A substring can be retrieved by providing
        /// a range. The range will be <see cref="TextDocument.validateRange">adjusted</see>.
        /// </summary>
        /// <param name="range">Include only the text included by the range.</param>
        /// <returns>The text inside the provided range or the entire text.</returns>
        abstract getText: ?range: Range -> string
        /// <summary>
        /// Get a word-range at the given position. By default words are defined by
        /// common separators, like space, -, _, etc. In addition, per language custom
        /// <see cref="LanguageConfiguration.wordPattern">word definitions</see> can be defined. It
        /// is also possible to provide a custom regular expression.
        /// 
        /// * *Note 1:* A custom regular expression must not match the empty string and
        /// if it does, it will be ignored.
        /// * *Note 2:* A custom regular expression will fail to match multiline strings
        /// and in the name of speed regular expressions should not match words with
        /// spaces. Use <see cref="TextLine.text"><c>TextLine.text</c></see> for more complex, non-wordy, scenarios.
        /// 
        /// The position will be <see cref="TextDocument.validatePosition">adjusted</see>.
        /// </summary>
        /// <param name="position">A position.</param>
        /// <param name="regex">Optional regular expression that describes what a word is.</param>
        /// <returns>A range spanning a word, or <c>undefined</c>.</returns>
        abstract getWordRangeAtPosition: position: Position * ?regex: RegExp -> Range option
        /// <summary>Ensure a range is completely contained in this document.</summary>
        /// <param name="range">A range.</param>
        /// <returns>The given range or a new, adjusted range.</returns>
        abstract validateRange: range: Range -> Range
        /// <summary>Ensure a position is contained in the range of this document.</summary>
        /// <param name="position">A position.</param>
        /// <returns>The given position or a new, adjusted position.</returns>
        abstract validatePosition: position: Position -> Position

    /// <summary>
    /// Represents a line and character position, such as
    /// the position of the cursor.
    /// 
    /// Position objects are __immutable__. Use the <see cref="Position.with">with</see> or
    /// <see cref="Position.translate">translate</see> methods to derive new positions
    /// from an existing position.
    /// </summary>
    type [<AllowNullLiteral>] Position =
        /// The zero-based line value.
        abstract line: float
        /// The zero-based character value.
        abstract character: float
        /// <summary>Check if this position is before <c>other</c>.</summary>
        /// <param name="other">A position.</param>
        /// <returns>
        /// <c>true</c> if position is on a smaller line
        /// or on the same line on a smaller character.
        /// </returns>
        abstract isBefore: other: Position -> bool
        /// <summary>Check if this position is before or equal to <c>other</c>.</summary>
        /// <param name="other">A position.</param>
        /// <returns>
        /// <c>true</c> if position is on a smaller line
        /// or on the same line on a smaller or equal character.
        /// </returns>
        abstract isBeforeOrEqual: other: Position -> bool
        /// <summary>Check if this position is after <c>other</c>.</summary>
        /// <param name="other">A position.</param>
        /// <returns>
        /// <c>true</c> if position is on a greater line
        /// or on the same line on a greater character.
        /// </returns>
        abstract isAfter: other: Position -> bool
        /// <summary>Check if this position is after or equal to <c>other</c>.</summary>
        /// <param name="other">A position.</param>
        /// <returns>
        /// <c>true</c> if position is on a greater line
        /// or on the same line on a greater or equal character.
        /// </returns>
        abstract isAfterOrEqual: other: Position -> bool
        /// <summary>Check if this position is equal to <c>other</c>.</summary>
        /// <param name="other">A position.</param>
        /// <returns>
        /// <c>true</c> if the line and character of the given position are equal to
        /// the line and character of this position.
        /// </returns>
        abstract isEqual: other: Position -> bool
        /// <summary>Compare this to <c>other</c>.</summary>
        /// <param name="other">A position.</param>
        /// <returns>
        /// A number smaller than zero if this position is before the given position,
        /// a number greater than zero if this position is after the given position, or zero when
        /// this and the given position are equal.
        /// </returns>
        abstract compareTo: other: Position -> float
        /// <summary>Create a new position relative to this position.</summary>
        /// <param name="lineDelta">Delta value for the line value, default is <c>0</c>.</param>
        /// <param name="characterDelta">Delta value for the character value, default is <c>0</c>.</param>
        /// <returns>
        /// A position which line and character is the sum of the current line and
        /// character and the corresponding deltas.
        /// </returns>
        abstract translate: ?lineDelta: float * ?characterDelta: float -> Position
        /// <summary>Derived a new position relative to this position.</summary>
        /// <param name="change">An object that describes a delta to this position.</param>
        /// <returns>
        /// A position that reflects the given delta. Will return <c>this</c> position if the change
        /// is not changing anything.
        /// </returns>
        abstract translate: change: {| lineDelta: float option; characterDelta: float option |} -> Position
        /// <summary>Create a new position derived from this position.</summary>
        /// <param name="line">Value that should be used as line value, default is the <see cref="Position.line">existing value</see></param>
        /// <param name="character">Value that should be used as character value, default is the <see cref="Position.character">existing value</see></param>
        /// <returns>A position where line and character are replaced by the given values.</returns>
        abstract ``with``: ?line: float * ?character: float -> Position
        /// <summary>Derived a new position from this position.</summary>
        /// <param name="change">An object that describes a change to this position.</param>
        /// <returns>
        /// A position that reflects the given change. Will return <c>this</c> position if the change
        /// is not changing anything.
        /// </returns>
        abstract ``with``: change: {| line: float option; character: float option |} -> Position

    /// <summary>
    /// Represents a line and character position, such as
    /// the position of the cursor.
    /// 
    /// Position objects are __immutable__. Use the <see cref="Position.with">with</see> or
    /// <see cref="Position.translate">translate</see> methods to derive new positions
    /// from an existing position.
    /// </summary>
    type [<AllowNullLiteral>] PositionStatic =
        /// <param name="line">A zero-based line value.</param>
        /// <param name="character">A zero-based character value.</param>
        [<EmitConstructor>] abstract Create: line: float * character: float -> Position

    /// <summary>
    /// A range represents an ordered pair of two positions.
    /// It is guaranteed that <see cref="Range.start">start</see>.isBeforeOrEqual(<see cref="Range.end)">end</see>
    /// 
    /// Range objects are __immutable__. Use the <see cref="Range.with">with</see>,
    /// <see cref="Range.intersection">intersection</see>, or <see cref="Range.union">union</see> methods
    /// to derive new ranges from an existing range.
    /// </summary>
    type [<AllowNullLiteral>] Range =
        /// <summary>The start position. It is before or equal to <see cref="Range.end">end</see>.</summary>
        abstract start: Position
        /// <summary>The end position. It is after or equal to <see cref="Range.start">start</see>.</summary>
        abstract ``end``: Position
        /// <summary><c>true</c> if <c>start</c> and <c>end</c> are equal.</summary>
        abstract isEmpty: bool with get, set
        /// <summary><c>true</c> if <c>start.line</c> and <c>end.line</c> are equal.</summary>
        abstract isSingleLine: bool with get, set
        /// <summary>Check if a position or a range is contained in this range.</summary>
        /// <param name="positionOrRange">A position or a range.</param>
        /// <returns>
        /// <c>true</c> if the position or range is inside or equal
        /// to this range.
        /// </returns>
        abstract contains: positionOrRange: U2<Position, Range> -> bool
        /// <summary>Check if <c>other</c> equals this range.</summary>
        /// <param name="other">A range.</param>
        /// <returns>
        /// <c>true</c> when start and end are <see cref="Position.isEqual">equal</see> to
        /// start and end of this range.
        /// </returns>
        abstract isEqual: other: Range -> bool
        /// <summary>
        /// Intersect <c>range</c> with this range and returns a new range or <c>undefined</c>
        /// if the ranges have no overlap.
        /// </summary>
        /// <param name="range">A range.</param>
        /// <returns>
        /// A range of the greater start and smaller end positions. Will
        /// return undefined when there is no overlap.
        /// </returns>
        abstract intersection: range: Range -> Range option
        /// <summary>Compute the union of <c>other</c> with this range.</summary>
        /// <param name="other">A range.</param>
        /// <returns>A range of smaller start position and the greater end position.</returns>
        abstract union: other: Range -> Range
        /// <summary>Derived a new range from this range.</summary>
        /// <param name="start">A position that should be used as start. The default value is the <see cref="Range.start">current start</see>.</param>
        /// <param name="end">A position that should be used as end. The default value is the <see cref="Range.end">current end</see>.</param>
        /// <returns>
        /// A range derived from this range with the given start and end position.
        /// If start and end are not different <c>this</c> range will be returned.
        /// </returns>
        abstract ``with``: ?start: Position * ?``end``: Position -> Range
        /// <summary>Derived a new range from this range.</summary>
        /// <param name="change">An object that describes a change to this range.</param>
        /// <returns>
        /// A range that reflects the given change. Will return <c>this</c> range if the change
        /// is not changing anything.
        /// </returns>
        abstract ``with``: change: {| start: Position option; ``end``: Position option |} -> Range

    /// <summary>
    /// A range represents an ordered pair of two positions.
    /// It is guaranteed that <see cref="Range.start">start</see>.isBeforeOrEqual(<see cref="Range.end)">end</see>
    /// 
    /// Range objects are __immutable__. Use the <see cref="Range.with">with</see>,
    /// <see cref="Range.intersection">intersection</see>, or <see cref="Range.union">union</see> methods
    /// to derive new ranges from an existing range.
    /// </summary>
    type [<AllowNullLiteral>] RangeStatic =
        /// <summary>
        /// Create a new range from two positions. If <c>start</c> is not
        /// before or equal to <c>end</c>, the values will be swapped.
        /// </summary>
        /// <param name="start">A position.</param>
        /// <param name="end">A position.</param>
        [<EmitConstructor>] abstract Create: start: Position * ``end``: Position -> Range
        /// <summary>
        /// Create a new range from number coordinates. It is a shorter equivalent of
        /// using <c>new Range(new Position(startLine, startCharacter), new Position(endLine, endCharacter))</c>
        /// </summary>
        /// <param name="startLine">A zero-based line value.</param>
        /// <param name="startCharacter">A zero-based character value.</param>
        /// <param name="endLine">A zero-based line value.</param>
        /// <param name="endCharacter">A zero-based character value.</param>
        [<EmitConstructor>] abstract Create: startLine: float * startCharacter: float * endLine: float * endCharacter: float -> Range

    /// Represents a text selection in an editor.
    type [<AllowNullLiteral>] Selection =
        inherit Range
        /// <summary>
        /// The position at which the selection starts.
        /// This position might be before or after <see cref="Selection.active">active</see>.
        /// </summary>
        abstract anchor: Position with get, set
        /// <summary>
        /// The position of the cursor.
        /// This position might be before or after <see cref="Selection.anchor">anchor</see>.
        /// </summary>
        abstract active: Position with get, set
        /// <summary>A selection is reversed if <see cref="Selection.active">active</see>.isBefore(<see cref="Selection.anchor)">anchor</see>.</summary>
        abstract isReversed: bool with get, set

    /// Represents a text selection in an editor.
    type [<AllowNullLiteral>] SelectionStatic =
        /// <summary>Create a selection from two positions.</summary>
        /// <param name="anchor">A position.</param>
        /// <param name="active">A position.</param>
        [<EmitConstructor>] abstract Create: anchor: Position * active: Position -> Selection
        /// <summary>Create a selection from four coordinates.</summary>
        /// <param name="anchorLine">A zero-based line value.</param>
        /// <param name="anchorCharacter">A zero-based character value.</param>
        /// <param name="activeLine">A zero-based line value.</param>
        /// <param name="activeCharacter">A zero-based character value.</param>
        [<EmitConstructor>] abstract Create: anchorLine: float * anchorCharacter: float * activeLine: float * activeCharacter: float -> Selection

    /// <summary>Represents sources that can cause <see cref="window.onDidChangeTextEditorSelection">selection change events</see>.</summary>
    type [<RequireQualifiedAccess>] TextEditorSelectionChangeKind =
        /// Selection changed due to typing in the editor.
        | Keyboard = 1
        /// Selection change due to clicking in the editor.
        | Mouse = 2
        /// Selection changed because a command ran.
        | Command = 3

    /// <summary>Represents an event describing the change in a <see cref="TextEditor.selections">text editor's selections</see>.</summary>
    type [<AllowNullLiteral>] TextEditorSelectionChangeEvent =
        /// <summary>The <see cref="TextEditor">text editor</see> for which the selections have changed.</summary>
        abstract textEditor: TextEditor with get, set
        /// <summary>The new value for the <see cref="TextEditor.selections">text editor's selections</see>.</summary>
        abstract selections: ResizeArray<Selection> with get, set
        /// <summary>
        /// The <see cref="TextEditorSelectionChangeKind">change kind</see> which has triggered this
        /// event. Can be <c>undefined</c>.
        /// </summary>
        abstract kind: TextEditorSelectionChangeKind option with get, set

    /// <summary>Represents an event describing the change in a <see cref="TextEditor.visibleRanges">text editor's visible ranges</see>.</summary>
    type [<AllowNullLiteral>] TextEditorVisibleRangesChangeEvent =
        /// <summary>The <see cref="TextEditor">text editor</see> for which the visible ranges have changed.</summary>
        abstract textEditor: TextEditor with get, set
        /// <summary>The new value for the <see cref="TextEditor.visibleRanges">text editor's visible ranges</see>.</summary>
        abstract visibleRanges: ResizeArray<Range> with get, set

    /// <summary>Represents an event describing the change in a <see cref="TextEditor.options">text editor's options</see>.</summary>
    type [<AllowNullLiteral>] TextEditorOptionsChangeEvent =
        /// <summary>The <see cref="TextEditor">text editor</see> for which the options have changed.</summary>
        abstract textEditor: TextEditor with get, set
        /// <summary>The new value for the <see cref="TextEditor.options">text editor's options</see>.</summary>
        abstract options: TextEditorOptions with get, set

    /// <summary>Represents an event describing the change of a <see cref="TextEditor.viewColumn">text editor's view column</see>.</summary>
    type [<AllowNullLiteral>] TextEditorViewColumnChangeEvent =
        /// <summary>The <see cref="TextEditor">text editor</see> for which the view column has changed.</summary>
        abstract textEditor: TextEditor with get, set
        /// <summary>The new value for the <see cref="TextEditor.viewColumn">text editor's view column</see>.</summary>
        abstract viewColumn: ViewColumn with get, set

    /// Rendering style of the cursor.
    type [<RequireQualifiedAccess>] TextEditorCursorStyle =
        /// Render the cursor as a vertical thick line.
        | Line = 1
        /// Render the cursor as a block filled.
        | Block = 2
        /// Render the cursor as a thick horizontal line.
        | Underline = 3
        /// Render the cursor as a vertical thin line.
        | LineThin = 4
        /// Render the cursor as a block outlined.
        | BlockOutline = 5
        /// Render the cursor as a thin horizontal line.
        | UnderlineThin = 6

    /// Rendering style of the line numbers.
    type [<RequireQualifiedAccess>] TextEditorLineNumbersStyle =
        /// Do not render the line numbers.
        | Off = 0
        /// Render the line numbers.
        | On = 1
        /// Render the line numbers with values relative to the primary cursor location.
        | Relative = 2

    /// <summary>Represents a <see cref="TextEditor">text editor</see>'s <see cref="TextEditor.options">options</see>.</summary>
    type [<AllowNullLiteral>] TextEditorOptions =
        /// <summary>
        /// The size in spaces a tab takes. This is used for two purposes:
        ///   - the rendering width of a tab character;
        ///   - the number of spaces to insert when <see cref="TextEditorOptions.insertSpaces">insertSpaces</see> is true.
        /// 
        /// When getting a text editor's options, this property will always be a number (resolved).
        /// When setting a text editor's options, this property is optional and it can be a number or <c>"auto"</c>.
        /// </summary>
        abstract tabSize: U2<float, string> option with get, set
        /// <summary>
        /// When pressing Tab insert <see cref="TextEditorOptions.tabSize">n</see> spaces.
        /// When getting a text editor's options, this property will always be a boolean (resolved).
        /// When setting a text editor's options, this property is optional and it can be a boolean or <c>"auto"</c>.
        /// </summary>
        abstract insertSpaces: U2<bool, string> option with get, set
        /// The rendering style of the cursor in this editor.
        /// When getting a text editor's options, this property will always be present.
        /// When setting a text editor's options, this property is optional.
        abstract cursorStyle: TextEditorCursorStyle option with get, set
        /// Render relative line numbers w.r.t. the current line number.
        /// When getting a text editor's options, this property will always be present.
        /// When setting a text editor's options, this property is optional.
        abstract lineNumbers: TextEditorLineNumbersStyle option with get, set

    /// <summary>
    /// Represents a handle to a set of decorations
    /// sharing the same <see cref="DecorationRenderOptions">styling options</see> in a <see cref="TextEditor">text editor</see>.
    /// 
    /// To get an instance of a <c>TextEditorDecorationType</c> use
    /// <see cref="window.createTextEditorDecorationType">createTextEditorDecorationType</see>.
    /// </summary>
    type [<AllowNullLiteral>] TextEditorDecorationType =
        /// Internal representation of the handle.
        abstract key: string
        /// Remove this decoration type and all decorations on all text editors using it.
        abstract dispose: unit -> unit

    /// <summary>Represents different <see cref="TextEditor.revealRange">reveal</see> strategies in a text editor.</summary>
    type [<RequireQualifiedAccess>] TextEditorRevealType =
        /// The range will be revealed with as little scrolling as possible.
        | Default = 0
        /// The range will always be revealed in the center of the viewport.
        | InCenter = 1
        /// If the range is outside the viewport, it will be revealed in the center of the viewport.
        /// Otherwise, it will be revealed with as little scrolling as possible.
        | InCenterIfOutsideViewport = 2
        /// The range will always be revealed at the top of the viewport.
        | AtTop = 3

    /// <summary>
    /// Represents different positions for rendering a decoration in an <see cref="DecorationRenderOptions.overviewRulerLane">overview ruler</see>.
    /// The overview ruler supports three lanes.
    /// </summary>
    type [<RequireQualifiedAccess>] OverviewRulerLane =
        | Left = 1
        | Center = 2
        | Right = 4
        | Full = 7

    /// Describes the behavior of decorations when typing/editing at their edges.
    type [<RequireQualifiedAccess>] DecorationRangeBehavior =
        /// The decoration's range will widen when edits occur at the start or end.
        | OpenOpen = 0
        /// The decoration's range will not widen when edits occur at the start of end.
        | ClosedClosed = 1
        /// The decoration's range will widen when edits occur at the start, but not at the end.
        | OpenClosed = 2
        /// The decoration's range will widen when edits occur at the end, but not at the start.
        | ClosedOpen = 3

    /// <summary>Represents options to configure the behavior of showing a <see cref="TextDocument">document</see> in an <see cref="TextEditor">editor</see>.</summary>
    type [<AllowNullLiteral>] TextDocumentShowOptions =
        /// <summary>
        /// An optional view column in which the <see cref="TextEditor">editor</see> should be shown.
        /// The default is the <see cref="ViewColumn.Active">active</see>, other values are adjusted to
        /// be <c>Min(column, columnCount + 1)</c>, the <see cref="ViewColumn.Active">active</see>-column is
        /// not adjusted. Use <see cref="ViewColumn.Beside"><c>ViewColumn.Beside</c></see> to open the
        /// editor to the side of the currently active one.
        /// </summary>
        abstract viewColumn: ViewColumn option with get, set
        /// <summary>An optional flag that when <c>true</c> will stop the <see cref="TextEditor">editor</see> from taking focus.</summary>
        abstract preserveFocus: bool option with get, set
        /// <summary>
        /// An optional flag that controls if an <see cref="TextEditor">editor</see>-tab will be replaced
        /// with the next editor or if it will be kept.
        /// </summary>
        abstract preview: bool option with get, set
        /// <summary>An optional selection to apply for the document in the <see cref="TextEditor">editor</see>.</summary>
        abstract selection: Range option with get, set

    /// <summary>
    /// A reference to one of the workbench colors as defined in <see href="https://code.visualstudio.com/docs/getstarted/theme-color-reference." />
    /// Using a theme color is preferred over a custom color as it gives theme authors and users the possibility to change the color.
    /// </summary>
    type [<AllowNullLiteral>] ThemeColor =
        interface end

    /// <summary>
    /// A reference to one of the workbench colors as defined in <see href="https://code.visualstudio.com/docs/getstarted/theme-color-reference." />
    /// Using a theme color is preferred over a custom color as it gives theme authors and users the possibility to change the color.
    /// </summary>
    type [<AllowNullLiteral>] ThemeColorStatic =
        /// <summary>Creates a reference to a theme color.</summary>
        /// <param name="id">of the color. The available colors are listed in <see href="https://code.visualstudio.com/docs/getstarted/theme-color-reference." /></param>
        [<EmitConstructor>] abstract Create: id: string -> ThemeColor

    /// <summary>
    /// A reference to a named icon. Currently only <see cref="ThemeIcon.File">File</see> and <see cref="ThemeIcon.Folder">Folder</see> are supported.
    /// Using a theme icon is preferred over a custom icon as it gives theme authors the possibility to change the icons.
    /// </summary>
    type [<AllowNullLiteral>] ThemeIcon =
        interface end

    /// <summary>
    /// A reference to a named icon. Currently only <see cref="ThemeIcon.File">File</see> and <see cref="ThemeIcon.Folder">Folder</see> are supported.
    /// Using a theme icon is preferred over a custom icon as it gives theme authors the possibility to change the icons.
    /// </summary>
    type [<AllowNullLiteral>] ThemeIconStatic =
        /// Reference to a icon representing a file. The icon is taken from the current file icon theme or a placeholder icon.
        abstract File: ThemeIcon
        /// Reference to a icon representing a folder. The icon is taken from the current file icon theme or a placeholder icon.
        abstract Folder: ThemeIcon

    /// <summary>Represents theme specific rendering styles for a <see cref="TextEditorDecorationType">text editor decoration</see>.</summary>
    type [<AllowNullLiteral>] ThemableDecorationRenderOptions =
        /// <summary>
        /// Background color of the decoration. Use rgba() and define transparent background colors to play well with other decorations.
        /// Alternatively a color from the color registry can be <see cref="ThemeColor">referenced</see>.
        /// </summary>
        abstract backgroundColor: U2<string, ThemeColor> option with get, set
        /// CSS styling property that will be applied to text enclosed by a decoration.
        abstract outline: string option with get, set
        /// CSS styling property that will be applied to text enclosed by a decoration.
        /// Better use 'outline' for setting one or more of the individual outline properties.
        abstract outlineColor: U2<string, ThemeColor> option with get, set
        /// CSS styling property that will be applied to text enclosed by a decoration.
        /// Better use 'outline' for setting one or more of the individual outline properties.
        abstract outlineStyle: string option with get, set
        /// CSS styling property that will be applied to text enclosed by a decoration.
        /// Better use 'outline' for setting one or more of the individual outline properties.
        abstract outlineWidth: string option with get, set
        /// CSS styling property that will be applied to text enclosed by a decoration.
        abstract border: string option with get, set
        /// CSS styling property that will be applied to text enclosed by a decoration.
        /// Better use 'border' for setting one or more of the individual border properties.
        abstract borderColor: U2<string, ThemeColor> option with get, set
        /// CSS styling property that will be applied to text enclosed by a decoration.
        /// Better use 'border' for setting one or more of the individual border properties.
        abstract borderRadius: string option with get, set
        /// CSS styling property that will be applied to text enclosed by a decoration.
        /// Better use 'border' for setting one or more of the individual border properties.
        abstract borderSpacing: string option with get, set
        /// CSS styling property that will be applied to text enclosed by a decoration.
        /// Better use 'border' for setting one or more of the individual border properties.
        abstract borderStyle: string option with get, set
        /// CSS styling property that will be applied to text enclosed by a decoration.
        /// Better use 'border' for setting one or more of the individual border properties.
        abstract borderWidth: string option with get, set
        /// CSS styling property that will be applied to text enclosed by a decoration.
        abstract fontStyle: string option with get, set
        /// CSS styling property that will be applied to text enclosed by a decoration.
        abstract fontWeight: string option with get, set
        /// CSS styling property that will be applied to text enclosed by a decoration.
        abstract textDecoration: string option with get, set
        /// CSS styling property that will be applied to text enclosed by a decoration.
        abstract cursor: string option with get, set
        /// CSS styling property that will be applied to text enclosed by a decoration.
        abstract color: U2<string, ThemeColor> option with get, set
        /// CSS styling property that will be applied to text enclosed by a decoration.
        abstract opacity: string option with get, set
        /// CSS styling property that will be applied to text enclosed by a decoration.
        abstract letterSpacing: string option with get, set
        /// An **absolute path** or an URI to an image to be rendered in the gutter.
        abstract gutterIconPath: U2<string, Uri> option with get, set
        /// <summary>
        /// Specifies the size of the gutter icon.
        /// Available values are 'auto', 'contain', 'cover' and any percentage value.
        /// For further information: <see href="https://msdn.microsoft.com/en-us/library/jj127316(v=vs.85).aspx" />
        /// </summary>
        abstract gutterIconSize: string option with get, set
        /// The color of the decoration in the overview ruler. Use rgba() and define transparent colors to play well with other decorations.
        abstract overviewRulerColor: U2<string, ThemeColor> option with get, set
        /// Defines the rendering options of the attachment that is inserted before the decorated text.
        abstract before: ThemableDecorationAttachmentRenderOptions option with get, set
        /// Defines the rendering options of the attachment that is inserted after the decorated text.
        abstract after: ThemableDecorationAttachmentRenderOptions option with get, set

    type [<AllowNullLiteral>] ThemableDecorationAttachmentRenderOptions =
        /// Defines a text content that is shown in the attachment. Either an icon or a text can be shown, but not both.
        abstract contentText: string option with get, set
        /// An **absolute path** or an URI to an image to be rendered in the attachment. Either an icon
        /// or a text can be shown, but not both.
        abstract contentIconPath: U2<string, Uri> option with get, set
        /// CSS styling property that will be applied to the decoration attachment.
        abstract border: string option with get, set
        /// CSS styling property that will be applied to text enclosed by a decoration.
        abstract borderColor: U2<string, ThemeColor> option with get, set
        /// CSS styling property that will be applied to the decoration attachment.
        abstract fontStyle: string option with get, set
        /// CSS styling property that will be applied to the decoration attachment.
        abstract fontWeight: string option with get, set
        /// CSS styling property that will be applied to the decoration attachment.
        abstract textDecoration: string option with get, set
        /// CSS styling property that will be applied to the decoration attachment.
        abstract color: U2<string, ThemeColor> option with get, set
        /// CSS styling property that will be applied to the decoration attachment.
        abstract backgroundColor: U2<string, ThemeColor> option with get, set
        /// CSS styling property that will be applied to the decoration attachment.
        abstract margin: string option with get, set
        /// CSS styling property that will be applied to the decoration attachment.
        abstract width: string option with get, set
        /// CSS styling property that will be applied to the decoration attachment.
        abstract height: string option with get, set

    /// <summary>Represents rendering styles for a <see cref="TextEditorDecorationType">text editor decoration</see>.</summary>
    type [<AllowNullLiteral>] DecorationRenderOptions =
        inherit ThemableDecorationRenderOptions
        /// <summary>
        /// Should the decoration be rendered also on the whitespace after the line text.
        /// Defaults to <c>false</c>.
        /// </summary>
        abstract isWholeLine: bool option with get, set
        /// <summary>
        /// Customize the growing behavior of the decoration when edits occur at the edges of the decoration's range.
        /// Defaults to <c>DecorationRangeBehavior.OpenOpen</c>.
        /// </summary>
        abstract rangeBehavior: DecorationRangeBehavior option with get, set
        /// The position in the overview ruler where the decoration should be rendered.
        abstract overviewRulerLane: OverviewRulerLane option with get, set
        /// Overwrite options for light themes.
        abstract light: ThemableDecorationRenderOptions option with get, set
        /// Overwrite options for dark themes.
        abstract dark: ThemableDecorationRenderOptions option with get, set

    /// <summary>Represents options for a specific decoration in a <see cref="TextEditorDecorationType">decoration set</see>.</summary>
    type [<AllowNullLiteral>] DecorationOptions =
        /// Range to which this decoration is applied. The range must not be empty.
        abstract range: Range with get, set
        /// A message that should be rendered when hovering over the decoration.
        abstract hoverMessage: U2<MarkedString, ResizeArray<MarkedString>> option with get, set
        /// Render options applied to the current decoration. For performance reasons, keep the
        /// number of decoration specific options small, and use decoration types wherever possible.
        abstract renderOptions: DecorationInstanceRenderOptions option with get, set

    type [<AllowNullLiteral>] ThemableDecorationInstanceRenderOptions =
        /// Defines the rendering options of the attachment that is inserted before the decorated text.
        abstract before: ThemableDecorationAttachmentRenderOptions option with get, set
        /// Defines the rendering options of the attachment that is inserted after the decorated text.
        abstract after: ThemableDecorationAttachmentRenderOptions option with get, set

    type [<AllowNullLiteral>] DecorationInstanceRenderOptions =
        inherit ThemableDecorationInstanceRenderOptions
        /// Overwrite options for light themes.
        abstract light: ThemableDecorationInstanceRenderOptions option with get, set
        /// Overwrite options for dark themes.
        abstract dark: ThemableDecorationInstanceRenderOptions option with get, set

    /// <summary>Represents an editor that is attached to a <see cref="TextDocument">document</see>.</summary>
    type [<AllowNullLiteral>] TextEditor =
        /// The document associated with this text editor. The document will be the same for the entire lifetime of this text editor.
        abstract document: TextDocument
        /// <summary>The primary selection on this text editor. Shorthand for <c>TextEditor.selections[0]</c>.</summary>
        abstract selection: Selection with get, set
        /// The selections in this text editor. The primary selection is always at index 0.
        abstract selections: ResizeArray<Selection> with get, set
        /// The current visible ranges in the editor (vertically).
        /// This accounts only for vertical scrolling, and not for horizontal scrolling.
        abstract visibleRanges: ResizeArray<Range>
        /// Text editor options.
        abstract options: TextEditorOptions with get, set
        /// <summary>
        /// The column in which this editor shows. Will be <c>undefined</c> in case this
        /// isn't one of the main editors, e.g an embedded editor, or when the editor
        /// column is larger than three.
        /// </summary>
        abstract viewColumn: ViewColumn option with get, set
        /// <summary>
        /// Perform an edit on the document associated with this text editor.
        /// 
        /// The given callback-function is invoked with an <see cref="TextEditorEdit">edit-builder</see> which must
        /// be used to make edits. Note that the edit-builder is only valid while the
        /// callback executes.
        /// </summary>
        /// <param name="callback">A function which can create edits using an <see cref="TextEditorEdit">edit-builder</see>.</param>
        /// <param name="options">The undo/redo behavior around this edit. By default, undo stops will be created before and after this edit.</param>
        /// <returns>A promise that resolves with a value indicating if the edits could be applied.</returns>
        abstract edit: callback: (TextEditorEdit -> unit) * ?options: {| undoStopBefore: bool; undoStopAfter: bool |} -> Thenable<bool>
        /// <summary>
        /// Insert a <see cref="SnippetString">snippet</see> and put the editor into snippet mode. "Snippet mode"
        /// means the editor adds placeholders and additional cursors so that the user can complete
        /// or accept the snippet.
        /// </summary>
        /// <param name="snippet">The snippet to insert in this edit.</param>
        /// <param name="location">Position or range at which to insert the snippet, defaults to the current editor selection or selections.</param>
        /// <param name="options">The undo/redo behavior around this edit. By default, undo stops will be created before and after this edit.</param>
        /// <returns>
        /// A promise that resolves with a value indicating if the snippet could be inserted. Note that the promise does not signal
        /// that the snippet is completely filled-in or accepted.
        /// </returns>
        abstract insertSnippet: snippet: SnippetString * ?location: U4<Position, Range, ResizeArray<Position>, ResizeArray<Range>> * ?options: {| undoStopBefore: bool; undoStopAfter: bool |} -> Thenable<bool>
        /// <summary>
        /// Adds a set of decorations to the text editor. If a set of decorations already exists with
        /// the given <see cref="TextEditorDecorationType">decoration type</see>, they will be replaced.
        /// </summary>
        /// <seealso cref="window.createTextEditorDecorationType">createTextEditorDecorationType .</seealso>
        /// <param name="decorationType">A decoration type.</param>
        /// <param name="rangesOrOptions">Either <see cref="Range">ranges</see> or more detailed <see cref="DecorationOptions">options</see>.</param>
        abstract setDecorations: decorationType: TextEditorDecorationType * rangesOrOptions: U2<ResizeArray<Range>, ResizeArray<DecorationOptions>> -> unit
        /// <summary>Scroll as indicated by <c>revealType</c> in order to reveal the given range.</summary>
        /// <param name="range">A range.</param>
        /// <param name="revealType">The scrolling strategy for revealing <c>range</c>.</param>
        abstract revealRange: range: Range * ?revealType: TextEditorRevealType -> unit
        /// <summary>~~Show the text editor.~~</summary>
        /// <param name="column">
        /// The <see cref="ViewColumn">column</see> in which to show this editor.
        /// This method shows unexpected behavior and will be removed in the next major update.
        /// </param>
        [<Obsolete("Use [window.showTextDocument](#window.showTextDocument) instead.")>]
        abstract show: ?column: ViewColumn -> unit
        /// ~~Hide the text editor.~~
        [<Obsolete("Use the command `workbench.action.closeActiveEditor` instead.
This method shows unexpected behavior and will be removed in the next major update.")>]
        abstract hide: unit -> unit

    /// <summary>Represents an end of line character sequence in a <see cref="TextDocument">document</see>.</summary>
    type [<RequireQualifiedAccess>] EndOfLine =
        /// <summary>The line feed <c>\n</c> character.</summary>
        | LF = 1
        /// <summary>The carriage return line feed <c>\r\n</c> sequence.</summary>
        | CRLF = 2

    /// <summary>
    /// A complex edit that will be applied in one transaction on a TextEditor.
    /// This holds a description of the edits and if the edits are valid (i.e. no overlapping regions, document was not changed in the meantime, etc.)
    /// they can be applied on a <see cref="TextDocument">document</see> associated with a <see cref="TextEditor">text editor</see>.
    /// </summary>
    type [<AllowNullLiteral>] TextEditorEdit =
        /// <summary>
        /// Replace a certain text region with a new value.
        /// You can use \r\n or \n in <c>value</c> and they will be normalized to the current <see cref="TextDocument">document</see>.
        /// </summary>
        /// <param name="location">The range this operation should remove.</param>
        /// <param name="value">The new text this operation should insert after removing <c>location</c>.</param>
        abstract replace: location: U3<Position, Range, Selection> * value: string -> unit
        /// <summary>
        /// Insert text at a location.
        /// You can use \r\n or \n in <c>value</c> and they will be normalized to the current <see cref="TextDocument">document</see>.
        /// Although the equivalent text edit can be made with <see cref="TextEditorEdit.replace), `insert` will produce a different resulting selection (it will get moved">replace</see>.
        /// </summary>
        /// <param name="location">The position where the new text should be inserted.</param>
        /// <param name="value">The new text this operation should insert.</param>
        abstract insert: location: Position * value: string -> unit
        /// <summary>Delete a certain text region.</summary>
        /// <param name="location">The range this operation should remove.</param>
        abstract delete: location: U2<Range, Selection> -> unit
        /// <summary>Set the end of line sequence.</summary>
        /// <param name="endOfLine">The new end of line for the <see cref="TextDocument">document</see>.</param>
        abstract setEndOfLine: endOfLine: EndOfLine -> unit

    /// A universal resource identifier representing either a file on disk
    /// or another resource, like untitled resources.
    type [<AllowNullLiteral>] Uri =
        /// <summary>
        /// Scheme is the <c>http</c> part of <c>http://www.msft.com/some/path?query#fragment</c>.
        /// The part before the first colon.
        /// </summary>
        abstract scheme: string
        /// <summary>
        /// Authority is the <c>www.msft.com</c> part of <c>http://www.msft.com/some/path?query#fragment</c>.
        /// The part between the first double slashes and the next slash.
        /// </summary>
        abstract authority: string
        /// <summary>Path is the <c>/some/path</c> part of <c>http://www.msft.com/some/path?query#fragment</c>.</summary>
        abstract path: string
        /// <summary>Query is the <c>query</c> part of <c>http://www.msft.com/some/path?query#fragment</c>.</summary>
        abstract query: string
        /// <summary>Fragment is the <c>fragment</c> part of <c>http://www.msft.com/some/path?query#fragment</c>.</summary>
        abstract fragment: string
        /// <summary>
        /// The string representing the corresponding file system path of this Uri.
        /// 
        /// Will handle UNC paths and normalize windows drive letters to lower-case. Also
        /// uses the platform specific path separator.
        /// 
        /// * Will *not* validate the path for invalid characters and semantics.
        /// * Will *not* look at the scheme of this Uri.
        /// * The resulting string shall *not* be used for display purposes but
        /// for disk operations, like <c>readFile</c> et al.
        /// 
        /// The *difference* to the <see cref="Uri.path"><c>path</c></see>-property is the use of the platform specific
        /// path separator and the handling of UNC paths. The sample below outlines the difference:
        /// <code language="ts">
        /// const u = URI.parse('file://server/c$/folder/file.txt')
        /// u.authority === 'server'
        /// u.path === '/shares/c$/file.txt'
        /// u.fsPath === '\\server\c$\folder\file.txt'
        /// </code>
        /// </summary>
        abstract fsPath: string
        /// <summary>
        /// Derive a new Uri from this Uri.
        /// 
        /// <code language="ts">
        /// let file = Uri.parse('before:some/file/path');
        /// let other = file.with({ scheme: 'after' });
        /// assert.ok(other.toString() === 'after:some/file/path');
        /// </code>
        /// </summary>
        /// <param name="change">
        /// An object that describes a change to this Uri. To unset components use <c>null</c> or
        /// the empty string.
        /// </param>
        /// <returns>
        /// A new Uri that reflects the given change. Will return <c>this</c> Uri if the change
        /// is not changing anything.
        /// </returns>
        abstract ``with``: change: UriWithChange -> Uri
        /// <summary>
        /// Returns a string representation of this Uri. The representation and normalization
        /// of a URI depends on the scheme.
        /// 
        /// * The resulting string can be safely used with <see cref="Uri.parse">Uri.parse</see>.
        /// * The resulting string shall *not* be used for display purposes.
        /// 
        /// *Note* that the implementation will encode _aggressive_ which often leads to unexpected,
        /// but not incorrect, results. For instance, colons are encoded to <c>%3A</c> which might be unexpected
        /// in file-uri. Also <c>&</c> and <c>=</c> will be encoded which might be unexpected for http-uris. For stability
        /// reasons this cannot be changed anymore. If you suffer from too aggressive encoding you should use
        /// the <c>skipEncoding</c>-argument: <c>uri.toString(true)</c>.
        /// </summary>
        /// <param name="skipEncoding">
        /// Do not percentage-encode the result, defaults to <c>false</c>. Note that
        /// the <c>#</c> and <c>?</c> characters occurring in the path will always be encoded.
        /// </param>
        /// <returns>A string representation of this Uri.</returns>
        abstract toString: ?skipEncoding: bool -> string
        /// <summary>Returns a JSON representation of this Uri.</summary>
        /// <returns>An object.</returns>
        abstract toJSON: unit -> obj option

    type [<AllowNullLiteral>] UriWithChange =
        abstract scheme: string option with get, set
        abstract authority: string option with get, set
        abstract path: string option with get, set
        abstract query: string option with get, set
        abstract fragment: string option with get, set

    /// A universal resource identifier representing either a file on disk
    /// or another resource, like untitled resources.
    type [<AllowNullLiteral>] UriStatic =
        /// <summary>
        /// Create an URI from a string, e.g. <c>http://www.msft.com/some/path</c>,
        /// <c>file:///usr/home</c>, or <c>scheme:with/path</c>.
        /// </summary>
        /// <seealso cref="Uri.toString">Uri.toString</seealso>
        /// <param name="value">The string value of an Uri.</param>
        /// <returns>A new Uri instance.</returns>
        abstract parse: value: string -> Uri
        /// <summary>
        /// Create an URI from a file system path. The <see cref="Uri.scheme">scheme</see>
        /// will be <c>file</c>.
        /// 
        /// The *difference* between <c>Uri#parse</c> and <c>Uri#file</c> is that the latter treats the argument
        /// as path, not as stringified-uri. E.g. <c>Uri.file(path)</c> is *not* the same as
        /// <c>Uri.parse('file://' + path)</c> because the path might contain characters that are
        /// interpreted (# and ?). See the following sample:
        /// <code language="ts">
        /// const good = URI.file('/coding/c#/project1');
        /// good.scheme === 'file';
        /// good.path === '/coding/c#/project1';
        /// good.fragment === '';
        /// 
        /// const bad = URI.parse('file://' + '/coding/c#/project1');
        /// bad.scheme === 'file';
        /// bad.path === '/coding/c'; // path is now broken
        /// bad.fragment === '/project1';
        /// </code>
        /// </summary>
        /// <param name="path">A file system or UNC path.</param>
        /// <returns>A new Uri instance.</returns>
        abstract file: path: string -> Uri

    /// <summary>
    /// A cancellation token is passed to an asynchronous or long running
    /// operation to request cancellation, like cancelling a request
    /// for completion items because the user continued to type.
    /// 
    /// To get an instance of a <c>CancellationToken</c> use a
    /// <see cref="CancellationTokenSource">CancellationTokenSource</see>.
    /// </summary>
    type [<AllowNullLiteral>] CancellationToken =
        /// <summary>Is <c>true</c> when the token has been cancelled, <c>false</c> otherwise.</summary>
        abstract isCancellationRequested: bool with get, set
        /// <summary>An <see cref="Event">event</see> which fires upon cancellation.</summary>
        abstract onCancellationRequested: Event<obj option> with get, set

    /// <summary>A cancellation source creates and controls a <see cref="CancellationToken">cancellation token</see>.</summary>
    type [<AllowNullLiteral>] CancellationTokenSource =
        /// The cancellation token of this source.
        abstract token: CancellationToken with get, set
        /// Signal cancellation on the token.
        abstract cancel: unit -> unit
        /// Dispose object and free resources.
        abstract dispose: unit -> unit

    /// <summary>A cancellation source creates and controls a <see cref="CancellationToken">cancellation token</see>.</summary>
    type [<AllowNullLiteral>] CancellationTokenSourceStatic =
        [<EmitConstructor>] abstract Create: unit -> CancellationTokenSource

    /// Represents a type which can release resources, such
    /// as event listening or a timer.
    type [<AllowNullLiteral>] Disposable =
        /// Dispose this object.
        abstract dispose: unit -> obj option

    /// Represents a type which can release resources, such
    /// as event listening or a timer.
    type [<AllowNullLiteral>] DisposableStatic =
        /// <summary>
        /// Combine many disposable-likes into one. Use this method
        /// when having objects with a dispose function which are not
        /// instances of Disposable.
        /// </summary>
        /// <param name="disposableLikes">Objects that have at least a <c>dispose</c>-function member.</param>
        /// <returns>
        /// Returns a new disposable which, upon dispose, will
        /// dispose all provided disposables.
        /// </returns>
        abstract from: [<ParamArray>] disposableLikes: {| dispose: (unit -> obj option) |}[] -> Disposable
        /// <summary>
        /// Creates a new Disposable calling the provided function
        /// on dispose.
        /// </summary>
        /// <param name="callOnDispose">Function that disposes something.</param>
        [<EmitConstructor>] abstract Create: callOnDispose: Function -> Disposable

    /// <summary>
    /// Represents a typed event.
    /// 
    /// A function that represents an event to which you subscribe by calling it with
    /// a listener function as argument.
    /// </summary>
    type [<AllowNullLiteral>] Event<'T> =
        /// <summary>
        /// A function that represents an event to which you subscribe by calling it with
        /// a listener function as argument.
        /// </summary>
        /// <param name="listener">The listener function will be called when the event happens.</param>
        /// <param name="thisArgs">The <c>this</c>-argument which will be used when calling the event listener.</param>
        /// <param name="disposables">An array to which a <see cref="Disposable">disposable</see> will be added.</param>
        /// <returns>A disposable which unsubscribes the event listener.</returns>
        [<Emit "$0($1...)">] abstract Invoke: listener: ('T -> obj option) * ?thisArgs: obj * ?disposables: ResizeArray<Disposable> -> Disposable

    /// <summary>
    /// An event emitter can be used to create and manage an <see cref="Event">event</see> for others
    /// to subscribe to. One emitter always owns one event.
    /// 
    /// Use this class if you want to provide event from within your extension, for instance
    /// inside a <see cref="TextDocumentContentProvider">TextDocumentContentProvider</see> or when providing
    /// API to other extensions.
    /// </summary>
    type [<AllowNullLiteral>] EventEmitter<'T> =
        /// The event listeners can subscribe to.
        abstract ``event``: Event<'T> with get, set
        /// <summary>
        /// Notify all subscribers of the <see cref="EventEmitter.event">event</see>. Failure
        /// of one or more listener will not fail this function call.
        /// </summary>
        /// <param name="data">The event object.</param>
        abstract fire: ?data: 'T -> unit
        /// Dispose this object and free resources.
        abstract dispose: unit -> unit

    /// <summary>
    /// An event emitter can be used to create and manage an <see cref="Event">event</see> for others
    /// to subscribe to. One emitter always owns one event.
    /// 
    /// Use this class if you want to provide event from within your extension, for instance
    /// inside a <see cref="TextDocumentContentProvider">TextDocumentContentProvider</see> or when providing
    /// API to other extensions.
    /// </summary>
    type [<AllowNullLiteral>] EventEmitterStatic =
        [<EmitConstructor>] abstract Create: unit -> EventEmitter<'T>

    /// <summary>
    /// A file system watcher notifies about changes to files and folders
    /// on disk.
    /// 
    /// To get an instance of a <c>FileSystemWatcher</c> use
    /// <see cref="workspace.createFileSystemWatcher">createFileSystemWatcher</see>.
    /// </summary>
    type [<AllowNullLiteral>] FileSystemWatcher =
        inherit Disposable
        /// true if this file system watcher has been created such that
        /// it ignores creation file system events.
        abstract ignoreCreateEvents: bool with get, set
        /// true if this file system watcher has been created such that
        /// it ignores change file system events.
        abstract ignoreChangeEvents: bool with get, set
        /// true if this file system watcher has been created such that
        /// it ignores delete file system events.
        abstract ignoreDeleteEvents: bool with get, set
        /// An event which fires on file/folder creation.
        abstract onDidCreate: Event<Uri> with get, set
        /// An event which fires on file/folder change.
        abstract onDidChange: Event<Uri> with get, set
        /// An event which fires on file/folder deletion.
        abstract onDidDelete: Event<Uri> with get, set

    /// <summary>
    /// A text document content provider allows to add readonly documents
    /// to the editor, such as source from a dll or generated html from md.
    /// 
    /// Content providers are <see cref="workspace.registerTextDocumentContentProvider">registered</see>
    /// for a <see cref="Uri.scheme">uri-scheme</see>. When a uri with that scheme is to
    /// be <see cref="workspace.openTextDocument">loaded</see> the content provider is
    /// asked.
    /// </summary>
    type [<AllowNullLiteral>] TextDocumentContentProvider =
        /// An event to signal a resource has changed.
        abstract onDidChange: Event<Uri> option with get, set
        /// <summary>
        /// Provide textual content for a given uri.
        /// 
        /// The editor will use the returned string-content to create a readonly
        /// <see cref="TextDocument">document</see>. Resources allocated should be released when
        /// the corresponding document has been <see cref="workspace.onDidCloseTextDocument">closed</see>.
        /// 
        /// **Note**: The contents of the created <see cref="TextDocument">document</see> might not be
        /// identical to the provided text due to end-of-line-sequence normalization.
        /// </summary>
        /// <param name="uri">An uri which scheme matches the scheme this provider was <see cref="workspace.registerTextDocumentContentProvider">registered</see> for.</param>
        /// <param name="token">A cancellation token.</param>
        /// <returns>A string or a thenable that resolves to such.</returns>
        abstract provideTextDocumentContent: uri: Uri * token: CancellationToken -> ProviderResult<string>

    /// Represents an item that can be selected from
    /// a list of items.
    type [<AllowNullLiteral>] QuickPickItem =
        /// A human readable string which is rendered prominent.
        abstract label: string with get, set
        /// A human readable string which is rendered less prominent.
        abstract description: string option with get, set
        /// A human readable string which is rendered less prominent.
        abstract detail: string option with get, set
        /// <summary>
        /// Optional flag indicating if this item is picked initially.
        /// (Only honored when the picker allows multiple selections.)
        /// </summary>
        /// <seealso cref="QuickPickOptions.canPickMany">QuickPickOptions.canPickMany</seealso>
        abstract picked: bool option with get, set
        /// Always show this item.
        abstract alwaysShow: bool option with get, set

    /// Options to configure the behavior of the quick pick UI.
    type [<AllowNullLiteral>] QuickPickOptions =
        /// An optional flag to include the description when filtering the picks.
        abstract matchOnDescription: bool option with get, set
        /// An optional flag to include the detail when filtering the picks.
        abstract matchOnDetail: bool option with get, set
        /// An optional string to show as place holder in the input box to guide the user what to pick on.
        abstract placeHolder: string option with get, set
        /// <summary>Set to <c>true</c> to keep the picker open when focus moves to another part of the editor or to another window.</summary>
        abstract ignoreFocusOut: bool option with get, set
        /// An optional flag to make the picker accept multiple selections, if true the result is an array of picks.
        abstract canPickMany: bool option with get, set
        /// An optional function that is invoked whenever an item is selected.
        abstract onDidSelectItem: item: U2<QuickPickItem, string> -> obj option

    /// <summary>Options to configure the behaviour of the <see cref="WorkspaceFolder">workspace folder</see> pick UI.</summary>
    type [<AllowNullLiteral>] WorkspaceFolderPickOptions =
        /// An optional string to show as place holder in the input box to guide the user what to pick on.
        abstract placeHolder: string option with get, set
        /// <summary>Set to <c>true</c> to keep the picker open when focus moves to another part of the editor or to another window.</summary>
        abstract ignoreFocusOut: bool option with get, set

    /// <summary>
    /// Options to configure the behaviour of a file open dialog.
    /// 
    /// * Note 1: A dialog can select files, folders, or both. This is not true for Windows
    /// which enforces to open either files or folder, but *not both*.
    /// * Note 2: Explicitly setting <c>canSelectFiles</c> and <c>canSelectFolders</c> to <c>false</c> is futile
    /// and the editor then silently adjusts the options to select files.
    /// </summary>
    type [<AllowNullLiteral>] OpenDialogOptions =
        /// The resource the dialog shows when opened.
        abstract defaultUri: Uri option with get, set
        /// A human-readable string for the open button.
        abstract openLabel: string option with get, set
        /// <summary>Allow to select files, defaults to <c>true</c>.</summary>
        abstract canSelectFiles: bool option with get, set
        /// <summary>Allow to select folders, defaults to <c>false</c>.</summary>
        abstract canSelectFolders: bool option with get, set
        /// Allow to select many files or folders.
        abstract canSelectMany: bool option with get, set
        /// A set of file filters that are used by the dialog. Each entry is a human readable label,
        /// like "TypeScript", and an array of extensions, e.g.
        /// <code language="ts">
        /// {
        ///  	'Images': ['png', 'jpg']
        ///  	'TypeScript': ['ts', 'tsx']
        /// }
        /// </code>
        abstract filters: {| Item: ResizeArray<string> |} option with get, set

    /// Options to configure the behaviour of a file save dialog.
    type [<AllowNullLiteral>] SaveDialogOptions =
        /// The resource the dialog shows when opened.
        abstract defaultUri: Uri option with get, set
        /// A human-readable string for the save button.
        abstract saveLabel: string option with get, set
        /// A set of file filters that are used by the dialog. Each entry is a human readable label,
        /// like "TypeScript", and an array of extensions, e.g.
        /// <code language="ts">
        /// {
        ///  	'Images': ['png', 'jpg']
        ///  	'TypeScript': ['ts', 'tsx']
        /// }
        /// </code>
        abstract filters: {| Item: ResizeArray<string> |} option with get, set

    /// <summary>
    /// Represents an action that is shown with an information, warning, or
    /// error message.
    /// </summary>
    /// <seealso cref="window.showInformationMessage">showInformationMessage</seealso>
    /// <seealso cref="window.showWarningMessage">showWarningMessage</seealso>
    /// <seealso cref="window.showErrorMessage">showErrorMessage</seealso>
    type [<AllowNullLiteral>] MessageItem =
        /// A short title like 'Retry', 'Open Log' etc.
        abstract title: string with get, set
        /// A hint for modal dialogs that the item should be triggered
        /// when the user cancels the dialog (e.g. by pressing the ESC
        /// key).
        /// 
        /// Note: this option is ignored for non-modal messages.
        abstract isCloseAffordance: bool option with get, set

    /// <summary>Options to configure the behavior of the message.</summary>
    /// <seealso cref="window.showInformationMessage">showInformationMessage</seealso>
    /// <seealso cref="window.showWarningMessage">showWarningMessage</seealso>
    /// <seealso cref="window.showErrorMessage">showErrorMessage</seealso>
    type [<AllowNullLiteral>] MessageOptions =
        /// Indicates that this message should be modal.
        abstract modal: bool option with get, set

    /// Options to configure the behavior of the input box UI.
    type [<AllowNullLiteral>] InputBoxOptions =
        /// The value to prefill in the input box.
        abstract value: string option with get, set
        /// <summary>
        /// Selection of the prefilled <see cref="InputBoxOptions.value"><c>value</c></see>. Defined as tuple of two number where the
        /// first is the inclusive start index and the second the exclusive end index. When <c>undefined</c> the whole
        /// word will be selected, when empty (start equals end) only the cursor will be set,
        /// otherwise the defined range will be selected.
        /// </summary>
        abstract valueSelection: (float * float) option with get, set
        /// The text to display underneath the input box.
        abstract prompt: string option with get, set
        /// An optional string to show as place holder in the input box to guide the user what to type.
        abstract placeHolder: string option with get, set
        /// <summary>Set to <c>true</c> to show a password prompt that will not show the typed value.</summary>
        abstract password: bool option with get, set
        /// <summary>Set to <c>true</c> to keep the input box open when focus moves to another part of the editor or to another window.</summary>
        abstract ignoreFocusOut: bool option with get, set
        /// <summary>
        /// An optional function that will be called to validate input and to give a hint
        /// to the user.
        /// </summary>
        /// <param name="value">The current value of the input box.</param>
        /// <returns>
        /// A human readable string which is presented as diagnostic message.
        /// Return <c>undefined</c>, <c>null</c>, or the empty string when 'value' is valid.
        /// </returns>
        abstract validateInput: value: string -> U2<string, Thenable<string option>> option

    /// <summary>
    /// A relative pattern is a helper to construct glob patterns that are matched
    /// relatively to a base path. The base path can either be an absolute file path
    /// or a <see cref="WorkspaceFolder">workspace folder</see>.
    /// </summary>
    type [<AllowNullLiteral>] RelativePattern =
        /// A base file path to which this pattern will be matched against relatively.
        abstract ``base``: string with get, set
        /// <summary>
        /// A file glob pattern like <c>*.{ts,js}</c> that will be matched on file paths
        /// relative to the base path.
        /// 
        /// Example: Given a base of <c>/home/work/folder</c> and a file path of <c>/home/work/folder/index.js</c>,
        /// the file glob pattern will match on <c>index.js</c>.
        /// </summary>
        abstract pattern: string with get, set

    /// <summary>
    /// A relative pattern is a helper to construct glob patterns that are matched
    /// relatively to a base path. The base path can either be an absolute file path
    /// or a <see cref="WorkspaceFolder">workspace folder</see>.
    /// </summary>
    type [<AllowNullLiteral>] RelativePatternStatic =
        /// <summary>
        /// Creates a new relative pattern object with a base path and pattern to match. This pattern
        /// will be matched on file paths relative to the base path.
        /// </summary>
        /// <param name="base">A base file path to which this pattern will be matched against relatively.</param>
        /// <param name="pattern">
        /// A file glob pattern like <c>*.{ts,js}</c> that will be matched on file paths
        /// relative to the base path.
        /// </param>
        [<EmitConstructor>] abstract Create: ``base``: U2<WorkspaceFolder, string> * pattern: string -> RelativePattern

    /// <summary>
    /// A file glob pattern to match file paths against. This can either be a glob pattern string
    /// (like <c>**​/*.{ts,js}</c> or <c>*.{ts,js}</c>) or a <see cref="RelativePattern">relative pattern</see>.
    /// 
    /// Glob patterns can have the following syntax:
    /// * <c>*</c> to match one or more characters in a path segment
    /// * <c>?</c> to match on one character in a path segment
    /// * <c>**</c> to match any number of path segments, including none
    /// * <c>{}</c> to group conditions (e.g. <c>**​/*.{ts,js}</c> matches all TypeScript and JavaScript files)
    /// * <c>[]</c> to declare a range of characters to match in a path segment (e.g., <c>example.[0-9]</c> to match on <c>example.0</c>, <c>example.1</c>, …)
    /// * <c>[!...]</c> to negate a range of characters to match in a path segment (e.g., <c>example.[!0-9]</c> to match on <c>example.a</c>, <c>example.b</c>, but not <c>example.0</c>)
    /// 
    /// Note: a backslash (<c>\</c>) is not valid within a glob pattern. If you have an existing file
    /// path to match against, consider to use the <see cref="RelativePattern">relative pattern</see> support
    /// that takes care of converting any backslash into slash. Otherwise, make sure to convert
    /// any backslash to slash when creating the glob pattern.
    /// </summary>
    type GlobPattern =
        U2<string, RelativePattern>

    /// <summary>
    /// A document filter denotes a document by different properties like
    /// the <see cref="TextDocument.languageId">language</see>, the <see cref="Uri.scheme">scheme</see> of
    /// its resource, or a glob-pattern that is applied to the <see cref="TextDocument.fileName">path</see>.
    /// </summary>
    type [<AllowNullLiteral>] DocumentFilter =
        /// <summary>A language id, like <c>typescript</c>.</summary>
        abstract language: string option with get, set
        /// <summary>A Uri <see cref="Uri.scheme">scheme</see>, like <c>file</c> or <c>untitled</c>.</summary>
        abstract scheme: string option with get, set
        /// <summary>
        /// A <see cref="GlobPattern">glob pattern</see> that is matched on the absolute path of the document. Use a <see cref="RelativePattern">relative pattern</see>
        /// to filter documents to a <see cref="WorkspaceFolder">workspace folder</see>.
        /// </summary>
        abstract pattern: GlobPattern option with get, set

    /// <summary>
    /// A language selector is the combination of one or many language identifiers
    /// and <see cref="DocumentFilter">language filters</see>.
    /// 
    /// *Note* that a document selector that is just a language identifier selects *all*
    /// documents, even those that are not saved on disk. Only use such selectors when
    /// a feature works without further context, e.g without the need to resolve related
    /// 'files'.
    /// </summary>
    type DocumentSelector =
        U3<DocumentFilter, string, Array<U2<DocumentFilter, string>>>

    /// <summary>
    /// A provider result represents the values a provider, like the <see cref="HoverProvider"><c>HoverProvider</c></see>,
    /// may return. For once this is the actual result type <c>T</c>, like <c>Hover</c>, or a thenable that resolves
    /// to that type <c>T</c>. In addition, <c>null</c> and <c>undefined</c> can be returned - either directly or from a
    /// thenable.
    /// 
    /// The snippets below are all valid implementations of the <see cref="HoverProvider"><c>HoverProvider</c></see>:
    /// 
    /// <code language="ts">
    /// let a: HoverProvider = {
    ///  	provideHover(doc, pos, token): ProviderResult<Hover> {
    ///  		return new Hover('Hello World');
    ///  	}
    /// }
    /// 
    /// let b: HoverProvider = {
    ///  	provideHover(doc, pos, token): ProviderResult<Hover> {
    ///  		return new Promise(resolve => {
    ///  			resolve(new Hover('Hello World'));
    ///  	 	});
    ///  	}
    /// }
    /// 
    /// let c: HoverProvider = {
    ///  	provideHover(doc, pos, token): ProviderResult<Hover> {
    ///  		return; // undefined
    ///  	}
    /// }
    /// </code>
    /// </summary>
    type ProviderResult<'T> =
        U2<'T, Thenable<'T option>> option

    /// <summary>
    /// Kind of a code action.
    /// 
    /// Kinds are a hierarchical list of identifiers separated by <c>.</c>, e.g. <c>"refactor.extract.function"</c>.
    /// 
    /// Code action kinds are used by VS Code for UI elements such as the refactoring context menu. Users
    /// can also trigger code actions with a specific kind with the <c>editor.action.codeAction</c> command.
    /// </summary>
    type [<AllowNullLiteral>] CodeActionKind =
        /// <summary>String value of the kind, e.g. <c>"refactor.extract.function"</c>.</summary>
        abstract value: string
        /// Create a new kind by appending a more specific selector to the current kind.
        /// 
        /// Does not modify the current kind.
        abstract append: parts: string -> CodeActionKind
        /// <summary>
        /// Checks if this code action kind intersects <c>other</c>.
        /// 
        /// The kind <c>"refactor.extract"</c> for example intersects <c>refactor</c>, <c>"refactor.extract"</c> and <c></c>"refactor.extract.function"`,
        /// but not <c>"unicorn.refactor.extract"</c>, or <c>"refactor.extractAll"</c>.
        /// </summary>
        /// <param name="other">Kind to check.</param>
        abstract intersects: other: CodeActionKind -> bool
        /// <summary>
        /// Checks if <c>other</c> is a sub-kind of this <c>CodeActionKind</c>.
        /// 
        /// The kind <c>"refactor.extract"</c> for example contains <c>"refactor.extract"</c> and <c></c>"refactor.extract.function"`,
        /// but not <c>"unicorn.refactor.extract"</c>, or <c>"refactor.extractAll"</c> or <c>refactor</c>.
        /// </summary>
        /// <param name="other">Kind to check.</param>
        abstract contains: other: CodeActionKind -> bool

    /// <summary>
    /// Kind of a code action.
    /// 
    /// Kinds are a hierarchical list of identifiers separated by <c>.</c>, e.g. <c>"refactor.extract.function"</c>.
    /// 
    /// Code action kinds are used by VS Code for UI elements such as the refactoring context menu. Users
    /// can also trigger code actions with a specific kind with the <c>editor.action.codeAction</c> command.
    /// </summary>
    type [<AllowNullLiteral>] CodeActionKindStatic =
        /// Empty kind.
        abstract Empty: CodeActionKind
        /// <summary>
        /// Base kind for quickfix actions: <c>quickfix</c>.
        /// 
        /// Quick fix actions address a problem in the code and are shown in the normal code action context menu.
        /// </summary>
        abstract QuickFix: CodeActionKind
        /// <summary>
        /// Base kind for refactoring actions: <c>refactor</c>
        /// 
        /// Refactoring actions are shown in the refactoring context menu.
        /// </summary>
        abstract Refactor: CodeActionKind
        /// <summary>
        /// Base kind for refactoring extraction actions: <c>refactor.extract</c>
        /// 
        /// Example extract actions:
        /// 
        /// - Extract method
        /// - Extract function
        /// - Extract variable
        /// - Extract interface from class
        /// - ...
        /// </summary>
        abstract RefactorExtract: CodeActionKind
        /// <summary>
        /// Base kind for refactoring inline actions: <c>refactor.inline</c>
        /// 
        /// Example inline actions:
        /// 
        /// - Inline function
        /// - Inline variable
        /// - Inline constant
        /// - ...
        /// </summary>
        abstract RefactorInline: CodeActionKind
        /// <summary>
        /// Base kind for refactoring rewrite actions: <c>refactor.rewrite</c>
        /// 
        /// Example rewrite actions:
        /// 
        /// - Convert JavaScript function to class
        /// - Add or remove parameter
        /// - Encapsulate field
        /// - Make method static
        /// - Move method to base class
        /// - ...
        /// </summary>
        abstract RefactorRewrite: CodeActionKind
        /// <summary>
        /// Base kind for source actions: <c>source</c>
        /// 
        /// Source code actions apply to the entire file and can be run on save
        /// using <c>editor.codeActionsOnSave</c>. They also are shown in <c>source</c> context menu.
        /// </summary>
        abstract Source: CodeActionKind
        /// <summary>Base kind for an organize imports source action: <c>source.organizeImports</c>.</summary>
        abstract SourceOrganizeImports: CodeActionKind
        /// <summary>
        /// Base kind for auto-fix source actions: <c>source.fixAll</c>.
        /// 
        /// Fix all actions automatically fix errors that have a clear fix that do not require user input.
        /// They should not suppress errors or perform unsafe fixes such as generating new types or classes.
        /// </summary>
        abstract SourceFixAll: CodeActionKind

    /// <summary>
    /// Contains additional diagnostic information about the context in which
    /// a <see cref="CodeActionProvider.provideCodeActions">code action</see> is run.
    /// </summary>
    type [<AllowNullLiteral>] CodeActionContext =
        /// An array of diagnostics.
        abstract diagnostics: ResizeArray<Diagnostic>
        /// Requested kind of actions to return.
        /// 
        /// Actions not of this kind are filtered out before being shown by the lightbulb.
        abstract only: CodeActionKind option

    /// <summary>
    /// A code action represents a change that can be performed in code, e.g. to fix a problem or
    /// to refactor code.
    /// 
    /// A CodeAction must set either <see cref="CodeAction.edit"><c>edit</c></see> and/or a <see cref="CodeAction.command"><c>command</c></see>. If both are supplied, the <c>edit</c> is applied first, then the command is executed.
    /// </summary>
    type [<AllowNullLiteral>] CodeAction =
        /// A short, human-readable, title for this code action.
        abstract title: string with get, set
        /// <summary>A <see cref="WorkspaceEdit">workspace edit</see> this code action performs.</summary>
        abstract edit: WorkspaceEdit option with get, set
        /// <summary><see cref="Diagnostic">Diagnostics</see> that this code action resolves.</summary>
        abstract diagnostics: ResizeArray<Diagnostic> option with get, set
        /// <summary>A <see cref="Command">command</see> this code action executes.</summary>
        abstract command: Command option with get, set
        /// <summary>
        /// <see cref="CodeActionKind">Kind</see> of the code action.
        /// 
        /// Used to filter code actions.
        /// </summary>
        abstract kind: CodeActionKind option with get, set
        /// <summary>
        /// Marks this as a preferred action. Preferred actions are used by the <c>auto fix</c> command and can be targeted
        /// by keybindings.
        /// 
        /// A quick fix should be marked preferred if it properly addresses the underlying error.
        /// A refactoring should be marked preferred if it is the most reasonable choice of actions to take.
        /// </summary>
        abstract isPreferred: bool option with get, set

    /// <summary>
    /// A code action represents a change that can be performed in code, e.g. to fix a problem or
    /// to refactor code.
    /// 
    /// A CodeAction must set either <see cref="CodeAction.edit"><c>edit</c></see> and/or a <see cref="CodeAction.command"><c>command</c></see>. If both are supplied, the <c>edit</c> is applied first, then the command is executed.
    /// </summary>
    type [<AllowNullLiteral>] CodeActionStatic =
        /// <summary>
        /// Creates a new code action.
        /// 
        /// A code action must have at least a <see cref="CodeAction.title">title</see> and <see cref="CodeAction.edit">edits</see>
        /// and/or a <see cref="CodeAction.command">command</see>.
        /// </summary>
        /// <param name="title">The title of the code action.</param>
        /// <param name="kind">The kind of the code action.</param>
        [<EmitConstructor>] abstract Create: title: string * ?kind: CodeActionKind -> CodeAction

    /// <summary>
    /// The code action interface defines the contract between extensions and
    /// the <see href="https://code.visualstudio.com/docs/editor/editingevolved#_code-action">light bulb</see> feature.
    /// 
    /// A code action can be any command that is <see cref="commands.getCommands">known</see> to the system.
    /// </summary>
    type [<AllowNullLiteral>] CodeActionProvider =
        /// <summary>Provide commands for the given document and range.</summary>
        /// <param name="document">The document in which the command was invoked.</param>
        /// <param name="range">
        /// The selector or range for which the command was invoked. This will always be a selection if
        /// there is a currently active editor.
        /// </param>
        /// <param name="context">Context carrying additional information.</param>
        /// <param name="token">A cancellation token.</param>
        /// <returns>
        /// An array of commands, quick fixes, or refactorings or a thenable of such. The lack of a result can be
        /// signaled by returning <c>undefined</c>, <c>null</c>, or an empty array.
        /// </returns>
        abstract provideCodeActions: document: TextDocument * range: U2<Range, Selection> * context: CodeActionContext * token: CancellationToken -> ProviderResult<ResizeArray<U2<Command, CodeAction>>>

    /// <summary>Metadata about the type of code actions that a <see cref="CodeActionProvider">CodeActionProvider</see> providers</summary>
    type [<AllowNullLiteral>] CodeActionProviderMetadata =
        /// <summary>
        /// <see cref="CodeActionKind">CodeActionKinds</see> that this provider may return.
        /// 
        /// The list of kinds may be generic, such as <c>CodeActionKind.Refactor</c>, or the provider
        /// may list our every specific kind they provide, such as <c>CodeActionKind.Refactor.Extract.append('function</c>)`
        /// </summary>
        abstract providedCodeActionKinds: ReadonlyArray<CodeActionKind> option

    /// <summary>
    /// A code lens represents a <see cref="Command">command</see> that should be shown along with
    /// source text, like the number of references, a way to run tests, etc.
    /// 
    /// A code lens is _unresolved_ when no command is associated to it. For performance
    /// reasons the creation of a code lens and resolving should be done to two stages.
    /// </summary>
    /// <seealso cref="CodeLensProvider.provideCodeLenses">CodeLensProvider.provideCodeLenses</seealso>
    /// <seealso cref="CodeLensProvider.resolveCodeLens">CodeLensProvider.resolveCodeLens</seealso>
    type [<AllowNullLiteral>] CodeLens =
        /// The range in which this code lens is valid. Should only span a single line.
        abstract range: Range with get, set
        /// The command this code lens represents.
        abstract command: Command option with get, set
        /// <summary><c>true</c> when there is a command associated.</summary>
        abstract isResolved: bool

    /// <summary>
    /// A code lens represents a <see cref="Command">command</see> that should be shown along with
    /// source text, like the number of references, a way to run tests, etc.
    /// 
    /// A code lens is _unresolved_ when no command is associated to it. For performance
    /// reasons the creation of a code lens and resolving should be done to two stages.
    /// </summary>
    /// <seealso cref="CodeLensProvider.provideCodeLenses">CodeLensProvider.provideCodeLenses</seealso>
    /// <seealso cref="CodeLensProvider.resolveCodeLens">CodeLensProvider.resolveCodeLens</seealso>
    type [<AllowNullLiteral>] CodeLensStatic =
        /// <summary>Creates a new code lens object.</summary>
        /// <param name="range">The range to which this code lens applies.</param>
        /// <param name="command">The command associated to this code lens.</param>
        [<EmitConstructor>] abstract Create: range: Range * ?command: Command -> CodeLens

    /// <summary>
    /// A code lens provider adds <see cref="Command">commands</see> to source text. The commands will be shown
    /// as dedicated horizontal lines in between the source text.
    /// </summary>
    type [<AllowNullLiteral>] CodeLensProvider =
        /// An optional event to signal that the code lenses from this provider have changed.
        abstract onDidChangeCodeLenses: Event<unit> option with get, set
        /// <summary>
        /// Compute a list of <see cref="CodeLens">lenses</see>. This call should return as fast as possible and if
        /// computing the commands is expensive implementors should only return code lens objects with the
        /// range set and implement <see cref="CodeLensProvider.resolveCodeLens">resolve</see>.
        /// </summary>
        /// <param name="document">The document in which the command was invoked.</param>
        /// <param name="token">A cancellation token.</param>
        /// <returns>
        /// An array of code lenses or a thenable that resolves to such. The lack of a result can be
        /// signaled by returning <c>undefined</c>, <c>null</c>, or an empty array.
        /// </returns>
        abstract provideCodeLenses: document: TextDocument * token: CancellationToken -> ProviderResult<ResizeArray<CodeLens>>
        /// <summary>
        /// This function will be called for each visible code lens, usually when scrolling and after
        /// calls to <see cref="CodeLensProvider.provideCodeLenses">compute</see>-lenses.
        /// </summary>
        /// <param name="codeLens">code lens that must be resolved.</param>
        /// <param name="token">A cancellation token.</param>
        /// <returns>The given, resolved code lens or thenable that resolves to such.</returns>
        abstract resolveCodeLens: codeLens: CodeLens * token: CancellationToken -> ProviderResult<CodeLens>

    /// <summary>
    /// Information about where a symbol is defined.
    /// 
    /// Provides additional metadata over normal <see cref="Location">location</see> definitions, including the range of
    /// the defining symbol
    /// </summary>
    type DefinitionLink =
        LocationLink

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
        /// <summary>Provide the definition of the symbol at the given position and document.</summary>
        /// <param name="document">The document in which the command was invoked.</param>
        /// <param name="position">The position at which the command was invoked.</param>
        /// <param name="token">A cancellation token.</param>
        /// <returns>
        /// A definition or a thenable that resolves to such. The lack of a result can be
        /// signaled by returning <c>undefined</c> or <c>null</c>.
        /// </returns>
        abstract provideDefinition: document: TextDocument * position: Position * token: CancellationToken -> ProviderResult<U2<Definition, ResizeArray<DefinitionLink>>>

    /// The implementation provider interface defines the contract between extensions and
    /// the go to implementation feature.
    type [<AllowNullLiteral>] ImplementationProvider =
        /// <summary>Provide the implementations of the symbol at the given position and document.</summary>
        /// <param name="document">The document in which the command was invoked.</param>
        /// <param name="position">The position at which the command was invoked.</param>
        /// <param name="token">A cancellation token.</param>
        /// <returns>
        /// A definition or a thenable that resolves to such. The lack of a result can be
        /// signaled by returning <c>undefined</c> or <c>null</c>.
        /// </returns>
        abstract provideImplementation: document: TextDocument * position: Position * token: CancellationToken -> ProviderResult<U2<Definition, ResizeArray<DefinitionLink>>>

    /// The type definition provider defines the contract between extensions and
    /// the go to type definition feature.
    type [<AllowNullLiteral>] TypeDefinitionProvider =
        /// <summary>Provide the type definition of the symbol at the given position and document.</summary>
        /// <param name="document">The document in which the command was invoked.</param>
        /// <param name="position">The position at which the command was invoked.</param>
        /// <param name="token">A cancellation token.</param>
        /// <returns>
        /// A definition or a thenable that resolves to such. The lack of a result can be
        /// signaled by returning <c>undefined</c> or <c>null</c>.
        /// </returns>
        abstract provideTypeDefinition: document: TextDocument * position: Position * token: CancellationToken -> ProviderResult<U2<Definition, ResizeArray<DefinitionLink>>>

    /// <summary>
    /// The declaration of a symbol representation as one or many <see cref="Location">locations</see>
    /// or [location links][#LocationLink].
    /// </summary>
    type Declaration =
        U3<Location, ResizeArray<Location>, ResizeArray<LocationLink>>

    /// The declaration provider interface defines the contract between extensions and
    /// the go to declaration feature.
    type [<AllowNullLiteral>] DeclarationProvider =
        /// <summary>Provide the declaration of the symbol at the given position and document.</summary>
        /// <param name="document">The document in which the command was invoked.</param>
        /// <param name="position">The position at which the command was invoked.</param>
        /// <param name="token">A cancellation token.</param>
        /// <returns>
        /// A declaration or a thenable that resolves to such. The lack of a result can be
        /// signaled by returning <c>undefined</c> or <c>null</c>.
        /// </returns>
        abstract provideDeclaration: document: TextDocument * position: Position * token: CancellationToken -> ProviderResult<Declaration>

    /// The MarkdownString represents human readable text that supports formatting via the
    /// markdown syntax. Standard markdown is supported, also tables, but no embedded html.
    type [<AllowNullLiteral>] MarkdownString =
        /// The markdown string.
        abstract value: string with get, set
        /// <summary>
        /// Indicates that this markdown string is from a trusted source. Only *trusted*
        /// markdown supports links that execute commands, e.g. <c>[Run it](command:myCommandId)</c>.
        /// </summary>
        abstract isTrusted: bool option with get, set
        /// <summary>Appends and escapes the given string to this markdown string.</summary>
        /// <param name="value">Plain text.</param>
        abstract appendText: value: string -> MarkdownString
        /// <summary>Appends the given string 'as is' to this markdown string.</summary>
        /// <param name="value">Markdown string.</param>
        abstract appendMarkdown: value: string -> MarkdownString
        /// <summary>Appends the given string as codeblock using the provided language.</summary>
        /// <param name="value">A code snippet.</param>
        /// <param name="language">An optional <see cref="languages.getLanguages">language identifier</see>.</param>
        abstract appendCodeblock: value: string * ?language: string -> MarkdownString

    /// The MarkdownString represents human readable text that supports formatting via the
    /// markdown syntax. Standard markdown is supported, also tables, but no embedded html.
    type [<AllowNullLiteral>] MarkdownStringStatic =
        /// <summary>Creates a new markdown string with the given value.</summary>
        /// <param name="value">Optional, initial value.</param>
        [<EmitConstructor>] abstract Create: ?value: string -> MarkdownString

    /// ~~MarkedString can be used to render human readable text. It is either a markdown string
    /// or a code-block that provides a language and a code snippet. Note that
    /// markdown strings will be sanitized - that means html will be escaped.~~
    [<Obsolete("This type is deprecated, please use [`MarkdownString`](#MarkdownString) instead.")>]
    type MarkedString =
        U3<MarkdownString, string, {| language: string; value: string |}>

    /// A hover represents additional information for a symbol or word. Hovers are
    /// rendered in a tooltip-like widget.
    type [<AllowNullLiteral>] Hover =
        /// The contents of this hover.
        abstract contents: ResizeArray<MarkedString> with get, set
        /// The range to which this hover applies. When missing, the
        /// editor will use the range at the current position or the
        /// current position itself.
        abstract range: Range option with get, set

    /// A hover represents additional information for a symbol or word. Hovers are
    /// rendered in a tooltip-like widget.
    type [<AllowNullLiteral>] HoverStatic =
        /// <summary>Creates a new hover object.</summary>
        /// <param name="contents">The contents of the hover.</param>
        /// <param name="range">The range to which the hover applies.</param>
        [<EmitConstructor>] abstract Create: contents: U2<MarkedString, ResizeArray<MarkedString>> * ?range: Range -> Hover

    /// <summary>
    /// The hover provider interface defines the contract between extensions and
    /// the <see href="https://code.visualstudio.com/docs/editor/intellisense">hover</see>-feature.
    /// </summary>
    type [<AllowNullLiteral>] HoverProvider =
        /// <summary>
        /// Provide a hover for the given position and document. Multiple hovers at the same
        /// position will be merged by the editor. A hover can have a range which defaults
        /// to the word range at the position when omitted.
        /// </summary>
        /// <param name="document">The document in which the command was invoked.</param>
        /// <param name="position">The position at which the command was invoked.</param>
        /// <param name="token">A cancellation token.</param>
        /// <returns>
        /// A hover or a thenable that resolves to such. The lack of a result can be
        /// signaled by returning <c>undefined</c> or <c>null</c>.
        /// </returns>
        abstract provideHover: document: TextDocument * position: Position * token: CancellationToken -> ProviderResult<Hover>

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
        abstract range: Range with get, set
        /// <summary>The highlight kind, default is <see cref="DocumentHighlightKind.Text">text</see>.</summary>
        abstract kind: DocumentHighlightKind option with get, set

    /// A document highlight is a range inside a text document which deserves
    /// special attention. Usually a document highlight is visualized by changing
    /// the background color of its range.
    type [<AllowNullLiteral>] DocumentHighlightStatic =
        /// <summary>Creates a new document highlight object.</summary>
        /// <param name="range">The range the highlight applies to.</param>
        /// <param name="kind">The highlight kind, default is <see cref="DocumentHighlightKind.Text">text</see>.</param>
        [<EmitConstructor>] abstract Create: range: Range * ?kind: DocumentHighlightKind -> DocumentHighlight

    /// The document highlight provider interface defines the contract between extensions and
    /// the word-highlight-feature.
    type [<AllowNullLiteral>] DocumentHighlightProvider =
        /// <summary>
        /// Provide a set of document highlights, like all occurrences of a variable or
        /// all exit-points of a function.
        /// </summary>
        /// <param name="document">The document in which the command was invoked.</param>
        /// <param name="position">The position at which the command was invoked.</param>
        /// <param name="token">A cancellation token.</param>
        /// <returns>
        /// An array of document highlights or a thenable that resolves to such. The lack of a result can be
        /// signaled by returning <c>undefined</c>, <c>null</c>, or an empty array.
        /// </returns>
        abstract provideDocumentHighlights: document: TextDocument * position: Position * token: CancellationToken -> ProviderResult<ResizeArray<DocumentHighlight>>

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
        abstract containerName: string with get, set
        /// The kind of this symbol.
        abstract kind: SymbolKind with get, set
        /// The location of this symbol.
        abstract location: Location with get, set

    /// Represents information about programming constructs like variables, classes,
    /// interfaces etc.
    type [<AllowNullLiteral>] SymbolInformationStatic =
        /// <summary>Creates a new symbol information object.</summary>
        /// <param name="name">The name of the symbol.</param>
        /// <param name="kind">The kind of the symbol.</param>
        /// <param name="containerName">The name of the symbol containing the symbol.</param>
        /// <param name="location">The location of the symbol.</param>
        [<EmitConstructor>] abstract Create: name: string * kind: SymbolKind * containerName: string * location: Location -> SymbolInformation
        /// <summary>~~Creates a new symbol information object.~~</summary>
        /// <param name="name">The name of the symbol.</param>
        /// <param name="kind">The kind of the symbol.</param>
        /// <param name="range">The range of the location of the symbol.</param>
        /// <param name="uri">The resource of the location of symbol, defaults to the current document.</param>
        /// <param name="containerName">The name of the symbol containing the symbol.</param>
        [<Obsolete("Please use the constructor taking a [location](#Location) object.")>]
        [<EmitConstructor>] abstract Create: name: string * kind: SymbolKind * range: Range * ?uri: Uri * ?containerName: string -> SymbolInformation

    /// Represents programming constructs like variables, classes, interfaces etc. that appear in a document. Document
    /// symbols can be hierarchical and they have two ranges: one that encloses its definition and one that points to
    /// its most interesting range, e.g. the range of an identifier.
    type [<AllowNullLiteral>] DocumentSymbol =
        /// The name of this symbol.
        abstract name: string with get, set
        /// More detail for this symbol, e.g the signature of a function.
        abstract detail: string with get, set
        /// The kind of this symbol.
        abstract kind: SymbolKind with get, set
        /// The range enclosing this symbol not including leading/trailing whitespace but everything else, e.g comments and code.
        abstract range: Range with get, set
        /// <summary>
        /// The range that should be selected and reveal when this symbol is being picked, e.g the name of a function.
        /// Must be contained by the <see cref="DocumentSymbol.range"><c>range</c></see>.
        /// </summary>
        abstract selectionRange: Range with get, set
        /// Children of this symbol, e.g. properties of a class.
        abstract children: ResizeArray<DocumentSymbol> with get, set

    /// Represents programming constructs like variables, classes, interfaces etc. that appear in a document. Document
    /// symbols can be hierarchical and they have two ranges: one that encloses its definition and one that points to
    /// its most interesting range, e.g. the range of an identifier.
    type [<AllowNullLiteral>] DocumentSymbolStatic =
        /// <summary>Creates a new document symbol.</summary>
        /// <param name="name">The name of the symbol.</param>
        /// <param name="detail">Details for the symbol.</param>
        /// <param name="kind">The kind of the symbol.</param>
        /// <param name="range">The full range of the symbol.</param>
        /// <param name="selectionRange">The range that should be reveal.</param>
        [<EmitConstructor>] abstract Create: name: string * detail: string * kind: SymbolKind * range: Range * selectionRange: Range -> DocumentSymbol

    /// <summary>
    /// The document symbol provider interface defines the contract between extensions and
    /// the <see href="https://code.visualstudio.com/docs/editor/editingevolved#_go-to-symbol">go to symbol</see>-feature.
    /// </summary>
    type [<AllowNullLiteral>] DocumentSymbolProvider =
        /// <summary>Provide symbol information for the given document.</summary>
        /// <param name="document">The document in which the command was invoked.</param>
        /// <param name="token">A cancellation token.</param>
        /// <returns>
        /// An array of document highlights or a thenable that resolves to such. The lack of a result can be
        /// signaled by returning <c>undefined</c>, <c>null</c>, or an empty array.
        /// </returns>
        abstract provideDocumentSymbols: document: TextDocument * token: CancellationToken -> ProviderResult<U2<ResizeArray<SymbolInformation>, ResizeArray<DocumentSymbol>>>

    /// Metadata about a document symbol provider.
    type [<AllowNullLiteral>] DocumentSymbolProviderMetadata =
        /// A human readable string that is shown when multiple outlines trees show for one document.
        abstract label: string option with get, set

    /// <summary>
    /// The workspace symbol provider interface defines the contract between extensions and
    /// the <see href="https://code.visualstudio.com/docs/editor/editingevolved#_open-symbol-by-name">symbol search</see>-feature.
    /// </summary>
    type [<AllowNullLiteral>] WorkspaceSymbolProvider =
        /// <summary>
        /// Project-wide search for a symbol matching the given query string.
        /// 
        /// The <c>query</c>-parameter should be interpreted in a *relaxed way* as the editor will apply its own highlighting
        /// and scoring on the results. A good rule of thumb is to match case-insensitive and to simply check that the
        /// characters of *query* appear in their order in a candidate symbol. Don't use prefix, substring, or similar
        /// strict matching.
        /// 
        /// To improve performance implementors can implement <c>resolveWorkspaceSymbol</c> and then provide symbols with partial
        /// <see cref="SymbolInformation.location">location</see>-objects, without a <c>range</c> defined. The editor will then call
        /// <c>resolveWorkspaceSymbol</c> for selected symbols only, e.g. when opening a workspace symbol.
        /// </summary>
        /// <param name="query">A query string, can be the empty string in which case all symbols should be returned.</param>
        /// <param name="token">A cancellation token.</param>
        /// <returns>
        /// An array of document highlights or a thenable that resolves to such. The lack of a result can be
        /// signaled by returning <c>undefined</c>, <c>null</c>, or an empty array.
        /// </returns>
        abstract provideWorkspaceSymbols: query: string * token: CancellationToken -> ProviderResult<ResizeArray<SymbolInformation>>
        /// <summary>
        /// Given a symbol fill in its <see cref="SymbolInformation.location">location</see>. This method is called whenever a symbol
        /// is selected in the UI. Providers can implement this method and return incomplete symbols from
        /// <see cref="WorkspaceSymbolProvider.provideWorkspaceSymbols"><c>provideWorkspaceSymbols</c></see> which often helps to improve
        /// performance.
        /// </summary>
        /// <param name="symbol">
        /// The symbol that is to be resolved. Guaranteed to be an instance of an object returned from an
        /// earlier call to <c>provideWorkspaceSymbols</c>.
        /// </param>
        /// <param name="token">A cancellation token.</param>
        /// <returns>
        /// The resolved symbol or a thenable that resolves to that. When no result is returned,
        /// the given <c>symbol</c> is used.
        /// </returns>
        abstract resolveWorkspaceSymbol: symbol: SymbolInformation * token: CancellationToken -> ProviderResult<SymbolInformation>

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
        /// <summary>Provide a set of project-wide references for the given position and document.</summary>
        /// <param name="document">The document in which the command was invoked.</param>
        /// <param name="position">The position at which the command was invoked.</param>
        /// <param name="token">A cancellation token.</param>
        /// <returns>
        /// An array of locations or a thenable that resolves to such. The lack of a result can be
        /// signaled by returning <c>undefined</c>, <c>null</c>, or an empty array.
        /// </returns>
        abstract provideReferences: document: TextDocument * position: Position * context: ReferenceContext * token: CancellationToken -> ProviderResult<ResizeArray<Location>>

    /// A text edit represents edits that should be applied
    /// to a document.
    type [<AllowNullLiteral>] TextEdit =
        /// The range this edit applies to.
        abstract range: Range with get, set
        /// The string this edit will insert.
        abstract newText: string with get, set
        /// The eol-sequence used in the document.
        /// 
        /// *Note* that the eol-sequence will be applied to the
        /// whole document.
        abstract newEol: EndOfLine with get, set

    /// A text edit represents edits that should be applied
    /// to a document.
    type [<AllowNullLiteral>] TextEditStatic =
        /// <summary>Utility to create a replace edit.</summary>
        /// <param name="range">A range.</param>
        /// <param name="newText">A string.</param>
        /// <returns>A new text edit object.</returns>
        abstract replace: range: Range * newText: string -> TextEdit
        /// <summary>Utility to create an insert edit.</summary>
        /// <param name="position">A position, will become an empty range.</param>
        /// <param name="newText">A string.</param>
        /// <returns>A new text edit object.</returns>
        abstract insert: position: Position * newText: string -> TextEdit
        /// <summary>Utility to create a delete edit.</summary>
        /// <param name="range">A range.</param>
        /// <returns>A new text edit object.</returns>
        abstract delete: range: Range -> TextEdit
        /// <summary>Utility to create an eol-edit.</summary>
        /// <param name="eol">An eol-sequence</param>
        /// <returns>A new text edit object.</returns>
        abstract setEndOfLine: eol: EndOfLine -> TextEdit
        /// <summary>Create a new TextEdit.</summary>
        /// <param name="range">A range.</param>
        /// <param name="newText">A string.</param>
        [<EmitConstructor>] abstract Create: range: Range * newText: string -> TextEdit

    /// <summary>
    /// A workspace edit is a collection of textual and files changes for
    /// multiple resources and documents.
    /// 
    /// Use the <see cref="workspace.applyEdit">applyEdit</see>-function to apply a workspace edit.
    /// </summary>
    type [<AllowNullLiteral>] WorkspaceEdit =
        /// The number of affected resources of textual or resource changes.
        abstract size: float
        /// <summary>Replace the given range with given text for the given resource.</summary>
        /// <param name="uri">A resource identifier.</param>
        /// <param name="range">A range.</param>
        /// <param name="newText">A string.</param>
        abstract replace: uri: Uri * range: Range * newText: string -> unit
        /// <summary>Insert the given text at the given position.</summary>
        /// <param name="uri">A resource identifier.</param>
        /// <param name="position">A position.</param>
        /// <param name="newText">A string.</param>
        abstract insert: uri: Uri * position: Position * newText: string -> unit
        /// <summary>Delete the text at the given range.</summary>
        /// <param name="uri">A resource identifier.</param>
        /// <param name="range">A range.</param>
        abstract delete: uri: Uri * range: Range -> unit
        /// <summary>Check if a text edit for a resource exists.</summary>
        /// <param name="uri">A resource identifier.</param>
        /// <returns><c>true</c> if the given resource will be touched by this edit.</returns>
        abstract has: uri: Uri -> bool
        /// <summary>Set (and replace) text edits for a resource.</summary>
        /// <param name="uri">A resource identifier.</param>
        /// <param name="edits">An array of text edits.</param>
        abstract set: uri: Uri * edits: ResizeArray<TextEdit> -> unit
        /// <summary>Get the text edits for a resource.</summary>
        /// <param name="uri">A resource identifier.</param>
        /// <returns>An array of text edits.</returns>
        abstract get: uri: Uri -> ResizeArray<TextEdit>
        /// <summary>Create a regular file.</summary>
        /// <param name="uri">Uri of the new file..</param>
        /// <param name="options">
        /// Defines if an existing file should be overwritten or be
        /// ignored. When overwrite and ignoreIfExists are both set overwrite wins.
        /// </param>
        abstract createFile: uri: Uri * ?options: {| overwrite: bool option; ignoreIfExists: bool option |} -> unit
        /// <summary>Delete a file or folder.</summary>
        /// <param name="uri">The uri of the file that is to be deleted.</param>
        abstract deleteFile: uri: Uri * ?options: {| recursive: bool option; ignoreIfNotExists: bool option |} -> unit
        /// <summary>Rename a file or folder.</summary>
        /// <param name="oldUri">The existing file.</param>
        /// <param name="newUri">The new location.</param>
        /// <param name="options">
        /// Defines if existing files should be overwritten or be
        /// ignored. When overwrite and ignoreIfExists are both set overwrite wins.
        /// </param>
        abstract renameFile: oldUri: Uri * newUri: Uri * ?options: {| overwrite: bool option; ignoreIfExists: bool option |} -> unit
        /// <summary>Get all text edits grouped by resource.</summary>
        /// <returns>A shallow copy of <c>[Uri, TextEdit[]]</c>-tuples.</returns>
        abstract entries: unit -> ResizeArray<Uri * ResizeArray<TextEdit>>

    /// <summary>
    /// A workspace edit is a collection of textual and files changes for
    /// multiple resources and documents.
    /// 
    /// Use the <see cref="workspace.applyEdit">applyEdit</see>-function to apply a workspace edit.
    /// </summary>
    type [<AllowNullLiteral>] WorkspaceEditStatic =
        [<EmitConstructor>] abstract Create: unit -> WorkspaceEdit

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
        /// <summary>
        /// Builder-function that appends the given string to
        /// the <see cref="SnippetString.value"><c>value</c></see> of this snippet string.
        /// </summary>
        /// <param name="string">A value to append 'as given'. The string will be escaped.</param>
        /// <returns>This snippet string.</returns>
        abstract appendText: string: string -> SnippetString
        /// <summary>
        /// Builder-function that appends a tabstop (<c>$1</c>, <c>$2</c> etc) to
        /// the <see cref="SnippetString.value"><c>value</c></see> of this snippet string.
        /// </summary>
        /// <param name="number">
        /// The number of this tabstop, defaults to an auto-increment
        /// value starting at 1.
        /// </param>
        /// <returns>This snippet string.</returns>
        abstract appendTabstop: ?number: float -> SnippetString
        /// <summary>
        /// Builder-function that appends a placeholder (<c>${1:value}</c>) to
        /// the <see cref="SnippetString.value"><c>value</c></see> of this snippet string.
        /// </summary>
        /// <param name="value">
        /// The value of this placeholder - either a string or a function
        /// with which a nested snippet can be created.
        /// </param>
        /// <param name="number">
        /// The number of this tabstop, defaults to an auto-increment
        /// value starting at 1.
        /// </param>
        /// <returns>This snippet string.</returns>
        abstract appendPlaceholder: value: U2<string, (SnippetString -> obj option)> * ?number: float -> SnippetString
        /// <summary>
        /// Builder-function that appends a variable (<c>${VAR}</c>) to
        /// the <see cref="SnippetString.value"><c>value</c></see> of this snippet string.
        /// </summary>
        /// <param name="name">The name of the variable - excluding the <c>$</c>.</param>
        /// <param name="defaultValue">
        /// The default value which is used when the variable name cannot
        /// be resolved - either a string or a function with which a nested snippet can be created.
        /// </param>
        /// <returns>This snippet string.</returns>
        abstract appendVariable: name: string * defaultValue: U2<string, (SnippetString -> obj option)> -> SnippetString

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
    type [<AllowNullLiteral>] SnippetStringStatic =
        [<EmitConstructor>] abstract Create: ?value: string -> SnippetString

    /// <summary>
    /// The rename provider interface defines the contract between extensions and
    /// the <see href="https://code.visualstudio.com/docs/editor/editingevolved#_rename-symbol">rename</see>-feature.
    /// </summary>
    type [<AllowNullLiteral>] RenameProvider =
        /// <summary>
        /// Provide an edit that describes changes that have to be made to one
        /// or many resources to rename a symbol to a different name.
        /// </summary>
        /// <param name="document">The document in which the command was invoked.</param>
        /// <param name="position">The position at which the command was invoked.</param>
        /// <param name="newName">The new name of the symbol. If the given name is not valid, the provider must return a rejected promise.</param>
        /// <param name="token">A cancellation token.</param>
        /// <returns>
        /// A workspace edit or a thenable that resolves to such. The lack of a result can be
        /// signaled by returning <c>undefined</c> or <c>null</c>.
        /// </returns>
        abstract provideRenameEdits: document: TextDocument * position: Position * newName: string * token: CancellationToken -> ProviderResult<WorkspaceEdit>
        /// <summary>
        /// Optional function for resolving and validating a position *before* running rename. The result can
        /// be a range or a range and a placeholder text. The placeholder text should be the identifier of the symbol
        /// which is being renamed - when omitted the text in the returned range is used.
        /// </summary>
        /// <param name="document">The document in which rename will be invoked.</param>
        /// <param name="position">The position at which rename will be invoked.</param>
        /// <param name="token">A cancellation token.</param>
        /// <returns>The range or range and placeholder text of the identifier that is to be renamed. The lack of a result can signaled by returning <c>undefined</c> or <c>null</c>.</returns>
        abstract prepareRename: document: TextDocument * position: Position * token: CancellationToken -> ProviderResult<U2<Range, {| range: Range; placeholder: string |}>>

    /// Value-object describing what options formatting should use.
    type [<AllowNullLiteral>] FormattingOptions =
        /// Size of a tab in spaces.
        abstract tabSize: float with get, set
        /// Prefer spaces over tabs.
        abstract insertSpaces: bool with get, set
        /// Signature for further properties.
        [<EmitIndexer>] abstract Item: key: string -> U3<bool, float, string> with get, set

    /// The document formatting provider interface defines the contract between extensions and
    /// the formatting-feature.
    type [<AllowNullLiteral>] DocumentFormattingEditProvider =
        /// <summary>Provide formatting edits for a whole document.</summary>
        /// <param name="document">The document in which the command was invoked.</param>
        /// <param name="options">Options controlling formatting.</param>
        /// <param name="token">A cancellation token.</param>
        /// <returns>
        /// A set of text edits or a thenable that resolves to such. The lack of a result can be
        /// signaled by returning <c>undefined</c>, <c>null</c>, or an empty array.
        /// </returns>
        abstract provideDocumentFormattingEdits: document: TextDocument * options: FormattingOptions * token: CancellationToken -> ProviderResult<ResizeArray<TextEdit>>

    /// The document formatting provider interface defines the contract between extensions and
    /// the formatting-feature.
    type [<AllowNullLiteral>] DocumentRangeFormattingEditProvider =
        /// <summary>
        /// Provide formatting edits for a range in a document.
        /// 
        /// The given range is a hint and providers can decide to format a smaller
        /// or larger range. Often this is done by adjusting the start and end
        /// of the range to full syntax nodes.
        /// </summary>
        /// <param name="document">The document in which the command was invoked.</param>
        /// <param name="range">The range which should be formatted.</param>
        /// <param name="options">Options controlling formatting.</param>
        /// <param name="token">A cancellation token.</param>
        /// <returns>
        /// A set of text edits or a thenable that resolves to such. The lack of a result can be
        /// signaled by returning <c>undefined</c>, <c>null</c>, or an empty array.
        /// </returns>
        abstract provideDocumentRangeFormattingEdits: document: TextDocument * range: Range * options: FormattingOptions * token: CancellationToken -> ProviderResult<ResizeArray<TextEdit>>

    /// The document formatting provider interface defines the contract between extensions and
    /// the formatting-feature.
    type [<AllowNullLiteral>] OnTypeFormattingEditProvider =
        /// <summary>
        /// Provide formatting edits after a character has been typed.
        /// 
        /// The given position and character should hint to the provider
        /// what range the position to expand to, like find the matching <c>{</c>
        /// when <c>}</c> has been entered.
        /// </summary>
        /// <param name="document">The document in which the command was invoked.</param>
        /// <param name="position">The position at which the command was invoked.</param>
        /// <param name="ch">The character that has been typed.</param>
        /// <param name="options">Options controlling formatting.</param>
        /// <param name="token">A cancellation token.</param>
        /// <returns>
        /// A set of text edits or a thenable that resolves to such. The lack of a result can be
        /// signaled by returning <c>undefined</c>, <c>null</c>, or an empty array.
        /// </returns>
        abstract provideOnTypeFormattingEdits: document: TextDocument * position: Position * ch: string * options: FormattingOptions * token: CancellationToken -> ProviderResult<ResizeArray<TextEdit>>

    /// Represents a parameter of a callable-signature. A parameter can
    /// have a label and a doc-comment.
    type [<AllowNullLiteral>] ParameterInformation =
        /// <summary>
        /// The label of this signature.
        /// 
        /// Either a string or inclusive start and exclusive end offsets within its containing
        /// <see cref="SignatureInformation.label">signature label</see>. *Note*: A label of type string must be
        /// a substring of its containing signature information's <see cref="SignatureInformation.label">label</see>.
        /// </summary>
        abstract label: U2<string, float * float> with get, set
        /// The human-readable doc-comment of this signature. Will be shown
        /// in the UI but can be omitted.
        abstract documentation: U2<string, MarkdownString> option with get, set

    /// Represents a parameter of a callable-signature. A parameter can
    /// have a label and a doc-comment.
    type [<AllowNullLiteral>] ParameterInformationStatic =
        /// <summary>Creates a new parameter information object.</summary>
        /// <param name="label">A label string or inclusive start and exclusive end offsets within its containing signature label.</param>
        /// <param name="documentation">A doc string.</param>
        [<EmitConstructor>] abstract Create: label: U2<string, float * float> * ?documentation: U2<string, MarkdownString> -> ParameterInformation

    /// Represents the signature of something callable. A signature
    /// can have a label, like a function-name, a doc-comment, and
    /// a set of parameters.
    type [<AllowNullLiteral>] SignatureInformation =
        /// The label of this signature. Will be shown in
        /// the UI.
        abstract label: string with get, set
        /// The human-readable doc-comment of this signature. Will be shown
        /// in the UI but can be omitted.
        abstract documentation: U2<string, MarkdownString> option with get, set
        /// The parameters of this signature.
        abstract parameters: ResizeArray<ParameterInformation> with get, set

    /// Represents the signature of something callable. A signature
    /// can have a label, like a function-name, a doc-comment, and
    /// a set of parameters.
    type [<AllowNullLiteral>] SignatureInformationStatic =
        /// <summary>Creates a new signature information object.</summary>
        /// <param name="label">A label string.</param>
        /// <param name="documentation">A doc string.</param>
        [<EmitConstructor>] abstract Create: label: string * ?documentation: U2<string, MarkdownString> -> SignatureInformation

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

    /// Signature help represents the signature of something
    /// callable. There can be multiple signatures but only one
    /// active and only one active parameter.
    type [<AllowNullLiteral>] SignatureHelpStatic =
        [<EmitConstructor>] abstract Create: unit -> SignatureHelp

    /// <summary>How a <see cref="SignatureHelpProvider"><c>SignatureHelpProvider</c></see> was triggered.</summary>
    type [<RequireQualifiedAccess>] SignatureHelpTriggerKind =
        /// Signature help was invoked manually by the user or by a command.
        | Invoke = 1
        /// Signature help was triggered by a trigger character.
        | TriggerCharacter = 2
        /// Signature help was triggered by the cursor moving or by the document content changing.
        | ContentChange = 3

    /// <summary>
    /// Additional information about the context in which a
    /// <see cref="SignatureHelpProvider.provideSignatureHelp"><c>SignatureHelpProvider</c></see> was triggered.
    /// </summary>
    type [<AllowNullLiteral>] SignatureHelpContext =
        /// Action that caused signature help to be triggered.
        abstract triggerKind: SignatureHelpTriggerKind
        /// <summary>
        /// Character that caused signature help to be triggered.
        /// 
        /// This is <c>undefined</c> when signature help is not triggered by typing, such as when manually invoking
        /// signature help or when moving the cursor.
        /// </summary>
        abstract triggerCharacter: string option
        /// <summary>
        /// <c>true</c> if signature help was already showing when it was triggered.
        /// 
        /// Retriggers occur when the signature help is already active and can be caused by actions such as
        /// typing a trigger character, a cursor move, or document content changes.
        /// </summary>
        abstract isRetrigger: bool
        /// <summary>
        /// The currently active <see cref="SignatureHelp"><c>SignatureHelp</c></see>.
        /// 
        /// The <c>activeSignatureHelp</c> has its [<c>SignatureHelp.activeSignature</c>] field updated based on
        /// the user arrowing through available signatures.
        /// </summary>
        abstract activeSignatureHelp: SignatureHelp option

    /// <summary>
    /// The signature help provider interface defines the contract between extensions and
    /// the <see href="https://code.visualstudio.com/docs/editor/intellisense">parameter hints</see>-feature.
    /// </summary>
    type [<AllowNullLiteral>] SignatureHelpProvider =
        /// <summary>Provide help for the signature at the given position and document.</summary>
        /// <param name="document">The document in which the command was invoked.</param>
        /// <param name="position">The position at which the command was invoked.</param>
        /// <param name="token">A cancellation token.</param>
        /// <param name="context">Information about how signature help was triggered.</param>
        /// <returns>
        /// Signature help or a thenable that resolves to such. The lack of a result can be
        /// signaled by returning <c>undefined</c> or <c>null</c>.
        /// </returns>
        abstract provideSignatureHelp: document: TextDocument * position: Position * token: CancellationToken * context: SignatureHelpContext -> ProviderResult<SignatureHelp>

    /// <summary>Metadata about a registered <see cref="SignatureHelpProvider"><c>SignatureHelpProvider</c></see>.</summary>
    type [<AllowNullLiteral>] SignatureHelpProviderMetadata =
        /// List of characters that trigger signature help.
        abstract triggerCharacters: ReadonlyArray<string>
        /// List of characters that re-trigger signature help.
        /// 
        /// These trigger characters are only active when signature help is already showing. All trigger characters
        /// are also counted as re-trigger characters.
        abstract retriggerCharacters: ReadonlyArray<string>

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
        | Reference = 17
        | File = 16
        | Folder = 18
        | EnumMember = 19
        | Constant = 20
        | Struct = 21
        | Event = 22
        | Operator = 23
        | TypeParameter = 24

    /// <summary>
    /// A completion item represents a text snippet that is proposed to complete text that is being typed.
    /// 
    /// It is sufficient to create a completion item from just a <see cref="CompletionItem.label">label</see>. In that
    /// case the completion item will replace the <see cref="TextDocument.getWordRangeAtPosition">word</see>
    /// until the cursor with the given label or <see cref="CompletionItem.insertText">insertText</see>. Otherwise the
    /// given <see cref="CompletionItem.textEdit">edit</see> is used.
    /// 
    /// When selecting a completion item in the editor its defined or synthesized text edit will be applied
    /// to *all* cursors/selections whereas <see cref="CompletionItem.additionalTextEdits">additionalTextEdits</see> will be
    /// applied as provided.
    /// </summary>
    /// <seealso cref="CompletionItemProvider.provideCompletionItems">CompletionItemProvider.provideCompletionItems</seealso>
    /// <seealso cref="CompletionItemProvider.resolveCompletionItem">CompletionItemProvider.resolveCompletionItem</seealso>
    type [<AllowNullLiteral>] CompletionItem =
        /// The label of this completion item. By default
        /// this is also the text that is inserted when selecting
        /// this completion.
        abstract label: string with get, set
        /// The kind of this completion item. Based on the kind
        /// an icon is chosen by the editor.
        abstract kind: CompletionItemKind option with get, set
        /// A human-readable string with additional information
        /// about this item, like type or symbol information.
        abstract detail: string option with get, set
        /// A human-readable string that represents a doc-comment.
        abstract documentation: U2<string, MarkdownString> option with get, set
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
        /// <summary>
        /// An optional set of characters that when pressed while this completion is active will accept it first and
        /// then type that character. *Note* that all commit characters should have <c>length=1</c> and that superfluous
        /// characters will be ignored.
        /// </summary>
        abstract commitCharacters: ResizeArray<string> option with get, set
        /// <summary>
        /// Keep whitespace of the <see cref="CompletionItem.insertText">insertText</see> as is. By default, the editor adjusts leading
        /// whitespace of new lines so that they match the indentation of the line for which the item is accepted - setting
        /// this to <c>true</c> will prevent that.
        /// </summary>
        abstract keepWhitespace: bool option with get, set
        [<Obsolete("Use `CompletionItem.insertText` and `CompletionItem.range` instead.

~~An [edit](#TextEdit) which is applied to a document when selecting
this completion. When an edit is provided the value of
[insertText](#CompletionItem.insertText) is ignored.~~

~~The [range](#Range) of the edit must be single-line and on the same
line completions were [requested](#CompletionItemProvider.provideCompletionItems) at.~~")>]
        abstract textEdit: TextEdit option with get, set
        /// <summary>
        /// An optional array of additional <see cref="TextEdit">text edits</see> that are applied when
        /// selecting this completion. Edits must not overlap with the main <see cref="CompletionItem.textEdit">edit</see>
        /// nor with themselves.
        /// </summary>
        abstract additionalTextEdits: ResizeArray<TextEdit> option with get, set
        /// <summary>
        /// An optional <see cref="Command">command</see> that is executed *after* inserting this completion. *Note* that
        /// additional modifications to the current document should be described with the
        /// <see cref="CompletionItem.additionalTextEdits">additionalTextEdits</see>-property.
        /// </summary>
        abstract command: Command option with get, set

    /// <summary>
    /// A completion item represents a text snippet that is proposed to complete text that is being typed.
    /// 
    /// It is sufficient to create a completion item from just a <see cref="CompletionItem.label">label</see>. In that
    /// case the completion item will replace the <see cref="TextDocument.getWordRangeAtPosition">word</see>
    /// until the cursor with the given label or <see cref="CompletionItem.insertText">insertText</see>. Otherwise the
    /// given <see cref="CompletionItem.textEdit">edit</see> is used.
    /// 
    /// When selecting a completion item in the editor its defined or synthesized text edit will be applied
    /// to *all* cursors/selections whereas <see cref="CompletionItem.additionalTextEdits">additionalTextEdits</see> will be
    /// applied as provided.
    /// </summary>
    /// <seealso cref="CompletionItemProvider.provideCompletionItems">CompletionItemProvider.provideCompletionItems</seealso>
    /// <seealso cref="CompletionItemProvider.resolveCompletionItem">CompletionItemProvider.resolveCompletionItem</seealso>
    type [<AllowNullLiteral>] CompletionItemStatic =
        /// <summary>
        /// Creates a new completion item.
        /// 
        /// Completion items must have at least a <see cref="CompletionItem.label">label</see> which then
        /// will be used as insert text as well as for sorting and filtering.
        /// </summary>
        /// <param name="label">The label of the completion.</param>
        /// <param name="kind">The <see cref="CompletionItemKind">kind</see> of the completion.</param>
        [<EmitConstructor>] abstract Create: label: string * ?kind: CompletionItemKind -> CompletionItem

    /// <summary>
    /// Represents a collection of <see cref="CompletionItem">completion items</see> to be presented
    /// in the editor.
    /// </summary>
    type [<AllowNullLiteral>] CompletionList =
        /// This list is not complete. Further typing should result in recomputing
        /// this list.
        abstract isIncomplete: bool option with get, set
        /// The completion items.
        abstract items: ResizeArray<CompletionItem> with get, set

    /// <summary>
    /// Represents a collection of <see cref="CompletionItem">completion items</see> to be presented
    /// in the editor.
    /// </summary>
    type [<AllowNullLiteral>] CompletionListStatic =
        /// <summary>Creates a new completion list.</summary>
        /// <param name="items">The completion items.</param>
        /// <param name="isIncomplete">The list is not complete.</param>
        [<EmitConstructor>] abstract Create: ?items: ResizeArray<CompletionItem> * ?isIncomplete: bool -> CompletionList

    /// <summary>How a <see cref="CompletionItemProvider">completion provider</see> was triggered</summary>
    type [<RequireQualifiedAccess>] CompletionTriggerKind =
        /// Completion was triggered normally.
        | Invoke = 0
        /// Completion was triggered by a trigger character.
        | TriggerCharacter = 1
        /// Completion was re-triggered as current completion list is incomplete
        | TriggerForIncompleteCompletions = 2

    /// <summary>
    /// Contains additional information about the context in which
    /// <see cref="CompletionItemProvider.provideCompletionItems">completion provider</see> is triggered.
    /// </summary>
    type [<AllowNullLiteral>] CompletionContext =
        /// How the completion was triggered.
        abstract triggerKind: CompletionTriggerKind
        /// <summary>
        /// Character that triggered the completion item provider.
        /// 
        /// <c>undefined</c> if provider was not triggered by a character.
        /// 
        /// The trigger character is already in the document when the completion provider is triggered.
        /// </summary>
        abstract triggerCharacter: string option

    /// <summary>
    /// The completion item provider interface defines the contract between extensions and
    /// <see href="https://code.visualstudio.com/docs/editor/intellisense">IntelliSense</see>.
    /// 
    /// Providers can delay the computation of the <see cref="CompletionItem.detail"><c>detail</c></see>
    /// and <see cref="CompletionItem.documentation"><c>documentation</c></see> properties by implementing the
    /// <see cref="CompletionItemProvider.resolveCompletionItem"><c>resolveCompletionItem</c></see>-function. However, properties that
    /// are needed for the initial sorting and filtering, like <c>sortText</c>, <c>filterText</c>, <c>insertText</c>, and <c>range</c>, must
    /// not be changed during resolve.
    /// 
    /// Providers are asked for completions either explicitly by a user gesture or -depending on the configuration-
    /// implicitly when typing words or trigger characters.
    /// </summary>
    type [<AllowNullLiteral>] CompletionItemProvider =
        /// <summary>Provide completion items for the given position and document.</summary>
        /// <param name="document">The document in which the command was invoked.</param>
        /// <param name="position">The position at which the command was invoked.</param>
        /// <param name="token">A cancellation token.</param>
        /// <param name="context">How the completion was triggered.</param>
        /// <returns>
        /// An array of completions, a <see cref="CompletionList">completion list</see>, or a thenable that resolves to either.
        /// The lack of a result can be signaled by returning <c>undefined</c>, <c>null</c>, or an empty array.
        /// </returns>
        abstract provideCompletionItems: document: TextDocument * position: Position * token: CancellationToken * context: CompletionContext -> ProviderResult<U2<ResizeArray<CompletionItem>, CompletionList>>
        /// <summary>
        /// Given a completion item fill in more data, like <see cref="CompletionItem.documentation">doc-comment</see>
        /// or <see cref="CompletionItem.detail">details</see>.
        /// 
        /// The editor will only resolve a completion item once.
        /// </summary>
        /// <param name="item">A completion item currently active in the UI.</param>
        /// <param name="token">A cancellation token.</param>
        /// <returns>
        /// The resolved completion item or a thenable that resolves to of such. It is OK to return the given
        /// <c>item</c>. When no result is returned, the given <c>item</c> will be used.
        /// </returns>
        abstract resolveCompletionItem: item: CompletionItem * token: CancellationToken -> ProviderResult<CompletionItem>

    /// A document link is a range in a text document that links to an internal or external resource, like another
    /// text document or a web site.
    type [<AllowNullLiteral>] DocumentLink =
        /// The range this link applies to.
        abstract range: Range with get, set
        /// The uri this link points to.
        abstract target: Uri option with get, set

    /// A document link is a range in a text document that links to an internal or external resource, like another
    /// text document or a web site.
    type [<AllowNullLiteral>] DocumentLinkStatic =
        /// <summary>Creates a new document link.</summary>
        /// <param name="range">The range the document link applies to. Must not be empty.</param>
        /// <param name="target">The uri the document link points to.</param>
        [<EmitConstructor>] abstract Create: range: Range * ?target: Uri -> DocumentLink

    /// The document link provider defines the contract between extensions and feature of showing
    /// links in the editor.
    type [<AllowNullLiteral>] DocumentLinkProvider =
        /// <summary>
        /// Provide links for the given document. Note that the editor ships with a default provider that detects
        /// <c>http(s)</c> and <c>file</c> links.
        /// </summary>
        /// <param name="document">The document in which the command was invoked.</param>
        /// <param name="token">A cancellation token.</param>
        /// <returns>
        /// An array of <see cref="DocumentLink">document links</see> or a thenable that resolves to such. The lack of a result
        /// can be signaled by returning <c>undefined</c>, <c>null</c>, or an empty array.
        /// </returns>
        abstract provideDocumentLinks: document: TextDocument * token: CancellationToken -> ProviderResult<ResizeArray<DocumentLink>>
        /// <summary>
        /// Given a link fill in its <see cref="DocumentLink.target">target</see>. This method is called when an incomplete
        /// link is selected in the UI. Providers can implement this method and return incomplete links
        /// (without target) from the <see cref="DocumentLinkProvider.provideDocumentLinks"><c>provideDocumentLinks</c></see> method which
        /// often helps to improve performance.
        /// </summary>
        /// <param name="link">The link that is to be resolved.</param>
        /// <param name="token">A cancellation token.</param>
        abstract resolveDocumentLink: link: DocumentLink * token: CancellationToken -> ProviderResult<DocumentLink>

    /// Represents a color in RGBA space.
    type [<AllowNullLiteral>] Color =
        /// The red component of this color in the range [0-1].
        abstract red: float
        /// The green component of this color in the range [0-1].
        abstract green: float
        /// The blue component of this color in the range [0-1].
        abstract blue: float
        /// The alpha component of this color in the range [0-1].
        abstract alpha: float

    /// Represents a color in RGBA space.
    type [<AllowNullLiteral>] ColorStatic =
        /// <summary>Creates a new color instance.</summary>
        /// <param name="red">The red component.</param>
        /// <param name="green">The green component.</param>
        /// <param name="blue">The blue component.</param>
        /// <param name="alpha">The alpha component.</param>
        [<EmitConstructor>] abstract Create: red: float * green: float * blue: float * alpha: float -> Color

    /// Represents a color range from a document.
    type [<AllowNullLiteral>] ColorInformation =
        /// The range in the document where this color appears.
        abstract range: Range with get, set
        /// The actual color value for this color range.
        abstract color: Color with get, set

    /// Represents a color range from a document.
    type [<AllowNullLiteral>] ColorInformationStatic =
        /// <summary>Creates a new color range.</summary>
        /// <param name="range">The range the color appears in. Must not be empty.</param>
        /// <param name="color">The value of the color.</param>
        /// <param name="format">The format in which this color is currently formatted.</param>
        [<EmitConstructor>] abstract Create: range: Range * color: Color -> ColorInformation

    /// <summary>
    /// A color presentation object describes how a <see cref="Color"><c>color</c></see> should be represented as text and what
    /// edits are required to refer to it from source code.
    /// 
    /// For some languages one color can have multiple presentations, e.g. css can represent the color red with
    /// the constant <c>Red</c>, the hex-value <c>#ff0000</c>, or in rgba and hsla forms. In csharp other representations
    /// apply, e.g <c>System.Drawing.Color.Red</c>.
    /// </summary>
    type [<AllowNullLiteral>] ColorPresentation =
        /// The label of this color presentation. It will be shown on the color
        /// picker header. By default this is also the text that is inserted when selecting
        /// this color presentation.
        abstract label: string with get, set
        /// <summary>
        /// An <see cref="TextEdit">edit</see> which is applied to a document when selecting
        /// this presentation for the color.  When <c>falsy</c> the <see cref="ColorPresentation.label">label</see>
        /// is used.
        /// </summary>
        abstract textEdit: TextEdit option with get, set
        /// <summary>
        /// An optional array of additional <see cref="TextEdit">text edits</see> that are applied when
        /// selecting this color presentation. Edits must not overlap with the main <see cref="ColorPresentation.textEdit">edit</see> nor with themselves.
        /// </summary>
        abstract additionalTextEdits: ResizeArray<TextEdit> option with get, set

    /// <summary>
    /// A color presentation object describes how a <see cref="Color"><c>color</c></see> should be represented as text and what
    /// edits are required to refer to it from source code.
    /// 
    /// For some languages one color can have multiple presentations, e.g. css can represent the color red with
    /// the constant <c>Red</c>, the hex-value <c>#ff0000</c>, or in rgba and hsla forms. In csharp other representations
    /// apply, e.g <c>System.Drawing.Color.Red</c>.
    /// </summary>
    type [<AllowNullLiteral>] ColorPresentationStatic =
        /// <summary>Creates a new color presentation.</summary>
        /// <param name="label">The label of this color presentation.</param>
        [<EmitConstructor>] abstract Create: label: string -> ColorPresentation

    /// The document color provider defines the contract between extensions and feature of
    /// picking and modifying colors in the editor.
    type [<AllowNullLiteral>] DocumentColorProvider =
        /// <summary>Provide colors for the given document.</summary>
        /// <param name="document">The document in which the command was invoked.</param>
        /// <param name="token">A cancellation token.</param>
        /// <returns>
        /// An array of <see cref="ColorInformation">color information</see> or a thenable that resolves to such. The lack of a result
        /// can be signaled by returning <c>undefined</c>, <c>null</c>, or an empty array.
        /// </returns>
        abstract provideDocumentColors: document: TextDocument * token: CancellationToken -> ProviderResult<ResizeArray<ColorInformation>>
        /// <summary>Provide <see cref="ColorPresentation">representations</see> for a color.</summary>
        /// <param name="color">The color to show and insert.</param>
        /// <param name="context">A context object with additional information</param>
        /// <param name="token">A cancellation token.</param>
        /// <returns>
        /// An array of color presentations or a thenable that resolves to such. The lack of a result
        /// can be signaled by returning <c>undefined</c>, <c>null</c>, or an empty array.
        /// </returns>
        abstract provideColorPresentations: color: Color * context: {| document: TextDocument; range: Range |} * token: CancellationToken -> ProviderResult<ResizeArray<ColorPresentation>>

    /// A line based folding range. To be valid, start and end line must a zero or larger and smaller than the number of lines in the document.
    /// Invalid ranges will be ignored.
    type [<AllowNullLiteral>] FoldingRange =
        /// The zero-based start line of the range to fold. The folded area starts after the line's last character.
        /// To be valid, the end must be zero or larger and smaller than the number of lines in the document.
        abstract start: float with get, set
        /// The zero-based end line of the range to fold. The folded area ends with the line's last character.
        /// To be valid, the end must be zero or larger and smaller than the number of lines in the document.
        abstract ``end``: float with get, set
        /// <summary>
        /// Describes the <see cref="FoldingRangeKind">Kind</see> of the folding range such as <see cref="FoldingRangeKind.Comment">Comment</see> or
        /// <see cref="FoldingRangeKind.Region">Region</see>. The kind is used to categorize folding ranges and used by commands
        /// like 'Fold all comments'. See
        /// <see cref="FoldingRangeKind">FoldingRangeKind</see> for an enumeration of all kinds.
        /// If not set, the range is originated from a syntax element.
        /// </summary>
        abstract kind: FoldingRangeKind option with get, set

    /// A line based folding range. To be valid, start and end line must a zero or larger and smaller than the number of lines in the document.
    /// Invalid ranges will be ignored.
    type [<AllowNullLiteral>] FoldingRangeStatic =
        /// <summary>Creates a new folding range.</summary>
        /// <param name="start">The start line of the folded range.</param>
        /// <param name="end">The end line of the folded range.</param>
        /// <param name="kind">The kind of the folding range.</param>
        [<EmitConstructor>] abstract Create: start: float * ``end``: float * ?kind: FoldingRangeKind -> FoldingRange

    /// <summary>
    /// An enumeration of specific folding range kinds. The kind is an optional field of a <see cref="FoldingRange">FoldingRange</see>
    /// and is used to distinguish specific folding ranges such as ranges originated from comments. The kind is used by commands like
    /// <c>Fold all comments</c> or <c>Fold all regions</c>.
    /// If the kind is not set on the range, the range originated from a syntax element other than comments, imports or region markers.
    /// </summary>
    type [<RequireQualifiedAccess>] FoldingRangeKind =
        /// Kind for folding range representing a comment.
        | Comment = 1
        /// Kind for folding range representing a import.
        | Imports = 2
        /// <summary>Kind for folding range representing regions originating from folding markers like <c>#region</c> and <c>#endregion</c>.</summary>
        | Region = 3

    /// Folding context (for future use)
    type [<AllowNullLiteral>] FoldingContext =
        interface end

    /// <summary>
    /// The folding range provider interface defines the contract between extensions and
    /// <see href="https://code.visualstudio.com/docs/editor/codebasics#_folding">Folding</see> in the editor.
    /// </summary>
    type [<AllowNullLiteral>] FoldingRangeProvider =
        /// <summary>
        /// Returns a list of folding ranges or null and undefined if the provider
        /// does not want to participate or was cancelled.
        /// </summary>
        /// <param name="document">The document in which the command was invoked.</param>
        /// <param name="context">Additional context information (for future use)</param>
        /// <param name="token">A cancellation token.</param>
        abstract provideFoldingRanges: document: TextDocument * context: FoldingContext * token: CancellationToken -> ProviderResult<ResizeArray<FoldingRange>>

    /// A tuple of two characters, like a pair of
    /// opening and closing brackets.
    type CharacterPair =
        string * string

    /// Describes how comments for a language work.
    type [<AllowNullLiteral>] CommentRule =
        /// <summary>The line comment token, like <c>// this is a comment</c></summary>
        abstract lineComment: string option with get, set
        /// <summary>The block comment character pair, like <c>/* block comment *&#47;</c></summary>
        abstract blockComment: CharacterPair option with get, set

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

    /// Describes a rule to be evaluated when pressing Enter.
    type [<AllowNullLiteral>] OnEnterRule =
        /// This rule will only execute if the text before the cursor matches this regular expression.
        abstract beforeText: RegExp with get, set
        /// This rule will only execute if the text after the cursor matches this regular expression.
        abstract afterText: RegExp option with get, set
        /// The action to execute.
        abstract action: EnterAction with get, set

    /// The language configuration interfaces defines the contract between extensions
    /// and various editor features, like automatic bracket insertion, automatic indentation etc.
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
        /// **Deprecated** Do not use.
        [<Obsolete("Will be replaced by a better API soon.")>]
        abstract __electricCharacterSupport: {| brackets: obj option; docComment: {| scope: string; ``open``: string; lineStart: string; close: string option |} option |} option with get, set
        /// **Deprecated** Do not use.
        [<Obsolete("Use the autoClosingPairs property in the language configuration file instead.")>]
        abstract __characterPairSupport: {| autoClosingPairs: ResizeArray<{| ``open``: string; close: string; notIn: ResizeArray<string> option |}> |} option with get, set

    /// The configuration target
    type [<RequireQualifiedAccess>] ConfigurationTarget =
        /// Global configuration
        | Global = 1
        /// Workspace configuration
        | Workspace = 2
        /// Workspace folder configuration
        | WorkspaceFolder = 3

    /// <summary>
    /// Represents the configuration. It is a merged view of
    /// 
    /// - Default configuration
    /// - Global configuration
    /// - Workspace configuration (if available)
    /// - Workspace folder configuration of the requested resource (if available)
    /// 
    /// *Global configuration* comes from User Settings and shadows Defaults.
    /// 
    /// *Workspace configuration* comes from Workspace Settings and shadows Global configuration.
    /// 
    /// *Workspace Folder configuration* comes from <c>.vscode</c> folder under one of the <see cref="workspace.workspaceFolders">workspace folders</see>.
    /// 
    /// *Note:* Workspace and Workspace Folder configurations contains <c>launch</c> and <c>tasks</c> settings. Their basename will be
    /// part of the section identifier. The following snippets shows how to retrieve all configurations
    /// from <c>launch.json</c>:
    /// 
    /// <code language="ts">
    /// // launch.json configuration
    /// const config = workspace.getConfiguration('launch', vscode.window.activeTextEditor.document.uri);
    /// 
    /// // retrieve values
    /// const values = config.get('configurations');
    /// </code>
    /// 
    /// Refer to <see href="https://code.visualstudio.com/docs/getstarted/settings">Settings</see> for more information.
    /// </summary>
    type [<AllowNullLiteral>] WorkspaceConfiguration =
        /// <summary>Return a value from this configuration.</summary>
        /// <param name="section">Configuration name, supports _dotted_ names.</param>
        /// <returns>The value <c>section</c> denotes or <c>undefined</c>.</returns>
        abstract get: section: string -> 'T option
        /// <summary>Return a value from this configuration.</summary>
        /// <param name="section">Configuration name, supports _dotted_ names.</param>
        /// <param name="defaultValue">A value should be returned when no value could be found, is <c>undefined</c>.</param>
        /// <returns>The value <c>section</c> denotes or the default.</returns>
        abstract get: section: string * defaultValue: 'T -> 'T
        /// <summary>Check if this configuration has a certain value.</summary>
        /// <param name="section">Configuration name, supports _dotted_ names.</param>
        /// <returns><c>true</c> if the section doesn't resolve to <c>undefined</c>.</returns>
        abstract has: section: string -> bool
        /// <summary>
        /// Retrieve all information about a configuration setting. A configuration value
        /// often consists of a *default* value, a global or installation-wide value,
        /// a workspace-specific value and a folder-specific value.
        /// 
        /// The *effective* value (returned by <see cref="WorkspaceConfiguration.get)"><c>get</c></see>
        /// is computed like this: <c>defaultValue</c> overwritten by <c>globalValue</c>,
        /// <c>globalValue</c> overwritten by <c>workspaceValue</c>. <c>workspaceValue</c> overwritten by <c>workspaceFolderValue</c>.
        /// Refer to <see href="https://code.visualstudio.com/docs/getstarted/settings">Settings Inheritance</see>
        /// for more information.
        /// 
        /// *Note:* The configuration name must denote a leaf in the configuration tree
        /// (<c>editor.fontSize</c> vs <c>editor</c>) otherwise no result is returned.
        /// </summary>
        /// <param name="section">Configuration name, supports _dotted_ names.</param>
        /// <returns>Information about a configuration setting or <c>undefined</c>.</returns>
        abstract inspect: section: string -> WorkspaceConfigurationInspect<'T> option
        /// <summary>
        /// Update a configuration value. The updated configuration values are persisted.
        /// 
        /// A value can be changed in
        /// 
        /// - <see cref="ConfigurationTarget.Global">Global configuration</see>: Changes the value for all instances of the editor.
        /// - <see cref="ConfigurationTarget.Workspace">Workspace configuration</see>: Changes the value for current workspace, if available.
        /// - <see cref="ConfigurationTarget.WorkspaceFolder">Workspace folder configuration</see>: Changes the value for the
        /// <see cref="workspace.workspaceFolders">Workspace folder</see> to which the current <see cref="WorkspaceConfiguration">configuration</see> is scoped to.
        /// 
        /// *Note 1:* Setting a global value in the presence of a more specific workspace value
        /// has no observable effect in that workspace, but in others. Setting a workspace value
        /// in the presence of a more specific folder value has no observable effect for the resources
        /// under respective <see cref="workspace.workspaceFolders">folder</see>, but in others. Refer to
        /// <see href="https://code.visualstudio.com/docs/getstarted/settings">Settings Inheritance</see> for more information.
        /// 
        /// *Note 2:* To remove a configuration value use <c>undefined</c>, like so: <c>config.update('somekey', undefined)</c>
        /// 
        /// Will throw error when
        /// - Writing a configuration which is not registered.
        /// - Writing a configuration to workspace or folder target when no workspace is opened
        /// - Writing a configuration to folder target when there is no folder settings
        /// - Writing to folder target without passing a resource when getting the configuration (<c>workspace.getConfiguration(section, resource)</c>)
        /// - Writing a window configuration to folder target
        /// </summary>
        /// <param name="section">Configuration name, supports _dotted_ names.</param>
        /// <param name="value">The new value.</param>
        /// <param name="configurationTarget">
        /// The <see cref="ConfigurationTarget">configuration target</see> or a boolean value.
        /// - If <c>true</c> configuration target is <c>ConfigurationTarget.Global</c>.
        /// - If <c>false</c> configuration target is <c>ConfigurationTarget.Workspace</c>.
        /// - If <c>undefined</c> or <c>null</c> configuration target is
        /// <c>ConfigurationTarget.WorkspaceFolder</c> when configuration is resource specific
        /// <c>ConfigurationTarget.Workspace</c> otherwise.
        /// </param>
        abstract update: section: string * value: obj option * ?configurationTarget: U2<ConfigurationTarget, bool> -> Thenable<unit>
        /// Readable dictionary that backs this configuration.
        [<EmitIndexer>] abstract Item: key: string -> obj option

    /// Represents a location inside a resource, such as a line
    /// inside a text file.
    type [<AllowNullLiteral>] Location =
        /// The resource identifier of this location.
        abstract uri: Uri with get, set
        /// The document range of this location.
        abstract range: Range with get, set

    /// Represents a location inside a resource, such as a line
    /// inside a text file.
    type [<AllowNullLiteral>] LocationStatic =
        /// <summary>Creates a new location object.</summary>
        /// <param name="uri">The resource identifier.</param>
        /// <param name="rangeOrPosition">The range or position. Positions will be converted to an empty range.</param>
        [<EmitConstructor>] abstract Create: uri: Uri * rangeOrPosition: U2<Range, Position> -> Location

    /// <summary>
    /// Represents the connection of two locations. Provides additional metadata over normal <see cref="Location">locations</see>,
    /// including an origin range.
    /// </summary>
    type [<AllowNullLiteral>] LocationLink =
        /// Span of the origin of this link.
        /// 
        /// Used as the underlined span for mouse definition hover. Defaults to the word range at
        /// the definition position.
        abstract originSelectionRange: Range option with get, set
        /// The target resource identifier of this link.
        abstract targetUri: Uri with get, set
        /// The full target range of this link.
        abstract targetRange: Range with get, set
        /// The span of this link.
        abstract targetSelectionRange: Range option with get, set

    /// The event that is fired when diagnostics change.
    type [<AllowNullLiteral>] DiagnosticChangeEvent =
        /// An array of resources for which diagnostics have changed.
        abstract uris: ResizeArray<Uri>

    /// Represents the severity of diagnostics.
    type [<RequireQualifiedAccess>] DiagnosticSeverity =
        /// Something not allowed by the rules of a language or other means.
        | Error = 0
        /// Something suspicious but allowed.
        | Warning = 1
        /// Something to inform about but not a problem.
        | Information = 2
        /// Something to hint to a better way of doing it, like proposing
        /// a refactoring.
        | Hint = 3

    /// Represents a related message and source code location for a diagnostic. This should be
    /// used to point to code locations that cause or related to a diagnostics, e.g when duplicating
    /// a symbol in a scope.
    type [<AllowNullLiteral>] DiagnosticRelatedInformation =
        /// The location of this related diagnostic information.
        abstract location: Location with get, set
        /// The message of this related diagnostic information.
        abstract message: string with get, set

    /// Represents a related message and source code location for a diagnostic. This should be
    /// used to point to code locations that cause or related to a diagnostics, e.g when duplicating
    /// a symbol in a scope.
    type [<AllowNullLiteral>] DiagnosticRelatedInformationStatic =
        /// <summary>Creates a new related diagnostic information object.</summary>
        /// <param name="location">The location.</param>
        /// <param name="message">The message.</param>
        [<EmitConstructor>] abstract Create: location: Location * message: string -> DiagnosticRelatedInformation

    /// Additional metadata about the type of a diagnostic.
    type [<RequireQualifiedAccess>] DiagnosticTag =
        /// <summary>
        /// Unused or unnecessary code.
        /// 
        /// Diagnostics with this tag are rendered faded out. The amount of fading
        /// is controlled by the <c>"editorUnnecessaryCode.opacity"</c> theme color. For
        /// example, <c>"editorUnnecessaryCode.opacity": "#000000c0"</c> will render the
        /// code with 75% opacity. For high contrast themes, use the
        /// <c>"editorUnnecessaryCode.border"</c> theme color to underline unnecessary code
        /// instead of fading it out.
        /// </summary>
        | Unnecessary = 1

    /// Represents a diagnostic, such as a compiler error or warning. Diagnostic objects
    /// are only valid in the scope of a file.
    type [<AllowNullLiteral>] Diagnostic =
        /// The range to which this diagnostic applies.
        abstract range: Range with get, set
        /// The human-readable message.
        abstract message: string with get, set
        /// <summary>The severity, default is <see cref="DiagnosticSeverity.Error">error</see>.</summary>
        abstract severity: DiagnosticSeverity with get, set
        /// A human-readable string describing the source of this
        /// diagnostic, e.g. 'typescript' or 'super lint'.
        abstract source: string option with get, set
        /// <summary>
        /// A code or identifier for this diagnostic.
        /// Should be used for later processing, e.g. when providing <see cref="CodeActionContext">code actions</see>.
        /// </summary>
        abstract code: U2<string, float> option with get, set
        /// An array of related diagnostic information, e.g. when symbol-names within
        /// a scope collide all definitions can be marked via this property.
        abstract relatedInformation: ResizeArray<DiagnosticRelatedInformation> option with get, set
        /// Additional metadata about the diagnostic.
        abstract tags: ResizeArray<DiagnosticTag> option with get, set

    /// Represents a diagnostic, such as a compiler error or warning. Diagnostic objects
    /// are only valid in the scope of a file.
    type [<AllowNullLiteral>] DiagnosticStatic =
        /// <summary>Creates a new diagnostic object.</summary>
        /// <param name="range">The range to which this diagnostic applies.</param>
        /// <param name="message">The human-readable message.</param>
        /// <param name="severity">The severity, default is <see cref="DiagnosticSeverity.Error">error</see>.</param>
        [<EmitConstructor>] abstract Create: range: Range * message: string * ?severity: DiagnosticSeverity -> Diagnostic

    /// <summary>
    /// A diagnostics collection is a container that manages a set of
    /// <see cref="Diagnostic">diagnostics</see>. Diagnostics are always scopes to a
    /// diagnostics collection and a resource.
    /// 
    /// To get an instance of a <c>DiagnosticCollection</c> use
    /// <see cref="languages.createDiagnosticCollection">createDiagnosticCollection</see>.
    /// </summary>
    type [<AllowNullLiteral>] DiagnosticCollection =
        /// <summary>
        /// The name of this diagnostic collection, for instance <c>typescript</c>. Every diagnostic
        /// from this collection will be associated with this name. Also, the task framework uses this
        /// name when defining <see href="https://code.visualstudio.com/docs/editor/tasks#_defining-a-problem-matcher">problem matchers</see>.
        /// </summary>
        abstract name: string
        /// <summary>
        /// Assign diagnostics for given resource. Will replace
        /// existing diagnostics for that resource.
        /// </summary>
        /// <param name="uri">A resource identifier.</param>
        /// <param name="diagnostics">Array of diagnostics or <c>undefined</c></param>
        abstract set: uri: Uri * diagnostics: ResizeArray<Diagnostic> option -> unit
        /// <summary>
        /// Replace all entries in this collection.
        /// 
        /// Diagnostics of multiple tuples of the same uri will be merged, e.g
        /// <c>[[file1, [d1]], [file1, [d2]]]</c> is equivalent to <c>[[file1, [d1, d2]]]</c>.
        /// If a diagnostics item is <c>undefined</c> as in <c>[file1, undefined]</c>
        /// all previous but not subsequent diagnostics are removed.
        /// </summary>
        /// <param name="entries">An array of tuples, like <c>[[file1, [d1, d2]], [file2, [d3, d4, d5]]]</c>, or <c>undefined</c>.</param>
        abstract set: entries: ResizeArray<Uri * ResizeArray<Diagnostic> option> -> unit
        /// <summary>
        /// Remove all diagnostics from this collection that belong
        /// to the provided <c>uri</c>. The same as <c>#set(uri, undefined)</c>.
        /// </summary>
        /// <param name="uri">A resource identifier.</param>
        abstract delete: uri: Uri -> unit
        /// <summary>
        /// Remove all diagnostics from this collection. The same
        /// as calling <c>#set(undefined)</c>;
        /// </summary>
        abstract clear: unit -> unit
        /// <summary>Iterate over each entry in this collection.</summary>
        /// <param name="callback">Function to execute for each entry.</param>
        /// <param name="thisArg">The <c>this</c> context used when invoking the handler function.</param>
        abstract forEach: callback: (Uri -> ResizeArray<Diagnostic> -> DiagnosticCollection -> obj option) * ?thisArg: obj -> unit
        /// <summary>
        /// Get the diagnostics for a given resource. *Note* that you cannot
        /// modify the diagnostics-array returned from this call.
        /// </summary>
        /// <param name="uri">A resource identifier.</param>
        /// <returns>An immutable array of <see cref="Diagnostic">diagnostics</see> or <c>undefined</c>.</returns>
        abstract get: uri: Uri -> ResizeArray<Diagnostic> option
        /// <summary>
        /// Check if this collection contains diagnostics for a
        /// given resource.
        /// </summary>
        /// <param name="uri">A resource identifier.</param>
        /// <returns><c>true</c> if this collection has diagnostic for the given resource.</returns>
        abstract has: uri: Uri -> bool
        /// <summary>
        /// Dispose and free associated resources. Calls
        /// <see cref="DiagnosticCollection.clear">clear</see>.
        /// </summary>
        abstract dispose: unit -> unit

    /// Denotes a location of an editor in the window. Editors can be arranged in a grid
    /// and each column represents one editor location in that grid by counting the editors
    /// in order of their appearance.
    type [<RequireQualifiedAccess>] ViewColumn =
        /// <summary>
        /// A *symbolic* editor column representing the currently active column. This value
        /// can be used when opening editors, but the *resolved* <see cref="TextEditor.viewColumn">viewColumn</see>-value
        /// of editors will always be <c>One</c>, <c>Two</c>, <c>Three</c>,... or <c>undefined</c> but never <c>Active</c>.
        /// </summary>
        | Active = -1
        /// <summary>
        /// A *symbolic* editor column representing the column to the side of the active one. This value
        /// can be used when opening editors, but the *resolved* <see cref="TextEditor.viewColumn">viewColumn</see>-value
        /// of editors will always be <c>One</c>, <c>Two</c>, <c>Three</c>,... or <c>undefined</c> but never <c>Beside</c>.
        /// </summary>
        | Beside = -2
        /// The first editor column.
        | One = 1
        /// The second editor column.
        | Two = 2
        /// The third editor column.
        | Three = 3
        /// The fourth editor column.
        | Four = 4
        /// The fifth editor column.
        | Five = 5
        /// The sixth editor column.
        | Six = 6
        /// The seventh editor column.
        | Seven = 7
        /// The eighth editor column.
        | Eight = 8
        /// The ninth editor column.
        | Nine = 9

    /// <summary>
    /// An output channel is a container for readonly textual information.
    /// 
    /// To get an instance of an <c>OutputChannel</c> use
    /// <see cref="window.createOutputChannel">createOutputChannel</see>.
    /// </summary>
    type [<AllowNullLiteral>] OutputChannel =
        /// The human-readable name of this output channel.
        abstract name: string
        /// <summary>Append the given value to the channel.</summary>
        /// <param name="value">A string, falsy values will not be printed.</param>
        abstract append: value: string -> unit
        /// <summary>
        /// Append the given value and a line feed character
        /// to the channel.
        /// </summary>
        /// <param name="value">A string, falsy values will be printed.</param>
        abstract appendLine: value: string -> unit
        /// Removes all output from the channel.
        abstract clear: unit -> unit
        /// <summary>Reveal this channel in the UI.</summary>
        /// <param name="preserveFocus">When <c>true</c> the channel will not take focus.</param>
        abstract show: ?preserveFocus: bool -> unit
        /// <summary>~~Reveal this channel in the UI.~~</summary>
        /// <param name="column">This argument is **deprecated** and will be ignored.</param>
        /// <param name="preserveFocus">When <c>true</c> the channel will not take focus.</param>
        [<Obsolete("Use the overload with just one parameter (`show(preserveFocus?: boolean): void`).")>]
        abstract show: ?column: ViewColumn * ?preserveFocus: bool -> unit
        /// Hide this channel from the UI.
        abstract hide: unit -> unit
        /// Dispose and free associated resources.
        abstract dispose: unit -> unit

    /// Represents the alignment of status bar items.
    type [<RequireQualifiedAccess>] StatusBarAlignment =
        /// Aligned to the left side.
        | Left = 1
        /// Aligned to the right side.
        | Right = 2

    /// A status bar item is a status bar contribution that can
    /// show text and icons and run a command on click.
    type [<AllowNullLiteral>] StatusBarItem =
        /// The alignment of this item.
        abstract alignment: StatusBarAlignment
        /// The priority of this item. Higher value means the item should
        /// be shown more to the left.
        abstract priority: float
        /// <summary>
        /// The text to show for the entry. You can embed icons in the text by leveraging the syntax:
        /// 
        /// <c>My text $(icon-name) contains icons like $(icon-name) this one.</c>
        /// 
        /// Where the icon-name is taken from the <see href="https://octicons.github.com">octicon</see> icon set, e.g.
        /// <c>light-bulb</c>, <c>thumbsup</c>, <c>zap</c> etc.
        /// </summary>
        abstract text: string with get, set
        /// The tooltip text when you hover over this entry.
        abstract tooltip: string option with get, set
        /// The foreground color for this entry.
        abstract color: U2<string, ThemeColor> option with get, set
        /// <summary>
        /// The identifier of a command to run on click. The command must be
        /// <see cref="commands.getCommands">known</see>.
        /// </summary>
        abstract command: string option with get, set
        /// Shows the entry in the status bar.
        abstract show: unit -> unit
        /// Hide the entry in the status bar.
        abstract hide: unit -> unit
        /// <summary>
        /// Dispose and free associated resources. Call
        /// <see cref="StatusBarItem.hide">hide</see>.
        /// </summary>
        abstract dispose: unit -> unit

    /// Defines a generalized way of reporting progress updates.
    type [<AllowNullLiteral>] Progress<'T> =
        /// <summary>Report a progress update.</summary>
        /// <param name="value">
        /// A progress item, like a message and/or an
        /// report on how much work finished
        /// </param>
        abstract report: value: 'T -> unit

    /// An individual terminal instance within the integrated terminal.
    type [<AllowNullLiteral>] Terminal =
        /// The name of the terminal.
        abstract name: string
        /// The process ID of the shell process.
        abstract processId: Thenable<float>
        /// <summary>
        /// Send text to the terminal. The text is written to the stdin of the underlying pty process
        /// (shell) of the terminal.
        /// </summary>
        /// <param name="text">The text to send.</param>
        /// <param name="addNewLine">
        /// Whether to add a new line to the text being sent, this is normally
        /// required to run a command in the terminal. The character(s) added are \n or \r\n
        /// depending on the platform. This defaults to <c>true</c>.
        /// </param>
        abstract sendText: text: string * ?addNewLine: bool -> unit
        /// <summary>Show the terminal panel and reveal this terminal in the UI.</summary>
        /// <param name="preserveFocus">When <c>true</c> the terminal will not take focus.</param>
        abstract show: ?preserveFocus: bool -> unit
        /// Hide the terminal panel if this terminal is currently showing.
        abstract hide: unit -> unit
        /// Dispose and free associated resources.
        abstract dispose: unit -> unit

    /// <summary>
    /// Represents an extension.
    /// 
    /// To get an instance of an <c>Extension</c> use <see cref="extensions.getExtension">getExtension</see>.
    /// </summary>
    type [<AllowNullLiteral>] Extension<'T> =
        /// <summary>The canonical extension identifier in the form of: <c>publisher.name</c>.</summary>
        abstract id: string
        /// The absolute file path of the directory containing this extension.
        abstract extensionPath: string
        /// <summary><c>true</c> if the extension has been activated.</summary>
        abstract isActive: bool
        /// The parsed contents of the extension's package.json.
        abstract packageJSON: obj option
        /// The public API exported by this extension. It is an invalid action
        /// to access this field before this extension has been activated.
        abstract exports: 'T
        /// <summary>Activates this extension and returns its public API.</summary>
        /// <returns>A promise that will resolve when this extension has been activated.</returns>
        abstract activate: unit -> Thenable<'T>

    /// <summary>
    /// An extension context is a collection of utilities private to an
    /// extension.
    /// 
    /// An instance of an <c>ExtensionContext</c> is provided as the first
    /// parameter to the <c>activate</c>-call of an extension.
    /// </summary>
    type [<AllowNullLiteral>] ExtensionContext =
        /// An array to which disposables can be added. When this
        /// extension is deactivated the disposables will be disposed.
        abstract subscriptions: ResizeArray<{| dispose: unit -> obj option |}> with get, set
        /// <summary>
        /// A memento object that stores state in the context
        /// of the currently opened <see cref="workspace.workspaceFolders">workspace</see>.
        /// </summary>
        abstract workspaceState: Memento with get, set
        /// <summary>
        /// A memento object that stores state independent
        /// of the current opened <see cref="workspace.workspaceFolders">workspace</see>.
        /// </summary>
        abstract globalState: Memento with get, set
        /// The absolute file path of the directory containing the extension.
        abstract extensionPath: string with get, set
        /// <summary>Get the absolute path of a resource contained in the extension.</summary>
        /// <param name="relativePath">A relative path to a resource contained in the extension.</param>
        /// <returns>The absolute path of the resource.</returns>
        abstract asAbsolutePath: relativePath: string -> string
        /// <summary>
        /// An absolute file path of a workspace specific directory in which the extension
        /// can store private state. The directory might not exist on disk and creation is
        /// up to the extension. However, the parent directory is guaranteed to be existent.
        /// 
        /// Use <see cref="ExtensionContext.workspaceState"><c>workspaceState</c></see> or
        /// <see cref="ExtensionContext.globalState"><c>globalState</c></see> to store key value data.
        /// </summary>
        abstract storagePath: string option with get, set
        /// <summary>
        /// An absolute file path in which the extension can store global state.
        /// The directory might not exist on disk and creation is
        /// up to the extension. However, the parent directory is guaranteed to be existent.
        /// 
        /// Use <see cref="ExtensionContext.globalState"><c>globalState</c></see> to store key value data.
        /// </summary>
        abstract globalStoragePath: string with get, set
        /// An absolute file path of a directory in which the extension can create log files.
        /// The directory might not exist on disk and creation is up to the extension. However,
        /// the parent directory is guaranteed to be existent.
        abstract logPath: string with get, set

    /// A memento represents a storage utility. It can store and retrieve
    /// values.
    type [<AllowNullLiteral>] Memento =
        /// <summary>Return a value.</summary>
        /// <param name="key">A string.</param>
        /// <returns>The stored value or <c>undefined</c>.</returns>
        abstract get: key: string -> 'T option
        /// <summary>Return a value.</summary>
        /// <param name="key">A string.</param>
        /// <param name="defaultValue">
        /// A value that should be returned when there is no
        /// value (<c>undefined</c>) with the given key.
        /// </param>
        /// <returns>The stored value or the defaultValue.</returns>
        abstract get: key: string * defaultValue: 'T -> 'T
        /// <summary>Store a value. The value must be JSON-stringifyable.</summary>
        /// <param name="key">A string.</param>
        /// <param name="value">A value. MUST not contain cyclic references.</param>
        abstract update: key: string * value: obj option -> Thenable<unit>

    /// Controls the behaviour of the terminal's visibility.
    type [<RequireQualifiedAccess>] TaskRevealKind =
        /// Always brings the terminal to front if the task is executed.
        | Always = 1
        /// Only brings the terminal to front if a problem is detected executing the task
        /// (e.g. the task couldn't be started because).
        | Silent = 2
        /// The terminal never comes to front when the task is executed.
        | Never = 3

    /// Controls how the task channel is used between tasks
    type [<RequireQualifiedAccess>] TaskPanelKind =
        /// Shares a panel with other tasks. This is the default.
        | Shared = 1
        /// Uses a dedicated panel for this tasks. The panel is not
        /// shared with other tasks.
        | Dedicated = 2
        /// Creates a new panel whenever this task is executed.
        | New = 3

    /// Controls how the task is presented in the UI.
    type [<AllowNullLiteral>] TaskPresentationOptions =
        /// <summary>
        /// Controls whether the task output is reveal in the user interface.
        /// Defaults to <c>RevealKind.Always</c>.
        /// </summary>
        abstract reveal: TaskRevealKind option with get, set
        /// Controls whether the command associated with the task is echoed
        /// in the user interface.
        abstract echo: bool option with get, set
        /// Controls whether the panel showing the task output is taking focus.
        abstract focus: bool option with get, set
        /// <summary>
        /// Controls if the task panel is used for this task only (dedicated),
        /// shared between tasks (shared) or if a new panel is created on
        /// every task execution (new). Defaults to <c>TaskInstanceKind.Shared</c>
        /// </summary>
        abstract panel: TaskPanelKind option with get, set
        /// Controls whether to show the "Terminal will be reused by tasks, press any key to close it" message.
        abstract showReuseMessage: bool option with get, set
        /// Controls whether the terminal is cleared before executing the task.
        abstract clear: bool option with get, set

    /// A grouping for tasks. The editor by default supports the
    /// 'Clean', 'Build', 'RebuildAll' and 'Test' group.
    type [<AllowNullLiteral>] TaskGroup =
        interface end

    /// A grouping for tasks. The editor by default supports the
    /// 'Clean', 'Build', 'RebuildAll' and 'Test' group.
    type [<AllowNullLiteral>] TaskGroupStatic =
        /// The clean task group;
        abstract Clean: TaskGroup with get, set
        /// The build task group;
        abstract Build: TaskGroup with get, set
        /// The rebuild all task group;
        abstract Rebuild: TaskGroup with get, set
        /// The test all task group;
        abstract Test: TaskGroup with get, set

    /// A structure that defines a task kind in the system.
    /// The value must be JSON-stringifyable.
    type [<AllowNullLiteral>] TaskDefinition =
        /// The task definition describing the task provided by an extension.
        /// Usually a task provider defines more properties to identify
        /// a task. They need to be defined in the package.json of the
        /// extension under the 'taskDefinitions' extension point. The npm
        /// task definition for example looks like this
        /// <code language="typescript">
        /// interface NpmTaskDefinition extends TaskDefinition {
        ///      script: string;
        /// }
        /// </code>
        /// 
        /// Note that type identifier starting with a '$' are reserved for internal
        /// usages and shouldn't be used by extensions.
        abstract ``type``: string
        /// Additional attributes of a concrete task definition.
        [<EmitIndexer>] abstract Item: name: string -> obj option with get, set

    /// Options for a process execution
    type [<AllowNullLiteral>] ProcessExecutionOptions =
        /// The current working directory of the executed program or shell.
        /// If omitted the tools current workspace root is used.
        abstract cwd: string option with get, set
        /// The additional environment of the executed program or shell. If omitted
        /// the parent process' environment is used. If provided it is merged with
        /// the parent process' environment.
        abstract env: {| Item: string |} option with get, set

    /// The execution of a task happens as an external process
    /// without shell interaction.
    type [<AllowNullLiteral>] ProcessExecution =
        /// The process to be executed.
        abstract ``process``: string with get, set
        /// The arguments passed to the process. Defaults to an empty array.
        abstract args: ResizeArray<string> with get, set
        /// The process options used when the process is executed.
        /// Defaults to undefined.
        abstract options: ProcessExecutionOptions option with get, set

    /// The execution of a task happens as an external process
    /// without shell interaction.
    type [<AllowNullLiteral>] ProcessExecutionStatic =
        /// <summary>Creates a process execution.</summary>
        /// <param name="process">The process to start.</param>
        /// <param name="options">Optional options for the started process.</param>
        [<EmitConstructor>] abstract Create: ``process``: string * ?options: ProcessExecutionOptions -> ProcessExecution
        /// <summary>Creates a process execution.</summary>
        /// <param name="process">The process to start.</param>
        /// <param name="args">Arguments to be passed to the process.</param>
        /// <param name="options">Optional options for the started process.</param>
        [<EmitConstructor>] abstract Create: ``process``: string * args: ResizeArray<string> * ?options: ProcessExecutionOptions -> ProcessExecution

    /// The shell quoting options.
    type [<AllowNullLiteral>] ShellQuotingOptions =
        /// <summary>
        /// The character used to do character escaping. If a string is provided only spaces
        /// are escaped. If a <c>{ escapeChar, charsToEscape }</c> literal is provide all characters
        /// in <c>charsToEscape</c> are escaped using the <c>escapeChar</c>.
        /// </summary>
        abstract escape: U2<string, {| escapeChar: string; charsToEscape: string |}> option with get, set
        /// The character used for strong quoting. The string's length must be 1.
        abstract strong: string option with get, set
        /// The character used for weak quoting. The string's length must be 1.
        abstract weak: string option with get, set

    /// Options for a shell execution
    type [<AllowNullLiteral>] ShellExecutionOptions =
        /// The shell executable.
        abstract executable: string option with get, set
        /// <summary>
        /// The arguments to be passed to the shell executable used to run the task. Most shells
        /// require special arguments to execute a command. For  example <c>bash</c> requires the <c>-c</c>
        /// argument to execute a command, <c>PowerShell</c> requires <c>-Command</c> and <c>cmd</c> requires both
        /// <c>/d</c> and <c>/c</c>.
        /// </summary>
        abstract shellArgs: ResizeArray<string> option with get, set
        /// The shell quotes supported by this shell.
        abstract shellQuoting: ShellQuotingOptions option with get, set
        /// The current working directory of the executed shell.
        /// If omitted the tools current workspace root is used.
        abstract cwd: string option with get, set
        /// The additional environment of the executed shell. If omitted
        /// the parent process' environment is used. If provided it is merged with
        /// the parent process' environment.
        abstract env: {| Item: string |} option with get, set

    /// Defines how an argument should be quoted if it contains
    /// spaces or unsupported characters.
    type [<RequireQualifiedAccess>] ShellQuoting =
        /// Character escaping should be used. This for example
        /// uses \ on bash and ` on PowerShell.
        | Escape = 1
        /// <summary>
        /// Strong string quoting should be used. This for example
        /// uses " for Windows cmd and ' for bash and PowerShell.
        /// Strong quoting treats arguments as literal strings.
        /// Under PowerShell echo 'The value is $(2 * 3)' will
        /// print <c>The value is $(2 * 3)</c>
        /// </summary>
        | Strong = 2
        /// <summary>
        /// Weak string quoting should be used. This for example
        /// uses " for Windows cmd, bash and PowerShell. Weak quoting
        /// still performs some kind of evaluation inside the quoted
        /// string.  Under PowerShell echo "The value is $(2 * 3)"
        /// will print <c>The value is 6</c>
        /// </summary>
        | Weak = 3

    /// A string that will be quoted depending on the used shell.
    type [<AllowNullLiteral>] ShellQuotedString =
        /// The actual string value.
        abstract value: string with get, set
        /// The quoting style to use.
        abstract quoting: ShellQuoting with get, set

    type [<AllowNullLiteral>] ShellExecution =
        /// <summary>The shell command line. Is <c>undefined</c> if created with a command and arguments.</summary>
        abstract commandLine: string with get, set
        /// <summary>The shell command. Is <c>undefined</c> if created with a full command line.</summary>
        abstract command: U2<string, ShellQuotedString> with get, set
        /// <summary>The shell args. Is <c>undefined</c> if created with a full command line.</summary>
        abstract args: ResizeArray<U2<string, ShellQuotedString>> with get, set
        /// The shell options used when the command line is executed in a shell.
        /// Defaults to undefined.
        abstract options: ShellExecutionOptions option with get, set

    type [<AllowNullLiteral>] ShellExecutionStatic =
        /// <summary>Creates a shell execution with a full command line.</summary>
        /// <param name="commandLine">The command line to execute.</param>
        /// <param name="options">Optional options for the started the shell.</param>
        [<EmitConstructor>] abstract Create: commandLine: string * ?options: ShellExecutionOptions -> ShellExecution
        /// <summary>
        /// Creates a shell execution with a command and arguments. For the real execution VS Code will
        /// construct a command line from the command and the arguments. This is subject to interpretation
        /// especially when it comes to quoting. If full control over the command line is needed please
        /// use the constructor that creates a <c>ShellExecution</c> with the full command line.
        /// </summary>
        /// <param name="command">The command to execute.</param>
        /// <param name="args">The command arguments.</param>
        /// <param name="options">Optional options for the started the shell.</param>
        [<EmitConstructor>] abstract Create: command: U2<string, ShellQuotedString> * args: ResizeArray<U2<string, ShellQuotedString>> * ?options: ShellExecutionOptions -> ShellExecution

    /// The scope of a task.
    type [<RequireQualifiedAccess>] TaskScope =
        /// The task is a global task
        | Global = 1
        /// The task is a workspace task
        | Workspace = 2

    /// Run options for a task.
    type [<AllowNullLiteral>] RunOptions =
        /// Controls whether task variables are re-evaluated on rerun.
        abstract reevaluateOnRerun: bool option with get, set

    /// A task to execute
    type [<AllowNullLiteral>] Task =
        /// The task's definition.
        abstract definition: TaskDefinition with get, set
        /// The task's scope.
        abstract scope: U2<TaskScope, WorkspaceFolder> option
        /// The task's name
        abstract name: string with get, set
        /// The task's execution engine
        abstract execution: U2<ProcessExecution, ShellExecution> option with get, set
        /// Whether the task is a background task or not.
        abstract isBackground: bool with get, set
        /// A human-readable string describing the source of this
        /// shell task, e.g. 'gulp' or 'npm'.
        abstract source: string with get, set
        /// The task group this tasks belongs to. See TaskGroup
        /// for a predefined set of available groups.
        /// Defaults to undefined meaning that the task doesn't
        /// belong to any special group.
        abstract group: TaskGroup option with get, set
        /// The presentation options. Defaults to an empty literal.
        abstract presentationOptions: TaskPresentationOptions with get, set
        /// The problem matchers attached to the task. Defaults to an empty
        /// array.
        abstract problemMatchers: ResizeArray<string> with get, set
        /// Run options for the task
        abstract runOptions: RunOptions with get, set

    /// A task to execute
    type [<AllowNullLiteral>] TaskStatic =
        /// <summary>Creates a new task.</summary>
        /// <param name="definition">The task definition as defined in the taskDefinitions extension point.</param>
        /// <param name="scope">Specifies the task's scope. It is either a global or a workspace task or a task for a specific workspace folder.</param>
        /// <param name="name">The task's name. Is presented in the user interface.</param>
        /// <param name="source">The task's source (e.g. 'gulp', 'npm', ...). Is presented in the user interface.</param>
        /// <param name="execution">The process or shell execution.</param>
        /// <param name="problemMatchers">
        /// the names of problem matchers to use, like '$tsc'
        /// or '$eslint'. Problem matchers can be contributed by an extension using
        /// the <c>problemMatchers</c> extension point.
        /// </param>
        [<EmitConstructor>] abstract Create: taskDefinition: TaskDefinition * scope: U2<WorkspaceFolder, TaskScope> * name: string * source: string * ?execution: U2<ProcessExecution, ShellExecution> * ?problemMatchers: U2<string, ResizeArray<string>> -> Task
        /// <summary>~~Creates a new task.~~</summary>
        /// <param name="definition">The task definition as defined in the taskDefinitions extension point.</param>
        /// <param name="name">The task's name. Is presented in the user interface.</param>
        /// <param name="source">The task's source (e.g. 'gulp', 'npm', ...). Is presented in the user interface.</param>
        /// <param name="execution">The process or shell execution.</param>
        /// <param name="problemMatchers">
        /// the names of problem matchers to use, like '$tsc'
        /// or '$eslint'. Problem matchers can be contributed by an extension using
        /// the <c>problemMatchers</c> extension point.
        /// </param>
        [<Obsolete("Use the new constructors that allow specifying a scope for the task.")>]
        [<EmitConstructor>] abstract Create: taskDefinition: TaskDefinition * name: string * source: string * ?execution: U2<ProcessExecution, ShellExecution> * ?problemMatchers: U2<string, ResizeArray<string>> -> Task

    /// A task provider allows to add tasks to the task service.
    /// A task provider is registered via #tasks.registerTaskProvider.
    type [<AllowNullLiteral>] TaskProvider =
        /// <summary>Provides tasks.</summary>
        /// <param name="token">A cancellation token.</param>
        /// <returns>an array of tasks</returns>
        abstract provideTasks: ?token: CancellationToken -> ProviderResult<ResizeArray<Task>>
        /// <summary>
        /// Resolves a task that has no <see cref="Task.execution"><c>execution</c></see> set. Tasks are
        /// often created from information found in the <c>tasks.json</c>-file. Such tasks miss
        /// the information on how to execute them and a task provider must fill in
        /// the missing information in the <c>resolveTask</c>-method. This method will not be
        /// called for tasks returned from the above <c>provideTasks</c> method since those
        /// tasks are always fully resolved. A valid default implementation for the
        /// <c>resolveTask</c> method is to return <c>undefined</c>.
        /// </summary>
        /// <param name="task">The task to resolve.</param>
        /// <param name="token">A cancellation token.</param>
        /// <returns>The resolved task</returns>
        abstract resolveTask: task: Task * ?token: CancellationToken -> ProviderResult<Task>

    /// An object representing an executed Task. It can be used
    /// to terminate a task.
    /// 
    /// This interface is not intended to be implemented.
    type [<AllowNullLiteral>] TaskExecution =
        /// The task that got started.
        abstract task: Task with get, set
        /// Terminates the task execution.
        abstract terminate: unit -> unit

    /// An event signaling the start of a task execution.
    /// 
    /// This interface is not intended to be implemented.
    type [<AllowNullLiteral>] TaskStartEvent =
        /// The task item representing the task that got started.
        abstract execution: TaskExecution with get, set

    /// An event signaling the end of an executed task.
    /// 
    /// This interface is not intended to be implemented.
    type [<AllowNullLiteral>] TaskEndEvent =
        /// The task item representing the task that finished.
        abstract execution: TaskExecution with get, set

    /// An event signaling the start of a process execution
    /// triggered through a task
    type [<AllowNullLiteral>] TaskProcessStartEvent =
        /// The task execution for which the process got started.
        abstract execution: TaskExecution with get, set
        /// The underlying process id.
        abstract processId: float with get, set

    /// An event signaling the end of a process execution
    /// triggered through a task
    type [<AllowNullLiteral>] TaskProcessEndEvent =
        /// The task execution for which the process got started.
        abstract execution: TaskExecution with get, set
        /// The process's exit code.
        abstract exitCode: float with get, set

    type [<AllowNullLiteral>] TaskFilter =
        /// The task version as used in the tasks.json file.
        /// The string support the package.json semver notation.
        abstract version: string option with get, set
        /// The task type to return;
        abstract ``type``: string option with get, set

    /// Namespace for tasks functionality.
    module Tasks =

        type [<AllowNullLiteral>] IExports =
            /// <summary>Register a task provider.</summary>
            /// <param name="type">The task kind type this provider is registered for.</param>
            /// <param name="provider">A task provider.</param>
            /// <returns>A <see cref="Disposable">disposable</see> that unregisters this provider when being disposed.</returns>
            abstract registerTaskProvider: ``type``: string * provider: TaskProvider -> Disposable
            /// <summary>
            /// Fetches all tasks available in the systems. This includes tasks
            /// from <c>tasks.json</c> files as well as tasks from task providers
            /// contributed through extensions.
            /// </summary>
            /// <param name="filter">a filter to filter the return tasks.</param>
            abstract fetchTasks: ?filter: TaskFilter -> Thenable<ResizeArray<Task>>
            /// <summary>
            /// Executes a task that is managed by VS Code. The returned
            /// task execution can be used to terminate the task.
            /// </summary>
            /// <param name="task">the task to execute</param>
            abstract executeTask: task: Task -> Thenable<TaskExecution>
            /// The currently active task executions or an empty array.
            abstract taskExecutions: ReadonlyArray<TaskExecution>
            /// Fires when a task starts.
            abstract onDidStartTask: Event<TaskStartEvent>
            /// Fires when a task ends.
            abstract onDidEndTask: Event<TaskEndEvent>
            /// Fires when the underlying process has been started.
            /// This event will not fire for tasks that don't
            /// execute an underlying process.
            abstract onDidStartTaskProcess: Event<TaskProcessStartEvent>
            /// Fires when the underlying process has ended.
            /// This event will not fire for tasks that don't
            /// execute an underlying process.
            abstract onDidEndTaskProcess: Event<TaskProcessEndEvent>

    /// <summary>
    /// Enumeration of file types. The types <c>File</c> and <c>Directory</c> can also be
    /// a symbolic links, in that use <c>FileType.File | FileType.SymbolicLink</c> and
    /// <c>FileType.Directory | FileType.SymbolicLink</c>.
    /// </summary>
    type [<RequireQualifiedAccess>] FileType =
        /// The file type is unknown.
        | Unknown = 0
        /// A regular file.
        | File = 1
        /// A directory.
        | Directory = 2
        /// A symbolic link to a file.
        | SymbolicLink = 64

    /// <summary>The <c>FileStat</c>-type represents metadata about a file</summary>
    type [<AllowNullLiteral>] FileStat =
        /// The type of the file, e.g. is a regular file, a directory, or symbolic link
        /// to a file.
        abstract ``type``: FileType with get, set
        /// The creation timestamp in milliseconds elapsed since January 1, 1970 00:00:00 UTC.
        abstract ctime: float with get, set
        /// The modification timestamp in milliseconds elapsed since January 1, 1970 00:00:00 UTC.
        abstract mtime: float with get, set
        /// The size in bytes.
        abstract size: float with get, set

    /// <summary>
    /// A type that filesystem providers should use to signal errors.
    /// 
    /// This class has factory methods for common error-cases, like <c>EntryNotFound</c> when
    /// a file or folder doesn't exist, use them like so: <c>throw vscode.FileSystemError.EntryNotFound(someUri);</c>
    /// </summary>
    type [<AllowNullLiteral>] FileSystemError =
        inherit Error

    /// <summary>
    /// A type that filesystem providers should use to signal errors.
    /// 
    /// This class has factory methods for common error-cases, like <c>EntryNotFound</c> when
    /// a file or folder doesn't exist, use them like so: <c>throw vscode.FileSystemError.EntryNotFound(someUri);</c>
    /// </summary>
    type [<AllowNullLiteral>] FileSystemErrorStatic =
        /// <summary>Create an error to signal that a file or folder wasn't found.</summary>
        /// <param name="messageOrUri">Message or uri.</param>
        abstract FileNotFound: ?messageOrUri: U2<string, Uri> -> FileSystemError
        /// <summary>
        /// Create an error to signal that a file or folder already exists, e.g. when
        /// creating but not overwriting a file.
        /// </summary>
        /// <param name="messageOrUri">Message or uri.</param>
        abstract FileExists: ?messageOrUri: U2<string, Uri> -> FileSystemError
        /// <summary>Create an error to signal that a file is not a folder.</summary>
        /// <param name="messageOrUri">Message or uri.</param>
        abstract FileNotADirectory: ?messageOrUri: U2<string, Uri> -> FileSystemError
        /// <summary>Create an error to signal that a file is a folder.</summary>
        /// <param name="messageOrUri">Message or uri.</param>
        abstract FileIsADirectory: ?messageOrUri: U2<string, Uri> -> FileSystemError
        /// <summary>Create an error to signal that an operation lacks required permissions.</summary>
        /// <param name="messageOrUri">Message or uri.</param>
        abstract NoPermissions: ?messageOrUri: U2<string, Uri> -> FileSystemError
        /// <summary>
        /// Create an error to signal that the file system is unavailable or too busy to
        /// complete a request.
        /// </summary>
        /// <param name="messageOrUri">Message or uri.</param>
        abstract Unavailable: ?messageOrUri: U2<string, Uri> -> FileSystemError
        /// <summary>Creates a new filesystem error.</summary>
        /// <param name="messageOrUri">Message or uri.</param>
        [<EmitConstructor>] abstract Create: ?messageOrUri: U2<string, Uri> -> FileSystemError

    /// Enumeration of file change types.
    type [<RequireQualifiedAccess>] FileChangeType =
        /// The contents or metadata of a file have changed.
        | Changed = 1
        /// A file has been created.
        | Created = 2
        /// A file has been deleted.
        | Deleted = 3

    /// The event filesystem providers must use to signal a file change.
    type [<AllowNullLiteral>] FileChangeEvent =
        /// The type of change.
        abstract ``type``: FileChangeType with get, set
        /// The uri of the file that has changed.
        abstract uri: Uri with get, set

    /// <summary>
    /// The filesystem provider defines what the editor needs to read, write, discover,
    /// and to manage files and folders. It allows extensions to serve files from remote places,
    /// like ftp-servers, and to seamlessly integrate those into the editor.
    /// 
    /// * *Note 1:* The filesystem provider API works with <see cref="Uri">uris</see> and assumes hierarchical
    /// paths, e.g. <c>foo:/my/path</c> is a child of <c>foo:/my/</c> and a parent of <c>foo:/my/path/deeper</c>.
    /// * *Note 2:* There is an activation event <c>onFileSystem:<scheme></c> that fires when a file
    /// or folder is being accessed.
    /// * *Note 3:* The word 'file' is often used to denote all <see cref="FileType">kinds</see> of files, e.g.
    /// folders, symbolic links, and regular files.
    /// </summary>
    type [<AllowNullLiteral>] FileSystemProvider =
        /// <summary>
        /// An event to signal that a resource has been created, changed, or deleted. This
        /// event should fire for resources that are being <see cref="FileSystemProvider.watch">watched</see>
        /// by clients of this provider.
        /// </summary>
        abstract onDidChangeFile: Event<ResizeArray<FileChangeEvent>>
        /// <summary>
        /// Subscribe to events in the file or folder denoted by <c>uri</c>.
        /// 
        /// The editor will call this function for files and folders. In the latter case, the
        /// options differ from defaults, e.g. what files/folders to exclude from watching
        /// and if subfolders, sub-subfolder, etc. should be watched (<c>recursive</c>).
        /// </summary>
        /// <param name="uri">The uri of the file to be watched.</param>
        /// <param name="options">Configures the watch.</param>
        /// <returns>A disposable that tells the provider to stop watching the <c>uri</c>.</returns>
        abstract watch: uri: Uri * options: {| recursive: bool; excludes: ResizeArray<string> |} -> Disposable
        /// <summary>
        /// Retrieve metadata about a file.
        /// 
        /// Note that the metadata for symbolic links should be the metadata of the file they refer to.
        /// Still, the <see cref="FileType.SymbolicLink">SymbolicLink</see>-type must be used in addition to the actual type, e.g.
        /// <c>FileType.SymbolicLink | FileType.Directory</c>.
        /// </summary>
        /// <param name="uri">The uri of the file to retrieve metadata about.</param>
        /// <returns>The file metadata about the file.</returns>
        /// <exception cref=""><see cref="FileSystemError.FileNotFound"><c>FileNotFound</c></see> when <c>uri</c> doesn't exist.</exception>
        abstract stat: uri: Uri -> U2<FileStat, Thenable<FileStat>>
        /// <summary>Retrieve all entries of a <see cref="FileType.Directory">directory</see>.</summary>
        /// <param name="uri">The uri of the folder.</param>
        /// <returns>An array of name/type-tuples or a thenable that resolves to such.</returns>
        /// <exception cref=""><see cref="FileSystemError.FileNotFound"><c>FileNotFound</c></see> when <c>uri</c> doesn't exist.</exception>
        abstract readDirectory: uri: Uri -> U2<ResizeArray<string * FileType>, Thenable<ResizeArray<string * FileType>>>
        /// <summary>Create a new directory (Note, that new files are created via <c>write</c>-calls).</summary>
        /// <param name="uri">The uri of the new folder.</param>
        /// <exception cref=""><see cref="FileSystemError.FileNotFound"><c>FileNotFound</c></see> when the parent of <c>uri</c> doesn't exist, e.g. no mkdirp-logic required.</exception>
        /// <exception cref=""><see cref="FileSystemError.FileExists"><c>FileExists</c></see> when <c>uri</c> already exists.</exception>
        /// <exception cref=""><see cref="FileSystemError.NoPermissions"><c>NoPermissions</c></see> when permissions aren't sufficient.</exception>
        abstract createDirectory: uri: Uri -> U2<unit, Thenable<unit>>
        /// <summary>Read the entire contents of a file.</summary>
        /// <param name="uri">The uri of the file.</param>
        /// <returns>An array of bytes or a thenable that resolves to such.</returns>
        /// <exception cref=""><see cref="FileSystemError.FileNotFound"><c>FileNotFound</c></see> when <c>uri</c> doesn't exist.</exception>
        abstract readFile: uri: Uri -> U2<Uint8Array, Thenable<Uint8Array>>
        /// <summary>Write data to a file, replacing its entire contents.</summary>
        /// <param name="uri">The uri of the file.</param>
        /// <param name="content">The new content of the file.</param>
        /// <param name="options">Defines if missing files should or must be created.</param>
        /// <exception cref=""><see cref="FileSystemError.FileNotFound"><c>FileNotFound</c></see> when <c>uri</c> doesn't exist and <c>create</c> is not set.</exception>
        /// <exception cref=""><see cref="FileSystemError.FileNotFound"><c>FileNotFound</c></see> when the parent of <c>uri</c> doesn't exist and <c>create</c> is set, e.g. no mkdirp-logic required.</exception>
        /// <exception cref=""><see cref="FileSystemError.FileExists"><c>FileExists</c></see> when <c>uri</c> already exists, <c>create</c> is set but <c>overwrite</c> is not set.</exception>
        /// <exception cref=""><see cref="FileSystemError.NoPermissions"><c>NoPermissions</c></see> when permissions aren't sufficient.</exception>
        abstract writeFile: uri: Uri * content: Uint8Array * options: {| create: bool; overwrite: bool |} -> U2<unit, Thenable<unit>>
        /// <summary>Delete a file.</summary>
        /// <param name="uri">The resource that is to be deleted.</param>
        /// <param name="options">Defines if deletion of folders is recursive.</param>
        /// <exception cref=""><see cref="FileSystemError.FileNotFound"><c>FileNotFound</c></see> when <c>uri</c> doesn't exist.</exception>
        /// <exception cref=""><see cref="FileSystemError.NoPermissions"><c>NoPermissions</c></see> when permissions aren't sufficient.</exception>
        abstract delete: uri: Uri * options: {| recursive: bool |} -> U2<unit, Thenable<unit>>
        /// <summary>Rename a file or folder.</summary>
        /// <param name="oldUri">The existing file.</param>
        /// <param name="newUri">The new location.</param>
        /// <param name="options">Defines if existing files should be overwritten.</param>
        /// <exception cref=""><see cref="FileSystemError.FileNotFound"><c>FileNotFound</c></see> when <c>oldUri</c> doesn't exist.</exception>
        /// <exception cref=""><see cref="FileSystemError.FileNotFound"><c>FileNotFound</c></see> when parent of <c>newUri</c> doesn't exist, e.g. no mkdirp-logic required.</exception>
        /// <exception cref=""><see cref="FileSystemError.FileExists"><c>FileExists</c></see> when <c>newUri</c> exists and when the <c>overwrite</c> option is not <c>true</c>.</exception>
        /// <exception cref=""><see cref="FileSystemError.NoPermissions"><c>NoPermissions</c></see> when permissions aren't sufficient.</exception>
        abstract rename: oldUri: Uri * newUri: Uri * options: {| overwrite: bool |} -> U2<unit, Thenable<unit>>
        /// <summary>
        /// Copy files or folders. Implementing this function is optional but it will speedup
        /// the copy operation.
        /// </summary>
        /// <param name="source">The existing file.</param>
        /// <param name="destination">The destination location.</param>
        /// <param name="options">Defines if existing files should be overwritten.</param>
        /// <exception cref=""><see cref="FileSystemError.FileNotFound"><c>FileNotFound</c></see> when <c>source</c> doesn't exist.</exception>
        /// <exception cref=""><see cref="FileSystemError.FileNotFound"><c>FileNotFound</c></see> when parent of <c>destination</c> doesn't exist, e.g. no mkdirp-logic required.</exception>
        /// <exception cref=""><see cref="FileSystemError.FileExists"><c>FileExists</c></see> when <c>destination</c> exists and when the <c>overwrite</c> option is not <c>true</c>.</exception>
        /// <exception cref=""><see cref="FileSystemError.NoPermissions"><c>NoPermissions</c></see> when permissions aren't sufficient.</exception>
        abstract copy: source: Uri * destination: Uri * options: {| overwrite: bool |} -> U2<unit, Thenable<unit>>

    /// Content settings for a webview.
    type [<AllowNullLiteral>] WebviewOptions =
        /// Controls whether scripts are enabled in the webview content or not.
        /// 
        /// Defaults to false (scripts-disabled).
        abstract enableScripts: bool option
        /// Controls whether command uris are enabled in webview content or not.
        /// 
        /// Defaults to false.
        abstract enableCommandUris: bool option
        /// <summary>
        /// Root paths from which the webview can load local (filesystem) resources using the <c>vscode-resource:</c> scheme.
        /// 
        /// Default to the root folders of the current workspace plus the extension's install directory.
        /// 
        /// Pass in an empty array to disallow access to any local resources.
        /// </summary>
        abstract localResourceRoots: ReadonlyArray<Uri> option

    /// A webview displays html content, like an iframe.
    type [<AllowNullLiteral>] Webview =
        /// Content settings for the webview.
        abstract options: WebviewOptions with get, set
        /// Contents of the webview.
        /// 
        /// Should be a complete html document.
        abstract html: string with get, set
        /// Fired when the webview content posts a message.
        abstract onDidReceiveMessage: Event<obj option>
        /// <summary>
        /// Post a message to the webview content.
        /// 
        /// Messages are only delivered if the webview is visible.
        /// </summary>
        /// <param name="message">Body of the message.</param>
        abstract postMessage: message: obj option -> Thenable<bool>

    /// Content settings for a webview panel.
    type [<AllowNullLiteral>] WebviewPanelOptions =
        /// Controls if the find widget is enabled in the panel.
        /// 
        /// Defaults to false.
        abstract enableFindWidget: bool option
        /// <summary>
        /// Controls if the webview panel's content (iframe) is kept around even when the panel
        /// is no longer visible.
        /// 
        /// Normally the webview panel's html context is created when the panel becomes visible
        /// and destroyed when it is hidden. Extensions that have complex state
        /// or UI can set the <c>retainContextWhenHidden</c> to make VS Code keep the webview
        /// context around, even when the webview moves to a background tab. When a webview using
        /// <c>retainContextWhenHidden</c> becomes hidden, its scripts and other dynamic content are suspended.
        /// When the panel becomes visible again, the context is automatically restored
        /// in the exact same state it was in originally. You cannot send messages to a
        /// hidden webview, even with <c>retainContextWhenHidden</c> enabled.
        /// 
        /// <c>retainContextWhenHidden</c> has a high memory overhead and should only be used if
        /// your panel's context cannot be quickly saved and restored.
        /// </summary>
        abstract retainContextWhenHidden: bool option

    /// A panel that contains a webview.
    type [<AllowNullLiteral>] WebviewPanel =
        /// <summary>Identifies the type of the webview panel, such as <c>'markdown.preview'</c>.</summary>
        abstract viewType: string
        /// Title of the panel shown in UI.
        abstract title: string with get, set
        /// Icon for the panel shown in UI.
        abstract iconPath: U2<Uri, {| light: Uri; dark: Uri |}> option with get, set
        /// Webview belonging to the panel.
        abstract webview: Webview
        /// Content settings for the webview panel.
        abstract options: WebviewPanelOptions
        /// Editor position of the panel. This property is only set if the webview is in
        /// one of the editor view columns.
        abstract viewColumn: ViewColumn option
        /// Whether the panel is active (focused by the user).
        abstract active: bool
        /// Whether the panel is visible.
        abstract visible: bool
        /// Fired when the panel's view state changes.
        abstract onDidChangeViewState: Event<WebviewPanelOnDidChangeViewStateEvent>
        /// <summary>
        /// Fired when the panel is disposed.
        /// 
        /// This may be because the user closed the panel or because <c>.dispose()</c> was
        /// called on it.
        /// 
        /// Trying to use the panel after it has been disposed throws an exception.
        /// </summary>
        abstract onDidDispose: Event<unit>
        /// <summary>
        /// Show the webview panel in a given column.
        /// 
        /// A webview panel may only show in a single column at a time. If it is already showing, this
        /// method moves it to a new column.
        /// </summary>
        /// <param name="viewColumn">View column to show the panel in. Shows in the current <c>viewColumn</c> if undefined.</param>
        /// <param name="preserveFocus">When <c>true</c>, the webview will not take focus.</param>
        abstract reveal: ?viewColumn: ViewColumn * ?preserveFocus: bool -> unit
        /// <summary>
        /// Dispose of the webview panel.
        /// 
        /// This closes the panel if it showing and disposes of the resources owned by the webview.
        /// Webview panels are also disposed when the user closes the webview panel. Both cases
        /// fire the <c>onDispose</c> event.
        /// </summary>
        abstract dispose: unit -> obj option

    /// Event fired when a webview panel's view state changes.
    type [<AllowNullLiteral>] WebviewPanelOnDidChangeViewStateEvent =
        /// Webview panel whose view state changed.
        abstract webviewPanel: WebviewPanel

    /// <summary>
    /// Restore webview panels that have been persisted when vscode shuts down.
    /// 
    /// There are two types of webview persistence:
    /// 
    /// - Persistence within a session.
    /// - Persistence across sessions (across restarts of VS Code).
    /// 
    /// A <c>WebviewPanelSerializer</c> is only required for the second case: persisting a webview across sessions.
    /// 
    /// Persistence within a session allows a webview to save its state when it becomes hidden
    /// and restore its content from this state when it becomes visible again. It is powered entirely
    /// by the webview content itself. To save off a persisted state, call <c>acquireVsCodeApi().setState()</c> with
    /// any json serializable object. To restore the state again, call <c>getState()</c>
    /// 
    /// <code language="js">
    /// // Within the webview
    /// const vscode = acquireVsCodeApi();
    /// 
    /// // Get existing state
    /// const oldState = vscode.getState() || { value: 0 };
    /// 
    /// // Update state
    /// setState({ value: oldState.value + 1 })
    /// </code>
    /// 
    /// A <c>WebviewPanelSerializer</c> extends this persistence across restarts of VS Code. When the editor is shutdown,
    /// VS Code will save off the state from <c>setState</c> of all webviews that have a serializer. When the
    /// webview first becomes visible after the restart, this state is passed to <c>deserializeWebviewPanel</c>.
    /// The extension can then restore the old <c>WebviewPanel</c> from this state.
    /// </summary>
    type [<AllowNullLiteral>] WebviewPanelSerializer =
        /// <summary>
        /// Restore a webview panel from its serialized <c>state</c>.
        /// 
        /// Called when a serialized webview first becomes visible.
        /// </summary>
        /// <param name="webviewPanel">
        /// Webview panel to restore. The serializer should take ownership of this panel. The
        /// serializer must restore the webview's <c>.html</c> and hook up all webview events.
        /// </param>
        /// <param name="state">Persisted state from the webview content.</param>
        /// <returns>Thenble indicating that the webview has been fully restored.</returns>
        abstract deserializeWebviewPanel: webviewPanel: WebviewPanel * state: obj option -> Thenable<unit>

    /// The clipboard provides read and write access to the system's clipboard.
    type [<AllowNullLiteral>] Clipboard =
        /// <summary>Read the current clipboard contents as text.</summary>
        /// <returns>A thenable that resolves to a string.</returns>
        abstract readText: unit -> Thenable<string>
        /// <summary>Writes text into the clipboard.</summary>
        /// <returns>A thenable that resolves when writing happened.</returns>
        abstract writeText: value: string -> Thenable<unit>

    /// Namespace describing the environment the editor runs in.
    module Env =

        type [<AllowNullLiteral>] IExports =
            /// The application name of the editor, like 'VS Code'.
            abstract appName: string
            /// The application root folder from which the editor is running.
            abstract appRoot: string
            /// <summary>Represents the preferred user-language, like <c>de-CH</c>, <c>fr</c>, or <c>en-US</c>.</summary>
            abstract language: string
            /// The system clipboard.
            abstract clipboard: Clipboard
            /// A unique identifier for the computer.
            abstract machineId: string
            /// A unique identifier for the current session.
            /// Changes each time the editor is started.
            abstract sessionId: string
            /// <summary>
            /// Opens an *external* item, e.g. a http(s) or mailto-link, using the
            /// default application.
            /// 
            /// *Note* that <see cref="window.showTextDocument"><c>showTextDocument</c></see> is the right
            /// way to open a text document inside the editor, not this function.
            /// </summary>
            /// <param name="target">The uri that should be opened.</param>
            /// <returns>A promise indicating if open was successful.</returns>
            abstract openExternal: target: Uri -> Thenable<bool>

    /// <summary>
    /// Namespace for dealing with commands. In short, a command is a function with a
    /// unique identifier. The function is sometimes also called _command handler_.
    /// 
    /// Commands can be added to the editor using the <see cref="commands.registerCommand">registerCommand</see>
    /// and <see cref="commands.registerTextEditorCommand">registerTextEditorCommand</see> functions. Commands
    /// can be executed <see cref="commands.executeCommand">manually</see> or from a UI gesture. Those are:
    /// 
    /// * palette - Use the <c>commands</c>-section in <c>package.json</c> to make a command show in
    /// the <see href="https://code.visualstudio.com/docs/getstarted/userinterface#_command-palette">command palette</see>.
    /// * keybinding - Use the <c>keybindings</c>-section in <c>package.json</c> to enable
    /// <see href="https://code.visualstudio.com/docs/getstarted/keybindings#_customizing-shortcuts">keybindings</see>
    /// for your extension.
    /// 
    /// Commands from other extensions and from the editor itself are accessible to an extension. However,
    /// when invoking an editor command not all argument types are supported.
    /// 
    /// This is a sample that registers a command handler and adds an entry for that command to the palette. First
    /// register a command handler with the identifier <c>extension.sayHello</c>.
    /// <code language="javascript">
    /// commands.registerCommand('extension.sayHello', () => {
    ///  	window.showInformationMessage('Hello World!');
    /// });
    /// </code>
    /// Second, bind the command identifier to a title under which it will show in the palette (<c>package.json</c>).
    /// <code language="json">
    /// {
    ///  	"contributes": {
    ///  		"commands": [{
    ///  			"command": "extension.sayHello",
    ///  			"title": "Hello World"
    ///  		}]
    ///  	}
    /// }
    /// </code>
    /// </summary>
    module Commands =

        type [<AllowNullLiteral>] IExports =
            /// <summary>
            /// Registers a command that can be invoked via a keyboard shortcut,
            /// a menu item, an action, or directly.
            /// 
            /// Registering a command with an existing command identifier twice
            /// will cause an error.
            /// </summary>
            /// <param name="command">A unique identifier for the command.</param>
            /// <param name="callback">A command handler function.</param>
            /// <param name="thisArg">The <c>this</c> context used when invoking the handler function.</param>
            /// <returns>Disposable which unregisters this command on disposal.</returns>
            abstract registerCommand: command: string * callback: (ResizeArray<obj option> -> obj option) * ?thisArg: obj -> Disposable
            /// <summary>
            /// Registers a text editor command that can be invoked via a keyboard shortcut,
            /// a menu item, an action, or directly.
            /// 
            /// Text editor commands are different from ordinary <see cref="commands.registerCommand">commands</see> as
            /// they only execute when there is an active editor when the command is called. Also, the
            /// command handler of an editor command has access to the active editor and to an
            /// <see cref="TextEditorEdit">edit</see>-builder.
            /// </summary>
            /// <param name="command">A unique identifier for the command.</param>
            /// <param name="callback">A command handler function with access to an <see cref="TextEditor">editor</see> and an <see cref="TextEditorEdit">edit</see>.</param>
            /// <param name="thisArg">The <c>this</c> context used when invoking the handler function.</param>
            /// <returns>Disposable which unregisters this command on disposal.</returns>
            abstract registerTextEditorCommand: command: string * callback: (TextEditor -> TextEditorEdit -> ResizeArray<obj option> -> unit) * ?thisArg: obj -> Disposable
            /// <summary>
            /// Executes the command denoted by the given command identifier.
            /// 
            /// * *Note 1:* When executing an editor command not all types are allowed to
            /// be passed as arguments. Allowed are the primitive types <c>string</c>, <c>boolean</c>,
            /// <c>number</c>, <c>undefined</c>, and <c>null</c>, as well as <see cref="Position"><c>Position</c></see>, <see cref="Range"><c>Range</c></see>, <see cref="Uri"><c>Uri</c></see> and <see cref="Location"><c>Location</c></see>.
            /// * *Note 2:* There are no restrictions when executing commands that have been contributed
            /// by extensions.
            /// </summary>
            /// <param name="command">Identifier of the command to execute.</param>
            /// <param name="rest">Parameters passed to the command function.</param>
            /// <returns>
            /// A thenable that resolves to the returned value of the given command. <c>undefined</c> when
            /// the command handler function doesn't return anything.
            /// </returns>
            abstract executeCommand: command: string * [<ParamArray>] rest: obj option[] -> Thenable<'T option>
            /// <summary>
            /// Retrieve the list of all available commands. Commands starting an underscore are
            /// treated as internal commands.
            /// </summary>
            /// <param name="filterInternal">Set <c>true</c> to not see internal commands (starting with an underscore)</param>
            /// <returns>Thenable that resolves to a list of command ids.</returns>
            abstract getCommands: ?filterInternal: bool -> Thenable<ResizeArray<string>>

    /// Represents the state of a window.
    type [<AllowNullLiteral>] WindowState =
        /// Whether the current window is focused.
        abstract focused: bool

    /// <summary>A uri handler is responsible for handling system-wide <see cref="Uri">uris</see>.</summary>
    /// <seealso cref="window.registerUriHandler">window.registerUriHandler .</seealso>
    type [<AllowNullLiteral>] UriHandler =
        /// <summary>Handle the provided system-wide <see cref="Uri">uri</see>.</summary>
        /// <seealso cref="window.registerUriHandler">window.registerUriHandler .</seealso>
        abstract handleUri: uri: Uri -> ProviderResult<unit>

    /// Namespace for dealing with the current window of the editor. That is visible
    /// and active editors, as well as, UI elements to show messages, selections, and
    /// asking for user input.
    module Window =

        type [<AllowNullLiteral>] IExports =
            /// <summary>
            /// The currently active editor or <c>undefined</c>. The active editor is the one
            /// that currently has focus or, when none has focus, the one that has changed
            /// input most recently.
            /// </summary>
            abstract activeTextEditor: TextEditor option with get, set
            /// The currently visible editors or an empty array.
            abstract visibleTextEditors: ResizeArray<TextEditor> with get, set
            /// <summary>
            /// An <see cref="Event">event</see> which fires when the <see cref="window.activeTextEditor">active editor</see>
            /// has changed. *Note* that the event also fires when the active editor changes
            /// to <c>undefined</c>.
            /// </summary>
            abstract onDidChangeActiveTextEditor: Event<TextEditor option>
            /// <summary>
            /// An <see cref="Event">event</see> which fires when the array of <see cref="window.visibleTextEditors">visible editors</see>
            /// has changed.
            /// </summary>
            abstract onDidChangeVisibleTextEditors: Event<ResizeArray<TextEditor>>
            /// <summary>An <see cref="Event">event</see> which fires when the selection in an editor has changed.</summary>
            abstract onDidChangeTextEditorSelection: Event<TextEditorSelectionChangeEvent>
            /// <summary>An <see cref="Event">event</see> which fires when the visible ranges of an editor has changed.</summary>
            abstract onDidChangeTextEditorVisibleRanges: Event<TextEditorVisibleRangesChangeEvent>
            /// <summary>An <see cref="Event">event</see> which fires when the options of an editor have changed.</summary>
            abstract onDidChangeTextEditorOptions: Event<TextEditorOptionsChangeEvent>
            /// <summary>An <see cref="Event">event</see> which fires when the view column of an editor has changed.</summary>
            abstract onDidChangeTextEditorViewColumn: Event<TextEditorViewColumnChangeEvent>
            /// The currently opened terminals or an empty array.
            abstract terminals: ReadonlyArray<Terminal>
            /// <summary>
            /// The currently active terminal or <c>undefined</c>. The active terminal is the one that
            /// currently has focus or most recently had focus.
            /// </summary>
            abstract activeTerminal: Terminal option
            /// <summary>
            /// An <see cref="Event">event</see> which fires when the <see cref="window.activeTerminal">active terminal</see>
            /// has changed. *Note* that the event also fires when the active terminal changes
            /// to <c>undefined</c>.
            /// </summary>
            abstract onDidChangeActiveTerminal: Event<Terminal option>
            /// <summary>
            /// An <see cref="Event">event</see> which fires when a terminal has been created, either through the
            /// <see cref="window.createTerminal">createTerminal</see> API or commands.
            /// </summary>
            abstract onDidOpenTerminal: Event<Terminal>
            /// <summary>An <see cref="Event">event</see> which fires when a terminal is disposed.</summary>
            abstract onDidCloseTerminal: Event<Terminal>
            /// Represents the current window's state.
            abstract state: WindowState
            /// <summary>
            /// An <see cref="Event">event</see> which fires when the focus state of the current window
            /// changes. The value of the event represents whether the window is focused.
            /// </summary>
            abstract onDidChangeWindowState: Event<WindowState>
            /// <summary>
            /// Show the given document in a text editor. A <see cref="ViewColumn">column</see> can be provided
            /// to control where the editor is being shown. Might change the <see cref="window.activeTextEditor">active editor</see>.
            /// </summary>
            /// <param name="document">A text document to be shown.</param>
            /// <param name="column">
            /// A view column in which the <see cref="TextEditor">editor</see> should be shown. The default is the <see cref="ViewColumn.Active">active</see>, other values
            /// are adjusted to be <c>Min(column, columnCount + 1)</c>, the <see cref="ViewColumn.Active">active</see>-column is not adjusted. Use <see cref="ViewColumn.Beside"><c>ViewColumn.Beside</c></see>
            /// to open the editor to the side of the currently active one.
            /// </param>
            /// <param name="preserveFocus">When <c>true</c> the editor will not take focus.</param>
            /// <returns>A promise that resolves to an <see cref="TextEditor">editor</see>.</returns>
            abstract showTextDocument: document: TextDocument * ?column: ViewColumn * ?preserveFocus: bool -> Thenable<TextEditor>
            /// <summary>
            /// Show the given document in a text editor. <see cref="TextDocumentShowOptions">Options</see> can be provided
            /// to control options of the editor is being shown. Might change the <see cref="window.activeTextEditor">active editor</see>.
            /// </summary>
            /// <param name="document">A text document to be shown.</param>
            /// <param name="options"><see cref="TextDocumentShowOptions">Editor options</see> to configure the behavior of showing the <see cref="TextEditor">editor</see>.</param>
            /// <returns>A promise that resolves to an <see cref="TextEditor">editor</see>.</returns>
            abstract showTextDocument: document: TextDocument * ?options: TextDocumentShowOptions -> Thenable<TextEditor>
            /// <summary>A short-hand for <c>openTextDocument(uri).then(document => showTextDocument(document, options))</c>.</summary>
            /// <seealso cref="openTextDocument">openTextDocument</seealso>
            /// <param name="uri">A resource identifier.</param>
            /// <param name="options"><see cref="TextDocumentShowOptions">Editor options</see> to configure the behavior of showing the <see cref="TextEditor">editor</see>.</param>
            /// <returns>A promise that resolves to an <see cref="TextEditor">editor</see>.</returns>
            abstract showTextDocument: uri: Uri * ?options: TextDocumentShowOptions -> Thenable<TextEditor>
            /// <summary>Create a TextEditorDecorationType that can be used to add decorations to text editors.</summary>
            /// <param name="options">Rendering options for the decoration type.</param>
            /// <returns>A new decoration type instance.</returns>
            abstract createTextEditorDecorationType: options: DecorationRenderOptions -> TextEditorDecorationType
            /// <summary>
            /// Show an information message to users. Optionally provide an array of items which will be presented as
            /// clickable buttons.
            /// </summary>
            /// <param name="message">The message to show.</param>
            /// <param name="items">A set of items that will be rendered as actions in the message.</param>
            /// <returns>A thenable that resolves to the selected item or <c>undefined</c> when being dismissed.</returns>
            abstract showInformationMessage: message: string * [<ParamArray>] items: string[] -> Thenable<string option>
            /// <summary>
            /// Show an information message to users. Optionally provide an array of items which will be presented as
            /// clickable buttons.
            /// </summary>
            /// <param name="message">The message to show.</param>
            /// <param name="options">Configures the behaviour of the message.</param>
            /// <param name="items">A set of items that will be rendered as actions in the message.</param>
            /// <returns>A thenable that resolves to the selected item or <c>undefined</c> when being dismissed.</returns>
            abstract showInformationMessage: message: string * options: MessageOptions * [<ParamArray>] items: string[] -> Thenable<string option>
            /// <summary>Show an information message.</summary>
            /// <seealso cref="window.showInformationMessage">showInformationMessage</seealso>
            /// <param name="message">The message to show.</param>
            /// <param name="items">A set of items that will be rendered as actions in the message.</param>
            /// <returns>A thenable that resolves to the selected item or <c>undefined</c> when being dismissed.</returns>
            abstract showInformationMessage: message: string * [<ParamArray>] items: 'T[] -> Thenable<'T option> when 'T :> MessageItem
            /// <summary>Show an information message.</summary>
            /// <seealso cref="window.showInformationMessage">showInformationMessage</seealso>
            /// <param name="message">The message to show.</param>
            /// <param name="options">Configures the behaviour of the message.</param>
            /// <param name="items">A set of items that will be rendered as actions in the message.</param>
            /// <returns>A thenable that resolves to the selected item or <c>undefined</c> when being dismissed.</returns>
            abstract showInformationMessage: message: string * options: MessageOptions * [<ParamArray>] items: 'T[] -> Thenable<'T option> when 'T :> MessageItem
            /// <summary>Show a warning message.</summary>
            /// <seealso cref="window.showInformationMessage">showInformationMessage</seealso>
            /// <param name="message">The message to show.</param>
            /// <param name="items">A set of items that will be rendered as actions in the message.</param>
            /// <returns>A thenable that resolves to the selected item or <c>undefined</c> when being dismissed.</returns>
            abstract showWarningMessage: message: string * [<ParamArray>] items: string[] -> Thenable<string option>
            /// <summary>Show a warning message.</summary>
            /// <seealso cref="window.showInformationMessage">showInformationMessage</seealso>
            /// <param name="message">The message to show.</param>
            /// <param name="options">Configures the behaviour of the message.</param>
            /// <param name="items">A set of items that will be rendered as actions in the message.</param>
            /// <returns>A thenable that resolves to the selected item or <c>undefined</c> when being dismissed.</returns>
            abstract showWarningMessage: message: string * options: MessageOptions * [<ParamArray>] items: string[] -> Thenable<string option>
            /// <summary>Show a warning message.</summary>
            /// <seealso cref="window.showInformationMessage">showInformationMessage</seealso>
            /// <param name="message">The message to show.</param>
            /// <param name="items">A set of items that will be rendered as actions in the message.</param>
            /// <returns>A thenable that resolves to the selected item or <c>undefined</c> when being dismissed.</returns>
            abstract showWarningMessage: message: string * [<ParamArray>] items: 'T[] -> Thenable<'T option> when 'T :> MessageItem
            /// <summary>Show a warning message.</summary>
            /// <seealso cref="window.showInformationMessage">showInformationMessage</seealso>
            /// <param name="message">The message to show.</param>
            /// <param name="options">Configures the behaviour of the message.</param>
            /// <param name="items">A set of items that will be rendered as actions in the message.</param>
            /// <returns>A thenable that resolves to the selected item or <c>undefined</c> when being dismissed.</returns>
            abstract showWarningMessage: message: string * options: MessageOptions * [<ParamArray>] items: 'T[] -> Thenable<'T option> when 'T :> MessageItem
            /// <summary>Show an error message.</summary>
            /// <seealso cref="window.showInformationMessage">showInformationMessage</seealso>
            /// <param name="message">The message to show.</param>
            /// <param name="items">A set of items that will be rendered as actions in the message.</param>
            /// <returns>A thenable that resolves to the selected item or <c>undefined</c> when being dismissed.</returns>
            abstract showErrorMessage: message: string * [<ParamArray>] items: string[] -> Thenable<string option>
            /// <summary>Show an error message.</summary>
            /// <seealso cref="window.showInformationMessage">showInformationMessage</seealso>
            /// <param name="message">The message to show.</param>
            /// <param name="options">Configures the behaviour of the message.</param>
            /// <param name="items">A set of items that will be rendered as actions in the message.</param>
            /// <returns>A thenable that resolves to the selected item or <c>undefined</c> when being dismissed.</returns>
            abstract showErrorMessage: message: string * options: MessageOptions * [<ParamArray>] items: string[] -> Thenable<string option>
            /// <summary>Show an error message.</summary>
            /// <seealso cref="window.showInformationMessage">showInformationMessage</seealso>
            /// <param name="message">The message to show.</param>
            /// <param name="items">A set of items that will be rendered as actions in the message.</param>
            /// <returns>A thenable that resolves to the selected item or <c>undefined</c> when being dismissed.</returns>
            abstract showErrorMessage: message: string * [<ParamArray>] items: 'T[] -> Thenable<'T option> when 'T :> MessageItem
            /// <summary>Show an error message.</summary>
            /// <seealso cref="window.showInformationMessage">showInformationMessage</seealso>
            /// <param name="message">The message to show.</param>
            /// <param name="options">Configures the behaviour of the message.</param>
            /// <param name="items">A set of items that will be rendered as actions in the message.</param>
            /// <returns>A thenable that resolves to the selected item or <c>undefined</c> when being dismissed.</returns>
            abstract showErrorMessage: message: string * options: MessageOptions * [<ParamArray>] items: 'T[] -> Thenable<'T option> when 'T :> MessageItem
            /// <summary>Shows a selection list allowing multiple selections.</summary>
            /// <param name="items">An array of strings, or a promise that resolves to an array of strings.</param>
            /// <param name="options">Configures the behavior of the selection list.</param>
            /// <param name="token">A token that can be used to signal cancellation.</param>
            /// <returns>A promise that resolves to the selected items or <c>undefined</c>.</returns>
            abstract showQuickPick: items: U2<ResizeArray<string>, Thenable<ResizeArray<string>>> * options: obj * ?token: CancellationToken -> Thenable<ResizeArray<string> option>
            /// <summary>Shows a selection list.</summary>
            /// <param name="items">An array of strings, or a promise that resolves to an array of strings.</param>
            /// <param name="options">Configures the behavior of the selection list.</param>
            /// <param name="token">A token that can be used to signal cancellation.</param>
            /// <returns>A promise that resolves to the selection or <c>undefined</c>.</returns>
            abstract showQuickPick: items: U2<ResizeArray<string>, Thenable<ResizeArray<string>>> * ?options: QuickPickOptions * ?token: CancellationToken -> Thenable<string option>
            /// <summary>Shows a selection list allowing multiple selections.</summary>
            /// <param name="items">An array of items, or a promise that resolves to an array of items.</param>
            /// <param name="options">Configures the behavior of the selection list.</param>
            /// <param name="token">A token that can be used to signal cancellation.</param>
            /// <returns>A promise that resolves to the selected items or <c>undefined</c>.</returns>
            abstract showQuickPick: items: U2<ResizeArray<'T>, Thenable<ResizeArray<'T>>> * options: obj * ?token: CancellationToken -> Thenable<ResizeArray<'T> option> when 'T :> QuickPickItem
            /// <summary>Shows a selection list.</summary>
            /// <param name="items">An array of items, or a promise that resolves to an array of items.</param>
            /// <param name="options">Configures the behavior of the selection list.</param>
            /// <param name="token">A token that can be used to signal cancellation.</param>
            /// <returns>A promise that resolves to the selected item or <c>undefined</c>.</returns>
            abstract showQuickPick: items: U2<ResizeArray<'T>, Thenable<ResizeArray<'T>>> * ?options: QuickPickOptions * ?token: CancellationToken -> Thenable<'T option> when 'T :> QuickPickItem
            /// <summary>
            /// Shows a selection list of <see cref="workspace.workspaceFolders">workspace folders</see> to pick from.
            /// Returns <c>undefined</c> if no folder is open.
            /// </summary>
            /// <param name="options">Configures the behavior of the workspace folder list.</param>
            /// <returns>A promise that resolves to the workspace folder or <c>undefined</c>.</returns>
            abstract showWorkspaceFolderPick: ?options: WorkspaceFolderPickOptions -> Thenable<WorkspaceFolder option>
            /// <summary>
            /// Shows a file open dialog to the user which allows to select a file
            /// for opening-purposes.
            /// </summary>
            /// <param name="options">Options that control the dialog.</param>
            /// <returns>A promise that resolves to the selected resources or <c>undefined</c>.</returns>
            abstract showOpenDialog: options: OpenDialogOptions -> Thenable<ResizeArray<Uri> option>
            /// <summary>
            /// Shows a file save dialog to the user which allows to select a file
            /// for saving-purposes.
            /// </summary>
            /// <param name="options">Options that control the dialog.</param>
            /// <returns>A promise that resolves to the selected resource or <c>undefined</c>.</returns>
            abstract showSaveDialog: options: SaveDialogOptions -> Thenable<Uri option>
            /// <summary>
            /// Opens an input box to ask the user for input.
            /// 
            /// The returned value will be <c>undefined</c> if the input box was canceled (e.g. pressing ESC). Otherwise the
            /// returned value will be the string typed by the user or an empty string if the user did not type
            /// anything but dismissed the input box with OK.
            /// </summary>
            /// <param name="options">Configures the behavior of the input box.</param>
            /// <param name="token">A token that can be used to signal cancellation.</param>
            /// <returns>A promise that resolves to a string the user provided or to <c>undefined</c> in case of dismissal.</returns>
            abstract showInputBox: ?options: InputBoxOptions * ?token: CancellationToken -> Thenable<string option>
            /// <summary>
            /// Creates a <see cref="QuickPick">QuickPick</see> to let the user pick an item from a list
            /// of items of type T.
            /// 
            /// Note that in many cases the more convenient <see cref="window.showQuickPick">window.showQuickPick</see>
            /// is easier to use. <see cref="window.createQuickPick">window.createQuickPick</see> should be used
            /// when <see cref="window.showQuickPick">window.showQuickPick</see> does not offer the required flexibility.
            /// </summary>
            /// <returns>A new <see cref="QuickPick">QuickPick</see>.</returns>
            abstract createQuickPick: unit -> QuickPick<'T> when 'T :> QuickPickItem
            /// <summary>
            /// Creates a <see cref="InputBox">InputBox</see> to let the user enter some text input.
            /// 
            /// Note that in many cases the more convenient <see cref="window.showInputBox">window.showInputBox</see>
            /// is easier to use. <see cref="window.createInputBox">window.createInputBox</see> should be used
            /// when <see cref="window.showInputBox">window.showInputBox</see> does not offer the required flexibility.
            /// </summary>
            /// <returns>A new <see cref="InputBox">InputBox</see>.</returns>
            abstract createInputBox: unit -> InputBox
            /// <summary>Creates a new <see cref="OutputChannel">output channel</see> with the given name.</summary>
            /// <param name="name">Human-readable string which will be used to represent the channel in the UI.</param>
            abstract createOutputChannel: name: string -> OutputChannel
            /// <summary>Create and show a new webview panel.</summary>
            /// <param name="viewType">Identifies the type of the webview panel.</param>
            /// <param name="title">Title of the panel.</param>
            /// <param name="showOptions">Where to show the webview in the editor. If preserveFocus is set, the new webview will not take focus.</param>
            /// <param name="options">Settings for the new panel.</param>
            /// <returns>New webview panel.</returns>
            abstract createWebviewPanel: viewType: string * title: string * showOptions: U2<ViewColumn, {| viewColumn: ViewColumn; preserveFocus: bool option |}> * ?options: obj -> WebviewPanel
            /// <summary>
            /// Set a message to the status bar. This is a short hand for the more powerful
            /// status bar <see cref="window.createStatusBarItem">items</see>.
            /// </summary>
            /// <param name="text">The message to show, supports icon substitution as in status bar <see cref="StatusBarItem.text">items</see>.</param>
            /// <param name="hideAfterTimeout">Timeout in milliseconds after which the message will be disposed.</param>
            /// <returns>A disposable which hides the status bar message.</returns>
            abstract setStatusBarMessage: text: string * hideAfterTimeout: float -> Disposable
            /// <summary>
            /// Set a message to the status bar. This is a short hand for the more powerful
            /// status bar <see cref="window.createStatusBarItem">items</see>.
            /// </summary>
            /// <param name="text">The message to show, supports icon substitution as in status bar <see cref="StatusBarItem.text">items</see>.</param>
            /// <param name="hideWhenDone">Thenable on which completion (resolve or reject) the message will be disposed.</param>
            /// <returns>A disposable which hides the status bar message.</returns>
            abstract setStatusBarMessage: text: string * hideWhenDone: Thenable<obj option> -> Disposable
            /// <summary>
            /// Set a message to the status bar. This is a short hand for the more powerful
            /// status bar <see cref="window.createStatusBarItem">items</see>.
            /// 
            /// *Note* that status bar messages stack and that they must be disposed when no
            /// longer used.
            /// </summary>
            /// <param name="text">The message to show, supports icon substitution as in status bar <see cref="StatusBarItem.text">items</see>.</param>
            /// <returns>A disposable which hides the status bar message.</returns>
            abstract setStatusBarMessage: text: string -> Disposable
            /// <summary>
            /// ~~Show progress in the Source Control viewlet while running the given callback and while
            /// its returned promise isn't resolve or rejected.~~
            /// </summary>
            /// <param name="task">
            /// A callback returning a promise. Progress increments can be reported with
            /// the provided <see cref="Progress">progress</see>-object.
            /// </param>
            /// <returns>The thenable the task did return.</returns>
            [<Obsolete("Use `withProgress` instead.")>]
            abstract withScmProgress: task: (Progress<float> -> Thenable<'R>) -> Thenable<'R>
            /// <summary>
            /// Show progress in the editor. Progress is shown while running the given callback
            /// and while the promise it returned isn't resolved nor rejected. The location at which
            /// progress should show (and other details) is defined via the passed <see cref="ProgressOptions"><c>ProgressOptions</c></see>.
            /// </summary>
            /// <param name="task">
            /// A callback returning a promise. Progress state can be reported with
            /// the provided <see cref="Progress">progress</see>-object.
            /// 
            /// To report discrete progress, use <c>increment</c> to indicate how much work has been completed. Each call with
            /// a <c>increment</c> value will be summed up and reflected as overall progress until 100% is reached (a value of
            /// e.g. <c>10</c> accounts for <c>10%</c> of work done).
            /// Note that currently only <c>ProgressLocation.Notification</c> is capable of showing discrete progress.
            /// 
            /// To monitor if the operation has been cancelled by the user, use the provided <see cref="CancellationToken"><c>CancellationToken</c></see>.
            /// Note that currently only <c>ProgressLocation.Notification</c> is supporting to show a cancel button to cancel the
            /// long running operation.
            /// </param>
            /// <returns>The thenable the task-callback returned.</returns>
            abstract withProgress: options: ProgressOptions * task: (Progress<{| message: string option; increment: float option |}> -> CancellationToken -> Thenable<'R>) -> Thenable<'R>
            /// <summary>Creates a status bar <see cref="StatusBarItem">item</see>.</summary>
            /// <param name="alignment">The alignment of the item.</param>
            /// <param name="priority">The priority of the item. Higher values mean the item should be shown more to the left.</param>
            /// <returns>A new status bar item.</returns>
            abstract createStatusBarItem: ?alignment: StatusBarAlignment * ?priority: float -> StatusBarItem
            /// <summary>
            /// Creates a <see cref="Terminal">Terminal</see>. The cwd of the terminal will be the workspace directory
            /// if it exists, regardless of whether an explicit customStartPath setting exists.
            /// </summary>
            /// <param name="name">Optional human-readable string which will be used to represent the terminal in the UI.</param>
            /// <param name="shellPath">Optional path to a custom shell executable to be used in the terminal.</param>
            /// <param name="shellArgs">Optional args for the custom shell executable, this does not work on Windows (see #8429)</param>
            /// <returns>A new Terminal.</returns>
            abstract createTerminal: ?name: string * ?shellPath: string * ?shellArgs: ResizeArray<string> -> Terminal
            /// <summary>
            /// Creates a <see cref="Terminal">Terminal</see>. The cwd of the terminal will be the workspace directory
            /// if it exists, regardless of whether an explicit customStartPath setting exists.
            /// </summary>
            /// <param name="options">A TerminalOptions object describing the characteristics of the new terminal.</param>
            /// <returns>A new Terminal.</returns>
            abstract createTerminal: options: TerminalOptions -> Terminal
            /// <summary>
            /// Register a <see cref="TreeDataProvider">TreeDataProvider</see> for the view contributed using the extension point <c>views</c>.
            /// This will allow you to contribute data to the <see cref="TreeView">TreeView</see> and update if the data changes.
            /// 
            /// **Note:** To get access to the <see cref="TreeView">TreeView</see> and perform operations on it, use <see cref="window.createTreeView">createTreeView</see>.
            /// </summary>
            /// <param name="viewId">Id of the view contributed using the extension point <c>views</c>.</param>
            /// <param name="treeDataProvider">A <see cref="TreeDataProvider">TreeDataProvider</see> that provides tree data for the view</param>
            abstract registerTreeDataProvider: viewId: string * treeDataProvider: TreeDataProvider<'T> -> Disposable
            /// <summary>Create a <see cref="TreeView">TreeView</see> for the view contributed using the extension point <c>views</c>.</summary>
            /// <param name="viewId">Id of the view contributed using the extension point <c>views</c>.</param>
            /// <param name="options">Options for creating the <see cref="TreeView">TreeView</see></param>
            /// <returns>a <see cref="TreeView">TreeView</see>.</returns>
            abstract createTreeView: viewId: string * options: TreeViewOptions<'T> -> TreeView<'T>
            /// <summary>
            /// Registers a <see cref="UriHandler">uri handler</see> capable of handling system-wide <see cref="Uri">uris</see>.
            /// In case there are multiple windows open, the topmost window will handle the uri.
            /// A uri handler is scoped to the extension it is contributed from; it will only
            /// be able to handle uris which are directed to the extension itself. A uri must respect
            /// the following rules:
            /// 
            /// - The uri-scheme must be the product name;
            /// - The uri-authority must be the extension id (eg. <c>my.extension</c>);
            /// - The uri-path, -query and -fragment parts are arbitrary.
            /// 
            /// For example, if the <c>my.extension</c> extension registers a uri handler, it will only
            /// be allowed to handle uris with the prefix <c>product-name://my.extension</c>.
            /// 
            /// An extension can only register a single uri handler in its entire activation lifetime.
            /// 
            /// * *Note:* There is an activation event <c>onUri</c> that fires when a uri directed for
            /// the current extension is about to be handled.
            /// </summary>
            /// <param name="handler">The uri handler to register for this extension.</param>
            abstract registerUriHandler: handler: UriHandler -> Disposable
            /// <summary>
            /// Registers a webview panel serializer.
            /// 
            /// Extensions that support reviving should have an <c>"onWebviewPanel:viewType"</c> activation event and
            /// make sure that <see cref="registerWebviewPanelSerializer">registerWebviewPanelSerializer</see> is called during activation.
            /// 
            /// Only a single serializer may be registered at a time for a given <c>viewType</c>.
            /// </summary>
            /// <param name="viewType">Type of the webview panel that can be serialized.</param>
            /// <param name="serializer">Webview serializer.</param>
            abstract registerWebviewPanelSerializer: viewType: string * serializer: WebviewPanelSerializer -> Disposable

    /// <summary>Options for creating a <see cref="TreeView">TreeView</see></summary>
    type [<AllowNullLiteral>] TreeViewOptions<'T> =
        /// A data provider that provides tree data.
        abstract treeDataProvider: TreeDataProvider<'T> with get, set
        /// Whether to show collapse all action or not.
        abstract showCollapseAll: bool option with get, set

    /// <summary>The event that is fired when an element in the <see cref="TreeView">TreeView</see> is expanded or collapsed</summary>
    type [<AllowNullLiteral>] TreeViewExpansionEvent<'T> =
        /// Element that is expanded or collapsed.
        abstract element: 'T

    /// <summary>The event that is fired when there is a change in <see cref="TreeView.selection">tree view's selection</see></summary>
    type [<AllowNullLiteral>] TreeViewSelectionChangeEvent<'T> =
        /// Selected elements.
        abstract selection: ResizeArray<'T>

    /// <summary>The event that is fired when there is a change in <see cref="TreeView.visible">tree view's visibility</see></summary>
    type [<AllowNullLiteral>] TreeViewVisibilityChangeEvent =
        /// <summary><c>true</c> if the <see cref="TreeView">tree view</see> is visible otherwise <c>false</c>.</summary>
        abstract visible: bool

    /// Represents a Tree view
    type [<AllowNullLiteral>] TreeView<'T> =
        inherit Disposable
        /// Event that is fired when an element is expanded
        abstract onDidExpandElement: Event<TreeViewExpansionEvent<'T>>
        /// Event that is fired when an element is collapsed
        abstract onDidCollapseElement: Event<TreeViewExpansionEvent<'T>>
        /// Currently selected elements.
        abstract selection: ResizeArray<'T>
        /// <summary>Event that is fired when the <see cref="TreeView.selection">selection</see> has changed</summary>
        abstract onDidChangeSelection: Event<TreeViewSelectionChangeEvent<'T>>
        /// <summary><c>true</c> if the <see cref="TreeView">tree view</see> is visible otherwise <c>false</c>.</summary>
        abstract visible: bool
        /// <summary>Event that is fired when <see cref="TreeView.visible">visibility</see> has changed</summary>
        abstract onDidChangeVisibility: Event<TreeViewVisibilityChangeEvent>
        /// <summary>
        /// Reveals the given element in the tree view.
        /// If the tree view is not visible then the tree view is shown and element is revealed.
        /// 
        /// By default revealed element is selected.
        /// In order to not to select, set the option <c>select</c> to <c>false</c>.
        /// In order to focus, set the option <c>focus</c> to <c>true</c>.
        /// In order to expand the revealed element, set the option <c>expand</c> to <c>true</c>. To expand recursively set <c>expand</c> to the number of levels to expand.
        /// **NOTE:** You can expand only to 3 levels maximum.
        /// 
        /// **NOTE:** <see cref="TreeDataProvider">TreeDataProvider</see> is required to implement <see cref="TreeDataProvider.getParent">getParent</see> method to access this API.
        /// </summary>
        abstract reveal: element: 'T * ?options: {| select: bool option; focus: bool option; expand: U2<bool, float> option |} -> Thenable<unit>

    /// A data provider that provides tree data
    type [<AllowNullLiteral>] TreeDataProvider<'T> =
        /// <summary>
        /// An optional event to signal that an element or root has changed.
        /// This will trigger the view to update the changed element/root and its children recursively (if shown).
        /// To signal that root has changed, do not pass any argument or pass <c>undefined</c> or <c>null</c>.
        /// </summary>
        abstract onDidChangeTreeData: Event<'T option> option with get, set
        /// <summary>Get <see cref="TreeItem">TreeItem</see> representation of the <c>element</c></summary>
        /// <param name="element">The element for which <see cref="TreeItem">TreeItem</see> representation is asked for.</param>
        /// <returns><see cref="TreeItem">TreeItem</see> representation of the element</returns>
        abstract getTreeItem: element: 'T -> U2<TreeItem, Thenable<TreeItem>>
        /// <summary>Get the children of <c>element</c> or root if no element is passed.</summary>
        /// <param name="element">The element from which the provider gets children. Can be <c>undefined</c>.</param>
        /// <returns>Children of <c>element</c> or root if no element is passed.</returns>
        abstract getChildren: ?element: 'T -> ProviderResult<ResizeArray<'T>>
        /// <summary>
        /// Optional method to return the parent of <c>element</c>.
        /// Return <c>null</c> or <c>undefined</c> if <c>element</c> is a child of root.
        /// 
        /// **NOTE:** This method should be implemented in order to access <see cref="TreeView.reveal">reveal</see> API.
        /// </summary>
        /// <param name="element">The element for which the parent has to be returned.</param>
        /// <returns>Parent of <c>element</c>.</returns>
        abstract getParent: element: 'T -> ProviderResult<'T>

    type [<AllowNullLiteral>] TreeItem =
        /// <summary>A human-readable string describing this item. When <c>falsy</c>, it is derived from <see cref="TreeItem.resourceUri">resourceUri</see>.</summary>
        abstract label: string option with get, set
        /// Optional id for the tree item that has to be unique across tree. The id is used to preserve the selection and expansion state of the tree item.
        /// 
        /// If not provided, an id is generated using the tree item's label. **Note** that when labels change, ids will change and that selection and expansion state cannot be kept stable anymore.
        abstract id: string option with get, set
        /// <summary>
        /// The icon path or <see cref="ThemeIcon">ThemeIcon</see> for the tree item.
        /// When <c>falsy</c>, <see cref="ThemeIcon.Folder">Folder Theme Icon</see> is assigned, if item is collapsible otherwise <see cref="ThemeIcon.File">File Theme Icon</see>.
        /// When a <see cref="ThemeIcon">ThemeIcon</see> is specified, icon is derived from the current file icon theme for the specified theme icon using <see cref="TreeItem.resourceUri) (if provided">resourceUri</see>.
        /// </summary>
        abstract iconPath: U4<string, Uri, {| light: U2<string, Uri>; dark: U2<string, Uri> |}, ThemeIcon> option with get, set
        /// <summary>
        /// A human readable string which is rendered less prominent.
        /// When <c>true</c>, it is derived from <see cref="TreeItem.resourceUri">resourceUri</see> and when <c>falsy</c>, it is not shown.
        /// </summary>
        abstract description: U2<string, bool> option with get, set
        /// <summary>
        /// The <see cref="Uri">uri</see> of the resource representing this item.
        /// 
        /// Will be used to derive the <see cref="TreeItem.label">label</see>, when it is not provided.
        /// Will be used to derive the icon from current icon theme, when <see cref="TreeItem.iconPath">iconPath</see> has <see cref="ThemeIcon">ThemeIcon</see> value.
        /// </summary>
        abstract resourceUri: Uri option with get, set
        /// The tooltip text when you hover over this item.
        abstract tooltip: string option with get, set
        /// <summary>The <see cref="Command">command</see> that should be executed when the tree item is selected.</summary>
        abstract command: Command option with get, set
        /// <summary><see cref="TreeItemCollapsibleState">TreeItemCollapsibleState</see> of the tree item.</summary>
        abstract collapsibleState: TreeItemCollapsibleState option with get, set
        /// <summary>
        /// Context value of the tree item. This can be used to contribute item specific actions in the tree.
        /// For example, a tree item is given a context value as <c>folder</c>. When contributing actions to <c>view/item/context</c>
        /// using <c>menus</c> extension point, you can specify context value for key <c>viewItem</c> in <c>when</c> expression like <c>viewItem == folder</c>.
        /// <code>
        /// "contributes": {
        /// 		"menus": {
        /// 			"view/item/context": [
        /// 				{
        /// 					"command": "extension.deleteFolder",
        /// 					"when": "viewItem == folder"
        /// 				}
        /// 			]
        /// 		}
        /// }
        /// </code>
        /// This will show action <c>extension.deleteFolder</c> only for items with <c>contextValue</c> is <c>folder</c>.
        /// </summary>
        abstract contextValue: string option with get, set

    type [<AllowNullLiteral>] TreeItemStatic =
        /// <param name="label">A human-readable string describing this item</param>
        /// <param name="collapsibleState"><see cref="TreeItemCollapsibleState">TreeItemCollapsibleState</see> of the tree item. Default is <see cref="TreeItemCollapsibleState.None">TreeItemCollapsibleState.None</see></param>
        [<EmitConstructor>] abstract Create: label: string * ?collapsibleState: TreeItemCollapsibleState -> TreeItem
        /// <param name="resourceUri">The <see cref="Uri">uri</see> of the resource representing this item.</param>
        /// <param name="collapsibleState"><see cref="TreeItemCollapsibleState">TreeItemCollapsibleState</see> of the tree item. Default is <see cref="TreeItemCollapsibleState.None">TreeItemCollapsibleState.None</see></param>
        [<EmitConstructor>] abstract Create: resourceUri: Uri * ?collapsibleState: TreeItemCollapsibleState -> TreeItem

    /// Collapsible state of the tree item
    type [<RequireQualifiedAccess>] TreeItemCollapsibleState =
        /// Determines an item can be neither collapsed nor expanded. Implies it has no children.
        | None = 0
        /// Determines an item is collapsed
        | Collapsed = 1
        /// Determines an item is expanded
        | Expanded = 2

    /// Value-object describing what options a terminal should use.
    type [<AllowNullLiteral>] TerminalOptions =
        /// A human-readable string which will be used to represent the terminal in the UI.
        abstract name: string option with get, set
        /// A path to a custom shell executable to be used in the terminal.
        abstract shellPath: string option with get, set
        /// Args for the custom shell executable, this does not work on Windows (see #8429)
        abstract shellArgs: ResizeArray<string> option with get, set
        /// A path or Uri for the current working directory to be used for the terminal.
        abstract cwd: U2<string, Uri> option with get, set
        /// Object with environment variables that will be added to the VS Code process.
        abstract env: {| Item: string option |} option with get, set
        /// <summary>
        /// Whether the terminal process environment should be exactly as provided in
        /// <c>TerminalOptions.env</c>. When this is false (default), the environment will be based on the
        /// window's environment and also apply configured platform settings like
        /// <c>terminal.integrated.windows.env</c> on top. When this is true, the complete environment
        /// must be provided as nothing will be inherited from the process or any configuration.
        /// </summary>
        abstract strictEnv: bool option with get, set

    /// A location in the editor at which progress information can be shown. It depends on the
    /// location how progress is visually represented.
    type [<RequireQualifiedAccess>] ProgressLocation =
        /// Show progress for the source control viewlet, as overlay for the icon and as progress bar
        /// inside the viewlet (when visible). Neither supports cancellation nor discrete progress.
        | SourceControl = 1
        /// Show progress in the status bar of the editor. Neither supports cancellation nor discrete progress.
        | Window = 10
        /// Show progress as notification with an optional cancel button. Supports to show infinite and discrete progress.
        | Notification = 15

    /// Value-object describing where and how progress should show.
    type [<AllowNullLiteral>] ProgressOptions =
        /// The location at which progress should show.
        abstract location: ProgressLocation with get, set
        /// A human-readable string which will be used to describe the
        /// operation.
        abstract title: string option with get, set
        /// <summary>
        /// Controls if a cancel button should show to allow the user to
        /// cancel the long running operation.  Note that currently only
        /// <c>ProgressLocation.Notification</c> is supporting to show a cancel
        /// button.
        /// </summary>
        abstract cancellable: bool option with get, set

    /// <summary>
    /// A light-weight user input UI that is initially not visible. After
    /// configuring it through its properties the extension can make it
    /// visible by calling <see cref="QuickInput.show">QuickInput.show</see>.
    /// 
    /// There are several reasons why this UI might have to be hidden and
    /// the extension will be notified through <see cref="QuickInput.onDidHide">QuickInput.onDidHide</see>.
    /// (Examples include: an explicit call to <see cref="QuickInput.hide">QuickInput.hide</see>,
    /// the user pressing Esc, some other input UI opening, etc.)
    /// 
    /// A user pressing Enter or some other gesture implying acceptance
    /// of the current state does not automatically hide this UI component.
    /// It is up to the extension to decide whether to accept the user's input
    /// and if the UI should indeed be hidden through a call to <see cref="QuickInput.hide">QuickInput.hide</see>.
    /// 
    /// When the extension no longer needs this input UI, it should
    /// <see cref="QuickInput.dispose">QuickInput.dispose</see> it to allow for freeing up
    /// any resources associated with it.
    /// 
    /// See <see cref="QuickPick">QuickPick</see> and <see cref="InputBox">InputBox</see> for concrete UIs.
    /// </summary>
    type [<AllowNullLiteral>] QuickInput =
        /// An optional title.
        abstract title: string option with get, set
        /// An optional current step count.
        abstract step: float option with get, set
        /// An optional total step count.
        abstract totalSteps: float option with get, set
        /// If the UI should allow for user input. Defaults to true.
        /// 
        /// Change this to false, e.g., while validating user input or
        /// loading data for the next step in user input.
        abstract enabled: bool with get, set
        /// If the UI should show a progress indicator. Defaults to false.
        /// 
        /// Change this to true, e.g., while loading more data or validating
        /// user input.
        abstract busy: bool with get, set
        /// If the UI should stay open even when loosing UI focus. Defaults to false.
        abstract ignoreFocusOut: bool with get, set
        /// <summary>
        /// Makes the input UI visible in its current configuration. Any other input
        /// UI will first fire an <see cref="QuickInput.onDidHide">QuickInput.onDidHide</see> event.
        /// </summary>
        abstract show: unit -> unit
        /// <summary>
        /// Hides this input UI. This will also fire an <see cref="QuickInput.onDidHide">QuickInput.onDidHide</see>
        /// event.
        /// </summary>
        abstract hide: unit -> unit
        /// <summary>
        /// An event signaling when this input UI is hidden.
        /// 
        /// There are several reasons why this UI might have to be hidden and
        /// the extension will be notified through <see cref="QuickInput.onDidHide">QuickInput.onDidHide</see>.
        /// (Examples include: an explicit call to <see cref="QuickInput.hide">QuickInput.hide</see>,
        /// the user pressing Esc, some other input UI opening, etc.)
        /// </summary>
        abstract onDidHide: Event<unit> with get, set
        /// Dispose of this input UI and any associated resources. If it is still
        /// visible, it is first hidden. After this call the input UI is no longer
        /// functional and no additional methods or properties on it should be
        /// accessed. Instead a new input UI should be created.
        abstract dispose: unit -> unit

    /// <summary>
    /// A concrete <see cref="QuickInput">QuickInput</see> to let the user pick an item from a
    /// list of items of type T. The items can be filtered through a filter text field and
    /// there is an option <see cref="QuickPick.canSelectMany">canSelectMany</see> to allow for
    /// selecting multiple items.
    /// 
    /// Note that in many cases the more convenient <see cref="window.showQuickPick">window.showQuickPick</see>
    /// is easier to use. <see cref="window.createQuickPick">window.createQuickPick</see> should be used
    /// when <see cref="window.showQuickPick">window.showQuickPick</see> does not offer the required flexibility.
    /// </summary>
    type [<AllowNullLiteral>] QuickPick<'T when 'T :> QuickPickItem> =
        inherit QuickInput
        /// Current value of the filter text.
        abstract value: string with get, set
        /// Optional placeholder in the filter text.
        abstract placeholder: string option with get, set
        /// An event signaling when the value of the filter text has changed.
        abstract onDidChangeValue: Event<string>
        /// An event signaling when the user indicated acceptance of the selected item(s).
        abstract onDidAccept: Event<unit>
        /// Buttons for actions in the UI.
        abstract buttons: ReadonlyArray<QuickInputButton> with get, set
        /// An event signaling when a button was triggered.
        abstract onDidTriggerButton: Event<QuickInputButton>
        /// Items to pick from.
        abstract items: ReadonlyArray<'T> with get, set
        /// If multiple items can be selected at the same time. Defaults to false.
        abstract canSelectMany: bool with get, set
        /// If the filter text should also be matched against the description of the items. Defaults to false.
        abstract matchOnDescription: bool with get, set
        /// If the filter text should also be matched against the detail of the items. Defaults to false.
        abstract matchOnDetail: bool with get, set
        /// Active items. This can be read and updated by the extension.
        abstract activeItems: ReadonlyArray<'T> with get, set
        /// An event signaling when the active items have changed.
        abstract onDidChangeActive: Event<ResizeArray<'T>>
        /// Selected items. This can be read and updated by the extension.
        abstract selectedItems: ReadonlyArray<'T> with get, set
        /// An event signaling when the selected items have changed.
        abstract onDidChangeSelection: Event<ResizeArray<'T>>

    /// <summary>
    /// A concrete <see cref="QuickInput">QuickInput</see> to let the user input a text value.
    /// 
    /// Note that in many cases the more convenient <see cref="window.showInputBox">window.showInputBox</see>
    /// is easier to use. <see cref="window.createInputBox">window.createInputBox</see> should be used
    /// when <see cref="window.showInputBox">window.showInputBox</see> does not offer the required flexibility.
    /// </summary>
    type [<AllowNullLiteral>] InputBox =
        inherit QuickInput
        /// Current input value.
        abstract value: string with get, set
        /// Optional placeholder in the filter text.
        abstract placeholder: string option with get, set
        /// If the input value should be hidden. Defaults to false.
        abstract password: bool with get, set
        /// An event signaling when the value has changed.
        abstract onDidChangeValue: Event<string>
        /// An event signaling when the user indicated acceptance of the input value.
        abstract onDidAccept: Event<unit>
        /// Buttons for actions in the UI.
        abstract buttons: ReadonlyArray<QuickInputButton> with get, set
        /// An event signaling when a button was triggered.
        abstract onDidTriggerButton: Event<QuickInputButton>
        /// An optional prompt text providing some ask or explanation to the user.
        abstract prompt: string option with get, set
        /// An optional validation message indicating a problem with the current input value.
        abstract validationMessage: string option with get, set

    /// <summary>Button for an action in a <see cref="QuickPick">QuickPick</see> or <see cref="InputBox">InputBox</see>.</summary>
    type [<AllowNullLiteral>] QuickInputButton =
        /// Icon for the button.
        abstract iconPath: U3<Uri, {| light: Uri; dark: Uri |}, ThemeIcon>
        /// An optional tooltip.
        abstract tooltip: string option

    /// <summary>Predefined buttons for <see cref="QuickPick">QuickPick</see> and <see cref="InputBox">InputBox</see>.</summary>
    type [<AllowNullLiteral>] QuickInputButtons =
        interface end

    /// <summary>Predefined buttons for <see cref="QuickPick">QuickPick</see> and <see cref="InputBox">InputBox</see>.</summary>
    type [<AllowNullLiteral>] QuickInputButtonsStatic =
        /// <summary>
        /// A back button for <see cref="QuickPick">QuickPick</see> and <see cref="InputBox">InputBox</see>.
        /// 
        /// When a navigation 'back' button is needed this one should be used for consistency.
        /// It comes with a predefined icon, tooltip and location.
        /// </summary>
        abstract Back: QuickInputButton

    /// <summary>An event describing an individual change in the text of a <see cref="TextDocument">document</see>.</summary>
    type [<AllowNullLiteral>] TextDocumentContentChangeEvent =
        /// The range that got replaced.
        abstract range: Range with get, set
        /// The offset of the range that got replaced.
        abstract rangeOffset: float with get, set
        /// The length of the range that got replaced.
        abstract rangeLength: float with get, set
        /// The new text for the range.
        abstract text: string with get, set

    /// <summary>An event describing a transactional <see cref="TextDocument">document</see> change.</summary>
    type [<AllowNullLiteral>] TextDocumentChangeEvent =
        /// The affected document.
        abstract document: TextDocument with get, set
        /// An array of content changes.
        abstract contentChanges: ResizeArray<TextDocumentContentChangeEvent> with get, set

    /// Represents reasons why a text document is saved.
    type [<RequireQualifiedAccess>] TextDocumentSaveReason =
        /// Manually triggered, e.g. by the user pressing save, by starting debugging,
        /// or by an API call.
        | Manual = 1
        /// Automatic after a delay.
        | AfterDelay = 2
        /// When the editor lost focus.
        | FocusOut = 3

    /// <summary>
    /// An event that is fired when a <see cref="TextDocument">document</see> will be saved.
    /// 
    /// To make modifications to the document before it is being saved, call the
    /// <see cref="TextDocumentWillSaveEvent.waitUntil"><c>waitUntil</c></see>-function with a thenable
    /// that resolves to an array of <see cref="TextEdit">text edits</see>.
    /// </summary>
    type [<AllowNullLiteral>] TextDocumentWillSaveEvent =
        /// The document that will be saved.
        abstract document: TextDocument with get, set
        /// The reason why save was triggered.
        abstract reason: TextDocumentSaveReason with get, set
        /// <summary>
        /// Allows to pause the event loop and to apply <see cref="TextEdit">pre-save-edits</see>.
        /// Edits of subsequent calls to this function will be applied in order. The
        /// edits will be *ignored* if concurrent modifications of the document happened.
        /// 
        /// *Note:* This function can only be called during event dispatch and not
        /// in an asynchronous manner:
        /// 
        /// <code language="ts">
        /// workspace.onWillSaveTextDocument(event => {
        ///  	// async, will *throw* an error
        ///  	setTimeout(() => event.waitUntil(promise));
        /// 
        ///  	// sync, OK
        ///  	event.waitUntil(promise);
        /// })
        /// </code>
        /// </summary>
        /// <param name="thenable">A thenable that resolves to <see cref="TextEdit">pre-save-edits</see>.</param>
        abstract waitUntil: thenable: Thenable<ResizeArray<TextEdit>> -> unit
        /// <summary>
        /// Allows to pause the event loop until the provided thenable resolved.
        /// 
        /// *Note:* This function can only be called during event dispatch.
        /// </summary>
        /// <param name="thenable">A thenable that delays saving.</param>
        abstract waitUntil: thenable: Thenable<obj option> -> unit

    /// <summary>An event describing a change to the set of <see cref="workspace.workspaceFolders">workspace folders</see>.</summary>
    type [<AllowNullLiteral>] WorkspaceFoldersChangeEvent =
        /// Added workspace folders.
        abstract added: ResizeArray<WorkspaceFolder>
        /// Removed workspace folders.
        abstract removed: ResizeArray<WorkspaceFolder>

    /// A workspace folder is one of potentially many roots opened by the editor. All workspace folders
    /// are equal which means there is no notion of an active or master workspace folder.
    type [<AllowNullLiteral>] WorkspaceFolder =
        /// <summary>
        /// The associated uri for this workspace folder.
        /// 
        /// *Note:* The <see cref="Uri">Uri</see>-type was intentionally chosen such that future releases of the editor can support
        /// workspace folders that are not stored on the local disk, e.g. <c>ftp://server/workspaces/foo</c>.
        /// </summary>
        abstract uri: Uri
        /// <summary>
        /// The name of this workspace folder. Defaults to
        /// the basename of its <see cref="Uri.path">uri-path</see>
        /// </summary>
        abstract name: string
        /// The ordinal number of this workspace folder.
        abstract index: float

    /// <summary>
    /// Namespace for dealing with the current workspace. A workspace is the representation
    /// of the folder that has been opened. There is no workspace when just a file but not a
    /// folder has been opened.
    /// 
    /// The workspace offers support for <see cref="workspace.createFileSystemWatcher">listening</see> to fs
    /// events and for <see cref="workspace.findFiles">finding</see> files. Both perform well and run _outside_
    /// the editor-process so that they should be always used instead of nodejs-equivalents.
    /// </summary>
    module Workspace =

        type [<AllowNullLiteral>] IExports =
            /// <summary>
            /// ~~The folder that is open in the editor. <c>undefined</c> when no folder
            /// has been opened.~~
            /// </summary>
            [<Obsolete("Use [`workspaceFolders`](#workspace.workspaceFolders) instead.")>]
            abstract rootPath: string option
            /// <summary>
            /// List of workspace folders or <c>undefined</c> when no folder is open.
            /// *Note* that the first entry corresponds to the value of <c>rootPath</c>.
            /// </summary>
            abstract workspaceFolders: ResizeArray<WorkspaceFolder> option
            /// <summary>
            /// The name of the workspace. <c>undefined</c> when no folder
            /// has been opened.
            /// </summary>
            abstract name: string option
            /// An event that is emitted when a workspace folder is added or removed.
            abstract onDidChangeWorkspaceFolders: Event<WorkspaceFoldersChangeEvent>
            /// <summary>
            /// Returns the <see cref="WorkspaceFolder">workspace folder</see> that contains a given uri.
            /// * returns <c>undefined</c> when the given uri doesn't match any workspace folder
            /// * returns the *input* when the given uri is a workspace folder itself
            /// </summary>
            /// <param name="uri">An uri.</param>
            /// <returns>A workspace folder or <c>undefined</c></returns>
            abstract getWorkspaceFolder: uri: Uri -> WorkspaceFolder option
            /// <summary>
            /// Returns a path that is relative to the workspace folder or folders.
            /// 
            /// When there are no <see cref="workspace.workspaceFolders">workspace folders</see> or when the path
            /// is not contained in them, the input is returned.
            /// </summary>
            /// <param name="pathOrUri">A path or uri. When a uri is given its <see cref="Uri.fsPath">fsPath</see> is used.</param>
            /// <param name="includeWorkspaceFolder">
            /// When <c>true</c> and when the given path is contained inside a
            /// workspace folder the name of the workspace is prepended. Defaults to <c>true</c> when there are
            /// multiple workspace folders and <c>false</c> otherwise.
            /// </param>
            /// <returns>A path relative to the root or the input.</returns>
            abstract asRelativePath: pathOrUri: U2<string, Uri> * ?includeWorkspaceFolder: bool -> string
            /// <summary>
            /// This method replaces <c>deleteCount</c> <see cref="workspace.workspaceFolders">workspace folders</see> starting at index <c>start</c>
            /// by an optional set of <c>workspaceFoldersToAdd</c> on the <c>vscode.workspace.workspaceFolders</c> array. This "splice"
            /// behavior can be used to add, remove and change workspace folders in a single operation.
            /// 
            /// If the first workspace folder is added, removed or changed, the currently executing extensions (including the
            /// one that called this method) will be terminated and restarted so that the (deprecated) <c>rootPath</c> property is
            /// updated to point to the first workspace folder.
            /// 
            /// Use the [<c>onDidChangeWorkspaceFolders()</c>](#onDidChangeWorkspaceFolders) event to get notified when the
            /// workspace folders have been updated.
            /// 
            /// **Example:** adding a new workspace folder at the end of workspace folders
            /// <code language="typescript">
            /// workspace.updateWorkspaceFolders(workspace.workspaceFolders ? workspace.workspaceFolders.length : 0, null, { uri: ...});
            /// </code>
            /// 
            /// **Example:** removing the first workspace folder
            /// <code language="typescript">
            /// workspace.updateWorkspaceFolders(0, 1);
            /// </code>
            /// 
            /// **Example:** replacing an existing workspace folder with a new one
            /// <code language="typescript">
            /// workspace.updateWorkspaceFolders(0, 1, { uri: ...});
            /// </code>
            /// 
            /// It is valid to remove an existing workspace folder and add it again with a different name
            /// to rename that folder.
            /// 
            /// **Note:** it is not valid to call [updateWorkspaceFolders()](#updateWorkspaceFolders) multiple times
            /// without waiting for the [<c>onDidChangeWorkspaceFolders()</c>](#onDidChangeWorkspaceFolders) to fire.
            /// </summary>
            /// <param name="start">
            /// the zero-based location in the list of currently opened <see cref="WorkspaceFolder">workspace folders</see>
            /// from which to start deleting workspace folders.
            /// </param>
            /// <param name="deleteCount">the optional number of workspace folders to remove.</param>
            /// <param name="workspaceFoldersToAdd">
            /// the optional variable set of workspace folders to add in place of the deleted ones.
            /// Each workspace is identified with a mandatory URI and an optional name.
            /// </param>
            /// <returns>
            /// true if the operation was successfully started and false otherwise if arguments were used that would result
            /// in invalid workspace folder state (e.g. 2 folders with the same URI).
            /// </returns>
            abstract updateWorkspaceFolders: start: float * deleteCount: float option * [<ParamArray>] workspaceFoldersToAdd: {| uri: Uri; name: string option |}[] -> bool
            /// <summary>
            /// Creates a file system watcher.
            /// 
            /// A glob pattern that filters the file events on their absolute path must be provided. Optionally,
            /// flags to ignore certain kinds of events can be provided. To stop listening to events the watcher must be disposed.
            /// 
            /// *Note* that only files within the current <see cref="workspace.workspaceFolders">workspace folders</see> can be watched.
            /// </summary>
            /// <param name="globPattern">
            /// A <see cref="GlobPattern">glob pattern</see> that is applied to the absolute paths of created, changed,
            /// and deleted files. Use a <see cref="RelativePattern">relative pattern</see> to limit events to a certain <see cref="WorkspaceFolder">workspace folder</see>.
            /// </param>
            /// <param name="ignoreCreateEvents">Ignore when files have been created.</param>
            /// <param name="ignoreChangeEvents">Ignore when files have been changed.</param>
            /// <param name="ignoreDeleteEvents">Ignore when files have been deleted.</param>
            /// <returns>A new file system watcher instance.</returns>
            abstract createFileSystemWatcher: globPattern: GlobPattern * ?ignoreCreateEvents: bool * ?ignoreChangeEvents: bool * ?ignoreDeleteEvents: bool -> FileSystemWatcher
            /// <summary>Find files across all <see cref="workspace.workspaceFolders">workspace folders</see> in the workspace.</summary>
            /// <param name="include">
            /// A <see cref="GlobPattern">glob pattern</see> that defines the files to search for. The glob pattern
            /// will be matched against the file paths of resulting matches relative to their workspace. Use a <see cref="RelativePattern">relative pattern</see>
            /// to restrict the search results to a <see cref="WorkspaceFolder">workspace folder</see>.
            /// </param>
            /// <param name="exclude">
            /// A <see cref="GlobPattern">glob pattern</see> that defines files and folders to exclude. The glob pattern
            /// will be matched against the file paths of resulting matches relative to their workspace. When <c>undefined</c> only default excludes will
            /// apply, when <c>null</c> no excludes will apply.
            /// </param>
            /// <param name="maxResults">An upper-bound for the result.</param>
            /// <param name="token">A token that can be used to signal cancellation to the underlying search engine.</param>
            /// <returns>
            /// A thenable that resolves to an array of resource identifiers. Will return no results if no
            /// <see cref="workspace.workspaceFolders">workspace folders</see> are opened.
            /// </returns>
            abstract findFiles: ``include``: GlobPattern * ?exclude: GlobPattern * ?maxResults: float * ?token: CancellationToken -> Thenable<ResizeArray<Uri>>
            /// <summary>Save all dirty files.</summary>
            /// <param name="includeUntitled">Also save files that have been created during this session.</param>
            /// <returns>A thenable that resolves when the files have been saved.</returns>
            abstract saveAll: ?includeUntitled: bool -> Thenable<bool>
            /// <summary>
            /// Make changes to one or many resources or create, delete, and rename resources as defined by the given
            /// <see cref="WorkspaceEdit">workspace edit</see>.
            /// 
            /// All changes of a workspace edit are applied in the same order in which they have been added. If
            /// multiple textual inserts are made at the same position, these strings appear in the resulting text
            /// in the order the 'inserts' were made. Invalid sequences like 'delete file a' -> 'insert text in file a'
            /// cause failure of the operation.
            /// 
            /// When applying a workspace edit that consists only of text edits an 'all-or-nothing'-strategy is used.
            /// A workspace edit with resource creations or deletions aborts the operation, e.g. consecutive edits will
            /// not be attempted, when a single edit fails.
            /// </summary>
            /// <param name="edit">A workspace edit.</param>
            /// <returns>A thenable that resolves when the edit could be applied.</returns>
            abstract applyEdit: edit: WorkspaceEdit -> Thenable<bool>
            /// All text documents currently known to the system.
            abstract textDocuments: ResizeArray<TextDocument>
            /// <summary>
            /// Opens a document. Will return early if this document is already open. Otherwise
            /// the document is loaded and the <see cref="workspace.onDidOpenTextDocument">didOpen</see>-event fires.
            /// 
            /// The document is denoted by an <see cref="Uri">uri</see>. Depending on the <see cref="Uri.scheme">scheme</see> the
            /// following rules apply:
            /// * <c>file</c>-scheme: Open a file on disk, will be rejected if the file does not exist or cannot be loaded.
            /// * <c>untitled</c>-scheme: A new file that should be saved on disk, e.g. <c>untitled:c:\frodo\new.js</c>. The language
            /// will be derived from the file name.
            /// * For all other schemes the registered text document content <see cref="TextDocumentContentProvider">providers</see> are consulted.
            /// 
            /// *Note* that the lifecycle of the returned document is owned by the editor and not by the extension. That means an
            /// <see cref="workspace.onDidCloseTextDocument"><c>onDidClose</c></see>-event can occur at any time after opening it.
            /// </summary>
            /// <param name="uri">Identifies the resource to open.</param>
            /// <returns>A promise that resolves to a <see cref="TextDocument">document</see>.</returns>
            abstract openTextDocument: uri: Uri -> Thenable<TextDocument>
            /// <summary>A short-hand for <c>openTextDocument(Uri.file(fileName))</c>.</summary>
            /// <seealso cref="openTextDocument">openTextDocument</seealso>
            /// <param name="fileName">A name of a file on disk.</param>
            /// <returns>A promise that resolves to a <see cref="TextDocument">document</see>.</returns>
            abstract openTextDocument: fileName: string -> Thenable<TextDocument>
            /// <summary>
            /// Opens an untitled text document. The editor will prompt the user for a file
            /// path when the document is to be saved. The <c>options</c> parameter allows to
            /// specify the *language* and/or the *content* of the document.
            /// </summary>
            /// <param name="options">Options to control how the document will be created.</param>
            /// <returns>A promise that resolves to a <see cref="TextDocument">document</see>.</returns>
            abstract openTextDocument: ?options: {| language: string option; content: string option |} -> Thenable<TextDocument>
            /// <summary>
            /// Register a text document content provider.
            /// 
            /// Only one provider can be registered per scheme.
            /// </summary>
            /// <param name="scheme">The uri-scheme to register for.</param>
            /// <param name="provider">A content provider.</param>
            /// <returns>A <see cref="Disposable">disposable</see> that unregisters this provider when being disposed.</returns>
            abstract registerTextDocumentContentProvider: scheme: string * provider: TextDocumentContentProvider -> Disposable
            /// <summary>
            /// An event that is emitted when a <see cref="TextDocument">text document</see> is opened or when the language id
            /// of a text document <see cref="languages.setTextDocumentLanguage">has been changed</see>.
            /// 
            /// To add an event listener when a visible text document is opened, use the <see cref="TextEditor">TextEditor</see> events in the
            /// <see cref="window">window</see> namespace. Note that:
            /// 
            /// - The event is emitted before the <see cref="TextDocument">document</see> is updated in the
            /// <see cref="window.activeTextEditor">active text editor</see>
            /// - When a <see cref="TextDocument">text document</see> is already open (e.g.: open in another <see cref="window.visibleTextEditors)">visible text editor</see> this event is not emitted
            /// </summary>
            abstract onDidOpenTextDocument: Event<TextDocument>
            /// <summary>
            /// An event that is emitted when a <see cref="TextDocument">text document</see> is disposed or when the language id
            /// of a text document <see cref="languages.setTextDocumentLanguage">has been changed</see>.
            /// 
            /// To add an event listener when a visible text document is closed, use the <see cref="TextEditor">TextEditor</see> events in the
            /// <see cref="window">window</see> namespace. Note that this event is not emitted when a <see cref="TextEditor">TextEditor</see> is closed
            /// but the document remains open in another <see cref="window.visibleTextEditors">visible text editor</see>.
            /// </summary>
            abstract onDidCloseTextDocument: Event<TextDocument>
            /// <summary>
            /// An event that is emitted when a <see cref="TextDocument">text document</see> is changed. This usually happens
            /// when the <see cref="TextDocument.getText">contents</see> changes but also when other things like the
            /// <see cref="TextDocument.isDirty">dirty</see>-state changes.
            /// </summary>
            abstract onDidChangeTextDocument: Event<TextDocumentChangeEvent>
            /// <summary>
            /// An event that is emitted when a <see cref="TextDocument">text document</see> will be saved to disk.
            /// 
            /// *Note 1:* Subscribers can delay saving by registering asynchronous work. For the sake of data integrity the editor
            /// might save without firing this event. For instance when shutting down with dirty files.
            /// 
            /// *Note 2:* Subscribers are called sequentially and they can <see cref="TextDocumentWillSaveEvent.waitUntil">delay</see> saving
            /// by registering asynchronous work. Protection against misbehaving listeners is implemented as such:
            ///   * there is an overall time budget that all listeners share and if that is exhausted no further listener is called
            ///   * listeners that take a long time or produce errors frequently will not be called anymore
            /// 
            /// The current thresholds are 1.5 seconds as overall time budget and a listener can misbehave 3 times before being ignored.
            /// </summary>
            abstract onWillSaveTextDocument: Event<TextDocumentWillSaveEvent>
            /// <summary>An event that is emitted when a <see cref="TextDocument">text document</see> is saved to disk.</summary>
            abstract onDidSaveTextDocument: Event<TextDocument>
            /// <summary>
            /// Get a workspace configuration object.
            /// 
            /// When a section-identifier is provided only that part of the configuration
            /// is returned. Dots in the section-identifier are interpreted as child-access,
            /// like <c>{ myExt: { setting: { doIt: true }}}</c> and <c>getConfiguration('myExt.setting').get('doIt') === true</c>.
            /// 
            /// When a resource is provided, configuration scoped to that resource is returned.
            /// </summary>
            /// <param name="section">A dot-separated identifier.</param>
            /// <param name="resource">A resource for which the configuration is asked for</param>
            /// <returns>The full configuration or a subset.</returns>
            abstract getConfiguration: ?section: string * ?resource: Uri -> WorkspaceConfiguration
            /// <summary>An event that is emitted when the <see cref="WorkspaceConfiguration">configuration</see> changed.</summary>
            abstract onDidChangeConfiguration: Event<ConfigurationChangeEvent>
            /// <summary>~~Register a task provider.~~</summary>
            /// <param name="type">The task kind type this provider is registered for.</param>
            /// <param name="provider">A task provider.</param>
            /// <returns>A <see cref="Disposable">disposable</see> that unregisters this provider when being disposed.</returns>
            [<Obsolete("Use the corresponding function on the `tasks` namespace instead")>]
            abstract registerTaskProvider: ``type``: string * provider: TaskProvider -> Disposable
            /// <summary>
            /// Register a filesystem provider for a given scheme, e.g. <c>ftp</c>.
            /// 
            /// There can only be one provider per scheme and an error is being thrown when a scheme
            /// has been claimed by another provider or when it is reserved.
            /// </summary>
            /// <param name="scheme">The uri-<see cref="Uri.scheme">scheme</see> the provider registers for.</param>
            /// <param name="provider">The filesystem provider.</param>
            /// <param name="options">Immutable metadata about the provider.</param>
            /// <returns>A <see cref="Disposable">disposable</see> that unregisters this provider when being disposed.</returns>
            abstract registerFileSystemProvider: scheme: string * provider: FileSystemProvider * ?options: {| isCaseSensitive: bool option; isReadonly: bool option |} -> Disposable

    /// An event describing the change in Configuration
    type [<AllowNullLiteral>] ConfigurationChangeEvent =
        /// <summary>Returns <c>true</c> if the given section for the given resource (if provided) is affected.</summary>
        /// <param name="section">Configuration name, supports _dotted_ names.</param>
        /// <param name="resource">A resource Uri.</param>
        /// <returns><c>true</c> if the given section for the given resource (if provided) is affected.</returns>
        abstract affectsConfiguration: section: string * ?resource: Uri -> bool

    /// <summary>
    /// Namespace for participating in language-specific editor <see href="https://code.visualstudio.com/docs/editor/editingevolved">features</see>,
    /// like IntelliSense, code actions, diagnostics etc.
    /// 
    /// Many programming languages exist and there is huge variety in syntaxes, semantics, and paradigms. Despite that, features
    /// like automatic word-completion, code navigation, or code checking have become popular across different tools for different
    /// programming languages.
    /// 
    /// The editor provides an API that makes it simple to provide such common features by having all UI and actions already in place and
    /// by allowing you to participate by providing data only. For instance, to contribute a hover all you have to do is provide a function
    /// that can be called with a <see cref="TextDocument">TextDocument</see> and a <see cref="Position">Position</see> returning hover info. The rest, like tracking the
    /// mouse, positioning the hover, keeping the hover stable etc. is taken care of by the editor.
    /// 
    /// <code language="javascript">
    /// languages.registerHoverProvider('javascript', {
    ///  	provideHover(document, position, token) {
    ///  		return new Hover('I am a hover!');
    ///  	}
    /// });
    /// </code>
    /// 
    /// Registration is done using a <see cref="DocumentSelector">document selector</see> which is either a language id, like <c>javascript</c> or
    /// a more complex <see cref="DocumentFilter">filter</see> like <c>{ language: 'typescript', scheme: 'file' }</c>. Matching a document against such
    /// a selector will result in a <see cref="languages.match">score</see> that is used to determine if and how a provider shall be used. When
    /// scores are equal the provider that came last wins. For features that allow full arity, like <see cref="languages.registerHoverProvider">hover</see>,
    /// the score is only checked to be <c>>0</c>, for other features, like <see cref="languages.registerCompletionItemProvider">IntelliSense</see> the
    /// score is used for determining the order in which providers are asked to participate.
    /// </summary>
    module Languages =

        type [<AllowNullLiteral>] IExports =
            /// <summary>Return the identifiers of all known languages.</summary>
            /// <returns>Promise resolving to an array of identifier strings.</returns>
            abstract getLanguages: unit -> Thenable<ResizeArray<string>>
            /// <summary>
            /// Set (and change) the <see cref="TextDocument.languageId">language</see> that is associated
            /// with the given document.
            /// 
            /// *Note* that calling this function will trigger the <see cref="workspace.onDidCloseTextDocument"><c>onDidCloseTextDocument</c></see> event
            /// followed by the <see cref="workspace.onDidOpenTextDocument"><c>onDidOpenTextDocument</c></see> event.
            /// </summary>
            /// <param name="document">The document which language is to be changed</param>
            /// <param name="languageId">The new language identifier.</param>
            /// <returns>A thenable that resolves with the updated document.</returns>
            abstract setTextDocumentLanguage: document: TextDocument * languageId: string -> Thenable<TextDocument>
            /// <summary>
            /// Compute the match between a document <see cref="DocumentSelector">selector</see> and a document. Values
            /// greater than zero mean the selector matches the document.
            /// 
            /// A match is computed according to these rules:
            /// 1. When <see cref="DocumentSelector"><c>DocumentSelector</c></see> is an array, compute the match for each contained <c>DocumentFilter</c> or language identifier and take the maximum value.
            /// 2. A string will be desugared to become the <c>language</c>-part of a <see cref="DocumentFilter"><c>DocumentFilter</c></see>, so <c>"fooLang"</c> is like <c>{ language: "fooLang" }</c>.
            /// 3. A <see cref="DocumentFilter"><c>DocumentFilter</c></see> will be matched against the document by comparing its parts with the document. The following rules apply:
            ///   1. When the <c>DocumentFilter</c> is empty (<c>{}</c>) the result is <c>0</c>
            ///   2. When <c>scheme</c>, <c>language</c>, or <c>pattern</c> are defined but one doesn’t match, the result is <c>0</c>
            ///   3. Matching against <c>*</c> gives a score of <c>5</c>, matching via equality or via a glob-pattern gives a score of <c>10</c>
            ///   4. The result is the maximum value of each match
            /// 
            /// Samples:
            /// <code language="js">
            /// // default document from disk (file-scheme)
            /// doc.uri; //'file:///my/file.js'
            /// doc.languageId; // 'javascript'
            /// match('javascript', doc); // 10;
            /// match({language: 'javascript'}, doc); // 10;
            /// match({language: 'javascript', scheme: 'file'}, doc); // 10;
            /// match('*', doc); // 5
            /// match('fooLang', doc); // 0
            /// match(['fooLang', '*'], doc); // 5
            /// 
            /// // virtual document, e.g. from git-index
            /// doc.uri; // 'git:/my/file.js'
            /// doc.languageId; // 'javascript'
            /// match('javascript', doc); // 10;
            /// match({language: 'javascript', scheme: 'git'}, doc); // 10;
            /// match('*', doc); // 5
            /// </code>
            /// </summary>
            /// <param name="selector">A document selector.</param>
            /// <param name="document">A text document.</param>
            /// <returns>A number <c>>0</c> when the selector matches and <c>0</c> when the selector does not match.</returns>
            abstract ``match``: selector: DocumentSelector * document: TextDocument -> float
            /// <summary>
            /// An <see cref="Event">event</see> which fires when the global set of diagnostics changes. This is
            /// newly added and removed diagnostics.
            /// </summary>
            abstract onDidChangeDiagnostics: Event<DiagnosticChangeEvent>
            /// <summary>
            /// Get all diagnostics for a given resource. *Note* that this includes diagnostics from
            /// all extensions but *not yet* from the task framework.
            /// </summary>
            /// <param name="resource">A resource</param>
            /// <returns>An array of <see cref="Diagnostic">diagnostics</see> objects or an empty array.</returns>
            abstract getDiagnostics: resource: Uri -> ResizeArray<Diagnostic>
            /// <summary>
            /// Get all diagnostics. *Note* that this includes diagnostics from
            /// all extensions but *not yet* from the task framework.
            /// </summary>
            /// <returns>An array of uri-diagnostics tuples or an empty array.</returns>
            abstract getDiagnostics: unit -> ResizeArray<Uri * ResizeArray<Diagnostic>>
            /// <summary>Create a diagnostics collection.</summary>
            /// <param name="name">The <see cref="DiagnosticCollection.name">name</see> of the collection.</param>
            /// <returns>A new diagnostic collection.</returns>
            abstract createDiagnosticCollection: ?name: string -> DiagnosticCollection
            /// <summary>
            /// Register a completion provider.
            /// 
            /// Multiple providers can be registered for a language. In that case providers are sorted
            /// by their <see cref="languages.match">score</see> and groups of equal score are sequentially asked for
            /// completion items. The process stops when one or many providers of a group return a
            /// result. A failing provider (rejected promise or exception) will not fail the whole
            /// operation.
            /// </summary>
            /// <param name="selector">A selector that defines the documents this provider is applicable to.</param>
            /// <param name="provider">A completion provider.</param>
            /// <param name="triggerCharacters">Trigger completion when the user types one of the characters, like <c>.</c> or <c>:</c>.</param>
            /// <returns>A <see cref="Disposable">disposable</see> that unregisters this provider when being disposed.</returns>
            abstract registerCompletionItemProvider: selector: DocumentSelector * provider: CompletionItemProvider * [<ParamArray>] triggerCharacters: string[] -> Disposable
            /// <summary>
            /// Register a code action provider.
            /// 
            /// Multiple providers can be registered for a language. In that case providers are asked in
            /// parallel and the results are merged. A failing provider (rejected promise or exception) will
            /// not cause a failure of the whole operation.
            /// </summary>
            /// <param name="selector">A selector that defines the documents this provider is applicable to.</param>
            /// <param name="provider">A code action provider.</param>
            /// <param name="metadata">Metadata about the kind of code actions the provider providers.</param>
            /// <returns>A <see cref="Disposable">disposable</see> that unregisters this provider when being disposed.</returns>
            abstract registerCodeActionsProvider: selector: DocumentSelector * provider: CodeActionProvider * ?metadata: CodeActionProviderMetadata -> Disposable
            /// <summary>
            /// Register a code lens provider.
            /// 
            /// Multiple providers can be registered for a language. In that case providers are asked in
            /// parallel and the results are merged. A failing provider (rejected promise or exception) will
            /// not cause a failure of the whole operation.
            /// </summary>
            /// <param name="selector">A selector that defines the documents this provider is applicable to.</param>
            /// <param name="provider">A code lens provider.</param>
            /// <returns>A <see cref="Disposable">disposable</see> that unregisters this provider when being disposed.</returns>
            abstract registerCodeLensProvider: selector: DocumentSelector * provider: CodeLensProvider -> Disposable
            /// <summary>
            /// Register a definition provider.
            /// 
            /// Multiple providers can be registered for a language. In that case providers are asked in
            /// parallel and the results are merged. A failing provider (rejected promise or exception) will
            /// not cause a failure of the whole operation.
            /// </summary>
            /// <param name="selector">A selector that defines the documents this provider is applicable to.</param>
            /// <param name="provider">A definition provider.</param>
            /// <returns>A <see cref="Disposable">disposable</see> that unregisters this provider when being disposed.</returns>
            abstract registerDefinitionProvider: selector: DocumentSelector * provider: DefinitionProvider -> Disposable
            /// <summary>
            /// Register an implementation provider.
            /// 
            /// Multiple providers can be registered for a language. In that case providers are asked in
            /// parallel and the results are merged. A failing provider (rejected promise or exception) will
            /// not cause a failure of the whole operation.
            /// </summary>
            /// <param name="selector">A selector that defines the documents this provider is applicable to.</param>
            /// <param name="provider">An implementation provider.</param>
            /// <returns>A <see cref="Disposable">disposable</see> that unregisters this provider when being disposed.</returns>
            abstract registerImplementationProvider: selector: DocumentSelector * provider: ImplementationProvider -> Disposable
            /// <summary>
            /// Register a type definition provider.
            /// 
            /// Multiple providers can be registered for a language. In that case providers are asked in
            /// parallel and the results are merged. A failing provider (rejected promise or exception) will
            /// not cause a failure of the whole operation.
            /// </summary>
            /// <param name="selector">A selector that defines the documents this provider is applicable to.</param>
            /// <param name="provider">A type definition provider.</param>
            /// <returns>A <see cref="Disposable">disposable</see> that unregisters this provider when being disposed.</returns>
            abstract registerTypeDefinitionProvider: selector: DocumentSelector * provider: TypeDefinitionProvider -> Disposable
            /// <summary>
            /// Register a declaration provider.
            /// 
            /// Multiple providers can be registered for a language. In that case providers are asked in
            /// parallel and the results are merged. A failing provider (rejected promise or exception) will
            /// not cause a failure of the whole operation.
            /// </summary>
            /// <param name="selector">A selector that defines the documents this provider is applicable to.</param>
            /// <param name="provider">A declaration provider.</param>
            /// <returns>A <see cref="Disposable">disposable</see> that unregisters this provider when being disposed.</returns>
            abstract registerDeclarationProvider: selector: DocumentSelector * provider: DeclarationProvider -> Disposable
            /// <summary>
            /// Register a hover provider.
            /// 
            /// Multiple providers can be registered for a language. In that case providers are asked in
            /// parallel and the results are merged. A failing provider (rejected promise or exception) will
            /// not cause a failure of the whole operation.
            /// </summary>
            /// <param name="selector">A selector that defines the documents this provider is applicable to.</param>
            /// <param name="provider">A hover provider.</param>
            /// <returns>A <see cref="Disposable">disposable</see> that unregisters this provider when being disposed.</returns>
            abstract registerHoverProvider: selector: DocumentSelector * provider: HoverProvider -> Disposable
            /// <summary>
            /// Register a document highlight provider.
            /// 
            /// Multiple providers can be registered for a language. In that case providers are sorted
            /// by their <see cref="languages.match">score</see> and groups sequentially asked for document highlights.
            /// The process stops when a provider returns a <c>non-falsy</c> or <c>non-failure</c> result.
            /// </summary>
            /// <param name="selector">A selector that defines the documents this provider is applicable to.</param>
            /// <param name="provider">A document highlight provider.</param>
            /// <returns>A <see cref="Disposable">disposable</see> that unregisters this provider when being disposed.</returns>
            abstract registerDocumentHighlightProvider: selector: DocumentSelector * provider: DocumentHighlightProvider -> Disposable
            /// <summary>
            /// Register a document symbol provider.
            /// 
            /// Multiple providers can be registered for a language. In that case providers are asked in
            /// parallel and the results are merged. A failing provider (rejected promise or exception) will
            /// not cause a failure of the whole operation.
            /// </summary>
            /// <param name="selector">A selector that defines the documents this provider is applicable to.</param>
            /// <param name="provider">A document symbol provider.</param>
            /// <param name="metaData">metadata about the provider</param>
            /// <returns>A <see cref="Disposable">disposable</see> that unregisters this provider when being disposed.</returns>
            abstract registerDocumentSymbolProvider: selector: DocumentSelector * provider: DocumentSymbolProvider * ?metaData: DocumentSymbolProviderMetadata -> Disposable
            /// <summary>
            /// Register a workspace symbol provider.
            /// 
            /// Multiple providers can be registered. In that case providers are asked in parallel and
            /// the results are merged. A failing provider (rejected promise or exception) will not cause
            /// a failure of the whole operation.
            /// </summary>
            /// <param name="provider">A workspace symbol provider.</param>
            /// <returns>A <see cref="Disposable">disposable</see> that unregisters this provider when being disposed.</returns>
            abstract registerWorkspaceSymbolProvider: provider: WorkspaceSymbolProvider -> Disposable
            /// <summary>
            /// Register a reference provider.
            /// 
            /// Multiple providers can be registered for a language. In that case providers are asked in
            /// parallel and the results are merged. A failing provider (rejected promise or exception) will
            /// not cause a failure of the whole operation.
            /// </summary>
            /// <param name="selector">A selector that defines the documents this provider is applicable to.</param>
            /// <param name="provider">A reference provider.</param>
            /// <returns>A <see cref="Disposable">disposable</see> that unregisters this provider when being disposed.</returns>
            abstract registerReferenceProvider: selector: DocumentSelector * provider: ReferenceProvider -> Disposable
            /// <summary>
            /// Register a rename provider.
            /// 
            /// Multiple providers can be registered for a language. In that case providers are sorted
            /// by their <see cref="languages.match">score</see> and the best-matching provider is used. Failure
            /// of the selected provider will cause a failure of the whole operation.
            /// </summary>
            /// <param name="selector">A selector that defines the documents this provider is applicable to.</param>
            /// <param name="provider">A rename provider.</param>
            /// <returns>A <see cref="Disposable">disposable</see> that unregisters this provider when being disposed.</returns>
            abstract registerRenameProvider: selector: DocumentSelector * provider: RenameProvider -> Disposable
            /// <summary>
            /// Register a formatting provider for a document.
            /// 
            /// Multiple providers can be registered for a language. In that case providers are sorted
            /// by their <see cref="languages.match">score</see> and the best-matching provider is used. Failure
            /// of the selected provider will cause a failure of the whole operation.
            /// </summary>
            /// <param name="selector">A selector that defines the documents this provider is applicable to.</param>
            /// <param name="provider">A document formatting edit provider.</param>
            /// <returns>A <see cref="Disposable">disposable</see> that unregisters this provider when being disposed.</returns>
            abstract registerDocumentFormattingEditProvider: selector: DocumentSelector * provider: DocumentFormattingEditProvider -> Disposable
            /// <summary>
            /// Register a formatting provider for a document range.
            /// 
            /// *Note:* A document range provider is also a <see cref="DocumentFormattingEditProvider">document formatter</see>
            /// which means there is no need to <see cref="languages.registerDocumentFormattingEditProvider">register</see> a document
            /// formatter when also registering a range provider.
            /// 
            /// Multiple providers can be registered for a language. In that case providers are sorted
            /// by their <see cref="languages.match">score</see> and the best-matching provider is used. Failure
            /// of the selected provider will cause a failure of the whole operation.
            /// </summary>
            /// <param name="selector">A selector that defines the documents this provider is applicable to.</param>
            /// <param name="provider">A document range formatting edit provider.</param>
            /// <returns>A <see cref="Disposable">disposable</see> that unregisters this provider when being disposed.</returns>
            abstract registerDocumentRangeFormattingEditProvider: selector: DocumentSelector * provider: DocumentRangeFormattingEditProvider -> Disposable
            /// <summary>
            /// Register a formatting provider that works on type. The provider is active when the user enables the setting <c>editor.formatOnType</c>.
            /// 
            /// Multiple providers can be registered for a language. In that case providers are sorted
            /// by their <see cref="languages.match">score</see> and the best-matching provider is used. Failure
            /// of the selected provider will cause a failure of the whole operation.
            /// </summary>
            /// <param name="selector">A selector that defines the documents this provider is applicable to.</param>
            /// <param name="provider">An on type formatting edit provider.</param>
            /// <param name="firstTriggerCharacter">A character on which formatting should be triggered, like <c>}</c>.</param>
            /// <param name="moreTriggerCharacter">More trigger characters.</param>
            /// <returns>A <see cref="Disposable">disposable</see> that unregisters this provider when being disposed.</returns>
            abstract registerOnTypeFormattingEditProvider: selector: DocumentSelector * provider: OnTypeFormattingEditProvider * firstTriggerCharacter: string * [<ParamArray>] moreTriggerCharacter: string[] -> Disposable
            /// <summary>
            /// Register a signature help provider.
            /// 
            /// Multiple providers can be registered for a language. In that case providers are sorted
            /// by their <see cref="languages.match">score</see> and called sequentially until a provider returns a
            /// valid result.
            /// </summary>
            /// <param name="selector">A selector that defines the documents this provider is applicable to.</param>
            /// <param name="provider">A signature help provider.</param>
            /// <param name="triggerCharacters">Trigger signature help when the user types one of the characters, like <c>,</c> or <c>(</c>.</param>
            /// <param name="metadata">Information about the provider.</param>
            /// <returns>A <see cref="Disposable">disposable</see> that unregisters this provider when being disposed.</returns>
            abstract registerSignatureHelpProvider: selector: DocumentSelector * provider: SignatureHelpProvider * [<ParamArray>] triggerCharacters: string[] -> Disposable
            abstract registerSignatureHelpProvider: selector: DocumentSelector * provider: SignatureHelpProvider * metadata: SignatureHelpProviderMetadata -> Disposable
            /// <summary>
            /// Register a document link provider.
            /// 
            /// Multiple providers can be registered for a language. In that case providers are asked in
            /// parallel and the results are merged. A failing provider (rejected promise or exception) will
            /// not cause a failure of the whole operation.
            /// </summary>
            /// <param name="selector">A selector that defines the documents this provider is applicable to.</param>
            /// <param name="provider">A document link provider.</param>
            /// <returns>A <see cref="Disposable">disposable</see> that unregisters this provider when being disposed.</returns>
            abstract registerDocumentLinkProvider: selector: DocumentSelector * provider: DocumentLinkProvider -> Disposable
            /// <summary>
            /// Register a color provider.
            /// 
            /// Multiple providers can be registered for a language. In that case providers are asked in
            /// parallel and the results are merged. A failing provider (rejected promise or exception) will
            /// not cause a failure of the whole operation.
            /// </summary>
            /// <param name="selector">A selector that defines the documents this provider is applicable to.</param>
            /// <param name="provider">A color provider.</param>
            /// <returns>A <see cref="Disposable">disposable</see> that unregisters this provider when being disposed.</returns>
            abstract registerColorProvider: selector: DocumentSelector * provider: DocumentColorProvider -> Disposable
            /// <summary>
            /// Register a folding range provider.
            /// 
            /// Multiple providers can be registered for a language. In that case providers are asked in
            /// parallel and the results are merged.
            /// If multiple folding ranges start at the same position, only the range of the first registered provider is used.
            /// If a folding range overlaps with an other range that has a smaller position, it is also ignored.
            /// 
            /// A failing provider (rejected promise or exception) will
            /// not cause a failure of the whole operation.
            /// </summary>
            /// <param name="selector">A selector that defines the documents this provider is applicable to.</param>
            /// <param name="provider">A folding range provider.</param>
            /// <returns>A <see cref="Disposable">disposable</see> that unregisters this provider when being disposed.</returns>
            abstract registerFoldingRangeProvider: selector: DocumentSelector * provider: FoldingRangeProvider -> Disposable
            /// <summary>Set a <see cref="LanguageConfiguration">language configuration</see> for a language.</summary>
            /// <param name="language">A language identifier like <c>typescript</c>.</param>
            /// <param name="configuration">Language configuration.</param>
            /// <returns>A <see cref="Disposable">disposable</see> that unsets this configuration.</returns>
            abstract setLanguageConfiguration: language: string * configuration: LanguageConfiguration -> Disposable

    /// Represents the input box in the Source Control viewlet.
    type [<AllowNullLiteral>] SourceControlInputBox =
        /// Setter and getter for the contents of the input box.
        abstract value: string with get, set
        /// A string to show as place holder in the input box to guide the user.
        abstract placeholder: string with get, set

    type [<AllowNullLiteral>] QuickDiffProvider =
        /// <summary>Provide a <see cref="Uri">uri</see> to the original resource of any given resource uri.</summary>
        /// <param name="uri">The uri of the resource open in a text editor.</param>
        /// <param name="token">A cancellation token.</param>
        /// <returns>A thenable that resolves to uri of the matching original resource.</returns>
        abstract provideOriginalResource: uri: Uri * token: CancellationToken -> ProviderResult<Uri>

    /// <summary>
    /// The theme-aware decorations for a
    /// <see cref="SourceControlResourceState">source control resource state</see>.
    /// </summary>
    type [<AllowNullLiteral>] SourceControlResourceThemableDecorations =
        /// <summary>
        /// The icon path for a specific
        /// <see cref="SourceControlResourceState">source control resource state</see>.
        /// </summary>
        abstract iconPath: U2<string, Uri> option

    /// <summary>
    /// The decorations for a <see cref="SourceControlResourceState">source control resource state</see>.
    /// Can be independently specified for light and dark themes.
    /// </summary>
    type [<AllowNullLiteral>] SourceControlResourceDecorations =
        inherit SourceControlResourceThemableDecorations
        /// <summary>
        /// Whether the <see cref="SourceControlResourceState">source control resource state</see> should
        /// be striked-through in the UI.
        /// </summary>
        abstract strikeThrough: bool option
        /// <summary>
        /// Whether the <see cref="SourceControlResourceState">source control resource state</see> should
        /// be faded in the UI.
        /// </summary>
        abstract faded: bool option
        /// <summary>
        /// The title for a specific
        /// <see cref="SourceControlResourceState">source control resource state</see>.
        /// </summary>
        abstract tooltip: string option
        /// The light theme decorations.
        abstract light: SourceControlResourceThemableDecorations option
        /// The dark theme decorations.
        abstract dark: SourceControlResourceThemableDecorations option

    /// <summary>
    /// An source control resource state represents the state of an underlying workspace
    /// resource within a certain <see cref="SourceControlResourceGroup">source control group</see>.
    /// </summary>
    type [<AllowNullLiteral>] SourceControlResourceState =
        /// <summary>The <see cref="Uri">uri</see> of the underlying resource inside the workspace.</summary>
        abstract resourceUri: Uri
        /// <summary>
        /// The <see cref="Command">command</see> which should be run when the resource
        /// state is open in the Source Control viewlet.
        /// </summary>
        abstract command: Command option
        /// <summary>
        /// The <see cref="SourceControlResourceDecorations">decorations</see> for this source control
        /// resource state.
        /// </summary>
        abstract decorations: SourceControlResourceDecorations option

    /// <summary>
    /// A source control resource group is a collection of
    /// <see cref="SourceControlResourceState">source control resource states</see>.
    /// </summary>
    type [<AllowNullLiteral>] SourceControlResourceGroup =
        /// The id of this source control resource group.
        abstract id: string
        /// The label of this source control resource group.
        abstract label: string with get, set
        /// <summary>
        /// Whether this source control resource group is hidden when it contains
        /// no <see cref="SourceControlResourceState">source control resource states</see>.
        /// </summary>
        abstract hideWhenEmpty: bool option with get, set
        /// <summary>
        /// This group's collection of
        /// <see cref="SourceControlResourceState">source control resource states</see>.
        /// </summary>
        abstract resourceStates: ResizeArray<SourceControlResourceState> with get, set
        /// Dispose this source control resource group.
        abstract dispose: unit -> unit

    /// <summary>
    /// An source control is able to provide <see cref="SourceControlResourceState">resource states</see>
    /// to the editor and interact with the editor in several source control related ways.
    /// </summary>
    type [<AllowNullLiteral>] SourceControl =
        /// The id of this source control.
        abstract id: string
        /// The human-readable label of this source control.
        abstract label: string
        /// The (optional) Uri of the root of this source control.
        abstract rootUri: Uri option
        /// <summary>The <see cref="SourceControlInputBox">input box</see> for this source control.</summary>
        abstract inputBox: SourceControlInputBox
        /// <summary>
        /// The UI-visible count of <see cref="SourceControlResourceState">resource states</see> of
        /// this source control.
        /// 
        /// Equals to the total number of <see cref="SourceControlResourceState">resource state</see>
        /// of this source control, if undefined.
        /// </summary>
        abstract count: float option with get, set
        /// <summary>An optional <see cref="QuickDiffProvider">quick diff provider</see>.</summary>
        abstract quickDiffProvider: QuickDiffProvider option with get, set
        /// Optional commit template string.
        /// 
        /// The Source Control viewlet will populate the Source Control
        /// input with this value when appropriate.
        abstract commitTemplate: string option with get, set
        /// Optional accept input command.
        /// 
        /// This command will be invoked when the user accepts the value
        /// in the Source Control input.
        abstract acceptInputCommand: Command option with get, set
        /// Optional status bar commands.
        /// 
        /// These commands will be displayed in the editor's status bar.
        abstract statusBarCommands: ResizeArray<Command> option with get, set
        /// <summary>Create a new <see cref="SourceControlResourceGroup">resource group</see>.</summary>
        abstract createResourceGroup: id: string * label: string -> SourceControlResourceGroup
        /// Dispose this source control.
        abstract dispose: unit -> unit

    module Scm =

        type [<AllowNullLiteral>] IExports =
            /// <summary>
            /// ~~The <see cref="SourceControlInputBox">input box</see> for the last source control
            /// created by the extension.~~
            /// </summary>
            [<Obsolete("Use SourceControl.inputBox instead")>]
            abstract inputBox: SourceControlInputBox
            /// <summary>Creates a new <see cref="SourceControl">source control</see> instance.</summary>
            /// <param name="id">An <c>id</c> for the source control. Something short, eg: <c>git</c>.</param>
            /// <param name="label">A human-readable string for the source control. Eg: <c>Git</c>.</param>
            /// <param name="rootUri">An optional Uri of the root of the source control. Eg: <c>Uri.parse(workspaceRoot)</c>.</param>
            /// <returns>An instance of <see cref="SourceControl">source control</see>.</returns>
            abstract createSourceControl: id: string * label: string * ?rootUri: Uri -> SourceControl

    /// Configuration for a debug session.
    type [<AllowNullLiteral>] DebugConfiguration =
        /// The type of the debug session.
        abstract ``type``: string with get, set
        /// The name of the debug session.
        abstract name: string with get, set
        /// The request type of the debug session.
        abstract request: string with get, set
        /// Additional debug type specific properties.
        [<EmitIndexer>] abstract Item: key: string -> obj option with get, set

    /// A debug session.
    type [<AllowNullLiteral>] DebugSession =
        /// The unique ID of this debug session.
        abstract id: string
        /// <summary>The debug session's type from the <see cref="DebugConfiguration">debug configuration</see>.</summary>
        abstract ``type``: string
        /// <summary>The debug session's name from the <see cref="DebugConfiguration">debug configuration</see>.</summary>
        abstract name: string
        /// <summary>The workspace folder of this session or <c>undefined</c> for a folderless setup.</summary>
        abstract workspaceFolder: WorkspaceFolder option
        /// <summary>
        /// The "resolved" <see cref="DebugConfiguration">debug configuration</see> of this session.
        /// "Resolved" means that
        /// - all variables have been substituted and
        /// - platform specific attribute sections have been "flattened" for the matching platform and removed for non-matching platforms.
        /// </summary>
        abstract configuration: DebugConfiguration
        /// Send a custom request to the debug adapter.
        abstract customRequest: command: string * ?args: obj -> Thenable<obj option>

    /// <summary>A custom Debug Adapter Protocol event received from a <see cref="DebugSession">debug session</see>.</summary>
    type [<AllowNullLiteral>] DebugSessionCustomEvent =
        /// <summary>The <see cref="DebugSession">debug session</see> for which the custom event was received.</summary>
        abstract session: DebugSession with get, set
        /// Type of event.
        abstract ``event``: string with get, set
        /// Event specific information.
        abstract body: obj option with get, set

    /// A debug configuration provider allows to add the initial debug configurations to a newly created launch.json
    /// and to resolve a launch configuration before it is used to start a new debug session.
    /// A debug configuration provider is registered via #debug.registerDebugConfigurationProvider.
    type [<AllowNullLiteral>] DebugConfigurationProvider =
        /// <summary>
        /// Provides initial <see cref="DebugConfiguration">debug configuration</see>. If more than one debug configuration provider is
        /// registered for the same type, debug configurations are concatenated in arbitrary order.
        /// </summary>
        /// <param name="folder">The workspace folder for which the configurations are used or <c>undefined</c> for a folderless setup.</param>
        /// <param name="token">A cancellation token.</param>
        /// <returns>An array of <see cref="DebugConfiguration">debug configurations</see>.</returns>
        abstract provideDebugConfigurations: folder: WorkspaceFolder option * ?token: CancellationToken -> ProviderResult<ResizeArray<DebugConfiguration>>
        /// <summary>
        /// Resolves a <see cref="DebugConfiguration">debug configuration</see> by filling in missing values or by adding/changing/removing attributes.
        /// If more than one debug configuration provider is registered for the same type, the resolveDebugConfiguration calls are chained
        /// in arbitrary order and the initial debug configuration is piped through the chain.
        /// Returning the value 'undefined' prevents the debug session from starting.
        /// Returning the value 'null' prevents the debug session from starting and opens the underlying debug configuration instead.
        /// </summary>
        /// <param name="folder">The workspace folder from which the configuration originates from or <c>undefined</c> for a folderless setup.</param>
        /// <param name="debugConfiguration">The <see cref="DebugConfiguration">debug configuration</see> to resolve.</param>
        /// <param name="token">A cancellation token.</param>
        /// <returns>The resolved debug configuration or undefined or null.</returns>
        abstract resolveDebugConfiguration: folder: WorkspaceFolder option * debugConfiguration: DebugConfiguration * ?token: CancellationToken -> ProviderResult<DebugConfiguration>

    /// Represents a debug adapter executable and optional arguments and runtime options passed to it.
    type [<AllowNullLiteral>] DebugAdapterExecutable =
        /// The command or path of the debug adapter executable.
        /// A command must be either an absolute path of an executable or the name of an command to be looked up via the PATH environment variable.
        /// The special value 'node' will be mapped to VS Code's built-in Node.js runtime.
        abstract command: string
        /// The arguments passed to the debug adapter executable. Defaults to an empty array.
        abstract args: ResizeArray<string>
        /// Optional options to be used when the debug adapter is started.
        /// Defaults to undefined.
        abstract options: DebugAdapterExecutableOptions option

    /// Represents a debug adapter executable and optional arguments and runtime options passed to it.
    type [<AllowNullLiteral>] DebugAdapterExecutableStatic =
        /// <summary>Creates a description for a debug adapter based on an executable program.</summary>
        /// <param name="command">The command or executable path that implements the debug adapter.</param>
        /// <param name="args">Optional arguments to be passed to the command or executable.</param>
        /// <param name="options">Optional options to be used when starting the command or executable.</param>
        [<EmitConstructor>] abstract Create: command: string * ?args: ResizeArray<string> * ?options: DebugAdapterExecutableOptions -> DebugAdapterExecutable

    /// Options for a debug adapter executable.
    type [<AllowNullLiteral>] DebugAdapterExecutableOptions =
        /// The additional environment of the executed program or shell. If omitted
        /// the parent process' environment is used. If provided it is merged with
        /// the parent process' environment.
        abstract env: {| Item: string |} option with get, set
        /// The current working directory for the executed debug adapter.
        abstract cwd: string option with get, set

    /// Represents a debug adapter running as a socket based server.
    type [<AllowNullLiteral>] DebugAdapterServer =
        /// The port.
        abstract port: float
        /// The host.
        abstract host: string option

    /// Represents a debug adapter running as a socket based server.
    type [<AllowNullLiteral>] DebugAdapterServerStatic =
        /// Create a description for a debug adapter running as a socket based server.
        [<EmitConstructor>] abstract Create: port: float * ?host: string -> DebugAdapterServer

    type DebugAdapterDescriptor =
        U2<DebugAdapterExecutable, DebugAdapterServer>

    type [<AllowNullLiteral>] DebugAdapterDescriptorFactory =
        /// <summary>
        /// 'createDebugAdapterDescriptor' is called at the start of a debug session to provide details about the debug adapter to use.
        /// These details must be returned as objects of type <see cref="DebugAdapterDescriptor">DebugAdapterDescriptor</see>.
        /// Currently two types of debug adapters are supported:
        /// - a debug adapter executable is specified as a command path and arguments (see <see cref="DebugAdapterExecutable)">DebugAdapterExecutable</see>,
        /// - a debug adapter server reachable via a communication port (see <see cref="DebugAdapterServer)">DebugAdapterServer</see>.
        /// If the method is not implemented the default behavior is this:
        ///    createDebugAdapter(session: DebugSession, executable: DebugAdapterExecutable) {
        ///       if (typeof session.configuration.debugServer === 'number') {
        ///          return new DebugAdapterServer(session.configuration.debugServer);
        ///       }
        ///       return executable;
        ///    }
        /// </summary>
        /// <param name="session">The <see cref="DebugSession">debug session</see> for which the debug adapter will be used.</param>
        /// <param name="executable">The debug adapter's executable information as specified in the package.json (or undefined if no such information exists).</param>
        /// <returns>a <see cref="DebugAdapterDescriptor">debug adapter descriptor</see> or undefined.</returns>
        abstract createDebugAdapterDescriptor: session: DebugSession * executable: DebugAdapterExecutable option -> ProviderResult<DebugAdapterDescriptor>

    /// A Debug Adapter Tracker is a means to track the communication between VS Code and a Debug Adapter.
    type [<AllowNullLiteral>] DebugAdapterTracker =
        /// A session with the debug adapter is about to be started.
        abstract onWillStartSession: unit -> unit
        /// The debug adapter is about to receive a Debug Adapter Protocol message from VS Code.
        abstract onWillReceiveMessage: message: obj option -> unit
        /// The debug adapter has sent a Debug Adapter Protocol message to VS Code.
        abstract onDidSendMessage: message: obj option -> unit
        /// The debug adapter session is about to be stopped.
        abstract onWillStopSession: unit -> unit
        /// An error with the debug adapter has occurred.
        abstract onError: error: Error -> unit
        /// The debug adapter has exited with the given exit code or signal.
        abstract onExit: code: float option * signal: string option -> unit

    type [<AllowNullLiteral>] DebugAdapterTrackerFactory =
        /// <summary>
        /// The method 'createDebugAdapterTracker' is called at the start of a debug session in order
        /// to return a "tracker" object that provides read-access to the communication between VS Code and a debug adapter.
        /// </summary>
        /// <param name="session">The <see cref="DebugSession">debug session</see> for which the debug adapter tracker will be used.</param>
        /// <returns>A <see cref="DebugAdapterTracker">debug adapter tracker</see> or undefined.</returns>
        abstract createDebugAdapterTracker: session: DebugSession -> ProviderResult<DebugAdapterTracker>

    /// Represents the debug console.
    type [<AllowNullLiteral>] DebugConsole =
        /// <summary>Append the given value to the debug console.</summary>
        /// <param name="value">A string, falsy values will not be printed.</param>
        abstract append: value: string -> unit
        /// <summary>
        /// Append the given value and a line feed character
        /// to the debug console.
        /// </summary>
        /// <param name="value">A string, falsy values will be printed.</param>
        abstract appendLine: value: string -> unit

    /// <summary>An event describing the changes to the set of <see cref="Breakpoint">breakpoints</see>.</summary>
    type [<AllowNullLiteral>] BreakpointsChangeEvent =
        /// Added breakpoints.
        abstract added: ResizeArray<Breakpoint>
        /// Removed breakpoints.
        abstract removed: ResizeArray<Breakpoint>
        /// Changed breakpoints.
        abstract changed: ResizeArray<Breakpoint>

    /// The base class of all breakpoint types.
    type [<AllowNullLiteral>] Breakpoint =
        /// The unique ID of the breakpoint.
        abstract id: string
        /// Is breakpoint enabled.
        abstract enabled: bool
        /// An optional expression for conditional breakpoints.
        abstract condition: string option
        /// An optional expression that controls how many hits of the breakpoint are ignored.
        abstract hitCondition: string option
        /// An optional message that gets logged when this breakpoint is hit. Embedded expressions within {} are interpolated by the debug adapter.
        abstract logMessage: string option

    /// The base class of all breakpoint types.
    type [<AllowNullLiteral>] BreakpointStatic =
        [<EmitConstructor>] abstract Create: ?enabled: bool * ?condition: string * ?hitCondition: string * ?logMessage: string -> Breakpoint

    /// A breakpoint specified by a source location.
    type [<AllowNullLiteral>] SourceBreakpoint =
        inherit Breakpoint
        /// The source and line position of this breakpoint.
        abstract location: Location

    /// A breakpoint specified by a source location.
    type [<AllowNullLiteral>] SourceBreakpointStatic =
        /// Create a new breakpoint for a source location.
        [<EmitConstructor>] abstract Create: location: Location * ?enabled: bool * ?condition: string * ?hitCondition: string * ?logMessage: string -> SourceBreakpoint

    /// A breakpoint specified by a function name.
    type [<AllowNullLiteral>] FunctionBreakpoint =
        inherit Breakpoint
        /// The name of the function to which this breakpoint is attached.
        abstract functionName: string

    /// A breakpoint specified by a function name.
    type [<AllowNullLiteral>] FunctionBreakpointStatic =
        /// Create a new function breakpoint.
        [<EmitConstructor>] abstract Create: functionName: string * ?enabled: bool * ?condition: string * ?hitCondition: string * ?logMessage: string -> FunctionBreakpoint

    /// Namespace for debug functionality.
    module Debug =

        type [<AllowNullLiteral>] IExports =
            /// <summary>
            /// The currently active <see cref="DebugSession">debug session</see> or <c>undefined</c>. The active debug session is the one
            /// represented by the debug action floating window or the one currently shown in the drop down menu of the debug action floating window.
            /// If no debug session is active, the value is <c>undefined</c>.
            /// </summary>
            abstract activeDebugSession: DebugSession option with get, set
            /// <summary>
            /// The currently active <see cref="DebugConsole">debug console</see>.
            /// If no debug session is active, output sent to the debug console is not shown.
            /// </summary>
            abstract activeDebugConsole: DebugConsole with get, set
            /// List of breakpoints.
            abstract breakpoints: ResizeArray<Breakpoint> with get, set
            /// <summary>
            /// An <see cref="Event">event</see> which fires when the <see cref="debug.activeDebugSession">active debug session</see>
            /// has changed. *Note* that the event also fires when the active debug session changes
            /// to <c>undefined</c>.
            /// </summary>
            abstract onDidChangeActiveDebugSession: Event<DebugSession option>
            /// <summary>An <see cref="Event">event</see> which fires when a new <see cref="DebugSession">debug session</see> has been started.</summary>
            abstract onDidStartDebugSession: Event<DebugSession>
            /// <summary>An <see cref="Event">event</see> which fires when a custom DAP event is received from the <see cref="DebugSession">debug session</see>.</summary>
            abstract onDidReceiveDebugSessionCustomEvent: Event<DebugSessionCustomEvent>
            /// <summary>An <see cref="Event">event</see> which fires when a <see cref="DebugSession">debug session</see> has terminated.</summary>
            abstract onDidTerminateDebugSession: Event<DebugSession>
            /// <summary>An <see cref="Event">event</see> that is emitted when the set of breakpoints is added, removed, or changed.</summary>
            abstract onDidChangeBreakpoints: Event<BreakpointsChangeEvent>
            /// <summary>
            /// Register a <see cref="DebugConfigurationProvider">debug configuration provider</see> for a specific debug type.
            /// More than one provider can be registered for the same type.
            /// </summary>
            /// <param name="type">The debug type for which the provider is registered.</param>
            /// <param name="provider">The <see cref="DebugConfigurationProvider">debug configuration provider</see> to register.</param>
            /// <returns>A <see cref="Disposable">disposable</see> that unregisters this provider when being disposed.</returns>
            abstract registerDebugConfigurationProvider: debugType: string * provider: DebugConfigurationProvider -> Disposable
            /// <summary>
            /// Register a <see cref="DebugAdapterDescriptorFactory">debug adapter descriptor factory</see> for a specific debug type.
            /// An extension is only allowed to register a DebugAdapterDescriptorFactory for the debug type(s) defined by the extension. Otherwise an error is thrown.
            /// Registering more than one DebugAdapterDescriptorFactory for a debug type results in an error.
            /// </summary>
            /// <param name="debugType">The debug type for which the factory is registered.</param>
            /// <param name="factory">The <see cref="DebugAdapterDescriptorFactory">debug adapter descriptor factory</see> to register.</param>
            /// <returns>A <see cref="Disposable">disposable</see> that unregisters this factory when being disposed.</returns>
            abstract registerDebugAdapterDescriptorFactory: debugType: string * factory: DebugAdapterDescriptorFactory -> Disposable
            /// <summary>Register a debug adapter tracker factory for the given debug type.</summary>
            /// <param name="debugType">The debug type for which the factory is registered or '*' for matching all debug types.</param>
            /// <param name="factory">The <see cref="DebugAdapterTrackerFactory">debug adapter tracker factory</see> to register.</param>
            /// <returns>A <see cref="Disposable">disposable</see> that unregisters this factory when being disposed.</returns>
            abstract registerDebugAdapterTrackerFactory: debugType: string * factory: DebugAdapterTrackerFactory -> Disposable
            /// <summary>
            /// Start debugging by using either a named launch or named compound configuration,
            /// or by directly passing a <see cref="DebugConfiguration">DebugConfiguration</see>.
            /// The named configurations are looked up in '.vscode/launch.json' found in the given folder.
            /// Before debugging starts, all unsaved files are saved and the launch configurations are brought up-to-date.
            /// Folder specific variables used in the configuration (e.g. '${workspaceFolder}') are resolved against the given folder.
            /// </summary>
            /// <param name="folder">The <see cref="WorkspaceFolder">workspace folder</see> for looking up named configurations and resolving variables or <c>undefined</c> for a non-folder setup.</param>
            /// <param name="nameOrConfiguration">Either the name of a debug or compound configuration or a <see cref="DebugConfiguration">DebugConfiguration</see> object.</param>
            /// <returns>A thenable that resolves when debugging could be successfully started.</returns>
            abstract startDebugging: folder: WorkspaceFolder option * nameOrConfiguration: U2<string, DebugConfiguration> -> Thenable<bool>
            /// <summary>Add breakpoints.</summary>
            /// <param name="breakpoints">The breakpoints to add.</param>
            abstract addBreakpoints: breakpoints: ResizeArray<Breakpoint> -> unit
            /// <summary>Remove breakpoints.</summary>
            /// <param name="breakpoints">The breakpoints to remove.</param>
            abstract removeBreakpoints: breakpoints: ResizeArray<Breakpoint> -> unit

    /// <summary>
    /// Namespace for dealing with installed extensions. Extensions are represented
    /// by an <see cref="Extension">extension</see>-interface which enables reflection on them.
    /// 
    /// Extension writers can provide APIs to other extensions by returning their API public
    /// surface from the <c>activate</c>-call.
    /// 
    /// <code language="javascript">
    /// export function activate(context: vscode.ExtensionContext) {
    ///  	let api = {
    ///  		sum(a, b) {
    ///  			return a + b;
    ///  		},
    ///  		mul(a, b) {
    ///  			return a * b;
    ///  		}
    ///  	};
    ///  	// 'export' public api-surface
    ///  	return api;
    /// }
    /// </code>
    /// When depending on the API of another extension add an <c>extensionDependency</c>-entry
    /// to <c>package.json</c>, and use the <see cref="extensions.getExtension">getExtension</see>-function
    /// and the <see cref="Extension.exports">exports</see>-property, like below:
    /// 
    /// <code language="javascript">
    /// let mathExt = extensions.getExtension('genius.math');
    /// let importedApi = mathExt.exports;
    /// 
    /// console.log(importedApi.mul(42, 1));
    /// </code>
    /// </summary>
    module Extensions =

        type [<AllowNullLiteral>] IExports =
            /// <summary>Get an extension by its full identifier in the form of: <c>publisher.name</c>.</summary>
            /// <param name="extensionId">An extension identifier.</param>
            /// <returns>An extension or <c>undefined</c>.</returns>
            abstract getExtension: extensionId: string -> Extension<obj option> option
            /// <summary>Get an extension its full identifier in the form of: <c>publisher.name</c>.</summary>
            /// <param name="extensionId">An extension identifier.</param>
            /// <returns>An extension or <c>undefined</c>.</returns>
            abstract getExtension: extensionId: string -> Extension<'T> option
            /// All extensions currently known to the system.
            abstract all: ResizeArray<Extension<obj option>> with get, set
            /// <summary>
            /// An event which fires when <c>extensions.all</c> changes. This can happen when extensions are
            /// installed, uninstalled, enabled or disabled.
            /// </summary>
            abstract onDidChange: Event<unit>

    type [<AllowNullLiteral>] WorkspaceConfigurationInspect<'T> =
        abstract key: string with get, set
        abstract defaultValue: 'T option with get, set
        abstract globalValue: 'T option with get, set
        abstract workspaceValue: 'T option with get, set
        abstract workspaceFolderValue: 'T option with get, set

/// Thenable is a common denominator between ES6 promises, Q, jquery.Deferred, WinJS.Promise,
/// and others. This API makes no assumption about what promise library is being used which
/// enables reusing existing code without migrating to a specific promise implementation. Still,
/// we recommend the use of native promises which are available in this editor.
type [<AllowNullLiteral>] Thenable<'T> =
    /// <summary>Attaches callbacks for the resolution and/or rejection of the Promise.</summary>
    /// <param name="onfulfilled">The callback to execute when the Promise is resolved.</param>
    /// <param name="onrejected">The callback to execute when the Promise is rejected.</param>
    /// <returns>A Promise for the completion of which ever callback is executed.</returns>
    abstract ``then``: ?onfulfilled: ('T -> U2<'TResult, Thenable<'TResult>>) * ?onrejected: (obj option -> U2<'TResult, Thenable<'TResult>>) -> Thenable<'TResult>
    abstract ``then``: ?onfulfilled: ('T -> U2<'TResult, Thenable<'TResult>>) * ?onrejected: (obj option -> unit) -> Thenable<'TResult>

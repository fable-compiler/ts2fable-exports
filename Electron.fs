// ts2fable 0.0.0
module rec Electron
open System
open Fable.Core
open Fable.Import.JS
open Fable.Import.Browser


type GlobalEvent =
    Event

module Electron =

    type [<AllowNullLiteral>] IExports =
        abstract EventEmitter: EventEmitterStatic
        abstract Accelerator: AcceleratorStatic
        abstract app: App
        abstract autoUpdater: AutoUpdater
        abstract clipboard: Clipboard
        abstract contentTracing: ContentTracing
        abstract crashReporter: CrashReporter
        abstract desktopCapturer: DesktopCapturer
        abstract dialog: Dialog
        abstract globalShortcut: GlobalShortcut
        abstract ipcMain: IpcMain
        abstract ipcRenderer: IpcRenderer
        abstract nativeImage: obj
        abstract net: Net
        abstract powerMonitor: PowerMonitor
        abstract powerSaveBlocker: PowerSaveBlocker
        abstract protocol: Protocol
        abstract remote: Remote
        abstract screen: Screen
        abstract session: obj
        abstract shell: Shell
        abstract systemPreferences: SystemPreferences
        abstract webContents: obj
        abstract webFrame: WebFrame
        abstract webviewTag: WebviewTag
        abstract BrowserView: BrowserViewStatic
        abstract BrowserWindow: BrowserWindowStatic
        abstract BrowserWindowProxy: BrowserWindowProxyStatic
        abstract ClientRequest: ClientRequestStatic
        abstract Cookies: CookiesStatic
        abstract Debugger: DebuggerStatic
        abstract DownloadItem: DownloadItemStatic
        abstract IncomingMessage: IncomingMessageStatic
        abstract Menu: MenuStatic
        abstract MenuItem: MenuItemStatic
        abstract NativeImage: NativeImageStatic
        abstract Notification: NotificationStatic
        abstract Session: SessionStatic
        abstract TouchBarButton: TouchBarButtonStatic
        abstract TouchBarColorPicker: TouchBarColorPickerStatic
        abstract TouchBarGroup: TouchBarGroupStatic
        abstract TouchBarLabel: TouchBarLabelStatic
        abstract TouchBarPopover: TouchBarPopoverStatic
        abstract TouchBarScrubber: TouchBarScrubberStatic
        abstract TouchBarSegmentedControl: TouchBarSegmentedControlStatic
        abstract TouchBarSlider: TouchBarSliderStatic
        abstract TouchBarSpacer: TouchBarSpacerStatic
        abstract TouchBar: TouchBarStatic
        abstract Tray: TrayStatic
        abstract WebContents: WebContentsStatic
        abstract WebRequest: WebRequestStatic

    type [<AllowNullLiteral>] EventEmitter =
        abstract addListener: ``event``: string * listener: Function -> EventEmitter
        abstract on: ``event``: string * listener: Function -> EventEmitter
        abstract once: ``event``: string * listener: Function -> EventEmitter
        abstract removeListener: ``event``: string * listener: Function -> EventEmitter
        abstract removeAllListeners: ?``event``: string -> EventEmitter
        abstract setMaxListeners: n: float -> EventEmitter
        abstract getMaxListeners: unit -> float
        abstract listeners: ``event``: string -> ResizeArray<Function>
        abstract emit: ``event``: string * [<ParamArray>] args: ResizeArray<obj option> -> bool
        abstract listenerCount: ``type``: string -> float
        abstract prependListener: ``event``: string * listener: Function -> EventEmitter
        abstract prependOnceListener: ``event``: string * listener: Function -> EventEmitter
        abstract eventNames: unit -> ResizeArray<string>

    type [<AllowNullLiteral>] EventEmitterStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> EventEmitter

    type [<AllowNullLiteral>] Accelerator =
        inherit String

    type [<AllowNullLiteral>] AcceleratorStatic =
        [<Emit "new $0($1...)">] abstract Create: image: U2<NativeImage, string> -> Accelerator

    type [<AllowNullLiteral>] Event =
        inherit GlobalEvent
        abstract preventDefault: (unit -> unit) with get, set
        abstract sender: WebContents with get, set
        abstract returnValue: obj option with get, set
        abstract ctrlKey: bool option with get, set
        abstract metaKey: bool option with get, set
        abstract shiftKey: bool option with get, set
        abstract altKey: bool option with get, set

    type [<AllowNullLiteral>] CommonInterface =
        abstract clipboard: Clipboard with get, set
        abstract crashReporter: CrashReporter with get, set
        abstract nativeImage: obj with get, set
        abstract screen: Screen with get, set
        abstract shell: Shell with get, set

    type [<AllowNullLiteral>] MainInterface =
        inherit CommonInterface
        abstract app: App with get, set
        abstract autoUpdater: AutoUpdater with get, set
        abstract BrowserView: obj with get, set
        abstract BrowserWindow: obj with get, set
        abstract ClientRequest: obj with get, set
        abstract contentTracing: ContentTracing with get, set
        abstract Cookies: obj with get, set
        abstract Debugger: obj with get, set
        abstract dialog: Dialog with get, set
        abstract DownloadItem: obj with get, set
        abstract globalShortcut: GlobalShortcut with get, set
        abstract IncomingMessage: obj with get, set
        abstract ipcMain: IpcMain with get, set
        abstract Menu: obj with get, set
        abstract MenuItem: obj with get, set
        abstract net: Net with get, set
        abstract Notification: obj with get, set
        abstract powerMonitor: PowerMonitor with get, set
        abstract powerSaveBlocker: PowerSaveBlocker with get, set
        abstract protocol: Protocol with get, set
        abstract session: obj with get, set
        abstract systemPreferences: SystemPreferences with get, set
        abstract TouchBar: obj with get, set
        abstract Tray: obj with get, set
        abstract webContents: obj with get, set
        abstract WebRequest: obj with get, set

    type [<AllowNullLiteral>] RendererInterface =
        inherit CommonInterface
        abstract BrowserWindowProxy: obj with get, set
        abstract desktopCapturer: DesktopCapturer with get, set
        abstract ipcRenderer: IpcRenderer with get, set
        abstract remote: Remote with get, set
        abstract webFrame: WebFrame with get, set
        abstract webviewTag: WebviewTag with get, set

    type [<AllowNullLiteral>] AllElectron =
        inherit MainInterface
        inherit RendererInterface

    type nativeImage =
        NativeImage

    type session =
        Session

    type webContents =
        WebContents

    type [<AllowNullLiteral>] App =
        inherit EventEmitter
        /// Emitted when Chrome's accessibility support changes. This event fires when
        /// assistive technologies, such as screen readers, are enabled or disabled. See
        /// https://www.chromium.org/developers/design-documents/accessibility for more
        /// details.
        [<Emit "$0.on('accessibility-support-changed',$1)">] abstract ``on_accessibility-support-changed``: listener: (Event -> bool -> unit) -> App
        [<Emit "$0.once('accessibility-support-changed',$1)">] abstract ``once_accessibility-support-changed``: listener: (Event -> bool -> unit) -> App
        [<Emit "$0.addListener('accessibility-support-changed',$1)">] abstract ``addListener_accessibility-support-changed``: listener: (Event -> bool -> unit) -> App
        [<Emit "$0.removeListener('accessibility-support-changed',$1)">] abstract ``removeListener_accessibility-support-changed``: listener: (Event -> bool -> unit) -> App
        /// Emitted when the application is activated. Various actions can trigger this
        /// event, such as launching the application for the first time, attempting to
        /// re-launch the application when it's already running, or clicking on the
        /// application's dock or taskbar icon.
        [<Emit "$0.on('activate',$1)">] abstract on_activate: listener: (Event -> bool -> unit) -> App
        [<Emit "$0.once('activate',$1)">] abstract once_activate: listener: (Event -> bool -> unit) -> App
        [<Emit "$0.addListener('activate',$1)">] abstract addListener_activate: listener: (Event -> bool -> unit) -> App
        [<Emit "$0.removeListener('activate',$1)">] abstract removeListener_activate: listener: (Event -> bool -> unit) -> App
        /// Emitted during Handoff after an activity from this device was successfully
        /// resumed on another one.
        [<Emit "$0.on('activity-was-continued',$1)">] abstract ``on_activity-was-continued``: listener: (Event -> string -> obj option -> unit) -> App
        [<Emit "$0.once('activity-was-continued',$1)">] abstract ``once_activity-was-continued``: listener: (Event -> string -> obj option -> unit) -> App
        [<Emit "$0.addListener('activity-was-continued',$1)">] abstract ``addListener_activity-was-continued``: listener: (Event -> string -> obj option -> unit) -> App
        [<Emit "$0.removeListener('activity-was-continued',$1)">] abstract ``removeListener_activity-was-continued``: listener: (Event -> string -> obj option -> unit) -> App
        /// Emitted before the application starts closing its windows. Calling
        /// event.preventDefault() will prevent the default behaviour, which is terminating
        /// the application. Note: If application quit was initiated by
        /// autoUpdater.quitAndInstall() then before-quit is emitted after emitting close
        /// event on all windows and closing them.
        [<Emit "$0.on('before-quit',$1)">] abstract ``on_before-quit``: listener: (Event -> unit) -> App
        [<Emit "$0.once('before-quit',$1)">] abstract ``once_before-quit``: listener: (Event -> unit) -> App
        [<Emit "$0.addListener('before-quit',$1)">] abstract ``addListener_before-quit``: listener: (Event -> unit) -> App
        [<Emit "$0.removeListener('before-quit',$1)">] abstract ``removeListener_before-quit``: listener: (Event -> unit) -> App
        /// Emitted when a browserWindow gets blurred.
        [<Emit "$0.on('browser-window-blur',$1)">] abstract ``on_browser-window-blur``: listener: (Event -> BrowserWindow -> unit) -> App
        [<Emit "$0.once('browser-window-blur',$1)">] abstract ``once_browser-window-blur``: listener: (Event -> BrowserWindow -> unit) -> App
        [<Emit "$0.addListener('browser-window-blur',$1)">] abstract ``addListener_browser-window-blur``: listener: (Event -> BrowserWindow -> unit) -> App
        [<Emit "$0.removeListener('browser-window-blur',$1)">] abstract ``removeListener_browser-window-blur``: listener: (Event -> BrowserWindow -> unit) -> App
        /// Emitted when a new browserWindow is created.
        [<Emit "$0.on('browser-window-created',$1)">] abstract ``on_browser-window-created``: listener: (Event -> BrowserWindow -> unit) -> App
        [<Emit "$0.once('browser-window-created',$1)">] abstract ``once_browser-window-created``: listener: (Event -> BrowserWindow -> unit) -> App
        [<Emit "$0.addListener('browser-window-created',$1)">] abstract ``addListener_browser-window-created``: listener: (Event -> BrowserWindow -> unit) -> App
        [<Emit "$0.removeListener('browser-window-created',$1)">] abstract ``removeListener_browser-window-created``: listener: (Event -> BrowserWindow -> unit) -> App
        /// Emitted when a browserWindow gets focused.
        [<Emit "$0.on('browser-window-focus',$1)">] abstract ``on_browser-window-focus``: listener: (Event -> BrowserWindow -> unit) -> App
        [<Emit "$0.once('browser-window-focus',$1)">] abstract ``once_browser-window-focus``: listener: (Event -> BrowserWindow -> unit) -> App
        [<Emit "$0.addListener('browser-window-focus',$1)">] abstract ``addListener_browser-window-focus``: listener: (Event -> BrowserWindow -> unit) -> App
        [<Emit "$0.removeListener('browser-window-focus',$1)">] abstract ``removeListener_browser-window-focus``: listener: (Event -> BrowserWindow -> unit) -> App
        /// Emitted when failed to verify the certificate for url, to trust the certificate
        /// you should prevent the default behavior with event.preventDefault() and call
        /// callback(true).
        [<Emit "$0.on('certificate-error',$1)">] abstract ``on_certificate-error``: listener: (Event -> WebContents -> string -> string -> Certificate -> (bool -> unit) -> unit) -> App
        [<Emit "$0.once('certificate-error',$1)">] abstract ``once_certificate-error``: listener: (Event -> WebContents -> string -> string -> Certificate -> (bool -> unit) -> unit) -> App
        [<Emit "$0.addListener('certificate-error',$1)">] abstract ``addListener_certificate-error``: listener: (Event -> WebContents -> string -> string -> Certificate -> (bool -> unit) -> unit) -> App
        [<Emit "$0.removeListener('certificate-error',$1)">] abstract ``removeListener_certificate-error``: listener: (Event -> WebContents -> string -> string -> Certificate -> (bool -> unit) -> unit) -> App
        /// Emitted during Handoff when an activity from a different device wants to be
        /// resumed. You should call event.preventDefault() if you want to handle this
        /// event. A user activity can be continued only in an app that has the same
        /// developer Team ID as the activity's source app and that supports the activity's
        /// type. Supported activity types are specified in the app's Info.plist under the
        /// NSUserActivityTypes key.
        [<Emit "$0.on('continue-activity',$1)">] abstract ``on_continue-activity``: listener: (Event -> string -> obj option -> unit) -> App
        [<Emit "$0.once('continue-activity',$1)">] abstract ``once_continue-activity``: listener: (Event -> string -> obj option -> unit) -> App
        [<Emit "$0.addListener('continue-activity',$1)">] abstract ``addListener_continue-activity``: listener: (Event -> string -> obj option -> unit) -> App
        [<Emit "$0.removeListener('continue-activity',$1)">] abstract ``removeListener_continue-activity``: listener: (Event -> string -> obj option -> unit) -> App
        /// Emitted during Handoff when an activity from a different device fails to be
        /// resumed.
        [<Emit "$0.on('continue-activity-error',$1)">] abstract ``on_continue-activity-error``: listener: (Event -> string -> string -> unit) -> App
        [<Emit "$0.once('continue-activity-error',$1)">] abstract ``once_continue-activity-error``: listener: (Event -> string -> string -> unit) -> App
        [<Emit "$0.addListener('continue-activity-error',$1)">] abstract ``addListener_continue-activity-error``: listener: (Event -> string -> string -> unit) -> App
        [<Emit "$0.removeListener('continue-activity-error',$1)">] abstract ``removeListener_continue-activity-error``: listener: (Event -> string -> string -> unit) -> App
        /// Emitted when the gpu process crashes or is killed.
        [<Emit "$0.on('gpu-process-crashed',$1)">] abstract ``on_gpu-process-crashed``: listener: (Event -> bool -> unit) -> App
        [<Emit "$0.once('gpu-process-crashed',$1)">] abstract ``once_gpu-process-crashed``: listener: (Event -> bool -> unit) -> App
        [<Emit "$0.addListener('gpu-process-crashed',$1)">] abstract ``addListener_gpu-process-crashed``: listener: (Event -> bool -> unit) -> App
        [<Emit "$0.removeListener('gpu-process-crashed',$1)">] abstract ``removeListener_gpu-process-crashed``: listener: (Event -> bool -> unit) -> App
        /// Emitted when webContents wants to do basic auth. The default behavior is to
        /// cancel all authentications, to override this you should prevent the default
        /// behavior with event.preventDefault() and call callback(username, password) with
        /// the credentials.
        [<Emit "$0.on('login',$1)">] abstract on_login: listener: (Event -> WebContents -> Request -> AuthInfo -> (string -> string -> unit) -> unit) -> App
        [<Emit "$0.once('login',$1)">] abstract once_login: listener: (Event -> WebContents -> Request -> AuthInfo -> (string -> string -> unit) -> unit) -> App
        [<Emit "$0.addListener('login',$1)">] abstract addListener_login: listener: (Event -> WebContents -> Request -> AuthInfo -> (string -> string -> unit) -> unit) -> App
        [<Emit "$0.removeListener('login',$1)">] abstract removeListener_login: listener: (Event -> WebContents -> Request -> AuthInfo -> (string -> string -> unit) -> unit) -> App
        /// Emitted when the user clicks the native macOS new tab button. The new tab button
        /// is only visible if the current BrowserWindow has a tabbingIdentifier
        [<Emit "$0.on('new-window-for-tab',$1)">] abstract ``on_new-window-for-tab``: listener: (Event -> unit) -> App
        [<Emit "$0.once('new-window-for-tab',$1)">] abstract ``once_new-window-for-tab``: listener: (Event -> unit) -> App
        [<Emit "$0.addListener('new-window-for-tab',$1)">] abstract ``addListener_new-window-for-tab``: listener: (Event -> unit) -> App
        [<Emit "$0.removeListener('new-window-for-tab',$1)">] abstract ``removeListener_new-window-for-tab``: listener: (Event -> unit) -> App
        /// Emitted when the user wants to open a file with the application. The open-file
        /// event is usually emitted when the application is already open and the OS wants
        /// to reuse the application to open the file. open-file is also emitted when a file
        /// is dropped onto the dock and the application is not yet running. Make sure to
        /// listen for the open-file event very early in your application startup to handle
        /// this case (even before the ready event is emitted). You should call
        /// event.preventDefault() if you want to handle this event. On Windows, you have to
        /// parse process.argv (in the main process) to get the filepath.
        [<Emit "$0.on('open-file',$1)">] abstract ``on_open-file``: listener: (Event -> string -> unit) -> App
        [<Emit "$0.once('open-file',$1)">] abstract ``once_open-file``: listener: (Event -> string -> unit) -> App
        [<Emit "$0.addListener('open-file',$1)">] abstract ``addListener_open-file``: listener: (Event -> string -> unit) -> App
        [<Emit "$0.removeListener('open-file',$1)">] abstract ``removeListener_open-file``: listener: (Event -> string -> unit) -> App
        /// Emitted when the user wants to open a URL with the application. Your
        /// application's Info.plist file must define the url scheme within the
        /// CFBundleURLTypes key, and set NSPrincipalClass to AtomApplication. You should
        /// call event.preventDefault() if you want to handle this event.
        [<Emit "$0.on('open-url',$1)">] abstract ``on_open-url``: listener: (Event -> string -> unit) -> App
        [<Emit "$0.once('open-url',$1)">] abstract ``once_open-url``: listener: (Event -> string -> unit) -> App
        [<Emit "$0.addListener('open-url',$1)">] abstract ``addListener_open-url``: listener: (Event -> string -> unit) -> App
        [<Emit "$0.removeListener('open-url',$1)">] abstract ``removeListener_open-url``: listener: (Event -> string -> unit) -> App
        /// Emitted when the application is quitting.
        [<Emit "$0.on('quit',$1)">] abstract on_quit: listener: (Event -> float -> unit) -> App
        [<Emit "$0.once('quit',$1)">] abstract once_quit: listener: (Event -> float -> unit) -> App
        [<Emit "$0.addListener('quit',$1)">] abstract addListener_quit: listener: (Event -> float -> unit) -> App
        [<Emit "$0.removeListener('quit',$1)">] abstract removeListener_quit: listener: (Event -> float -> unit) -> App
        /// Emitted when Electron has finished initializing. On macOS, launchInfo holds the
        /// userInfo of the NSUserNotification that was used to open the application, if it
        /// was launched from Notification Center. You can call app.isReady() to check if
        /// this event has already fired.
        [<Emit "$0.on('ready',$1)">] abstract on_ready: listener: (obj option -> unit) -> App
        [<Emit "$0.once('ready',$1)">] abstract once_ready: listener: (obj option -> unit) -> App
        [<Emit "$0.addListener('ready',$1)">] abstract addListener_ready: listener: (obj option -> unit) -> App
        [<Emit "$0.removeListener('ready',$1)">] abstract removeListener_ready: listener: (obj option -> unit) -> App
        /// Emitted when a client certificate is requested. The url corresponds to the
        /// navigation entry requesting the client certificate and callback can be called
        /// with an entry filtered from the list. Using event.preventDefault() prevents the
        /// application from using the first certificate from the store.
        [<Emit "$0.on('select-client-certificate',$1)">] abstract ``on_select-client-certificate``: listener: (Event -> WebContents -> string -> ResizeArray<Certificate> -> (Certificate -> unit) -> unit) -> App
        [<Emit "$0.once('select-client-certificate',$1)">] abstract ``once_select-client-certificate``: listener: (Event -> WebContents -> string -> ResizeArray<Certificate> -> (Certificate -> unit) -> unit) -> App
        [<Emit "$0.addListener('select-client-certificate',$1)">] abstract ``addListener_select-client-certificate``: listener: (Event -> WebContents -> string -> ResizeArray<Certificate> -> (Certificate -> unit) -> unit) -> App
        [<Emit "$0.removeListener('select-client-certificate',$1)">] abstract ``removeListener_select-client-certificate``: listener: (Event -> WebContents -> string -> ResizeArray<Certificate> -> (Certificate -> unit) -> unit) -> App
        /// Emitted when Handoff is about to be resumed on another device. If you need to
        /// update the state to be transferred, you should call event.preventDefault()
        /// immediatelly, construct a new userInfo dictionary and call
        /// app.updateCurrentActiviy() in a timely manner. Otherwise the operation will fail
        /// and continue-activity-error will be called.
        [<Emit "$0.on('update-activity-state',$1)">] abstract ``on_update-activity-state``: listener: (Event -> string -> obj option -> unit) -> App
        [<Emit "$0.once('update-activity-state',$1)">] abstract ``once_update-activity-state``: listener: (Event -> string -> obj option -> unit) -> App
        [<Emit "$0.addListener('update-activity-state',$1)">] abstract ``addListener_update-activity-state``: listener: (Event -> string -> obj option -> unit) -> App
        [<Emit "$0.removeListener('update-activity-state',$1)">] abstract ``removeListener_update-activity-state``: listener: (Event -> string -> obj option -> unit) -> App
        /// Emitted when a new webContents is created.
        [<Emit "$0.on('web-contents-created',$1)">] abstract ``on_web-contents-created``: listener: (Event -> WebContents -> unit) -> App
        [<Emit "$0.once('web-contents-created',$1)">] abstract ``once_web-contents-created``: listener: (Event -> WebContents -> unit) -> App
        [<Emit "$0.addListener('web-contents-created',$1)">] abstract ``addListener_web-contents-created``: listener: (Event -> WebContents -> unit) -> App
        [<Emit "$0.removeListener('web-contents-created',$1)">] abstract ``removeListener_web-contents-created``: listener: (Event -> WebContents -> unit) -> App
        /// Emitted during Handoff before an activity from a different device wants to be
        /// resumed. You should call event.preventDefault() if you want to handle this
        /// event.
        [<Emit "$0.on('will-continue-activity',$1)">] abstract ``on_will-continue-activity``: listener: (Event -> string -> unit) -> App
        [<Emit "$0.once('will-continue-activity',$1)">] abstract ``once_will-continue-activity``: listener: (Event -> string -> unit) -> App
        [<Emit "$0.addListener('will-continue-activity',$1)">] abstract ``addListener_will-continue-activity``: listener: (Event -> string -> unit) -> App
        [<Emit "$0.removeListener('will-continue-activity',$1)">] abstract ``removeListener_will-continue-activity``: listener: (Event -> string -> unit) -> App
        /// Emitted when the application has finished basic startup. On Windows and Linux,
        /// the will-finish-launching event is the same as the ready event; on macOS, this
        /// event represents the applicationWillFinishLaunching notification of
        /// NSApplication. You would usually set up listeners for the open-file and open-url
        /// events here, and start the crash reporter and auto updater. In most cases, you
        /// should just do everything in the ready event handler.
        [<Emit "$0.on('will-finish-launching',$1)">] abstract ``on_will-finish-launching``: listener: Function -> App
        [<Emit "$0.once('will-finish-launching',$1)">] abstract ``once_will-finish-launching``: listener: Function -> App
        [<Emit "$0.addListener('will-finish-launching',$1)">] abstract ``addListener_will-finish-launching``: listener: Function -> App
        [<Emit "$0.removeListener('will-finish-launching',$1)">] abstract ``removeListener_will-finish-launching``: listener: Function -> App
        /// Emitted when all windows have been closed and the application will quit. Calling
        /// event.preventDefault() will prevent the default behaviour, which is terminating
        /// the application. See the description of the window-all-closed event for the
        /// differences between the will-quit and window-all-closed events.
        [<Emit "$0.on('will-quit',$1)">] abstract ``on_will-quit``: listener: (Event -> unit) -> App
        [<Emit "$0.once('will-quit',$1)">] abstract ``once_will-quit``: listener: (Event -> unit) -> App
        [<Emit "$0.addListener('will-quit',$1)">] abstract ``addListener_will-quit``: listener: (Event -> unit) -> App
        [<Emit "$0.removeListener('will-quit',$1)">] abstract ``removeListener_will-quit``: listener: (Event -> unit) -> App
        /// Emitted when all windows have been closed. If you do not subscribe to this event
        /// and all windows are closed, the default behavior is to quit the app; however, if
        /// you subscribe, you control whether the app quits or not. If the user pressed Cmd
        /// + Q, or the developer called app.quit(), Electron will first try to close all
        /// the windows and then emit the will-quit event, and in this case the
        /// window-all-closed event would not be emitted.
        [<Emit "$0.on('window-all-closed',$1)">] abstract ``on_window-all-closed``: listener: Function -> App
        [<Emit "$0.once('window-all-closed',$1)">] abstract ``once_window-all-closed``: listener: Function -> App
        [<Emit "$0.addListener('window-all-closed',$1)">] abstract ``addListener_window-all-closed``: listener: Function -> App
        [<Emit "$0.removeListener('window-all-closed',$1)">] abstract ``removeListener_window-all-closed``: listener: Function -> App
        /// Adds path to the recent documents list. This list is managed by the OS. On
        /// Windows you can visit the list from the task bar, and on macOS you can visit it
        /// from dock menu.
        abstract addRecentDocument: path: string -> unit
        /// Clears the recent documents list.
        abstract clearRecentDocuments: unit -> unit
        /// By default, Chromium disables 3D APIs (e.g. WebGL) until restart on a per domain
        /// basis if the GPU processes crashes too frequently. This function disables that
        /// behaviour. This method can only be called before app is ready.
        abstract disableDomainBlockingFor3DAPIs: unit -> unit
        /// Disables hardware acceleration for current app. This method can only be called
        /// before app is ready.
        abstract disableHardwareAcceleration: unit -> unit
        /// Enables mixed sandbox mode on the app. This method can only be called before app
        /// is ready.
        abstract enableMixedSandbox: unit -> unit
        /// Exits immediately with exitCode.  exitCode defaults to 0. All windows will be
        /// closed immediately without asking user and the before-quit and will-quit events
        /// will not be emitted.
        abstract exit: ?exitCode: float -> unit
        /// On Linux, focuses on the first visible window. On macOS, makes the application
        /// the active app. On Windows, focuses on the application's first window.
        abstract focus: unit -> unit
        abstract getAppMemoryInfo: unit -> ResizeArray<ProcessMetric>
        abstract getAppMetrics: unit -> ResizeArray<ProcessMetric>
        abstract getAppPath: unit -> string
        abstract getBadgeCount: unit -> float
        abstract getCurrentActivityType: unit -> string
        /// Fetches a path's associated icon. On Windows, there a 2 kinds of icons: On Linux
        /// and macOS, icons depend on the application associated with file mime type.
        abstract getFileIcon: path: string * callback: (Error -> NativeImage -> unit) -> unit
        /// Fetches a path's associated icon. On Windows, there a 2 kinds of icons: On Linux
        /// and macOS, icons depend on the application associated with file mime type.
        abstract getFileIcon: path: string * options: FileIconOptions * callback: (Error -> NativeImage -> unit) -> unit
        abstract getGPUFeatureStatus: unit -> GPUFeatureStatus
        abstract getJumpListSettings: unit -> JumpListSettings
        /// Note: When distributing your packaged app, you have to also ship the locales
        /// folder. Note: On Windows you have to call it after the ready events gets
        /// emitted.
        abstract getLocale: unit -> string
        /// If you provided path and args options to app.setLoginItemSettings then you need
        /// to pass the same arguments here for openAtLogin to be set correctly. Note: This
        /// API has no effect on MAS builds.
        abstract getLoginItemSettings: ?options: LoginItemSettingsOptions -> LoginItemSettings
        /// Usually the name field of package.json is a short lowercased name, according to
        /// the npm modules spec. You should usually also specify a productName field, which
        /// is your application's full capitalized name, and which will be preferred over
        /// name by Electron.
        abstract getName: unit -> string
        /// You can request the following paths by the name:
        abstract getPath: name: string -> string
        abstract getVersion: unit -> string
        /// Hides all application windows without minimizing them.
        abstract hide: unit -> unit
        /// Imports the certificate in pkcs12 format into the platform certificate store.
        /// callback is called with the result of import operation, a value of 0 indicates
        /// success while any other value indicates failure according to chromium
        /// net_error_list.
        abstract importCertificate: options: ImportCertificateOptions * callback: (float -> unit) -> unit
        /// Invalidates the current Handoff user activity.
        abstract invalidateCurrentActivity: ``type``: string -> unit
        abstract isAccessibilitySupportEnabled: unit -> bool
        /// This method checks if the current executable is the default handler for a
        /// protocol (aka URI scheme). If so, it will return true. Otherwise, it will return
        /// false. Note: On macOS, you can use this method to check if the app has been
        /// registered as the default protocol handler for a protocol. You can also verify
        /// this by checking ~/Library/Preferences/com.apple.LaunchServices.plist on the
        /// macOS machine. Please refer to Apple's documentation for details. The API uses
        /// the Windows Registry and LSCopyDefaultHandlerForURLScheme internally.
        abstract isDefaultProtocolClient: protocol: string * ?path: string * ?args: ResizeArray<string> -> bool
        abstract isInApplicationsFolder: unit -> bool
        abstract isReady: unit -> bool
        abstract isUnityRunning: unit -> bool
        /// This method makes your application a Single Instance Application - instead of
        /// allowing multiple instances of your app to run, this will ensure that only a
        /// single instance of your app is running, and other instances signal this instance
        /// and exit. callback will be called by the first instance with callback(argv,
        /// workingDirectory) when a second instance has been executed. argv is an Array of
        /// the second instance's command line arguments, and workingDirectory is its
        /// current working directory. Usually applications respond to this by making their
        /// primary window focused and non-minimized. The callback is guaranteed to be
        /// executed after the ready event of app gets emitted. This method returns false if
        /// your process is the primary instance of the application and your app should
        /// continue loading. And returns true if your process has sent its parameters to
        /// another instance, and you should immediately quit. On macOS the system enforces
        /// single instance automatically when users try to open a second instance of your
        /// app in Finder, and the open-file and open-url events will be emitted for that.
        /// However when users start your app in command line the system's single instance
        /// mechanism will be bypassed and you have to use this method to ensure single
        /// instance. An example of activating the window of primary instance when a second
        /// instance starts:
        abstract makeSingleInstance: callback: (ResizeArray<string> -> string -> unit) -> bool
        /// No confirmation dialog will be presented by default, if you wish to allow the
        /// user to confirm the operation you may do so using the dialog API. NOTE: This
        /// method throws errors if anything other than the user causes the move to fail.
        /// For instance if the user cancels the authorization dialog this method returns
        /// false.  If we fail to perform the copy then this method will throw an error.
        /// The message in the error should be informative and tell you exactly what went
        /// wrong
        abstract moveToApplicationsFolder: unit -> bool
        /// Try to close all windows. The before-quit event will be emitted first. If all
        /// windows are successfully closed, the will-quit event will be emitted and by
        /// default the application will terminate. This method guarantees that all
        /// beforeunload and unload event handlers are correctly executed. It is possible
        /// that a window cancels the quitting by returning false in the beforeunload event
        /// handler.
        abstract quit: unit -> unit
        /// Relaunches the app when current instance exits. By default the new instance will
        /// use the same working directory and command line arguments with current instance.
        /// When args is specified, the args will be passed as command line arguments
        /// instead. When execPath is specified, the execPath will be executed for relaunch
        /// instead of current app. Note that this method does not quit the app when
        /// executed, you have to call app.quit or app.exit after calling app.relaunch to
        /// make the app restart. When app.relaunch is called for multiple times, multiple
        /// instances will be started after current instance exited. An example of
        /// restarting current instance immediately and adding a new command line argument
        /// to the new instance:
        abstract relaunch: ?options: RelaunchOptions -> unit
        /// Releases all locks that were created by makeSingleInstance. This will allow
        /// multiple instances of the application to once again run side by side.
        abstract releaseSingleInstance: unit -> unit
        /// This method checks if the current executable as the default handler for a
        /// protocol (aka URI scheme). If so, it will remove the app as the default handler.
        abstract removeAsDefaultProtocolClient: protocol: string * ?path: string * ?args: ResizeArray<string> -> bool
        /// Set the about panel options. This will override the values defined in the app's
        /// .plist file. See the Apple docs for more details.
        abstract setAboutPanelOptions: options: AboutPanelOptionsOptions -> unit
        /// Manually enables Chrome's accessibility support, allowing to expose
        /// accessibility switch to users in application settings.
        /// https://www.chromium.org/developers/design-documents/accessibility for more
        /// details. Disabled by default. Note: Rendering accessibility tree can
        /// significantly affect the performance of your app. It should not be enabled by
        /// default.
        abstract setAccessibilitySupportEnabled: enabled: bool -> unit
        /// Changes the Application User Model ID to id.
        abstract setAppUserModelId: id: string -> unit
        /// This method sets the current executable as the default handler for a protocol
        /// (aka URI scheme). It allows you to integrate your app deeper into the operating
        /// system. Once registered, all links with your-protocol:// will be opened with the
        /// current executable. The whole link, including protocol, will be passed to your
        /// application as a parameter. On Windows you can provide optional parameters path,
        /// the path to your executable, and args, an array of arguments to be passed to
        /// your executable when it launches. Note: On macOS, you can only register
        /// protocols that have been added to your app's info.plist, which can not be
        /// modified at runtime. You can however change the file with a simple text editor
        /// or script during build time. Please refer to Apple's documentation for details.
        /// The API uses the Windows Registry and LSSetDefaultHandlerForURLScheme
        /// internally.
        abstract setAsDefaultProtocolClient: protocol: string * ?path: string * ?args: ResizeArray<string> -> bool
        /// Sets the counter badge for current app. Setting the count to 0 will hide the
        /// badge. On macOS it shows on the dock icon. On Linux it only works for Unity
        /// launcher, Note: Unity launcher requires the existence of a .desktop file to
        /// work, for more information please read Desktop Environment Integration.
        abstract setBadgeCount: count: float -> bool
        /// Sets or removes a custom Jump List for the application, and returns one of the
        /// following strings: If categories is null the previously set custom Jump List (if
        /// any) will be replaced by the standard Jump List for the app (managed by
        /// Windows). Note: If a JumpListCategory object has neither the type nor the name
        /// property set then its type is assumed to be tasks. If the name property is set
        /// but the type property is omitted then the type is assumed to be custom. Note:
        /// Users can remove items from custom categories, and Windows will not allow a
        /// removed item to be added back into a custom category until after the next
        /// successful call to app.setJumpList(categories). Any attempt to re-add a removed
        /// item to a custom category earlier than that will result in the entire custom
        /// category being omitted from the Jump List. The list of removed items can be
        /// obtained using app.getJumpListSettings(). Here's a very simple example of
        /// creating a custom Jump List:
        abstract setJumpList: categories: ResizeArray<JumpListCategory> -> unit
        /// Set the app's login item settings. To work with Electron's autoUpdater on
        /// Windows, which uses Squirrel, you'll want to set the launch path to Update.exe,
        /// and pass arguments that specify your application name. For example: Note: This
        /// API has no effect on MAS builds.
        abstract setLoginItemSettings: settings: Settings -> unit
        /// Overrides the current application's name.
        abstract setName: name: string -> unit
        /// Overrides the path to a special directory or file associated with name. If the
        /// path specifies a directory that does not exist, the directory will be created by
        /// this method. On failure an Error is thrown. You can only override paths of a
        /// name defined in app.getPath. By default, web pages' cookies and caches will be
        /// stored under the userData directory. If you want to change this location, you
        /// have to override the userData path before the ready event of the app module is
        /// emitted.
        abstract setPath: name: string * path: string -> unit
        /// Creates an NSUserActivity and sets it as the current activity. The activity is
        /// eligible for Handoff to another device afterward.
        abstract setUserActivity: ``type``: string * userInfo: obj option * ?webpageURL: string -> unit
        /// Adds tasks to the Tasks category of the JumpList on Windows. tasks is an array
        /// of Task objects. Note: If you'd like to customize the Jump List even more use
        /// app.setJumpList(categories) instead.
        abstract setUserTasks: tasks: ResizeArray<Task> -> bool
        /// Shows application windows after they were hidden. Does not automatically focus
        /// them.
        abstract show: unit -> unit
        /// Updates the current activity if its type matches type, merging the entries from
        /// userInfo into its current userInfo dictionary.
        abstract updateCurrentActivity: ``type``: string * userInfo: obj option -> unit
        abstract commandLine: CommandLine with get, set
        abstract dock: Dock with get, set

    type [<AllowNullLiteral>] AutoUpdater =
        inherit EventEmitter
        /// Emitted when checking if an update has started.
        [<Emit "$0.on('checking-for-update',$1)">] abstract ``on_checking-for-update``: listener: Function -> AutoUpdater
        [<Emit "$0.once('checking-for-update',$1)">] abstract ``once_checking-for-update``: listener: Function -> AutoUpdater
        [<Emit "$0.addListener('checking-for-update',$1)">] abstract ``addListener_checking-for-update``: listener: Function -> AutoUpdater
        [<Emit "$0.removeListener('checking-for-update',$1)">] abstract ``removeListener_checking-for-update``: listener: Function -> AutoUpdater
        /// Emitted when there is an error while updating.
        [<Emit "$0.on('error',$1)">] abstract on_error: listener: (Error -> unit) -> AutoUpdater
        [<Emit "$0.once('error',$1)">] abstract once_error: listener: (Error -> unit) -> AutoUpdater
        [<Emit "$0.addListener('error',$1)">] abstract addListener_error: listener: (Error -> unit) -> AutoUpdater
        [<Emit "$0.removeListener('error',$1)">] abstract removeListener_error: listener: (Error -> unit) -> AutoUpdater
        /// Emitted when there is an available update. The update is downloaded
        /// automatically.
        [<Emit "$0.on('update-available',$1)">] abstract ``on_update-available``: listener: Function -> AutoUpdater
        [<Emit "$0.once('update-available',$1)">] abstract ``once_update-available``: listener: Function -> AutoUpdater
        [<Emit "$0.addListener('update-available',$1)">] abstract ``addListener_update-available``: listener: Function -> AutoUpdater
        [<Emit "$0.removeListener('update-available',$1)">] abstract ``removeListener_update-available``: listener: Function -> AutoUpdater
        /// Emitted when an update has been downloaded. On Windows only releaseName is
        /// available.
        [<Emit "$0.on('update-downloaded',$1)">] abstract ``on_update-downloaded``: listener: (Event -> string -> string -> DateTime -> string -> unit) -> AutoUpdater
        [<Emit "$0.once('update-downloaded',$1)">] abstract ``once_update-downloaded``: listener: (Event -> string -> string -> DateTime -> string -> unit) -> AutoUpdater
        [<Emit "$0.addListener('update-downloaded',$1)">] abstract ``addListener_update-downloaded``: listener: (Event -> string -> string -> DateTime -> string -> unit) -> AutoUpdater
        [<Emit "$0.removeListener('update-downloaded',$1)">] abstract ``removeListener_update-downloaded``: listener: (Event -> string -> string -> DateTime -> string -> unit) -> AutoUpdater
        /// Emitted when there is no available update.
        [<Emit "$0.on('update-not-available',$1)">] abstract ``on_update-not-available``: listener: Function -> AutoUpdater
        [<Emit "$0.once('update-not-available',$1)">] abstract ``once_update-not-available``: listener: Function -> AutoUpdater
        [<Emit "$0.addListener('update-not-available',$1)">] abstract ``addListener_update-not-available``: listener: Function -> AutoUpdater
        [<Emit "$0.removeListener('update-not-available',$1)">] abstract ``removeListener_update-not-available``: listener: Function -> AutoUpdater
        /// Asks the server whether there is an update. You must call setFeedURL before
        /// using this API.
        abstract checkForUpdates: unit -> unit
        abstract getFeedURL: unit -> string
        /// Restarts the app and installs the update after it has been downloaded. It should
        /// only be called after update-downloaded has been emitted. Note:
        /// autoUpdater.quitAndInstall() will close all application windows first and only
        /// emit before-quit event on app after that. This is different from the normal quit
        /// event sequence.
        abstract quitAndInstall: unit -> unit
        /// Sets the url and initialize the auto updater.
        abstract setFeedURL: url: string * ?requestHeaders: obj option -> unit

    type [<AllowNullLiteral>] BluetoothDevice =
        abstract deviceId: string with get, set
        abstract deviceName: string with get, set

    type [<AllowNullLiteral>] BrowserView =
        inherit EventEmitter
        /// Force closing the view, the unload and beforeunload events won't be emitted for
        /// the web page. After you're done with a view, call this function in order to free
        /// memory and other resources as soon as possible.
        abstract destroy: unit -> unit
        abstract isDestroyed: unit -> bool
        abstract setAutoResize: options: AutoResizeOptions -> unit
        abstract setBackgroundColor: color: string -> unit
        /// Resizes and moves the view to the supplied bounds relative to the window.
        abstract setBounds: bounds: Rectangle -> unit
        abstract id: float with get, set
        abstract webContents: WebContents with get, set

    type [<AllowNullLiteral>] BrowserViewStatic =
        [<Emit "new $0($1...)">] abstract Create: ?options: BrowserViewConstructorOptions -> BrowserView
        abstract fromId: id: float -> BrowserView
        abstract fromWebContents: webContents: WebContents -> BrowserView option
        abstract getAllViews: unit -> ResizeArray<BrowserView>

    type [<AllowNullLiteral>] BrowserWindow =
        inherit EventEmitter
        /// Emitted when an App Command is invoked. These are typically related to keyboard
        /// media keys or browser commands, as well as the "Back" button built into some
        /// mice on Windows. Commands are lowercased, underscores are replaced with hyphens,
        /// and the APPCOMMAND_ prefix is stripped off. e.g. APPCOMMAND_BROWSER_BACKWARD is
        /// emitted as browser-backward.
        [<Emit "$0.on('app-command',$1)">] abstract ``on_app-command``: listener: (Event -> string -> unit) -> BrowserWindow
        [<Emit "$0.once('app-command',$1)">] abstract ``once_app-command``: listener: (Event -> string -> unit) -> BrowserWindow
        [<Emit "$0.addListener('app-command',$1)">] abstract ``addListener_app-command``: listener: (Event -> string -> unit) -> BrowserWindow
        [<Emit "$0.removeListener('app-command',$1)">] abstract ``removeListener_app-command``: listener: (Event -> string -> unit) -> BrowserWindow
        /// Emitted when the window loses focus.
        [<Emit "$0.on('blur',$1)">] abstract on_blur: listener: Function -> BrowserWindow
        [<Emit "$0.once('blur',$1)">] abstract once_blur: listener: Function -> BrowserWindow
        [<Emit "$0.addListener('blur',$1)">] abstract addListener_blur: listener: Function -> BrowserWindow
        [<Emit "$0.removeListener('blur',$1)">] abstract removeListener_blur: listener: Function -> BrowserWindow
        /// Emitted when the window is going to be closed. It's emitted before the
        /// beforeunload and unload event of the DOM. Calling event.preventDefault() will
        /// cancel the close. Usually you would want to use the beforeunload handler to
        /// decide whether the window should be closed, which will also be called when the
        /// window is reloaded. In Electron, returning any value other than undefined would
        /// cancel the close. For example: Note: There is a subtle difference between the
        /// behaviors of window.onbeforeunload = handler and
        /// window.addEventListener('beforeunload', handler). It is recommended to always
        /// set the event.returnValue explicitly, instead of just returning a value, as the
        /// former works more consistently within Electron.
        [<Emit "$0.on('close',$1)">] abstract on_close: listener: (Event -> unit) -> BrowserWindow
        [<Emit "$0.once('close',$1)">] abstract once_close: listener: (Event -> unit) -> BrowserWindow
        [<Emit "$0.addListener('close',$1)">] abstract addListener_close: listener: (Event -> unit) -> BrowserWindow
        [<Emit "$0.removeListener('close',$1)">] abstract removeListener_close: listener: (Event -> unit) -> BrowserWindow
        /// Emitted when the window is closed. After you have received this event you should
        /// remove the reference to the window and avoid using it any more.
        [<Emit "$0.on('closed',$1)">] abstract on_closed: listener: Function -> BrowserWindow
        [<Emit "$0.once('closed',$1)">] abstract once_closed: listener: Function -> BrowserWindow
        [<Emit "$0.addListener('closed',$1)">] abstract addListener_closed: listener: Function -> BrowserWindow
        [<Emit "$0.removeListener('closed',$1)">] abstract removeListener_closed: listener: Function -> BrowserWindow
        /// Emitted when the window enters a full-screen state.
        [<Emit "$0.on('enter-full-screen',$1)">] abstract ``on_enter-full-screen``: listener: Function -> BrowserWindow
        [<Emit "$0.once('enter-full-screen',$1)">] abstract ``once_enter-full-screen``: listener: Function -> BrowserWindow
        [<Emit "$0.addListener('enter-full-screen',$1)">] abstract ``addListener_enter-full-screen``: listener: Function -> BrowserWindow
        [<Emit "$0.removeListener('enter-full-screen',$1)">] abstract ``removeListener_enter-full-screen``: listener: Function -> BrowserWindow
        /// Emitted when the window enters a full-screen state triggered by HTML API.
        [<Emit "$0.on('enter-html-full-screen',$1)">] abstract ``on_enter-html-full-screen``: listener: Function -> BrowserWindow
        [<Emit "$0.once('enter-html-full-screen',$1)">] abstract ``once_enter-html-full-screen``: listener: Function -> BrowserWindow
        [<Emit "$0.addListener('enter-html-full-screen',$1)">] abstract ``addListener_enter-html-full-screen``: listener: Function -> BrowserWindow
        [<Emit "$0.removeListener('enter-html-full-screen',$1)">] abstract ``removeListener_enter-html-full-screen``: listener: Function -> BrowserWindow
        /// Emitted when the window gains focus.
        [<Emit "$0.on('focus',$1)">] abstract on_focus: listener: Function -> BrowserWindow
        [<Emit "$0.once('focus',$1)">] abstract once_focus: listener: Function -> BrowserWindow
        [<Emit "$0.addListener('focus',$1)">] abstract addListener_focus: listener: Function -> BrowserWindow
        [<Emit "$0.removeListener('focus',$1)">] abstract removeListener_focus: listener: Function -> BrowserWindow
        /// Emitted when the window is hidden.
        [<Emit "$0.on('hide',$1)">] abstract on_hide: listener: Function -> BrowserWindow
        [<Emit "$0.once('hide',$1)">] abstract once_hide: listener: Function -> BrowserWindow
        [<Emit "$0.addListener('hide',$1)">] abstract addListener_hide: listener: Function -> BrowserWindow
        [<Emit "$0.removeListener('hide',$1)">] abstract removeListener_hide: listener: Function -> BrowserWindow
        /// Emitted when the window leaves a full-screen state.
        [<Emit "$0.on('leave-full-screen',$1)">] abstract ``on_leave-full-screen``: listener: Function -> BrowserWindow
        [<Emit "$0.once('leave-full-screen',$1)">] abstract ``once_leave-full-screen``: listener: Function -> BrowserWindow
        [<Emit "$0.addListener('leave-full-screen',$1)">] abstract ``addListener_leave-full-screen``: listener: Function -> BrowserWindow
        [<Emit "$0.removeListener('leave-full-screen',$1)">] abstract ``removeListener_leave-full-screen``: listener: Function -> BrowserWindow
        /// Emitted when the window leaves a full-screen state triggered by HTML API.
        [<Emit "$0.on('leave-html-full-screen',$1)">] abstract ``on_leave-html-full-screen``: listener: Function -> BrowserWindow
        [<Emit "$0.once('leave-html-full-screen',$1)">] abstract ``once_leave-html-full-screen``: listener: Function -> BrowserWindow
        [<Emit "$0.addListener('leave-html-full-screen',$1)">] abstract ``addListener_leave-html-full-screen``: listener: Function -> BrowserWindow
        [<Emit "$0.removeListener('leave-html-full-screen',$1)">] abstract ``removeListener_leave-html-full-screen``: listener: Function -> BrowserWindow
        /// Emitted when window is maximized.
        [<Emit "$0.on('maximize',$1)">] abstract on_maximize: listener: Function -> BrowserWindow
        [<Emit "$0.once('maximize',$1)">] abstract once_maximize: listener: Function -> BrowserWindow
        [<Emit "$0.addListener('maximize',$1)">] abstract addListener_maximize: listener: Function -> BrowserWindow
        [<Emit "$0.removeListener('maximize',$1)">] abstract removeListener_maximize: listener: Function -> BrowserWindow
        /// Emitted when the window is minimized.
        [<Emit "$0.on('minimize',$1)">] abstract on_minimize: listener: Function -> BrowserWindow
        [<Emit "$0.once('minimize',$1)">] abstract once_minimize: listener: Function -> BrowserWindow
        [<Emit "$0.addListener('minimize',$1)">] abstract addListener_minimize: listener: Function -> BrowserWindow
        [<Emit "$0.removeListener('minimize',$1)">] abstract removeListener_minimize: listener: Function -> BrowserWindow
        /// Emitted when the window is being moved to a new position. Note: On macOS this
        /// event is just an alias of moved.
        [<Emit "$0.on('move',$1)">] abstract on_move: listener: Function -> BrowserWindow
        [<Emit "$0.once('move',$1)">] abstract once_move: listener: Function -> BrowserWindow
        [<Emit "$0.addListener('move',$1)">] abstract addListener_move: listener: Function -> BrowserWindow
        [<Emit "$0.removeListener('move',$1)">] abstract removeListener_move: listener: Function -> BrowserWindow
        /// Emitted once when the window is moved to a new position.
        [<Emit "$0.on('moved',$1)">] abstract on_moved: listener: Function -> BrowserWindow
        [<Emit "$0.once('moved',$1)">] abstract once_moved: listener: Function -> BrowserWindow
        [<Emit "$0.addListener('moved',$1)">] abstract addListener_moved: listener: Function -> BrowserWindow
        [<Emit "$0.removeListener('moved',$1)">] abstract removeListener_moved: listener: Function -> BrowserWindow
        /// Emitted when the native new tab button is clicked.
        [<Emit "$0.on('new-window-for-tab',$1)">] abstract ``on_new-window-for-tab``: listener: Function -> BrowserWindow
        [<Emit "$0.once('new-window-for-tab',$1)">] abstract ``once_new-window-for-tab``: listener: Function -> BrowserWindow
        [<Emit "$0.addListener('new-window-for-tab',$1)">] abstract ``addListener_new-window-for-tab``: listener: Function -> BrowserWindow
        [<Emit "$0.removeListener('new-window-for-tab',$1)">] abstract ``removeListener_new-window-for-tab``: listener: Function -> BrowserWindow
        /// Emitted when the document changed its title, calling event.preventDefault() will
        /// prevent the native window's title from changing.
        [<Emit "$0.on('page-title-updated',$1)">] abstract ``on_page-title-updated``: listener: (Event -> string -> unit) -> BrowserWindow
        [<Emit "$0.once('page-title-updated',$1)">] abstract ``once_page-title-updated``: listener: (Event -> string -> unit) -> BrowserWindow
        [<Emit "$0.addListener('page-title-updated',$1)">] abstract ``addListener_page-title-updated``: listener: (Event -> string -> unit) -> BrowserWindow
        [<Emit "$0.removeListener('page-title-updated',$1)">] abstract ``removeListener_page-title-updated``: listener: (Event -> string -> unit) -> BrowserWindow
        /// Emitted when the web page has been rendered (while not being shown) and window
        /// can be displayed without a visual flash.
        [<Emit "$0.on('ready-to-show',$1)">] abstract ``on_ready-to-show``: listener: Function -> BrowserWindow
        [<Emit "$0.once('ready-to-show',$1)">] abstract ``once_ready-to-show``: listener: Function -> BrowserWindow
        [<Emit "$0.addListener('ready-to-show',$1)">] abstract ``addListener_ready-to-show``: listener: Function -> BrowserWindow
        [<Emit "$0.removeListener('ready-to-show',$1)">] abstract ``removeListener_ready-to-show``: listener: Function -> BrowserWindow
        /// Emitted when the window is being resized.
        [<Emit "$0.on('resize',$1)">] abstract on_resize: listener: Function -> BrowserWindow
        [<Emit "$0.once('resize',$1)">] abstract once_resize: listener: Function -> BrowserWindow
        [<Emit "$0.addListener('resize',$1)">] abstract addListener_resize: listener: Function -> BrowserWindow
        [<Emit "$0.removeListener('resize',$1)">] abstract removeListener_resize: listener: Function -> BrowserWindow
        /// Emitted when the unresponsive web page becomes responsive again.
        [<Emit "$0.on('responsive',$1)">] abstract on_responsive: listener: Function -> BrowserWindow
        [<Emit "$0.once('responsive',$1)">] abstract once_responsive: listener: Function -> BrowserWindow
        [<Emit "$0.addListener('responsive',$1)">] abstract addListener_responsive: listener: Function -> BrowserWindow
        [<Emit "$0.removeListener('responsive',$1)">] abstract removeListener_responsive: listener: Function -> BrowserWindow
        /// Emitted when the window is restored from a minimized state.
        [<Emit "$0.on('restore',$1)">] abstract on_restore: listener: Function -> BrowserWindow
        [<Emit "$0.once('restore',$1)">] abstract once_restore: listener: Function -> BrowserWindow
        [<Emit "$0.addListener('restore',$1)">] abstract addListener_restore: listener: Function -> BrowserWindow
        [<Emit "$0.removeListener('restore',$1)">] abstract removeListener_restore: listener: Function -> BrowserWindow
        /// Emitted when scroll wheel event phase has begun.
        [<Emit "$0.on('scroll-touch-begin',$1)">] abstract ``on_scroll-touch-begin``: listener: Function -> BrowserWindow
        [<Emit "$0.once('scroll-touch-begin',$1)">] abstract ``once_scroll-touch-begin``: listener: Function -> BrowserWindow
        [<Emit "$0.addListener('scroll-touch-begin',$1)">] abstract ``addListener_scroll-touch-begin``: listener: Function -> BrowserWindow
        [<Emit "$0.removeListener('scroll-touch-begin',$1)">] abstract ``removeListener_scroll-touch-begin``: listener: Function -> BrowserWindow
        /// Emitted when scroll wheel event phase filed upon reaching the edge of element.
        [<Emit "$0.on('scroll-touch-edge',$1)">] abstract ``on_scroll-touch-edge``: listener: Function -> BrowserWindow
        [<Emit "$0.once('scroll-touch-edge',$1)">] abstract ``once_scroll-touch-edge``: listener: Function -> BrowserWindow
        [<Emit "$0.addListener('scroll-touch-edge',$1)">] abstract ``addListener_scroll-touch-edge``: listener: Function -> BrowserWindow
        [<Emit "$0.removeListener('scroll-touch-edge',$1)">] abstract ``removeListener_scroll-touch-edge``: listener: Function -> BrowserWindow
        /// Emitted when scroll wheel event phase has ended.
        [<Emit "$0.on('scroll-touch-end',$1)">] abstract ``on_scroll-touch-end``: listener: Function -> BrowserWindow
        [<Emit "$0.once('scroll-touch-end',$1)">] abstract ``once_scroll-touch-end``: listener: Function -> BrowserWindow
        [<Emit "$0.addListener('scroll-touch-end',$1)">] abstract ``addListener_scroll-touch-end``: listener: Function -> BrowserWindow
        [<Emit "$0.removeListener('scroll-touch-end',$1)">] abstract ``removeListener_scroll-touch-end``: listener: Function -> BrowserWindow
        /// Emitted when window session is going to end due to force shutdown or machine
        /// restart or session log off.
        [<Emit "$0.on('session-end',$1)">] abstract ``on_session-end``: listener: Function -> BrowserWindow
        [<Emit "$0.once('session-end',$1)">] abstract ``once_session-end``: listener: Function -> BrowserWindow
        [<Emit "$0.addListener('session-end',$1)">] abstract ``addListener_session-end``: listener: Function -> BrowserWindow
        [<Emit "$0.removeListener('session-end',$1)">] abstract ``removeListener_session-end``: listener: Function -> BrowserWindow
        /// Emitted when the window opens a sheet.
        [<Emit "$0.on('sheet-begin',$1)">] abstract ``on_sheet-begin``: listener: Function -> BrowserWindow
        [<Emit "$0.once('sheet-begin',$1)">] abstract ``once_sheet-begin``: listener: Function -> BrowserWindow
        [<Emit "$0.addListener('sheet-begin',$1)">] abstract ``addListener_sheet-begin``: listener: Function -> BrowserWindow
        [<Emit "$0.removeListener('sheet-begin',$1)">] abstract ``removeListener_sheet-begin``: listener: Function -> BrowserWindow
        /// Emitted when the window has closed a sheet.
        [<Emit "$0.on('sheet-end',$1)">] abstract ``on_sheet-end``: listener: Function -> BrowserWindow
        [<Emit "$0.once('sheet-end',$1)">] abstract ``once_sheet-end``: listener: Function -> BrowserWindow
        [<Emit "$0.addListener('sheet-end',$1)">] abstract ``addListener_sheet-end``: listener: Function -> BrowserWindow
        [<Emit "$0.removeListener('sheet-end',$1)">] abstract ``removeListener_sheet-end``: listener: Function -> BrowserWindow
        /// Emitted when the window is shown.
        [<Emit "$0.on('show',$1)">] abstract on_show: listener: Function -> BrowserWindow
        [<Emit "$0.once('show',$1)">] abstract once_show: listener: Function -> BrowserWindow
        [<Emit "$0.addListener('show',$1)">] abstract addListener_show: listener: Function -> BrowserWindow
        [<Emit "$0.removeListener('show',$1)">] abstract removeListener_show: listener: Function -> BrowserWindow
        /// Emitted on 3-finger swipe. Possible directions are up, right, down, left.
        [<Emit "$0.on('swipe',$1)">] abstract on_swipe: listener: (Event -> string -> unit) -> BrowserWindow
        [<Emit "$0.once('swipe',$1)">] abstract once_swipe: listener: (Event -> string -> unit) -> BrowserWindow
        [<Emit "$0.addListener('swipe',$1)">] abstract addListener_swipe: listener: (Event -> string -> unit) -> BrowserWindow
        [<Emit "$0.removeListener('swipe',$1)">] abstract removeListener_swipe: listener: (Event -> string -> unit) -> BrowserWindow
        /// Emitted when the window exits from a maximized state.
        [<Emit "$0.on('unmaximize',$1)">] abstract on_unmaximize: listener: Function -> BrowserWindow
        [<Emit "$0.once('unmaximize',$1)">] abstract once_unmaximize: listener: Function -> BrowserWindow
        [<Emit "$0.addListener('unmaximize',$1)">] abstract addListener_unmaximize: listener: Function -> BrowserWindow
        [<Emit "$0.removeListener('unmaximize',$1)">] abstract removeListener_unmaximize: listener: Function -> BrowserWindow
        /// Emitted when the web page becomes unresponsive.
        [<Emit "$0.on('unresponsive',$1)">] abstract on_unresponsive: listener: Function -> BrowserWindow
        [<Emit "$0.once('unresponsive',$1)">] abstract once_unresponsive: listener: Function -> BrowserWindow
        [<Emit "$0.addListener('unresponsive',$1)">] abstract addListener_unresponsive: listener: Function -> BrowserWindow
        [<Emit "$0.removeListener('unresponsive',$1)">] abstract removeListener_unresponsive: listener: Function -> BrowserWindow
        /// Adds a window as a tab on this window, after the tab for the window instance.
        abstract addTabbedWindow: browserWindow: BrowserWindow -> unit
        /// Removes focus from the window.
        abstract blur: unit -> unit
        abstract blurWebView: unit -> unit
        /// Same as webContents.capturePage([rect, ]callback).
        abstract capturePage: callback: (NativeImage -> unit) -> unit
        /// Same as webContents.capturePage([rect, ]callback).
        abstract capturePage: rect: Rectangle * callback: (NativeImage -> unit) -> unit
        /// Moves window to the center of the screen.
        abstract center: unit -> unit
        /// Try to close the window. This has the same effect as a user manually clicking
        /// the close button of the window. The web page may cancel the close though. See
        /// the close event.
        abstract close: unit -> unit
        /// Closes the currently open Quick Look panel.
        abstract closeFilePreview: unit -> unit
        /// Force closing the window, the unload and beforeunload event won't be emitted for
        /// the web page, and close event will also not be emitted for this window, but it
        /// guarantees the closed event will be emitted.
        abstract destroy: unit -> unit
        /// Starts or stops flashing the window to attract user's attention.
        abstract flashFrame: flag: bool -> unit
        /// Focuses on the window.
        abstract focus: unit -> unit
        abstract focusOnWebView: unit -> unit
        abstract getBounds: unit -> Rectangle
        /// Note: The BrowserView API is currently experimental and may change or be removed
        /// in future Electron releases.
        abstract getBrowserView: unit -> BrowserView option
        abstract getChildWindows: unit -> ResizeArray<BrowserWindow>
        abstract getContentBounds: unit -> Rectangle
        abstract getContentSize: unit -> ResizeArray<float>
        abstract getMaximumSize: unit -> ResizeArray<float>
        abstract getMinimumSize: unit -> ResizeArray<float>
        /// The native type of the handle is HWND on Windows, NSView* on macOS, and Window
        /// (unsigned long) on Linux.
        abstract getNativeWindowHandle: unit -> Buffer
        abstract getOpacity: unit -> float
        abstract getParentWindow: unit -> BrowserWindow
        abstract getPosition: unit -> ResizeArray<float>
        abstract getRepresentedFilename: unit -> string
        abstract getSize: unit -> ResizeArray<float>
        /// Note: The title of web page can be different from the title of the native
        /// window.
        abstract getTitle: unit -> string
        /// On Windows and Linux always returns true.
        abstract hasShadow: unit -> bool
        /// Hides the window.
        abstract hide: unit -> unit
        /// Hooks a windows message. The callback is called when the message is received in
        /// the WndProc.
        abstract hookWindowMessage: message: float * callback: Function -> unit
        abstract isAlwaysOnTop: unit -> bool
        /// On Linux always returns true.
        abstract isClosable: unit -> bool
        abstract isDestroyed: unit -> bool
        abstract isDocumentEdited: unit -> bool
        abstract isFocused: unit -> bool
        abstract isFullScreen: unit -> bool
        abstract isFullScreenable: unit -> bool
        abstract isKiosk: unit -> bool
        /// On Linux always returns true.
        abstract isMaximizable: unit -> bool
        abstract isMaximized: unit -> bool
        abstract isMenuBarAutoHide: unit -> bool
        abstract isMenuBarVisible: unit -> bool
        /// On Linux always returns true.
        abstract isMinimizable: unit -> bool
        abstract isMinimized: unit -> bool
        abstract isModal: unit -> bool
        /// On Linux always returns true.
        abstract isMovable: unit -> bool
        abstract isResizable: unit -> bool
        abstract isSimpleFullScreen: unit -> bool
        abstract isVisible: unit -> bool
        /// Note: This API always returns false on Windows.
        abstract isVisibleOnAllWorkspaces: unit -> bool
        abstract isWindowMessageHooked: message: float -> bool
        /// Same as webContents.loadURL(url[, options]). The url can be a remote address
        /// (e.g. http://) or a path to a local HTML file using the file:// protocol. To
        /// ensure that file URLs are properly formatted, it is recommended to use Node's
        /// url.format method: You can load a URL using a POST request with URL-encoded data
        /// by doing the following:
        abstract loadURL: url: string * ?options: LoadURLOptions -> unit
        /// Maximizes the window. This will also show (but not focus) the window if it isn't
        /// being displayed already.
        abstract maximize: unit -> unit
        /// Merges all windows into one window with multiple tabs when native tabs are
        /// enabled and there is more than one open window.
        abstract mergeAllWindows: unit -> unit
        /// Minimizes the window. On some platforms the minimized window will be shown in
        /// the Dock.
        abstract minimize: unit -> unit
        /// Moves the current tab into a new window if native tabs are enabled and there is
        /// more than one tab in the current window.
        abstract moveTabToNewWindow: unit -> unit
        /// Uses Quick Look to preview a file at a given path.
        abstract previewFile: path: string * ?displayName: string -> unit
        /// Same as webContents.reload.
        abstract reload: unit -> unit
        /// Restores the window from minimized state to its previous state.
        abstract restore: unit -> unit
        /// Selects the next tab when native tabs are enabled and there are other tabs in
        /// the window.
        abstract selectNextTab: unit -> unit
        /// Selects the previous tab when native tabs are enabled and there are other tabs
        /// in the window.
        abstract selectPreviousTab: unit -> unit
        /// Sets whether the window should show always on top of other windows. After
        /// setting this, the window is still a normal window, not a toolbox window which
        /// can not be focused on.
        abstract setAlwaysOnTop: flag: bool * ?level: U8<string, string, string, string, string, string, string, string> * ?relativeLevel: float -> unit
        /// Sets the properties for the window's taskbar button. Note: relaunchCommand and
        /// relaunchDisplayName must always be set together. If one of those properties is
        /// not set, then neither will be used.
        abstract setAppDetails: options: AppDetailsOptions -> unit
        /// This will make a window maintain an aspect ratio. The extra size allows a
        /// developer to have space, specified in pixels, not included within the aspect
        /// ratio calculations. This API already takes into account the difference between a
        /// window's size and its content size. Consider a normal window with an HD video
        /// player and associated controls. Perhaps there are 15 pixels of controls on the
        /// left edge, 25 pixels of controls on the right edge and 50 pixels of controls
        /// below the player. In order to maintain a 16:9 aspect ratio (standard aspect
        /// ratio for HD @1920x1080) within the player itself we would call this function
        /// with arguments of 16/9 and [ 40, 50 ]. The second argument doesn't care where
        /// the extra width and height are within the content view--only that they exist.
        /// Just sum any extra width and height areas you have within the overall content
        /// view.
        abstract setAspectRatio: aspectRatio: float * extraSize: Size -> unit
        /// Controls whether to hide cursor when typing.
        abstract setAutoHideCursor: autoHide: bool -> unit
        /// Sets whether the window menu bar should hide itself automatically. Once set the
        /// menu bar will only show when users press the single Alt key. If the menu bar is
        /// already visible, calling setAutoHideMenuBar(true) won't hide it immediately.
        abstract setAutoHideMenuBar: hide: bool -> unit
        /// Resizes and moves the window to the supplied bounds
        abstract setBounds: bounds: Rectangle * ?animate: bool -> unit
        abstract setBrowserView: browserView: BrowserView -> unit
        /// Sets whether the window can be manually closed by user. On Linux does nothing.
        abstract setClosable: closable: bool -> unit
        /// Resizes and moves the window's client area (e.g. the web page) to the supplied
        /// bounds.
        abstract setContentBounds: bounds: Rectangle * ?animate: bool -> unit
        /// Prevents the window contents from being captured by other apps. On macOS it sets
        /// the NSWindow's sharingType to NSWindowSharingNone. On Windows it calls
        /// SetWindowDisplayAffinity with WDA_MONITOR.
        abstract setContentProtection: enable: bool -> unit
        /// Resizes the window's client area (e.g. the web page) to width and height.
        abstract setContentSize: width: float * height: float * ?animate: bool -> unit
        /// Specifies whether the window’s document has been edited, and the icon in title
        /// bar will become gray when set to true.
        abstract setDocumentEdited: edited: bool -> unit
        /// Changes whether the window can be focused.
        abstract setFocusable: focusable: bool -> unit
        /// Sets whether the window should be in fullscreen mode.
        abstract setFullScreen: flag: bool -> unit
        /// Sets whether the maximize/zoom window button toggles fullscreen mode or
        /// maximizes the window.
        abstract setFullScreenable: fullscreenable: bool -> unit
        /// Sets whether the window should have a shadow. On Windows and Linux does nothing.
        abstract setHasShadow: hasShadow: bool -> unit
        /// Changes window icon.
        abstract setIcon: icon: NativeImage -> unit
        /// Makes the window ignore all mouse events. All mouse events happened in this
        /// window will be passed to the window below this window, but if this window has
        /// focus, it will still receive keyboard events.
        abstract setIgnoreMouseEvents: ignore: bool * ?options: IgnoreMouseEventsOptions -> unit
        /// Enters or leaves the kiosk mode.
        abstract setKiosk: flag: bool -> unit
        /// Sets whether the window can be manually maximized by user. On Linux does
        /// nothing.
        abstract setMaximizable: maximizable: bool -> unit
        /// Sets the maximum size of window to width and height.
        abstract setMaximumSize: width: float * height: float -> unit
        /// Sets the menu as the window's menu bar, setting it to null will remove the menu
        /// bar.
        abstract setMenu: menu: Menu option -> unit
        /// Sets whether the menu bar should be visible. If the menu bar is auto-hide, users
        /// can still bring up the menu bar by pressing the single Alt key.
        abstract setMenuBarVisibility: visible: bool -> unit
        /// Sets whether the window can be manually minimized by user. On Linux does
        /// nothing.
        abstract setMinimizable: minimizable: bool -> unit
        /// Sets the minimum size of window to width and height.
        abstract setMinimumSize: width: float * height: float -> unit
        /// Sets whether the window can be moved by user. On Linux does nothing.
        abstract setMovable: movable: bool -> unit
        /// Sets the opacity of the window. On Linux does nothing.
        abstract setOpacity: opacity: float -> unit
        /// Sets a 16 x 16 pixel overlay onto the current taskbar icon, usually used to
        /// convey some sort of application status or to passively notify the user.
        abstract setOverlayIcon: overlay: NativeImage * description: string -> unit
        /// Sets parent as current window's parent window, passing null will turn current
        /// window into a top-level window.
        abstract setParentWindow: parent: BrowserWindow -> unit
        /// Moves window to x and y.
        abstract setPosition: x: float * y: float * ?animate: bool -> unit
        /// Sets progress value in progress bar. Valid range is [0, 1.0]. Remove progress
        /// bar when progress < 0; Change to indeterminate mode when progress > 1. On Linux
        /// platform, only supports Unity desktop environment, you need to specify the
        /// *.desktop file name to desktopName field in package.json. By default, it will
        /// assume app.getName().desktop. On Windows, a mode can be passed. Accepted values
        /// are none, normal, indeterminate, error, and paused. If you call setProgressBar
        /// without a mode set (but with a value within the valid range), normal will be
        /// assumed.
        abstract setProgressBar: progress: float * ?options: ProgressBarOptions -> unit
        /// Sets the pathname of the file the window represents, and the icon of the file
        /// will show in window's title bar.
        abstract setRepresentedFilename: filename: string -> unit
        /// Sets whether the window can be manually resized by user.
        abstract setResizable: resizable: bool -> unit
        /// Changes the attachment point for sheets on macOS. By default, sheets are
        /// attached just below the window frame, but you may want to display them beneath a
        /// HTML-rendered toolbar. For example:
        abstract setSheetOffset: offsetY: float * ?offsetX: float -> unit
        /// Enters or leaves simple fullscreen mode. Simple fullscreen mode emulates the
        /// native fullscreen behavior found in versions of Mac OS X prior to Lion (10.7).
        abstract setSimpleFullScreen: flag: bool -> unit
        /// Resizes the window to width and height.
        abstract setSize: width: float * height: float * ?animate: bool -> unit
        /// Makes the window not show in the taskbar.
        abstract setSkipTaskbar: skip: bool -> unit
        /// Add a thumbnail toolbar with a specified set of buttons to the thumbnail image
        /// of a window in a taskbar button layout. Returns a Boolean object indicates
        /// whether the thumbnail has been added successfully. The number of buttons in
        /// thumbnail toolbar should be no greater than 7 due to the limited room. Once you
        /// setup the thumbnail toolbar, the toolbar cannot be removed due to the platform's
        /// limitation. But you can call the API with an empty array to clean the buttons.
        /// The buttons is an array of Button objects: The flags is an array that can
        /// include following Strings:
        abstract setThumbarButtons: buttons: ResizeArray<ThumbarButton> -> bool
        /// Sets the region of the window to show as the thumbnail image displayed when
        /// hovering over the window in the taskbar. You can reset the thumbnail to be the
        /// entire window by specifying an empty region: {x: 0, y: 0, width: 0, height: 0}.
        abstract setThumbnailClip: region: Rectangle -> unit
        /// Sets the toolTip that is displayed when hovering over the window thumbnail in
        /// the taskbar.
        abstract setThumbnailToolTip: toolTip: string -> unit
        /// Changes the title of native window to title.
        abstract setTitle: title: string -> unit
        /// Sets the touchBar layout for the current window. Specifying null or undefined
        /// clears the touch bar. This method only has an effect if the machine has a touch
        /// bar and is running on macOS 10.12.1+. Note: The TouchBar API is currently
        /// experimental and may change or be removed in future Electron releases.
        abstract setTouchBar: touchBar: TouchBar -> unit
        /// Adds a vibrancy effect to the browser window. Passing null or an empty string
        /// will remove the vibrancy effect on the window.
        abstract setVibrancy: ``type``: obj -> unit
        /// Sets whether the window should be visible on all workspaces. Note: This API does
        /// nothing on Windows.
        abstract setVisibleOnAllWorkspaces: visible: bool -> unit
        /// Shows and gives focus to the window.
        abstract show: unit -> unit
        /// Same as webContents.showDefinitionForSelection().
        abstract showDefinitionForSelection: unit -> unit
        /// Shows the window but doesn't focus on it.
        abstract showInactive: unit -> unit
        /// Toggles the visibility of the tab bar if native tabs are enabled and there is
        /// only one tab in the current window.
        abstract toggleTabBar: unit -> unit
        /// Unhooks all of the window messages.
        abstract unhookAllWindowMessages: unit -> unit
        /// Unhook the window message.
        abstract unhookWindowMessage: message: float -> unit
        /// Unmaximizes the window.
        abstract unmaximize: unit -> unit
        abstract id: float with get, set
        abstract webContents: WebContents with get, set

    type [<AllowNullLiteral>] BrowserWindowStatic =
        [<Emit "new $0($1...)">] abstract Create: ?options: BrowserWindowConstructorOptions -> BrowserWindow
        /// Adds DevTools extension located at path, and returns extension's name. The
        /// extension will be remembered so you only need to call this API once, this API is
        /// not for programming use. If you try to add an extension that has already been
        /// loaded, this method will not return and instead log a warning to the console.
        /// The method will also not return if the extension's manifest is missing or
        /// incomplete. Note: This API cannot be called before the ready event of the app
        /// module is emitted.
        abstract addDevToolsExtension: path: string -> unit
        /// Adds Chrome extension located at path, and returns extension's name. The method
        /// will also not return if the extension's manifest is missing or incomplete. Note:
        /// This API cannot be called before the ready event of the app module is emitted.
        abstract addExtension: path: string -> unit
        abstract fromBrowserView: browserView: BrowserView -> BrowserWindow option
        abstract fromId: id: float -> BrowserWindow
        abstract fromWebContents: webContents: WebContents -> BrowserWindow
        abstract getAllWindows: unit -> ResizeArray<BrowserWindow>
        /// To check if a DevTools extension is installed you can run the following: Note:
        /// This API cannot be called before the ready event of the app module is emitted.
        abstract getDevToolsExtensions: unit -> DevToolsExtensions
        /// Note: This API cannot be called before the ready event of the app module is
        /// emitted.
        abstract getExtensions: unit -> Extensions
        abstract getFocusedWindow: unit -> BrowserWindow
        /// Remove a DevTools extension by name. Note: This API cannot be called before the
        /// ready event of the app module is emitted.
        abstract removeDevToolsExtension: name: string -> unit
        /// Remove a Chrome extension by name. Note: This API cannot be called before the
        /// ready event of the app module is emitted.
        abstract removeExtension: name: string -> unit

    type [<AllowNullLiteral>] BrowserWindowProxy =
        inherit EventEmitter
        /// Removes focus from the child window.
        abstract blur: unit -> unit
        /// Forcefully closes the child window without calling its unload event.
        abstract close: unit -> unit
        /// Evaluates the code in the child window.
        abstract eval: code: string -> unit
        /// Focuses the child window (brings the window to front).
        abstract focus: unit -> unit
        /// Sends a message to the child window with the specified origin or * for no origin
        /// preference. In addition to these methods, the child window implements
        /// window.opener object with no properties and a single method.
        abstract postMessage: message: string * targetOrigin: string -> unit
        /// Invokes the print dialog on the child window.
        abstract print: unit -> unit
        abstract closed: bool with get, set

    type [<AllowNullLiteral>] BrowserWindowProxyStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> BrowserWindowProxy

    type [<AllowNullLiteral>] Certificate =
        /// PEM encoded data
        abstract data: string with get, set
        /// Fingerprint of the certificate
        abstract fingerprint: string with get, set
        /// Issuer principal
        abstract issuer: CertificatePrincipal with get, set
        /// Issuer certificate (if not self-signed)
        abstract issuerCert: Certificate with get, set
        /// Issuer's Common Name
        abstract issuerName: string with get, set
        /// Hex value represented string
        abstract serialNumber: string with get, set
        /// Subject principal
        abstract subject: CertificatePrincipal with get, set
        /// Subject's Common Name
        abstract subjectName: string with get, set
        /// End date of the certificate being valid in seconds
        abstract validExpiry: float with get, set
        /// Start date of the certificate being valid in seconds
        abstract validStart: float with get, set

    type [<AllowNullLiteral>] CertificatePrincipal =
        /// Common Name
        abstract commonName: string with get, set
        /// Country or region
        abstract country: string with get, set
        /// Locality
        abstract locality: string with get, set
        /// Organization names
        abstract organizations: ResizeArray<string> with get, set
        /// Organization Unit names
        abstract organizationUnits: ResizeArray<string> with get, set
        /// State or province
        abstract state: string with get, set

    type [<AllowNullLiteral>] ClientRequest =
        inherit EventEmitter
        /// Emitted when the request is aborted. The abort event will not be fired if the
        /// request is already closed.
        [<Emit "$0.on('abort',$1)">] abstract on_abort: listener: Function -> ClientRequest
        [<Emit "$0.once('abort',$1)">] abstract once_abort: listener: Function -> ClientRequest
        [<Emit "$0.addListener('abort',$1)">] abstract addListener_abort: listener: Function -> ClientRequest
        [<Emit "$0.removeListener('abort',$1)">] abstract removeListener_abort: listener: Function -> ClientRequest
        /// Emitted as the last event in the HTTP request-response transaction. The close
        /// event indicates that no more events will be emitted on either the request or
        /// response objects.
        [<Emit "$0.on('close',$1)">] abstract on_close: listener: Function -> ClientRequest
        [<Emit "$0.once('close',$1)">] abstract once_close: listener: Function -> ClientRequest
        [<Emit "$0.addListener('close',$1)">] abstract addListener_close: listener: Function -> ClientRequest
        [<Emit "$0.removeListener('close',$1)">] abstract removeListener_close: listener: Function -> ClientRequest
        /// Emitted when the net module fails to issue a network request. Typically when the
        /// request object emits an error event, a close event will subsequently follow and
        /// no response object will be provided.
        [<Emit "$0.on('error',$1)">] abstract on_error: listener: (Error -> unit) -> ClientRequest
        [<Emit "$0.once('error',$1)">] abstract once_error: listener: (Error -> unit) -> ClientRequest
        [<Emit "$0.addListener('error',$1)">] abstract addListener_error: listener: (Error -> unit) -> ClientRequest
        [<Emit "$0.removeListener('error',$1)">] abstract removeListener_error: listener: (Error -> unit) -> ClientRequest
        /// Emitted just after the last chunk of the request's data has been written into
        /// the request object.
        [<Emit "$0.on('finish',$1)">] abstract on_finish: listener: Function -> ClientRequest
        [<Emit "$0.once('finish',$1)">] abstract once_finish: listener: Function -> ClientRequest
        [<Emit "$0.addListener('finish',$1)">] abstract addListener_finish: listener: Function -> ClientRequest
        [<Emit "$0.removeListener('finish',$1)">] abstract removeListener_finish: listener: Function -> ClientRequest
        /// Emitted when an authenticating proxy is asking for user credentials. The
        /// callback function is expected to be called back with user credentials: Providing
        /// empty credentials will cancel the request and report an authentication error on
        /// the response object:
        [<Emit "$0.on('login',$1)">] abstract on_login: listener: (AuthInfo -> (string -> string -> unit) -> unit) -> ClientRequest
        [<Emit "$0.once('login',$1)">] abstract once_login: listener: (AuthInfo -> (string -> string -> unit) -> unit) -> ClientRequest
        [<Emit "$0.addListener('login',$1)">] abstract addListener_login: listener: (AuthInfo -> (string -> string -> unit) -> unit) -> ClientRequest
        [<Emit "$0.removeListener('login',$1)">] abstract removeListener_login: listener: (AuthInfo -> (string -> string -> unit) -> unit) -> ClientRequest
        /// Emitted when there is redirection and the mode is manual. Calling
        /// request.followRedirect will continue with the redirection.
        [<Emit "$0.on('redirect',$1)">] abstract on_redirect: listener: (float -> string -> string -> obj option -> unit) -> ClientRequest
        [<Emit "$0.once('redirect',$1)">] abstract once_redirect: listener: (float -> string -> string -> obj option -> unit) -> ClientRequest
        [<Emit "$0.addListener('redirect',$1)">] abstract addListener_redirect: listener: (float -> string -> string -> obj option -> unit) -> ClientRequest
        [<Emit "$0.removeListener('redirect',$1)">] abstract removeListener_redirect: listener: (float -> string -> string -> obj option -> unit) -> ClientRequest
        [<Emit "$0.on('response',$1)">] abstract on_response: listener: (IncomingMessage -> unit) -> ClientRequest
        [<Emit "$0.once('response',$1)">] abstract once_response: listener: (IncomingMessage -> unit) -> ClientRequest
        [<Emit "$0.addListener('response',$1)">] abstract addListener_response: listener: (IncomingMessage -> unit) -> ClientRequest
        [<Emit "$0.removeListener('response',$1)">] abstract removeListener_response: listener: (IncomingMessage -> unit) -> ClientRequest
        /// Cancels an ongoing HTTP transaction. If the request has already emitted the
        /// close event, the abort operation will have no effect. Otherwise an ongoing event
        /// will emit abort and close events. Additionally, if there is an ongoing response
        /// object,it will emit the aborted event.
        abstract abort: unit -> unit
        /// Sends the last chunk of the request data. Subsequent write or end operations
        /// will not be allowed. The finish event is emitted just after the end operation.
        abstract ``end``: ?chunk: U2<string, Buffer> * ?encoding: string * ?callback: Function -> unit
        /// Continues any deferred redirection request when the redirection mode is manual.
        abstract followRedirect: unit -> unit
        abstract getHeader: name: string -> Header
        /// Removes a previously set extra header name. This method can be called only
        /// before first write. Trying to call it after the first write will throw an error.
        abstract removeHeader: name: string -> unit
        /// Adds an extra HTTP header. The header name will issued as it is without
        /// lowercasing. It can be called only before first write. Calling this method after
        /// the first write will throw an error. If the passed value is not a String, its
        /// toString() method will be called to obtain the final value.
        abstract setHeader: name: string * value: obj option -> unit
        /// callback is essentially a dummy function introduced in the purpose of keeping
        /// similarity with the Node.js API. It is called asynchronously in the next tick
        /// after chunk content have been delivered to the Chromium networking layer.
        /// Contrary to the Node.js implementation, it is not guaranteed that chunk content
        /// have been flushed on the wire before callback is called. Adds a chunk of data to
        /// the request body. The first write operation may cause the request headers to be
        /// issued on the wire. After the first write operation, it is not allowed to add or
        /// remove a custom header.
        abstract write: chunk: U2<string, Buffer> * ?encoding: string * ?callback: Function -> unit
        abstract chunkedEncoding: bool with get, set

    type [<AllowNullLiteral>] ClientRequestStatic =
        [<Emit "new $0($1...)">] abstract Create: options: obj -> ClientRequest

    type [<AllowNullLiteral>] Clipboard =
        inherit EventEmitter
        abstract availableFormats: ?``type``: string -> ResizeArray<string>
        /// Clears the clipboard content.
        abstract clear: ?``type``: string -> unit
        abstract has: format: string * ?``type``: string -> bool
        abstract read: format: string -> string
        /// Returns an Object containing title and url keys representing the bookmark in the
        /// clipboard. The title and url values will be empty strings when the bookmark is
        /// unavailable.
        abstract readBookmark: unit -> ReadBookmark
        abstract readBuffer: format: string -> Buffer
        abstract readFindText: unit -> string
        abstract readHTML: ?``type``: string -> string
        abstract readImage: ?``type``: string -> NativeImage
        abstract readRTF: ?``type``: string -> string
        abstract readText: ?``type``: string -> string
        /// Writes data to the clipboard.
        abstract write: data: Data * ?``type``: string -> unit
        /// Writes the title and url into the clipboard as a bookmark. Note: Most apps on
        /// Windows don't support pasting bookmarks into them so you can use clipboard.write
        /// to write both a bookmark and fallback text to the clipboard.
        abstract writeBookmark: title: string * url: string * ?``type``: string -> unit
        /// Writes the buffer into the clipboard as format.
        abstract writeBuffer: format: string * buffer: Buffer * ?``type``: string -> unit
        /// Writes the text into the find pasteboard as plain text. This method uses
        /// synchronous IPC when called from the renderer process.
        abstract writeFindText: text: string -> unit
        /// Writes markup to the clipboard.
        abstract writeHTML: markup: string * ?``type``: string -> unit
        /// Writes image to the clipboard.
        abstract writeImage: image: NativeImage * ?``type``: string -> unit
        /// Writes the text into the clipboard in RTF.
        abstract writeRTF: text: string * ?``type``: string -> unit
        /// Writes the text into the clipboard as plain text.
        abstract writeText: text: string * ?``type``: string -> unit

    type [<AllowNullLiteral>] ContentTracing =
        inherit EventEmitter
        /// Get the current monitoring traced data. Child processes typically cache trace
        /// data and only rarely flush and send trace data back to the main process. This is
        /// because it may be an expensive operation to send the trace data over IPC and we
        /// would like to avoid unneeded runtime overhead from tracing. So, to end tracing,
        /// we must asynchronously ask all child processes to flush any pending trace data.
        /// Once all child processes have acknowledged the captureMonitoringSnapshot request
        /// the callback will be called with a file that contains the traced data.
        abstract captureMonitoringSnapshot: resultFilePath: string * callback: (string -> unit) -> unit
        /// Get a set of category groups. The category groups can change as new code paths
        /// are reached. Once all child processes have acknowledged the getCategories
        /// request the callback is invoked with an array of category groups.
        abstract getCategories: callback: (ResizeArray<string> -> unit) -> unit
        /// Get the maximum usage across processes of trace buffer as a percentage of the
        /// full state. When the TraceBufferUsage value is determined the callback is
        /// called.
        abstract getTraceBufferUsage: callback: (float -> float -> unit) -> unit
        /// Start monitoring on all processes. Monitoring begins immediately locally and
        /// asynchronously on child processes as soon as they receive the startMonitoring
        /// request. Once all child processes have acknowledged the startMonitoring request
        /// the callback will be called.
        abstract startMonitoring: options: StartMonitoringOptions * callback: Function -> unit
        /// Start recording on all processes. Recording begins immediately locally and
        /// asynchronously on child processes as soon as they receive the EnableRecording
        /// request. The callback will be called once all child processes have acknowledged
        /// the startRecording request. categoryFilter is a filter to control what category
        /// groups should be traced. A filter can have an optional - prefix to exclude
        /// category groups that contain a matching category. Having both included and
        /// excluded category patterns in the same list is not supported. Examples:
        /// traceOptions controls what kind of tracing is enabled, it is a comma-delimited
        /// list. Possible options are: The first 3 options are trace recording modes and
        /// hence mutually exclusive. If more than one trace recording modes appear in the
        /// traceOptions string, the last one takes precedence. If none of the trace
        /// recording modes are specified, recording mode is record-until-full. The trace
        /// option will first be reset to the default option (record_mode set to
        /// record-until-full, enable_sampling and enable_systrace set to false) before
        /// options parsed from traceOptions are applied on it.
        abstract startRecording: options: StartRecordingOptions * callback: Function -> unit
        /// Stop monitoring on all processes. Once all child processes have acknowledged the
        /// stopMonitoring request the callback is called.
        abstract stopMonitoring: callback: Function -> unit
        /// Stop recording on all processes. Child processes typically cache trace data and
        /// only rarely flush and send trace data back to the main process. This helps to
        /// minimize the runtime overhead of tracing since sending trace data over IPC can
        /// be an expensive operation. So, to end tracing, we must asynchronously ask all
        /// child processes to flush any pending trace data. Once all child processes have
        /// acknowledged the stopRecording request, callback will be called with a file that
        /// contains the traced data. Trace data will be written into resultFilePath if it
        /// is not empty or into a temporary file. The actual file path will be passed to
        /// callback if it's not null.
        abstract stopRecording: resultFilePath: string * callback: (string -> unit) -> unit

    type [<AllowNullLiteral>] Cookie =
        /// The domain of the cookie.
        abstract domain: string option with get, set
        /// The expiration date of the cookie as the number of seconds since the UNIX epoch.
        /// Not provided for session cookies.
        abstract expirationDate: float option with get, set
        /// Whether the cookie is a host-only cookie.
        abstract hostOnly: bool option with get, set
        /// Whether the cookie is marked as HTTP only.
        abstract httpOnly: bool option with get, set
        /// The name of the cookie.
        abstract name: string with get, set
        /// The path of the cookie.
        abstract path: string option with get, set
        /// Whether the cookie is marked as secure.
        abstract secure: bool option with get, set
        /// Whether the cookie is a session cookie or a persistent cookie with an expiration
        /// date.
        abstract session: bool option with get, set
        /// The value of the cookie.
        abstract value: string with get, set

    type [<AllowNullLiteral>] Cookies =
        inherit EventEmitter
        /// Emitted when a cookie is changed because it was added, edited, removed, or
        /// expired.
        [<Emit "$0.on('changed',$1)">] abstract on_changed: listener: (Event -> Cookie -> U5<string, string, string, string, string> -> bool -> unit) -> Cookies
        [<Emit "$0.once('changed',$1)">] abstract once_changed: listener: (Event -> Cookie -> U5<string, string, string, string, string> -> bool -> unit) -> Cookies
        [<Emit "$0.addListener('changed',$1)">] abstract addListener_changed: listener: (Event -> Cookie -> U5<string, string, string, string, string> -> bool -> unit) -> Cookies
        [<Emit "$0.removeListener('changed',$1)">] abstract removeListener_changed: listener: (Event -> Cookie -> U5<string, string, string, string, string> -> bool -> unit) -> Cookies
        /// Writes any unwritten cookies data to disk.
        abstract flushStore: callback: Function -> unit
        /// Sends a request to get all cookies matching details, callback will be called
        /// with callback(error, cookies) on complete.
        abstract get: filter: Filter * callback: (Error -> ResizeArray<Cookie> -> unit) -> unit
        /// Removes the cookies matching url and name, callback will called with callback()
        /// on complete.
        abstract remove: url: string * name: string * callback: Function -> unit
        /// Sets a cookie with details, callback will be called with callback(error) on
        /// complete.
        abstract set: details: Details * callback: (Error -> unit) -> unit

    type [<AllowNullLiteral>] CookiesStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> Cookies

    type [<AllowNullLiteral>] CPUUsage =
        /// The number of average idle cpu wakeups per second since the last call to
        /// getCPUUsage. First call returns 0. Will always return 0 on Windows.
        abstract idleWakeupsPerSecond: float with get, set
        /// Percentage of CPU used since the last call to getCPUUsage. First call returns 0.
        abstract percentCPUUsage: float with get, set

    type [<AllowNullLiteral>] CrashReport =
        abstract date: string with get, set
        abstract ID: float with get, set

    type [<AllowNullLiteral>] CrashReporter =
        inherit EventEmitter
        /// Set an extra parameter to be sent with the crash report. The values specified
        /// here will be sent in addition to any values set via the extra option when start
        /// was called. This API is only available on macOS, if you need to add/update extra
        /// parameters on Linux and Windows after your first call to start you can call
        /// start again with the updated extra options.
        abstract addExtraParameter: key: string * value: string -> unit
        /// Returns the date and ID of the last crash report. If no crash reports have been
        /// sent or the crash reporter has not been started, null is returned.
        abstract getLastCrashReport: unit -> CrashReport
        /// See all of the current parameters being passed to the crash reporter.
        abstract getParameters: unit -> unit
        /// Returns all uploaded crash reports. Each report contains the date and uploaded
        /// ID.
        abstract getUploadedReports: unit -> ResizeArray<CrashReport>
        /// Note: This API can only be called from the main process.
        abstract getUploadToServer: unit -> bool
        /// Remove a extra parameter from the current set of parameters so that it will not
        /// be sent with the crash report.
        abstract removeExtraParameter: key: string -> unit
        /// This would normally be controlled by user preferences. This has no effect if
        /// called before start is called. Note: This API can only be called from the main
        /// process.
        abstract setUploadToServer: uploadToServer: bool -> unit
        /// You are required to call this method before using any other crashReporter APIs
        /// and in each process (main/renderer) from which you want to collect crash
        /// reports. You can pass different options to crashReporter.start when calling from
        /// different processes. Note Child processes created via the child_process module
        /// will not have access to the Electron modules. Therefore, to collect crash
        /// reports from them, use process.crashReporter.start instead. Pass the same
        /// options as above along with an additional one called crashesDirectory that
        /// should point to a directory to store the crash reports temporarily. You can test
        /// this out by calling process.crash() to crash the child process. Note: To collect
        /// crash reports from child process in Windows, you need to add this extra code as
        /// well. This will start the process that will monitor and send the crash reports.
        /// Replace submitURL, productName and crashesDirectory with appropriate values.
        /// Note: If you need send additional/updated extra parameters after your first call
        /// start you can call setExtraParameter on macOS or call start again with the
        /// new/updated extra parameters on Linux and Windows. Note: On macOS, Electron uses
        /// a new crashpad client for crash collection and reporting. If you want to enable
        /// crash reporting, initializing crashpad from the main process using
        /// crashReporter.start is required regardless of which process you want to collect
        /// crashes from. Once initialized this way, the crashpad handler collects crashes
        /// from all processes. You still have to call crashReporter.start from the renderer
        /// or child process, otherwise crashes from them will get reported without
        /// companyName, productName or any of the extra information.
        abstract start: options: CrashReporterStartOptions -> unit

    type [<AllowNullLiteral>] Debugger =
        inherit EventEmitter
        /// Emitted when debugging session is terminated. This happens either when
        /// webContents is closed or devtools is invoked for the attached webContents.
        [<Emit "$0.on('detach',$1)">] abstract on_detach: listener: (Event -> string -> unit) -> Debugger
        [<Emit "$0.once('detach',$1)">] abstract once_detach: listener: (Event -> string -> unit) -> Debugger
        [<Emit "$0.addListener('detach',$1)">] abstract addListener_detach: listener: (Event -> string -> unit) -> Debugger
        [<Emit "$0.removeListener('detach',$1)">] abstract removeListener_detach: listener: (Event -> string -> unit) -> Debugger
        /// Emitted whenever debugging target issues instrumentation event.
        [<Emit "$0.on('message',$1)">] abstract on_message: listener: (Event -> string -> obj option -> unit) -> Debugger
        [<Emit "$0.once('message',$1)">] abstract once_message: listener: (Event -> string -> obj option -> unit) -> Debugger
        [<Emit "$0.addListener('message',$1)">] abstract addListener_message: listener: (Event -> string -> obj option -> unit) -> Debugger
        [<Emit "$0.removeListener('message',$1)">] abstract removeListener_message: listener: (Event -> string -> obj option -> unit) -> Debugger
        /// Attaches the debugger to the webContents.
        abstract attach: ?protocolVersion: string -> unit
        /// Detaches the debugger from the webContents.
        abstract detach: unit -> unit
        abstract isAttached: unit -> bool
        /// Send given command to the debugging target.
        abstract sendCommand: ``method``: string * ?commandParams: obj option * ?callback: (obj option -> obj option -> unit) -> unit

    type [<AllowNullLiteral>] DebuggerStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> Debugger

    type [<AllowNullLiteral>] DesktopCapturer =
        inherit EventEmitter
        /// Starts gathering information about all available desktop media sources, and
        /// calls callback(error, sources) when finished. sources is an array of
        /// DesktopCapturerSource objects, each DesktopCapturerSource represents a screen or
        /// an individual window that can be captured.
        abstract getSources: options: SourcesOptions * callback: (Error -> ResizeArray<DesktopCapturerSource> -> unit) -> unit

    type [<AllowNullLiteral>] DesktopCapturerSource =
        /// The identifier of a window or screen that can be used as a chromeMediaSourceId
        /// constraint when calling [navigator.webkitGetUserMedia]. The format of the
        /// identifier will be window:XX or screen:XX, where XX is a random generated
        /// number.
        abstract id: string with get, set
        /// A screen source will be named either Entire Screen or Screen <index>, while the
        /// name of a window source will match the window title.
        abstract name: string with get, set
        /// A thumbnail image. There is no guarantee that the size of the thumbnail is the
        /// same as the thumbnailSize specified in the options passed to
        /// desktopCapturer.getSources. The actual size depends on the scale of the screen
        /// or window.
        abstract thumbnail: NativeImage with get, set

    type [<AllowNullLiteral>] Dialog =
        inherit EventEmitter
        /// On macOS, this displays a modal dialog that shows a message and certificate
        /// information, and gives the user the option of trusting/importing the
        /// certificate. If you provide a browserWindow argument the dialog will be attached
        /// to the parent window, making it modal. On Windows the options are more limited,
        /// due to the Win32 APIs used:
        abstract showCertificateTrustDialog: browserWindow: BrowserWindow * options: CertificateTrustDialogOptions * callback: Function -> unit
        /// On macOS, this displays a modal dialog that shows a message and certificate
        /// information, and gives the user the option of trusting/importing the
        /// certificate. If you provide a browserWindow argument the dialog will be attached
        /// to the parent window, making it modal. On Windows the options are more limited,
        /// due to the Win32 APIs used:
        abstract showCertificateTrustDialog: options: CertificateTrustDialogOptions * callback: Function -> unit
        /// Displays a modal dialog that shows an error message. This API can be called
        /// safely before the ready event the app module emits, it is usually used to report
        /// errors in early stage of startup.  If called before the app readyevent on Linux,
        /// the message will be emitted to stderr, and no GUI dialog will appear.
        abstract showErrorBox: title: string * content: string -> unit
        /// Shows a message box, it will block the process until the message box is closed.
        /// It returns the index of the clicked button. The browserWindow argument allows
        /// the dialog to attach itself to a parent window, making it modal. If a callback
        /// is passed, the dialog will not block the process. The API call will be
        /// asynchronous and the result will be passed via callback(response).
        abstract showMessageBox: browserWindow: BrowserWindow * options: MessageBoxOptions * ?callback: (float -> bool -> unit) -> float
        /// Shows a message box, it will block the process until the message box is closed.
        /// It returns the index of the clicked button. The browserWindow argument allows
        /// the dialog to attach itself to a parent window, making it modal. If a callback
        /// is passed, the dialog will not block the process. The API call will be
        /// asynchronous and the result will be passed via callback(response).
        abstract showMessageBox: options: MessageBoxOptions * ?callback: (float -> bool -> unit) -> float
        /// The browserWindow argument allows the dialog to attach itself to a parent
        /// window, making it modal. The filters specifies an array of file types that can
        /// be displayed or selected when you want to limit the user to a specific type. For
        /// example: The extensions array should contain extensions without wildcards or
        /// dots (e.g. 'png' is good but '.png' and '*.png' are bad). To show all files, use
        /// the '*' wildcard (no other wildcard is supported). If a callback is passed, the
        /// API call will be asynchronous and the result will be passed via
        /// callback(filenames) Note: On Windows and Linux an open dialog can not be both a
        /// file selector and a directory selector, so if you set properties to ['openFile',
        /// 'openDirectory'] on these platforms, a directory selector will be shown.
        abstract showOpenDialog: browserWindow: BrowserWindow * options: OpenDialogOptions * ?callback: (ResizeArray<string> -> unit) -> ResizeArray<string>
        /// The browserWindow argument allows the dialog to attach itself to a parent
        /// window, making it modal. The filters specifies an array of file types that can
        /// be displayed or selected when you want to limit the user to a specific type. For
        /// example: The extensions array should contain extensions without wildcards or
        /// dots (e.g. 'png' is good but '.png' and '*.png' are bad). To show all files, use
        /// the '*' wildcard (no other wildcard is supported). If a callback is passed, the
        /// API call will be asynchronous and the result will be passed via
        /// callback(filenames) Note: On Windows and Linux an open dialog can not be both a
        /// file selector and a directory selector, so if you set properties to ['openFile',
        /// 'openDirectory'] on these platforms, a directory selector will be shown.
        abstract showOpenDialog: options: OpenDialogOptions * ?callback: (ResizeArray<string> -> unit) -> ResizeArray<string>
        /// The browserWindow argument allows the dialog to attach itself to a parent
        /// window, making it modal. The filters specifies an array of file types that can
        /// be displayed, see dialog.showOpenDialog for an example. If a callback is passed,
        /// the API call will be asynchronous and the result will be passed via
        /// callback(filename)
        abstract showSaveDialog: browserWindow: BrowserWindow * options: SaveDialogOptions * ?callback: (string -> unit) -> string
        /// The browserWindow argument allows the dialog to attach itself to a parent
        /// window, making it modal. The filters specifies an array of file types that can
        /// be displayed, see dialog.showOpenDialog for an example. If a callback is passed,
        /// the API call will be asynchronous and the result will be passed via
        /// callback(filename)
        abstract showSaveDialog: options: SaveDialogOptions * ?callback: (string -> unit) -> string

    type [<AllowNullLiteral>] Display =
        abstract bounds: Rectangle with get, set
        /// Unique identifier associated with the display.
        abstract id: float with get, set
        /// Can be 0, 90, 180, 270, represents screen rotation in clock-wise degrees.
        abstract rotation: float with get, set
        /// Output device's pixel scale factor.
        abstract scaleFactor: float with get, set
        abstract size: Size with get, set
        /// Can be available, unavailable, unknown.
        abstract touchSupport: U3<string, string, string> with get, set
        abstract workArea: Rectangle with get, set
        abstract workAreaSize: Size with get, set

    type [<AllowNullLiteral>] DownloadItem =
        inherit EventEmitter
        /// Emitted when the download is in a terminal state. This includes a completed
        /// download, a cancelled download (via downloadItem.cancel()), and interrupted
        /// download that can't be resumed. The state can be one of following:
        [<Emit "$0.on('done',$1)">] abstract on_done: listener: (Event -> string -> unit) -> DownloadItem
        [<Emit "$0.once('done',$1)">] abstract once_done: listener: (Event -> string -> unit) -> DownloadItem
        [<Emit "$0.addListener('done',$1)">] abstract addListener_done: listener: (Event -> string -> unit) -> DownloadItem
        [<Emit "$0.removeListener('done',$1)">] abstract removeListener_done: listener: (Event -> string -> unit) -> DownloadItem
        /// Emitted when the download has been updated and is not done. The state can be one
        /// of following:
        [<Emit "$0.on('updated',$1)">] abstract on_updated: listener: (Event -> string -> unit) -> DownloadItem
        [<Emit "$0.once('updated',$1)">] abstract once_updated: listener: (Event -> string -> unit) -> DownloadItem
        [<Emit "$0.addListener('updated',$1)">] abstract addListener_updated: listener: (Event -> string -> unit) -> DownloadItem
        [<Emit "$0.removeListener('updated',$1)">] abstract removeListener_updated: listener: (Event -> string -> unit) -> DownloadItem
        /// Cancels the download operation.
        abstract cancel: unit -> unit
        abstract canResume: unit -> bool
        abstract getContentDisposition: unit -> string
        abstract getETag: unit -> string
        /// Note: The file name is not always the same as the actual one saved in local
        /// disk. If user changes the file name in a prompted download saving dialog, the
        /// actual name of saved file will be different.
        abstract getFilename: unit -> string
        abstract getLastModifiedTime: unit -> string
        abstract getMimeType: unit -> string
        abstract getReceivedBytes: unit -> float
        abstract getSavePath: unit -> string
        abstract getStartTime: unit -> float
        /// Note: The following methods are useful specifically to resume a cancelled item
        /// when session is restarted.
        abstract getState: unit -> U4<string, string, string, string>
        /// If the size is unknown, it returns 0.
        abstract getTotalBytes: unit -> float
        abstract getURL: unit -> string
        abstract getURLChain: unit -> ResizeArray<string>
        abstract hasUserGesture: unit -> bool
        abstract isPaused: unit -> bool
        /// Pauses the download.
        abstract pause: unit -> unit
        /// Resumes the download that has been paused. Note: To enable resumable downloads
        /// the server you are downloading from must support range requests and provide both
        /// Last-Modified and ETag header values. Otherwise resume() will dismiss previously
        /// received bytes and restart the download from the beginning.
        abstract resume: unit -> unit
        /// The API is only available in session's will-download callback function. If user
        /// doesn't set the save path via the API, Electron will use the original routine to
        /// determine the save path(Usually prompts a save dialog).
        abstract setSavePath: path: string -> unit

    type [<AllowNullLiteral>] DownloadItemStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> DownloadItem

    type [<AllowNullLiteral>] FileFilter =
        abstract extensions: ResizeArray<string> with get, set
        abstract name: string with get, set

    type [<AllowNullLiteral>] GlobalShortcut =
        inherit EventEmitter
        /// When the accelerator is already taken by other applications, this call will
        /// still return false. This behavior is intended by operating systems, since they
        /// don't want applications to fight for global shortcuts.
        abstract isRegistered: accelerator: Accelerator -> bool
        /// Registers a global shortcut of accelerator. The callback is called when the
        /// registered shortcut is pressed by the user. When the accelerator is already
        /// taken by other applications, this call will silently fail. This behavior is
        /// intended by operating systems, since they don't want applications to fight for
        /// global shortcuts.
        abstract register: accelerator: Accelerator * callback: Function -> unit
        /// Unregisters the global shortcut of accelerator.
        abstract unregister: accelerator: Accelerator -> unit
        /// Unregisters all of the global shortcuts.
        abstract unregisterAll: unit -> unit

    type [<AllowNullLiteral>] GPUFeatureStatus =
        /// Canvas
        abstract ``2d_canvas``: string with get, set
        /// Flash
        abstract flash_3d: string with get, set
        /// Flash Stage3D
        abstract flash_stage3d: string with get, set
        /// Flash Stage3D Baseline profile
        abstract flash_stage3d_baseline: string with get, set
        /// Compositing
        abstract gpu_compositing: string with get, set
        /// Multiple Raster Threads
        abstract multiple_raster_threads: string with get, set
        /// Native GpuMemoryBuffers
        abstract native_gpu_memory_buffers: string with get, set
        /// Rasterization
        abstract rasterization: string with get, set
        /// Video Decode
        abstract video_decode: string with get, set
        /// Video Encode
        abstract video_encode: string with get, set
        /// VPx Video Decode
        abstract vpx_decode: string with get, set
        /// WebGL
        abstract webgl: string with get, set
        /// WebGL2
        abstract webgl2: string with get, set

    type [<AllowNullLiteral>] IncomingMessage =
        inherit EventEmitter
        /// Emitted when a request has been canceled during an ongoing HTTP transaction.
        [<Emit "$0.on('aborted',$1)">] abstract on_aborted: listener: Function -> IncomingMessage
        [<Emit "$0.once('aborted',$1)">] abstract once_aborted: listener: Function -> IncomingMessage
        [<Emit "$0.addListener('aborted',$1)">] abstract addListener_aborted: listener: Function -> IncomingMessage
        [<Emit "$0.removeListener('aborted',$1)">] abstract removeListener_aborted: listener: Function -> IncomingMessage
        /// The data event is the usual method of transferring response data into
        /// applicative code.
        [<Emit "$0.on('data',$1)">] abstract on_data: listener: (Buffer -> unit) -> IncomingMessage
        [<Emit "$0.once('data',$1)">] abstract once_data: listener: (Buffer -> unit) -> IncomingMessage
        [<Emit "$0.addListener('data',$1)">] abstract addListener_data: listener: (Buffer -> unit) -> IncomingMessage
        [<Emit "$0.removeListener('data',$1)">] abstract removeListener_data: listener: (Buffer -> unit) -> IncomingMessage
        /// Indicates that response body has ended.
        [<Emit "$0.on('end',$1)">] abstract on_end: listener: Function -> IncomingMessage
        [<Emit "$0.once('end',$1)">] abstract once_end: listener: Function -> IncomingMessage
        [<Emit "$0.addListener('end',$1)">] abstract addListener_end: listener: Function -> IncomingMessage
        [<Emit "$0.removeListener('end',$1)">] abstract removeListener_end: listener: Function -> IncomingMessage
        /// error Error - Typically holds an error string identifying failure root cause.
        /// Emitted when an error was encountered while streaming response data events. For
        /// instance, if the server closes the underlying while the response is still
        /// streaming, an error event will be emitted on the response object and a close
        /// event will subsequently follow on the request object.
        [<Emit "$0.on('error',$1)">] abstract on_error: listener: Function -> IncomingMessage
        [<Emit "$0.once('error',$1)">] abstract once_error: listener: Function -> IncomingMessage
        [<Emit "$0.addListener('error',$1)">] abstract addListener_error: listener: Function -> IncomingMessage
        [<Emit "$0.removeListener('error',$1)">] abstract removeListener_error: listener: Function -> IncomingMessage
        abstract headers: obj option with get, set
        abstract httpVersion: string with get, set
        abstract httpVersionMajor: float with get, set
        abstract httpVersionMinor: float with get, set
        abstract statusCode: float with get, set
        abstract statusMessage: string with get, set

    type [<AllowNullLiteral>] IncomingMessageStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> IncomingMessage

    type [<AllowNullLiteral>] IOCounters =
        /// Then number of I/O other operations.
        abstract otherOperationCount: float with get, set
        /// Then number of I/O other transfers.
        abstract otherTransferCount: float with get, set
        /// The number of I/O read operations.
        abstract readOperationCount: float with get, set
        /// The number of I/O read transfers.
        abstract readTransferCount: float with get, set
        /// The number of I/O write operations.
        abstract writeOperationCount: float with get, set
        /// The number of I/O write transfers.
        abstract writeTransferCount: float with get, set

    type [<AllowNullLiteral>] IpcMain =
        inherit EventEmitter
        /// Listens to channel, when a new message arrives listener would be called with
        /// listener(event, args...).
        abstract on: channel: string * listener: Function -> IpcMain
        /// Adds a one time listener function for the event. This listener is invoked only
        /// the next time a message is sent to channel, after which it is removed.
        abstract once: channel: string * listener: Function -> IpcMain
        /// Removes listeners of the specified channel.
        abstract removeAllListeners: channel: string -> IpcMain
        /// Removes the specified listener from the listener array for the specified
        /// channel.
        abstract removeListener: channel: string * listener: Function -> IpcMain

    type [<AllowNullLiteral>] IpcRenderer =
        inherit EventEmitter
        /// Listens to channel, when a new message arrives listener would be called with
        /// listener(event, args...).
        abstract on: channel: string * listener: Function -> IpcRenderer
        /// Adds a one time listener function for the event. This listener is invoked only
        /// the next time a message is sent to channel, after which it is removed.
        abstract once: channel: string * listener: Function -> IpcRenderer
        /// Removes all listeners, or those of the specified channel.
        abstract removeAllListeners: channel: string -> IpcRenderer
        /// Removes the specified listener from the listener array for the specified
        /// channel.
        abstract removeListener: channel: string * listener: Function -> IpcRenderer
        /// Send a message to the main process asynchronously via channel, you can also send
        /// arbitrary arguments. Arguments will be serialized in JSON internally and hence
        /// no functions or prototype chain will be included. The main process handles it by
        /// listening for channel with ipcMain module.
        abstract send: channel: string * [<ParamArray>] args: ResizeArray<obj option> -> unit
        /// Send a message to the main process synchronously via channel, you can also send
        /// arbitrary arguments. Arguments will be serialized in JSON internally and hence
        /// no functions or prototype chain will be included. The main process handles it by
        /// listening for channel with ipcMain module, and replies by setting
        /// event.returnValue. Note: Sending a synchronous message will block the whole
        /// renderer process, unless you know what you are doing you should never use it.
        abstract sendSync: channel: string * [<ParamArray>] args: ResizeArray<obj option> -> obj option
        /// Sends a message to a window with windowid via channel
        abstract sendTo: windowId: float * channel: string * [<ParamArray>] args: ResizeArray<obj option> -> unit
        /// Like ipcRenderer.send but the event will be sent to the <webview> element in the
        /// host page instead of the main process.
        abstract sendToHost: channel: string * [<ParamArray>] args: ResizeArray<obj option> -> unit

    type [<AllowNullLiteral>] JumpListCategory =
        /// Array of objects if type is tasks or custom, otherwise it should be omitted.
        abstract items: ResizeArray<JumpListItem> option with get, set
        /// Must be set if type is custom, otherwise it should be omitted.
        abstract name: string option with get, set
        /// One of the following:
        abstract ``type``: U4<string, string, string, string> option with get, set

    type [<AllowNullLiteral>] JumpListItem =
        /// The command line arguments when program is executed. Should only be set if type
        /// is task.
        abstract args: string option with get, set
        /// Description of the task (displayed in a tooltip). Should only be set if type is
        /// task.
        abstract description: string option with get, set
        /// The index of the icon in the resource file. If a resource file contains multiple
        /// icons this value can be used to specify the zero-based index of the icon that
        /// should be displayed for this task. If a resource file contains only one icon,
        /// this property should be set to zero.
        abstract iconIndex: float option with get, set
        /// The absolute path to an icon to be displayed in a Jump List, which can be an
        /// arbitrary resource file that contains an icon (e.g. .ico, .exe, .dll). You can
        /// usually specify process.execPath to show the program icon.
        abstract iconPath: string option with get, set
        /// Path of the file to open, should only be set if type is file.
        abstract path: string option with get, set
        /// Path of the program to execute, usually you should specify process.execPath
        /// which opens the current program. Should only be set if type is task.
        abstract program: string option with get, set
        /// The text to be displayed for the item in the Jump List. Should only be set if
        /// type is task.
        abstract title: string option with get, set
        /// One of the following:
        abstract ``type``: U3<string, string, string> option with get, set

    type [<AllowNullLiteral>] MemoryInfo =
        /// The maximum amount of memory that has ever been pinned to actual physical RAM.
        /// On macOS its value will always be 0.
        abstract peakWorkingSetSize: float with get, set
        /// Process id of the process.
        abstract pid: float with get, set
        /// The amount of memory not shared by other processes, such as JS heap or HTML
        /// content.
        abstract privateBytes: float with get, set
        /// The amount of memory shared between processes, typically memory consumed by the
        /// Electron code itself
        abstract sharedBytes: float with get, set
        /// The amount of memory currently pinned to actual physical RAM.
        abstract workingSetSize: float with get, set

    type [<AllowNullLiteral>] MemoryUsageDetails =
        abstract count: float with get, set
        abstract liveSize: float with get, set
        abstract size: float with get, set

    type [<AllowNullLiteral>] Menu =
        /// Appends the menuItem to the menu.
        abstract append: menuItem: MenuItem -> unit
        /// Closes the context menu in the browserWindow.
        abstract closePopup: ?browserWindow: BrowserWindow -> unit
        abstract getMenuItemById: id: string -> MenuItem
        /// Inserts the menuItem to the pos position of the menu.
        abstract insert: pos: float * menuItem: MenuItem -> unit
        /// Pops up this menu as a context menu in the browserWindow.
        abstract popup: ?browserWindow: BrowserWindow * ?options: PopupOptions -> unit
        abstract items: ResizeArray<MenuItem> with get, set

    type [<AllowNullLiteral>] MenuStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> Menu
        /// Generally, the template is just an array of options for constructing a MenuItem.
        /// The usage can be referenced above. You can also attach other fields to the
        /// element of the template and they will become properties of the constructed menu
        /// items.
        abstract buildFromTemplate: template: ResizeArray<MenuItemConstructorOptions> -> Menu
        /// Note: The returned Menu instance doesn't support dynamic addition or removal of
        /// menu items. Instance properties can still be dynamically modified.
        abstract getApplicationMenu: unit -> Menu option
        /// Sends the action to the first responder of application. This is used for
        /// emulating default macOS menu behaviors. Usually you would just use the role
        /// property of a MenuItem. See the macOS Cocoa Event Handling Guide for more
        /// information on macOS' native actions.
        abstract sendActionToFirstResponder: action: string -> unit
        /// Sets menu as the application menu on macOS. On Windows and Linux, the menu will
        /// be set as each window's top menu. Passing null will remove the menu bar on
        /// Windows and Linux but has no effect on macOS. Note: This API has to be called
        /// after the ready event of app module.
        abstract setApplicationMenu: menu: Menu option -> unit

    type [<AllowNullLiteral>] MenuItem =
        abstract ``checked``: bool with get, set
        abstract click: Function with get, set
        abstract enabled: bool with get, set
        abstract label: string with get, set
        abstract visible: bool with get, set

    type [<AllowNullLiteral>] MenuItemStatic =
        [<Emit "new $0($1...)">] abstract Create: options: MenuItemConstructorOptions -> MenuItem

    type [<AllowNullLiteral>] MimeTypedBuffer =
        /// The actual Buffer content
        abstract data: Buffer with get, set
        /// The mimeType of the Buffer that you are sending
        abstract mimeType: string with get, set

    type [<AllowNullLiteral>] NativeImage =
        /// Add an image representation for a specific scale factor. This can be used to
        /// explicitly add different scale factor representations to an image. This can be
        /// called on empty images.
        abstract addRepresentation: options: AddRepresentationOptions -> unit
        abstract crop: rect: Rectangle -> NativeImage
        abstract getAspectRatio: unit -> float
        /// The difference between getBitmap() and toBitmap() is, getBitmap() does not copy
        /// the bitmap data, so you have to use the returned Buffer immediately in current
        /// event loop tick, otherwise the data might be changed or destroyed.
        abstract getBitmap: ?options: BitmapOptions -> Buffer
        /// Notice that the returned pointer is a weak pointer to the underlying native
        /// image instead of a copy, so you must ensure that the associated nativeImage
        /// instance is kept around.
        abstract getNativeHandle: unit -> Buffer
        abstract getSize: unit -> Size
        abstract isEmpty: unit -> bool
        abstract isTemplateImage: unit -> bool
        /// If only the height or the width are specified then the current aspect ratio will
        /// be preserved in the resized image.
        abstract resize: options: ResizeOptions -> NativeImage
        /// Marks the image as a template image.
        abstract setTemplateImage: option: bool -> unit
        abstract toBitmap: ?options: ToBitmapOptions -> Buffer
        abstract toDataURL: ?options: ToDataURLOptions -> string
        abstract toJPEG: quality: float -> Buffer
        abstract toPNG: ?options: ToPNGOptions -> Buffer

    type [<AllowNullLiteral>] NativeImageStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> NativeImage
        /// Creates an empty NativeImage instance.
        abstract createEmpty: unit -> NativeImage
        /// Creates a new NativeImage instance from buffer.
        abstract createFromBuffer: buffer: Buffer * ?options: CreateFromBufferOptions -> NativeImage
        /// Creates a new NativeImage instance from dataURL.
        abstract createFromDataURL: dataURL: string -> NativeImage
        /// Creates a new NativeImage instance from the NSImage that maps to the given image
        /// name.  See NSImageName for a list of possible values. The hslShift is applied to
        /// the image with the following rules This means that [-1, 0, 1] will make the
        /// image completely white and [-1, 1, 0] will make the image completely black.
        abstract createFromNamedImage: imageName: string * hslShift: ResizeArray<float> -> NativeImage
        /// Creates a new NativeImage instance from a file located at path. This method
        /// returns an empty image if the path does not exist, cannot be read, or is not a
        /// valid image.
        abstract createFromPath: path: string -> NativeImage

    type [<AllowNullLiteral>] Net =
        inherit EventEmitter
        /// Creates a ClientRequest instance using the provided options which are directly
        /// forwarded to the ClientRequest constructor. The net.request method would be used
        /// to issue both secure and insecure HTTP requests according to the specified
        /// protocol scheme in the options object.
        abstract request: options: U2<obj option, string> -> ClientRequest

    type [<AllowNullLiteral>] Notification =
        inherit EventEmitter
        [<Emit "$0.on('action',$1)">] abstract on_action: listener: (Event -> float -> unit) -> Notification
        [<Emit "$0.once('action',$1)">] abstract once_action: listener: (Event -> float -> unit) -> Notification
        [<Emit "$0.addListener('action',$1)">] abstract addListener_action: listener: (Event -> float -> unit) -> Notification
        [<Emit "$0.removeListener('action',$1)">] abstract removeListener_action: listener: (Event -> float -> unit) -> Notification
        /// Emitted when the notification is clicked by the user.
        [<Emit "$0.on('click',$1)">] abstract on_click: listener: (Event -> unit) -> Notification
        [<Emit "$0.once('click',$1)">] abstract once_click: listener: (Event -> unit) -> Notification
        [<Emit "$0.addListener('click',$1)">] abstract addListener_click: listener: (Event -> unit) -> Notification
        [<Emit "$0.removeListener('click',$1)">] abstract removeListener_click: listener: (Event -> unit) -> Notification
        /// Emitted when the notification is closed by manual intervention from the user.
        /// This event is not guaranteed to be emitted in all cases where the notification
        /// is closed.
        [<Emit "$0.on('close',$1)">] abstract on_close: listener: (Event -> unit) -> Notification
        [<Emit "$0.once('close',$1)">] abstract once_close: listener: (Event -> unit) -> Notification
        [<Emit "$0.addListener('close',$1)">] abstract addListener_close: listener: (Event -> unit) -> Notification
        [<Emit "$0.removeListener('close',$1)">] abstract removeListener_close: listener: (Event -> unit) -> Notification
        /// Emitted when the user clicks the "Reply" button on a notification with hasReply:
        /// true.
        [<Emit "$0.on('reply',$1)">] abstract on_reply: listener: (Event -> string -> unit) -> Notification
        [<Emit "$0.once('reply',$1)">] abstract once_reply: listener: (Event -> string -> unit) -> Notification
        [<Emit "$0.addListener('reply',$1)">] abstract addListener_reply: listener: (Event -> string -> unit) -> Notification
        [<Emit "$0.removeListener('reply',$1)">] abstract removeListener_reply: listener: (Event -> string -> unit) -> Notification
        /// Emitted when the notification is shown to the user, note this could be fired
        /// multiple times as a notification can be shown multiple times through the show()
        /// method.
        [<Emit "$0.on('show',$1)">] abstract on_show: listener: (Event -> unit) -> Notification
        [<Emit "$0.once('show',$1)">] abstract once_show: listener: (Event -> unit) -> Notification
        [<Emit "$0.addListener('show',$1)">] abstract addListener_show: listener: (Event -> unit) -> Notification
        [<Emit "$0.removeListener('show',$1)">] abstract removeListener_show: listener: (Event -> unit) -> Notification
        /// Dismisses the notification.
        abstract close: unit -> unit
        /// Immediately shows the notification to the user, please note this means unlike
        /// the HTML5 Notification implementation, simply instantiating a new Notification
        /// does not immediately show it to the user, you need to call this method before
        /// the OS will display it. If the notification has been shown before, this method
        /// will dismiss the previously shown notification and create a new one with
        /// identical properties.
        abstract show: unit -> unit

    type [<AllowNullLiteral>] NotificationStatic =
        [<Emit "new $0($1...)">] abstract Create: options: NotificationConstructorOptions -> Notification
        abstract isSupported: unit -> bool

    type [<AllowNullLiteral>] NotificationAction =
        /// The label for the given action.
        abstract text: string option with get, set
        /// The type of action, can be button.
        abstract ``type``: string with get, set

    type [<AllowNullLiteral>] Point =
        abstract x: float with get, set
        abstract y: float with get, set

    type [<AllowNullLiteral>] PowerMonitor =
        inherit EventEmitter
        /// Emitted when the system changes to AC power.
        [<Emit "$0.on('on-ac',$1)">] abstract ``on_on-ac``: listener: Function -> PowerMonitor
        [<Emit "$0.once('on-ac',$1)">] abstract ``once_on-ac``: listener: Function -> PowerMonitor
        [<Emit "$0.addListener('on-ac',$1)">] abstract ``addListener_on-ac``: listener: Function -> PowerMonitor
        [<Emit "$0.removeListener('on-ac',$1)">] abstract ``removeListener_on-ac``: listener: Function -> PowerMonitor
        /// Emitted when system changes to battery power.
        [<Emit "$0.on('on-battery',$1)">] abstract ``on_on-battery``: listener: Function -> PowerMonitor
        [<Emit "$0.once('on-battery',$1)">] abstract ``once_on-battery``: listener: Function -> PowerMonitor
        [<Emit "$0.addListener('on-battery',$1)">] abstract ``addListener_on-battery``: listener: Function -> PowerMonitor
        [<Emit "$0.removeListener('on-battery',$1)">] abstract ``removeListener_on-battery``: listener: Function -> PowerMonitor
        /// Emitted when system is resuming.
        [<Emit "$0.on('resume',$1)">] abstract on_resume: listener: Function -> PowerMonitor
        [<Emit "$0.once('resume',$1)">] abstract once_resume: listener: Function -> PowerMonitor
        [<Emit "$0.addListener('resume',$1)">] abstract addListener_resume: listener: Function -> PowerMonitor
        [<Emit "$0.removeListener('resume',$1)">] abstract removeListener_resume: listener: Function -> PowerMonitor
        /// Emitted when the system is suspending.
        [<Emit "$0.on('suspend',$1)">] abstract on_suspend: listener: Function -> PowerMonitor
        [<Emit "$0.once('suspend',$1)">] abstract once_suspend: listener: Function -> PowerMonitor
        [<Emit "$0.addListener('suspend',$1)">] abstract addListener_suspend: listener: Function -> PowerMonitor
        [<Emit "$0.removeListener('suspend',$1)">] abstract removeListener_suspend: listener: Function -> PowerMonitor

    type [<AllowNullLiteral>] PowerSaveBlocker =
        inherit EventEmitter
        abstract isStarted: id: float -> bool
        /// Starts preventing the system from entering lower-power mode. Returns an integer
        /// identifying the power save blocker. Note: prevent-display-sleep has higher
        /// precedence over prevent-app-suspension. Only the highest precedence type takes
        /// effect. In other words, prevent-display-sleep always takes precedence over
        /// prevent-app-suspension. For example, an API calling A requests for
        /// prevent-app-suspension, and another calling B requests for
        /// prevent-display-sleep. prevent-display-sleep will be used until B stops its
        /// request. After that, prevent-app-suspension is used.
        abstract start: ``type``: U2<string, string> -> float
        /// Stops the specified power save blocker.
        abstract stop: id: float -> unit

    type [<AllowNullLiteral>] PrinterInfo =
        abstract description: string with get, set
        abstract isDefault: bool with get, set
        abstract name: string with get, set
        abstract status: float with get, set

    type [<AllowNullLiteral>] ProcessMetric =
        /// CPU usage of the process.
        abstract cpu: CPUUsage with get, set
        /// Memory information for the process.
        abstract memory: MemoryInfo with get, set
        /// Process id of the process.
        abstract pid: float with get, set
        /// Process type (Browser or Tab or GPU etc).
        abstract ``type``: string with get, set

    type [<AllowNullLiteral>] Protocol =
        inherit EventEmitter
        /// Intercepts scheme protocol and uses handler as the protocol's new handler which
        /// sends a Buffer as a response.
        abstract interceptBufferProtocol: scheme: string * handler: (InterceptBufferProtocolRequest -> (Buffer -> unit) -> unit) * ?completion: (Error -> unit) -> unit
        /// Intercepts scheme protocol and uses handler as the protocol's new handler which
        /// sends a file as a response.
        abstract interceptFileProtocol: scheme: string * handler: (InterceptFileProtocolRequest -> (string -> unit) -> unit) * ?completion: (Error -> unit) -> unit
        /// Intercepts scheme protocol and uses handler as the protocol's new handler which
        /// sends a new HTTP request as a response.
        abstract interceptHttpProtocol: scheme: string * handler: (InterceptHttpProtocolRequest -> (RedirectRequest -> unit) -> unit) * ?completion: (Error -> unit) -> unit
        /// Same as protocol.registerStreamProtocol, except that it replaces an existing
        /// protocol handler.
        abstract interceptStreamProtocol: scheme: string * handler: (InterceptStreamProtocolRequest -> (U2<ReadableStream, StreamProtocolResponse> -> unit) -> unit) * ?completion: (Error -> unit) -> unit
        /// Intercepts scheme protocol and uses handler as the protocol's new handler which
        /// sends a String as a response.
        abstract interceptStringProtocol: scheme: string * handler: (InterceptStringProtocolRequest -> (string -> unit) -> unit) * ?completion: (Error -> unit) -> unit
        /// The callback will be called with a boolean that indicates whether there is
        /// already a handler for scheme.
        abstract isProtocolHandled: scheme: string * callback: (Error -> unit) -> unit
        /// Registers a protocol of scheme that will send a Buffer as a response. The usage
        /// is the same with registerFileProtocol, except that the callback should be called
        /// with either a Buffer object or an object that has the data, mimeType, and
        /// charset properties. Example:
        abstract registerBufferProtocol: scheme: string * handler: (RegisterBufferProtocolRequest -> (U2<Buffer, MimeTypedBuffer> -> unit) -> unit) * ?completion: (Error -> unit) -> unit
        /// Registers a protocol of scheme that will send the file as a response. The
        /// handler will be called with handler(request, callback) when a request is going
        /// to be created with scheme. completion will be called with completion(null) when
        /// scheme is successfully registered or completion(error) when failed. To handle
        /// the request, the callback should be called with either the file's path or an
        /// object that has a path property, e.g. callback(filePath) or callback({path:
        /// filePath}). When callback is called with nothing, a number, or an object that
        /// has an error property, the request will fail with the error number you
        /// specified. For the available error numbers you can use, please see the net error
        /// list. By default the scheme is treated like http:, which is parsed differently
        /// than protocols that follow the "generic URI syntax" like file:, so you probably
        /// want to call protocol.registerStandardSchemes to have your scheme treated as a
        /// standard scheme.
        abstract registerFileProtocol: scheme: string * handler: (RegisterFileProtocolRequest -> (string -> unit) -> unit) * ?completion: (Error -> unit) -> unit
        /// Registers a protocol of scheme that will send an HTTP request as a response. The
        /// usage is the same with registerFileProtocol, except that the callback should be
        /// called with a redirectRequest object that has the url, method, referrer,
        /// uploadData and session properties. By default the HTTP request will reuse the
        /// current session. If you want the request to have a different session you should
        /// set session to null. For POST requests the uploadData object must be provided.
        abstract registerHttpProtocol: scheme: string * handler: (RegisterHttpProtocolRequest -> (RedirectRequest -> unit) -> unit) * ?completion: (Error -> unit) -> unit
        abstract registerServiceWorkerSchemes: schemes: ResizeArray<string> -> unit
        /// A standard scheme adheres to what RFC 3986 calls generic URI syntax. For example
        /// http and https are standard schemes, while file is not. Registering a scheme as
        /// standard, will allow relative and absolute resources to be resolved correctly
        /// when served. Otherwise the scheme will behave like the file protocol, but
        /// without the ability to resolve relative URLs. For example when you load
        /// following page with custom protocol without registering it as standard scheme,
        /// the image will not be loaded because non-standard schemes can not recognize
        /// relative URLs: Registering a scheme as standard will allow access to files
        /// through the FileSystem API. Otherwise the renderer will throw a security error
        /// for the scheme. By default web storage apis (localStorage, sessionStorage,
        /// webSQL, indexedDB, cookies) are disabled for non standard schemes. So in general
        /// if you want to register a custom protocol to replace the http protocol, you have
        /// to register it as a standard scheme: Note: This method can only be used before
        /// the ready event of the app module gets emitted.
        abstract registerStandardSchemes: schemes: ResizeArray<string> * ?options: RegisterStandardSchemesOptions -> unit
        /// Registers a protocol of scheme that will send a Readable as a response. The
        /// usage is similar to the other register{Any}Protocol, except that the callback
        /// should be called with either a Readable object or an object that has the data,
        /// statusCode, and headers properties. Example: It is possible to pass any object
        /// that implements the readable stream API (emits data/end/error events). For
        /// example, here's how a file could be returned:
        abstract registerStreamProtocol: scheme: string * handler: (RegisterStreamProtocolRequest -> (U2<ReadableStream, StreamProtocolResponse> -> unit) -> unit) * ?completion: (Error -> unit) -> unit
        /// Registers a protocol of scheme that will send a String as a response. The usage
        /// is the same with registerFileProtocol, except that the callback should be called
        /// with either a String or an object that has the data, mimeType, and charset
        /// properties.
        abstract registerStringProtocol: scheme: string * handler: (RegisterStringProtocolRequest -> (string -> unit) -> unit) * ?completion: (Error -> unit) -> unit
        /// Remove the interceptor installed for scheme and restore its original handler.
        abstract uninterceptProtocol: scheme: string * ?completion: (Error -> unit) -> unit
        /// Unregisters the custom protocol of scheme.
        abstract unregisterProtocol: scheme: string * ?completion: (Error -> unit) -> unit

    type [<AllowNullLiteral>] Rectangle =
        /// The height of the rectangle (must be an integer)
        abstract height: float with get, set
        /// The width of the rectangle (must be an integer)
        abstract width: float with get, set
        /// The x coordinate of the origin of the rectangle (must be an integer)
        abstract x: float with get, set
        /// The y coordinate of the origin of the rectangle (must be an integer)
        abstract y: float with get, set

    type [<AllowNullLiteral>] Remote =
        inherit MainInterface
        abstract getCurrentWebContents: unit -> WebContents
        abstract getCurrentWindow: unit -> BrowserWindow
        abstract getGlobal: name: string -> obj option
        /// e.g.
        abstract require: ``module``: string -> obj option
        /// The process object in the main process. This is the same as
        /// remote.getGlobal('process') but is cached.
        abstract ``process``: obj option with get, set

    type [<AllowNullLiteral>] RemoveClientCertificate =
        /// Origin of the server whose associated client certificate must be removed from
        /// the cache.
        abstract origin: string with get, set
        /// clientCertificate.
        abstract ``type``: string with get, set

    type [<AllowNullLiteral>] RemovePassword =
        /// When provided, the authentication info related to the origin will only be
        /// removed otherwise the entire cache will be cleared.
        abstract origin: string option with get, set
        /// Credentials of the authentication. Must be provided if removing by origin.
        abstract password: string option with get, set
        /// Realm of the authentication. Must be provided if removing by origin.
        abstract realm: string option with get, set
        /// Scheme of the authentication. Can be basic, digest, ntlm, negotiate. Must be
        /// provided if removing by origin.
        abstract scheme: U4<string, string, string, string> option with get, set
        /// password.
        abstract ``type``: string with get, set
        /// Credentials of the authentication. Must be provided if removing by origin.
        abstract username: string option with get, set

    type [<AllowNullLiteral>] Screen =
        inherit EventEmitter
        /// Emitted when newDisplay has been added.
        [<Emit "$0.on('display-added',$1)">] abstract ``on_display-added``: listener: (Event -> Display -> unit) -> Screen
        [<Emit "$0.once('display-added',$1)">] abstract ``once_display-added``: listener: (Event -> Display -> unit) -> Screen
        [<Emit "$0.addListener('display-added',$1)">] abstract ``addListener_display-added``: listener: (Event -> Display -> unit) -> Screen
        [<Emit "$0.removeListener('display-added',$1)">] abstract ``removeListener_display-added``: listener: (Event -> Display -> unit) -> Screen
        /// Emitted when one or more metrics change in a display. The changedMetrics is an
        /// array of strings that describe the changes. Possible changes are bounds,
        /// workArea, scaleFactor and rotation.
        [<Emit "$0.on('display-metrics-changed',$1)">] abstract ``on_display-metrics-changed``: listener: (Event -> Display -> ResizeArray<string> -> unit) -> Screen
        [<Emit "$0.once('display-metrics-changed',$1)">] abstract ``once_display-metrics-changed``: listener: (Event -> Display -> ResizeArray<string> -> unit) -> Screen
        [<Emit "$0.addListener('display-metrics-changed',$1)">] abstract ``addListener_display-metrics-changed``: listener: (Event -> Display -> ResizeArray<string> -> unit) -> Screen
        [<Emit "$0.removeListener('display-metrics-changed',$1)">] abstract ``removeListener_display-metrics-changed``: listener: (Event -> Display -> ResizeArray<string> -> unit) -> Screen
        /// Emitted when oldDisplay has been removed.
        [<Emit "$0.on('display-removed',$1)">] abstract ``on_display-removed``: listener: (Event -> Display -> unit) -> Screen
        [<Emit "$0.once('display-removed',$1)">] abstract ``once_display-removed``: listener: (Event -> Display -> unit) -> Screen
        [<Emit "$0.addListener('display-removed',$1)">] abstract ``addListener_display-removed``: listener: (Event -> Display -> unit) -> Screen
        [<Emit "$0.removeListener('display-removed',$1)">] abstract ``removeListener_display-removed``: listener: (Event -> Display -> unit) -> Screen
        abstract getAllDisplays: unit -> ResizeArray<Display>
        /// The current absolute position of the mouse pointer.
        abstract getCursorScreenPoint: unit -> Point
        abstract getDisplayMatching: rect: Rectangle -> Display
        abstract getDisplayNearestPoint: point: Point -> Display
        abstract getMenuBarHeight: unit -> float
        abstract getPrimaryDisplay: unit -> Display

    type [<AllowNullLiteral>] ScrubberItem =
        /// The image to appear in this item
        abstract icon: NativeImage option with get, set
        /// The text to appear in this item
        abstract label: string option with get, set

    type [<AllowNullLiteral>] SegmentedControlSegment =
        /// Whether this segment is selectable. Default: true
        abstract enabled: bool option with get, set
        /// The image to appear in this segment
        abstract icon: NativeImage option with get, set
        /// The text to appear in this segment
        abstract label: string option with get, set

    type [<AllowNullLiteral>] Session =
        inherit EventEmitter
        /// A Session object, the default session object of the app.
        abstract defaultSession: Session option with get, set
        /// Emitted when Electron is about to download item in webContents. Calling
        /// event.preventDefault() will cancel the download and item will not be available
        /// from next tick of the process.
        [<Emit "$0.on('will-download',$1)">] abstract ``on_will-download``: listener: (Event -> DownloadItem -> WebContents -> unit) -> Session
        [<Emit "$0.once('will-download',$1)">] abstract ``once_will-download``: listener: (Event -> DownloadItem -> WebContents -> unit) -> Session
        [<Emit "$0.addListener('will-download',$1)">] abstract ``addListener_will-download``: listener: (Event -> DownloadItem -> WebContents -> unit) -> Session
        [<Emit "$0.removeListener('will-download',$1)">] abstract ``removeListener_will-download``: listener: (Event -> DownloadItem -> WebContents -> unit) -> Session
        /// Dynamically sets whether to always send credentials for HTTP NTLM or Negotiate
        /// authentication.
        abstract allowNTLMCredentialsForDomains: domains: string -> unit
        /// Clears the session’s HTTP authentication cache.
        abstract clearAuthCache: options: U2<RemovePassword, RemoveClientCertificate> * ?callback: Function -> unit
        /// Clears the session’s HTTP cache.
        abstract clearCache: callback: Function -> unit
        /// Clears the host resolver cache.
        abstract clearHostResolverCache: ?callback: Function -> unit
        /// Clears the data of web storages.
        abstract clearStorageData: ?options: ClearStorageDataOptions * ?callback: Function -> unit
        /// Allows resuming cancelled or interrupted downloads from previous Session. The
        /// API will generate a DownloadItem that can be accessed with the will-download
        /// event. The DownloadItem will not have any WebContents associated with it and the
        /// initial state will be interrupted. The download will start only when the resume
        /// API is called on the DownloadItem.
        abstract createInterruptedDownload: options: CreateInterruptedDownloadOptions -> unit
        /// Disables any network emulation already active for the session. Resets to the
        /// original network configuration.
        abstract disableNetworkEmulation: unit -> unit
        /// Emulates network with the given configuration for the session.
        abstract enableNetworkEmulation: options: EnableNetworkEmulationOptions -> unit
        /// Writes any unwritten DOMStorage data to disk.
        abstract flushStorageData: unit -> unit
        abstract getBlobData: identifier: string * callback: (Buffer -> unit) -> Blob
        /// Callback is invoked with the session's current cache size.
        abstract getCacheSize: callback: (float -> unit) -> unit
        abstract getUserAgent: unit -> string
        /// Resolves the proxy information for url. The callback will be called with
        /// callback(proxy) when the request is performed.
        abstract resolveProxy: url: string * callback: (string -> unit) -> unit
        /// Sets the certificate verify proc for session, the proc will be called with
        /// proc(request, callback) whenever a server certificate verification is requested.
        /// Calling callback(0) accepts the certificate, calling callback(-2) rejects it.
        /// Calling setCertificateVerifyProc(null) will revert back to default certificate
        /// verify proc.
        abstract setCertificateVerifyProc: proc: (CertificateVerifyProcRequest -> (float -> unit) -> unit) -> unit
        /// Sets download saving directory. By default, the download directory will be the
        /// Downloads under the respective app folder.
        abstract setDownloadPath: path: string -> unit
        /// Sets the handler which can be used to respond to permission requests for the
        /// session. Calling callback(true) will allow the permission and callback(false)
        /// will reject it. To clear the handler, call setPermissionRequestHandler(null).
        abstract setPermissionRequestHandler: handler: (WebContents -> string -> (bool -> unit) -> unit option) -> unit
        /// Sets the proxy settings. When pacScript and proxyRules are provided together,
        /// the proxyRules option is ignored and pacScript configuration is applied. The
        /// proxyRules has to follow the rules below: For example: The proxyBypassRules is a
        /// comma separated list of rules described below:
        abstract setProxy: config: Config * callback: Function -> unit
        /// Overrides the userAgent and acceptLanguages for this session. The
        /// acceptLanguages must a comma separated ordered list of language codes, for
        /// example "en-US,fr,de,ko,zh-CN,ja". This doesn't affect existing WebContents, and
        /// each WebContents can use webContents.setUserAgent to override the session-wide
        /// user agent.
        abstract setUserAgent: userAgent: string * ?acceptLanguages: string -> unit
        abstract cookies: Cookies with get, set
        abstract protocol: Protocol with get, set
        abstract webRequest: WebRequest with get, set

    type [<AllowNullLiteral>] SessionStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> Session
        /// If partition starts with persist:, the page will use a persistent session
        /// available to all pages in the app with the same partition. if there is no
        /// persist: prefix, the page will use an in-memory session. If the partition is
        /// empty then default session of the app will be returned. To create a Session with
        /// options, you have to ensure the Session with the partition has never been used
        /// before. There is no way to change the options of an existing Session object.
        abstract fromPartition: partition: string * ?options: FromPartitionOptions -> Session

    type [<AllowNullLiteral>] Shell =
        /// Play the beep sound.
        abstract beep: unit -> unit
        /// Move the given file to trash and returns a boolean status for the operation.
        abstract moveItemToTrash: fullPath: string -> bool
        /// Open the given external protocol URL in the desktop's default manner. (For
        /// example, mailto: URLs in the user's default mail agent).
        abstract openExternal: url: string * ?options: OpenExternalOptions * ?callback: (Error -> unit) -> bool
        /// Open the given file in the desktop's default manner.
        abstract openItem: fullPath: string -> bool
        /// Resolves the shortcut link at shortcutPath. An exception will be thrown when any
        /// error happens.
        abstract readShortcutLink: shortcutPath: string -> ShortcutDetails
        /// Show the given file in a file manager. If possible, select the file.
        abstract showItemInFolder: fullPath: string -> bool
        /// Creates or updates a shortcut link at shortcutPath.
        abstract writeShortcutLink: shortcutPath: string * operation: U3<string, string, string> * options: ShortcutDetails -> bool
        /// Creates or updates a shortcut link at shortcutPath.
        abstract writeShortcutLink: shortcutPath: string * options: ShortcutDetails -> bool

    type [<AllowNullLiteral>] ShortcutDetails =
        /// The Application User Model ID. Default is empty.
        abstract appUserModelId: string option with get, set
        /// The arguments to be applied to target when launching from this shortcut. Default
        /// is empty.
        abstract args: string option with get, set
        /// The working directory. Default is empty.
        abstract cwd: string option with get, set
        /// The description of the shortcut. Default is empty.
        abstract description: string option with get, set
        /// The path to the icon, can be a DLL or EXE. icon and iconIndex have to be set
        /// together. Default is empty, which uses the target's icon.
        abstract icon: string option with get, set
        /// The resource ID of icon when icon is a DLL or EXE. Default is 0.
        abstract iconIndex: float option with get, set
        /// The target to launch from this shortcut.
        abstract target: string with get, set

    type [<AllowNullLiteral>] Size =
        abstract height: float with get, set
        abstract width: float with get, set

    type [<AllowNullLiteral>] StreamProtocolResponse =
        /// A Node.js readable stream representing the response body
        abstract data: ReadableStream with get, set
        /// An object containing the response headers
        abstract headers: Headers with get, set
        /// The HTTP response code
        abstract statusCode: float with get, set

    type [<AllowNullLiteral>] SystemPreferences =
        inherit EventEmitter
        [<Emit "$0.on('accent-color-changed',$1)">] abstract ``on_accent-color-changed``: listener: (Event -> string -> unit) -> SystemPreferences
        [<Emit "$0.once('accent-color-changed',$1)">] abstract ``once_accent-color-changed``: listener: (Event -> string -> unit) -> SystemPreferences
        [<Emit "$0.addListener('accent-color-changed',$1)">] abstract ``addListener_accent-color-changed``: listener: (Event -> string -> unit) -> SystemPreferences
        [<Emit "$0.removeListener('accent-color-changed',$1)">] abstract ``removeListener_accent-color-changed``: listener: (Event -> string -> unit) -> SystemPreferences
        [<Emit "$0.on('color-changed',$1)">] abstract ``on_color-changed``: listener: (Event -> unit) -> SystemPreferences
        [<Emit "$0.once('color-changed',$1)">] abstract ``once_color-changed``: listener: (Event -> unit) -> SystemPreferences
        [<Emit "$0.addListener('color-changed',$1)">] abstract ``addListener_color-changed``: listener: (Event -> unit) -> SystemPreferences
        [<Emit "$0.removeListener('color-changed',$1)">] abstract ``removeListener_color-changed``: listener: (Event -> unit) -> SystemPreferences
        [<Emit "$0.on('inverted-color-scheme-changed',$1)">] abstract ``on_inverted-color-scheme-changed``: listener: (Event -> bool -> unit) -> SystemPreferences
        [<Emit "$0.once('inverted-color-scheme-changed',$1)">] abstract ``once_inverted-color-scheme-changed``: listener: (Event -> bool -> unit) -> SystemPreferences
        [<Emit "$0.addListener('inverted-color-scheme-changed',$1)">] abstract ``addListener_inverted-color-scheme-changed``: listener: (Event -> bool -> unit) -> SystemPreferences
        [<Emit "$0.removeListener('inverted-color-scheme-changed',$1)">] abstract ``removeListener_inverted-color-scheme-changed``: listener: (Event -> bool -> unit) -> SystemPreferences
        abstract getAccentColor: unit -> string
        abstract getColor: color: obj -> string
        /// Some popular key and types are:
        abstract getUserDefault: key: string * ``type``: U8<string, string, string, string, string, string, string, string> -> obj option
        /// An example of using it to determine if you should create a transparent window or
        /// not (transparent windows won't work correctly when DWM composition is disabled):
        abstract isAeroGlassEnabled: unit -> bool
        abstract isDarkMode: unit -> bool
        abstract isInvertedColorScheme: unit -> bool
        abstract isSwipeTrackingFromScrollEventsEnabled: unit -> bool
        /// Posts event as native notifications of macOS. The userInfo is an Object that
        /// contains the user information dictionary sent along with the notification.
        abstract postLocalNotification: ``event``: string * userInfo: obj option -> unit
        /// Posts event as native notifications of macOS. The userInfo is an Object that
        /// contains the user information dictionary sent along with the notification.
        abstract postNotification: ``event``: string * userInfo: obj option -> unit
        /// Removes the key in NSUserDefaults. This can be used to restore the default or
        /// global value of a key previously set with setUserDefault.
        abstract removeUserDefault: key: string -> unit
        /// Set the value of key in NSUserDefaults. Note that type should match actual type
        /// of value. An exception is thrown if they don't. Some popular key and types are:
        abstract setUserDefault: key: string * ``type``: string * value: string -> unit
        /// Same as subscribeNotification, but uses NSNotificationCenter for local defaults.
        /// This is necessary for events such as NSUserDefaultsDidChangeNotification
        abstract subscribeLocalNotification: ``event``: string * callback: (string -> obj option -> unit) -> unit
        /// Subscribes to native notifications of macOS, callback will be called with
        /// callback(event, userInfo) when the corresponding event happens. The userInfo is
        /// an Object that contains the user information dictionary sent along with the
        /// notification. The id of the subscriber is returned, which can be used to
        /// unsubscribe the event. Under the hood this API subscribes to
        /// NSDistributedNotificationCenter, example values of event are:
        abstract subscribeNotification: ``event``: string * callback: (string -> obj option -> unit) -> unit
        /// Same as unsubscribeNotification, but removes the subscriber from
        /// NSNotificationCenter.
        abstract unsubscribeLocalNotification: id: float -> unit
        /// Removes the subscriber with id.
        abstract unsubscribeNotification: id: float -> unit

    type [<AllowNullLiteral>] Task =
        /// The command line arguments when program is executed.
        abstract arguments: string with get, set
        /// Description of this task.
        abstract description: string with get, set
        /// The icon index in the icon file. If an icon file consists of two or more icons,
        /// set this value to identify the icon. If an icon file consists of one icon, this
        /// value is 0.
        abstract iconIndex: float with get, set
        /// The absolute path to an icon to be displayed in a JumpList, which can be an
        /// arbitrary resource file that contains an icon. You can usually specify
        /// process.execPath to show the icon of the program.
        abstract iconPath: string with get, set
        /// Path of the program to execute, usually you should specify process.execPath
        /// which opens the current program.
        abstract program: string with get, set
        /// The string to be displayed in a JumpList.
        abstract title: string with get, set

    type [<AllowNullLiteral>] ThumbarButton =
        abstract click: Function with get, set
        /// Control specific states and behaviors of the button. By default, it is
        /// ['enabled'].
        abstract flags: ResizeArray<string> option with get, set
        /// The icon showing in thumbnail toolbar.
        abstract icon: NativeImage with get, set
        /// The text of the button's tooltip.
        abstract tooltip: string option with get, set

    type [<AllowNullLiteral>] TouchBarButton =
        inherit EventEmitter
        abstract backgroundColor: string with get, set
        abstract icon: NativeImage with get, set
        abstract label: string with get, set

    type [<AllowNullLiteral>] TouchBarButtonStatic =
        [<Emit "new $0($1...)">] abstract Create: options: TouchBarButtonConstructorOptions -> TouchBarButton

    type [<AllowNullLiteral>] TouchBarColorPicker =
        inherit EventEmitter
        abstract availableColors: ResizeArray<string> with get, set
        abstract selectedColor: string with get, set

    type [<AllowNullLiteral>] TouchBarColorPickerStatic =
        [<Emit "new $0($1...)">] abstract Create: options: TouchBarColorPickerConstructorOptions -> TouchBarColorPicker

    type [<AllowNullLiteral>] TouchBarGroup =
        inherit EventEmitter

    type [<AllowNullLiteral>] TouchBarGroupStatic =
        [<Emit "new $0($1...)">] abstract Create: options: TouchBarGroupConstructorOptions -> TouchBarGroup

    type [<AllowNullLiteral>] TouchBarLabel =
        inherit EventEmitter
        abstract label: string with get, set
        abstract textColor: string with get, set

    type [<AllowNullLiteral>] TouchBarLabelStatic =
        [<Emit "new $0($1...)">] abstract Create: options: TouchBarLabelConstructorOptions -> TouchBarLabel

    type [<AllowNullLiteral>] TouchBarPopover =
        inherit EventEmitter
        abstract icon: NativeImage with get, set
        abstract label: string with get, set

    type [<AllowNullLiteral>] TouchBarPopoverStatic =
        [<Emit "new $0($1...)">] abstract Create: options: TouchBarPopoverConstructorOptions -> TouchBarPopover

    type [<AllowNullLiteral>] TouchBarScrubber =
        inherit EventEmitter
        abstract continuous: bool with get, set
        abstract items: ResizeArray<ScrubberItem> with get, set
        abstract mode: string with get, set
        abstract overlayStyle: string with get, set
        abstract selectedStyle: string with get, set
        abstract showArrowButtons: bool with get, set

    type [<AllowNullLiteral>] TouchBarScrubberStatic =
        [<Emit "new $0($1...)">] abstract Create: options: TouchBarScrubberConstructorOptions -> TouchBarScrubber

    type [<AllowNullLiteral>] TouchBarSegmentedControl =
        inherit EventEmitter
        abstract segments: ResizeArray<SegmentedControlSegment> with get, set
        abstract segmentStyle: string with get, set
        abstract selectedIndex: float with get, set

    type [<AllowNullLiteral>] TouchBarSegmentedControlStatic =
        [<Emit "new $0($1...)">] abstract Create: options: TouchBarSegmentedControlConstructorOptions -> TouchBarSegmentedControl

    type [<AllowNullLiteral>] TouchBarSlider =
        inherit EventEmitter
        abstract label: string with get, set
        abstract maxValue: float with get, set
        abstract minValue: float with get, set
        abstract value: float with get, set

    type [<AllowNullLiteral>] TouchBarSliderStatic =
        [<Emit "new $0($1...)">] abstract Create: options: TouchBarSliderConstructorOptions -> TouchBarSlider

    type [<AllowNullLiteral>] TouchBarSpacer =
        inherit EventEmitter

    type [<AllowNullLiteral>] TouchBarSpacerStatic =
        [<Emit "new $0($1...)">] abstract Create: options: TouchBarSpacerConstructorOptions -> TouchBarSpacer

    type [<AllowNullLiteral>] TouchBar =
        inherit EventEmitter
        abstract escapeItem: obj option with get, set
        abstract TouchBarButton: obj with get, set
        abstract TouchBarColorPicker: obj with get, set
        abstract TouchBarGroup: obj with get, set
        abstract TouchBarLabel: obj with get, set
        abstract TouchBarPopover: obj with get, set
        abstract TouchBarScrubber: obj with get, set
        abstract TouchBarSegmentedControl: obj with get, set
        abstract TouchBarSlider: obj with get, set
        abstract TouchBarSpacer: obj with get, set

    type [<AllowNullLiteral>] TouchBarStatic =
        [<Emit "new $0($1...)">] abstract Create: options: TouchBarConstructorOptions -> TouchBar

    type [<AllowNullLiteral>] Tray =
        inherit EventEmitter
        /// Emitted when the tray balloon is clicked.
        [<Emit "$0.on('balloon-click',$1)">] abstract ``on_balloon-click``: listener: Function -> Tray
        [<Emit "$0.once('balloon-click',$1)">] abstract ``once_balloon-click``: listener: Function -> Tray
        [<Emit "$0.addListener('balloon-click',$1)">] abstract ``addListener_balloon-click``: listener: Function -> Tray
        [<Emit "$0.removeListener('balloon-click',$1)">] abstract ``removeListener_balloon-click``: listener: Function -> Tray
        /// Emitted when the tray balloon is closed because of timeout or user manually
        /// closes it.
        [<Emit "$0.on('balloon-closed',$1)">] abstract ``on_balloon-closed``: listener: Function -> Tray
        [<Emit "$0.once('balloon-closed',$1)">] abstract ``once_balloon-closed``: listener: Function -> Tray
        [<Emit "$0.addListener('balloon-closed',$1)">] abstract ``addListener_balloon-closed``: listener: Function -> Tray
        [<Emit "$0.removeListener('balloon-closed',$1)">] abstract ``removeListener_balloon-closed``: listener: Function -> Tray
        /// Emitted when the tray balloon shows.
        [<Emit "$0.on('balloon-show',$1)">] abstract ``on_balloon-show``: listener: Function -> Tray
        [<Emit "$0.once('balloon-show',$1)">] abstract ``once_balloon-show``: listener: Function -> Tray
        [<Emit "$0.addListener('balloon-show',$1)">] abstract ``addListener_balloon-show``: listener: Function -> Tray
        [<Emit "$0.removeListener('balloon-show',$1)">] abstract ``removeListener_balloon-show``: listener: Function -> Tray
        /// Emitted when the tray icon is clicked.
        [<Emit "$0.on('click',$1)">] abstract on_click: listener: (Event -> Rectangle -> Point -> unit) -> Tray
        [<Emit "$0.once('click',$1)">] abstract once_click: listener: (Event -> Rectangle -> Point -> unit) -> Tray
        [<Emit "$0.addListener('click',$1)">] abstract addListener_click: listener: (Event -> Rectangle -> Point -> unit) -> Tray
        [<Emit "$0.removeListener('click',$1)">] abstract removeListener_click: listener: (Event -> Rectangle -> Point -> unit) -> Tray
        /// Emitted when the tray icon is double clicked.
        [<Emit "$0.on('double-click',$1)">] abstract ``on_double-click``: listener: (Event -> Rectangle -> unit) -> Tray
        [<Emit "$0.once('double-click',$1)">] abstract ``once_double-click``: listener: (Event -> Rectangle -> unit) -> Tray
        [<Emit "$0.addListener('double-click',$1)">] abstract ``addListener_double-click``: listener: (Event -> Rectangle -> unit) -> Tray
        [<Emit "$0.removeListener('double-click',$1)">] abstract ``removeListener_double-click``: listener: (Event -> Rectangle -> unit) -> Tray
        /// Emitted when a drag operation ends on the tray or ends at another location.
        [<Emit "$0.on('drag-end',$1)">] abstract ``on_drag-end``: listener: Function -> Tray
        [<Emit "$0.once('drag-end',$1)">] abstract ``once_drag-end``: listener: Function -> Tray
        [<Emit "$0.addListener('drag-end',$1)">] abstract ``addListener_drag-end``: listener: Function -> Tray
        [<Emit "$0.removeListener('drag-end',$1)">] abstract ``removeListener_drag-end``: listener: Function -> Tray
        /// Emitted when a drag operation enters the tray icon.
        [<Emit "$0.on('drag-enter',$1)">] abstract ``on_drag-enter``: listener: Function -> Tray
        [<Emit "$0.once('drag-enter',$1)">] abstract ``once_drag-enter``: listener: Function -> Tray
        [<Emit "$0.addListener('drag-enter',$1)">] abstract ``addListener_drag-enter``: listener: Function -> Tray
        [<Emit "$0.removeListener('drag-enter',$1)">] abstract ``removeListener_drag-enter``: listener: Function -> Tray
        /// Emitted when a drag operation exits the tray icon.
        [<Emit "$0.on('drag-leave',$1)">] abstract ``on_drag-leave``: listener: Function -> Tray
        [<Emit "$0.once('drag-leave',$1)">] abstract ``once_drag-leave``: listener: Function -> Tray
        [<Emit "$0.addListener('drag-leave',$1)">] abstract ``addListener_drag-leave``: listener: Function -> Tray
        [<Emit "$0.removeListener('drag-leave',$1)">] abstract ``removeListener_drag-leave``: listener: Function -> Tray
        /// Emitted when any dragged items are dropped on the tray icon.
        [<Emit "$0.on('drop',$1)">] abstract on_drop: listener: Function -> Tray
        [<Emit "$0.once('drop',$1)">] abstract once_drop: listener: Function -> Tray
        [<Emit "$0.addListener('drop',$1)">] abstract addListener_drop: listener: Function -> Tray
        [<Emit "$0.removeListener('drop',$1)">] abstract removeListener_drop: listener: Function -> Tray
        /// Emitted when dragged files are dropped in the tray icon.
        [<Emit "$0.on('drop-files',$1)">] abstract ``on_drop-files``: listener: (Event -> ResizeArray<string> -> unit) -> Tray
        [<Emit "$0.once('drop-files',$1)">] abstract ``once_drop-files``: listener: (Event -> ResizeArray<string> -> unit) -> Tray
        [<Emit "$0.addListener('drop-files',$1)">] abstract ``addListener_drop-files``: listener: (Event -> ResizeArray<string> -> unit) -> Tray
        [<Emit "$0.removeListener('drop-files',$1)">] abstract ``removeListener_drop-files``: listener: (Event -> ResizeArray<string> -> unit) -> Tray
        /// Emitted when dragged text is dropped in the tray icon.
        [<Emit "$0.on('drop-text',$1)">] abstract ``on_drop-text``: listener: (Event -> string -> unit) -> Tray
        [<Emit "$0.once('drop-text',$1)">] abstract ``once_drop-text``: listener: (Event -> string -> unit) -> Tray
        [<Emit "$0.addListener('drop-text',$1)">] abstract ``addListener_drop-text``: listener: (Event -> string -> unit) -> Tray
        [<Emit "$0.removeListener('drop-text',$1)">] abstract ``removeListener_drop-text``: listener: (Event -> string -> unit) -> Tray
        /// Emitted when the mouse enters the tray icon.
        [<Emit "$0.on('mouse-enter',$1)">] abstract ``on_mouse-enter``: listener: (Event -> Point -> unit) -> Tray
        [<Emit "$0.once('mouse-enter',$1)">] abstract ``once_mouse-enter``: listener: (Event -> Point -> unit) -> Tray
        [<Emit "$0.addListener('mouse-enter',$1)">] abstract ``addListener_mouse-enter``: listener: (Event -> Point -> unit) -> Tray
        [<Emit "$0.removeListener('mouse-enter',$1)">] abstract ``removeListener_mouse-enter``: listener: (Event -> Point -> unit) -> Tray
        /// Emitted when the mouse exits the tray icon.
        [<Emit "$0.on('mouse-leave',$1)">] abstract ``on_mouse-leave``: listener: (Event -> Point -> unit) -> Tray
        [<Emit "$0.once('mouse-leave',$1)">] abstract ``once_mouse-leave``: listener: (Event -> Point -> unit) -> Tray
        [<Emit "$0.addListener('mouse-leave',$1)">] abstract ``addListener_mouse-leave``: listener: (Event -> Point -> unit) -> Tray
        [<Emit "$0.removeListener('mouse-leave',$1)">] abstract ``removeListener_mouse-leave``: listener: (Event -> Point -> unit) -> Tray
        /// Emitted when the mouse moves in the tray icon.
        [<Emit "$0.on('mouse-move',$1)">] abstract ``on_mouse-move``: listener: (Event -> Point -> unit) -> Tray
        [<Emit "$0.once('mouse-move',$1)">] abstract ``once_mouse-move``: listener: (Event -> Point -> unit) -> Tray
        [<Emit "$0.addListener('mouse-move',$1)">] abstract ``addListener_mouse-move``: listener: (Event -> Point -> unit) -> Tray
        [<Emit "$0.removeListener('mouse-move',$1)">] abstract ``removeListener_mouse-move``: listener: (Event -> Point -> unit) -> Tray
        /// Emitted when the tray icon is right clicked.
        [<Emit "$0.on('right-click',$1)">] abstract ``on_right-click``: listener: (Event -> Rectangle -> unit) -> Tray
        [<Emit "$0.once('right-click',$1)">] abstract ``once_right-click``: listener: (Event -> Rectangle -> unit) -> Tray
        [<Emit "$0.addListener('right-click',$1)">] abstract ``addListener_right-click``: listener: (Event -> Rectangle -> unit) -> Tray
        [<Emit "$0.removeListener('right-click',$1)">] abstract ``removeListener_right-click``: listener: (Event -> Rectangle -> unit) -> Tray
        /// Destroys the tray icon immediately.
        abstract destroy: unit -> unit
        /// Displays a tray balloon.
        abstract displayBalloon: options: DisplayBalloonOptions -> unit
        /// The bounds of this tray icon as Object.
        abstract getBounds: unit -> Rectangle
        abstract isDestroyed: unit -> bool
        /// Pops up the context menu of the tray icon. When menu is passed, the menu will be
        /// shown instead of the tray icon's context menu. The position is only available on
        /// Windows, and it is (0, 0) by default.
        abstract popUpContextMenu: ?menu: Menu * ?position: Point -> unit
        /// Sets the context menu for this icon.
        abstract setContextMenu: menu: Menu -> unit
        /// Sets when the tray's icon background becomes highlighted (in blue). Note: You
        /// can use highlightMode with a BrowserWindow by toggling between 'never' and
        /// 'always' modes when the window visibility changes.
        abstract setHighlightMode: mode: U3<string, string, string> -> unit
        /// Sets the image associated with this tray icon.
        abstract setImage: image: U2<NativeImage, string> -> unit
        /// Sets the image associated with this tray icon when pressed on macOS.
        abstract setPressedImage: image: NativeImage -> unit
        /// Sets the title displayed aside of the tray icon in the status bar.
        abstract setTitle: title: string -> unit
        /// Sets the hover text for this tray icon.
        abstract setToolTip: toolTip: string -> unit

    type [<AllowNullLiteral>] TrayStatic =
        [<Emit "new $0($1...)">] abstract Create: image: U2<NativeImage, string> -> Tray

    type [<AllowNullLiteral>] UploadBlob =
        /// UUID of blob data to upload.
        abstract blobUUID: string with get, set
        /// blob.
        abstract ``type``: string with get, set

    type [<AllowNullLiteral>] UploadData =
        /// UUID of blob data. Use method to retrieve the data.
        abstract blobUUID: string with get, set
        /// Content being sent.
        abstract bytes: Buffer with get, set
        /// Path of file being uploaded.
        abstract file: string with get, set

    type [<AllowNullLiteral>] UploadFile =
        /// Path of file to be uploaded.
        abstract filePath: string with get, set
        /// Number of bytes to read from offset. Defaults to 0.
        abstract length: float with get, set
        /// Last Modification time in number of seconds sine the UNIX epoch.
        abstract modificationTime: float with get, set
        /// Defaults to 0.
        abstract offset: float with get, set
        /// file.
        abstract ``type``: string with get, set

    type [<AllowNullLiteral>] UploadFileSystem =
        /// FileSystem url to read data for upload.
        abstract filsSystemURL: string with get, set
        /// Number of bytes to read from offset. Defaults to 0.
        abstract length: float with get, set
        /// Last Modification time in number of seconds sine the UNIX epoch.
        abstract modificationTime: float with get, set
        /// Defaults to 0.
        abstract offset: float with get, set
        /// fileSystem.
        abstract ``type``: string with get, set

    type [<AllowNullLiteral>] UploadRawData =
        /// Data to be uploaded.
        abstract bytes: Buffer with get, set
        /// rawData.
        abstract ``type``: string with get, set

    type [<AllowNullLiteral>] WebContents =
        inherit EventEmitter
        /// Emitted before dispatching the keydown and keyup events in the page. Calling
        /// event.preventDefault will prevent the page keydown/keyup events and the menu
        /// shortcuts. To only prevent the menu shortcuts, use setIgnoreMenuShortcuts:
        [<Emit "$0.on('before-input-event',$1)">] abstract ``on_before-input-event``: listener: (Event -> Input -> unit) -> WebContents
        [<Emit "$0.once('before-input-event',$1)">] abstract ``once_before-input-event``: listener: (Event -> Input -> unit) -> WebContents
        [<Emit "$0.addListener('before-input-event',$1)">] abstract ``addListener_before-input-event``: listener: (Event -> Input -> unit) -> WebContents
        [<Emit "$0.removeListener('before-input-event',$1)">] abstract ``removeListener_before-input-event``: listener: (Event -> Input -> unit) -> WebContents
        /// Emitted when failed to verify the certificate for url. The usage is the same
        /// with the certificate-error event of app.
        [<Emit "$0.on('certificate-error',$1)">] abstract ``on_certificate-error``: listener: (Event -> string -> string -> Certificate -> (bool -> unit) -> unit) -> WebContents
        [<Emit "$0.once('certificate-error',$1)">] abstract ``once_certificate-error``: listener: (Event -> string -> string -> Certificate -> (bool -> unit) -> unit) -> WebContents
        [<Emit "$0.addListener('certificate-error',$1)">] abstract ``addListener_certificate-error``: listener: (Event -> string -> string -> Certificate -> (bool -> unit) -> unit) -> WebContents
        [<Emit "$0.removeListener('certificate-error',$1)">] abstract ``removeListener_certificate-error``: listener: (Event -> string -> string -> Certificate -> (bool -> unit) -> unit) -> WebContents
        /// Emitted when the associated window logs a console message. Will not be emitted
        /// for windows with offscreen rendering enabled.
        [<Emit "$0.on('console-message',$1)">] abstract ``on_console-message``: listener: (float -> string -> float -> string -> unit) -> WebContents
        [<Emit "$0.once('console-message',$1)">] abstract ``once_console-message``: listener: (float -> string -> float -> string -> unit) -> WebContents
        [<Emit "$0.addListener('console-message',$1)">] abstract ``addListener_console-message``: listener: (float -> string -> float -> string -> unit) -> WebContents
        [<Emit "$0.removeListener('console-message',$1)">] abstract ``removeListener_console-message``: listener: (float -> string -> float -> string -> unit) -> WebContents
        /// Emitted when there is a new context menu that needs to be handled.
        [<Emit "$0.on('context-menu',$1)">] abstract ``on_context-menu``: listener: (Event -> ContextMenuParams -> unit) -> WebContents
        [<Emit "$0.once('context-menu',$1)">] abstract ``once_context-menu``: listener: (Event -> ContextMenuParams -> unit) -> WebContents
        [<Emit "$0.addListener('context-menu',$1)">] abstract ``addListener_context-menu``: listener: (Event -> ContextMenuParams -> unit) -> WebContents
        [<Emit "$0.removeListener('context-menu',$1)">] abstract ``removeListener_context-menu``: listener: (Event -> ContextMenuParams -> unit) -> WebContents
        /// Emitted when the renderer process crashes or is killed.
        [<Emit "$0.on('crashed',$1)">] abstract on_crashed: listener: (Event -> bool -> unit) -> WebContents
        [<Emit "$0.once('crashed',$1)">] abstract once_crashed: listener: (Event -> bool -> unit) -> WebContents
        [<Emit "$0.addListener('crashed',$1)">] abstract addListener_crashed: listener: (Event -> bool -> unit) -> WebContents
        [<Emit "$0.removeListener('crashed',$1)">] abstract removeListener_crashed: listener: (Event -> bool -> unit) -> WebContents
        /// Emitted when the cursor's type changes. The type parameter can be default,
        /// crosshair, pointer, text, wait, help, e-resize, n-resize, ne-resize, nw-resize,
        /// s-resize, se-resize, sw-resize, w-resize, ns-resize, ew-resize, nesw-resize,
        /// nwse-resize, col-resize, row-resize, m-panning, e-panning, n-panning,
        /// ne-panning, nw-panning, s-panning, se-panning, sw-panning, w-panning, move,
        /// vertical-text, cell, context-menu, alias, progress, nodrop, copy, none,
        /// not-allowed, zoom-in, zoom-out, grab, grabbing, custom. If the type parameter is
        /// custom, the image parameter will hold the custom cursor image in a NativeImage,
        /// and scale, size and hotspot will hold additional information about the custom
        /// cursor.
        [<Emit "$0.on('cursor-changed',$1)">] abstract ``on_cursor-changed``: listener: (Event -> string -> NativeImage -> float -> Size -> Point -> unit) -> WebContents
        [<Emit "$0.once('cursor-changed',$1)">] abstract ``once_cursor-changed``: listener: (Event -> string -> NativeImage -> float -> Size -> Point -> unit) -> WebContents
        [<Emit "$0.addListener('cursor-changed',$1)">] abstract ``addListener_cursor-changed``: listener: (Event -> string -> NativeImage -> float -> Size -> Point -> unit) -> WebContents
        [<Emit "$0.removeListener('cursor-changed',$1)">] abstract ``removeListener_cursor-changed``: listener: (Event -> string -> NativeImage -> float -> Size -> Point -> unit) -> WebContents
        /// Emitted when webContents is destroyed.
        [<Emit "$0.on('destroyed',$1)">] abstract on_destroyed: listener: Function -> WebContents
        [<Emit "$0.once('destroyed',$1)">] abstract once_destroyed: listener: Function -> WebContents
        [<Emit "$0.addListener('destroyed',$1)">] abstract addListener_destroyed: listener: Function -> WebContents
        [<Emit "$0.removeListener('destroyed',$1)">] abstract removeListener_destroyed: listener: Function -> WebContents
        /// Emitted when DevTools is closed.
        [<Emit "$0.on('devtools-closed',$1)">] abstract ``on_devtools-closed``: listener: Function -> WebContents
        [<Emit "$0.once('devtools-closed',$1)">] abstract ``once_devtools-closed``: listener: Function -> WebContents
        [<Emit "$0.addListener('devtools-closed',$1)">] abstract ``addListener_devtools-closed``: listener: Function -> WebContents
        [<Emit "$0.removeListener('devtools-closed',$1)">] abstract ``removeListener_devtools-closed``: listener: Function -> WebContents
        /// Emitted when DevTools is focused / opened.
        [<Emit "$0.on('devtools-focused',$1)">] abstract ``on_devtools-focused``: listener: Function -> WebContents
        [<Emit "$0.once('devtools-focused',$1)">] abstract ``once_devtools-focused``: listener: Function -> WebContents
        [<Emit "$0.addListener('devtools-focused',$1)">] abstract ``addListener_devtools-focused``: listener: Function -> WebContents
        [<Emit "$0.removeListener('devtools-focused',$1)">] abstract ``removeListener_devtools-focused``: listener: Function -> WebContents
        /// Emitted when DevTools is opened.
        [<Emit "$0.on('devtools-opened',$1)">] abstract ``on_devtools-opened``: listener: Function -> WebContents
        [<Emit "$0.once('devtools-opened',$1)">] abstract ``once_devtools-opened``: listener: Function -> WebContents
        [<Emit "$0.addListener('devtools-opened',$1)">] abstract ``addListener_devtools-opened``: listener: Function -> WebContents
        [<Emit "$0.removeListener('devtools-opened',$1)">] abstract ``removeListener_devtools-opened``: listener: Function -> WebContents
        /// Emitted when the devtools window instructs the webContents to reload
        [<Emit "$0.on('devtools-reload-page',$1)">] abstract ``on_devtools-reload-page``: listener: Function -> WebContents
        [<Emit "$0.once('devtools-reload-page',$1)">] abstract ``once_devtools-reload-page``: listener: Function -> WebContents
        [<Emit "$0.addListener('devtools-reload-page',$1)">] abstract ``addListener_devtools-reload-page``: listener: Function -> WebContents
        [<Emit "$0.removeListener('devtools-reload-page',$1)">] abstract ``removeListener_devtools-reload-page``: listener: Function -> WebContents
        /// Emitted when a <webview> has been attached to this web contents.
        [<Emit "$0.on('did-attach-webview',$1)">] abstract ``on_did-attach-webview``: listener: (Event -> WebContents -> unit) -> WebContents
        [<Emit "$0.once('did-attach-webview',$1)">] abstract ``once_did-attach-webview``: listener: (Event -> WebContents -> unit) -> WebContents
        [<Emit "$0.addListener('did-attach-webview',$1)">] abstract ``addListener_did-attach-webview``: listener: (Event -> WebContents -> unit) -> WebContents
        [<Emit "$0.removeListener('did-attach-webview',$1)">] abstract ``removeListener_did-attach-webview``: listener: (Event -> WebContents -> unit) -> WebContents
        /// Emitted when a page's theme color changes. This is usually due to encountering a
        /// meta tag:
        [<Emit "$0.on('did-change-theme-color',$1)">] abstract ``on_did-change-theme-color``: listener: (Event -> string option -> unit) -> WebContents
        [<Emit "$0.once('did-change-theme-color',$1)">] abstract ``once_did-change-theme-color``: listener: (Event -> string option -> unit) -> WebContents
        [<Emit "$0.addListener('did-change-theme-color',$1)">] abstract ``addListener_did-change-theme-color``: listener: (Event -> string option -> unit) -> WebContents
        [<Emit "$0.removeListener('did-change-theme-color',$1)">] abstract ``removeListener_did-change-theme-color``: listener: (Event -> string option -> unit) -> WebContents
        /// This event is like did-finish-load but emitted when the load failed or was
        /// cancelled, e.g. window.stop() is invoked. The full list of error codes and their
        /// meaning is available here.
        [<Emit "$0.on('did-fail-load',$1)">] abstract ``on_did-fail-load``: listener: (Event -> float -> string -> string -> bool -> unit) -> WebContents
        [<Emit "$0.once('did-fail-load',$1)">] abstract ``once_did-fail-load``: listener: (Event -> float -> string -> string -> bool -> unit) -> WebContents
        [<Emit "$0.addListener('did-fail-load',$1)">] abstract ``addListener_did-fail-load``: listener: (Event -> float -> string -> string -> bool -> unit) -> WebContents
        [<Emit "$0.removeListener('did-fail-load',$1)">] abstract ``removeListener_did-fail-load``: listener: (Event -> float -> string -> string -> bool -> unit) -> WebContents
        /// Emitted when the navigation is done, i.e. the spinner of the tab has stopped
        /// spinning, and the onload event was dispatched.
        [<Emit "$0.on('did-finish-load',$1)">] abstract ``on_did-finish-load``: listener: Function -> WebContents
        [<Emit "$0.once('did-finish-load',$1)">] abstract ``once_did-finish-load``: listener: Function -> WebContents
        [<Emit "$0.addListener('did-finish-load',$1)">] abstract ``addListener_did-finish-load``: listener: Function -> WebContents
        [<Emit "$0.removeListener('did-finish-load',$1)">] abstract ``removeListener_did-finish-load``: listener: Function -> WebContents
        /// Emitted when a frame has done navigation.
        [<Emit "$0.on('did-frame-finish-load',$1)">] abstract ``on_did-frame-finish-load``: listener: (Event -> bool -> unit) -> WebContents
        [<Emit "$0.once('did-frame-finish-load',$1)">] abstract ``once_did-frame-finish-load``: listener: (Event -> bool -> unit) -> WebContents
        [<Emit "$0.addListener('did-frame-finish-load',$1)">] abstract ``addListener_did-frame-finish-load``: listener: (Event -> bool -> unit) -> WebContents
        [<Emit "$0.removeListener('did-frame-finish-load',$1)">] abstract ``removeListener_did-frame-finish-load``: listener: (Event -> bool -> unit) -> WebContents
        /// Emitted when a redirect is received while requesting a resource.
        [<Emit "$0.on('did-get-redirect-request',$1)">] abstract ``on_did-get-redirect-request``: listener: (Event -> string -> string -> bool -> float -> string -> string -> obj option -> unit) -> WebContents
        [<Emit "$0.once('did-get-redirect-request',$1)">] abstract ``once_did-get-redirect-request``: listener: (Event -> string -> string -> bool -> float -> string -> string -> obj option -> unit) -> WebContents
        [<Emit "$0.addListener('did-get-redirect-request',$1)">] abstract ``addListener_did-get-redirect-request``: listener: (Event -> string -> string -> bool -> float -> string -> string -> obj option -> unit) -> WebContents
        [<Emit "$0.removeListener('did-get-redirect-request',$1)">] abstract ``removeListener_did-get-redirect-request``: listener: (Event -> string -> string -> bool -> float -> string -> string -> obj option -> unit) -> WebContents
        /// Emitted when details regarding a requested resource are available. status
        /// indicates the socket connection to download the resource.
        [<Emit "$0.on('did-get-response-details',$1)">] abstract ``on_did-get-response-details``: listener: (Event -> bool -> string -> string -> float -> string -> string -> obj option -> string -> unit) -> WebContents
        [<Emit "$0.once('did-get-response-details',$1)">] abstract ``once_did-get-response-details``: listener: (Event -> bool -> string -> string -> float -> string -> string -> obj option -> string -> unit) -> WebContents
        [<Emit "$0.addListener('did-get-response-details',$1)">] abstract ``addListener_did-get-response-details``: listener: (Event -> bool -> string -> string -> float -> string -> string -> obj option -> string -> unit) -> WebContents
        [<Emit "$0.removeListener('did-get-response-details',$1)">] abstract ``removeListener_did-get-response-details``: listener: (Event -> bool -> string -> string -> float -> string -> string -> obj option -> string -> unit) -> WebContents
        /// Emitted when a navigation is done. This event is not emitted for in-page
        /// navigations, such as clicking anchor links or updating the window.location.hash.
        /// Use did-navigate-in-page event for this purpose.
        [<Emit "$0.on('did-navigate',$1)">] abstract ``on_did-navigate``: listener: (Event -> string -> unit) -> WebContents
        [<Emit "$0.once('did-navigate',$1)">] abstract ``once_did-navigate``: listener: (Event -> string -> unit) -> WebContents
        [<Emit "$0.addListener('did-navigate',$1)">] abstract ``addListener_did-navigate``: listener: (Event -> string -> unit) -> WebContents
        [<Emit "$0.removeListener('did-navigate',$1)">] abstract ``removeListener_did-navigate``: listener: (Event -> string -> unit) -> WebContents
        /// Emitted when an in-page navigation happened. When in-page navigation happens,
        /// the page URL changes but does not cause navigation outside of the page. Examples
        /// of this occurring are when anchor links are clicked or when the DOM hashchange
        /// event is triggered.
        [<Emit "$0.on('did-navigate-in-page',$1)">] abstract ``on_did-navigate-in-page``: listener: (Event -> string -> bool -> unit) -> WebContents
        [<Emit "$0.once('did-navigate-in-page',$1)">] abstract ``once_did-navigate-in-page``: listener: (Event -> string -> bool -> unit) -> WebContents
        [<Emit "$0.addListener('did-navigate-in-page',$1)">] abstract ``addListener_did-navigate-in-page``: listener: (Event -> string -> bool -> unit) -> WebContents
        [<Emit "$0.removeListener('did-navigate-in-page',$1)">] abstract ``removeListener_did-navigate-in-page``: listener: (Event -> string -> bool -> unit) -> WebContents
        /// Corresponds to the points in time when the spinner of the tab started spinning.
        [<Emit "$0.on('did-start-loading',$1)">] abstract ``on_did-start-loading``: listener: Function -> WebContents
        [<Emit "$0.once('did-start-loading',$1)">] abstract ``once_did-start-loading``: listener: Function -> WebContents
        [<Emit "$0.addListener('did-start-loading',$1)">] abstract ``addListener_did-start-loading``: listener: Function -> WebContents
        [<Emit "$0.removeListener('did-start-loading',$1)">] abstract ``removeListener_did-start-loading``: listener: Function -> WebContents
        /// Corresponds to the points in time when the spinner of the tab stopped spinning.
        [<Emit "$0.on('did-stop-loading',$1)">] abstract ``on_did-stop-loading``: listener: Function -> WebContents
        [<Emit "$0.once('did-stop-loading',$1)">] abstract ``once_did-stop-loading``: listener: Function -> WebContents
        [<Emit "$0.addListener('did-stop-loading',$1)">] abstract ``addListener_did-stop-loading``: listener: Function -> WebContents
        [<Emit "$0.removeListener('did-stop-loading',$1)">] abstract ``removeListener_did-stop-loading``: listener: Function -> WebContents
        /// Emitted when the document in the given frame is loaded.
        [<Emit "$0.on('dom-ready',$1)">] abstract ``on_dom-ready``: listener: (Event -> unit) -> WebContents
        [<Emit "$0.once('dom-ready',$1)">] abstract ``once_dom-ready``: listener: (Event -> unit) -> WebContents
        [<Emit "$0.addListener('dom-ready',$1)">] abstract ``addListener_dom-ready``: listener: (Event -> unit) -> WebContents
        [<Emit "$0.removeListener('dom-ready',$1)">] abstract ``removeListener_dom-ready``: listener: (Event -> unit) -> WebContents
        /// Emitted when a result is available for [webContents.findInPage] request.
        [<Emit "$0.on('found-in-page',$1)">] abstract ``on_found-in-page``: listener: (Event -> Result -> unit) -> WebContents
        [<Emit "$0.once('found-in-page',$1)">] abstract ``once_found-in-page``: listener: (Event -> Result -> unit) -> WebContents
        [<Emit "$0.addListener('found-in-page',$1)">] abstract ``addListener_found-in-page``: listener: (Event -> Result -> unit) -> WebContents
        [<Emit "$0.removeListener('found-in-page',$1)">] abstract ``removeListener_found-in-page``: listener: (Event -> Result -> unit) -> WebContents
        /// Emitted when webContents wants to do basic auth. The usage is the same with the
        /// login event of app.
        [<Emit "$0.on('login',$1)">] abstract on_login: listener: (Event -> Request -> AuthInfo -> (string -> string -> unit) -> unit) -> WebContents
        [<Emit "$0.once('login',$1)">] abstract once_login: listener: (Event -> Request -> AuthInfo -> (string -> string -> unit) -> unit) -> WebContents
        [<Emit "$0.addListener('login',$1)">] abstract addListener_login: listener: (Event -> Request -> AuthInfo -> (string -> string -> unit) -> unit) -> WebContents
        [<Emit "$0.removeListener('login',$1)">] abstract removeListener_login: listener: (Event -> Request -> AuthInfo -> (string -> string -> unit) -> unit) -> WebContents
        /// Emitted when media is paused or done playing.
        [<Emit "$0.on('media-paused',$1)">] abstract ``on_media-paused``: listener: Function -> WebContents
        [<Emit "$0.once('media-paused',$1)">] abstract ``once_media-paused``: listener: Function -> WebContents
        [<Emit "$0.addListener('media-paused',$1)">] abstract ``addListener_media-paused``: listener: Function -> WebContents
        [<Emit "$0.removeListener('media-paused',$1)">] abstract ``removeListener_media-paused``: listener: Function -> WebContents
        /// Emitted when media starts playing.
        [<Emit "$0.on('media-started-playing',$1)">] abstract ``on_media-started-playing``: listener: Function -> WebContents
        [<Emit "$0.once('media-started-playing',$1)">] abstract ``once_media-started-playing``: listener: Function -> WebContents
        [<Emit "$0.addListener('media-started-playing',$1)">] abstract ``addListener_media-started-playing``: listener: Function -> WebContents
        [<Emit "$0.removeListener('media-started-playing',$1)">] abstract ``removeListener_media-started-playing``: listener: Function -> WebContents
        /// Emitted when the page requests to open a new window for a url. It could be
        /// requested by window.open or an external link like <a target='_blank'>. By
        /// default a new BrowserWindow will be created for the url. Calling
        /// event.preventDefault() will prevent Electron from automatically creating a new
        /// BrowserWindow. If you call event.preventDefault() and manually create a new
        /// BrowserWindow then you must set event.newGuest to reference the new
        /// BrowserWindow instance, failing to do so may result in unexpected behavior. For
        /// example:
        [<Emit "$0.on('new-window',$1)">] abstract ``on_new-window``: listener: (Event -> string -> string -> U6<string, string, string, string, string, string> -> obj option -> ResizeArray<string> -> unit) -> WebContents
        [<Emit "$0.once('new-window',$1)">] abstract ``once_new-window``: listener: (Event -> string -> string -> U6<string, string, string, string, string, string> -> obj option -> ResizeArray<string> -> unit) -> WebContents
        [<Emit "$0.addListener('new-window',$1)">] abstract ``addListener_new-window``: listener: (Event -> string -> string -> U6<string, string, string, string, string, string> -> obj option -> ResizeArray<string> -> unit) -> WebContents
        [<Emit "$0.removeListener('new-window',$1)">] abstract ``removeListener_new-window``: listener: (Event -> string -> string -> U6<string, string, string, string, string, string> -> obj option -> ResizeArray<string> -> unit) -> WebContents
        /// Emitted when page receives favicon urls.
        [<Emit "$0.on('page-favicon-updated',$1)">] abstract ``on_page-favicon-updated``: listener: (Event -> ResizeArray<string> -> unit) -> WebContents
        [<Emit "$0.once('page-favicon-updated',$1)">] abstract ``once_page-favicon-updated``: listener: (Event -> ResizeArray<string> -> unit) -> WebContents
        [<Emit "$0.addListener('page-favicon-updated',$1)">] abstract ``addListener_page-favicon-updated``: listener: (Event -> ResizeArray<string> -> unit) -> WebContents
        [<Emit "$0.removeListener('page-favicon-updated',$1)">] abstract ``removeListener_page-favicon-updated``: listener: (Event -> ResizeArray<string> -> unit) -> WebContents
        /// Emitted when a new frame is generated. Only the dirty area is passed in the
        /// buffer.
        [<Emit "$0.on('paint',$1)">] abstract on_paint: listener: (Event -> Rectangle -> NativeImage -> unit) -> WebContents
        [<Emit "$0.once('paint',$1)">] abstract once_paint: listener: (Event -> Rectangle -> NativeImage -> unit) -> WebContents
        [<Emit "$0.addListener('paint',$1)">] abstract addListener_paint: listener: (Event -> Rectangle -> NativeImage -> unit) -> WebContents
        [<Emit "$0.removeListener('paint',$1)">] abstract removeListener_paint: listener: (Event -> Rectangle -> NativeImage -> unit) -> WebContents
        /// Emitted when a plugin process has crashed.
        [<Emit "$0.on('plugin-crashed',$1)">] abstract ``on_plugin-crashed``: listener: (Event -> string -> string -> unit) -> WebContents
        [<Emit "$0.once('plugin-crashed',$1)">] abstract ``once_plugin-crashed``: listener: (Event -> string -> string -> unit) -> WebContents
        [<Emit "$0.addListener('plugin-crashed',$1)">] abstract ``addListener_plugin-crashed``: listener: (Event -> string -> string -> unit) -> WebContents
        [<Emit "$0.removeListener('plugin-crashed',$1)">] abstract ``removeListener_plugin-crashed``: listener: (Event -> string -> string -> unit) -> WebContents
        /// Emitted when bluetooth device needs to be selected on call to
        /// navigator.bluetooth.requestDevice. To use navigator.bluetooth api webBluetooth
        /// should be enabled.  If event.preventDefault is not called, first available
        /// device will be selected. callback should be called with deviceId to be selected,
        /// passing empty string to callback will cancel the request.
        [<Emit "$0.on('select-bluetooth-device',$1)">] abstract ``on_select-bluetooth-device``: listener: (Event -> ResizeArray<BluetoothDevice> -> (string -> unit) -> unit) -> WebContents
        [<Emit "$0.once('select-bluetooth-device',$1)">] abstract ``once_select-bluetooth-device``: listener: (Event -> ResizeArray<BluetoothDevice> -> (string -> unit) -> unit) -> WebContents
        [<Emit "$0.addListener('select-bluetooth-device',$1)">] abstract ``addListener_select-bluetooth-device``: listener: (Event -> ResizeArray<BluetoothDevice> -> (string -> unit) -> unit) -> WebContents
        [<Emit "$0.removeListener('select-bluetooth-device',$1)">] abstract ``removeListener_select-bluetooth-device``: listener: (Event -> ResizeArray<BluetoothDevice> -> (string -> unit) -> unit) -> WebContents
        /// Emitted when a client certificate is requested. The usage is the same with the
        /// select-client-certificate event of app.
        [<Emit "$0.on('select-client-certificate',$1)">] abstract ``on_select-client-certificate``: listener: (Event -> string -> ResizeArray<Certificate> -> (Certificate -> unit) -> unit) -> WebContents
        [<Emit "$0.once('select-client-certificate',$1)">] abstract ``once_select-client-certificate``: listener: (Event -> string -> ResizeArray<Certificate> -> (Certificate -> unit) -> unit) -> WebContents
        [<Emit "$0.addListener('select-client-certificate',$1)">] abstract ``addListener_select-client-certificate``: listener: (Event -> string -> ResizeArray<Certificate> -> (Certificate -> unit) -> unit) -> WebContents
        [<Emit "$0.removeListener('select-client-certificate',$1)">] abstract ``removeListener_select-client-certificate``: listener: (Event -> string -> ResizeArray<Certificate> -> (Certificate -> unit) -> unit) -> WebContents
        /// Emitted when mouse moves over a link or the keyboard moves the focus to a link.
        [<Emit "$0.on('update-target-url',$1)">] abstract ``on_update-target-url``: listener: (Event -> string -> unit) -> WebContents
        [<Emit "$0.once('update-target-url',$1)">] abstract ``once_update-target-url``: listener: (Event -> string -> unit) -> WebContents
        [<Emit "$0.addListener('update-target-url',$1)">] abstract ``addListener_update-target-url``: listener: (Event -> string -> unit) -> WebContents
        [<Emit "$0.removeListener('update-target-url',$1)">] abstract ``removeListener_update-target-url``: listener: (Event -> string -> unit) -> WebContents
        /// Emitted when a <webview>'s web contents is being attached to this web contents.
        /// Calling event.preventDefault() will destroy the guest page. This event can be
        /// used to configure webPreferences for the webContents of a <webview> before it's
        /// loaded, and provides the ability to set settings that can't be set via <webview>
        /// attributes. Note: The specified preload script option will be appear as
        /// preloadURL (not preload) in the webPreferences object emitted with this event.
        [<Emit "$0.on('will-attach-webview',$1)">] abstract ``on_will-attach-webview``: listener: (Event -> obj option -> obj option -> unit) -> WebContents
        [<Emit "$0.once('will-attach-webview',$1)">] abstract ``once_will-attach-webview``: listener: (Event -> obj option -> obj option -> unit) -> WebContents
        [<Emit "$0.addListener('will-attach-webview',$1)">] abstract ``addListener_will-attach-webview``: listener: (Event -> obj option -> obj option -> unit) -> WebContents
        [<Emit "$0.removeListener('will-attach-webview',$1)">] abstract ``removeListener_will-attach-webview``: listener: (Event -> obj option -> obj option -> unit) -> WebContents
        /// Emitted when a user or the page wants to start navigation. It can happen when
        /// the window.location object is changed or a user clicks a link in the page. This
        /// event will not emit when the navigation is started programmatically with APIs
        /// like webContents.loadURL and webContents.back. It is also not emitted for
        /// in-page navigations, such as clicking anchor links or updating the
        /// window.location.hash. Use did-navigate-in-page event for this purpose. Calling
        /// event.preventDefault() will prevent the navigation.
        [<Emit "$0.on('will-navigate',$1)">] abstract ``on_will-navigate``: listener: (Event -> string -> unit) -> WebContents
        [<Emit "$0.once('will-navigate',$1)">] abstract ``once_will-navigate``: listener: (Event -> string -> unit) -> WebContents
        [<Emit "$0.addListener('will-navigate',$1)">] abstract ``addListener_will-navigate``: listener: (Event -> string -> unit) -> WebContents
        [<Emit "$0.removeListener('will-navigate',$1)">] abstract ``removeListener_will-navigate``: listener: (Event -> string -> unit) -> WebContents
        /// Emitted when a beforeunload event handler is attempting to cancel a page unload.
        /// Calling event.preventDefault() will ignore the beforeunload event handler and
        /// allow the page to be unloaded.
        [<Emit "$0.on('will-prevent-unload',$1)">] abstract ``on_will-prevent-unload``: listener: (Event -> unit) -> WebContents
        [<Emit "$0.once('will-prevent-unload',$1)">] abstract ``once_will-prevent-unload``: listener: (Event -> unit) -> WebContents
        [<Emit "$0.addListener('will-prevent-unload',$1)">] abstract ``addListener_will-prevent-unload``: listener: (Event -> unit) -> WebContents
        [<Emit "$0.removeListener('will-prevent-unload',$1)">] abstract ``removeListener_will-prevent-unload``: listener: (Event -> unit) -> WebContents
        /// Adds the specified path to DevTools workspace. Must be used after DevTools
        /// creation:
        abstract addWorkSpace: path: string -> unit
        /// Begin subscribing for presentation events and captured frames, the callback will
        /// be called with callback(frameBuffer, dirtyRect) when there is a presentation
        /// event. The frameBuffer is a Buffer that contains raw pixel data. On most
        /// machines, the pixel data is effectively stored in 32bit BGRA format, but the
        /// actual representation depends on the endianness of the processor (most modern
        /// processors are little-endian, on machines with big-endian processors the data is
        /// in 32bit ARGB format). The dirtyRect is an object with x, y, width, height
        /// properties that describes which part of the page was repainted. If onlyDirty is
        /// set to true, frameBuffer will only contain the repainted area. onlyDirty
        /// defaults to false.
        abstract beginFrameSubscription: callback: (Buffer -> Rectangle -> unit) -> unit
        /// Begin subscribing for presentation events and captured frames, the callback will
        /// be called with callback(frameBuffer, dirtyRect) when there is a presentation
        /// event. The frameBuffer is a Buffer that contains raw pixel data. On most
        /// machines, the pixel data is effectively stored in 32bit BGRA format, but the
        /// actual representation depends on the endianness of the processor (most modern
        /// processors are little-endian, on machines with big-endian processors the data is
        /// in 32bit ARGB format). The dirtyRect is an object with x, y, width, height
        /// properties that describes which part of the page was repainted. If onlyDirty is
        /// set to true, frameBuffer will only contain the repainted area. onlyDirty
        /// defaults to false.
        abstract beginFrameSubscription: onlyDirty: bool * callback: (Buffer -> Rectangle -> unit) -> unit
        abstract canGoBack: unit -> bool
        abstract canGoForward: unit -> bool
        abstract canGoToOffset: offset: float -> bool
        /// Captures a snapshot of the page within rect. Upon completion callback will be
        /// called with callback(image). The image is an instance of NativeImage that stores
        /// data of the snapshot. Omitting rect will capture the whole visible page.
        abstract capturePage: rect: Rectangle * callback: (NativeImage -> unit) -> unit
        /// Captures a snapshot of the page within rect. Upon completion callback will be
        /// called with callback(image). The image is an instance of NativeImage that stores
        /// data of the snapshot. Omitting rect will capture the whole visible page.
        abstract capturePage: callback: (NativeImage -> unit) -> unit
        /// Clears the navigation history.
        abstract clearHistory: unit -> unit
        /// Closes the devtools.
        abstract closeDevTools: unit -> unit
        /// Executes the editing command copy in web page.
        abstract copy: unit -> unit
        /// Copy the image at the given position to the clipboard.
        abstract copyImageAt: x: float * y: float -> unit
        /// Executes the editing command cut in web page.
        abstract cut: unit -> unit
        /// Executes the editing command delete in web page.
        abstract delete: unit -> unit
        /// Disable device emulation enabled by webContents.enableDeviceEmulation.
        abstract disableDeviceEmulation: unit -> unit
        /// Initiates a download of the resource at url without navigating. The
        /// will-download event of session will be triggered.
        abstract downloadURL: url: string -> unit
        /// Enable device emulation with the given parameters.
        abstract enableDeviceEmulation: parameters: Parameters -> unit
        /// End subscribing for frame presentation events.
        abstract endFrameSubscription: unit -> unit
        /// Evaluates code in page. In the browser window some HTML APIs like
        /// requestFullScreen can only be invoked by a gesture from the user. Setting
        /// userGesture to true will remove this limitation. If the result of the executed
        /// code is a promise the callback result will be the resolved value of the promise.
        ///   We recommend that you use the returned Promise to handle code that results in a
        /// Promise.
        abstract executeJavaScript: code: string * ?userGesture: bool * ?callback: (obj option -> unit) -> Promise<obj option>
        /// Starts a request to find all matches for the text in the web page. The result of
        /// the request can be obtained by subscribing to found-in-page event.
        abstract findInPage: text: string * ?options: FindInPageOptions -> float
        /// Focuses the web page.
        abstract focus: unit -> unit
        abstract getFrameRate: unit -> float
        abstract getOSProcessId: unit -> float
        /// Get the system printer list.
        abstract getPrinters: unit -> ResizeArray<PrinterInfo>
        abstract getTitle: unit -> string
        abstract getURL: unit -> string
        abstract getUserAgent: unit -> string
        abstract getWebRTCIPHandlingPolicy: unit -> string
        /// Sends a request to get current zoom factor, the callback will be called with
        /// callback(zoomFactor).
        abstract getZoomFactor: callback: (float -> unit) -> unit
        /// Sends a request to get current zoom level, the callback will be called with
        /// callback(zoomLevel).
        abstract getZoomLevel: callback: (float -> unit) -> unit
        /// Makes the browser go back a web page.
        abstract goBack: unit -> unit
        /// Makes the browser go forward a web page.
        abstract goForward: unit -> unit
        /// Navigates browser to the specified absolute web page index.
        abstract goToIndex: index: float -> unit
        /// Navigates to the specified offset from the "current entry".
        abstract goToOffset: offset: float -> unit
        /// Checks if any ServiceWorker is registered and returns a boolean as response to
        /// callback.
        abstract hasServiceWorker: callback: (bool -> unit) -> unit
        /// Injects CSS into the current web page.
        abstract insertCSS: css: string -> unit
        /// Inserts text to the focused element.
        abstract insertText: text: string -> unit
        /// Starts inspecting element at position (x, y).
        abstract inspectElement: x: float * y: float -> unit
        /// Opens the developer tools for the service worker context.
        abstract inspectServiceWorker: unit -> unit
        /// Schedules a full repaint of the window this web contents is in. If offscreen
        /// rendering is enabled invalidates the frame and generates a new one through the
        /// 'paint' event.
        abstract invalidate: unit -> unit
        abstract isAudioMuted: unit -> bool
        abstract isCrashed: unit -> bool
        abstract isDestroyed: unit -> bool
        abstract isDevToolsFocused: unit -> bool
        abstract isDevToolsOpened: unit -> bool
        abstract isFocused: unit -> bool
        abstract isLoading: unit -> bool
        abstract isLoadingMainFrame: unit -> bool
        abstract isOffscreen: unit -> bool
        abstract isPainting: unit -> bool
        abstract isWaitingForResponse: unit -> bool
        /// Loads the url in the window. The url must contain the protocol prefix, e.g. the
        /// http:// or file://. If the load should bypass http cache then use the pragma
        /// header to achieve it.
        abstract loadURL: url: string * ?options: LoadURLOptions -> unit
        /// Opens the devtools.
        abstract openDevTools: ?options: OpenDevToolsOptions -> unit
        /// Executes the editing command paste in web page.
        abstract paste: unit -> unit
        /// Executes the editing command pasteAndMatchStyle in web page.
        abstract pasteAndMatchStyle: unit -> unit
        /// Prints window's web page. When silent is set to true, Electron will pick the
        /// system's default printer if deviceName is empty and the default settings for
        /// printing. Calling window.print() in web page is equivalent to calling
        /// webContents.print({silent: false, printBackground: false, deviceName: ''}). Use
        /// page-break-before: always; CSS style to force to print to a new page.
        abstract print: ?options: PrintOptions * ?callback: Function -> unit
        /// Prints window's web page as PDF with Chromium's preview printing custom
        /// settings. The callback will be called with callback(error, data) on completion.
        /// The data is a Buffer that contains the generated PDF data. The landscape will be
        /// ignored if @page CSS at-rule is used in the web page. By default, an empty
        /// options will be regarded as: Use page-break-before: always; CSS style to force
        /// to print to a new page. An example of webContents.printToPDF:
        abstract printToPDF: options: PrintToPDFOptions * callback: (Error -> Buffer -> unit) -> unit
        /// Executes the editing command redo in web page.
        abstract redo: unit -> unit
        /// Reloads the current web page.
        abstract reload: unit -> unit
        /// Reloads current page and ignores cache.
        abstract reloadIgnoringCache: unit -> unit
        /// Removes the specified path from DevTools workspace.
        abstract removeWorkSpace: path: string -> unit
        /// Executes the editing command replace in web page.
        abstract replace: text: string -> unit
        /// Executes the editing command replaceMisspelling in web page.
        abstract replaceMisspelling: text: string -> unit
        abstract savePage: fullPath: string * saveType: U3<string, string, string> * callback: (Error -> unit) -> bool
        /// Executes the editing command selectAll in web page.
        abstract selectAll: unit -> unit
        /// Send an asynchronous message to renderer process via channel, you can also send
        /// arbitrary arguments. Arguments will be serialized in JSON internally and hence
        /// no functions or prototype chain will be included. The renderer process can
        /// handle the message by listening to channel with the ipcRenderer module. An
        /// example of sending messages from the main process to the renderer process:
        abstract send: channel: string * [<ParamArray>] args: ResizeArray<obj option> -> unit
        /// Sends an input event to the page. Note: The BrowserWindow containing the
        /// contents needs to be focused for sendInputEvent() to work. For keyboard events,
        /// the event object also have following properties: For mouse events, the event
        /// object also have following properties: For the mouseWheel event, the event
        /// object also have following properties:
        abstract sendInputEvent: ``event``: Event -> unit
        /// Mute the audio on the current web page.
        abstract setAudioMuted: muted: bool -> unit
        /// If offscreen rendering is enabled sets the frame rate to the specified number.
        /// Only values between 1 and 60 are accepted.
        abstract setFrameRate: fps: float -> unit
        /// Ignore application menu shortcuts while this web contents is focused.
        abstract setIgnoreMenuShortcuts: ignore: bool -> unit
        /// Sets the maximum and minimum layout-based (i.e. non-visual) zoom level.
        abstract setLayoutZoomLevelLimits: minimumLevel: float * maximumLevel: float -> unit
        /// Set the size of the page. This is only supported for <webview> guest contents.
        abstract setSize: options: SizeOptions -> unit
        /// Overrides the user agent for this web page.
        abstract setUserAgent: userAgent: string -> unit
        /// Sets the maximum and minimum pinch-to-zoom level.
        abstract setVisualZoomLevelLimits: minimumLevel: float * maximumLevel: float -> unit
        /// Setting the WebRTC IP handling policy allows you to control which IPs are
        /// exposed via WebRTC.  See BrowserLeaks for more details.
        abstract setWebRTCIPHandlingPolicy: policy: U4<string, string, string, string> -> unit
        /// Changes the zoom factor to the specified factor. Zoom factor is zoom percent
        /// divided by 100, so 300% = 3.0.
        abstract setZoomFactor: factor: float -> unit
        /// Changes the zoom level to the specified level. The original size is 0 and each
        /// increment above or below represents zooming 20% larger or smaller to default
        /// limits of 300% and 50% of original size, respectively.
        abstract setZoomLevel: level: float -> unit
        /// Deprecated: Call setVisualZoomLevelLimits instead to set the visual zoom level
        /// limits. This method will be removed in Electron 2.0.
        abstract setZoomLevelLimits: minimumLevel: float * maximumLevel: float -> unit
        /// Shows pop-up dictionary that searches the selected word on the page.
        abstract showDefinitionForSelection: unit -> unit
        /// Sets the item as dragging item for current drag-drop operation, file is the
        /// absolute path of the file to be dragged, and icon is the image showing under the
        /// cursor when dragging.
        abstract startDrag: item: Item -> unit
        /// If offscreen rendering is enabled and not painting, start painting.
        abstract startPainting: unit -> unit
        /// Stops any pending navigation.
        abstract stop: unit -> unit
        /// Stops any findInPage request for the webContents with the provided action.
        abstract stopFindInPage: action: U3<string, string, string> -> unit
        /// If offscreen rendering is enabled and painting, stop painting.
        abstract stopPainting: unit -> unit
        /// Toggles the developer tools.
        abstract toggleDevTools: unit -> unit
        /// Executes the editing command undo in web page.
        abstract undo: unit -> unit
        /// Unregisters any ServiceWorker if present and returns a boolean as response to
        /// callback when the JS promise is fulfilled or false when the JS promise is
        /// rejected.
        abstract unregisterServiceWorker: callback: (bool -> unit) -> unit
        /// Executes the editing command unselect in web page.
        abstract unselect: unit -> unit
        abstract debugger: Debugger with get, set
        abstract devToolsWebContents: WebContents with get, set
        abstract hostWebContents: WebContents with get, set
        abstract id: float with get, set
        abstract session: Session with get, set

    type [<AllowNullLiteral>] WebContentsStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> WebContents
        abstract fromId: id: float -> WebContents
        abstract getAllWebContents: unit -> ResizeArray<WebContents>
        abstract getFocusedWebContents: unit -> WebContents

    type [<AllowNullLiteral>] WebFrame =
        inherit EventEmitter
        /// Attempts to free memory that is no longer being used (like images from a
        /// previous navigation). Note that blindly calling this method probably makes
        /// Electron slower since it will have to refill these emptied caches, you should
        /// only call it if an event in your app has occurred that makes you think your page
        /// is actually using less memory (i.e. you have navigated from a super heavy page
        /// to a mostly empty one, and intend to stay there).
        abstract clearCache: unit -> unit
        /// Evaluates code in page. In the browser window some HTML APIs like
        /// requestFullScreen can only be invoked by a gesture from the user. Setting
        /// userGesture to true will remove this limitation.
        abstract executeJavaScript: code: string * ?userGesture: bool * ?callback: (obj option -> unit) -> Promise<obj option>
        /// Returns an object describing usage information of Blink's internal memory
        /// caches. This will generate:
        abstract getResourceUsage: unit -> ResourceUsage
        abstract getZoomFactor: unit -> float
        abstract getZoomLevel: unit -> float
        /// Inserts text to the focused element.
        abstract insertText: text: string -> unit
        /// Resources will be loaded from this scheme regardless of the current page's
        /// Content Security Policy.
        abstract registerURLSchemeAsBypassingCSP: scheme: string -> unit
        /// Registers the scheme as secure, bypasses content security policy for resources,
        /// allows registering ServiceWorker and supports fetch API. Specify an option with
        /// the value of false to omit it from the registration. An example of registering a
        /// privileged scheme, without bypassing Content Security Policy:
        abstract registerURLSchemeAsPrivileged: scheme: string * ?options: RegisterURLSchemeAsPrivilegedOptions -> unit
        /// Registers the scheme as secure scheme. Secure schemes do not trigger mixed
        /// content warnings. For example, https and data are secure schemes because they
        /// cannot be corrupted by active network attackers.
        abstract registerURLSchemeAsSecure: scheme: string -> unit
        /// Sets the maximum and minimum layout-based (i.e. non-visual) zoom level.
        abstract setLayoutZoomLevelLimits: minimumLevel: float * maximumLevel: float -> unit
        /// Sets a provider for spell checking in input fields and text areas. The provider
        /// must be an object that has a spellCheck method that returns whether the word
        /// passed is correctly spelled. An example of using node-spellchecker as provider:
        abstract setSpellCheckProvider: language: string * autoCorrectWord: bool * provider: Provider -> unit
        /// Sets the maximum and minimum pinch-to-zoom level.
        abstract setVisualZoomLevelLimits: minimumLevel: float * maximumLevel: float -> unit
        /// Changes the zoom factor to the specified factor. Zoom factor is zoom percent
        /// divided by 100, so 300% = 3.0.
        abstract setZoomFactor: factor: float -> unit
        /// Changes the zoom level to the specified level. The original size is 0 and each
        /// increment above or below represents zooming 20% larger or smaller to default
        /// limits of 300% and 50% of original size, respectively.
        abstract setZoomLevel: level: float -> unit
        /// Deprecated: Call setVisualZoomLevelLimits instead to set the visual zoom level
        /// limits. This method will be removed in Electron 2.0.
        abstract setZoomLevelLimits: minimumLevel: float * maximumLevel: float -> unit

    type [<AllowNullLiteral>] WebRequest =
        inherit EventEmitter
        /// The listener will be called with listener(details) when a server initiated
        /// redirect is about to occur.
        abstract onBeforeRedirect: listener: (OnBeforeRedirectDetails -> unit) -> unit
        /// The listener will be called with listener(details) when a server initiated
        /// redirect is about to occur.
        abstract onBeforeRedirect: filter: OnBeforeRedirectFilter * listener: (OnBeforeRedirectDetails -> unit) -> unit
        /// The listener will be called with listener(details, callback) when a request is
        /// about to occur. The uploadData is an array of UploadData objects. The callback
        /// has to be called with an response object.
        abstract onBeforeRequest: listener: (OnBeforeRequestDetails -> (Response -> unit) -> unit) -> unit
        /// The listener will be called with listener(details, callback) when a request is
        /// about to occur. The uploadData is an array of UploadData objects. The callback
        /// has to be called with an response object.
        abstract onBeforeRequest: filter: OnBeforeRequestFilter * listener: (OnBeforeRequestDetails -> (Response -> unit) -> unit) -> unit
        /// The listener will be called with listener(details, callback) before sending an
        /// HTTP request, once the request headers are available. This may occur after a TCP
        /// connection is made to the server, but before any http data is sent. The callback
        /// has to be called with an response object.
        abstract onBeforeSendHeaders: filter: OnBeforeSendHeadersFilter * listener: Function -> unit
        /// The listener will be called with listener(details, callback) before sending an
        /// HTTP request, once the request headers are available. This may occur after a TCP
        /// connection is made to the server, but before any http data is sent. The callback
        /// has to be called with an response object.
        abstract onBeforeSendHeaders: listener: Function -> unit
        /// The listener will be called with listener(details) when a request is completed.
        abstract onCompleted: filter: OnCompletedFilter * listener: (OnCompletedDetails -> unit) -> unit
        /// The listener will be called with listener(details) when a request is completed.
        abstract onCompleted: listener: (OnCompletedDetails -> unit) -> unit
        /// The listener will be called with listener(details) when an error occurs.
        abstract onErrorOccurred: listener: (OnErrorOccurredDetails -> unit) -> unit
        /// The listener will be called with listener(details) when an error occurs.
        abstract onErrorOccurred: filter: OnErrorOccurredFilter * listener: (OnErrorOccurredDetails -> unit) -> unit
        /// The listener will be called with listener(details, callback) when HTTP response
        /// headers of a request have been received. The callback has to be called with an
        /// response object.
        abstract onHeadersReceived: filter: OnHeadersReceivedFilter * listener: Function -> unit
        /// The listener will be called with listener(details, callback) when HTTP response
        /// headers of a request have been received. The callback has to be called with an
        /// response object.
        abstract onHeadersReceived: listener: Function -> unit
        /// The listener will be called with listener(details) when first byte of the
        /// response body is received. For HTTP requests, this means that the status line
        /// and response headers are available.
        abstract onResponseStarted: listener: (OnResponseStartedDetails -> unit) -> unit
        /// The listener will be called with listener(details) when first byte of the
        /// response body is received. For HTTP requests, this means that the status line
        /// and response headers are available.
        abstract onResponseStarted: filter: OnResponseStartedFilter * listener: (OnResponseStartedDetails -> unit) -> unit
        /// The listener will be called with listener(details) just before a request is
        /// going to be sent to the server, modifications of previous onBeforeSendHeaders
        /// response are visible by the time this listener is fired.
        abstract onSendHeaders: filter: OnSendHeadersFilter * listener: (OnSendHeadersDetails -> unit) -> unit
        /// The listener will be called with listener(details) just before a request is
        /// going to be sent to the server, modifications of previous onBeforeSendHeaders
        /// response are visible by the time this listener is fired.
        abstract onSendHeaders: listener: (OnSendHeadersDetails -> unit) -> unit

    type [<AllowNullLiteral>] WebRequestStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> WebRequest

    type [<AllowNullLiteral>] WebviewTag =
        inherit HTMLElement
        /// Fired when a load has committed. This includes navigation within the current
        /// document as well as subframe document-level loads, but does not include
        /// asynchronous resource loads.
        [<Emit "$0.addEventListener('load-commit',$1,$2)">] abstract ``addEventListener_load-commit``: listener: (LoadCommitEvent -> unit) * ?useCapture: bool -> WebviewTag
        [<Emit "$0.removeEventListener('load-commit',$1)">] abstract ``removeEventListener_load-commit``: listener: (LoadCommitEvent -> unit) -> WebviewTag
        /// Fired when the navigation is done, i.e. the spinner of the tab will stop
        /// spinning, and the onload event is dispatched.
        [<Emit "$0.addEventListener('did-finish-load',$1,$2)">] abstract ``addEventListener_did-finish-load``: listener: (Event -> unit) * ?useCapture: bool -> WebviewTag
        [<Emit "$0.removeEventListener('did-finish-load',$1)">] abstract ``removeEventListener_did-finish-load``: listener: (Event -> unit) -> WebviewTag
        /// This event is like did-finish-load, but fired when the load failed or was
        /// cancelled, e.g. window.stop() is invoked.
        [<Emit "$0.addEventListener('did-fail-load',$1,$2)">] abstract ``addEventListener_did-fail-load``: listener: (DidFailLoadEvent -> unit) * ?useCapture: bool -> WebviewTag
        [<Emit "$0.removeEventListener('did-fail-load',$1)">] abstract ``removeEventListener_did-fail-load``: listener: (DidFailLoadEvent -> unit) -> WebviewTag
        /// Fired when a frame has done navigation.
        [<Emit "$0.addEventListener('did-frame-finish-load',$1,$2)">] abstract ``addEventListener_did-frame-finish-load``: listener: (DidFrameFinishLoadEvent -> unit) * ?useCapture: bool -> WebviewTag
        [<Emit "$0.removeEventListener('did-frame-finish-load',$1)">] abstract ``removeEventListener_did-frame-finish-load``: listener: (DidFrameFinishLoadEvent -> unit) -> WebviewTag
        /// Corresponds to the points in time when the spinner of the tab starts spinning.
        [<Emit "$0.addEventListener('did-start-loading',$1,$2)">] abstract ``addEventListener_did-start-loading``: listener: (Event -> unit) * ?useCapture: bool -> WebviewTag
        [<Emit "$0.removeEventListener('did-start-loading',$1)">] abstract ``removeEventListener_did-start-loading``: listener: (Event -> unit) -> WebviewTag
        /// Corresponds to the points in time when the spinner of the tab stops spinning.
        [<Emit "$0.addEventListener('did-stop-loading',$1,$2)">] abstract ``addEventListener_did-stop-loading``: listener: (Event -> unit) * ?useCapture: bool -> WebviewTag
        [<Emit "$0.removeEventListener('did-stop-loading',$1)">] abstract ``removeEventListener_did-stop-loading``: listener: (Event -> unit) -> WebviewTag
        /// Fired when details regarding a requested resource is available. status indicates
        /// socket connection to download the resource.
        [<Emit "$0.addEventListener('did-get-response-details',$1,$2)">] abstract ``addEventListener_did-get-response-details``: listener: (DidGetResponseDetailsEvent -> unit) * ?useCapture: bool -> WebviewTag
        [<Emit "$0.removeEventListener('did-get-response-details',$1)">] abstract ``removeEventListener_did-get-response-details``: listener: (DidGetResponseDetailsEvent -> unit) -> WebviewTag
        /// Fired when a redirect was received while requesting a resource.
        [<Emit "$0.addEventListener('did-get-redirect-request',$1,$2)">] abstract ``addEventListener_did-get-redirect-request``: listener: (DidGetRedirectRequestEvent -> unit) * ?useCapture: bool -> WebviewTag
        [<Emit "$0.removeEventListener('did-get-redirect-request',$1)">] abstract ``removeEventListener_did-get-redirect-request``: listener: (DidGetRedirectRequestEvent -> unit) -> WebviewTag
        /// Fired when document in the given frame is loaded.
        [<Emit "$0.addEventListener('dom-ready',$1,$2)">] abstract ``addEventListener_dom-ready``: listener: (Event -> unit) * ?useCapture: bool -> WebviewTag
        [<Emit "$0.removeEventListener('dom-ready',$1)">] abstract ``removeEventListener_dom-ready``: listener: (Event -> unit) -> WebviewTag
        /// Fired when page title is set during navigation. explicitSet is false when title
        /// is synthesized from file url.
        [<Emit "$0.addEventListener('page-title-updated',$1,$2)">] abstract ``addEventListener_page-title-updated``: listener: (PageTitleUpdatedEvent -> unit) * ?useCapture: bool -> WebviewTag
        [<Emit "$0.removeEventListener('page-title-updated',$1)">] abstract ``removeEventListener_page-title-updated``: listener: (PageTitleUpdatedEvent -> unit) -> WebviewTag
        /// Fired when page receives favicon urls.
        [<Emit "$0.addEventListener('page-favicon-updated',$1,$2)">] abstract ``addEventListener_page-favicon-updated``: listener: (PageFaviconUpdatedEvent -> unit) * ?useCapture: bool -> WebviewTag
        [<Emit "$0.removeEventListener('page-favicon-updated',$1)">] abstract ``removeEventListener_page-favicon-updated``: listener: (PageFaviconUpdatedEvent -> unit) -> WebviewTag
        /// Fired when page enters fullscreen triggered by HTML API.
        [<Emit "$0.addEventListener('enter-html-full-screen',$1,$2)">] abstract ``addEventListener_enter-html-full-screen``: listener: (Event -> unit) * ?useCapture: bool -> WebviewTag
        [<Emit "$0.removeEventListener('enter-html-full-screen',$1)">] abstract ``removeEventListener_enter-html-full-screen``: listener: (Event -> unit) -> WebviewTag
        /// Fired when page leaves fullscreen triggered by HTML API.
        [<Emit "$0.addEventListener('leave-html-full-screen',$1,$2)">] abstract ``addEventListener_leave-html-full-screen``: listener: (Event -> unit) * ?useCapture: bool -> WebviewTag
        [<Emit "$0.removeEventListener('leave-html-full-screen',$1)">] abstract ``removeEventListener_leave-html-full-screen``: listener: (Event -> unit) -> WebviewTag
        /// Fired when the guest window logs a console message. The following example code
        /// forwards all log messages to the embedder's console without regard for log level
        /// or other properties.
        [<Emit "$0.addEventListener('console-message',$1,$2)">] abstract ``addEventListener_console-message``: listener: (ConsoleMessageEvent -> unit) * ?useCapture: bool -> WebviewTag
        [<Emit "$0.removeEventListener('console-message',$1)">] abstract ``removeEventListener_console-message``: listener: (ConsoleMessageEvent -> unit) -> WebviewTag
        /// Fired when a result is available for webview.findInPage request.
        [<Emit "$0.addEventListener('found-in-page',$1,$2)">] abstract ``addEventListener_found-in-page``: listener: (FoundInPageEvent -> unit) * ?useCapture: bool -> WebviewTag
        [<Emit "$0.removeEventListener('found-in-page',$1)">] abstract ``removeEventListener_found-in-page``: listener: (FoundInPageEvent -> unit) -> WebviewTag
        /// Fired when the guest page attempts to open a new browser window. The following
        /// example code opens the new url in system's default browser.
        [<Emit "$0.addEventListener('new-window',$1,$2)">] abstract ``addEventListener_new-window``: listener: (NewWindowEvent -> unit) * ?useCapture: bool -> WebviewTag
        [<Emit "$0.removeEventListener('new-window',$1)">] abstract ``removeEventListener_new-window``: listener: (NewWindowEvent -> unit) -> WebviewTag
        /// Emitted when a user or the page wants to start navigation. It can happen when
        /// the window.location object is changed or a user clicks a link in the page. This
        /// event will not emit when the navigation is started programmatically with APIs
        /// like <webview>.loadURL and <webview>.back. It is also not emitted during in-page
        /// navigation, such as clicking anchor links or updating the window.location.hash.
        /// Use did-navigate-in-page event for this purpose. Calling event.preventDefault()
        /// does NOT have any effect.
        [<Emit "$0.addEventListener('will-navigate',$1,$2)">] abstract ``addEventListener_will-navigate``: listener: (WillNavigateEvent -> unit) * ?useCapture: bool -> WebviewTag
        [<Emit "$0.removeEventListener('will-navigate',$1)">] abstract ``removeEventListener_will-navigate``: listener: (WillNavigateEvent -> unit) -> WebviewTag
        /// Emitted when a navigation is done. This event is not emitted for in-page
        /// navigations, such as clicking anchor links or updating the window.location.hash.
        /// Use did-navigate-in-page event for this purpose.
        [<Emit "$0.addEventListener('did-navigate',$1,$2)">] abstract ``addEventListener_did-navigate``: listener: (DidNavigateEvent -> unit) * ?useCapture: bool -> WebviewTag
        [<Emit "$0.removeEventListener('did-navigate',$1)">] abstract ``removeEventListener_did-navigate``: listener: (DidNavigateEvent -> unit) -> WebviewTag
        /// Emitted when an in-page navigation happened. When in-page navigation happens,
        /// the page URL changes but does not cause navigation outside of the page. Examples
        /// of this occurring are when anchor links are clicked or when the DOM hashchange
        /// event is triggered.
        [<Emit "$0.addEventListener('did-navigate-in-page',$1,$2)">] abstract ``addEventListener_did-navigate-in-page``: listener: (DidNavigateInPageEvent -> unit) * ?useCapture: bool -> WebviewTag
        [<Emit "$0.removeEventListener('did-navigate-in-page',$1)">] abstract ``removeEventListener_did-navigate-in-page``: listener: (DidNavigateInPageEvent -> unit) -> WebviewTag
        /// Fired when the guest page attempts to close itself. The following example code
        /// navigates the webview to about:blank when the guest attempts to close itself.
        [<Emit "$0.addEventListener('close',$1,$2)">] abstract addEventListener_close: listener: (Event -> unit) * ?useCapture: bool -> WebviewTag
        [<Emit "$0.removeEventListener('close',$1)">] abstract removeEventListener_close: listener: (Event -> unit) -> WebviewTag
        /// Fired when the guest page has sent an asynchronous message to embedder page.
        /// With sendToHost method and ipc-message event you can easily communicate between
        /// guest page and embedder page:
        [<Emit "$0.addEventListener('ipc-message',$1,$2)">] abstract ``addEventListener_ipc-message``: listener: (IpcMessageEvent -> unit) * ?useCapture: bool -> WebviewTag
        [<Emit "$0.removeEventListener('ipc-message',$1)">] abstract ``removeEventListener_ipc-message``: listener: (IpcMessageEvent -> unit) -> WebviewTag
        /// Fired when the renderer process is crashed.
        [<Emit "$0.addEventListener('crashed',$1,$2)">] abstract addEventListener_crashed: listener: (Event -> unit) * ?useCapture: bool -> WebviewTag
        [<Emit "$0.removeEventListener('crashed',$1)">] abstract removeEventListener_crashed: listener: (Event -> unit) -> WebviewTag
        /// Fired when the gpu process is crashed.
        [<Emit "$0.addEventListener('gpu-crashed',$1,$2)">] abstract ``addEventListener_gpu-crashed``: listener: (Event -> unit) * ?useCapture: bool -> WebviewTag
        [<Emit "$0.removeEventListener('gpu-crashed',$1)">] abstract ``removeEventListener_gpu-crashed``: listener: (Event -> unit) -> WebviewTag
        /// Fired when a plugin process is crashed.
        [<Emit "$0.addEventListener('plugin-crashed',$1,$2)">] abstract ``addEventListener_plugin-crashed``: listener: (PluginCrashedEvent -> unit) * ?useCapture: bool -> WebviewTag
        [<Emit "$0.removeEventListener('plugin-crashed',$1)">] abstract ``removeEventListener_plugin-crashed``: listener: (PluginCrashedEvent -> unit) -> WebviewTag
        /// Fired when the WebContents is destroyed.
        [<Emit "$0.addEventListener('destroyed',$1,$2)">] abstract addEventListener_destroyed: listener: (Event -> unit) * ?useCapture: bool -> WebviewTag
        [<Emit "$0.removeEventListener('destroyed',$1)">] abstract removeEventListener_destroyed: listener: (Event -> unit) -> WebviewTag
        /// Emitted when media starts playing.
        [<Emit "$0.addEventListener('media-started-playing',$1,$2)">] abstract ``addEventListener_media-started-playing``: listener: (Event -> unit) * ?useCapture: bool -> WebviewTag
        [<Emit "$0.removeEventListener('media-started-playing',$1)">] abstract ``removeEventListener_media-started-playing``: listener: (Event -> unit) -> WebviewTag
        /// Emitted when media is paused or done playing.
        [<Emit "$0.addEventListener('media-paused',$1,$2)">] abstract ``addEventListener_media-paused``: listener: (Event -> unit) * ?useCapture: bool -> WebviewTag
        [<Emit "$0.removeEventListener('media-paused',$1)">] abstract ``removeEventListener_media-paused``: listener: (Event -> unit) -> WebviewTag
        /// Emitted when a page's theme color changes. This is usually due to encountering a
        /// meta tag:
        [<Emit "$0.addEventListener('did-change-theme-color',$1,$2)">] abstract ``addEventListener_did-change-theme-color``: listener: (DidChangeThemeColorEvent -> unit) * ?useCapture: bool -> WebviewTag
        [<Emit "$0.removeEventListener('did-change-theme-color',$1)">] abstract ``removeEventListener_did-change-theme-color``: listener: (DidChangeThemeColorEvent -> unit) -> WebviewTag
        /// Emitted when mouse moves over a link or the keyboard moves the focus to a link.
        [<Emit "$0.addEventListener('update-target-url',$1,$2)">] abstract ``addEventListener_update-target-url``: listener: (UpdateTargetUrlEvent -> unit) * ?useCapture: bool -> WebviewTag
        [<Emit "$0.removeEventListener('update-target-url',$1)">] abstract ``removeEventListener_update-target-url``: listener: (UpdateTargetUrlEvent -> unit) -> WebviewTag
        /// Emitted when DevTools is opened.
        [<Emit "$0.addEventListener('devtools-opened',$1,$2)">] abstract ``addEventListener_devtools-opened``: listener: (Event -> unit) * ?useCapture: bool -> WebviewTag
        [<Emit "$0.removeEventListener('devtools-opened',$1)">] abstract ``removeEventListener_devtools-opened``: listener: (Event -> unit) -> WebviewTag
        /// Emitted when DevTools is closed.
        [<Emit "$0.addEventListener('devtools-closed',$1,$2)">] abstract ``addEventListener_devtools-closed``: listener: (Event -> unit) * ?useCapture: bool -> WebviewTag
        [<Emit "$0.removeEventListener('devtools-closed',$1)">] abstract ``removeEventListener_devtools-closed``: listener: (Event -> unit) -> WebviewTag
        /// Emitted when DevTools is focused / opened.
        [<Emit "$0.addEventListener('devtools-focused',$1,$2)">] abstract ``addEventListener_devtools-focused``: listener: (Event -> unit) * ?useCapture: bool -> WebviewTag
        [<Emit "$0.removeEventListener('devtools-focused',$1)">] abstract ``removeEventListener_devtools-focused``: listener: (Event -> unit) -> WebviewTag
        abstract addEventListener: ``type``: 'K * listener: (HTMLElement -> HTMLElementEventMap -> obj option) * ?useCapture: bool -> unit
        abstract addEventListener: ``type``: string * listener: EventListenerOrEventListenerObject * ?useCapture: bool -> unit
        abstract removeEventListener: ``type``: 'K * listener: (HTMLElement -> HTMLElementEventMap -> obj option) * ?useCapture: bool -> unit
        abstract removeEventListener: ``type``: string * listener: EventListenerOrEventListenerObject * ?useCapture: bool -> unit
        abstract canGoBack: unit -> bool
        abstract canGoForward: unit -> bool
        abstract canGoToOffset: offset: float -> bool
        /// Captures a snapshot of the webview's page. Same as
        /// webContents.capturePage([rect, ]callback).
        abstract capturePage: callback: (NativeImage -> unit) -> unit
        /// Captures a snapshot of the webview's page. Same as
        /// webContents.capturePage([rect, ]callback).
        abstract capturePage: rect: Rectangle * callback: (NativeImage -> unit) -> unit
        /// Clears the navigation history.
        abstract clearHistory: unit -> unit
        /// Closes the DevTools window of guest page.
        abstract closeDevTools: unit -> unit
        /// Executes editing command copy in page.
        abstract copy: unit -> unit
        /// Executes editing command cut in page.
        abstract cut: unit -> unit
        /// Executes editing command delete in page.
        abstract delete: unit -> unit
        /// Evaluates code in page. If userGesture is set, it will create the user gesture
        /// context in the page. HTML APIs like requestFullScreen, which require user
        /// action, can take advantage of this option for automation.
        abstract executeJavaScript: code: string * ?userGesture: bool * ?callback: (obj option -> unit) -> unit
        /// Starts a request to find all matches for the text in the web page. The result of
        /// the request can be obtained by subscribing to found-in-page event.
        abstract findInPage: text: string * ?options: FindInPageOptions -> float
        abstract getTitle: unit -> string
        abstract getURL: unit -> string
        abstract getUserAgent: unit -> string
        abstract getWebContents: unit -> WebContents
        /// Makes the guest page go back.
        abstract goBack: unit -> unit
        /// Makes the guest page go forward.
        abstract goForward: unit -> unit
        /// Navigates to the specified absolute index.
        abstract goToIndex: index: float -> unit
        /// Navigates to the specified offset from the "current entry".
        abstract goToOffset: offset: float -> unit
        /// Injects CSS into the guest page.
        abstract insertCSS: css: string -> unit
        /// Inserts text to the focused element.
        abstract insertText: text: string -> unit
        /// Starts inspecting element at position (x, y) of guest page.
        abstract inspectElement: x: float * y: float -> unit
        /// Opens the DevTools for the service worker context present in the guest page.
        abstract inspectServiceWorker: unit -> unit
        abstract isAudioMuted: unit -> bool
        abstract isCrashed: unit -> bool
        abstract isDevToolsFocused: unit -> bool
        abstract isDevToolsOpened: unit -> bool
        abstract isLoading: unit -> bool
        abstract isWaitingForResponse: unit -> bool
        /// Loads the url in the webview, the url must contain the protocol prefix, e.g. the
        /// http:// or file://.
        abstract loadURL: url: string * ?options: LoadURLOptions -> unit
        /// Opens a DevTools window for guest page.
        abstract openDevTools: unit -> unit
        /// Executes editing command paste in page.
        abstract paste: unit -> unit
        /// Executes editing command pasteAndMatchStyle in page.
        abstract pasteAndMatchStyle: unit -> unit
        /// Prints webview's web page. Same as webContents.print([options]).
        abstract print: ?options: PrintOptions -> unit
        /// Prints webview's web page as PDF, Same as webContents.printToPDF(options,
        /// callback).
        abstract printToPDF: options: PrintToPDFOptions * callback: (Error -> Buffer -> unit) -> unit
        /// Executes editing command redo in page.
        abstract redo: unit -> unit
        /// Reloads the guest page.
        abstract reload: unit -> unit
        /// Reloads the guest page and ignores cache.
        abstract reloadIgnoringCache: unit -> unit
        /// Executes editing command replace in page.
        abstract replace: text: string -> unit
        /// Executes editing command replaceMisspelling in page.
        abstract replaceMisspelling: text: string -> unit
        /// Executes editing command selectAll in page.
        abstract selectAll: unit -> unit
        /// Send an asynchronous message to renderer process via channel, you can also send
        /// arbitrary arguments. The renderer process can handle the message by listening to
        /// the channel event with the ipcRenderer module. See webContents.send for
        /// examples.
        abstract send: channel: string * [<ParamArray>] args: ResizeArray<obj option> -> unit
        /// Sends an input event to the page. See webContents.sendInputEvent for detailed
        /// description of event object.
        abstract sendInputEvent: ``event``: obj option -> unit
        /// Set guest page muted.
        abstract setAudioMuted: muted: bool -> unit
        /// Overrides the user agent for the guest page.
        abstract setUserAgent: userAgent: string -> unit
        /// Changes the zoom factor to the specified factor. Zoom factor is zoom percent
        /// divided by 100, so 300% = 3.0.
        abstract setZoomFactor: factor: float -> unit
        /// Changes the zoom level to the specified level. The original size is 0 and each
        /// increment above or below represents zooming 20% larger or smaller to default
        /// limits of 300% and 50% of original size, respectively.
        abstract setZoomLevel: level: float -> unit
        /// Shows pop-up dictionary that searches the selected word on the page.
        abstract showDefinitionForSelection: unit -> unit
        /// Stops any pending navigation.
        abstract stop: unit -> unit
        /// Stops any findInPage request for the webview with the provided action.
        abstract stopFindInPage: action: U3<string, string, string> -> unit
        /// Executes editing command undo in page.
        abstract undo: unit -> unit
        /// Executes editing command unselect in page.
        abstract unselect: unit -> unit
        /// When this attribute is present the guest page will be allowed to open new
        /// windows. Popups are disabled by default.
        abstract allowpopups: string option with get, set
        /// When this attribute is present the webview container will automatically resize
        /// within the bounds specified by the attributes minwidth, minheight, maxwidth, and
        /// maxheight. These constraints do not impact the webview unless autosize is
        /// enabled. When autosize is enabled, the webview container size cannot be less
        /// than the minimum values or greater than the maximum.
        abstract autosize: string option with get, set
        /// A list of strings which specifies the blink features to be enabled separated by
        /// ,. The full list of supported feature strings can be found in the
        /// RuntimeEnabledFeatures.json5 file.
        abstract blinkfeatures: string option with get, set
        /// A list of strings which specifies the blink features to be disabled separated by
        /// ,. The full list of supported feature strings can be found in the
        /// RuntimeEnabledFeatures.json5 file.
        abstract disableblinkfeatures: string option with get, set
        /// When this attribute is present the webview contents will be prevented from
        /// resizing when the webview element itself is resized. This can be used in
        /// combination with webContents.setSize to manually resize the webview contents in
        /// reaction to a window size change. This can make resizing faster compared to
        /// relying on the webview element bounds to automatically resize the contents.
        abstract disableguestresize: string option with get, set
        /// When this attribute is present the guest page will have web security disabled.
        /// Web security is enabled by default.
        abstract disablewebsecurity: string option with get, set
        /// A value that links the webview to a specific webContents. When a webview first
        /// loads a new webContents is created and this attribute is set to its instance
        /// identifier. Setting this attribute on a new or existing webview connects it to
        /// the existing webContents that currently renders in a different webview. The
        /// existing webview will see the destroy event and will then create a new
        /// webContents when a new url is loaded.
        abstract guestinstance: string option with get, set
        /// Sets the referrer URL for the guest page.
        abstract httpreferrer: string option with get, set
        /// When this attribute is present the guest page in webview will have node
        /// integration and can use node APIs like require and process to access low level
        /// system resources. Node integration is disabled by default in the guest page.
        abstract nodeintegration: string option with get, set
        /// Sets the session used by the page. If partition starts with persist:, the page
        /// will use a persistent session available to all pages in the app with the same
        /// partition. if there is no persist: prefix, the page will use an in-memory
        /// session. By assigning the same partition, multiple pages can share the same
        /// session. If the partition is unset then default session of the app will be used.
        /// This value can only be modified before the first navigation, since the session
        /// of an active renderer process cannot change. Subsequent attempts to modify the
        /// value will fail with a DOM exception.
        abstract partition: string option with get, set
        /// When this attribute is present the guest page in webview will be able to use
        /// browser plugins. Plugins are disabled by default.
        abstract plugins: string option with get, set
        /// Specifies a script that will be loaded before other scripts run in the guest
        /// page. The protocol of script's URL must be either file: or asar:, because it
        /// will be loaded by require in guest page under the hood. When the guest page
        /// doesn't have node integration this script will still have access to all Node
        /// APIs, but global objects injected by Node will be deleted after this script has
        /// finished executing. Note: This option will be appear as preloadURL (not preload)
        /// in the webPreferences specified to the will-attach-webview event.
        abstract preload: string option with get, set
        /// Returns the visible URL. Writing to this attribute initiates top-level
        /// navigation. Assigning src its own value will reload the current page. The src
        /// attribute can also accept data URLs, such as data:text/plain,Hello, world!.
        abstract src: string option with get, set
        /// Sets the user agent for the guest page before the page is navigated to. Once the
        /// page is loaded, use the setUserAgent method to change the user agent.
        abstract useragent: string option with get, set
        /// A list of strings which specifies the web preferences to be set on the webview,
        /// separated by ,. The full list of supported preference strings can be found in
        /// BrowserWindow. The string follows the same format as the features string in
        /// window.open. A name by itself is given a true boolean value. A preference can be
        /// set to another value by including an =, followed by the value. Special values
        /// yes and 1 are interpreted as true, while no and 0 are interpreted as false.
        abstract webpreferences: string option with get, set

    type [<AllowNullLiteral>] AboutPanelOptionsOptions =
        /// The app's name.
        abstract applicationName: string option with get, set
        /// The app's version.
        abstract applicationVersion: string option with get, set
        /// Copyright information.
        abstract copyright: string option with get, set
        /// Credit information.
        abstract credits: string option with get, set
        /// The app's build version number.
        abstract version: string option with get, set

    type [<AllowNullLiteral>] AddRepresentationOptions =
        /// The scale factor to add the image representation for.
        abstract scaleFactor: float with get, set
        /// Defaults to 0. Required if a bitmap buffer is specified as buffer.
        abstract width: float option with get, set
        /// Defaults to 0. Required if a bitmap buffer is specified as buffer.
        abstract height: float option with get, set
        /// The buffer containing the raw image data.
        abstract buffer: Buffer option with get, set
        /// The data URL containing either a base 64 encoded PNG or JPEG image.
        abstract dataURL: string option with get, set

    type [<AllowNullLiteral>] AppDetailsOptions =
        /// Window's . It has to be set, otherwise the other options will have no effect.
        abstract appId: string option with get, set
        /// Window's .
        abstract appIconPath: string option with get, set
        /// Index of the icon in appIconPath. Ignored when appIconPath is not set. Default
        /// is 0.
        abstract appIconIndex: float option with get, set
        /// Window's .
        abstract relaunchCommand: string option with get, set
        /// Window's .
        abstract relaunchDisplayName: string option with get, set

    type [<AllowNullLiteral>] AuthInfo =
        abstract isProxy: bool with get, set
        abstract scheme: string with get, set
        abstract host: string with get, set
        abstract port: float with get, set
        abstract realm: string with get, set

    type [<AllowNullLiteral>] AutoResizeOptions =
        /// If true, the view's width will grow and shrink together with the window. false
        /// by default.
        abstract width: bool with get, set
        /// If true, the view's height will grow and shrink together with the window. false
        /// by default.
        abstract height: bool with get, set

    type [<AllowNullLiteral>] BitmapOptions =
        /// Defaults to 1.0.
        abstract scaleFactor: float option with get, set

    type [<AllowNullLiteral>] BrowserViewConstructorOptions =
        /// See .
        abstract webPreferences: WebPreferences option with get, set

    type [<AllowNullLiteral>] BrowserWindowConstructorOptions =
        /// Window's width in pixels. Default is 800.
        abstract width: float option with get, set
        /// Window's height in pixels. Default is 600.
        abstract height: float option with get, set
        /// ( if y is used) Window's left offset from screen. Default is to center the
        /// window.
        abstract x: float option with get, set
        /// ( if x is used) Window's top offset from screen. Default is to center the
        /// window.
        abstract y: float option with get, set
        /// The width and height would be used as web page's size, which means the actual
        /// window's size will include window frame's size and be slightly larger. Default
        /// is false.
        abstract useContentSize: bool option with get, set
        /// Show window in the center of the screen.
        abstract center: bool option with get, set
        /// Window's minimum width. Default is 0.
        abstract minWidth: float option with get, set
        /// Window's minimum height. Default is 0.
        abstract minHeight: float option with get, set
        /// Window's maximum width. Default is no limit.
        abstract maxWidth: float option with get, set
        /// Window's maximum height. Default is no limit.
        abstract maxHeight: float option with get, set
        /// Whether window is resizable. Default is true.
        abstract resizable: bool option with get, set
        /// Whether window is movable. This is not implemented on Linux. Default is true.
        abstract movable: bool option with get, set
        /// Whether window is minimizable. This is not implemented on Linux. Default is
        /// true.
        abstract minimizable: bool option with get, set
        /// Whether window is maximizable. This is not implemented on Linux. Default is
        /// true.
        abstract maximizable: bool option with get, set
        /// Whether window is closable. This is not implemented on Linux. Default is true.
        abstract closable: bool option with get, set
        /// Whether the window can be focused. Default is true. On Windows setting
        /// focusable: false also implies setting skipTaskbar: true. On Linux setting
        /// focusable: false makes the window stop interacting with wm, so the window will
        /// always stay on top in all workspaces.
        abstract focusable: bool option with get, set
        /// Whether the window should always stay on top of other windows. Default is false.
        abstract alwaysOnTop: bool option with get, set
        /// Whether the window should show in fullscreen. When explicitly set to false the
        /// fullscreen button will be hidden or disabled on macOS. Default is false.
        abstract fullscreen: bool option with get, set
        /// Whether the window can be put into fullscreen mode. On macOS, also whether the
        /// maximize/zoom button should toggle full screen mode or maximize window. Default
        /// is true.
        abstract fullscreenable: bool option with get, set
        /// Use pre-Lion fullscreen on macOS. Default is false.
        abstract simpleFullscreen: bool option with get, set
        /// Whether to show the window in taskbar. Default is false.
        abstract skipTaskbar: bool option with get, set
        /// The kiosk mode. Default is false.
        abstract kiosk: bool option with get, set
        /// Default window title. Default is "Electron".
        abstract title: string option with get, set
        /// The window icon. On Windows it is recommended to use ICO icons to get best
        /// visual effects, you can also leave it undefined so the executable's icon will be
        /// used.
        abstract icon: U2<NativeImage, string> option with get, set
        /// Whether window should be shown when created. Default is true.
        abstract show: bool option with get, set
        /// Specify false to create a . Default is true.
        abstract frame: bool option with get, set
        /// Specify parent window. Default is null.
        abstract parent: BrowserWindow option with get, set
        /// Whether this is a modal window. This only works when the window is a child
        /// window. Default is false.
        abstract modal: bool option with get, set
        /// Whether the web view accepts a single mouse-down event that simultaneously
        /// activates the window. Default is false.
        abstract acceptFirstMouse: bool option with get, set
        /// Whether to hide cursor when typing. Default is false.
        abstract disableAutoHideCursor: bool option with get, set
        /// Auto hide the menu bar unless the Alt key is pressed. Default is false.
        abstract autoHideMenuBar: bool option with get, set
        /// Enable the window to be resized larger than screen. Default is false.
        abstract enableLargerThanScreen: bool option with get, set
        /// Window's background color as a hexadecimal value, like #66CD00 or #FFF or
        /// #80FFFFFF (alpha is supported). Default is #FFF (white).
        abstract backgroundColor: string option with get, set
        /// Whether window should have a shadow. This is only implemented on macOS. Default
        /// is true.
        abstract hasShadow: bool option with get, set
        /// Set the initial opacity of the window, between 0.0 (fully transparent) and 1.0
        /// (fully opaque). This is only implemented on Windows and macOS.
        abstract opacity: float option with get, set
        /// Forces using dark theme for the window, only works on some GTK+3 desktop
        /// environments. Default is false.
        abstract darkTheme: bool option with get, set
        /// Makes the window . Default is false.
        abstract transparent: bool option with get, set
        /// The type of window, default is normal window. See more about this below.
        abstract ``type``: string option with get, set
        /// The style of window title bar. Default is default. Possible values are:
        abstract titleBarStyle: U5<string, string, string, string, string> option with get, set
        /// Shows the title in the tile bar in full screen mode on macOS for all
        /// titleBarStyle options. Default is false.
        abstract fullscreenWindowTitle: bool option with get, set
        /// Use WS_THICKFRAME style for frameless windows on Windows, which adds standard
        /// window frame. Setting it to false will remove window shadow and window
        /// animations. Default is true.
        abstract thickFrame: bool option with get, set
        /// Add a type of vibrancy effect to the window, only on macOS. Can be
        /// appearance-based, light, dark, titlebar, selection, menu, popover, sidebar,
        /// medium-light or ultra-dark.
        abstract vibrancy: obj option with get, set
        /// Controls the behavior on macOS when option-clicking the green stoplight button
        /// on the toolbar or by clicking the Window > Zoom menu item. If true, the window
        /// will grow to the preferred width of the web page when zoomed, false will cause
        /// it to zoom to the width of the screen. This will also affect the behavior when
        /// calling maximize() directly. Default is false.
        abstract zoomToPageWidth: bool option with get, set
        /// Tab group name, allows opening the window as a native tab on macOS 10.12+.
        /// Windows with the same tabbing identifier will be grouped together. This also
        /// adds a native new tab button to your window's tab bar and allows your app and
        /// window to receive the new-window-for-tab event.
        abstract tabbingIdentifier: string option with get, set
        /// Settings of web page's features.
        abstract webPreferences: WebPreferences option with get, set

    type [<AllowNullLiteral>] CertificateTrustDialogOptions =
        /// The certificate to trust/import.
        abstract certificate: Certificate with get, set
        /// The message to display to the user.
        abstract message: string with get, set

    type [<AllowNullLiteral>] CertificateVerifyProcRequest =
        abstract hostname: string with get, set
        abstract certificate: Certificate with get, set
        /// Verification result from chromium.
        abstract verificationResult: string with get, set
        /// Error code.
        abstract errorCode: float with get, set

    type [<AllowNullLiteral>] ClearStorageDataOptions =
        /// Should follow window.location.origin’s representation scheme://host:port.
        abstract origin: string option with get, set
        /// The types of storages to clear, can contain: appcache, cookies, filesystem,
        /// indexdb, localstorage, shadercache, websql, serviceworkers
        abstract storages: ResizeArray<string> option with get, set
        /// The types of quotas to clear, can contain: temporary, persistent, syncable.
        abstract quotas: ResizeArray<string> option with get, set

    type [<AllowNullLiteral>] CommandLine =
        /// Append a switch (with optional value) to Chromium's command line. Note: This
        /// will not affect process.argv, and is mainly used by developers to control some
        /// low-level Chromium behaviors.
        abstract appendSwitch: (string -> string -> unit) with get, set
        /// Append an argument to Chromium's command line. The argument will be quoted
        /// correctly. Note: This will not affect process.argv.
        abstract appendArgument: (string -> unit) with get, set

    type [<AllowNullLiteral>] Config =
        /// The URL associated with the PAC file.
        abstract pacScript: string with get, set
        /// Rules indicating which proxies to use.
        abstract proxyRules: string with get, set
        /// Rules indicating which URLs should bypass the proxy settings.
        abstract proxyBypassRules: string with get, set

    type [<AllowNullLiteral>] ConsoleMessageEvent =
        inherit Event
        abstract level: float with get, set
        abstract message: string with get, set
        abstract line: float with get, set
        abstract sourceId: string with get, set

    type [<AllowNullLiteral>] ContextMenuParams =
        /// x coordinate
        abstract x: float with get, set
        /// y coordinate
        abstract y: float with get, set
        /// URL of the link that encloses the node the context menu was invoked on.
        abstract linkURL: string with get, set
        /// Text associated with the link. May be an empty string if the contents of the
        /// link are an image.
        abstract linkText: string with get, set
        /// URL of the top level page that the context menu was invoked on.
        abstract pageURL: string with get, set
        /// URL of the subframe that the context menu was invoked on.
        abstract frameURL: string with get, set
        /// Source URL for the element that the context menu was invoked on. Elements with
        /// source URLs are images, audio and video.
        abstract srcURL: string with get, set
        /// Type of the node the context menu was invoked on. Can be none, image, audio,
        /// video, canvas, file or plugin.
        abstract mediaType: U7<string, string, string, string, string, string, string> with get, set
        /// Whether the context menu was invoked on an image which has non-empty contents.
        abstract hasImageContents: bool with get, set
        /// Whether the context is editable.
        abstract isEditable: bool with get, set
        /// Text of the selection that the context menu was invoked on.
        abstract selectionText: string with get, set
        /// Title or alt text of the selection that the context was invoked on.
        abstract titleText: string with get, set
        /// The misspelled word under the cursor, if any.
        abstract misspelledWord: string with get, set
        /// The character encoding of the frame on which the menu was invoked.
        abstract frameCharset: string with get, set
        /// If the context menu was invoked on an input field, the type of that field.
        /// Possible values are none, plainText, password, other.
        abstract inputFieldType: string with get, set
        /// Input source that invoked the context menu. Can be none, mouse, keyboard, touch,
        /// touchMenu.
        abstract menuSourceType: U5<string, string, string, string, string> with get, set
        /// The flags for the media element the context menu was invoked on.
        abstract mediaFlags: MediaFlags with get, set
        /// These flags indicate whether the renderer believes it is able to perform the
        /// corresponding action.
        abstract editFlags: EditFlags with get, set

    type [<AllowNullLiteral>] CrashReporterStartOptions =
        abstract companyName: string option with get, set
        /// URL that crash reports will be sent to as POST.
        abstract submitURL: string with get, set
        /// Defaults to app.getName().
        abstract productName: string option with get, set
        /// Whether crash reports should be sent to the server Default is true.
        abstract uploadToServer: bool option with get, set
        /// Default is false.
        abstract ignoreSystemCrashHandler: bool option with get, set
        /// An object you can define that will be sent along with the report. Only string
        /// properties are sent correctly. Nested objects are not supported and the property
        /// names and values must be less than 64 characters long.
        abstract extra: Extra option with get, set
        /// Directory to store the crashreports temporarily (only used when the crash
        /// reporter is started via process.crashReporter.start)
        abstract crashesDirectory: string option with get, set

    type [<AllowNullLiteral>] CreateFromBufferOptions =
        /// Required for bitmap buffers.
        abstract width: float option with get, set
        /// Required for bitmap buffers.
        abstract height: float option with get, set
        /// Defaults to 1.0.
        abstract scaleFactor: float option with get, set

    type [<AllowNullLiteral>] CreateInterruptedDownloadOptions =
        /// Absolute path of the download.
        abstract path: string with get, set
        /// Complete URL chain for the download.
        abstract urlChain: ResizeArray<string> with get, set
        abstract mimeType: string option with get, set
        /// Start range for the download.
        abstract offset: float with get, set
        /// Total length of the download.
        abstract length: float with get, set
        /// Last-Modified header value.
        abstract lastModified: string with get, set
        /// ETag header value.
        abstract eTag: string with get, set
        /// Time when download was started in number of seconds since UNIX epoch.
        abstract startTime: float option with get, set

    type [<AllowNullLiteral>] Data =
        abstract text: string option with get, set
        abstract html: string option with get, set
        abstract image: NativeImage option with get, set
        abstract rtf: string option with get, set
        /// The title of the url at text.
        abstract bookmark: string option with get, set

    type [<AllowNullLiteral>] Details =
        /// The url to associate the cookie with.
        abstract url: string with get, set
        /// The name of the cookie. Empty by default if omitted.
        abstract name: string option with get, set
        /// The value of the cookie. Empty by default if omitted.
        abstract value: string option with get, set
        /// The domain of the cookie. Empty by default if omitted.
        abstract domain: string option with get, set
        /// The path of the cookie. Empty by default if omitted.
        abstract path: string option with get, set
        /// Whether the cookie should be marked as Secure. Defaults to false.
        abstract secure: bool option with get, set
        /// Whether the cookie should be marked as HTTP only. Defaults to false.
        abstract httpOnly: bool option with get, set
        /// The expiration date of the cookie as the number of seconds since the UNIX epoch.
        /// If omitted then the cookie becomes a session cookie and will not be retained
        /// between sessions.
        abstract expirationDate: float option with get, set

    type [<AllowNullLiteral>] DevToolsExtensions =
        interface end

    type [<AllowNullLiteral>] DidChangeThemeColorEvent =
        inherit Event
        abstract themeColor: string with get, set

    type [<AllowNullLiteral>] DidFailLoadEvent =
        inherit Event
        abstract errorCode: float with get, set
        abstract errorDescription: string with get, set
        abstract validatedURL: string with get, set
        abstract isMainFrame: bool with get, set

    type [<AllowNullLiteral>] DidFrameFinishLoadEvent =
        inherit Event
        abstract isMainFrame: bool with get, set

    type [<AllowNullLiteral>] DidGetRedirectRequestEvent =
        inherit Event
        abstract oldURL: string with get, set
        abstract newURL: string with get, set
        abstract isMainFrame: bool with get, set

    type [<AllowNullLiteral>] DidGetResponseDetailsEvent =
        inherit Event
        abstract status: bool with get, set
        abstract newURL: string with get, set
        abstract originalURL: string with get, set
        abstract httpResponseCode: float with get, set
        abstract requestMethod: string with get, set
        abstract referrer: string with get, set
        abstract headers: Headers with get, set
        abstract resourceType: string with get, set

    type [<AllowNullLiteral>] DidNavigateEvent =
        inherit Event
        abstract url: string with get, set

    type [<AllowNullLiteral>] DidNavigateInPageEvent =
        inherit Event
        abstract isMainFrame: bool with get, set
        abstract url: string with get, set

    type [<AllowNullLiteral>] DisplayBalloonOptions =
        abstract icon: U2<NativeImage, string> option with get, set
        abstract title: string with get, set
        abstract content: string with get, set

    type [<AllowNullLiteral>] Dock =
        /// When critical is passed, the dock icon will bounce until either the application
        /// becomes active or the request is canceled. When informational is passed, the
        /// dock icon will bounce for one second. However, the request remains active until
        /// either the application becomes active or the request is canceled.
        abstract bounce: (U2<string, string> -> float) with get, set
        /// Cancel the bounce of id.
        abstract cancelBounce: (float -> unit) with get, set
        /// Bounces the Downloads stack if the filePath is inside the Downloads folder.
        abstract downloadFinished: (string -> unit) with get, set
        /// Sets the string to be displayed in the dock’s badging area.
        abstract setBadge: (string -> unit) with get, set
        abstract getBadge: (unit -> string) with get, set
        /// Hides the dock icon.
        abstract hide: (unit -> unit) with get, set
        /// Shows the dock icon.
        abstract show: (unit -> unit) with get, set
        abstract isVisible: (unit -> bool) with get, set
        /// Sets the application's dock menu.
        abstract setMenu: (Menu -> unit) with get, set
        /// Sets the image associated with this dock icon.
        abstract setIcon: (U2<NativeImage, string> -> unit) with get, set

    type [<AllowNullLiteral>] EnableNetworkEmulationOptions =
        /// Whether to emulate network outage. Defaults to false.
        abstract offline: bool option with get, set
        /// RTT in ms. Defaults to 0 which will disable latency throttling.
        abstract latency: float option with get, set
        /// Download rate in Bps. Defaults to 0 which will disable download throttling.
        abstract downloadThroughput: float option with get, set
        /// Upload rate in Bps. Defaults to 0 which will disable upload throttling.
        abstract uploadThroughput: float option with get, set

    type [<AllowNullLiteral>] Extensions =
        interface end

    type [<AllowNullLiteral>] FileIconOptions =
        abstract size: U3<string, string, string> with get, set

    type [<AllowNullLiteral>] Filter =
        /// Retrieves cookies which are associated with url. Empty implies retrieving
        /// cookies of all urls.
        abstract url: string option with get, set
        /// Filters cookies by name.
        abstract name: string option with get, set
        /// Retrieves cookies whose domains match or are subdomains of domains
        abstract domain: string option with get, set
        /// Retrieves cookies whose path matches path.
        abstract path: string option with get, set
        /// Filters cookies by their Secure property.
        abstract secure: bool option with get, set
        /// Filters out session or persistent cookies.
        abstract session: bool option with get, set

    type [<AllowNullLiteral>] FindInPageOptions =
        /// Whether to search forward or backward, defaults to true.
        abstract forward: bool option with get, set
        /// Whether the operation is first request or a follow up, defaults to false.
        abstract findNext: bool option with get, set
        /// Whether search should be case-sensitive, defaults to false.
        abstract matchCase: bool option with get, set
        /// Whether to look only at the start of words. defaults to false.
        abstract wordStart: bool option with get, set
        /// When combined with wordStart, accepts a match in the middle of a word if the
        /// match begins with an uppercase letter followed by a lowercase or non-letter.
        /// Accepts several other intra-word matches, defaults to false.
        abstract medialCapitalAsWordStart: bool option with get, set

    type [<AllowNullLiteral>] FoundInPageEvent =
        inherit Event
        abstract result: FoundInPageResult with get, set

    type [<AllowNullLiteral>] FromPartitionOptions =
        /// Whether to enable cache.
        abstract cache: bool with get, set

    type [<AllowNullLiteral>] Header =
        /// Specify an extra header name.
        abstract name: string with get, set

    type [<AllowNullLiteral>] Headers =
        interface end

    type [<AllowNullLiteral>] IgnoreMouseEventsOptions =
        /// If true, forwards mouse move messages to Chromium, enabling mouse related events
        /// such as mouseleave. Only used when ignore is true. If ignore is false,
        /// forwarding is always disabled regardless of this value.
        abstract forward: bool option with get, set

    type [<AllowNullLiteral>] ImportCertificateOptions =
        /// Path for the pkcs12 file.
        abstract certificate: string with get, set
        /// Passphrase for the certificate.
        abstract password: string with get, set

    type [<AllowNullLiteral>] Input =
        /// Either keyUp or keyDown
        abstract ``type``: string with get, set
        /// Equivalent to
        abstract key: string with get, set
        /// Equivalent to
        abstract code: string with get, set
        /// Equivalent to
        abstract isAutoRepeat: bool with get, set
        /// Equivalent to
        abstract shift: bool with get, set
        /// Equivalent to
        abstract control: bool with get, set
        /// Equivalent to
        abstract alt: bool with get, set
        /// Equivalent to
        abstract meta: bool with get, set

    type [<AllowNullLiteral>] InterceptBufferProtocolRequest =
        abstract url: string with get, set
        abstract referrer: string with get, set
        abstract ``method``: string with get, set
        abstract uploadData: ResizeArray<UploadData> with get, set

    type [<AllowNullLiteral>] InterceptFileProtocolRequest =
        abstract url: string with get, set
        abstract referrer: string with get, set
        abstract ``method``: string with get, set
        abstract uploadData: ResizeArray<UploadData> with get, set

    type [<AllowNullLiteral>] InterceptHttpProtocolRequest =
        abstract url: string with get, set
        abstract referrer: string with get, set
        abstract ``method``: string with get, set
        abstract uploadData: ResizeArray<UploadData> with get, set

    type [<AllowNullLiteral>] InterceptStreamProtocolRequest =
        abstract url: string with get, set
        abstract headers: Headers with get, set
        abstract referrer: string with get, set
        abstract ``method``: string with get, set
        abstract uploadData: ResizeArray<UploadData> with get, set

    type [<AllowNullLiteral>] InterceptStringProtocolRequest =
        abstract url: string with get, set
        abstract referrer: string with get, set
        abstract ``method``: string with get, set
        abstract uploadData: ResizeArray<UploadData> with get, set

    type [<AllowNullLiteral>] IpcMessageEvent =
        inherit Event
        abstract channel: string with get, set
        abstract args: ResizeArray<obj option> with get, set

    type [<AllowNullLiteral>] Item =
        /// or files Array The path(s) to the file(s) being dragged.
        abstract file: string with get, set
        /// The image must be non-empty on macOS.
        abstract icon: NativeImage with get, set

    type [<AllowNullLiteral>] JumpListSettings =
        /// The minimum number of items that will be shown in the Jump List (for a more
        /// detailed description of this value see the ).
        abstract minItems: float with get, set
        /// Array of JumpListItem objects that correspond to items that the user has
        /// explicitly removed from custom categories in the Jump List. These items must not
        /// be re-added to the Jump List in the call to app.setJumpList(), Windows will not
        /// display any custom category that contains any of the removed items.
        abstract removedItems: ResizeArray<JumpListItem> with get, set

    type [<AllowNullLiteral>] LoadCommitEvent =
        inherit Event
        abstract url: string with get, set
        abstract isMainFrame: bool with get, set

    type [<AllowNullLiteral>] LoadURLOptions =
        /// A HTTP Referrer url.
        abstract httpReferrer: string option with get, set
        /// A user agent originating the request.
        abstract userAgent: string option with get, set
        /// Extra headers separated by "\n"
        abstract extraHeaders: string option with get, set
        abstract postData: U4<ResizeArray<UploadRawData>, ResizeArray<UploadFile>, ResizeArray<UploadFileSystem>, ResizeArray<UploadBlob>> option with get, set
        /// Base url (with trailing path separator) for files to be loaded by the data url.
        /// This is needed only if the specified url is a data url and needs to load other
        /// files.
        abstract baseURLForDataURL: string option with get, set

    type [<AllowNullLiteral>] LoginItemSettings =
        abstract options: Options option with get, set
        /// true if the app is set to open at login.
        abstract openAtLogin: bool with get, set
        /// true if the app is set to open as hidden at login. This setting is only
        /// supported on macOS.
        abstract openAsHidden: bool with get, set
        /// true if the app was opened at login automatically. This setting is only
        /// supported on macOS.
        abstract wasOpenedAtLogin: bool with get, set
        /// true if the app was opened as a hidden login item. This indicates that the app
        /// should not open any windows at startup. This setting is only supported on macOS.
        abstract wasOpenedAsHidden: bool with get, set
        /// true if the app was opened as a login item that should restore the state from
        /// the previous session. This indicates that the app should restore the windows
        /// that were open the last time the app was closed. This setting is only supported
        /// on macOS.
        abstract restoreState: bool with get, set

    type [<AllowNullLiteral>] LoginItemSettingsOptions =
        /// The executable path to compare against. Defaults to process.execPath.
        abstract path: string option with get, set
        /// The command-line arguments to compare against. Defaults to an empty array.
        abstract args: ResizeArray<string> option with get, set

    type [<AllowNullLiteral>] MenuItemConstructorOptions =
        /// Will be called with click(menuItem, browserWindow, event) when the menu item is
        /// clicked.
        abstract click: (MenuItem -> BrowserWindow -> Event -> unit) option with get, set
        /// Define the action of the menu item, when specified the click property will be
        /// ignored. See .
        abstract role: string option with get, set
        /// Can be normal, separator, submenu, checkbox or radio.
        abstract ``type``: U5<string, string, string, string, string> option with get, set
        abstract label: string option with get, set
        abstract sublabel: string option with get, set
        abstract accelerator: Accelerator option with get, set
        abstract icon: U2<NativeImage, string> option with get, set
        /// If false, the menu item will be greyed out and unclickable.
        abstract enabled: bool option with get, set
        /// If false, the menu item will be entirely hidden.
        abstract visible: bool option with get, set
        /// Should only be specified for checkbox or radio type menu items.
        abstract ``checked``: bool option with get, set
        /// Should be specified for submenu type menu items. If submenu is specified, the
        /// type: 'submenu' can be omitted. If the value is not a Menu then it will be
        /// automatically converted to one using Menu.buildFromTemplate.
        abstract submenu: U2<ResizeArray<MenuItemConstructorOptions>, Menu> option with get, set
        /// Unique within a single menu. If defined then it can be used as a reference to
        /// this item by the position attribute.
        abstract id: string option with get, set
        /// This field allows fine-grained definition of the specific location within a
        /// given menu.
        abstract position: string option with get, set

    type [<AllowNullLiteral>] MessageBoxOptions =
        /// Can be "none", "info", "error", "question" or "warning". On Windows, "question"
        /// displays the same icon as "info", unless you set an icon using the "icon"
        /// option. On macOS, both "warning" and "error" display the same warning icon.
        abstract ``type``: string option with get, set
        /// Array of texts for buttons. On Windows, an empty array will result in one button
        /// labeled "OK".
        abstract buttons: ResizeArray<string> option with get, set
        /// Index of the button in the buttons array which will be selected by default when
        /// the message box opens.
        abstract defaultId: float option with get, set
        /// Title of the message box, some platforms will not show it.
        abstract title: string option with get, set
        /// Content of the message box.
        abstract message: string with get, set
        /// Extra information of the message.
        abstract detail: string option with get, set
        /// If provided, the message box will include a checkbox with the given label. The
        /// checkbox state can be inspected only when using callback.
        abstract checkboxLabel: string option with get, set
        /// Initial checked state of the checkbox. false by default.
        abstract checkboxChecked: bool option with get, set
        abstract icon: NativeImage option with get, set
        /// The index of the button to be used to cancel the dialog, via the Esc key. By
        /// default this is assigned to the first button with "cancel" or "no" as the label.
        /// If no such labeled buttons exist and this option is not set, 0 will be used as
        /// the return value or callback response. This option is ignored on Windows.
        abstract cancelId: float option with get, set
        /// On Windows Electron will try to figure out which one of the buttons are common
        /// buttons (like "Cancel" or "Yes"), and show the others as command links in the
        /// dialog. This can make the dialog appear in the style of modern Windows apps. If
        /// you don't like this behavior, you can set noLink to true.
        abstract noLink: bool option with get, set
        /// Normalize the keyboard access keys across platforms. Default is false. Enabling
        /// this assumes & is used in the button labels for the placement of the keyboard
        /// shortcut access key and labels will be converted so they work correctly on each
        /// platform, & characters are removed on macOS, converted to _ on Linux, and left
        /// untouched on Windows. For example, a button label of Vie&w will be converted to
        /// Vie_w on Linux and View on macOS and can be selected via Alt-W on Windows and
        /// Linux.
        abstract normalizeAccessKeys: bool option with get, set

    type [<AllowNullLiteral>] NewWindowEvent =
        inherit Event
        abstract url: string with get, set
        abstract frameName: string with get, set
        /// Can be `default`, `foreground-tab`, `background-tab`, `new-window`,
        /// `save-to-disk` and `other`.
        abstract disposition: U6<string, string, string, string, string, string> with get, set
        /// The options which should be used for creating the new `BrowserWindow`.
        abstract options: Options with get, set

    type [<AllowNullLiteral>] NotificationConstructorOptions =
        /// A title for the notification, which will be shown at the top of the notification
        /// window when it is shown
        abstract title: string with get, set
        /// A subtitle for the notification, which will be displayed below the title.
        abstract subtitle: string option with get, set
        /// The body text of the notification, which will be displayed below the title or
        /// subtitle
        abstract body: string with get, set
        /// Whether or not to emit an OS notification noise when showing the notification
        abstract silent: bool option with get, set
        /// An icon to use in the notification
        abstract icon: U2<string, NativeImage> option with get, set
        /// Whether or not to add an inline reply option to the notification.
        abstract hasReply: bool option with get, set
        /// The placeholder to write in the inline reply input field.
        abstract replyPlaceholder: string option with get, set
        /// The name of the sound file to play when the notification is shown.
        abstract sound: string option with get, set
        /// Actions to add to the notification. Please read the available actions and
        /// limitations in the NotificationAction documentation
        abstract actions: ResizeArray<NotificationAction> option with get, set

    type [<AllowNullLiteral>] OnBeforeRedirectDetails =
        abstract id: float with get, set
        abstract url: string with get, set
        abstract ``method``: string with get, set
        abstract webContentsId: float option with get, set
        abstract resourceType: string with get, set
        abstract timestamp: float with get, set
        abstract redirectURL: string with get, set
        abstract statusCode: float with get, set
        /// The server IP address that the request was actually sent to.
        abstract ip: string option with get, set
        abstract fromCache: bool with get, set
        abstract responseHeaders: ResponseHeaders with get, set

    type [<AllowNullLiteral>] OnBeforeRedirectFilter =
        /// Array of URL patterns that will be used to filter out the requests that do not
        /// match the URL patterns.
        abstract urls: ResizeArray<string> with get, set

    type [<AllowNullLiteral>] OnBeforeRequestDetails =
        abstract id: float with get, set
        abstract url: string with get, set
        abstract ``method``: string with get, set
        abstract webContentsId: float option with get, set
        abstract resourceType: string with get, set
        abstract timestamp: float with get, set
        abstract uploadData: ResizeArray<UploadData> with get, set

    type [<AllowNullLiteral>] OnBeforeRequestFilter =
        /// Array of URL patterns that will be used to filter out the requests that do not
        /// match the URL patterns.
        abstract urls: ResizeArray<string> with get, set

    type [<AllowNullLiteral>] OnBeforeSendHeadersFilter =
        /// Array of URL patterns that will be used to filter out the requests that do not
        /// match the URL patterns.
        abstract urls: ResizeArray<string> with get, set

    type [<AllowNullLiteral>] OnCompletedDetails =
        abstract id: float with get, set
        abstract url: string with get, set
        abstract ``method``: string with get, set
        abstract webContentsId: float option with get, set
        abstract resourceType: string with get, set
        abstract timestamp: float with get, set
        abstract responseHeaders: ResponseHeaders with get, set
        abstract fromCache: bool with get, set
        abstract statusCode: float with get, set
        abstract statusLine: string with get, set

    type [<AllowNullLiteral>] OnCompletedFilter =
        /// Array of URL patterns that will be used to filter out the requests that do not
        /// match the URL patterns.
        abstract urls: ResizeArray<string> with get, set

    type [<AllowNullLiteral>] OnErrorOccurredDetails =
        abstract id: float with get, set
        abstract url: string with get, set
        abstract ``method``: string with get, set
        abstract webContentsId: float option with get, set
        abstract resourceType: string with get, set
        abstract timestamp: float with get, set
        abstract fromCache: bool with get, set
        /// The error description.
        abstract error: string with get, set

    type [<AllowNullLiteral>] OnErrorOccurredFilter =
        /// Array of URL patterns that will be used to filter out the requests that do not
        /// match the URL patterns.
        abstract urls: ResizeArray<string> with get, set

    type [<AllowNullLiteral>] OnHeadersReceivedFilter =
        /// Array of URL patterns that will be used to filter out the requests that do not
        /// match the URL patterns.
        abstract urls: ResizeArray<string> with get, set

    type [<AllowNullLiteral>] OnResponseStartedDetails =
        abstract id: float with get, set
        abstract url: string with get, set
        abstract ``method``: string with get, set
        abstract webContentsId: float option with get, set
        abstract resourceType: string with get, set
        abstract timestamp: float with get, set
        abstract responseHeaders: ResponseHeaders with get, set
        /// Indicates whether the response was fetched from disk cache.
        abstract fromCache: bool with get, set
        abstract statusCode: float with get, set
        abstract statusLine: string with get, set

    type [<AllowNullLiteral>] OnResponseStartedFilter =
        /// Array of URL patterns that will be used to filter out the requests that do not
        /// match the URL patterns.
        abstract urls: ResizeArray<string> with get, set

    type [<AllowNullLiteral>] OnSendHeadersDetails =
        abstract id: float with get, set
        abstract url: string with get, set
        abstract ``method``: string with get, set
        abstract webContentsId: float option with get, set
        abstract resourceType: string with get, set
        abstract timestamp: float with get, set
        abstract requestHeaders: RequestHeaders with get, set

    type [<AllowNullLiteral>] OnSendHeadersFilter =
        /// Array of URL patterns that will be used to filter out the requests that do not
        /// match the URL patterns.
        abstract urls: ResizeArray<string> with get, set

    type [<AllowNullLiteral>] OpenDevToolsOptions =
        /// Opens the devtools with specified dock state, can be right, bottom, undocked,
        /// detach. Defaults to last used dock state. In undocked mode it's possible to dock
        /// back. In detach mode it's not.
        abstract mode: U4<string, string, string, string> with get, set

    type [<AllowNullLiteral>] OpenDialogOptions =
        abstract title: string option with get, set
        abstract defaultPath: string option with get, set
        /// Custom label for the confirmation button, when left empty the default label will
        /// be used.
        abstract buttonLabel: string option with get, set
        abstract filters: ResizeArray<FileFilter> option with get, set
        /// Contains which features the dialog should use. The following values are
        /// supported:
        abstract properties: Array<U8<string, string, string, string, string, string, string, string>> option with get, set
        /// Message to display above input boxes.
        abstract message: string option with get, set

    type [<AllowNullLiteral>] OpenExternalOptions =
        /// true to bring the opened application to the foreground. The default is true.
        abstract activate: bool with get, set

    type [<AllowNullLiteral>] PageFaviconUpdatedEvent =
        inherit Event
        /// Array of URLs.
        abstract favicons: ResizeArray<string> with get, set

    type [<AllowNullLiteral>] PageTitleUpdatedEvent =
        inherit Event
        abstract title: string with get, set
        abstract explicitSet: bool with get, set

    type [<AllowNullLiteral>] Parameters =
        /// Specify the screen type to emulate (default: desktop)
        abstract screenPosition: U2<string, string> with get, set
        /// Set the emulated screen size (screenPosition == mobile)
        abstract screenSize: Size with get, set
        /// Position the view on the screen (screenPosition == mobile) (default: {x: 0, y:
        /// 0})
        abstract viewPosition: Point with get, set
        /// Set the device scale factor (if zero defaults to original device scale factor)
        /// (default: 0)
        abstract deviceScaleFactor: float with get, set
        /// Set the emulated view size (empty means no override)
        abstract viewSize: Size with get, set
        /// Whether emulated view should be scaled down if necessary to fit into available
        /// space (default: false)
        abstract fitToView: bool with get, set
        /// Offset of the emulated view inside available space (not in fit to view mode)
        /// (default: {x: 0, y: 0})
        abstract offset: Point with get, set
        /// Scale of emulated view inside available space (not in fit to view mode)
        /// (default: 1)
        abstract scale: float with get, set

    type [<AllowNullLiteral>] PluginCrashedEvent =
        inherit Event
        abstract name: string with get, set
        abstract version: string with get, set

    type [<AllowNullLiteral>] PopupOptions =
        /// Default is the current mouse cursor position. Must be declared if y is declared.
        abstract x: float option with get, set
        /// Default is the current mouse cursor position. Must be declared if x is declared.
        abstract y: float option with get, set
        /// Set to true to have this method return immediately called, false to return after
        /// the menu has been selected or closed. Defaults to false.
        abstract async: bool option with get, set
        /// The index of the menu item to be positioned under the mouse cursor at the
        /// specified coordinates. Default is -1.
        abstract positioningItem: float option with get, set

    type [<AllowNullLiteral>] PrintOptions =
        /// Don't ask user for print settings. Default is false.
        abstract silent: bool option with get, set
        /// Also prints the background color and image of the web page. Default is false.
        abstract printBackground: bool option with get, set
        /// Set the printer device name to use. Default is ''.
        abstract deviceName: string option with get, set

    type [<AllowNullLiteral>] PrintToPDFOptions =
        /// Specifies the type of margins to use. Uses 0 for default margin, 1 for no
        /// margin, and 2 for minimum margin.
        abstract marginsType: float option with get, set
        /// Specify page size of the generated PDF. Can be A3, A4, A5, Legal, Letter,
        /// Tabloid or an Object containing height and width in microns.
        abstract pageSize: string option with get, set
        /// Whether to print CSS backgrounds.
        abstract printBackground: bool option with get, set
        /// Whether to print selection only.
        abstract printSelectionOnly: bool option with get, set
        /// true for landscape, false for portrait.
        abstract landscape: bool option with get, set

    type [<AllowNullLiteral>] ProcessMemoryInfo =
        /// The amount of memory currently pinned to actual physical RAM.
        abstract workingSetSize: float with get, set
        /// The maximum amount of memory that has ever been pinned to actual physical RAM.
        abstract peakWorkingSetSize: float with get, set
        /// The amount of memory not shared by other processes, such as JS heap or HTML
        /// content.
        abstract privateBytes: float with get, set
        /// The amount of memory shared between processes, typically memory consumed by the
        /// Electron code itself
        abstract sharedBytes: float with get, set

    type [<AllowNullLiteral>] ProgressBarOptions =
        /// Mode for the progress bar. Can be none, normal, indeterminate, error or paused.
        abstract mode: U5<string, string, string, string, string> with get, set

    type [<AllowNullLiteral>] Provider =
        /// Returns Boolean
        abstract spellCheck: (string -> unit) with get, set

    type [<AllowNullLiteral>] ReadBookmark =
        abstract title: string with get, set
        abstract url: string with get, set

    type [<AllowNullLiteral>] RedirectRequest =
        abstract url: string with get, set
        abstract ``method``: string with get, set
        abstract session: Session option with get, set
        abstract uploadData: UploadData option with get, set

    type [<AllowNullLiteral>] RegisterBufferProtocolRequest =
        abstract url: string with get, set
        abstract referrer: string with get, set
        abstract ``method``: string with get, set
        abstract uploadData: ResizeArray<UploadData> with get, set

    type [<AllowNullLiteral>] RegisterFileProtocolRequest =
        abstract url: string with get, set
        abstract referrer: string with get, set
        abstract ``method``: string with get, set
        abstract uploadData: ResizeArray<UploadData> with get, set

    type [<AllowNullLiteral>] RegisterHttpProtocolRequest =
        abstract url: string with get, set
        abstract referrer: string with get, set
        abstract ``method``: string with get, set
        abstract uploadData: ResizeArray<UploadData> with get, set

    type [<AllowNullLiteral>] RegisterStandardSchemesOptions =
        /// true to register the scheme as secure. Default false.
        abstract secure: bool option with get, set

    type [<AllowNullLiteral>] RegisterStreamProtocolRequest =
        abstract url: string with get, set
        abstract headers: Headers with get, set
        abstract referrer: string with get, set
        abstract ``method``: string with get, set
        abstract uploadData: ResizeArray<UploadData> with get, set

    type [<AllowNullLiteral>] RegisterStringProtocolRequest =
        abstract url: string with get, set
        abstract referrer: string with get, set
        abstract ``method``: string with get, set
        abstract uploadData: ResizeArray<UploadData> with get, set

    type [<AllowNullLiteral>] RegisterURLSchemeAsPrivilegedOptions =
        /// Default true.
        abstract secure: bool option with get, set
        /// Default true.
        abstract bypassCSP: bool option with get, set
        /// Default true.
        abstract allowServiceWorkers: bool option with get, set
        /// Default true.
        abstract supportFetchAPI: bool option with get, set
        /// Default true.
        abstract corsEnabled: bool option with get, set

    type [<AllowNullLiteral>] RelaunchOptions =
        abstract args: ResizeArray<string> option with get, set
        abstract execPath: string option with get, set

    type [<AllowNullLiteral>] Request =
        abstract ``method``: string with get, set
        abstract url: string with get, set
        abstract referrer: string with get, set

    type [<AllowNullLiteral>] ResizeOptions =
        /// Defaults to the image's width.
        abstract width: float option with get, set
        /// Defaults to the image's height
        abstract height: float option with get, set
        /// The desired quality of the resize image. Possible values are good, better or
        /// best. The default is best. These values express a desired quality/speed
        /// tradeoff. They are translated into an algorithm-specific method that depends on
        /// the capabilities (CPU, GPU) of the underlying platform. It is possible for all
        /// three methods to be mapped to the same algorithm on a given platform.
        abstract quality: string option with get, set

    type [<AllowNullLiteral>] ResourceUsage =
        abstract images: MemoryUsageDetails with get, set
        abstract cssStyleSheets: MemoryUsageDetails with get, set
        abstract xslStyleSheets: MemoryUsageDetails with get, set
        abstract fonts: MemoryUsageDetails with get, set
        abstract other: MemoryUsageDetails with get, set

    type [<AllowNullLiteral>] Response =
        abstract cancel: bool option with get, set
        /// The original request is prevented from being sent or completed and is instead
        /// redirected to the given URL.
        abstract redirectURL: string option with get, set

    type [<AllowNullLiteral>] Result =
        abstract requestId: float with get, set
        /// Position of the active match.
        abstract activeMatchOrdinal: float with get, set
        /// Number of Matches.
        abstract matches: float with get, set
        /// Coordinates of first match region.
        abstract selectionArea: SelectionArea with get, set
        abstract finalUpdate: bool with get, set

    type [<AllowNullLiteral>] SaveDialogOptions =
        abstract title: string option with get, set
        /// Absolute directory path, absolute file path, or file name to use by default.
        abstract defaultPath: string option with get, set
        /// Custom label for the confirmation button, when left empty the default label will
        /// be used.
        abstract buttonLabel: string option with get, set
        abstract filters: ResizeArray<FileFilter> option with get, set
        /// Message to display above text fields.
        abstract message: string option with get, set
        /// Custom label for the text displayed in front of the filename text field.
        abstract nameFieldLabel: string option with get, set
        /// Show the tags input box, defaults to true.
        abstract showsTagField: bool option with get, set

    type [<AllowNullLiteral>] Settings =
        /// true to open the app at login, false to remove the app as a login item. Defaults
        /// to false.
        abstract openAtLogin: bool option with get, set
        /// true to open the app as hidden. Defaults to false. The user can edit this
        /// setting from the System Preferences so
        /// app.getLoginItemStatus().wasOpenedAsHidden should be checked when the app is
        /// opened to know the current value. This setting is only supported on macOS.
        abstract openAsHidden: bool option with get, set
        /// The executable to launch at login. Defaults to process.execPath.
        abstract path: string option with get, set
        /// The command-line arguments to pass to the executable. Defaults to an empty
        /// array. Take care to wrap paths in quotes.
        abstract args: ResizeArray<string> option with get, set

    type [<AllowNullLiteral>] SizeOptions =
        /// true to make the webview container automatically resize within the bounds
        /// specified by the attributes normal, min and max.
        abstract enableAutoSize: bool option with get, set
        /// Normal size of the page. This can be used in combination with the attribute to
        /// manually resize the webview guest contents.
        abstract normal: Size option with get, set
        /// Minimum size of the page. This can be used in combination with the attribute to
        /// manually resize the webview guest contents.
        abstract min: Size option with get, set
        /// Maximium size of the page. This can be used in combination with the attribute to
        /// manually resize the webview guest contents.
        abstract max: Size option with get, set

    type [<AllowNullLiteral>] SourcesOptions =
        /// An array of Strings that lists the types of desktop sources to be captured,
        /// available types are screen and window.
        abstract types: ResizeArray<string> with get, set
        /// The size that the media source thumbnail should be scaled to. Default is 150 x
        /// 150.
        abstract thumbnailSize: Size option with get, set

    type [<AllowNullLiteral>] StartMonitoringOptions =
        abstract categoryFilter: string with get, set
        abstract traceOptions: string with get, set

    type [<AllowNullLiteral>] StartRecordingOptions =
        abstract categoryFilter: string with get, set
        abstract traceOptions: string with get, set

    type [<AllowNullLiteral>] SystemMemoryInfo =
        /// The total amount of physical memory in Kilobytes available to the system.
        abstract total: float with get, set
        /// The total amount of memory not being used by applications or disk cache.
        abstract free: float with get, set
        /// The total amount of swap memory in Kilobytes available to the system.
        abstract swapTotal: float with get, set
        /// The free amount of swap memory in Kilobytes available to the system.
        abstract swapFree: float with get, set

    type [<AllowNullLiteral>] ToBitmapOptions =
        /// Defaults to 1.0.
        abstract scaleFactor: float option with get, set

    type [<AllowNullLiteral>] ToDataURLOptions =
        /// Defaults to 1.0.
        abstract scaleFactor: float option with get, set

    type [<AllowNullLiteral>] ToPNGOptions =
        /// Defaults to 1.0.
        abstract scaleFactor: float option with get, set

    type [<AllowNullLiteral>] TouchBarButtonConstructorOptions =
        /// Button text.
        abstract label: string option with get, set
        /// Button background color in hex format, i.e #ABCDEF.
        abstract backgroundColor: string option with get, set
        /// Button icon.
        abstract icon: NativeImage option with get, set
        /// Can be left, right or overlay.
        abstract iconPosition: U3<string, string, string> option with get, set
        /// Function to call when the button is clicked.
        abstract click: (unit -> unit) option with get, set

    type [<AllowNullLiteral>] TouchBarColorPickerConstructorOptions =
        /// Array of hex color strings to appear as possible colors to select.
        abstract availableColors: ResizeArray<string> option with get, set
        /// The selected hex color in the picker, i.e #ABCDEF.
        abstract selectedColor: string option with get, set
        /// Function to call when a color is selected.
        abstract change: (string -> unit) option with get, set

    type [<AllowNullLiteral>] TouchBarConstructorOptions =
        abstract items: Array<obj> with get, set
        abstract escapeItem: obj option with get, set

    type [<AllowNullLiteral>] TouchBarGroupConstructorOptions =
        /// Items to display as a group.
        abstract items: TouchBar with get, set

    type [<AllowNullLiteral>] TouchBarLabelConstructorOptions =
        /// Text to display.
        abstract label: string option with get, set
        /// Hex color of text, i.e #ABCDEF.
        abstract textColor: string option with get, set

    type [<AllowNullLiteral>] TouchBarPopoverConstructorOptions =
        /// Popover button text.
        abstract label: string option with get, set
        /// Popover button icon.
        abstract icon: NativeImage option with get, set
        /// Items to display in the popover.
        abstract items: TouchBar option with get, set
        /// true to display a close button on the left of the popover, false to not show it.
        /// Default is true.
        abstract showCloseButton: bool option with get, set

    type [<AllowNullLiteral>] TouchBarScrubberConstructorOptions =
        /// An array of items to place in this scrubber
        abstract items: ResizeArray<ScrubberItem> with get, set
        /// Called when the user taps an item that was not the last tapped item
        abstract select: (float -> unit) with get, set
        /// Called when the user taps any item
        abstract highlight: (float -> unit) with get, set
        /// Selected item style. Defaults to null.
        abstract selectedStyle: string with get, set
        /// Selected overlay item style. Defaults to null.
        abstract overlayStyle: string with get, set
        /// Defaults to false.
        abstract showArrowButtons: bool with get, set
        /// Defaults to free.
        abstract mode: string with get, set
        /// Defaults to true.
        abstract continuous: bool with get, set

    type [<AllowNullLiteral>] TouchBarSegmentedControlConstructorOptions =
        /// Style of the segments:
        abstract segmentStyle: U8<string, string, string, string, string, string, string, string> option with get, set
        /// The selection mode of the control:
        abstract mode: U3<string, string, string> option with get, set
        /// An array of segments to place in this control.
        abstract segments: ResizeArray<SegmentedControlSegment> with get, set
        /// The index of the currently selected segment, will update automatically with user
        /// interaction. When the mode is multiple it will be the last selected item.
        abstract selectedIndex: float option with get, set
        /// Called when the user selects a new segment
        abstract change: (float -> bool -> unit) with get, set

    type [<AllowNullLiteral>] TouchBarSliderConstructorOptions =
        /// Label text.
        abstract label: string option with get, set
        /// Selected value.
        abstract value: float option with get, set
        /// Minimum value.
        abstract minValue: float option with get, set
        /// Maximum value.
        abstract maxValue: float option with get, set
        /// Function to call when the slider is changed.
        abstract change: (float -> unit) option with get, set

    type [<AllowNullLiteral>] TouchBarSpacerConstructorOptions =
        /// Size of spacer, possible values are:
        abstract size: U3<string, string, string> option with get, set

    type [<AllowNullLiteral>] UpdateTargetUrlEvent =
        inherit Event
        abstract url: string with get, set

    type [<AllowNullLiteral>] Versions =
        /// A String representing Chrome's version string.
        abstract chrome: string option with get, set
        /// A String representing Electron's version string.
        abstract electron: string option with get, set

    type [<AllowNullLiteral>] WillNavigateEvent =
        inherit Event
        abstract url: string with get, set

    type [<AllowNullLiteral>] EditFlags =
        /// Whether the renderer believes it can undo.
        abstract canUndo: bool with get, set
        /// Whether the renderer believes it can redo.
        abstract canRedo: bool with get, set
        /// Whether the renderer believes it can cut.
        abstract canCut: bool with get, set
        /// Whether the renderer believes it can copy
        abstract canCopy: bool with get, set
        /// Whether the renderer believes it can paste.
        abstract canPaste: bool with get, set
        /// Whether the renderer believes it can delete.
        abstract canDelete: bool with get, set
        /// Whether the renderer believes it can select all.
        abstract canSelectAll: bool with get, set

    type [<AllowNullLiteral>] Extra =
        interface end

    type [<AllowNullLiteral>] FoundInPageResult =
        abstract requestId: float with get, set
        /// Position of the active match.
        abstract activeMatchOrdinal: float with get, set
        /// Number of Matches.
        abstract matches: float with get, set
        /// Coordinates of first match region.
        abstract selectionArea: SelectionArea with get, set
        abstract finalUpdate: bool with get, set

    type [<AllowNullLiteral>] MediaFlags =
        /// Whether the media element has crashed.
        abstract inError: bool with get, set
        /// Whether the media element is paused.
        abstract isPaused: bool with get, set
        /// Whether the media element is muted.
        abstract isMuted: bool with get, set
        /// Whether the media element has audio.
        abstract hasAudio: bool with get, set
        /// Whether the media element is looping.
        abstract isLooping: bool with get, set
        /// Whether the media element's controls are visible.
        abstract isControlsVisible: bool with get, set
        /// Whether the media element's controls are toggleable.
        abstract canToggleControls: bool with get, set
        /// Whether the media element can be rotated.
        abstract canRotate: bool with get, set

    type [<AllowNullLiteral>] Options =
        interface end

    type [<AllowNullLiteral>] RequestHeaders =
        interface end

    type [<AllowNullLiteral>] ResponseHeaders =
        interface end

    type [<AllowNullLiteral>] SelectionArea =
        interface end

    type [<AllowNullLiteral>] WebPreferences =
        /// Whether to enable DevTools. If it is set to false, can not use
        /// BrowserWindow.webContents.openDevTools() to open DevTools. Default is true.
        abstract devTools: bool option with get, set
        /// Whether node integration is enabled. Default is true.
        abstract nodeIntegration: bool option with get, set
        /// Whether node integration is enabled in web workers. Default is false. More about
        /// this can be found in .
        abstract nodeIntegrationInWorker: bool option with get, set
        /// Specifies a script that will be loaded before other scripts run in the page.
        /// This script will always have access to node APIs no matter whether node
        /// integration is turned on or off. The value should be the absolute file path to
        /// the script. When node integration is turned off, the preload script can
        /// reintroduce Node global symbols back to the global scope. See example .
        abstract preload: string option with get, set
        /// If set, this will sandbox the renderer associated with the window, making it
        /// compatible with the Chromium OS-level sandbox and disabling the Node.js engine.
        /// This is not the same as the nodeIntegration option and the APIs available to the
        /// preload script are more limited. Read more about the option . This option is
        /// currently experimental and may change or be removed in future Electron releases.
        abstract sandbox: bool option with get, set
        /// Sets the session used by the page. Instead of passing the Session object
        /// directly, you can also choose to use the partition option instead, which accepts
        /// a partition string. When both session and partition are provided, session will
        /// be preferred. Default is the default session.
        abstract session: Session option with get, set
        /// Sets the session used by the page according to the session's partition string.
        /// If partition starts with persist:, the page will use a persistent session
        /// available to all pages in the app with the same partition. If there is no
        /// persist: prefix, the page will use an in-memory session. By assigning the same
        /// partition, multiple pages can share the same session. Default is the default
        /// session.
        abstract partition: string option with get, set
        /// The default zoom factor of the page, 3.0 represents 300%. Default is 1.0.
        abstract zoomFactor: float option with get, set
        /// Enables JavaScript support. Default is true.
        abstract javascript: bool option with get, set
        /// When false, it will disable the same-origin policy (usually using testing
        /// websites by people), and set allowRunningInsecureContent to true if this options
        /// has not been set by user. Default is true.
        abstract webSecurity: bool option with get, set
        /// Allow an https page to run JavaScript, CSS or plugins from http URLs. Default is
        /// false.
        abstract allowRunningInsecureContent: bool option with get, set
        /// Enables image support. Default is true.
        abstract images: bool option with get, set
        /// Make TextArea elements resizable. Default is true.
        abstract textAreasAreResizable: bool option with get, set
        /// Enables WebGL support. Default is true.
        abstract webgl: bool option with get, set
        /// Enables WebAudio support. Default is true.
        abstract webaudio: bool option with get, set
        /// Whether plugins should be enabled. Default is false.
        abstract plugins: bool option with get, set
        /// Enables Chromium's experimental features. Default is false.
        abstract experimentalFeatures: bool option with get, set
        /// Enables Chromium's experimental canvas features. Default is false.
        abstract experimentalCanvasFeatures: bool option with get, set
        /// Enables scroll bounce (rubber banding) effect on macOS. Default is false.
        abstract scrollBounce: bool option with get, set
        /// A list of feature strings separated by ,, like CSSVariables,KeyboardEventKey to
        /// enable. The full list of supported feature strings can be found in the file.
        abstract blinkFeatures: string option with get, set
        /// A list of feature strings separated by ,, like CSSVariables,KeyboardEventKey to
        /// disable. The full list of supported feature strings can be found in the file.
        abstract disableBlinkFeatures: string option with get, set
        /// Sets the default font for the font-family.
        abstract defaultFontFamily: DefaultFontFamily option with get, set
        /// Defaults to 16.
        abstract defaultFontSize: float option with get, set
        /// Defaults to 13.
        abstract defaultMonospaceFontSize: float option with get, set
        /// Defaults to 0.
        abstract minimumFontSize: float option with get, set
        /// Defaults to ISO-8859-1.
        abstract defaultEncoding: string option with get, set
        /// Whether to throttle animations and timers when the page becomes background. This
        /// also affects the . Defaults to true.
        abstract backgroundThrottling: bool option with get, set
        /// Whether to enable offscreen rendering for the browser window. Defaults to false.
        /// See the for more details.
        abstract offscreen: bool option with get, set
        /// Whether to run Electron APIs and the specified preload script in a separate
        /// JavaScript context. Defaults to false. The context that the preload script runs
        /// in will still have full access to the document and window globals but it will
        /// use its own set of JavaScript builtins (Array, Object, JSON, etc.) and will be
        /// isolated from any changes made to the global environment by the loaded page. The
        /// Electron API will only be available in the preload script and not the loaded
        /// page. This option should be used when loading potentially untrusted remote
        /// content to ensure the loaded content cannot tamper with the preload script and
        /// any Electron APIs being used. This option uses the same technique used by . You
        /// can access this context in the dev tools by selecting the 'Electron Isolated
        /// Context' entry in the combo box at the top of the Console tab. This option is
        /// currently experimental and may change or be removed in future Electron releases.
        abstract contextIsolation: bool option with get, set
        /// Whether to use native window.open(). Defaults to false. This option is currently
        /// experimental.
        abstract nativeWindowOpen: bool option with get, set
        /// Whether to enable the . Defaults to the value of the nodeIntegration option. The
        /// preload script configured for the <webview> will have node integration enabled
        /// when it is executed so you should ensure remote/untrusted content is not able to
        /// create a <webview> tag with a possibly malicious preload script. You can use the
        /// will-attach-webview event on to strip away the preload script and to validate or
        /// alter the <webview>'s initial settings.
        abstract webviewTag: bool option with get, set

    type [<AllowNullLiteral>] DefaultFontFamily =
        /// Defaults to Times New Roman.
        abstract standard: string option with get, set
        /// Defaults to Times New Roman.
        abstract serif: string option with get, set
        /// Defaults to Arial.
        abstract sansSerif: string option with get, set
        /// Defaults to Courier New.
        abstract monospace: string option with get, set
        /// Defaults to Script.
        abstract cursive: string option with get, set
        /// Defaults to Impact.
        abstract fantasy: string option with get, set

type [<AllowNullLiteral>] NodeRequireFunction =
    [<Emit "$0.Invoke('electron')">] abstract Invoke_electron: unit -> obj

type [<AllowNullLiteral>] File =
    /// The real path to the file on the users filesystem
    abstract path: string with get, set

type [<AllowNullLiteral>] Document =
    [<Emit "$0.createElement('webview')">] abstract createElement_webview: unit -> Electron.WebviewTag

module NodeJS =

    type [<AllowNullLiteral>] Process =
        inherit EventEmitter
        /// Emitted when Electron has loaded its internal initialization script and is
        /// beginning to load the web page or the main script. It can be used by the preload
        /// script to add removed Node global symbols back to the global scope when node
        /// integration is turned off:
        [<Emit "$0.on('loaded',$1)">] abstract on_loaded: listener: Function -> Process
        [<Emit "$0.once('loaded',$1)">] abstract once_loaded: listener: Function -> Process
        [<Emit "$0.addListener('loaded',$1)">] abstract addListener_loaded: listener: Function -> Process
        [<Emit "$0.removeListener('loaded',$1)">] abstract removeListener_loaded: listener: Function -> Process
        /// Causes the main thread of the current process crash.
        abstract crash: unit -> unit
        abstract getCPUUsage: unit -> Electron.CPUUsage
        abstract getIOCounters: unit -> Electron.IOCounters
        /// Returns an object giving memory usage statistics about the current process. Note
        /// that all statistics are reported in Kilobytes.
        abstract getProcessMemoryInfo: unit -> Electron.ProcessMemoryInfo
        /// Returns an object giving memory usage statistics about the entire system. Note
        /// that all statistics are reported in Kilobytes.
        abstract getSystemMemoryInfo: unit -> Electron.SystemMemoryInfo
        /// Causes the main thread of the current process hang.
        abstract hang: unit -> unit
        /// Sets the file descriptor soft limit to maxDescriptors or the OS hard limit,
        /// whichever is lower for the current process.
        abstract setFdLimit: maxDescriptors: float -> unit
        /// A Boolean. When app is started by being passed as parameter to the default app,
        /// this property is true in the main process, otherwise it is undefined.
        abstract defaultApp: bool option with get, set
        /// A Boolean. For Mac App Store build, this property is true, for other builds it
        /// is undefined.
        abstract mas: bool option with get, set
        /// A Boolean that controls ASAR support inside your application. Setting this to
        /// true will disable the support for asar archives in Node's built-in modules.
        abstract noAsar: bool option with get, set
        /// A Boolean that controls whether or not deprecation warnings are printed to
        /// stderr. Setting this to true will silence deprecation warnings.  This property
        /// is used instead of the --no-deprecation command line flag.
        abstract noDeprecation: bool option with get, set
        /// A String representing the path to the resources directory.
        abstract resourcesPath: string option with get, set
        /// A Boolean that controls whether or not deprecation warnings will be thrown as
        /// exceptions.  Setting this to true will throw errors for deprecations.  This
        /// property is used instead of the --throw-deprecation command line flag.
        abstract throwDeprecation: bool option with get, set
        /// A Boolean that controls whether or not deprecations printed to stderr include
        /// their stack trace.  Setting this to true will print  stack traces for
        /// deprecations. This property is instead of the --trace-deprecation command line
        /// flag.
        abstract traceDeprecation: bool option with get, set
        /// A Boolean that controls whether or not process warnings printed to stderr
        /// include their stack trace.  Setting this to true will print stack traces for
        /// process warnings (including deprecations).  This property is instead of the
        /// --trace-warnings command line flag.
        abstract traceProcessWarnings: bool option with get, set
        /// A String representing the current process's type, can be "browser" (i.e. main
        /// process) or "renderer".
        abstract ``type``: string option with get, set
        /// A Boolean. If the app is running as a Windows Store app (appx), this property is
        /// true, for otherwise it is undefined.
        abstract windowsStore: bool option with get, set

    type [<AllowNullLiteral>] ProcessVersions =
        abstract electron: string with get, set
        abstract chrome: string with get, set

Creating a Google Chrome extension can be a rewarding project! Here's a simple guide to help you get started:

### Step 1: Set Up Your Project
1. **Create a new folder** for your extension files. Name it something relevant, like `MyFirstExtension`.

2. **Create a manifest file**:
   - In your folder, create a file named `manifest.json`.
   - Add the following code to `manifest.json`:

```json
{
  "manifest_version": 3,
  "name": "My First Extension",
  "version": "1.0",
  "description": "This is my first Chrome extension.",
  "action": {
    "default_popup": "popup.html",
    "default_icon": {
      "16": "icon16.png",
      "48": "icon48.png",
      "128": "icon128.png"
    }
  },
  "permissions": ["activeTab"]
}
```

### Step 2: Create the Popup HTML
1. **Create a file named `popup.html`** in the same folder.
2. Add the following code to `popup.html`:

```html
<!DOCTYPE html>
<html>
<head>
  <title>My First Extension</title>
  <style>
    body { width: 200px; }
    h1 { font-size: 20px; }
  </style>
</head>
<body>
  <h1>Hello, World!</h1>
  <p>This is my first Chrome extension.</p>
</body>
</html>
```

### Step 3: Add Icons
1. **Create icon files** named `icon16.png`, `icon48.png`, and `icon128.png` in the same folder. These icons will be used for your extension.

### Step 4: Load Your Extension in Chrome
1. Open Chrome and go to `chrome://extensions/`.
2. Enable **Developer mode** by toggling the switch in the top right corner.
3. Click on **Load unpacked** and select your extension folder.

Your extension should now be loaded and visible in the Chrome toolbar. When you click on the extension icon, it will display the popup you created.

For more detailed information and advanced features, you can refer to the [Chrome Developer documentation](https://developer.chrome.com/docs/extensions/get-started/)¹.

Feel free to ask if you have any questions or need further assistance!

Sursă: conversație cu Copilot. 9/9/2024
(1) Extensions / Get started | Chrome for Developers. https://developer.chrome.com/docs/extensions/get-started/.
(2) Create and publish custom Chrome apps & extensions. https://support.google.com/chrome/a/answer/2714278?hl=en.
(3) Add & open Chrome apps - Chrome Web Store Help - Google Help. https://support.google.com/chrome_webstore/answer/3060053?hl=en.
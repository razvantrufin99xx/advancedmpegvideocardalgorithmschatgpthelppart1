Sure! Here's a simple example of how to create a small HTTP server using Node.js:

1. **Install Node.js**: If you don't have Node.js installed, you can download it from [nodejs.org](https://nodejs.org/).

2. **Create a new file**: Let's name it `server.js`.

3. **Write the server code**:
```javascript
// Import the HTTP module
const http = require('http');

// Create an HTTP server
const server = http.createServer((req, res) => {
  // Set the response header
  res.writeHead(200, { 'Content-Type': 'text/plain' });
  // Send the response body
  res.end('Hello, World!\n');
});

// The server listens on port 3000
server.listen(3000, '127.0.0.1', () => {
  console.log('Server is running at http://127.0.0.1:3000/');
});
```

4. **Run the server**: Open your terminal, navigate to the directory where `server.js` is located, and run:
```bash
node server.js
```

5. **Access the server**: Open your web browser and go to `http://127.0.0.1:3000/`. You should see "Hello, World!" displayed.

This is a basic example to get you started. If you need more advanced features, you can explore frameworks like Express.js for Node.js.

Would you like to see examples in other programming languages as well?

Sursă: conversație cu Copilot. 9/9/2024
(1) How To Create a Simple HTTP Server with Node.js. https://www.youtube.com/watch?v=TrofE5tDRag.
(2) Make a Simple HTTP Server in Java - Java Tutorial - Part 3: Server Sockets. https://www.youtube.com/watch?v=N4f-D-oBvTc.
(3) How To Create a Simple Web Server Using Python and the http.server Module. https://www.youtube.com/watch?v=kogOfxg1c_g.
(4) How To Create a Web Server in Node.js with the HTTP Module. https://www.digitalocean.com/community/tutorials/how-to-create-a-web-server-in-node-js-with-the-http-module.
(5) http-server: a simple static HTTP server - GitHub. https://github.com/http-party/http-server.
(6) Creating a Server at Home for Web Hosting [2024 Guide] - Review42. https://review42.com/resources/how-to-create-your-server-at-home-for-web-hosting/.
(7) C# Simple Http Server - coding.vision. https://codingvision.net/c-simple-http-server.
(8) Make a simple HTTP Server with Node in 6 Steps - DEV Community. https://dev.to/ajkachnic/make-a-simple-http-server-with-node-in-6-steps-491c.
(9) undefined. http://someurl.com.
(10) undefined. http://127.0.0.1/.
const { env } = require('process');

// Default to the known HTTPS port from launchSettings.json
const target = env.ASPNETCORE_HTTPS_PORT
  ? `https://localhost:${env.ASPNETCORE_HTTPS_PORT}`
  : env.ASPNETCORE_URLS
    ? env.ASPNETCORE_URLS.split(';')[0]
    : 'https://localhost:7121';

const PROXY_CONFIG = [
  {
    context: [
      "/api" // ⬅️ Forward all /api requests (like /api/Auth/login)
    ],
    target,
    secure: false,
    changeOrigin: true
  }
];

module.exports = PROXY_CONFIG;

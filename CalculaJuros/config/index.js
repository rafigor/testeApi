const env        = process.env.NODE_ENV_CONFIG || 'development';
const configPath = `./config.${env}.js`;

console.log(`Arquivo de configuração : ${configPath}`);

module.exports = require(configPath); // eslint-disable-line import/no-dynamic-require

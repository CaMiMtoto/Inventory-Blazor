// vite.config.js
import {defineConfig} from 'vite';
import VitePluginSass from 'vite-plugin-sass';

const path = require('path')


export default defineConfig({
    plugins: [
        VitePluginSass({
            /* plugin options here */
        }),
    ],
    build: {
        outDir: './wwwroot/js',
    },

});

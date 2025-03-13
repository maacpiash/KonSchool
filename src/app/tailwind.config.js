require('dotenv').config()
const lumexui = require(`${process.env.NUGET_SOURCE}/packages/lumexui/1.1.1/theme/plugin`)

/** @type {import('tailwindcss').Config} */
module.exports = {
  content: [`${process.env.NUGET_SOURCE}/packages/lumexui/1.1.1/theme/components/*.cs`],
  theme: {
    extend: {},
  },
  plugins: [lumexui],
}

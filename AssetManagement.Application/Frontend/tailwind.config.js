/** @type {import('tailwindcss').Config} */
module.exports = {
  content: [
    "./public/index.html",
    "./src/**/*.{js,jsx,ts,tsx}",
    "./public/index.html",
  ],
  theme: {
      extend: {
        colors: {
        'primary' : '#cf2338',
        'secondary': '#707070',
      },
      fontFamily: {
      },
    },
  },
  plugins: [],
}


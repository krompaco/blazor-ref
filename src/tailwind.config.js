const defaultTheme = require('tailwindcss/defaultTheme')

module.exports = {
	purge: {
		enabled: process.env.NODE_ENV === 'production',
		content: ['./**/*.cshtml', './**/*.razor']
	},
	darkMode: false, // or 'media' or 'class'
	theme: {
		extend: {
			fontFamily: {
				sans: ['Inter var', 'Arial', 'Helvetica', 'sans-serif'],
				mono: ['JetBrains Mono', ...defaultTheme.fontFamily.mono],
			},
			outline: {
				jk: ['3px dotted #DB2777', '1px'],
			},
			typography: {
				DEFAULT: {
					css: {
						'pre code::before': {
							content: 'none',
						},
						'pre code::after': {
							content: 'none',
						},
					},
				},
			}
		},
	},
	variants: {
		extend: {
			outline: ['hover', 'active'],
		},
	},
	plugins: [
		require('@tailwindcss/typography')
	],
}

const nuget = require("@vops/nuget");

nuget.updateAndPublish("HelpScoutClient")
	.catch(console.error);
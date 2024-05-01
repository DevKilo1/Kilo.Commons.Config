# Kilo.Commons.Config

**How to use:**
Refer to Example.cs! Copy and paste the Config.cs into your project!

In the future, you can expect a public method inside the Config object named "Set".

That method will do the same as setting the property value of something in the config object (JObject), but it will sync between all players.

That's how it works at the moment, but may change in the future. Simply setting property values in the JObject won't sync, which is great for per-player configuration options.


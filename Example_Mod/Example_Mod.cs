using Timber_and_Stone.API;

// Use a namespace to keep things tidy and to work alongside other mods.
namespace Example_Mod
{
    // Inherit from CSharpPlugin
    public class Example_Mod : CSharpPlugin
    {
        public static readonly string ModName = "Example Mod";

        // Override the OnLoad() method
        public override void OnLoad()
        {
            // Use GUIManager singleton to add a textline saying our mod has been loaded.
            GUIManager.getInstance().AddTextLine($"{ModName} Loaded.");
        }

        // Override the OnEnable() method
        public override void OnEnable()
        {
            // Use GUIManager singleton to add a textline saying our mod has been enabled.
            GUIManager.getInstance().AddTextLine($"{ModName} Enabled.");
        }

        // Override the OnEnable() method
        public override void OnDisable()
        {
            // Used to save stuff or remove stuff
            // Might not be working for Beta 1.71
        }

        // Destructor
        ~Example_Mod()
        {
            // Used to save stuff or remove stuff much like OnDisable
            // Works when our instance has been destroyed
        }
    }
}

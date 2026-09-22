using System;

namespace HS.Modding.SDK;

public interface IMod 
{ 
    string Identifier { get; } 
    string Name { get; }
    string Description { get; }
    string[] Authors { get; }
    string[] Dependencies { get; } // Base is pre-included in ModLoader, it loads first.
        
    byte[] IconBytes { get; }
    string IconPath { get; } // If you use this, you do not need raw bytes, you should also put the image in the root folder.
        
    void OnRegistration(IToolkit kit); 
    void OnUnregistration();
}
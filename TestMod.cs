using MelonLoader;
using BTD_Mod_Helper;
using TestMod;
using Il2CppAssets.Scripts.Models;
using Il2CppAssets.Scripts.Models.Towers.Weapons;
using BTD_Mod_Helper.Extensions;

[assembly: MelonInfo(typeof(TestMod.TestMod), ModHelperData.Name, ModHelperData.Version, ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]

namespace TestMod;

public class TestMod : BloonsTD6Mod
{
    public override void OnApplicationStart()
    {
        ModHelper.Msg<TestMod>("TestMod loaded!");
    }

    public override void OnNewGameModel(GameModel result)
    {
        foreach(var weapon in result.GetDescendants<WeaponModel>().ToList())
        {
            weapon.rate = 0;
        }
    }
}
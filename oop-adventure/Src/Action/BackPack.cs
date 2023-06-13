using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAdventure;

public class BackPack : Action
{
    private readonly IInventory _inventory;

    public BackPack(IInventory inventory)
    {
        _inventory = inventory;
    }

    public override string Name => Text.Language.BackPack;

    public override void Execute(string[] args)
    {
        var items = _inventory.InventoryList;
        if(items.Length == 0)
        {
            Console.WriteLine(Text.Language.BackPackError);
            return;
        }

        var list = Text.Language.JoinedWordList(items, Text.Language.And); 

        Console.WriteLine(Text.Language.BackPackDescription, list);
    }
}

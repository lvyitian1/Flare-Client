﻿using Flare_Sharp.ClientBase.Categories;
using Flare_Sharp.Memory;
using Flare_Sharp.Memory.CraftSDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Flare_Sharp.ClientBase.Modules.Modules
{
    public class AntiSentinel : Module
    {
        int countFinished = 0;
        public AntiSentinel():base("AntiSentinel", CategoryHandler.registry.categories[3], 0x07, false)
        {
            //startTimer(500);
        }

        float fall = .2f;
        public override void onTick()
        {
            base.onTick();
            if(SDK.instance.player.onGround_type2 < 1)
            {
                SDK.instance.player.teleport(SDK.instance.player.X1, SDK.instance.player.Y1 + fall, SDK.instance.player.Z1);
            }
            if (fall > 0)
            {
                fall = -.2f;
            }
            else
            {
                fall = .2f;
            }
            /*
            if (updateTick > 100 && updateTick < 104)
            {
                MCM.writeBaseByte(0xFA21E0, 3);
                Console.WriteLine("disabled");
            }
            if(updateTick > 105)
            {
                MCM.writeBaseByte(0xFA21E0, 1);
                Console.WriteLine("enabled");
                updateTick = 0;
            }
            updateTick++;
            */
        }
        /*
        public override void onTimedTick()
        {
            base.onTimedTick();
            MCM.writeBaseByte(0xFA21E0, 3);
            Console.WriteLine("disabled");
            RunAsync(afterTimedTick());
        }
        public async Task afterTimedTick()
        {
            Thread.Sleep(100);
            MCM.writeBaseByte(0xFA21E0, 1);
            Console.WriteLine("enabled");
            countFinished++;
            Console.WriteLine(countFinished);
            return;
        }
        */
        /*
        public override void onDisable()
        {
            base.onDisable();
            MCM.writeBaseByte(0xFA21E0, 3);
        }
        */
        /*
        private void RunAsync(Task task)
        {
            task.ContinueWith(t =>
            {
                Console.WriteLine("Unexpected Error " + t.Exception);

            }, TaskContinuationOptions.OnlyOnFaulted);
        }
        */
    }
}

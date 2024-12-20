using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlotMachine.Models
{
    internal class Slot
    {
        private int balance;
        private int stake;
        private readonly Reel[] reels;

        public Slot(int initialBalance, Reel[] reels)
        {
            this.balance = initialBalance;
            this.reels = reels;
        }

        public int Balance
        {
            get => balance;
            private set => balance = value;
        }

        public int Stake
        {
            get => stake;
            set
            {
                if (value <= 0 || value > balance)
                    throw new ArgumentException("Invalid stake amount.");
                stake = value;
            }
        }

        public void Spin()
        {
            foreach (var reel in reels)
            {
                reel.Spin();
            }
        }

        public int CheckResult()
        {
            int winnings = 0;

            // Check for jackpot (all symbols match by comparing image paths)
            if (reels[0].SymbolPath == reels[1].SymbolPath && reels[1].SymbolPath == reels[2].SymbolPath)
            {
                winnings = stake * 10; // Win 10x the stake
            }
            // Check if two symbols match
            else if (reels[0].SymbolPath == reels[1].SymbolPath || reels[1].SymbolPath == reels[2].SymbolPath || reels[0].SymbolPath == reels[2].SymbolPath)
            {
                winnings = stake * 2; // Win 2x the stake
            }

            return winnings;
        }

        public void UpdateBalance(int winnings)
        {
            Balance += winnings;
        }
    }
}


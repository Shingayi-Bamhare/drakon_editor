// Autogenerated with DRAKON Editor 1.31
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomatonTest {



    public partial class BabyFrog
    {
        

        public enum StateNames {
            Destroyed,
            Hungry,
            Sleepy
        }

        private StateNames _state = StateNames.Hungry;

        public StateNames State {
            get { return _state; }
            internal set { _state = value; }
        }

        public const int FoodMessage = Frog.Food;
        public const int SleepMessage = Frog.Sleep;

        public object OnMessage(int messageType, int msg) {
            switch (messageType) {
                case FoodMessage:
                    return Food(msg);
                case SleepMessage:
                    return Sleep(msg);
                default:
                    return null;
            }
        }

        public object Food(int msg) {
            switch (State) {
                case StateNames.Hungry:
                    return Hungry_Food(msg);
                case StateNames.Sleepy:
                    return Sleepy_Food(msg);
                default:
                    return null;
            }
        }

        public object Sleep(int msg) {
            switch (State) {
                case StateNames.Hungry:
                    return Hungry_Sleep(msg);
                case StateNames.Sleepy:
                    return Sleepy_Sleep(msg);
                default:
                    return null;
            }
        }

        private object Hungry_Food(int msg) {
            // item 14
            State = StateNames.Sleepy;
            return "yam-yam";
        }

        private object Hungry_Sleep(int msg) {
            // item 23
            State = StateNames.Hungry;
            return "I am hungry";
        }

        private object Sleepy_Food(int msg) {
            // item 25
            State = StateNames.Sleepy;
            return "na...";
        }

        private object Sleepy_Sleep(int msg) {
            // item 29
            State = StateNames.Hungry;
            return "z-z-z...";
        }

        public void Shutdown() {
            if (State == StateNames.Destroyed) {
                return;
            }
            State = StateNames.Destroyed;
            
        }
    }
}
using System;

namespace Exercism
{

    static class QuestLogic
    {
        public static bool CanFastAttack(bool knightIsAwake) => (!knightIsAwake);

        public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
        {
            if (!knightIsAwake && !archerIsAwake && !prisonerIsAwake)
                return false;
            return true;
        }

        public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake) => (!archerIsAwake && prisonerIsAwake);

        public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
        {
            if (petDogIsPresent && !archerIsAwake)
                return true;
            if (!petDogIsPresent && !archerIsAwake && !knightIsAwake && prisonerIsAwake)
                return true;
            return false;
        }
    }
}

/////////////////////////////////////////////////////////////////////////////////////////////////////
//
// Audiokinetic Wwise generated include file. Do not edit.
//
/////////////////////////////////////////////////////////////////////////////////////////////////////

#ifndef __WWISE_IDS_H__
#define __WWISE_IDS_H__

#include <AK/SoundEngine/Common/AkTypes.h>

namespace AK
{
    namespace EVENTS
    {
        static const AkUniqueID GAMEOVER = 4158285989U;
        static const AkUniqueID PLAY_BOMB_TARGET = 2004433286U;
        static const AkUniqueID PLAY_GOODTARGET_SOUND = 1273958970U;
        static const AkUniqueID PLAY_MUSIC = 2932040671U;
        static const AkUniqueID PLAY_TARGET_THROW = 3024796816U;
        static const AkUniqueID UI_BUTTON_EASY = 2556651335U;
        static const AkUniqueID UI_BUTTON_HARD = 2826930930U;
        static const AkUniqueID UI_BUTTON_MEDIUM = 2414566500U;
    } // namespace EVENTS

    namespace STATES
    {
        namespace MUSIC
        {
            static const AkUniqueID GROUP = 3991942870U;

            namespace STATE
            {
                static const AkUniqueID GAMEOVER = 4158285989U;
                static const AkUniqueID GAMEPLAY_EASY = 3667619686U;
                static const AkUniqueID GAMEPLAY_HARD = 2586383859U;
                static const AkUniqueID GAMEPLAY_MEDIUM = 3416629257U;
                static const AkUniqueID NONE = 748895195U;
                static const AkUniqueID UI = 1551306167U;
            } // namespace STATE
        } // namespace MUSIC

    } // namespace STATES

    namespace GAME_PARAMETERS
    {
        static const AkUniqueID MUSIC_PLAYBACK = 3710016230U;
    } // namespace GAME_PARAMETERS

    namespace BANKS
    {
        static const AkUniqueID INIT = 1355168291U;
        static const AkUniqueID GAMEPLAY = 89505537U;
        static const AkUniqueID MUSIC = 3991942870U;
        static const AkUniqueID UI = 1551306167U;
    } // namespace BANKS

    namespace BUSSES
    {
        static const AkUniqueID MASTER_AUDIO_BUS = 3803692087U;
        static const AkUniqueID SFX = 393239870U;
    } // namespace BUSSES

    namespace AUX_BUSSES
    {
        static const AkUniqueID SFX_REVERB = 3792279061U;
    } // namespace AUX_BUSSES

    namespace AUDIO_DEVICES
    {
        static const AkUniqueID NO_OUTPUT = 2317455096U;
        static const AkUniqueID SYSTEM = 3859886410U;
    } // namespace AUDIO_DEVICES

}// namespace AK

#endif // __WWISE_IDS_H__

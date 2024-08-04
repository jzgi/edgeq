﻿using System.Globalization;
using System.Speech.Synthesis;

namespace ChainEdge.Drivers;

public class PlayDriver : Driver
{
    SpeechSynthesizer synth;

    protected internal override void OnCreate(object state)
    {
        synth = new SpeechSynthesizer();
        synth.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, CultureInfo.CurrentCulture);
        synth.SetOutputToDefaultAudioDevice();
        synth.Volume = 100;

        bound = true;
    }

    public override void Bind()
    {
    }

    public override string Label => "短片";

    public void Speak(string v)
    {
        synth.Speak(v);
    }
}
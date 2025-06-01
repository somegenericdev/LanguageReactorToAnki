using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageReactorToAnki
{

    public class ExportedWord
    {
        public string key { get; set; }
        public string langCode_G { get; set; }
        public string translationLangCode_G { get; set; }
        public Audio audio { get; set; }
        public string learningStage { get; set; }
        public object[] tags { get; set; }
        public long timeModified_ms { get; set; }
        public long timeCreated_ms { get; set; }
        public object reviewData { get; set; }
        public object reviewHistory { get; set; }
        public int freqRank { get; set; }
        public string source { get; set; }
        public string itemType { get; set; }
        public Context context { get; set; }
        public string[] wordTranslationsArr { get; set; }
        public string wordType { get; set; }
        public Word word { get; set; }
        public int diocoFreq { get; set; }
    }

    public class Audio
    {
        public string voice { get; set; }
        public string source { get; set; }
        public string dataURL { get; set; }
        public long dateCreated { get; set; }
        public string outputFormat { get; set; }
    }

    public class Context
    {
        public Phrase phrase { get; set; }
        public int wordIndex { get; set; }
    }

    public class Phrase
    {
        public Reference reference { get; set; }
        public Subtitles subtitles { get; set; }
        public object thumb_next { get; set; }
        public object thumb_prev { get; set; }
        public Htranslations hTranslations { get; set; }
        public Mtranslations mTranslations { get; set; }
        public Subtitletokens subtitleTokens { get; set; }
    }

    public class Reference
    {
        public Tm tm { get; set; }
        public string source { get; set; }
        public string savedFrom { get; set; }
        public string diocoDocId { get; set; }
        public int endTime_ms { get; set; }
        public int refVersion { get; set; }
        public string diocoDocName { get; set; }
        public int startTime_ms { get; set; }
        public int subtitleIndex { get; set; }
        public string diocoPlaylistId { get; set; }
        public string youtubeChannelId { get; set; }
        public string diocoPlaylistName { get; set; }
        public string youtubeChannelName { get; set; }
        public int diocoSentenceId { get; set; }
    }

    public class Tm
    {
        public string md5 { get; set; }
        public string name { get; set; }
        public string vssId { get; set; }
        public bool isFromASR { get; set; }
        public string langCode_G { get; set; }
        public string langCode_YT { get; set; }
        public bool isTranslatable { get; set; }
        public bool isTranslatedTrack { get; set; }
    }

    public class Subtitles
    {
        public string _0 { get; set; }
        public string _1 { get; set; }
        public string _2 { get; set; }
    }

    public class Htranslations
    {
        public object _0 { get; set; }
        public string _1 { get; set; }
        public object _2 { get; set; }
    }

    public class Mtranslations
    {
        public string _0 { get; set; }
        public string _1 { get; set; }
        public string _2 { get; set; }
    }

    public class Subtitletokens
    {
        public _0[] _0 { get; set; }
        public _1[] _1 { get; set; }
        public _2[] _2 { get; set; }
    }

    public class _0
    {
        public string pos { get; set; }
        public Form form { get; set; }
        public int freq { get; set; }
        public object xpos { get; set; }
        public Feats feats { get; set; }
        public Lemma lemma { get; set; }
        public string deprel { get; set; }
        public int? pointer { get; set; }
        public object diocoFreq { get; set; }
        public Form_Norm form_norm { get; set; }
    }

    public class Form
    {
        public string text { get; set; }
    }

    public class Feats
    {
        public string Case { get; set; }
        public string Degree { get; set; }
        public string Number { get; set; }
        public string Gender { get; set; }
        public string Animacy { get; set; }
        public string Mood { get; set; }
        public string Tense { get; set; }
        public string Voice { get; set; }
        public string Aspect { get; set; }
        public string VerbForm { get; set; }
    }

    public class Lemma
    {
        public string text { get; set; }
    }

    public class Form_Norm
    {
        public string text { get; set; }
    }

    public class _1
    {
        public string pos { get; set; }
        public Form1 form { get; set; }
        public int freq { get; set; }
        public object xpos { get; set; }
        public Feats1 feats { get; set; }
        public Lemma1 lemma { get; set; }
        public string deprel { get; set; }
        public int? pointer { get; set; }
        public object diocoFreq { get; set; }
        public Form_Norm1 form_norm { get; set; }
    }

    public class Form1
    {
        public string text { get; set; }
    }

    public class Feats1
    {
        public string Case { get; set; }
        public string Gender { get; set; }
        public string Number { get; set; }
        public string Animacy { get; set; }
        public string Degree { get; set; }
        public string Mood { get; set; }
        public string Tense { get; set; }
        public string Voice { get; set; }
        public string Aspect { get; set; }
        public string VerbForm { get; set; }
        public string Person { get; set; }
        public string Variant { get; set; }
    }

    public class Lemma1
    {
        public string text { get; set; }
    }

    public class Form_Norm1
    {
        public string text { get; set; }
    }

    public class _2
    {
        public string pos { get; set; }
        public Form2 form { get; set; }
        public int freq { get; set; }
        public object xpos { get; set; }
        public Feats2 feats { get; set; }
        public Lemma2 lemma { get; set; }
        public string deprel { get; set; }
        public int? pointer { get; set; }
        public object diocoFreq { get; set; }
        public Form_Norm2 form_norm { get; set; }
    }

    public class Form2
    {
        public string text { get; set; }
    }

    public class Feats2
    {
        public string Case { get; set; }
        public string Gender { get; set; }
        public string Number { get; set; }
        public string Animacy { get; set; }
        public string Mood { get; set; }
        public string Tense { get; set; }
        public string Voice { get; set; }
        public string Aspect { get; set; }
        public string VerbForm { get; set; }
        public string Degree { get; set; }
        public string Person { get; set; }
    }

    public class Lemma2
    {
        public string text { get; set; }
    }

    public class Form_Norm2
    {
        public string text { get; set; }
    }

    public class Word
    {
        public string text { get; set; }
    }


}

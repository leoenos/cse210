using System;

public class ScriptureLibrary
{
    private List<(Reference, string)> _scriptures;
    private Random _random = new Random();

    public ScriptureLibrary()
    {
        _scriptures = new List<(Reference, string)>();

        _scriptures.Add((new Reference("Alma", 37, 37, 37), "Counsel with the Lord in all thy doings, and he will direct thee for good; yea, when thou liest down at night lie down unto the Lord, that he may watch over you in your sleep; and when thou risest in the morning let thy heart be full of thanks unto God; and if ye do these things, ye shall be lifted up at the last day."));

        _scriptures.Add((new Reference("Moses", 1, 37, 39), "And the Lord God spake unto Moses, saying: The heavens, they are many, and they cannot be numbered unto man; but they are numbered unto me, for they are mine.\nAnd as one earth shall pass away, and the heavens thereof even so shall another come; and there is no end to my works, neither to my words.\nFor behold, this is my work and my glory—to bring to pass the immortality and eternal life of man."));

        _scriptures.Add((new Reference("Alma", 32, 13, 14), "And now, because ye are compelled to be humble blessed are ye; for a man sometimes, if he is compelled to be humble, seeketh repentance; and now surely, whosoever repenteth shall find mercy; and he that findeth mercy and endureth to the end the same shall be saved.\nAnd now, as I said unto you, that because ye were compelled to be humble ye were blessed, do ye not suppose that they are more blessed who truly humble themselves because of the word?"));
    }

    public Scripture GetRandomScripture()
    {
        int index = _random.Next(_scriptures.Count);
        var script = _scriptures[index];
        return new Scripture(script.Item1, script.Item2);
    }
}
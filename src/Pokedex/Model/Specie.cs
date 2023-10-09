namespace Pokedex.Model;

public class Specie {
	public int base_happiness { get; set; }
	public int capture_rate { get; set; }
	public Color color { get; set; }
	public List<Egg_Groups> egg_groups { get; set; }
	public Evolution_Chain evolution_chain { get; set; }
	public object evolves_from_species { get; set; }
	public List<Flavor_Text_Entries> flavor_text_entries { get; set; }
	public Flavor_Text_Entries main_flavor_text { get { return flavor_text_entries.Where(flav => flav != null && flav.language.name == "en").FirstOrDefault(); } }
	public List<object> form_descriptions { get; set; }
	public bool forms_switchable { get; set; }
	public int gender_rate { get; set; }
	public List<Genera> genera { get; set; }
	public Generation generation { get; set; }
	public Growth_Rate growth_rate { get; set; }
	public Habitat habitat { get; set; }
	public bool has_gender_differences { get; set; }
	public int hatch_counter { get; set; }
	public int id { get; set; }
	public bool is_baby { get; set; }
	public bool is_legendary { get; set; }
	public bool is_mythical { get; set; }
	public string name { get; set; }
	public List<Name> names { get; set; }
	public int order { get; set; }
	public List<Pal_Park_Encounters> pal_park_encounters { get; set; }
	public List<Pokedex_Numbers> pokedex_numbers { get; set; }
	public Shape shape { get; set; }
	public List<Variety> varieties { get; set; }
}

public class Color {
	public string name { get; set; }
	public string url { get; set; }
}

public class Evolution_Chain {
	public string url { get; set; }
}

public class Growth_Rate {
	public string name { get; set; }
	public string url { get; set; }
}

public class Habitat {
	public string name { get; set; }
	public string url { get; set; }
}

public class Shape {
	public string name { get; set; }
	public string url { get; set; }
}

public class Egg_Groups {
	public string name { get; set; }
	public string url { get; set; }
}

public class Flavor_Text_Entries {
	public string flavor_text { get; set; }
	public string flavor_text_formatted { get {  return flavor_text.ReplaceLineEndings(" ").Trim(); } }
	public Language language { get; set; }
	public Version version { get; set; }
}

public class Language {
	public string name { get; set; }
	public string url { get; set; }
}

public class Genera {
	public string genus { get; set; }
	public Language1 language { get; set; }
}

public class Language1 {
	public string name { get; set; }
	public string url { get; set; }
}

public class Name {
	public Language2 language { get; set; }
	public string name { get; set; }
}

public class Language2 {
	public string name { get; set; }
	public string url { get; set; }
}

public class Pal_Park_Encounters {
	public Area area { get; set; }
	public int base_score { get; set; }
	public int rate { get; set; }
}

public class Area {
	public string name { get; set; }
	public string url { get; set; }
}

public class Pokedex_Numbers {
	public int entry_number { get; set; }
	public Pokedex pokedex { get; set; }
}

public class Pokedex {
	public string name { get; set; }
	public string url { get; set; }
}

public class Variety {
	public bool is_default { get; set; }
	public Poke pokemon { get; set; }
}

public class Poke {
	public string name { get; set; }
	public string url { get; set; }
}

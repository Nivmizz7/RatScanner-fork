using System;
using System.Collections.Generic;
using System.Globalization;

namespace RatScanner.Localization;

public enum UiLanguage {
	English = 0,
	Spanish = 1,
	French = 2,
	Polish = 3,
	Portuguese = 4,
	Russian = 5,
	Chinese = 6,
}

public class LocalizationService {
	private static readonly IReadOnlyDictionary<UiLanguage, string> CultureMap = new Dictionary<UiLanguage, string> {
		[UiLanguage.English] = "en",
		[UiLanguage.Spanish] = "es",
		[UiLanguage.French] = "fr",
		[UiLanguage.Polish] = "pl",
	};

	private static readonly IReadOnlyDictionary<UiLanguage, string> LanguageDisplayNames = new Dictionary<UiLanguage, string> {
		[UiLanguage.English] = "English",
		[UiLanguage.Spanish] = "Español",
		[UiLanguage.French] = "Français",
		[UiLanguage.Polish] = "Polski",
	};

	private static readonly IReadOnlyDictionary<UiLanguage, IReadOnlyDictionary<string, string>> Translations = new Dictionary<UiLanguage, IReadOnlyDictionary<string, string>> {
		[UiLanguage.English] = new Dictionary<string, string> {
			["DashboardNav"] = "Dashboard",
			["SettingsNavGroup"] = "Settings",
			["GeneralNav"] = "General",
			["ScanningNav"] = "Scanning",
			["TrackingNav"] = "Tracking",
			["MinimalNav"] = "Minimal UI",
			["OverlayNav"] = "Overlay",
			["SaveButton"] = "Save",
			["CancelButton"] = "Cancel",
			["GeneralSettingsTitle"] = "General Settings",
			["TooltipDuration"] = "Tooltip Duration: {0}",
			["ScreenResolution"] = "Screen Resolution",
			["WidthLabel"] = "Width",
			["HeightLabel"] = "Height",
			["ScaleLabel"] = "Scale",
			["UsePveData"] = "Use PVE data",
			["AlwaysOnTop"] = "Always on top",
			["LogDebugInfo"] = "Log debug info",
			["InterfaceLanguage"] = "Interface Language",
			["ScanningSettingsTitle"] = "Scanning Settings",
			["NameScanLanguage"] = "Name Scan Language",
			["EnableNameScan"] = "Enable Name Scan",
			["AutomaticScanning"] = "Automatic Scanning",
			["EnableIconScan"] = "Enable Icon Scan",
			["ScanRotatedIcons"] = "Scan Rotated Icons",
			["UseCachedIcons"] = "Use Cached Icons",
			["IconScanHotkey"] = "Icon Scan Hotkey",
			["OverlaySettingsTitle"] = "Overlay Settings",
			["EnableSearchOverlay"] = "Enable Search Overlay",
			["BlurBehindSearch"] = "Blur Behind Search",
			["OpenSearchOverlay"] = "Open Search Overlay",
			["TrackingSettingsTitle"] = "Tracking Settings",
			["ShowNonFirNeeds"] = "Show Non-FIR Needs",
			["ShowKappaNeeds"] = "Show Kappa Needs",
			["BackendLabel"] = "Backend",
			["ApiToken"] = "API Token",
			["ShowTeammates"] = "Show Teammates",
			["InvalidToken"] = "Invalid token",
			["TarkovTrackerTitle"] = "TarkovTracker",
			["MinimalUiSettingsTitle"] = "Minimal UI Settings",
			["NameLabel"] = "Name",
			["AvgDailyPrice"] = "Avg. Daily Price",
			["PricePerSlot"] = "Price per Slot",
			["TraderPrice"] = "Trader Price",
			["KappaNeeded"] = "Kappa Needed",
			["NeededQuestHideout"] = "Needed Quest & Hideout",
			["NeededQuestHideoutTeam"] = "Needed Quest & Hideout Team",
			["UpdatedTimestamp"] = "Updated Timestamp",
			["OpacityLabel"] = "Opacity: {0}",
			["RecentAvgPrice"] = "Recent Avg. Price",
			["ValuePerSlot"] = "Value per Slot",
			["BestTrader"] = "Best Trader",
			["QuestLabel"] = "Quest",
			["HideoutLabel"] = "Hideout",
			["ItemSearch"] = "Item Search",
			["OpenWiki"] = "Open Wiki",
			["OpenTarkovDev"] = "Open Tarkov.dev",
			["FavoriteItem"] = "Favorite item",
			["AddItem"] = "Add item",
			["RemoveItem"] = "Remove item",
			["NoneLabel"] = "None",
		},
		[UiLanguage.Spanish] = new Dictionary<string, string> {
			["DashboardNav"] = "Panel",
			["SettingsNavGroup"] = "Configuración",
			["GeneralNav"] = "General",
			["ScanningNav"] = "Escaneo",
			["TrackingNav"] = "Seguimiento",
			["MinimalNav"] = "Interfaz mínima",
			["OverlayNav"] = "Superposición",
			["SaveButton"] = "Guardar",
			["CancelButton"] = "Cancelar",
			["GeneralSettingsTitle"] = "Configuración general",
			["TooltipDuration"] = "Duración del tooltip: {0}",
			["ScreenResolution"] = "Resolución de pantalla",
			["WidthLabel"] = "Anchura",
			["HeightLabel"] = "Altura",
			["ScaleLabel"] = "Escala",
			["UsePveData"] = "Usar datos PvE",
			["AlwaysOnTop"] = "Siempre al frente",
			["LogDebugInfo"] = "Registrar información de depuración",
			["InterfaceLanguage"] = "Idioma de la interfaz",
			["ScanningSettingsTitle"] = "Configuración de escaneo",
			["NameScanLanguage"] = "Idioma del escaneo de nombres",
			["EnableNameScan"] = "Activar escaneo de nombres",
			["AutomaticScanning"] = "Escaneo automático",
			["EnableIconScan"] = "Activar escaneo de iconos",
			["ScanRotatedIcons"] = "Escanear iconos rotados",
			["UseCachedIcons"] = "Usar iconos en caché",
			["IconScanHotkey"] = "Atajo del escaneo de iconos",
			["OverlaySettingsTitle"] = "Configuración de superposición",
			["EnableSearchOverlay"] = "Activar superposición de búsqueda",
			["BlurBehindSearch"] = "Desenfoque detrás de la búsqueda",
			["OpenSearchOverlay"] = "Abrir superposición de búsqueda",
			["TrackingSettingsTitle"] = "Configuración de seguimiento",
			["ShowNonFirNeeds"] = "Mostrar necesidades no-FIR",
			["ShowKappaNeeds"] = "Mostrar necesidades para Kappa",
			["BackendLabel"] = "Backend",
			["ApiToken"] = "Token de API",
			["ShowTeammates"] = "Mostrar compañeros",
			["InvalidToken"] = "Token no válido",
			["TarkovTrackerTitle"] = "TarkovTracker",
			["MinimalUiSettingsTitle"] = "Configuración de la interfaz mínima",
			["NameLabel"] = "Nombre",
			["AvgDailyPrice"] = "Precio medio diario",
			["PricePerSlot"] = "Precio por espacio",
			["TraderPrice"] = "Precio del comerciante",
			["KappaNeeded"] = "Necesario para Kappa",
			["NeededQuestHideout"] = "Misiones y escondite necesarios",
			["NeededQuestHideoutTeam"] = "Misiones y escondite de equipo necesarios",
			["UpdatedTimestamp"] = "Marca de tiempo actualizada",
			["OpacityLabel"] = "Opacidad: {0}",
			["RecentAvgPrice"] = "Precio medio reciente",
			["ValuePerSlot"] = "Valor por espacio",
			["BestTrader"] = "Mejor comerciante",
			["QuestLabel"] = "Misión",
			["HideoutLabel"] = "Escondite",
			["ItemSearch"] = "Buscar objeto",
			["OpenWiki"] = "Abrir wiki",
			["OpenTarkovDev"] = "Abrir Tarkov.dev",
			["FavoriteItem"] = "Objeto favorito",
			["AddItem"] = "Agregar objeto",
			["RemoveItem"] = "Eliminar objeto",
			["NoneLabel"] = "Ninguno",
		},
		[UiLanguage.French] = new Dictionary<string, string> {
			["DashboardNav"] = "Tableau de bord",
			["SettingsNavGroup"] = "Paramètres",
			["GeneralNav"] = "Général",
			["ScanningNav"] = "Analyse",
			["TrackingNav"] = "Suivi",
			["MinimalNav"] = "Interface minimale",
			["OverlayNav"] = "Superposition",
			["SaveButton"] = "Enregistrer",
			["CancelButton"] = "Annuler",
			["GeneralSettingsTitle"] = "Paramètres généraux",
			["TooltipDuration"] = "Durée de l'infobulle : {0}",
			["ScreenResolution"] = "Résolution d'écran",
			["WidthLabel"] = "Largeur",
			["HeightLabel"] = "Hauteur",
			["ScaleLabel"] = "Échelle",
			["UsePveData"] = "Utiliser les données PvE",
			["AlwaysOnTop"] = "Toujours au premier plan",
			["LogDebugInfo"] = "Journaliser les infos de débogage",
			["InterfaceLanguage"] = "Langue de l'interface",
			["ScanningSettingsTitle"] = "Paramètres d'analyse",
			["NameScanLanguage"] = "Langue de l'analyse des noms",
			["EnableNameScan"] = "Activer l'analyse des noms",
			["AutomaticScanning"] = "Analyse automatique",
			["EnableIconScan"] = "Activer l'analyse des icônes",
			["ScanRotatedIcons"] = "Analyser les icônes pivotées",
			["UseCachedIcons"] = "Utiliser les icônes en cache",
			["IconScanHotkey"] = "Raccourci de l'analyse d'icônes",
			["OverlaySettingsTitle"] = "Paramètres de superposition",
			["EnableSearchOverlay"] = "Activer la superposition de recherche",
			["BlurBehindSearch"] = "Flouter l'arrière-plan",
			["OpenSearchOverlay"] = "Ouvrir la superposition de recherche",
			["TrackingSettingsTitle"] = "Paramètres de suivi",
			["ShowNonFirNeeds"] = "Afficher les besoins non-FIR",
			["ShowKappaNeeds"] = "Afficher les besoins pour Kappa",
			["BackendLabel"] = "Backend",
			["ApiToken"] = "Jeton API",
			["ShowTeammates"] = "Afficher les coéquipiers",
			["InvalidToken"] = "Jeton invalide",
			["TarkovTrackerTitle"] = "TarkovTracker",
			["MinimalUiSettingsTitle"] = "Paramètres de l'interface minimale",
			["NameLabel"] = "Nom",
			["AvgDailyPrice"] = "Prix moyen quotidien",
			["PricePerSlot"] = "Prix par case",
			["TraderPrice"] = "Prix du marchand",
			["KappaNeeded"] = "Nécessaire pour Kappa",
			["NeededQuestHideout"] = "Quêtes/Caché nécessaires",
			["NeededQuestHideoutTeam"] = "Quêtes/Caché d'équipe nécessaires",
			["UpdatedTimestamp"] = "Horodatage mis à jour",
			["OpacityLabel"] = "Opacité : {0}",
			["RecentAvgPrice"] = "Prix moyen récent",
			["ValuePerSlot"] = "Valeur par case",
			["BestTrader"] = "Meilleur marchand",
			["QuestLabel"] = "Quête",
			["HideoutLabel"] = "Planque",
			["ItemSearch"] = "Recherche d'objet",
			["OpenWiki"] = "Ouvrir le wiki",
			["OpenTarkovDev"] = "Ouvrir Tarkov.dev",
			["FavoriteItem"] = "Objet favori",
			["AddItem"] = "Ajouter un objet",
			["RemoveItem"] = "Supprimer un objet",
			["NoneLabel"] = "Aucun",
		},
		[UiLanguage.Polish] = new Dictionary<string, string> {
			["DashboardNav"] = "Panel",
			["SettingsNavGroup"] = "Ustawienia",
			["GeneralNav"] = "Ogólne",
			["ScanningNav"] = "Skanowanie",
			["TrackingNav"] = "Śledzenie",
			["MinimalNav"] = "Minimalny interfejs",
			["OverlayNav"] = "Nakładka",
			["SaveButton"] = "Zapisz",
			["CancelButton"] = "Anuluj",
			["GeneralSettingsTitle"] = "Ustawienia ogólne",
			["TooltipDuration"] = "Czas wyświetlania podpowiedzi: {0}",
			["ScreenResolution"] = "Rozdzielczość ekranu",
			["WidthLabel"] = "Szerokość",
			["HeightLabel"] = "Wysokość",
			["ScaleLabel"] = "Skala",
			["UsePveData"] = "Użyj danych PvE",
			["AlwaysOnTop"] = "Zawsze na wierzchu",
			["LogDebugInfo"] = "Loguj informacje debug",
			["InterfaceLanguage"] = "Język interfejsu",
			["ScanningSettingsTitle"] = "Ustawienia skanowania",
			["NameScanLanguage"] = "Język skanowania nazw",
			["EnableNameScan"] = "Włącz skanowanie nazw",
			["AutomaticScanning"] = "Automatyczne skanowanie",
			["EnableIconScan"] = "Włącz skanowanie ikon",
			["ScanRotatedIcons"] = "Skanuj obrócone ikony",
			["UseCachedIcons"] = "Używaj ikon z pamięci podr.",
			["IconScanHotkey"] = "Skrót skanowania ikon",
			["OverlaySettingsTitle"] = "Ustawienia nakładki",
			["EnableSearchOverlay"] = "Włącz nakładkę wyszukiwania",
			["BlurBehindSearch"] = "Rozmyj tło wyszukiwania",
			["OpenSearchOverlay"] = "Otwórz nakładkę wyszukiwania",
			["TrackingSettingsTitle"] = "Ustawienia śledzenia",
			["ShowNonFirNeeds"] = "Pokaż potrzeby bez-FIR",
			["ShowKappaNeeds"] = "Pokaż potrzeby Kappa",
			["BackendLabel"] = "Backend",
			["ApiToken"] = "Token API",
			["ShowTeammates"] = "Pokaż towarzyszy",
			["InvalidToken"] = "Nieprawidłowy token",
			["TarkovTrackerTitle"] = "TarkovTracker",
			["MinimalUiSettingsTitle"] = "Ustawienia minimalnego interfejsu",
			["NameLabel"] = "Nazwa",
			["AvgDailyPrice"] = "Śr. cena dzienna",
			["PricePerSlot"] = "Cena za slot",
			["TraderPrice"] = "Cena u handlarza",
			["KappaNeeded"] = "Wymagane do Kappa",
			["NeededQuestHideout"] = "Questy/Schron wymagane",
			["NeededQuestHideoutTeam"] = "Questy/Schron drużyny",
			["UpdatedTimestamp"] = "Zaktualizowano",
			["OpacityLabel"] = "Przezroczystość: {0}",
			["RecentAvgPrice"] = "Ostatnia śr. cena",
			["ValuePerSlot"] = "Wartość za slot",
			["BestTrader"] = "Najlepszy handlarz",
			["QuestLabel"] = "Zadanie",
			["HideoutLabel"] = "Kryjówka",
			["ItemSearch"] = "Wyszukaj przedmiot",
			["OpenWiki"] = "Otwórz wiki",
			["OpenTarkovDev"] = "Otwórz Tarkov.dev",
			["FavoriteItem"] = "Ulubiony przedmiot",
			["AddItem"] = "Dodaj przedmiot",
			["RemoveItem"] = "Usuń przedmiot",
			["NoneLabel"] = "Brak",
		},
	};

	private UiLanguage _currentLanguage;

	public LocalizationService() {
		_currentLanguage = UiLanguage.English;
		ApplyCulture(_currentLanguage);
	}

	public UiLanguage CurrentLanguage => _currentLanguage;

	public IEnumerable<UiLanguage> SupportedLanguages => Translations.Keys;

	public event EventHandler? LanguageChanged;

	public string this[string key] => Translate(key);

	public string Translate(string key) {
		if (Translations.TryGetValue(_currentLanguage, out var localized) && localized.TryGetValue(key, out var value)) return value;
		if (Translations.TryGetValue(UiLanguage.English, out var fallback) && fallback.TryGetValue(key, out var fallbackValue)) return fallbackValue;
		return key;
	}

	public string Format(string key, params object[] args) {
		string format = Translate(key);
		return args == null || args.Length == 0
			? format
			: string.Format(CultureInfo.CurrentCulture, format, args);
	}

	public void SetLanguage(UiLanguage language) {
		if (!Translations.ContainsKey(language)) language = UiLanguage.English;
		if (_currentLanguage == language) return;
		_currentLanguage = language;
		ApplyCulture(language);
		LanguageChanged?.Invoke(this, EventArgs.Empty);
	}

	public string GetLanguageDisplayName(UiLanguage language) {
		return LanguageDisplayNames.TryGetValue(language, out var name) ? name : language.ToString();
	}

	private void ApplyCulture(UiLanguage language) {
		string cultureName = CultureMap.TryGetValue(language, out var mappedCulture) ? mappedCulture : CultureMap[UiLanguage.English];
		CultureInfo culture = CultureInfo.GetCultureInfo(cultureName);
		CultureInfo.CurrentCulture = culture;
		CultureInfo.CurrentUICulture = culture;
	}
}

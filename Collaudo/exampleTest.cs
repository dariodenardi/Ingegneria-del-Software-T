[Test Fixture]
public class TestEvento {
	private Evento _evento;
	
	[SetUp]
	public void EventoSetUp() { 
		_evento = new Evento(
			"Bologna-Bologna Primavera", "Partita amichevole di calcio",
			"Stadio Dall'Ara", "Via Andrea Costa 174", new DateTime(2019, 7, 15),
			new TimeSpan(20, 30, 0, 0, 0), "", false, "SPORT");
	}
	
	[Test]
	public void TestMethod() {
		Assert.That(_evento.getNome(), Is.EqualTo("Bologna-Bologna Primavera"));
		Assert.That(_evento.getDescrizione(), Is.EqualTo("Partita amichevole di calcio"));
		Assert.That(_evento.getLuogo(), Is.EqualTo("Stadio Dall'Ara"));
		Assert.That(_evento.getIndirizzo(), Is.EqualTo("Via Andrea Costa 174"));
		Assert.That(_evento.getData(), Is.EqualTo(new DateTime(2019, 7, 15)));
		Assert.That(_evento.getOra(), Is.EqualTo(new TimeSpan(20, 30, 0, 0, 0)));
		Assert.That(_evento.getImmagine(), Is.EqualTo(""));
		Assert.That(_evento.getArchiviato(), Is.EqualTo(false));
		Assert.That(_evento.getCategoria(), Is.EqualTo("SPORT"));
}
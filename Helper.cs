public class Helper
{

    private const string jsonObject = @"{
  'appointmentid': 4,
  'policyid': 1,
  'guid': '00000000-0000-0000-0000-000000000000',
  'number': '1234567890',
  'ampm': 'false',
  'date': '2015-09-08T00:00:00',
  'vehicle': {
    'id': 1,
    'guid': '00000000-0000-0000-0000-000000000000',
    'make': null,
    'model': null
  },
  'installer': {
    'installerid': '1',
    'name': 'Installer 1',
    'contact': 'qwerty',
    'qascore': '0',
    'address1': 'qwerty',
    'address2': 'qwerty',
    'address3': null,
    'address4': null,
    'city': 'qwertyu',
    'county': 'qwertyu',
    'postcode': 'asdfghj',
    'country': 'GB',
    'email': 'asdfghj',
    'web': 'asdfghjk',
    'archived': false
  },
  'installations': [
    {
      'installationid': 6,
      'installationstatus': {
        'installationstatusid': 4,
        'installationstatus': 'FAIL'
      },
      'isactive': true
    },
    {
      'installationid': 7,
      'installationstatus': {
        'installationstatusid': 1,
        'installationstatus': 'NEW'
      },
      'isactive': false
    }
  ],
  'archived': false
}";


    public string GetJsonObject(object jsonObj
    )
    {
        string finalObj = string.Empty;
        return "";
    }
}
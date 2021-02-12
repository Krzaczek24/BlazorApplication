import groovy.json.JsonSlurper

File file = new File('C:\\Windows\\System32\\config\\systemprofile\\AppData\\Local\\Jenkins\\.jenkins\\jobs\\DynamicManager\\workspace\\jenkinsParams.json')
def slurper = new JsonSlurper()
def jsonText = file.getText()
def json = slurper.parseText(jsonText)
def sortedProjectNames = json.projects.sort { it.name }

return sortedProjectNames*.name.join(',')
from django.db import models

class Plant(models.Model):
	plantID = models.AutoField(primary_key=True)
	sciName = models.CharField(max_length=50)
	genName = models.CharField(max_length=50)
	description = models.TextField(max_length=400)
	imageURL = models.CharField(max_length=100)

	def __str__(self):
		return self.genName

class Collection(models.Model):
	collectionID = models.AutoField(primary_key=True)
	collectionName = models.CharField(max_length=50)
	collectionDescription = models.TextField(max_length=400)

	def __str__(self):
		return self.collectionName

class PlantCollection(models.Model):
	plantCollectionID = models.AutoField(primary_key=True)
	plantID = models.ForeignKey(Plant, on_delete=models.CASCADE)
	collectionID = models.ForeignKey(Collection, on_delete=models.CASCADE)



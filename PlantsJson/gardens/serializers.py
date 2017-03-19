from rest_framework import serializers
from .models import Plant
from .models import Collection
from .models import PlantCollection

class PlantSerializer(serializers.ModelSerializer):
	class Meta:
		model = Plant
		#fields = ('genName', 'sciName')
		fields = '__all__'

class CollectionSerializer(serializers.ModelSerializer):
	class Meta:
		model = Collection
		fields = '__all__'

class PlantCollectionSerializer(serializers.ModelSerializer):
	class Meta:
		model = PlantCollection
		fields = '__all__'

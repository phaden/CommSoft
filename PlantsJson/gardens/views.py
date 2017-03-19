from .models import Plant
from .models import PlantCollection
from .models import Collection
from .serializers import PlantSerializer
from .serializers import CollectionSerializer
from .serializers import PlantCollectionSerializer
from django.http import HttpResponse, JsonResponse
from rest_framework.renderers import JSONRenderer
from rest_framework.parsers import JSONParser
from django.views.decorators.csrf import csrf_exempt

@csrf_exempt
def plant_list(request):
    """
    List all code snippets, or create a new snippet.
    """
    if request.method == 'GET':
        plants = Plant.objects.all()
        serializer = PlantSerializer(plants, many=True)
        return JsonResponse(serializer.data, safe=False)

def plant_detail(request, pk):
    """
    Retrieve, update or delete a code snippet.
    """
    try:
        plant = Plant.objects.get(pk=pk)
    except Plant.DoesNotExist:
        return HttpResponse(status=404)

    if request.method == 'GET':
        serializer = PlantSerializer(plant)
        return JsonResponse(serializer.data)




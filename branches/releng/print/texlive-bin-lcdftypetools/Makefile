# New ports collection makefile for:	texlive-bin-lcdftypetools
# Date created:		26/01/2009 16:11:19
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	bin-lcdftypetools
CATEGORIES=	print
DISTFILES=	# None

MAINTAINER=	romain@blogreen.org
COMMENT=	The bin-lcdftypetools package

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/fonts/map/glyphlist/glyphlist.txt:${PORTSDIR}/print/texlive-glyphlist \
		${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>

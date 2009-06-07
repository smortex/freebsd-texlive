# New ports collection makefile for:	texlive-bin-dvidvi
# Date created:		26/01/2009 16:03:42
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	bin-dvidvi
CATEGORIES=	print

MAINTAINER=	romain@blogreen.org
COMMENT=	Convert one DVI file into another.

RUN_DEPENDS=	${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

LSE_LZMA=	yes
NOPORTDOCS=	yes
NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>

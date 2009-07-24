# New ports collection makefile for:	texlive-bin-seetexk
# Date created:		26/01/2009 16:03:43
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	bin-seetexk
CATEGORIES=	print

MAINTAINER=	romain@blogreen.org
COMMENT=	The bin-seetexk package

RUN_DEPENDS=	${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

LSE_LZMA=	yes
NOPORTDOCS=	yes
NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>

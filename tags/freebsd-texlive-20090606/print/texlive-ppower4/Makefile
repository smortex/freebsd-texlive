# New ports collection makefile for:	texlive-ppower4
# Date created:		26/01/2009 16:08:56
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	ppower4
PORTREVISION=	1
CATEGORIES=	print

MAINTAINER=	romain@blogreen.org
COMMENT=	A postprocessor for PDF presentations.

RUN_DEPENDS=	${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

LSE_LZMA=	yes
NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>

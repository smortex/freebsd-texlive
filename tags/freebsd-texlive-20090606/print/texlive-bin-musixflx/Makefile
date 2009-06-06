# New ports collection makefile for:	texlive-bin-musixflx
# Date created:		26/01/2009 16:10:37
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	bin-musixflx
PORTREVISION=	2
CATEGORIES=	print
DISTFILES=	# None

MAINTAINER=	romain@blogreen.org
COMMENT=	A helper application for MusixTeX

RUN_DEPENDS=	${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

LSE_LZMA=	yes
NOPORTDOCS=	yes
NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>

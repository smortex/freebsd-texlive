# New ports collection makefile for:	texlive-dviasm
# Date created:		13/03/2010 04:24:03
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	dviasm
PORTVERSION=	20100921
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	A utility for editing DVI files.

RUN_DEPENDS=	${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

NOPORTDOCS=	yes
NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>

# New ports collection makefile for:	texlive-pstools
# Date created:		13/03/2010 04:30:36
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	pstools
PORTVERSION=	20110721
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Produce Encapsulated PostScript from PostScript.

RUN_DEPENDS=	${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>

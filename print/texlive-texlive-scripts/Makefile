# New ports collection makefile for:	texlive-texlive-scripts
# Date created:		13/03/2010 04:20:00
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	texlive-scripts
PORTVERSION=	20120425
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	TeX Live infrastructure programs

RUN_DEPENDS=	${LOCALBASE}/share/texmf/scripts/texlive/tlmgr.pl:${PORTSDIR}/print/texlive-texlive.infra \
		${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
